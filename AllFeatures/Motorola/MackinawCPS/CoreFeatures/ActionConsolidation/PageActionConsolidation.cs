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

namespace Motorola.MackinawCPS.CoreFeatures.ActionConsolidation
{
	// Token: 0x0200041A RID: 1050
	public class PageActionConsolidation : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x06008FE4 RID: 36836 RVA: 0x00879CF4 File Offset: 0x00877EF4
		public PageActionConsolidation()
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

		// Token: 0x06008FE5 RID: 36837 RVA: 0x00879D2C File Offset: 0x00877F2C
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1252917248;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)403439617;
				if (num != 0)
				{
				}
				num = (short)1185742852;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::AcpUI.AcpExpander acpExpander;
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
					{
						object obj;
						if (obj != null)
						{
							num = (short)1076822017;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A9;
					}
					case 1:
					{
						object obj;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderActionConsolidationConsolidatedActions.MyDataPresenter = this.ExpanderActionConsolidationConsolidatedActions;
						num = (short)2059862022;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						this.RecNavToolbarPageActionConsolidation.ChildToolbars.Add(this.RecNavToolbarExpanderActionConsolidationConsolidatedActions);
						object obj = null;
						obj = this.RecNavToolbarExpanderActionConsolidationConsolidatedActions.MyRecordsetDataSource;
						num = (short)1433534464;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_188;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_86;
						}
						continue;
					case 5:
						try
						{
							num = (short)85327876;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									if (acpExpander != null)
									{
										num = (short)830406659;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 2:
									if (!enumerator.MoveNext())
									{
										num = (short)1028849669;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
									num = (short)1127743489;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									num = (short)1238491296;
									short num3 = num;
									num = (short)681566368;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_322;
									default:
										num = (short)1268056064;
										if (num != 0)
										{
										}
										base.Expanders.Add(acpExpander);
										num = (short)487522304;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_20A;
									}
									continue;
								case 5:
									num = (short)1295843334;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_322;
								}
								IL_20C:
								num = (short)254935042;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_20A:
								goto IL_20C;
							}
							IL_322:
							goto IL_161;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_344;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_331:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)79429634;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (disposable != null)
									{
										num = (short)441122816;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_39A;
								case 2:
									goto IL_398;
								}
								goto IL_344;
							}
							IL_398:
							IL_39A:
							goto EndFinally_8;
							IL_344:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)422510593;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_331;
							EndFinally_8:;
						}
						goto IL_39B;
						IL_161:
						base.OnLoaded(sender, e);
						this.a = true;
						num = (short)1834352643;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_A9;
					}
					IL_86:
					if (!this.a)
					{
						num = (short)185860098;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_A9:
					num = (short)900595712;
					short num4 = num;
					acpExpander = null;
					enumerator = this.MyStackPanel.Children.GetEnumerator();
					num = (short)1713176581;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_188:
				IL_39B:
				this.MyStackPanel.Children[0].Focus();
				return;
			}
		}

		// Token: 0x06008FE6 RID: 36838 RVA: 0x0087A108 File Offset: 0x00878308
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
					goto IL_BB;
				case 1:
					num2 = (short)1891565569;
					if (num2 != 0)
					{
					}
					if (this.a)
					{
						num2 = (short)732626944;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
				{
					num2 = (short)886105393;
					short num3 = num2;
					num2 = (short)1952113969;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_BB;
					default:
						goto IL_12F;
					}
					break;
				}
				}
				goto IL_1C;
				IL_BB:
				num2 = (short)1176174592;
				short num4 = num2;
				num2 = (short)932118530;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_12F:
			num2 = (short)1763573760;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			this.RecNavToolbarPageActionConsolidation.DataContext = null;
			this.RecNavToolbarExpanderActionConsolidationConsolidatedActions.DataContext = null;
			this.RecNavToolbarPageActionConsolidation.MyDataPresenter = null;
			this.RecNavToolbarExpanderActionConsolidationConsolidatedActions.MyDataPresenter = null;
			num2 = (short)1291452417;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06008FE7 RID: 36839 RVA: 0x0087A25C File Offset: 0x0087845C
		public override void SetDataContext()
		{
			short num = (short)1933246470;
			int num2 = (int)((global::System.IntPtr)num);
			object feature;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_1C3;
				case 1:
					goto IL_7F;
				case 2:
					if (feature != null)
					{
						num = (short)435552264;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C3;
				case 3:
					goto IL_7F;
				case 4:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(4008);
					num = (short)707395587;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(4008);
					num = (short)1209466882;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					IL_14:
					switch (0)
					{
					case 0:
						goto IL_48;
					}
					continue;
				case 7:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)1344929797;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageActionConsolidation).MySecondaryRecordsetDataSource = null;
					num = (short)1974796288;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_1BE;
				}
				IL_48:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)48562180;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(4008);
				num = (short)272760833;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_7F:
				num = (short)171704320;
				short num3 = num;
				this.RecNavToolbarPageActionConsolidation.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				num = (short)34996231;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1C3:
				num = (short)2080259410;
				short num4 = num;
				num = (short)1872510290;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_14;
				default:
					goto IL_1F7;
				}
			}
			IL_1BE:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageActionConsolidation).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
			return;
			IL_1F7:
			num = (short)1306525696;
			if (num != 0)
			{
			}
			num = (short)340590593;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008FE8 RID: 36840 RVA: 0x0087A4A0 File Offset: 0x008786A0
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 3;
			short num = (short)1329987584;
			switch (num)
			{
			default:
			{
				num = (short)739639316;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)47169175;
					short num3 = num;
					num = (short)937672343;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1E5;
					case 1:
						break;
					default:
					{
						num = (short)1895759872;
						short num4 = num;
						break;
					}
					}
					num = (short)646512640;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource;
						base.NavigationService.Navigate(new global::System.Uri(myRecordsetDataSource.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
						num = (short)207683596;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						num = (short)271384577;
						if (num != 0)
						{
						}
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("雃ꏅꯇ蓉귋룍蓏뷑믓뫕뫗믙껛軝臟藡臣꟥诧黩藫臭黯뇱鯳飵请闹郻韽擿持瀃漅朇搉", a_))
						{
							num = (short)328007691;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2EC;
					case 2:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1274478609;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)1985216521;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						global::System.Windows.Data.CollectionView collectionView;
						collectionView.MoveCurrentToLast();
						num = (short)453312519;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						num = (short)1501036545;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInner consolidatedActionsInner;
						if (consolidatedActionsInner != null)
						{
							num = (short)1454047251;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)827129864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						num = (short)2070085645;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_269;
					case 8:
					{
						global::System.Windows.Data.CollectionView collectionView;
						if (collectionView.Count > 0)
						{
							num = (short)1337851910;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_342;
					}
					case 9:
						goto IL_294;
					case 10:
					{
						object myRecordsetDataSource2;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource2);
						global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInner consolidatedActionsInner = (global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInner)collectionView.CurrentItem;
						num = (short)1993998341;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource = this.RecNavToolbarPageActionConsolidation.MyRecordsetDataSource;
						num = (short)1038811157;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						goto IL_2EC;
					case 13:
					{
						global::System.Windows.Data.CollectionView collectionView;
						if (collectionView.IsCurrentAfterLast)
						{
							num = (short)1663303683;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						collectionView.MoveCurrentToFirst();
						goto IL_1E5;
					}
					case 14:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("雃ꏅꯇ蓉귋룍蓏뷑믓뫕뫗믙껛鯝食鋡藣裥賧迩黫꿭鏯蛱鷳駵雷맹鏻都珿洁栃漅氇欉砋服缏簑圓礕瘗椙猛爝䤟䘡䔣別䴧丩洫䴭䐯嬱嬳堵䬷", a_))
						{
							num = (short)955252752;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 15:
						goto IL_1A4;
					case 16:
						num = (short)857145346;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource2 = this.RecNavToolbarExpanderActionConsolidationConsolidatedActions.MyRecordsetDataSource;
						num = (short)339935254;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						goto IL_1FD;
					case 19:
					{
						global::System.Windows.Data.CollectionView collectionView;
						global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInner consolidatedActionsInner;
						collectionView.MoveCurrentTo(consolidatedActionsInner);
						num = (short)1343488015;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						switch (0)
						{
						case 0:
							goto IL_11C;
						}
						continue;
					case 21:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource;
						if (myRecordsetDataSource != null)
						{
							num = (short)815464448;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2EC;
					}
					case 22:
					{
						object myRecordsetDataSource2;
						if (myRecordsetDataSource2 != null)
						{
							num = (short)210173962;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					}
					IL_11C:
					if (A_0 is global::AcpUI.AcpRecNavToolbar)
					{
						num = (short)1865940996;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_2EC:
					num = (short)581763086;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E5:
					num = (short)1835026;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1A4:
				IL_1FD:
				IL_269:
				goto IL_342;
				IL_294:
				return;
				IL_342:
				((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
				return;
			}
			}
		}

		// Token: 0x06008FE9 RID: 36841 RVA: 0x0087A954 File Offset: 0x00878B54
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1806974219;
			short num2 = num;
			num = (short)410860811;
			switch (num2 == num)
			{
			}
			num = (short)1694433280;
			short num3 = num;
			num = (short)591921153;
			if (num != 0)
			{
			}
			num = (short)1967128576;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x06008FEA RID: 36842 RVA: 0x0087AA08 File Offset: 0x00878C08
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)106697162;
			short num2 = num;
			num = (short)449515978;
			switch (num2 == num)
			{
			}
			num = (short)516161536;
			short num3 = num;
			num = (short)573243392;
			if (num != 0)
			{
			}
			num = (short)1464205313;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06008FEB RID: 36843 RVA: 0x0087AAB8 File Offset: 0x00878CB8
		internal void OnExpanderActionConsolidationConsolidatedActionsClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInner item;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderActionConsolidationConsolidatedActions.SyncDataSources();
					goto IL_C7;
				case 1:
					if (myRecordsetDataSource != null)
					{
						num2 = (short)1318060033;
						if (num2 != 0)
						{
						}
						num2 = (short)284819456;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_152;
				case 2:
				{
					num2 = (short)2133987068;
					short num3 = num2;
					num2 = (short)1659965180;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C7;
					default:
						goto IL_13B;
					}
					break;
				}
				}
				goto IL_1C;
				IL_C7:
				num2 = (short)665976832;
				short num4 = num2;
				num2 = (short)845021186;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_13B:
			num2 = (short)1958346752;
			if (num2 != 0)
			{
			}
			IL_152:
			this.RecNavToolbarExpanderActionConsolidationConsolidatedActions.TableMode = false;
			return;
			IL_1C:
			item = (global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderActionConsolidationConsolidatedActions.MyRecordsetDataSource;
			num2 = (short)1354039297;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06008FEC RID: 36844 RVA: 0x0087AC24 File Offset: 0x00878E24
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 10;
			while (this.b)
			{
				short num = (short)616039972;
				short num2 = num;
				num = (short)1248790052;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1037238273;
					if (num != 0)
					{
					}
					num = (short)495321088;
					short num3 = num;
					num = (short)813170688;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
			this.b = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("賌ꏎ뷐闒냔뛖귘껚꿜뫞鋠\ud8e2蛤裦蓨鯪苬臮铰鷲致\ud8f6诸髺駼雾渀☂㜄㜆氈礊樌怎缐簒研縖稘栚㠜ⴞᄠ䀢䨤䤦伨䈪䨬娮䌰刲䄴帶嘸唺ሼ帾≀㝂ⱄ⡆❈湊罌罎㉐㱒㭔⑖㙘㝚㑜㭞`ᝢ౤ࡦݨ䑪౬౮հᩲᩴ᥶᩸ᑺ፼౾ﾊﾐ붒", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06008FED RID: 36845 RVA: 0x0087AD04 File Offset: 0x00878F04
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1422721026;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)192151553;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_902;
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
					goto IL_3B7;
				case 2:
					goto IL_952;
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
					goto IL_FF0;
				case 13:
					goto IL_5EC;
				case 14:
					goto IL_507;
				case 15:
					goto IL_85D;
				case 16:
					goto IL_EC4;
				case 17:
					goto IL_F98;
				case 18:
					goto IL_B7D;
				case 19:
					goto IL_C8C;
				case 20:
					goto IL_BF9;
				case 21:
					goto IL_684;
				case 22:
					goto IL_E6F;
				case 23:
					goto IL_C99;
				case 24:
					goto IL_843;
				case 25:
					goto IL_F02;
				case 26:
					goto IL_ED1;
				case 27:
					goto IL_CA6;
				case 28:
					goto IL_850;
				case 29:
					goto IL_86A;
				case 30:
					goto IL_34F;
				case 31:
					goto IL_776;
				case 32:
					goto IL_62A;
				case 33:
					goto IL_5C8;
				case 34:
					goto IL_3F5;
				case 35:
					goto IL_9E5;
				case 36:
					goto IL_6A8;
				case 37:
					goto IL_E4B;
				case 38:
					goto IL_72B;
				case 39:
					goto IL_EF5;
				case 40:
					goto IL_3E8;
				case 41:
					goto IL_F33;
				case 42:
					goto IL_D39;
				case 43:
					goto IL_307;
				case 44:
					goto IL_45D;
				case 45:
					goto IL_836;
				case 46:
					goto IL_402;
				case 47:
					goto IL_383;
				case 48:
					goto IL_6C2;
				case 49:
					goto IL_606;
				case 50:
					goto IL_4D6;
				case 51:
					goto IL_4C9;
				case 52:
					goto IL_DA8;
				case 53:
					goto IL_B8A;
				case 54:
					goto IL_DF3;
				case 55:
					goto IL_4A5;
				case 56:
					goto IL_A9F;
				case 57:
					goto IL_FD6;
				case 58:
					goto IL_A30;
				case 59:
					goto IL_450;
				case 60:
					goto IL_D9B;
				case 61:
					goto IL_C41;
				case 62:
					goto IL_538;
				case 63:
					goto IL_E00;
				case 64:
					goto IL_8C2;
				case 65:
					goto IL_75C;
				case 66:
					goto IL_9B4;
				case 67:
					goto IL_580;
				case 68:
					goto IL_877;
				case 69:
					goto IL_AC3;
				case 70:
					goto IL_C65;
				case 71:
					goto IL_436;
				case 72:
					goto IL_429;
				case 73:
					goto IL_7AA;
				case 74:
					goto IL_F0F;
				case 75:
					goto IL_BD5;
				case 76:
					goto IL_79D;
				case 77:
					goto IL_7EB;
				case 78:
					goto IL_7B7;
				case 79:
					goto IL_3AA;
				case 80:
					goto IL_990;
				case 81:
					goto IL_E7C;
				case 82:
					goto IL_C7F;
				case 83:
					goto IL_7DE;
				case 84:
					goto IL_52B;
				case 85:
					goto IL_983;
				case 86:
					goto IL_D46;
				case 87:
					goto IL_9C1;
				case 88:
					goto IL_E3E;
				case 89:
					goto IL_BC8;
				case 90:
					goto IL_4FA;
				case 91:
					goto IL_D1F;
				case 92:
					goto IL_8CF;
				case 93:
					goto IL_F5A;
				case 94:
					goto IL_A6E;
				case 95:
					goto IL_7C4;
				case 96:
					goto IL_769;
				case 97:
					goto IL_F8B;
				case 98:
					goto IL_829;
				case 99:
					goto IL_2FA;
				case 100:
					goto IL_790;
				case 101:
					goto IL_976;
				case 102:
					goto IL_376;
				case 103:
					goto IL_FE3;
				case 104:
					goto IL_74F;
				case 105:
					goto IL_7F8;
				case 106:
					goto IL_6B5;
				case 107:
					goto IL_F67;
				case 108:
					goto IL_B32;
				case 109:
					goto IL_CFB;
				case 110:
					goto IL_ADD;
				case 111:
					goto IL_443;
				case 112:
					goto IL_8B5;
				case 113:
					goto IL_9FF;
				case 114:
					goto IL_A23;
				case 115:
					goto IL_B97;
				case 116:
					goto IL_8A8;
				case 117:
					goto IL_35C;
				case 118:
					goto IL_89B;
				case 119:
					goto IL_B3F;
				case 120:
					goto IL_2ED;
				case 121:
					goto IL_B0E;
				case 122:
					goto IL_CCA;
				case 123:
					goto IL_A61;
				case 124:
					goto IL_AD0;
				case 125:
					goto IL_C1D;
				case 126:
					goto IL_6DC;
				case 127:
					goto IL_55C;
				case 128:
					goto IL_783;
				case 129:
					goto IL_8DC;
				case 130:
					goto IL_B63;
				case 131:
					goto IL_A7B;
				case 132:
					goto IL_677;
				case 133:
					goto IL_805;
				case 134:
					goto IL_41C;
				case 135:
					goto IL_DB5;
				case 136:
					goto IL_E31;
				case 137:
					goto IL_32B;
				case 138:
					goto IL_FC9;
				case 139:
					goto IL_481;
				case 140:
					goto IL_6CF;
				case 141:
					goto IL_9F2;
				case 142:
					goto IL_6E9;
				case 143:
					goto IL_A3D;
				case 144:
					goto IL_F40;
				case 145:
					goto IL_5A4;
				case 146:
					goto IL_390;
				case 147:
					goto IL_6F6;
				case 148:
					goto IL_F4D;
				case 149:
					goto IL_CD7;
				case 150:
					goto IL_40F;
				case 151:
					goto IL_AEA;
				case 152:
					goto IL_369;
				case 153:
					goto IL_5F9;
				case 154:
					goto IL_7D1;
				case 155:
					goto IL_E0D;
				case 156:
					goto IL_B70;
				case 157:
					goto IL_D6A;
				case 158:
					goto IL_DE6;
				case 159:
					goto IL_D2C;
				case 160:
					goto IL_BBB;
				case 161:
					goto IL_DC2;
				case 162:
					goto IL_39D;
				case 163:
					goto IL_EA0;
				case 164:
					goto IL_D8E;
				case 165:
					goto IL_FBC;
				case 166:
					goto IL_C72;
				default:
					num = (short)494993408;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_2ED:
			this.CVBtnRadioErgoConfigACGeneralZone_A36592 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2FA:
			this.RadioErgoConfigACAlertAudioFile_A42875_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_307:
			this.LblRadioErgoConfigACRelayPatternErrStrategy_A36583 = (global::AcpUI.AcpLabel)target;
			this.LblRadioErgoConfigACRelayPatternErrStrategy_A36583.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_32B:
			this.RadioErgoConfigACAlertInterval_A42877 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadioErgoConfigACAlertInterval_A42877.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_34F:
			this.RadioErgoConfigACGeneralActionAllowed_A36579Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_35C:
			this.CpyBtnRadioErgoConfigACGeneralIndex_A36591 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_369:
			this.RTDBtnRadioErgoConfigACGeneralTxPowerChange__42916 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_376:
			this.RadioErgoConfigACGeneralTxPowerChange__42916_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_383:
			this.RadioErgoConfigACRelayPatternErrStrategy_A36583Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_390:
			this.RTDBtnRadioErgoConfigACGeneralTEXTMESSAGE_42913 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_39D:
			this.CVBtnRadioErgoConfigACGeneralErrStrategy_A36594 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3AA:
			this.CVBtnRadioErgoConfigACGpsReportErrStrategy_A36588 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3B7:
			((global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.PageActionConsolidation)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.PageActionConsolidation)target).Unloaded += this.OnUnloaded;
			return;
			IL_3E8:
			this.CpyBtnRadioErgoConfigACRelayPattern_A36582 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3F5:
			this.CpyBtnRadioErgoConfigACName_A36581 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_402:
			this.CpyBtnRadioErgoConfigACRelayPatternErrStrategy_A36583 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_40F:
			this.CVBtnRadioErgoConfigACGeneralTxPowerChange__42916 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_41C:
			this.RTDBtnRadioErgoConfigACAlertAudioFile_A42875 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_429:
			this.GrpBoxExpanderActionConsolidationGeneralPseudo1 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_436:
			this.RadioErgoConfigAC3rdPartyNotificationErrorStategy_A41516Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_443:
			this.CpyBtnRadioErgoConfigACActionID_A36590 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_450:
			this.RadioErgoConfigACSirenTypeErrStrategy_A36585Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_45D:
			this.RadioErgoConfigACRelayPatternErrStrategy_A36583 = (global::AcpUI.AcpComboBox)target;
			this.RadioErgoConfigACRelayPatternErrStrategy_A36583.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_481:
			this.LblRadioErgoConfigACAlertInterval_A42877 = (global::AcpUI.AcpLabel)target;
			this.LblRadioErgoConfigACAlertInterval_A42877.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4A5:
			this.LblRadioErgoConfigACSirenTypeErrStrategy_A36585 = (global::AcpUI.AcpLabel)target;
			this.LblRadioErgoConfigACSirenTypeErrStrategy_A36585.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4C9:
			this.RTDBtnRadioErgoConfigACSirenType_A36584 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4D6:
			this.RadioErgoConfigACSirenType_A36584 = (global::AcpUI.AcpComboBox)target;
			this.RadioErgoConfigACSirenType_A36584.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4FA:
			this.RadioErgoConfigACAlertVisualResponse_A42878Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_507:
			this.HLinkGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkGeneral.Click += this.HLinkClick;
			return;
			IL_52B:
			this.RadioErgoConfigACGpsReportErrStrategy_A36588Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_538:
			this.RadioErgoConfigAC3rdPartyNotification_A41510 = (global::AcpUI.AcpComboBox)target;
			this.RadioErgoConfigAC3rdPartyNotification_A41510.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_55C:
			this.LblRadioErgoConfigACGeneralChannel_A36593 = (global::AcpUI.AcpLabel)target;
			this.LblRadioErgoConfigACGeneralChannel_A36593.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_580:
			this.LblRadioErgoConfigAC3rdPartyNotificationErrorStategy_A41516 = (global::AcpUI.AcpLabel)target;
			this.LblRadioErgoConfigAC3rdPartyNotificationErrorStategy_A41516.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5A4:
			this.LblRadioErgoConfigACGeneralTEXTMESSAGE_42913 = (global::AcpUI.AcpLabel)target;
			this.LblRadioErgoConfigACGeneralTEXTMESSAGE_42913.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5C8:
			this.RadioErgoConfigACName_A36581 = (global::AcpUI.AcpTextBox)target;
			this.RadioErgoConfigACName_A36581.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5EC:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_5F9:
			this.CpyBtnRadioErgoConfigACGeneralTxPowerChange__42916 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_606:
			this.LblRadioErgoConfigACSirenType_A36584 = (global::AcpUI.AcpLabel)target;
			this.LblRadioErgoConfigACSirenType_A36584.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_62A:
			num = (short)323420161;
			if (num != 0)
			{
			}
			this.LblRadioErgoConfigACName_A36581 = (global::AcpUI.AcpLabel)target;
			this.LblRadioErgoConfigACName_A36581.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_677:
			this.CVBtnRadioErgoConfigACAlertAudioFile_A42875 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_684:
			this.RadioErgoConfigACActionType_A42871 = (global::AcpUI.AcpComboBox)target;
			this.RadioErgoConfigACActionType_A42871.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_6A8:
			this.CVBtnRadioErgoConfigACRelayPattern_A36582 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6B5:
			this.gridExpanderActionConsolidationConsolidatedActionsSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_6C2:
			this.CVBtnRadioErgoConfigACSirenType_A36584 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6CF:
			this.RTDBtnRadioErgoConfigACAlertInterval_A42877 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_6DC:
			this.CVBtnRadioErgoConfigACGeneralChannel_A36593 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6E9:
			this.RadioErgoConfigACAlertInterval_A42877Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_6F6:
			num = (short)1763508224;
			short num3 = num;
			this.CpyBtnRadioErgoConfigACGeneralTEXTMESSAGE_42913 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_72B:
			this.RadioErgoConfigACRelayPattern_A36582 = (global::AcpUI.AcpComboBox)target;
			this.RadioErgoConfigACRelayPattern_A36582.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_74F:
			this.RadioErgoConfigACGeneralErrStrategy_A36594_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_75C:
			this.RadioErgoConfigAC3rdPartyNotification_A41510Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_769:
			this.RadioErgoConfigACGeneralIndex_A36591_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_776:
			this.CVBtnRadioErgoConfigACName_A36581 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_783:
			this.RTDBtnRadioErgoConfigACGeneralChannel_A36593 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_790:
			this.RadioErgoConfigACAlertInterval_A42877_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_79D:
			this.RTDBtnRadioErgoConfigACGpsReport_A36587 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_7AA:
			this.CVBtnRadioErgoConfigACGpsReport_A36587 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_7B7:
			this.RadioErgoConfigACGpsReport_A36587Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_7C4:
			this.RadioErgoConfigACActionID_A36590_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_7D1:
			this.RadioErgoConfigACGeneralTxPowerChange__42916Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_7DE:
			this.CpyBtnRadioErgoConfigACGpsReportErrStrategy_A36588 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_7EB:
			this.CpyBtnRadioErgoConfigACGpsReport_A36587 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_7F8:
			this.ExpanderActionConsolidationConsolidatedActionsSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_805:
			this.LblRadioErgoConfigACAlertAudioFile_A42875 = (global::AcpUI.AcpLabel)target;
			this.LblRadioErgoConfigACAlertAudioFile_A42875.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_829:
			this.RadioErgoConfigACGeneralChannel_A36593_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_836:
			this.RTDBtnRadioErgoConfigACRelayPatternErrStrategy_A36583 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_843:
			this.RadioErgoConfigACActionType_A42871Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_850:
			this.RTDBtnRadioErgoConfigACGeneralActionAllowed_A36579 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_85D:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_86A:
			this.CpyBtnRadioErgoConfigACGeneralActionAllowed_A36579 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_877:
			this.RadioErgoConfigAC3rdPartyNotificationErrorStategy_A41516 = (global::AcpUI.AcpComboBox)target;
			this.RadioErgoConfigAC3rdPartyNotificationErrorStategy_A41516.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_89B:
			this.RadioErgoConfigACGeneralIndex_A36591Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_8A8:
			this.RTDBtnRadioErgoConfigACGeneralIndex_A36591 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_8B5:
			this.RadioErgoConfigACActionID_A36590Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_8C2:
			this.CpyBtnRadioErgoConfigAC3rdPartyNotification_A41510 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_8CF:
			this.ExpanderActionConsolidationConsolidatedActionsGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_8DC:
			this.CpyBtnRadioErgoConfigACGeneralChannel_A36593 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_902:
			num = (short)83348051;
			short num4 = num;
			num = (short)2096155219;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_DC2:
				this.RadioErgoConfigACGeneralErrStrategy_A36594 = (global::AcpUI.AcpComboBox)target;
				this.RadioErgoConfigACGeneralErrStrategy_A36594.GotFocus += this.OnFieldNameDoubleClick;
				return;
			default:
				num = (short)1371668480;
				if (num != 0)
				{
				}
				goto IL_FF0;
			}
			IL_952:
			this.RecNavToolbarPageActionConsolidation = (global::AcpUI.AcpParentRecNavToolbar)target;
			this.RecNavToolbarPageActionConsolidation.ModeClick += this.OnModeClick;
			return;
			IL_976:
			this.RadioErgoConfigACGeneralTEXTMESSAGE_42913_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_983:
			this.CVBtnRadioErgoConfigACAlertVisualResponse_A42878 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_990:
			this.LblRadioErgoConfigACGpsReportErrStrategy_A36588 = (global::AcpUI.AcpLabel)target;
			this.LblRadioErgoConfigACGpsReportErrStrategy_A36588.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_9B4:
			this.CVBtnRadioErgoConfigAC3rdPartyNotificationErrorStategy_A41516 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_9C1:
			this.RadioErgoConfigACAlertVisualResponse_A42878 = (global::AcpUI.AcpComboBox)target;
			this.RadioErgoConfigACAlertVisualResponse_A42878.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_9E5:
			this.RadioErgoConfigACName_A36581Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_9F2:
			this.CpyBtnRadioErgoConfigACAlertInterval_A42877 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9FF:
			this.RadioErgoConfigACGeneralIndex_A36591 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadioErgoConfigACGeneralIndex_A36591.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_A23:
			this.CVBtnRadioErgoConfigACGeneralIndex_A36591 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A30:
			this.CpyBtnRadioErgoConfigACSirenTypeErrStrategy_A36585 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A3D:
			this.RadioErgoConfigACGeneralTEXTMESSAGE_42913 = (global::AcpUI.AcpTextBox)target;
			this.RadioErgoConfigACGeneralTEXTMESSAGE_42913.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_A61:
			this.CpyBtnRadioErgoConfigACGeneralZone_A36592 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A6E:
			this.ExpanderActionConsolidationConsolidatedActions = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_A7B:
			this.RadioErgoConfigACAlertAudioFile_A42875 = (global::AcpUI.AcpComboBox)target;
			this.RadioErgoConfigACAlertAudioFile_A42875.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_A9F:
			this.RadioErgoConfigACSirenTypeErrStrategy_A36585 = (global::AcpUI.AcpComboBox)target;
			this.RadioErgoConfigACSirenTypeErrStrategy_A36585.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_AC3:
			this.RTDBtnRadioErgoConfigAC3rdPartyNotificationErrorStategy_A41516 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_AD0:
			this.RadioErgoConfigACGeneralZone_A36592Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_ADD:
			this.RTDBtnRadioErgoConfigACActionID_A36590 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_AEA:
			this.LblRadioErgoConfigACGeneralTxPowerChange__42916 = (global::AcpUI.AcpLabel)target;
			this.LblRadioErgoConfigACGeneralTxPowerChange__42916.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_B0E:
			this.LblRadioErgoConfigACGeneralZone_A36592 = (global::AcpUI.AcpLabel)target;
			this.LblRadioErgoConfigACGeneralZone_A36592.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_B32:
			this.CVBtnRadioErgoConfigACActionID_A36590 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B3F:
			this.RadioErgoConfigACGeneralZone_A36592 = (global::AcpUI.AcpComboBox)target;
			this.RadioErgoConfigACGeneralZone_A36592.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B63:
			this.RadioErgoConfigACGeneralChannel_A36593Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_B70:
			this.CVBtnRadioErgoConfigACGeneralMuteSSA__42917 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B7D:
			this.GrpBoxExpanderActionConsolidationGeneralPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_B8A:
			this.RadioErgoConfigACSirenType_A36584Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_B97:
			this.LblRadioErgoConfigACGeneralIndex_A36591 = (global::AcpUI.AcpLabel)target;
			this.LblRadioErgoConfigACGeneralIndex_A36591.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_BBB:
			this.RadioErgoConfigACGeneralMuteSSA__42917Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_BC8:
			this.CpyBtnRadioErgoConfigACAlertVisualResponse_A42878 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_BD5:
			this.RadioErgoConfigACGpsReport_A36587 = (global::AcpUI.AcpCheckBox)target;
			this.RadioErgoConfigACGpsReport_A36587.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_BF9:
			this.LblRadioErgoConfigACActionType_A42871 = (global::AcpUI.AcpLabel)target;
			this.LblRadioErgoConfigACActionType_A42871.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_C1D:
			this.RadioErgoConfigACGeneralChannel_A36593 = (global::AcpUI.AcpComboBox)target;
			this.RadioErgoConfigACGeneralChannel_A36593.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_C41:
			this.LblRadioErgoConfigAC3rdPartyNotification_A41510 = (global::AcpUI.AcpLabel)target;
			this.LblRadioErgoConfigAC3rdPartyNotification_A41510.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_C65:
			this.CpyBtnRadioErgoConfigAC3rdPartyNotificationErrorStategy_A41516 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_C72:
			this.RadioErgoConfigACGeneralErrStrategy_A36594Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_C7F:
			this.RTDBtnRadioErgoConfigACGpsReportErrStrategy_A36588 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_C8C:
			this.CVBtnRadioErgoConfigACActionType_A42871 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_C99:
			this.CpyBtnRadioErgoConfigACActionType_A42871 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_CA6:
			this.RadioErgoConfigACGeneralActionAllowed_A36579 = (global::AcpUI.AcpLabel)target;
			this.RadioErgoConfigACGeneralActionAllowed_A36579.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_CCA:
			this.RTDBtnRadioErgoConfigACGeneralZone_A36592 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_CD7:
			this.RadioErgoConfigACGeneralTxPowerChange__42916 = (global::AcpUI.AcpComboBox)target;
			this.RadioErgoConfigACGeneralTxPowerChange__42916.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_CFB:
			this.LblRadioErgoConfigACActionID_A36590 = (global::AcpUI.AcpLabel)target;
			this.LblRadioErgoConfigACActionID_A36590.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_D1F:
			this.ExpanderActionConsolidationGeneralGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_D2C:
			this.CpyBtnRadioErgoConfigACGeneralMuteSSA__42917 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_D39:
			this.CVBtnRadioErgoConfigACRelayPatternErrStrategy_A36583 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_D46:
			this.LblRadioErgoConfigACAlertVisualResponse_A42878 = (global::AcpUI.AcpLabel)target;
			this.LblRadioErgoConfigACAlertVisualResponse_A42878.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_D6A:
			this.LblRadioErgoConfigACGeneralMuteSSA__42917 = (global::AcpUI.AcpLabel)target;
			this.LblRadioErgoConfigACGeneralMuteSSA__42917.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_D8E:
			this.RTDBtnRadioErgoConfigACGeneralErrStrategy_A36594 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_D9B:
			this.CVBtnRadioErgoConfigAC3rdPartyNotification_A41510 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_DA8:
			this.CpyBtnRadioErgoConfigACSirenType_A36584 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_DB5:
			this.CpyBtnRadioErgoConfigACAlertAudioFile_A42875 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_DE6:
			this.RTDBtnRadioErgoConfigACGeneralMuteSSA__42917 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_DF3:
			this.CVBtnRadioErgoConfigACSirenTypeErrStrategy_A36585 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_E00:
			this.RTDBtnRadioErgoConfigAC3rdPartyNotification_A41510 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_E0D:
			this.RadioErgoConfigACGeneralMuteSSA__42917 = (global::AcpUI.AcpCheckBox)target;
			this.RadioErgoConfigACGeneralMuteSSA__42917.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_E31:
			this.RadioErgoConfigACAlertAudioFile_A42875Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_E3E:
			this.RTDBtnRadioErgoConfigACAlertVisualResponse_A42878 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_E4B:
			this.LblRadioErgoConfigACRelayPattern_A36582 = (global::AcpUI.AcpLabel)target;
			this.LblRadioErgoConfigACRelayPattern_A36582.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_E6F:
			this.RTDBtnRadioErgoConfigACActionType_A42871 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_E7C:
			this.RadioErgoConfigACGpsReportErrStrategy_A36588 = (global::AcpUI.AcpComboBox)target;
			this.RadioErgoConfigACGpsReportErrStrategy_A36588.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_EA0:
			this.LblRadioErgoConfigACGeneralErrStrategy_A36594 = (global::AcpUI.AcpLabel)target;
			this.LblRadioErgoConfigACGeneralErrStrategy_A36594.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_EC4:
			this.ExpanderActionConsolidationGeneral = (global::AcpUI.AcpExpander)target;
			return;
			IL_ED1:
			this.LblRadioErgoConfigACGeneralActionAllowed_A36579 = (global::AcpUI.AcpLabel)target;
			this.LblRadioErgoConfigACGeneralActionAllowed_A36579.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_EF5:
			this.RTDBtnRadioErgoConfigACRelayPattern_A36582 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_F02:
			this.CVBtnRadioErgoConfigACGeneralActionAllowed_A36579 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_F0F:
			this.LblRadioErgoConfigACGpsReport_A36587 = (global::AcpUI.AcpLabel)target;
			this.LblRadioErgoConfigACGpsReport_A36587.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_F33:
			this.RadioErgoConfigACRelayPattern_A36582Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_F40:
			this.CVBtnRadioErgoConfigACGeneralTEXTMESSAGE_42913 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_F4D:
			this.RadioErgoConfigACGeneralTEXTMESSAGE_42913Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_F5A:
			this.ExpanderActionConsolidationConsolidatedActionsTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_F67:
			this.RadioErgoConfigACActionID_A36590 = (global::AcpUI.AcpComboBox)target;
			this.RadioErgoConfigACActionID_A36590.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_F8B:
			this.RadioErgoConfigACGeneralZone_A36592_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_F98:
			this.RecNavToolbarExpanderActionConsolidationConsolidatedActions = (global::AcpUI.AcpChildRecNavToolbar)target;
			this.RecNavToolbarExpanderActionConsolidationConsolidatedActions.ModeClick += this.OnModeClick;
			return;
			IL_FBC:
			this.CpyBtnRadioErgoConfigACGeneralErrStrategy_A36594 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_FC9:
			this.CVBtnRadioErgoConfigACAlertInterval_A42877 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_FD6:
			this.RTDBtnRadioErgoConfigACSirenTypeErrStrategy_A36585 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_FE3:
			this.RadioErgoConfigACGeneralMuteSSA__42917_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_FF0:
			this.b = true;
		}

		// Token: 0x06008FEE RID: 36846 RVA: 0x0087BD08 File Offset: 0x00879F08
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 3:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 4:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 5:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 6:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 7:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 8:
				break;
			case 9:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 10:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 11:
			{
				short num = (short)325447896;
				short num2 = num;
				num = (short)1714286808;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1699020801;
					if (num != 0)
					{
					}
					num = (short)1155596288;
					short num3 = num;
					num = (short)2080178176;
					if (num != 0)
					{
					}
					((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				}
				}
				break;
			}
			case 12:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			default:
				return;
			}
			((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x0400478F RID: 18319
		private bool a;

		// Token: 0x04004790 RID: 18320
		internal global::AcpUI.AcpParentRecNavToolbar RecNavToolbarPageActionConsolidation;

		// Token: 0x04004791 RID: 18321
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x04004792 RID: 18322
		internal global::System.Windows.Documents.Hyperlink HLinkGeneral;

		// Token: 0x04004793 RID: 18323
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x04004794 RID: 18324
		internal global::AcpUI.AcpExpander ExpanderActionConsolidationGeneral;

		// Token: 0x04004795 RID: 18325
		internal global::AcpUI.AcpChildRecNavToolbar RecNavToolbarExpanderActionConsolidationConsolidatedActions;

		// Token: 0x04004796 RID: 18326
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderActionConsolidationGeneralPseudo0;

		// Token: 0x04004797 RID: 18327
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadioErgoConfigACActionType_A42871;

		// Token: 0x04004798 RID: 18328
		internal global::AcpUI.AcpLabel LblRadioErgoConfigACActionType_A42871;

		// Token: 0x04004799 RID: 18329
		internal global::AcpUI.AcpComboBox RadioErgoConfigACActionType_A42871;

		// Token: 0x0400479A RID: 18330
		internal global::AcpUI.AcpRtdButton RTDBtnRadioErgoConfigACActionType_A42871;

		// Token: 0x0400479B RID: 18331
		internal global::AcpUI.AcpCopyButton CpyBtnRadioErgoConfigACActionType_A42871;

		// Token: 0x0400479C RID: 18332
		internal global::AcpUI.AcpLabel RadioErgoConfigACActionType_A42871Comp;

		// Token: 0x0400479D RID: 18333
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadioErgoConfigACGeneralActionAllowed_A36579;

		// Token: 0x0400479E RID: 18334
		internal global::AcpUI.AcpLabel LblRadioErgoConfigACGeneralActionAllowed_A36579;

		// Token: 0x0400479F RID: 18335
		internal global::AcpUI.AcpLabel RadioErgoConfigACGeneralActionAllowed_A36579;

		// Token: 0x040047A0 RID: 18336
		internal global::AcpUI.AcpRtdButton RTDBtnRadioErgoConfigACGeneralActionAllowed_A36579;

		// Token: 0x040047A1 RID: 18337
		internal global::AcpUI.AcpCopyButton CpyBtnRadioErgoConfigACGeneralActionAllowed_A36579;

		// Token: 0x040047A2 RID: 18338
		internal global::AcpUI.AcpLabel RadioErgoConfigACGeneralActionAllowed_A36579Comp;

		// Token: 0x040047A3 RID: 18339
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadioErgoConfigACName_A36581;

		// Token: 0x040047A4 RID: 18340
		internal global::AcpUI.AcpLabel LblRadioErgoConfigACName_A36581;

		// Token: 0x040047A5 RID: 18341
		internal global::AcpUI.AcpTextBox RadioErgoConfigACName_A36581;

		// Token: 0x040047A6 RID: 18342
		internal global::AcpUI.AcpCopyButton CpyBtnRadioErgoConfigACName_A36581;

		// Token: 0x040047A7 RID: 18343
		internal global::AcpUI.AcpLabel RadioErgoConfigACName_A36581Comp;

		// Token: 0x040047A8 RID: 18344
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadioErgoConfigACRelayPattern_A36582;

		// Token: 0x040047A9 RID: 18345
		internal global::AcpUI.AcpLabel LblRadioErgoConfigACRelayPattern_A36582;

		// Token: 0x040047AA RID: 18346
		internal global::AcpUI.AcpComboBox RadioErgoConfigACRelayPattern_A36582;

		// Token: 0x040047AB RID: 18347
		internal global::AcpUI.AcpRtdButton RTDBtnRadioErgoConfigACRelayPattern_A36582;

		// Token: 0x040047AC RID: 18348
		internal global::AcpUI.AcpCopyButton CpyBtnRadioErgoConfigACRelayPattern_A36582;

		// Token: 0x040047AD RID: 18349
		internal global::AcpUI.AcpLabel RadioErgoConfigACRelayPattern_A36582Comp;

		// Token: 0x040047AE RID: 18350
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadioErgoConfigACRelayPatternErrStrategy_A36583;

		// Token: 0x040047AF RID: 18351
		internal global::AcpUI.AcpLabel LblRadioErgoConfigACRelayPatternErrStrategy_A36583;

		// Token: 0x040047B0 RID: 18352
		internal global::AcpUI.AcpComboBox RadioErgoConfigACRelayPatternErrStrategy_A36583;

		// Token: 0x040047B1 RID: 18353
		internal global::AcpUI.AcpRtdButton RTDBtnRadioErgoConfigACRelayPatternErrStrategy_A36583;

		// Token: 0x040047B2 RID: 18354
		internal global::AcpUI.AcpCopyButton CpyBtnRadioErgoConfigACRelayPatternErrStrategy_A36583;

		// Token: 0x040047B3 RID: 18355
		internal global::AcpUI.AcpLabel RadioErgoConfigACRelayPatternErrStrategy_A36583Comp;

		// Token: 0x040047B4 RID: 18356
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadioErgoConfigACSirenType_A36584;

		// Token: 0x040047B5 RID: 18357
		internal global::AcpUI.AcpLabel LblRadioErgoConfigACSirenType_A36584;

		// Token: 0x040047B6 RID: 18358
		internal global::AcpUI.AcpComboBox RadioErgoConfigACSirenType_A36584;

		// Token: 0x040047B7 RID: 18359
		internal global::AcpUI.AcpRtdButton RTDBtnRadioErgoConfigACSirenType_A36584;

		// Token: 0x040047B8 RID: 18360
		internal global::AcpUI.AcpCopyButton CpyBtnRadioErgoConfigACSirenType_A36584;

		// Token: 0x040047B9 RID: 18361
		internal global::AcpUI.AcpLabel RadioErgoConfigACSirenType_A36584Comp;

		// Token: 0x040047BA RID: 18362
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadioErgoConfigACSirenTypeErrStrategy_A36585;

		// Token: 0x040047BB RID: 18363
		internal global::AcpUI.AcpLabel LblRadioErgoConfigACSirenTypeErrStrategy_A36585;

		// Token: 0x040047BC RID: 18364
		internal global::AcpUI.AcpComboBox RadioErgoConfigACSirenTypeErrStrategy_A36585;

		// Token: 0x040047BD RID: 18365
		internal global::AcpUI.AcpRtdButton RTDBtnRadioErgoConfigACSirenTypeErrStrategy_A36585;

		// Token: 0x040047BE RID: 18366
		internal global::AcpUI.AcpCopyButton CpyBtnRadioErgoConfigACSirenTypeErrStrategy_A36585;

		// Token: 0x040047BF RID: 18367
		internal global::AcpUI.AcpLabel RadioErgoConfigACSirenTypeErrStrategy_A36585Comp;

		// Token: 0x040047C0 RID: 18368
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadioErgoConfigAC3rdPartyNotification_A41510;

		// Token: 0x040047C1 RID: 18369
		internal global::AcpUI.AcpLabel LblRadioErgoConfigAC3rdPartyNotification_A41510;

		// Token: 0x040047C2 RID: 18370
		internal global::AcpUI.AcpComboBox RadioErgoConfigAC3rdPartyNotification_A41510;

		// Token: 0x040047C3 RID: 18371
		internal global::AcpUI.AcpRtdButton RTDBtnRadioErgoConfigAC3rdPartyNotification_A41510;

		// Token: 0x040047C4 RID: 18372
		internal global::AcpUI.AcpCopyButton CpyBtnRadioErgoConfigAC3rdPartyNotification_A41510;

		// Token: 0x040047C5 RID: 18373
		internal global::AcpUI.AcpLabel RadioErgoConfigAC3rdPartyNotification_A41510Comp;

		// Token: 0x040047C6 RID: 18374
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadioErgoConfigAC3rdPartyNotificationErrorStategy_A41516;

		// Token: 0x040047C7 RID: 18375
		internal global::AcpUI.AcpLabel LblRadioErgoConfigAC3rdPartyNotificationErrorStategy_A41516;

		// Token: 0x040047C8 RID: 18376
		internal global::AcpUI.AcpComboBox RadioErgoConfigAC3rdPartyNotificationErrorStategy_A41516;

		// Token: 0x040047C9 RID: 18377
		internal global::AcpUI.AcpRtdButton RTDBtnRadioErgoConfigAC3rdPartyNotificationErrorStategy_A41516;

		// Token: 0x040047CA RID: 18378
		internal global::AcpUI.AcpCopyButton CpyBtnRadioErgoConfigAC3rdPartyNotificationErrorStategy_A41516;

		// Token: 0x040047CB RID: 18379
		internal global::AcpUI.AcpLabel RadioErgoConfigAC3rdPartyNotificationErrorStategy_A41516Comp;

		// Token: 0x040047CC RID: 18380
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderActionConsolidationGeneralPseudo1;

		// Token: 0x040047CD RID: 18381
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadioErgoConfigACGpsReport_A36587;

		// Token: 0x040047CE RID: 18382
		internal global::AcpUI.AcpLabel LblRadioErgoConfigACGpsReport_A36587;

		// Token: 0x040047CF RID: 18383
		internal global::AcpUI.AcpCheckBox RadioErgoConfigACGpsReport_A36587;

		// Token: 0x040047D0 RID: 18384
		internal global::AcpUI.AcpRtdButton RTDBtnRadioErgoConfigACGpsReport_A36587;

		// Token: 0x040047D1 RID: 18385
		internal global::AcpUI.AcpCopyButton CpyBtnRadioErgoConfigACGpsReport_A36587;

		// Token: 0x040047D2 RID: 18386
		internal global::AcpUI.AcpCheckBox RadioErgoConfigACGpsReport_A36587Comp;

		// Token: 0x040047D3 RID: 18387
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadioErgoConfigACGpsReportErrStrategy_A36588;

		// Token: 0x040047D4 RID: 18388
		internal global::AcpUI.AcpLabel LblRadioErgoConfigACGpsReportErrStrategy_A36588;

		// Token: 0x040047D5 RID: 18389
		internal global::AcpUI.AcpComboBox RadioErgoConfigACGpsReportErrStrategy_A36588;

		// Token: 0x040047D6 RID: 18390
		internal global::AcpUI.AcpRtdButton RTDBtnRadioErgoConfigACGpsReportErrStrategy_A36588;

		// Token: 0x040047D7 RID: 18391
		internal global::AcpUI.AcpCopyButton CpyBtnRadioErgoConfigACGpsReportErrStrategy_A36588;

		// Token: 0x040047D8 RID: 18392
		internal global::AcpUI.AcpLabel RadioErgoConfigACGpsReportErrStrategy_A36588Comp;

		// Token: 0x040047D9 RID: 18393
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadioErgoConfigACAlertVisualResponse_A42878;

		// Token: 0x040047DA RID: 18394
		internal global::AcpUI.AcpLabel LblRadioErgoConfigACAlertVisualResponse_A42878;

		// Token: 0x040047DB RID: 18395
		internal global::AcpUI.AcpComboBox RadioErgoConfigACAlertVisualResponse_A42878;

		// Token: 0x040047DC RID: 18396
		internal global::AcpUI.AcpRtdButton RTDBtnRadioErgoConfigACAlertVisualResponse_A42878;

		// Token: 0x040047DD RID: 18397
		internal global::AcpUI.AcpCopyButton CpyBtnRadioErgoConfigACAlertVisualResponse_A42878;

		// Token: 0x040047DE RID: 18398
		internal global::AcpUI.AcpLabel RadioErgoConfigACAlertVisualResponse_A42878Comp;

		// Token: 0x040047DF RID: 18399
		internal global::System.Windows.Controls.Grid ExpanderActionConsolidationGeneralGrid;

		// Token: 0x040047E0 RID: 18400
		internal global::System.Windows.Controls.Grid ExpanderActionConsolidationConsolidatedActionsGrid;

		// Token: 0x040047E1 RID: 18401
		internal global::AcpUI.AcpGroupBox ExpanderActionConsolidationConsolidatedActionsTableView;

		// Token: 0x040047E2 RID: 18402
		internal global::AcpUI.AcpXamDataPresenter ExpanderActionConsolidationConsolidatedActions;

		// Token: 0x040047E3 RID: 18403
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadioErgoConfigACActionID_A36590_Col;

		// Token: 0x040047E4 RID: 18404
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadioErgoConfigACGeneralIndex_A36591_Col;

		// Token: 0x040047E5 RID: 18405
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadioErgoConfigACGeneralZone_A36592_Col;

		// Token: 0x040047E6 RID: 18406
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadioErgoConfigACGeneralChannel_A36593_Col;

		// Token: 0x040047E7 RID: 18407
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadioErgoConfigACAlertAudioFile_A42875_Col;

		// Token: 0x040047E8 RID: 18408
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadioErgoConfigACAlertInterval_A42877_Col;

		// Token: 0x040047E9 RID: 18409
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadioErgoConfigACGeneralTEXTMESSAGE_42913_Col;

		// Token: 0x040047EA RID: 18410
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadioErgoConfigACGeneralTxPowerChange__42916_Col;

		// Token: 0x040047EB RID: 18411
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadioErgoConfigACGeneralMuteSSA__42917_Col;

		// Token: 0x040047EC RID: 18412
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadioErgoConfigACGeneralErrStrategy_A36594_Col;

		// Token: 0x040047ED RID: 18413
		internal global::AcpUI.AcpGroupBox ExpanderActionConsolidationConsolidatedActionsSRecView;

		// Token: 0x040047EE RID: 18414
		internal global::System.Windows.Controls.Grid gridExpanderActionConsolidationConsolidatedActionsSRecView;

		// Token: 0x040047EF RID: 18415
		internal global::AcpUI.AcpComboBox RadioErgoConfigACActionID_A36590;

		// Token: 0x040047F0 RID: 18416
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadioErgoConfigACActionID_A36590;

		// Token: 0x040047F1 RID: 18417
		internal global::AcpUI.AcpLabel LblRadioErgoConfigACActionID_A36590;

		// Token: 0x040047F2 RID: 18418
		internal global::AcpUI.AcpRtdButton RTDBtnRadioErgoConfigACActionID_A36590;

		// Token: 0x040047F3 RID: 18419
		internal global::AcpUI.AcpCopyButton CpyBtnRadioErgoConfigACActionID_A36590;

		// Token: 0x040047F4 RID: 18420
		internal global::AcpUI.AcpLabel RadioErgoConfigACActionID_A36590Comp;

		// Token: 0x040047F5 RID: 18421
		internal global::AcpUI.AcpTextBoxSpinner RadioErgoConfigACGeneralIndex_A36591;

		// Token: 0x040047F6 RID: 18422
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadioErgoConfigACGeneralIndex_A36591;

		// Token: 0x040047F7 RID: 18423
		internal global::AcpUI.AcpLabel LblRadioErgoConfigACGeneralIndex_A36591;

		// Token: 0x040047F8 RID: 18424
		internal global::AcpUI.AcpRtdButton RTDBtnRadioErgoConfigACGeneralIndex_A36591;

		// Token: 0x040047F9 RID: 18425
		internal global::AcpUI.AcpCopyButton CpyBtnRadioErgoConfigACGeneralIndex_A36591;

		// Token: 0x040047FA RID: 18426
		internal global::AcpUI.AcpLabel RadioErgoConfigACGeneralIndex_A36591Comp;

		// Token: 0x040047FB RID: 18427
		internal global::AcpUI.AcpComboBox RadioErgoConfigACGeneralZone_A36592;

		// Token: 0x040047FC RID: 18428
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadioErgoConfigACGeneralZone_A36592;

		// Token: 0x040047FD RID: 18429
		internal global::AcpUI.AcpLabel LblRadioErgoConfigACGeneralZone_A36592;

		// Token: 0x040047FE RID: 18430
		internal global::AcpUI.AcpRtdButton RTDBtnRadioErgoConfigACGeneralZone_A36592;

		// Token: 0x040047FF RID: 18431
		internal global::AcpUI.AcpCopyButton CpyBtnRadioErgoConfigACGeneralZone_A36592;

		// Token: 0x04004800 RID: 18432
		internal global::AcpUI.AcpLabel RadioErgoConfigACGeneralZone_A36592Comp;

		// Token: 0x04004801 RID: 18433
		internal global::AcpUI.AcpComboBox RadioErgoConfigACGeneralChannel_A36593;

		// Token: 0x04004802 RID: 18434
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadioErgoConfigACGeneralChannel_A36593;

		// Token: 0x04004803 RID: 18435
		internal global::AcpUI.AcpLabel LblRadioErgoConfigACGeneralChannel_A36593;

		// Token: 0x04004804 RID: 18436
		internal global::AcpUI.AcpRtdButton RTDBtnRadioErgoConfigACGeneralChannel_A36593;

		// Token: 0x04004805 RID: 18437
		internal global::AcpUI.AcpCopyButton CpyBtnRadioErgoConfigACGeneralChannel_A36593;

		// Token: 0x04004806 RID: 18438
		internal global::AcpUI.AcpLabel RadioErgoConfigACGeneralChannel_A36593Comp;

		// Token: 0x04004807 RID: 18439
		internal global::AcpUI.AcpComboBox RadioErgoConfigACAlertAudioFile_A42875;

		// Token: 0x04004808 RID: 18440
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadioErgoConfigACAlertAudioFile_A42875;

		// Token: 0x04004809 RID: 18441
		internal global::AcpUI.AcpLabel LblRadioErgoConfigACAlertAudioFile_A42875;

		// Token: 0x0400480A RID: 18442
		internal global::AcpUI.AcpRtdButton RTDBtnRadioErgoConfigACAlertAudioFile_A42875;

		// Token: 0x0400480B RID: 18443
		internal global::AcpUI.AcpCopyButton CpyBtnRadioErgoConfigACAlertAudioFile_A42875;

		// Token: 0x0400480C RID: 18444
		internal global::AcpUI.AcpLabel RadioErgoConfigACAlertAudioFile_A42875Comp;

		// Token: 0x0400480D RID: 18445
		internal global::AcpUI.AcpTextBoxSpinner RadioErgoConfigACAlertInterval_A42877;

		// Token: 0x0400480E RID: 18446
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadioErgoConfigACAlertInterval_A42877;

		// Token: 0x0400480F RID: 18447
		internal global::AcpUI.AcpLabel LblRadioErgoConfigACAlertInterval_A42877;

		// Token: 0x04004810 RID: 18448
		internal global::AcpUI.AcpRtdButton RTDBtnRadioErgoConfigACAlertInterval_A42877;

		// Token: 0x04004811 RID: 18449
		internal global::AcpUI.AcpCopyButton CpyBtnRadioErgoConfigACAlertInterval_A42877;

		// Token: 0x04004812 RID: 18450
		internal global::AcpUI.AcpLabel RadioErgoConfigACAlertInterval_A42877Comp;

		// Token: 0x04004813 RID: 18451
		internal global::AcpUI.AcpTextBox RadioErgoConfigACGeneralTEXTMESSAGE_42913;

		// Token: 0x04004814 RID: 18452
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadioErgoConfigACGeneralTEXTMESSAGE_42913;

		// Token: 0x04004815 RID: 18453
		internal global::AcpUI.AcpLabel LblRadioErgoConfigACGeneralTEXTMESSAGE_42913;

		// Token: 0x04004816 RID: 18454
		internal global::AcpUI.AcpRtdButton RTDBtnRadioErgoConfigACGeneralTEXTMESSAGE_42913;

		// Token: 0x04004817 RID: 18455
		internal global::AcpUI.AcpCopyButton CpyBtnRadioErgoConfigACGeneralTEXTMESSAGE_42913;

		// Token: 0x04004818 RID: 18456
		internal global::AcpUI.AcpLabel RadioErgoConfigACGeneralTEXTMESSAGE_42913Comp;

		// Token: 0x04004819 RID: 18457
		internal global::AcpUI.AcpComboBox RadioErgoConfigACGeneralTxPowerChange__42916;

		// Token: 0x0400481A RID: 18458
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadioErgoConfigACGeneralTxPowerChange__42916;

		// Token: 0x0400481B RID: 18459
		internal global::AcpUI.AcpLabel LblRadioErgoConfigACGeneralTxPowerChange__42916;

		// Token: 0x0400481C RID: 18460
		internal global::AcpUI.AcpRtdButton RTDBtnRadioErgoConfigACGeneralTxPowerChange__42916;

		// Token: 0x0400481D RID: 18461
		internal global::AcpUI.AcpCopyButton CpyBtnRadioErgoConfigACGeneralTxPowerChange__42916;

		// Token: 0x0400481E RID: 18462
		internal global::AcpUI.AcpLabel RadioErgoConfigACGeneralTxPowerChange__42916Comp;

		// Token: 0x0400481F RID: 18463
		internal global::AcpUI.AcpCheckBox RadioErgoConfigACGeneralMuteSSA__42917;

		// Token: 0x04004820 RID: 18464
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadioErgoConfigACGeneralMuteSSA__42917;

		// Token: 0x04004821 RID: 18465
		internal global::AcpUI.AcpLabel LblRadioErgoConfigACGeneralMuteSSA__42917;

		// Token: 0x04004822 RID: 18466
		internal global::AcpUI.AcpRtdButton RTDBtnRadioErgoConfigACGeneralMuteSSA__42917;

		// Token: 0x04004823 RID: 18467
		internal global::AcpUI.AcpCopyButton CpyBtnRadioErgoConfigACGeneralMuteSSA__42917;

		// Token: 0x04004824 RID: 18468
		internal global::AcpUI.AcpCheckBox RadioErgoConfigACGeneralMuteSSA__42917Comp;

		// Token: 0x04004825 RID: 18469
		internal global::AcpUI.AcpComboBox RadioErgoConfigACGeneralErrStrategy_A36594;

		// Token: 0x04004826 RID: 18470
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadioErgoConfigACGeneralErrStrategy_A36594;

		// Token: 0x04004827 RID: 18471
		internal global::AcpUI.AcpLabel LblRadioErgoConfigACGeneralErrStrategy_A36594;

		// Token: 0x04004828 RID: 18472
		internal global::AcpUI.AcpRtdButton RTDBtnRadioErgoConfigACGeneralErrStrategy_A36594;

		// Token: 0x04004829 RID: 18473
		internal global::AcpUI.AcpCopyButton CpyBtnRadioErgoConfigACGeneralErrStrategy_A36594;

		// Token: 0x0400482A RID: 18474
		internal global::AcpUI.AcpLabel RadioErgoConfigACGeneralErrStrategy_A36594Comp;

		// Token: 0x0400482B RID: 18475
		private bool b;
	}
}
