using System;

namespace CefSharp.Handler
{
	// Token: 0x0200010C RID: 268
	public class JsDialogHandler : global::CefSharp.IJsDialogHandler
	{
		// Token: 0x060007EE RID: 2030 RVA: 0x0000CA7C File Offset: 0x0000AC7C
		bool global::CefSharp.IJsDialogHandler.OnJSDialog(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, string originUrl, global::CefSharp.CefJsDialogType dialogType, string messageText, string defaultPromptText, global::CefSharp.IJsDialogCallback callback, ref bool suppressMessage)
		{
			return this.OnJSDialog(chromiumWebBrowser, browser, originUrl, dialogType, messageText, defaultPromptText, callback, ref suppressMessage);
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x0000CA9C File Offset: 0x0000AC9C
		protected virtual bool OnJSDialog(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, string originUrl, global::CefSharp.CefJsDialogType dialogType, string messageText, string defaultPromptText, global::CefSharp.IJsDialogCallback callback, ref bool suppressMessage)
		{
			return false;
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x0000CA9F File Offset: 0x0000AC9F
		bool global::CefSharp.IJsDialogHandler.OnBeforeUnloadDialog(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, string messageText, bool isReload, global::CefSharp.IJsDialogCallback callback)
		{
			return this.OnBeforeUnloadDialog(chromiumWebBrowser, browser, messageText, isReload, callback);
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x0000CAAE File Offset: 0x0000ACAE
		protected virtual bool OnBeforeUnloadDialog(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, string messageText, bool isReload, global::CefSharp.IJsDialogCallback callback)
		{
			return false;
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x0000CAB1 File Offset: 0x0000ACB1
		void global::CefSharp.IJsDialogHandler.OnResetDialogState(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser)
		{
			this.OnResetDialogState(chromiumWebBrowser, browser);
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x0000CABB File Offset: 0x0000ACBB
		protected virtual void OnResetDialogState(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser)
		{
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x0000CABD File Offset: 0x0000ACBD
		void global::CefSharp.IJsDialogHandler.OnDialogClosed(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser)
		{
			this.OnDialogClosed(chromiumWebBrowser, browser);
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x0000CAC7 File Offset: 0x0000ACC7
		protected virtual void OnDialogClosed(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser)
		{
		}
	}
}
