using System;
using System.Collections.Generic;
using CefSharp.Enums;
using CefSharp.Structs;

namespace CefSharp.Handler
{
	// Token: 0x02000105 RID: 261
	public class DisplayHandler : global::CefSharp.IDisplayHandler
	{
		// Token: 0x060007A5 RID: 1957 RVA: 0x0000C7CD File Offset: 0x0000A9CD
		void global::CefSharp.IDisplayHandler.OnAddressChanged(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.AddressChangedEventArgs addressChangedArgs)
		{
			this.OnAddressChanged(chromiumWebBrowser, addressChangedArgs);
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x0000C7D7 File Offset: 0x0000A9D7
		protected virtual void OnAddressChanged(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.AddressChangedEventArgs addressChangedArgs)
		{
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x0000C7D9 File Offset: 0x0000A9D9
		bool global::CefSharp.IDisplayHandler.OnAutoResize(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.Structs.Size newSize)
		{
			return this.OnAutoResize(chromiumWebBrowser, browser, newSize);
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x0000C7E4 File Offset: 0x0000A9E4
		protected virtual bool OnAutoResize(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.Structs.Size newSize)
		{
			return false;
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x0000C7E7 File Offset: 0x0000A9E7
		bool global::CefSharp.IDisplayHandler.OnCursorChange(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::System.IntPtr cursor, global::CefSharp.Enums.CursorType type, global::CefSharp.Structs.CursorInfo customCursorInfo)
		{
			return this.OnCursorChange(chromiumWebBrowser, browser, cursor, type, customCursorInfo);
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x0000C7F6 File Offset: 0x0000A9F6
		protected virtual bool OnCursorChange(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::System.IntPtr cursor, global::CefSharp.Enums.CursorType type, global::CefSharp.Structs.CursorInfo customCursorInfo)
		{
			return false;
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x0000C7F9 File Offset: 0x0000A9F9
		void global::CefSharp.IDisplayHandler.OnTitleChanged(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.TitleChangedEventArgs titleChangedArgs)
		{
			this.OnTitleChanged(chromiumWebBrowser, titleChangedArgs);
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x0000C803 File Offset: 0x0000AA03
		protected virtual void OnTitleChanged(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.TitleChangedEventArgs titleChangedArgs)
		{
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x0000C805 File Offset: 0x0000AA05
		void global::CefSharp.IDisplayHandler.OnFaviconUrlChange(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::System.Collections.Generic.IList<string> urls)
		{
			this.OnFaviconUrlChange(chromiumWebBrowser, browser, urls);
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x0000C810 File Offset: 0x0000AA10
		protected virtual void OnFaviconUrlChange(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::System.Collections.Generic.IList<string> urls)
		{
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x0000C812 File Offset: 0x0000AA12
		void global::CefSharp.IDisplayHandler.OnFullscreenModeChange(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, bool fullscreen)
		{
			this.OnFullscreenModeChange(chromiumWebBrowser, browser, fullscreen);
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x0000C81D File Offset: 0x0000AA1D
		protected virtual void OnFullscreenModeChange(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, bool fullscreen)
		{
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x0000C81F File Offset: 0x0000AA1F
		void global::CefSharp.IDisplayHandler.OnLoadingProgressChange(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, double progress)
		{
			this.OnLoadingProgressChange(chromiumWebBrowser, browser, progress);
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x0000C82A File Offset: 0x0000AA2A
		protected virtual void OnLoadingProgressChange(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, double progress)
		{
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x0000C82C File Offset: 0x0000AA2C
		bool global::CefSharp.IDisplayHandler.OnTooltipChanged(global::CefSharp.IWebBrowser chromiumWebBrowser, ref string text)
		{
			return this.OnTooltipChanged(chromiumWebBrowser, ref text);
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x0000C836 File Offset: 0x0000AA36
		protected virtual bool OnTooltipChanged(global::CefSharp.IWebBrowser chromiumWebBrowser, ref string text)
		{
			return false;
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x0000C839 File Offset: 0x0000AA39
		void global::CefSharp.IDisplayHandler.OnStatusMessage(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.StatusMessageEventArgs statusMessageArgs)
		{
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x0000C83B File Offset: 0x0000AA3B
		protected virtual void OnStatusMessage(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.StatusMessageEventArgs statusMessageArgs)
		{
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x0000C83D File Offset: 0x0000AA3D
		bool global::CefSharp.IDisplayHandler.OnConsoleMessage(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.ConsoleMessageEventArgs consoleMessageArgs)
		{
			return this.OnConsoleMessage(chromiumWebBrowser, consoleMessageArgs);
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x0000C847 File Offset: 0x0000AA47
		protected virtual bool OnConsoleMessage(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.ConsoleMessageEventArgs consoleMessageArgs)
		{
			return false;
		}
	}
}
