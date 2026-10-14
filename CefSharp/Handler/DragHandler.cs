using System;
using System.Collections.Generic;
using CefSharp.Enums;

namespace CefSharp.Handler
{
	// Token: 0x02000107 RID: 263
	public class DragHandler : global::CefSharp.IDragHandler
	{
		// Token: 0x060007C1 RID: 1985 RVA: 0x0000C888 File Offset: 0x0000AA88
		bool global::CefSharp.IDragHandler.OnDragEnter(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IDragData dragData, global::CefSharp.Enums.DragOperationsMask mask)
		{
			return this.OnDragEnter(chromiumWebBrowser, browser, dragData, mask);
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x0000C895 File Offset: 0x0000AA95
		protected virtual bool OnDragEnter(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IDragData dragData, global::CefSharp.Enums.DragOperationsMask mask)
		{
			return false;
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x0000C898 File Offset: 0x0000AA98
		void global::CefSharp.IDragHandler.OnDraggableRegionsChanged(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::System.Collections.Generic.IList<global::CefSharp.DraggableRegion> regions)
		{
			this.OnDraggableRegionsChanged(chromiumWebBrowser, browser, frame, regions);
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x0000C8A5 File Offset: 0x0000AAA5
		protected virtual void OnDraggableRegionsChanged(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::System.Collections.Generic.IList<global::CefSharp.DraggableRegion> regions)
		{
		}
	}
}
