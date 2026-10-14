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

namespace Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu
{
	// Token: 0x02000289 RID: 649
	public class PageDisplayAndMenu : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x060070E1 RID: 28897 RVA: 0x00646A68 File Offset: 0x00644C68
		public PageDisplayAndMenu()
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

		// Token: 0x060070E2 RID: 28898 RVA: 0x00646AA0 File Offset: 0x00644CA0
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1797259264;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)1038483464;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					object obj;
					global::AcpUI.AcpExpander acpExpander;
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						goto IL_259;
					case 1:
						if (obj != null)
						{
							num = (short)2128347142;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_259;
					case 2:
						try
						{
							num = (short)1286995973;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_192;
								case 1:
									if (acpExpander != null)
									{
										num = (short)208273410;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 2:
									base.Expanders.Add(acpExpander);
									num = (short)302841860;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									if (!enumerator.MoveNext())
									{
										num = (short)942407686;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
									num = (short)990576641;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_D3;
									}
									continue;
								case 6:
									num = (short)932184064;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_118:
								num = (short)2013724675;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_D3:
								goto IL_118;
							}
							IL_192:
							goto IL_2EC;
						}
						finally
						{
							global::System.IDisposable disposable;
							switch (0)
							{
							case 0:
								break;
							default:
								for (;;)
								{
									IL_1A1:
									switch (num2)
									{
									case 0:
										goto IL_256;
									case 1:
										if (disposable != null)
										{
											num = (short)170590210;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_258;
									case 2:
									{
										disposable.Dispose();
										num = (short)1459742939;
										short num3 = num;
										num = (short)512288987;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_1BB;
										default:
											num = (short)324468736;
											if (num != 0)
											{
											}
											num = (short)390004736;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									}
									goto IL_1B4;
								}
								IL_256:
								IL_258:
								goto EndFinally_9;
							}
							IL_1B4:
							disposable = (enumerator as global::System.IDisposable);
							IL_1BB:
							num = (short)1646657537;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_1A1;
							EndFinally_9:;
						}
						goto IL_259;
						IL_2EC:
						base.OnLoaded(sender, e);
						this.a = true;
						num = (short)412155908;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_3C3;
					case 4:
						goto IL_313;
					case 5:
						num = (short)1849425921;
						if (num != 0)
						{
						}
						if (obj != null)
						{
							num = (short)677773321;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3C3;
					case 6:
					{
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderDisplayAndMenuBacklightColors.MyDataPresenter = this.ExpanderDisplayAndMenuBacklightColors;
						num = (short)679608320;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						obj = null;
						obj = this.RecNavToolbarExpanderDisplayAndMenuIDDisplayTable.MyRecordsetDataSource;
						num = (short)245956613;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						switch (0)
						{
						case 0:
							goto IL_6B;
						}
						continue;
					case 9:
					{
						global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderDisplayAndMenuIDDisplayTable.MyDataPresenter = this.ExpanderDisplayAndMenuIDDisplayTable;
						num = (short)1703215104;
						short num4 = num;
						num = (short)770113539;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_6B:
					if (!this.a)
					{
						num = (short)214695943;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_259:
					acpExpander = null;
					enumerator = this.MyStackPanel.Children.GetEnumerator();
					num = (short)305201154;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3C3:
					obj = this.RecNavToolbarExpanderDisplayAndMenuBacklightColors.MyRecordsetDataSource;
					num = (short)1848967169;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_313:
				this.MyStackPanel.Children[0].Focus();
				return;
			}
		}

		// Token: 0x060070E3 RID: 28899 RVA: 0x00646EEC File Offset: 0x006450EC
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			int num;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						return;
					case 1:
						if (this.a)
						{
							num2 = (short)120127490;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 2:
					{
						base.OnUnloaded(sender, e);
						this.a = false;
						num2 = (short)1034717931;
						short num3 = num2;
						num2 = (short)1882491627;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_73;
						default:
							num2 = (short)345112576;
							if (num2 != 0)
							{
							}
							num2 = (short)665255936;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_1C;
				}
				return;
			}
			IL_1C:
			num2 = (short)2011234305;
			if (num2 != 0)
			{
			}
			this.RecNavToolbarExpanderDisplayAndMenuIDDisplayTable.DataContext = null;
			this.RecNavToolbarExpanderDisplayAndMenuBacklightColors.DataContext = null;
			this.RecNavToolbarExpanderDisplayAndMenuIDDisplayTable.MyDataPresenter = null;
			this.RecNavToolbarExpanderDisplayAndMenuBacklightColors.MyDataPresenter = null;
			IL_73:
			num2 = (short)372310016;
			short num4 = num2;
			num2 = (short)680329217;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060070E4 RID: 28900 RVA: 0x00647044 File Offset: 0x00645244
		public override void SetDataContext()
		{
			short num = (short)1390477334;
			int num2 = (int)((global::System.IntPtr)num);
			object feature;
			for (;;)
			{
				num = (short)1391656960;
				short num3 = num;
				switch (num2)
				{
				case 0:
					goto IL_16A;
				case 1:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10215] != null)
					{
						num = (short)1408696331;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10215].EmbeddedRecset != null)
					{
						num = (short)152371204;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
					num = (short)1089798145;
					if (num != 0)
					{
					}
					if (feature != null)
					{
						num = (short)2091384852;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					goto IL_1F9;
				case 5:
					goto IL_3C3;
				case 6:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10021].EmbeddedRecset != null)
					{
						num = (short)101187607;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3C3;
				case 7:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)1444937749;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 8:
					num = (short)1565392911;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2010);
					num = (short)1605632000;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (feature != null)
					{
						num = (short)1669070867;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3C3;
				case 11:
					num = (short)542572546;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)665649166;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderDisplayAndMenuIDDisplayTable).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderDisplayAndMenuBacklightColors).MySecondaryRecordsetDataSource = null;
					num = (short)1117388816;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
				{
					num = (short)1925378190;
					short num4 = num;
					num = (short)63238286;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_4AE;
					default:
						num = (short)1103757312;
						if (num != 0)
						{
						}
						goto IL_16A;
					}
					break;
				}
				case 14:
					feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2010);
					num = (short)1956904970;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					goto IL_4AE;
				case 16:
					return;
				case 17:
					num = (short)1154482182;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)37879816;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3C3;
				case 19:
					num = (short)282853394;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					num = (short)201785351;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					num = (short)1993998337;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					switch (0)
					{
					case 0:
						goto IL_AC;
					}
					continue;
				case 23:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderDisplayAndMenuIDDisplayTable).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10021].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderDisplayAndMenuIDDisplayTable).SyncDataSources();
					num = (short)803405829;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_AC:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)1603534857;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2010);
				num = (short)164888589;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_16A:
				num = (short)1384579084;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3C3:
				num = (short)1536294915;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4AE:
				if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10021] == null)
				{
					goto IL_3C3;
				}
				num = (short)1748762641;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1F9:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderDisplayAndMenuBacklightColors).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10215].EmbeddedRecset;
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderDisplayAndMenuBacklightColors).SyncDataSources();
		}

		// Token: 0x060070E5 RID: 28901 RVA: 0x00647538 File Offset: 0x00645738
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 11;
			short num = (short)2061107200;
			switch (num)
			{
			default:
			{
				num = (short)1339162639;
				int num2 = (int)((global::System.IntPtr)num);
				object myRecordsetDataSource;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1398734864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)137166858;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)876281860;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						IL_2DD:
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						myRecordsetDataSource = this.RecNavToolbarExpanderDisplayAndMenuBacklightColors.MyRecordsetDataSource;
						num = (short)80805889;
						if (num != 0)
						{
						}
						num = (short)26607630;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)910229513;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)1451098124;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						object myRecordsetDataSource2;
						if (myRecordsetDataSource2 != null)
						{
							num = (short)1833107456;
							short num3 = num;
							num = (short)639500296;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_133;
					}
					case 6:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("黋ꯍ돏鳑뗓ꃕ賗뗙돛닝苟菡難ꏥ郧髩跫胭铯韱蛳답釷觹賻鋽懿笁䔃栅氇䜉椋怍攏們甓甕猗瘙甛礝䠟嘡朣䤥䐧䔩師崭", a_))
						{
							num = (short)1467809792;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 7:
						goto IL_12E;
					case 8:
					{
						object myRecordsetDataSource2;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource2);
						global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.IDDisplayTableInner item = (global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.IDDisplayTableInner)collectionView.CurrentItem;
						collectionView.MoveCurrentTo(item);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)2034237451;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource2 = this.RecNavToolbarExpanderDisplayAndMenuIDDisplayTable.MyRecordsetDataSource;
						num = (short)838205445;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("黋ꯍ돏鳑뗓ꃕ賗뗙돛닝苟菡難ꏥ郧髩跫胭铯韱蛳답釷觹賻鋽懿笁䔃栅氇䜉椋怍攏嬑倓刕焗椙氛爝䄟嬡瀣䜥䨧䘩䤫", a_))
						{
							num = (short)1218838530;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_133;
					case 11:
						goto IL_133;
					case 12:
						goto IL_133;
					case 13:
						return;
					case 14:
						if (myRecordsetDataSource != null)
						{
							num = (short)2026897415;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 15:
						switch (0)
						{
						case 0:
							goto IL_92;
						}
						continue;
					case 16:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)595394563;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)1774321677;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_92:
					if (A_0 is global::AcpUI.AcpRecNavToolbar)
					{
						num = (short)1319763969;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_133:
					num = (short)149604829;
					short num4 = num;
					num = (short)1150077405;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2DD;
					default:
						num = (short)1633746944;
						if (num != 0)
						{
						}
						num = (short)762576902;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_12E:
				global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
				global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.BacklightColorsInner item2 = (global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.BacklightColorsInner)collectionView2.CurrentItem;
				collectionView2.MoveCurrentTo(item2);
				((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
				return;
			}
			}
		}

		// Token: 0x060070E6 RID: 28902 RVA: 0x00647940 File Offset: 0x00645B40
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)2106480123;
			short num2 = num;
			num = (short)776754683;
			switch (num2 == num)
			{
			}
			num = (short)837353472;
			short num3 = num;
			num = (short)765394944;
			if (num != 0)
			{
			}
			num = (short)1605238785;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x060070E7 RID: 28903 RVA: 0x006479F4 File Offset: 0x00645BF4
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)2010899843;
			short num2 = num;
			num = (short)1524950403;
			switch (num2 == num)
			{
			}
			num = (short)1517813760;
			short num3 = num;
			num = (short)1263599617;
			if (num != 0)
			{
			}
			num = (short)2048327680;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x060070E8 RID: 28904 RVA: 0x00647AA0 File Offset: 0x00645CA0
		internal void OnExpanderDisplayAndMenuIDDisplayTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			int num;
			short num2;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.IDDisplayTableInner item;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_151;
					case 1:
					{
						num2 = (short)2063859712;
						short num3 = num2;
						if (myRecordsetDataSource != null)
						{
							num2 = (short)35061762;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_153;
					}
					case 2:
					{
						((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
						this.RecNavToolbarExpanderDisplayAndMenuIDDisplayTable.SyncDataSources();
						num2 = (short)805737769;
						short num4 = num2;
						num2 = (short)646747433;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4D;
						default:
							num2 = (short)1127677953;
							if (num2 != 0)
							{
							}
							num2 = (short)927006720;
							if (num2 != 0)
							{
							}
							num2 = (short)245039104;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_1C;
				}
				IL_151:
				IL_153:
				this.RecNavToolbarExpanderDisplayAndMenuIDDisplayTable.TableMode = false;
				return;
			}
			IL_1C:
			item = (global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.IDDisplayTableInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderDisplayAndMenuIDDisplayTable.MyRecordsetDataSource;
			IL_4D:
			num2 = (short)641073153;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060070E9 RID: 28905 RVA: 0x00647C0C File Offset: 0x00645E0C
		internal void OnExpanderDisplayAndMenuBacklightColorsClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			int num;
			short num2;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.BacklightColorsInner item;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_150;
					case 1:
					{
						num2 = (short)1475674112;
						short num3 = num2;
						if (myRecordsetDataSource != null)
						{
							num2 = (short)2063400962;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_152;
					}
					case 2:
					{
						((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
						this.RecNavToolbarExpanderDisplayAndMenuBacklightColors.SyncDataSources();
						num2 = (short)374872411;
						short num4 = num2;
						num2 = (short)1614616923;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4D;
						default:
							num2 = (short)1969553409;
							if (num2 != 0)
							{
							}
							num2 = (short)717357056;
							if (num2 != 0)
							{
							}
							num2 = (short)2090860544;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_1C;
				}
				IL_150:
				IL_152:
				this.RecNavToolbarExpanderDisplayAndMenuBacklightColors.TableMode = false;
				return;
			}
			IL_1C:
			item = (global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.BacklightColorsInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderDisplayAndMenuBacklightColors.MyRecordsetDataSource;
			IL_4D:
			num2 = (short)500957185;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060070EA RID: 28906 RVA: 0x00647D78 File Offset: 0x00645F78
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 2;
			if (this.b)
			{
				short num = (short)1387791801;
				short num2 = num;
				num = (short)464782777;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1717370881;
					if (num != 0)
					{
					}
					num = (short)2014969856;
					if (num != 0)
					{
					}
					num = (short)204668928;
					short num3 = num;
					return;
				}
				}
			}
			this.b = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("蓄ꯆꗈ跊꣌껎ꗐꛒ꟔닖꫘뻜냞賠鏢諤触賨藪駬샮菰鋲釴黶雸\udefa쿼쿾搀焂戄栆月搊怌明爐怒〔┖⤘砚爜焞䜠䨢䈤刦嬨䨪夬䘮帰崲ᨴ匶倸䠺䴼匾⁀㩂恄畆祈⩊⍌⭎瑐慒敔㩖㱘㕚⡜灞ՠ੢ᙤᝦը੪ᑬ๮ὰᝲᡴቶ᝸๺卼ݾ", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060070EB RID: 28907 RVA: 0x00647E5C File Offset: 0x0064605C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1873346561;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)103940098;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 2:
					goto IL_B98;
				}
				IL_30:
				switch (connectionId)
				{
				case 1:
					goto IL_B4F;
				case 2:
				case 3:
				case 4:
				case 5:
				case 6:
				case 7:
				case 8:
					goto IL_201D;
				case 9:
					goto IL_652;
				case 10:
					goto IL_12D6;
				case 11:
					goto IL_1DBB;
				case 12:
					goto IL_1BFF;
				case 13:
					goto IL_807;
				case 14:
					goto IL_190B;
				case 15:
					goto IL_155C;
				case 16:
					goto IL_795;
				case 17:
					goto IL_A95;
				case 18:
					goto IL_1B8B;
				case 19:
					goto IL_1616;
				case 20:
					goto IL_16ED;
				case 21:
					goto IL_DD7;
				case 22:
					goto IL_1C54;
				case 23:
					goto IL_10F0;
				case 24:
					goto IL_144A;
				case 25:
					goto IL_EFD;
				case 26:
					goto IL_1C9F;
				case 27:
					goto IL_1EE7;
				case 28:
					goto IL_1D1B;
				case 29:
					goto IL_15CB;
				case 30:
					goto IL_1752;
				case 31:
					goto IL_876;
				case 32:
					goto IL_E6A;
				case 33:
					goto IL_1307;
				case 34:
					goto IL_F0A;
				case 35:
					goto IL_1DDF;
				case 36:
					goto IL_1CC3;
				case 37:
					goto IL_1117;
				case 38:
					goto IL_1FAE;
				case 39:
					goto IL_11D4;
				case 40:
					goto IL_A7B;
				case 41:
					goto IL_18FE;
				case 42:
					goto IL_1131;
				case 43:
					goto IL_1AA0;
				case 44:
					goto IL_1F8A;
				case 45:
					goto IL_159A;
				case 46:
					goto IL_135F;
				case 47:
					goto IL_10B2;
				case 48:
					goto IL_F17;
				case 49:
					goto IL_AA2;
				case 50:
					goto IL_5D3;
				case 51:
					goto IL_13A0;
				case 52:
					goto IL_A88;
				case 53:
					goto IL_C23;
				case 54:
					goto IL_929;
				case 55:
					goto IL_10FD;
				case 56:
					goto IL_85C;
				case 57:
					goto IL_1B36;
				case 58:
					goto IL_164A;
				case 59:
					goto IL_683;
				case 60:
					goto IL_7FA;
				case 61:
					goto IL_883;
				case 62:
					goto IL_1F70;
				case 63:
					goto IL_13C4;
				case 64:
					goto IL_1196;
				case 65:
					goto IL_12A5;
				case 66:
					goto IL_8F5;
				case 67:
					goto IL_1D59;
				case 68:
					goto IL_1E8F;
				case 69:
					goto IL_1878;
				case 70:
					goto IL_65F;
				case 71:
					goto IL_110A;
				case 72:
					goto IL_1EDA;
				case 73:
					goto IL_1A86;
				case 74:
					goto IL_1C47;
				case 75:
					goto IL_1E1D;
				case 76:
					goto IL_5A2;
				case 77:
					goto IL_1A62;
				case 78:
					goto IL_719;
				case 79:
					goto IL_8B4;
				case 80:
					goto IL_19F3;
				case 81:
					goto IL_690;
				case 82:
					goto IL_13F5;
				case 83:
					goto IL_189C;
				case 84:
					goto IL_A6E;
				case 85:
					goto IL_61E;
				case 86:
					goto IL_84F;
				case 87:
					goto IL_16C6;
				case 88:
					goto IL_1274;
				case 89:
					goto IL_764;
				case 90:
					goto IL_757;
				case 91:
					goto IL_F93;
				case 92:
					goto IL_1A00;
				case 93:
					goto IL_1CD0;
				case 94:
					goto IL_108E;
				case 95:
					goto IL_19A8;
				case 96:
					goto IL_1002;
				case 97:
					goto IL_DFB;
				case 98:
					goto IL_D10;
				case 99:
					goto IL_175F;
				case 100:
					goto IL_1A3E;
				case 101:
					goto IL_733;
				case 102:
					goto IL_116F;
				case 103:
					goto IL_172B;
				case 104:
					goto IL_CB8;
				case 105:
					goto IL_158D;
				case 106:
					goto IL_1960;
				case 107:
					goto IL_1BDB;
				case 108:
					goto IL_1124;
				case 109:
					goto IL_70C;
				case 110:
					goto IL_1580;
				case 111:
					goto IL_1D4C;
				case 112:
					goto IL_1C23;
				case 113:
					goto IL_7AF;
				case 114:
					goto IL_1630;
				case 115:
					goto IL_90F;
				case 116:
					goto IL_C09;
				case 117:
					goto IL_B28;
				case 118:
					goto IL_176C;
				case 119:
					goto IL_AAF;
				case 120:
					goto IL_1036;
				case 121:
					goto IL_151E;
				case 122:
					goto IL_7E0;
				case 123:
					goto IL_D1D;
				case 124:
					goto IL_1538;
				case 125:
					goto IL_E9B;
				case 126:
					goto IL_1E10;
				case 127:
					goto IL_1386;
				case 128:
					goto IL_98B;
				case 129:
					goto IL_1C92;
				case 130:
					goto IL_FF5;
				case 131:
					goto IL_1CDD;
				case 132:
					goto IL_1CEA;
				case 133:
					goto IL_167B;
				case 134:
					goto IL_EBF;
				case 135:
					goto IL_19CC;
				case 136:
					goto IL_6F2;
				case 137:
					goto IL_6E5;
				case 138:
					goto IL_1B67;
				case 139:
					goto IL_BE5;
				case 140:
					goto IL_97E;
				case 141:
					goto IL_9C1;
				case 142:
					goto IL_1B98;
				case 143:
					goto IL_1ABA;
				case 144:
					goto IL_A23;
				case 145:
					goto IL_1043;
				case 146:
					goto IL_166E;
				case 147:
					goto IL_1F0B;
				case 148:
					goto IL_186B;
				case 149:
					goto IL_E5D;
				case 150:
					goto IL_BC1;
				case 151:
					goto IL_15F2;
				case 152:
					goto IL_1457;
				case 153:
					goto IL_1F18;
				case 154:
					goto IL_645;
				case 155:
					goto IL_C16;
				case 156:
					goto IL_9FF;
				case 157:
					goto IL_18DA;
				case 158:
					goto IL_16AC;
				case 159:
					goto IL_7A2;
				case 160:
					goto IL_1189;
				case 161:
					goto IL_1236;
				case 162:
					goto IL_ED9;
				case 163:
					goto IL_1471;
				case 164:
					goto IL_1495;
				case 165:
					goto IL_1F63;
				case 166:
					goto IL_FA0;
				case 167:
					goto IL_171E;
				case 168:
					goto IL_10BF;
				case 169:
					goto IL_1AF8;
				case 170:
					goto IL_1338;
				case 171:
					goto IL_B35;
				case 172:
					goto IL_788;
				case 173:
					goto IL_1B29;
				case 174:
					goto IL_193C;
				case 175:
					goto IL_1250;
				case 176:
					goto IL_1711;
				case 177:
					goto IL_CF6;
				case 178:
					goto IL_F79;
				case 179:
					goto IL_1745;
				case 180:
					goto IL_E39;
				case 181:
					goto IL_9CE;
				case 182:
					goto IL_19D9;
				case 183:
					goto IL_1790;
				case 184:
					goto IL_183A;
				case 185:
					goto IL_91C;
				case 186:
					goto IL_B9D;
				case 187:
					goto IL_1AC7;
				case 188:
					goto IL_1081;
				case 189:
					goto IL_1F7D;
				case 190:
					goto IL_A61;
				case 191:
					goto IL_1229;
				case 192:
					goto IL_1419;
				case 193:
					goto IL_95A;
				case 194:
					goto IL_595;
				case 195:
					goto IL_1E68;
				case 196:
					goto IL_A47;
				case 197:
					goto IL_1E82;
				case 198:
					goto IL_1205;
				case 199:
					goto IL_1847;
				case 200:
					goto IL_1379;
				case 201:
					goto IL_611;
				case 202:
					goto IL_D75;
				case 203:
					goto IL_117C;
				case 204:
					goto IL_890;
				case 205:
					goto IL_902;
				case 206:
					goto IL_1FDF;
				case 207:
					goto IL_D37;
				case 208:
					goto IL_C3D;
				case 209:
					goto IL_CAB;
				case 210:
					goto IL_1D0E;
				case 211:
					goto IL_1B1C;
				case 212:
					goto IL_15BE;
				case 213:
					goto IL_B04;
				case 214:
					goto IL_17E5;
				case 215:
					goto IL_1E9C;
				case 216:
					goto IL_19E6;
				case 217:
					goto IL_1A31;
				case 218:
					goto IL_6FF;
				case 219:
					goto IL_1D8A;
				case 220:
					goto IL_F24;
				case 221:
					goto IL_D82;
				case 222:
					goto IL_1393;
				case 223:
					goto IL_AF7;
				case 224:
					goto IL_100F;
				case 225:
					goto IL_E08;
				case 226:
					goto IL_AD3;
				case 227:
					goto IL_F55;
				case 228:
					goto IL_D68;
				case 229:
					goto IL_18CD;
				case 230:
					goto IL_1F56;
				case 231:
					goto IL_5F7;
				case 232:
					goto IL_CD2;
				case 233:
					goto IL_14D6;
				case 234:
					goto IL_D2A;
				case 235:
					goto IL_1AAD;
				case 236:
					goto IL_588;
				case 237:
					goto IL_E8E;
				case 238:
					goto IL_D8F;
				case 239:
					goto IL_1DEC;
				case 240:
					goto IL_16D3;
				case 241:
					goto IL_1A93;
				case 242:
					goto IL_13E8;
				case 243:
					goto IL_14C9;
				case 244:
					goto IL_B42;
				case 245:
					goto IL_D03;
				case 246:
					goto IL_1243;
				case 247:
					goto IL_16E0;
				case 248:
					goto IL_1FD2;
				case 249:
					goto IL_7D3;
				case 250:
					goto IL_132B;
				case 251:
					goto IL_113E;
				case 252:
					goto IL_8CE;
				case 253:
					goto IL_936;
				case 254:
					goto IL_1464;
				case 255:
					goto IL_163D;
				case 256:
					goto IL_1074;
				case 257:
					goto IL_1EB6;
				case 258:
					goto IL_169F;
				case 259:
					goto IL_1E44;
				case 260:
					goto IL_192F;
				case 261:
					goto IL_869;
				case 262:
					goto IL_15E5;
				case 263:
					goto IL_A54;
				case 264:
					goto IL_12B2;
				case 265:
					goto IL_15D8;
				case 266:
					goto IL_C30;
				case 267:
					goto IL_14FA;
				case 268:
					goto IL_6C1;
				case 269:
					goto IL_CC5;
				case 270:
					goto IL_1298;
				case 271:
					goto IL_14A2;
				case 272:
					goto IL_5C6;
				case 273:
					goto IL_F48;
				case 274:
					goto IL_152B;
				case 275:
					goto IL_1AEB;
				case 276:
					goto IL_726;
				case 277:
					goto IL_8C1;
				case 278:
					goto IL_1345;
				case 279:
					goto IL_1162;
				case 280:
					goto IL_8DB;
				case 281:
					goto IL_11F8;
				case 282:
					goto IL_D5B;
				case 283:
					goto IL_1A0D;
				case 284:
					goto IL_1738;
				case 285:
					goto IL_FAD;
				case 286:
					goto IL_1BA5;
				case 287:
					goto IL_7ED;
				case 288:
					goto IL_DB3;
				case 289:
					goto IL_8E8;
				case 290:
					goto IL_179D;
				case 291:
					goto IL_1809;
				case 292:
					goto IL_62B;
				case 293:
					goto IL_1C85;
				case 294:
					goto IL_1F32;
				case 295:
					goto IL_1E37;
				case 296:
					goto IL_1816;
				case 297:
					goto IL_2010;
				case 298:
					goto IL_9F2;
				case 299:
					goto IL_11BA;
				case 300:
					goto IL_69D;
				case 301:
					goto IL_F86;
				case 302:
					goto IL_82B;
				case 303:
					goto IL_604;
				case 304:
					goto IL_1DAE;
				case 305:
					goto IL_10E3;
				case 306:
					goto IL_1FEC;
				case 307:
					goto IL_1B5A;
				case 308:
					goto IL_E15;
				case 309:
					goto IL_1067;
				case 310:
					goto IL_101C;
				case 311:
					goto IL_136C;
				case 312:
					goto IL_1029;
				case 313:
					goto IL_1F25;
				case 314:
					goto IL_1E2A;
				case 315:
					goto IL_1984;
				case 316:
					goto IL_1D28;
				case 317:
					goto IL_14AF;
				case 318:
					goto IL_16B9;
				case 319:
					goto IL_1EA9;
				case 320:
					goto IL_11C7;
				case 321:
					goto IL_FD1;
				case 322:
					goto IL_1D66;
				case 323:
					goto IL_1E75;
				case 324:
					goto IL_1623;
				case 325:
					goto IL_638;
				case 326:
					goto IL_14BC;
				case 327:
					goto IL_18C0;
				case 328:
					goto IL_12FA;
				case 329:
					goto IL_1C61;
				case 330:
					goto IL_17C1;
				case 331:
					goto IL_1352;
				case 332:
					goto IL_ECC;
				case 333:
					goto IL_143D;
				default:
					num = (short)1501560832;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_588:
			this.DispMenuIDDisplayDisplayOnModeChange_A7876Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_595:
			this.RTDBtnRadioErgDispAdvanceStatusAutoExit_42158 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5A2:
			this.LblDispMenuGeneralOutofRangeIndicator_A8678 = (global::AcpUI.AcpLabel)target;
			this.LblDispMenuGeneralOutofRangeIndicator_A8678.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5C6:
			this.ExpanderDisplayAndMenuBacklightColorControlGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_5D3:
			this.LblDRSMFlipDisplayState_A24778 = (global::AcpUI.AcpLabel)target;
			this.LblDRSMFlipDisplayState_A24778.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5F7:
			this.CVBtnDispMenuIDDisplayDisplayOnModeChange_A7876 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_604:
			this.RTDBtnDispMenuLabtoolBlue1_A7565 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_611:
			this.CpyBtnRadioErgDispAdvanceChannelColorBacklight_43747 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_61E:
			this.CpyBtnDispMenuGeneralSearchingSiteIndicator = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_62B:
			this.CpyBtnDispMenuLabtoolRed1_A8923 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_638:
			this.DispMenuTestModePassword_A4973Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_645:
			this.AdvancedDisplayLightTimeSec_A7875Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_652:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_65F:
			this.DispMenuGeneralSlowScrollCount_A9160 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DispMenuGeneralSlowScrollCount_A9160.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_683:
			this.RTDBtnDispMenuGeneralSlowScrollRatems_A9161 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_690:
			this.CVBtnDispMenuGeneralSearchingSiteIndicator = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_69D:
			this.DispMenuLabtoolBlue1_A7565 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DispMenuLabtoolBlue1_A7565.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_6C1:
			this.RadProfBacklightColorControlDefaultBacklightColor_A7811 = (global::AcpUI.AcpComboBox)target;
			this.RadProfBacklightColorControlDefaultBacklightColor_A7811.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_6E5:
			this.CVBtnAdvancedAutoLight = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6F2:
			this.DispMenuAdvancedLanguageSelection_A8386Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_6FF:
			this.CVBtnPrefixIDTextSize_A22465 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_70C:
			this.CpyBtnRadErgoWideStealthSaveDayNightMode_A36492 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_719:
			this.RTDBtnDispMenuGeneralOutofRangeIndicator_A8678 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_726:
			this.DispMenuLabtoolColorText1_A7689_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_733:
			this.DispMenuGeneralSiteTrunkingIndicator_A7426 = (global::AcpUI.AcpComboBox)target;
			this.DispMenuGeneralSiteTrunkingIndicator_A7426.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_757:
			this.RTDBtnDispMenuGeneralOutOfRangeHoldOffTimer = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_764:
			this.DispMenuGeneralOutOfRangeHoldOffTimer = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DispMenuGeneralOutOfRangeHoldOffTimer.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_788:
			this.DisplMenuAdvancedTopLightColorPerChannel_A43171Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_795:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_7A2:
			this.CpyBtnDispMenuAdvancedAlternatingDisplayTimems_A7436 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_7AF:
			this.RadErgoDisGeneralSysRegIndicator_A37603 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoDisGeneralSysRegIndicator_A37603.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_7D3:
			this.ExpanderDisplayAndMenuIDDisplayTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_7E0:
			this.RadErgoCfgDisplayGeneralLocalOnlyIndicator_A40160Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_7ED:
			this.DispMenuLabtoolColorText1_A7689Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_7FA:
			this.CpyBtnDispMenuGeneralSlowScrollRatems_A9161 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_807:
			this.HLinkBacklightColorControl = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkBacklightColorControl.Click += this.HLinkClick;
			return;
			IL_82B:
			this.LblDispMenuLabtoolBlue1_A7565 = (global::AcpUI.AcpLabel)target;
			this.LblDispMenuLabtoolBlue1_A7565.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_84F:
			this.DispMenuGeneralSearchingSiteIndicatorComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_85C:
			this.CVBtnDispMenuGeneralSlowScrollRatems_A9161 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_869:
			this.CpyBtnDispMenuIDDisplayID_A8738 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_876:
			this.CVBtnDispMenuGeneralTopZoneTextSize_A19769 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_883:
			this.DispMenuGeneralSlowScrollRatems_A9161Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_890:
			this.RecNavToolbarExpanderDisplayAndMenuIDDisplayTable = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderDisplayAndMenuIDDisplayTable.ModeClick += this.OnModeClick;
			return;
			IL_8B4:
			this.CpyBtnDispMenuGeneralOutofRangeIndicator_A8678 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_8C1:
			this.DispMenuLabtoolRed1_A8923_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_8CE:
			this.CVBtnPrefix_A23035 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_8DB:
			this.DispMenuLabtoolConfigurable1_A7700_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_8E8:
			this.CVBtnDispMenuLabtoolRed1_A8923 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_8F5:
			this.CpyBtnDispMenuGeneralFastScrollRatems_A8014 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_902:
			this.GrpBoxExpanderDisplayAndMenuIDDisplayPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_90F:
			this.CpyBtnRadErgoDisGeneralSysRegIndicator_A37603 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_91C:
			this.CVBtnRadErgoWideDispMenu_A21430 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_929:
			this.DRSMFlipDisplayState_A24778Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_936:
			this.LblPrefix_A23035 = (global::AcpUI.AcpLabel)target;
			this.LblPrefix_A23035.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_95A:
			this.RadioErgDispAdvanceStatusAutoExit_42158 = (global::AcpUI.AcpComboBox)target;
			this.RadioErgDispAdvanceStatusAutoExit_42158.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_97E:
			this.RTDBtnAdvancedAutoLight = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_98B:
			num = (short)924647425;
			if (num != 0)
			{
			}
			this.DispMenuGeneralOutOfRangeEarlyDetectionComp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_9C1:
			this.CpyBtnAdvancedAutoLight = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9CE:
			this.DispMenuAdvancedFeatureInactivityTimeoutSec_A20011 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DispMenuAdvancedFeatureInactivityTimeoutSec_A20011.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_9F2:
			this.CpyBtnDispMenuLabtoolGreen1_A8172 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9FF:
			this.LblDispMenuAdvancedAlternatingDisplayTimems_A7436 = (global::AcpUI.AcpLabel)target;
			this.LblDispMenuAdvancedAlternatingDisplayTimems_A7436.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A23:
			this.LblRadWideAdvancedBacklightWhileinVA_A7536 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideAdvancedBacklightWhileinVA_A7536.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A47:
			this.RadioErgDispAdvanceStatusAutoExit_42158Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_A54:
			this.ExpanderDisplayAndMenuBacklightColorControl = (global::AcpUI.AcpExpander)target;
			return;
			IL_A61:
			this.RadErgoWideDispMenu_A21430Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_A6E:
			this.RTDBtnDispMenuGeneralSearchingSiteIndicator = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A7B:
			this.RTDBtnDispMenuTopChannelTextSize_A19504 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A88:
			this.RTDBtnDRSMFlipDisplayState_A24778 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A95:
			this.ExpanderDisplayAndMenuGeneral = (global::AcpUI.AcpExpander)target;
			return;
			IL_AA2:
			this.CVBtnDRSMFlipDisplayState_A24778 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_AAF:
			this.RadErgoCfgDisplayGeneralLocalOnlyIndicator_A40160 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoCfgDisplayGeneralLocalOnlyIndicator_A40160.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_AD3:
			this.LblDispMenuIDDisplayDisplayOnPTT_A7878 = (global::AcpUI.AcpLabel)target;
			this.LblDispMenuIDDisplayDisplayOnPTT_A7878.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_AF7:
			this.PrefixIDTextSize_A22465Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_B04:
			this.LblDispMenuIDDisplayEndOfVoiceTimerSec_A7973 = (global::AcpUI.AcpLabel)target;
			this.LblDispMenuIDDisplayEndOfVoiceTimerSec_A7973.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_B28:
			this.CVBtnRadErgoCfgDisplayGeneralLocalOnlyIndicator_A40160 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B35:
			this.CpyBtnDisplMenuAdvancedTopLightColorPerChannel_A43171 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B42:
			this.ExpanderDisplayAndMenuIDDisplayTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_B4F:
			((global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.PageDisplayAndMenu)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.PageDisplayAndMenu)target).Unloaded += this.OnUnloaded;
			return;
			IL_B98:
			goto IL_201D;
			IL_B9D:
			this.LblRadErgoWideDispMenu_A21430 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideDispMenu_A21430.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_BC1:
			this.LblAdvancedDisplayLightTimeSec_A7875 = (global::AcpUI.AcpLabel)target;
			this.LblAdvancedDisplayLightTimeSec_A7875.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_BE5:
			this.AdvancedAutoLight = (global::AcpUI.AcpCheckBox)target;
			this.AdvancedAutoLight.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_C09:
			this.RadErgoDisGeneralSysRegIndicator_A37603Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_C16:
			this.CVBtnDispMenuAdvancedAlternatingDisplayTimems_A7436 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_C23:
			this.CpyBtnDRSMFlipDisplayState_A24778 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_C30:
			this.CVBtnRadProfBacklightColorControlDefaultBacklightColor_A7811 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_C3D:
			num = (short)2002406071;
			short num3 = num;
			num = (short)1927760567;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_132B:
				this.gridExpanderDisplayAndMenuIDDisplayTableSRecView = (global::System.Windows.Controls.Grid)target;
				return;
			default:
				num = (short)220856320;
				if (num != 0)
				{
				}
				this.DispMenuIDDisplayPTTIDDisplay_A8221 = (global::AcpUI.AcpComboBox)target;
				this.DispMenuIDDisplayPTTIDDisplay_A8221.GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			IL_CAB:
			this.RTDBtnDispMenuIDDisplayPTTIDDisplay_A8221 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_CB8:
			this.DispMenuGeneralSiteTrunkingIndicator_A7426Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_CC5:
			this.RTDBtnRadProfBacklightColorControlDefaultBacklightColor_A7811 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_CD2:
			this.LblDispMenuIDDisplayDisplayOnModeChange_A7876 = (global::AcpUI.AcpLabel)target;
			this.LblDispMenuIDDisplayDisplayOnModeChange_A7876.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_CF6:
			this.CpyBtnAdvancedIndependentRotaryLight_A8254 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_D03:
			this.ExpanderDisplayAndMenuIDDisplayTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_D10:
			this.DispMenuGeneralImbalancedCoverageIndicator_A8240Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_D1D:
			this.CVBtnDispMenuGeneralOutOfRangeEarlyDetection = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_D2A:
			this.RTDBtnDispMenuIDDisplayDisplayOnModeChange_A7876 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_D37:
			this.LblDispMenuIDDisplayPTTIDDisplay_A8221 = (global::AcpUI.AcpLabel)target;
			this.LblDispMenuIDDisplayPTTIDDisplay_A8221.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_D5B:
			this.gridExpanderDisplayAndMenuBacklightColorsSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_D68:
			this.RTDBtnDispMenuIDDisplayDisplayOnPTT_A7878 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_D75:
			this.RadioErgDispAdvanceChannelColorBacklight_43747Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_D82:
			this.RTDBtnPrefixIDTextSize_A22465 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_D8F:
			this.LblDispMenuIDDisplayDisplayOnReceive_A7880 = (global::AcpUI.AcpLabel)target;
			this.LblDispMenuIDDisplayDisplayOnReceive_A7880.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_DB3:
			this.DispMenuLabtoolRed1_A8923 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DispMenuLabtoolRed1_A8923.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_DD7:
			this.DispMenuGeneralZoneTextSize_A8167 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DispMenuGeneralZoneTextSize_A8167.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_DFB:
			this.CpyBtnDispMenuGeneralImbalancedCoverageIndicator_A8240 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_E08:
			this.CVBtnDispMenuIDDisplayDisplayOnPTT_A7878 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_E15:
			this.LblDispMenuLabtoolConfigurable1_A7700 = (global::AcpUI.AcpLabel)target;
			this.LblDispMenuLabtoolConfigurable1_A7700.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_E39:
			this.LblDispMenuAdvancedFeatureInactivityTimeoutSec_A20011 = (global::AcpUI.AcpLabel)target;
			this.LblDispMenuAdvancedFeatureInactivityTimeoutSec_A20011.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_E5D:
			this.CVBtnAdvancedDisplayLightTimeSec_A7875 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_E6A:
			this.LblDispMenuGeneralTopZoneTextSize_A19769 = (global::AcpUI.AcpLabel)target;
			this.LblDispMenuGeneralTopZoneTextSize_A19769.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_E8E:
			this.CVBtnDispMenuIDDisplayDisplayOnReceive_A7880 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_E9B:
			this.DispMenuGeneralOutOfRangeEarlyDetection = (global::AcpUI.AcpCheckBox)target;
			this.DispMenuGeneralOutOfRangeEarlyDetection.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_EBF:
			this.RTDBtnDispMenuAdvancedLanguageSelection_A8386 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_ECC:
			this.CpyBtnDispMenuLabtoolCharacterEncodingType_A21738 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_ED9:
			this.LblDispMenuAdvancedTemporaryMessageDisplayTimems_A9287 = (global::AcpUI.AcpLabel)target;
			this.LblDispMenuAdvancedTemporaryMessageDisplayTimems_A9287.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_EFD:
			this.CVBtnDispMenuGeneralChannelTextSize_A7663 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_F0A:
			this.RTDBtnDispMenuGeneralTopZoneTextSize_A19769 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_F17:
			this.FlipDisplayState_A19471Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_F24:
			this.PrefixIDTextSize_A22465 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.PrefixIDTextSize_A22465.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_F48:
			this.ExpanderDisplayAndMenuBacklightColorsGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_F55:
			this.DispMenuIDDisplayDisplayOnPTT_A7878 = (global::AcpUI.AcpCheckBox)target;
			this.DispMenuIDDisplayDisplayOnPTT_A7878.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_F79:
			this.AdvancedIndependentRotaryLight_A8254Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_F86:
			this.CVBtnDispMenuLabtoolBlue1_A7565 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_F93:
			this.CpyBtnDispMenuGeneralOutOfRangeHoldOffTimer = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_FA0:
			this.DispMenuAdvancedTemporaryMessageDisplayTimems_A9287Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_FAD:
			this.LblDispMenuLabtoolColorText1_A7689 = (global::AcpUI.AcpLabel)target;
			this.LblDispMenuLabtoolColorText1_A7689.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_FD1:
			this.LblDispMenuTestModePassword_A4973 = (global::AcpUI.AcpLabel)target;
			this.LblDispMenuTestModePassword_A4973.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_FF5:
			this.GrpBoxExpanderDisplayAndMenuAdvancedPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1002:
			this.RTDBtnDispMenuGeneralImbalancedCoverageIndicator_A8240 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_100F:
			this.GrpBoxExpanderDisplayAndMenuIDDisplayTalkgroup = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_101C:
			this.CpyBtnDispMenuLabtoolConfigurable1_A7700 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1029:
			this.ExpanderDisplayAndMenuTestMode = (global::AcpUI.AcpExpander)target;
			return;
			IL_1036:
			this.RTDBtnRadErgoCfgDisplayGeneralLocalOnlyIndicator_A40160 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1043:
			this.RadWideAdvancedBacklightWhileinVA_A7536 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideAdvancedBacklightWhileinVA_A7536.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1067:
			this.RTDBtnDispMenuLabtoolConfigurable1_A7700 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1074:
			this.Prefix_A23035Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1081:
			this.RTDBtnRadErgoWideDispMenu_A21430 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_108E:
			this.LblDispMenuGeneralImbalancedCoverageIndicator_A8240 = (global::AcpUI.AcpLabel)target;
			this.LblDispMenuGeneralImbalancedCoverageIndicator_A8240.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_10B2:
			this.CpyBtnFlipDisplayState_A19471 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_10BF:
			this.LblDisplMenuAdvancedTopLightColorPerChannel_A43171 = (global::AcpUI.AcpLabel)target;
			this.LblDisplMenuAdvancedTopLightColorPerChannel_A43171.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_10E3:
			this.DispMenuLabtoolBlue1_A7565Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_10F0:
			this.CpyBtnDispMenuGeneralZoneTextSize_A8167 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_10FD:
			this.GrpBoxExpanderDisplayAndMenuGeneralScrollConfiguration = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_110A:
			this.RTDBtnDispMenuGeneralSlowScrollCount_A9160 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1117:
			this.CVBtnDispMenuTopChannelTextSize_A19504 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1124:
			this.RTDBtnRadErgoWideStealthSaveDayNightMode_A36492 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1131:
			this.DispMenuTopChannelTextSize_A19504Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_113E:
			this.Prefix_A23035 = (global::AcpUI.AcpLabel)target;
			this.Prefix_A23035.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1162:
			this.DispMenuLabtoolBlue1_A7565_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_116F:
			this.RTDBtnDispMenuGeneralSiteTrunkingIndicator_A7426 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_117C:
			this.ExpanderDisplayAndMenuIDDisplay = (global::AcpUI.AcpExpander)target;
			return;
			IL_1189:
			this.DispMenuAdvancedAlternatingDisplayTimems_A7436Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1196:
			this.DispMenuGeneralFastScrollRatems_A8014 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DispMenuGeneralFastScrollRatems_A8014.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_11BA:
			this.DispMenuLabtoolGreen1_A8172Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_11C7:
			this.CVBtnDispMenuTestModePassword_A4973 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_11D4:
			this.DispMenuTopChannelTextSize_A19504 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DispMenuTopChannelTextSize_A19504.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_11F8:
			this.ExpanderDisplayAndMenuBacklightColorsSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1205:
			this.LblRadioErgDispAdvanceChannelColorBacklight_43747 = (global::AcpUI.AcpLabel)target;
			this.LblRadioErgDispAdvanceChannelColorBacklight_43747.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1229:
			this.CVBtnRadioErgDispAdvanceStatusAutoExit_42158 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1236:
			this.CVBtnDispMenuAdvancedTemporaryMessageDisplayTimems_A9287 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1243:
			this.ExpanderDisplayAndMenuIDDisplayTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_1250:
			this.AdvancedIndependentRotaryLight_A8254 = (global::AcpUI.AcpCheckBox)target;
			this.AdvancedIndependentRotaryLight_A8254.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1274:
			this.LblDispMenuGeneralOutOfRangeHoldOffTimer = (global::AcpUI.AcpLabel)target;
			this.LblDispMenuGeneralOutOfRangeHoldOffTimer.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1298:
			this.CpyBtnRadProfBacklightColorControlDefaultBacklightColor_A7811 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_12A5:
			this.RTDBtnDispMenuGeneralFastScrollRatems_A8014 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_12B2:
			this.RecNavToolbarExpanderDisplayAndMenuBacklightColors = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderDisplayAndMenuBacklightColors.ModeClick += this.OnModeClick;
			return;
			IL_12D6:
			this.HLinkGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkGeneral.Click += this.HLinkClick;
			return;
			IL_12FA:
			this.CVBtnDispMenuLabtoolCharacterEncodingType_A21738 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1307:
			this.DispMenuGeneralTopZoneTextSize_A19769 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DispMenuGeneralTopZoneTextSize_A19769.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1338:
			this.RTDBtnDisplMenuAdvancedTopLightColorPerChannel_A43171 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1345:
			this.DispMenuLabtoolGreen1_A8172_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1352:
			this.RTDBtnDispMenuLabtoolCharacterEncodingType_A21738 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_135F:
			this.RTDBtnFlipDisplayState_A19471 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_136C:
			this.DispMenuLabtoolConfigurable1_A7700Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1379:
			this.RTDBtnRadioErgDispAdvanceChannelColorBacklight_43747 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1386:
			this.CpyBtnDispMenuGeneralOutOfRangeEarlyDetection = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1393:
			this.CpyBtnPrefixIDTextSize_A22465 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_13A0:
			this.DRSMFlipDisplayState_A24778 = (global::AcpUI.AcpComboBox)target;
			this.DRSMFlipDisplayState_A24778.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_13C4:
			this.LblDispMenuGeneralFastScrollRatems_A8014 = (global::AcpUI.AcpLabel)target;
			this.LblDispMenuGeneralFastScrollRatems_A8014.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_13E8:
			this.DispMenuIDDisplayDisplayOnReceive_A7880Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_13F5:
			this.LblDispMenuGeneralSearchingSiteIndicator = (global::AcpUI.AcpLabel)target;
			this.LblDispMenuGeneralSearchingSiteIndicator.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1419:
			this.LblRadioErgDispAdvanceStatusAutoExit_42158 = (global::AcpUI.AcpLabel)target;
			this.LblRadioErgDispAdvanceStatusAutoExit_42158.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_143D:
			this.DispMenuLabtoolCharacterEncodingType_A21738Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_144A:
			this.DispMenuGeneralZoneTextSize_A8167Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1457:
			this.RTDBtnAdvancedDisplayLightTimeSec_A7875 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1464:
			this.RTDBtnPrefix_A23035 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1471:
			this.DispMenuAdvancedTemporaryMessageDisplayTimems_A9287 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DispMenuAdvancedTemporaryMessageDisplayTimems_A9287.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1495:
			this.RTDBtnDispMenuAdvancedTemporaryMessageDisplayTimems_A9287 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_14A2:
			this.RadProfBacklightColorControlDefaultBacklightColor_A7811Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_14AF:
			this.RTDBtnDispMenuTestModeTestModePasswordEnabled_A4971 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_14BC:
			this.ExpanderDisplayAndMenuLabtool = (global::AcpUI.AcpExpander)target;
			return;
			IL_14C9:
			this.ExpanderDisplayAndMenuIDDisplayGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_14D6:
			this.DispMenuIDDisplayDisplayOnModeChange_A7876 = (global::AcpUI.AcpCheckBox)target;
			this.DispMenuIDDisplayDisplayOnModeChange_A7876.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_14FA:
			this.LblRadProfBacklightColorControlDefaultBacklightColor_A7811 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfBacklightColorControlDefaultBacklightColor_A7811.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_151E:
			this.CpyBtnRadErgoCfgDisplayGeneralLocalOnlyIndicator_A40160 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_152B:
			this.ExpanderDisplayAndMenuBacklightColorsTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1538:
			this.LblDispMenuGeneralOutOfRangeEarlyDetection = (global::AcpUI.AcpLabel)target;
			this.LblDispMenuGeneralOutOfRangeEarlyDetection.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_155C:
			this.HLinkLabtool = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkLabtool.Click += this.HLinkClick;
			return;
			IL_1580:
			this.RadErgoWideStealthSaveDayNightMode_A36492Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_158D:
			this.CVBtnRadErgoWideStealthSaveDayNightMode_A36492 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_159A:
			this.FlipDisplayState_A19471 = (global::AcpUI.AcpComboBox)target;
			this.FlipDisplayState_A19471.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_15BE:
			this.CVBtnDispMenuIDDisplayEndOfVoiceTimerSec_A7973 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_15CB:
			this.CpyBtnDispMenuGeneralChannelTextSize_A7663 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_15D8:
			this.GrpBoxExpanderDisplayAndMenuBacklightColorControlPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_15E5:
			this.DispMenuIDDisplayID_A8738Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_15F2:
			this.AdvancedDisplayLightTimeSec_A7875 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.AdvancedDisplayLightTimeSec_A7875.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1616:
			this.CVBtnDispMenuGeneralZoneTextSize_A8167 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1623:
			this.CpyBtnDispMenuTestModePassword_A4973 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1630:
			this.RTDBtnRadErgoDisGeneralSysRegIndicator_A37603 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_163D:
			this.CpyBtnPrefix_A23035 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_164A:
			this.DispMenuGeneralSlowScrollRatems_A9161 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DispMenuGeneralSlowScrollRatems_A9161.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_166E:
			this.RTDBtnRadWideAdvancedBacklightWhileinVA_A7536 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_167B:
			this.DispMenuAdvancedLanguageSelection_A8386 = (global::AcpUI.AcpComboBox)target;
			this.DispMenuAdvancedLanguageSelection_A8386.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_169F:
			this.CVBtnDispMenuIDDisplayID_A8738 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_16AC:
			this.RTDBtnDispMenuAdvancedAlternatingDisplayTimems_A7436 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_16B9:
			this.CpyBtnDispMenuTestModeTestModePasswordEnabled_A4971 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_16C6:
			this.CVBtnDispMenuGeneralOutOfRangeHoldOffTimer = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_16D3:
			this.RTDBtnDispMenuIDDisplayDisplayOnReceive_A7880 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_16E0:
			this.Prefix_A23035_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_16ED:
			this.LblDispMenuGeneralZoneTextSize_A8167 = (global::AcpUI.AcpLabel)target;
			this.LblDispMenuGeneralZoneTextSize_A8167.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1711:
			this.RTDBtnAdvancedIndependentRotaryLight_A8254 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_171E:
			this.CVBtnDisplMenuAdvancedTopLightColorPerChannel_A43171 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_172B:
			this.CpyBtnDispMenuGeneralSiteTrunkingIndicator_A7426 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1738:
			this.CVBtnDispMenuLabtoolColorText1_A7689 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1745:
			this.CVBtnDispMenuAdvancedFeatureInactivityTimeoutSec_A20011 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1752:
			this.DispMenuGeneralChannelTextSize_A7663Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_175F:
			this.CVBtnDispMenuGeneralSiteTrunkingIndicator_A7426 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_176C:
			this.LblRadErgoCfgDisplayGeneralLocalOnlyIndicator_A40160 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoCfgDisplayGeneralLocalOnlyIndicator_A40160.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1790:
			this.CpyBtnDispMenuAdvancedFeatureInactivityTimeoutSec_A20011 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_179D:
			this.LblDispMenuLabtoolRed1_A8923 = (global::AcpUI.AcpLabel)target;
			this.LblDispMenuLabtoolRed1_A8923.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_17C1:
			this.DispMenuLabtoolCharacterEncodingType_A21738 = (global::AcpUI.AcpComboBox)target;
			this.DispMenuLabtoolCharacterEncodingType_A21738.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_17E5:
			this.DispMenuIDDisplayEndOfVoiceTimerSec_A7973 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DispMenuIDDisplayEndOfVoiceTimerSec_A7973.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1809:
			this.RTDBtnDispMenuLabtoolRed1_A8923 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1816:
			this.LblDispMenuLabtoolGreen1_A8172 = (global::AcpUI.AcpLabel)target;
			this.LblDispMenuLabtoolGreen1_A8172.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_183A:
			this.DispMenuAdvancedFeatureInactivityTimeoutSec_A20011Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1847:
			this.RadioErgDispAdvanceChannelColorBacklight_43747 = (global::AcpUI.AcpComboBox)target;
			this.RadioErgDispAdvanceChannelColorBacklight_43747.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_186B:
			this.RadWideAdvancedBacklightWhileinVA_A7536Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1878:
			this.LblDispMenuGeneralSlowScrollCount_A9160 = (global::AcpUI.AcpLabel)target;
			this.LblDispMenuGeneralSlowScrollCount_A9160.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_189C:
			this.DispMenuGeneralSearchingSiteIndicator = (global::AcpUI.AcpComboBox)target;
			this.DispMenuGeneralSearchingSiteIndicator.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_18C0:
			this.GrpBoxExpanderDisplayAndMenuLabtoolPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_18CD:
			this.CpyBtnDispMenuIDDisplayDisplayOnPTT_A7878 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_18DA:
			this.DispMenuAdvancedAlternatingDisplayTimems_A7436 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DispMenuAdvancedAlternatingDisplayTimems_A7436.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_18FE:
			this.CpyBtnDispMenuTopChannelTextSize_A19504 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_190B:
			this.HLinkTestMode = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkTestMode.Click += this.HLinkClick;
			return;
			IL_192F:
			this.RTDBtnDispMenuIDDisplayID_A8738 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_193C:
			this.LblAdvancedIndependentRotaryLight_A8254 = (global::AcpUI.AcpLabel)target;
			this.LblAdvancedIndependentRotaryLight_A8254.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1960:
			this.LblRadErgoWideStealthSaveDayNightMode_A36492 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideStealthSaveDayNightMode_A36492.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1984:
			this.LblDispMenuTestModeTestModePasswordEnabled_A4971 = (global::AcpUI.AcpLabel)target;
			this.LblDispMenuTestModeTestModePasswordEnabled_A4971.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_19A8:
			this.DispMenuGeneralImbalancedCoverageIndicator_A8240 = (global::AcpUI.AcpComboBox)target;
			this.DispMenuGeneralImbalancedCoverageIndicator_A8240.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_19CC:
			this.CpyBtnDispMenuAdvancedLanguageSelection_A8386 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_19D9:
			this.RTDBtnDispMenuAdvancedFeatureInactivityTimeoutSec_A20011 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_19E6:
			this.CpyBtnDispMenuIDDisplayEndOfVoiceTimerSec_A7973 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_19F3:
			this.DispMenuGeneralOutofRangeIndicator_A8678Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1A00:
			this.DispMenuGeneralOutOfRangeHoldOffTimerComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1A0D:
			this.DispMenuLabtoolColorText1_A7689 = (global::AcpUI.AcpTextBox)target;
			this.DispMenuLabtoolColorText1_A7689.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1A31:
			this.DispMenuIDDisplayEndOfVoiceTimerSec_A7973Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1A3E:
			this.LblDispMenuGeneralSiteTrunkingIndicator_A7426 = (global::AcpUI.AcpLabel)target;
			this.LblDispMenuGeneralSiteTrunkingIndicator_A7426.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1A62:
			this.DispMenuGeneralOutofRangeIndicator_A8678 = (global::AcpUI.AcpComboBox)target;
			this.DispMenuGeneralOutofRangeIndicator_A8678.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1A86:
			this.DispMenuGeneralSlowScrollCount_A9160Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1A93:
			this.CpyBtnDispMenuIDDisplayDisplayOnReceive_A7880 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1AA0:
			this.CVBtnFlipDisplayState_A19471 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1AAD:
			this.CpyBtnDispMenuIDDisplayDisplayOnModeChange_A7876 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1ABA:
			this.CVBtnRadWideAdvancedBacklightWhileinVA_A7536 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1AC7:
			this.RadErgoWideDispMenu_A21430 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoWideDispMenu_A21430.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1AEB:
			this.ExpanderDisplayAndMenuBacklightColors = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_1AF8:
			this.DisplMenuAdvancedTopLightColorPerChannel_A43171 = (global::AcpUI.AcpCheckBox)target;
			this.DisplMenuAdvancedTopLightColorPerChannel_A43171.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1B1C:
			this.DispMenuIDDisplayPTTIDDisplay_A8221Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1B29:
			this.CVBtnAdvancedIndependentRotaryLight_A8254 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1B36:
			this.LblDispMenuGeneralSlowScrollRatems_A9161 = (global::AcpUI.AcpLabel)target;
			this.LblDispMenuGeneralSlowScrollRatems_A9161.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1B5A:
			this.CVBtnDispMenuLabtoolConfigurable1_A7700 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1B67:
			this.LblAdvancedAutoLight = (global::AcpUI.AcpLabel)target;
			this.LblAdvancedAutoLight.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1B8B:
			this.GrpBoxExpanderDisplayAndMenuGeneralTextConfiguration = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1B98:
			this.AdvancedAutoLightComp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1BA5:
			num = (short)1422262272;
			short num4 = num;
			this.CpyBtnDispMenuLabtoolColorText1_A7689 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1BDB:
			this.RadErgoWideStealthSaveDayNightMode_A36492 = (global::AcpUI.AcpCheckBox)target;
			this.RadErgoWideStealthSaveDayNightMode_A36492.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1BFF:
			this.HLinkIDDisplay = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkIDDisplay.Click += this.HLinkClick;
			return;
			IL_1C23:
			this.LblRadErgoDisGeneralSysRegIndicator_A37603 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoDisGeneralSysRegIndicator_A37603.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1C47:
			this.GrpBoxExpanderDisplayAndMenuGeneralPseudo2 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1C54:
			this.RTDBtnDispMenuGeneralZoneTextSize_A8167 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1C61:
			this.LblDispMenuLabtoolCharacterEncodingType_A21738 = (global::AcpUI.AcpLabel)target;
			this.LblDispMenuLabtoolCharacterEncodingType_A21738.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1C85:
			this.DispMenuLabtoolRed1_A8923Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1C92:
			this.ExpanderDisplayAndMenuAdvanced = (global::AcpUI.AcpExpander)target;
			return;
			IL_1C9F:
			this.LblDispMenuGeneralChannelTextSize_A7663 = (global::AcpUI.AcpLabel)target;
			this.LblDispMenuGeneralChannelTextSize_A7663.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1CC3:
			this.DispMenuGeneralTopZoneTextSize_A19769Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1CD0:
			this.CVBtnDispMenuGeneralImbalancedCoverageIndicator_A8240 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1CDD:
			this.CVBtnDispMenuAdvancedLanguageSelection_A8386 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1CEA:
			this.LblDispMenuAdvancedLanguageSelection_A8386 = (global::AcpUI.AcpLabel)target;
			this.LblDispMenuAdvancedLanguageSelection_A8386.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1D0E:
			this.CpyBtnDispMenuIDDisplayPTTIDDisplay_A8221 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1D1B:
			this.RTDBtnDispMenuGeneralChannelTextSize_A7663 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1D28:
			this.DispMenuTestModeTestModePasswordEnabled_A4971 = (global::AcpUI.AcpCheckBox)target;
			this.DispMenuTestModeTestModePasswordEnabled_A4971.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1D4C:
			this.CVBtnRadErgoDisGeneralSysRegIndicator_A37603 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1D59:
			this.DispMenuGeneralFastScrollRatems_A8014Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1D66:
			this.DispMenuTestModePassword_A4973 = (global::AcpUI.AcpTextBox)target;
			this.DispMenuTestModePassword_A4973.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1D8A:
			this.LblPrefixIDTextSize_A22465 = (global::AcpUI.AcpLabel)target;
			this.LblPrefixIDTextSize_A22465.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1DAE:
			this.CpyBtnDispMenuLabtoolBlue1_A7565 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1DBB:
			this.HLinkAdvanced = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkAdvanced.Click += this.HLinkClick;
			return;
			IL_1DDF:
			this.CpyBtnDispMenuGeneralTopZoneTextSize_A19769 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1DEC:
			this.DispMenuIDDisplayDisplayOnReceive_A7880 = (global::AcpUI.AcpCheckBox)target;
			this.DispMenuIDDisplayDisplayOnReceive_A7880.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1E10:
			this.RTDBtnDispMenuGeneralOutOfRangeEarlyDetection = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1E1D:
			this.CVBtnDispMenuGeneralOutofRangeIndicator_A8678 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1E2A:
			this.CVBtnDispMenuTestModeTestModePasswordEnabled_A4971 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1E37:
			this.CVBtnDispMenuLabtoolGreen1_A8172 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1E44:
			this.LblDispMenuIDDisplayID_A8738 = (global::AcpUI.AcpLabel)target;
			this.LblDispMenuIDDisplayID_A8738.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1E68:
			this.CpyBtnRadioErgDispAdvanceStatusAutoExit_42158 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1E75:
			this.RTDBtnDispMenuTestModePassword_A4973 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1E82:
			this.CVBtnRadioErgDispAdvanceChannelColorBacklight_43747 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1E8F:
			this.CVBtnDispMenuGeneralSlowScrollCount_A9160 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1E9C:
			this.RTDBtnDispMenuIDDisplayEndOfVoiceTimerSec_A7973 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1EA9:
			this.DispMenuTestModeTestModePasswordEnabled_A4971Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1EB6:
			this.DispMenuIDDisplayID_A8738 = (global::AcpUI.AcpTextBox)target;
			this.DispMenuIDDisplayID_A8738.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1EDA:
			this.CpyBtnDispMenuGeneralSlowScrollCount_A9160 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1EE7:
			this.DispMenuGeneralChannelTextSize_A7663 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DispMenuGeneralChannelTextSize_A7663.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1F0B:
			this.CpyBtnRadWideAdvancedBacklightWhileinVA_A7536 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1F18:
			this.CpyBtnAdvancedDisplayLightTimeSec_A7875 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1F25:
			this.GrpBoxExpanderDisplayAndMenuTestModePseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1F32:
			this.DispMenuLabtoolGreen1_A8172 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DispMenuLabtoolGreen1_A8172.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1F56:
			this.DispMenuIDDisplayDisplayOnPTT_A7878Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1F63:
			this.CpyBtnDispMenuAdvancedTemporaryMessageDisplayTimems_A9287 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1F70:
			this.CVBtnDispMenuGeneralFastScrollRatems_A8014 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1F7D:
			this.CpyBtnRadErgoWideDispMenu_A21430 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1F8A:
			this.LblFlipDisplayState_A19471 = (global::AcpUI.AcpLabel)target;
			this.LblFlipDisplayState_A19471.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1FAE:
			this.LblDispMenuTopChannelTextSize_A19504 = (global::AcpUI.AcpLabel)target;
			this.LblDispMenuTopChannelTextSize_A19504.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1FD2:
			this.DispMenuIDDisplayID_A8738_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1FDF:
			this.CVBtnDispMenuIDDisplayPTTIDDisplay_A8221 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1FEC:
			this.DispMenuLabtoolConfigurable1_A7700 = (global::AcpUI.AcpCheckBox)target;
			this.DispMenuLabtoolConfigurable1_A7700.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2010:
			this.RTDBtnDispMenuLabtoolGreen1_A8172 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_201D:
			this.b = true;
		}

		// Token: 0x060070EC RID: 28908 RVA: 0x00649E90 File Offset: 0x00648090
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
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 4:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 5:
			{
				short num = (short)1633536950;
				short num2 = num;
				num = (short)1092012982;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1544552448;
					short num3 = num;
					num = (short)701890560;
					if (num != 0)
					{
					}
					((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				}
				}
				break;
			}
			case 6:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 7:
			{
				short num = (short)1553072129;
				if (num != 0)
				{
				}
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			case 8:
				break;
			default:
				return;
			}
			((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x04002BA1 RID: 11169
		private bool a;

		// Token: 0x04002BA2 RID: 11170
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x04002BA3 RID: 11171
		internal global::System.Windows.Documents.Hyperlink HLinkGeneral;

		// Token: 0x04002BA4 RID: 11172
		internal global::System.Windows.Documents.Hyperlink HLinkAdvanced;

		// Token: 0x04002BA5 RID: 11173
		internal global::System.Windows.Documents.Hyperlink HLinkIDDisplay;

		// Token: 0x04002BA6 RID: 11174
		internal global::System.Windows.Documents.Hyperlink HLinkBacklightColorControl;

		// Token: 0x04002BA7 RID: 11175
		internal global::System.Windows.Documents.Hyperlink HLinkTestMode;

		// Token: 0x04002BA8 RID: 11176
		internal global::System.Windows.Documents.Hyperlink HLinkLabtool;

		// Token: 0x04002BA9 RID: 11177
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x04002BAA RID: 11178
		internal global::AcpUI.AcpExpander ExpanderDisplayAndMenuGeneral;

		// Token: 0x04002BAB RID: 11179
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDisplayAndMenuGeneralTextConfiguration;

		// Token: 0x04002BAC RID: 11180
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDispMenuGeneralZoneTextSize_A8167;

		// Token: 0x04002BAD RID: 11181
		internal global::AcpUI.AcpLabel LblDispMenuGeneralZoneTextSize_A8167;

		// Token: 0x04002BAE RID: 11182
		internal global::AcpUI.AcpTextBoxSpinner DispMenuGeneralZoneTextSize_A8167;

		// Token: 0x04002BAF RID: 11183
		internal global::AcpUI.AcpRtdButton RTDBtnDispMenuGeneralZoneTextSize_A8167;

		// Token: 0x04002BB0 RID: 11184
		internal global::AcpUI.AcpCopyButton CpyBtnDispMenuGeneralZoneTextSize_A8167;

		// Token: 0x04002BB1 RID: 11185
		internal global::AcpUI.AcpLabel DispMenuGeneralZoneTextSize_A8167Comp;

		// Token: 0x04002BB2 RID: 11186
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDispMenuGeneralChannelTextSize_A7663;

		// Token: 0x04002BB3 RID: 11187
		internal global::AcpUI.AcpLabel LblDispMenuGeneralChannelTextSize_A7663;

		// Token: 0x04002BB4 RID: 11188
		internal global::AcpUI.AcpTextBoxSpinner DispMenuGeneralChannelTextSize_A7663;

		// Token: 0x04002BB5 RID: 11189
		internal global::AcpUI.AcpRtdButton RTDBtnDispMenuGeneralChannelTextSize_A7663;

		// Token: 0x04002BB6 RID: 11190
		internal global::AcpUI.AcpCopyButton CpyBtnDispMenuGeneralChannelTextSize_A7663;

		// Token: 0x04002BB7 RID: 11191
		internal global::AcpUI.AcpLabel DispMenuGeneralChannelTextSize_A7663Comp;

		// Token: 0x04002BB8 RID: 11192
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDispMenuGeneralTopZoneTextSize_A19769;

		// Token: 0x04002BB9 RID: 11193
		internal global::AcpUI.AcpLabel LblDispMenuGeneralTopZoneTextSize_A19769;

		// Token: 0x04002BBA RID: 11194
		internal global::AcpUI.AcpTextBoxSpinner DispMenuGeneralTopZoneTextSize_A19769;

		// Token: 0x04002BBB RID: 11195
		internal global::AcpUI.AcpRtdButton RTDBtnDispMenuGeneralTopZoneTextSize_A19769;

		// Token: 0x04002BBC RID: 11196
		internal global::AcpUI.AcpCopyButton CpyBtnDispMenuGeneralTopZoneTextSize_A19769;

		// Token: 0x04002BBD RID: 11197
		internal global::AcpUI.AcpLabel DispMenuGeneralTopZoneTextSize_A19769Comp;

		// Token: 0x04002BBE RID: 11198
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDispMenuTopChannelTextSize_A19504;

		// Token: 0x04002BBF RID: 11199
		internal global::AcpUI.AcpLabel LblDispMenuTopChannelTextSize_A19504;

		// Token: 0x04002BC0 RID: 11200
		internal global::AcpUI.AcpTextBoxSpinner DispMenuTopChannelTextSize_A19504;

		// Token: 0x04002BC1 RID: 11201
		internal global::AcpUI.AcpRtdButton RTDBtnDispMenuTopChannelTextSize_A19504;

		// Token: 0x04002BC2 RID: 11202
		internal global::AcpUI.AcpCopyButton CpyBtnDispMenuTopChannelTextSize_A19504;

		// Token: 0x04002BC3 RID: 11203
		internal global::AcpUI.AcpLabel DispMenuTopChannelTextSize_A19504Comp;

		// Token: 0x04002BC4 RID: 11204
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnFlipDisplayState_A19471;

		// Token: 0x04002BC5 RID: 11205
		internal global::AcpUI.AcpLabel LblFlipDisplayState_A19471;

		// Token: 0x04002BC6 RID: 11206
		internal global::AcpUI.AcpComboBox FlipDisplayState_A19471;

		// Token: 0x04002BC7 RID: 11207
		internal global::AcpUI.AcpRtdButton RTDBtnFlipDisplayState_A19471;

		// Token: 0x04002BC8 RID: 11208
		internal global::AcpUI.AcpCopyButton CpyBtnFlipDisplayState_A19471;

		// Token: 0x04002BC9 RID: 11209
		internal global::AcpUI.AcpLabel FlipDisplayState_A19471Comp;

		// Token: 0x04002BCA RID: 11210
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDRSMFlipDisplayState_A24778;

		// Token: 0x04002BCB RID: 11211
		internal global::AcpUI.AcpLabel LblDRSMFlipDisplayState_A24778;

		// Token: 0x04002BCC RID: 11212
		internal global::AcpUI.AcpComboBox DRSMFlipDisplayState_A24778;

		// Token: 0x04002BCD RID: 11213
		internal global::AcpUI.AcpRtdButton RTDBtnDRSMFlipDisplayState_A24778;

		// Token: 0x04002BCE RID: 11214
		internal global::AcpUI.AcpCopyButton CpyBtnDRSMFlipDisplayState_A24778;

		// Token: 0x04002BCF RID: 11215
		internal global::AcpUI.AcpLabel DRSMFlipDisplayState_A24778Comp;

		// Token: 0x04002BD0 RID: 11216
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDisplayAndMenuGeneralScrollConfiguration;

		// Token: 0x04002BD1 RID: 11217
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDispMenuGeneralSlowScrollRatems_A9161;

		// Token: 0x04002BD2 RID: 11218
		internal global::AcpUI.AcpLabel LblDispMenuGeneralSlowScrollRatems_A9161;

		// Token: 0x04002BD3 RID: 11219
		internal global::AcpUI.AcpTextBoxSpinner DispMenuGeneralSlowScrollRatems_A9161;

		// Token: 0x04002BD4 RID: 11220
		internal global::AcpUI.AcpRtdButton RTDBtnDispMenuGeneralSlowScrollRatems_A9161;

		// Token: 0x04002BD5 RID: 11221
		internal global::AcpUI.AcpCopyButton CpyBtnDispMenuGeneralSlowScrollRatems_A9161;

		// Token: 0x04002BD6 RID: 11222
		internal global::AcpUI.AcpLabel DispMenuGeneralSlowScrollRatems_A9161Comp;

		// Token: 0x04002BD7 RID: 11223
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDispMenuGeneralFastScrollRatems_A8014;

		// Token: 0x04002BD8 RID: 11224
		internal global::AcpUI.AcpLabel LblDispMenuGeneralFastScrollRatems_A8014;

		// Token: 0x04002BD9 RID: 11225
		internal global::AcpUI.AcpTextBoxSpinner DispMenuGeneralFastScrollRatems_A8014;

		// Token: 0x04002BDA RID: 11226
		internal global::AcpUI.AcpRtdButton RTDBtnDispMenuGeneralFastScrollRatems_A8014;

		// Token: 0x04002BDB RID: 11227
		internal global::AcpUI.AcpCopyButton CpyBtnDispMenuGeneralFastScrollRatems_A8014;

		// Token: 0x04002BDC RID: 11228
		internal global::AcpUI.AcpLabel DispMenuGeneralFastScrollRatems_A8014Comp;

		// Token: 0x04002BDD RID: 11229
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDispMenuGeneralSlowScrollCount_A9160;

		// Token: 0x04002BDE RID: 11230
		internal global::AcpUI.AcpLabel LblDispMenuGeneralSlowScrollCount_A9160;

		// Token: 0x04002BDF RID: 11231
		internal global::AcpUI.AcpTextBoxSpinner DispMenuGeneralSlowScrollCount_A9160;

		// Token: 0x04002BE0 RID: 11232
		internal global::AcpUI.AcpRtdButton RTDBtnDispMenuGeneralSlowScrollCount_A9160;

		// Token: 0x04002BE1 RID: 11233
		internal global::AcpUI.AcpCopyButton CpyBtnDispMenuGeneralSlowScrollCount_A9160;

		// Token: 0x04002BE2 RID: 11234
		internal global::AcpUI.AcpLabel DispMenuGeneralSlowScrollCount_A9160Comp;

		// Token: 0x04002BE3 RID: 11235
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDisplayAndMenuGeneralPseudo2;

		// Token: 0x04002BE4 RID: 11236
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDispMenuGeneralOutofRangeIndicator_A8678;

		// Token: 0x04002BE5 RID: 11237
		internal global::AcpUI.AcpLabel LblDispMenuGeneralOutofRangeIndicator_A8678;

		// Token: 0x04002BE6 RID: 11238
		internal global::AcpUI.AcpComboBox DispMenuGeneralOutofRangeIndicator_A8678;

		// Token: 0x04002BE7 RID: 11239
		internal global::AcpUI.AcpRtdButton RTDBtnDispMenuGeneralOutofRangeIndicator_A8678;

		// Token: 0x04002BE8 RID: 11240
		internal global::AcpUI.AcpCopyButton CpyBtnDispMenuGeneralOutofRangeIndicator_A8678;

		// Token: 0x04002BE9 RID: 11241
		internal global::AcpUI.AcpLabel DispMenuGeneralOutofRangeIndicator_A8678Comp;

		// Token: 0x04002BEA RID: 11242
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDispMenuGeneralSearchingSiteIndicator;

		// Token: 0x04002BEB RID: 11243
		internal global::AcpUI.AcpLabel LblDispMenuGeneralSearchingSiteIndicator;

		// Token: 0x04002BEC RID: 11244
		internal global::AcpUI.AcpComboBox DispMenuGeneralSearchingSiteIndicator;

		// Token: 0x04002BED RID: 11245
		internal global::AcpUI.AcpRtdButton RTDBtnDispMenuGeneralSearchingSiteIndicator;

		// Token: 0x04002BEE RID: 11246
		internal global::AcpUI.AcpCopyButton CpyBtnDispMenuGeneralSearchingSiteIndicator;

		// Token: 0x04002BEF RID: 11247
		internal global::AcpUI.AcpLabel DispMenuGeneralSearchingSiteIndicatorComp;

		// Token: 0x04002BF0 RID: 11248
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDispMenuGeneralOutOfRangeHoldOffTimer;

		// Token: 0x04002BF1 RID: 11249
		internal global::AcpUI.AcpLabel LblDispMenuGeneralOutOfRangeHoldOffTimer;

		// Token: 0x04002BF2 RID: 11250
		internal global::AcpUI.AcpTextBoxSpinner DispMenuGeneralOutOfRangeHoldOffTimer;

		// Token: 0x04002BF3 RID: 11251
		internal global::AcpUI.AcpRtdButton RTDBtnDispMenuGeneralOutOfRangeHoldOffTimer;

		// Token: 0x04002BF4 RID: 11252
		internal global::AcpUI.AcpCopyButton CpyBtnDispMenuGeneralOutOfRangeHoldOffTimer;

		// Token: 0x04002BF5 RID: 11253
		internal global::AcpUI.AcpLabel DispMenuGeneralOutOfRangeHoldOffTimerComp;

		// Token: 0x04002BF6 RID: 11254
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDispMenuGeneralImbalancedCoverageIndicator_A8240;

		// Token: 0x04002BF7 RID: 11255
		internal global::AcpUI.AcpLabel LblDispMenuGeneralImbalancedCoverageIndicator_A8240;

		// Token: 0x04002BF8 RID: 11256
		internal global::AcpUI.AcpComboBox DispMenuGeneralImbalancedCoverageIndicator_A8240;

		// Token: 0x04002BF9 RID: 11257
		internal global::AcpUI.AcpRtdButton RTDBtnDispMenuGeneralImbalancedCoverageIndicator_A8240;

		// Token: 0x04002BFA RID: 11258
		internal global::AcpUI.AcpCopyButton CpyBtnDispMenuGeneralImbalancedCoverageIndicator_A8240;

		// Token: 0x04002BFB RID: 11259
		internal global::AcpUI.AcpLabel DispMenuGeneralImbalancedCoverageIndicator_A8240Comp;

		// Token: 0x04002BFC RID: 11260
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDispMenuGeneralSiteTrunkingIndicator_A7426;

		// Token: 0x04002BFD RID: 11261
		internal global::AcpUI.AcpLabel LblDispMenuGeneralSiteTrunkingIndicator_A7426;

		// Token: 0x04002BFE RID: 11262
		internal global::AcpUI.AcpComboBox DispMenuGeneralSiteTrunkingIndicator_A7426;

		// Token: 0x04002BFF RID: 11263
		internal global::AcpUI.AcpRtdButton RTDBtnDispMenuGeneralSiteTrunkingIndicator_A7426;

		// Token: 0x04002C00 RID: 11264
		internal global::AcpUI.AcpCopyButton CpyBtnDispMenuGeneralSiteTrunkingIndicator_A7426;

		// Token: 0x04002C01 RID: 11265
		internal global::AcpUI.AcpLabel DispMenuGeneralSiteTrunkingIndicator_A7426Comp;

		// Token: 0x04002C02 RID: 11266
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideStealthSaveDayNightMode_A36492;

		// Token: 0x04002C03 RID: 11267
		internal global::AcpUI.AcpLabel LblRadErgoWideStealthSaveDayNightMode_A36492;

		// Token: 0x04002C04 RID: 11268
		internal global::AcpUI.AcpCheckBox RadErgoWideStealthSaveDayNightMode_A36492;

		// Token: 0x04002C05 RID: 11269
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideStealthSaveDayNightMode_A36492;

		// Token: 0x04002C06 RID: 11270
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideStealthSaveDayNightMode_A36492;

		// Token: 0x04002C07 RID: 11271
		internal global::AcpUI.AcpCheckBox RadErgoWideStealthSaveDayNightMode_A36492Comp;

		// Token: 0x04002C08 RID: 11272
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoDisGeneralSysRegIndicator_A37603;

		// Token: 0x04002C09 RID: 11273
		internal global::AcpUI.AcpLabel LblRadErgoDisGeneralSysRegIndicator_A37603;

		// Token: 0x04002C0A RID: 11274
		internal global::AcpUI.AcpComboBox RadErgoDisGeneralSysRegIndicator_A37603;

		// Token: 0x04002C0B RID: 11275
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoDisGeneralSysRegIndicator_A37603;

		// Token: 0x04002C0C RID: 11276
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoDisGeneralSysRegIndicator_A37603;

		// Token: 0x04002C0D RID: 11277
		internal global::AcpUI.AcpLabel RadErgoDisGeneralSysRegIndicator_A37603Comp;

		// Token: 0x04002C0E RID: 11278
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoCfgDisplayGeneralLocalOnlyIndicator_A40160;

		// Token: 0x04002C0F RID: 11279
		internal global::AcpUI.AcpLabel LblRadErgoCfgDisplayGeneralLocalOnlyIndicator_A40160;

		// Token: 0x04002C10 RID: 11280
		internal global::AcpUI.AcpComboBox RadErgoCfgDisplayGeneralLocalOnlyIndicator_A40160;

		// Token: 0x04002C11 RID: 11281
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoCfgDisplayGeneralLocalOnlyIndicator_A40160;

		// Token: 0x04002C12 RID: 11282
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoCfgDisplayGeneralLocalOnlyIndicator_A40160;

		// Token: 0x04002C13 RID: 11283
		internal global::AcpUI.AcpLabel RadErgoCfgDisplayGeneralLocalOnlyIndicator_A40160Comp;

		// Token: 0x04002C14 RID: 11284
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDispMenuGeneralOutOfRangeEarlyDetection;

		// Token: 0x04002C15 RID: 11285
		internal global::AcpUI.AcpLabel LblDispMenuGeneralOutOfRangeEarlyDetection;

		// Token: 0x04002C16 RID: 11286
		internal global::AcpUI.AcpCheckBox DispMenuGeneralOutOfRangeEarlyDetection;

		// Token: 0x04002C17 RID: 11287
		internal global::AcpUI.AcpRtdButton RTDBtnDispMenuGeneralOutOfRangeEarlyDetection;

		// Token: 0x04002C18 RID: 11288
		internal global::AcpUI.AcpCopyButton CpyBtnDispMenuGeneralOutOfRangeEarlyDetection;

		// Token: 0x04002C19 RID: 11289
		internal global::AcpUI.AcpCheckBox DispMenuGeneralOutOfRangeEarlyDetectionComp;

		// Token: 0x04002C1A RID: 11290
		internal global::AcpUI.AcpExpander ExpanderDisplayAndMenuAdvanced;

		// Token: 0x04002C1B RID: 11291
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDisplayAndMenuAdvancedPseudo0;

		// Token: 0x04002C1C RID: 11292
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDispMenuAdvancedLanguageSelection_A8386;

		// Token: 0x04002C1D RID: 11293
		internal global::AcpUI.AcpLabel LblDispMenuAdvancedLanguageSelection_A8386;

		// Token: 0x04002C1E RID: 11294
		internal global::AcpUI.AcpComboBox DispMenuAdvancedLanguageSelection_A8386;

		// Token: 0x04002C1F RID: 11295
		internal global::AcpUI.AcpRtdButton RTDBtnDispMenuAdvancedLanguageSelection_A8386;

		// Token: 0x04002C20 RID: 11296
		internal global::AcpUI.AcpCopyButton CpyBtnDispMenuAdvancedLanguageSelection_A8386;

		// Token: 0x04002C21 RID: 11297
		internal global::AcpUI.AcpLabel DispMenuAdvancedLanguageSelection_A8386Comp;

		// Token: 0x04002C22 RID: 11298
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnAdvancedAutoLight;

		// Token: 0x04002C23 RID: 11299
		internal global::AcpUI.AcpLabel LblAdvancedAutoLight;

		// Token: 0x04002C24 RID: 11300
		internal global::AcpUI.AcpCheckBox AdvancedAutoLight;

		// Token: 0x04002C25 RID: 11301
		internal global::AcpUI.AcpRtdButton RTDBtnAdvancedAutoLight;

		// Token: 0x04002C26 RID: 11302
		internal global::AcpUI.AcpCopyButton CpyBtnAdvancedAutoLight;

		// Token: 0x04002C27 RID: 11303
		internal global::AcpUI.AcpCheckBox AdvancedAutoLightComp;

		// Token: 0x04002C28 RID: 11304
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideAdvancedBacklightWhileinVA_A7536;

		// Token: 0x04002C29 RID: 11305
		internal global::AcpUI.AcpLabel LblRadWideAdvancedBacklightWhileinVA_A7536;

		// Token: 0x04002C2A RID: 11306
		internal global::AcpUI.AcpCheckBox RadWideAdvancedBacklightWhileinVA_A7536;

		// Token: 0x04002C2B RID: 11307
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideAdvancedBacklightWhileinVA_A7536;

		// Token: 0x04002C2C RID: 11308
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideAdvancedBacklightWhileinVA_A7536;

		// Token: 0x04002C2D RID: 11309
		internal global::AcpUI.AcpCheckBox RadWideAdvancedBacklightWhileinVA_A7536Comp;

		// Token: 0x04002C2E RID: 11310
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnAdvancedDisplayLightTimeSec_A7875;

		// Token: 0x04002C2F RID: 11311
		internal global::AcpUI.AcpLabel LblAdvancedDisplayLightTimeSec_A7875;

		// Token: 0x04002C30 RID: 11312
		internal global::AcpUI.AcpTextBoxSpinner AdvancedDisplayLightTimeSec_A7875;

		// Token: 0x04002C31 RID: 11313
		internal global::AcpUI.AcpRtdButton RTDBtnAdvancedDisplayLightTimeSec_A7875;

		// Token: 0x04002C32 RID: 11314
		internal global::AcpUI.AcpCopyButton CpyBtnAdvancedDisplayLightTimeSec_A7875;

		// Token: 0x04002C33 RID: 11315
		internal global::AcpUI.AcpLabel AdvancedDisplayLightTimeSec_A7875Comp;

		// Token: 0x04002C34 RID: 11316
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDispMenuAdvancedAlternatingDisplayTimems_A7436;

		// Token: 0x04002C35 RID: 11317
		internal global::AcpUI.AcpLabel LblDispMenuAdvancedAlternatingDisplayTimems_A7436;

		// Token: 0x04002C36 RID: 11318
		internal global::AcpUI.AcpTextBoxSpinner DispMenuAdvancedAlternatingDisplayTimems_A7436;

		// Token: 0x04002C37 RID: 11319
		internal global::AcpUI.AcpRtdButton RTDBtnDispMenuAdvancedAlternatingDisplayTimems_A7436;

		// Token: 0x04002C38 RID: 11320
		internal global::AcpUI.AcpCopyButton CpyBtnDispMenuAdvancedAlternatingDisplayTimems_A7436;

		// Token: 0x04002C39 RID: 11321
		internal global::AcpUI.AcpLabel DispMenuAdvancedAlternatingDisplayTimems_A7436Comp;

		// Token: 0x04002C3A RID: 11322
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDispMenuAdvancedTemporaryMessageDisplayTimems_A9287;

		// Token: 0x04002C3B RID: 11323
		internal global::AcpUI.AcpLabel LblDispMenuAdvancedTemporaryMessageDisplayTimems_A9287;

		// Token: 0x04002C3C RID: 11324
		internal global::AcpUI.AcpTextBoxSpinner DispMenuAdvancedTemporaryMessageDisplayTimems_A9287;

		// Token: 0x04002C3D RID: 11325
		internal global::AcpUI.AcpRtdButton RTDBtnDispMenuAdvancedTemporaryMessageDisplayTimems_A9287;

		// Token: 0x04002C3E RID: 11326
		internal global::AcpUI.AcpCopyButton CpyBtnDispMenuAdvancedTemporaryMessageDisplayTimems_A9287;

		// Token: 0x04002C3F RID: 11327
		internal global::AcpUI.AcpLabel DispMenuAdvancedTemporaryMessageDisplayTimems_A9287Comp;

		// Token: 0x04002C40 RID: 11328
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDisplMenuAdvancedTopLightColorPerChannel_A43171;

		// Token: 0x04002C41 RID: 11329
		internal global::AcpUI.AcpLabel LblDisplMenuAdvancedTopLightColorPerChannel_A43171;

		// Token: 0x04002C42 RID: 11330
		internal global::AcpUI.AcpCheckBox DisplMenuAdvancedTopLightColorPerChannel_A43171;

		// Token: 0x04002C43 RID: 11331
		internal global::AcpUI.AcpRtdButton RTDBtnDisplMenuAdvancedTopLightColorPerChannel_A43171;

		// Token: 0x04002C44 RID: 11332
		internal global::AcpUI.AcpCopyButton CpyBtnDisplMenuAdvancedTopLightColorPerChannel_A43171;

		// Token: 0x04002C45 RID: 11333
		internal global::AcpUI.AcpCheckBox DisplMenuAdvancedTopLightColorPerChannel_A43171Comp;

		// Token: 0x04002C46 RID: 11334
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnAdvancedIndependentRotaryLight_A8254;

		// Token: 0x04002C47 RID: 11335
		internal global::AcpUI.AcpLabel LblAdvancedIndependentRotaryLight_A8254;

		// Token: 0x04002C48 RID: 11336
		internal global::AcpUI.AcpCheckBox AdvancedIndependentRotaryLight_A8254;

		// Token: 0x04002C49 RID: 11337
		internal global::AcpUI.AcpRtdButton RTDBtnAdvancedIndependentRotaryLight_A8254;

		// Token: 0x04002C4A RID: 11338
		internal global::AcpUI.AcpCopyButton CpyBtnAdvancedIndependentRotaryLight_A8254;

		// Token: 0x04002C4B RID: 11339
		internal global::AcpUI.AcpCheckBox AdvancedIndependentRotaryLight_A8254Comp;

		// Token: 0x04002C4C RID: 11340
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDispMenuAdvancedFeatureInactivityTimeoutSec_A20011;

		// Token: 0x04002C4D RID: 11341
		internal global::AcpUI.AcpLabel LblDispMenuAdvancedFeatureInactivityTimeoutSec_A20011;

		// Token: 0x04002C4E RID: 11342
		internal global::AcpUI.AcpTextBoxSpinner DispMenuAdvancedFeatureInactivityTimeoutSec_A20011;

		// Token: 0x04002C4F RID: 11343
		internal global::AcpUI.AcpRtdButton RTDBtnDispMenuAdvancedFeatureInactivityTimeoutSec_A20011;

		// Token: 0x04002C50 RID: 11344
		internal global::AcpUI.AcpCopyButton CpyBtnDispMenuAdvancedFeatureInactivityTimeoutSec_A20011;

		// Token: 0x04002C51 RID: 11345
		internal global::AcpUI.AcpLabel DispMenuAdvancedFeatureInactivityTimeoutSec_A20011Comp;

		// Token: 0x04002C52 RID: 11346
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideDispMenu_A21430;

		// Token: 0x04002C53 RID: 11347
		internal global::AcpUI.AcpLabel LblRadErgoWideDispMenu_A21430;

		// Token: 0x04002C54 RID: 11348
		internal global::AcpUI.AcpComboBox RadErgoWideDispMenu_A21430;

		// Token: 0x04002C55 RID: 11349
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideDispMenu_A21430;

		// Token: 0x04002C56 RID: 11350
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideDispMenu_A21430;

		// Token: 0x04002C57 RID: 11351
		internal global::AcpUI.AcpLabel RadErgoWideDispMenu_A21430Comp;

		// Token: 0x04002C58 RID: 11352
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadioErgDispAdvanceStatusAutoExit_42158;

		// Token: 0x04002C59 RID: 11353
		internal global::AcpUI.AcpLabel LblRadioErgDispAdvanceStatusAutoExit_42158;

		// Token: 0x04002C5A RID: 11354
		internal global::AcpUI.AcpComboBox RadioErgDispAdvanceStatusAutoExit_42158;

		// Token: 0x04002C5B RID: 11355
		internal global::AcpUI.AcpRtdButton RTDBtnRadioErgDispAdvanceStatusAutoExit_42158;

		// Token: 0x04002C5C RID: 11356
		internal global::AcpUI.AcpCopyButton CpyBtnRadioErgDispAdvanceStatusAutoExit_42158;

		// Token: 0x04002C5D RID: 11357
		internal global::AcpUI.AcpLabel RadioErgDispAdvanceStatusAutoExit_42158Comp;

		// Token: 0x04002C5E RID: 11358
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadioErgDispAdvanceChannelColorBacklight_43747;

		// Token: 0x04002C5F RID: 11359
		internal global::AcpUI.AcpLabel LblRadioErgDispAdvanceChannelColorBacklight_43747;

		// Token: 0x04002C60 RID: 11360
		internal global::AcpUI.AcpComboBox RadioErgDispAdvanceChannelColorBacklight_43747;

		// Token: 0x04002C61 RID: 11361
		internal global::AcpUI.AcpRtdButton RTDBtnRadioErgDispAdvanceChannelColorBacklight_43747;

		// Token: 0x04002C62 RID: 11362
		internal global::AcpUI.AcpCopyButton CpyBtnRadioErgDispAdvanceChannelColorBacklight_43747;

		// Token: 0x04002C63 RID: 11363
		internal global::AcpUI.AcpLabel RadioErgDispAdvanceChannelColorBacklight_43747Comp;

		// Token: 0x04002C64 RID: 11364
		internal global::AcpUI.AcpExpander ExpanderDisplayAndMenuIDDisplay;

		// Token: 0x04002C65 RID: 11365
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderDisplayAndMenuIDDisplayTable;

		// Token: 0x04002C66 RID: 11366
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDisplayAndMenuIDDisplayPseudo0;

		// Token: 0x04002C67 RID: 11367
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDispMenuIDDisplayPTTIDDisplay_A8221;

		// Token: 0x04002C68 RID: 11368
		internal global::AcpUI.AcpLabel LblDispMenuIDDisplayPTTIDDisplay_A8221;

		// Token: 0x04002C69 RID: 11369
		internal global::AcpUI.AcpComboBox DispMenuIDDisplayPTTIDDisplay_A8221;

		// Token: 0x04002C6A RID: 11370
		internal global::AcpUI.AcpRtdButton RTDBtnDispMenuIDDisplayPTTIDDisplay_A8221;

		// Token: 0x04002C6B RID: 11371
		internal global::AcpUI.AcpCopyButton CpyBtnDispMenuIDDisplayPTTIDDisplay_A8221;

		// Token: 0x04002C6C RID: 11372
		internal global::AcpUI.AcpLabel DispMenuIDDisplayPTTIDDisplay_A8221Comp;

		// Token: 0x04002C6D RID: 11373
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDispMenuIDDisplayEndOfVoiceTimerSec_A7973;

		// Token: 0x04002C6E RID: 11374
		internal global::AcpUI.AcpLabel LblDispMenuIDDisplayEndOfVoiceTimerSec_A7973;

		// Token: 0x04002C6F RID: 11375
		internal global::AcpUI.AcpTextBoxSpinner DispMenuIDDisplayEndOfVoiceTimerSec_A7973;

		// Token: 0x04002C70 RID: 11376
		internal global::AcpUI.AcpRtdButton RTDBtnDispMenuIDDisplayEndOfVoiceTimerSec_A7973;

		// Token: 0x04002C71 RID: 11377
		internal global::AcpUI.AcpCopyButton CpyBtnDispMenuIDDisplayEndOfVoiceTimerSec_A7973;

		// Token: 0x04002C72 RID: 11378
		internal global::AcpUI.AcpLabel DispMenuIDDisplayEndOfVoiceTimerSec_A7973Comp;

		// Token: 0x04002C73 RID: 11379
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnPrefixIDTextSize_A22465;

		// Token: 0x04002C74 RID: 11380
		internal global::AcpUI.AcpLabel LblPrefixIDTextSize_A22465;

		// Token: 0x04002C75 RID: 11381
		internal global::AcpUI.AcpTextBoxSpinner PrefixIDTextSize_A22465;

		// Token: 0x04002C76 RID: 11382
		internal global::AcpUI.AcpRtdButton RTDBtnPrefixIDTextSize_A22465;

		// Token: 0x04002C77 RID: 11383
		internal global::AcpUI.AcpCopyButton CpyBtnPrefixIDTextSize_A22465;

		// Token: 0x04002C78 RID: 11384
		internal global::AcpUI.AcpLabel PrefixIDTextSize_A22465Comp;

		// Token: 0x04002C79 RID: 11385
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDisplayAndMenuIDDisplayTalkgroup;

		// Token: 0x04002C7A RID: 11386
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDispMenuIDDisplayDisplayOnPTT_A7878;

		// Token: 0x04002C7B RID: 11387
		internal global::AcpUI.AcpLabel LblDispMenuIDDisplayDisplayOnPTT_A7878;

		// Token: 0x04002C7C RID: 11388
		internal global::AcpUI.AcpCheckBox DispMenuIDDisplayDisplayOnPTT_A7878;

		// Token: 0x04002C7D RID: 11389
		internal global::AcpUI.AcpRtdButton RTDBtnDispMenuIDDisplayDisplayOnPTT_A7878;

		// Token: 0x04002C7E RID: 11390
		internal global::AcpUI.AcpCopyButton CpyBtnDispMenuIDDisplayDisplayOnPTT_A7878;

		// Token: 0x04002C7F RID: 11391
		internal global::AcpUI.AcpCheckBox DispMenuIDDisplayDisplayOnPTT_A7878Comp;

		// Token: 0x04002C80 RID: 11392
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDispMenuIDDisplayDisplayOnModeChange_A7876;

		// Token: 0x04002C81 RID: 11393
		internal global::AcpUI.AcpLabel LblDispMenuIDDisplayDisplayOnModeChange_A7876;

		// Token: 0x04002C82 RID: 11394
		internal global::AcpUI.AcpCheckBox DispMenuIDDisplayDisplayOnModeChange_A7876;

		// Token: 0x04002C83 RID: 11395
		internal global::AcpUI.AcpRtdButton RTDBtnDispMenuIDDisplayDisplayOnModeChange_A7876;

		// Token: 0x04002C84 RID: 11396
		internal global::AcpUI.AcpCopyButton CpyBtnDispMenuIDDisplayDisplayOnModeChange_A7876;

		// Token: 0x04002C85 RID: 11397
		internal global::AcpUI.AcpCheckBox DispMenuIDDisplayDisplayOnModeChange_A7876Comp;

		// Token: 0x04002C86 RID: 11398
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDispMenuIDDisplayDisplayOnReceive_A7880;

		// Token: 0x04002C87 RID: 11399
		internal global::AcpUI.AcpLabel LblDispMenuIDDisplayDisplayOnReceive_A7880;

		// Token: 0x04002C88 RID: 11400
		internal global::AcpUI.AcpCheckBox DispMenuIDDisplayDisplayOnReceive_A7880;

		// Token: 0x04002C89 RID: 11401
		internal global::AcpUI.AcpRtdButton RTDBtnDispMenuIDDisplayDisplayOnReceive_A7880;

		// Token: 0x04002C8A RID: 11402
		internal global::AcpUI.AcpCopyButton CpyBtnDispMenuIDDisplayDisplayOnReceive_A7880;

		// Token: 0x04002C8B RID: 11403
		internal global::AcpUI.AcpCheckBox DispMenuIDDisplayDisplayOnReceive_A7880Comp;

		// Token: 0x04002C8C RID: 11404
		internal global::System.Windows.Controls.Grid ExpanderDisplayAndMenuIDDisplayGrid;

		// Token: 0x04002C8D RID: 11405
		internal global::System.Windows.Controls.Grid ExpanderDisplayAndMenuIDDisplayTableGrid;

		// Token: 0x04002C8E RID: 11406
		internal global::AcpUI.AcpGroupBox ExpanderDisplayAndMenuIDDisplayTableTableView;

		// Token: 0x04002C8F RID: 11407
		internal global::AcpUI.AcpXamDataPresenter ExpanderDisplayAndMenuIDDisplayTable;

		// Token: 0x04002C90 RID: 11408
		internal global::Infragistics.Windows.DataPresenter.UnboundField Prefix_A23035_Col;

		// Token: 0x04002C91 RID: 11409
		internal global::Infragistics.Windows.DataPresenter.UnboundField DispMenuIDDisplayID_A8738_Col;

		// Token: 0x04002C92 RID: 11410
		internal global::AcpUI.AcpGroupBox ExpanderDisplayAndMenuIDDisplayTableSRecView;

		// Token: 0x04002C93 RID: 11411
		internal global::System.Windows.Controls.Grid gridExpanderDisplayAndMenuIDDisplayTableSRecView;

		// Token: 0x04002C94 RID: 11412
		internal global::AcpUI.AcpLabel Prefix_A23035;

		// Token: 0x04002C95 RID: 11413
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnPrefix_A23035;

		// Token: 0x04002C96 RID: 11414
		internal global::AcpUI.AcpLabel LblPrefix_A23035;

		// Token: 0x04002C97 RID: 11415
		internal global::AcpUI.AcpRtdButton RTDBtnPrefix_A23035;

		// Token: 0x04002C98 RID: 11416
		internal global::AcpUI.AcpCopyButton CpyBtnPrefix_A23035;

		// Token: 0x04002C99 RID: 11417
		internal global::AcpUI.AcpLabel Prefix_A23035Comp;

		// Token: 0x04002C9A RID: 11418
		internal global::AcpUI.AcpTextBox DispMenuIDDisplayID_A8738;

		// Token: 0x04002C9B RID: 11419
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDispMenuIDDisplayID_A8738;

		// Token: 0x04002C9C RID: 11420
		internal global::AcpUI.AcpLabel LblDispMenuIDDisplayID_A8738;

		// Token: 0x04002C9D RID: 11421
		internal global::AcpUI.AcpRtdButton RTDBtnDispMenuIDDisplayID_A8738;

		// Token: 0x04002C9E RID: 11422
		internal global::AcpUI.AcpCopyButton CpyBtnDispMenuIDDisplayID_A8738;

		// Token: 0x04002C9F RID: 11423
		internal global::AcpUI.AcpLabel DispMenuIDDisplayID_A8738Comp;

		// Token: 0x04002CA0 RID: 11424
		internal global::AcpUI.AcpExpander ExpanderDisplayAndMenuBacklightColorControl;

		// Token: 0x04002CA1 RID: 11425
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderDisplayAndMenuBacklightColors;

		// Token: 0x04002CA2 RID: 11426
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDisplayAndMenuBacklightColorControlPseudo0;

		// Token: 0x04002CA3 RID: 11427
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfBacklightColorControlDefaultBacklightColor_A7811;

		// Token: 0x04002CA4 RID: 11428
		internal global::AcpUI.AcpLabel LblRadProfBacklightColorControlDefaultBacklightColor_A7811;

		// Token: 0x04002CA5 RID: 11429
		internal global::AcpUI.AcpComboBox RadProfBacklightColorControlDefaultBacklightColor_A7811;

		// Token: 0x04002CA6 RID: 11430
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfBacklightColorControlDefaultBacklightColor_A7811;

		// Token: 0x04002CA7 RID: 11431
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfBacklightColorControlDefaultBacklightColor_A7811;

		// Token: 0x04002CA8 RID: 11432
		internal global::AcpUI.AcpLabel RadProfBacklightColorControlDefaultBacklightColor_A7811Comp;

		// Token: 0x04002CA9 RID: 11433
		internal global::System.Windows.Controls.Grid ExpanderDisplayAndMenuBacklightColorControlGrid;

		// Token: 0x04002CAA RID: 11434
		internal global::System.Windows.Controls.Grid ExpanderDisplayAndMenuBacklightColorsGrid;

		// Token: 0x04002CAB RID: 11435
		internal global::AcpUI.AcpGroupBox ExpanderDisplayAndMenuBacklightColorsTableView;

		// Token: 0x04002CAC RID: 11436
		internal global::AcpUI.AcpXamDataPresenter ExpanderDisplayAndMenuBacklightColors;

		// Token: 0x04002CAD RID: 11437
		internal global::Infragistics.Windows.DataPresenter.UnboundField DispMenuLabtoolColorText1_A7689_Col;

		// Token: 0x04002CAE RID: 11438
		internal global::Infragistics.Windows.DataPresenter.UnboundField DispMenuLabtoolRed1_A8923_Col;

		// Token: 0x04002CAF RID: 11439
		internal global::Infragistics.Windows.DataPresenter.UnboundField DispMenuLabtoolGreen1_A8172_Col;

		// Token: 0x04002CB0 RID: 11440
		internal global::Infragistics.Windows.DataPresenter.UnboundField DispMenuLabtoolBlue1_A7565_Col;

		// Token: 0x04002CB1 RID: 11441
		internal global::Infragistics.Windows.DataPresenter.UnboundField DispMenuLabtoolConfigurable1_A7700_Col;

		// Token: 0x04002CB2 RID: 11442
		internal global::AcpUI.AcpGroupBox ExpanderDisplayAndMenuBacklightColorsSRecView;

		// Token: 0x04002CB3 RID: 11443
		internal global::System.Windows.Controls.Grid gridExpanderDisplayAndMenuBacklightColorsSRecView;

		// Token: 0x04002CB4 RID: 11444
		internal global::AcpUI.AcpTextBox DispMenuLabtoolColorText1_A7689;

		// Token: 0x04002CB5 RID: 11445
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDispMenuLabtoolColorText1_A7689;

		// Token: 0x04002CB6 RID: 11446
		internal global::AcpUI.AcpLabel LblDispMenuLabtoolColorText1_A7689;

		// Token: 0x04002CB7 RID: 11447
		internal global::AcpUI.AcpCopyButton CpyBtnDispMenuLabtoolColorText1_A7689;

		// Token: 0x04002CB8 RID: 11448
		internal global::AcpUI.AcpLabel DispMenuLabtoolColorText1_A7689Comp;

		// Token: 0x04002CB9 RID: 11449
		internal global::AcpUI.AcpTextBoxSpinner DispMenuLabtoolRed1_A8923;

		// Token: 0x04002CBA RID: 11450
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDispMenuLabtoolRed1_A8923;

		// Token: 0x04002CBB RID: 11451
		internal global::AcpUI.AcpLabel LblDispMenuLabtoolRed1_A8923;

		// Token: 0x04002CBC RID: 11452
		internal global::AcpUI.AcpRtdButton RTDBtnDispMenuLabtoolRed1_A8923;

		// Token: 0x04002CBD RID: 11453
		internal global::AcpUI.AcpCopyButton CpyBtnDispMenuLabtoolRed1_A8923;

		// Token: 0x04002CBE RID: 11454
		internal global::AcpUI.AcpLabel DispMenuLabtoolRed1_A8923Comp;

		// Token: 0x04002CBF RID: 11455
		internal global::AcpUI.AcpTextBoxSpinner DispMenuLabtoolGreen1_A8172;

		// Token: 0x04002CC0 RID: 11456
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDispMenuLabtoolGreen1_A8172;

		// Token: 0x04002CC1 RID: 11457
		internal global::AcpUI.AcpLabel LblDispMenuLabtoolGreen1_A8172;

		// Token: 0x04002CC2 RID: 11458
		internal global::AcpUI.AcpRtdButton RTDBtnDispMenuLabtoolGreen1_A8172;

		// Token: 0x04002CC3 RID: 11459
		internal global::AcpUI.AcpCopyButton CpyBtnDispMenuLabtoolGreen1_A8172;

		// Token: 0x04002CC4 RID: 11460
		internal global::AcpUI.AcpLabel DispMenuLabtoolGreen1_A8172Comp;

		// Token: 0x04002CC5 RID: 11461
		internal global::AcpUI.AcpTextBoxSpinner DispMenuLabtoolBlue1_A7565;

		// Token: 0x04002CC6 RID: 11462
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDispMenuLabtoolBlue1_A7565;

		// Token: 0x04002CC7 RID: 11463
		internal global::AcpUI.AcpLabel LblDispMenuLabtoolBlue1_A7565;

		// Token: 0x04002CC8 RID: 11464
		internal global::AcpUI.AcpRtdButton RTDBtnDispMenuLabtoolBlue1_A7565;

		// Token: 0x04002CC9 RID: 11465
		internal global::AcpUI.AcpCopyButton CpyBtnDispMenuLabtoolBlue1_A7565;

		// Token: 0x04002CCA RID: 11466
		internal global::AcpUI.AcpLabel DispMenuLabtoolBlue1_A7565Comp;

		// Token: 0x04002CCB RID: 11467
		internal global::AcpUI.AcpCheckBox DispMenuLabtoolConfigurable1_A7700;

		// Token: 0x04002CCC RID: 11468
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDispMenuLabtoolConfigurable1_A7700;

		// Token: 0x04002CCD RID: 11469
		internal global::AcpUI.AcpLabel LblDispMenuLabtoolConfigurable1_A7700;

		// Token: 0x04002CCE RID: 11470
		internal global::AcpUI.AcpRtdButton RTDBtnDispMenuLabtoolConfigurable1_A7700;

		// Token: 0x04002CCF RID: 11471
		internal global::AcpUI.AcpCopyButton CpyBtnDispMenuLabtoolConfigurable1_A7700;

		// Token: 0x04002CD0 RID: 11472
		internal global::AcpUI.AcpCheckBox DispMenuLabtoolConfigurable1_A7700Comp;

		// Token: 0x04002CD1 RID: 11473
		internal global::AcpUI.AcpExpander ExpanderDisplayAndMenuTestMode;

		// Token: 0x04002CD2 RID: 11474
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDisplayAndMenuTestModePseudo0;

		// Token: 0x04002CD3 RID: 11475
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDispMenuTestModeTestModePasswordEnabled_A4971;

		// Token: 0x04002CD4 RID: 11476
		internal global::AcpUI.AcpLabel LblDispMenuTestModeTestModePasswordEnabled_A4971;

		// Token: 0x04002CD5 RID: 11477
		internal global::AcpUI.AcpCheckBox DispMenuTestModeTestModePasswordEnabled_A4971;

		// Token: 0x04002CD6 RID: 11478
		internal global::AcpUI.AcpRtdButton RTDBtnDispMenuTestModeTestModePasswordEnabled_A4971;

		// Token: 0x04002CD7 RID: 11479
		internal global::AcpUI.AcpCopyButton CpyBtnDispMenuTestModeTestModePasswordEnabled_A4971;

		// Token: 0x04002CD8 RID: 11480
		internal global::AcpUI.AcpCheckBox DispMenuTestModeTestModePasswordEnabled_A4971Comp;

		// Token: 0x04002CD9 RID: 11481
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDispMenuTestModePassword_A4973;

		// Token: 0x04002CDA RID: 11482
		internal global::AcpUI.AcpLabel LblDispMenuTestModePassword_A4973;

		// Token: 0x04002CDB RID: 11483
		internal global::AcpUI.AcpTextBox DispMenuTestModePassword_A4973;

		// Token: 0x04002CDC RID: 11484
		internal global::AcpUI.AcpRtdButton RTDBtnDispMenuTestModePassword_A4973;

		// Token: 0x04002CDD RID: 11485
		internal global::AcpUI.AcpCopyButton CpyBtnDispMenuTestModePassword_A4973;

		// Token: 0x04002CDE RID: 11486
		internal global::AcpUI.AcpLabel DispMenuTestModePassword_A4973Comp;

		// Token: 0x04002CDF RID: 11487
		internal global::AcpUI.AcpExpander ExpanderDisplayAndMenuLabtool;

		// Token: 0x04002CE0 RID: 11488
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDisplayAndMenuLabtoolPseudo0;

		// Token: 0x04002CE1 RID: 11489
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDispMenuLabtoolCharacterEncodingType_A21738;

		// Token: 0x04002CE2 RID: 11490
		internal global::AcpUI.AcpLabel LblDispMenuLabtoolCharacterEncodingType_A21738;

		// Token: 0x04002CE3 RID: 11491
		internal global::AcpUI.AcpComboBox DispMenuLabtoolCharacterEncodingType_A21738;

		// Token: 0x04002CE4 RID: 11492
		internal global::AcpUI.AcpRtdButton RTDBtnDispMenuLabtoolCharacterEncodingType_A21738;

		// Token: 0x04002CE5 RID: 11493
		internal global::AcpUI.AcpCopyButton CpyBtnDispMenuLabtoolCharacterEncodingType_A21738;

		// Token: 0x04002CE6 RID: 11494
		internal global::AcpUI.AcpLabel DispMenuLabtoolCharacterEncodingType_A21738Comp;

		// Token: 0x04002CE7 RID: 11495
		private bool b;
	}
}
