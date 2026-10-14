using System;

namespace CefSharp.Handler
{
	// Token: 0x02000102 RID: 258
	public class ContextMenuHandler : global::CefSharp.IContextMenuHandler
	{
		// Token: 0x06000794 RID: 1940 RVA: 0x0000C733 File Offset: 0x0000A933
		void global::CefSharp.IContextMenuHandler.OnBeforeContextMenu(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IContextMenuParams parameters, global::CefSharp.IMenuModel model)
		{
			this.OnBeforeContextMenu(chromiumWebBrowser, browser, frame, parameters, model);
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x0000C742 File Offset: 0x0000A942
		protected virtual void OnBeforeContextMenu(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IContextMenuParams parameters, global::CefSharp.IMenuModel model)
		{
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x0000C744 File Offset: 0x0000A944
		bool global::CefSharp.IContextMenuHandler.OnContextMenuCommand(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IContextMenuParams parameters, global::CefSharp.CefMenuCommand commandId, global::CefSharp.CefEventFlags eventFlags)
		{
			return this.OnContextMenuCommand(chromiumWebBrowser, browser, frame, parameters, commandId, eventFlags);
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x0000C755 File Offset: 0x0000A955
		protected virtual bool OnContextMenuCommand(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IContextMenuParams parameters, global::CefSharp.CefMenuCommand commandId, global::CefSharp.CefEventFlags eventFlags)
		{
			return false;
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x0000C758 File Offset: 0x0000A958
		void global::CefSharp.IContextMenuHandler.OnContextMenuDismissed(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame)
		{
			this.OnContextMenuDismissed(chromiumWebBrowser, browser, frame);
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x0000C763 File Offset: 0x0000A963
		protected virtual void OnContextMenuDismissed(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame)
		{
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x0000C765 File Offset: 0x0000A965
		bool global::CefSharp.IContextMenuHandler.RunContextMenu(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IContextMenuParams parameters, global::CefSharp.IMenuModel model, global::CefSharp.IRunContextMenuCallback callback)
		{
			return this.RunContextMenu(chromiumWebBrowser, browser, frame, parameters, model, callback);
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x0000C776 File Offset: 0x0000A976
		protected virtual bool RunContextMenu(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.IContextMenuParams parameters, global::CefSharp.IMenuModel model, global::CefSharp.IRunContextMenuCallback callback)
		{
			return false;
		}
	}
}
