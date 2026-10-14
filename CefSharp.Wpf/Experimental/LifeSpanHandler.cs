using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Interop;
using CefSharp.Handler;

namespace CefSharp.Wpf.Experimental
{
	// Token: 0x02000024 RID: 36
	public class LifeSpanHandler : global::CefSharp.Handler.LifeSpanHandler
	{
		// Token: 0x060001D2 RID: 466 RVA: 0x00006DA0 File Offset: 0x00004FA0
		public LifeSpanHandler(global::CefSharp.Wpf.Experimental.LifeSpanHandlerCreatePopupChromiumWebBrowser chromiumWebBrowserCreatedDelegate = null)
		{
			this.chromiumWebBrowserCreatedDelegate = chromiumWebBrowserCreatedDelegate;
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00006DBA File Offset: 0x00004FBA
		public global::CefSharp.Wpf.Experimental.LifeSpanHandler OnBeforePopupCreated(global::CefSharp.Wpf.Experimental.LifeSpanHandlerOnBeforePopupCreatedDelegate onBeforePopupCreated)
		{
			this.onBeforePopupCreated = onBeforePopupCreated;
			return this;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00006DC4 File Offset: 0x00004FC4
		public global::CefSharp.Wpf.Experimental.LifeSpanHandler OnPopupCreated(global::CefSharp.Wpf.Experimental.LifeSpanHandlerOnPopupCreatedDelegate onPopupCreated)
		{
			this.onPopupCreated = onPopupCreated;
			return this;
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00006DCE File Offset: 0x00004FCE
		public global::CefSharp.Wpf.Experimental.LifeSpanHandler OnPopupBrowserCreated(global::CefSharp.Wpf.Experimental.LifeSpanHandlerOnPopupBrowserCreatedDelegate onPopupBrowserCreated)
		{
			this.onPopupBrowserCreated = onPopupBrowserCreated;
			return this;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00006DD8 File Offset: 0x00004FD8
		public global::CefSharp.Wpf.Experimental.LifeSpanHandler OnPopupDestroyed(global::CefSharp.Wpf.Experimental.LifeSpanHandlerOnPopupDestroyedDelegate onPopupDestroyed)
		{
			this.onPopupDestroyed = onPopupDestroyed;
			return this;
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00006DE2 File Offset: 0x00004FE2
		public static global::CefSharp.Wpf.Experimental.LifeSpanHandlerBuilder Create(global::CefSharp.Wpf.Experimental.LifeSpanHandlerCreatePopupChromiumWebBrowser chromiumWebBrowserCreatedDelegate = null)
		{
			return new global::CefSharp.Wpf.Experimental.LifeSpanHandlerBuilder(chromiumWebBrowserCreatedDelegate);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00006DEC File Offset: 0x00004FEC
		protected override bool OnBeforePopup(global::CefSharp.IWebBrowser browserControl, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, string targetUrl, string targetFrameName, global::CefSharp.WindowOpenDisposition targetDisposition, bool userGesture, global::CefSharp.IPopupFeatures popupFeatures, global::CefSharp.IWindowInfo windowInfo, global::CefSharp.IBrowserSettings browserSettings, ref bool noJavascriptAccess, out global::CefSharp.IWebBrowser newBrowser)
		{
			newBrowser = null;
			global::CefSharp.Wpf.Experimental.LifeSpanHandlerOnBeforePopupCreatedDelegate lifeSpanHandlerOnBeforePopupCreatedDelegate = this.onBeforePopupCreated;
			global::CefSharp.Wpf.Experimental.PopupCreation popupCreation = (lifeSpanHandlerOnBeforePopupCreatedDelegate != null) ? lifeSpanHandlerOnBeforePopupCreatedDelegate(browserControl, browser, frame, targetUrl, targetFrameName, targetDisposition, userGesture, browserSettings) : global::CefSharp.Wpf.Experimental.PopupCreation.Continue;
			if (popupCreation == global::CefSharp.Wpf.Experimental.PopupCreation.Cancel)
			{
				return true;
			}
			if (popupCreation == global::CefSharp.Wpf.Experimental.PopupCreation.ContinueWithJavascriptDisabled)
			{
				noJavascriptAccess = true;
			}
			if (this.onPopupCreated == null)
			{
				return false;
			}
			global::CefSharp.Wpf.ChromiumWebBrowser chromiumWebBrowser = (global::CefSharp.Wpf.ChromiumWebBrowser)browserControl;
			global::CefSharp.Wpf.ChromiumWebBrowser control = null;
			chromiumWebBrowser.Dispatcher.Invoke(delegate()
			{
				global::CefSharp.Wpf.Experimental.LifeSpanHandlerCreatePopupChromiumWebBrowser lifeSpanHandlerCreatePopupChromiumWebBrowser = this.chromiumWebBrowserCreatedDelegate;
				control = ((lifeSpanHandlerCreatePopupChromiumWebBrowser != null) ? lifeSpanHandlerCreatePopupChromiumWebBrowser() : null);
				if (control == null)
				{
					control = new global::CefSharp.Wpf.ChromiumWebBrowser();
				}
				control.SetAsPopup();
				control.LifeSpanHandler = this;
				this.pendingChromiumWebBrowser = control;
				global::CefSharp.Wpf.Experimental.LifeSpanHandlerOnPopupCreatedDelegate lifeSpanHandlerOnPopupCreatedDelegate = this.onPopupCreated;
				if (lifeSpanHandlerOnPopupCreatedDelegate != null)
				{
					lifeSpanHandlerOnPopupCreatedDelegate(control, targetUrl, targetFrameName, windowInfo);
				}
				global::System.Windows.Window window = global::System.Windows.Window.GetWindow(control);
				if (window == null)
				{
					windowInfo.SetAsWindowless(global::System.IntPtr.Zero);
					return;
				}
				global::System.Windows.Interop.WindowInteropHelper windowInteropHelper = new global::System.Windows.Interop.WindowInteropHelper(window);
				global::System.IntPtr asWindowless = windowInteropHelper.EnsureHandle();
				windowInfo.SetAsWindowless(asWindowless);
			});
			newBrowser = control;
			return false;
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00006E90 File Offset: 0x00005090
		protected override void OnAfterCreated(global::CefSharp.IWebBrowser browserControl, global::CefSharp.IBrowser browser)
		{
			if (browser.IsPopup && this.pendingChromiumWebBrowser != null)
			{
				this.chromiumWebBrowserMap.Add(browser.GetHost().GetWindowHandle(), this.pendingChromiumWebBrowser);
				global::CefSharp.Wpf.Experimental.LifeSpanHandlerOnPopupBrowserCreatedDelegate lifeSpanHandlerOnPopupBrowserCreatedDelegate = this.onPopupBrowserCreated;
				if (lifeSpanHandlerOnPopupBrowserCreatedDelegate != null)
				{
					lifeSpanHandlerOnPopupBrowserCreatedDelegate(this.pendingChromiumWebBrowser, browser);
				}
				this.pendingChromiumWebBrowser = null;
			}
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00006EE8 File Offset: 0x000050E8
		protected override bool DoClose(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser)
		{
			if (browser.IsPopup && !browser.IsDisposed)
			{
				global::System.IntPtr windowHandle = browser.GetHost().GetWindowHandle();
				global::CefSharp.Wpf.ChromiumWebBrowser control;
				if (this.chromiumWebBrowserMap.TryGetValue(windowHandle, out control))
				{
					if (control == null)
					{
						return false;
					}
					if (!control.Dispatcher.HasShutdownStarted)
					{
						control.Dispatcher.Invoke(delegate()
						{
							global::CefSharp.Wpf.Experimental.LifeSpanHandlerOnPopupDestroyedDelegate lifeSpanHandlerOnPopupDestroyedDelegate = this.onPopupDestroyed;
							if (lifeSpanHandlerOnPopupDestroyedDelegate != null)
							{
								lifeSpanHandlerOnPopupDestroyedDelegate(control, browser);
							}
							if (!control.IsDisposed)
							{
								control.Dispose();
							}
						});
					}
					this.chromiumWebBrowserMap.Remove(windowHandle);
					return true;
				}
			}
			return false;
		}

		// Token: 0x04000193 RID: 403
		private global::CefSharp.Wpf.Experimental.LifeSpanHandlerOnBeforePopupCreatedDelegate onBeforePopupCreated;

		// Token: 0x04000194 RID: 404
		private global::CefSharp.Wpf.Experimental.LifeSpanHandlerOnPopupDestroyedDelegate onPopupDestroyed;

		// Token: 0x04000195 RID: 405
		private global::CefSharp.Wpf.Experimental.LifeSpanHandlerOnPopupBrowserCreatedDelegate onPopupBrowserCreated;

		// Token: 0x04000196 RID: 406
		private global::CefSharp.Wpf.Experimental.LifeSpanHandlerOnPopupCreatedDelegate onPopupCreated;

		// Token: 0x04000197 RID: 407
		private global::CefSharp.Wpf.Experimental.LifeSpanHandlerCreatePopupChromiumWebBrowser chromiumWebBrowserCreatedDelegate;

		// Token: 0x04000198 RID: 408
		private global::System.Collections.Generic.Dictionary<global::System.IntPtr, global::CefSharp.Wpf.ChromiumWebBrowser> chromiumWebBrowserMap = new global::System.Collections.Generic.Dictionary<global::System.IntPtr, global::CefSharp.Wpf.ChromiumWebBrowser>();

		// Token: 0x04000199 RID: 409
		private global::CefSharp.Wpf.ChromiumWebBrowser pendingChromiumWebBrowser;
	}
}
