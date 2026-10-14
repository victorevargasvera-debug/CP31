using System;

namespace CefSharp.Internals
{
	// Token: 0x020000D5 RID: 213
	public interface IBrowserAdapter : global::System.IDisposable
	{
		// Token: 0x0600063A RID: 1594
		void CreateBrowser(global::CefSharp.IWindowInfo windowInfo, global::CefSharp.IBrowserSettings browserSettings, global::CefSharp.IRequestContext requestContext, string address);

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x0600063B RID: 1595
		global::CefSharp.Internals.IMethodRunnerQueue MethodRunnerQueue { get; }

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x0600063C RID: 1596
		global::CefSharp.Internals.IJavascriptObjectRepositoryInternal JavascriptObjectRepository { get; }

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x0600063D RID: 1597
		global::CefSharp.Internals.IJavascriptCallbackFactory JavascriptCallbackFactory { get; }

		// Token: 0x0600063E RID: 1598
		void OnAfterBrowserCreated(global::CefSharp.IBrowser browser);

		// Token: 0x0600063F RID: 1599
		global::CefSharp.IBrowser GetBrowser(int browserId);

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000640 RID: 1600
		bool IsDisposed { get; }

		// Token: 0x06000641 RID: 1601
		void Resize(int width, int height);
	}
}
