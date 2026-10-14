using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Navigation;
using ACPBrowser;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpCommonLib.FieldsReport;
using AcpCommonLib.FindResult;
using AcpCommonLib.StatusMessage;
using AcpCommonResources;
using AcpUI.Common;
using AcpUILib;
using DevComponents.WpfDock;
using DevComponents.WpfDock.themes;

namespace AcpUI
{
	// Token: 0x0200004D RID: 77
	public class AcpIuiPage : global::System.Windows.Controls.Page, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x00051E20 File Offset: 0x00050020
		public global::System.Windows.Controls.Frame GetFrameLeft
		{
			get
			{
				short num = (short)1618746552;
				short num2 = num;
				num = (short)1596464312;
				switch (num2 == num)
				{
				}
				num = (short)1447297024;
				short num3 = num;
				num = (short)2044198913;
				if (num != 0)
				{
				}
				num = (short)529465344;
				if (num != 0)
				{
				}
				return this.s;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x00051ED4 File Offset: 0x000500D4
		public global::System.Windows.Controls.Frame GetFrameCenterTop
		{
			get
			{
				short num = (short)1597645859;
				short num2 = num;
				num = (short)1507206179;
				switch (num2 == num)
				{
				}
				num = (short)2115108864;
				short num3 = num;
				num = (short)1839529985;
				if (num != 0)
				{
				}
				num = (short)282591232;
				if (num != 0)
				{
				}
				return this.ar;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000476 RID: 1142 RVA: 0x00051F84 File Offset: 0x00050184
		public global::System.Windows.Controls.Frame GetFrameRight
		{
			get
			{
				short num = (short)2040421006;
				short num2 = num;
				num = (short)45111950;
				switch (num2 == num)
				{
				}
				num = (short)1303773184;
				short num3 = num;
				num = (short)1761476609;
				if (num != 0)
				{
				}
				num = (short)1427505152;
				if (num != 0)
				{
				}
				return this.w;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000477 RID: 1143 RVA: 0x00052034 File Offset: 0x00050234
		public global::System.Windows.Controls.Frame GetFrameOutput
		{
			get
			{
				short num = (short)1894648258;
				short num2 = num;
				num = (short)1461520834;
				switch (num2 == num)
				{
				}
				num = (short)842858496;
				short num3 = num;
				num = (short)2137915392;
				if (num != 0)
				{
				}
				num = (short)248578049;
				if (num != 0)
				{
				}
				return this.ac;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000478 RID: 1144 RVA: 0x000520E4 File Offset: 0x000502E4
		public global::System.Windows.Controls.Frame GetFrameInvalidFields
		{
			get
			{
				short num = (short)2011669760;
				short num2 = num;
				num = (short)1810408704;
				switch (num2 == num)
				{
				}
				num = (short)402653184;
				short num3 = num;
				num = (short)895156225;
				if (num != 0)
				{
				}
				num = (short)2015363072;
				if (num != 0)
				{
				}
				return this.ae;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000479 RID: 1145 RVA: 0x00052194 File Offset: 0x00050394
		public global::System.Windows.Controls.Frame GetFrameImpExp
		{
			get
			{
				short num = (short)1011789731;
				short num2 = num;
				num = (short)1023192995;
				switch (num2 == num)
				{
				}
				num = (short)2027487232;
				short num3 = num;
				num = (short)216530945;
				if (num != 0)
				{
				}
				num = (short)1482817536;
				if (num != 0)
				{
				}
				return this.ai;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x00052244 File Offset: 0x00050444
		public global::System.Windows.Controls.Frame GetFrameDnD
		{
			get
			{
				short num = (short)1195682276;
				short num2 = num;
				num = (short)1685432804;
				switch (num2 == num)
				{
				}
				num = (short)407437312;
				short num3 = num;
				num = (short)1517355008;
				if (num != 0)
				{
				}
				num = (short)2098200577;
				if (num != 0)
				{
				}
				return this.ag;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x000522F0 File Offset: 0x000504F0
		public global::System.Windows.Controls.Frame GetFrameComparator
		{
			get
			{
				short num = (short)1959327408;
				short num2 = num;
				num = (short)216528560;
				switch (num2 == num)
				{
				}
				num = (short)1944977408;
				short num3 = num;
				num = (short)1456996353;
				if (num != 0)
				{
				}
				num = (short)1919352832;
				if (num != 0)
				{
				}
				return this.ak;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x000523A0 File Offset: 0x000505A0
		public global::System.Windows.Controls.Frame GetFrameFindResults
		{
			get
			{
				short num = (short)439630404;
				short num2 = num;
				num = (short)1638545988;
				switch (num2 == num)
				{
				}
				num = (short)1455816704;
				short num3 = num;
				num = (short)615579649;
				if (num != 0)
				{
				}
				num = (short)4456448;
				if (num != 0)
				{
				}
				return this.ao;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x0600047D RID: 1149 RVA: 0x00052450 File Offset: 0x00050650
		public global::System.Windows.Controls.Frame GetStatusBar
		{
			get
			{
				short num = (short)1473708033;
				if (num != 0)
				{
				}
				num = (short)1176477768;
				short num2 = num;
				num = (short)1940955208;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1316159488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)959840256;
				if (num != 0)
				{
				}
				return this.n;
			}
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00052500 File Offset: 0x00050700
		public void InitDockWindowState(global::AcpUI.Common.DockWndType dwType, bool bVisible, bool bAutoRise)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			short num2;
			global::DevComponents.WpfDock.DockWindow dockWindow;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1052852546;
					short num3 = num2;
					num2 = (short)2021212482;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num2 = (short)1241972736;
						if (num2 != 0)
						{
						}
						num2 = (short)1703608327;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					return;
				case 2:
					goto IL_198;
				case 3:
					if (dwType == global::AcpUI.Common.DockWndType.Naviagtion)
					{
						num2 = (short)762314761;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_201;
				case 4:
					num2 = (short)1032388609;
					if (num2 != 0)
					{
					}
					dockWindow.Visibility = global::System.Windows.Visibility.Collapsed;
					num2 = (short)543096835;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_201;
				case 6:
					goto IL_198;
				case 7:
					if (!bVisible)
					{
						num2 = (short)1919483908;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					dockWindow.Visibility = global::System.Windows.Visibility.Visible;
					global::AcpUI.Common.Utility.DockWindowVisibilityChanged(dockWindow, true);
					num2 = (short)1341849602;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (dockWindow != null)
					{
						num2 = (short)1204224000;
						short num4 = num2;
						num2 = (short)440074240;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 9:
					dockWindow.IsAutoHide = true;
					num2 = (short)1130037253;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_38;
				IL_198:
				((global::AcpUI.AcpDockWindow)dockWindow).IsAutoRiseEnabled = bAutoRise;
				global::AcpUI.Common.Utility.a(dockWindow, bAutoRise);
				num2 = (short)1706295297;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_201:
				global::AcpUI.Common.Utility.DockWindowVisibilityChanged(dockWindow, false);
				num2 = (short)1752825862;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_38:
			dockWindow = this.GetDockWindow(dwType);
			num2 = (short)1387659272;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x00052734 File Offset: 0x00050934
		public void GetDockWindowState(global::AcpUI.Common.DockWndType dwType, out bool bVisibile, out bool bAutoRise, out bool bAutoHide)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			global::DevComponents.WpfDock.DockWindow dockWindow;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					global::System.Windows.Visibility visibility = dockWindow.Visibility;
					num2 = (short)1130233863;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					return;
				case 2:
				{
					num2 = (short)280035328;
					short num3 = num2;
					goto IL_168;
				}
				case 3:
				{
					global::System.Windows.Visibility visibility;
					if (visibility - global::System.Windows.Visibility.Hidden > 1)
					{
						num2 = (short)1347747849;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					bVisibile = false;
					num2 = (short)1762122384;
					short num4 = num2;
					num2 = (short)111008400;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_183;
					default:
						num2 = (short)482803712;
						if (num2 != 0)
						{
						}
						num2 = (short)1525547010;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					num2 = (short)1367474177;
					if (num2 != 0)
					{
					}
					num2 = (short)777322499;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_168;
				case 6:
					goto IL_168;
				case 7:
				{
					global::System.Windows.Visibility visibility;
					if (visibility != global::System.Windows.Visibility.Visible)
					{
						num2 = (short)1885995012;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					bVisibile = true;
					num2 = (short)847314950;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 8:
					if (dockWindow != null)
					{
						num2 = (short)2029518848;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 9:
					num2 = (short)1979777029;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_38;
				IL_183:
				num2 = (short)705232897;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_168:
				bAutoRise = ((global::AcpUI.AcpDockWindow)dockWindow).IsAutoRiseEnabled;
				bAutoHide = ((global::AcpUI.AcpDockWindow)dockWindow).IsAutoHide;
				goto IL_183;
			}
			return;
			IL_38:
			bVisibile = true;
			bAutoRise = true;
			bAutoHide = true;
			dockWindow = this.GetDockWindow(dwType);
			num2 = (short)1877016584;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x00052968 File Offset: 0x00050B68
		public void PopupDockWindow(global::AcpUI.Common.DockWndType dwType)
		{
			global::DevComponents.WpfDock.DockWindow dockWindow = this.GetDockWindow(dwType);
			short num;
			if (dockWindow.Visibility == global::System.Windows.Visibility.Visible)
			{
				for (;;)
				{
					num = (short)664138075;
					short num2 = num;
					num = (short)1098183003;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_4A;
					}
				}
				IL_4A:
				num = (short)650903552;
				short num3 = num;
				num = (short)1868234752;
				if (num != 0)
				{
				}
				dockWindow.IsAutoHide = false;
				return;
			}
			num = (short)2085486593;
			if (num != 0)
			{
			}
			this.OpenDockWindow(dwType);
			dockWindow.IsAutoHide = false;
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00052A40 File Offset: 0x00050C40
		public bool IsDockWindowAutoHide(global::AcpUI.Common.DockWndType dwType)
		{
			short num = (short)771125541;
			short num2 = num;
			num = (short)1288335653;
			switch (num2 == num)
			{
			}
			num = (short)1515651072;
			short num3 = num;
			num = (short)1831075841;
			if (num != 0)
			{
			}
			num = (short)1565458432;
			if (num != 0)
			{
			}
			return ((global::AcpUI.AcpDockWindow)this.GetDockWindow(dwType)).IsAutoHide;
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00052AFC File Offset: 0x00050CFC
		public void SetDockWindowAutoRise(global::AcpUI.Common.DockWndType dwType, bool IsAutoRiseOn)
		{
			short num = (short)934650425;
			short num2 = num;
			num = (short)906535481;
			switch (num2 == num)
			{
			}
			num = (short)1888681984;
			short num3 = num;
			num = (short)435159041;
			if (num != 0)
			{
			}
			num = (short)167968768;
			if (num != 0)
			{
			}
			global::DevComponents.WpfDock.DockWindow dockWindow = this.GetDockWindow(dwType);
			((global::AcpUI.AcpDockWindow)dockWindow).IsAutoRiseEnabled = IsAutoRiseOn;
			global::AcpUI.Common.Utility.a(dockWindow, IsAutoRiseOn);
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00052BC0 File Offset: 0x00050DC0
		private void d(global::DevComponents.WpfDock.DockWindow A_0)
		{
			short num = (short)539754501;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				IL_1F:
				switch (num2)
				{
				case 0:
					while (A_0.Image is global::System.Windows.Controls.Image)
					{
						num = (short)837108452;
						short num3 = num;
						num = (short)1167606500;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1981874176;
							if (num != 0)
							{
							}
							num = (short)1025048577;
							if (num != 0)
							{
							}
							num = (short)1592983553;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_1F;
						}
					}
					return;
				case 1:
				{
					num = (short)1321598976;
					short num4 = num;
					global::System.Windows.UIElement uielement = (global::System.Windows.Controls.Image)A_0.Image;
					global::System.Windows.Media.Animation.DoubleAnimation doubleAnimation = new global::System.Windows.Media.Animation.DoubleAnimation();
					doubleAnimation.From = new double?(1.0);
					doubleAnimation.To = new double?(0.2);
					global::System.Windows.Duration duration = new global::System.Windows.Duration(global::System.TimeSpan.FromSeconds(0.3));
					doubleAnimation.Duration = duration;
					doubleAnimation.AutoReverse = true;
					global::System.Windows.Media.Animation.RepeatBehavior repeatBehavior = new global::System.Windows.Media.Animation.RepeatBehavior(global::System.TimeSpan.FromSeconds(5.0));
					doubleAnimation.RepeatBehavior = repeatBehavior;
					doubleAnimation.FillBehavior = global::System.Windows.Media.Animation.FillBehavior.Stop;
					uielement.BeginAnimation(global::System.Windows.UIElement.OpacityProperty, doubleAnimation, global::System.Windows.Media.Animation.HandoffBehavior.SnapshotAndReplace);
					A_0.AttentionRequired = true;
					num = (short)1377239044;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					num = (short)1625489411;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (A_0.Image != null)
					{
						num = (short)439615494;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					return;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_41;
					}
					continue;
				case 6:
					num = (short)1335033856;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_41:
				if (A_0 == null)
				{
					break;
				}
				num = (short)694419458;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00052DFC File Offset: 0x00050FFC
		private void c(global::DevComponents.WpfDock.DockWindow A_0)
		{
			short num = (short)748552199;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					global::System.Windows.Controls.Image image = (global::System.Windows.Controls.Image)A_0.Image;
					num = (short)1650982916;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					num = (short)650706946;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)1593442304;
					short num3 = num;
					if (A_0.Image != null)
					{
						num = (short)1676017669;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 3:
					if (A_0.Image is global::System.Windows.Controls.Image)
					{
						num = (short)902889472;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
				{
					global::System.Windows.Controls.Image image;
					if (image.HasAnimatedProperties)
					{
						goto IL_96;
					}
					return;
				}
				case 5:
					num = (short)300744707;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					num = (short)966787073;
					if (num != 0)
					{
					}
					global::System.Windows.Controls.Image image;
					image.BeginAnimation(global::System.Windows.UIElement.OpacityProperty, null);
					A_0.AttentionRequired = false;
					num = (short)556728328;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
					switch (0)
					{
					case 0:
						goto IL_4A;
					}
					continue;
				case 8:
				{
					num = (short)1184149781;
					short num4 = num;
					num = (short)1740484885;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_96;
					default:
						goto IL_1E5;
					}
					break;
				}
				}
				IL_4A:
				if (A_0 != null)
				{
					num = (short)160038913;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_96:
				num = (short)1895038982;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1E5:
			num = (short)747962368;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00053008 File Offset: 0x00051208
		public void OpenDockWindow(global::AcpUI.Common.DockWndType dwType)
		{
			switch (0)
			{
			case 0:
				goto IL_4C;
			}
			int num;
			global::DevComponents.WpfDock.DockWindow dockWindow;
			short num2;
			for (;;)
			{
				IL_0A:
				bool flag;
				switch (num)
				{
				case 0:
					if (((global::AcpUI.AcpDockWindow)dockWindow).IsAutoRiseEnabled)
					{
						num2 = (short)561709070;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					this.d(dockWindow);
					num2 = (short)1255800843;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_29A;
				case 2:
					num2 = (short)1459027969;
					if (num2 != 0)
					{
					}
					if (!dockWindow.IsAutoHide)
					{
						num2 = (short)1365377034;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2096562176;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (dockWindow != null)
					{
						num2 = (short)854392841;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 4:
					return;
				case 5:
				{
					num2 = (short)1061068717;
					short num3 = num2;
					num2 = (short)233480109;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2FE;
					default:
						num2 = (short)109576192;
						if (num2 != 0)
						{
						}
						dockWindow.IsAutoHide = false;
						num2 = (short)362545153;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 6:
					if (flag)
					{
						num2 = (short)2005663756;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 7:
					goto IL_10C;
				case 8:
					if (dockWindow.Visibility != global::System.Windows.Visibility.Visible)
					{
						num2 = (short)1694629893;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_29A;
				case 9:
					this.a(dockWindow);
					num2 = (short)709951496;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					goto IL_2FE;
				case 11:
					goto IL_10C;
				case 12:
				{
					global::System.Windows.RoutedEventArgs a_ = new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfDock.DockWindow.AutoHideChangedEvent, dockWindow);
					this.AutoHideChanged(dockWindow, a_);
					global::AcpUI.Common.Utility.DockWindowVisibilityChanged(dockWindow, true);
					num2 = (short)1466368004;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 13:
					goto IL_10C;
				case 14:
					((global::AcpUI.AcpDockWindow)dockWindow).StartTimer(5000);
					dockWindow.AutoHideOpen = true;
					flag = true;
					num2 = (short)25493511;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_4C;
				IL_10C:
				num2 = (short)1332936710;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_29A:
				flag = false;
				num2 = (short)16187394;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2FE:
				num2 = (short)279445504;
				short num4 = num2;
				dockWindow.Open();
				dockWindow.IsSelected = true;
				flag = true;
				num2 = (short)316276749;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_4C:
			dockWindow = this.GetDockWindow(dwType);
			num2 = (short)1039794179;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00053318 File Offset: 0x00051518
		public void CloseDockWindow(global::AcpUI.Common.DockWndType dwType)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::DevComponents.WpfDock.DockWindow dockWindow;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_E8;
				case 1:
				{
					num2 = (short)1744691254;
					short num3 = num2;
					num2 = (short)1607131190;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E8;
					default:
						num2 = (short)1394147328;
						if (num2 != 0)
						{
						}
						dockWindow.Close();
						num2 = (short)2019753984;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					if (dockWindow != null)
					{
						num2 = (short)1013252097;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_1C;
			}
			IL_E8:
			num2 = (short)169607169;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			dockWindow = this.GetDockWindow(dwType);
			num2 = (short)1726480384;
			short num4 = num2;
			num2 = (short)2030239746;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00053438 File Offset: 0x00051638
		public global::DevComponents.WpfDock.DockWindow GetDockWindow(global::AcpUI.Common.DockWndType dwType)
		{
			switch (0)
			{
			case 0:
				goto IL_88;
			}
			int num;
			short num2;
			global::DevComponents.WpfDock.DockWindow result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					if (dwType == global::AcpUI.Common.DockWndType.SysKeyRpt)
					{
						num2 = (short)2067333149;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)884604928;
					short num3 = num2;
					num2 = (short)745799705;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					goto IL_1D7;
				case 2:
				{
					num2 = (short)1433452521;
					short num4 = num2;
					num2 = (short)733790185;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)404291584;
						if (num2 != 0)
						{
						}
						result = this.v;
						num2 = (short)347471888;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					goto IL_2BB;
				case 4:
					if (dwType == global::AcpUI.Common.DockWndType.Comparator)
					{
						num2 = (short)487522326;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)284295192;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_298;
				case 6:
					if (dwType == global::AcpUI.Common.DockWndType.Output)
					{
						num2 = (short)1776615450;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1761476619;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					return result;
				case 8:
					if (dwType == global::AcpUI.Common.DockWndType.Naviagtion)
					{
						num2 = (short)2119368722;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)219021331;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					return result;
				case 10:
					if (dwType == global::AcpUI.Common.DockWndType.DnD)
					{
						num2 = (short)1931542556;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)594935825;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					if (dwType == global::AcpUI.Common.DockWndType.InvalidFields)
					{
						num2 = (short)1219297303;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2043215882;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					return result;
				case 13:
					result = this.ah;
					num2 = (short)1749024788;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					result = this.al;
					num2 = (short)1902313499;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					result = this.an;
					num2 = (short)258867212;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					goto IL_1B3;
				case 17:
					if (dwType == global::AcpUI.Common.DockWndType.ImpExp)
					{
						num2 = (short)1855717389;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1904672772;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
					result = this.r;
					num2 = (short)1011548181;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					if (dwType == global::AcpUI.Common.DockWndType.HelpInfo)
					{
						num2 = (short)1803157506;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)349306886;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 20:
					goto IL_11A;
				case 21:
					return result;
				case 22:
					result = this.aj;
					num2 = (short)1925906433;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 23:
					result = this.ad;
					num2 = (short)1236008967;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 24:
					if (dwType == global::AcpUI.Common.DockWndType.FindResults)
					{
						num2 = (short)1030881295;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1664024576;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 25:
					if (dwType == global::AcpUI.Common.DockWndType.FillUpFillDown)
					{
						num2 = (short)1678442510;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 26:
					result = this.ab;
					num2 = (short)1357643781;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 27:
					return result;
				case 28:
					result = this.af;
					num2 = (short)54591497;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 29:
					result = this.ap;
					num2 = (short)1501429763;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_88;
			}
			IL_11A:
			IL_1B3:
			IL_1D7:
			IL_298:
			return result;
			IL_2BB:
			num2 = (short)718864385;
			if (num2 != 0)
			{
			}
			return result;
			IL_88:
			result = null;
			num2 = (short)1430388744;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x0005390C File Offset: 0x00051B0C
		private void DockWindowActivated(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1296814658;
			short num2 = num;
			num = (short)408998466;
			switch (num2 == num)
			{
			}
			num = (short)834600960;
			short num3 = num;
			num = (short)287375360;
			if (num != 0)
			{
			}
			num = (short)1022296065;
			if (num != 0)
			{
			}
			global::DevComponents.WpfDock.DockWindow dockWindow = A_1.OriginalSource as global::DevComponents.WpfDock.DockWindow;
			this.a(dockWindow);
			this.c(dockWindow);
			dockWindow.AttentionRequired = false;
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x000539D4 File Offset: 0x00051BD4
		private void DockWindowDeactivated(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)613874886;
			short num2 = num;
			num = (short)1755643078;
			switch (num2 == num)
			{
			}
			num = (short)65339392;
			short num3 = num;
			num = (short)290390017;
			if (num != 0)
			{
			}
			num = (short)1010958336;
			if (num != 0)
			{
			}
			object originalSource = A_1.OriginalSource;
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00053A80 File Offset: 0x00051C80
		private void DockWindowClosing(object A_0, global::DevComponents.WpfDock.CancelSourceRoutedEventArgs A_1)
		{
			short num = (short)1676023560;
			short num2 = num;
			num = (short)1956386568;
			switch (num2 == num)
			{
			}
			num = (short)729481216;
			short num3 = num;
			num = (short)1003552768;
			if (num != 0)
			{
			}
			num = (short)535887873;
			if (num != 0)
			{
			}
			object originalSource = A_1.OriginalSource;
			this.c = true;
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00053B38 File Offset: 0x00051D38
		private void DockWindowClosed(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)986185729;
			if (num != 0)
			{
			}
			num = (short)725822030;
			short num2 = num;
			num = (short)1773283918;
			switch (num2 == num)
			{
			default:
			{
				num = (short)65208320;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)112852992;
			if (num != 0)
			{
			}
			global::DevComponents.WpfDock.DockWindow dockWindow = A_1.OriginalSource as global::DevComponents.WpfDock.DockWindow;
			global::AcpUI.Common.Utility.DockWindowVisibilityChanged(dockWindow, false);
			this.b(dockWindow);
			this.c = false;
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00053C00 File Offset: 0x00051E00
		private void b(global::DevComponents.WpfDock.DockWindow A_0)
		{
			int a_ = 1;
			switch (0)
			{
			case 0:
				goto IL_C1;
			}
			int num;
			short num2;
			uint num3;
			string name;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					return;
				case 1:
					num2 = (short)2069102611;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (num3 != 972022454U)
					{
						num2 = (short)1255604236;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)20316182;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (!(name == global::AcpUI.Common.Utility.c("풖ﺞ펠슢톤좦\udba8슬첮\udab0\udbb4펶", a_)))
					{
						num2 = (short)679018529;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_64C;
				case 4:
					if (!(name == global::AcpUI.Common.Utility.c("\ud896햠쪤쒦슨ﲪ쎬쮮", a_)))
					{
						num2 = (short)1691746328;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_5F5;
				case 5:
					return;
				case 6:
					return;
				case 7:
					if (num3 != 2229884933U)
					{
						num2 = (short)1165819945;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1426128936;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					return;
				case 9:
					return;
				case 10:
					goto IL_46B;
				case 11:
					num2 = (short)1819017234;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
				{
					num2 = (short)1172307968;
					short num4 = num2;
					num2 = (short)466485285;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 13:
					goto IL_125;
				case 14:
					if (num3 != 2263907426U)
					{
						num2 = (short)247857162;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)417267735;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					num2 = (short)532611093;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					return;
				case 17:
					num2 = (short)1030094850;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
					if (num3 <= 809347798U)
					{
						num2 = (short)726663169;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)729481254;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					if (num3 != 119543072U)
					{
						num2 = (short)2010185743;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1E4;
				case 20:
					if (num3 <= 2228748310U)
					{
						num2 = (short)2017787915;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1672019995;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 21:
					if (num3 != 809347798U)
					{
						num2 = (short)1167065097;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)183828493;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 22:
					if (!(name == global::AcpUI.Common.Utility.c("\ude96\ud89c토쪤쒦슨ﲪ쎬쮮", a_)))
					{
						num2 = (short)478609408;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_23B;
				case 23:
					if (!(name == global::AcpUI.Common.Utility.c("톖列춞쒠킢키쮦\udda8\ud8aa삮튰\ud8b2\ud9b6\uddb8", a_)))
					{
						num2 = (short)1710358536;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_697;
				case 24:
				{
					num2 = (short)61155174;
					short num5 = num2;
					num2 = (short)127149926;
					switch ((num5 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_125;
					default:
						goto IL_31F;
					}
					break;
				}
				case 25:
					num2 = (short)192479266;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 26:
					return;
				case 27:
					if (num3 <= 2263907426U)
					{
						num2 = (short)455933984;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1929969693;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 28:
					return;
				case 29:
					if (num3 != 2613810977U)
					{
						num2 = (short)1525350425;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)111214627;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 30:
					if (!(name == global::AcpUI.Common.Utility.c("톖쪞토첤쮦얨슬\ud8ae\udfb0\udab4풶트펼\udbbe", a_)))
					{
						num2 = (short)1036320784;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_788;
				case 31:
					num2 = (short)239730727;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 32:
					num2 = (short)2130771975;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 33:
					return;
				case 34:
					if (num3 != 3695995382U)
					{
						num2 = (short)333578271;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1900281886;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 35:
					if (!(name == global::AcpUI.Common.Utility.c("펖\udf9a\ud99c슠좢즦춨", a_)))
					{
						num2 = (short)112066586;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3E1;
				case 36:
					return;
				case 37:
					if (num3 != 2228748310U)
					{
						num2 = (short)440729605;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1008336900;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 38:
					if (num3 != 815471089U)
					{
						num2 = (short)464715793;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1551630339;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 39:
					if (num3 != 3731834594U)
					{
						num2 = (short)1882587142;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_497;
				case 40:
					if (!(name == global::AcpUI.Common.Utility.c("\ude96ﲜ좠잢캦첨잪즬\udcae\udcb2횴\udcb6햺\ud9bc", a_)))
					{
						num2 = (short)1900609564;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_287;
				case 41:
					num2 = (short)1640300558;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_C1;
				IL_125:
				if (name == global::AcpUI.Common.Utility.c("쒖횜爵\ud8a0삤힦욨\ud9aa\ud9ac\udfb0ힲ", a_))
				{
					goto IL_294;
				}
				num2 = (short)56950820;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_1E4:
			name == global::AcpUI.Common.Utility.c("\ud996쪜쾠잢쪤킦쒪캬쒮\uddb2톴", a_);
			return;
			IL_23B:
			this.ai.Content = null;
			return;
			IL_287:
			this.ae.Content = null;
			return;
			IL_294:
			this.aq.Content = null;
			return;
			IL_31F:
			num2 = (short)1085276160;
			if (num2 != 0)
			{
			}
			return;
			IL_3E1:
			this.ag.Content = null;
			return;
			IL_46B:
			num2 = (short)2004221953;
			if (num2 != 0)
			{
			}
			return;
			IL_497:
			name == global::AcpUI.Common.Utility.c("쎖좞좠춢솤좦\udea8슬첮\udab0\udbb4펶", a_);
			return;
			IL_5F5:
			this.ac.Content = null;
			return;
			IL_64C:
			this.ak.Content = null;
			return;
			IL_697:
			this.ao.Content = null;
			return;
			IL_788:
			this.am.Content = null;
			return;
			IL_C1:
			name = A_0.Name;
			num3 = global::d.a(name);
			num2 = (short)1243480084;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x000543A4 File Offset: 0x000525A4
		private void AutoHideChanged(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)317063168;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_A7;
				}
				global::DevComponents.WpfDock.DockWindow dockWindow2;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
					{
						global::DevComponents.WpfDock.DockWindowGroup previousGroup;
						int num3;
						if (previousGroup.Items.Count <= num3)
						{
							num = (short)981270544;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						object obj = previousGroup.Items[num3--];
						num = (short)726401048;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (!this.c)
						{
							num = (short)221315092;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
					{
						num = (short)1174310952;
						short num4 = num;
						num = (short)754356264;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1C1;
						default:
						{
							num = (short)911147008;
							if (num != 0)
							{
							}
							global::DevComponents.WpfDock.DockWindow dockWindow;
							dockWindow.IsAutoHide = dockWindow2.IsAutoHide;
							num = (short)1375928347;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 3:
					{
						object obj;
						global::DevComponents.WpfDock.DockWindow dockWindow3 = (global::DevComponents.WpfDock.DockWindow)obj;
						num = (short)113901590;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						if (!dockWindow2.IsAutoHide)
						{
							num = (short)2020802578;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::DevComponents.WpfDock.DockWindowGroup previousGroup = dockWindow2.PreviousGroup;
						num = (short)83427338;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						if (dockWindow2 != null)
						{
							num = (short)796327959;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
						goto IL_209;
					case 7:
						goto IL_514;
					case 8:
					{
						int num5;
						if (num5 > -1)
						{
							num = (short)1383727118;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3FC;
					}
					case 9:
						return;
					case 10:
					{
						global::DevComponents.WpfDock.DockWindowGroup previousGroup;
						if (previousGroup != null)
						{
							num = (short)574554124;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3FC;
					}
					case 11:
						num = (short)2086797312;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
					{
						global::DevComponents.WpfDock.DockWindowGroup previousGroup;
						int num3 = previousGroup.Items.Count - 1;
						num = (short)432996373;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
					{
						int num3;
						if (num3 > -1)
						{
							num = (short)258277387;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3FC;
					}
					case 14:
						num = (short)41091100;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						object obj2;
						if (obj2 is global::DevComponents.WpfDock.DockWindow)
						{
							goto IL_1C1;
						}
						goto IL_514;
					}
					case 16:
						goto IL_3FC;
					case 17:
					{
						global::DevComponents.WpfDock.DockWindow dockWindow3;
						dockWindow3.IsAutoHide = dockWindow2.IsAutoHide;
						num = (short)1718222854;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
					{
						global::DevComponents.WpfDock.DockSite dockSite = dockWindow2.GetDockSite();
						global::System.Windows.Controls.Dock dockFromDockWindow = dockSite.GetDockFromDockWindow(dockWindow2);
						global::DevComponents.WpfDock.AutoHidePanel autoHidePanel = dockSite.GetAutoHidePanel(dockFromDockWindow);
						int num5 = autoHidePanel.Items.Count - 1;
						num = (short)506527751;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
					{
						num = (short)957087744;
						short num6 = num;
						object obj2;
						global::DevComponents.WpfDock.DockWindow dockWindow = (global::DevComponents.WpfDock.DockWindow)obj2;
						num = (short)236584989;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						num = (short)698613764;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						goto IL_209;
					case 22:
					{
						global::DevComponents.WpfDock.DockWindow dockWindow3;
						if (dockWindow3.Visibility == global::System.Windows.Visibility.Visible)
						{
							num = (short)281804817;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_209;
					}
					case 23:
						num = (short)315555841;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
					{
						object obj;
						if (obj is global::DevComponents.WpfDock.DockWindow)
						{
							num = (short)704184323;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_209;
					}
					case 25:
						goto IL_3FC;
					case 26:
						num = (short)393805849;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						goto IL_514;
					case 28:
					{
						num = (short)245825537;
						if (num != 0)
						{
						}
						int num5;
						global::DevComponents.WpfDock.AutoHidePanel autoHidePanel;
						if (autoHidePanel.Items.Count <= num5)
						{
							num = (short)1191903258;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						object obj2 = autoHidePanel.Items[num5--];
						num = (short)1393426447;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 29:
					{
						global::DevComponents.WpfDock.DockWindow dockWindow;
						if (dockWindow.Visibility == global::System.Windows.Visibility.Visible)
						{
							num = (short)1455292418;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_514;
					}
					}
					goto IL_A7;
					IL_1C1:
					num = (short)1078132755;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_209:
					num = (short)1642856461;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3FC:
					dockWindow2.IsSelected = true;
					num = (short)2110324745;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_514:
					num = (short)1334444040;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_A7:
				dockWindow2 = (A_1.OriginalSource as global::DevComponents.WpfDock.DockWindow);
				num = (short)1068236805;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00054950 File Offset: 0x00052B50
		private void a(global::DevComponents.WpfDock.DockWindow A_0)
		{
			int a_ = 8;
			short num = (short)9502720;
			switch (num)
			{
			default:
			{
				num = (short)496959584;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::AcpUI.Common.PageFieldsReport pageFieldsReport;
					global::AcpUI.Common.PageInvalidFieldsReport pageInvalidFieldsReport;
					global::AcpUI.Common.PageFieldsReport pageFieldsReport2;
					global::AcpUI.Common.PageFieldsReport pageFieldsReport3;
					global::AcpUI.Common.PageFindResults pageFindResults;
					switch (num2)
					{
					case 0:
						goto IL_7E6;
					case 1:
						if (pageFieldsReport.DataContext == null)
						{
							num = (short)1573781646;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15ED;
					case 2:
						goto IL_F4D;
					case 3:
						num = (short)544735338;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)861143045;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (global::AcpCommonLib.AppInfoManager.ComparatorFieldsReport.HasFields)
						{
							num = (short)921632821;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_16D5;
					case 6:
						goto IL_E27;
					case 7:
						num = (short)1977221137;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (this.k == null)
						{
							num = (short)632815645;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9DF;
					case 9:
						goto IL_54E;
					case 10:
						goto IL_6CD;
					case 11:
						goto IL_1642;
					case 12:
						num = (short)2023948314;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_10AF;
					case 14:
						num = (short)1630601342;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_54E;
					case 16:
						if (pageInvalidFieldsReport != null)
						{
							num = (short)1772748887;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_65A;
					case 17:
						if (pageFieldsReport2.DataContext == null)
						{
							num = (short)113311755;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1617;
					case 18:
						goto IL_54E;
					case 19:
						if (this.IsSameFieldsReportInfoList(this.e, global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.UiFields))
						{
							num = (short)2047410242;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12CB;
					case 20:
						if (global::AcpCommonLib.AppInfoManager.StatusMsgReport != null)
						{
							num = (short)646119513;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_135D;
					case 21:
						pageFieldsReport3 = null;
						num = (short)2037448752;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						this.m = new global::AcpUI.Common.PageReportSystemKeys();
						num = (short)207421446;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						goto IL_D31;
					case 24:
					{
						string name;
						if (name == global::AcpUI.Common.Utility.c("\ud89d즟캡좣\ud8a7얫슭\udcaf\udbb3솵횷ﺹ펻\uddbdꮿ闁꫃ꋅ", a_))
						{
							num = (short)802291819;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						name == global::AcpUI.Common.Utility.c("쪝솟톡쾣솧쒩좫솭잯\udbb3햵펷튻\udabd", a_);
						num = (short)1870856217;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
						goto IL_54E;
					case 26:
						if (this.k != null)
						{
							num = (short)1200423046;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_135D;
					case 27:
						pageInvalidFieldsReport = null;
						num = (short)1423376483;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						goto IL_106F;
					case 29:
						this.k = new global::AcpUI.Common.PageOutputMessage();
						num = (short)1417609325;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						num = (short)1925841032;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						if (this.l != null)
						{
							num = (short)46006349;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11AC;
					case 32:
						num = (short)1316618241;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						goto IL_15ED;
					case 34:
						pageInvalidFieldsReport = new global::AcpUI.Common.PageInvalidFieldsReport();
						pageInvalidFieldsReport.Title = global::AcpCommonResources.AcpResources.Invalid_Fields;
						pageInvalidFieldsReport.f.Header = global::AcpCommonResources.AcpResources.Invalid_Fields_Result;
						num = (short)1329135639;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						if (pageFieldsReport3.DataContext == null)
						{
							num = (short)1260585088;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F4D;
					case 36:
						if (global::AcpCommonLib.AppInfoManager.FillUpFillDownFieldsReport != null)
						{
							num = (short)2113142911;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11AC;
					case 37:
						num = (short)990969864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
					{
						string name;
						if (name == global::AcpUI.Common.Utility.c("힝춟튡\udea5\ud8a7쎫춭\udbaf\udab3튵", a_))
						{
							num = (short)1378484299;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1263599676;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 39:
						goto IL_54E;
					case 40:
						if (global::AcpCommonLib.AppInfoManager.StatusMsgReport.HasMsgs)
						{
							num = (short)686030860;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_135D;
					case 41:
						goto IL_4D8;
					case 42:
						goto IL_10AF;
					case 43:
						if (this.l == null)
						{
							num = (short)1542324318;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E56;
					case 44:
						num = (short)2005008514;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						num = (short)112328826;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
					{
						string name;
						if (name == global::AcpUI.Common.Utility.c("힝캟풡얣쪥솧캩잭햯\udeb1킳억ﲷ햹\udfbb햽鞿곁ꃃ", a_))
						{
							num = (short)1860173851;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)523436178;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 47:
						goto IL_7E6;
					case 48:
						if (this.ag.Content == null)
						{
							num = (short)1858404500;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)56819809;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						if (this.l.DataContext == null)
						{
							num = (short)2111963188;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_174C;
					case 50:
						if (this.m == null)
						{
							num = (short)840302614;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E27;
					case 51:
						num = (short)709165127;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
						goto IL_18F5;
					case 53:
						num = (short)1992818770;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 54:
						goto IL_102F;
					case 55:
						goto IL_1617;
					case 56:
						if (pageFieldsReport3 != null)
						{
							num = (short)249692190;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AF7;
					case 57:
						num = (short)774570019;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 58:
						num = (short)1182924908;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 59:
						pageFieldsReport = (global::AcpUI.Common.PageFieldsReport)this.ak.Content;
						num = (short)609550364;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 60:
					{
						string name;
						if (name == global::AcpUI.Common.Utility.c("\udd9d쾟쾡풣장\udaa7쮩\ud8ab솭슯\udbb3햵펷튻\udabd", a_))
						{
							num = (short)1696923781;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1238237328;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 61:
						num = (short)1242300548;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 62:
					{
						string name = A_0.Name;
						num = (short)383189077;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 63:
						if (this.ae.Content is global::AcpUI.Common.PageInvalidFieldsReport)
						{
							num = (short)892076133;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 64:
						if (global::AcpCommonLib.AppInfoManager.FindResultReport != null)
						{
							num = (short)1802371123;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1262;
					case 65:
						if (global::AcpCommonLib.AppInfoManager.ImportExportFieldsReport != null)
						{
							num = (short)356188205;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9B3;
					case 66:
						num = (short)846725204;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 67:
						if (this.IsSameFieldsReportInfoList(this.j, global::AcpCommonLib.AppInfoManager.FillUpFillDownFieldsReport.Fields))
						{
							num = (short)1805582440;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_18F5;
					case 68:
						goto IL_193C;
					case 69:
						goto IL_19B7;
					case 70:
						pageFieldsReport2 = new global::AcpUI.Common.PageFieldsReport();
						pageFieldsReport2.Title = global::AcpCommonResources.AcpResources.Import_Export_Report;
						pageFieldsReport2.f.Header = global::AcpCommonResources.AcpResources.Import_Export_Result;
						num = (short)935198733;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 71:
						if (global::AcpCommonLib.AppInfoManager.FindResultReport.HasResults)
						{
							num = (short)1079246851;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1262;
					case 72:
						goto IL_193C;
					case 73:
						if (this.ao.Content == null)
						{
							num = (short)1643053125;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)426704970;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 74:
						if (this.ao.Content is global::AcpUI.Common.PageFindResults)
						{
							num = (short)986513525;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 75:
						pageFieldsReport2 = null;
						num = (short)1313013850;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 76:
						if (global::AcpCommonLib.AppInfoManager.InvalidFieldsReport != null)
						{
							num = (short)825950358;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_65A;
					case 77:
						num = (short)217841731;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 78:
						if (this.ak.Content is global::AcpUI.Common.PageFieldsReport)
						{
							num = (short)816578619;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 79:
						goto IL_E56;
					case 80:
					{
						num = (short)2062161963;
						short num3 = num;
						num = (short)343939115;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_17F6;
						default:
							num = (short)133627904;
							if (num != 0)
							{
							}
							if (global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport != null)
							{
								num = (short)1049821294;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_AF7;
						}
						break;
					}
					case 81:
						try
						{
							A_0.UpdateLayout();
							return;
						}
						catch (global::System.InvalidOperationException)
						{
							return;
						}
						goto IL_19B7;
					case 82:
						if (pageFieldsReport != null)
						{
							num = (short)1206648846;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_16D5;
					case 83:
						pageFieldsReport = new global::AcpUI.Common.PageFieldsReport();
						pageFieldsReport.Title = global::AcpCommonResources.AcpResources.Comparator_Report;
						pageFieldsReport.f.Header = global::AcpCommonResources.AcpResources.Comparator_Result;
						num = (short)1094320257;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 84:
						if (pageInvalidFieldsReport.DataContext == null)
						{
							num = (short)1760690278;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4D8;
					case 85:
					{
						string name;
						if (name == global::AcpUI.Common.Utility.c("톝햟횡풣펥\udca7쎫춭\udbaf\udab3튵", a_))
						{
							num = (short)1531314213;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1610743854;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 86:
						goto IL_177A;
					case 87:
						num = (short)2061041683;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 88:
						if (this.ai.Content is global::AcpUI.Common.PageFieldsReport)
						{
							num = (short)1690239117;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 89:
						num = (short)486998056;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 90:
						if (this.ai.Content == null)
						{
							num = (short)2117206086;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1329725528;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 91:
						goto IL_54E;
					case 92:
						pageFieldsReport3 = (global::AcpUI.Common.PageFieldsReport)this.ag.Content;
						num = (short)1575354415;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 93:
						if (pageFindResults.DataContext == null)
						{
							num = (short)875036682;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_177A;
					case 94:
						this.l = new global::AcpUI.Common.PageFieldsReport();
						this.l.Title = global::AcpCommonResources.AcpResources.Fill_Up_Fill_Down_Report;
						this.l.f.Header = global::AcpCommonResources.AcpResources.Fill_Up_Fill_Down_Result;
						num = (short)2081226831;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 95:
						goto IL_102F;
					case 96:
						switch (0)
						{
						case 0:
							goto IL_2AB;
						}
						continue;
					case 97:
						if (this.ag.Content is global::AcpUI.Common.PageFieldsReport)
						{
							num = (short)956498012;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 98:
					{
						string name;
						if (name == global::AcpUI.Common.Utility.c("춝\ud99f톡쎥톧즫\udead\udfaf삱삳횷\udeb9", a_))
						{
							num = (short)2111438991;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)416612376;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 99:
						if (this.ae.Content == null)
						{
							num = (short)206831650;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)433520703;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 100:
						if (this.ak.Content == null)
						{
							num = (short)543817811;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)338231374;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 101:
						pageInvalidFieldsReport = (global::AcpUI.Common.PageInvalidFieldsReport)this.ae.Content;
						num = (short)549453943;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 102:
						goto IL_12CB;
					case 103:
						goto IL_1A35;
					case 104:
						num = (short)6488113;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 105:
						pageFindResults = null;
						num = (short)1098842185;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 106:
						if (pageFindResults != null)
						{
							num = (short)257359916;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1262;
					case 107:
						num = (short)972750891;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 108:
						if (this.k.DataContext == null)
						{
							num = (short)1392509031;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_193C;
					case 109:
						goto IL_9DF;
					case 110:
						num = (short)1609302155;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 111:
						if (this.IsSameFieldsReportInfoList(this.g, global::AcpCommonLib.AppInfoManager.ImportExportFieldsReport.Fields))
						{
							num = (short)212074503;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1642;
					case 112:
						if (global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.UiHasFields)
						{
							num = (short)425263217;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_65A;
					case 113:
						num = (short)1224146960;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 114:
						if (global::AcpCommonLib.AppInfoManager.ComparatorFieldsReport != null)
						{
							num = (short)1226899460;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_16D5;
					case 115:
						goto IL_54E;
					case 116:
						goto IL_4D8;
					case 117:
						pageFindResults = (global::AcpUI.Common.PageFindResults)this.ao.Content;
						num = (short)76415071;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 118:
						num = (short)1333198879;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 119:
						goto IL_D31;
					case 120:
						goto IL_1617;
					case 121:
						goto IL_F4D;
					case 122:
						if (global::AcpCommonLib.AppInfoManager.ImportExportFieldsReport.HasFields)
						{
							num = (short)2115502141;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9B3;
					case 123:
						goto IL_15ED;
					case 124:
						if (this.IsSameStatusMessageInfoList(this.d, global::AcpCommonLib.AppInfoManager.StatusMsgReport.Messages))
						{
							num = (short)1696727098;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A35;
					case 125:
						goto IL_54E;
					case 126:
						if (this.IsSameFieldsReportInfoList(this.h, global::AcpCommonLib.AppInfoManager.ComparatorFieldsReport.Fields))
						{
							num = (short)1374879776;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7A2;
					case 127:
					{
						num = (short)1265565696;
						short num4 = num;
						num = (short)1785725063;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 128:
						goto IL_148F;
					case 129:
						goto IL_106F;
					case 130:
						if (this.IsSameFindResultInfoList(this.i, global::AcpCommonLib.AppInfoManager.FindResultReport.Results))
						{
							num = (short)1982005379;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6CD;
					case 131:
						num = (short)1389625437;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 132:
						if (pageFieldsReport2 != null)
						{
							num = (short)1313538197;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9B3;
					case 133:
						pageFieldsReport = null;
						num = (short)1049755748;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 134:
						num = (short)910557308;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 135:
						if (global::AcpCommonLib.AppInfoManager.FillUpFillDownFieldsReport.HasFields)
						{
							num = (short)1989410934;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11AC;
					case 136:
						if (this.IsSameFieldsReportInfoList(this.f, global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport.Fields))
						{
							num = (short)772538425;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_148F;
					case 137:
						goto IL_174C;
					case 138:
						goto IL_174C;
					case 139:
						if (global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport.HasFields)
						{
							num = (short)609353868;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AF7;
					case 140:
						goto IL_17F6;
					case 141:
						pageFieldsReport2 = (global::AcpUI.Common.PageFieldsReport)this.ai.Content;
						num = (short)167444522;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 142:
						goto IL_7A2;
					case 143:
						num = (short)661585970;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 144:
					{
						string name;
						if (name == global::AcpUI.Common.Utility.c("\ud89d즟첡삣춧\ud9a9\ud9ab슭쒯솱\ud9b5\udbb7톹킽꒿", a_))
						{
							num = (short)334233705;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)987824226;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 145:
						goto IL_177A;
					case 146:
					{
						string name;
						if (name == global::AcpUI.Common.Utility.c("\uda9d캟즥쮧솩ﮫ삭풯", a_))
						{
							num = (short)1720451093;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)673054758;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 147:
						goto IL_54E;
					case 148:
						pageFieldsReport3 = new global::AcpUI.Common.PageFieldsReport();
						pageFieldsReport3.Title = global::AcpCommonResources.AcpResources.Drag_and_Drop_Report;
						pageFieldsReport3.f.Header = global::AcpCommonResources.AcpResources.Drag_and_Drop_Result;
						num = (short)1244397568;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 149:
						num = (short)1691353199;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 150:
						num = (short)2077556848;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_2AB:
					if (A_0 != null)
					{
						num = (short)808583230;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_4D8:
					this.ae.Content = pageInvalidFieldsReport;
					num = (short)911278119;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_54E:
					num = (short)344391761;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_65A:
					pageInvalidFieldsReport.DataContext = null;
					this.e = null;
					num = (short)50331689;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6CD:
					pageFindResults.DataContext = global::AcpCommonLib.AppInfoManager.FindResultReport.Results;
					this.i = new global::System.Collections.Generic.List<global::AcpCommonLib.FindResult.FindResultInfo>(global::AcpCommonLib.AppInfoManager.FindResultReport.Results);
					num = (short)767164561;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7A2:
					pageFieldsReport.DataContext = global::AcpCommonLib.AppInfoManager.ComparatorFieldsReport.Fields;
					this.h = new global::System.Collections.Generic.List<global::AcpCommonLib.FieldsReport.FieldsReportInfo>(global::AcpCommonLib.AppInfoManager.ComparatorFieldsReport.Fields);
					num = (short)775553147;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7E6:
					num = (short)97714256;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9B3:
					pageFieldsReport2.DataContext = null;
					this.g = null;
					num = (short)1215430711;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9DF:
					num = (short)1680408596;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AF7:
					pageFieldsReport3.DataContext = null;
					this.f = null;
					num = (short)205521017;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D31:
					num = (short)1237909580;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E27:
					this.aq.Navigate(this.m);
					num = (short)1581514877;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E56:
					num = (short)802881572;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F4D:
					this.ag.Content = pageFieldsReport3;
					num = (short)38862849;
					if (num != 0)
					{
					}
					num = (short)1012269171;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_102F:
					num = (short)1734082624;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_106F:
					num = (short)1626996850;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_10AF:
					num = (short)1085407297;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_11AC:
					this.l.DataContext = null;
					this.j = null;
					num = (short)424018057;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1262:
					pageFindResults.DataContext = null;
					this.i = null;
					num = (short)2008481878;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_12CB:
					pageInvalidFieldsReport.DataContext = global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.UiFields;
					this.e = new global::System.Collections.Generic.List<global::AcpCommonLib.FieldsReport.FieldsReportInfo>(global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.UiFields);
					num = (short)431030388;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_135D:
					this.k.DataContext = null;
					this.d = null;
					num = (short)523305032;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_148F:
					pageFieldsReport3.DataContext = global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport.Fields;
					this.f = new global::System.Collections.Generic.List<global::AcpCommonLib.FieldsReport.FieldsReportInfo>(global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport.Fields);
					num = (short)1567162370;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15ED:
					this.ak.Content = pageFieldsReport;
					num = (short)2070478995;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1617:
					this.ai.Content = pageFieldsReport2;
					num = (short)316866651;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1642:
					pageFieldsReport2.DataContext = global::AcpCommonLib.AppInfoManager.ImportExportFieldsReport.Fields;
					this.g = new global::System.Collections.Generic.List<global::AcpCommonLib.FieldsReport.FieldsReportInfo>(global::AcpCommonLib.AppInfoManager.ImportExportFieldsReport.Fields);
					num = (short)622395512;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_16D5:
					pageFieldsReport.DataContext = null;
					this.h = null;
					num = (short)753205281;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_174C:
					this.am.Content = this.l;
					num = (short)1949433874;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_177A:
					this.ao.Content = pageFindResults;
					num = (short)1904214031;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_17F6:
					num = (short)2019295288;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_18F5:
					this.l.DataContext = global::AcpCommonLib.AppInfoManager.FillUpFillDownFieldsReport.Fields;
					this.j = new global::System.Collections.Generic.List<global::AcpCommonLib.FieldsReport.FieldsReportInfo>(global::AcpCommonLib.AppInfoManager.FillUpFillDownFieldsReport.Fields);
					num = (short)696254602;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_193C:
					this.ac.Content = this.k;
					num = (short)1271332873;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_19B7:
					pageFindResults = new global::AcpUI.Common.PageFindResults();
					pageFindResults.Title = global::AcpUI.Common.Utility.c("\ud89d즟첡삣蚥盛쾩\udfab\udbad\udcaf욱잳", a_);
					num = (short)983695414;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A35:
					this.k.DataContext = global::AcpCommonLib.AppInfoManager.StatusMsgReport.Messages;
					this.d = new global::System.Collections.Generic.List<global::AcpCommonLib.StatusMessage.StatusMessageInfo>(global::AcpCommonLib.AppInfoManager.StatusMsgReport.Messages);
					num = (short)981008452;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x000563EC File Offset: 0x000545EC
		public bool IsSameStatusMessageInfoList(global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.StatusMessage.StatusMessageInfo> lastList, global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.StatusMessage.StatusMessageInfo> UIFields)
		{
			short num;
			try
			{
				num = (short)1027997696;
				switch (num)
				{
				default:
				{
					num = (short)1272512516;
					int num2 = (int)((global::System.IntPtr)num);
					bool result;
					for (;;)
					{
						global::System.Collections.Generic.List<global::AcpCommonLib.StatusMessage.StatusMessageInfo> list;
						bool flag;
						global::System.Collections.Generic.List<global::AcpCommonLib.StatusMessage.StatusMessageInfo>.Enumerator enumerator;
						switch (num2)
						{
						case 0:
						{
							global::System.Collections.Generic.List<global::AcpCommonLib.StatusMessage.StatusMessageInfo> list2;
							if (list.Count == list2.Count)
							{
								num = (short)546766856;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							flag = false;
							num = (short)554631174;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							goto IL_306;
						case 2:
							try
							{
								num = (short)1414791169;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_2B4;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_1E8;
										}
										continue;
									case 2:
									{
										global::System.Collections.Generic.List<global::AcpCommonLib.StatusMessage.StatusMessageInfo> list2;
										if (list2.Find(new global::System.Predicate<global::AcpCommonLib.StatusMessage.StatusMessageInfo>(CS$<>8__locals1.b)) == null)
										{
											num = (short)1254162435;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 3:
										flag = false;
										num = (short)1701445636;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										goto IL_29B;
									case 5:
										goto IL_29B;
									case 6:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)2065629189;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpCommonLib.StatusMessage.StatusMessageInfo a = enumerator.Current;
										num = (short)1720909826;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_1EA:
									num = (short)1468203014;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_1E8:
									goto IL_1EA;
									IL_29B:
									num = (short)1472528384;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_2B4:
								goto IL_184;
							}
							finally
							{
								((global::System.IDisposable)enumerator).Dispose();
							}
							goto IL_2C7;
						case 3:
						{
							list = new global::System.Collections.Generic.List<global::AcpCommonLib.StatusMessage.StatusMessageInfo>(lastList);
							global::System.Collections.Generic.List<global::AcpCommonLib.StatusMessage.StatusMessageInfo> list2 = new global::System.Collections.Generic.List<global::AcpCommonLib.StatusMessage.StatusMessageInfo>(UIFields);
							flag = true;
							num = (short)269418496;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							switch (0)
							{
							case 0:
								goto IL_6D;
							}
							continue;
						case 5:
							goto IL_1A0;
						case 6:
							goto IL_184;
						case 7:
							if (UIFields != null)
							{
								goto IL_167;
							}
							goto IL_2ED;
						case 8:
							goto IL_2C7;
						case 9:
						{
							num = (short)545445573;
							short num3 = num;
							num = (short)1732368069;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_167;
							default:
								num = (short)131530752;
								if (num != 0)
								{
								}
								num = (short)1498415111;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						IL_6D:
						if (lastList != null)
						{
							num = (short)716767241;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2ED;
						IL_167:
						num = (short)995885059;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_184:
						result = flag;
						num = (short)658505733;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2C7:
						enumerator = list.GetEnumerator();
						num = (short)1024065538;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2ED:
						num = (short)1431699457;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1A0:
					return result;
					IL_306:
					break;
				}
				}
			}
			catch
			{
				return false;
			}
			num = (short)797573121;
			if (num != 0)
			{
			}
			num = (short)1104084992;
			short num4 = num;
			return false;
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00056790 File Offset: 0x00054990
		public bool IsSameFindResultInfoList(global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.FindResult.FindResultInfo> lastList, global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.FindResult.FindResultInfo> UIFields)
		{
			short num;
			bool result;
			try
			{
				num = (short)646512640;
				switch (num)
				{
				default:
				{
					num = (short)1051262980;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.List<global::AcpCommonLib.FindResult.FindResultInfo> list;
						bool flag;
						global::System.Collections.Generic.List<global::AcpCommonLib.FindResult.FindResultInfo>.Enumerator enumerator;
						switch (num2)
						{
						case 0:
						{
							global::System.Collections.Generic.List<global::AcpCommonLib.FindResult.FindResultInfo> list2;
							if (list.Count == list2.Count)
							{
								num = (short)354680840;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							flag = false;
							num = (short)997851142;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							goto IL_30E;
						case 2:
							try
							{
								num = (short)1972240385;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_2BE;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_19B;
										}
										continue;
									case 2:
									{
										global::System.Collections.Generic.List<global::AcpCommonLib.FindResult.FindResultInfo> list2;
										if (list2.Find(new global::System.Predicate<global::AcpCommonLib.FindResult.FindResultInfo>(CS$<>8__locals1.b)) == null)
										{
											num = (short)2094989315;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 3:
										flag = false;
										goto IL_229;
									case 4:
										goto IL_2A5;
									case 5:
										goto IL_2A5;
									case 6:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)575930373;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpCommonLib.FindResult.FindResultInfo a = enumerator.Current;
										num = (short)1672871938;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_19D:
									num = (short)299397581;
									short num3 = num;
									num = (short)1615622605;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										IL_229:
										num = (short)1675362308;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									default:
										num = (short)116588544;
										if (num != 0)
										{
										}
										num = (short)990380038;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_19B:
									goto IL_19D;
									IL_2A5:
									num = (short)500957184;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_2BE:
								goto IL_135;
							}
							finally
							{
								((global::System.IDisposable)enumerator).Dispose();
							}
							goto IL_2D1;
						case 3:
						{
							list = new global::System.Collections.Generic.List<global::AcpCommonLib.FindResult.FindResultInfo>(lastList);
							global::System.Collections.Generic.List<global::AcpCommonLib.FindResult.FindResultInfo> list2 = new global::System.Collections.Generic.List<global::AcpCommonLib.FindResult.FindResultInfo>(UIFields);
							flag = true;
							num = (short)370475008;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							switch (0)
							{
							case 0:
								goto IL_6D;
							}
							continue;
						case 5:
							goto IL_152;
						case 6:
							goto IL_135;
						case 7:
							if (UIFields != null)
							{
								num = (short)1542455299;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2F6;
						case 8:
							goto IL_2D1;
						case 9:
							num = (short)225181703;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_6D:
						if (lastList != null)
						{
							num = (short)1251344393;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F6;
						IL_135:
						result = flag;
						num = (short)146669573;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2D1:
						enumerator = list.GetEnumerator();
						num = (short)1708457986;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2F6:
						num = (short)322240513;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_152:
					goto IL_340;
					IL_30E:
					break;
				}
				}
			}
			catch
			{
				result = false;
				goto IL_340;
			}
			num = (short)1759641601;
			if (num != 0)
			{
			}
			return false;
			IL_340:
			num = (short)154206208;
			short num4 = num;
			return result;
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00056B40 File Offset: 0x00054D40
		public bool IsSameFieldsReportInfoList(global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.FieldsReport.FieldsReportInfo> lastList, global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.FieldsReport.FieldsReportInfo> UIFields)
		{
			short num;
			bool result;
			try
			{
				num = (short)1839202304;
				switch (num)
				{
				default:
				{
					num = (short)819724297;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.List<global::AcpCommonLib.FieldsReport.FieldsReportInfo> list;
						bool flag;
						global::System.Collections.Generic.List<global::AcpCommonLib.FieldsReport.FieldsReportInfo>.Enumerator enumerator;
						switch (num2)
						{
						case 0:
							goto IL_303;
						case 1:
						{
							global::System.Collections.Generic.List<global::AcpCommonLib.FieldsReport.FieldsReportInfo> list2;
							if (list.Count == list2.Count)
							{
								num = (short)1027014661;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							flag = false;
							num = (short)387055618;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_132;
						case 3:
							if (UIFields != null)
							{
								num = (short)2049966088;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2EA;
						case 4:
							goto IL_14E;
						case 5:
							goto IL_2C5;
						case 6:
							try
							{
								num = (short)911343622;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_29A;
									case 1:
										flag = false;
										goto IL_21F;
									case 2:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)813367296;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpCommonLib.FieldsReport.FieldsReportInfo a = enumerator.Current;
										num = (short)99549189;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
										goto IL_29A;
									case 4:
										goto IL_2B2;
									case 5:
									{
										global::System.Collections.Generic.List<global::AcpCommonLib.FieldsReport.FieldsReportInfo> list2;
										if (list2.Find(new global::System.Predicate<global::AcpCommonLib.FieldsReport.FieldsReportInfo>(CS$<>8__locals1.b)) == null)
										{
											num = (short)595329025;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 6:
										switch (0)
										{
										case 0:
											goto IL_195;
										}
										continue;
									}
									IL_197:
									num = (short)635796784;
									short num3 = num;
									num = (short)555842864;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										IL_21F:
										num = (short)475594755;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									default:
										num = (short)493092864;
										if (num != 0)
										{
										}
										num = (short)1047527426;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_195:
									goto IL_197;
									IL_29A:
									num = (short)505806852;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_2B2:
								goto IL_132;
							}
							finally
							{
								((global::System.IDisposable)enumerator).Dispose();
							}
							goto IL_2C5;
						case 7:
							num = (short)1628831747;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
						{
							list = new global::System.Collections.Generic.List<global::AcpCommonLib.FieldsReport.FieldsReportInfo>(lastList);
							global::System.Collections.Generic.List<global::AcpCommonLib.FieldsReport.FieldsReportInfo> list2 = new global::System.Collections.Generic.List<global::AcpCommonLib.FieldsReport.FieldsReportInfo>(UIFields);
							flag = true;
							num = (short)1840578561;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
							switch (0)
							{
							case 0:
								goto IL_6E;
							}
							continue;
						}
						IL_6E:
						if (lastList != null)
						{
							num = (short)1862729735;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2EA;
						IL_132:
						result = flag;
						num = (short)150536196;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2C5:
						enumerator = list.GetEnumerator();
						num = (short)5636102;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2EA:
						num = (short)1158545408;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_14E:
					goto IL_335;
					IL_303:
					break;
				}
				}
			}
			catch
			{
				result = false;
				goto IL_335;
			}
			num = (short)239796225;
			if (num != 0)
			{
			}
			return false;
			IL_335:
			num = (short)796786688;
			short num4 = num;
			return result;
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00056EE4 File Offset: 0x000550E4
		public void RefreshSelectedEventWindow()
		{
			int a_ = 2;
			switch (0)
			{
			case 0:
				goto IL_9D;
			}
			int num;
			short num2;
			global::DevComponents.WpfDock.DockWindow selectedDockWindow;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport != null)
					{
						num2 = (short)1063256092;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					num2 = (short)1543569415;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (selectedDockWindow.Name == global::AcpUI.Common.Utility.c("힗햟횡즥쮧솩ﮫ삭풯", a_))
					{
						num2 = (short)205586441;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)809697292;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_57B;
				case 4:
				{
					num2 = (short)1872953345;
					if (num2 != 0)
					{
					}
					num2 = (short)1397751808;
					short num3 = num2;
					if (selectedDockWindow.Name == global::AcpUI.Common.Utility.c("톗\udb9d\ud89f튡즥쮧솩ﮫ삭풯", a_))
					{
						num2 = (short)1889796112;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1736572936;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					if (selectedDockWindow.Name == global::AcpUI.Common.Utility.c("\ude97瞧잡힣펥쒧\udea9\udfab\udfaf톱\udfb3횷\udeb9", a_))
					{
						goto IL_519;
					}
					num2 = (short)1452081167;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (global::AcpCommonLib.AppInfoManager.FillUpFillDownFieldsReport != null)
					{
						num2 = (short)1268908049;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 7:
					if (global::AcpCommonLib.AppInfoManager.ComparatorFieldsReport != null)
					{
						num2 = (short)2061238299;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 8:
					if (selectedDockWindow.Name == global::AcpUI.Common.Utility.c("\udb97솟킡얣튥잧\ud8a9솭펯\ud9b1\ud8b5\udcb7", a_))
					{
						num2 = (short)1634205697;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1689387013;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					num2 = (short)1261043742;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					if (!selectedDockWindow.IsAutoHide)
					{
						num2 = (short)1379205134;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 11:
					if (global::AcpCommonLib.AppInfoManager.InvalidFieldsReport != null)
					{
						num2 = (short)553189400;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 12:
					if (selectedDockWindow.Name == global::AcpUI.Common.Utility.c("톗ﾝ첟쮡삣솧쾩삫쪭쎯\udbb3햵펷튻\udabd", a_))
					{
						num2 = (short)189399059;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)459603989;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					goto IL_193;
				case 14:
					num2 = (short)1616248834;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					if (selectedDockWindow.Name == global::AcpUI.Common.Utility.c("\ude97튡쾥쒧용솭잯\udcb1\ud9b5\udbb7톹킽꒿", a_))
					{
						num2 = (short)1387397138;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 16:
					num2 = (short)2104557588;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
					global::AcpCommonLib.AppInfoManager.FillUpFillDownFieldsReport.FieldsReportChanged = true;
					num2 = (short)654966809;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
					num2 = (short)1035730950;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					num2 = (short)1383006219;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 20:
					if (global::AcpCommonLib.AppInfoManager.ImportExportFieldsReport != null)
					{
						num2 = (short)554041347;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 21:
					if (selectedDockWindow.Name == global::AcpUI.Common.Utility.c("\udc97\ud89b\uda9d쾟송쾣욧캩", a_))
					{
						num2 = (short)2080899098;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1885143044;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 22:
					num2 = (short)1108017162;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 23:
					if (global::AcpCommonLib.AppInfoManager.FindResultReport != null)
					{
						num2 = (short)938672159;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 24:
					goto IL_2F2;
				case 25:
				{
					num2 = (short)8058229;
					short num4 = num2;
					num2 = (short)883422581;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_519;
					default:
						goto IL_3A1;
					}
					break;
				}
				case 26:
					num2 = (short)834404352;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 27:
					goto IL_1D0;
				case 28:
					goto IL_3F6;
				case 29:
					num2 = (short)1969553431;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 30:
					if (global::AcpCommonLib.AppInfoManager.StatusMsgReport != null)
					{
						num2 = (short)1282867213;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 31:
					goto IL_4DF;
				case 32:
					if (selectedDockWindow != null)
					{
						num2 = (short)1168113686;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_9D;
				IL_519:
				num2 = (short)884736029;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_193:
			global::AcpCommonLib.AppInfoManager.StatusMsgReport.MessageListChanged = true;
			return;
			IL_1D0:
			global::AcpCommonLib.AppInfoManager.ComparatorFieldsReport.FieldsReportChanged = true;
			return;
			IL_2F2:
			global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.FieldsReportChanged = true;
			return;
			IL_3A1:
			num2 = (short)1127940096;
			if (num2 != 0)
			{
			}
			return;
			IL_3F6:
			global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport.FieldsReportChanged = true;
			return;
			IL_4DF:
			global::AcpCommonLib.AppInfoManager.FindResultReport.ResultChanged = true;
			return;
			IL_57B:
			global::AcpCommonLib.AppInfoManager.ImportExportFieldsReport.FieldsReportChanged = true;
			return;
			IL_9D:
			selectedDockWindow = this.aa.SelectedDockWindow;
			num2 = (short)1552482336;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00057514 File Offset: 0x00055714
		private void OnFieldReportUpdated(object A_0, global::AcpUI.Common.FieldReportUpdatedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_3C;
			}
			int num;
			global::AcpUI.Common.DockWndType dockWndType;
			short num2;
			global::AcpCommonLib.FieldReportType fieldReportType;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_16E;
				case 1:
					goto IL_16E;
				case 2:
					return;
				case 3:
					goto IL_16E;
				case 4:
					goto IL_16E;
				case 5:
					this.OpenDockWindow(dockWndType);
					num2 = (short)772603906;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					goto IL_16E;
				case 7:
				{
					num2 = (short)897187840;
					short num3 = num2;
					goto IL_16E;
				}
				case 8:
					num2 = (short)868614148;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (dockWndType != global::AcpUI.Common.DockWndType.UnKnown)
					{
						num2 = (short)20512773;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 10:
					switch (fieldReportType)
					{
					case global::AcpCommonLib.FieldReportType.InvalidFld:
						dockWndType = global::AcpUI.Common.DockWndType.InvalidFields;
						num2 = (short)1733754886;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::AcpCommonLib.FieldReportType.ImpExp:
						dockWndType = global::AcpUI.Common.DockWndType.ImpExp;
						num2 = (short)1841233927;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::AcpCommonLib.FieldReportType.DnD:
						dockWndType = global::AcpUI.Common.DockWndType.DnD;
						break;
					case global::AcpCommonLib.FieldReportType.Comparator:
					{
						dockWndType = global::AcpUI.Common.DockWndType.Comparator;
						num2 = (short)1371472833;
						short num4 = num2;
						num2 = (short)1439171521;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num2 = (short)1407582208;
							if (num2 != 0)
							{
							}
							num2 = (short)1990262785;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case global::AcpCommonLib.FieldReportType.FillUpFillDown:
						dockWndType = global::AcpUI.Common.DockWndType.FillUpFillDown;
						num2 = (short)404815875;
						num = (int)((global::System.IntPtr)num2);
						continue;
					default:
						num2 = (short)42467336;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)470810624;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_3C;
				IL_16E:
				num2 = (short)1841496065;
				if (num2 != 0)
				{
				}
				num2 = (short)1371996169;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_3C:
			dockWndType = global::AcpUI.Common.DockWndType.UnKnown;
			fieldReportType = A_1.FieldReportType;
			num2 = (short)1692336138;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x0005775C File Offset: 0x0005595C
		private void a(global::AcpUI.Common.DockWndType A_0, bool A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			global::DevComponents.WpfDock.DockWindow dockWindow;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (dockWindow.IsMouseWithinAutoHidePopup())
					{
						num2 = (short)521469958;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					this.c(dockWindow);
					this.e = null;
					num2 = (short)1010040839;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (!dockWindow.IsAutoHide)
					{
						num2 = (short)369229829;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)352714754;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					if (A_1)
					{
						goto IL_A4;
					}
					num2 = (short)431489977;
					short num3 = num2;
					num2 = (short)1227162553;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1FA;
					default:
					{
						num2 = (short)194379776;
						short num4 = num2;
						num2 = (short)949813248;
						if (num2 != 0)
						{
						}
						num2 = (short)787415044;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 3:
					num2 = (short)1339490305;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					num2 = (short)1456209920;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_190;
				case 6:
					goto IL_1FA;
				case 7:
					goto IL_1B7;
				case 8:
					if (dockWindow.Dispatcher.CheckAccess())
					{
						num2 = (short)239206403;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_34;
			}
			IL_A4:
			this.OpenDockWindow(A_0);
			return;
			IL_190:
			this.OpenDockWindow(A_0);
			return;
			IL_1B7:
			return;
			IL_1FA:
			goto IL_A4;
			IL_34:
			num2 = (short)1007878145;
			if (num2 != 0)
			{
			}
			dockWindow = this.GetDockWindow(A_0);
			num2 = (short)1824981000;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00057968 File Offset: 0x00055B68
		private void OnComparatorFieldReportChanged(object A_0, global::AcpCommonLib.FieldsReport.NotifyFieldsReportChangedEventArgs A_1)
		{
			short num = (short)1562623440;
			short num2 = num;
			num = (short)1730526672;
			switch (num2 == num)
			{
			}
			num = (short)479985664;
			short num3 = num;
			num = (short)482607104;
			if (num != 0)
			{
			}
			num = (short)2097283073;
			if (num != 0)
			{
			}
			this.a(global::AcpUI.Common.DockWndType.Comparator, global::AcpCommonLib.AppInfoManager.ComparatorFieldsReport.HasFields);
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00057A20 File Offset: 0x00055C20
		private void OnDnDFieldReportChanged(object A_0, global::AcpCommonLib.FieldsReport.NotifyFieldsReportChangedEventArgs A_1)
		{
			short num = (short)1200329109;
			short num2 = num;
			num = (short)1398444437;
			switch (num2 == num)
			{
			}
			num = (short)969474048;
			short num3 = num;
			num = (short)2032795649;
			if (num != 0)
			{
			}
			num = (short)270860288;
			if (num != 0)
			{
			}
			this.a(global::AcpUI.Common.DockWndType.DnD, global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport.HasFields);
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00057ADC File Offset: 0x00055CDC
		private void OnFillUpFillDownFieldReportChanged(object A_0, global::AcpCommonLib.FieldsReport.NotifyFieldsReportChangedEventArgs A_1)
		{
			short num = (short)864669905;
			short num2 = num;
			num = (short)935252177;
			switch (num2 == num)
			{
			}
			num = (short)1562050560;
			short num3 = num;
			num = (short)1437663233;
			if (num != 0)
			{
			}
			num = (short)1454833664;
			if (num != 0)
			{
			}
			this.a(global::AcpUI.Common.DockWndType.FillUpFillDown, global::AcpCommonLib.AppInfoManager.FillUpFillDownFieldsReport.HasFields);
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00057B98 File Offset: 0x00055D98
		private void OnInvalidFieldsReportChanged(object A_0, global::AcpCommonLib.FieldsReport.NotifyFieldsReportChangedEventArgs A_1)
		{
			short num = (short)440769304;
			short num2 = num;
			num = (short)768121624;
			switch (num2 == num)
			{
			}
			num = (short)1327759360;
			short num3 = num;
			num = (short)1281687553;
			if (num != 0)
			{
			}
			num = (short)406585344;
			if (num != 0)
			{
			}
			this.a(global::AcpUI.Common.DockWndType.InvalidFields, global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.UiHasFields);
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00057C50 File Offset: 0x00055E50
		private void OnImportExportFieldReportChanged(object A_0, global::AcpCommonLib.FieldsReport.NotifyFieldsReportChangedEventArgs A_1)
		{
			short num = (short)1837236225;
			if (num != 0)
			{
			}
			num = (short)2057354521;
			short num2 = num;
			num = (short)1657715993;
			switch (num2 == num)
			{
			default:
			{
				num = (short)761331712;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1689190400;
			if (num != 0)
			{
			}
			this.a(global::AcpUI.Common.DockWndType.ImpExp, global::AcpCommonLib.AppInfoManager.ImportExportFieldsReport.HasFields);
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00057D0C File Offset: 0x00055F0C
		private void OnStatusMessageChanged(object A_0, global::AcpCommonLib.StatusMessage.NotifyMsgListChangedEventArgs A_1)
		{
			short num = (short)1758229236;
			short num2 = num;
			num = (short)2087219956;
			switch (num2 == num)
			{
			}
			num = (short)1910636544;
			short num3 = num;
			num = (short)1359413249;
			if (num != 0)
			{
			}
			num = (short)1832255488;
			if (num != 0)
			{
			}
			this.a(global::AcpUI.Common.DockWndType.Output, global::AcpCommonLib.AppInfoManager.StatusMsgReport.HasMsgs);
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x00057DC8 File Offset: 0x00055FC8
		private void OnFindResultChanged(object A_0, global::AcpCommonLib.FindResult.NotifyFindResultChangedEventArgs A_1)
		{
			short num = (short)1424981199;
			short num2 = num;
			num = (short)1902476495;
			switch (num2 == num)
			{
			}
			num = (short)1101398016;
			short num3 = num;
			num = (short)254541825;
			if (num != 0)
			{
			}
			num = (short)1840119808;
			if (num != 0)
			{
			}
			this.a(global::AcpUI.Common.DockWndType.FindResults, global::AcpCommonLib.AppInfoManager.FindResultReport.HasResults);
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00057E80 File Offset: 0x00056080
		private void OnRightPanePinAndDisplayFieldHelpInfo(object A_0, global::AcpUI.Common.CpgFieldNameMouseEventArgs A_1)
		{
			short num = (short)297879780;
			short num2 = num;
			num = (short)589121764;
			switch (num2 == num)
			{
			}
			num = (short)415825920;
			short num3 = num;
			num = (short)1785593857;
			if (num != 0)
			{
			}
			num = (short)1646526464;
			if (num != 0)
			{
			}
			this.PopupDockWindow(global::AcpUI.Common.DockWndType.HelpInfo);
			this.OnRightPaneDisplayFieldHelpInfo(A_0, A_1);
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00057F38 File Offset: 0x00056138
		private void OnRightPaneDisplayFieldHelpInfo(object A_0, global::AcpUI.Common.CpgFieldNameMouseEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_3C;
			}
			int num;
			short num2;
			global::AcpUILib.IAcpUIParentCtrlBase acpUIParentCtrlBase;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_250;
				case 1:
					goto IL_BE;
				case 2:
					goto IL_172;
				case 3:
				{
					global::AcpBusinessLayer.AcpFieldBase myBLObject;
					global::AcpUI.HelpMapData helpMapData;
					if (!this.a.TryGetValue(myBLObject.Name, out helpMapData))
					{
						num2 = (short)863371265;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					this.x.ShowSingleFileHelp(helpMapData.Url);
					num2 = (short)367329284;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					goto IL_1A0;
				case 5:
					num2 = (short)161808390;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
				{
					if (acpUIParentCtrlBase.MyBLObject == null)
					{
						num2 = (short)1564213250;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::AcpBusinessLayer.AcpFieldBase myBLObject = acpUIParentCtrlBase.MyBLObject;
					num2 = (short)1853685767;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 7:
				{
					num2 = (short)1089339392;
					short num3 = num2;
					if (this.a == null)
					{
						num2 = (short)123797504;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)681181187;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 8:
					acpUIParentCtrlBase = (global::AcpUILib.IAcpUIParentCtrlBase)A_0;
					num2 = (short)62193673;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (acpUIParentCtrlBase != null)
					{
						num2 = (short)265814021;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 10:
					if (A_0 is global::AcpUILib.IAcpUIParentCtrlBase)
					{
						num2 = (short)352714760;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_3C;
			}
			for (;;)
			{
				IL_250:
				num2 = (short)1214152550;
				short num4 = num2;
				num2 = (short)28147558;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_122;
				}
			}
			IL_122:
			num2 = (short)13762560;
			if (num2 != 0)
			{
			}
			return;
			IL_BE:
			num2 = (short)1580138497;
			if (num2 != 0)
			{
			}
			return;
			IL_172:
			return;
			IL_1A0:
			return;
			IL_3C:
			acpUIParentCtrlBase = null;
			num2 = (short)563281930;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x0005819C File Offset: 0x0005639C
		public void ChangeColorScheme(global::DevComponents.WpfDock.eDockVisualStyle dockColor, global::System.Windows.Media.Color customBaseColor)
		{
			short num = (short)547422209;
			if (num != 0)
			{
			}
			num = (short)701557410;
			short num2 = num;
			num = (short)549972642;
			switch (num2 == num)
			{
			default:
			{
				num = (short)255655936;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1719140352;
			if (num != 0)
			{
			}
			this.o.ChangeColorScheme(dockColor, customBaseColor);
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00058254 File Offset: 0x00056454
		public AcpIuiPage()
		{
			int a_ = 4;
			this.b = global::ACPBrowser.Utility.HelpRootDir + global::AcpUI.Common.Utility.c("ﾙﲟ쾡얣횥蚧튩솫슭", a_);
			base..ctor();
			this.InitializeComponent();
			this.ad.DataContext = global::AcpCommonLib.AppInfoManager.InvalidFieldsReport;
			global::System.Windows.Application.Current.Resources.MergedDictionaries.Add(new global::DevComponents.WpfDock.themes.Office2007SilverSkin());
			global::AcpUI.Common.Utility.FieldsReportUpdatedEvent += this.OnFieldReportUpdated;
			global::AcpCommonLib.StatusMessage.StatusMessagesManager.NotifyMsgListChangedEvent += this.OnStatusMessageChanged;
			global::AcpCommonLib.FindResult.FindResultsManager.NotifyFindResultChangedEvent += this.OnFindResultChanged;
			global::AcpUI.Common.Utility.CpgFieldNameMouseDoubleClickEvent += this.OnRightPanePinAndDisplayFieldHelpInfo;
			global::AcpUI.Common.Utility.CpgFieldNameMouseClickEvent += this.OnRightPaneDisplayFieldHelpInfo;
			global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.NotifyFieldsReportChangedEvent += this.OnInvalidFieldsReportChanged;
			if (global::AcpCommonLib.AppInfoManager.ImportExportFieldsReport == null)
			{
				global::AcpCommonLib.AppInfoManager.ImportExportFieldsReport = new global::AcpCommonLib.FieldsReport.FieldsReportManager();
			}
			global::AcpCommonLib.AppInfoManager.ImportExportFieldsReport.NotifyFieldsReportChangedEvent += this.OnImportExportFieldReportChanged;
			if (global::AcpCommonLib.AppInfoManager.ComparatorFieldsReport == null)
			{
				global::AcpCommonLib.AppInfoManager.ComparatorFieldsReport = new global::AcpCommonLib.FieldsReport.FieldsReportManager();
			}
			global::AcpCommonLib.AppInfoManager.ComparatorFieldsReport.NotifyFieldsReportChangedEvent += this.OnComparatorFieldReportChanged;
			if (global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport == null)
			{
				global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport = new global::AcpCommonLib.FieldsReport.FieldsReportManager();
			}
			global::AcpCommonLib.AppInfoManager.DragAndDropFieldsReport.NotifyFieldsReportChangedEvent += this.OnDnDFieldReportChanged;
			if (global::AcpCommonLib.AppInfoManager.FillUpFillDownFieldsReport == null)
			{
				global::AcpCommonLib.AppInfoManager.FillUpFillDownFieldsReport = new global::AcpCommonLib.FieldsReport.FieldsReportManager();
			}
			global::AcpCommonLib.AppInfoManager.FillUpFillDownFieldsReport.NotifyFieldsReportChangedEvent += this.OnFillUpFillDownFieldReportChanged;
			this.a = global::AcpUI.HelpMapProvider.ParseHelpMapFile(this.b);
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x000583E8 File Offset: 0x000565E8
		private void FrameCenterTop_Navigated(object A_0, global::System.Windows.Navigation.NavigationEventArgs A_1)
		{
			short num = (short)534642689;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					global::AcpCommonLib.AppInfoManager.ClearNavigationHistory = false;
					num = (short)570452209;
					short num3 = num;
					num = (short)1828874481;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_9B;
					default:
					{
						num = (short)963575809;
						if (num != 0)
						{
						}
						num = (short)1141112832;
						if (num != 0)
						{
						}
						num = (short)1470234624;
						short num4 = num;
						num = (short)2017525765;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_40;
					}
					continue;
				case 2:
					goto IL_61;
				case 3:
					goto IL_61;
				case 4:
				{
					global::System.Windows.Controls.Frame frame = (global::System.Windows.Controls.Frame)A_0;
					num = (short)64028674;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					return;
				case 6:
				{
					global::System.Windows.Controls.Frame frame;
					if (!frame.CanGoBack)
					{
						num = (short)1001652224;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					frame.RemoveBackEntry();
					goto IL_9B;
				}
				}
				IL_40:
				if (global::AcpCommonLib.AppInfoManager.ClearNavigationHistory)
				{
					num = (short)1054932996;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_61:
				num = (short)2069626886;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_9B:
				num = (short)1238695939;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00058588 File Offset: 0x00056788
		private void FrameInvalidFields_LoadCompleted(object A_0, global::System.Windows.Navigation.NavigationEventArgs A_1)
		{
			short num = (short)112786667;
			short num2 = num;
			num = (short)645528811;
			switch (num2 == num)
			{
			}
			num = (short)758317057;
			if (num != 0)
			{
			}
			num = (short)431489024;
			short num3 = num;
			num = (short)1166606336;
			if (num != 0)
			{
			}
			global::System.Windows.Controls.Frame a_ = A_0 as global::System.Windows.Controls.Frame;
			this.a(a_);
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00058640 File Offset: 0x00056840
		private void FrameDnD_LoadCompleted(object A_0, global::System.Windows.Navigation.NavigationEventArgs A_1)
		{
			short num = (short)1607771101;
			short num2 = num;
			num = (short)265987037;
			switch (num2 == num)
			{
			}
			num = (short)1306918913;
			if (num != 0)
			{
			}
			num = (short)585170944;
			short num3 = num;
			num = (short)597032960;
			if (num != 0)
			{
			}
			global::System.Windows.Controls.Frame a_ = A_0 as global::System.Windows.Controls.Frame;
			this.a(a_);
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x000586F8 File Offset: 0x000568F8
		private void FrameFillUpFillDown_LoadCompleted(object A_0, global::System.Windows.Navigation.NavigationEventArgs A_1)
		{
			short num = (short)726885207;
			short num2 = num;
			num = (short)1510826839;
			switch (num2 == num)
			{
			}
			num = (short)814350337;
			if (num != 0)
			{
			}
			num = (short)149946368;
			short num3 = num;
			num = (short)316866560;
			if (num != 0)
			{
			}
			global::System.Windows.Controls.Frame a_ = A_0 as global::System.Windows.Controls.Frame;
			this.a(a_);
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x000587B0 File Offset: 0x000569B0
		private void FrameImpExp_LoadCompleted(object A_0, global::System.Windows.Navigation.NavigationEventArgs A_1)
		{
			short num = (short)310190953;
			short num2 = num;
			num = (short)1497441129;
			switch (num2 == num)
			{
			}
			num = (short)1486684160;
			if (num != 0)
			{
			}
			num = (short)1629552640;
			short num3 = num;
			num = (short)109707265;
			if (num != 0)
			{
			}
			global::System.Windows.Controls.Frame a_ = A_0 as global::System.Windows.Controls.Frame;
			this.a(a_);
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00058868 File Offset: 0x00056A68
		private void FrameComparator_LoadCompleted(object A_0, global::System.Windows.Navigation.NavigationEventArgs A_1)
		{
			short num = (short)618204261;
			short num2 = num;
			num = (short)1751911525;
			switch (num2 == num)
			{
			}
			num = (short)679411713;
			if (num != 0)
			{
			}
			num = (short)1713635328;
			short num3 = num;
			num = (short)913637376;
			if (num != 0)
			{
			}
			global::System.Windows.Controls.Frame a_ = A_0 as global::System.Windows.Controls.Frame;
			this.a(a_);
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00058924 File Offset: 0x00056B24
		private void FrameFindResults_LoadCompleted(object A_0, global::System.Windows.Navigation.NavigationEventArgs A_1)
		{
			short num = (short)1430486286;
			short num2 = num;
			num = (short)453606670;
			switch (num2 == num)
			{
			}
			num = (short)361889793;
			if (num != 0)
			{
			}
			num = (short)1684865024;
			short num3 = num;
			num = (short)1801650176;
			if (num != 0)
			{
			}
			global::System.Windows.Controls.Frame a_ = A_0 as global::System.Windows.Controls.Frame;
			this.a(a_);
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x000589DC File Offset: 0x00056BDC
		private void FrameSysKeyReport_LoadCompleted(object A_0, global::System.Windows.Navigation.NavigationEventArgs A_1)
		{
			short num = (short)818300686;
			short num2 = num;
			num = (short)1150830350;
			switch (num2 == num)
			{
			}
			num = (short)2126839808;
			if (num != 0)
			{
			}
			num = (short)1617297408;
			short num3 = num;
			num = (short)2070282241;
			if (num != 0)
			{
			}
			global::System.Windows.Controls.Frame a_ = A_0 as global::System.Windows.Controls.Frame;
			this.a(a_);
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00058A94 File Offset: 0x00056C94
		private void a(global::System.Windows.Controls.Frame A_0)
		{
			short num = (short)1828192258;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (A_0.BackStack != null)
					{
						num = (short)1357447172;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					goto IL_FB;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_46;
					}
					continue;
				case 3:
				{
					if (A_0.CanGoBack)
					{
						A_0.RemoveBackEntry();
						num = (short)30670849;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1922248685;
					short num3 = num;
					num = (short)175910893;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_95;
					default:
					{
						num = (short)1794965504;
						if (num != 0)
						{
						}
						num = (short)306642944;
						short num4 = num;
						num = (short)1969029126;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 4:
					num = (short)2020409351;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_95;
				case 6:
					return;
				case 7:
					goto IL_FB;
				}
				IL_46:
				if (A_0 != null)
				{
					num = (short)846528517;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_95:
				num = (short)508428289;
				if (num != 0)
				{
				}
				num = (short)1582432256;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_FB:
				num = (short)1983512579;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00058C50 File Offset: 0x00056E50
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.17.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 11;
			while (this.@as)
			{
				short num = (short)2088239105;
				if (num != 0)
				{
				}
				num = (short)1844302932;
				short num2 = num;
				num = (short)1149293652;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					break;
				default:
				{
					num = (short)1212284928;
					short num3 = num;
					break;
				}
				}
				num = (short)1982726144;
				if (num != 0)
				{
				}
				return;
			}
			this.@as = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::AcpUI.Common.Utility.c("躠욤힦ﲨ隬첮\udeb0\udeb2어\ud8b6ힸ\udeba펼쮾ꋂ뗄럆돊곌ꋎ뷐", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00058D34 File Offset: 0x00056F34
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.17.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal global::System.Delegate a(global::System.Type A_0, string A_1)
		{
			short num = (short)928622969;
			short num2 = num;
			num = (short)428779897;
			switch (num2 == num)
			{
			}
			num = (short)1905197057;
			if (num != 0)
			{
			}
			num = (short)1066270720;
			short num3 = num;
			num = (short)2022572032;
			if (num != 0)
			{
			}
			return global::System.Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00058DE8 File Offset: 0x00056FE8
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.17.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1299316737;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1575747585;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					goto IL_2B2;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_5A;
					}
					continue;
				case 2:
					num = (short)1684930560;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_5A:
				switch (connectionId)
				{
				case 1:
					goto IL_4C6;
				case 2:
					goto IL_3B4;
				case 3:
					goto IL_15C;
				case 4:
					goto IL_30E;
				case 5:
					goto IL_301;
				case 6:
					goto IL_12B;
				case 7:
					goto IL_190;
				case 8:
					goto IL_38D;
				case 9:
					goto IL_31B;
				case 10:
					goto IL_380;
				case 11:
					goto IL_3A7;
				case 12:
					goto IL_1E5;
				case 13:
					goto IL_359;
				case 14:
					goto IL_366;
				case 15:
					goto IL_469;
				case 16:
					goto IL_183;
				case 17:
					goto IL_11E;
				case 18:
					goto IL_4E0;
				case 19:
					goto IL_373;
				case 20:
					goto IL_476;
				case 21:
					goto IL_169;
				case 22:
					goto IL_FA;
				case 23:
					goto IL_4D3;
				case 24:
					goto IL_335;
				case 25:
					goto IL_39A;
				case 26:
					goto IL_138;
				case 27:
					goto IL_328;
				case 28:
					goto IL_19D;
				case 29:
					goto IL_176;
				case 30:
					goto IL_504;
				case 31:
					goto IL_1C1;
				default:
					num = (short)1972764674;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_FA:
			this.ai = (global::System.Windows.Controls.Frame)target;
			this.ai.LoadCompleted += this.FrameImpExp_LoadCompleted;
			return;
			IL_11E:
			this.ad = (global::AcpUI.AcpDockWindow)target;
			return;
			IL_12B:
			this.s = (global::System.Windows.Controls.Frame)target;
			return;
			IL_138:
			this.am = (global::System.Windows.Controls.Frame)target;
			this.am.LoadCompleted += this.FrameFillUpFillDown_LoadCompleted;
			return;
			IL_15C:
			this.p = (global::DevComponents.WpfDock.SplitPanel)target;
			return;
			IL_169:
			this.ah = (global::AcpUI.AcpDockWindow)target;
			return;
			IL_176:
			this.ap = (global::AcpUI.AcpDockWindow)target;
			return;
			IL_183:
			this.ac = (global::System.Windows.Controls.Frame)target;
			return;
			IL_190:
			this.t = (global::DevComponents.WpfDock.SplitPanel)target;
			return;
			IL_19D:
			this.ao = (global::System.Windows.Controls.Frame)target;
			this.ao.LoadCompleted += this.FrameFindResults_LoadCompleted;
			return;
			IL_1C1:
			this.ar = (global::System.Windows.Controls.Frame)target;
			this.ar.Navigated += this.FrameCenterTop_Navigated;
			return;
			IL_1E5:
			this.y = (global::DevComponents.WpfDock.DockSite)target;
			this.y.AddHandler(global::DevComponents.WpfDock.DockWindow.ActivatedEvent, new global::System.Windows.RoutedEventHandler(this.DockWindowActivated));
			this.y.AddHandler(global::DevComponents.WpfDock.DockWindow.DeactivatedEvent, new global::System.Windows.RoutedEventHandler(this.DockWindowDeactivated));
			this.y.AddHandler(global::DevComponents.WpfDock.DockWindow.AutoHideOpenChangedEvent, new global::System.Windows.RoutedEventHandler(this.DockWindowActivated));
			this.y.AddHandler(global::DevComponents.WpfDock.DockWindow.AutoHideChangedEvent, new global::System.Windows.RoutedEventHandler(this.AutoHideChanged));
			this.y.AddHandler(global::DevComponents.WpfDock.DockWindow.ClosingEvent, new global::DevComponents.WpfDock.CancelSourceRoutedEventHandler(this.DockWindowClosing));
			this.y.AddHandler(global::DevComponents.WpfDock.DockWindow.ClosedEvent, new global::System.Windows.RoutedEventHandler(this.DockWindowClosed));
			return;
			IL_2B2:
			num = (short)369133618;
			short num3 = num;
			num = (short)720930866;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_335:
				this.ak = (global::System.Windows.Controls.Frame)target;
				this.ak.LoadCompleted += this.FrameComparator_LoadCompleted;
				return;
			default:
				num = (short)175702016;
				if (num != 0)
				{
				}
				this.@as = true;
				return;
			}
			IL_301:
			this.r = (global::AcpUI.AcpDockWindow)target;
			return;
			IL_30E:
			this.q = (global::DevComponents.WpfDock.DockWindowGroup)target;
			return;
			IL_31B:
			this.v = (global::AcpUI.AcpDockWindow)target;
			return;
			IL_328:
			this.an = (global::AcpUI.AcpDockWindow)target;
			return;
			IL_359:
			this.z = (global::DevComponents.WpfDock.SplitPanel)target;
			return;
			IL_366:
			this.aa = (global::DevComponents.WpfDock.DockWindowGroup)target;
			return;
			IL_373:
			this.af = (global::AcpUI.AcpDockWindow)target;
			return;
			IL_380:
			this.w = (global::System.Windows.Controls.Frame)target;
			return;
			IL_38D:
			this.u = (global::DevComponents.WpfDock.DockWindowGroup)target;
			return;
			IL_39A:
			this.al = (global::AcpUI.AcpDockWindow)target;
			return;
			IL_3A7:
			this.x = (global::ACPBrowser.ContextHelp)target;
			return;
			IL_3B4:
			this.o = (global::DevComponents.WpfDock.DockSite)target;
			this.o.AddHandler(global::DevComponents.WpfDock.DockWindow.ActivatedEvent, new global::System.Windows.RoutedEventHandler(this.DockWindowActivated));
			this.o.AddHandler(global::DevComponents.WpfDock.DockWindow.DeactivatedEvent, new global::System.Windows.RoutedEventHandler(this.DockWindowDeactivated));
			this.o.AddHandler(global::DevComponents.WpfDock.DockWindow.AutoHideOpenChangedEvent, new global::System.Windows.RoutedEventHandler(this.DockWindowActivated));
			this.o.AddHandler(global::DevComponents.WpfDock.DockWindow.AutoHideChangedEvent, new global::System.Windows.RoutedEventHandler(this.AutoHideChanged));
			this.o.AddHandler(global::DevComponents.WpfDock.DockWindow.ClosingEvent, new global::DevComponents.WpfDock.CancelSourceRoutedEventHandler(this.DockWindowClosing));
			this.o.AddHandler(global::DevComponents.WpfDock.DockWindow.ClosedEvent, new global::System.Windows.RoutedEventHandler(this.DockWindowClosed));
			return;
			IL_469:
			this.ab = (global::AcpUI.AcpDockWindow)target;
			return;
			IL_476:
			num = (short)1999241216;
			short num4 = num;
			this.ag = (global::System.Windows.Controls.Frame)target;
			this.ag.LoadCompleted += this.FrameDnD_LoadCompleted;
			return;
			IL_4C6:
			this.n = (global::System.Windows.Controls.Frame)target;
			return;
			IL_4D3:
			this.aj = (global::AcpUI.AcpDockWindow)target;
			return;
			IL_4E0:
			this.ae = (global::System.Windows.Controls.Frame)target;
			this.ae.LoadCompleted += this.FrameInvalidFields_LoadCompleted;
			return;
			IL_504:
			this.aq = (global::System.Windows.Controls.Frame)target;
			this.aq.LoadCompleted += this.FrameSysKeyReport_LoadCompleted;
		}

		// Token: 0x04000270 RID: 624
		private global::System.Collections.Generic.Dictionary<string, global::AcpUI.HelpMapData> a;

		// Token: 0x04000271 RID: 625
		private string b;

		// Token: 0x04000272 RID: 626
		private bool c;

		// Token: 0x04000273 RID: 627
		private global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.StatusMessage.StatusMessageInfo> d;

		// Token: 0x04000274 RID: 628
		private global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.FieldsReport.FieldsReportInfo> e;

		// Token: 0x04000275 RID: 629
		private global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.FieldsReport.FieldsReportInfo> f;

		// Token: 0x04000276 RID: 630
		private global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.FieldsReport.FieldsReportInfo> g;

		// Token: 0x04000277 RID: 631
		private global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.FieldsReport.FieldsReportInfo> h;

		// Token: 0x04000278 RID: 632
		private global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.FindResult.FindResultInfo> i;

		// Token: 0x04000279 RID: 633
		private global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.FieldsReport.FieldsReportInfo> j;

		// Token: 0x0400027A RID: 634
		private global::AcpUI.Common.PageOutputMessage k;

		// Token: 0x0400027B RID: 635
		private global::AcpUI.Common.PageFieldsReport l;

		// Token: 0x0400027C RID: 636
		private global::AcpUI.Common.PageReportSystemKeys m;

		// Token: 0x0400027D RID: 637
		internal global::System.Windows.Controls.Frame n;

		// Token: 0x0400027E RID: 638
		internal global::DevComponents.WpfDock.DockSite o;

		// Token: 0x0400027F RID: 639
		internal global::DevComponents.WpfDock.SplitPanel p;

		// Token: 0x04000280 RID: 640
		internal global::DevComponents.WpfDock.DockWindowGroup q;

		// Token: 0x04000281 RID: 641
		internal global::AcpUI.AcpDockWindow r;

		// Token: 0x04000282 RID: 642
		internal global::System.Windows.Controls.Frame s;

		// Token: 0x04000283 RID: 643
		internal global::DevComponents.WpfDock.SplitPanel t;

		// Token: 0x04000284 RID: 644
		internal global::DevComponents.WpfDock.DockWindowGroup u;

		// Token: 0x04000285 RID: 645
		internal global::AcpUI.AcpDockWindow v;

		// Token: 0x04000286 RID: 646
		internal global::System.Windows.Controls.Frame w;

		// Token: 0x04000287 RID: 647
		internal global::ACPBrowser.ContextHelp x;

		// Token: 0x04000288 RID: 648
		internal global::DevComponents.WpfDock.DockSite y;

		// Token: 0x04000289 RID: 649
		internal global::DevComponents.WpfDock.SplitPanel z;

		// Token: 0x0400028A RID: 650
		internal global::DevComponents.WpfDock.DockWindowGroup aa;

		// Token: 0x0400028B RID: 651
		internal global::AcpUI.AcpDockWindow ab;

		// Token: 0x0400028C RID: 652
		internal global::System.Windows.Controls.Frame ac;

		// Token: 0x0400028D RID: 653
		internal global::AcpUI.AcpDockWindow ad;

		// Token: 0x0400028E RID: 654
		internal global::System.Windows.Controls.Frame ae;

		// Token: 0x0400028F RID: 655
		internal global::AcpUI.AcpDockWindow af;

		// Token: 0x04000290 RID: 656
		internal global::System.Windows.Controls.Frame ag;

		// Token: 0x04000291 RID: 657
		internal global::AcpUI.AcpDockWindow ah;

		// Token: 0x04000292 RID: 658
		internal global::System.Windows.Controls.Frame ai;

		// Token: 0x04000293 RID: 659
		internal global::AcpUI.AcpDockWindow aj;

		// Token: 0x04000294 RID: 660
		internal global::System.Windows.Controls.Frame ak;

		// Token: 0x04000295 RID: 661
		internal global::AcpUI.AcpDockWindow al;

		// Token: 0x04000296 RID: 662
		internal global::System.Windows.Controls.Frame am;

		// Token: 0x04000297 RID: 663
		internal global::AcpUI.AcpDockWindow an;

		// Token: 0x04000298 RID: 664
		internal global::System.Windows.Controls.Frame ao;

		// Token: 0x04000299 RID: 665
		internal global::AcpUI.AcpDockWindow ap;

		// Token: 0x0400029A RID: 666
		internal global::System.Windows.Controls.Frame aq;

		// Token: 0x0400029B RID: 667
		internal global::System.Windows.Controls.Frame ar;

		// Token: 0x0400029C RID: 668
		private bool @as;
	}
}
