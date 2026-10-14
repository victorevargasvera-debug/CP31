using System;
using System.Collections.Generic;
using CefSharp.Enums;
using CefSharp.Structs;

namespace CefSharp
{
	// Token: 0x02000056 RID: 86
	public interface IDisplayHandler
	{
		// Token: 0x06000135 RID: 309
		void OnAddressChanged(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.AddressChangedEventArgs addressChangedArgs);

		// Token: 0x06000136 RID: 310
		bool OnAutoResize(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.Structs.Size newSize);

		// Token: 0x06000137 RID: 311
		bool OnCursorChange(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::System.IntPtr cursor, global::CefSharp.Enums.CursorType type, global::CefSharp.Structs.CursorInfo customCursorInfo);

		// Token: 0x06000138 RID: 312
		void OnTitleChanged(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.TitleChangedEventArgs titleChangedArgs);

		// Token: 0x06000139 RID: 313
		void OnFaviconUrlChange(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::System.Collections.Generic.IList<string> urls);

		// Token: 0x0600013A RID: 314
		void OnFullscreenModeChange(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, bool fullscreen);

		// Token: 0x0600013B RID: 315
		void OnLoadingProgressChange(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, double progress);

		// Token: 0x0600013C RID: 316
		bool OnTooltipChanged(global::CefSharp.IWebBrowser chromiumWebBrowser, ref string text);

		// Token: 0x0600013D RID: 317
		void OnStatusMessage(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.StatusMessageEventArgs statusMessageArgs);

		// Token: 0x0600013E RID: 318
		bool OnConsoleMessage(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.ConsoleMessageEventArgs consoleMessageArgs);
	}
}
