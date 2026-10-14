using System;
using CefSharp.Enums;
using CefSharp.Structs;

namespace CefSharp.Internals
{
	// Token: 0x020000DD RID: 221
	public interface IRenderWebBrowser : global::CefSharp.Internals.IWebBrowserInternal, global::CefSharp.IWebBrowser, global::CefSharp.IChromiumWebBrowserBase, global::System.IDisposable
	{
		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000663 RID: 1635
		// (set) Token: 0x06000664 RID: 1636
		global::CefSharp.IAccessibilityHandler AccessibilityHandler { get; set; }

		// Token: 0x06000665 RID: 1637
		global::CefSharp.Structs.ScreenInfo? GetScreenInfo();

		// Token: 0x06000666 RID: 1638
		global::CefSharp.Structs.Rect GetViewRect();

		// Token: 0x06000667 RID: 1639
		bool GetScreenPoint(int viewX, int viewY, out int screenX, out int screenY);

		// Token: 0x06000668 RID: 1640
		void OnAcceleratedPaint(global::CefSharp.PaintElementType type, global::CefSharp.Structs.Rect dirtyRect, global::System.IntPtr sharedHandle);

		// Token: 0x06000669 RID: 1641
		void OnPaint(global::CefSharp.PaintElementType type, global::CefSharp.Structs.Rect dirtyRect, global::System.IntPtr buffer, int width, int height);

		// Token: 0x0600066A RID: 1642
		void OnCursorChange(global::System.IntPtr cursor, global::CefSharp.Enums.CursorType type, global::CefSharp.Structs.CursorInfo customCursorInfo);

		// Token: 0x0600066B RID: 1643
		bool StartDragging(global::CefSharp.IDragData dragData, global::CefSharp.Enums.DragOperationsMask mask, int x, int y);

		// Token: 0x0600066C RID: 1644
		void UpdateDragCursor(global::CefSharp.Enums.DragOperationsMask operation);

		// Token: 0x0600066D RID: 1645
		void OnPopupShow(bool show);

		// Token: 0x0600066E RID: 1646
		void OnPopupSize(global::CefSharp.Structs.Rect rect);

		// Token: 0x0600066F RID: 1647
		void OnImeCompositionRangeChanged(global::CefSharp.Structs.Range selectedRange, global::CefSharp.Structs.Rect[] characterBounds);

		// Token: 0x06000670 RID: 1648
		void OnVirtualKeyboardRequested(global::CefSharp.IBrowser browser, global::CefSharp.Enums.TextInputMode inputMode);
	}
}
