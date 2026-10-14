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
	// Token: 0x02000177 RID: 375
	[global::System.Runtime.InteropServices.ComVisible(false)]
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	internal static class NativeWindowMethods
	{
		// Token: 0x06000C98 RID: 3224 RVA: 0x00028BFE File Offset: 0x00026DFE
		internal static bool AdjustWindowRectExApi(ref global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT lpRect, int dwStyle, bool bMenu, int dwExStyle)
		{
			return global::Infragistics.Windows.Helpers.NativeWindowMethods.AdjustWindowRectEx(ref lpRect, dwStyle, bMenu, dwExStyle);
		}

		// Token: 0x06000C99 RID: 3225
		[global::System.Runtime.InteropServices.DllImport("user32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, ExactSpelling = true)]
		private static extern bool AdjustWindowRectEx(ref global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT lpRect, int dwStyle, bool bMenu, int dwExStyle);

		// Token: 0x06000C9A RID: 3226
		[global::System.Runtime.InteropServices.DllImport("user32", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, ExactSpelling = true)]
		public static extern global::System.IntPtr CallNextHookEx(global::System.IntPtr hook, int nCode, global::System.IntPtr wParam, global::System.IntPtr lParam);

		// Token: 0x06000C9B RID: 3227
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		internal static extern global::System.IntPtr DefWindowProc(global::System.IntPtr hWnd, int uMsg, global::System.IntPtr wParam, global::System.IntPtr lParam);

		// Token: 0x06000C9C RID: 3228
		[global::System.Runtime.InteropServices.DllImport("dwmapi.dll")]
		private static extern int DwmIsCompositionEnabled(out bool enabled);

		// Token: 0x06000C9D RID: 3229
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		internal static extern bool EnableMenuItem(global::System.IntPtr hMenu, int uIDEnableItem, int uEnable);

		// Token: 0x06000C9E RID: 3230
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Bool)]
		internal static extern bool EnumChildWindows(global::System.IntPtr hwndParent, global::Infragistics.Windows.Helpers.NativeWindowMethods.EnumWindowsProc lpEnumFunc, global::System.IntPtr lParam);

		// Token: 0x06000C9F RID: 3231
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Bool)]
		internal static extern bool EnumThreadWindows(int dwThreadId, global::Infragistics.Windows.Helpers.NativeWindowMethods.EnumWindowsProc lpfn, global::System.IntPtr lParam);

		// Token: 0x06000CA0 RID: 3232 RVA: 0x00028C09 File Offset: 0x00026E09
		internal static global::System.IntPtr GetAncestorApi(global::System.IntPtr hwnd, int gaFlags)
		{
			return global::Infragistics.Windows.Helpers.NativeWindowMethods.GetAncestor(hwnd, gaFlags);
		}

		// Token: 0x06000CA1 RID: 3233
		[global::System.Runtime.InteropServices.DllImport("user32.dll", ExactSpelling = true)]
		internal static extern global::System.IntPtr GetAncestor(global::System.IntPtr hwnd, int gaFlags);

		// Token: 0x06000CA2 RID: 3234
		[global::System.Runtime.InteropServices.DllImport("user32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto)]
		private static extern int GetCaretBlinkTime();

		// Token: 0x06000CA3 RID: 3235
		[global::System.Runtime.InteropServices.DllImport("user32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, SetLastError = true)]
		internal static extern int GetClipboardFormatName(int format, global::System.Text.StringBuilder lpString, int cchMax);

		// Token: 0x06000CA4 RID: 3236 RVA: 0x00028C14 File Offset: 0x00026E14
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

		// Token: 0x06000CA5 RID: 3237 RVA: 0x00028C44 File Offset: 0x00026E44
		private static int GetCurrentThreadIdApiUnsafe()
		{
			return global::Infragistics.Windows.Helpers.NativeWindowMethods.GetCurrentThreadId();
		}

		// Token: 0x06000CA6 RID: 3238
		[global::System.Runtime.InteropServices.DllImport("kernel32")]
		private static extern int GetCurrentThreadId();

		// Token: 0x06000CA7 RID: 3239
		[global::System.Runtime.InteropServices.DllImport("user32")]
		internal static extern int GetCursorPos(ref global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT lpPoint);

		// Token: 0x06000CA8 RID: 3240
		[global::System.Runtime.InteropServices.DllImport("user32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto)]
		private static extern int GetDoubleClickTime();

		// Token: 0x06000CA9 RID: 3241
		[global::System.Runtime.InteropServices.DllImport("user32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, ExactSpelling = true)]
		public static extern global::System.IntPtr GetFocus();

		// Token: 0x06000CAA RID: 3242
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		internal static extern global::System.IntPtr GetMessageExtraInfo();

		// Token: 0x06000CAB RID: 3243
		[global::System.Runtime.InteropServices.DllImport("user32")]
		internal static extern int GetMessagePos();

		// Token: 0x06000CAC RID: 3244
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		internal static extern int GetMessageTime();

		// Token: 0x06000CAD RID: 3245
		[global::System.Runtime.InteropServices.DllImport("user32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto)]
		private static extern bool GetMonitorInfo(global::System.Runtime.InteropServices.HandleRef handle, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] global::Infragistics.Windows.Helpers.NativeWindowMethods.MONITIORINFOEX monitorInfo);

		// Token: 0x06000CAE RID: 3246
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		internal static extern bool GetMonitorInfo(global::System.IntPtr hMonitor, out global::Infragistics.Windows.Helpers.NativeWindowMethods.MONITORINFO lpmi);

		// Token: 0x06000CAF RID: 3247
		[global::System.Runtime.InteropServices.DllImport("user32.dll", ExactSpelling = true)]
		internal static extern global::System.IntPtr GetParent(global::System.IntPtr hwnd);

		// Token: 0x06000CB0 RID: 3248 RVA: 0x00028C4B File Offset: 0x00026E4B
		internal static global::System.IntPtr GetSystemMenuApi(global::System.IntPtr hWnd, bool revert)
		{
			return global::Infragistics.Windows.Helpers.NativeWindowMethods.GetSystemMenu(hWnd, revert);
		}

		// Token: 0x06000CB1 RID: 3249
		[global::System.Runtime.InteropServices.DllImport("user32", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, ExactSpelling = true)]
		private static extern global::System.IntPtr GetSystemMenu(global::System.IntPtr hWnd, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Bool)] bool revert);

		// Token: 0x06000CB2 RID: 3250
		[global::System.Runtime.InteropServices.DllImport("user32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, ExactSpelling = true)]
		private static extern int GetSystemMetrics(int index);

		// Token: 0x06000CB3 RID: 3251
		[global::System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
		internal static extern global::System.IntPtr GetWindow(global::System.IntPtr hWnd, uint uCmd);

		// Token: 0x06000CB4 RID: 3252
		[global::System.Runtime.InteropServices.DllImport("user32")]
		private static extern bool GetWindowInfo(global::System.IntPtr hwnd, ref global::Infragistics.Windows.Helpers.NativeWindowMethods.WINDOWINFO pwi);

		// Token: 0x06000CB5 RID: 3253
		[global::System.Runtime.InteropServices.DllImport("user32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, EntryPoint = "GetWindowLong")]
		public static extern global::System.IntPtr GetWindowLong32(global::System.IntPtr hWnd, int nIndex);

		// Token: 0x06000CB6 RID: 3254
		[global::System.Runtime.InteropServices.DllImport("user32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, EntryPoint = "GetWindowLongPtr")]
		public static extern global::System.IntPtr GetWindowLongPtr64(global::System.IntPtr hWnd, int nIndex);

		// Token: 0x06000CB7 RID: 3255 RVA: 0x00028C54 File Offset: 0x00026E54
		internal static global::System.IntPtr GetWindowLong(global::System.IntPtr hwnd, int nIndex)
		{
			if (global::System.IntPtr.Size == 4)
			{
				return global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowLong32(hwnd, nIndex);
			}
			return global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowLongPtr64(hwnd, nIndex);
		}

		// Token: 0x06000CB8 RID: 3256
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Bool)]
		internal static extern bool GetWindowPlacement(global::System.IntPtr hWnd, ref global::Infragistics.Windows.Helpers.NativeWindowMethods.WINDOWPLACEMENT lpwndpl);

		// Token: 0x06000CB9 RID: 3257
		[global::System.Runtime.InteropServices.DllImport("user32")]
		internal static extern int MapWindowPoints(global::System.IntPtr hwndSrc, global::System.IntPtr hwndDest, [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] ref global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT pt, int ptCount);

		// Token: 0x06000CBA RID: 3258
		[global::System.Runtime.InteropServices.DllImport("user32.dll", ExactSpelling = true)]
		internal static extern global::System.IntPtr MonitorFromPoint(global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT pt, int flags);

		// Token: 0x06000CBB RID: 3259
		[global::System.Runtime.InteropServices.DllImport("user32.dll", ExactSpelling = true)]
		internal static extern global::System.IntPtr MonitorFromRect([global::System.Runtime.InteropServices.In] ref global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT rect, int flags);

		// Token: 0x06000CBC RID: 3260
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		internal static extern global::System.IntPtr MonitorFromWindow(global::System.IntPtr hwnd, uint dwFlags);

		// Token: 0x06000CBD RID: 3261
		[global::System.Runtime.InteropServices.DllImport("user32", CharSet = global::System.Runtime.InteropServices.CharSet.Auto)]
		internal static extern int PostMessage(global::System.IntPtr hWnd, int msg, global::System.IntPtr wparam, global::System.IntPtr lparam);

		// Token: 0x06000CBE RID: 3262 RVA: 0x00028C6D File Offset: 0x00026E6D
		internal static global::System.IntPtr SendMessageApi(global::System.IntPtr hWnd, int msg, global::System.IntPtr wparam, global::System.IntPtr lparam)
		{
			return global::Infragistics.Windows.Helpers.NativeWindowMethods.SendMessage(hWnd, msg, wparam, lparam);
		}

		// Token: 0x06000CBF RID: 3263
		[global::System.Runtime.InteropServices.DllImport("user32", CharSet = global::System.Runtime.InteropServices.CharSet.Auto)]
		private static extern global::System.IntPtr SendMessage(global::System.IntPtr hWnd, int msg, global::System.IntPtr wparam, global::System.IntPtr lparam);

		// Token: 0x06000CC0 RID: 3264
		[global::System.Runtime.InteropServices.DllImport("user32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, EntryPoint = "SetWindowLong")]
		private static extern global::System.IntPtr SetWindowLong32(global::System.IntPtr hWnd, int nIndex, global::System.IntPtr dwNewLong);

		// Token: 0x06000CC1 RID: 3265
		[global::System.Runtime.InteropServices.DllImport("user32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, EntryPoint = "SetWindowLongPtr")]
		private static extern global::System.IntPtr SetWindowLongPtr64(global::System.IntPtr hWnd, int nIndex, global::System.IntPtr dwNewLong);

		// Token: 0x06000CC2 RID: 3266 RVA: 0x00028C78 File Offset: 0x00026E78
		internal static global::System.IntPtr SetWindowLong(global::System.IntPtr hwnd, int nIndex, global::System.IntPtr dwNewLong)
		{
			if (global::System.IntPtr.Size == 4)
			{
				return global::Infragistics.Windows.Helpers.NativeWindowMethods.SetWindowLong32(hwnd, nIndex, dwNewLong);
			}
			return global::Infragistics.Windows.Helpers.NativeWindowMethods.SetWindowLongPtr64(hwnd, nIndex, dwNewLong);
		}

		// Token: 0x06000CC3 RID: 3267
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Bool)]
		internal static extern bool SetWindowPlacement(global::System.IntPtr hWnd, ref global::Infragistics.Windows.Helpers.NativeWindowMethods.WINDOWPLACEMENT lpwndpl);

		// Token: 0x06000CC4 RID: 3268 RVA: 0x00028C93 File Offset: 0x00026E93
		internal static bool SetWindowPosApi(global::System.IntPtr hWnd, global::System.IntPtr hWndInsertAfter, int x, int y, int cx, int cy, int flags)
		{
			return global::Infragistics.Windows.Helpers.NativeWindowMethods.SetWindowPos(hWnd, hWndInsertAfter, x, y, cx, cy, flags);
		}

		// Token: 0x06000CC5 RID: 3269
		[global::System.Runtime.InteropServices.DllImport("user32", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, ExactSpelling = true)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Bool)]
		private static extern bool SetWindowPos(global::System.IntPtr hWnd, global::System.IntPtr hWndInsertAfter, int x, int y, int cx, int cy, int flags);

		// Token: 0x06000CC6 RID: 3270
		[global::System.Runtime.InteropServices.DllImport("user32", CharSet = global::System.Runtime.InteropServices.CharSet.Auto)]
		public static extern global::System.IntPtr SetWindowsHookEx(int id, global::Infragistics.Windows.Helpers.NativeWindowMethods.HookProc hookProc, global::System.IntPtr hmod, int dwThreadId);

		// Token: 0x06000CC7 RID: 3271
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Bool)]
		internal static extern bool ShowWindow(global::System.IntPtr hwnd, int nCmdShow);

		// Token: 0x06000CC8 RID: 3272
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		internal static extern int TrackPopupMenuEx(global::System.IntPtr hmenu, uint fuFlags, int x, int y, global::System.IntPtr hwnd, global::System.IntPtr lptpm);

		// Token: 0x06000CC9 RID: 3273
		[global::System.Runtime.InteropServices.DllImport("user32", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, ExactSpelling = true)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Bool)]
		public static extern bool UnhookWindowsHookEx(global::System.IntPtr hook);

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000CCA RID: 3274 RVA: 0x00028CA4 File Offset: 0x00026EA4
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

		// Token: 0x06000CCB RID: 3275 RVA: 0x00028D04 File Offset: 0x00026F04
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private static int GetSystemInformationCaretBlinkTime()
		{
			return global::System.Windows.Forms.SystemInformation.CaretBlinkTime;
		}

		// Token: 0x06000CCC RID: 3276 RVA: 0x00028D0C File Offset: 0x00026F0C
		private static int UnsafeCaretBlinkTime()
		{
			return global::Infragistics.Windows.Helpers.NativeWindowMethods.GetCaretBlinkTime();
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000CCD RID: 3277 RVA: 0x00028D20 File Offset: 0x00026F20
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

		// Token: 0x06000CCE RID: 3278 RVA: 0x00028D80 File Offset: 0x00026F80
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private static int GetSystemInformationDoubleClickTime()
		{
			return global::System.Windows.Forms.SystemInformation.DoubleClickTime;
		}

		// Token: 0x06000CCF RID: 3279 RVA: 0x00028D87 File Offset: 0x00026F87
		private static int UnsafeDoubleClickTime()
		{
			return global::Infragistics.Windows.Helpers.NativeWindowMethods.GetDoubleClickTime();
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000CD0 RID: 3280 RVA: 0x00028D90 File Offset: 0x00026F90
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

		// Token: 0x06000CD1 RID: 3281 RVA: 0x00028E04 File Offset: 0x00027004
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private static global::System.Windows.Size GetSystemInformationDoubleClickSize()
		{
			global::System.Drawing.Size doubleClickSize = global::System.Windows.Forms.SystemInformation.DoubleClickSize;
			return new global::System.Windows.Size(global::Infragistics.Windows.Helpers.NativeWindowMethods.ConvertToLogicalPixels(doubleClickSize.Width), global::Infragistics.Windows.Helpers.NativeWindowMethods.ConvertToLogicalPixels(doubleClickSize.Height));
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x00028E34 File Offset: 0x00027034
		private static global::System.Windows.Size UnsafeDoubleClickSize()
		{
			return new global::System.Windows.Size((double)global::Infragistics.Windows.Helpers.NativeWindowMethods.GetSystemMetrics(36), (double)global::Infragistics.Windows.Helpers.NativeWindowMethods.GetSystemMetrics(37));
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000CD3 RID: 3283 RVA: 0x00028E4C File Offset: 0x0002704C
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

		// Token: 0x06000CD4 RID: 3284 RVA: 0x00028EC0 File Offset: 0x000270C0
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private static global::System.Windows.Size GetSystemInformationDragSize()
		{
			global::System.Drawing.Size dragSize = global::System.Windows.Forms.SystemInformation.DragSize;
			return new global::System.Windows.Size(global::Infragistics.Windows.Helpers.NativeWindowMethods.ConvertToLogicalPixels(dragSize.Width), global::Infragistics.Windows.Helpers.NativeWindowMethods.ConvertToLogicalPixels(dragSize.Height));
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x00028EF0 File Offset: 0x000270F0
		private static global::System.Windows.Size UnsafeDragSize()
		{
			return new global::System.Windows.Size((double)global::Infragistics.Windows.Helpers.NativeWindowMethods.GetSystemMetrics(68), (double)global::Infragistics.Windows.Helpers.NativeWindowMethods.GetSystemMetrics(69));
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x00028F07 File Offset: 0x00027107
		private static int ConvertToDevicePixels(double logicalValue)
		{
			return global::Infragistics.Windows.Utilities.ConvertFromLogicalPixels(logicalValue);
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x00028F0F File Offset: 0x0002710F
		private static double ConvertToLogicalPixels(int pixelValue)
		{
			return global::Infragistics.Windows.Utilities.ConvertToLogicalPixels(pixelValue);
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000CD8 RID: 3288 RVA: 0x00028F18 File Offset: 0x00027118
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

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000CD9 RID: 3289 RVA: 0x00028F54 File Offset: 0x00027154
		private static global::System.Windows.Size PrimaryMonitorSizeUnsafe
		{
			[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				return new global::System.Windows.Size((double)global::Infragistics.Windows.Helpers.NativeWindowMethods.GetSystemMetrics(0), (double)global::Infragistics.Windows.Helpers.NativeWindowMethods.GetSystemMetrics(1));
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000CDA RID: 3290 RVA: 0x00028F6C File Offset: 0x0002716C
		private static global::System.Windows.Size PrimaryMonitorSizeFallback
		{
			[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				global::System.Drawing.Size primaryMonitorSize = global::System.Windows.Forms.SystemInformation.PrimaryMonitorSize;
				return new global::System.Windows.Size((double)primaryMonitorSize.Width, (double)primaryMonitorSize.Height);
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000CDB RID: 3291 RVA: 0x00028F94 File Offset: 0x00027194
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

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000CDC RID: 3292 RVA: 0x00028FEC File Offset: 0x000271EC
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

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000CDD RID: 3293 RVA: 0x00029054 File Offset: 0x00027254
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

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000CDE RID: 3294 RVA: 0x00029098 File Offset: 0x00027298
		private static double VirtualScreenLeftFallback
		{
			[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				return global::Infragistics.Windows.Helpers.NativeWindowMethods.ConvertToLogicalPixels(global::System.Windows.Forms.SystemInformation.VirtualScreen.Left);
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000CDF RID: 3295 RVA: 0x000290B8 File Offset: 0x000272B8
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

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000CE0 RID: 3296 RVA: 0x000290FC File Offset: 0x000272FC
		private static double VirtualScreenHeightFallback
		{
			[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				return global::Infragistics.Windows.Helpers.NativeWindowMethods.ConvertToLogicalPixels(global::System.Windows.Forms.SystemInformation.VirtualScreen.Height);
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000CE1 RID: 3297 RVA: 0x0002911C File Offset: 0x0002731C
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

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000CE2 RID: 3298 RVA: 0x00029160 File Offset: 0x00027360
		private static double VirtualScreenTopFallback
		{
			[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				return global::Infragistics.Windows.Helpers.NativeWindowMethods.ConvertToLogicalPixels(global::System.Windows.Forms.SystemInformation.VirtualScreen.Top);
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000CE3 RID: 3299 RVA: 0x00029180 File Offset: 0x00027380
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

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000CE4 RID: 3300 RVA: 0x000291C4 File Offset: 0x000273C4
		private static double VirtualScreenWidthFallback
		{
			[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			get
			{
				return global::Infragistics.Windows.Helpers.NativeWindowMethods.ConvertToLogicalPixels(global::System.Windows.Forms.SystemInformation.VirtualScreen.Width);
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000CE5 RID: 3301 RVA: 0x000291E4 File Offset: 0x000273E4
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

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000CE6 RID: 3302 RVA: 0x00029228 File Offset: 0x00027428
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

		// Token: 0x06000CE7 RID: 3303 RVA: 0x00029290 File Offset: 0x00027490
		internal static global::System.IntPtr AddBits(global::System.IntPtr ptr, int bitsToAdd)
		{
			if (global::System.IntPtr.Size == 4)
			{
				return new global::System.IntPtr(ptr.ToInt32() | bitsToAdd);
			}
			return new global::System.IntPtr(ptr.ToInt64() | (long)((ulong)bitsToAdd));
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x000292B8 File Offset: 0x000274B8
		internal static bool AreBitsPresent(global::System.IntPtr ptr, int bits)
		{
			if (global::System.IntPtr.Size == 4)
			{
				return (ptr.ToInt32() & bits) != 0;
			}
			return (ptr.ToInt64() & (long)bits) != 0L;
		}

		// Token: 0x06000CE9 RID: 3305 RVA: 0x000292E3 File Offset: 0x000274E3
		internal static global::System.IntPtr EncodeSize(int width, int height)
		{
			return new global::System.IntPtr(height << 16 | width);
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x000292F0 File Offset: 0x000274F0
		internal static long GetBits(global::System.IntPtr ptr)
		{
			if (global::System.IntPtr.Size == 4)
			{
				return (long)ptr.ToInt32();
			}
			return ptr.ToInt64();
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x0002930C File Offset: 0x0002750C
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

		// Token: 0x06000CEC RID: 3308 RVA: 0x00029348 File Offset: 0x00027548
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private static global::System.Windows.Point GetCursorPosSafe()
		{
			global::System.Drawing.Point position = global::System.Windows.Forms.Cursor.Position;
			return new global::System.Windows.Point((double)position.X, (double)position.Y);
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x00029370 File Offset: 0x00027570
		private static global::System.Windows.Point GetCursorPosUnsafe()
		{
			global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT point = default(global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT);
			global::Infragistics.Windows.Helpers.NativeWindowMethods.GetCursorPos(ref point);
			return point.Point;
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x00029394 File Offset: 0x00027594
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

		// Token: 0x06000CEF RID: 3311 RVA: 0x000293F8 File Offset: 0x000275F8
		internal static global::Infragistics.Windows.Helpers.NativeWindowMethods.SIZE GetNonClientSize(global::System.IntPtr hwnd)
		{
			int dwStyle = global::Infragistics.Windows.Helpers.NativeWindowMethods.IntPtrToInt32(global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowLong(hwnd, -16));
			int dwExStyle = global::Infragistics.Windows.Helpers.NativeWindowMethods.IntPtrToInt32(global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowLong(hwnd, -20));
			global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT rect = default(global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT);
			global::Infragistics.Windows.Helpers.NativeWindowMethods.AdjustWindowRectExApi(ref rect, dwStyle, false, dwExStyle);
			return new global::Infragistics.Windows.Helpers.NativeWindowMethods.SIZE(rect.right - rect.left, rect.bottom - rect.top);
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x00029458 File Offset: 0x00027658
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

		// Token: 0x06000CF1 RID: 3313 RVA: 0x0002949C File Offset: 0x0002769C
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

		// Token: 0x06000CF2 RID: 3314 RVA: 0x00029520 File Offset: 0x00027720
		internal static global::Infragistics.Windows.Helpers.NativeWindowMethods.WINDOWINFO GetWindowInfo(global::System.IntPtr hwnd)
		{
			global::Infragistics.Windows.Helpers.NativeWindowMethods.WINDOWINFO windowinfo = default(global::Infragistics.Windows.Helpers.NativeWindowMethods.WINDOWINFO);
			windowinfo.cbSize = global::System.Runtime.InteropServices.Marshal.SizeOf(windowinfo);
			global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowInfo(hwnd, ref windowinfo);
			return windowinfo;
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x00029554 File Offset: 0x00027754
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

		// Token: 0x06000CF4 RID: 3316 RVA: 0x00029598 File Offset: 0x00027798
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

		// Token: 0x06000CF5 RID: 3317 RVA: 0x000295D8 File Offset: 0x000277D8
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

		// Token: 0x06000CF6 RID: 3318 RVA: 0x0002961C File Offset: 0x0002781C
		internal static global::System.Windows.Rect GetWorkArea(global::System.Windows.Point point)
		{
			global::Infragistics.Windows.Helpers.NativeWindowMethods.ScreenHelper screenHelper = global::Infragistics.Windows.Helpers.NativeWindowMethods.ScreenHelper.FromPoint(point);
			return screenHelper.WorkingArea;
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x00029638 File Offset: 0x00027838
		internal static global::System.Windows.Rect GetWorkArea(global::System.Windows.Rect screenRect)
		{
			global::Infragistics.Windows.Helpers.NativeWindowMethods.ScreenHelper screenHelper = global::Infragistics.Windows.Helpers.NativeWindowMethods.ScreenHelper.FromRect(screenRect);
			return screenHelper.WorkingArea;
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x00029652 File Offset: 0x00027852
		internal static int GetXFromLParam(global::System.IntPtr lParam)
		{
			return global::Infragistics.Windows.Helpers.NativeWindowMethods.SignedLoWord(global::Infragistics.Windows.Helpers.NativeWindowMethods.IntPtrToInt32(lParam));
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x0002965F File Offset: 0x0002785F
		internal static int GetYFromLParam(global::System.IntPtr lParam)
		{
			return global::Infragistics.Windows.Helpers.NativeWindowMethods.SignedHiWord(global::Infragistics.Windows.Helpers.NativeWindowMethods.IntPtrToInt32(lParam));
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x0002966C File Offset: 0x0002786C
		internal static int IntPtrToInt32(global::System.IntPtr intPtr)
		{
			return (int)intPtr.ToInt64();
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000CFB RID: 3323 RVA: 0x00029678 File Offset: 0x00027878
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

		// Token: 0x06000CFC RID: 3324 RVA: 0x000296B8 File Offset: 0x000278B8
		private static bool UnsafeIsDWMCompositionEnabled()
		{
			bool flag;
			return global::Infragistics.Windows.Helpers.NativeWindowMethods.DwmIsCompositionEnabled(out flag) == 0 && flag;
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x000296D4 File Offset: 0x000278D4
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

		// Token: 0x06000CFE RID: 3326 RVA: 0x00029718 File Offset: 0x00027918
		internal static global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT PointFromLParam(global::System.IntPtr lParam)
		{
			int value = global::Infragistics.Windows.Helpers.NativeWindowMethods.IntPtrToInt32(lParam);
			return new global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT(global::Infragistics.Windows.Helpers.NativeWindowMethods.SignedLoWord(value), global::Infragistics.Windows.Helpers.NativeWindowMethods.SignedHiWord(value));
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x0002973D File Offset: 0x0002793D
		internal static global::System.IntPtr RemoveBits(global::System.IntPtr ptr, int bitsToRemove)
		{
			if (global::System.IntPtr.Size == 4)
			{
				return new global::System.IntPtr(ptr.ToInt32() & ~bitsToRemove);
			}
			return new global::System.IntPtr(ptr.ToInt64() & (long)(~(long)bitsToRemove));
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x00029767 File Offset: 0x00027967
		internal static int SignedLoWord(int value)
		{
			return (int)((short)(value & 65535));
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x00029771 File Offset: 0x00027971
		internal static int SignedHiWord(int value)
		{
			return (int)((short)(value >> 16 & 65535));
		}

		// Token: 0x040005BD RID: 1469
		internal const int HCBT_ACTIVATE = 5;

		// Token: 0x040005BE RID: 1470
		internal const uint GW_HWNDFIRST = 0U;

		// Token: 0x040005BF RID: 1471
		internal const uint GW_HWNDLAST = 1U;

		// Token: 0x040005C0 RID: 1472
		internal const uint GW_HWNDNEXT = 2U;

		// Token: 0x040005C1 RID: 1473
		internal const uint GW_HWNDPREV = 3U;

		// Token: 0x040005C2 RID: 1474
		internal const uint GW_OWNER = 4U;

		// Token: 0x040005C3 RID: 1475
		internal const uint GW_CHILD = 5U;

		// Token: 0x040005C4 RID: 1476
		internal const uint GW_ENABLEDPOPUP = 6U;

		// Token: 0x040005C5 RID: 1477
		internal const int GWL_HWNDPARENT = -8;

		// Token: 0x040005C6 RID: 1478
		internal const int GWL_STYLE = -16;

		// Token: 0x040005C7 RID: 1479
		internal const int GWL_EXSTYLE = -20;

		// Token: 0x040005C8 RID: 1480
		internal const int MF_BYCOMMAND = 0;

		// Token: 0x040005C9 RID: 1481
		internal const int MF_BYPOSITION = 1024;

		// Token: 0x040005CA RID: 1482
		internal const int MF_ENABLED = 0;

		// Token: 0x040005CB RID: 1483
		internal const int MF_GRAYED = 1;

		// Token: 0x040005CC RID: 1484
		internal const int MF_DEFAULT = 4096;

		// Token: 0x040005CD RID: 1485
		internal const int MF_SYSMENU = 8192;

		// Token: 0x040005CE RID: 1486
		internal const int MONITOR_DEFAULTTONULL = 0;

		// Token: 0x040005CF RID: 1487
		internal const int MONITOR_DEFAULTTOPRIMARY = 1;

		// Token: 0x040005D0 RID: 1488
		internal const int MONITOR_DEFAULTTONEAREST = 2;

		// Token: 0x040005D1 RID: 1489
		internal const int SC_MINIMIZE = 61472;

		// Token: 0x040005D2 RID: 1490
		internal const int SC_MAXIMIZE = 61488;

		// Token: 0x040005D3 RID: 1491
		internal const int SC_NEXTWINDOW = 61504;

		// Token: 0x040005D4 RID: 1492
		internal const int SC_CLOSE = 61536;

		// Token: 0x040005D5 RID: 1493
		internal const int SC_RESTORE = 61728;

		// Token: 0x040005D6 RID: 1494
		internal const int SC_KEYMENU = 61696;

		// Token: 0x040005D7 RID: 1495
		internal const int SC_MOUSEMENU = 61584;

		// Token: 0x040005D8 RID: 1496
		internal const int SC_CONTEXTHELP = 61824;

		// Token: 0x040005D9 RID: 1497
		internal const int SC_MOVE = 61456;

		// Token: 0x040005DA RID: 1498
		internal const int SC_DRAGMOVE = 61458;

		// Token: 0x040005DB RID: 1499
		internal const int SIZE_RESTORED = 0;

		// Token: 0x040005DC RID: 1500
		internal const int SIZE_MINIMIZED = 1;

		// Token: 0x040005DD RID: 1501
		internal const int SIZE_MAXIMIZED = 2;

		// Token: 0x040005DE RID: 1502
		internal const int SIZE_MAXSHOW = 3;

		// Token: 0x040005DF RID: 1503
		internal const int SIZE_MAXHIDE = 4;

		// Token: 0x040005E0 RID: 1504
		private const int SM_CXVIRTUALSCREEN = 78;

		// Token: 0x040005E1 RID: 1505
		private const int SM_CMONITORS = 80;

		// Token: 0x040005E2 RID: 1506
		internal const int SW_FORCEMINIMIZE = 11;

		// Token: 0x040005E3 RID: 1507
		internal const int SW_HIDE = 0;

		// Token: 0x040005E4 RID: 1508
		internal const int SW_MAXIMIZE = 3;

		// Token: 0x040005E5 RID: 1509
		internal const int SW_MINIMIZE = 6;

		// Token: 0x040005E6 RID: 1510
		internal const int SW_RESTORE = 9;

		// Token: 0x040005E7 RID: 1511
		internal const int SW_SHOW = 5;

		// Token: 0x040005E8 RID: 1512
		internal const int SW_SHOWDEFAULT = 10;

		// Token: 0x040005E9 RID: 1513
		internal const int SW_SHOWMAXIMIZED = 3;

		// Token: 0x040005EA RID: 1514
		internal const int SW_SHOWMINIMIZED = 2;

		// Token: 0x040005EB RID: 1515
		internal const int SW_SHOWMINNOACTIVE = 7;

		// Token: 0x040005EC RID: 1516
		internal const int SW_SHOWNA = 8;

		// Token: 0x040005ED RID: 1517
		internal const int SW_SHOWNOACTIVATE = 4;

		// Token: 0x040005EE RID: 1518
		internal const int SW_SHOWNORMAL = 1;

		// Token: 0x040005EF RID: 1519
		internal const int SWP_NOACTIVATE = 16;

		// Token: 0x040005F0 RID: 1520
		internal const int SWP_SHOWWINDOW = 64;

		// Token: 0x040005F1 RID: 1521
		internal const int SWP_NOSIZE = 1;

		// Token: 0x040005F2 RID: 1522
		internal const int SWP_NOMOVE = 2;

		// Token: 0x040005F3 RID: 1523
		internal const int SWP_NOSENDCHANGING = 1024;

		// Token: 0x040005F4 RID: 1524
		internal const int SWP_FRAMECHANGED = 32;

		// Token: 0x040005F5 RID: 1525
		internal const int SWP_NOOWNERZORDER = 512;

		// Token: 0x040005F6 RID: 1526
		internal const int SWP_NOZORDER = 4;

		// Token: 0x040005F7 RID: 1527
		internal const int SWP_NOREDRAW = 8;

		// Token: 0x040005F8 RID: 1528
		internal const int SWP_HIDEWINDOW = 128;

		// Token: 0x040005F9 RID: 1529
		internal const int SWP_NOCOPYBITS = 256;

		// Token: 0x040005FA RID: 1530
		internal const int SWP_DRAWFRAME = 32;

		// Token: 0x040005FB RID: 1531
		internal const int SWP_NOREPOSITION = 512;

		// Token: 0x040005FC RID: 1532
		internal const int SWP_DEFERERASE = 8192;

		// Token: 0x040005FD RID: 1533
		internal const int SWP_ASYNCWINDOWPOS = 16384;

		// Token: 0x040005FE RID: 1534
		internal const int SWP_STATECHANGED = 32768;

		// Token: 0x040005FF RID: 1535
		internal const int WH_CBT = 5;

		// Token: 0x04000600 RID: 1536
		internal const int WM_NCHITTEST = 132;

		// Token: 0x04000601 RID: 1537
		internal const int WM_NCCALCSIZE = 131;

		// Token: 0x04000602 RID: 1538
		internal const int WM_NCUAHDRAWCAPTION = 174;

		// Token: 0x04000603 RID: 1539
		internal const int WM_NCUAHDRAWFRAME = 175;

		// Token: 0x04000604 RID: 1540
		internal const int WM_NCPAINT = 133;

		// Token: 0x04000605 RID: 1541
		internal const int WM_NCACTIVATE = 134;

		// Token: 0x04000606 RID: 1542
		internal const int WM_STYLECHANGING = 124;

		// Token: 0x04000607 RID: 1543
		internal const int WM_GETMINMAXINFO = 36;

		// Token: 0x04000608 RID: 1544
		internal const int WM_MOVING = 534;

		// Token: 0x04000609 RID: 1545
		internal const int WM_SIZE = 5;

		// Token: 0x0400060A RID: 1546
		internal const int WM_CONTEXTMENU = 123;

		// Token: 0x0400060B RID: 1547
		internal const int WM_SYSCOMMAND = 274;

		// Token: 0x0400060C RID: 1548
		internal const int WM_NCLBUTTONDBLCLK = 163;

		// Token: 0x0400060D RID: 1549
		internal const int WM_DWMCOMPOSITIONCHANGED = 798;

		// Token: 0x0400060E RID: 1550
		internal const int WM_WINDOWPOSCHANGING = 70;

		// Token: 0x0400060F RID: 1551
		internal const int WM_WINDOWPOSCHANGED = 71;

		// Token: 0x04000610 RID: 1552
		internal const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x04000611 RID: 1553
		internal const int WM_SHOWWINDOW = 24;

		// Token: 0x04000612 RID: 1554
		internal const int WM_MOUSEACTIVATE = 33;

		// Token: 0x04000613 RID: 1555
		internal const int WM_DISPLAYCHANGE = 126;

		// Token: 0x04000614 RID: 1556
		internal const int WM_LBUTTONUP = 514;

		// Token: 0x04000615 RID: 1557
		internal const int WM_ENTERSIZEMOVE = 561;

		// Token: 0x04000616 RID: 1558
		internal const int WM_EXITSIZEMOVE = 562;

		// Token: 0x04000617 RID: 1559
		internal const int WM_TABLET_DEFBASE = 704;

		// Token: 0x04000618 RID: 1560
		internal const int WM_TABLET_QUERYSYSTEMGESTURESTATUS = 716;

		// Token: 0x04000619 RID: 1561
		internal const int WS_MINIMIZEBOX = 131072;

		// Token: 0x0400061A RID: 1562
		internal const int WS_MAXIMIZEBOX = 65536;

		// Token: 0x0400061B RID: 1563
		internal const int WS_SYSMENU = 524288;

		// Token: 0x0400061C RID: 1564
		internal const int WS_OVERLAPPED = 0;

		// Token: 0x0400061D RID: 1565
		internal const int WS_POPUP = -2147483648;

		// Token: 0x0400061E RID: 1566
		internal const int WS_CHILD = 1073741824;

		// Token: 0x0400061F RID: 1567
		internal const int WS_MINIMIZE = 536870912;

		// Token: 0x04000620 RID: 1568
		internal const int WS_VISIBLE = 268435456;

		// Token: 0x04000621 RID: 1569
		internal const int WS_DISABLED = 134217728;

		// Token: 0x04000622 RID: 1570
		internal const int WS_CLIPSIBLINGS = 67108864;

		// Token: 0x04000623 RID: 1571
		internal const int WS_CLIPCHILDREN = 33554432;

		// Token: 0x04000624 RID: 1572
		internal const int WS_MAXIMIZE = 16777216;

		// Token: 0x04000625 RID: 1573
		internal const int WS_CAPTION = 12582912;

		// Token: 0x04000626 RID: 1574
		internal const int WS_BORDER = 8388608;

		// Token: 0x04000627 RID: 1575
		internal const int WS_DLGFRAME = 4194304;

		// Token: 0x04000628 RID: 1576
		internal const int WS_VSCROLL = 2097152;

		// Token: 0x04000629 RID: 1577
		internal const int WS_HSCROLL = 1048576;

		// Token: 0x0400062A RID: 1578
		internal const int WS_THICKFRAME = 262144;

		// Token: 0x0400062B RID: 1579
		internal const int WS_GROUP = 131072;

		// Token: 0x0400062C RID: 1580
		internal const int WS_TABSTOP = 65536;

		// Token: 0x0400062D RID: 1581
		internal const int WS_TILED = 0;

		// Token: 0x0400062E RID: 1582
		internal const int WS_ICONIC = 536870912;

		// Token: 0x0400062F RID: 1583
		internal const int WS_SIZEBOX = 262144;

		// Token: 0x04000630 RID: 1584
		internal const int WS_TILEDWINDOW = 13565952;

		// Token: 0x04000631 RID: 1585
		internal const int WS_OVERLAPPEDWINDOW = 13565952;

		// Token: 0x04000632 RID: 1586
		internal const int WS_POPUPWINDOW = -2138570752;

		// Token: 0x04000633 RID: 1587
		internal const int WS_CHILDWINDOW = 1073741824;

		// Token: 0x04000634 RID: 1588
		internal const int WS_EX_DLGMODALFRAME = 1;

		// Token: 0x04000635 RID: 1589
		internal const int WS_EX_NOPARENTNOTIFY = 4;

		// Token: 0x04000636 RID: 1590
		internal const int WS_EX_TOPMOST = 8;

		// Token: 0x04000637 RID: 1591
		internal const int WS_EX_ACCEPTFILES = 16;

		// Token: 0x04000638 RID: 1592
		internal const int WS_EX_TRANSPARENT = 32;

		// Token: 0x04000639 RID: 1593
		internal const int WS_EX_MDICHILD = 64;

		// Token: 0x0400063A RID: 1594
		internal const int WS_EX_TOOLWINDOW = 128;

		// Token: 0x0400063B RID: 1595
		internal const int WS_EX_WINDOWEDGE = 256;

		// Token: 0x0400063C RID: 1596
		internal const int WS_EX_CLIENTEDGE = 512;

		// Token: 0x0400063D RID: 1597
		internal const int WS_EX_CONTEXTHELP = 1024;

		// Token: 0x0400063E RID: 1598
		internal const int WS_EX_RIGHT = 4096;

		// Token: 0x0400063F RID: 1599
		internal const int WS_EX_LEFT = 0;

		// Token: 0x04000640 RID: 1600
		internal const int WS_EX_RTLREADING = 8192;

		// Token: 0x04000641 RID: 1601
		internal const int WS_EX_LTRREADING = 0;

		// Token: 0x04000642 RID: 1602
		internal const int WS_EX_LEFTSCROLLBAR = 16384;

		// Token: 0x04000643 RID: 1603
		internal const int WS_EX_RIGHTSCROLLBAR = 0;

		// Token: 0x04000644 RID: 1604
		internal const int WS_EX_CONTROLPARENT = 65536;

		// Token: 0x04000645 RID: 1605
		internal const int WS_EX_STATICEDGE = 131072;

		// Token: 0x04000646 RID: 1606
		internal const int WS_EX_APPWINDOW = 262144;

		// Token: 0x04000647 RID: 1607
		internal const int WS_EX_OVERLAPPEDWINDOW = 768;

		// Token: 0x04000648 RID: 1608
		internal const int WS_EX_PALETTEWINDOW = 392;

		// Token: 0x04000649 RID: 1609
		internal const int WS_EX_LAYERED = 524288;

		// Token: 0x0400064A RID: 1610
		internal const int WS_EX_NOINHERITLAYOUT = 1048576;

		// Token: 0x0400064B RID: 1611
		internal const int WS_EX_LAYOUTRTL = 4194304;

		// Token: 0x0400064C RID: 1612
		internal const int WS_EX_COMPOSITED = 33554432;

		// Token: 0x0400064D RID: 1613
		internal const int WS_EX_NOACTIVATE = 134217728;

		// Token: 0x0400064E RID: 1614
		private const int PtrSizeOn32Bit = 4;

		// Token: 0x0400064F RID: 1615
		private const int PtrSizeOn64Bit = 8;

		// Token: 0x04000650 RID: 1616
		internal const int WPF_ASYNCWINDOWPLACEMENT = 4;

		// Token: 0x04000651 RID: 1617
		internal const int WPF_RESTORETOMAXIMIZED = 2;

		// Token: 0x04000652 RID: 1618
		internal const int WPF_SETMINPOSITION = 1;

		// Token: 0x04000653 RID: 1619
		internal const int SW_OTHERUNZOOM = 4;

		// Token: 0x04000654 RID: 1620
		internal const int SW_OTHERZOOM = 2;

		// Token: 0x04000655 RID: 1621
		internal const int SW_PARENTCLOSING = 1;

		// Token: 0x04000656 RID: 1622
		internal const int SW_PARENTOPENING = 3;

		// Token: 0x04000657 RID: 1623
		internal const uint TPM_CENTERALIGN = 4U;

		// Token: 0x04000658 RID: 1624
		internal const uint TPM_LEFTALIGN = 0U;

		// Token: 0x04000659 RID: 1625
		internal const uint TPM_RIGHTALIGN = 8U;

		// Token: 0x0400065A RID: 1626
		internal const uint TPM_BOTTOMALIGN = 32U;

		// Token: 0x0400065B RID: 1627
		internal const uint TPM_TOPALIGN = 0U;

		// Token: 0x0400065C RID: 1628
		internal const uint TPM_VCENTERALIGN = 16U;

		// Token: 0x0400065D RID: 1629
		internal const uint TPM_NONOTIFY = 128U;

		// Token: 0x0400065E RID: 1630
		internal const uint TPM_RETURNCMD = 256U;

		// Token: 0x0400065F RID: 1631
		internal const uint TPM_LEFTBUTTON = 0U;

		// Token: 0x04000660 RID: 1632
		internal const uint TPM_RIGHTBUTTON = 2U;

		// Token: 0x04000661 RID: 1633
		internal const long MOUSEEVENTF_FROMTOUCH = 4283520768L;

		// Token: 0x04000662 RID: 1634
		internal const int GA_PARENT = 1;

		// Token: 0x04000663 RID: 1635
		internal const int GA_ROOT = 2;

		// Token: 0x04000664 RID: 1636
		internal const int GA_ROOTOWNER = 3;

		// Token: 0x04000665 RID: 1637
		private static bool _securityException;

		// Token: 0x04000666 RID: 1638
		private static bool hasSecurityExceptionBeenThrown = false;

		// Token: 0x04000667 RID: 1639
		internal static readonly global::System.IntPtr HWND_TOP = new global::System.IntPtr(0);

		// Token: 0x04000668 RID: 1640
		internal static readonly global::System.IntPtr HWND_BOTTOM = new global::System.IntPtr(1);

		// Token: 0x04000669 RID: 1641
		internal static readonly global::System.IntPtr HWND_TOPMOST = new global::System.IntPtr(-1);

		// Token: 0x0400066A RID: 1642
		internal static readonly global::System.IntPtr HWND_NOTOPMOST = new global::System.IntPtr(-2);

		// Token: 0x0400066B RID: 1643
		private static bool _unsafeCaretBlinkTimeDoesntWork;

		// Token: 0x0400066C RID: 1644
		private static bool _systemInformationCaretBlinkTimeDoesntWork;

		// Token: 0x0400066D RID: 1645
		private static bool _unsafeDoubleClickTimeDoesntWork;

		// Token: 0x0400066E RID: 1646
		private static bool _systemInformationDoubleClickTimeDoesntWork;

		// Token: 0x0400066F RID: 1647
		private static bool _unsafeDoubleClickSizeDoesntWork;

		// Token: 0x04000670 RID: 1648
		private static bool _systemInformationDoubleClickSizeDoesntWork;

		// Token: 0x04000671 RID: 1649
		private static bool _unsafeDragSizeDoesntWork;

		// Token: 0x04000672 RID: 1650
		private static bool _systemInformationDragSizeDoesntWork;

		// Token: 0x02000178 RID: 376
		internal struct MINMAXINFO
		{
			// Token: 0x04000673 RID: 1651
			public global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT ptReserved;

			// Token: 0x04000674 RID: 1652
			public global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT ptMaxSize;

			// Token: 0x04000675 RID: 1653
			public global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT ptMaxPosition;

			// Token: 0x04000676 RID: 1654
			public global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT ptMinTrackSize;

			// Token: 0x04000677 RID: 1655
			public global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT ptMaxTrackSize;
		}

		// Token: 0x02000179 RID: 377
		public struct MONITORINFO
		{
			// Token: 0x04000678 RID: 1656
			public uint cbSize;

			// Token: 0x04000679 RID: 1657
			public global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT rcMonitor;

			// Token: 0x0400067A RID: 1658
			public global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT rcWork;

			// Token: 0x0400067B RID: 1659
			public uint dwFlags;
		}

		// Token: 0x0200017A RID: 378
		[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = global::System.Runtime.InteropServices.CharSet.Auto, Pack = 4)]
		internal class MONITIORINFOEX
		{
			// Token: 0x06000D03 RID: 3331 RVA: 0x000297B4 File Offset: 0x000279B4
			internal MONITIORINFOEX()
			{
				this._size = global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Infragistics.Windows.Helpers.NativeWindowMethods.MONITIORINFOEX));
				this._rcMonitor = default(global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT);
				this._rcWork = default(global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT);
				this._device = new char[32];
			}

			// Token: 0x0400067C RID: 1660
			internal int _size;

			// Token: 0x0400067D RID: 1661
			internal global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT _rcMonitor;

			// Token: 0x0400067E RID: 1662
			internal global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT _rcWork;

			// Token: 0x0400067F RID: 1663
			internal int _flags;

			// Token: 0x04000680 RID: 1664
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 32)]
			internal char[] _device;
		}

		// Token: 0x0200017B RID: 379
		internal struct NCCALCSIZE_PARAMS
		{
			// Token: 0x04000681 RID: 1665
			internal global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT rectProposed;

			// Token: 0x04000682 RID: 1666
			internal global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT rectBeforeMove;

			// Token: 0x04000683 RID: 1667
			internal global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT rectClientBeforeMove;

			// Token: 0x04000684 RID: 1668
			internal global::System.IntPtr ptrWindowPos;
		}

		// Token: 0x0200017C RID: 380
		internal struct POINT : global::System.IEquatable<global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT>
		{
			// Token: 0x06000D04 RID: 3332 RVA: 0x00029801 File Offset: 0x00027A01
			internal POINT(int x, int y)
			{
				this.X = x;
				this.Y = y;
			}

			// Token: 0x17000280 RID: 640
			// (get) Token: 0x06000D05 RID: 3333 RVA: 0x00029811 File Offset: 0x00027A11
			internal global::System.Windows.Point Point
			{
				get
				{
					return new global::System.Windows.Point((double)this.X, (double)this.Y);
				}
			}

			// Token: 0x06000D06 RID: 3334 RVA: 0x00029826 File Offset: 0x00027A26
			public bool Equals(global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT other)
			{
				return this.X == other.X && this.Y == other.Y;
			}

			// Token: 0x04000685 RID: 1669
			internal int X;

			// Token: 0x04000686 RID: 1670
			internal int Y;
		}

		// Token: 0x0200017D RID: 381
		internal struct RECT
		{
			// Token: 0x06000D07 RID: 3335 RVA: 0x00029848 File Offset: 0x00027A48
			internal RECT(int left, int top, int right, int bottom)
			{
				this.left = left;
				this.top = top;
				this.right = right;
				this.bottom = bottom;
			}

			// Token: 0x17000281 RID: 641
			// (get) Token: 0x06000D08 RID: 3336 RVA: 0x00029867 File Offset: 0x00027A67
			public int Height
			{
				get
				{
					return this.bottom - this.top;
				}
			}

			// Token: 0x17000282 RID: 642
			// (get) Token: 0x06000D09 RID: 3337 RVA: 0x00029876 File Offset: 0x00027A76
			public int Width
			{
				get
				{
					return this.right - this.left;
				}
			}

			// Token: 0x06000D0A RID: 3338 RVA: 0x00029885 File Offset: 0x00027A85
			public static global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT FromLTRB(global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT leftTop, global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT rightBottom)
			{
				return new global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT(leftTop.X, leftTop.Y, rightBottom.X, rightBottom.Y);
			}

			// Token: 0x06000D0B RID: 3339 RVA: 0x000298A8 File Offset: 0x00027AA8
			public global::System.Windows.Rect ToRect()
			{
				return new global::System.Windows.Rect((double)this.left, (double)this.top, (double)global::System.Math.Abs(this.right - this.left), (double)global::System.Math.Abs(this.bottom - this.top));
			}

			// Token: 0x04000687 RID: 1671
			internal int left;

			// Token: 0x04000688 RID: 1672
			internal int top;

			// Token: 0x04000689 RID: 1673
			internal int right;

			// Token: 0x0400068A RID: 1674
			internal int bottom;
		}

		// Token: 0x0200017E RID: 382
		internal struct SIZE
		{
			// Token: 0x06000D0C RID: 3340 RVA: 0x000298E3 File Offset: 0x00027AE3
			public SIZE(int width, int height)
			{
				this.width = width;
				this.height = height;
			}

			// Token: 0x0400068B RID: 1675
			public int width;

			// Token: 0x0400068C RID: 1676
			public int height;
		}

		// Token: 0x0200017F RID: 383
		internal struct STYLESTRUCT
		{
			// Token: 0x0400068D RID: 1677
			public int styleOld;

			// Token: 0x0400068E RID: 1678
			public int styleNew;
		}

		// Token: 0x02000180 RID: 384
		internal struct WINDOWINFO
		{
			// Token: 0x0400068F RID: 1679
			public int cbSize;

			// Token: 0x04000690 RID: 1680
			public global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT rcWindow;

			// Token: 0x04000691 RID: 1681
			public global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT rcClient;

			// Token: 0x04000692 RID: 1682
			public uint dwStyle;

			// Token: 0x04000693 RID: 1683
			public uint dwExStyle;

			// Token: 0x04000694 RID: 1684
			public uint dwWindowStatus;

			// Token: 0x04000695 RID: 1685
			public uint cxWindowBorders;

			// Token: 0x04000696 RID: 1686
			public uint cyWindowBorders;

			// Token: 0x04000697 RID: 1687
			public ushort atomWindowType;

			// Token: 0x04000698 RID: 1688
			public ushort wCreatorVersion;
		}

		// Token: 0x02000181 RID: 385
		public struct WINDOWPLACEMENT
		{
			// Token: 0x04000699 RID: 1689
			public int length;

			// Token: 0x0400069A RID: 1690
			public int flags;

			// Token: 0x0400069B RID: 1691
			public int showCmd;

			// Token: 0x0400069C RID: 1692
			public global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT ptMinPosition;

			// Token: 0x0400069D RID: 1693
			public global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT ptMaxPosition;

			// Token: 0x0400069E RID: 1694
			public global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT rcNormalPosition;
		}

		// Token: 0x02000182 RID: 386
		internal struct WINDOWPOS
		{
			// Token: 0x0400069F RID: 1695
			internal global::System.IntPtr hwnd;

			// Token: 0x040006A0 RID: 1696
			internal global::System.IntPtr hWndInsertAfter;

			// Token: 0x040006A1 RID: 1697
			internal int x;

			// Token: 0x040006A2 RID: 1698
			internal int y;

			// Token: 0x040006A3 RID: 1699
			internal int cx;

			// Token: 0x040006A4 RID: 1700
			internal int cy;

			// Token: 0x040006A5 RID: 1701
			internal int flags;
		}

		// Token: 0x02000183 RID: 387
		internal enum HitTestResults
		{
			// Token: 0x040006A7 RID: 1703
			HTERROR = -2,
			// Token: 0x040006A8 RID: 1704
			HTTRANSPARENT,
			// Token: 0x040006A9 RID: 1705
			HTNOWHERE,
			// Token: 0x040006AA RID: 1706
			HTCLIENT,
			// Token: 0x040006AB RID: 1707
			HTCAPTION,
			// Token: 0x040006AC RID: 1708
			HTSYSMENU,
			// Token: 0x040006AD RID: 1709
			HTGROWBOX,
			// Token: 0x040006AE RID: 1710
			HTSIZE = 4,
			// Token: 0x040006AF RID: 1711
			HTMENU,
			// Token: 0x040006B0 RID: 1712
			HTHSCROLL,
			// Token: 0x040006B1 RID: 1713
			HTVSCROLL,
			// Token: 0x040006B2 RID: 1714
			HTMINBUTTON,
			// Token: 0x040006B3 RID: 1715
			HTMAXBUTTON,
			// Token: 0x040006B4 RID: 1716
			HTLEFT,
			// Token: 0x040006B5 RID: 1717
			HTRIGHT,
			// Token: 0x040006B6 RID: 1718
			HTTOP,
			// Token: 0x040006B7 RID: 1719
			HTTOPLEFT,
			// Token: 0x040006B8 RID: 1720
			HTTOPRIGHT,
			// Token: 0x040006B9 RID: 1721
			HTBOTTOM,
			// Token: 0x040006BA RID: 1722
			HTBOTTOMLEFT,
			// Token: 0x040006BB RID: 1723
			HTBOTTOMRIGHT,
			// Token: 0x040006BC RID: 1724
			HTBORDER,
			// Token: 0x040006BD RID: 1725
			HTREDUCE = 8,
			// Token: 0x040006BE RID: 1726
			HTZOOM,
			// Token: 0x040006BF RID: 1727
			HTSIZEFIRST,
			// Token: 0x040006C0 RID: 1728
			HTSIZELAST = 17,
			// Token: 0x040006C1 RID: 1729
			HTOBJECT = 19,
			// Token: 0x040006C2 RID: 1730
			HTCLOSE,
			// Token: 0x040006C3 RID: 1731
			HTHELP
		}

		// Token: 0x02000184 RID: 388
		// (Invoke) Token: 0x06000D0E RID: 3342
		public delegate bool EnumWindowsProc(global::System.IntPtr hWnd, global::System.IntPtr lParam);

		// Token: 0x02000185 RID: 389
		// (Invoke) Token: 0x06000D12 RID: 3346
		public delegate global::System.IntPtr HookProc(int ncode, global::System.IntPtr wParam, global::System.IntPtr lParam);

		// Token: 0x02000186 RID: 390
		private class ScreenHelper
		{
			// Token: 0x06000D15 RID: 3349 RVA: 0x000298F4 File Offset: 0x00027AF4
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

			// Token: 0x17000283 RID: 643
			// (get) Token: 0x06000D16 RID: 3350 RVA: 0x00029A15 File Offset: 0x00027C15
			internal global::System.Windows.Rect Bounds
			{
				get
				{
					return this._bounds;
				}
			}

			// Token: 0x17000284 RID: 644
			// (get) Token: 0x06000D17 RID: 3351 RVA: 0x00029A1D File Offset: 0x00027C1D
			internal global::System.Windows.Rect WorkingArea
			{
				get
				{
					return this._workingArea;
				}
			}

			// Token: 0x06000D18 RID: 3352 RVA: 0x00029A28 File Offset: 0x00027C28
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

			// Token: 0x06000D19 RID: 3353 RVA: 0x00029AA4 File Offset: 0x00027CA4
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

			// Token: 0x06000D1A RID: 3354 RVA: 0x00029B44 File Offset: 0x00027D44
			[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			private static global::Infragistics.Windows.Helpers.NativeWindowMethods.ScreenHelper FromPointFallback(global::System.Windows.Point point)
			{
				return new global::Infragistics.Windows.Helpers.NativeWindowMethods.ScreenHelper(global::System.Windows.Forms.Screen.FromPoint(new global::System.Drawing.Point((int)point.X, (int)point.Y)));
			}

			// Token: 0x06000D1B RID: 3355 RVA: 0x00029B68 File Offset: 0x00027D68
			[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			private static global::Infragistics.Windows.Helpers.NativeWindowMethods.ScreenHelper FromRectFallback(global::System.Windows.Rect rect)
			{
				global::System.Drawing.Rectangle rect2 = global::System.Drawing.Rectangle.FromLTRB((int)rect.Left, (int)rect.Top, (int)rect.Right, (int)rect.Bottom);
				return new global::Infragistics.Windows.Helpers.NativeWindowMethods.ScreenHelper(global::System.Windows.Forms.Screen.FromRectangle(rect2));
			}

			// Token: 0x06000D1C RID: 3356 RVA: 0x00029BA8 File Offset: 0x00027DA8
			[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
			private global::System.Windows.Rect GetBoundsFallback(out global::System.Windows.Rect workingRect)
			{
				global::System.Windows.Forms.Screen screen = this._screenObject as global::System.Windows.Forms.Screen;
				global::System.Drawing.Rectangle bounds = screen.Bounds;
				global::System.Drawing.Rectangle workingArea = screen.WorkingArea;
				workingRect = new global::System.Windows.Rect((double)workingArea.Left, (double)workingArea.Top, (double)workingArea.Width, (double)workingArea.Height);
				return new global::System.Windows.Rect((double)bounds.Left, (double)bounds.Top, (double)bounds.Width, (double)bounds.Height);
			}

			// Token: 0x040006C4 RID: 1732
			private object _screenObject;

			// Token: 0x040006C5 RID: 1733
			private global::System.Windows.Rect _bounds;

			// Token: 0x040006C6 RID: 1734
			private global::System.Windows.Rect _workingArea;
		}
	}
}
