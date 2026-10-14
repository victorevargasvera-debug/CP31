using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Threading;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.DockManager
{
	// Token: 0x020000D5 RID: 213
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplateVisualState(Name = "Bottom", GroupName = "LocationStates")]
	[global::System.Windows.TemplateVisualState(Name = "Left", GroupName = "LocationStates")]
	[global::System.Windows.TemplateVisualState(Name = "Right", GroupName = "LocationStates")]
	[global::System.Windows.TemplateVisualState(Name = "Top", GroupName = "LocationStates")]
	public class UnpinnedTabFlyout : global::System.Windows.Controls.Control
	{
		// Token: 0x060006FB RID: 1787 RVA: 0x00020B10 File Offset: 0x0001ED10
		static UnpinnedTabFlyout()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::System.Windows.Controls.Control.HorizontalContentAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.HorizontalAlignmentStretchBox));
			global::System.Windows.Controls.Control.VerticalContentAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VerticalAlignmentStretchBox));
			global::Infragistics.Windows.DockManager.XamDockManager.DockManagerPropertyKey.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.OnDockManagerChanged)));
			global::System.Windows.UIElement.RenderTransformOriginProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.CoerceRenderTransformOrigin)));
			global::System.Windows.UIElement.RenderTransformProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.CoerceRenderTransform)));
			global::System.Windows.FrameworkElement.WidthProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.CoerceWidth)));
			global::System.Windows.FrameworkElement.HeightProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.CoerceHeight)));
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00020E55 File Offset: 0x0001F055
		public UnpinnedTabFlyout()
		{
			base.Loaded += this.OnLoaded;
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x00020E70 File Offset: 0x0001F070
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
		{
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
			global::Infragistics.Windows.DockManager.DockManagerPanel dockManagerPanel = (dockManager != null) ? dockManager.DockPanel : null;
			if (dockManagerPanel != null)
			{
				switch (this.Side)
				{
				case global::System.Windows.Controls.Dock.Left:
				case global::System.Windows.Controls.Dock.Right:
				{
					double width = constraint.Width;
					if (this.ConstrainFlyoutExtent(ref width, this.MaxFlyoutWidth, true))
					{
						constraint.Width = width;
					}
					break;
				}
				case global::System.Windows.Controls.Dock.Top:
				case global::System.Windows.Controls.Dock.Bottom:
				{
					double height = constraint.Height;
					if (this.ConstrainFlyoutExtent(ref height, this.MaxFlyoutHeight, false))
					{
						constraint.Height = height;
					}
					break;
				}
				}
			}
			return base.MeasureOverride(constraint);
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x00020F00 File Offset: 0x0001F100
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this._hasVisualStateGroups = global::Infragistics.VisualStateUtilities.GetHasVisualStateGroups(this);
			this.UpdateVisualStates(false);
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x00020F1B File Offset: 0x0001F11B
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseEnter(e);
			if (this.Pane != null)
			{
				global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.ShowFlyoutOnMouseEnter(this.Pane);
			}
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x00020F37 File Offset: 0x0001F137
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseLeave(e);
			if (this.Pane != null)
			{
				global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.HideFlyoutOnMouseLeave(this.Pane);
			}
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x00020F54 File Offset: 0x0001F154
		private static void OnPaneChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.ContentPane contentPane = e.NewValue as global::Infragistics.Windows.DockManager.ContentPane;
			global::Infragistics.Windows.DockManager.UnpinnedTabFlyout unpinnedTabFlyout = (global::Infragistics.Windows.DockManager.UnpinnedTabFlyout)d;
			global::Infragistics.Windows.DockManager.ContentPane contentPane2 = e.OldValue as global::Infragistics.Windows.DockManager.ContentPane;
			if (contentPane2 != null)
			{
				contentPane2.RemoveHandler(global::Infragistics.Windows.DockManager.ContentPane.ClosedEvent, new global::System.Windows.RoutedEventHandler(unpinnedTabFlyout.OnFlyoutPaneClosed));
			}
			if (contentPane2 != null && contentPane != contentPane2 && !contentPane2.IsPinned)
			{
				contentPane2.HideAllHwndHosts();
			}
			if (contentPane == null)
			{
				global::System.Windows.IInputElement focusedElement = global::System.Windows.Input.Keyboard.FocusedElement;
				global::Infragistics.Windows.DockManager.XamDockManager dockManager = unpinnedTabFlyout.DockManager;
				bool flag = focusedElement != null && unpinnedTabFlyout.IsInPopup && unpinnedTabFlyout.IsKeyboardFocusWithin && null != dockManager;
				if (flag)
				{
					dockManager.ForceFocus();
				}
				unpinnedTabFlyout.ClearValue(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.FlyoutPaneVisibilityProperty);
				unpinnedTabFlyout.ClearValue(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.IsFlyInSuspendedProperty);
				unpinnedTabFlyout.SetValue(global::System.Windows.UIElement.VisibilityProperty, global::Infragistics.KnownBoxes.VisibilityHiddenBox);
				global::Infragistics.Windows.Controls.ToolWindow toolWindow = global::Infragistics.Windows.Controls.ToolWindow.GetToolWindow(unpinnedTabFlyout);
				if (toolWindow != null && unpinnedTabFlyout.IsInPopup)
				{
					toolWindow.Close();
				}
				unpinnedTabFlyout.ClearValue(global::System.Windows.FrameworkElement.WidthProperty);
				unpinnedTabFlyout.ClearValue(global::System.Windows.FrameworkElement.HeightProperty);
				if (flag)
				{
					focusedElement.Focus();
				}
			}
			else
			{
				contentPane.AddHandler(global::Infragistics.Windows.DockManager.ContentPane.ClosedEvent, new global::System.Windows.RoutedEventHandler(unpinnedTabFlyout.OnFlyoutPaneClosed), true);
				unpinnedTabFlyout.SetValue(global::System.Windows.UIElement.VisibilityProperty, global::Infragistics.KnownBoxes.VisibilityVisibleBox);
				unpinnedTabFlyout.SetBinding(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.FlyoutPaneVisibilityProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.UIElement.VisibilityProperty, global::System.Windows.Data.BindingMode.OneWay, contentPane));
				unpinnedTabFlyout.SetBinding(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.IsFlyInSuspendedProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DockManager.ContentPane.IsFlyInSuspendedProperty, global::System.Windows.Data.BindingMode.OneWay, contentPane));
				global::Infragistics.Windows.DockManager.XamDockManager dockManager2 = unpinnedTabFlyout.DockManager;
				if (dockManager2 != null)
				{
					unpinnedTabFlyout.SetValue(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.SidePropertyKey, global::Infragistics.KnownBoxes.FromValue(dockManager2.GetDockedSide(contentPane)));
				}
				global::Infragistics.Windows.DockManager.DockManagerPanel dockManagerPanel = (dockManager2 != null) ? dockManager2.DockPanel : null;
				if (dockManagerPanel != null)
				{
					bool? useToolWindow = contentPane.CanShowInPopup ? null : new bool?(false);
					dockManagerPanel.VerifyFlyoutPanelHost(useToolWindow);
				}
				global::Infragistics.Windows.Controls.ToolWindow toolWindow2 = global::Infragistics.Windows.Controls.ToolWindow.GetToolWindow(unpinnedTabFlyout);
				if (!unpinnedTabFlyout.IsInPopup)
				{
					toolWindow2 = null;
				}
				if (toolWindow2 != null)
				{
					toolWindow2.ClearValue(global::System.Windows.FrameworkElement.WidthProperty);
					toolWindow2.ClearValue(global::System.Windows.FrameworkElement.HeightProperty);
					if (global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(toolWindow2) > 0)
					{
						global::System.Windows.UIElement uielement = global::System.Windows.Media.VisualTreeHelper.GetChild(toolWindow2, 0) as global::System.Windows.UIElement;
						if (uielement != null)
						{
							uielement.InvalidateMeasure();
						}
					}
				}
				switch (unpinnedTabFlyout.Side)
				{
				case global::System.Windows.Controls.Dock.Left:
				case global::System.Windows.Controls.Dock.Right:
					unpinnedTabFlyout.SetBinding(global::System.Windows.FrameworkElement.WidthProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.FlyoutExtentProperty, global::System.Windows.Data.BindingMode.TwoWay, contentPane));
					unpinnedTabFlyout.ClearValue(global::System.Windows.FrameworkElement.HeightProperty);
					break;
				case global::System.Windows.Controls.Dock.Top:
				case global::System.Windows.Controls.Dock.Bottom:
					unpinnedTabFlyout.SetBinding(global::System.Windows.FrameworkElement.HeightProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.FlyoutExtentProperty, global::System.Windows.Data.BindingMode.TwoWay, contentPane));
					unpinnedTabFlyout.ClearValue(global::System.Windows.FrameworkElement.WidthProperty);
					break;
				}
				unpinnedTabFlyout.InvalidateMeasure();
				unpinnedTabFlyout.CoerceValue(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.FlyoutAnimationProperty);
				unpinnedTabFlyout._scaleTransform = null;
				unpinnedTabFlyout._translateTransform = null;
				unpinnedTabFlyout.CoerceValue(global::System.Windows.UIElement.RenderTransformProperty);
				unpinnedTabFlyout.InitializeToolWindowAlignment();
				if (toolWindow2 != null && !toolWindow2.IsVisible)
				{
					global::Infragistics.Windows.DockManager.DockManagerUtilities.InitializePreventAllowsTransparency(toolWindow2);
					toolWindow2.Show(dockManagerPanel, false, true);
				}
			}
			unpinnedTabFlyout.VerifyMouseOverTimer();
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000702 RID: 1794 RVA: 0x00021224 File Offset: 0x0001F424
		// (set) Token: 0x06000703 RID: 1795 RVA: 0x00021238 File Offset: 0x0001F438
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DockManager.ContentPane Pane
		{
			get
			{
				return (global::Infragistics.Windows.DockManager.ContentPane)base.GetValue(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.PaneProperty);
			}
			private set
			{
				global::Infragistics.Windows.DockManager.ContentPane pane = this.Pane;
				if (value != pane)
				{
					try
					{
						if (pane != null)
						{
							pane.SuspendIsVisibleResolvedVerification();
						}
						if (value != null)
						{
							value.SuspendIsVisibleResolvedVerification();
						}
						global::Infragistics.Windows.DockManager.DockManagerPanel dockManagerPanel = this.GetUIParentCore() as global::Infragistics.Windows.DockManager.DockManagerPanel;
						if (dockManagerPanel == null)
						{
							global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
							if (dockManager != null)
							{
								dockManagerPanel = dockManager.DockPanel;
							}
						}
						if (dockManagerPanel != null && value != null)
						{
							dockManagerPanel.RemoveUnpinnedPane(value);
						}
						base.SetValue(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.PanePropertyKey, (value == null) ? global::System.Windows.DependencyProperty.UnsetValue : value);
						if (dockManagerPanel != null && pane != null)
						{
							dockManagerPanel.AddUnpinnedPane(pane);
						}
					}
					finally
					{
						if (pane != null)
						{
							pane.ResumeIsVisibleResolvedVerification();
						}
						if (value != null)
						{
							value.ResumeIsVisibleResolvedVerification();
						}
					}
				}
			}
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x000212D8 File Offset: 0x0001F4D8
		private static void OnSideChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			d.CoerceValue(global::System.Windows.UIElement.RenderTransformOriginProperty);
			d.CoerceValue(global::System.Windows.UIElement.RenderTransformProperty);
			d.CoerceValue(global::System.Windows.FrameworkElement.WidthProperty);
			d.CoerceValue(global::System.Windows.FrameworkElement.HeightProperty);
			((global::Infragistics.Windows.DockManager.UnpinnedTabFlyout)d).UpdateVisualStates();
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000705 RID: 1797 RVA: 0x00021311 File Offset: 0x0001F511
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::System.Windows.Controls.Dock Side
		{
			get
			{
				return (global::System.Windows.Controls.Dock)base.GetValue(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.SideProperty);
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000706 RID: 1798 RVA: 0x00021323 File Offset: 0x0001F523
		// (set) Token: 0x06000707 RID: 1799 RVA: 0x0002132B File Offset: 0x0001F52B
		internal global::Infragistics.Windows.DockManager.UnpinnedFlyoutState CurrentState
		{
			get
			{
				return this._currentState;
			}
			private set
			{
				if (value != this._currentState)
				{
					this._currentState = value;
					if (value == global::Infragistics.Windows.DockManager.UnpinnedFlyoutState.Closed)
					{
						this.Pane = null;
						return;
					}
					if (value == global::Infragistics.Windows.DockManager.UnpinnedFlyoutState.Shown)
					{
						base.InvalidateVisual();
					}
				}
			}
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x00021352 File Offset: 0x0001F552
		internal static double GetFlyoutExtent(global::System.Windows.DependencyObject d)
		{
			return (double)d.GetValue(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.FlyoutExtentProperty);
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x00021364 File Offset: 0x0001F564
		internal static void SetFlyoutExtent(global::System.Windows.DependencyObject d, double value)
		{
			d.SetValue(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.FlyoutExtentProperty, value);
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x0600070A RID: 1802 RVA: 0x00021377 File Offset: 0x0001F577
		internal bool IsClosing
		{
			get
			{
				return this._currentState == global::Infragistics.Windows.DockManager.UnpinnedFlyoutState.Closing || this._currentState == global::Infragistics.Windows.DockManager.UnpinnedFlyoutState.ClosingIgnoreMouse;
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x0600070B RID: 1803 RVA: 0x00021390 File Offset: 0x0001F590
		internal bool IsInPopup
		{
			get
			{
				global::Infragistics.Windows.Controls.ToolWindow toolWindow = global::Infragistics.Windows.Controls.ToolWindow.GetToolWindow(this);
				if (toolWindow != null && toolWindow.Tag == global::Infragistics.Windows.DockManager.DockManagerPanel.FlyoutToolWindowId)
				{
					if (toolWindow.Content == this)
					{
						return true;
					}
					global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
					if (dockManager != null && dockManager.ShowFlyoutInToolWindow && toolWindow != global::Infragistics.Windows.Controls.ToolWindow.GetToolWindow(dockManager))
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x0600070C RID: 1804 RVA: 0x000213DD File Offset: 0x0001F5DD
		internal bool IsMouseOverEx
		{
			get
			{
				return base.IsMouseOver || (this.Pane != null && this.Pane.HasHwndHost && global::Infragistics.Windows.DockManager.DockManagerUtilities.IsMouseOver(this));
			}
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x0002140C File Offset: 0x0001F60C
		private static void OnMaxFlyoutHeightChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.UnpinnedTabFlyout unpinnedTabFlyout = (global::Infragistics.Windows.DockManager.UnpinnedTabFlyout)d;
			unpinnedTabFlyout.CoerceValue(global::System.Windows.FrameworkElement.HeightProperty);
			switch (unpinnedTabFlyout.Side)
			{
			case global::System.Windows.Controls.Dock.Top:
			case global::System.Windows.Controls.Dock.Bottom:
				unpinnedTabFlyout.InvalidateMeasure();
				break;
			case global::System.Windows.Controls.Dock.Right:
				break;
			default:
				return;
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x0600070E RID: 1806 RVA: 0x0002144D File Offset: 0x0001F64D
		// (set) Token: 0x0600070F RID: 1807 RVA: 0x0002145F File Offset: 0x0001F65F
		internal double MaxFlyoutHeight
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.MaxFlyoutHeightProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.MaxFlyoutHeightProperty, value);
			}
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00021474 File Offset: 0x0001F674
		private static void OnMaxFlyoutWidthChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.UnpinnedTabFlyout unpinnedTabFlyout = (global::Infragistics.Windows.DockManager.UnpinnedTabFlyout)d;
			unpinnedTabFlyout.CoerceValue(global::System.Windows.FrameworkElement.WidthProperty);
			switch (unpinnedTabFlyout.Side)
			{
			case global::System.Windows.Controls.Dock.Left:
			case global::System.Windows.Controls.Dock.Right:
				unpinnedTabFlyout.InvalidateMeasure();
				break;
			case global::System.Windows.Controls.Dock.Top:
				break;
			default:
				return;
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000711 RID: 1809 RVA: 0x000214B3 File Offset: 0x0001F6B3
		// (set) Token: 0x06000712 RID: 1810 RVA: 0x000214C5 File Offset: 0x0001F6C5
		internal double MaxFlyoutWidth
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.MaxFlyoutWidthProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.MaxFlyoutWidthProperty, value);
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000713 RID: 1811 RVA: 0x000214D8 File Offset: 0x0001F6D8
		private global::Infragistics.Windows.DockManager.XamDockManager DockManager
		{
			get
			{
				return global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
			}
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x000214E0 File Offset: 0x0001F6E0
		private static object CoerceFlyoutAnimation(global::System.Windows.DependencyObject d, object newValue)
		{
			global::Infragistics.Windows.DockManager.UnpinnedTabFlyout unpinnedTabFlyout = (global::Infragistics.Windows.DockManager.UnpinnedTabFlyout)d;
			global::Infragistics.Windows.DockManager.ContentPane pane = unpinnedTabFlyout.Pane;
			if (pane != null && !pane.AllowAnimations)
			{
				return global::Infragistics.Windows.DockManager.PaneFlyoutAnimation.None;
			}
			global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(d);
			if (unpinnedTabFlyout.IsInPopup && global::Infragistics.Windows.DockManager.DockManagerUtilities.IsPopupInChildWindow)
			{
				return global::Infragistics.Windows.DockManager.PaneFlyoutAnimation.None;
			}
			return newValue;
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x0002152B File Offset: 0x0001F72B
		private static void OnFlyoutAnimationChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			d.CoerceValue(global::System.Windows.UIElement.RenderTransformProperty);
			d.CoerceValue(global::System.Windows.UIElement.RenderTransformOriginProperty);
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x00021543 File Offset: 0x0001F743
		private global::Infragistics.Windows.DockManager.PaneFlyoutAnimation FlyoutAnimation
		{
			get
			{
				return (global::Infragistics.Windows.DockManager.PaneFlyoutAnimation)base.GetValue(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.FlyoutAnimationProperty);
			}
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x00021558 File Offset: 0x0001F758
		private static void OnFlyoutPaneVisibilityChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (global::System.Windows.Visibility.Collapsed.Equals(e.NewValue))
			{
				global::Infragistics.Windows.DockManager.UnpinnedTabFlyout unpinnedTabFlyout = (global::Infragistics.Windows.DockManager.UnpinnedTabFlyout)d;
				unpinnedTabFlyout.HideFlyout(unpinnedTabFlyout.Pane, false, false, true, false, false);
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x00021591 File Offset: 0x0001F791
		private bool IsLeftOrRightEdge
		{
			get
			{
				return this.Side == global::System.Windows.Controls.Dock.Left || this.Side == global::System.Windows.Controls.Dock.Right;
			}
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x000215A8 File Offset: 0x0001F7A8
		private static void OnIsFlyInSuspendedChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.UnpinnedTabFlyout unpinnedTabFlyout = (global::Infragistics.Windows.DockManager.UnpinnedTabFlyout)d;
			global::Infragistics.Windows.DockManager.ContentPane pane = unpinnedTabFlyout.Pane;
			if (pane != null)
			{
				if (false.Equals(e.NewValue))
				{
					if (!pane.IsKeyboardFocusWithinEx)
					{
						unpinnedTabFlyout.HideFlyout(pane, true, true, false, true, false);
						return;
					}
				}
				else if (unpinnedTabFlyout.IsClosing)
				{
					unpinnedTabFlyout.ShowFlyout(unpinnedTabFlyout.Pane, false, false, true);
				}
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x00021604 File Offset: 0x0001F804
		private bool IsShowingOrShown
		{
			get
			{
				return this._currentState == global::Infragistics.Windows.DockManager.UnpinnedFlyoutState.Showing || this._currentState == global::Infragistics.Windows.DockManager.UnpinnedFlyoutState.Shown;
			}
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x0002161C File Offset: 0x0001F81C
		protected virtual void SetVisualState(bool useTransitions)
		{
			string text = null;
			switch (this.Side)
			{
			case global::System.Windows.Controls.Dock.Left:
				text = "Left";
				break;
			case global::System.Windows.Controls.Dock.Top:
				text = "Top";
				break;
			case global::System.Windows.Controls.Dock.Right:
				text = "Right";
				break;
			case global::System.Windows.Controls.Dock.Bottom:
				text = "Bottom";
				break;
			}
			if (text != null)
			{
				global::System.Windows.VisualStateManager.GoToState(this, text, useTransitions);
			}
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x00021674 File Offset: 0x0001F874
		private static void OnVisualStatePropertyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.UnpinnedTabFlyout unpinnedTabFlyout = target as global::Infragistics.Windows.DockManager.UnpinnedTabFlyout;
			unpinnedTabFlyout.UpdateVisualStates();
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x0002168E File Offset: 0x0001F88E
		protected void UpdateVisualStates()
		{
			this.UpdateVisualStates(true);
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x00021697 File Offset: 0x0001F897
		protected void UpdateVisualStates(bool useTransitions)
		{
			if (!this._hasVisualStateGroups)
			{
				return;
			}
			if (!base.IsLoaded)
			{
				useTransitions = false;
			}
			this.SetVisualState(useTransitions);
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x000216B4 File Offset: 0x0001F8B4
		internal void HideFlyout(global::Infragistics.Windows.DockManager.ContentPane pane, bool checkMouseOverState, bool allowAnimation, bool ignoreMouseWhileClosing, bool allowAutoHideDelay, bool honorIsFlyInSuspended = false)
		{
			this.StopShowTimer();
			if (this._currentState == global::Infragistics.Windows.DockManager.UnpinnedFlyoutState.Closed)
			{
				return;
			}
			if (honorIsFlyInSuspended && pane == this.Pane && true.Equals(base.GetValue(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.IsFlyInSuspendedProperty)) && !pane.IsPinned)
			{
				return;
			}
			if (this.IsClosing && allowAnimation)
			{
				if (ignoreMouseWhileClosing && this._currentState == global::Infragistics.Windows.DockManager.UnpinnedFlyoutState.Closing)
				{
					this._currentState = global::Infragistics.Windows.DockManager.UnpinnedFlyoutState.ClosingIgnoreMouse;
				}
				return;
			}
			if (pane != null && pane != this.Pane)
			{
				return;
			}
			if (checkMouseOverState && this.Pane != null && !this.Pane.IsActivePane)
			{
				if (this.IsMouseOverEx)
				{
					return;
				}
				global::Infragistics.Windows.DockManager.UnpinnedTabAreaInfo unpinnedTabAreaInfo = this.Pane.PlacementInfo.CurrentContainer as global::Infragistics.Windows.DockManager.UnpinnedTabAreaInfo;
				global::Infragistics.Windows.DockManager.UnpinnedTabArea unpinnedTabArea = (unpinnedTabAreaInfo != null) ? unpinnedTabAreaInfo.TabArea : null;
				if (unpinnedTabArea != null)
				{
					global::Infragistics.Windows.DockManager.PaneTabItem paneTabItem = unpinnedTabArea.ItemContainerGenerator.ContainerFromItem(this.Pane) as global::Infragistics.Windows.DockManager.PaneTabItem;
					if (paneTabItem != null && paneTabItem.IsMouseOver)
					{
						return;
					}
				}
			}
			this.CurrentState = (ignoreMouseWhileClosing ? global::Infragistics.Windows.DockManager.UnpinnedFlyoutState.ClosingIgnoreMouse : global::Infragistics.Windows.DockManager.UnpinnedFlyoutState.Closing);
			global::System.Windows.Media.Animation.Storyboard sb = allowAnimation ? this.CreateStoryboard(false, allowAutoHideDelay) : null;
			this.StartStoryboard(sb);
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x000217BC File Offset: 0x0001F9BC
		internal static void HideFlyoutOnMouseLeave(global::Infragistics.Windows.DockManager.ContentPane pane)
		{
			if (pane != null && global::Infragistics.Windows.DockManager.PaneLocation.Unpinned == global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(pane) && !pane.IsActivePane)
			{
				global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(pane);
				if (dockManager != null)
				{
					dockManager.HideFlyout(pane, true, true, false, true, true);
				}
			}
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x000217F4 File Offset: 0x0001F9F4
		internal void InitializeToolWindowAlignment()
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = global::Infragistics.Windows.Controls.ToolWindow.GetToolWindow(this);
			if (toolWindow != null && this.IsInPopup)
			{
				switch (this.Side)
				{
				default:
					toolWindow.VerticalAlignment = global::System.Windows.VerticalAlignment.Stretch;
					toolWindow.HorizontalAlignment = global::System.Windows.HorizontalAlignment.Left;
					return;
				case global::System.Windows.Controls.Dock.Top:
					toolWindow.VerticalAlignment = global::System.Windows.VerticalAlignment.Top;
					toolWindow.HorizontalAlignment = global::System.Windows.HorizontalAlignment.Stretch;
					return;
				case global::System.Windows.Controls.Dock.Right:
					toolWindow.VerticalAlignment = global::System.Windows.VerticalAlignment.Stretch;
					toolWindow.HorizontalAlignment = global::System.Windows.HorizontalAlignment.Right;
					return;
				case global::System.Windows.Controls.Dock.Bottom:
					toolWindow.VerticalAlignment = global::System.Windows.VerticalAlignment.Bottom;
					toolWindow.HorizontalAlignment = global::System.Windows.HorizontalAlignment.Stretch;
					break;
				}
			}
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x0002186B File Offset: 0x0001FA6B
		internal void ShowAndHideFlyout(global::Infragistics.Windows.DockManager.ContentPane contentPane)
		{
			this.ShowFlyout(contentPane, false, false, false);
			this.HideFlyout(contentPane, false, true, true, true, true);
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x00021884 File Offset: 0x0001FA84
		internal void ShowFlyout(global::Infragistics.Windows.DockManager.ContentPane pane, bool allowDelay, bool basedOnMouseOver, bool allowAnimation)
		{
			if (basedOnMouseOver && pane == this.Pane && !pane.IsFlyInSuspended && this._currentState == global::Infragistics.Windows.DockManager.UnpinnedFlyoutState.ClosingIgnoreMouse)
			{
				return;
			}
			if (basedOnMouseOver && pane != this.Pane && this.Pane != null && this.Pane.IsFlyInSuspended && this._currentState != global::Infragistics.Windows.DockManager.UnpinnedFlyoutState.Closed)
			{
				return;
			}
			if (pane.PaneLocation != global::Infragistics.Windows.DockManager.PaneLocation.Unpinned && this.DockManager == global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(pane))
			{
				return;
			}
			if (this.Pane == pane && this.IsShowingOrShown)
			{
				this.StopShowTimer();
				return;
			}
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = this.DockManager;
			if (dockManager == null)
			{
				this.StopShowTimer();
				return;
			}
			if (basedOnMouseOver && pane != this.Pane && dockManager.UnpinnedTabHoverAction != global::Infragistics.Windows.DockManager.UnpinnedTabHoverAction.Flyout)
			{
				return;
			}
			global::Infragistics.Windows.DockManager.ContentPane pane2 = this.Pane;
			if (this.Pane != pane && this.Pane != null)
			{
				if (allowDelay)
				{
					this.StartShowTimer(pane);
					return;
				}
				this.HideFlyout(this.Pane, false, false, true, false, false);
			}
			this.StopShowTimer();
			if (pane != this.Pane)
			{
				this.Pane = pane;
				if (!this.IsInPopup)
				{
					dockManager.DockPanel.InvalidateArrange();
					dockManager.InvalidateArrange();
					dockManager.UpdateLayout();
				}
			}
			this.CurrentState = global::Infragistics.Windows.DockManager.UnpinnedFlyoutState.Showing;
			if (pane != pane2)
			{
				dockManager.RaiseFlyoutOpening(global::System.EventArgs.Empty);
			}
			if (this.Pane != pane || this.CurrentState != global::Infragistics.Windows.DockManager.UnpinnedFlyoutState.Showing)
			{
				return;
			}
			global::System.Windows.Media.Animation.Storyboard sb = allowAnimation ? this.CreateStoryboard(true, true) : null;
			this.StartStoryboard(sb);
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x000219D8 File Offset: 0x0001FBD8
		internal static void ShowFlyoutOnMouseEnter(global::Infragistics.Windows.DockManager.ContentPane pane)
		{
			if (pane != null && global::Infragistics.Windows.DockManager.PaneLocation.Unpinned == global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(pane))
			{
				global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(pane);
				if (dockManager != null && dockManager.FlyoutState != global::Infragistics.Windows.DockManager.UnpinnedFlyoutState.Closed)
				{
					dockManager.ShowFlyout(pane, true, true);
				}
			}
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x00021A0C File Offset: 0x0001FC0C
		internal void VerifyMouseOverTimer()
		{
			bool flag = false;
			if (this.Pane != null && this.Pane.HasHwndHost && base.IsLoaded)
			{
				flag = true;
			}
			if (flag)
			{
				if (this._mouseOverTimer == null)
				{
					this._mouseOverTimer = new global::System.Windows.Threading.DispatcherTimer(global::System.TimeSpan.FromMilliseconds(250.0), global::System.Windows.Threading.DispatcherPriority.Input, new global::System.EventHandler(this.OnMouseOverTick), base.Dispatcher);
					this._mouseOverTimer.Start();
					return;
				}
			}
			else if (this._mouseOverTimer != null)
			{
				this._mouseOverTimer.Tick -= this.OnMouseOverTick;
				this._mouseOverTimer.Stop();
				this._mouseOverTimer = null;
			}
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x00021AB0 File Offset: 0x0001FCB0
		private static global::System.Windows.Point CalcResizeOrigin(global::System.Windows.Controls.Dock side)
		{
			switch (side)
			{
			default:
				return default(global::System.Windows.Point);
			case global::System.Windows.Controls.Dock.Right:
				return new global::System.Windows.Point(1.0, 0.0);
			case global::System.Windows.Controls.Dock.Bottom:
				return new global::System.Windows.Point(0.0, 1.0);
			}
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x00021B10 File Offset: 0x0001FD10
		private static object CoerceHeight(global::System.Windows.DependencyObject d, object newValue)
		{
			global::Infragistics.Windows.DockManager.UnpinnedTabFlyout unpinnedTabFlyout = d as global::Infragistics.Windows.DockManager.UnpinnedTabFlyout;
			switch (unpinnedTabFlyout.Side)
			{
			case global::System.Windows.Controls.Dock.Top:
			case global::System.Windows.Controls.Dock.Bottom:
			{
				double num = (double)newValue;
				if (unpinnedTabFlyout.ConstrainFlyoutExtent(ref num, unpinnedTabFlyout.MaxFlyoutHeight, false))
				{
					return num;
				}
				break;
			}
			}
			return newValue;
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x00021B64 File Offset: 0x0001FD64
		private static object CoerceRenderTransform(global::System.Windows.DependencyObject d, object newValue)
		{
			global::Infragistics.Windows.DockManager.UnpinnedTabFlyout unpinnedTabFlyout = (global::Infragistics.Windows.DockManager.UnpinnedTabFlyout)d;
			switch (unpinnedTabFlyout.FlyoutAnimation)
			{
			case global::Infragistics.Windows.DockManager.PaneFlyoutAnimation.Resize:
				if (unpinnedTabFlyout._scaleTransform == null)
				{
					unpinnedTabFlyout._scaleTransform = new global::System.Windows.Media.ScaleTransform();
				}
				return unpinnedTabFlyout._scaleTransform;
			case global::Infragistics.Windows.DockManager.PaneFlyoutAnimation.Slide:
				if (unpinnedTabFlyout._translateTransform == null)
				{
					unpinnedTabFlyout._translateTransform = new global::System.Windows.Media.TranslateTransform();
				}
				return unpinnedTabFlyout._translateTransform;
			default:
				return newValue;
			}
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x00021BC8 File Offset: 0x0001FDC8
		private static object CoerceRenderTransformOrigin(global::System.Windows.DependencyObject d, object newValue)
		{
			global::Infragistics.Windows.DockManager.UnpinnedTabFlyout unpinnedTabFlyout = (global::Infragistics.Windows.DockManager.UnpinnedTabFlyout)d;
			if (unpinnedTabFlyout.FlyoutAnimation == global::Infragistics.Windows.DockManager.PaneFlyoutAnimation.Resize)
			{
				return global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.CalcResizeOrigin(unpinnedTabFlyout.Side);
			}
			return newValue;
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x00021BF8 File Offset: 0x0001FDF8
		private static object CoerceWidth(global::System.Windows.DependencyObject d, object newValue)
		{
			global::Infragistics.Windows.DockManager.UnpinnedTabFlyout unpinnedTabFlyout = d as global::Infragistics.Windows.DockManager.UnpinnedTabFlyout;
			switch (unpinnedTabFlyout.Side)
			{
			case global::System.Windows.Controls.Dock.Left:
			case global::System.Windows.Controls.Dock.Right:
			{
				double num = (double)newValue;
				if (unpinnedTabFlyout.ConstrainFlyoutExtent(ref num, unpinnedTabFlyout.MaxFlyoutWidth, true))
				{
					return num;
				}
				break;
			}
			}
			return newValue;
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x00021C47 File Offset: 0x0001FE47
		private bool ConstrainFlyoutExtent(ref double value, double maxAvailable, bool isHorizontal)
		{
			if (double.IsNaN(value))
			{
				return false;
			}
			if (double.IsPositiveInfinity(maxAvailable))
			{
				return false;
			}
			maxAvailable = global::System.Math.Max(maxAvailable - global::Infragistics.Windows.DockManager.UnpinnedTabFlyoutSplitter.GetReservedSpace(isHorizontal), 0.0);
			if (global::Infragistics.CoreUtilities.LessThanOrClose(value, maxAvailable))
			{
				return false;
			}
			value = maxAvailable;
			return true;
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x00021C86 File Offset: 0x0001FE86
		private global::System.Windows.Media.Animation.Storyboard CreateStoryboard(bool show, bool allowAutoHideDelay)
		{
			return this.CreateStoryboard(show, allowAutoHideDelay, this._currentStoryboard != null);
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x00021C9C File Offset: 0x0001FE9C
		private global::System.Windows.Media.Animation.Storyboard CreateStoryboard(bool show, bool allowAutoHideDelay, bool startWithCurrentValue)
		{
			global::Infragistics.Windows.DockManager.PaneFlyoutAnimation flyoutAnimation = this.FlyoutAnimation;
			double value = show ? 250.0 : 250.0;
			global::System.Windows.Duration duration = new global::System.Windows.Duration(global::System.TimeSpan.FromMilliseconds(value));
			if (!show && flyoutAnimation == global::Infragistics.Windows.DockManager.PaneFlyoutAnimation.None && !allowAutoHideDelay)
			{
				return null;
			}
			global::System.Windows.Media.Animation.Storyboard storyboard = new global::System.Windows.Media.Animation.Storyboard();
			storyboard.FillBehavior = global::System.Windows.Media.Animation.FillBehavior.Stop;
			if (!show)
			{
				storyboard.BeginTime = new global::System.TimeSpan?(global::System.TimeSpan.FromMilliseconds(500.0));
			}
			switch (flyoutAnimation)
			{
			case global::Infragistics.Windows.DockManager.PaneFlyoutAnimation.None:
			{
				global::System.Windows.Media.Animation.DoubleAnimation doubleAnimation = new global::System.Windows.Media.Animation.DoubleAnimation(base.Opacity, base.Opacity, new global::System.Windows.Duration(global::System.TimeSpan.FromMilliseconds(1.0)), global::System.Windows.Media.Animation.FillBehavior.Stop);
				storyboard.Children.Add(doubleAnimation);
				global::System.Windows.Media.Animation.Storyboard.SetTargetProperty(doubleAnimation, new global::System.Windows.PropertyPath(global::System.Windows.UIElement.OpacityProperty));
				break;
			}
			case global::Infragistics.Windows.DockManager.PaneFlyoutAnimation.Fade:
			{
				double toValue = show ? 1.0 : 0.0;
				double fromValue = startWithCurrentValue ? base.Opacity : (show ? 0.0 : 1.0);
				global::System.Windows.Media.Animation.DoubleAnimation doubleAnimation2 = new global::System.Windows.Media.Animation.DoubleAnimation(fromValue, toValue, duration, global::System.Windows.Media.Animation.FillBehavior.Stop);
				storyboard.Children.Add(doubleAnimation2);
				global::System.Windows.Media.Animation.Storyboard.SetTargetProperty(doubleAnimation2, new global::System.Windows.PropertyPath(global::System.Windows.UIElement.OpacityProperty));
				doubleAnimation2.DecelerationRatio = 0.75;
				break;
			}
			case global::Infragistics.Windows.DockManager.PaneFlyoutAnimation.Resize:
			{
				bool isLeftOrRightEdge = this.IsLeftOrRightEdge;
				string path = isLeftOrRightEdge ? "(UIElement.RenderTransform).(ScaleTransform.ScaleX)" : "(UIElement.RenderTransform).(ScaleTransform.ScaleY)";
				global::System.Windows.DependencyProperty dp = isLeftOrRightEdge ? global::System.Windows.Media.ScaleTransform.ScaleXProperty : global::System.Windows.Media.ScaleTransform.ScaleYProperty;
				global::System.Windows.Media.ScaleTransform scaleTransform = this._scaleTransform ?? new global::System.Windows.Media.ScaleTransform();
				double toValue2 = show ? 1.0 : 0.0;
				double fromValue2 = startWithCurrentValue ? ((double)scaleTransform.GetValue(dp)) : (show ? 0.0 : 1.0);
				global::System.Windows.Media.Animation.DoubleAnimation doubleAnimation3 = new global::System.Windows.Media.Animation.DoubleAnimation(fromValue2, toValue2, duration, global::System.Windows.Media.Animation.FillBehavior.Stop);
				global::System.Windows.Media.Animation.Storyboard.SetTargetProperty(doubleAnimation3, new global::System.Windows.PropertyPath(path, new object[0]));
				storyboard.Children.Add(doubleAnimation3);
				break;
			}
			case global::Infragistics.Windows.DockManager.PaneFlyoutAnimation.Slide:
			{
				bool isLeftOrRightEdge2 = this.IsLeftOrRightEdge;
				string path2 = isLeftOrRightEdge2 ? "(UIElement.RenderTransform).(TranslateTransform.X)" : "(UIElement.RenderTransform).(TranslateTransform.Y)";
				global::System.Windows.DependencyProperty dp2 = isLeftOrRightEdge2 ? global::System.Windows.Media.TranslateTransform.XProperty : global::System.Windows.Media.TranslateTransform.YProperty;
				global::System.Windows.Media.TranslateTransform translateTransform = this._translateTransform ?? new global::System.Windows.Media.TranslateTransform();
				double num = 0.0;
				double num2;
				switch (this.Side)
				{
				default:
					num2 = -base.ActualWidth;
					break;
				case global::System.Windows.Controls.Dock.Top:
					num2 = -base.ActualHeight;
					break;
				case global::System.Windows.Controls.Dock.Right:
					num2 = base.ActualWidth;
					break;
				case global::System.Windows.Controls.Dock.Bottom:
					num2 = base.ActualHeight;
					break;
				}
				if (!show)
				{
					double num3 = num;
					num = num2;
					num2 = num3;
				}
				double fromValue3 = startWithCurrentValue ? ((double)translateTransform.GetValue(dp2)) : num2;
				global::System.Windows.Media.Animation.DoubleAnimation doubleAnimation4 = new global::System.Windows.Media.Animation.DoubleAnimation(fromValue3, num, duration, global::System.Windows.Media.Animation.FillBehavior.Stop);
				global::System.Windows.Media.Animation.Storyboard.SetTargetProperty(doubleAnimation4, new global::System.Windows.PropertyPath(path2, new object[0]));
				storyboard.Children.Add(doubleAnimation4);
				break;
			}
			}
			return storyboard;
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x00021F88 File Offset: 0x00020188
		private static void OnDockManagerChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (e.NewValue != null)
			{
				global::System.Windows.Data.BindingOperations.SetBinding(d, global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.FlyoutAnimationProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DockManager.XamDockManager.FlyoutAnimationProperty, global::System.Windows.Data.BindingMode.OneWay, e.NewValue));
				return;
			}
			global::System.Windows.Data.BindingOperations.ClearBinding(d, global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.FlyoutAnimationProperty);
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x00021FBD File Offset: 0x000201BD
		private void OnFlyoutPaneClosed(object sender, global::System.Windows.RoutedEventArgs e)
		{
			if (this.Pane == sender)
			{
				this.HideFlyout(this.Pane, false, false, true, false, false);
			}
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x00021FD9 File Offset: 0x000201D9
		private void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			base.Loaded -= this.OnLoaded;
			base.Unloaded += this.OnUnloaded;
			this.VerifyMouseOverTimer();
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x00022008 File Offset: 0x00020208
		private void OnMouseOverTick(object sender, global::System.EventArgs e)
		{
			switch (this._currentState)
			{
			case global::Infragistics.Windows.DockManager.UnpinnedFlyoutState.Closed:
			case global::Infragistics.Windows.DockManager.UnpinnedFlyoutState.ClosingIgnoreMouse:
				break;
			case global::Infragistics.Windows.DockManager.UnpinnedFlyoutState.Closing:
				if (this.Pane != null && this.IsMouseOverEx)
				{
					global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.ShowFlyoutOnMouseEnter(this.Pane);
					return;
				}
				break;
			case global::Infragistics.Windows.DockManager.UnpinnedFlyoutState.Showing:
			case global::Infragistics.Windows.DockManager.UnpinnedFlyoutState.Shown:
				if (this.Pane != null && !this.IsMouseOverEx)
				{
					global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.HideFlyoutOnMouseLeave(this.Pane);
				}
				break;
			default:
				return;
			}
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x00022070 File Offset: 0x00020270
		private void OnShowDelayTimerTick(object sender, global::System.EventArgs e)
		{
			global::System.Windows.Threading.DispatcherTimer dispatcherTimer = (global::System.Windows.Threading.DispatcherTimer)sender;
			global::Infragistics.Windows.DockManager.ContentPane contentPane = dispatcherTimer.Tag as global::Infragistics.Windows.DockManager.ContentPane;
			this.StopShowTimer();
			if (contentPane != null)
			{
				this.ShowFlyout(contentPane, false, true, true);
			}
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x000220A3 File Offset: 0x000202A3
		private void OnStoryboardCompleted(object sender, global::System.EventArgs e)
		{
			this.StopCurrentStoryboard();
			if (this.IsClosing)
			{
				this.CurrentState = global::Infragistics.Windows.DockManager.UnpinnedFlyoutState.Closed;
				return;
			}
			if (this._currentState == global::Infragistics.Windows.DockManager.UnpinnedFlyoutState.Showing)
			{
				this.CurrentState = global::Infragistics.Windows.DockManager.UnpinnedFlyoutState.Shown;
			}
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x000220CB File Offset: 0x000202CB
		private void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			base.Unloaded -= this.OnUnloaded;
			base.Loaded += this.OnLoaded;
			this.VerifyMouseOverTimer();
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x000220F8 File Offset: 0x000202F8
		[global::System.Diagnostics.Conditional("DEBUG")]
		private static void OutputElementTree()
		{
			global::System.Windows.DependencyObject dependencyObject = global::System.Windows.Input.Mouse.DirectlyOver as global::System.Windows.DependencyObject;
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			while (dependencyObject != null)
			{
				stringBuilder.Append(dependencyObject.GetType().Name);
				stringBuilder.Append("->");
				if (dependencyObject is global::System.Windows.ContentElement)
				{
					dependencyObject = global::System.Windows.LogicalTreeHelper.GetParent(dependencyObject);
				}
				else
				{
					dependencyObject = global::System.Windows.Media.VisualTreeHelper.GetParent(dependencyObject);
				}
			}
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x00022154 File Offset: 0x00020354
		private void StartShowTimer(global::Infragistics.Windows.DockManager.ContentPane pane)
		{
			if (this._showDelayTimer != null && this._showDelayTimer.Tag == pane)
			{
				return;
			}
			if (this._showDelayTimer == null)
			{
				this._showDelayTimer = new global::System.Windows.Threading.DispatcherTimer(global::System.TimeSpan.FromMilliseconds(500.0), global::System.Windows.Threading.DispatcherPriority.Normal, new global::System.EventHandler(this.OnShowDelayTimerTick), base.Dispatcher);
			}
			this._showDelayTimer.Tag = pane;
			this._showDelayTimer.Start();
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x000221C4 File Offset: 0x000203C4
		private void StartStoryboard(global::System.Windows.Media.Animation.Storyboard sb)
		{
			if (sb != null)
			{
				sb.Completed += this.OnStoryboardCompleted;
				sb.Begin(this, true);
			}
			this.StopCurrentStoryboard();
			if (sb != null)
			{
				this._currentStoryboard = sb;
				return;
			}
			if (this._currentState == global::Infragistics.Windows.DockManager.UnpinnedFlyoutState.Showing)
			{
				this.CurrentState = global::Infragistics.Windows.DockManager.UnpinnedFlyoutState.Shown;
				return;
			}
			if (this.IsClosing)
			{
				this.CurrentState = global::Infragistics.Windows.DockManager.UnpinnedFlyoutState.Closed;
			}
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x0002221F File Offset: 0x0002041F
		private void StopCurrentStoryboard()
		{
			if (this._currentStoryboard != null)
			{
				this._currentStoryboard.Completed -= this.OnStoryboardCompleted;
				this._currentStoryboard.Stop(this);
				this._currentStoryboard.Remove(this);
				this._currentStoryboard = null;
			}
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x0002225F File Offset: 0x0002045F
		private void StopShowTimer()
		{
			if (this._showDelayTimer != null)
			{
				this._showDelayTimer.Tag = null;
				this._showDelayTimer.Stop();
			}
		}

		// Token: 0x040003B5 RID: 949
		private const double AutoHideDelay = 500.0;

		// Token: 0x040003B6 RID: 950
		private const double ShowDurationTime = 250.0;

		// Token: 0x040003B7 RID: 951
		private const double HideDurationTime = 250.0;

		// Token: 0x040003B8 RID: 952
		private global::Infragistics.Windows.DockManager.UnpinnedFlyoutState _currentState;

		// Token: 0x040003B9 RID: 953
		private global::System.Windows.Media.Animation.Storyboard _currentStoryboard;

		// Token: 0x040003BA RID: 954
		private global::System.Windows.Media.ScaleTransform _scaleTransform;

		// Token: 0x040003BB RID: 955
		private global::System.Windows.Media.TranslateTransform _translateTransform;

		// Token: 0x040003BC RID: 956
		private global::System.Windows.Threading.DispatcherTimer _showDelayTimer;

		// Token: 0x040003BD RID: 957
		private global::System.Windows.Threading.DispatcherTimer _mouseOverTimer;

		// Token: 0x040003BE RID: 958
		private bool _hasVisualStateGroups;

		// Token: 0x040003BF RID: 959
		private static readonly global::System.Windows.DependencyPropertyKey PanePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Pane", typeof(global::Infragistics.Windows.DockManager.ContentPane), typeof(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.OnPaneChanged)));

		// Token: 0x040003C0 RID: 960
		public static readonly global::System.Windows.DependencyProperty PaneProperty = global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.PanePropertyKey.DependencyProperty;

		// Token: 0x040003C1 RID: 961
		private static readonly global::System.Windows.DependencyPropertyKey SidePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Side", typeof(global::System.Windows.Controls.Dock), typeof(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.DockLeftBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.OnSideChanged)));

		// Token: 0x040003C2 RID: 962
		public static readonly global::System.Windows.DependencyProperty SideProperty = global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.SidePropertyKey.DependencyProperty;

		// Token: 0x040003C3 RID: 963
		internal static readonly global::System.Windows.DependencyProperty FlyoutExtentProperty = global::System.Windows.DependencyProperty.RegisterAttached("FlyoutExtent", typeof(double), typeof(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout), new global::System.Windows.FrameworkPropertyMetadata(double.NaN));

		// Token: 0x040003C4 RID: 964
		internal static readonly global::System.Windows.DependencyProperty MaxFlyoutHeightProperty = global::Infragistics.DependencyPropertyUtilities.Register("MaxFlyoutHeight", typeof(double), typeof(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(double.PositiveInfinity, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.OnMaxFlyoutHeightChanged)));

		// Token: 0x040003C5 RID: 965
		internal static readonly global::System.Windows.DependencyProperty MaxFlyoutWidthProperty = global::Infragistics.DependencyPropertyUtilities.Register("MaxFlyoutWidth", typeof(double), typeof(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(double.PositiveInfinity, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.OnMaxFlyoutWidthChanged)));

		// Token: 0x040003C6 RID: 966
		private static readonly global::System.Windows.DependencyProperty FlyoutAnimationProperty = global::System.Windows.DependencyProperty.Register("FlyoutAnimation", typeof(global::Infragistics.Windows.DockManager.PaneFlyoutAnimation), typeof(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DockManager.PaneFlyoutAnimation.Slide, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.OnFlyoutAnimationChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.CoerceFlyoutAnimation)));

		// Token: 0x040003C7 RID: 967
		private static readonly global::System.Windows.DependencyProperty FlyoutPaneVisibilityProperty = global::System.Windows.DependencyProperty.Register("FlyoutPaneVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityVisibleBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.OnFlyoutPaneVisibilityChanged)));

		// Token: 0x040003C8 RID: 968
		private static readonly global::System.Windows.DependencyProperty IsFlyInSuspendedProperty = global::System.Windows.DependencyProperty.Register("IsFlyInSuspended", typeof(bool), typeof(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.OnIsFlyInSuspendedChanged)));
	}
}
