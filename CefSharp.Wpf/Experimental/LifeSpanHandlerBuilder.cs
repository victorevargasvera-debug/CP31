using System;

namespace CefSharp.Wpf.Experimental
{
	// Token: 0x02000025 RID: 37
	public class LifeSpanHandlerBuilder
	{
		// Token: 0x060001DB RID: 475 RVA: 0x00006F90 File Offset: 0x00005190
		public LifeSpanHandlerBuilder(global::CefSharp.Wpf.Experimental.LifeSpanHandlerCreatePopupChromiumWebBrowser chromiumWebBrowserCreatedDelegate)
		{
			this.handler = new global::CefSharp.Wpf.Experimental.LifeSpanHandler(chromiumWebBrowserCreatedDelegate);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00006FA4 File Offset: 0x000051A4
		public global::CefSharp.Wpf.Experimental.LifeSpanHandlerBuilder OnBeforePopupCreated(global::CefSharp.Wpf.Experimental.LifeSpanHandlerOnBeforePopupCreatedDelegate onBeforePopupCreated)
		{
			this.handler.OnBeforePopupCreated(onBeforePopupCreated);
			return this;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00006FB4 File Offset: 0x000051B4
		public global::CefSharp.Wpf.Experimental.LifeSpanHandlerBuilder OnPopupCreated(global::CefSharp.Wpf.Experimental.LifeSpanHandlerOnPopupCreatedDelegate onPopupCreated)
		{
			this.handler.OnPopupCreated(onPopupCreated);
			return this;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00006FC4 File Offset: 0x000051C4
		public global::CefSharp.Wpf.Experimental.LifeSpanHandlerBuilder OnPopupBrowserCreated(global::CefSharp.Wpf.Experimental.LifeSpanHandlerOnPopupBrowserCreatedDelegate onPopupBrowserCreated)
		{
			this.handler.OnPopupBrowserCreated(onPopupBrowserCreated);
			return this;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00006FD4 File Offset: 0x000051D4
		public global::CefSharp.Wpf.Experimental.LifeSpanHandlerBuilder OnPopupDestroyed(global::CefSharp.Wpf.Experimental.LifeSpanHandlerOnPopupDestroyedDelegate onPopupDestroyed)
		{
			this.handler.OnPopupDestroyed(onPopupDestroyed);
			return this;
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00006FE4 File Offset: 0x000051E4
		public global::CefSharp.ILifeSpanHandler Build()
		{
			return this.handler;
		}

		// Token: 0x0400019A RID: 410
		private readonly global::CefSharp.Wpf.Experimental.LifeSpanHandler handler;
	}
}
