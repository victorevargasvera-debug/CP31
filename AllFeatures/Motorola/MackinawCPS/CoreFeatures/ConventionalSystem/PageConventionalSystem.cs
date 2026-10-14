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

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalSystem
{
	// Token: 0x02000558 RID: 1368
	public class PageConventionalSystem : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x0600B73F RID: 46911 RVA: 0x00AA0800 File Offset: 0x00A9EA00
		public PageConventionalSystem()
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

		// Token: 0x0600B740 RID: 46912 RVA: 0x00AA0838 File Offset: 0x00A9EA38
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)544210944;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1496645637;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::AcpUI.AcpExpander acpExpander;
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						goto IL_82;
					case 1:
						try
						{
							num = (short)64356357;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_314;
								case 1:
									num = (short)335609856;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									if (acpExpander != null)
									{
										num = (short)1401094148;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 4:
									base.Expanders.Add(acpExpander);
									num = (short)1592524803;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_208;
									}
									continue;
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)834666497;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
									num = (short)1429309210;
									short num3 = num;
									num = (short)925468442;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_314;
									default:
										num = (short)1416953856;
										if (num != 0)
										{
										}
										num = (short)239730690;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_20A:
								num = (short)1402732550;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_208:
								goto IL_20A;
							}
							IL_314:
							goto IL_135;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_336;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_323:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)913113089;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_38B;
								case 2:
									if (disposable != null)
									{
										num = (short)913047552;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_38D;
								}
								goto IL_336;
							}
							IL_38B:
							IL_38D:
							goto EndFinally_8;
							IL_336:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1379008514;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_323;
							EndFinally_8:;
						}
						goto IL_38E;
						IL_135:
						base.OnLoaded(sender, e);
						this.a = true;
						num = (short)650182660;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						object obj;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderConventionalSystemIndividualIDTones.MyDataPresenter = this.ExpanderConventionalSystemIndividualIDTones;
						num = (short)2019229696;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						object obj;
						if (obj != null)
						{
							num = (short)2046689282;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_82;
					}
					case 4:
						goto IL_15D;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_5F;
						}
						continue;
					case 6:
					{
						this.RecNavToolbarPageConventionalSystem.ChildToolbars.Add(this.RecNavToolbarExpanderConventionalSystemIndividualIDTones);
						object obj = null;
						obj = this.RecNavToolbarExpanderConventionalSystemIndividualIDTones.MyRecordsetDataSource;
						num = (short)224133121;
						if (num != 0)
						{
						}
						num = (short)1970405379;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_5F:
					if (!this.a)
					{
						num = (short)411041798;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_38E;
					IL_82:
					acpExpander = null;
					enumerator = this.MyStackPanel.Children.GetEnumerator();
					num = (short)1296433153;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_15D:
				num = (short)563347456;
				short num4 = num;
				IL_38E:
				this.MyStackPanel.Children[0].Focus();
				return;
			}
			}
		}

		// Token: 0x0600B741 RID: 46913 RVA: 0x00AA0C08 File Offset: 0x00A9EE08
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
					num2 = (short)869531649;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return;
				case 2:
				{
					if (!this.a)
					{
						return;
					}
					num2 = (short)2057633793;
					if (num2 != 0)
					{
					}
					num2 = (short)1892580570;
					short num3 = num2;
					num2 = (short)1675656410;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num2 = (short)952631296;
						if (num2 != 0)
						{
						}
						num2 = (short)575864832;
						short num4 = num2;
						num2 = (short)296550400;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			this.RecNavToolbarPageConventionalSystem.DataContext = null;
			this.RecNavToolbarExpanderConventionalSystemIndividualIDTones.DataContext = null;
			this.RecNavToolbarPageConventionalSystem.MyDataPresenter = null;
			this.RecNavToolbarExpanderConventionalSystemIndividualIDTones.MyDataPresenter = null;
			num2 = (short)11010050;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600B742 RID: 46914 RVA: 0x00AA0D5C File Offset: 0x00A9EF5C
		public override void SetDataContext()
		{
			short num = (short)1212940295;
			int num2 = (int)((global::System.IntPtr)num);
			object feature;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)340983809;
					if (num != 0)
					{
					}
					num = (short)1362904567;
					short num3 = num;
					num = (short)293553655;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_96;
					default:
						num = (short)1274871808;
						if (num != 0)
						{
						}
						feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2053);
						num = (short)233570310;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					goto IL_80;
				case 2:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)498466816;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageConventionalSystem).MySecondaryRecordsetDataSource = null;
					num = (short)1527119877;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_80;
				case 4:
					goto IL_235;
				case 5:
					goto IL_19B;
				case 6:
					if (feature != null)
					{
						num = (short)1336999940;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_4A;
					}
					continue;
				case 8:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2053);
					num = (short)2080440321;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_4A:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)485294088;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2053);
				num = (short)1922891779;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_96:
				num = (short)1682702338;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_80:
				this.RecNavToolbarPageConventionalSystem.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				goto IL_96;
			}
			IL_19B:
			num = (short)456065024;
			short num4 = num;
			return;
			IL_235:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageConventionalSystem).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
		}

		// Token: 0x0600B743 RID: 46915 RVA: 0x00AA0FA4 File Offset: 0x00A9F1A4
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 4;
			short num = (short)54919168;
			switch (num)
			{
			default:
			{
				num = (short)1080033280;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Windows.Data.CollectionView collectionView;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_AA;
						}
						continue;
					case 1:
						num = (short)619053077;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_15A;
					case 3:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource;
						base.NavigationService.Navigate(new global::System.Uri(myRecordsetDataSource.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
						num = (short)308084756;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						object myRecordsetDataSource2;
						if (myRecordsetDataSource2 != null)
						{
							num = (short)953024518;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 5:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource2 = this.RecNavToolbarExpanderConventionalSystemIndividualIDTones.MyRecordsetDataSource;
						num = (short)1938685956;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						object myRecordsetDataSource2;
						collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource2);
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInner individualIDTonesInner = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInner)collectionView.CurrentItem;
						num = (short)1664614412;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						num = (short)1939406858;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_1B4;
					case 9:
						goto IL_202;
					case 10:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("韄ꋆ꫈藊곌많藐볒뫔믖믘뫚꿜连胠蓢胤ꓦ蛨藪鯬諮鿰蟲鳴飶韸髺釼곾砀瀂焄戆搈", a_))
						{
							num = (short)1994129419;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F1;
					case 11:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource = this.RecNavToolbarPageConventionalSystem.MyRecordsetDataSource;
						num = (short)1192165395;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInner individualIDTonesInner;
						if (individualIDTonesInner == null)
						{
							num = (short)461438992;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1933233393;
						short num3 = num;
						num = (short)367250673;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_202;
						default:
							num = (short)1538064384;
							if (num != 0)
							{
							}
							num = (short)753926166;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 13:
						goto IL_24C;
					case 14:
						num = (short)129368081;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						num = (short)1331298304;
						short num4 = num;
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("韄ꋆ꫈藊곌많藐볒뫔믖믘뫚꿜髞駠鏢蓤触跨軪鿬곮黰鷲菴鋶韸迺铼郾漀戂椄吆瀈砊礌樎簐娒笔猖瀘洚琜笞吠䈢䤤渦洨缪䈬䄮吰䀲", a_))
						{
							num = (short)886505473;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 16:
						if (collectionView.Count > 0)
						{
							num = (short)389677070;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36E;
					case 17:
						if (collectionView.IsCurrentAfterLast)
						{
							num = (short)1491468297;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						collectionView.MoveCurrentToFirst();
						num = (short)511246344;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						goto IL_222;
					case 19:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource;
						if (myRecordsetDataSource != null)
						{
							num = (short)1302855683;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F1;
					}
					case 20:
						goto IL_2F1;
					case 21:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)475070469;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)988545037;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInner individualIDTonesInner;
						collectionView.MoveCurrentTo(individualIDTonesInner);
						num = (short)1257832450;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_AA:
					if (A_0 is global::AcpUI.AcpRecNavToolbar)
					{
						num = (short)915472385;
						if (num != 0)
						{
						}
						num = (short)1975189511;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_202:
					collectionView.MoveCurrentToLast();
					num = (short)838795282;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2F1:
					num = (short)643629071;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_15A:
				IL_1B4:
				IL_222:
				goto IL_36E;
				IL_24C:
				return;
				IL_36E:
				((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
				return;
			}
			}
		}

		// Token: 0x0600B744 RID: 46916 RVA: 0x00AA1458 File Offset: 0x00A9F658
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)501872657;
			short num2 = num;
			num = (short)468776977;
			switch (num2 == num)
			{
			default:
			{
				num = (short)936050688;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1185939457;
			if (num != 0)
			{
			}
			num = (short)2059534336;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x0600B745 RID: 46917 RVA: 0x00AA1508 File Offset: 0x00A9F708
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1286211152;
			short num2 = num;
			num = (short)614663760;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1520959488;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1673527297;
			if (num != 0)
			{
			}
			num = (short)2072248320;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x0600B746 RID: 46918 RVA: 0x00AA15B8 File Offset: 0x00A9F7B8
		internal void OnExpanderConventionalSystemIndividualIDTonesClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			object myRecordsetDataSource;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInner item;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (myRecordsetDataSource != null)
					{
						num2 = (short)624885762;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_B1;
				case 1:
					goto IL_B1;
				case 2:
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderConventionalSystemIndividualIDTones.SyncDataSources();
					num2 = (short)620953601;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
				IL_B1:
				num2 = (short)1760572365;
				short num3 = num2;
				num2 = (short)928068557;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_E7;
				}
			}
			IL_E7:
			num2 = (short)812122112;
			short num4 = num2;
			num2 = (short)8978433;
			if (num2 != 0)
			{
			}
			num2 = (short)1226309632;
			if (num2 != 0)
			{
			}
			this.RecNavToolbarExpanderConventionalSystemIndividualIDTones.TableMode = false;
			return;
			IL_1C:
			item = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderConventionalSystemIndividualIDTones.MyRecordsetDataSource;
			num2 = (short)1202126848;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600B747 RID: 46919 RVA: 0x00AA1720 File Offset: 0x00A9F920
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 0;
			while (this.b)
			{
				short num = (short)1848311809;
				if (num != 0)
				{
				}
				num = (short)412134290;
				short num2 = num;
				num = (short)129411986;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					break;
				default:
				{
					num = (short)1610219520;
					short num3 = num;
					break;
				}
				}
				num = (short)723582976;
				if (num != 0)
				{
				}
				return;
			}
			this.b = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("苂꧄ꯆ迈껊곌믎ꓐꇒ냔ꓖ룚닜닞釠賢诤苦蟨鿪심賮黰鷲菴鋶韸迺铼郾漀戂椄∆㬈㬊渌怎缐甒簔瀖氘椚簜欞䠠䰢䬤ࠦ䨨䐪䌬央吰崲䄴帶嘸唺尼匾摀煂畄㑆え㡊㥌⩎㱐籒㙔㡖㝘ⵚ㡜ㅞᕠ੢੤०ࡨݪṬ᙮ɰݲၴ᩶坸ͺᱼቾ", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600B748 RID: 46920 RVA: 0x00AA1804 File Offset: 0x00A9FA04
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1191968769;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_379B;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 2:
					num = (short)204865536;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_30:
				switch (connectionId)
				{
				case 1:
					goto IL_F9D;
				case 2:
					goto IL_F79;
				case 3:
				case 4:
				case 5:
					goto IL_3881;
				case 6:
					goto IL_A77;
				case 7:
					goto IL_1678;
				case 8:
					goto IL_3416;
				case 9:
					goto IL_3603;
				case 10:
					goto IL_20EF;
				case 11:
					goto IL_3708;
				case 12:
					goto IL_34DD;
				case 13:
					goto IL_1F9F;
				case 14:
					goto IL_C43;
				case 15:
					goto IL_1F4A;
				case 16:
					goto IL_18FE;
				case 17:
					goto IL_2575;
				case 18:
					goto IL_353F;
				case 19:
					goto IL_EA8;
				case 20:
					goto IL_BBA;
				case 21:
					goto IL_3641;
				case 22:
					goto IL_1C7F;
				case 23:
					goto IL_19A1;
				case 24:
					goto IL_1FEA;
				case 25:
					goto IL_2D62;
				case 26:
					goto IL_1ABD;
				case 27:
					goto IL_11BE;
				case 28:
					goto IL_3369;
				case 29:
					goto IL_276C;
				case 30:
					goto IL_1EE8;
				case 31:
					goto IL_221B;
				case 32:
					goto IL_1492;
				case 33:
					goto IL_37F5;
				case 34:
					goto IL_36D7;
				case 35:
					goto IL_1288;
				case 36:
					goto IL_2C9B;
				case 37:
					goto IL_17EC;
				case 38:
					goto IL_2A6A;
				case 39:
					goto IL_2113;
				case 40:
					goto IL_23D0;
				case 41:
					goto IL_2F31;
				case 42:
					goto IL_348F;
				case 43:
					goto IL_2809;
				case 44:
					goto IL_2066;
				case 45:
					goto IL_338D;
				case 46:
					goto IL_C84;
				case 47:
					goto IL_1B22;
				case 48:
					goto IL_120C;
				case 49:
					goto IL_196D;
				case 50:
					goto IL_2629;
				case 51:
					goto IL_12AC;
				case 52:
					goto IL_2BA3;
				case 53:
					goto IL_32D3;
				case 54:
					goto IL_16A9;
				case 55:
					goto IL_367F;
				case 56:
					goto IL_2DFB;
				case 57:
					goto IL_2351;
				case 58:
					goto IL_1FF7;
				case 59:
					goto IL_327E;
				case 60:
					goto IL_14D0;
				case 61:
					goto IL_22F9;
				case 62:
					goto IL_2BEE;
				case 63:
					goto IL_2D17;
				case 64:
					goto IL_E77;
				case 65:
					goto IL_15BB;
				case 66:
					goto IL_345E;
				case 67:
					goto IL_1501;
				case 68:
					goto IL_2FC1;
				case 69:
					goto IL_31B4;
				case 70:
					goto IL_294C;
				case 71:
					goto IL_247A;
				case 72:
					goto IL_2885;
				case 73:
					goto IL_1C72;
				case 74:
					goto IL_2449;
				case 75:
					goto IL_2DEE;
				case 76:
					goto IL_3746;
				case 77:
					goto IL_1925;
				case 78:
					goto IL_1701;
				case 79:
					goto IL_381C;
				case 80:
					goto IL_99C;
				case 81:
					goto IL_EB5;
				case 82:
					goto IL_12B9;
				case 83:
					goto IL_1759;
				case 84:
					goto IL_1454;
				case 85:
					goto IL_1026;
				case 86:
					goto IL_E9B;
				case 87:
					goto IL_35C5;
				case 88:
					goto IL_D4E;
				case 89:
					goto IL_2CB5;
				case 90:
					goto IL_1E14;
				case 91:
					goto IL_C6A;
				case 92:
					goto IL_149F;
				case 93:
					goto IL_19EC;
				case 94:
					goto IL_37D1;
				case 95:
					goto IL_A91;
				case 96:
					goto IL_CA8;
				case 97:
					goto IL_3101;
				case 98:
					goto IL_C36;
				case 99:
					goto IL_22EC;
				case 100:
					goto IL_27E5;
				case 101:
					goto IL_3338;
				case 102:
					goto IL_177D;
				case 103:
					goto IL_2997;
				case 104:
					goto IL_2A43;
				case 105:
					goto IL_157D;
				case 106:
					goto IL_2B34;
				case 107:
					goto IL_D03;
				case 108:
					goto IL_165E;
				case 109:
					goto IL_324A;
				case 110:
					goto IL_20A4;
				case 111:
					goto IL_2A77;
				case 112:
					goto IL_1E93;
				case 113:
					goto IL_2816;
				case 114:
					goto IL_3501;
				case 115:
					goto IL_3739;
				case 116:
					goto IL_A84;
				case 117:
					goto IL_21C3;
				case 118:
					goto IL_27B4;
				case 119:
					goto IL_14AC;
				case 120:
					goto IL_1C31;
				case 121:
					goto IL_31A7;
				case 122:
					goto IL_3219;
				case 123:
					goto IL_3159;
				case 124:
					goto IL_339A;
				case 125:
					goto IL_37A0;
				case 126:
					goto IL_982;
				case 127:
					goto IL_CC2;
				case 128:
					goto IL_28F4;
				case 129:
					goto IL_B55;
				case 130:
					goto IL_32AF;
				case 131:
					goto IL_24FC;
				case 132:
					goto IL_291B;
				case 133:
					goto IL_AB5;
				case 134:
					goto IL_297D;
				case 135:
					goto IL_376A;
				case 136:
					goto IL_2B10;
				case 137:
					goto IL_17AE;
				case 138:
					goto IL_213A;
				case 139:
					goto IL_E6A;
				case 140:
					goto IL_2EAB;
				case 141:
					goto IL_C5D;
				case 142:
					goto IL_9FE;
				case 143:
					goto IL_22A4;
				case 144:
					goto IL_1DE3;
				case 145:
					goto IL_2E6D;
				case 146:
					goto IL_BA0;
				case 147:
					goto IL_318D;
				case 148:
					goto IL_1F7B;
				case 149:
					goto IL_B7C;
				case 150:
					goto IL_134C;
				case 151:
					goto IL_1644;
				case 152:
					goto IL_201B;
				case 153:
					goto IL_1A96;
				case 154:
					goto IL_2228;
				case 155:
					goto IL_232D;
				case 156:
					goto IL_212D;
				case 157:
					goto IL_1C3E;
				case 158:
					goto IL_2847;
				case 159:
					goto IL_2E2F;
				case 160:
					goto IL_1D50;
				case 161:
					goto IL_1430;
				case 162:
					goto IL_138D;
				case 163:
					goto IL_10E0;
				case 164:
					goto IL_11CB;
				case 165:
					goto IL_1DD6;
				case 166:
					goto IL_2080;
				case 167:
					goto IL_1D74;
				case 168:
					goto IL_B6F;
				case 169:
					goto IL_153F;
				case 170:
					goto IL_224C;
				case 171:
					goto IL_2AB8;
				case 172:
					goto IL_1088;
				case 173:
					goto IL_1B46;
				case 174:
					goto IL_220E;
				case 175:
					goto IL_332B;
				case 176:
					goto IL_307B;
				case 177:
					goto IL_1AE4;
				case 178:
					goto IL_1918;
				case 179:
					goto IL_1DC9;
				case 180:
					goto IL_2313;
				case 181:
					goto IL_1D1C;
				case 182:
					goto IL_14DD;
				case 183:
					goto IL_B31;
				case 184:
					goto IL_3802;
				case 185:
					goto IL_32F7;
				case 186:
					goto IL_1CEB;
				case 187:
					goto IL_33E2;
				case 188:
					goto IL_BEB;
				case 189:
					goto IL_380F;
				case 190:
					goto IL_D34;
				case 191:
					goto IL_320C;
				case 192:
					goto IL_24E2;
				case 193:
					goto IL_100C;
				case 194:
					goto IL_F3B;
				case 195:
					goto IL_190B;
				case 196:
					goto IL_289F;
				case 197:
					goto IL_EC2;
				case 198:
					goto IL_1F26;
				case 199:
					goto IL_19D2;
				case 200:
					goto IL_2714;
				case 201:
					goto IL_2028;
				case 202:
					goto IL_25E1;
				case 203:
					goto IL_238F;
				case 204:
					goto IL_10ED;
				case 205:
					goto IL_C1C;
				case 206:
					goto IL_13D8;
				case 207:
					goto IL_1B6A;
				case 208:
					goto IL_1F57;
				case 209:
					goto IL_123D;
				case 210:
					goto IL_2035;
				case 211:
					goto IL_2297;
				case 212:
					goto IL_1FDD;
				case 213:
					goto IL_2643;
				case 214:
					goto IL_DB0;
				case 215:
					goto IL_18C0;
				case 216:
					goto IL_1728;
				case 217:
					goto IL_18DA;
				case 218:
					goto IL_2B72;
				case 219:
					goto IL_34C3;
				case 220:
					goto IL_2C39;
				case 221:
					goto IL_1380;
				case 222:
					goto IL_2FDB;
				case 223:
					goto IL_2599;
				case 224:
					goto IL_343A;
				case 225:
					goto IL_28C3;
				case 226:
					goto IL_35B8;
				case 227:
					goto IL_2854;
				case 228:
					goto IL_124A;
				case 229:
					goto IL_2C53;
				case 230:
					goto IL_1A1D;
				case 231:
					goto IL_FFF;
				case 232:
					goto IL_B00;
				case 233:
					goto IL_AF3;
				case 234:
					goto IL_DA3;
				case 235:
					goto IL_26F0;
				case 236:
					goto IL_DBD;
				case 237:
					goto IL_2FCE;
				case 238:
					goto IL_31FF;
				case 239:
					goto IL_3874;
				case 240:
					goto IL_331E;
				case 241:
					goto IL_2DCA;
				case 242:
					goto IL_E08;
				case 243:
					goto IL_2DBD;
				case 244:
					goto IL_33FC;
				case 245:
					goto IL_1D29;
				case 246:
					goto IL_13E5;
				case 247:
					goto IL_22C8;
				case 248:
					goto IL_29EC;
				case 249:
					goto IL_3271;
				case 250:
					goto IL_2A84;
				case 251:
					goto IL_1EF5;
				case 252:
					goto IL_FF2;
				case 253:
					goto IL_19F9;
				case 254:
					goto IL_2928;
				case 255:
					goto IL_1E2E;
				case 256:
					goto IL_11FF;
				case 257:
					goto IL_319A;
				case 258:
					goto IL_1019;
				case 259:
					goto IL_346B;
				case 260:
					goto IL_2650;
				case 261:
					goto IL_1EDB;
				case 262:
					goto IL_DFB;
				case 263:
					goto IL_17F9;
				case 264:
					goto IL_3777;
				case 265:
					goto IL_A53;
				case 266:
					goto IL_28D0;
				case 267:
					goto IL_1994;
				case 268:
					goto IL_1570;
				case 269:
					goto IL_219C;
				case 270:
					goto IL_2E08;
				case 271:
					goto IL_BC7;
				case 272:
					goto IL_1606;
				case 273:
					goto IL_2E22;
				case 274:
					goto IL_2306;
				case 275:
					goto IL_127B;
				case 276:
					goto IL_1C24;
				case 277:
					goto IL_1A4E;
				case 278:
					goto IL_29C8;
				case 279:
					goto IL_182A;
				case 280:
					goto IL_2A91;
				case 281:
					goto IL_1837;
				case 282:
					goto IL_1359;
				case 283:
					goto IL_2E87;
				case 284:
					goto IL_350E;
				case 285:
					goto IL_283A;
				case 286:
					goto IL_21B6;
				case 287:
					goto IL_300C;
				case 288:
					goto IL_1AD7;
				case 289:
					goto IL_1461;
				case 290:
					goto IL_F48;
				case 291:
					goto IL_1C65;
				case 292:
					goto IL_16DA;
				case 293:
					goto IL_36FB;
				case 294:
					goto IL_BAD;
				case 295:
					goto IL_2CA8;
				case 296:
					goto IL_2790;
				case 297:
					goto IL_365B;
				case 298:
					goto IL_368C;
				case 299:
					goto IL_1E55;
				case 300:
					goto IL_10AF;
				case 301:
					goto IL_1637;
				case 302:
					goto IL_30DD;
				case 303:
					goto IL_2F55;
				case 304:
					goto IL_1B15;
				case 305:
					goto IL_1332;
				case 306:
					goto IL_2059;
				case 307:
					goto IL_1ACA;
				case 308:
					goto IL_3057;
				case 309:
					goto IL_1E6F;
				case 310:
					goto IL_DE1;
				case 311:
					goto IL_1D36;
				case 312:
					goto IL_11F2;
				case 313:
					goto IL_1B77;
				case 314:
					goto IL_1E3B;
				case 315:
					goto IL_1CC7;
				case 316:
					goto IL_FCE;
				case 317:
					goto IL_D41;
				case 318:
					goto IL_3409;
				case 319:
					goto IL_3563;
				case 320:
					goto IL_275F;
				case 321:
					goto IL_2AC5;
				case 322:
					goto IL_1BF3;
				case 323:
					goto IL_2D96;
				case 324:
					goto IL_1423;
				case 325:
					goto IL_2A5D;
				case 326:
					goto IL_E5D;
				case 327:
					goto IL_21D0;
				case 328:
					goto IL_2861;
				case 329:
					goto IL_15F9;
				case 330:
					goto IL_2D89;
				case 331:
					goto IL_17D2;
				case 332:
					goto IL_2BE1;
				case 333:
					goto IL_D7F;
				case 334:
					goto IL_35DF;
				case 335:
					goto IL_975;
				case 336:
					goto IL_E2C;
				case 337:
					goto IL_24D5;
				case 338:
					goto IL_2B65;
				case 339:
					goto IL_311B;
				case 340:
					goto IL_2F9D;
				case 341:
					goto IL_15EC;
				case 342:
					goto IL_243C;
				case 343:
					goto IL_20BE;
				case 344:
					goto IL_3166;
				case 345:
					goto IL_1173;
				case 346:
					goto IL_154C;
				case 347:
					goto IL_2D55;
				case 348:
					goto IL_9F1;
				case 349:
					goto IL_1057;
				case 350:
					goto IL_CB5;
				case 351:
					goto IL_2320;
				case 352:
					goto IL_D27;
				case 353:
					goto IL_111E;
				case 354:
					goto IL_1064;
				case 355:
					goto IL_171B;
				case 356:
					goto IL_1C17;
				case 357:
					goto IL_2E7A;
				case 358:
					goto IL_2AF6;
				case 359:
					goto IL_3843;
				case 360:
					goto IL_2CD9;
				case 361:
					goto IL_272E;
				case 362:
					goto IL_2120;
				case 363:
					goto IL_24EF;
				case 364:
					goto IL_1E62;
				case 365:
					goto IL_F17;
				case 366:
					goto IL_1949;
				case 367:
					goto IL_2721;
				case 368:
					goto IL_3867;
				case 369:
					goto IL_2CFD;
				case 370:
					goto IL_1BB5;
				case 371:
					goto IL_2418;
				case 372:
					goto IL_2551;
				case 373:
					goto IL_2D0A;
				case 374:
					goto IL_310E;
				case 375:
					goto IL_34D0;
				case 376:
					goto IL_1197;
				case 377:
					goto IL_12DD;
				case 378:
					goto IL_B0D;
				case 379:
					goto IL_1DBC;
				case 380:
					goto IL_1D43;
				case 381:
					goto IL_3173;
				case 382:
					goto IL_298A;
				case 383:
					goto IL_EF3;
				case 384:
					goto IL_130E;
				case 385:
					goto IL_139A;
				case 386:
					goto IL_11D8;
				case 387:
					goto IL_228A;
				case 388:
					goto IL_1166;
				case 389:
					goto IL_ECF;
				case 390:
					goto IL_1735;
				case 391:
					goto IL_335C;
				case 392:
					goto IL_36CA;
				case 393:
					goto IL_10A2;
				case 394:
					goto IL_2BD4;
				case 395:
					goto IL_252D;
				case 396:
					goto IL_2F79;
				case 397:
					goto IL_2A9E;
				case 398:
					goto IL_1111;
				case 399:
					goto IL_3019;
				case 400:
					goto IL_1E21;
				case 401:
					goto IL_9A9;
				case 402:
					goto IL_1219;
				case 403:
					goto IL_37C4;
				case 404:
					goto IL_11A4;
				case 405:
					goto IL_1C58;
				case 406:
					goto IL_3264;
				case 407:
					goto IL_188F;
				case 408:
					goto IL_2681;
				case 409:
					goto IL_968;
				case 410:
					goto IL_314C;
				case 411:
					goto IL_2892;
				case 412:
					goto IL_2D6F;
				case 413:
					goto IL_1DF0;
				case 414:
					goto IL_178A;
				case 415:
					goto IL_2970;
				case 416:
					goto IL_3311;
				case 417:
					goto IL_162A;
				case 418:
					goto IL_2E15;
				case 419:
					goto IL_10BC;
				case 420:
					goto IL_25BD;
				case 421:
					goto IL_F6C;
				case 422:
					goto IL_1AA3;
				case 423:
					goto IL_1882;
				case 424:
					goto IL_3257;
				case 425:
					goto IL_29A4;
				case 426:
					goto IL_16B6;
				case 427:
					goto IL_150E;
				case 428:
					goto IL_3829;
				case 429:
					goto IL_364E;
				case 430:
					goto IL_1AB0;
				case 431:
					goto IL_BF8;
				case 432:
					goto IL_1806;
				case 433:
					goto IL_2BC7;
				case 434:
					goto IL_2B03;
				case 435:
					goto IL_36BD;
				case 436:
					goto IL_CDC;
				case 437:
					goto IL_2178;
				case 438:
					goto IL_13FF;
				case 439:
					goto IL_2D7C;
				case 440:
					goto IL_D72;
				case 441:
					goto IL_19DF;
				case 442:
					goto IL_31F2;
				case 443:
					goto IL_1F02;
				case 444:
					goto IL_2C77;
				case 445:
					goto IL_1A41;
				case 446:
					goto IL_23A9;
				case 447:
					goto IL_1E48;
				case 448:
					goto IL_2201;
				case 449:
					goto IL_1FD0;
				case 450:
					goto IL_2EE9;
				case 451:
					goto IL_1CA3;
				case 452:
					goto IL_166B;
				case 453:
					goto IL_313F;
				case 454:
					goto IL_C77;
				case 455:
					goto IL_23C3;
				case 456:
					goto IL_E39;
				case 457:
					goto IL_1033;
				case 458:
					goto IL_2B58;
				case 459:
					goto IL_1987;
				case 460:
					goto IL_1095;
				case 461:
					goto IL_197A;
				case 462:
					goto IL_1651;
				case 463:
					goto IL_1844;
				case 464:
					goto IL_1D98;
				case 465:
					goto IL_1301;
				case 466:
					goto IL_18B3;
				case 467:
					goto IL_31C1;
				case 468:
					goto IL_AE6;
				case 469:
					goto IL_18CD;
				case 470:
					goto IL_2F0D;
				case 471:
					goto IL_2456;
				case 472:
					goto IL_1B08;
				case 473:
					goto IL_98F;
				case 474:
					goto IL_16E7;
				case 475:
					goto IL_34A9;
				case 476:
					goto IL_273B;
				case 477:
					goto IL_151B;
				case 478:
					goto IL_CCF;
				case 479:
					goto IL_B62;
				case 480:
					goto IL_32A2;
				case 481:
					goto IL_15DF;
				case 482:
					goto IL_1142;
				case 483:
					goto IL_2154;
				case 484:
					goto IL_1B84;
				case 485:
					goto IL_CE9;
				case 486:
					goto IL_3836;
				case 487:
					goto IL_1366;
				case 488:
					goto IL_1BC2;
				case 489:
					goto IL_2266;
				case 490:
					goto IL_3033;
				case 491:
					goto IL_24C8;
				case 492:
					goto IL_2636;
				case 493:
					goto IL_11B1;
				case 494:
					goto IL_2A10;
				case 495:
					goto IL_3634;
				case 496:
					goto IL_3180;
				case 497:
					goto IL_3226;
				case 498:
					goto IL_20CB;
				case 499:
					goto IL_C29;
				case 500:
					goto IL_2C08;
				case 501:
					goto IL_CF6;
				case 502:
					goto IL_309F;
				case 503:
					goto IL_33BE;
				case 504:
					goto IL_2EB8;
				case 505:
					goto IL_349C;
				case 506:
					goto IL_35D2;
				case 507:
					goto IL_A22;
				case 508:
					goto IL_2AAB;
				case 509:
					goto IL_1BCF;
				case 510:
					goto IL_2605;
				case 511:
					goto IL_3627;
				case 512:
					goto IL_2AE9;
				case 513:
					goto IL_133F;
				case 514:
					goto IL_34B6;
				case 515:
					goto IL_158A;
				case 516:
					goto IL_1EB7;
				case 517:
					goto IL_DEE;
				case 518:
					goto IL_2674;
				case 519:
					goto IL_235E;
				case 520:
					goto IL_1485;
				case 521:
					goto IL_3570;
				case 522:
					goto IL_AC2;
				case 523:
					goto IL_30D0;
				case 524:
					goto IL_C50;
				case 525:
					goto IL_2EDC;
				case 526:
					goto IL_3532;
				case 527:
					goto IL_9CD;
				case 528:
					goto IL_3699;
				case 529:
					goto IL_11E5;
				case 530:
					goto IL_3304;
				case 531:
					goto IL_2901;
				case 532:
					goto IL_13F2;
				case 533:
					goto IL_13A7;
				case 534:
					goto IL_170E;
				case 535:
					goto IL_2FE8;
				case 536:
					goto IL_13B4;
				case 537:
					goto IL_2520;
				case 538:
					goto IL_2BFB;
				case 539:
					goto IL_2073;
				case 540:
					goto IL_2E60;
				case 541:
					goto IL_3594;
				case 542:
					goto IL_236B;
				case 543:
					goto IL_2147;
				case 544:
					goto IL_3026;
				case 545:
					goto IL_33EF;
				case 546:
					goto IL_1868;
				case 547:
					goto IL_2D24;
				case 548:
					goto IL_1CF8;
				case 549:
					goto IL_2B96;
				case 550:
					goto IL_2A50;
				case 551:
					goto IL_2259;
				case 552:
					goto IL_15AE;
				case 553:
					goto IL_1A72;
				case 554:
					goto IL_31CE;
				case 555:
					goto IL_20B1;
				case 556:
					goto IL_21F4;
				case 557:
					goto IL_1373;
				case 558:
					goto IL_2DA3;
				case 559:
					goto IL_30AC;
				case 560:
					goto IL_23F4;
				case 561:
					goto IL_2DB0;
				case 562:
					goto IL_21A9;
				case 563:
					goto IL_239C;
				case 564:
					goto IL_290E;
				case 565:
					goto IL_2C15;
				case 566:
					goto IL_A2F;
				case 567:
					goto IL_19C5;
				case 568:
					goto IL_1875;
				case 569:
					goto IL_169C;
				case 570:
					goto IL_27D8;
				case 571:
					goto IL_1FAC;
				case 572:
					goto IL_2E3C;
				case 573:
					goto IL_1C4B;
				case 574:
					goto IL_372C;
				case 575:
					goto IL_2C46;
				case 576:
					goto IL_16F4;
				case 577:
					goto IL_1B91;
				case 578:
					goto IL_1257;
				case 579:
					goto IL_2D48;
				case 580:
					goto IL_17DF;
				case 581:
					goto IL_23B6;
				default:
					num = (short)731840514;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_968:
			this.RTDBtnCnvSysDVRSPOP25Enable_A40126 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_975:
			this.RTDBtnCnvSysDVRSPTTWarningTime_A40131 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_982:
			this.RTDBtnCnvSysGeneralAckPretimems_A7393 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_98F:
			this.CpyBtnCnvSysFeaturesDataOperatedSquelchDOS_A7796 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_99C:
			this.CnvSysGeneralMDCPrimaryID_A8744Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_9A9:
			this.LblCnvSysFeaturesEmergencyAckEn_A41546 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysFeaturesEmergencyAckEn_A41546.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_9CD:
			this.LblCnvSysSecureDynTGKeySel_A40133 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysSecureDynTGKeySel_A40133.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_9F1:
			this.CpyBtnCnvSysDVRSRespPendingTime_A40129 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9FE:
			this.LblCnvSysGeneralEmergencyProfileSelection_A19421 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysGeneralEmergencyProfileSelection_A19421.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A22:
			this.CnvSysSecurePatchKeySel_A40136Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_A2F:
			this.ConSysCPTotalPretime_A20162 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.ConSysCPTotalPretime_A20162.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_A53:
			this.LblCnvSysDVRSEndOutOfRangeOnAnalogRx_A40143 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysDVRSEndOutOfRangeOnAnalogRx_A40143.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A77:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_A84:
			this.CnvSysGeneralSidetones_A8774Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_A91:
			this.CnvSysGeneralAdditionalMDCPID_A41761 = (global::AcpUI.AcpCheckBox)target;
			this.CnvSysGeneralAdditionalMDCPID_A41761.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_AB5:
			this.CpyBtnCnvSysGeneralInterPacketTimems_A8312 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_AC2:
			this.CnvSysSecureInterConnectKeySel_A40135 = (global::AcpUI.AcpComboBox)target;
			this.CnvSysSecureInterConnectKeySel_A40135.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_AE6:
			this.GrpBoxExpanderConventionalSystemFeaturesDataOperatedSquelchEnable = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_AF3:
			this.CnvSysDVRSEmerBlockInFS_A40143Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_B00:
			this.CpyBtnCnvSysDVRSEmerBlockInFS_A40143 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B0D:
			this.CnvSysFeaturesMessage_A8497 = (global::AcpUI.AcpCheckBox)target;
			this.CnvSysFeaturesMessage_A8497.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B31:
			this.CnvSysGeneralQc2CallFormat_A42230 = (global::AcpUI.AcpComboBox)target;
			this.CnvSysGeneralQc2CallFormat_A42230.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B55:
			this.CVBtnCnvSysGeneralInterPacketTimems_A8312 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B62:
			this.CpyBtnCnvSysFeaturesDOSOperation_A7891 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B6F:
			this.RTDBtnCnvSysGeneralPreambles_A8731 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_B7C:
			this.CnvSysGeneralDataProfileSelection_A13266 = (global::AcpUI.AcpComboBox)target;
			this.CnvSysGeneralDataProfileSelection_A13266.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_BA0:
			this.CnvSysGeneralEmergencyProfileSelection_A19421Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_BAD:
			this.GrpBoxExpanderConventionalSystemDVRSDynamicRegrouping = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_BBA:
			this.CnvSysGeneralKeyofConventionalSystem_A20482Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_BC7:
			this.LblCnvSysDVRSAttachRetryTime_A40141 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysDVRSAttachRetryTime_A40141.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_BEB:
			this.ExpanderConventionalSystemIndividualIDTonesGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_BF8:
			this.LblCnvSysFeaturesSendLocationToPeer_42427 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysFeaturesSendLocationToPeer_42427.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_C1C:
			this.RTDBtnCnvSysGeneralQc2Freq_A42232 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_C29:
			this.RTDBtnCnvSysSecureKMFProfIndex_A40132 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_C36:
			this.CnvSysGeneralAdditionalMDCPID_A41761Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_C43:
			this.ExpanderConventionalSystemGeneral = (global::AcpUI.AcpExpander)target;
			return;
			IL_C50:
			this.CpyBtnCnvSysSecureInterConnectKeySel_A40135 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_C5D:
			this.CVBtnCnvSysGeneralEmergencyProfileSelection_A19421 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_C6A:
			this.CpyBtnCnvSysGeneralVariableID_A9612 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_C77:
			this.CnvSysFeaturesRemoteRadioMode_A8935Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_C84:
			this.LblCnvSysGeneralSystemKeyPresent_A40120 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysGeneralSystemKeyPresent_A40120.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_CA8:
			this.RTDBtnCnvSysGeneralAdditionalMDCPID_A41761 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_CB5:
			this.ExpanderConventionalSystemFeatures = (global::AcpUI.AcpExpander)target;
			return;
			IL_CC2:
			this.CpyBtnCnvSysGeneralAckPretimems_A7393 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_CCF:
			this.RTDBtnCnvSysFeaturesDOSOperation_A7891 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_CDC:
			this.CVBtnCnvSysFeaturesSelectCallInCallReset_A9102 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_CE9:
			this.CpyBtnCnvSysFeaturesDOSCoastTimems_A7890 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_CF6:
			this.CnvSysSecureKMFProfIndex_A40132Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_D03:
			this.CnvSysGeneralCourtesyTone_43584 = (global::AcpUI.AcpCheckBox)target;
			this.CnvSysGeneralCourtesyTone_43584.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_D27:
			this.CVBtnCnvSysFeaturesRadioInhibit_A8831 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_D34:
			this.ExpanderConventionalSystemIndividualIDTones = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_D41:
			this.RTDBtnCnvSysDVRSIndCallMaxTargetRingTime_A40139 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_D4E:
			this.LblCnvSysGeneralVariableID_A9612 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysGeneralVariableID_A9612.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_D72:
			this.CpyBtnCnvSysFeaturesSelectCallInCallReset_A9102 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_D7F:
			this.LblCnvSysDVRSPTTWarningTime_A40131 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysDVRSPTTWarningTime_A40131.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_DA3:
			this.CVBtnCnvSysFeatureCallType_A40147 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_DB0:
			this.ExpanderConventionalSystemDVRS = (global::AcpUI.AcpExpander)target;
			return;
			IL_DBD:
			this.CnvSysFeatureCallType_A40147 = (global::AcpUI.AcpComboBox)target;
			this.CnvSysFeatureCallType_A40147.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_DE1:
			this.RTDBtnCnvSysFeatureDynRegroupChannel_A40144 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_DEE:
			this.RTDBtnCnvSysSecurePrivateCallKeySel_A40137 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_DFB:
			this.CpyBtnCnvSysDVRSOutOfDVRSRangeTime_A40127 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_E08:
			this.CnvSysDVRSTAAfterDVRSNoCommAttempts_A40125 = (global::AcpUI.AcpComboBox)target;
			this.CnvSysDVRSTAAfterDVRSNoCommAttempts_A40125.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_E2C:
			this.CpyBtnCnvSysDVRSPTTWarningTime_A40131 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_E39:
			this.LblCnvSysFeaturesTxBaseTimeSec_A9513 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysFeaturesTxBaseTimeSec_A9513.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_E5D:
			this.CVBtnCnvSysDVRSForceUnmuteTime_A40138 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_E6A:
			this.CpyBtnCnvSysGeneralLimitedPatiencesec_A8433 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_E77:
			this.LblCnvSysGeneralIndividualID_A8287 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysGeneralIndividualID_A8287.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_E9B:
			this.CnvSysGeneralSecondaryID_A9065Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_EA8:
			this.CpyBtnCnvSysGeneralKeyofConventionalSystem_A20482 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_EB5:
			this.CVBtnCnvSysGeneralSecondaryID_A9065 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_EC2:
			this.CVBtnCnvSysGeneralQc2Name_A42231 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_ECF:
			this.LblCnvSysFeaturesEmergencyAlarmRxIndicator_A7930 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysFeaturesEmergencyAlarmRxIndicator_A7930.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_EF3:
			this.LblCnvSysFeaturesDynamicIDEnable_A40100 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysFeaturesDynamicIDEnable_A40100.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_F17:
			this.LblCnvSysFeaturesStatus_A9186 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysFeaturesStatus_A9186.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_F3B:
			this.ExpanderConventionalSystemIndividualIDTonesSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_F48:
			this.CnvSysDVRSPhase2SysCompatibility_43000 = (global::AcpUI.AcpCheckBox)target;
			this.CnvSysDVRSPhase2SysCompatibility_43000.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_F6C:
			this.RTDBtnDataProfFeaturesTextMessagingService_A9372 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_F79:
			this.RecNavToolbarPageConventionalSystem = (global::AcpUI.AcpParentRecNavToolbar)target;
			this.RecNavToolbarPageConventionalSystem.ModeClick += this.OnModeClick;
			return;
			IL_F9D:
			((global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.PageConventionalSystem)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.PageConventionalSystem)target).Unloaded += this.OnUnloaded;
			return;
			IL_FCE:
			this.CnvSysDVRSIndCallMaxTargetRingTime_A40139 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvSysDVRSIndCallMaxTargetRingTime_A40139.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_FF2:
			this.CVBtnCnvSysTalkaroundAudioModes_44812 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_FFF:
			this.RTDBtnCnvSysDVRSEmerBlockInFS_A40143 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_100C:
			this.CnvSysGeneralQc2Code_A42234_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1019:
			this.CVBtnCnvSysDVRSOutOfDVRSRangeTime_A40127 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1026:
			this.CpyBtnCnvSysGeneralSecondaryID_A9065 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1033:
			this.CnvSysFeaturesTxBaseTimeSec_A9513 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvSysFeaturesTxBaseTimeSec_A9513.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1057:
			this.CnvSysDVRSRespPendingTime_A40129Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1064:
			this.CnvSysFeaturesRadioInhibit_A8831 = (global::AcpUI.AcpCheckBox)target;
			this.CnvSysFeaturesRadioInhibit_A8831.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1088:
			this.ExpanderConventionalSystemQuikCallII = (global::AcpUI.AcpExpander)target;
			return;
			IL_1095:
			this.CnvSysFeaturesTxBaseTimeSec_A9513Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_10A2:
			this.CnvSysFeaturesEmergencyAlarmRxIndicator_A7930Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_10AF:
			this.CnvSysFeatureDynRegroupEn_A40146Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_10BC:
			this.LblDataProfFeaturesTextMessagingService_A9372 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfFeaturesTextMessagingService_A9372.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_10E0:
			this.CpyBtnCnvSysLabtoolPreambleEnable_A19576 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_10ED:
			this.LblCnvSysGeneralQc2Freq_A42232 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysGeneralQc2Freq_A42232.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1111:
			this.CpyBtnCnvSysFeaturesQualifyEmergencyAlarmRx_A7931 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_111E:
			this.LblCnvSysFeaturesRadioInhibit_A8831 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysFeaturesRadioInhibit_A8831.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1142:
			this.LblCnvSysFeaturesDOSCoastTimems_A7890 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysFeaturesDOSCoastTimems_A7890.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1166:
			this.CVBtnCnvSysFeaturesEmergencyAlarmRxIndicator_A7930 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1173:
			this.LblCnvSysDVRSRespPendingTime_A40129 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysDVRSRespPendingTime_A40129.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1197:
			this.CVBtnCnvSysFeaturesMessage_A8497 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_11A4:
			this.CpyBtnCnvSysFeaturesEmergencyAckEn_A41546 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_11B1:
			this.CnvSysFeaturesPASelection_A42880Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_11BE:
			this.CVBtnConvConfigConvSystemFeatRSISys_A41838 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_11CB:
			this.CnvSysLabtoolPreambleEnable_A19576Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_11D8:
			this.CpyBtnCnvSysFeaturesDynamicIDEnable_A40100 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_11E5:
			this.RTDBtnCnvSysSecureDynTGKeySel_A40133 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_11F2:
			this.CnvSysFeatureDynRegroupChannel_A40144Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_11FF:
			this.CpyBtnCnvSysTalkaroundAudioModes_44812 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_120C:
			this.RTDBtnCnvSysGeneralSystemKeyPresent_A40120 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1219:
			this.CnvSysFeaturesEmergencyAckEn_A41546 = (global::AcpUI.AcpCheckBox)target;
			this.CnvSysFeaturesEmergencyAckEn_A41546.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_123D:
			this.CVBtnCnvSysGeneralQc2Code_A42234 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_124A:
			this.CVBtnCnvSysDVRSEmerBlockInFS_A40143 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1257:
			this.ConventionalSystemQuikCallIIToneListItemID_A42258 = (global::AcpUI.AcpComboBox)target;
			this.ConventionalSystemQuikCallIIToneListItemID_A42258.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_127B:
			this.CnvSysDVRSAttachRetryTime_A40141Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1288:
			this.CnvSysGeneralSystemGroupNumber_A21960 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.CnvSysGeneralSystemGroupNumber_A21960.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_12AC:
			this.CVBtnCnvSysGeneralHomeWACNID_A40121 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_12B9:
			this.LblCnvSysGeneralSecondaryID_A9065 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysGeneralSecondaryID_A9065.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_12DD:
			this.LblCnvSysFeaturesMessage_A8497 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysFeaturesMessage_A8497.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1301:
			this.RTDBtnCnvSysFeaturesExtendedDispatchEn_A37220 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_130E:
			this.CnvSysFeaturesDynamicIDEnable_A40100 = (global::AcpUI.AcpCheckBox)target;
			this.CnvSysFeaturesDynamicIDEnable_A40100.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1332:
			this.CpyBtnCnvSysFeatureDynRegroupZone_A40145 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_133F:
			this.CnvSysSecureFSKeySel_A40134Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_134C:
			this.RTDBtnCnvSysGeneralDataProfileSelection_A13266 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1359:
			this.CVBtnCnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1366:
			this.GrpBoxExpanderConventionalSystemFeaturesPseudo2 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1373:
			this.CnvSysLabtoolAckPreambles_A7392Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1380:
			this.CnvSysDVRSTalkPermitTone_A40124Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_138D:
			this.RTDBtnCnvSysLabtoolPreambleEnable_A19576 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_139A:
			this.RTDBtnCnvSysFeaturesDynamicIDEnable_A40100 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_13A7:
			this.GrpBoxExpanderConventionalSystemLabtoolPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_13B4:
			this.CnvSysLabtoolRACSidetone_A8820 = (global::AcpUI.AcpCheckBox)target;
			this.CnvSysLabtoolRACSidetone_A8820.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_13D8:
			this.CpyBtnCnvSysGeneralQc2Freq_A42232 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_13E5:
			this.CVBtnCnvSysDVRSPreferTalkaroundInNoComms_44810 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_13F2:
			this.ExpanderConventionalSystemLabtool = (global::AcpUI.AcpExpander)target;
			return;
			IL_13FF:
			this.CnvSysFeaturesSelectCallInCallReset_A9102 = (global::AcpUI.AcpComboBox)target;
			this.CnvSysFeaturesSelectCallInCallReset_A9102.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1423:
			this.CpyBtnCnvSysDVRSPrivateCallMaxInitRingTime_A40140 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1430:
			this.CnvSysLabtoolPreambleEnable_A19576 = (global::AcpUI.AcpCheckBox)target;
			this.CnvSysLabtoolPreambleEnable_A19576.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1454:
			this.RTDBtnCnvSysGeneralSecondaryID_A9065 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1461:
			this.LblCnvSysDVRSPhase2SysCompatibility_43000 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysDVRSPhase2SysCompatibility_43000.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1485:
			this.CVBtnCnvSysSecureInterConnectKeySel_A40135 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1492:
			this.ConvConfigConvSystemFeatRSISys_A41838Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_149F:
			this.CnvSysGeneralVariableID_A9612Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_14AC:
			this.CnvSysGeneralSystemPretimems2_A9246 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvSysGeneralSystemPretimems2_A9246.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_14D0:
			this.RTDBtnCnvSysGeneralSystemID_A40122 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_14DD:
			this.LblCnvSysGeneralQc2CallFormat_A42230 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysGeneralQc2CallFormat_A42230.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1501:
			this.CpyBtnCnvSysGeneralIndividualID_A8287 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_150E:
			this.RTDBtnCnvSysFeaturesGroupTMSEable_42809 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_151B:
			this.CnvSysFeaturesDOSOperation_A7891 = (global::AcpUI.AcpComboBox)target;
			this.CnvSysFeaturesDOSOperation_A7891.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_153F:
			this.CpyBtnCnvSysGeneralPreambles_A8731 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_154C:
			this.CnvSysDVRSRespPendingTime_A40129 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvSysDVRSRespPendingTime_A40129.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1570:
			this.CpyBtnCnvSysDVRSEndOutOfRangeOnAnalogRx_A40143 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_157D:
			this.CVBtnCnvSysGeneralCourtesyTone_43584 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_158A:
			this.LblCnvSysSecurePrivateCallKeySel_A40137 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysSecurePrivateCallKeySel_A40137.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_15AE:
			this.CVBtnCnvSysLabtoolAckPreambles_A7392 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_15BB:
			this.CnvSysGeneralIndividualID_A8287 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.CnvSysGeneralIndividualID_A8287.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_15DF:
			this.CVBtnCnvSysFeaturesDOSCoastTimems_A7890 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_15EC:
			this.RTDBtnCnvSysDVRSBusyUpdateTime_A40130 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_15F9:
			this.RTDBtnCnvSysDVRSForceUnmuteTime_A40138 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1606:
			this.CnvSysDVRSAttachRetryTime_A40141 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvSysDVRSAttachRetryTime_A40141.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_162A:
			this.CnvSysFeaturesCAIDataRegistration_A7585Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1637:
			this.CVBtnCnvSysFeatureDynRegroupZone_A40145 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1644:
			this.CpyBtnCnvSysGeneralDataProfileSelection_A13266 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1651:
			this.CVBtnCnvSysFeaturesExtendedDispatchEn_A37220 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_165E:
			this.RTDBtnCnvSysGeneralCourtesyTone_43584 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_166B:
			this.RTDBtnCnvSysFeaturesRemoteRadioMode_A8935 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1678:
			this.HLinkGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkGeneral.Click += this.HLinkClick;
			return;
			IL_169C:
			this.ConSysCPTotalPretime_A20162Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_16A9:
			this.RTDBtnCnvSysGeneralHomeWACNID_A40121 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_16B6:
			this.CnvSysFeaturesGroupTMSEable_42809 = (global::AcpUI.AcpComboBox)target;
			this.CnvSysFeaturesGroupTMSEable_42809.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_16DA:
			this.CpyBtnCnvSysDVRSPhase2SysCompatibility_43000 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_16E7:
			this.CnvSysFeaturesDataOperatedSquelchDOS_A7796Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_16F4:
			this.CVBtnConventionalSystemQuikCallIIToneListItemID_A42258 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1701:
			this.RTDBtnCnvSysGeneralMDCPrimaryID_A8744 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_170E:
			this.CVBtnCnvSysLabtoolRACSidetone_A8820 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_171B:
			this.RTDBtnCnvSysFeaturesRadioInhibit_A8831 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1728:
			this.CVBtnCnvSysDVRSTalkPermitTone_A40124 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1735:
			this.CnvSysFeaturesEmergencyAlarmRxIndicator_A7930 = (global::AcpUI.AcpCheckBox)target;
			this.CnvSysFeaturesEmergencyAlarmRxIndicator_A7930.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1759:
			this.CnvSysGeneralSecondaryID_A9065 = (global::AcpUI.AcpTextBox)target;
			this.CnvSysGeneralSecondaryID_A9065.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_177D:
			this.RTDBtnCnvSysGeneralPTTID_A8427 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_178A:
			this.CnvSysFeaturesCAIDataRegistration_A7585 = (global::AcpUI.AcpCheckBox)target;
			this.CnvSysFeaturesCAIDataRegistration_A7585.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_17AE:
			this.CnvSysGeneralLimitedPatiencesec_A8433 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvSysGeneralLimitedPatiencesec_A8433.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_17D2:
			this.CnvSysDVRSForceUnmuteTime_A40138Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_17DF:
			this.CpyBtnConventionalSystemQuikCallIIToneListItemID_A42258 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_17EC:
			this.CpyBtnCnvSysGeneralSystemGroupNumber_A21960 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_17F9:
			this.CnvSysDVRSOutOfDVRSRangeTime_A40127Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1806:
			this.CnvSysFeaturesSendLocationToPeer_42427 = (global::AcpUI.AcpCheckBox)target;
			this.CnvSysFeaturesSendLocationToPeer_42427.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_182A:
			this.RTDBtnCnvSysDVRSAttachRetries_A40142 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1837:
			this.CnvSysDVRSAttachRetries_A40142Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1844:
			this.LblCnvSysFeaturesExtendedDispatchEn_A37220 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysFeaturesExtendedDispatchEn_A37220.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1868:
			this.CVBtnCnvSysLabtoolCPTotalPretimeMDC_A7789 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1875:
			this.CpyBtnConSysCPTotalPretime_A20162 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1882:
			this.DataProfFeaturesTextMessagingService_A9372Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_188F:
			this.LblCnvSysDVRSPOP25Enable_A40126 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysDVRSPOP25Enable_A40126.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_18B3:
			this.CpyBtnCnvSysFeaturesExtendedDispatchEn_A37220 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_18C0:
			this.GrpBoxExpanderConventionalSystemDVRSPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_18CD:
			this.CVBtnCnvSysFeaturesDataOperatedSquelchDOS_A7796 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_18DA:
			this.LblCnvSysDVRSTalkPermitTone_A40124 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysDVRSTalkPermitTone_A40124.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_18FE:
			this.CVBtnCnvSysGeneralKeyofConventionalSystem_A20482 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_190B:
			this.gridExpanderConventionalSystemIndividualIDTonesSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_1918:
			this.RTDBtnCnvSysQCIIDecode = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1925:
			this.CnvSysGeneralMDCPrimaryID_A8744 = (global::AcpUI.AcpTextBox)target;
			this.CnvSysGeneralMDCPrimaryID_A8744.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1949:
			this.CnvSysFeaturesStatus_A9186 = (global::AcpUI.AcpCheckBox)target;
			this.CnvSysFeaturesStatus_A9186.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_196D:
			this.CpyBtnCnvSysGeneralSystemKeyPresent_A40120 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_197A:
			this.GrpBoxExpanderConventionalSystemFeaturesPseudo1 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1987:
			this.CpyBtnCnvSysFeaturesTxBaseTimeSec_A9513 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1994:
			this.RTDBtnCnvSysDVRSEndOutOfRangeOnAnalogRx_A40143 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_19A1:
			this.CnvSysGeneralSystemType_A13262 = (global::AcpUI.AcpComboBox)target;
			this.CnvSysGeneralSystemType_A13262.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_19C5:
			this.RTDBtnConSysCPTotalPretime_A20162 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_19D2:
			this.RTDBtnCnvSysGeneralQc2Name_A42231 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_19DF:
			this.CnvSysFeaturesSelectCallInCallReset_A9102Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_19EC:
			this.CVBtnCnvSysGeneralAdditionalMDCPID_A41761 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_19F9:
			this.LblCnvSysTalkaroundAudioModes_44812 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysTalkaroundAudioModes_44812.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1A1D:
			this.CnvSysDVRSEmerBlockInFS_A40143 = (global::AcpUI.AcpCheckBox)target;
			this.CnvSysDVRSEmerBlockInFS_A40143.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1A41:
			this.RTDBtnCnvSysFeaturesAutoResetTimesec_A7511 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1A4E:
			this.LblCnvSysDVRSAttachRetries_A40142 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysDVRSAttachRetries_A40142.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1A72:
			this.LblCnvSysLabtoolAckPreambles_A7392 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysLabtoolAckPreambles_A7392.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1A96:
			this.CVBtnCnvSysGeneralRepeaterAccessPretimems_A8741 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1AA3:
			this.CpyBtnDataProfFeaturesTextMessagingService_A9372 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1AB0:
			this.CVBtnCnvSysFeaturesSendLocationToPeer_42427 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1ABD:
			this.CnvSysGeneralSystemType_A13262Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1ACA:
			this.CVBtnCnvSysFeatureDynRegroupChannel_A40144 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1AD7:
			this.CVBtnCnvSysDVRSPhase2SysCompatibility_43000 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1AE4:
			this.CnvSysQCIIDecode = (global::AcpUI.AcpCheckBox)target;
			this.CnvSysQCIIDecode.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1B08:
			this.RTDBtnCnvSysFeaturesDataOperatedSquelchDOS_A7796 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1B15:
			this.RTDBtnCnvSysFeatureDynRegroupZone_A40145 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1B22:
			this.CnvSysGeneralSystemKeyPresent_A40120 = (global::AcpUI.AcpLabel)target;
			this.CnvSysGeneralSystemKeyPresent_A40120.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1B46:
			this.RecNavToolbarExpanderConventionalSystemIndividualIDTones = (global::AcpUI.AcpChildRecNavToolbar)target;
			this.RecNavToolbarExpanderConventionalSystemIndividualIDTones.ModeClick += this.OnModeClick;
			return;
			IL_1B6A:
			this.CnvSysGeneralQc2Freq_A42232Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1B77:
			this.GrpBoxExpanderConventionalSystemDVRSTimers = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1B84:
			this.RTDBtnCnvSysFeaturesDOSCoastTimems_A7890 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1B91:
			this.LblConventionalSystemQuikCallIIToneListItemID_A42258 = (global::AcpUI.AcpLabel)target;
			this.LblConventionalSystemQuikCallIIToneListItemID_A42258.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1BB5:
			this.CVBtnCnvSysFeaturesStatusRequest_A9198 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1BC2:
			this.CVBtnCnvSysFeaturesPASelection_A42880 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1BCF:
			this.LblCnvSysSecureFSKeySel_A40134 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysSecureFSKeySel_A40134.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1BF3:
			this.CnvSysDVRSPrivateCallMaxInitRingTime_A40140 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvSysDVRSPrivateCallMaxInitRingTime_A40140.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1C17:
			this.CpyBtnCnvSysFeaturesRadioInhibit_A8831 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1C24:
			this.CVBtnCnvSysDVRSAttachRetries_A40142 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1C31:
			this.RTDBtnCnvSysGeneralSystemPretimems2_A9246 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1C3E:
			this.CpyBtnCnvSysGeneralRepeaterAccessPretimems_A8741 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1C4B:
			this.RTDBtnCnvSysLabtoolRetryConstrant_A8950 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1C58:
			this.CnvSysFeaturesEmergencyAckEn_A41546Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1C65:
			this.RTDBtnCnvSysDVRSPhase2SysCompatibility_43000 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1C72:
			this.CpyBtnCnvSysGeneralPreambleLength_A8721 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1C7F:
			this.LblCnvSysGeneralSystemType_A13262 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysGeneralSystemType_A13262.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1CA3:
			this.CnvSysFeaturesRemoteRadioMode_A8935 = (global::AcpUI.AcpComboBox)target;
			this.CnvSysFeaturesRemoteRadioMode_A8935.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1CC7:
			this.LblCnvSysDVRSIndCallMaxTargetRingTime_A40139 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysDVRSIndCallMaxTargetRingTime_A40139.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1CEB:
			this.CnvSysGeneralQc2CallFormat_A42230Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1CF8:
			this.CnvSysLabtoolCPTotalPretimeMDC_A7789 = (global::AcpUI.AcpTextBox)target;
			this.CnvSysLabtoolCPTotalPretimeMDC_A7789.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1D1C:
			this.CVBtnCnvSysGeneralQc2CallFormat_A42230 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1D29:
			this.CnvSysDVRSTAAfterDVRSNoCommAttempts_A40125Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1D36:
			this.CpyBtnCnvSysFeatureDynRegroupChannel_A40144 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1D43:
			this.CpyBtnCnvSysFeaturesMessage_A8497 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1D50:
			this.LblCnvSysLabtoolPreambleEnable_A19576 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysLabtoolPreambleEnable_A19576.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1D74:
			this.CnvSysGeneralPreambles_A8731 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvSysGeneralPreambles_A8731.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1D98:
			this.CnvSysFeaturesExtendedDispatchEn_A37220 = (global::AcpUI.AcpCheckBox)target;
			this.CnvSysFeaturesExtendedDispatchEn_A37220.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1DBC:
			this.RTDBtnCnvSysFeaturesMessage_A8497 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1DC9:
			this.CpyBtnCnvSysQCIIDecode = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1DD6:
			this.CVBtnCnvSysGeneralPreambles_A8731 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1DE3:
			this.RTDBtnCnvSysGeneralEmergencyProfileSelection_A19421 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1DF0:
			this.LblCnvSysFeaturesCAIDataRegistration_A7585 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysFeaturesCAIDataRegistration_A7585.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1E14:
			this.RTDBtnCnvSysGeneralVariableID_A9612 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1E21:
			this.CVBtnCnvSysFeaturesEmergencyAckEn_A41546 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1E2E:
			this.RTDBtnCnvSysTalkaroundAudioModes_44812 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1E3B:
			this.CVBtnCnvSysDVRSIndCallMaxTargetRingTime_A40139 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1E48:
			this.CnvSysFeaturesAutoResetTimesec_A7511Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1E55:
			this.CpyBtnCnvSysFeatureDynRegroupEn_A40146 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1E62:
			this.CVBtnCnvSysFeaturesStatus_A9186 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1E6F:
			this.CnvSysFeatureDynRegroupChannel_A40144 = (global::AcpUI.AcpComboBox)target;
			this.CnvSysFeatureDynRegroupChannel_A40144.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1E93:
			this.LblCnvSysGeneralSidetones_A8774 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysGeneralSidetones_A8774.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1EB7:
			this.CnvSysSecurePrivateCallKeySel_A40137 = (global::AcpUI.AcpComboBox)target;
			this.CnvSysSecurePrivateCallKeySel_A40137.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1EDB:
			this.RTDBtnCnvSysDVRSOutOfDVRSRangeTime_A40127 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1EE8:
			this.RTDBtnConvConfigConvSystemFeatRSISys_A41838 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1EF5:
			this.CnvSysDVRSPreferTalkaroundInNoComms_44810Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1F02:
			this.LblCnvSysFeaturesAutoResetTimesec_A7511 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysFeaturesAutoResetTimesec_A7511.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1F26:
			this.LblCnvSysGeneralQc2Name_A42231 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysGeneralQc2Name_A42231.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1F4A:
			this.GrpBoxExpanderConventionalSystemGeneralPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1F57:
			this.CnvSysGeneralQc2Code_A42234 = (global::AcpUI.AcpComboBox)target;
			this.CnvSysGeneralQc2Code_A42234.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1F7B:
			this.LblCnvSysGeneralDataProfileSelection_A13266 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysGeneralDataProfileSelection_A13266.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1F9F:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_1FAC:
			this.LblCnvSysLabtoolRetryConstrant_A8950 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysLabtoolRetryConstrant_A8950.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1FD0:
			this.CVBtnCnvSysFeaturesRemoteRadioMode_A8935 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1FDD:
			this.CpyBtnCnvSysGeneralQc2Code_A42234 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1FEA:
			this.RTDBtnCnvSysGeneralSystemType_A13262 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1FF7:
			this.LblCnvSysGeneralSystemID_A40122 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysGeneralSystemID_A40122.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_201B:
			this.CnvSysGeneralDataProfileSelection_A13266Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2028:
			this.CnvSysGeneralQc2Name_A42231Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2035:
			this.LblCnvSysGeneralQc2Code_A42234 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysGeneralQc2Code_A42234.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2059:
			this.CnvSysFeatureDynRegroupZone_A40145Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2066:
			this.AstTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2073:
			this.CnvSysLabtoolRACSidetone_A8820Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2080:
			this.LblCnvSysGeneralPreambles_A8731 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysGeneralPreambles_A8731.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_20A4:
			this.CnvSysGeneralCourtesyTone_43584Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_20B1:
			this.RTDBtnCnvSysLabtoolAckPreambles_A7392 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_20BE:
			this.CnvSysDVRSBusyUpdateTime_A40130Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_20CB:
			this.CnvSysSecureKMFProfIndex_A40132 = (global::AcpUI.AcpComboBox)target;
			this.CnvSysSecureKMFProfIndex_A40132.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_20EF:
			this.HLinkFeatures = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkFeatures.Click += this.HLinkClick;
			return;
			IL_2113:
			this.CVBtnAstTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2120:
			this.CpyBtnCnvSysFeaturesRadioCheck_A8826 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_212D:
			this.RTDBtnCnvSysGeneralRepeaterAccessPretimems_A8741 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_213A:
			this.RTDBtnCnvSysGeneralLimitedPatiencesec_A8433 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2147:
			this.RTDBtnCnvSysLabtoolPreambles_A8730 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2154:
			this.CnvSysFeaturesDOSCoastTimems_A7890 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvSysFeaturesDOSCoastTimems_A7890.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2178:
			this.LblCnvSysFeaturesSelectCallInCallReset_A9102 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysFeaturesSelectCallInCallReset_A9102.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_219C:
			this.CnvSysDVRSEndOutOfRangeOnAnalogRx_A40143Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_21A9:
			this.CpyBtnCnvSysLabtoolInterPacketPreambles_A8311 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_21B6:
			this.CpyBtnCnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_21C3:
			this.CVBtnCnvSysGeneralSystemPretimems2_A9246 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_21D0:
			this.LblCnvSysDVRSForceUnmuteTime_A40138 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysDVRSForceUnmuteTime_A40138.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_21F4:
			this.CpyBtnCnvSysLabtoolAckPreambles_A7392 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2201:
			this.GrpBoxExpanderConventionalSystemFeaturesRemoteMonitorRadioTrace = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_220E:
			this.GrpBoxExpanderConventionalSystemQuikCallIIPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_221B:
			this.CpyBtnConvConfigConvSystemFeatRSISys_A41838 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2228:
			this.LblCnvSysGeneralRepeaterAccessPretimems_A8741 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysGeneralRepeaterAccessPretimems_A8741.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_224C:
			this.CnvSysGeneralPreambles_A8731Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2259:
			this.CnvSysLabtoolCPTotalPretimeMDC_A7789Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2266:
			this.LblCnvSysFeaturesPASelection_A42880 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysFeaturesPASelection_A42880.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_228A:
			this.CnvSysFeaturesDynamicIDEnable_A40100Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2297:
			this.RTDBtnCnvSysGeneralQc2Code_A42234 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_22A4:
			this.CnvSysGeneralEmergencyProfileSelection_A19421 = (global::AcpUI.AcpComboBox)target;
			this.CnvSysGeneralEmergencyProfileSelection_A19421.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_22C8:
			this.LblCnvSysDVRSPreferTalkaroundInNoComms_44810 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysDVRSPreferTalkaroundInNoComms_44810.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_22EC:
			this.CVBtnCnvSysGeneralPTTID_A8427 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_22F9:
			this.CpyBtnCnvSysGeneralSystemID_A40122 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2306:
			this.CpyBtnCnvSysDVRSAttachRetryTime_A40141 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2313:
			this.CnvSysQCIIDecodeComp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2320:
			this.GrpBoxExpanderConventionalSystemFeaturesPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_232D:
			this.CnvSysGeneralRepeaterAccessPretimems_A8741 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvSysGeneralRepeaterAccessPretimems_A8741.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2351:
			this.CVBtnCnvSysGeneralSystemID_A40122 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_235E:
			this.CnvSysSecurePrivateCallKeySel_A40137Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_236B:
			this.CnvSysLabtoolPreambles_A8730 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvSysLabtoolPreambles_A8730.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_238F:
			this.CVBtnCnvSysGeneralQc2Freq_A42232 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_239C:
			this.CnvSysLabtoolInterPacketPreambles_A8311Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_23A9:
			this.CpyBtnCnvSysFeaturesAutoResetTimesec_A7511 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_23B6:
			this.ConventionalSystemQuikCallIIToneListItemID_A42258Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_23C3:
			this.CVBtnCnvSysFeaturesTxBaseTimeSec_A9513 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_23D0:
			this.LblAstTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279 = (global::AcpUI.AcpLabel)target;
			this.LblAstTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_23F4:
			this.CnvSysLabtoolInterPacketPreambles_A8311 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvSysLabtoolInterPacketPreambles_A8311.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2418:
			this.LblCnvSysFeaturesStatusRequest_A9198 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysFeaturesStatusRequest_A9198.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_243C:
			this.CpyBtnCnvSysDVRSBusyUpdateTime_A40130 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2449:
			this.CnvSysGeneralPreambleLength_A8721Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2456:
			this.CnvSysFeaturesDataOperatedSquelchDOS_A7796 = (global::AcpUI.AcpCheckBox)target;
			this.CnvSysFeaturesDataOperatedSquelchDOS_A7796.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_247A:
			num = (short)1346764800;
			short num3 = num;
			this.CnvSysGeneralPreambleLength_A8721 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvSysGeneralPreambleLength_A8721.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_24C8:
			this.RTDBtnCnvSysFeaturesPASelection_A42880 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_24D5:
			this.CnvSysDVRSPTTWarningTime_A40131Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_24E2:
			this.CnvSysGeneralQc2Freq_A42232_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_24EF:
			this.CnvSysFeaturesRadioCheck_A8826Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_24FC:
			this.CnvSysGeneralInterPacketTimems_A8312 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvSysGeneralInterPacketTimems_A8312.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2520:
			this.RTDBtnCnvSysLabtoolRACSidetone_A8820 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_252D:
			this.LblCnvSysFeaturesQualifyEmergencyAlarmRx_A7931 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysFeaturesQualifyEmergencyAlarmRx_A7931.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2551:
			this.CnvSysFeaturesStatusRequest_A9198 = (global::AcpUI.AcpCheckBox)target;
			this.CnvSysFeaturesStatusRequest_A9198.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2575:
			this.LblCnvSysGeneralKeyofConventionalSystem_A20482 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysGeneralKeyofConventionalSystem_A20482.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2599:
			this.LblCnvSysDVRSDVRSyncNACMatching_44811 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysDVRSDVRSyncNACMatching_44811.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_25BD:
			this.DataProfFeaturesTextMessagingService_A9372 = (global::AcpUI.AcpComboBox)target;
			this.DataProfFeaturesTextMessagingService_A9372.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_25E1:
			this.CnvSysGeneralQc2Freq_A42232 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvSysGeneralQc2Freq_A42232.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2605:
			this.CnvSysSecureFSKeySel_A40134 = (global::AcpUI.AcpComboBox)target;
			this.CnvSysSecureFSKeySel_A40134.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2629:
			this.CnvSysGeneralSystemKeyPresent_A40120Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2636:
			this.CpyBtnCnvSysFeaturesPASelection_A42880 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2643:
			this.CnvSysGeneralQc2Code_A42234Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2650:
			this.CnvSysDVRSOutOfDVRSRangeTime_A40127 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvSysDVRSOutOfDVRSRangeTime_A40127.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2674:
			this.CpyBtnCnvSysSecurePrivateCallKeySel_A40137 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2681:
			num = (short)182220021;
			short num4 = num;
			num = (short)203584757;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_220E;
			default:
				num = (short)50266112;
				if (num != 0)
				{
				}
				this.CnvSysDVRSPOP25Enable_A40126 = (global::AcpUI.AcpCheckBox)target;
				this.CnvSysDVRSPOP25Enable_A40126.GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			IL_26F0:
			this.LblCnvSysFeatureCallType_A40147 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysFeatureCallType_A40147.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2714:
			this.CpyBtnCnvSysGeneralQc2Name_A42231 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2721:
			this.RTDBtnCnvSysFeaturesStatus_A9186 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_272E:
			this.RTDBtnCnvSysFeaturesRadioCheck_A8826 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_273B:
			this.LblCnvSysFeaturesDOSOperation_A7891 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysFeaturesDOSOperation_A7891.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_275F:
			this.CVBtnCnvSysDVRSPrivateCallMaxInitRingTime_A40140 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_276C:
			this.ConvConfigConvSystemFeatRSISys_A41838 = (global::AcpUI.AcpCheckBox)target;
			this.ConvConfigConvSystemFeatRSISys_A41838.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2790:
			this.LblCnvSysFeatureDynRegroupEn_A40146 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysFeatureDynRegroupEn_A40146.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_27B4:
			this.LblCnvSysGeneralSystemPretimems2_A9246 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysGeneralSystemPretimems2_A9246.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_27D8:
			this.CVBtnCnvSysLabtoolRetryConstrant_A8950 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_27E5:
			this.LblCnvSysGeneralPTTID_A8427 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysGeneralPTTID_A8427.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2809:
			this.CpyBtnAstTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2816:
			this.CnvSysGeneralSidetones_A8774 = (global::AcpUI.AcpComboBox)target;
			this.CnvSysGeneralSidetones_A8774.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_283A:
			this.RTDBtnCnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2847:
			this.CnvSysGeneralRepeaterAccessPretimems_A8741Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2854:
			this.CnvSysDVRSDVRSyncNACMatching_44811Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2861:
			this.CnvSysDVRSForceUnmuteTime_A40138 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvSysDVRSForceUnmuteTime_A40138.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2885:
			this.RTDBtnCnvSysGeneralPreambleLength_A8721 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2892:
			this.CnvSysDVRSPOP25Enable_A40126Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_289F:
			this.CnvSysGeneralQc2Name_A42231 = (global::AcpUI.AcpLabel)target;
			this.CnvSysGeneralQc2Name_A42231.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_28C3:
			this.RTDBtnCnvSysDVRSDVRSyncNACMatching_44811 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_28D0:
			this.CnvSysDVRSEndOutOfRangeOnAnalogRx_A40143 = (global::AcpUI.AcpCheckBox)target;
			this.CnvSysDVRSEndOutOfRangeOnAnalogRx_A40143.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_28F4:
			this.CnvSysGeneralAckPretimems_A7393Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2901:
			this.CnvSysSecureDynTGKeySel_A40133Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_290E:
			this.CVBtnConSysCPTotalPretime_A20162 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_291B:
			this.RTDBtnCnvSysGeneralInterPacketTimems_A8312 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2928:
			this.CnvSysTalkaroundAudioModes_44812 = (global::AcpUI.AcpComboBox)target;
			this.CnvSysTalkaroundAudioModes_44812.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_294C:
			this.LblCnvSysGeneralPreambleLength_A8721 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysGeneralPreambleLength_A8721.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2970:
			this.RTDBtnCnvSysFeaturesCAIDataRegistration_A7585 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_297D:
			this.CnvSysGeneralInterPacketTimems_A8312Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_298A:
			this.CVBtnCnvSysFeaturesDynamicIDEnable_A40100 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2997:
			this.CpyBtnCnvSysGeneralPTTID_A8427 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_29A4:
			this.LblCnvSysFeaturesGroupTMSEable_42809 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysFeaturesGroupTMSEable_42809.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_29C8:
			this.CnvSysDVRSAttachRetries_A40142 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvSysDVRSAttachRetries_A40142.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_29EC:
			this.CnvSysDVRSPreferTalkaroundInNoComms_44810 = (global::AcpUI.AcpCheckBox)target;
			this.CnvSysDVRSPreferTalkaroundInNoComms_44810.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2A10:
			num = (short)92798977;
			if (num != 0)
			{
			}
			this.ExpanderConventionalSystemSecure = (global::AcpUI.AcpExpander)target;
			return;
			IL_2A43:
			this.CnvSysGeneralPTTID_A8427Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2A50:
			this.CpyBtnCnvSysLabtoolCPTotalPretimeMDC_A7789 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2A5D:
			this.CnvSysDVRSPrivateCallMaxInitRingTime_A40140Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2A6A:
			this.CnvSysGeneralSystemGroupNumber_A21960Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_2A77:
			this.CVBtnCnvSysGeneralSidetones_A8774 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2A84:
			this.CpyBtnCnvSysDVRSPreferTalkaroundInNoComms_44810 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2A91:
			this.CpyBtnCnvSysDVRSAttachRetries_A40142 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2A9E:
			this.RTDBtnCnvSysFeaturesQualifyEmergencyAlarmRx_A7931 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2AAB:
			this.CVBtnCnvSysSecureFSKeySel_A40134 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2AB8:
			this.GrpBoxExpanderConventionalSystemGeneralTxTone = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_2AC5:
			this.LblCnvSysDVRSPrivateCallMaxInitRingTime_A40140 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysDVRSPrivateCallMaxInitRingTime_A40140.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2AE9:
			this.CpyBtnCnvSysSecureFSKeySel_A40134 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2AF6:
			this.CVBtnCnvSysFeaturesRadioCheck_A8826 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2B03:
			this.CpyBtnCnvSysFeaturesSendLocationToPeer_42427 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2B10:
			this.LblCnvSysGeneralLimitedPatiencesec_A8433 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysGeneralLimitedPatiencesec_A8433.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2B34:
			this.LblCnvSysGeneralCourtesyTone_43584 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysGeneralCourtesyTone_43584.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2B58:
			this.RTDBtnCnvSysFeaturesTxBaseTimeSec_A9513 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2B65:
			this.CVBtnCnvSysDVRSBusyUpdateTime_A40130 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2B72:
			this.CnvSysDVRSTalkPermitTone_A40124 = (global::AcpUI.AcpCheckBox)target;
			this.CnvSysDVRSTalkPermitTone_A40124.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2B96:
			this.RTDBtnCnvSysLabtoolCPTotalPretimeMDC_A7789 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2BA3:
			this.LblCnvSysGeneralHomeWACNID_A40121 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysGeneralHomeWACNID_A40121.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2BC7:
			this.RTDBtnCnvSysFeaturesSendLocationToPeer_42427 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2BD4:
			this.CVBtnCnvSysFeaturesQualifyEmergencyAlarmRx_A7931 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2BE1:
			this.CVBtnCnvSysDVRSPTTWarningTime_A40131 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2BEE:
			this.CnvSysGeneralSystemID_A40122Comp = (global::AcpUI.AcpTextBoxCustomDecHex)target;
			return;
			IL_2BFB:
			this.CpyBtnCnvSysLabtoolRACSidetone_A8820 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2C08:
			this.CpyBtnCnvSysSecureKMFProfIndex_A40132 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2C15:
			this.LblConSysCPTotalPretime_A20162 = (global::AcpUI.AcpLabel)target;
			this.LblConSysCPTotalPretime_A20162.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2C39:
			this.CpyBtnCnvSysDVRSTalkPermitTone_A40124 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2C46:
			this.CnvSysLabtoolRetryConstrant_A8950Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2C53:
			this.LblCnvSysDVRSEmerBlockInFS_A40143 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysDVRSEmerBlockInFS_A40143.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2C77:
			this.CnvSysFeaturesAutoResetTimesec_A7511 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvSysFeaturesAutoResetTimesec_A7511.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2C9B:
			this.RTDBtnCnvSysGeneralSystemGroupNumber_A21960 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2CA8:
			this.CVBtnCnvSysFeatureDynRegroupEn_A40146 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2CB5:
			this.CnvSysGeneralVariableID_A9612 = (global::AcpUI.AcpTextBox)target;
			this.CnvSysGeneralVariableID_A9612.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2CD9:
			this.CnvSysFeaturesRadioCheck_A8826 = (global::AcpUI.AcpCheckBox)target;
			this.CnvSysFeaturesRadioCheck_A8826.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2CFD:
			this.CnvSysFeaturesStatus_A9186Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2D0A:
			this.RTDBtnCnvSysFeaturesStatusRequest_A9198 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2D17:
			this.CVBtnCnvSysGeneralIndividualID_A8287 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2D24:
			this.LblCnvSysLabtoolCPTotalPretimeMDC_A7789 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysLabtoolCPTotalPretimeMDC_A7789.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2D48:
			this.RTDBtnConventionalSystemQuikCallIIToneListItemID_A42258 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2D55:
			this.RTDBtnCnvSysDVRSRespPendingTime_A40129 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2D62:
			this.CpyBtnCnvSysGeneralSystemType_A13262 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2D6F:
			this.CVBtnCnvSysFeaturesCAIDataRegistration_A7585 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2D7C:
			this.RTDBtnCnvSysFeaturesSelectCallInCallReset_A9102 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2D89:
			this.CpyBtnCnvSysDVRSForceUnmuteTime_A40138 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2D96:
			this.RTDBtnCnvSysDVRSPrivateCallMaxInitRingTime_A40140 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2DA3:
			this.CVBtnCnvSysLabtoolInterPacketPreambles_A8311 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2DB0:
			this.RTDBtnCnvSysLabtoolInterPacketPreambles_A8311 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2DBD:
			this.RTDBtnCnvSysDVRSTAAfterDVRSNoCommAttempts_A40125 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2DCA:
			this.LblCnvSysDVRSTAAfterDVRSNoCommAttempts_A40125 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysDVRSTAAfterDVRSNoCommAttempts_A40125.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2DEE:
			this.CVBtnCnvSysGeneralMDCPrimaryID_A8744 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2DFB:
			this.CnvSysGeneralHomeWACNID_A40121Comp = (global::AcpUI.AcpTextBoxCustomDecHex)target;
			return;
			IL_2E08:
			this.CVBtnCnvSysDVRSAttachRetryTime_A40141 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2E15:
			this.CVBtnDataProfFeaturesTextMessagingService_A9372 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2E22:
			this.RTDBtnCnvSysDVRSAttachRetryTime_A40141 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2E2F:
			this.CVBtnCnvSysLabtoolPreambleEnable_A19576 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2E3C:
			this.CnvSysLabtoolRetryConstrant_A8950 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvSysLabtoolRetryConstrant_A8950.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2E60:
			this.CVBtnCnvSysLabtoolPreambles_A8730 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2E6D:
			this.CpyBtnCnvSysGeneralEmergencyProfileSelection_A19421 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2E7A:
			this.CnvSysFeaturesRadioInhibit_A8831Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2E87:
			this.LblCnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2EAB:
			this.CnvSysGeneralLimitedPatiencesec_A8433Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2EB8:
			this.CnvSysSecurePatchKeySel_A40136 = (global::AcpUI.AcpComboBox)target;
			this.CnvSysSecurePatchKeySel_A40136.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2EDC:
			this.CnvSysSecureInterConnectKeySel_A40135Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2EE9:
			this.LblCnvSysFeaturesRemoteRadioMode_A8935 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysFeaturesRemoteRadioMode_A8935.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2F0D:
			this.LblCnvSysFeaturesDataOperatedSquelchDOS_A7796 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysFeaturesDataOperatedSquelchDOS_A7796.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2F31:
			this.AstTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.AstTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2F55:
			this.CnvSysFeatureDynRegroupZone_A40145 = (global::AcpUI.AcpComboBox)target;
			this.CnvSysFeatureDynRegroupZone_A40145.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2F79:
			this.CnvSysFeaturesQualifyEmergencyAlarmRx_A7931 = (global::AcpUI.AcpCheckBox)target;
			this.CnvSysFeaturesQualifyEmergencyAlarmRx_A7931.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2F9D:
			this.CnvSysDVRSBusyUpdateTime_A40130 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvSysDVRSBusyUpdateTime_A40130.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2FC1:
			this.CnvSysGeneralIndividualID_A8287Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_2FCE:
			this.RTDBtnCnvSysFeatureCallType_A40147 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2FDB:
			this.CVBtnCnvSysDVRSDVRSyncNACMatching_44811 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2FE8:
			this.LblCnvSysLabtoolRACSidetone_A8820 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysLabtoolRACSidetone_A8820.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_300C:
			this.CnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_3019:
			this.CnvSysFeaturesQualifyEmergencyAlarmRx_A7931Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_3026:
			this.CpyBtnCnvSysLabtoolPreambles_A8730 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3033:
			this.CnvSysFeaturesPASelection_A42880 = (global::AcpUI.AcpComboBox)target;
			this.CnvSysFeaturesPASelection_A42880.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3057:
			this.LblCnvSysFeatureDynRegroupChannel_A40144 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysFeatureDynRegroupChannel_A40144.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_307B:
			this.LblCnvSysQCIIDecode = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysQCIIDecode.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_309F:
			this.CVBtnCnvSysSecurePatchKeySel_A40136 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_30AC:
			this.LblCnvSysLabtoolInterPacketPreambles_A8311 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysLabtoolInterPacketPreambles_A8311.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_30D0:
			this.RTDBtnCnvSysSecureInterConnectKeySel_A40135 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_30DD:
			this.LblCnvSysFeatureDynRegroupZone_A40145 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysFeatureDynRegroupZone_A40145.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3101:
			this.CpyBtnCnvSysGeneralAdditionalMDCPID_A41761 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_310E:
			this.CpyBtnCnvSysFeaturesStatusRequest_A9198 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_311B:
			this.LblCnvSysDVRSBusyUpdateTime_A40130 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysDVRSBusyUpdateTime_A40130.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_313F:
			this.CpyBtnCnvSysFeaturesRemoteRadioMode_A8935 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_314C:
			this.CpyBtnCnvSysDVRSPOP25Enable_A40126 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3159:
			this.CVBtnCnvSysGeneralAckPretimems_A7393 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3166:
			this.CVBtnCnvSysDVRSRespPendingTime_A40129 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3173:
			this.CnvSysFeaturesMessage_A8497Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_3180:
			this.CVBtnCnvSysSecureKMFProfIndex_A40132 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_318D:
			this.CVBtnCnvSysGeneralDataProfileSelection_A13266 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_319A:
			this.CnvSysTalkaroundAudioModes_44812Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_31A7:
			this.CpyBtnCnvSysGeneralSystemPretimems2_A9246 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_31B4:
			this.CVBtnCnvSysGeneralPreambleLength_A8721 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_31C1:
			this.CnvSysFeaturesExtendedDispatchEn_A37220Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_31CE:
			this.CnvSysLabtoolAckPreambles_A7392 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvSysLabtoolAckPreambles_A7392.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_31F2:
			this.CVBtnCnvSysFeaturesAutoResetTimesec_A7511 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_31FF:
			this.CpyBtnCnvSysFeatureCallType_A40147 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_320C:
			this.CnvSysGeneralQc2Name_A42231_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_3219:
			this.CnvSysGeneralSystemPretimems2_A9246Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3226:
			this.LblCnvSysSecureKMFProfIndex_A40132 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysSecureKMFProfIndex_A40132.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_324A:
			this.CpyBtnCnvSysGeneralCourtesyTone_43584 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3257:
			this.CVBtnCnvSysFeaturesGroupTMSEable_42809 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3264:
			this.CVBtnCnvSysDVRSPOP25Enable_A40126 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3271:
			this.RTDBtnCnvSysDVRSPreferTalkaroundInNoComms_44810 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_327E:
			this.CnvSysGeneralSystemID_A40122 = (global::AcpUI.AcpTextBoxCustomDecHex)target;
			this.CnvSysGeneralSystemID_A40122.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_32A2:
			this.CnvSysFeaturesDOSOperation_A7891Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_32AF:
			this.LblCnvSysGeneralInterPacketTimems_A8312 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysGeneralInterPacketTimems_A8312.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_32D3:
			this.CnvSysGeneralHomeWACNID_A40121 = (global::AcpUI.AcpTextBoxCustomDecHex)target;
			this.CnvSysGeneralHomeWACNID_A40121.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_32F7:
			this.CpyBtnCnvSysGeneralQc2CallFormat_A42230 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3304:
			this.CpyBtnCnvSysSecureDynTGKeySel_A40133 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3311:
			this.CpyBtnCnvSysFeaturesCAIDataRegistration_A7585 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_331E:
			this.CVBtnCnvSysDVRSTAAfterDVRSNoCommAttempts_A40125 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_332B:
			this.CVBtnCnvSysQCIIDecode = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3338:
			this.CnvSysGeneralPTTID_A8427 = (global::AcpUI.AcpComboBox)target;
			this.CnvSysGeneralPTTID_A8427.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_335C:
			this.RTDBtnCnvSysFeaturesEmergencyAlarmRxIndicator_A7930 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3369:
			this.LblConvConfigConvSystemFeatRSISys_A41838 = (global::AcpUI.AcpLabel)target;
			this.LblConvConfigConvSystemFeatRSISys_A41838.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_338D:
			this.CVBtnCnvSysGeneralSystemKeyPresent_A40120 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_339A:
			this.LblCnvSysGeneralAckPretimems_A7393 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysGeneralAckPretimems_A7393.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_33BE:
			this.LblCnvSysSecurePatchKeySel_A40136 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysSecurePatchKeySel_A40136.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_33E2:
			this.ExpanderConventionalSystemQuikCallIIGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_33EF:
			this.CnvSysLabtoolPreambles_A8730Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_33FC:
			this.CpyBtnCnvSysDVRSTAAfterDVRSNoCommAttempts_A40125 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3409:
			this.CpyBtnCnvSysDVRSIndCallMaxTargetRingTime_A40139 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3416:
			this.HLinkQuikCallII = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkQuikCallII.Click += this.HLinkClick;
			return;
			IL_343A:
			this.CnvSysDVRSDVRSyncNACMatching_44811 = (global::AcpUI.AcpCheckBox)target;
			this.CnvSysDVRSDVRSyncNACMatching_44811.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_345E:
			this.RTDBtnCnvSysGeneralIndividualID_A8287 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_346B:
			this.LblCnvSysDVRSOutOfDVRSRangeTime_A40127 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysDVRSOutOfDVRSRangeTime_A40127.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_348F:
			this.RTDBtnAstTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_349C:
			this.RTDBtnCnvSysSecurePatchKeySel_A40136 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_34A9:
			this.CVBtnCnvSysFeaturesDOSOperation_A7891 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_34B6:
			this.CVBtnCnvSysSecurePrivateCallKeySel_A40137 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_34C3:
			this.RTDBtnCnvSysDVRSTalkPermitTone_A40124 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_34D0:
			this.CnvSysFeaturesStatusRequest_A9198Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_34DD:
			this.HLinkLabtool = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkLabtool.Click += this.HLinkClick;
			return;
			IL_3501:
			this.RTDBtnCnvSysGeneralSidetones_A8774 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_350E:
			this.CnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445 = (global::AcpUI.AcpCheckBox)target;
			this.CnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3532:
			this.CVBtnCnvSysSecureDynTGKeySel_A40133 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_353F:
			this.CnvSysGeneralKeyofConventionalSystem_A20482 = (global::AcpUI.AcpTextBox)target;
			this.CnvSysGeneralKeyofConventionalSystem_A20482.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3563:
			this.CnvSysDVRSIndCallMaxTargetRingTime_A40139Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3570:
			this.LblCnvSysSecureInterConnectKeySel_A40135 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysSecureInterConnectKeySel_A40135.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3594:
			this.LblCnvSysLabtoolPreambles_A8730 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysLabtoolPreambles_A8730.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_35B8:
			this.CpyBtnCnvSysDVRSDVRSyncNACMatching_44811 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_35C5:
			this.CVBtnCnvSysGeneralVariableID_A9612 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_35D2:
			this.CpyBtnCnvSysSecurePatchKeySel_A40136 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_35DF:
			this.CnvSysDVRSPTTWarningTime_A40131 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvSysDVRSPTTWarningTime_A40131.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3603:
			this.HLinkDVRS = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkDVRS.Click += this.HLinkClick;
			return;
			IL_3627:
			this.RTDBtnCnvSysSecureFSKeySel_A40134 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3634:
			this.GrpBoxExpanderConventionalSystemSecurePseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_3641:
			this.CVBtnCnvSysGeneralSystemType_A13262 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_364E:
			this.CnvSysFeaturesGroupTMSEable_42809Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_365B:
			this.CnvSysFeatureDynRegroupEn_A40146 = (global::AcpUI.AcpCheckBox)target;
			this.CnvSysFeatureDynRegroupEn_A40146.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_367F:
			this.CpyBtnCnvSysGeneralHomeWACNID_A40121 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_368C:
			this.RTDBtnCnvSysFeatureDynRegroupEn_A40146 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3699:
			this.CnvSysSecureDynTGKeySel_A40133 = (global::AcpUI.AcpComboBox)target;
			this.CnvSysSecureDynTGKeySel_A40133.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_36BD:
			this.CnvSysFeaturesSendLocationToPeer_42427Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_36CA:
			this.CpyBtnCnvSysFeaturesEmergencyAlarmRxIndicator_A7930 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_36D7:
			this.LblCnvSysGeneralSystemGroupNumber_A21960 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysGeneralSystemGroupNumber_A21960.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_36FB:
			this.CnvSysDVRSPhase2SysCompatibility_43000Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_3708:
			this.HLinkSecure = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkSecure.Click += this.HLinkClick;
			return;
			IL_372C:
			this.CpyBtnCnvSysLabtoolRetryConstrant_A8950 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3739:
			this.CpyBtnCnvSysGeneralSidetones_A8774 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3746:
			this.LblCnvSysGeneralMDCPrimaryID_A8744 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysGeneralMDCPrimaryID_A8744.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_376A:
			this.CVBtnCnvSysGeneralLimitedPatiencesec_A8433 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3777:
			this.CVBtnCnvSysDVRSEndOutOfRangeOnAnalogRx_A40143 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_379B:
			goto IL_3881;
			IL_37A0:
			this.CnvSysGeneralAckPretimems_A7393 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvSysGeneralAckPretimems_A7393.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_37C4:
			this.RTDBtnCnvSysFeaturesEmergencyAckEn_A41546 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_37D1:
			this.LblCnvSysGeneralAdditionalMDCPID_A41761 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysGeneralAdditionalMDCPID_A41761.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_37F5:
			this.CVBtnCnvSysGeneralSystemGroupNumber_A21960 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3802:
			this.RTDBtnCnvSysGeneralQc2CallFormat_A42230 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_380F:
			this.ExpanderConventionalSystemIndividualIDTonesTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_381C:
			this.CpyBtnCnvSysGeneralMDCPrimaryID_A8744 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3829:
			this.CpyBtnCnvSysFeaturesGroupTMSEable_42809 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3836:
			this.CnvSysFeaturesDOSCoastTimems_A7890Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3843:
			this.LblCnvSysFeaturesRadioCheck_A8826 = (global::AcpUI.AcpLabel)target;
			this.LblCnvSysFeaturesRadioCheck_A8826.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3867:
			this.CpyBtnCnvSysFeaturesStatus_A9186 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3874:
			this.CnvSysFeatureCallType_A40147Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3881:
			this.b = true;
		}

		// Token: 0x0600B749 RID: 46921 RVA: 0x00AA509C File Offset: 0x00AA329C
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 3:
				break;
			case 4:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 5:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			default:
			{
				short num = (short)994824723;
				short num2 = num;
				num = (short)1033490963;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_2E;
				case 1:
					break;
				default:
				{
					num = (short)1975451648;
					short num3 = num;
					break;
				}
				}
				num = (short)2019885057;
				if (num != 0)
				{
				}
				num = (short)1864302592;
				if (num != 0)
				{
				}
				return;
			}
			}
			IL_2E:
			((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x040058C6 RID: 22726
		private bool a;

		// Token: 0x040058C7 RID: 22727
		internal global::AcpUI.AcpParentRecNavToolbar RecNavToolbarPageConventionalSystem;

		// Token: 0x040058C8 RID: 22728
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x040058C9 RID: 22729
		internal global::System.Windows.Documents.Hyperlink HLinkGeneral;

		// Token: 0x040058CA RID: 22730
		internal global::System.Windows.Documents.Hyperlink HLinkQuikCallII;

		// Token: 0x040058CB RID: 22731
		internal global::System.Windows.Documents.Hyperlink HLinkDVRS;

		// Token: 0x040058CC RID: 22732
		internal global::System.Windows.Documents.Hyperlink HLinkFeatures;

		// Token: 0x040058CD RID: 22733
		internal global::System.Windows.Documents.Hyperlink HLinkSecure;

		// Token: 0x040058CE RID: 22734
		internal global::System.Windows.Documents.Hyperlink HLinkLabtool;

		// Token: 0x040058CF RID: 22735
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x040058D0 RID: 22736
		internal global::AcpUI.AcpExpander ExpanderConventionalSystemGeneral;

		// Token: 0x040058D1 RID: 22737
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalSystemGeneralPseudo0;

		// Token: 0x040058D2 RID: 22738
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysGeneralKeyofConventionalSystem_A20482;

		// Token: 0x040058D3 RID: 22739
		internal global::AcpUI.AcpLabel LblCnvSysGeneralKeyofConventionalSystem_A20482;

		// Token: 0x040058D4 RID: 22740
		internal global::AcpUI.AcpTextBox CnvSysGeneralKeyofConventionalSystem_A20482;

		// Token: 0x040058D5 RID: 22741
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysGeneralKeyofConventionalSystem_A20482;

		// Token: 0x040058D6 RID: 22742
		internal global::AcpUI.AcpLabel CnvSysGeneralKeyofConventionalSystem_A20482Comp;

		// Token: 0x040058D7 RID: 22743
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysGeneralSystemType_A13262;

		// Token: 0x040058D8 RID: 22744
		internal global::AcpUI.AcpLabel LblCnvSysGeneralSystemType_A13262;

		// Token: 0x040058D9 RID: 22745
		internal global::AcpUI.AcpComboBox CnvSysGeneralSystemType_A13262;

		// Token: 0x040058DA RID: 22746
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysGeneralSystemType_A13262;

		// Token: 0x040058DB RID: 22747
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysGeneralSystemType_A13262;

		// Token: 0x040058DC RID: 22748
		internal global::AcpUI.AcpLabel CnvSysGeneralSystemType_A13262Comp;

		// Token: 0x040058DD RID: 22749
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnConvConfigConvSystemFeatRSISys_A41838;

		// Token: 0x040058DE RID: 22750
		internal global::AcpUI.AcpLabel LblConvConfigConvSystemFeatRSISys_A41838;

		// Token: 0x040058DF RID: 22751
		internal global::AcpUI.AcpCheckBox ConvConfigConvSystemFeatRSISys_A41838;

		// Token: 0x040058E0 RID: 22752
		internal global::AcpUI.AcpRtdButton RTDBtnConvConfigConvSystemFeatRSISys_A41838;

		// Token: 0x040058E1 RID: 22753
		internal global::AcpUI.AcpCopyButton CpyBtnConvConfigConvSystemFeatRSISys_A41838;

		// Token: 0x040058E2 RID: 22754
		internal global::AcpUI.AcpCheckBox ConvConfigConvSystemFeatRSISys_A41838Comp;

		// Token: 0x040058E3 RID: 22755
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysGeneralSystemGroupNumber_A21960;

		// Token: 0x040058E4 RID: 22756
		internal global::AcpUI.AcpLabel LblCnvSysGeneralSystemGroupNumber_A21960;

		// Token: 0x040058E5 RID: 22757
		internal global::AcpUI.AcpTextBoxSpinnerDecHex CnvSysGeneralSystemGroupNumber_A21960;

		// Token: 0x040058E6 RID: 22758
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysGeneralSystemGroupNumber_A21960;

		// Token: 0x040058E7 RID: 22759
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysGeneralSystemGroupNumber_A21960;

		// Token: 0x040058E8 RID: 22760
		internal global::AcpUI.AcpTextBoxDecHex CnvSysGeneralSystemGroupNumber_A21960Comp;

		// Token: 0x040058E9 RID: 22761
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnAstTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279;

		// Token: 0x040058EA RID: 22762
		internal global::AcpUI.AcpLabel LblAstTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279;

		// Token: 0x040058EB RID: 22763
		internal global::AcpUI.AcpTextBoxSpinner AstTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279;

		// Token: 0x040058EC RID: 22764
		internal global::AcpUI.AcpRtdButton RTDBtnAstTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279;

		// Token: 0x040058ED RID: 22765
		internal global::AcpUI.AcpCopyButton CpyBtnAstTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279;

		// Token: 0x040058EE RID: 22766
		internal global::AcpUI.AcpLabel AstTlkgrpLstGeneralSystemWideTalkgroupHangTimesec_A9279Comp;

		// Token: 0x040058EF RID: 22767
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysGeneralSystemKeyPresent_A40120;

		// Token: 0x040058F0 RID: 22768
		internal global::AcpUI.AcpLabel LblCnvSysGeneralSystemKeyPresent_A40120;

		// Token: 0x040058F1 RID: 22769
		internal global::AcpUI.AcpLabel CnvSysGeneralSystemKeyPresent_A40120;

		// Token: 0x040058F2 RID: 22770
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysGeneralSystemKeyPresent_A40120;

		// Token: 0x040058F3 RID: 22771
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysGeneralSystemKeyPresent_A40120;

		// Token: 0x040058F4 RID: 22772
		internal global::AcpUI.AcpLabel CnvSysGeneralSystemKeyPresent_A40120Comp;

		// Token: 0x040058F5 RID: 22773
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysGeneralHomeWACNID_A40121;

		// Token: 0x040058F6 RID: 22774
		internal global::AcpUI.AcpLabel LblCnvSysGeneralHomeWACNID_A40121;

		// Token: 0x040058F7 RID: 22775
		internal global::AcpUI.AcpTextBoxCustomDecHex CnvSysGeneralHomeWACNID_A40121;

		// Token: 0x040058F8 RID: 22776
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysGeneralHomeWACNID_A40121;

		// Token: 0x040058F9 RID: 22777
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysGeneralHomeWACNID_A40121;

		// Token: 0x040058FA RID: 22778
		internal global::AcpUI.AcpTextBoxCustomDecHex CnvSysGeneralHomeWACNID_A40121Comp;

		// Token: 0x040058FB RID: 22779
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysGeneralSystemID_A40122;

		// Token: 0x040058FC RID: 22780
		internal global::AcpUI.AcpLabel LblCnvSysGeneralSystemID_A40122;

		// Token: 0x040058FD RID: 22781
		internal global::AcpUI.AcpTextBoxCustomDecHex CnvSysGeneralSystemID_A40122;

		// Token: 0x040058FE RID: 22782
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysGeneralSystemID_A40122;

		// Token: 0x040058FF RID: 22783
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysGeneralSystemID_A40122;

		// Token: 0x04005900 RID: 22784
		internal global::AcpUI.AcpTextBoxCustomDecHex CnvSysGeneralSystemID_A40122Comp;

		// Token: 0x04005901 RID: 22785
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysGeneralIndividualID_A8287;

		// Token: 0x04005902 RID: 22786
		internal global::AcpUI.AcpLabel LblCnvSysGeneralIndividualID_A8287;

		// Token: 0x04005903 RID: 22787
		internal global::AcpUI.AcpTextBoxSpinnerDecHex CnvSysGeneralIndividualID_A8287;

		// Token: 0x04005904 RID: 22788
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysGeneralIndividualID_A8287;

		// Token: 0x04005905 RID: 22789
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysGeneralIndividualID_A8287;

		// Token: 0x04005906 RID: 22790
		internal global::AcpUI.AcpTextBoxDecHex CnvSysGeneralIndividualID_A8287Comp;

		// Token: 0x04005907 RID: 22791
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysGeneralPreambleLength_A8721;

		// Token: 0x04005908 RID: 22792
		internal global::AcpUI.AcpLabel LblCnvSysGeneralPreambleLength_A8721;

		// Token: 0x04005909 RID: 22793
		internal global::AcpUI.AcpTextBoxSpinner CnvSysGeneralPreambleLength_A8721;

		// Token: 0x0400590A RID: 22794
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysGeneralPreambleLength_A8721;

		// Token: 0x0400590B RID: 22795
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysGeneralPreambleLength_A8721;

		// Token: 0x0400590C RID: 22796
		internal global::AcpUI.AcpLabel CnvSysGeneralPreambleLength_A8721Comp;

		// Token: 0x0400590D RID: 22797
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysGeneralMDCPrimaryID_A8744;

		// Token: 0x0400590E RID: 22798
		internal global::AcpUI.AcpLabel LblCnvSysGeneralMDCPrimaryID_A8744;

		// Token: 0x0400590F RID: 22799
		internal global::AcpUI.AcpTextBox CnvSysGeneralMDCPrimaryID_A8744;

		// Token: 0x04005910 RID: 22800
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysGeneralMDCPrimaryID_A8744;

		// Token: 0x04005911 RID: 22801
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysGeneralMDCPrimaryID_A8744;

		// Token: 0x04005912 RID: 22802
		internal global::AcpUI.AcpLabel CnvSysGeneralMDCPrimaryID_A8744Comp;

		// Token: 0x04005913 RID: 22803
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysGeneralSecondaryID_A9065;

		// Token: 0x04005914 RID: 22804
		internal global::AcpUI.AcpLabel LblCnvSysGeneralSecondaryID_A9065;

		// Token: 0x04005915 RID: 22805
		internal global::AcpUI.AcpTextBox CnvSysGeneralSecondaryID_A9065;

		// Token: 0x04005916 RID: 22806
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysGeneralSecondaryID_A9065;

		// Token: 0x04005917 RID: 22807
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysGeneralSecondaryID_A9065;

		// Token: 0x04005918 RID: 22808
		internal global::AcpUI.AcpLabel CnvSysGeneralSecondaryID_A9065Comp;

		// Token: 0x04005919 RID: 22809
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysGeneralVariableID_A9612;

		// Token: 0x0400591A RID: 22810
		internal global::AcpUI.AcpLabel LblCnvSysGeneralVariableID_A9612;

		// Token: 0x0400591B RID: 22811
		internal global::AcpUI.AcpTextBox CnvSysGeneralVariableID_A9612;

		// Token: 0x0400591C RID: 22812
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysGeneralVariableID_A9612;

		// Token: 0x0400591D RID: 22813
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysGeneralVariableID_A9612;

		// Token: 0x0400591E RID: 22814
		internal global::AcpUI.AcpLabel CnvSysGeneralVariableID_A9612Comp;

		// Token: 0x0400591F RID: 22815
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysGeneralAdditionalMDCPID_A41761;

		// Token: 0x04005920 RID: 22816
		internal global::AcpUI.AcpLabel LblCnvSysGeneralAdditionalMDCPID_A41761;

		// Token: 0x04005921 RID: 22817
		internal global::AcpUI.AcpCheckBox CnvSysGeneralAdditionalMDCPID_A41761;

		// Token: 0x04005922 RID: 22818
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysGeneralAdditionalMDCPID_A41761;

		// Token: 0x04005923 RID: 22819
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysGeneralAdditionalMDCPID_A41761;

		// Token: 0x04005924 RID: 22820
		internal global::AcpUI.AcpCheckBox CnvSysGeneralAdditionalMDCPID_A41761Comp;

		// Token: 0x04005925 RID: 22821
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysGeneralPTTID_A8427;

		// Token: 0x04005926 RID: 22822
		internal global::AcpUI.AcpLabel LblCnvSysGeneralPTTID_A8427;

		// Token: 0x04005927 RID: 22823
		internal global::AcpUI.AcpComboBox CnvSysGeneralPTTID_A8427;

		// Token: 0x04005928 RID: 22824
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysGeneralPTTID_A8427;

		// Token: 0x04005929 RID: 22825
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysGeneralPTTID_A8427;

		// Token: 0x0400592A RID: 22826
		internal global::AcpUI.AcpLabel CnvSysGeneralPTTID_A8427Comp;

		// Token: 0x0400592B RID: 22827
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysGeneralCourtesyTone_43584;

		// Token: 0x0400592C RID: 22828
		internal global::AcpUI.AcpLabel LblCnvSysGeneralCourtesyTone_43584;

		// Token: 0x0400592D RID: 22829
		internal global::AcpUI.AcpCheckBox CnvSysGeneralCourtesyTone_43584;

		// Token: 0x0400592E RID: 22830
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysGeneralCourtesyTone_43584;

		// Token: 0x0400592F RID: 22831
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysGeneralCourtesyTone_43584;

		// Token: 0x04005930 RID: 22832
		internal global::AcpUI.AcpCheckBox CnvSysGeneralCourtesyTone_43584Comp;

		// Token: 0x04005931 RID: 22833
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysGeneralSidetones_A8774;

		// Token: 0x04005932 RID: 22834
		internal global::AcpUI.AcpLabel LblCnvSysGeneralSidetones_A8774;

		// Token: 0x04005933 RID: 22835
		internal global::AcpUI.AcpComboBox CnvSysGeneralSidetones_A8774;

		// Token: 0x04005934 RID: 22836
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysGeneralSidetones_A8774;

		// Token: 0x04005935 RID: 22837
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysGeneralSidetones_A8774;

		// Token: 0x04005936 RID: 22838
		internal global::AcpUI.AcpLabel CnvSysGeneralSidetones_A8774Comp;

		// Token: 0x04005937 RID: 22839
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysGeneralSystemPretimems2_A9246;

		// Token: 0x04005938 RID: 22840
		internal global::AcpUI.AcpLabel LblCnvSysGeneralSystemPretimems2_A9246;

		// Token: 0x04005939 RID: 22841
		internal global::AcpUI.AcpTextBoxSpinner CnvSysGeneralSystemPretimems2_A9246;

		// Token: 0x0400593A RID: 22842
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysGeneralSystemPretimems2_A9246;

		// Token: 0x0400593B RID: 22843
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysGeneralSystemPretimems2_A9246;

		// Token: 0x0400593C RID: 22844
		internal global::AcpUI.AcpLabel CnvSysGeneralSystemPretimems2_A9246Comp;

		// Token: 0x0400593D RID: 22845
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysGeneralAckPretimems_A7393;

		// Token: 0x0400593E RID: 22846
		internal global::AcpUI.AcpLabel LblCnvSysGeneralAckPretimems_A7393;

		// Token: 0x0400593F RID: 22847
		internal global::AcpUI.AcpTextBoxSpinner CnvSysGeneralAckPretimems_A7393;

		// Token: 0x04005940 RID: 22848
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysGeneralAckPretimems_A7393;

		// Token: 0x04005941 RID: 22849
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysGeneralAckPretimems_A7393;

		// Token: 0x04005942 RID: 22850
		internal global::AcpUI.AcpLabel CnvSysGeneralAckPretimems_A7393Comp;

		// Token: 0x04005943 RID: 22851
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysGeneralInterPacketTimems_A8312;

		// Token: 0x04005944 RID: 22852
		internal global::AcpUI.AcpLabel LblCnvSysGeneralInterPacketTimems_A8312;

		// Token: 0x04005945 RID: 22853
		internal global::AcpUI.AcpTextBoxSpinner CnvSysGeneralInterPacketTimems_A8312;

		// Token: 0x04005946 RID: 22854
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysGeneralInterPacketTimems_A8312;

		// Token: 0x04005947 RID: 22855
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysGeneralInterPacketTimems_A8312;

		// Token: 0x04005948 RID: 22856
		internal global::AcpUI.AcpLabel CnvSysGeneralInterPacketTimems_A8312Comp;

		// Token: 0x04005949 RID: 22857
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysGeneralLimitedPatiencesec_A8433;

		// Token: 0x0400594A RID: 22858
		internal global::AcpUI.AcpLabel LblCnvSysGeneralLimitedPatiencesec_A8433;

		// Token: 0x0400594B RID: 22859
		internal global::AcpUI.AcpTextBoxSpinner CnvSysGeneralLimitedPatiencesec_A8433;

		// Token: 0x0400594C RID: 22860
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysGeneralLimitedPatiencesec_A8433;

		// Token: 0x0400594D RID: 22861
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysGeneralLimitedPatiencesec_A8433;

		// Token: 0x0400594E RID: 22862
		internal global::AcpUI.AcpLabel CnvSysGeneralLimitedPatiencesec_A8433Comp;

		// Token: 0x0400594F RID: 22863
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysGeneralEmergencyProfileSelection_A19421;

		// Token: 0x04005950 RID: 22864
		internal global::AcpUI.AcpLabel LblCnvSysGeneralEmergencyProfileSelection_A19421;

		// Token: 0x04005951 RID: 22865
		internal global::AcpUI.AcpComboBox CnvSysGeneralEmergencyProfileSelection_A19421;

		// Token: 0x04005952 RID: 22866
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysGeneralEmergencyProfileSelection_A19421;

		// Token: 0x04005953 RID: 22867
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysGeneralEmergencyProfileSelection_A19421;

		// Token: 0x04005954 RID: 22868
		internal global::AcpUI.AcpLabel CnvSysGeneralEmergencyProfileSelection_A19421Comp;

		// Token: 0x04005955 RID: 22869
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysGeneralDataProfileSelection_A13266;

		// Token: 0x04005956 RID: 22870
		internal global::AcpUI.AcpLabel LblCnvSysGeneralDataProfileSelection_A13266;

		// Token: 0x04005957 RID: 22871
		internal global::AcpUI.AcpComboBox CnvSysGeneralDataProfileSelection_A13266;

		// Token: 0x04005958 RID: 22872
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysGeneralDataProfileSelection_A13266;

		// Token: 0x04005959 RID: 22873
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysGeneralDataProfileSelection_A13266;

		// Token: 0x0400595A RID: 22874
		internal global::AcpUI.AcpLabel CnvSysGeneralDataProfileSelection_A13266Comp;

		// Token: 0x0400595B RID: 22875
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysGeneralRepeaterAccessPretimems_A8741;

		// Token: 0x0400595C RID: 22876
		internal global::AcpUI.AcpLabel LblCnvSysGeneralRepeaterAccessPretimems_A8741;

		// Token: 0x0400595D RID: 22877
		internal global::AcpUI.AcpTextBoxSpinner CnvSysGeneralRepeaterAccessPretimems_A8741;

		// Token: 0x0400595E RID: 22878
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysGeneralRepeaterAccessPretimems_A8741;

		// Token: 0x0400595F RID: 22879
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysGeneralRepeaterAccessPretimems_A8741;

		// Token: 0x04005960 RID: 22880
		internal global::AcpUI.AcpLabel CnvSysGeneralRepeaterAccessPretimems_A8741Comp;

		// Token: 0x04005961 RID: 22881
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysLabtoolPreambleEnable_A19576;

		// Token: 0x04005962 RID: 22882
		internal global::AcpUI.AcpLabel LblCnvSysLabtoolPreambleEnable_A19576;

		// Token: 0x04005963 RID: 22883
		internal global::AcpUI.AcpCheckBox CnvSysLabtoolPreambleEnable_A19576;

		// Token: 0x04005964 RID: 22884
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysLabtoolPreambleEnable_A19576;

		// Token: 0x04005965 RID: 22885
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysLabtoolPreambleEnable_A19576;

		// Token: 0x04005966 RID: 22886
		internal global::AcpUI.AcpCheckBox CnvSysLabtoolPreambleEnable_A19576Comp;

		// Token: 0x04005967 RID: 22887
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysGeneralPreambles_A8731;

		// Token: 0x04005968 RID: 22888
		internal global::AcpUI.AcpLabel LblCnvSysGeneralPreambles_A8731;

		// Token: 0x04005969 RID: 22889
		internal global::AcpUI.AcpTextBoxSpinner CnvSysGeneralPreambles_A8731;

		// Token: 0x0400596A RID: 22890
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysGeneralPreambles_A8731;

		// Token: 0x0400596B RID: 22891
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysGeneralPreambles_A8731;

		// Token: 0x0400596C RID: 22892
		internal global::AcpUI.AcpLabel CnvSysGeneralPreambles_A8731Comp;

		// Token: 0x0400596D RID: 22893
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalSystemGeneralTxTone;

		// Token: 0x0400596E RID: 22894
		internal global::AcpUI.AcpExpander ExpanderConventionalSystemQuikCallII;

		// Token: 0x0400596F RID: 22895
		internal global::AcpUI.AcpChildRecNavToolbar RecNavToolbarExpanderConventionalSystemIndividualIDTones;

		// Token: 0x04005970 RID: 22896
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalSystemQuikCallIIPseudo0;

		// Token: 0x04005971 RID: 22897
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysQCIIDecode;

		// Token: 0x04005972 RID: 22898
		internal global::AcpUI.AcpLabel LblCnvSysQCIIDecode;

		// Token: 0x04005973 RID: 22899
		internal global::AcpUI.AcpCheckBox CnvSysQCIIDecode;

		// Token: 0x04005974 RID: 22900
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysQCIIDecode;

		// Token: 0x04005975 RID: 22901
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysQCIIDecode;

		// Token: 0x04005976 RID: 22902
		internal global::AcpUI.AcpCheckBox CnvSysQCIIDecodeComp;

		// Token: 0x04005977 RID: 22903
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysGeneralQc2CallFormat_A42230;

		// Token: 0x04005978 RID: 22904
		internal global::AcpUI.AcpLabel LblCnvSysGeneralQc2CallFormat_A42230;

		// Token: 0x04005979 RID: 22905
		internal global::AcpUI.AcpComboBox CnvSysGeneralQc2CallFormat_A42230;

		// Token: 0x0400597A RID: 22906
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysGeneralQc2CallFormat_A42230;

		// Token: 0x0400597B RID: 22907
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysGeneralQc2CallFormat_A42230;

		// Token: 0x0400597C RID: 22908
		internal global::AcpUI.AcpLabel CnvSysGeneralQc2CallFormat_A42230Comp;

		// Token: 0x0400597D RID: 22909
		internal global::System.Windows.Controls.Grid ExpanderConventionalSystemQuikCallIIGrid;

		// Token: 0x0400597E RID: 22910
		internal global::System.Windows.Controls.Grid ExpanderConventionalSystemIndividualIDTonesGrid;

		// Token: 0x0400597F RID: 22911
		internal global::AcpUI.AcpGroupBox ExpanderConventionalSystemIndividualIDTonesTableView;

		// Token: 0x04005980 RID: 22912
		internal global::AcpUI.AcpXamDataPresenter ExpanderConventionalSystemIndividualIDTones;

		// Token: 0x04005981 RID: 22913
		internal global::Infragistics.Windows.DataPresenter.UnboundField CnvSysGeneralQc2Name_A42231_Col;

		// Token: 0x04005982 RID: 22914
		internal global::Infragistics.Windows.DataPresenter.UnboundField CnvSysGeneralQc2Freq_A42232_Col;

		// Token: 0x04005983 RID: 22915
		internal global::Infragistics.Windows.DataPresenter.UnboundField CnvSysGeneralQc2Code_A42234_Col;

		// Token: 0x04005984 RID: 22916
		internal global::AcpUI.AcpGroupBox ExpanderConventionalSystemIndividualIDTonesSRecView;

		// Token: 0x04005985 RID: 22917
		internal global::System.Windows.Controls.Grid gridExpanderConventionalSystemIndividualIDTonesSRecView;

		// Token: 0x04005986 RID: 22918
		internal global::AcpUI.AcpLabel CnvSysGeneralQc2Name_A42231;

		// Token: 0x04005987 RID: 22919
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysGeneralQc2Name_A42231;

		// Token: 0x04005988 RID: 22920
		internal global::AcpUI.AcpLabel LblCnvSysGeneralQc2Name_A42231;

		// Token: 0x04005989 RID: 22921
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysGeneralQc2Name_A42231;

		// Token: 0x0400598A RID: 22922
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysGeneralQc2Name_A42231;

		// Token: 0x0400598B RID: 22923
		internal global::AcpUI.AcpLabel CnvSysGeneralQc2Name_A42231Comp;

		// Token: 0x0400598C RID: 22924
		internal global::AcpUI.AcpTextBoxSpinner CnvSysGeneralQc2Freq_A42232;

		// Token: 0x0400598D RID: 22925
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysGeneralQc2Freq_A42232;

		// Token: 0x0400598E RID: 22926
		internal global::AcpUI.AcpLabel LblCnvSysGeneralQc2Freq_A42232;

		// Token: 0x0400598F RID: 22927
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysGeneralQc2Freq_A42232;

		// Token: 0x04005990 RID: 22928
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysGeneralQc2Freq_A42232;

		// Token: 0x04005991 RID: 22929
		internal global::AcpUI.AcpLabel CnvSysGeneralQc2Freq_A42232Comp;

		// Token: 0x04005992 RID: 22930
		internal global::AcpUI.AcpComboBox CnvSysGeneralQc2Code_A42234;

		// Token: 0x04005993 RID: 22931
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysGeneralQc2Code_A42234;

		// Token: 0x04005994 RID: 22932
		internal global::AcpUI.AcpLabel LblCnvSysGeneralQc2Code_A42234;

		// Token: 0x04005995 RID: 22933
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysGeneralQc2Code_A42234;

		// Token: 0x04005996 RID: 22934
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysGeneralQc2Code_A42234;

		// Token: 0x04005997 RID: 22935
		internal global::AcpUI.AcpLabel CnvSysGeneralQc2Code_A42234Comp;

		// Token: 0x04005998 RID: 22936
		internal global::AcpUI.AcpExpander ExpanderConventionalSystemDVRS;

		// Token: 0x04005999 RID: 22937
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalSystemDVRSPseudo0;

		// Token: 0x0400599A RID: 22938
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysDVRSTalkPermitTone_A40124;

		// Token: 0x0400599B RID: 22939
		internal global::AcpUI.AcpLabel LblCnvSysDVRSTalkPermitTone_A40124;

		// Token: 0x0400599C RID: 22940
		internal global::AcpUI.AcpCheckBox CnvSysDVRSTalkPermitTone_A40124;

		// Token: 0x0400599D RID: 22941
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysDVRSTalkPermitTone_A40124;

		// Token: 0x0400599E RID: 22942
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysDVRSTalkPermitTone_A40124;

		// Token: 0x0400599F RID: 22943
		internal global::AcpUI.AcpCheckBox CnvSysDVRSTalkPermitTone_A40124Comp;

		// Token: 0x040059A0 RID: 22944
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysDVRSDVRSyncNACMatching_44811;

		// Token: 0x040059A1 RID: 22945
		internal global::AcpUI.AcpLabel LblCnvSysDVRSDVRSyncNACMatching_44811;

		// Token: 0x040059A2 RID: 22946
		internal global::AcpUI.AcpCheckBox CnvSysDVRSDVRSyncNACMatching_44811;

		// Token: 0x040059A3 RID: 22947
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysDVRSDVRSyncNACMatching_44811;

		// Token: 0x040059A4 RID: 22948
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysDVRSDVRSyncNACMatching_44811;

		// Token: 0x040059A5 RID: 22949
		internal global::AcpUI.AcpCheckBox CnvSysDVRSDVRSyncNACMatching_44811Comp;

		// Token: 0x040059A6 RID: 22950
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysDVRSEmerBlockInFS_A40143;

		// Token: 0x040059A7 RID: 22951
		internal global::AcpUI.AcpLabel LblCnvSysDVRSEmerBlockInFS_A40143;

		// Token: 0x040059A8 RID: 22952
		internal global::AcpUI.AcpCheckBox CnvSysDVRSEmerBlockInFS_A40143;

		// Token: 0x040059A9 RID: 22953
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysDVRSEmerBlockInFS_A40143;

		// Token: 0x040059AA RID: 22954
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysDVRSEmerBlockInFS_A40143;

		// Token: 0x040059AB RID: 22955
		internal global::AcpUI.AcpCheckBox CnvSysDVRSEmerBlockInFS_A40143Comp;

		// Token: 0x040059AC RID: 22956
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysFeatureCallType_A40147;

		// Token: 0x040059AD RID: 22957
		internal global::AcpUI.AcpLabel LblCnvSysFeatureCallType_A40147;

		// Token: 0x040059AE RID: 22958
		internal global::AcpUI.AcpComboBox CnvSysFeatureCallType_A40147;

		// Token: 0x040059AF RID: 22959
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysFeatureCallType_A40147;

		// Token: 0x040059B0 RID: 22960
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysFeatureCallType_A40147;

		// Token: 0x040059B1 RID: 22961
		internal global::AcpUI.AcpLabel CnvSysFeatureCallType_A40147Comp;

		// Token: 0x040059B2 RID: 22962
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysDVRSTAAfterDVRSNoCommAttempts_A40125;

		// Token: 0x040059B3 RID: 22963
		internal global::AcpUI.AcpLabel LblCnvSysDVRSTAAfterDVRSNoCommAttempts_A40125;

		// Token: 0x040059B4 RID: 22964
		internal global::AcpUI.AcpComboBox CnvSysDVRSTAAfterDVRSNoCommAttempts_A40125;

		// Token: 0x040059B5 RID: 22965
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysDVRSTAAfterDVRSNoCommAttempts_A40125;

		// Token: 0x040059B6 RID: 22966
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysDVRSTAAfterDVRSNoCommAttempts_A40125;

		// Token: 0x040059B7 RID: 22967
		internal global::AcpUI.AcpLabel CnvSysDVRSTAAfterDVRSNoCommAttempts_A40125Comp;

		// Token: 0x040059B8 RID: 22968
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysDVRSPreferTalkaroundInNoComms_44810;

		// Token: 0x040059B9 RID: 22969
		internal global::AcpUI.AcpLabel LblCnvSysDVRSPreferTalkaroundInNoComms_44810;

		// Token: 0x040059BA RID: 22970
		internal global::AcpUI.AcpCheckBox CnvSysDVRSPreferTalkaroundInNoComms_44810;

		// Token: 0x040059BB RID: 22971
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysDVRSPreferTalkaroundInNoComms_44810;

		// Token: 0x040059BC RID: 22972
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysDVRSPreferTalkaroundInNoComms_44810;

		// Token: 0x040059BD RID: 22973
		internal global::AcpUI.AcpCheckBox CnvSysDVRSPreferTalkaroundInNoComms_44810Comp;

		// Token: 0x040059BE RID: 22974
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysTalkaroundAudioModes_44812;

		// Token: 0x040059BF RID: 22975
		internal global::AcpUI.AcpLabel LblCnvSysTalkaroundAudioModes_44812;

		// Token: 0x040059C0 RID: 22976
		internal global::AcpUI.AcpComboBox CnvSysTalkaroundAudioModes_44812;

		// Token: 0x040059C1 RID: 22977
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysTalkaroundAudioModes_44812;

		// Token: 0x040059C2 RID: 22978
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysTalkaroundAudioModes_44812;

		// Token: 0x040059C3 RID: 22979
		internal global::AcpUI.AcpLabel CnvSysTalkaroundAudioModes_44812Comp;

		// Token: 0x040059C4 RID: 22980
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysDVRSOutOfDVRSRangeTime_A40127;

		// Token: 0x040059C5 RID: 22981
		internal global::AcpUI.AcpLabel LblCnvSysDVRSOutOfDVRSRangeTime_A40127;

		// Token: 0x040059C6 RID: 22982
		internal global::AcpUI.AcpTextBoxSpinner CnvSysDVRSOutOfDVRSRangeTime_A40127;

		// Token: 0x040059C7 RID: 22983
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysDVRSOutOfDVRSRangeTime_A40127;

		// Token: 0x040059C8 RID: 22984
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysDVRSOutOfDVRSRangeTime_A40127;

		// Token: 0x040059C9 RID: 22985
		internal global::AcpUI.AcpLabel CnvSysDVRSOutOfDVRSRangeTime_A40127Comp;

		// Token: 0x040059CA RID: 22986
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysDVRSEndOutOfRangeOnAnalogRx_A40143;

		// Token: 0x040059CB RID: 22987
		internal global::AcpUI.AcpLabel LblCnvSysDVRSEndOutOfRangeOnAnalogRx_A40143;

		// Token: 0x040059CC RID: 22988
		internal global::AcpUI.AcpCheckBox CnvSysDVRSEndOutOfRangeOnAnalogRx_A40143;

		// Token: 0x040059CD RID: 22989
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysDVRSEndOutOfRangeOnAnalogRx_A40143;

		// Token: 0x040059CE RID: 22990
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysDVRSEndOutOfRangeOnAnalogRx_A40143;

		// Token: 0x040059CF RID: 22991
		internal global::AcpUI.AcpCheckBox CnvSysDVRSEndOutOfRangeOnAnalogRx_A40143Comp;

		// Token: 0x040059D0 RID: 22992
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysDVRSAttachRetryTime_A40141;

		// Token: 0x040059D1 RID: 22993
		internal global::AcpUI.AcpLabel LblCnvSysDVRSAttachRetryTime_A40141;

		// Token: 0x040059D2 RID: 22994
		internal global::AcpUI.AcpTextBoxSpinner CnvSysDVRSAttachRetryTime_A40141;

		// Token: 0x040059D3 RID: 22995
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysDVRSAttachRetryTime_A40141;

		// Token: 0x040059D4 RID: 22996
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysDVRSAttachRetryTime_A40141;

		// Token: 0x040059D5 RID: 22997
		internal global::AcpUI.AcpLabel CnvSysDVRSAttachRetryTime_A40141Comp;

		// Token: 0x040059D6 RID: 22998
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysDVRSAttachRetries_A40142;

		// Token: 0x040059D7 RID: 22999
		internal global::AcpUI.AcpLabel LblCnvSysDVRSAttachRetries_A40142;

		// Token: 0x040059D8 RID: 23000
		internal global::AcpUI.AcpTextBoxSpinner CnvSysDVRSAttachRetries_A40142;

		// Token: 0x040059D9 RID: 23001
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysDVRSAttachRetries_A40142;

		// Token: 0x040059DA RID: 23002
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysDVRSAttachRetries_A40142;

		// Token: 0x040059DB RID: 23003
		internal global::AcpUI.AcpLabel CnvSysDVRSAttachRetries_A40142Comp;

		// Token: 0x040059DC RID: 23004
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445;

		// Token: 0x040059DD RID: 23005
		internal global::AcpUI.AcpLabel LblCnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445;

		// Token: 0x040059DE RID: 23006
		internal global::AcpUI.AcpCheckBox CnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445;

		// Token: 0x040059DF RID: 23007
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445;

		// Token: 0x040059E0 RID: 23008
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445;

		// Token: 0x040059E1 RID: 23009
		internal global::AcpUI.AcpCheckBox CnvSysDVRSBypassQuickKeyVoiceChannelAccess_42445Comp;

		// Token: 0x040059E2 RID: 23010
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysDVRSPhase2SysCompatibility_43000;

		// Token: 0x040059E3 RID: 23011
		internal global::AcpUI.AcpLabel LblCnvSysDVRSPhase2SysCompatibility_43000;

		// Token: 0x040059E4 RID: 23012
		internal global::AcpUI.AcpCheckBox CnvSysDVRSPhase2SysCompatibility_43000;

		// Token: 0x040059E5 RID: 23013
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysDVRSPhase2SysCompatibility_43000;

		// Token: 0x040059E6 RID: 23014
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysDVRSPhase2SysCompatibility_43000;

		// Token: 0x040059E7 RID: 23015
		internal global::AcpUI.AcpCheckBox CnvSysDVRSPhase2SysCompatibility_43000Comp;

		// Token: 0x040059E8 RID: 23016
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalSystemDVRSDynamicRegrouping;

		// Token: 0x040059E9 RID: 23017
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysFeatureDynRegroupEn_A40146;

		// Token: 0x040059EA RID: 23018
		internal global::AcpUI.AcpLabel LblCnvSysFeatureDynRegroupEn_A40146;

		// Token: 0x040059EB RID: 23019
		internal global::AcpUI.AcpCheckBox CnvSysFeatureDynRegroupEn_A40146;

		// Token: 0x040059EC RID: 23020
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysFeatureDynRegroupEn_A40146;

		// Token: 0x040059ED RID: 23021
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysFeatureDynRegroupEn_A40146;

		// Token: 0x040059EE RID: 23022
		internal global::AcpUI.AcpCheckBox CnvSysFeatureDynRegroupEn_A40146Comp;

		// Token: 0x040059EF RID: 23023
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysFeatureDynRegroupZone_A40145;

		// Token: 0x040059F0 RID: 23024
		internal global::AcpUI.AcpLabel LblCnvSysFeatureDynRegroupZone_A40145;

		// Token: 0x040059F1 RID: 23025
		internal global::AcpUI.AcpComboBox CnvSysFeatureDynRegroupZone_A40145;

		// Token: 0x040059F2 RID: 23026
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysFeatureDynRegroupZone_A40145;

		// Token: 0x040059F3 RID: 23027
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysFeatureDynRegroupZone_A40145;

		// Token: 0x040059F4 RID: 23028
		internal global::AcpUI.AcpLabel CnvSysFeatureDynRegroupZone_A40145Comp;

		// Token: 0x040059F5 RID: 23029
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysFeatureDynRegroupChannel_A40144;

		// Token: 0x040059F6 RID: 23030
		internal global::AcpUI.AcpLabel LblCnvSysFeatureDynRegroupChannel_A40144;

		// Token: 0x040059F7 RID: 23031
		internal global::AcpUI.AcpComboBox CnvSysFeatureDynRegroupChannel_A40144;

		// Token: 0x040059F8 RID: 23032
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysFeatureDynRegroupChannel_A40144;

		// Token: 0x040059F9 RID: 23033
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysFeatureDynRegroupChannel_A40144;

		// Token: 0x040059FA RID: 23034
		internal global::AcpUI.AcpLabel CnvSysFeatureDynRegroupChannel_A40144Comp;

		// Token: 0x040059FB RID: 23035
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalSystemDVRSTimers;

		// Token: 0x040059FC RID: 23036
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysDVRSIndCallMaxTargetRingTime_A40139;

		// Token: 0x040059FD RID: 23037
		internal global::AcpUI.AcpLabel LblCnvSysDVRSIndCallMaxTargetRingTime_A40139;

		// Token: 0x040059FE RID: 23038
		internal global::AcpUI.AcpTextBoxSpinner CnvSysDVRSIndCallMaxTargetRingTime_A40139;

		// Token: 0x040059FF RID: 23039
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysDVRSIndCallMaxTargetRingTime_A40139;

		// Token: 0x04005A00 RID: 23040
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysDVRSIndCallMaxTargetRingTime_A40139;

		// Token: 0x04005A01 RID: 23041
		internal global::AcpUI.AcpLabel CnvSysDVRSIndCallMaxTargetRingTime_A40139Comp;

		// Token: 0x04005A02 RID: 23042
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysDVRSPrivateCallMaxInitRingTime_A40140;

		// Token: 0x04005A03 RID: 23043
		internal global::AcpUI.AcpLabel LblCnvSysDVRSPrivateCallMaxInitRingTime_A40140;

		// Token: 0x04005A04 RID: 23044
		internal global::AcpUI.AcpTextBoxSpinner CnvSysDVRSPrivateCallMaxInitRingTime_A40140;

		// Token: 0x04005A05 RID: 23045
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysDVRSPrivateCallMaxInitRingTime_A40140;

		// Token: 0x04005A06 RID: 23046
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysDVRSPrivateCallMaxInitRingTime_A40140;

		// Token: 0x04005A07 RID: 23047
		internal global::AcpUI.AcpLabel CnvSysDVRSPrivateCallMaxInitRingTime_A40140Comp;

		// Token: 0x04005A08 RID: 23048
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysDVRSForceUnmuteTime_A40138;

		// Token: 0x04005A09 RID: 23049
		internal global::AcpUI.AcpLabel LblCnvSysDVRSForceUnmuteTime_A40138;

		// Token: 0x04005A0A RID: 23050
		internal global::AcpUI.AcpTextBoxSpinner CnvSysDVRSForceUnmuteTime_A40138;

		// Token: 0x04005A0B RID: 23051
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysDVRSForceUnmuteTime_A40138;

		// Token: 0x04005A0C RID: 23052
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysDVRSForceUnmuteTime_A40138;

		// Token: 0x04005A0D RID: 23053
		internal global::AcpUI.AcpLabel CnvSysDVRSForceUnmuteTime_A40138Comp;

		// Token: 0x04005A0E RID: 23054
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysDVRSPTTWarningTime_A40131;

		// Token: 0x04005A0F RID: 23055
		internal global::AcpUI.AcpLabel LblCnvSysDVRSPTTWarningTime_A40131;

		// Token: 0x04005A10 RID: 23056
		internal global::AcpUI.AcpTextBoxSpinner CnvSysDVRSPTTWarningTime_A40131;

		// Token: 0x04005A11 RID: 23057
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysDVRSPTTWarningTime_A40131;

		// Token: 0x04005A12 RID: 23058
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysDVRSPTTWarningTime_A40131;

		// Token: 0x04005A13 RID: 23059
		internal global::AcpUI.AcpLabel CnvSysDVRSPTTWarningTime_A40131Comp;

		// Token: 0x04005A14 RID: 23060
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysDVRSBusyUpdateTime_A40130;

		// Token: 0x04005A15 RID: 23061
		internal global::AcpUI.AcpLabel LblCnvSysDVRSBusyUpdateTime_A40130;

		// Token: 0x04005A16 RID: 23062
		internal global::AcpUI.AcpTextBoxSpinner CnvSysDVRSBusyUpdateTime_A40130;

		// Token: 0x04005A17 RID: 23063
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysDVRSBusyUpdateTime_A40130;

		// Token: 0x04005A18 RID: 23064
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysDVRSBusyUpdateTime_A40130;

		// Token: 0x04005A19 RID: 23065
		internal global::AcpUI.AcpLabel CnvSysDVRSBusyUpdateTime_A40130Comp;

		// Token: 0x04005A1A RID: 23066
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysDVRSRespPendingTime_A40129;

		// Token: 0x04005A1B RID: 23067
		internal global::AcpUI.AcpLabel LblCnvSysDVRSRespPendingTime_A40129;

		// Token: 0x04005A1C RID: 23068
		internal global::AcpUI.AcpTextBoxSpinner CnvSysDVRSRespPendingTime_A40129;

		// Token: 0x04005A1D RID: 23069
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysDVRSRespPendingTime_A40129;

		// Token: 0x04005A1E RID: 23070
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysDVRSRespPendingTime_A40129;

		// Token: 0x04005A1F RID: 23071
		internal global::AcpUI.AcpLabel CnvSysDVRSRespPendingTime_A40129Comp;

		// Token: 0x04005A20 RID: 23072
		internal global::AcpUI.AcpExpander ExpanderConventionalSystemFeatures;

		// Token: 0x04005A21 RID: 23073
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalSystemFeaturesPseudo0;

		// Token: 0x04005A22 RID: 23074
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysFeaturesRadioInhibit_A8831;

		// Token: 0x04005A23 RID: 23075
		internal global::AcpUI.AcpLabel LblCnvSysFeaturesRadioInhibit_A8831;

		// Token: 0x04005A24 RID: 23076
		internal global::AcpUI.AcpCheckBox CnvSysFeaturesRadioInhibit_A8831;

		// Token: 0x04005A25 RID: 23077
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysFeaturesRadioInhibit_A8831;

		// Token: 0x04005A26 RID: 23078
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysFeaturesRadioInhibit_A8831;

		// Token: 0x04005A27 RID: 23079
		internal global::AcpUI.AcpCheckBox CnvSysFeaturesRadioInhibit_A8831Comp;

		// Token: 0x04005A28 RID: 23080
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysFeaturesRadioCheck_A8826;

		// Token: 0x04005A29 RID: 23081
		internal global::AcpUI.AcpLabel LblCnvSysFeaturesRadioCheck_A8826;

		// Token: 0x04005A2A RID: 23082
		internal global::AcpUI.AcpCheckBox CnvSysFeaturesRadioCheck_A8826;

		// Token: 0x04005A2B RID: 23083
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysFeaturesRadioCheck_A8826;

		// Token: 0x04005A2C RID: 23084
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysFeaturesRadioCheck_A8826;

		// Token: 0x04005A2D RID: 23085
		internal global::AcpUI.AcpCheckBox CnvSysFeaturesRadioCheck_A8826Comp;

		// Token: 0x04005A2E RID: 23086
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysFeaturesStatus_A9186;

		// Token: 0x04005A2F RID: 23087
		internal global::AcpUI.AcpLabel LblCnvSysFeaturesStatus_A9186;

		// Token: 0x04005A30 RID: 23088
		internal global::AcpUI.AcpCheckBox CnvSysFeaturesStatus_A9186;

		// Token: 0x04005A31 RID: 23089
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysFeaturesStatus_A9186;

		// Token: 0x04005A32 RID: 23090
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysFeaturesStatus_A9186;

		// Token: 0x04005A33 RID: 23091
		internal global::AcpUI.AcpCheckBox CnvSysFeaturesStatus_A9186Comp;

		// Token: 0x04005A34 RID: 23092
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysFeaturesStatusRequest_A9198;

		// Token: 0x04005A35 RID: 23093
		internal global::AcpUI.AcpLabel LblCnvSysFeaturesStatusRequest_A9198;

		// Token: 0x04005A36 RID: 23094
		internal global::AcpUI.AcpCheckBox CnvSysFeaturesStatusRequest_A9198;

		// Token: 0x04005A37 RID: 23095
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysFeaturesStatusRequest_A9198;

		// Token: 0x04005A38 RID: 23096
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysFeaturesStatusRequest_A9198;

		// Token: 0x04005A39 RID: 23097
		internal global::AcpUI.AcpCheckBox CnvSysFeaturesStatusRequest_A9198Comp;

		// Token: 0x04005A3A RID: 23098
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysFeaturesMessage_A8497;

		// Token: 0x04005A3B RID: 23099
		internal global::AcpUI.AcpLabel LblCnvSysFeaturesMessage_A8497;

		// Token: 0x04005A3C RID: 23100
		internal global::AcpUI.AcpCheckBox CnvSysFeaturesMessage_A8497;

		// Token: 0x04005A3D RID: 23101
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysFeaturesMessage_A8497;

		// Token: 0x04005A3E RID: 23102
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysFeaturesMessage_A8497;

		// Token: 0x04005A3F RID: 23103
		internal global::AcpUI.AcpCheckBox CnvSysFeaturesMessage_A8497Comp;

		// Token: 0x04005A40 RID: 23104
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysFeaturesDynamicIDEnable_A40100;

		// Token: 0x04005A41 RID: 23105
		internal global::AcpUI.AcpLabel LblCnvSysFeaturesDynamicIDEnable_A40100;

		// Token: 0x04005A42 RID: 23106
		internal global::AcpUI.AcpCheckBox CnvSysFeaturesDynamicIDEnable_A40100;

		// Token: 0x04005A43 RID: 23107
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysFeaturesDynamicIDEnable_A40100;

		// Token: 0x04005A44 RID: 23108
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysFeaturesDynamicIDEnable_A40100;

		// Token: 0x04005A45 RID: 23109
		internal global::AcpUI.AcpCheckBox CnvSysFeaturesDynamicIDEnable_A40100Comp;

		// Token: 0x04005A46 RID: 23110
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysFeaturesEmergencyAlarmRxIndicator_A7930;

		// Token: 0x04005A47 RID: 23111
		internal global::AcpUI.AcpLabel LblCnvSysFeaturesEmergencyAlarmRxIndicator_A7930;

		// Token: 0x04005A48 RID: 23112
		internal global::AcpUI.AcpCheckBox CnvSysFeaturesEmergencyAlarmRxIndicator_A7930;

		// Token: 0x04005A49 RID: 23113
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysFeaturesEmergencyAlarmRxIndicator_A7930;

		// Token: 0x04005A4A RID: 23114
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysFeaturesEmergencyAlarmRxIndicator_A7930;

		// Token: 0x04005A4B RID: 23115
		internal global::AcpUI.AcpCheckBox CnvSysFeaturesEmergencyAlarmRxIndicator_A7930Comp;

		// Token: 0x04005A4C RID: 23116
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysFeaturesQualifyEmergencyAlarmRx_A7931;

		// Token: 0x04005A4D RID: 23117
		internal global::AcpUI.AcpLabel LblCnvSysFeaturesQualifyEmergencyAlarmRx_A7931;

		// Token: 0x04005A4E RID: 23118
		internal global::AcpUI.AcpCheckBox CnvSysFeaturesQualifyEmergencyAlarmRx_A7931;

		// Token: 0x04005A4F RID: 23119
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysFeaturesQualifyEmergencyAlarmRx_A7931;

		// Token: 0x04005A50 RID: 23120
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysFeaturesQualifyEmergencyAlarmRx_A7931;

		// Token: 0x04005A51 RID: 23121
		internal global::AcpUI.AcpCheckBox CnvSysFeaturesQualifyEmergencyAlarmRx_A7931Comp;

		// Token: 0x04005A52 RID: 23122
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysFeaturesEmergencyAckEn_A41546;

		// Token: 0x04005A53 RID: 23123
		internal global::AcpUI.AcpLabel LblCnvSysFeaturesEmergencyAckEn_A41546;

		// Token: 0x04005A54 RID: 23124
		internal global::AcpUI.AcpCheckBox CnvSysFeaturesEmergencyAckEn_A41546;

		// Token: 0x04005A55 RID: 23125
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysFeaturesEmergencyAckEn_A41546;

		// Token: 0x04005A56 RID: 23126
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysFeaturesEmergencyAckEn_A41546;

		// Token: 0x04005A57 RID: 23127
		internal global::AcpUI.AcpCheckBox CnvSysFeaturesEmergencyAckEn_A41546Comp;

		// Token: 0x04005A58 RID: 23128
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysDVRSPOP25Enable_A40126;

		// Token: 0x04005A59 RID: 23129
		internal global::AcpUI.AcpLabel LblCnvSysDVRSPOP25Enable_A40126;

		// Token: 0x04005A5A RID: 23130
		internal global::AcpUI.AcpCheckBox CnvSysDVRSPOP25Enable_A40126;

		// Token: 0x04005A5B RID: 23131
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysDVRSPOP25Enable_A40126;

		// Token: 0x04005A5C RID: 23132
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysDVRSPOP25Enable_A40126;

		// Token: 0x04005A5D RID: 23133
		internal global::AcpUI.AcpCheckBox CnvSysDVRSPOP25Enable_A40126Comp;

		// Token: 0x04005A5E RID: 23134
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysFeaturesCAIDataRegistration_A7585;

		// Token: 0x04005A5F RID: 23135
		internal global::AcpUI.AcpLabel LblCnvSysFeaturesCAIDataRegistration_A7585;

		// Token: 0x04005A60 RID: 23136
		internal global::AcpUI.AcpCheckBox CnvSysFeaturesCAIDataRegistration_A7585;

		// Token: 0x04005A61 RID: 23137
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysFeaturesCAIDataRegistration_A7585;

		// Token: 0x04005A62 RID: 23138
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysFeaturesCAIDataRegistration_A7585;

		// Token: 0x04005A63 RID: 23139
		internal global::AcpUI.AcpCheckBox CnvSysFeaturesCAIDataRegistration_A7585Comp;

		// Token: 0x04005A64 RID: 23140
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfFeaturesTextMessagingService_A9372;

		// Token: 0x04005A65 RID: 23141
		internal global::AcpUI.AcpLabel LblDataProfFeaturesTextMessagingService_A9372;

		// Token: 0x04005A66 RID: 23142
		internal global::AcpUI.AcpComboBox DataProfFeaturesTextMessagingService_A9372;

		// Token: 0x04005A67 RID: 23143
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfFeaturesTextMessagingService_A9372;

		// Token: 0x04005A68 RID: 23144
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfFeaturesTextMessagingService_A9372;

		// Token: 0x04005A69 RID: 23145
		internal global::AcpUI.AcpLabel DataProfFeaturesTextMessagingService_A9372Comp;

		// Token: 0x04005A6A RID: 23146
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysFeaturesGroupTMSEable_42809;

		// Token: 0x04005A6B RID: 23147
		internal global::AcpUI.AcpLabel LblCnvSysFeaturesGroupTMSEable_42809;

		// Token: 0x04005A6C RID: 23148
		internal global::AcpUI.AcpComboBox CnvSysFeaturesGroupTMSEable_42809;

		// Token: 0x04005A6D RID: 23149
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysFeaturesGroupTMSEable_42809;

		// Token: 0x04005A6E RID: 23150
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysFeaturesGroupTMSEable_42809;

		// Token: 0x04005A6F RID: 23151
		internal global::AcpUI.AcpLabel CnvSysFeaturesGroupTMSEable_42809Comp;

		// Token: 0x04005A70 RID: 23152
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysFeaturesSendLocationToPeer_42427;

		// Token: 0x04005A71 RID: 23153
		internal global::AcpUI.AcpLabel LblCnvSysFeaturesSendLocationToPeer_42427;

		// Token: 0x04005A72 RID: 23154
		internal global::AcpUI.AcpCheckBox CnvSysFeaturesSendLocationToPeer_42427;

		// Token: 0x04005A73 RID: 23155
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysFeaturesSendLocationToPeer_42427;

		// Token: 0x04005A74 RID: 23156
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysFeaturesSendLocationToPeer_42427;

		// Token: 0x04005A75 RID: 23157
		internal global::AcpUI.AcpCheckBox CnvSysFeaturesSendLocationToPeer_42427Comp;

		// Token: 0x04005A76 RID: 23158
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysFeaturesSelectCallInCallReset_A9102;

		// Token: 0x04005A77 RID: 23159
		internal global::AcpUI.AcpLabel LblCnvSysFeaturesSelectCallInCallReset_A9102;

		// Token: 0x04005A78 RID: 23160
		internal global::AcpUI.AcpComboBox CnvSysFeaturesSelectCallInCallReset_A9102;

		// Token: 0x04005A79 RID: 23161
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysFeaturesSelectCallInCallReset_A9102;

		// Token: 0x04005A7A RID: 23162
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysFeaturesSelectCallInCallReset_A9102;

		// Token: 0x04005A7B RID: 23163
		internal global::AcpUI.AcpLabel CnvSysFeaturesSelectCallInCallReset_A9102Comp;

		// Token: 0x04005A7C RID: 23164
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysFeaturesAutoResetTimesec_A7511;

		// Token: 0x04005A7D RID: 23165
		internal global::AcpUI.AcpLabel LblCnvSysFeaturesAutoResetTimesec_A7511;

		// Token: 0x04005A7E RID: 23166
		internal global::AcpUI.AcpTextBoxSpinner CnvSysFeaturesAutoResetTimesec_A7511;

		// Token: 0x04005A7F RID: 23167
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysFeaturesAutoResetTimesec_A7511;

		// Token: 0x04005A80 RID: 23168
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysFeaturesAutoResetTimesec_A7511;

		// Token: 0x04005A81 RID: 23169
		internal global::AcpUI.AcpLabel CnvSysFeaturesAutoResetTimesec_A7511Comp;

		// Token: 0x04005A82 RID: 23170
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalSystemFeaturesRemoteMonitorRadioTrace;

		// Token: 0x04005A83 RID: 23171
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysFeaturesRemoteRadioMode_A8935;

		// Token: 0x04005A84 RID: 23172
		internal global::AcpUI.AcpLabel LblCnvSysFeaturesRemoteRadioMode_A8935;

		// Token: 0x04005A85 RID: 23173
		internal global::AcpUI.AcpComboBox CnvSysFeaturesRemoteRadioMode_A8935;

		// Token: 0x04005A86 RID: 23174
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysFeaturesRemoteRadioMode_A8935;

		// Token: 0x04005A87 RID: 23175
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysFeaturesRemoteRadioMode_A8935;

		// Token: 0x04005A88 RID: 23176
		internal global::AcpUI.AcpLabel CnvSysFeaturesRemoteRadioMode_A8935Comp;

		// Token: 0x04005A89 RID: 23177
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysFeaturesTxBaseTimeSec_A9513;

		// Token: 0x04005A8A RID: 23178
		internal global::AcpUI.AcpLabel LblCnvSysFeaturesTxBaseTimeSec_A9513;

		// Token: 0x04005A8B RID: 23179
		internal global::AcpUI.AcpTextBoxSpinner CnvSysFeaturesTxBaseTimeSec_A9513;

		// Token: 0x04005A8C RID: 23180
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysFeaturesTxBaseTimeSec_A9513;

		// Token: 0x04005A8D RID: 23181
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysFeaturesTxBaseTimeSec_A9513;

		// Token: 0x04005A8E RID: 23182
		internal global::AcpUI.AcpLabel CnvSysFeaturesTxBaseTimeSec_A9513Comp;

		// Token: 0x04005A8F RID: 23183
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalSystemFeaturesPseudo1;

		// Token: 0x04005A90 RID: 23184
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysFeaturesExtendedDispatchEn_A37220;

		// Token: 0x04005A91 RID: 23185
		internal global::AcpUI.AcpLabel LblCnvSysFeaturesExtendedDispatchEn_A37220;

		// Token: 0x04005A92 RID: 23186
		internal global::AcpUI.AcpCheckBox CnvSysFeaturesExtendedDispatchEn_A37220;

		// Token: 0x04005A93 RID: 23187
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysFeaturesExtendedDispatchEn_A37220;

		// Token: 0x04005A94 RID: 23188
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysFeaturesExtendedDispatchEn_A37220;

		// Token: 0x04005A95 RID: 23189
		internal global::AcpUI.AcpCheckBox CnvSysFeaturesExtendedDispatchEn_A37220Comp;

		// Token: 0x04005A96 RID: 23190
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalSystemFeaturesDataOperatedSquelchEnable;

		// Token: 0x04005A97 RID: 23191
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysFeaturesDataOperatedSquelchDOS_A7796;

		// Token: 0x04005A98 RID: 23192
		internal global::AcpUI.AcpLabel LblCnvSysFeaturesDataOperatedSquelchDOS_A7796;

		// Token: 0x04005A99 RID: 23193
		internal global::AcpUI.AcpCheckBox CnvSysFeaturesDataOperatedSquelchDOS_A7796;

		// Token: 0x04005A9A RID: 23194
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysFeaturesDataOperatedSquelchDOS_A7796;

		// Token: 0x04005A9B RID: 23195
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysFeaturesDataOperatedSquelchDOS_A7796;

		// Token: 0x04005A9C RID: 23196
		internal global::AcpUI.AcpCheckBox CnvSysFeaturesDataOperatedSquelchDOS_A7796Comp;

		// Token: 0x04005A9D RID: 23197
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysFeaturesDOSOperation_A7891;

		// Token: 0x04005A9E RID: 23198
		internal global::AcpUI.AcpLabel LblCnvSysFeaturesDOSOperation_A7891;

		// Token: 0x04005A9F RID: 23199
		internal global::AcpUI.AcpComboBox CnvSysFeaturesDOSOperation_A7891;

		// Token: 0x04005AA0 RID: 23200
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysFeaturesDOSOperation_A7891;

		// Token: 0x04005AA1 RID: 23201
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysFeaturesDOSOperation_A7891;

		// Token: 0x04005AA2 RID: 23202
		internal global::AcpUI.AcpLabel CnvSysFeaturesDOSOperation_A7891Comp;

		// Token: 0x04005AA3 RID: 23203
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysFeaturesDOSCoastTimems_A7890;

		// Token: 0x04005AA4 RID: 23204
		internal global::AcpUI.AcpLabel LblCnvSysFeaturesDOSCoastTimems_A7890;

		// Token: 0x04005AA5 RID: 23205
		internal global::AcpUI.AcpTextBoxSpinner CnvSysFeaturesDOSCoastTimems_A7890;

		// Token: 0x04005AA6 RID: 23206
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysFeaturesDOSCoastTimems_A7890;

		// Token: 0x04005AA7 RID: 23207
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysFeaturesDOSCoastTimems_A7890;

		// Token: 0x04005AA8 RID: 23208
		internal global::AcpUI.AcpLabel CnvSysFeaturesDOSCoastTimems_A7890Comp;

		// Token: 0x04005AA9 RID: 23209
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalSystemFeaturesPseudo2;

		// Token: 0x04005AAA RID: 23210
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysFeaturesPASelection_A42880;

		// Token: 0x04005AAB RID: 23211
		internal global::AcpUI.AcpLabel LblCnvSysFeaturesPASelection_A42880;

		// Token: 0x04005AAC RID: 23212
		internal global::AcpUI.AcpComboBox CnvSysFeaturesPASelection_A42880;

		// Token: 0x04005AAD RID: 23213
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysFeaturesPASelection_A42880;

		// Token: 0x04005AAE RID: 23214
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysFeaturesPASelection_A42880;

		// Token: 0x04005AAF RID: 23215
		internal global::AcpUI.AcpLabel CnvSysFeaturesPASelection_A42880Comp;

		// Token: 0x04005AB0 RID: 23216
		internal global::AcpUI.AcpExpander ExpanderConventionalSystemSecure;

		// Token: 0x04005AB1 RID: 23217
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalSystemSecurePseudo0;

		// Token: 0x04005AB2 RID: 23218
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysSecureKMFProfIndex_A40132;

		// Token: 0x04005AB3 RID: 23219
		internal global::AcpUI.AcpLabel LblCnvSysSecureKMFProfIndex_A40132;

		// Token: 0x04005AB4 RID: 23220
		internal global::AcpUI.AcpComboBox CnvSysSecureKMFProfIndex_A40132;

		// Token: 0x04005AB5 RID: 23221
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysSecureKMFProfIndex_A40132;

		// Token: 0x04005AB6 RID: 23222
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysSecureKMFProfIndex_A40132;

		// Token: 0x04005AB7 RID: 23223
		internal global::AcpUI.AcpLabel CnvSysSecureKMFProfIndex_A40132Comp;

		// Token: 0x04005AB8 RID: 23224
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysSecurePatchKeySel_A40136;

		// Token: 0x04005AB9 RID: 23225
		internal global::AcpUI.AcpLabel LblCnvSysSecurePatchKeySel_A40136;

		// Token: 0x04005ABA RID: 23226
		internal global::AcpUI.AcpComboBox CnvSysSecurePatchKeySel_A40136;

		// Token: 0x04005ABB RID: 23227
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysSecurePatchKeySel_A40136;

		// Token: 0x04005ABC RID: 23228
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysSecurePatchKeySel_A40136;

		// Token: 0x04005ABD RID: 23229
		internal global::AcpUI.AcpLabel CnvSysSecurePatchKeySel_A40136Comp;

		// Token: 0x04005ABE RID: 23230
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysSecureFSKeySel_A40134;

		// Token: 0x04005ABF RID: 23231
		internal global::AcpUI.AcpLabel LblCnvSysSecureFSKeySel_A40134;

		// Token: 0x04005AC0 RID: 23232
		internal global::AcpUI.AcpComboBox CnvSysSecureFSKeySel_A40134;

		// Token: 0x04005AC1 RID: 23233
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysSecureFSKeySel_A40134;

		// Token: 0x04005AC2 RID: 23234
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysSecureFSKeySel_A40134;

		// Token: 0x04005AC3 RID: 23235
		internal global::AcpUI.AcpLabel CnvSysSecureFSKeySel_A40134Comp;

		// Token: 0x04005AC4 RID: 23236
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysSecurePrivateCallKeySel_A40137;

		// Token: 0x04005AC5 RID: 23237
		internal global::AcpUI.AcpLabel LblCnvSysSecurePrivateCallKeySel_A40137;

		// Token: 0x04005AC6 RID: 23238
		internal global::AcpUI.AcpComboBox CnvSysSecurePrivateCallKeySel_A40137;

		// Token: 0x04005AC7 RID: 23239
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysSecurePrivateCallKeySel_A40137;

		// Token: 0x04005AC8 RID: 23240
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysSecurePrivateCallKeySel_A40137;

		// Token: 0x04005AC9 RID: 23241
		internal global::AcpUI.AcpLabel CnvSysSecurePrivateCallKeySel_A40137Comp;

		// Token: 0x04005ACA RID: 23242
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysSecureInterConnectKeySel_A40135;

		// Token: 0x04005ACB RID: 23243
		internal global::AcpUI.AcpLabel LblCnvSysSecureInterConnectKeySel_A40135;

		// Token: 0x04005ACC RID: 23244
		internal global::AcpUI.AcpComboBox CnvSysSecureInterConnectKeySel_A40135;

		// Token: 0x04005ACD RID: 23245
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysSecureInterConnectKeySel_A40135;

		// Token: 0x04005ACE RID: 23246
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysSecureInterConnectKeySel_A40135;

		// Token: 0x04005ACF RID: 23247
		internal global::AcpUI.AcpLabel CnvSysSecureInterConnectKeySel_A40135Comp;

		// Token: 0x04005AD0 RID: 23248
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysSecureDynTGKeySel_A40133;

		// Token: 0x04005AD1 RID: 23249
		internal global::AcpUI.AcpLabel LblCnvSysSecureDynTGKeySel_A40133;

		// Token: 0x04005AD2 RID: 23250
		internal global::AcpUI.AcpComboBox CnvSysSecureDynTGKeySel_A40133;

		// Token: 0x04005AD3 RID: 23251
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysSecureDynTGKeySel_A40133;

		// Token: 0x04005AD4 RID: 23252
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysSecureDynTGKeySel_A40133;

		// Token: 0x04005AD5 RID: 23253
		internal global::AcpUI.AcpLabel CnvSysSecureDynTGKeySel_A40133Comp;

		// Token: 0x04005AD6 RID: 23254
		internal global::AcpUI.AcpExpander ExpanderConventionalSystemLabtool;

		// Token: 0x04005AD7 RID: 23255
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalSystemLabtoolPseudo0;

		// Token: 0x04005AD8 RID: 23256
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysLabtoolRACSidetone_A8820;

		// Token: 0x04005AD9 RID: 23257
		internal global::AcpUI.AcpLabel LblCnvSysLabtoolRACSidetone_A8820;

		// Token: 0x04005ADA RID: 23258
		internal global::AcpUI.AcpCheckBox CnvSysLabtoolRACSidetone_A8820;

		// Token: 0x04005ADB RID: 23259
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysLabtoolRACSidetone_A8820;

		// Token: 0x04005ADC RID: 23260
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysLabtoolRACSidetone_A8820;

		// Token: 0x04005ADD RID: 23261
		internal global::AcpUI.AcpCheckBox CnvSysLabtoolRACSidetone_A8820Comp;

		// Token: 0x04005ADE RID: 23262
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysLabtoolPreambles_A8730;

		// Token: 0x04005ADF RID: 23263
		internal global::AcpUI.AcpLabel LblCnvSysLabtoolPreambles_A8730;

		// Token: 0x04005AE0 RID: 23264
		internal global::AcpUI.AcpTextBoxSpinner CnvSysLabtoolPreambles_A8730;

		// Token: 0x04005AE1 RID: 23265
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysLabtoolPreambles_A8730;

		// Token: 0x04005AE2 RID: 23266
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysLabtoolPreambles_A8730;

		// Token: 0x04005AE3 RID: 23267
		internal global::AcpUI.AcpLabel CnvSysLabtoolPreambles_A8730Comp;

		// Token: 0x04005AE4 RID: 23268
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysLabtoolCPTotalPretimeMDC_A7789;

		// Token: 0x04005AE5 RID: 23269
		internal global::AcpUI.AcpLabel LblCnvSysLabtoolCPTotalPretimeMDC_A7789;

		// Token: 0x04005AE6 RID: 23270
		internal global::AcpUI.AcpTextBox CnvSysLabtoolCPTotalPretimeMDC_A7789;

		// Token: 0x04005AE7 RID: 23271
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysLabtoolCPTotalPretimeMDC_A7789;

		// Token: 0x04005AE8 RID: 23272
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysLabtoolCPTotalPretimeMDC_A7789;

		// Token: 0x04005AE9 RID: 23273
		internal global::AcpUI.AcpLabel CnvSysLabtoolCPTotalPretimeMDC_A7789Comp;

		// Token: 0x04005AEA RID: 23274
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysLabtoolAckPreambles_A7392;

		// Token: 0x04005AEB RID: 23275
		internal global::AcpUI.AcpLabel LblCnvSysLabtoolAckPreambles_A7392;

		// Token: 0x04005AEC RID: 23276
		internal global::AcpUI.AcpTextBoxSpinner CnvSysLabtoolAckPreambles_A7392;

		// Token: 0x04005AED RID: 23277
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysLabtoolAckPreambles_A7392;

		// Token: 0x04005AEE RID: 23278
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysLabtoolAckPreambles_A7392;

		// Token: 0x04005AEF RID: 23279
		internal global::AcpUI.AcpLabel CnvSysLabtoolAckPreambles_A7392Comp;

		// Token: 0x04005AF0 RID: 23280
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysLabtoolInterPacketPreambles_A8311;

		// Token: 0x04005AF1 RID: 23281
		internal global::AcpUI.AcpLabel LblCnvSysLabtoolInterPacketPreambles_A8311;

		// Token: 0x04005AF2 RID: 23282
		internal global::AcpUI.AcpTextBoxSpinner CnvSysLabtoolInterPacketPreambles_A8311;

		// Token: 0x04005AF3 RID: 23283
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysLabtoolInterPacketPreambles_A8311;

		// Token: 0x04005AF4 RID: 23284
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysLabtoolInterPacketPreambles_A8311;

		// Token: 0x04005AF5 RID: 23285
		internal global::AcpUI.AcpLabel CnvSysLabtoolInterPacketPreambles_A8311Comp;

		// Token: 0x04005AF6 RID: 23286
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnConSysCPTotalPretime_A20162;

		// Token: 0x04005AF7 RID: 23287
		internal global::AcpUI.AcpLabel LblConSysCPTotalPretime_A20162;

		// Token: 0x04005AF8 RID: 23288
		internal global::AcpUI.AcpTextBoxSpinnerDecHex ConSysCPTotalPretime_A20162;

		// Token: 0x04005AF9 RID: 23289
		internal global::AcpUI.AcpRtdButton RTDBtnConSysCPTotalPretime_A20162;

		// Token: 0x04005AFA RID: 23290
		internal global::AcpUI.AcpCopyButton CpyBtnConSysCPTotalPretime_A20162;

		// Token: 0x04005AFB RID: 23291
		internal global::AcpUI.AcpTextBoxDecHex ConSysCPTotalPretime_A20162Comp;

		// Token: 0x04005AFC RID: 23292
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvSysLabtoolRetryConstrant_A8950;

		// Token: 0x04005AFD RID: 23293
		internal global::AcpUI.AcpLabel LblCnvSysLabtoolRetryConstrant_A8950;

		// Token: 0x04005AFE RID: 23294
		internal global::AcpUI.AcpTextBoxSpinner CnvSysLabtoolRetryConstrant_A8950;

		// Token: 0x04005AFF RID: 23295
		internal global::AcpUI.AcpRtdButton RTDBtnCnvSysLabtoolRetryConstrant_A8950;

		// Token: 0x04005B00 RID: 23296
		internal global::AcpUI.AcpCopyButton CpyBtnCnvSysLabtoolRetryConstrant_A8950;

		// Token: 0x04005B01 RID: 23297
		internal global::AcpUI.AcpLabel CnvSysLabtoolRetryConstrant_A8950Comp;

		// Token: 0x04005B02 RID: 23298
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnConventionalSystemQuikCallIIToneListItemID_A42258;

		// Token: 0x04005B03 RID: 23299
		internal global::AcpUI.AcpLabel LblConventionalSystemQuikCallIIToneListItemID_A42258;

		// Token: 0x04005B04 RID: 23300
		internal global::AcpUI.AcpComboBox ConventionalSystemQuikCallIIToneListItemID_A42258;

		// Token: 0x04005B05 RID: 23301
		internal global::AcpUI.AcpRtdButton RTDBtnConventionalSystemQuikCallIIToneListItemID_A42258;

		// Token: 0x04005B06 RID: 23302
		internal global::AcpUI.AcpCopyButton CpyBtnConventionalSystemQuikCallIIToneListItemID_A42258;

		// Token: 0x04005B07 RID: 23303
		internal global::AcpUI.AcpLabel ConventionalSystemQuikCallIIToneListItemID_A42258Comp;

		// Token: 0x04005B08 RID: 23304
		private bool b;
	}
}
