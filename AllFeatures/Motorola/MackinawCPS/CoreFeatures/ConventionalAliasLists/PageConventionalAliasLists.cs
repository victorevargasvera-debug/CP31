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

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists
{
	// Token: 0x020005CF RID: 1487
	public class PageConventionalAliasLists : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x0600CE58 RID: 52824 RVA: 0x00BFFFB8 File Offset: 0x00BFE1B8
		public PageConventionalAliasLists()
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

		// Token: 0x0600CE59 RID: 52825 RVA: 0x00BFFFF0 File Offset: 0x00BFE1F0
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1608843264;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)624033801;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					object obj;
					global::AcpUI.AcpExpander acpExpander;
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						if (obj != null)
						{
							num = (short)1893269511;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_254;
					case 1:
					{
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderConventionalAliasListsMessageAliasTable.MyDataPresenter = this.ExpanderConventionalAliasListsMessageAliasTable;
						num = (short)1715470342;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)2131361793;
						if (num != 0)
						{
						}
						if (obj != null)
						{
							num = (short)258801665;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3C5;
					case 3:
						obj = null;
						obj = this.RecNavToolbarExpanderConventionalAliasListsMessageAliasTable.MyRecordsetDataSource;
						num = (short)1225981954;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						try
						{
							num = (short)1959526406;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									if (acpExpander != null)
									{
										num = (short)1332412419;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 2:
									num = (short)1078394884;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									base.Expanders.Add(acpExpander);
									num = (short)368443393;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_18E;
								case 5:
									if (!enumerator.MoveNext())
									{
										num = (short)1579483138;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
									num = (short)1354825728;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_D3;
									}
									continue;
								}
								IL_117:
								num = (short)1563885573;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_D3:
								goto IL_117;
							}
							IL_18E:
							goto IL_2C0;
						}
						finally
						{
							global::System.IDisposable disposable;
							switch (0)
							{
							case 0:
								break;
							default:
								for (;;)
								{
									IL_19D:
									switch (num2)
									{
									case 0:
										goto IL_251;
									case 1:
									{
										num = (short)1200105743;
										short num3 = num;
										num = (short)208414991;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_1B7;
										default:
											num = (short)791019520;
											if (num != 0)
											{
											}
											disposable.Dispose();
											num = (short)377487360;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 2:
										if (disposable != null)
										{
											num = (short)2032009217;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_253;
									}
									goto IL_1B0;
								}
								IL_251:
								IL_253:
								goto EndFinally_9;
							}
							IL_1B0:
							disposable = (enumerator as global::System.IDisposable);
							IL_1B7:
							num = (short)2105147394;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_19D;
							EndFinally_9:;
						}
						goto IL_254;
						IL_2C0:
						base.OnLoaded(sender, e);
						this.a = true;
						num = (short)555679752;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						num = (short)1804140544;
						short num4 = num;
						goto IL_254;
					}
					case 6:
						goto IL_3C5;
					case 7:
					{
						global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderConventionalAliasListsStatusAliasTable.MyDataPresenter = this.ExpanderConventionalAliasListsStatusAliasTable;
						num = (short)293404677;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_2E8;
					case 9:
						switch (0)
						{
						case 0:
							goto IL_6C;
						}
						continue;
					}
					IL_6C:
					if (!this.a)
					{
						num = (short)2138505219;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_254:
					acpExpander = null;
					enumerator = this.MyStackPanel.Children.GetEnumerator();
					num = (short)195559428;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3C5:
					obj = this.RecNavToolbarExpanderConventionalAliasListsStatusAliasTable.MyRecordsetDataSource;
					num = (short)1346961408;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2E8:
				this.MyStackPanel.Children[0].Focus();
				return;
			}
		}

		// Token: 0x0600CE5A RID: 52826 RVA: 0x00C00440 File Offset: 0x00BFE640
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			int num;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						return;
					case 1:
					{
						num2 = (short)1579891358;
						short num3 = num2;
						num2 = (short)589904542;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4C;
						default:
						{
							num2 = (short)1678245888;
							if (num2 != 0)
							{
							}
							num2 = (short)70516736;
							short num4 = num2;
							base.OnUnloaded(sender, e);
							this.a = false;
							num2 = (short)1147863040;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 2:
						num2 = (short)386596865;
						if (num2 != 0)
						{
						}
						if (this.a)
						{
							num2 = (short)451739649;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					goto IL_1C;
				}
				return;
			}
			IL_1C:
			this.RecNavToolbarExpanderConventionalAliasListsMessageAliasTable.DataContext = null;
			this.RecNavToolbarExpanderConventionalAliasListsStatusAliasTable.DataContext = null;
			this.RecNavToolbarExpanderConventionalAliasListsMessageAliasTable.MyDataPresenter = null;
			this.RecNavToolbarExpanderConventionalAliasListsStatusAliasTable.MyDataPresenter = null;
			IL_4C:
			num2 = (short)1704984578;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600CE5B RID: 52827 RVA: 0x00C00598 File Offset: 0x00BFE798
		public override void SetDataContext()
		{
			short num = (short)1450494416;
			short num2 = num;
			num = (short)1051249104;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_32D:
				num = (short)405864454;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)511967232;
				if (num != 0)
				{
				}
				num = (short)1436352533;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			object feature;
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_3C1;
				case 1:
					goto IL_189;
				case 2:
					num = (short)1583087635;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)420282372;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10012] != null)
					{
						num = (short)1670053899;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3C1;
				case 5:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10012].EmbeddedRecset != null)
					{
						goto IL_32D;
					}
					goto IL_3C1;
				case 6:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderConventionalAliasListsMessageAliasTable).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10012].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderConventionalAliasListsMessageAliasTable).SyncDataSources();
					num = (short)957808640;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10014].EmbeddedRecset != null)
					{
						num = (short)1930756109;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 8:
					if (feature != null)
					{
						num = (short)944832521;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3C1;
				case 9:
					num = (short)2014707724;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (feature != null)
					{
						num = (short)826867714;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 11:
				{
					num = (short)300220416;
					short num4 = num;
					num = (short)725155845;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 12:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)1369767939;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3C1;
				case 13:
					goto IL_219;
				case 14:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)83886097;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderConventionalAliasListsMessageAliasTable).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderConventionalAliasListsStatusAliasTable).MySecondaryRecordsetDataSource = null;
					num = (short)418054166;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					num = (short)984612871;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					num = (short)1912864788;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2007);
					num = (short)860880904;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					goto IL_189;
				case 19:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)1659502608;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 20:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10014] != null)
					{
						num = (short)159973391;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 21:
					switch (0)
					{
					case 0:
						goto IL_CF;
					}
					continue;
				case 22:
					goto IL_2C8;
				case 23:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2007);
					num = (short)1406730241;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_CF:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)2095775767;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2007);
				num = (short)723255314;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_189:
				num = (short)452263950;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_3C1:
				num = (short)1441005578;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_219:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderConventionalAliasListsStatusAliasTable).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10014].EmbeddedRecset;
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderConventionalAliasListsStatusAliasTable).SyncDataSources();
			return;
			IL_2C8:
			num = (short)849739777;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600CE5C RID: 52828 RVA: 0x00C00A8C File Offset: 0x00BFEC8C
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 17;
			short num = (short)50528256;
			switch (num)
			{
			default:
			{
				num = (short)1147076618;
				int num2 = (int)((global::System.IntPtr)num);
				object myRecordsetDataSource;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_108;
					case 1:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1955135489;
							if (num != 0)
							{
							}
							num = (short)1825112076;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)748158985;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1180237838;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)348717067;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)613154821;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (myRecordsetDataSource != null)
						{
							num = (short)269746176;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 5:
						goto IL_238;
					case 6:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("胑뇓뗕雗믙ꫛ諝迟跡裣蓥觧飩ꧫ雭胯鏱髳鋵鷷裹뿻釽滿琁愃栅簇按挋怍焏縑唓稕焗笙漛初䤟儡倣唥笧帩䴫娭䔯䄱申娵儷嬹伻樽ℿ⁁⡃⍅", a_))
						{
							num = (short)1282408456;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 7:
						goto IL_10D;
					case 8:
						num = (short)18481153;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						return;
					case 10:
						switch (0)
						{
						case 0:
							goto IL_92;
						}
						continue;
					case 11:
						goto IL_10D;
					case 12:
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						myRecordsetDataSource = this.RecNavToolbarExpanderConventionalAliasListsStatusAliasTable.MyRecordsetDataSource;
						num = (short)1789657092;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)1585643522;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
					{
						num = (short)1333407289;
						short num3 = num;
						num = (short)1380789817;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_238;
						default:
						{
							num = (short)582090752;
							if (num != 0)
							{
							}
							num = (short)320929792;
							short num4 = num;
							((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
							object myRecordsetDataSource2 = this.RecNavToolbarExpanderConventionalAliasListsMessageAliasTable.MyRecordsetDataSource;
							num = (short)779550735;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 15:
					{
						object myRecordsetDataSource2;
						if (myRecordsetDataSource2 != null)
						{
							num = (short)136511504;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10D;
					}
					case 16:
					{
						object myRecordsetDataSource2;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource2);
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.MessageAliasTableInner item = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.MessageAliasTableInner)collectionView.CurrentItem;
						collectionView.MoveCurrentTo(item);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)344850439;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_92:
					if (A_0 is global::AcpUI.AcpRecNavToolbar)
					{
						num = (short)459669507;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_10D:
					num = (short)585236486;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_238:
					if (!(((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("胑뇓뗕雗믙ꫛ諝迟跡裣蓥觧飩ꧫ雭胯鏱髳鋵鷷裹뿻釽滿琁愃栅簇按挋怍焏縑唓稕焗笙漛初䤟儡倣唥攧伩弫崭儯唱儳眵吷匹崻䴽ᐿ⍁♃⩅ⵇ", a_)))
					{
						goto IL_10D;
					}
					num = (short)766509069;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_108:
				global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.StatusAliasTableInner item2 = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.StatusAliasTableInner)collectionView2.CurrentItem;
				collectionView2.MoveCurrentTo(item2);
				((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
				return;
			}
			}
		}

		// Token: 0x0600CE5D RID: 52829 RVA: 0x00C00E98 File Offset: 0x00BFF098
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)703528960;
			short num2 = num;
			num = (short)196703855;
			short num3 = num;
			num = (short)924350063;
			switch (num3 == num)
			{
			}
			num = (short)272891905;
			if (num != 0)
			{
			}
			num = (short)540999680;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x0600CE5E RID: 52830 RVA: 0x00C00F48 File Offset: 0x00BFF148
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)525008896;
			short num2 = num;
			num = (short)1409784182;
			short num3 = num;
			num = (short)690723190;
			switch (num3 == num)
			{
			}
			num = (short)969932801;
			if (num != 0)
			{
			}
			num = (short)91029504;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x0600CE5F RID: 52831 RVA: 0x00C00FFC File Offset: 0x00BFF1FC
		internal void OnExpanderConventionalAliasListsMessageAliasTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.MessageAliasTableInner item;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)787939329;
					if (num2 != 0)
					{
					}
					if (myRecordsetDataSource != null)
					{
						num2 = (short)1817509889;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_159;
				case 1:
				{
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderConventionalAliasListsMessageAliasTable.SyncDataSources();
					num2 = (short)1787859476;
					short num3 = num2;
					num2 = (short)1304138260;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1012924416;
						if (num2 != 0)
						{
						}
						num2 = (short)75497474;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					goto IL_157;
				}
				goto IL_1C;
			}
			IL_157:
			IL_159:
			this.RecNavToolbarExpanderConventionalAliasListsMessageAliasTable.TableMode = false;
			return;
			IL_1C:
			num2 = (short)819003392;
			short num4 = num2;
			item = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.MessageAliasTableInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderConventionalAliasListsMessageAliasTable.MyRecordsetDataSource;
			num2 = (short)1255669760;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600CE60 RID: 52832 RVA: 0x00C01170 File Offset: 0x00BFF370
		internal void OnExpanderConventionalAliasListsStatusAliasTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			object myRecordsetDataSource;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.StatusAliasTableInner item;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (myRecordsetDataSource != null)
					{
						num2 = (short)283770881;
						if (num2 != 0)
						{
						}
						num2 = (short)1330774017;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_157;
				case 1:
				{
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderConventionalAliasListsStatusAliasTable.SyncDataSources();
					num2 = (short)653873979;
					short num3 = num2;
					num2 = (short)250893115;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1654325248;
						if (num2 != 0)
						{
						}
						num2 = (short)10485762;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					goto IL_155;
				}
				goto IL_1C;
			}
			IL_155:
			IL_157:
			this.RecNavToolbarExpanderConventionalAliasListsStatusAliasTable.TableMode = false;
			return;
			IL_1C:
			num2 = (short)1784020992;
			short num4 = num2;
			item = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.StatusAliasTableInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderConventionalAliasListsStatusAliasTable.MyRecordsetDataSource;
			num2 = (short)25231360;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600CE61 RID: 52833 RVA: 0x00C012E0 File Offset: 0x00BFF4E0
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 6;
			while (this.b)
			{
				short num = (short)101668729;
				short num2 = num;
				num = (short)1013405561;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)97845249;
					if (num != 0)
					{
					}
					num = (short)1283325952;
					if (num != 0)
					{
					}
					num = (short)1246887936;
					short num3 = num;
					return;
				}
				}
			}
			this.b = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("裈ꟊꇌ觎듐닒ꇔꋖꯘ뻚껜苠賢裤韦蛨藪裬臮藰\udcf2雴飶韸跺飼釾甀樂樄椆栈朊⠌㴎ℐ瀒稔礖缘爚稜樞匠䈢儤並䘨䔪Ȭ䰮帰崲䌴制圸伺吼倾⽀≂⥄扆筈筊ⱌ⍎㡐㉒♔牖歘歚ㅜ㙞በᝢᙤ䡦੨Ѫͬ᥮ᑰᵲŴṶᙸᕺᱼ፾愈ﲎ뮔", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600CE62 RID: 52834 RVA: 0x00C013C4 File Offset: 0x00BFF5C4
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)902297894;
			short num2 = num;
			num = (short)953088294;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1298989056;
				if (num != 0)
				{
				}
				num = (short)716308480;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_7C;
						}
						continue;
					case 1:
						num = (short)1499267074;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_24E;
					}
					IL_7C:
					switch (connectionId)
					{
					case 1:
						goto IL_3B4;
					case 2:
					case 3:
					case 4:
					case 5:
						goto IL_5AE;
					case 6:
						goto IL_48F;
					case 7:
						goto IL_4E7;
					case 8:
						goto IL_46B;
					case 9:
						goto IL_4B6;
					case 10:
						goto IL_1CF;
					case 11:
						goto IL_260;
					case 12:
						goto IL_383;
					case 13:
						goto IL_253;
					case 14:
						goto IL_18E;
					case 15:
						goto IL_338;
					case 16:
						goto IL_203;
					case 17:
						goto IL_26D;
					case 18:
						goto IL_376;
					case 19:
						goto IL_369;
					case 20:
						goto IL_32B;
					case 21:
						goto IL_57D;
					case 22:
						goto IL_4A9;
					case 23:
						goto IL_2C2;
					case 24:
						goto IL_22A;
					case 25:
						goto IL_2E6;
					case 26:
						goto IL_409;
					case 27:
						goto IL_423;
					case 28:
						goto IL_50B;
					case 29:
						goto IL_3E5;
					case 30:
						goto IL_3A7;
					case 31:
						goto IL_1F6;
					case 32:
						goto IL_181;
					case 33:
						goto IL_525;
					case 34:
						goto IL_5A1;
					case 35:
						goto IL_31E;
					case 36:
						goto IL_570;
					case 37:
						goto IL_1DC;
					case 38:
						goto IL_518;
					case 39:
						goto IL_174;
					case 40:
						goto IL_556;
					case 41:
						goto IL_4DA;
					case 42:
						goto IL_29E;
					case 43:
						goto IL_416;
					case 44:
						goto IL_345;
					case 45:
						goto IL_19B;
					case 46:
						goto IL_549;
					case 47:
						goto IL_210;
					case 48:
						goto IL_27A;
					case 49:
						goto IL_1E9;
					case 50:
						goto IL_447;
					case 51:
						goto IL_49C;
					case 52:
						goto IL_21D;
					case 53:
						goto IL_563;
					default:
						num = (short)981794817;
						num3 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_174:
				this.CnvAlsLstStatusAliasListStatusAliasText_A9192_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
				return;
				IL_181:
				this.ExpanderConventionalAliasListsStatusAliasList = (global::AcpUI.AcpExpander)target;
				return;
				IL_18E:
				this.ExpanderConventionalAliasListsMessageAliasTableGrid = (global::System.Windows.Controls.Grid)target;
				return;
				IL_19B:
				num = (short)237174785;
				if (num != 0)
				{
				}
				this.RTDBtnCnvAlsLstStatusAliasListStatusAliasNumber_A9191 = (global::AcpUI.AcpRtdButton)target;
				return;
				IL_1DC:
				this.ExpanderConventionalAliasListsStatusAliasTable = (global::AcpUI.AcpXamDataPresenter)target;
				return;
				IL_1E9:
				this.CVBtnCnvAlsLstStatusAliasListStatusAliasText_A9192 = (global::AcpUI.AcpCustomViewCheckBox)target;
				return;
				IL_1F6:
				this.CnvAlsLstMessageAliasListMessageAliasText_A8502Comp = (global::AcpUI.AcpLabel)target;
				return;
				IL_203:
				this.ExpanderConventionalAliasListsMessageAliasTable = (global::AcpUI.AcpXamDataPresenter)target;
				return;
				IL_210:
				this.CnvAlsLstStatusAliasListStatusAliasNumber_A9191Comp = (global::AcpUI.AcpLabel)target;
				return;
				IL_21D:
				this.CnvAlsLstStatusAliasListStatusAliasText_A9192Comp = (global::AcpUI.AcpLabel)target;
				return;
				IL_22A:
				this.RTDBtnCnvAlsLstMessageAliasListMessageAliasNumber_A8501 = (global::AcpUI.AcpRtdButton)target;
				return;
				IL_24E:
				goto IL_5AE;
				IL_253:
				this.ExpanderConventionalAliasListsMessageAliasListGrid = (global::System.Windows.Controls.Grid)target;
				return;
				IL_260:
				this.ExpanderConventionalAliasListsMessageAliasList = (global::AcpUI.AcpExpander)target;
				return;
				IL_26D:
				this.CnvAlsLstMessageAliasListMessageAliasNumber_A8501_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
				return;
				IL_27A:
				this.CnvAlsLstStatusAliasListStatusAliasText_A9192 = (global::AcpUI.AcpTextBox)target;
				this.CnvAlsLstStatusAliasListStatusAliasText_A9192.GotFocus += this.OnFieldNameDoubleClick;
				return;
				IL_29E:
				this.CnvAlsLstStatusAliasListStatusAliasNumber_A9191 = (global::AcpUI.AcpTextBoxSpinner)target;
				this.CnvAlsLstStatusAliasListStatusAliasNumber_A9191.GotFocus += this.OnFieldNameDoubleClick;
				return;
				IL_2C2:
				this.LblCnvAlsLstMessageAliasListMessageAliasNumber_A8501 = (global::AcpUI.AcpLabel)target;
				this.LblCnvAlsLstMessageAliasListMessageAliasNumber_A8501.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
				return;
				IL_2E6:
				num = (short)1199439872;
				short num4 = num;
				this.CpyBtnCnvAlsLstMessageAliasListMessageAliasNumber_A8501 = (global::AcpUI.AcpCopyButton)target;
				return;
				IL_31E:
				this.ExpanderConventionalAliasListsStatusAliasTableGrid = (global::System.Windows.Controls.Grid)target;
				return;
				IL_32B:
				this.gridExpanderConventionalAliasListsMessageAliasTableSRecView = (global::System.Windows.Controls.Grid)target;
				return;
				IL_338:
				this.ExpanderConventionalAliasListsMessageAliasTableTableView = (global::AcpUI.AcpGroupBox)target;
				return;
				IL_345:
				this.LblCnvAlsLstStatusAliasListStatusAliasNumber_A9191 = (global::AcpUI.AcpLabel)target;
				this.LblCnvAlsLstStatusAliasListStatusAliasNumber_A9191.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
				return;
				IL_369:
				this.ExpanderConventionalAliasListsMessageAliasTableSRecView = (global::AcpUI.AcpGroupBox)target;
				return;
				IL_376:
				this.CnvAlsLstMessageAliasListMessageAliasText_A8502_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
				return;
				IL_383:
				this.RecNavToolbarExpanderConventionalAliasListsMessageAliasTable = (global::AcpUI.AcpRecNavToolbar)target;
				this.RecNavToolbarExpanderConventionalAliasListsMessageAliasTable.ModeClick += this.OnModeClick;
				return;
				IL_3A7:
				this.CpyBtnCnvAlsLstMessageAliasListMessageAliasText_A8502 = (global::AcpUI.AcpCopyButton)target;
				return;
				IL_3B4:
				((global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.PageConventionalAliasLists)target).Loaded += this.OnLoaded;
				((global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.PageConventionalAliasLists)target).Unloaded += this.OnUnloaded;
				return;
				IL_3E5:
				this.LblCnvAlsLstMessageAliasListMessageAliasText_A8502 = (global::AcpUI.AcpLabel)target;
				this.LblCnvAlsLstMessageAliasListMessageAliasText_A8502.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
				return;
				IL_409:
				this.CnvAlsLstMessageAliasListMessageAliasNumber_A8501Comp = (global::AcpUI.AcpLabel)target;
				return;
				IL_416:
				this.CVBtnCnvAlsLstStatusAliasListStatusAliasNumber_A9191 = (global::AcpUI.AcpCustomViewCheckBox)target;
				return;
				IL_423:
				this.CnvAlsLstMessageAliasListMessageAliasText_A8502 = (global::AcpUI.AcpTextBox)target;
				this.CnvAlsLstMessageAliasListMessageAliasText_A8502.GotFocus += this.OnFieldNameDoubleClick;
				return;
				IL_447:
				this.LblCnvAlsLstStatusAliasListStatusAliasText_A9192 = (global::AcpUI.AcpLabel)target;
				this.LblCnvAlsLstStatusAliasListStatusAliasText_A9192.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
				return;
				IL_46B:
				this.HLinkStatusAliasList = (global::System.Windows.Documents.Hyperlink)target;
				this.HLinkStatusAliasList.Click += this.HLinkClick;
				return;
				IL_48F:
				this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
				return;
				IL_49C:
				this.CpyBtnCnvAlsLstStatusAliasListStatusAliasText_A9192 = (global::AcpUI.AcpCopyButton)target;
				return;
				IL_4A9:
				this.CVBtnCnvAlsLstMessageAliasListMessageAliasNumber_A8501 = (global::AcpUI.AcpCustomViewCheckBox)target;
				return;
				IL_4B6:
				this.HLinkLabtool = (global::System.Windows.Documents.Hyperlink)target;
				this.HLinkLabtool.Click += this.HLinkClick;
				return;
				IL_4DA:
				this.gridExpanderConventionalAliasListsStatusAliasTableSRecView = (global::System.Windows.Controls.Grid)target;
				return;
				IL_4E7:
				this.HLinkMessageAliasList = (global::System.Windows.Documents.Hyperlink)target;
				this.HLinkMessageAliasList.Click += this.HLinkClick;
				return;
				IL_50B:
				this.CVBtnCnvAlsLstMessageAliasListMessageAliasText_A8502 = (global::AcpUI.AcpCustomViewCheckBox)target;
				return;
				IL_518:
				this.CnvAlsLstStatusAliasListStatusAliasNumber_A9191_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
				return;
				IL_525:
				this.RecNavToolbarExpanderConventionalAliasListsStatusAliasTable = (global::AcpUI.AcpRecNavToolbar)target;
				this.RecNavToolbarExpanderConventionalAliasListsStatusAliasTable.ModeClick += this.OnModeClick;
				return;
				IL_549:
				this.CpyBtnCnvAlsLstStatusAliasListStatusAliasNumber_A9191 = (global::AcpUI.AcpCopyButton)target;
				return;
				IL_556:
				this.ExpanderConventionalAliasListsStatusAliasTableSRecView = (global::AcpUI.AcpGroupBox)target;
				return;
				IL_563:
				this.ExpanderConventionalAliasListsLabtool = (global::AcpUI.AcpExpander)target;
				return;
				IL_570:
				this.ExpanderConventionalAliasListsStatusAliasTableTableView = (global::AcpUI.AcpGroupBox)target;
				return;
				IL_57D:
				this.CnvAlsLstMessageAliasListMessageAliasNumber_A8501 = (global::AcpUI.AcpTextBoxSpinner)target;
				this.CnvAlsLstMessageAliasListMessageAliasNumber_A8501.GotFocus += this.OnFieldNameDoubleClick;
				return;
				IL_5A1:
				this.ExpanderConventionalAliasListsStatusAliasListGrid = (global::System.Windows.Controls.Grid)target;
				return;
				IL_5AE:
				this.b = true;
				return;
			}
			}
			IL_1CF:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
		}

		// Token: 0x0600CE63 RID: 52835 RVA: 0x00C01988 File Offset: 0x00BFFB88
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num = (short)1690049596;
			short num2 = num;
			num = (short)46865468;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1574305792;
				if (num != 0)
				{
				}
				switch (connectionId)
				{
				case 2:
					((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				case 3:
					((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				case 4:
					((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				case 5:
					((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				}
				break;
			}
			num = (short)954138625;
			if (num != 0)
			{
			}
			num = (short)906493952;
			short num3 = num;
		}

		// Token: 0x04006508 RID: 25864
		private bool a;

		// Token: 0x04006509 RID: 25865
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x0400650A RID: 25866
		internal global::System.Windows.Documents.Hyperlink HLinkMessageAliasList;

		// Token: 0x0400650B RID: 25867
		internal global::System.Windows.Documents.Hyperlink HLinkStatusAliasList;

		// Token: 0x0400650C RID: 25868
		internal global::System.Windows.Documents.Hyperlink HLinkLabtool;

		// Token: 0x0400650D RID: 25869
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x0400650E RID: 25870
		internal global::AcpUI.AcpExpander ExpanderConventionalAliasListsMessageAliasList;

		// Token: 0x0400650F RID: 25871
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderConventionalAliasListsMessageAliasTable;

		// Token: 0x04006510 RID: 25872
		internal global::System.Windows.Controls.Grid ExpanderConventionalAliasListsMessageAliasListGrid;

		// Token: 0x04006511 RID: 25873
		internal global::System.Windows.Controls.Grid ExpanderConventionalAliasListsMessageAliasTableGrid;

		// Token: 0x04006512 RID: 25874
		internal global::AcpUI.AcpGroupBox ExpanderConventionalAliasListsMessageAliasTableTableView;

		// Token: 0x04006513 RID: 25875
		internal global::AcpUI.AcpXamDataPresenter ExpanderConventionalAliasListsMessageAliasTable;

		// Token: 0x04006514 RID: 25876
		internal global::Infragistics.Windows.DataPresenter.UnboundField CnvAlsLstMessageAliasListMessageAliasNumber_A8501_Col;

		// Token: 0x04006515 RID: 25877
		internal global::Infragistics.Windows.DataPresenter.UnboundField CnvAlsLstMessageAliasListMessageAliasText_A8502_Col;

		// Token: 0x04006516 RID: 25878
		internal global::AcpUI.AcpGroupBox ExpanderConventionalAliasListsMessageAliasTableSRecView;

		// Token: 0x04006517 RID: 25879
		internal global::System.Windows.Controls.Grid gridExpanderConventionalAliasListsMessageAliasTableSRecView;

		// Token: 0x04006518 RID: 25880
		internal global::AcpUI.AcpTextBoxSpinner CnvAlsLstMessageAliasListMessageAliasNumber_A8501;

		// Token: 0x04006519 RID: 25881
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvAlsLstMessageAliasListMessageAliasNumber_A8501;

		// Token: 0x0400651A RID: 25882
		internal global::AcpUI.AcpLabel LblCnvAlsLstMessageAliasListMessageAliasNumber_A8501;

		// Token: 0x0400651B RID: 25883
		internal global::AcpUI.AcpRtdButton RTDBtnCnvAlsLstMessageAliasListMessageAliasNumber_A8501;

		// Token: 0x0400651C RID: 25884
		internal global::AcpUI.AcpCopyButton CpyBtnCnvAlsLstMessageAliasListMessageAliasNumber_A8501;

		// Token: 0x0400651D RID: 25885
		internal global::AcpUI.AcpLabel CnvAlsLstMessageAliasListMessageAliasNumber_A8501Comp;

		// Token: 0x0400651E RID: 25886
		internal global::AcpUI.AcpTextBox CnvAlsLstMessageAliasListMessageAliasText_A8502;

		// Token: 0x0400651F RID: 25887
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvAlsLstMessageAliasListMessageAliasText_A8502;

		// Token: 0x04006520 RID: 25888
		internal global::AcpUI.AcpLabel LblCnvAlsLstMessageAliasListMessageAliasText_A8502;

		// Token: 0x04006521 RID: 25889
		internal global::AcpUI.AcpCopyButton CpyBtnCnvAlsLstMessageAliasListMessageAliasText_A8502;

		// Token: 0x04006522 RID: 25890
		internal global::AcpUI.AcpLabel CnvAlsLstMessageAliasListMessageAliasText_A8502Comp;

		// Token: 0x04006523 RID: 25891
		internal global::AcpUI.AcpExpander ExpanderConventionalAliasListsStatusAliasList;

		// Token: 0x04006524 RID: 25892
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderConventionalAliasListsStatusAliasTable;

		// Token: 0x04006525 RID: 25893
		internal global::System.Windows.Controls.Grid ExpanderConventionalAliasListsStatusAliasListGrid;

		// Token: 0x04006526 RID: 25894
		internal global::System.Windows.Controls.Grid ExpanderConventionalAliasListsStatusAliasTableGrid;

		// Token: 0x04006527 RID: 25895
		internal global::AcpUI.AcpGroupBox ExpanderConventionalAliasListsStatusAliasTableTableView;

		// Token: 0x04006528 RID: 25896
		internal global::AcpUI.AcpXamDataPresenter ExpanderConventionalAliasListsStatusAliasTable;

		// Token: 0x04006529 RID: 25897
		internal global::Infragistics.Windows.DataPresenter.UnboundField CnvAlsLstStatusAliasListStatusAliasNumber_A9191_Col;

		// Token: 0x0400652A RID: 25898
		internal global::Infragistics.Windows.DataPresenter.UnboundField CnvAlsLstStatusAliasListStatusAliasText_A9192_Col;

		// Token: 0x0400652B RID: 25899
		internal global::AcpUI.AcpGroupBox ExpanderConventionalAliasListsStatusAliasTableSRecView;

		// Token: 0x0400652C RID: 25900
		internal global::System.Windows.Controls.Grid gridExpanderConventionalAliasListsStatusAliasTableSRecView;

		// Token: 0x0400652D RID: 25901
		internal global::AcpUI.AcpTextBoxSpinner CnvAlsLstStatusAliasListStatusAliasNumber_A9191;

		// Token: 0x0400652E RID: 25902
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvAlsLstStatusAliasListStatusAliasNumber_A9191;

		// Token: 0x0400652F RID: 25903
		internal global::AcpUI.AcpLabel LblCnvAlsLstStatusAliasListStatusAliasNumber_A9191;

		// Token: 0x04006530 RID: 25904
		internal global::AcpUI.AcpRtdButton RTDBtnCnvAlsLstStatusAliasListStatusAliasNumber_A9191;

		// Token: 0x04006531 RID: 25905
		internal global::AcpUI.AcpCopyButton CpyBtnCnvAlsLstStatusAliasListStatusAliasNumber_A9191;

		// Token: 0x04006532 RID: 25906
		internal global::AcpUI.AcpLabel CnvAlsLstStatusAliasListStatusAliasNumber_A9191Comp;

		// Token: 0x04006533 RID: 25907
		internal global::AcpUI.AcpTextBox CnvAlsLstStatusAliasListStatusAliasText_A9192;

		// Token: 0x04006534 RID: 25908
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvAlsLstStatusAliasListStatusAliasText_A9192;

		// Token: 0x04006535 RID: 25909
		internal global::AcpUI.AcpLabel LblCnvAlsLstStatusAliasListStatusAliasText_A9192;

		// Token: 0x04006536 RID: 25910
		internal global::AcpUI.AcpCopyButton CpyBtnCnvAlsLstStatusAliasListStatusAliasText_A9192;

		// Token: 0x04006537 RID: 25911
		internal global::AcpUI.AcpLabel CnvAlsLstStatusAliasListStatusAliasText_A9192Comp;

		// Token: 0x04006538 RID: 25912
		internal global::AcpUI.AcpExpander ExpanderConventionalAliasListsLabtool;

		// Token: 0x04006539 RID: 25913
		private bool b;
	}
}
