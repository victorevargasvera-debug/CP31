using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;
using Infragistics.AutomationPeers;
using Infragistics.Themes;
using Infragistics.Windows;
using Infragistics.Windows.Licensing;

namespace Infragistics.Controls.Menus
{
	// Token: 0x02000021 RID: 33
	[global::System.Windows.StyleTypedProperty(Property = "ItemContainerStyle", StyleTargetType = typeof(global::Infragistics.Controls.Menus.XamMenuItem))]
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	[global::Infragistics.Windows.Licensing.UltraLicense("XamMenu", global::Infragistics.Windows.Licensing.UltraLicenseAttribute.WpfProductType.DV | global::Infragistics.Windows.Licensing.UltraLicenseAttribute.WpfProductType.LOB)]
	public class XamMenu : global::Infragistics.Controls.Menus.XamMenuBase
	{
		// Token: 0x0600012C RID: 300 RVA: 0x00005C50 File Offset: 0x00003E50
		static XamMenu()
		{
			global::System.Windows.Style style = new global::System.Windows.Style();
			style.Seal();
			global::System.Windows.FrameworkElement.FocusVisualStyleProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Menus.XamMenu), new global::System.Windows.FrameworkPropertyMetadata(style));
			global::Infragistics.Themes.ThemeManager.RegisterControl(typeof(global::Infragistics.Controls.Menus.XamMenu));
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00005D34 File Offset: 0x00003F34
		public XamMenu()
		{
			base.DefaultStyleKey = typeof(global::Infragistics.Controls.Menus.XamMenu);
			this._webBehaviorTimer = new global::System.Windows.Threading.DispatcherTimer();
			this._webBehaviorTimer.Tick += delegate(object sender, global::System.EventArgs e)
			{
				this.CloseCurrentOpen();
				base.ReturnFocus();
				base.ClearPreviouslyFocusedControl();
			};
			global::Infragistics.Windows.Utilities.ValidateLicense(typeof(global::Infragistics.Controls.Menus.XamMenu), this);
			base.Focusable = false;
			base.IsTabStop = false;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00005DA0 File Offset: 0x00003FA0
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			if (this._isMenuOrientationNotSet)
			{
				global::System.Windows.Controls.StackPanel stackPanel = base.HeaderedItemContainerGenerator.ItemsHost as global::System.Windows.Controls.StackPanel;
				if (stackPanel != null && stackPanel.Orientation != this.MenuOrientation)
				{
					stackPanel.Orientation = this.MenuOrientation;
					this._isMenuOrientationNotSet = false;
				}
			}
			return base.ArrangeOverride(finalSize);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00005DF1 File Offset: 0x00003FF1
		protected override void OnBeforeUnload()
		{
			if (base.CurrentOpen != null)
			{
				base.CurrentOpen.UnloadSubmenu();
				base.CurrentOpen = null;
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00005E0D File Offset: 0x0000400D
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.AutomationPeers.XamMenuAutomationPeer(this);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00005E18 File Offset: 0x00004018
		protected internal override void OnCurrentOpenItemChanged(global::Infragistics.Controls.Menus.XamMenuItem oldItem, global::Infragistics.Controls.Menus.XamMenuItem newItem)
		{
			if (oldItem == null && newItem != null)
			{
				global::System.Windows.UIElement uielement = global::Infragistics.Controls.Menus.XamMenuBase.GetRoot(newItem) as global::System.Windows.UIElement;
				if (uielement != null && uielement != global::Infragistics.PlatformProxy.GetRootVisual(this))
				{
					uielement.AddHandler(global::System.Windows.UIElement.MouseLeftButtonDownEvent, new global::System.Windows.Input.MouseButtonEventHandler(base.RootVisual_MouseLeftButtonDown), true);
				}
				this.EnableCloseUpTriggerTrackers();
			}
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00005E64 File Offset: 0x00004064
		protected override void OnLostFocus(global::System.Windows.RoutedEventArgs e)
		{
			object focusedElement = global::Infragistics.PlatformProxy.GetFocusedElement(this);
			if (global::Infragistics.Controls.Menus.XamMenuBase.IsObjectFromMenu(this, focusedElement))
			{
				global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem = focusedElement as global::Infragistics.Controls.Menus.XamMenuItem;
				if (xamMenuItem != null)
				{
					this._previouslyFocusedControl = xamMenuItem;
				}
				return;
			}
			this._previouslyFocusedControl = null;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00005E9A File Offset: 0x0000409A
		public override void OnApplyTemplate()
		{
			global::System.Windows.Input.AccessKeyManager.RemoveAccessKeyPressedHandler(this, new global::System.Windows.Input.AccessKeyPressedEventHandler(this.HandleAccessKeyPressed));
			base.OnApplyTemplate();
			global::System.Windows.Input.AccessKeyManager.AddAccessKeyPressedHandler(this, new global::System.Windows.Input.AccessKeyPressedEventHandler(this.HandleAccessKeyPressed));
			this._isMenuOrientationNotSet = true;
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00005ECD File Offset: 0x000040CD
		// (set) Token: 0x06000135 RID: 309 RVA: 0x00005EDF File Offset: 0x000040DF
		public global::System.Windows.Controls.Orientation MenuOrientation
		{
			get
			{
				return (global::System.Windows.Controls.Orientation)base.GetValue(global::Infragistics.Controls.Menus.XamMenu.MenuOrientationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamMenu.MenuOrientationProperty, value);
			}
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00005EF4 File Offset: 0x000040F4
		private static void OnMenuOrientationPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamMenu xamMenu = d as global::Infragistics.Controls.Menus.XamMenu;
			if (xamMenu != null)
			{
				global::System.Windows.Controls.StackPanel stackPanel = xamMenu.HeaderedItemContainerGenerator.ItemsHost as global::System.Windows.Controls.StackPanel;
				if (stackPanel != null)
				{
					stackPanel.Orientation = xamMenu.MenuOrientation;
					return;
				}
				xamMenu._isMenuOrientationNotSet = true;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000137 RID: 311 RVA: 0x00005F33 File Offset: 0x00004133
		// (set) Token: 0x06000138 RID: 312 RVA: 0x00005F45 File Offset: 0x00004145
		public bool ExpandOnHover
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Menus.XamMenu.ExpandOnHoverProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamMenu.ExpandOnHoverProperty, value);
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000139 RID: 313 RVA: 0x00005F58 File Offset: 0x00004158
		// (set) Token: 0x0600013A RID: 314 RVA: 0x00005F6A File Offset: 0x0000416A
		public global::System.Windows.Controls.Control NavigationElement
		{
			get
			{
				return (global::System.Windows.Controls.Control)base.GetValue(global::Infragistics.Controls.Menus.XamMenu.NavigationElementProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamMenu.NavigationElementProperty, value);
			}
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00005F78 File Offset: 0x00004178
		internal override void CloseCurrentOpen()
		{
			base.CloseCurrentOpen();
			if (this._webBehaviorTimer != null)
			{
				this._webBehaviorTimer.Stop();
			}
			global::System.Windows.UIElement uielement = global::Infragistics.Controls.Menus.XamMenuBase.GetRoot(this) as global::System.Windows.UIElement;
			if (uielement != null && uielement != global::Infragistics.PlatformProxy.GetRootVisual(this))
			{
				uielement.RemoveHandler(global::System.Windows.UIElement.MouseLeftButtonDownEvent, new global::System.Windows.Input.MouseButtonEventHandler(base.RootVisual_MouseLeftButtonDown));
				this.DisableCloseUpTriggerTrackers();
			}
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00005FD3 File Offset: 0x000041D3
		internal void StartTimer()
		{
			this._webBehaviorTimer.Interval = new global::System.TimeSpan(0, 0, 0, 0, 100);
			this._webBehaviorTimer.Start();
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00005FF6 File Offset: 0x000041F6
		internal void StopTimer()
		{
			this._webBehaviorTimer.Stop();
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00006003 File Offset: 0x00004203
		private void HandleAccessKeyPressed(object sender, global::System.Windows.Input.AccessKeyPressedEventArgs e)
		{
			if (e.Scope == null && e.Target == null)
			{
				if (string.IsNullOrEmpty(e.Key))
				{
					return;
				}
				e.Target = this;
				e.Handled = true;
			}
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00006031 File Offset: 0x00004231
		private void EnableCloseUpTriggerTrackers()
		{
			if (!this._windowEventsHooked)
			{
				this._window = global::System.Windows.Window.GetWindow(this);
				if (this._window != null)
				{
					this._window.Deactivated += this.OnWindowStateChanged;
					this._windowEventsHooked = true;
				}
			}
		}

		// Token: 0x06000140 RID: 320 RVA: 0x0000606D File Offset: 0x0000426D
		private void OnWindowStateChanged(object sender, global::System.EventArgs e)
		{
			if (base.CurrentOpen != null)
			{
				this.CloseCurrentOpen();
			}
		}

		// Token: 0x06000141 RID: 321 RVA: 0x0000607D File Offset: 0x0000427D
		private void DisableCloseUpTriggerTrackers()
		{
			if (this._windowEventsHooked && this._window != null && this._window != null)
			{
				this._window.Deactivated -= this.OnWindowStateChanged;
				this._windowEventsHooked = false;
			}
		}

		// Token: 0x04000064 RID: 100
		private global::System.Windows.Window _window;

		// Token: 0x04000065 RID: 101
		private bool _windowEventsHooked;

		// Token: 0x04000066 RID: 102
		private global::System.Windows.Threading.DispatcherTimer _webBehaviorTimer;

		// Token: 0x04000067 RID: 103
		private bool _isMenuOrientationNotSet;

		// Token: 0x04000068 RID: 104
		public static readonly global::System.Windows.DependencyProperty MenuOrientationProperty = global::System.Windows.DependencyProperty.Register("MenuOrientation", typeof(global::System.Windows.Controls.Orientation), typeof(global::Infragistics.Controls.Menus.XamMenu), new global::System.Windows.PropertyMetadata(global::System.Windows.Controls.Orientation.Horizontal, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamMenu.OnMenuOrientationPropertyChanged)));

		// Token: 0x04000069 RID: 105
		public static readonly global::System.Windows.DependencyProperty ExpandOnHoverProperty = global::System.Windows.DependencyProperty.Register("ExpandOnHover", typeof(bool), typeof(global::Infragistics.Controls.Menus.XamMenu), new global::System.Windows.PropertyMetadata(false));

		// Token: 0x0400006A RID: 106
		public static readonly global::System.Windows.DependencyProperty NavigationElementProperty = global::System.Windows.DependencyProperty.Register("NavigationElement", typeof(global::System.Windows.Controls.Control), typeof(global::Infragistics.Controls.Menus.XamMenu), null);
	}
}
