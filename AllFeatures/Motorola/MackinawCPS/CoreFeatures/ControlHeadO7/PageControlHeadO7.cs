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

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO7
{
	// Token: 0x0200038B RID: 907
	public class PageControlHeadO7 : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x0600869E RID: 34462 RVA: 0x007D5B8C File Offset: 0x007D3D8C
		public PageControlHeadO7()
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

		// Token: 0x0600869F RID: 34463 RVA: 0x007D5BC4 File Offset: 0x007D3DC4
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)526123008;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				switch (0)
				{
				case 0:
					goto IL_6F;
				}
				for (;;)
				{
					IL_28:
					object obj;
					global::System.Collections.IEnumerator enumerator;
					global::AcpUI.AcpExpander acpExpander;
					switch (num2)
					{
					case 0:
						if (obj != null)
						{
							num = (short)1406402567;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12B;
					case 1:
						goto IL_234;
					case 2:
						goto IL_4C2;
					case 3:
						if (!this.a)
						{
							num = (short)1979908104;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_537;
					case 4:
						goto IL_B6;
					case 5:
						if (obj != null)
						{
							num = (short)751501327;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B6;
					case 6:
						goto IL_E6;
					case 7:
					{
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderControlHeadO7O7.MyDataPresenter = this.ExpanderControlHeadO7O7;
						num = (short)854327310;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						obj = null;
						obj = this.RecNavToolbarExpanderControlHeadO7O7.MyRecordsetDataSource;
						num = (short)13434880;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_260;
					case 10:
					{
						try
						{
							num = (short)1832517633;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									if (!enumerator.MoveNext())
									{
										num = (short)1924202499;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
									num = (short)2087321602;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_336;
									}
									continue;
								case 2:
									if (acpExpander != null)
									{
										num = (short)939589638;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 3:
									num = (short)1176633348;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_3F8;
								case 6:
									base.Expanders.Add(acpExpander);
									num = (short)1685848069;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_3A1:
								num = (short)851705856;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_336:
								goto IL_3A1;
							}
							IL_3F8:
							goto IL_1E5;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_41A;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_407:
								switch (num2)
								{
								case 0:
									goto IL_4BF;
								case 1:
								{
									num = (short)1669460133;
									short num3 = num;
									num = (short)972550309;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_4BF;
									default:
										num = (short)163250176;
										if (num != 0)
										{
										}
										disposable.Dispose();
										num = (short)2116485120;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									if (disposable != null)
									{
										num = (short)489488385;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4C1;
								}
								goto IL_41A;
							}
							IL_4BF:
							IL_4C1:
							goto EndFinally_11;
							IL_41A:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1714159618;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_407;
							EndFinally_11:;
						}
						goto IL_4C2;
						IL_1E5:
						num = (short)2085748736;
						short num4 = num;
						base.OnLoaded(sender, e);
						this.a = true;
						num = (short)1720385537;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						if (obj != null)
						{
							num = (short)1694498829;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_260;
					case 12:
						if (obj != null)
						{
							num = (short)493355010;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E6;
					case 13:
					{
						global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderControlHeadO7O7DataButtonTable.MyDataPresenter = this.ExpanderControlHeadO7O7DataButtonTable;
						num = (short)1921712137;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						goto IL_12B;
					case 15:
					{
						global::System.Windows.Data.CollectionView collectionView3 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderControlHeadO7O7NavigationControlsTable.MyDataPresenter = this.ExpanderControlHeadO7O7NavigationControlsTable;
						num = (short)603914244;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_6F;
					IL_B6:
					acpExpander = null;
					enumerator = this.MyStackPanel.Children.GetEnumerator();
					num = (short)1248133130;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E6:
					obj = this.RecNavToolbarExpanderControlHeadO7O7NavigationControlsTable.MyRecordsetDataSource;
					num = (short)278659077;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_12B:
					obj = this.RecNavToolbarExpanderControlHeadO7O7DataButtonTable.MyRecordsetDataSource;
					num = (short)929300491;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_260:
					obj = this.RecNavToolbarExpanderControlHeadO7O7MFKAssignmentControl.MyRecordsetDataSource;
					num = (short)627703820;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4C2:
					global::System.Windows.Data.CollectionView collectionView4 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
					this.RecNavToolbarExpanderControlHeadO7O7MFKAssignmentControl.MyDataPresenter = this.ExpanderControlHeadO7O7MFKAssignmentControl;
					num = (short)1857093638;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_234:
				num = (short)1157627905;
				if (num != 0)
				{
				}
				IL_537:
				this.MyStackPanel.Children[0].Focus();
				return;
				IL_6F:
				this.PreOnLoaded(sender, e);
				num = (short)385220611;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
		}

		// Token: 0x060086A0 RID: 34464 RVA: 0x007D613C File Offset: 0x007D433C
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
					goto IL_15D;
				case 1:
				{
					num2 = (short)2001549001;
					short num3 = num2;
					num2 = (short)2123314889;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15D;
					default:
						num2 = (short)74711040;
						if (num2 != 0)
						{
						}
						base.OnUnloaded(sender, e);
						this.a = false;
						num2 = (short)1374945280;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					if (this.a)
					{
						num2 = (short)174325761;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_15F;
				}
				goto IL_1C;
			}
			IL_15D:
			IL_15F:
			num2 = (short)1872297985;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			this.PreOnUnloaded(sender, e);
			this.RecNavToolbarExpanderControlHeadO7O7.DataContext = null;
			this.RecNavToolbarExpanderControlHeadO7O7DataButtonTable.DataContext = null;
			this.RecNavToolbarExpanderControlHeadO7O7MFKAssignmentControl.DataContext = null;
			this.RecNavToolbarExpanderControlHeadO7O7NavigationControlsTable.DataContext = null;
			this.RecNavToolbarExpanderControlHeadO7O7.MyDataPresenter = null;
			this.RecNavToolbarExpanderControlHeadO7O7DataButtonTable.MyDataPresenter = null;
			this.RecNavToolbarExpanderControlHeadO7O7MFKAssignmentControl.MyDataPresenter = null;
			this.RecNavToolbarExpanderControlHeadO7O7NavigationControlsTable.MyDataPresenter = null;
			num2 = (short)579272704;
			short num4 = num2;
			num2 = (short)887226370;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060086A1 RID: 34465 RVA: 0x007D62D0 File Offset: 0x007D44D0
		public override void SetDataContext()
		{
			short num = (short)39649299;
			int num2 = (int)((global::System.IntPtr)num);
			object feature;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1319370763;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (feature != null)
					{
						num = (short)303038466;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_417;
				case 2:
					num = (short)1069219857;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10717].EmbeddedRecset != null)
					{
						num = (short)685703199;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_14A;
				case 4:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10719] != null)
					{
						num = (short)1074069527;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_417;
				case 5:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(4114);
					num = (short)1456275496;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(4114);
					num = (short)1840447489;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10718] != null)
					{
						num = (short)1181220873;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7F4;
				case 8:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10719].EmbeddedRecset != null)
					{
						num = (short)104398858;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_417;
				case 9:
					goto IL_623;
				case 10:
				{
					num = (short)1571028992;
					short num3 = num;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO7O7).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10719].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO7O7).SyncDataSources();
					num = (short)148242457;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 11:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)1821835297;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 12:
					if (feature != null)
					{
						num = (short)137363476;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_14A;
				case 13:
					num = (short)2125332487;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					num = (short)1631780867;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					if (feature != null)
					{
						num = (short)648019968;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 16:
				{
					num = (short)391143959;
					short num4 = num;
					num = (short)1850171927;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_623;
					default:
						num = (short)261095424;
						if (num != 0)
						{
						}
						num = (short)1518272513;
						if (num != 0)
						{
						}
						num = (short)2010054674;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 17:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)1961295906;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_417;
				case 18:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)1820327949;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7F4;
				case 19:
					switch (0)
					{
					case 0:
						goto IL_CE;
					}
					continue;
				case 20:
					num = (short)1510408224;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					goto IL_14A;
				case 22:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10718].EmbeddedRecset != null)
					{
						num = (short)1485439005;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7F4;
				case 23:
					num = (short)1758265352;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					if (feature != null)
					{
						num = (short)1100349456;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7F4;
				case 25:
					goto IL_417;
				case 26:
					num = (short)396886053;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 27:
					goto IL_3C5;
				case 28:
					num = (short)1039663142;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 29:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO7O7MFKAssignmentControl).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10718].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO7O7MFKAssignmentControl).SyncDataSources();
					num = (short)811860009;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 30:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)823525382;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO7O7).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO7O7DataButtonTable).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO7O7MFKAssignmentControl).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO7O7NavigationControlsTable).MySecondaryRecordsetDataSource = null;
					num = (short)932839463;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 31:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO7O7DataButtonTable).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10717].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO7O7DataButtonTable).SyncDataSources();
					num = (short)1905721365;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 32:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)946339868;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_14A;
				case 33:
					num = (short)1045692452;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 34:
					num = (short)1081606148;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 35:
					goto IL_21A;
				case 36:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10727] != null)
					{
						num = (short)1021575194;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 37:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10727].EmbeddedRecset != null)
					{
						num = (short)509083675;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 38:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10717] != null)
					{
						num = (short)1875378190;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_14A;
				case 39:
					return;
				case 40:
					goto IL_21A;
				case 41:
					goto IL_7F4;
				}
				IL_CE:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)1650982917;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(4114);
				num = (short)351993891;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_14A:
				num = (short)970588184;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_21A:
				num = (short)1641611294;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_417:
				num = (short)518455308;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_623:
				num = (short)848101398;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_7F4:
				num = (short)909901839;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_3C5:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO7O7NavigationControlsTable).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10727].EmbeddedRecset;
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO7O7NavigationControlsTable).SyncDataSources();
		}

		// Token: 0x060086A2 RID: 34466 RVA: 0x007D6B0C File Offset: 0x007D4D0C
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 8;
			short num = (short)519241728;
			switch (num)
			{
			default:
			{
				num = (short)1085997058;
				int num2 = (int)((global::System.IntPtr)num);
				object myRecordsetDataSource3;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_125;
					case 1:
						num = (short)662700038;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_D1;
						}
						continue;
					case 3:
					{
						object myRecordsetDataSource;
						if (myRecordsetDataSource != null)
						{
							num = (short)636157967;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_472;
					}
					case 4:
						num = (short)717815830;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1218445330;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)32833553;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1039663113;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A3;
					case 7:
					{
						object myRecordsetDataSource2;
						if (myRecordsetDataSource2 != null)
						{
							num = (short)201719829;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_125;
					}
					case 8:
						num = (short)1968373786;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						myRecordsetDataSource3 = this.RecNavToolbarExpanderControlHeadO7O7NavigationControlsTable.MyRecordsetDataSource;
						num = (short)913702928;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						object myRecordsetDataSource4;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource4);
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInner item = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInner)collectionView.CurrentItem;
						collectionView.MoveCurrentTo(item);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)1264648219;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						goto IL_557;
					case 12:
					{
						object myRecordsetDataSource4;
						if (myRecordsetDataSource4 != null)
						{
							num = (short)1713963018;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_557;
					}
					case 13:
						num = (short)1883308061;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_39E;
					case 15:
					{
						object myRecordsetDataSource;
						global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7Inner item2 = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7Inner)collectionView2.CurrentItem;
						collectionView2.MoveCurrentTo(item2);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)1295581216;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						if (myRecordsetDataSource3 != null)
						{
							num = (short)506855438;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 17:
						goto IL_472;
					case 18:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource = this.RecNavToolbarExpanderControlHeadO7O7.MyRecordsetDataSource;
						num = (short)382599171;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
					{
						if (!(((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("鯈껊껌臎냐ꗒ臔룖뛘럚뿜뻞鏠ꛢ鷤韦裨藪觬諮菰냲髴駶跸觺鋼鏾䤀昂搄挆䘈㰊䈌㠎弐爒挔縖縘稚検瘞丠䴢昤䠦䜨弪弬䀮崰䀲愴嘶嬸场堼", a_)))
						{
							return;
						}
						num = (short)737056433;
						short num3 = num;
						num = (short)374445745;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3A3;
						default:
							num = (short)427622400;
							if (num != 0)
							{
							}
							num = (short)1558577153;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 20:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource2 = this.RecNavToolbarExpanderControlHeadO7O7DataButtonTable.MyRecordsetDataSource;
						num = (short)160956423;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
					{
						object myRecordsetDataSource2;
						global::System.Windows.Data.CollectionView collectionView3 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource2);
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInner item3 = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInner)collectionView3.CurrentItem;
						collectionView3.MoveCurrentTo(item3);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)939720732;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1443430420;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)1247739904;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource4 = this.RecNavToolbarExpanderControlHeadO7O7MFKAssignmentControl.MyRecordsetDataSource;
						num = (short)751108096;
						short num4 = num;
						num = (short)243728396;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("鯈껊껌臎냐ꗒ臔룖뛘럚뿜뻞鏠ꛢ鷤韦裨藪觬諮菰냲髴駶跸觺鋼鏾䤀昂搄挆䘈㰊䈌㠎尐唒帔嘖樘栚琜砞传丢䀤䤦崨株䈬䄮䔰䄲娴嬶", a_))
						{
							num = (short)129105933;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_557;
					case 25:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("鯈껊껌臎냐ꗒ臔룖뛘럚뿜뻞鏠ꛢ鷤韦裨藪觬諮菰냲髴駶跸觺鋼鏾䤀昂搄挆䘈㰊䈌㠎唐爒愔瘖嬘渚検欞丠䴢焤䘦䬨䜪䠬", a_))
						{
							num = (short)870318084;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_125;
					case 26:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("鯈껊껌臎냐ꗒ臔룖뛘럚뿜뻞鏠ꛢ鷤韦裨藪觬諮菰냲髴駶跸觺鋼鏾䤀昂搄挆䘈㰊䈌㠎", a_))
						{
							num = (short)55902239;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_472;
					case 27:
						goto IL_557;
					case 28:
						goto IL_125;
					case 29:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1466957847;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)447152139;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						return;
					case 31:
						num = (short)1784938501;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						goto IL_472;
					}
					IL_D1:
					if (A_0 is global::AcpUI.AcpRecNavToolbar)
					{
						num = (short)960757768;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_125:
					num = (short)1250295809;
					if (num != 0)
					{
					}
					num = (short)1958871064;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3A3:
					((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
					num = (short)899547166;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_472:
					num = (short)641073177;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_557:
					num = (short)284098579;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_39E:
				global::System.Windows.Data.CollectionView collectionView4 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource3);
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsTableInner item4 = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsTableInner)collectionView4.CurrentItem;
				collectionView4.MoveCurrentTo(item4);
				((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
				return;
			}
			}
		}

		// Token: 0x060086A3 RID: 34467 RVA: 0x007D7224 File Offset: 0x007D5424
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1263773530;
			short num2 = num;
			num = (short)863545178;
			switch (num2 == num)
			{
			}
			num = (short)159318017;
			if (num != 0)
			{
			}
			num = (short)502792192;
			if (num != 0)
			{
			}
			num = (short)693108736;
			short num3 = num;
			base.OnHLinkClick(A_0);
		}

		// Token: 0x060086A4 RID: 34468 RVA: 0x007D72D4 File Offset: 0x007D54D4
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1168356504;
			short num2 = num;
			num = (short)1141224600;
			switch (num2 == num)
			{
			}
			num = (short)414973953;
			if (num != 0)
			{
			}
			num = (short)505741312;
			if (num != 0)
			{
			}
			num = (short)2049179648;
			short num3 = num;
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x060086A5 RID: 34469 RVA: 0x007D7388 File Offset: 0x007D5588
		internal void OnExpanderControlHeadO7O7Click(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)2062221312;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_45;
			}
			int num3;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7Inner item;
			for (;;)
			{
				IL_33:
				switch (num3)
				{
				case 0:
					goto IL_D9;
				case 1:
					IL_A1:
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderControlHeadO7O7.SyncDataSources();
					num = (short)1898250240;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (myRecordsetDataSource != null)
					{
						num = (short)1393491969;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D9;
				}
				goto IL_45;
				IL_D9:
				num = (short)1447165953;
				if (num != 0)
				{
				}
				num = (short)227485666;
				short num4 = num;
				num = (short)383330274;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_A1;
				default:
					goto IL_134;
				}
			}
			IL_134:
			num = (short)1576206336;
			if (num != 0)
			{
			}
			this.RecNavToolbarExpanderControlHeadO7O7.TableMode = false;
			return;
			IL_45:
			item = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7Inner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderControlHeadO7O7.MyRecordsetDataSource;
			num = (short)314376194;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_33;
		}

		// Token: 0x060086A6 RID: 34470 RVA: 0x007D74EC File Offset: 0x007D56EC
		internal void OnExpanderControlHeadO7O7DataButtonTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)479264768;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			int num3;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInner item;
			for (;;)
			{
				IL_32:
				switch (num3)
				{
				case 0:
					num = (short)116326401;
					if (num != 0)
					{
					}
					goto IL_FF;
				case 1:
					IL_A0:
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderControlHeadO7O7DataButtonTable.SyncDataSources();
					num = (short)756219904;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (myRecordsetDataSource != null)
					{
						num = (short)2130771969;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_FF;
				}
				goto IL_44;
				IL_FF:
				num = (short)1481805355;
				short num4 = num;
				num = (short)666603051;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_A0;
				default:
					goto IL_134;
				}
			}
			IL_134:
			num = (short)874250240;
			if (num != 0)
			{
			}
			this.RecNavToolbarExpanderControlHeadO7O7DataButtonTable.TableMode = false;
			return;
			IL_44:
			item = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderControlHeadO7O7DataButtonTable.MyRecordsetDataSource;
			num = (short)512229378;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_32;
		}

		// Token: 0x060086A7 RID: 34471 RVA: 0x007D7650 File Offset: 0x007D5850
		internal void OnExpanderControlHeadO7O7MFKAssignmentControlClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)2023227392;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_45;
			}
			int num3;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInner item;
			for (;;)
			{
				IL_33:
				switch (num3)
				{
				case 0:
					goto IL_105;
				case 1:
					IL_CD:
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderControlHeadO7O7MFKAssignmentControl.SyncDataSources();
					num = (short)866058240;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (myRecordsetDataSource != null)
					{
						num = (short)1395064833;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_105;
				}
				goto IL_45;
				IL_105:
				num = (short)747598012;
				short num4 = num;
				num = (short)882995388;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_CD;
				default:
					goto IL_13B;
				}
			}
			IL_13B:
			num = (short)1738211328;
			if (num != 0)
			{
			}
			this.RecNavToolbarExpanderControlHeadO7O7MFKAssignmentControl.TableMode = false;
			return;
			IL_45:
			num = (short)1837629441;
			if (num != 0)
			{
			}
			item = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderControlHeadO7O7MFKAssignmentControl.MyRecordsetDataSource;
			num = (short)459538434;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_33;
		}

		// Token: 0x060086A8 RID: 34472 RVA: 0x007D77BC File Offset: 0x007D59BC
		internal void OnExpanderControlHeadO7O7NavigationControlsTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)522452992;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			int num3;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsTableInner item;
			for (;;)
			{
				IL_32:
				switch (num3)
				{
				case 0:
					goto IL_D9;
				case 1:
					IL_A1:
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderControlHeadO7O7NavigationControlsTable.SyncDataSources();
					num = (short)1030422528;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (myRecordsetDataSource != null)
					{
						num = (short)1281622017;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D9;
				}
				goto IL_44;
				IL_D9:
				num = (short)2069739276;
				short num4 = num;
				num = (short)301512460;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_A1;
				default:
					goto IL_10E;
				}
			}
			IL_10E:
			num = (short)2068250625;
			if (num != 0)
			{
			}
			num = (short)1792868352;
			if (num != 0)
			{
			}
			this.RecNavToolbarExpanderControlHeadO7O7NavigationControlsTable.TableMode = false;
			return;
			IL_44:
			item = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsTableInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderControlHeadO7O7NavigationControlsTable.MyRecordsetDataSource;
			num = (short)1724514306;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_32;
		}

		// Token: 0x060086A9 RID: 34473 RVA: 0x007D7920 File Offset: 0x007D5B20
		private void PreOnLoaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1413168413;
			short num2 = num;
			num = (short)375078173;
			switch (num2 == num)
			{
			}
			num = (short)1685127169;
			if (num != 0)
			{
			}
			num = (short)1843396608;
			if (num != 0)
			{
			}
			num = (short)780075008;
			short num3 = num;
			this.b();
		}

		// Token: 0x060086AA RID: 34474 RVA: 0x007D79CC File Offset: 0x007D5BCC
		private void PreOnUnloaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1338573454;
			short num2 = num;
			num = (short)1016005262;
			switch (num2 == num)
			{
			}
			num = (short)1862205441;
			if (num != 0)
			{
			}
			num = (short)966393856;
			short num3 = num;
			num = (short)2083454976;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x060086AB RID: 34475 RVA: 0x007D7A80 File Offset: 0x007D5C80
		private void b()
		{
			short num = (short)725483521;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 2:
					global::AcpCommonLib.AppInfoManager.AppInfoHelper.PropertyChanged += this.OnAppInfoPropertyChanged;
					goto IL_E1;
				}
				IL_30:
				num = (short)1724252161;
				if (num != 0)
				{
				}
				if (this.a)
				{
					break;
				}
				num = (short)1107686439;
				short num3 = num;
				num = (short)403764263;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1488977920;
					if (num != 0)
					{
					}
					num = (short)662044674;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_E1:
				num = (short)586088448;
				short num4 = num;
				num = (short)1443954688;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060086AC RID: 34476 RVA: 0x007D7BB4 File Offset: 0x007D5DB4
		private void OnAppInfoPropertyChanged(object A_0, global::System.ComponentModel.PropertyChangedEventArgs A_1)
		{
			int a_ = 7;
			short num = (short)2003304449;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					if (!(A_1.PropertyName == global::AllFeatures.CodeplugGuid.b("臇Ꟊ볋ꇍꋏꛑ鯓ꛕ뷗꣙뷛ꫝ觟跡諣ꗥ蟧蟩鳫苭闯蛱釳鋵", a_)))
					{
						return;
					}
					num = (short)1322336544;
					short num3 = num;
					num = (short)1680163104;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1D;
					default:
						num = (short)799342592;
						if (num != 0)
						{
						}
						num = (short)451477506;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					goto IL_1D;
				case 2:
					goto IL_9B;
				case 3:
				{
					num = (short)1355939840;
					short num4 = num;
					num = (short)706019328;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					return;
				}
				goto IL_41;
				IL_1D:
				switch (0)
				{
				case 0:
					IL_41:
					if (A_1.PropertyName == global::AllFeatures.CodeplugGuid.b("資꓉꣋臍ꃏ럑ꛓ럕곗동돛냝ꏟ跡解雥蓧迩飫语铯", a_))
					{
						goto IL_9B;
					}
					num = (short)1335099395;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				continue;
				IL_9B:
				this.myO7GraphicView.SetMenuItems();
				num = (short)748748801;
				if (num != 0)
				{
				}
				num = (short)2107047940;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060086AD RID: 34477 RVA: 0x007D7D48 File Offset: 0x007D5F48
		private void a()
		{
			short num = (short)722599937;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_C8;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 2:
					global::AcpCommonLib.AppInfoManager.AppInfoHelper.PropertyChanged -= this.OnAppInfoPropertyChanged;
					goto IL_B1;
				}
				IL_31:
				if (this.a)
				{
					goto IL_F4;
				}
				num = (short)897853503;
				short num3 = num;
				num = (short)1327507519;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1651376128;
					if (num != 0)
					{
					}
					num = (short)703660034;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_B1:
				num = (short)1171652608;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_C8:
			num = (short)513998848;
			short num4 = num;
			IL_F4:
			num = (short)395378689;
			if (num != 0)
			{
			}
		}

		// Token: 0x060086AE RID: 34478 RVA: 0x007D7E70 File Offset: 0x007D6070
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 11;
			if (!this.b)
			{
				short num = (short)1135411200;
				short num2 = num;
				num = (short)776934653;
				short num3 = num;
				num = (short)1353323773;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1502609409;
					if (num != 0)
					{
					}
					num = (short)95944704;
					if (num != 0)
					{
					}
					this.b = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("迍볏뻑鋓돕맗껙꧛곝藟釡\udfe3藥蟧蟩鳫臭黯韱髳苵ퟷ裹鷻髽槿洁℃㐅㠇漉縋植缏簑笓笕焗礙漛㬝ሟሡ䜣䤥䘧䰩䔫䤭䔯䀱唳䈵儷唹刻ᄽ⌿ⵁ⩃㉅㩇╉⁋㵍罏ㅑ㭓㡕ⱗ⡙㍛㉝䕟偡呣๥൧୩࡫䭭䉯䉱女卵䩷䩹፻䥽꽿ﲇ궙늛솟쾡좣", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
		}

		// Token: 0x060086AF RID: 34479 RVA: 0x007D7F54 File Offset: 0x007D6154
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)775618561;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_3EA;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 2:
					num = (short)714211328;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_31:
				switch (connectionId)
				{
				case 1:
					goto IL_8E4;
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
					goto IL_EAE;
				case 16:
					goto IL_915;
				case 17:
					goto IL_597;
				case 18:
					goto IL_4F7;
				case 19:
					goto IL_82A;
				case 20:
					goto IL_E25;
				case 21:
					goto IL_ACD;
				case 22:
					goto IL_BC5;
				case 23:
					goto IL_DB5;
				case 24:
					goto IL_B77;
				case 25:
					goto IL_5EF;
				case 26:
					goto IL_BD2;
				case 27:
					goto IL_810;
				case 28:
					goto IL_E49;
				case 29:
					goto IL_DA8;
				case 30:
					goto IL_BF6;
				case 31:
					goto IL_81D;
				case 32:
					goto IL_6D0;
				case 33:
					goto IL_324;
				case 34:
					goto IL_84E;
				case 35:
					goto IL_5D5;
				case 36:
					goto IL_573;
				case 37:
					goto IL_413;
				case 38:
					goto IL_97A;
				case 39:
					goto IL_5FC;
				case 40:
					goto IL_E63;
				case 41:
					goto IL_685;
				case 42:
					goto IL_3EF;
				case 43:
					goto IL_CDC;
				case 44:
					goto IL_C6D;
				case 45:
					goto IL_2F3;
				case 46:
					goto IL_492;
				case 47:
					goto IL_803;
				case 48:
					goto IL_420;
				case 49:
					goto IL_386;
				case 50:
					goto IL_62D;
				case 51:
					goto IL_5C8;
				case 52:
					goto IL_4B9;
				case 53:
					goto IL_4C6;
				case 54:
					goto IL_D50;
				case 55:
					goto IL_AF1;
				case 56:
					goto IL_A4B;
				case 57:
					goto IL_4AC;
				case 58:
					goto IL_CCF;
				case 59:
					goto IL_E56;
				case 60:
					goto IL_485;
				case 61:
					goto IL_9DC;
				case 62:
					goto IL_B91;
				case 63:
					goto IL_B9E;
				case 64:
					goto IL_528;
				case 65:
					goto IL_8BD;
				case 66:
					goto IL_69F;
				case 67:
					goto IL_949;
				case 68:
					goto IL_542;
				case 69:
					goto IL_85B;
				case 70:
					goto IL_A58;
				case 71:
					goto IL_732;
				case 72:
					goto IL_45E;
				case 73:
					goto IL_46B;
				case 74:
					goto IL_D5D;
				case 75:
					goto IL_B53;
				case 76:
					goto IL_93C;
				case 77:
					goto IL_70E;
				case 78:
					goto IL_756;
				case 79:
					goto IL_3C4;
				case 80:
					goto IL_7B8;
				case 81:
					goto IL_D84;
				case 82:
					goto IL_BB8;
				case 83:
					goto IL_794;
				case 84:
					goto IL_51B;
				case 85:
					goto IL_92F;
				case 86:
					goto IL_C91;
				case 87:
					goto IL_956;
				case 88:
					goto IL_B46;
				case 89:
					goto IL_4D3;
				case 90:
					goto IL_DC2;
				case 91:
					goto IL_8CA;
				case 92:
					goto IL_C53;
				case 93:
					goto IL_A03;
				case 94:
					goto IL_763;
				case 95:
					goto IL_6AC;
				case 96:
					goto IL_E70;
				case 97:
					goto IL_7F6;
				case 98:
					goto IL_2E6;
				case 99:
					goto IL_6EA;
				case 100:
					goto IL_922;
				case 101:
					goto IL_362;
				case 102:
					goto IL_7C5;
				case 103:
					goto IL_692;
				case 104:
					goto IL_D77;
				case 105:
					goto IL_609;
				case 106:
					goto IL_A99;
				case 107:
					goto IL_D12;
				case 108:
					goto IL_A72;
				case 109:
					goto IL_478;
				case 110:
					goto IL_9CF;
				case 111:
					goto IL_8B0;
				case 112:
					goto IL_9AB;
				case 113:
					goto IL_C46;
				case 114:
					goto IL_8A3;
				case 115:
					goto IL_331;
				case 116:
					goto IL_87F;
				case 117:
					goto IL_2D9;
				case 118:
					goto IL_AA6;
				case 119:
					goto IL_A8C;
				case 120:
					goto IL_B15;
				case 121:
					goto IL_9F6;
				case 122:
					goto IL_A65;
				case 123:
					goto IL_6DD;
				case 124:
					goto IL_535;
				case 125:
					goto IL_65E;
				case 126:
					goto IL_8D7;
				case 127:
					goto IL_AB3;
				case 128:
					goto IL_A27;
				case 129:
					goto IL_5E2;
				case 130:
					goto IL_7D2;
				case 131:
					goto IL_451;
				case 132:
					goto IL_B84;
				case 133:
					goto IL_C2C;
				case 134:
					goto IL_300;
				case 135:
					goto IL_49F;
				case 136:
					goto IL_E7D;
				case 137:
					goto IL_651;
				case 138:
					goto IL_66B;
				case 139:
					goto IL_99E;
				case 140:
					goto IL_9E9;
				case 141:
					goto IL_54F;
				case 142:
					goto IL_678;
				case 143:
					goto IL_393;
				case 144:
					goto IL_EA1;
				case 145:
					goto IL_D6A;
				case 146:
					goto IL_444;
				case 147:
					goto IL_C39;
				case 148:
					goto IL_355;
				case 149:
					goto IL_5BB;
				case 150:
					goto IL_770;
				case 151:
					goto IL_A7F;
				case 152:
					goto IL_C9E;
				case 153:
					goto IL_AC0;
				case 154:
					goto IL_D43;
				case 155:
					goto IL_C60;
				case 156:
					goto IL_B22;
				case 157:
					goto IL_D36;
				case 158:
					goto IL_3A0;
				case 159:
					goto IL_CC2;
				case 160:
					goto IL_DCF;
				case 161:
					goto IL_BAB;
				default:
					num = (short)1420558338;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_2D9:
			this.RTDBtnRadErgoControlO7MFKButtonPress_A42218 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2E6:
			this.RadErgCtrlHeadO7DataButtonTrkBCO_A41298Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2F3:
			this.RTDBtnCHO7EmergencyButtonBCO_A41290 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_300:
			this.RadErgoControlO7MFKFeatureAssignment_A41295 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoControlO7MFKFeatureAssignment_A41295.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_324:
			this.CHO7EmergencyButtonFeature_A41291_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_331:
			this.LblRadErgoControlO7MFKButtonPress_A42218 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoControlO7MFKButtonPress_A42218.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_355:
			this.ExpanderControlHeadO7O7NavigationControlsTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_362:
			this.LblRadErgCtrlHeadO7DataButtonTrkFeature_A41297 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgCtrlHeadO7DataButtonTrkFeature_A41297.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_386:
			this.CVBtnCHO7EmergencyButtonFeature_A41291 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_393:
			this.ExpanderControlHeadO7O7NavigationControlsTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_3A0:
			this.LblRadErgoControlO7UpDownButton_A41293 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoControlO7UpDownButton_A41293.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3C4:
			this.CpyBtnRadErgCtrlHeadO7DataButtonCnvBCO_A41300 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3EA:
			goto IL_EAE;
			IL_3EF:
			this.CHO7EmergencyButtonBCO_A41290 = (global::AcpUI.AcpComboBox)target;
			this.CHO7EmergencyButtonBCO_A41290.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_413:
			this.CVBtnCHO7EmergencyButtonName_A41289 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_420:
			this.CHO7EmergencyButtonFeature_A41291 = (global::AcpUI.AcpComboBox)target;
			this.CHO7EmergencyButtonFeature_A41291.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_444:
			this.O7UpDownButtonName_A41292_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_451:
			this.RTDBtnO7MFKAssignmentControlName_A41294 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_45E:
			this.RTDBtnRadErgCtrlHeadO7DataButtonName_A41296 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_46B:
			this.CpyBtnRadErgCtrlHeadO7DataButtonName_A41296 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_478:
			this.CpyBtnCHO7DataButtonTrkIndex_A41418 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_485:
			this.RadErgCtrlHeadO7DataButtonName_A41296_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_492:
			this.CpyBtnCHO7EmergencyButtonBCO_A41290 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_49F:
			this.CVBtnRadErgoControlO7MFKFeatureAssignment_A41295 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4AC:
			this.ExpanderControlHeadO7O7DataButtonTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_4B9:
			this.CpyBtnCHO7EmergencyButtonFeature_A41291 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4C6:
			this.CHO7EmergencyButtonFeature_A41291Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4D3:
			this.LblCHO7DataButtonConvIndex_A41417 = (global::AcpUI.AcpLabel)target;
			this.LblCHO7DataButtonConvIndex_A41417.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4F7:
			this.HLinkO7GeneralExpander = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkO7GeneralExpander.Click += this.HLinkClick;
			return;
			IL_51B:
			this.RTDBtnRadErgCtrlHeadO7DataButtonCnvFeature_A41299 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_528:
			this.RadErgCtrlHeadO7DataButtonTrkBCO_A41298_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_535:
			this.O7MFKAssignmentControlName_A41294_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_542:
			this.gridExpanderControlHeadO7O7DataButtonTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_54F:
			this.RecNavToolbarExpanderControlHeadO7O7NavigationControlsTable = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderControlHeadO7O7NavigationControlsTable.ModeClick += this.OnModeClick;
			return;
			IL_573:
			this.CHO7EmergencyButtonName_A41289 = (global::AcpUI.AcpLabel)target;
			this.CHO7EmergencyButtonName_A41289.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_597:
			this.HLinkControlHeadO7GraphicalView = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkControlHeadO7GraphicalView.Click += this.HLinkClick;
			return;
			IL_5BB:
			this.gridExpanderControlHeadO7O7NavigationControlsTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_5C8:
			this.RTDBtnCHO7EmergencyButtonFeature_A41291 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5D5:
			this.gridExpanderControlHeadO7O7SRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_5E2:
			this.CVBtnO7MFKAssignmentControlName_A41294 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5EF:
			this.ExpanderControlHeadO7O7GeneralExpander = (global::AcpUI.AcpExpander)target;
			return;
			IL_5FC:
			this.RTDBtnCHO7EmergencyButtonName_A41289 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_609:
			this.CHO7DataButtonTrkIndex_A41418 = (global::AcpUI.AcpComboBox)target;
			this.CHO7DataButtonTrkIndex_A41418.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_62D:
			this.LblCHO7EmergencyButtonFeature_A41291 = (global::AcpUI.AcpLabel)target;
			this.LblCHO7EmergencyButtonFeature_A41291.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_651:
			this.RTDBtnRadErgoControlO7MFKFeatureAssignment_A41295 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_65E:
			this.RadErgoControlO7MFKFeatureAssignment_A41295_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_66B:
			this.CpyBtnRadErgoControlO7MFKFeatureAssignment_A41295 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_678:
			this.ExpanderControlHeadO7O7NavigationControlsExpanderGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_685:
			this.CHO7EmergencyButtonName_A41289Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_692:
			this.CpyBtnRadErgCtrlHeadO7DataButtonTrkFeature_A41297 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_69F:
			this.CHO7DataButtonTrkIndex_A41418_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_6AC:
			this.LblRadErgCtrlHeadO7DataButtonTrkBCO_A41298 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgCtrlHeadO7DataButtonTrkBCO_A41298.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_6D0:
			this.CHO7EmergencyButtonBCO_A41290_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_6DD:
			this.ExpanderControlHeadO7O7MFKAssignmentControl = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_6EA:
			this.RadErgCtrlHeadO7DataButtonTrkFeature_A41297 = (global::AcpUI.AcpComboBox)target;
			this.RadErgCtrlHeadO7DataButtonTrkFeature_A41297.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_70E:
			this.LblRadErgCtrlHeadO7DataButtonCnvBCO_A41300 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgCtrlHeadO7DataButtonCnvBCO_A41300.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_732:
			this.LblRadErgCtrlHeadO7DataButtonName_A41296 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgCtrlHeadO7DataButtonName_A41296.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_756:
			this.RTDBtnRadErgCtrlHeadO7DataButtonCnvBCO_A41300 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_763:
			this.CVBtnRadErgCtrlHeadO7DataButtonTrkBCO_A41298 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_770:
			this.O7UpDownButtonName_A41292 = (global::AcpUI.AcpLabel)target;
			this.O7UpDownButtonName_A41292.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_794:
			this.LblRadErgCtrlHeadO7DataButtonCnvFeature_A41299 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgCtrlHeadO7DataButtonCnvFeature_A41299.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_7B8:
			this.RadErgCtrlHeadO7DataButtonCnvBCO_A41300Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_7C5:
			this.RTDBtnRadErgCtrlHeadO7DataButtonTrkFeature_A41297 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_7D2:
			this.LblO7MFKAssignmentControlName_A41294 = (global::AcpUI.AcpLabel)target;
			this.LblO7MFKAssignmentControlName_A41294.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_7F6:
			this.CpyBtnRadErgCtrlHeadO7DataButtonTrkBCO_A41298 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_803:
			this.CHO7EmergencyButtonBCO_A41290Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_810:
			this.ExpanderControlHeadO7O7GeneralExpanderGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_81D:
			this.CHO7EmergencyButtonName_A41289_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_82A:
			this.HLinkO7DataButton = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkO7DataButton.Click += this.HLinkClick;
			return;
			IL_84E:
			this.ExpanderControlHeadO7O7SRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_85B:
			this.RadErgCtrlHeadO7DataButtonName_A41296 = (global::AcpUI.AcpLabel)target;
			this.RadErgCtrlHeadO7DataButtonName_A41296.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_87F:
			this.RadErgoControlO7MFKButtonPress_A42218 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoControlO7MFKButtonPress_A42218.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_8A3:
			this.CVBtnRadErgoControlO7MFKButtonPress_A42218 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_8B0:
			this.ExpanderControlHeadO7O7MultiFunctionKnob = (global::AcpUI.AcpExpander)target;
			return;
			IL_8BD:
			this.RadErgCtrlHeadO7DataButtonTrkFeature_A41297_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_8CA:
			this.CpyBtnCHO7DataButtonConvIndex_A41417 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_8D7:
			this.ExpanderControlHeadO7O7MFKAssignmentControlSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_8E4:
			((global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.PageControlHeadO7)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.PageControlHeadO7)target).Unloaded += this.OnUnloaded;
			return;
			IL_915:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_922:
			this.CVBtnRadErgCtrlHeadO7DataButtonTrkFeature_A41297 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_92F:
			this.CpyBtnRadErgCtrlHeadO7DataButtonCnvFeature_A41299 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_93C:
			this.CVBtnRadErgCtrlHeadO7DataButtonCnvBCO_A41300 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_949:
			this.ExpanderControlHeadO7O7DataButtonTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_956:
			this.CHO7DataButtonConvIndex_A41417 = (global::AcpUI.AcpComboBox)target;
			this.CHO7DataButtonConvIndex_A41417.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_97A:
			this.LblCHO7EmergencyButtonName_A41289 = (global::AcpUI.AcpLabel)target;
			this.LblCHO7EmergencyButtonName_A41289.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_99E:
			this.RadErgoControlO7MFKFeatureAssignment_A41295Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_9AB:
			this.RecNavToolbarExpanderControlHeadO7O7MFKAssignmentControl = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderControlHeadO7O7MFKAssignmentControl.ModeClick += this.OnModeClick;
			return;
			IL_9CF:
			this.CHO7DataButtonTrkIndex_A41418Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_9DC:
			this.RadErgCtrlHeadO7DataButtonCnvBCO_A41300_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_9E9:
			this.ExpanderControlHeadO7O7NavigationControlsExpander = (global::AcpUI.AcpExpander)target;
			return;
			IL_9F6:
			this.ExpanderControlHeadO7O7MFKAssignmentControlGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_A03:
			this.RadErgCtrlHeadO7DataButtonTrkBCO_A41298 = (global::AcpUI.AcpComboBox)target;
			this.RadErgCtrlHeadO7DataButtonTrkBCO_A41298.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_A27:
			this.O7MFKAssignmentControlName_A41294 = (global::AcpUI.AcpLabel)target;
			this.O7MFKAssignmentControlName_A41294.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_A4B:
			this.ExpanderControlHeadO7O7DataButtonGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_A58:
			this.CVBtnRadErgCtrlHeadO7DataButtonName_A41296 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A65:
			this.ExpanderControlHeadO7O7MFKAssignmentControlTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_A72:
			this.RTDBtnCHO7DataButtonTrkIndex_A41418 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A7F:
			this.CVBtnO7UpDownButtonName_A41292 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A8C:
			this.RadErgoControlO7MFKButtonPress_A42218Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_A99:
			this.CVBtnCHO7DataButtonTrkIndex_A41418 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_AA6:
			this.CpyBtnRadErgoControlO7MFKButtonPress_A42218 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_AB3:
			this.gridExpanderControlHeadO7O7MFKAssignmentControlSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_AC0:
			this.RTDBtnO7UpDownButtonName_A41292 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_ACD:
			this.HLinkO7NavigationControlsExpander = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkO7NavigationControlsExpander.Click += this.HLinkClick;
			return;
			IL_AF1:
			this.RecNavToolbarExpanderControlHeadO7O7DataButtonTable = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderControlHeadO7O7DataButtonTable.ModeClick += this.OnModeClick;
			return;
			IL_B15:
			this.ExpanderControlHeadO7O7MultiFunctionKnobGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_B22:
			this.RadErgoControlO7UpDownButton_A41293 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoControlO7UpDownButton_A41293.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B46:
			this.CVBtnCHO7DataButtonConvIndex_A41417 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B53:
			this.RadErgCtrlHeadO7DataButtonCnvBCO_A41300 = (global::AcpUI.AcpComboBox)target;
			this.RadErgCtrlHeadO7DataButtonCnvBCO_A41300.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B77:
			this.myO7GraphicView = (global::ControlHeadGraphicView.O7GraphicView)target;
			return;
			IL_B84:
			this.CpyBtnO7MFKAssignmentControlName_A41294 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B91:
			this.RadErgCtrlHeadO7DataButtonCnvFeature_A41299_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_B9E:
			this.CHO7DataButtonConvIndex_A41417_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_BAB:
			this.RadErgoControlO7UpDownButton_A41293Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_BB8:
			this.CVBtnRadErgCtrlHeadO7DataButtonCnvFeature_A41299 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_BC5:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_BD2:
			this.RecNavToolbarExpanderControlHeadO7O7 = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderControlHeadO7O7.ModeClick += this.OnModeClick;
			return;
			IL_BF6:
			num = (short)600965120;
			short num3 = num;
			this.ExpanderControlHeadO7O7 = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_C2C:
			this.O7MFKAssignmentControlName_A41294Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_C39:
			this.RadErgoControlO7UpDownButton_A41293_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_C46:
			this.GrpBoxExpanderControlHeadO7O7MultiFunctionKnobPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_C53:
			this.CHO7DataButtonConvIndex_A41417Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_C60:
			this.O7UpDownButtonName_A41292Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_C6D:
			this.LblCHO7EmergencyButtonBCO_A41290 = (global::AcpUI.AcpLabel)target;
			this.LblCHO7EmergencyButtonBCO_A41290.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_C91:
			this.RadErgCtrlHeadO7DataButtonCnvFeature_A41299Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_C9E:
			this.LblO7UpDownButtonName_A41292 = (global::AcpUI.AcpLabel)target;
			this.LblO7UpDownButtonName_A41292.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_CC2:
			this.RTDBtnRadErgoControlO7UpDownButton_A41293 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_CCF:
			this.ExpanderControlHeadO7O7DataButtonTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_CDC:
			num = (short)1475411969;
			if (num != 0)
			{
			}
			this.CVBtnCHO7EmergencyButtonBCO_A41290 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_D12:
			this.LblCHO7DataButtonTrkIndex_A41418 = (global::AcpUI.AcpLabel)target;
			this.LblCHO7DataButtonTrkIndex_A41418.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_D36:
			this.CVBtnRadErgoControlO7UpDownButton_A41293 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_D43:
			this.CpyBtnO7UpDownButtonName_A41292 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_D50:
			this.ExpanderControlHeadO7O7DataButton = (global::AcpUI.AcpExpander)target;
			return;
			IL_D5D:
			this.RadErgCtrlHeadO7DataButtonName_A41296Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_D6A:
			this.ExpanderControlHeadO7O7NavigationControlsTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_D77:
			this.RadErgCtrlHeadO7DataButtonTrkFeature_A41297Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_D84:
			this.RadErgCtrlHeadO7DataButtonCnvFeature_A41299 = (global::AcpUI.AcpComboBox)target;
			this.RadErgCtrlHeadO7DataButtonCnvFeature_A41299.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_DA8:
			this.ExpanderControlHeadO7O7TableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_DB5:
			this.ExpanderControlHeadO7GraphicalView = (global::AcpUI.AcpExpander)target;
			return;
			IL_DC2:
			this.RTDBtnCHO7DataButtonConvIndex_A41417 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_DCF:
			num = (short)990001718;
			short num4 = num;
			num = (short)662059574;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_EA1:
				this.ExpanderControlHeadO7O7NavigationControlsTableTableView = (global::AcpUI.AcpGroupBox)target;
				return;
			default:
				num = (short)1378156544;
				if (num != 0)
				{
				}
				this.CpyBtnRadErgoControlO7UpDownButton_A41293 = (global::AcpUI.AcpCopyButton)target;
				return;
			}
			IL_E25:
			this.HLinkO7MultiFunctionKnob = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkO7MultiFunctionKnob.Click += this.HLinkClick;
			return;
			IL_E49:
			this.ExpanderControlHeadO7O7Grid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_E56:
			this.ExpanderControlHeadO7O7DataButtonTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_E63:
			this.CpyBtnCHO7EmergencyButtonName_A41289 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_E70:
			this.RTDBtnRadErgCtrlHeadO7DataButtonTrkBCO_A41298 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_E7D:
			this.LblRadErgoControlO7MFKFeatureAssignment_A41295 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoControlO7MFKFeatureAssignment_A41295.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_EAE:
			this.b = true;
		}

		// Token: 0x060086B0 RID: 34480 RVA: 0x007D8E18 File Offset: 0x007D7018
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 2:
				((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 3:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 4:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 5:
				((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 6:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 7:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 8:
			{
				short num = (short)521863169;
				if (num != 0)
				{
				}
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			case 9:
				break;
			case 10:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 11:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 12:
				((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 13:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 14:
				((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 15:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			default:
			{
				short num = (short)746520576;
				short num2 = num;
				num = (short)201961281;
				short num3 = num;
				num = (short)1123987265;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)260112384;
					if (num != 0)
					{
					}
					return;
				}
				break;
			}
			}
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x04003E96 RID: 16022
		private bool a;

		// Token: 0x04003E97 RID: 16023
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x04003E98 RID: 16024
		internal global::System.Windows.Documents.Hyperlink HLinkControlHeadO7GraphicalView;

		// Token: 0x04003E99 RID: 16025
		internal global::System.Windows.Documents.Hyperlink HLinkO7GeneralExpander;

		// Token: 0x04003E9A RID: 16026
		internal global::System.Windows.Documents.Hyperlink HLinkO7DataButton;

		// Token: 0x04003E9B RID: 16027
		internal global::System.Windows.Documents.Hyperlink HLinkO7MultiFunctionKnob;

		// Token: 0x04003E9C RID: 16028
		internal global::System.Windows.Documents.Hyperlink HLinkO7NavigationControlsExpander;

		// Token: 0x04003E9D RID: 16029
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x04003E9E RID: 16030
		internal global::AcpUI.AcpExpander ExpanderControlHeadO7GraphicalView;

		// Token: 0x04003E9F RID: 16031
		internal global::ControlHeadGraphicView.O7GraphicView myO7GraphicView;

		// Token: 0x04003EA0 RID: 16032
		internal global::AcpUI.AcpExpander ExpanderControlHeadO7O7GeneralExpander;

		// Token: 0x04003EA1 RID: 16033
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderControlHeadO7O7;

		// Token: 0x04003EA2 RID: 16034
		internal global::System.Windows.Controls.Grid ExpanderControlHeadO7O7GeneralExpanderGrid;

		// Token: 0x04003EA3 RID: 16035
		internal global::System.Windows.Controls.Grid ExpanderControlHeadO7O7Grid;

		// Token: 0x04003EA4 RID: 16036
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadO7O7TableView;

		// Token: 0x04003EA5 RID: 16037
		internal global::AcpUI.AcpXamDataPresenter ExpanderControlHeadO7O7;

		// Token: 0x04003EA6 RID: 16038
		internal global::Infragistics.Windows.DataPresenter.UnboundField CHO7EmergencyButtonName_A41289_Col;

		// Token: 0x04003EA7 RID: 16039
		internal global::Infragistics.Windows.DataPresenter.UnboundField CHO7EmergencyButtonBCO_A41290_Col;

		// Token: 0x04003EA8 RID: 16040
		internal global::Infragistics.Windows.DataPresenter.UnboundField CHO7EmergencyButtonFeature_A41291_Col;

		// Token: 0x04003EA9 RID: 16041
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadO7O7SRecView;

		// Token: 0x04003EAA RID: 16042
		internal global::System.Windows.Controls.Grid gridExpanderControlHeadO7O7SRecView;

		// Token: 0x04003EAB RID: 16043
		internal global::AcpUI.AcpLabel CHO7EmergencyButtonName_A41289;

		// Token: 0x04003EAC RID: 16044
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCHO7EmergencyButtonName_A41289;

		// Token: 0x04003EAD RID: 16045
		internal global::AcpUI.AcpLabel LblCHO7EmergencyButtonName_A41289;

		// Token: 0x04003EAE RID: 16046
		internal global::AcpUI.AcpRtdButton RTDBtnCHO7EmergencyButtonName_A41289;

		// Token: 0x04003EAF RID: 16047
		internal global::AcpUI.AcpCopyButton CpyBtnCHO7EmergencyButtonName_A41289;

		// Token: 0x04003EB0 RID: 16048
		internal global::AcpUI.AcpLabel CHO7EmergencyButtonName_A41289Comp;

		// Token: 0x04003EB1 RID: 16049
		internal global::AcpUI.AcpComboBox CHO7EmergencyButtonBCO_A41290;

		// Token: 0x04003EB2 RID: 16050
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCHO7EmergencyButtonBCO_A41290;

		// Token: 0x04003EB3 RID: 16051
		internal global::AcpUI.AcpLabel LblCHO7EmergencyButtonBCO_A41290;

		// Token: 0x04003EB4 RID: 16052
		internal global::AcpUI.AcpRtdButton RTDBtnCHO7EmergencyButtonBCO_A41290;

		// Token: 0x04003EB5 RID: 16053
		internal global::AcpUI.AcpCopyButton CpyBtnCHO7EmergencyButtonBCO_A41290;

		// Token: 0x04003EB6 RID: 16054
		internal global::AcpUI.AcpLabel CHO7EmergencyButtonBCO_A41290Comp;

		// Token: 0x04003EB7 RID: 16055
		internal global::AcpUI.AcpComboBox CHO7EmergencyButtonFeature_A41291;

		// Token: 0x04003EB8 RID: 16056
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCHO7EmergencyButtonFeature_A41291;

		// Token: 0x04003EB9 RID: 16057
		internal global::AcpUI.AcpLabel LblCHO7EmergencyButtonFeature_A41291;

		// Token: 0x04003EBA RID: 16058
		internal global::AcpUI.AcpRtdButton RTDBtnCHO7EmergencyButtonFeature_A41291;

		// Token: 0x04003EBB RID: 16059
		internal global::AcpUI.AcpCopyButton CpyBtnCHO7EmergencyButtonFeature_A41291;

		// Token: 0x04003EBC RID: 16060
		internal global::AcpUI.AcpLabel CHO7EmergencyButtonFeature_A41291Comp;

		// Token: 0x04003EBD RID: 16061
		internal global::AcpUI.AcpExpander ExpanderControlHeadO7O7DataButton;

		// Token: 0x04003EBE RID: 16062
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderControlHeadO7O7DataButtonTable;

		// Token: 0x04003EBF RID: 16063
		internal global::System.Windows.Controls.Grid ExpanderControlHeadO7O7DataButtonGrid;

		// Token: 0x04003EC0 RID: 16064
		internal global::System.Windows.Controls.Grid ExpanderControlHeadO7O7DataButtonTableGrid;

		// Token: 0x04003EC1 RID: 16065
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadO7O7DataButtonTableTableView;

		// Token: 0x04003EC2 RID: 16066
		internal global::AcpUI.AcpXamDataPresenter ExpanderControlHeadO7O7DataButtonTable;

		// Token: 0x04003EC3 RID: 16067
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgCtrlHeadO7DataButtonName_A41296_Col;

		// Token: 0x04003EC4 RID: 16068
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgCtrlHeadO7DataButtonCnvBCO_A41300_Col;

		// Token: 0x04003EC5 RID: 16069
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgCtrlHeadO7DataButtonCnvFeature_A41299_Col;

		// Token: 0x04003EC6 RID: 16070
		internal global::Infragistics.Windows.DataPresenter.UnboundField CHO7DataButtonConvIndex_A41417_Col;

		// Token: 0x04003EC7 RID: 16071
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgCtrlHeadO7DataButtonTrkBCO_A41298_Col;

		// Token: 0x04003EC8 RID: 16072
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgCtrlHeadO7DataButtonTrkFeature_A41297_Col;

		// Token: 0x04003EC9 RID: 16073
		internal global::Infragistics.Windows.DataPresenter.UnboundField CHO7DataButtonTrkIndex_A41418_Col;

		// Token: 0x04003ECA RID: 16074
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadO7O7DataButtonTableSRecView;

		// Token: 0x04003ECB RID: 16075
		internal global::System.Windows.Controls.Grid gridExpanderControlHeadO7O7DataButtonTableSRecView;

		// Token: 0x04003ECC RID: 16076
		internal global::AcpUI.AcpLabel RadErgCtrlHeadO7DataButtonName_A41296;

		// Token: 0x04003ECD RID: 16077
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgCtrlHeadO7DataButtonName_A41296;

		// Token: 0x04003ECE RID: 16078
		internal global::AcpUI.AcpLabel LblRadErgCtrlHeadO7DataButtonName_A41296;

		// Token: 0x04003ECF RID: 16079
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgCtrlHeadO7DataButtonName_A41296;

		// Token: 0x04003ED0 RID: 16080
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgCtrlHeadO7DataButtonName_A41296;

		// Token: 0x04003ED1 RID: 16081
		internal global::AcpUI.AcpLabel RadErgCtrlHeadO7DataButtonName_A41296Comp;

		// Token: 0x04003ED2 RID: 16082
		internal global::AcpUI.AcpComboBox RadErgCtrlHeadO7DataButtonCnvBCO_A41300;

		// Token: 0x04003ED3 RID: 16083
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgCtrlHeadO7DataButtonCnvBCO_A41300;

		// Token: 0x04003ED4 RID: 16084
		internal global::AcpUI.AcpLabel LblRadErgCtrlHeadO7DataButtonCnvBCO_A41300;

		// Token: 0x04003ED5 RID: 16085
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgCtrlHeadO7DataButtonCnvBCO_A41300;

		// Token: 0x04003ED6 RID: 16086
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgCtrlHeadO7DataButtonCnvBCO_A41300;

		// Token: 0x04003ED7 RID: 16087
		internal global::AcpUI.AcpLabel RadErgCtrlHeadO7DataButtonCnvBCO_A41300Comp;

		// Token: 0x04003ED8 RID: 16088
		internal global::AcpUI.AcpComboBox RadErgCtrlHeadO7DataButtonCnvFeature_A41299;

		// Token: 0x04003ED9 RID: 16089
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgCtrlHeadO7DataButtonCnvFeature_A41299;

		// Token: 0x04003EDA RID: 16090
		internal global::AcpUI.AcpLabel LblRadErgCtrlHeadO7DataButtonCnvFeature_A41299;

		// Token: 0x04003EDB RID: 16091
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgCtrlHeadO7DataButtonCnvFeature_A41299;

		// Token: 0x04003EDC RID: 16092
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgCtrlHeadO7DataButtonCnvFeature_A41299;

		// Token: 0x04003EDD RID: 16093
		internal global::AcpUI.AcpLabel RadErgCtrlHeadO7DataButtonCnvFeature_A41299Comp;

		// Token: 0x04003EDE RID: 16094
		internal global::AcpUI.AcpComboBox CHO7DataButtonConvIndex_A41417;

		// Token: 0x04003EDF RID: 16095
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCHO7DataButtonConvIndex_A41417;

		// Token: 0x04003EE0 RID: 16096
		internal global::AcpUI.AcpLabel LblCHO7DataButtonConvIndex_A41417;

		// Token: 0x04003EE1 RID: 16097
		internal global::AcpUI.AcpRtdButton RTDBtnCHO7DataButtonConvIndex_A41417;

		// Token: 0x04003EE2 RID: 16098
		internal global::AcpUI.AcpCopyButton CpyBtnCHO7DataButtonConvIndex_A41417;

		// Token: 0x04003EE3 RID: 16099
		internal global::AcpUI.AcpLabel CHO7DataButtonConvIndex_A41417Comp;

		// Token: 0x04003EE4 RID: 16100
		internal global::AcpUI.AcpComboBox RadErgCtrlHeadO7DataButtonTrkBCO_A41298;

		// Token: 0x04003EE5 RID: 16101
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgCtrlHeadO7DataButtonTrkBCO_A41298;

		// Token: 0x04003EE6 RID: 16102
		internal global::AcpUI.AcpLabel LblRadErgCtrlHeadO7DataButtonTrkBCO_A41298;

		// Token: 0x04003EE7 RID: 16103
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgCtrlHeadO7DataButtonTrkBCO_A41298;

		// Token: 0x04003EE8 RID: 16104
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgCtrlHeadO7DataButtonTrkBCO_A41298;

		// Token: 0x04003EE9 RID: 16105
		internal global::AcpUI.AcpLabel RadErgCtrlHeadO7DataButtonTrkBCO_A41298Comp;

		// Token: 0x04003EEA RID: 16106
		internal global::AcpUI.AcpComboBox RadErgCtrlHeadO7DataButtonTrkFeature_A41297;

		// Token: 0x04003EEB RID: 16107
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgCtrlHeadO7DataButtonTrkFeature_A41297;

		// Token: 0x04003EEC RID: 16108
		internal global::AcpUI.AcpLabel LblRadErgCtrlHeadO7DataButtonTrkFeature_A41297;

		// Token: 0x04003EED RID: 16109
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgCtrlHeadO7DataButtonTrkFeature_A41297;

		// Token: 0x04003EEE RID: 16110
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgCtrlHeadO7DataButtonTrkFeature_A41297;

		// Token: 0x04003EEF RID: 16111
		internal global::AcpUI.AcpLabel RadErgCtrlHeadO7DataButtonTrkFeature_A41297Comp;

		// Token: 0x04003EF0 RID: 16112
		internal global::AcpUI.AcpComboBox CHO7DataButtonTrkIndex_A41418;

		// Token: 0x04003EF1 RID: 16113
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCHO7DataButtonTrkIndex_A41418;

		// Token: 0x04003EF2 RID: 16114
		internal global::AcpUI.AcpLabel LblCHO7DataButtonTrkIndex_A41418;

		// Token: 0x04003EF3 RID: 16115
		internal global::AcpUI.AcpRtdButton RTDBtnCHO7DataButtonTrkIndex_A41418;

		// Token: 0x04003EF4 RID: 16116
		internal global::AcpUI.AcpCopyButton CpyBtnCHO7DataButtonTrkIndex_A41418;

		// Token: 0x04003EF5 RID: 16117
		internal global::AcpUI.AcpLabel CHO7DataButtonTrkIndex_A41418Comp;

		// Token: 0x04003EF6 RID: 16118
		internal global::AcpUI.AcpExpander ExpanderControlHeadO7O7MultiFunctionKnob;

		// Token: 0x04003EF7 RID: 16119
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderControlHeadO7O7MFKAssignmentControl;

		// Token: 0x04003EF8 RID: 16120
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderControlHeadO7O7MultiFunctionKnobPseudo0;

		// Token: 0x04003EF9 RID: 16121
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoControlO7MFKButtonPress_A42218;

		// Token: 0x04003EFA RID: 16122
		internal global::AcpUI.AcpLabel LblRadErgoControlO7MFKButtonPress_A42218;

		// Token: 0x04003EFB RID: 16123
		internal global::AcpUI.AcpComboBox RadErgoControlO7MFKButtonPress_A42218;

		// Token: 0x04003EFC RID: 16124
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoControlO7MFKButtonPress_A42218;

		// Token: 0x04003EFD RID: 16125
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoControlO7MFKButtonPress_A42218;

		// Token: 0x04003EFE RID: 16126
		internal global::AcpUI.AcpLabel RadErgoControlO7MFKButtonPress_A42218Comp;

		// Token: 0x04003EFF RID: 16127
		internal global::System.Windows.Controls.Grid ExpanderControlHeadO7O7MultiFunctionKnobGrid;

		// Token: 0x04003F00 RID: 16128
		internal global::System.Windows.Controls.Grid ExpanderControlHeadO7O7MFKAssignmentControlGrid;

		// Token: 0x04003F01 RID: 16129
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadO7O7MFKAssignmentControlTableView;

		// Token: 0x04003F02 RID: 16130
		internal global::AcpUI.AcpXamDataPresenter ExpanderControlHeadO7O7MFKAssignmentControl;

		// Token: 0x04003F03 RID: 16131
		internal global::Infragistics.Windows.DataPresenter.UnboundField O7MFKAssignmentControlName_A41294_Col;

		// Token: 0x04003F04 RID: 16132
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoControlO7MFKFeatureAssignment_A41295_Col;

		// Token: 0x04003F05 RID: 16133
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadO7O7MFKAssignmentControlSRecView;

		// Token: 0x04003F06 RID: 16134
		internal global::System.Windows.Controls.Grid gridExpanderControlHeadO7O7MFKAssignmentControlSRecView;

		// Token: 0x04003F07 RID: 16135
		internal global::AcpUI.AcpLabel O7MFKAssignmentControlName_A41294;

		// Token: 0x04003F08 RID: 16136
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnO7MFKAssignmentControlName_A41294;

		// Token: 0x04003F09 RID: 16137
		internal global::AcpUI.AcpLabel LblO7MFKAssignmentControlName_A41294;

		// Token: 0x04003F0A RID: 16138
		internal global::AcpUI.AcpRtdButton RTDBtnO7MFKAssignmentControlName_A41294;

		// Token: 0x04003F0B RID: 16139
		internal global::AcpUI.AcpCopyButton CpyBtnO7MFKAssignmentControlName_A41294;

		// Token: 0x04003F0C RID: 16140
		internal global::AcpUI.AcpLabel O7MFKAssignmentControlName_A41294Comp;

		// Token: 0x04003F0D RID: 16141
		internal global::AcpUI.AcpComboBox RadErgoControlO7MFKFeatureAssignment_A41295;

		// Token: 0x04003F0E RID: 16142
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoControlO7MFKFeatureAssignment_A41295;

		// Token: 0x04003F0F RID: 16143
		internal global::AcpUI.AcpLabel LblRadErgoControlO7MFKFeatureAssignment_A41295;

		// Token: 0x04003F10 RID: 16144
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoControlO7MFKFeatureAssignment_A41295;

		// Token: 0x04003F11 RID: 16145
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoControlO7MFKFeatureAssignment_A41295;

		// Token: 0x04003F12 RID: 16146
		internal global::AcpUI.AcpLabel RadErgoControlO7MFKFeatureAssignment_A41295Comp;

		// Token: 0x04003F13 RID: 16147
		internal global::AcpUI.AcpExpander ExpanderControlHeadO7O7NavigationControlsExpander;

		// Token: 0x04003F14 RID: 16148
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderControlHeadO7O7NavigationControlsTable;

		// Token: 0x04003F15 RID: 16149
		internal global::System.Windows.Controls.Grid ExpanderControlHeadO7O7NavigationControlsExpanderGrid;

		// Token: 0x04003F16 RID: 16150
		internal global::System.Windows.Controls.Grid ExpanderControlHeadO7O7NavigationControlsTableGrid;

		// Token: 0x04003F17 RID: 16151
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadO7O7NavigationControlsTableTableView;

		// Token: 0x04003F18 RID: 16152
		internal global::AcpUI.AcpXamDataPresenter ExpanderControlHeadO7O7NavigationControlsTable;

		// Token: 0x04003F19 RID: 16153
		internal global::Infragistics.Windows.DataPresenter.UnboundField O7UpDownButtonName_A41292_Col;

		// Token: 0x04003F1A RID: 16154
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoControlO7UpDownButton_A41293_Col;

		// Token: 0x04003F1B RID: 16155
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadO7O7NavigationControlsTableSRecView;

		// Token: 0x04003F1C RID: 16156
		internal global::System.Windows.Controls.Grid gridExpanderControlHeadO7O7NavigationControlsTableSRecView;

		// Token: 0x04003F1D RID: 16157
		internal global::AcpUI.AcpLabel O7UpDownButtonName_A41292;

		// Token: 0x04003F1E RID: 16158
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnO7UpDownButtonName_A41292;

		// Token: 0x04003F1F RID: 16159
		internal global::AcpUI.AcpLabel LblO7UpDownButtonName_A41292;

		// Token: 0x04003F20 RID: 16160
		internal global::AcpUI.AcpRtdButton RTDBtnO7UpDownButtonName_A41292;

		// Token: 0x04003F21 RID: 16161
		internal global::AcpUI.AcpCopyButton CpyBtnO7UpDownButtonName_A41292;

		// Token: 0x04003F22 RID: 16162
		internal global::AcpUI.AcpLabel O7UpDownButtonName_A41292Comp;

		// Token: 0x04003F23 RID: 16163
		internal global::AcpUI.AcpComboBox RadErgoControlO7UpDownButton_A41293;

		// Token: 0x04003F24 RID: 16164
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoControlO7UpDownButton_A41293;

		// Token: 0x04003F25 RID: 16165
		internal global::AcpUI.AcpLabel LblRadErgoControlO7UpDownButton_A41293;

		// Token: 0x04003F26 RID: 16166
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoControlO7UpDownButton_A41293;

		// Token: 0x04003F27 RID: 16167
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoControlO7UpDownButton_A41293;

		// Token: 0x04003F28 RID: 16168
		internal global::AcpUI.AcpLabel RadErgoControlO7UpDownButton_A41293Comp;

		// Token: 0x04003F29 RID: 16169
		private bool b;
	}
}
