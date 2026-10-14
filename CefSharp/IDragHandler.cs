using System;
using System.Collections.Generic;
using CefSharp.Enums;

namespace CefSharp
{
	// Token: 0x02000058 RID: 88
	public interface IDragHandler
	{
		// Token: 0x06000142 RID: 322
		bool OnDragEnter(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IDragData dragData, global::CefSharp.Enums.DragOperationsMask mask);

		// Token: 0x06000143 RID: 323
		void OnDraggableRegionsChanged(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::System.Collections.Generic.IList<global::CefSharp.DraggableRegion> regions);
	}
}
