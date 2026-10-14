using System;
using System.Collections.Generic;

namespace CefSharp
{
	// Token: 0x02000055 RID: 85
	public interface IDialogHandler
	{
		// Token: 0x06000134 RID: 308
		bool OnFileDialog(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.CefFileDialogMode mode, string title, string defaultFilePath, global::System.Collections.Generic.List<string> acceptFilters, global::CefSharp.IFileDialogCallback callback);
	}
}
