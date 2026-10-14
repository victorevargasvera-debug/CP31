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
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO9;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadE5
{
	// Token: 0x020003E9 RID: 1001
	public class PageControlHeadE5 : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x06008C94 RID: 35988 RVA: 0x0083C308 File Offset: 0x0083A508
		public PageControlHeadE5()
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

		// Token: 0x06008C95 RID: 35989 RVA: 0x0083C340 File Offset: 0x0083A540
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1818361856;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				switch (0)
				{
				case 0:
					goto IL_63;
				}
				for (;;)
				{
					IL_28:
					object obj;
					global::AcpUI.AcpExpander acpExpander;
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						goto IL_45B;
					case 1:
					{
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderControlHeadE5BottomFunctionProgrammableButtonTable.MyDataPresenter = this.ExpanderControlHeadE5E5BottomFunctionProgrammableButton_43755;
						num = (short)872284160;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						num = (short)1889402880;
						short num3 = num;
						global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderControlHeadE5E5.MyDataPresenter = this.ExpanderControlHeadE5E5;
						num = (short)1420492811;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						if (obj != null)
						{
							num = (short)1706164233;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_385;
					case 4:
						try
						{
							num = (short)1296695302;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									num = (short)755761156;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									if (acpExpander != null)
									{
										num = (short)1183917331;
										short num4 = num;
										num = (short)149431571;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											num = (short)707002368;
											if (num != 0)
											{
											}
											num = (short)914096131;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
									}
									break;
								case 3:
									base.Expanders.Add(acpExpander);
									num = (short)991428608;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_1FC;
								case 5:
									if (!enumerator.MoveNext())
									{
										num = (short)204668929;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
									num = (short)788660226;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_EB;
									}
									continue;
								}
								IL_ED:
								num = (short)998244357;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_EB:
								goto IL_ED;
							}
							IL_1FC:
							goto IL_3B5;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_21E;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_20B:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)1785528321;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_273;
								case 2:
									if (disposable != null)
									{
										num = (short)1387593728;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_275;
								}
								goto IL_21E;
							}
							IL_273:
							IL_275:
							goto EndFinally_10;
							IL_21E:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1461780482;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_20B;
							EndFinally_10:;
						}
						goto IL_276;
						IL_3B5:
						base.OnLoaded(sender, e);
						this.a = true;
						num = (short)668336134;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (obj != null)
						{
							num = (short)981467138;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_41A;
					case 6:
						goto IL_3DC;
					case 7:
						if (obj != null)
						{
							num = (short)287113217;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_45B;
					case 8:
						goto IL_385;
					case 9:
						goto IL_276;
					case 10:
						obj = null;
						obj = this.RecNavToolbarExpanderControlHeadE5E5.MyRecordsetDataSource;
						num = (short)93388801;
						if (num != 0)
						{
						}
						num = (short)1151467525;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_41A;
					case 12:
						if (!this.a)
						{
							num = (short)277676042;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4A4;
					}
					goto IL_63;
					IL_276:
					global::System.Windows.Data.CollectionView collectionView3 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
					this.RecNavToolbarExpanderControlHeadE5E5NavigationControlsTable.MyDataPresenter = this.ExpanderControlHeadE5E5NavigationControlsTable;
					num = (short)108527624;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_385:
					acpExpander = null;
					enumerator = this.MyStackPanel.Children.GetEnumerator();
					num = (short)223412228;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_41A:
					obj = this.RecNavToolbarExpanderControlHeadE5BottomFunctionProgrammableButtonTable.MyRecordsetDataSource;
					num = (short)538378247;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_45B:
					obj = this.RecNavToolbarExpanderControlHeadE5E5NavigationControlsTable.MyRecordsetDataSource;
					num = (short)923795459;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_3DC:
				IL_4A4:
				this.PostOnLoaded(sender, e);
				this.MyStackPanel.Children[0].Focus();
				return;
				IL_63:
				this.PreOnLoaded(sender, e);
				num = (short)122028044;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
		}

		// Token: 0x06008C96 RID: 35990 RVA: 0x0083C82C File Offset: 0x0083AA2C
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
					goto IL_13D;
				case 1:
					return;
				case 2:
				{
					num2 = (short)216072192;
					short num3 = num2;
					if (this.a)
					{
						num2 = (short)1989148673;
						if (num2 != 0)
						{
						}
						num2 = (short)1787494400;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			this.PreOnUnloaded(sender, e);
			this.RecNavToolbarExpanderControlHeadE5E5.DataContext = null;
			this.RecNavToolbarExpanderControlHeadE5E5.MyDataPresenter = null;
			this.RecNavToolbarExpanderControlHeadE5E5NavigationControlsTable.DataContext = null;
			this.RecNavToolbarExpanderControlHeadE5E5NavigationControlsTable.MyDataPresenter = null;
			this.RecNavToolbarExpanderControlHeadE5BottomFunctionProgrammableButtonTable.DataContext = null;
			this.RecNavToolbarExpanderControlHeadE5BottomFunctionProgrammableButtonTable.MyDataPresenter = null;
			num2 = (short)614578628;
			short num4 = num2;
			num2 = (short)1933490628;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_13D:
				base.OnUnloaded(sender, e);
				this.a = false;
				num2 = (short)1538064385;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)566886400;
				if (num2 != 0)
				{
				}
				num2 = (short)1807286274;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06008C97 RID: 35991 RVA: 0x0083C9A0 File Offset: 0x0083ABA0
		public override void SetDataContext()
		{
			short num = (short)819265568;
			int num2 = (int)((global::System.IntPtr)num);
			object feature;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1074724894;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)635961358;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)1927610389;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_656;
				case 3:
					goto IL_219;
				case 4:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadE5BottomFunctionProgrammableButtonTable).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10903].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadE5BottomFunctionProgrammableButtonTable).SyncDataSources();
					num = (short)1486225420;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(4236);
					num = (short)342097923;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(4236);
					num = (short)1123549194;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadE5E5).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10902].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadE5E5).SyncDataSources();
					num = (short)1120862217;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10902] != null)
					{
						num = (short)657719318;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_656;
				case 9:
					goto IL_656;
				case 10:
					if (feature != null)
					{
						num = (short)182911004;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_656;
				case 11:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)1902772230;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadE5E5).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadE5BottomFunctionProgrammableButtonTable).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadE5E5NavigationControlsTable).MySecondaryRecordsetDataSource = null;
					num = (short)1363673107;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					goto IL_F9;
				case 13:
					num = (short)661258260;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10903].EmbeddedRecset != null)
					{
						num = (short)898629636;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F9;
				case 15:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10902].EmbeddedRecset != null)
					{
						num = (short)1355612167;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_656;
				case 16:
				{
					num = (short)431012264;
					short num3 = num;
					num = (short)861518248;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_116;
					default:
						num = (short)1946025984;
						if (num != 0)
						{
						}
						if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
						{
							num = (short)446431232;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F9;
					}
					break;
				}
				case 17:
					if (feature != null)
					{
						num = (short)766312475;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F9;
				case 18:
					num = (short)1760493599;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					return;
				case 20:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10896].EmbeddedRecset != null)
					{
						num = (short)286916633;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 21:
					num = (short)760021000;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					num = (short)984612879;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					num = (short)649461761;
					if (num != 0)
					{
					}
					goto IL_219;
				case 24:
					num = (short)1996161050;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					goto IL_3FE;
				case 26:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)219938834;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 27:
					num = (short)1042743312;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 28:
					num = (short)1753808898;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 29:
					if (feature != null)
					{
						goto IL_116;
					}
					return;
				case 30:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10903] != null)
					{
						num = (short)1562443777;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F9;
				case 31:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10896] != null)
					{
						num = (short)1720778765;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 32:
					switch (0)
					{
					case 0:
						goto IL_A9;
					}
					continue;
				}
				IL_A9:
				num = (short)597032960;
				short num4 = num;
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)1646854149;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(4236);
				num = (short)417529879;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_F9:
				num = (short)735772701;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_116:
				num = (short)307691544;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_219:
				num = (short)1349320715;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_656:
				num = (short)1227751441;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_3FE:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadE5E5NavigationControlsTable).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10896].EmbeddedRecset;
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadE5E5NavigationControlsTable).SyncDataSources();
		}

		// Token: 0x06008C98 RID: 35992 RVA: 0x0083D040 File Offset: 0x0083B240
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)339515256;
			short num2 = num;
			num = (short)1355126648;
			switch (num2 == num)
			{
			}
			num = (short)519766016;
			if (num != 0)
			{
			}
			num = (short)1324023808;
			short num3 = num;
			num = (short)1967063041;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x06008C99 RID: 35993 RVA: 0x0083D0F0 File Offset: 0x0083B2F0
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1133387356;
			short num2 = num;
			num = (short)1849499228;
			switch (num2 == num)
			{
			}
			num = (short)2136997889;
			if (num != 0)
			{
			}
			num = (short)2100101120;
			short num3 = num;
			num = (short)2146500608;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06008C9A RID: 35994 RVA: 0x0083D1A0 File Offset: 0x0083B3A0
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 8;
			short num = (short)2135687168;
			switch (num)
			{
			default:
			{
				num = (short)1132396564;
				int num2 = (int)((global::System.IntPtr)num);
				object myRecordsetDataSource2;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
					{
						object myRecordsetDataSource;
						if (myRecordsetDataSource != null)
						{
							num = (short)1440088085;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4AE;
					}
					case 2:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource = this.RecNavToolbarExpanderControlHeadE5E5.MyRecordsetDataSource;
						num = (short)199163905;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("鯈껊껌臎냐ꗒ臔룖뛘럚뿜뻞鏠ꛢ鷤韦裨藪觬諮菰냲髴駶跸觺鋼鏾䤀昂搄挆䰈㸊䠌㨎", a_))
						{
							num = (short)861011976;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4AE;
					case 4:
						if (myRecordsetDataSource2 != null)
						{
							num = (short)1754529801;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 5:
						goto IL_4AE;
					case 6:
					{
						object myRecordsetDataSource3;
						if (myRecordsetDataSource3 != null)
						{
							num = (short)434700301;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DB;
					}
					case 7:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)11599894;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)1581121546;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_4A9;
					case 9:
						goto IL_26C;
					case 10:
						goto IL_DB;
					case 11:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1600847874;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)2128412677;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)746979331;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						num = (short)1119551488;
						short num3 = num;
						object myRecordsetDataSource3;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource3);
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInner item = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInner)collectionView.CurrentItem;
						collectionView.MoveCurrentTo(item);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)1729822737;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
					{
						num = (short)1143789636;
						short num4 = num;
						num = (short)1563416644;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4A9;
						default:
							num = (short)300548096;
							if (num != 0)
							{
							}
							num = (short)992935937;
							if (num != 0)
							{
							}
							num = (short)1089208336;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 15:
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						myRecordsetDataSource2 = this.RecNavToolbarExpanderControlHeadE5E5NavigationControlsTable.MyRecordsetDataSource;
						num = (short)113639428;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)556466191;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)362872832;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_DB;
					case 18:
						num = (short)652673031;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("鯈껊껌臎냐ꗒ臔룖뛘럚뿜뻞鏠ꛢ鷤韦裨藪觬諮菰냲髴駶跸觺鋼鏾䤀昂搄挆䰈㸊䠌㨎弐爒挔縖縘稚検瘞丠䴢昤䠦䜨弪弬䀮崰䀲愴嘶嬸场堼", a_))
						{
							num = (short)1116012558;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 20:
						switch (0)
						{
						case 0:
							goto IL_B2;
						}
						continue;
					case 21:
					{
						object myRecordsetDataSource;
						global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5Inner item2 = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5Inner)collectionView2.CurrentItem;
						collectionView2.MoveCurrentTo(item2);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)125698071;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource3 = this.RecNavToolbarExpanderControlHeadE5BottomFunctionProgrammableButtonTable.MyRecordsetDataSource;
						num = (short)206700550;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
						goto IL_4AE;
					case 24:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("鯈껊껌臎냐ꗒ臔룖뛘럚뿜뻞鏠ꛢ鷤韦裨藪觬諮菰냲髴駶跸觺鋼鏾䤀昂搄挆䰈㸊伌怎攐朒稔稖弘渚猜簞唠䨢䨤䤦礨太䈬䠮䌰刲場娶堸夺儼娾̀㙂ㅄ㍆♈╊᥌⹎㍐㽒ご", a_))
						{
							num = (short)1902837778;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DB;
					}
					IL_B2:
					if (A_0 is global::AcpUI.AcpRecNavToolbar)
					{
						num = (short)523960332;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_DB:
					num = (short)1596063763;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4A9:
					num = (short)118882315;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4AE:
					num = (short)385286168;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_26C:
				global::System.Windows.Data.CollectionView collectionView3 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource2);
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5NavigationControlsTableInner item3 = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5NavigationControlsTableInner)collectionView3.CurrentItem;
				collectionView3.MoveCurrentTo(item3);
				((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
				return;
			}
			}
		}

		// Token: 0x06008C9B RID: 35995 RVA: 0x0083D738 File Offset: 0x0083B938
		internal void OnExpanderControlHeadE5E5Click(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_93;
			}
			short num;
			object myRecordsetDataSource;
			int num4;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5Inner item;
			for (;;)
			{
				IL_0A:
				num = (short)2085759204;
				short num2 = num;
				num = (short)1370630372;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				case 1:
					goto IL_6B;
				default:
				{
					num = (short)1791229952;
					short num3 = num;
					goto IL_6B;
				}
				}
				IL_DC:
				if (myRecordsetDataSource != null)
				{
					num = (short)641138689;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_6B:
				num = (short)1501757440;
				if (num != 0)
				{
				}
				switch (num4)
				{
				case 0:
					goto IL_DC;
				case 1:
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderControlHeadE5E5.SyncDataSources();
					num = (short)362479618;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_12C;
				}
				goto IL_93;
			}
			IL_12C:
			num = (short)621674497;
			if (num != 0)
			{
			}
			this.RecNavToolbarExpanderControlHeadE5E5.TableMode = false;
			return;
			IL_93:
			item = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5Inner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderControlHeadE5E5.MyRecordsetDataSource;
			num = (short)271908864;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06008C9C RID: 35996 RVA: 0x0083D8A8 File Offset: 0x0083BAA8
		internal void OnExpanderControlHeadE5E5NavigationControlsTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_93;
			}
			short num;
			object myRecordsetDataSource;
			int num4;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5NavigationControlsTableInner item;
			for (;;)
			{
				IL_0A:
				num = (short)47445855;
				short num2 = num;
				num = (short)1733097311;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				case 1:
					goto IL_6A;
				default:
				{
					num = (short)1600651264;
					short num3 = num;
					goto IL_6A;
				}
				}
				IL_DB:
				if (myRecordsetDataSource != null)
				{
					num = (short)68550657;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_6A:
				num = (short)1008336896;
				if (num != 0)
				{
				}
				switch (num4)
				{
				case 0:
					goto IL_DB;
				case 1:
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderControlHeadE5E5NavigationControlsTable.SyncDataSources();
					num = (short)1793196033;
					if (num != 0)
					{
					}
					num = (short)1312096258;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_155;
				}
				goto IL_93;
			}
			IL_155:
			this.RecNavToolbarExpanderControlHeadE5E5NavigationControlsTable.TableMode = false;
			return;
			IL_93:
			item = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5NavigationControlsTableInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderControlHeadE5E5NavigationControlsTable.MyRecordsetDataSource;
			num = (short)589627392;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06008C9D RID: 35997 RVA: 0x0083DA18 File Offset: 0x0083BC18
		internal void OnExpanderControlHeadE5BottomFunctionProgrammableButtonTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_B8;
			}
			short num;
			int num4;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInner item;
			for (;;)
			{
				IL_0A:
				num = (short)1057357825;
				if (num != 0)
				{
				}
				num = (short)548339712;
				short num2 = num;
				num = (short)1196166771;
				short num3 = num;
				num = (short)383979123;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1382416384;
					if (num != 0)
					{
					}
					switch (num4)
					{
					case 0:
						goto IL_102;
					case 1:
						((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
						this.RecNavToolbarExpanderControlHeadE5BottomFunctionProgrammableButtonTable.SyncDataSources();
						num = (short)1984299010;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_153;
					}
					goto IL_B8;
				}
				IL_102:
				if (myRecordsetDataSource == null)
				{
					break;
				}
				num = (short)392298497;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_153:
			this.RecNavToolbarExpanderControlHeadE5BottomFunctionProgrammableButtonTable.TableMode = false;
			return;
			IL_B8:
			item = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderControlHeadE5BottomFunctionProgrammableButtonTable.MyRecordsetDataSource;
			num = (short)1746141184;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06008C9E RID: 35998 RVA: 0x0083DB88 File Offset: 0x0083BD88
		private void PreOnLoaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)151497645;
			short num2 = num;
			num = (short)1211214765;
			switch (num2 == num)
			{
			}
			num = (short)2094137345;
			if (num != 0)
			{
			}
			num = (short)719781888;
			short num3 = num;
			num = (short)1303642112;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008C9F RID: 35999 RVA: 0x0083DC30 File Offset: 0x0083BE30
		private void PostOnLoaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1545879396;
			short num2 = num;
			num = (short)1200701284;
			switch (num2 == num)
			{
			}
			num = (short)338296833;
			if (num != 0)
			{
			}
			num = (short)1014824960;
			short num3 = num;
			num = (short)148439040;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008CA0 RID: 36000 RVA: 0x0083DCD8 File Offset: 0x0083BED8
		private void PreOnUnloaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)2117074945;
			if (num != 0)
			{
			}
			num = (short)680067345;
			short num2 = num;
			num = (short)1283391761;
			switch (num2 == num)
			{
			}
			num = (short)57868288;
			short num3 = num;
			num = (short)2106130432;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008CA1 RID: 36001 RVA: 0x0083DD84 File Offset: 0x0083BF84
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 17;
			short num = (short)147746315;
			short num2 = num;
			num = (short)1834577419;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)421003264;
				short num3 = num;
				num = (short)316407809;
				if (num != 0)
				{
				}
				num = (short)1024262144;
				if (num != 0)
				{
				}
				if (!this.b)
				{
					this.b = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("﷑闓뫕듗鳙맛뿝铟韡難菥鯧퇩迫臭鷯英鯳飵鷷铹裻퇽狿持怃漅朇⼉㸋㸍甏怑猓礕瘗甙焛眝䌟儡ģᐥᠧ䤩䌫䀭嘯嬱匳䌵䨷嬹䠻圽⼿ⱁ歃╅❇⑉㡋㱍㽏㹑❓祕㭗㕙㉛⩝቟ൡࡣ䍥婧婩ѫ୭ᅯᙱ关䑵䡷坹奻䱽끿놃ꦅ揄﶑ﺕﶗﮙﮝ閟財\udca3장얧용", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				break;
			}
			}
		}

		// Token: 0x06008CA2 RID: 36002 RVA: 0x0083DE68 File Offset: 0x0083C068
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1135869952;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 1:
					num = (short)937951234;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_2EB;
				}
				IL_30:
				switch (connectionId)
				{
				case 1:
					goto IL_73F;
				case 2:
				case 3:
				case 4:
				case 5:
				case 6:
				case 7:
				case 8:
				case 9:
				case 10:
					goto IL_9F0;
				case 11:
					goto IL_49D;
				case 12:
					goto IL_42B;
				case 13:
					goto IL_862;
				case 14:
					goto IL_886;
				case 15:
					goto IL_6E8;
				case 16:
					goto IL_4F5;
				case 17:
					goto IL_9E3;
				case 18:
					goto IL_70C;
				case 19:
					goto IL_5ED;
				case 20:
					goto IL_770;
				case 21:
					goto IL_255;
				case 22:
					goto IL_490;
				case 23:
					goto IL_4DB;
				case 24:
					goto IL_2FD;
				case 25:
					goto IL_5A2;
				case 26:
					goto IL_502;
				case 27:
					goto IL_2F0;
				case 28:
					goto IL_6DB;
				case 29:
					goto IL_23B;
				case 30:
					goto IL_3C6;
				case 31:
					goto IL_930;
				case 32:
					goto IL_289;
				case 33:
					goto IL_30A;
				case 34:
					goto IL_411;
				case 35:
					goto IL_404;
				case 36:
					goto IL_4B7;
				case 37:
					goto IL_3F7;
				case 38:
					goto IL_51C;
				case 39:
					goto IL_3B9;
				case 40:
					goto IL_9BC;
				case 41:
					goto IL_97B;
				case 42:
					goto IL_8E8;
				case 43:
					goto IL_45C;
				case 44:
					goto IL_80D;
				case 45:
					goto IL_476;
				case 46:
					goto IL_355;
				case 47:
					goto IL_348;
				case 48:
					goto IL_5BC;
				case 49:
					goto IL_794;
				case 50:
					goto IL_638;
				case 51:
					goto IL_2C7;
				case 52:
					goto IL_690;
				case 53:
					goto IL_62B;
				case 54:
					goto IL_645;
				case 55:
					goto IL_9C9;
				case 56:
					goto IL_44F;
				case 57:
					goto IL_683;
				case 58:
					goto IL_8DB;
				case 59:
					goto IL_41E;
				case 60:
					goto IL_8B7;
				case 61:
					goto IL_831;
				case 62:
					goto IL_5C9;
				case 63:
					goto IL_652;
				case 64:
					goto IL_22E;
				case 65:
					goto IL_27C;
				case 66:
					goto IL_607;
				case 67:
					goto IL_5AF;
				case 68:
					goto IL_6B7;
				case 69:
					goto IL_50F;
				case 70:
					goto IL_69D;
				case 71:
					goto IL_362;
				case 72:
					goto IL_90C;
				case 73:
					goto IL_8AA;
				case 74:
					goto IL_7E9;
				case 75:
					goto IL_262;
				case 76:
					goto IL_9A2;
				case 77:
					goto IL_221;
				case 78:
					goto IL_7C5;
				case 79:
					goto IL_7B8;
				case 80:
					goto IL_54D;
				case 81:
					goto IL_469;
				case 82:
					goto IL_5FA;
				case 83:
					goto IL_96E;
				case 84:
					goto IL_4E8;
				case 85:
					goto IL_324;
				case 86:
					goto IL_6AA;
				case 87:
					goto IL_3EA;
				case 88:
					goto IL_248;
				case 89:
					goto IL_961;
				case 90:
					goto IL_540;
				case 91:
					goto IL_571;
				case 92:
					goto IL_483;
				case 93:
					goto IL_2AD;
				case 94:
					goto IL_57E;
				case 95:
					goto IL_317;
				case 96:
					goto IL_83E;
				case 97:
					goto IL_26F;
				case 98:
					goto IL_4AA;
				case 99:
					goto IL_995;
				case 100:
					goto IL_65F;
				case 101:
					goto IL_9AF;
				case 102:
					goto IL_93D;
				case 103:
					goto IL_2BA;
				case 104:
					goto IL_988;
				case 105:
					goto IL_9D6;
				default:
				{
					num = (short)930938880;
					short num3 = num;
					num = (short)1251868673;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
			IL_221:
			this.E5BottomFunctionButtonFeature_43758Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_22E:
			this.CpyBtnE5BottomFunctionButtonName_43756 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_23B:
			this.gridExpanderControlHeadE5E5SRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_248:
			this.ExpanderControlHeadE5E5NavigationControlsTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_255:
			this.ExpanderControlHeadE5E5GeneralExpanderGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_262:
			this.RTDBtnE5BottomFunctionButtonFeature_43758 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_26F:
			this.RTDBtnE5UpDownButtonName_43753 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_27C:
			this.E5BottomFunctionButtonName_43756Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_289:
			this.LblCHE5EmergencyButtonName_43766 = (global::AcpUI.AcpLabel)target;
			this.LblCHE5EmergencyButtonName_43766.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2AD:
			this.gridExpanderControlHeadE5E5NavigationControlsTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_2BA:
			this.RTDBtnRadErgoControlE5UpDownButton_43752 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2C7:
			this.ExpanderControlHeadE5BottomFunctionProgrammableButtonTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_2EB:
			goto IL_9F0;
			IL_2F0:
			this.CHE5EmergencyButtonFeature_43768_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_2FD:
			this.ExpanderControlHeadE5E5 = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_30A:
			this.RTDBtnCHE5EmergencyButtonName_43766 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_317:
			this.CVBtnE5UpDownButtonName_43753 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_324:
			this.RecNavToolbarExpanderControlHeadE5E5NavigationControlsTable = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderControlHeadE5E5NavigationControlsTable.ModeClick += this.OnModeClick;
			return;
			IL_348:
			this.CHE5EmergencyButtonFeature_43768Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_355:
			this.CpyBtnCHE5EmergencyButtonFeature_43768 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_362:
			num = (short)124507742;
			short num4 = num;
			num = (short)1844762206;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_248;
			default:
				num = (short)1707278336;
				if (num != 0)
				{
				}
				this.E5BottomFunctionButtonBCO_43757Comp = (global::AcpUI.AcpLabel)target;
				return;
			}
			IL_3B9:
			this.RTDBtnCHE5EmergencyButtonBCO_43767 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3C6:
			this.CHE5EmergencyButtonName_43766 = (global::AcpUI.AcpLabel)target;
			this.CHE5EmergencyButtonName_43766.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3EA:
			this.ExpanderControlHeadE5E5NavigationControlsTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_3F7:
			this.CVBtnCHE5EmergencyButtonBCO_43767 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_404:
			this.CHE5EmergencyButtonName_43766Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_411:
			this.CpyBtnCHE5EmergencyButtonName_43766 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_41E:
			this.gridExpanderControlHeadE5BottomFunctionProgrammableButtonTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_42B:
			this.HLinkControlHeadE5GraphicalView = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkControlHeadE5GraphicalView.Click += this.HLinkClick;
			return;
			IL_44F:
			this.E5BottomFunctionButtonFeature_43758_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_45C:
			this.CVBtnCHE5EmergencyButtonFeature_43768 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_469:
			this.RTDBtnE5BottomFunctionButtonIndex_43759 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_476:
			this.RTDBtnCHE5EmergencyButtonFeature_43768 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_483:
			this.ExpanderControlHeadE5E5NavigationControlsTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_490:
			this.ExpanderControlHeadE5E5Grid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_49D:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_4AA:
			this.CpyBtnE5UpDownButtonName_43753 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4B7:
			this.CHE5EmergencyButtonBCO_43767 = (global::AcpUI.AcpComboBox)target;
			this.CHE5EmergencyButtonBCO_43767.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4DB:
			this.ExpanderControlHeadE5E5TableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_4E8:
			this.ExpanderControlHeadE5E5NavigationControlsExpander = (global::AcpUI.AcpExpander)target;
			return;
			IL_4F5:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_502:
			this.CHE5EmergencyButtonBCO_43767_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_50F:
			this.RTDBtnE5BottomFunctionButtonBCO_43757 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_51C:
			this.LblCHE5EmergencyButtonBCO_43767 = (global::AcpUI.AcpLabel)target;
			this.LblCHE5EmergencyButtonBCO_43767.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_540:
			this.E5UpDownButtonName_43753_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_54D:
			this.LblE5BottomFunctionButtonIndex_43759 = (global::AcpUI.AcpLabel)target;
			this.LblE5BottomFunctionButtonIndex_43759.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_571:
			this.RadErgoControlE5UpDownButton_43752_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_57E:
			this.E5UpDownButtonName_43753 = (global::AcpUI.AcpLabel)target;
			this.E5UpDownButtonName_43753.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5A2:
			this.CHE5EmergencyButtonName_437666_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_5AF:
			this.CVBtnE5BottomFunctionButtonBCO_43757 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5BC:
			this.ExpanderControlHeadE5E5BottomFunctionProgrammableButtonExpander_43754 = (global::AcpUI.AcpExpander)target;
			return;
			IL_5C9:
			this.LblE5BottomFunctionButtonName_43756 = (global::AcpUI.AcpLabel)target;
			this.LblE5BottomFunctionButtonName_43756.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5ED:
			this.ExpanderControlHeadE5E5GeneralExpander = (global::AcpUI.AcpExpander)target;
			return;
			IL_5FA:
			this.CpyBtnE5BottomFunctionButtonIndex_43759 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_607:
			this.E5BottomFunctionButtonBCO_43757 = (global::AcpUI.AcpComboBox)target;
			this.E5BottomFunctionButtonBCO_43757.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_62B:
			this.ExpanderControlHeadE5E5BottomFunctionProgrammableButton_43755 = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_638:
			this.ExpanderControlHeadE5BottomFunctionProgrammableButtonGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_645:
			this.E5BottomFunctionButtonName_43756_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_652:
			this.RTDBtnE5BottomFunctionButtonName_43756 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_65F:
			this.RadErgoControlE5UpDownButton_43752 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoControlE5UpDownButton_43752.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_683:
			this.E5BottomFunctionButtonIndex_43759_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_690:
			this.ExpanderControlHeadE5BottomFunctionProgrammableButtonTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_69D:
			this.CpyBtnE5BottomFunctionButtonBCO_43757 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_6AA:
			this.ExpanderControlHeadE5E5NavigationControlsExpanderGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_6B7:
			this.LblE5BottomFunctionButtonBCO_43757 = (global::AcpUI.AcpLabel)target;
			this.LblE5BottomFunctionButtonBCO_43757.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_6DB:
			this.ExpanderControlHeadE5E5SRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_6E8:
			this.HLinkE5NavigationControlsExpander = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkE5NavigationControlsExpander.Click += this.HLinkClick;
			return;
			IL_70C:
			num = (short)1975975937;
			if (num != 0)
			{
			}
			this.myE5GraphicView = (global::ControlHeadGraphicView.E5GraphicView)target;
			return;
			IL_73F:
			((global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.PageControlHeadE5)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.PageControlHeadE5)target).Unloaded += this.OnUnloaded;
			return;
			IL_770:
			this.RecNavToolbarExpanderControlHeadE5E5 = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderControlHeadE5E5.ModeClick += this.OnModeClick;
			return;
			IL_794:
			this.RecNavToolbarExpanderControlHeadE5BottomFunctionProgrammableButtonTable = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderControlHeadE5BottomFunctionProgrammableButtonTable.ModeClick += this.OnModeClick;
			return;
			IL_7B8:
			this.CVBtnE5BottomFunctionButtonIndex_43759 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_7C5:
			this.E5BottomFunctionButtonIndex_43759 = (global::AcpUI.AcpComboBox)target;
			this.E5BottomFunctionButtonIndex_43759.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_7E9:
			this.LblE5BottomFunctionButtonFeature_43758 = (global::AcpUI.AcpLabel)target;
			this.LblE5BottomFunctionButtonFeature_43758.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_80D:
			this.LblCHE5EmergencyButtonFeature_43768 = (global::AcpUI.AcpLabel)target;
			this.LblCHE5EmergencyButtonFeature_43768.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_831:
			this.CVBtnE5BottomFunctionButtonName_43756 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_83E:
			this.LblE5UpDownButtonName_43753 = (global::AcpUI.AcpLabel)target;
			this.LblE5UpDownButtonName_43753.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_862:
			this.HLinkE5GeneralExpander = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkE5GeneralExpander.Click += this.HLinkClick;
			return;
			IL_886:
			this.HLinkE5BottomFunctionProgrammableButtonExpander_43754 = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkE5BottomFunctionProgrammableButtonExpander_43754.Click += this.HLinkClick;
			return;
			IL_8AA:
			this.CVBtnE5BottomFunctionButtonFeature_43758 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_8B7:
			this.E5BottomFunctionButtonName_43756 = (global::AcpUI.AcpLabel)target;
			this.E5BottomFunctionButtonName_43756.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_8DB:
			this.ExpanderControlHeadE5BottomFunctionProgrammableButtonTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_8E8:
			this.CHE5EmergencyButtonFeature_43768 = (global::AcpUI.AcpComboBox)target;
			this.CHE5EmergencyButtonFeature_43768.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_90C:
			this.E5BottomFunctionButtonFeature_43758 = (global::AcpUI.AcpComboBox)target;
			this.E5BottomFunctionButtonFeature_43758.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_930:
			this.CVBtnCHE5EmergencyButtonName_43766 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_93D:
			this.LblRadErgoControlE5UpDownButton_43752 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoControlE5UpDownButton_43752.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_961:
			this.ExpanderControlHeadE5E5NavigationControlsTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_96E:
			this.E5BottomFunctionButtonIndex_43759Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_97B:
			this.CHE5EmergencyButtonBCO_43767Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_988:
			this.CpyBtnRadErgoControlE5UpDownButton_43752 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_995:
			this.E5UpDownButtonName_43753Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_9A2:
			this.CpyBtnE5BottomFunctionButtonFeature_43758 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9AF:
			this.CVBtnRadErgoControlE5UpDownButton_43752 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_9BC:
			this.CpyBtnCHE5EmergencyButtonBCO_43767 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9C9:
			this.E5BottomFunctionButtonBCO_43757_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_9D6:
			this.RadErgoControlE5UpDownButton_43752Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_9E3:
			this.ExpanderControlHeadE5GraphicalView = (global::AcpUI.AcpExpander)target;
			return;
			IL_9F0:
			this.b = true;
		}

		// Token: 0x06008CA3 RID: 36003 RVA: 0x0083E86C File Offset: 0x0083CA6C
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 2:
			{
				short num = (short)334260793;
				short num2 = num;
				num = (short)635923001;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1596325888;
					short num3 = num;
					num = (short)1686962176;
					if (num != 0)
					{
					}
					((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				}
				}
				break;
			}
			case 3:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 4:
			{
				short num = (short)289734657;
				if (num != 0)
				{
				}
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			case 5:
				((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 6:
				break;
			case 7:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 8:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 9:
				((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 10:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			default:
				return;
			}
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x040043F7 RID: 17399
		private bool a;

		// Token: 0x040043F8 RID: 17400
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x040043F9 RID: 17401
		internal global::System.Windows.Documents.Hyperlink HLinkControlHeadE5GraphicalView;

		// Token: 0x040043FA RID: 17402
		internal global::System.Windows.Documents.Hyperlink HLinkE5GeneralExpander;

		// Token: 0x040043FB RID: 17403
		internal global::System.Windows.Documents.Hyperlink HLinkE5BottomFunctionProgrammableButtonExpander_43754;

		// Token: 0x040043FC RID: 17404
		internal global::System.Windows.Documents.Hyperlink HLinkE5NavigationControlsExpander;

		// Token: 0x040043FD RID: 17405
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x040043FE RID: 17406
		internal global::AcpUI.AcpExpander ExpanderControlHeadE5GraphicalView;

		// Token: 0x040043FF RID: 17407
		internal global::ControlHeadGraphicView.E5GraphicView myE5GraphicView;

		// Token: 0x04004400 RID: 17408
		internal global::AcpUI.AcpExpander ExpanderControlHeadE5E5GeneralExpander;

		// Token: 0x04004401 RID: 17409
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderControlHeadE5E5;

		// Token: 0x04004402 RID: 17410
		internal global::System.Windows.Controls.Grid ExpanderControlHeadE5E5GeneralExpanderGrid;

		// Token: 0x04004403 RID: 17411
		internal global::System.Windows.Controls.Grid ExpanderControlHeadE5E5Grid;

		// Token: 0x04004404 RID: 17412
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadE5E5TableView;

		// Token: 0x04004405 RID: 17413
		internal global::AcpUI.AcpXamDataPresenter ExpanderControlHeadE5E5;

		// Token: 0x04004406 RID: 17414
		internal global::Infragistics.Windows.DataPresenter.UnboundField CHE5EmergencyButtonName_437666_Col;

		// Token: 0x04004407 RID: 17415
		internal global::Infragistics.Windows.DataPresenter.UnboundField CHE5EmergencyButtonBCO_43767_Col;

		// Token: 0x04004408 RID: 17416
		internal global::Infragistics.Windows.DataPresenter.UnboundField CHE5EmergencyButtonFeature_43768_Col;

		// Token: 0x04004409 RID: 17417
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadE5E5SRecView;

		// Token: 0x0400440A RID: 17418
		internal global::System.Windows.Controls.Grid gridExpanderControlHeadE5E5SRecView;

		// Token: 0x0400440B RID: 17419
		internal global::AcpUI.AcpLabel CHE5EmergencyButtonName_43766;

		// Token: 0x0400440C RID: 17420
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCHE5EmergencyButtonName_43766;

		// Token: 0x0400440D RID: 17421
		internal global::AcpUI.AcpLabel LblCHE5EmergencyButtonName_43766;

		// Token: 0x0400440E RID: 17422
		internal global::AcpUI.AcpRtdButton RTDBtnCHE5EmergencyButtonName_43766;

		// Token: 0x0400440F RID: 17423
		internal global::AcpUI.AcpCopyButton CpyBtnCHE5EmergencyButtonName_43766;

		// Token: 0x04004410 RID: 17424
		internal global::AcpUI.AcpLabel CHE5EmergencyButtonName_43766Comp;

		// Token: 0x04004411 RID: 17425
		internal global::AcpUI.AcpComboBox CHE5EmergencyButtonBCO_43767;

		// Token: 0x04004412 RID: 17426
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCHE5EmergencyButtonBCO_43767;

		// Token: 0x04004413 RID: 17427
		internal global::AcpUI.AcpLabel LblCHE5EmergencyButtonBCO_43767;

		// Token: 0x04004414 RID: 17428
		internal global::AcpUI.AcpRtdButton RTDBtnCHE5EmergencyButtonBCO_43767;

		// Token: 0x04004415 RID: 17429
		internal global::AcpUI.AcpCopyButton CpyBtnCHE5EmergencyButtonBCO_43767;

		// Token: 0x04004416 RID: 17430
		internal global::AcpUI.AcpLabel CHE5EmergencyButtonBCO_43767Comp;

		// Token: 0x04004417 RID: 17431
		internal global::AcpUI.AcpComboBox CHE5EmergencyButtonFeature_43768;

		// Token: 0x04004418 RID: 17432
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCHE5EmergencyButtonFeature_43768;

		// Token: 0x04004419 RID: 17433
		internal global::AcpUI.AcpLabel LblCHE5EmergencyButtonFeature_43768;

		// Token: 0x0400441A RID: 17434
		internal global::AcpUI.AcpRtdButton RTDBtnCHE5EmergencyButtonFeature_43768;

		// Token: 0x0400441B RID: 17435
		internal global::AcpUI.AcpCopyButton CpyBtnCHE5EmergencyButtonFeature_43768;

		// Token: 0x0400441C RID: 17436
		internal global::AcpUI.AcpLabel CHE5EmergencyButtonFeature_43768Comp;

		// Token: 0x0400441D RID: 17437
		internal global::AcpUI.AcpExpander ExpanderControlHeadE5E5BottomFunctionProgrammableButtonExpander_43754;

		// Token: 0x0400441E RID: 17438
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderControlHeadE5BottomFunctionProgrammableButtonTable;

		// Token: 0x0400441F RID: 17439
		internal global::System.Windows.Controls.Grid ExpanderControlHeadE5BottomFunctionProgrammableButtonGrid;

		// Token: 0x04004420 RID: 17440
		internal global::System.Windows.Controls.Grid ExpanderControlHeadE5BottomFunctionProgrammableButtonTableGrid;

		// Token: 0x04004421 RID: 17441
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadE5BottomFunctionProgrammableButtonTableTableView;

		// Token: 0x04004422 RID: 17442
		internal global::AcpUI.AcpXamDataPresenter ExpanderControlHeadE5E5BottomFunctionProgrammableButton_43755;

		// Token: 0x04004423 RID: 17443
		internal global::Infragistics.Windows.DataPresenter.UnboundField E5BottomFunctionButtonName_43756_Col;

		// Token: 0x04004424 RID: 17444
		internal global::Infragistics.Windows.DataPresenter.UnboundField E5BottomFunctionButtonBCO_43757_Col;

		// Token: 0x04004425 RID: 17445
		internal global::Infragistics.Windows.DataPresenter.UnboundField E5BottomFunctionButtonFeature_43758_Col;

		// Token: 0x04004426 RID: 17446
		internal global::Infragistics.Windows.DataPresenter.UnboundField E5BottomFunctionButtonIndex_43759_Col;

		// Token: 0x04004427 RID: 17447
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadE5BottomFunctionProgrammableButtonTableSRecView;

		// Token: 0x04004428 RID: 17448
		internal global::System.Windows.Controls.Grid gridExpanderControlHeadE5BottomFunctionProgrammableButtonTableSRecView;

		// Token: 0x04004429 RID: 17449
		internal global::AcpUI.AcpLabel E5BottomFunctionButtonName_43756;

		// Token: 0x0400442A RID: 17450
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnE5BottomFunctionButtonName_43756;

		// Token: 0x0400442B RID: 17451
		internal global::AcpUI.AcpLabel LblE5BottomFunctionButtonName_43756;

		// Token: 0x0400442C RID: 17452
		internal global::AcpUI.AcpRtdButton RTDBtnE5BottomFunctionButtonName_43756;

		// Token: 0x0400442D RID: 17453
		internal global::AcpUI.AcpCopyButton CpyBtnE5BottomFunctionButtonName_43756;

		// Token: 0x0400442E RID: 17454
		internal global::AcpUI.AcpLabel E5BottomFunctionButtonName_43756Comp;

		// Token: 0x0400442F RID: 17455
		internal global::AcpUI.AcpComboBox E5BottomFunctionButtonBCO_43757;

		// Token: 0x04004430 RID: 17456
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnE5BottomFunctionButtonBCO_43757;

		// Token: 0x04004431 RID: 17457
		internal global::AcpUI.AcpLabel LblE5BottomFunctionButtonBCO_43757;

		// Token: 0x04004432 RID: 17458
		internal global::AcpUI.AcpRtdButton RTDBtnE5BottomFunctionButtonBCO_43757;

		// Token: 0x04004433 RID: 17459
		internal global::AcpUI.AcpCopyButton CpyBtnE5BottomFunctionButtonBCO_43757;

		// Token: 0x04004434 RID: 17460
		internal global::AcpUI.AcpLabel E5BottomFunctionButtonBCO_43757Comp;

		// Token: 0x04004435 RID: 17461
		internal global::AcpUI.AcpComboBox E5BottomFunctionButtonFeature_43758;

		// Token: 0x04004436 RID: 17462
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnE5BottomFunctionButtonFeature_43758;

		// Token: 0x04004437 RID: 17463
		internal global::AcpUI.AcpLabel LblE5BottomFunctionButtonFeature_43758;

		// Token: 0x04004438 RID: 17464
		internal global::AcpUI.AcpRtdButton RTDBtnE5BottomFunctionButtonFeature_43758;

		// Token: 0x04004439 RID: 17465
		internal global::AcpUI.AcpCopyButton CpyBtnE5BottomFunctionButtonFeature_43758;

		// Token: 0x0400443A RID: 17466
		internal global::AcpUI.AcpLabel E5BottomFunctionButtonFeature_43758Comp;

		// Token: 0x0400443B RID: 17467
		internal global::AcpUI.AcpComboBox E5BottomFunctionButtonIndex_43759;

		// Token: 0x0400443C RID: 17468
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnE5BottomFunctionButtonIndex_43759;

		// Token: 0x0400443D RID: 17469
		internal global::AcpUI.AcpLabel LblE5BottomFunctionButtonIndex_43759;

		// Token: 0x0400443E RID: 17470
		internal global::AcpUI.AcpRtdButton RTDBtnE5BottomFunctionButtonIndex_43759;

		// Token: 0x0400443F RID: 17471
		internal global::AcpUI.AcpCopyButton CpyBtnE5BottomFunctionButtonIndex_43759;

		// Token: 0x04004440 RID: 17472
		internal global::AcpUI.AcpLabel E5BottomFunctionButtonIndex_43759Comp;

		// Token: 0x04004441 RID: 17473
		internal global::AcpUI.AcpExpander ExpanderControlHeadE5E5NavigationControlsExpander;

		// Token: 0x04004442 RID: 17474
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderControlHeadE5E5NavigationControlsTable;

		// Token: 0x04004443 RID: 17475
		internal global::System.Windows.Controls.Grid ExpanderControlHeadE5E5NavigationControlsExpanderGrid;

		// Token: 0x04004444 RID: 17476
		internal global::System.Windows.Controls.Grid ExpanderControlHeadE5E5NavigationControlsTableGrid;

		// Token: 0x04004445 RID: 17477
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadE5E5NavigationControlsTableTableView;

		// Token: 0x04004446 RID: 17478
		internal global::AcpUI.AcpXamDataPresenter ExpanderControlHeadE5E5NavigationControlsTable;

		// Token: 0x04004447 RID: 17479
		internal global::Infragistics.Windows.DataPresenter.UnboundField E5UpDownButtonName_43753_Col;

		// Token: 0x04004448 RID: 17480
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoControlE5UpDownButton_43752_Col;

		// Token: 0x04004449 RID: 17481
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadE5E5NavigationControlsTableSRecView;

		// Token: 0x0400444A RID: 17482
		internal global::System.Windows.Controls.Grid gridExpanderControlHeadE5E5NavigationControlsTableSRecView;

		// Token: 0x0400444B RID: 17483
		internal global::AcpUI.AcpLabel E5UpDownButtonName_43753;

		// Token: 0x0400444C RID: 17484
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnE5UpDownButtonName_43753;

		// Token: 0x0400444D RID: 17485
		internal global::AcpUI.AcpLabel LblE5UpDownButtonName_43753;

		// Token: 0x0400444E RID: 17486
		internal global::AcpUI.AcpRtdButton RTDBtnE5UpDownButtonName_43753;

		// Token: 0x0400444F RID: 17487
		internal global::AcpUI.AcpCopyButton CpyBtnE5UpDownButtonName_43753;

		// Token: 0x04004450 RID: 17488
		internal global::AcpUI.AcpLabel E5UpDownButtonName_43753Comp;

		// Token: 0x04004451 RID: 17489
		internal global::AcpUI.AcpComboBox RadErgoControlE5UpDownButton_43752;

		// Token: 0x04004452 RID: 17490
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoControlE5UpDownButton_43752;

		// Token: 0x04004453 RID: 17491
		internal global::AcpUI.AcpLabel LblRadErgoControlE5UpDownButton_43752;

		// Token: 0x04004454 RID: 17492
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoControlE5UpDownButton_43752;

		// Token: 0x04004455 RID: 17493
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoControlE5UpDownButton_43752;

		// Token: 0x04004456 RID: 17494
		internal global::AcpUI.AcpLabel RadErgoControlE5UpDownButton_43752Comp;

		// Token: 0x04004457 RID: 17495
		private bool b;
	}
}
