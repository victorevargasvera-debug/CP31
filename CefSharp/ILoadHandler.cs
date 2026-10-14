using System;

namespace CefSharp
{
	// Token: 0x02000060 RID: 96
	public interface ILoadHandler
	{
		// Token: 0x0600015E RID: 350
		void OnLoadingStateChange(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.LoadingStateChangedEventArgs loadingStateChangedArgs);

		// Token: 0x0600015F RID: 351
		void OnFrameLoadStart(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.FrameLoadStartEventArgs frameLoadStartArgs);

		// Token: 0x06000160 RID: 352
		void OnFrameLoadEnd(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.FrameLoadEndEventArgs frameLoadEndArgs);

		// Token: 0x06000161 RID: 353
		void OnLoadError(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.LoadErrorEventArgs loadErrorArgs);
	}
}
