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

namespace Motorola.MackinawCPS.CoreFeatures.Shepherds
{
	// Token: 0x020001DE RID: 478
	public class PageShepherds : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x06005411 RID: 21521 RVA: 0x004C4134 File Offset: 0x004C2334
		public PageShepherds()
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

		// Token: 0x06005412 RID: 21522 RVA: 0x004C416C File Offset: 0x004C236C
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1480196096;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)826212367;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					object obj;
					global::AcpUI.AcpExpander acpExpander;
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						goto IL_489;
					case 1:
						if (obj != null)
						{
							num = (short)1368653840;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_66D;
					case 2:
						if (obj != null)
						{
							num = (short)1998258198;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4E5;
					case 3:
					{
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderShepherdsConventionalShepherdList.MyDataPresenter = this.ExpanderShepherdsConventionalShepherdList;
						num = (short)861143047;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_576;
					case 5:
						goto IL_4E5;
					case 6:
						goto IL_66D;
					case 7:
						goto IL_3FB;
					case 8:
						goto IL_D5;
					case 9:
						if (obj != null)
						{
							num = (short)1631387672;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_576;
					case 10:
						if (obj != null)
						{
							num = (short)2061631491;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3FB;
					case 11:
						if (obj != null)
						{
							num = (short)1560084503;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_445;
					case 12:
						obj = null;
						obj = this.RecNavToolbarExpanderShepherdsConventionalProductIndependentButtonList.MyRecordsetDataSource;
						num = (short)206110729;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_445;
					case 14:
					{
						num = (short)1066401793;
						if (num != 0)
						{
						}
						global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderShepherdsSignalIndependentProductIndependentNonProgrammableButtonList.MyDataPresenter = this.ExpanderShepherdsSignalIndependentProductIndependentNonProgrammableButtonList;
						num = (short)879230984;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						switch (0)
						{
						case 0:
							goto IL_AB;
						}
						continue;
					case 16:
					{
						global::System.Windows.Data.CollectionView collectionView3 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderShepherdsTrunkingShepherdList.MyDataPresenter = this.ExpanderShepherdsTrunkingShepherdList;
						num = (short)234160134;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
					{
						global::System.Windows.Data.CollectionView collectionView4 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderShepherdsSignalIndependentProductIndependentProgrammableButtonList.MyDataPresenter = this.ExpanderShepherdsSignalIndependentProductIndependentProgrammableButtonList;
						num = (short)586678272;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						if (obj != null)
						{
							num = (short)681902094;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D5;
					case 19:
						if (obj != null)
						{
							num = (short)1990721553;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_489;
					case 20:
						goto IL_4E0;
					case 21:
						try
						{
							num = (short)743899137;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									base.Expanders.Add(acpExpander);
									num = (short)557711362;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_201;
									}
									continue;
								case 3:
									num = (short)483196933;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									if (acpExpander != null)
									{
										num = (short)820183040;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 5:
									goto IL_2BE;
								case 6:
									if (!enumerator.MoveNext())
									{
										num = (short)1070137347;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
									num = (short)1567883268;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_26A:
								num = (short)1994260486;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_201:
								goto IL_26A;
							}
							IL_2BE:
							goto IL_4B9;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_2E0;
							}
							for (;;)
							{
								IL_2CD:
								switch (num2)
								{
								case 0:
								{
									global::System.IDisposable disposable;
									if (disposable != null)
									{
										num = (short)873332737;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_385;
								}
								case 1:
								{
									global::System.IDisposable disposable;
									disposable.Dispose();
									num = (short)1332150274;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_383;
								}
								goto IL_2E0;
							}
							IL_383:
							IL_385:
							goto EndFinally_14;
							for (;;)
							{
								IL_2E0:
								global::System.IDisposable disposable = enumerator as global::System.IDisposable;
								num = (short)877282079;
								short num3 = num;
								num = (short)287458079;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									goto IL_31C;
								}
							}
							IL_31C:
							num = (short)1665073152;
							if (num != 0)
							{
							}
							num = (short)762970112;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_2CD;
							EndFinally_14:;
						}
						goto IL_386;
						IL_4B9:
						base.OnLoaded(sender, e);
						this.a = true;
						num = (short)224788500;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
					{
						global::System.Windows.Data.CollectionView collectionView5 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderShepherdsGlobalShepherdList.MyDataPresenter = this.ExpanderShepherdsGlobalShepherdList;
						num = (short)1698955269;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
					{
						global::System.Windows.Data.CollectionView collectionView6 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderShepherdsTrunkingProductIndependentButtonList.MyDataPresenter = this.ExpanderShepherdsTrunkingProductIndependentButtonList;
						num = (short)1945239552;
						short num4 = num;
						num = (short)487784461;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						goto IL_386;
					}
					IL_AB:
					if (!this.a)
					{
						num = (short)1657864204;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_D5:
					obj = this.RecNavToolbarExpanderShepherdsSignalIndependentProductIndependentProgrammableButtonList.MyRecordsetDataSource;
					num = (short)1377304595;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_386:
					global::System.Windows.Data.CollectionView collectionView7 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
					this.RecNavToolbarExpanderShepherdsConventionalProductIndependentButtonList.MyDataPresenter = this.ExpanderShepherdsConventionalProductIndependentButtonList;
					num = (short)1490288644;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3FB:
					obj = this.RecNavToolbarExpanderShepherdsTrunkingShepherdList.MyRecordsetDataSource;
					num = (short)1287585793;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_445:
					obj = this.RecNavToolbarExpanderShepherdsGlobalShepherdList.MyRecordsetDataSource;
					num = (short)2052325378;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_489:
					acpExpander = null;
					enumerator = this.MyStackPanel.Children.GetEnumerator();
					num = (short)1097465877;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4E5:
					obj = this.RecNavToolbarExpanderShepherdsConventionalShepherdList.MyRecordsetDataSource;
					num = (short)139132938;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_576:
					obj = this.RecNavToolbarExpanderShepherdsTrunkingProductIndependentButtonList.MyRecordsetDataSource;
					num = (short)306839563;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_66D:
					obj = this.RecNavToolbarExpanderShepherdsSignalIndependentProductIndependentNonProgrammableButtonList.MyRecordsetDataSource;
					num = (short)267845650;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_4E0:
				this.MyStackPanel.Children[0].Focus();
				return;
			}
		}

		// Token: 0x06005413 RID: 21523 RVA: 0x004C4888 File Offset: 0x004C2A88
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
					return;
				case 1:
				{
					base.OnUnloaded(sender, e);
					this.a = false;
					num2 = (short)2124480512;
					short num3 = num2;
					num2 = (short)1491664896;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					if (this.a)
					{
						num2 = (short)1196949505;
						if (num2 != 0)
						{
						}
						num2 = (short)117702657;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_1C;
			}
			return;
			for (;;)
			{
				IL_1C:
				this.RecNavToolbarExpanderShepherdsConventionalProductIndependentButtonList.DataContext = null;
				this.RecNavToolbarExpanderShepherdsTrunkingProductIndependentButtonList.DataContext = null;
				this.RecNavToolbarExpanderShepherdsGlobalShepherdList.DataContext = null;
				this.RecNavToolbarExpanderShepherdsConventionalShepherdList.DataContext = null;
				this.RecNavToolbarExpanderShepherdsTrunkingShepherdList.DataContext = null;
				this.RecNavToolbarExpanderShepherdsSignalIndependentProductIndependentNonProgrammableButtonList.DataContext = null;
				this.RecNavToolbarExpanderShepherdsSignalIndependentProductIndependentProgrammableButtonList.DataContext = null;
				this.RecNavToolbarExpanderShepherdsConventionalProductIndependentButtonList.MyDataPresenter = null;
				this.RecNavToolbarExpanderShepherdsTrunkingProductIndependentButtonList.MyDataPresenter = null;
				this.RecNavToolbarExpanderShepherdsGlobalShepherdList.MyDataPresenter = null;
				this.RecNavToolbarExpanderShepherdsConventionalShepherdList.MyDataPresenter = null;
				this.RecNavToolbarExpanderShepherdsTrunkingShepherdList.MyDataPresenter = null;
				this.RecNavToolbarExpanderShepherdsSignalIndependentProductIndependentNonProgrammableButtonList.MyDataPresenter = null;
				this.RecNavToolbarExpanderShepherdsSignalIndependentProductIndependentProgrammableButtonList.MyDataPresenter = null;
				num2 = (short)890371290;
				short num4 = num2;
				num2 = (short)2082602202;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_FC;
				}
			}
			IL_FC:
			num2 = (short)1762852864;
			if (num2 != 0)
			{
			}
			num2 = (short)498991106;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06005414 RID: 21524 RVA: 0x004C4A5C File Offset: 0x004C2C5C
		public override void SetDataContext()
		{
			short num = (short)170131490;
			int num2 = (int)((global::System.IntPtr)num);
			object feature;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)1362624579;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A53;
				case 1:
					num = (short)2038825002;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_517;
				case 3:
					if (feature != null)
					{
						num = (short)1666187302;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_59D;
				case 4:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)1707671559;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CC4;
				case 5:
					goto IL_59D;
				case 6:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)131006525;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8C9;
				case 7:
					num = (short)1069678648;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10037].EmbeddedRecset != null)
					{
						num = (short)1820000273;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CC4;
				case 9:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)200212542;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 10:
					if (feature != null)
					{
						num = (short)1788542991;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_67F;
				case 11:
					num = (short)467599366;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderShepherdsTrunkingProductIndependentButtonList).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10027].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderShepherdsTrunkingProductIndependentButtonList).SyncDataSources();
					num = (short)809959442;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					num = (short)1261371446;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					if (feature != null)
					{
						num = (short)2098069559;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 15:
					num = (short)674431028;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)175243292;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderShepherdsConventionalProductIndependentButtonList).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderShepherdsTrunkingProductIndependentButtonList).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderShepherdsGlobalShepherdList).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderShepherdsConventionalShepherdList).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderShepherdsTrunkingShepherdList).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderShepherdsSignalIndependentProductIndependentNonProgrammableButtonList).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderShepherdsSignalIndependentProductIndependentProgrammableButtonList).MySecondaryRecordsetDataSource = null;
					num = (short)1605042178;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					goto IL_37E;
				case 18:
					goto IL_8C9;
				case 19:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10031].EmbeddedRecset != null)
					{
						num = (short)724566048;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_67F;
				case 20:
					num = (short)412549156;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)677445633;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_99D;
				case 22:
					num = (short)925827080;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderShepherdsConventionalProductIndependentButtonList).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10025].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderShepherdsConventionalProductIndependentButtonList).SyncDataSources();
					num = (short)94699525;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10033] != null)
					{
						num = (short)1244856340;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A53;
				case 25:
					if (feature != null)
					{
						num = (short)2066874407;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_99D;
				case 26:
					num = (short)1238564929;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 27:
					goto IL_B9F;
				case 28:
					feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2013);
					num = (short)522977283;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 29:
					num = (short)1452474368;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 30:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10025].EmbeddedRecset != null)
					{
						num = (short)683016215;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_59D;
				case 31:
					if (feature != null)
					{
						num = (short)1373896761;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CC4;
				case 32:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderShepherdsSignalIndependentProductIndependentNonProgrammableButtonList).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10031].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderShepherdsSignalIndependentProductIndependentNonProgrammableButtonList).SyncDataSources();
					num = (short)1152712755;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 33:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10029] != null)
					{
						num = (short)1529085978;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 34:
					switch (0)
					{
					case 0:
						goto IL_138;
					}
					continue;
				case 35:
					goto IL_A53;
				case 36:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10033].EmbeddedRecset != null)
					{
						num = (short)1380843580;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A53;
				case 37:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderShepherdsConventionalShepherdList).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10035].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderShepherdsConventionalShepherdList).SyncDataSources();
					num = (short)185335852;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 38:
					num = (short)1448214578;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 39:
					num = (short)433127445;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 40:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10025] != null)
					{
						num = (short)663027758;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_59D;
				case 41:
					num = (short)1637023803;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 42:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10035] != null)
					{
						num = (short)655884341;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_99D;
				case 43:
					if (feature != null)
					{
						num = (short)1063125021;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A53;
				case 44:
					goto IL_99D;
				case 45:
					if (feature != null)
					{
						num = (short)1754923019;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8C9;
				case 46:
					num = (short)142475294;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 47:
					goto IL_B9F;
				case 48:
					goto IL_CC4;
				case 49:
					goto IL_C73;
				case 50:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)1726808127;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_59D;
				case 51:
					goto IL_67F;
				case 52:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)1962606633;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_67F;
				case 53:
					num = (short)1389363268;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 54:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10027].EmbeddedRecset != null)
					{
						num = (short)1841233932;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8C9;
				case 55:
					num = (short)2108030985;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 56:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10037] != null)
					{
						num = (short)909377558;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CC4;
				case 57:
					num = (short)99352580;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 58:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2013);
					num = (short)1476001819;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 59:
				{
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10031] == null)
					{
						goto IL_67F;
					}
					num = (short)1772991542;
					short num3 = num;
					num = (short)2007217206;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_37E;
					default:
						num = (short)555024384;
						if (num != 0)
						{
						}
						num = (short)1667170368;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 60:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderShepherdsGlobalShepherdList).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10033].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderShepherdsGlobalShepherdList).SyncDataSources();
					num = (short)1907490851;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 61:
					num = (short)1758724162;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 62:
					num = (short)1199964193;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 63:
					num = (short)18546728;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 64:
					num = (short)26542099;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 65:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10029].EmbeddedRecset != null)
					{
						num = (short)1722941489;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 66:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10027] != null)
					{
						num = (short)5046285;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8C9;
				case 67:
					num = (short)1491402776;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 68:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10035].EmbeddedRecset != null)
					{
						num = (short)552140801;
						if (num != 0)
						{
						}
						num = (short)737148965;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_99D;
				}
				IL_138:
				num = (short)390070272;
				short num4 = num;
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)1466630202;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2013);
				num = (short)201326639;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_37E:
				((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderShepherdsTrunkingShepherdList).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10037].EmbeddedRecset;
				((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderShepherdsTrunkingShepherdList).SyncDataSources();
				num = (short)365690928;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_59D:
				num = (short)244711469;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_67F:
				num = (short)689307662;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_8C9:
				num = (short)95617067;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_99D:
				num = (short)543752223;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A53:
				num = (short)1955201049;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_B9F:
				num = (short)2104688656;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_CC4:
				num = (short)1008599050;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_517:
			return;
			IL_C73:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderShepherdsSignalIndependentProductIndependentProgrammableButtonList).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10029].EmbeddedRecset;
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderShepherdsSignalIndependentProductIndependentProgrammableButtonList).SyncDataSources();
		}

		// Token: 0x06005415 RID: 21525 RVA: 0x004C5768 File Offset: 0x004C3968
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 13;
			short num = (short)1841168384;
			switch (num)
			{
			default:
			{
				num = (short)2117074990;
				int num2 = (int)((global::System.IntPtr)num);
				object myRecordsetDataSource5;
				for (;;)
				{
					num = (short)1982464000;
					short num3 = num;
					switch (num2)
					{
					case 0:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource = this.RecNavToolbarExpanderShepherdsGlobalShepherdList.MyRecordsetDataSource;
						num = (short)394657837;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)46071850;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)915341332;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1568931888;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)1301086226;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						object myRecordsetDataSource2;
						if (myRecordsetDataSource2 != null)
						{
							num = (short)502267948;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9F3;
					}
					case 4:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1061486632;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)913440824;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("鳍뗏뇑髓럕껗軙돛뇝賟胡藣铥귧鋩鳫迭黯雱釳蓵꯷鋹駻軽棿朁瘃戅笇帉縋笍縏礑紓砕缗䤙琛笝借䨡䄣吥䰧昩䔫崭䐯", a_))
						{
							num = (short)7340047;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_ACE;
					case 6:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource3 = this.RecNavToolbarExpanderShepherdsTrunkingShepherdList.MyRecordsetDataSource;
						num = (short)1923285039;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1594032128;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)846594082;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("鳍뗏뇑髓럕껗軙돛뇝賟胡藣铥귧鋩鳫迭黯雱釳蓵꯷鋹駻軽棿朁瘃戅笇䤉挋怍昏眑稓戕焗甙爛缝䰟爡嘣䤥䰧弩伫娭礯就倳匵䠷弹刻娽┿ⱁぃх㵇㹉㡋⅍㹏ṑ㵓╕ⱗ", a_))
						{
							num = (short)1271398427;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_561;
					case 9:
					{
						object myRecordsetDataSource4;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource4);
						global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalProductIndependentButtonListInner item = (global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalProductIndependentButtonListInner)collectionView.CurrentItem;
						collectionView.MoveCurrentTo(item);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)22216723;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						object myRecordsetDataSource4;
						if (myRecordsetDataSource4 != null)
						{
							num = (short)1319043081;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_561;
					}
					case 11:
						if (myRecordsetDataSource5 != null)
						{
							num = (short)223412256;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 12:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)935329798;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)395247641;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("鳍뗏뇑髓럕껗軙돛뇝賟胡藣铥귧鋩鳫迭黯雱釳蓵꯷鋹駻軽棿朁瘃戅笇変攋植縏猑砓引瘗縙礛渝䔟䰡䀣䌥䘧帩簫尭弯嘱䄳唵䰷猹刻娽┿㉁⅃⡅ⱇ⽉≋㩍O⁑㭓ㅕ⩗㭙ㅛ㍝şaࡣͥ⩧ὩᡫᩭὯᱱ㡳ή୷๹", a_))
						{
							num = (short)850395186;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 14:
						num = (short)1164181511;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						num = (short)498270220;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						num = (short)1692205084;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_ACE;
					case 18:
						return;
					case 19:
						goto IL_561;
					case 20:
						goto IL_5B7;
					case 21:
						goto IL_561;
					case 22:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1954021413;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)1354563605;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("鳍뗏뇑髓럕껗軙돛뇝賟胡藣铥귧鋩鳫迭黯雱釳蓵꯷鋹駻軽棿朁瘃戅笇䤉挋怍昏眑稓戕焗甙爛缝䰟無䰣䌥堧䈩䤫尭启縱崳䔵䰷", a_))
						{
							num = (short)1019215903;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9F3;
					case 24:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("鳍뗏뇑髓럕껗軙돛뇝賟胡藣铥귧鋩鳫迭黯雱釳蓵꯷鋹駻軽棿朁瘃戅笇帉縋笍縏礑紓砕缗䨙減焝䐟圡䜣別愧䐩䠫䬭䀯圱娳刵崷吹䠻簽㔿㙁ぃ⥅♇ى╋㵍⑏", a_))
						{
							num = (short)1239810077;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5B7;
					case 25:
						num = (short)1234763777;
						if (num != 0)
						{
						}
						goto IL_ACE;
					case 26:
						goto IL_9F3;
					case 27:
						num = (short)698744854;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)2019164215;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						goto IL_AB0;
					case 29:
						num = (short)19660801;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("鳍뗏뇑髓럕껗軙돛뇝賟胡藣铥귧鋩鳫迭黯雱釳蓵꯷鋹駻軽棿朁瘃戅笇変攋植縏猑砓引瘗縙礛渝䔟䰡䀣䌥䘧帩簫尭弯嘱䄳唵䰷猹刻娽┿㉁⅃⡅ⱇ⽉≋㩍ṏ㵑㩓ٕ⩗㕙㭛ⱝşཡॣݥ੧٩५Ɑկٱs᥵ᙷ㙹ᕻൽ", a_))
						{
							num = (short)66650128;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3FA;
					case 31:
						num = (short)1857028100;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						goto IL_364;
					case 33:
						goto IL_6C5;
					case 34:
						goto IL_6C5;
					case 35:
					{
						object myRecordsetDataSource6;
						global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource6);
						global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner item2 = (global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner)collectionView2.CurrentItem;
						collectionView2.MoveCurrentTo(item2);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)199557171;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 36:
						num = (short)877264904;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource4 = this.RecNavToolbarExpanderShepherdsConventionalProductIndependentButtonList.MyRecordsetDataSource;
						num = (short)1917255690;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 38:
					{
						object myRecordsetDataSource7;
						global::System.Windows.Data.CollectionView collectionView3 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource7);
						global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingProductIndependentButtonListInner item3 = (global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingProductIndependentButtonListInner)collectionView3.CurrentItem;
						collectionView3.MoveCurrentTo(item3);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)1203830833;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 39:
					{
						object myRecordsetDataSource7;
						if (myRecordsetDataSource7 != null)
						{
							num = (short)2008023078;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5B7;
					}
					case 40:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource2 = this.RecNavToolbarExpanderShepherdsConventionalShepherdList.MyRecordsetDataSource;
						num = (short)1264451587;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 41:
					{
						object myRecordsetDataSource;
						global::System.Windows.Data.CollectionView collectionView4 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
						global::Motorola.MackinawCPS.CoreFeatures.Shepherds.GlobalShepherdListInner item4 = (global::Motorola.MackinawCPS.CoreFeatures.Shepherds.GlobalShepherdListInner)collectionView4.CurrentItem;
						collectionView4.MoveCurrentTo(item4);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)679936033;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 42:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource7 = this.RecNavToolbarExpanderShepherdsTrunkingProductIndependentButtonList.MyRecordsetDataSource;
						num = (short)479526951;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 43:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("鳍뗏뇑髓럕껗軙돛뇝賟胡藣铥귧鋩鳫迭黯雱釳蓵꯷鋹駻軽棿朁瘃戅笇䴉怋愍爏猑砓䔕瀗缙氛瘝䔟倡䀣樥䄧天堫", a_))
						{
							num = (short)249430030;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6C5;
					case 44:
					{
						object myRecordsetDataSource2;
						global::System.Windows.Data.CollectionView collectionView5 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource2);
						global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalShepherdListInner item5 = (global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalShepherdListInner)collectionView5.CurrentItem;
						collectionView5.MoveCurrentTo(item5);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)857407514;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 45:
					{
						object myRecordsetDataSource;
						if (myRecordsetDataSource == null)
						{
							goto IL_6C5;
						}
						num = (short)1051097798;
						short num4 = num;
						num = (short)144997062;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_AB0;
						default:
							num = (short)1729298432;
							if (num != 0)
							{
							}
							num = (short)511049769;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 46:
						switch (0)
						{
						case 0:
							goto IL_15E;
						}
						continue;
					case 47:
					{
						object myRecordsetDataSource3;
						if (myRecordsetDataSource3 != null)
						{
							num = (short)549650484;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_ACE;
					}
					case 48:
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						myRecordsetDataSource5 = this.RecNavToolbarExpanderShepherdsSignalIndependentProductIndependentProgrammableButtonList.MyRecordsetDataSource;
						num = (short)1619656715;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						goto IL_5B7;
					case 50:
						num = (short)1193934850;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 51:
						goto IL_3FA;
					case 52:
					{
						object myRecordsetDataSource3;
						global::System.Windows.Data.CollectionView collectionView6 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource3);
						global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingShepherdListInner item6 = (global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingShepherdListInner)collectionView6.CurrentItem;
						collectionView6.MoveCurrentTo(item6);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)2016477201;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 53:
						goto IL_3FA;
					case 54:
					{
						object myRecordsetDataSource6;
						if (myRecordsetDataSource6 != null)
						{
							num = (short)2091909155;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3FA;
					}
					case 55:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource6 = this.RecNavToolbarExpanderShepherdsSignalIndependentProductIndependentNonProgrammableButtonList.MyRecordsetDataSource;
						num = (short)325779510;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 56:
						goto IL_9F3;
					}
					IL_15E:
					if (A_0 is global::AcpUI.AcpRecNavToolbar)
					{
						num = (short)290324516;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_3FA:
					num = (short)847577101;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_561:
					num = (short)587726872;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5B7:
					num = (short)1701052459;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6C5:
					num = (short)352256023;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9F3:
					num = (short)1535639557;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AB0:
					num = (short)1467940917;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_ACE:
					num = (short)708968478;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_364:
				global::System.Windows.Data.CollectionView collectionView7 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource5);
				global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentProgrammableButtonListInner item7 = (global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentProgrammableButtonListInner)collectionView7.CurrentItem;
				collectionView7.MoveCurrentTo(item7);
				((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
				return;
			}
			}
		}

		// Token: 0x06005416 RID: 21526 RVA: 0x004C6320 File Offset: 0x004C4520
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1224035145;
			short num2 = num;
			num = (short)967854921;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1133576192;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1736966144;
			if (num != 0)
			{
			}
			num = (short)1653669889;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x06005417 RID: 21527 RVA: 0x004C63D4 File Offset: 0x004C45D4
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)588120065;
			if (num != 0)
			{
			}
			num = (short)2135031808;
			short num2 = num;
			num = (short)737834364;
			short num3 = num;
			num = (short)1274443132;
			switch (num3 == num)
			{
			}
			num = (short)1053097984;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06005418 RID: 21528 RVA: 0x004C6484 File Offset: 0x004C4684
		internal void OnExpanderShepherdsConventionalProductIndependentButtonListClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			object myRecordsetDataSource;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalProductIndependentButtonListInner item;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_151;
				case 1:
				{
					if (myRecordsetDataSource == null)
					{
						goto IL_153;
					}
					num2 = (short)124299382;
					short num3 = num2;
					num2 = (short)1173071990;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_153;
					default:
					{
						num2 = (short)422510592;
						short num4 = num2;
						num2 = (short)1148911617;
						if (num2 != 0)
						{
						}
						num2 = (short)1882324992;
						if (num2 != 0)
						{
						}
						num2 = (short)1320288258;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 2:
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderShepherdsConventionalProductIndependentButtonList.SyncDataSources();
					num2 = (short)2083848192;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
			}
			IL_151:
			IL_153:
			this.RecNavToolbarExpanderShepherdsConventionalProductIndependentButtonList.TableMode = false;
			return;
			IL_1C:
			item = (global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalProductIndependentButtonListInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderShepherdsConventionalProductIndependentButtonList.MyRecordsetDataSource;
			num2 = (short)283246593;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06005419 RID: 21529 RVA: 0x004C65F0 File Offset: 0x004C47F0
		internal void OnExpanderShepherdsTrunkingProductIndependentButtonListClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			object myRecordsetDataSource;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingProductIndependentButtonListInner item;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_152;
				case 1:
				{
					if (myRecordsetDataSource == null)
					{
						goto IL_154;
					}
					num2 = (short)572957305;
					short num3 = num2;
					num2 = (short)2087363193;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_154;
					default:
					{
						num2 = (short)655360;
						short num4 = num2;
						num2 = (short)1812332544;
						if (num2 != 0)
						{
						}
						num2 = (short)1068367874;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 2:
					num2 = (short)1369243649;
					if (num2 != 0)
					{
					}
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderShepherdsTrunkingProductIndependentButtonList.SyncDataSources();
					num2 = (short)873463808;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
			}
			IL_152:
			IL_154:
			this.RecNavToolbarExpanderShepherdsTrunkingProductIndependentButtonList.TableMode = false;
			return;
			IL_1C:
			item = (global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingProductIndependentButtonListInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderShepherdsTrunkingProductIndependentButtonList.MyRecordsetDataSource;
			num2 = (short)276627457;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600541A RID: 21530 RVA: 0x004C6760 File Offset: 0x004C4960
		internal void OnExpanderShepherdsGlobalShepherdListClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			object myRecordsetDataSource;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.Shepherds.GlobalShepherdListInner item;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_155;
				case 1:
				{
					if (myRecordsetDataSource == null)
					{
						goto IL_157;
					}
					num2 = (short)843410726;
					short num3 = num2;
					num2 = (short)1989569830;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_157;
					default:
					{
						num2 = (short)1747648512;
						short num4 = num2;
						num2 = (short)1186529280;
						if (num2 != 0)
						{
						}
						num2 = (short)1528627201;
						if (num2 != 0)
						{
						}
						num2 = (short)1395982338;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 2:
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderShepherdsGlobalShepherdList.SyncDataSources();
					num2 = (short)88014848;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
			}
			IL_155:
			IL_157:
			this.RecNavToolbarExpanderShepherdsGlobalShepherdList.TableMode = false;
			return;
			IL_1C:
			item = (global::Motorola.MackinawCPS.CoreFeatures.Shepherds.GlobalShepherdListInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderShepherdsGlobalShepherdList.MyRecordsetDataSource;
			num2 = (short)285278209;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600541B RID: 21531 RVA: 0x004C68D0 File Offset: 0x004C4AD0
		internal void OnExpanderShepherdsConventionalShepherdListClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalShepherdListInner item;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_153;
				case 1:
					num2 = (short)664469505;
					if (num2 != 0)
					{
					}
					if (myRecordsetDataSource != null)
					{
						num2 = (short)150870906;
						short num3 = num2;
						num2 = (short)1325996922;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_155;
						case 1:
							break;
						default:
						{
							num2 = (short)1345650688;
							short num4 = num2;
							break;
						}
						}
						num2 = (short)128122880;
						if (num2 != 0)
						{
						}
						num2 = (short)1773273090;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_155;
				case 2:
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderShepherdsConventionalShepherdList.SyncDataSources();
					num2 = (short)80740352;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
			}
			IL_153:
			IL_155:
			this.RecNavToolbarExpanderShepherdsConventionalShepherdList.TableMode = false;
			return;
			IL_1C:
			item = (global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalShepherdListInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderShepherdsConventionalShepherdList.MyRecordsetDataSource;
			num2 = (short)334299137;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600541C RID: 21532 RVA: 0x004C6A40 File Offset: 0x004C4C40
		internal void OnExpanderShepherdsTrunkingShepherdListClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			object myRecordsetDataSource;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingShepherdListInner item;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_12A;
				case 1:
				{
					if (myRecordsetDataSource == null)
					{
						goto IL_12C;
					}
					num2 = (short)855072946;
					short num3 = num2;
					num2 = (short)1633771698;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_12C;
					default:
					{
						num2 = (short)716767232;
						short num4 = num2;
						num2 = (short)190382080;
						if (num2 != 0)
						{
						}
						num2 = (short)108003330;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 2:
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderShepherdsTrunkingShepherdList.SyncDataSources();
					num2 = (short)2122645504;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
			}
			IL_12A:
			IL_12C:
			num2 = (short)346685441;
			if (num2 != 0)
			{
			}
			this.RecNavToolbarExpanderShepherdsTrunkingShepherdList.TableMode = false;
			return;
			IL_1C:
			item = (global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingShepherdListInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderShepherdsTrunkingShepherdList.MyRecordsetDataSource;
			num2 = (short)1089470465;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600541D RID: 21533 RVA: 0x004C6BB0 File Offset: 0x004C4DB0
		internal void OnExpanderShepherdsSignalIndependentProductIndependentNonProgrammableButtonListClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			short num;
			int num2;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner item;
			for (;;)
			{
				IL_0A:
				num = (short)1226309633;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					goto IL_152;
				case 1:
					if (myRecordsetDataSource != null)
					{
						num = (short)168080400;
						short num3 = num;
						num = (short)1920250896;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_154;
						case 1:
							break;
						default:
						{
							num = (short)1123811328;
							short num4 = num;
							break;
						}
						}
						num = (short)870776832;
						if (num != 0)
						{
						}
						num = (short)1686372354;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_154;
				case 2:
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderShepherdsSignalIndependentProductIndependentNonProgrammableButtonList.SyncDataSources();
					num = (short)225640448;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_44;
			}
			IL_152:
			IL_154:
			this.RecNavToolbarExpanderShepherdsSignalIndependentProductIndependentNonProgrammableButtonList.TableMode = false;
			return;
			IL_44:
			item = (global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderShepherdsSignalIndependentProductIndependentNonProgrammableButtonList.MyRecordsetDataSource;
			num = (short)1503199233;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600541E RID: 21534 RVA: 0x004C6D20 File Offset: 0x004C4F20
		internal void OnExpanderShepherdsSignalIndependentProductIndependentProgrammableButtonListClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			object myRecordsetDataSource;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentProgrammableButtonListInner item;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_150;
				case 1:
					if (myRecordsetDataSource != null)
					{
						num2 = (short)1761148929;
						if (num2 != 0)
						{
						}
						num2 = (short)336272783;
						short num3 = num2;
						num2 = (short)1217469839;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_152;
						case 1:
							break;
						default:
						{
							num2 = (short)433586176;
							short num4 = num2;
							break;
						}
						}
						num2 = (short)818937856;
						if (num2 != 0)
						{
						}
						num2 = (short)1998651394;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_152;
				case 2:
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderShepherdsSignalIndependentProductIndependentProgrammableButtonList.SyncDataSources();
					num2 = (short)547684352;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
			}
			IL_150:
			IL_152:
			this.RecNavToolbarExpanderShepherdsSignalIndependentProductIndependentProgrammableButtonList.TableMode = false;
			return;
			IL_1C:
			item = (global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentProgrammableButtonListInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderShepherdsSignalIndependentProductIndependentProgrammableButtonList.MyRecordsetDataSource;
			num2 = (short)1969291265;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600541F RID: 21535 RVA: 0x004C6E8C File Offset: 0x004C508C
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 18;
			if (this.b)
			{
				short num = (short)474713164;
				short num2 = num;
				num = (short)248941644;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)376373248;
					short num3 = num;
					num = (short)1674969089;
					if (num != 0)
					{
					}
					num = (short)476119040;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
			this.b = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("ﳒ铔믖뗘鷚룜뻞闠離韤苦髨탪軬胮鳰菲髴駶鳸闺觼탾猀戂愄渆昈⸊㼌㼎琐愒爔砖眘琚瀜瘞䈠倢$ᔦᤨ䠪䈬䄮地娲刴䈶䬸娺䤼嘾⹀ⵂ橄㑆ⅈ⹊㵌❎㑐⅒ㅔ⑖癘⡚㕜㩞ᅠୢdᕦ൨ᡪ䍬ᝮၰṲᥴ", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06005420 RID: 21536 RVA: 0x004C6F6C File Offset: 0x004C516C
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)228786178;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_A37;
				case 1:
					num = (short)1573322752;
					num2 = (int)((global::System.IntPtr)num);
					continue;
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
					goto IL_444;
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
				case 18:
					goto IL_1197;
				case 19:
					goto IL_A3C;
				case 20:
					goto IL_65B;
				case 21:
					goto IL_1064;
				case 22:
					goto IL_5BB;
				case 23:
					goto IL_94F;
				case 24:
					goto IL_EDA;
				case 25:
					goto IL_1104;
				case 26:
					goto IL_BEF;
				case 27:
					goto IL_D2C;
				case 28:
					goto IL_FBE;
				case 29:
					goto IL_C99;
				case 30:
					goto IL_714;
				case 31:
					goto IL_F18;
				case 32:
					goto IL_D39;
				case 33:
					goto IL_935;
				case 34:
					goto IL_F32;
				case 35:
					goto IL_EB3;
				case 36:
					goto IL_EFE;
				case 37:
					goto IL_D46;
				case 38:
					goto IL_942;
				case 39:
					goto IL_973;
				case 40:
					goto IL_397;
				case 41:
					goto IL_823;
				case 42:
					goto IL_A8A;
				case 43:
					goto IL_6E3;
				case 44:
					goto IL_64E;
				case 45:
					goto IL_499;
				case 46:
					goto IL_104A;
				case 47:
					goto IL_721;
				case 48:
					goto IL_F80;
				case 49:
					goto IL_7C1;
				case 50:
					goto IL_F0B;
				case 51:
					goto IL_475;
				case 52:
					goto IL_EA6;
				case 53:
					goto IL_1095;
				case 54:
					goto IL_37D;
				case 55:
					goto IL_1019;
				case 56:
					goto IL_556;
				case 57:
					goto IL_73B;
				case 58:
					goto IL_4A6;
				case 59:
					goto IL_928;
				case 60:
					goto IL_3F9;
				case 61:
					goto IL_6D6;
				case 62:
					goto IL_5A1;
				case 63:
					goto IL_594;
				case 64:
					goto IL_DC2;
				case 65:
					goto IL_E03;
				case 66:
					goto IL_C13;
				case 67:
					goto IL_1173;
				case 68:
					goto IL_B44;
				case 69:
					goto IL_570;
				case 70:
					goto IL_F59;
				case 71:
					goto IL_E4E;
				case 72:
					goto IL_AEC;
				case 73:
					goto IL_532;
				case 74:
					goto IL_F25;
				case 75:
					goto IL_CCA;
				case 76:
					goto IL_603;
				case 77:
					goto IL_DF6;
				case 78:
					goto IL_9E2;
				case 79:
					goto IL_7F2;
				case 80:
					goto IL_A70;
				case 81:
					goto IL_61D;
				case 82:
					goto IL_997;
				case 83:
					goto IL_B51;
				case 84:
					goto IL_1159;
				case 85:
					goto IL_857;
				case 86:
					goto IL_114C;
				case 87:
					goto IL_4F1;
				case 88:
					goto IL_4E4;
				case 89:
					goto IL_CEE;
				case 90:
					goto IL_E5B;
				case 91:
					goto IL_A63;
				case 92:
					goto IL_84A;
				case 93:
					goto IL_87B;
				case 94:
					goto IL_8DD;
				case 95:
					goto IL_C75;
				case 96:
					goto IL_437;
				case 97:
					goto IL_10C6;
				case 98:
					goto IL_FF2;
				case 99:
					goto IL_A56;
				case 100:
					goto IL_8D0;
				case 101:
					goto IL_5DF;
				case 102:
					goto IL_EC0;
				case 103:
					goto IL_D08;
				case 104:
					goto IL_A7D;
				case 105:
					goto IL_DCF;
				case 106:
					goto IL_F73;
				case 107:
					goto IL_E82;
				case 108:
					goto IL_5AE;
				case 109:
					goto IL_9EF;
				case 110:
					goto IL_C68;
				case 111:
					goto IL_D91;
				case 112:
					goto IL_B13;
				case 113:
					goto IL_888;
				case 114:
					goto IL_100C;
				case 115:
					goto IL_816;
				case 116:
					goto IL_FE5;
				case 117:
					goto IL_A49;
				case 118:
					goto IL_91B;
				case 119:
					goto IL_370;
				case 120:
					goto IL_83D;
				case 121:
					goto IL_FD8;
				case 122:
					goto IL_8EA;
				case 123:
					goto IL_3D5;
				case 124:
					goto IL_1166;
				case 125:
					goto IL_7CE;
				case 126:
					goto IL_72E;
				case 127:
					goto IL_B92;
				case 128:
					goto IL_F66;
				case 129:
					goto IL_1128;
				case 130:
					goto IL_B6B;
				case 131:
					goto IL_ABB;
				case 132:
					goto IL_4FE;
				case 133:
					goto IL_9D5;
				case 134:
					goto IL_ADF;
				case 135:
					goto IL_E10;
				case 136:
					goto IL_D6A;
				case 137:
					goto IL_9B1;
				case 138:
					goto IL_B9F;
				case 139:
					goto IL_3A4;
				case 140:
					goto IL_9A4;
				case 141:
					goto IL_C20;
				case 142:
					goto IL_363;
				case 143:
					goto IL_B85;
				case 144:
					goto IL_B06;
				case 145:
					goto IL_D84;
				case 146:
					goto IL_B5E;
				case 147:
					goto IL_BAC;
				case 148:
					goto IL_A13;
				case 149:
					goto IL_CBD;
				case 150:
					goto IL_610;
				case 151:
					goto IL_783;
				case 152:
					goto IL_830;
				case 153:
					goto IL_B20;
				case 154:
					goto IL_10B9;
				case 155:
					goto IL_FFF;
				case 156:
					goto IL_707;
				case 157:
					goto IL_8F7;
				case 158:
					goto IL_E75;
				case 159:
					goto IL_4C0;
				case 160:
					goto IL_F3F;
				case 161:
					goto IL_1057;
				case 162:
					goto IL_38A;
				case 163:
					goto IL_A97;
				case 164:
					goto IL_563;
				case 165:
					goto IL_75F;
				case 166:
					goto IL_AF9;
				case 167:
					goto IL_7A7;
				case 168:
					goto IL_FCB;
				case 169:
					goto IL_1026;
				case 170:
					goto IL_641;
				case 171:
					goto IL_D77;
				case 172:
					goto IL_7B4;
				case 173:
					goto IL_406;
				case 174:
					goto IL_F4C;
				case 175:
					goto IL_B78;
				case 176:
					goto IL_10EA;
				case 177:
					goto IL_4B3;
				case 178:
					goto IL_BB9;
				case 179:
					goto IL_3B1;
				case 180:
					goto IL_67F;
				case 181:
					goto IL_8AC;
				case 182:
					goto IL_DDC;
				case 183:
					goto IL_ECD;
				case 184:
					goto IL_E68;
				case 185:
					goto IL_D9E;
				case 186:
					goto IL_E34;
				case 187:
					goto IL_C44;
				case 188:
					goto IL_E41;
				case 189:
					goto IL_F8D;
				case 190:
					goto IL_10F7;
				case 191:
					goto IL_413;
				case 192:
					goto IL_DE9;
				case 193:
					goto IL_F9A;
				case 194:
					goto IL_1088;
				case 195:
					goto IL_CFB;
				default:
					num = (short)568590337;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_363:
			this.ExpanderShepherdsSignalIndependentProductIndependentNonProgrammableButtonGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_370:
			this.RadErgoCfgTrkBtnListID_A21166_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_37D:
			this.CpyBtnTrunkingProductIndependentButtonKey = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_38A:
			this.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_397:
			this.CpyBtnConventionalProductIndependentButtonKey = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3A4:
			this.RadErgoCfgTrkBtnListKey_A21174Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3B1:
			this.RadErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3D5:
			this.RadErgoCfgTrkBtnListType_A21167 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoCfgTrkBtnListType_A21167.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3F9:
			this.ExpanderShepherdsGlobalShepherdListTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_406:
			this.ExpanderShepherdsSignalIndependentProductIndependentProgrammableButtonList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_413:
			this.RadErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194 = (global::AcpUI.AcpTextBox)target;
			this.RadErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_437:
			this.CVBtnRadErgoCfgCnvBtnListType_A21164 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_444:
			((global::Motorola.MackinawCPS.CoreFeatures.Shepherds.PageShepherds)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.Shepherds.PageShepherds)target).Unloaded += this.OnUnloaded;
			return;
			IL_475:
			this.TrunkingProductIndependentButtonKey = (global::AcpUI.AcpTextBox)target;
			this.TrunkingProductIndependentButtonKey.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_499:
			this.ExpanderShepherdsTrunkingProductIndependentButtonListGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_4A6:
			this.ExpanderShepherdsGlobalShepherdGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_4B3:
			this.ExpanderShepherdsSignalIndependentProductIndependentProgrammableButtonListSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_4C0:
			this.LblRadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4E4:
			this.ExpanderShepherdsConventionalShepherdListTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_4F1:
			this.ExpanderShepherdsConventionalShepherdListGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_4FE:
			num = (short)1784414209;
			if (num != 0)
			{
			}
			this.RTDBtnRadErgoCfgTrkBtnListID_A21166 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_532:
			this.RadErgoCfgSignalIndepBtnListType_A21172 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoCfgSignalIndepBtnListType_A21172.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_556:
			this.ExpanderShepherdsGlobalShepherd = (global::AcpUI.AcpExpander)target;
			return;
			IL_563:
			this.CVBtnRadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_570:
			this.LblRadErgoCfgSignalIndepBtnListID_A21171 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgSignalIndepBtnListID_A21171.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_594:
			this.RadErgoCfgSignalIndepBtnListType_A21172_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_5A1:
			this.RadErgoCfgSignalIndepBtnListID_A21171_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_5AE:
			this.CVBtnRadErgoCfgCnvBtnListKey_A21175 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5BB:
			this.HLinkGlobalShepherd = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkGlobalShepherd.Click += this.HLinkClick;
			return;
			IL_5DF:
			this.RadErgoCfgCnvBtnListID_A21376 = (global::AcpUI.AcpLabel)target;
			this.RadErgoCfgCnvBtnListID_A21376.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_603:
			this.RTDBtnRadErgoCfgSignalIndepBtnListType_A21172 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_610:
			this.gridExpanderShepherdsSignalIndependentProductIndependentNonProgrammableButtonListSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_61D:
			this.LblRadErgoCfgSignalIndepBtnListKey_A21276 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgSignalIndepBtnListKey_A21276.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_641:
			this.ExpanderShepherdsSignalIndependentProductIndependentProgrammableButtonGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_64E:
			this.ExpanderShepherdsTrunkingProductIndependentButtonGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_65B:
			this.HLinkConventionalProductIndependentButton = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkConventionalProductIndependentButton.Click += this.HLinkClick;
			return;
			IL_67F:
			num = (short)1419384382;
			short num3 = num;
			num = (short)1438979646;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_9A4:
				this.ExpanderShepherdsSignalIndependentProductIndependentNonProgrammableButton = (global::AcpUI.AcpExpander)target;
				return;
			default:
				num = (short)759169024;
				if (num != 0)
				{
				}
				this.CVBtnRadErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757 = (global::AcpUI.AcpCustomViewCheckBox)target;
				return;
			}
			IL_6D6:
			this.ExpanderShepherdsGlobalShepherdList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_6E3:
			this.RecNavToolbarExpanderShepherdsTrunkingProductIndependentButtonList = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderShepherdsTrunkingProductIndependentButtonList.ModeClick += this.OnModeClick;
			return;
			IL_707:
			this.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_714:
			this.ExpanderShepherdsConventionalProductIndependentButtonGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_721:
			this.ExpanderShepherdsTrunkingProductIndependentButtonList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_72E:
			this.RTDBtnRadErgoCfgTrkBtnListType_A21167 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_73B:
			this.RecNavToolbarExpanderShepherdsGlobalShepherdList = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderShepherdsGlobalShepherdList.ModeClick += this.OnModeClick;
			return;
			IL_75F:
			this.LblRadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_783:
			this.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_7A7:
			this.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_7B4:
			this.ExpanderShepherdsSignalIndependentProductIndependentProgrammableButtonListTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_7C1:
			this.ExpanderShepherdsTrunkingProductIndependentButtonListSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_7CE:
			this.LblRadErgoCfgTrkBtnListType_A21167 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgTrkBtnListType_A21167.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_7F2:
			this.RadErgoCfgSignalIndepBtnListKey_A21276 = (global::AcpUI.AcpTextBox)target;
			this.RadErgoCfgSignalIndepBtnListKey_A21276.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_816:
			this.ExpanderShepherdsTrunkingShepherdListGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_823:
			this.ConventionalProductIndependentButtonKeyComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_830:
			this.CVBtnRadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_83D:
			this.RadErgoCfgTrkBtnListKey_A21174_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_84A:
			this.RadErgoCfgCnvBtnListKey_A21175_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_857:
			this.RecNavToolbarExpanderShepherdsConventionalShepherdList = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderShepherdsConventionalShepherdList.ModeClick += this.OnModeClick;
			return;
			IL_87B:
			this.ExpanderShepherdsConventionalShepherdListSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_888:
			this.RecNavToolbarExpanderShepherdsTrunkingShepherdList = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderShepherdsTrunkingShepherdList.ModeClick += this.OnModeClick;
			return;
			IL_8AC:
			this.LblRadErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_8D0:
			this.RadErgoCfgCnvBtnListType_A21164Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_8DD:
			this.gridExpanderShepherdsConventionalShepherdListSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_8EA:
			this.gridExpanderShepherdsTrunkingShepherdListSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_8F7:
			this.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_91B:
			this.RadErgoCfgTrkBtnListType_A21167_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_928:
			this.ExpanderShepherdsGlobalShepherdListGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_935:
			this.ExpanderShepherdsConventionalProductIndependentButtonList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_942:
			this.CVBtnConventionalProductIndependentButtonKey = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_94F:
			this.HLinkConventionalShepherd = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkConventionalShepherd.Click += this.HLinkClick;
			return;
			IL_973:
			this.LblConventionalProductIndependentButtonKey = (global::AcpUI.AcpLabel)target;
			this.LblConventionalProductIndependentButtonKey.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_997:
			this.CpyBtnRadErgoCfgSignalIndepBtnListKey_A21276 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9B1:
			this.LblRadErgoCfgTrkBtnListKey_A21174 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgTrkBtnListKey_A21174.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_9D5:
			this.CpyBtnRadErgoCfgTrkBtnListID_A21166 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9E2:
			this.RadErgoCfgSignalIndepBtnListType_A21172Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_9EF:
			this.LblRadErgoCfgCnvBtnListKey_A21175 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgCnvBtnListKey_A21175.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A13:
			this.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_A37:
			goto IL_1197;
			IL_A3C:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_A49:
			this.ExpanderShepherdsTrunkingShepherdList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_A56:
			this.CpyBtnRadErgoCfgCnvBtnListType_A21164 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A63:
			this.RadErgoCfgCnvBtnListID_A21376_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_A70:
			this.CVBtnRadErgoCfgSignalIndepBtnListKey_A21276 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A7D:
			this.RTDBtnRadErgoCfgCnvBtnListID_A21376 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A8A:
			this.ExpanderShepherdsTrunkingProductIndependentButton = (global::AcpUI.AcpExpander)target;
			return;
			IL_A97:
			this.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195 = (global::AcpUI.AcpTextBox)target;
			this.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_ABB:
			this.LblRadErgoCfgTrkBtnListID_A21166 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgTrkBtnListID_A21166.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_ADF:
			this.RadErgoCfgTrkBtnListID_A21166Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_AEC:
			this.RadErgoCfgSignalIndepBtnListID_A21171Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_AF9:
			this.CpyBtnRadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B06:
			this.ExpanderShepherdsSignalIndependentProductIndependentNonProgrammableButtonListTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_B13:
			this.ExpanderShepherdsTrunkingShepherd = (global::AcpUI.AcpExpander)target;
			return;
			IL_B20:
			this.LblRadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_B44:
			this.CVBtnRadErgoCfgSignalIndepBtnListID_A21171 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B51:
			this.RadErgoCfgSignalIndepBtnListKey_A21276Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_B5E:
			this.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_B6B:
			this.CVBtnRadErgoCfgTrkBtnListID_A21166 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B78:
			this.RadErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_B85:
			this.ExpanderShepherdsSignalIndependentProductIndependentNonProgrammableButtonListGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_B92:
			this.CpyBtnRadErgoCfgTrkBtnListType_A21167 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B9F:
			this.CpyBtnRadErgoCfgTrkBtnListKey_A21174 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_BAC:
			this.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_BB9:
			num = (short)759824384;
			short num4 = num;
			this.gridExpanderShepherdsSignalIndependentProductIndependentProgrammableButtonListSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_BEF:
			this.HLinkSignalIndependentProductIndependentProgrammableButton = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkSignalIndependentProductIndependentProgrammableButton.Click += this.HLinkClick;
			return;
			IL_C13:
			this.gridExpanderShepherdsGlobalShepherdListSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_C20:
			this.RecNavToolbarExpanderShepherdsSignalIndependentProductIndependentNonProgrammableButtonList = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderShepherdsSignalIndependentProductIndependentNonProgrammableButtonList.ModeClick += this.OnModeClick;
			return;
			IL_C44:
			this.LblRadErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_C68:
			this.CpyBtnRadErgoCfgCnvBtnListKey_A21175 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_C75:
			this.RadErgoCfgCnvBtnListType_A21164 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoCfgCnvBtnListType_A21164.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_C99:
			this.RecNavToolbarExpanderShepherdsConventionalProductIndependentButtonList = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderShepherdsConventionalProductIndependentButtonList.ModeClick += this.OnModeClick;
			return;
			IL_CBD:
			this.ExpanderShepherdsSignalIndependentProductIndependentNonProgrammableButtonListSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_CCA:
			this.LblRadErgoCfgSignalIndepBtnListType_A21172 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgSignalIndepBtnListType_A21172.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_CEE:
			this.ExpanderShepherdsConventionalShepherdList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_CFB:
			this.RadErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_D08:
			this.LblRadErgoCfgCnvBtnListID_A21376 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgCnvBtnListID_A21376.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_D2C:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_D39:
			this.ExpanderShepherdsConventionalProductIndependentButtonListTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_D46:
			this.ConventionalProductIndependentButtonKey = (global::AcpUI.AcpTextBox)target;
			this.ConventionalProductIndependentButtonKey.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_D6A:
			this.CVBtnRadErgoCfgTrkBtnListKey_A21174 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_D77:
			this.ExpanderShepherdsSignalIndependentProductIndependentProgrammableButtonListGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_D84:
			this.ExpanderShepherdsSignalIndependentProductIndependentNonProgrammableButtonList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_D91:
			this.RadErgoCfgCnvBtnListKey_A21175Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_D9E:
			this.RadErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_DC2:
			this.RadErgoCfgSignalIndepBtnListKey_A21276_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_DCF:
			this.CpyBtnRadErgoCfgCnvBtnListID_A21376 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_DDC:
			this.RTDBtnRadErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_DE9:
			this.CVBtnRadErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_DF6:
			this.CpyBtnRadErgoCfgSignalIndepBtnListType_A21172 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_E03:
			this.ExpanderShepherdsGlobalShepherdListSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_E10:
			this.RadErgoCfgTrkBtnListKey_A21174 = (global::AcpUI.AcpTextBox)target;
			this.RadErgoCfgTrkBtnListKey_A21174.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_E34:
			this.CVBtnRadErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_E41:
			this.RTDBtnRadErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_E4E:
			this.CpyBtnRadErgoCfgSignalIndepBtnListID_A21171 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_E5B:
			this.RadErgoCfgCnvBtnListType_A21164_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_E68:
			this.RadErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_E75:
			this.CVBtnRadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_E82:
			this.RadErgoCfgCnvBtnListKey_A21175 = (global::AcpUI.AcpTextBox)target;
			this.RadErgoCfgCnvBtnListKey_A21175.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_EA6:
			this.CVBtnTrunkingProductIndependentButtonKey = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_EB3:
			this.ExpanderShepherdsConventionalProductIndependentButtonListSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_EC0:
			this.CVBtnRadErgoCfgCnvBtnListID_A21376 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_ECD:
			this.CpyBtnRadErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_EDA:
			this.HLinkTrunkingShepherd = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkTrunkingShepherd.Click += this.HLinkClick;
			return;
			IL_EFE:
			this.gridExpanderShepherdsConventionalProductIndependentButtonListSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_F0B:
			this.gridExpanderShepherdsTrunkingProductIndependentButtonListSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_F18:
			this.ExpanderShepherdsConventionalProductIndependentButtonListGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_F25:
			this.CVBtnRadErgoCfgSignalIndepBtnListType_A21172 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_F32:
			this.ConventionalProductIndependentButtonKey_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_F3F:
			this.RTDBtnRadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_F4C:
			this.RadErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_F59:
			this.RTDBtnRadErgoCfgSignalIndepBtnListID_A21171 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_F66:
			this.RadErgoCfgTrkBtnListType_A21167Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_F73:
			this.RadErgoCfgCnvBtnListID_A21376Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_F80:
			this.TrunkingProductIndependentButtonKey_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_F8D:
			this.CpyBtnRadErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_F9A:
			this.LblRadErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_FBE:
			this.ExpanderShepherdsConventionalProductIndependentButton = (global::AcpUI.AcpExpander)target;
			return;
			IL_FCB:
			this.ExpanderShepherdsSignalIndependentProductIndependentProgrammableButton = (global::AcpUI.AcpExpander)target;
			return;
			IL_FD8:
			this.ExpanderShepherdsTrunkingShepherdListSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_FE5:
			this.ExpanderShepherdsTrunkingShepherdListTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_FF2:
			this.RTDBtnRadErgoCfgCnvBtnListType_A21164 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_FFF:
			this.CpyBtnRadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_100C:
			this.ExpanderShepherdsTrunkingShepherdGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_1019:
			this.TrunkingProductIndependentButtonKeyComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1026:
			this.RecNavToolbarExpanderShepherdsSignalIndependentProductIndependentProgrammableButtonList = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderShepherdsSignalIndependentProductIndependentProgrammableButtonList.ModeClick += this.OnModeClick;
			return;
			IL_104A:
			this.ExpanderShepherdsTrunkingProductIndependentButtonListTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1057:
			this.CpyBtnRadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1064:
			this.HLinkTrunkingProductIndependentButton = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkTrunkingProductIndependentButton.Click += this.HLinkClick;
			return;
			IL_1088:
			this.CpyBtnRadErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1095:
			this.LblTrunkingProductIndependentButtonKey = (global::AcpUI.AcpLabel)target;
			this.LblTrunkingProductIndependentButtonKey.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_10B9:
			this.RTDBtnRadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_10C6:
			this.LblRadErgoCfgCnvBtnListType_A21164 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgCnvBtnListType_A21164.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_10EA:
			this.RadErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_10F7:
			this.RadErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1104:
			this.HLinkSignalIndependentProductIndependentNonProgrammableButton = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkSignalIndependentProductIndependentNonProgrammableButton.Click += this.HLinkClick;
			return;
			IL_1128:
			this.RadErgoCfgTrkBtnListID_A21166 = (global::AcpUI.AcpLabel)target;
			this.RadErgoCfgTrkBtnListID_A21166.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_114C:
			this.ExpanderShepherdsConventionalShepherdGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_1159:
			this.ExpanderShepherdsConventionalShepherd = (global::AcpUI.AcpExpander)target;
			return;
			IL_1166:
			this.CVBtnRadErgoCfgTrkBtnListType_A21167 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1173:
			this.RadErgoCfgSignalIndepBtnListID_A21171 = (global::AcpUI.AcpLabel)target;
			this.RadErgoCfgSignalIndepBtnListID_A21171.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1197:
			this.b = true;
		}

		// Token: 0x06005421 RID: 21537 RVA: 0x004C8118 File Offset: 0x004C6318
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num = (short)2021130240;
			short num2 = num;
			switch (connectionId)
			{
			case 2:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 3:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 4:
				((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 5:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 6:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 7:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 8:
				((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 9:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 10:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 11:
				break;
			case 12:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 13:
			{
				num = (short)836580529;
				short num3 = num;
				num = (short)572470449;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)734920704;
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
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 16:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 17:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 18:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			default:
				num = (short)1012727809;
				if (num != 0)
				{
				}
				return;
			}
			((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x040020AA RID: 8362
		private bool a;

		// Token: 0x040020AB RID: 8363
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x040020AC RID: 8364
		internal global::System.Windows.Documents.Hyperlink HLinkConventionalProductIndependentButton;

		// Token: 0x040020AD RID: 8365
		internal global::System.Windows.Documents.Hyperlink HLinkTrunkingProductIndependentButton;

		// Token: 0x040020AE RID: 8366
		internal global::System.Windows.Documents.Hyperlink HLinkGlobalShepherd;

		// Token: 0x040020AF RID: 8367
		internal global::System.Windows.Documents.Hyperlink HLinkConventionalShepherd;

		// Token: 0x040020B0 RID: 8368
		internal global::System.Windows.Documents.Hyperlink HLinkTrunkingShepherd;

		// Token: 0x040020B1 RID: 8369
		internal global::System.Windows.Documents.Hyperlink HLinkSignalIndependentProductIndependentNonProgrammableButton;

		// Token: 0x040020B2 RID: 8370
		internal global::System.Windows.Documents.Hyperlink HLinkSignalIndependentProductIndependentProgrammableButton;

		// Token: 0x040020B3 RID: 8371
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x040020B4 RID: 8372
		internal global::AcpUI.AcpExpander ExpanderShepherdsConventionalProductIndependentButton;

		// Token: 0x040020B5 RID: 8373
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderShepherdsConventionalProductIndependentButtonList;

		// Token: 0x040020B6 RID: 8374
		internal global::System.Windows.Controls.Grid ExpanderShepherdsConventionalProductIndependentButtonGrid;

		// Token: 0x040020B7 RID: 8375
		internal global::System.Windows.Controls.Grid ExpanderShepherdsConventionalProductIndependentButtonListGrid;

		// Token: 0x040020B8 RID: 8376
		internal global::AcpUI.AcpGroupBox ExpanderShepherdsConventionalProductIndependentButtonListTableView;

		// Token: 0x040020B9 RID: 8377
		internal global::AcpUI.AcpXamDataPresenter ExpanderShepherdsConventionalProductIndependentButtonList;

		// Token: 0x040020BA RID: 8378
		internal global::Infragistics.Windows.DataPresenter.UnboundField ConventionalProductIndependentButtonKey_Col;

		// Token: 0x040020BB RID: 8379
		internal global::AcpUI.AcpGroupBox ExpanderShepherdsConventionalProductIndependentButtonListSRecView;

		// Token: 0x040020BC RID: 8380
		internal global::System.Windows.Controls.Grid gridExpanderShepherdsConventionalProductIndependentButtonListSRecView;

		// Token: 0x040020BD RID: 8381
		internal global::AcpUI.AcpTextBox ConventionalProductIndependentButtonKey;

		// Token: 0x040020BE RID: 8382
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnConventionalProductIndependentButtonKey;

		// Token: 0x040020BF RID: 8383
		internal global::AcpUI.AcpLabel LblConventionalProductIndependentButtonKey;

		// Token: 0x040020C0 RID: 8384
		internal global::AcpUI.AcpCopyButton CpyBtnConventionalProductIndependentButtonKey;

		// Token: 0x040020C1 RID: 8385
		internal global::AcpUI.AcpLabel ConventionalProductIndependentButtonKeyComp;

		// Token: 0x040020C2 RID: 8386
		internal global::AcpUI.AcpExpander ExpanderShepherdsTrunkingProductIndependentButton;

		// Token: 0x040020C3 RID: 8387
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderShepherdsTrunkingProductIndependentButtonList;

		// Token: 0x040020C4 RID: 8388
		internal global::System.Windows.Controls.Grid ExpanderShepherdsTrunkingProductIndependentButtonGrid;

		// Token: 0x040020C5 RID: 8389
		internal global::System.Windows.Controls.Grid ExpanderShepherdsTrunkingProductIndependentButtonListGrid;

		// Token: 0x040020C6 RID: 8390
		internal global::AcpUI.AcpGroupBox ExpanderShepherdsTrunkingProductIndependentButtonListTableView;

		// Token: 0x040020C7 RID: 8391
		internal global::AcpUI.AcpXamDataPresenter ExpanderShepherdsTrunkingProductIndependentButtonList;

		// Token: 0x040020C8 RID: 8392
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrunkingProductIndependentButtonKey_Col;

		// Token: 0x040020C9 RID: 8393
		internal global::AcpUI.AcpGroupBox ExpanderShepherdsTrunkingProductIndependentButtonListSRecView;

		// Token: 0x040020CA RID: 8394
		internal global::System.Windows.Controls.Grid gridExpanderShepherdsTrunkingProductIndependentButtonListSRecView;

		// Token: 0x040020CB RID: 8395
		internal global::AcpUI.AcpTextBox TrunkingProductIndependentButtonKey;

		// Token: 0x040020CC RID: 8396
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrunkingProductIndependentButtonKey;

		// Token: 0x040020CD RID: 8397
		internal global::AcpUI.AcpLabel LblTrunkingProductIndependentButtonKey;

		// Token: 0x040020CE RID: 8398
		internal global::AcpUI.AcpCopyButton CpyBtnTrunkingProductIndependentButtonKey;

		// Token: 0x040020CF RID: 8399
		internal global::AcpUI.AcpLabel TrunkingProductIndependentButtonKeyComp;

		// Token: 0x040020D0 RID: 8400
		internal global::AcpUI.AcpExpander ExpanderShepherdsGlobalShepherd;

		// Token: 0x040020D1 RID: 8401
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderShepherdsGlobalShepherdList;

		// Token: 0x040020D2 RID: 8402
		internal global::System.Windows.Controls.Grid ExpanderShepherdsGlobalShepherdGrid;

		// Token: 0x040020D3 RID: 8403
		internal global::System.Windows.Controls.Grid ExpanderShepherdsGlobalShepherdListGrid;

		// Token: 0x040020D4 RID: 8404
		internal global::AcpUI.AcpGroupBox ExpanderShepherdsGlobalShepherdListTableView;

		// Token: 0x040020D5 RID: 8405
		internal global::AcpUI.AcpXamDataPresenter ExpanderShepherdsGlobalShepherdList;

		// Token: 0x040020D6 RID: 8406
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoCfgSignalIndepBtnListID_A21171_Col;

		// Token: 0x040020D7 RID: 8407
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoCfgSignalIndepBtnListType_A21172_Col;

		// Token: 0x040020D8 RID: 8408
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoCfgSignalIndepBtnListKey_A21276_Col;

		// Token: 0x040020D9 RID: 8409
		internal global::AcpUI.AcpGroupBox ExpanderShepherdsGlobalShepherdListSRecView;

		// Token: 0x040020DA RID: 8410
		internal global::System.Windows.Controls.Grid gridExpanderShepherdsGlobalShepherdListSRecView;

		// Token: 0x040020DB RID: 8411
		internal global::AcpUI.AcpLabel RadErgoCfgSignalIndepBtnListID_A21171;

		// Token: 0x040020DC RID: 8412
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgSignalIndepBtnListID_A21171;

		// Token: 0x040020DD RID: 8413
		internal global::AcpUI.AcpLabel LblRadErgoCfgSignalIndepBtnListID_A21171;

		// Token: 0x040020DE RID: 8414
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgSignalIndepBtnListID_A21171;

		// Token: 0x040020DF RID: 8415
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgSignalIndepBtnListID_A21171;

		// Token: 0x040020E0 RID: 8416
		internal global::AcpUI.AcpLabel RadErgoCfgSignalIndepBtnListID_A21171Comp;

		// Token: 0x040020E1 RID: 8417
		internal global::AcpUI.AcpComboBox RadErgoCfgSignalIndepBtnListType_A21172;

		// Token: 0x040020E2 RID: 8418
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgSignalIndepBtnListType_A21172;

		// Token: 0x040020E3 RID: 8419
		internal global::AcpUI.AcpLabel LblRadErgoCfgSignalIndepBtnListType_A21172;

		// Token: 0x040020E4 RID: 8420
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgSignalIndepBtnListType_A21172;

		// Token: 0x040020E5 RID: 8421
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgSignalIndepBtnListType_A21172;

		// Token: 0x040020E6 RID: 8422
		internal global::AcpUI.AcpLabel RadErgoCfgSignalIndepBtnListType_A21172Comp;

		// Token: 0x040020E7 RID: 8423
		internal global::AcpUI.AcpTextBox RadErgoCfgSignalIndepBtnListKey_A21276;

		// Token: 0x040020E8 RID: 8424
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgSignalIndepBtnListKey_A21276;

		// Token: 0x040020E9 RID: 8425
		internal global::AcpUI.AcpLabel LblRadErgoCfgSignalIndepBtnListKey_A21276;

		// Token: 0x040020EA RID: 8426
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgSignalIndepBtnListKey_A21276;

		// Token: 0x040020EB RID: 8427
		internal global::AcpUI.AcpLabel RadErgoCfgSignalIndepBtnListKey_A21276Comp;

		// Token: 0x040020EC RID: 8428
		internal global::AcpUI.AcpExpander ExpanderShepherdsConventionalShepherd;

		// Token: 0x040020ED RID: 8429
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderShepherdsConventionalShepherdList;

		// Token: 0x040020EE RID: 8430
		internal global::System.Windows.Controls.Grid ExpanderShepherdsConventionalShepherdGrid;

		// Token: 0x040020EF RID: 8431
		internal global::System.Windows.Controls.Grid ExpanderShepherdsConventionalShepherdListGrid;

		// Token: 0x040020F0 RID: 8432
		internal global::AcpUI.AcpGroupBox ExpanderShepherdsConventionalShepherdListTableView;

		// Token: 0x040020F1 RID: 8433
		internal global::AcpUI.AcpXamDataPresenter ExpanderShepherdsConventionalShepherdList;

		// Token: 0x040020F2 RID: 8434
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoCfgCnvBtnListType_A21164_Col;

		// Token: 0x040020F3 RID: 8435
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoCfgCnvBtnListID_A21376_Col;

		// Token: 0x040020F4 RID: 8436
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoCfgCnvBtnListKey_A21175_Col;

		// Token: 0x040020F5 RID: 8437
		internal global::AcpUI.AcpGroupBox ExpanderShepherdsConventionalShepherdListSRecView;

		// Token: 0x040020F6 RID: 8438
		internal global::System.Windows.Controls.Grid gridExpanderShepherdsConventionalShepherdListSRecView;

		// Token: 0x040020F7 RID: 8439
		internal global::AcpUI.AcpComboBox RadErgoCfgCnvBtnListType_A21164;

		// Token: 0x040020F8 RID: 8440
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgCnvBtnListType_A21164;

		// Token: 0x040020F9 RID: 8441
		internal global::AcpUI.AcpLabel LblRadErgoCfgCnvBtnListType_A21164;

		// Token: 0x040020FA RID: 8442
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgCnvBtnListType_A21164;

		// Token: 0x040020FB RID: 8443
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgCnvBtnListType_A21164;

		// Token: 0x040020FC RID: 8444
		internal global::AcpUI.AcpLabel RadErgoCfgCnvBtnListType_A21164Comp;

		// Token: 0x040020FD RID: 8445
		internal global::AcpUI.AcpLabel RadErgoCfgCnvBtnListID_A21376;

		// Token: 0x040020FE RID: 8446
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgCnvBtnListID_A21376;

		// Token: 0x040020FF RID: 8447
		internal global::AcpUI.AcpLabel LblRadErgoCfgCnvBtnListID_A21376;

		// Token: 0x04002100 RID: 8448
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgCnvBtnListID_A21376;

		// Token: 0x04002101 RID: 8449
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgCnvBtnListID_A21376;

		// Token: 0x04002102 RID: 8450
		internal global::AcpUI.AcpLabel RadErgoCfgCnvBtnListID_A21376Comp;

		// Token: 0x04002103 RID: 8451
		internal global::AcpUI.AcpTextBox RadErgoCfgCnvBtnListKey_A21175;

		// Token: 0x04002104 RID: 8452
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgCnvBtnListKey_A21175;

		// Token: 0x04002105 RID: 8453
		internal global::AcpUI.AcpLabel LblRadErgoCfgCnvBtnListKey_A21175;

		// Token: 0x04002106 RID: 8454
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgCnvBtnListKey_A21175;

		// Token: 0x04002107 RID: 8455
		internal global::AcpUI.AcpLabel RadErgoCfgCnvBtnListKey_A21175Comp;

		// Token: 0x04002108 RID: 8456
		internal global::AcpUI.AcpExpander ExpanderShepherdsTrunkingShepherd;

		// Token: 0x04002109 RID: 8457
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderShepherdsTrunkingShepherdList;

		// Token: 0x0400210A RID: 8458
		internal global::System.Windows.Controls.Grid ExpanderShepherdsTrunkingShepherdGrid;

		// Token: 0x0400210B RID: 8459
		internal global::System.Windows.Controls.Grid ExpanderShepherdsTrunkingShepherdListGrid;

		// Token: 0x0400210C RID: 8460
		internal global::AcpUI.AcpGroupBox ExpanderShepherdsTrunkingShepherdListTableView;

		// Token: 0x0400210D RID: 8461
		internal global::AcpUI.AcpXamDataPresenter ExpanderShepherdsTrunkingShepherdList;

		// Token: 0x0400210E RID: 8462
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoCfgTrkBtnListType_A21167_Col;

		// Token: 0x0400210F RID: 8463
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoCfgTrkBtnListID_A21166_Col;

		// Token: 0x04002110 RID: 8464
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoCfgTrkBtnListKey_A21174_Col;

		// Token: 0x04002111 RID: 8465
		internal global::AcpUI.AcpGroupBox ExpanderShepherdsTrunkingShepherdListSRecView;

		// Token: 0x04002112 RID: 8466
		internal global::System.Windows.Controls.Grid gridExpanderShepherdsTrunkingShepherdListSRecView;

		// Token: 0x04002113 RID: 8467
		internal global::AcpUI.AcpComboBox RadErgoCfgTrkBtnListType_A21167;

		// Token: 0x04002114 RID: 8468
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgTrkBtnListType_A21167;

		// Token: 0x04002115 RID: 8469
		internal global::AcpUI.AcpLabel LblRadErgoCfgTrkBtnListType_A21167;

		// Token: 0x04002116 RID: 8470
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgTrkBtnListType_A21167;

		// Token: 0x04002117 RID: 8471
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgTrkBtnListType_A21167;

		// Token: 0x04002118 RID: 8472
		internal global::AcpUI.AcpLabel RadErgoCfgTrkBtnListType_A21167Comp;

		// Token: 0x04002119 RID: 8473
		internal global::AcpUI.AcpLabel RadErgoCfgTrkBtnListID_A21166;

		// Token: 0x0400211A RID: 8474
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgTrkBtnListID_A21166;

		// Token: 0x0400211B RID: 8475
		internal global::AcpUI.AcpLabel LblRadErgoCfgTrkBtnListID_A21166;

		// Token: 0x0400211C RID: 8476
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgTrkBtnListID_A21166;

		// Token: 0x0400211D RID: 8477
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgTrkBtnListID_A21166;

		// Token: 0x0400211E RID: 8478
		internal global::AcpUI.AcpLabel RadErgoCfgTrkBtnListID_A21166Comp;

		// Token: 0x0400211F RID: 8479
		internal global::AcpUI.AcpTextBox RadErgoCfgTrkBtnListKey_A21174;

		// Token: 0x04002120 RID: 8480
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgTrkBtnListKey_A21174;

		// Token: 0x04002121 RID: 8481
		internal global::AcpUI.AcpLabel LblRadErgoCfgTrkBtnListKey_A21174;

		// Token: 0x04002122 RID: 8482
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgTrkBtnListKey_A21174;

		// Token: 0x04002123 RID: 8483
		internal global::AcpUI.AcpLabel RadErgoCfgTrkBtnListKey_A21174Comp;

		// Token: 0x04002124 RID: 8484
		internal global::AcpUI.AcpExpander ExpanderShepherdsSignalIndependentProductIndependentNonProgrammableButton;

		// Token: 0x04002125 RID: 8485
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderShepherdsSignalIndependentProductIndependentNonProgrammableButtonList;

		// Token: 0x04002126 RID: 8486
		internal global::System.Windows.Controls.Grid ExpanderShepherdsSignalIndependentProductIndependentNonProgrammableButtonGrid;

		// Token: 0x04002127 RID: 8487
		internal global::System.Windows.Controls.Grid ExpanderShepherdsSignalIndependentProductIndependentNonProgrammableButtonListGrid;

		// Token: 0x04002128 RID: 8488
		internal global::AcpUI.AcpGroupBox ExpanderShepherdsSignalIndependentProductIndependentNonProgrammableButtonListTableView;

		// Token: 0x04002129 RID: 8489
		internal global::AcpUI.AcpXamDataPresenter ExpanderShepherdsSignalIndependentProductIndependentNonProgrammableButtonList;

		// Token: 0x0400212A RID: 8490
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777_Col;

		// Token: 0x0400212B RID: 8491
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778_Col;

		// Token: 0x0400212C RID: 8492
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195_Col;

		// Token: 0x0400212D RID: 8493
		internal global::AcpUI.AcpGroupBox ExpanderShepherdsSignalIndependentProductIndependentNonProgrammableButtonListSRecView;

		// Token: 0x0400212E RID: 8494
		internal global::System.Windows.Controls.Grid gridExpanderShepherdsSignalIndependentProductIndependentNonProgrammableButtonListSRecView;

		// Token: 0x0400212F RID: 8495
		internal global::AcpUI.AcpComboBox RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777;

		// Token: 0x04002130 RID: 8496
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777;

		// Token: 0x04002131 RID: 8497
		internal global::AcpUI.AcpLabel LblRadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777;

		// Token: 0x04002132 RID: 8498
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777;

		// Token: 0x04002133 RID: 8499
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777;

		// Token: 0x04002134 RID: 8500
		internal global::AcpUI.AcpLabel RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777Comp;

		// Token: 0x04002135 RID: 8501
		internal global::AcpUI.AcpComboBox RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778;

		// Token: 0x04002136 RID: 8502
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778;

		// Token: 0x04002137 RID: 8503
		internal global::AcpUI.AcpLabel LblRadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778;

		// Token: 0x04002138 RID: 8504
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778;

		// Token: 0x04002139 RID: 8505
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778;

		// Token: 0x0400213A RID: 8506
		internal global::AcpUI.AcpLabel RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778Comp;

		// Token: 0x0400213B RID: 8507
		internal global::AcpUI.AcpTextBox RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195;

		// Token: 0x0400213C RID: 8508
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195;

		// Token: 0x0400213D RID: 8509
		internal global::AcpUI.AcpLabel LblRadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195;

		// Token: 0x0400213E RID: 8510
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195;

		// Token: 0x0400213F RID: 8511
		internal global::AcpUI.AcpLabel RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonKey_A21195Comp;

		// Token: 0x04002140 RID: 8512
		internal global::AcpUI.AcpExpander ExpanderShepherdsSignalIndependentProductIndependentProgrammableButton;

		// Token: 0x04002141 RID: 8513
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderShepherdsSignalIndependentProductIndependentProgrammableButtonList;

		// Token: 0x04002142 RID: 8514
		internal global::System.Windows.Controls.Grid ExpanderShepherdsSignalIndependentProductIndependentProgrammableButtonGrid;

		// Token: 0x04002143 RID: 8515
		internal global::System.Windows.Controls.Grid ExpanderShepherdsSignalIndependentProductIndependentProgrammableButtonListGrid;

		// Token: 0x04002144 RID: 8516
		internal global::AcpUI.AcpGroupBox ExpanderShepherdsSignalIndependentProductIndependentProgrammableButtonListTableView;

		// Token: 0x04002145 RID: 8517
		internal global::AcpUI.AcpXamDataPresenter ExpanderShepherdsSignalIndependentProductIndependentProgrammableButtonList;

		// Token: 0x04002146 RID: 8518
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757_Col;

		// Token: 0x04002147 RID: 8519
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758_Col;

		// Token: 0x04002148 RID: 8520
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194_Col;

		// Token: 0x04002149 RID: 8521
		internal global::AcpUI.AcpGroupBox ExpanderShepherdsSignalIndependentProductIndependentProgrammableButtonListSRecView;

		// Token: 0x0400214A RID: 8522
		internal global::System.Windows.Controls.Grid gridExpanderShepherdsSignalIndependentProductIndependentProgrammableButtonListSRecView;

		// Token: 0x0400214B RID: 8523
		internal global::AcpUI.AcpComboBox RadErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757;

		// Token: 0x0400214C RID: 8524
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757;

		// Token: 0x0400214D RID: 8525
		internal global::AcpUI.AcpLabel LblRadErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757;

		// Token: 0x0400214E RID: 8526
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757;

		// Token: 0x0400214F RID: 8527
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757;

		// Token: 0x04002150 RID: 8528
		internal global::AcpUI.AcpLabel RadErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757Comp;

		// Token: 0x04002151 RID: 8529
		internal global::AcpUI.AcpComboBox RadErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758;

		// Token: 0x04002152 RID: 8530
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758;

		// Token: 0x04002153 RID: 8531
		internal global::AcpUI.AcpLabel LblRadErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758;

		// Token: 0x04002154 RID: 8532
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758;

		// Token: 0x04002155 RID: 8533
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758;

		// Token: 0x04002156 RID: 8534
		internal global::AcpUI.AcpLabel RadErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758Comp;

		// Token: 0x04002157 RID: 8535
		internal global::AcpUI.AcpTextBox RadErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194;

		// Token: 0x04002158 RID: 8536
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194;

		// Token: 0x04002159 RID: 8537
		internal global::AcpUI.AcpLabel LblRadErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194;

		// Token: 0x0400215A RID: 8538
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194;

		// Token: 0x0400215B RID: 8539
		internal global::AcpUI.AcpLabel RadErgoCfgSignalIndependentProductIndependentProgrammableButtonKey_A21194Comp;

		// Token: 0x0400215C RID: 8540
		private bool b;
	}
}
