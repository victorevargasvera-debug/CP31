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

namespace Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories
{
	// Token: 0x02000317 RID: 791
	public class PageKeypadMicAndAccessories : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x06007C1A RID: 31770 RVA: 0x0071BF7C File Offset: 0x0071A17C
		public PageKeypadMicAndAccessories()
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

		// Token: 0x06007C1B RID: 31771 RVA: 0x0071BFB4 File Offset: 0x0071A1B4
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)725352448;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)232783877;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					object obj;
					global::AcpUI.AcpExpander acpExpander;
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						obj = null;
						obj = this.RecNavToolbarExpanderKeypadMicAndAccessoriesKMButton.MyRecordsetDataSource;
						num = (short)752943112;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_296;
					case 2:
						goto IL_42B;
					case 3:
						if (obj != null)
						{
							num = (short)2067922951;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_42B;
					case 4:
						if (obj != null)
						{
							num = (short)8126465;
							if (num != 0)
							{
							}
							num = (short)643104769;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_357;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_78;
						}
						continue;
					case 6:
						goto IL_357;
					case 7:
					{
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderKeypadMicAndAccessoriesDataButton.MyDataPresenter = this.ExpanderKeypadMicAndAccessoriesDataButton;
						num = (short)1365966850;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						if (obj != null)
						{
							num = (short)1199702027;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3EA;
					case 9:
						goto IL_3AE;
					case 10:
						try
						{
							num = (short)1482817536;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_10E;
									}
									continue;
								case 1:
								{
									num = (short)301350638;
									short num3 = num;
									num = (short)214580974;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_21D;
									default:
										num = (short)3211264;
										if (num != 0)
										{
										}
										base.Expanders.Add(acpExpander);
										num = (short)290127876;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									goto IL_21D;
								case 3:
									if (acpExpander != null)
									{
										num = (short)88604673;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 5:
									num = (short)1304887298;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									if (!enumerator.MoveNext())
									{
										num = (short)1582366725;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
									num = (short)1562443779;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_110:
								num = (short)1242890246;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_10E:
								goto IL_110;
							}
							IL_21D:
							goto IL_387;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_23F;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_22C:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)1097465857;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_293;
								case 2:
									if (disposable != null)
									{
										num = (short)518258688;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_295;
								}
								goto IL_23F;
							}
							IL_293:
							IL_295:
							goto EndFinally_10;
							IL_23F:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1917911042;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_22C;
							EndFinally_10:;
						}
						goto IL_296;
						IL_387:
						base.OnLoaded(sender, e);
						this.a = true;
						num = (short)632422409;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderKeypadMicAndAccessoriesKMButton.MyDataPresenter = this.ExpanderKeypadMicAndAccessoriesKMButton;
						num = (short)470351884;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						goto IL_3EA;
					}
					IL_78:
					if (!this.a)
					{
						num = (short)1871970304;
						short num4 = num;
						num = (short)570884096;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_296:
					global::System.Windows.Data.CollectionView collectionView3 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
					this.RecNavToolbarExpanderKeypadMicAndAccessoriesKMANavigationControlsTable.MyDataPresenter = this.ExpanderKeypadMicAndAccessoriesKMANavigationControlsTable;
					num = (short)1766588422;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_357:
					acpExpander = null;
					enumerator = this.MyStackPanel.Children.GetEnumerator();
					num = (short)2101215242;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3EA:
					obj = this.RecNavToolbarExpanderKeypadMicAndAccessoriesDataButton.MyRecordsetDataSource;
					num = (short)2106064899;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_42B:
					obj = this.RecNavToolbarExpanderKeypadMicAndAccessoriesKMANavigationControlsTable.MyRecordsetDataSource;
					num = (short)378077188;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_3AE:
				this.MyStackPanel.Children[0].Focus();
				return;
			}
		}

		// Token: 0x06007C1C RID: 31772 RVA: 0x0071C494 File Offset: 0x0071A694
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
					base.OnUnloaded(sender, e);
					this.a = false;
					num2 = (short)170196993;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_C2;
				case 2:
					if (this.a)
					{
						num2 = (short)2112946176;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_C4;
				}
				goto IL_1C;
			}
			IL_C2:
			IL_C4:
			num2 = (short)229572608;
			short num3 = num2;
			num2 = (short)1404657918;
			short num4 = num2;
			num2 = (short)1636327678;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_C2;
			default:
				num2 = (short)1482686465;
				if (num2 != 0)
				{
				}
				num2 = (short)1933574144;
				if (num2 != 0)
				{
				}
				return;
			}
			IL_1C:
			this.RecNavToolbarExpanderKeypadMicAndAccessoriesKMButton.DataContext = null;
			this.RecNavToolbarExpanderKeypadMicAndAccessoriesDataButton.DataContext = null;
			this.RecNavToolbarExpanderKeypadMicAndAccessoriesKMANavigationControlsTable.DataContext = null;
			this.RecNavToolbarExpanderKeypadMicAndAccessoriesKMButton.MyDataPresenter = null;
			this.RecNavToolbarExpanderKeypadMicAndAccessoriesDataButton.MyDataPresenter = null;
			this.RecNavToolbarExpanderKeypadMicAndAccessoriesKMANavigationControlsTable.MyDataPresenter = null;
			num2 = (short)186777602;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06007C1D RID: 31773 RVA: 0x0071C600 File Offset: 0x0071A800
		public override void SetDataContext()
		{
			short num = (short)253493261;
			int num2 = (int)((global::System.IntPtr)num);
			object feature;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_657;
				case 1:
					goto IL_D1;
				case 2:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)1004470288;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderKeypadMicAndAccessoriesKMButton).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderKeypadMicAndAccessoriesDataButton).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderKeypadMicAndAccessoriesKMANavigationControlsTable).MySecondaryRecordsetDataSource = null;
					num = (short)578813961;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)1829437460;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (feature != null)
					{
						num = (short)1686962195;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_657;
				case 5:
					goto IL_263;
				case 6:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10231].EmbeddedRecset != null)
					{
						num = (short)771883029;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_657;
				case 7:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10753].EmbeddedRecset != null)
					{
						num = (short)989724680;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 8:
					goto IL_3FD;
				case 9:
					return;
				case 10:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10231] != null)
					{
						num = (short)6750208;
						short num3 = num;
						num = (short)1260650520;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_657;
				case 11:
					num = (short)1306525706;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)1538457603;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D1;
				case 13:
					switch (0)
					{
					case 0:
						goto IL_AA;
					}
					continue;
				case 14:
					num = (short)1187708935;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					num = (short)862453772;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2128);
					num = (short)1366228996;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					num = (short)1297940508;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					goto IL_263;
				case 19:
				{
					num = (short)561250305;
					if (num != 0)
					{
					}
					num = (short)1665635389;
					short num4 = num;
					num = (short)245142589;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_652;
					default:
						num = (short)751763456;
						if (num != 0)
						{
						}
						num = (short)1963065369;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 20:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10228] != null)
					{
						num = (short)123994135;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D1;
				case 21:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderKeypadMicAndAccessoriesKMButton).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10231].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderKeypadMicAndAccessoriesKMButton).SyncDataSources();
					num = (short)312934400;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					if (feature != null)
					{
						num = (short)1464533024;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 23:
					num = (short)1919942685;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					num = (short)1196883974;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)722731019;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_657;
				case 26:
					goto IL_652;
				case 27:
					if (feature != null)
					{
						num = (short)2128019471;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D1;
				case 28:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10753] != null)
					{
						num = (short)548405262;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 29:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10228].EmbeddedRecset != null)
					{
						num = (short)1578958874;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D1;
				case 30:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2128);
					num = (short)2043478021;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 31:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)1201143825;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 32:
					num = (short)1366097951;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_AA:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)483786782;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2128);
				num = (short)578551826;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D1:
				num = (short)773586966;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_263:
				num = (short)1331363842;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_652:
				((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderKeypadMicAndAccessoriesDataButton).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10228].EmbeddedRecset;
				((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderKeypadMicAndAccessoriesDataButton).SyncDataSources();
				num = (short)584581121;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_657:
				num = (short)2010447899;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_3FD:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderKeypadMicAndAccessoriesKMANavigationControlsTable).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10753].EmbeddedRecset;
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderKeypadMicAndAccessoriesKMANavigationControlsTable).SyncDataSources();
		}

		// Token: 0x06007C1E RID: 31774 RVA: 0x0071CCA0 File Offset: 0x0071AEA0
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 6;
			short num = (short)169442724;
			short num2 = num;
			num = (short)13139364;
			object myRecordsetDataSource;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_52C:
				((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
				myRecordsetDataSource = this.RecNavToolbarExpanderKeypadMicAndAccessoriesDataButton.MyRecordsetDataSource;
				num = (short)138543112;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
			{
				num = (short)65339392;
				short num4 = num;
				num = (short)143458304;
				if (num != 0)
				{
				}
				num = (short)1127350272;
				switch (num)
				{
				default:
					num = (short)697892882;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				break;
			}
			}
			object myRecordsetDataSource2;
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_2BD;
				case 1:
					goto IL_356;
				case 2:
					if (myRecordsetDataSource2 != null)
					{
						num = (short)31457280;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
					goto IL_4D3;
				case 4:
				{
					object myRecordsetDataSource3;
					if (myRecordsetDataSource3 != null)
					{
						num = (short)1584267265;
						if (num != 0)
						{
						}
						num = (short)1293221908;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4D3;
				}
				case 5:
					goto IL_4D3;
				case 6:
					((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
					myRecordsetDataSource2 = this.RecNavToolbarExpanderKeypadMicAndAccessoriesKMANavigationControlsTable.MyRecordsetDataSource;
					num = (short)16777218;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_398;
				case 8:
					if (myRecordsetDataSource != null)
					{
						num = (short)2077818892;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_151;
				case 9:
					goto IL_151;
				case 10:
					if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
					{
						num = (short)330170385;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
					num = (short)1670643717;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					goto IL_151;
				case 12:
				{
					global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
					global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInner item = (global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInner)collectionView.CurrentItem;
					collectionView.MoveCurrentTo(item);
					((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
					num = (short)849281035;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 13:
					if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
					{
						num = (short)157351943;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
					num = (short)1423310857;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					num = (short)1663696909;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					num = (short)1096351760;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
					{
						num = (short)68747270;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
					num = (short)1757282305;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
				{
					((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
					object myRecordsetDataSource3 = this.RecNavToolbarExpanderKeypadMicAndAccessoriesKMButton.MyRecordsetDataSource;
					num = (short)627441668;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 18:
					switch (0)
					{
					case 0:
						goto IL_128;
					}
					continue;
				case 19:
					if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("闆곈꣊菌껎Ꟑ蟒뫔룖뗘맚볜귞ꓠ鯢闤蛦蟨迪裬鷮뫰雲賴蟶飸鿺냼雾戀䈂欄挆䠈栊渌樎成怒稔攖瀘縚渜吞氠愢値匦崨䐪䌬", a_))
					{
						num = (short)1902444567;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4D3;
				case 20:
				{
					object myRecordsetDataSource3;
					global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource3);
					global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner item2 = (global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner)collectionView2.CurrentItem;
					collectionView2.MoveCurrentTo(item2);
					((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
					num = (short)1862008835;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 21:
					if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("闆곈꣊菌껎Ꟑ蟒뫔룖뗘맚볜귞ꓠ鯢闤蛦蟨迪裬鷮뫰雲賴蟶飸鿺냼雾戀䈂欄挆䠈栊渌樎成怒稔攖瀘縚渜嬞䀠圢䐤攦尨弪夬䀮弰", a_))
					{
						num = (short)1395195918;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_151;
				case 22:
					num = (short)1088028691;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					num = (short)2066743306;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("闆곈꣊菌껎Ꟑ蟒뫔룖뗘맚볜귞ꓠ鯢闤蛦蟨迪裬鷮뫰雲賴蟶飸鿺냼雾戀䈂欄挆䠈栊渌樎成怒稔攖瀘縚渜吞氠戢欤䘦弨䈪䨬丮䔰娲娴夶稸吺匼䬾㍀ⱂ⥄㑆ᵈ⩊⽌⍎㑐", a_))
					{
						num = (short)278659087;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_128:
				if (A_0 is global::AcpUI.AcpRecNavToolbar)
				{
					num = (short)1209794582;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_151:
				num = (short)1660223512;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_4D3:
				num = (short)1178796053;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_2BD:
			global::System.Windows.Data.CollectionView collectionView3 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource2);
			global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMANavigationControlsTableInner item3 = (global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMANavigationControlsTableInner)collectionView3.CurrentItem;
			collectionView3.MoveCurrentTo(item3);
			((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
			return;
			IL_356:
			return;
			IL_398:
			goto IL_52C;
		}

		// Token: 0x06007C1F RID: 31775 RVA: 0x0071D22C File Offset: 0x0071B42C
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)735208832;
			short num2 = num;
			num = (short)229074304;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1003749376;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)657719297;
			if (num != 0)
			{
			}
			num = (short)1440808960;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x06007C20 RID: 31776 RVA: 0x0071D2DC File Offset: 0x0071B4DC
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1041727533;
			short num2 = num;
			num = (short)206733357;
			switch (num2 == num)
			{
			default:
			{
				num = (short)631963648;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1704132608;
			if (num != 0)
			{
			}
			num = (short)1731264513;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06007C21 RID: 31777 RVA: 0x0071D38C File Offset: 0x0071B58C
		internal void OnExpanderKeypadMicAndAccessoriesKMButtonClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				object myRecordsetDataSource;
				global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner item;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)1987186021;
						short num3 = num2;
						num2 = (short)1721961829;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)452919296;
							if (num2 != 0)
							{
							}
							if (myRecordsetDataSource != null)
							{
								num2 = (short)502071297;
								if (num2 != 0)
								{
								}
								num2 = (short)2032009218;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_151;
						}
						break;
					}
					case 1:
						goto IL_14F;
					case 2:
					{
						((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
						this.RecNavToolbarExpanderKeypadMicAndAccessoriesKMButton.SyncDataSources();
						num2 = (short)1676935168;
						short num4 = num2;
						num2 = (short)1109393409;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				IL_1C:
				item = (global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
				myRecordsetDataSource = this.RecNavToolbarExpanderKeypadMicAndAccessoriesKMButton.MyRecordsetDataSource;
				num2 = (short)2082930688;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_14F:
			IL_151:
			this.RecNavToolbarExpanderKeypadMicAndAccessoriesKMButton.TableMode = false;
		}

		// Token: 0x06007C22 RID: 31778 RVA: 0x0071D4F8 File Offset: 0x0071B6F8
		internal void OnExpanderKeypadMicAndAccessoriesDataButtonClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				object myRecordsetDataSource;
				global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInner item;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)470193926;
						short num3 = num2;
						num2 = (short)638883590;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)676790272;
							if (num2 != 0)
							{
							}
							if (myRecordsetDataSource != null)
							{
								num2 = (short)1740963842;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_155;
						}
						break;
					}
					case 1:
						goto IL_153;
					case 2:
					{
						((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
						this.RecNavToolbarExpanderKeypadMicAndAccessoriesDataButton.SyncDataSources();
						num2 = (short)1913192449;
						if (num2 != 0)
						{
						}
						num2 = (short)2078932992;
						short num4 = num2;
						num2 = (short)70844417;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				IL_1C:
				item = (global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
				myRecordsetDataSource = this.RecNavToolbarExpanderKeypadMicAndAccessoriesDataButton.MyRecordsetDataSource;
				num2 = (short)1924988928;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_153:
			IL_155:
			this.RecNavToolbarExpanderKeypadMicAndAccessoriesDataButton.TableMode = false;
		}

		// Token: 0x06007C23 RID: 31779 RVA: 0x0071D668 File Offset: 0x0071B868
		internal void OnExpanderKeypadMicAndAccessoriesKMANavigationControlsTableClick(object sender, global::System.Windows.RoutedEventArgs e)
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
				object myRecordsetDataSource;
				global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMANavigationControlsTableInner item;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)1856144170;
						short num3 = num2;
						num2 = (short)646677290;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)650510336;
							if (num2 != 0)
							{
							}
							if (myRecordsetDataSource != null)
							{
								num2 = (short)66650114;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_152;
						}
						break;
					}
					case 1:
						goto IL_FF;
					case 2:
						((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
						this.RecNavToolbarExpanderKeypadMicAndAccessoriesKMANavigationControlsTable.SyncDataSources();
						num2 = (short)322240513;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				IL_1C:
				item = (global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMANavigationControlsTableInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
				myRecordsetDataSource = this.RecNavToolbarExpanderKeypadMicAndAccessoriesKMANavigationControlsTable.MyRecordsetDataSource;
				num2 = (short)2048262144;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_FF:
			num2 = (short)936640512;
			short num4 = num2;
			num2 = (short)1551564801;
			if (num2 != 0)
			{
			}
			IL_152:
			this.RecNavToolbarExpanderKeypadMicAndAccessoriesKMANavigationControlsTable.TableMode = false;
		}

		// Token: 0x06007C24 RID: 31780 RVA: 0x0071D7D4 File Offset: 0x0071B9D4
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 14;
			while (this.b)
			{
				short num = (short)1739186360;
				short num2 = num;
				num = (short)1333059768;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1860501504;
					if (num != 0)
					{
					}
					num = (short)379584512;
					short num3 = num;
					num = (short)578551809;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
			this.b = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("郐뿒맔釖볘뫚꧜꫞鏠蛢雤\udce6諨蓪胬鿮黰鷲郴駶跸퓺迼黾攀樂樄∆㬈㬊栌紎瘐簒笔砖琘爚縜氞Рᄢᔤ䐦䘨䔪䬬䘮嘰䘲䜴嘶䴸刺刼儾湀⁂⩄⥆㵈㥊≌⍎≐籒㹔㉖⁘⭚㱜㭞䑠兢啤੦hࡪ䡬嵮䅰ቲ᭴፶屸䥺䵼Ṿ愈ﾌ몔ﲖﲘﺞ얠캢첤쒦좨얪즬캮튰킲킴쒶쪸풺쾼횾꓀냂뿆꣈ꛊꇌ", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06007C25 RID: 31781 RVA: 0x0071D8B8 File Offset: 0x0071BAB8
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1149960193;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_3C9;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 2:
					goto IL_3E1;
				}
				IL_31:
				switch (connectionId)
				{
				case 1:
					goto IL_963;
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
					goto IL_E70;
				case 18:
					goto IL_994;
				case 19:
					goto IL_58E;
				case 20:
					goto IL_4EE;
				case 21:
					goto IL_848;
				case 22:
					goto IL_DF4;
				case 23:
					goto IL_B63;
				case 24:
					goto IL_C44;
				case 25:
					goto IL_BDF;
				case 26:
					goto IL_614;
				case 27:
					goto IL_DD0;
				case 28:
					goto IL_82E;
				case 29:
					goto IL_C51;
				case 30:
					goto IL_E32;
				case 31:
					goto IL_C5E;
				case 32:
					goto IL_83B;
				case 33:
					goto IL_86C;
				case 34:
					goto IL_34A;
				case 35:
					goto IL_6F5;
				case 36:
					goto IL_5E3;
				case 37:
					goto IL_581;
				case 38:
					goto IL_3F3;
				case 39:
					goto IL_9E2;
				case 40:
					goto IL_621;
				case 41:
					goto IL_E3F;
				case 42:
					goto IL_693;
				case 43:
					goto IL_3E6;
				case 44:
					goto IL_D04;
				case 45:
					goto IL_CC3;
				case 46:
					goto IL_302;
				case 47:
					goto IL_472;
				case 48:
					goto IL_80A;
				case 49:
					goto IL_400;
				case 50:
					goto IL_37E;
				case 51:
					goto IL_652;
				case 52:
					goto IL_5BF;
				case 53:
					goto IL_4B0;
				case 54:
					goto IL_4BD;
				case 55:
					goto IL_D78;
				case 56:
					goto IL_B70;
				case 57:
					goto IL_A9C;
				case 58:
					goto IL_48C;
				case 59:
					goto IL_CF7;
				case 60:
					goto IL_BF9;
				case 61:
					goto IL_465;
				case 62:
					goto IL_A2D;
				case 63:
					goto IL_D85;
				case 64:
					goto IL_51F;
				case 65:
					goto IL_9C8;
				case 66:
					goto IL_90E;
				case 67:
					goto IL_6DB;
				case 68:
					goto IL_567;
				case 69:
					goto IL_AA9;
				case 70:
					goto IL_879;
				case 71:
					goto IL_C1D;
				case 72:
					goto IL_434;
				case 73:
					goto IL_427;
				case 74:
					goto IL_740;
				case 75:
					goto IL_BD2;
				case 76:
					goto IL_DAC;
				case 77:
					goto IL_733;
				case 78:
					goto IL_7A8;
				case 79:
					goto IL_3BC;
				case 80:
					goto IL_74D;
				case 81:
					goto IL_9BB;
				case 82:
					goto IL_C37;
				case 83:
					goto IL_9AE;
				case 84:
					goto IL_512;
				case 85:
					goto IL_79B;
				case 86:
					goto IL_CD0;
				case 87:
					goto IL_BC5;
				case 88:
					goto IL_9D5;
				case 89:
					goto IL_4E1;
				case 90:
					goto IL_E18;
				case 91:
					goto IL_932;
				case 92:
					goto IL_CA9;
				case 93:
					goto IL_A6B;
				case 94:
					goto IL_75A;
				case 95:
					goto IL_6E8;
				case 96:
					goto IL_D9F;
				case 97:
					goto IL_7E6;
				case 98:
					goto IL_2F5;
				case 99:
					goto IL_70F;
				case 100:
					goto IL_9A1;
				case 101:
					goto IL_371;
				case 102:
					goto IL_7B5;
				case 103:
					goto IL_6B7;
				case 104:
					goto IL_645;
				case 105:
					goto IL_D3A;
				case 106:
					goto IL_B2F;
				case 107:
					goto IL_C9C;
				case 108:
					goto IL_458;
				case 109:
					goto IL_ADA;
				case 110:
					goto IL_901;
				case 111:
					goto IL_9FC;
				case 112:
					goto IL_A20;
				case 113:
				{
					num = (short)682664217;
					short num3 = num;
					num = (short)325755161;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_8DF;
					}
					break;
				}
				case 114:
					goto IL_357;
				case 115:
					goto IL_B7D;
				case 116:
					goto IL_89D;
				case 117:
					goto IL_2D1;
				case 118:
					goto IL_B3C;
				case 119:
					goto IL_B22;
				case 120:
					goto IL_A5E;
				case 121:
					goto IL_AB6;
				case 122:
					goto IL_702;
				case 123:
					goto IL_543;
				case 124:
					goto IL_66C;
				case 125:
					goto IL_956;
				case 126:
					goto IL_BEC;
				case 127:
					goto IL_5F0;
				case 128:
					goto IL_A8F;
				case 129:
					goto IL_7C2;
				case 130:
					goto IL_41A;
				case 131:
					goto IL_B49;
				case 132:
					goto IL_C6B;
				case 133:
					goto IL_326;
				case 134:
					goto IL_47F;
				case 135:
					goto IL_E4C;
				case 136:
					goto IL_65F;
				case 137:
					goto IL_679;
				case 138:
					goto IL_9EF;
				case 139:
					goto IL_A3A;
				case 140:
					goto IL_574;
				case 141:
					goto IL_38B;
				case 142:
					goto IL_686;
				case 143:
					goto IL_D92;
				case 144:
					goto IL_40D;
				case 145:
					goto IL_D6B;
				case 146:
					goto IL_364;
				case 147:
					goto IL_5B2;
				case 148:
					goto IL_C78;
				case 149:
					goto IL_767;
				case 150:
					goto IL_AFE;
				case 151:
					goto IL_B56;
				case 152:
					goto IL_CDD;
				case 153:
					goto IL_D5E;
				case 154:
					goto IL_BA1;
				case 155:
					goto IL_CB6;
				case 156:
					goto IL_398;
				case 157:
					goto IL_E25;
				case 158:
					goto IL_CEA;
				case 159:
					goto IL_C2A;
				default:
					num = (short)1403256832;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_3C9:
				num = (short)601489410;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_2D1:
			this.LblRadErgoCfgKMTrunkingKMDataButtonBCO_A22604 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgKMTrunkingKMDataButtonBCO_A22604.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2F5:
			this.CVBtnRadErgoCfgKMConventionalKMDataButtonBCO_A22602 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_302:
			this.RadErgoCfgKMConventionalKMButtonBCO_A19643 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoCfgKMConventionalKMButtonBCO_A19643.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_326:
			this.RadErgoCfgKMDataButtonKey_A22600 = (global::AcpUI.AcpTextBox)target;
			this.RadErgoCfgKMDataButtonKey_A22600.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_34A:
			this.RadErgoCfgKMConventionalKMButtonFeature_A19646_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_357:
			this.RadErgoCfgKMConventionalKMDatatButtonIndex_A41423Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_364:
			this.ExpanderKeypadMicAndAccessoriesKMANavigationControlsTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_371:
			this.CpyBtnRadErgoCfgKMConventionalKMDataButtonBCO_A22602 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_37E:
			this.CpyBtnRadErgoCfgKMConventionalKMButtonBCO_A19643 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_38B:
			this.ExpanderKeypadMicAndAccessoriesKMANavigationControlsTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_398:
			this.LblRadErgoControlKMAUpDownButton_41760 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoControlKMAUpDownButton_41760.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3BC:
			this.ExpanderKeypadMicAndAccessoriesDataButtonTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_3E1:
			goto IL_E70;
			IL_3E6:
			this.RTDBtnRadErgoCfgKMButtonName_A22561 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3F3:
			this.ExpanderKeypadMicAndAccessoriesKMButtonSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_400:
			this.RTDBtnRadErgoCfgKMConventionalKMButtonBCO_A19643 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_40D:
			this.RadErgoControlKMANaviControlName_41759_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_41A:
			this.RTDBtnRadErgoCfgKMTrunkingKMDatatButtonIndex_A41424 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_427:
			this.CpyBtnRadErgoCfgKMButtonKey_A22560 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_434:
			this.LblRadErgoCfgKMButtonKey_A22560 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgKMButtonKey_A22560.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_458:
			this.RadErgoCfgKMConventionalKMDatatButtonFeature_A22603Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_465:
			this.RTDBtnRadErgoCfgKMTrunkingKMButtonBCO_A19745 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_472:
			this.CVBtnRadErgoCfgKMConventionalKMButtonBCO_A19643 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_47F:
			this.CVBtnRadErgoCfgKMDataButtonKey_A22600 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_48C:
			this.RadErgoCfgKMTrunkingKMButtonBCO_A19745 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoCfgKMTrunkingKMButtonBCO_A19745.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4B0:
			this.CVBtnRadErgoCfgKMConventionalKMButtonFeature_A19646 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4BD:
			this.LblRadErgoCfgKMConventionalKMButtonFeature_A19646 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgKMConventionalKMButtonFeature_A19646.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4E1:
			this.ExpanderKeypadMicAndAccessoriesDataButtonSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_4EE:
			this.HLinkGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkGeneral.Click += this.HLinkClick;
			return;
			IL_512:
			this.RadErgoCfgKMConventionalKMDatatButtonIndex_A41423_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_51F:
			this.RadErgoCfgKMTrunkingKMButtonFeature_A19746 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoCfgKMTrunkingKMButtonFeature_A19746.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_543:
			this.LblRadErgoCfgKMTrunkingKMDatatButtonFeature_A22605 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgKMTrunkingKMDatatButtonFeature_A22605.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_567:
			this.CpyBtnRadErgoCfgKMTrunkingKMButtonFeature_A19746 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_574:
			this.ExpanderKeypadMicAndAccessoriesKMANavigationControlsExpanderGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_581:
			this.RadErgoCfgKMButtonKey_A22560_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_58E:
			this.HLinkKeypadMicAndAccessoriesGraphicview = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkKeypadMicAndAccessoriesGraphicview.Click += this.HLinkClick;
			return;
			IL_5B2:
			this.gridExpanderKeypadMicAndAccessoriesKMANavigationControlsTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_5BF:
			this.RadErgoCfgKMConventionalKMButtonFeature_A19646 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoCfgKMConventionalKMButtonFeature_A19646.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5E3:
			this.RadErgoCfgKMTrunkingKMButtonFeature_A19746_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_5F0:
			this.RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_614:
			this.ExpanderKeypadMicAndAccessoriesGeneral = (global::AcpUI.AcpExpander)target;
			return;
			IL_621:
			this.RadErgoCfgKMButtonName_A22561 = (global::AcpUI.AcpLabel)target;
			this.RadErgoCfgKMButtonName_A22561.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_645:
			this.CVBtnRadErgoCfgKMConventionalKMDatatButtonFeature_A22603 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_652:
			this.RadErgoCfgKMConventionalKMButtonBCO_A19643Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_65F:
			this.CpyBtnRadErgoCfgKMDataButtonKey_A22600 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_66C:
			this.RTDBtnRadErgoCfgKMTrunkingKMDatatButtonFeature_A22605 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_679:
			this.RadErgoCfgKMDataButtonKey_A22600Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_686:
			this.ExpanderKeypadMicAndAccessoriesKMANavigationControlsTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_693:
			this.LblRadErgoCfgKMButtonName_A22561 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgKMButtonName_A22561.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_6B7:
			this.RadErgoCfgKMConventionalKMDatatButtonFeature_A22603 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoCfgKMConventionalKMDatatButtonFeature_A22603.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_6DB:
			this.RTDBtnRadErgoCfgKMTrunkingKMButtonFeature_A19746 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_6E8:
			this.CpyBtnRadErgoCfgKMDataButtonName_A22601 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_6F5:
			this.RadErgoCfgKMTrunkingKMButtonBCO_A19745_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_702:
			this.CVBtnRadErgoCfgKMTrunkingKMDatatButtonFeature_A22605 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_70F:
			this.LblRadErgoCfgKMConventionalKMDataButtonBCO_A22602 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgKMConventionalKMDataButtonBCO_A22602.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_733:
			this.ExpanderKeypadMicAndAccessoriesDataGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_740:
			this.RadErgoCfgKMButtonKey_A22560Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_74D:
			this.ExpanderKeypadMicAndAccessoriesDataButton = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_75A:
			this.RTDBtnRadErgoCfgKMDataButtonName_A22601 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_767:
			num = (short)1154744321;
			if (num != 0)
			{
			}
			this.CVBtnRadErgoControlKMANaviControlName_41759 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_79B:
			this.RadErgoCfgKMTrunkingKMDataButtonBCO_A22604_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_7A8:
			this.ExpanderKeypadMicAndAccessoriesDataButtonGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_7B5:
			this.RadErgoCfgKMConventionalKMDataButtonBCO_A22602Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_7C2:
			this.LblRadErgoCfgKMTrunkingKMDatatButtonIndex_A41424 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgKMTrunkingKMDatatButtonIndex_A41424.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_7E6:
			this.RadErgoCfgKMConventionalKMDataButtonBCO_A22602 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoCfgKMConventionalKMDataButtonBCO_A22602.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_80A:
			this.LblRadErgoCfgKMConventionalKMButtonBCO_A19643 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgKMConventionalKMButtonBCO_A19643.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_82E:
			this.ExpanderKeypadMicAndAccessoriesGeneralGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_83B:
			this.RadErgoCfgKMButtonName_A22561_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_848:
			this.HLinkData = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkData.Click += this.HLinkClick;
			return;
			IL_86C:
			this.RadErgoCfgKMConventionalKMButtonBCO_A19643_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_879:
			this.RadErgoCfgKMButtonKey_A22560 = (global::AcpUI.AcpTextBox)target;
			this.RadErgoCfgKMButtonKey_A22560.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_89D:
			this.CVBtnRadErgoCfgKMTrunkingKMDataButtonBCO_A22604 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_8DF:
			num = (short)1447362560;
			if (num != 0)
			{
			}
			this.CpyBtnRadErgoCfgKMConventionalKMDatatButtonIndex_A41423 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_901:
			this.CVBtnRadErgoCfgKMConventionalKMDatatButtonIndex_A41423 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_90E:
			this.LblRadErgoCfgKMTrunkingKMButtonFeature_A19746 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgKMTrunkingKMButtonFeature_A19746.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_932:
			this.RadErgoCfgKMDataButtonName_A22601 = (global::AcpUI.AcpLabel)target;
			this.RadErgoCfgKMDataButtonName_A22601.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_956:
			this.CpyBtnRadErgoCfgKMTrunkingKMDatatButtonFeature_A22605 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_963:
			((global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.PageKeypadMicAndAccessories)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.PageKeypadMicAndAccessories)target).Unloaded += this.OnUnloaded;
			return;
			IL_994:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_9A1:
			this.RTDBtnRadErgoCfgKMConventionalKMDataButtonBCO_A22602 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_9AE:
			this.RadErgoCfgKMConventionalKMDatatButtonFeature_A22603_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_9BB:
			this.RadErgoCfgKMDataButtonName_A22601_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_9C8:
			this.CVBtnRadErgoCfgKMTrunkingKMButtonFeature_A19746 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_9D5:
			this.RadErgoCfgKMDataButtonKey_A22600_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_9E2:
			this.gridExpanderKeypadMicAndAccessoriesKMButtonSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_9EF:
			this.ExpanderKeypadMicAndAccessoriesKMANavigationControlsExpander = (global::AcpUI.AcpExpander)target;
			return;
			IL_9FC:
			this.LblRadErgoCfgKMConventionalKMDatatButtonIndex_A41423 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgKMConventionalKMDatatButtonIndex_A41423.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A20:
			this.RTDBtnRadErgoCfgKMConventionalKMDatatButtonIndex_A41423 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A2D:
			this.CpyBtnRadErgoCfgKMTrunkingKMButtonBCO_A19745 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A3A:
			this.RecNavToolbarExpanderKeypadMicAndAccessoriesKMANavigationControlsTable = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderKeypadMicAndAccessoriesKMANavigationControlsTable.ModeClick += this.OnModeClick;
			return;
			IL_A5E:
			this.RadErgoCfgKMTrunkingKMDataButtonBCO_A22604Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_A6B:
			this.LblRadErgoCfgKMDataButtonName_A22601 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgKMDataButtonName_A22601.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A8F:
			this.CVBtnRadErgoCfgKMTrunkingKMDatatButtonIndex_A41424 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A9C:
			this.RadErgoCfgKMConventionalKMButtonFeature_A19646Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_AA9:
			this.RadErgoCfgKMTrunkingKMButtonFeature_A19746Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_AB6:
			this.RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_ADA:
			this.RadErgoCfgKMConventionalKMDatatButtonIndex_A41423 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoCfgKMConventionalKMDatatButtonIndex_A41423.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_AFE:
			this.LblRadErgoControlKMANaviControlName_41759 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoControlKMANaviControlName_41759.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_B22:
			this.CpyBtnRadErgoCfgKMTrunkingKMDataButtonBCO_A22604 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B2F:
			this.RTDBtnRadErgoCfgKMConventionalKMDatatButtonFeature_A22603 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_B3C:
			this.RTDBtnRadErgoCfgKMTrunkingKMDataButtonBCO_A22604 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_B49:
			this.CpyBtnRadErgoCfgKMTrunkingKMDatatButtonIndex_A41424 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B56:
			this.RTDBtnRadErgoControlKMANaviControlName_41759 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_B63:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_B70:
			this.CpyBtnRadErgoCfgKMConventionalKMButtonFeature_A19646 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B7D:
			this.RadErgoCfgKMTrunkingKMDataButtonBCO_A22604 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoCfgKMTrunkingKMDataButtonBCO_A22604.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_BA1:
			this.RadErgoControlKMAUpDownButton_41760 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoControlKMAUpDownButton_41760.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_BC5:
			this.RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_BD2:
			this.ExpanderKeypadMicAndAccessoriesData = (global::AcpUI.AcpExpander)target;
			return;
			IL_BDF:
			this.myKeypadMicAndAccessoriesGraphicView = (global::ControlHeadGraphicView.KeypadMicAndAccessoriesGraphicView)target;
			return;
			IL_BEC:
			this.RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_BF9:
			this.LblRadErgoCfgKMTrunkingKMButtonBCO_A19745 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgKMTrunkingKMButtonBCO_A19745.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_C1D:
			this.CVBtnRadErgoCfgKMButtonKey_A22560 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_C2A:
			this.RadErgoControlKMAUpDownButton_41760Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_C37:
			this.RadErgoCfgKMConventionalKMDataButtonBCO_A22602_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_C44:
			this.ExpanderKeypadMicAndAccessoriesGraphicview = (global::AcpUI.AcpExpander)target;
			return;
			IL_C51:
			this.ExpanderKeypadMicAndAccessoriesKMButtonGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_C5E:
			this.ExpanderKeypadMicAndAccessoriesKMButton = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_C6B:
			this.RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_C78:
			this.RadErgoControlKMANaviControlName_41759 = (global::AcpUI.AcpLabel)target;
			this.RadErgoControlKMANaviControlName_41759.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_C9C:
			this.CpyBtnRadErgoCfgKMConventionalKMDatatButtonFeature_A22603 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_CA9:
			this.CVBtnRadErgoCfgKMDataButtonName_A22601 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_CB6:
			this.CVBtnRadErgoControlKMAUpDownButton_41760 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_CC3:
			this.RadErgoCfgKMButtonName_A22561Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_CD0:
			this.RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_CDD:
			this.CpyBtnRadErgoControlKMANaviControlName_41759 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_CEA:
			this.CpyBtnRadErgoControlKMAUpDownButton_41760 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_CF7:
			this.CVBtnRadErgoCfgKMTrunkingKMButtonBCO_A19745 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_D04:
			num = (short)661389312;
			short num4 = num;
			this.CpyBtnRadErgoCfgKMButtonName_A22561 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_D3A:
			this.LblRadErgoCfgKMConventionalKMDatatButtonFeature_A22603 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgKMConventionalKMDatatButtonFeature_A22603.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_D5E:
			this.RadErgoControlKMANaviControlName_41759Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_D6B:
			this.RadErgoControlKMAUpDownButton_41760_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_D78:
			this.RTDBtnRadErgoCfgKMConventionalKMButtonFeature_A19646 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_D85:
			this.RadErgoCfgKMTrunkingKMButtonBCO_A19745Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_D92:
			this.ExpanderKeypadMicAndAccessoriesKMANavigationControlsTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_D9F:
			this.RadErgoCfgKMDataButtonName_A22601Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_DAC:
			this.RecNavToolbarExpanderKeypadMicAndAccessoriesDataButton = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderKeypadMicAndAccessoriesDataButton.ModeClick += this.OnModeClick;
			return;
			IL_DD0:
			this.RecNavToolbarExpanderKeypadMicAndAccessoriesKMButton = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderKeypadMicAndAccessoriesKMButton.ModeClick += this.OnModeClick;
			return;
			IL_DF4:
			this.HLinkKMANavigationControlsExpander = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkKMANavigationControlsExpander.Click += this.HLinkClick;
			return;
			IL_E18:
			this.gridExpanderKeypadMicAndAccessoriesDataButtonSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_E25:
			this.RTDBtnRadErgoControlKMAUpDownButton_41760 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_E32:
			this.ExpanderKeypadMicAndAccessoriesKMButtonTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_E3F:
			this.CVBtnRadErgoCfgKMButtonName_A22561 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_E4C:
			this.LblRadErgoCfgKMDataButtonKey_A22600 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgKMDataButtonKey_A22600.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_E70:
			this.b = true;
		}

		// Token: 0x06007C26 RID: 31782 RVA: 0x0071E73C File Offset: 0x0071C93C
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
			{
				short num = (short)1384841216;
				short num2 = num;
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			case 4:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 5:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 6:
				break;
			case 7:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 8:
				((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
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
			{
				short num = (short)1581081514;
				short num3 = num;
				num = (short)400122794;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1369964544;
					if (num != 0)
					{
					}
					((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				}
				break;
			}
			case 13:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 14:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 15:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 16:
				((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 17:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			default:
			{
				short num = (short)539820033;
				if (num != 0)
				{
				}
				return;
			}
			}
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x04003732 RID: 14130
		private bool a;

		// Token: 0x04003733 RID: 14131
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x04003734 RID: 14132
		internal global::System.Windows.Documents.Hyperlink HLinkKeypadMicAndAccessoriesGraphicview;

		// Token: 0x04003735 RID: 14133
		internal global::System.Windows.Documents.Hyperlink HLinkGeneral;

		// Token: 0x04003736 RID: 14134
		internal global::System.Windows.Documents.Hyperlink HLinkData;

		// Token: 0x04003737 RID: 14135
		internal global::System.Windows.Documents.Hyperlink HLinkKMANavigationControlsExpander;

		// Token: 0x04003738 RID: 14136
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x04003739 RID: 14137
		internal global::AcpUI.AcpExpander ExpanderKeypadMicAndAccessoriesGraphicview;

		// Token: 0x0400373A RID: 14138
		internal global::ControlHeadGraphicView.KeypadMicAndAccessoriesGraphicView myKeypadMicAndAccessoriesGraphicView;

		// Token: 0x0400373B RID: 14139
		internal global::AcpUI.AcpExpander ExpanderKeypadMicAndAccessoriesGeneral;

		// Token: 0x0400373C RID: 14140
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderKeypadMicAndAccessoriesKMButton;

		// Token: 0x0400373D RID: 14141
		internal global::System.Windows.Controls.Grid ExpanderKeypadMicAndAccessoriesGeneralGrid;

		// Token: 0x0400373E RID: 14142
		internal global::System.Windows.Controls.Grid ExpanderKeypadMicAndAccessoriesKMButtonGrid;

		// Token: 0x0400373F RID: 14143
		internal global::AcpUI.AcpGroupBox ExpanderKeypadMicAndAccessoriesKMButtonTableView;

		// Token: 0x04003740 RID: 14144
		internal global::AcpUI.AcpXamDataPresenter ExpanderKeypadMicAndAccessoriesKMButton;

		// Token: 0x04003741 RID: 14145
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoCfgKMButtonName_A22561_Col;

		// Token: 0x04003742 RID: 14146
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoCfgKMConventionalKMButtonBCO_A19643_Col;

		// Token: 0x04003743 RID: 14147
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoCfgKMConventionalKMButtonFeature_A19646_Col;

		// Token: 0x04003744 RID: 14148
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoCfgKMTrunkingKMButtonBCO_A19745_Col;

		// Token: 0x04003745 RID: 14149
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoCfgKMTrunkingKMButtonFeature_A19746_Col;

		// Token: 0x04003746 RID: 14150
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoCfgKMButtonKey_A22560_Col;

		// Token: 0x04003747 RID: 14151
		internal global::AcpUI.AcpGroupBox ExpanderKeypadMicAndAccessoriesKMButtonSRecView;

		// Token: 0x04003748 RID: 14152
		internal global::System.Windows.Controls.Grid gridExpanderKeypadMicAndAccessoriesKMButtonSRecView;

		// Token: 0x04003749 RID: 14153
		internal global::AcpUI.AcpLabel RadErgoCfgKMButtonName_A22561;

		// Token: 0x0400374A RID: 14154
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgKMButtonName_A22561;

		// Token: 0x0400374B RID: 14155
		internal global::AcpUI.AcpLabel LblRadErgoCfgKMButtonName_A22561;

		// Token: 0x0400374C RID: 14156
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgKMButtonName_A22561;

		// Token: 0x0400374D RID: 14157
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgKMButtonName_A22561;

		// Token: 0x0400374E RID: 14158
		internal global::AcpUI.AcpLabel RadErgoCfgKMButtonName_A22561Comp;

		// Token: 0x0400374F RID: 14159
		internal global::AcpUI.AcpComboBox RadErgoCfgKMConventionalKMButtonBCO_A19643;

		// Token: 0x04003750 RID: 14160
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgKMConventionalKMButtonBCO_A19643;

		// Token: 0x04003751 RID: 14161
		internal global::AcpUI.AcpLabel LblRadErgoCfgKMConventionalKMButtonBCO_A19643;

		// Token: 0x04003752 RID: 14162
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgKMConventionalKMButtonBCO_A19643;

		// Token: 0x04003753 RID: 14163
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgKMConventionalKMButtonBCO_A19643;

		// Token: 0x04003754 RID: 14164
		internal global::AcpUI.AcpLabel RadErgoCfgKMConventionalKMButtonBCO_A19643Comp;

		// Token: 0x04003755 RID: 14165
		internal global::AcpUI.AcpComboBox RadErgoCfgKMConventionalKMButtonFeature_A19646;

		// Token: 0x04003756 RID: 14166
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgKMConventionalKMButtonFeature_A19646;

		// Token: 0x04003757 RID: 14167
		internal global::AcpUI.AcpLabel LblRadErgoCfgKMConventionalKMButtonFeature_A19646;

		// Token: 0x04003758 RID: 14168
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgKMConventionalKMButtonFeature_A19646;

		// Token: 0x04003759 RID: 14169
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgKMConventionalKMButtonFeature_A19646;

		// Token: 0x0400375A RID: 14170
		internal global::AcpUI.AcpLabel RadErgoCfgKMConventionalKMButtonFeature_A19646Comp;

		// Token: 0x0400375B RID: 14171
		internal global::AcpUI.AcpComboBox RadErgoCfgKMTrunkingKMButtonBCO_A19745;

		// Token: 0x0400375C RID: 14172
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgKMTrunkingKMButtonBCO_A19745;

		// Token: 0x0400375D RID: 14173
		internal global::AcpUI.AcpLabel LblRadErgoCfgKMTrunkingKMButtonBCO_A19745;

		// Token: 0x0400375E RID: 14174
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgKMTrunkingKMButtonBCO_A19745;

		// Token: 0x0400375F RID: 14175
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgKMTrunkingKMButtonBCO_A19745;

		// Token: 0x04003760 RID: 14176
		internal global::AcpUI.AcpLabel RadErgoCfgKMTrunkingKMButtonBCO_A19745Comp;

		// Token: 0x04003761 RID: 14177
		internal global::AcpUI.AcpComboBox RadErgoCfgKMTrunkingKMButtonFeature_A19746;

		// Token: 0x04003762 RID: 14178
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgKMTrunkingKMButtonFeature_A19746;

		// Token: 0x04003763 RID: 14179
		internal global::AcpUI.AcpLabel LblRadErgoCfgKMTrunkingKMButtonFeature_A19746;

		// Token: 0x04003764 RID: 14180
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgKMTrunkingKMButtonFeature_A19746;

		// Token: 0x04003765 RID: 14181
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgKMTrunkingKMButtonFeature_A19746;

		// Token: 0x04003766 RID: 14182
		internal global::AcpUI.AcpLabel RadErgoCfgKMTrunkingKMButtonFeature_A19746Comp;

		// Token: 0x04003767 RID: 14183
		internal global::AcpUI.AcpTextBox RadErgoCfgKMButtonKey_A22560;

		// Token: 0x04003768 RID: 14184
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgKMButtonKey_A22560;

		// Token: 0x04003769 RID: 14185
		internal global::AcpUI.AcpLabel LblRadErgoCfgKMButtonKey_A22560;

		// Token: 0x0400376A RID: 14186
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgKMButtonKey_A22560;

		// Token: 0x0400376B RID: 14187
		internal global::AcpUI.AcpLabel RadErgoCfgKMButtonKey_A22560Comp;

		// Token: 0x0400376C RID: 14188
		internal global::AcpUI.AcpExpander ExpanderKeypadMicAndAccessoriesData;

		// Token: 0x0400376D RID: 14189
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderKeypadMicAndAccessoriesDataButton;

		// Token: 0x0400376E RID: 14190
		internal global::System.Windows.Controls.Grid ExpanderKeypadMicAndAccessoriesDataGrid;

		// Token: 0x0400376F RID: 14191
		internal global::System.Windows.Controls.Grid ExpanderKeypadMicAndAccessoriesDataButtonGrid;

		// Token: 0x04003770 RID: 14192
		internal global::AcpUI.AcpGroupBox ExpanderKeypadMicAndAccessoriesDataButtonTableView;

		// Token: 0x04003771 RID: 14193
		internal global::AcpUI.AcpXamDataPresenter ExpanderKeypadMicAndAccessoriesDataButton;

		// Token: 0x04003772 RID: 14194
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoCfgKMDataButtonName_A22601_Col;

		// Token: 0x04003773 RID: 14195
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoCfgKMConventionalKMDataButtonBCO_A22602_Col;

		// Token: 0x04003774 RID: 14196
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoCfgKMConventionalKMDatatButtonFeature_A22603_Col;

		// Token: 0x04003775 RID: 14197
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoCfgKMConventionalKMDatatButtonIndex_A41423_Col;

		// Token: 0x04003776 RID: 14198
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoCfgKMTrunkingKMDataButtonBCO_A22604_Col;

		// Token: 0x04003777 RID: 14199
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605_Col;

		// Token: 0x04003778 RID: 14200
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424_Col;

		// Token: 0x04003779 RID: 14201
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoCfgKMDataButtonKey_A22600_Col;

		// Token: 0x0400377A RID: 14202
		internal global::AcpUI.AcpGroupBox ExpanderKeypadMicAndAccessoriesDataButtonSRecView;

		// Token: 0x0400377B RID: 14203
		internal global::System.Windows.Controls.Grid gridExpanderKeypadMicAndAccessoriesDataButtonSRecView;

		// Token: 0x0400377C RID: 14204
		internal global::AcpUI.AcpLabel RadErgoCfgKMDataButtonName_A22601;

		// Token: 0x0400377D RID: 14205
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgKMDataButtonName_A22601;

		// Token: 0x0400377E RID: 14206
		internal global::AcpUI.AcpLabel LblRadErgoCfgKMDataButtonName_A22601;

		// Token: 0x0400377F RID: 14207
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgKMDataButtonName_A22601;

		// Token: 0x04003780 RID: 14208
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgKMDataButtonName_A22601;

		// Token: 0x04003781 RID: 14209
		internal global::AcpUI.AcpLabel RadErgoCfgKMDataButtonName_A22601Comp;

		// Token: 0x04003782 RID: 14210
		internal global::AcpUI.AcpComboBox RadErgoCfgKMConventionalKMDataButtonBCO_A22602;

		// Token: 0x04003783 RID: 14211
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgKMConventionalKMDataButtonBCO_A22602;

		// Token: 0x04003784 RID: 14212
		internal global::AcpUI.AcpLabel LblRadErgoCfgKMConventionalKMDataButtonBCO_A22602;

		// Token: 0x04003785 RID: 14213
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgKMConventionalKMDataButtonBCO_A22602;

		// Token: 0x04003786 RID: 14214
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgKMConventionalKMDataButtonBCO_A22602;

		// Token: 0x04003787 RID: 14215
		internal global::AcpUI.AcpLabel RadErgoCfgKMConventionalKMDataButtonBCO_A22602Comp;

		// Token: 0x04003788 RID: 14216
		internal global::AcpUI.AcpComboBox RadErgoCfgKMConventionalKMDatatButtonFeature_A22603;

		// Token: 0x04003789 RID: 14217
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgKMConventionalKMDatatButtonFeature_A22603;

		// Token: 0x0400378A RID: 14218
		internal global::AcpUI.AcpLabel LblRadErgoCfgKMConventionalKMDatatButtonFeature_A22603;

		// Token: 0x0400378B RID: 14219
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgKMConventionalKMDatatButtonFeature_A22603;

		// Token: 0x0400378C RID: 14220
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgKMConventionalKMDatatButtonFeature_A22603;

		// Token: 0x0400378D RID: 14221
		internal global::AcpUI.AcpLabel RadErgoCfgKMConventionalKMDatatButtonFeature_A22603Comp;

		// Token: 0x0400378E RID: 14222
		internal global::AcpUI.AcpComboBox RadErgoCfgKMConventionalKMDatatButtonIndex_A41423;

		// Token: 0x0400378F RID: 14223
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgKMConventionalKMDatatButtonIndex_A41423;

		// Token: 0x04003790 RID: 14224
		internal global::AcpUI.AcpLabel LblRadErgoCfgKMConventionalKMDatatButtonIndex_A41423;

		// Token: 0x04003791 RID: 14225
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgKMConventionalKMDatatButtonIndex_A41423;

		// Token: 0x04003792 RID: 14226
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgKMConventionalKMDatatButtonIndex_A41423;

		// Token: 0x04003793 RID: 14227
		internal global::AcpUI.AcpLabel RadErgoCfgKMConventionalKMDatatButtonIndex_A41423Comp;

		// Token: 0x04003794 RID: 14228
		internal global::AcpUI.AcpComboBox RadErgoCfgKMTrunkingKMDataButtonBCO_A22604;

		// Token: 0x04003795 RID: 14229
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgKMTrunkingKMDataButtonBCO_A22604;

		// Token: 0x04003796 RID: 14230
		internal global::AcpUI.AcpLabel LblRadErgoCfgKMTrunkingKMDataButtonBCO_A22604;

		// Token: 0x04003797 RID: 14231
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgKMTrunkingKMDataButtonBCO_A22604;

		// Token: 0x04003798 RID: 14232
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgKMTrunkingKMDataButtonBCO_A22604;

		// Token: 0x04003799 RID: 14233
		internal global::AcpUI.AcpLabel RadErgoCfgKMTrunkingKMDataButtonBCO_A22604Comp;

		// Token: 0x0400379A RID: 14234
		internal global::AcpUI.AcpComboBox RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605;

		// Token: 0x0400379B RID: 14235
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgKMTrunkingKMDatatButtonFeature_A22605;

		// Token: 0x0400379C RID: 14236
		internal global::AcpUI.AcpLabel LblRadErgoCfgKMTrunkingKMDatatButtonFeature_A22605;

		// Token: 0x0400379D RID: 14237
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgKMTrunkingKMDatatButtonFeature_A22605;

		// Token: 0x0400379E RID: 14238
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgKMTrunkingKMDatatButtonFeature_A22605;

		// Token: 0x0400379F RID: 14239
		internal global::AcpUI.AcpLabel RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605Comp;

		// Token: 0x040037A0 RID: 14240
		internal global::AcpUI.AcpComboBox RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424;

		// Token: 0x040037A1 RID: 14241
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgKMTrunkingKMDatatButtonIndex_A41424;

		// Token: 0x040037A2 RID: 14242
		internal global::AcpUI.AcpLabel LblRadErgoCfgKMTrunkingKMDatatButtonIndex_A41424;

		// Token: 0x040037A3 RID: 14243
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgKMTrunkingKMDatatButtonIndex_A41424;

		// Token: 0x040037A4 RID: 14244
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgKMTrunkingKMDatatButtonIndex_A41424;

		// Token: 0x040037A5 RID: 14245
		internal global::AcpUI.AcpLabel RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424Comp;

		// Token: 0x040037A6 RID: 14246
		internal global::AcpUI.AcpTextBox RadErgoCfgKMDataButtonKey_A22600;

		// Token: 0x040037A7 RID: 14247
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgKMDataButtonKey_A22600;

		// Token: 0x040037A8 RID: 14248
		internal global::AcpUI.AcpLabel LblRadErgoCfgKMDataButtonKey_A22600;

		// Token: 0x040037A9 RID: 14249
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgKMDataButtonKey_A22600;

		// Token: 0x040037AA RID: 14250
		internal global::AcpUI.AcpLabel RadErgoCfgKMDataButtonKey_A22600Comp;

		// Token: 0x040037AB RID: 14251
		internal global::AcpUI.AcpExpander ExpanderKeypadMicAndAccessoriesKMANavigationControlsExpander;

		// Token: 0x040037AC RID: 14252
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderKeypadMicAndAccessoriesKMANavigationControlsTable;

		// Token: 0x040037AD RID: 14253
		internal global::System.Windows.Controls.Grid ExpanderKeypadMicAndAccessoriesKMANavigationControlsExpanderGrid;

		// Token: 0x040037AE RID: 14254
		internal global::System.Windows.Controls.Grid ExpanderKeypadMicAndAccessoriesKMANavigationControlsTableGrid;

		// Token: 0x040037AF RID: 14255
		internal global::AcpUI.AcpGroupBox ExpanderKeypadMicAndAccessoriesKMANavigationControlsTableTableView;

		// Token: 0x040037B0 RID: 14256
		internal global::AcpUI.AcpXamDataPresenter ExpanderKeypadMicAndAccessoriesKMANavigationControlsTable;

		// Token: 0x040037B1 RID: 14257
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoControlKMANaviControlName_41759_Col;

		// Token: 0x040037B2 RID: 14258
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoControlKMAUpDownButton_41760_Col;

		// Token: 0x040037B3 RID: 14259
		internal global::AcpUI.AcpGroupBox ExpanderKeypadMicAndAccessoriesKMANavigationControlsTableSRecView;

		// Token: 0x040037B4 RID: 14260
		internal global::System.Windows.Controls.Grid gridExpanderKeypadMicAndAccessoriesKMANavigationControlsTableSRecView;

		// Token: 0x040037B5 RID: 14261
		internal global::AcpUI.AcpLabel RadErgoControlKMANaviControlName_41759;

		// Token: 0x040037B6 RID: 14262
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoControlKMANaviControlName_41759;

		// Token: 0x040037B7 RID: 14263
		internal global::AcpUI.AcpLabel LblRadErgoControlKMANaviControlName_41759;

		// Token: 0x040037B8 RID: 14264
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoControlKMANaviControlName_41759;

		// Token: 0x040037B9 RID: 14265
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoControlKMANaviControlName_41759;

		// Token: 0x040037BA RID: 14266
		internal global::AcpUI.AcpLabel RadErgoControlKMANaviControlName_41759Comp;

		// Token: 0x040037BB RID: 14267
		internal global::AcpUI.AcpComboBox RadErgoControlKMAUpDownButton_41760;

		// Token: 0x040037BC RID: 14268
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoControlKMAUpDownButton_41760;

		// Token: 0x040037BD RID: 14269
		internal global::AcpUI.AcpLabel LblRadErgoControlKMAUpDownButton_41760;

		// Token: 0x040037BE RID: 14270
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoControlKMAUpDownButton_41760;

		// Token: 0x040037BF RID: 14271
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoControlKMAUpDownButton_41760;

		// Token: 0x040037C0 RID: 14272
		internal global::AcpUI.AcpLabel RadErgoControlKMAUpDownButton_41760Comp;

		// Token: 0x040037C1 RID: 14273
		private bool b;
	}
}
