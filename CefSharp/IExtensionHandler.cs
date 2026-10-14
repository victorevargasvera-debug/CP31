using System;

namespace CefSharp
{
	// Token: 0x02000059 RID: 89
	public interface IExtensionHandler : global::System.IDisposable
	{
		// Token: 0x06000144 RID: 324
		void OnExtensionLoadFailed(global::CefSharp.CefErrorCode errorCode);

		// Token: 0x06000145 RID: 325
		void OnExtensionLoaded(global::CefSharp.IExtension extension);

		// Token: 0x06000146 RID: 326
		void OnExtensionUnloaded(global::CefSharp.IExtension extension);

		// Token: 0x06000147 RID: 327
		bool OnBeforeBackgroundBrowser(global::CefSharp.IExtension extension, string url, global::CefSharp.IBrowserSettings settings);

		// Token: 0x06000148 RID: 328
		bool OnBeforeBrowser(global::CefSharp.IExtension extension, global::CefSharp.IBrowser browser, global::CefSharp.IBrowser activeBrowser, int index, string url, bool active, global::CefSharp.IWindowInfo windowInfo, global::CefSharp.IBrowserSettings settings);

		// Token: 0x06000149 RID: 329
		global::CefSharp.IBrowser GetActiveBrowser(global::CefSharp.IExtension extension, global::CefSharp.IBrowser browser, bool includeIncognito);

		// Token: 0x0600014A RID: 330
		bool CanAccessBrowser(global::CefSharp.IExtension extension, global::CefSharp.IBrowser browser, bool includeIncognito, global::CefSharp.IBrowser targetBrowser);

		// Token: 0x0600014B RID: 331
		bool GetExtensionResource(global::CefSharp.IExtension extension, global::CefSharp.IBrowser browser, string file, global::CefSharp.IGetExtensionResourceCallback callback);
	}
}
