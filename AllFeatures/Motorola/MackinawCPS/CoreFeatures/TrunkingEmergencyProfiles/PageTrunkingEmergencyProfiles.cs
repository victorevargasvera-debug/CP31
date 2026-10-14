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

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles
{
	// Token: 0x0200047C RID: 1148
	public class PageTrunkingEmergencyProfiles : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x060097BC RID: 38844 RVA: 0x008E5C90 File Offset: 0x008E3E90
		public PageTrunkingEmergencyProfiles()
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

		// Token: 0x060097BD RID: 38845 RVA: 0x008E5CC8 File Offset: 0x008E3EC8
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1235580443;
			short num2 = num;
			num = (short)179992091;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_7D:
				switch (0)
				{
				case 0:
					goto IL_AA;
				}
				break;
			default:
				num = (short)1845035008;
				if (num != 0)
				{
				}
				num = (short)1088815104;
				num3 = (int)num;
				switch (num3)
				{
				default:
					num = (short)1333067779;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				break;
			}
			for (;;)
			{
				IL_87:
				global::AcpUI.AcpExpander acpExpander;
				global::System.Collections.IEnumerator enumerator;
				switch (num3)
				{
				case 0:
				{
					object obj;
					global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
					this.RecNavToolbarExpanderTrunkingEmergencyProfilesTrunkingEmergencyToneTable.MyDataPresenter = this.ExpanderTrunkingEmergencyProfilesTrunkingEmergencyToneTable;
					num = (short)1966342150;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					goto IL_17B;
				case 2:
					try
					{
						num = (short)1288962051;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								if (acpExpander != null)
								{
									num = (short)2005794817;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 1:
								base.Expanders.Add(acpExpander);
								num = (short)1952776197;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								num = (short)1732771846;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_250;
								}
								continue;
							case 4:
								if (!enumerator.MoveNext())
								{
									num = (short)502792194;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
								num = (short)677117952;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								goto IL_310;
							}
							IL_252:
							num = (short)960626692;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_250:
							goto IL_252;
						}
						IL_310:
						goto IL_154;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_332;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_31F:
							switch (num3)
							{
							case 0:
								if (disposable != null)
								{
									num = (short)565182465;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_388;
							case 1:
								disposable.Dispose();
								num = (short)1540882434;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_386;
							}
							goto IL_332;
						}
						IL_386:
						IL_388:
						goto EndFinally_8;
						IL_332:
						disposable = (enumerator as global::System.IDisposable);
						num = (short)2089025536;
						num3 = (int)((global::System.IntPtr)num);
						goto IL_31F;
						EndFinally_8:;
					}
					goto IL_389;
					IL_154:
					base.OnLoaded(sender, e);
					this.a = true;
					num = (short)1992622081;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_7D;
				case 4:
				{
					this.RecNavToolbarPageTrunkingEmergencyProfiles.ChildToolbars.Add(this.RecNavToolbarExpanderTrunkingEmergencyProfilesTrunkingEmergencyToneTable);
					object obj = null;
					obj = this.RecNavToolbarExpanderTrunkingEmergencyProfilesTrunkingEmergencyToneTable.MyRecordsetDataSource;
					num = (short)1312948229;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
				{
					object obj;
					if (obj != null)
					{
						num = (short)1487470592;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CC;
				}
				case 6:
					goto IL_CC;
				}
				goto IL_AA;
				IL_CC:
				acpExpander = null;
				enumerator = this.MyStackPanel.Children.GetEnumerator();
				num = (short)1464991746;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_17B:
			num = (short)975110145;
			if (num != 0)
			{
			}
			num = (short)1125646336;
			short num4 = num;
			goto IL_389;
			IL_AA:
			if (!this.a)
			{
				num = (short)1930428420;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_87;
			}
			IL_389:
			this.MyStackPanel.Children[0].Focus();
		}

		// Token: 0x060097BE RID: 38846 RVA: 0x008E6094 File Offset: 0x008E4294
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
				{
					num2 = (short)2103056277;
					short num3 = num2;
					num2 = (short)1974015893;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_11C;
					case 1:
						break;
					default:
					{
						num2 = (short)989396992;
						short num4 = num2;
						break;
					}
					}
					num2 = (short)452722688;
					if (num2 != 0)
					{
					}
					if (this.a)
					{
						num2 = (short)1219428353;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_11E;
				}
				case 1:
					base.OnUnloaded(sender, e);
					this.a = false;
					num2 = (short)389677058;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_11C;
				}
				goto IL_1C;
			}
			IL_11C:
			IL_11E:
			num2 = (short)439484417;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			this.RecNavToolbarPageTrunkingEmergencyProfiles.DataContext = null;
			this.RecNavToolbarExpanderTrunkingEmergencyProfilesTrunkingEmergencyToneTable.DataContext = null;
			this.RecNavToolbarPageTrunkingEmergencyProfiles.MyDataPresenter = null;
			this.RecNavToolbarExpanderTrunkingEmergencyProfilesTrunkingEmergencyToneTable.MyDataPresenter = null;
			num2 = (short)1591934976;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060097BF RID: 38847 RVA: 0x008E61E8 File Offset: 0x008E43E8
		public override void SetDataContext()
		{
			short num = (short)1081737216;
			short num2 = num;
			num = (short)1667366917;
			int num3 = (int)((global::System.IntPtr)num);
			object feature;
			for (;;)
			{
				switch (num3)
				{
				case 0:
				{
					feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2076);
					num = (short)530370706;
					short num4 = num;
					num = (short)1315098770;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_151;
					default:
						num = (short)975831040;
						if (num != 0)
						{
						}
						num = (short)1231945732;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)2058420224;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_151;
				case 2:
					goto IL_175;
				case 3:
					goto IL_CC;
				case 4:
					if (feature != null)
					{
						num = (short)1285881864;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 5:
					num = (short)1765474305;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_98;
					}
					continue;
				case 6:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2076);
					num = (short)1393164295;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_CC;
				case 8:
					goto IL_232;
				}
				IL_98:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)308150278;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2076);
				num = (short)96010243;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_CC:
				this.RecNavToolbarPageTrunkingEmergencyProfiles.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				num = (short)1627914241;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_151:
				((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageTrunkingEmergencyProfiles).MySecondaryRecordsetDataSource = null;
				num = (short)1956184066;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_175:
			return;
			IL_232:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageTrunkingEmergencyProfiles).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
		}

		// Token: 0x060097C0 RID: 38848 RVA: 0x008E642C File Offset: 0x008E462C
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 4;
			short num = (short)1631256576;
			switch (num)
			{
			default:
			{
				num = (short)763494401;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_292;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_A9;
						}
						continue;
					case 2:
					{
						global::System.Windows.Data.CollectionView collectionView;
						if (collectionView.Count > 0)
						{
							num = (short)1647509509;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_340;
					}
					case 3:
					{
						global::System.Windows.Data.CollectionView collectionView;
						if (collectionView.IsCurrentAfterLast)
						{
							goto IL_F2;
						}
						collectionView.MoveCurrentToFirst();
						num = (short)564330506;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						num = (short)468686096;
						short num3 = num;
						num = (short)1683264784;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_F2;
						default:
						{
							num = (short)2119892992;
							if (num != 0)
							{
							}
							num = (short)615710721;
							if (num != 0)
							{
							}
							global::AcpCommonLib.IAcpRecordset myRecordsetDataSource = this.RecNavToolbarPageTrunkingEmergencyProfiles.MyRecordsetDataSource;
							num = (short)1917583377;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 5:
						num = (short)1924857859;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						object myRecordsetDataSource2;
						if (myRecordsetDataSource2 != null)
						{
							num = (short)1916076054;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 7:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("韄ꋆ꫈藊곌많藐볒뫔믖믘뫚꿜髞駠鏢蓤触跨軪鿬믮菰蛲鯴鳶郸闺髼뫾氀昂眄怆氈攊渌瘎䄐愒稔焖瀘眚砜氞甠儢値䤦䈨䈪䌬䠮琰帲倴䔶常帺匼尾㡀ᝂ⩄⥆ⱈὊⱌⵎ㵐㙒", a_))
						{
							num = (short)1611071501;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 8:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource;
						base.NavigationService.Navigate(new global::System.Uri(myRecordsetDataSource.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
						num = (short)1642856468;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyToneTableInner trunkingEmergencyToneTableInner;
						if (trunkingEmergencyToneTableInner != null)
						{
							num = (short)891879445;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2007760898;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_18A;
					case 11:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource2 = this.RecNavToolbarExpanderTrunkingEmergencyProfilesTrunkingEmergencyToneTable.MyRecordsetDataSource;
						num = (short)1710555136;
						short num4 = num;
						num = (short)1751318534;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						goto IL_269;
					case 13:
						num = (short)587202578;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("韄ꋆ꫈藊곌많藐볒뫔믖믘뫚꿜连胠蓢胤돦鯨黪菬蓮飰鷲鋴닶铸黺迼飾搀洂昄縆夈礊戌椎砐缒瀔搖", a_))
						{
							num = (short)2131755012;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2EB;
					case 15:
					{
						global::System.Windows.Data.CollectionView collectionView;
						collectionView.MoveCurrentToLast();
						num = (short)424804364;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						goto IL_12F;
					case 17:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource;
						if (myRecordsetDataSource != null)
						{
							num = (short)90636296;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2EB;
					}
					case 18:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)621215755;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)1720975360;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						num = (short)1159593998;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						goto IL_2EB;
					case 21:
					{
						global::System.Windows.Data.CollectionView collectionView;
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyToneTableInner trunkingEmergencyToneTableInner;
						collectionView.MoveCurrentTo(trunkingEmergencyToneTableInner);
						num = (short)1041956880;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
					{
						object myRecordsetDataSource2;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource2);
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyToneTableInner trunkingEmergencyToneTableInner = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyToneTableInner)collectionView.CurrentItem;
						num = (short)310050825;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_A9:
					if (A_0 is global::AcpUI.AcpRecNavToolbar)
					{
						num = (short)1142620179;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_F2:
					num = (short)1684209679;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2EB:
					num = (short)1929773063;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_12F:
				IL_18A:
				IL_269:
				goto IL_340;
				IL_292:
				return;
				IL_340:
				((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
				return;
			}
			}
		}

		// Token: 0x060097C1 RID: 38849 RVA: 0x008E68DC File Offset: 0x008E4ADC
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)70768432;
			short num2 = num;
			num = (short)885184304;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1770389504;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1732509697;
			if (num != 0)
			{
			}
			num = (short)1595473920;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x060097C2 RID: 38850 RVA: 0x008E698C File Offset: 0x008E4B8C
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1199889234;
			short num2 = num;
			num = (short)838327122;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1971781632;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)815857665;
			if (num != 0)
			{
			}
			num = (short)1054277632;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x060097C3 RID: 38851 RVA: 0x008E6A3C File Offset: 0x008E4C3C
		internal void OnExpanderTrunkingEmergencyProfilesTrunkingEmergencyToneTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			object myRecordsetDataSource;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyToneTableInner item;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (myRecordsetDataSource != null)
					{
						num2 = (short)1694171137;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_DC;
				case 1:
				{
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderTrunkingEmergencyProfilesTrunkingEmergencyToneTable.SyncDataSources();
					num2 = (short)630849536;
					short num3 = num2;
					num2 = (short)610992130;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_DC;
				}
				goto IL_1C;
				IL_DC:
				num2 = (short)870776833;
				if (num2 != 0)
				{
				}
				num2 = (short)2107876808;
				short num4 = num2;
				num2 = (short)1399104968;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_136;
				}
			}
			IL_136:
			num2 = (short)633602048;
			if (num2 != 0)
			{
			}
			this.RecNavToolbarExpanderTrunkingEmergencyProfilesTrunkingEmergencyToneTable.TableMode = false;
			return;
			IL_1C:
			item = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyToneTableInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderTrunkingEmergencyProfilesTrunkingEmergencyToneTable.MyRecordsetDataSource;
			num2 = (short)1002307584;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060097C4 RID: 38852 RVA: 0x008E6BA0 File Offset: 0x008E4DA0
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 13;
			short num = (short)805795661;
			short num2 = num;
			num = (short)394753869;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1064828928;
				if (num != 0)
				{
				}
				num = (short)493420544;
				short num3 = num;
				if (!this.b)
				{
					this.b = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("量뻑룓郕뷗믙꣛ꯝ鋟蟡韣\udde5诧藩臫黭鿯鳱釳飵賷헹駻鏽旿瀁挃挅昇椉甋⬍∏∑眓礕瘗簙甛礝唟倡䔣別䄧䔩䈫ĭ䐯䀱䄳堵匷匹刻夽政灁瑃⍅╇⽉㹋⥍㕏㱑㝓⽕絗桙汛⹝቟ൡɣཥѧཀྵὫ䅭ѯqųᡵ፷፹ቻ᥽秊ﺗﮝ펟財\udca3장얧용", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				break;
			}
			}
			num = (short)1865678849;
			if (num != 0)
			{
			}
		}

		// Token: 0x060097C5 RID: 38853 RVA: 0x008E6C80 File Offset: 0x008E4E80
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1692925952;
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
					num = (short)1152319490;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_A21;
				}
				IL_30:
				switch (connectionId)
				{
				case 1:
					goto IL_43B;
				case 2:
					goto IL_A26;
				case 3:
				case 4:
				case 5:
				case 6:
				case 7:
					goto IL_122F;
				case 8:
					goto IL_670;
				case 9:
					goto IL_114B;
				case 10:
					goto IL_5A2;
				case 11:
					goto IL_97E;
				case 12:
					goto IL_F93;
				case 13:
					goto IL_11D4;
				case 14:
					goto IL_C35;
				case 15:
					goto IL_D44;
				case 16:
					goto IL_10A5;
				case 17:
					goto IL_C9A;
				case 18:
					goto IL_6C8;
				case 19:
					goto IL_FD1;
				case 20:
					goto IL_D51;
				case 21:
					goto IL_964;
				case 22:
					goto IL_FEB;
				case 23:
					goto IL_F3E;
				case 24:
					goto IL_FB7;
				case 25:
					goto IL_D5E;
				case 26:
					goto IL_9A2;
				case 27:
					goto IL_971;
				case 28:
					goto IL_37F;
				case 29:
					goto IL_824;
				case 30:
					goto IL_1131;
				case 31:
					goto IL_697;
				case 32:
					goto IL_663;
				case 33:
					goto IL_479;
				case 34:
					goto IL_ACB;
				case 35:
					goto IL_6EC;
				case 36:
					goto IL_107E;
				case 37:
					goto IL_7D9;
				case 38:
					goto IL_FC4;
				case 39:
					goto IL_46C;
				case 40:
					goto IL_117C;
				case 41:
					goto IL_F1A;
				case 42:
					goto IL_1117;
				case 43:
					goto IL_34E;
				case 44:
					goto IL_526;
				case 45:
					goto IL_957;
				case 46:
					goto IL_486;
				case 47:
					goto IL_781;
				case 48:
					goto IL_3F0;
				case 49:
					goto IL_68A;
				case 50:
					goto IL_571;
				case 51:
					goto IL_564;
				case 52:
					goto IL_DAC;
				case 53:
					goto IL_E32;
				case 54:
					goto IL_1215;
				case 55:
					goto IL_C42;
				case 56:
					goto IL_B6E;
				case 57:
					goto IL_557;
				case 58:
					goto IL_1029;
				case 59:
					goto IL_E7D;
				case 60:
					goto IL_B16;
				case 61:
					goto IL_519;
				case 62:
					goto IL_FDE;
				case 63:
					goto IL_11FB;
				case 64:
					goto IL_CE2;
				case 65:
					goto IL_5EA;
				case 66:
					goto IL_AB1;
				case 67:
					goto IL_7F3;
				case 68:
					goto IL_9E3;
				case 69:
					goto IL_9AF;
				case 70:
					goto IL_632;
				case 71:
					goto IL_E0E;
				case 72:
					goto IL_B7B;
				case 73:
					goto IL_11EE;
				case 74:
					goto IL_886;
				case 75:
					goto IL_4E8;
				case 76:
					goto IL_4DB;
				case 77:
					goto IL_D06;
				case 78:
					goto IL_EA1;
				case 79:
					goto IL_11AD;
				case 80:
					goto IL_879;
				case 81:
					goto IL_AA4;
				case 82:
					goto IL_893;
				case 83:
					goto IL_90C;
				case 84:
					goto IL_C76;
				case 85:
					goto IL_42E;
				case 86:
					goto IL_10F0;
				case 87:
					goto IL_110A;
				case 88:
					goto IL_A97;
				case 89:
					goto IL_8E8;
				case 90:
					goto IL_5C6;
				case 91:
					goto IL_D37;
				case 92:
					goto IL_ABE;
				case 93:
					goto IL_DD0;
				case 94:
					goto IL_F62;
				case 95:
					goto IL_105A;
				case 96:
					goto IL_57E;
				case 97:
					goto IL_D92;
				case 98:
					goto IL_9F0;
				case 99:
					goto IL_C69;
				case 100:
					goto IL_F0D;
				case 101:
					goto IL_B54;
				case 102:
					goto IL_8A0;
				case 103:
					goto IL_800;
				case 104:
					goto IL_1208;
				case 105:
					goto IL_10E3;
				case 106:
					goto IL_94A;
				case 107:
					goto IL_341;
				case 108:
					goto IL_855;
				case 109:
					goto IL_A4A;
				case 110:
					goto IL_10D6;
				case 111:
					goto IL_3BD;
				case 112:
					goto IL_930;
				case 113:
					goto IL_7E6;
				case 114:
					goto IL_104D;
				case 115:
					goto IL_75D;
				case 116:
					goto IL_BEA;
				case 117:
					goto IL_1222;
				case 118:
					goto IL_BC3;
				case 119:
					goto IL_B09;
				case 120:
					goto IL_AFC;
				case 121:
					goto IL_4F5;
				case 122:
					goto IL_9D6;
				case 123:
					goto IL_11A0;
				case 124:
					goto IL_D85;
				case 125:
					goto IL_C0E;
				case 126:
					goto IL_9C9;
				case 127:
					goto IL_9BC;
				case 128:
					goto IL_3A3;
				case 129:
					goto IL_C4F;
				case 130:
					goto IL_BDD;
				case 131:
					goto IL_334;
				case 132:
					goto IL_D6B;
				case 133:
					goto IL_B30;
				case 134:
					goto IL_E56;
				case 135:
					goto IL_B9F;
				case 136:
					goto IL_C1B;
				case 137:
					goto IL_9FD;
				case 138:
					goto IL_848;
				case 139:
					goto IL_60E;
				case 140:
					goto IL_7B2;
				case 141:
					goto IL_CBE;
				case 142:
					goto IL_B61;
				case 143:
					goto IL_11E1;
				case 144:
					goto IL_10FD;
				case 145:
					goto IL_6A4;
				case 146:
					goto IL_93D;
				case 147:
					goto IL_EE9;
				case 148:
					goto IL_4CE;
				case 149:
					goto IL_100F;
				case 150:
					goto IL_113E;
				case 151:
					goto IL_35B;
				case 152:
					goto IL_AEF;
				case 153:
					goto IL_533;
				case 154:
					goto IL_7A5;
				case 155:
					goto IL_B23;
				case 156:
					goto IL_7BF;
				case 157:
					goto IL_10B2;
				case 158:
					goto IL_101C;
				case 159:
					goto IL_63F;
				case 160:
					goto IL_D78;
				case 161:
					goto IL_7CC;
				case 162:
					goto IL_3FD;
				case 163:
					goto IL_1124;
				case 164:
					goto IL_BD0;
				case 165:
					goto IL_11BA;
				case 166:
					goto IL_4AA;
				case 167:
					goto IL_8C4;
				case 168:
					goto IL_3B0;
				case 169:
					goto IL_67D;
				case 170:
					goto IL_C28;
				case 171:
					goto IL_DDD;
				case 172:
					goto IL_F6F;
				case 173:
					goto IL_EC5;
				case 174:
					goto IL_D9F;
				case 175:
					goto IL_C5C;
				case 176:
					goto IL_E63;
				case 177:
					goto IL_E70;
				case 178:
					goto IL_108B;
				case 179:
					goto IL_11C7;
				case 180:
					goto IL_40A;
				case 181:
					goto IL_DEA;
				case 182:
					goto IL_1098;
				case 183:
					goto IL_116F;
				case 184:
					goto IL_D2A;
				default:
					num = (short)1671823361;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_334:
			this.ExpanderTrunkingEmergencyProfilesTrunkingEmergencyToneTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_341:
			this.CVBtnTrkPeEMGFindMeRxEnable_42923 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_34E:
			this.CpyBtnTrkEmerProfGeneralEmergencyTalkback_A9268 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_35B:
			this.TrkEmerTonePeriodSec_42110 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.TrkEmerTonePeriodSec_42110.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_37F:
			this.LblTrkEmerProfGeneralRetryCounter_A8951 = (global::AcpUI.AcpLabel)target;
			this.LblTrkEmerProfGeneralRetryCounter_A8951.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3A3:
			this.TrkEmerToneMinimumVolume_42109_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_3B0:
			this.RTDBtnEmergencyExitControl_43341 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3BD:
			num = (short)226623489;
			if (num != 0)
			{
			}
			this.CpyBtnTrkPeEMGFindMeRxEnable_42923 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3F0:
			this.RTDBtnTrkEmerProfGeneralRevertPTTID_A12642 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3FD:
			this.TrkEmerAudioRouting_42111Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_40A:
			this.LblTrkEmergencyToneSelection_42055 = (global::AcpUI.AcpLabel)target;
			this.LblTrkEmergencyToneSelection_42055.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_42E:
			this.RTDBtnTrkEmerProfGeneralTxPeriodsec1_A7939 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_43B:
			((global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.PageTrunkingEmergencyProfiles)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.PageTrunkingEmergencyProfiles)target).Unloaded += this.OnUnloaded;
			return;
			IL_46C:
			this.CVBtnTrkEmerProfGeneralEmergencyTalkback_A9268 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_479:
			this.CVBtnTrkEmerProfGeneralConsoleAckRequired_A7712 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_486:
			this.LblTrkEmerProfGeneralRevertPTTID_A12642 = (global::AcpUI.AcpLabel)target;
			this.LblTrkEmerProfGeneralRevertPTTID_A12642.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4AA:
			this.LblEmergencyExitControl_43341 = (global::AcpUI.AcpLabel)target;
			this.LblEmergencyExitControl_43341.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4CE:
			this.RTDBtnTrkEmerToneMinimumVolume_42109 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4DB:
			this.CVBtnTrkEmerProfGeneralTxPeriodsec2_A43601 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4E8:
			this.TrkEmerProEmergencyAutoTransmitMode_A22567Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4F5:
			this.RecNavToolbarExpanderTrunkingEmergencyProfilesTrunkingEmergencyToneTable = (global::AcpUI.AcpChildRecNavToolbar)target;
			this.RecNavToolbarExpanderTrunkingEmergencyProfilesTrunkingEmergencyToneTable.ModeClick += this.OnModeClick;
			return;
			IL_519:
			this.CpyBtnEmergencyExitOnChannelChange_43588 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_526:
			this.TrkEmerProfGeneralEmergencyTalkback_A9268Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_533:
			this.LblTrkEmerTonePeriodSec_42110 = (global::AcpUI.AcpLabel)target;
			this.LblTrkEmerTonePeriodSec_42110.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_557:
			this.CVBtnEmergencyExitOnChannelChange_43588 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_564:
			this.CVBtnTrkPerManDownEnable_42039 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_571:
			this.TrkEmerProfGeneralRevertPTTID_A12642Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_57E:
			this.TrkEmerProfEmergencyHotAuxMic_A42300 = (global::AcpUI.AcpComboBox)target;
			this.TrkEmerProfEmergencyHotAuxMic_A42300.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5A2:
			this.HLinkTrunkingEmergencyToneList = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkTrunkingEmergencyToneList.Click += this.HLinkClick;
			return;
			IL_5C6:
			this.TrkEmerProfGeneralTxPeriodsec2_A9132 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.TrkEmerProfGeneralTxPeriodsec2_A9132.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5EA:
			this.TrkEmerProfGeneralRemoteActivationEmergency = (global::AcpUI.AcpComboBox)target;
			this.TrkEmerProfGeneralRemoteActivationEmergency.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_60E:
			this.TrkEmerTone_42108 = (global::AcpUI.AcpComboBox)target;
			this.TrkEmerTone_42108.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_632:
			this.CVBtnTrkEmerProEmergencyAutoTransmitMode_A22567 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_63F:
			this.LblTrkEmerAudioRouting_42111 = (global::AcpUI.AcpLabel)target;
			this.LblTrkEmerAudioRouting_42111.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_663:
			this.TrkEmerProfGeneralRetryCounter_A8951Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_670:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_67D:
			this.CpyBtnEmergencyExitControl_43341 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_68A:
			this.CpyBtnTrkEmerProfGeneralRevertPTTID_A12642 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_697:
			this.CpyBtnTrkEmerProfGeneralRetryCounter_A8951 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_6A4:
			this.TrkEmerToneMinimumVolume_42109 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.TrkEmerToneMinimumVolume_42109.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_6C8:
			this.TrkEmerProfGeneralkeyofTrunkingEmergencyProfiles_A19419 = (global::AcpUI.AcpTextBox)target;
			this.TrkEmerProfGeneralkeyofTrunkingEmergencyProfiles_A19419.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_6EC:
			num = (short)890479757;
			short num3 = num;
			num = (short)2134353037;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_34E;
			default:
				num = (short)1960706048;
				if (num != 0)
				{
				}
				this.TrkEmerProfGeneralConsoleAckRequired_A7712 = (global::AcpUI.AcpCheckBox)target;
				this.TrkEmerProfGeneralConsoleAckRequired_A7712.GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			IL_75D:
			this.LblTrkEmerProfImpactDetectionEn_A43392 = (global::AcpUI.AcpLabel)target;
			this.LblTrkEmerProfImpactDetectionEn_A43392.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_781:
			this.TrkEmerProfGeneralRevertPTTID_A12642 = (global::AcpUI.AcpCheckBox)target;
			this.TrkEmerProfGeneralRevertPTTID_A12642.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_7A5:
			this.RTDBtnTrkEmerTonePeriodSec_42110 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_7B2:
			this.CVBtnTrkEmerTone_42108 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_7BF:
			this.TrkEmerTonePeriodSec_42110Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_7CC:
			this.CpyBtnTrkEmerAudioRouting_42111 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_7D9:
			this.CpyBtnTrkEmerProfGeneralConsoleAckRequired_A7712 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_7E6:
			this.GrpBoxExpanderTrunkingEmergencyProfilesGeneralPseudo2 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_7F3:
			this.CpyBtnTrkEmerProfGeneralRemoteActivationEmergency = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_800:
			this.TrkPeEMGFindMeTxEnable_42921 = (global::AcpUI.AcpCheckBox)target;
			this.TrkPeEMGFindMeTxEnable_42921.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_824:
			this.TrkEmerProfGeneralRetryCounter_A8951 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.TrkEmerProfGeneralRetryCounter_A8951.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_848:
			this.EmergencyToneTrigger_42107Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_855:
			this.LblTrkPeEMGFindMeRxEnable_42923 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPeEMGFindMeRxEnable_42923.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_879:
			this.CpyBtnTrkEmerProfGeneralTxPeriodsec2_A43601 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_886:
			this.CpyBtnTrkEmerProEmergencyAutoTransmitMode_A22567 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_893:
			this.CVBtnTrkEmerProfGeneralTxPeriodsec1_A7939 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_8A0:
			this.LblTrkPeEMGFindMeTxEnable_42921 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPeEMGFindMeTxEnable_42921.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_8C4:
			this.EmergencyExitControl_43341 = (global::AcpUI.AcpComboBox)target;
			this.EmergencyExitControl_43341.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_8E8:
			this.LblTrkEmerProfGeneralTxPeriodsec2_A9132 = (global::AcpUI.AcpLabel)target;
			this.LblTrkEmerProfGeneralTxPeriodsec2_A9132.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_90C:
			this.LblTrkEmerProfGeneralTxPeriodsec1_A7939 = (global::AcpUI.AcpLabel)target;
			this.LblTrkEmerProfGeneralTxPeriodsec1_A7939.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_930:
			this.TrkPeEMGFindMeRxEnable_42923Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_93D:
			this.CVBtnTrkEmerToneMinimumVolume_42109 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_94A:
			this.TrkPeEMGFindMeTxEnable_42921Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_957:
			this.CVBtnTrkEmerProfGeneralRevertPTTID_A12642 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_964:
			this.CVBtnTrkEmerProfGeneralEmergencyOperation_A7926 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_971:
			this.CVBtnTrkEmerProfGeneralRetryCounter_A8951 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_97E:
			this.HLinkEmergencyCompatibilityOptionsTrunking = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkEmergencyCompatibilityOptionsTrunking.Click += this.HLinkClick;
			return;
			IL_9A2:
			this.TrkEmerProfGeneralEmergencyOperation_A7926Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_9AF:
			this.GrpBoxExpanderTrunkingEmergencyProfilesGeneralAutoTransmit = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_9BC:
			this.TrkEmerTone_42108_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_9C9:
			this.EmergencyToneTrigger_42107_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_9D6:
			this.ExpanderTrunkingEmergencyProfilesTrunkingEmergencyToneListGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_9E3:
			this.TrkEmerProfGeneralRemoteActivationEmergencyComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_9F0:
			this.CpyBtnTrkEmerProfEmergencyHotAuxMic_A42300 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9FD:
			this.CpyBtnEmergencyToneTrigger_42107 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A21:
			goto IL_122F;
			IL_A26:
			this.RecNavToolbarPageTrunkingEmergencyProfiles = (global::AcpUI.AcpParentRecNavToolbar)target;
			this.RecNavToolbarPageTrunkingEmergencyProfiles.ModeClick += this.OnModeClick;
			return;
			IL_A4A:
			num = (short)1555693568;
			short num4 = num;
			this.TrkPeEMGFindMeRxEnable_42923 = (global::AcpUI.AcpCheckBox)target;
			this.TrkPeEMGFindMeRxEnable_42923.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_A97:
			this.CVBtnTrkEmerProfGeneralTxPeriodsec2_A9132 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_AA4:
			this.TrkEmerProfGeneralTxPeriodsec2_A43601Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_AB1:
			this.RTDBtnTrkEmerProfGeneralRemoteActivationEmergency = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_ABE:
			this.CpyBtnTrkEmerProfGeneralTxPeriodsec2_A9132 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_ACB:
			this.LblTrkEmerProfGeneralConsoleAckRequired_A7712 = (global::AcpUI.AcpLabel)target;
			this.LblTrkEmerProfGeneralConsoleAckRequired_A7712.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_AEF:
			this.CVBtnTrkEmerTonePeriodSec_42110 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_AFC:
			this.ExpanderTrunkingEmergencyProfilesTrunkingEmergencyToneList = (global::AcpUI.AcpExpander)target;
			return;
			IL_B09:
			this.TrkEmerProfImpactDetectionEn_A43392Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_B16:
			this.RTDBtnEmergencyExitOnChannelChange_43588 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_B23:
			this.CpyBtnTrkEmerTonePeriodSec_42110 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B30:
			this.EmergencyToneTrigger_42107 = (global::AcpUI.AcpComboBox)target;
			this.EmergencyToneTrigger_42107.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B54:
			this.CVBtnTrkPeEMGFindMeTxEnable_42921 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B61:
			this.RTDBtnTrkEmerTone_42108 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_B6E:
			this.TrkPerManDownEnable_42039Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_B7B:
			this.TrkEmerProEmergencyAutoTransmitMode_A22567 = (global::AcpUI.AcpComboBox)target;
			this.TrkEmerProEmergencyAutoTransmitMode_A22567.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B9F:
			this.LblEmergencyToneTrigger_42107 = (global::AcpUI.AcpLabel)target;
			this.LblEmergencyToneTrigger_42107.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_BC3:
			this.CpyBtnTrkEmerProfImpactDetectionEn_A43392 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_BD0:
			this.GrpBoxExpanderTrunkingEmergencyProfilesEmergencyCompatibilityOptionsTrunkingPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_BDD:
			this.TrkEmerAudioRouting_42111_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_BEA:
			this.TrkEmerProfImpactDetectionEn_A43392 = (global::AcpUI.AcpCheckBox)target;
			this.TrkEmerProfImpactDetectionEn_A43392.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_C0E:
			this.ExpanderTrunkingEmergencyProfilesTrunkingEmergencyToneTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_C1B:
			this.RTDBtnEmergencyToneTrigger_42107 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_C28:
			this.EmergencyExitControl_43341Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_C35:
			this.ExpanderTrunkingEmergencyProfilesGeneral = (global::AcpUI.AcpExpander)target;
			return;
			IL_C42:
			this.CpyBtnTrkPerManDownEnable_42039 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_C4F:
			this.TrkEmerTonePeriodSec_42110_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_C5C:
			this.CpyBtnEmergencyHotMicRestart_43342 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_C69:
			this.TrkEmerProfEmergencyHotAuxMic_A42300Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_C76:
			this.TrkEmerProfGeneralTxPeriodsec1_A7939 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.TrkEmerProfGeneralTxPeriodsec1_A7939.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_C9A:
			this.LblTrkEmerProfGeneralkeyofTrunkingEmergencyProfiles_A19419 = (global::AcpUI.AcpLabel)target;
			this.LblTrkEmerProfGeneralkeyofTrunkingEmergencyProfiles_A19419.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_CBE:
			this.LblTrkEmerTone_42108 = (global::AcpUI.AcpLabel)target;
			this.LblTrkEmerTone_42108.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_CE2:
			this.LblTrkEmerProfGeneralRemoteActivationEmergency = (global::AcpUI.AcpLabel)target;
			this.LblTrkEmerProfGeneralRemoteActivationEmergency.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_D06:
			this.LblTrkEmerProfGeneralTxPeriodsec2_A43601 = (global::AcpUI.AcpLabel)target;
			this.LblTrkEmerProfGeneralTxPeriodsec2_A43601.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_D2A:
			this.TrkEmergencyToneSelection_42055Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_D37:
			this.RTDBtnTrkEmerProfGeneralTxPeriodsec2_A9132 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_D44:
			this.GrpBoxExpanderTrunkingEmergencyProfilesGeneralPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_D51:
			this.TrkEmerProfGeneralkeyofTrunkingEmergencyProfiles_A19419Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_D5E:
			this.CpyBtnTrkEmerProfGeneralEmergencyOperation_A7926 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_D6B:
			this.gridExpanderTrunkingEmergencyProfilesTrunkingEmergencyToneTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_D78:
			this.RTDBtnTrkEmerAudioRouting_42111 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_D85:
			this.ExpanderTrunkingEmergencyProfilesTrunkingEmergencyToneTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_D92:
			this.RTDBtnTrkEmerProfEmergencyHotAuxMic_A42300 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_D9F:
			this.RTDBtnEmergencyHotMicRestart_43342 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_DAC:
			this.LblTrkPerManDownEnable_42039 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerManDownEnable_42039.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_DD0:
			this.TrkEmerProfGeneralTxPeriodsec2_A9132Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_DDD:
			this.CVBtnEmergencyHotMicRestart_43342 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_DEA:
			this.TrkEmergencyToneSelection_42055 = (global::AcpUI.AcpComboBox)target;
			this.TrkEmergencyToneSelection_42055.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_E0E:
			this.LblTrkEmerProEmergencyAutoTransmitMode_A22567 = (global::AcpUI.AcpLabel)target;
			this.LblTrkEmerProEmergencyAutoTransmitMode_A22567.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_E32:
			this.TrkPerManDownEnable_42039 = (global::AcpUI.AcpCheckBox)target;
			this.TrkPerManDownEnable_42039.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_E56:
			this.CVBtnEmergencyToneTrigger_42107 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_E63:
			this.EmergencyHotMicRestart_43342Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_E70:
			this.ExpanderTrunkingEmergencyProfilesLabtool = (global::AcpUI.AcpExpander)target;
			return;
			IL_E7D:
			this.EmergencyExitOnChannelChange_43588 = (global::AcpUI.AcpCheckBox)target;
			this.EmergencyExitOnChannelChange_43588.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_EA1:
			this.TrkEmerProfGeneralTxPeriodsec2_A43601 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.TrkEmerProfGeneralTxPeriodsec2_A43601.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_EC5:
			this.EmergencyHotMicRestart_43342 = (global::AcpUI.AcpCheckBox)target;
			this.EmergencyHotMicRestart_43342.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_EE9:
			this.LblTrkEmerToneMinimumVolume_42109 = (global::AcpUI.AcpLabel)target;
			this.LblTrkEmerToneMinimumVolume_42109.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_F0D:
			this.GrpBoxExpanderTrunkingEmergencyProfilesGeneralEmergencyFindMe = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_F1A:
			this.TrkEmerProfGeneralEmergencyTalkback_A9268 = (global::AcpUI.AcpComboBox)target;
			this.TrkEmerProfGeneralEmergencyTalkback_A9268.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_F3E:
			this.TrkEmerProfGeneralEmergencyOperation_A7926 = (global::AcpUI.AcpComboBox)target;
			this.TrkEmerProfGeneralEmergencyOperation_A7926.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_F62:
			this.CVBtnTrkEmerProfEmergencyHotAuxMic_A42300 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_F6F:
			this.LblEmergencyHotMicRestart_43342 = (global::AcpUI.AcpLabel)target;
			this.LblEmergencyHotMicRestart_43342.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_F93:
			this.HLinkLabtool = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkLabtool.Click += this.HLinkClick;
			return;
			IL_FB7:
			this.RTDBtnTrkEmerProfGeneralEmergencyOperation_A7926 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_FC4:
			this.TrkEmerProfGeneralConsoleAckRequired_A7712Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_FD1:
			this.CpyBtnTrkEmerProfGeneralkeyofTrunkingEmergencyProfiles_A19419 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_FDE:
			this.EmergencyExitOnChannelChange_43588Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_FEB:
			this.LblTrkEmerProfGeneralEmergencyOperation_A7926 = (global::AcpUI.AcpLabel)target;
			this.LblTrkEmerProfGeneralEmergencyOperation_A7926.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_100F:
			this.CpyBtnTrkEmerToneMinimumVolume_42109 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_101C:
			this.CVBtnTrkEmerAudioRouting_42111 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1029:
			this.LblEmergencyExitOnChannelChange_43588 = (global::AcpUI.AcpLabel)target;
			this.LblEmergencyExitOnChannelChange_43588.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_104D:
			this.CVBtnTrkEmerProfImpactDetectionEn_A43392 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_105A:
			this.LblTrkEmerProfEmergencyHotAuxMic_A42300 = (global::AcpUI.AcpLabel)target;
			this.LblTrkEmerProfEmergencyHotAuxMic_A42300.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_107E:
			this.RTDBtnTrkEmerProfGeneralConsoleAckRequired_A7712 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_108B:
			this.GrpBoxExpanderTrunkingEmergencyProfilesLabtoolPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1098:
			this.RTDBtnTrkEmergencyToneSelection_42055 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_10A5:
			this.CVBtnTrkEmerProfGeneralkeyofTrunkingEmergencyProfiles_A19419 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_10B2:
			this.TrkEmerAudioRouting_42111 = (global::AcpUI.AcpComboBox)target;
			this.TrkEmerAudioRouting_42111.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_10D6:
			this.RTDBtnTrkPeEMGFindMeRxEnable_42923 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_10E3:
			this.CpyBtnTrkPeEMGFindMeTxEnable_42921 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_10F0:
			this.CpyBtnTrkEmerProfGeneralTxPeriodsec1_A7939 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_10FD:
			this.TrkEmerTone_42108Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_110A:
			this.TrkEmerProfGeneralTxPeriodsec1_A7939Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1117:
			this.RTDBtnTrkEmerProfGeneralEmergencyTalkback_A9268 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1124:
			this.ExpanderTrunkingEmergencyProfilesEmergencyCompatibilityOptionsTrunking = (global::AcpUI.AcpExpander)target;
			return;
			IL_1131:
			this.RTDBtnTrkEmerProfGeneralRetryCounter_A8951 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_113E:
			this.TrkEmerToneMinimumVolume_42109Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_114B:
			this.HLinkGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkGeneral.Click += this.HLinkClick;
			return;
			IL_116F:
			this.CpyBtnTrkEmergencyToneSelection_42055 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_117C:
			this.LblTrkEmerProfGeneralEmergencyTalkback_A9268 = (global::AcpUI.AcpLabel)target;
			this.LblTrkEmerProfGeneralEmergencyTalkback_A9268.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_11A0:
			this.ExpanderTrunkingEmergencyProfilesTrunkingEmergencyToneTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_11AD:
			this.RTDBtnTrkEmerProfGeneralTxPeriodsec2_A43601 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_11BA:
			this.CVBtnEmergencyExitControl_43341 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_11C7:
			this.CVBtnTrkEmergencyToneSelection_42055 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_11D4:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_11E1:
			this.CpyBtnTrkEmerTone_42108 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_11EE:
			this.RTDBtnTrkEmerProEmergencyAutoTransmitMode_A22567 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_11FB:
			this.CVBtnTrkEmerProfGeneralRemoteActivationEmergency = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1208:
			this.RTDBtnTrkPeEMGFindMeTxEnable_42921 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1215:
			this.RTDBtnTrkPerManDownEnable_42039 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1222:
			this.RTDBtnTrkEmerProfImpactDetectionEn_A43392 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_122F:
			this.b = true;
		}

		// Token: 0x060097C6 RID: 38854 RVA: 0x008E7EC4 File Offset: 0x008E60C4
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num;
			for (;;)
			{
				num = (short)148635648;
				short num2 = num;
				switch (connectionId)
				{
				case 3:
					goto IL_102;
				case 4:
					goto IL_AA;
				case 5:
				{
					num = (short)718951372;
					short num3 = num;
					num = (short)2046317516;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_7D;
					}
					break;
				}
				case 6:
					goto IL_C3;
				case 7:
					goto IL_11A;
				}
				break;
			}
			return;
			IL_7D:
			num = (short)1713242112;
			if (num != 0)
			{
			}
			((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_AA:
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_C3:
			num = (short)1205010433;
			if (num != 0)
			{
			}
			((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_102:
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_11A:
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x04004A51 RID: 19025
		private bool a;

		// Token: 0x04004A52 RID: 19026
		internal global::AcpUI.AcpParentRecNavToolbar RecNavToolbarPageTrunkingEmergencyProfiles;

		// Token: 0x04004A53 RID: 19027
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x04004A54 RID: 19028
		internal global::System.Windows.Documents.Hyperlink HLinkGeneral;

		// Token: 0x04004A55 RID: 19029
		internal global::System.Windows.Documents.Hyperlink HLinkTrunkingEmergencyToneList;

		// Token: 0x04004A56 RID: 19030
		internal global::System.Windows.Documents.Hyperlink HLinkEmergencyCompatibilityOptionsTrunking;

		// Token: 0x04004A57 RID: 19031
		internal global::System.Windows.Documents.Hyperlink HLinkLabtool;

		// Token: 0x04004A58 RID: 19032
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x04004A59 RID: 19033
		internal global::AcpUI.AcpExpander ExpanderTrunkingEmergencyProfilesGeneral;

		// Token: 0x04004A5A RID: 19034
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingEmergencyProfilesGeneralPseudo0;

		// Token: 0x04004A5B RID: 19035
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkEmerProfGeneralkeyofTrunkingEmergencyProfiles_A19419;

		// Token: 0x04004A5C RID: 19036
		internal global::AcpUI.AcpLabel LblTrkEmerProfGeneralkeyofTrunkingEmergencyProfiles_A19419;

		// Token: 0x04004A5D RID: 19037
		internal global::AcpUI.AcpTextBox TrkEmerProfGeneralkeyofTrunkingEmergencyProfiles_A19419;

		// Token: 0x04004A5E RID: 19038
		internal global::AcpUI.AcpCopyButton CpyBtnTrkEmerProfGeneralkeyofTrunkingEmergencyProfiles_A19419;

		// Token: 0x04004A5F RID: 19039
		internal global::AcpUI.AcpLabel TrkEmerProfGeneralkeyofTrunkingEmergencyProfiles_A19419Comp;

		// Token: 0x04004A60 RID: 19040
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkEmerProfGeneralEmergencyOperation_A7926;

		// Token: 0x04004A61 RID: 19041
		internal global::AcpUI.AcpLabel LblTrkEmerProfGeneralEmergencyOperation_A7926;

		// Token: 0x04004A62 RID: 19042
		internal global::AcpUI.AcpComboBox TrkEmerProfGeneralEmergencyOperation_A7926;

		// Token: 0x04004A63 RID: 19043
		internal global::AcpUI.AcpRtdButton RTDBtnTrkEmerProfGeneralEmergencyOperation_A7926;

		// Token: 0x04004A64 RID: 19044
		internal global::AcpUI.AcpCopyButton CpyBtnTrkEmerProfGeneralEmergencyOperation_A7926;

		// Token: 0x04004A65 RID: 19045
		internal global::AcpUI.AcpLabel TrkEmerProfGeneralEmergencyOperation_A7926Comp;

		// Token: 0x04004A66 RID: 19046
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkEmerProfGeneralRetryCounter_A8951;

		// Token: 0x04004A67 RID: 19047
		internal global::AcpUI.AcpLabel LblTrkEmerProfGeneralRetryCounter_A8951;

		// Token: 0x04004A68 RID: 19048
		internal global::AcpUI.AcpTextBoxSpinner TrkEmerProfGeneralRetryCounter_A8951;

		// Token: 0x04004A69 RID: 19049
		internal global::AcpUI.AcpRtdButton RTDBtnTrkEmerProfGeneralRetryCounter_A8951;

		// Token: 0x04004A6A RID: 19050
		internal global::AcpUI.AcpCopyButton CpyBtnTrkEmerProfGeneralRetryCounter_A8951;

		// Token: 0x04004A6B RID: 19051
		internal global::AcpUI.AcpLabel TrkEmerProfGeneralRetryCounter_A8951Comp;

		// Token: 0x04004A6C RID: 19052
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkEmerProfGeneralConsoleAckRequired_A7712;

		// Token: 0x04004A6D RID: 19053
		internal global::AcpUI.AcpLabel LblTrkEmerProfGeneralConsoleAckRequired_A7712;

		// Token: 0x04004A6E RID: 19054
		internal global::AcpUI.AcpCheckBox TrkEmerProfGeneralConsoleAckRequired_A7712;

		// Token: 0x04004A6F RID: 19055
		internal global::AcpUI.AcpRtdButton RTDBtnTrkEmerProfGeneralConsoleAckRequired_A7712;

		// Token: 0x04004A70 RID: 19056
		internal global::AcpUI.AcpCopyButton CpyBtnTrkEmerProfGeneralConsoleAckRequired_A7712;

		// Token: 0x04004A71 RID: 19057
		internal global::AcpUI.AcpCheckBox TrkEmerProfGeneralConsoleAckRequired_A7712Comp;

		// Token: 0x04004A72 RID: 19058
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkEmerProfGeneralEmergencyTalkback_A9268;

		// Token: 0x04004A73 RID: 19059
		internal global::AcpUI.AcpLabel LblTrkEmerProfGeneralEmergencyTalkback_A9268;

		// Token: 0x04004A74 RID: 19060
		internal global::AcpUI.AcpComboBox TrkEmerProfGeneralEmergencyTalkback_A9268;

		// Token: 0x04004A75 RID: 19061
		internal global::AcpUI.AcpRtdButton RTDBtnTrkEmerProfGeneralEmergencyTalkback_A9268;

		// Token: 0x04004A76 RID: 19062
		internal global::AcpUI.AcpCopyButton CpyBtnTrkEmerProfGeneralEmergencyTalkback_A9268;

		// Token: 0x04004A77 RID: 19063
		internal global::AcpUI.AcpLabel TrkEmerProfGeneralEmergencyTalkback_A9268Comp;

		// Token: 0x04004A78 RID: 19064
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkEmerProfGeneralRevertPTTID_A12642;

		// Token: 0x04004A79 RID: 19065
		internal global::AcpUI.AcpLabel LblTrkEmerProfGeneralRevertPTTID_A12642;

		// Token: 0x04004A7A RID: 19066
		internal global::AcpUI.AcpCheckBox TrkEmerProfGeneralRevertPTTID_A12642;

		// Token: 0x04004A7B RID: 19067
		internal global::AcpUI.AcpRtdButton RTDBtnTrkEmerProfGeneralRevertPTTID_A12642;

		// Token: 0x04004A7C RID: 19068
		internal global::AcpUI.AcpCopyButton CpyBtnTrkEmerProfGeneralRevertPTTID_A12642;

		// Token: 0x04004A7D RID: 19069
		internal global::AcpUI.AcpCheckBox TrkEmerProfGeneralRevertPTTID_A12642Comp;

		// Token: 0x04004A7E RID: 19070
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerManDownEnable_42039;

		// Token: 0x04004A7F RID: 19071
		internal global::AcpUI.AcpLabel LblTrkPerManDownEnable_42039;

		// Token: 0x04004A80 RID: 19072
		internal global::AcpUI.AcpCheckBox TrkPerManDownEnable_42039;

		// Token: 0x04004A81 RID: 19073
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerManDownEnable_42039;

		// Token: 0x04004A82 RID: 19074
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerManDownEnable_42039;

		// Token: 0x04004A83 RID: 19075
		internal global::AcpUI.AcpCheckBox TrkPerManDownEnable_42039Comp;

		// Token: 0x04004A84 RID: 19076
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnEmergencyExitOnChannelChange_43588;

		// Token: 0x04004A85 RID: 19077
		internal global::AcpUI.AcpLabel LblEmergencyExitOnChannelChange_43588;

		// Token: 0x04004A86 RID: 19078
		internal global::AcpUI.AcpCheckBox EmergencyExitOnChannelChange_43588;

		// Token: 0x04004A87 RID: 19079
		internal global::AcpUI.AcpRtdButton RTDBtnEmergencyExitOnChannelChange_43588;

		// Token: 0x04004A88 RID: 19080
		internal global::AcpUI.AcpCopyButton CpyBtnEmergencyExitOnChannelChange_43588;

		// Token: 0x04004A89 RID: 19081
		internal global::AcpUI.AcpCheckBox EmergencyExitOnChannelChange_43588Comp;

		// Token: 0x04004A8A RID: 19082
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkEmerProfGeneralRemoteActivationEmergency;

		// Token: 0x04004A8B RID: 19083
		internal global::AcpUI.AcpLabel LblTrkEmerProfGeneralRemoteActivationEmergency;

		// Token: 0x04004A8C RID: 19084
		internal global::AcpUI.AcpComboBox TrkEmerProfGeneralRemoteActivationEmergency;

		// Token: 0x04004A8D RID: 19085
		internal global::AcpUI.AcpRtdButton RTDBtnTrkEmerProfGeneralRemoteActivationEmergency;

		// Token: 0x04004A8E RID: 19086
		internal global::AcpUI.AcpCopyButton CpyBtnTrkEmerProfGeneralRemoteActivationEmergency;

		// Token: 0x04004A8F RID: 19087
		internal global::AcpUI.AcpLabel TrkEmerProfGeneralRemoteActivationEmergencyComp;

		// Token: 0x04004A90 RID: 19088
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingEmergencyProfilesGeneralAutoTransmit;

		// Token: 0x04004A91 RID: 19089
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkEmerProEmergencyAutoTransmitMode_A22567;

		// Token: 0x04004A92 RID: 19090
		internal global::AcpUI.AcpLabel LblTrkEmerProEmergencyAutoTransmitMode_A22567;

		// Token: 0x04004A93 RID: 19091
		internal global::AcpUI.AcpComboBox TrkEmerProEmergencyAutoTransmitMode_A22567;

		// Token: 0x04004A94 RID: 19092
		internal global::AcpUI.AcpRtdButton RTDBtnTrkEmerProEmergencyAutoTransmitMode_A22567;

		// Token: 0x04004A95 RID: 19093
		internal global::AcpUI.AcpCopyButton CpyBtnTrkEmerProEmergencyAutoTransmitMode_A22567;

		// Token: 0x04004A96 RID: 19094
		internal global::AcpUI.AcpLabel TrkEmerProEmergencyAutoTransmitMode_A22567Comp;

		// Token: 0x04004A97 RID: 19095
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkEmerProfGeneralTxPeriodsec2_A43601;

		// Token: 0x04004A98 RID: 19096
		internal global::AcpUI.AcpLabel LblTrkEmerProfGeneralTxPeriodsec2_A43601;

		// Token: 0x04004A99 RID: 19097
		internal global::AcpUI.AcpTextBoxSpinner TrkEmerProfGeneralTxPeriodsec2_A43601;

		// Token: 0x04004A9A RID: 19098
		internal global::AcpUI.AcpRtdButton RTDBtnTrkEmerProfGeneralTxPeriodsec2_A43601;

		// Token: 0x04004A9B RID: 19099
		internal global::AcpUI.AcpCopyButton CpyBtnTrkEmerProfGeneralTxPeriodsec2_A43601;

		// Token: 0x04004A9C RID: 19100
		internal global::AcpUI.AcpLabel TrkEmerProfGeneralTxPeriodsec2_A43601Comp;

		// Token: 0x04004A9D RID: 19101
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkEmerProfGeneralTxPeriodsec1_A7939;

		// Token: 0x04004A9E RID: 19102
		internal global::AcpUI.AcpLabel LblTrkEmerProfGeneralTxPeriodsec1_A7939;

		// Token: 0x04004A9F RID: 19103
		internal global::AcpUI.AcpTextBoxSpinner TrkEmerProfGeneralTxPeriodsec1_A7939;

		// Token: 0x04004AA0 RID: 19104
		internal global::AcpUI.AcpRtdButton RTDBtnTrkEmerProfGeneralTxPeriodsec1_A7939;

		// Token: 0x04004AA1 RID: 19105
		internal global::AcpUI.AcpCopyButton CpyBtnTrkEmerProfGeneralTxPeriodsec1_A7939;

		// Token: 0x04004AA2 RID: 19106
		internal global::AcpUI.AcpLabel TrkEmerProfGeneralTxPeriodsec1_A7939Comp;

		// Token: 0x04004AA3 RID: 19107
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkEmerProfGeneralTxPeriodsec2_A9132;

		// Token: 0x04004AA4 RID: 19108
		internal global::AcpUI.AcpLabel LblTrkEmerProfGeneralTxPeriodsec2_A9132;

		// Token: 0x04004AA5 RID: 19109
		internal global::AcpUI.AcpTextBoxSpinner TrkEmerProfGeneralTxPeriodsec2_A9132;

		// Token: 0x04004AA6 RID: 19110
		internal global::AcpUI.AcpRtdButton RTDBtnTrkEmerProfGeneralTxPeriodsec2_A9132;

		// Token: 0x04004AA7 RID: 19111
		internal global::AcpUI.AcpCopyButton CpyBtnTrkEmerProfGeneralTxPeriodsec2_A9132;

		// Token: 0x04004AA8 RID: 19112
		internal global::AcpUI.AcpLabel TrkEmerProfGeneralTxPeriodsec2_A9132Comp;

		// Token: 0x04004AA9 RID: 19113
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkEmerProfEmergencyHotAuxMic_A42300;

		// Token: 0x04004AAA RID: 19114
		internal global::AcpUI.AcpLabel LblTrkEmerProfEmergencyHotAuxMic_A42300;

		// Token: 0x04004AAB RID: 19115
		internal global::AcpUI.AcpComboBox TrkEmerProfEmergencyHotAuxMic_A42300;

		// Token: 0x04004AAC RID: 19116
		internal global::AcpUI.AcpRtdButton RTDBtnTrkEmerProfEmergencyHotAuxMic_A42300;

		// Token: 0x04004AAD RID: 19117
		internal global::AcpUI.AcpCopyButton CpyBtnTrkEmerProfEmergencyHotAuxMic_A42300;

		// Token: 0x04004AAE RID: 19118
		internal global::AcpUI.AcpLabel TrkEmerProfEmergencyHotAuxMic_A42300Comp;

		// Token: 0x04004AAF RID: 19119
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingEmergencyProfilesGeneralEmergencyFindMe;

		// Token: 0x04004AB0 RID: 19120
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPeEMGFindMeTxEnable_42921;

		// Token: 0x04004AB1 RID: 19121
		internal global::AcpUI.AcpLabel LblTrkPeEMGFindMeTxEnable_42921;

		// Token: 0x04004AB2 RID: 19122
		internal global::AcpUI.AcpCheckBox TrkPeEMGFindMeTxEnable_42921;

		// Token: 0x04004AB3 RID: 19123
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPeEMGFindMeTxEnable_42921;

		// Token: 0x04004AB4 RID: 19124
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPeEMGFindMeTxEnable_42921;

		// Token: 0x04004AB5 RID: 19125
		internal global::AcpUI.AcpCheckBox TrkPeEMGFindMeTxEnable_42921Comp;

		// Token: 0x04004AB6 RID: 19126
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPeEMGFindMeRxEnable_42923;

		// Token: 0x04004AB7 RID: 19127
		internal global::AcpUI.AcpLabel LblTrkPeEMGFindMeRxEnable_42923;

		// Token: 0x04004AB8 RID: 19128
		internal global::AcpUI.AcpCheckBox TrkPeEMGFindMeRxEnable_42923;

		// Token: 0x04004AB9 RID: 19129
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPeEMGFindMeRxEnable_42923;

		// Token: 0x04004ABA RID: 19130
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPeEMGFindMeRxEnable_42923;

		// Token: 0x04004ABB RID: 19131
		internal global::AcpUI.AcpCheckBox TrkPeEMGFindMeRxEnable_42923Comp;

		// Token: 0x04004ABC RID: 19132
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingEmergencyProfilesGeneralPseudo2;

		// Token: 0x04004ABD RID: 19133
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkEmerProfImpactDetectionEn_A43392;

		// Token: 0x04004ABE RID: 19134
		internal global::AcpUI.AcpLabel LblTrkEmerProfImpactDetectionEn_A43392;

		// Token: 0x04004ABF RID: 19135
		internal global::AcpUI.AcpCheckBox TrkEmerProfImpactDetectionEn_A43392;

		// Token: 0x04004AC0 RID: 19136
		internal global::AcpUI.AcpRtdButton RTDBtnTrkEmerProfImpactDetectionEn_A43392;

		// Token: 0x04004AC1 RID: 19137
		internal global::AcpUI.AcpCopyButton CpyBtnTrkEmerProfImpactDetectionEn_A43392;

		// Token: 0x04004AC2 RID: 19138
		internal global::AcpUI.AcpCheckBox TrkEmerProfImpactDetectionEn_A43392Comp;

		// Token: 0x04004AC3 RID: 19139
		internal global::AcpUI.AcpExpander ExpanderTrunkingEmergencyProfilesTrunkingEmergencyToneList;

		// Token: 0x04004AC4 RID: 19140
		internal global::AcpUI.AcpChildRecNavToolbar RecNavToolbarExpanderTrunkingEmergencyProfilesTrunkingEmergencyToneTable;

		// Token: 0x04004AC5 RID: 19141
		internal global::System.Windows.Controls.Grid ExpanderTrunkingEmergencyProfilesTrunkingEmergencyToneListGrid;

		// Token: 0x04004AC6 RID: 19142
		internal global::System.Windows.Controls.Grid ExpanderTrunkingEmergencyProfilesTrunkingEmergencyToneTableGrid;

		// Token: 0x04004AC7 RID: 19143
		internal global::AcpUI.AcpGroupBox ExpanderTrunkingEmergencyProfilesTrunkingEmergencyToneTableTableView;

		// Token: 0x04004AC8 RID: 19144
		internal global::AcpUI.AcpXamDataPresenter ExpanderTrunkingEmergencyProfilesTrunkingEmergencyToneTable;

		// Token: 0x04004AC9 RID: 19145
		internal global::Infragistics.Windows.DataPresenter.UnboundField EmergencyToneTrigger_42107_Col;

		// Token: 0x04004ACA RID: 19146
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkEmerTone_42108_Col;

		// Token: 0x04004ACB RID: 19147
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkEmerToneMinimumVolume_42109_Col;

		// Token: 0x04004ACC RID: 19148
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkEmerTonePeriodSec_42110_Col;

		// Token: 0x04004ACD RID: 19149
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkEmerAudioRouting_42111_Col;

		// Token: 0x04004ACE RID: 19150
		internal global::AcpUI.AcpGroupBox ExpanderTrunkingEmergencyProfilesTrunkingEmergencyToneTableSRecView;

		// Token: 0x04004ACF RID: 19151
		internal global::System.Windows.Controls.Grid gridExpanderTrunkingEmergencyProfilesTrunkingEmergencyToneTableSRecView;

		// Token: 0x04004AD0 RID: 19152
		internal global::AcpUI.AcpComboBox EmergencyToneTrigger_42107;

		// Token: 0x04004AD1 RID: 19153
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnEmergencyToneTrigger_42107;

		// Token: 0x04004AD2 RID: 19154
		internal global::AcpUI.AcpLabel LblEmergencyToneTrigger_42107;

		// Token: 0x04004AD3 RID: 19155
		internal global::AcpUI.AcpRtdButton RTDBtnEmergencyToneTrigger_42107;

		// Token: 0x04004AD4 RID: 19156
		internal global::AcpUI.AcpCopyButton CpyBtnEmergencyToneTrigger_42107;

		// Token: 0x04004AD5 RID: 19157
		internal global::AcpUI.AcpLabel EmergencyToneTrigger_42107Comp;

		// Token: 0x04004AD6 RID: 19158
		internal global::AcpUI.AcpComboBox TrkEmerTone_42108;

		// Token: 0x04004AD7 RID: 19159
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkEmerTone_42108;

		// Token: 0x04004AD8 RID: 19160
		internal global::AcpUI.AcpLabel LblTrkEmerTone_42108;

		// Token: 0x04004AD9 RID: 19161
		internal global::AcpUI.AcpRtdButton RTDBtnTrkEmerTone_42108;

		// Token: 0x04004ADA RID: 19162
		internal global::AcpUI.AcpCopyButton CpyBtnTrkEmerTone_42108;

		// Token: 0x04004ADB RID: 19163
		internal global::AcpUI.AcpLabel TrkEmerTone_42108Comp;

		// Token: 0x04004ADC RID: 19164
		internal global::AcpUI.AcpTextBoxSpinner TrkEmerToneMinimumVolume_42109;

		// Token: 0x04004ADD RID: 19165
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkEmerToneMinimumVolume_42109;

		// Token: 0x04004ADE RID: 19166
		internal global::AcpUI.AcpLabel LblTrkEmerToneMinimumVolume_42109;

		// Token: 0x04004ADF RID: 19167
		internal global::AcpUI.AcpRtdButton RTDBtnTrkEmerToneMinimumVolume_42109;

		// Token: 0x04004AE0 RID: 19168
		internal global::AcpUI.AcpCopyButton CpyBtnTrkEmerToneMinimumVolume_42109;

		// Token: 0x04004AE1 RID: 19169
		internal global::AcpUI.AcpLabel TrkEmerToneMinimumVolume_42109Comp;

		// Token: 0x04004AE2 RID: 19170
		internal global::AcpUI.AcpTextBoxSpinner TrkEmerTonePeriodSec_42110;

		// Token: 0x04004AE3 RID: 19171
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkEmerTonePeriodSec_42110;

		// Token: 0x04004AE4 RID: 19172
		internal global::AcpUI.AcpLabel LblTrkEmerTonePeriodSec_42110;

		// Token: 0x04004AE5 RID: 19173
		internal global::AcpUI.AcpRtdButton RTDBtnTrkEmerTonePeriodSec_42110;

		// Token: 0x04004AE6 RID: 19174
		internal global::AcpUI.AcpCopyButton CpyBtnTrkEmerTonePeriodSec_42110;

		// Token: 0x04004AE7 RID: 19175
		internal global::AcpUI.AcpLabel TrkEmerTonePeriodSec_42110Comp;

		// Token: 0x04004AE8 RID: 19176
		internal global::AcpUI.AcpComboBox TrkEmerAudioRouting_42111;

		// Token: 0x04004AE9 RID: 19177
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkEmerAudioRouting_42111;

		// Token: 0x04004AEA RID: 19178
		internal global::AcpUI.AcpLabel LblTrkEmerAudioRouting_42111;

		// Token: 0x04004AEB RID: 19179
		internal global::AcpUI.AcpRtdButton RTDBtnTrkEmerAudioRouting_42111;

		// Token: 0x04004AEC RID: 19180
		internal global::AcpUI.AcpCopyButton CpyBtnTrkEmerAudioRouting_42111;

		// Token: 0x04004AED RID: 19181
		internal global::AcpUI.AcpLabel TrkEmerAudioRouting_42111Comp;

		// Token: 0x04004AEE RID: 19182
		internal global::AcpUI.AcpExpander ExpanderTrunkingEmergencyProfilesEmergencyCompatibilityOptionsTrunking;

		// Token: 0x04004AEF RID: 19183
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingEmergencyProfilesEmergencyCompatibilityOptionsTrunkingPseudo0;

		// Token: 0x04004AF0 RID: 19184
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnEmergencyExitControl_43341;

		// Token: 0x04004AF1 RID: 19185
		internal global::AcpUI.AcpLabel LblEmergencyExitControl_43341;

		// Token: 0x04004AF2 RID: 19186
		internal global::AcpUI.AcpComboBox EmergencyExitControl_43341;

		// Token: 0x04004AF3 RID: 19187
		internal global::AcpUI.AcpRtdButton RTDBtnEmergencyExitControl_43341;

		// Token: 0x04004AF4 RID: 19188
		internal global::AcpUI.AcpCopyButton CpyBtnEmergencyExitControl_43341;

		// Token: 0x04004AF5 RID: 19189
		internal global::AcpUI.AcpLabel EmergencyExitControl_43341Comp;

		// Token: 0x04004AF6 RID: 19190
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnEmergencyHotMicRestart_43342;

		// Token: 0x04004AF7 RID: 19191
		internal global::AcpUI.AcpLabel LblEmergencyHotMicRestart_43342;

		// Token: 0x04004AF8 RID: 19192
		internal global::AcpUI.AcpCheckBox EmergencyHotMicRestart_43342;

		// Token: 0x04004AF9 RID: 19193
		internal global::AcpUI.AcpRtdButton RTDBtnEmergencyHotMicRestart_43342;

		// Token: 0x04004AFA RID: 19194
		internal global::AcpUI.AcpCopyButton CpyBtnEmergencyHotMicRestart_43342;

		// Token: 0x04004AFB RID: 19195
		internal global::AcpUI.AcpCheckBox EmergencyHotMicRestart_43342Comp;

		// Token: 0x04004AFC RID: 19196
		internal global::AcpUI.AcpExpander ExpanderTrunkingEmergencyProfilesLabtool;

		// Token: 0x04004AFD RID: 19197
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingEmergencyProfilesLabtoolPseudo0;

		// Token: 0x04004AFE RID: 19198
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkEmergencyToneSelection_42055;

		// Token: 0x04004AFF RID: 19199
		internal global::AcpUI.AcpLabel LblTrkEmergencyToneSelection_42055;

		// Token: 0x04004B00 RID: 19200
		internal global::AcpUI.AcpComboBox TrkEmergencyToneSelection_42055;

		// Token: 0x04004B01 RID: 19201
		internal global::AcpUI.AcpRtdButton RTDBtnTrkEmergencyToneSelection_42055;

		// Token: 0x04004B02 RID: 19202
		internal global::AcpUI.AcpCopyButton CpyBtnTrkEmergencyToneSelection_42055;

		// Token: 0x04004B03 RID: 19203
		internal global::AcpUI.AcpLabel TrkEmergencyToneSelection_42055Comp;

		// Token: 0x04004B04 RID: 19204
		private bool b;
	}
}
