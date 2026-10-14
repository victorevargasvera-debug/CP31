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
using ConstraintHelper;
using ControlHeadGraphicView;
using Infragistics.Windows.DataPresenter;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO9
{
	// Token: 0x0200034F RID: 847
	public class PageControlHeadO9 : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x06008187 RID: 33159 RVA: 0x007829AC File Offset: 0x00780BAC
		public PageControlHeadO9()
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

		// Token: 0x06008188 RID: 33160 RVA: 0x007829E4 File Offset: 0x00780BE4
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1405222912;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				switch (0)
				{
				case 0:
					goto IL_C2;
				}
				for (;;)
				{
					IL_27:
					object obj;
					switch (num2)
					{
					case 0:
						goto IL_39B;
					case 1:
					{
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderControlHeadO9O9.MyDataPresenter = this.ExpanderControlHeadO9O9;
						num = (short)1362100233;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_343;
					case 3:
					{
						global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderControlHeadO9BottomFunctionButtonBCOList.MyDataPresenter = this.ExpanderControlHeadO9BottomFunctionButtonBCOList;
						num = (short)143982594;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						if (obj != null)
						{
							num = (short)71041034;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_153;
					case 5:
					{
						global::System.Windows.Data.CollectionView collectionView3 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderControlHeadO9O9DataButton.MyDataPresenter = this.ExpanderControlHeadO9O9DataButton;
						num = (short)1421738011;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						if (obj != null)
						{
							num = (short)924450819;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_343;
					case 7:
					{
						global::System.Windows.Data.CollectionView collectionView4 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderControlHeadO9O9NavigationControlsTable.MyDataPresenter = this.ExpanderControlHeadO9O9NavigationControlsTable;
						num = (short)939327511;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_88A;
					case 9:
						goto IL_213;
					case 10:
					{
						global::System.Windows.Data.CollectionView collectionView5 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderControlHeadO9PASirenButtonsList.MyDataPresenter = this.ExpanderControlHeadO9PASirenButtonsList;
						num = (short)1022820377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						if (obj != null)
						{
							num = (short)943849492;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5D1;
					case 12:
						if (!this.a)
						{
							num = (short)570490898;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_919;
					case 13:
						goto IL_36F;
					case 14:
						if (obj != null)
						{
							num = (short)576454687;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2FA;
					case 15:
						if (obj != null)
						{
							num = (short)816447504;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4D1;
					case 16:
					{
						global::System.Windows.Data.CollectionView collectionView6 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderControlHeadO9BottomFunctionProgrammableButtonTable.MyDataPresenter = this.ExpanderControlHeadO9BottomFunctionProgrammableButtonTable;
						num = (short)1218510865;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						goto IL_4D1;
					case 18:
						obj = null;
						obj = this.RecNavToolbarExpanderControlHeadO9O9.MyRecordsetDataSource;
						num = (short)1911685154;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						goto IL_10B;
					case 20:
					{
						global::System.Windows.Data.CollectionView collectionView7 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderControlHeadO9ResponseSelectorList.MyDataPresenter = this.ExpanderControlHeadO9ResponseSelectorList;
						num = (short)2112552981;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						goto IL_5D1;
					case 22:
						goto IL_2FA;
					case 23:
						goto IL_519;
					case 24:
						if (obj != null)
						{
							num = (short)2106064903;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_519;
					case 25:
						goto IL_153;
					case 26:
						if (obj != null)
						{
							num = (short)1646526497;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_88A;
					case 27:
						goto IL_426;
					case 28:
					{
						global::System.Windows.Data.CollectionView collectionView8 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderControlHeadO9RelayPatternBCOListList.MyDataPresenter = this.ExpanderControlHeadO9RelayPatternBCOListList;
						num = (short)1451528423;
						short num3 = num;
						num = (short)105550055;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_36F;
						default:
							num = (short)725024768;
							if (num != 0)
							{
							}
							num = (short)1025703971;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 29:
						if (obj != null)
						{
							num = (short)214171676;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8D1;
					case 30:
						if (obj != null)
						{
							num = (short)135200773;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_426;
					case 31:
					{
						num = (short)1343815681;
						if (num != 0)
						{
						}
						global::System.Windows.Data.CollectionView collectionView9 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderControlHeadO9TopFunctionProgrammableButtonList.MyDataPresenter = this.ExpanderControlHeadO9TopFunctionProgrammableButtonList;
						num = (short)677838870;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 32:
						if (obj != null)
						{
							num = (short)1701904420;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10B;
					case 33:
					{
						global::System.Windows.Data.CollectionView collectionView10 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderControlHeadO9DirectionalButtonsList.MyDataPresenter = this.ExpanderControlHeadO9DirectionalButtonsList;
						num = (short)2112356360;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 34:
						if (obj != null)
						{
							num = (short)896598017;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_213;
					case 35:
						goto IL_8D1;
					case 36:
					{
						global::System.Windows.Data.CollectionView collectionView11 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderControlHeadO9ConsolidatedActionBCOListTable.MyDataPresenter = this.ExpanderControlHeadO9ConsolidatedActionBCOListTable;
						num = (short)2041380864;
						short num4 = num;
						num = (short)984940563;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_C2;
					IL_10B:
					obj = this.RecNavToolbarExpanderControlHeadO9O9NavigationControlsTable.MyRecordsetDataSource;
					num = (short)2000945176;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_153:
					obj = this.RecNavToolbarExpanderControlHeadO9RelayPatternBCOListList.MyRecordsetDataSource;
					num = (short)874643485;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_213:
					obj = this.RecNavToolbarExpanderControlHeadO9O9DataButton.MyRecordsetDataSource;
					num = (short)1442447390;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2FA:
					obj = this.RecNavToolbarExpanderControlHeadO9BottomFunctionProgrammableButtonTable.MyRecordsetDataSource;
					num = (short)276103183;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_343:
					global::AcpUI.AcpExpander acpExpander = null;
					global::System.Collections.IEnumerator enumerator = this.MyStackPanel.Children.GetEnumerator();
					num = (short)1614020621;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_36F:
					try
					{
						num = (short)907935744;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_756;
								}
								continue;
							case 1:
								if (acpExpander != null)
								{
									num = (short)1323368452;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 2:
								num = (short)2115698694;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								if (!enumerator.MoveNext())
								{
									num = (short)1306918914;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
								num = (short)863633409;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								base.Expanders.Add(acpExpander);
								num = (short)1595736069;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								goto IL_811;
							}
							IL_799:
							num = (short)1203437571;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_756:
							goto IL_799;
						}
						IL_811:
						goto IL_374;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_833;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_820:
							switch (num2)
							{
							case 0:
								if (disposable != null)
								{
									num = (short)476315649;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_889;
							case 1:
								disposable.Dispose();
								num = (short)349962242;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_887;
							}
							goto IL_833;
						}
						IL_887:
						IL_889:
						goto EndFinally_18;
						IL_833:
						disposable = (enumerator as global::System.IDisposable);
						num = (short)1506803712;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_820;
						EndFinally_18:;
					}
					goto IL_88A;
					IL_374:
					base.OnLoaded(sender, e);
					this.a = true;
					num = (short)527630336;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_426:
					obj = this.RecNavToolbarExpanderControlHeadO9TopFunctionProgrammableButtonList.MyRecordsetDataSource;
					num = (short)1583808526;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4D1:
					obj = this.RecNavToolbarExpanderControlHeadO9ResponseSelectorList.MyRecordsetDataSource;
					num = (short)1763246091;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_519:
					obj = this.RecNavToolbarExpanderControlHeadO9BottomFunctionButtonBCOList.MyRecordsetDataSource;
					num = (short)497811462;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5D1:
					obj = this.RecNavToolbarExpanderControlHeadO9DirectionalButtonsList.MyRecordsetDataSource;
					num = (short)12517402;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_88A:
					obj = this.RecNavToolbarExpanderControlHeadO9PASirenButtonsList.MyRecordsetDataSource;
					num = (short)1660420100;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8D1:
					obj = this.RecNavToolbarExpanderControlHeadO9ConsolidatedActionBCOListTable.MyRecordsetDataSource;
					num = (short)1576075296;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_39B:
				IL_919:
				this.PostOnLoaded(sender, e);
				this.MyStackPanel.Children[0].Focus();
				return;
				IL_C2:
				this.PreOnLoaded(sender, e);
				num = (short)1830748172;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
		}

		// Token: 0x06008189 RID: 33161 RVA: 0x00783348 File Offset: 0x00781548
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			short num;
			for (;;)
			{
				IL_0A:
				num = (short)145752065;
				if (num != 0)
				{
				}
				int num2;
				switch (num2)
				{
				case 0:
					if (this.a)
					{
						num = (short)1204682753;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					base.OnUnloaded(sender, e);
					this.a = false;
					num = (short)1750728706;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_229;
				}
				break;
			}
			IL_44:
			num = (short)1873281024;
			short num3 = num;
			num = (short)1006266391;
			short num4 = num;
			num = (short)71788567;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_229:
				break;
			default:
			{
				num = (short)645070848;
				if (num != 0)
				{
				}
				this.PreOnUnloaded(sender, e);
				this.RecNavToolbarExpanderControlHeadO9O9.DataContext = null;
				this.RecNavToolbarExpanderControlHeadO9O9DataButton.DataContext = null;
				this.RecNavToolbarExpanderControlHeadO9TopFunctionProgrammableButtonList.DataContext = null;
				this.RecNavToolbarExpanderControlHeadO9BottomFunctionProgrammableButtonTable.DataContext = null;
				this.RecNavToolbarExpanderControlHeadO9ResponseSelectorList.DataContext = null;
				this.RecNavToolbarExpanderControlHeadO9DirectionalButtonsList.DataContext = null;
				this.RecNavToolbarExpanderControlHeadO9PASirenButtonsList.DataContext = null;
				this.RecNavToolbarExpanderControlHeadO9RelayPatternBCOListList.DataContext = null;
				this.RecNavToolbarExpanderControlHeadO9ConsolidatedActionBCOListTable.DataContext = null;
				this.RecNavToolbarExpanderControlHeadO9O9NavigationControlsTable.DataContext = null;
				this.RecNavToolbarExpanderControlHeadO9BottomFunctionButtonBCOList.DataContext = null;
				this.RecNavToolbarExpanderControlHeadO9O9.MyDataPresenter = null;
				this.RecNavToolbarExpanderControlHeadO9O9DataButton.MyDataPresenter = null;
				this.RecNavToolbarExpanderControlHeadO9TopFunctionProgrammableButtonList.MyDataPresenter = null;
				this.RecNavToolbarExpanderControlHeadO9BottomFunctionProgrammableButtonTable.MyDataPresenter = null;
				this.RecNavToolbarExpanderControlHeadO9ResponseSelectorList.MyDataPresenter = null;
				this.RecNavToolbarExpanderControlHeadO9DirectionalButtonsList.MyDataPresenter = null;
				this.RecNavToolbarExpanderControlHeadO9PASirenButtonsList.MyDataPresenter = null;
				this.RecNavToolbarExpanderControlHeadO9RelayPatternBCOListList.MyDataPresenter = null;
				this.RecNavToolbarExpanderControlHeadO9ConsolidatedActionBCOListTable.MyDataPresenter = null;
				this.RecNavToolbarExpanderControlHeadO9O9NavigationControlsTable.MyDataPresenter = null;
				this.RecNavToolbarExpanderControlHeadO9BottomFunctionButtonBCOList.MyDataPresenter = null;
				num = (short)497221632;
				int num2 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0600818A RID: 33162 RVA: 0x00783580 File Offset: 0x00781780
		public override void SetDataContext()
		{
			short num = (short)895615056;
			int num2 = (int)((global::System.IntPtr)num);
			object feature;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO9ConsolidatedActionBCOListTable).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10622].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO9ConsolidatedActionBCOListTable).SyncDataSources();
					num = (short)1317142607;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)1975713801;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2CA;
				case 2:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO9BottomFunctionProgrammableButtonTable).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10618].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO9BottomFunctionProgrammableButtonTable).SyncDataSources();
					num = (short)51773506;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (feature != null)
					{
						num = (short)1175257109;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7E5;
				case 4:
					num = (short)1643184196;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					num = (short)1104674919;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					num = (short)448593936;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					num = (short)1070792705;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					num = (short)1061748824;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					num = (short)268435497;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10624] != null)
					{
						num = (short)1037828198;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1058;
				case 11:
					goto IL_3A0;
				case 12:
					if (feature != null)
					{
						num = (short)115671063;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_126B;
				case 13:
					goto IL_1058;
				case 14:
					num = (short)907411517;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					num = (short)105906275;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)1685848107;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_70F;
				case 17:
					if (feature != null)
					{
						num = (short)688259135;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EE1;
				case 18:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10626] != null)
					{
						num = (short)598540389;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CDC;
				case 19:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10743] != null)
					{
						num = (short)615514117;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_126B;
				case 20:
					goto IL_126B;
				case 21:
					num = (short)878837800;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					goto IL_FB0;
				case 23:
					num = (short)564068409;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					num = (short)1752825890;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					num = (short)2142634084;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 26:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)598016077;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3A0;
				case 27:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10618] != null)
					{
						num = (short)621936665;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_70F;
				case 28:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)476643422;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1058;
				case 29:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(4003);
					num = (short)244645930;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 30:
					return;
				case 31:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO9DirectionalButtonsList).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10609].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO9DirectionalButtonsList).SyncDataSources();
					num = (short)1626996796;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 32:
					if (feature != null)
					{
						num = (short)983891975;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2CA;
				case 33:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10624].EmbeddedRecset != null)
					{
						num = (short)550895666;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1058;
				case 34:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10616] != null)
					{
						num = (short)797835278;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7E5;
				case 35:
					num = (short)2011955256;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 36:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10731].EmbeddedRecset != null)
					{
						num = (short)1585250400;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3A0;
				case 37:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)1277952073;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO9O9).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO9O9DataButton).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO9TopFunctionProgrammableButtonList).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO9BottomFunctionProgrammableButtonTable).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO9ResponseSelectorList).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO9DirectionalButtonsList).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO9PASirenButtonsList).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO9RelayPatternBCOListList).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO9ConsolidatedActionBCOListTable).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO9O9NavigationControlsTable).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO9BottomFunctionButtonBCOList).MySecondaryRecordsetDataSource = null;
					num = (short)336658462;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 38:
					num = (short)1332740097;
					if (num != 0)
					{
					}
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO9TopFunctionProgrammableButtonList).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10616].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO9TopFunctionProgrammableButtonList).SyncDataSources();
					num = (short)1665073245;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 39:
					num = (short)1590099987;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 40:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)1185349656;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7E5;
				case 41:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10622] != null)
					{
						num = (short)47251460;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2CA;
				case 42:
				{
					num = (short)1587412992;
					short num3 = num;
					goto IL_BFE;
				}
				case 43:
					num = (short)777322523;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 44:
					if (feature != null)
					{
						num = (short)2030174256;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3A0;
				case 45:
					num = (short)707199046;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 46:
					num = (short)16384036;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 47:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)1931280479;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CDC;
				case 48:
					num = (short)1913454618;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 49:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10620] != null)
					{
						num = (short)202506275;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EE1;
				case 50:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO9ResponseSelectorList).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10624].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO9ResponseSelectorList).SyncDataSources();
					num = (short)1930493965;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 51:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10611] != null)
					{
						num = (short)188481544;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_821;
				case 52:
					if (feature != null)
					{
						num = (short)2070347821;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_244;
				case 53:
					num = (short)613613644;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 54:
					if (feature != null)
					{
						num = (short)161808488;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CDC;
				case 55:
					num = (short)1845428298;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 56:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10620].EmbeddedRecset != null)
					{
						num = (short)1251672126;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EE1;
				case 57:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)322961447;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_126B;
				case 58:
					num = (short)1966866481;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 59:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10626].EmbeddedRecset != null)
					{
						num = (short)1171456081;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CDC;
				case 60:
					goto IL_244;
				case 61:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10616].EmbeddedRecset != null)
					{
						num = (short)2145910822;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7E5;
				case 62:
				{
					num = (short)341225077;
					short num4 = num;
					num = (short)89566837;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_DAC;
					default:
						num = (short)1987969024;
						if (num != 0)
						{
						}
						((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO9RelayPatternBCOListList).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10620].EmbeddedRecset;
						((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO9RelayPatternBCOListList).SyncDataSources();
						num = (short)1196621915;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 63:
					num = (short)849870919;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 64:
					num = (short)513867804;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 65:
					if (feature != null)
					{
						num = (short)1586233408;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1058;
				case 66:
					goto IL_70F;
				case 67:
					if (feature != null)
					{
						num = (short)2012676193;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 68:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10622].EmbeddedRecset != null)
					{
						num = (short)1046282240;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2CA;
				case 69:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10628].EmbeddedRecset != null)
					{
						num = (short)103743510;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 70:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)2097152055;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_244;
				case 71:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)1464401978;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EE1;
				case 72:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO9PASirenButtonsList).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10743].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO9PASirenButtonsList).SyncDataSources();
					num = (short)437059604;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 73:
					feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(4003);
					num = (short)1560936502;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 74:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10609] != null)
					{
						num = (short)630915125;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_244;
				case 75:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10731] != null)
					{
						num = (short)1123942446;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3A0;
				case 76:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10609].EmbeddedRecset != null)
					{
						num = (short)1839071263;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_244;
				case 77:
					num = (short)1805451339;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 78:
					if (feature != null)
					{
						num = (short)2035810310;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_70F;
				case 79:
					goto IL_2CA;
				case 80:
					switch (0)
					{
					case 0:
						goto IL_1C8;
					}
					continue;
				case 81:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO9O9).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10626].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO9O9).SyncDataSources();
					num = (short)303824988;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 82:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)30867471;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 83:
					num = (short)907673669;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 84:
					if (feature != null)
					{
						num = (short)275906649;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_821;
				case 85:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO9O9DataButton).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10611].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO9O9DataButton).SyncDataSources();
					num = (short)969736278;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 86:
					goto IL_821;
				case 87:
					goto IL_BFE;
				case 88:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10611].EmbeddedRecset != null)
					{
						num = (short)1480261717;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_821;
				case 89:
					num = (short)944898138;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 90:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)1730609250;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_821;
				case 91:
					goto IL_EE1;
				case 92:
					goto IL_CDC;
				case 93:
					goto IL_7E5;
				case 94:
					num = (short)699858954;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 95:
					goto IL_DAC;
				case 96:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO9O9NavigationControlsTable).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10731].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO9O9NavigationControlsTable).SyncDataSources();
					num = (short)141426699;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 97:
					num = (short)246808658;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 98:
					num = (short)717488179;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 99:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10628] != null)
					{
						num = (short)1087111251;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 100:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10618].EmbeddedRecset != null)
					{
						num = (short)1475936258;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_70F;
				case 101:
					num = (short)1599143995;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 102:
					num = (short)699203617;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 103:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10743].EmbeddedRecset != null)
					{
						num = (short)498335816;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_126B;
				case 104:
					num = (short)2075131951;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_1C8:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)786104349;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(4003);
				num = (short)590020695;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_244:
				num = (short)1000931340;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2CA:
				num = (short)2142109740;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3A0:
				num = (short)489291843;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_70F:
				num = (short)1924005953;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_7E5:
				num = (short)957218894;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_821:
				num = (short)380436483;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_BFE:
				num = (short)1910439973;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_CDC:
				num = (short)1682636884;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_DAC:
				num = (short)924057618;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_EE1:
				num = (short)529203232;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1058:
				num = (short)480903220;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_126B:
				num = (short)662962193;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_FB0:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO9BottomFunctionButtonBCOList).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10628].EmbeddedRecset;
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO9BottomFunctionButtonBCOList).SyncDataSources();
		}

		// Token: 0x0600818B RID: 33163 RVA: 0x0078491C File Offset: 0x00782B1C
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 10;
			short num = (short)1448214528;
			switch (num)
			{
			default:
			{
				num = (short)1266679858;
				int num2 = (int)((global::System.IntPtr)num);
				object myRecordsetDataSource11;
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						object myRecordsetDataSource;
						if (myRecordsetDataSource != null)
						{
							num = (short)899940354;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AC1;
					}
					case 1:
						goto IL_474;
					case 2:
					{
						object myRecordsetDataSource;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInner item = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInner)collectionView.CurrentItem;
						collectionView.MoveCurrentTo(item);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)1656684584;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("駊꣌곎鿐닒ꏔ菖뛘듚뇜뷞胠釢ꃤ鿦駨諪菬诮铰臲뛴飶韸迺迼郾洀䬂怄昆洈䐊㐌䴎縐朒愔砖琘崚栜焞䈠圢䰤䠦䜨笪弬䀮嘰䄲吴娶吸娺弼匾⑀łい㍆㵈⑊⍌᭎ぐㅒ㥔㉖", a_))
						{
							num = (short)723058755;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AC1;
					case 4:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1911357445;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)121700379;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource2 = this.RecNavToolbarExpanderControlHeadO9O9NavigationControlsTable.MyRecordsetDataSource;
						num = (short)312279071;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("駊꣌곎鿐닒ꏔ菖뛘듚뇜뷞胠釢ꃤ鿦駨諪菬诮铰臲뛴飶韸迺迼郾洀䬂怄昆洈䐊㐌嬎縐挒匔或眘砚検瘞丠䴢甤唦䘨䰪弬丮尰帲吴唶唸帺缼䨾㕀㝂⩄⥆Ո≊㹌㭎", a_))
						{
							num = (short)350879769;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_95B;
					case 7:
						num = (short)1681522714;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_323;
					case 9:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource3 = this.RecNavToolbarExpanderControlHeadO9O9DataButton.MyRecordsetDataSource;
						num = (short)1525481511;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						object myRecordsetDataSource4;
						global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource4);
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner item2 = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner)collectionView2.CurrentItem;
						collectionView2.MoveCurrentTo(item2);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)978452535;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						goto IL_632;
					case 12:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)2046492720;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)1924464717;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1089732669;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)18481240;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("駊꣌곎鿐닒ꏔ菖뛘듚뇜뷞胠釢ꃤ鿦駨諪菬诮铰臲뛴飶韸迺迼郾洀䬂怄昆洈䐊㐌䬎砐愒瀔琖洘爚爜焞䀠伢朤刦崨弪䈬䄮䈰缲尴䐶䴸", a_))
						{
							num = (short)252444705;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_474;
					case 15:
						goto IL_DFE;
					case 16:
						goto IL_DFE;
					case 17:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("駊꣌곎鿐닒ꏔ菖뛘듚뇜뷞胠釢ꃤ鿦駨諪菬诮铰臲뛴飶韸迺迼郾洀䬂怄昆洈䐊㐌䴎縐朒愔砖琘崚栜焞䈠圢䰤䠦䜨椪堬嬮䔰尲嬴甶稸琺焼嘾㉀㝂", a_))
						{
							num = (short)1004929069;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 18:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("駊꣌곎鿐닒ꏔ菖뛘듚뇜뷞胠釢ꃤ鿦駨諪菬诮铰臲뛴飶韸迺迼郾洀䬂怄昆洈䐊㐌崎琐怒攔砖眘栚砜䰞䐠伢䀤䐦崨䐪弬挮堰䀲䄴", a_))
						{
							num = (short)792264787;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DFE;
					case 19:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource5 = this.RecNavToolbarExpanderControlHeadO9RelayPatternBCOListList.MyRecordsetDataSource;
						num = (short)1392508965;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
					{
						object myRecordsetDataSource4;
						if (myRecordsetDataSource4 != null)
						{
							num = (short)525795338;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_95B;
					}
					case 21:
					{
						object myRecordsetDataSource6;
						global::System.Windows.Data.CollectionView collectionView3 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource6);
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner item3 = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner)collectionView3.CurrentItem;
						collectionView3.MoveCurrentTo(item3);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)1629880395;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1369047096;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)1861681222;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						goto IL_632;
					case 24:
					{
						object myRecordsetDataSource7;
						if (myRecordsetDataSource7 != null)
						{
							num = (short)1625161813;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BDE;
					}
					case 25:
						num = (short)596705343;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("駊꣌곎鿐닒ꏔ菖뛘듚뇜뷞胠釢ꃤ鿦駨諪菬诮铰臲뛴飶韸迺迼郾洀䬂怄昆洈䐊㐌䀎⠐", a_))
						{
							num = (short)553582679;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BDE;
					case 27:
						goto IL_41B;
					case 28:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("駊꣌곎鿐닒ꏔ菖뛘듚뇜뷞胠釢ꃤ鿦駨諪菬诮铰臲뛴飶韸迺迼郾洀䬂怄昆洈䐊㐌䀎⠐園琔挖砘多栜欞唠䰢䬤", a_))
						{
							num = (short)1021444130;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_632;
					case 29:
						num = (short)1584660484;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						num = (short)1838940172;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
					{
						object myRecordsetDataSource2;
						if (myRecordsetDataSource2 != null)
						{
							num = (short)102170697;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_41B;
					}
					case 32:
						goto IL_F28;
					case 33:
						num = (short)1742798908;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						num = (short)926548032;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
					{
						object myRecordsetDataSource8;
						if (myRecordsetDataSource8 != null)
						{
							num = (short)942669902;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10AB;
					}
					case 36:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("駊꣌곎鿐닒ꏔ菖뛘듚뇜뷞胠釢ꃤ鿦駨諪菬诮铰臲뛴飶韸迺迼郾洀䬂怄昆洈䐊㐌䰎縐紒昔砖甘爚礜縞唠䘢䄤昦䨨弪䐬䀮弰焲瘴砶甸刺丼䬾ᕀ≂❄⭆ⱈ", a_))
						{
							num = (short)695730262;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_323;
					case 37:
					{
						object myRecordsetDataSource5;
						if (myRecordsetDataSource5 != null)
						{
							num = (short)1435500624;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F28;
					}
					case 38:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource6 = this.RecNavToolbarExpanderControlHeadO9ConsolidatedActionBCOListTable.MyRecordsetDataSource;
						num = (short)2032468039;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 39:
					{
						num = (short)2075787265;
						if (num != 0)
						{
						}
						object myRecordsetDataSource3;
						if (myRecordsetDataSource3 != null)
						{
							goto IL_D6D;
						}
						goto IL_632;
					}
					case 40:
						goto IL_AC1;
					case 41:
					{
						object myRecordsetDataSource9;
						if (myRecordsetDataSource9 != null)
						{
							num = (short)1877672020;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DFE;
					}
					case 42:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)136773679;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)1794834447;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						return;
					case 44:
					{
						object myRecordsetDataSource10;
						global::System.Windows.Data.CollectionView collectionView4 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource10);
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInner item4 = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInner)collectionView4.CurrentItem;
						collectionView4.MoveCurrentTo(item4);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)925564929;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 45:
						num = (short)1898840110;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)870842440;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)983105579;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource9 = this.RecNavToolbarExpanderControlHeadO9ResponseSelectorList.MyRecordsetDataSource;
						num = (short)773718057;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 48:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource8 = this.RecNavToolbarExpanderControlHeadO9PASirenButtonsList.MyRecordsetDataSource;
						num = (short)1947664419;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 49:
						num = (short)1006305334;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
					{
						num = (short)1052352901;
						short num3 = num;
						num = (short)815047045;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_D6D;
						case 1:
							break;
						default:
						{
							num = (short)515571712;
							short num4 = num;
							break;
						}
						}
						num = (short)571473920;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_224;
						}
						continue;
					}
					case 51:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource10 = this.RecNavToolbarExpanderControlHeadO9DirectionalButtonsList.MyRecordsetDataSource;
						num = (short)989265989;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 52:
						goto IL_95B;
					case 53:
						goto IL_41B;
					case 54:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1265303571;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)1102774304;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 55:
						goto IL_95B;
					case 56:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource7 = this.RecNavToolbarExpanderControlHeadO9O9.MyRecordsetDataSource;
						num = (short)113246232;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 57:
						goto IL_BDE;
					case 58:
					{
						object myRecordsetDataSource3;
						global::System.Windows.Data.CollectionView collectionView5 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource3);
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInner item5 = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInner)collectionView5.CurrentItem;
						collectionView5.MoveCurrentTo(item5);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)1333526539;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 59:
						goto IL_10AB;
					case 60:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)912916531;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)356974671;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 61:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource = this.RecNavToolbarExpanderControlHeadO9BottomFunctionProgrammableButtonTable.MyRecordsetDataSource;
						num = (short)1014759424;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 62:
						goto IL_CDE;
					case 63:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1365049410;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)823132212;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 64:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)306315273;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)451674135;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 65:
						if (myRecordsetDataSource11 != null)
						{
							num = (short)443154494;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 66:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource4 = this.RecNavToolbarExpanderControlHeadO9TopFunctionProgrammableButtonList.MyRecordsetDataSource;
						num = (short)559480852;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 67:
						num = (short)1072168973;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 68:
						goto IL_F28;
					case 69:
					{
						object myRecordsetDataSource10;
						if (myRecordsetDataSource10 != null)
						{
							num = (short)1699872812;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_474;
					}
					case 70:
						goto IL_BDE;
					case 71:
					{
						object myRecordsetDataSource6;
						if (myRecordsetDataSource6 != null)
						{
							num = (short)264765461;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_323;
					}
					case 72:
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						myRecordsetDataSource11 = this.RecNavToolbarExpanderControlHeadO9BottomFunctionButtonBCOList.MyRecordsetDataSource;
						num = (short)1275723841;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 73:
					{
						object myRecordsetDataSource2;
						global::System.Windows.Data.CollectionView collectionView6 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource2);
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInner item6 = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInner)collectionView6.CurrentItem;
						collectionView6.MoveCurrentTo(item6);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)620953653;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 74:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1571094566;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)727777288;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 75:
						goto IL_323;
					case 76:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("駊꣌곎鿐닒ꏔ菖뛘듚뇜뷞胠釢ꃤ鿦駨諪菬诮铰臲뛴飶韸迺迼郾洀䬂怄昆洈䐊㐌䀎⠐崒琔愖瀘簚簜欞䠠䰢䬤搦䘨䔪夬崮帰弲䘴挶堸夺儼娾", a_))
						{
							num = (short)1294532637;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_41B;
					case 77:
						goto IL_10AB;
					case 78:
					{
						object myRecordsetDataSource8;
						global::System.Windows.Data.CollectionView collectionView7 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource8);
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInner item7 = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInner)collectionView7.CurrentItem;
						collectionView7.MoveCurrentTo(item7);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)1568735291;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 79:
						goto IL_474;
					case 80:
					{
						object myRecordsetDataSource5;
						global::System.Windows.Data.CollectionView collectionView8 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource5);
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner item8 = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner)collectionView8.CurrentItem;
						collectionView8.MoveCurrentTo(item8);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)1760100420;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 81:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("駊꣌곎鿐닒ꏔ菖뛘듚뇜뷞胠釢ꃤ鿦駨諪菬诮铰臲뛴飶韸迺迼郾洀䬂怄昆洈䐊㐌弎倐䀒簔攖簘甚弜樞唠圢䨤䤦娨未䐬尮䔰", a_))
						{
							num = (short)1043267614;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10AB;
					case 82:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("駊꣌곎鿐닒ꏔ菖뛘듚뇜뷞胠釢ꃤ鿦駨諪菬诮铰臲뛴飶韸迺迼郾洀䬂怄昆洈䐊㐌崎琐缒琔渖䤘稚検欞䐠儢䬤攦樨搪愬䘮䈰䜲礴帶䨸伺", a_))
						{
							num = (short)506331185;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F28;
					case 83:
						num = (short)1070858282;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 84:
					{
						object myRecordsetDataSource9;
						global::System.Windows.Data.CollectionView collectionView9 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource9);
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ResponseSelectorListInner item9 = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ResponseSelectorListInner)collectionView9.CurrentItem;
						collectionView9.MoveCurrentTo(item9);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)613351440;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 85:
					{
						object myRecordsetDataSource7;
						global::System.Windows.Data.CollectionView collectionView10 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource7);
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9Inner item10 = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9Inner)collectionView10.CurrentItem;
						collectionView10.MoveCurrentTo(item10);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)555089977;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 86:
						num = (short)876413002;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 87:
						num = (short)369426454;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 88:
						goto IL_AC1;
					}
					IL_224:
					if (A_0 is global::AcpUI.AcpRecNavToolbar)
					{
						num = (short)2127757319;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_323:
					num = (short)2146893900;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_41B:
					num = (short)1725693969;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_474:
					num = (short)1525481553;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_632:
					num = (short)1362821126;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_95B:
					num = (short)795541507;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AC1:
					num = (short)164757522;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BDE:
					num = (short)1263075356;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D6D:
					num = (short)751894586;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_DFE:
					num = (short)153223182;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F28:
					num = (short)1383858212;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_10AB:
					num = (short)1620770898;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_CDE:
				global::System.Windows.Data.CollectionView collectionView11 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource11);
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInner item11 = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInner)collectionView11.CurrentItem;
				collectionView11.MoveCurrentTo(item11);
				((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
				return;
			}
			}
		}

		// Token: 0x0600818C RID: 33164 RVA: 0x00785AF4 File Offset: 0x00783CF4
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1703804928;
			short num2 = num;
			num = (short)1133514274;
			short num3 = num;
			num = (short)1334775330;
			switch (num3 == num)
			{
			}
			num = (short)1812922369;
			if (num != 0)
			{
			}
			num = (short)1278869504;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x0600818D RID: 33165 RVA: 0x00785BA8 File Offset: 0x00783DA8
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1624899584;
			short num2 = num;
			num = (short)1300919762;
			short num3 = num;
			num = (short)1756394962;
			switch (num3 == num)
			{
			}
			num = (short)1933836288;
			if (num != 0)
			{
			}
			num = (short)1138098177;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x0600818E RID: 33166 RVA: 0x00785C58 File Offset: 0x00783E58
		internal void OnExpanderControlHeadO9O9Click(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			object myRecordsetDataSource;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9Inner item;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (myRecordsetDataSource != null)
					{
						num2 = (short)170262530;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E2;
				case 1:
					goto IL_E2;
				case 2:
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderControlHeadO9O9.SyncDataSources();
					goto IL_C9;
				}
				goto IL_1C;
				IL_C9:
				num2 = (short)558694401;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_E2:
				num2 = (short)776994630;
				short num3 = num2;
				num2 = (short)1458831174;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_C9;
				default:
					goto IL_117;
				}
			}
			IL_117:
			num2 = (short)1469579265;
			if (num2 != 0)
			{
			}
			num2 = (short)579403776;
			if (num2 != 0)
			{
			}
			this.RecNavToolbarExpanderControlHeadO9O9.TableMode = false;
			return;
			IL_1C:
			item = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9Inner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderControlHeadO9O9.MyRecordsetDataSource;
			num2 = (short)771686400;
			short num4 = num2;
			num2 = (short)615251968;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600818F RID: 33167 RVA: 0x00785DC8 File Offset: 0x00783FC8
		internal void OnExpanderControlHeadO9O9DataButtonClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			object myRecordsetDataSource;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInner item;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (myRecordsetDataSource != null)
					{
						num2 = (short)1965228034;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E4;
				case 1:
					goto IL_E4;
				case 2:
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderControlHeadO9O9DataButton.SyncDataSources();
					goto IL_C9;
				}
				goto IL_1C;
				IL_C9:
				num2 = (short)1434255361;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_E4:
				num2 = (short)2139113163;
				short num3 = num2;
				num2 = (short)1773094603;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_C9;
				default:
					goto IL_119;
				}
			}
			IL_119:
			num2 = (short)931921921;
			if (num2 != 0)
			{
			}
			num2 = (short)1767571456;
			if (num2 != 0)
			{
			}
			this.RecNavToolbarExpanderControlHeadO9O9DataButton.TableMode = false;
			return;
			IL_1C:
			item = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderControlHeadO9O9DataButton.MyRecordsetDataSource;
			num2 = (short)1106182144;
			short num4 = num2;
			num2 = (short)1207238656;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06008190 RID: 33168 RVA: 0x00785F38 File Offset: 0x00784138
		internal void OnExpanderControlHeadO9TopFunctionProgrammableButtonListClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			object myRecordsetDataSource;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner item;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (myRecordsetDataSource != null)
					{
						num2 = (short)583139330;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_10D;
				case 1:
					goto IL_10D;
				case 2:
					num2 = (short)655361;
					if (num2 != 0)
					{
					}
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderControlHeadO9TopFunctionProgrammableButtonList.SyncDataSources();
					goto IL_F2;
				}
				goto IL_1C;
				IL_F2:
				num2 = (short)1445003265;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_10D:
				num2 = (short)438893824;
				short num3 = num2;
				num2 = (short)1749744896;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_F2;
				default:
					goto IL_142;
				}
			}
			IL_142:
			num2 = (short)807403520;
			if (num2 != 0)
			{
			}
			this.RecNavToolbarExpanderControlHeadO9TopFunctionProgrammableButtonList.TableMode = false;
			return;
			IL_1C:
			item = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderControlHeadO9TopFunctionProgrammableButtonList.MyRecordsetDataSource;
			num2 = (short)565575680;
			short num4 = num2;
			num2 = (short)678756352;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06008191 RID: 33169 RVA: 0x007860A8 File Offset: 0x007842A8
		internal void OnExpanderControlHeadO9BottomFunctionProgrammableButtonTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_42;
			}
			short num;
			int num2;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInner item;
			for (;;)
			{
				IL_0A:
				num = (short)152371201;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					if (myRecordsetDataSource != null)
					{
						num = (short)1037893634;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_106;
				case 1:
					goto IL_106;
				case 2:
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderControlHeadO9BottomFunctionProgrammableButtonTable.SyncDataSources();
					goto IL_ED;
				}
				goto IL_42;
				IL_ED:
				num = (short)620429313;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_106:
				num = (short)1532786800;
				short num3 = num;
				num = (short)1134262384;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_ED;
				default:
					goto IL_13B;
				}
			}
			IL_13B:
			num = (short)1667563520;
			if (num != 0)
			{
			}
			this.RecNavToolbarExpanderControlHeadO9BottomFunctionProgrammableButtonTable.TableMode = false;
			return;
			IL_42:
			num = (short)98435072;
			short num4 = num;
			item = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderControlHeadO9BottomFunctionProgrammableButtonTable.MyRecordsetDataSource;
			num = (short)1105133568;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06008192 RID: 33170 RVA: 0x00786214 File Offset: 0x00784414
		internal void OnExpanderControlHeadO9ResponseSelectorListClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			object myRecordsetDataSource;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ResponseSelectorListInner item;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (myRecordsetDataSource != null)
					{
						num2 = (short)15794178;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_10C;
				case 1:
					goto IL_10C;
				case 2:
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderControlHeadO9ResponseSelectorList.SyncDataSources();
					goto IL_F1;
				}
				goto IL_1C;
				IL_F1:
				num2 = (short)1833762817;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_10C:
				num2 = (short)729563647;
				short num3 = num2;
				num2 = (short)1766736383;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_F1;
				default:
					goto IL_140;
				}
			}
			IL_140:
			num2 = (short)540540928;
			if (num2 != 0)
			{
			}
			this.RecNavToolbarExpanderControlHeadO9ResponseSelectorList.TableMode = false;
			return;
			IL_1C:
			num2 = (short)1240793089;
			if (num2 != 0)
			{
			}
			num2 = (short)2097872896;
			short num4 = num2;
			item = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ResponseSelectorListInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderControlHeadO9ResponseSelectorList.MyRecordsetDataSource;
			num2 = (short)530644992;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06008193 RID: 33171 RVA: 0x00786384 File Offset: 0x00784584
		internal void OnExpanderControlHeadO9DirectionalButtonsListClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			object myRecordsetDataSource;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInner item;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (myRecordsetDataSource != null)
					{
						num2 = (short)2132672514;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_106;
				case 1:
					goto IL_106;
				case 2:
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderControlHeadO9DirectionalButtonsList.SyncDataSources();
					goto IL_ED;
				}
				goto IL_1C;
				IL_ED:
				num2 = (short)60882945;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_106:
				num2 = (short)1324037342;
				short num3 = num2;
				num2 = (short)999109854;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_ED;
				default:
					goto IL_13C;
				}
			}
			IL_13C:
			num2 = (short)1788215296;
			if (num2 != 0)
			{
			}
			this.RecNavToolbarExpanderControlHeadO9DirectionalButtonsList.TableMode = false;
			return;
			IL_1C:
			num2 = (short)1752039425;
			if (num2 != 0)
			{
			}
			num2 = (short)1074724864;
			short num4 = num2;
			item = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderControlHeadO9DirectionalButtonsList.MyRecordsetDataSource;
			num2 = (short)1269956608;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06008194 RID: 33172 RVA: 0x007864F0 File Offset: 0x007846F0
		internal void OnExpanderControlHeadO9PASirenButtonsListClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInner item;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)171442177;
					if (num2 != 0)
					{
					}
					if (myRecordsetDataSource != null)
					{
						num2 = (short)1090519042;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_104;
				case 1:
					goto IL_104;
				case 2:
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderControlHeadO9PASirenButtonsList.SyncDataSources();
					goto IL_E9;
				}
				goto IL_1C;
				IL_E9:
				num2 = (short)1713700865;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_104:
				num2 = (short)879721815;
				short num3 = num2;
				num2 = (short)601849175;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_E9;
				default:
					goto IL_13A;
				}
			}
			IL_13A:
			num2 = (short)1319043072;
			if (num2 != 0)
			{
			}
			this.RecNavToolbarExpanderControlHeadO9PASirenButtonsList.TableMode = false;
			return;
			IL_1C:
			item = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderControlHeadO9PASirenButtonsList.MyRecordsetDataSource;
			num2 = (short)387121152;
			short num4 = num2;
			num2 = (short)1481048064;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06008195 RID: 33173 RVA: 0x00786658 File Offset: 0x00784858
		internal void OnExpanderControlHeadO9RelayPatternBCOListListClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			object myRecordsetDataSource;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner item;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (myRecordsetDataSource != null)
					{
						num2 = (short)15400962;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_DD;
				case 1:
					goto IL_DD;
				case 2:
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderControlHeadO9RelayPatternBCOListList.SyncDataSources();
					goto IL_C4;
				}
				goto IL_1C;
				IL_C4:
				num2 = (short)133038081;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_DD:
				num2 = (short)1455947777;
				if (num2 != 0)
				{
				}
				num2 = (short)1380255444;
				short num3 = num2;
				num2 = (short)136971988;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_C4;
				default:
					goto IL_13A;
				}
			}
			IL_13A:
			num2 = (short)1322582016;
			if (num2 != 0)
			{
			}
			this.RecNavToolbarExpanderControlHeadO9RelayPatternBCOListList.TableMode = false;
			return;
			IL_1C:
			item = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderControlHeadO9RelayPatternBCOListList.MyRecordsetDataSource;
			num2 = (short)471859200;
			short num4 = num2;
			num2 = (short)1873739776;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06008196 RID: 33174 RVA: 0x007867C0 File Offset: 0x007849C0
		internal void OnExpanderControlHeadO9ConsolidatedActionBCOListTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			object myRecordsetDataSource;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner item;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (myRecordsetDataSource != null)
					{
						num2 = (short)532021250;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E2;
				case 1:
					goto IL_E2;
				case 2:
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderControlHeadO9ConsolidatedActionBCOListTable.SyncDataSources();
					goto IL_C7;
				}
				goto IL_1C;
				IL_C7:
				num2 = (short)856752129;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_E2:
				num2 = (short)624295937;
				if (num2 != 0)
				{
				}
				num2 = (short)1678063301;
				short num3 = num2;
				num2 = (short)729757381;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_C7;
				default:
					goto IL_13E;
				}
			}
			IL_13E:
			num2 = (short)1634271232;
			if (num2 != 0)
			{
			}
			this.RecNavToolbarExpanderControlHeadO9ConsolidatedActionBCOListTable.TableMode = false;
			return;
			IL_1C:
			item = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderControlHeadO9ConsolidatedActionBCOListTable.MyRecordsetDataSource;
			num2 = (short)522846208;
			short num4 = num2;
			num2 = (short)701235200;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06008197 RID: 33175 RVA: 0x0078692C File Offset: 0x00784B2C
		internal void OnExpanderControlHeadO9O9NavigationControlsTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			object myRecordsetDataSource;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInner item;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (myRecordsetDataSource != null)
					{
						num2 = (short)2138505218;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_109;
				case 1:
					goto IL_109;
				case 2:
					num2 = (short)57409537;
					if (num2 != 0)
					{
					}
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderControlHeadO9O9NavigationControlsTable.SyncDataSources();
					goto IL_EF;
				}
				goto IL_1C;
				IL_EF:
				num2 = (short)408092673;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_109:
				num2 = (short)1686033359;
				short num3 = num2;
				num2 = (short)1014485967;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_EF;
				default:
					goto IL_13F;
				}
			}
			IL_13F:
			num2 = (short)737935360;
			if (num2 != 0)
			{
			}
			this.RecNavToolbarExpanderControlHeadO9O9NavigationControlsTable.TableMode = false;
			return;
			IL_1C:
			item = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderControlHeadO9O9NavigationControlsTable.MyRecordsetDataSource;
			num2 = (short)140181504;
			short num4 = num2;
			num2 = (short)826933248;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06008198 RID: 33176 RVA: 0x00786A9C File Offset: 0x00784C9C
		internal void OnExpanderControlHeadO9BottomFunctionButtonBCOListClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			object myRecordsetDataSource;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInner item;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (myRecordsetDataSource != null)
					{
						num2 = (short)1645740034;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_108;
				case 1:
					goto IL_108;
				case 2:
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderControlHeadO9BottomFunctionButtonBCOList.SyncDataSources();
					goto IL_ED;
				}
				goto IL_1C;
				IL_ED:
				num2 = (short)1228275713;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_108:
				num2 = (short)395885165;
				short num3 = num2;
				num2 = (short)1580448365;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_ED;
				default:
					goto IL_13E;
				}
			}
			IL_13E:
			num2 = (short)1305477120;
			if (num2 != 0)
			{
			}
			this.RecNavToolbarExpanderControlHeadO9BottomFunctionButtonBCOList.TableMode = false;
			return;
			IL_1C:
			num2 = (short)38338561;
			if (num2 != 0)
			{
			}
			num2 = (short)579862528;
			short num4 = num2;
			item = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderControlHeadO9BottomFunctionButtonBCOList.MyRecordsetDataSource;
			num2 = (short)1317666816;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06008199 RID: 33177 RVA: 0x00786C08 File Offset: 0x00784E08
		private void PreOnLoaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)804454400;
			short num2 = num;
			num = (short)1008837395;
			short num3 = num;
			num = (short)862757651;
			switch (num3 == num)
			{
			}
			num = (short)903610369;
			if (num != 0)
			{
			}
			num = (short)1512833024;
			if (num != 0)
			{
			}
			this.c();
		}

		// Token: 0x0600819A RID: 33178 RVA: 0x00786CBC File Offset: 0x00784EBC
		private void PostOnLoaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)837287936;
			short num2 = num;
			num = (short)768103264;
			short num3 = num;
			num = (short)478434144;
			switch (num3 == num)
			{
			}
			num = (short)714866689;
			if (num != 0)
			{
			}
			num = (short)1989083136;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x0600819B RID: 33179 RVA: 0x00786D6C File Offset: 0x00784F6C
		private void PreOnUnloaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1161625600;
			short num2 = num;
			num = (short)2020982407;
			short num3 = num;
			num = (short)1109704327;
			switch (num3 == num)
			{
			}
			num = (short)862191617;
			if (num != 0)
			{
			}
			num = (short)141295616;
			if (num != 0)
			{
			}
			this.b();
		}

		// Token: 0x0600819C RID: 33180 RVA: 0x00786E20 File Offset: 0x00785020
		private void c()
		{
			short num = (short)517996544;
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
					return;
				case 2:
				{
					num = (short)1243348992;
					short num3 = num;
					global::AcpCommonLib.AppInfoManager.AppInfoHelper.PropertyChanged += this.OnAppInfoPropertyChanged;
					num = (short)193527809;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_30:
				if (this.a)
				{
					break;
				}
				num = (short)36791753;
				short num4 = num;
				num = (short)2016306633;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
					num = (short)947388417;
					if (num != 0)
					{
					}
					num = (short)65929216;
					if (num != 0)
					{
					}
					num = (short)853409794;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
		}

		// Token: 0x0600819D RID: 33181 RVA: 0x00786F50 File Offset: 0x00785150
		private void OnAppInfoPropertyChanged(object A_0, global::System.ComponentModel.PropertyChangedEventArgs A_1)
		{
			int a_ = 18;
			short num = (short)1865023488;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)462356480;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_6C;
					}
					continue;
				}
				case 1:
				{
					num = (short)1252600950;
					short num4 = num;
					num = (short)106966134;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)2043084800;
						if (num != 0)
						{
						}
						if (A_1.PropertyName == global::AllFeatures.CodeplugGuid.b("髒룔Ꟗ뛘꧚꧜郞釠蛢韤蛦鷨苪苬臮닰鳲飴蟶闸黺觼髾攀", a_))
						{
							num = (short)2062221315;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					break;
				}
				case 2:
					num = (short)1194786817;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_9E;
				case 4:
					return;
				}
				IL_6C:
				if (!(A_1.PropertyName == global::AllFeatures.CodeplugGuid.b("韒믔돖雘ꯚ룜귞胠韢賤裦蟨꣪苬苮臰鿲郴菶鳸鿺", a_)))
				{
					num = (short)1654915074;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_9E:
				this.myO9GraphicView.SetMenuItems();
				num = (short)1944649729;
				if (num != 0)
				{
				}
				num = (short)1898250244;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600819E RID: 33182 RVA: 0x007870E4 File Offset: 0x007852E4
		private void b()
		{
			short num = (short)1139081216;
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
					return;
				case 2:
				{
					num = (short)830930944;
					short num3 = num;
					global::AcpCommonLib.AppInfoManager.AppInfoHelper.PropertyChanged -= this.OnAppInfoPropertyChanged;
					num = (short)1553793025;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_30:
				num = (short)1658519553;
				if (num != 0)
				{
				}
				if (this.a)
				{
					break;
				}
				num = (short)1877329762;
				short num4 = num;
				num = (short)1068222306;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
					num = (short)974061568;
					if (num != 0)
					{
					}
					num = (short)1923940354;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
		}

		// Token: 0x0600819F RID: 33183 RVA: 0x00787210 File Offset: 0x00785410
		private void a()
		{
			short num = (short)146014208;
			switch (num)
			{
			default:
			{
				num = (short)459866130;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					int num3;
					switch (num2)
					{
					case 0:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection topFunctionProgrammableButtonListInnerSection;
						if (topFunctionProgrammableButtonListInnerSection.TopFunctionBtnCnvChannel_A36943.ReferencedNode == null)
						{
							num = (short)380698626;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_334;
					}
					case 1:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection topFunctionProgrammableButtonListInnerSection;
						topFunctionProgrammableButtonListInnerSection.TopFunctionBtnCnvChannel_A36943.ResetToDefaultWithUndo();
						num = (short)1761280024;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)1607008272;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset topFunctionProgrammableButtonListInnerRecset;
						if (num3 >= topFunctionProgrammableButtonListInnerRecset.Count)
						{
							num = (short)120389658;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner = topFunctionProgrammableButtonListInnerRecset[num3] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner;
						num = (short)1594621975;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						num3 = 0;
						num = (short)748748811;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (!global::AcpCommonLib.AppInfoManager.DndOrImportOperation)
						{
							goto IL_24B;
						}
						goto IL_334;
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9 controlHeadO;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset topFunctionProgrammableButtonListInnerRecset = controlHeadO.TopFunctionProgrammableButton.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset;
						num = (short)1725562900;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9 controlHeadO = global::AcpCommonLib.FeatureManager.GetFeature(4003)[0] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9;
						num = (short)1463418893;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						num = (short)1388915820;
						short num4 = num;
						num = (short)369175660;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_24B;
						default:
						{
							num = (short)1286537216;
							if (num != 0)
							{
							}
							num = (short)373686273;
							if (num != 0)
							{
							}
							global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner;
							global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection topFunctionProgrammableButtonListInnerSection = topFunctionProgrammableButtonListInner.TopFunctionProgrammableButtonListInnerSection;
							num = (short)60948489;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 9:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection topFunctionProgrammableButtonListInnerSection;
						if (topFunctionProgrammableButtonListInnerSection != null)
						{
							num = (short)1012400147;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_334;
					}
					case 10:
						goto IL_269;
					case 11:
					{
						num = (short)621084672;
						short num5 = num;
						goto IL_269;
					}
					case 12:
						if (global::AcpCommonLib.FeatureManager.GetFeature(4003) != null)
						{
							num = (short)54984711;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 13:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9 controlHeadO;
						if (controlHeadO != null)
						{
							num = (short)859308038;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 14:
						num = (short)308740111;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (!global::AcpCommonLib.AppInfoManager.BackgroundDeserializeOpertaion)
						{
							num = (short)747044886;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_334;
					case 16:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection topFunctionProgrammableButtonListInnerSection;
						if (topFunctionProgrammableButtonListInnerSection.TopFunctionBtnCnvChannel_A36943.UIValue != topFunctionProgrammableButtonListInnerSection.TopFunctionBtnCnvChannel_A36943.InvalidText)
						{
							num = (short)590217230;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_334;
					}
					case 17:
						num = (short)731512844;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						switch (0)
						{
						case 0:
							goto IL_B3;
						}
						continue;
					case 19:
						num = (short)386007061;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset topFunctionProgrammableButtonListInnerRecset;
						if (topFunctionProgrammableButtonListInnerRecset != null)
						{
							num = (short)1898119172;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 21:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection topFunctionProgrammableButtonListInnerSection;
						if (topFunctionProgrammableButtonListInnerSection.TopFunctionBtnCnvChannel_A36943 != null)
						{
							num = (short)133431321;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_334;
					}
					case 22:
						num = (short)2015297541;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner;
						if (topFunctionProgrammableButtonListInner != null)
						{
							num = (short)1341587464;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_334;
					}
					case 24:
						goto IL_334;
					case 25:
						num = (short)1022361600;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						return;
					}
					IL_B3:
					if (global::ConstraintHelper.UtilityMack.IsMobile())
					{
						num = (short)95092753;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_24B:
					num = (short)1861877761;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_269:
					num = (short)2059403267;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_334:
					num3++;
					num = (short)963706890;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x060081A0 RID: 33184 RVA: 0x0078770C File Offset: 0x0078590C
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 18;
			short num;
			while (!this.b)
			{
				num = (short)1683916148;
				short num2 = num;
				num = (short)1764263284;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)137297920;
					if (num != 0)
					{
					}
					num = (short)750977025;
					if (num != 0)
					{
					}
					this.b = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("ﳒ铔믖뗘鷚룜뻞闠離韤苦髨탪軬胮鳰菲髴駶鳸闺觼탾猀戂愄渆昈⸊㼌㼎琐愒爔砖眘琚瀜瘞䈠倢$ᔦᤨ䠪䈬䄮地娲刴䈶䬸娺䤼嘾⹀ⵂ橄⑆♈╊㥌㵎㹐㽒♔硖㩘㑚㍜⭞፠ౢ।䉦孨孪լ੮ၰᝲ側䕶䥸噺塼䵾놀버ꢆﮎﲒ璉ﾖﲘ漢列颠趢\udda4욦쒨잪", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
			num = (short)1645740032;
			short num3 = num;
		}

		// Token: 0x060081A1 RID: 33185 RVA: 0x007877F0 File Offset: 0x007859F0
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)921042945;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_14F7;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 2:
					num = (short)1438253056;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_31:
				switch (connectionId)
				{
				case 1:
					goto IL_E3C;
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
				case 19:
				case 20:
				case 21:
				case 22:
				case 23:
				case 24:
				case 25:
				case 26:
				case 27:
				case 28:
				case 29:
				case 30:
				case 31:
				case 32:
				case 33:
				case 34:
				case 35:
				case 36:
				case 37:
				case 38:
				case 39:
				case 40:
				case 41:
				case 42:
				case 43:
				case 44:
				case 45:
				case 46:
				case 47:
				case 48:
				case 49:
				case 50:
				case 51:
				case 52:
					goto IL_2BE5;
				case 53:
					goto IL_E6D;
				case 54:
					goto IL_93A;
				case 55:
					goto IL_2BC1;
				case 56:
					goto IL_1F05;
				case 57:
					goto IL_2A0C;
				case 58:
					goto IL_1D59;
				case 59:
					goto IL_1D1B;
				case 60:
					goto IL_B62;
				case 61:
					goto IL_2321;
				case 62:
					goto IL_175E;
				case 63:
					goto IL_D99;
				case 64:
					goto IL_A94;
				case 65:
					goto IL_295C;
				case 66:
					goto IL_1A83;
				case 67:
					goto IL_1818;
				case 68:
					goto IL_1DD2;
				case 69:
					goto IL_18EF;
				case 70:
					goto IL_2ABC;
				case 71:
					goto IL_1098;
				case 72:
					goto IL_1CE7;
				case 73:
					goto IL_24B6;
				case 74:
					goto IL_1327;
				case 75:
					goto IL_2092;
				case 76:
					goto IL_2742;
				case 77:
					goto IL_1162;
				case 78:
					goto IL_164C;
				case 79:
					goto IL_2230;
				case 80:
					goto IL_1F29;
				case 81:
					goto IL_2892;
				case 82:
					goto IL_251E;
				case 83:
					goto IL_1E65;
				case 84:
					goto IL_1954;
				case 85:
					goto IL_BD1;
				case 86:
					goto IL_17B6;
				case 87:
					goto IL_10FD;
				case 88:
					goto IL_23BE;
				case 89:
					goto IL_116F;
				case 90:
					goto IL_29D8;
				case 91:
					goto IL_1520;
				case 92:
					goto IL_28C6;
				case 93:
					goto IL_21B1;
				case 94:
					goto IL_1DDF;
				case 95:
					goto IL_2AAF;
				case 96:
					goto IL_1365;
				case 97:
					goto IL_2159;
				case 98:
					goto IL_298D;
				case 99:
					goto IL_D68;
				case 100:
					goto IL_1422;
				case 101:
					goto IL_2678;
				case 102:
					goto IL_1396;
				case 103:
					goto IL_25C8;
				case 104:
					goto IL_227E;
				case 105:
					goto IL_1A76;
				case 106:
					goto IL_2264;
				case 107:
					goto IL_2B83;
				case 108:
					goto IL_179C;
				case 109:
					goto IL_283A;
				case 110:
					goto IL_158F;
				case 111:
					goto IL_117C;
				case 112:
					goto IL_8BB;
				case 113:
					goto IL_DBD;
				case 114:
					goto IL_15E7;
				case 115:
					goto IL_12E9;
				case 116:
					goto IL_D8C;
				case 117:
					goto IL_F00;
				case 118:
					goto IL_C9B;
				case 119:
					goto IL_1C01;
				case 120:
					goto IL_2704;
				case 121:
					goto IL_BA0;
				case 122:
					goto IL_1334;
				case 123:
					goto IL_214C;
				case 124:
					goto IL_96B;
				case 125:
					goto IL_BDE;
				case 126:
					goto IL_1863;
				case 127:
					goto IL_B3E;
				case 128:
					goto IL_2511;
				case 129:
					goto IL_26AC;
				case 130:
					goto IL_15F4;
				case 131:
					goto IL_2B2E;
				case 132:
					goto IL_13FB;
				case 133:
					goto IL_274F;
				case 134:
					goto IL_C50;
				case 135:
					goto IL_14C5;
				case 136:
					goto IL_1CA9;
				case 137:
					goto IL_1EA3;
				case 138:
					goto IL_24F7;
				case 139:
					goto IL_2542;
				case 140:
					goto IL_203A;
				case 141:
					goto IL_95E;
				case 142:
					goto IL_2B07;
				case 143:
					goto IL_1341;
				case 144:
					goto IL_1A1E;
				case 145:
					goto IL_2816;
				case 146:
					goto IL_2620;
				case 147:
					goto IL_22ED;
				case 148:
					goto IL_265E;
				case 149:
					goto IL_873;
				case 150:
					goto IL_2692;
				case 151:
					goto IL_A2F;
				case 152:
					goto IL_C0F;
				case 153:
					goto IL_2AA2;
				case 154:
					goto IL_211B;
				case 155:
					goto IL_978;
				case 156:
					goto IL_1F7E;
				case 157:
					goto IL_1BD0;
				case 158:
					goto IL_1625;
				case 159:
					goto IL_258A;
				case 160:
					goto IL_D5B;
				case 161:
					goto IL_1D4C;
				case 162:
					goto IL_8EF;
				case 163:
					goto IL_B93;
				case 164:
					goto IL_209F;
				case 165:
					goto IL_1E03;
				case 166:
					goto IL_A7A;
				case 167:
					goto IL_21A4;
				case 168:
					goto IL_A6D;
				case 169:
					goto IL_11F8;
				case 170:
					goto IL_1494;
				case 171:
					goto IL_18C8;
				case 172:
					goto IL_1A2B;
				case 173:
					goto IL_1F71;
				case 174:
					goto IL_1B82;
				case 175:
					goto IL_1BC3;
				case 176:
					goto IL_12DC;
				case 177:
					goto IL_1B8F;
				case 178:
					goto IL_1239;
				case 179:
					goto IL_FBA;
				case 180:
					goto IL_10A5;
				case 181:
					goto IL_1E96;
				case 182:
					goto IL_2A7E;
				case 183:
					goto IL_A60;
				case 184:
					goto IL_13BD;
				case 185:
					goto IL_2085;
				case 186:
					goto IL_1961;
				case 187:
					goto IL_F62;
				case 188:
					goto IL_20AC;
				case 189:
					goto IL_1BB6;
				case 190:
					goto IL_178F;
				case 191:
					goto IL_192D;
				case 192:
					goto IL_1AF2;
				case 193:
					goto IL_27BE;
				case 194:
					goto IL_1372;
				case 195:
					goto IL_A22;
				case 196:
					goto IL_1AC1;
				case 197:
					goto IL_2173;
				case 198:
					goto IL_2B5F;
				case 199:
					goto IL_2447;
				case 200:
					goto IL_ADC;
				case 201:
					goto IL_C6A;
				case 202:
					goto IL_1782;
				case 203:
					goto IL_1D0E;
				case 204:
					goto IL_ECF;
				case 205:
					goto IL_E15;
				case 206:
					goto IL_2861;
				case 207:
					goto IL_DE1;
				case 208:
					goto IL_1849;
				case 209:
					goto IL_22BC;
				case 210:
					goto IL_1E10;
				case 211:
					goto IL_126D;
				case 212:
					goto IL_FC7;
				case 213:
					goto IL_B24;
				case 214:
					goto IL_1985;
				case 215:
					goto IL_1D3F;
				case 216:
					goto IL_1117;
				case 217:
					goto IL_238D;
				case 218:
					goto IL_1DAE;
				case 219:
					goto IL_1720;
				case 220:
					goto IL_15B6;
				case 221:
					goto IL_CE6;
				case 222:
					goto IL_173A;
				case 223:
					goto IL_1E34;
				case 224:
					goto IL_20F7;
				case 225:
					goto IL_122C;
				case 226:
					goto IL_23EF;
				case 227:
					goto IL_21D8;
				case 228:
					goto IL_25E2;
				case 229:
					goto IL_2911;
				case 230:
					goto IL_2345;
				case 231:
					goto IL_113B;
				case 232:
					goto IL_187D;
				case 233:
					goto IL_2942;
				case 234:
					goto IL_9DA;
				case 235:
					goto IL_9CD;
				case 236:
					goto IL_EAB;
				case 237:
					goto IL_CD9;
				case 238:
					goto IL_CF3;
				case 239:
					goto IL_243A;
				case 240:
					goto IL_2597;
				case 241:
					goto IL_2606;
				case 242:
					goto IL_1B16;
				case 243:
					goto IL_D27;
				case 244:
					goto IL_2AFA;
				case 245:
					goto IL_2AE0;
				case 246:
					goto IL_127A;
				case 247:
					goto IL_1CF4;
				case 248:
					goto IL_2128;
				case 249:
					goto IL_1C32;
				case 250:
					goto IL_1870;
				case 251:
					goto IL_2A4A;
				case 252:
					goto IL_E87;
				case 253:
					goto IL_10F0;
				case 254:
					goto IL_1CC3;
				case 255:
					goto IL_26EA;
				case 256:
					goto IL_EF3;
				case 257:
					goto IL_266B;
				case 258:
					goto IL_1659;
				case 259:
					goto IL_D1A;
				case 260:
					goto IL_916;
				case 261:
					goto IL_23FC;
				case 262:
					goto IL_180B;
				case 263:
					goto IL_2A57;
				case 264:
					goto IL_13D7;
				case 265:
					goto IL_1A11;
				case 266:
					goto IL_AB8;
				case 267:
					goto IL_146D;
				case 268:
					goto IL_2013;
				case 269:
					goto IL_1155;
				case 270:
					goto IL_1897;
				case 271:
					goto IL_2613;
				case 272:
					goto IL_168A;
				case 273:
					goto IL_16AE;
				case 274:
					goto IL_2166;
				case 275:
					goto IL_1205;
				case 276:
					goto IL_2773;
				case 277:
					goto IL_202D;
				case 278:
					goto IL_1A52;
				case 279:
					goto IL_1920;
				case 280:
					goto IL_130D;
				case 281:
					goto IL_E22;
				case 282:
					goto IL_1551;
				case 283:
					goto IL_2566;
				case 284:
					goto IL_A87;
				case 285:
					goto IL_24C3;
				case 286:
					goto IL_26DD;
				case 287:
					goto IL_1C82;
				case 288:
					goto IL_1487;
				case 289:
					goto IL_2980;
				case 290:
					goto IL_F89;
				case 291:
					goto IL_2797;
				case 292:
					goto IL_1947;
				case 293:
					goto IL_11C7;
				case 294:
					goto IL_18FC;
				case 295:
					goto IL_1C9C;
				case 296:
					goto IL_1B3A;
				case 297:
					goto IL_D00;
				case 298:
					goto IL_10E3;
				case 299:
					goto IL_1992;
				case 300:
					goto IL_1A9D;
				case 301:
					goto IL_1C68;
				case 302:
					goto IL_C77;
				case 303:
					goto IL_E7A;
				case 304:
					goto IL_24A9;
				case 305:
					goto IL_19F7;
				case 306:
					goto IL_1E41;
				case 307:
					goto IL_29FF;
				case 308:
					goto IL_12B8;
				case 309:
					goto IL_2B52;
				case 310:
					goto IL_D4E;
				case 311:
					goto IL_28B9;
				case 312:
					goto IL_1449;
				case 313:
					goto IL_1632;
				case 314:
					goto IL_CB5;
				case 315:
					goto IL_2047;
				case 316:
					goto IL_866;
				case 317:
					goto IL_25BB;
				case 318:
					goto IL_D34;
				case 319:
					goto IL_2298;
				case 320:
					goto IL_2735;
				case 321:
					goto IL_143C;
				case 322:
					goto IL_27CB;
				case 323:
					goto IL_2257;
				case 324:
					goto IL_1EEB;
				case 325:
					goto IL_1036;
				case 326:
					goto IL_13CA;
				case 327:
					goto IL_8E2;
				case 328:
					goto IL_1A04;
				case 329:
					goto IL_C02;
				case 330:
					goto IL_C5D;
				case 331:
					goto IL_F1A;
				case 332:
					goto IL_15A9;
				case 333:
					goto IL_F3E;
				case 334:
					goto IL_FF8;
				case 335:
					goto IL_2854;
				case 336:
					goto IL_29CB;
				case 337:
					goto IL_2180;
				case 338:
					goto IL_2454;
				case 339:
					goto IL_2461;
				case 340:
					goto IL_1C8F;
				case 341:
					goto IL_E08;
				case 342:
					goto IL_17A9;
				case 343:
					goto IL_1F4D;
				case 344:
					goto IL_19B9;
				case 345:
					goto IL_22C9;
				case 346:
					goto IL_224A;
				case 347:
					goto IL_2314;
				case 348:
					goto IL_1BA9;
				case 349:
					goto IL_1B5E;
				case 350:
					goto IL_1189;
				case 351:
					goto IL_9FE;
				case 352:
					goto IL_1043;
				case 353:
					goto IL_299A;
				case 354:
					goto IL_27FC;
				case 355:
					goto IL_29A7;
				case 356:
					goto IL_DFB;
				case 357:
					goto IL_11A3;
				case 358:
					goto IL_10C9;
				case 359:
					goto IL_1246;
				case 360:
					goto IL_DEE;
				case 361:
					goto IL_1029;
				case 362:
					goto IL_15C3;
				case 363:
					goto IL_20EA;
				case 364:
					goto IL_2BB4;
				case 365:
					goto IL_F7C;
				case 366:
					goto IL_2307;
				case 367:
					goto IL_269F;
				case 368:
					goto IL_1C25;
				case 369:
					goto IL_8C8;
				case 370:
					goto IL_FEB;
				case 371:
					goto IL_110A;
				case 372:
					goto IL_1A45;
				case 373:
					goto IL_1050;
				case 374:
					goto IL_28AC;
				case 375:
					goto IL_16EF;
				case 376:
					goto IL_859;
				case 377:
					goto IL_242D;
				case 378:
					goto IL_2A30;
				case 379:
					goto IL_1BDD;
				case 380:
					goto IL_27A4;
				case 381:
					goto IL_1601;
				case 382:
					goto IL_25D5;
				case 383:
					goto IL_147A;
				case 384:
					goto IL_18D5;
				case 385:
					goto IL_F96;
				case 386:
					goto IL_E2F;
				case 387:
					goto IL_2369;
				case 388:
					goto IL_16E2;
				case 389:
					goto IL_2685;
				case 390:
					goto IL_2AED;
				case 391:
					goto IL_152D;
				case 392:
					goto IL_13A3;
				case 393:
					goto IL_B00;
				case 394:
					goto IL_18E2;
				case 395:
					goto IL_167D;
				case 396:
					goto IL_294F;
				case 397:
					goto IL_C29;
				case 398:
					goto IL_26B9;
				case 399:
					goto IL_2006;
				case 400:
					goto IL_CA8;
				case 401:
					goto IL_12AB;
				case 402:
					goto IL_1856;
				case 403:
					goto IL_2809;
				case 404:
					goto IL_21F2;
				case 405:
					goto IL_188A;
				case 406:
					goto IL_1D01;
				case 407:
					goto IL_1C75;
				case 408:
					goto IL_2061;
				case 409:
					goto IL_1A90;
				case 410:
					goto IL_1D8A;
				case 411:
					goto IL_14D2;
				case 412:
					goto IL_BC4;
				case 413:
					goto IL_D41;
				case 414:
					goto IL_220C;
				case 415:
					goto IL_F0D;
				case 416:
					goto IL_17E7;
				case 417:
					goto IL_F6F;
				case 418:
					goto IL_17DA;
				case 419:
					goto IL_16BB;
				case 420:
					goto IL_14A1;
				case 421:
					goto IL_1713;
				case 422:
					goto IL_9A9;
				case 423:
					goto IL_1196;
				case 424:
					goto IL_1B9C;
				case 425:
					goto IL_172D;
				case 426:
					goto IL_289F;
				case 427:
					goto IL_897;
				case 428:
					goto IL_2A3D;
				case 429:
					goto IL_155E;
				case 430:
					goto IL_193A;
				case 431:
					goto IL_C1C;
				case 432:
					goto IL_A53;
				case 433:
					goto IL_13B0;
				case 434:
					goto IL_142F;
				case 435:
					goto IL_2271;
				case 436:
					goto IL_1005;
				case 437:
					goto IL_C36;
				case 438:
					goto IL_2485;
				case 439:
					goto IL_2847;
				case 440:
					goto IL_1212;
				case 441:
					goto IL_199F;
				case 442:
					goto IL_19C6;
				case 443:
					goto IL_1FAF;
				case 444:
					goto IL_1074;
				case 445:
					goto IL_20DD;
				case 446:
					goto IL_228B;
				case 447:
					goto IL_23E2;
				case 448:
					goto IL_B31;
				case 449:
					goto IL_2B90;
				case 450:
					goto IL_C43;
				case 451:
					goto IL_2B21;
				case 452:
					goto IL_1EF8;
				case 453:
					goto IL_26F7;
				case 454:
					goto IL_8FC;
				case 455:
					goto IL_28F7;
				case 456:
					goto IL_2B14;
				case 457:
					goto IL_19EA;
				case 458:
					goto IL_239A;
				case 459:
					goto IL_2A71;
				case 460:
					goto IL_11D4;
				case 461:
					goto IL_27B1;
				case 462:
					goto IL_1408;
				case 463:
					goto IL_D0D;
				case 464:
					goto IL_2409;
				case 465:
					goto IL_1CB6;
				case 466:
					goto IL_985;
				case 467:
					goto IL_131A;
				case 468:
					goto IL_B86;
				case 469:
					goto IL_21BE;
				case 470:
					goto IL_8D5;
				case 471:
					goto IL_27D8;
				case 472:
					goto IL_2A64;
				case 473:
					goto IL_29E5;
				case 474:
					goto IL_10D6;
				case 475:
					goto IL_129E;
				case 476:
					goto IL_1253;
				case 477:
					goto IL_159C;
				case 478:
					goto IL_22FA;
				case 479:
					goto IL_1260;
				case 480:
					goto IL_262D;
				case 481:
					goto IL_28EA;
				case 482:
					goto IL_1E72;
				case 483:
					goto IL_21CB;
				case 484:
					goto IL_1FA2;
				case 485:
					goto IL_29F2;
				case 486:
					goto IL_2711;
				case 487:
					goto IL_16C8;
				case 488:
					goto IL_1ACE;
				case 489:
					goto IL_20D0;
				case 490:
					goto IL_2885;
				case 491:
					goto IL_1415;
				case 492:
					goto IL_18BB;
				case 493:
					goto IL_1EC7;
				case 494:
					goto IL_2054;
				case 495:
					goto IL_121F;
				case 496:
					goto IL_223D;
				case 497:
					goto IL_2651;
				case 498:
					goto IL_2020;
				case 499:
					goto IL_21E5;
				case 500:
					goto IL_2904;
				case 501:
					goto IL_909;
				case 502:
					goto IL_1825;
				case 503:
					goto IL_16D5;
				case 504:
					goto IL_14FC;
				case 505:
					goto IL_1D7D;
				case 506:
					goto IL_2504;
				case 507:
					goto IL_1A38;
				case 508:
					goto IL_291E;
				case 509:
					goto IL_19AC;
				case 510:
					goto IL_156B;
				case 511:
					goto IL_1148;
				case 512:
					goto IL_163F;
				case 513:
					goto IL_21FF;
				default:
					num = (short)866451458;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_859:
			this.RTDBtnRadErgCtrlHeadO9DirLightBarName_A36558 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_866:
			this.CpyBtnCHO9BottomFunctionButtonIndex_A36665 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_873:
			this.CHO9DataButtonTrkIndex_A41416 = (global::AcpUI.AcpComboBox)target;
			this.CHO9DataButtonTrkIndex_A41416.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_897:
			this.RecNavToolbarExpanderControlHeadO9RelayPatternBCOListList = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderControlHeadO9RelayPatternBCOListList.ModeClick += this.OnModeClick;
			return;
			IL_8BB:
			this.gridExpanderControlHeadO9O9DataButtonSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_8C8:
			this.RadErgCtrlHeadO9DirLightBarFeature_A36597_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_8D5:
			this.ExpanderControlHeadO9O9NavigationControlsExpander = (global::AcpUI.AcpExpander)target;
			return;
			IL_8E2:
			this.CHO9PursuitKnobSecondaryIndex_A36823_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_8EF:
			this.CHO9CnvTopFunctionButtonLabelLine1_A36626_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_8FC:
			this.RadErgoControlO9ACBCOListBco_A36666_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_909:
			this.gridExpanderControlHeadO9BottomFunctionButtonBCOListSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_916:
			this.LblO9CHTrkTopFunctionButtonIndex_A36639 = (global::AcpUI.AcpLabel)target;
			this.LblO9CHTrkTopFunctionButtonIndex_A36639.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_93A:
			this.HLinkControlHeadO9GraphicalView = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkControlHeadO9GraphicalView.Click += this.HLinkClick;
			return;
			IL_95E:
			this.CpyBtnRadErgCtrlHeadO9DataButtonTrkBCO_A36527 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_96B:
			this.RadErgCtrlHeadO9DataButtonCnvBCO_A36529Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_978:
			this.ExpanderControlHeadO9TopFunctionProgrammableButton = (global::AcpUI.AcpExpander)target;
			return;
			IL_985:
			this.LblRadErgoControlO9ACBCOListIndex_A36668 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoControlO9ACBCOListIndex_A36668.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_9A9:
			this.LblCHO9PASirenButtonsFeature_A41540 = (global::AcpUI.AcpLabel)target;
			this.LblCHO9PASirenButtonsFeature_A41540.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_9CD:
			this.CVBtnCHO9TrkTopFunctionButtonLabelLine1_A36650 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_9DA:
			this.CHO9TrkTopFunctionButtonLabelLine1_A36650 = (global::AcpUI.AcpTextBox)target;
			this.CHO9TrkTopFunctionButtonLabelLine1_A36650.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_9FE:
			this.LblCHO9PursuitKnobSecondaryIndex_A36823 = (global::AcpUI.AcpLabel)target;
			this.LblCHO9PursuitKnobSecondaryIndex_A36823.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A22:
			this.RTDBtnCHO9CnvTopFunctionButtonLabelLine2_A36627 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A2F:
			this.LblCHO9DataButtonTrkIndex_A41416 = (global::AcpUI.AcpLabel)target;
			this.LblCHO9DataButtonTrkIndex_A41416.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A53:
			this.RdEgoO9DirLtbarPatternBcoListBco_A36661_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_A60:
			this.RTDBtnCHO9TopFunctionButton_A36618 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A6D:
			this.TopFunctionBtnCnvZone_A36942_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_A7A:
			this.O9CHCnvTopFunctionButtonIndex_A36634_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_A87:
			this.ExpanderControlHeadO9BottomFunctionProgrammableButtonGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_A94:
			this.HLinkO9NavigationControlsExpander = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkO9NavigationControlsExpander.Click += this.HLinkClick;
			return;
			IL_AB8:
			this.LblO9CHTrkTopFunctionButtonStsMsgIndex_A36782 = (global::AcpUI.AcpLabel)target;
			this.LblO9CHTrkTopFunctionButtonStsMsgIndex_A36782.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_ADC:
			this.LblCnvTopFunctionButtonBCO_A36628 = (global::AcpUI.AcpLabel)target;
			this.LblCnvTopFunctionButtonBCO_A36628.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_B00:
			this.LblRadErgCtrlHeadO9DirLightBarIndex_A36601 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgCtrlHeadO9DirLightBarIndex_A36601.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_B24:
			this.RTDBtnO9CHCnvTopFunctionButtonIndex_A36634 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_B31:
			this.ExpanderControlHeadO9ConsolidatedActionBCOList = (global::AcpUI.AcpExpander)target;
			return;
			IL_B3E:
			this.LblRadErgCtrlHeadO9DataButtonCnvFeature_A36528 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgCtrlHeadO9DataButtonCnvFeature_A36528.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_B62:
			this.HLinkDirectionalButtons = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkDirectionalButtons.Click += this.HLinkClick;
			return;
			IL_B86:
			this.CpyBtnRadErgoControlO9ACBCOListIndex_A36668 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B93:
			this.CHO9CnvTopFunctionButtonLabelLine2_A36627_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_BA0:
			this.LblRadErgCtrlHeadO9DataButtonCnvBCO_A36529 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgCtrlHeadO9DataButtonCnvBCO_A36529.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_BC4:
			this.CpyBtnCHO9PASirenButtonsName_A41537 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_BD1:
			this.CHO9EmergencyButtonName_A36680Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_BDE:
			this.RadErgCtrlHeadO9DataButtonCnvFeature_A36528 = (global::AcpUI.AcpComboBox)target;
			this.RadErgCtrlHeadO9DataButtonCnvFeature_A36528.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_C02:
			this.ExpanderControlHeadO9ResponseSelectorListSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_C0F:
			this.RTDBtnCHO9DataButtonTrkIndex_A41416 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_C1C:
			this.ExpanderControlHeadO9RelayPatternBCOListList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_C29:
			this.ExpanderControlHeadO9PASirenButtons = (global::AcpUI.AcpExpander)target;
			return;
			IL_C36:
			this.CVBtnRdEgoO9DirLtbarPatternBcoListBco_A36661 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_C43:
			this.ExpanderControlHeadO9ConsolidatedActionBCOListGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_C50:
			this.RTDBtnCHO9DataButtonConvIndex_A41414 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_C5D:
			this.gridExpanderControlHeadO9ResponseSelectorListSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_C6A:
			this.RTDBtnCnvTopFunctionButtonBCO_A36628 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_C77:
			this.LblCHO9BottomFunctionButtonBCO_A36660 = (global::AcpUI.AcpLabel)target;
			this.LblCHO9BottomFunctionButtonBCO_A36660.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_C9B:
			this.RadErgCtrlHeadO9DataButtonName_A36523Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_CA8:
			this.ExpanderControlHeadO9PASirenButtonsListGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_CB5:
			this.LblCHO9BottomFunctionButtonIndex_A36665 = (global::AcpUI.AcpLabel)target;
			this.LblCHO9BottomFunctionButtonIndex_A36665.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_CD9:
			this.RTDBtnCHO9TrkTopFunctionButtonLabelLine1_A36650 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_CE6:
			this.O9CHCnvTopFunctionButtonStsMsgIndex_A36781Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_CF3:
			this.CpyBtnCHO9TrkTopFunctionButtonLabelLine1_A36650 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_D00:
			this.RTDBtnCHO9BottomFunctionButtonName_A36657 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_D0D:
			this.RadErgoControlO9ACBCOListBco_A36666Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_D1A:
			this.CVBtnO9CHTrkTopFunctionButtonIndex_A36639 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_D27:
			this.RTDBtnCHO9TrkTopFunctionButtonLabelLine2_A36651 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_D34:
			this.ExpanderControlHeadO9ResponseSelector = (global::AcpUI.AcpExpander)target;
			return;
			IL_D41:
			this.CHO9PASirenButtonsName_A41537Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_D4E:
			this.CpyBtnCHO9BottomFunctionButtonFeature_A36664 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_D5B:
			this.ExpanderControlHeadO9TopFunctionProgrammableButtonList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_D68:
			this.RecNavToolbarExpanderControlHeadO9O9DataButton = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderControlHeadO9O9DataButton.ModeClick += this.OnModeClick;
			return;
			IL_D8C:
			this.RTDBtnRadErgCtrlHeadO9DataButtonName_A36523 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_D99:
			this.HLinkConsolidatedActionBCOList = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkConsolidatedActionBCOList.Click += this.HLinkClick;
			return;
			IL_DBD:
			this.RadErgCtrlHeadO9DataButtonName_A36523 = (global::AcpUI.AcpLabel)target;
			this.RadErgCtrlHeadO9DataButtonName_A36523.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_DE1:
			this.RTDBtnO9CHCnvTopFunctionButtonFeature_A36629 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_DEE:
			this.CHO9PursuitKnobTertiaryIndex_A37025Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_DFB:
			this.CVBtnCHO9PursuitKnobTertiaryIndex_A37025 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_E08:
			this.CpyBtnCHO9PursuitKnobAction_A36684 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_E15:
			this.CVBtnO9CHCnvTopFunctionButtonFeature_A36629 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_E22:
			this.TopFunctionBtnTrkChannel_A36945Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_E2F:
			this.CVBtnRadErgCtrlHeadO9DirLightBarFeature_A36597 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_E3C:
			((global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PageControlHeadO9)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PageControlHeadO9)target).Unloaded += this.OnUnloaded;
			return;
			IL_E6D:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_E7A:
			this.RTDBtnCHO9BottomFunctionButtonBCO_A36660 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_E87:
			this.O9CHTrkTopFunctionButtonFeature_A36637 = (global::AcpUI.AcpComboBox)target;
			this.O9CHTrkTopFunctionButtonFeature_A36637.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_EAB:
			this.LblCHO9TrkTopFunctionButtonLabelLine1_A36650 = (global::AcpUI.AcpLabel)target;
			this.LblCHO9TrkTopFunctionButtonLabelLine1_A36650.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_ECF:
			this.O9CHCnvTopFunctionButtonFeature_A36629 = (global::AcpUI.AcpComboBox)target;
			this.O9CHCnvTopFunctionButtonFeature_A36629.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_EF3:
			this.CpyBtnO9CHTrkTopFunctionButtonFeature_A36637 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_F00:
			this.CpyBtnRadErgCtrlHeadO9DataButtonName_A36523 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_F0D:
			this.CVBtnCHO9PASirenButtonsBCO_A41538 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_F1A:
			this.CHO9PursuitKnobMode_A36683 = (global::AcpUI.AcpLabel)target;
			this.CHO9PursuitKnobMode_A36683.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_F3E:
			this.LblCHO9PursuitKnobMode_A36683 = (global::AcpUI.AcpLabel)target;
			this.LblCHO9PursuitKnobMode_A36683.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_F62:
			this.CVBtnCHO9CnvTopFunctionButtonLabelLine1_A36626 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_F6F:
			this.RTDBtnCHO9PASirenButtonsBCO_A41538 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_F7C:
			this.ExpanderControlHeadO9DirectionalButtonsListTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_F89:
			this.CHO9BottomFunctionButtonFeature_A36664_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_F96:
			this.RadErgCtrlHeadO9DirLightBarFeature_A36597 = (global::AcpUI.AcpComboBox)target;
			this.RadErgCtrlHeadO9DirLightBarFeature_A36597.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_FBA:
			this.gridExpanderControlHeadO9TopFunctionProgrammableButtonListSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_FC7:
			this.LblO9CHCnvTopFunctionButtonIndex_A36634 = (global::AcpUI.AcpLabel)target;
			this.LblO9CHCnvTopFunctionButtonIndex_A36634.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_FEB:
			this.RadErgCtrlHeadO9DirLightBarIndex_A36601_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_FF8:
			this.RTDBtnCHO9PursuitKnobMode_A36683 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1005:
			this.RdEgoO9DirLtbarPatternBcoListBco_A36661 = (global::AcpUI.AcpComboBox)target;
			this.RdEgoO9DirLtbarPatternBcoListBco_A36661.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1029:
			this.ExpanderControlHeadO9DirectionalButtons = (global::AcpUI.AcpExpander)target;
			return;
			IL_1036:
			this.CHO9PursuitKnobAction_A36684_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1043:
			this.RTDBtnCHO9PursuitKnobSecondaryIndex_A36823 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1050:
			this.RadErgCtrlHeadO9DirLightBarName_A36558 = (global::AcpUI.AcpLabel)target;
			this.RadErgCtrlHeadO9DirLightBarName_A36558.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1074:
			this.LblRdEgoO9DirLtbarPatternBcoListIndex_A36707 = (global::AcpUI.AcpLabel)target;
			this.LblRdEgoO9DirLtbarPatternBcoListIndex_A36707.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1098:
			this.ExpanderControlHeadO9GeneralGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_10A5:
			this.CHO9TopFunctionButton_A36618 = (global::AcpUI.AcpLabel)target;
			this.CHO9TopFunctionButton_A36618.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_10C9:
			this.RTDBtnCHO9PursuitKnobTertiaryIndex_A37025 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_10D6:
			this.ExpanderControlHeadO9O9NavigationControlsTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_10E3:
			this.CpyBtnCHO9BottomFunctionButtonName_A36657 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_10F0:
			this.CVBtnO9CHTrkTopFunctionButtonFeature_A36637 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_10FD:
			this.CVBtnCHO9EmergencyButtonBCO_A36681 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_110A:
			this.ExpanderControlHeadO9DirectionalButtonsListSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1117:
			this.O9CHCnvTopFunctionButtonStsMsgIndex_A36781 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.O9CHCnvTopFunctionButtonStsMsgIndex_A36781.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_113B:
			this.RTDBtnTopFunctionBtnCnvChannel_A36943 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1148:
			this.RTDBtnCHO9BottomFunctionButtonFeature_A36826 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1155:
			this.O9CHTrkTopFunctionButtonStsMsgIndex_A36782Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1162:
			this.CHO9EmergencyButtonFeature_A36682_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_116F:
			this.RTDBtnCHO9EmergencyButtonBCO_A36681 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_117C:
			this.ExpanderControlHeadO9O9DataButtonSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1189:
			this.CVBtnCHO9PursuitKnobSecondaryIndex_A36823 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1196:
			this.RTDBtnCHO9PASirenButtonsFeature_A41540 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_11A3:
			this.LblCHO9PursuitKnobTertiaryIndex_A37025 = (global::AcpUI.AcpLabel)target;
			this.LblCHO9PursuitKnobTertiaryIndex_A37025.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_11C7:
			this.gridExpanderControlHeadO9BottomFunctionProgrammableButtonTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_11D4:
			this.LblRadErgoControlO9ACBCOListBco_A36666 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoControlO9ACBCOListBco_A36666.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_11F8:
			this.TopFunctionBtnCnvChannel_A36943_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1205:
			this.TopFunctionBtnTrkZone_A36944Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1212:
			this.CpyBtnRdEgoO9DirLtbarPatternBcoListBco_A36661 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_121F:
			this.ExpanderControlHeadO9BottomFunctionButtonBCOListGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_122C:
			this.RTDBtnTopFunctionBtnCnvZone_A36942 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1239:
			this.ExpanderControlHeadO9TopFunctionProgrammableButtonListSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1246:
			this.CpyBtnCHO9PursuitKnobTertiaryIndex_A37025 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1253:
			this.RadErgoControlO9NaviControlName_A41370_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1260:
			this.gridExpanderControlHeadO9O9NavigationControlsTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_126D:
			this.CVBtnO9CHCnvTopFunctionButtonIndex_A36634 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_127A:
			this.O9CHTrkTopFunctionButtonBCO_A36636 = (global::AcpUI.AcpComboBox)target;
			this.O9CHTrkTopFunctionButtonBCO_A36636.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_129E:
			this.ExpanderControlHeadO9O9NavigationControlsTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_12AB:
			this.ExpanderControlHeadO9PASirenButtonsListTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_12B8:
			this.LblCHO9BottomFunctionButtonFeature_A36664 = (global::AcpUI.AcpLabel)target;
			this.LblCHO9BottomFunctionButtonFeature_A36664.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_12DC:
			this.TopFunctionBtnTrkZone_A36944_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_12E9:
			this.LblRadErgCtrlHeadO9DataButtonName_A36523 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgCtrlHeadO9DataButtonName_A36523.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_130D:
			this.CpyBtnTopFunctionBtnTrkChannel_A36945 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_131A:
			this.RTDBtnRadErgoControlO9ACBCOListIndex_A36668 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1327:
			this.ExpanderControlHeadO9O9 = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_1334:
			this.RTDBtnRadErgCtrlHeadO9DataButtonCnvBCO_A36529 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1341:
			this.RadErgCtrlHeadO9DataButtonTrkFeature_A36526 = (global::AcpUI.AcpComboBox)target;
			this.RadErgCtrlHeadO9DataButtonTrkFeature_A36526.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1365:
			this.CpyBtnCHO9EmergencyButtonFeature_A36682 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1372:
			this.LblCHO9CnvTopFunctionButtonLabelLine2_A36627 = (global::AcpUI.AcpLabel)target;
			this.LblCHO9CnvTopFunctionButtonLabelLine2_A36627.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1396:
			this.ExpanderControlHeadO9O9DataButtonTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_13A3:
			this.CVBtnRadErgCtrlHeadO9DirLightBarIndex_A36601 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_13B0:
			this.RdEgoO9DirLtbarPatternBcoListIndex_A36707_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_13BD:
			this.CpyBtnCHO9TopFunctionButton_A36618 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_13CA:
			this.CHO9PursuitKnobIndex_A36685_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_13D7:
			this.O9CHTrkTopFunctionButtonStsMsgIndex_A36782 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.O9CHTrkTopFunctionButtonStsMsgIndex_A36782.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_13FB:
			this.CVBtnCHO9DataButtonConvIndex_A41414 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1408:
			this.CpyBtnRadErgoControlO9ACBCOListBco_A36666 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1415:
			this.RadErgoControlO9NaviControlFeature_A41371Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1422:
			this.ExpanderControlHeadO9ControlHeadO9DataGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_142F:
			this.ExpanderControlHeadO9RelayPatternBCOListListSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_143C:
			this.ExpanderControlHeadO9ResponseSelectorListGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_1449:
			this.CHO9BottomFunctionButtonIndex_A36665 = (global::AcpUI.AcpComboBox)target;
			this.CHO9BottomFunctionButtonIndex_A36665.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_146D:
			this.RTDBtnO9CHTrkTopFunctionButtonStsMsgIndex_A36782 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_147A:
			this.CpyBtnRadErgCtrlHeadO9DirLightBarBCO_A36559 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1487:
			this.CHO9BottomFunctionButtonName_A36657_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1494:
			this.CHO9TrkTopFunctionButtonLabelLine1_A36650_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_14A1:
			this.CHO9PASirenButtonsFeature_A41540 = (global::AcpUI.AcpComboBox)target;
			this.CHO9PASirenButtonsFeature_A41540.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_14C5:
			this.CpyBtnCHO9DataButtonConvIndex_A41414 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_14D2:
			this.RTDBtnCHO9PASirenButtonsName_A41537 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_14F7:
			goto IL_2BE5;
			IL_14FC:
			this.LblCHO9BottomFunctionButtonBCO_A36827 = (global::AcpUI.AcpLabel)target;
			this.LblCHO9BottomFunctionButtonBCO_A36827.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1520:
			this.CHO9EmergencyButtonBCO_A36681Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_152D:
			this.RadErgCtrlHeadO9DirLightBarIndex_A36601 = (global::AcpUI.AcpComboBox)target;
			this.RadErgCtrlHeadO9DirLightBarIndex_A36601.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1551:
			this.ExpanderControlHeadO9BottomFunctionProgrammableButton = (global::AcpUI.AcpExpander)target;
			return;
			IL_155E:
			this.ExpanderControlHeadO9RelayPatternBCOListListGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_156B:
			this.LblCHO9BottomFunctionButtonFeature_A36826 = (global::AcpUI.AcpLabel)target;
			this.LblCHO9BottomFunctionButtonFeature_A36826.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_158F:
			this.CHO9DataButtonTrkIndex_A41416_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_159C:
			this.RadErgoControlO9NaviControlFeature_A41371_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_15A9:
			this.CVBtnCHO9PursuitKnobMode_A36683 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_15B6:
			this.CpyBtnO9CHCnvTopFunctionButtonStsMsgIndex_A36781 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_15C3:
			this.RecNavToolbarExpanderControlHeadO9DirectionalButtonsList = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderControlHeadO9DirectionalButtonsList.ModeClick += this.OnModeClick;
			return;
			IL_15E7:
			this.CVBtnRadErgCtrlHeadO9DataButtonName_A36523 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_15F4:
			this.RadErgCtrlHeadO9DataButtonCnvFeature_A36528Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1601:
			this.LblRadErgCtrlHeadO9DirLightBarBCO_A36559 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgCtrlHeadO9DirLightBarBCO_A36559.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1625:
			this.ExpanderControlHeadO9TopFunctionProgrammableButtonListGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_1632:
			this.CVBtnCHO9BottomFunctionButtonIndex_A36665 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_163F:
			this.CpyBtnCHO9BottomFunctionButtonFeature_A36826 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_164C:
			this.ExpanderControlHeadO9O9SRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1659:
			this.O9CHTrkTopFunctionButtonIndex_A36639 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.O9CHTrkTopFunctionButtonIndex_A36639.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_167D:
			this.CpyBtnRadErgCtrlHeadO9DirLightBarIndex_A36601 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_168A:
			this.LblTopFunctionBtnTrkZone_A36944 = (global::AcpUI.AcpLabel)target;
			this.LblTopFunctionBtnTrkZone_A36944.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_16AE:
			this.RTDBtnTopFunctionBtnTrkZone_A36944 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_16BB:
			this.CHO9PASirenButtonsBCO_A41538Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_16C8:
			this.CVBtnRadErgoControlO9NaviControlFeature_A41371 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_16D5:
			this.CVBtnCHO9BottomFunctionButtonBCO_A36827 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_16E2:
			this.RTDBtnRadErgCtrlHeadO9DirLightBarFeature_A36597 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_16EF:
			this.LblRadErgCtrlHeadO9DirLightBarName_A36558 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgCtrlHeadO9DirLightBarName_A36558.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1713:
			this.CVBtnCHO9PASirenButtonsFeature_A41540 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1720:
			this.RTDBtnO9CHCnvTopFunctionButtonStsMsgIndex_A36781 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_172D:
			this.CHO9PASirenButtonsFeature_A41540Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_173A:
			this.TopFunctionBtnCnvZone_A36942 = (global::AcpUI.AcpComboBox)target;
			this.TopFunctionBtnCnvZone_A36942.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_175E:
			this.HLinkRelayPatternBCOList = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkRelayPatternBCOList.Click += this.HLinkClick;
			return;
			IL_1782:
			this.CpyBtnCnvTopFunctionButtonBCO_A36628 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_178F:
			this.CpyBtnCHO9CnvTopFunctionButtonLabelLine1_A36626 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_179C:
			this.RadErgCtrlHeadO9DataButtonTrkBCO_A36527_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_17A9:
			this.CHO9PursuitKnobAction_A36684Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_17B6:
			this.CHO9EmergencyButtonBCO_A36681 = (global::AcpUI.AcpComboBox)target;
			this.CHO9EmergencyButtonBCO_A36681.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_17DA:
			this.CpyBtnCHO9PASirenButtonsBCO_A41538 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_17E7:
			this.LblCHO9PASirenButtonsBCO_A41538 = (global::AcpUI.AcpLabel)target;
			this.LblCHO9PASirenButtonsBCO_A41538.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_180B:
			this.CpyBtnO9CHTrkTopFunctionButtonIndex_A36639 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1818:
			this.ExpanderControlHeadO9GraphicalView = (global::AcpUI.AcpExpander)target;
			return;
			IL_1825:
			this.CHO9BottomFunctionButtonBCO_A36827 = (global::AcpUI.AcpComboBox)target;
			this.CHO9BottomFunctionButtonBCO_A36827.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1849:
			this.CpyBtnO9CHCnvTopFunctionButtonFeature_A36629 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1856:
			this.ExpanderControlHeadO9PASirenButtonsList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_1863:
			this.CVBtnRadErgCtrlHeadO9DataButtonCnvFeature_A36528 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1870:
			this.CpyBtnO9CHTrkTopFunctionButtonBCO_A36636 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_187D:
			this.CpyBtnTopFunctionBtnCnvChannel_A36943 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_188A:
			this.CHO9PASirenButtonsFeature_A41540_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1897:
			this.TopFunctionBtnTrkZone_A36944 = (global::AcpUI.AcpComboBox)target;
			this.TopFunctionBtnTrkZone_A36944.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_18BB:
			this.ExpanderControlHeadO9Labtool = (global::AcpUI.AcpExpander)target;
			return;
			IL_18C8:
			this.CHO9TrkTopFunctionButtonLabelLine2_A36651_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_18D5:
			this.RadErgCtrlHeadO9DirLightBarBCO_A36559Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_18E2:
			this.RTDBtnRadErgCtrlHeadO9DirLightBarIndex_A36601 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_18EF:
			this.ExpanderControlHeadO9General = (global::AcpUI.AcpExpander)target;
			return;
			IL_18FC:
			this.CHO9BottomFunctionButtonName_A36657 = (global::AcpUI.AcpLabel)target;
			this.CHO9BottomFunctionButtonName_A36657.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1920:
			this.RTDBtnTopFunctionBtnTrkChannel_A36945 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_192D:
			this.CHO9CnvTopFunctionButtonLabelLine1_A36626Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_193A:
			this.ExpanderControlHeadO9RelayPatternBCOListListTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1947:
			this.ExpanderControlHeadO9BottomFunctionProgrammableButtonTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1954:
			this.CpyBtnCHO9EmergencyButtonName_A36680 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1961:
			this.CHO9CnvTopFunctionButtonLabelLine1_A36626 = (global::AcpUI.AcpTextBox)target;
			this.CHO9CnvTopFunctionButtonLabelLine1_A36626.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1985:
			this.CpyBtnO9CHCnvTopFunctionButtonIndex_A36634 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1992:
			this.CHO9BottomFunctionButtonName_A36657Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_199F:
			this.RdEgoO9DirLtbarPatternBcoListBco_A36661Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_19AC:
			this.CVBtnCHO9BottomFunctionButtonFeature_A36826 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_19B9:
			this.CVBtnCHO9PursuitKnobIndex_A36685 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_19C6:
			this.RdEgoO9DirLtbarPatternBcoListIndex_A36707 = (global::AcpUI.AcpComboBox)target;
			this.RdEgoO9DirLtbarPatternBcoListIndex_A36707.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_19EA:
			this.gridExpanderControlHeadO9ConsolidatedActionBCOListTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_19F7:
			this.CHO9BottomFunctionButtonBCO_A36660Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1A04:
			this.CHO9PursuitKnobTertiaryIndex_A37025_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1A11:
			this.CVBtnO9CHTrkTopFunctionButtonStsMsgIndex_A36782 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1A1E:
			this.CVBtnRadErgCtrlHeadO9DataButtonTrkFeature_A36526 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1A2B:
			this.O9CHTrkTopFunctionButtonBCO_A36636_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1A38:
			this.CHO9BottomFunctionButtonBCO_A36827Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1A45:
			this.gridExpanderControlHeadO9DirectionalButtonsListSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_1A52:
			this.LblTopFunctionBtnTrkChannel_A36945 = (global::AcpUI.AcpLabel)target;
			this.LblTopFunctionBtnTrkChannel_A36945.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1A76:
			this.RadErgCtrlHeadO9DataButtonCnvBCO_A36529_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1A83:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_1A90:
			this.CVBtnCHO9PASirenButtonsName_A41537 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1A9D:
			this.CHO9BottomFunctionButtonBCO_A36660 = (global::AcpUI.AcpComboBox)target;
			this.CHO9BottomFunctionButtonBCO_A36660.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1AC1:
			this.CpyBtnCHO9CnvTopFunctionButtonLabelLine2_A36627 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1ACE:
			this.LblRadErgoControlO9NaviControlFeature_A41371 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoControlO9NaviControlFeature_A41371.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1AF2:
			this.CHO9CnvTopFunctionButtonLabelLine2_A36627 = (global::AcpUI.AcpTextBox)target;
			this.CHO9CnvTopFunctionButtonLabelLine2_A36627.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1B16:
			this.LblCHO9TrkTopFunctionButtonLabelLine2_A36651 = (global::AcpUI.AcpLabel)target;
			this.LblCHO9TrkTopFunctionButtonLabelLine2_A36651.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1B3A:
			this.LblCHO9BottomFunctionButtonName_A36657 = (global::AcpUI.AcpLabel)target;
			this.LblCHO9BottomFunctionButtonName_A36657.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1B5E:
			this.CHO9PursuitKnobSecondaryIndex_A36823 = (global::AcpUI.AcpComboBox)target;
			this.CHO9PursuitKnobSecondaryIndex_A36823.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1B82:
			this.O9CHTrkTopFunctionButtonIndex_A36639_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1B8F:
			this.TopFunctionBtnTrkChannel_A36945_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1B9C:
			this.CpyBtnCHO9PASirenButtonsFeature_A41540 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1BA9:
			this.CHO9PursuitKnobIndex_A36685Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1BB6:
			this.RTDBtnCHO9CnvTopFunctionButtonLabelLine1_A36626 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1BC3:
			this.O9CHTrkTopFunctionButtonStsMsgIndex_A36782_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1BD0:
			this.ExpanderControlHeadO9TopFunctionProgrammableButtonGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_1BDD:
			this.RadErgCtrlHeadO9DirLightBarBCO_A36559 = (global::AcpUI.AcpComboBox)target;
			this.RadErgCtrlHeadO9DirLightBarBCO_A36559.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1C01:
			this.RadErgCtrlHeadO9DataButtonCnvBCO_A36529 = (global::AcpUI.AcpComboBox)target;
			this.RadErgCtrlHeadO9DataButtonCnvBCO_A36529.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1C25:
			this.RadErgCtrlHeadO9DirLightBarBCO_A36559_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1C32:
			num = (short)1570570240;
			short num3 = num;
			this.RTDBtnO9CHTrkTopFunctionButtonBCO_A36636 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1C68:
			this.CVBtnCHO9BottomFunctionButtonBCO_A36660 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1C75:
			this.gridExpanderControlHeadO9PASirenButtonsListSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_1C82:
			this.ExpanderControlHeadO9BottomFunctionProgrammableButtonTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_1C8F:
			this.RTDBtnCHO9PursuitKnobAction_A36684 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1C9C:
			this.CVBtnCHO9BottomFunctionButtonName_A36657 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1CA9:
			this.CHO9DataButtonConvIndex_A41414Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1CB6:
			this.CVBtnRadErgoControlO9ACBCOListIndex_A36668 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1CC3:
			this.LblO9CHTrkTopFunctionButtonFeature_A36637 = (global::AcpUI.AcpLabel)target;
			this.LblO9CHTrkTopFunctionButtonFeature_A36637.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1CE7:
			this.ExpanderControlHeadO9O9Grid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_1CF4:
			this.CVBtnO9CHTrkTopFunctionButtonBCO_A36636 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1D01:
			this.ExpanderControlHeadO9PASirenButtonsListSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1D0E:
			this.CnvTopFunctionButtonBCO_A36628Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1D1B:
			this.HLinkResponseSelector = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkResponseSelector.Click += this.HLinkClick;
			return;
			IL_1D3F:
			this.O9CHCnvTopFunctionButtonIndex_A36634Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1D4C:
			this.CHO9TopFunctionButton_A36618_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1D59:
			this.HLinkBottomFunctionProgrammableButton = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkBottomFunctionProgrammableButton.Click += this.HLinkClick;
			return;
			IL_1D7D:
			this.RTDBtnCHO9BottomFunctionButtonBCO_A36827 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1D8A:
			this.LblCHO9PASirenButtonsName_A41537 = (global::AcpUI.AcpLabel)target;
			this.LblCHO9PASirenButtonsName_A41537.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1DAE:
			this.LblO9CHCnvTopFunctionButtonStsMsgIndex_A36781 = (global::AcpUI.AcpLabel)target;
			this.LblO9CHCnvTopFunctionButtonStsMsgIndex_A36781.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1DD2:
			this.myO9GraphicView = (global::ControlHeadGraphicView.O9GraphicView)target;
			return;
			IL_1DDF:
			this.LblCHO9EmergencyButtonFeature_A36682 = (global::AcpUI.AcpLabel)target;
			this.LblCHO9EmergencyButtonFeature_A36682.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1E03:
			this.O9CHCnvTopFunctionButtonFeature_A36629_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1E10:
			this.O9CHCnvTopFunctionButtonIndex_A36634 = (global::AcpUI.AcpComboBox)target;
			this.O9CHCnvTopFunctionButtonIndex_A36634.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1E34:
			this.CVBtnTopFunctionBtnCnvZone_A36942 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1E41:
			this.CHO9BottomFunctionButtonFeature_A36664 = (global::AcpUI.AcpComboBox)target;
			this.CHO9BottomFunctionButtonFeature_A36664.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1E65:
			this.RTDBtnCHO9EmergencyButtonName_A36680 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1E72:
			this.LblRadErgoControlO9NaviControlName_A41370 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoControlO9NaviControlName_A41370.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1E96:
			this.CVBtnCHO9TopFunctionButton_A36618 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1EA3:
			this.RadErgCtrlHeadO9DataButtonTrkBCO_A36527 = (global::AcpUI.AcpComboBox)target;
			this.RadErgCtrlHeadO9DataButtonTrkBCO_A36527.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1EC7:
			this.RecNavToolbarExpanderControlHeadO9BottomFunctionButtonBCOList = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderControlHeadO9BottomFunctionButtonBCOList.ModeClick += this.OnModeClick;
			return;
			IL_1EEB:
			this.CHO9PursuitKnobMode_A36683_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1EF8:
			this.ExpanderControlHeadO9ConsolidatedActionBCOListTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1F05:
			this.HLinkControlHeadO9Data = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkControlHeadO9Data.Click += this.HLinkClick;
			return;
			IL_1F29:
			this.CHO9EmergencyButtonName_A36680 = (global::AcpUI.AcpLabel)target;
			this.CHO9EmergencyButtonName_A36680.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1F4D:
			this.CHO9PursuitKnobIndex_A36685 = (global::AcpUI.AcpComboBox)target;
			this.CHO9PursuitKnobIndex_A36685.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1F71:
			this.O9CHTrkTopFunctionButtonFeature_A36637_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1F7E:
			this.RecNavToolbarExpanderControlHeadO9TopFunctionProgrammableButtonList = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderControlHeadO9TopFunctionProgrammableButtonList.ModeClick += this.OnModeClick;
			return;
			IL_1FA2:
			this.CpyBtnRadErgoControlO9NaviControlName_A41370 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1FAF:
			num = (short)776945317;
			short num4 = num;
			num = (short)2000633509;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_2504:
				this.CpyBtnCHO9BottomFunctionButtonBCO_A36827 = (global::AcpUI.AcpCopyButton)target;
				return;
			default:
				num = (short)38535168;
				if (num != 0)
				{
				}
				this.CVBtnRdEgoO9DirLtbarPatternBcoListIndex_A36707 = (global::AcpUI.AcpCustomViewCheckBox)target;
				return;
			}
			IL_2006:
			this.ExpanderControlHeadO9PASirenButtonsGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_2013:
			this.CpyBtnO9CHTrkTopFunctionButtonStsMsgIndex_A36782 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2020:
			this.CHO9BottomFunctionButtonBCO_A36827_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_202D:
			this.CVBtnTopFunctionBtnTrkChannel_A36945 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_203A:
			this.RTDBtnRadErgCtrlHeadO9DataButtonTrkBCO_A36527 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2047:
			this.RTDBtnCHO9BottomFunctionButtonIndex_A36665 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2054:
			this.ExpanderControlHeadO9LabtoolGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_2061:
			this.CHO9PASirenButtonsName_A41537 = (global::AcpUI.AcpLabel)target;
			this.CHO9PASirenButtonsName_A41537.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2085:
			this.CHO9TopFunctionButton_A36618Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2092:
			this.CHO9EmergencyButtonName_A36680_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_209F:
			this.CnvTopFunctionButtonBCO_A36628_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_20AC:
			this.LblCHO9CnvTopFunctionButtonLabelLine1_A36626 = (global::AcpUI.AcpLabel)target;
			this.LblCHO9CnvTopFunctionButtonLabelLine1_A36626.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_20D0:
			this.RTDBtnRadErgoControlO9NaviControlFeature_A41371 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_20DD:
			this.RTDBtnRdEgoO9DirLtbarPatternBcoListIndex_A36707 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_20EA:
			this.ExpanderControlHeadO9DirectionalButtonsGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_20F7:
			this.LblTopFunctionBtnCnvZone_A36942 = (global::AcpUI.AcpLabel)target;
			this.LblTopFunctionBtnCnvZone_A36942.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_211B:
			this.CHO9DataButtonTrkIndex_A41416Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2128:
			this.LblO9CHTrkTopFunctionButtonBCO_A36636 = (global::AcpUI.AcpLabel)target;
			this.LblO9CHTrkTopFunctionButtonBCO_A36636.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_214C:
			this.CpyBtnRadErgCtrlHeadO9DataButtonCnvBCO_A36529 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2159:
			this.CHO9EmergencyButtonFeature_A36682Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2166:
			this.CpyBtnTopFunctionBtnTrkZone_A36944 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2173:
			this.CHO9CnvTopFunctionButtonLabelLine2_A36627Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2180:
			this.CHO9PursuitKnobAction_A36684 = (global::AcpUI.AcpComboBox)target;
			this.CHO9PursuitKnobAction_A36684.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_21A4:
			this.O9CHCnvTopFunctionButtonStsMsgIndex_A36781_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_21B1:
			this.CVBtnCHO9EmergencyButtonFeature_A36682 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_21BE:
			this.RadErgoControlO9ACBCOListIndex_A36668Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_21CB:
			this.RTDBtnRadErgoControlO9NaviControlName_A41370 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_21D8:
			this.TopFunctionBtnCnvZone_A36942Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_21E5:
			this.CHO9BottomFunctionButtonFeature_A36826_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_21F2:
			this.CHO9PASirenButtonsBCO_A41538_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_21FF:
			this.CHO9BottomFunctionButtonFeature_A36826Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_220C:
			this.CHO9PASirenButtonsBCO_A41538 = (global::AcpUI.AcpComboBox)target;
			this.CHO9PASirenButtonsBCO_A41538.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2230:
			this.gridExpanderControlHeadO9O9SRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_223D:
			this.ExpanderControlHeadO9BottomFunctionButtonBCOListTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_224A:
			this.RTDBtnCHO9PursuitKnobIndex_A36685 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2257:
			this.ExpanderControlHeadO9ResponseSelectorList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_2264:
			this.RadErgCtrlHeadO9DataButtonCnvFeature_A36528_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_2271:
			this.gridExpanderControlHeadO9RelayPatternBCOListListSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_227E:
			this.RadErgCtrlHeadO9DataButtonName_A36523_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_228B:
			this.CpyBtnRdEgoO9DirLtbarPatternBcoListIndex_A36707 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2298:
			this.RecNavToolbarExpanderControlHeadO9ResponseSelectorList = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderControlHeadO9ResponseSelectorList.ModeClick += this.OnModeClick;
			return;
			IL_22BC:
			this.O9CHCnvTopFunctionButtonFeature_A36629Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_22C9:
			this.LblCHO9PursuitKnobIndex_A36685 = (global::AcpUI.AcpLabel)target;
			this.LblCHO9PursuitKnobIndex_A36685.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_22ED:
			this.CpyBtnRadErgCtrlHeadO9DataButtonTrkFeature_A36526 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_22FA:
			this.ExpanderControlHeadO9O9NavigationControlsTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_2307:
			this.ExpanderControlHeadO9DirectionalButtonsList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_2314:
			this.CpyBtnCHO9PursuitKnobIndex_A36685 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2321:
			this.HLinkPASirenButtons = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkPASirenButtons.Click += this.HLinkClick;
			return;
			IL_2345:
			this.LblTopFunctionBtnCnvChannel_A36943 = (global::AcpUI.AcpLabel)target;
			this.LblTopFunctionBtnCnvChannel_A36943.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2369:
			this.LblRadErgCtrlHeadO9DirLightBarFeature_A36597 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgCtrlHeadO9DirLightBarFeature_A36597.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_238D:
			this.CVBtnO9CHCnvTopFunctionButtonStsMsgIndex_A36781 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_239A:
			this.RadErgoControlO9ACBCOListBco_A36666 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoControlO9ACBCOListBco_A36666.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_23BE:
			this.LblCHO9EmergencyButtonBCO_A36681 = (global::AcpUI.AcpLabel)target;
			this.LblCHO9EmergencyButtonBCO_A36681.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_23E2:
			this.RdEgoO9DirLtbarPatternBcoListIndex_A36707Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_23EF:
			this.CpyBtnTopFunctionBtnCnvZone_A36942 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_23FC:
			this.RTDBtnO9CHTrkTopFunctionButtonIndex_A36639 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2409:
			this.RadErgoControlO9ACBCOListIndex_A36668 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoControlO9ACBCOListIndex_A36668.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_242D:
			this.CpyBtnRadErgCtrlHeadO9DirLightBarName_A36558 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_243A:
			this.CHO9TrkTopFunctionButtonLabelLine1_A36650Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2447:
			this.CVBtnCnvTopFunctionButtonBCO_A36628 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2454:
			this.CVBtnCHO9PursuitKnobAction_A36684 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2461:
			this.LblCHO9PursuitKnobAction_A36684 = (global::AcpUI.AcpLabel)target;
			this.LblCHO9PursuitKnobAction_A36684.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2485:
			this.LblRdEgoO9DirLtbarPatternBcoListBco_A36661 = (global::AcpUI.AcpLabel)target;
			this.LblRdEgoO9DirLtbarPatternBcoListBco_A36661.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_24A9:
			this.CpyBtnCHO9BottomFunctionButtonBCO_A36660 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_24B6:
			this.ExpanderControlHeadO9O9TableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_24C3:
			num = (short)1255866369;
			if (num != 0)
			{
			}
			this.ExpanderControlHeadO9BottomFunctionProgrammableButtonTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_24F7:
			this.CVBtnRadErgCtrlHeadO9DataButtonTrkBCO_A36527 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2511:
			this.RTDBtnRadErgCtrlHeadO9DataButtonCnvFeature_A36528 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_251E:
			this.LblCHO9EmergencyButtonName_A36680 = (global::AcpUI.AcpLabel)target;
			this.LblCHO9EmergencyButtonName_A36680.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2542:
			this.LblRadErgCtrlHeadO9DataButtonTrkBCO_A36527 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgCtrlHeadO9DataButtonTrkBCO_A36527.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2566:
			this.RecNavToolbarExpanderControlHeadO9BottomFunctionProgrammableButtonTable = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderControlHeadO9BottomFunctionProgrammableButtonTable.ModeClick += this.OnModeClick;
			return;
			IL_258A:
			this.ExpanderControlHeadO9TopFunctionProgrammableButtonListTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_2597:
			this.CHO9TrkTopFunctionButtonLabelLine2_A36651 = (global::AcpUI.AcpTextBox)target;
			this.CHO9TrkTopFunctionButtonLabelLine2_A36651.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_25BB:
			this.CHO9BottomFunctionButtonIndex_A36665Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_25C8:
			this.ExpanderControlHeadO9O9DataButton = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_25D5:
			this.RTDBtnRadErgCtrlHeadO9DirLightBarBCO_A36559 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_25E2:
			this.TopFunctionBtnCnvChannel_A36943 = (global::AcpUI.AcpComboBox)target;
			this.TopFunctionBtnCnvChannel_A36943.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2606:
			this.CVBtnCHO9TrkTopFunctionButtonLabelLine2_A36651 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2613:
			this.CVBtnTopFunctionBtnTrkZone_A36944 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2620:
			this.RTDBtnRadErgCtrlHeadO9DataButtonTrkFeature_A36526 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_262D:
			this.RadErgoControlO9NaviControlName_A41370 = (global::AcpUI.AcpLabel)target;
			this.RadErgoControlO9NaviControlName_A41370.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2651:
			this.ExpanderControlHeadO9BottomFunctionButtonBCOList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_265E:
			this.RadErgCtrlHeadO9DataButtonTrkFeature_A36526Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_266B:
			this.O9CHTrkTopFunctionButtonFeature_A36637Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2678:
			this.ExpanderControlHeadO9O9DataButtonGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_2685:
			this.CpyBtnRadErgCtrlHeadO9DirLightBarFeature_A36597 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2692:
			this.CVBtnCHO9DataButtonTrkIndex_A41416 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_269F:
			this.RadErgCtrlHeadO9DirLightBarName_A36558_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_26AC:
			this.CpyBtnRadErgCtrlHeadO9DataButtonCnvFeature_A36528 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_26B9:
			this.RecNavToolbarExpanderControlHeadO9PASirenButtonsList = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderControlHeadO9PASirenButtonsList.ModeClick += this.OnModeClick;
			return;
			IL_26DD:
			this.ExpanderControlHeadO9BottomFunctionProgrammableButtonTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_26EA:
			this.RTDBtnO9CHTrkTopFunctionButtonFeature_A36637 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_26F7:
			this.ExpanderControlHeadO9ConsolidatedActionBCOListTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_2704:
			this.CVBtnRadErgCtrlHeadO9DataButtonCnvBCO_A36529 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2711:
			this.RadErgoControlO9NaviControlFeature_A41371 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoControlO9NaviControlFeature_A41371.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2735:
			this.ExpanderControlHeadO9ResponseSelectorGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_2742:
			this.CHO9EmergencyButtonBCO_A36681_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_274F:
			this.LblCHO9DataButtonConvIndex_A41414 = (global::AcpUI.AcpLabel)target;
			this.LblCHO9DataButtonConvIndex_A41414.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2773:
			this.TopFunctionBtnTrkChannel_A36945 = (global::AcpUI.AcpComboBox)target;
			this.TopFunctionBtnTrkChannel_A36945.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2797:
			this.CHO9BottomFunctionButtonIndex_A36665_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_27A4:
			this.CVBtnRadErgCtrlHeadO9DirLightBarBCO_A36559 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_27B1:
			this.RTDBtnRadErgoControlO9ACBCOListBco_A36666 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_27BE:
			this.CVBtnCHO9CnvTopFunctionButtonLabelLine2_A36627 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_27CB:
			this.ExpanderControlHeadO9ResponseSelectorListTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_27D8:
			this.RecNavToolbarExpanderControlHeadO9O9NavigationControlsTable = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderControlHeadO9O9NavigationControlsTable.ModeClick += this.OnModeClick;
			return;
			IL_27FC:
			this.CHO9PursuitKnobSecondaryIndex_A36823Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2809:
			this.CHO9PASirenButtonsName_A41537_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_2816:
			this.LblRadErgCtrlHeadO9DataButtonTrkFeature_A36526 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgCtrlHeadO9DataButtonTrkFeature_A36526.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_283A:
			this.RadErgCtrlHeadO9DataButtonTrkFeature_A36526_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_2847:
			this.RTDBtnRdEgoO9DirLtbarPatternBcoListBco_A36661 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2854:
			this.CpyBtnCHO9PursuitKnobMode_A36683 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2861:
			this.LblO9CHCnvTopFunctionButtonFeature_A36629 = (global::AcpUI.AcpLabel)target;
			this.LblO9CHCnvTopFunctionButtonFeature_A36629.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2885:
			this.CpyBtnRadErgoControlO9NaviControlFeature_A41371 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2892:
			this.CVBtnCHO9EmergencyButtonName_A36680 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_289F:
			this.ExpanderControlHeadO9RelayPatternBCOList = (global::AcpUI.AcpExpander)target;
			return;
			IL_28AC:
			this.CVBtnRadErgCtrlHeadO9DirLightBarName_A36558 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_28B9:
			this.CHO9BottomFunctionButtonFeature_A36664Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_28C6:
			this.CHO9EmergencyButtonFeature_A36682 = (global::AcpUI.AcpComboBox)target;
			this.CHO9EmergencyButtonFeature_A36682.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_28EA:
			this.CVBtnRadErgoControlO9NaviControlName_A41370 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_28F7:
			this.RadErgoControlO9ACBCOListIndex_A36668_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_2904:
			this.ExpanderControlHeadO9BottomFunctionButtonBCOListSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_2911:
			this.CVBtnTopFunctionBtnCnvChannel_A36943 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_291E:
			this.CHO9BottomFunctionButtonFeature_A36826 = (global::AcpUI.AcpComboBox)target;
			this.CHO9BottomFunctionButtonFeature_A36826.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2942:
			this.TopFunctionBtnCnvChannel_A36943Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_294F:
			this.RadErgCtrlHeadO9DirLightBarIndex_A36601Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_295C:
			this.HLinkLabtool = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkLabtool.Click += this.HLinkClick;
			return;
			IL_2980:
			this.CHO9BottomFunctionButtonBCO_A36660_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_298D:
			this.ExpanderControlHeadO9ControlHeadO9Data = (global::AcpUI.AcpExpander)target;
			return;
			IL_299A:
			this.CpyBtnCHO9PursuitKnobSecondaryIndex_A36823 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_29A7:
			this.CHO9PursuitKnobTertiaryIndex_A37025 = (global::AcpUI.AcpComboBox)target;
			this.CHO9PursuitKnobTertiaryIndex_A37025.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_29CB:
			this.CHO9PursuitKnobMode_A36683Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_29D8:
			this.CpyBtnCHO9EmergencyButtonBCO_A36681 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_29E5:
			this.ExpanderControlHeadO9O9NavigationControlsTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_29F2:
			this.RadErgoControlO9NaviControlName_A41370Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_29FF:
			this.CVBtnCHO9BottomFunctionButtonFeature_A36664 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2A0C:
			this.HLinkTopFunctionProgrammableButton = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkTopFunctionProgrammableButton.Click += this.HLinkClick;
			return;
			IL_2A30:
			this.RadErgCtrlHeadO9DirLightBarName_A36558Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2A3D:
			this.ExpanderControlHeadO9RelayPatternBCOListGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_2A4A:
			this.O9CHTrkTopFunctionButtonBCO_A36636Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2A57:
			this.O9CHTrkTopFunctionButtonIndex_A36639Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2A64:
			this.ExpanderControlHeadO9O9NavigationControlsExpanderGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_2A71:
			this.CVBtnRadErgoControlO9ACBCOListBco_A36666 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2A7E:
			this.LblCHO9TopFunctionButton_A36618 = (global::AcpUI.AcpLabel)target;
			this.LblCHO9TopFunctionButton_A36618.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2AA2:
			this.CpyBtnCHO9DataButtonTrkIndex_A41416 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2AAF:
			this.RTDBtnCHO9EmergencyButtonFeature_A36682 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2ABC:
			this.RecNavToolbarExpanderControlHeadO9O9 = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderControlHeadO9O9.ModeClick += this.OnModeClick;
			return;
			IL_2AE0:
			this.CHO9TrkTopFunctionButtonLabelLine2_A36651Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2AED:
			this.RadErgCtrlHeadO9DirLightBarFeature_A36597Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2AFA:
			this.CpyBtnCHO9TrkTopFunctionButtonLabelLine2_A36651 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2B07:
			this.RadErgCtrlHeadO9DataButtonTrkBCO_A36527Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2B14:
			this.ExpanderControlHeadO9ConsolidatedActionBCOListTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_2B21:
			this.ExpanderControlHeadO9ConsolidatedActionBCOListTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_2B2E:
			this.CHO9DataButtonConvIndex_A41414 = (global::AcpUI.AcpComboBox)target;
			this.CHO9DataButtonConvIndex_A41414.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2B52:
			this.RTDBtnCHO9BottomFunctionButtonFeature_A36664 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2B5F:
			this.CnvTopFunctionButtonBCO_A36628 = (global::AcpUI.AcpComboBox)target;
			this.CnvTopFunctionButtonBCO_A36628.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2B83:
			this.CHO9DataButtonConvIndex_A41414_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_2B90:
			this.RecNavToolbarExpanderControlHeadO9ConsolidatedActionBCOListTable = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderControlHeadO9ConsolidatedActionBCOListTable.ModeClick += this.OnModeClick;
			return;
			IL_2BB4:
			this.ExpanderControlHeadO9DirectionalButtonsListGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_2BC1:
			this.HLinkGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkGeneral.Click += this.HLinkClick;
			return;
			IL_2BE5:
			this.b = true;
		}

		// Token: 0x060081A2 RID: 33186 RVA: 0x0078A3EC File Offset: 0x007885EC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
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
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
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
				((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 13:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 14:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 15:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 16:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 17:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 18:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 19:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 20:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 21:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 22:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 23:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 24:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 25:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 26:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 27:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 28:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 29:
				((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 30:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 31:
			{
				short num = (short)1459545372;
				short num2 = num;
				num = (short)997385500;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1835204608;
					if (num != 0)
					{
					}
					((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				}
				break;
			}
			case 32:
			{
				short num = (short)601161728;
				short num3 = num;
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			case 33:
				((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 34:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 35:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 36:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 37:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 38:
				((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 39:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 40:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 41:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 42:
				((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 43:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 44:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 45:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 46:
				break;
			case 47:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 48:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 49:
				((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 50:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 51:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 52:
			{
				short num = (short)236126209;
				if (num != 0)
				{
				}
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			default:
				return;
			}
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x040039D6 RID: 14806
		private bool a;

		// Token: 0x040039D7 RID: 14807
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x040039D8 RID: 14808
		internal global::System.Windows.Documents.Hyperlink HLinkControlHeadO9GraphicalView;

		// Token: 0x040039D9 RID: 14809
		internal global::System.Windows.Documents.Hyperlink HLinkGeneral;

		// Token: 0x040039DA RID: 14810
		internal global::System.Windows.Documents.Hyperlink HLinkControlHeadO9Data;

		// Token: 0x040039DB RID: 14811
		internal global::System.Windows.Documents.Hyperlink HLinkTopFunctionProgrammableButton;

		// Token: 0x040039DC RID: 14812
		internal global::System.Windows.Documents.Hyperlink HLinkBottomFunctionProgrammableButton;

		// Token: 0x040039DD RID: 14813
		internal global::System.Windows.Documents.Hyperlink HLinkResponseSelector;

		// Token: 0x040039DE RID: 14814
		internal global::System.Windows.Documents.Hyperlink HLinkDirectionalButtons;

		// Token: 0x040039DF RID: 14815
		internal global::System.Windows.Documents.Hyperlink HLinkPASirenButtons;

		// Token: 0x040039E0 RID: 14816
		internal global::System.Windows.Documents.Hyperlink HLinkRelayPatternBCOList;

		// Token: 0x040039E1 RID: 14817
		internal global::System.Windows.Documents.Hyperlink HLinkConsolidatedActionBCOList;

		// Token: 0x040039E2 RID: 14818
		internal global::System.Windows.Documents.Hyperlink HLinkO9NavigationControlsExpander;

		// Token: 0x040039E3 RID: 14819
		internal global::System.Windows.Documents.Hyperlink HLinkLabtool;

		// Token: 0x040039E4 RID: 14820
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x040039E5 RID: 14821
		internal global::AcpUI.AcpExpander ExpanderControlHeadO9GraphicalView;

		// Token: 0x040039E6 RID: 14822
		internal global::ControlHeadGraphicView.O9GraphicView myO9GraphicView;

		// Token: 0x040039E7 RID: 14823
		internal global::AcpUI.AcpExpander ExpanderControlHeadO9General;

		// Token: 0x040039E8 RID: 14824
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderControlHeadO9O9;

		// Token: 0x040039E9 RID: 14825
		internal global::System.Windows.Controls.Grid ExpanderControlHeadO9GeneralGrid;

		// Token: 0x040039EA RID: 14826
		internal global::System.Windows.Controls.Grid ExpanderControlHeadO9O9Grid;

		// Token: 0x040039EB RID: 14827
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadO9O9TableView;

		// Token: 0x040039EC RID: 14828
		internal global::AcpUI.AcpXamDataPresenter ExpanderControlHeadO9O9;

		// Token: 0x040039ED RID: 14829
		internal global::Infragistics.Windows.DataPresenter.UnboundField CHO9EmergencyButtonName_A36680_Col;

		// Token: 0x040039EE RID: 14830
		internal global::Infragistics.Windows.DataPresenter.UnboundField CHO9EmergencyButtonBCO_A36681_Col;

		// Token: 0x040039EF RID: 14831
		internal global::Infragistics.Windows.DataPresenter.UnboundField CHO9EmergencyButtonFeature_A36682_Col;

		// Token: 0x040039F0 RID: 14832
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadO9O9SRecView;

		// Token: 0x040039F1 RID: 14833
		internal global::System.Windows.Controls.Grid gridExpanderControlHeadO9O9SRecView;

		// Token: 0x040039F2 RID: 14834
		internal global::AcpUI.AcpLabel CHO9EmergencyButtonName_A36680;

		// Token: 0x040039F3 RID: 14835
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCHO9EmergencyButtonName_A36680;

		// Token: 0x040039F4 RID: 14836
		internal global::AcpUI.AcpLabel LblCHO9EmergencyButtonName_A36680;

		// Token: 0x040039F5 RID: 14837
		internal global::AcpUI.AcpRtdButton RTDBtnCHO9EmergencyButtonName_A36680;

		// Token: 0x040039F6 RID: 14838
		internal global::AcpUI.AcpCopyButton CpyBtnCHO9EmergencyButtonName_A36680;

		// Token: 0x040039F7 RID: 14839
		internal global::AcpUI.AcpLabel CHO9EmergencyButtonName_A36680Comp;

		// Token: 0x040039F8 RID: 14840
		internal global::AcpUI.AcpComboBox CHO9EmergencyButtonBCO_A36681;

		// Token: 0x040039F9 RID: 14841
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCHO9EmergencyButtonBCO_A36681;

		// Token: 0x040039FA RID: 14842
		internal global::AcpUI.AcpLabel LblCHO9EmergencyButtonBCO_A36681;

		// Token: 0x040039FB RID: 14843
		internal global::AcpUI.AcpRtdButton RTDBtnCHO9EmergencyButtonBCO_A36681;

		// Token: 0x040039FC RID: 14844
		internal global::AcpUI.AcpCopyButton CpyBtnCHO9EmergencyButtonBCO_A36681;

		// Token: 0x040039FD RID: 14845
		internal global::AcpUI.AcpLabel CHO9EmergencyButtonBCO_A36681Comp;

		// Token: 0x040039FE RID: 14846
		internal global::AcpUI.AcpComboBox CHO9EmergencyButtonFeature_A36682;

		// Token: 0x040039FF RID: 14847
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCHO9EmergencyButtonFeature_A36682;

		// Token: 0x04003A00 RID: 14848
		internal global::AcpUI.AcpLabel LblCHO9EmergencyButtonFeature_A36682;

		// Token: 0x04003A01 RID: 14849
		internal global::AcpUI.AcpRtdButton RTDBtnCHO9EmergencyButtonFeature_A36682;

		// Token: 0x04003A02 RID: 14850
		internal global::AcpUI.AcpCopyButton CpyBtnCHO9EmergencyButtonFeature_A36682;

		// Token: 0x04003A03 RID: 14851
		internal global::AcpUI.AcpLabel CHO9EmergencyButtonFeature_A36682Comp;

		// Token: 0x04003A04 RID: 14852
		internal global::AcpUI.AcpExpander ExpanderControlHeadO9ControlHeadO9Data;

		// Token: 0x04003A05 RID: 14853
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderControlHeadO9O9DataButton;

		// Token: 0x04003A06 RID: 14854
		internal global::System.Windows.Controls.Grid ExpanderControlHeadO9ControlHeadO9DataGrid;

		// Token: 0x04003A07 RID: 14855
		internal global::System.Windows.Controls.Grid ExpanderControlHeadO9O9DataButtonGrid;

		// Token: 0x04003A08 RID: 14856
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadO9O9DataButtonTableView;

		// Token: 0x04003A09 RID: 14857
		internal global::AcpUI.AcpXamDataPresenter ExpanderControlHeadO9O9DataButton;

		// Token: 0x04003A0A RID: 14858
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgCtrlHeadO9DataButtonName_A36523_Col;

		// Token: 0x04003A0B RID: 14859
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgCtrlHeadO9DataButtonCnvBCO_A36529_Col;

		// Token: 0x04003A0C RID: 14860
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgCtrlHeadO9DataButtonCnvFeature_A36528_Col;

		// Token: 0x04003A0D RID: 14861
		internal global::Infragistics.Windows.DataPresenter.UnboundField CHO9DataButtonConvIndex_A41414_Col;

		// Token: 0x04003A0E RID: 14862
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgCtrlHeadO9DataButtonTrkBCO_A36527_Col;

		// Token: 0x04003A0F RID: 14863
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgCtrlHeadO9DataButtonTrkFeature_A36526_Col;

		// Token: 0x04003A10 RID: 14864
		internal global::Infragistics.Windows.DataPresenter.UnboundField CHO9DataButtonTrkIndex_A41416_Col;

		// Token: 0x04003A11 RID: 14865
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadO9O9DataButtonSRecView;

		// Token: 0x04003A12 RID: 14866
		internal global::System.Windows.Controls.Grid gridExpanderControlHeadO9O9DataButtonSRecView;

		// Token: 0x04003A13 RID: 14867
		internal global::AcpUI.AcpLabel RadErgCtrlHeadO9DataButtonName_A36523;

		// Token: 0x04003A14 RID: 14868
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgCtrlHeadO9DataButtonName_A36523;

		// Token: 0x04003A15 RID: 14869
		internal global::AcpUI.AcpLabel LblRadErgCtrlHeadO9DataButtonName_A36523;

		// Token: 0x04003A16 RID: 14870
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgCtrlHeadO9DataButtonName_A36523;

		// Token: 0x04003A17 RID: 14871
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgCtrlHeadO9DataButtonName_A36523;

		// Token: 0x04003A18 RID: 14872
		internal global::AcpUI.AcpLabel RadErgCtrlHeadO9DataButtonName_A36523Comp;

		// Token: 0x04003A19 RID: 14873
		internal global::AcpUI.AcpComboBox RadErgCtrlHeadO9DataButtonCnvBCO_A36529;

		// Token: 0x04003A1A RID: 14874
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgCtrlHeadO9DataButtonCnvBCO_A36529;

		// Token: 0x04003A1B RID: 14875
		internal global::AcpUI.AcpLabel LblRadErgCtrlHeadO9DataButtonCnvBCO_A36529;

		// Token: 0x04003A1C RID: 14876
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgCtrlHeadO9DataButtonCnvBCO_A36529;

		// Token: 0x04003A1D RID: 14877
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgCtrlHeadO9DataButtonCnvBCO_A36529;

		// Token: 0x04003A1E RID: 14878
		internal global::AcpUI.AcpLabel RadErgCtrlHeadO9DataButtonCnvBCO_A36529Comp;

		// Token: 0x04003A1F RID: 14879
		internal global::AcpUI.AcpComboBox RadErgCtrlHeadO9DataButtonCnvFeature_A36528;

		// Token: 0x04003A20 RID: 14880
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgCtrlHeadO9DataButtonCnvFeature_A36528;

		// Token: 0x04003A21 RID: 14881
		internal global::AcpUI.AcpLabel LblRadErgCtrlHeadO9DataButtonCnvFeature_A36528;

		// Token: 0x04003A22 RID: 14882
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgCtrlHeadO9DataButtonCnvFeature_A36528;

		// Token: 0x04003A23 RID: 14883
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgCtrlHeadO9DataButtonCnvFeature_A36528;

		// Token: 0x04003A24 RID: 14884
		internal global::AcpUI.AcpLabel RadErgCtrlHeadO9DataButtonCnvFeature_A36528Comp;

		// Token: 0x04003A25 RID: 14885
		internal global::AcpUI.AcpComboBox CHO9DataButtonConvIndex_A41414;

		// Token: 0x04003A26 RID: 14886
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCHO9DataButtonConvIndex_A41414;

		// Token: 0x04003A27 RID: 14887
		internal global::AcpUI.AcpLabel LblCHO9DataButtonConvIndex_A41414;

		// Token: 0x04003A28 RID: 14888
		internal global::AcpUI.AcpRtdButton RTDBtnCHO9DataButtonConvIndex_A41414;

		// Token: 0x04003A29 RID: 14889
		internal global::AcpUI.AcpCopyButton CpyBtnCHO9DataButtonConvIndex_A41414;

		// Token: 0x04003A2A RID: 14890
		internal global::AcpUI.AcpLabel CHO9DataButtonConvIndex_A41414Comp;

		// Token: 0x04003A2B RID: 14891
		internal global::AcpUI.AcpComboBox RadErgCtrlHeadO9DataButtonTrkBCO_A36527;

		// Token: 0x04003A2C RID: 14892
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgCtrlHeadO9DataButtonTrkBCO_A36527;

		// Token: 0x04003A2D RID: 14893
		internal global::AcpUI.AcpLabel LblRadErgCtrlHeadO9DataButtonTrkBCO_A36527;

		// Token: 0x04003A2E RID: 14894
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgCtrlHeadO9DataButtonTrkBCO_A36527;

		// Token: 0x04003A2F RID: 14895
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgCtrlHeadO9DataButtonTrkBCO_A36527;

		// Token: 0x04003A30 RID: 14896
		internal global::AcpUI.AcpLabel RadErgCtrlHeadO9DataButtonTrkBCO_A36527Comp;

		// Token: 0x04003A31 RID: 14897
		internal global::AcpUI.AcpComboBox RadErgCtrlHeadO9DataButtonTrkFeature_A36526;

		// Token: 0x04003A32 RID: 14898
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgCtrlHeadO9DataButtonTrkFeature_A36526;

		// Token: 0x04003A33 RID: 14899
		internal global::AcpUI.AcpLabel LblRadErgCtrlHeadO9DataButtonTrkFeature_A36526;

		// Token: 0x04003A34 RID: 14900
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgCtrlHeadO9DataButtonTrkFeature_A36526;

		// Token: 0x04003A35 RID: 14901
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgCtrlHeadO9DataButtonTrkFeature_A36526;

		// Token: 0x04003A36 RID: 14902
		internal global::AcpUI.AcpLabel RadErgCtrlHeadO9DataButtonTrkFeature_A36526Comp;

		// Token: 0x04003A37 RID: 14903
		internal global::AcpUI.AcpComboBox CHO9DataButtonTrkIndex_A41416;

		// Token: 0x04003A38 RID: 14904
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCHO9DataButtonTrkIndex_A41416;

		// Token: 0x04003A39 RID: 14905
		internal global::AcpUI.AcpLabel LblCHO9DataButtonTrkIndex_A41416;

		// Token: 0x04003A3A RID: 14906
		internal global::AcpUI.AcpRtdButton RTDBtnCHO9DataButtonTrkIndex_A41416;

		// Token: 0x04003A3B RID: 14907
		internal global::AcpUI.AcpCopyButton CpyBtnCHO9DataButtonTrkIndex_A41416;

		// Token: 0x04003A3C RID: 14908
		internal global::AcpUI.AcpLabel CHO9DataButtonTrkIndex_A41416Comp;

		// Token: 0x04003A3D RID: 14909
		internal global::AcpUI.AcpExpander ExpanderControlHeadO9TopFunctionProgrammableButton;

		// Token: 0x04003A3E RID: 14910
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderControlHeadO9TopFunctionProgrammableButtonList;

		// Token: 0x04003A3F RID: 14911
		internal global::System.Windows.Controls.Grid ExpanderControlHeadO9TopFunctionProgrammableButtonGrid;

		// Token: 0x04003A40 RID: 14912
		internal global::System.Windows.Controls.Grid ExpanderControlHeadO9TopFunctionProgrammableButtonListGrid;

		// Token: 0x04003A41 RID: 14913
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadO9TopFunctionProgrammableButtonListTableView;

		// Token: 0x04003A42 RID: 14914
		internal global::AcpUI.AcpXamDataPresenter ExpanderControlHeadO9TopFunctionProgrammableButtonList;

		// Token: 0x04003A43 RID: 14915
		internal global::Infragistics.Windows.DataPresenter.UnboundField CHO9TopFunctionButton_A36618_Col;

		// Token: 0x04003A44 RID: 14916
		internal global::Infragistics.Windows.DataPresenter.UnboundField CHO9CnvTopFunctionButtonLabelLine1_A36626_Col;

		// Token: 0x04003A45 RID: 14917
		internal global::Infragistics.Windows.DataPresenter.UnboundField CHO9CnvTopFunctionButtonLabelLine2_A36627_Col;

		// Token: 0x04003A46 RID: 14918
		internal global::Infragistics.Windows.DataPresenter.UnboundField CnvTopFunctionButtonBCO_A36628_Col;

		// Token: 0x04003A47 RID: 14919
		internal global::Infragistics.Windows.DataPresenter.UnboundField O9CHCnvTopFunctionButtonFeature_A36629_Col;

		// Token: 0x04003A48 RID: 14920
		internal global::Infragistics.Windows.DataPresenter.UnboundField O9CHCnvTopFunctionButtonIndex_A36634_Col;

		// Token: 0x04003A49 RID: 14921
		internal global::Infragistics.Windows.DataPresenter.UnboundField O9CHCnvTopFunctionButtonStsMsgIndex_A36781_Col;

		// Token: 0x04003A4A RID: 14922
		internal global::Infragistics.Windows.DataPresenter.UnboundField TopFunctionBtnCnvZone_A36942_Col;

		// Token: 0x04003A4B RID: 14923
		internal global::Infragistics.Windows.DataPresenter.UnboundField TopFunctionBtnCnvChannel_A36943_Col;

		// Token: 0x04003A4C RID: 14924
		internal global::Infragistics.Windows.DataPresenter.UnboundField CHO9TrkTopFunctionButtonLabelLine1_A36650_Col;

		// Token: 0x04003A4D RID: 14925
		internal global::Infragistics.Windows.DataPresenter.UnboundField CHO9TrkTopFunctionButtonLabelLine2_A36651_Col;

		// Token: 0x04003A4E RID: 14926
		internal global::Infragistics.Windows.DataPresenter.UnboundField O9CHTrkTopFunctionButtonBCO_A36636_Col;

		// Token: 0x04003A4F RID: 14927
		internal global::Infragistics.Windows.DataPresenter.UnboundField O9CHTrkTopFunctionButtonFeature_A36637_Col;

		// Token: 0x04003A50 RID: 14928
		internal global::Infragistics.Windows.DataPresenter.UnboundField O9CHTrkTopFunctionButtonIndex_A36639_Col;

		// Token: 0x04003A51 RID: 14929
		internal global::Infragistics.Windows.DataPresenter.UnboundField O9CHTrkTopFunctionButtonStsMsgIndex_A36782_Col;

		// Token: 0x04003A52 RID: 14930
		internal global::Infragistics.Windows.DataPresenter.UnboundField TopFunctionBtnTrkZone_A36944_Col;

		// Token: 0x04003A53 RID: 14931
		internal global::Infragistics.Windows.DataPresenter.UnboundField TopFunctionBtnTrkChannel_A36945_Col;

		// Token: 0x04003A54 RID: 14932
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadO9TopFunctionProgrammableButtonListSRecView;

		// Token: 0x04003A55 RID: 14933
		internal global::System.Windows.Controls.Grid gridExpanderControlHeadO9TopFunctionProgrammableButtonListSRecView;

		// Token: 0x04003A56 RID: 14934
		internal global::AcpUI.AcpLabel CHO9TopFunctionButton_A36618;

		// Token: 0x04003A57 RID: 14935
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCHO9TopFunctionButton_A36618;

		// Token: 0x04003A58 RID: 14936
		internal global::AcpUI.AcpLabel LblCHO9TopFunctionButton_A36618;

		// Token: 0x04003A59 RID: 14937
		internal global::AcpUI.AcpRtdButton RTDBtnCHO9TopFunctionButton_A36618;

		// Token: 0x04003A5A RID: 14938
		internal global::AcpUI.AcpCopyButton CpyBtnCHO9TopFunctionButton_A36618;

		// Token: 0x04003A5B RID: 14939
		internal global::AcpUI.AcpLabel CHO9TopFunctionButton_A36618Comp;

		// Token: 0x04003A5C RID: 14940
		internal global::AcpUI.AcpTextBox CHO9CnvTopFunctionButtonLabelLine1_A36626;

		// Token: 0x04003A5D RID: 14941
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCHO9CnvTopFunctionButtonLabelLine1_A36626;

		// Token: 0x04003A5E RID: 14942
		internal global::AcpUI.AcpLabel LblCHO9CnvTopFunctionButtonLabelLine1_A36626;

		// Token: 0x04003A5F RID: 14943
		internal global::AcpUI.AcpRtdButton RTDBtnCHO9CnvTopFunctionButtonLabelLine1_A36626;

		// Token: 0x04003A60 RID: 14944
		internal global::AcpUI.AcpCopyButton CpyBtnCHO9CnvTopFunctionButtonLabelLine1_A36626;

		// Token: 0x04003A61 RID: 14945
		internal global::AcpUI.AcpLabel CHO9CnvTopFunctionButtonLabelLine1_A36626Comp;

		// Token: 0x04003A62 RID: 14946
		internal global::AcpUI.AcpTextBox CHO9CnvTopFunctionButtonLabelLine2_A36627;

		// Token: 0x04003A63 RID: 14947
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCHO9CnvTopFunctionButtonLabelLine2_A36627;

		// Token: 0x04003A64 RID: 14948
		internal global::AcpUI.AcpLabel LblCHO9CnvTopFunctionButtonLabelLine2_A36627;

		// Token: 0x04003A65 RID: 14949
		internal global::AcpUI.AcpRtdButton RTDBtnCHO9CnvTopFunctionButtonLabelLine2_A36627;

		// Token: 0x04003A66 RID: 14950
		internal global::AcpUI.AcpCopyButton CpyBtnCHO9CnvTopFunctionButtonLabelLine2_A36627;

		// Token: 0x04003A67 RID: 14951
		internal global::AcpUI.AcpLabel CHO9CnvTopFunctionButtonLabelLine2_A36627Comp;

		// Token: 0x04003A68 RID: 14952
		internal global::AcpUI.AcpComboBox CnvTopFunctionButtonBCO_A36628;

		// Token: 0x04003A69 RID: 14953
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvTopFunctionButtonBCO_A36628;

		// Token: 0x04003A6A RID: 14954
		internal global::AcpUI.AcpLabel LblCnvTopFunctionButtonBCO_A36628;

		// Token: 0x04003A6B RID: 14955
		internal global::AcpUI.AcpRtdButton RTDBtnCnvTopFunctionButtonBCO_A36628;

		// Token: 0x04003A6C RID: 14956
		internal global::AcpUI.AcpCopyButton CpyBtnCnvTopFunctionButtonBCO_A36628;

		// Token: 0x04003A6D RID: 14957
		internal global::AcpUI.AcpLabel CnvTopFunctionButtonBCO_A36628Comp;

		// Token: 0x04003A6E RID: 14958
		internal global::AcpUI.AcpComboBox O9CHCnvTopFunctionButtonFeature_A36629;

		// Token: 0x04003A6F RID: 14959
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnO9CHCnvTopFunctionButtonFeature_A36629;

		// Token: 0x04003A70 RID: 14960
		internal global::AcpUI.AcpLabel LblO9CHCnvTopFunctionButtonFeature_A36629;

		// Token: 0x04003A71 RID: 14961
		internal global::AcpUI.AcpRtdButton RTDBtnO9CHCnvTopFunctionButtonFeature_A36629;

		// Token: 0x04003A72 RID: 14962
		internal global::AcpUI.AcpCopyButton CpyBtnO9CHCnvTopFunctionButtonFeature_A36629;

		// Token: 0x04003A73 RID: 14963
		internal global::AcpUI.AcpLabel O9CHCnvTopFunctionButtonFeature_A36629Comp;

		// Token: 0x04003A74 RID: 14964
		internal global::AcpUI.AcpComboBox O9CHCnvTopFunctionButtonIndex_A36634;

		// Token: 0x04003A75 RID: 14965
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnO9CHCnvTopFunctionButtonIndex_A36634;

		// Token: 0x04003A76 RID: 14966
		internal global::AcpUI.AcpLabel LblO9CHCnvTopFunctionButtonIndex_A36634;

		// Token: 0x04003A77 RID: 14967
		internal global::AcpUI.AcpRtdButton RTDBtnO9CHCnvTopFunctionButtonIndex_A36634;

		// Token: 0x04003A78 RID: 14968
		internal global::AcpUI.AcpCopyButton CpyBtnO9CHCnvTopFunctionButtonIndex_A36634;

		// Token: 0x04003A79 RID: 14969
		internal global::AcpUI.AcpLabel O9CHCnvTopFunctionButtonIndex_A36634Comp;

		// Token: 0x04003A7A RID: 14970
		internal global::AcpUI.AcpTextBoxSpinner O9CHCnvTopFunctionButtonStsMsgIndex_A36781;

		// Token: 0x04003A7B RID: 14971
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnO9CHCnvTopFunctionButtonStsMsgIndex_A36781;

		// Token: 0x04003A7C RID: 14972
		internal global::AcpUI.AcpLabel LblO9CHCnvTopFunctionButtonStsMsgIndex_A36781;

		// Token: 0x04003A7D RID: 14973
		internal global::AcpUI.AcpRtdButton RTDBtnO9CHCnvTopFunctionButtonStsMsgIndex_A36781;

		// Token: 0x04003A7E RID: 14974
		internal global::AcpUI.AcpCopyButton CpyBtnO9CHCnvTopFunctionButtonStsMsgIndex_A36781;

		// Token: 0x04003A7F RID: 14975
		internal global::AcpUI.AcpLabel O9CHCnvTopFunctionButtonStsMsgIndex_A36781Comp;

		// Token: 0x04003A80 RID: 14976
		internal global::AcpUI.AcpComboBox TopFunctionBtnCnvZone_A36942;

		// Token: 0x04003A81 RID: 14977
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTopFunctionBtnCnvZone_A36942;

		// Token: 0x04003A82 RID: 14978
		internal global::AcpUI.AcpLabel LblTopFunctionBtnCnvZone_A36942;

		// Token: 0x04003A83 RID: 14979
		internal global::AcpUI.AcpRtdButton RTDBtnTopFunctionBtnCnvZone_A36942;

		// Token: 0x04003A84 RID: 14980
		internal global::AcpUI.AcpCopyButton CpyBtnTopFunctionBtnCnvZone_A36942;

		// Token: 0x04003A85 RID: 14981
		internal global::AcpUI.AcpLabel TopFunctionBtnCnvZone_A36942Comp;

		// Token: 0x04003A86 RID: 14982
		internal global::AcpUI.AcpComboBox TopFunctionBtnCnvChannel_A36943;

		// Token: 0x04003A87 RID: 14983
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTopFunctionBtnCnvChannel_A36943;

		// Token: 0x04003A88 RID: 14984
		internal global::AcpUI.AcpLabel LblTopFunctionBtnCnvChannel_A36943;

		// Token: 0x04003A89 RID: 14985
		internal global::AcpUI.AcpRtdButton RTDBtnTopFunctionBtnCnvChannel_A36943;

		// Token: 0x04003A8A RID: 14986
		internal global::AcpUI.AcpCopyButton CpyBtnTopFunctionBtnCnvChannel_A36943;

		// Token: 0x04003A8B RID: 14987
		internal global::AcpUI.AcpLabel TopFunctionBtnCnvChannel_A36943Comp;

		// Token: 0x04003A8C RID: 14988
		internal global::AcpUI.AcpTextBox CHO9TrkTopFunctionButtonLabelLine1_A36650;

		// Token: 0x04003A8D RID: 14989
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCHO9TrkTopFunctionButtonLabelLine1_A36650;

		// Token: 0x04003A8E RID: 14990
		internal global::AcpUI.AcpLabel LblCHO9TrkTopFunctionButtonLabelLine1_A36650;

		// Token: 0x04003A8F RID: 14991
		internal global::AcpUI.AcpRtdButton RTDBtnCHO9TrkTopFunctionButtonLabelLine1_A36650;

		// Token: 0x04003A90 RID: 14992
		internal global::AcpUI.AcpCopyButton CpyBtnCHO9TrkTopFunctionButtonLabelLine1_A36650;

		// Token: 0x04003A91 RID: 14993
		internal global::AcpUI.AcpLabel CHO9TrkTopFunctionButtonLabelLine1_A36650Comp;

		// Token: 0x04003A92 RID: 14994
		internal global::AcpUI.AcpTextBox CHO9TrkTopFunctionButtonLabelLine2_A36651;

		// Token: 0x04003A93 RID: 14995
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCHO9TrkTopFunctionButtonLabelLine2_A36651;

		// Token: 0x04003A94 RID: 14996
		internal global::AcpUI.AcpLabel LblCHO9TrkTopFunctionButtonLabelLine2_A36651;

		// Token: 0x04003A95 RID: 14997
		internal global::AcpUI.AcpRtdButton RTDBtnCHO9TrkTopFunctionButtonLabelLine2_A36651;

		// Token: 0x04003A96 RID: 14998
		internal global::AcpUI.AcpCopyButton CpyBtnCHO9TrkTopFunctionButtonLabelLine2_A36651;

		// Token: 0x04003A97 RID: 14999
		internal global::AcpUI.AcpLabel CHO9TrkTopFunctionButtonLabelLine2_A36651Comp;

		// Token: 0x04003A98 RID: 15000
		internal global::AcpUI.AcpComboBox O9CHTrkTopFunctionButtonBCO_A36636;

		// Token: 0x04003A99 RID: 15001
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnO9CHTrkTopFunctionButtonBCO_A36636;

		// Token: 0x04003A9A RID: 15002
		internal global::AcpUI.AcpLabel LblO9CHTrkTopFunctionButtonBCO_A36636;

		// Token: 0x04003A9B RID: 15003
		internal global::AcpUI.AcpRtdButton RTDBtnO9CHTrkTopFunctionButtonBCO_A36636;

		// Token: 0x04003A9C RID: 15004
		internal global::AcpUI.AcpCopyButton CpyBtnO9CHTrkTopFunctionButtonBCO_A36636;

		// Token: 0x04003A9D RID: 15005
		internal global::AcpUI.AcpLabel O9CHTrkTopFunctionButtonBCO_A36636Comp;

		// Token: 0x04003A9E RID: 15006
		internal global::AcpUI.AcpComboBox O9CHTrkTopFunctionButtonFeature_A36637;

		// Token: 0x04003A9F RID: 15007
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnO9CHTrkTopFunctionButtonFeature_A36637;

		// Token: 0x04003AA0 RID: 15008
		internal global::AcpUI.AcpLabel LblO9CHTrkTopFunctionButtonFeature_A36637;

		// Token: 0x04003AA1 RID: 15009
		internal global::AcpUI.AcpRtdButton RTDBtnO9CHTrkTopFunctionButtonFeature_A36637;

		// Token: 0x04003AA2 RID: 15010
		internal global::AcpUI.AcpCopyButton CpyBtnO9CHTrkTopFunctionButtonFeature_A36637;

		// Token: 0x04003AA3 RID: 15011
		internal global::AcpUI.AcpLabel O9CHTrkTopFunctionButtonFeature_A36637Comp;

		// Token: 0x04003AA4 RID: 15012
		internal global::AcpUI.AcpTextBoxSpinner O9CHTrkTopFunctionButtonIndex_A36639;

		// Token: 0x04003AA5 RID: 15013
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnO9CHTrkTopFunctionButtonIndex_A36639;

		// Token: 0x04003AA6 RID: 15014
		internal global::AcpUI.AcpLabel LblO9CHTrkTopFunctionButtonIndex_A36639;

		// Token: 0x04003AA7 RID: 15015
		internal global::AcpUI.AcpRtdButton RTDBtnO9CHTrkTopFunctionButtonIndex_A36639;

		// Token: 0x04003AA8 RID: 15016
		internal global::AcpUI.AcpCopyButton CpyBtnO9CHTrkTopFunctionButtonIndex_A36639;

		// Token: 0x04003AA9 RID: 15017
		internal global::AcpUI.AcpLabel O9CHTrkTopFunctionButtonIndex_A36639Comp;

		// Token: 0x04003AAA RID: 15018
		internal global::AcpUI.AcpTextBoxSpinner O9CHTrkTopFunctionButtonStsMsgIndex_A36782;

		// Token: 0x04003AAB RID: 15019
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnO9CHTrkTopFunctionButtonStsMsgIndex_A36782;

		// Token: 0x04003AAC RID: 15020
		internal global::AcpUI.AcpLabel LblO9CHTrkTopFunctionButtonStsMsgIndex_A36782;

		// Token: 0x04003AAD RID: 15021
		internal global::AcpUI.AcpRtdButton RTDBtnO9CHTrkTopFunctionButtonStsMsgIndex_A36782;

		// Token: 0x04003AAE RID: 15022
		internal global::AcpUI.AcpCopyButton CpyBtnO9CHTrkTopFunctionButtonStsMsgIndex_A36782;

		// Token: 0x04003AAF RID: 15023
		internal global::AcpUI.AcpLabel O9CHTrkTopFunctionButtonStsMsgIndex_A36782Comp;

		// Token: 0x04003AB0 RID: 15024
		internal global::AcpUI.AcpComboBox TopFunctionBtnTrkZone_A36944;

		// Token: 0x04003AB1 RID: 15025
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTopFunctionBtnTrkZone_A36944;

		// Token: 0x04003AB2 RID: 15026
		internal global::AcpUI.AcpLabel LblTopFunctionBtnTrkZone_A36944;

		// Token: 0x04003AB3 RID: 15027
		internal global::AcpUI.AcpRtdButton RTDBtnTopFunctionBtnTrkZone_A36944;

		// Token: 0x04003AB4 RID: 15028
		internal global::AcpUI.AcpCopyButton CpyBtnTopFunctionBtnTrkZone_A36944;

		// Token: 0x04003AB5 RID: 15029
		internal global::AcpUI.AcpLabel TopFunctionBtnTrkZone_A36944Comp;

		// Token: 0x04003AB6 RID: 15030
		internal global::AcpUI.AcpComboBox TopFunctionBtnTrkChannel_A36945;

		// Token: 0x04003AB7 RID: 15031
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTopFunctionBtnTrkChannel_A36945;

		// Token: 0x04003AB8 RID: 15032
		internal global::AcpUI.AcpLabel LblTopFunctionBtnTrkChannel_A36945;

		// Token: 0x04003AB9 RID: 15033
		internal global::AcpUI.AcpRtdButton RTDBtnTopFunctionBtnTrkChannel_A36945;

		// Token: 0x04003ABA RID: 15034
		internal global::AcpUI.AcpCopyButton CpyBtnTopFunctionBtnTrkChannel_A36945;

		// Token: 0x04003ABB RID: 15035
		internal global::AcpUI.AcpLabel TopFunctionBtnTrkChannel_A36945Comp;

		// Token: 0x04003ABC RID: 15036
		internal global::AcpUI.AcpExpander ExpanderControlHeadO9BottomFunctionProgrammableButton;

		// Token: 0x04003ABD RID: 15037
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderControlHeadO9BottomFunctionProgrammableButtonTable;

		// Token: 0x04003ABE RID: 15038
		internal global::System.Windows.Controls.Grid ExpanderControlHeadO9BottomFunctionProgrammableButtonGrid;

		// Token: 0x04003ABF RID: 15039
		internal global::System.Windows.Controls.Grid ExpanderControlHeadO9BottomFunctionProgrammableButtonTableGrid;

		// Token: 0x04003AC0 RID: 15040
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadO9BottomFunctionProgrammableButtonTableTableView;

		// Token: 0x04003AC1 RID: 15041
		internal global::AcpUI.AcpXamDataPresenter ExpanderControlHeadO9BottomFunctionProgrammableButtonTable;

		// Token: 0x04003AC2 RID: 15042
		internal global::Infragistics.Windows.DataPresenter.UnboundField CHO9BottomFunctionButtonName_A36657_Col;

		// Token: 0x04003AC3 RID: 15043
		internal global::Infragistics.Windows.DataPresenter.UnboundField CHO9BottomFunctionButtonBCO_A36660_Col;

		// Token: 0x04003AC4 RID: 15044
		internal global::Infragistics.Windows.DataPresenter.UnboundField CHO9BottomFunctionButtonFeature_A36664_Col;

		// Token: 0x04003AC5 RID: 15045
		internal global::Infragistics.Windows.DataPresenter.UnboundField CHO9BottomFunctionButtonIndex_A36665_Col;

		// Token: 0x04003AC6 RID: 15046
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadO9BottomFunctionProgrammableButtonTableSRecView;

		// Token: 0x04003AC7 RID: 15047
		internal global::System.Windows.Controls.Grid gridExpanderControlHeadO9BottomFunctionProgrammableButtonTableSRecView;

		// Token: 0x04003AC8 RID: 15048
		internal global::AcpUI.AcpLabel CHO9BottomFunctionButtonName_A36657;

		// Token: 0x04003AC9 RID: 15049
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCHO9BottomFunctionButtonName_A36657;

		// Token: 0x04003ACA RID: 15050
		internal global::AcpUI.AcpLabel LblCHO9BottomFunctionButtonName_A36657;

		// Token: 0x04003ACB RID: 15051
		internal global::AcpUI.AcpRtdButton RTDBtnCHO9BottomFunctionButtonName_A36657;

		// Token: 0x04003ACC RID: 15052
		internal global::AcpUI.AcpCopyButton CpyBtnCHO9BottomFunctionButtonName_A36657;

		// Token: 0x04003ACD RID: 15053
		internal global::AcpUI.AcpLabel CHO9BottomFunctionButtonName_A36657Comp;

		// Token: 0x04003ACE RID: 15054
		internal global::AcpUI.AcpComboBox CHO9BottomFunctionButtonBCO_A36660;

		// Token: 0x04003ACF RID: 15055
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCHO9BottomFunctionButtonBCO_A36660;

		// Token: 0x04003AD0 RID: 15056
		internal global::AcpUI.AcpLabel LblCHO9BottomFunctionButtonBCO_A36660;

		// Token: 0x04003AD1 RID: 15057
		internal global::AcpUI.AcpRtdButton RTDBtnCHO9BottomFunctionButtonBCO_A36660;

		// Token: 0x04003AD2 RID: 15058
		internal global::AcpUI.AcpCopyButton CpyBtnCHO9BottomFunctionButtonBCO_A36660;

		// Token: 0x04003AD3 RID: 15059
		internal global::AcpUI.AcpLabel CHO9BottomFunctionButtonBCO_A36660Comp;

		// Token: 0x04003AD4 RID: 15060
		internal global::AcpUI.AcpComboBox CHO9BottomFunctionButtonFeature_A36664;

		// Token: 0x04003AD5 RID: 15061
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCHO9BottomFunctionButtonFeature_A36664;

		// Token: 0x04003AD6 RID: 15062
		internal global::AcpUI.AcpLabel LblCHO9BottomFunctionButtonFeature_A36664;

		// Token: 0x04003AD7 RID: 15063
		internal global::AcpUI.AcpRtdButton RTDBtnCHO9BottomFunctionButtonFeature_A36664;

		// Token: 0x04003AD8 RID: 15064
		internal global::AcpUI.AcpCopyButton CpyBtnCHO9BottomFunctionButtonFeature_A36664;

		// Token: 0x04003AD9 RID: 15065
		internal global::AcpUI.AcpLabel CHO9BottomFunctionButtonFeature_A36664Comp;

		// Token: 0x04003ADA RID: 15066
		internal global::AcpUI.AcpComboBox CHO9BottomFunctionButtonIndex_A36665;

		// Token: 0x04003ADB RID: 15067
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCHO9BottomFunctionButtonIndex_A36665;

		// Token: 0x04003ADC RID: 15068
		internal global::AcpUI.AcpLabel LblCHO9BottomFunctionButtonIndex_A36665;

		// Token: 0x04003ADD RID: 15069
		internal global::AcpUI.AcpRtdButton RTDBtnCHO9BottomFunctionButtonIndex_A36665;

		// Token: 0x04003ADE RID: 15070
		internal global::AcpUI.AcpCopyButton CpyBtnCHO9BottomFunctionButtonIndex_A36665;

		// Token: 0x04003ADF RID: 15071
		internal global::AcpUI.AcpLabel CHO9BottomFunctionButtonIndex_A36665Comp;

		// Token: 0x04003AE0 RID: 15072
		internal global::AcpUI.AcpExpander ExpanderControlHeadO9ResponseSelector;

		// Token: 0x04003AE1 RID: 15073
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderControlHeadO9ResponseSelectorList;

		// Token: 0x04003AE2 RID: 15074
		internal global::System.Windows.Controls.Grid ExpanderControlHeadO9ResponseSelectorGrid;

		// Token: 0x04003AE3 RID: 15075
		internal global::System.Windows.Controls.Grid ExpanderControlHeadO9ResponseSelectorListGrid;

		// Token: 0x04003AE4 RID: 15076
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadO9ResponseSelectorListTableView;

		// Token: 0x04003AE5 RID: 15077
		internal global::AcpUI.AcpXamDataPresenter ExpanderControlHeadO9ResponseSelectorList;

		// Token: 0x04003AE6 RID: 15078
		internal global::Infragistics.Windows.DataPresenter.UnboundField CHO9PursuitKnobMode_A36683_Col;

		// Token: 0x04003AE7 RID: 15079
		internal global::Infragistics.Windows.DataPresenter.UnboundField CHO9PursuitKnobAction_A36684_Col;

		// Token: 0x04003AE8 RID: 15080
		internal global::Infragistics.Windows.DataPresenter.UnboundField CHO9PursuitKnobIndex_A36685_Col;

		// Token: 0x04003AE9 RID: 15081
		internal global::Infragistics.Windows.DataPresenter.UnboundField CHO9PursuitKnobSecondaryIndex_A36823_Col;

		// Token: 0x04003AEA RID: 15082
		internal global::Infragistics.Windows.DataPresenter.UnboundField CHO9PursuitKnobTertiaryIndex_A37025_Col;

		// Token: 0x04003AEB RID: 15083
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadO9ResponseSelectorListSRecView;

		// Token: 0x04003AEC RID: 15084
		internal global::System.Windows.Controls.Grid gridExpanderControlHeadO9ResponseSelectorListSRecView;

		// Token: 0x04003AED RID: 15085
		internal global::AcpUI.AcpLabel CHO9PursuitKnobMode_A36683;

		// Token: 0x04003AEE RID: 15086
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCHO9PursuitKnobMode_A36683;

		// Token: 0x04003AEF RID: 15087
		internal global::AcpUI.AcpLabel LblCHO9PursuitKnobMode_A36683;

		// Token: 0x04003AF0 RID: 15088
		internal global::AcpUI.AcpRtdButton RTDBtnCHO9PursuitKnobMode_A36683;

		// Token: 0x04003AF1 RID: 15089
		internal global::AcpUI.AcpCopyButton CpyBtnCHO9PursuitKnobMode_A36683;

		// Token: 0x04003AF2 RID: 15090
		internal global::AcpUI.AcpLabel CHO9PursuitKnobMode_A36683Comp;

		// Token: 0x04003AF3 RID: 15091
		internal global::AcpUI.AcpComboBox CHO9PursuitKnobAction_A36684;

		// Token: 0x04003AF4 RID: 15092
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCHO9PursuitKnobAction_A36684;

		// Token: 0x04003AF5 RID: 15093
		internal global::AcpUI.AcpLabel LblCHO9PursuitKnobAction_A36684;

		// Token: 0x04003AF6 RID: 15094
		internal global::AcpUI.AcpRtdButton RTDBtnCHO9PursuitKnobAction_A36684;

		// Token: 0x04003AF7 RID: 15095
		internal global::AcpUI.AcpCopyButton CpyBtnCHO9PursuitKnobAction_A36684;

		// Token: 0x04003AF8 RID: 15096
		internal global::AcpUI.AcpLabel CHO9PursuitKnobAction_A36684Comp;

		// Token: 0x04003AF9 RID: 15097
		internal global::AcpUI.AcpComboBox CHO9PursuitKnobIndex_A36685;

		// Token: 0x04003AFA RID: 15098
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCHO9PursuitKnobIndex_A36685;

		// Token: 0x04003AFB RID: 15099
		internal global::AcpUI.AcpLabel LblCHO9PursuitKnobIndex_A36685;

		// Token: 0x04003AFC RID: 15100
		internal global::AcpUI.AcpRtdButton RTDBtnCHO9PursuitKnobIndex_A36685;

		// Token: 0x04003AFD RID: 15101
		internal global::AcpUI.AcpCopyButton CpyBtnCHO9PursuitKnobIndex_A36685;

		// Token: 0x04003AFE RID: 15102
		internal global::AcpUI.AcpLabel CHO9PursuitKnobIndex_A36685Comp;

		// Token: 0x04003AFF RID: 15103
		internal global::AcpUI.AcpComboBox CHO9PursuitKnobSecondaryIndex_A36823;

		// Token: 0x04003B00 RID: 15104
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCHO9PursuitKnobSecondaryIndex_A36823;

		// Token: 0x04003B01 RID: 15105
		internal global::AcpUI.AcpLabel LblCHO9PursuitKnobSecondaryIndex_A36823;

		// Token: 0x04003B02 RID: 15106
		internal global::AcpUI.AcpRtdButton RTDBtnCHO9PursuitKnobSecondaryIndex_A36823;

		// Token: 0x04003B03 RID: 15107
		internal global::AcpUI.AcpCopyButton CpyBtnCHO9PursuitKnobSecondaryIndex_A36823;

		// Token: 0x04003B04 RID: 15108
		internal global::AcpUI.AcpLabel CHO9PursuitKnobSecondaryIndex_A36823Comp;

		// Token: 0x04003B05 RID: 15109
		internal global::AcpUI.AcpComboBox CHO9PursuitKnobTertiaryIndex_A37025;

		// Token: 0x04003B06 RID: 15110
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCHO9PursuitKnobTertiaryIndex_A37025;

		// Token: 0x04003B07 RID: 15111
		internal global::AcpUI.AcpLabel LblCHO9PursuitKnobTertiaryIndex_A37025;

		// Token: 0x04003B08 RID: 15112
		internal global::AcpUI.AcpRtdButton RTDBtnCHO9PursuitKnobTertiaryIndex_A37025;

		// Token: 0x04003B09 RID: 15113
		internal global::AcpUI.AcpCopyButton CpyBtnCHO9PursuitKnobTertiaryIndex_A37025;

		// Token: 0x04003B0A RID: 15114
		internal global::AcpUI.AcpLabel CHO9PursuitKnobTertiaryIndex_A37025Comp;

		// Token: 0x04003B0B RID: 15115
		internal global::AcpUI.AcpExpander ExpanderControlHeadO9DirectionalButtons;

		// Token: 0x04003B0C RID: 15116
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderControlHeadO9DirectionalButtonsList;

		// Token: 0x04003B0D RID: 15117
		internal global::System.Windows.Controls.Grid ExpanderControlHeadO9DirectionalButtonsGrid;

		// Token: 0x04003B0E RID: 15118
		internal global::System.Windows.Controls.Grid ExpanderControlHeadO9DirectionalButtonsListGrid;

		// Token: 0x04003B0F RID: 15119
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadO9DirectionalButtonsListTableView;

		// Token: 0x04003B10 RID: 15120
		internal global::AcpUI.AcpXamDataPresenter ExpanderControlHeadO9DirectionalButtonsList;

		// Token: 0x04003B11 RID: 15121
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgCtrlHeadO9DirLightBarName_A36558_Col;

		// Token: 0x04003B12 RID: 15122
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgCtrlHeadO9DirLightBarBCO_A36559_Col;

		// Token: 0x04003B13 RID: 15123
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgCtrlHeadO9DirLightBarFeature_A36597_Col;

		// Token: 0x04003B14 RID: 15124
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgCtrlHeadO9DirLightBarIndex_A36601_Col;

		// Token: 0x04003B15 RID: 15125
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadO9DirectionalButtonsListSRecView;

		// Token: 0x04003B16 RID: 15126
		internal global::System.Windows.Controls.Grid gridExpanderControlHeadO9DirectionalButtonsListSRecView;

		// Token: 0x04003B17 RID: 15127
		internal global::AcpUI.AcpLabel RadErgCtrlHeadO9DirLightBarName_A36558;

		// Token: 0x04003B18 RID: 15128
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgCtrlHeadO9DirLightBarName_A36558;

		// Token: 0x04003B19 RID: 15129
		internal global::AcpUI.AcpLabel LblRadErgCtrlHeadO9DirLightBarName_A36558;

		// Token: 0x04003B1A RID: 15130
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgCtrlHeadO9DirLightBarName_A36558;

		// Token: 0x04003B1B RID: 15131
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgCtrlHeadO9DirLightBarName_A36558;

		// Token: 0x04003B1C RID: 15132
		internal global::AcpUI.AcpLabel RadErgCtrlHeadO9DirLightBarName_A36558Comp;

		// Token: 0x04003B1D RID: 15133
		internal global::AcpUI.AcpComboBox RadErgCtrlHeadO9DirLightBarBCO_A36559;

		// Token: 0x04003B1E RID: 15134
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgCtrlHeadO9DirLightBarBCO_A36559;

		// Token: 0x04003B1F RID: 15135
		internal global::AcpUI.AcpLabel LblRadErgCtrlHeadO9DirLightBarBCO_A36559;

		// Token: 0x04003B20 RID: 15136
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgCtrlHeadO9DirLightBarBCO_A36559;

		// Token: 0x04003B21 RID: 15137
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgCtrlHeadO9DirLightBarBCO_A36559;

		// Token: 0x04003B22 RID: 15138
		internal global::AcpUI.AcpLabel RadErgCtrlHeadO9DirLightBarBCO_A36559Comp;

		// Token: 0x04003B23 RID: 15139
		internal global::AcpUI.AcpComboBox RadErgCtrlHeadO9DirLightBarFeature_A36597;

		// Token: 0x04003B24 RID: 15140
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgCtrlHeadO9DirLightBarFeature_A36597;

		// Token: 0x04003B25 RID: 15141
		internal global::AcpUI.AcpLabel LblRadErgCtrlHeadO9DirLightBarFeature_A36597;

		// Token: 0x04003B26 RID: 15142
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgCtrlHeadO9DirLightBarFeature_A36597;

		// Token: 0x04003B27 RID: 15143
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgCtrlHeadO9DirLightBarFeature_A36597;

		// Token: 0x04003B28 RID: 15144
		internal global::AcpUI.AcpLabel RadErgCtrlHeadO9DirLightBarFeature_A36597Comp;

		// Token: 0x04003B29 RID: 15145
		internal global::AcpUI.AcpComboBox RadErgCtrlHeadO9DirLightBarIndex_A36601;

		// Token: 0x04003B2A RID: 15146
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgCtrlHeadO9DirLightBarIndex_A36601;

		// Token: 0x04003B2B RID: 15147
		internal global::AcpUI.AcpLabel LblRadErgCtrlHeadO9DirLightBarIndex_A36601;

		// Token: 0x04003B2C RID: 15148
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgCtrlHeadO9DirLightBarIndex_A36601;

		// Token: 0x04003B2D RID: 15149
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgCtrlHeadO9DirLightBarIndex_A36601;

		// Token: 0x04003B2E RID: 15150
		internal global::AcpUI.AcpLabel RadErgCtrlHeadO9DirLightBarIndex_A36601Comp;

		// Token: 0x04003B2F RID: 15151
		internal global::AcpUI.AcpExpander ExpanderControlHeadO9PASirenButtons;

		// Token: 0x04003B30 RID: 15152
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderControlHeadO9PASirenButtonsList;

		// Token: 0x04003B31 RID: 15153
		internal global::System.Windows.Controls.Grid ExpanderControlHeadO9PASirenButtonsGrid;

		// Token: 0x04003B32 RID: 15154
		internal global::System.Windows.Controls.Grid ExpanderControlHeadO9PASirenButtonsListGrid;

		// Token: 0x04003B33 RID: 15155
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadO9PASirenButtonsListTableView;

		// Token: 0x04003B34 RID: 15156
		internal global::AcpUI.AcpXamDataPresenter ExpanderControlHeadO9PASirenButtonsList;

		// Token: 0x04003B35 RID: 15157
		internal global::Infragistics.Windows.DataPresenter.UnboundField CHO9PASirenButtonsName_A41537_Col;

		// Token: 0x04003B36 RID: 15158
		internal global::Infragistics.Windows.DataPresenter.UnboundField CHO9PASirenButtonsBCO_A41538_Col;

		// Token: 0x04003B37 RID: 15159
		internal global::Infragistics.Windows.DataPresenter.UnboundField CHO9PASirenButtonsFeature_A41540_Col;

		// Token: 0x04003B38 RID: 15160
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadO9PASirenButtonsListSRecView;

		// Token: 0x04003B39 RID: 15161
		internal global::System.Windows.Controls.Grid gridExpanderControlHeadO9PASirenButtonsListSRecView;

		// Token: 0x04003B3A RID: 15162
		internal global::AcpUI.AcpLabel CHO9PASirenButtonsName_A41537;

		// Token: 0x04003B3B RID: 15163
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCHO9PASirenButtonsName_A41537;

		// Token: 0x04003B3C RID: 15164
		internal global::AcpUI.AcpLabel LblCHO9PASirenButtonsName_A41537;

		// Token: 0x04003B3D RID: 15165
		internal global::AcpUI.AcpRtdButton RTDBtnCHO9PASirenButtonsName_A41537;

		// Token: 0x04003B3E RID: 15166
		internal global::AcpUI.AcpCopyButton CpyBtnCHO9PASirenButtonsName_A41537;

		// Token: 0x04003B3F RID: 15167
		internal global::AcpUI.AcpLabel CHO9PASirenButtonsName_A41537Comp;

		// Token: 0x04003B40 RID: 15168
		internal global::AcpUI.AcpComboBox CHO9PASirenButtonsBCO_A41538;

		// Token: 0x04003B41 RID: 15169
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCHO9PASirenButtonsBCO_A41538;

		// Token: 0x04003B42 RID: 15170
		internal global::AcpUI.AcpLabel LblCHO9PASirenButtonsBCO_A41538;

		// Token: 0x04003B43 RID: 15171
		internal global::AcpUI.AcpRtdButton RTDBtnCHO9PASirenButtonsBCO_A41538;

		// Token: 0x04003B44 RID: 15172
		internal global::AcpUI.AcpCopyButton CpyBtnCHO9PASirenButtonsBCO_A41538;

		// Token: 0x04003B45 RID: 15173
		internal global::AcpUI.AcpLabel CHO9PASirenButtonsBCO_A41538Comp;

		// Token: 0x04003B46 RID: 15174
		internal global::AcpUI.AcpComboBox CHO9PASirenButtonsFeature_A41540;

		// Token: 0x04003B47 RID: 15175
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCHO9PASirenButtonsFeature_A41540;

		// Token: 0x04003B48 RID: 15176
		internal global::AcpUI.AcpLabel LblCHO9PASirenButtonsFeature_A41540;

		// Token: 0x04003B49 RID: 15177
		internal global::AcpUI.AcpRtdButton RTDBtnCHO9PASirenButtonsFeature_A41540;

		// Token: 0x04003B4A RID: 15178
		internal global::AcpUI.AcpCopyButton CpyBtnCHO9PASirenButtonsFeature_A41540;

		// Token: 0x04003B4B RID: 15179
		internal global::AcpUI.AcpLabel CHO9PASirenButtonsFeature_A41540Comp;

		// Token: 0x04003B4C RID: 15180
		internal global::AcpUI.AcpExpander ExpanderControlHeadO9RelayPatternBCOList;

		// Token: 0x04003B4D RID: 15181
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderControlHeadO9RelayPatternBCOListList;

		// Token: 0x04003B4E RID: 15182
		internal global::System.Windows.Controls.Grid ExpanderControlHeadO9RelayPatternBCOListGrid;

		// Token: 0x04003B4F RID: 15183
		internal global::System.Windows.Controls.Grid ExpanderControlHeadO9RelayPatternBCOListListGrid;

		// Token: 0x04003B50 RID: 15184
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadO9RelayPatternBCOListListTableView;

		// Token: 0x04003B51 RID: 15185
		internal global::AcpUI.AcpXamDataPresenter ExpanderControlHeadO9RelayPatternBCOListList;

		// Token: 0x04003B52 RID: 15186
		internal global::Infragistics.Windows.DataPresenter.UnboundField RdEgoO9DirLtbarPatternBcoListBco_A36661_Col;

		// Token: 0x04003B53 RID: 15187
		internal global::Infragistics.Windows.DataPresenter.UnboundField RdEgoO9DirLtbarPatternBcoListIndex_A36707_Col;

		// Token: 0x04003B54 RID: 15188
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadO9RelayPatternBCOListListSRecView;

		// Token: 0x04003B55 RID: 15189
		internal global::System.Windows.Controls.Grid gridExpanderControlHeadO9RelayPatternBCOListListSRecView;

		// Token: 0x04003B56 RID: 15190
		internal global::AcpUI.AcpComboBox RdEgoO9DirLtbarPatternBcoListBco_A36661;

		// Token: 0x04003B57 RID: 15191
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRdEgoO9DirLtbarPatternBcoListBco_A36661;

		// Token: 0x04003B58 RID: 15192
		internal global::AcpUI.AcpLabel LblRdEgoO9DirLtbarPatternBcoListBco_A36661;

		// Token: 0x04003B59 RID: 15193
		internal global::AcpUI.AcpRtdButton RTDBtnRdEgoO9DirLtbarPatternBcoListBco_A36661;

		// Token: 0x04003B5A RID: 15194
		internal global::AcpUI.AcpCopyButton CpyBtnRdEgoO9DirLtbarPatternBcoListBco_A36661;

		// Token: 0x04003B5B RID: 15195
		internal global::AcpUI.AcpLabel RdEgoO9DirLtbarPatternBcoListBco_A36661Comp;

		// Token: 0x04003B5C RID: 15196
		internal global::AcpUI.AcpComboBox RdEgoO9DirLtbarPatternBcoListIndex_A36707;

		// Token: 0x04003B5D RID: 15197
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRdEgoO9DirLtbarPatternBcoListIndex_A36707;

		// Token: 0x04003B5E RID: 15198
		internal global::AcpUI.AcpLabel LblRdEgoO9DirLtbarPatternBcoListIndex_A36707;

		// Token: 0x04003B5F RID: 15199
		internal global::AcpUI.AcpRtdButton RTDBtnRdEgoO9DirLtbarPatternBcoListIndex_A36707;

		// Token: 0x04003B60 RID: 15200
		internal global::AcpUI.AcpCopyButton CpyBtnRdEgoO9DirLtbarPatternBcoListIndex_A36707;

		// Token: 0x04003B61 RID: 15201
		internal global::AcpUI.AcpLabel RdEgoO9DirLtbarPatternBcoListIndex_A36707Comp;

		// Token: 0x04003B62 RID: 15202
		internal global::AcpUI.AcpExpander ExpanderControlHeadO9ConsolidatedActionBCOList;

		// Token: 0x04003B63 RID: 15203
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderControlHeadO9ConsolidatedActionBCOListTable;

		// Token: 0x04003B64 RID: 15204
		internal global::System.Windows.Controls.Grid ExpanderControlHeadO9ConsolidatedActionBCOListGrid;

		// Token: 0x04003B65 RID: 15205
		internal global::System.Windows.Controls.Grid ExpanderControlHeadO9ConsolidatedActionBCOListTableGrid;

		// Token: 0x04003B66 RID: 15206
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadO9ConsolidatedActionBCOListTableTableView;

		// Token: 0x04003B67 RID: 15207
		internal global::AcpUI.AcpXamDataPresenter ExpanderControlHeadO9ConsolidatedActionBCOListTable;

		// Token: 0x04003B68 RID: 15208
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoControlO9ACBCOListBco_A36666_Col;

		// Token: 0x04003B69 RID: 15209
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoControlO9ACBCOListIndex_A36668_Col;

		// Token: 0x04003B6A RID: 15210
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadO9ConsolidatedActionBCOListTableSRecView;

		// Token: 0x04003B6B RID: 15211
		internal global::System.Windows.Controls.Grid gridExpanderControlHeadO9ConsolidatedActionBCOListTableSRecView;

		// Token: 0x04003B6C RID: 15212
		internal global::AcpUI.AcpComboBox RadErgoControlO9ACBCOListBco_A36666;

		// Token: 0x04003B6D RID: 15213
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoControlO9ACBCOListBco_A36666;

		// Token: 0x04003B6E RID: 15214
		internal global::AcpUI.AcpLabel LblRadErgoControlO9ACBCOListBco_A36666;

		// Token: 0x04003B6F RID: 15215
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoControlO9ACBCOListBco_A36666;

		// Token: 0x04003B70 RID: 15216
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoControlO9ACBCOListBco_A36666;

		// Token: 0x04003B71 RID: 15217
		internal global::AcpUI.AcpLabel RadErgoControlO9ACBCOListBco_A36666Comp;

		// Token: 0x04003B72 RID: 15218
		internal global::AcpUI.AcpComboBox RadErgoControlO9ACBCOListIndex_A36668;

		// Token: 0x04003B73 RID: 15219
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoControlO9ACBCOListIndex_A36668;

		// Token: 0x04003B74 RID: 15220
		internal global::AcpUI.AcpLabel LblRadErgoControlO9ACBCOListIndex_A36668;

		// Token: 0x04003B75 RID: 15221
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoControlO9ACBCOListIndex_A36668;

		// Token: 0x04003B76 RID: 15222
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoControlO9ACBCOListIndex_A36668;

		// Token: 0x04003B77 RID: 15223
		internal global::AcpUI.AcpLabel RadErgoControlO9ACBCOListIndex_A36668Comp;

		// Token: 0x04003B78 RID: 15224
		internal global::AcpUI.AcpExpander ExpanderControlHeadO9O9NavigationControlsExpander;

		// Token: 0x04003B79 RID: 15225
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderControlHeadO9O9NavigationControlsTable;

		// Token: 0x04003B7A RID: 15226
		internal global::System.Windows.Controls.Grid ExpanderControlHeadO9O9NavigationControlsExpanderGrid;

		// Token: 0x04003B7B RID: 15227
		internal global::System.Windows.Controls.Grid ExpanderControlHeadO9O9NavigationControlsTableGrid;

		// Token: 0x04003B7C RID: 15228
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadO9O9NavigationControlsTableTableView;

		// Token: 0x04003B7D RID: 15229
		internal global::AcpUI.AcpXamDataPresenter ExpanderControlHeadO9O9NavigationControlsTable;

		// Token: 0x04003B7E RID: 15230
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoControlO9NaviControlName_A41370_Col;

		// Token: 0x04003B7F RID: 15231
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoControlO9NaviControlFeature_A41371_Col;

		// Token: 0x04003B80 RID: 15232
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadO9O9NavigationControlsTableSRecView;

		// Token: 0x04003B81 RID: 15233
		internal global::System.Windows.Controls.Grid gridExpanderControlHeadO9O9NavigationControlsTableSRecView;

		// Token: 0x04003B82 RID: 15234
		internal global::AcpUI.AcpLabel RadErgoControlO9NaviControlName_A41370;

		// Token: 0x04003B83 RID: 15235
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoControlO9NaviControlName_A41370;

		// Token: 0x04003B84 RID: 15236
		internal global::AcpUI.AcpLabel LblRadErgoControlO9NaviControlName_A41370;

		// Token: 0x04003B85 RID: 15237
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoControlO9NaviControlName_A41370;

		// Token: 0x04003B86 RID: 15238
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoControlO9NaviControlName_A41370;

		// Token: 0x04003B87 RID: 15239
		internal global::AcpUI.AcpLabel RadErgoControlO9NaviControlName_A41370Comp;

		// Token: 0x04003B88 RID: 15240
		internal global::AcpUI.AcpComboBox RadErgoControlO9NaviControlFeature_A41371;

		// Token: 0x04003B89 RID: 15241
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoControlO9NaviControlFeature_A41371;

		// Token: 0x04003B8A RID: 15242
		internal global::AcpUI.AcpLabel LblRadErgoControlO9NaviControlFeature_A41371;

		// Token: 0x04003B8B RID: 15243
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoControlO9NaviControlFeature_A41371;

		// Token: 0x04003B8C RID: 15244
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoControlO9NaviControlFeature_A41371;

		// Token: 0x04003B8D RID: 15245
		internal global::AcpUI.AcpLabel RadErgoControlO9NaviControlFeature_A41371Comp;

		// Token: 0x04003B8E RID: 15246
		internal global::AcpUI.AcpExpander ExpanderControlHeadO9Labtool;

		// Token: 0x04003B8F RID: 15247
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderControlHeadO9BottomFunctionButtonBCOList;

		// Token: 0x04003B90 RID: 15248
		internal global::System.Windows.Controls.Grid ExpanderControlHeadO9LabtoolGrid;

		// Token: 0x04003B91 RID: 15249
		internal global::System.Windows.Controls.Grid ExpanderControlHeadO9BottomFunctionButtonBCOListGrid;

		// Token: 0x04003B92 RID: 15250
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadO9BottomFunctionButtonBCOListTableView;

		// Token: 0x04003B93 RID: 15251
		internal global::AcpUI.AcpXamDataPresenter ExpanderControlHeadO9BottomFunctionButtonBCOList;

		// Token: 0x04003B94 RID: 15252
		internal global::Infragistics.Windows.DataPresenter.UnboundField CHO9BottomFunctionButtonBCO_A36827_Col;

		// Token: 0x04003B95 RID: 15253
		internal global::Infragistics.Windows.DataPresenter.UnboundField CHO9BottomFunctionButtonFeature_A36826_Col;

		// Token: 0x04003B96 RID: 15254
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadO9BottomFunctionButtonBCOListSRecView;

		// Token: 0x04003B97 RID: 15255
		internal global::System.Windows.Controls.Grid gridExpanderControlHeadO9BottomFunctionButtonBCOListSRecView;

		// Token: 0x04003B98 RID: 15256
		internal global::AcpUI.AcpComboBox CHO9BottomFunctionButtonBCO_A36827;

		// Token: 0x04003B99 RID: 15257
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCHO9BottomFunctionButtonBCO_A36827;

		// Token: 0x04003B9A RID: 15258
		internal global::AcpUI.AcpLabel LblCHO9BottomFunctionButtonBCO_A36827;

		// Token: 0x04003B9B RID: 15259
		internal global::AcpUI.AcpRtdButton RTDBtnCHO9BottomFunctionButtonBCO_A36827;

		// Token: 0x04003B9C RID: 15260
		internal global::AcpUI.AcpCopyButton CpyBtnCHO9BottomFunctionButtonBCO_A36827;

		// Token: 0x04003B9D RID: 15261
		internal global::AcpUI.AcpLabel CHO9BottomFunctionButtonBCO_A36827Comp;

		// Token: 0x04003B9E RID: 15262
		internal global::AcpUI.AcpComboBox CHO9BottomFunctionButtonFeature_A36826;

		// Token: 0x04003B9F RID: 15263
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCHO9BottomFunctionButtonFeature_A36826;

		// Token: 0x04003BA0 RID: 15264
		internal global::AcpUI.AcpLabel LblCHO9BottomFunctionButtonFeature_A36826;

		// Token: 0x04003BA1 RID: 15265
		internal global::AcpUI.AcpRtdButton RTDBtnCHO9BottomFunctionButtonFeature_A36826;

		// Token: 0x04003BA2 RID: 15266
		internal global::AcpUI.AcpCopyButton CpyBtnCHO9BottomFunctionButtonFeature_A36826;

		// Token: 0x04003BA3 RID: 15267
		internal global::AcpUI.AcpLabel CHO9BottomFunctionButtonFeature_A36826Comp;

		// Token: 0x04003BA4 RID: 15268
		private bool b;
	}
}
