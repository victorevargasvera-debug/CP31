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

namespace Motorola.MackinawCPS.CoreFeatures.RadioVIPs
{
	// Token: 0x020002EF RID: 751
	public class PageRadioVIPs : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x06007A30 RID: 31280 RVA: 0x006EF77C File Offset: 0x006ED97C
		public PageRadioVIPs()
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

		// Token: 0x06007A31 RID: 31281 RVA: 0x006EF7B4 File Offset: 0x006ED9B4
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1296760832;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)482148358;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					object obj;
					global::AcpUI.AcpExpander acpExpander;
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
					{
						num = (short)1719992320;
						short num3 = num;
						if (obj != null)
						{
							num = (short)57147401;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_20A;
					}
					case 1:
						try
						{
							num = (short)683212803;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									if (acpExpander != null)
									{
										num = (short)1661468674;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 2:
									base.Expanders.Add(acpExpander);
									num = (short)515440640;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_D5;
									}
									continue;
								case 4:
									if (!enumerator.MoveNext())
									{
										num = (short)341442565;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
									num = (short)1815609345;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									num = (short)386465798;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_192;
								}
								IL_119:
								num = (short)2081947652;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_D5:
								goto IL_119;
							}
							IL_192:
							goto IL_29D;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_1B4;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_1A1:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)304152577;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_209;
								case 1:
									disposable.Dispose();
									num = (short)504299522;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_207;
								}
								goto IL_1B4;
							}
							IL_207:
							IL_209:
							goto EndFinally_9;
							IL_1B4:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1415577600;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_1A1;
							EndFinally_9:;
						}
						goto IL_20A;
						IL_29D:
						base.OnLoaded(sender, e);
						this.a = true;
						num = (short)1420296196;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						obj = null;
						obj = this.RecNavToolbarExpanderRadioVIPsRadioVIP.MyRecordsetDataSource;
						goto IL_2D8;
					case 3:
						goto IL_398;
					case 4:
						goto IL_2C5;
					case 5:
						goto IL_20A;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_6D;
						}
						continue;
					case 7:
					{
						num = (short)1340805276;
						short num4 = num;
						num = (short)1075450012;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2D8;
						default:
							num = (short)1192230912;
							if (num != 0)
							{
							}
							if (obj != null)
							{
								num = (short)1417084936;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_398;
						}
						break;
					}
					case 8:
					{
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderRadioVIPsRadioVIP.MyDataPresenter = this.ExpanderRadioVIPsRadioVIP;
						num = (short)425394179;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderRadioVIPsGCAIVIP.MyDataPresenter = this.ExpanderRadioVIPsGCAIVIP;
						num = (short)1757937669;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_6D:
					if (!this.a)
					{
						num = (short)1311047682;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_20A:
					num = (short)25296897;
					if (num != 0)
					{
					}
					acpExpander = null;
					enumerator = this.MyStackPanel.Children.GetEnumerator();
					num = (short)1960902657;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2D8:
					num = (short)983564295;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_398:
					obj = this.RecNavToolbarExpanderRadioVIPsGCAIVIP.MyRecordsetDataSource;
					num = (short)2023292928;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2C5:
				this.MyStackPanel.Children[0].Focus();
				return;
			}
		}

		// Token: 0x06007A32 RID: 31282 RVA: 0x006EFC00 File Offset: 0x006EDE00
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
				num = (short)297467904;
				short num2 = num;
				int num3;
				switch (num3)
				{
				case 0:
					if (this.a)
					{
						num = (short)805175297;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					base.OnUnloaded(sender, e);
					this.a = false;
					num = (short)1234632706;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_148;
				}
				break;
			}
			IL_44:
			this.RecNavToolbarExpanderRadioVIPsRadioVIP.DataContext = null;
			this.RecNavToolbarExpanderRadioVIPsGCAIVIP.DataContext = null;
			this.RecNavToolbarExpanderRadioVIPsRadioVIP.MyDataPresenter = null;
			this.RecNavToolbarExpanderRadioVIPsGCAIVIP.MyDataPresenter = null;
			num = (short)283591804;
			short num4 = num;
			num = (short)408896636;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_148:
				break;
			default:
			{
				num = (short)363921409;
				if (num != 0)
				{
				}
				num = (short)1311506432;
				if (num != 0)
				{
				}
				num = (short)1138294784;
				int num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06007A33 RID: 31283 RVA: 0x006EFD58 File Offset: 0x006EDF58
		public override void SetDataContext()
		{
			short num = (short)1502871563;
			int num2 = (int)((global::System.IntPtr)num);
			object feature;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1710358528;
					short num3 = num;
					num = (short)1655963662;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10218].EmbeddedRecset != null)
					{
						num = (short)124583957;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_37C;
				case 2:
					goto IL_37C;
				case 3:
					goto IL_496;
				case 4:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)1635909637;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderRadioVIPsRadioVIP).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderRadioVIPsGCAIVIP).MySecondaryRecordsetDataSource = null;
					num = (short)698286087;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2125);
					num = (short)313262098;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)1233256456;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 7:
					return;
				case 8:
					num = (short)439615501;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					num = (short)1857159169;
					if (num != 0)
					{
					}
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)275578890;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_37C;
				case 10:
					num = (short)967442444;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					switch (0)
					{
					case 0:
						goto IL_86;
					}
					continue;
				case 12:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10218] != null)
					{
						num = (short)1076625431;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_37C;
				case 13:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10797] != null)
					{
						num = (short)270663680;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 14:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10797].EmbeddedRecset != null)
					{
						num = (short)590151695;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 15:
					goto IL_1FC;
				case 16:
					goto IL_143;
				case 17:
					num = (short)1282801673;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					if (feature != null)
					{
						num = (short)1353908241;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_37C;
				case 19:
					num = (short)372834310;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
				{
					num = (short)465744959;
					short num4 = num;
					num = (short)493204543;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_496;
					default:
						num = (short)1129709568;
						if (num != 0)
						{
						}
						base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2125);
						num = (short)672792579;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 21:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderRadioVIPsRadioVIP).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10218].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderRadioVIPsRadioVIP).SyncDataSources();
					num = (short)2009595906;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					if (feature != null)
					{
						num = (short)922026003;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 23:
					num = (short)160038913;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_86:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)1738604564;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2125);
				num = (short)64421904;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_143:
				num = (short)198443012;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_496:
				goto IL_143;
				IL_37C:
				num = (short)1513488406;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1FC:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderRadioVIPsGCAIVIP).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10797].EmbeddedRecset;
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderRadioVIPsGCAIVIP).SyncDataSources();
		}

		// Token: 0x06007A34 RID: 31284 RVA: 0x006F0250 File Offset: 0x006EE450
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 16;
			short num = (short)261816320;
			switch (num)
			{
			default:
			{
				num = (short)225574925;
				int num2 = (int)((global::System.IntPtr)num);
				object myRecordsetDataSource2;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1313538054;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource = this.RecNavToolbarExpanderRadioVIPsRadioVIP.MyRecordsetDataSource;
						num = (short)1627389963;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (myRecordsetDataSource2 != null)
						{
							num = (short)1942683655;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3D1;
					case 3:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1854865409;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)351666192;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_10A;
					case 5:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("菐뛒뛔駖룘귚觜냞軠迢蟤蛦鯨껪闬鿮郰鷲釴鋶诸ꧺ鳼鯾栀氂匄丆夈砊䨌䰎倐娒䌔帖䤘", a_))
						{
							num = (short)31326217;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3D1;
					case 6:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("菐뛒뛔駖룘귚觜냞軠迢蟤蛦鯨껪闬鿮郰鷲釴鋶诸ꧺ鳼鯾栀氂匄丆夈砊弌渎甐稒稔䄖倘䬚", a_))
						{
							num = (short)1922498568;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10A;
					case 7:
						goto IL_105;
					case 8:
						num = (short)271253507;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)2041577486;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						object myRecordsetDataSource;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
						global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInner item = (global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInner)collectionView.CurrentItem;
						collectionView.MoveCurrentTo(item);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)1728118788;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						object myRecordsetDataSource;
						if (myRecordsetDataSource != null)
						{
							num = (short)343146496;
							short num3 = num;
							num = (short)156893194;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10A;
					}
					case 12:
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						myRecordsetDataSource2 = this.RecNavToolbarExpanderRadioVIPsGCAIVIP.MyRecordsetDataSource;
						num = (short)2045706242;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						switch (0)
						{
						case 0:
							goto IL_90;
						}
						continue;
					case 14:
						goto IL_245;
					case 15:
					{
						num = (short)1769976955;
						short num4 = num;
						num = (short)862041211;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_245;
						default:
							goto IL_2C9;
						}
						break;
					}
					case 16:
						goto IL_10A;
					}
					IL_90:
					if (A_0 is global::AcpUI.AcpRecNavToolbar)
					{
						num = (short)1678311424;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3D1;
					IL_10A:
					num = (short)1403453445;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_245:
					if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
					{
						num = (short)1598423052;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)1036189711;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_105:
				global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource2);
				global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.GCAIVIPInner item2 = (global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.GCAIVIPInner)collectionView2.CurrentItem;
				collectionView2.MoveCurrentTo(item2);
				((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
				return;
				IL_2C9:
				num = (short)1486749696;
				if (num != 0)
				{
				}
				IL_3D1:
				num = (short)1354432513;
				if (num != 0)
				{
				}
				return;
			}
			}
		}

		// Token: 0x06007A35 RID: 31285 RVA: 0x006F0658 File Offset: 0x006EE858
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)800849921;
			if (num != 0)
			{
			}
			num = (short)788660224;
			short num2 = num;
			num = (short)1979318429;
			short num3 = num;
			num = (short)497156253;
			switch (num3 == num)
			{
			}
			num = (short)909049856;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x06007A36 RID: 31286 RVA: 0x006F070C File Offset: 0x006EE90C
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1168679364;
			short num2 = num;
			num = (short)232497604;
			switch (num2 == num)
			{
			default:
			{
				num = (short)895942656;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)961150976;
			if (num != 0)
			{
			}
			num = (short)641269761;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06007A37 RID: 31287 RVA: 0x006F07BC File Offset: 0x006EE9BC
		internal void OnExpanderRadioVIPsRadioVIPClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			short num;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInner item;
			for (;;)
			{
				IL_0A:
				num = (short)50003968;
				short num2 = num;
				int num3;
				switch (num3)
				{
				case 0:
					if (myRecordsetDataSource != null)
					{
						num = (short)293601281;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_14F;
				case 1:
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderRadioVIPsRadioVIP.SyncDataSources();
					num = (short)926023682;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_14D;
				}
				break;
			}
			IL_44:
			item = (global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderRadioVIPsRadioVIP.MyRecordsetDataSource;
			num = (short)1390097050;
			short num4 = num;
			num = (short)556610202;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_14D:
				break;
			default:
			{
				num = (short)2120876033;
				if (num != 0)
				{
				}
				num = (short)4521984;
				if (num != 0)
				{
				}
				num = (short)346423296;
				int num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			}
			IL_14F:
			this.RecNavToolbarExpanderRadioVIPsRadioVIP.TableMode = false;
		}

		// Token: 0x06007A38 RID: 31288 RVA: 0x006F0924 File Offset: 0x006EEB24
		internal void OnExpanderRadioVIPsGCAIVIPClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_45;
			}
			short num;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.GCAIVIPInner item;
			for (;;)
			{
				IL_0A:
				num = (short)1585250304;
				short num2 = num;
				int num3;
				switch (num3)
				{
				case 0:
					if (myRecordsetDataSource != null)
					{
						num = (short)1666318337;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_153;
				case 1:
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderRadioVIPsGCAIVIP.SyncDataSources();
					num = (short)814743553;
					if (num != 0)
					{
					}
					num = (short)1520173058;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_151;
				}
				break;
			}
			IL_45:
			item = (global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.GCAIVIPInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderRadioVIPsGCAIVIP.MyRecordsetDataSource;
			num = (short)1874556345;
			short num4 = num;
			num = (short)2137945529;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_151:
				break;
			default:
			{
				num = (short)1767112704;
				if (num != 0)
				{
				}
				num = (short)892141568;
				int num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			}
			IL_153:
			this.RecNavToolbarExpanderRadioVIPsGCAIVIP.TableMode = false;
		}

		// Token: 0x06007A39 RID: 31289 RVA: 0x006F0A90 File Offset: 0x006EEC90
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 6;
			short num = (short)650441184;
			short num2 = num;
			num = (short)646640096;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1085734912;
				if (num != 0)
				{
				}
				if (!this.b)
				{
					num = (short)698089472;
					short num3 = num;
					num = (short)1247346689;
					if (num != 0)
					{
					}
					this.b = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("裈ꟊꇌ觎듐닒ꇔꋖꯘ뻚껜苠賢裤韦蛨藪裬臮藰\udcf2蟴零鷸鋺鋼\udafe㌀㌂怄甆済搊挌怎簐稒瘔搖㰘⤚ⴜ簞丠䴢䌤並丨帪弬丮䔰娲娴夶ᘸ堺刼儾㕀ㅂ⩄⭆㩈摊㽌⹎㕐㩒㩔牖歘歚⭜㙞ᅠၢ䩤ᕦࡨཪѬnݰᩲմѶ坸ͺᱼቾ", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				break;
			}
		}

		// Token: 0x06007A3A RID: 31290 RVA: 0x006F0B70 File Offset: 0x006EED70
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1543831553;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_2F1;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 2:
					num = (short)1383071744;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_31:
				switch (connectionId)
				{
				case 1:
					goto IL_791;
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
					goto IL_96E;
				case 12:
					goto IL_415;
				case 13:
					goto IL_4EA;
				case 14:
					goto IL_858;
				case 15:
					goto IL_777;
				case 16:
					goto IL_584;
				case 17:
					goto IL_87C;
				case 18:
					goto IL_784;
				case 19:
					goto IL_67C;
				case 20:
					goto IL_76A;
				case 21:
					goto IL_22C;
				case 22:
					goto IL_491;
				case 23:
					goto IL_528;
				case 24:
					goto IL_303;
				case 25:
					goto IL_591;
				case 26:
					goto IL_631;
				case 27:
					goto IL_2F6;
				case 28:
					goto IL_1FB;
				case 29:
					goto IL_399;
				case 30:
					goto IL_7C2;
				case 31:
					goto IL_28E;
				case 32:
					goto IL_310;
				case 33:
					goto IL_3E4;
				case 34:
					goto IL_3D7;
				case 35:
					goto IL_51B;
				case 36:
					goto IL_3B3;
				case 37:
					goto IL_5C2;
				case 38:
					goto IL_375;
				case 39:
					goto IL_8F8;
				case 40:
					goto IL_954;
				case 41:
					goto IL_42F;
				case 42:
					goto IL_8C7;
				case 43:
					goto IL_831;
				case 44:
					goto IL_460;
				case 45:
					goto IL_34E;
				case 46:
					goto IL_35B;
				case 47:
					goto IL_64B;
				case 48:
					goto IL_71F;
				case 49:
					goto IL_2CC;
				case 50:
					goto IL_6B0;
				case 51:
					goto IL_6A3;
				case 52:
					goto IL_6D4;
				case 53:
					goto IL_422;
				case 54:
					goto IL_7E6;
				case 55:
					goto IL_712;
				case 56:
					goto IL_3F1;
				case 57:
					goto IL_8BA;
				case 58:
					goto IL_8AD;
				case 59:
					goto IL_6E1;
				case 60:
					goto IL_658;
				case 61:
					goto IL_1EE;
				case 62:
					goto IL_26A;
				case 63:
					goto IL_696;
				case 64:
					goto IL_63E;
				case 65:
					goto IL_75D;
				case 66:
					goto IL_59E;
				case 67:
					goto IL_368;
				case 68:
					goto IL_743;
				case 69:
					goto IL_83E;
				case 70:
					goto IL_8A0;
				case 71:
					goto IL_239;
				case 72:
					goto IL_824;
				case 73:
					goto IL_1E1;
				case 74:
					goto IL_817;
				case 75:
					goto IL_689;
				case 76:
					goto IL_5F3;
				case 77:
					goto IL_43C;
				case 78:
					goto IL_80A;
				case 79:
					goto IL_560;
				case 80:
					goto IL_341;
				case 81:
					goto IL_8EB;
				case 82:
					goto IL_750;
				case 83:
					goto IL_208;
				case 84:
					goto IL_3A6;
				case 85:
					goto IL_5CF;
				case 86:
					goto IL_600;
				case 87:
					goto IL_484;
				case 88:
					goto IL_29B;
				case 89:
					goto IL_60D;
				case 90:
					goto IL_334;
				case 91:
					goto IL_246;
				case 92:
					goto IL_947;
				case 93:
					goto IL_50E;
				case 94:
					goto IL_84B;
				case 95:
					goto IL_6EE;
				case 96:
					goto IL_912;
				case 97:
					goto IL_2A8;
				case 98:
					goto IL_905;
				case 99:
					goto IL_961;
				default:
					num = (short)1924530178;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_1E1:
			this.GCAIVipInputFeature_42623_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1EE:
			this.CVBtnRadVipKey_A22500 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1FB:
			this.ExpanderRadioVIPsRadioVIPSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_208:
			this.GCAIVipInputBCO_42620 = (global::AcpUI.AcpComboBox)target;
			this.GCAIVipInputBCO_42620.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_22C:
			this.ExpanderRadioVIPsRadioVIP = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_239:
			this.RadioGCAIVipName_42622_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_246:
			this.LblGCAIVipInputFeature_42623 = (global::AcpUI.AcpLabel)target;
			this.LblGCAIVipInputFeature_42623.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_26A:
			this.LblRadVipKey_A22500 = (global::AcpUI.AcpLabel)target;
			this.LblRadVipKey_A22500.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_28E:
			this.CVBtnRadVipName_A22501 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_29B:
			this.GCAIVipInputBCO_42620Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2A8:
			this.LblRadioGCAIVIPKey_42621 = (global::AcpUI.AcpLabel)target;
			this.LblRadioGCAIVIPKey_42621.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2CC:
			this.CVBtnRadVipOutputBCO_A20946 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2F1:
			goto IL_96E;
			IL_2F6:
			this.RadVipKey_A22500_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_303:
			this.RadVipInputFeature_A21329_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_310:
			this.LblRadVipName_A22501 = (global::AcpUI.AcpLabel)target;
			this.LblRadVipName_A22501.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_334:
			this.CVBtnGCAIVipInputFeature_42623 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_341:
			this.RTDBtnRadioGCAIVipName_42622 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_34E:
			this.RTDBtnRadVipInputFeature_A21329 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_35B:
			this.CpyBtnRadVipInputFeature_A21329 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_368:
			this.ExpanderRadioVIPsGCAIGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_375:
			this.LblRadVipInputBCO_A21328 = (global::AcpUI.AcpLabel)target;
			this.LblRadVipInputBCO_A21328.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_399:
			this.gridExpanderRadioVIPsRadioVIPSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_3A6:
			this.CVBtnGCAIVipInputBCO_42620 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3B3:
			this.RadVipInputBCO_A21328 = (global::AcpUI.AcpComboBox)target;
			this.RadVipInputBCO_A21328.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3D7:
			this.CpyBtnRadVipName_A22501 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3E4:
			this.RTDBtnRadVipName_A22501 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3F1:
			this.LblRadVipOutputFeature_A20947 = (global::AcpUI.AcpLabel)target;
			this.LblRadVipOutputFeature_A20947.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_415:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_422:
			this.RadVipOutputBCO_A20946Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_42F:
			this.RadVipInputBCO_A21328Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_43C:
			this.RadioGCAIVipName_42622 = (global::AcpUI.AcpLabel)target;
			this.RadioGCAIVipName_42622.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_460:
			this.LblRadVipInputFeature_A21329 = (global::AcpUI.AcpLabel)target;
			this.LblRadVipInputFeature_A21329.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_484:
			this.CpyBtnGCAIVipInputBCO_42620 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_491:
			num = (short)2071707132;
			short num3 = num;
			num = (short)1092468220;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_29B;
			default:
				num = (short)1303642112;
				if (num != 0)
				{
				}
				this.RadVipName_A22501_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
				return;
			}
			IL_4EA:
			this.HLinkGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkGeneral.Click += this.HLinkClick;
			return;
			IL_50E:
			this.CpyBtnGCAIVipInputFeature_42623 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_51B:
			this.RadVipName_A22501Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_528:
			num = (short)198115328;
			short num4 = num;
			this.RadVipInputBCO_A21328_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_560:
			this.LblRadioGCAIVipName_42622 = (global::AcpUI.AcpLabel)target;
			this.LblRadioGCAIVipName_42622.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_584:
			this.ExpanderRadioVIPsGeneral = (global::AcpUI.AcpExpander)target;
			return;
			IL_591:
			this.RadVipOutputBCO_A20946_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_59E:
			this.RecNavToolbarExpanderRadioVIPsGCAIVIP = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderRadioVIPsGCAIVIP.ModeClick += this.OnModeClick;
			return;
			IL_5C2:
			this.CVBtnRadVipInputBCO_A21328 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5CF:
			this.LblGCAIVipInputBCO_42620 = (global::AcpUI.AcpLabel)target;
			this.LblGCAIVipInputBCO_42620.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5F3:
			this.gridExpanderRadioVIPsGCAIVIPSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_600:
			this.RTDBtnGCAIVipInputBCO_42620 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_60D:
			this.GCAIVipInputFeature_42623 = (global::AcpUI.AcpComboBox)target;
			this.GCAIVipInputFeature_42623.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_631:
			this.RadVipOutputFeature_A20947_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_63E:
			this.RadVipKey_A22500Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_64B:
			this.RadVipInputFeature_A21329Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_658:
			this.RadVipKey_A22500 = (global::AcpUI.AcpTextBox)target;
			this.RadVipKey_A22500.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_67C:
			this.ExpanderRadioVIPsRadioVIPGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_689:
			this.ExpanderRadioVIPsGCAIVIPSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_696:
			this.CpyBtnRadVipKey_A22500 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_6A3:
			this.RTDBtnRadVipOutputBCO_A20946 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_6B0:
			this.LblRadVipOutputBCO_A20946 = (global::AcpUI.AcpLabel)target;
			this.LblRadVipOutputBCO_A20946.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_6D4:
			this.CpyBtnRadVipOutputBCO_A20946 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_6E1:
			this.RadVipOutputFeature_A20947Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_6EE:
			this.RadioGCAIVIPKey_42621 = (global::AcpUI.AcpTextBox)target;
			this.RadioGCAIVIPKey_42621.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_712:
			this.CVBtnRadVipOutputFeature_A20947 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_71F:
			this.RadVipOutputBCO_A20946 = (global::AcpUI.AcpComboBox)target;
			this.RadVipOutputBCO_A20946.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_743:
			this.ExpanderRadioVIPsGCAIVIPGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_750:
			this.RadioGCAIVipName_42622Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_75D:
			this.ExpanderRadioVIPsGCAI = (global::AcpUI.AcpExpander)target;
			return;
			IL_76A:
			this.ExpanderRadioVIPsRadioVIPTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_777:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_784:
			this.ExpanderRadioVIPsGeneralGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_791:
			((global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.PageRadioVIPs)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.PageRadioVIPs)target).Unloaded += this.OnUnloaded;
			return;
			IL_7C2:
			this.RadVipName_A22501 = (global::AcpUI.AcpLabel)target;
			this.RadVipName_A22501.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_7E6:
			this.RadVipOutputFeature_A20947 = (global::AcpUI.AcpComboBox)target;
			this.RadVipOutputFeature_A20947.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_80A:
			this.CVBtnRadioGCAIVipName_42622 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_817:
			this.RadioGCAIVIPKey_42621_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_824:
			this.GCAIVipInputBCO_42620_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_831:
			this.CVBtnRadVipInputFeature_A21329 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_83E:
			this.ExpanderRadioVIPsGCAIVIPTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_84B:
			this.GCAIVipInputFeature_42623Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_858:
			this.HLinkGCAI = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkGCAI.Click += this.HLinkClick;
			return;
			IL_87C:
			this.RecNavToolbarExpanderRadioVIPsRadioVIP = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderRadioVIPsRadioVIP.ModeClick += this.OnModeClick;
			return;
			IL_8A0:
			this.ExpanderRadioVIPsGCAIVIP = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_8AD:
			this.CpyBtnRadVipOutputFeature_A20947 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_8BA:
			this.RTDBtnRadVipOutputFeature_A20947 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_8C7:
			this.RadVipInputFeature_A21329 = (global::AcpUI.AcpComboBox)target;
			this.RadVipInputFeature_A21329.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_8EB:
			this.CpyBtnRadioGCAIVipName_42622 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_8F8:
			this.RTDBtnRadVipInputBCO_A21328 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_905:
			this.CpyBtnRadioGCAIVIPKey_42621 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_912:
			num = (short)1643905025;
			if (num != 0)
			{
			}
			this.CVBtnRadioGCAIVIPKey_42621 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_947:
			this.RTDBtnGCAIVipInputFeature_42623 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_954:
			this.CpyBtnRadVipInputBCO_A21328 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_961:
			this.RadioGCAIVIPKey_42621Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_96E:
			this.b = true;
		}

		// Token: 0x06007A3B RID: 31291 RVA: 0x006F14F4 File Offset: 0x006EF6F4
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 2:
				((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 3:
			{
				short num = (short)90733518;
				short num2 = num;
				num = (short)302349262;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1122500608;
					short num3 = num;
					num = (short)834011136;
					if (num != 0)
					{
					}
					((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				}
				}
				break;
			}
			case 4:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 5:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 6:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 7:
				break;
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
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			default:
			{
				short num = (short)637927425;
				if (num != 0)
				{
				}
				return;
			}
			}
			((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x04003363 RID: 13155
		private bool a;

		// Token: 0x04003364 RID: 13156
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x04003365 RID: 13157
		internal global::System.Windows.Documents.Hyperlink HLinkGeneral;

		// Token: 0x04003366 RID: 13158
		internal global::System.Windows.Documents.Hyperlink HLinkGCAI;

		// Token: 0x04003367 RID: 13159
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x04003368 RID: 13160
		internal global::AcpUI.AcpExpander ExpanderRadioVIPsGeneral;

		// Token: 0x04003369 RID: 13161
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderRadioVIPsRadioVIP;

		// Token: 0x0400336A RID: 13162
		internal global::System.Windows.Controls.Grid ExpanderRadioVIPsGeneralGrid;

		// Token: 0x0400336B RID: 13163
		internal global::System.Windows.Controls.Grid ExpanderRadioVIPsRadioVIPGrid;

		// Token: 0x0400336C RID: 13164
		internal global::AcpUI.AcpGroupBox ExpanderRadioVIPsRadioVIPTableView;

		// Token: 0x0400336D RID: 13165
		internal global::AcpUI.AcpXamDataPresenter ExpanderRadioVIPsRadioVIP;

		// Token: 0x0400336E RID: 13166
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadVipName_A22501_Col;

		// Token: 0x0400336F RID: 13167
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadVipInputBCO_A21328_Col;

		// Token: 0x04003370 RID: 13168
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadVipInputFeature_A21329_Col;

		// Token: 0x04003371 RID: 13169
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadVipOutputBCO_A20946_Col;

		// Token: 0x04003372 RID: 13170
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadVipOutputFeature_A20947_Col;

		// Token: 0x04003373 RID: 13171
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadVipKey_A22500_Col;

		// Token: 0x04003374 RID: 13172
		internal global::AcpUI.AcpGroupBox ExpanderRadioVIPsRadioVIPSRecView;

		// Token: 0x04003375 RID: 13173
		internal global::System.Windows.Controls.Grid gridExpanderRadioVIPsRadioVIPSRecView;

		// Token: 0x04003376 RID: 13174
		internal global::AcpUI.AcpLabel RadVipName_A22501;

		// Token: 0x04003377 RID: 13175
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadVipName_A22501;

		// Token: 0x04003378 RID: 13176
		internal global::AcpUI.AcpLabel LblRadVipName_A22501;

		// Token: 0x04003379 RID: 13177
		internal global::AcpUI.AcpRtdButton RTDBtnRadVipName_A22501;

		// Token: 0x0400337A RID: 13178
		internal global::AcpUI.AcpCopyButton CpyBtnRadVipName_A22501;

		// Token: 0x0400337B RID: 13179
		internal global::AcpUI.AcpLabel RadVipName_A22501Comp;

		// Token: 0x0400337C RID: 13180
		internal global::AcpUI.AcpComboBox RadVipInputBCO_A21328;

		// Token: 0x0400337D RID: 13181
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadVipInputBCO_A21328;

		// Token: 0x0400337E RID: 13182
		internal global::AcpUI.AcpLabel LblRadVipInputBCO_A21328;

		// Token: 0x0400337F RID: 13183
		internal global::AcpUI.AcpRtdButton RTDBtnRadVipInputBCO_A21328;

		// Token: 0x04003380 RID: 13184
		internal global::AcpUI.AcpCopyButton CpyBtnRadVipInputBCO_A21328;

		// Token: 0x04003381 RID: 13185
		internal global::AcpUI.AcpLabel RadVipInputBCO_A21328Comp;

		// Token: 0x04003382 RID: 13186
		internal global::AcpUI.AcpComboBox RadVipInputFeature_A21329;

		// Token: 0x04003383 RID: 13187
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadVipInputFeature_A21329;

		// Token: 0x04003384 RID: 13188
		internal global::AcpUI.AcpLabel LblRadVipInputFeature_A21329;

		// Token: 0x04003385 RID: 13189
		internal global::AcpUI.AcpRtdButton RTDBtnRadVipInputFeature_A21329;

		// Token: 0x04003386 RID: 13190
		internal global::AcpUI.AcpCopyButton CpyBtnRadVipInputFeature_A21329;

		// Token: 0x04003387 RID: 13191
		internal global::AcpUI.AcpLabel RadVipInputFeature_A21329Comp;

		// Token: 0x04003388 RID: 13192
		internal global::AcpUI.AcpComboBox RadVipOutputBCO_A20946;

		// Token: 0x04003389 RID: 13193
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadVipOutputBCO_A20946;

		// Token: 0x0400338A RID: 13194
		internal global::AcpUI.AcpLabel LblRadVipOutputBCO_A20946;

		// Token: 0x0400338B RID: 13195
		internal global::AcpUI.AcpRtdButton RTDBtnRadVipOutputBCO_A20946;

		// Token: 0x0400338C RID: 13196
		internal global::AcpUI.AcpCopyButton CpyBtnRadVipOutputBCO_A20946;

		// Token: 0x0400338D RID: 13197
		internal global::AcpUI.AcpLabel RadVipOutputBCO_A20946Comp;

		// Token: 0x0400338E RID: 13198
		internal global::AcpUI.AcpComboBox RadVipOutputFeature_A20947;

		// Token: 0x0400338F RID: 13199
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadVipOutputFeature_A20947;

		// Token: 0x04003390 RID: 13200
		internal global::AcpUI.AcpLabel LblRadVipOutputFeature_A20947;

		// Token: 0x04003391 RID: 13201
		internal global::AcpUI.AcpRtdButton RTDBtnRadVipOutputFeature_A20947;

		// Token: 0x04003392 RID: 13202
		internal global::AcpUI.AcpCopyButton CpyBtnRadVipOutputFeature_A20947;

		// Token: 0x04003393 RID: 13203
		internal global::AcpUI.AcpLabel RadVipOutputFeature_A20947Comp;

		// Token: 0x04003394 RID: 13204
		internal global::AcpUI.AcpTextBox RadVipKey_A22500;

		// Token: 0x04003395 RID: 13205
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadVipKey_A22500;

		// Token: 0x04003396 RID: 13206
		internal global::AcpUI.AcpLabel LblRadVipKey_A22500;

		// Token: 0x04003397 RID: 13207
		internal global::AcpUI.AcpCopyButton CpyBtnRadVipKey_A22500;

		// Token: 0x04003398 RID: 13208
		internal global::AcpUI.AcpLabel RadVipKey_A22500Comp;

		// Token: 0x04003399 RID: 13209
		internal global::AcpUI.AcpExpander ExpanderRadioVIPsGCAI;

		// Token: 0x0400339A RID: 13210
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderRadioVIPsGCAIVIP;

		// Token: 0x0400339B RID: 13211
		internal global::System.Windows.Controls.Grid ExpanderRadioVIPsGCAIGrid;

		// Token: 0x0400339C RID: 13212
		internal global::System.Windows.Controls.Grid ExpanderRadioVIPsGCAIVIPGrid;

		// Token: 0x0400339D RID: 13213
		internal global::AcpUI.AcpGroupBox ExpanderRadioVIPsGCAIVIPTableView;

		// Token: 0x0400339E RID: 13214
		internal global::AcpUI.AcpXamDataPresenter ExpanderRadioVIPsGCAIVIP;

		// Token: 0x0400339F RID: 13215
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadioGCAIVipName_42622_Col;

		// Token: 0x040033A0 RID: 13216
		internal global::Infragistics.Windows.DataPresenter.UnboundField GCAIVipInputBCO_42620_Col;

		// Token: 0x040033A1 RID: 13217
		internal global::Infragistics.Windows.DataPresenter.UnboundField GCAIVipInputFeature_42623_Col;

		// Token: 0x040033A2 RID: 13218
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadioGCAIVIPKey_42621_Col;

		// Token: 0x040033A3 RID: 13219
		internal global::AcpUI.AcpGroupBox ExpanderRadioVIPsGCAIVIPSRecView;

		// Token: 0x040033A4 RID: 13220
		internal global::System.Windows.Controls.Grid gridExpanderRadioVIPsGCAIVIPSRecView;

		// Token: 0x040033A5 RID: 13221
		internal global::AcpUI.AcpLabel RadioGCAIVipName_42622;

		// Token: 0x040033A6 RID: 13222
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadioGCAIVipName_42622;

		// Token: 0x040033A7 RID: 13223
		internal global::AcpUI.AcpLabel LblRadioGCAIVipName_42622;

		// Token: 0x040033A8 RID: 13224
		internal global::AcpUI.AcpRtdButton RTDBtnRadioGCAIVipName_42622;

		// Token: 0x040033A9 RID: 13225
		internal global::AcpUI.AcpCopyButton CpyBtnRadioGCAIVipName_42622;

		// Token: 0x040033AA RID: 13226
		internal global::AcpUI.AcpLabel RadioGCAIVipName_42622Comp;

		// Token: 0x040033AB RID: 13227
		internal global::AcpUI.AcpComboBox GCAIVipInputBCO_42620;

		// Token: 0x040033AC RID: 13228
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnGCAIVipInputBCO_42620;

		// Token: 0x040033AD RID: 13229
		internal global::AcpUI.AcpLabel LblGCAIVipInputBCO_42620;

		// Token: 0x040033AE RID: 13230
		internal global::AcpUI.AcpRtdButton RTDBtnGCAIVipInputBCO_42620;

		// Token: 0x040033AF RID: 13231
		internal global::AcpUI.AcpCopyButton CpyBtnGCAIVipInputBCO_42620;

		// Token: 0x040033B0 RID: 13232
		internal global::AcpUI.AcpLabel GCAIVipInputBCO_42620Comp;

		// Token: 0x040033B1 RID: 13233
		internal global::AcpUI.AcpComboBox GCAIVipInputFeature_42623;

		// Token: 0x040033B2 RID: 13234
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnGCAIVipInputFeature_42623;

		// Token: 0x040033B3 RID: 13235
		internal global::AcpUI.AcpLabel LblGCAIVipInputFeature_42623;

		// Token: 0x040033B4 RID: 13236
		internal global::AcpUI.AcpRtdButton RTDBtnGCAIVipInputFeature_42623;

		// Token: 0x040033B5 RID: 13237
		internal global::AcpUI.AcpCopyButton CpyBtnGCAIVipInputFeature_42623;

		// Token: 0x040033B6 RID: 13238
		internal global::AcpUI.AcpLabel GCAIVipInputFeature_42623Comp;

		// Token: 0x040033B7 RID: 13239
		internal global::AcpUI.AcpTextBox RadioGCAIVIPKey_42621;

		// Token: 0x040033B8 RID: 13240
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadioGCAIVIPKey_42621;

		// Token: 0x040033B9 RID: 13241
		internal global::AcpUI.AcpLabel LblRadioGCAIVIPKey_42621;

		// Token: 0x040033BA RID: 13242
		internal global::AcpUI.AcpCopyButton CpyBtnRadioGCAIVIPKey_42621;

		// Token: 0x040033BB RID: 13243
		internal global::AcpUI.AcpLabel RadioGCAIVIPKey_42621Comp;

		// Token: 0x040033BC RID: 13244
		private bool b;
	}
}
