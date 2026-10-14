using System;
using System.Security;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;

namespace Infragistics.Windows.Controls
{
	// Token: 0x020001BB RID: 443
	public static class PopupHelper
	{
		// Token: 0x06000ECD RID: 3789 RVA: 0x0002F93C File Offset: 0x0002DB3C
		static PopupHelper()
		{
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::System.Windows.Controls.Primitives.Popup), global::System.Windows.Input.Mouse.PreviewMouseUpEvent, new global::System.Windows.Input.MouseButtonEventHandler(global::Infragistics.Windows.Controls.PopupHelper.OnPopupPreviewMouseUp));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::System.Windows.Controls.Primitives.Popup), global::System.Windows.Input.Mouse.PreviewMouseDownEvent, new global::System.Windows.Input.MouseButtonEventHandler(global::Infragistics.Windows.Controls.PopupHelper.OnPopupPreviewMouseDown));
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x0002F9F8 File Offset: 0x0002DBF8
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

		// Token: 0x06000ECF RID: 3791 RVA: 0x0002FA3D File Offset: 0x0002DC3D
		[global::System.Windows.AttachedPropertyBrowsableForType(typeof(global::System.Windows.Controls.Primitives.Popup))]
		public static global::System.Windows.Controls.Primitives.ButtonBase GetDropDownButton(global::System.Windows.DependencyObject d)
		{
			return (global::System.Windows.Controls.Primitives.ButtonBase)d.GetValue(global::Infragistics.Windows.Controls.PopupHelper.DropDownButtonProperty);
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x0002FA4F File Offset: 0x0002DC4F
		public static void SetDropDownButton(global::System.Windows.DependencyObject d, global::System.Windows.Controls.Primitives.ButtonBase value)
		{
			d.SetValue(global::Infragistics.Windows.Controls.PopupHelper.DropDownButtonProperty, value);
		}

		// Token: 0x06000ED1 RID: 3793 RVA: 0x0002FA60 File Offset: 0x0002DC60
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

		// Token: 0x06000ED2 RID: 3794 RVA: 0x0002FAAE File Offset: 0x0002DCAE
		public static bool GetHandleMouseDownOnClose(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.Controls.PopupHelper.HandleMouseDownOnCloseProperty);
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x0002FAC0 File Offset: 0x0002DCC0
		public static void SetHandleMouseDownOnClose(global::System.Windows.DependencyObject d, bool value)
		{
			d.SetValue(global::Infragistics.Windows.Controls.PopupHelper.HandleMouseDownOnCloseProperty, value);
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000ED4 RID: 3796 RVA: 0x0002FAD3 File Offset: 0x0002DCD3
		internal static bool IsPopupInChildWindow
		{
			get
			{
				return !global::Infragistics.Windows.Controls.PopupHelper.PopupAllowsTransparency;
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000ED5 RID: 3797 RVA: 0x0002FAE0 File Offset: 0x0002DCE0
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

		// Token: 0x06000ED6 RID: 3798 RVA: 0x0002FB2C File Offset: 0x0002DD2C
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

		// Token: 0x06000ED7 RID: 3799 RVA: 0x0002FB68 File Offset: 0x0002DD68
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

		// Token: 0x06000ED8 RID: 3800 RVA: 0x0002FBAC File Offset: 0x0002DDAC
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

		// Token: 0x06000ED9 RID: 3801 RVA: 0x0002FC14 File Offset: 0x0002DE14
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

		// Token: 0x06000EDA RID: 3802 RVA: 0x0002FC8C File Offset: 0x0002DE8C
		private static void OnPopupPreviewMouseDownInstance(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			global::System.Windows.Controls.Primitives.Popup popup = sender as global::System.Windows.Controls.Primitives.Popup;
			if (!popup.IsOpen && global::Infragistics.Windows.Controls.PopupHelper.GetHandleMouseDownOnClose(popup))
			{
				e.Handled = true;
			}
		}

		// Token: 0x04000813 RID: 2067
		[global::System.ThreadStatic]
		private static bool? _popupAllowsTransparency;

		// Token: 0x04000814 RID: 2068
		public static readonly global::System.Windows.DependencyProperty DropDownButtonProperty = global::System.Windows.DependencyProperty.RegisterAttached("DropDownButton", typeof(global::System.Windows.Controls.Primitives.ButtonBase), typeof(global::Infragistics.Windows.Controls.PopupHelper), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.PopupHelper.OnDropDownButtonChanged)));

		// Token: 0x04000815 RID: 2069
		public static readonly global::System.Windows.DependencyProperty HandleMouseDownOnCloseProperty = global::System.Windows.DependencyProperty.RegisterAttached("HandleMouseDownOnClose", typeof(bool), typeof(global::Infragistics.Windows.Controls.PopupHelper), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.PopupHelper.OnHandleMouseDownOnCloseChanged)));
	}
}
