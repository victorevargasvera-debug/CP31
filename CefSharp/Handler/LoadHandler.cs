using System;

namespace CefSharp.Handler
{
	// Token: 0x0200010F RID: 271
	public class LoadHandler : global::CefSharp.ILoadHandler
	{
		// Token: 0x06000805 RID: 2053 RVA: 0x0000CB7B File Offset: 0x0000AD7B
		void global::CefSharp.ILoadHandler.OnLoadingStateChange(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.LoadingStateChangedEventArgs loadingStateChangedArgs)
		{
			this.OnLoadingStateChange(chromiumWebBrowser, loadingStateChangedArgs);
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x0000CB85 File Offset: 0x0000AD85
		protected virtual void OnLoadingStateChange(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.LoadingStateChangedEventArgs loadingStateChangedArgs)
		{
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x0000CB87 File Offset: 0x0000AD87
		void global::CefSharp.ILoadHandler.OnFrameLoadStart(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.FrameLoadStartEventArgs frameLoadStartArgs)
		{
			this.OnFrameLoadStart(chromiumWebBrowser, frameLoadStartArgs);
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x0000CB91 File Offset: 0x0000AD91
		protected virtual void OnFrameLoadStart(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.FrameLoadStartEventArgs frameLoadStartArgs)
		{
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x0000CB93 File Offset: 0x0000AD93
		void global::CefSharp.ILoadHandler.OnFrameLoadEnd(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.FrameLoadEndEventArgs frameLoadEndArgs)
		{
			this.OnFrameLoadEnd(chromiumWebBrowser, frameLoadEndArgs);
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x0000CB9D File Offset: 0x0000AD9D
		protected virtual void OnFrameLoadEnd(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.FrameLoadEndEventArgs frameLoadEndArgs)
		{
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x0000CB9F File Offset: 0x0000AD9F
		void global::CefSharp.ILoadHandler.OnLoadError(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.LoadErrorEventArgs loadErrorArgs)
		{
			this.OnLoadError(chromiumWebBrowser, loadErrorArgs);
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x0000CBA9 File Offset: 0x0000ADA9
		protected virtual void OnLoadError(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.LoadErrorEventArgs loadErrorArgs)
		{
		}
	}
}
