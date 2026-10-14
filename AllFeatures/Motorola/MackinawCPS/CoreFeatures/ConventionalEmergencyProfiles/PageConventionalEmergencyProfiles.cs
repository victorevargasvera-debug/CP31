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

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles
{
	// Token: 0x02000494 RID: 1172
	public class PageConventionalEmergencyProfiles : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x06009AA9 RID: 39593 RVA: 0x0090D588 File Offset: 0x0090B788
		public PageConventionalEmergencyProfiles()
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

		// Token: 0x06009AAA RID: 39594 RVA: 0x0090D5C0 File Offset: 0x0090B7C0
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)49545216;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)841023491;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.IEnumerator enumerator;
					global::AcpUI.AcpExpander acpExpander;
					switch (num2)
					{
					case 0:
						goto IL_84;
					case 1:
					{
						this.RecNavToolbarPageConventionalEmergencyProfiles.ChildToolbars.Add(this.RecNavToolbarExpanderConventionalEmergencyProfilesEmergencyToneTable);
						object obj = null;
						obj = this.RecNavToolbarExpanderConventionalEmergencyProfilesEmergencyToneTable.MyRecordsetDataSource;
						num = (short)750612432;
						short num3 = num;
						num = (short)147288016;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1F2;
						default:
						{
							num = (short)945684480;
							if (num != 0)
							{
							}
							num = (short)1853620224;
							short num4 = num;
							num = (short)1718288385;
							if (num != 0)
							{
							}
							num = (short)1477771266;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 2:
					{
						object obj;
						if (obj != null)
						{
							num = (short)1117716485;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_84;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_61;
						}
						continue;
					case 4:
						try
						{
							num = (short)1971650563;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_310;
								case 1:
									if (!enumerator.MoveNext())
									{
										num = (short)35061764;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
									num = (short)1909784581;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_252;
									}
									continue;
								case 4:
									num = (short)609550336;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									if (acpExpander != null)
									{
										num = (short)841940998;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 6:
									base.Expanders.Add(acpExpander);
									num = (short)1249443842;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_254:
								num = (short)1506803713;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_252:
								goto IL_254;
							}
							IL_310:
							goto IL_1A9;
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
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)971898881;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_389;
								case 1:
									disposable.Dispose();
									num = (short)599064578;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_387;
								}
								goto IL_332;
							}
							IL_387:
							IL_389:
							goto EndFinally_8;
							IL_332:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1642266624;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_31F;
							EndFinally_8:;
						}
						goto IL_38A;
						IL_1A9:
						base.OnLoaded(sender, e);
						this.a = true;
						num = (short)1038483462;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						object obj;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderConventionalEmergencyProfilesEmergencyToneTable.MyDataPresenter = this.ExpanderConventionalEmergencyProfilesEmergencyToneTable;
						goto IL_1F2;
					}
					case 6:
						goto IL_1D0;
					}
					IL_61:
					if (!this.a)
					{
						num = (short)668467201;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_84:
					acpExpander = null;
					enumerator = this.MyStackPanel.Children.GetEnumerator();
					num = (short)91881476;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1F2:
					num = (short)1707147264;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1D0:
				IL_38A:
				this.MyStackPanel.Children[0].Focus();
				return;
			}
		}

		// Token: 0x06009AAB RID: 39595 RVA: 0x0090D98C File Offset: 0x0090BB8C
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
						num2 = (short)199622657;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
				{
					base.OnUnloaded(sender, e);
					this.a = false;
					num2 = (short)525160147;
					short num3 = num2;
					num2 = (short)1600868051;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1089142785;
						if (num2 != 0)
						{
						}
						num2 = (short)1251147776;
						if (num2 != 0)
						{
						}
						num2 = (short)1499070466;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			num2 = (short)1508769792;
			short num4 = num2;
			this.RecNavToolbarPageConventionalEmergencyProfiles.DataContext = null;
			this.RecNavToolbarExpanderConventionalEmergencyProfilesEmergencyToneTable.DataContext = null;
			this.RecNavToolbarPageConventionalEmergencyProfiles.MyDataPresenter = null;
			this.RecNavToolbarExpanderConventionalEmergencyProfilesEmergencyToneTable.MyDataPresenter = null;
			num2 = (short)798425088;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06009AAC RID: 39596 RVA: 0x0090DAE8 File Offset: 0x0090BCE8
		public override void SetDataContext()
		{
			short num = (short)844627973;
			int num2 = (int)((global::System.IntPtr)num);
			object feature;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)1328545798;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageConventionalEmergencyProfiles).MySecondaryRecordsetDataSource = null;
					num = (short)114098183;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2075);
					goto IL_158;
				case 2:
				{
					num = (short)1817313280;
					short num3 = num;
					goto IL_A7;
				}
				case 3:
					goto IL_A7;
				case 4:
					goto IL_233;
				case 5:
					num = (short)143851521;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_70;
					}
					continue;
				case 6:
					feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2075);
					num = (short)1079050248;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_1C1;
				case 8:
					if (feature != null)
					{
						num = (short)1616510980;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_70:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)1566441473;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2075);
				num = (short)981401603;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A7:
				this.RecNavToolbarPageConventionalEmergencyProfiles.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				num = (short)296986625;
				short num4 = num;
				num = (short)851224577;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_158:
					num = (short)2125463554;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1290862592;
					if (num != 0)
					{
					}
					num = (short)1936523264;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_1C1:
			return;
			IL_233:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageConventionalEmergencyProfiles).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
		}

		// Token: 0x06009AAD RID: 39597 RVA: 0x0090DD30 File Offset: 0x0090BF30
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 19;
			short num = (short)1505296384;
			switch (num)
			{
			default:
			{
				num = (short)1787822098;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						global::System.Windows.Data.CollectionView collectionView;
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.EmergencyToneTableInner emergencyToneTableInner;
						collectionView.MoveCurrentTo(emergencyToneTableInner);
						num = (short)1497825283;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_2EE;
					case 2:
					{
						global::System.Windows.Data.CollectionView collectionView;
						if (collectionView.Count > 0)
						{
							num = (short)1969750037;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36D;
					}
					case 3:
						goto IL_157;
					case 4:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)94240773;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)1546584071;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource = this.RecNavToolbarExpanderConventionalEmergencyProfilesEmergencyToneTable.MyRecordsetDataSource;
						num = (short)435945489;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_1B2;
					case 7:
						goto IL_248;
					case 8:
					{
						global::System.Windows.Data.CollectionView collectionView;
						collectionView.MoveCurrentToLast();
						num = (short)165281812;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource2;
						base.NavigationService.Navigate(new global::System.Uri(myRecordsetDataSource2.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
						num = (short)822149121;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						num = (short)539123278;
						short num3 = num;
						num = (short)2041929294;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
						{
							num = (short)2133786624;
							if (num != 0)
							{
							}
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.EmergencyToneTableInner emergencyToneTableInner;
							if (emergencyToneTableInner != null)
							{
								num = (short)1417478144;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1698627586;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 11:
					{
						object myRecordsetDataSource;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.EmergencyToneTableInner emergencyToneTableInner = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.EmergencyToneTableInner)collectionView.CurrentItem;
						num = (short)1234305034;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						num = (short)1362558980;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource2;
						if (myRecordsetDataSource2 != null)
						{
							num = (short)2103967753;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2EE;
					}
					case 14:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource2 = this.RecNavToolbarPageConventionalEmergencyProfiles.MyRecordsetDataSource;
						num = (short)332857357;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("蛓돕믗铙뷛꣝듟跡诣諥諧诩黫꯭裯英闳飵鳷鿹軻뷽濿氁爃挅昇縉攋愍縏猑砓匕甗缙減礝䔟䰡䜣弥砧堩䌫䠭夯帱儳䔵紷圹夻䰽✿❁⩃╅ㅇṉ⍋⁍㕏ّ㕓㑕㑗㽙", a_))
						{
							num = (short)1611137024;
							short num4 = num;
							num = (short)786169868;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 16:
						num = (short)1557659670;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
					{
						object myRecordsetDataSource;
						if (myRecordsetDataSource != null)
						{
							num = (short)988282891;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 18:
						switch (0)
						{
						case 0:
							goto IL_A8;
						}
						continue;
					case 19:
					{
						global::System.Windows.Data.CollectionView collectionView;
						if (collectionView.IsCurrentAfterLast)
						{
							num = (short)834469896;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						collectionView.MoveCurrentToFirst();
						num = (short)916783110;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						goto IL_21F;
					case 21:
						num = (short)1062338579;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("蛓돕믗铙뷛꣝듟跡诣諥諧诩黫뻭釯闱釳뗵韷铹諻鯽滿瘁洃椅昇欉怋䬍紏眑易焕紗琙缛朝瀟倡䬣䀥䄧䘩䤫崭", a_))
						{
							num = (short)1197998094;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2EE;
					}
					IL_A8:
					if (A_0 is global::AcpUI.AcpRecNavToolbar)
					{
						num = (short)1386938369;
						if (num != 0)
						{
						}
						num = (short)1297285136;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_2EE:
					num = (short)866254863;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_157:
				IL_1B2:
				IL_21F:
				goto IL_36D;
				IL_248:
				return;
				IL_36D:
				((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
				return;
			}
			}
		}

		// Token: 0x06009AAE RID: 39598 RVA: 0x0090E1E4 File Offset: 0x0090C3E4
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1876819968;
			short num2 = num;
			num = (short)2125922305;
			if (num != 0)
			{
			}
			num = (short)740523933;
			short num3 = num;
			num = (short)2037284765;
			switch (num3 == num)
			{
			}
			num = (short)1824522240;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x06009AAF RID: 39599 RVA: 0x0090E298 File Offset: 0x0090C498
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1193672704;
			short num2 = num;
			num = (short)1585970445;
			short num3 = num;
			num = (short)1113652493;
			switch (num3 == num)
			{
			}
			num = (short)1279983617;
			if (num != 0)
			{
			}
			num = (short)357302272;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06009AB0 RID: 39600 RVA: 0x0090E344 File Offset: 0x0090C544
		internal void OnExpanderConventionalEmergencyProfilesEmergencyToneTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_45;
				}
				int num3;
				object myRecordsetDataSource;
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.EmergencyToneTableInner item;
				for (;;)
				{
					IL_0A:
					num = (short)401801216;
					short num2 = num;
					switch (num3)
					{
					case 0:
						((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
						this.RecNavToolbarExpanderConventionalEmergencyProfilesEmergencyToneTable.SyncDataSources();
						num = (short)616431617;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_DE;
					case 2:
						if (myRecordsetDataSource != null)
						{
							num = (short)2133786624;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E0;
					}
					goto IL_45;
				}
				IL_E0:
				num = (short)1730091009;
				short num4 = num;
				num = (short)580655105;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_114;
				}
				IL_DE:
				goto IL_E0;
				IL_45:
				item = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.EmergencyToneTableInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
				myRecordsetDataSource = this.RecNavToolbarExpanderConventionalEmergencyProfilesEmergencyToneTable.MyRecordsetDataSource;
				num = (short)15335426;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			IL_114:
			num = (short)494534657;
			if (num != 0)
			{
			}
			num = (short)997916672;
			if (num != 0)
			{
			}
			this.RecNavToolbarExpanderConventionalEmergencyProfilesEmergencyToneTable.TableMode = false;
		}

		// Token: 0x06009AB1 RID: 39601 RVA: 0x0090E4B0 File Offset: 0x0090C6B0
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 14;
			if (!this.b)
			{
				short num = (short)517685121;
				short num2 = num;
				num = (short)830750593;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)191758336;
					short num3 = num;
					num = (short)1582891009;
					if (num != 0)
					{
					}
					num = (short)1618411520;
					if (num != 0)
					{
					}
					this.b = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("郐뿒맔釖볘뫚꧜꫞鏠蛢雤\udce6諨蓪胬鿮黰鷲郴駶跸퓺飼鋾搀焂戄戆月栊琌⨎⌐⌒瘔砖眘級琜砞吠儢䐤匦䀨䐪䌬.到尲嬴䄶尸唺䤼嘾⹀ⵂ⑄⭆汈祊経⩎㱐㙒❔ざ㱘㕚㹜♞䑠兢啤ᝦ᭨Ѫ୬ٮᵰᙲٴ塶᩸ᑺ፼ॾﺒﺘﺚﲞ\ud8a0펢힤좦쾨슪솬쪮슰鶲춴횶풸ힺ", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
		}

		// Token: 0x06009AB2 RID: 39602 RVA: 0x0090E590 File Offset: 0x0090C790
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1578827778;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)922353665;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_A33;
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
					goto IL_4A2;
				case 2:
					goto IL_A38;
				case 3:
				case 4:
				case 5:
				case 6:
				case 7:
					goto IL_1611;
				case 8:
					goto IL_11D6;
				case 9:
					goto IL_6D7;
				case 10:
					goto IL_145C;
				case 11:
					goto IL_609;
				case 12:
					goto IL_96A;
				case 13:
					goto IL_152D;
				case 14:
					goto IL_134A;
				case 15:
					goto IL_CA2;
				case 16:
					goto IL_F76;
				case 17:
					goto IL_D83;
				case 18:
					goto IL_14B4;
				case 19:
					goto IL_11F0;
				case 20:
					goto IL_149A;
				case 21:
					goto IL_746;
				case 22:
					goto IL_D1E;
				case 23:
					goto IL_D90;
				case 24:
					goto IL_FCB;
				case 25:
					goto IL_10B6;
				case 26:
					goto IL_950;
				case 27:
					goto IL_1013;
				case 28:
					goto IL_1604;
				case 29:
					goto IL_F21;
				case 30:
					goto IL_125F;
				case 31:
					goto IL_DB4;
				case 32:
					goto IL_9B4;
				case 33:
					goto IL_95D;
				case 34:
					goto IL_40C;
				case 35:
					goto IL_83E;
				case 36:
					goto IL_F83;
				case 37:
					goto IL_72C;
				case 38:
					goto IL_AE2;
				case 39:
					goto IL_6CA;
				case 40:
					goto IL_4F7;
				case 41:
					goto IL_753;
				case 42:
					goto IL_12B7;
				case 43:
					goto IL_11A5;
				case 44:
					goto IL_108F;
				case 45:
					goto IL_7F3;
				case 46:
					goto IL_1578;
				case 47:
					goto IL_4D3;
				case 48:
					goto IL_FA7;
				case 49:
					goto IL_12DB;
				case 50:
					goto IL_15DD;
				case 51:
					goto IL_3F2;
				case 52:
					goto IL_148D;
				case 53:
					goto IL_55F;
				case 54:
					goto IL_784;
				case 55:
					goto IL_504;
				case 56:
					goto IL_F14;
				case 57:
					goto IL_943;
				case 58:
					goto IL_457;
				case 59:
					goto IL_708;
				case 60:
					goto IL_5C1;
				case 61:
					goto IL_E19;
				case 62:
					goto IL_5B4;
				case 63:
					goto IL_118B;
				case 64:
					goto IL_E5A;
				case 65:
					goto IL_12F5;
				case 66:
					goto IL_CAF;
				case 67:
					goto IL_BC4;
				case 68:
					goto IL_5A7;
				case 69:
					goto IL_144F;
				case 70:
					goto IL_1051;
				case 71:
					goto IL_1435;
				case 72:
					goto IL_B6C;
				case 73:
					goto IL_FEF;
				case 74:
					goto IL_552;
				case 75:
					goto IL_1480;
				case 76:
					goto IL_ED3;
				case 77:
					goto IL_15AC;
				case 78:
					goto IL_651;
				case 79:
					goto IL_A9A;
				case 80:
					goto IL_824;
				case 81:
					goto IL_9F5;
				case 82:
					goto IL_9C1;
				case 83:
					goto IL_D38;
				case 84:
					goto IL_682;
				case 85:
					goto IL_BD1;
				case 86:
					goto IL_129D;
				case 87:
					goto IL_E4D;
				case 88:
					goto IL_8A0;
				case 89:
					goto IL_155E;
				case 90:
					goto IL_1509;
				case 91:
					goto IL_D45;
				case 92:
					goto IL_52B;
				case 93:
					goto IL_538;
				case 94:
					goto IL_1585;
				case 95:
					goto IL_EE0;
				case 96:
					goto IL_87C;
				case 97:
					goto IL_A76;
				case 98:
					goto IL_8AD;
				case 99:
					goto IL_8F8;
				case 100:
					goto IL_13AC;
				case 101:
					goto IL_D11;
				case 102:
					goto IL_1357;
				case 103:
					goto IL_47E;
				case 104:
					goto IL_1388;
				case 105:
					goto IL_A69;
				case 106:
					goto IL_114D;
				case 107:
					goto IL_8EB;
				case 108:
					goto IL_1082;
				case 109:
					goto IL_62D;
				case 110:
					goto IL_ABE;
				case 111:
					goto IL_D76;
				case 112:
					goto IL_1592;
				case 113:
					goto IL_E26;
				case 114:
					goto IL_F45;
				case 115:
					goto IL_1221;
				case 116:
					goto IL_1167;
				case 117:
					goto IL_5E5;
				case 118:
					goto IL_A02;
				case 119:
					goto IL_15F7;
				case 120:
					goto IL_DFF;
				case 121:
					goto IL_BAA;
				case 122:
					goto IL_CED;
				case 123:
					goto IL_8BA;
				case 124:
					goto IL_14A7;
				case 125:
					goto IL_831;
				case 126:
					goto IL_F07;
				case 127:
					goto IL_1319;
				case 128:
					goto IL_A5C;
				case 129:
					goto IL_91F;
				case 130:
					goto IL_10DD;
				case 131:
					goto IL_3E5;
				case 132:
					goto IL_86F;
				case 133:
					goto IL_1290;
				case 134:
					goto IL_905;
				case 135:
					goto IL_10D0;
				case 136:
					goto IL_44A;
				case 137:
					goto IL_105E;
				case 138:
					goto IL_800;
				case 139:
					goto IL_777;
				case 140:
					goto IL_C57;
				case 141:
					goto IL_15EA;
				case 142:
					goto IL_C19;
				case 143:
					goto IL_141B;
				case 144:
					goto IL_B24;
				case 145:
					goto IL_B48;
				case 146:
					goto IL_9E8;
				case 147:
					goto IL_545;
				case 148:
					goto IL_140E;
				case 149:
					goto IL_12AA;
				case 150:
					goto IL_E67;
				case 151:
					goto IL_DC1;
				case 152:
					goto IL_9DB;
				case 153:
					goto IL_C64;
				case 154:
					goto IL_9CE;
				case 155:
					goto IL_CD3;
				case 156:
					goto IL_419;
				case 157:
					goto IL_C33;
				case 158:
					goto IL_DF2;
				case 159:
					goto IL_B9D;
				case 160:
					goto IL_3D8;
				case 161:
					goto IL_156B;
				case 162:
					goto IL_BF5;
				case 163:
					goto IL_D2B;
				case 164:
					goto IL_C71;
				case 165:
					goto IL_12E8;
				case 166:
					goto IL_A0F;
				case 167:
					goto IL_1442;
				case 168:
					goto IL_BB7;
				case 169:
					goto IL_675;
				case 170:
					goto IL_7CC;
				case 171:
					goto IL_862;
				case 172:
					goto IL_115A;
				case 173:
					goto IL_1214;
				case 174:
					goto IL_1364;
				case 175:
					goto IL_EFA;
				case 176:
					goto IL_1020;
				case 177:
					goto IL_739;
				case 178:
					goto IL_912;
				case 179:
					goto IL_1428;
				case 180:
					goto IL_14E5;
				case 181:
					goto IL_51E;
				case 182:
					goto IL_11B2;
				case 183:
					goto IL_B17;
				case 184:
					goto IL_3FF;
				case 185:
					goto IL_B90;
				case 186:
					goto IL_583;
				case 187:
					goto IL_1198;
				case 188:
					goto IL_7A8;
				case 189:
					goto IL_10C3;
				case 190:
					goto IL_7D9;
				case 191:
					goto IL_DE5;
				case 192:
					goto IL_13B9;
				case 193:
					goto IL_1044;
				case 194:
					goto IL_6A6;
				case 195:
					goto IL_C26;
				case 196:
					goto IL_7E6;
				case 197:
					goto IL_464;
				case 198:
					goto IL_122E;
				case 199:
					goto IL_E33;
				case 200:
					goto IL_C7E;
				case 201:
					goto IL_14D8;
				case 202:
					goto IL_511;
				case 203:
					goto IL_159F;
				case 204:
					goto IL_8DE;
				case 205:
					goto IL_43D;
				case 206:
					goto IL_6FB;
				case 207:
					goto IL_15B9;
				case 208:
					goto IL_F52;
				case 209:
					goto IL_E0C;
				case 210:
					goto IL_109C;
				case 211:
					goto IL_EED;
				case 212:
					goto IL_CE0;
				case 213:
					goto IL_E8B;
				case 214:
					goto IL_EAF;
				case 215:
					goto IL_1283;
				case 216:
					goto IL_13DD;
				case 217:
					goto IL_1551;
				case 218:
					goto IL_10A9;
				case 219:
					goto IL_E40;
				case 220:
					goto IL_471;
				case 221:
					goto IL_13EA;
				case 222:
					goto IL_1326;
				case 223:
					goto IL_11E3;
				case 224:
					goto IL_1252;
				case 225:
					goto IL_D69;
				default:
					num = (short)763887616;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_3D8:
			this.CnvEmerProfMDCEnable2_A7924Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_3E5:
			this.RTDBtnCnvEmerProfImpactDetectionEn_A43391 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3F2:
			this.CnvEmerProfGeneralImpoliteRetries_A8242Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3FF:
			this.CpyBtnEmerTone_42046 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_40C:
			this.CVBtnCnvEmerProfGeneralAcknowledgeAlertTone_A7394 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_419:
			this.LblCnvEmerProfMDCEnable2_A7924 = (global::AcpUI.AcpLabel)target;
			this.LblCnvEmerProfMDCEnable2_A7924.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_43D:
			this.GrpBoxExpanderConventionalEmergencyProfilesEmergencyCompatibilityOptionsConventionalPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_44A:
			this.CVBtnCnvEmerProfMDCEmergencyPTTIDSidetone_A7946 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_457:
			this.CVBtnEmergencyExitOnChannelChange_43590 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_464:
			this.EmerTonePeriodSec_42048Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_471:
			this.CVBtnCnvEmergencyToneSelection_42053 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_47E:
			this.LblCnvEmerProfGeneralEnable3_A8171 = (global::AcpUI.AcpLabel)target;
			this.LblCnvEmerProfGeneralEnable3_A8171.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4A2:
			((global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.PageConventionalEmergencyProfiles)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.PageConventionalEmergencyProfiles)target).Unloaded += this.OnUnloaded;
			return;
			IL_4D3:
			this.LblCnvEmerProfGeneralImpoliteRetries_A8242 = (global::AcpUI.AcpLabel)target;
			this.LblCnvEmerProfGeneralImpoliteRetries_A8242.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4F7:
			this.CVBtnCnvEmerProfGeneralPoliteRetries_A8712 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_504:
			this.RTDBtnCnvPerManDownEnable_42038 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_511:
			this.CpyBtnEmerAudioRouting_42049 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_51E:
			this.CVBtnEmerTone_42046 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_52B:
			this.RTDBtnCnvEmerProfGeneralTxPeriodsec2_A9131 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_538:
			this.CpyBtnCnvEmerProfGeneralTxPeriodsec2_A9131 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_545:
			this.CpyBtnCnvEmerProfMDCTxBaseTimeSec_A9514 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_552:
			this.RTDBtnConEmerProEmergencyAutoTransmitMode_A22532 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_55F:
			this.LblCnvPerManDownEnable_42038 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerManDownEnable_42038.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_583:
			this.EmerToneMinimumVolumn_42047 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.EmerToneMinimumVolumn_42047.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5A7:
			this.CpyBtnCnvEmerProfGeneralRemoteActivationEmergency = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5B4:
			this.CpyBtnEmergencyExitOnChannelChange_43590 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5C1:
			this.EmergencyExitOnChannelChange_43590 = (global::AcpUI.AcpCheckBox)target;
			this.EmergencyExitOnChannelChange_43590.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5E5:
			this.CnvPerEMGFindMeTxEnable_42920 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerEMGFindMeTxEnable_42920.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_609:
			this.HLinkEmergencyToneList = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkEmergencyToneList.Click += this.HLinkClick;
			return;
			IL_62D:
			this.LblCnvEmerProfGeneralFactor_A9548 = (global::AcpUI.AcpLabel)target;
			this.LblCnvEmerProfGeneralFactor_A9548.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_651:
			this.LblCnvEmerProfGeneralTxPeriodsec2_A43600 = (global::AcpUI.AcpLabel)target;
			this.LblCnvEmerProfGeneralTxPeriodsec2_A43600.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_675:
			this.EmerToneMinimumVolumn_42047_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_682:
			this.LblCnvEmerProfGeneralTxPeriodsec1_A8212 = (global::AcpUI.AcpLabel)target;
			this.LblCnvEmerProfGeneralTxPeriodsec1_A8212.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_6A6:
			this.LblEmerTonePeriodSec_42048 = (global::AcpUI.AcpLabel)target;
			this.LblEmerTonePeriodSec_42048.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_6CA:
			this.CnvEmerProfGeneralAcknowledgeAlertTone_A7394Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_6D7:
			this.HLinkGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkGeneral.Click += this.HLinkClick;
			return;
			IL_6FB:
			this.CVBtnEmergencyExitControl_43344 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_708:
			this.LblEmergencyExitOnChannelChange_43590 = (global::AcpUI.AcpLabel)target;
			this.LblEmergencyExitOnChannelChange_43590.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_72C:
			this.RTDBtnCnvEmerProfGeneralAcknowledgeAlertTone_A7394 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_739:
			this.RTDBtnEmergencyToneTrigger_42045 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_746:
			this.CnvEmerProfGeneralkeyofConventionalEmergencyProfiles_A19418Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_753:
			this.LblCnvEmerProfGeneralPoliteRetries_A8712 = (global::AcpUI.AcpLabel)target;
			this.LblCnvEmerProfGeneralPoliteRetries_A8712.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_777:
			this.RTDBtnCnvEmerProfMDCEmergencyPTTIDSidetone_A7946 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_784:
			this.CnvPerManDownEnable_42038 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerManDownEnable_42038.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_7A8:
			this.LblEmerToneMinimumVolumn_42047 = (global::AcpUI.AcpLabel)target;
			this.LblEmerToneMinimumVolumn_42047.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_7CC:
			this.EmerTonePeriodSec_42048_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_7D9:
			this.CpyBtnEmerToneMinimumVolumn_42047 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_7E6:
			this.CpyBtnEmerTonePeriodSec_42048 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_7F3:
			this.CnvEmerProfGeneralPoliteRetries_A8712Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_800:
			this.CnvEmerProfMDCEmergencyPTTIDSidetone_A7946 = (global::AcpUI.AcpCheckBox)target;
			this.CnvEmerProfMDCEmergencyPTTIDSidetone_A7946.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_824:
			this.RTDBtnCnvEmerProfGeneralTxPeriodsec2_A43600 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_831:
			this.CpyBtnCnvPerEMGFindMeRxEnable_42922 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_83E:
			this.LblCnvEmerProfGeneralAcknowledgeAlertTone_A7394 = (global::AcpUI.AcpLabel)target;
			this.LblCnvEmerProfGeneralAcknowledgeAlertTone_A7394.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_862:
			this.EmerAudioRouting_42049_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_86F:
			this.CpyBtnCnvEmerProfImpactDetectionEn_A43391 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_87C:
			this.LblCnvEmerProfEmergencyHotAuxMic_A42296 = (global::AcpUI.AcpLabel)target;
			this.LblCnvEmerProfEmergencyHotAuxMic_A42296.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_8A0:
			this.CnvEmerProfGeneralTxPeriodsec1_A8212Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_8AD:
			this.RTDBtnCnvEmerProfEmergencyHotAuxMic_A42296 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_8BA:
			this.CnvPerEMGFindMeRxEnable_42922 = (global::AcpUI.AcpCheckBox)target;
			this.CnvPerEMGFindMeRxEnable_42922.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_8DE:
			this.ExpanderConventionalEmergencyProfilesEmergencyCompatibilityOptionsConventional = (global::AcpUI.AcpExpander)target;
			return;
			IL_8EB:
			this.CnvEmerProfGeneralEnable3_A8171Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_8F8:
			this.CpyBtnCnvEmerProfEmergencyHotAuxMic_A42296 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_905:
			this.ExpanderConventionalEmergencyProfilesMDC = (global::AcpUI.AcpExpander)target;
			return;
			IL_912:
			this.CpyBtnEmergencyToneTrigger_42045 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_91F:
			this.LblCnvEmerProfImpactDetectionEn_A43391 = (global::AcpUI.AcpLabel)target;
			this.LblCnvEmerProfImpactDetectionEn_A43391.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_943:
			this.CnvPerManDownEnable_42038Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_950:
			this.CpyBtnCnvEmerProfGeneralEmergencyType_A7960 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_95D:
			this.CnvEmerProfGeneralConsoleAckRequired_A40167Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_96A:
			num = (short)1783955457;
			if (num != 0)
			{
			}
			this.HLinkEmergencyCompatibilityOptionsConventional = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkEmergencyCompatibilityOptionsConventional.Click += this.HLinkClick;
			return;
			IL_9B4:
			this.CpyBtnCnvEmerProfGeneralConsoleAckRequired_A40167 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9C1:
			this.CnvEmerProfGeneralTxPeriodsec2_A43600Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_9CE:
			this.CnvEmerProfMDCRxBaseTimesec_A8999Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_9DB:
			this.RTDBtnCnvEmerProfMDCRxBaseTimesec_A8999 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_9E8:
			this.RTDBtnCnvEmerProfMDCTxBaseTimeSec_A9514 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_9F5:
			this.CpyBtnCnvEmerProfGeneralTxPeriodsec2_A43600 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A02:
			this.RTDBtnCnvPerEMGFindMeTxEnable_42920 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A0F:
			this.ExpanderConventionalEmergencyProfilesEmergencyToneTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_A33:
			goto IL_1611;
			IL_A38:
			this.RecNavToolbarPageConventionalEmergencyProfiles = (global::AcpUI.AcpParentRecNavToolbar)target;
			this.RecNavToolbarPageConventionalEmergencyProfiles.ModeClick += this.OnModeClick;
			return;
			IL_A5C:
			this.CVBtnCnvEmerProfImpactDetectionEn_A43391 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A69:
			this.RTDBtnCnvEmerProfGeneralEnable3_A8171 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A76:
			this.CnvEmerProfEmergencyHotAuxMic_A42296 = (global::AcpUI.AcpComboBox)target;
			this.CnvEmerProfEmergencyHotAuxMic_A42296.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_A9A:
			this.CnvEmerProfGeneralTxPeriodsec2_A43600 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvEmerProfGeneralTxPeriodsec2_A43600.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_ABE:
			this.CnvEmerProfGeneralFactor_A9548 = (global::AcpUI.AcpComboBox)target;
			this.CnvEmerProfGeneralFactor_A9548.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_AE2:
			num = (short)1046544384;
			short num3 = num;
			this.CpyBtnCnvEmerProfGeneralAcknowledgeAlertTone_A7394 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B17:
			this.RTDBtnEmerTone_42046 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_B24:
			this.LblCnvEmerProfMDCTxBaseTimeSec_A9514 = (global::AcpUI.AcpLabel)target;
			this.LblCnvEmerProfMDCTxBaseTimeSec_A9514.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_B48:
			this.CnvEmerProfMDCTxBaseTimeSec_A9514 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvEmerProfMDCTxBaseTimeSec_A9514.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B6C:
			this.LblConEmerProEmergencyAutoTransmitMode_A22532 = (global::AcpUI.AcpLabel)target;
			this.LblConEmerProEmergencyAutoTransmitMode_A22532.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_B90:
			this.EmerTone_42046Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_B9D:
			this.CpyBtnCnvEmerProfMDCEnable2_A7924 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_BAA:
			this.CVBtnCnvPerEMGFindMeRxEnable_42922 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_BB7:
			this.EmerTone_42046_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_BC4:
			this.RTDBtnCnvEmerProfGeneralRemoteActivationEmergency = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_BD1:
			this.CnvEmerProfGeneralTxPeriodsec1_A8212 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvEmerProfGeneralTxPeriodsec1_A8212.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_BF5:
			this.RecNavToolbarExpanderConventionalEmergencyProfilesEmergencyToneTable = (global::AcpUI.AcpChildRecNavToolbar)target;
			this.RecNavToolbarExpanderConventionalEmergencyProfilesEmergencyToneTable.ModeClick += this.OnModeClick;
			return;
			IL_C19:
			this.GrpBoxExpanderConventionalEmergencyProfilesMDCEmergencyRemoteMonitor = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_C26:
			this.RTDBtnEmerTonePeriodSec_42048 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_C33:
			this.CnvEmerProfMDCEnable2_A7924 = (global::AcpUI.AcpCheckBox)target;
			this.CnvEmerProfMDCEnable2_A7924.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_C57:
			this.CpyBtnCnvEmerProfMDCEmergencyPTTIDSidetone_A7946 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_C64:
			this.CpyBtnCnvEmerProfMDCRxBaseTimesec_A8999 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_C71:
			this.ExpanderConventionalEmergencyProfilesEmergencyToneTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_C7E:
			this.LblEmerAudioRouting_42049 = (global::AcpUI.AcpLabel)target;
			this.LblEmerAudioRouting_42049.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_CA2:
			this.ExpanderConventionalEmergencyProfilesGeneral = (global::AcpUI.AcpExpander)target;
			return;
			IL_CAF:
			this.CnvEmerProfGeneralRemoteActivationEmergency = (global::AcpUI.AcpComboBox)target;
			this.CnvEmerProfGeneralRemoteActivationEmergency.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_CD3:
			this.CVBtnCnvEmerProfMDCEnable2_A7924 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_CE0:
			this.CVBtnEmergencyHotMicReStart_43343 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_CED:
			this.LblCnvPerEMGFindMeRxEnable_42922 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerEMGFindMeRxEnable_42922.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_D11:
			this.GrpBoxExpanderConventionalEmergencyProfilesGeneralTxMultiplier = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_D1E:
			this.CVBtnCnvEmerProfGeneralEmergencyType_A7960 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_D2B:
			this.ExpanderConventionalEmergencyProfilesEmergencyToneListGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_D38:
			this.CVBtnCnvEmerProfGeneralTxPeriodsec1_A8212 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_D45:
			this.CnvEmerProfGeneralTxPeriodsec2_A9131 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvEmerProfGeneralTxPeriodsec2_A9131.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_D69:
			this.CnvEmergencyToneSelection_42053Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_D76:
			this.RTDBtnCnvEmerProfGeneralFactor_A9548 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_D83:
			this.CVBtnCnvEmerProfGeneralkeyofConventionalEmergencyProfiles_A19418 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_D90:
			this.LblCnvEmerProfGeneralEmergencyType_A7960 = (global::AcpUI.AcpLabel)target;
			this.LblCnvEmerProfGeneralEmergencyType_A7960.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_DB4:
			this.RTDBtnCnvEmerProfGeneralConsoleAckRequired_A40167 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_DC1:
			this.CnvEmerProfMDCRxBaseTimesec_A8999 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvEmerProfMDCRxBaseTimesec_A8999.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_DE5:
			this.EmerToneMinimumVolumn_42047Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_DF2:
			this.RTDBtnCnvEmerProfMDCEnable2_A7924 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_DFF:
			this.CnvPerEMGFindMeTxEnable_42920Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_E0C:
			this.RTDBtnEmergencyExitControl_43344 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_E19:
			this.RTDBtnEmergencyExitOnChannelChange_43590 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_E26:
			this.CnvEmerProfGeneralFactor_A9548Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_E33:
			this.CVBtnEmerAudioRouting_42049 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_E40:
			this.GrpBoxExpanderConventionalEmergencyProfilesLabtoolPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_E4D:
			this.CpyBtnCnvEmerProfGeneralTxPeriodsec1_A8212 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_E5A:
			this.CVBtnCnvEmerProfGeneralRemoteActivationEmergency = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_E67:
			this.LblCnvEmerProfMDCRxBaseTimesec_A8999 = (global::AcpUI.AcpLabel)target;
			this.LblCnvEmerProfMDCRxBaseTimesec_A8999.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_E8B:
			this.LblEmergencyHotMicReStart_43343 = (global::AcpUI.AcpLabel)target;
			this.LblEmergencyHotMicReStart_43343.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_EAF:
			this.EmergencyHotMicReStart_43343 = (global::AcpUI.AcpCheckBox)target;
			this.EmergencyHotMicReStart_43343.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_ED3:
			this.ConEmerProEmergencyAutoTransmitMode_A22532Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_EE0:
			this.CVBtnCnvEmerProfEmergencyHotAuxMic_A42296 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_EED:
			this.EmergencyExitControl_43344Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_EFA:
			this.CVBtnEmergencyToneTrigger_42045 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_F07:
			this.CnvPerEMGFindMeRxEnable_42922Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_F14:
			this.CpyBtnCnvPerManDownEnable_42038 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_F21:
			this.LblCnvEmerProfGeneralConsoleAckRequired_A40167 = (global::AcpUI.AcpLabel)target;
			this.LblCnvEmerProfGeneralConsoleAckRequired_A40167.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_F45:
			this.GrpBoxExpanderConventionalEmergencyProfilesGeneralEmergencyFindMe = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_F52:
			this.EmergencyExitControl_43344 = (global::AcpUI.AcpComboBox)target;
			this.EmergencyExitControl_43344.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_F76:
			this.GrpBoxExpanderConventionalEmergencyProfilesGeneralPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_F83:
			this.CnvEmerProfGeneralAcknowledgeAlertTone_A7394 = (global::AcpUI.AcpCheckBox)target;
			this.CnvEmerProfGeneralAcknowledgeAlertTone_A7394.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_FA7:
			this.CnvEmerProfGeneralImpoliteRetries_A8242 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvEmerProfGeneralImpoliteRetries_A8242.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_FCB:
			this.CnvEmerProfGeneralEmergencyType_A7960 = (global::AcpUI.AcpComboBox)target;
			this.CnvEmerProfGeneralEmergencyType_A7960.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_FEF:
			this.ConEmerProEmergencyAutoTransmitMode_A22532 = (global::AcpUI.AcpComboBox)target;
			this.ConEmerProEmergencyAutoTransmitMode_A22532.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1013:
			this.CnvEmerProfGeneralEmergencyType_A7960Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1020:
			this.LblEmergencyToneTrigger_42045 = (global::AcpUI.AcpLabel)target;
			this.LblEmergencyToneTrigger_42045.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1044:
			this.CVBtnEmerTonePeriodSec_42048 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1051:
			this.GrpBoxExpanderConventionalEmergencyProfilesGeneralAutoTransmit = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_105E:
			this.LblCnvEmerProfMDCEmergencyPTTIDSidetone_A7946 = (global::AcpUI.AcpLabel)target;
			this.LblCnvEmerProfMDCEmergencyPTTIDSidetone_A7946.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1082:
			this.CVBtnCnvEmerProfGeneralFactor_A9548 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_108F:
			this.CpyBtnCnvEmerProfGeneralPoliteRetries_A8712 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_109C:
			this.CpyBtnEmergencyExitControl_43344 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_10A9:
			this.ExpanderConventionalEmergencyProfilesLabtool = (global::AcpUI.AcpExpander)target;
			return;
			IL_10B6:
			this.RTDBtnCnvEmerProfGeneralEmergencyType_A7960 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_10C3:
			this.RTDBtnEmerToneMinimumVolumn_42047 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_10D0:
			this.GrpBoxExpanderConventionalEmergencyProfilesMDCPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_10DD:
			num = (short)91920167;
			short num4 = num;
			num = (short)109877031;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_A76;
			default:
				num = (short)142868480;
				if (num != 0)
				{
				}
				this.CnvEmerProfImpactDetectionEn_A43391 = (global::AcpUI.AcpCheckBox)target;
				this.CnvEmerProfImpactDetectionEn_A43391.GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			IL_114D:
			this.CpyBtnCnvEmerProfGeneralEnable3_A8171 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_115A:
			this.ExpanderConventionalEmergencyProfilesEmergencyToneTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1167:
			this.LblCnvPerEMGFindMeTxEnable_42920 = (global::AcpUI.AcpLabel)target;
			this.LblCnvPerEMGFindMeTxEnable_42920.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_118B:
			this.EmergencyExitOnChannelChange_43590Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1198:
			this.CVBtnEmerToneMinimumVolumn_42047 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_11A5:
			this.RTDBtnCnvEmerProfGeneralPoliteRetries_A8712 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_11B2:
			this.LblEmerTone_42046 = (global::AcpUI.AcpLabel)target;
			this.LblEmerTone_42046.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_11D6:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_11E3:
			this.RTDBtnCnvEmergencyToneSelection_42053 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_11F0:
			this.CnvEmerProfGeneralkeyofConventionalEmergencyProfiles_A19418 = (global::AcpUI.AcpTextBox)target;
			this.CnvEmerProfGeneralkeyofConventionalEmergencyProfiles_A19418.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1214:
			this.gridExpanderConventionalEmergencyProfilesEmergencyToneTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_1221:
			this.CVBtnCnvPerEMGFindMeTxEnable_42920 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_122E:
			this.EmerAudioRouting_42049 = (global::AcpUI.AcpComboBox)target;
			this.EmerAudioRouting_42049.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1252:
			this.CpyBtnCnvEmergencyToneSelection_42053 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_125F:
			this.CnvEmerProfGeneralConsoleAckRequired_A40167 = (global::AcpUI.AcpCheckBox)target;
			this.CnvEmerProfGeneralConsoleAckRequired_A40167.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1283:
			this.RTDBtnEmergencyHotMicReStart_43343 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1290:
			this.CnvEmerProfImpactDetectionEn_A43391Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_129D:
			this.RTDBtnCnvEmerProfGeneralTxPeriodsec1_A8212 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_12AA:
			this.CVBtnCnvEmerProfMDCRxBaseTimesec_A8999 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_12B7:
			this.CnvEmerProfGeneralPoliteRetries_A8712 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.CnvEmerProfGeneralPoliteRetries_A8712.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_12DB:
			this.RTDBtnCnvEmerProfGeneralImpoliteRetries_A8242 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_12E8:
			this.ExpanderConventionalEmergencyProfilesEmergencyToneTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_12F5:
			this.LblCnvEmerProfGeneralRemoteActivationEmergency = (global::AcpUI.AcpLabel)target;
			this.LblCnvEmerProfGeneralRemoteActivationEmergency.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1319:
			this.GrpBoxExpanderConventionalEmergencyProfilesGeneralPseudo3 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1326:
			this.CnvEmergencyToneSelection_42053 = (global::AcpUI.AcpComboBox)target;
			this.CnvEmergencyToneSelection_42053.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_134A:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_1357:
			this.CVBtnCnvEmerProfGeneralEnable3_A8171 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1364:
			this.EmergencyToneTrigger_42045 = (global::AcpUI.AcpComboBox)target;
			this.EmergencyToneTrigger_42045.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1388:
			this.CnvEmerProfGeneralEnable3_A8171 = (global::AcpUI.AcpCheckBox)target;
			this.CnvEmerProfGeneralEnable3_A8171.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_13AC:
			this.CnvEmerProfEmergencyHotAuxMic_A42296Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_13B9:
			this.EmerTonePeriodSec_42048 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.EmerTonePeriodSec_42048.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_13DD:
			this.CpyBtnEmergencyHotMicReStart_43343 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_13EA:
			this.LblCnvEmergencyToneSelection_42053 = (global::AcpUI.AcpLabel)target;
			this.LblCnvEmergencyToneSelection_42053.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_140E:
			this.CnvEmerProfMDCTxBaseTimeSec_A9514Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_141B:
			this.CVBtnCnvEmerProfMDCTxBaseTimeSec_A9514 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1428:
			this.EmergencyToneTrigger_42045Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1435:
			this.CVBtnConEmerProEmergencyAutoTransmitMode_A22532 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1442:
			this.EmergencyToneTrigger_42045_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_144F:
			this.CnvEmerProfGeneralRemoteActivationEmergencyComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_145C:
			this.HLinkMDC = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkMDC.Click += this.HLinkClick;
			return;
			IL_1480:
			this.CpyBtnConEmerProEmergencyAutoTransmitMode_A22532 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_148D:
			this.CVBtnCnvPerManDownEnable_42038 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_149A:
			this.CpyBtnCnvEmerProfGeneralkeyofConventionalEmergencyProfiles_A19418 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_14A7:
			this.RTDBtnCnvPerEMGFindMeRxEnable_42922 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_14B4:
			this.LblCnvEmerProfGeneralkeyofConventionalEmergencyProfiles_A19418 = (global::AcpUI.AcpLabel)target;
			this.LblCnvEmerProfGeneralkeyofConventionalEmergencyProfiles_A19418.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_14D8:
			this.RTDBtnEmerAudioRouting_42049 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_14E5:
			this.EmerTone_42046 = (global::AcpUI.AcpComboBox)target;
			this.EmerTone_42046.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1509:
			this.LblCnvEmerProfGeneralTxPeriodsec2_A9131 = (global::AcpUI.AcpLabel)target;
			this.LblCnvEmerProfGeneralTxPeriodsec2_A9131.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_152D:
			this.HLinkLabtool = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkLabtool.Click += this.HLinkClick;
			return;
			IL_1551:
			this.EmergencyHotMicReStart_43343Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_155E:
			this.CVBtnCnvEmerProfGeneralTxPeriodsec2_A9131 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_156B:
			this.ExpanderConventionalEmergencyProfilesEmergencyToneList = (global::AcpUI.AcpExpander)target;
			return;
			IL_1578:
			this.CVBtnCnvEmerProfGeneralImpoliteRetries_A8242 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1585:
			this.CnvEmerProfGeneralTxPeriodsec2_A9131Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1592:
			this.CpyBtnCnvEmerProfGeneralFactor_A9548 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_159F:
			this.EmerAudioRouting_42049Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_15AC:
			this.CVBtnCnvEmerProfGeneralTxPeriodsec2_A43600 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_15B9:
			this.LblEmergencyExitControl_43344 = (global::AcpUI.AcpLabel)target;
			this.LblEmergencyExitControl_43344.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_15DD:
			this.CpyBtnCnvEmerProfGeneralImpoliteRetries_A8242 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_15EA:
			this.CnvEmerProfMDCEmergencyPTTIDSidetone_A7946Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_15F7:
			this.CpyBtnCnvPerEMGFindMeTxEnable_42920 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1604:
			this.CVBtnCnvEmerProfGeneralConsoleAckRequired_A40167 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1611:
			this.b = true;
		}

		// Token: 0x06009AB3 RID: 39603 RVA: 0x0090FBB8 File Offset: 0x0090DDB8
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 3:
				break;
			case 4:
			{
				short num = (short)1949262152;
				short num2 = num;
				num = (short)1270505800;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1892745216;
					if (num != 0)
					{
					}
					num = (short)1890975745;
					if (num != 0)
					{
					}
					num = (short)588382208;
					short num3 = num;
					((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				}
				}
				break;
			}
			case 5:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 6:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 7:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			default:
				return;
			}
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x04004BE4 RID: 19428
		private bool a;

		// Token: 0x04004BE5 RID: 19429
		internal global::AcpUI.AcpParentRecNavToolbar RecNavToolbarPageConventionalEmergencyProfiles;

		// Token: 0x04004BE6 RID: 19430
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x04004BE7 RID: 19431
		internal global::System.Windows.Documents.Hyperlink HLinkGeneral;

		// Token: 0x04004BE8 RID: 19432
		internal global::System.Windows.Documents.Hyperlink HLinkMDC;

		// Token: 0x04004BE9 RID: 19433
		internal global::System.Windows.Documents.Hyperlink HLinkEmergencyToneList;

		// Token: 0x04004BEA RID: 19434
		internal global::System.Windows.Documents.Hyperlink HLinkEmergencyCompatibilityOptionsConventional;

		// Token: 0x04004BEB RID: 19435
		internal global::System.Windows.Documents.Hyperlink HLinkLabtool;

		// Token: 0x04004BEC RID: 19436
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x04004BED RID: 19437
		internal global::AcpUI.AcpExpander ExpanderConventionalEmergencyProfilesGeneral;

		// Token: 0x04004BEE RID: 19438
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalEmergencyProfilesGeneralPseudo0;

		// Token: 0x04004BEF RID: 19439
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvEmerProfGeneralkeyofConventionalEmergencyProfiles_A19418;

		// Token: 0x04004BF0 RID: 19440
		internal global::AcpUI.AcpLabel LblCnvEmerProfGeneralkeyofConventionalEmergencyProfiles_A19418;

		// Token: 0x04004BF1 RID: 19441
		internal global::AcpUI.AcpTextBox CnvEmerProfGeneralkeyofConventionalEmergencyProfiles_A19418;

		// Token: 0x04004BF2 RID: 19442
		internal global::AcpUI.AcpCopyButton CpyBtnCnvEmerProfGeneralkeyofConventionalEmergencyProfiles_A19418;

		// Token: 0x04004BF3 RID: 19443
		internal global::AcpUI.AcpLabel CnvEmerProfGeneralkeyofConventionalEmergencyProfiles_A19418Comp;

		// Token: 0x04004BF4 RID: 19444
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvEmerProfGeneralEmergencyType_A7960;

		// Token: 0x04004BF5 RID: 19445
		internal global::AcpUI.AcpLabel LblCnvEmerProfGeneralEmergencyType_A7960;

		// Token: 0x04004BF6 RID: 19446
		internal global::AcpUI.AcpComboBox CnvEmerProfGeneralEmergencyType_A7960;

		// Token: 0x04004BF7 RID: 19447
		internal global::AcpUI.AcpRtdButton RTDBtnCnvEmerProfGeneralEmergencyType_A7960;

		// Token: 0x04004BF8 RID: 19448
		internal global::AcpUI.AcpCopyButton CpyBtnCnvEmerProfGeneralEmergencyType_A7960;

		// Token: 0x04004BF9 RID: 19449
		internal global::AcpUI.AcpLabel CnvEmerProfGeneralEmergencyType_A7960Comp;

		// Token: 0x04004BFA RID: 19450
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvEmerProfGeneralConsoleAckRequired_A40167;

		// Token: 0x04004BFB RID: 19451
		internal global::AcpUI.AcpLabel LblCnvEmerProfGeneralConsoleAckRequired_A40167;

		// Token: 0x04004BFC RID: 19452
		internal global::AcpUI.AcpCheckBox CnvEmerProfGeneralConsoleAckRequired_A40167;

		// Token: 0x04004BFD RID: 19453
		internal global::AcpUI.AcpRtdButton RTDBtnCnvEmerProfGeneralConsoleAckRequired_A40167;

		// Token: 0x04004BFE RID: 19454
		internal global::AcpUI.AcpCopyButton CpyBtnCnvEmerProfGeneralConsoleAckRequired_A40167;

		// Token: 0x04004BFF RID: 19455
		internal global::AcpUI.AcpCheckBox CnvEmerProfGeneralConsoleAckRequired_A40167Comp;

		// Token: 0x04004C00 RID: 19456
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvEmerProfGeneralAcknowledgeAlertTone_A7394;

		// Token: 0x04004C01 RID: 19457
		internal global::AcpUI.AcpLabel LblCnvEmerProfGeneralAcknowledgeAlertTone_A7394;

		// Token: 0x04004C02 RID: 19458
		internal global::AcpUI.AcpCheckBox CnvEmerProfGeneralAcknowledgeAlertTone_A7394;

		// Token: 0x04004C03 RID: 19459
		internal global::AcpUI.AcpRtdButton RTDBtnCnvEmerProfGeneralAcknowledgeAlertTone_A7394;

		// Token: 0x04004C04 RID: 19460
		internal global::AcpUI.AcpCopyButton CpyBtnCnvEmerProfGeneralAcknowledgeAlertTone_A7394;

		// Token: 0x04004C05 RID: 19461
		internal global::AcpUI.AcpCheckBox CnvEmerProfGeneralAcknowledgeAlertTone_A7394Comp;

		// Token: 0x04004C06 RID: 19462
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvEmerProfGeneralPoliteRetries_A8712;

		// Token: 0x04004C07 RID: 19463
		internal global::AcpUI.AcpLabel LblCnvEmerProfGeneralPoliteRetries_A8712;

		// Token: 0x04004C08 RID: 19464
		internal global::AcpUI.AcpTextBoxSpinner CnvEmerProfGeneralPoliteRetries_A8712;

		// Token: 0x04004C09 RID: 19465
		internal global::AcpUI.AcpRtdButton RTDBtnCnvEmerProfGeneralPoliteRetries_A8712;

		// Token: 0x04004C0A RID: 19466
		internal global::AcpUI.AcpCopyButton CpyBtnCnvEmerProfGeneralPoliteRetries_A8712;

		// Token: 0x04004C0B RID: 19467
		internal global::AcpUI.AcpLabel CnvEmerProfGeneralPoliteRetries_A8712Comp;

		// Token: 0x04004C0C RID: 19468
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvEmerProfGeneralImpoliteRetries_A8242;

		// Token: 0x04004C0D RID: 19469
		internal global::AcpUI.AcpLabel LblCnvEmerProfGeneralImpoliteRetries_A8242;

		// Token: 0x04004C0E RID: 19470
		internal global::AcpUI.AcpTextBoxSpinner CnvEmerProfGeneralImpoliteRetries_A8242;

		// Token: 0x04004C0F RID: 19471
		internal global::AcpUI.AcpRtdButton RTDBtnCnvEmerProfGeneralImpoliteRetries_A8242;

		// Token: 0x04004C10 RID: 19472
		internal global::AcpUI.AcpCopyButton CpyBtnCnvEmerProfGeneralImpoliteRetries_A8242;

		// Token: 0x04004C11 RID: 19473
		internal global::AcpUI.AcpLabel CnvEmerProfGeneralImpoliteRetries_A8242Comp;

		// Token: 0x04004C12 RID: 19474
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerManDownEnable_42038;

		// Token: 0x04004C13 RID: 19475
		internal global::AcpUI.AcpLabel LblCnvPerManDownEnable_42038;

		// Token: 0x04004C14 RID: 19476
		internal global::AcpUI.AcpCheckBox CnvPerManDownEnable_42038;

		// Token: 0x04004C15 RID: 19477
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerManDownEnable_42038;

		// Token: 0x04004C16 RID: 19478
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerManDownEnable_42038;

		// Token: 0x04004C17 RID: 19479
		internal global::AcpUI.AcpCheckBox CnvPerManDownEnable_42038Comp;

		// Token: 0x04004C18 RID: 19480
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnEmergencyExitOnChannelChange_43590;

		// Token: 0x04004C19 RID: 19481
		internal global::AcpUI.AcpLabel LblEmergencyExitOnChannelChange_43590;

		// Token: 0x04004C1A RID: 19482
		internal global::AcpUI.AcpCheckBox EmergencyExitOnChannelChange_43590;

		// Token: 0x04004C1B RID: 19483
		internal global::AcpUI.AcpRtdButton RTDBtnEmergencyExitOnChannelChange_43590;

		// Token: 0x04004C1C RID: 19484
		internal global::AcpUI.AcpCopyButton CpyBtnEmergencyExitOnChannelChange_43590;

		// Token: 0x04004C1D RID: 19485
		internal global::AcpUI.AcpCheckBox EmergencyExitOnChannelChange_43590Comp;

		// Token: 0x04004C1E RID: 19486
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvEmerProfGeneralRemoteActivationEmergency;

		// Token: 0x04004C1F RID: 19487
		internal global::AcpUI.AcpLabel LblCnvEmerProfGeneralRemoteActivationEmergency;

		// Token: 0x04004C20 RID: 19488
		internal global::AcpUI.AcpComboBox CnvEmerProfGeneralRemoteActivationEmergency;

		// Token: 0x04004C21 RID: 19489
		internal global::AcpUI.AcpRtdButton RTDBtnCnvEmerProfGeneralRemoteActivationEmergency;

		// Token: 0x04004C22 RID: 19490
		internal global::AcpUI.AcpCopyButton CpyBtnCnvEmerProfGeneralRemoteActivationEmergency;

		// Token: 0x04004C23 RID: 19491
		internal global::AcpUI.AcpLabel CnvEmerProfGeneralRemoteActivationEmergencyComp;

		// Token: 0x04004C24 RID: 19492
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalEmergencyProfilesGeneralAutoTransmit;

		// Token: 0x04004C25 RID: 19493
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnConEmerProEmergencyAutoTransmitMode_A22532;

		// Token: 0x04004C26 RID: 19494
		internal global::AcpUI.AcpLabel LblConEmerProEmergencyAutoTransmitMode_A22532;

		// Token: 0x04004C27 RID: 19495
		internal global::AcpUI.AcpComboBox ConEmerProEmergencyAutoTransmitMode_A22532;

		// Token: 0x04004C28 RID: 19496
		internal global::AcpUI.AcpRtdButton RTDBtnConEmerProEmergencyAutoTransmitMode_A22532;

		// Token: 0x04004C29 RID: 19497
		internal global::AcpUI.AcpCopyButton CpyBtnConEmerProEmergencyAutoTransmitMode_A22532;

		// Token: 0x04004C2A RID: 19498
		internal global::AcpUI.AcpLabel ConEmerProEmergencyAutoTransmitMode_A22532Comp;

		// Token: 0x04004C2B RID: 19499
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvEmerProfGeneralTxPeriodsec2_A43600;

		// Token: 0x04004C2C RID: 19500
		internal global::AcpUI.AcpLabel LblCnvEmerProfGeneralTxPeriodsec2_A43600;

		// Token: 0x04004C2D RID: 19501
		internal global::AcpUI.AcpTextBoxSpinner CnvEmerProfGeneralTxPeriodsec2_A43600;

		// Token: 0x04004C2E RID: 19502
		internal global::AcpUI.AcpRtdButton RTDBtnCnvEmerProfGeneralTxPeriodsec2_A43600;

		// Token: 0x04004C2F RID: 19503
		internal global::AcpUI.AcpCopyButton CpyBtnCnvEmerProfGeneralTxPeriodsec2_A43600;

		// Token: 0x04004C30 RID: 19504
		internal global::AcpUI.AcpLabel CnvEmerProfGeneralTxPeriodsec2_A43600Comp;

		// Token: 0x04004C31 RID: 19505
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvEmerProfGeneralTxPeriodsec1_A8212;

		// Token: 0x04004C32 RID: 19506
		internal global::AcpUI.AcpLabel LblCnvEmerProfGeneralTxPeriodsec1_A8212;

		// Token: 0x04004C33 RID: 19507
		internal global::AcpUI.AcpTextBoxSpinner CnvEmerProfGeneralTxPeriodsec1_A8212;

		// Token: 0x04004C34 RID: 19508
		internal global::AcpUI.AcpRtdButton RTDBtnCnvEmerProfGeneralTxPeriodsec1_A8212;

		// Token: 0x04004C35 RID: 19509
		internal global::AcpUI.AcpCopyButton CpyBtnCnvEmerProfGeneralTxPeriodsec1_A8212;

		// Token: 0x04004C36 RID: 19510
		internal global::AcpUI.AcpLabel CnvEmerProfGeneralTxPeriodsec1_A8212Comp;

		// Token: 0x04004C37 RID: 19511
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvEmerProfGeneralTxPeriodsec2_A9131;

		// Token: 0x04004C38 RID: 19512
		internal global::AcpUI.AcpLabel LblCnvEmerProfGeneralTxPeriodsec2_A9131;

		// Token: 0x04004C39 RID: 19513
		internal global::AcpUI.AcpTextBoxSpinner CnvEmerProfGeneralTxPeriodsec2_A9131;

		// Token: 0x04004C3A RID: 19514
		internal global::AcpUI.AcpRtdButton RTDBtnCnvEmerProfGeneralTxPeriodsec2_A9131;

		// Token: 0x04004C3B RID: 19515
		internal global::AcpUI.AcpCopyButton CpyBtnCnvEmerProfGeneralTxPeriodsec2_A9131;

		// Token: 0x04004C3C RID: 19516
		internal global::AcpUI.AcpLabel CnvEmerProfGeneralTxPeriodsec2_A9131Comp;

		// Token: 0x04004C3D RID: 19517
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvEmerProfEmergencyHotAuxMic_A42296;

		// Token: 0x04004C3E RID: 19518
		internal global::AcpUI.AcpLabel LblCnvEmerProfEmergencyHotAuxMic_A42296;

		// Token: 0x04004C3F RID: 19519
		internal global::AcpUI.AcpComboBox CnvEmerProfEmergencyHotAuxMic_A42296;

		// Token: 0x04004C40 RID: 19520
		internal global::AcpUI.AcpRtdButton RTDBtnCnvEmerProfEmergencyHotAuxMic_A42296;

		// Token: 0x04004C41 RID: 19521
		internal global::AcpUI.AcpCopyButton CpyBtnCnvEmerProfEmergencyHotAuxMic_A42296;

		// Token: 0x04004C42 RID: 19522
		internal global::AcpUI.AcpLabel CnvEmerProfEmergencyHotAuxMic_A42296Comp;

		// Token: 0x04004C43 RID: 19523
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalEmergencyProfilesGeneralTxMultiplier;

		// Token: 0x04004C44 RID: 19524
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvEmerProfGeneralEnable3_A8171;

		// Token: 0x04004C45 RID: 19525
		internal global::AcpUI.AcpLabel LblCnvEmerProfGeneralEnable3_A8171;

		// Token: 0x04004C46 RID: 19526
		internal global::AcpUI.AcpCheckBox CnvEmerProfGeneralEnable3_A8171;

		// Token: 0x04004C47 RID: 19527
		internal global::AcpUI.AcpRtdButton RTDBtnCnvEmerProfGeneralEnable3_A8171;

		// Token: 0x04004C48 RID: 19528
		internal global::AcpUI.AcpCopyButton CpyBtnCnvEmerProfGeneralEnable3_A8171;

		// Token: 0x04004C49 RID: 19529
		internal global::AcpUI.AcpCheckBox CnvEmerProfGeneralEnable3_A8171Comp;

		// Token: 0x04004C4A RID: 19530
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvEmerProfGeneralFactor_A9548;

		// Token: 0x04004C4B RID: 19531
		internal global::AcpUI.AcpLabel LblCnvEmerProfGeneralFactor_A9548;

		// Token: 0x04004C4C RID: 19532
		internal global::AcpUI.AcpComboBox CnvEmerProfGeneralFactor_A9548;

		// Token: 0x04004C4D RID: 19533
		internal global::AcpUI.AcpRtdButton RTDBtnCnvEmerProfGeneralFactor_A9548;

		// Token: 0x04004C4E RID: 19534
		internal global::AcpUI.AcpCopyButton CpyBtnCnvEmerProfGeneralFactor_A9548;

		// Token: 0x04004C4F RID: 19535
		internal global::AcpUI.AcpLabel CnvEmerProfGeneralFactor_A9548Comp;

		// Token: 0x04004C50 RID: 19536
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalEmergencyProfilesGeneralEmergencyFindMe;

		// Token: 0x04004C51 RID: 19537
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerEMGFindMeTxEnable_42920;

		// Token: 0x04004C52 RID: 19538
		internal global::AcpUI.AcpLabel LblCnvPerEMGFindMeTxEnable_42920;

		// Token: 0x04004C53 RID: 19539
		internal global::AcpUI.AcpCheckBox CnvPerEMGFindMeTxEnable_42920;

		// Token: 0x04004C54 RID: 19540
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerEMGFindMeTxEnable_42920;

		// Token: 0x04004C55 RID: 19541
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerEMGFindMeTxEnable_42920;

		// Token: 0x04004C56 RID: 19542
		internal global::AcpUI.AcpCheckBox CnvPerEMGFindMeTxEnable_42920Comp;

		// Token: 0x04004C57 RID: 19543
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvPerEMGFindMeRxEnable_42922;

		// Token: 0x04004C58 RID: 19544
		internal global::AcpUI.AcpLabel LblCnvPerEMGFindMeRxEnable_42922;

		// Token: 0x04004C59 RID: 19545
		internal global::AcpUI.AcpCheckBox CnvPerEMGFindMeRxEnable_42922;

		// Token: 0x04004C5A RID: 19546
		internal global::AcpUI.AcpRtdButton RTDBtnCnvPerEMGFindMeRxEnable_42922;

		// Token: 0x04004C5B RID: 19547
		internal global::AcpUI.AcpCopyButton CpyBtnCnvPerEMGFindMeRxEnable_42922;

		// Token: 0x04004C5C RID: 19548
		internal global::AcpUI.AcpCheckBox CnvPerEMGFindMeRxEnable_42922Comp;

		// Token: 0x04004C5D RID: 19549
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalEmergencyProfilesGeneralPseudo3;

		// Token: 0x04004C5E RID: 19550
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvEmerProfImpactDetectionEn_A43391;

		// Token: 0x04004C5F RID: 19551
		internal global::AcpUI.AcpLabel LblCnvEmerProfImpactDetectionEn_A43391;

		// Token: 0x04004C60 RID: 19552
		internal global::AcpUI.AcpCheckBox CnvEmerProfImpactDetectionEn_A43391;

		// Token: 0x04004C61 RID: 19553
		internal global::AcpUI.AcpRtdButton RTDBtnCnvEmerProfImpactDetectionEn_A43391;

		// Token: 0x04004C62 RID: 19554
		internal global::AcpUI.AcpCopyButton CpyBtnCnvEmerProfImpactDetectionEn_A43391;

		// Token: 0x04004C63 RID: 19555
		internal global::AcpUI.AcpCheckBox CnvEmerProfImpactDetectionEn_A43391Comp;

		// Token: 0x04004C64 RID: 19556
		internal global::AcpUI.AcpExpander ExpanderConventionalEmergencyProfilesMDC;

		// Token: 0x04004C65 RID: 19557
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalEmergencyProfilesMDCPseudo0;

		// Token: 0x04004C66 RID: 19558
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvEmerProfMDCEmergencyPTTIDSidetone_A7946;

		// Token: 0x04004C67 RID: 19559
		internal global::AcpUI.AcpLabel LblCnvEmerProfMDCEmergencyPTTIDSidetone_A7946;

		// Token: 0x04004C68 RID: 19560
		internal global::AcpUI.AcpCheckBox CnvEmerProfMDCEmergencyPTTIDSidetone_A7946;

		// Token: 0x04004C69 RID: 19561
		internal global::AcpUI.AcpRtdButton RTDBtnCnvEmerProfMDCEmergencyPTTIDSidetone_A7946;

		// Token: 0x04004C6A RID: 19562
		internal global::AcpUI.AcpCopyButton CpyBtnCnvEmerProfMDCEmergencyPTTIDSidetone_A7946;

		// Token: 0x04004C6B RID: 19563
		internal global::AcpUI.AcpCheckBox CnvEmerProfMDCEmergencyPTTIDSidetone_A7946Comp;

		// Token: 0x04004C6C RID: 19564
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalEmergencyProfilesMDCEmergencyRemoteMonitor;

		// Token: 0x04004C6D RID: 19565
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvEmerProfMDCTxBaseTimeSec_A9514;

		// Token: 0x04004C6E RID: 19566
		internal global::AcpUI.AcpLabel LblCnvEmerProfMDCTxBaseTimeSec_A9514;

		// Token: 0x04004C6F RID: 19567
		internal global::AcpUI.AcpTextBoxSpinner CnvEmerProfMDCTxBaseTimeSec_A9514;

		// Token: 0x04004C70 RID: 19568
		internal global::AcpUI.AcpRtdButton RTDBtnCnvEmerProfMDCTxBaseTimeSec_A9514;

		// Token: 0x04004C71 RID: 19569
		internal global::AcpUI.AcpCopyButton CpyBtnCnvEmerProfMDCTxBaseTimeSec_A9514;

		// Token: 0x04004C72 RID: 19570
		internal global::AcpUI.AcpLabel CnvEmerProfMDCTxBaseTimeSec_A9514Comp;

		// Token: 0x04004C73 RID: 19571
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvEmerProfMDCRxBaseTimesec_A8999;

		// Token: 0x04004C74 RID: 19572
		internal global::AcpUI.AcpLabel LblCnvEmerProfMDCRxBaseTimesec_A8999;

		// Token: 0x04004C75 RID: 19573
		internal global::AcpUI.AcpTextBoxSpinner CnvEmerProfMDCRxBaseTimesec_A8999;

		// Token: 0x04004C76 RID: 19574
		internal global::AcpUI.AcpRtdButton RTDBtnCnvEmerProfMDCRxBaseTimesec_A8999;

		// Token: 0x04004C77 RID: 19575
		internal global::AcpUI.AcpCopyButton CpyBtnCnvEmerProfMDCRxBaseTimesec_A8999;

		// Token: 0x04004C78 RID: 19576
		internal global::AcpUI.AcpLabel CnvEmerProfMDCRxBaseTimesec_A8999Comp;

		// Token: 0x04004C79 RID: 19577
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvEmerProfMDCEnable2_A7924;

		// Token: 0x04004C7A RID: 19578
		internal global::AcpUI.AcpLabel LblCnvEmerProfMDCEnable2_A7924;

		// Token: 0x04004C7B RID: 19579
		internal global::AcpUI.AcpCheckBox CnvEmerProfMDCEnable2_A7924;

		// Token: 0x04004C7C RID: 19580
		internal global::AcpUI.AcpRtdButton RTDBtnCnvEmerProfMDCEnable2_A7924;

		// Token: 0x04004C7D RID: 19581
		internal global::AcpUI.AcpCopyButton CpyBtnCnvEmerProfMDCEnable2_A7924;

		// Token: 0x04004C7E RID: 19582
		internal global::AcpUI.AcpCheckBox CnvEmerProfMDCEnable2_A7924Comp;

		// Token: 0x04004C7F RID: 19583
		internal global::AcpUI.AcpExpander ExpanderConventionalEmergencyProfilesEmergencyToneList;

		// Token: 0x04004C80 RID: 19584
		internal global::AcpUI.AcpChildRecNavToolbar RecNavToolbarExpanderConventionalEmergencyProfilesEmergencyToneTable;

		// Token: 0x04004C81 RID: 19585
		internal global::System.Windows.Controls.Grid ExpanderConventionalEmergencyProfilesEmergencyToneListGrid;

		// Token: 0x04004C82 RID: 19586
		internal global::System.Windows.Controls.Grid ExpanderConventionalEmergencyProfilesEmergencyToneTableGrid;

		// Token: 0x04004C83 RID: 19587
		internal global::AcpUI.AcpGroupBox ExpanderConventionalEmergencyProfilesEmergencyToneTableTableView;

		// Token: 0x04004C84 RID: 19588
		internal global::AcpUI.AcpXamDataPresenter ExpanderConventionalEmergencyProfilesEmergencyToneTable;

		// Token: 0x04004C85 RID: 19589
		internal global::Infragistics.Windows.DataPresenter.UnboundField EmergencyToneTrigger_42045_Col;

		// Token: 0x04004C86 RID: 19590
		internal global::Infragistics.Windows.DataPresenter.UnboundField EmerTone_42046_Col;

		// Token: 0x04004C87 RID: 19591
		internal global::Infragistics.Windows.DataPresenter.UnboundField EmerToneMinimumVolumn_42047_Col;

		// Token: 0x04004C88 RID: 19592
		internal global::Infragistics.Windows.DataPresenter.UnboundField EmerTonePeriodSec_42048_Col;

		// Token: 0x04004C89 RID: 19593
		internal global::Infragistics.Windows.DataPresenter.UnboundField EmerAudioRouting_42049_Col;

		// Token: 0x04004C8A RID: 19594
		internal global::AcpUI.AcpGroupBox ExpanderConventionalEmergencyProfilesEmergencyToneTableSRecView;

		// Token: 0x04004C8B RID: 19595
		internal global::System.Windows.Controls.Grid gridExpanderConventionalEmergencyProfilesEmergencyToneTableSRecView;

		// Token: 0x04004C8C RID: 19596
		internal global::AcpUI.AcpComboBox EmergencyToneTrigger_42045;

		// Token: 0x04004C8D RID: 19597
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnEmergencyToneTrigger_42045;

		// Token: 0x04004C8E RID: 19598
		internal global::AcpUI.AcpLabel LblEmergencyToneTrigger_42045;

		// Token: 0x04004C8F RID: 19599
		internal global::AcpUI.AcpRtdButton RTDBtnEmergencyToneTrigger_42045;

		// Token: 0x04004C90 RID: 19600
		internal global::AcpUI.AcpCopyButton CpyBtnEmergencyToneTrigger_42045;

		// Token: 0x04004C91 RID: 19601
		internal global::AcpUI.AcpLabel EmergencyToneTrigger_42045Comp;

		// Token: 0x04004C92 RID: 19602
		internal global::AcpUI.AcpComboBox EmerTone_42046;

		// Token: 0x04004C93 RID: 19603
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnEmerTone_42046;

		// Token: 0x04004C94 RID: 19604
		internal global::AcpUI.AcpLabel LblEmerTone_42046;

		// Token: 0x04004C95 RID: 19605
		internal global::AcpUI.AcpRtdButton RTDBtnEmerTone_42046;

		// Token: 0x04004C96 RID: 19606
		internal global::AcpUI.AcpCopyButton CpyBtnEmerTone_42046;

		// Token: 0x04004C97 RID: 19607
		internal global::AcpUI.AcpLabel EmerTone_42046Comp;

		// Token: 0x04004C98 RID: 19608
		internal global::AcpUI.AcpTextBoxSpinner EmerToneMinimumVolumn_42047;

		// Token: 0x04004C99 RID: 19609
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnEmerToneMinimumVolumn_42047;

		// Token: 0x04004C9A RID: 19610
		internal global::AcpUI.AcpLabel LblEmerToneMinimumVolumn_42047;

		// Token: 0x04004C9B RID: 19611
		internal global::AcpUI.AcpRtdButton RTDBtnEmerToneMinimumVolumn_42047;

		// Token: 0x04004C9C RID: 19612
		internal global::AcpUI.AcpCopyButton CpyBtnEmerToneMinimumVolumn_42047;

		// Token: 0x04004C9D RID: 19613
		internal global::AcpUI.AcpLabel EmerToneMinimumVolumn_42047Comp;

		// Token: 0x04004C9E RID: 19614
		internal global::AcpUI.AcpTextBoxSpinner EmerTonePeriodSec_42048;

		// Token: 0x04004C9F RID: 19615
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnEmerTonePeriodSec_42048;

		// Token: 0x04004CA0 RID: 19616
		internal global::AcpUI.AcpLabel LblEmerTonePeriodSec_42048;

		// Token: 0x04004CA1 RID: 19617
		internal global::AcpUI.AcpRtdButton RTDBtnEmerTonePeriodSec_42048;

		// Token: 0x04004CA2 RID: 19618
		internal global::AcpUI.AcpCopyButton CpyBtnEmerTonePeriodSec_42048;

		// Token: 0x04004CA3 RID: 19619
		internal global::AcpUI.AcpLabel EmerTonePeriodSec_42048Comp;

		// Token: 0x04004CA4 RID: 19620
		internal global::AcpUI.AcpComboBox EmerAudioRouting_42049;

		// Token: 0x04004CA5 RID: 19621
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnEmerAudioRouting_42049;

		// Token: 0x04004CA6 RID: 19622
		internal global::AcpUI.AcpLabel LblEmerAudioRouting_42049;

		// Token: 0x04004CA7 RID: 19623
		internal global::AcpUI.AcpRtdButton RTDBtnEmerAudioRouting_42049;

		// Token: 0x04004CA8 RID: 19624
		internal global::AcpUI.AcpCopyButton CpyBtnEmerAudioRouting_42049;

		// Token: 0x04004CA9 RID: 19625
		internal global::AcpUI.AcpLabel EmerAudioRouting_42049Comp;

		// Token: 0x04004CAA RID: 19626
		internal global::AcpUI.AcpExpander ExpanderConventionalEmergencyProfilesEmergencyCompatibilityOptionsConventional;

		// Token: 0x04004CAB RID: 19627
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalEmergencyProfilesEmergencyCompatibilityOptionsConventionalPseudo0;

		// Token: 0x04004CAC RID: 19628
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnEmergencyExitControl_43344;

		// Token: 0x04004CAD RID: 19629
		internal global::AcpUI.AcpLabel LblEmergencyExitControl_43344;

		// Token: 0x04004CAE RID: 19630
		internal global::AcpUI.AcpComboBox EmergencyExitControl_43344;

		// Token: 0x04004CAF RID: 19631
		internal global::AcpUI.AcpRtdButton RTDBtnEmergencyExitControl_43344;

		// Token: 0x04004CB0 RID: 19632
		internal global::AcpUI.AcpCopyButton CpyBtnEmergencyExitControl_43344;

		// Token: 0x04004CB1 RID: 19633
		internal global::AcpUI.AcpLabel EmergencyExitControl_43344Comp;

		// Token: 0x04004CB2 RID: 19634
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnEmergencyHotMicReStart_43343;

		// Token: 0x04004CB3 RID: 19635
		internal global::AcpUI.AcpLabel LblEmergencyHotMicReStart_43343;

		// Token: 0x04004CB4 RID: 19636
		internal global::AcpUI.AcpCheckBox EmergencyHotMicReStart_43343;

		// Token: 0x04004CB5 RID: 19637
		internal global::AcpUI.AcpRtdButton RTDBtnEmergencyHotMicReStart_43343;

		// Token: 0x04004CB6 RID: 19638
		internal global::AcpUI.AcpCopyButton CpyBtnEmergencyHotMicReStart_43343;

		// Token: 0x04004CB7 RID: 19639
		internal global::AcpUI.AcpCheckBox EmergencyHotMicReStart_43343Comp;

		// Token: 0x04004CB8 RID: 19640
		internal global::AcpUI.AcpExpander ExpanderConventionalEmergencyProfilesLabtool;

		// Token: 0x04004CB9 RID: 19641
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderConventionalEmergencyProfilesLabtoolPseudo0;

		// Token: 0x04004CBA RID: 19642
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCnvEmergencyToneSelection_42053;

		// Token: 0x04004CBB RID: 19643
		internal global::AcpUI.AcpLabel LblCnvEmergencyToneSelection_42053;

		// Token: 0x04004CBC RID: 19644
		internal global::AcpUI.AcpComboBox CnvEmergencyToneSelection_42053;

		// Token: 0x04004CBD RID: 19645
		internal global::AcpUI.AcpRtdButton RTDBtnCnvEmergencyToneSelection_42053;

		// Token: 0x04004CBE RID: 19646
		internal global::AcpUI.AcpCopyButton CpyBtnCnvEmergencyToneSelection_42053;

		// Token: 0x04004CBF RID: 19647
		internal global::AcpUI.AcpLabel CnvEmergencyToneSelection_42053Comp;

		// Token: 0x04004CC0 RID: 19648
		private bool b;
	}
}
