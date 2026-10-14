using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using System.Windows.Navigation;
using AcpCommonLib;
using AcpUI.Common;
using CommonResources;
using DevComponents.WpfDock;
using DevComponents.WpfRibbon;
using MackinawCPS.HomeBase;
using PreEmptive.SoS.Runtime;

namespace MackinawCPS
{
	// Token: 0x02000039 RID: 57
	public partial class PageNavPaneButtons : Page
	{
		// Token: 0x06000162 RID: 354 RVA: 0x00046A14 File Offset: 0x00044C14
		internal void OnButtonClick(object sender, RoutedEventArgs e)
		{
			int a_ = 12;
			short num = (short)68747264;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_E0;
				}
				WindowMain windowMain;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
						if (this.FrameHome.Content != null)
						{
							num = (short)637075467;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1C0;
					case 1:
						goto IL_583;
					case 2:
						goto IL_1FD;
					case 3:
						goto IL_425;
					case 4:
						goto IL_21C;
					case 5:
						if (sender == this.ButtonCustomViewMode)
						{
							num = (short)372244490;
							num2 = (int)((IntPtr)num);
							continue;
						}
						MessageBox.Show(AppResources.PageNavPaneButtons_OnButtonClick);
						num = (short)599195651;
						num2 = (int)((IntPtr)num);
						continue;
					case 6:
						goto IL_5A3;
					case 7:
						goto IL_140;
					case 8:
					{
						num = (short)475791360;
						short num3 = num;
						AppInfoManager.AppMode = ApplicationMode.CodeplugConfigurationMode;
						bool flag = windowMain.CpgOpenFlag;
						num = (short)493158423;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 9:
						goto IL_5E7;
					case 10:
						AppInfoManager.AppMode = ApplicationMode.CustomViewConfigurationMode;
						windowMain.ribbonTabCustomViewCfgMode.IsSelected = true;
						AppInfoManager.ClearNavigationHistory = true;
						windowMain.FrameCenterTop.Navigate(new Uri(FixedLengthStream.b("꿫鯭華蛱鯳鯵껷鏹駻觽⿿刁攃愅洇䤉礋納搏紑礓䀕焗缙欛䤝䔟両䜣䤥䔧伩ȫ嘭儯弱堳", a_), UriKind.RelativeOrAbsolute));
						num = (short)741081107;
						num2 = (int)((IntPtr)num);
						continue;
					case 11:
						num = (short)1142030370;
						num2 = (int)((IntPtr)num);
						continue;
					case 12:
						goto IL_7E2;
					case 13:
					{
						windowMain.ribbonTabCodeplug.IsSelected = true;
						DockWindow dockWindow = windowMain.GetPageIUI.GetDockWindow(DockWndType.Naviagtion);
						num = (short)1668874264;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 14:
					{
						bool flag;
						if (flag)
						{
							num = (short)1450311693;
							num2 = (int)((IntPtr)num);
							continue;
						}
						this.ButtonHome.IsSelected = true;
						this.ButtonCpgNav.IsSelected = false;
						e.Handled = true;
						num = (short)270794770;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 15:
						if (sender == this.ButtonCpgNav)
						{
							num = (short)1617756168;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)966787077;
						num2 = (int)((IntPtr)num);
						continue;
					case 16:
						goto IL_35C;
					case 17:
					{
						num = (short)578134132;
						short num4 = num;
						num = (short)548708468;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_17F;
						default:
						{
							num = (short)1717436416;
							if (num != 0)
							{
							}
							bool flag = windowMain.OpenCodeplug(null, null, null);
							num = (short)824836108;
							num2 = (int)((IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 18:
						goto IL_3FD;
					case 19:
						goto IL_2FD;
					case 20:
						goto IL_53D;
					case 21:
					{
						DockWindow dockWindow;
						DockSite.SetDockSize((SplitPanel)((DockWindowGroup)dockWindow.Parent).Parent, 220.0);
						num = (short)570490902;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 22:
						goto IL_81E;
					case 23:
					{
						bool flag;
						if (!flag)
						{
							num = (short)267583505;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_7E2;
					}
					case 24:
					{
						DockWindow dockWindow;
						if (!dockWindow.IsAutoHide)
						{
							num = (short)2018836511;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_81E;
					}
					case 25:
						num = (short)1872494628;
						num2 = (int)((IntPtr)num);
						continue;
					case 26:
					{
						DockWindow dockWindow2;
						if (!dockWindow2.IsAutoHide)
						{
							num = (short)1731264552;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_53D;
					}
					case 27:
						goto IL_1C0;
					case 28:
						if (this.FrameCodeplug.Content != null)
						{
							num = (short)1221656601;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_140;
					case 29:
						num = (short)1629683713;
						if (num != 0)
						{
						}
						if (this.bNavigateToContentPage)
						{
							num = (short)176685091;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_583;
					case 30:
					{
						DockWindow dockWindow;
						if (!dockWindow.IsFloating)
						{
							num = (short)1563885589;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_81E;
					}
					case 31:
						goto IL_17F;
					case 32:
						windowMain.FrameCenterTop.Navigate(new Uri(FeatureManager.GetFeature(2049).UIPagePath, UriKind.RelativeOrAbsolute));
						num = (short)1302855682;
						num2 = (int)((IntPtr)num);
						continue;
					case 33:
						if (sender == this.ButtonHome)
						{
							num = (short)777257001;
							num2 = (int)((IntPtr)num);
							continue;
						}
						num = (short)1893007375;
						num2 = (int)((IntPtr)num);
						continue;
					case 34:
						if (!(this.FrameHome.Content is PageWelcomeTreeView))
						{
							num = (short)47972379;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_35C;
					case 35:
						windowMain.FrameCenterTop.Navigate(new Uri(FixedLengthStream.b("ꓫ臭鷯韱뛳韵请鿹폻껽懿攁愃儅洇昉漋愍紏眑㨓渕礗眙瀛", a_), UriKind.RelativeOrAbsolute));
						num = (short)139919361;
						num2 = (int)((IntPtr)num);
						continue;
					case 36:
						if (!(this.FrameCodeplug.Content is PageTreeView))
						{
							num = (short)1534263303;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_5E7;
					case 37:
						if (this.bNavigateToContentPage)
						{
							num = (short)1107820576;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_1FD;
					case 38:
					{
						DockWindow dockWindow2;
						DockSite.SetDockSize((SplitPanel)((DockWindowGroup)dockWindow2.Parent).Parent, 300.0);
						num = (short)939786260;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 39:
					{
						DockWindow dockWindow2;
						if (!dockWindow2.IsFloating)
						{
							num = (short)1386938406;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_53D;
					}
					case 40:
						num = (short)963969063;
						num2 = (int)((IntPtr)num);
						continue;
					case 41:
					{
						AppInfoManager.AppMode = ApplicationMode.CodeplugConfigurationMode;
						windowMain.ribbonTabCodeplug.IsSelected = true;
						DockWindow dockWindow2 = windowMain.GetPageIUI.GetDockWindow(DockWndType.Naviagtion);
						num = (short)977731610;
						num2 = (int)((IntPtr)num);
						continue;
					}
					}
					goto IL_E0;
					IL_140:
					this.FrameCodeplug.Navigate(new Uri(FixedLengthStream.b("볫迭韯韱ꃳ蓵鷷鿹꫻韽旿甁⨃縅椇有怋", a_), UriKind.RelativeOrAbsolute));
					num = (short)800653321;
					num2 = (int)((IntPtr)num);
					continue;
					IL_17F:
					num = (short)2100887582;
					num2 = (int)((IntPtr)num);
					continue;
					IL_1C0:
					this.FrameHome.Navigate(new Uri(FixedLengthStream.b("ꓫ臭鷯韱뛳韵请鿹폻껽懿攁愃儅洇昉漋愍紏眑䀓搕紗缙䨛眝䔟唡ਣ帥䤧䜩䀫", a_), UriKind.RelativeOrAbsolute));
					num = (short)269352976;
					num2 = (int)((IntPtr)num);
					continue;
					IL_1FD:
					this.bNavigateToContentPage = true;
					num = (short)447807492;
					num2 = (int)((IntPtr)num);
					continue;
					IL_35C:
					num = (short)1845231645;
					num2 = (int)((IntPtr)num);
					continue;
					IL_53D:
					num = (short)290521088;
					num2 = (int)((IntPtr)num);
					continue;
					IL_583:
					this.bNavigateToContentPage = true;
					num = (short)487915526;
					num2 = (int)((IntPtr)num);
					continue;
					IL_5E7:
					num = (short)884080677;
					num2 = (int)((IntPtr)num);
					continue;
					IL_7E2:
					num = (short)2144337934;
					num2 = (int)((IntPtr)num);
					continue;
					IL_81E:
					num = (short)1138688028;
					num2 = (int)((IntPtr)num);
				}
				IL_21C:
				IL_2FD:
				IL_3FD:
				IL_425:
				IL_5A3:
				windowMain.SelectedNavigationMode = (PaneItem)sender;
				return;
				IL_E0:
				windowMain = (WindowMain)Application.Current.MainWindow;
				windowMain.ribbonTabSecurity.Visibility = Visibility.Collapsed;
				num = (short)498860065;
				num2 = (int)((IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00047290 File Offset: 0x00045490
		internal object GetSelectedItemContent()
		{
			short num = (short)1531175962;
			short num2 = num;
			num = (short)1540809754;
			switch (num2 == num)
			{
			}
			num = (short)673382401;
			if (num != 0)
			{
			}
			num = (short)1035337728;
			if (num != 0)
			{
			}
			num = (short)2032861184;
			short num3 = num;
			return ((Frame)this.AppNavPane.SelectedContent).Content;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0004734C File Offset: 0x0004554C
		internal void SetSelectedItem(PaneItem item, bool NavigateToContentPage)
		{
			short num = (short)1685782530;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				num = (short)911942100;
				short num3 = num;
				num = (short)945627604;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
					num = (short)2066743296;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
					{
						num = (short)692453377;
						if (num != 0)
						{
						}
						num = (short)666697728;
						short num4 = num;
						this.bNavigateToContentPage = NavigateToContentPage;
						item.IsSelected = true;
						num = (short)350224385;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 1:
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_7C;
						}
						continue;
					}
					IL_7C:
					if (item.IsSelected)
					{
						return;
					}
					num = (short)164102144;
					num2 = (int)((IntPtr)num);
					break;
				}
			}
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00047470 File Offset: 0x00045670
		public PageNavPaneButtons()
		{
			this.InitializeComponent();
			AcpUI.Common.Utility.SetDirection(this);
			this.ButtonHome.IsSelected = true;
			WindowMain dataContext = (WindowMain)Application.Current.MainWindow;
			base.DataContext = dataContext;
		}

		// Token: 0x06000166 RID: 358 RVA: 0x000474BC File Offset: 0x000456BC
		private void ClearFrame_Navigated(object sender, NavigationEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			Frame frame;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_120;
				case 1:
					if (frame.Content != null)
					{
						num2 = (short)1867710468;
						num = (int)((IntPtr)num2);
						continue;
					}
					frame.NavigationService.RemoveBackEntry();
					num2 = (short)1755185152;
					num = (int)((IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)1983730465;
					short num3 = num2;
					num2 = (short)232346401;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)1301872640;
						if (num2 != 0)
						{
						}
						num2 = (short)1106051073;
						num = (int)((IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					if (frame.NavigationService.CanGoBack)
					{
						num2 = (short)2042953730;
						num = (int)((IntPtr)num2);
						continue;
					}
					return;
				case 4:
					goto IL_F8;
				case 5:
					goto IL_120;
				}
				goto IL_28;
				IL_120:
				num2 = (short)1093926915;
				num = (int)((IntPtr)num2);
			}
			IL_F8:
			num2 = (short)88866817;
			if (num2 != 0)
			{
			}
			return;
			IL_28:
			num2 = (short)1772158976;
			short num4 = num2;
			frame = (Frame)sender;
			num2 = (short)1347026949;
			num = (int)((IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000116 RID: 278
		private bool bNavigateToContentPage = true;

		// Token: 0x0400011F RID: 287
		[NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
