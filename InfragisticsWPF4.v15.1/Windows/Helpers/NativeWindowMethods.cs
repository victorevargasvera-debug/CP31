using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Interop;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.Helpers
{
	// Token: 0x02000199 RID: 409
	[global::System.Runtime.InteropServices.ComVisible(false)]
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	internal static class NativeWindowMethods
	{
		// Token: 0x06000DAD RID: 3501 RVA: 0x0002CD86 File Offset: 0x0002AF86
		internal static bool AdjustWindowRectExApi(ref global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT lpRect, int dwStyle, bool bMenu, int dwExStyle)
		{
			return global::Infragistics.Windows.Helpers.NativeWindowMethods.AdjustWindowRectEx(ref lpRect, dwStyle, bMenu, dwExStyle);
		}

		// Token: 0x06000DAE RID: 3502
		[global::System.Runtime.InteropServices.DllImport("user32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, ExactSpelling = true)]
		private static extern bool AdjustWindowRectEx(ref global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT lpRect, int dwStyle, bool bMenu, int dwExStyle);

		// Token: 0x06000DAF RID: 3503
		[global::System.Runtime.InteropServices.DllImport("user32", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, ExactSpelling = true)]
		public static extern global::System.IntPtr CallNextHookEx(global::System.IntPtr hook, int nCode, global::System.IntPtr wParam, global::System.IntPtr lParam);

		// Token: 0x06000DB0 RID: 3504
		[global::System.Runtime.InteropServices.DllImport("gdi32")]
		private static extern int CombineRgn(global::System.IntPtr hrgnDest, global::System.IntPtr hrgnSrc1, global::System.IntPtr hrgnSrc2, global::Infragistics.Windows.Helpers.NativeWindowMethods.RegionCombineMode combineMode);

		// Token: 0x06000DB1 RID: 3505 RVA: 0x0002CD91 File Offset: 0x0002AF91
		internal static int CombineRgnApi(global::System.IntPtr hrgnDest, global::System.IntPtr hrgnSrc1, global::System.IntPtr hrgnSrc2, global::Infragistics.Windows.Helpers.NativeWindowMethods.RegionCombineMode combineMode)
		{
			return global::Infragistics.Windows.Helpers.NativeWindowMethods.CombineRgn(hrgnDest, hrgnSrc1, hrgnSrc2, combineMode);
		}

		// Token: 0x06000DB2 RID: 3506
		[global::System.Runtime.InteropServices.DllImport("gdi32")]
		private static extern global::System.IntPtr CreateRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect);

		// Token: 0x06000DB3 RID: 3507 RVA: 0x0002CD9C File Offset: 0x0002AF9C
		internal static global::System.IntPtr CreateRectRegionApi(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect)
		{
			return global::Infragistics.Windows.Helpers.NativeWindowMethods.CreateRectRgn(nLeftRect, nTopRect, nRightRect, nBottomRect);
		}

		// Token: 0x06000DB4 RID: 3508
		[global::System.Runtime.InteropServices.DllImport("gdi32.dll")]
		private static extern global::System.IntPtr CreateRoundRectRgn(int x1, int y1, int x2, int y2, int cx, int cy);

		// Token: 0x06000DB5 RID: 3509 RVA: 0x0002CDA7 File Offset: 0x0002AFA7
		internal static global::System.IntPtr CreateRoundRectRgnApi(int x1, int y1, int x2, int y2, int cx, int cy)
		{
			return global::Infragistics.Windows.Helpers.NativeWindowMethods.CreateRoundRectRgn(x1, y1, x2, y2, cx, cy);
		}

		// Token: 0x06000DB6 RID: 3510
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		internal static extern global::System.IntPtr DefWindowProc(global::System.IntPtr hWnd, int uMsg, global::System.IntPtr wParam, global::System.IntPtr lParam);

		// Token: 0x06000DB7 RID: 3511
		[global::System.Runtime.InteropServices.DllImport("gdi32", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, ExactSpelling = true)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Bool)]
		internal static extern bool DeleteObject(global::System.IntPtr hObject);

		// Token: 0x06000DB8 RID: 3512 RVA: 0x0002CDB8 File Offset: 0x0002AFB8
		internal static int DwmGetWindowAttributeApi(global::System.IntPtr hwnd, uint dwAttribute, ref global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT pvAttribute, uint cbAttribute)
		{
			if (global::System.Environment.OSVersion.Version.Major < 6)
			{
				return -1;
			}
			int result;
			try
			{
				result = global::Infragistics.Windows.Helpers.NativeWindowMethods.DwmGetWindowAttributeApiUnsafe(hwnd, dwAttribute, ref pvAttribute, cbAttribute);
			}
			catch
			{
				result = -1;
			}
			return result;
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x0002CDFC File Offset: 0x0002AFFC
		private static int DwmGetWindowAttributeApiUnsafe(global::System.IntPtr hwnd, uint dwAttribute, ref global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT pvAttribute, uint cbAttribute)
		{
			return global::Infragistics.Windows.Helpers.NativeWindowMethods.DwmGetWindowAttribute(hwnd, dwAttribute, ref pvAttribute, cbAttribute);
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x0002CE08 File Offset: 0x0002B008
		internal static int DwmExtendFrameIntoClientAreaApi(global::System.IntPtr hWnd, ref global::Infragistics.Windows.Helpers.NativeWindowMethods.MARGINS pMargins)
		{
			if (global::System.Environment.OSVersion.Version.Major < 6)
			{
				return -1;
			}
			int result;
			try
			{
				result = global::Infragistics.Windows.Helpers.NativeWindowMethods.DwmExtendFrameIntoClientAreaApiUnsafe(hWnd, ref pMargins);
			}
			catch
			{
				result = -1;
			}
			return result;
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x0002CE4C File Offset: 0x0002B04C
		private static int DwmExtendFrameIntoClientAreaApiUnsafe(global::System.IntPtr hWnd, ref global::Infragistics.Windows.Helpers.NativeWindowMethods.MARGINS pMargins)
		{
			return global::Infragistics.Windows.Helpers.NativeWindowMethods.DwmExtendFrameIntoClientArea(hWnd, ref pMargins);
		}

		// Token: 0x06000DBC RID: 3516
		[global::System.Runtime.InteropServices.DllImport("dwmapi.dll")]
		private static extern int DwmExtendFrameIntoClientArea(global::System.IntPtr hWnd, ref global::Infragistics.Windows.Helpers.NativeWindowMethods.MARGINS pMargins);

		// Token: 0x06000DBD RID: 3517
		[global::System.Runtime.InteropServices.DllImport("dwmapi.dll")]
		private static extern int DwmGetWindowAttribute(global::System.IntPtr hwnd, uint dwAttribute, ref global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT pvAttribute, uint cbAttribute);

		// Token: 0x06000DBE RID: 3518
		[global::System.Runtime.InteropServices.DllImport("dwmapi.dll")]
		internal static extern int DwmDefWindowProc([global::System.Runtime.InteropServices.In] global::System.IntPtr hWnd, uint msg, global::System.IntPtr wParam, global::System.IntPtr lParam, out int plResult);

		// Token: 0x06000DBF RID: 3519
		[global::System.Runtime.InteropServices.DllImport("dwmapi.dll")]
		private static extern int DwmIsCompositionEnabled(out bool enabled);

		// Token: 0x06000DC0 RID: 3520
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		internal static extern bool EnableMenuItem(global::System.IntPtr hMenu, int uIDEnableItem, int uEnable);

		// Token: 0x06000DC1 RID: 3521
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Bool)]
		internal static extern bool EnumChildWindows(global::System.IntPtr hwndParent, global::Infragistics.Windows.Helpers.NativeWindowMethods.EnumWindowsProc lpEnumFunc, global::System.IntPtr lParam);

		// Token: 0x06000DC2 RID: 3522
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Bool)]
		internal static extern bool EnumThreadWindows(int dwThreadId, global::Infragistics.Windows.Helpers.NativeWindowMethods.EnumWindowsProc lpfn, global::System.IntPtr lParam);

		// Token: 0x06000DC3 RID: 3523 RVA: 0x0002CE55 File Offset: 0x0002B055
		internal static global::System.IntPtr GetAncestorApi(global::System.IntPtr hwnd, int gaFlags)
		{
			return global::Infragistics.Windows.Helpers.NativeWindowMethods.GetAncestor(hwnd, gaFlags);
		}

		// Token: 0x06000DC4 RID: 3524
		[global::System.Runtime.InteropServices.DllImport("user32.dll", ExactSpelling = true)]
		internal static extern global::System.IntPtr GetAncestor(global::System.IntPtr hwnd, int gaFlags);

		// Token: 0x06000DC5 RID: 3525 RVA: 0x0002CE60 File Offset: 0x0002B060
		internal static global::System.IntPtr? GetCaptureApi()
		{
			global::System.IntPtr? result;
			try
			{
				result = new global::System.IntPtr?(global::Infragistics.Windows.Helpers.NativeWindowMethods.GetCapture());
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000DC6 RID: 3526
		[global::System.Runtime.InteropServices.DllImport("user32")]
		private static extern global::System.IntPtr GetCapture();

		// Token: 0x06000DC7 RID: 3527
		[global::System.Runtime.InteropServices.DllImport("user32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto)]
		private static extern int GetCaretBlinkTime();

		// Token: 0x06000DC8 RID: 3528 RVA: 0x0002CE98 File Offset: 0x0002B098
		internal static global::System.IntPtr GetClassLongPtr(global::System.IntPtr hWnd, int nIndex)
		{
			if (global::System.IntPtr.Size > 4)
			{
				return global::Infragistics.Windows.Helpers.NativeWindowMethods.GetClassLongPtr64(hWnd, nIndex);
			}
			return new global::System.IntPtr((long)((ulong)global::Infragistics.Windows.Helpers.NativeWindowMethods.GetClassLongPtr32(hWnd, nIndex)));
		}

		// Token: 0x06000DC9 RID: 3529
		[global::System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "GetClassLong")]
		private static extern uint GetClassLongPtr32(global::System.IntPtr hWnd, int nIndex);

		// Token: 0x06000DCA RID: 3530
		[global::System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "GetClassLongPtr")]
		private static extern global::System.IntPtr GetClassLongPtr64(global::System.IntPtr hWnd, int nIndex);

		// Token: 0x06000DCB RID: 3531
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Bool)]
		internal static extern bool GetClientRect(global::System.IntPtr hWnd, ref global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT rect);

		// Token: 0x06000DCC RID: 3532
		[global::System.Runtime.InteropServices.DllImport("user32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, SetLastError = true)]
		internal static extern int GetClipboardFormatName(int format, global::System.Text.StringBuilder lpString, int cchMax);

		// Token: 0x06000DCD RID: 3533 RVA: 0x0002CEB8 File Offset: 0x0002B0B8
		internal static int GetCurrentThreadIdApi()
		{
			try
			{
				return global::Infragistics.Windows.Helpers.NativeWindowMethods.GetCurrentThreadIdApiUnsafe();
			}
			catch (global::System.Security.SecurityException)
			{
			}
			return global::System.AppDomain.GetCurrentThreadId();
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x0002CEE8 File Offset: 0x0002B0E8
		private static int GetCurrentThreadIdApiUnsafe()
		{
			return global::Infragistics.Windows.Helpers.NativeWindowMethods.GetCurrentThreadId();
		}

		// Token: 0x06000DCF RID: 3535
		[global::System.Runtime.InteropServices.DllImport("kernel32")]
		private static extern int GetCurrentThreadId();

		// Token: 0x06000DD0 RID: 3536
		[global::System.Runtime.InteropServices.DllImport("user32")]
		internal static extern int GetCursorPos(ref global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT lpPoint);

		// Token: 0x06000DD1 RID: 3537
		[global::System.Runtime.InteropServices.DllImport("user32", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, ExactSpelling = true)]
		internal static extern global::System.IntPtr GetDC(global::System.IntPtr hwnd);

		// Token: 0x06000DD2 RID: 3538
		[global::System.Runtime.InteropServices.DllImport("user32", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, ExactSpelling = true)]
		internal static extern global::System.IntPtr GetDCEx(global::System.IntPtr hwnd, global::System.IntPtr hrgnclip, uint fdwOptions);

		// Token: 0x06000DD3 RID: 3539
		[global::System.Runtime.InteropServices.DllImport("user32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto)]
		private static extern int GetDoubleClickTime();

		// Token: 0x06000DD4 RID: 3540
		[global::System.Runtime.InteropServices.DllImport("user32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, ExactSpelling = true)]
		public static extern global::System.IntPtr GetFocus();

		// Token: 0x06000DD5 RID: 3541
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		internal static extern int GetMenuState(global::System.IntPtr hMenu, int uID, int uFlags);

		// Token: 0x06000DD6 RID: 3542
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		internal static extern global::System.IntPtr GetMessageExtraInfo();

		// Token: 0x06000DD7 RID: 3543
		[global::System.Runtime.InteropServices.DllImport("user32")]
		internal static extern int GetMessagePos();

		// Token: 0x06000DD8 RID: 3544
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		internal static extern int GetMessageTime();

		// Token: 0x06000DD9 RID: 3545
		[global::System.Runtime.InteropServices.DllImport("user32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto)]
		private static extern bool GetMonitorInfo(global::System.Runtime.InteropServices.HandleRef handle, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] global::Infragistics.Windows.Helpers.NativeWindowMethods.MONITIORINFOEX monitorInfo);

		// Token: 0x06000DDA RID: 3546
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		internal static extern bool GetMonitorInfo(global::System.IntPtr hMonitor, out global::Infragistics.Windows.Helpers.NativeWindowMethods.MONITORINFO lpmi);

		// Token: 0x06000DDB RID: 3547
		[global::System.Runtime.InteropServices.DllImport("user32.dll", ExactSpelling = true)]
		internal static extern global::System.IntPtr GetParent(global::System.IntPtr hwnd);

		// Token: 0x06000DDC RID: 3548 RVA: 0x0002CEEF File Offset: 0x0002B0EF
		internal static global::System.IntPtr GetSystemMenuApi(global::System.IntPtr hWnd, bool revert)
		{
			return global::Infragistics.Windows.Helpers.NativeWindowMethods.GetSystemMenu(hWnd, revert);
		}

		// Token: 0x06000DDD RID: 3549
		[global::System.Runtime.InteropServices.DllImport("user32", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, ExactSpelling = true)]
		private static extern global::System.IntPtr GetSystemMenu(global::System.IntPtr hWnd, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Bool)] bool revert);

		// Token: 0x06000DDE RID: 3550
		[global::System.Runtime.InteropServices.DllImport("user32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, ExactSpelling = true)]
		private static extern int GetSystemMetrics(int index);

		// Token: 0x06000DDF RID: 3551
		[global::System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
		internal static extern global::System.IntPtr GetWindow(global::System.IntPtr hWnd, uint uCmd);

		// Token: 0x06000DE0 RID: 3552
		[global::System.Runtime.InteropServices.DllImport("user32")]
		internal static extern global::System.IntPtr GetWindowDC(global::System.IntPtr hwnd);

		// Token: 0x06000DE1 RID: 3553
		[global::System.Runtime.InteropServices.DllImport("user32")]
		internal static extern bool GetWindowInfo(global::System.IntPtr hwnd, ref global::Infragistics.Windows.Helpers.NativeWindowMethods.WINDOWINFO pwi);

		// Token: 0x06000DE2 RID: 3554
		[global::System.Runtime.InteropServices.DllImport("user32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, EntryPoint = "GetWindowLong")]
		public static extern global::System.IntPtr GetWindowLong32(global::System.IntPtr hWnd, int nIndex);

		// Token: 0x06000DE3 RID: 3555
		[global::System.Runtime.InteropServices.DllImport("user32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, EntryPoint = "GetWindowLongPtr")]
		public static extern global::System.IntPtr GetWindowLongPtr64(global::System.IntPtr hWnd, int nIndex);

		// Token: 0x06000DE4 RID: 3556 RVA: 0x0002CEF8 File Offset: 0x0002B0F8
		internal static global::System.IntPtr GetWindowLong(global::System.IntPtr hwnd, int nIndex)
		{
			if (global::System.IntPtr.Size == 4)
			{
				return global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowLong32(hwnd, nIndex);
			}
			return global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowLongPtr64(hwnd, nIndex);
		}

		// Token: 0x06000DE5 RID: 3557
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Bool)]
		internal static extern bool GetWindowPlacement(global::System.IntPtr hWnd, ref global::Infragistics.Windows.Helpers.NativeWindowMethods.WINDOWPLACEMENT lpwndpl);

		// Token: 0x06000DE6 RID: 3558
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Bool)]
		internal static extern bool GetWindowRect(global::System.IntPtr hwnd, ref global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT lpRect);

		// Token: 0x06000DE7 RID: 3559
		[global::System.Runtime.InteropServices.DllImport("uxtheme.dll", SetLastError = true)]
		internal static extern int IsAppThemed();

		// Token: 0x06000DE8 RID: 3560
		[global::System.Runtime.InteropServices.DllImport("uxtheme.dll", SetLastError = true)]
		internal static extern int IsThemeActive();

		// Token: 0x06000DE9 RID: 3561 RVA: 0x0002CF11 File Offset: 0x0002B111
		internal static global::System.IntPtr LoadImageApi(global::System.IntPtr hinst, int lpszName, uint uType, int cxDesired, int cyDesired, uint fuLoad)
		{
			return global::Infragistics.Windows.Helpers.NativeWindowMethods.LoadImage(hinst, lpszName, uType, cxDesired, cyDesired, fuLoad);
		}

		// Token: 0x06000DEA RID: 3562
		[global::System.Runtime.InteropServices.DllImport("user32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, SetLastError = true)]
		private static extern global::System.IntPtr LoadImage(global::System.IntPtr hinst, int lpszName, uint uType, int cxDesired, int cyDesired, uint fuLoad);

		// Token: 0x06000DEB RID: 3563
		[global::System.Runtime.InteropServices.DllImport("user32")]
		internal static extern int MapWindowPoints(global::System.IntPtr hwndSrc, global::System.IntPtr hwndDest, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT pt, int ptCount);

		// Token: 0x06000DEC RID: 3564
		[global::System.Runtime.InteropServices.DllImport("user32.dll", ExactSpelling = true)]
		internal static extern global::System.IntPtr MonitorFromPoint(global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT pt, int flags);

		// Token: 0x06000DED RID: 3565
		[global::System.Runtime.InteropServices.DllImport("user32.dll", ExactSpelling = true)]
		internal static extern global::System.IntPtr MonitorFromRect([global::System.Runtime.InteropServices.In] ref global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT rect, int flags);

		// Token: 0x06000DEE RID: 3566
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		internal static extern global::System.IntPtr MonitorFromWindow(global::System.IntPtr hwnd, uint dwFlags);

		// Token: 0x06000DEF RID: 3567
		[global::System.Runtime.InteropServices.DllImport("user32", CharSet = global::System.Runtime.InteropServices.CharSet.Auto)]
		internal static extern int PostMessage(global::System.IntPtr hWnd, int msg, global::System.IntPtr wparam, global::System.IntPtr lparam);

		// Token: 0x06000DF0 RID: 3568 RVA: 0x0002CF20 File Offset: 0x0002B120
		internal static int ReleaseDCApi(global::System.IntPtr hwnd, global::System.IntPtr hdc)
		{
			return global::Infragistics.Windows.Helpers.NativeWindowMethods.ReleaseDC(hwnd, hdc);
		}

		// Token: 0x06000DF1 RID: 3569
		[global::System.Runtime.InteropServices.DllImport("user32", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, ExactSpelling = true)]
		internal static extern int ReleaseDC(global::System.IntPtr hwnd, global::System.IntPtr hdc);

		// Token: 0x06000DF2 RID: 3570 RVA: 0x0002CF29 File Offset: 0x0002B129
		internal static global::System.IntPtr SendMessageApi(global::System.IntPtr hWnd, int msg, global::System.IntPtr wparam, global::System.IntPtr lparam)
		{
			return global::Infragistics.Windows.Helpers.NativeWindowMethods.SendMessage(hWnd, msg, wparam, lparam);
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x0002CF34 File Offset: 0x0002B134
		internal static global::System.IntPtr SendMessageApi(global::System.IntPtr hWnd, int msg, global::System.IntPtr wparam, ref global::Infragistics.Windows.Helpers.NativeWindowMethods.TITLEBARINFOEX lparam)
		{
			return global::Infragistics.Windows.Helpers.NativeWindowMethods.SendMessage(hWnd, msg, wparam, ref lparam);
		}

		// Token: 0x06000DF4 RID: 3572
		[global::System.Runtime.InteropServices.DllImport("user32", CharSet = global::System.Runtime.InteropServices.CharSet.Auto)]
		private static extern global::System.IntPtr SendMessage(global::System.IntPtr hWnd, int msg, global::System.IntPtr wparam, global::System.IntPtr lparam);

		// Token: 0x06000DF5 RID: 3573
		[global::System.Runtime.InteropServices.DllImport("user32", CharSet = global::System.Runtime.InteropServices.CharSet.Auto)]
		private static extern global::System.IntPtr SendMessage(global::System.IntPtr hWnd, int msg, global::System.IntPtr wparam, ref global::Infragistics.Windows.Helpers.NativeWindowMethods.TITLEBARINFOEX lparam);

		// Token: 0x06000DF6 RID: 3574
		[global::System.Runtime.InteropServices.DllImport("user32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, EntryPoint = "SetWindowLong")]
		private static extern global::System.IntPtr SetWindowLong32(global::System.IntPtr hWnd, int nIndex, global::System.IntPtr dwNewLong);

		// Token: 0x06000DF7 RID: 3575
		[global::System.Runtime.InteropServices.DllImport("user32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, EntryPoint = "SetWindowLongPtr")]
		private static extern global::System.IntPtr SetWindowLongPtr64(global::System.IntPtr hWnd, int nIndex, global::System.IntPtr dwNewLong);

		// Token: 0x06000DF8 RID: 3576 RVA: 0x0002CF3F File Offset: 0x0002B13F
		internal static global::System.IntPtr SetWindowLong(global::System.IntPtr hwnd, int nIndex, global::System.IntPtr dwNewLong)
		{
			if (global::System.IntPtr.Size == 4)
			{
				return global::Infragistics.Windows.Helpers.NativeWindowMethods.SetWindowLong32(hwnd, nIndex, dwNewLong);
			}
			return global::Infragistics.Windows.Helpers.NativeWindowMethods.SetWindowLongPtr64(hwnd, nIndex, dwNewLong);
		}

		// Token: 0x06000DF9 RID: 3577
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Bool)]
		internal static extern bool SetWindowPlacement(global::System.IntPtr hWnd, ref global::Infragistics.Windows.Helpers.NativeWindowMethods.WINDOWPLACEMENT lpwndpl);

		// Token: 0x06000DFA RID: 3578
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern int SetWindowRgn(global::System.IntPtr hWnd, global::System.IntPtr hRgn, bool bRedraw);

		// Token: 0x06000DFB RID: 3579 RVA: 0x0002CF5A File Offset: 0x0002B15A
		internal static int SetWindowRgnApi(global::System.IntPtr hWnd, global::System.IntPtr hRgn, bool bRedraw)
		{
			return global::Infragistics.Windows.Helpers.NativeWindowMethods.SetWindowRgn(hWnd, hRgn, bRedraw);
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x0002CF64 File Offset: 0x0002B164
		internal static bool SetWindowPosApi(global::System.IntPtr hWnd, global::System.IntPtr hWndInsertAfter, int x, int y, int cx, int cy, int flags)
		{
			return global::Infragistics.Windows.Helpers.NativeWindowMethods.SetWindowPos(hWnd, hWndInsertAfter, x, y, cx, cy, flags);
		}

		// Token: 0x06000DFD RID: 3581
		[global::System.Runtime.InteropServices.DllImport("user32", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, ExactSpelling = true)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Bool)]
		private static extern bool SetWindowPos(global::System.IntPtr hWnd, global::System.IntPtr hWndInsertAfter, int x, int y, int cx, int cy, int flags);

		// Token: 0x06000DFE RID: 3582
		[global::System.Runtime.InteropServices.DllImport("user32", CharSet = global::System.Runtime.InteropServices.CharSet.Auto)]
		public static extern global::System.IntPtr SetWindowsHookEx(int id, global::Infragistics.Windows.Helpers.NativeWindowMethods.HookProc hookProc, global::System.IntPtr hmod, int dwThreadId);

		// Token: 0x06000DFF RID: 3583
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Bool)]
		internal static extern bool ShowWindow(global::System.IntPtr hwnd, int nCmdShow);

		// Token: 0x06000E00 RID: 3584
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		internal static extern int TrackPopupMenuEx(global::System.IntPtr hmenu, uint fuFlags, int x, int y, global::System.IntPtr hwnd, global::System.IntPtr lptpm);

		// Token: 0x06000E01 RID: 3585
		[global::System.Runtime.InteropServices.DllImport("user32", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, ExactSpelling = true)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Bool)]
		public static extern bool UnhookWindowsHookEx(global::System.IntPtr hook);

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000E02 RID: 3586 RVA: 0x0002CF78 File Offset: 0x0002B178
		internal static int CaretBlinkTime
		{
			get
			{
				if (!global::Infragistics.Windows.Helpers.NativeWindowMethods._unsafeCaretBlinkTimeDoesntWork)
				{
					try
					{
						return global::Infragistics.Windows.Helpers.NativeWindowMethods.UnsafeCaretBlinkTime();
					}
					catch
					{
						global::Infragistics.Windows.Helpers.NativeWindowMethods._unsafeCaretBlinkTimeDoesntWork = true;
					}
				}
				if (!global::Infragistics.Windows.Helpers.NativeWindowMethods._systemInformationCaretBlinkTimeDoesntWork)
				{
					try
					{
						return global::Infragistics.Windows.Helpers.NativeWindowMethods.GetSystemInformationCaretBlinkTime();
					}
					catch
					{
						global::Infragistics.Windows.Helpers.NativeWindowMethods._systemInformationCaretBlinkTimeDoesntWork = true;
					}
				}
				return 500;
			}
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x0002CFD8 File Offset: 0x0002B1D8
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private static int GetSystemInformationCaretBlinkTime()
		{
			return global::System.Windows.Forms.SystemInformation.CaretBlinkTime;
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x0002CFE0 File Offset: 0x0002B1E0
		private static int UnsafeCaretBlinkTime()
		{
			return global::Infragistics.Windows.Helpers.NativeWindowMethods.GetCaretBlinkTime();
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000E05 RID: 3589 RVA: 0x0002CFF4 File Offset: 0x0002B1F4
		internal static int DoubleClickTime
		{
			get
			{
				if (!global::Infragistics.Windows.Helpers.NativeWindowMethods._unsafeDoubleClickTimeDoesntWork)
				{
					try
					{
						return global::Infragistics.Windows.Helpers.NativeWindowMethods.UnsafeDoubleClickTime();
					}
					catch
					{
						global::Infragistics.Windows.Helpers.NativeWindowMethods._unsafeDoubleClickTimeDoesntWork = true;
					}
				}
				if (!global::Infragistics.Windows.Helpers.NativeWindowMethods._systemInformationDoubleClickTimeDoesntWork)
				{
					try
					{
						return global::Infragistics.Windows.Helpers.NativeWindowMethods.GetSystemInformationDoubleClickTime();
					}
					catch
					{
						global::Infragistics.Windows.Helpers.NativeWindowMethods._systemInformationDoubleClickTimeDoesntWork = true;
					}
				}
				return 500;
			}
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x0002D054 File Offset: 0x0002B254
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private static int GetSystemInformationDoubleClickTime()
		{
			return global::System.Windows.Forms.SystemInformation.DoubleClickTime;
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x0002D05B File Offset: 0x0002B25B
		private static int UnsafeDoubleClickTime()
		{
			return global::Infragistics.Windows.Helpers.NativeWindowMethods.GetDoubleClickTime();
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000E08 RID: 3592 RVA: 0x0002D064 File Offset: 0x0002B264
		internal static global::System.Windows.Size DoubleClickSize
		{
			get
			{
				if (!global::Infragistics.Windows.Helpers.NativeWindowMethods._unsafeDoubleClickSizeDoesntWork)
				{
					try
					{
						return global::Infragistics.Windows.Helpers.NativeWindowMethods.UnsafeDoubleClickSize();
					}
					catch
					{
						global::Infragistics.Windows.Helpers.NativeWindowMethods._unsafeDoubleClickSizeDoesntWork = true;
					}
				}
				if (!global::Infragistics.Windows.Helpers.NativeWindowMethods._systemInformationDoubleClickSizeDoesntWork)
				{
					try
					{
						return global::Infragistics.Windows.Helpers.NativeWindowMethods.GetSystemInformationDoubleClickSize();
					}
					catch
					{
						global::Infragistics.Windows.Helpers.NativeWindowMethods._systemInformationDoubleClickSizeDoesntWork = true;
					}
				}
				return new global::System.Windows.Size(4.0, 4.0);
			}
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x0002D0D8 File Offset: 0x0002B2D8
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private static global::System.Windows.Size GetSystemInformationDoubleClickSize()
		{
			global::System.Drawing.Size doubleClickSize = global::System.Windows.Forms.SystemInformation.DoubleClickSize;
			return new global::System.Windows.Size(global::Infragistics.Windows.Helpers.NativeWindowMethods.ConvertToLogicalPixels(doubleClickSize.Width), global::Infragistics.Windows.Helpers.NativeWindowMethods.ConvertToLogicalPixels(doubleClickSize.Height));
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x0002D108 File Offset: 0x0002B308
		private static global::System.Windows.Size UnsafeDoubleClickSize()
		{
			return new global::System.Windows.Size((double)global::Infragistics.Windows.Helpers.NativeWindowMethods.GetSystemMetrics(36), (double)global::Infragistics.Windows.Helpers.NativeWindowMethods.GetSystemMetrics(37));
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000E0B RID: 3595 RVA: 0x0002D120 File Offset: 0x0002B320
		internal static global::System.Windows.Size DragSize
		{
			get
			{
				if (!global::Infragistics.Windows.Helpers.NativeWindowMethods._unsafeDragSizeDoesntWork)
				{
					try
					{
						return global::Infragistics.Windows.Helpers.NativeWindowMethods.UnsafeDragSize();
					}
					catch
					{
						global::Infragistics.Windows.Helpers.NativeWindowMethods._unsafeDragSizeDoesntWork = true;
					}
				}
				if (!global::Infragistics.Windows.Helpers.NativeWindowMethods._systemInformationDragSizeDoesntWork)
				{
					try
					{
						return global::Infragistics.Windows.Helpers.NativeWindowMethods.GetSystemInformationDragSize();
					}
					catch
					{
						global::Infragistics.Windows.Helpers.NativeWindowMethods._systemInformationDragSizeDoesntWork = true;
					}
				}
				return new global::System.Windows.Size(4.0, 4.0);
			}
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x0002D194 File Offset: 0x0002B394
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private static global::System.Windows.Size GetSystemInformationDragSize()
		{
			global::System.Drawing.Size dragSize = global::System.Windows.Forms.SystemInformation.DragSize;
			return new global::System.Windows.Size(global::Infragistics.Windows.Helpers.NativeWindowMethods.ConvertToLogicalPixels(dragSize.Width), global::Infragistics.Windows.Helpers.NativeWindowMethods.ConvertToLogicalPixels(dragSize.Height));
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x0002D1C4 File Offset: 0x0002B3C4
		private static global::System.Windows.Size UnsafeDragSize()
		{
			return new global::System.Windows.Size((double)global::Infragistics.Windows.Helpers.NativeWindowMethods.GetSystemMetrics(68), (double)global::Infragistics.Windows.Helpers.NativeWindowMethods.GetSystemMetrics(69));
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x0002D1DB File Offset: 0x0002B3DB
		private static int ConvertToDevicePixels(double logicalValue)
		{
			return global::Infragistics.Windows.Utilities.ConvertFromLogicalPixels(logicalValue);
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x0002D1E3 File Offset: 0x0002B3E3
		private static double ConvertToLogicalPixels(int pixelValue)
		{
			return global::Infragistics.Windows.Utilities.ConvertToLogicalPixels(pixelValue);
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000E10 RID: 3600 RVA: 0x0002D1EB File Offset: 0x0002B3EB
		internal static bool IsClassicTheme
		{
			get
			{
				return global::Infragistics.Windows.Helpers.NativeWindowMethods.AreThemesSupported && !global::Infragistics.Windows.Helpers.NativeWindowMethods.IsThemeActiveInternal();
			}
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x0002D1FE File Offset: 0x0002B3FE
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private static bool IsThemeActiveInternal()
		{
			return global::Infragistics.Windows.Helpers.NativeWindowMethods.IsThemeActive() != 0 && global::Infragistics.Windows.Helpers.NativeWindowMethods.IsAppThemed() != 0;
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000E12 RID: 3602 RVA: 0x0002D214 File Offset: 0x0002B414
		internal static bool IsWindows8orAbove
		{
			get
			{
				global::System.Version version = global::System.Environment.OSVersion.Version;
				return version.Major > 6 || (version.Major >= 6 && version.Minor >= 2);
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000E13 RID: 3603 RVA: 0x0002D250 File Offset: 0x0002B450
		internal static global::System.Windows.Size PrimaryMonitorSize
		{
			get
			{
				if (!global::Infragistics.Windows.Helpers.NativeWindowMethods._securityException)
				{
					try
					{
						return global::Infragistics.Windows.Helpers.NativeWindowMethods.PrimaryMonitorSizeUnsafe;
					}
					catch (global::System.Security.SecurityException)
					{
						global::Infragistics.Windows.Helpers.NativeWindowMethods._securityException = true;
					}
				}
				return global::Infragistics.Windows.Helpers.NativeWindowMethods.PrimaryMonitorSizeFallback;
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000E14 RID: 3604 RVA: 0x0002D28C File Offset: 0x0002B48C
		private static global::System.Windows.Size PrimaryMonitorSizeUnsafe
		{
			[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				return new global::System.Windows.Size((double)global::Infragistics.Windows.Helpers.NativeWindowMethods.GetSystemMetrics(0), (double)global::Infragistics.Windows.Helpers.NativeWindowMethods.GetSystemMetrics(1));
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000E15 RID: 3605 RVA: 0x0002D2A4 File Offset: 0x0002B4A4
		private static global::System.Windows.Size PrimaryMonitorSizeFallback
		{
			[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				global::System.Drawing.Size primaryMonitorSize = global::System.Windows.Forms.SystemInformation.PrimaryMonitorSize;
				return new global::System.Windows.Size((double)primaryMonitorSize.Width, (double)primaryMonitorSize.Height);
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000E16 RID: 3606 RVA: 0x0002D2CC File Offset: 0x0002B4CC
		internal static global::System.Windows.Rect VirtualScreenArea
		{
			get
			{
				if (global::Infragistics.Windows.Helpers.NativeWindowMethods.hasSecurityExceptionBeenThrown)
				{
					return global::Infragistics.Windows.Helpers.NativeWindowMethods.VirtualScreenAreaFallback;
				}
				global::System.Windows.Rect result;
				try
				{
					result = new global::System.Windows.Rect(global::System.Windows.SystemParameters.VirtualScreenLeft, global::System.Windows.SystemParameters.VirtualScreenTop, global::System.Windows.SystemParameters.VirtualScreenWidth, global::System.Windows.SystemParameters.VirtualScreenHeight);
				}
				catch (global::System.Security.SecurityException)
				{
					global::Infragistics.Windows.Helpers.NativeWindowMethods.hasSecurityExceptionBeenThrown = true;
					result = global::Infragistics.Windows.Helpers.NativeWindowMethods.VirtualScreenAreaFallback;
				}
				return result;
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000E17 RID: 3607 RVA: 0x0002D324 File Offset: 0x0002B524
		private static global::System.Windows.Rect VirtualScreenAreaFallback
		{
			[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				global::System.Drawing.Rectangle virtualScreen = global::System.Windows.Forms.SystemInformation.VirtualScreen;
				return new global::System.Windows.Rect
				{
					X = global::Infragistics.Windows.Helpers.NativeWindowMethods.ConvertToLogicalPixels(virtualScreen.X),
					Y = global::Infragistics.Windows.Helpers.NativeWindowMethods.ConvertToLogicalPixels(virtualScreen.Y),
					Width = global::Infragistics.Windows.Helpers.NativeWindowMethods.ConvertToLogicalPixels(virtualScreen.Width),
					Height = global::Infragistics.Windows.Helpers.NativeWindowMethods.ConvertToLogicalPixels(virtualScreen.Height)
				};
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000E18 RID: 3608 RVA: 0x0002D38C File Offset: 0x0002B58C
		internal static double VirtualScreenLeft
		{
			get
			{
				if (global::Infragistics.Windows.Helpers.NativeWindowMethods.hasSecurityExceptionBeenThrown)
				{
					return global::Infragistics.Windows.Helpers.NativeWindowMethods.VirtualScreenLeftFallback;
				}
				double result;
				try
				{
					result = global::System.Windows.SystemParameters.VirtualScreenLeft;
				}
				catch (global::System.Security.SecurityException)
				{
					global::Infragistics.Windows.Helpers.NativeWindowMethods.hasSecurityExceptionBeenThrown = true;
					result = global::Infragistics.Windows.Helpers.NativeWindowMethods.VirtualScreenLeftFallback;
				}
				return result;
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000E19 RID: 3609 RVA: 0x0002D3D0 File Offset: 0x0002B5D0
		private static double VirtualScreenLeftFallback
		{
			[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				return global::Infragistics.Windows.Helpers.NativeWindowMethods.ConvertToLogicalPixels(global::System.Windows.Forms.SystemInformation.VirtualScreen.Left);
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000E1A RID: 3610 RVA: 0x0002D3F0 File Offset: 0x0002B5F0
		internal static double VirtualScreenHeight
		{
			get
			{
				if (global::Infragistics.Windows.Helpers.NativeWindowMethods.hasSecurityExceptionBeenThrown)
				{
					return global::Infragistics.Windows.Helpers.NativeWindowMethods.VirtualScreenHeightFallback;
				}
				double result;
				try
				{
					result = global::System.Windows.SystemParameters.VirtualScreenHeight;
				}
				catch (global::System.Security.SecurityException)
				{
					global::Infragistics.Windows.Helpers.NativeWindowMethods.hasSecurityExceptionBeenThrown = true;
					result = global::Infragistics.Windows.Helpers.NativeWindowMethods.VirtualScreenHeightFallback;
				}
				return result;
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000E1B RID: 3611 RVA: 0x0002D434 File Offset: 0x0002B634
		private static double VirtualScreenHeightFallback
		{
			[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				return global::Infragistics.Windows.Helpers.NativeWindowMethods.ConvertToLogicalPixels(global::System.Windows.Forms.SystemInformation.VirtualScreen.Height);
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000E1C RID: 3612 RVA: 0x0002D454 File Offset: 0x0002B654
		internal static double VirtualScreenTop
		{
			get
			{
				if (global::Infragistics.Windows.Helpers.NativeWindowMethods.hasSecurityExceptionBeenThrown)
				{
					return global::Infragistics.Windows.Helpers.NativeWindowMethods.VirtualScreenTopFallback;
				}
				double result;
				try
				{
					result = global::System.Windows.SystemParameters.VirtualScreenTop;
				}
				catch (global::System.Security.SecurityException)
				{
					global::Infragistics.Windows.Helpers.NativeWindowMethods.hasSecurityExceptionBeenThrown = true;
					result = global::Infragistics.Windows.Helpers.NativeWindowMethods.VirtualScreenTopFallback;
				}
				return result;
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000E1D RID: 3613 RVA: 0x0002D498 File Offset: 0x0002B698
		private static double VirtualScreenTopFallback
		{
			[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				return global::Infragistics.Windows.Helpers.NativeWindowMethods.ConvertToLogicalPixels(global::System.Windows.Forms.SystemInformation.VirtualScreen.Top);
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000E1E RID: 3614 RVA: 0x0002D4B8 File Offset: 0x0002B6B8
		internal static double VirtualScreenWidth
		{
			get
			{
				if (global::Infragistics.Windows.Helpers.NativeWindowMethods.hasSecurityExceptionBeenThrown)
				{
					return global::Infragistics.Windows.Helpers.NativeWindowMethods.VirtualScreenWidthFallback;
				}
				double result;
				try
				{
					result = global::System.Windows.SystemParameters.VirtualScreenWidth;
				}
				catch (global::System.Security.SecurityException)
				{
					global::Infragistics.Windows.Helpers.NativeWindowMethods.hasSecurityExceptionBeenThrown = true;
					result = global::Infragistics.Windows.Helpers.NativeWindowMethods.VirtualScreenWidthFallback;
				}
				return result;
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000E1F RID: 3615 RVA: 0x0002D4FC File Offset: 0x0002B6FC
		private static double VirtualScreenWidthFallback
		{
			[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				return global::Infragistics.Windows.Helpers.NativeWindowMethods.ConvertToLogicalPixels(global::System.Windows.Forms.SystemInformation.VirtualScreen.Width);
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000E20 RID: 3616 RVA: 0x0002D51C File Offset: 0x0002B71C
		internal static global::System.Windows.Rect WorkArea
		{
			get
			{
				if (global::Infragistics.Windows.Helpers.NativeWindowMethods.hasSecurityExceptionBeenThrown)
				{
					return global::Infragistics.Windows.Helpers.NativeWindowMethods.WorkAreaFallback;
				}
				global::System.Windows.Rect result;
				try
				{
					result = global::System.Windows.SystemParameters.WorkArea;
				}
				catch (global::System.Security.SecurityException)
				{
					global::Infragistics.Windows.Helpers.NativeWindowMethods.hasSecurityExceptionBeenThrown = true;
					result = global::Infragistics.Windows.Helpers.NativeWindowMethods.WorkAreaFallback;
				}
				return result;
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000E21 RID: 3617 RVA: 0x0002D560 File Offset: 0x0002B760
		private static global::System.Windows.Rect WorkAreaFallback
		{
			[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				global::System.Drawing.Rectangle workingArea = global::System.Windows.Forms.SystemInformation.WorkingArea;
				return new global::System.Windows.Rect
				{
					X = global::Infragistics.Windows.Helpers.NativeWindowMethods.ConvertToLogicalPixels(workingArea.X),
					Y = global::Infragistics.Windows.Helpers.NativeWindowMethods.ConvertToLogicalPixels(workingArea.Y),
					Width = global::Infragistics.Windows.Helpers.NativeWindowMethods.ConvertToLogicalPixels(workingArea.Width),
					Height = global::Infragistics.Windows.Helpers.NativeWindowMethods.ConvertToLogicalPixels(workingArea.Height)
				};
			}
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x0002D5C8 File Offset: 0x0002B7C8
		internal static global::System.IntPtr AddBits(global::System.IntPtr ptr, int bitsToAdd)
		{
			if (global::System.IntPtr.Size == 4)
			{
				return new global::System.IntPtr(ptr.ToInt32() | bitsToAdd);
			}
			return new global::System.IntPtr(ptr.ToInt64() | (long)((ulong)bitsToAdd));
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x0002D5F0 File Offset: 0x0002B7F0
		internal static void AdjustMaximizedRect(ref global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT rect)
		{
			global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT monitorRect = global::Infragistics.Windows.Helpers.NativeWindowMethods.GetMonitorRect(rect);
			if (global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT.Intersect(monitorRect, rect).Height == monitorRect.Height)
			{
				rect.bottom = monitorRect.bottom - 1;
			}
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x0002D635 File Offset: 0x0002B835
		internal static bool AreBitsPresent(global::System.IntPtr ptr, int bits)
		{
			if (global::System.IntPtr.Size == 4)
			{
				return (ptr.ToInt32() & bits) != 0;
			}
			return (ptr.ToInt64() & (long)bits) != 0L;
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x0002D660 File Offset: 0x0002B860
		internal static global::System.IntPtr EncodeSize(int width, int height)
		{
			return new global::System.IntPtr(height << 16 | width);
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x0002D66D File Offset: 0x0002B86D
		internal static long GetBits(global::System.IntPtr ptr)
		{
			if (global::System.IntPtr.Size == 4)
			{
				return (long)ptr.ToInt32();
			}
			return ptr.ToInt64();
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x0002D688 File Offset: 0x0002B888
		internal static global::System.Windows.Point GetCursorPosApi()
		{
			if (!global::Infragistics.Windows.Helpers.NativeWindowMethods._securityException)
			{
				try
				{
					return global::Infragistics.Windows.Helpers.NativeWindowMethods.GetCursorPosUnsafe();
				}
				catch (global::System.Security.SecurityException)
				{
					global::Infragistics.Windows.Helpers.NativeWindowMethods._securityException = true;
				}
			}
			return global::Infragistics.Windows.Helpers.NativeWindowMethods.GetCursorPosSafe();
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x0002D6C4 File Offset: 0x0002B8C4
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private static global::System.Windows.Point GetCursorPosSafe()
		{
			global::System.Drawing.Point position = global::System.Windows.Forms.Cursor.Position;
			return new global::System.Windows.Point((double)position.X, (double)position.Y);
		}

		// Token: 0x06000E29 RID: 3625 RVA: 0x0002D6EC File Offset: 0x0002B8EC
		private static global::System.Windows.Point GetCursorPosUnsafe()
		{
			global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT point = default(global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT);
			global::Infragistics.Windows.Helpers.NativeWindowMethods.GetCursorPos(ref point);
			return point.Point;
		}

		// Token: 0x06000E2A RID: 3626 RVA: 0x0002D710 File Offset: 0x0002B910
		internal static global::Infragistics.Windows.Helpers.NativeWindowMethods.HitTestResults GetHitTestResult(global::Infragistics.Windows.Controls.ToolWindowPart part)
		{
			switch (part)
			{
			case global::Infragistics.Windows.Controls.ToolWindowPart.Caption:
			case global::Infragistics.Windows.Controls.ToolWindowPart.Content:
				return global::Infragistics.Windows.Helpers.NativeWindowMethods.HitTestResults.HTCLIENT;
			case global::Infragistics.Windows.Controls.ToolWindowPart.BorderLeft:
				return global::Infragistics.Windows.Helpers.NativeWindowMethods.HitTestResults.HTLEFT;
			case global::Infragistics.Windows.Controls.ToolWindowPart.BorderRight:
				return global::Infragistics.Windows.Helpers.NativeWindowMethods.HitTestResults.HTRIGHT;
			case global::Infragistics.Windows.Controls.ToolWindowPart.BorderTop:
				return global::Infragistics.Windows.Helpers.NativeWindowMethods.HitTestResults.HTTOP;
			case global::Infragistics.Windows.Controls.ToolWindowPart.BorderBottom:
				return global::Infragistics.Windows.Helpers.NativeWindowMethods.HitTestResults.HTBOTTOM;
			case global::Infragistics.Windows.Controls.ToolWindowPart.BorderTopLeft:
				return global::Infragistics.Windows.Helpers.NativeWindowMethods.HitTestResults.HTTOPLEFT;
			case global::Infragistics.Windows.Controls.ToolWindowPart.BorderTopRight:
				return global::Infragistics.Windows.Helpers.NativeWindowMethods.HitTestResults.HTTOPRIGHT;
			case global::Infragistics.Windows.Controls.ToolWindowPart.BorderBottomLeft:
				return global::Infragistics.Windows.Helpers.NativeWindowMethods.HitTestResults.HTBOTTOMLEFT;
			case global::Infragistics.Windows.Controls.ToolWindowPart.BorderBottomRight:
				return global::Infragistics.Windows.Helpers.NativeWindowMethods.HitTestResults.HTBOTTOMRIGHT;
			case global::Infragistics.Windows.Controls.ToolWindowPart.ResizeGrip:
				return global::Infragistics.Windows.Helpers.NativeWindowMethods.HitTestResults.HTBOTTOMRIGHT;
			default:
				return global::Infragistics.Windows.Helpers.NativeWindowMethods.HitTestResults.HTCLIENT;
			}
		}

		// Token: 0x06000E2B RID: 3627 RVA: 0x0002D774 File Offset: 0x0002B974
		internal static global::System.Windows.Size GetHwndBorderSize(global::System.Windows.Window window)
		{
			if (!global::Infragistics.Windows.Helpers.NativeWindowMethods.hasSecurityExceptionBeenThrown)
			{
				try
				{
					global::System.Windows.Size result;
					if (global::Infragistics.Windows.Helpers.NativeWindowMethods.GetHwndBorderSizeUnsafe(window, out result))
					{
						return result;
					}
				}
				catch (global::System.Security.SecurityException)
				{
					global::Infragistics.Windows.Helpers.NativeWindowMethods.hasSecurityExceptionBeenThrown = true;
				}
			}
			switch (window.ResizeMode)
			{
			case global::System.Windows.ResizeMode.NoResize:
				return new global::System.Windows.Size(global::System.Windows.SystemParameters.FixedFrameVerticalBorderWidth, global::System.Windows.SystemParameters.FixedFrameHorizontalBorderHeight);
			default:
				return new global::System.Windows.Size(global::System.Windows.SystemParameters.ResizeFrameVerticalBorderWidth, global::System.Windows.SystemParameters.ResizeFrameHorizontalBorderHeight);
			}
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x0002D7F0 File Offset: 0x0002B9F0
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private static bool GetHwndBorderSizeUnsafe(global::System.Windows.Window window, out global::System.Windows.Size borderSize)
		{
			global::System.Windows.Interop.WindowInteropHelper windowInteropHelper = new global::System.Windows.Interop.WindowInteropHelper(window);
			if (windowInteropHelper.Handle == global::System.IntPtr.Zero)
			{
				borderSize = global::System.Windows.Size.Empty;
				return false;
			}
			int dwStyle = global::Infragistics.Windows.Helpers.NativeWindowMethods.IntPtrToInt32(global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowLong(windowInteropHelper.Handle, -16));
			int dwExStyle = global::Infragistics.Windows.Helpers.NativeWindowMethods.IntPtrToInt32(global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowLong(windowInteropHelper.Handle, -20));
			global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT rect = default(global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT);
			global::Infragistics.Windows.Helpers.NativeWindowMethods.AdjustWindowRectExApi(ref rect, dwStyle, false, dwExStyle);
			double width = global::Infragistics.Windows.Utilities.ConvertToLogicalPixels(rect.right, window);
			double height = global::Infragistics.Windows.Utilities.ConvertToLogicalPixels(rect.bottom, window);
			borderSize = new global::System.Windows.Size(width, height);
			return true;
		}

		// Token: 0x06000E2D RID: 3629 RVA: 0x0002D88C File Offset: 0x0002BA8C
		private static global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT GetMonitorRect(global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT rect)
		{
			if (global::Infragistics.Windows.Helpers.NativeWindowMethods.GetSystemMetrics(80) == 0)
			{
				return new global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT(0, 0, global::Infragistics.Windows.Helpers.NativeWindowMethods.GetSystemMetrics(0), global::Infragistics.Windows.Helpers.NativeWindowMethods.GetSystemMetrics(1));
			}
			global::System.IntPtr handle = global::Infragistics.Windows.Helpers.NativeWindowMethods.MonitorFromRect(ref rect, 2);
			global::Infragistics.Windows.Helpers.NativeWindowMethods.MONITIORINFOEX monitiorinfoex = new global::Infragistics.Windows.Helpers.NativeWindowMethods.MONITIORINFOEX();
			global::Infragistics.Windows.Helpers.NativeWindowMethods.GetMonitorInfo(new global::System.Runtime.InteropServices.HandleRef(null, handle), monitiorinfoex);
			return monitiorinfoex._rcMonitor;
		}

		// Token: 0x06000E2E RID: 3630 RVA: 0x0002D8DC File Offset: 0x0002BADC
		internal static global::Infragistics.Windows.Helpers.NativeWindowMethods.SIZE GetNonClientSize(global::System.IntPtr hwnd)
		{
			int dwStyle = global::Infragistics.Windows.Helpers.NativeWindowMethods.IntPtrToInt32(global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowLong(hwnd, -16));
			int dwExStyle = global::Infragistics.Windows.Helpers.NativeWindowMethods.IntPtrToInt32(global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowLong(hwnd, -20));
			global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT rect = default(global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT);
			global::Infragistics.Windows.Helpers.NativeWindowMethods.AdjustWindowRectExApi(ref rect, dwStyle, false, dwExStyle);
			return new global::Infragistics.Windows.Helpers.NativeWindowMethods.SIZE(rect.right - rect.left, rect.bottom - rect.top);
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x0002D93C File Offset: 0x0002BB3C
		internal static string GetRegisteredMessageName(int message)
		{
			if (message >= 49152 && message <= 65535)
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(256);
				int clipboardFormatName = global::Infragistics.Windows.Helpers.NativeWindowMethods.GetClipboardFormatName(message, stringBuilder, stringBuilder.Capacity);
				if (clipboardFormatName > 0)
				{
					return stringBuilder.ToString(0, clipboardFormatName);
				}
			}
			return null;
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x0002D980 File Offset: 0x0002BB80
		internal static int GetScreenHeight(global::System.IntPtr hwnd)
		{
			global::System.IntPtr intPtr = global::Infragistics.Windows.Helpers.NativeWindowMethods.MonitorFromWindow(hwnd, 0U);
			if (intPtr == global::System.IntPtr.Zero)
			{
				intPtr = global::Infragistics.Windows.Helpers.NativeWindowMethods.MonitorFromWindow(hwnd, 2U);
			}
			if (global::System.IntPtr.Zero != intPtr)
			{
				global::Infragistics.Windows.Helpers.NativeWindowMethods.MONITORINFO monitorinfo = default(global::Infragistics.Windows.Helpers.NativeWindowMethods.MONITORINFO);
				monitorinfo.cbSize = (uint)global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Infragistics.Windows.Helpers.NativeWindowMethods.MONITORINFO));
				if (global::Infragistics.Windows.Helpers.NativeWindowMethods.GetMonitorInfo(intPtr, out monitorinfo))
				{
					return monitorinfo.rcMonitor.bottom - monitorinfo.rcMonitor.top;
				}
			}
			return global::Infragistics.Windows.Utilities.ConvertFromLogicalPixels(global::System.Windows.SystemParameters.PrimaryScreenHeight);
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x0002DA04 File Offset: 0x0002BC04
		internal static global::Infragistics.Windows.Helpers.NativeWindowMethods.WINDOWINFO GetWindowInfo(global::System.IntPtr hwnd)
		{
			global::Infragistics.Windows.Helpers.NativeWindowMethods.WINDOWINFO windowinfo = default(global::Infragistics.Windows.Helpers.NativeWindowMethods.WINDOWINFO);
			windowinfo.cbSize = global::System.Runtime.InteropServices.Marshal.SizeOf(windowinfo);
			global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowInfo(hwnd, ref windowinfo);
			return windowinfo;
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x0002DA38 File Offset: 0x0002BC38
		internal static global::Infragistics.Windows.Helpers.NativeWindowMethods.WINDOWPLACEMENT GetWindowPlacement(global::System.IntPtr hwnd)
		{
			global::Infragistics.Windows.Helpers.NativeWindowMethods.WINDOWPLACEMENT result = default(global::Infragistics.Windows.Helpers.NativeWindowMethods.WINDOWPLACEMENT);
			result.length = global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Infragistics.Windows.Helpers.NativeWindowMethods.WINDOWPLACEMENT));
			if (hwnd != global::System.IntPtr.Zero)
			{
				global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowPlacement(hwnd, ref result);
			}
			return result;
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x0002DA7C File Offset: 0x0002BC7C
		internal static global::System.Windows.WindowState GetWindowState(global::System.Windows.Window window)
		{
			if (window == null)
			{
				return global::System.Windows.WindowState.Normal;
			}
			global::System.Windows.Interop.WindowInteropHelper windowInteropHelper = new global::System.Windows.Interop.WindowInteropHelper(window);
			if (windowInteropHelper.Handle == global::System.IntPtr.Zero)
			{
				return window.WindowState;
			}
			return global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowState(windowInteropHelper.Handle);
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x0002DABC File Offset: 0x0002BCBC
		internal static global::System.Windows.WindowState GetWindowState(global::System.IntPtr hwnd)
		{
			global::System.Windows.WindowState result = global::System.Windows.WindowState.Normal;
			if (global::System.IntPtr.Zero != hwnd)
			{
				global::Infragistics.Windows.Helpers.NativeWindowMethods.WINDOWPLACEMENT windowPlacement = global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowPlacement(hwnd);
				if (windowPlacement.showCmd == 2)
				{
					result = global::System.Windows.WindowState.Minimized;
				}
				else if (windowPlacement.showCmd == 3)
				{
					result = global::System.Windows.WindowState.Maximized;
				}
				else
				{
					result = global::System.Windows.WindowState.Normal;
				}
			}
			return result;
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x0002DB00 File Offset: 0x0002BD00
		internal static global::System.Windows.Rect GetWorkArea(global::System.Windows.Point point)
		{
			global::Infragistics.Windows.Helpers.NativeWindowMethods.ScreenHelper screenHelper = global::Infragistics.Windows.Helpers.NativeWindowMethods.ScreenHelper.FromPoint(point);
			return screenHelper.WorkingArea;
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x0002DB1C File Offset: 0x0002BD1C
		internal static global::System.Windows.Rect GetWorkArea(global::System.Windows.Rect screenRect)
		{
			global::Infragistics.Windows.Helpers.NativeWindowMethods.ScreenHelper screenHelper = global::Infragistics.Windows.Helpers.NativeWindowMethods.ScreenHelper.FromRect(screenRect);
			return screenHelper.WorkingArea;
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x0002DB36 File Offset: 0x0002BD36
		internal static int GetXFromLParam(global::System.IntPtr lParam)
		{
			return global::Infragistics.Windows.Helpers.NativeWindowMethods.SignedLoWord(global::Infragistics.Windows.Helpers.NativeWindowMethods.IntPtrToInt32(lParam));
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x0002DB43 File Offset: 0x0002BD43
		internal static int GetYFromLParam(global::System.IntPtr lParam)
		{
			return global::Infragistics.Windows.Helpers.NativeWindowMethods.SignedHiWord(global::Infragistics.Windows.Helpers.NativeWindowMethods.IntPtrToInt32(lParam));
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x0002DB50 File Offset: 0x0002BD50
		internal static int IntPtrToInt32(global::System.IntPtr intPtr)
		{
			return (int)intPtr.ToInt64();
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000E3A RID: 3642 RVA: 0x0002DB5C File Offset: 0x0002BD5C
		internal static bool IsDWMCompositionEnabled
		{
			get
			{
				if (global::System.Environment.OSVersion.Version.Major < 6)
				{
					return false;
				}
				bool result;
				try
				{
					result = global::Infragistics.Windows.Helpers.NativeWindowMethods.UnsafeIsDWMCompositionEnabled();
				}
				catch
				{
					result = false;
				}
				return result;
			}
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x0002DB9C File Offset: 0x0002BD9C
		private static bool UnsafeIsDWMCompositionEnabled()
		{
			bool flag;
			return global::Infragistics.Windows.Helpers.NativeWindowMethods.DwmIsCompositionEnabled(out flag) == 0 && flag;
		}

		// Token: 0x06000E3C RID: 3644
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Bool)]
		internal static extern bool IsWindowVisible(global::System.IntPtr hwnd);

		// Token: 0x06000E3D RID: 3645 RVA: 0x0002DBB8 File Offset: 0x0002BDB8
		internal static bool IsTopMostApi(global::System.IntPtr hwnd)
		{
			bool result = false;
			if (hwnd != global::System.IntPtr.Zero)
			{
				global::System.IntPtr ancestorApi = global::Infragistics.Windows.Helpers.NativeWindowMethods.GetAncestorApi(hwnd, 2);
				if (ancestorApi != global::System.IntPtr.Zero)
				{
					global::System.IntPtr windowLong = global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowLong(ancestorApi, -20);
					result = global::Infragistics.Windows.Helpers.NativeWindowMethods.AreBitsPresent(windowLong, 8);
				}
			}
			return result;
		}

		// Token: 0x06000E3E RID: 3646 RVA: 0x0002DBFC File Offset: 0x0002BDFC
		internal static bool IsWindowStyleRemoved(global::System.Windows.Window window, int styleBit)
		{
			global::System.Windows.Interop.WindowInteropHelper windowInteropHelper = new global::System.Windows.Interop.WindowInteropHelper(window);
			if (windowInteropHelper.Handle != global::System.IntPtr.Zero)
			{
				global::System.IntPtr windowLong = global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowLong(windowInteropHelper.Handle, -16);
				if (!global::Infragistics.Windows.Helpers.NativeWindowMethods.AreBitsPresent(windowLong, styleBit))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x0002DC3C File Offset: 0x0002BE3C
		internal static global::System.IntPtr MakeLParam(int width, int height)
		{
			return (global::System.IntPtr)((int)((short)height) << 16 | (width & 65535));
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x0002DC50 File Offset: 0x0002BE50
		internal static void NotifyFrameChange(global::System.IntPtr hwnd)
		{
			if (hwnd != global::System.IntPtr.Zero)
			{
				global::Infragistics.Windows.Helpers.NativeWindowMethods.SetWindowPosApi(hwnd, global::System.IntPtr.Zero, 0, 0, 0, 0, 567);
			}
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x0002DC74 File Offset: 0x0002BE74
		internal static global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT PointFromLParam(global::System.IntPtr lParam)
		{
			int value = global::Infragistics.Windows.Helpers.NativeWindowMethods.IntPtrToInt32(lParam);
			return new global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT(global::Infragistics.Windows.Helpers.NativeWindowMethods.SignedLoWord(value), global::Infragistics.Windows.Helpers.NativeWindowMethods.SignedHiWord(value));
		}

		// Token: 0x06000E42 RID: 3650 RVA: 0x0002DC9C File Offset: 0x0002BE9C
		internal static bool PreventClose(global::System.Windows.Window window)
		{
			global::System.Windows.Interop.WindowInteropHelper windowInteropHelper = new global::System.Windows.Interop.WindowInteropHelper(window);
			global::System.IntPtr handle = windowInteropHelper.Handle;
			if (handle != global::System.IntPtr.Zero)
			{
				global::System.IntPtr systemMenu = global::Infragistics.Windows.Helpers.NativeWindowMethods.GetSystemMenu(handle, false);
				if (global::System.IntPtr.Zero != systemMenu)
				{
					int menuState = global::Infragistics.Windows.Helpers.NativeWindowMethods.GetMenuState(systemMenu, 61536, 0);
					if ((menuState & 3) != 0)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x0002DCEE File Offset: 0x0002BEEE
		internal static global::System.IntPtr RemoveBits(global::System.IntPtr ptr, int bitsToRemove)
		{
			if (global::System.IntPtr.Size == 4)
			{
				return new global::System.IntPtr(ptr.ToInt32() & ~bitsToRemove);
			}
			return new global::System.IntPtr(ptr.ToInt64() & (long)(~(long)bitsToRemove));
		}

		// Token: 0x06000E44 RID: 3652 RVA: 0x0002DD18 File Offset: 0x0002BF18
		internal static global::System.IntPtr RemoveBits(global::System.IntPtr ptr, int bitsToRemove, out int bitsRemoved)
		{
			if (global::System.IntPtr.Size == 4)
			{
				int num = ptr.ToInt32();
				bitsRemoved = (num & bitsToRemove);
				return new global::System.IntPtr(num & ~bitsToRemove);
			}
			long num2 = ptr.ToInt64();
			bitsRemoved = (int)(num2 & (long)bitsToRemove);
			return new global::System.IntPtr(num2 & (long)(~(long)bitsToRemove));
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x0002DD60 File Offset: 0x0002BF60
		internal static void SetZorder(global::System.Windows.Window window, global::System.Windows.Window windowAfter)
		{
			global::System.Windows.Interop.HwndSource hwndSource = global::System.Windows.PresentationSource.FromVisual(window) as global::System.Windows.Interop.HwndSource;
			global::System.Windows.Interop.HwndSource hwndSource2 = global::System.Windows.PresentationSource.FromVisual(windowAfter) as global::System.Windows.Interop.HwndSource;
			global::System.IntPtr handle = hwndSource.Handle;
			global::System.IntPtr handle2 = hwndSource2.Handle;
			if (handle != global::System.IntPtr.Zero && handle2 != global::System.IntPtr.Zero)
			{
				global::Infragistics.Windows.Helpers.NativeWindowMethods.SetWindowPosApi(handle, handle2, 0, 0, 0, 0, 531);
			}
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x0002DDBE File Offset: 0x0002BFBE
		internal static void SetZorder(global::System.IntPtr hwnd, global::System.IntPtr hwndAfter)
		{
			global::Infragistics.Windows.Helpers.NativeWindowMethods.SetWindowPosApi(hwnd, hwndAfter, 0, 0, 0, 0, 531);
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x0002DDD1 File Offset: 0x0002BFD1
		internal static int SignedLoWord(int value)
		{
			return (int)((short)(value & 65535));
		}

		// Token: 0x06000E48 RID: 3656 RVA: 0x0002DDDB File Offset: 0x0002BFDB
		internal static int SignedHiWord(int value)
		{
			return (int)((short)(value >> 16 & 65535));
		}

		// Token: 0x04000682 RID: 1666
		internal const int HCBT_ACTIVATE = 5;

		// Token: 0x04000683 RID: 1667
		internal const uint GW_HWNDFIRST = 0U;

		// Token: 0x04000684 RID: 1668
		internal const uint GW_HWNDLAST = 1U;

		// Token: 0x04000685 RID: 1669
		internal const uint GW_HWNDNEXT = 2U;

		// Token: 0x04000686 RID: 1670
		internal const uint GW_HWNDPREV = 3U;

		// Token: 0x04000687 RID: 1671
		internal const uint GW_OWNER = 4U;

		// Token: 0x04000688 RID: 1672
		internal const uint GW_CHILD = 5U;

		// Token: 0x04000689 RID: 1673
		internal const uint GW_ENABLEDPOPUP = 6U;

		// Token: 0x0400068A RID: 1674
		internal const int GWL_HWNDPARENT = -8;

		// Token: 0x0400068B RID: 1675
		internal const int GWL_STYLE = -16;

		// Token: 0x0400068C RID: 1676
		internal const int GWL_EXSTYLE = -20;

		// Token: 0x0400068D RID: 1677
		internal const int HTTRANSPARENT = -1;

		// Token: 0x0400068E RID: 1678
		internal const int HTNOWHERE = 0;

		// Token: 0x0400068F RID: 1679
		internal const int HTCLIENT = 1;

		// Token: 0x04000690 RID: 1680
		internal const int HTCAPTION = 2;

		// Token: 0x04000691 RID: 1681
		internal const int HTSYSMENU = 3;

		// Token: 0x04000692 RID: 1682
		internal const int HTGROWBOX = 4;

		// Token: 0x04000693 RID: 1683
		internal const int HTLEFT = 10;

		// Token: 0x04000694 RID: 1684
		internal const int HTRIGHT = 11;

		// Token: 0x04000695 RID: 1685
		internal const int HTTOP = 12;

		// Token: 0x04000696 RID: 1686
		internal const int HTTOPLEFT = 13;

		// Token: 0x04000697 RID: 1687
		internal const int HTTOPRIGHT = 14;

		// Token: 0x04000698 RID: 1688
		internal const int HTBOTTOM = 15;

		// Token: 0x04000699 RID: 1689
		internal const int HTBOTTOMLEFT = 16;

		// Token: 0x0400069A RID: 1690
		internal const int HTBOTTOMRIGHT = 17;

		// Token: 0x0400069B RID: 1691
		internal const int HTBORDER = 18;

		// Token: 0x0400069C RID: 1692
		internal const int HTMAXBUTTON = 9;

		// Token: 0x0400069D RID: 1693
		internal const int HTMINBUTTON = 8;

		// Token: 0x0400069E RID: 1694
		internal const int HTCLOSE = 20;

		// Token: 0x0400069F RID: 1695
		internal const int MF_INSERT = 0;

		// Token: 0x040006A0 RID: 1696
		internal const int MF_CHANGE = 128;

		// Token: 0x040006A1 RID: 1697
		internal const int MF_APPEND = 256;

		// Token: 0x040006A2 RID: 1698
		internal const int MF_DELETE = 512;

		// Token: 0x040006A3 RID: 1699
		internal const int MF_REMOVE = 4096;

		// Token: 0x040006A4 RID: 1700
		internal const int MF_BYCOMMAND = 0;

		// Token: 0x040006A5 RID: 1701
		internal const int MF_BYPOSITION = 1024;

		// Token: 0x040006A6 RID: 1702
		internal const int MF_SEPARATOR = 2048;

		// Token: 0x040006A7 RID: 1703
		internal const int MF_ENABLED = 0;

		// Token: 0x040006A8 RID: 1704
		internal const int MF_GRAYED = 1;

		// Token: 0x040006A9 RID: 1705
		internal const int MF_DISABLED = 2;

		// Token: 0x040006AA RID: 1706
		internal const int MF_UNCHECKED = 0;

		// Token: 0x040006AB RID: 1707
		internal const int MF_CHECKED = 8;

		// Token: 0x040006AC RID: 1708
		internal const int MF_USECHECKBITMAPS = 512;

		// Token: 0x040006AD RID: 1709
		internal const int MF_STRING = 0;

		// Token: 0x040006AE RID: 1710
		internal const int MF_BITMAP = 4;

		// Token: 0x040006AF RID: 1711
		internal const int MF_OWNERDRAW = 256;

		// Token: 0x040006B0 RID: 1712
		internal const int MF_POPUP = 16;

		// Token: 0x040006B1 RID: 1713
		internal const int MF_MENUBARBREAK = 32;

		// Token: 0x040006B2 RID: 1714
		internal const int MF_MENUBREAK = 64;

		// Token: 0x040006B3 RID: 1715
		internal const int MF_UNHILITE = 0;

		// Token: 0x040006B4 RID: 1716
		internal const int MF_HILITE = 128;

		// Token: 0x040006B5 RID: 1717
		internal const int MF_DEFAULT = 4096;

		// Token: 0x040006B6 RID: 1718
		internal const int MF_SYSMENU = 8192;

		// Token: 0x040006B7 RID: 1719
		internal const int MF_HELP = 16384;

		// Token: 0x040006B8 RID: 1720
		internal const int MF_RIGHTJUSTIFY = 16384;

		// Token: 0x040006B9 RID: 1721
		internal const int MF_MOUSESELECT = 32768;

		// Token: 0x040006BA RID: 1722
		internal const int MONITOR_DEFAULTTONULL = 0;

		// Token: 0x040006BB RID: 1723
		internal const int MONITOR_DEFAULTTOPRIMARY = 1;

		// Token: 0x040006BC RID: 1724
		internal const int MONITOR_DEFAULTTONEAREST = 2;

		// Token: 0x040006BD RID: 1725
		internal const int SC_MINIMIZE = 61472;

		// Token: 0x040006BE RID: 1726
		internal const int SC_MAXIMIZE = 61488;

		// Token: 0x040006BF RID: 1727
		internal const int SC_NEXTWINDOW = 61504;

		// Token: 0x040006C0 RID: 1728
		internal const int SC_CLOSE = 61536;

		// Token: 0x040006C1 RID: 1729
		internal const int SC_RESTORE = 61728;

		// Token: 0x040006C2 RID: 1730
		internal const int SC_KEYMENU = 61696;

		// Token: 0x040006C3 RID: 1731
		internal const int SC_MOUSEMENU = 61584;

		// Token: 0x040006C4 RID: 1732
		internal const int SC_CONTEXTHELP = 61824;

		// Token: 0x040006C5 RID: 1733
		internal const int SC_MOVE = 61456;

		// Token: 0x040006C6 RID: 1734
		internal const int SC_DRAGMOVE = 61458;

		// Token: 0x040006C7 RID: 1735
		internal const int SIZE_RESTORED = 0;

		// Token: 0x040006C8 RID: 1736
		internal const int SIZE_MINIMIZED = 1;

		// Token: 0x040006C9 RID: 1737
		internal const int SIZE_MAXIMIZED = 2;

		// Token: 0x040006CA RID: 1738
		internal const int SIZE_MAXSHOW = 3;

		// Token: 0x040006CB RID: 1739
		internal const int SIZE_MAXHIDE = 4;

		// Token: 0x040006CC RID: 1740
		private const int SM_CXVIRTUALSCREEN = 78;

		// Token: 0x040006CD RID: 1741
		private const int SM_CMONITORS = 80;

		// Token: 0x040006CE RID: 1742
		private const int SM_CXSCREEN = 0;

		// Token: 0x040006CF RID: 1743
		private const int SM_CYSCREEN = 1;

		// Token: 0x040006D0 RID: 1744
		internal const int SW_FORCEMINIMIZE = 11;

		// Token: 0x040006D1 RID: 1745
		internal const int SW_HIDE = 0;

		// Token: 0x040006D2 RID: 1746
		internal const int SW_MAXIMIZE = 3;

		// Token: 0x040006D3 RID: 1747
		internal const int SW_MINIMIZE = 6;

		// Token: 0x040006D4 RID: 1748
		internal const int SW_RESTORE = 9;

		// Token: 0x040006D5 RID: 1749
		internal const int SW_SHOW = 5;

		// Token: 0x040006D6 RID: 1750
		internal const int SW_SHOWDEFAULT = 10;

		// Token: 0x040006D7 RID: 1751
		internal const int SW_SHOWMAXIMIZED = 3;

		// Token: 0x040006D8 RID: 1752
		internal const int SW_SHOWMINIMIZED = 2;

		// Token: 0x040006D9 RID: 1753
		internal const int SW_SHOWMINNOACTIVE = 7;

		// Token: 0x040006DA RID: 1754
		internal const int SW_SHOWNA = 8;

		// Token: 0x040006DB RID: 1755
		internal const int SW_SHOWNOACTIVATE = 4;

		// Token: 0x040006DC RID: 1756
		internal const int SW_SHOWNORMAL = 1;

		// Token: 0x040006DD RID: 1757
		internal const int SWP_NOACTIVATE = 16;

		// Token: 0x040006DE RID: 1758
		internal const int SWP_SHOWWINDOW = 64;

		// Token: 0x040006DF RID: 1759
		internal const int SWP_NOSIZE = 1;

		// Token: 0x040006E0 RID: 1760
		internal const int SWP_NOMOVE = 2;

		// Token: 0x040006E1 RID: 1761
		internal const int SWP_NOSENDCHANGING = 1024;

		// Token: 0x040006E2 RID: 1762
		internal const int SWP_FRAMECHANGED = 32;

		// Token: 0x040006E3 RID: 1763
		internal const int SWP_NOOWNERZORDER = 512;

		// Token: 0x040006E4 RID: 1764
		internal const int SWP_NOZORDER = 4;

		// Token: 0x040006E5 RID: 1765
		internal const int SWP_NOREDRAW = 8;

		// Token: 0x040006E6 RID: 1766
		internal const int SWP_HIDEWINDOW = 128;

		// Token: 0x040006E7 RID: 1767
		internal const int SWP_NOCOPYBITS = 256;

		// Token: 0x040006E8 RID: 1768
		internal const int SWP_DRAWFRAME = 32;

		// Token: 0x040006E9 RID: 1769
		internal const int SWP_NOREPOSITION = 512;

		// Token: 0x040006EA RID: 1770
		internal const int SWP_DEFERERASE = 8192;

		// Token: 0x040006EB RID: 1771
		internal const int SWP_ASYNCWINDOWPOS = 16384;

		// Token: 0x040006EC RID: 1772
		internal const int SWP_STATECHANGED = 32768;

		// Token: 0x040006ED RID: 1773
		internal const int WH_CBT = 5;

		// Token: 0x040006EE RID: 1774
		internal const int WM_DESTROY = 2;

		// Token: 0x040006EF RID: 1775
		internal const int WM_NCHITTEST = 132;

		// Token: 0x040006F0 RID: 1776
		internal const int WM_NCCALCSIZE = 131;

		// Token: 0x040006F1 RID: 1777
		internal const int WM_NCUAHDRAWCAPTION = 174;

		// Token: 0x040006F2 RID: 1778
		internal const int WM_NCUAHDRAWFRAME = 175;

		// Token: 0x040006F3 RID: 1779
		internal const int WM_NCPAINT = 133;

		// Token: 0x040006F4 RID: 1780
		internal const int WM_NCACTIVATE = 134;

		// Token: 0x040006F5 RID: 1781
		internal const int WM_STYLECHANGING = 124;

		// Token: 0x040006F6 RID: 1782
		internal const int WM_GETMINMAXINFO = 36;

		// Token: 0x040006F7 RID: 1783
		internal const int WM_GETSYSMENU = 787;

		// Token: 0x040006F8 RID: 1784
		internal const int WM_GETTITLEBARINFOEX = 831;

		// Token: 0x040006F9 RID: 1785
		internal const int WM_MOVING = 534;

		// Token: 0x040006FA RID: 1786
		internal const int WM_SIZE = 5;

		// Token: 0x040006FB RID: 1787
		internal const int WM_CONTEXTMENU = 123;

		// Token: 0x040006FC RID: 1788
		internal const int WM_SYSCOMMAND = 274;

		// Token: 0x040006FD RID: 1789
		internal const int WM_NCMOUSEMOVE = 160;

		// Token: 0x040006FE RID: 1790
		internal const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x040006FF RID: 1791
		internal const int WM_NCLBUTTONUP = 162;

		// Token: 0x04000700 RID: 1792
		internal const int WM_NCLBUTTONDBLCLK = 163;

		// Token: 0x04000701 RID: 1793
		internal const int WM_NCRBUTTONDOWN = 164;

		// Token: 0x04000702 RID: 1794
		internal const int WM_NCRBUTTONUP = 165;

		// Token: 0x04000703 RID: 1795
		internal const int WM_NCRBUTTONDBLCLK = 166;

		// Token: 0x04000704 RID: 1796
		internal const int WM_NCMBUTTONDOWN = 167;

		// Token: 0x04000705 RID: 1797
		internal const int WM_NCMBUTTONUP = 168;

		// Token: 0x04000706 RID: 1798
		internal const int WM_NCMBUTTONDBLCLK = 169;

		// Token: 0x04000707 RID: 1799
		internal const int WM_MOVE = 3;

		// Token: 0x04000708 RID: 1800
		internal const int WM_SETICON = 128;

		// Token: 0x04000709 RID: 1801
		internal const int WM_SETCURSOR = 32;

		// Token: 0x0400070A RID: 1802
		internal const int WM_SETTEXT = 12;

		// Token: 0x0400070B RID: 1803
		internal const int WM_DWMCOMPOSITIONCHANGED = 798;

		// Token: 0x0400070C RID: 1804
		internal const int WM_WINDOWPOSCHANGING = 70;

		// Token: 0x0400070D RID: 1805
		internal const int WM_WINDOWPOSCHANGED = 71;

		// Token: 0x0400070E RID: 1806
		internal const int WM_SHOWWINDOW = 24;

		// Token: 0x0400070F RID: 1807
		internal const int WM_MOUSEACTIVATE = 33;

		// Token: 0x04000710 RID: 1808
		internal const int MA_ACTIVATE = 1;

		// Token: 0x04000711 RID: 1809
		internal const int MA_ACTIVATEANDEAT = 2;

		// Token: 0x04000712 RID: 1810
		internal const int MA_NOACTIVATE = 3;

		// Token: 0x04000713 RID: 1811
		internal const int MA_NOACTIVATEANDEAT = 4;

		// Token: 0x04000714 RID: 1812
		internal const int WM_DISPLAYCHANGE = 126;

		// Token: 0x04000715 RID: 1813
		internal const int WM_LBUTTONUP = 514;

		// Token: 0x04000716 RID: 1814
		internal const int WM_ENTERSIZEMOVE = 561;

		// Token: 0x04000717 RID: 1815
		internal const int WM_EXITSIZEMOVE = 562;

		// Token: 0x04000718 RID: 1816
		internal const int WM_TABLET_DEFBASE = 704;

		// Token: 0x04000719 RID: 1817
		internal const int WM_TABLET_QUERYSYSTEMGESTURESTATUS = 716;

		// Token: 0x0400071A RID: 1818
		internal const int WS_MINIMIZEBOX = 131072;

		// Token: 0x0400071B RID: 1819
		internal const int WS_MAXIMIZEBOX = 65536;

		// Token: 0x0400071C RID: 1820
		internal const int WS_SYSMENU = 524288;

		// Token: 0x0400071D RID: 1821
		internal const int WS_OVERLAPPED = 0;

		// Token: 0x0400071E RID: 1822
		internal const int WS_POPUP = -2147483648;

		// Token: 0x0400071F RID: 1823
		internal const int WS_CHILD = 1073741824;

		// Token: 0x04000720 RID: 1824
		internal const int WS_MINIMIZE = 536870912;

		// Token: 0x04000721 RID: 1825
		internal const int WS_VISIBLE = 268435456;

		// Token: 0x04000722 RID: 1826
		internal const int WS_DISABLED = 134217728;

		// Token: 0x04000723 RID: 1827
		internal const int WS_CLIPSIBLINGS = 67108864;

		// Token: 0x04000724 RID: 1828
		internal const int WS_CLIPCHILDREN = 33554432;

		// Token: 0x04000725 RID: 1829
		internal const int WS_MAXIMIZE = 16777216;

		// Token: 0x04000726 RID: 1830
		internal const int WS_CAPTION = 12582912;

		// Token: 0x04000727 RID: 1831
		internal const int WS_BORDER = 8388608;

		// Token: 0x04000728 RID: 1832
		internal const int WS_DLGFRAME = 4194304;

		// Token: 0x04000729 RID: 1833
		internal const int WS_VSCROLL = 2097152;

		// Token: 0x0400072A RID: 1834
		internal const int WS_HSCROLL = 1048576;

		// Token: 0x0400072B RID: 1835
		internal const int WS_THICKFRAME = 262144;

		// Token: 0x0400072C RID: 1836
		internal const int WS_GROUP = 131072;

		// Token: 0x0400072D RID: 1837
		internal const int WS_TABSTOP = 65536;

		// Token: 0x0400072E RID: 1838
		internal const int WS_TILED = 0;

		// Token: 0x0400072F RID: 1839
		internal const int WS_ICONIC = 536870912;

		// Token: 0x04000730 RID: 1840
		internal const int WS_SIZEBOX = 262144;

		// Token: 0x04000731 RID: 1841
		internal const int WS_TILEDWINDOW = 13565952;

		// Token: 0x04000732 RID: 1842
		internal const int WS_OVERLAPPEDWINDOW = 13565952;

		// Token: 0x04000733 RID: 1843
		internal const int WS_POPUPWINDOW = -2138570752;

		// Token: 0x04000734 RID: 1844
		internal const int WS_CHILDWINDOW = 1073741824;

		// Token: 0x04000735 RID: 1845
		internal const int WS_EX_DLGMODALFRAME = 1;

		// Token: 0x04000736 RID: 1846
		internal const int WS_EX_NOPARENTNOTIFY = 4;

		// Token: 0x04000737 RID: 1847
		internal const int WS_EX_TOPMOST = 8;

		// Token: 0x04000738 RID: 1848
		internal const int WS_EX_ACCEPTFILES = 16;

		// Token: 0x04000739 RID: 1849
		internal const int WS_EX_TRANSPARENT = 32;

		// Token: 0x0400073A RID: 1850
		internal const int WS_EX_MDICHILD = 64;

		// Token: 0x0400073B RID: 1851
		internal const int WS_EX_TOOLWINDOW = 128;

		// Token: 0x0400073C RID: 1852
		internal const int WS_EX_WINDOWEDGE = 256;

		// Token: 0x0400073D RID: 1853
		internal const int WS_EX_CLIENTEDGE = 512;

		// Token: 0x0400073E RID: 1854
		internal const int WS_EX_CONTEXTHELP = 1024;

		// Token: 0x0400073F RID: 1855
		internal const int WS_EX_RIGHT = 4096;

		// Token: 0x04000740 RID: 1856
		internal const int WS_EX_LEFT = 0;

		// Token: 0x04000741 RID: 1857
		internal const int WS_EX_RTLREADING = 8192;

		// Token: 0x04000742 RID: 1858
		internal const int WS_EX_LTRREADING = 0;

		// Token: 0x04000743 RID: 1859
		internal const int WS_EX_LEFTSCROLLBAR = 16384;

		// Token: 0x04000744 RID: 1860
		internal const int WS_EX_RIGHTSCROLLBAR = 0;

		// Token: 0x04000745 RID: 1861
		internal const int WS_EX_CONTROLPARENT = 65536;

		// Token: 0x04000746 RID: 1862
		internal const int WS_EX_STATICEDGE = 131072;

		// Token: 0x04000747 RID: 1863
		internal const int WS_EX_APPWINDOW = 262144;

		// Token: 0x04000748 RID: 1864
		internal const int WS_EX_OVERLAPPEDWINDOW = 768;

		// Token: 0x04000749 RID: 1865
		internal const int WS_EX_PALETTEWINDOW = 392;

		// Token: 0x0400074A RID: 1866
		internal const int WS_EX_LAYERED = 524288;

		// Token: 0x0400074B RID: 1867
		internal const int WS_EX_NOINHERITLAYOUT = 1048576;

		// Token: 0x0400074C RID: 1868
		internal const int WS_EX_LAYOUTRTL = 4194304;

		// Token: 0x0400074D RID: 1869
		internal const int WS_EX_COMPOSITED = 33554432;

		// Token: 0x0400074E RID: 1870
		internal const int WS_EX_NOACTIVATE = 134217728;

		// Token: 0x0400074F RID: 1871
		internal const int DCX_WINDOW = 1;

		// Token: 0x04000750 RID: 1872
		internal const int DCX_VALIDATE = 2097152;

		// Token: 0x04000751 RID: 1873
		internal const int DCX_PARENTCLIP = 32;

		// Token: 0x04000752 RID: 1874
		internal const int DCX_NORESETATTRS = 4;

		// Token: 0x04000753 RID: 1875
		internal const int DCX_NORECOMPUTE = 1048576;

		// Token: 0x04000754 RID: 1876
		internal const int DCX_LOCKWINDOWUPDATE = 1024;

		// Token: 0x04000755 RID: 1877
		internal const int DCX_INTERSECTUPDATE = 512;

		// Token: 0x04000756 RID: 1878
		internal const int DCX_INTERSECTRGN = 128;

		// Token: 0x04000757 RID: 1879
		internal const int DCX_EXCLUDEUPDATE = 256;

		// Token: 0x04000758 RID: 1880
		internal const int DCX_EXCLUDERGN = 64;

		// Token: 0x04000759 RID: 1881
		internal const int DCX_CLIPSIBLINGS = 16;

		// Token: 0x0400075A RID: 1882
		internal const int DCX_CLIPCHILDREN = 8;

		// Token: 0x0400075B RID: 1883
		internal const int DCX_CACHE = 2;

		// Token: 0x0400075C RID: 1884
		private const int PtrSizeOn32Bit = 4;

		// Token: 0x0400075D RID: 1885
		private const int PtrSizeOn64Bit = 8;

		// Token: 0x0400075E RID: 1886
		internal const int ICON_SMALL2 = 2;

		// Token: 0x0400075F RID: 1887
		internal const int WM_GETICON = 127;

		// Token: 0x04000760 RID: 1888
		internal const int GCL_HICONSM = -34;

		// Token: 0x04000761 RID: 1889
		internal const int IDI_APPLICATION = 32512;

		// Token: 0x04000762 RID: 1890
		internal const int IMAGE_ICON = 1;

		// Token: 0x04000763 RID: 1891
		internal const uint LR_SHARED = 32768U;

		// Token: 0x04000764 RID: 1892
		internal const int WPF_ASYNCWINDOWPLACEMENT = 4;

		// Token: 0x04000765 RID: 1893
		internal const int WPF_RESTORETOMAXIMIZED = 2;

		// Token: 0x04000766 RID: 1894
		internal const int WPF_SETMINPOSITION = 1;

		// Token: 0x04000767 RID: 1895
		internal const int SW_OTHERUNZOOM = 4;

		// Token: 0x04000768 RID: 1896
		internal const int SW_OTHERZOOM = 2;

		// Token: 0x04000769 RID: 1897
		internal const int SW_PARENTCLOSING = 1;

		// Token: 0x0400076A RID: 1898
		internal const int SW_PARENTOPENING = 3;

		// Token: 0x0400076B RID: 1899
		internal const uint TPM_CENTERALIGN = 4U;

		// Token: 0x0400076C RID: 1900
		internal const uint TPM_LEFTALIGN = 0U;

		// Token: 0x0400076D RID: 1901
		internal const uint TPM_RIGHTALIGN = 8U;

		// Token: 0x0400076E RID: 1902
		internal const uint TPM_BOTTOMALIGN = 32U;

		// Token: 0x0400076F RID: 1903
		internal const uint TPM_TOPALIGN = 0U;

		// Token: 0x04000770 RID: 1904
		internal const uint TPM_VCENTERALIGN = 16U;

		// Token: 0x04000771 RID: 1905
		internal const uint TPM_NONOTIFY = 128U;

		// Token: 0x04000772 RID: 1906
		internal const uint TPM_RETURNCMD = 256U;

		// Token: 0x04000773 RID: 1907
		internal const uint TPM_LEFTBUTTON = 0U;

		// Token: 0x04000774 RID: 1908
		internal const uint TPM_RIGHTBUTTON = 2U;

		// Token: 0x04000775 RID: 1909
		internal const long MOUSEEVENTF_FROMTOUCH = 4283520768L;

		// Token: 0x04000776 RID: 1910
		internal const int GA_PARENT = 1;

		// Token: 0x04000777 RID: 1911
		internal const int GA_ROOT = 2;

		// Token: 0x04000778 RID: 1912
		internal const int GA_ROOTOWNER = 3;

		// Token: 0x04000779 RID: 1913
		private static bool _securityException;

		// Token: 0x0400077A RID: 1914
		private static bool hasSecurityExceptionBeenThrown = false;

		// Token: 0x0400077B RID: 1915
		internal static readonly bool AreThemesSupported = false;

		// Token: 0x0400077C RID: 1916
		internal static readonly global::System.IntPtr HWND_TOP = new global::System.IntPtr(0);

		// Token: 0x0400077D RID: 1917
		internal static readonly global::System.IntPtr HWND_BOTTOM = new global::System.IntPtr(1);

		// Token: 0x0400077E RID: 1918
		internal static readonly global::System.IntPtr HWND_TOPMOST = new global::System.IntPtr(-1);

		// Token: 0x0400077F RID: 1919
		internal static readonly global::System.IntPtr HWND_NOTOPMOST = new global::System.IntPtr(-2);

		// Token: 0x04000780 RID: 1920
		private static bool _unsafeCaretBlinkTimeDoesntWork;

		// Token: 0x04000781 RID: 1921
		private static bool _systemInformationCaretBlinkTimeDoesntWork;

		// Token: 0x04000782 RID: 1922
		private static bool _unsafeDoubleClickTimeDoesntWork;

		// Token: 0x04000783 RID: 1923
		private static bool _systemInformationDoubleClickTimeDoesntWork;

		// Token: 0x04000784 RID: 1924
		private static bool _unsafeDoubleClickSizeDoesntWork;

		// Token: 0x04000785 RID: 1925
		private static bool _systemInformationDoubleClickSizeDoesntWork;

		// Token: 0x04000786 RID: 1926
		private static bool _unsafeDragSizeDoesntWork;

		// Token: 0x04000787 RID: 1927
		private static bool _systemInformationDragSizeDoesntWork;

		// Token: 0x0200019A RID: 410
		internal struct MARGINS
		{
			// Token: 0x06000E4A RID: 3658 RVA: 0x0002DE23 File Offset: 0x0002C023
			public MARGINS(int left, int right, int top, int bottom)
			{
				this.Left = left;
				this.Right = right;
				this.Top = top;
				this.Bottom = bottom;
			}

			// Token: 0x04000788 RID: 1928
			public int Left;

			// Token: 0x04000789 RID: 1929
			public int Right;

			// Token: 0x0400078A RID: 1930
			public int Top;

			// Token: 0x0400078B RID: 1931
			public int Bottom;
		}

		// Token: 0x0200019B RID: 411
		internal struct MINMAXINFO
		{
			// Token: 0x0400078C RID: 1932
			public global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT ptReserved;

			// Token: 0x0400078D RID: 1933
			public global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT ptMaxSize;

			// Token: 0x0400078E RID: 1934
			public global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT ptMaxPosition;

			// Token: 0x0400078F RID: 1935
			public global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT ptMinTrackSize;

			// Token: 0x04000790 RID: 1936
			public global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT ptMaxTrackSize;
		}

		// Token: 0x0200019C RID: 412
		public struct MONITORINFO
		{
			// Token: 0x04000791 RID: 1937
			public uint cbSize;

			// Token: 0x04000792 RID: 1938
			public global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT rcMonitor;

			// Token: 0x04000793 RID: 1939
			public global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT rcWork;

			// Token: 0x04000794 RID: 1940
			public uint dwFlags;
		}

		// Token: 0x0200019D RID: 413
		[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = global::System.Runtime.InteropServices.CharSet.Auto, Pack = 4)]
		internal class MONITIORINFOEX
		{
			// Token: 0x06000E4B RID: 3659 RVA: 0x0002DE44 File Offset: 0x0002C044
			internal MONITIORINFOEX()
			{
				this._size = global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Infragistics.Windows.Helpers.NativeWindowMethods.MONITIORINFOEX));
				this._rcMonitor = default(global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT);
				this._rcWork = default(global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT);
				this._device = new char[32];
			}

			// Token: 0x04000795 RID: 1941
			internal int _size;

			// Token: 0x04000796 RID: 1942
			internal global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT _rcMonitor;

			// Token: 0x04000797 RID: 1943
			internal global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT _rcWork;

			// Token: 0x04000798 RID: 1944
			internal int _flags;

			// Token: 0x04000799 RID: 1945
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 32)]
			internal char[] _device;
		}

		// Token: 0x0200019E RID: 414
		internal struct NCCALCSIZE_PARAMS
		{
			// Token: 0x0400079A RID: 1946
			internal global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT rectProposed;

			// Token: 0x0400079B RID: 1947
			internal global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT rectBeforeMove;

			// Token: 0x0400079C RID: 1948
			internal global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT rectClientBeforeMove;

			// Token: 0x0400079D RID: 1949
			internal global::System.IntPtr ptrWindowPos;
		}

		// Token: 0x0200019F RID: 415
		internal struct POINT : global::System.IEquatable<global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT>
		{
			// Token: 0x06000E4C RID: 3660 RVA: 0x0002DE91 File Offset: 0x0002C091
			internal POINT(int x, int y)
			{
				this.X = x;
				this.Y = y;
			}

			// Token: 0x1700029E RID: 670
			// (get) Token: 0x06000E4D RID: 3661 RVA: 0x0002DEA1 File Offset: 0x0002C0A1
			internal global::System.Windows.Point Point
			{
				get
				{
					return new global::System.Windows.Point((double)this.X, (double)this.Y);
				}
			}

			// Token: 0x06000E4E RID: 3662 RVA: 0x0002DEB6 File Offset: 0x0002C0B6
			public bool Equals(global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT other)
			{
				return this.X == other.X && this.Y == other.Y;
			}

			// Token: 0x0400079E RID: 1950
			internal int X;

			// Token: 0x0400079F RID: 1951
			internal int Y;
		}

		// Token: 0x020001A0 RID: 416
		internal struct RECT
		{
			// Token: 0x06000E4F RID: 3663 RVA: 0x0002DED8 File Offset: 0x0002C0D8
			internal RECT(int left, int top, int right, int bottom)
			{
				this.left = left;
				this.top = top;
				this.right = right;
				this.bottom = bottom;
			}

			// Token: 0x1700029F RID: 671
			// (get) Token: 0x06000E50 RID: 3664 RVA: 0x0002DEF7 File Offset: 0x0002C0F7
			internal global::System.Drawing.Rectangle Rect
			{
				get
				{
					return global::System.Drawing.Rectangle.FromLTRB(this.left, this.top, this.right, this.bottom);
				}
			}

			// Token: 0x06000E51 RID: 3665 RVA: 0x0002DF18 File Offset: 0x0002C118
			internal static global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT Intersect(global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT rect1, global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT rect2)
			{
				global::System.Drawing.Rectangle rectangle = global::System.Drawing.Rectangle.Intersect(rect1.Rect, rect2.Rect);
				return new global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT(rectangle.X, rectangle.Y, rectangle.Right, rectangle.Bottom);
			}

			// Token: 0x170002A0 RID: 672
			// (get) Token: 0x06000E52 RID: 3666 RVA: 0x0002DF5A File Offset: 0x0002C15A
			public int Height
			{
				get
				{
					return this.bottom - this.top;
				}
			}

			// Token: 0x170002A1 RID: 673
			// (get) Token: 0x06000E53 RID: 3667 RVA: 0x0002DF69 File Offset: 0x0002C169
			public int Width
			{
				get
				{
					return this.right - this.left;
				}
			}

			// Token: 0x06000E54 RID: 3668 RVA: 0x0002DF78 File Offset: 0x0002C178
			public static global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT FromLTRB(global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT leftTop, global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT rightBottom)
			{
				return new global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT(leftTop.X, leftTop.Y, rightBottom.X, rightBottom.Y);
			}

			// Token: 0x06000E55 RID: 3669 RVA: 0x0002DF9B File Offset: 0x0002C19B
			public global::System.Windows.Rect ToRect()
			{
				return new global::System.Windows.Rect((double)this.left, (double)this.top, (double)global::System.Math.Abs(this.right - this.left), (double)global::System.Math.Abs(this.bottom - this.top));
			}

			// Token: 0x040007A0 RID: 1952
			internal int left;

			// Token: 0x040007A1 RID: 1953
			internal int top;

			// Token: 0x040007A2 RID: 1954
			internal int right;

			// Token: 0x040007A3 RID: 1955
			internal int bottom;
		}

		// Token: 0x020001A1 RID: 417
		internal struct SIZE
		{
			// Token: 0x06000E56 RID: 3670 RVA: 0x0002DFD6 File Offset: 0x0002C1D6
			public SIZE(int width, int height)
			{
				this.width = width;
				this.height = height;
			}

			// Token: 0x040007A4 RID: 1956
			public int width;

			// Token: 0x040007A5 RID: 1957
			public int height;
		}

		// Token: 0x020001A2 RID: 418
		internal struct STYLESTRUCT
		{
			// Token: 0x040007A6 RID: 1958
			public int styleOld;

			// Token: 0x040007A7 RID: 1959
			public int styleNew;
		}

		// Token: 0x020001A3 RID: 419
		internal struct TITLEBARINFOEX
		{
			// Token: 0x040007A8 RID: 1960
			public const int CCHILDREN_TITLEBAR = 5;

			// Token: 0x040007A9 RID: 1961
			public uint cbSize;

			// Token: 0x040007AA RID: 1962
			public global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT rcTitleBar;

			// Token: 0x040007AB RID: 1963
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 6)]
			public uint[] rgstate;

			// Token: 0x040007AC RID: 1964
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 6)]
			public global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT[] rgrect;
		}

		// Token: 0x020001A4 RID: 420
		internal struct WINDOWINFO
		{
			// Token: 0x040007AD RID: 1965
			public int cbSize;

			// Token: 0x040007AE RID: 1966
			public global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT rcWindow;

			// Token: 0x040007AF RID: 1967
			public global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT rcClient;

			// Token: 0x040007B0 RID: 1968
			public uint dwStyle;

			// Token: 0x040007B1 RID: 1969
			public uint dwExStyle;

			// Token: 0x040007B2 RID: 1970
			public uint dwWindowStatus;

			// Token: 0x040007B3 RID: 1971
			public uint cxWindowBorders;

			// Token: 0x040007B4 RID: 1972
			public uint cyWindowBorders;

			// Token: 0x040007B5 RID: 1973
			public ushort atomWindowType;

			// Token: 0x040007B6 RID: 1974
			public ushort wCreatorVersion;
		}

		// Token: 0x020001A5 RID: 421
		public struct WINDOWPLACEMENT
		{
			// Token: 0x040007B7 RID: 1975
			public int length;

			// Token: 0x040007B8 RID: 1976
			public int flags;

			// Token: 0x040007B9 RID: 1977
			public int showCmd;

			// Token: 0x040007BA RID: 1978
			public global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT ptMinPosition;

			// Token: 0x040007BB RID: 1979
			public global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT ptMaxPosition;

			// Token: 0x040007BC RID: 1980
			public global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT rcNormalPosition;
		}

		// Token: 0x020001A6 RID: 422
		internal struct WINDOWPOS
		{
			// Token: 0x040007BD RID: 1981
			internal global::System.IntPtr hwnd;

			// Token: 0x040007BE RID: 1982
			internal global::System.IntPtr hWndInsertAfter;

			// Token: 0x040007BF RID: 1983
			internal int x;

			// Token: 0x040007C0 RID: 1984
			internal int y;

			// Token: 0x040007C1 RID: 1985
			internal int cx;

			// Token: 0x040007C2 RID: 1986
			internal int cy;

			// Token: 0x040007C3 RID: 1987
			internal int flags;
		}

		// Token: 0x020001A7 RID: 423
		internal enum HitTestResults
		{
			// Token: 0x040007C5 RID: 1989
			HTERROR = -2,
			// Token: 0x040007C6 RID: 1990
			HTTRANSPARENT,
			// Token: 0x040007C7 RID: 1991
			HTNOWHERE,
			// Token: 0x040007C8 RID: 1992
			HTCLIENT,
			// Token: 0x040007C9 RID: 1993
			HTCAPTION,
			// Token: 0x040007CA RID: 1994
			HTSYSMENU,
			// Token: 0x040007CB RID: 1995
			HTGROWBOX,
			// Token: 0x040007CC RID: 1996
			HTSIZE = 4,
			// Token: 0x040007CD RID: 1997
			HTMENU,
			// Token: 0x040007CE RID: 1998
			HTHSCROLL,
			// Token: 0x040007CF RID: 1999
			HTVSCROLL,
			// Token: 0x040007D0 RID: 2000
			HTMINBUTTON,
			// Token: 0x040007D1 RID: 2001
			HTMAXBUTTON,
			// Token: 0x040007D2 RID: 2002
			HTLEFT,
			// Token: 0x040007D3 RID: 2003
			HTRIGHT,
			// Token: 0x040007D4 RID: 2004
			HTTOP,
			// Token: 0x040007D5 RID: 2005
			HTTOPLEFT,
			// Token: 0x040007D6 RID: 2006
			HTTOPRIGHT,
			// Token: 0x040007D7 RID: 2007
			HTBOTTOM,
			// Token: 0x040007D8 RID: 2008
			HTBOTTOMLEFT,
			// Token: 0x040007D9 RID: 2009
			HTBOTTOMRIGHT,
			// Token: 0x040007DA RID: 2010
			HTBORDER,
			// Token: 0x040007DB RID: 2011
			HTREDUCE = 8,
			// Token: 0x040007DC RID: 2012
			HTZOOM,
			// Token: 0x040007DD RID: 2013
			HTSIZEFIRST,
			// Token: 0x040007DE RID: 2014
			HTSIZELAST = 17,
			// Token: 0x040007DF RID: 2015
			HTOBJECT = 19,
			// Token: 0x040007E0 RID: 2016
			HTCLOSE,
			// Token: 0x040007E1 RID: 2017
			HTHELP
		}

		// Token: 0x020001A8 RID: 424
		internal enum RegionCombineMode
		{
			// Token: 0x040007E3 RID: 2019
			RGN_AND = 1,
			// Token: 0x040007E4 RID: 2020
			RGN_OR,
			// Token: 0x040007E5 RID: 2021
			RGN_XOR,
			// Token: 0x040007E6 RID: 2022
			RGN_DIFF,
			// Token: 0x040007E7 RID: 2023
			RGN_COPY,
			// Token: 0x040007E8 RID: 2024
			RGN_MIN = 1,
			// Token: 0x040007E9 RID: 2025
			RGN_MAX = 5
		}

		// Token: 0x020001A9 RID: 425
		// (Invoke) Token: 0x06000E58 RID: 3672
		public delegate bool EnumWindowsProc(global::System.IntPtr hWnd, global::System.IntPtr lParam);

		// Token: 0x020001AA RID: 426
		// (Invoke) Token: 0x06000E5C RID: 3676
		public delegate global::System.IntPtr HookProc(int ncode, global::System.IntPtr wParam, global::System.IntPtr lParam);

		// Token: 0x020001AB RID: 427
		private class ScreenHelper
		{
			// Token: 0x06000E5F RID: 3679 RVA: 0x0002DFE8 File Offset: 0x0002C1E8
			private ScreenHelper(object screenObject)
			{
				this._screenObject = screenObject;
				if (screenObject == null)
				{
					this._bounds = new global::System.Windows.Rect((double)global::Infragistics.Windows.Utilities.ConvertFromLogicalPixels(global::System.Windows.SystemParameters.VirtualScreenLeft), (double)global::Infragistics.Windows.Utilities.ConvertFromLogicalPixels(global::System.Windows.SystemParameters.VirtualScreenTop), (double)global::Infragistics.Windows.Utilities.ConvertFromLogicalPixels(global::System.Windows.SystemParameters.VirtualScreenWidth), (double)global::Infragistics.Windows.Utilities.ConvertFromLogicalPixels(global::System.Windows.SystemParameters.VirtualScreenHeight));
					this._workingArea = this._bounds;
					return;
				}
				if (!(screenObject is global::System.IntPtr))
				{
					this._bounds = this.GetBoundsFallback(out this._workingArea);
					return;
				}
				global::Infragistics.Windows.Helpers.NativeWindowMethods.MONITIORINFOEX monitiorinfoex = new global::Infragistics.Windows.Helpers.NativeWindowMethods.MONITIORINFOEX();
				global::Infragistics.Windows.Helpers.NativeWindowMethods.GetMonitorInfo(new global::System.Runtime.InteropServices.HandleRef(null, (global::System.IntPtr)screenObject), monitiorinfoex);
				double virtualScreenWidth = global::Infragistics.Windows.Helpers.NativeWindowMethods.VirtualScreenWidth;
				global::Infragistics.Windows.Helpers.NativeWindowMethods.GetSystemMetrics(78);
				double num = 1.0;
				global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT rcMonitor = monitiorinfoex._rcMonitor;
				this._bounds = new global::System.Windows.Rect((double)rcMonitor.left * num, (double)rcMonitor.top * num, (double)rcMonitor.Width * num, (double)rcMonitor.Height * num);
				global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT rcWork = monitiorinfoex._rcWork;
				this._workingArea = new global::System.Windows.Rect((double)rcWork.left * num, (double)rcWork.top * num, (double)rcWork.Width * num, (double)rcWork.Height * num);
			}

			// Token: 0x170002A2 RID: 674
			// (get) Token: 0x06000E60 RID: 3680 RVA: 0x0002E109 File Offset: 0x0002C309
			internal global::System.Windows.Rect Bounds
			{
				get
				{
					return this._bounds;
				}
			}

			// Token: 0x170002A3 RID: 675
			// (get) Token: 0x06000E61 RID: 3681 RVA: 0x0002E111 File Offset: 0x0002C311
			internal global::System.Windows.Rect WorkingArea
			{
				get
				{
					return this._workingArea;
				}
			}

			// Token: 0x06000E62 RID: 3682 RVA: 0x0002E11C File Offset: 0x0002C31C
			internal static global::Infragistics.Windows.Helpers.NativeWindowMethods.ScreenHelper FromPoint(global::System.Windows.Point point)
			{
				if (global::Infragistics.Windows.Helpers.NativeWindowMethods.hasSecurityExceptionBeenThrown)
				{
					return global::Infragistics.Windows.Helpers.NativeWindowMethods.ScreenHelper.FromPointFallback(point);
				}
				global::Infragistics.Windows.Helpers.NativeWindowMethods.ScreenHelper result;
				try
				{
					if (global::Infragistics.Windows.Helpers.NativeWindowMethods.GetSystemMetrics(80) == 0)
					{
						result = new global::Infragistics.Windows.Helpers.NativeWindowMethods.ScreenHelper(null);
					}
					else
					{
						global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT pt = new global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT((int)point.X, (int)point.Y);
						result = new global::Infragistics.Windows.Helpers.NativeWindowMethods.ScreenHelper(global::Infragistics.Windows.Helpers.NativeWindowMethods.MonitorFromPoint(pt, 2));
					}
				}
				catch (global::System.Security.SecurityException)
				{
					global::Infragistics.Windows.Helpers.NativeWindowMethods.hasSecurityExceptionBeenThrown = true;
					result = global::Infragistics.Windows.Helpers.NativeWindowMethods.ScreenHelper.FromPointFallback(point);
				}
				return result;
			}

			// Token: 0x06000E63 RID: 3683 RVA: 0x0002E198 File Offset: 0x0002C398
			internal static global::Infragistics.Windows.Helpers.NativeWindowMethods.ScreenHelper FromRect(global::System.Windows.Rect rect)
			{
				rect = global::Infragistics.Windows.Utilities.RectFromPoints(rect.TopLeft, rect.BottomRight);
				if (!global::Infragistics.Windows.Helpers.NativeWindowMethods.hasSecurityExceptionBeenThrown)
				{
					try
					{
						if (global::Infragistics.Windows.Helpers.NativeWindowMethods.GetSystemMetrics(80) == 0)
						{
							return new global::Infragistics.Windows.Helpers.NativeWindowMethods.ScreenHelper(null);
						}
						global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT rect2 = new global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT((int)rect.Left, (int)rect.Top, (int)rect.Right, (int)rect.Bottom);
						return new global::Infragistics.Windows.Helpers.NativeWindowMethods.ScreenHelper(global::Infragistics.Windows.Helpers.NativeWindowMethods.MonitorFromRect(ref rect2, 2));
					}
					catch (global::System.Security.SecurityException)
					{
						global::Infragistics.Windows.Helpers.NativeWindowMethods.hasSecurityExceptionBeenThrown = true;
					}
				}
				return global::Infragistics.Windows.Helpers.NativeWindowMethods.ScreenHelper.FromRectFallback(rect);
			}

			// Token: 0x06000E64 RID: 3684 RVA: 0x0002E238 File Offset: 0x0002C438
			[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			private static global::Infragistics.Windows.Helpers.NativeWindowMethods.ScreenHelper FromPointFallback(global::System.Windows.Point point)
			{
				return new global::Infragistics.Windows.Helpers.NativeWindowMethods.ScreenHelper(global::System.Windows.Forms.Screen.FromPoint(new global::System.Drawing.Point((int)point.X, (int)point.Y)));
			}

			// Token: 0x06000E65 RID: 3685 RVA: 0x0002E25C File Offset: 0x0002C45C
			[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			private static global::Infragistics.Windows.Helpers.NativeWindowMethods.ScreenHelper FromRectFallback(global::System.Windows.Rect rect)
			{
				global::System.Drawing.Rectangle rect2 = global::System.Drawing.Rectangle.FromLTRB((int)rect.Left, (int)rect.Top, (int)rect.Right, (int)rect.Bottom);
				return new global::Infragistics.Windows.Helpers.NativeWindowMethods.ScreenHelper(global::System.Windows.Forms.Screen.FromRectangle(rect2));
			}

			// Token: 0x06000E66 RID: 3686 RVA: 0x0002E29C File Offset: 0x0002C49C
			[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			private global::System.Windows.Rect GetBoundsFallback(out global::System.Windows.Rect workingRect)
			{
				global::System.Windows.Forms.Screen screen = this._screenObject as global::System.Windows.Forms.Screen;
				global::System.Drawing.Rectangle bounds = screen.Bounds;
				global::System.Drawing.Rectangle workingArea = screen.WorkingArea;
				workingRect = new global::System.Windows.Rect((double)workingArea.Left, (double)workingArea.Top, (double)workingArea.Width, (double)workingArea.Height);
				return new global::System.Windows.Rect((double)bounds.Left, (double)bounds.Top, (double)bounds.Width, (double)bounds.Height);
			}

			// Token: 0x040007EA RID: 2026
			private object _screenObject;

			// Token: 0x040007EB RID: 2027
			private global::System.Windows.Rect _bounds;

			// Token: 0x040007EC RID: 2028
			private global::System.Windows.Rect _workingArea;
		}
	}
}
