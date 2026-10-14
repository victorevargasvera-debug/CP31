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
using ControlHeadGraphicView;
using Infragistics.Windows.DataPresenter;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO3
{
	// Token: 0x020003B9 RID: 953
	public class PageControlHeadO3 : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x0600897D RID: 35197 RVA: 0x00808C1C File Offset: 0x00806E1C
		public PageControlHeadO3()
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

		// Token: 0x0600897E RID: 35198 RVA: 0x00808C54 File Offset: 0x00806E54
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1578500096;
			short num2 = num;
			num = (short)1726873600;
			int num3 = (int)num;
			switch (num3)
			{
			default:
				num = (short)1126039555;
				num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					object obj;
					global::AcpUI.AcpExpander acpExpander;
					global::System.Collections.IEnumerator enumerator;
					switch (num3)
					{
					case 0:
						num = (short)2054815745;
						if (num != 0)
						{
						}
						if (obj != null)
						{
							num = (short)802816009;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_456;
					case 1:
					{
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderControlHeadO3O3HHCHButton.MyDataPresenter = this.ExpanderControlHeadO3O3HHCHButton;
						num = (short)1027276802;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_3E9;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_A3;
						}
						continue;
					case 4:
						goto IL_456;
					case 5:
						if (obj != null)
						{
							num = (short)1657208839;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_355;
					case 6:
						if (obj != null)
						{
							num = (short)1391591425;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E9;
					case 7:
						goto IL_296;
					case 8:
						goto IL_3AD;
					case 9:
					{
						global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderControlHeadO3DataButton.MyDataPresenter = this.ExpanderControlHeadO3DataButton;
						num = (short)669450244;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						obj = null;
						obj = this.RecNavToolbarExpanderControlHeadO3O3HHCHButton.MyRecordsetDataSource;
						num = (short)179240966;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						try
						{
							num = (short)444334084;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									goto IL_1CE;
								case 2:
									num = (short)324599808;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									base.Expanders.Add(acpExpander);
									num = (short)668073985;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_10A;
									}
									continue;
								case 5:
									if (acpExpander != null)
									{
										num = (short)2047803395;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 6:
									if (!enumerator.MoveNext())
									{
										num = (short)1222639618;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
									num = (short)1544290309;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_10C:
								num = (short)961216518;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_10A:
								goto IL_10C;
							}
							IL_1CE:
							goto IL_386;
						}
						finally
						{
							for (;;)
							{
								IL_1D3:
								switch (0)
								{
								case 0:
									goto IL_1F0;
								}
								global::System.IDisposable disposable;
								for (;;)
								{
									IL_1DD:
									switch (num3)
									{
									case 0:
										goto IL_293;
									case 1:
										disposable.Dispose();
										num = (short)1684668416;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
									{
										num = (short)1275975610;
										short num4 = num;
										num = (short)203151290;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_1D3;
										default:
											num = (short)1925185536;
											if (num != 0)
											{
											}
											if (disposable != null)
											{
												num = (short)78512129;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_295;
										}
										break;
									}
									}
									break;
								}
								IL_1F0:
								disposable = (enumerator as global::System.IDisposable);
								num = (short)1222311938;
								num3 = (int)((global::System.IntPtr)num);
								goto IL_1DD;
							}
							IL_293:
							IL_295:;
						}
						goto IL_296;
						IL_386:
						base.OnLoaded(sender, e);
						this.a = true;
						num = (short)285999112;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_355;
					}
					IL_A3:
					if (!this.a)
					{
						num = (short)2085552138;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_296:
					global::System.Windows.Data.CollectionView collectionView3 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
					this.RecNavToolbarExpanderControlHeadO3O3NavigationControlsTable.MyDataPresenter = this.ExpanderControlHeadO3O3NavigationControlsTable;
					num = (short)1199243276;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_355:
					acpExpander = null;
					enumerator = this.MyStackPanel.Children.GetEnumerator();
					num = (short)1033830411;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_3E9:
					obj = this.RecNavToolbarExpanderControlHeadO3DataButton.MyRecordsetDataSource;
					num = (short)673972224;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_456:
					obj = this.RecNavToolbarExpanderControlHeadO3O3NavigationControlsTable.MyRecordsetDataSource;
					num = (short)411303941;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_3AD:
				this.MyStackPanel.Children[0].Focus();
				return;
			}
		}

		// Token: 0x0600897F RID: 35199 RVA: 0x00809134 File Offset: 0x00807334
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num2;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_10E;
					case 1:
						base.OnUnloaded(sender, e);
						this.a = false;
						num2 = (short)566362112;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
					{
						num2 = (short)2022217164;
						short num3 = num2;
						num2 = (short)829068748;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)1061158912;
							if (num2 != 0)
							{
							}
							if (this.a)
							{
								num2 = (short)1722810369;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_137;
						}
						break;
					}
					}
					break;
				}
				IL_1C:
				this.RecNavToolbarExpanderControlHeadO3O3HHCHButton.DataContext = null;
				this.RecNavToolbarExpanderControlHeadO3DataButton.DataContext = null;
				this.RecNavToolbarExpanderControlHeadO3O3NavigationControlsTable.DataContext = null;
				this.RecNavToolbarExpanderControlHeadO3O3HHCHButton.MyDataPresenter = null;
				this.RecNavToolbarExpanderControlHeadO3DataButton.MyDataPresenter = null;
				this.RecNavToolbarExpanderControlHeadO3O3NavigationControlsTable.MyDataPresenter = null;
				num2 = (short)1049886722;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_10E:
			num2 = (short)795541505;
			if (num2 != 0)
			{
			}
			IL_137:
			num2 = (short)2073427968;
			short num4 = num2;
		}

		// Token: 0x06008980 RID: 35200 RVA: 0x008092A0 File Offset: 0x008074A0
		public override void SetDataContext()
		{
			short num = (short)1078919174;
			int num2 = (int)((global::System.IntPtr)num);
			object feature;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)189661207;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_263;
				case 2:
					goto IL_F7;
				case 3:
					num = (short)1678049301;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)319356959;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_650;
				case 5:
					num = (short)624099348;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_A8;
					}
					continue;
				case 7:
					return;
				case 8:
					goto IL_263;
				case 9:
					num = (short)1226178579;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2127);
					num = (short)1520435211;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (feature != null)
					{
						num = (short)1683423264;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_650;
				case 12:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO3O3HHCHButton).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10235].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO3O3HHCHButton).SyncDataSources();
					num = (short)1204551705;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					if (feature != null)
					{
						num = (short)504168475;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F7;
				case 14:
					num = (short)1011023902;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
				{
					num = (short)1592983552;
					short num3 = num;
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)1682243598;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F7;
				}
				case 16:
					num = (short)1229520914;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2127);
					num = (short)1956446216;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10732].EmbeddedRecset != null)
					{
						num = (short)677314586;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 19:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)1656160259;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 20:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10235].EmbeddedRecset != null)
					{
						num = (short)1945829388;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_650;
				case 21:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10732] != null)
					{
						goto IL_247;
					}
					return;
				case 22:
					if (feature != null)
					{
						num = (short)1396768777;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 23:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10234].EmbeddedRecset != null)
					{
						num = (short)258867229;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F7;
				case 24:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)1325465610;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO3O3HHCHButton).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO3DataButton).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO3O3NavigationControlsTable).MySecondaryRecordsetDataSource = null;
					num = (short)1121714183;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					goto IL_650;
				case 26:
					goto IL_426;
				case 27:
					num = (short)109182991;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 28:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10235] != null)
					{
						num = (short)1136328709;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_650;
				case 29:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO3DataButton).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10234].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO3DataButton).SyncDataSources();
					num = (short)1774583810;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 30:
				{
					num = (short)1732441179;
					short num4 = num;
					num = (short)234615899;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_247;
					default:
						num = (short)1145503744;
						if (num != 0)
						{
						}
						if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10234] != null)
						{
							num = (short)170524672;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F7;
					}
					break;
				}
				case 31:
					num = (short)827654172;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 32:
					num = (short)1594032132;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_A8:
				num = (short)1217724417;
				if (num != 0)
				{
				}
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)1744044049;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2127);
				num = (short)1688010753;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_F7:
				num = (short)280690710;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_247:
				num = (short)985530384;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_263:
				num = (short)1759117336;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_650:
				num = (short)1537605645;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_426:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO3O3NavigationControlsTable).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10732].EmbeddedRecset;
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO3O3NavigationControlsTable).SyncDataSources();
		}

		// Token: 0x06008981 RID: 35201 RVA: 0x00809938 File Offset: 0x00807B38
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 0;
			short num = (short)1392705536;
			switch (num)
			{
			default:
			{
				num = (short)1367080961;
				if (num != 0)
				{
				}
				num = (short)398196756;
				int num2 = (int)((global::System.IntPtr)num);
				object myRecordsetDataSource3;
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)254798337;
						short num3 = num;
						num = (short)1148512769;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_28B;
						default:
							num = (short)1326710784;
							if (num != 0)
							{
							}
							if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
							{
								num = (short)696778766;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
							num = (short)1954414613;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						goto IL_101;
					case 2:
						goto IL_28B;
					case 3:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource = this.RecNavToolbarExpanderControlHeadO3O3HHCHButton.MyRecordsetDataSource;
						num = (short)403374103;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						num = (short)1291517952;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)1750466577;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_101;
					case 7:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("鏀ꛂꛄ视꣈뷊駌ꃎ뻐뿒럔뛖ꯘ黚ꗜ꿞胠跢臤苦鯨꣪苬臮藰臲髴鯶뇸黺鳼鯾一。䨄㐆䄈䌊丌䜎匐昒愔挖瘘甚", a_))
						{
							num = (short)83623945;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4D1;
					case 8:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("鏀ꛂꛄ视꣈뷊駌ꃎ뻐뿒럔뛖ꯘ黚ꗜ꿞胠跢臤苦鯨꣪苬臮藰臲髴鯶뇸黺鳼鯾一。䨄㐆䜈樊笌明瘐爒愔縖瘘甚帜瀞传圢圤䠦䔨堪礬丮匰弲倴", a_))
						{
							num = (short)2025259012;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 9:
					{
						num = (short)1931149312;
						short num4 = num;
						num = (short)193003522;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_4D1;
					case 11:
						goto IL_244;
					case 12:
					{
						object myRecordsetDataSource2;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource2);
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInner item = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInner)collectionView.CurrentItem;
						collectionView.MoveCurrentTo(item);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)2053373953;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("鏀ꛂꛄ视꣈뷊駌ꃎ뻐뿒럔뛖ꯘ黚ꗜ꿞胠跢臤苦鯨꣪苬臮藰臲髴鯶뇸黺鳼鯾一。䄄昆紈樊伌税攐朒稔礖", a_))
						{
							num = (short)1556348933;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_101;
					case 14:
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						myRecordsetDataSource3 = this.RecNavToolbarExpanderControlHeadO3O3NavigationControlsTable.MyRecordsetDataSource;
						num = (short)697303062;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						num = (short)1894711303;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						object myRecordsetDataSource;
						global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInner item2 = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInner)collectionView2.CurrentItem;
						collectionView2.MoveCurrentTo(item2);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)733610002;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)864419864;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)1435041798;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						goto IL_4D1;
					case 19:
					{
						object myRecordsetDataSource2;
						if (myRecordsetDataSource2 != null)
						{
							num = (short)658898956;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_101;
					}
					case 20:
						switch (0)
						{
						case 0:
							goto IL_D8;
						}
						continue;
					case 21:
						return;
					case 22:
						if (myRecordsetDataSource3 != null)
						{
							num = (short)1231290379;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 23:
					{
						object myRecordsetDataSource;
						if (myRecordsetDataSource != null)
						{
							num = (short)2096824336;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4D1;
					}
					case 24:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource2 = this.RecNavToolbarExpanderControlHeadO3DataButton.MyRecordsetDataSource;
						num = (short)16777235;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_D8:
					if (A_0 is global::AcpUI.AcpRecNavToolbar)
					{
						num = (short)498925583;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_101:
					num = (short)1784807432;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_28B:
					if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
					{
						num = (short)266731523;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
					num = (short)1106247690;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4D1:
					num = (short)1867186189;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_244:
				global::System.Windows.Data.CollectionView collectionView3 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource3);
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsTableInner item3 = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsTableInner)collectionView3.CurrentItem;
				collectionView3.MoveCurrentTo(item3);
				((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
				return;
			}
			}
		}

		// Token: 0x06008982 RID: 35202 RVA: 0x00809EC8 File Offset: 0x008080C8
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1941316376;
			short num2 = num;
			num = (short)350298904;
			switch (num2 == num)
			{
			}
			num = (short)647430145;
			if (num != 0)
			{
			}
			num = (short)530186240;
			short num3 = num;
			num = (short)108134400;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x06008983 RID: 35203 RVA: 0x00809F7C File Offset: 0x0080817C
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1064805747;
			short num2 = num;
			num = (short)728278387;
			switch (num2 == num)
			{
			}
			num = (short)117112833;
			if (num != 0)
			{
			}
			num = (short)116850688;
			short num3 = num;
			num = (short)59506688;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06008984 RID: 35204 RVA: 0x0080A02C File Offset: 0x0080822C
		internal void OnExpanderControlHeadO3O3HHCHButtonClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			object myRecordsetDataSource;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInner item;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_128;
				case 1:
					if (myRecordsetDataSource != null)
					{
						num2 = (short)952827905;
						if (num2 != 0)
						{
						}
						num2 = (short)423821314;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_12A;
				case 2:
				{
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderControlHeadO3O3HHCHButton.SyncDataSources();
					num2 = (short)144128692;
					short num3 = num2;
					num2 = (short)319634100;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_12A;
					default:
						num2 = (short)693960704;
						if (num2 != 0)
						{
						}
						num2 = (short)413138944;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_1C;
			}
			IL_128:
			IL_12A:
			num2 = (short)823721984;
			short num4 = num2;
			this.RecNavToolbarExpanderControlHeadO3O3HHCHButton.TableMode = false;
			return;
			IL_1C:
			item = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderControlHeadO3O3HHCHButton.MyRecordsetDataSource;
			num2 = (short)565444609;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06008985 RID: 35205 RVA: 0x0080A19C File Offset: 0x0080839C
		internal void OnExpanderControlHeadO3DataButtonClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			object myRecordsetDataSource;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInner item;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_125;
				case 1:
					if (myRecordsetDataSource != null)
					{
						num2 = (short)1285226498;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_127;
				case 2:
				{
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderControlHeadO3DataButton.SyncDataSources();
					num2 = (short)225430711;
					short num3 = num2;
					num2 = (short)515296439;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_127;
					default:
						num2 = (short)352190465;
						if (num2 != 0)
						{
						}
						num2 = (short)1598291968;
						if (num2 != 0)
						{
						}
						num2 = (short)543948800;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_1C;
			}
			IL_125:
			IL_127:
			num2 = (short)1987837952;
			short num4 = num2;
			this.RecNavToolbarExpanderControlHeadO3DataButton.TableMode = false;
			return;
			IL_1C:
			item = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderControlHeadO3DataButton.MyRecordsetDataSource;
			num2 = (short)217120769;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06008986 RID: 35206 RVA: 0x0080A308 File Offset: 0x00808508
		internal void OnExpanderControlHeadO3O3NavigationControlsTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			object myRecordsetDataSource;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsTableInner item;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_FC;
				case 1:
					if (myRecordsetDataSource != null)
					{
						num2 = (short)653459458;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_FE;
				case 2:
				{
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderControlHeadO3O3NavigationControlsTable.SyncDataSources();
					num2 = (short)355790237;
					short num3 = num2;
					num2 = (short)1743383965;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_FE;
					default:
						num2 = (short)1603338240;
						if (num2 != 0)
						{
						}
						num2 = (short)1116995584;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_1C;
			}
			IL_FC:
			IL_FE:
			num2 = (short)1400504321;
			if (num2 != 0)
			{
			}
			num2 = (short)205914112;
			short num4 = num2;
			this.RecNavToolbarExpanderControlHeadO3O3NavigationControlsTable.TableMode = false;
			return;
			IL_1C:
			item = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsTableInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderControlHeadO3O3NavigationControlsTable.MyRecordsetDataSource;
			num2 = (short)873660417;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06008987 RID: 35207 RVA: 0x0080A470 File Offset: 0x00808670
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 0;
			short num;
			if (this.b)
			{
				num = (short)265314407;
				short num2 = num;
				num = (short)443572327;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1493893120;
					if (num != 0)
					{
					}
					num = (short)1117585409;
					if (num != 0)
					{
					}
					return;
				}
			}
			num = (short)1078525952;
			short num3 = num;
			this.b = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("苂꧄ꯆ迈껊곌믎ꓐꇒ냔ꓖ룚닜닞釠賢诤苦蟨鿪심鷮郰韲鳴飶\udcf8짺췼髾猀搂樄椆昈昊搌氎成㘒✔✖稘琚猜礞䠠䐢値唦䠨弪䐬䀮弰ᰲ嘴堶圸伺似倾ⵀあ橄⑆♈╊㥌㵎㹐㽒灔敖楘㍚㡜㹞ՠ䙢坤坦䑨乪彬彮Ṱ䁲婴ᑶᙸᕺॼൾ벎뾐殺", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06008988 RID: 35208 RVA: 0x0080A550 File Offset: 0x00808750
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1195114496;
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
					goto IL_3E2;
				case 2:
					num = (short)1419706369;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_31:
				switch (connectionId)
				{
				case 1:
					goto IL_966;
				case 2:
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
					goto IL_E71;
				case 18:
					goto IL_997;
				case 19:
					goto IL_5D9;
				case 20:
					goto IL_539;
				case 21:
					goto IL_895;
				case 22:
					goto IL_DF5;
				case 23:
					goto IL_B66;
				case 24:
					goto IL_C6E;
				case 25:
					goto IL_BE2;
				case 26:
					goto IL_65F;
				case 27:
					goto IL_DD1;
				case 28:
					goto IL_87B;
				case 29:
					goto IL_C7B;
				case 30:
					goto IL_E33;
				case 31:
					goto IL_C88;
				case 32:
					goto IL_888;
				case 33:
					goto IL_8B9;
				case 34:
					goto IL_34B;
				case 35:
					goto IL_740;
				case 36:
					goto IL_62E;
				case 37:
					goto IL_5CC;
				case 38:
					goto IL_3F4;
				case 39:
					goto IL_9E5;
				case 40:
					goto IL_66C;
				case 41:
					goto IL_E40;
				case 42:
					goto IL_6DE;
				case 43:
					goto IL_3E7;
				case 44:
					goto IL_D2E;
				case 45:
					goto IL_CED;
				case 46:
					goto IL_303;
				case 47:
					goto IL_4BD;
				case 48:
					goto IL_857;
				case 49:
					goto IL_401;
				case 50:
					goto IL_37F;
				case 51:
					goto IL_69D;
				case 52:
					goto IL_60A;
				case 53:
					goto IL_4FB;
				case 54:
					goto IL_508;
				case 55:
					goto IL_D79;
				case 56:
					goto IL_B73;
				case 57:
					goto IL_A9F;
				case 58:
					goto IL_4D7;
				case 59:
					goto IL_D21;
				case 60:
					goto IL_BFC;
				case 61:
					goto IL_4B0;
				case 62:
					goto IL_A30;
				case 63:
					goto IL_D86;
				case 64:
					goto IL_56A;
				case 65:
					goto IL_9CB;
				case 66:
					goto IL_911;
				case 67:
					goto IL_726;
				case 68:
					goto IL_5B2;
				case 69:
					goto IL_AAC;
				case 70:
					goto IL_8C6;
				case 71:
					goto IL_C20;
				case 72:
					goto IL_435;
				case 73:
					goto IL_428;
				case 74:
					goto IL_78B;
				case 75:
					goto IL_BD5;
				case 76:
					goto IL_DAD;
				case 77:
					goto IL_77E;
				case 78:
					goto IL_7F5;
				case 79:
					goto IL_3BD;
				case 80:
					goto IL_798;
				case 81:
					goto IL_9BE;
				case 82:
					goto IL_C61;
				case 83:
					goto IL_9B1;
				case 84:
					goto IL_55D;
				case 85:
					goto IL_7E8;
				case 86:
					goto IL_CFA;
				case 87:
					goto IL_BC8;
				case 88:
					goto IL_9D8;
				case 89:
					goto IL_52C;
				case 90:
					goto IL_E19;
				case 91:
					goto IL_935;
				case 92:
					goto IL_CD3;
				case 93:
					goto IL_A6E;
				case 94:
					goto IL_7A5;
				case 95:
					goto IL_733;
				case 96:
					goto IL_DA0;
				case 97:
					goto IL_833;
				case 98:
					goto IL_2F6;
				case 99:
					goto IL_75A;
				case 100:
					goto IL_9A4;
				case 101:
					goto IL_372;
				case 102:
					goto IL_802;
				case 103:
					goto IL_702;
				case 104:
					goto IL_690;
				case 105:
					goto IL_D3B;
				case 106:
					goto IL_B32;
				case 107:
					goto IL_CC6;
				case 108:
					goto IL_459;
				case 109:
					goto IL_ADD;
				case 110:
					goto IL_904;
				case 111:
					goto IL_9FF;
				case 112:
					goto IL_A23;
				case 113:
					goto IL_8F7;
				case 114:
					goto IL_358;
				case 115:
					goto IL_B80;
				case 116:
					goto IL_8EA;
				case 117:
					goto IL_2D2;
				case 118:
					goto IL_B3F;
				case 119:
					goto IL_B25;
				case 120:
					goto IL_A61;
				case 121:
					goto IL_AB9;
				case 122:
					goto IL_74D;
				case 123:
					goto IL_58E;
				case 124:
					goto IL_6B7;
				case 125:
					goto IL_959;
				case 126:
					goto IL_BEF;
				case 127:
					goto IL_63B;
				case 128:
					goto IL_A92;
				case 129:
					goto IL_80F;
				case 130:
					goto IL_41B;
				case 131:
					goto IL_B4C;
				case 132:
					goto IL_C95;
				case 133:
					goto IL_327;
				case 134:
					goto IL_4CA;
				case 135:
					goto IL_E4D;
				case 136:
					goto IL_6AA;
				case 137:
					goto IL_6C4;
				case 138:
					goto IL_9F2;
				case 139:
					goto IL_A3D;
				case 140:
					goto IL_5BF;
				case 141:
					goto IL_38C;
				case 142:
					goto IL_6D1;
				case 143:
					goto IL_D93;
				case 144:
					goto IL_40E;
				case 145:
					goto IL_D6C;
				case 146:
					goto IL_365;
				case 147:
					goto IL_5FD;
				case 148:
					goto IL_CA2;
				case 149:
					goto IL_7DB;
				case 150:
					goto IL_B01;
				case 151:
					goto IL_B59;
				case 152:
					goto IL_D07;
				case 153:
					goto IL_D5F;
				case 154:
					goto IL_BA4;
				case 155:
					goto IL_CE0;
				case 156:
					goto IL_399;
				case 157:
					goto IL_E26;
				case 158:
					goto IL_D14;
				case 159:
					goto IL_C2D;
				default:
					num = (short)1119092738;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_2D2:
			this.LblCntrlHeadO3TrunkingO3DataButtonBCO_A22596 = (global::AcpUI.AcpLabel)target;
			this.LblCntrlHeadO3TrunkingO3DataButtonBCO_A22596.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2F6:
			this.CVBtnCntrlHeadO3ConventionalO3DataButtonBCO_A22592 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_303:
			this.CntrlHeadO3ConventionalO3HHCHButtonBCO_A19649 = (global::AcpUI.AcpComboBox)target;
			this.CntrlHeadO3ConventionalO3HHCHButtonBCO_A19649.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_327:
			this.CntrlHeadO3DataButtonKey_A22590 = (global::AcpUI.AcpTextBox)target;
			this.CntrlHeadO3DataButtonKey_A22590.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_34B:
			this.CntrlHeadO3ConventionalO3HHCHButtonFeature_A19650_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_358:
			this.CHO3DataButtonConvIndex_A41419Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_365:
			this.ExpanderControlHeadO3O3NavigationControlsTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_372:
			this.CpyBtnCntrlHeadO3ConventionalO3DataButtonBCO_A22592 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_37F:
			this.CpyBtnCntrlHeadO3ConventionalO3HHCHButtonBCO_A19649 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_38C:
			this.ExpanderControlHeadO3O3NavigationControlsTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_399:
			this.LblRadErgoControlO3NaviControlFeature_A41375 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoControlO3NaviControlFeature_A41375.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3BD:
			this.ExpanderControlHeadO3DataButtonTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_3E2:
			goto IL_E71;
			IL_3E7:
			this.RTDBtnCntrlHeadO3HHCHButtonName_A22523 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3F4:
			this.ExpanderControlHeadO3O3HHCHButtonSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_401:
			this.RTDBtnCntrlHeadO3ConventionalO3HHCHButtonBCO_A19649 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_40E:
			this.RadErgoControlO3NaviControlName_A41374_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_41B:
			this.RTDBtnCHO3DataButtonTrkIndex_A41420 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_428:
			this.CpyBtnCntrlHeadO3HHCHButtonKey_A22522 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_435:
			this.LblCntrlHeadO3HHCHButtonKey_A22522 = (global::AcpUI.AcpLabel)target;
			this.LblCntrlHeadO3HHCHButtonKey_A22522.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_459:
			num = (short)411370180;
			short num3 = num;
			num = (short)2019492548;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_9F2:
				this.ExpanderControlHeadO3O3NavigationControlsExpander = (global::AcpUI.AcpExpander)target;
				return;
			default:
				num = (short)21299200;
				if (num != 0)
				{
				}
				this.CntrlHeadO3ConventionalO3DatatButtonFeature_A22595Comp = (global::AcpUI.AcpLabel)target;
				return;
			}
			IL_4B0:
			this.RTDBtnCntrlHeadO3TrunkingO3HHCHButtonBCO_A19749 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4BD:
			this.CVBtnCntrlHeadO3ConventionalO3HHCHButtonBCO_A19649 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4CA:
			this.CVBtnCntrlHeadO3DataButtonKey_A22590 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4D7:
			this.CntrlHeadO3TrunkingO3HHCHButtonBCO_A19749 = (global::AcpUI.AcpComboBox)target;
			this.CntrlHeadO3TrunkingO3HHCHButtonBCO_A19749.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4FB:
			this.CVBtnCntrlHeadO3ConventionalO3HHCHButtonFeature_A19650 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_508:
			this.LblCntrlHeadO3ConventionalO3HHCHButtonFeature_A19650 = (global::AcpUI.AcpLabel)target;
			this.LblCntrlHeadO3ConventionalO3HHCHButtonFeature_A19650.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_52C:
			this.ExpanderControlHeadO3DataButtonSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_539:
			this.HLinkGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkGeneral.Click += this.HLinkClick;
			return;
			IL_55D:
			this.CHO3DataButtonConvIndex_A41419_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_56A:
			this.CntrlHeadO3TrunkingO3HHCHButtonFeature_A19750 = (global::AcpUI.AcpComboBox)target;
			this.CntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_58E:
			this.LblCntrlHeadO3TrunkingO3DatatButtonFeature_A22597 = (global::AcpUI.AcpLabel)target;
			this.LblCntrlHeadO3TrunkingO3DatatButtonFeature_A22597.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5B2:
			this.CpyBtnCntrlHeadO3TrunkingO3HHCHButtonFeature_A19750 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5BF:
			this.ExpanderControlHeadO3O3NavigationControlsExpanderGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_5CC:
			this.CntrlHeadO3HHCHButtonKey_A22522_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_5D9:
			this.HLinkControlHeadO3GraphicalView = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkControlHeadO3GraphicalView.Click += this.HLinkClick;
			return;
			IL_5FD:
			this.gridExpanderControlHeadO3O3NavigationControlsTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_60A:
			this.CntrlHeadO3ConventionalO3HHCHButtonFeature_A19650 = (global::AcpUI.AcpComboBox)target;
			this.CntrlHeadO3ConventionalO3HHCHButtonFeature_A19650.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_62E:
			this.CntrlHeadO3TrunkingO3HHCHButtonFeature_A19750_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_63B:
			this.CHO3DataButtonTrkIndex_A41420 = (global::AcpUI.AcpComboBox)target;
			this.CHO3DataButtonTrkIndex_A41420.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_65F:
			this.ExpanderControlHeadO3General = (global::AcpUI.AcpExpander)target;
			return;
			IL_66C:
			this.CntrlHeadO3HHCHButtonName_A22523 = (global::AcpUI.AcpLabel)target;
			this.CntrlHeadO3HHCHButtonName_A22523.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_690:
			this.CVBtnCntrlHeadO3ConventionalO3DatatButtonFeature_A22595 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_69D:
			this.CntrlHeadO3ConventionalO3HHCHButtonBCO_A19649Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_6AA:
			this.CpyBtnCntrlHeadO3DataButtonKey_A22590 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_6B7:
			this.RTDBtnCntrlHeadO3TrunkingO3DatatButtonFeature_A22597 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_6C4:
			this.CntrlHeadO3DataButtonKey_A22590Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_6D1:
			this.ExpanderControlHeadO3O3NavigationControlsTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_6DE:
			this.LblCntrlHeadO3HHCHButtonName_A22523 = (global::AcpUI.AcpLabel)target;
			this.LblCntrlHeadO3HHCHButtonName_A22523.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_702:
			this.CntrlHeadO3ConventionalO3DatatButtonFeature_A22595 = (global::AcpUI.AcpComboBox)target;
			this.CntrlHeadO3ConventionalO3DatatButtonFeature_A22595.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_726:
			this.RTDBtnCntrlHeadO3TrunkingO3HHCHButtonFeature_A19750 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_733:
			this.CpyBtnCntrlHeadO3DataButtonName_A22591 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_740:
			this.CntrlHeadO3TrunkingO3HHCHButtonBCO_A19749_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_74D:
			this.CVBtnCntrlHeadO3TrunkingO3DatatButtonFeature_A22597 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_75A:
			this.LblCntrlHeadO3ConventionalO3DataButtonBCO_A22592 = (global::AcpUI.AcpLabel)target;
			this.LblCntrlHeadO3ConventionalO3DataButtonBCO_A22592.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_77E:
			this.ExpanderControlHeadO3DataGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_78B:
			this.CntrlHeadO3HHCHButtonKey_A22522Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_798:
			this.ExpanderControlHeadO3DataButton = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_7A5:
			num = (short)399179776;
			short num4 = num;
			this.RTDBtnCntrlHeadO3DataButtonName_A22591 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_7DB:
			this.CVBtnRadErgoControlO3NaviControlName_A41374 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_7E8:
			this.CntrlHeadO3TrunkingO3DataButtonBCO_A22596_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_7F5:
			this.ExpanderControlHeadO3DataButtonGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_802:
			this.CntrlHeadO3ConventionalO3DataButtonBCO_A22592Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_80F:
			this.LblCHO3DataButtonTrkIndex_A41420 = (global::AcpUI.AcpLabel)target;
			this.LblCHO3DataButtonTrkIndex_A41420.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_833:
			this.CntrlHeadO3ConventionalO3DataButtonBCO_A22592 = (global::AcpUI.AcpComboBox)target;
			this.CntrlHeadO3ConventionalO3DataButtonBCO_A22592.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_857:
			this.LblCntrlHeadO3ConventionalO3HHCHButtonBCO_A19649 = (global::AcpUI.AcpLabel)target;
			this.LblCntrlHeadO3ConventionalO3HHCHButtonBCO_A19649.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_87B:
			this.ExpanderControlHeadO3GeneralGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_888:
			this.CntrlHeadO3HHCHButtonName_A22523_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_895:
			this.HLinkData = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkData.Click += this.HLinkClick;
			return;
			IL_8B9:
			this.CntrlHeadO3ConventionalO3HHCHButtonBCO_A19649_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_8C6:
			this.CntrlHeadO3HHCHButtonKey_A22522 = (global::AcpUI.AcpTextBox)target;
			this.CntrlHeadO3HHCHButtonKey_A22522.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_8EA:
			this.CVBtnCntrlHeadO3TrunkingO3DataButtonBCO_A22596 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_8F7:
			this.CpyBtnCHO3DataButtonConvIndex_A41419 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_904:
			this.CVBtnCHO3DataButtonConvIndex_A41419 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_911:
			this.LblCntrlHeadO3TrunkingO3HHCHButtonFeature_A19750 = (global::AcpUI.AcpLabel)target;
			this.LblCntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_935:
			this.CntrlHeadO3DataButtonName_A22591 = (global::AcpUI.AcpLabel)target;
			this.CntrlHeadO3DataButtonName_A22591.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_959:
			this.CpyBtnCntrlHeadO3TrunkingO3DatatButtonFeature_A22597 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_966:
			((global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.PageControlHeadO3)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.PageControlHeadO3)target).Unloaded += this.OnUnloaded;
			return;
			IL_997:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_9A4:
			this.RTDBtnCntrlHeadO3ConventionalO3DataButtonBCO_A22592 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_9B1:
			this.CntrlHeadO3ConventionalO3DatatButtonFeature_A22595_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_9BE:
			this.CntrlHeadO3DataButtonName_A22591_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_9CB:
			this.CVBtnCntrlHeadO3TrunkingO3HHCHButtonFeature_A19750 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_9D8:
			this.CntrlHeadO3DataButtonKey_A22590_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_9E5:
			this.gridExpanderControlHeadO3O3HHCHButtonSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_9FF:
			this.LblCHO3DataButtonConvIndex_A41419 = (global::AcpUI.AcpLabel)target;
			this.LblCHO3DataButtonConvIndex_A41419.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A23:
			this.RTDBtnCHO3DataButtonConvIndex_A41419 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A30:
			this.CpyBtnCntrlHeadO3TrunkingO3HHCHButtonBCO_A19749 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A3D:
			this.RecNavToolbarExpanderControlHeadO3O3NavigationControlsTable = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderControlHeadO3O3NavigationControlsTable.ModeClick += this.OnModeClick;
			return;
			IL_A61:
			this.CntrlHeadO3TrunkingO3DataButtonBCO_A22596Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_A6E:
			this.LblCntrlHeadO3DataButtonName_A22591 = (global::AcpUI.AcpLabel)target;
			this.LblCntrlHeadO3DataButtonName_A22591.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A92:
			this.CVBtnCHO3DataButtonTrkIndex_A41420 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A9F:
			this.CntrlHeadO3ConventionalO3HHCHButtonFeature_A19650Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_AAC:
			this.CntrlHeadO3TrunkingO3HHCHButtonFeature_A19750Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_AB9:
			this.CntrlHeadO3TrunkingO3DatatButtonFeature_A22597 = (global::AcpUI.AcpComboBox)target;
			this.CntrlHeadO3TrunkingO3DatatButtonFeature_A22597.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_ADD:
			this.CHO3DataButtonConvIndex_A41419 = (global::AcpUI.AcpComboBox)target;
			this.CHO3DataButtonConvIndex_A41419.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B01:
			this.LblRadErgoControlO3NaviControlName_A41374 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoControlO3NaviControlName_A41374.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_B25:
			this.CpyBtnCntrlHeadO3TrunkingO3DataButtonBCO_A22596 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B32:
			this.RTDBtnCntrlHeadO3ConventionalO3DatatButtonFeature_A22595 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_B3F:
			this.RTDBtnCntrlHeadO3TrunkingO3DataButtonBCO_A22596 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_B4C:
			this.CpyBtnCHO3DataButtonTrkIndex_A41420 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B59:
			this.RTDBtnRadErgoControlO3NaviControlName_A41374 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_B66:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_B73:
			this.CpyBtnCntrlHeadO3ConventionalO3HHCHButtonFeature_A19650 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B80:
			this.CntrlHeadO3TrunkingO3DataButtonBCO_A22596 = (global::AcpUI.AcpComboBox)target;
			this.CntrlHeadO3TrunkingO3DataButtonBCO_A22596.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_BA4:
			this.RadErgoControlO3NaviControlFeature_A41375 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoControlO3NaviControlFeature_A41375.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_BC8:
			this.CHO3DataButtonTrkIndex_A41420_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_BD5:
			this.ExpanderControlHeadO3Data = (global::AcpUI.AcpExpander)target;
			return;
			IL_BE2:
			this.myO3GraphicView = (global::ControlHeadGraphicView.O3GraphicView)target;
			return;
			IL_BEF:
			this.CntrlHeadO3TrunkingO3DatatButtonFeature_A22597Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_BFC:
			this.LblCntrlHeadO3TrunkingO3HHCHButtonBCO_A19749 = (global::AcpUI.AcpLabel)target;
			this.LblCntrlHeadO3TrunkingO3HHCHButtonBCO_A19749.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_C20:
			this.CVBtnCntrlHeadO3HHCHButtonKey_A22522 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_C2D:
			num = (short)1701707777;
			if (num != 0)
			{
			}
			this.RadErgoControlO3NaviControlFeature_A41375Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_C61:
			this.CntrlHeadO3ConventionalO3DataButtonBCO_A22592_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_C6E:
			this.ExpanderControlHeadO3GraphicalView = (global::AcpUI.AcpExpander)target;
			return;
			IL_C7B:
			this.ExpanderControlHeadO3O3HHCHButtonGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_C88:
			this.ExpanderControlHeadO3O3HHCHButton = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_C95:
			this.CHO3DataButtonTrkIndex_A41420Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_CA2:
			this.RadErgoControlO3NaviControlName_A41374 = (global::AcpUI.AcpLabel)target;
			this.RadErgoControlO3NaviControlName_A41374.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_CC6:
			this.CpyBtnCntrlHeadO3ConventionalO3DatatButtonFeature_A22595 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_CD3:
			this.CVBtnCntrlHeadO3DataButtonName_A22591 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_CE0:
			this.CVBtnRadErgoControlO3NaviControlFeature_A41375 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_CED:
			this.CntrlHeadO3HHCHButtonName_A22523Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_CFA:
			this.CntrlHeadO3TrunkingO3DatatButtonFeature_A22597_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_D07:
			this.CpyBtnRadErgoControlO3NaviControlName_A41374 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_D14:
			this.CpyBtnRadErgoControlO3NaviControlFeature_A41375 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_D21:
			this.CVBtnCntrlHeadO3TrunkingO3HHCHButtonBCO_A19749 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_D2E:
			this.CpyBtnCntrlHeadO3HHCHButtonName_A22523 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_D3B:
			this.LblCntrlHeadO3ConventionalO3DatatButtonFeature_A22595 = (global::AcpUI.AcpLabel)target;
			this.LblCntrlHeadO3ConventionalO3DatatButtonFeature_A22595.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_D5F:
			this.RadErgoControlO3NaviControlName_A41374Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_D6C:
			this.RadErgoControlO3NaviControlFeature_A41375_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_D79:
			this.RTDBtnCntrlHeadO3ConventionalO3HHCHButtonFeature_A19650 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_D86:
			this.CntrlHeadO3TrunkingO3HHCHButtonBCO_A19749Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_D93:
			this.ExpanderControlHeadO3O3NavigationControlsTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_DA0:
			this.CntrlHeadO3DataButtonName_A22591Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_DAD:
			this.RecNavToolbarExpanderControlHeadO3DataButton = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderControlHeadO3DataButton.ModeClick += this.OnModeClick;
			return;
			IL_DD1:
			this.RecNavToolbarExpanderControlHeadO3O3HHCHButton = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderControlHeadO3O3HHCHButton.ModeClick += this.OnModeClick;
			return;
			IL_DF5:
			this.HLinkO3NavigationControlsExpander = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkO3NavigationControlsExpander.Click += this.HLinkClick;
			return;
			IL_E19:
			this.gridExpanderControlHeadO3DataButtonSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_E26:
			this.RTDBtnRadErgoControlO3NaviControlFeature_A41375 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_E33:
			this.ExpanderControlHeadO3O3HHCHButtonTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_E40:
			this.CVBtnCntrlHeadO3HHCHButtonName_A22523 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_E4D:
			this.LblCntrlHeadO3DataButtonKey_A22590 = (global::AcpUI.AcpLabel)target;
			this.LblCntrlHeadO3DataButtonKey_A22590.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_E71:
			this.b = true;
		}

		// Token: 0x06008989 RID: 35209 RVA: 0x0080B3D8 File Offset: 0x008095D8
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num;
			for (;;)
			{
				switch (connectionId)
				{
				case 2:
					goto IL_D6;
				case 3:
				{
					num = (short)2114147745;
					short num2 = num;
					num = (short)590435745;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_16C;
					}
					break;
				}
				case 4:
					goto IL_A6;
				case 5:
					goto IL_209;
				case 6:
					goto IL_1F0;
				case 7:
					goto IL_221;
				case 8:
					goto IL_11E;
				case 9:
					goto IL_8E;
				case 10:
					goto IL_239;
				case 11:
					goto IL_EE;
				case 12:
					goto IL_76;
				case 13:
					goto IL_1D8;
				case 14:
					goto IL_BE;
				case 15:
					goto IL_199;
				case 16:
					goto IL_106;
				case 17:
					goto IL_251;
				}
				break;
			}
			num = (short)836239360;
			short num3 = num;
			return;
			IL_76:
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_8E:
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_A6:
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_BE:
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_D6:
			((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_EE:
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_106:
			((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_11E:
			((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_16C:
			num = (short)1215954944;
			if (num != 0)
			{
			}
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_199:
			num = (short)2028470273;
			if (num != 0)
			{
			}
			((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1D8:
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1F0:
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_209:
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_221:
			((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_239:
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_251:
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x040040EF RID: 16623
		private bool a;

		// Token: 0x040040F0 RID: 16624
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x040040F1 RID: 16625
		internal global::System.Windows.Documents.Hyperlink HLinkControlHeadO3GraphicalView;

		// Token: 0x040040F2 RID: 16626
		internal global::System.Windows.Documents.Hyperlink HLinkGeneral;

		// Token: 0x040040F3 RID: 16627
		internal global::System.Windows.Documents.Hyperlink HLinkData;

		// Token: 0x040040F4 RID: 16628
		internal global::System.Windows.Documents.Hyperlink HLinkO3NavigationControlsExpander;

		// Token: 0x040040F5 RID: 16629
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x040040F6 RID: 16630
		internal global::AcpUI.AcpExpander ExpanderControlHeadO3GraphicalView;

		// Token: 0x040040F7 RID: 16631
		internal global::ControlHeadGraphicView.O3GraphicView myO3GraphicView;

		// Token: 0x040040F8 RID: 16632
		internal global::AcpUI.AcpExpander ExpanderControlHeadO3General;

		// Token: 0x040040F9 RID: 16633
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderControlHeadO3O3HHCHButton;

		// Token: 0x040040FA RID: 16634
		internal global::System.Windows.Controls.Grid ExpanderControlHeadO3GeneralGrid;

		// Token: 0x040040FB RID: 16635
		internal global::System.Windows.Controls.Grid ExpanderControlHeadO3O3HHCHButtonGrid;

		// Token: 0x040040FC RID: 16636
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadO3O3HHCHButtonTableView;

		// Token: 0x040040FD RID: 16637
		internal global::AcpUI.AcpXamDataPresenter ExpanderControlHeadO3O3HHCHButton;

		// Token: 0x040040FE RID: 16638
		internal global::Infragistics.Windows.DataPresenter.UnboundField CntrlHeadO3HHCHButtonName_A22523_Col;

		// Token: 0x040040FF RID: 16639
		internal global::Infragistics.Windows.DataPresenter.UnboundField CntrlHeadO3ConventionalO3HHCHButtonBCO_A19649_Col;

		// Token: 0x04004100 RID: 16640
		internal global::Infragistics.Windows.DataPresenter.UnboundField CntrlHeadO3ConventionalO3HHCHButtonFeature_A19650_Col;

		// Token: 0x04004101 RID: 16641
		internal global::Infragistics.Windows.DataPresenter.UnboundField CntrlHeadO3TrunkingO3HHCHButtonBCO_A19749_Col;

		// Token: 0x04004102 RID: 16642
		internal global::Infragistics.Windows.DataPresenter.UnboundField CntrlHeadO3TrunkingO3HHCHButtonFeature_A19750_Col;

		// Token: 0x04004103 RID: 16643
		internal global::Infragistics.Windows.DataPresenter.UnboundField CntrlHeadO3HHCHButtonKey_A22522_Col;

		// Token: 0x04004104 RID: 16644
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadO3O3HHCHButtonSRecView;

		// Token: 0x04004105 RID: 16645
		internal global::System.Windows.Controls.Grid gridExpanderControlHeadO3O3HHCHButtonSRecView;

		// Token: 0x04004106 RID: 16646
		internal global::AcpUI.AcpLabel CntrlHeadO3HHCHButtonName_A22523;

		// Token: 0x04004107 RID: 16647
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCntrlHeadO3HHCHButtonName_A22523;

		// Token: 0x04004108 RID: 16648
		internal global::AcpUI.AcpLabel LblCntrlHeadO3HHCHButtonName_A22523;

		// Token: 0x04004109 RID: 16649
		internal global::AcpUI.AcpRtdButton RTDBtnCntrlHeadO3HHCHButtonName_A22523;

		// Token: 0x0400410A RID: 16650
		internal global::AcpUI.AcpCopyButton CpyBtnCntrlHeadO3HHCHButtonName_A22523;

		// Token: 0x0400410B RID: 16651
		internal global::AcpUI.AcpLabel CntrlHeadO3HHCHButtonName_A22523Comp;

		// Token: 0x0400410C RID: 16652
		internal global::AcpUI.AcpComboBox CntrlHeadO3ConventionalO3HHCHButtonBCO_A19649;

		// Token: 0x0400410D RID: 16653
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCntrlHeadO3ConventionalO3HHCHButtonBCO_A19649;

		// Token: 0x0400410E RID: 16654
		internal global::AcpUI.AcpLabel LblCntrlHeadO3ConventionalO3HHCHButtonBCO_A19649;

		// Token: 0x0400410F RID: 16655
		internal global::AcpUI.AcpRtdButton RTDBtnCntrlHeadO3ConventionalO3HHCHButtonBCO_A19649;

		// Token: 0x04004110 RID: 16656
		internal global::AcpUI.AcpCopyButton CpyBtnCntrlHeadO3ConventionalO3HHCHButtonBCO_A19649;

		// Token: 0x04004111 RID: 16657
		internal global::AcpUI.AcpLabel CntrlHeadO3ConventionalO3HHCHButtonBCO_A19649Comp;

		// Token: 0x04004112 RID: 16658
		internal global::AcpUI.AcpComboBox CntrlHeadO3ConventionalO3HHCHButtonFeature_A19650;

		// Token: 0x04004113 RID: 16659
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCntrlHeadO3ConventionalO3HHCHButtonFeature_A19650;

		// Token: 0x04004114 RID: 16660
		internal global::AcpUI.AcpLabel LblCntrlHeadO3ConventionalO3HHCHButtonFeature_A19650;

		// Token: 0x04004115 RID: 16661
		internal global::AcpUI.AcpRtdButton RTDBtnCntrlHeadO3ConventionalO3HHCHButtonFeature_A19650;

		// Token: 0x04004116 RID: 16662
		internal global::AcpUI.AcpCopyButton CpyBtnCntrlHeadO3ConventionalO3HHCHButtonFeature_A19650;

		// Token: 0x04004117 RID: 16663
		internal global::AcpUI.AcpLabel CntrlHeadO3ConventionalO3HHCHButtonFeature_A19650Comp;

		// Token: 0x04004118 RID: 16664
		internal global::AcpUI.AcpComboBox CntrlHeadO3TrunkingO3HHCHButtonBCO_A19749;

		// Token: 0x04004119 RID: 16665
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCntrlHeadO3TrunkingO3HHCHButtonBCO_A19749;

		// Token: 0x0400411A RID: 16666
		internal global::AcpUI.AcpLabel LblCntrlHeadO3TrunkingO3HHCHButtonBCO_A19749;

		// Token: 0x0400411B RID: 16667
		internal global::AcpUI.AcpRtdButton RTDBtnCntrlHeadO3TrunkingO3HHCHButtonBCO_A19749;

		// Token: 0x0400411C RID: 16668
		internal global::AcpUI.AcpCopyButton CpyBtnCntrlHeadO3TrunkingO3HHCHButtonBCO_A19749;

		// Token: 0x0400411D RID: 16669
		internal global::AcpUI.AcpLabel CntrlHeadO3TrunkingO3HHCHButtonBCO_A19749Comp;

		// Token: 0x0400411E RID: 16670
		internal global::AcpUI.AcpComboBox CntrlHeadO3TrunkingO3HHCHButtonFeature_A19750;

		// Token: 0x0400411F RID: 16671
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCntrlHeadO3TrunkingO3HHCHButtonFeature_A19750;

		// Token: 0x04004120 RID: 16672
		internal global::AcpUI.AcpLabel LblCntrlHeadO3TrunkingO3HHCHButtonFeature_A19750;

		// Token: 0x04004121 RID: 16673
		internal global::AcpUI.AcpRtdButton RTDBtnCntrlHeadO3TrunkingO3HHCHButtonFeature_A19750;

		// Token: 0x04004122 RID: 16674
		internal global::AcpUI.AcpCopyButton CpyBtnCntrlHeadO3TrunkingO3HHCHButtonFeature_A19750;

		// Token: 0x04004123 RID: 16675
		internal global::AcpUI.AcpLabel CntrlHeadO3TrunkingO3HHCHButtonFeature_A19750Comp;

		// Token: 0x04004124 RID: 16676
		internal global::AcpUI.AcpTextBox CntrlHeadO3HHCHButtonKey_A22522;

		// Token: 0x04004125 RID: 16677
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCntrlHeadO3HHCHButtonKey_A22522;

		// Token: 0x04004126 RID: 16678
		internal global::AcpUI.AcpLabel LblCntrlHeadO3HHCHButtonKey_A22522;

		// Token: 0x04004127 RID: 16679
		internal global::AcpUI.AcpCopyButton CpyBtnCntrlHeadO3HHCHButtonKey_A22522;

		// Token: 0x04004128 RID: 16680
		internal global::AcpUI.AcpLabel CntrlHeadO3HHCHButtonKey_A22522Comp;

		// Token: 0x04004129 RID: 16681
		internal global::AcpUI.AcpExpander ExpanderControlHeadO3Data;

		// Token: 0x0400412A RID: 16682
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderControlHeadO3DataButton;

		// Token: 0x0400412B RID: 16683
		internal global::System.Windows.Controls.Grid ExpanderControlHeadO3DataGrid;

		// Token: 0x0400412C RID: 16684
		internal global::System.Windows.Controls.Grid ExpanderControlHeadO3DataButtonGrid;

		// Token: 0x0400412D RID: 16685
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadO3DataButtonTableView;

		// Token: 0x0400412E RID: 16686
		internal global::AcpUI.AcpXamDataPresenter ExpanderControlHeadO3DataButton;

		// Token: 0x0400412F RID: 16687
		internal global::Infragistics.Windows.DataPresenter.UnboundField CntrlHeadO3DataButtonName_A22591_Col;

		// Token: 0x04004130 RID: 16688
		internal global::Infragistics.Windows.DataPresenter.UnboundField CntrlHeadO3ConventionalO3DataButtonBCO_A22592_Col;

		// Token: 0x04004131 RID: 16689
		internal global::Infragistics.Windows.DataPresenter.UnboundField CntrlHeadO3ConventionalO3DatatButtonFeature_A22595_Col;

		// Token: 0x04004132 RID: 16690
		internal global::Infragistics.Windows.DataPresenter.UnboundField CHO3DataButtonConvIndex_A41419_Col;

		// Token: 0x04004133 RID: 16691
		internal global::Infragistics.Windows.DataPresenter.UnboundField CntrlHeadO3TrunkingO3DataButtonBCO_A22596_Col;

		// Token: 0x04004134 RID: 16692
		internal global::Infragistics.Windows.DataPresenter.UnboundField CntrlHeadO3TrunkingO3DatatButtonFeature_A22597_Col;

		// Token: 0x04004135 RID: 16693
		internal global::Infragistics.Windows.DataPresenter.UnboundField CHO3DataButtonTrkIndex_A41420_Col;

		// Token: 0x04004136 RID: 16694
		internal global::Infragistics.Windows.DataPresenter.UnboundField CntrlHeadO3DataButtonKey_A22590_Col;

		// Token: 0x04004137 RID: 16695
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadO3DataButtonSRecView;

		// Token: 0x04004138 RID: 16696
		internal global::System.Windows.Controls.Grid gridExpanderControlHeadO3DataButtonSRecView;

		// Token: 0x04004139 RID: 16697
		internal global::AcpUI.AcpLabel CntrlHeadO3DataButtonName_A22591;

		// Token: 0x0400413A RID: 16698
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCntrlHeadO3DataButtonName_A22591;

		// Token: 0x0400413B RID: 16699
		internal global::AcpUI.AcpLabel LblCntrlHeadO3DataButtonName_A22591;

		// Token: 0x0400413C RID: 16700
		internal global::AcpUI.AcpRtdButton RTDBtnCntrlHeadO3DataButtonName_A22591;

		// Token: 0x0400413D RID: 16701
		internal global::AcpUI.AcpCopyButton CpyBtnCntrlHeadO3DataButtonName_A22591;

		// Token: 0x0400413E RID: 16702
		internal global::AcpUI.AcpLabel CntrlHeadO3DataButtonName_A22591Comp;

		// Token: 0x0400413F RID: 16703
		internal global::AcpUI.AcpComboBox CntrlHeadO3ConventionalO3DataButtonBCO_A22592;

		// Token: 0x04004140 RID: 16704
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCntrlHeadO3ConventionalO3DataButtonBCO_A22592;

		// Token: 0x04004141 RID: 16705
		internal global::AcpUI.AcpLabel LblCntrlHeadO3ConventionalO3DataButtonBCO_A22592;

		// Token: 0x04004142 RID: 16706
		internal global::AcpUI.AcpRtdButton RTDBtnCntrlHeadO3ConventionalO3DataButtonBCO_A22592;

		// Token: 0x04004143 RID: 16707
		internal global::AcpUI.AcpCopyButton CpyBtnCntrlHeadO3ConventionalO3DataButtonBCO_A22592;

		// Token: 0x04004144 RID: 16708
		internal global::AcpUI.AcpLabel CntrlHeadO3ConventionalO3DataButtonBCO_A22592Comp;

		// Token: 0x04004145 RID: 16709
		internal global::AcpUI.AcpComboBox CntrlHeadO3ConventionalO3DatatButtonFeature_A22595;

		// Token: 0x04004146 RID: 16710
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCntrlHeadO3ConventionalO3DatatButtonFeature_A22595;

		// Token: 0x04004147 RID: 16711
		internal global::AcpUI.AcpLabel LblCntrlHeadO3ConventionalO3DatatButtonFeature_A22595;

		// Token: 0x04004148 RID: 16712
		internal global::AcpUI.AcpRtdButton RTDBtnCntrlHeadO3ConventionalO3DatatButtonFeature_A22595;

		// Token: 0x04004149 RID: 16713
		internal global::AcpUI.AcpCopyButton CpyBtnCntrlHeadO3ConventionalO3DatatButtonFeature_A22595;

		// Token: 0x0400414A RID: 16714
		internal global::AcpUI.AcpLabel CntrlHeadO3ConventionalO3DatatButtonFeature_A22595Comp;

		// Token: 0x0400414B RID: 16715
		internal global::AcpUI.AcpComboBox CHO3DataButtonConvIndex_A41419;

		// Token: 0x0400414C RID: 16716
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCHO3DataButtonConvIndex_A41419;

		// Token: 0x0400414D RID: 16717
		internal global::AcpUI.AcpLabel LblCHO3DataButtonConvIndex_A41419;

		// Token: 0x0400414E RID: 16718
		internal global::AcpUI.AcpRtdButton RTDBtnCHO3DataButtonConvIndex_A41419;

		// Token: 0x0400414F RID: 16719
		internal global::AcpUI.AcpCopyButton CpyBtnCHO3DataButtonConvIndex_A41419;

		// Token: 0x04004150 RID: 16720
		internal global::AcpUI.AcpLabel CHO3DataButtonConvIndex_A41419Comp;

		// Token: 0x04004151 RID: 16721
		internal global::AcpUI.AcpComboBox CntrlHeadO3TrunkingO3DataButtonBCO_A22596;

		// Token: 0x04004152 RID: 16722
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCntrlHeadO3TrunkingO3DataButtonBCO_A22596;

		// Token: 0x04004153 RID: 16723
		internal global::AcpUI.AcpLabel LblCntrlHeadO3TrunkingO3DataButtonBCO_A22596;

		// Token: 0x04004154 RID: 16724
		internal global::AcpUI.AcpRtdButton RTDBtnCntrlHeadO3TrunkingO3DataButtonBCO_A22596;

		// Token: 0x04004155 RID: 16725
		internal global::AcpUI.AcpCopyButton CpyBtnCntrlHeadO3TrunkingO3DataButtonBCO_A22596;

		// Token: 0x04004156 RID: 16726
		internal global::AcpUI.AcpLabel CntrlHeadO3TrunkingO3DataButtonBCO_A22596Comp;

		// Token: 0x04004157 RID: 16727
		internal global::AcpUI.AcpComboBox CntrlHeadO3TrunkingO3DatatButtonFeature_A22597;

		// Token: 0x04004158 RID: 16728
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCntrlHeadO3TrunkingO3DatatButtonFeature_A22597;

		// Token: 0x04004159 RID: 16729
		internal global::AcpUI.AcpLabel LblCntrlHeadO3TrunkingO3DatatButtonFeature_A22597;

		// Token: 0x0400415A RID: 16730
		internal global::AcpUI.AcpRtdButton RTDBtnCntrlHeadO3TrunkingO3DatatButtonFeature_A22597;

		// Token: 0x0400415B RID: 16731
		internal global::AcpUI.AcpCopyButton CpyBtnCntrlHeadO3TrunkingO3DatatButtonFeature_A22597;

		// Token: 0x0400415C RID: 16732
		internal global::AcpUI.AcpLabel CntrlHeadO3TrunkingO3DatatButtonFeature_A22597Comp;

		// Token: 0x0400415D RID: 16733
		internal global::AcpUI.AcpComboBox CHO3DataButtonTrkIndex_A41420;

		// Token: 0x0400415E RID: 16734
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCHO3DataButtonTrkIndex_A41420;

		// Token: 0x0400415F RID: 16735
		internal global::AcpUI.AcpLabel LblCHO3DataButtonTrkIndex_A41420;

		// Token: 0x04004160 RID: 16736
		internal global::AcpUI.AcpRtdButton RTDBtnCHO3DataButtonTrkIndex_A41420;

		// Token: 0x04004161 RID: 16737
		internal global::AcpUI.AcpCopyButton CpyBtnCHO3DataButtonTrkIndex_A41420;

		// Token: 0x04004162 RID: 16738
		internal global::AcpUI.AcpLabel CHO3DataButtonTrkIndex_A41420Comp;

		// Token: 0x04004163 RID: 16739
		internal global::AcpUI.AcpTextBox CntrlHeadO3DataButtonKey_A22590;

		// Token: 0x04004164 RID: 16740
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCntrlHeadO3DataButtonKey_A22590;

		// Token: 0x04004165 RID: 16741
		internal global::AcpUI.AcpLabel LblCntrlHeadO3DataButtonKey_A22590;

		// Token: 0x04004166 RID: 16742
		internal global::AcpUI.AcpCopyButton CpyBtnCntrlHeadO3DataButtonKey_A22590;

		// Token: 0x04004167 RID: 16743
		internal global::AcpUI.AcpLabel CntrlHeadO3DataButtonKey_A22590Comp;

		// Token: 0x04004168 RID: 16744
		internal global::AcpUI.AcpExpander ExpanderControlHeadO3O3NavigationControlsExpander;

		// Token: 0x04004169 RID: 16745
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderControlHeadO3O3NavigationControlsTable;

		// Token: 0x0400416A RID: 16746
		internal global::System.Windows.Controls.Grid ExpanderControlHeadO3O3NavigationControlsExpanderGrid;

		// Token: 0x0400416B RID: 16747
		internal global::System.Windows.Controls.Grid ExpanderControlHeadO3O3NavigationControlsTableGrid;

		// Token: 0x0400416C RID: 16748
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadO3O3NavigationControlsTableTableView;

		// Token: 0x0400416D RID: 16749
		internal global::AcpUI.AcpXamDataPresenter ExpanderControlHeadO3O3NavigationControlsTable;

		// Token: 0x0400416E RID: 16750
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoControlO3NaviControlName_A41374_Col;

		// Token: 0x0400416F RID: 16751
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoControlO3NaviControlFeature_A41375_Col;

		// Token: 0x04004170 RID: 16752
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadO3O3NavigationControlsTableSRecView;

		// Token: 0x04004171 RID: 16753
		internal global::System.Windows.Controls.Grid gridExpanderControlHeadO3O3NavigationControlsTableSRecView;

		// Token: 0x04004172 RID: 16754
		internal global::AcpUI.AcpLabel RadErgoControlO3NaviControlName_A41374;

		// Token: 0x04004173 RID: 16755
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoControlO3NaviControlName_A41374;

		// Token: 0x04004174 RID: 16756
		internal global::AcpUI.AcpLabel LblRadErgoControlO3NaviControlName_A41374;

		// Token: 0x04004175 RID: 16757
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoControlO3NaviControlName_A41374;

		// Token: 0x04004176 RID: 16758
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoControlO3NaviControlName_A41374;

		// Token: 0x04004177 RID: 16759
		internal global::AcpUI.AcpLabel RadErgoControlO3NaviControlName_A41374Comp;

		// Token: 0x04004178 RID: 16760
		internal global::AcpUI.AcpComboBox RadErgoControlO3NaviControlFeature_A41375;

		// Token: 0x04004179 RID: 16761
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoControlO3NaviControlFeature_A41375;

		// Token: 0x0400417A RID: 16762
		internal global::AcpUI.AcpLabel LblRadErgoControlO3NaviControlFeature_A41375;

		// Token: 0x0400417B RID: 16763
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoControlO3NaviControlFeature_A41375;

		// Token: 0x0400417C RID: 16764
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoControlO3NaviControlFeature_A41375;

		// Token: 0x0400417D RID: 16765
		internal global::AcpUI.AcpLabel RadErgoControlO3NaviControlFeature_A41375Comp;

		// Token: 0x0400417E RID: 16766
		private bool b;
	}
}
