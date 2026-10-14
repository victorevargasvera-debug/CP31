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
using AcpUITTS;
using AllFeatures;
using Infragistics.Windows.DataPresenter;

namespace Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment
{
	// Token: 0x0200004C RID: 76
	public class PageZoneChannelAssignment : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x060003C0 RID: 960 RVA: 0x00042998 File Offset: 0x00040B98
		public PageZoneChannelAssignment()
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

		// Token: 0x060003C1 RID: 961 RVA: 0x000429D0 File Offset: 0x00040BD0
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1238892544;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)2124939270;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::AcpUI.AcpExpander acpExpander;
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)392101894;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1696268289;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_2C5;
								case 2:
									if (acpExpander != null)
									{
										num = (short)924975109;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 3:
									if (!enumerator.MoveNext())
									{
										num = (short)2078408704;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
									num = (short)1946550274;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									base.Expanders.Add(acpExpander);
									num = (short)399245316;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_208;
									}
									continue;
								}
								IL_20A:
								num = (short)1632632835;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_208:
								goto IL_20A;
							}
							IL_2C5:
							goto IL_134;
						}
						finally
						{
							num = (short)1971258602;
							short num3 = num;
							num = (short)445842666;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_354:
								num = (short)591593473;
								num2 = (int)((global::System.IntPtr)num);
								break;
							default:
								num = (short)1538719744;
								if (num != 0)
								{
								}
								switch (0)
								{
								case 0:
									goto IL_333;
								}
								break;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_320:
								switch (num2)
								{
								case 0:
									goto IL_388;
								case 1:
									disposable.Dispose();
									num = (short)1624375296;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_351;
								}
								goto IL_333;
							}
							IL_351:
							if (disposable != null)
							{
								goto IL_354;
							}
							IL_388:
							goto EndFinally_7;
							IL_333:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)907608066;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_320;
							EndFinally_7:;
						}
						goto IL_38B;
						IL_134:
						base.OnLoaded(sender, e);
						this.a = true;
						num = (short)137691141;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_AB;
					case 2:
					{
						num = (short)1704460288;
						short num4 = num;
						object obj;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderZoneChannelAssignmentChannelAssignmentList.MyDataPresenter = this.ExpanderZoneChannelAssignmentChannelAssignmentList;
						num = (short)1517223937;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						this.RecNavToolbarPageZoneChannelAssignment.ChildToolbars.Add(this.RecNavToolbarExpanderZoneChannelAssignmentChannelAssignmentList);
						object obj = null;
						obj = this.RecNavToolbarExpanderZoneChannelAssignmentChannelAssignmentList.MyRecordsetDataSource;
						num = (short)2122711044;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						object obj;
						if (obj != null)
						{
							num = (short)511508482;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AB;
					}
					case 5:
						goto IL_15C;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_61;
						}
						continue;
					}
					IL_61:
					num = (short)913965057;
					if (num != 0)
					{
					}
					if (!this.a)
					{
						num = (short)886112259;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_AB:
					acpExpander = null;
					enumerator = this.MyStackPanel.Children.GetEnumerator();
					num = (short)2037645312;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_15C:
				IL_38B:
				this.MyStackPanel.Children[0].Focus();
				return;
			}
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00042D9C File Offset: 0x00040F9C
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)42734932;
			short num2 = num;
			num = (short)1217140052;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_B3:
				num = (short)1845100544;
				short num3 = num;
				num = (short)1607663617;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			default:
				num = (short)1865744384;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_67;
				}
				break;
			}
			for (;;)
			{
				IL_55:
				switch (num4)
				{
				case 0:
					goto IL_11D;
				case 1:
					base.OnUnloaded(sender, e);
					this.a = false;
					num = (short)792068096;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_AB;
				}
				goto IL_67;
			}
			IL_AB:
			if (this.a)
			{
				goto IL_B3;
			}
			IL_11D:
			num = (short)276496385;
			if (num != 0)
			{
			}
			return;
			IL_67:
			this.RecNavToolbarPageZoneChannelAssignment.DataContext = null;
			this.RecNavToolbarExpanderZoneChannelAssignmentChannelAssignmentList.DataContext = null;
			this.RecNavToolbarPageZoneChannelAssignment.MyDataPresenter = null;
			this.RecNavToolbarExpanderZoneChannelAssignmentChannelAssignmentList.MyDataPresenter = null;
			num = (short)1578893314;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_55;
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00042EF0 File Offset: 0x000410F0
		public override void SetDataContext()
		{
			short num = (short)550764544;
			int num2 = (int)((global::System.IntPtr)num);
			object feature;
			for (;;)
			{
				num = (short)540540929;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_72;
					}
					continue;
				case 1:
					goto IL_A5;
				case 2:
					goto IL_A5;
				case 3:
					goto IL_1BE;
				case 4:
					feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2051);
					num = (short)565510151;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)1943339012;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageZoneChannelAssignment).MySecondaryRecordsetDataSource = null;
					num = (short)2002190342;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_1C3;
				case 7:
					if (feature != null)
					{
						num = (short)2044788739;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C3;
				case 8:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2051);
					num = (short)357957634;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_72:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)1455816712;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_14E;
				IL_A5:
				this.RecNavToolbarPageZoneChannelAssignment.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				num = (short)1645084677;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_14E:
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2051);
				num = (short)275054593;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1C3:
				num = (short)1311669577;
				short num3 = num;
				num = (short)1775992137;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_14E;
				default:
					goto IL_1F9;
				}
			}
			IL_1BE:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageZoneChannelAssignment).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
			return;
			IL_1F9:
			num = (short)804126720;
			if (num != 0)
			{
			}
			num = (short)808714240;
			short num4 = num;
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00043138 File Offset: 0x00041338
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 19;
			short num = (short)832503808;
			switch (num)
			{
			default:
			{
				num = (short)917514;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("蛓돕믗铙뷛꣝듟跡诣諥諧诩黫뻭釯闱釳공韷铹駻뷽棿持樃栅洇昉䴋納挏笑猓砕甗缙爛樝", a_))
						{
							num = (short)658636821;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_313;
					case 1:
						goto IL_2B9;
					case 2:
					{
						object myRecordsetDataSource;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner = (global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner)collectionView.CurrentItem;
						num = (short)370737170;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource2;
						base.NavigationService.Navigate(new global::System.Uri(myRecordsetDataSource2.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
						num = (short)1537605649;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						object myRecordsetDataSource;
						if (myRecordsetDataSource != null)
						{
							num = (short)120258562;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 5:
					{
						num = (short)37262155;
						short num3 = num;
						num = (short)1864667979;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)2092892160;
							if (num != 0)
							{
							}
							num = (short)1131610113;
							if (num != 0)
							{
							}
							global::System.Windows.Data.CollectionView collectionView;
							collectionView.MoveCurrentToLast();
							break;
						}
						}
						num = (short)1497169936;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						num = (short)1989607431;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1911488526;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)600768513;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)1401356288;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						global::System.Windows.Data.CollectionView collectionView;
						if (collectionView.Count > 0)
						{
							num = (short)170197012;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_368;
					}
					case 10:
						switch (0)
						{
						case 0:
							goto IL_A8;
						}
						continue;
					case 11:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("蛓돕믗铙뷛꣝듟跡诣諥諧诩黫꯭裯英闳飵鳷鿹軻ꓽ濿氁愃䔅怇欉戋怍甏縑唓攕欗猙笛瀝䴟䜡䨣別欧䈩䴫䀭帯圱堳眵䬷䤹唻夽⸿⽁⅃⡅㱇ى╋㵍⑏", a_))
						{
							num = (short)1884356614;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 12:
						goto IL_158;
					case 13:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource2;
						if (myRecordsetDataSource2 != null)
						{
							num = (short)1985544195;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_313;
					}
					case 14:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource = this.RecNavToolbarExpanderZoneChannelAssignmentChannelAssignmentList.MyRecordsetDataSource;
						num = (short)1282408452;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
					{
						global::System.Windows.Data.CollectionView collectionView;
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
						collectionView.MoveCurrentTo(channelAssignmentListInner);
						num = (short)66453516;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						goto IL_28F;
					case 17:
						goto IL_313;
					case 18:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
						if (channelAssignmentListInner != null)
						{
							num = (short)785383439;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1065943049;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						goto IL_1B3;
					case 20:
						num = (short)1863909398;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource2 = this.RecNavToolbarPageZoneChannelAssignment.MyRecordsetDataSource;
						num = (short)990969869;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
					{
						global::System.Windows.Data.CollectionView collectionView;
						if (collectionView.IsCurrentAfterLast)
						{
							num = (short)560332805;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						collectionView.MoveCurrentToFirst();
						num = (short)1766195219;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_A8:
					num = (short)239927296;
					short num4 = num;
					if (A_0 is global::AcpUI.AcpRecNavToolbar)
					{
						num = (short)827129864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_313:
					num = (short)1304231947;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_158:
				IL_1B3:
				IL_28F:
				goto IL_368;
				IL_2B9:
				return;
				IL_368:
				((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
				return;
			}
			}
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x000435E8 File Offset: 0x000417E8
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1620784665;
			short num2 = num;
			num = (short)1723938329;
			switch (num2 == num)
			{
			default:
			{
				num = (short)185860096;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1893269505;
			if (num != 0)
			{
			}
			num = (short)1144455168;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00043698 File Offset: 0x00041898
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1398818815;
			short num2 = num;
			num = (short)70797311;
			switch (num2 == num)
			{
			default:
			{
				num = (short)598605824;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)496369665;
			if (num != 0)
			{
			}
			num = (short)1368260608;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00043748 File Offset: 0x00041948
		internal void OnExpanderZoneChannelAssignmentChannelAssignmentListClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)228433933;
			short num2 = num;
			num = (short)474521613;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_B1:
				num = (short)1674706944;
				short num3 = num;
				num = (short)980811777;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			default:
				num = (short)392167424;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_68;
				}
				break;
			}
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner item;
			for (;;)
			{
				IL_56:
				switch (num4)
				{
				case 0:
					goto IL_128;
				case 1:
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderZoneChannelAssignmentChannelAssignmentList.SyncDataSources();
					num = (short)598540288;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_AE;
				}
				goto IL_68;
			}
			IL_AE:
			if (myRecordsetDataSource != null)
			{
				goto IL_B1;
			}
			IL_128:
			num = (short)1795358721;
			if (num != 0)
			{
			}
			this.RecNavToolbarExpanderZoneChannelAssignmentChannelAssignmentList.TableMode = false;
			return;
			IL_68:
			item = (global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderZoneChannelAssignmentChannelAssignmentList.MyRecordsetDataSource;
			num = (short)22413314;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_56;
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x000438B4 File Offset: 0x00041AB4
		public void ChangeRSISiteNumberRange(string mask)
		{
			short num = (short)1927544833;
			if (num != 0)
			{
			}
			num = (short)933298176;
			short num2 = num;
			num = (short)770275596;
			short num3 = num;
			num = (short)344881420;
			switch (num3 == num)
			{
			}
			num = (short)1537015808;
			if (num != 0)
			{
			}
			this.ZoneChannelAssignmentRSISiteNumber_A41833.MaskTypeSpinner = mask;
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00043968 File Offset: 0x00041B68
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 13;
			if (!this.b)
			{
				short num = (short)87490560;
				short num2 = num;
				num = (short)248817411;
				short num3 = num;
				num = (short)1240573699;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1131413504;
					if (num != 0)
					{
					}
					num = (short)13107201;
					if (num != 0)
					{
					}
					this.b = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("量뻑룓郕뷗믙꣛ꯝ鋟蟡韣\udde5诧藩臫黭鿯鳱釳飵賷헹蛻釽滿朁℃㐅㠇椉搋漍縏簑焓稕㴗⠙Ⱋ缝匟儡䴣䄥䘧䜩䤫䀭䐯ᴱ丳夵嘷弹弻嘽ℿⱁ⩃⍅⑇⭉㽋㵍㥏㕑㩓㭕㵗㑙⡛灝ᡟ͡ॣ੥", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00043A48 File Offset: 0x00041C48
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)2081554433;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)900202498;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_32;
					}
					continue;
				case 2:
					goto IL_B51;
				}
				IL_32:
				switch (connectionId)
				{
				case 1:
					goto IL_555;
				case 2:
					goto IL_B56;
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
					goto IL_19BD;
				case 19:
					goto IL_1261;
				case 20:
					goto IL_187A;
				case 21:
					goto IL_72E;
				case 22:
					goto IL_14B9;
				case 23:
					goto IL_677;
				case 24:
					goto IL_A51;
				case 25:
					goto IL_1545;
				case 26:
					goto IL_168F;
				case 27:
					goto IL_10C0;
				case 28:
					goto IL_DC6;
				case 29:
					goto IL_13A7;
				case 30:
					goto IL_EBE;
				case 31:
					goto IL_197F;
				case 32:
					goto IL_1511;
				case 33:
					goto IL_16F4;
				case 34:
					goto IL_1292;
				case 35:
					goto IL_7CB;
				case 36:
					goto IL_E42;
				case 37:
					goto IL_186D;
				case 38:
					goto IL_EE2;
				case 39:
					goto IL_1958;
				case 40:
					goto IL_10FE;
				case 41:
					goto IL_A20;
				case 42:
					goto IL_11BB;
				case 43:
					goto IL_112F;
				case 44:
					goto IL_14F7;
				case 45:
					goto IL_1359;
				case 46:
					goto IL_1082;
				case 47:
					goto IL_12EA;
				case 48:
					goto IL_A75;
				case 49:
					goto IL_EEF;
				case 50:
					goto IL_4ED;
				case 51:
					goto IL_A44;
				case 52:
					goto IL_953;
				case 53:
					goto IL_BE9;
				case 54:
					goto IL_79A;
				case 55:
					goto IL_10CD;
				case 56:
					goto IL_17EC;
				case 57:
					goto IL_593;
				case 58:
					goto IL_721;
				case 59:
					goto IL_7EF;
				case 60:
					goto IL_1579;
				case 61:
					goto IL_1247;
				case 62:
					goto IL_1194;
				case 63:
					goto IL_8F1;
				case 64:
					goto IL_1366;
				case 65:
					goto IL_194B;
				case 66:
					goto IL_586;
				case 67:
					goto IL_10DA;
				case 68:
					goto IL_17F9;
				case 69:
					goto IL_18E9;
				case 70:
					goto IL_18B8;
				case 71:
					goto IL_4BC;
				case 72:
					goto IL_612;
				case 73:
					goto IL_1623;
				case 74:
					goto IL_86B;
				case 75:
					goto IL_5A0;
				case 76:
					goto IL_1380;
				case 77:
					goto IL_A13;
				case 78:
					goto IL_521;
				case 79:
					goto IL_776;
				case 80:
					goto IL_1216;
				case 81:
					goto IL_65D;
				case 82:
					goto IL_650;
				case 83:
					goto IL_F3D;
				case 84:
					goto IL_1075;
				case 85:
					goto IL_1701;
				case 86:
					goto IL_F95;
				case 87:
					goto IL_16B6;
				case 88:
					goto IL_DD3;
				case 89:
					goto IL_CD1;
				case 90:
					goto IL_14EA;
				case 91:
					goto IL_62C;
				case 92:
					goto IL_1156;
				case 93:
					goto IL_198C;
				case 94:
					goto IL_C62;
				case 95:
					goto IL_14DD;
				case 96:
					goto IL_1122;
				case 97:
					goto IL_5EE;
				case 98:
					goto IL_18F6;
				case 99:
					goto IL_14AC;
				case 100:
					goto IL_FF7;
				case 101:
					goto IL_6BF;
				case 102:
					goto IL_147B;
				case 103:
					goto IL_922;
				case 104:
					goto IL_AE4;
				case 105:
					goto IL_BB8;
				case 106:
					goto IL_A82;
				case 107:
					goto IL_155F;
				case 108:
					goto IL_6F0;
				case 109:
					goto IL_E5C;
				case 110:
					goto IL_CDE;
				case 111:
					goto IL_1328;
				case 112:
					goto IL_1725;
				case 113:
					goto IL_99E;
				case 114:
					goto IL_F88;
				case 115:
					goto IL_17DF;
				case 116:
					goto IL_15AA;
				case 117:
					goto IL_E80;
				case 118:
					goto IL_5D4;
				case 119:
					goto IL_5C7;
				case 120:
					goto IL_1837;
				case 121:
					goto IL_159D;
				case 122:
					goto IL_B94;
				case 123:
					goto IL_97A;
				case 124:
					goto IL_9AB;
				case 125:
					goto IL_1004;
				case 126:
					goto IL_9DF;
				case 127:
					goto IL_1538;
				case 128:
					goto IL_17AE;
				case 129:
					goto IL_E1E;
				case 130:
					goto IL_13CB;
				case 131:
					goto IL_B87;
				case 132:
					goto IL_548;
				case 133:
					goto IL_16A9;
				case 134:
					goto IL_13FC;
				case 135:
					goto IL_9D2;
				case 136:
					goto IL_BC5;
				case 137:
					goto IL_69B;
				case 138:
					goto IL_11EF;
				case 139:
					goto IL_1187;
				case 140:
					goto IL_EB1;
				case 141:
					goto IL_1409;
				case 142:
					goto IL_15DB;
				case 143:
					goto IL_F4A;
				case 144:
					goto IL_10A6;
				case 145:
					goto IL_12C3;
				case 146:
					goto IL_18AB;
				case 147:
					goto IL_66A;
				case 148:
					goto IL_B08;
				case 149:
					goto IL_1209;
				case 150:
					goto IL_169C;
				case 151:
					goto IL_F23;
				case 152:
					goto IL_CA0;
				case 153:
					goto IL_E11;
				case 154:
					goto IL_16E7;
				case 155:
					goto IL_9B8;
				case 156:
					goto IL_17D2;
				case 157:
					goto IL_1732;
				case 158:
					goto IL_946;
				case 159:
					goto IL_B7A;
				case 160:
					goto IL_1068;
				case 161:
					goto IL_138D;
				case 162:
					goto IL_A06;
				case 163:
					goto IL_11E2;
				case 164:
					goto IL_4AF;
				case 165:
					goto IL_96D;
				case 166:
					goto IL_191A;
				case 167:
					goto IL_9EC;
				case 168:
					goto IL_11D5;
				case 169:
					goto IL_131B;
				case 170:
					goto IL_514;
				case 171:
					goto IL_117A;
				case 172:
					goto IL_8FE;
				case 173:
					goto IL_85E;
				case 174:
					goto IL_D4D;
				case 175:
					goto IL_1770;
				case 176:
					goto IL_D0F;
				case 177:
					goto IL_C1A;
				case 178:
					goto IL_1504;
				case 179:
					goto IL_C3E;
				case 180:
					goto IL_1972;
				case 181:
					goto IL_AD7;
				case 182:
					goto IL_182A;
				case 183:
					goto IL_1927;
				case 184:
					goto IL_5E1;
				case 185:
					goto IL_1335;
				case 186:
					goto IL_144A;
				case 187:
					goto IL_D71;
				case 188:
					goto IL_EFC;
				case 189:
					goto IL_AB3;
				case 190:
					goto IL_F16;
				case 191:
					goto IL_A8F;
				case 192:
					goto IL_DE0;
				case 193:
					goto IL_D40;
				case 194:
					goto IL_4FA;
				case 195:
					goto IL_FB9;
				case 196:
					goto IL_C93;
				case 197:
					goto IL_1647;
				case 198:
					goto IL_4A2;
				case 199:
					goto IL_D02;
				case 200:
					goto IL_143D;
				case 201:
					goto IL_D7E;
				case 202:
					goto IL_E4F;
				case 203:
					goto IL_166B;
				case 204:
					goto IL_1373;
				case 205:
					goto IL_B2C;
				case 206:
					goto IL_156C;
				case 207:
					goto IL_CAD;
				case 208:
					goto IL_11FC;
				case 209:
					goto IL_6CC;
				case 210:
					goto IL_8B3;
				case 211:
					goto IL_12B6;
				case 212:
					goto IL_960;
				case 213:
					goto IL_13D8;
				case 214:
					goto IL_113C;
				case 215:
					goto IL_1044;
				case 216:
					goto IL_15CE;
				case 217:
					goto IL_189E;
				case 218:
					goto IL_7BE;
				case 219:
					goto IL_1488;
				case 220:
					goto IL_9F9;
				case 221:
					goto IL_1457;
				case 222:
					goto IL_1254;
				case 223:
					goto IL_5BA;
				case 224:
					goto IL_C0D;
				case 225:
					goto IL_C6F;
				case 226:
					goto IL_123A;
				case 227:
					goto IL_4C9;
				case 228:
					goto IL_1416;
				case 229:
					goto IL_151E;
				case 230:
					goto IL_61F;
				case 231:
					goto IL_88F;
				case 232:
					goto IL_F09;
				case 233:
					goto IL_8C0;
				case 234:
					goto IL_11C8;
				case 235:
					goto IL_1149;
				case 236:
					goto IL_12D0;
				case 237:
					goto IL_D1C;
				case 238:
					goto IL_152B;
				case 239:
					goto IL_6FD;
				case 240:
					goto IL_8E4;
				case 241:
					goto IL_F6E;
				case 242:
					goto IL_52E;
				case 243:
					goto IL_177D;
				case 244:
					goto IL_DA2;
				case 245:
					goto IL_16C3;
				case 246:
					goto IL_1965;
				case 247:
					goto IL_173F;
				case 248:
					goto IL_5AD;
				case 249:
					goto IL_9C5;
				case 250:
					goto IL_178A;
				case 251:
					goto IL_507;
				case 252:
					goto IL_752;
				case 253:
					goto IL_10B3;
				case 254:
					goto IL_F30;
				case 255:
					goto IL_11A1;
				case 256:
					goto IL_1999;
				case 257:
					goto IL_1037;
				case 258:
					goto IL_DED;
				case 259:
					goto IL_FDD;
				case 260:
					goto IL_FEA;
				case 261:
					goto IL_130E;
				case 262:
					goto IL_18C5;
				case 263:
					goto IL_1423;
				case 264:
					goto IL_15FF;
				case 265:
					goto IL_181D;
				case 266:
					goto IL_11AE;
				case 267:
					goto IL_F7B;
				case 268:
					goto IL_1552;
				case 269:
					goto IL_53B;
				case 270:
					goto IL_1430;
				case 271:
					goto IL_174C;
				case 272:
					goto IL_126E;
				case 273:
					goto IL_139A;
				case 274:
					goto IL_EA4;
				case 275:
					goto IL_12DD;
				default:
					num = (short)911474688;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_4A2:
			this.RTDBtnZnChanCfgChannelsTalkgroup_A9276 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4AF:
			this.ZnChanCfgChannelsChannelColorBacklightSelection_43749_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_4BC:
			this.ZoneChannelAssignmentRSIMode_A41831Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4C9:
			this.LblZnChanCfgChannelsChannelColorBacklightSelection_43749 = (global::AcpUI.AcpLabel)target;
			this.LblZnChanCfgChannelsChannelColorBacklightSelection_43749.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4ED:
			this.CpyBtnVCZoneAnnouncement_A21515 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4FA:
			this.ZnChanCfgChannelsPersonality_A8698Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_507:
			this.CVBtnZnChanCfgChannelsFallbackZone = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_514:
			this.ExpanderZoneChannelAssignmentChannelAssignmentListSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_521:
			this.CVBtnZoneChannelAssignmentRSISiteNumber_A41833 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_52E:
			this.ZnChanCfgChannelsFiregroundSectorID_A33630Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_53B:
			this.GrpBoxExpanderZoneChannelAssignmentLabtoolPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_548:
			this.ZoneChannelAssignmentRSIDTRTogTime_A41836Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_555:
			((global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.PageZoneChannelAssignment)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.PageZoneChannelAssignment)target).Unloaded += this.OnUnloaded;
			return;
			IL_586:
			this.CVBtnZoneChannelAssignmentRSIMode_A41831 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_593:
			this.ZnChanCfgZoneDynamicZoneEnable_A41257Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_5A0:
			this.RTDBtnZoneChannelAssignmentRSITransmitIndication_A41834 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5AD:
			this.CpyBtnVCChannelAnnouncement_A20176 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5BA:
			this.CpyBtnZnChanCfgTopLightColor_A43173 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5C7:
			this.CpyBtnZoneChannelAssignmentRSIAutoDial_A41832 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5D4:
			this.RTDBtnZoneChannelAssignmentRSIAutoDial_A41832 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5E1:
			this.CVBtnZnChanCfgChannelsChannelType_A22241 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5EE:
			this.LblAlternateComparatorHostname_43797 = (global::AcpUI.AcpLabel)target;
			this.LblAlternateComparatorHostname_43797.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_612:
			this.CVBtnZoneChannelAssignmentRSITransmitIndication_A41834 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_61F:
			this.ZnChanCfgChannelsChannelColorBacklightSelection_43749Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_62C:
			this.LblMainComparatorDTLSPortNumber_43798 = (global::AcpUI.AcpLabel)target;
			this.LblMainComparatorDTLSPortNumber_43798.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_650:
			this.CpyBtnZoneChannelAssignmentRSISiteNumber_A41833 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_65D:
			this.RTDBtnZoneChannelAssignmentRSISiteNumber_A41833 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_66A:
			this.ExpanderZoneChannelAssignmentChannels = (global::AcpUI.AcpExpander)target;
			return;
			IL_677:
			this.HLinkChannels = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkChannels.Click += this.HLinkClick;
			return;
			IL_69B:
			this.ZnChanCfgFPPProtectionProtectedZone_A8765 = (global::AcpUI.AcpCheckBox)target;
			this.ZnChanCfgFPPProtectionProtectedZone_A8765.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_6BF:
			this.AlternateComparatorHostname_43797Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_6CC:
			this.LblZnChanCfgChannelsRadioProfileCompositeItemNameID_A20192 = (global::AcpUI.AcpLabel)target;
			this.LblZnChanCfgChannelsRadioProfileCompositeItemNameID_A20192.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_6F0:
			this.CVBtnComparatorChannelNumber_43800 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6FD:
			this.LblZnChanCfgChannelsFiregroundSectorID_A33630 = (global::AcpUI.AcpLabel)target;
			this.LblZnChanCfgChannelsFiregroundSectorID_A33630.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_721:
			this.CVBtnZnChanCfgZoneZoneCloningEnable_43119 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_72E:
			this.HLinkRSI = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkRSI.Click += this.HLinkClick;
			return;
			IL_752:
			this.LblZnChanCfgChannelsFallbackZone = (global::AcpUI.AcpLabel)target;
			this.LblZnChanCfgChannelsFallbackZone.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_776:
			this.LblZoneChannelAssignmentRSISiteNumber_A41833 = (global::AcpUI.AcpLabel)target;
			this.LblZoneChannelAssignmentRSISiteNumber_A41833.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_79A:
			this.ZnChanCfgZoneDynamicZoneEnable_A41257 = (global::AcpUI.AcpCheckBox)target;
			this.ZnChanCfgZoneDynamicZoneEnable_A41257.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_7BE:
			this.ChannelAnnouncementID_A20175Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_7CB:
			this.ZnChanCfgZoneTopDisplayZone_A19772 = (global::AcpUI.AcpTextBox)target;
			this.ZnChanCfgZoneTopDisplayZone_A19772.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_7EF:
			num = (short)2050805740;
			short num3 = num;
			num = (short)246206444;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_EB1:
				this.ZnChanCfgFPPProtectionProtectedZone_A8765Comp = (global::AcpUI.AcpCheckBox)target;
				return;
			default:
				num = (short)24248320;
				if (num != 0)
				{
				}
				this.LblZnChanCfgZoneZoneCloningEnable_43119 = (global::AcpUI.AcpLabel)target;
				this.LblZnChanCfgZoneZoneCloningEnable_43119.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
				return;
			}
			IL_85E:
			this.CVBtnZnChanCfgChannelsChannelName_A7659 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_86B:
			this.ZoneChannelAssignmentRSITransmitIndication_A41834 = (global::AcpUI.AcpCheckBox)target;
			this.ZoneChannelAssignmentRSITransmitIndication_A41834.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_88F:
			this.ChannelsActiveChannel = (global::AcpUI.AcpCheckBox)target;
			this.ChannelsActiveChannel.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_8B3:
			this.RTDBtnZnChanCfgChannelsRadioProfileCompositeItemNameID_A20192 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_8C0:
			this.LblChannelsActiveChannel = (global::AcpUI.AcpLabel)target;
			this.LblChannelsActiveChannel.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_8E4:
			this.RTDBtnZnChanCfgChannelsFiregroundSectorID_A33630 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_8F1:
			this.ZnChanCfgZoneZoneCloningEnable_43119Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_8FE:
			this.ZnChanCfgChannelsChannelName_A7659 = (global::AcpUI.AcpTextBox)target;
			this.ZnChanCfgChannelsChannelName_A7659.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_922:
			this.LblAlternateComparatorDTLSPortNumber_43801 = (global::AcpUI.AcpLabel)target;
			this.LblAlternateComparatorDTLSPortNumber_43801.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_946:
			this.ZnChanCfgChannelsTalkgroup_A9276_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_953:
			this.CVBtnZnChanCfgZoneDynamicZoneEnable_A41257 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_960:
			this.ZnChanCfgChannelsRadioProfileCompositeItemNameID_A20192Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_96D:
			this.ChannelsActiveChannel_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_97A:
			this.ZoneChannelAssignmentRSITimeDialAtt_A41835 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.ZoneChannelAssignmentRSITimeDialAtt_A41835.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_99E:
			this.ComparatorChannelNumber_43800Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_9AB:
			this.RTDBtnZoneChannelAssignmentRSITimeDialAtt_A41835 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_9B8:
			this.ZnChanCfgChannelsTopDisplayChannel_A19774_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_9C5:
			this.VCChannelAnnouncement_A20176Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_9D2:
			this.CVBtnZnChanCfgFPPProtectionProtectedZone_A8765 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_9DF:
			this.ZoneChannelAssignmentRSITimeDialAtt_A41835Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_9EC:
			this.ZnChanCfgChannelsFallbackZone_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_9F9:
			this.CVBtnZnChanCfgTopLightColor_A43173 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A06:
			this.VCChannelAnnouncement_A20176_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_A13:
			this.ZoneChannelAssignmentRSITransmitIndication_A41834Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_A20:
			this.ZoneVoiceAnnouncementID_A21514 = (global::AcpUI.AcpComboBox)target;
			this.ZoneVoiceAnnouncementID_A21514.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_A44:
			this.RadInfoGeneralCodeplugAlias_A7684Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_A51:
			this.HLinkLabtool = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkLabtool.Click += this.HLinkClick;
			return;
			IL_A75:
			this.TTSBtnVCZoneAnnouncement_A21515 = (global::AcpUITTS.AcpTTSButton)target;
			return;
			IL_A82:
			this.CpyBtnAlternateComparatorDTLSPortNumber_43801 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A8F:
			this.LblZnChanCfgChannelsPersonality_A8698 = (global::AcpUI.AcpLabel)target;
			this.LblZnChanCfgChannelsPersonality_A8698.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_AB3:
			this.ZnChanCfgChannelsPersonality_A8698 = (global::AcpUI.AcpComboBox)target;
			this.ZnChanCfgChannelsPersonality_A8698.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_AD7:
			this.CpyBtnZnChanCfgChannelsTopDisplayChannel_A19774 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_AE4:
			this.AlternateComparatorDTLSPortNumber_43801 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.AlternateComparatorDTLSPortNumber_43801.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B08:
			this.RecNavToolbarExpanderZoneChannelAssignmentChannelAssignmentList = (global::AcpUI.AcpChildRecNavToolbar)target;
			this.RecNavToolbarExpanderZoneChannelAssignmentChannelAssignmentList.ModeClick += this.OnModeClick;
			return;
			IL_B2C:
			this.CpyBtnZnChanCfgChannelsConventionalChannelReference_A20560 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B51:
			goto IL_19BD;
			IL_B56:
			this.RecNavToolbarPageZoneChannelAssignment = (global::AcpUI.AcpParentRecNavToolbar)target;
			this.RecNavToolbarPageZoneChannelAssignment.ModeClick += this.OnModeClick;
			return;
			IL_B7A:
			this.ZnChanCfgChannelsConventionalChannelReference_A20560_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_B87:
			this.CpyBtnZoneChannelAssignmentRSIDTRTogTime_A41836 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B94:
			this.LblZoneChannelAssignmentRSITimeDialAtt_A41835 = (global::AcpUI.AcpLabel)target;
			this.LblZoneChannelAssignmentRSITimeDialAtt_A41835.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_BB8:
			this.RTDBtnAlternateComparatorDTLSPortNumber_43801 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_BC5:
			this.LblZnChanCfgFPPProtectionProtectedZone_A8765 = (global::AcpUI.AcpLabel)target;
			this.LblZnChanCfgFPPProtectionProtectedZone_A8765.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_BE9:
			this.LblZnChanCfgZoneDynamicZoneEnable_A41257 = (global::AcpUI.AcpLabel)target;
			this.LblZnChanCfgZoneDynamicZoneEnable_A41257.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_C0D:
			this.ZnChanCfgTopLightColor_A43173Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_C1A:
			this.ZnChanCfgChannelsTopDisplayChannel_A19774 = (global::AcpUI.AcpTextBox)target;
			this.ZnChanCfgChannelsTopDisplayChannel_A19774.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_C3E:
			this.LblZnChanCfgChannelsTopDisplayChannel_A19774 = (global::AcpUI.AcpLabel)target;
			this.LblZnChanCfgChannelsTopDisplayChannel_A19774.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_C62:
			this.CpyBtnMainComparatorDTLSPortNumber_43798 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_C6F:
			this.ZnChanCfgChannelsChannelColorBacklightSelection_43749 = (global::AcpUI.AcpComboBox)target;
			this.ZnChanCfgChannelsChannelColorBacklightSelection_43749.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_C93:
			this.CVBtnZnChanCfgChannelsTalkgroup_A9276 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_CA0:
			this.ExpanderZoneChannelAssignmentChannelAssignmentList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_CAD:
			this.ZnChanCfgChannelsRadioProfileCompositeItemNameID_A20192 = (global::AcpUI.AcpComboBox)target;
			this.ZnChanCfgChannelsRadioProfileCompositeItemNameID_A20192.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_CD1:
			this.MainComparatorHostname_43796Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_CDE:
			this.ComparatorChannelNumber_43800 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.ComparatorChannelNumber_43800.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_D02:
			this.CpyBtnZnChanCfgChannelsTalkgroup_A9276 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_D0F:
			this.ZnChanCfgChannelsChannelName_A7659Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_D1C:
			this.ZnChanCfgChannelsFiregroundSectorID_A33630 = (global::AcpUI.AcpTextBox)target;
			this.ZnChanCfgChannelsFiregroundSectorID_A33630.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_D40:
			this.CpyBtnZnChanCfgChannelsPersonality_A8698 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_D4D:
			this.LblZnChanCfgChannelsChannelName_A7659 = (global::AcpUI.AcpLabel)target;
			this.LblZnChanCfgChannelsChannelName_A7659.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_D71:
			this.CpyBtnZnChanCfgChannelsChannelType_A22241 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_D7E:
			this.ZnChanCfgChannelsConventionalChannelReference_A20560 = (global::AcpUI.AcpComboBox)target;
			this.ZnChanCfgChannelsConventionalChannelReference_A20560.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_DA2:
			this.LblVCChannelAnnouncement_A20176 = (global::AcpUI.AcpLabel)target;
			this.LblVCChannelAnnouncement_A20176.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_DC6:
			this.CVBtnZnChanCfgZoneZoneName_A9724 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_DD3:
			this.CpyBtnMainComparatorHostname_43796 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_DE0:
			this.RTDBtnZnChanCfgChannelsPersonality_A8698 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_DED:
			this.LblZnChanCfgChannelsFallbackChannel = (global::AcpUI.AcpLabel)target;
			this.LblZnChanCfgChannelsFallbackChannel.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_E11:
			this.Position_38487 = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_E1E:
			this.ZoneChannelAssignmentRSIDTRTogTime_A41836 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.ZoneChannelAssignmentRSIDTRTogTime_A41836.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_E42:
			this.RTDBtnZnChanCfgZoneTopDisplayZone_A19772 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_E4F:
			this.CVBtnZnChanCfgChannelsConventionalChannelReference_A20560 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_E5C:
			this.LblComparatorChannelNumber_43800 = (global::AcpUI.AcpLabel)target;
			this.LblComparatorChannelNumber_43800.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_E80:
			this.ZoneChannelAssignmentRSIAutoDial_A41832 = (global::AcpUI.AcpCheckBox)target;
			this.ZoneChannelAssignmentRSIAutoDial_A41832.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_EA4:
			this.CpyBtnZnChanCfgLabtoolLastSelectedChnl_A41075 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_EBE:
			this.ZnChanCfgZoneZoneName_A9724 = (global::AcpUI.AcpTextBox)target;
			this.ZnChanCfgZoneZoneName_A9724.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_EE2:
			this.ZnChanCfgZoneTopDisplayZone_A19772Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_EEF:
			this.RTDBtnVCZoneAnnouncement_A21515 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_EFC:
			this.ZnChanCfgChannelsChannelType_A22241Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_F09:
			this.CVBtnChannelsActiveChannel = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_F16:
			this.CVBtnZnChanCfgChannelsPersonality_A8698 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_F23:
			this.ExpanderZoneChannelAssignmentChannelAssignmentListTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_F30:
			this.CpyBtnZnChanCfgChannelsFallbackZone = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_F3D:
			this.ZoneChannelAssignmentRSISiteNumber_A41833Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_F4A:
			this.ZnChanCfgFPPProtectionFPPEnable_A19562 = (global::AcpUI.AcpCheckBox)target;
			this.ZnChanCfgFPPProtectionFPPEnable_A19562.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_F6E:
			this.CpyBtnZnChanCfgChannelsFiregroundSectorID_A33630 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_F7B:
			this.ZnChanCfgChannelsWiFiComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_F88:
			this.GrpBoxExpanderZoneChannelAssignmentRSIAutodial = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_F95:
			this.MainComparatorHostname_43796 = (global::AcpUI.AcpTextBox)target;
			this.MainComparatorHostname_43796.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_FB9:
			this.ZnChanCfgChannelsTalkgroup_A9276 = (global::AcpUI.AcpComboBox)target;
			this.ZnChanCfgChannelsTalkgroup_A9276.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_FDD:
			this.RTDBtnZnChanCfgChannelsFallbackChannel = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_FEA:
			this.CpyBtnZnChanCfgChannelsFallbackChannel = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_FF7:
			this.CpyBtnAlternateComparatorHostname_43797 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1004:
			num = (short)1098383361;
			if (num != 0)
			{
			}
			this.CpyBtnZoneChannelAssignmentRSITimeDialAtt_A41835 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1037:
			this.CVBtnZnChanCfgChannelsFallbackChannel = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1044:
			this.LblChannelAnnouncementID_A20175 = (global::AcpUI.AcpLabel)target;
			this.LblChannelAnnouncementID_A20175.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1068:
			this.ZnChanCfgChannelsRadioProfileCompositeItemNameID_A20192_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1075:
			this.CVBtnMainComparatorHostname_43796 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1082:
			this.LblVCZoneAnnouncement_A21515 = (global::AcpUI.AcpLabel)target;
			this.LblVCZoneAnnouncement_A21515.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_10A6:
			this.RTDBtnZnChanCfgFPPProtectionFPPEnable_A19562 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_10B3:
			this.RTDBtnZnChanCfgChannelsFallbackZone = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_10C0:
			this.GrpBoxExpanderZoneChannelAssignmentZonePseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_10CD:
			this.RTDBtnZnChanCfgZoneDynamicZoneEnable_A41257 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_10DA:
			this.LblZoneChannelAssignmentRSIMode_A41831 = (global::AcpUI.AcpLabel)target;
			this.LblZoneChannelAssignmentRSIMode_A41831.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_10FE:
			this.LblZoneVoiceAnnouncementID_A21514 = (global::AcpUI.AcpLabel)target;
			this.LblZoneVoiceAnnouncementID_A21514.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1122:
			this.CVBtnAlternateComparatorHostname_43797 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_112F:
			this.CpyBtnZoneVoiceAnnouncementID_A21514 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_113C:
			this.CVBtnChannelAnnouncementID_A20175 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1149:
			this.CpyBtnChannelsActiveChannel = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1156:
			this.MainComparatorDTLSPortNumber_43798 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.MainComparatorDTLSPortNumber_43798.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_117A:
			this.gridExpanderZoneChannelAssignmentChannelAssignmentListSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_1187:
			this.CpyBtnZnChanCfgFPPProtectionProtectedZone_A8765 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1194:
			this.CpyBtnZnChanCfgZoneZoneCloningEnable_43119 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_11A1:
			this.ZnChanCfgChannelsFallbackZoneComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_11AE:
			this.CpyBtnZnChanCfgChannelsWiFi = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_11BB:
			this.RTDBtnZoneVoiceAnnouncementID_A21514 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_11C8:
			this.RTDBtnChannelsActiveChannel = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_11D5:
			this.ZnChanCfgChannelsFallbackChannel_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_11E2:
			this.ZnChanCfgTopLightColor_A43173_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_11EF:
			this.RTDBtnZnChanCfgFPPProtectionProtectedZone_A8765 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_11FC:
			this.CVBtnZnChanCfgChannelsRadioProfileCompositeItemNameID_A20192 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1209:
			this.ExpanderZoneChannelAssignmentChannelsGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_1216:
			this.ZoneChannelAssignmentRSISiteNumber_A41833 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.ZoneChannelAssignmentRSISiteNumber_A41833.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_123A:
			this.CVBtnZnChanCfgChannelsChannelColorBacklightSelection_43749 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1247:
			this.RTDBtnZnChanCfgZoneZoneCloningEnable_43119 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1254:
			this.RTDBtnZnChanCfgTopLightColor_A43173 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1261:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_126E:
			this.ZnChanCfgLabtoolLastSelectedChnl_A41075 = (global::AcpUI.AcpComboBox)target;
			this.ZnChanCfgLabtoolLastSelectedChnl_A41075.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1292:
			this.LblZnChanCfgZoneTopDisplayZone_A19772 = (global::AcpUI.AcpLabel)target;
			this.LblZnChanCfgZoneTopDisplayZone_A19772.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_12B6:
			this.CpyBtnZnChanCfgChannelsRadioProfileCompositeItemNameID_A20192 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_12C3:
			this.CpyBtnZnChanCfgFPPProtectionFPPEnable_A19562 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_12D0:
			this.ChannelsActiveChannelComp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_12DD:
			this.ZnChanCfgLabtoolLastSelectedChnl_A41075Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_12EA:
			this.VCZoneAnnouncement_A21515 = (global::AcpUI.AcpTextBox)target;
			this.VCZoneAnnouncement_A21515.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_130E:
			this.ZnChanCfgChannelsFallbackChannelComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_131B:
			this.ZnChanCfgChannelsWiFi_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1328:
			this.RTDBtnComparatorChannelNumber_43800 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1335:
			this.LblZnChanCfgChannelsChannelType_A22241 = (global::AcpUI.AcpLabel)target;
			this.LblZnChanCfgChannelsChannelType_A22241.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1359:
			this.CVBtnVCZoneAnnouncement_A21515 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1366:
			this.ExpanderZoneChannelAssignmentRSI = (global::AcpUI.AcpExpander)target;
			return;
			IL_1373:
			this.RTDBtnZnChanCfgChannelsConventionalChannelReference_A20560 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1380:
			this.CpyBtnZoneChannelAssignmentRSITransmitIndication_A41834 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_138D:
			this.ChannelAnnouncementID_A20175_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_139A:
			this.RTDBtnZnChanCfgLabtoolLastSelectedChnl_A41075 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_13A7:
			this.LblZnChanCfgZoneZoneName_A9724 = (global::AcpUI.AcpLabel)target;
			this.LblZnChanCfgZoneZoneName_A9724.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_13CB:
			this.RTDBtnZoneChannelAssignmentRSIDTRTogTime_A41836 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_13D8:
			this.ChannelAnnouncementID_A20175 = (global::AcpUI.AcpComboBox)target;
			this.ChannelAnnouncementID_A20175.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_13FC:
			this.GrpBoxExpanderZoneChannelAssignmentFPPProtectionPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1409:
			this.CVBtnZnChanCfgFPPProtectionFPPEnable_A19562 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1416:
			this.RTDBtnZnChanCfgChannelsChannelColorBacklightSelection_43749 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1423:
			this.CVBtnZnChanCfgChannelsWiFi = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1430:
			this.CVBtnZnChanCfgLabtoolLastSelectedChnl_A41075 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_143D:
			this.ZnChanCfgChannelsTalkgroup_A9276Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_144A:
			this.RTDBtnZnChanCfgChannelsChannelType_A22241 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1457:
			this.LblZnChanCfgTopLightColor_A43173 = (global::AcpUI.AcpLabel)target;
			this.LblZnChanCfgTopLightColor_A43173.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_147B:
			this.CVBtnAlternateComparatorDTLSPortNumber_43801 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1488:
			this.ZnChanCfgTopLightColor_A43173 = (global::AcpUI.AcpComboBox)target;
			this.ZnChanCfgTopLightColor_A43173.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_14AC:
			this.RTDBtnAlternateComparatorHostname_43797 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_14B9:
			this.HLinkFPPProtection = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkFPPProtection.Click += this.HLinkClick;
			return;
			IL_14DD:
			this.MainComparatorDTLSPortNumber_43798Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_14EA:
			this.CVBtnMainComparatorDTLSPortNumber_43798 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_14F7:
			this.ZoneVoiceAnnouncementID_A21514Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1504:
			this.CVBtnZnChanCfgChannelsTopDisplayChannel_A19774 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1511:
			this.ZnChanCfgZoneZoneName_A9724Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_151E:
			this.CpyBtnZnChanCfgChannelsChannelColorBacklightSelection_43749 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_152B:
			this.CVBtnZnChanCfgChannelsFiregroundSectorID_A33630 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1538:
			this.CVBtnZoneChannelAssignmentRSIDTRTogTime_A41836 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1545:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_1552:
			this.ExpanderZoneChannelAssignmentLabtool = (global::AcpUI.AcpExpander)target;
			return;
			IL_155F:
			this.AlternateComparatorDTLSPortNumber_43801Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_156C:
			this.ZnChanCfgChannelsConventionalChannelReference_A20560Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1579:
			this.ZnChanCfgZoneZoneCloningEnable_43119 = (global::AcpUI.AcpCheckBox)target;
			this.ZnChanCfgZoneZoneCloningEnable_43119.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_159D:
			this.CVBtnZoneChannelAssignmentRSITimeDialAtt_A41835 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_15AA:
			this.LblZoneChannelAssignmentRSIAutoDial_A41832 = (global::AcpUI.AcpLabel)target;
			this.LblZoneChannelAssignmentRSIAutoDial_A41832.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_15CE:
			this.RTDBtnChannelAnnouncementID_A20175 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_15DB:
			this.LblZnChanCfgFPPProtectionFPPEnable_A19562 = (global::AcpUI.AcpLabel)target;
			this.LblZnChanCfgFPPProtectionFPPEnable_A19562.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_15FF:
			this.LblZnChanCfgChannelsWiFi = (global::AcpUI.AcpLabel)target;
			this.LblZnChanCfgChannelsWiFi.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1623:
			this.LblZoneChannelAssignmentRSITransmitIndication_A41834 = (global::AcpUI.AcpLabel)target;
			this.LblZoneChannelAssignmentRSITransmitIndication_A41834.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1647:
			this.LblZnChanCfgChannelsTalkgroup_A9276 = (global::AcpUI.AcpLabel)target;
			this.LblZnChanCfgChannelsTalkgroup_A9276.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_166B:
			this.LblZnChanCfgChannelsConventionalChannelReference_A20560 = (global::AcpUI.AcpLabel)target;
			this.LblZnChanCfgChannelsConventionalChannelReference_A20560.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_168F:
			this.ExpanderZoneChannelAssignmentZone = (global::AcpUI.AcpExpander)target;
			return;
			IL_169C:
			this.ExpanderZoneChannelAssignmentChannelAssignmentListGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_16A9:
			this.ExpanderZoneChannelAssignmentFPPProtection = (global::AcpUI.AcpExpander)target;
			return;
			IL_16B6:
			this.RTDBtnMainComparatorHostname_43796 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_16C3:
			this.VCChannelAnnouncement_A20176 = (global::AcpUI.AcpTextBox)target;
			this.VCChannelAnnouncement_A20176.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_16E7:
			this.ZnChanCfgChannelsChannelName_A7659_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_16F4:
			this.CVBtnZnChanCfgZoneTopDisplayZone_A19772 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1701:
			this.LblMainComparatorHostname_43796 = (global::AcpUI.AcpLabel)target;
			this.LblMainComparatorHostname_43796.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1725:
			this.CpyBtnComparatorChannelNumber_43800 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1732:
			this.ZnChanCfgChannelsPersonality_A8698_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_173F:
			this.RTDBtnVCChannelAnnouncement_A20176 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_174C:
			this.LblZnChanCfgLabtoolLastSelectedChnl_A41075 = (global::AcpUI.AcpLabel)target;
			this.LblZnChanCfgLabtoolLastSelectedChnl_A41075.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1770:
			this.CpyBtnZnChanCfgChannelsChannelName_A7659 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_177D:
			this.CVBtnVCChannelAnnouncement_A20176 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_178A:
			this.ZnChanCfgChannelsFallbackZone = (global::AcpUI.AcpComboBox)target;
			this.ZnChanCfgChannelsFallbackZone.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_17AE:
			this.LblZoneChannelAssignmentRSIDTRTogTime_A41836 = (global::AcpUI.AcpLabel)target;
			this.LblZoneChannelAssignmentRSIDTRTogTime_A41836.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_17D2:
			this.ZnChanCfgChannelsChannelType_A22241_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_17DF:
			this.CVBtnZoneChannelAssignmentRSIAutoDial_A41832 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_17EC:
			this.CpyBtnZnChanCfgZoneDynamicZoneEnable_A41257 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_17F9:
			this.ZoneChannelAssignmentRSIMode_A41831 = (global::AcpUI.AcpComboBox)target;
			this.ZoneChannelAssignmentRSIMode_A41831.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_181D:
			this.RTDBtnZnChanCfgChannelsWiFi = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_182A:
			this.ZnChanCfgChannelsTopDisplayChannel_A19774Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1837:
			num = (short)1725693952;
			short num4 = num;
			this.ZoneChannelAssignmentRSIAutoDial_A41832Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_186D:
			this.CpyBtnZnChanCfgZoneTopDisplayZone_A19772 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_187A:
			this.HLinkZone = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkZone.Click += this.HLinkClick;
			return;
			IL_189E:
			this.CpyBtnChannelAnnouncementID_A20175 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_18AB:
			this.ZnChanCfgFPPProtectionFPPEnable_A19562Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_18B8:
			this.CpyBtnZoneChannelAssignmentRSIMode_A41831 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_18C5:
			this.ZnChanCfgChannelsWiFi = (global::AcpUI.AcpComboBox)target;
			this.ZnChanCfgChannelsWiFi.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_18E9:
			this.RTDBtnZoneChannelAssignmentRSIMode_A41831 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_18F6:
			this.AlternateComparatorHostname_43797 = (global::AcpUI.AcpTextBox)target;
			this.AlternateComparatorHostname_43797.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_191A:
			this.ZnChanCfgChannelsFiregroundSectorID_A33630_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1927:
			this.ZnChanCfgChannelsChannelType_A22241 = (global::AcpUI.AcpComboBox)target;
			this.ZnChanCfgChannelsChannelType_A22241.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_194B:
			this.GrpBoxExpanderZoneChannelAssignmentRSIPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1958:
			this.CVBtnZoneVoiceAnnouncementID_A21514 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1965:
			this.TTSBtnVCChannelAnnouncement_A20176 = (global::AcpUITTS.AcpTTSButton)target;
			return;
			IL_1972:
			this.RTDBtnZnChanCfgChannelsTopDisplayChannel_A19774 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_197F:
			this.CpyBtnZnChanCfgZoneZoneName_A9724 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_198C:
			this.RTDBtnMainComparatorDTLSPortNumber_43798 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1999:
			this.ZnChanCfgChannelsFallbackChannel = (global::AcpUI.AcpComboBox)target;
			this.ZnChanCfgChannelsFallbackChannel.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_19BD:
			this.b = true;
		}

		// Token: 0x060003CB RID: 971 RVA: 0x0004541C File Offset: 0x0004361C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 3:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 4:
				((global::AcpUITTS.AcpTTSTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 5:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
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
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 10:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 11:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 12:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 13:
			{
				short num = (short)1300824065;
				if (num != 0)
				{
				}
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			case 14:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 15:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 16:
			{
				short num = (short)781283271;
				short num2 = num;
				num = (short)970747847;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1939079168;
					if (num != 0)
					{
					}
					((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				}
				break;
			}
			case 17:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 18:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			default:
			{
				short num = (short)1016004608;
				short num3 = num;
				return;
			}
			}
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x040000C9 RID: 201
		private bool a;

		// Token: 0x040000CA RID: 202
		internal global::AcpUI.AcpParentRecNavToolbar RecNavToolbarPageZoneChannelAssignment;

		// Token: 0x040000CB RID: 203
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x040000CC RID: 204
		internal global::System.Windows.Documents.Hyperlink HLinkZone;

		// Token: 0x040000CD RID: 205
		internal global::System.Windows.Documents.Hyperlink HLinkRSI;

		// Token: 0x040000CE RID: 206
		internal global::System.Windows.Documents.Hyperlink HLinkFPPProtection;

		// Token: 0x040000CF RID: 207
		internal global::System.Windows.Documents.Hyperlink HLinkChannels;

		// Token: 0x040000D0 RID: 208
		internal global::System.Windows.Documents.Hyperlink HLinkLabtool;

		// Token: 0x040000D1 RID: 209
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x040000D2 RID: 210
		internal global::AcpUI.AcpExpander ExpanderZoneChannelAssignmentZone;

		// Token: 0x040000D3 RID: 211
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderZoneChannelAssignmentZonePseudo0;

		// Token: 0x040000D4 RID: 212
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnZnChanCfgZoneZoneName_A9724;

		// Token: 0x040000D5 RID: 213
		internal global::AcpUI.AcpLabel LblZnChanCfgZoneZoneName_A9724;

		// Token: 0x040000D6 RID: 214
		internal global::AcpUI.AcpTextBox ZnChanCfgZoneZoneName_A9724;

		// Token: 0x040000D7 RID: 215
		internal global::AcpUI.AcpCopyButton CpyBtnZnChanCfgZoneZoneName_A9724;

		// Token: 0x040000D8 RID: 216
		internal global::AcpUI.AcpLabel ZnChanCfgZoneZoneName_A9724Comp;

		// Token: 0x040000D9 RID: 217
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnZnChanCfgZoneTopDisplayZone_A19772;

		// Token: 0x040000DA RID: 218
		internal global::AcpUI.AcpLabel LblZnChanCfgZoneTopDisplayZone_A19772;

		// Token: 0x040000DB RID: 219
		internal global::AcpUI.AcpTextBox ZnChanCfgZoneTopDisplayZone_A19772;

		// Token: 0x040000DC RID: 220
		internal global::AcpUI.AcpRtdButton RTDBtnZnChanCfgZoneTopDisplayZone_A19772;

		// Token: 0x040000DD RID: 221
		internal global::AcpUI.AcpCopyButton CpyBtnZnChanCfgZoneTopDisplayZone_A19772;

		// Token: 0x040000DE RID: 222
		internal global::AcpUI.AcpLabel ZnChanCfgZoneTopDisplayZone_A19772Comp;

		// Token: 0x040000DF RID: 223
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnZoneVoiceAnnouncementID_A21514;

		// Token: 0x040000E0 RID: 224
		internal global::AcpUI.AcpLabel LblZoneVoiceAnnouncementID_A21514;

		// Token: 0x040000E1 RID: 225
		internal global::AcpUI.AcpComboBox ZoneVoiceAnnouncementID_A21514;

		// Token: 0x040000E2 RID: 226
		internal global::AcpUI.AcpRtdButton RTDBtnZoneVoiceAnnouncementID_A21514;

		// Token: 0x040000E3 RID: 227
		internal global::AcpUI.AcpCopyButton CpyBtnZoneVoiceAnnouncementID_A21514;

		// Token: 0x040000E4 RID: 228
		internal global::AcpUI.AcpLabel ZoneVoiceAnnouncementID_A21514Comp;

		// Token: 0x040000E5 RID: 229
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnVCZoneAnnouncement_A21515;

		// Token: 0x040000E6 RID: 230
		internal global::AcpUI.AcpLabel LblVCZoneAnnouncement_A21515;

		// Token: 0x040000E7 RID: 231
		internal global::AcpUI.AcpTextBox VCZoneAnnouncement_A21515;

		// Token: 0x040000E8 RID: 232
		internal global::AcpUITTS.AcpTTSButton TTSBtnVCZoneAnnouncement_A21515;

		// Token: 0x040000E9 RID: 233
		internal global::AcpUI.AcpRtdButton RTDBtnVCZoneAnnouncement_A21515;

		// Token: 0x040000EA RID: 234
		internal global::AcpUI.AcpCopyButton CpyBtnVCZoneAnnouncement_A21515;

		// Token: 0x040000EB RID: 235
		internal global::AcpUI.AcpLabel RadInfoGeneralCodeplugAlias_A7684Comp;

		// Token: 0x040000EC RID: 236
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnZnChanCfgZoneDynamicZoneEnable_A41257;

		// Token: 0x040000ED RID: 237
		internal global::AcpUI.AcpLabel LblZnChanCfgZoneDynamicZoneEnable_A41257;

		// Token: 0x040000EE RID: 238
		internal global::AcpUI.AcpCheckBox ZnChanCfgZoneDynamicZoneEnable_A41257;

		// Token: 0x040000EF RID: 239
		internal global::AcpUI.AcpRtdButton RTDBtnZnChanCfgZoneDynamicZoneEnable_A41257;

		// Token: 0x040000F0 RID: 240
		internal global::AcpUI.AcpCopyButton CpyBtnZnChanCfgZoneDynamicZoneEnable_A41257;

		// Token: 0x040000F1 RID: 241
		internal global::AcpUI.AcpCheckBox ZnChanCfgZoneDynamicZoneEnable_A41257Comp;

		// Token: 0x040000F2 RID: 242
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnZnChanCfgZoneZoneCloningEnable_43119;

		// Token: 0x040000F3 RID: 243
		internal global::AcpUI.AcpLabel LblZnChanCfgZoneZoneCloningEnable_43119;

		// Token: 0x040000F4 RID: 244
		internal global::AcpUI.AcpCheckBox ZnChanCfgZoneZoneCloningEnable_43119;

		// Token: 0x040000F5 RID: 245
		internal global::AcpUI.AcpRtdButton RTDBtnZnChanCfgZoneZoneCloningEnable_43119;

		// Token: 0x040000F6 RID: 246
		internal global::AcpUI.AcpCopyButton CpyBtnZnChanCfgZoneZoneCloningEnable_43119;

		// Token: 0x040000F7 RID: 247
		internal global::AcpUI.AcpCheckBox ZnChanCfgZoneZoneCloningEnable_43119Comp;

		// Token: 0x040000F8 RID: 248
		internal global::AcpUI.AcpExpander ExpanderZoneChannelAssignmentRSI;

		// Token: 0x040000F9 RID: 249
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderZoneChannelAssignmentRSIPseudo0;

		// Token: 0x040000FA RID: 250
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnZoneChannelAssignmentRSIMode_A41831;

		// Token: 0x040000FB RID: 251
		internal global::AcpUI.AcpLabel LblZoneChannelAssignmentRSIMode_A41831;

		// Token: 0x040000FC RID: 252
		internal global::AcpUI.AcpComboBox ZoneChannelAssignmentRSIMode_A41831;

		// Token: 0x040000FD RID: 253
		internal global::AcpUI.AcpRtdButton RTDBtnZoneChannelAssignmentRSIMode_A41831;

		// Token: 0x040000FE RID: 254
		internal global::AcpUI.AcpCopyButton CpyBtnZoneChannelAssignmentRSIMode_A41831;

		// Token: 0x040000FF RID: 255
		internal global::AcpUI.AcpLabel ZoneChannelAssignmentRSIMode_A41831Comp;

		// Token: 0x04000100 RID: 256
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnZoneChannelAssignmentRSITransmitIndication_A41834;

		// Token: 0x04000101 RID: 257
		internal global::AcpUI.AcpLabel LblZoneChannelAssignmentRSITransmitIndication_A41834;

		// Token: 0x04000102 RID: 258
		internal global::AcpUI.AcpCheckBox ZoneChannelAssignmentRSITransmitIndication_A41834;

		// Token: 0x04000103 RID: 259
		internal global::AcpUI.AcpRtdButton RTDBtnZoneChannelAssignmentRSITransmitIndication_A41834;

		// Token: 0x04000104 RID: 260
		internal global::AcpUI.AcpCopyButton CpyBtnZoneChannelAssignmentRSITransmitIndication_A41834;

		// Token: 0x04000105 RID: 261
		internal global::AcpUI.AcpCheckBox ZoneChannelAssignmentRSITransmitIndication_A41834Comp;

		// Token: 0x04000106 RID: 262
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnZoneChannelAssignmentRSISiteNumber_A41833;

		// Token: 0x04000107 RID: 263
		internal global::AcpUI.AcpLabel LblZoneChannelAssignmentRSISiteNumber_A41833;

		// Token: 0x04000108 RID: 264
		internal global::AcpUI.AcpTextBoxSpinner ZoneChannelAssignmentRSISiteNumber_A41833;

		// Token: 0x04000109 RID: 265
		internal global::AcpUI.AcpRtdButton RTDBtnZoneChannelAssignmentRSISiteNumber_A41833;

		// Token: 0x0400010A RID: 266
		internal global::AcpUI.AcpCopyButton CpyBtnZoneChannelAssignmentRSISiteNumber_A41833;

		// Token: 0x0400010B RID: 267
		internal global::AcpUI.AcpLabel ZoneChannelAssignmentRSISiteNumber_A41833Comp;

		// Token: 0x0400010C RID: 268
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnMainComparatorHostname_43796;

		// Token: 0x0400010D RID: 269
		internal global::AcpUI.AcpLabel LblMainComparatorHostname_43796;

		// Token: 0x0400010E RID: 270
		internal global::AcpUI.AcpTextBox MainComparatorHostname_43796;

		// Token: 0x0400010F RID: 271
		internal global::AcpUI.AcpRtdButton RTDBtnMainComparatorHostname_43796;

		// Token: 0x04000110 RID: 272
		internal global::AcpUI.AcpCopyButton CpyBtnMainComparatorHostname_43796;

		// Token: 0x04000111 RID: 273
		internal global::AcpUI.AcpLabel MainComparatorHostname_43796Comp;

		// Token: 0x04000112 RID: 274
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnMainComparatorDTLSPortNumber_43798;

		// Token: 0x04000113 RID: 275
		internal global::AcpUI.AcpLabel LblMainComparatorDTLSPortNumber_43798;

		// Token: 0x04000114 RID: 276
		internal global::AcpUI.AcpTextBoxSpinner MainComparatorDTLSPortNumber_43798;

		// Token: 0x04000115 RID: 277
		internal global::AcpUI.AcpRtdButton RTDBtnMainComparatorDTLSPortNumber_43798;

		// Token: 0x04000116 RID: 278
		internal global::AcpUI.AcpCopyButton CpyBtnMainComparatorDTLSPortNumber_43798;

		// Token: 0x04000117 RID: 279
		internal global::AcpUI.AcpLabel MainComparatorDTLSPortNumber_43798Comp;

		// Token: 0x04000118 RID: 280
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnAlternateComparatorHostname_43797;

		// Token: 0x04000119 RID: 281
		internal global::AcpUI.AcpLabel LblAlternateComparatorHostname_43797;

		// Token: 0x0400011A RID: 282
		internal global::AcpUI.AcpTextBox AlternateComparatorHostname_43797;

		// Token: 0x0400011B RID: 283
		internal global::AcpUI.AcpRtdButton RTDBtnAlternateComparatorHostname_43797;

		// Token: 0x0400011C RID: 284
		internal global::AcpUI.AcpCopyButton CpyBtnAlternateComparatorHostname_43797;

		// Token: 0x0400011D RID: 285
		internal global::AcpUI.AcpLabel AlternateComparatorHostname_43797Comp;

		// Token: 0x0400011E RID: 286
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnAlternateComparatorDTLSPortNumber_43801;

		// Token: 0x0400011F RID: 287
		internal global::AcpUI.AcpLabel LblAlternateComparatorDTLSPortNumber_43801;

		// Token: 0x04000120 RID: 288
		internal global::AcpUI.AcpTextBoxSpinner AlternateComparatorDTLSPortNumber_43801;

		// Token: 0x04000121 RID: 289
		internal global::AcpUI.AcpRtdButton RTDBtnAlternateComparatorDTLSPortNumber_43801;

		// Token: 0x04000122 RID: 290
		internal global::AcpUI.AcpCopyButton CpyBtnAlternateComparatorDTLSPortNumber_43801;

		// Token: 0x04000123 RID: 291
		internal global::AcpUI.AcpLabel AlternateComparatorDTLSPortNumber_43801Comp;

		// Token: 0x04000124 RID: 292
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnComparatorChannelNumber_43800;

		// Token: 0x04000125 RID: 293
		internal global::AcpUI.AcpLabel LblComparatorChannelNumber_43800;

		// Token: 0x04000126 RID: 294
		internal global::AcpUI.AcpTextBoxSpinner ComparatorChannelNumber_43800;

		// Token: 0x04000127 RID: 295
		internal global::AcpUI.AcpRtdButton RTDBtnComparatorChannelNumber_43800;

		// Token: 0x04000128 RID: 296
		internal global::AcpUI.AcpCopyButton CpyBtnComparatorChannelNumber_43800;

		// Token: 0x04000129 RID: 297
		internal global::AcpUI.AcpLabel ComparatorChannelNumber_43800Comp;

		// Token: 0x0400012A RID: 298
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderZoneChannelAssignmentRSIAutodial;

		// Token: 0x0400012B RID: 299
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnZoneChannelAssignmentRSIAutoDial_A41832;

		// Token: 0x0400012C RID: 300
		internal global::AcpUI.AcpLabel LblZoneChannelAssignmentRSIAutoDial_A41832;

		// Token: 0x0400012D RID: 301
		internal global::AcpUI.AcpCheckBox ZoneChannelAssignmentRSIAutoDial_A41832;

		// Token: 0x0400012E RID: 302
		internal global::AcpUI.AcpRtdButton RTDBtnZoneChannelAssignmentRSIAutoDial_A41832;

		// Token: 0x0400012F RID: 303
		internal global::AcpUI.AcpCopyButton CpyBtnZoneChannelAssignmentRSIAutoDial_A41832;

		// Token: 0x04000130 RID: 304
		internal global::AcpUI.AcpCheckBox ZoneChannelAssignmentRSIAutoDial_A41832Comp;

		// Token: 0x04000131 RID: 305
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnZoneChannelAssignmentRSITimeDialAtt_A41835;

		// Token: 0x04000132 RID: 306
		internal global::AcpUI.AcpLabel LblZoneChannelAssignmentRSITimeDialAtt_A41835;

		// Token: 0x04000133 RID: 307
		internal global::AcpUI.AcpTextBoxSpinner ZoneChannelAssignmentRSITimeDialAtt_A41835;

		// Token: 0x04000134 RID: 308
		internal global::AcpUI.AcpRtdButton RTDBtnZoneChannelAssignmentRSITimeDialAtt_A41835;

		// Token: 0x04000135 RID: 309
		internal global::AcpUI.AcpCopyButton CpyBtnZoneChannelAssignmentRSITimeDialAtt_A41835;

		// Token: 0x04000136 RID: 310
		internal global::AcpUI.AcpLabel ZoneChannelAssignmentRSITimeDialAtt_A41835Comp;

		// Token: 0x04000137 RID: 311
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnZoneChannelAssignmentRSIDTRTogTime_A41836;

		// Token: 0x04000138 RID: 312
		internal global::AcpUI.AcpLabel LblZoneChannelAssignmentRSIDTRTogTime_A41836;

		// Token: 0x04000139 RID: 313
		internal global::AcpUI.AcpTextBoxSpinner ZoneChannelAssignmentRSIDTRTogTime_A41836;

		// Token: 0x0400013A RID: 314
		internal global::AcpUI.AcpRtdButton RTDBtnZoneChannelAssignmentRSIDTRTogTime_A41836;

		// Token: 0x0400013B RID: 315
		internal global::AcpUI.AcpCopyButton CpyBtnZoneChannelAssignmentRSIDTRTogTime_A41836;

		// Token: 0x0400013C RID: 316
		internal global::AcpUI.AcpLabel ZoneChannelAssignmentRSIDTRTogTime_A41836Comp;

		// Token: 0x0400013D RID: 317
		internal global::AcpUI.AcpExpander ExpanderZoneChannelAssignmentFPPProtection;

		// Token: 0x0400013E RID: 318
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderZoneChannelAssignmentFPPProtectionPseudo0;

		// Token: 0x0400013F RID: 319
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnZnChanCfgFPPProtectionProtectedZone_A8765;

		// Token: 0x04000140 RID: 320
		internal global::AcpUI.AcpLabel LblZnChanCfgFPPProtectionProtectedZone_A8765;

		// Token: 0x04000141 RID: 321
		internal global::AcpUI.AcpCheckBox ZnChanCfgFPPProtectionProtectedZone_A8765;

		// Token: 0x04000142 RID: 322
		internal global::AcpUI.AcpRtdButton RTDBtnZnChanCfgFPPProtectionProtectedZone_A8765;

		// Token: 0x04000143 RID: 323
		internal global::AcpUI.AcpCopyButton CpyBtnZnChanCfgFPPProtectionProtectedZone_A8765;

		// Token: 0x04000144 RID: 324
		internal global::AcpUI.AcpCheckBox ZnChanCfgFPPProtectionProtectedZone_A8765Comp;

		// Token: 0x04000145 RID: 325
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnZnChanCfgFPPProtectionFPPEnable_A19562;

		// Token: 0x04000146 RID: 326
		internal global::AcpUI.AcpLabel LblZnChanCfgFPPProtectionFPPEnable_A19562;

		// Token: 0x04000147 RID: 327
		internal global::AcpUI.AcpCheckBox ZnChanCfgFPPProtectionFPPEnable_A19562;

		// Token: 0x04000148 RID: 328
		internal global::AcpUI.AcpRtdButton RTDBtnZnChanCfgFPPProtectionFPPEnable_A19562;

		// Token: 0x04000149 RID: 329
		internal global::AcpUI.AcpCopyButton CpyBtnZnChanCfgFPPProtectionFPPEnable_A19562;

		// Token: 0x0400014A RID: 330
		internal global::AcpUI.AcpCheckBox ZnChanCfgFPPProtectionFPPEnable_A19562Comp;

		// Token: 0x0400014B RID: 331
		internal global::AcpUI.AcpExpander ExpanderZoneChannelAssignmentChannels;

		// Token: 0x0400014C RID: 332
		internal global::AcpUI.AcpChildRecNavToolbar RecNavToolbarExpanderZoneChannelAssignmentChannelAssignmentList;

		// Token: 0x0400014D RID: 333
		internal global::System.Windows.Controls.Grid ExpanderZoneChannelAssignmentChannelsGrid;

		// Token: 0x0400014E RID: 334
		internal global::System.Windows.Controls.Grid ExpanderZoneChannelAssignmentChannelAssignmentListGrid;

		// Token: 0x0400014F RID: 335
		internal global::AcpUI.AcpGroupBox ExpanderZoneChannelAssignmentChannelAssignmentListTableView;

		// Token: 0x04000150 RID: 336
		internal global::AcpUI.AcpXamDataPresenter ExpanderZoneChannelAssignmentChannelAssignmentList;

		// Token: 0x04000151 RID: 337
		internal global::Infragistics.Windows.DataPresenter.UnboundField Position_38487;

		// Token: 0x04000152 RID: 338
		internal global::Infragistics.Windows.DataPresenter.UnboundField ZnChanCfgChannelsChannelName_A7659_Col;

		// Token: 0x04000153 RID: 339
		internal global::Infragistics.Windows.DataPresenter.UnboundField ZnChanCfgChannelsTopDisplayChannel_A19774_Col;

		// Token: 0x04000154 RID: 340
		internal global::Infragistics.Windows.DataPresenter.UnboundField ZnChanCfgChannelsChannelType_A22241_Col;

		// Token: 0x04000155 RID: 341
		internal global::Infragistics.Windows.DataPresenter.UnboundField ZnChanCfgChannelsPersonality_A8698_Col;

		// Token: 0x04000156 RID: 342
		internal global::Infragistics.Windows.DataPresenter.UnboundField ZnChanCfgChannelsTalkgroup_A9276_Col;

		// Token: 0x04000157 RID: 343
		internal global::Infragistics.Windows.DataPresenter.UnboundField ZnChanCfgChannelsConventionalChannelReference_A20560_Col;

		// Token: 0x04000158 RID: 344
		internal global::Infragistics.Windows.DataPresenter.UnboundField ZnChanCfgChannelsRadioProfileCompositeItemNameID_A20192_Col;

		// Token: 0x04000159 RID: 345
		internal global::Infragistics.Windows.DataPresenter.UnboundField ChannelAnnouncementID_A20175_Col;

		// Token: 0x0400015A RID: 346
		internal global::Infragistics.Windows.DataPresenter.UnboundField VCChannelAnnouncement_A20176_Col;

		// Token: 0x0400015B RID: 347
		internal global::Infragistics.Windows.DataPresenter.UnboundField ZnChanCfgTopLightColor_A43173_Col;

		// Token: 0x0400015C RID: 348
		internal global::Infragistics.Windows.DataPresenter.UnboundField ZnChanCfgChannelsChannelColorBacklightSelection_43749_Col;

		// Token: 0x0400015D RID: 349
		internal global::Infragistics.Windows.DataPresenter.UnboundField ChannelsActiveChannel_Col;

		// Token: 0x0400015E RID: 350
		internal global::Infragistics.Windows.DataPresenter.UnboundField ZnChanCfgChannelsFiregroundSectorID_A33630_Col;

		// Token: 0x0400015F RID: 351
		internal global::Infragistics.Windows.DataPresenter.UnboundField ZnChanCfgChannelsFallbackZone_Col;

		// Token: 0x04000160 RID: 352
		internal global::Infragistics.Windows.DataPresenter.UnboundField ZnChanCfgChannelsFallbackChannel_Col;

		// Token: 0x04000161 RID: 353
		internal global::Infragistics.Windows.DataPresenter.UnboundField ZnChanCfgChannelsWiFi_Col;

		// Token: 0x04000162 RID: 354
		internal global::AcpUI.AcpGroupBox ExpanderZoneChannelAssignmentChannelAssignmentListSRecView;

		// Token: 0x04000163 RID: 355
		internal global::System.Windows.Controls.Grid gridExpanderZoneChannelAssignmentChannelAssignmentListSRecView;

		// Token: 0x04000164 RID: 356
		internal global::AcpUI.AcpTextBox ZnChanCfgChannelsChannelName_A7659;

		// Token: 0x04000165 RID: 357
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnZnChanCfgChannelsChannelName_A7659;

		// Token: 0x04000166 RID: 358
		internal global::AcpUI.AcpLabel LblZnChanCfgChannelsChannelName_A7659;

		// Token: 0x04000167 RID: 359
		internal global::AcpUI.AcpCopyButton CpyBtnZnChanCfgChannelsChannelName_A7659;

		// Token: 0x04000168 RID: 360
		internal global::AcpUI.AcpLabel ZnChanCfgChannelsChannelName_A7659Comp;

		// Token: 0x04000169 RID: 361
		internal global::AcpUI.AcpTextBox ZnChanCfgChannelsTopDisplayChannel_A19774;

		// Token: 0x0400016A RID: 362
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnZnChanCfgChannelsTopDisplayChannel_A19774;

		// Token: 0x0400016B RID: 363
		internal global::AcpUI.AcpLabel LblZnChanCfgChannelsTopDisplayChannel_A19774;

		// Token: 0x0400016C RID: 364
		internal global::AcpUI.AcpRtdButton RTDBtnZnChanCfgChannelsTopDisplayChannel_A19774;

		// Token: 0x0400016D RID: 365
		internal global::AcpUI.AcpCopyButton CpyBtnZnChanCfgChannelsTopDisplayChannel_A19774;

		// Token: 0x0400016E RID: 366
		internal global::AcpUI.AcpLabel ZnChanCfgChannelsTopDisplayChannel_A19774Comp;

		// Token: 0x0400016F RID: 367
		internal global::AcpUI.AcpComboBox ZnChanCfgChannelsChannelType_A22241;

		// Token: 0x04000170 RID: 368
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnZnChanCfgChannelsChannelType_A22241;

		// Token: 0x04000171 RID: 369
		internal global::AcpUI.AcpLabel LblZnChanCfgChannelsChannelType_A22241;

		// Token: 0x04000172 RID: 370
		internal global::AcpUI.AcpRtdButton RTDBtnZnChanCfgChannelsChannelType_A22241;

		// Token: 0x04000173 RID: 371
		internal global::AcpUI.AcpCopyButton CpyBtnZnChanCfgChannelsChannelType_A22241;

		// Token: 0x04000174 RID: 372
		internal global::AcpUI.AcpLabel ZnChanCfgChannelsChannelType_A22241Comp;

		// Token: 0x04000175 RID: 373
		internal global::AcpUI.AcpComboBox ZnChanCfgChannelsPersonality_A8698;

		// Token: 0x04000176 RID: 374
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnZnChanCfgChannelsPersonality_A8698;

		// Token: 0x04000177 RID: 375
		internal global::AcpUI.AcpLabel LblZnChanCfgChannelsPersonality_A8698;

		// Token: 0x04000178 RID: 376
		internal global::AcpUI.AcpRtdButton RTDBtnZnChanCfgChannelsPersonality_A8698;

		// Token: 0x04000179 RID: 377
		internal global::AcpUI.AcpCopyButton CpyBtnZnChanCfgChannelsPersonality_A8698;

		// Token: 0x0400017A RID: 378
		internal global::AcpUI.AcpLabel ZnChanCfgChannelsPersonality_A8698Comp;

		// Token: 0x0400017B RID: 379
		internal global::AcpUI.AcpComboBox ZnChanCfgChannelsTalkgroup_A9276;

		// Token: 0x0400017C RID: 380
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnZnChanCfgChannelsTalkgroup_A9276;

		// Token: 0x0400017D RID: 381
		internal global::AcpUI.AcpLabel LblZnChanCfgChannelsTalkgroup_A9276;

		// Token: 0x0400017E RID: 382
		internal global::AcpUI.AcpRtdButton RTDBtnZnChanCfgChannelsTalkgroup_A9276;

		// Token: 0x0400017F RID: 383
		internal global::AcpUI.AcpCopyButton CpyBtnZnChanCfgChannelsTalkgroup_A9276;

		// Token: 0x04000180 RID: 384
		internal global::AcpUI.AcpLabel ZnChanCfgChannelsTalkgroup_A9276Comp;

		// Token: 0x04000181 RID: 385
		internal global::AcpUI.AcpComboBox ZnChanCfgChannelsConventionalChannelReference_A20560;

		// Token: 0x04000182 RID: 386
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnZnChanCfgChannelsConventionalChannelReference_A20560;

		// Token: 0x04000183 RID: 387
		internal global::AcpUI.AcpLabel LblZnChanCfgChannelsConventionalChannelReference_A20560;

		// Token: 0x04000184 RID: 388
		internal global::AcpUI.AcpRtdButton RTDBtnZnChanCfgChannelsConventionalChannelReference_A20560;

		// Token: 0x04000185 RID: 389
		internal global::AcpUI.AcpCopyButton CpyBtnZnChanCfgChannelsConventionalChannelReference_A20560;

		// Token: 0x04000186 RID: 390
		internal global::AcpUI.AcpLabel ZnChanCfgChannelsConventionalChannelReference_A20560Comp;

		// Token: 0x04000187 RID: 391
		internal global::AcpUI.AcpComboBox ZnChanCfgChannelsRadioProfileCompositeItemNameID_A20192;

		// Token: 0x04000188 RID: 392
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnZnChanCfgChannelsRadioProfileCompositeItemNameID_A20192;

		// Token: 0x04000189 RID: 393
		internal global::AcpUI.AcpLabel LblZnChanCfgChannelsRadioProfileCompositeItemNameID_A20192;

		// Token: 0x0400018A RID: 394
		internal global::AcpUI.AcpRtdButton RTDBtnZnChanCfgChannelsRadioProfileCompositeItemNameID_A20192;

		// Token: 0x0400018B RID: 395
		internal global::AcpUI.AcpCopyButton CpyBtnZnChanCfgChannelsRadioProfileCompositeItemNameID_A20192;

		// Token: 0x0400018C RID: 396
		internal global::AcpUI.AcpLabel ZnChanCfgChannelsRadioProfileCompositeItemNameID_A20192Comp;

		// Token: 0x0400018D RID: 397
		internal global::AcpUI.AcpComboBox ChannelAnnouncementID_A20175;

		// Token: 0x0400018E RID: 398
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnChannelAnnouncementID_A20175;

		// Token: 0x0400018F RID: 399
		internal global::AcpUI.AcpLabel LblChannelAnnouncementID_A20175;

		// Token: 0x04000190 RID: 400
		internal global::AcpUI.AcpRtdButton RTDBtnChannelAnnouncementID_A20175;

		// Token: 0x04000191 RID: 401
		internal global::AcpUI.AcpCopyButton CpyBtnChannelAnnouncementID_A20175;

		// Token: 0x04000192 RID: 402
		internal global::AcpUI.AcpLabel ChannelAnnouncementID_A20175Comp;

		// Token: 0x04000193 RID: 403
		internal global::AcpUI.AcpComboBox ZnChanCfgTopLightColor_A43173;

		// Token: 0x04000194 RID: 404
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnZnChanCfgTopLightColor_A43173;

		// Token: 0x04000195 RID: 405
		internal global::AcpUI.AcpLabel LblZnChanCfgTopLightColor_A43173;

		// Token: 0x04000196 RID: 406
		internal global::AcpUI.AcpRtdButton RTDBtnZnChanCfgTopLightColor_A43173;

		// Token: 0x04000197 RID: 407
		internal global::AcpUI.AcpCopyButton CpyBtnZnChanCfgTopLightColor_A43173;

		// Token: 0x04000198 RID: 408
		internal global::AcpUI.AcpLabel ZnChanCfgTopLightColor_A43173Comp;

		// Token: 0x04000199 RID: 409
		internal global::AcpUI.AcpComboBox ZnChanCfgChannelsChannelColorBacklightSelection_43749;

		// Token: 0x0400019A RID: 410
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnZnChanCfgChannelsChannelColorBacklightSelection_43749;

		// Token: 0x0400019B RID: 411
		internal global::AcpUI.AcpLabel LblZnChanCfgChannelsChannelColorBacklightSelection_43749;

		// Token: 0x0400019C RID: 412
		internal global::AcpUI.AcpRtdButton RTDBtnZnChanCfgChannelsChannelColorBacklightSelection_43749;

		// Token: 0x0400019D RID: 413
		internal global::AcpUI.AcpCopyButton CpyBtnZnChanCfgChannelsChannelColorBacklightSelection_43749;

		// Token: 0x0400019E RID: 414
		internal global::AcpUI.AcpLabel ZnChanCfgChannelsChannelColorBacklightSelection_43749Comp;

		// Token: 0x0400019F RID: 415
		internal global::AcpUI.AcpCheckBox ChannelsActiveChannel;

		// Token: 0x040001A0 RID: 416
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnChannelsActiveChannel;

		// Token: 0x040001A1 RID: 417
		internal global::AcpUI.AcpLabel LblChannelsActiveChannel;

		// Token: 0x040001A2 RID: 418
		internal global::AcpUI.AcpRtdButton RTDBtnChannelsActiveChannel;

		// Token: 0x040001A3 RID: 419
		internal global::AcpUI.AcpCopyButton CpyBtnChannelsActiveChannel;

		// Token: 0x040001A4 RID: 420
		internal global::AcpUI.AcpCheckBox ChannelsActiveChannelComp;

		// Token: 0x040001A5 RID: 421
		internal global::AcpUI.AcpTextBox ZnChanCfgChannelsFiregroundSectorID_A33630;

		// Token: 0x040001A6 RID: 422
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnZnChanCfgChannelsFiregroundSectorID_A33630;

		// Token: 0x040001A7 RID: 423
		internal global::AcpUI.AcpLabel LblZnChanCfgChannelsFiregroundSectorID_A33630;

		// Token: 0x040001A8 RID: 424
		internal global::AcpUI.AcpRtdButton RTDBtnZnChanCfgChannelsFiregroundSectorID_A33630;

		// Token: 0x040001A9 RID: 425
		internal global::AcpUI.AcpCopyButton CpyBtnZnChanCfgChannelsFiregroundSectorID_A33630;

		// Token: 0x040001AA RID: 426
		internal global::AcpUI.AcpLabel ZnChanCfgChannelsFiregroundSectorID_A33630Comp;

		// Token: 0x040001AB RID: 427
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnVCChannelAnnouncement_A20176;

		// Token: 0x040001AC RID: 428
		internal global::AcpUI.AcpLabel LblVCChannelAnnouncement_A20176;

		// Token: 0x040001AD RID: 429
		internal global::AcpUI.AcpTextBox VCChannelAnnouncement_A20176;

		// Token: 0x040001AE RID: 430
		internal global::AcpUITTS.AcpTTSButton TTSBtnVCChannelAnnouncement_A20176;

		// Token: 0x040001AF RID: 431
		internal global::AcpUI.AcpRtdButton RTDBtnVCChannelAnnouncement_A20176;

		// Token: 0x040001B0 RID: 432
		internal global::AcpUI.AcpCopyButton CpyBtnVCChannelAnnouncement_A20176;

		// Token: 0x040001B1 RID: 433
		internal global::AcpUI.AcpLabel VCChannelAnnouncement_A20176Comp;

		// Token: 0x040001B2 RID: 434
		internal global::AcpUI.AcpComboBox ZnChanCfgChannelsFallbackZone;

		// Token: 0x040001B3 RID: 435
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnZnChanCfgChannelsFallbackZone;

		// Token: 0x040001B4 RID: 436
		internal global::AcpUI.AcpLabel LblZnChanCfgChannelsFallbackZone;

		// Token: 0x040001B5 RID: 437
		internal global::AcpUI.AcpRtdButton RTDBtnZnChanCfgChannelsFallbackZone;

		// Token: 0x040001B6 RID: 438
		internal global::AcpUI.AcpCopyButton CpyBtnZnChanCfgChannelsFallbackZone;

		// Token: 0x040001B7 RID: 439
		internal global::AcpUI.AcpLabel ZnChanCfgChannelsFallbackZoneComp;

		// Token: 0x040001B8 RID: 440
		internal global::AcpUI.AcpComboBox ZnChanCfgChannelsFallbackChannel;

		// Token: 0x040001B9 RID: 441
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnZnChanCfgChannelsFallbackChannel;

		// Token: 0x040001BA RID: 442
		internal global::AcpUI.AcpLabel LblZnChanCfgChannelsFallbackChannel;

		// Token: 0x040001BB RID: 443
		internal global::AcpUI.AcpRtdButton RTDBtnZnChanCfgChannelsFallbackChannel;

		// Token: 0x040001BC RID: 444
		internal global::AcpUI.AcpCopyButton CpyBtnZnChanCfgChannelsFallbackChannel;

		// Token: 0x040001BD RID: 445
		internal global::AcpUI.AcpLabel ZnChanCfgChannelsFallbackChannelComp;

		// Token: 0x040001BE RID: 446
		internal global::AcpUI.AcpComboBox ZnChanCfgChannelsWiFi;

		// Token: 0x040001BF RID: 447
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnZnChanCfgChannelsWiFi;

		// Token: 0x040001C0 RID: 448
		internal global::AcpUI.AcpLabel LblZnChanCfgChannelsWiFi;

		// Token: 0x040001C1 RID: 449
		internal global::AcpUI.AcpRtdButton RTDBtnZnChanCfgChannelsWiFi;

		// Token: 0x040001C2 RID: 450
		internal global::AcpUI.AcpCopyButton CpyBtnZnChanCfgChannelsWiFi;

		// Token: 0x040001C3 RID: 451
		internal global::AcpUI.AcpLabel ZnChanCfgChannelsWiFiComp;

		// Token: 0x040001C4 RID: 452
		internal global::AcpUI.AcpExpander ExpanderZoneChannelAssignmentLabtool;

		// Token: 0x040001C5 RID: 453
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderZoneChannelAssignmentLabtoolPseudo0;

		// Token: 0x040001C6 RID: 454
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnZnChanCfgLabtoolLastSelectedChnl_A41075;

		// Token: 0x040001C7 RID: 455
		internal global::AcpUI.AcpLabel LblZnChanCfgLabtoolLastSelectedChnl_A41075;

		// Token: 0x040001C8 RID: 456
		internal global::AcpUI.AcpComboBox ZnChanCfgLabtoolLastSelectedChnl_A41075;

		// Token: 0x040001C9 RID: 457
		internal global::AcpUI.AcpRtdButton RTDBtnZnChanCfgLabtoolLastSelectedChnl_A41075;

		// Token: 0x040001CA RID: 458
		internal global::AcpUI.AcpCopyButton CpyBtnZnChanCfgLabtoolLastSelectedChnl_A41075;

		// Token: 0x040001CB RID: 459
		internal global::AcpUI.AcpLabel ZnChanCfgLabtoolLastSelectedChnl_A41075Comp;

		// Token: 0x040001CC RID: 460
		private bool b;
	}
}
