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

namespace Motorola.MackinawCPS.CoreFeatures.ToneSignalingList
{
	// Token: 0x020001C5 RID: 453
	public class PageToneSignalingList : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x060052E8 RID: 21224 RVA: 0x004B3B20 File Offset: 0x004B1D20
		public PageToneSignalingList()
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

		// Token: 0x060052E9 RID: 21225 RVA: 0x004B3B58 File Offset: 0x004B1D58
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)46268416;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)1487929344;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::AcpUI.AcpExpander acpExpander;
					global::System.Collections.IEnumerator enumerator;
					object obj;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_62;
						}
						continue;
					case 1:
						try
						{
							num = (short)445448192;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_254;
									}
									continue;
								case 1:
									num = (short)1168834565;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									if (acpExpander != null)
									{
										num = (short)426835974;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 4:
									if (!enumerator.MoveNext())
									{
										num = (short)1672216577;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
									num = (short)936443907;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_313;
								case 6:
									base.Expanders.Add(acpExpander);
									num = (short)1963065346;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_256:
								num = (short)889126916;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_254:
								goto IL_256;
							}
							IL_313:
							goto IL_1AA;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_335;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_322:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)1477312513;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_38A;
								case 1:
									disposable.Dispose();
									num = (short)1331888130;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_388;
								}
								goto IL_335;
							}
							IL_388:
							IL_38A:
							goto EndFinally_8;
							IL_335:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)414384128;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_322;
							EndFinally_8:;
						}
						goto IL_38B;
						IL_1AA:
						base.OnLoaded(sender, e);
						this.a = true;
						num = (short)1317273606;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						if (obj == null)
						{
							goto IL_85;
						}
						num = (short)739804932;
						short num3 = num;
						num = (short)1796310788;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1D8;
						default:
						{
							num = (short)474415105;
							if (num != 0)
							{
							}
							num = (short)620167168;
							if (num != 0)
							{
							}
							num = (short)457310208;
							short num4 = num;
							num = (short)295239683;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 3:
						goto IL_1D8;
					case 4:
						this.RecNavToolbarPageToneSignalingList.ChildToolbars.Add(this.RecNavToolbarExpanderToneSignalingListAstroAlertingToneTable);
						obj = null;
						obj = this.RecNavToolbarExpanderToneSignalingListAstroAlertingToneTable.MyRecordsetDataSource;
						num = (short)1643970562;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_85;
					case 6:
						goto IL_1D3;
					}
					IL_62:
					if (!this.a)
					{
						num = (short)1871773700;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_85:
					acpExpander = null;
					enumerator = this.MyStackPanel.Children.GetEnumerator();
					num = (short)1019150337;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1D8:
					global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
					this.RecNavToolbarExpanderToneSignalingListAstroAlertingToneTable.MyDataPresenter = this.ExpanderToneSignalingListAstroAlertingToneTable;
					num = (short)192544773;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1D3:
				IL_38B:
				this.MyStackPanel.Children[0].Focus();
				return;
			}
		}

		// Token: 0x060052EA RID: 21226 RVA: 0x004B3F24 File Offset: 0x004B2124
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
					goto IL_62;
				case 1:
				{
					num2 = (short)1098308472;
					short num3 = num2;
					num2 = (short)1318968184;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_62;
					default:
						num2 = (short)1148911616;
						if (num2 != 0)
						{
						}
						base.OnUnloaded(sender, e);
						this.a = false;
						num2 = (short)932184066;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					goto IL_F4;
				}
				goto IL_1C;
				IL_62:
				if (!this.a)
				{
					return;
				}
				num2 = (short)1356398593;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_F4:
			num2 = (short)2024341505;
			if (num2 != 0)
			{
			}
			num2 = (short)1770323968;
			short num4 = num2;
			return;
			IL_1C:
			this.RecNavToolbarPageToneSignalingList.DataContext = null;
			this.RecNavToolbarExpanderToneSignalingListAstroAlertingToneTable.DataContext = null;
			this.RecNavToolbarPageToneSignalingList.MyDataPresenter = null;
			this.RecNavToolbarExpanderToneSignalingListAstroAlertingToneTable.MyDataPresenter = null;
			num2 = (short)1194262528;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060052EB RID: 21227 RVA: 0x004B4078 File Offset: 0x004B2278
		public override void SetDataContext()
		{
			short num = (short)60096514;
			int num2 = (int)((global::System.IntPtr)num);
			object feature;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_7D;
				case 1:
					goto IL_195;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_4A;
					}
					continue;
				case 3:
					feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(4156);
					num = (short)390987780;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (feature != null)
					{
						num = (short)1723596807;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_195;
				case 5:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(4156);
					num = (short)1739456512;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)479461379;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageToneSignalingList).MySecondaryRecordsetDataSource = null;
					num = (short)460718081;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_190;
				case 8:
					goto IL_7D;
				}
				IL_4A:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)576978949;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_122;
				IL_7D:
				this.RecNavToolbarPageToneSignalingList.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				num = (short)142147590;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_122:
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(4156);
				num = (short)843317256;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_195:
				num = (short)2114250072;
				short num3 = num;
				num = (short)1347216728;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_122;
				case 1:
					goto IL_1F6;
				}
				goto Block_4;
			}
			IL_190:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageToneSignalingList).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
			return;
			Block_4:
			num = (short)494600192;
			short num4 = num;
			IL_1F6:
			num = (short)1728184321;
			if (num != 0)
			{
			}
			num = (short)597426176;
			if (num != 0)
			{
			}
		}

		// Token: 0x060052EC RID: 21228 RVA: 0x004B42BC File Offset: 0x004B24BC
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 18;
			short num = (short)1739194368;
			switch (num)
			{
			default:
			{
				num = (short)1218904070;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_296;
					case 1:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource = this.RecNavToolbarPageToneSignalingList.MyRecordsetDataSource;
						num = (short)831434089;
						short num3 = num;
						num = (short)798469481;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2D1;
						default:
							num = (short)1939603456;
							if (num != 0)
							{
							}
							num = (short)2032402439;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						num = (short)1082589185;
						if (num != 0)
						{
						}
						num = (short)1851523094;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_26B;
					case 4:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("臒냔듖韘뫚ꯜ诞軠賢觤藦裨駪뷬軮雰雲ꇴ飶韸黺껼雾昀洂搄欆怈攊樌䌎砐怒愔", a_))
						{
							num = (short)1425604609;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2EF;
					case 5:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("臒냔듖韘뫚ꯜ诞軠賢觤藦裨駪꣬韮臰鋲鯴鏶鳸觺ꧼ郾漀昂嘄渆済攊氌挎砐紒爔嬖瀘栚検帞删圢圤䠦栨䜪䠬崮䔰娲嬴倶洸吺匼娾ᕀ≂❄⭆ⱈ", a_))
						{
							num = (short)2007629826;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_AA;
						}
						continue;
					case 7:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource;
						if (myRecordsetDataSource != null)
						{
							num = (short)435617792;
							short num4 = num;
							num = (short)1063780370;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2EF;
					}
					case 8:
					{
						object myRecordsetDataSource2;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource2);
						global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.AstroAlertingToneTableInner astroAlertingToneTableInner = (global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.AstroAlertingToneTableInner)collectionView.CurrentItem;
						num = (short)2024472589;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						num = (short)1983905802;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						global::System.Windows.Data.CollectionView collectionView;
						if (collectionView.IsCurrentAfterLast)
						{
							num = (short)910753803;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						collectionView.MoveCurrentToFirst();
						num = (short)1777336340;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						global::System.Windows.Data.CollectionView collectionView;
						collectionView.MoveCurrentToLast();
						num = (short)1584332803;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						global::System.Windows.Data.CollectionView collectionView;
						global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.AstroAlertingToneTableInner astroAlertingToneTableInner;
						collectionView.MoveCurrentTo(astroAlertingToneTableInner);
						num = (short)387186704;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.AstroAlertingToneTableInner astroAlertingToneTableInner;
						if (astroAlertingToneTableInner != null)
						{
							goto IL_2D1;
						}
						num = (short)296615953;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						num = (short)1229324292;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						object myRecordsetDataSource2;
						if (myRecordsetDataSource2 != null)
						{
							num = (short)1104216072;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 16:
						goto IL_131;
					case 17:
					{
						global::System.Windows.Data.CollectionView collectionView;
						if (collectionView.Count > 0)
						{
							num = (short)840957961;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_345;
					}
					case 18:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource;
						base.NavigationService.Navigate(new global::System.Uri(myRecordsetDataSource.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
						num = (short)97845267;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						goto IL_2EF;
					case 20:
						goto IL_18C;
					case 21:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource2 = this.RecNavToolbarExpanderToneSignalingListAstroAlertingToneTable.MyRecordsetDataSource;
						num = (short)1898315791;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)182583317;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)1014628352;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_AA:
					if (A_0 is global::AcpUI.AcpRecNavToolbar)
					{
						num = (short)1990066190;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_2D1:
					num = (short)2114256908;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2EF:
					num = (short)1945305093;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_131:
				IL_18C:
				IL_26B:
				goto IL_345;
				IL_296:
				return;
				IL_345:
				((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
				return;
			}
			}
		}

		// Token: 0x060052ED RID: 21229 RVA: 0x004B476C File Offset: 0x004B296C
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1133838337;
			if (num != 0)
			{
			}
			num = (short)678232064;
			short num2 = num;
			num = (short)1566628066;
			short num3 = num;
			num = (short)1841879266;
			switch (num3 == num)
			{
			}
			num = (short)2070085632;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x060052EE RID: 21230 RVA: 0x004B481C File Offset: 0x004B2A1C
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1465335285;
			short num2 = num;
			num = (short)1454587381;
			switch (num2 == num)
			{
			}
			num = (short)498925569;
			if (num != 0)
			{
			}
			num = (short)2097676288;
			if (num != 0)
			{
			}
			num = (short)636223488;
			short num3 = num;
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x060052EF RID: 21231 RVA: 0x004B48CC File Offset: 0x004B2ACC
		internal void OnExpanderToneSignalingListAstroAlertingToneTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.AstroAlertingToneTableInner item;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_151;
				case 1:
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderToneSignalingListAstroAlertingToneTable.SyncDataSources();
					num2 = (short)1721303040;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (myRecordsetDataSource != null)
					{
						num2 = (short)1589706753;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_153;
				}
				goto IL_1C;
			}
			IL_151:
			goto IL_153;
			IL_1C:
			num2 = (short)113180672;
			short num3 = num2;
			num2 = (short)400621569;
			if (num2 != 0)
			{
			}
			item = (global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.AstroAlertingToneTableInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderToneSignalingListAstroAlertingToneTable.MyRecordsetDataSource;
			num2 = (short)1242516613;
			short num4 = num2;
			num2 = (short)1476938885;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_153:
				this.RecNavToolbarExpanderToneSignalingListAstroAlertingToneTable.TableMode = false;
				return;
			default:
			{
				num2 = (short)684916736;
				if (num2 != 0)
				{
				}
				num2 = (short)341704706;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060052F0 RID: 21232 RVA: 0x004B4A38 File Offset: 0x004B2C38
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 9;
			if (this.b)
			{
				short num = (short)362020864;
				short num2 = num;
				num = (short)1223723131;
				short num3 = num;
				num = (short)1815971963;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)786759681;
					if (num != 0)
					{
					}
					num = (short)1585905664;
					if (num != 0)
					{
					}
					return;
				}
			}
			this.b = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("跋ꋍ볏铑뇓럕곗꿙껛믝鏟\ud9e1蟣觥藧髩菫胭闯鳱胳\ud9f5諷鯹飻韽濿✁㘃㘅洇砉欋愍縏紑礓缕笗椙㤛Ⱍဟ䄡䬣䠥丧䌩䬫嬭䈯匱䀳張圷吹ጻ䨽⼿ⱁ⅃捅穇穉㽋❍㝏㱑㕓㩕ㅗ㑙㭛筝剟剡ݣ॥٧౩ի७կqᕳɵᅷᕹቻ兽궇뢉벋ﶍ憐望劣薟邡钣쪥솧\ud9a9\ud8ab膭쒯\uddb1\udab3펵쮷펹\udbbb킽ꆿ껁귃ꣅ꿇ꛉꗋ뷍꓏ﳑ곓럕뗗뛙", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060052F1 RID: 21233 RVA: 0x004B4B1C File Offset: 0x004B2D1C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)118358018;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_2CF;
				case 1:
					num = (short)158138368;
					num2 = (int)((global::System.IntPtr)num);
					continue;
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
					goto IL_7AA;
				case 2:
					goto IL_3F3;
				case 3:
				case 4:
				case 5:
				case 6:
				case 7:
				case 8:
				case 9:
				case 10:
				case 11:
					goto IL_95C;
				case 12:
					goto IL_4C7;
				case 13:
					goto IL_871;
				case 14:
					goto IL_790;
				case 15:
					goto IL_51F;
				case 16:
					goto IL_895;
				case 17:
					goto IL_79D;
				case 18:
					goto IL_5D2;
				case 19:
					goto IL_4EE;
				case 20:
					goto IL_20A;
				case 21:
					goto IL_4BA;
				case 22:
					goto IL_2F8;
				case 23:
					goto IL_783;
				case 24:
					goto IL_52C;
				case 25:
					goto IL_2D4;
				case 26:
					goto IL_59E;
				case 27:
					goto IL_1F0;
				case 28:
					goto IL_38E;
				case 29:
					goto IL_7DB;
				case 30:
					goto IL_26C;
				case 31:
					goto IL_305;
				case 32:
					goto IL_3CC;
				case 33:
					goto IL_3D9;
				case 34:
					goto IL_4E1;
				case 35:
					goto IL_3BF;
				case 36:
					goto IL_381;
				case 37:
					goto IL_55D;
				case 38:
					goto IL_928;
				case 39:
					goto IL_8F7;
				case 40:
					goto IL_46F;
				case 41:
					goto IL_81C;
				case 42:
					goto IL_4A0;
				case 43:
					goto IL_343;
				case 44:
					goto IL_350;
				case 45:
					goto IL_5B8;
				case 46:
					goto IL_6BA;
				case 47:
					goto IL_2AA;
				case 48:
					goto IL_64B;
				case 49:
					goto IL_627;
				case 50:
					goto IL_7E8;
				case 51:
					goto IL_658;
				case 52:
					goto IL_417;
				case 53:
					goto IL_6AD;
				case 54:
					goto IL_3E6;
				case 55:
					goto IL_8D3;
				case 56:
					goto IL_8C6;
				case 57:
					goto IL_67C;
				case 58:
					goto IL_5C5;
				case 59:
					goto IL_1E3;
				case 60:
					goto IL_25F;
				case 61:
					goto IL_603;
				case 62:
					goto IL_5AB;
				case 63:
					goto IL_738;
				case 64:
					goto IL_550;
				case 65:
					goto IL_374;
				case 66:
					goto IL_6DE;
				case 67:
					goto IL_829;
				case 68:
					goto IL_8B9;
				case 69:
					goto IL_22E;
				case 70:
					goto IL_1D6;
				case 71:
					goto IL_80F;
				case 72:
					goto IL_802;
				case 73:
					goto IL_5DF;
				case 74:
					goto IL_577;
				case 75:
					goto IL_47C;
				case 76:
					goto IL_7F5;
				case 77:
					goto IL_512;
				case 78:
					goto IL_336;
				case 79:
					goto IL_6EB;
				case 80:
					goto IL_1FD;
				case 81:
					goto IL_39B;
				case 82:
					goto IL_584;
				case 83:
					goto IL_56A;
				case 84:
					goto IL_94F;
				case 85:
					goto IL_279;
				case 86:
					goto IL_4AD;
				case 87:
					goto IL_312;
				case 88:
					goto IL_591;
				case 89:
					goto IL_252;
				case 90:
					goto IL_4D4;
				case 91:
					goto IL_84D;
				case 92:
					goto IL_6A0;
				case 93:
					goto IL_904;
				case 94:
					goto IL_29D;
				case 95:
					goto IL_942;
				case 96:
					goto IL_935;
				default:
					num = (short)1437466625;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_1D6:
			this.RTDBtnRadErgoAstroAlertingToneTableAlertTone = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1E3:
			this.CpyBtnRadErgoAstroAlertingToneTableTone2Freq = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1F0:
			this.CpyBtnRadErgoAstroAlertingToneListType_A43068 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1FD:
			this.CVBtnRadErgoAstroAlertingToneTableToneFreq_A43069 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_20A:
			this.RadErgoAstroAlertingToneTableAstroAlertingToneTableAlias = (global::AcpUI.AcpTextBox)target;
			this.RadErgoAstroAlertingToneTableAstroAlertingToneTableAlias.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_22E:
			this.LblRadErgoAstroAlertingToneTableAlertTone = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoAstroAlertingToneTableAlertTone.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_252:
			this.CpyBtnRadErgoAstroAlertingToneTableToneDuration_A43070 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_25F:
			this.RadErgoAstroAlertingToneTableTone2FreqComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_26C:
			this.ExpanderToneSignalingListAstroAlertingToneTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_279:
			this.RadErgoAstroAlertingToneTableToneDuration_A43070 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadErgoAstroAlertingToneTableToneDuration_A43070.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_29D:
			this.RTDBtnRadErgoAstroAlertingToneTableTonePretime_A43071 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2AA:
			this.CpyBtnRadErgoAstroAlertingToneTableToneAliasText_42533 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2CF:
			goto IL_95C;
			IL_2D4:
			this.RadErgoAstroAlertingToneListType_A43068 = (global::AcpUI.AcpComboBox)target;
			this.RadErgoAstroAlertingToneListType_A43068.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2F8:
			this.RadErgoAstroAlertingToneTableAstroAlertingToneTableAliasComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_305:
			this.ExpanderToneSignalingListAstroAlertingToneTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_312:
			this.LblRadErgoAstroAlertingToneTableToneDuration_A43070 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoAstroAlertingToneTableToneDuration_A43070.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_336:
			this.RadErgoAstroAlertingToneTableExternalControlComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_343:
			this.gridExpanderToneSignalingListAstroAlertingToneTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_350:
			this.RadErgoAstroAlertingToneTableToneAliasText_42533 = (global::AcpUI.AcpTextBox)target;
			this.RadErgoAstroAlertingToneTableToneAliasText_42533.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_374:
			this.CpyBtnRadErgoAstroAlertingToneTableUnmuteEnable = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_381:
			this.RadErgoAstroAlertingToneTableUnmuteEnable_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_38E:
			this.RadErgoAstroAlertingToneListType_A43068Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_39B:
			this.LblRadErgoAstroAlertingToneTableToneFreq_A43069 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoAstroAlertingToneTableToneFreq_A43069.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3BF:
			this.RadErgoAstroAlertingToneTableTone2Freq_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_3CC:
			this.ExpanderToneSignalingListAstroAlertingToneTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_3D9:
			this.RadErgoAstroAlertingToneTableToneAliasText_42533_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_3E6:
			this.RadErgoAstroAlertingToneTableTone1FreqComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3F3:
			this.RecNavToolbarPageToneSignalingList = (global::AcpUI.AcpParentRecNavToolbar)target;
			this.RecNavToolbarPageToneSignalingList.ModeClick += this.OnModeClick;
			return;
			IL_417:
			num = (short)249444808;
			short num3 = num;
			num = (short)280181192;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_374;
			default:
				num = (short)1589575680;
				if (num != 0)
				{
				}
				this.RTDBtnRadErgoAstroAlertingToneTableTone1Freq = (global::AcpUI.AcpRtdButton)target;
				return;
			}
			IL_46F:
			this.RadErgoAstroAlertingToneTableToneDuration_A43070_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_47C:
			this.LblRadErgoAstroAlertingToneTableExternalControl = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoAstroAlertingToneTableExternalControl.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4A0:
			this.ExpanderToneSignalingListAstroAlertingToneTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_4AD:
			this.CVBtnRadErgoAstroAlertingToneTableToneDuration_A43070 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4BA:
			this.CpyBtnRadErgoAstroAlertingToneTableAstroAlertingToneTableAlias = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4C7:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_4D4:
			this.RadErgoAstroAlertingToneTableToneDuration_A43070Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4E1:
			this.RadErgoAstroAlertingToneTableTone1Freq_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_4EE:
			this.LblRadErgoAstroAlertingToneTableAstroAlertingToneTableAlias = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoAstroAlertingToneTableAstroAlertingToneTableAlias.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_512:
			this.CpyBtnRadErgoAstroAlertingToneTableExternalControl = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_51F:
			this.ExpanderToneSignalingListAstroAlertingToneListExpander = (global::AcpUI.AcpExpander)target;
			return;
			IL_52C:
			this.LblRadErgoAstroAlertingToneListType_A43068 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoAstroAlertingToneListType_A43068.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_550:
			this.RTDBtnRadErgoAstroAlertingToneTableUnmuteEnable = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_55D:
			this.RadErgoAstroAlertingToneTableAlertTone_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_56A:
			this.CpyBtnRadErgoAstroAlertingToneTableToneFreq_A43069 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_577:
			this.CVBtnRadErgoAstroAlertingToneTableExternalControl = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_584:
			this.RTDBtnRadErgoAstroAlertingToneTableToneFreq_A43069 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_591:
			this.RTDBtnRadErgoAstroAlertingToneTableToneDuration_A43070 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_59E:
			this.RTDBtnRadErgoAstroAlertingToneListType_A43068 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5AB:
			this.CVBtnRadErgoAstroAlertingToneTableUnmuteEnable = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5B8:
			this.CVBtnRadErgoAstroAlertingToneTableToneAliasText_42533 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5C5:
			this.RTDBtnRadErgoAstroAlertingToneTableTone2Freq = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5D2:
			this.CVBtnRadErgoAstroAlertingToneTableAstroAlertingToneTableAlias = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5DF:
			this.RadErgoAstroAlertingToneTableExternalControl = (global::AcpUI.AcpComboBox)target;
			this.RadErgoAstroAlertingToneTableExternalControl.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_603:
			this.RadErgoAstroAlertingToneTableUnmuteEnable = (global::AcpUI.AcpCheckBox)target;
			this.RadErgoAstroAlertingToneTableUnmuteEnable.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_627:
			this.RadErgoAstroAlertingToneTableTone1Freq = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadErgoAstroAlertingToneTableTone1Freq.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_64B:
			this.RadErgoAstroAlertingToneTableToneAliasText_42533Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_658:
			this.LblRadErgoAstroAlertingToneTableTone1Freq = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoAstroAlertingToneTableTone1Freq.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_67C:
			this.LblRadErgoAstroAlertingToneTableTone2Freq = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoAstroAlertingToneTableTone2Freq.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_6A0:
			this.CVBtnRadErgoAstroAlertingToneTableTonePretime_A43071 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6AD:
			this.CpyBtnRadErgoAstroAlertingToneTableTone1Freq = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_6BA:
			this.LblRadErgoAstroAlertingToneTableToneAliasText_42533 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoAstroAlertingToneTableToneAliasText_42533.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_6DE:
			this.RadErgoAstroAlertingToneTableUnmuteEnableComp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_6EB:
			num = (short)1238433792;
			short num4 = num;
			this.RadErgoAstroAlertingToneTableToneFreq_A43069 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadErgoAstroAlertingToneTableToneFreq_A43069.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_738:
			num = (short)766509057;
			if (num != 0)
			{
			}
			this.LblRadErgoAstroAlertingToneTableUnmuteEnable = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoAstroAlertingToneTableUnmuteEnable.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_783:
			this.CVBtnRadErgoAstroAlertingToneListType_A43068 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_790:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_79D:
			this.GrpBoxExpanderToneSignalingListAstroAlertingToneListExpanderPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_7AA:
			((global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.PageToneSignalingList)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.PageToneSignalingList)target).Unloaded += this.OnUnloaded;
			return;
			IL_7DB:
			this.ExpanderToneSignalingListAstroAlertingToneListExpanderGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_7E8:
			this.CVBtnRadErgoAstroAlertingToneTableTone1Freq = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_7F5:
			this.RTDBtnRadErgoAstroAlertingToneTableExternalControl = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_802:
			this.RadErgoAstroAlertingToneTableAlertToneComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_80F:
			this.CpyBtnRadErgoAstroAlertingToneTableAlertTone = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_81C:
			this.RadErgoAstroAlertingToneTableTonePretime_A43071_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_829:
			this.RadErgoAstroAlertingToneTableAlertTone = (global::AcpUI.AcpComboBox)target;
			this.RadErgoAstroAlertingToneTableAlertTone.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_84D:
			this.RadErgoAstroAlertingToneTableTonePretime_A43071 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadErgoAstroAlertingToneTableTonePretime_A43071.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_871:
			this.HLinkAstroAlertingToneListExpander = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkAstroAlertingToneListExpander.Click += this.HLinkClick;
			return;
			IL_895:
			this.RecNavToolbarExpanderToneSignalingListAstroAlertingToneTable = (global::AcpUI.AcpChildRecNavToolbar)target;
			this.RecNavToolbarExpanderToneSignalingListAstroAlertingToneTable.ModeClick += this.OnModeClick;
			return;
			IL_8B9:
			this.CVBtnRadErgoAstroAlertingToneTableAlertTone = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_8C6:
			this.CVBtnRadErgoAstroAlertingToneTableTone2Freq = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_8D3:
			this.RadErgoAstroAlertingToneTableTone2Freq = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadErgoAstroAlertingToneTableTone2Freq.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_8F7:
			this.RadErgoAstroAlertingToneTableToneFreq_A43069_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_904:
			this.LblRadErgoAstroAlertingToneTableTonePretime_A43071 = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoAstroAlertingToneTableTonePretime_A43071.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_928:
			this.RadErgoAstroAlertingToneTableExternalControl_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_935:
			this.RadErgoAstroAlertingToneTableTonePretime_A43071Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_942:
			this.CpyBtnRadErgoAstroAlertingToneTableTonePretime_A43071 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_94F:
			this.RadErgoAstroAlertingToneTableToneFreq_A43069Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_95C:
			this.b = true;
		}

		// Token: 0x060052F2 RID: 21234 RVA: 0x004B548C File Offset: 0x004B368C
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num;
			switch (connectionId)
			{
			case 3:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 4:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 5:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 6:
			{
				num = (short)1328283649;
				if (num != 0)
				{
				}
				num = (short)750159320;
				short num2 = num;
				num = (short)528319960;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1752891392;
					if (num != 0)
					{
					}
					((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				}
				break;
			}
			case 7:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 8:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 9:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 10:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 11:
				break;
			default:
				return;
			}
			num = (short)261357568;
			short num3 = num;
			((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x04001F46 RID: 8006
		private bool a;

		// Token: 0x04001F47 RID: 8007
		internal global::AcpUI.AcpParentRecNavToolbar RecNavToolbarPageToneSignalingList;

		// Token: 0x04001F48 RID: 8008
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x04001F49 RID: 8009
		internal global::System.Windows.Documents.Hyperlink HLinkAstroAlertingToneListExpander;

		// Token: 0x04001F4A RID: 8010
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x04001F4B RID: 8011
		internal global::AcpUI.AcpExpander ExpanderToneSignalingListAstroAlertingToneListExpander;

		// Token: 0x04001F4C RID: 8012
		internal global::AcpUI.AcpChildRecNavToolbar RecNavToolbarExpanderToneSignalingListAstroAlertingToneTable;

		// Token: 0x04001F4D RID: 8013
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderToneSignalingListAstroAlertingToneListExpanderPseudo0;

		// Token: 0x04001F4E RID: 8014
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoAstroAlertingToneTableAstroAlertingToneTableAlias;

		// Token: 0x04001F4F RID: 8015
		internal global::AcpUI.AcpLabel LblRadErgoAstroAlertingToneTableAstroAlertingToneTableAlias;

		// Token: 0x04001F50 RID: 8016
		internal global::AcpUI.AcpTextBox RadErgoAstroAlertingToneTableAstroAlertingToneTableAlias;

		// Token: 0x04001F51 RID: 8017
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoAstroAlertingToneTableAstroAlertingToneTableAlias;

		// Token: 0x04001F52 RID: 8018
		internal global::AcpUI.AcpLabel RadErgoAstroAlertingToneTableAstroAlertingToneTableAliasComp;

		// Token: 0x04001F53 RID: 8019
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoAstroAlertingToneListType_A43068;

		// Token: 0x04001F54 RID: 8020
		internal global::AcpUI.AcpLabel LblRadErgoAstroAlertingToneListType_A43068;

		// Token: 0x04001F55 RID: 8021
		internal global::AcpUI.AcpComboBox RadErgoAstroAlertingToneListType_A43068;

		// Token: 0x04001F56 RID: 8022
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoAstroAlertingToneListType_A43068;

		// Token: 0x04001F57 RID: 8023
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoAstroAlertingToneListType_A43068;

		// Token: 0x04001F58 RID: 8024
		internal global::AcpUI.AcpLabel RadErgoAstroAlertingToneListType_A43068Comp;

		// Token: 0x04001F59 RID: 8025
		internal global::System.Windows.Controls.Grid ExpanderToneSignalingListAstroAlertingToneListExpanderGrid;

		// Token: 0x04001F5A RID: 8026
		internal global::System.Windows.Controls.Grid ExpanderToneSignalingListAstroAlertingToneTableGrid;

		// Token: 0x04001F5B RID: 8027
		internal global::AcpUI.AcpGroupBox ExpanderToneSignalingListAstroAlertingToneTableTableView;

		// Token: 0x04001F5C RID: 8028
		internal global::AcpUI.AcpXamDataPresenter ExpanderToneSignalingListAstroAlertingToneTable;

		// Token: 0x04001F5D RID: 8029
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoAstroAlertingToneTableToneAliasText_42533_Col;

		// Token: 0x04001F5E RID: 8030
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoAstroAlertingToneTableTone1Freq_Col;

		// Token: 0x04001F5F RID: 8031
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoAstroAlertingToneTableTone2Freq_Col;

		// Token: 0x04001F60 RID: 8032
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoAstroAlertingToneTableUnmuteEnable_Col;

		// Token: 0x04001F61 RID: 8033
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoAstroAlertingToneTableAlertTone_Col;

		// Token: 0x04001F62 RID: 8034
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoAstroAlertingToneTableExternalControl_Col;

		// Token: 0x04001F63 RID: 8035
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoAstroAlertingToneTableToneFreq_A43069_Col;

		// Token: 0x04001F64 RID: 8036
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoAstroAlertingToneTableToneDuration_A43070_Col;

		// Token: 0x04001F65 RID: 8037
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadErgoAstroAlertingToneTableTonePretime_A43071_Col;

		// Token: 0x04001F66 RID: 8038
		internal global::AcpUI.AcpGroupBox ExpanderToneSignalingListAstroAlertingToneTableSRecView;

		// Token: 0x04001F67 RID: 8039
		internal global::System.Windows.Controls.Grid gridExpanderToneSignalingListAstroAlertingToneTableSRecView;

		// Token: 0x04001F68 RID: 8040
		internal global::AcpUI.AcpTextBox RadErgoAstroAlertingToneTableToneAliasText_42533;

		// Token: 0x04001F69 RID: 8041
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoAstroAlertingToneTableToneAliasText_42533;

		// Token: 0x04001F6A RID: 8042
		internal global::AcpUI.AcpLabel LblRadErgoAstroAlertingToneTableToneAliasText_42533;

		// Token: 0x04001F6B RID: 8043
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoAstroAlertingToneTableToneAliasText_42533;

		// Token: 0x04001F6C RID: 8044
		internal global::AcpUI.AcpLabel RadErgoAstroAlertingToneTableToneAliasText_42533Comp;

		// Token: 0x04001F6D RID: 8045
		internal global::AcpUI.AcpTextBoxSpinner RadErgoAstroAlertingToneTableTone1Freq;

		// Token: 0x04001F6E RID: 8046
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoAstroAlertingToneTableTone1Freq;

		// Token: 0x04001F6F RID: 8047
		internal global::AcpUI.AcpLabel LblRadErgoAstroAlertingToneTableTone1Freq;

		// Token: 0x04001F70 RID: 8048
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoAstroAlertingToneTableTone1Freq;

		// Token: 0x04001F71 RID: 8049
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoAstroAlertingToneTableTone1Freq;

		// Token: 0x04001F72 RID: 8050
		internal global::AcpUI.AcpLabel RadErgoAstroAlertingToneTableTone1FreqComp;

		// Token: 0x04001F73 RID: 8051
		internal global::AcpUI.AcpTextBoxSpinner RadErgoAstroAlertingToneTableTone2Freq;

		// Token: 0x04001F74 RID: 8052
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoAstroAlertingToneTableTone2Freq;

		// Token: 0x04001F75 RID: 8053
		internal global::AcpUI.AcpLabel LblRadErgoAstroAlertingToneTableTone2Freq;

		// Token: 0x04001F76 RID: 8054
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoAstroAlertingToneTableTone2Freq;

		// Token: 0x04001F77 RID: 8055
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoAstroAlertingToneTableTone2Freq;

		// Token: 0x04001F78 RID: 8056
		internal global::AcpUI.AcpLabel RadErgoAstroAlertingToneTableTone2FreqComp;

		// Token: 0x04001F79 RID: 8057
		internal global::AcpUI.AcpCheckBox RadErgoAstroAlertingToneTableUnmuteEnable;

		// Token: 0x04001F7A RID: 8058
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoAstroAlertingToneTableUnmuteEnable;

		// Token: 0x04001F7B RID: 8059
		internal global::AcpUI.AcpLabel LblRadErgoAstroAlertingToneTableUnmuteEnable;

		// Token: 0x04001F7C RID: 8060
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoAstroAlertingToneTableUnmuteEnable;

		// Token: 0x04001F7D RID: 8061
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoAstroAlertingToneTableUnmuteEnable;

		// Token: 0x04001F7E RID: 8062
		internal global::AcpUI.AcpCheckBox RadErgoAstroAlertingToneTableUnmuteEnableComp;

		// Token: 0x04001F7F RID: 8063
		internal global::AcpUI.AcpComboBox RadErgoAstroAlertingToneTableAlertTone;

		// Token: 0x04001F80 RID: 8064
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoAstroAlertingToneTableAlertTone;

		// Token: 0x04001F81 RID: 8065
		internal global::AcpUI.AcpLabel LblRadErgoAstroAlertingToneTableAlertTone;

		// Token: 0x04001F82 RID: 8066
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoAstroAlertingToneTableAlertTone;

		// Token: 0x04001F83 RID: 8067
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoAstroAlertingToneTableAlertTone;

		// Token: 0x04001F84 RID: 8068
		internal global::AcpUI.AcpLabel RadErgoAstroAlertingToneTableAlertToneComp;

		// Token: 0x04001F85 RID: 8069
		internal global::AcpUI.AcpComboBox RadErgoAstroAlertingToneTableExternalControl;

		// Token: 0x04001F86 RID: 8070
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoAstroAlertingToneTableExternalControl;

		// Token: 0x04001F87 RID: 8071
		internal global::AcpUI.AcpLabel LblRadErgoAstroAlertingToneTableExternalControl;

		// Token: 0x04001F88 RID: 8072
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoAstroAlertingToneTableExternalControl;

		// Token: 0x04001F89 RID: 8073
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoAstroAlertingToneTableExternalControl;

		// Token: 0x04001F8A RID: 8074
		internal global::AcpUI.AcpLabel RadErgoAstroAlertingToneTableExternalControlComp;

		// Token: 0x04001F8B RID: 8075
		internal global::AcpUI.AcpTextBoxSpinner RadErgoAstroAlertingToneTableToneFreq_A43069;

		// Token: 0x04001F8C RID: 8076
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoAstroAlertingToneTableToneFreq_A43069;

		// Token: 0x04001F8D RID: 8077
		internal global::AcpUI.AcpLabel LblRadErgoAstroAlertingToneTableToneFreq_A43069;

		// Token: 0x04001F8E RID: 8078
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoAstroAlertingToneTableToneFreq_A43069;

		// Token: 0x04001F8F RID: 8079
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoAstroAlertingToneTableToneFreq_A43069;

		// Token: 0x04001F90 RID: 8080
		internal global::AcpUI.AcpLabel RadErgoAstroAlertingToneTableToneFreq_A43069Comp;

		// Token: 0x04001F91 RID: 8081
		internal global::AcpUI.AcpTextBoxSpinner RadErgoAstroAlertingToneTableToneDuration_A43070;

		// Token: 0x04001F92 RID: 8082
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoAstroAlertingToneTableToneDuration_A43070;

		// Token: 0x04001F93 RID: 8083
		internal global::AcpUI.AcpLabel LblRadErgoAstroAlertingToneTableToneDuration_A43070;

		// Token: 0x04001F94 RID: 8084
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoAstroAlertingToneTableToneDuration_A43070;

		// Token: 0x04001F95 RID: 8085
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoAstroAlertingToneTableToneDuration_A43070;

		// Token: 0x04001F96 RID: 8086
		internal global::AcpUI.AcpLabel RadErgoAstroAlertingToneTableToneDuration_A43070Comp;

		// Token: 0x04001F97 RID: 8087
		internal global::AcpUI.AcpTextBoxSpinner RadErgoAstroAlertingToneTableTonePretime_A43071;

		// Token: 0x04001F98 RID: 8088
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoAstroAlertingToneTableTonePretime_A43071;

		// Token: 0x04001F99 RID: 8089
		internal global::AcpUI.AcpLabel LblRadErgoAstroAlertingToneTableTonePretime_A43071;

		// Token: 0x04001F9A RID: 8090
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoAstroAlertingToneTableTonePretime_A43071;

		// Token: 0x04001F9B RID: 8091
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoAstroAlertingToneTableTonePretime_A43071;

		// Token: 0x04001F9C RID: 8092
		internal global::AcpUI.AcpLabel RadErgoAstroAlertingToneTableTonePretime_A43071Comp;

		// Token: 0x04001F9D RID: 8093
		private bool b;
	}
}
