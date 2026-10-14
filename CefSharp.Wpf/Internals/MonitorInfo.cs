using System;
using System.Runtime.InteropServices;

namespace CefSharp.Wpf.Internals
{
	// Token: 0x02000015 RID: 21
	internal static class MonitorInfo
	{
		// Token: 0x0600018F RID: 399
		[global::System.Runtime.InteropServices.DllImport("user32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto)]
		private static extern bool GetMonitorInfo(global::System.IntPtr hMonitor, ref global::CefSharp.Wpf.Internals.MonitorInfoEx lpmi);

		// Token: 0x06000190 RID: 400
		[global::System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern global::System.IntPtr MonitorFromWindow(global::System.IntPtr hwnd, uint dwFlags);

		// Token: 0x06000191 RID: 401 RVA: 0x00006190 File Offset: 0x00004390
		internal static void GetMonitorInfoForWindowHandle(global::System.IntPtr windowHandle, ref global::CefSharp.Wpf.Internals.MonitorInfoEx monitorInfo)
		{
			global::System.IntPtr hMonitor = global::CefSharp.Wpf.Internals.MonitorInfo.MonitorFromWindow(windowHandle, 2U);
			global::CefSharp.Wpf.Internals.MonitorInfo.GetMonitorInfo(hMonitor, ref monitorInfo);
		}

		// Token: 0x040000B4 RID: 180
		private const int MONITOR_DEFAULTTONULL = 0;

		// Token: 0x040000B5 RID: 181
		private const int MONITOR_DEFAULTTOPRIMARY = 1;

		// Token: 0x040000B6 RID: 182
		private const int MONITOR_DEFAULTTONEAREST = 2;
	}
}
