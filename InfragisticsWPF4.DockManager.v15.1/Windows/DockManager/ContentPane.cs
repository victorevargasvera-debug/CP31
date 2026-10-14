using System;
using System.ComponentModel;
using System.Threading;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using System.Windows.Threading;
using Infragistics.Windows.Automation.Peers.DockManager;
using Infragistics.Windows.Commands;
using Infragistics.Windows.Controls;
using Infragistics.Windows.Controls.Events;
using Infragistics.Windows.DockManager.Dragging;
using Infragistics.Windows.DockManager.Events;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DockManager
{
	// Token: 0x02000019 RID: 25
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "DockedBottom", GroupName = "PaneLocationStates")]
	[global::System.Windows.TemplateVisualState(Name = "DockedLeft", GroupName = "PaneLocationStates")]
	[global::System.Windows.TemplateVisualState(Name = "Inactive", GroupName = "ActiveStates")]
	[global::System.Windows.TemplateVisualState(Name = "DockedTop", GroupName = "PaneLocationStates")]
	[global::System.Windows.TemplateVisualState(Name = "DockedBottom", GroupName = "PaneLocationStates")]
	[global::System.Windows.TemplateVisualState(Name = "Document", GroupName = "PaneLocationStates")]
	[global::System.Windows.TemplateVisualState(Name = "Floating", GroupName = "PaneLocationStates")]
	[global::System.Windows.TemplateVisualState(Name = "Disabled", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "DockedRight", GroupName = "PaneLocationStates")]
	[global::System.Windows.TemplateVisualState(Name = "Unpinned", GroupName = "PaneLocationStates")]
	[global::System.Windows.TemplateVisualState(Name = "Active", GroupName = "ActiveStates")]
	[global::System.Windows.TemplateVisualState(Name = "ActiveDocument", GroupName = "ActiveStates")]
	public class ContentPane : global::System.Windows.Controls.HeaderedContentControl, global::Infragistics.Windows.Commands.ICommandHost, global::Infragistics.Windows.DockManager.IHwndHostInfoOwner
	{
		// Token: 0x060000B9 RID: 185 RVA: 0x00004D44 File Offset: 0x00002F44
		public ContentPane()
		{
			this._placementInfo = new global::Infragistics.Windows.DockManager.ContentPane.PanePlacementInfo();
			this._commands = global::Infragistics.Windows.DockManager.ContentPaneCommands.Instance;
			global::Infragistics.Windows.DockManager.HwndHostInfo.SetHwndHost(this, new global::Infragistics.Windows.DockManager.HwndHostInfo(this));
			base.IsVisibleChanged += delegate(object o, global::System.Windows.DependencyPropertyChangedEventArgs e)
			{
				this.VerifyIsVisibleResolved();
			};
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00004DCC File Offset: 0x00002FCC
		static ContentPane()
		{
			global::Infragistics.Windows.DockManager.ContentPane.ClosingEvent = global::System.Windows.EventManager.RegisterRoutedEvent("Closing", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DockManager.Events.PaneClosingEventArgs>), typeof(global::Infragistics.Windows.DockManager.ContentPane));
			global::Infragistics.Windows.DockManager.ContentPane.ClosedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("Closed", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DockManager.Events.PaneClosedEventArgs>), typeof(global::Infragistics.Windows.DockManager.ContentPane));
			global::Infragistics.Windows.DockManager.ContentPane.ExecutingCommandEvent = global::System.Windows.EventManager.RegisterRoutedEvent("ExecutingCommand", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs>), typeof(global::Infragistics.Windows.DockManager.ContentPane));
			global::Infragistics.Windows.DockManager.ContentPane.ExecutedCommandEvent = global::System.Windows.EventManager.RegisterRoutedEvent("ExecutedCommand", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs>), typeof(global::Infragistics.Windows.DockManager.ContentPane));
			global::Infragistics.Windows.DockManager.ContentPane.IsVisibleResolvedChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("IsVisibleResolvedChanged", global::System.Windows.RoutingStrategy.Direct, typeof(global::System.Windows.RoutedEventHandler), typeof(global::Infragistics.Windows.DockManager.ContentPane));
			global::Infragistics.Windows.DockManager.ContentPane.OptionsMenuOpeningEvent = global::System.Windows.EventManager.RegisterRoutedEvent("OptionsMenuOpening", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DockManager.Events.PaneOptionsMenuOpeningEventArgs>), typeof(global::Infragistics.Windows.DockManager.ContentPane));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DockManager.ContentPane)));
			global::System.Windows.Controls.Control.HorizontalContentAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.HorizontalAlignmentStretchBox));
			global::System.Windows.Controls.Control.VerticalContentAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VerticalAlignmentStretchBox));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.DockManager.ContentPane), global::System.Windows.Input.Keyboard.PreviewLostKeyboardFocusEvent, new global::System.Windows.Input.KeyboardFocusChangedEventHandler(global::Infragistics.Windows.DockManager.ContentPane.OnPreviousLostKeyboardFocus));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.DockManager.ContentPane), global::System.Windows.Input.Mouse.MouseDownEvent, new global::System.Windows.Input.MouseButtonEventHandler(global::Infragistics.Windows.DockManager.ContentPane.OnMouseDown), true);
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.DockManager.ContentPane), global::System.Windows.Input.Mouse.PreviewMouseDownEvent, new global::System.Windows.Input.MouseButtonEventHandler(global::Infragistics.Windows.DockManager.ContentPane.OnPreviewMouseDown), false);
			global::System.Windows.Input.KeyboardNavigation.IsTabStopProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::System.Windows.Input.KeyboardNavigation.DirectionalNavigationProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.Cycle));
			global::System.Windows.Input.KeyboardNavigation.TabNavigationProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.Cycle));
			global::System.Windows.Input.FocusManager.IsFocusScopeProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox));
			global::System.Windows.Controls.HeaderedContentControl.HeaderTemplateSelectorProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DockManager.ContentPane.ContentPaneTemplateSelector.Instance));
			global::System.Windows.UIElement.VisibilityProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.ContentPane.OnVisibilityChanged)));
			global::System.Windows.Input.FocusManager.FocusedElementProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DockManager.ContentPane.CoerceFocusedElement)));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::System.Windows.FrameworkElement), global::System.Windows.Input.Keyboard.PreviewGotKeyboardFocusEvent, new global::System.Windows.Input.KeyboardFocusChangedEventHandler(global::Infragistics.Windows.DockManager.ContentPane.OnPreviousRootGotKeyboardFocus));
			global::Infragistics.Windows.DockManager.XamDockManager.PaneLocationPropertyKey.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.ContentPane.OnPaneLocationChanged)));
			global::Infragistics.Windows.DockManager.XamDockManager.DockManagerPropertyKey.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.ContentPane.OnDockManagerChanged)));
			global::System.Windows.UIElement.IsEnabledProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.ContentPane.OnVisualStatePropertyChanged)));
			global::Infragistics.Windows.DockManager.ActivePaneManager.IsActivePaneProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.ContentPane.OnVisualStatePropertyChanged)), global::Infragistics.Windows.DockManager.ActivePaneManager.IsActivePanePropertyKey);
			global::Infragistics.Windows.DockManager.ActivePaneManager.IsActiveDocumentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.ContentPane.OnVisualStatePropertyChanged)), global::Infragistics.Windows.DockManager.ActivePaneManager.IsActiveDocumentPropertyKey);
			global::Infragistics.Windows.DockManager.DockManagerUtilities.IsMovingPanesProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(delegate(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
			{
				((global::Infragistics.Windows.DockManager.ContentPane)d).VerifyIsVisibleResolved();
			}));
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00005800 File Offset: 0x00003A00
		private static void OnDockManagerChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.ContentPane contentPane = d as global::Infragistics.Windows.DockManager.ContentPane;
			if (global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(contentPane) != e.NewValue)
			{
				return;
			}
			global::Infragistics.Windows.DockManager.XamDockManager xamDockManager = e.OldValue as global::Infragistics.Windows.DockManager.XamDockManager;
			global::Infragistics.Windows.DockManager.XamDockManager xamDockManager2 = e.NewValue as global::Infragistics.Windows.DockManager.XamDockManager;
			contentPane.VerifyIsPinnedState();
			if (xamDockManager != null)
			{
				xamDockManager.ActivePaneManager.OnPaneRemoved(contentPane);
				xamDockManager.DirtyHasHwndHosts();
			}
			if (xamDockManager2 != null)
			{
				global::Infragistics.Windows.DockManager.ContentPane contentPane2 = global::Infragistics.Windows.Utilities.GetAncestorFromType(contentPane, typeof(global::Infragistics.Windows.DockManager.ContentPane), true, xamDockManager2) as global::Infragistics.Windows.DockManager.ContentPane;
				if (contentPane2 != null && contentPane2 != contentPane)
				{
					throw new global::System.InvalidOperationException(global::Infragistics.Windows.DockManager.XamDockManager.GetString("LE_CannotNestContentPanes", new object[]
					{
						contentPane,
						contentPane2
					}));
				}
				xamDockManager2.ActivePaneManager.OnPaneAdded(contentPane);
				if (contentPane.HasHwndHost && false.Equals(xamDockManager2.HasHwndHostNoVerify))
				{
					xamDockManager2.DirtyHasHwndHosts();
				}
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000058D0 File Offset: 0x00003AD0
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this._hasVisualStateGroups = global::Infragistics.VisualStateUtilities.GetHasVisualStateGroups(this);
			this.UpdateVisualStates(false);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000058EB File Offset: 0x00003AEB
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.DockManager.ContentPaneAutomationPeer(this);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000058F4 File Offset: 0x00003AF4
		protected override void OnHeaderChanged(object oldHeader, object newHeader)
		{
			base.OnHeaderChanged(oldHeader, newHeader);
			global::Infragistics.Windows.DockManager.PaneToolWindow singlePaneToolWindow = global::Infragistics.Windows.DockManager.PaneToolWindow.GetSinglePaneToolWindow(this);
			if (singlePaneToolWindow != null)
			{
				singlePaneToolWindow.RefreshSinglePaneTitle();
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00005919 File Offset: 0x00003B19
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			base.OnKeyDown(e);
			if (!e.Handled && this.Commands != null && this.Commands.ProcessKeyboardInput(e, this))
			{
				e.Handled = true;
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00005948 File Offset: 0x00003B48
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseEnter(e);
			if (this.IsInUnpinnedArea)
			{
				global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.ShowFlyoutOnMouseEnter(this);
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000595F File Offset: 0x00003B5F
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseLeave(e);
			if (this.IsInUnpinnedArea)
			{
				global::Infragistics.Windows.DockManager.UnpinnedTabFlyout.HideFlyoutOnMouseLeave(this);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00005976 File Offset: 0x00003B76
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x00005988 File Offset: 0x00003B88
		[global::System.ComponentModel.Bindable(true)]
		public bool AllowDocking
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DockManager.ContentPane.AllowDockingProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.ContentPane.AllowDockingProperty, value);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x0000599B File Offset: 0x00003B9B
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x000059AD File Offset: 0x00003BAD
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<bool>))]
		public bool? AllowDockingLeft
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Windows.DockManager.ContentPane.AllowDockingLeftProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.ContentPane.AllowDockingLeftProperty, value);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x000059C0 File Offset: 0x00003BC0
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x000059D2 File Offset: 0x00003BD2
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<bool>))]
		public bool? AllowDockingTop
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Windows.DockManager.ContentPane.AllowDockingTopProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.ContentPane.AllowDockingTopProperty, value);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x000059E5 File Offset: 0x00003BE5
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x000059F7 File Offset: 0x00003BF7
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<bool>))]
		[global::System.ComponentModel.Bindable(true)]
		public bool? AllowDockingRight
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Windows.DockManager.ContentPane.AllowDockingRightProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.ContentPane.AllowDockingRightProperty, value);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00005A0A File Offset: 0x00003C0A
		// (set) Token: 0x060000CB RID: 203 RVA: 0x00005A1C File Offset: 0x00003C1C
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<bool>))]
		public bool? AllowDockingBottom
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Windows.DockManager.ContentPane.AllowDockingBottomProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.ContentPane.AllowDockingBottomProperty, value);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00005A2F File Offset: 0x00003C2F
		// (set) Token: 0x060000CD RID: 205 RVA: 0x00005A41 File Offset: 0x00003C41
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<bool>))]
		public bool? AllowDockingFloating
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Windows.DockManager.ContentPane.AllowDockingFloatingProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.ContentPane.AllowDockingFloatingProperty, value);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00005A54 File Offset: 0x00003C54
		// (set) Token: 0x060000CF RID: 207 RVA: 0x00005A66 File Offset: 0x00003C66
		[global::System.ComponentModel.Bindable(true)]
		public bool AllowInDocumentHost
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DockManager.ContentPane.AllowInDocumentHostProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.ContentPane.AllowInDocumentHostProperty, value);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00005A79 File Offset: 0x00003C79
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x00005A8B File Offset: 0x00003C8B
		[global::System.ComponentModel.Bindable(true)]
		public bool AllowFloatingOnly
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DockManager.ContentPane.AllowFloatingOnlyProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.ContentPane.AllowFloatingOnlyProperty, value);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00005A9E File Offset: 0x00003C9E
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x00005AB0 File Offset: 0x00003CB0
		[global::System.ComponentModel.Bindable(true)]
		public bool AllowPinning
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DockManager.ContentPane.AllowPinningProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.ContentPane.AllowPinningProperty, value);
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00005AC4 File Offset: 0x00003CC4
		private static void OnAllowCloseChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.PaneToolWindow paneToolWindow = global::Infragistics.Windows.Controls.ToolWindow.GetToolWindow(d) as global::Infragistics.Windows.DockManager.PaneToolWindow;
			if (paneToolWindow != null)
			{
				paneToolWindow.RefreshToolWindowState();
			}
			global::System.Windows.Input.CommandManager.InvalidateRequerySuggested();
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00005AEB File Offset: 0x00003CEB
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x00005AFD File Offset: 0x00003CFD
		[global::System.ComponentModel.Bindable(true)]
		public bool AllowClose
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DockManager.ContentPane.AllowCloseProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.ContentPane.AllowCloseProperty, value);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00005B10 File Offset: 0x00003D10
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x00005B22 File Offset: 0x00003D22
		[global::System.ComponentModel.Bindable(true)]
		public bool AllowDockingInTabGroup
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DockManager.ContentPane.AllowDockingInTabGroupProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.ContentPane.AllowDockingInTabGroupProperty, value);
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00005B35 File Offset: 0x00003D35
		// (set) Token: 0x060000DA RID: 218 RVA: 0x00005B47 File Offset: 0x00003D47
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DockManager.PaneCloseAction CloseAction
		{
			get
			{
				return (global::Infragistics.Windows.DockManager.PaneCloseAction)base.GetValue(global::Infragistics.Windows.DockManager.ContentPane.CloseActionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.ContentPane.CloseActionProperty, value);
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00005B5A File Offset: 0x00003D5A
		// (set) Token: 0x060000DC RID: 220 RVA: 0x00005B6C File Offset: 0x00003D6C
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Visibility CloseButtonVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.DockManager.ContentPane.CloseButtonVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.ContentPane.CloseButtonVisibilityProperty, value);
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00005B7F File Offset: 0x00003D7F
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Visibility ContentVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.DockManager.ContentPane.ContentVisibilityProperty);
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00005B91 File Offset: 0x00003D91
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool HasImage
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DockManager.ContentPane.HasImageProperty);
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00005BA3 File Offset: 0x00003DA3
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::System.Windows.Visibility HeaderVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.DockManager.ContentPane.HeaderVisibilityProperty);
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00005BB5 File Offset: 0x00003DB5
		private static void OnImageChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			d.SetValue(global::Infragistics.Windows.DockManager.ContentPane.HasImagePropertyKey, (e.NewValue == null) ? global::System.Windows.DependencyProperty.UnsetValue : global::Infragistics.KnownBoxes.TrueBox);
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00005BD7 File Offset: 0x00003DD7
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x00005BE9 File Offset: 0x00003DE9
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Media.ImageSource Image
		{
			get
			{
				return (global::System.Windows.Media.ImageSource)base.GetValue(global::Infragistics.Windows.DockManager.ContentPane.ImageProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.ContentPane.ImageProperty, value);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x00005BF7 File Offset: 0x00003DF7
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsActivePane
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DockManager.ContentPane.IsActivePaneProperty);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x00005C09 File Offset: 0x00003E09
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsActiveDocument
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DockManager.ContentPane.IsActiveDocumentProperty);
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00005C1B File Offset: 0x00003E1B
		private static void OnIsFlyInSuspended(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Input.CommandManager.InvalidateRequerySuggested();
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00005C22 File Offset: 0x00003E22
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x00005C34 File Offset: 0x00003E34
		[global::System.ComponentModel.Bindable(true)]
		public bool IsFlyInSuspended
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DockManager.ContentPane.IsFlyInSuspendedProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.ContentPane.IsFlyInSuspendedProperty, value);
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00005C47 File Offset: 0x00003E47
		private static void OnIsPinnedChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.DockManager.ContentPane)d).VerifyIsPinnedState();
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00005C54 File Offset: 0x00003E54
		// (set) Token: 0x060000EA RID: 234 RVA: 0x00005C66 File Offset: 0x00003E66
		[global::System.ComponentModel.Bindable(true)]
		public bool IsPinned
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DockManager.ContentPane.IsPinnedProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.ContentPane.IsPinnedProperty, value);
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000EB RID: 235 RVA: 0x00005C79 File Offset: 0x00003E79
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Description("Returns or sets a boolean indicating if the pane is providing the caption of the floating PaneToolWindow")]
		[global::System.ComponentModel.Category("Behavior")]
		public bool IsProvidingFloatingWindowCaption
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DockManager.ContentPane.IsProvidingFloatingWindowCaptionProperty);
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00005C8B File Offset: 0x00003E8B
		private static void OnIsVisibleResolvedPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.DockManager.ContentPane)d).RaiseIsVisibleResolvedChanged(new global::System.Windows.RoutedEventArgs());
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000ED RID: 237 RVA: 0x00005C9D File Offset: 0x00003E9D
		// (set) Token: 0x060000EE RID: 238 RVA: 0x00005CAF File Offset: 0x00003EAF
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsVisibleResolved
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DockManager.ContentPane.IsVisibleResolvedProperty);
			}
			private set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.ContentPane.IsVisibleResolvedPropertyKey, value);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000EF RID: 239 RVA: 0x00005CC2 File Offset: 0x00003EC2
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x00005CCF File Offset: 0x00003ECF
		[global::System.ComponentModel.Bindable(true)]
		public object NavigatorDescription
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.DockManager.ContentPane.NavigatorDescriptionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.ContentPane.NavigatorDescriptionProperty, value);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00005CDD File Offset: 0x00003EDD
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x00005CEF File Offset: 0x00003EEF
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.DataTemplate NavigatorDescriptionTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Windows.DockManager.ContentPane.NavigatorDescriptionTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.ContentPane.NavigatorDescriptionTemplateProperty, value);
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x00005CFD File Offset: 0x00003EFD
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x00005D0F File Offset: 0x00003F0F
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Controls.DataTemplateSelector NavigatorDescriptionTemplateSelector
		{
			get
			{
				return (global::System.Windows.Controls.DataTemplateSelector)base.GetValue(global::Infragistics.Windows.DockManager.ContentPane.NavigatorDescriptionTemplateSelectorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.ContentPane.NavigatorDescriptionTemplateSelectorProperty, value);
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00005D1D File Offset: 0x00003F1D
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x00005D2A File Offset: 0x00003F2A
		[global::System.ComponentModel.Bindable(true)]
		public object NavigatorTitle
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.DockManager.ContentPane.NavigatorTitleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.ContentPane.NavigatorTitleProperty, value);
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00005D38 File Offset: 0x00003F38
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x00005D4A File Offset: 0x00003F4A
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.DataTemplate NavigatorTitleTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Windows.DockManager.ContentPane.NavigatorTitleTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.ContentPane.NavigatorTitleTemplateProperty, value);
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x00005D58 File Offset: 0x00003F58
		// (set) Token: 0x060000FA RID: 250 RVA: 0x00005D6A File Offset: 0x00003F6A
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Controls.DataTemplateSelector NavigatorTitleTemplateSelector
		{
			get
			{
				return (global::System.Windows.Controls.DataTemplateSelector)base.GetValue(global::Infragistics.Windows.DockManager.ContentPane.NavigatorTitleTemplateSelectorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.ContentPane.NavigatorTitleTemplateSelectorProperty, value);
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000FB RID: 251 RVA: 0x00005D78 File Offset: 0x00003F78
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DockManager.PaneLocation PaneLocation
		{
			get
			{
				return (global::Infragistics.Windows.DockManager.PaneLocation)base.GetValue(global::Infragistics.Windows.DockManager.ContentPane.PaneLocationProperty);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000FC RID: 252 RVA: 0x00005D8A File Offset: 0x00003F8A
		// (set) Token: 0x060000FD RID: 253 RVA: 0x00005D9C File Offset: 0x00003F9C
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Visibility PinButtonVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.DockManager.ContentPane.PinButtonVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.ContentPane.PinButtonVisibilityProperty, value);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000FE RID: 254 RVA: 0x00005DAF File Offset: 0x00003FAF
		// (set) Token: 0x060000FF RID: 255 RVA: 0x00005DC1 File Offset: 0x00003FC1
		[global::System.ComponentModel.Bindable(true)]
		public bool SaveInLayout
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DockManager.ContentPane.SaveInLayoutProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.ContentPane.SaveInLayoutProperty, value);
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00005DD4 File Offset: 0x00003FD4
		// (set) Token: 0x06000101 RID: 257 RVA: 0x00005DE6 File Offset: 0x00003FE6
		[global::System.ComponentModel.Bindable(true)]
		public string SerializationId
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DockManager.ContentPane.SerializationIdProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.ContentPane.SerializationIdProperty, value);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000102 RID: 258 RVA: 0x00005DF4 File Offset: 0x00003FF4
		// (set) Token: 0x06000103 RID: 259 RVA: 0x00005E01 File Offset: 0x00004001
		[global::System.ComponentModel.Bindable(true)]
		public object TabHeader
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.DockManager.ContentPane.TabHeaderProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.ContentPane.TabHeaderProperty, value);
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000104 RID: 260 RVA: 0x00005E0F File Offset: 0x0000400F
		// (set) Token: 0x06000105 RID: 261 RVA: 0x00005E21 File Offset: 0x00004021
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.DataTemplate TabHeaderTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Windows.DockManager.ContentPane.TabHeaderTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.ContentPane.TabHeaderTemplateProperty, value);
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000106 RID: 262 RVA: 0x00005E2F File Offset: 0x0000402F
		// (set) Token: 0x06000107 RID: 263 RVA: 0x00005E41 File Offset: 0x00004041
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Controls.DataTemplateSelector TabHeaderTemplateSelector
		{
			get
			{
				return (global::System.Windows.Controls.DataTemplateSelector)base.GetValue(global::Infragistics.Windows.DockManager.ContentPane.TabHeaderTemplateSelectorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.ContentPane.TabHeaderTemplateSelectorProperty, value);
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000108 RID: 264 RVA: 0x00005E4F File Offset: 0x0000404F
		// (set) Token: 0x06000109 RID: 265 RVA: 0x00005E61 File Offset: 0x00004061
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Visibility WindowPositionMenuVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.DockManager.ContentPane.WindowPositionMenuVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.ContentPane.WindowPositionMenuVisibilityProperty, value);
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600010A RID: 266 RVA: 0x00005E74 File Offset: 0x00004074
		internal bool AllowAnimations
		{
			get
			{
				global::Infragistics.Windows.DockManager.HwndHostInfo hwndHost = global::Infragistics.Windows.DockManager.HwndHostInfo.GetHwndHost(this);
				return hwndHost == null || !hwndHost.HasHwndHost;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00005E98 File Offset: 0x00004098
		internal global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations AllowedDropLocations
		{
			get
			{
				global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations allowedDropLocations = (global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations)this.DockableAreas;
				if (this.AllowInDocumentHost)
				{
					allowedDropLocations |= global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations.Document;
				}
				return allowedDropLocations;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00005EBA File Offset: 0x000040BA
		internal bool CanActivate
		{
			get
			{
				return base.Visibility == global::System.Windows.Visibility.Visible && base.IsEnabled;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00005ECC File Offset: 0x000040CC
		internal bool CanCloseAllButThis
		{
			get
			{
				if (this.PaneLocation == global::Infragistics.Windows.DockManager.PaneLocation.Document)
				{
					global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
					global::Infragistics.Windows.DockManager.DocumentContentHost documentContentHost = (dockManager != null) ? dockManager.DocumentContentHost : null;
					if (documentContentHost != null)
					{
						for (global::Infragistics.Windows.DockManager.ContentPane contentPane = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetFirstLastPane(documentContentHost, true, global::Infragistics.Windows.DockManager.PaneFilterFlags.AllVisible); contentPane != null; contentPane = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetNextPreviousPane(contentPane, false, true, documentContentHost))
						{
							if (contentPane != this && contentPane.AllowClose)
							{
								return true;
							}
						}
					}
				}
				return false;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00005F24 File Offset: 0x00004124
		internal bool CanShowInPopup
		{
			get
			{
				global::Infragistics.Windows.DockManager.HwndHostInfo hwndHost = global::Infragistics.Windows.DockManager.HwndHostInfo.GetHwndHost(this);
				return hwndHost == null || !hwndHost.HasHwndHost || !(global::Infragistics.Windows.DockManager.HwndHostInfo.WebBrowserType != null) || global::Infragistics.Windows.DockManager.DockManagerUtilities.CanHostBrowserInPopup || !hwndHost.HasWebBrowser;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00005F64 File Offset: 0x00004164
		internal bool CanToggleDockedState
		{
			get
			{
				switch (global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(this))
				{
				case global::Infragistics.Windows.DockManager.PaneLocation.DockedLeft:
				case global::Infragistics.Windows.DockManager.PaneLocation.DockedRight:
				case global::Infragistics.Windows.DockManager.PaneLocation.DockedTop:
				case global::Infragistics.Windows.DockManager.PaneLocation.DockedBottom:
					return this.IsDockingAllowed(global::Infragistics.Windows.DockManager.PaneLocation.Floating);
				case global::Infragistics.Windows.DockManager.PaneLocation.Floating:
					return (this.DockableAreas & ~global::Infragistics.Windows.DockManager.DockableAreas.Floating) != global::Infragistics.Windows.DockManager.DockableAreas.None;
				default:
					return false;
				}
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000110 RID: 272 RVA: 0x00005FB0 File Offset: 0x000041B0
		internal bool CanTogglePinnedState
		{
			get
			{
				if (!this.AllowPinning)
				{
					return false;
				}
				switch (global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(this))
				{
				case global::Infragistics.Windows.DockManager.PaneLocation.DockedLeft:
				case global::Infragistics.Windows.DockManager.PaneLocation.DockedRight:
				case global::Infragistics.Windows.DockManager.PaneLocation.DockedTop:
				case global::Infragistics.Windows.DockManager.PaneLocation.DockedBottom:
				case global::Infragistics.Windows.DockManager.PaneLocation.Unpinned:
					return true;
				}
				return false;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000111 RID: 273 RVA: 0x00005FF7 File Offset: 0x000041F7
		internal global::Infragistics.Windows.Commands.CommandsBase Commands
		{
			get
			{
				return this._commands;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00006000 File Offset: 0x00004200
		internal global::Infragistics.Windows.DockManager.DockableAreas DockableAreas
		{
			get
			{
				global::Infragistics.Windows.DockManager.DockableAreas dockableAreas = global::Infragistics.Windows.DockManager.DockableAreas.None;
				if (this.IsDockingAllowed(global::Infragistics.Windows.DockManager.PaneLocation.DockedBottom))
				{
					dockableAreas |= global::Infragistics.Windows.DockManager.DockableAreas.Bottom;
				}
				if (this.IsDockingAllowed(global::Infragistics.Windows.DockManager.PaneLocation.DockedLeft))
				{
					dockableAreas |= global::Infragistics.Windows.DockManager.DockableAreas.Left;
				}
				if (this.IsDockingAllowed(global::Infragistics.Windows.DockManager.PaneLocation.DockedRight))
				{
					dockableAreas |= global::Infragistics.Windows.DockManager.DockableAreas.Right;
				}
				if (this.IsDockingAllowed(global::Infragistics.Windows.DockManager.PaneLocation.DockedTop))
				{
					dockableAreas |= global::Infragistics.Windows.DockManager.DockableAreas.Top;
				}
				if (this.IsDockingAllowed(global::Infragistics.Windows.DockManager.PaneLocation.Floating))
				{
					dockableAreas |= global::Infragistics.Windows.DockManager.DockableAreas.Floating;
				}
				return dockableAreas;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000113 RID: 275 RVA: 0x00006054 File Offset: 0x00004254
		internal bool HasHwndHost
		{
			get
			{
				global::Infragistics.Windows.DockManager.HwndHostInfo hwndHost = global::Infragistics.Windows.DockManager.HwndHostInfo.GetHwndHost(this);
				return hwndHost != null && hwndHost.HasHwndHost;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00006073 File Offset: 0x00004273
		internal global::Infragistics.Windows.DockManager.PaneHeaderPresenter HeaderPresenter
		{
			get
			{
				if (this._paneHeaderPresenter == null)
				{
					return null;
				}
				return global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._paneHeaderPresenter) as global::Infragistics.Windows.DockManager.PaneHeaderPresenter;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000115 RID: 277 RVA: 0x0000608F File Offset: 0x0000428F
		internal bool IsActivating
		{
			get
			{
				return this._isActivating;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000116 RID: 278 RVA: 0x00006097 File Offset: 0x00004297
		internal bool IsKeyboardFocusWithinEx
		{
			get
			{
				return base.IsKeyboardFocusWithin || global::Infragistics.Windows.DockManager.ActivePaneManager.GetIsKeyboardFocusWithinEx(this) || this.HasFocusInHwndHost();
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000117 RID: 279 RVA: 0x000060B4 File Offset: 0x000042B4
		internal bool IsCurrentFlyoutPane
		{
			get
			{
				global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
				return dockManager != null && dockManager.CurrentFlyoutPane == this;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000118 RID: 280 RVA: 0x000060D6 File Offset: 0x000042D6
		internal bool IsDockable
		{
			get
			{
				return global::Infragistics.Windows.DockManager.DockManagerUtilities.IsDockable(global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(this));
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000119 RID: 281 RVA: 0x000060E3 File Offset: 0x000042E3
		internal bool IsDocument
		{
			get
			{
				return global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(this) == global::Infragistics.Windows.DockManager.PaneLocation.Document;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600011A RID: 282 RVA: 0x000060EE File Offset: 0x000042EE
		internal bool IsInUnpinnedArea
		{
			get
			{
				return global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(this) == global::Infragistics.Windows.DockManager.PaneLocation.Unpinned;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600011B RID: 283 RVA: 0x000060F9 File Offset: 0x000042F9
		// (set) Token: 0x0600011C RID: 284 RVA: 0x00006101 File Offset: 0x00004301
		internal global::System.DateTime LastActivatedTime
		{
			get
			{
				return this._lastActivatedTime;
			}
			set
			{
				this._lastActivatedTime = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600011D RID: 285 RVA: 0x0000610A File Offset: 0x0000430A
		// (set) Token: 0x0600011E RID: 286 RVA: 0x00006112 File Offset: 0x00004312
		internal global::System.Windows.Point? LastFloatingLocation
		{
			get
			{
				return this._lastFloatingLocation;
			}
			set
			{
				this._lastFloatingLocation = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600011F RID: 287 RVA: 0x0000611B File Offset: 0x0000431B
		// (set) Token: 0x06000120 RID: 288 RVA: 0x00006123 File Offset: 0x00004323
		internal global::System.Windows.Size LastFloatingSize
		{
			get
			{
				return this._lastFloatingSize;
			}
			set
			{
				this._lastFloatingSize = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000121 RID: 289 RVA: 0x0000612C File Offset: 0x0000432C
		// (set) Token: 0x06000122 RID: 290 RVA: 0x00006134 File Offset: 0x00004334
		internal global::System.Windows.Rect LastFloatingWindowRect
		{
			get
			{
				return this._lastFloatingWindowRect;
			}
			set
			{
				this._lastFloatingWindowRect = value;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000123 RID: 291 RVA: 0x0000613D File Offset: 0x0000433D
		internal global::Infragistics.Windows.DockManager.ContentPane.PanePlacementInfo PlacementInfo
		{
			get
			{
				return this._placementInfo;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00006145 File Offset: 0x00004345
		// (set) Token: 0x06000125 RID: 293 RVA: 0x0000614D File Offset: 0x0000434D
		internal bool SuppressFlyoutDuringActivate
		{
			get
			{
				return this._suppressFlyoutDuringActivate;
			}
			set
			{
				this._suppressFlyoutDuringActivate = value;
			}
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00006156 File Offset: 0x00004356
		public bool Activate()
		{
			return this.ActivateInternal();
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0000615E File Offset: 0x0000435E
		public bool ExecuteCommand(global::System.Windows.Input.RoutedCommand command)
		{
			return this.ExecuteCommandImpl(new global::Infragistics.Windows.Commands.ExecuteCommandInfo(command));
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0000616C File Offset: 0x0000436C
		protected virtual void SetVisualState(bool useTransitions)
		{
			if (base.IsEnabled)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Normal", useTransitions);
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Disabled", useTransitions);
			}
			if (this.IsActivePane)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Active", useTransitions);
			}
			else if (this.IsActiveDocument)
			{
				global::Infragistics.VisualStateUtilities.GoToState(this, useTransitions, new string[]
				{
					"ActiveDocument",
					"Inactive"
				});
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Inactive", useTransitions);
			}
			string text = null;
			switch (this.PaneLocation)
			{
			case global::Infragistics.Windows.DockManager.PaneLocation.DockedLeft:
				text = "DockedLeft";
				break;
			case global::Infragistics.Windows.DockManager.PaneLocation.DockedRight:
				text = "DockedRight";
				break;
			case global::Infragistics.Windows.DockManager.PaneLocation.DockedTop:
				text = "DockedTop";
				break;
			case global::Infragistics.Windows.DockManager.PaneLocation.DockedBottom:
				text = "DockedBottom";
				break;
			case global::Infragistics.Windows.DockManager.PaneLocation.Floating:
				text = "Floating";
				break;
			case global::Infragistics.Windows.DockManager.PaneLocation.Unpinned:
				text = "Unpinned";
				break;
			case global::Infragistics.Windows.DockManager.PaneLocation.Document:
				text = "Document";
				break;
			}
			if (text != null)
			{
				global::System.Windows.VisualStateManager.GoToState(this, text, useTransitions);
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00006260 File Offset: 0x00004460
		private static void OnVisualStatePropertyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.ContentPane contentPane = target as global::Infragistics.Windows.DockManager.ContentPane;
			contentPane.UpdateVisualStates();
		}

		// Token: 0x0600012A RID: 298 RVA: 0x0000627A File Offset: 0x0000447A
		protected void UpdateVisualStates()
		{
			this.UpdateVisualStates(true);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00006284 File Offset: 0x00004484
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
			global::Infragistics.Windows.DockManager.PaneHeaderPresenter headerPresenter = this.HeaderPresenter;
			if (headerPresenter != null)
			{
				headerPresenter.UpdateVisualStates(useTransitions);
			}
		}

		// Token: 0x0600012C RID: 300 RVA: 0x000062BD File Offset: 0x000044BD
		internal bool ActivateInternal()
		{
			return this.ActivateInternal(false);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x000062C6 File Offset: 0x000044C6
		internal bool ActivateInternal(bool force)
		{
			return this.ActivateInternal(force, true);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x000062D0 File Offset: 0x000044D0
		internal bool ActivateInternal(bool force, bool bringIntoView)
		{
			return this.ActivateInternal(force, bringIntoView, false);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x000062DC File Offset: 0x000044DC
		internal bool ActivateInternal(bool force, bool bringIntoView, bool restoreMinimizedToolWindow)
		{
			if (this._isActivating)
			{
				return this.IsKeyboardFocusWithinEx;
			}
			bool result;
			try
			{
				this._isActivating = true;
				result = this.ActivateInternalImpl(force, bringIntoView, restoreMinimizedToolWindow);
			}
			finally
			{
				this._isActivating = false;
			}
			return result;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00006324 File Offset: 0x00004524
		private bool ActivateInternalImpl(bool force, bool bringIntoView, bool restoreMinimizedToolWindow)
		{
			bool focusable = base.Focusable;
			if ((base.Content != null || focusable) && this.CanActivate && (force || !this.IsKeyboardFocusWithinEx))
			{
				global::System.Windows.Window window = global::System.Windows.Window.GetWindow(this);
				bool flag = false;
				if (window != null && !global::System.Windows.Interop.BrowserInteropHelper.IsBrowserHosted)
				{
					global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
					if (dockManager != null)
					{
						dockManager.SuspendShowFlyout();
					}
					try
					{
						try
						{
							flag = global::Infragistics.Windows.DockManager.DockManagerUtilities.Activate(window);
						}
						catch
						{
						}
						goto IL_7E;
					}
					finally
					{
						if (dockManager != null)
						{
							dockManager.ResumeShowFlyout();
						}
					}
				}
				global::Infragistics.Windows.Controls.ToolWindow toolWindow = global::Infragistics.Windows.Controls.ToolWindow.GetToolWindow(this);
				if (toolWindow != null)
				{
					toolWindow.Activate();
					flag = true;
				}
				IL_7E:
				if (flag)
				{
					global::Infragistics.Windows.DockManager.XamDockManager dockManager2 = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
					if (dockManager2 != null && global::System.Windows.Input.Keyboard.FocusedElement == null && this.PaneLocation == global::Infragistics.Windows.DockManager.PaneLocation.Unpinned)
					{
						dockManager2.ForceFocus();
					}
				}
				if (restoreMinimizedToolWindow)
				{
					global::Infragistics.Windows.DockManager.DockManagerUtilities.RestoreMinimizedToolWindow(this);
					if (global::Infragistics.Windows.Controls.ToolWindow.GetToolWindow(this) == null && this.PaneLocation != global::Infragistics.Windows.DockManager.PaneLocation.Unknown && !global::Infragistics.Windows.DockManager.DockManagerUtilities.IsFloating(this.PaneLocation))
					{
						global::Infragistics.Windows.DockManager.DockManagerUtilities.RestoreMinimizedWindow(global::System.Windows.Window.GetWindow(this));
					}
				}
				if (bringIntoView)
				{
					base.BringIntoView();
					base.UpdateLayout();
				}
				global::System.Windows.DependencyObject focusScope = global::System.Windows.Input.FocusManager.GetFocusScope(this);
				global::System.Windows.IInputElement focusedElement = global::System.Windows.Input.FocusManager.GetFocusedElement(focusScope ?? this);
				if (window != null)
				{
					global::Infragistics.Windows.DockManager.PaneToolWindow paneToolWindow = global::Infragistics.Windows.Controls.ToolWindow.GetToolWindow(this) as global::Infragistics.Windows.DockManager.PaneToolWindow;
					if (paneToolWindow != null && paneToolWindow.Host != null && paneToolWindow.Host.IsWindow)
					{
						paneToolWindow.ClearDragHelperFocusedElement();
					}
				}
				global::System.Windows.IInputElement focusedElement2 = global::System.Windows.Input.Keyboard.FocusedElement;
				if (focusedElement == null || !(focusedElement is global::System.Windows.DependencyObject) || !global::Infragistics.Windows.Utilities.IsDescendantOf(this, (global::System.Windows.DependencyObject)focusedElement))
				{
					bool flag2 = focusable && this.FocusElementDuringActivate(this);
					if (!focusable || flag2)
					{
						global::System.Windows.Input.TraversalRequest request = new global::System.Windows.Input.TraversalRequest(global::System.Windows.Input.FocusNavigationDirection.First);
						return this.MoveFocus(request) || flag2;
					}
				}
				else
				{
					if (this.FocusElementDuringActivate(focusedElement))
					{
						return true;
					}
					global::System.Windows.DependencyObject dependencyObject = focusedElement as global::System.Windows.DependencyObject;
					bool flag3 = false;
					if (dependencyObject != null && (false.Equals(dependencyObject.GetValue(global::System.Windows.UIElement.IsVisibleProperty)) || false.Equals(dependencyObject.GetValue(global::System.Windows.UIElement.IsEnabledProperty))))
					{
						flag3 = true;
					}
					if (flag3)
					{
						if (global::Infragistics.Windows.DockManager.DockManagerUtilities.MoveFocus(dependencyObject, new global::System.Windows.Input.TraversalRequest(global::System.Windows.Input.FocusNavigationDirection.Next)) && this.IsKeyboardFocusWithinEx)
						{
							return true;
						}
						if (this.FocusElementDuringActivate(this))
						{
							return true;
						}
					}
				}
				global::System.Windows.IInputElement focusedElement3 = global::System.Windows.Input.Keyboard.FocusedElement;
				if (focusedElement2 == focusedElement3 && base.IsVisible && base.IsEnabled && global::Infragistics.Windows.DockManager.DockManagerUtilities.IsInDisabledWindow(window))
				{
					global::Infragistics.Windows.DockManager.XamDockManager dockManager3 = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
					if (dockManager3 != null && dockManager3.ActivePane == null)
					{
						dockManager3.ActivePaneManager.MoveToFront(this);
						if (this.PaneLocation == global::Infragistics.Windows.DockManager.PaneLocation.Document)
						{
							dockManager3.ActivePaneManager.SetActiveDocument(this);
						}
					}
				}
			}
			return this.IsKeyboardFocusWithinEx;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x000065A8 File Offset: 0x000047A8
		internal bool ChangeToDockable()
		{
			global::Infragistics.Windows.DockManager.IContentPaneContainer currentContainer = this.PlacementInfo.CurrentContainer;
			global::Infragistics.Windows.DockManager.IContentPaneContainer contentPaneContainer = this.PlacementInfo.DockableContainer;
			global::Infragistics.Windows.DockManager.SplitPane splitPane = null;
			if (contentPaneContainer == currentContainer)
			{
				return false;
			}
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
			if (dockManager == null)
			{
				return false;
			}
			if (global::Infragistics.Windows.DockManager.DockManagerUtilities.IsDockable(this.PaneLocation))
			{
				return false;
			}
			if (global::Infragistics.Windows.DockManager.DockManagerUtilities.IsFloating(this.PaneLocation) && contentPaneContainer != null && global::Infragistics.Windows.DockManager.DockManagerUtilities.IsDocked(contentPaneContainer.PaneLocation))
			{
				if (this.PlacementInfo.FloatingDockablePlaceholder != null)
				{
					contentPaneContainer = this.PlacementInfo.FloatingDockablePlaceholder.Container;
				}
				else if (this.IsDockingAllowed(global::Infragistics.Windows.DockManager.PaneLocation.Floating))
				{
					contentPaneContainer = null;
				}
			}
			if (contentPaneContainer != null && !dockManager.IsPaneLocationVisible(contentPaneContainer.PaneLocation))
			{
				if (contentPaneContainer.PaneLocation == global::Infragistics.Windows.DockManager.PaneLocation.Floating)
				{
					contentPaneContainer = this.PlacementInfo.DockedContainer;
					if (contentPaneContainer != null && !dockManager.IsPaneLocationVisible(contentPaneContainer.PaneLocation))
					{
						return false;
					}
				}
				else
				{
					if (!dockManager.IsPaneLocationVisible(global::Infragistics.Windows.DockManager.PaneLocation.Floating))
					{
						return false;
					}
					if (this.PlacementInfo.FloatingDockablePlaceholder != null)
					{
						contentPaneContainer = this.PlacementInfo.FloatingDockablePlaceholder.Container;
					}
					else
					{
						contentPaneContainer = null;
					}
				}
			}
			if (contentPaneContainer == null)
			{
				splitPane = global::Infragistics.Windows.DockManager.DockManagerUtilities.CreateSplitPane(dockManager);
				global::Infragistics.Windows.DockManager.InitialPaneLocation value = global::Infragistics.Windows.DockManager.InitialPaneLocation.DockableFloating;
				if (this.IsDockingAllowed(global::Infragistics.Windows.DockManager.PaneLocation.Floating))
				{
					global::Infragistics.Windows.DockManager.XamDockManager.SetFloatingSize(splitPane, this.GetSizeForFloating());
					if (this.LastFloatingLocation != null)
					{
						global::Infragistics.Windows.DockManager.XamDockManager.SetFloatingLocation(splitPane, this.LastFloatingLocation);
					}
				}
				else if (this.IsDockingAllowed(global::Infragistics.Windows.DockManager.PaneLocation.DockedLeft))
				{
					value = global::Infragistics.Windows.DockManager.InitialPaneLocation.DockedLeft;
				}
				else if (this.IsDockingAllowed(global::Infragistics.Windows.DockManager.PaneLocation.DockedBottom))
				{
					value = global::Infragistics.Windows.DockManager.InitialPaneLocation.DockedBottom;
				}
				else if (this.IsDockingAllowed(global::Infragistics.Windows.DockManager.PaneLocation.DockedRight))
				{
					value = global::Infragistics.Windows.DockManager.InitialPaneLocation.DockedRight;
				}
				else
				{
					if (!this.IsDockingAllowed(global::Infragistics.Windows.DockManager.PaneLocation.DockedTop))
					{
						return false;
					}
					value = global::Infragistics.Windows.DockManager.InitialPaneLocation.DockedTop;
				}
				global::Infragistics.Windows.DockManager.XamDockManager.SetInitialLocation(splitPane, value);
				contentPaneContainer = splitPane;
			}
			using (global::Infragistics.Windows.DockManager.MovePaneHelper movePaneHelper = new global::Infragistics.Windows.DockManager.MovePaneHelper(dockManager, contentPaneContainer, new global::Infragistics.Windows.DockManager.ContentPane[]
			{
				this
			}))
			{
				if (splitPane != null)
				{
					dockManager.Panes.Add(splitPane);
				}
				global::Infragistics.Windows.DockManager.DockManagerUtilities.MovePane(this, contentPaneContainer, null, contentPaneContainer.PaneLocation, movePaneHelper);
			}
			global::Infragistics.Windows.DockManager.DockManagerUtilities.RemoveContainerIfNeeded(currentContainer);
			this.ActivateInternal(true, true, true);
			return true;
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00006798 File Offset: 0x00004998
		internal bool ChangeToDocument()
		{
			if (this.IsDocument)
			{
				return false;
			}
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
			if (dockManager == null)
			{
				return false;
			}
			global::Infragistics.Windows.DockManager.DocumentContentHost documentContentHost = dockManager.DocumentContentHost;
			global::Infragistics.Windows.DockManager.IContentPaneContainer currentContainer = this.PlacementInfo.CurrentContainer;
			global::Infragistics.Windows.DockManager.IContentPaneContainer containerForPane = documentContentHost.GetContainerForPane(this, true);
			if (containerForPane == null)
			{
				return false;
			}
			global::Infragistics.Windows.DockManager.DockManagerUtilities.MovePane(this, containerForPane, new int?(0), containerForPane.PaneLocation);
			global::Infragistics.Windows.DockManager.DockManagerUtilities.RemoveContainerIfNeeded(currentContainer);
			this.ActivateInternal(true, true, true);
			return true;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00006800 File Offset: 0x00004A00
		internal bool ChangeToFloatingOnly()
		{
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
			if (dockManager == null)
			{
				return false;
			}
			if (this.PaneLocation == global::Infragistics.Windows.DockManager.PaneLocation.FloatingOnly)
			{
				return false;
			}
			global::Infragistics.Windows.DockManager.ContentPane.PanePlacementInfo placementInfo = this.PlacementInfo;
			global::Infragistics.Windows.DockManager.IContentPaneContainer currentContainer = placementInfo.CurrentContainer;
			global::Infragistics.Windows.DockManager.ContentPanePlaceholder floatingOnlyPlaceholder = placementInfo.FloatingOnlyPlaceholder;
			global::Infragistics.Windows.DockManager.SplitPane splitPane = null;
			global::Infragistics.Windows.DockManager.IContentPaneContainer contentPaneContainer;
			if (floatingOnlyPlaceholder != null)
			{
				contentPaneContainer = floatingOnlyPlaceholder.Container;
			}
			else
			{
				splitPane = global::Infragistics.Windows.DockManager.DockManagerUtilities.CreateSplitPane(dockManager);
				global::Infragistics.Windows.DockManager.XamDockManager.SetInitialLocation(splitPane, global::Infragistics.Windows.DockManager.InitialPaneLocation.FloatingOnly);
				global::System.Windows.Size sizeForFloating = this.GetSizeForFloating();
				global::Infragistics.Windows.DockManager.XamDockManager.SetFloatingSize(splitPane, sizeForFloating);
				if (this.LastFloatingLocation != null)
				{
					global::Infragistics.Windows.DockManager.XamDockManager.SetFloatingLocation(splitPane, this.LastFloatingLocation);
				}
				contentPaneContainer = splitPane;
			}
			if (contentPaneContainer == null)
			{
				return false;
			}
			using (global::Infragistics.Windows.DockManager.MovePaneHelper movePaneHelper = new global::Infragistics.Windows.DockManager.MovePaneHelper(dockManager, contentPaneContainer, new global::Infragistics.Windows.DockManager.ContentPane[]
			{
				this
			}))
			{
				if (splitPane != null)
				{
					dockManager.Panes.Add(splitPane);
				}
				global::Infragistics.Windows.DockManager.DockManagerUtilities.MovePane(this, contentPaneContainer, null, contentPaneContainer.PaneLocation, movePaneHelper);
			}
			global::Infragistics.Windows.DockManager.DockManagerUtilities.RemoveContainerIfNeeded(currentContainer);
			this.ActivateInternal(true, true, true);
			return true;
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0000690C File Offset: 0x00004B0C
		internal void ClearHeader(global::Infragistics.Windows.DockManager.PaneHeaderPresenter header)
		{
			if (base.Header == header)
			{
				this._paneHeaderPresenter = null;
			}
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00006920 File Offset: 0x00004B20
		internal global::System.Windows.Size GetSizeForFloating()
		{
			global::System.Windows.Size lastFloatingSize = this.LastFloatingSize;
			if (lastFloatingSize.IsEmpty)
			{
				lastFloatingSize = new global::System.Windows.Size(base.ActualWidth, base.ActualHeight);
			}
			return lastFloatingSize;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00006954 File Offset: 0x00004B54
		internal global::System.Windows.FrameworkElement GetFocusedHwndHost()
		{
			global::Infragistics.Windows.DockManager.HwndHostInfo hwndHost = global::Infragistics.Windows.DockManager.HwndHostInfo.GetHwndHost(this);
			if (hwndHost == null)
			{
				return null;
			}
			return hwndHost.GetFocusedHwndHost();
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00006974 File Offset: 0x00004B74
		internal bool HasFocusInHwndHost()
		{
			global::Infragistics.Windows.DockManager.HwndHostInfo hwndHost = global::Infragistics.Windows.DockManager.HwndHostInfo.GetHwndHost(this);
			return hwndHost != null && hwndHost.HasFocusWithin();
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00006994 File Offset: 0x00004B94
		internal void HideAllHwndHosts()
		{
			global::Infragistics.Windows.DockManager.HwndHostInfo hwndHost = global::Infragistics.Windows.DockManager.HwndHostInfo.GetHwndHost(this);
			if (hwndHost != null)
			{
				hwndHost.HideAll();
			}
		}

		// Token: 0x06000139 RID: 313 RVA: 0x000069B4 File Offset: 0x00004BB4
		internal bool IsDockingAllowed(global::Infragistics.Windows.DockManager.PaneLocation location)
		{
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
			if (dockManager != null && !dockManager.IsPaneLocationVisible(location))
			{
				return false;
			}
			global::System.Windows.DependencyProperty dp;
			switch (location)
			{
			case global::Infragistics.Windows.DockManager.PaneLocation.DockedLeft:
				dp = global::Infragistics.Windows.DockManager.ContentPane.AllowDockingLeftProperty;
				break;
			case global::Infragistics.Windows.DockManager.PaneLocation.DockedRight:
				dp = global::Infragistics.Windows.DockManager.ContentPane.AllowDockingRightProperty;
				break;
			case global::Infragistics.Windows.DockManager.PaneLocation.DockedTop:
				dp = global::Infragistics.Windows.DockManager.ContentPane.AllowDockingTopProperty;
				break;
			case global::Infragistics.Windows.DockManager.PaneLocation.DockedBottom:
				dp = global::Infragistics.Windows.DockManager.ContentPane.AllowDockingBottomProperty;
				break;
			case global::Infragistics.Windows.DockManager.PaneLocation.Floating:
				dp = global::Infragistics.Windows.DockManager.ContentPane.AllowDockingFloatingProperty;
				break;
			default:
				return false;
			}
			bool? flag = (bool?)base.GetValue(dp);
			if (flag != null)
			{
				return flag.Value;
			}
			return location == global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(this) || this.AllowDocking;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00006A51 File Offset: 0x00004C51
		internal void InitializeHeader(global::Infragistics.Windows.DockManager.PaneHeaderPresenter header)
		{
			this._paneHeaderPresenter = new global::System.WeakReference(header);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00006A60 File Offset: 0x00004C60
		internal void InitializeMenu(global::System.Windows.Controls.ItemCollection items)
		{
			bool isDocument = this.IsDocument;
			int count = items.Count;
			if (isDocument)
			{
				this.AddMenuItem(global::Infragistics.Windows.DockManager.PaneMenuItem.Close, items);
				this.AddMenuItem(global::Infragistics.Windows.DockManager.PaneMenuItem.CloseAllButThis, items);
			}
			int count2 = items.Count;
			this.AddMenuItem(global::Infragistics.Windows.DockManager.PaneMenuItem.FloatingOnly, items);
			this.AddMenuItem(global::Infragistics.Windows.DockManager.PaneMenuItem.Dockable, items);
			this.AddMenuItem(global::Infragistics.Windows.DockManager.PaneMenuItem.Document, items);
			this.AddMenuItem(global::Infragistics.Windows.DockManager.PaneMenuItem.AutoHide, items);
			this.AddMenuItem(global::Infragistics.Windows.DockManager.PaneMenuItem.Hide, items);
			int count3 = items.Count;
			if (isDocument)
			{
				this.AddMenuItem(global::Infragistics.Windows.DockManager.PaneMenuItem.NewHorizontalTabGroup, items);
				this.AddMenuItem(global::Infragistics.Windows.DockManager.PaneMenuItem.NewVerticalTabGroup, items);
				this.AddMenuItem(global::Infragistics.Windows.DockManager.PaneMenuItem.NextTabGroup, items);
				this.AddMenuItem(global::Infragistics.Windows.DockManager.PaneMenuItem.PreviousTabGroup, items);
				int count4 = items.Count;
				if (count2 != count3 && count3 != count4)
				{
					this.InsertMenuItem(global::Infragistics.Windows.DockManager.PaneMenuItem.Separator, count3, items);
				}
				if (count != count2 && count2 != count4)
				{
					this.InsertMenuItem(global::Infragistics.Windows.DockManager.PaneMenuItem.Separator, count2, items);
				}
			}
			this.RaiseOptionsMenuOpening(new global::Infragistics.Windows.DockManager.Events.PaneOptionsMenuOpeningEventArgs(items));
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00006B34 File Offset: 0x00004D34
		internal static void OnPaneContextMenuOpening(object sender, global::System.Windows.Controls.ContextMenuEventArgs e)
		{
			global::System.Windows.FrameworkElement frameworkElement = sender as global::System.Windows.FrameworkElement;
			global::Infragistics.Windows.DockManager.ContentPane contentPane;
			if (frameworkElement is global::Infragistics.Windows.DockManager.PaneTabItem)
			{
				contentPane = ((global::Infragistics.Windows.DockManager.PaneTabItem)frameworkElement).Pane;
				if (contentPane.PaneLocation == global::Infragistics.Windows.DockManager.PaneLocation.Unpinned)
				{
					return;
				}
			}
			else if (frameworkElement is global::Infragistics.Windows.DockManager.PaneHeaderPresenter)
			{
				contentPane = ((global::Infragistics.Windows.DockManager.PaneHeaderPresenter)frameworkElement).Pane;
			}
			else
			{
				contentPane = null;
			}
			if (frameworkElement != null && contentPane != null && frameworkElement.ContextMenu == null && global::System.Windows.DependencyPropertyHelper.GetValueSource(frameworkElement, global::System.Windows.FrameworkElement.ContextMenuProperty).BaseValueSource < global::System.Windows.BaseValueSource.DefaultStyle)
			{
				global::System.Windows.Controls.ContextMenu contextMenu = new global::System.Windows.Controls.ContextMenu();
				contextMenu.SetValue(global::System.Windows.FrameworkElement.DefaultStyleKeyProperty, global::Infragistics.Windows.DockManager.XamDockManager.ContextMenuStyleKey);
				contextMenu.PlacementTarget = frameworkElement;
				contextMenu.Placement = global::System.Windows.Controls.Primitives.PlacementMode.RelativePoint;
				global::System.Windows.Point point = default(global::System.Windows.Point);
				global::System.Windows.DependencyObject dependencyObject = e.OriginalSource as global::System.Windows.DependencyObject;
				while (dependencyObject is global::System.Windows.ContentElement)
				{
					dependencyObject = global::System.Windows.LogicalTreeHelper.GetParent(dependencyObject);
				}
				if (dependencyObject is global::System.Windows.UIElement)
				{
					point = frameworkElement.TranslatePoint(point, (global::System.Windows.UIElement)dependencyObject);
				}
				contextMenu.HorizontalOffset = e.CursorLeft - point.X;
				contextMenu.VerticalOffset = e.CursorTop - point.Y;
				contentPane.InitializeMenu(contextMenu.Items);
				if (contextMenu.Items.Count > 0)
				{
					contextMenu.Unloaded += delegate(object sender2, global::System.Windows.RoutedEventArgs e2)
					{
						((global::System.Windows.Controls.ContextMenu)sender2).PlacementTarget = null;
					};
					contextMenu.IsOpen = true;
					e.Handled = true;
				}
			}
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00006C87 File Offset: 0x00004E87
		internal void ResumeIsVisibleResolvedVerification()
		{
			this._suspendIsVisibleResolvedVerificationCount--;
			if (this._suspendIsVisibleResolvedVerificationCount == 0)
			{
				this.VerifyIsVisibleResolved();
			}
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00006CA5 File Offset: 0x00004EA5
		internal void SuspendIsVisibleResolvedVerification()
		{
			this._suspendIsVisibleResolvedVerificationCount++;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00006CB8 File Offset: 0x00004EB8
		internal void VerifyContentVisibility()
		{
			global::Infragistics.Windows.DockManager.HwndHostInfo hwndHost = global::Infragistics.Windows.DockManager.HwndHostInfo.GetHwndHost(this);
			if (hwndHost != null && hwndHost.HasHwndHost && global::Infragistics.Windows.DockManager.DockManagerPanel.UnpinnedPaneContainer.GetIsHiddenUnpinned(this))
			{
				base.SetValue(global::Infragistics.Windows.DockManager.ContentPane.ContentVisibilityPropertyKey, global::Infragistics.KnownBoxes.VisibilityCollapsedBox);
				return;
			}
			base.ClearValue(global::Infragistics.Windows.DockManager.ContentPane.ContentVisibilityPropertyKey);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00006CFC File Offset: 0x00004EFC
		internal void VerifyHeaderVisibility()
		{
			object value = global::System.Windows.DependencyProperty.UnsetValue;
			object value2 = global::System.Windows.DependencyProperty.UnsetValue;
			if (this.IsDocument)
			{
				value = global::Infragistics.KnownBoxes.VisibilityCollapsedBox;
			}
			else
			{
				global::Infragistics.Windows.DockManager.PaneToolWindow singlePaneToolWindow = global::Infragistics.Windows.DockManager.PaneToolWindow.GetSinglePaneToolWindow(this);
				if (singlePaneToolWindow != null)
				{
					if (singlePaneToolWindow.FloatingWindowCaptionSource == global::Infragistics.Windows.DockManager.FloatingWindowCaptionSource.UseToolWindowTitle)
					{
						value = global::Infragistics.KnownBoxes.VisibilityCollapsedBox;
					}
					else
					{
						value2 = global::Infragistics.KnownBoxes.TrueBox;
					}
				}
			}
			base.SetValue(global::Infragistics.Windows.DockManager.ContentPane.HeaderVisibilityPropertyKey, value);
			base.SetValue(global::Infragistics.Windows.DockManager.ContentPane.IsProvidingFloatingWindowCaptionPropertyKey, value2);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00006D5D File Offset: 0x00004F5D
		internal void VerifyIsVisibleResolved()
		{
			if (this._suspendIsVisibleResolvedVerificationCount == 0 && !global::Infragistics.Windows.DockManager.DockManagerUtilities.GetIsMovingPanes(this))
			{
				base.SetValue(global::Infragistics.Windows.DockManager.ContentPane.IsVisibleResolvedPropertyKey, global::Infragistics.KnownBoxes.FromValue(base.IsVisible && !global::Infragistics.Windows.DockManager.DockManagerPanel.UnpinnedPaneContainer.GetIsHiddenUnpinned(this)));
			}
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00006D93 File Offset: 0x00004F93
		private void AddMenuItem(global::Infragistics.Windows.DockManager.PaneMenuItem menuInfo, global::System.Windows.Controls.ItemCollection items)
		{
			this.InsertMenuItem(menuInfo, items.Count, items);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00006DA3 File Offset: 0x00004FA3
		private static object CoerceFocusedElement(global::System.Windows.DependencyObject d, object newValue)
		{
			if (newValue == d)
			{
				return null;
			}
			return newValue;
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00006DAC File Offset: 0x00004FAC
		private global::System.Windows.Controls.MenuItem CreateMenuItem(global::System.Windows.Input.RoutedCommand command, string resourceName, bool isCheckable, bool isChecked)
		{
			global::System.Windows.Controls.MenuItem menuItem = new global::System.Windows.Controls.MenuItem();
			if (isCheckable)
			{
				menuItem.IsCheckable = isCheckable;
				menuItem.IsChecked = isChecked;
			}
			menuItem.Command = command;
			menuItem.CommandTarget = this;
			menuItem.CommandParameter = this;
			menuItem.Header = global::Infragistics.Windows.DockManager.XamDockManager.GetString(resourceName);
			menuItem.SetValue(global::System.Windows.FrameworkElement.DefaultStyleKeyProperty, global::Infragistics.Windows.DockManager.XamDockManager.MenuItemStyleKey);
			return menuItem;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00006E03 File Offset: 0x00005003
		private void DisposeMouseDownFocusWatcher()
		{
			if (this._mouseDownFocusWatcher != null)
			{
				this._mouseDownFocusWatcher.FocusedElementChanged -= this.OnMouseDownFocusChanged;
				this._mouseDownFocusWatcher.Dispose();
				this._mouseDownFocusWatcher = null;
			}
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00006E38 File Offset: 0x00005038
		private bool ExecuteCommandImpl(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			global::System.Windows.Input.RoutedCommand routedCommand = commandInfo.RoutedCommand;
			global::Infragistics.Windows.DockManager.DockManagerUtilities.ThrowIfNull(routedCommand, "command");
			if (!global::Infragistics.Windows.Commands.Commands<global::Infragistics.Windows.DockManager.ContentPane>.IsMinimumStatePresentForCommand(this, routedCommand))
			{
				return false;
			}
			if (!((global::Infragistics.Windows.Commands.ICommandHost)this).CanExecute(commandInfo))
			{
				return false;
			}
			if (this.PaneLocation == global::Infragistics.Windows.DockManager.PaneLocation.Unknown)
			{
				return false;
			}
			global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs executingCommandEventArgs = new global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs(routedCommand);
			if (!this.RaiseExecutingCommand(executingCommandEventArgs))
			{
				return !executingCommandEventArgs.ContinueKeyRouting;
			}
			global::System.Windows.Input.ModifierKeys modifiers = global::System.Windows.Input.Keyboard.Modifiers;
			global::System.Windows.Input.ModifierKeys modifiers2 = global::System.Windows.Input.Keyboard.Modifiers;
			global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.Tab);
			bool flag = false;
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
			if (dockManager != null)
			{
				if (routedCommand == global::Infragistics.Windows.DockManager.ContentPaneCommands.ActivatePane)
				{
					flag = this.ActivateInternal();
				}
				else if (routedCommand == global::Infragistics.Windows.DockManager.ContentPaneCommands.TogglePinnedState)
				{
					if (this.CanTogglePinnedState)
					{
						dockManager.UnpinPane(this, true);
						flag = true;
					}
				}
				else if (routedCommand == global::Infragistics.Windows.DockManager.ContentPaneCommands.ChangeToDockable)
				{
					flag = this.ChangeToDockable();
				}
				else if (routedCommand == global::Infragistics.Windows.DockManager.ContentPaneCommands.ChangeToDocument)
				{
					flag = this.ChangeToDocument();
				}
				else if (routedCommand == global::Infragistics.Windows.DockManager.ContentPaneCommands.ChangeToFloatingOnly)
				{
					flag = this.ChangeToFloatingOnly();
				}
				else if (routedCommand == global::Infragistics.Windows.DockManager.ContentPaneCommands.Close)
				{
					dockManager.ClosePane(this, true);
					flag = true;
				}
				else if (routedCommand == global::Infragistics.Windows.DockManager.ContentPaneCommands.CloseAllButThis)
				{
					dockManager.CloseAllButThis(this);
					flag = true;
				}
				else if (routedCommand == global::Infragistics.Windows.DockManager.ContentPaneCommands.MoveToNewHorizontalGroup || routedCommand == global::Infragistics.Windows.DockManager.ContentPaneCommands.MoveToNewVerticalGroup)
				{
					global::System.Windows.Controls.Orientation newGroupOrientation = (routedCommand == global::Infragistics.Windows.DockManager.ContentPaneCommands.MoveToNewHorizontalGroup) ? global::System.Windows.Controls.Orientation.Horizontal : global::System.Windows.Controls.Orientation.Vertical;
					flag = global::Infragistics.Windows.DockManager.XamDockManager.MoveToNewGroup(this, newGroupOrientation);
				}
				else if (routedCommand == global::Infragistics.Windows.DockManager.ContentPaneCommands.MoveToNextGroup || routedCommand == global::Infragistics.Windows.DockManager.ContentPaneCommands.MoveToPreviousGroup)
				{
					flag = dockManager.MoveToNextGroup(this, routedCommand == global::Infragistics.Windows.DockManager.ContentPaneCommands.MoveToNextGroup);
				}
				else if (routedCommand == global::Infragistics.Windows.DockManager.ContentPaneCommands.ToggleDockedState)
				{
					flag = dockManager.ToggleDockedState(this);
				}
				else if (routedCommand == global::Infragistics.Windows.DockManager.ContentPaneCommands.FlyIn)
				{
					dockManager.HideFlyout(this, false, true, true, false, false);
					flag = true;
				}
				else if (routedCommand == global::Infragistics.Windows.DockManager.ContentPaneCommands.Flyout)
				{
					dockManager.ShowFlyout(this, false, false);
					flag = true;
				}
			}
			if (flag)
			{
				this.RaiseExecutedCommand(new global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs(routedCommand));
			}
			return flag;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00006FF8 File Offset: 0x000051F8
		private bool FocusElementDuringActivate(global::System.Windows.IInputElement element)
		{
			if (element == null)
			{
				return false;
			}
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
			bool flag = dockManager == null || dockManager.IsActivatingPane;
			if (!flag)
			{
				dockManager.IsActivatingPane = true;
			}
			bool result;
			try
			{
				result = element.Focus();
			}
			finally
			{
				if (!flag)
				{
					dockManager.IsActivatingPane = false;
				}
			}
			return result;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00007050 File Offset: 0x00005250
		private void InsertMenuItem(global::Infragistics.Windows.DockManager.PaneMenuItem menuInfo, int index, global::System.Windows.Controls.ItemCollection items)
		{
			if (!this.ShouldIncludeMenuItem(menuInfo))
			{
				return;
			}
			object obj = null;
			switch (menuInfo)
			{
			case global::Infragistics.Windows.DockManager.PaneMenuItem.FloatingOnly:
				if (this.ShouldIncludeMenuItem(global::Infragistics.Windows.DockManager.PaneMenuItem.Dockable) || this.ShouldIncludeMenuItem(global::Infragistics.Windows.DockManager.PaneMenuItem.Document) || this.ShouldIncludeMenuItem(global::Infragistics.Windows.DockManager.PaneMenuItem.AutoHide))
				{
					obj = this.CreateMenuItem(global::Infragistics.Windows.DockManager.ContentPaneCommands.ChangeToFloatingOnly, "FloatingPaneMenuItem", true, this.PaneLocation == global::Infragistics.Windows.DockManager.PaneLocation.FloatingOnly);
				}
				break;
			case global::Infragistics.Windows.DockManager.PaneMenuItem.Dockable:
				if (this.ShouldIncludeMenuItem(global::Infragistics.Windows.DockManager.PaneMenuItem.FloatingOnly) || this.ShouldIncludeMenuItem(global::Infragistics.Windows.DockManager.PaneMenuItem.Document) || this.ShouldIncludeMenuItem(global::Infragistics.Windows.DockManager.PaneMenuItem.AutoHide))
				{
					obj = this.CreateMenuItem(global::Infragistics.Windows.DockManager.ContentPaneCommands.ChangeToDockable, "DockablePaneMenuItem", true, this.IsDockable);
				}
				break;
			case global::Infragistics.Windows.DockManager.PaneMenuItem.Document:
				if (this.ShouldIncludeMenuItem(global::Infragistics.Windows.DockManager.PaneMenuItem.FloatingOnly) || this.ShouldIncludeMenuItem(global::Infragistics.Windows.DockManager.PaneMenuItem.Dockable) || this.ShouldIncludeMenuItem(global::Infragistics.Windows.DockManager.PaneMenuItem.AutoHide))
				{
					obj = this.CreateMenuItem(global::Infragistics.Windows.DockManager.ContentPaneCommands.ChangeToDocument, "DocumentPaneMenuItem", true, this.IsDocument);
				}
				break;
			case global::Infragistics.Windows.DockManager.PaneMenuItem.AutoHide:
				obj = this.CreateMenuItem(global::Infragistics.Windows.DockManager.ContentPaneCommands.TogglePinnedState, "PinPaneMenuItem", true, global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(this) == global::Infragistics.Windows.DockManager.PaneLocation.Unpinned);
				break;
			case global::Infragistics.Windows.DockManager.PaneMenuItem.Hide:
				if (!this.IsDocument || this.ShouldIncludeMenuItem(global::Infragistics.Windows.DockManager.PaneMenuItem.Dockable) || this.ShouldIncludeMenuItem(global::Infragistics.Windows.DockManager.PaneMenuItem.FloatingOnly) || this.ShouldIncludeMenuItem(global::Infragistics.Windows.DockManager.PaneMenuItem.AutoHide))
				{
					obj = this.CreateMenuItem(global::Infragistics.Windows.DockManager.ContentPaneCommands.Close, "HidePaneMenuItem", false, false);
				}
				break;
			case global::Infragistics.Windows.DockManager.PaneMenuItem.Close:
				obj = this.CreateMenuItem(global::Infragistics.Windows.DockManager.ContentPaneCommands.Close, "ClosePaneMenuItem", false, false);
				break;
			case global::Infragistics.Windows.DockManager.PaneMenuItem.CloseAllButThis:
				obj = this.CreateMenuItem(global::Infragistics.Windows.DockManager.ContentPaneCommands.CloseAllButThis, "CloseAllButThisPaneMenuItem", false, false);
				break;
			case global::Infragistics.Windows.DockManager.PaneMenuItem.NewHorizontalTabGroup:
				obj = this.CreateMenuItem(global::Infragistics.Windows.DockManager.ContentPaneCommands.MoveToNewHorizontalGroup, "MoveToNewHorizontalGroupPaneMenuItem", false, false);
				break;
			case global::Infragistics.Windows.DockManager.PaneMenuItem.NewVerticalTabGroup:
				obj = this.CreateMenuItem(global::Infragistics.Windows.DockManager.ContentPaneCommands.MoveToNewVerticalGroup, "MoveToNewVerticalGroupPaneMenuItem", false, false);
				break;
			case global::Infragistics.Windows.DockManager.PaneMenuItem.NextTabGroup:
				obj = this.CreateMenuItem(global::Infragistics.Windows.DockManager.ContentPaneCommands.MoveToNextGroup, "MoveToNextGroupPaneMenuItem", false, false);
				break;
			case global::Infragistics.Windows.DockManager.PaneMenuItem.PreviousTabGroup:
				obj = this.CreateMenuItem(global::Infragistics.Windows.DockManager.ContentPaneCommands.MoveToPreviousGroup, "MoveToPreviousGroupPaneMenuItem", false, false);
				break;
			case global::Infragistics.Windows.DockManager.PaneMenuItem.Separator:
			{
				global::System.Windows.Controls.Separator separator = new global::System.Windows.Controls.Separator();
				separator.SetValue(global::System.Windows.FrameworkElement.DefaultStyleKeyProperty, global::Infragistics.Windows.DockManager.XamDockManager.MenuItemSeparatorStyleKey);
				separator.SetResourceReference(global::System.Windows.FrameworkElement.StyleProperty, global::Infragistics.Windows.DockManager.XamDockManager.MenuItemSeparatorStyleKey);
				obj = separator;
				break;
			}
			}
			if (obj != null)
			{
				items.Insert(index, obj);
			}
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0000726C File Offset: 0x0000546C
		private static bool IsLosingFocusToRootVisual(global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			bool result = false;
			global::System.Windows.Media.Visual visual = e.OldFocus as global::System.Windows.Media.Visual;
			if (visual != null)
			{
				global::System.Windows.DependencyObject dependencyObject = e.NewFocus as global::System.Windows.DependencyObject;
				if ((dependencyObject is global::System.Windows.Media.Visual || dependencyObject is global::System.Windows.Media.Media3D.Visual3D) && global::System.Windows.Media.VisualTreeHelper.GetParent(dependencyObject) == null)
				{
					if (dependencyObject is global::System.Windows.Window && global::System.Windows.Window.GetWindow(visual) == dependencyObject)
					{
						result = true;
					}
					else if (visual.IsDescendantOf(dependencyObject))
					{
						result = true;
					}
				}
			}
			return result;
		}

		// Token: 0x0600014A RID: 330 RVA: 0x000072D0 File Offset: 0x000054D0
		private static void OnMouseDown(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			global::Infragistics.Windows.DockManager.ContentPane contentPane = sender as global::Infragistics.Windows.DockManager.ContentPane;
			if (contentPane._mouseDownFocusWatcher != null)
			{
				contentPane.DisposeMouseDownFocusWatcher();
				contentPane.ActivateInternal();
			}
		}

		// Token: 0x0600014B RID: 331 RVA: 0x000072F9 File Offset: 0x000054F9
		private void OnMouseDownFocusChanged(object sender, global::System.Windows.RoutedPropertyChangedEventArgs<global::System.Windows.IInputElement> e)
		{
			this.DisposeMouseDownFocusWatcher();
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00007304 File Offset: 0x00005504
		private static void OnPaneLocationChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.ContentPane contentPane = d as global::Infragistics.Windows.DockManager.ContentPane;
			contentPane.VerifyHeaderVisibility();
			contentPane.VerifyIsPinnedState();
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(contentPane);
			if (dockManager != null)
			{
				dockManager.ActivePaneManager.OnPaneLocationChanged(contentPane, (global::Infragistics.Windows.DockManager.PaneLocation)e.OldValue, (global::Infragistics.Windows.DockManager.PaneLocation)e.NewValue);
			}
			contentPane.UpdateVisualStates();
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00007358 File Offset: 0x00005558
		private static void OnPreviousLostKeyboardFocus(object sender, global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.ContentPane contentPane = sender as global::Infragistics.Windows.DockManager.ContentPane;
			bool flag = global::Infragistics.Windows.DockManager.ContentPane.IsLosingFocusToRootVisual(e);
			if (flag)
			{
				e.Handled = true;
				global::System.Windows.DependencyObject focusScope = global::System.Windows.Input.FocusManager.GetFocusScope(contentPane);
				if (contentPane == focusScope)
				{
					global::System.Windows.IInputElement focusedElement = global::System.Windows.Input.FocusManager.GetFocusedElement(contentPane);
					if (focusedElement != e.OldFocus)
					{
						if (focusedElement != null)
						{
							focusedElement.Focus();
						}
						else
						{
							contentPane.MoveFocus(new global::System.Windows.Input.TraversalRequest(global::System.Windows.Input.FocusNavigationDirection.First));
						}
						contentPane.InvalidateVisual();
					}
				}
			}
		}

		// Token: 0x0600014E RID: 334 RVA: 0x000073B8 File Offset: 0x000055B8
		private static void OnPreviewMouseDown(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			global::Infragistics.Windows.DockManager.ContentPane contentPane = sender as global::Infragistics.Windows.DockManager.ContentPane;
			if (contentPane._mouseDownFocusWatcher == null && !contentPane.IsKeyboardFocusWithin && !contentPane.IsKeyboardFocused)
			{
				contentPane._mouseDownFocusWatcher = new global::Infragistics.Windows.DockManager.FocusWatcher();
				contentPane._mouseDownFocusWatcher.FocusedElementChanged += contentPane.OnMouseDownFocusChanged;
			}
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00007406 File Offset: 0x00005606
		private static void OnPreviousRootGotKeyboardFocus(object sender, global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			if (e.OriginalSource != e.Source)
			{
				return;
			}
			global::Infragistics.Windows.DockManager.ContentPane.OnPreviousRootGotKeyboardFocusImpl(sender, e);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00007420 File Offset: 0x00005620
		private static void OnPreviousRootGotKeyboardFocusImpl(object sender, global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			global::System.Windows.DependencyObject dependencyObject = e.OldFocus as global::System.Windows.DependencyObject;
			if (dependencyObject == null || global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(dependencyObject) == null)
			{
				return;
			}
			global::Infragistics.Windows.DockManager.HwndHostInfo hwndHost = global::Infragistics.Windows.DockManager.HwndHostInfo.GetHwndHost(dependencyObject);
			global::Infragistics.Windows.DockManager.ContentPane contentPane = (hwndHost != null) ? (hwndHost.Owner as global::Infragistics.Windows.DockManager.ContentPane) : null;
			if (contentPane == null)
			{
				return;
			}
			if (!global::Infragistics.Windows.DockManager.ContentPane.IsLosingFocusToRootVisual(e))
			{
				return;
			}
			if (contentPane.ShouldPreventLostFocus(e.NewFocus as global::System.Windows.DependencyObject))
			{
				e.Handled = true;
			}
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00007485 File Offset: 0x00005685
		private static void OnVisibilityChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.DockManagerUtilities.RaiseVisibilityChanged(d, e);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00007490 File Offset: 0x00005690
		private bool ShouldIncludeMenuItem(global::Infragistics.Windows.DockManager.PaneMenuItem menuItem)
		{
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
			if (dockManager == null)
			{
				return false;
			}
			switch (menuItem)
			{
			case global::Infragistics.Windows.DockManager.PaneMenuItem.FloatingOnly:
				return this.AllowFloatingOnly || this.PaneLocation == global::Infragistics.Windows.DockManager.PaneLocation.FloatingOnly;
			case global::Infragistics.Windows.DockManager.PaneMenuItem.Dockable:
				return this.IsDockable || this.DockableAreas != global::Infragistics.Windows.DockManager.DockableAreas.None;
			case global::Infragistics.Windows.DockManager.PaneMenuItem.Document:
				return dockManager.HasDocumentContentHost && (this.IsDocument || this.AllowInDocumentHost);
			case global::Infragistics.Windows.DockManager.PaneMenuItem.AutoHide:
				return this.AllowPinning;
			case global::Infragistics.Windows.DockManager.PaneMenuItem.Hide:
				return this.AllowClose;
			case global::Infragistics.Windows.DockManager.PaneMenuItem.Close:
				return this.AllowClose;
			case global::Infragistics.Windows.DockManager.PaneMenuItem.CloseAllButThis:
				return this.CanCloseAllButThis;
			case global::Infragistics.Windows.DockManager.PaneMenuItem.NewHorizontalTabGroup:
				return global::Infragistics.Windows.DockManager.XamDockManager.CanMoveToNewGroup(this, global::System.Windows.Controls.Orientation.Horizontal);
			case global::Infragistics.Windows.DockManager.PaneMenuItem.NewVerticalTabGroup:
				return global::Infragistics.Windows.DockManager.XamDockManager.CanMoveToNewGroup(this, global::System.Windows.Controls.Orientation.Vertical);
			case global::Infragistics.Windows.DockManager.PaneMenuItem.NextTabGroup:
				return global::Infragistics.Windows.DockManager.XamDockManager.CanMoveToNextPreviousGroup(this, true);
			case global::Infragistics.Windows.DockManager.PaneMenuItem.PreviousTabGroup:
				return global::Infragistics.Windows.DockManager.XamDockManager.CanMoveToNextPreviousGroup(this, false);
			case global::Infragistics.Windows.DockManager.PaneMenuItem.Separator:
				return true;
			default:
				return true;
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0000756B File Offset: 0x0000576B
		private bool ShouldPreventLostFocus(global::System.Windows.DependencyObject newFocus)
		{
			return base.IsVisible && base.IsEnabled;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00007580 File Offset: 0x00005780
		internal void VerifyIsPinnedState()
		{
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
			if (dockManager != null)
			{
				base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::System.Threading.ContextCallback(this.VerifyIsPinnedStateSynchronous), dockManager.IsLoaded);
			}
		}

		// Token: 0x06000155 RID: 341 RVA: 0x000075BC File Offset: 0x000057BC
		private void VerifyIsPinnedStateSynchronous(object allowShowFlyout)
		{
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
			if (dockManager != null)
			{
				dockManager.ProcessPinnedState(this, this.PaneLocation, true.Equals(allowShowFlyout));
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x000075EA File Offset: 0x000057EA
		protected virtual void OnClosing(global::Infragistics.Windows.DockManager.Events.PaneClosingEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x000075F3 File Offset: 0x000057F3
		internal void RaiseClosing(global::Infragistics.Windows.DockManager.Events.PaneClosingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DockManager.ContentPane.ClosingEvent;
			args.Source = this;
			this.OnClosing(args);
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000158 RID: 344 RVA: 0x0000760E File Offset: 0x0000580E
		// (remove) Token: 0x06000159 RID: 345 RVA: 0x0000761C File Offset: 0x0000581C
		public event global::System.EventHandler<global::Infragistics.Windows.DockManager.Events.PaneClosingEventArgs> Closing
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DockManager.ContentPane.ClosingEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DockManager.ContentPane.ClosingEvent, value);
			}
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0000762A File Offset: 0x0000582A
		protected virtual void OnClosed(global::Infragistics.Windows.DockManager.Events.PaneClosedEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00007633 File Offset: 0x00005833
		internal void RaiseClosed(global::Infragistics.Windows.DockManager.Events.PaneClosedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DockManager.ContentPane.ClosedEvent;
			args.Source = this;
			this.OnClosed(args);
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600015C RID: 348 RVA: 0x0000764E File Offset: 0x0000584E
		// (remove) Token: 0x0600015D RID: 349 RVA: 0x0000765C File Offset: 0x0000585C
		public event global::System.EventHandler<global::Infragistics.Windows.DockManager.Events.PaneClosedEventArgs> Closed
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DockManager.ContentPane.ClosedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DockManager.ContentPane.ClosedEvent, value);
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000766A File Offset: 0x0000586A
		protected virtual void OnExecutingCommand(global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00007673 File Offset: 0x00005873
		internal bool RaiseExecutingCommand(global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DockManager.ContentPane.ExecutingCommandEvent;
			args.Source = this;
			this.OnExecutingCommand(args);
			return !args.Cancel;
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000160 RID: 352 RVA: 0x00007697 File Offset: 0x00005897
		// (remove) Token: 0x06000161 RID: 353 RVA: 0x000076A5 File Offset: 0x000058A5
		public event global::System.EventHandler<global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs> ExecutingCommand
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DockManager.ContentPane.ExecutingCommandEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DockManager.ContentPane.ExecutingCommandEvent, value);
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x000076B3 File Offset: 0x000058B3
		protected virtual void OnExecutedCommand(global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x000076BC File Offset: 0x000058BC
		internal void RaiseExecutedCommand(global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DockManager.ContentPane.ExecutedCommandEvent;
			args.Source = this;
			this.OnExecutedCommand(args);
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000164 RID: 356 RVA: 0x000076D7 File Offset: 0x000058D7
		// (remove) Token: 0x06000165 RID: 357 RVA: 0x000076E5 File Offset: 0x000058E5
		public event global::System.EventHandler<global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs> ExecutedCommand
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DockManager.ContentPane.ExecutedCommandEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DockManager.ContentPane.ExecutedCommandEvent, value);
			}
		}

		// Token: 0x06000166 RID: 358 RVA: 0x000076F3 File Offset: 0x000058F3
		protected virtual void OnIsVisibleResolvedChanged(global::System.Windows.RoutedEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x000076FC File Offset: 0x000058FC
		internal void RaiseIsVisibleResolvedChanged(global::System.Windows.RoutedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DockManager.ContentPane.IsVisibleResolvedChangedEvent;
			args.Source = this;
			this.OnIsVisibleResolvedChanged(args);
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000168 RID: 360 RVA: 0x00007717 File Offset: 0x00005917
		// (remove) Token: 0x06000169 RID: 361 RVA: 0x00007725 File Offset: 0x00005925
		public event global::System.Windows.RoutedEventHandler IsVisibleResolvedChanged
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DockManager.ContentPane.IsVisibleResolvedChangedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DockManager.ContentPane.IsVisibleResolvedChangedEvent, value);
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00007733 File Offset: 0x00005933
		protected virtual void OnOptionsMenuOpening(global::Infragistics.Windows.DockManager.Events.PaneOptionsMenuOpeningEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0000773C File Offset: 0x0000593C
		internal void RaiseOptionsMenuOpening(global::Infragistics.Windows.DockManager.Events.PaneOptionsMenuOpeningEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DockManager.ContentPane.OptionsMenuOpeningEvent;
			args.Source = this;
			this.OnOptionsMenuOpening(args);
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x0600016C RID: 364 RVA: 0x00007757 File Offset: 0x00005957
		// (remove) Token: 0x0600016D RID: 365 RVA: 0x00007765 File Offset: 0x00005965
		public event global::System.EventHandler<global::Infragistics.Windows.DockManager.Events.PaneOptionsMenuOpeningEventArgs> OptionsMenuOpening
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DockManager.ContentPane.OptionsMenuOpeningEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DockManager.ContentPane.OptionsMenuOpeningEvent, value);
			}
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00007774 File Offset: 0x00005974
		bool global::Infragistics.Windows.Commands.ICommandHost.CanExecute(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			global::System.Windows.Input.RoutedCommand routedCommand = commandInfo.RoutedCommand;
			if (routedCommand == null)
			{
				return false;
			}
			if (routedCommand.OwnerType == typeof(global::Infragistics.Windows.DockManager.ContentPaneCommands))
			{
				commandInfo.ForceHandled = true;
			}
			if (this.PaneLocation == global::Infragistics.Windows.DockManager.PaneLocation.Unknown)
			{
				return false;
			}
			if (routedCommand == global::Infragistics.Windows.DockManager.ContentPaneCommands.ActivatePane)
			{
				return this.CanActivate;
			}
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
			if (routedCommand == global::Infragistics.Windows.DockManager.ContentPaneCommands.Close)
			{
				return this.AllowClose;
			}
			if (routedCommand == global::Infragistics.Windows.DockManager.ContentPaneCommands.ChangeToDockable)
			{
				return this.IsPinned && (this.IsDockable || this.DockableAreas != global::Infragistics.Windows.DockManager.DockableAreas.None);
			}
			if (routedCommand == global::Infragistics.Windows.DockManager.ContentPaneCommands.ChangeToDocument)
			{
				return this.IsPinned && dockManager != null && dockManager.HasDocumentContentHost && (this.IsDocument || (dockManager.IsPaneLocationVisible(global::Infragistics.Windows.DockManager.PaneLocation.Document) && this.AllowInDocumentHost));
			}
			if (routedCommand == global::Infragistics.Windows.DockManager.ContentPaneCommands.ChangeToFloatingOnly)
			{
				return this.IsPinned && (this.PaneLocation == global::Infragistics.Windows.DockManager.PaneLocation.FloatingOnly || ((dockManager == null || dockManager.IsPaneLocationVisible(global::Infragistics.Windows.DockManager.PaneLocation.FloatingOnly)) && this.AllowFloatingOnly));
			}
			if (routedCommand == global::Infragistics.Windows.DockManager.ContentPaneCommands.CloseAllButThis)
			{
				return this.CanCloseAllButThis;
			}
			if (routedCommand == global::Infragistics.Windows.DockManager.ContentPaneCommands.MoveToNewHorizontalGroup)
			{
				return global::Infragistics.Windows.DockManager.XamDockManager.CanMoveToNewGroup(this, global::System.Windows.Controls.Orientation.Horizontal);
			}
			if (routedCommand == global::Infragistics.Windows.DockManager.ContentPaneCommands.MoveToNewVerticalGroup)
			{
				return global::Infragistics.Windows.DockManager.XamDockManager.CanMoveToNewGroup(this, global::System.Windows.Controls.Orientation.Vertical);
			}
			if (routedCommand == global::Infragistics.Windows.DockManager.ContentPaneCommands.MoveToNextGroup)
			{
				return global::Infragistics.Windows.DockManager.XamDockManager.CanMoveToNextPreviousGroup(this, true);
			}
			if (routedCommand == global::Infragistics.Windows.DockManager.ContentPaneCommands.MoveToPreviousGroup)
			{
				return global::Infragistics.Windows.DockManager.XamDockManager.CanMoveToNextPreviousGroup(this, false);
			}
			if (routedCommand == global::Infragistics.Windows.DockManager.ContentPaneCommands.ToggleDockedState)
			{
				return this.CanToggleDockedState;
			}
			if (routedCommand == global::Infragistics.Windows.DockManager.ContentPaneCommands.TogglePinnedState)
			{
				return this.CanTogglePinnedState;
			}
			if (routedCommand == global::Infragistics.Windows.DockManager.ContentPaneCommands.FlyIn)
			{
				return this.PaneLocation == global::Infragistics.Windows.DockManager.PaneLocation.Unpinned && dockManager != null && dockManager.CurrentFlyoutPane == this && !this.IsFlyInSuspended;
			}
			return routedCommand == global::Infragistics.Windows.DockManager.ContentPaneCommands.Flyout && (base.Visibility == global::System.Windows.Visibility.Visible && this.PaneLocation == global::Infragistics.Windows.DockManager.PaneLocation.Unpinned) && dockManager != null;
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0000792C File Offset: 0x00005B2C
		long global::Infragistics.Windows.Commands.ICommandHost.GetCurrentState(long statesToQuery)
		{
			global::Infragistics.Windows.DockManager.ContentPaneStates contentPaneStates = (global::Infragistics.Windows.DockManager.ContentPaneStates)0L;
			if (this.IsActiveDocument)
			{
				contentPaneStates |= global::Infragistics.Windows.DockManager.ContentPaneStates.IsActiveDocument;
			}
			if (this.IsActivePane)
			{
				contentPaneStates |= global::Infragistics.Windows.DockManager.ContentPaneStates.IsActivePane;
			}
			if (this.AllowClose)
			{
				contentPaneStates |= global::Infragistics.Windows.DockManager.ContentPaneStates.AllowClose;
			}
			switch (this.PaneLocation)
			{
			case global::Infragistics.Windows.DockManager.PaneLocation.DockedLeft:
			case global::Infragistics.Windows.DockManager.PaneLocation.DockedRight:
			case global::Infragistics.Windows.DockManager.PaneLocation.DockedTop:
			case global::Infragistics.Windows.DockManager.PaneLocation.DockedBottom:
				contentPaneStates |= global::Infragistics.Windows.DockManager.ContentPaneStates.IsDocked;
				break;
			case global::Infragistics.Windows.DockManager.PaneLocation.Floating:
				contentPaneStates |= global::Infragistics.Windows.DockManager.ContentPaneStates.IsFloating;
				contentPaneStates |= global::Infragistics.Windows.DockManager.ContentPaneStates.IsFloatingDockable;
				break;
			case global::Infragistics.Windows.DockManager.PaneLocation.FloatingOnly:
				contentPaneStates |= global::Infragistics.Windows.DockManager.ContentPaneStates.IsFloating;
				contentPaneStates |= global::Infragistics.Windows.DockManager.ContentPaneStates.IsFloatingOnly;
				break;
			case global::Infragistics.Windows.DockManager.PaneLocation.Unpinned:
				contentPaneStates |= global::Infragistics.Windows.DockManager.ContentPaneStates.IsUnpinned;
				break;
			case global::Infragistics.Windows.DockManager.PaneLocation.Document:
				contentPaneStates |= global::Infragistics.Windows.DockManager.ContentPaneStates.IsDocument;
				break;
			}
			return (long)(contentPaneStates & (global::Infragistics.Windows.DockManager.ContentPaneStates)statesToQuery);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x000079D0 File Offset: 0x00005BD0
		bool global::Infragistics.Windows.Commands.ICommandHost.Execute(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			global::System.Windows.Input.RoutedCommand routedCommand = commandInfo.RoutedCommand;
			return routedCommand != null && this.ExecuteCommandImpl(commandInfo);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x000079F0 File Offset: 0x00005BF0
		void global::Infragistics.Windows.DockManager.IHwndHostInfoOwner.OnHasHostsChanged()
		{
			this.VerifyContentVisibility();
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
			if (dockManager != null)
			{
				if (this == dockManager.CurrentFlyoutPane && dockManager.DockPanel != null)
				{
					dockManager.DockPanel.FlyoutPanel.VerifyMouseOverTimer();
				}
				if (this.HasHwndHost)
				{
					global::Infragistics.Windows.DockManager.PaneToolWindow paneToolWindow = global::Infragistics.Windows.Controls.ToolWindow.GetToolWindow(this) as global::Infragistics.Windows.DockManager.PaneToolWindow;
					if (paneToolWindow != null)
					{
						paneToolWindow.VerifyPreventAllowsTransparency();
					}
				}
				if (!dockManager.HasHwndHost)
				{
					dockManager.DirtyHasHwndHosts();
				}
			}
		}

		// Token: 0x04000035 RID: 53
		private readonly global::Infragistics.Windows.DockManager.ContentPane.PanePlacementInfo _placementInfo;

		// Token: 0x04000036 RID: 54
		private global::Infragistics.Windows.DockManager.FocusWatcher _mouseDownFocusWatcher;

		// Token: 0x04000037 RID: 55
		private global::System.Windows.Size _lastFloatingSize = global::System.Windows.Size.Empty;

		// Token: 0x04000038 RID: 56
		private global::System.Windows.Point? _lastFloatingLocation = null;

		// Token: 0x04000039 RID: 57
		private global::System.Windows.Rect _lastFloatingWindowRect = global::System.Windows.Rect.Empty;

		// Token: 0x0400003A RID: 58
		private global::System.DateTime _lastActivatedTime = global::System.DateTime.MinValue;

		// Token: 0x0400003B RID: 59
		private global::Infragistics.Windows.DockManager.ContentPaneCommands _commands;

		// Token: 0x0400003C RID: 60
		private bool _suppressFlyoutDuringActivate;

		// Token: 0x0400003D RID: 61
		private int _suspendIsVisibleResolvedVerificationCount;

		// Token: 0x0400003E RID: 62
		private bool _isActivating;

		// Token: 0x0400003F RID: 63
		private global::System.WeakReference _paneHeaderPresenter;

		// Token: 0x04000040 RID: 64
		private bool _hasVisualStateGroups;

		// Token: 0x04000041 RID: 65
		public static readonly global::System.Windows.DependencyProperty AllowDockingProperty = global::System.Windows.DependencyProperty.Register("AllowDocking", typeof(bool), typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox));

		// Token: 0x04000042 RID: 66
		public static readonly global::System.Windows.DependencyProperty AllowDockingLeftProperty = global::System.Windows.DependencyProperty.Register("AllowDockingLeft", typeof(bool?), typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000043 RID: 67
		public static readonly global::System.Windows.DependencyProperty AllowDockingTopProperty = global::System.Windows.DependencyProperty.Register("AllowDockingTop", typeof(bool?), typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000044 RID: 68
		public static readonly global::System.Windows.DependencyProperty AllowDockingRightProperty = global::System.Windows.DependencyProperty.Register("AllowDockingRight", typeof(bool?), typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000045 RID: 69
		public static readonly global::System.Windows.DependencyProperty AllowDockingBottomProperty = global::System.Windows.DependencyProperty.Register("AllowDockingBottom", typeof(bool?), typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000046 RID: 70
		public static readonly global::System.Windows.DependencyProperty AllowDockingFloatingProperty = global::System.Windows.DependencyProperty.Register("AllowDockingFloating", typeof(bool?), typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000047 RID: 71
		public static readonly global::System.Windows.DependencyProperty AllowInDocumentHostProperty = global::System.Windows.DependencyProperty.Register("AllowInDocumentHost", typeof(bool), typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox));

		// Token: 0x04000048 RID: 72
		public static readonly global::System.Windows.DependencyProperty AllowFloatingOnlyProperty = global::System.Windows.DependencyProperty.Register("AllowFloatingOnly", typeof(bool), typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox));

		// Token: 0x04000049 RID: 73
		public static readonly global::System.Windows.DependencyProperty AllowPinningProperty = global::System.Windows.DependencyProperty.Register("AllowPinning", typeof(bool), typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox));

		// Token: 0x0400004A RID: 74
		public static readonly global::System.Windows.DependencyProperty AllowCloseProperty = global::System.Windows.DependencyProperty.Register("AllowClose", typeof(bool), typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.ContentPane.OnAllowCloseChanged)));

		// Token: 0x0400004B RID: 75
		public static readonly global::System.Windows.DependencyProperty AllowDockingInTabGroupProperty = global::System.Windows.DependencyProperty.Register("AllowDockingInTabGroup", typeof(bool), typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox));

		// Token: 0x0400004C RID: 76
		public static readonly global::System.Windows.DependencyProperty CloseActionProperty = global::System.Windows.DependencyProperty.Register("CloseAction", typeof(global::Infragistics.Windows.DockManager.PaneCloseAction), typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DockManager.PaneCloseAction.HidePane));

		// Token: 0x0400004D RID: 77
		public static readonly global::System.Windows.DependencyProperty CloseButtonVisibilityProperty = global::System.Windows.DependencyProperty.Register("CloseButtonVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityVisibleBox));

		// Token: 0x0400004E RID: 78
		private static readonly global::System.Windows.DependencyPropertyKey ContentVisibilityPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ContentVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityVisibleBox));

		// Token: 0x0400004F RID: 79
		public static readonly global::System.Windows.DependencyProperty ContentVisibilityProperty = global::Infragistics.Windows.DockManager.ContentPane.ContentVisibilityPropertyKey.DependencyProperty;

		// Token: 0x04000050 RID: 80
		private static readonly global::System.Windows.DependencyPropertyKey HasImagePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("HasImage", typeof(bool), typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000051 RID: 81
		public static readonly global::System.Windows.DependencyProperty HasImageProperty = global::Infragistics.Windows.DockManager.ContentPane.HasImagePropertyKey.DependencyProperty;

		// Token: 0x04000052 RID: 82
		private static readonly global::System.Windows.DependencyPropertyKey HeaderVisibilityPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("HeaderVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityVisibleBox));

		// Token: 0x04000053 RID: 83
		public static readonly global::System.Windows.DependencyProperty HeaderVisibilityProperty = global::Infragistics.Windows.DockManager.ContentPane.HeaderVisibilityPropertyKey.DependencyProperty;

		// Token: 0x04000054 RID: 84
		public static readonly global::System.Windows.DependencyProperty ImageProperty = global::System.Windows.DependencyProperty.Register("Image", typeof(global::System.Windows.Media.ImageSource), typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.ContentPane.OnImageChanged)));

		// Token: 0x04000055 RID: 85
		public static readonly global::System.Windows.DependencyProperty IsActivePaneProperty = global::Infragistics.Windows.DockManager.ActivePaneManager.IsActivePaneProperty.AddOwner(typeof(global::Infragistics.Windows.DockManager.ContentPane));

		// Token: 0x04000056 RID: 86
		public static readonly global::System.Windows.DependencyProperty IsActiveDocumentProperty = global::Infragistics.Windows.DockManager.ActivePaneManager.IsActiveDocumentProperty.AddOwner(typeof(global::Infragistics.Windows.DockManager.ContentPane));

		// Token: 0x04000057 RID: 87
		public static readonly global::System.Windows.DependencyProperty IsFlyInSuspendedProperty = global::System.Windows.DependencyProperty.Register("IsFlyInSuspended", typeof(bool), typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.ContentPane.OnIsFlyInSuspended)));

		// Token: 0x04000058 RID: 88
		public static readonly global::System.Windows.DependencyProperty IsPinnedProperty = global::System.Windows.DependencyProperty.Register("IsPinned", typeof(bool), typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.ContentPane.OnIsPinnedChanged)));

		// Token: 0x04000059 RID: 89
		private static readonly global::System.Windows.DependencyPropertyKey IsProvidingFloatingWindowCaptionPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsProvidingFloatingWindowCaption", typeof(bool), typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x0400005A RID: 90
		public static readonly global::System.Windows.DependencyProperty IsProvidingFloatingWindowCaptionProperty = global::Infragistics.Windows.DockManager.ContentPane.IsProvidingFloatingWindowCaptionPropertyKey.DependencyProperty;

		// Token: 0x0400005B RID: 91
		private static readonly global::System.Windows.DependencyPropertyKey IsVisibleResolvedPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsVisibleResolved", typeof(bool), typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.ContentPane.OnIsVisibleResolvedPropertyChanged)));

		// Token: 0x0400005C RID: 92
		public static readonly global::System.Windows.DependencyProperty IsVisibleResolvedProperty = global::Infragistics.Windows.DockManager.ContentPane.IsVisibleResolvedPropertyKey.DependencyProperty;

		// Token: 0x0400005D RID: 93
		public static readonly global::System.Windows.DependencyProperty NavigatorDescriptionProperty = global::System.Windows.DependencyProperty.Register("NavigatorDescription", typeof(object), typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x0400005E RID: 94
		public static readonly global::System.Windows.DependencyProperty NavigatorDescriptionTemplateProperty = global::System.Windows.DependencyProperty.Register("NavigatorDescriptionTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x0400005F RID: 95
		public static readonly global::System.Windows.DependencyProperty NavigatorDescriptionTemplateSelectorProperty = global::System.Windows.DependencyProperty.Register("NavigatorDescriptionTemplateSelector", typeof(global::System.Windows.Controls.DataTemplateSelector), typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000060 RID: 96
		public static readonly global::System.Windows.DependencyProperty NavigatorTitleProperty = global::System.Windows.DependencyProperty.Register("NavigatorTitle", typeof(object), typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000061 RID: 97
		public static readonly global::System.Windows.DependencyProperty NavigatorTitleTemplateProperty = global::System.Windows.DependencyProperty.Register("NavigatorTitleTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000062 RID: 98
		public static readonly global::System.Windows.DependencyProperty NavigatorTitleTemplateSelectorProperty = global::System.Windows.DependencyProperty.Register("NavigatorTitleTemplateSelector", typeof(global::System.Windows.Controls.DataTemplateSelector), typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000063 RID: 99
		public static readonly global::System.Windows.DependencyProperty PaneLocationProperty = global::Infragistics.Windows.DockManager.XamDockManager.PaneLocationProperty.AddOwner(typeof(global::Infragistics.Windows.DockManager.ContentPane));

		// Token: 0x04000064 RID: 100
		public static readonly global::System.Windows.DependencyProperty PinButtonVisibilityProperty = global::System.Windows.DependencyProperty.Register("PinButtonVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityVisibleBox));

		// Token: 0x04000065 RID: 101
		public static readonly global::System.Windows.DependencyProperty SaveInLayoutProperty = global::System.Windows.DependencyProperty.Register("SaveInLayout", typeof(bool), typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox));

		// Token: 0x04000066 RID: 102
		public static readonly global::System.Windows.DependencyProperty SerializationIdProperty = global::System.Windows.DependencyProperty.Register("SerializationId", typeof(string), typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000067 RID: 103
		public static readonly global::System.Windows.DependencyProperty TabHeaderProperty = global::System.Windows.DependencyProperty.Register("TabHeader", typeof(object), typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000068 RID: 104
		public static readonly global::System.Windows.DependencyProperty TabHeaderTemplateProperty = global::System.Windows.DependencyProperty.Register("TabHeaderTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000069 RID: 105
		public static readonly global::System.Windows.DependencyProperty TabHeaderTemplateSelectorProperty = global::System.Windows.DependencyProperty.Register("TabHeaderTemplateSelector", typeof(global::System.Windows.Controls.DataTemplateSelector), typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DockManager.ContentPane.ContentPaneTemplateSelector.Instance));

		// Token: 0x0400006A RID: 106
		public static readonly global::System.Windows.DependencyProperty WindowPositionMenuVisibilityProperty = global::System.Windows.DependencyProperty.Register("WindowPositionMenuVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.DockManager.ContentPane), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityVisibleBox));

		// Token: 0x0200001A RID: 26
		internal class ContentPaneTemplateSelector : global::System.Windows.Controls.DataTemplateSelector
		{
			// Token: 0x06000175 RID: 373 RVA: 0x00007A59 File Offset: 0x00005C59
			private ContentPaneTemplateSelector()
			{
			}

			// Token: 0x06000176 RID: 374 RVA: 0x00007A64 File Offset: 0x00005C64
			static ContentPaneTemplateSelector()
			{
				global::Infragistics.Windows.DockManager.ContentPane.ContentPaneTemplateSelector.PaneHeaderDataTemplateForString = global::Infragistics.Windows.DockManager.DockManagerUtilities.CreateStringTemplate(typeof(global::Infragistics.Windows.DockManager.PaneHeaderPresenter), false);
				global::Infragistics.Windows.DockManager.ContentPane.ContentPaneTemplateSelector.PaneTabItemDataTemplateForString = global::Infragistics.Windows.DockManager.DockManagerUtilities.CreateStringTemplate(typeof(global::Infragistics.Windows.DockManager.PaneTabItem), false);
				global::Infragistics.Windows.DockManager.ContentPane.ContentPaneTemplateSelector.PaneTabItemDataTemplateForAccessText = global::Infragistics.Windows.DockManager.DockManagerUtilities.CreateStringTemplate(typeof(global::Infragistics.Windows.DockManager.PaneTabItem), true);
			}

			// Token: 0x06000177 RID: 375 RVA: 0x00007ABC File Offset: 0x00005CBC
			public override global::System.Windows.DataTemplate SelectTemplate(object item, global::System.Windows.DependencyObject container)
			{
				global::System.Windows.Controls.ContentPresenter contentPresenter = container as global::System.Windows.Controls.ContentPresenter;
				if (contentPresenter != null && item is string)
				{
					if (contentPresenter.TemplatedParent is global::Infragistics.Windows.DockManager.PaneHeaderPresenter && !contentPresenter.RecognizesAccessKey)
					{
						return global::Infragistics.Windows.DockManager.ContentPane.ContentPaneTemplateSelector.PaneHeaderDataTemplateForString;
					}
					if (contentPresenter.TemplatedParent is global::Infragistics.Windows.DockManager.PaneTabItem)
					{
						if (contentPresenter.RecognizesAccessKey)
						{
							return global::Infragistics.Windows.DockManager.ContentPane.ContentPaneTemplateSelector.PaneTabItemDataTemplateForAccessText;
						}
						return global::Infragistics.Windows.DockManager.ContentPane.ContentPaneTemplateSelector.PaneTabItemDataTemplateForString;
					}
				}
				return null;
			}

			// Token: 0x04000073 RID: 115
			internal static readonly global::System.Windows.DataTemplate PaneHeaderDataTemplateForString;

			// Token: 0x04000074 RID: 116
			internal static readonly global::System.Windows.DataTemplate PaneTabItemDataTemplateForString;

			// Token: 0x04000075 RID: 117
			internal static readonly global::System.Windows.DataTemplate PaneTabItemDataTemplateForAccessText;

			// Token: 0x04000076 RID: 118
			internal static readonly global::System.Windows.Controls.DataTemplateSelector Instance = new global::Infragistics.Windows.DockManager.ContentPane.ContentPaneTemplateSelector();
		}

		// Token: 0x0200001B RID: 27
		internal class PanePlacementInfo
		{
			// Token: 0x06000178 RID: 376 RVA: 0x00007B18 File Offset: 0x00005D18
			internal PanePlacementInfo()
			{
			}

			// Token: 0x1700004F RID: 79
			// (get) Token: 0x06000179 RID: 377 RVA: 0x00007B20 File Offset: 0x00005D20
			// (set) Token: 0x0600017A RID: 378 RVA: 0x00007B28 File Offset: 0x00005D28
			internal global::Infragistics.Windows.DockManager.IContentPaneContainer CurrentContainer
			{
				get
				{
					return this._currentContainer;
				}
				set
				{
					this._currentContainer = value;
					this.VerifyLastDockableContainer();
				}
			}

			// Token: 0x17000050 RID: 80
			// (get) Token: 0x0600017B RID: 379 RVA: 0x00007B37 File Offset: 0x00005D37
			internal global::Infragistics.Windows.DockManager.IContentPaneContainer DockableContainer
			{
				get
				{
					return this._lastDockableContainer;
				}
			}

			// Token: 0x17000051 RID: 81
			// (get) Token: 0x0600017C RID: 380 RVA: 0x00007B3F File Offset: 0x00005D3F
			internal global::Infragistics.Windows.DockManager.IContentPaneContainer DockedContainer
			{
				get
				{
					if (this._dockedEdgePlaceholder != null)
					{
						return this._dockedEdgePlaceholder.Container;
					}
					if (this._currentContainer != null && global::Infragistics.Windows.DockManager.DockManagerUtilities.IsDocked(this._currentContainer.PaneLocation))
					{
						return this._currentContainer;
					}
					return null;
				}
			}

			// Token: 0x17000052 RID: 82
			// (get) Token: 0x0600017D RID: 381 RVA: 0x00007B77 File Offset: 0x00005D77
			internal global::Infragistics.Windows.DockManager.ContentPanePlaceholder DockedEdgePlaceholder
			{
				get
				{
					return this._dockedEdgePlaceholder;
				}
			}

			// Token: 0x17000053 RID: 83
			// (get) Token: 0x0600017E RID: 382 RVA: 0x00007B7F File Offset: 0x00005D7F
			internal global::Infragistics.Windows.DockManager.ContentPanePlaceholder FloatingDockablePlaceholder
			{
				get
				{
					return this._floatingDockablePlaceholder;
				}
			}

			// Token: 0x17000054 RID: 84
			// (get) Token: 0x0600017F RID: 383 RVA: 0x00007B87 File Offset: 0x00005D87
			internal global::Infragistics.Windows.DockManager.ContentPanePlaceholder FloatingOnlyPlaceholder
			{
				get
				{
					return this._floatingOnlyPlaceholder;
				}
			}

			// Token: 0x06000180 RID: 384 RVA: 0x00007B90 File Offset: 0x00005D90
			private void DeletePlaceholder(ref global::Infragistics.Windows.DockManager.ContentPanePlaceholder placeholder)
			{
				global::Infragistics.Windows.DockManager.ContentPanePlaceholder contentPanePlaceholder = placeholder;
				placeholder = null;
				if (contentPanePlaceholder != null)
				{
					global::Infragistics.Windows.DockManager.IContentPaneContainer container = contentPanePlaceholder.Container;
					global::Infragistics.Windows.DockManager.IPaneContainer paneContainer = container as global::Infragistics.Windows.DockManager.IPaneContainer;
					if (paneContainer != null)
					{
						int num = paneContainer.Panes.IndexOf(contentPanePlaceholder);
						if (num >= 0)
						{
							container.RemoveContentPane(contentPanePlaceholder.Pane, false);
							global::Infragistics.Windows.DockManager.DockManagerUtilities.RemoveContainerIfNeeded(container);
						}
					}
				}
			}

			// Token: 0x06000181 RID: 385 RVA: 0x00007BDC File Offset: 0x00005DDC
			internal bool IsInSameDockedContainer(global::Infragistics.Windows.DockManager.ContentPane pane)
			{
				global::Infragistics.Windows.DockManager.IContentPaneContainer dockedContainer = this.DockedContainer;
				global::Infragistics.Windows.DockManager.IContentPaneContainer dockedContainer2 = pane.PlacementInfo.DockedContainer;
				return dockedContainer != null && dockedContainer2 != null && dockedContainer == dockedContainer2;
			}

			// Token: 0x06000182 RID: 386 RVA: 0x00007C08 File Offset: 0x00005E08
			internal void RemovePlaceholder(global::Infragistics.Windows.DockManager.ContentPanePlaceholder placeholder)
			{
				if (placeholder == this._dockedEdgePlaceholder)
				{
					this.RemovePlaceholderImpl(ref this._dockedEdgePlaceholder);
				}
				else if (placeholder == this._floatingDockablePlaceholder)
				{
					this.RemovePlaceholderImpl(ref this._floatingDockablePlaceholder);
				}
				else if (placeholder == this._floatingOnlyPlaceholder)
				{
					this.RemovePlaceholderImpl(ref this._floatingOnlyPlaceholder);
				}
				this.VerifyLastDockableContainer();
			}

			// Token: 0x06000183 RID: 387 RVA: 0x00007C60 File Offset: 0x00005E60
			private void RemovePlaceholderImpl(ref global::Infragistics.Windows.DockManager.ContentPanePlaceholder placeholder)
			{
				global::Infragistics.Windows.DockManager.ContentPanePlaceholder contentPanePlaceholder = placeholder;
				if (contentPanePlaceholder != null)
				{
					placeholder = null;
					if (contentPanePlaceholder.Container != null)
					{
						global::Infragistics.Windows.DockManager.IPaneContainer paneContainer = contentPanePlaceholder.Container as global::Infragistics.Windows.DockManager.IPaneContainer;
						if (paneContainer == null)
						{
							return;
						}
						paneContainer.Panes.IndexOf(contentPanePlaceholder);
					}
				}
			}

			// Token: 0x06000184 RID: 388 RVA: 0x00007C9C File Offset: 0x00005E9C
			internal void RemoveReplacedPlaceholder()
			{
				if (this._currentContainer != null)
				{
					switch (this._currentContainer.PaneLocation)
					{
					case global::Infragistics.Windows.DockManager.PaneLocation.DockedLeft:
					case global::Infragistics.Windows.DockManager.PaneLocation.DockedRight:
					case global::Infragistics.Windows.DockManager.PaneLocation.DockedTop:
					case global::Infragistics.Windows.DockManager.PaneLocation.DockedBottom:
						this.DeletePlaceholder(ref this._dockedEdgePlaceholder);
						return;
					case global::Infragistics.Windows.DockManager.PaneLocation.Floating:
						this.DeletePlaceholder(ref this._floatingDockablePlaceholder);
						return;
					case global::Infragistics.Windows.DockManager.PaneLocation.FloatingOnly:
						this.DeletePlaceholder(ref this._floatingOnlyPlaceholder);
						break;
					default:
						return;
					}
				}
			}

			// Token: 0x06000185 RID: 389 RVA: 0x00007D04 File Offset: 0x00005F04
			internal void StorePlaceholder(global::Infragistics.Windows.DockManager.ContentPanePlaceholder placeholder)
			{
				global::Infragistics.Windows.DockManager.PaneLocation paneLocation = global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(placeholder);
				this.StorePlaceholder(placeholder, paneLocation);
			}

			// Token: 0x06000186 RID: 390 RVA: 0x00007D20 File Offset: 0x00005F20
			internal void StorePlaceholder(global::Infragistics.Windows.DockManager.ContentPanePlaceholder placeholder, global::Infragistics.Windows.DockManager.PaneLocation location)
			{
				if (global::Infragistics.Windows.DockManager.DockManagerUtilities.IsDocked(location))
				{
					this.StorePlaceholderImpl(ref this._dockedEdgePlaceholder, placeholder);
					this.VerifyLastDockableContainer(global::Infragistics.Windows.DockManager.DockableState.Docked);
					return;
				}
				if (location == global::Infragistics.Windows.DockManager.PaneLocation.Floating)
				{
					this.StorePlaceholderImpl(ref this._floatingDockablePlaceholder, placeholder);
					this.VerifyLastDockableContainer(global::Infragistics.Windows.DockManager.DockableState.Floating);
					return;
				}
				if (location == global::Infragistics.Windows.DockManager.PaneLocation.FloatingOnly)
				{
					this.StorePlaceholderImpl(ref this._floatingOnlyPlaceholder, placeholder);
				}
			}

			// Token: 0x06000187 RID: 391 RVA: 0x00007D74 File Offset: 0x00005F74
			private void StorePlaceholderImpl(ref global::Infragistics.Windows.DockManager.ContentPanePlaceholder placeholder, global::Infragistics.Windows.DockManager.ContentPanePlaceholder newPlaceholder)
			{
				placeholder = newPlaceholder;
			}

			// Token: 0x06000188 RID: 392 RVA: 0x00007D7C File Offset: 0x00005F7C
			private void VerifyLastDockableContainer()
			{
				global::Infragistics.Windows.DockManager.DockableState preferredState = (this._lastDockableContainer != null && global::Infragistics.Windows.DockManager.DockManagerUtilities.IsFloating(this._lastDockableContainer.PaneLocation)) ? global::Infragistics.Windows.DockManager.DockableState.Floating : global::Infragistics.Windows.DockManager.DockableState.Docked;
				this.VerifyLastDockableContainer(preferredState);
			}

			// Token: 0x06000189 RID: 393 RVA: 0x00007DB0 File Offset: 0x00005FB0
			internal void VerifyLastDockableContainer(global::Infragistics.Windows.DockManager.DockableState preferredState)
			{
				global::Infragistics.Windows.DockManager.IContentPaneContainer lastDockableContainer;
				if (this._currentContainer != null && global::Infragistics.Windows.DockManager.DockManagerUtilities.IsDockable(this._currentContainer.PaneLocation))
				{
					lastDockableContainer = this._currentContainer;
				}
				else if (preferredState == global::Infragistics.Windows.DockManager.DockableState.Docked && this._dockedEdgePlaceholder != null)
				{
					lastDockableContainer = this._dockedEdgePlaceholder.Container;
				}
				else if (this._floatingDockablePlaceholder != null)
				{
					lastDockableContainer = this._floatingDockablePlaceholder.Container;
				}
				else
				{
					lastDockableContainer = null;
				}
				this._lastDockableContainer = lastDockableContainer;
			}

			// Token: 0x04000077 RID: 119
			private global::Infragistics.Windows.DockManager.ContentPanePlaceholder _dockedEdgePlaceholder;

			// Token: 0x04000078 RID: 120
			private global::Infragistics.Windows.DockManager.ContentPanePlaceholder _floatingDockablePlaceholder;

			// Token: 0x04000079 RID: 121
			private global::Infragistics.Windows.DockManager.ContentPanePlaceholder _floatingOnlyPlaceholder;

			// Token: 0x0400007A RID: 122
			private global::Infragistics.Windows.DockManager.IContentPaneContainer _currentContainer;

			// Token: 0x0400007B RID: 123
			private global::Infragistics.Windows.DockManager.IContentPaneContainer _lastDockableContainer;
		}
	}
}
