using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Interop;

namespace Infragistics.Windows.DockManager
{
	// Token: 0x0200007B RID: 123
	[global::System.Runtime.InteropServices.ComVisible(false)]
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	internal static class NativeWindowMethods
	{
		// Token: 0x06000440 RID: 1088
		[global::System.Runtime.InteropServices.DllImport("user32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, ExactSpelling = true)]
		private static extern bool GetCursorPos([global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] global::Infragistics.Windows.DockManager.NativeWindowMethods.POINT pt);

		// Token: 0x06000441 RID: 1089
		[global::System.Runtime.InteropServices.DllImport("user32")]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Bool)]
		internal static extern bool IsWindowEnabled(global::System.IntPtr hwnd);

		// Token: 0x06000442 RID: 1090 RVA: 0x000180A1 File Offset: 0x000162A1
		internal static global::System.IntPtr SendMessageApi(global::System.IntPtr hWnd, int msg, global::System.IntPtr wparam, global::System.IntPtr lparam)
		{
			return global::Infragistics.Windows.DockManager.NativeWindowMethods.SendMessage(hWnd, msg, wparam, lparam);
		}

		// Token: 0x06000443 RID: 1091
		[global::System.Runtime.InteropServices.DllImport("user32", CharSet = global::System.Runtime.InteropServices.CharSet.Auto)]
		private static extern global::System.IntPtr SendMessage(global::System.IntPtr hWnd, int msg, global::System.IntPtr wparam, global::System.IntPtr lparam);

		// Token: 0x06000444 RID: 1092 RVA: 0x000180AC File Offset: 0x000162AC
		internal static bool SetWindowPosApi(global::System.IntPtr hWnd, global::System.IntPtr hWndInsertAfter, int x, int y, int cx, int cy, int flags)
		{
			return global::Infragistics.Windows.DockManager.NativeWindowMethods.SetWindowPos(hWnd, hWndInsertAfter, x, y, cx, cy, flags);
		}

		// Token: 0x06000445 RID: 1093
		[global::System.Runtime.InteropServices.DllImport("user32", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, ExactSpelling = true)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Bool)]
		private static extern bool SetWindowPos(global::System.IntPtr hWnd, global::System.IntPtr hWndInsertAfter, int x, int y, int cx, int cy, int flags);

		// Token: 0x06000446 RID: 1094
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		internal static extern bool ShowWindow(global::System.IntPtr hWnd, int nCmdShow);

		// Token: 0x06000447 RID: 1095 RVA: 0x000180C0 File Offset: 0x000162C0
		public static global::System.Windows.Point GetCurrentMousePosition()
		{
			global::Infragistics.Windows.DockManager.NativeWindowMethods.POINT pt = default(global::Infragistics.Windows.DockManager.NativeWindowMethods.POINT);
			if (global::Infragistics.Windows.DockManager.NativeWindowMethods._apiGetCursorPosFailed)
			{
				try
				{
					global::Infragistics.Windows.DockManager.NativeWindowMethods.GetCursorPos(pt);
					goto IL_2D;
				}
				catch
				{
					global::Infragistics.Windows.DockManager.NativeWindowMethods._apiGetCursorPosFailed = true;
					pt = global::Infragistics.Windows.DockManager.NativeWindowMethods.GetWinFormCursorPos();
					goto IL_2D;
				}
			}
			pt = global::Infragistics.Windows.DockManager.NativeWindowMethods.GetWinFormCursorPos();
			IL_2D:
			return new global::System.Windows.Point((double)pt.X, (double)pt.Y);
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00018120 File Offset: 0x00016320
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private static global::Infragistics.Windows.DockManager.NativeWindowMethods.POINT GetWinFormCursorPos()
		{
			global::System.Drawing.Point position = global::System.Windows.Forms.Cursor.Position;
			return new global::Infragistics.Windows.DockManager.NativeWindowMethods.POINT(position.X, position.Y);
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00018146 File Offset: 0x00016346
		internal static int IntPtrToInt32(global::System.IntPtr intPtr)
		{
			return (int)intPtr.ToInt64();
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00018150 File Offset: 0x00016350
		internal static void MoveWindow(global::System.Windows.Window window, global::System.Windows.Point location)
		{
			global::System.Windows.Interop.WindowInteropHelper windowInteropHelper = new global::System.Windows.Interop.WindowInteropHelper(window);
			if (windowInteropHelper.Handle == global::System.IntPtr.Zero)
			{
				window.Top = location.Y;
				window.Left = location.X;
				return;
			}
			global::System.Windows.Interop.HwndSource hwndSource = global::System.Windows.Interop.HwndSource.FromHwnd(windowInteropHelper.Handle);
			global::System.Windows.Point point = hwndSource.CompositionTarget.TransformToDevice.Transform(location);
			global::Infragistics.Windows.DockManager.NativeWindowMethods.SetWindowPosApi(windowInteropHelper.Handle, global::System.IntPtr.Zero, (int)point.X, (int)point.Y, 0, 0, 533);
		}

		// Token: 0x040002C8 RID: 712
		internal const int HT_CAPTION = 2;

		// Token: 0x040002C9 RID: 713
		internal const int SW_HIDE = 0;

		// Token: 0x040002CA RID: 714
		internal const int SWP_NOACTIVATE = 16;

		// Token: 0x040002CB RID: 715
		internal const int SWP_SHOWWINDOW = 64;

		// Token: 0x040002CC RID: 716
		internal const int SWP_NOSIZE = 1;

		// Token: 0x040002CD RID: 717
		internal const int SWP_NOMOVE = 2;

		// Token: 0x040002CE RID: 718
		internal const int SWP_NOSENDCHANGING = 1024;

		// Token: 0x040002CF RID: 719
		internal const int SWP_FRAMECHANGED = 32;

		// Token: 0x040002D0 RID: 720
		internal const int SWP_NOOWNERZORDER = 512;

		// Token: 0x040002D1 RID: 721
		internal const int SWP_NOZORDER = 4;

		// Token: 0x040002D2 RID: 722
		internal const int SWP_NOREDRAW = 8;

		// Token: 0x040002D3 RID: 723
		internal const int SWP_HIDEWINDOW = 128;

		// Token: 0x040002D4 RID: 724
		internal const int SWP_NOCOPYBITS = 256;

		// Token: 0x040002D5 RID: 725
		internal const int SWP_DRAWFRAME = 32;

		// Token: 0x040002D6 RID: 726
		internal const int SWP_NOREPOSITION = 512;

		// Token: 0x040002D7 RID: 727
		internal const int SWP_DEFERERASE = 8192;

		// Token: 0x040002D8 RID: 728
		internal const int SWP_ASYNCWINDOWPOS = 16384;

		// Token: 0x040002D9 RID: 729
		internal const int WM_NCHITTEST = 132;

		// Token: 0x040002DA RID: 730
		private static bool _apiGetCursorPosFailed;

		// Token: 0x0200007C RID: 124
		internal struct POINT : global::System.IEquatable<global::Infragistics.Windows.DockManager.NativeWindowMethods.POINT>
		{
			// Token: 0x0600044B RID: 1099 RVA: 0x000181DA File Offset: 0x000163DA
			internal POINT(int x, int y)
			{
				this.X = x;
				this.Y = y;
			}

			// Token: 0x170000DD RID: 221
			// (get) Token: 0x0600044C RID: 1100 RVA: 0x000181EA File Offset: 0x000163EA
			internal global::System.Windows.Point Point
			{
				get
				{
					return new global::System.Windows.Point((double)this.X, (double)this.Y);
				}
			}

			// Token: 0x0600044D RID: 1101 RVA: 0x000181FF File Offset: 0x000163FF
			public bool Equals(global::Infragistics.Windows.DockManager.NativeWindowMethods.POINT other)
			{
				return this.X == other.X && this.Y == other.Y;
			}

			// Token: 0x040002DB RID: 731
			internal int X;

			// Token: 0x040002DC RID: 732
			internal int Y;
		}
	}
}
