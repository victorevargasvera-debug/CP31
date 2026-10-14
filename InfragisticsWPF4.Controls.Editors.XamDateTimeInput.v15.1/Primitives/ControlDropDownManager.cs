using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using Infragistics.Windows.Controls;

namespace Infragistics.Controls.Primitives
{
	// Token: 0x02000002 RID: 2
	internal class ControlDropDownManager
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000020D0 File Offset: 0x000002D0
		internal ControlDropDownManager(global::System.Windows.Controls.Control owningControl, global::System.Windows.Controls.Primitives.Popup popup, global::System.Windows.Controls.Primitives.ToggleButton button, global::System.Action openAction, global::System.Action closeAction, global::System.Windows.Controls.Decorator chrome) : this(owningControl, popup, button, false, openAction, closeAction, chrome)
		{
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000020E4 File Offset: 0x000002E4
		internal ControlDropDownManager(global::System.Windows.Controls.Control owningControl, global::System.Windows.Controls.Primitives.Popup popup, global::System.Windows.Controls.Primitives.ToggleButton button, bool staysOpen, global::System.Action openAction, global::System.Action closeAction, global::System.Windows.Controls.Decorator chrome)
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(owningControl, "owningControl");
			global::Infragistics.CoreUtilities.ValidateNotNull(popup, "popup");
			this._owningControl = owningControl;
			this._popup = popup;
			this._popup.Opened += this.OnPopupOpened;
			this._popup.Closed += this.OnPopupClosed;
			this._button = button;
			this._openAction = openAction;
			this._closeAction = closeAction;
			this._popup.StaysOpen = staysOpen;
			if (this._button != null)
			{
				global::Infragistics.Windows.Controls.PopupHelper.SetDropDownButton(this._popup, this._button);
			}
			global::Infragistics.Controls.Primitives.ControlDropDownManager.InitializeIfNotDefault(this._popup, global::System.Windows.Controls.Primitives.Popup.AllowsTransparencyProperty, global::Infragistics.KnownBoxes.TrueBox);
			if (global::System.Windows.SystemParameters.ComboBoxAnimation)
			{
				global::Infragistics.Controls.Primitives.ControlDropDownManager.InitializeIfNotDefault(this._popup, global::System.Windows.Controls.Primitives.Popup.PopupAnimationProperty, global::System.Windows.SystemParameters.ComboBoxPopupAnimation);
			}
			if (chrome != null)
			{
				global::System.Windows.UIElement child = this._popup.Child;
				if (child != null && child.GetType().Name != "SystemDropShadowChrome")
				{
					this._popup.Child = chrome;
					chrome.Child = child;
				}
			}
			this.Placement = global::Infragistics.Controls.Primitives.DropDownPlacementMode.Bottom;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002202 File Offset: 0x00000402
		// (set) Token: 0x06000004 RID: 4 RVA: 0x0000220F File Offset: 0x0000040F
		internal double HorizontalOffset
		{
			get
			{
				return this._popup.HorizontalOffset;
			}
			set
			{
				this._popup.HorizontalOffset = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000005 RID: 5 RVA: 0x0000221D File Offset: 0x0000041D
		// (set) Token: 0x06000006 RID: 6 RVA: 0x00002234 File Offset: 0x00000434
		internal bool IsOpen
		{
			get
			{
				return this._popup != null && this._popup.IsOpen;
			}
			set
			{
				if (this._popup == null)
				{
					return;
				}
				if (this._popup.IsOpen != value)
				{
					this._popup.IsOpen = value;
				}
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002259 File Offset: 0x00000459
		internal global::System.Windows.FrameworkElement OriginalPopupChild
		{
			get
			{
				return this._popup.Child as global::System.Windows.FrameworkElement;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000008 RID: 8 RVA: 0x0000226B File Offset: 0x0000046B
		// (set) Token: 0x06000009 RID: 9 RVA: 0x00002278 File Offset: 0x00000478
		internal global::Infragistics.Controls.Primitives.DropDownPlacementMode Placement
		{
			get
			{
				return (global::Infragistics.Controls.Primitives.DropDownPlacementMode)this._popup.Placement;
			}
			set
			{
				this._popup.Placement = (global::System.Windows.Controls.Primitives.PlacementMode)value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002286 File Offset: 0x00000486
		// (set) Token: 0x0600000B RID: 11 RVA: 0x00002293 File Offset: 0x00000493
		internal bool StaysOpen
		{
			get
			{
				return this._popup.StaysOpen;
			}
			set
			{
				if (this.StaysOpen == value)
				{
					return;
				}
				this._popup.StaysOpen = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000022AB File Offset: 0x000004AB
		// (set) Token: 0x0600000D RID: 13 RVA: 0x000022B8 File Offset: 0x000004B8
		internal double VerticalOffset
		{
			get
			{
				return this._popup.VerticalOffset;
			}
			set
			{
				this._popup.VerticalOffset = value;
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000022C8 File Offset: 0x000004C8
		internal void Dispose()
		{
			if (this._owningControl == null)
			{
				return;
			}
			this._popup.Opened -= this.OnPopupOpened;
			this._popup.Closed -= this.OnPopupClosed;
			this._popup = null;
			this._owningControl = null;
			this._button = null;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002324 File Offset: 0x00000524
		internal static void InitializeIfNotDefault(global::System.Windows.DependencyObject target, global::System.Windows.DependencyProperty property, object value)
		{
			if (global::System.Windows.DependencyPropertyHelper.GetValueSource(target, property).BaseValueSource == global::System.Windows.BaseValueSource.Default)
			{
				target.SetValue(property, value);
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000234B File Offset: 0x0000054B
		private void OnPopupClosed(object sender, global::System.EventArgs e)
		{
			if (this._closeAction != null)
			{
				this._closeAction();
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002360 File Offset: 0x00000560
		private void OnPopupOpened(object sender, global::System.EventArgs e)
		{
			if (this._openAction != null)
			{
				this._openAction();
			}
		}

		// Token: 0x04000001 RID: 1
		private global::System.Windows.Controls.Control _owningControl;

		// Token: 0x04000002 RID: 2
		private global::System.Windows.Controls.Primitives.Popup _popup;

		// Token: 0x04000003 RID: 3
		private global::System.Windows.Controls.Primitives.ToggleButton _button;

		// Token: 0x04000004 RID: 4
		private global::System.Action _openAction;

		// Token: 0x04000005 RID: 5
		private global::System.Action _closeAction;
	}
}
