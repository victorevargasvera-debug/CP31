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

namespace Motorola.MackinawCPS.CoreFeatures.PhoneWide
{
	// Token: 0x02000441 RID: 1089
	public class PagePhoneWide : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x0600937A RID: 37754 RVA: 0x008AC238 File Offset: 0x008AA438
		public PagePhoneWide()
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

		// Token: 0x0600937B RID: 37755 RVA: 0x008AC270 File Offset: 0x008AA470
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1172439040;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)491847687;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					object obj;
					global::AcpUI.AcpExpander acpExpander;
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						goto IL_3C3;
					case 1:
						goto IL_33B;
					case 2:
						if (obj != null)
						{
							num = (short)19398662;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3C3;
					case 3:
						if (obj != null)
						{
							num = (short)2146959364;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_27E;
					case 4:
					{
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderPhoneWideDTMFCodesTable.MyDataPresenter = this.ExpanderPhoneWideDTMFCodesTable;
						num = (short)2145386504;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						obj = null;
						obj = this.RecNavToolbarExpanderPhoneWideDTMFTimingTable.MyRecordsetDataSource;
						num = (short)1444020226;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderPhoneWideDTMFTimingTable.MyDataPresenter = this.ExpanderPhoneWideDTMFTimingTable;
						num = (short)1354629120;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						switch (0)
						{
						case 0:
							goto IL_6B;
						}
						continue;
					case 8:
						goto IL_27E;
					case 9:
					{
						try
						{
							num = (short)507576324;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1B6;
								case 1:
									num = (short)1847394305;
									if (num != 0)
									{
									}
									base.Expanders.Add(acpExpander);
									num = (short)1095827461;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									num = (short)979107840;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									if (!enumerator.MoveNext())
									{
										num = (short)200081410;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
									num = (short)2068578310;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_D2;
									}
									continue;
								case 6:
									if (acpExpander != null)
									{
										num = (short)887554049;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								IL_115:
								num = (short)34471939;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_D2:
								goto IL_115;
							}
							IL_1B6:
							goto IL_2EA;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_1D8;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_1C5:
								switch (num2)
								{
								case 0:
									goto IL_27B;
								case 1:
								{
									num = (short)300840204;
									short num3 = num;
									num = (short)8090892;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_1F5;
									default:
										num = (short)1620377600;
										if (num != 0)
										{
										}
										disposable.Dispose();
										num = (short)1965883392;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									goto IL_1F5;
								}
								goto IL_1D8;
								IL_1F5:
								if (disposable == null)
								{
									break;
								}
								num = (short)650379265;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_27B:
							goto EndFinally_9;
							IL_1D8:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)65536002;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_1C5;
							EndFinally_9:;
						}
						goto IL_27E;
						IL_2EA:
						num = (short)2088894464;
						short num4 = num;
						base.OnLoaded(sender, e);
						this.a = true;
						num = (short)2011365377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_6B:
					if (!this.a)
					{
						num = (short)86769669;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_27E:
					acpExpander = null;
					enumerator = this.MyStackPanel.Children.GetEnumerator();
					num = (short)242155529;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3C3:
					obj = this.RecNavToolbarExpanderPhoneWideDTMFCodesTable.MyRecordsetDataSource;
					num = (short)449183747;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_33B:
				this.MyStackPanel.Children[0].Focus();
				return;
			}
		}

		// Token: 0x0600937C RID: 37756 RVA: 0x008AC6BC File Offset: 0x008AA8BC
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
					num2 = (short)1901257577;
					short num3 = num2;
					num2 = (short)193323881;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_87;
					default:
						num2 = (short)46923776;
						if (num2 != 0)
						{
						}
						base.OnUnloaded(sender, e);
						this.a = false;
						num2 = (short)1717239808;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					goto IL_87;
				}
				goto IL_1C;
				IL_87:
				num2 = (short)1064697856;
				short num4 = num2;
				if (!this.a)
				{
					break;
				}
				num2 = (short)862257153;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_1C:
			num2 = (short)336789505;
			if (num2 != 0)
			{
			}
			this.RecNavToolbarExpanderPhoneWideDTMFTimingTable.DataContext = null;
			this.RecNavToolbarExpanderPhoneWideDTMFCodesTable.DataContext = null;
			this.RecNavToolbarExpanderPhoneWideDTMFTimingTable.MyDataPresenter = null;
			this.RecNavToolbarExpanderPhoneWideDTMFCodesTable.MyDataPresenter = null;
			num2 = (short)1448607746;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600937D RID: 37757 RVA: 0x008AC814 File Offset: 0x008AAA14
		public override void SetDataContext()
		{
			short num = (short)1740046339;
			int num2 = (int)((global::System.IntPtr)num);
			object feature;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)47185924;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)1551433738;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (feature != null)
					{
						num = (short)1926037516;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
					num = (short)879034369;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_AC;
					}
					continue;
				case 4:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10000].EmbeddedRecset != null)
					{
						num = (short)155451410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 5:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2000);
					num = (short)2049572884;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10002].EmbeddedRecset != null)
					{
						num = (short)1898905623;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3E8;
				case 7:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10000] != null)
					{
						num = (short)692518912;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 8:
				{
					feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2000);
					num = (short)1135017984;
					short num3 = num;
					num = (short)31588365;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
					num = (short)1019019271;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10002] != null)
					{
						num = (short)1035403279;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3E8;
				case 11:
					num = (short)784859152;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					num = (short)1555759118;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					if (feature != null)
					{
						num = (short)1199177739;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3E8;
				case 14:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)231407625;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 15:
					num = (short)1090453510;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)1421017089;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3E8;
				case 17:
				{
					num = (short)617665069;
					short num4 = num;
					num = (short)2094125613;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)977076224;
						if (num != 0)
						{
						}
						goto IL_3E8;
					}
					break;
				}
				case 18:
					goto IL_23E;
				case 19:
					goto IL_1B0;
				case 20:
					goto IL_1B0;
				case 21:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)1362231304;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderPhoneWideDTMFTimingTable).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderPhoneWideDTMFCodesTable).MySecondaryRecordsetDataSource = null;
					num = (short)2013462550;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					return;
				case 23:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderPhoneWideDTMFTimingTable).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10002].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderPhoneWideDTMFTimingTable).SyncDataSources();
					num = (short)29098001;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_AC:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)119275525;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2000);
				num = (short)502595603;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1B0:
				num = (short)501415957;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3E8:
				num = (short)2014904322;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_23E:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderPhoneWideDTMFCodesTable).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10000].EmbeddedRecset;
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderPhoneWideDTMFCodesTable).SyncDataSources();
		}

		// Token: 0x0600937E RID: 37758 RVA: 0x008ACD08 File Offset: 0x008AAF08
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 6;
			object myRecordsetDataSource2;
			for (;;)
			{
				IL_09:
				short num = (short)2064056320;
				switch (num)
				{
				default:
				{
					num = (short)1490288640;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						num = (short)1337847148;
						short num3 = num;
						num = (short)1983638892;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_09;
						default:
							num = (short)2088304640;
							if (num != 0)
							{
							}
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_DD;
								}
								continue;
							case 1:
								goto IL_15A;
							case 2:
								return;
							case 3:
								if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("闆곈꣊菌껎Ꟑ蟒뫔룖뗘맚볜귞ꓠ鯢闤蛦蟨迪裬鷮ꇰ鯲髴駶鳸곺铼鯾搀䜂億䨆伈䠊戌欎琐怒䄔瘖笘眚砜", a_))
								{
									num = (short)164560907;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								return;
							case 4:
								num = (short)1453391884;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								goto IL_15A;
							case 6:
							{
								((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
								object myRecordsetDataSource = this.RecNavToolbarExpanderPhoneWideDTMFTimingTable.MyRecordsetDataSource;
								num = (short)2093481985;
								if (num != 0)
								{
								}
								num = (short)1141440525;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 7:
								num = (short)562561039;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
							{
								object myRecordsetDataSource;
								global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
								global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFTimingInner item = (global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFTimingInner)collectionView.CurrentItem;
								collectionView.MoveCurrentTo(item);
								((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
								num = (short)580648965;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 9:
								((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
								myRecordsetDataSource2 = this.RecNavToolbarExpanderPhoneWideDTMFCodesTable.MyRecordsetDataSource;
								num = (short)1586626570;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 10:
								if (myRecordsetDataSource2 != null)
								{
									num = (short)630587406;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								return;
							case 11:
								num = (short)1037631504;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 12:
								if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
								{
									num = (short)2142240774;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
								num = (short)79560705;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 13:
							{
								num = (short)1753415680;
								short num4 = num;
								object myRecordsetDataSource;
								if (myRecordsetDataSource != null)
								{
									num = (short)1250295816;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_15A;
							}
							case 14:
								goto IL_155;
							case 15:
								if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("闆곈꣊菌껎Ꟑ蟒뫔룖뗘맚볜귞ꓠ鯢闤蛦蟨迪裬鷮ꇰ鯲髴駶鳸곺铼鯾搀䜂億䨆伈弊搌戎砐紒爔䌖砘礚焜稞", a_))
								{
									num = (short)1723662340;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_15A;
							case 16:
								if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
								{
									num = (short)1991376905;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
								num = (short)1251278850;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_DD:
							if (A_0 is global::AcpUI.AcpRecNavToolbar)
							{
								num = (short)1786445831;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
							return;
							IL_15A:
							num = (short)813760515;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					break;
				}
				}
			}
			IL_155:
			global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource2);
			global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFCodesInner item2 = (global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFCodesInner)collectionView2.CurrentItem;
			collectionView2.MoveCurrentTo(item2);
			((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
		}

		// Token: 0x0600937F RID: 37759 RVA: 0x008AD118 File Offset: 0x008AB318
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)151998036;
			short num2 = num;
			num = (short)2092977748;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1073545216;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1423507457;
			if (num != 0)
			{
			}
			num = (short)536477696;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x06009380 RID: 37760 RVA: 0x008AD1C8 File Offset: 0x008AB3C8
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)423569467;
			short num2 = num;
			num = (short)1242245179;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1161363456;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1402601473;
			if (num != 0)
			{
			}
			num = (short)1409482752;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06009381 RID: 37761 RVA: 0x008AD27C File Offset: 0x008AB47C
		internal void OnExpanderPhoneWideDTMFTimingTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_44;
				}
				int num2;
				object myRecordsetDataSource;
				global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFTimingInner item;
				for (;;)
				{
					IL_0A:
					num = (short)1660485633;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
					{
						num = (short)1377069957;
						short num3 = num;
						num = (short)1993567109;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)829423616;
							if (num != 0)
							{
							}
							if (myRecordsetDataSource != null)
							{
								num = (short)1574043650;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_154;
						}
						break;
					}
					case 1:
						goto IL_128;
					case 2:
						((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
						this.RecNavToolbarExpanderPhoneWideDTMFTimingTable.SyncDataSources();
						num = (short)1397882881;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				IL_44:
				item = (global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFTimingInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
				myRecordsetDataSource = this.RecNavToolbarExpanderPhoneWideDTMFTimingTable.MyRecordsetDataSource;
				num = (short)1763966976;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			IL_128:
			num = (short)615317504;
			short num4 = num;
			IL_154:
			this.RecNavToolbarExpanderPhoneWideDTMFTimingTable.TableMode = false;
		}

		// Token: 0x06009382 RID: 37762 RVA: 0x008AD3EC File Offset: 0x008AB5EC
		internal void OnExpanderPhoneWideDTMFCodesTableClick(object sender, global::System.Windows.RoutedEventArgs e)
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
				global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFCodesInner item;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)1056927267;
						short num3 = num2;
						num2 = (short)700935715;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)1995046912;
							if (num2 != 0)
							{
							}
							if (myRecordsetDataSource != null)
							{
								num2 = (short)1531052034;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_154;
						}
						break;
					}
					case 1:
						goto IL_100;
					case 2:
						((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
						this.RecNavToolbarExpanderPhoneWideDTMFCodesTable.SyncDataSources();
						num2 = (short)2048917505;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				IL_1C:
				item = (global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFCodesInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
				myRecordsetDataSource = this.RecNavToolbarExpanderPhoneWideDTMFCodesTable.MyRecordsetDataSource;
				num2 = (short)2107572224;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_100:
			num2 = (short)227147777;
			if (num2 != 0)
			{
			}
			num2 = (short)1669005312;
			short num4 = num2;
			IL_154:
			this.RecNavToolbarExpanderPhoneWideDTMFCodesTable.TableMode = false;
		}

		// Token: 0x06009383 RID: 37763 RVA: 0x008AD55C File Offset: 0x008AB75C
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 4;
			short num;
			while (!this.b)
			{
				num = (short)1754136577;
				if (num != 0)
				{
				}
				num = (short)57508427;
				short num2 = num;
				num = (short)1903329867;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)509214720;
					if (num != 0)
					{
					}
					this.b = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("蛆ꗈꟊ诌꫎냐꟒ꃔꗖ볘꣚볞軠転闤裦蟨軪菬鯮\udef0菲鷴飶韸黺\ud8fc췾㄀琂氄挆氈␊紌朎縐紒瀔怖瀘缚砜ㄞ夠䈢䠤䬦", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
			num = (short)1283588096;
			short num3 = num;
		}

		// Token: 0x06009384 RID: 37764 RVA: 0x008AD63C File Offset: 0x008AB83C
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1716060160;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 1:
					goto IL_32B;
				case 2:
					num = (short)14680065;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_31:
				switch (connectionId)
				{
				case 1:
					goto IL_8B3;
				case 2:
				case 3:
				case 4:
				case 5:
				case 6:
				case 7:
				case 8:
					goto IL_B3F;
				case 9:
					goto IL_54B;
				case 10:
					goto IL_4AB;
				case 11:
					goto IL_7E2;
				case 12:
					goto IL_8E4;
				case 13:
					goto IL_ADA;
				case 14:
					goto IL_7B1;
				case 15:
					goto IL_5A3;
				case 16:
					goto IL_B32;
				case 17:
					goto IL_AE7;
				case 18:
					goto IL_7BE;
				case 19:
					goto IL_66D;
				case 20:
					goto IL_806;
				case 21:
					goto IL_26D;
				case 22:
					goto IL_53E;
				case 23:
					goto IL_572;
				case 24:
					goto IL_33D;
				case 25:
					goto IL_5B0;
				case 26:
					goto IL_622;
				case 27:
					goto IL_330;
				case 28:
					goto IL_99E;
				case 29:
					goto IL_23C;
				case 30:
					goto IL_418;
				case 31:
					goto IL_7A4;
				case 32:
					goto IL_361;
				case 33:
					goto IL_2B8;
				case 34:
					goto IL_B25;
				case 35:
					goto IL_47A;
				case 36:
					goto IL_456;
				case 37:
					goto IL_565;
				case 38:
					goto IL_5CA;
				case 39:
					goto IL_449;
				case 40:
					goto IL_A41;
				case 41:
					goto IL_3F4;
				case 42:
					goto IL_B0B;
				case 43:
					goto IL_9E9;
				case 44:
					goto IL_4DC;
				case 45:
					goto IL_96D;
				case 46:
					goto IL_875;
				case 47:
					goto IL_50D;
				case 48:
					goto IL_63C;
				case 49:
					goto IL_3C3;
				case 50:
					goto IL_39F;
				case 51:
					goto IL_813;
				case 52:
					goto IL_6CF;
				case 53:
					goto IL_A4E;
				case 54:
					goto IL_307;
				case 55:
					goto IL_710;
				case 56:
					goto IL_6C2;
				case 57:
					goto IL_6DC;
				case 58:
					goto IL_960;
				case 59:
					goto IL_4CF;
				case 60:
					goto IL_703;
				case 61:
					goto IL_AA6;
				case 62:
					goto IL_953;
				case 63:
					goto IL_49E;
				case 64:
					goto IL_AB3;
				case 65:
					goto IL_882;
				case 66:
					goto IL_6E9;
				case 67:
					goto IL_649;
				case 68:
					goto IL_991;
				case 69:
					goto IL_22F;
				case 70:
					goto IL_69E;
				case 71:
					goto IL_2AB;
				case 72:
					goto IL_780;
				case 73:
					goto IL_62F;
				case 74:
					goto IL_5BD;
				case 75:
					goto IL_71D;
				case 76:
					goto IL_3D0;
				case 77:
					goto IL_A27;
				case 78:
					goto IL_92F;
				case 79:
					goto IL_A68;
				case 80:
					goto IL_868;
				case 81:
					goto IL_27A;
				case 82:
					goto IL_9C5;
				case 83:
					goto IL_222;
				case 84:
					goto IL_844;
				case 85:
					goto IL_837;
				case 86:
					goto IL_9B8;
				case 87:
					goto IL_5E4;
				case 88:
					goto IL_500;
				case 89:
					goto IL_67A;
				case 90:
					goto IL_A99;
				case 91:
					goto IL_596;
				case 92:
					goto IL_72A;
				case 93:
					goto IL_392;
				case 94:
					goto IL_8A6;
				case 95:
					goto IL_43C;
				case 96:
					goto IL_260;
				case 97:
					goto IL_A1A;
				case 98:
					goto IL_5D7;
				case 99:
					goto IL_5F1;
				case 100:
					goto IL_A5B;
				case 101:
					goto IL_51A;
				case 102:
					goto IL_2C5;
				case 103:
					goto IL_615;
				case 104:
					goto IL_36E;
				case 105:
					goto IL_A34;
				case 106:
					goto IL_287;
				case 107:
					goto IL_558;
				case 108:
					goto IL_9AB;
				case 109:
					goto IL_6F6;
				case 110:
					goto IL_9F6;
				case 111:
					goto IL_AC0;
				case 112:
					goto IL_A75;
				case 113:
					goto IL_2FA;
				case 114:
					goto IL_ACD;
				case 115:
					goto IL_B18;
				default:
					num = (short)1099825154;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_222:
			this.CVBtnPhnWideDialingInterdigitDelayms_A7836 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_22F:
			this.PhnWideDialingkeyofDialing_A21285Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_23C:
			this.LblPhnWideDialingPhoneDialing_A8700 = (global::AcpUI.AcpLabel)target;
			this.LblPhnWideDialingPhoneDialing_A8700.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_260:
			this.PhnWideDTMFCodesDeaccess_A7803_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_26D:
			this.PhnWideGeneralDisplayFormat_A7874Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_27A:
			this.PhnWideDialingDigitDurationms_A7834Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_287:
			this.LblPhnWideDTMFCodesAccess_A7381 = (global::AcpUI.AcpLabel)target;
			this.LblPhnWideDTMFCodesAccess_A7381.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2AB:
			this.CVBtnPhnWideDialingInitialDelayms_A7835 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2B8:
			this.PhnWideDialingPhoneDialing_A8700Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2C5:
			num = (short)1091043328;
			short num3 = num;
			this.CpyBtnPhnWideDTMFCodesKeyofDTMFCodesTable_A12800 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2FA:
			this.RTDBtnPhnWideDTMFCodesDeaccess_A7803 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_307:
			this.PhnWideDialingDTMFDigitHangtimems_A7896Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_32B:
			goto IL_B3F;
			IL_330:
			this.PhnWideGeneralManualAccessLiveDialing_A8462Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_33D:
			this.PhnWideGeneralManualAccessLiveDialing_A8462 = (global::AcpUI.AcpCheckBox)target;
			this.PhnWideGeneralManualAccessLiveDialing_A8462.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_361:
			this.CpyBtnPhnWideDialingPhoneDialing_A8700 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_36E:
			this.PhnWideDTMFCodesAccess_A7381 = (global::AcpUI.AcpTextBox)target;
			this.PhnWideDTMFCodesAccess_A7381.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_392:
			this.ExpanderPhoneWideDTMFCodesTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_39F:
			this.LblPhnWideDialingDTMFDigitHangtimems_A7896 = (global::AcpUI.AcpLabel)target;
			this.LblPhnWideDialingDTMFDigitHangtimems_A7896.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3C3:
			this.CVBtnPhnWideDialingDTMFDigitHangtimems_A7896 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3D0:
			this.PhnWideDialingDigitDurationms_A7834 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.PhnWideDialingDigitDurationms_A7834.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3F4:
			this.RecNavToolbarExpanderPhoneWideDTMFTimingTable = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderPhoneWideDTMFTimingTable.ModeClick += this.OnModeClick;
			return;
			IL_418:
			this.PhnWideDialingPhoneDialing_A8700 = (global::AcpUI.AcpComboBox)target;
			this.PhnWideDialingPhoneDialing_A8700.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_43C:
			this.PhnWideDTMFCodesAccess_A7381_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_449:
			this.PhnWideDialingASTRO25PhoneOverdialType_A7473Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_456:
			this.PhnWideDialingASTRO25PhoneOverdialType_A7473 = (global::AcpUI.AcpComboBox)target;
			this.PhnWideDialingASTRO25PhoneOverdialType_A7473.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_47A:
			this.LblPhnWideDialingASTRO25PhoneOverdialType_A7473 = (global::AcpUI.AcpLabel)target;
			this.LblPhnWideDialingASTRO25PhoneOverdialType_A7473.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_49E:
			this.ExpanderPhoneWideDTMFTimingTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_4AB:
			this.HLinkGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkGeneral.Click += this.HLinkClick;
			return;
			IL_4CF:
			this.PhnWideDialingkeyofDialing_A21285_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_4DC:
			this.LblPhnWideDialingDTMFPauseTimems_A7898 = (global::AcpUI.AcpLabel)target;
			this.LblPhnWideDialingDTMFPauseTimems_A7898.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_500:
			this.ExpanderPhoneWideDTMFCodes = (global::AcpUI.AcpExpander)target;
			return;
			IL_50D:
			this.CpyBtnPhnWideDialingDTMFPauseTimems_A7898 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_51A:
			this.LblPhnWideDTMFCodesKeyofDTMFCodesTable_A12800 = (global::AcpUI.AcpLabel)target;
			this.LblPhnWideDTMFCodesKeyofDTMFCodesTable_A12800.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_53E:
			this.CVBtnPhnWideGeneralManualAccessLiveDialing_A8462 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_54B:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_558:
			this.RTDBtnPhnWideDTMFCodesAccess_A7381 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_565:
			this.RTDBtnPhnWideDialingASTRO25PhoneOverdialType_A7473 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_572:
			this.LblPhnWideGeneralManualAccessLiveDialing_A8462 = (global::AcpUI.AcpLabel)target;
			this.LblPhnWideGeneralManualAccessLiveDialing_A8462.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_596:
			this.ExpanderPhoneWideDTMFCodesTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_5A3:
			this.GrpBoxExpanderPhoneWideGeneralPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_5B0:
			this.RTDBtnPhnWideGeneralManualAccessLiveDialing_A8462 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5BD:
			this.CpyBtnPhnWideDialingInitialDelayms_A7835 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5CA:
			this.CpyBtnPhnWideDialingASTRO25PhoneOverdialType_A7473 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5D7:
			this.gridExpanderPhoneWideDTMFCodesTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_5E4:
			this.PhnWideDialingInterdigitDelayms_A7836Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_5F1:
			this.PhnWideDTMFCodesKeyofDTMFCodesTable_A12800 = (global::AcpUI.AcpTextBox)target;
			this.PhnWideDTMFCodesKeyofDTMFCodesTable_A12800.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_615:
			this.PhnWideDTMFCodesKeyofDTMFCodesTable_A12800Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_622:
			this.CpyBtnPhnWideGeneralManualAccessLiveDialing_A8462 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_62F:
			this.RTDBtnPhnWideDialingInitialDelayms_A7835 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_63C:
			this.PhnWideDialingDTMFPauseTimems_A7898Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_649:
			this.LblPhnWideDialingkeyofDialing_A21285 = (global::AcpUI.AcpLabel)target;
			this.LblPhnWideDialingkeyofDialing_A21285.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_66D:
			this.RTDBtnPhnWideGeneralDisplayFormat_A7874 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_67A:
			this.RecNavToolbarExpanderPhoneWideDTMFCodesTable = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderPhoneWideDTMFCodesTable.ModeClick += this.OnModeClick;
			return;
			IL_69E:
			this.PhnWideDialingInitialDelayms_A7835 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.PhnWideDialingInitialDelayms_A7835.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_6C2:
			this.ExpanderPhoneWideDTMFTimingTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_6CF:
			this.RTDBtnPhnWideDialingDTMFDigitHangtimems_A7896 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_6DC:
			this.ExpanderPhoneWideDTMFTimingTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_6E9:
			this.CVBtnPhnWideDialingkeyofDialing_A21285 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6F6:
			this.PhnWideDTMFCodesAccess_A7381Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_703:
			this.PhnWideDialingInitialDelayms_A7835_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_710:
			this.ExpanderPhoneWideDTMFTimingGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_71D:
			this.PhnWideDialingInitialDelayms_A7835Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_72A:
			num = (short)667704589;
			short num4 = num;
			num = (short)1940544781;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_875:
				this.RTDBtnPhnWideDialingDTMFPauseTimems_A7898 = (global::AcpUI.AcpRtdButton)target;
				return;
			default:
				num = (short)635895808;
				if (num != 0)
				{
				}
				this.ExpanderPhoneWideDTMFCodesTableTableView = (global::AcpUI.AcpGroupBox)target;
				return;
			}
			IL_780:
			this.LblPhnWideDialingInitialDelayms_A7835 = (global::AcpUI.AcpLabel)target;
			this.LblPhnWideDialingInitialDelayms_A7835.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_7A4:
			this.RTDBtnPhnWideDialingPhoneDialing_A8700 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_7B1:
			this.ExpanderPhoneWideGeneral = (global::AcpUI.AcpExpander)target;
			return;
			IL_7BE:
			this.PhnWideGeneralDisplayFormat_A7874 = (global::AcpUI.AcpComboBox)target;
			this.PhnWideGeneralDisplayFormat_A7874.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_7E2:
			this.HLinkDTMFTiming = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkDTMFTiming.Click += this.HLinkClick;
			return;
			IL_806:
			this.CpyBtnPhnWideGeneralDisplayFormat_A7874 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_813:
			this.PhnWideDialingDTMFDigitHangtimems_A7896 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.PhnWideDialingDTMFDigitHangtimems_A7896.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_837:
			this.RTDBtnPhnWideDialingInterdigitDelayms_A7836 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_844:
			this.LblPhnWideDialingInterdigitDelayms_A7836 = (global::AcpUI.AcpLabel)target;
			this.LblPhnWideDialingInterdigitDelayms_A7836.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_868:
			this.CpyBtnPhnWideDialingDigitDurationms_A7834 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_882:
			this.PhnWideDialingkeyofDialing_A21285 = (global::AcpUI.AcpTextBox)target;
			this.PhnWideDialingkeyofDialing_A21285.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_8A6:
			this.PhnWideDTMFCodesKeyofDTMFCodesTable_A12800_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_8B3:
			((global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.PagePhoneWide)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.PagePhoneWide)target).Unloaded += this.OnUnloaded;
			return;
			IL_8E4:
			num = (short)191758337;
			if (num != 0)
			{
			}
			this.HLinkDTMFCodes = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkDTMFCodes.Click += this.HLinkClick;
			return;
			IL_92F:
			this.LblPhnWideDialingDigitDurationms_A7834 = (global::AcpUI.AcpLabel)target;
			this.LblPhnWideDialingDigitDurationms_A7834.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_953:
			this.PhnWideDialingInterdigitDelayms_A7836_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_960:
			this.ExpanderPhoneWideDTMFTimingTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_96D:
			this.PhnWideDialingDTMFPauseTimems_A7898 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.PhnWideDialingDTMFPauseTimems_A7898.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_991:
			this.CpyBtnPhnWideDialingkeyofDialing_A21285 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_99E:
			this.CVBtnPhnWideDialingPhoneDialing_A8700 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_9AB:
			this.CpyBtnPhnWideDTMFCodesAccess_A7381 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9B8:
			this.CpyBtnPhnWideDialingInterdigitDelayms_A7836 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9C5:
			this.PhnWideDialingInterdigitDelayms_A7836 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.PhnWideDialingInterdigitDelayms_A7836.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_9E9:
			this.CVBtnPhnWideDialingDTMFPauseTimems_A7898 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_9F6:
			this.PhnWideDTMFCodesDeaccess_A7803 = (global::AcpUI.AcpTextBox)target;
			this.PhnWideDTMFCodesDeaccess_A7803.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_A1A:
			this.ExpanderPhoneWideDTMFCodesTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_A27:
			this.CVBtnPhnWideDialingDigitDurationms_A7834 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A34:
			this.CVBtnPhnWideDTMFCodesAccess_A7381 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A41:
			this.ExpanderPhoneWideDTMFTiming = (global::AcpUI.AcpExpander)target;
			return;
			IL_A4E:
			this.CpyBtnPhnWideDialingDTMFDigitHangtimems_A7896 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A5B:
			this.CVBtnPhnWideDTMFCodesKeyofDTMFCodesTable_A12800 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A68:
			this.RTDBtnPhnWideDialingDigitDurationms_A7834 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A75:
			this.LblPhnWideDTMFCodesDeaccess_A7803 = (global::AcpUI.AcpLabel)target;
			this.LblPhnWideDTMFCodesDeaccess_A7803.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A99:
			this.ExpanderPhoneWideDTMFCodesGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_AA6:
			this.PhnWideDialingDigitDurationms_A7834_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_AB3:
			this.gridExpanderPhoneWideDTMFTimingTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_AC0:
			this.CVBtnPhnWideDTMFCodesDeaccess_A7803 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_ACD:
			this.CpyBtnPhnWideDTMFCodesDeaccess_A7803 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_ADA:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_AE7:
			this.LblPhnWideGeneralDisplayFormat_A7874 = (global::AcpUI.AcpLabel)target;
			this.LblPhnWideGeneralDisplayFormat_A7874.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_B0B:
			this.GrpBoxExpanderPhoneWideDTMFTimingPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_B18:
			this.PhnWideDTMFCodesDeaccess_A7803Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_B25:
			this.CVBtnPhnWideDialingASTRO25PhoneOverdialType_A7473 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B32:
			this.CVBtnPhnWideGeneralDisplayFormat_A7874 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B3F:
			this.b = true;
		}

		// Token: 0x06009385 RID: 37765 RVA: 0x008AE190 File Offset: 0x008AC390
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num = (short)1682139198;
			short num2 = num;
			num = (short)2094164030;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)2069233665;
				if (num != 0)
				{
				}
				num = (short)1653211136;
				if (num != 0)
				{
				}
				switch (connectionId)
				{
				case 2:
					break;
				case 3:
					((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				case 4:
					((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				case 5:
					((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				case 6:
					((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				case 7:
				{
					num = (short)1092681728;
					short num3 = num;
					((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				}
				case 8:
					((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				default:
					return;
				}
				break;
			}
			((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x040048B2 RID: 18610
		private bool a;

		// Token: 0x040048B3 RID: 18611
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x040048B4 RID: 18612
		internal global::System.Windows.Documents.Hyperlink HLinkGeneral;

		// Token: 0x040048B5 RID: 18613
		internal global::System.Windows.Documents.Hyperlink HLinkDTMFTiming;

		// Token: 0x040048B6 RID: 18614
		internal global::System.Windows.Documents.Hyperlink HLinkDTMFCodes;

		// Token: 0x040048B7 RID: 18615
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x040048B8 RID: 18616
		internal global::AcpUI.AcpExpander ExpanderPhoneWideGeneral;

		// Token: 0x040048B9 RID: 18617
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderPhoneWideGeneralPseudo0;

		// Token: 0x040048BA RID: 18618
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnPhnWideGeneralDisplayFormat_A7874;

		// Token: 0x040048BB RID: 18619
		internal global::AcpUI.AcpLabel LblPhnWideGeneralDisplayFormat_A7874;

		// Token: 0x040048BC RID: 18620
		internal global::AcpUI.AcpComboBox PhnWideGeneralDisplayFormat_A7874;

		// Token: 0x040048BD RID: 18621
		internal global::AcpUI.AcpRtdButton RTDBtnPhnWideGeneralDisplayFormat_A7874;

		// Token: 0x040048BE RID: 18622
		internal global::AcpUI.AcpCopyButton CpyBtnPhnWideGeneralDisplayFormat_A7874;

		// Token: 0x040048BF RID: 18623
		internal global::AcpUI.AcpLabel PhnWideGeneralDisplayFormat_A7874Comp;

		// Token: 0x040048C0 RID: 18624
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnPhnWideGeneralManualAccessLiveDialing_A8462;

		// Token: 0x040048C1 RID: 18625
		internal global::AcpUI.AcpLabel LblPhnWideGeneralManualAccessLiveDialing_A8462;

		// Token: 0x040048C2 RID: 18626
		internal global::AcpUI.AcpCheckBox PhnWideGeneralManualAccessLiveDialing_A8462;

		// Token: 0x040048C3 RID: 18627
		internal global::AcpUI.AcpRtdButton RTDBtnPhnWideGeneralManualAccessLiveDialing_A8462;

		// Token: 0x040048C4 RID: 18628
		internal global::AcpUI.AcpCopyButton CpyBtnPhnWideGeneralManualAccessLiveDialing_A8462;

		// Token: 0x040048C5 RID: 18629
		internal global::AcpUI.AcpCheckBox PhnWideGeneralManualAccessLiveDialing_A8462Comp;

		// Token: 0x040048C6 RID: 18630
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnPhnWideDialingPhoneDialing_A8700;

		// Token: 0x040048C7 RID: 18631
		internal global::AcpUI.AcpLabel LblPhnWideDialingPhoneDialing_A8700;

		// Token: 0x040048C8 RID: 18632
		internal global::AcpUI.AcpComboBox PhnWideDialingPhoneDialing_A8700;

		// Token: 0x040048C9 RID: 18633
		internal global::AcpUI.AcpRtdButton RTDBtnPhnWideDialingPhoneDialing_A8700;

		// Token: 0x040048CA RID: 18634
		internal global::AcpUI.AcpCopyButton CpyBtnPhnWideDialingPhoneDialing_A8700;

		// Token: 0x040048CB RID: 18635
		internal global::AcpUI.AcpLabel PhnWideDialingPhoneDialing_A8700Comp;

		// Token: 0x040048CC RID: 18636
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnPhnWideDialingASTRO25PhoneOverdialType_A7473;

		// Token: 0x040048CD RID: 18637
		internal global::AcpUI.AcpLabel LblPhnWideDialingASTRO25PhoneOverdialType_A7473;

		// Token: 0x040048CE RID: 18638
		internal global::AcpUI.AcpComboBox PhnWideDialingASTRO25PhoneOverdialType_A7473;

		// Token: 0x040048CF RID: 18639
		internal global::AcpUI.AcpRtdButton RTDBtnPhnWideDialingASTRO25PhoneOverdialType_A7473;

		// Token: 0x040048D0 RID: 18640
		internal global::AcpUI.AcpCopyButton CpyBtnPhnWideDialingASTRO25PhoneOverdialType_A7473;

		// Token: 0x040048D1 RID: 18641
		internal global::AcpUI.AcpLabel PhnWideDialingASTRO25PhoneOverdialType_A7473Comp;

		// Token: 0x040048D2 RID: 18642
		internal global::AcpUI.AcpExpander ExpanderPhoneWideDTMFTiming;

		// Token: 0x040048D3 RID: 18643
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderPhoneWideDTMFTimingTable;

		// Token: 0x040048D4 RID: 18644
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderPhoneWideDTMFTimingPseudo0;

		// Token: 0x040048D5 RID: 18645
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnPhnWideDialingDTMFPauseTimems_A7898;

		// Token: 0x040048D6 RID: 18646
		internal global::AcpUI.AcpLabel LblPhnWideDialingDTMFPauseTimems_A7898;

		// Token: 0x040048D7 RID: 18647
		internal global::AcpUI.AcpTextBoxSpinner PhnWideDialingDTMFPauseTimems_A7898;

		// Token: 0x040048D8 RID: 18648
		internal global::AcpUI.AcpRtdButton RTDBtnPhnWideDialingDTMFPauseTimems_A7898;

		// Token: 0x040048D9 RID: 18649
		internal global::AcpUI.AcpCopyButton CpyBtnPhnWideDialingDTMFPauseTimems_A7898;

		// Token: 0x040048DA RID: 18650
		internal global::AcpUI.AcpLabel PhnWideDialingDTMFPauseTimems_A7898Comp;

		// Token: 0x040048DB RID: 18651
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnPhnWideDialingDTMFDigitHangtimems_A7896;

		// Token: 0x040048DC RID: 18652
		internal global::AcpUI.AcpLabel LblPhnWideDialingDTMFDigitHangtimems_A7896;

		// Token: 0x040048DD RID: 18653
		internal global::AcpUI.AcpTextBoxSpinner PhnWideDialingDTMFDigitHangtimems_A7896;

		// Token: 0x040048DE RID: 18654
		internal global::AcpUI.AcpRtdButton RTDBtnPhnWideDialingDTMFDigitHangtimems_A7896;

		// Token: 0x040048DF RID: 18655
		internal global::AcpUI.AcpCopyButton CpyBtnPhnWideDialingDTMFDigitHangtimems_A7896;

		// Token: 0x040048E0 RID: 18656
		internal global::AcpUI.AcpLabel PhnWideDialingDTMFDigitHangtimems_A7896Comp;

		// Token: 0x040048E1 RID: 18657
		internal global::System.Windows.Controls.Grid ExpanderPhoneWideDTMFTimingGrid;

		// Token: 0x040048E2 RID: 18658
		internal global::System.Windows.Controls.Grid ExpanderPhoneWideDTMFTimingTableGrid;

		// Token: 0x040048E3 RID: 18659
		internal global::AcpUI.AcpGroupBox ExpanderPhoneWideDTMFTimingTableTableView;

		// Token: 0x040048E4 RID: 18660
		internal global::AcpUI.AcpXamDataPresenter ExpanderPhoneWideDTMFTimingTable;

		// Token: 0x040048E5 RID: 18661
		internal global::Infragistics.Windows.DataPresenter.UnboundField PhnWideDialingkeyofDialing_A21285_Col;

		// Token: 0x040048E6 RID: 18662
		internal global::Infragistics.Windows.DataPresenter.UnboundField PhnWideDialingInitialDelayms_A7835_Col;

		// Token: 0x040048E7 RID: 18663
		internal global::Infragistics.Windows.DataPresenter.UnboundField PhnWideDialingDigitDurationms_A7834_Col;

		// Token: 0x040048E8 RID: 18664
		internal global::Infragistics.Windows.DataPresenter.UnboundField PhnWideDialingInterdigitDelayms_A7836_Col;

		// Token: 0x040048E9 RID: 18665
		internal global::AcpUI.AcpGroupBox ExpanderPhoneWideDTMFTimingTableSRecView;

		// Token: 0x040048EA RID: 18666
		internal global::System.Windows.Controls.Grid gridExpanderPhoneWideDTMFTimingTableSRecView;

		// Token: 0x040048EB RID: 18667
		internal global::AcpUI.AcpTextBox PhnWideDialingkeyofDialing_A21285;

		// Token: 0x040048EC RID: 18668
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnPhnWideDialingkeyofDialing_A21285;

		// Token: 0x040048ED RID: 18669
		internal global::AcpUI.AcpLabel LblPhnWideDialingkeyofDialing_A21285;

		// Token: 0x040048EE RID: 18670
		internal global::AcpUI.AcpCopyButton CpyBtnPhnWideDialingkeyofDialing_A21285;

		// Token: 0x040048EF RID: 18671
		internal global::AcpUI.AcpLabel PhnWideDialingkeyofDialing_A21285Comp;

		// Token: 0x040048F0 RID: 18672
		internal global::AcpUI.AcpTextBoxSpinner PhnWideDialingInitialDelayms_A7835;

		// Token: 0x040048F1 RID: 18673
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnPhnWideDialingInitialDelayms_A7835;

		// Token: 0x040048F2 RID: 18674
		internal global::AcpUI.AcpLabel LblPhnWideDialingInitialDelayms_A7835;

		// Token: 0x040048F3 RID: 18675
		internal global::AcpUI.AcpRtdButton RTDBtnPhnWideDialingInitialDelayms_A7835;

		// Token: 0x040048F4 RID: 18676
		internal global::AcpUI.AcpCopyButton CpyBtnPhnWideDialingInitialDelayms_A7835;

		// Token: 0x040048F5 RID: 18677
		internal global::AcpUI.AcpLabel PhnWideDialingInitialDelayms_A7835Comp;

		// Token: 0x040048F6 RID: 18678
		internal global::AcpUI.AcpTextBoxSpinner PhnWideDialingDigitDurationms_A7834;

		// Token: 0x040048F7 RID: 18679
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnPhnWideDialingDigitDurationms_A7834;

		// Token: 0x040048F8 RID: 18680
		internal global::AcpUI.AcpLabel LblPhnWideDialingDigitDurationms_A7834;

		// Token: 0x040048F9 RID: 18681
		internal global::AcpUI.AcpRtdButton RTDBtnPhnWideDialingDigitDurationms_A7834;

		// Token: 0x040048FA RID: 18682
		internal global::AcpUI.AcpCopyButton CpyBtnPhnWideDialingDigitDurationms_A7834;

		// Token: 0x040048FB RID: 18683
		internal global::AcpUI.AcpLabel PhnWideDialingDigitDurationms_A7834Comp;

		// Token: 0x040048FC RID: 18684
		internal global::AcpUI.AcpTextBoxSpinner PhnWideDialingInterdigitDelayms_A7836;

		// Token: 0x040048FD RID: 18685
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnPhnWideDialingInterdigitDelayms_A7836;

		// Token: 0x040048FE RID: 18686
		internal global::AcpUI.AcpLabel LblPhnWideDialingInterdigitDelayms_A7836;

		// Token: 0x040048FF RID: 18687
		internal global::AcpUI.AcpRtdButton RTDBtnPhnWideDialingInterdigitDelayms_A7836;

		// Token: 0x04004900 RID: 18688
		internal global::AcpUI.AcpCopyButton CpyBtnPhnWideDialingInterdigitDelayms_A7836;

		// Token: 0x04004901 RID: 18689
		internal global::AcpUI.AcpLabel PhnWideDialingInterdigitDelayms_A7836Comp;

		// Token: 0x04004902 RID: 18690
		internal global::AcpUI.AcpExpander ExpanderPhoneWideDTMFCodes;

		// Token: 0x04004903 RID: 18691
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderPhoneWideDTMFCodesTable;

		// Token: 0x04004904 RID: 18692
		internal global::System.Windows.Controls.Grid ExpanderPhoneWideDTMFCodesGrid;

		// Token: 0x04004905 RID: 18693
		internal global::System.Windows.Controls.Grid ExpanderPhoneWideDTMFCodesTableGrid;

		// Token: 0x04004906 RID: 18694
		internal global::AcpUI.AcpGroupBox ExpanderPhoneWideDTMFCodesTableTableView;

		// Token: 0x04004907 RID: 18695
		internal global::AcpUI.AcpXamDataPresenter ExpanderPhoneWideDTMFCodesTable;

		// Token: 0x04004908 RID: 18696
		internal global::Infragistics.Windows.DataPresenter.UnboundField PhnWideDTMFCodesKeyofDTMFCodesTable_A12800_Col;

		// Token: 0x04004909 RID: 18697
		internal global::Infragistics.Windows.DataPresenter.UnboundField PhnWideDTMFCodesAccess_A7381_Col;

		// Token: 0x0400490A RID: 18698
		internal global::Infragistics.Windows.DataPresenter.UnboundField PhnWideDTMFCodesDeaccess_A7803_Col;

		// Token: 0x0400490B RID: 18699
		internal global::AcpUI.AcpGroupBox ExpanderPhoneWideDTMFCodesTableSRecView;

		// Token: 0x0400490C RID: 18700
		internal global::System.Windows.Controls.Grid gridExpanderPhoneWideDTMFCodesTableSRecView;

		// Token: 0x0400490D RID: 18701
		internal global::AcpUI.AcpTextBox PhnWideDTMFCodesKeyofDTMFCodesTable_A12800;

		// Token: 0x0400490E RID: 18702
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnPhnWideDTMFCodesKeyofDTMFCodesTable_A12800;

		// Token: 0x0400490F RID: 18703
		internal global::AcpUI.AcpLabel LblPhnWideDTMFCodesKeyofDTMFCodesTable_A12800;

		// Token: 0x04004910 RID: 18704
		internal global::AcpUI.AcpCopyButton CpyBtnPhnWideDTMFCodesKeyofDTMFCodesTable_A12800;

		// Token: 0x04004911 RID: 18705
		internal global::AcpUI.AcpLabel PhnWideDTMFCodesKeyofDTMFCodesTable_A12800Comp;

		// Token: 0x04004912 RID: 18706
		internal global::AcpUI.AcpTextBox PhnWideDTMFCodesAccess_A7381;

		// Token: 0x04004913 RID: 18707
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnPhnWideDTMFCodesAccess_A7381;

		// Token: 0x04004914 RID: 18708
		internal global::AcpUI.AcpLabel LblPhnWideDTMFCodesAccess_A7381;

		// Token: 0x04004915 RID: 18709
		internal global::AcpUI.AcpRtdButton RTDBtnPhnWideDTMFCodesAccess_A7381;

		// Token: 0x04004916 RID: 18710
		internal global::AcpUI.AcpCopyButton CpyBtnPhnWideDTMFCodesAccess_A7381;

		// Token: 0x04004917 RID: 18711
		internal global::AcpUI.AcpLabel PhnWideDTMFCodesAccess_A7381Comp;

		// Token: 0x04004918 RID: 18712
		internal global::AcpUI.AcpTextBox PhnWideDTMFCodesDeaccess_A7803;

		// Token: 0x04004919 RID: 18713
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnPhnWideDTMFCodesDeaccess_A7803;

		// Token: 0x0400491A RID: 18714
		internal global::AcpUI.AcpLabel LblPhnWideDTMFCodesDeaccess_A7803;

		// Token: 0x0400491B RID: 18715
		internal global::AcpUI.AcpRtdButton RTDBtnPhnWideDTMFCodesDeaccess_A7803;

		// Token: 0x0400491C RID: 18716
		internal global::AcpUI.AcpCopyButton CpyBtnPhnWideDTMFCodesDeaccess_A7803;

		// Token: 0x0400491D RID: 18717
		internal global::AcpUI.AcpLabel PhnWideDTMFCodesDeaccess_A7803Comp;

		// Token: 0x0400491E RID: 18718
		private bool b;
	}
}
