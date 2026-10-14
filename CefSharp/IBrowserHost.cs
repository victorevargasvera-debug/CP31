using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CefSharp.Callback;
using CefSharp.Enums;
using CefSharp.Structs;

namespace CefSharp
{
	// Token: 0x02000069 RID: 105
	public interface IBrowserHost : global::System.IDisposable
	{
		// Token: 0x0600019B RID: 411
		void AddWordToDictionary(string word);

		// Token: 0x0600019C RID: 412
		void CloseBrowser(bool forceClose);

		// Token: 0x0600019D RID: 413
		bool TryCloseBrowser();

		// Token: 0x0600019E RID: 414
		void CloseDevTools();

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600019F RID: 415
		bool HasDevTools { get; }

		// Token: 0x060001A0 RID: 416
		bool SendDevToolsMessage(string messageAsJson);

		// Token: 0x060001A1 RID: 417
		int ExecuteDevToolsMethod(int messageId, string method, string paramsAsJson);

		// Token: 0x060001A2 RID: 418
		int ExecuteDevToolsMethod(int messageId, string method, global::System.Collections.Generic.IDictionary<string, object> parameters = null);

		// Token: 0x060001A3 RID: 419
		int GetNextDevToolsMessageId();

		// Token: 0x060001A4 RID: 420
		global::CefSharp.IRegistration AddDevToolsMessageObserver(global::CefSharp.Callback.IDevToolsMessageObserver observer);

		// Token: 0x060001A5 RID: 421
		void DragTargetDragEnter(global::CefSharp.IDragData dragData, global::CefSharp.MouseEvent mouseEvent, global::CefSharp.Enums.DragOperationsMask allowedOperations);

		// Token: 0x060001A6 RID: 422
		void DragTargetDragOver(global::CefSharp.MouseEvent mouseEvent, global::CefSharp.Enums.DragOperationsMask allowedOperations);

		// Token: 0x060001A7 RID: 423
		void DragTargetDragDrop(global::CefSharp.MouseEvent mouseEvent);

		// Token: 0x060001A8 RID: 424
		void DragSourceEndedAt(int x, int y, global::CefSharp.Enums.DragOperationsMask op);

		// Token: 0x060001A9 RID: 425
		void DragTargetDragLeave();

		// Token: 0x060001AA RID: 426
		void DragSourceSystemDragEnded();

		// Token: 0x060001AB RID: 427
		void Find(string searchText, bool forward, bool matchCase, bool findNext);

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001AC RID: 428
		global::CefSharp.IExtension Extension { get; }

		// Token: 0x060001AD RID: 429
		global::System.IntPtr GetOpenerWindowHandle();

		// Token: 0x060001AE RID: 430
		global::System.IntPtr GetWindowHandle();

		// Token: 0x060001AF RID: 431
		double GetZoomLevel();

		// Token: 0x060001B0 RID: 432
		global::System.Threading.Tasks.Task<double> GetZoomLevelAsync();

		// Token: 0x060001B1 RID: 433
		void Invalidate(global::CefSharp.PaintElementType type);

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001B2 RID: 434
		bool IsBackgroundHost { get; }

		// Token: 0x060001B3 RID: 435
		void ImeSetComposition(string text, global::CefSharp.Structs.CompositionUnderline[] underlines, global::CefSharp.Structs.Range? replacementRange, global::CefSharp.Structs.Range? selectionRange);

		// Token: 0x060001B4 RID: 436
		void ImeCommitText(string text, global::CefSharp.Structs.Range? replacementRange, int relativeCursorPos);

		// Token: 0x060001B5 RID: 437
		void ImeFinishComposingText(bool keepSelection);

		// Token: 0x060001B6 RID: 438
		void ImeCancelComposition();

		// Token: 0x060001B7 RID: 439
		void NotifyMoveOrResizeStarted();

		// Token: 0x060001B8 RID: 440
		void NotifyScreenInfoChanged();

		// Token: 0x060001B9 RID: 441
		void Print();

		// Token: 0x060001BA RID: 442
		void PrintToPdf(string path, global::CefSharp.PdfPrintSettings settings, global::CefSharp.IPrintToPdfCallback callback);

		// Token: 0x060001BB RID: 443
		void ReplaceMisspelling(string word);

		// Token: 0x060001BC RID: 444
		void RunFileDialog(global::CefSharp.CefFileDialogMode mode, string title, string defaultFilePath, global::System.Collections.Generic.IList<string> acceptFilters, global::CefSharp.Callback.IRunFileDialogCallback callback);

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001BD RID: 445
		global::CefSharp.IRequestContext RequestContext { get; }

		// Token: 0x060001BE RID: 446
		void SendExternalBeginFrame();

		// Token: 0x060001BF RID: 447
		void SendCaptureLostEvent();

		// Token: 0x060001C0 RID: 448
		void SendFocusEvent(bool setFocus);

		// Token: 0x060001C1 RID: 449
		void SendKeyEvent(global::CefSharp.KeyEvent keyEvent);

		// Token: 0x060001C2 RID: 450
		void SendKeyEvent(int message, int wParam, int lParam);

		// Token: 0x060001C3 RID: 451
		void SendMouseClickEvent(global::CefSharp.MouseEvent mouseEvent, global::CefSharp.MouseButtonType mouseButtonType, bool mouseUp, int clickCount);

		// Token: 0x060001C4 RID: 452
		void SendMouseWheelEvent(global::CefSharp.MouseEvent mouseEvent, int deltaX, int deltaY);

		// Token: 0x060001C5 RID: 453
		void SendTouchEvent(global::CefSharp.Structs.TouchEvent evt);

		// Token: 0x060001C6 RID: 454
		void SetAccessibilityState(global::CefSharp.CefState accessibilityState);

		// Token: 0x060001C7 RID: 455
		void SetAutoResizeEnabled(bool enabled, global::CefSharp.Structs.Size minSize, global::CefSharp.Structs.Size maxSize);

		// Token: 0x060001C8 RID: 456
		void SetFocus(bool focus);

		// Token: 0x060001C9 RID: 457
		void SetZoomLevel(double zoomLevel);

		// Token: 0x060001CA RID: 458
		void ShowDevTools(global::CefSharp.IWindowInfo windowInfo = null, int inspectElementAtX = 0, int inspectElementAtY = 0);

		// Token: 0x060001CB RID: 459
		void StartDownload(string url);

		// Token: 0x060001CC RID: 460
		void StopFinding(bool clearSelection);

		// Token: 0x060001CD RID: 461
		void SendMouseMoveEvent(global::CefSharp.MouseEvent mouseEvent, bool mouseLeave);

		// Token: 0x060001CE RID: 462
		void WasHidden(bool hidden);

		// Token: 0x060001CF RID: 463
		void WasResized();

		// Token: 0x060001D0 RID: 464
		void GetNavigationEntries(global::CefSharp.INavigationEntryVisitor visitor, bool currentOnly);

		// Token: 0x060001D1 RID: 465
		global::CefSharp.NavigationEntry GetVisibleNavigationEntry();

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001D2 RID: 466
		// (set) Token: 0x060001D3 RID: 467
		int WindowlessFrameRate { get; set; }

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001D4 RID: 468
		bool WindowRenderingDisabled { get; }

		// Token: 0x060001D5 RID: 469
		void SetAudioMuted(bool mute);

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001D6 RID: 470
		bool IsAudioMuted { get; }

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001D7 RID: 471
		bool IsDisposed { get; }
	}
}
