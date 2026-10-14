using System;
using System.Collections.Generic;

namespace CefSharp.Handler
{
	// Token: 0x02000104 RID: 260
	public class DialogHandler : global::CefSharp.IDialogHandler
	{
		// Token: 0x060007A2 RID: 1954 RVA: 0x0000C7AF File Offset: 0x0000A9AF
		bool global::CefSharp.IDialogHandler.OnFileDialog(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.CefFileDialogMode mode, string title, string defaultFilePath, global::System.Collections.Generic.List<string> acceptFilters, global::CefSharp.IFileDialogCallback callback)
		{
			return this.OnFileDialog(chromiumWebBrowser, browser, mode, title, defaultFilePath, acceptFilters, callback);
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x0000C7C2 File Offset: 0x0000A9C2
		protected virtual bool OnFileDialog(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.CefFileDialogMode mode, string title, string defaultFilePath, global::System.Collections.Generic.List<string> acceptFilters, global::CefSharp.IFileDialogCallback callback)
		{
			return false;
		}
	}
}
