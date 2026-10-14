using System;

namespace CefSharp.Internals
{
	// Token: 0x020000DF RID: 223
	public interface IWebBrowserInternal : global::CefSharp.IWebBrowser, global::CefSharp.IChromiumWebBrowserBase, global::System.IDisposable
	{
		// Token: 0x06000672 RID: 1650
		void OnAfterBrowserCreated(global::CefSharp.IBrowser browser);

		// Token: 0x06000673 RID: 1651
		void SetAddress(global::CefSharp.AddressChangedEventArgs args);

		// Token: 0x06000674 RID: 1652
		void SetLoadingStateChange(global::CefSharp.LoadingStateChangedEventArgs args);

		// Token: 0x06000675 RID: 1653
		void SetTitle(global::CefSharp.TitleChangedEventArgs args);

		// Token: 0x06000676 RID: 1654
		void SetTooltipText(string tooltipText);

		// Token: 0x06000677 RID: 1655
		void SetCanExecuteJavascriptOnMainFrame(long frameId, bool canExecute);

		// Token: 0x06000678 RID: 1656
		void SetJavascriptMessageReceived(global::CefSharp.JavascriptMessageReceivedEventArgs args);

		// Token: 0x06000679 RID: 1657
		void OnFrameLoadStart(global::CefSharp.FrameLoadStartEventArgs args);

		// Token: 0x0600067A RID: 1658
		void OnFrameLoadEnd(global::CefSharp.FrameLoadEndEventArgs args);

		// Token: 0x0600067B RID: 1659
		void OnConsoleMessage(global::CefSharp.ConsoleMessageEventArgs args);

		// Token: 0x0600067C RID: 1660
		void OnStatusMessage(global::CefSharp.StatusMessageEventArgs args);

		// Token: 0x0600067D RID: 1661
		void OnLoadError(global::CefSharp.LoadErrorEventArgs args);

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x0600067E RID: 1662
		global::CefSharp.Internals.IBrowserAdapter BrowserAdapter { get; }

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x0600067F RID: 1663
		// (set) Token: 0x06000680 RID: 1664
		bool HasParent { get; set; }

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000681 RID: 1665
		// (set) Token: 0x06000682 RID: 1666
		global::System.IDisposable DevToolsContext { get; set; }
	}
}
