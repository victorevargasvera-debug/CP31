using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;

namespace Infragistics.DragDrop
{
	// Token: 0x02000003 RID: 3
	internal static class PlatformProxy
	{
		// Token: 0x0600004B RID: 75
		[global::System.Runtime.InteropServices.DllImport("kernel32")]
		public static extern int GetCurrentThreadId();

		// Token: 0x0600004C RID: 76
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Bool)]
		public static extern bool EnumThreadWindows(int dwThreadId, global::Infragistics.DragDrop.PlatformProxy.EnumWindowsProc lpfn, global::System.IntPtr lParam);

		// Token: 0x0600004D RID: 77 RVA: 0x00005160 File Offset: 0x00003360
		public static global::System.Windows.UIElement GetRootVisual(global::System.Windows.DependencyObject dependencyObject)
		{
			global::System.Windows.UIElement uielement = global::System.Windows.Window.GetWindow(dependencyObject);
			if (uielement == null)
			{
				for (global::System.Windows.DependencyObject parent = global::System.Windows.Media.VisualTreeHelper.GetParent(dependencyObject); parent != null; parent = global::System.Windows.Media.VisualTreeHelper.GetParent(parent))
				{
					uielement = (parent as global::System.Windows.UIElement);
				}
			}
			return uielement;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00005192 File Offset: 0x00003392
		public static global::System.Windows.UIElement GetHostChild(global::System.Windows.UIElement host, global::System.Windows.UIElement rootSource)
		{
			if (rootSource != null && rootSource.GetType().Name == "RootBrowserWindow")
			{
				return ((global::System.Windows.Window)host).Content as global::System.Windows.UIElement;
			}
			return ((global::System.Windows.Controls.Primitives.Popup)host).Child;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000051CC File Offset: 0x000033CC
		public static global::System.Windows.UIElement GetHost(global::System.Windows.UIElement hostRoot, global::System.Windows.UIElement appRoot, global::System.Windows.UIElement hostChild)
		{
			if (appRoot != null && appRoot.GetType().Name == "RootBrowserWindow")
			{
				return new global::System.Windows.Window
				{
					IsHitTestVisible = false,
					WindowStyle = global::System.Windows.WindowStyle.None,
					ShowInTaskbar = false,
					AllowsTransparency = true,
					Topmost = true,
					Background = new global::System.Windows.Media.SolidColorBrush(global::System.Windows.Media.Colors.Transparent),
					Content = hostChild
				};
			}
			return new global::System.Windows.Controls.Primitives.Popup
			{
				AllowsTransparency = true,
				Placement = global::System.Windows.Controls.Primitives.PlacementMode.Relative,
				PlacementTarget = hostRoot,
				Child = hostChild
			};
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000525C File Offset: 0x0000345C
		public static void OpenHost(global::System.Windows.UIElement host, global::System.Windows.UIElement rootSource, global::System.Windows.UIElement child = null)
		{
			if (rootSource != null && rootSource.GetType().Name == "RootBrowserWindow")
			{
				global::System.Windows.Window window = (global::System.Windows.Window)host;
				if (child != null)
				{
					window.Content = child;
				}
				window.Show();
				return;
			}
			global::System.Windows.Controls.Primitives.Popup popup = (global::System.Windows.Controls.Primitives.Popup)host;
			if (child != null)
			{
				popup.Child = child;
			}
			popup.IsOpen = true;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000052B4 File Offset: 0x000034B4
		public static void CloseHost(global::System.Windows.UIElement host, global::System.Windows.UIElement rootSource, bool clearChild, bool close)
		{
			if (rootSource != null && rootSource.GetType().Name == "RootBrowserWindow")
			{
				global::System.Windows.Window window = (global::System.Windows.Window)host;
				if (!close)
				{
					window.Hide();
				}
				else
				{
					window.Close();
				}
				if (clearChild)
				{
					window.Content = null;
				}
				return;
			}
			global::System.Windows.Controls.Primitives.Popup popup = (global::System.Windows.Controls.Primitives.Popup)host;
			if (popup.IsOpen)
			{
				popup.IsOpen = false;
			}
			if (clearChild)
			{
				popup.Child = null;
			}
			if (close)
			{
				popup.PlacementTarget = null;
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00005328 File Offset: 0x00003528
		public static void SetHostPosition(global::System.Windows.UIElement host, global::System.Windows.UIElement rootSource, double top, double left)
		{
			if (rootSource != null && rootSource.GetType().Name == "RootBrowserWindow")
			{
				global::System.Windows.Window window = (global::System.Windows.Window)host;
				window.Top = top;
				if (window.FlowDirection == global::System.Windows.FlowDirection.RightToLeft)
				{
					left -= window.Width;
				}
				window.Left = left;
				return;
			}
			global::System.Windows.Controls.Primitives.Popup popup = (global::System.Windows.Controls.Primitives.Popup)host;
			popup.HorizontalOffset = left;
			popup.VerticalOffset = top;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00005390 File Offset: 0x00003590
		public static void SetHostSize(global::System.Windows.UIElement host, global::System.Windows.UIElement rootSource, double width, double height)
		{
			if (rootSource != null && rootSource.GetType().Name == "RootBrowserWindow")
			{
				global::System.Windows.Window window = (global::System.Windows.Window)host;
				window.Width = width;
				window.Height = height;
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000053CC File Offset: 0x000035CC
		public static global::System.Windows.Point GetMousePosition(global::System.Windows.Input.MouseEventArgs e, global::System.Windows.UIElement rootSource)
		{
			global::System.Windows.Point point = e.GetPosition(rootSource);
			if (rootSource != null && rootSource.GetType().Name == "RootBrowserWindow")
			{
				point = rootSource.PointToScreen(point);
			}
			return point;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00005404 File Offset: 0x00003604
		public static void RefreshHostsLayout(global::System.Windows.UIElement rootSource, global::System.Windows.UIElement dragHost, global::System.Windows.UIElement cursorHost, global::System.Windows.UIElement targetMarkerHost)
		{
			if (targetMarkerHost != null)
			{
				global::Infragistics.DragDrop.PlatformProxy.CloseHost(targetMarkerHost, rootSource, false, false);
				global::Infragistics.DragDrop.PlatformProxy.OpenHost(targetMarkerHost, rootSource, null);
			}
			if (dragHost != null)
			{
				global::Infragistics.DragDrop.PlatformProxy.CloseHost(dragHost, rootSource, false, false);
				global::Infragistics.DragDrop.PlatformProxy.OpenHost(dragHost, rootSource, null);
			}
			if (cursorHost != null)
			{
				global::Infragistics.DragDrop.PlatformProxy.CloseHost(cursorHost, rootSource, false, false);
				global::Infragistics.DragDrop.PlatformProxy.OpenHost(cursorHost, rootSource, null);
			}
		}

		// Token: 0x02000004 RID: 4
		// (Invoke) Token: 0x06000057 RID: 87
		public delegate bool EnumWindowsProc(global::System.IntPtr hWnd, global::System.IntPtr lParam);
	}
}
