using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.ObjectModel;
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
using CommonResources;
using Infragistics.Windows.DataPresenter;
using Motorola.MackinawCPS.CoreFeatures.ConventionalSystem;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.Contact
{
	// Token: 0x02000219 RID: 537
	public class UclContactPage : global::AcpUI.AcpPageFeature, global::AcpUILib.IAcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x06001B78 RID: 7032 RVA: 0x00235D5C File Offset: 0x00233F5C
		public UclContactPage()
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

		// Token: 0x06001B79 RID: 7033 RVA: 0x00235D94 File Offset: 0x00233F94
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
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num2 = (short)1127809024;
						short num3 = num2;
						num2 = (short)1321074691;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2200);
					num2 = (short)1638924293;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_E9;
				case 2:
				{
					num2 = (short)1031843520;
					short num4 = num2;
					num2 = (short)1262268096;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_AE;
					default:
						num2 = (short)399310848;
						if (num2 != 0)
						{
						}
						goto IL_98;
					}
					break;
				}
				case 3:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2200);
					num2 = (short)223346690;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num2 = (short)658571265;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C4;
				case 5:
					goto IL_98;
				}
				goto IL_28;
				IL_AE:
				num2 = (short)932577284;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_98:
				this.RecNavToolbarUclContact.MyRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				goto IL_AE;
			}
			IL_E9:
			object feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2200);
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarUclContact).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarUclContact).SyncDataSources();
			return;
			IL_1C4:
			num2 = (short)970129409;
			if (num2 != 0)
			{
			}
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarUclContact).MySecondaryRecordsetDataSource = null;
			return;
			IL_28:
			base.MyBaseRecNavToolbar = this.RecNavToolbarUclContact;
			num2 = (short)1258291200;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001B7A RID: 7034 RVA: 0x00235F9C File Offset: 0x0023419C
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1444020224;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)1422393354;
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
							goto IL_5B1;
						}
						return;
					case 1:
						goto IL_264;
					case 2:
					{
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						num = (short)229244931;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_B0;
					case 4:
						if (obj != null)
						{
							num = (short)2101149710;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_474;
					case 5:
						goto IL_2B1;
					case 6:
					{
						global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						obj = null;
						obj = this.RecNavToolbarTrunkingT2CallList.MyRecordsetDataSource;
						num = (short)590807055;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						if (obj != null)
						{
							num = (short)293273617;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_264;
					case 8:
						this.RecNavToolbarUclContact.ChildToolbars.Add(this.RecNavToolbarAstroCallList);
						this.RecNavToolbarUclContact.ChildToolbars.Add(this.RecNavToolbarMDCCallList);
						this.RecNavToolbarUclContact.ChildToolbars.Add(this.RecNavToolbarPhoneCallList);
						this.RecNavToolbarUclContact.ChildToolbars.Add(this.RecNavToolbarTrunkingCallList);
						this.RecNavToolbarUclContact.ChildToolbars.Add(this.RecNavToolbarTrunkingT2CallList);
						this.RecNavToolbarAstroCallList.MyDataPresenter = this.AstroCallListDataPresenter;
						this.RecNavToolbarMDCCallList.MyDataPresenter = this.MDCCallListDataPresenter;
						this.RecNavToolbarPhoneCallList.MyDataPresenter = this.PhoneCallListDataPresenter;
						this.RecNavToolbarTrunkingCallList.MyDataPresenter = this.TrunkingCallListDataPresenter;
						this.RecNavToolbarTrunkingT2CallList.MyDataPresenter = this.TrunkingT2CallListDataPresenter;
						obj = null;
						obj = this.RecNavToolbarTrunkingCallList.MyRecordsetDataSource;
						num = (short)2132672512;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						try
						{
							num = (short)1336606720;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_33A;
									}
									continue;
								case 1:
									goto IL_3FD;
								case 3:
									num = (short)1384316929;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									if (acpExpander != null)
									{
										num = (short)723714053;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 5:
									base.Expanders.Add(acpExpander);
									num = (short)913309698;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									if (!enumerator.MoveNext())
									{
										num = (short)857014275;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
									num = (short)1781006340;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_3A3:
								num = (short)1231552518;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_33A:
								goto IL_3A3;
							}
							IL_3FD:
							goto IL_221;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_41F;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_40C:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)514654210;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (disposable != null)
									{
										num = (short)148766720;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_473;
								case 2:
									goto IL_471;
								}
								goto IL_41F;
							}
							IL_471:
							IL_473:
							goto EndFinally_11;
							IL_41F:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1570045953;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_40C;
							EndFinally_11:;
						}
						goto IL_474;
						IL_221:
						this.MyStackPanel.Children[0].Focus();
						base.OnLoaded(sender, e);
						this.a = true;
						num = (short)2035417104;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						switch (0)
						{
						case 0:
							goto IL_8B;
						}
						continue;
					case 11:
						goto IL_474;
					case 12:
					{
						global::System.Windows.Data.CollectionView collectionView3 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						num = (short)856358917;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						if (obj != null)
						{
							num = (short)469106690;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B0;
					case 14:
					{
						global::System.Windows.Data.CollectionView collectionView4 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						num = (short)2020498602;
						short num3 = num;
						num = (short)1273257130;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_5B1;
						default:
						{
							num = (short)1392246784;
							short num4 = num;
							num = (short)583008256;
							if (num != 0)
							{
							}
							num = (short)161349643;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 15:
						if (obj != null)
						{
							num = (short)1884815372;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B1;
					case 16:
						return;
					case 17:
					{
						global::System.Windows.Data.CollectionView collectionView5 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						num = (short)2109079553;
						if (num != 0)
						{
						}
						num = (short)114950145;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_8B:
					if (!this.a)
					{
						num = (short)423624712;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_B0:
					acpExpander = null;
					enumerator = this.MyStackPanel.Children.GetEnumerator();
					num = (short)1882259465;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_264:
					obj = null;
					obj = this.RecNavToolbarMDCCallList.MyRecordsetDataSource;
					num = (short)1258029060;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2B1:
					obj = null;
					obj = this.RecNavToolbarAstroCallList.MyRecordsetDataSource;
					num = (short)1962803207;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_474:
					obj = null;
					obj = this.RecNavToolbarPhoneCallList.MyRecordsetDataSource;
					num = (short)1095761933;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5B1:
					num = (short)105054214;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
		}

		// Token: 0x06001B7B RID: 7035 RVA: 0x002365E4 File Offset: 0x002347E4
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_46;
			}
			short num;
			int num3;
			for (;;)
			{
				IL_0A:
				num = (short)813367296;
				short num2 = num;
				switch (num3)
				{
				case 0:
					if (this.a)
					{
						num = (short)1038417922;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_136;
				case 1:
					goto IL_136;
				case 2:
					base.OnUnloaded(sender, e);
					this.a = false;
					num = (short)1392246785;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_46;
				IL_136:
				num = (short)164145541;
				short num4 = num;
				num = (short)1345825157;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_16C;
				}
			}
			IL_16C:
			num = (short)711786497;
			if (num != 0)
			{
			}
			num = (short)805240832;
			if (num != 0)
			{
			}
			return;
			IL_46:
			this.RecNavToolbarAstroCallList.DataContext = null;
			this.RecNavToolbarMDCCallList.DataContext = null;
			this.RecNavToolbarPhoneCallList.DataContext = null;
			this.RecNavToolbarTrunkingCallList.DataContext = null;
			this.RecNavToolbarTrunkingT2CallList.DataContext = null;
			this.RecNavToolbarUclContact.DataContext = null;
			this.RecNavToolbarAstroCallList.MyDataPresenter = null;
			this.RecNavToolbarMDCCallList.MyDataPresenter = null;
			this.RecNavToolbarPhoneCallList.MyDataPresenter = null;
			this.RecNavToolbarTrunkingCallList.MyDataPresenter = null;
			this.RecNavToolbarTrunkingT2CallList.MyDataPresenter = null;
			this.RecNavToolbarUclContact.MyDataPresenter = null;
			num = (short)1638924288;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06001B7C RID: 7036 RVA: 0x0023679C File Offset: 0x0023499C
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 1;
			short num = (short)1037893632;
			switch (num)
			{
			default:
			{
				num = (short)238288936;
				int num2 = (int)((global::System.IntPtr)num);
				global::AcpCommonLib.IAcpRecordset myRecordsetDataSource4;
				for (;;)
				{
					object myRecordsetDataSource;
					switch (num2)
					{
					case 0:
					{
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
						global::SpecialFeatures.Ucl.Contact.TrunkingT2CallList trunkingT2CallList = (global::SpecialFeatures.Ucl.Contact.TrunkingT2CallList)collectionView.CurrentItem;
						num = (short)827772280;
						short num3 = num;
						num = (short)1344458104;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_520;
						default:
							num = (short)889126912;
							if (num != 0)
							{
							}
							num = (short)367394875;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)653066267;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_418;
					case 2:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횃쒉쒏﶑ﮓ歹流ﮙ펝장쒧용잭쎯욱", a_))
						{
							num = (short)835584073;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1831272515;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_F6E;
					case 4:
					{
						global::System.Windows.Data.CollectionView collectionView;
						global::SpecialFeatures.Ucl.Contact.TrunkingT2CallList trunkingT2CallList;
						collectionView.MoveCurrentTo(trunkingT2CallList);
						num = (short)1116209177;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						object myRecordsetDataSource2;
						if (myRecordsetDataSource2 != null)
						{
							num = (short)960299057;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23B;
					}
					case 6:
					{
						object myRecordsetDataSource3 = this.RecNavToolbarPhoneCallList.MyRecordsetDataSource;
						num = (short)1757216821;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						if (myRecordsetDataSource4 != null)
						{
							num = (short)1449066575;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 8:
						if (myRecordsetDataSource != null)
						{
							num = (short)1693843456;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_59A;
					case 9:
					{
						global::System.Windows.Data.CollectionView collectionView2;
						if (collectionView2.Count > 0)
						{
							num = (short)1785331725;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_362;
					}
					case 10:
					{
						global::System.Windows.Data.CollectionView collectionView3;
						global::SpecialFeatures.Ucl.Contact.PhoneCallList phoneCallList;
						collectionView3.MoveCurrentTo(phoneCallList);
						num = (short)506331139;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						num = (short)1966473300;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
					{
						object myRecordsetDataSource5;
						if (myRecordsetDataSource5 != null)
						{
							num = (short)1565524048;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CE8;
					}
					case 13:
						num = (short)2029125679;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
					{
						global::SpecialFeatures.Ucl.Contact.TrunkingCallList trunkingCallList;
						if (trunkingCallList != null)
						{
							num = (short)1948516438;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1081671714;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						goto IL_A7C;
					case 16:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1213661210;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C83;
					case 17:
					{
						global::SpecialFeatures.Ucl.Contact.MDCCallList mdccallList;
						if (mdccallList != null)
						{
							num = (short)1453523022;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)369229879;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						num = (short)1900216395;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						goto IL_575;
					case 20:
					{
						object myRecordsetDataSource2 = this.RecNavToolbarTrunkingCallList.MyRecordsetDataSource;
						num = (short)830930949;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
					{
						global::System.Windows.Data.CollectionView collectionView2;
						collectionView2.MoveCurrentToLast();
						num = (short)527171638;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						goto IL_644;
					case 23:
						goto IL_A9F;
					case 24:
						goto IL_598;
					case 25:
						goto IL_575;
					case 26:
					{
						object myRecordsetDataSource5 = this.RecNavToolbarAstroCallList.MyRecordsetDataSource;
						num = (short)2073886732;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
						goto IL_520;
					case 28:
						goto IL_F91;
					case 29:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)350158933;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_66E;
					case 30:
					{
						num = (short)1715077121;
						if (num != 0)
						{
						}
						global::System.Windows.Data.CollectionView collectionView4;
						collectionView4.MoveCurrentToLast();
						num = (short)1708982287;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
					{
						object myRecordsetDataSource6;
						if (myRecordsetDataSource6 != null)
						{
							num = (short)356188242;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_568;
					}
					case 32:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횃쒉쒏﶑ﮓ歹流ﮙ쪝튟힡쪣춥솧쒩쮫節芯햳\udab5풷햻춽뒿", a_))
						{
							num = (short)134545473;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)99221547;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						goto IL_EEC;
					case 34:
					{
						global::System.Windows.Data.CollectionView collectionView5;
						if (collectionView5.Count > 0)
						{
							num = (short)1511391284;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_644;
					}
					case 35:
					{
						global::System.Windows.Data.CollectionView collectionView;
						if (collectionView.IsCurrentAfterLast)
						{
							num = (short)364904529;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						collectionView.MoveCurrentToFirst();
						num = (short)1493893139;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 36:
						num = (short)711589934;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						num = (short)1950613561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
					{
						global::System.Windows.Data.CollectionView collectionView5;
						if (collectionView5.IsCurrentAfterLast)
						{
							num = (short)1572274238;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						collectionView5.MoveCurrentToFirst();
						num = (short)922615850;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 39:
						goto IL_A7C;
					case 40:
						switch (0)
						{
						case 0:
							goto IL_1AA;
						}
						continue;
					case 41:
						goto IL_644;
					case 42:
						goto IL_644;
					case 43:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횃쒉쒏﶑ﮓ歹流ﮙ\udf9d펟횡횣즥쮩삫슭ﲯ\udbb1잳습", a_))
						{
							num = (short)146604098;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1147076610;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
					{
						global::System.Windows.Data.CollectionView collectionView3;
						if (collectionView3.Count > 0)
						{
							num = (short)579665957;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F6E;
					}
					case 45:
						myRecordsetDataSource4 = this.RecNavToolbarUclContact.MyRecordsetDataSource;
						num = (short)1979777031;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횃쒉쒏﶑ﮓ歹流ﮙ쮝쎟캡즥욧\udea9춫춭쒯", a_))
						{
							num = (short)1322385453;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)50921543;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
					{
						global::System.Windows.Data.CollectionView collectionView2;
						if (collectionView2.IsCurrentAfterLast)
						{
							num = (short)368312341;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						collectionView2.MoveCurrentToFirst();
						num = (short)1560281162;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 48:
						goto IL_669;
					case 49:
					{
						object myRecordsetDataSource2;
						global::System.Windows.Data.CollectionView collectionView5 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource2);
						global::SpecialFeatures.Ucl.Contact.TrunkingCallList trunkingCallList = (global::SpecialFeatures.Ucl.Contact.TrunkingCallList)collectionView5.CurrentItem;
						num = (short)1816985614;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 50:
						goto IL_386;
					case 51:
						goto IL_F6E;
					case 52:
						num = (short)1435959334;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 53:
					{
						object myRecordsetDataSource3;
						if (myRecordsetDataSource3 != null)
						{
							num = (short)9437252;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_40B;
					}
					case 54:
						goto IL_362;
					case 55:
					{
						global::System.Windows.Data.CollectionView collectionView4;
						if (collectionView4.Count > 0)
						{
							num = (short)1156382731;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A7C;
					}
					case 56:
					{
						global::SpecialFeatures.Ucl.Contact.AstroCallList astroCallList;
						if (astroCallList != null)
						{
							num = (short)464584762;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2109865993;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 57:
					{
						global::System.Windows.Data.CollectionView collectionView3;
						if (collectionView3.IsCurrentAfterLast)
						{
							num = (short)1804402757;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						collectionView3.MoveCurrentToFirst();
						num = (short)601817139;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 58:
					{
						global::System.Windows.Data.CollectionView collectionView2;
						global::SpecialFeatures.Ucl.Contact.AstroCallList astroCallList;
						collectionView2.MoveCurrentTo(astroCallList);
						num = (short)1374552140;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 59:
					{
						global::SpecialFeatures.Ucl.Contact.TrunkingT2CallList trunkingT2CallList;
						if (trunkingT2CallList != null)
						{
							num = (short)1027473412;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1683095624;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 60:
						num = (short)1756495907;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 61:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)414253076;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AE7;
					case 62:
					{
						global::System.Windows.Data.CollectionView collectionView5;
						collectionView5.MoveCurrentToLast();
						num = (short)1147928617;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 63:
					{
						global::SpecialFeatures.Ucl.Contact.PhoneCallList phoneCallList;
						if (phoneCallList != null)
						{
							num = (short)1451163658;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2047344684;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 64:
						goto IL_F6E;
					case 65:
						num = (short)296615937;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 66:
						num = (short)160104464;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 67:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횃쒉쒏﶑ﮓ歹流ﮙ캝좟춡쪣쎥쮩삫슭ﲯ\udbb1잳습", a_))
						{
							num = (short)1868365842;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 68:
					{
						num = (short)1535574016;
						short num4 = num;
						object myRecordsetDataSource3;
						global::System.Windows.Data.CollectionView collectionView3 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource3);
						global::SpecialFeatures.Ucl.Contact.PhoneCallList phoneCallList = (global::SpecialFeatures.Ucl.Contact.PhoneCallList)collectionView3.CurrentItem;
						num = (short)1454178367;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 69:
					{
						global::System.Windows.Data.CollectionView collectionView3;
						collectionView3.MoveCurrentToLast();
						num = (short)13893696;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 70:
						goto IL_575;
					case 71:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횃쒉쒏﶑ﮓ歹流ﮙ쪝튟힡쪣춥솧쒩쮫톯\udeb1\ud8b3蝹톷즹좻", a_))
						{
							num = (short)150798419;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1011286048;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 72:
					{
						global::System.Windows.Data.CollectionView collectionView;
						if (collectionView.Count > 0)
						{
							num = (short)1867776060;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_575;
					}
					case 73:
						num = (short)1451491357;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 74:
						goto IL_362;
					case 75:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1224081414;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)856555553;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 76:
						goto IL_362;
					case 77:
						goto IL_A7C;
					case 78:
					{
						global::SpecialFeatures.Ucl.Contact.MDCCallList mdccallList;
						global::System.Windows.Data.CollectionView collectionView4;
						collectionView4.MoveCurrentTo(mdccallList);
						num = (short)696647757;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 79:
						goto IL_9CE;
					case 80:
					{
						object myRecordsetDataSource5;
						global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource5);
						global::SpecialFeatures.Ucl.Contact.AstroCallList astroCallList = (global::SpecialFeatures.Ucl.Contact.AstroCallList)collectionView2.CurrentItem;
						num = (short)429850680;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 81:
					{
						global::System.Windows.Data.CollectionView collectionView;
						collectionView.MoveCurrentToLast();
						num = (short)1021902918;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 82:
					{
						object myRecordsetDataSource6;
						global::System.Windows.Data.CollectionView collectionView4 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource6);
						global::SpecialFeatures.Ucl.Contact.MDCCallList mdccallList = (global::SpecialFeatures.Ucl.Contact.MDCCallList)collectionView4.CurrentItem;
						num = (short)1879638033;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 83:
						num = (short)200998973;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 84:
					{
						global::System.Windows.Data.CollectionView collectionView4;
						if (collectionView4.IsCurrentAfterLast)
						{
							num = (short)479789086;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						collectionView4.MoveCurrentToFirst();
						num = (short)1721237543;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 85:
					{
						object myRecordsetDataSource6 = this.RecNavToolbarMDCCallList.MyRecordsetDataSource;
						num = (short)1686437919;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 86:
					{
						global::SpecialFeatures.Ucl.Contact.TrunkingCallList trunkingCallList;
						global::System.Windows.Data.CollectionView collectionView5;
						collectionView5.MoveCurrentTo(trunkingCallList);
						num = (short)1652162582;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_1AA:
					if (A_0 is global::AcpUI.AcpRecNavToolbar)
					{
						num = (short)2022178852;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_362:
					((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
					num = (short)1532493874;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_520:
					myRecordsetDataSource = this.RecNavToolbarTrunkingT2CallList.MyRecordsetDataSource;
					num = (short)1947336712;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_575:
					((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
					num = (short)23789592;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_644:
					((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
					num = (short)2014314544;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A7C:
					((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
					num = (short)347275287;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F6E:
					((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
					num = (short)344915996;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_23B:
				((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
				return;
				IL_386:
				goto IL_CE8;
				IL_40B:
				((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
				return;
				IL_418:
				((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
				return;
				IL_568:
				((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
				return;
				IL_598:
				IL_59A:
				((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
				return;
				IL_669:
				goto IL_23B;
				IL_66E:
				((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
				return;
				IL_9CE:
				base.NavigationService.Navigate(new global::System.Uri(myRecordsetDataSource4.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
				return;
				IL_A9F:
				goto IL_568;
				IL_AE7:
				((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
				return;
				IL_C83:
				((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
				return;
				IL_CE8:
				((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
				return;
				IL_EEC:
				return;
				IL_F91:
				goto IL_40B;
			}
			}
		}

		// Token: 0x06001B7D RID: 7037 RVA: 0x00237740 File Offset: 0x00235940
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)968163329;
			if (num != 0)
			{
			}
			num = (short)127664128;
			short num2 = num;
			num = (short)1474672343;
			short num3 = num;
			num = (short)1444853463;
			switch (num3 == num)
			{
			}
			num = (short)1795555328;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06001B7E RID: 7038 RVA: 0x002377F4 File Offset: 0x002359F4
		internal global::System.Collections.ObjectModel.ObservableCollection<string> GetAstroSystemID()
		{
			short num = (short)1645674496;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_52;
				}
				int num3;
				global::AcpCommonLib.IAcpRecordset feature;
				global::System.Collections.ObjectModel.ObservableCollection<string> observableCollection;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
						if (conventionalSystem.General.CnvSysGeneralSystemType_A13262.UIValue == global::CommonResources.AppResources.ASTRO_Id)
						{
							num = (short)1823997959;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8B;
					}
					case 1:
					{
						if (num3 >= feature.Count)
						{
							num = (short)1976500226;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem)feature[num3];
						num = (short)2133590016;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						return observableCollection;
					case 3:
					{
						num = (short)95446751;
						short num4 = num;
						num = (short)1266116319;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_8B;
						default:
							num = (short)873725952;
							if (num != 0)
							{
							}
							goto IL_8B;
						}
						break;
					}
					case 4:
					{
						int cnvSysGeneralSystemGroupNumber_A21960Value;
						if (!observableCollection.Contains(cnvSysGeneralSystemGroupNumber_A21960Value.ToString()))
						{
							num = (short)1963327496;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8B;
					}
					case 5:
						goto IL_1CC;
					case 6:
						goto IL_1CC;
					case 7:
					{
						num = (short)465567744;
						short num5 = num;
						num = (short)1937506305;
						if (num != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
						int cnvSysGeneralSystemGroupNumber_A21960Value = conventionalSystem.General.CnvSysGeneralSystemGroupNumber_A21960Value;
						num = (short)1814953988;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						int cnvSysGeneralSystemGroupNumber_A21960Value;
						observableCollection.Add(cnvSysGeneralSystemGroupNumber_A21960Value.ToString());
						num = (short)214302723;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_52;
					IL_8B:
					num3++;
					num = (short)102891525;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1CC:
					num = (short)1076690945;
					num2 = (int)((global::System.IntPtr)num);
				}
				return observableCollection;
				IL_52:
				observableCollection = new global::System.Collections.ObjectModel.ObservableCollection<string>();
				observableCollection.Add(global::CommonResources.AppResources.Unassigned_ID);
				feature = global::AcpCommonLib.FeatureManager.GetFeature(2053);
				num3 = 0;
				num = (short)1189412870;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06001B7F RID: 7039 RVA: 0x00237A64 File Offset: 0x00235C64
		private void OnComboBox_Loaded(object A_0, global::System.EventArgs A_1)
		{
			short num = (short)1180172288;
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
				{
					num = (short)602406913;
					if (num != 0)
					{
					}
					num = (short)249561088;
					short num3 = num;
					num = (short)80101450;
					short num4 = num;
					num = (short)290734154;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3B;
					default:
						num = (short)2104623104;
						if (num != 0)
						{
						}
						((global::AcpUI.AcpComboBox)A_0).ItemsSource = this.GetAstroSystemID();
						num = (short)1660813314;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					return;
				}
				goto IL_30;
				IL_3B:
				num = (short)1062928385;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_30:
				if (A_0 is global::AcpUI.AcpComboBox)
				{
					goto IL_3B;
				}
				break;
			}
		}

		// Token: 0x06001B80 RID: 7040 RVA: 0x00237B88 File Offset: 0x00235D88
		private void AcpComboBox_DropDownOpened(object A_0, global::System.EventArgs A_1)
		{
			short num = (short)1183318016;
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
				{
					num = (short)1551237120;
					short num3 = num;
					num = (short)2118688013;
					short num4 = num;
					num = (short)1925487885;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3B;
					default:
						num = (short)1765474304;
						if (num != 0)
						{
						}
						((global::AcpUI.AcpComboBox)A_0).ItemsSource = this.GetAstroSystemID();
						num = (short)1869938690;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					goto IL_F0;
				}
				goto IL_30;
				IL_3B:
				num = (short)1139933185;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_30:
				if (A_0 is global::AcpUI.AcpComboBox)
				{
					goto IL_3B;
				}
				return;
			}
			IL_F0:
			num = (short)102891521;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001B81 RID: 7041 RVA: 0x00237CB0 File Offset: 0x00235EB0
		private void HLinkContactClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1900257637;
			short num2 = num;
			num = (short)1947771237;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1036189696;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)902758400;
			if (num != 0)
			{
			}
			num = (short)235470849;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x06001B82 RID: 7042 RVA: 0x00237D60 File Offset: 0x00235F60
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 19;
			while (this.b)
			{
				short num = (short)1199570944;
				short num2 = num;
				num = (short)427673099;
				short num3 = num;
				num = (short)921683467;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)647036928;
					if (num != 0)
					{
					}
					num = (short)918355969;
					if (num != 0)
					{
					}
					return;
				}
			}
			this.b = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("릕쮗鍊ﶝ즟쎡좣춧쮩\ud8ab\udbad슯ힱ잳趵\udbb7햹톻캽꾿곁ꇃꣅ볇꿋꿍볏뻑뛙뗛귝铟쟡훣훥诧藩苫裭駯闱至蓵駷軹闻釽滿ⴁ會椅昇縉洋洍搏㴑愓甕琗礙猛瀝吟䌡䜣別堧䬩䬫䬭ḯ䨱唳嬵吷", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06001B83 RID: 7043 RVA: 0x00237E44 File Offset: 0x00236044
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)290193410;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)2114453505;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_9F2;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				switch (connectionId)
				{
				case 1:
					goto IL_4D2;
				case 2:
					goto IL_9F7;
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
					goto IL_1480;
				case 24:
					goto IL_113A;
				case 25:
					goto IL_6C2;
				case 26:
					goto IL_938;
				case 27:
					goto IL_650;
				case 28:
					goto IL_137B;
				case 29:
					goto IL_1252;
				case 30:
					goto IL_EC8;
				case 31:
					goto IL_C0B;
				case 32:
					goto IL_1401;
				case 33:
					goto IL_CEC;
				case 34:
					goto IL_1154;
				case 35:
					goto IL_13D0;
				case 36:
					goto IL_71A;
				case 37:
					goto IL_C87;
				case 38:
					goto IL_CF9;
				case 39:
					goto IL_F46;
				case 40:
					goto IL_104F;
				case 41:
					goto IL_907;
				case 42:
					goto IL_F60;
				case 43:
					goto IL_11ED;
				case 44:
					goto IL_EA1;
				case 45:
					goto IL_F15;
				case 46:
					goto IL_95C;
				case 47:
					goto IL_92B;
				case 48:
					goto IL_43C;
				case 49:
					goto IL_D06;
				case 50:
					goto IL_823;
				case 51:
					goto IL_700;
				case 52:
					goto IL_AA1;
				case 53:
					goto IL_6B5;
				case 54:
					goto IL_510;
				case 55:
					goto IL_1195;
				case 56:
					goto IL_73E;
				case 57:
					goto IL_1109;
				case 58:
					goto IL_FC5;
				case 59:
					goto IL_7EF;
				case 60:
					goto IL_F22;
				case 61:
					goto IL_503;
				case 62:
					goto IL_144C;
				case 63:
					goto IL_11FA;
				case 64:
					goto IL_13AC;
				case 65:
					goto IL_422;
				case 66:
					goto IL_E7D;
				case 67:
					goto IL_5D4;
				case 68:
					goto IL_76F;
				case 69:
					goto IL_534;
				case 70:
					goto IL_10D8;
				case 71:
					goto IL_470;
				case 72:
					goto IL_8E3;
				case 73:
					goto IL_6F3;
				case 74:
					goto IL_61F;
				case 75:
					goto IL_612;
				case 76:
					goto IL_D54;
				case 77:
					goto IL_122B;
				case 78:
					goto IL_DC3;
				case 79:
					goto IL_C18;
				case 80:
					goto IL_133D;
				case 81:
					goto IL_B44;
				case 82:
					goto IL_605;
				case 83:
					goto IL_F87;
				case 84:
					goto IL_136E;
				case 85:
					goto IL_AEC;
				case 86:
					goto IL_F53;
				case 87:
					goto IL_5C7;
				case 88:
					goto IL_E0E;
				case 89:
					goto IL_139F;
				case 90:
					goto IL_681;
				case 91:
					goto IL_11D3;
				case 92:
					goto IL_A70;
				case 93:
					goto IL_809;
				case 94:
					goto IL_99D;
				case 95:
					goto IL_969;
				case 96:
					goto IL_69B;
				case 97:
					goto IL_CA1;
				case 98:
					goto IL_B51;
				case 99:
					goto IL_DB6;
				case 100:
					goto IL_1466;
				case 101:
					goto IL_857;
				case 102:
					goto IL_143F;
				case 103:
					goto IL_CAE;
				case 104:
					goto IL_572;
				case 105:
					goto IL_57F;
				case 106:
					goto IL_1473;
				case 107:
					goto IL_E1B;
				case 108:
					goto IL_84A;
				case 109:
					goto IL_A4C;
				case 110:
					goto IL_864;
				case 111:
					goto IL_898;
				case 112:
					goto IL_1276;
				case 113:
					goto IL_C63;
				case 114:
					goto IL_12A7;
				case 115:
					goto IL_4AE;
				case 116:
					goto IL_10B1;
				case 117:
					goto IL_A28;
				case 118:
					goto IL_88B;
				case 119:
					goto IL_12B4;
				case 120:
					goto IL_674;
				case 121:
					goto IL_A94;
				case 122:
					goto IL_CDF;
				case 123:
					goto IL_FB8;
				case 124:
					goto IL_D78;
				case 125:
					goto IL_EAE;
				case 126:
					goto IL_116E;
				case 127:
					goto IL_10CB;
				case 128:
					goto IL_643;
				case 129:
					goto IL_9AA;
				case 130:
					goto IL_D3A;
				case 131:
					goto IL_C56;
				case 132:
					goto IL_B2A;
				case 133:
					goto IL_13F4;
				case 134:
					goto IL_871;
				case 135:
					goto IL_E70;
				case 136:
					goto IL_816;
				case 137:
					goto IL_1238;
				case 138:
					goto IL_A1B;
				case 139:
					goto IL_8D6;
				case 140:
					goto IL_10A4;
				case 141:
					goto IL_3FE;
				case 142:
					goto IL_83D;
				case 143:
					goto IL_11AF;
				case 144:
					goto IL_8A5;
				case 145:
					goto IL_1080;
				case 146:
					goto IL_463;
				case 147:
					goto IL_F94;
				case 148:
					goto IL_7FC;
				case 149:
					goto IL_762;
				case 150:
					goto IL_BA9;
				case 151:
					goto IL_130C;
				case 152:
					goto IL_12FF;
				case 153:
					goto IL_B6B;
				case 154:
					goto IL_ABB;
				case 155:
					goto IL_AC8;
				case 156:
					goto IL_990;
				case 157:
					goto IL_5A3;
				case 158:
					goto IL_11E0;
				case 159:
					goto IL_134A;
				case 160:
					goto IL_D2D;
				case 161:
					goto IL_BCD;
				case 162:
					goto IL_983;
				case 163:
					goto IL_D13;
				case 164:
					goto IL_976;
				case 165:
					goto IL_449;
				case 166:
					goto IL_C25;
				case 167:
					goto IL_B9C;
				case 168:
					goto IL_DD0;
				case 169:
					goto IL_3F1;
				case 170:
					goto IL_B1D;
				case 171:
					goto IL_B5E;
				case 172:
					goto IL_121E;
				case 173:
					goto IL_BDA;
				case 174:
					goto IL_C94;
				case 175:
					goto IL_9CE;
				case 176:
					goto IL_1330;
				case 177:
					goto IL_68E;
				case 178:
					goto IL_B37;
				case 179:
					goto IL_7A0;
				case 180:
					goto IL_830;
				case 181:
					goto IL_10BE;
				case 182:
					goto IL_1161;
				case 183:
					goto IL_F6D;
				case 184:
					goto IL_E4C;
				case 185:
					goto IL_70D;
				case 186:
					goto IL_8B2;
				case 187:
					goto IL_129A;
				case 188:
					goto IL_141B;
				case 189:
					goto IL_565;
				case 190:
					goto IL_1116;
				case 191:
					goto IL_AAE;
				case 192:
					goto IL_42F;
				case 193:
					goto IL_AF9;
				case 194:
					goto IL_5E1;
				case 195:
					goto IL_793;
				case 196:
					goto IL_10E5;
				case 197:
					goto IL_7D5;
				case 198:
					goto IL_105C;
				case 199:
					goto IL_F7A;
				case 200:
					goto IL_D20;
				case 201:
					goto IL_12C1;
				case 202:
					goto IL_6A8;
				case 203:
					goto IL_7E2;
				case 204:
					goto IL_B8F;
				case 205:
					goto IL_494;
				case 206:
					goto IL_117B;
				case 207:
					goto IL_D85;
				case 208:
					goto IL_BFE;
				case 209:
					goto IL_140E;
				case 210:
					goto IL_541;
				case 211:
					goto IL_87E;
				case 212:
					goto IL_456;
				case 213:
					goto IL_6E6;
				case 214:
					goto IL_1459;
				case 215:
					goto IL_EBB;
				case 216:
					goto IL_D47;
				case 217:
					goto IL_FE9;
				case 218:
					goto IL_E3F;
				case 219:
					goto IL_C32;
				case 220:
					goto IL_DDD;
				case 221:
					goto IL_DEA;
				case 222:
					goto IL_11A2;
				case 223:
					goto IL_12CE;
				case 224:
					goto IL_12F2;
				case 225:
					goto IL_D92;
				case 226:
					goto IL_4A1;
				case 227:
					goto IL_1042;
				case 228:
					goto IL_1245;
				case 229:
					goto IL_1147;
				case 230:
					goto IL_1188;
				case 231:
					goto IL_CD2;
				default:
					num = (short)1996226560;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_3F1:
			this.IndividualIDCompAstro = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_3FE:
			this.SystemAliasAstro = (global::AcpUI.AcpComboBox)target;
			this.SystemAliasAstro.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_422:
			this.RTDBtnCustmWACNID = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_42F:
			this.CVBtnCustmGroupNumberMDC = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_43C:
			this.SystemIDTable = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_449:
			this.SystemGroupNumberComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_456:
			this.GroupBoxTableViewPhone = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_463:
			this.CVBtnSystemGroupNumber = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_470:
			this.LblCustmSystemID = (global::AcpUI.AcpLabel)target;
			this.LblCustmSystemID.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_494:
			this.CopyButtonCustmGroupNumberMDC = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4A1:
			this.RtdBtnPhoneCategory = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4AE:
			this.IndividualIDTrkT2 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.IndividualIDTrkT2.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4D2:
			((global::SpecialFeatures.Ucl.Contact.UclContactPage)target).Loaded += this.OnLoaded;
			((global::SpecialFeatures.Ucl.Contact.UclContactPage)target).Unloaded += this.OnUnloaded;
			return;
			IL_503:
			this.RtdBtnWACNID = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_510:
			this.SystemAlias = (global::AcpUI.AcpComboBox)target;
			this.SystemAlias.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_534:
			this.RtdBtnHomeSystemID = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_541:
			this.RecNavToolbarPhoneCallList = (global::AcpUI.AcpChildRecNavToolbar)target;
			this.RecNavToolbarPhoneCallList.ModeClick += this.OnModeClick;
			return;
			IL_565:
			this.CVBtnSystemGroupNumberMDC = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_572:
			this.CVBtnSystemAliasTrkT2 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_57F:
			this.LblSystemAliasTrkT2 = (global::AcpUI.AcpLabel)target;
			this.LblSystemAliasTrkT2.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5A3:
			this.CallType = (global::AcpUI.AcpComboBox)target;
			this.CallType.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5C7:
			this.CopyButtonCustmSystemID = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5D4:
			this.CVBtnHomeSystemID = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5E1:
			this.CustmGroupNumberMDC = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CustmGroupNumberMDC.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_605:
			this.WACNIDComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_612:
			this.CVBtnIndividualID = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_61F:
			this.IndividualID = (global::AcpUI.AcpTextBoxSpinner)target;
			this.IndividualID.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_643:
			this.ExpAstroCallList = (global::AcpUI.AcpExpander)target;
			return;
			IL_650:
			this.HLinkTrunkingT2CallList = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkTrunkingT2CallList.Click += this.HLinkContactClick;
			return;
			IL_674:
			this.CopyButtonSystemAliasTrkT2 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_681:
			this.IndividualIDComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_68E:
			this.SystemNameTableMDC = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_69B:
			this.SystemNameTableTrkT2 = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_6A8:
			this.SystemAliasCompMDC = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_6B5:
			this.StdGridGeneralGrp = (global::System.Windows.Controls.Grid)target;
			return;
			IL_6C2:
			this.HLinkGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkGeneral.Click += this.HLinkContactClick;
			return;
			IL_6E6:
			this.PhoneCallListDataPresenter = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_6F3:
			this.RTDBtnCustmSystemID = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_700:
			this.GroupBoxSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_70D:
			this.CVBtnSystemAliasMDC = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_71A:
			this.TxtBoxContactAlias = (global::AcpUI.AcpTextBox)target;
			this.TxtBoxContactAlias.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_73E:
			this.LblSystemAlias = (global::AcpUI.AcpLabel)target;
			this.LblSystemAlias.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_762:
			this.CVBtnCustmGroupNumber = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_76F:
			this.LblTrunkingCallListHomeSystemID = (global::AcpUI.AcpLabel)target;
			this.LblTrunkingCallListHomeSystemID.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_793:
			this.RTDBtnCustmGroupNumberMDC = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_7A0:
			num = (short)682098689;
			if (num != 0)
			{
			}
			this.CustmGroupNumberTableMDC = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_7D5:
			this.CVBtnPrimaryIDMDC = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_7E2:
			this.CopyButtonSystemGroupNumberMDC = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_7EF:
			this.CVBtnWACNID = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_7FC:
			this.RtdBtnSystemGroupNumber = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_809:
			this.GridTrunkingT2CallList = (global::System.Windows.Controls.Grid)target;
			return;
			IL_816:
			this.IndividualIDTableAstro = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_823:
			this.IndividualIDTable = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_830:
			this.PrimaryIDTableMDC = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_83D:
			this.CVBtnSystemAliasAstro = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_84A:
			this.CVBtnSystemIDTrkT2 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_857:
			this.gridTrkT2 = (global::System.Windows.Controls.Grid)target;
			return;
			IL_864:
			this.RtdBtnSystemIDTrkT2 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_871:
			this.SystemGroupNumberTable = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_87E:
			this.GridPhoneCallList = (global::System.Windows.Controls.Grid)target;
			return;
			IL_88B:
			this.RtdBtnIndividualIDTrkT2 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_898:
			this.CVBtnCustmSystemIDTrkT2 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_8A5:
			this.RtdBtnSystemAliasAstro = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_8B2:
			this.LblSystemAliasMDC = (global::AcpUI.AcpLabel)target;
			this.LblSystemAliasMDC.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_8D6:
			this.gridAstro = (global::System.Windows.Controls.Grid)target;
			return;
			IL_8E3:
			this.CustmSystemID = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.CustmSystemID.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_907:
			this.RecNavToolbarTrunkingCallList = (global::AcpUI.AcpChildRecNavToolbar)target;
			this.RecNavToolbarTrunkingCallList.ModeClick += this.OnModeClick;
			return;
			IL_92B:
			this.CustmWACNIDTable = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_938:
			this.HLinkTrunkingCallList = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkTrunkingCallList.Click += this.HLinkContactClick;
			return;
			IL_95C:
			this.RASWACNIDTable = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_969:
			this.TrunkingT2CallListDataPresenter = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_976:
			this.CopyButtonSystemGroupNumber = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_983:
			this.CopyButtonSystemAliasAstro = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_990:
			this.RtdBtnIndividualIDAstro = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_99D:
			this.GroupBoxTableViewTrkT2 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_9AA:
			this.RecNavToolbarAstroCallList = (global::AcpUI.AcpChildRecNavToolbar)target;
			this.RecNavToolbarAstroCallList.ModeClick += this.OnModeClick;
			return;
			IL_9CE:
			this.GroupBoxTableViewMDC = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_9F2:
			goto IL_1480;
			IL_9F7:
			this.RecNavToolbarUclContact = (global::AcpUI.AcpParentRecNavToolbar)target;
			this.RecNavToolbarUclContact.ModeClick += this.OnModeClick;
			return;
			IL_A1B:
			this.GroupBoxSRecViewAstro = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_A28:
			this.LblTrunkingT2CallListIndividualID = (global::AcpUI.AcpLabel)target;
			this.LblTrunkingT2CallListIndividualID.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A4C:
			this.LblTrunkingT2CallListSystemID = (global::AcpUI.AcpLabel)target;
			this.LblTrunkingT2CallListSystemID.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A70:
			this.RecNavToolbarTrunkingT2CallList = (global::AcpUI.AcpChildRecNavToolbar)target;
			this.RecNavToolbarTrunkingT2CallList.ModeClick += this.OnModeClick;
			return;
			IL_A94:
			this.SystemAliasCompTrkT2 = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_AA1:
			this.grid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_AAE:
			this.RtdBtnSystemGroupNumberMDC = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_ABB:
			this.CVBtnIndividualIDAstro = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_AC8:
			this.LblAstroCallListIndividualID = (global::AcpUI.AcpLabel)target;
			this.LblAstroCallListIndividualID.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_AEC:
			this.CopyButtonHomeSystemID = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_AF9:
			this.LblCustmGroupNumberMDC = (global::AcpUI.AcpLabel)target;
			this.LblCustmGroupNumberMDC.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_B1D:
			this.CopyButtonCallType = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B2A:
			this.AstroCallListDataPresenter = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_B37:
			this.SystemGroupNumberTableMDC = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_B44:
			this.CopyButtonWACNID = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B51:
			this.CustmSystemIDTableTrkT2 = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_B5E:
			this.CallTypeComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_B6B:
			this.IndividualIDAstro = (global::AcpUI.AcpTextBoxSpinner)target;
			this.IndividualIDAstro.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B8F:
			this.SystemGroupNumberCompMDC = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_B9C:
			this.CustmGroupNumberComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_BA9:
			this.LblCustmGroupNumber = (global::AcpUI.AcpLabel)target;
			this.LblCustmGroupNumber.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_BCD:
			this.CompGridGrpAstro = (global::System.Windows.Controls.Grid)target;
			return;
			IL_BDA:
			this.RecNavToolbarMDCCallList = (global::AcpUI.AcpChildRecNavToolbar)target;
			this.RecNavToolbarMDCCallList.ModeClick += this.OnModeClick;
			return;
			IL_BFE:
			this.PrimaryIDCompMDC = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_C0B:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_C18:
			this.CopyButtonSystemAlias = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_C25:
			this.CopyButtonCustmGroupNumber = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_C32:
			this.PhoneNumber = (global::AcpUI.AcpTextBox)target;
			this.PhoneNumber.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_C56:
			this.GroupBoxTableViewAstro = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_C63:
			this.CustmSystemIDTrkT2 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CustmSystemIDTrkT2.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_C87:
			this.CompGrpBoxExpanderColumn = (global::System.Windows.Controls.Grid)target;
			return;
			IL_C94:
			this.GridMDCCallList = (global::System.Windows.Controls.Grid)target;
			return;
			IL_CA1:
			this.SystemIDTableTrkT2 = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_CAE:
			this.SystemAliasTrkT2 = (global::AcpUI.AcpComboBox)target;
			this.SystemAliasTrkT2.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_CD2:
			this.PhoneCategoryComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_CDF:
			this.CopyButtonSystemIDTrkT2 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_CEC:
			this.StdGrpBoxExpanderColumn = (global::System.Windows.Controls.Grid)target;
			return;
			IL_CF9:
			this.CopyContactAlias = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_D06:
			this.CustmSystemIDTable = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_D13:
			this.SystemAliasCompAstro = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_D20:
			this.CompGridGrpMDC = (global::System.Windows.Controls.Grid)target;
			return;
			IL_D2D:
			this.RtdBtnCallType = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_D3A:
			this.GridAstroCallList = (global::System.Windows.Controls.Grid)target;
			return;
			IL_D47:
			this.GroupBoxSRecViewPhone = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_D54:
			this.LblTrunkingCallListIndividualID = (global::AcpUI.AcpLabel)target;
			this.LblTrunkingCallListIndividualID.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_D78:
			this.CopyButtonCustmSystemIDTrkT2 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_D85:
			this.CopyButtonPrimaryIDMDC = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_D92:
			this.LblPhoneCallListPhoneCategory = (global::AcpUI.AcpLabel)target;
			this.LblPhoneCallListPhoneCategory.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_DB6:
			this.IndividualIDTableTrkT2 = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_DC3:
			this.CompGridGrpTrunking = (global::System.Windows.Controls.Grid)target;
			return;
			IL_DD0:
			this.CopyButtonIndividualIDAstro = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_DDD:
			this.CVBtnPhoneNumber = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_DEA:
			this.LblPhoneCallListPhoneNumber = (global::AcpUI.AcpLabel)target;
			this.LblPhoneCallListPhoneNumber.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_E0E:
			this.CustmSystemIDComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_E1B:
			this.SystemIDTrkT2 = (global::AcpUI.AcpTextBox)target;
			this.SystemIDTrkT2.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_E3F:
			this.StdGridGeneralGrpPhone = (global::System.Windows.Controls.Grid)target;
			return;
			IL_E4C:
			this.SystemAliasMDC = (global::AcpUI.AcpComboBox)target;
			this.SystemAliasMDC.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_E70:
			this.CustmGroupNumberTable = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_E7D:
			this.HomeSystemID = (global::AcpUI.AcpTextBox)target;
			this.HomeSystemID.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_EA1:
			this.TrunkingCallListDataPresenter = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_EAE:
			this.CustmSystemIDCompTrkT2 = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_EBB:
			this.CategoryTablePhone = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_EC8:
			num = (short)1550188544;
			short num3 = num;
			this.HLinkPhoneCallList = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkPhoneCallList.Click += this.HLinkContactClick;
			return;
			IL_F15:
			this.SystemNameTable = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_F22:
			this.LblTrunkingCallListWACNID = (global::AcpUI.AcpLabel)target;
			this.LblTrunkingCallListWACNID.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_F46:
			this.ContactAliasComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_F53:
			this.HomeSystemIDComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_F60:
			this.GridTrunkingCallList = (global::System.Windows.Controls.Grid)target;
			return;
			IL_F6D:
			this.StdGridGeneralGrpMDC = (global::System.Windows.Controls.Grid)target;
			return;
			IL_F7A:
			this.RtdBtnPrimaryIDMDC = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_F87:
			this.CopyButtonCustmWACNID = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_F94:
			this.LblAstroCallListSystemGroupNumber = (global::AcpUI.AcpLabel)target;
			this.LblAstroCallListSystemGroupNumber.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_FB8:
			this.SystemIDCompTrkT2 = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_FC5:
			this.WACNID = (global::AcpUI.AcpTextBox)target;
			this.WACNID.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_FE9:
			num = (short)1743688058;
			short num4 = num;
			num = (short)1242337658;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_7E2;
			default:
				num = (short)457179136;
				if (num != 0)
				{
				}
				this.gridPhone = (global::System.Windows.Controls.Grid)target;
				return;
			}
			IL_1042:
			this.CompGridGrpPhone = (global::System.Windows.Controls.Grid)target;
			return;
			IL_104F:
			this.ExpTrunkingCallList = (global::AcpUI.AcpExpander)target;
			return;
			IL_105C:
			this.LblMDCCallListPrimaryID = (global::AcpUI.AcpLabel)target;
			this.LblMDCCallListPrimaryID.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1080:
			this.SystemGroupNumber = (global::AcpUI.AcpTextBox)target;
			this.SystemGroupNumber.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_10A4:
			this.StdGridGeneralGrpAstro = (global::System.Windows.Controls.Grid)target;
			return;
			IL_10B1:
			this.CVBtnIndividualIDTrkT2 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_10BE:
			this.GroupBoxSRecViewMDC = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_10CB:
			this.IndividualIDCompTrkT2 = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_10D8:
			this.CVBtnCustmSystemID = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_10E5:
			this.PrimaryIDMDC = (global::AcpUI.AcpTextBoxSpinner)target;
			this.PrimaryIDMDC.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1109:
			this.RtdBtnSystemAlias = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1116:
			this.LblMDCCallListSystemGroupNumber = (global::AcpUI.AcpLabel)target;
			this.LblMDCCallListSystemGroupNumber.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_113A:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_1147:
			this.PhoneNumberComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_1154:
			this.CVBtnContactAlias = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1161:
			this.gridMDC = (global::System.Windows.Controls.Grid)target;
			return;
			IL_116E:
			this.CopyButtonIndividualIDTrkT2 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_117B:
			this.CustmGroupNumberCompMDC = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_1188:
			this.CopyButtonPhoneCategory = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1195:
			this.CVBtnSystemAlias = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_11A2:
			this.RtdBtnPhoneNumber = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_11AF:
			this.LblSystemAliasAstro = (global::AcpUI.AcpLabel)target;
			this.LblSystemAliasAstro.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_11D3:
			this.ExpTrunkingT2CallList = (global::AcpUI.AcpExpander)target;
			return;
			IL_11E0:
			this.CVBtnCallType = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_11ED:
			this.GroupBoxTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_11FA:
			this.LblCustmWACNID = (global::AcpUI.AcpLabel)target;
			this.LblCustmWACNID.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_121E:
			this.ExpMDCCallList = (global::AcpUI.AcpExpander)target;
			return;
			IL_122B:
			this.RtdBtnIndividualID = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1238:
			this.CallTypeTable = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1245:
			this.CopyButtonPhoneNumber = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1252:
			this.HLinkMDCCallList = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkMDCCallList.Click += this.HLinkContactClick;
			return;
			IL_1276:
			this.LblCustmSystemIDTrkT2 = (global::AcpUI.AcpLabel)target;
			this.LblCustmSystemIDTrkT2.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_129A:
			this.RtdBtnSystemAliasMDC = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_12A7:
			this.RTDBtnCustmSystemIDTrkT2 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_12B4:
			this.CompGridGrpTrkT2 = (global::System.Windows.Controls.Grid)target;
			return;
			IL_12C1:
			this.CopyButtonSystemAliasMDC = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_12CE:
			this.PhoneCategory = (global::AcpUI.AcpComboBox)target;
			this.PhoneCategory.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_12F2:
			this.CVBtnPhoneCategory = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_12FF:
			this.RTDBtnCustmGroupNumber = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_130C:
			this.CustmGroupNumber = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CustmGroupNumber.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1330:
			this.MDCCallListDataPresenter = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_133D:
			this.SystemAliasComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_134A:
			this.LblAstroCallListCallType = (global::AcpUI.AcpLabel)target;
			this.LblAstroCallListCallType.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_136E:
			this.CustmWACNIDComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_137B:
			this.HLinkAstroCallList = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkAstroCallList.Click += this.HLinkContactClick;
			return;
			IL_139F:
			this.CopyButtonIndividualID = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_13AC:
			this.CustmWACNID = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.CustmWACNID.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_13D0:
			this.LblContactAlias = (global::AcpUI.AcpLabel)target;
			this.LblContactAlias.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_13F4:
			this.SystemNameTableAstro = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1401:
			this.ExpGeneral = (global::AcpUI.AcpExpander)target;
			return;
			IL_140E:
			this.ExpPhoneCallList = (global::AcpUI.AcpExpander)target;
			return;
			IL_141B:
			this.SystemGroupNumberMDC = (global::AcpUI.AcpTextBox)target;
			this.SystemGroupNumberMDC.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_143F:
			this.StdGridGeneralGrpTrkT2 = (global::System.Windows.Controls.Grid)target;
			return;
			IL_144C:
			this.CVBtnCustmWACNID = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1459:
			this.NumberTablePhone = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1466:
			this.GroupBoxSRecViewTrkT2 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1473:
			this.RtdBtnSystemAliasTrkT2 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1480:
			this.b = true;
		}

		// Token: 0x06001B84 RID: 7044 RVA: 0x002392D8 File Offset: 0x002374D8
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 3:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 4:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 5:
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 6:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 7:
			{
				short num = (short)1910046720;
				short num2 = num;
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			case 8:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 9:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 10:
			{
				short num = (short)661932447;
				short num3 = num;
				num = (short)1529039263;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)948895744;
					if (num != 0)
					{
					}
					((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				}
				break;
			}
			case 11:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 12:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 13:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 14:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 15:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 16:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 17:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 18:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 19:
			{
				short num = (short)1098711041;
				if (num != 0)
				{
				}
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			case 20:
				break;
			case 21:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 22:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 23:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			default:
				return;
			}
			((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x04000CD0 RID: 3280
		private bool a;

		// Token: 0x04000CD1 RID: 3281
		internal global::AcpUI.AcpParentRecNavToolbar RecNavToolbarUclContact;

		// Token: 0x04000CD2 RID: 3282
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x04000CD3 RID: 3283
		internal global::System.Windows.Documents.Hyperlink HLinkGeneral;

		// Token: 0x04000CD4 RID: 3284
		internal global::System.Windows.Documents.Hyperlink HLinkTrunkingCallList;

		// Token: 0x04000CD5 RID: 3285
		internal global::System.Windows.Documents.Hyperlink HLinkTrunkingT2CallList;

		// Token: 0x04000CD6 RID: 3286
		internal global::System.Windows.Documents.Hyperlink HLinkAstroCallList;

		// Token: 0x04000CD7 RID: 3287
		internal global::System.Windows.Documents.Hyperlink HLinkMDCCallList;

		// Token: 0x04000CD8 RID: 3288
		internal global::System.Windows.Documents.Hyperlink HLinkPhoneCallList;

		// Token: 0x04000CD9 RID: 3289
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x04000CDA RID: 3290
		internal global::AcpUI.AcpExpander ExpGeneral;

		// Token: 0x04000CDB RID: 3291
		internal global::System.Windows.Controls.Grid StdGrpBoxExpanderColumn;

		// Token: 0x04000CDC RID: 3292
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnContactAlias;

		// Token: 0x04000CDD RID: 3293
		internal global::AcpUI.AcpLabel LblContactAlias;

		// Token: 0x04000CDE RID: 3294
		internal global::AcpUI.AcpTextBox TxtBoxContactAlias;

		// Token: 0x04000CDF RID: 3295
		internal global::System.Windows.Controls.Grid CompGrpBoxExpanderColumn;

		// Token: 0x04000CE0 RID: 3296
		internal global::AcpUI.AcpCopyButton CopyContactAlias;

		// Token: 0x04000CE1 RID: 3297
		internal global::AcpUI.AcpViewOnlyCtrl ContactAliasComp;

		// Token: 0x04000CE2 RID: 3298
		internal global::AcpUI.AcpExpander ExpTrunkingCallList;

		// Token: 0x04000CE3 RID: 3299
		internal global::AcpUI.AcpChildRecNavToolbar RecNavToolbarTrunkingCallList;

		// Token: 0x04000CE4 RID: 3300
		internal global::System.Windows.Controls.Grid GridTrunkingCallList;

		// Token: 0x04000CE5 RID: 3301
		internal global::AcpUI.AcpGroupBox GroupBoxTableView;

		// Token: 0x04000CE6 RID: 3302
		internal global::AcpUI.AcpXamDataPresenter TrunkingCallListDataPresenter;

		// Token: 0x04000CE7 RID: 3303
		internal global::Infragistics.Windows.DataPresenter.UnboundField SystemNameTable;

		// Token: 0x04000CE8 RID: 3304
		internal global::Infragistics.Windows.DataPresenter.UnboundField RASWACNIDTable;

		// Token: 0x04000CE9 RID: 3305
		internal global::Infragistics.Windows.DataPresenter.UnboundField CustmWACNIDTable;

		// Token: 0x04000CEA RID: 3306
		internal global::Infragistics.Windows.DataPresenter.UnboundField SystemIDTable;

		// Token: 0x04000CEB RID: 3307
		internal global::Infragistics.Windows.DataPresenter.UnboundField CustmSystemIDTable;

		// Token: 0x04000CEC RID: 3308
		internal global::Infragistics.Windows.DataPresenter.UnboundField IndividualIDTable;

		// Token: 0x04000CED RID: 3309
		internal global::AcpUI.AcpGroupBox GroupBoxSRecView;

		// Token: 0x04000CEE RID: 3310
		internal global::System.Windows.Controls.Grid grid;

		// Token: 0x04000CEF RID: 3311
		internal global::System.Windows.Controls.Grid StdGridGeneralGrp;

		// Token: 0x04000CF0 RID: 3312
		internal global::AcpUI.AcpComboBox SystemAlias;

		// Token: 0x04000CF1 RID: 3313
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSystemAlias;

		// Token: 0x04000CF2 RID: 3314
		internal global::AcpUI.AcpLabel LblSystemAlias;

		// Token: 0x04000CF3 RID: 3315
		internal global::AcpUI.AcpRtdButton RtdBtnSystemAlias;

		// Token: 0x04000CF4 RID: 3316
		internal global::AcpUI.AcpTextBox WACNID;

		// Token: 0x04000CF5 RID: 3317
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnWACNID;

		// Token: 0x04000CF6 RID: 3318
		internal global::AcpUI.AcpLabel LblTrunkingCallListWACNID;

		// Token: 0x04000CF7 RID: 3319
		internal global::AcpUI.AcpRtdButton RtdBtnWACNID;

		// Token: 0x04000CF8 RID: 3320
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCustmWACNID;

		// Token: 0x04000CF9 RID: 3321
		internal global::AcpUI.AcpLabel LblCustmWACNID;

		// Token: 0x04000CFA RID: 3322
		internal global::AcpUI.AcpTextBoxSpinnerDecHex CustmWACNID;

		// Token: 0x04000CFB RID: 3323
		internal global::AcpUI.AcpRtdButton RTDBtnCustmWACNID;

		// Token: 0x04000CFC RID: 3324
		internal global::AcpUI.AcpTextBox HomeSystemID;

		// Token: 0x04000CFD RID: 3325
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnHomeSystemID;

		// Token: 0x04000CFE RID: 3326
		internal global::AcpUI.AcpLabel LblTrunkingCallListHomeSystemID;

		// Token: 0x04000CFF RID: 3327
		internal global::AcpUI.AcpRtdButton RtdBtnHomeSystemID;

		// Token: 0x04000D00 RID: 3328
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCustmSystemID;

		// Token: 0x04000D01 RID: 3329
		internal global::AcpUI.AcpLabel LblCustmSystemID;

		// Token: 0x04000D02 RID: 3330
		internal global::AcpUI.AcpTextBoxSpinnerDecHex CustmSystemID;

		// Token: 0x04000D03 RID: 3331
		internal global::AcpUI.AcpRtdButton RTDBtnCustmSystemID;

		// Token: 0x04000D04 RID: 3332
		internal global::AcpUI.AcpTextBoxSpinner IndividualID;

		// Token: 0x04000D05 RID: 3333
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnIndividualID;

		// Token: 0x04000D06 RID: 3334
		internal global::AcpUI.AcpLabel LblTrunkingCallListIndividualID;

		// Token: 0x04000D07 RID: 3335
		internal global::AcpUI.AcpRtdButton RtdBtnIndividualID;

		// Token: 0x04000D08 RID: 3336
		internal global::System.Windows.Controls.Grid CompGridGrpTrunking;

		// Token: 0x04000D09 RID: 3337
		internal global::AcpUI.AcpCopyButton CopyButtonSystemAlias;

		// Token: 0x04000D0A RID: 3338
		internal global::AcpUI.AcpViewOnlyCtrl SystemAliasComp;

		// Token: 0x04000D0B RID: 3339
		internal global::AcpUI.AcpCopyButton CopyButtonWACNID;

		// Token: 0x04000D0C RID: 3340
		internal global::AcpUI.AcpViewOnlyCtrl WACNIDComp;

		// Token: 0x04000D0D RID: 3341
		internal global::AcpUI.AcpCopyButton CopyButtonCustmWACNID;

		// Token: 0x04000D0E RID: 3342
		internal global::AcpUI.AcpViewOnlyCtrl CustmWACNIDComp;

		// Token: 0x04000D0F RID: 3343
		internal global::AcpUI.AcpCopyButton CopyButtonHomeSystemID;

		// Token: 0x04000D10 RID: 3344
		internal global::AcpUI.AcpViewOnlyCtrl HomeSystemIDComp;

		// Token: 0x04000D11 RID: 3345
		internal global::AcpUI.AcpCopyButton CopyButtonCustmSystemID;

		// Token: 0x04000D12 RID: 3346
		internal global::AcpUI.AcpViewOnlyCtrl CustmSystemIDComp;

		// Token: 0x04000D13 RID: 3347
		internal global::AcpUI.AcpCopyButton CopyButtonIndividualID;

		// Token: 0x04000D14 RID: 3348
		internal global::AcpUI.AcpViewOnlyCtrl IndividualIDComp;

		// Token: 0x04000D15 RID: 3349
		internal global::AcpUI.AcpExpander ExpTrunkingT2CallList;

		// Token: 0x04000D16 RID: 3350
		internal global::AcpUI.AcpChildRecNavToolbar RecNavToolbarTrunkingT2CallList;

		// Token: 0x04000D17 RID: 3351
		internal global::System.Windows.Controls.Grid GridTrunkingT2CallList;

		// Token: 0x04000D18 RID: 3352
		internal global::AcpUI.AcpGroupBox GroupBoxTableViewTrkT2;

		// Token: 0x04000D19 RID: 3353
		internal global::AcpUI.AcpXamDataPresenter TrunkingT2CallListDataPresenter;

		// Token: 0x04000D1A RID: 3354
		internal global::Infragistics.Windows.DataPresenter.UnboundField SystemNameTableTrkT2;

		// Token: 0x04000D1B RID: 3355
		internal global::Infragistics.Windows.DataPresenter.UnboundField SystemIDTableTrkT2;

		// Token: 0x04000D1C RID: 3356
		internal global::Infragistics.Windows.DataPresenter.UnboundField CustmSystemIDTableTrkT2;

		// Token: 0x04000D1D RID: 3357
		internal global::Infragistics.Windows.DataPresenter.UnboundField IndividualIDTableTrkT2;

		// Token: 0x04000D1E RID: 3358
		internal global::AcpUI.AcpGroupBox GroupBoxSRecViewTrkT2;

		// Token: 0x04000D1F RID: 3359
		internal global::System.Windows.Controls.Grid gridTrkT2;

		// Token: 0x04000D20 RID: 3360
		internal global::System.Windows.Controls.Grid StdGridGeneralGrpTrkT2;

		// Token: 0x04000D21 RID: 3361
		internal global::AcpUI.AcpComboBox SystemAliasTrkT2;

		// Token: 0x04000D22 RID: 3362
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSystemAliasTrkT2;

		// Token: 0x04000D23 RID: 3363
		internal global::AcpUI.AcpLabel LblSystemAliasTrkT2;

		// Token: 0x04000D24 RID: 3364
		internal global::AcpUI.AcpRtdButton RtdBtnSystemAliasTrkT2;

		// Token: 0x04000D25 RID: 3365
		internal global::AcpUI.AcpTextBox SystemIDTrkT2;

		// Token: 0x04000D26 RID: 3366
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSystemIDTrkT2;

		// Token: 0x04000D27 RID: 3367
		internal global::AcpUI.AcpLabel LblTrunkingT2CallListSystemID;

		// Token: 0x04000D28 RID: 3368
		internal global::AcpUI.AcpRtdButton RtdBtnSystemIDTrkT2;

		// Token: 0x04000D29 RID: 3369
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCustmSystemIDTrkT2;

		// Token: 0x04000D2A RID: 3370
		internal global::AcpUI.AcpLabel LblCustmSystemIDTrkT2;

		// Token: 0x04000D2B RID: 3371
		internal global::AcpUI.AcpTextBoxSpinner CustmSystemIDTrkT2;

		// Token: 0x04000D2C RID: 3372
		internal global::AcpUI.AcpRtdButton RTDBtnCustmSystemIDTrkT2;

		// Token: 0x04000D2D RID: 3373
		internal global::AcpUI.AcpTextBoxSpinner IndividualIDTrkT2;

		// Token: 0x04000D2E RID: 3374
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnIndividualIDTrkT2;

		// Token: 0x04000D2F RID: 3375
		internal global::AcpUI.AcpLabel LblTrunkingT2CallListIndividualID;

		// Token: 0x04000D30 RID: 3376
		internal global::AcpUI.AcpRtdButton RtdBtnIndividualIDTrkT2;

		// Token: 0x04000D31 RID: 3377
		internal global::System.Windows.Controls.Grid CompGridGrpTrkT2;

		// Token: 0x04000D32 RID: 3378
		internal global::AcpUI.AcpCopyButton CopyButtonSystemAliasTrkT2;

		// Token: 0x04000D33 RID: 3379
		internal global::AcpUI.AcpViewOnlyCtrl SystemAliasCompTrkT2;

		// Token: 0x04000D34 RID: 3380
		internal global::AcpUI.AcpCopyButton CopyButtonSystemIDTrkT2;

		// Token: 0x04000D35 RID: 3381
		internal global::AcpUI.AcpViewOnlyCtrl SystemIDCompTrkT2;

		// Token: 0x04000D36 RID: 3382
		internal global::AcpUI.AcpCopyButton CopyButtonCustmSystemIDTrkT2;

		// Token: 0x04000D37 RID: 3383
		internal global::AcpUI.AcpViewOnlyCtrl CustmSystemIDCompTrkT2;

		// Token: 0x04000D38 RID: 3384
		internal global::AcpUI.AcpCopyButton CopyButtonIndividualIDTrkT2;

		// Token: 0x04000D39 RID: 3385
		internal global::AcpUI.AcpViewOnlyCtrl IndividualIDCompTrkT2;

		// Token: 0x04000D3A RID: 3386
		internal global::AcpUI.AcpExpander ExpAstroCallList;

		// Token: 0x04000D3B RID: 3387
		internal global::AcpUI.AcpChildRecNavToolbar RecNavToolbarAstroCallList;

		// Token: 0x04000D3C RID: 3388
		internal global::System.Windows.Controls.Grid GridAstroCallList;

		// Token: 0x04000D3D RID: 3389
		internal global::AcpUI.AcpGroupBox GroupBoxTableViewAstro;

		// Token: 0x04000D3E RID: 3390
		internal global::AcpUI.AcpXamDataPresenter AstroCallListDataPresenter;

		// Token: 0x04000D3F RID: 3391
		internal global::Infragistics.Windows.DataPresenter.UnboundField SystemNameTableAstro;

		// Token: 0x04000D40 RID: 3392
		internal global::Infragistics.Windows.DataPresenter.UnboundField SystemGroupNumberTable;

		// Token: 0x04000D41 RID: 3393
		internal global::Infragistics.Windows.DataPresenter.UnboundField CustmGroupNumberTable;

		// Token: 0x04000D42 RID: 3394
		internal global::Infragistics.Windows.DataPresenter.UnboundField IndividualIDTableAstro;

		// Token: 0x04000D43 RID: 3395
		internal global::Infragistics.Windows.DataPresenter.UnboundField CallTypeTable;

		// Token: 0x04000D44 RID: 3396
		internal global::AcpUI.AcpGroupBox GroupBoxSRecViewAstro;

		// Token: 0x04000D45 RID: 3397
		internal global::System.Windows.Controls.Grid gridAstro;

		// Token: 0x04000D46 RID: 3398
		internal global::System.Windows.Controls.Grid StdGridGeneralGrpAstro;

		// Token: 0x04000D47 RID: 3399
		internal global::AcpUI.AcpComboBox SystemAliasAstro;

		// Token: 0x04000D48 RID: 3400
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSystemAliasAstro;

		// Token: 0x04000D49 RID: 3401
		internal global::AcpUI.AcpLabel LblSystemAliasAstro;

		// Token: 0x04000D4A RID: 3402
		internal global::AcpUI.AcpRtdButton RtdBtnSystemAliasAstro;

		// Token: 0x04000D4B RID: 3403
		internal global::AcpUI.AcpTextBox SystemGroupNumber;

		// Token: 0x04000D4C RID: 3404
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSystemGroupNumber;

		// Token: 0x04000D4D RID: 3405
		internal global::AcpUI.AcpLabel LblAstroCallListSystemGroupNumber;

		// Token: 0x04000D4E RID: 3406
		internal global::AcpUI.AcpRtdButton RtdBtnSystemGroupNumber;

		// Token: 0x04000D4F RID: 3407
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCustmGroupNumber;

		// Token: 0x04000D50 RID: 3408
		internal global::AcpUI.AcpLabel LblCustmGroupNumber;

		// Token: 0x04000D51 RID: 3409
		internal global::AcpUI.AcpTextBoxSpinner CustmGroupNumber;

		// Token: 0x04000D52 RID: 3410
		internal global::AcpUI.AcpRtdButton RTDBtnCustmGroupNumber;

		// Token: 0x04000D53 RID: 3411
		internal global::AcpUI.AcpTextBoxSpinner IndividualIDAstro;

		// Token: 0x04000D54 RID: 3412
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnIndividualIDAstro;

		// Token: 0x04000D55 RID: 3413
		internal global::AcpUI.AcpLabel LblAstroCallListIndividualID;

		// Token: 0x04000D56 RID: 3414
		internal global::AcpUI.AcpRtdButton RtdBtnIndividualIDAstro;

		// Token: 0x04000D57 RID: 3415
		internal global::AcpUI.AcpComboBox CallType;

		// Token: 0x04000D58 RID: 3416
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCallType;

		// Token: 0x04000D59 RID: 3417
		internal global::AcpUI.AcpLabel LblAstroCallListCallType;

		// Token: 0x04000D5A RID: 3418
		internal global::AcpUI.AcpRtdButton RtdBtnCallType;

		// Token: 0x04000D5B RID: 3419
		internal global::System.Windows.Controls.Grid CompGridGrpAstro;

		// Token: 0x04000D5C RID: 3420
		internal global::AcpUI.AcpCopyButton CopyButtonSystemAliasAstro;

		// Token: 0x04000D5D RID: 3421
		internal global::AcpUI.AcpViewOnlyCtrl SystemAliasCompAstro;

		// Token: 0x04000D5E RID: 3422
		internal global::AcpUI.AcpCopyButton CopyButtonSystemGroupNumber;

		// Token: 0x04000D5F RID: 3423
		internal global::AcpUI.AcpViewOnlyCtrl SystemGroupNumberComp;

		// Token: 0x04000D60 RID: 3424
		internal global::AcpUI.AcpCopyButton CopyButtonCustmGroupNumber;

		// Token: 0x04000D61 RID: 3425
		internal global::AcpUI.AcpViewOnlyCtrl CustmGroupNumberComp;

		// Token: 0x04000D62 RID: 3426
		internal global::AcpUI.AcpCopyButton CopyButtonIndividualIDAstro;

		// Token: 0x04000D63 RID: 3427
		internal global::AcpUI.AcpViewOnlyCtrl IndividualIDCompAstro;

		// Token: 0x04000D64 RID: 3428
		internal global::AcpUI.AcpCopyButton CopyButtonCallType;

		// Token: 0x04000D65 RID: 3429
		internal global::AcpUI.AcpViewOnlyCtrl CallTypeComp;

		// Token: 0x04000D66 RID: 3430
		internal global::AcpUI.AcpExpander ExpMDCCallList;

		// Token: 0x04000D67 RID: 3431
		internal global::AcpUI.AcpChildRecNavToolbar RecNavToolbarMDCCallList;

		// Token: 0x04000D68 RID: 3432
		internal global::System.Windows.Controls.Grid GridMDCCallList;

		// Token: 0x04000D69 RID: 3433
		internal global::AcpUI.AcpGroupBox GroupBoxTableViewMDC;

		// Token: 0x04000D6A RID: 3434
		internal global::AcpUI.AcpXamDataPresenter MDCCallListDataPresenter;

		// Token: 0x04000D6B RID: 3435
		internal global::Infragistics.Windows.DataPresenter.UnboundField SystemNameTableMDC;

		// Token: 0x04000D6C RID: 3436
		internal global::Infragistics.Windows.DataPresenter.UnboundField SystemGroupNumberTableMDC;

		// Token: 0x04000D6D RID: 3437
		internal global::Infragistics.Windows.DataPresenter.UnboundField CustmGroupNumberTableMDC;

		// Token: 0x04000D6E RID: 3438
		internal global::Infragistics.Windows.DataPresenter.UnboundField PrimaryIDTableMDC;

		// Token: 0x04000D6F RID: 3439
		internal global::AcpUI.AcpGroupBox GroupBoxSRecViewMDC;

		// Token: 0x04000D70 RID: 3440
		internal global::System.Windows.Controls.Grid gridMDC;

		// Token: 0x04000D71 RID: 3441
		internal global::System.Windows.Controls.Grid StdGridGeneralGrpMDC;

		// Token: 0x04000D72 RID: 3442
		internal global::AcpUI.AcpComboBox SystemAliasMDC;

		// Token: 0x04000D73 RID: 3443
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSystemAliasMDC;

		// Token: 0x04000D74 RID: 3444
		internal global::AcpUI.AcpLabel LblSystemAliasMDC;

		// Token: 0x04000D75 RID: 3445
		internal global::AcpUI.AcpRtdButton RtdBtnSystemAliasMDC;

		// Token: 0x04000D76 RID: 3446
		internal global::AcpUI.AcpTextBox SystemGroupNumberMDC;

		// Token: 0x04000D77 RID: 3447
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSystemGroupNumberMDC;

		// Token: 0x04000D78 RID: 3448
		internal global::AcpUI.AcpLabel LblMDCCallListSystemGroupNumber;

		// Token: 0x04000D79 RID: 3449
		internal global::AcpUI.AcpRtdButton RtdBtnSystemGroupNumberMDC;

		// Token: 0x04000D7A RID: 3450
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCustmGroupNumberMDC;

		// Token: 0x04000D7B RID: 3451
		internal global::AcpUI.AcpLabel LblCustmGroupNumberMDC;

		// Token: 0x04000D7C RID: 3452
		internal global::AcpUI.AcpTextBoxSpinner CustmGroupNumberMDC;

		// Token: 0x04000D7D RID: 3453
		internal global::AcpUI.AcpRtdButton RTDBtnCustmGroupNumberMDC;

		// Token: 0x04000D7E RID: 3454
		internal global::AcpUI.AcpTextBoxSpinner PrimaryIDMDC;

		// Token: 0x04000D7F RID: 3455
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnPrimaryIDMDC;

		// Token: 0x04000D80 RID: 3456
		internal global::AcpUI.AcpLabel LblMDCCallListPrimaryID;

		// Token: 0x04000D81 RID: 3457
		internal global::AcpUI.AcpRtdButton RtdBtnPrimaryIDMDC;

		// Token: 0x04000D82 RID: 3458
		internal global::System.Windows.Controls.Grid CompGridGrpMDC;

		// Token: 0x04000D83 RID: 3459
		internal global::AcpUI.AcpCopyButton CopyButtonSystemAliasMDC;

		// Token: 0x04000D84 RID: 3460
		internal global::AcpUI.AcpViewOnlyCtrl SystemAliasCompMDC;

		// Token: 0x04000D85 RID: 3461
		internal global::AcpUI.AcpCopyButton CopyButtonSystemGroupNumberMDC;

		// Token: 0x04000D86 RID: 3462
		internal global::AcpUI.AcpViewOnlyCtrl SystemGroupNumberCompMDC;

		// Token: 0x04000D87 RID: 3463
		internal global::AcpUI.AcpCopyButton CopyButtonCustmGroupNumberMDC;

		// Token: 0x04000D88 RID: 3464
		internal global::AcpUI.AcpViewOnlyCtrl CustmGroupNumberCompMDC;

		// Token: 0x04000D89 RID: 3465
		internal global::AcpUI.AcpCopyButton CopyButtonPrimaryIDMDC;

		// Token: 0x04000D8A RID: 3466
		internal global::AcpUI.AcpViewOnlyCtrl PrimaryIDCompMDC;

		// Token: 0x04000D8B RID: 3467
		internal global::AcpUI.AcpExpander ExpPhoneCallList;

		// Token: 0x04000D8C RID: 3468
		internal global::AcpUI.AcpChildRecNavToolbar RecNavToolbarPhoneCallList;

		// Token: 0x04000D8D RID: 3469
		internal global::System.Windows.Controls.Grid GridPhoneCallList;

		// Token: 0x04000D8E RID: 3470
		internal global::AcpUI.AcpGroupBox GroupBoxTableViewPhone;

		// Token: 0x04000D8F RID: 3471
		internal global::AcpUI.AcpXamDataPresenter PhoneCallListDataPresenter;

		// Token: 0x04000D90 RID: 3472
		internal global::Infragistics.Windows.DataPresenter.UnboundField NumberTablePhone;

		// Token: 0x04000D91 RID: 3473
		internal global::Infragistics.Windows.DataPresenter.UnboundField CategoryTablePhone;

		// Token: 0x04000D92 RID: 3474
		internal global::AcpUI.AcpGroupBox GroupBoxSRecViewPhone;

		// Token: 0x04000D93 RID: 3475
		internal global::System.Windows.Controls.Grid gridPhone;

		// Token: 0x04000D94 RID: 3476
		internal global::System.Windows.Controls.Grid StdGridGeneralGrpPhone;

		// Token: 0x04000D95 RID: 3477
		internal global::AcpUI.AcpTextBox PhoneNumber;

		// Token: 0x04000D96 RID: 3478
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnPhoneNumber;

		// Token: 0x04000D97 RID: 3479
		internal global::AcpUI.AcpLabel LblPhoneCallListPhoneNumber;

		// Token: 0x04000D98 RID: 3480
		internal global::AcpUI.AcpRtdButton RtdBtnPhoneNumber;

		// Token: 0x04000D99 RID: 3481
		internal global::AcpUI.AcpComboBox PhoneCategory;

		// Token: 0x04000D9A RID: 3482
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnPhoneCategory;

		// Token: 0x04000D9B RID: 3483
		internal global::AcpUI.AcpLabel LblPhoneCallListPhoneCategory;

		// Token: 0x04000D9C RID: 3484
		internal global::AcpUI.AcpRtdButton RtdBtnPhoneCategory;

		// Token: 0x04000D9D RID: 3485
		internal global::System.Windows.Controls.Grid CompGridGrpPhone;

		// Token: 0x04000D9E RID: 3486
		internal global::AcpUI.AcpCopyButton CopyButtonPhoneNumber;

		// Token: 0x04000D9F RID: 3487
		internal global::AcpUI.AcpViewOnlyCtrl PhoneNumberComp;

		// Token: 0x04000DA0 RID: 3488
		internal global::AcpUI.AcpCopyButton CopyButtonPhoneCategory;

		// Token: 0x04000DA1 RID: 3489
		internal global::AcpUI.AcpViewOnlyCtrl PhoneCategoryComp;

		// Token: 0x04000DA2 RID: 3490
		private bool b;
	}
}
