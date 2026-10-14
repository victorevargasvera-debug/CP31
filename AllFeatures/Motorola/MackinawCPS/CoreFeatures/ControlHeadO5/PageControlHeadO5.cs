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

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO5
{
	// Token: 0x020003A9 RID: 937
	public class PageControlHeadO5 : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x06008873 RID: 34931 RVA: 0x007F0C08 File Offset: 0x007EEE08
		public PageControlHeadO5()
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

		// Token: 0x06008874 RID: 34932 RVA: 0x007F0C40 File Offset: 0x007EEE40
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1922105344;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				switch (0)
				{
				case 0:
					goto IL_56;
				}
				for (;;)
				{
					IL_27:
					object obj;
					global::AcpUI.AcpExpander acpExpander;
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
					{
						if (obj == null)
						{
							goto IL_399;
						}
						num = (short)1043871651;
						short num3 = num;
						num = (short)1504655267;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_287;
						default:
							num = (short)456196096;
							if (num != 0)
							{
							}
							num = (short)81002499;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						obj = null;
						obj = this.RecNavToolbarExpanderControlHeadO5O5.MyRecordsetDataSource;
						num = (short)1550581760;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (!this.a)
						{
							num = (short)1664811009;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_407;
					case 3:
					{
						num = (short)337379328;
						short num4 = num;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderControlHeadO5O5.MyDataPresenter = this.ExpanderControlHeadO5O5;
						num = (short)2128347141;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						if (obj != null)
						{
							num = (short)1035468806;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_20B;
					case 5:
						goto IL_399;
					case 6:
					{
						global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderControlHeadO5O5NavigationControlsTable.MyDataPresenter = this.ExpanderControlHeadO5O5NavigationControlsTable;
						num = (short)514195465;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						try
						{
							num = (short)848494592;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_DC;
									}
									continue;
								case 1:
									base.Expanders.Add(acpExpander);
									num = (short)1620246534;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_194;
								case 3:
									num = (short)687603714;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									if (acpExpander != null)
									{
										num = (short)1344077825;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 5:
									if (!enumerator.MoveNext())
									{
										num = (short)526909443;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
									num = (short)1341390852;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_11E:
								num = (short)1450508293;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_DC:
								goto IL_11E;
							}
							IL_194:
							goto IL_278;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_1B6;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_1A3:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)713228289;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_20A;
								case 1:
									disposable.Dispose();
									num = (short)191954946;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_208;
								}
								goto IL_1B6;
							}
							IL_208:
							IL_20A:
							goto EndFinally_9;
							IL_1B6:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1730740224;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_1A3;
							EndFinally_9:;
						}
						goto IL_20B;
						IL_278:
						base.OnLoaded(sender, e);
						this.a = true;
						goto IL_287;
					case 8:
						goto IL_29F;
					case 9:
						goto IL_20B;
					}
					goto IL_56;
					IL_20B:
					acpExpander = null;
					enumerator = this.MyStackPanel.Children.GetEnumerator();
					num = (short)1710227463;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_287:
					num = (short)1120600072;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_399:
					num = (short)916717569;
					if (num != 0)
					{
					}
					obj = this.RecNavToolbarExpanderControlHeadO5O5NavigationControlsTable.MyRecordsetDataSource;
					num = (short)1353121796;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_29F:
				IL_407:
				this.MyStackPanel.Children[0].Focus();
				return;
				IL_56:
				this.PreOnLoaded(sender, e);
				num = (short)1200619522;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
		}

		// Token: 0x06008875 RID: 34933 RVA: 0x007F1088 File Offset: 0x007EF288
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
					if (this.a)
					{
						num2 = (short)1079967745;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
				{
					num2 = (short)2330140;
					short num3 = num2;
					num2 = (short)619875868;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)2079719424;
						short num4 = num2;
						num2 = (short)1794244609;
						if (num2 != 0)
						{
						}
						num2 = (short)2014052352;
						if (num2 != 0)
						{
						}
						break;
					}
					}
					base.OnUnloaded(sender, e);
					this.a = false;
					num2 = (short)108789762;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			this.PreOnUnloaded(sender, e);
			this.RecNavToolbarExpanderControlHeadO5O5.DataContext = null;
			this.RecNavToolbarExpanderControlHeadO5O5NavigationControlsTable.DataContext = null;
			this.RecNavToolbarExpanderControlHeadO5O5.MyDataPresenter = null;
			this.RecNavToolbarExpanderControlHeadO5O5NavigationControlsTable.MyDataPresenter = null;
			num2 = (short)1704919040;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06008876 RID: 34934 RVA: 0x007F11E4 File Offset: 0x007EF3E4
		public override void SetDataContext()
		{
			short num = (short)448200705;
			int num2 = (int)((global::System.IntPtr)num);
			object feature;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10735] != null)
					{
						num = (short)1958805521;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_86;
					}
					continue;
				case 2:
				{
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2130);
					num = (short)1799356416;
					short num3 = num;
					num = (short)1954021386;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					num = (short)1356595211;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_353;
				case 5:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10227] != null)
					{
						num = (short)625803277;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_353;
				case 6:
					if (feature != null)
					{
						num = (short)698089475;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_353;
				case 7:
					num = (short)434307073;
					if (num != 0)
					{
					}
					num = (short)1938620421;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2130);
					num = (short)1811087366;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO5O5).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10227].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO5O5).SyncDataSources();
					num = (short)1085276164;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_142;
				case 11:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)982581255;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_353;
				case 12:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)419037200;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 13:
				{
					num = (short)1437007536;
					short num4 = num;
					num = (short)1015742128;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_201;
					default:
						num = (short)1031077888;
						if (num != 0)
						{
						}
						num = (short)638255123;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 14:
					goto IL_1CF;
				case 15:
					goto IL_142;
				case 16:
					goto IL_201;
				case 17:
					num = (short)984088596;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					num = (short)2136408076;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10227].EmbeddedRecset != null)
					{
						num = (short)1575354377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_353;
				case 20:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10735].EmbeddedRecset != null)
					{
						num = (short)1204158478;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 21:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)88670216;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO5O5).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO5O5NavigationControlsTable).MySecondaryRecordsetDataSource = null;
					num = (short)1131544598;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					return;
				case 23:
					if (feature != null)
					{
						num = (short)1957691410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_86:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)960954370;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2130);
				num = (short)2144469007;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_142:
				num = (short)1228013589;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_201:
				num = (short)36241408;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_353:
				num = (short)289865751;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1CF:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO5O5NavigationControlsTable).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10735].EmbeddedRecset;
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderControlHeadO5O5NavigationControlsTable).SyncDataSources();
		}

		// Token: 0x06008877 RID: 34935 RVA: 0x007F16DC File Offset: 0x007EF8DC
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 15;
			short num = (short)1900740608;
			switch (num)
			{
			default:
			{
				num = (short)93766424;
				short num2 = num;
				num = (short)1275642648;
				object myRecordsetDataSource;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_129:
					num = (short)1579810817;
					if (num != 0)
					{
					}
					((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
					myRecordsetDataSource = this.RecNavToolbarExpanderControlHeadO5O5NavigationControlsTable.MyRecordsetDataSource;
					num = (short)278593539;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)404291584;
					if (num != 0)
					{
					}
					num = (short)1529282560;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
					{
						num = (short)1986134016;
						short num4 = num;
						switch (0)
						{
						case 0:
							goto IL_102;
						}
						continue;
					}
					case 1:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1495728138;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)1399324678;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_1A1;
					case 3:
						if (myRecordsetDataSource != null)
						{
							num = (short)101187586;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1611268107;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)1949958160;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)2060845057;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_1A6;
					case 7:
					{
						object myRecordsetDataSource2;
						if (myRecordsetDataSource2 != null)
						{
							num = (short)2058354700;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A6;
					}
					case 8:
						goto IL_1A6;
					case 9:
						num = (short)1295581199;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource2 = this.RecNavToolbarExpanderControlHeadO5O5.MyRecordsetDataSource;
						num = (short)718143495;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						goto IL_307;
					case 12:
					{
						object myRecordsetDataSource2;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource2);
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5Inner item = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5Inner)collectionView.CurrentItem;
						collectionView.MoveCurrentTo(item);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)1184169992;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						num = (short)156303364;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("苏럑럓飕맗곙裛뇝迟軡蛣蟥髧꿩铫黭釯鳱郳鏵諷맹鏻都瓿瀁欃樅䀇漉洋樍式✑嬓⌕嘗笙樛眝䜟䌡倣伥䜧䐩漫䄭帯䘱䘳夵吷䤹栻弽∿⹁⅃", a_))
						{
							num = (short)1044512781;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 15:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("苏럑럓飕맗곙裛뇝迟軡蛣蟥髧꿩铫黭釯鳱郳鏵諷맹鏻都瓿瀁欃樅䀇漉洋樍式✑嬓⌕", a_))
						{
							num = (short)362348549;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A6;
					case 16:
						return;
					}
					IL_102:
					if (A_0 is global::AcpUI.AcpRecNavToolbar)
					{
						num = (short)1325858825;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_1A6:
					num = (short)50987022;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_1A1:
				global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsTableInner item2 = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsTableInner)collectionView2.CurrentItem;
				collectionView2.MoveCurrentTo(item2);
				((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
				return;
				IL_307:
				goto IL_129;
			}
			}
		}

		// Token: 0x06008878 RID: 34936 RVA: 0x007F1AE4 File Offset: 0x007EFCE4
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)2043440937;
			short num2 = num;
			num = (short)558001961;
			switch (num2 == num)
			{
			}
			num = (short)2132475905;
			if (num != 0)
			{
			}
			num = (short)400228352;
			short num3 = num;
			num = (short)2020933632;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x06008879 RID: 34937 RVA: 0x007F1B94 File Offset: 0x007EFD94
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)875364353;
			if (num != 0)
			{
			}
			num = (short)153301819;
			short num2 = num;
			num = (short)257110843;
			switch (num2 == num)
			{
			}
			num = (short)1655111680;
			short num3 = num;
			num = (short)1068892160;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x0600887A RID: 34938 RVA: 0x007F1C44 File Offset: 0x007EFE44
		internal void OnExpanderControlHeadO5O5Click(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)395116544;
			short num2 = num;
			int num3;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5Inner item;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_33:
					switch (num3)
					{
					case 0:
						num = (short)725680129;
						if (num != 0)
						{
						}
						((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
						this.RecNavToolbarExpanderControlHeadO5O5.SyncDataSources();
						num = (short)1258291201;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_102;
					case 2:
						if (myRecordsetDataSource != null)
						{
							num = (short)1794899968;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_150;
					}
					goto IL_45;
				}
				IL_102:
				num = (short)1410347375;
				short num4 = num;
				num = (short)1850683759;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_76;
				default:
					num = (short)940834816;
					if (num != 0)
					{
					}
					break;
				}
				IL_150:
				this.RecNavToolbarExpanderControlHeadO5O5.TableMode = false;
				return;
			}
			}
			IL_45:
			item = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5Inner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderControlHeadO5O5.MyRecordsetDataSource;
			IL_76:
			num = (short)1616117762;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_33;
		}

		// Token: 0x0600887B RID: 34939 RVA: 0x007F1DB0 File Offset: 0x007EFFB0
		internal void OnExpanderControlHeadO5O5NavigationControlsTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1417543680;
			short num2 = num;
			int num3;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsTableInner item;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_33:
					switch (num3)
					{
					case 0:
						((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
						this.RecNavToolbarExpanderControlHeadO5O5NavigationControlsTable.SyncDataSources();
						num = (short)1538719745;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_DA;
					case 2:
						if (myRecordsetDataSource != null)
						{
							num = (short)143327232;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_14D;
					}
					goto IL_45;
				}
				IL_DA:
				num = (short)1153992810;
				short num4 = num;
				num = (short)1733527658;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_76;
				default:
					num = (short)304414721;
					if (num != 0)
					{
					}
					num = (short)1876426752;
					if (num != 0)
					{
					}
					break;
				}
				IL_14D:
				this.RecNavToolbarExpanderControlHeadO5O5NavigationControlsTable.TableMode = false;
				return;
			}
			}
			IL_45:
			item = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsTableInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderControlHeadO5O5NavigationControlsTable.MyRecordsetDataSource;
			IL_76:
			num = (short)1931149314;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_33;
		}

		// Token: 0x0600887C RID: 34940 RVA: 0x007F1F18 File Offset: 0x007F0118
		private void PreOnLoaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1647881186;
			short num2 = num;
			num = (short)2003217378;
			switch (num2 == num)
			{
			}
			num = (short)2099642369;
			if (num != 0)
			{
			}
			num = (short)485752832;
			short num3 = num;
			num = (short)1676083200;
			if (num != 0)
			{
			}
			this.b();
		}

		// Token: 0x0600887D RID: 34941 RVA: 0x007F1FC8 File Offset: 0x007F01C8
		private void PreOnUnloaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1985588477;
			short num2 = num;
			num = (short)1130343677;
			switch (num2 == num)
			{
			}
			num = (short)455081985;
			if (num != 0)
			{
			}
			num = (short)535166976;
			short num3 = num;
			num = (short)1077346304;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x0600887E RID: 34942 RVA: 0x007F2074 File Offset: 0x007F0274
		private void b()
		{
			short num = (short)1667432448;
			short num2 = num;
			num = (short)204406785;
			if (num != 0)
			{
			}
			num = (short)885719042;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					global::AcpCommonLib.AppInfoManager.AppInfoHelper.PropertyChanged += this.OnAppInfoPropertyChanged;
					num = (short)309460993;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)579341523;
					short num4 = num;
					num = (short)1623330003;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_67;
					default:
						goto IL_106;
					}
					break;
				}
				case 2:
					goto IL_67;
				}
				goto IL_83;
				IL_67:
				switch (0)
				{
				case 0:
					IL_83:
					if (this.a)
					{
						return;
					}
					num = (short)1378091008;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_106:
			num = (short)1422917632;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600887F RID: 34943 RVA: 0x007F21A0 File Offset: 0x007F03A0
		private void OnAppInfoPropertyChanged(object A_0, global::System.ComponentModel.PropertyChangedEventArgs A_1)
		{
			int a_ = 6;
			short num = (short)1605441209;
			short num2 = num;
			num = (short)1342772921;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_117:
				num = (short)565116929;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
			{
				num = (short)171769856;
				if (num != 0)
				{
				}
				num = (short)1662910464;
				short num4 = num;
				num = (short)1173094404;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			}
			for (;;)
			{
				num = (short)1930100737;
				if (num != 0)
				{
				}
				switch (num3)
				{
				case 0:
					if (A_1.PropertyName == global::AllFeatures.CodeplugGuid.b("軆꓈믊ꋌ뷎ꗐ鳒ꗔ닖ꯘ뫚꧜뛞軠跢ꛤ裦蓨鯪臬諮藰雲釴", a_))
					{
						num = (short)443613187;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					goto IL_12F;
				case 2:
					num = (short)882507776;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_17B;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_DA;
					}
					continue;
				}
				IL_DA:
				if (A_1.PropertyName == global::AllFeatures.CodeplugGuid.b("菆ꟈ꿊苌뿎듐ꇒ듔ꏖ냘듚돜鳞軠転闤详賨鿪裬诮", a_))
				{
					break;
				}
				num = (short)1200422914;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_10C:
			this.myO5GraphicView.SetMenuItems();
			goto IL_117;
			IL_12F:
			return;
			IL_17B:
			goto IL_10C;
		}

		// Token: 0x06008880 RID: 34944 RVA: 0x007F232C File Offset: 0x007F052C
		private void a()
		{
			short num = (short)456982528;
			short num2 = num;
			num = (short)1584136194;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)436666369;
				if (num != 0)
				{
				}
				switch (num3)
				{
				case 0:
					global::AcpCommonLib.AppInfoManager.AppInfoHelper.PropertyChanged -= this.OnAppInfoPropertyChanged;
					num = (short)501940225;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)1935243338;
					short num4 = num;
					num = (short)864909386;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3E;
					default:
						goto IL_105;
					}
					break;
				}
				case 2:
					goto IL_3E;
				}
				goto IL_82;
				IL_3E:
				switch (0)
				{
				case 0:
					IL_82:
					if (this.a)
					{
						return;
					}
					num = (short)131137536;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_105:
			num = (short)1746141184;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008881 RID: 34945 RVA: 0x007F2458 File Offset: 0x007F0658
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 1;
			short num;
			if (this.b)
			{
				num = (short)996081665;
				if (num != 0)
				{
				}
				num = (short)82373664;
				short num2 = num;
				num = (short)304540704;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1616904192;
					if (num != 0)
					{
					}
					break;
				}
				return;
			}
			num = (short)555548672;
			short num3 = num;
			this.b = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("藃꫅꓇賉꧋꿍꓏ꟑꛓ돕ꯗ뿛뇝跟鋡诣裥跧蓩飫쇭苯鏱郳鿵韷\udff9컻컽旿瀁挃椅昇攉愋服猏愑ㄓ␕⠗礙猛瀝䘟䬡䌣匥娧䬩堫䜭弯就ᬳ唵圷吹䠻䰽⼿⹁㝃楅⭇╉≋㩍≏㵑㡓獕橗橙㑛㭝ş١䅣呥塧䝩䥫屭䁯ᵱ䅳奵᭷ᕹቻ੽ꖏ벑", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06008882 RID: 34946 RVA: 0x007F2538 File Offset: 0x007F0738
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1761869826;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)18546689;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_27E;
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
					goto IL_448;
				case 2:
				case 3:
				case 4:
				case 5:
				case 6:
				case 7:
					goto IL_725;
				case 8:
					goto IL_3D6;
				case 9:
					goto IL_701;
				case 10:
					goto IL_4AD;
				case 11:
					goto IL_6DD;
				case 12:
					goto IL_5BC;
				case 13:
					goto IL_43B;
				case 14:
					goto IL_1BD;
				case 15:
					goto IL_493;
				case 16:
					goto IL_290;
				case 17:
					goto IL_571;
				case 18:
					goto IL_283;
				case 19:
					goto IL_18C;
				case 20:
					goto IL_388;
				case 21:
					goto IL_232;
				case 22:
					goto IL_3BC;
				case 23:
					goto IL_2B4;
				case 24:
					goto IL_3AF;
				case 25:
					goto IL_3A2;
				case 26:
					goto IL_486;
				case 27:
					goto IL_364;
				case 28:
					goto IL_4D1;
				case 29:
					goto IL_4EB;
				case 30:
					goto IL_3F0;
				case 31:
					goto IL_333;
				case 32:
					goto IL_326;
				case 33:
					goto IL_40A;
				case 34:
					goto IL_259;
				case 35:
					goto IL_692;
				case 36:
					goto IL_58B;
				case 37:
					goto IL_607;
				case 38:
					goto IL_3E3;
				case 39:
					goto IL_5E3;
				case 40:
					goto IL_3C9;
				case 41:
					goto IL_63D;
				case 42:
					goto IL_5D6;
				case 43:
					goto IL_17F;
				case 44:
					goto IL_225;
				case 45:
					goto IL_598;
				case 46:
					goto IL_57E;
				case 47:
					goto IL_340;
				case 48:
					goto IL_6B6;
				case 49:
					goto IL_4DE;
				case 50:
					goto IL_1CA;
				case 51:
					goto IL_661;
				case 52:
					goto IL_172;
				case 53:
					goto IL_5C9;
				case 54:
					goto IL_533;
				case 55:
					goto IL_3FD;
				case 56:
					goto IL_6C3;
				case 57:
					goto IL_319;
				case 58:
					goto IL_4A0;
				case 59:
					goto IL_395;
				case 60:
					goto IL_199;
				case 61:
					goto IL_540;
				case 62:
					goto IL_50F;
				case 63:
					goto IL_23F;
				case 64:
					goto IL_30C;
				case 65:
					goto IL_42E;
				case 66:
					goto IL_1D7;
				case 67:
					goto IL_479;
				case 68:
					goto IL_54D;
				case 69:
					goto IL_6D0;
				case 70:
					goto IL_24C;
				case 71:
					goto IL_685;
				default:
					num = (short)1051852800;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_172:
			this.ExpanderControlHeadO5O5NavigationControlsExpanderGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_17F:
			this.CpyBtnCntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_18C:
			this.ExpanderControlHeadO5O5TableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_199:
			this.RadErgoControlO5NaviControlName_A41378 = (global::AcpUI.AcpLabel)target;
			this.RadErgoControlO5NaviControlName_A41378.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1BD:
			this.myO5GraphicView = (global::ControlHeadGraphicView.O5GraphicView)target;
			return;
			IL_1CA:
			this.ExpanderControlHeadO5O5NavigationControlsExpander = (global::AcpUI.AcpExpander)target;
			return;
			IL_1D7:
			num = (short)811991041;
			if (num != 0)
			{
			}
			this.RadErgoControlO5NaviControlFeature_A41379 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoControlO5NaviControlFeature_A41379.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_225:
			this.CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_232:
			this.CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_23F:
			this.RTDBtnRadErgoControlO5NaviControlName_A41378 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_24C:
			this.CpyBtnRadErgoControlO5NaviControlFeature_A41379 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_259:
			this.CVBtnCntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_27E:
			goto IL_725;
			IL_283:
			this.ExpanderControlHeadO5O5Grid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_290:
			this.RecNavToolbarExpanderControlHeadO5O5 = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderControlHeadO5O5.ModeClick += this.OnModeClick;
			return;
			IL_2B4:
			num = (short)700989544;
			short num3 = num;
			num = (short)1551319144;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_540:
				this.CVBtnRadErgoControlO5NaviControlName_A41378 = (global::AcpUI.AcpCustomViewCheckBox)target;
				return;
			default:
				num = (short)173998080;
				if (num != 0)
				{
				}
				this.CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
				return;
			}
			IL_30C:
			this.CpyBtnRadErgoControlO5NaviControlName_A41378 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_319:
			this.RadErgoControlO5NaviControlFeature_A41379_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_326:
			this.CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_333:
			this.CpyBtnCntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_340:
			this.LblCntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193 = (global::AcpUI.AcpLabel)target;
			this.LblCntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_364:
			this.CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520 = (global::AcpUI.AcpLabel)target;
			this.CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_388:
			this.ExpanderControlHeadO5O5 = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_395:
			this.gridExpanderControlHeadO5O5NavigationControlsTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_3A2:
			this.ExpanderControlHeadO5O5SRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_3AF:
			this.CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_3BC:
			this.CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_3C9:
			this.CVBtnCntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3D6:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_3E3:
			this.CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3F0:
			this.RTDBtnCntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3FD:
			this.ExpanderControlHeadO5O5NavigationControlsTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_40A:
			this.CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753 = (global::AcpUI.AcpComboBox)target;
			this.CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_42E:
			this.RadErgoControlO5NaviControlName_A41378Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_43B:
			this.ExpanderControlHeadO5GraphicalView = (global::AcpUI.AcpExpander)target;
			return;
			IL_448:
			((global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.PageControlHeadO5)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.PageControlHeadO5)target).Unloaded += this.OnUnloaded;
			return;
			IL_479:
			this.CVBtnRadErgoControlO5NaviControlFeature_A41379 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_486:
			this.gridExpanderControlHeadO5O5SRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_493:
			this.ExpanderControlHeadO5General = (global::AcpUI.AcpExpander)target;
			return;
			IL_4A0:
			this.ExpanderControlHeadO5O5NavigationControlsTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_4AD:
			this.HLinkGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkGeneral.Click += this.HLinkClick;
			return;
			IL_4D1:
			this.CVBtnCntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4DE:
			this.CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4EB:
			this.LblCntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520 = (global::AcpUI.AcpLabel)target;
			this.LblCntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_50F:
			this.LblRadErgoControlO5NaviControlName_A41378 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoControlO5NaviControlName_A41378.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_533:
			this.ExpanderControlHeadO5O5NavigationControlsTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_54D:
			this.LblRadErgoControlO5NaviControlFeature_A41379 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoControlO5NaviControlFeature_A41379.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_571:
			this.ExpanderControlHeadO5GeneralGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_57E:
			this.CVBtnCntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_58B:
			this.RTDBtnCntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_598:
			this.CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193 = (global::AcpUI.AcpTextBox)target;
			this.CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5BC:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_5C9:
			this.ExpanderControlHeadO5O5NavigationControlsTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_5D6:
			this.RTDBtnCntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5E3:
			this.CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754 = (global::AcpUI.AcpComboBox)target;
			this.CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_607:
			num = (short)1219493888;
			short num4 = num;
			this.CpyBtnCntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_63D:
			this.LblCntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754 = (global::AcpUI.AcpLabel)target;
			this.LblCntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_661:
			this.RecNavToolbarExpanderControlHeadO5O5NavigationControlsTable = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderControlHeadO5O5NavigationControlsTable.ModeClick += this.OnModeClick;
			return;
			IL_685:
			this.RadErgoControlO5NaviControlFeature_A41379Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_692:
			this.LblCntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753 = (global::AcpUI.AcpLabel)target;
			this.LblCntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_6B6:
			this.CpyBtnCntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_6C3:
			this.RadErgoControlO5NaviControlName_A41378_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_6D0:
			this.RTDBtnRadErgoControlO5NaviControlFeature_A41379 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_6DD:
			this.HLinkO5NavigationControlsExpander = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkO5NavigationControlsExpander.Click += this.HLinkClick;
			return;
			IL_701:
			this.HLinkControlHeadO5GraphicalView = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkControlHeadO5GraphicalView.Click += this.HLinkClick;
			return;
			IL_725:
			this.b = true;
		}

		// Token: 0x06008883 RID: 34947 RVA: 0x007F2C74 File Offset: 0x007F0E74
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num = (short)1677983744;
			short num2 = num;
			switch (connectionId)
			{
			case 2:
				((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 3:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 4:
			{
				num = (short)62460805;
				short num3 = num;
				num = (short)2093486981;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1390215168;
					if (num != 0)
					{
					}
					((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				}
				break;
			}
			case 5:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 6:
				((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 7:
				break;
			default:
				num = (short)1003749377;
				if (num != 0)
				{
				}
				return;
			}
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x04004008 RID: 16392
		private bool a;

		// Token: 0x04004009 RID: 16393
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x0400400A RID: 16394
		internal global::System.Windows.Documents.Hyperlink HLinkControlHeadO5GraphicalView;

		// Token: 0x0400400B RID: 16395
		internal global::System.Windows.Documents.Hyperlink HLinkGeneral;

		// Token: 0x0400400C RID: 16396
		internal global::System.Windows.Documents.Hyperlink HLinkO5NavigationControlsExpander;

		// Token: 0x0400400D RID: 16397
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x0400400E RID: 16398
		internal global::AcpUI.AcpExpander ExpanderControlHeadO5GraphicalView;

		// Token: 0x0400400F RID: 16399
		internal global::ControlHeadGraphicView.O5GraphicView myO5GraphicView;

		// Token: 0x04004010 RID: 16400
		internal global::AcpUI.AcpExpander ExpanderControlHeadO5General;

		// Token: 0x04004011 RID: 16401
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderControlHeadO5O5;

		// Token: 0x04004012 RID: 16402
		internal global::System.Windows.Controls.Grid ExpanderControlHeadO5GeneralGrid;

		// Token: 0x04004013 RID: 16403
		internal global::System.Windows.Controls.Grid ExpanderControlHeadO5O5Grid;

		// Token: 0x04004014 RID: 16404
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadO5O5TableView;

		// Token: 0x04004015 RID: 16405
		internal global::AcpUI.AcpXamDataPresenter ExpanderControlHeadO5O5;

		// Token: 0x04004016 RID: 16406
		internal global::Infragistics.Windows.DataPresenter.UnboundField CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520_Col;

		// Token: 0x04004017 RID: 16407
		internal global::Infragistics.Windows.DataPresenter.UnboundField CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753_Col;

		// Token: 0x04004018 RID: 16408
		internal global::Infragistics.Windows.DataPresenter.UnboundField CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754_Col;

		// Token: 0x04004019 RID: 16409
		internal global::Infragistics.Windows.DataPresenter.UnboundField CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193_Col;

		// Token: 0x0400401A RID: 16410
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadO5O5SRecView;

		// Token: 0x0400401B RID: 16411
		internal global::System.Windows.Controls.Grid gridExpanderControlHeadO5O5SRecView;

		// Token: 0x0400401C RID: 16412
		internal global::AcpUI.AcpLabel CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520;

		// Token: 0x0400401D RID: 16413
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520;

		// Token: 0x0400401E RID: 16414
		internal global::AcpUI.AcpLabel LblCntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520;

		// Token: 0x0400401F RID: 16415
		internal global::AcpUI.AcpRtdButton RTDBtnCntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520;

		// Token: 0x04004020 RID: 16416
		internal global::AcpUI.AcpCopyButton CpyBtnCntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520;

		// Token: 0x04004021 RID: 16417
		internal global::AcpUI.AcpLabel CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520Comp;

		// Token: 0x04004022 RID: 16418
		internal global::AcpUI.AcpComboBox CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753;

		// Token: 0x04004023 RID: 16419
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753;

		// Token: 0x04004024 RID: 16420
		internal global::AcpUI.AcpLabel LblCntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753;

		// Token: 0x04004025 RID: 16421
		internal global::AcpUI.AcpRtdButton RTDBtnCntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753;

		// Token: 0x04004026 RID: 16422
		internal global::AcpUI.AcpCopyButton CpyBtnCntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753;

		// Token: 0x04004027 RID: 16423
		internal global::AcpUI.AcpLabel CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753Comp;

		// Token: 0x04004028 RID: 16424
		internal global::AcpUI.AcpComboBox CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754;

		// Token: 0x04004029 RID: 16425
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754;

		// Token: 0x0400402A RID: 16426
		internal global::AcpUI.AcpLabel LblCntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754;

		// Token: 0x0400402B RID: 16427
		internal global::AcpUI.AcpRtdButton RTDBtnCntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754;

		// Token: 0x0400402C RID: 16428
		internal global::AcpUI.AcpCopyButton CpyBtnCntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754;

		// Token: 0x0400402D RID: 16429
		internal global::AcpUI.AcpLabel CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754Comp;

		// Token: 0x0400402E RID: 16430
		internal global::AcpUI.AcpTextBox CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193;

		// Token: 0x0400402F RID: 16431
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193;

		// Token: 0x04004030 RID: 16432
		internal global::AcpUI.AcpLabel LblCntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193;

		// Token: 0x04004031 RID: 16433
		internal global::AcpUI.AcpCopyButton CpyBtnCntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193;

		// Token: 0x04004032 RID: 16434
		internal global::AcpUI.AcpLabel CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193Comp;

		// Token: 0x04004033 RID: 16435
		internal global::AcpUI.AcpExpander ExpanderControlHeadO5O5NavigationControlsExpander;

		// Token: 0x04004034 RID: 16436
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderControlHeadO5O5NavigationControlsTable;

		// Token: 0x04004035 RID: 16437
		internal global::System.Windows.Controls.Grid ExpanderControlHeadO5O5NavigationControlsExpanderGrid;

		// Token: 0x04004036 RID: 16438
		internal global::System.Windows.Controls.Grid ExpanderControlHeadO5O5NavigationControlsTableGrid;

		// Token: 0x04004037 RID: 16439
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadO5O5NavigationControlsTableTableView;

		// Token: 0x04004038 RID: 16440
		internal global::AcpUI.AcpXamDataPresenter ExpanderControlHeadO5O5NavigationControlsTable;

		// Token: 0x04004039 RID: 16441
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoControlO5NaviControlName_A41378_Col;

		// Token: 0x0400403A RID: 16442
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoControlO5NaviControlFeature_A41379_Col;

		// Token: 0x0400403B RID: 16443
		internal global::AcpUI.AcpGroupBox ExpanderControlHeadO5O5NavigationControlsTableSRecView;

		// Token: 0x0400403C RID: 16444
		internal global::System.Windows.Controls.Grid gridExpanderControlHeadO5O5NavigationControlsTableSRecView;

		// Token: 0x0400403D RID: 16445
		internal global::AcpUI.AcpLabel RadErgoControlO5NaviControlName_A41378;

		// Token: 0x0400403E RID: 16446
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoControlO5NaviControlName_A41378;

		// Token: 0x0400403F RID: 16447
		internal global::AcpUI.AcpLabel LblRadErgoControlO5NaviControlName_A41378;

		// Token: 0x04004040 RID: 16448
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoControlO5NaviControlName_A41378;

		// Token: 0x04004041 RID: 16449
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoControlO5NaviControlName_A41378;

		// Token: 0x04004042 RID: 16450
		internal global::AcpUI.AcpLabel RadErgoControlO5NaviControlName_A41378Comp;

		// Token: 0x04004043 RID: 16451
		internal global::AcpUI.AcpComboBox RadErgoControlO5NaviControlFeature_A41379;

		// Token: 0x04004044 RID: 16452
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoControlO5NaviControlFeature_A41379;

		// Token: 0x04004045 RID: 16453
		internal global::AcpUI.AcpLabel LblRadErgoControlO5NaviControlFeature_A41379;

		// Token: 0x04004046 RID: 16454
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoControlO5NaviControlFeature_A41379;

		// Token: 0x04004047 RID: 16455
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoControlO5NaviControlFeature_A41379;

		// Token: 0x04004048 RID: 16456
		internal global::AcpUI.AcpLabel RadErgoControlO5NaviControlFeature_A41379Comp;

		// Token: 0x04004049 RID: 16457
		private bool b;
	}
}
