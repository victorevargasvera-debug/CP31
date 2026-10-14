using System;

namespace CefSharp
{
	// Token: 0x02000053 RID: 83
	public interface IContextMenuHandler
	{
		// Token: 0x0600012E RID: 302
		void OnBeforeContextMenu(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IContextMenuParams parameters, global::CefSharp.IMenuModel model);

		// Token: 0x0600012F RID: 303
		bool OnContextMenuCommand(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IContextMenuParams parameters, global::CefSharp.CefMenuCommand commandId, global::CefSharp.CefEventFlags eventFlags);

		// Token: 0x06000130 RID: 304
		void OnContextMenuDismissed(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame);

		// Token: 0x06000131 RID: 305
		bool RunContextMenu(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IContextMenuParams parameters, global::CefSharp.IMenuModel model, global::CefSharp.IRunContextMenuCallback callback);
	}
}
