using System;
using System.Security;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000194 RID: 404
	public static class PopupHelper
	{
		// Token: 0x06000D7A RID: 3450 RVA: 0x0002B0DC File Offset: 0x000292DC
		static PopupHelper()
		{
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::System.Windows.Controls.Primitives.Popup), global::System.Windows.Input.Mouse.PreviewMouseUpEvent, new global::System.Windows.Input.MouseButtonEventHandler(global::Infragistics.Windows.Controls.PopupHelper.OnPopupPreviewMouseUp));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::System.Windows.Controls.Primitives.Popup), global::System.Windows.Input.Mouse.PreviewMouseDownEvent, new global::System.Windows.Input.MouseButtonEventHandler(global::Infragistics.Windows.Controls.PopupHelper.OnPopupPreviewMouseDown));
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x0002B198 File Offset: 0x00029398
		private static void OnDropDownButtonChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Controls.Primitives.Popup popup = d as global::System.Windows.Controls.Primitives.Popup;
			if (popup != null)
			{
				if (e.NewValue == null)
				{
					popup.Opened -= global::Infragistics.Windows.Controls.PopupHelper.OnPopupOpened;
					return;
				}
				popup.Opened += global::Infragistics.Windows.Controls.PopupHelper.OnPopupOpened;
			}
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x0002B1DD File Offset: 0x000293DD
		[global::System.Windows.AttachedPropertyBrowsableForType(typeof(global::System.Windows.Controls.Primitives.Popup))]
		public static global::System.Windows.Controls.Primitives.ButtonBase GetDropDownButton(global::System.Windows.DependencyObject d)
		{
			return (global::System.Windows.Controls.Primitives.ButtonBase)d.GetValue(global::Infragistics.Windows.Controls.PopupHelper.DropDownButtonProperty);
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x0002B1EF File Offset: 0x000293EF
		public static void SetDropDownButton(global::System.Windows.DependencyObject d, global::System.Windows.Controls.Primitives.ButtonBase value)
		{
			d.SetValue(global::Infragistics.Windows.Controls.PopupHelper.DropDownButtonProperty, value);
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x0002B200 File Offset: 0x00029400
		private static void OnHandleMouseDownOnCloseChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Controls.Primitives.Popup popup = d as global::System.Windows.Controls.Primitives.Popup;
			if (popup != null)
			{
				if (true.Equals(e.NewValue))
				{
					popup.PreviewMouseDown += global::Infragistics.Windows.Controls.PopupHelper.OnPopupPreviewMouseDownInstance;
					return;
				}
				popup.PreviewMouseDown -= global::Infragistics.Windows.Controls.PopupHelper.OnPopupPreviewMouseDownInstance;
			}
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x0002B24E File Offset: 0x0002944E
		public static bool GetHandleMouseDownOnClose(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.Controls.PopupHelper.HandleMouseDownOnCloseProperty);
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x0002B260 File Offset: 0x00029460
		public static void SetHandleMouseDownOnClose(global::System.Windows.DependencyObject d, bool value)
		{
			d.SetValue(global::Infragistics.Windows.Controls.PopupHelper.HandleMouseDownOnCloseProperty, value);
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000D81 RID: 3457 RVA: 0x0002B273 File Offset: 0x00029473
		internal static bool IsPopupInChildWindow
		{
			get
			{
				return !global::Infragistics.Windows.Controls.PopupHelper.PopupAllowsTransparency;
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000D82 RID: 3458 RVA: 0x0002B280 File Offset: 0x00029480
		internal static bool PopupAllowsTransparency
		{
			get
			{
				if (global::Infragistics.Windows.Controls.PopupHelper._popupAllowsTransparency == null)
				{
					global::System.Windows.Controls.Primitives.Popup popup = new global::System.Windows.Controls.Primitives.Popup();
					popup.AllowsTransparency = true;
					popup.CoerceValue(global::System.Windows.Controls.Primitives.Popup.AllowsTransparencyProperty);
					global::Infragistics.Windows.Controls.PopupHelper._popupAllowsTransparency = new bool?(popup.AllowsTransparency);
				}
				return global::Infragistics.Windows.Controls.PopupHelper._popupAllowsTransparency.Value;
			}
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x0002B2CC File Offset: 0x000294CC
		public static void BringToFront(global::System.Windows.Controls.Primitives.Popup popup)
		{
			global::Infragistics.Windows.Utilities.ThrowIfNull(popup, "popup");
			if (!popup.IsOpen)
			{
				return;
			}
			try
			{
				global::Infragistics.Windows.Controls.PopupController.BringToFront(popup);
			}
			catch (global::System.Security.SecurityException)
			{
			}
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x0002B308 File Offset: 0x00029508
		private static void OnPopupOpened(object sender, global::System.EventArgs e)
		{
			global::System.Windows.Controls.Primitives.Popup popup = (global::System.Windows.Controls.Primitives.Popup)sender;
			global::System.Windows.Controls.Primitives.ButtonBase dropDownButton = global::Infragistics.Windows.Controls.PopupHelper.GetDropDownButton(popup);
			if (dropDownButton != null && dropDownButton.IsMouseCaptureWithin && !popup.StaysOpen)
			{
				dropDownButton.ReleaseMouseCapture();
				popup.StaysOpen = true;
				popup.StaysOpen = false;
			}
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x0002B34C File Offset: 0x0002954C
		private static void OnPopupPreviewMouseUp(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			global::System.Windows.Controls.Primitives.Popup popup = sender as global::System.Windows.Controls.Primitives.Popup;
			global::System.Windows.Controls.Primitives.ButtonBase dropDownButton = global::Infragistics.Windows.Controls.PopupHelper.GetDropDownButton(popup);
			if (dropDownButton != null && popup.IsOpen && !popup.StaysOpen && dropDownButton.ClickMode == global::System.Windows.Controls.ClickMode.Press)
			{
				global::System.Windows.Media.HitTestResult hitTestResult = global::System.Windows.Media.VisualTreeHelper.HitTest(dropDownButton, e.GetPosition(dropDownButton));
				if (hitTestResult != null && hitTestResult.VisualHit != null && dropDownButton.IsAncestorOf(hitTestResult.VisualHit))
				{
					e.Handled = true;
				}
			}
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x0002B3B4 File Offset: 0x000295B4
		private static void OnPopupPreviewMouseDown(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			global::System.Windows.Controls.Primitives.Popup popup = sender as global::System.Windows.Controls.Primitives.Popup;
			global::System.Windows.Controls.Primitives.ButtonBase dropDownButton = global::Infragistics.Windows.Controls.PopupHelper.GetDropDownButton(popup);
			if (dropDownButton != null && popup.IsOpen && !popup.StaysOpen && dropDownButton.ClickMode != global::System.Windows.Controls.ClickMode.Hover)
			{
				global::System.Windows.Media.HitTestResult hitTestResult = global::System.Windows.Media.VisualTreeHelper.HitTest(dropDownButton, e.GetPosition(dropDownButton));
				if (hitTestResult != null && hitTestResult.VisualHit != null && dropDownButton.IsAncestorOf(hitTestResult.VisualHit))
				{
					if (dropDownButton.ClickMode == global::System.Windows.Controls.ClickMode.Press)
					{
						popup.IsOpen = false;
					}
					e.Handled = true;
				}
			}
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x0002B42C File Offset: 0x0002962C
		private static void OnPopupPreviewMouseDownInstance(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			global::System.Windows.Controls.Primitives.Popup popup = sender as global::System.Windows.Controls.Primitives.Popup;
			if (!popup.IsOpen && global::Infragistics.Windows.Controls.PopupHelper.GetHandleMouseDownOnClose(popup))
			{
				e.Handled = true;
			}
		}

		// Token: 0x040006E9 RID: 1769
		[global::System.ThreadStatic]
		private static bool? _popupAllowsTransparency;

		// Token: 0x040006EA RID: 1770
		public static readonly global::System.Windows.DependencyProperty DropDownButtonProperty = global::System.Windows.DependencyProperty.RegisterAttached("DropDownButton", typeof(global::System.Windows.Controls.Primitives.ButtonBase), typeof(global::Infragistics.Windows.Controls.PopupHelper), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.PopupHelper.OnDropDownButtonChanged)));

		// Token: 0x040006EB RID: 1771
		public static readonly global::System.Windows.DependencyProperty HandleMouseDownOnCloseProperty = global::System.Windows.DependencyProperty.RegisterAttached("HandleMouseDownOnClose", typeof(bool), typeof(global::Infragistics.Windows.Controls.PopupHelper), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.PopupHelper.OnHandleMouseDownOnCloseChanged)));
	}
}
