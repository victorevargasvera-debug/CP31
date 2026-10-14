using System;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace Infragistics.Windows.DockManager
{
	// Token: 0x020000D1 RID: 209
	internal static class ThumbDragService
	{
		// Token: 0x060006CD RID: 1741 RVA: 0x0001FD40 File Offset: 0x0001DF40
		static ThumbDragService()
		{
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::System.Windows.Controls.Primitives.Thumb), global::System.Windows.Controls.Primitives.Thumb.DragStartedEvent, new global::System.Windows.Controls.Primitives.DragStartedEventHandler(global::Infragistics.Windows.DockManager.ThumbDragService.OnThumbDragStarted));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::System.Windows.Controls.Primitives.Thumb), global::System.Windows.Controls.Primitives.Thumb.DragCompletedEvent, new global::System.Windows.Controls.Primitives.DragCompletedEventHandler(global::Infragistics.Windows.DockManager.ThumbDragService.OnThumbDragCompleted));
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x0001FDBA File Offset: 0x0001DFBA
		public static bool GetCancelThumbDragOnEscape(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.DockManager.ThumbDragService.CancelThumbDragOnEscapeProperty);
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x0001FDCC File Offset: 0x0001DFCC
		public static void SetCancelThumbDragOnEscape(global::System.Windows.DependencyObject d, bool value)
		{
			d.SetValue(global::Infragistics.Windows.DockManager.ThumbDragService.CancelThumbDragOnEscapeProperty, value);
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x0001FDDF File Offset: 0x0001DFDF
		private static void OnFocusedElementPreviewKeyUp(object sender, global::System.Windows.Input.KeyEventArgs e)
		{
			e.Handled = true;
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x0001FDE8 File Offset: 0x0001DFE8
		private static void OnFocusedElementChanged(object sender, global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.ThumbDragService.UnhookElement(e.OldFocus);
			global::System.Windows.Controls.Primitives.Thumb thumb = global::System.Windows.Input.Mouse.Captured as global::System.Windows.Controls.Primitives.Thumb;
			if (thumb != null && global::Infragistics.Windows.DockManager.ThumbDragService.GetCancelThumbDragOnEscape(thumb))
			{
				global::Infragistics.Windows.DockManager.ThumbDragService.HookElement(e.NewFocus);
			}
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x0001FE24 File Offset: 0x0001E024
		private static void OnFocusedElementPreviewKeyDown(object sender, global::System.Windows.Input.KeyEventArgs e)
		{
			if (e.Key == global::System.Windows.Input.Key.Escape)
			{
				global::System.Windows.Controls.Primitives.Thumb thumb = global::System.Windows.Input.Mouse.Captured as global::System.Windows.Controls.Primitives.Thumb;
				if (thumb != null)
				{
					thumb.ReleaseMouseCapture();
					return;
				}
			}
			else
			{
				e.Handled = true;
			}
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x0001FE57 File Offset: 0x0001E057
		private static void HookElement(global::System.Windows.IInputElement element)
		{
			if (element != null)
			{
				element.LostKeyboardFocus += global::Infragistics.Windows.DockManager.ThumbDragService.OnFocusedElementChanged;
				element.PreviewKeyDown += global::Infragistics.Windows.DockManager.ThumbDragService.OnFocusedElementPreviewKeyDown;
				element.PreviewKeyUp += global::Infragistics.Windows.DockManager.ThumbDragService.OnFocusedElementPreviewKeyUp;
			}
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x0001FE92 File Offset: 0x0001E092
		private static void UnhookElement(global::System.Windows.IInputElement element)
		{
			if (element != null)
			{
				element.LostKeyboardFocus -= global::Infragistics.Windows.DockManager.ThumbDragService.OnFocusedElementChanged;
				element.PreviewKeyDown -= global::Infragistics.Windows.DockManager.ThumbDragService.OnFocusedElementPreviewKeyDown;
				element.PreviewKeyUp -= global::Infragistics.Windows.DockManager.ThumbDragService.OnFocusedElementPreviewKeyUp;
			}
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x0001FECD File Offset: 0x0001E0CD
		private static void OnThumbDragCompleted(object sender, global::System.Windows.Controls.Primitives.DragCompletedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.ThumbDragService.UnhookElement(global::System.Windows.Input.Keyboard.FocusedElement);
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x0001FEDC File Offset: 0x0001E0DC
		private static void OnThumbDragStarted(object sender, global::System.Windows.Controls.Primitives.DragStartedEventArgs e)
		{
			global::System.Windows.Controls.Primitives.Thumb thumb = e.OriginalSource as global::System.Windows.Controls.Primitives.Thumb;
			if (thumb != null && global::Infragistics.Windows.DockManager.ThumbDragService.GetCancelThumbDragOnEscape(thumb))
			{
				global::Infragistics.Windows.DockManager.ThumbDragService.HookElement(global::System.Windows.Input.Keyboard.FocusedElement);
			}
		}

		// Token: 0x040003AC RID: 940
		public static readonly global::System.Windows.DependencyProperty CancelThumbDragOnEscapeProperty = global::System.Windows.DependencyProperty.RegisterAttached("CancelThumbDragOnEscape", typeof(bool), typeof(global::Infragistics.Windows.DockManager.ThumbDragService), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
	}
}
