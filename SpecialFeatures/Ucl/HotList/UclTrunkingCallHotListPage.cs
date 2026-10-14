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
	// Token: 0x020001EB RID: 491
	public class UclTrunkingCallHotListPage : global::AcpUI.AcpPageFeature, global::AcpUILib.IAcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x060017A1 RID: 6049 RVA: 0x00200D7C File Offset: 0x001FEF7C
		public UclTrunkingCallHotListPage()
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

		// Token: 0x060017A2 RID: 6050 RVA: 0x00200DB4 File Offset: 0x001FEFB4
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
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num2 = (short)1246756865;
						if (num2 != 0)
						{
						}
						num2 = (short)2066284547;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1E5;
				case 1:
					goto IL_187;
				case 2:
					goto IL_6C;
				case 3:
					goto IL_158;
				case 4:
					goto IL_6C;
				case 5:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num2 = (short)1231486977;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2208);
					num2 = (short)644612100;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_28;
				IL_6C:
				this.RecNavToolbarUclTrunkingCallHotList.MyRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				num2 = (short)1926464846;
				short num3 = num2;
				num2 = (short)1461945678;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_187:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2208);
					num2 = (short)2110521346;
					num = (int)((global::System.IntPtr)num2);
					break;
				default:
				{
					num2 = (short)1572798464;
					short num4 = num2;
					num2 = (short)1258422272;
					if (num2 != 0)
					{
					}
					num2 = (short)881983488;
					num = (int)((global::System.IntPtr)num2);
					break;
				}
				}
			}
			IL_158:
			object feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2208);
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarUclTrunkingCallHotList).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarUclTrunkingCallHotList).SyncDataSources();
			return;
			IL_1E5:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarUclTrunkingCallHotList).MySecondaryRecordsetDataSource = null;
			return;
			IL_28:
			base.MyBaseRecNavToolbar = this.RecNavToolbarUclTrunkingCallHotList;
			num2 = (short)697368581;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060017A3 RID: 6051 RVA: 0x00200FB4 File Offset: 0x001FF1B4
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)734068736;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)105316361;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::AcpUI.AcpExpander acpExpander;
					global::System.Collections.IEnumerator enumerator;
					object obj;
					switch (num2)
					{
					case 0:
						goto IL_2F4;
					case 1:
						try
						{
							num = (short)536608774;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									base.Expanders.Add(acpExpander);
									num = (short)2128084997;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (!enumerator.MoveNext())
									{
										num = (short)632946692;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
									num = (short)66191362;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									if (acpExpander != null)
									{
										num = (short)1358626816;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 3:
									goto IL_18E;
								case 4:
									num = (short)1496580099;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_D4;
									}
									continue;
								}
								IL_117:
								num = (short)689176577;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_D4:
								goto IL_117;
							}
							IL_18E:
							goto IL_2B4;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_1B0;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_19D:
								switch (num2)
								{
								case 0:
									goto IL_257;
								case 1:
								{
									num = (short)4277878;
									short num3 = num;
									num = (short)1610630774;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_1D4;
									default:
										num = (short)253296640;
										if (num != 0)
										{
										}
										disposable.Dispose();
										num = (short)509345792;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									if (disposable != null)
									{
										goto IL_1D4;
									}
									goto IL_259;
								}
								goto IL_1B0;
								IL_1D4:
								num = (short)1645936641;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_257:
							IL_259:
							goto EndFinally_8;
							IL_1B0:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1712783362;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_19D;
							EndFinally_8:;
						}
						goto IL_25A;
						IL_2B4:
						this.MyStackPanel.Children[0].Focus();
						base.OnLoaded(sender, e);
						this.a = true;
						num = (short)1559691264;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						object myRecordsetDataSource;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
						num = (short)796131333;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						object myRecordsetDataSource;
						if (myRecordsetDataSource != null)
						{
							num = (short)686882818;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_39D;
					}
					case 4:
					{
						this.RecNavToolbarUclTrunkingCallHotList.ChildToolbars.Add(this.RecNavToolbarTrunkingCallHotListHotList);
						base.MyBaseRecNavToolbar = this.RecNavToolbarUclTrunkingCallHotList;
						object myRecordsetDataSource = this.RecNavToolbarUclTrunkingCallHotList.MyRecordsetDataSource;
						num = (short)2128412675;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_39D;
					case 6:
					{
						num = (short)106037248;
						short num4 = num;
						global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarTrunkingCallHotListHotList.MyDataPresenter = this.TrunkingCallHotListDataPresenter;
						num = (short)2030895111;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_25A;
					case 8:
						if (obj != null)
						{
							num = (short)753074182;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_25A;
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
						num = (short)1727332356;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_25A:
					acpExpander = null;
					enumerator = this.MyStackPanel.Children.GetEnumerator();
					num = (short)147914753;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_39D:
					obj = null;
					obj = this.RecNavToolbarTrunkingCallHotListHotList.MyRecordsetDataSource;
					num = (short)1864368129;
					if (num != 0)
					{
					}
					num = (short)1061224456;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2F4:
				this.a();
				return;
			}
		}

		// Token: 0x060017A4 RID: 6052 RVA: 0x0020141C File Offset: 0x001FF61C
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
					goto IL_11C;
				case 1:
				{
					num2 = (short)2055104347;
					short num3 = num2;
					num2 = (short)706504539;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6B;
					default:
					{
						num2 = (short)1981284352;
						short num4 = num2;
						num2 = (short)1174142976;
						if (num2 != 0)
						{
						}
						base.OnUnloaded(sender, e);
						this.a = false;
						num2 = (short)1444282368;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 2:
					if (this.a)
					{
						goto IL_6B;
					}
					return;
				}
				goto IL_1C;
				IL_6B:
				num2 = (short)1468071937;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_11C:
			num2 = (short)110624769;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			this.RecNavToolbarTrunkingCallHotListHotList.DataContext = null;
			this.RecNavToolbarUclTrunkingCallHotList.DataContext = null;
			this.RecNavToolbarTrunkingCallHotListHotList.MyDataPresenter = null;
			this.RecNavToolbarUclTrunkingCallHotList.MyDataPresenter = null;
			num2 = (short)1773404162;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060017A5 RID: 6053 RVA: 0x00201570 File Offset: 0x001FF770
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)99073646;
			short num2 = num;
			num = (short)6405742;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1013907456;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1777598464;
			if (num != 0)
			{
			}
			num = (short)516554753;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x060017A6 RID: 6054 RVA: 0x00201624 File Offset: 0x001FF824
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 12;
			short num = (short)337444864;
			switch (num)
			{
			default:
			{
				num = (short)2055929867;
				int num2 = (int)((global::System.IntPtr)num);
				global::AcpCommonLib.IAcpRecordset myRecordsetDataSource;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (myRecordsetDataSource != null)
						{
							num = (short)788922376;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						num = (short)721092623;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_24A;
					case 3:
						goto IL_36B;
					case 4:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8e\udb94쾚춠솢쒤햦ﲨ좪솬ﮮ쎰욲\udbb4\udcb6킸햺\udabcﲾꃀ꿂꧄迆ꛈ뿊臌ꛎꋐ꟒", a_))
						{
							num = (short)1296760845;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1561133076;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1344602122;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)1736966165;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						object myRecordsetDataSource2;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource2);
						global::SpecialFeatures.Ucl.HotList.TrunkingCallHotList trunkingCallHotList = (global::SpecialFeatures.Ucl.HotList.TrunkingCallHotList)collectionView.CurrentItem;
						num = (short)1771307026;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_12A;
					case 8:
						goto IL_1FC;
					case 9:
					{
						global::System.Windows.Data.CollectionView collectionView;
						global::SpecialFeatures.Ucl.HotList.TrunkingCallHotList trunkingCallHotList;
						collectionView.MoveCurrentTo(trunkingCallHotList);
						num = (short)285736967;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource2 = this.RecNavToolbarTrunkingCallHotListHotList.MyRecordsetDataSource;
						num = (short)1824325644;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						switch (0)
						{
						case 0:
							goto IL_A5;
						}
						continue;
					case 12:
					{
						num = (short)1535311873;
						if (num != 0)
						{
						}
						object myRecordsetDataSource2;
						if (myRecordsetDataSource2 != null)
						{
							num = (short)1035927558;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 13:
					{
						myRecordsetDataSource = this.RecNavToolbarUclTrunkingCallHotList.MyRecordsetDataSource;
						num = (short)631694915;
						short num3 = num;
						num = (short)1365239363;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_36B;
						default:
							num = (short)539951104;
							if (num != 0)
							{
							}
							num = (short)1696858112;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 14:
						num = (short)1202847748;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						global::System.Windows.Data.CollectionView collectionView;
						if (collectionView.IsCurrentAfterLast)
						{
							num = (short)1125974035;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						collectionView.MoveCurrentToFirst();
						num = (short)1517748240;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						goto IL_167;
					case 17:
					{
						global::System.Windows.Data.CollectionView collectionView;
						if (collectionView.Count > 0)
						{
							num = (short)227475457;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_321;
					}
					case 18:
					{
						global::SpecialFeatures.Ucl.HotList.TrunkingCallHotList trunkingCallHotList;
						if (trunkingCallHotList != null)
						{
							num = (short)364969993;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1245380625;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
					{
						num = (short)1039859712;
						short num4 = num;
						global::System.Windows.Data.CollectionView collectionView;
						collectionView.MoveCurrentToLast();
						num = (short)2138243074;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8e\udb94쾚춠솢쒤햦ﶨ\ud9aa\ud8ac솮\udab0\udab2\udbb4킶視\udaba톼펾觀곂뇄识ꃈ룊만蟎뻐꟒駔뻖꫘꿚", a_))
						{
							num = (short)843907075;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 21:
						goto IL_274;
					}
					IL_A5:
					if (A_0 is global::AcpUI.AcpRecNavToolbar)
					{
						num = (short)30277646;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_36B:
					num = (short)538050565;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_12A:
				IL_167:
				goto IL_321;
				IL_1FC:
				base.NavigationService.Navigate(new global::System.Uri(myRecordsetDataSource.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
				return;
				IL_24A:
				goto IL_321;
				IL_274:
				return;
				IL_321:
				((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
				return;
			}
			}
		}

		// Token: 0x060017A7 RID: 6055 RVA: 0x00201AB4 File Offset: 0x001FFCB4
		private void a()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::SpecialFeatures.Ucl.Contact.UclContactRecset uclContactRecset;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (uclContactRecset != null)
					{
						num2 = (short)174587906;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					goto IL_247;
				case 2:
					goto IL_FC;
				}
				goto IL_1C;
			}
			IL_247:
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
			try
			{
				num2 = (short)1159331842;
				num = (int)((global::System.IntPtr)num2);
				for (;;)
				{
					switch (num)
					{
					case 1:
						if (!enumerator.MoveNext())
						{
							num2 = (short)1474297860;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						((global::AcpBusinessLayer.Recordset)((global::SpecialFeatures.Ucl.Contact.UclContact)enumerator.Current).TrunkingCallList.EmbeddedRecset).RefreshKeyMap();
						num2 = (short)1990262784;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_13A;
						}
						continue;
					case 3:
						goto IL_1BE;
					case 4:
						num2 = (short)452132867;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					IL_13C:
					num2 = (short)1557397505;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_13A:
					goto IL_13C;
				}
				IL_1BE:
				return;
			}
			finally
			{
				num2 = (short)1604648960;
				num = (int)((global::System.IntPtr)num2);
				for (;;)
				{
					switch (num)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_1F3;
						}
						continue;
					case 1:
						goto IL_226;
					case 2:
						enumerator.Dispose();
						num2 = (short)376766465;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					IL_1F3:
					if (enumerator == null)
					{
						break;
					}
					num2 = (short)1484259330;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_226:;
			}
			goto IL_229;
			IL_1C:
			num2 = (short)178716672;
			short num3 = num2;
			num2 = (short)200209618;
			short num4 = num2;
			num2 = (short)1148450002;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_FC:
				break;
			default:
				num2 = (short)589365248;
				if (num2 != 0)
				{
				}
				num2 = (short)1496514561;
				if (num2 != 0)
				{
				}
				uclContactRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2200) as global::SpecialFeatures.Ucl.Contact.UclContactRecset);
				num2 = (short)637861888;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_229:
			enumerator = uclContactRecset.GetEnumerator();
			num2 = (short)935985153;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060017A8 RID: 6056 RVA: 0x00201D20 File Offset: 0x001FFF20
		private void HLinkTrunkingCallHotListClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1085625020;
			short num2 = num;
			num = (short)889606844;
			switch (num2 == num)
			{
			}
			num = (short)1971781632;
			if (num != 0)
			{
			}
			num = (short)1758265344;
			short num3 = num;
			num = (short)1648820225;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x060017A9 RID: 6057 RVA: 0x00201DD4 File Offset: 0x001FFFD4
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 0;
			while (this.b)
			{
				short num = (short)1073348608;
				short num2 = num;
				num = (short)812631126;
				short num3 = num;
				num = (short)841139286;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1821835264;
					if (num != 0)
					{
					}
					num = (short)676462593;
					if (num != 0)
					{
					}
					return;
				}
			}
			this.b = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("겂횄﶐햒爵튠颢욤좦쒨\udbaa슬솮풰\uddb2솴颶\udab8\udaba톼펾ꯆꃈ룊만뛔룖럘뷚드룞铠釢蓤鏦胨蓪菬샮駰鳲致鯶郸裺觼탾琀怂椄猆笈縊挌搎砐紒爔琖砘眚焜眞丠圢䤤並娨弪崬丮嘰嘲᬴伶堸嘺儼", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060017AA RID: 6058 RVA: 0x00201EB4 File Offset: 0x002000B4
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)940113920;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_32;
					}
					continue;
				case 1:
					goto IL_249;
				case 2:
					num = (short)356057089;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_32:
				switch (connectionId)
				{
				case 1:
					goto IL_3A5;
				case 2:
					goto IL_417;
				case 3:
				case 4:
					goto IL_46C;
				case 5:
					goto IL_33C;
				case 6:
					goto IL_19B;
				case 7:
					goto IL_25B;
				case 8:
					goto IL_24E;
				case 9:
					goto IL_108;
				case 10:
					goto IL_1FD;
				case 11:
					goto IL_2F1;
				case 12:
					goto IL_268;
				case 13:
					goto IL_2CD;
				case 14:
					goto IL_30B;
				case 15:
					goto IL_32F;
				case 16:
					goto IL_224;
				case 17:
					goto IL_2A6;
				case 18:
					goto IL_2B3;
				case 19:
					goto IL_3FD;
				case 20:
					goto IL_3E3;
				case 21:
					goto IL_1F0;
				case 22:
					goto IL_FB;
				case 23:
					goto IL_3D6;
				case 24:
					goto IL_371;
				case 25:
					goto IL_2C0;
				case 26:
					goto IL_43B;
				case 27:
					goto IL_EE;
				case 28:
					goto IL_1BF;
				case 29:
					goto IL_45F;
				case 30:
					goto IL_282;
				case 31:
					goto IL_2FE;
				case 32:
					goto IL_12C;
				case 33:
					goto IL_275;
				case 34:
					goto IL_20A;
				case 35:
					goto IL_3F0;
				case 36:
					goto IL_1E3;
				case 37:
					goto IL_40A;
				case 38:
					goto IL_217;
				default:
					num = (short)190578690;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_EE:
			this.CVBtnContactAlias = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_FB:
			this.CallIdTable_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_108:
			this.RecNavToolbarTrunkingCallHotListHotList = (global::AcpUI.AcpChildRecNavToolbar)target;
			this.RecNavToolbarTrunkingCallHotListHotList.ModeClick += this.OnModeClick;
			return;
			IL_12C:
			num = (short)567656051;
			short num3 = num;
			num = (short)1108917875;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_1BF:
				this.LblContactAlias = (global::AcpUI.AcpLabel)target;
				this.LblContactAlias.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
				return;
			default:
				num = (short)33685504;
				if (num != 0)
				{
				}
				this.LblCallID = (global::AcpUI.AcpLabel)target;
				this.LblCallID.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
				return;
			}
			IL_19B:
			this.HLinkTrunkingCallHotList = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkTrunkingCallHotList.Click += this.HLinkTrunkingCallHotListClick;
			return;
			IL_1E3:
			this.ContactAliasComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_1F0:
			this.ContactAliasTable_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1FD:
			this.GrpBoxExpanderPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_20A:
			this.CompGridGeneralGrp = (global::System.Windows.Controls.Grid)target;
			return;
			IL_217:
			this.CallIDComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_224:
			this.CpyBtnHotListAlias = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_249:
			goto IL_46C;
			IL_24E:
			this.ExpTrunkingCallHotList = (global::AcpUI.AcpExpander)target;
			return;
			IL_25B:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_268:
			this.CVBtnTrunkingHotListAlias = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_275:
			this.RtdBtnCallID = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_282:
			this.CallID = (global::AcpUI.AcpComboBox)target;
			this.CallID.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2A6:
			this.TxtBoxHotListAliasComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_2B3:
			this.GridFrame = (global::System.Windows.Controls.Grid)target;
			return;
			IL_2C0:
			this.StdGridGeneralGrp = (global::System.Windows.Controls.Grid)target;
			return;
			IL_2CD:
			this.LblHotListAlias = (global::AcpUI.AcpLabel)target;
			this.LblHotListAlias.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2F1:
			this.StdGrpBoxExpanderColumn = (global::System.Windows.Controls.Grid)target;
			return;
			IL_2FE:
			this.CVBtnCallID = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_30B:
			this.TxtBoxHotListAlias = (global::AcpUI.AcpTextBox)target;
			this.TxtBoxHotListAlias.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_32F:
			this.CompGrpBoxExpanderColumn = (global::System.Windows.Controls.Grid)target;
			return;
			IL_33C:
			num = (short)1070006272;
			short num4 = num;
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_371:
			num = (short)191037441;
			if (num != 0)
			{
			}
			this.grid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_3A5:
			((global::SpecialFeatures.Ucl.HotList.UclTrunkingCallHotListPage)target).Loaded += this.OnLoaded;
			((global::SpecialFeatures.Ucl.HotList.UclTrunkingCallHotListPage)target).Unloaded += this.OnUnloaded;
			return;
			IL_3D6:
			this.GroupBoxSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_3E3:
			this.TrunkingCallHotListDataPresenter = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_3F0:
			this.CopyButtonContactAlias = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3FD:
			this.GroupBoxTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_40A:
			this.CopyButtonCallID = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_417:
			this.RecNavToolbarUclTrunkingCallHotList = (global::AcpUI.AcpParentRecNavToolbar)target;
			this.RecNavToolbarUclTrunkingCallHotList.ModeClick += this.OnModeClick;
			return;
			IL_43B:
			this.ContactAlias = (global::AcpUI.AcpComboBox)target;
			this.ContactAlias.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_45F:
			this.RtdBtnContactAlias = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_46C:
			this.b = true;
		}

		// Token: 0x060017AB RID: 6059 RVA: 0x00202334 File Offset: 0x00200534
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num = (short)1474428929;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (connectionId != 4)
					{
						num = (short)1161560066;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_13D;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 2:
					return;
				case 3:
					goto IL_109;
				}
				IL_34:
				num = (short)724566017;
				if (num != 0)
				{
				}
				if (connectionId == 3)
				{
					break;
				}
				num = (short)1959124855;
				short num3 = num;
				num = (short)1272438647;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)982974464;
					if (num != 0)
					{
					}
					num = (short)1855127552;
					short num4 = num;
					num = (short)1206845443;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_109:
				num = (short)1604780032;
				num2 = (int)((global::System.IntPtr)num);
			}
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_13D:
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x04000C28 RID: 3112
		private bool a;

		// Token: 0x04000C29 RID: 3113
		internal global::AcpUI.AcpParentRecNavToolbar RecNavToolbarUclTrunkingCallHotList;

		// Token: 0x04000C2A RID: 3114
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x04000C2B RID: 3115
		internal global::System.Windows.Documents.Hyperlink HLinkTrunkingCallHotList;

		// Token: 0x04000C2C RID: 3116
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x04000C2D RID: 3117
		internal global::AcpUI.AcpExpander ExpTrunkingCallHotList;

		// Token: 0x04000C2E RID: 3118
		internal global::AcpUI.AcpChildRecNavToolbar RecNavToolbarTrunkingCallHotListHotList;

		// Token: 0x04000C2F RID: 3119
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderPseudo0;

		// Token: 0x04000C30 RID: 3120
		internal global::System.Windows.Controls.Grid StdGrpBoxExpanderColumn;

		// Token: 0x04000C31 RID: 3121
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrunkingHotListAlias;

		// Token: 0x04000C32 RID: 3122
		internal global::AcpUI.AcpLabel LblHotListAlias;

		// Token: 0x04000C33 RID: 3123
		internal global::AcpUI.AcpTextBox TxtBoxHotListAlias;

		// Token: 0x04000C34 RID: 3124
		internal global::System.Windows.Controls.Grid CompGrpBoxExpanderColumn;

		// Token: 0x04000C35 RID: 3125
		internal global::AcpUI.AcpCopyButton CpyBtnHotListAlias;

		// Token: 0x04000C36 RID: 3126
		internal global::AcpUI.AcpViewOnlyCtrl TxtBoxHotListAliasComp;

		// Token: 0x04000C37 RID: 3127
		internal global::System.Windows.Controls.Grid GridFrame;

		// Token: 0x04000C38 RID: 3128
		internal global::AcpUI.AcpGroupBox GroupBoxTableView;

		// Token: 0x04000C39 RID: 3129
		internal global::AcpUI.AcpXamDataPresenter TrunkingCallHotListDataPresenter;

		// Token: 0x04000C3A RID: 3130
		internal global::Infragistics.Windows.DataPresenter.UnboundField ContactAliasTable_Col;

		// Token: 0x04000C3B RID: 3131
		internal global::Infragistics.Windows.DataPresenter.UnboundField CallIdTable_Col;

		// Token: 0x04000C3C RID: 3132
		internal global::AcpUI.AcpGroupBox GroupBoxSRecView;

		// Token: 0x04000C3D RID: 3133
		internal global::System.Windows.Controls.Grid grid;

		// Token: 0x04000C3E RID: 3134
		internal global::System.Windows.Controls.Grid StdGridGeneralGrp;

		// Token: 0x04000C3F RID: 3135
		internal global::AcpUI.AcpComboBox ContactAlias;

		// Token: 0x04000C40 RID: 3136
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnContactAlias;

		// Token: 0x04000C41 RID: 3137
		internal global::AcpUI.AcpLabel LblContactAlias;

		// Token: 0x04000C42 RID: 3138
		internal global::AcpUI.AcpRtdButton RtdBtnContactAlias;

		// Token: 0x04000C43 RID: 3139
		internal global::AcpUI.AcpComboBox CallID;

		// Token: 0x04000C44 RID: 3140
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCallID;

		// Token: 0x04000C45 RID: 3141
		internal global::AcpUI.AcpLabel LblCallID;

		// Token: 0x04000C46 RID: 3142
		internal global::AcpUI.AcpRtdButton RtdBtnCallID;

		// Token: 0x04000C47 RID: 3143
		internal global::System.Windows.Controls.Grid CompGridGeneralGrp;

		// Token: 0x04000C48 RID: 3144
		internal global::AcpUI.AcpCopyButton CopyButtonContactAlias;

		// Token: 0x04000C49 RID: 3145
		internal global::AcpUI.AcpViewOnlyCtrl ContactAliasComp;

		// Token: 0x04000C4A RID: 3146
		internal global::AcpUI.AcpCopyButton CopyButtonCallID;

		// Token: 0x04000C4B RID: 3147
		internal global::AcpUI.AcpViewOnlyCtrl CallIDComp;

		// Token: 0x04000C4C RID: 3148
		private bool b;
	}
}
