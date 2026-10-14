using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpUI;
using AcpUI.Common;
using AcpUILib;
using Infragistics.Windows.DataPresenter;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Ucl.Contact;

namespace SpecialFeatures.Ucl.HotList
{
	// Token: 0x020001F0 RID: 496
	public class UclTrunkingT2CallHotListPage : global::AcpUI.AcpPageFeature, global::AcpUILib.IAcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x060017DB RID: 6107 RVA: 0x002048A0 File Offset: 0x00202AA0
		public UclTrunkingT2CallHotListPage()
		{
			try
			{
				this.InitializeComponent();
			}
			catch (global::System.Exception)
			{
			}
			global::AcpUI.Common.Utility.SetDirection(this);
		}

		// Token: 0x060017DC RID: 6108 RVA: 0x002048D8 File Offset: 0x00202AD8
		public override void SetDataContext()
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_E6;
				case 1:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num2 = (short)176422916;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2214);
					num2 = (short)1253507077;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)268173312;
					short num3 = num2;
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num2 = (short)1765408768;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C0;
				}
				case 3:
				{
					num2 = (short)2144799052;
					short num4 = num2;
					num2 = (short)1062865228;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E6;
					default:
						num2 = (short)1767047168;
						if (num2 != 0)
						{
						}
						goto IL_6C;
					}
					break;
				}
				case 4:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2214);
					num2 = (short)163315715;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_6C;
				}
				goto IL_28;
				IL_6C:
				this.RecNavToolbarUclTrunkingT2CallHotList.MyRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				num2 = (short)1841627138;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_E6:
			object feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2214);
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarUclTrunkingT2CallHotList).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarUclTrunkingT2CallHotList).SyncDataSources();
			return;
			IL_1C0:
			num2 = (short)924778497;
			if (num2 != 0)
			{
			}
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarUclTrunkingT2CallHotList).MySecondaryRecordsetDataSource = null;
			return;
			IL_28:
			base.MyBaseRecNavToolbar = this.RecNavToolbarUclTrunkingT2CallHotList;
			num2 = (short)1389887489;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060017DD RID: 6109 RVA: 0x00204AD8 File Offset: 0x00202CD8
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1597964288;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)295174149;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					object obj;
					global::AcpUI.AcpExpander acpExpander;
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						goto IL_3EC;
					case 1:
					{
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarTrunkingT2CallHotListHotList.MyDataPresenter = this.TrunkingT2CallHotListDataPresenter;
						num = (short)988610569;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						object myRecordsetDataSource;
						if (myRecordsetDataSource != null)
						{
							num = (short)1320681478;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3EC;
					}
					case 3:
						goto IL_31C;
					case 4:
					{
						this.RecNavToolbarUclTrunkingT2CallHotList.ChildToolbars.Add(this.RecNavToolbarTrunkingT2CallHotListHotList);
						base.MyBaseRecNavToolbar = this.RecNavToolbarUclTrunkingT2CallHotList;
						object myRecordsetDataSource = this.RecNavToolbarUclTrunkingT2CallHotList.MyRecordsetDataSource;
						num = (short)1382678530;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						switch (0)
						{
						case 0:
							goto IL_6D;
						}
						continue;
					case 6:
					{
						object myRecordsetDataSource;
						global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
						num = (short)841351168;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						if (obj != null)
						{
							num = (short)987234305;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_25A;
					case 8:
					{
						try
						{
							num = (short)125239298;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								IL_B3:
								switch (num2)
								{
								case 0:
									num = (short)342097924;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									base.Expanders.Add(acpExpander);
									num = (short)1746862086;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_D6;
									}
									continue;
								case 3:
									while (!enumerator.MoveNext())
									{
										num = (short)511147888;
										short num3 = num;
										num = (short)1763934064;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											num = (short)1073283072;
											if (num != 0)
											{
											}
											num = (short)1128988672;
											num2 = (int)((global::System.IntPtr)num);
											goto IL_B3;
										}
									}
									acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
									num = (short)1075052549;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_1E1;
								case 5:
									if (acpExpander != null)
									{
										num = (short)1131479041;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								IL_11C:
								num = (short)868548611;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_D6:
								goto IL_11C;
							}
							IL_1E1:
							goto IL_2B5;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_203;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_1F0:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)1923874818;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (disposable != null)
									{
										num = (short)633143296;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_259;
								case 2:
									goto IL_257;
								}
								goto IL_203;
							}
							IL_257:
							IL_259:
							goto EndFinally_9;
							IL_203:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1396506625;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_1F0;
							EndFinally_9:;
						}
						goto IL_25A;
						IL_2B5:
						num = (short)946667520;
						short num4 = num;
						this.MyStackPanel.Children[0].Focus();
						base.OnLoaded(sender, e);
						this.a = true;
						num = (short)819068931;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						num = (short)1873018881;
						if (num != 0)
						{
						}
						goto IL_25A;
					}
					IL_6D:
					if (!this.a)
					{
						num = (short)431423492;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_25A:
					acpExpander = null;
					enumerator = this.MyStackPanel.Children.GetEnumerator();
					num = (short)1936457736;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3EC:
					obj = null;
					obj = this.RecNavToolbarTrunkingT2CallHotListHotList.MyRecordsetDataSource;
					num = (short)1346961415;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_31C:
				this.a();
				return;
			}
		}

		// Token: 0x060017DE RID: 6110 RVA: 0x00204F3C File Offset: 0x0020313C
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
				{
					num2 = (short)1667235840;
					short num3 = num2;
					base.OnUnloaded(sender, e);
					this.a = false;
					num2 = (short)1783037954;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					goto IL_60;
				case 2:
				{
					num2 = (short)729389797;
					short num4 = num2;
					num2 = (short)959159013;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_60;
					default:
						goto IL_109;
					}
					break;
				}
				}
				goto IL_1C;
				IL_60:
				if (!this.a)
				{
					return;
				}
				num2 = (short)2101542912;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_109:
			num2 = (short)1248919553;
			if (num2 != 0)
			{
			}
			num2 = (short)812843008;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			this.RecNavToolbarTrunkingT2CallHotListHotList.DataContext = null;
			this.RecNavToolbarUclTrunkingT2CallHotList.DataContext = null;
			this.RecNavToolbarTrunkingT2CallHotListHotList.MyDataPresenter = null;
			this.RecNavToolbarUclTrunkingT2CallHotList.MyDataPresenter = null;
			num2 = (short)1923350529;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060017DF RID: 6111 RVA: 0x00205094 File Offset: 0x00203294
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)90800184;
			short num2 = num;
			num = (short)775127096;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1302200320;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)638713857;
			if (num != 0)
			{
			}
			num = (short)1615331328;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x060017E0 RID: 6112 RVA: 0x00205144 File Offset: 0x00203344
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 6;
			short num = (short)1244332032;
			switch (num)
			{
			default:
			{
				num = (short)867237903;
				int num2 = (int)((global::System.IntPtr)num);
				global::AcpCommonLib.IAcpRecordset myRecordsetDataSource;
				for (;;)
				{
					global::System.Windows.Data.CollectionView collectionView;
					object myRecordsetDataSource2;
					global::SpecialFeatures.Ucl.HotList.TrunkingT2CallHotList trunkingT2CallHotList;
					switch (num2)
					{
					case 0:
						myRecordsetDataSource = this.RecNavToolbarUclTrunkingT2CallHotList.MyRecordsetDataSource;
						num = (short)562167824;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)579338244;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_227;
					case 3:
						goto IL_1A2;
					case 4:
						if (collectionView.IsCurrentAfterLast)
						{
							num = (short)1432158226;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						collectionView.MoveCurrentToFirst();
						num = (short)1495662604;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb88솎솔ﾜﺞ펠힤튦잨삪쒬솮횰螴\ud8b8ힺ톼껀럂规껆뫈뿊藌ꃎꗐ鿒볔ꓖ귘", a_))
						{
							num = (short)640876565;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						myRecordsetDataSource2 = this.RecNavToolbarTrunkingT2CallHotListHotList.MyRecordsetDataSource;
						num = (short)956825617;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_484;
					case 8:
						goto IL_272;
					case 9:
					{
						num = (short)1351084568;
						short num3 = num;
						num = (short)2028857880;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_484;
						default:
						{
							num = (short)1151860736;
							if (num != 0)
							{
							}
							collectionView.MoveCurrentTo(trunkingT2CallHotList);
							num = (short)789053440;
							short num4 = num;
							num = (short)613154819;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 10:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb88솎솔ﾜﺞ펠욤쮦ﶨ\ud9aa\ud8ac솮\udab0\udab2\udbb4킶覺ﺼ\udebe귀꿂跄꣆뷈蟊꓌볎ꗐ", a_))
						{
							num = (short)1427963904;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)277479429;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (trunkingT2CallHotList != null)
						{
							num = (short)713490441;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)374669332;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_1E0;
					case 13:
						num = (short)1406009354;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_29D;
					case 15:
						switch (0)
						{
						case 0:
							goto IL_A7;
						}
						continue;
					case 16:
						if (myRecordsetDataSource != null)
						{
							num = (short)1572536322;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 17:
						if (myRecordsetDataSource2 != null)
						{
							num = (short)1433600007;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 18:
						collectionView.MoveCurrentToLast();
						num = (short)1284833288;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)636682246;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)1000734734;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (collectionView.Count > 0)
						{
							num = (short)1529151489;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_34C;
					case 21:
						num = (short)386531347;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_A7:
					if (A_0 is global::AcpUI.AcpRecNavToolbar)
					{
						num = (short)1757544461;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_484:
					collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource2);
					trunkingT2CallHotList = (global::SpecialFeatures.Ucl.HotList.TrunkingT2CallHotList)collectionView.CurrentItem;
					num = (short)823984139;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1A2:
				IL_1E0:
				goto IL_34C;
				IL_227:
				num = (short)1201209345;
				if (num != 0)
				{
				}
				base.NavigationService.Navigate(new global::System.Uri(myRecordsetDataSource.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
				return;
				IL_272:
				goto IL_34C;
				IL_29D:
				return;
				IL_34C:
				((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
				return;
			}
			}
		}

		// Token: 0x060017E1 RID: 6113 RVA: 0x002055DC File Offset: 0x002037DC
		private void a()
		{
			int num;
			global::SpecialFeatures.Ucl.Contact.UclContactRecset uclContactRecset;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num)
					{
					case 0:
						if (uclContactRecset != null)
						{
							num2 = (short)1062928386;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 1:
						try
						{
							num2 = (short)689700865;
							num = (int)((global::System.IntPtr)num2);
							for (;;)
							{
								switch (num)
								{
								case 0:
									if (!enumerator.MoveNext())
									{
										num2 = (short)216989699;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									((global::AcpBusinessLayer.Recordset)((global::SpecialFeatures.Ucl.Contact.UclContact)enumerator.Current).TrunkingT2CallList.EmbeddedRecset).RefreshKeyMap();
									num2 = (short)1408368644;
									num = (int)((global::System.IntPtr)num2);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_C4;
									}
									continue;
								case 2:
									goto IL_148;
								case 3:
									num2 = (short)2098987010;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								IL_C6:
								num2 = (short)699400192;
								num = (int)((global::System.IntPtr)num2);
								continue;
								IL_C4:
								goto IL_C6;
							}
							IL_148:
							return;
						}
						finally
						{
							num2 = (short)808452096;
							num = (int)((global::System.IntPtr)num2);
							for (;;)
							{
								switch (num)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_17D;
									}
									continue;
								case 1:
									goto IL_1B2;
								case 2:
									enumerator.Dispose();
									num2 = (short)1681784833;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								IL_17D:
								if (enumerator == null)
								{
									break;
								}
								num2 = (short)1531117570;
								num = (int)((global::System.IntPtr)num2);
							}
							IL_1B2:;
						}
						goto IL_1B5;
					case 2:
					{
						num2 = (short)1508311040;
						short num3 = num2;
						goto IL_1B5;
					}
					}
					goto IL_1C;
					IL_1B5:
					num2 = (short)2108096513;
					if (num2 != 0)
					{
					}
					enumerator = uclContactRecset.GetEnumerator();
					num2 = (short)96208270;
					short num4 = num2;
					num2 = (short)1578632590;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2C;
					default:
						num2 = (short)1062207488;
						if (num2 != 0)
						{
						}
						num2 = (short)296943617;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
				}
				return;
			}
			IL_1C:
			uclContactRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2200) as global::SpecialFeatures.Ucl.Contact.UclContactRecset);
			IL_2C:
			num2 = (short)1373569024;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060017E2 RID: 6114 RVA: 0x00205844 File Offset: 0x00203A44
		private void HLinkTrunkingT2CallHotListClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)143465980;
			short num2 = num;
			num = (short)1445862908;
			switch (num2 == num)
			{
			default:
			{
				num = (short)162791424;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1887109121;
			if (num != 0)
			{
			}
			num = (short)596377600;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x060017E3 RID: 6115 RVA: 0x002058F4 File Offset: 0x00203AF4
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 2;
			short num = (short)857697224;
			short num2 = num;
			num = (short)2190280;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1911619584;
				short num3 = num;
				num = (short)720175104;
				if (num != 0)
				{
				}
				if (!this.b)
				{
					this.b = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꪄ풆麗ﾒ펔쒠킢麤쒦욨욪\uddac삮\udfb0횲\udbb4쎶隸\ud8ba\udcbc펾귀ꗈꋊ뻌믎듖뛘뗚믜뛞蛠離韤蛦鷨苪苬臮\udef0鯲髴菶闸鋺軼课⸀瘂昄欆紈礊砌愎稐稒笔瀖洘⤚縜縞䴠伢䴤䠦崨䜪䐬尮䔰䌲吴倶尸ᔺ䔼帾ⱀ⽂", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				break;
			}
			}
			num = (short)241565697;
			if (num != 0)
			{
			}
		}

		// Token: 0x060017E4 RID: 6116 RVA: 0x002059D4 File Offset: 0x00203BD4
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1994784768;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)386909256;
					short num3 = num;
					num = (short)1453179976;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_347;
					default:
						num = (short)800980992;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_7B;
						}
						continue;
					}
					break;
				}
				case 1:
					goto IL_247;
				case 2:
					num = (short)1808662529;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_7B:
				switch (connectionId)
				{
				case 1:
					goto IL_354;
				case 2:
					goto IL_3EE;
				case 3:
				case 4:
					goto IL_46C;
				case 5:
					goto IL_33A;
				case 6:
					goto IL_199;
				case 7:
					goto IL_259;
				case 8:
					goto IL_24C;
				case 9:
					goto IL_151;
				case 10:
					goto IL_1FB;
				case 11:
					goto IL_2EF;
				case 12:
					goto IL_266;
				case 13:
					goto IL_2CB;
				case 14:
					goto IL_309;
				case 15:
					goto IL_32D;
				case 16:
					goto IL_222;
				case 17:
					goto IL_2A4;
				case 18:
					goto IL_2B1;
				case 19:
					goto IL_3D4;
				case 20:
					goto IL_392;
				case 21:
					goto IL_1EE;
				case 22:
					goto IL_144;
				case 23:
					goto IL_385;
				case 24:
					goto IL_347;
				case 25:
					goto IL_2BE;
				case 26:
					goto IL_412;
				case 27:
					goto IL_137;
				case 28:
					goto IL_1BD;
				case 29:
					goto IL_45F;
				case 30:
					goto IL_280;
				case 31:
					goto IL_2FC;
				case 32:
					goto IL_175;
				case 33:
					goto IL_273;
				case 34:
					goto IL_208;
				case 35:
					goto IL_39F;
				case 36:
					goto IL_1E1;
				case 37:
					goto IL_3E1;
				case 38:
					goto IL_215;
				default:
					num = (short)628621314;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_137:
			this.CVBtnContactAlias = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_144:
			this.CallIdTable_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_151:
			this.RecNavToolbarTrunkingT2CallHotListHotList = (global::AcpUI.AcpChildRecNavToolbar)target;
			this.RecNavToolbarTrunkingT2CallHotListHotList.ModeClick += this.OnModeClick;
			return;
			IL_175:
			this.LblCallID = (global::AcpUI.AcpLabel)target;
			this.LblCallID.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_199:
			this.HLinkTrunkingT2CallHotList = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkTrunkingT2CallHotList.Click += this.HLinkTrunkingT2CallHotListClick;
			return;
			IL_1BD:
			this.LblContactAlias = (global::AcpUI.AcpLabel)target;
			this.LblContactAlias.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1E1:
			this.ContactAliasComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_1EE:
			this.ContactAliasTable_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1FB:
			this.GrpBoxExpanderPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_208:
			this.CompGridGeneralGrp = (global::System.Windows.Controls.Grid)target;
			return;
			IL_215:
			this.CallIDComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_222:
			this.CpyBtnHotListAlias = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_247:
			goto IL_46C;
			IL_24C:
			this.ExpTrunkingT2CallHotList = (global::AcpUI.AcpExpander)target;
			return;
			IL_259:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_266:
			this.CVBtnTrunkingT2HotListAlias = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_273:
			this.RtdBtnCallID = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_280:
			this.CallID = (global::AcpUI.AcpComboBox)target;
			this.CallID.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2A4:
			this.TxtBoxHotListAliasComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_2B1:
			this.GridFrame = (global::System.Windows.Controls.Grid)target;
			return;
			IL_2BE:
			this.StdGridGeneralGrp = (global::System.Windows.Controls.Grid)target;
			return;
			IL_2CB:
			this.LblHotListAlias = (global::AcpUI.AcpLabel)target;
			this.LblHotListAlias.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2EF:
			this.StdGrpBoxExpanderColumn = (global::System.Windows.Controls.Grid)target;
			return;
			IL_2FC:
			this.CVBtnCallID = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_309:
			this.TxtBoxHotListAlias = (global::AcpUI.AcpTextBox)target;
			this.TxtBoxHotListAlias.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_32D:
			this.CompGrpBoxExpanderColumn = (global::System.Windows.Controls.Grid)target;
			return;
			IL_33A:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_347:
			this.grid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_354:
			((global::SpecialFeatures.Ucl.HotList.UclTrunkingT2CallHotListPage)target).Loaded += this.OnLoaded;
			((global::SpecialFeatures.Ucl.HotList.UclTrunkingT2CallHotListPage)target).Unloaded += this.OnUnloaded;
			return;
			IL_385:
			this.GroupBoxSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_392:
			this.TrunkingT2CallHotListDataPresenter = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_39F:
			num = (short)1820590080;
			short num4 = num;
			this.CopyButtonContactAlias = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3D4:
			this.GroupBoxTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_3E1:
			this.CopyButtonCallID = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3EE:
			this.RecNavToolbarUclTrunkingT2CallHotList = (global::AcpUI.AcpParentRecNavToolbar)target;
			this.RecNavToolbarUclTrunkingT2CallHotList.ModeClick += this.OnModeClick;
			return;
			IL_412:
			num = (short)590151681;
			if (num != 0)
			{
			}
			this.ContactAlias = (global::AcpUI.AcpComboBox)target;
			this.ContactAlias.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_45F:
			this.RtdBtnContactAlias = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_46C:
			this.b = true;
		}

		// Token: 0x060017E5 RID: 6117 RVA: 0x00205E54 File Offset: 0x00204054
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num = (short)995753984;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 1:
				{
					num = (short)182770741;
					short num3 = num;
					num = (short)999349301;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3B;
					default:
						num = (short)1046347776;
						if (num != 0)
						{
						}
						num = (short)476643331;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					goto IL_138;
				case 3:
					if (connectionId != 4)
					{
						num = (short)1356857346;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_13A;
				}
				goto IL_34;
				IL_3B:
				num = (short)1286340609;
				if (num != 0)
				{
				}
				num = (short)563412993;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_34:
				if (connectionId != 3)
				{
					goto IL_3B;
				}
				break;
			}
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_138:
			num = (short)1078001664;
			short num4 = num;
			return;
			IL_13A:
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x04000C56 RID: 3158
		private bool a;

		// Token: 0x04000C57 RID: 3159
		internal global::AcpUI.AcpParentRecNavToolbar RecNavToolbarUclTrunkingT2CallHotList;

		// Token: 0x04000C58 RID: 3160
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x04000C59 RID: 3161
		internal global::System.Windows.Documents.Hyperlink HLinkTrunkingT2CallHotList;

		// Token: 0x04000C5A RID: 3162
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x04000C5B RID: 3163
		internal global::AcpUI.AcpExpander ExpTrunkingT2CallHotList;

		// Token: 0x04000C5C RID: 3164
		internal global::AcpUI.AcpChildRecNavToolbar RecNavToolbarTrunkingT2CallHotListHotList;

		// Token: 0x04000C5D RID: 3165
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderPseudo0;

		// Token: 0x04000C5E RID: 3166
		internal global::System.Windows.Controls.Grid StdGrpBoxExpanderColumn;

		// Token: 0x04000C5F RID: 3167
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrunkingT2HotListAlias;

		// Token: 0x04000C60 RID: 3168
		internal global::AcpUI.AcpLabel LblHotListAlias;

		// Token: 0x04000C61 RID: 3169
		internal global::AcpUI.AcpTextBox TxtBoxHotListAlias;

		// Token: 0x04000C62 RID: 3170
		internal global::System.Windows.Controls.Grid CompGrpBoxExpanderColumn;

		// Token: 0x04000C63 RID: 3171
		internal global::AcpUI.AcpCopyButton CpyBtnHotListAlias;

		// Token: 0x04000C64 RID: 3172
		internal global::AcpUI.AcpViewOnlyCtrl TxtBoxHotListAliasComp;

		// Token: 0x04000C65 RID: 3173
		internal global::System.Windows.Controls.Grid GridFrame;

		// Token: 0x04000C66 RID: 3174
		internal global::AcpUI.AcpGroupBox GroupBoxTableView;

		// Token: 0x04000C67 RID: 3175
		internal global::AcpUI.AcpXamDataPresenter TrunkingT2CallHotListDataPresenter;

		// Token: 0x04000C68 RID: 3176
		internal global::Infragistics.Windows.DataPresenter.UnboundField ContactAliasTable_Col;

		// Token: 0x04000C69 RID: 3177
		internal global::Infragistics.Windows.DataPresenter.UnboundField CallIdTable_Col;

		// Token: 0x04000C6A RID: 3178
		internal global::AcpUI.AcpGroupBox GroupBoxSRecView;

		// Token: 0x04000C6B RID: 3179
		internal global::System.Windows.Controls.Grid grid;

		// Token: 0x04000C6C RID: 3180
		internal global::System.Windows.Controls.Grid StdGridGeneralGrp;

		// Token: 0x04000C6D RID: 3181
		internal global::AcpUI.AcpComboBox ContactAlias;

		// Token: 0x04000C6E RID: 3182
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnContactAlias;

		// Token: 0x04000C6F RID: 3183
		internal global::AcpUI.AcpLabel LblContactAlias;

		// Token: 0x04000C70 RID: 3184
		internal global::AcpUI.AcpRtdButton RtdBtnContactAlias;

		// Token: 0x04000C71 RID: 3185
		internal global::AcpUI.AcpComboBox CallID;

		// Token: 0x04000C72 RID: 3186
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCallID;

		// Token: 0x04000C73 RID: 3187
		internal global::AcpUI.AcpLabel LblCallID;

		// Token: 0x04000C74 RID: 3188
		internal global::AcpUI.AcpRtdButton RtdBtnCallID;

		// Token: 0x04000C75 RID: 3189
		internal global::System.Windows.Controls.Grid CompGridGeneralGrp;

		// Token: 0x04000C76 RID: 3190
		internal global::AcpUI.AcpCopyButton CopyButtonContactAlias;

		// Token: 0x04000C77 RID: 3191
		internal global::AcpUI.AcpViewOnlyCtrl ContactAliasComp;

		// Token: 0x04000C78 RID: 3192
		internal global::AcpUI.AcpCopyButton CopyButtonCallID;

		// Token: 0x04000C79 RID: 3193
		internal global::AcpUI.AcpViewOnlyCtrl CallIDComp;

		// Token: 0x04000C7A RID: 3194
		private bool b;
	}
}
