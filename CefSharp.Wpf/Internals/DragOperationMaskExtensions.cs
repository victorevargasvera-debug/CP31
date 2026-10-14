using System;
using System.Windows;
using CefSharp.Enums;

namespace CefSharp.Wpf.Internals
{
	// Token: 0x02000012 RID: 18
	internal static class DragOperationMaskExtensions
	{
		// Token: 0x06000173 RID: 371 RVA: 0x00005DE0 File Offset: 0x00003FE0
		public static global::CefSharp.Enums.DragOperationsMask GetDragOperationsMask(this global::System.Windows.DragDropEffects dragDropEffects)
		{
			global::CefSharp.Enums.DragOperationsMask dragOperationsMask = global::CefSharp.Enums.DragOperationsMask.None;
			if (dragDropEffects.HasFlag(global::System.Windows.DragDropEffects.All))
			{
				dragOperationsMask |= (global::CefSharp.Enums.DragOperationsMask)4294967295U;
			}
			if (dragDropEffects.HasFlag(global::System.Windows.DragDropEffects.Copy))
			{
				dragOperationsMask |= global::CefSharp.Enums.DragOperationsMask.Copy;
			}
			if (dragDropEffects.HasFlag(global::System.Windows.DragDropEffects.Move))
			{
				dragOperationsMask |= global::CefSharp.Enums.DragOperationsMask.Move;
			}
			if (dragDropEffects.HasFlag(global::System.Windows.DragDropEffects.Link))
			{
				dragOperationsMask |= global::CefSharp.Enums.DragOperationsMask.Link;
			}
			return dragOperationsMask;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00005E51 File Offset: 0x00004051
		public static global::System.Windows.DragDropEffects GetDragEffects(this global::CefSharp.Enums.DragOperationsMask mask)
		{
			if ((mask & (global::CefSharp.Enums.DragOperationsMask)4294967295U) == (global::CefSharp.Enums.DragOperationsMask)4294967295U)
			{
				return global::System.Windows.DragDropEffects.Copy | global::System.Windows.DragDropEffects.Move | global::System.Windows.DragDropEffects.Link | global::System.Windows.DragDropEffects.Scroll;
			}
			if ((mask & global::CefSharp.Enums.DragOperationsMask.Copy) == global::CefSharp.Enums.DragOperationsMask.Copy)
			{
				return global::System.Windows.DragDropEffects.Copy;
			}
			if ((mask & global::CefSharp.Enums.DragOperationsMask.Move) == global::CefSharp.Enums.DragOperationsMask.Move)
			{
				return global::System.Windows.DragDropEffects.Move;
			}
			if ((mask & global::CefSharp.Enums.DragOperationsMask.Link) == global::CefSharp.Enums.DragOperationsMask.Link)
			{
				return global::System.Windows.DragDropEffects.Link;
			}
			return global::System.Windows.DragDropEffects.None;
		}
	}
}
