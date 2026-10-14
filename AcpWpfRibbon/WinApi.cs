using System;
using System.Runtime.InteropServices;
using System.Windows;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon
{
	// Token: 0x020000A7 RID: 167
	internal class WinApi
	{
		// Token: 0x0600083A RID: 2106
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern bool IsZoomed(global::System.IntPtr hWnd);

		// Token: 0x0600083B RID: 2107
		[global::System.Runtime.InteropServices.DllImport("user32")]
		public static extern int SendMessage(global::System.IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x0600083C RID: 2108
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern int TrackPopupMenu(global::System.IntPtr hMenu, uint uFlags, int x, int y, int nReserved, global::System.IntPtr hWnd, global::System.IntPtr prcRect);

		// Token: 0x0600083D RID: 2109
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern global::System.IntPtr GetSystemMenu(global::System.IntPtr hWnd, bool bRevert);

		// Token: 0x0600083E RID: 2110
		[global::System.Runtime.InteropServices.DllImport("user32")]
		public static extern bool PostMessage(global::System.IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x0600083F RID: 2111
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern int SetWindowRgn(global::System.IntPtr hWnd, global::System.IntPtr hRgn, bool bRedraw);

		// Token: 0x06000840 RID: 2112
		[global::System.Runtime.InteropServices.DllImport("gdi32.dll")]
		public static extern global::System.IntPtr CreateRoundRectRgn(int x1, int y1, int x2, int y2, int cx, int cy);

		// Token: 0x06000841 RID: 2113
		[global::System.Runtime.InteropServices.DllImport("gdi32.dll")]
		public static extern global::System.IntPtr CreateRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect);

		// Token: 0x06000842 RID: 2114
		[global::System.Runtime.InteropServices.DllImport("gdi32.dll")]
		public static extern int CombineRgn(global::System.IntPtr hrgnDest, global::System.IntPtr hrgnSrc1, global::System.IntPtr hrgnSrc2, int fnCombineMode);

		// Token: 0x06000843 RID: 2115
		[global::System.Runtime.InteropServices.DllImport("user32")]
		public static extern int SetWindowLong(global::System.IntPtr hWnd, int nIndex, int dwNewLong);

		// Token: 0x06000844 RID: 2116
		[global::System.Runtime.InteropServices.DllImport("user32")]
		public static extern int GetWindowLong(global::System.IntPtr hWnd, int nIndex);

		// Token: 0x06000845 RID: 2117
		[global::System.Runtime.InteropServices.DllImport("user32")]
		public static extern bool SetWindowPos(global::System.IntPtr hWnd, global::System.IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, int uFlags);

		// Token: 0x06000846 RID: 2118
		[global::System.Runtime.InteropServices.DllImport("user32")]
		public static extern bool GetMonitorInfo(global::System.IntPtr hMonitor, global::DevComponents.WpfRibbon.WinApi.MONITORINFO lpmi);

		// Token: 0x06000847 RID: 2119
		[global::System.Runtime.InteropServices.DllImport("User32")]
		public static extern global::System.IntPtr MonitorFromWindow(global::System.IntPtr handle, int flags);

		// Token: 0x06000848 RID: 2120
		[global::System.Runtime.InteropServices.DllImport("dwmapi.dll")]
		public static extern int DwmDefWindowProc(global::System.IntPtr hwnd, int msg, global::System.IntPtr wParam, global::System.IntPtr lParam, out global::System.IntPtr plResult);

		// Token: 0x06000849 RID: 2121
		[global::System.Runtime.InteropServices.DllImport("user32")]
		public static extern bool GetWindowRect(global::System.IntPtr hWnd, ref global::DevComponents.WpfRibbon.WinApi.RECT r);

		// Token: 0x0600084A RID: 2122
		[global::System.Runtime.InteropServices.DllImport("gdi32.dll")]
		public static extern bool DeleteObject(global::System.IntPtr hObject);

		// Token: 0x0600084B RID: 2123
		[global::System.Runtime.InteropServices.DllImport("dwmapi.dll", PreserveSig = false)]
		private static extern bool DwmIsCompositionEnabled();

		// Token: 0x0600084C RID: 2124
		[global::System.Runtime.InteropServices.DllImport("dwmapi.dll")]
		private static extern int DwmExtendFrameIntoClientArea(global::System.IntPtr hWnd, ref global::DevComponents.WpfRibbon.WinApi.MARGINS pMargins);

		// Token: 0x0600084D RID: 2125 RVA: 0x000C0114 File Offset: 0x000BE314
		public static void ExtendGlass(global::System.IntPtr handle, int glassHeight)
		{
			short num = (short)411605510;
			short num2 = num;
			num = (short)219060742;
			switch (num2 == num)
			{
			}
			num = (short)1104347136;
			if (num != 0)
			{
			}
			num = (short)260702208;
			short num3 = num;
			num = (short)417595393;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.WinApi.MARGINS margins = default(global::DevComponents.WpfRibbon.WinApi.MARGINS);
			margins.cxLeftWidth = 0;
			margins.cxRightWidth = 0;
			margins.cyTopHeight = glassHeight;
			margins.cyBottomHeight = 0;
			global::DevComponents.WpfRibbon.WinApi.DwmExtendFrameIntoClientArea(handle, ref margins);
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x0600084E RID: 2126 RVA: 0x000C01F0 File Offset: 0x000BE3F0
		public static bool IsGlassEnabled
		{
			get
			{
				short num;
				if (global::System.Environment.OSVersion.Version.Major < 6)
				{
					num = (short)168230913;
					if (num != 0)
					{
					}
					num = (short)58716787;
					short num2 = num;
					num = (short)1801712243;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1652162560;
						if (num != 0)
						{
						}
						return false;
					}
				}
				num = (short)431030272;
				short num3 = num;
				return global::DevComponents.WpfRibbon.WinApi.DwmIsCompositionEnabled();
			}
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x000C02B4 File Offset: 0x000BE4B4
		public static int LOWORD(int n)
		{
			short num = (short)263655883;
			short num2 = num;
			num = (short)875631051;
			switch (num2 == num)
			{
			}
			num = (short)1121058817;
			if (num != 0)
			{
			}
			num = (short)2027290624;
			short num3 = num;
			num = (short)1895301120;
			if (num != 0)
			{
			}
			return (int)((short)(n & 65535));
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x000C0368 File Offset: 0x000BE568
		public static int HIWORD(int n)
		{
			short num = (short)238970051;
			short num2 = num;
			num = (short)1424254147;
			switch (num2 == num)
			{
			}
			num = (short)1418133505;
			if (num != 0)
			{
			}
			num = (short)1045954560;
			short num3 = num;
			num = (short)997654528;
			if (num != 0)
			{
			}
			return (int)((short)(n >> 16 & 65535));
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x000C0418 File Offset: 0x000BE618
		public static int LOWORD(global::System.IntPtr n)
		{
			short num = (short)1718741714;
			short num2 = num;
			num = (short)1849158354;
			switch (num2 == num)
			{
			}
			num = (short)1662844928;
			if (num != 0)
			{
			}
			num = (short)87031808;
			short num3 = num;
			num = (short)1116209153;
			if (num != 0)
			{
			}
			return global::DevComponents.WpfRibbon.WinApi.LOWORD((int)((long)n));
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x000C04D0 File Offset: 0x000BE6D0
		public static int HIWORD(global::System.IntPtr n)
		{
			short num = (short)398084201;
			short num2 = num;
			num = (short)80037993;
			switch (num2 == num)
			{
			}
			num = (short)1838481409;
			if (num != 0)
			{
			}
			num = (short)1855520768;
			short num3 = num;
			num = (short)1221328896;
			if (num != 0)
			{
			}
			return global::DevComponents.WpfRibbon.WinApi.HIWORD((int)((long)n));
		}

		// Token: 0x06000853 RID: 2131
		[global::System.Runtime.InteropServices.DllImport("user32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, ExactSpelling = true)]
		public static extern int GetSystemMetrics(int nIndex);

		// Token: 0x06000854 RID: 2132
		[global::System.Runtime.InteropServices.DllImport("user32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto)]
		public static extern bool SystemParametersInfo(int nAction, int nParam, ref int value, int ignore);

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000855 RID: 2133 RVA: 0x000C0588 File Offset: 0x000BE788
		public static global::System.Windows.Size FrameBorderSize
		{
			get
			{
				short num = (short)1491744676;
				short num2 = num;
				num = (short)1329543076;
				switch (num2 == num)
				{
				}
				num = (short)1847263233;
				if (num != 0)
				{
				}
				num = (short)874905600;
				short num3 = num;
				num = (short)940310528;
				if (num != 0)
				{
				}
				return new global::System.Windows.Size((double)global::DevComponents.WpfRibbon.WinApi.GetSystemMetrics(32), (double)global::DevComponents.WpfRibbon.WinApi.GetSystemMetrics(33));
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000856 RID: 2134 RVA: 0x000C0648 File Offset: 0x000BE848
		public static int BorderMultiplierFactor
		{
			get
			{
				short num = (short)744602798;
				short num2 = num;
				num = (short)1714338990;
				switch (num2 == num)
				{
				}
				num = (short)1635450881;
				if (num != 0)
				{
				}
				num = (short)1940455424;
				short num3 = num;
				num = (short)12386304;
				if (num != 0)
				{
				}
				int result = 0;
				global::DevComponents.WpfRibbon.WinApi.SystemParametersInfo(5, 0, ref result, 0);
				return result;
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000857 RID: 2135 RVA: 0x000C0700 File Offset: 0x000BE900
		public static int CaptionHeight
		{
			get
			{
				short num = (short)1896958102;
				short num2 = num;
				num = (short)253577366;
				switch (num2 == num)
				{
				}
				num = (short)798949377;
				if (num != 0)
				{
				}
				num = (short)1701117952;
				short num3 = num;
				num = (short)1308295168;
				if (num != 0)
				{
				}
				return global::DevComponents.WpfRibbon.WinApi.GetSystemMetrics(4);
			}
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x000C07B4 File Offset: 0x000BE9B4
		internal static global::System.Windows.WindowState WindowStateFromParam(global::System.IntPtr wParam)
		{
			short num = (short)354325697;
			short num2 = num;
			num = (short)1962054849;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return global::System.Windows.WindowState.Minimized;
			case 1:
				break;
			default:
			{
				num = (short)1291780096;
				short num3 = num;
				break;
			}
			}
			num = (short)21299200;
			if (num != 0)
			{
			}
			num = (short)1994784770;
			int num4 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num4)
				{
				case 0:
					if (wParam.ToInt32() == 1)
					{
						num = (short)1900412929;
						if (num != 0)
						{
						}
						num = (short)1037828097;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return global::System.Windows.WindowState.Normal;
				case 1:
					goto IL_129;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_A7;
					}
					continue;
				case 3:
					return global::System.Windows.WindowState.Maximized;
				}
				IL_A7:
				if (wParam.ToInt32() == 2)
				{
					num = (short)493551619;
					num4 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1476329472;
					num4 = (int)((global::System.IntPtr)num);
				}
			}
			return global::System.Windows.WindowState.Maximized;
			IL_129:
			return global::System.Windows.WindowState.Minimized;
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x000C08F0 File Offset: 0x000BEAF0
		static WinApi()
		{
			short num2;
			global::System.Version version;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_28;
				}
				int num;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)1255473152;
						short num3 = num2;
						num2 = (short)1116798979;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 1:
						if (version.Minor >= 1)
						{
							num2 = (short)1131741184;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_6C;
					case 2:
						if (version.Major >= 6)
						{
							num2 = (short)1248198660;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_6C;
					case 3:
						goto IL_112;
					case 4:
						num2 = (short)1839661057;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
						goto IL_80;
					}
					goto IL_28;
					IL_6C:
					num2 = (short)1949892613;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_80:
				num2 = (short)11307125;
				short num4 = num2;
				num2 = (short)1545111669;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_B4;
				}
				IL_28:
				version = global::System.Environment.OSVersion.Version;
				num2 = (short)286588930;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_B4:
			num2 = (short)1334575104;
			if (num2 != 0)
			{
			}
			bool isWindows = false;
			goto IL_18A;
			IL_112:
			num2 = (short)1145831425;
			if (num2 != 0)
			{
			}
			isWindows = (version.Build >= 7000);
			IL_18A:
			global::DevComponents.WpfRibbon.WinApi._IsWindows7 = isWindows;
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x0600085A RID: 2138 RVA: 0x000C0A8C File Offset: 0x000BEC8C
		public static bool IsWindows7
		{
			get
			{
				short num = (short)478850319;
				short num2 = num;
				num = (short)1890692367;
				switch (num2 == num)
				{
				}
				num = (short)598999041;
				if (num != 0)
				{
				}
				num = (short)598409216;
				short num3 = num;
				num = (short)927268864;
				if (num != 0)
				{
				}
				return global::DevComponents.WpfRibbon.WinApi._IsWindows7;
			}
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x000C0B3C File Offset: 0x000BED3C
		internal static void ValidateLicenseKey(string p)
		{
			int a_ = 18;
			short num;
			if (p == global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⹩⵫⩭䡯䉱䝳䙵䡷㹹㵻䱽뉿", a_))
			{
				num = (short)1604970398;
				short num2 = num;
				num = (short)1641670558;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)753991681;
					if (num != 0)
					{
					}
					num = (short)49938432;
					if (num != 0)
					{
					}
					global::DevComponents.WpfRibbon.WinApi.KeyValidated = true;
					return;
				}
			}
			num = (short)1641283584;
			short num3 = num;
			global::DevComponents.WpfRibbon.WinApi.KeyValidated = false;
		}

		// Token: 0x040006C6 RID: 1734
		private static bool _IsWindows7;

		// Token: 0x040006C7 RID: 1735
		internal static bool KeyValidated;

		// Token: 0x020000A8 RID: 168
		public enum WindowLongValues
		{
			// Token: 0x040006C9 RID: 1737
			GWL_EXSTYLE = -20,
			// Token: 0x040006CA RID: 1738
			GWL_STYLE = -16
		}

		// Token: 0x020000A9 RID: 169
		public enum WindowStyles
		{
			// Token: 0x040006CC RID: 1740
			WS_THICKFRAME = 262144,
			// Token: 0x040006CD RID: 1741
			WS_EX_DLGMODALFRAME = 1
		}

		// Token: 0x020000AA RID: 170
		[global::System.Flags]
		public enum SetWindowPosParams
		{
			// Token: 0x040006CF RID: 1743
			SWP_FRAMECHANGED = 32,
			// Token: 0x040006D0 RID: 1744
			SWP_NOSIZE = 1,
			// Token: 0x040006D1 RID: 1745
			SWP_NOMOVE = 2,
			// Token: 0x040006D2 RID: 1746
			SWP_NOZORDER = 4
		}

		// Token: 0x020000AB RID: 171
		public enum WindowsMessages
		{
			// Token: 0x040006D4 RID: 1748
			WM_SYSCOMMAND = 274,
			// Token: 0x040006D5 RID: 1749
			WM_SIZE = 5,
			// Token: 0x040006D6 RID: 1750
			WM_NCHITTEST = 132,
			// Token: 0x040006D7 RID: 1751
			WM_NCLBUTTONDOWN = 161,
			// Token: 0x040006D8 RID: 1752
			WM_NCCALCSIZE = 131,
			// Token: 0x040006D9 RID: 1753
			WM_EXITSIZEMOVE = 562,
			// Token: 0x040006DA RID: 1754
			WM_ENTERSIZEMOVE = 561,
			// Token: 0x040006DB RID: 1755
			WM_SIZING = 532,
			// Token: 0x040006DC RID: 1756
			WM_GETMINMAXINFO = 36,
			// Token: 0x040006DD RID: 1757
			WM_DWMCOMPOSITIONCHANGED = 798,
			// Token: 0x040006DE RID: 1758
			WVR_VALIDRECTS = 1024,
			// Token: 0x040006DF RID: 1759
			WM_USER = 1024
		}

		// Token: 0x020000AC RID: 172
		public enum SysCommands
		{
			// Token: 0x040006E1 RID: 1761
			SC_CLOSE = 61536,
			// Token: 0x040006E2 RID: 1762
			SC_NEXTWINDOW = 61504,
			// Token: 0x040006E3 RID: 1763
			SC_PREVWINDOW = 61520,
			// Token: 0x040006E4 RID: 1764
			SC_KEYMENU = 61696,
			// Token: 0x040006E5 RID: 1765
			SC_RESTORE = 61728,
			// Token: 0x040006E6 RID: 1766
			SC_MINIMIZE = 61472,
			// Token: 0x040006E7 RID: 1767
			SC_MAXIMIZE = 61488,
			// Token: 0x040006E8 RID: 1768
			SC_MOVE = 61456,
			// Token: 0x040006E9 RID: 1769
			SC_SIZE = 61440
		}

		// Token: 0x020000AD RID: 173
		public enum SizingCommand
		{
			// Token: 0x040006EB RID: 1771
			None,
			// Token: 0x040006EC RID: 1772
			North = 3,
			// Token: 0x040006ED RID: 1773
			South = 6,
			// Token: 0x040006EE RID: 1774
			East = 2,
			// Token: 0x040006EF RID: 1775
			West = 1,
			// Token: 0x040006F0 RID: 1776
			NorthEast = 5,
			// Token: 0x040006F1 RID: 1777
			NorthWest = 4,
			// Token: 0x040006F2 RID: 1778
			SouthEast = 8,
			// Token: 0x040006F3 RID: 1779
			SouthWest = 7
		}

		// Token: 0x020000AE RID: 174
		public enum WmSizeType
		{
			// Token: 0x040006F5 RID: 1781
			SIZE_RESTORED,
			// Token: 0x040006F6 RID: 1782
			SIZE_MINIMIZED,
			// Token: 0x040006F7 RID: 1783
			SIZE_MAXIMIZED,
			// Token: 0x040006F8 RID: 1784
			SIZE_MAXSHOW,
			// Token: 0x040006F9 RID: 1785
			SIZE_MAXHIDE
		}

		// Token: 0x020000AF RID: 175
		public enum WindowHitTestRegions
		{
			// Token: 0x040006FB RID: 1787
			Error = -2,
			// Token: 0x040006FC RID: 1788
			TransparentOrCovered,
			// Token: 0x040006FD RID: 1789
			NoWhere,
			// Token: 0x040006FE RID: 1790
			ClientArea,
			// Token: 0x040006FF RID: 1791
			TitleBar,
			// Token: 0x04000700 RID: 1792
			SystemMenu,
			// Token: 0x04000701 RID: 1793
			GrowBox,
			// Token: 0x04000702 RID: 1794
			Menu,
			// Token: 0x04000703 RID: 1795
			HorizontalScrollBar,
			// Token: 0x04000704 RID: 1796
			VerticalScrollBar,
			// Token: 0x04000705 RID: 1797
			MinimizeButton,
			// Token: 0x04000706 RID: 1798
			MaximizeButton,
			// Token: 0x04000707 RID: 1799
			LeftSizeableBorder,
			// Token: 0x04000708 RID: 1800
			RightSizeableBorder,
			// Token: 0x04000709 RID: 1801
			TopSizeableBorder,
			// Token: 0x0400070A RID: 1802
			TopLeftSizeableCorner,
			// Token: 0x0400070B RID: 1803
			TopRightSizeableCorner,
			// Token: 0x0400070C RID: 1804
			BottomSizeableBorder,
			// Token: 0x0400070D RID: 1805
			BottomLeftSizeableCorner,
			// Token: 0x0400070E RID: 1806
			BottomRightSizeableCorner,
			// Token: 0x0400070F RID: 1807
			NonSizableBorder,
			// Token: 0x04000710 RID: 1808
			Object,
			// Token: 0x04000711 RID: 1809
			CloseButton,
			// Token: 0x04000712 RID: 1810
			HelpButton,
			// Token: 0x04000713 RID: 1811
			SizeBox = 4,
			// Token: 0x04000714 RID: 1812
			ReduceButton = 8,
			// Token: 0x04000715 RID: 1813
			ZoomButton
		}

		// Token: 0x020000B0 RID: 176
		public struct MARGINS
		{
			// Token: 0x04000716 RID: 1814
			public int cxLeftWidth;

			// Token: 0x04000717 RID: 1815
			public int cxRightWidth;

			// Token: 0x04000718 RID: 1816
			public int cyTopHeight;

			// Token: 0x04000719 RID: 1817
			public int cyBottomHeight;
		}

		// Token: 0x020000B1 RID: 177
		public struct WINDOWPOS
		{
			// Token: 0x0400071A RID: 1818
			public global::System.IntPtr hwnd;

			// Token: 0x0400071B RID: 1819
			public global::System.IntPtr hwndInsertAfter;

			// Token: 0x0400071C RID: 1820
			public int x;

			// Token: 0x0400071D RID: 1821
			public int y;

			// Token: 0x0400071E RID: 1822
			public int cx;

			// Token: 0x0400071F RID: 1823
			public int cy;

			// Token: 0x04000720 RID: 1824
			public int flags;
		}

		// Token: 0x020000B2 RID: 178
		public struct NCCALCSIZE_PARAMS
		{
			// Token: 0x04000721 RID: 1825
			public global::DevComponents.WpfRibbon.WinApi.RECT rgrc0;

			// Token: 0x04000722 RID: 1826
			public global::DevComponents.WpfRibbon.WinApi.RECT rgrc1;

			// Token: 0x04000723 RID: 1827
			public global::DevComponents.WpfRibbon.WinApi.RECT rgrc2;

			// Token: 0x04000724 RID: 1828
			public global::System.IntPtr lppos;
		}

		// Token: 0x020000B3 RID: 179
		[global::System.Serializable]
		public struct RECT
		{
			// Token: 0x0600085D RID: 2141 RVA: 0x000C0C28 File Offset: 0x000BEE28
			public RECT(int left_, int top_, int right_, int bottom_)
			{
				this.Left = left_;
				this.Top = top_;
				this.Right = right_;
				this.Bottom = bottom_;
			}

			// Token: 0x0600085E RID: 2142 RVA: 0x000C0C54 File Offset: 0x000BEE54
			public RECT(global::System.Windows.Rect r)
			{
				this.Left = (int)global::System.Math.Ceiling(r.Left);
				this.Top = (int)global::System.Math.Ceiling(r.Top);
				this.Right = (int)global::System.Math.Ceiling(r.Right);
				this.Bottom = (int)global::System.Math.Ceiling(r.Bottom);
			}

			// Token: 0x170001D6 RID: 470
			// (get) Token: 0x0600085F RID: 2143 RVA: 0x000C0CB0 File Offset: 0x000BEEB0
			public int Height
			{
				get
				{
					short num = (short)2092652002;
					short num2 = num;
					num = (short)1996641762;
					switch (num2 == num)
					{
					}
					num = (short)543162369;
					if (num != 0)
					{
					}
					num = (short)2096693248;
					short num3 = num;
					num = (short)1947074560;
					if (num != 0)
					{
					}
					return this.Bottom - this.Top;
				}
			}

			// Token: 0x170001D7 RID: 471
			// (get) Token: 0x06000860 RID: 2144 RVA: 0x000C0D64 File Offset: 0x000BEF64
			public int Width
			{
				get
				{
					short num = (short)498964778;
					short num2 = num;
					num = (short)692099370;
					switch (num2 == num)
					{
					}
					num = (short)471138304;
					if (num != 0)
					{
					}
					num = (short)1597440000;
					short num3 = num;
					num = (short)926154753;
					if (num != 0)
					{
					}
					return this.Right - this.Left;
				}
			}

			// Token: 0x170001D8 RID: 472
			// (get) Token: 0x06000861 RID: 2145 RVA: 0x000C0E1C File Offset: 0x000BF01C
			public global::System.Windows.Size Size
			{
				get
				{
					short num = (short)1990399636;
					short num2 = num;
					num = (short)59709076;
					switch (num2 == num)
					{
					}
					num = (short)831979521;
					if (num != 0)
					{
					}
					num = (short)1453522944;
					short num3 = num;
					num = (short)1951989760;
					if (num != 0)
					{
					}
					return new global::System.Windows.Size((double)this.Width, (double)this.Height);
				}
			}

			// Token: 0x170001D9 RID: 473
			// (get) Token: 0x06000862 RID: 2146 RVA: 0x000C0EDC File Offset: 0x000BF0DC
			public global::System.Windows.Point Location
			{
				get
				{
					short num = (short)1319391118;
					short num2 = num;
					num = (short)1289572238;
					switch (num2 == num)
					{
					}
					num = (short)347537408;
					if (num != 0)
					{
					}
					num = (short)341901312;
					short num3 = num;
					num = (short)566493185;
					if (num != 0)
					{
					}
					return new global::System.Windows.Point((double)this.Left, (double)this.Top);
				}
			}

			// Token: 0x06000863 RID: 2147 RVA: 0x000C0F98 File Offset: 0x000BF198
			public global::System.Windows.Rect ToRectangle()
			{
				short num = (short)1527955873;
				short num2 = num;
				num = (short)383500705;
				switch (num2 == num)
				{
				}
				num = (short)1878130689;
				if (num != 0)
				{
				}
				num = (short)1713766400;
				short num3 = num;
				num = (short)455606272;
				if (num != 0)
				{
				}
				return new global::System.Windows.Rect((double)this.Left, (double)this.Top, (double)(this.Right - this.Left), (double)(this.Bottom - this.Top));
			}

			// Token: 0x06000864 RID: 2148 RVA: 0x000C1074 File Offset: 0x000BF274
			public static global::DevComponents.WpfRibbon.WinApi.RECT FromRectangle(global::System.Windows.Rect r)
			{
				short num = (short)1570911638;
				short num2 = num;
				num = (short)58471830;
				switch (num2 == num)
				{
				}
				num = (short)66256897;
				if (num != 0)
				{
				}
				num = (short)1067057152;
				short num3 = num;
				num = (short)1965490176;
				if (num != 0)
				{
				}
				return new global::DevComponents.WpfRibbon.WinApi.RECT((int)global::System.Math.Ceiling(r.Left), (int)global::System.Math.Ceiling(r.Top), (int)global::System.Math.Ceiling(r.Right), (int)global::System.Math.Ceiling(r.Bottom));
			}

			// Token: 0x06000865 RID: 2149 RVA: 0x000C1154 File Offset: 0x000BF354
			public override int GetHashCode()
			{
				short num = (short)1722879993;
				short num2 = num;
				num = (short)818941945;
				switch (num2 == num)
				{
				}
				num = (short)799604737;
				if (num != 0)
				{
				}
				num = (short)1932787712;
				short num3 = num;
				num = (short)1882849280;
				if (num != 0)
				{
				}
				return this.Left ^ (this.Top << 13 | this.Top >> 19) ^ (this.Width << 26 | this.Width >> 6) ^ (this.Height << 7 | this.Height >> 25);
			}

			// Token: 0x06000866 RID: 2150 RVA: 0x000C123C File Offset: 0x000BF43C
			public static implicit operator global::System.Windows.Rect(global::DevComponents.WpfRibbon.WinApi.RECT rect)
			{
				short num = (short)501809153;
				if (num != 0)
				{
				}
				num = (short)476764667;
				short num2 = num;
				num = (short)173464059;
				switch (num2 == num)
				{
				}
				num = (short)1966080;
				short num3 = num;
				num = (short)963117056;
				if (num != 0)
				{
				}
				return new global::System.Windows.Rect((double)rect.Left, (double)rect.Top, (double)(rect.Right - rect.Left), (double)(rect.Bottom - rect.Top));
			}

			// Token: 0x06000867 RID: 2151 RVA: 0x000C1314 File Offset: 0x000BF514
			public static implicit operator global::DevComponents.WpfRibbon.WinApi.RECT(global::System.Windows.Rect rect)
			{
				short num = (short)874748278;
				short num2 = num;
				num = (short)1024301430;
				switch (num2 == num)
				{
				}
				num = (short)1247346688;
				if (num != 0)
				{
				}
				num = (short)147062784;
				short num3 = num;
				num = (short)1538850817;
				if (num != 0)
				{
				}
				return new global::System.Windows.Rect(rect.Left, rect.Top, rect.Right - rect.Left, rect.Bottom - rect.Top);
			}

			// Token: 0x06000868 RID: 2152 RVA: 0x000C13F4 File Offset: 0x000BF5F4
			public override string ToString()
			{
				int a_ = 9;
				short num = (short)1534673637;
				short num2 = num;
				num = (short)1769751269;
				switch (num2 == num)
				{
				}
				num = (short)1925775361;
				if (num != 0)
				{
				}
				num = (short)675545088;
				short num3 = num;
				num = (short)1379401728;
				if (num != 0)
				{
				}
				return string.Concat(new string[]
				{
					global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ⵠ٢ͤ፦周", a_),
					this.Left.ToString(),
					global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("䵠䍢ㅤࡦᥨ噪", a_),
					this.Top.ToString(),
					global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("䵠䍢㝤๦๨ͪᥬ剮", a_),
					this.Right.ToString(),
					global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("䵠䍢❤ࡦᵨὪɬɮ䱰", a_),
					this.Bottom.ToString()
				});
			}

			// Token: 0x04000725 RID: 1829
			public int Left;

			// Token: 0x04000726 RID: 1830
			public int Top;

			// Token: 0x04000727 RID: 1831
			public int Right;

			// Token: 0x04000728 RID: 1832
			public int Bottom;
		}

		// Token: 0x020000B4 RID: 180
		[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = global::System.Runtime.InteropServices.CharSet.Auto)]
		public class MONITORINFO
		{
			// Token: 0x04000729 RID: 1833
			public int cbSize = global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::DevComponents.WpfRibbon.WinApi.MONITORINFO));

			// Token: 0x0400072A RID: 1834
			public global::DevComponents.WpfRibbon.WinApi.RECT rcMonitor;

			// Token: 0x0400072B RID: 1835
			public global::DevComponents.WpfRibbon.WinApi.RECT rcWork;

			// Token: 0x0400072C RID: 1836
			public int dwFlags;
		}

		// Token: 0x020000B5 RID: 181
		public struct POINT
		{
			// Token: 0x0600086A RID: 2154 RVA: 0x000C1554 File Offset: 0x000BF754
			public POINT(int x, int y)
			{
				this.x = x;
				this.y = y;
			}

			// Token: 0x0400072D RID: 1837
			public int x;

			// Token: 0x0400072E RID: 1838
			public int y;
		}

		// Token: 0x020000B6 RID: 182
		public struct MINMAXINFO
		{
			// Token: 0x0400072F RID: 1839
			public global::DevComponents.WpfRibbon.WinApi.POINT ptReserved;

			// Token: 0x04000730 RID: 1840
			public global::DevComponents.WpfRibbon.WinApi.POINT ptMaxSize;

			// Token: 0x04000731 RID: 1841
			public global::DevComponents.WpfRibbon.WinApi.POINT ptMaxPosition;

			// Token: 0x04000732 RID: 1842
			public global::DevComponents.WpfRibbon.WinApi.POINT ptMinTrackSize;

			// Token: 0x04000733 RID: 1843
			public global::DevComponents.WpfRibbon.WinApi.POINT ptMaxTrackSize;
		}

		// Token: 0x020000B7 RID: 183
		public enum CombineRgnStyles
		{
			// Token: 0x04000735 RID: 1845
			RGN_AND = 1,
			// Token: 0x04000736 RID: 1846
			RGN_OR,
			// Token: 0x04000737 RID: 1847
			RGN_XOR,
			// Token: 0x04000738 RID: 1848
			RGN_DIFF,
			// Token: 0x04000739 RID: 1849
			RGN_COPY,
			// Token: 0x0400073A RID: 1850
			RGN_MIN = 1,
			// Token: 0x0400073B RID: 1851
			RGN_MAX = 5
		}

		// Token: 0x020000B8 RID: 184
		private enum WM_SIZE
		{
			// Token: 0x0400073D RID: 1853
			SIZE_MAXHIDE = 4,
			// Token: 0x0400073E RID: 1854
			SIZE_MAXIMIZED = 2,
			// Token: 0x0400073F RID: 1855
			SIZE_MAXSHOW,
			// Token: 0x04000740 RID: 1856
			SIZE_MINIMIZED = 1,
			// Token: 0x04000741 RID: 1857
			SIZE_RESTORED = 0
		}
	}
}
