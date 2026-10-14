using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Threading;
using Infragistics.Windows.Automation.Peers;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Reporting;
using Infragistics.Windows.Themes;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000203 RID: 515
	[global::System.Windows.TemplatePart(Name = "PART_BorderTop", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplatePart(Name = "PART_BorderLeft", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplatePart(Name = "PART_BorderBottom", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplatePart(Name = "PART_BorderTopLeft", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplatePart(Name = "PART_BorderTopRight", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplatePart(Name = "PART_BorderBottomRight", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplatePart(Name = "PART_ResizeGrip", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplatePart(Name = "PART_Content", Type = typeof(global::System.Windows.Controls.ContentPresenter))]
	[global::System.Windows.TemplatePart(Name = "PART_BorderRight", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplatePart(Name = "PART_BorderBottomLeft", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplateVisualState(Name = "Active", GroupName = "ActiveStates")]
	[global::System.Windows.TemplateVisualState(Name = "Inactive", GroupName = "ActiveStates")]
	[global::System.Windows.TemplatePart(Name = "PART_Caption", Type = typeof(global::System.Windows.FrameworkElement))]
	public class ToolWindow : global::System.Windows.Controls.ContentControl, global::Infragistics.Windows.Helpers.IMinMaxWatcherOwner
	{
		// Token: 0x0600137C RID: 4988 RVA: 0x00047D14 File Offset: 0x00045F14
		static ToolWindow()
		{
			global::Infragistics.Windows.Controls.ToolWindow.ThemeChangedEvent = global::Infragistics.Windows.Themes.ThemeManager.ThemeChangedEvent.AddOwner(typeof(global::Infragistics.Windows.Controls.ToolWindow));
			global::Infragistics.Windows.Controls.ToolWindow.TitleProperty = global::System.Windows.Window.TitleProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.ToolWindow.CoerceTitle)));
			global::Infragistics.Windows.Controls.ToolWindow.TopProperty = global::System.Windows.Window.TopProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.ToolWindow));
			global::Infragistics.Windows.Controls.ToolWindow.TopmostProperty = global::System.Windows.Window.TopmostProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.ToolWindow));
			global::Infragistics.Windows.Controls.ToolWindow.UseOSNonClientAreaProperty = global::System.Windows.DependencyProperty.Register("UseOSNonClientArea", typeof(bool), typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindow.OnUseOSNonClientAreaChanged)));
			global::Infragistics.Windows.Controls.ToolWindow.VerticalAlignmentModeProperty = global::System.Windows.DependencyProperty.Register("VerticalAlignmentMode", typeof(global::Infragistics.Windows.Controls.ToolWindowAlignmentMode), typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.ToolWindowAlignmentMode.Manual, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindow.OnRelativePositionSettingChanged)));
			global::Infragistics.Windows.Controls.ToolWindow.VerticalAlignmentOffsetProperty = global::System.Windows.DependencyProperty.Register("VerticalAlignmentOffset", typeof(double), typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(0.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindow.OnRelativePositionSettingChanged)));
			global::Infragistics.Windows.Controls.ToolWindow.WindowStartupLocationProperty = global::System.Windows.DependencyProperty.Register("WindowStartupLocation", typeof(global::Infragistics.Windows.Controls.ToolWindowStartupLocation), typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.ToolWindowStartupLocation.Manual));
			global::Infragistics.Windows.Controls.ToolWindow.WindowStateProperty = global::System.Windows.DependencyProperty.Register("WindowState", typeof(global::System.Windows.WindowState), typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.WindowState.Normal, global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindow.OnWindowStateChanged)));
			global::Infragistics.Windows.Controls.ToolWindow.HitTestCodePropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("HitTestCode", typeof(global::Infragistics.Windows.Helpers.NativeWindowMethods.HitTestResults), typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Helpers.NativeWindowMethods.HitTestResults.HTNOWHERE));
			global::Infragistics.Windows.Controls.ToolWindow.HitTestCodeProperty = global::Infragistics.Windows.Controls.ToolWindow.HitTestCodePropertyKey.DependencyProperty;
			global::Infragistics.Windows.Controls.ToolWindow.HostProperty = global::System.Windows.DependencyProperty.Register("Host", typeof(global::Infragistics.Windows.Controls.IToolWindowHost), typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindow.OnHostChanged)));
			global::Infragistics.Windows.Controls.ToolWindow.ToolWindowPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("ToolWindow", typeof(global::Infragistics.Windows.Controls.ToolWindow), typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.Inherits | global::System.Windows.FrameworkPropertyMetadataOptions.OverridesInheritanceBehavior, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindow.OnToolWindowChanged)));
			global::Infragistics.Windows.Controls.ToolWindow.ToolWindowProperty = global::Infragistics.Windows.Controls.ToolWindow.ToolWindowPropertyKey.DependencyProperty;
			global::Infragistics.Windows.Controls.ToolWindow.PreferredBorderWidthProperty = global::System.Windows.DependencyProperty.Register("PreferredBorderWidth", typeof(double), typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(0.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindow.OnPreferredBorderSizeChanged)));
			global::Infragistics.Windows.Controls.ToolWindow.PreferredBorderHeightProperty = global::System.Windows.DependencyProperty.Register("PreferredBorderHeight", typeof(double), typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(0.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindow.OnPreferredBorderSizeChanged)));
			global::Infragistics.Windows.Controls.ToolWindow.ToolWindowPartProperty = global::System.Windows.DependencyProperty.Register("ToolWindowPart", typeof(object), typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(null), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Controls.ToolWindow.ValidateToolWindowPart));
			global::Infragistics.Windows.Controls.ToolWindow._getOwnerHwndFailed = false;
			global::Infragistics.Windows.Controls.ToolWindow.CloseCommand = new global::System.Windows.Input.RoutedCommand("Close", typeof(global::Infragistics.Windows.Controls.ToolWindow));
			global::Infragistics.Windows.Controls.ToolWindow.MinimizeCommand = new global::System.Windows.Input.RoutedCommand("Minimize", typeof(global::Infragistics.Windows.Controls.ToolWindow));
			global::Infragistics.Windows.Controls.ToolWindow.MaximizeCommand = new global::System.Windows.Input.RoutedCommand("Maximize", typeof(global::Infragistics.Windows.Controls.ToolWindow));
			global::Infragistics.Windows.Controls.ToolWindow.RestoreCommand = new global::System.Windows.Input.RoutedCommand("Restore", typeof(global::Infragistics.Windows.Controls.ToolWindow));
			global::Infragistics.Windows.Controls.ToolWindow.EventActivated = new object();
			global::Infragistics.Windows.Controls.ToolWindow.EventDeactivated = new object();
			global::Infragistics.Windows.Controls.ToolWindow.EventClosing = new object();
			global::Infragistics.Windows.Controls.ToolWindow.EventClosed = new object();
			global::Infragistics.Windows.Controls.ToolWindow.EventWindowShowing = new object();
			global::Infragistics.Windows.Themes.ThemeManager.RegisterGroupings(typeof(global::Infragistics.Windows.Controls.ToolWindow), new string[]
			{
				global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesGeneric.Locator>.Location.Grouping
			});
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Controls.ToolWindow)));
			global::System.Windows.Input.KeyboardNavigation.IsTabStopProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::System.Windows.Controls.Control.HorizontalContentAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.HorizontalAlignmentStretchBox));
			global::System.Windows.Controls.Control.VerticalContentAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VerticalAlignmentStretchBox));
			global::System.Windows.FrameworkElement.HorizontalAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindow.OnRelativePositionSettingChanged)));
			global::System.Windows.FrameworkElement.VerticalAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindow.OnRelativePositionSettingChanged)));
			global::System.Windows.FrameworkElement.MinWidthProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.ToolWindow.CoerceMinWidth)));
			global::System.Windows.FrameworkElement.MinHeightProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.ToolWindow.CoerceMinHeight)));
			global::System.Windows.FrameworkElement.MaxWidthProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.ToolWindow.CoerceMaxWidth)));
			global::System.Windows.FrameworkElement.MaxHeightProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.ToolWindow.CoerceMaxHeight)));
			global::System.Windows.FrameworkElement.WidthProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.ToolWindow.CoerceWidth)));
			global::System.Windows.FrameworkElement.HeightProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.ToolWindow.CoerceHeight)));
			global::System.Windows.FrameworkElement.FlowDirectionProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindow.OnFlowDirectionChanged)));
			global::System.Windows.UIElement.VisibilityProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindow.OnVisibilityChanged)));
			global::System.Windows.Input.CommandManager.RegisterClassCommandBinding(typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.Input.CommandBinding(global::Infragistics.Windows.Controls.ToolWindow.CloseCommand, new global::System.Windows.Input.ExecutedRoutedEventHandler(global::Infragistics.Windows.Controls.ToolWindow.OnExecuteCommand), new global::System.Windows.Input.CanExecuteRoutedEventHandler(global::Infragistics.Windows.Controls.ToolWindow.OnCanExecuteCommand)));
			global::System.Windows.Input.CommandManager.RegisterClassCommandBinding(typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.Input.CommandBinding(global::Infragistics.Windows.Controls.ToolWindow.MinimizeCommand, new global::System.Windows.Input.ExecutedRoutedEventHandler(global::Infragistics.Windows.Controls.ToolWindow.OnExecuteCommand), new global::System.Windows.Input.CanExecuteRoutedEventHandler(global::Infragistics.Windows.Controls.ToolWindow.OnCanExecuteCommand)));
			global::System.Windows.Input.CommandManager.RegisterClassCommandBinding(typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.Input.CommandBinding(global::Infragistics.Windows.Controls.ToolWindow.MaximizeCommand, new global::System.Windows.Input.ExecutedRoutedEventHandler(global::Infragistics.Windows.Controls.ToolWindow.OnExecuteCommand), new global::System.Windows.Input.CanExecuteRoutedEventHandler(global::Infragistics.Windows.Controls.ToolWindow.OnCanExecuteCommand)));
			global::System.Windows.Input.CommandManager.RegisterClassCommandBinding(typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.Input.CommandBinding(global::Infragistics.Windows.Controls.ToolWindow.RestoreCommand, new global::System.Windows.Input.ExecutedRoutedEventHandler(global::Infragistics.Windows.Controls.ToolWindow.OnExecuteCommand), new global::System.Windows.Input.CanExecuteRoutedEventHandler(global::Infragistics.Windows.Controls.ToolWindow.OnCanExecuteCommand)));
			global::Infragistics.Windows.Controls.ToolWindow.PartCount = global::System.Enum.GetValues(typeof(global::Infragistics.Windows.Controls.ToolWindowPart)).Length;
			global::Infragistics.Windows.Controls.ToolWindow.BoxedParts = new object[global::Infragistics.Windows.Controls.ToolWindow.PartCount];
			for (int i = 0; i < global::Infragistics.Windows.Controls.ToolWindow.PartCount; i++)
			{
				global::Infragistics.Windows.Controls.ToolWindow.BoxedParts[i] = global::System.Enum.ToObject(typeof(global::Infragistics.Windows.Controls.ToolWindowPart), i);
			}
		}

		// Token: 0x0600137D RID: 4989 RVA: 0x00048824 File Offset: 0x00046A24
		public ToolWindow()
		{
			this._cachedWindowState = (global::System.Windows.WindowState)base.GetValue(global::Infragistics.Windows.Controls.ToolWindow.WindowStateProperty);
			base.SetValue(global::Infragistics.Windows.Controls.ToolWindow.ToolWindowPropertyKey, this);
			base.Loaded += this.OnLoaded;
		}

		// Token: 0x0600137E RID: 4990 RVA: 0x00048880 File Offset: 0x00046A80
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			if (this._parts == null)
			{
				this._parts = new global::System.Windows.FrameworkElement[global::Infragistics.Windows.Controls.ToolWindow.PartCount];
			}
			else
			{
				for (int i = 0; i < global::Infragistics.Windows.Controls.ToolWindow.PartCount; i++)
				{
					global::System.Windows.FrameworkElement frameworkElement = this._parts[i];
					if (frameworkElement != null)
					{
						frameworkElement.ClearValue(global::Infragistics.Windows.Controls.ToolWindow.HitTestCodePropertyKey);
						frameworkElement.ClearValue(global::Infragistics.Windows.Controls.ToolWindow.ToolWindowPartProperty);
						frameworkElement.MouseLeftButtonDown -= this.OnPartMouseLeftButtonDown;
						frameworkElement.QueryCursor -= this.OnPartQueryCursor;
					}
				}
			}
			for (int j = 0; j < global::Infragistics.Windows.Controls.ToolWindow.PartCount; j++)
			{
				global::Infragistics.Windows.Controls.ToolWindowPart toolWindowPart = (global::Infragistics.Windows.Controls.ToolWindowPart)j;
				string partName = global::Infragistics.Windows.Controls.ToolWindow.GetPartName(toolWindowPart);
				global::System.Windows.FrameworkElement frameworkElement2 = base.GetTemplateChild(partName) as global::System.Windows.FrameworkElement;
				if (frameworkElement2 != null && toolWindowPart != global::Infragistics.Windows.Controls.ToolWindowPart.Content)
				{
					frameworkElement2.SetValue(global::Infragistics.Windows.Controls.ToolWindow.HitTestCodePropertyKey, global::Infragistics.Windows.Helpers.NativeWindowMethods.GetHitTestResult(toolWindowPart));
					frameworkElement2.SetValue(global::Infragistics.Windows.Controls.ToolWindow.ToolWindowPartProperty, global::Infragistics.Windows.Controls.ToolWindow.BoxedParts[j]);
					frameworkElement2.MouseLeftButtonDown += this.OnPartMouseLeftButtonDown;
					frameworkElement2.QueryCursor += this.OnPartQueryCursor;
				}
				this._parts[j] = frameworkElement2;
			}
			this.CalculateMinMaxExtents(true);
			this.VerifyResizeGripHitTestResult();
			this._hasVisualStateGroups = global::Infragistics.VisualStateUtilities.GetHasVisualStateGroups(this);
			this.UpdateVisualStates(false);
		}

		// Token: 0x0600137F RID: 4991 RVA: 0x000489B8 File Offset: 0x00046BB8
		protected override void OnContentChanged(object oldContent, object newContent)
		{
			base.OnContentChanged(oldContent, newContent);
			this.CalculateMinMaxExtents(true);
			if (this._minMaxWatcher != null)
			{
				global::System.Windows.Data.BindingOperations.ClearAllBindings(this._minMaxWatcher);
			}
			this._minMaxWatcher = ((newContent is global::System.Windows.FrameworkElement) ? new global::Infragistics.Windows.Helpers.MinMaxWatcher(this, (global::System.Windows.FrameworkElement)newContent) : null);
		}

		// Token: 0x06001380 RID: 4992 RVA: 0x00048A04 File Offset: 0x00046C04
		protected sealed override void OnContextMenuOpening(global::System.Windows.Controls.ContextMenuEventArgs e)
		{
			base.OnContextMenuOpening(e);
			if (this.ShowContextMenu(e.OriginalSource, new global::System.Windows.Point(e.CursorLeft, e.CursorTop), true))
			{
				e.Handled = true;
			}
		}

		// Token: 0x06001381 RID: 4993 RVA: 0x00048A34 File Offset: 0x00046C34
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.ToolWindowAutomationPeer(this);
		}

		// Token: 0x06001382 RID: 4994 RVA: 0x00048A3C File Offset: 0x00046C3C
		protected override void OnInitialized(global::System.EventArgs e)
		{
			base.OnInitialized(e);
			this.InitializeBorderThicknessBindings();
		}

		// Token: 0x06001383 RID: 4995 RVA: 0x00048A4B File Offset: 0x00046C4B
		protected override void OnPreviewMouseDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (this.Host != null)
			{
				this.Host.Activate();
			}
			base.OnPreviewMouseDown(e);
		}

		// Token: 0x06001384 RID: 4996 RVA: 0x00048A67 File Offset: 0x00046C67
		public override string ToString()
		{
			return string.Format("{0} Content: {1}", base.GetType().Name, base.Content);
		}

		// Token: 0x06001385 RID: 4997 RVA: 0x00048A84 File Offset: 0x00046C84
		private static void OnAllowCloseChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Input.CommandManager.InvalidateRequerySuggested();
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06001386 RID: 4998 RVA: 0x00048A8B File Offset: 0x00046C8B
		// (set) Token: 0x06001387 RID: 4999 RVA: 0x00048A9D File Offset: 0x00046C9D
		[global::System.ComponentModel.Bindable(true)]
		public bool AllowClose
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.ToolWindow.AllowCloseProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ToolWindow.AllowCloseProperty, value);
			}
		}

		// Token: 0x06001388 RID: 5000 RVA: 0x00048AB0 File Offset: 0x00046CB0
		private static object CoerceAllowMaximize(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = d as global::Infragistics.Windows.Controls.ToolWindow;
			if (toolWindow.ResizeMode == global::System.Windows.ResizeMode.NoResize)
			{
				return global::Infragistics.KnownBoxes.FalseBox;
			}
			return baseValue;
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06001389 RID: 5001 RVA: 0x00048AD3 File Offset: 0x00046CD3
		// (set) Token: 0x0600138A RID: 5002 RVA: 0x00048AE5 File Offset: 0x00046CE5
		[global::System.ComponentModel.Bindable(true)]
		public bool AllowMaximize
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.ToolWindow.AllowMaximizeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ToolWindow.AllowMaximizeProperty, value);
			}
		}

		// Token: 0x0600138B RID: 5003 RVA: 0x00048AF8 File Offset: 0x00046CF8
		private static object CoerceAllowMinimize(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = d as global::Infragistics.Windows.Controls.ToolWindow;
			switch (toolWindow.ResizeMode)
			{
			case global::System.Windows.ResizeMode.NoResize:
				return global::Infragistics.KnownBoxes.FalseBox;
			case global::System.Windows.ResizeMode.CanMinimize:
				return global::Infragistics.KnownBoxes.TrueBox;
			default:
				return baseValue;
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x0600138C RID: 5004 RVA: 0x00048B30 File Offset: 0x00046D30
		// (set) Token: 0x0600138D RID: 5005 RVA: 0x00048B42 File Offset: 0x00046D42
		[global::System.ComponentModel.Bindable(true)]
		public bool AllowMinimize
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.ToolWindow.AllowMinimizeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ToolWindow.AllowMinimizeProperty, value);
			}
		}

		// Token: 0x0600138E RID: 5006 RVA: 0x00048B55 File Offset: 0x00046D55
		private static void OnAllowsTransparencyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.Controls.ToolWindow)d).OnSupportsAllowsTransparencyChanged();
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x0600138F RID: 5007 RVA: 0x00048B62 File Offset: 0x00046D62
		// (set) Token: 0x06001390 RID: 5008 RVA: 0x00048B74 File Offset: 0x00046D74
		[global::System.ComponentModel.Bindable(true)]
		public bool AllowsTransparency
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.ToolWindow.AllowsTransparencyProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ToolWindow.AllowsTransparencyProperty, value);
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06001391 RID: 5009 RVA: 0x00048B87 File Offset: 0x00046D87
		// (set) Token: 0x06001392 RID: 5010 RVA: 0x00048B99 File Offset: 0x00046D99
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Visibility CaptionVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.Controls.ToolWindow.CaptionVisibilityProperty);
			}
			protected set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ToolWindow.CaptionVisibilityPropertyKey, value);
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06001393 RID: 5011 RVA: 0x00048BAC File Offset: 0x00046DAC
		// (set) Token: 0x06001394 RID: 5012 RVA: 0x00048BBC File Offset: 0x00046DBC
		[global::System.ComponentModel.Bindable(true)]
		public bool? DialogResult
		{
			get
			{
				base.VerifyAccess();
				return this._dialogResult;
			}
			set
			{
				base.VerifyAccess();
				if (!this._showingAsDialog)
				{
					throw new global::System.InvalidOperationException(global::SR.GetString("LE_CannotSetDialogResult"));
				}
				if (value != this._dialogResult)
				{
					this._dialogResult = value;
					this.Close();
				}
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06001395 RID: 5013 RVA: 0x00048C25 File Offset: 0x00046E25
		// (set) Token: 0x06001396 RID: 5014 RVA: 0x00048C37 File Offset: 0x00046E37
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Controls.ToolWindowAlignmentMode HorizontalAlignmentMode
		{
			get
			{
				return (global::Infragistics.Windows.Controls.ToolWindowAlignmentMode)base.GetValue(global::Infragistics.Windows.Controls.ToolWindow.HorizontalAlignmentModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ToolWindow.HorizontalAlignmentModeProperty, value);
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06001397 RID: 5015 RVA: 0x00048C4A File Offset: 0x00046E4A
		// (set) Token: 0x06001398 RID: 5016 RVA: 0x00048C5C File Offset: 0x00046E5C
		[global::System.ComponentModel.Bindable(true)]
		public double HorizontalAlignmentOffset
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.Controls.ToolWindow.HorizontalAlignmentOffsetProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ToolWindow.HorizontalAlignmentOffsetProperty, value);
			}
		}

		// Token: 0x06001399 RID: 5017 RVA: 0x00048C70 File Offset: 0x00046E70
		private static void OnIsActiveChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = (global::Infragistics.Windows.Controls.ToolWindow)d;
			if (true.Equals(e.NewValue))
			{
				toolWindow.OnActivated(global::System.EventArgs.Empty);
			}
			else
			{
				toolWindow.OnDeactivated(global::System.EventArgs.Empty);
			}
			toolWindow.UpdateVisualStates(false);
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x0600139A RID: 5018 RVA: 0x00048CB5 File Offset: 0x00046EB5
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool IsActive
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.ToolWindow.IsActiveProperty);
			}
		}

		// Token: 0x0600139B RID: 5019 RVA: 0x00048CC8 File Offset: 0x00046EC8
		private static void OnIsOwnedWindowChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = d as global::Infragistics.Windows.Controls.ToolWindow;
			if (toolWindow.Host != null && toolWindow.Host.IsWindow && toolWindow.IsVisible)
			{
				try
				{
					toolWindow.VerifyIsOwnedState();
				}
				catch (global::System.Security.SecurityException)
				{
				}
			}
		}

		// Token: 0x0600139C RID: 5020 RVA: 0x00048D14 File Offset: 0x00046F14
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private void VerifyIsOwnedState()
		{
			if (this.Host == null || !this.Host.IsWindow)
			{
				return;
			}
			if (this.IsOwnedWindow)
			{
				this.SetWindowOwner(this.Host as global::System.Windows.Window, global::Infragistics.Windows.Controls.ToolWindow.GetOwningWindow(this.Owner));
				return;
			}
			this.ClearWindowOwner(this.Host as global::System.Windows.Window);
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x0600139D RID: 5021 RVA: 0x00048D6D File Offset: 0x00046F6D
		// (set) Token: 0x0600139E RID: 5022 RVA: 0x00048D7F File Offset: 0x00046F7F
		[global::System.ComponentModel.Bindable(true)]
		public bool IsOwnedWindow
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.ToolWindow.IsOwnedWindowProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ToolWindow.IsOwnedWindowProperty, value);
			}
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x00048D94 File Offset: 0x00046F94
		private static void OnIsUsingOSNonClientAreaChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = d as global::Infragistics.Windows.Controls.ToolWindow;
			toolWindow.InitializeBorderThicknessBindings();
			if (toolWindow.Host != null && !toolWindow.IsModal && toolWindow.Host.IsWindow && toolWindow.IsVisible)
			{
				toolWindow.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::Infragistics.Windows.Controls.ToolWindow.MethodInvoker(toolWindow.ReshowIfVisible));
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x060013A0 RID: 5024 RVA: 0x00048DED File Offset: 0x00046FED
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsUsingOSNonClientArea
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.ToolWindow.IsUsingOSNonClientAreaProperty);
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x060013A1 RID: 5025 RVA: 0x00048DFF File Offset: 0x00046FFF
		// (set) Token: 0x060013A2 RID: 5026 RVA: 0x00048E11 File Offset: 0x00047011
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.LengthConverter))]
		public double Left
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.Controls.ToolWindow.LeftProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ToolWindow.LeftProperty, value);
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x060013A3 RID: 5027 RVA: 0x00048E24 File Offset: 0x00047024
		// (set) Token: 0x060013A4 RID: 5028 RVA: 0x00048E36 File Offset: 0x00047036
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Visibility MaximizeButtonVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.Controls.ToolWindow.MaximizeButtonVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ToolWindow.MaximizeButtonVisibilityProperty, value);
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x060013A5 RID: 5029 RVA: 0x00048E49 File Offset: 0x00047049
		// (set) Token: 0x060013A6 RID: 5030 RVA: 0x00048E5B File Offset: 0x0004705B
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Visibility MinimizeButtonVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.Controls.ToolWindow.MinimizeButtonVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ToolWindow.MinimizeButtonVisibilityProperty, value);
			}
		}

		// Token: 0x060013A7 RID: 5031 RVA: 0x00048E70 File Offset: 0x00047070
		private static void OnOwnerChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.ToolWindow @object = (global::Infragistics.Windows.Controls.ToolWindow)d;
			global::System.Windows.FrameworkElement frameworkElement = e.OldValue as global::System.Windows.FrameworkElement;
			global::System.Windows.FrameworkElement frameworkElement2 = e.NewValue as global::System.Windows.FrameworkElement;
			if (frameworkElement != null)
			{
				frameworkElement.Loaded -= @object.OnOwnerLoaded;
				frameworkElement.Unloaded -= @object.OnOwnerUnloaded;
			}
			if (frameworkElement2 != null)
			{
				frameworkElement2.Unloaded += @object.OnOwnerUnloaded;
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x060013A8 RID: 5032 RVA: 0x00048EDA File Offset: 0x000470DA
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.FrameworkElement Owner
		{
			get
			{
				return (global::System.Windows.FrameworkElement)base.GetValue(global::Infragistics.Windows.Controls.ToolWindow.OwnerProperty);
			}
		}

		// Token: 0x060013A9 RID: 5033 RVA: 0x00048EEC File Offset: 0x000470EC
		private static void OnResizeModeChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.Controls.ToolWindow)d).InitializeBorderThicknessBindings();
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x00048EFC File Offset: 0x000470FC
		private static object CoerceResizeMode(global::System.Windows.DependencyObject d, object newValue)
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = (global::Infragistics.Windows.Controls.ToolWindow)d;
			if (toolWindow._isCalculatingSizeWithoutContent && (global::System.Windows.ResizeMode)newValue == global::System.Windows.ResizeMode.CanResizeWithGrip)
			{
				return global::System.Windows.ResizeMode.CanResize;
			}
			return newValue;
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x060013AB RID: 5035 RVA: 0x00048F29 File Offset: 0x00047129
		// (set) Token: 0x060013AC RID: 5036 RVA: 0x00048F3B File Offset: 0x0004713B
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.ResizeMode ResizeMode
		{
			get
			{
				return (global::System.Windows.ResizeMode)base.GetValue(global::Infragistics.Windows.Controls.ToolWindow.ResizeModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ToolWindow.ResizeModeProperty, value);
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x060013AD RID: 5037 RVA: 0x00048F4E File Offset: 0x0004714E
		// (set) Token: 0x060013AE RID: 5038 RVA: 0x00048F60 File Offset: 0x00047160
		[global::System.ComponentModel.Bindable(true)]
		public bool ShowInTaskbar
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.ToolWindow.ShowInTaskbarProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ToolWindow.ShowInTaskbarProperty, value);
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x060013AF RID: 5039 RVA: 0x00048F73 File Offset: 0x00047173
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::System.Windows.Thickness PreferredBorderThickness
		{
			get
			{
				return (global::System.Windows.Thickness)base.GetValue(global::Infragistics.Windows.Controls.ToolWindow.PreferredBorderThicknessProperty);
			}
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x00048F88 File Offset: 0x00047188
		private static void OnThemeChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = target as global::Infragistics.Windows.Controls.ToolWindow;
			if (toolWindow.IsLoaded)
			{
				toolWindow.InvalidateMeasure();
				toolWindow.UpdateLayout();
			}
			toolWindow.OnThemeChanged((string)e.OldValue, (string)e.NewValue);
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x060013B1 RID: 5041 RVA: 0x00048FCE File Offset: 0x000471CE
		// (set) Token: 0x060013B2 RID: 5042 RVA: 0x00048FE0 File Offset: 0x000471E0
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DefaultValue(null)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Themes.ThemeTypeConverter))]
		public string Theme
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.Controls.ToolWindow.ThemeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ToolWindow.ThemeProperty, value);
			}
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x00048FF0 File Offset: 0x000471F0
		protected virtual void OnThemeChanged(string previousValue, string currentValue)
		{
			base.RaiseEvent(new global::System.Windows.RoutedPropertyChangedEventArgs<string>(previousValue, currentValue)
			{
				RoutedEvent = global::Infragistics.Windows.Controls.ToolWindow.ThemeChangedEvent,
				Source = this
			});
		}

		// Token: 0x14000029 RID: 41
		// (add) Token: 0x060013B4 RID: 5044 RVA: 0x0004901E File Offset: 0x0004721E
		// (remove) Token: 0x060013B5 RID: 5045 RVA: 0x0004902C File Offset: 0x0004722C
		public event global::System.Windows.RoutedPropertyChangedEventHandler<string> ThemeChanged
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.Controls.ToolWindow.ThemeChangedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.Controls.ToolWindow.ThemeChangedEvent, value);
			}
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x0004903C File Offset: 0x0004723C
		private static object CoerceTitle(global::System.Windows.DependencyObject d, object newValue)
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = (global::Infragistics.Windows.Controls.ToolWindow)d;
			if (toolWindow.IsUsingOSNonClientArea)
			{
				return newValue;
			}
			if (!toolWindow._isCalculatingSizeWithoutContent)
			{
				return newValue;
			}
			return "W";
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x060013B7 RID: 5047 RVA: 0x00049069 File Offset: 0x00047269
		// (set) Token: 0x060013B8 RID: 5048 RVA: 0x0004907B File Offset: 0x0004727B
		[global::System.ComponentModel.Bindable(true)]
		public string Title
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.Controls.ToolWindow.TitleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ToolWindow.TitleProperty, value);
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x060013B9 RID: 5049 RVA: 0x00049089 File Offset: 0x00047289
		// (set) Token: 0x060013BA RID: 5050 RVA: 0x0004909B File Offset: 0x0004729B
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.LengthConverter))]
		[global::System.ComponentModel.Bindable(true)]
		public double Top
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.Controls.ToolWindow.TopProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ToolWindow.TopProperty, value);
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x060013BB RID: 5051 RVA: 0x000490AE File Offset: 0x000472AE
		// (set) Token: 0x060013BC RID: 5052 RVA: 0x000490C0 File Offset: 0x000472C0
		[global::System.ComponentModel.Bindable(true)]
		public bool Topmost
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.ToolWindow.TopmostProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ToolWindow.TopmostProperty, value);
			}
		}

		// Token: 0x060013BD RID: 5053 RVA: 0x000490D3 File Offset: 0x000472D3
		private static void OnUseOSNonClientAreaChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.Controls.ToolWindow)d).VerifyIsUsingOSNonClientArea();
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x060013BE RID: 5054 RVA: 0x000490E0 File Offset: 0x000472E0
		// (set) Token: 0x060013BF RID: 5055 RVA: 0x000490F2 File Offset: 0x000472F2
		[global::System.ComponentModel.Bindable(true)]
		public bool UseOSNonClientArea
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.ToolWindow.UseOSNonClientAreaProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ToolWindow.UseOSNonClientAreaProperty, value);
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x060013C0 RID: 5056 RVA: 0x00049105 File Offset: 0x00047305
		// (set) Token: 0x060013C1 RID: 5057 RVA: 0x00049117 File Offset: 0x00047317
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Controls.ToolWindowAlignmentMode VerticalAlignmentMode
		{
			get
			{
				return (global::Infragistics.Windows.Controls.ToolWindowAlignmentMode)base.GetValue(global::Infragistics.Windows.Controls.ToolWindow.VerticalAlignmentModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ToolWindow.VerticalAlignmentModeProperty, value);
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x060013C2 RID: 5058 RVA: 0x0004912A File Offset: 0x0004732A
		// (set) Token: 0x060013C3 RID: 5059 RVA: 0x0004913C File Offset: 0x0004733C
		[global::System.ComponentModel.Bindable(true)]
		public double VerticalAlignmentOffset
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.Controls.ToolWindow.VerticalAlignmentOffsetProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ToolWindow.VerticalAlignmentOffsetProperty, value);
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x060013C4 RID: 5060 RVA: 0x0004914F File Offset: 0x0004734F
		// (set) Token: 0x060013C5 RID: 5061 RVA: 0x00049161 File Offset: 0x00047361
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Controls.ToolWindowStartupLocation WindowStartupLocation
		{
			get
			{
				return (global::Infragistics.Windows.Controls.ToolWindowStartupLocation)base.GetValue(global::Infragistics.Windows.Controls.ToolWindow.WindowStartupLocationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ToolWindow.WindowStartupLocationProperty, value);
			}
		}

		// Token: 0x060013C6 RID: 5062 RVA: 0x00049174 File Offset: 0x00047374
		private static void OnWindowStateChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = d as global::Infragistics.Windows.Controls.ToolWindow;
			toolWindow._cachedWindowState = (global::System.Windows.WindowState)e.NewValue;
			d.CoerceValue(global::System.Windows.FrameworkElement.MinHeightProperty);
			d.CoerceValue(global::System.Windows.FrameworkElement.MinWidthProperty);
			d.CoerceValue(global::System.Windows.FrameworkElement.MaxHeightProperty);
			d.CoerceValue(global::System.Windows.FrameworkElement.MaxWidthProperty);
			d.CoerceValue(global::System.Windows.FrameworkElement.HeightProperty);
			d.CoerceValue(global::System.Windows.FrameworkElement.WidthProperty);
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x060013C7 RID: 5063 RVA: 0x000491DC File Offset: 0x000473DC
		// (set) Token: 0x060013C8 RID: 5064 RVA: 0x000491E4 File Offset: 0x000473E4
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.WindowState WindowState
		{
			get
			{
				return this._cachedWindowState;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ToolWindow.WindowStateProperty, value);
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x060013C9 RID: 5065 RVA: 0x000491F7 File Offset: 0x000473F7
		internal bool AllowsTransparencyResolved
		{
			get
			{
				return this.SupportsAllowsTransparency && this.AllowsTransparency;
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x060013CA RID: 5066 RVA: 0x00049209 File Offset: 0x00047409
		internal global::System.Windows.FrameworkElement CaptionElement
		{
			get
			{
				return base.GetTemplateChild("PART_Caption") as global::System.Windows.FrameworkElement;
			}
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x0004921C File Offset: 0x0004741C
		internal void EnsureOnScreen(bool fullyInView)
		{
			global::Infragistics.Windows.Controls.IToolWindowHost host = this.Host;
			if (host == null)
			{
				return;
			}
			host.EnsureOnScreen(fullyInView);
		}

		// Token: 0x060013CC RID: 5068 RVA: 0x0004923B File Offset: 0x0004743B
		internal static global::Infragistics.Windows.Helpers.NativeWindowMethods.HitTestResults GetHitTestCode(global::System.Windows.DependencyObject d)
		{
			return (global::Infragistics.Windows.Helpers.NativeWindowMethods.HitTestResults)d.GetValue(global::Infragistics.Windows.Controls.ToolWindow.HitTestCodeProperty);
		}

		// Token: 0x060013CD RID: 5069 RVA: 0x00049250 File Offset: 0x00047450
		private static void OnHostChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = d as global::Infragistics.Windows.Controls.ToolWindow;
			toolWindow.VerifyIsUsingOSNonClientArea();
			toolWindow.CoerceValue(global::System.Windows.FrameworkElement.WidthProperty);
			toolWindow.CoerceValue(global::System.Windows.FrameworkElement.HeightProperty);
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x060013CE RID: 5070 RVA: 0x00049280 File Offset: 0x00047480
		// (set) Token: 0x060013CF RID: 5071 RVA: 0x00049292 File Offset: 0x00047492
		internal global::Infragistics.Windows.Controls.IToolWindowHost Host
		{
			get
			{
				return (global::Infragistics.Windows.Controls.IToolWindowHost)base.GetValue(global::Infragistics.Windows.Controls.ToolWindow.HostProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ToolWindow.HostProperty, value);
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x060013D0 RID: 5072 RVA: 0x000492A0 File Offset: 0x000474A0
		internal bool IsCalculatingSizeWithoutContent
		{
			get
			{
				return this._isCalculatingSizeWithoutContent;
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x060013D1 RID: 5073 RVA: 0x000492A8 File Offset: 0x000474A8
		internal bool IsDeferredShowPending
		{
			get
			{
				return this._deferredShowInfo != null;
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x060013D2 RID: 5074 RVA: 0x000492B6 File Offset: 0x000474B6
		internal bool IsDelayedMinMaxPending
		{
			get
			{
				return this._isDelayedMinMaxPending;
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x060013D3 RID: 5075 RVA: 0x000492BE File Offset: 0x000474BE
		internal bool IsModal
		{
			get
			{
				return this._showingAsDialog;
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x060013D4 RID: 5076 RVA: 0x000492C6 File Offset: 0x000474C6
		internal bool IsReshowing
		{
			get
			{
				return this._isReshowing;
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x060013D5 RID: 5077 RVA: 0x000492CE File Offset: 0x000474CE
		internal virtual bool KeepOnScreen
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x060013D6 RID: 5078 RVA: 0x000492D1 File Offset: 0x000474D1
		// (set) Token: 0x060013D7 RID: 5079 RVA: 0x000492D9 File Offset: 0x000474D9
		internal bool RestoreToMaximized
		{
			get
			{
				return this._restoreToMaximized;
			}
			set
			{
				this._restoreToMaximized = value;
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x060013D8 RID: 5080 RVA: 0x000492E2 File Offset: 0x000474E2
		// (set) Token: 0x060013D9 RID: 5081 RVA: 0x000492EA File Offset: 0x000474EA
		internal bool IsNonClientTouchDrag { get; set; }

		// Token: 0x060013DA RID: 5082 RVA: 0x000492F4 File Offset: 0x000474F4
		private static void OnToolWindowChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (global::System.Windows.Input.Keyboard.FocusedElement == d)
			{
				if (e.OldValue != null)
				{
					((global::Infragistics.Windows.Controls.ToolWindow)e.OldValue).ClearValue(global::Infragistics.Windows.Controls.ToolWindow.IsActivePropertyKey);
					return;
				}
				if (e.NewValue != null)
				{
					((global::Infragistics.Windows.Controls.ToolWindow)e.NewValue).SetValue(global::Infragistics.Windows.Controls.ToolWindow.IsActivePropertyKey, global::Infragistics.KnownBoxes.TrueBox);
				}
			}
		}

		// Token: 0x060013DB RID: 5083 RVA: 0x0004934D File Offset: 0x0004754D
		public static global::Infragistics.Windows.Controls.ToolWindow GetToolWindow(global::System.Windows.DependencyObject d)
		{
			return (global::Infragistics.Windows.Controls.ToolWindow)d.GetValue(global::Infragistics.Windows.Controls.ToolWindow.ToolWindowProperty);
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x060013DC RID: 5084 RVA: 0x0004935F File Offset: 0x0004755F
		internal bool UsesRelativePosition
		{
			get
			{
				return (!this._isLoadedAfterShow || !this._showingAsDialog) && (this.VerticalAlignmentMode == global::Infragistics.Windows.Controls.ToolWindowAlignmentMode.UseAlignment || this.HorizontalAlignmentMode == global::Infragistics.Windows.Controls.ToolWindowAlignmentMode.UseAlignment);
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x060013DD RID: 5085 RVA: 0x00049386 File Offset: 0x00047586
		protected global::System.ComponentModel.EventHandlerList Events
		{
			get
			{
				if (this._events == null)
				{
					this._events = new global::System.ComponentModel.EventHandlerList();
				}
				return this._events;
			}
		}

		// Token: 0x060013DE RID: 5086 RVA: 0x000493A1 File Offset: 0x000475A1
		private static void OnPreferredBorderSizeChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.Controls.ToolWindow)d).UpdatePreferredBorderThickness();
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x060013DF RID: 5087 RVA: 0x000493AE File Offset: 0x000475AE
		// (set) Token: 0x060013E0 RID: 5088 RVA: 0x000493C0 File Offset: 0x000475C0
		private double PreferredBorderWidth
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.Controls.ToolWindow.PreferredBorderWidthProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ToolWindow.PreferredBorderWidthProperty, value);
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x060013E1 RID: 5089 RVA: 0x000493D3 File Offset: 0x000475D3
		// (set) Token: 0x060013E2 RID: 5090 RVA: 0x000493E5 File Offset: 0x000475E5
		private double PreferredBorderHeight
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.Controls.ToolWindow.PreferredBorderHeightProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ToolWindow.PreferredBorderHeightProperty, value);
			}
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x000493F8 File Offset: 0x000475F8
		private static bool ValidateToolWindowPart(object newValue)
		{
			return newValue == null || newValue is global::Infragistics.Windows.Controls.ToolWindowPart;
		}

		// Token: 0x060013E4 RID: 5092 RVA: 0x00049408 File Offset: 0x00047608
		private global::Infragistics.Windows.Controls.ToolWindowPart? GetToolWindowPart(global::System.Windows.DependencyObject d)
		{
			return (global::Infragistics.Windows.Controls.ToolWindowPart?)d.GetValue(global::Infragistics.Windows.Controls.ToolWindow.ToolWindowPartProperty);
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x0004941C File Offset: 0x0004761C
		internal void AdjustRelativeRect(global::System.Windows.Rect ownerRect, ref global::System.Windows.Rect rect)
		{
			if (!this.UsesRelativePosition)
			{
				return;
			}
			if (this.VerticalAlignmentMode == global::Infragistics.Windows.Controls.ToolWindowAlignmentMode.UseAlignment)
			{
				switch (base.VerticalAlignment)
				{
				case global::System.Windows.VerticalAlignment.Top:
					rect.Y = ownerRect.Top;
					break;
				case global::System.Windows.VerticalAlignment.Center:
					rect.Y = ownerRect.Top + (ownerRect.Height - rect.Height) / 2.0;
					break;
				case global::System.Windows.VerticalAlignment.Bottom:
					rect.Y = ownerRect.Bottom - rect.Height;
					break;
				case global::System.Windows.VerticalAlignment.Stretch:
					rect.Y = ownerRect.Top;
					rect.Height = ownerRect.Height;
					break;
				}
				rect.Y += this.VerticalAlignmentOffset;
			}
			if (this.HorizontalAlignmentMode == global::Infragistics.Windows.Controls.ToolWindowAlignmentMode.UseAlignment)
			{
				global::System.Windows.HorizontalAlignment horizontalAlignment = base.HorizontalAlignment;
				bool flag = this.Owner != null && this.Owner.FlowDirection == global::System.Windows.FlowDirection.LeftToRight;
				if (!flag)
				{
					switch (horizontalAlignment)
					{
					case global::System.Windows.HorizontalAlignment.Left:
						horizontalAlignment = global::System.Windows.HorizontalAlignment.Right;
						break;
					case global::System.Windows.HorizontalAlignment.Right:
						horizontalAlignment = global::System.Windows.HorizontalAlignment.Left;
						break;
					}
				}
				switch (horizontalAlignment)
				{
				case global::System.Windows.HorizontalAlignment.Left:
					rect.X = ownerRect.Left;
					break;
				case global::System.Windows.HorizontalAlignment.Center:
					rect.X = ownerRect.Left + (ownerRect.Width - rect.Width) / 2.0;
					break;
				case global::System.Windows.HorizontalAlignment.Right:
					rect.X = ownerRect.Right - rect.Width;
					break;
				case global::System.Windows.HorizontalAlignment.Stretch:
					rect.X = ownerRect.Left;
					rect.Width = ownerRect.Width;
					break;
				}
				if (flag)
				{
					rect.X += this.HorizontalAlignmentOffset;
					return;
				}
				rect.X -= this.HorizontalAlignmentOffset;
			}
		}

		// Token: 0x060013E6 RID: 5094 RVA: 0x000495D0 File Offset: 0x000477D0
		internal void CalculateMinMaxExtents(bool async)
		{
			this._sizeWithoutCaption = (this._sizeWithoutContent = global::System.Windows.Size.Empty);
			if (!async || global::Infragistics.Windows.Reporting.ReportSection.GetIsInReport(this))
			{
				this.CalculateMinMaxExtentsImpl();
				return;
			}
			this._isDelayedMinMaxPending = true;
			if (this.Host == null || this.Host.HandlesDelayedMinMaxRequests)
			{
				return;
			}
			base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.DataBind, new global::Infragistics.Windows.Controls.ToolWindow.MethodInvoker(this.CalculateMinMaxExtentsImpl));
		}

		// Token: 0x060013E7 RID: 5095 RVA: 0x00049639 File Offset: 0x00047839
		internal virtual void CloseOverride()
		{
			if (this.Host != null)
			{
				this.Host.Close();
				return;
			}
			if (this.Owner != null)
			{
				base.ClearValue(global::Infragistics.Windows.Controls.ToolWindow.OwnerPropertyKey);
			}
		}

		// Token: 0x060013E8 RID: 5096 RVA: 0x00049664 File Offset: 0x00047864
		internal static global::System.IntPtr GetOwnerHwnd(global::System.Windows.FrameworkElement owner)
		{
			if (global::Infragistics.Windows.Controls.ToolWindow._getOwnerHwndFailed)
			{
				return global::System.IntPtr.Zero;
			}
			if (global::System.Windows.Interop.BrowserInteropHelper.IsBrowserHosted)
			{
				return global::System.IntPtr.Zero;
			}
			global::System.IntPtr result;
			try
			{
				result = global::Infragistics.Windows.Controls.ToolWindow.GetOwnerHwndImpl(owner);
			}
			catch (global::System.Security.SecurityException)
			{
				global::Infragistics.Windows.Controls.ToolWindow._getOwnerHwndFailed = true;
				result = global::System.IntPtr.Zero;
			}
			return result;
		}

		// Token: 0x060013E9 RID: 5097 RVA: 0x000496B4 File Offset: 0x000478B4
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private static global::System.IntPtr GetOwnerHwndImpl(global::System.Windows.FrameworkElement owner)
		{
			global::System.Windows.Interop.HwndSource hwndSource = global::System.Windows.PresentationSource.FromVisual(owner) as global::System.Windows.Interop.HwndSource;
			if (hwndSource == null)
			{
				return global::System.IntPtr.Zero;
			}
			return hwndSource.Handle;
		}

		// Token: 0x060013EA RID: 5098 RVA: 0x000496DC File Offset: 0x000478DC
		internal global::System.Windows.Rect GetRestoreBounds(bool queryHost)
		{
			if (queryHost && this.Host != null)
			{
				return this.Host.GetRestoreBounds();
			}
			return this._restoreBounds;
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x000496FB File Offset: 0x000478FB
		internal global::System.Windows.FrameworkElement GetTemplatePart(global::Infragistics.Windows.Controls.ToolWindowPart part)
		{
			if (this._parts != null)
			{
				return this._parts[(int)part];
			}
			return null;
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x00049710 File Offset: 0x00047910
		internal static bool IsMouseOverRoot(global::System.Windows.FrameworkElement relativeElement, global::System.Windows.Point relativePoint)
		{
			global::System.IntPtr ownerHwnd = global::Infragistics.Windows.Controls.ToolWindow.GetOwnerHwnd(relativeElement);
			if (ownerHwnd != global::System.IntPtr.Zero)
			{
				return global::Infragistics.Windows.Controls.ToolWindow.IsMouseOverRootUnsafe(ownerHwnd, relativeElement, relativePoint);
			}
			global::System.Windows.Media.Visual commonAncestor = global::Infragistics.Windows.Utilities.GetCommonAncestor(relativeElement, null);
			global::System.Windows.Point point = global::Infragistics.Windows.Utilities.PointToScreenSafe(commonAncestor, default(global::System.Windows.Point));
			global::System.Windows.Point point2 = global::Infragistics.Windows.Utilities.PointToScreenSafe(commonAncestor, global::System.Windows.Media.VisualTreeHelper.GetDescendantBounds(commonAncestor).BottomRight);
			global::System.Windows.Rect rect = global::Infragistics.Windows.Utilities.RectFromPoints(point, point2);
			global::System.Windows.Point point3 = global::Infragistics.Windows.Utilities.PointToScreenSafe(relativeElement, relativePoint);
			return rect.Contains(point3);
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x00049784 File Offset: 0x00047984
		private static bool IsMouseOverRootUnsafe(global::System.IntPtr hwnd, global::System.Windows.FrameworkElement relativeElement, global::System.Windows.Point relativePoint)
		{
			global::System.Windows.Point point = global::Infragistics.Windows.Utilities.PointToScreenSafe(relativeElement, relativePoint);
			global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT rcWindow = global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowInfo(hwnd).rcWindow;
			return rcWindow.ToRect().Contains(point);
		}

		// Token: 0x060013EE RID: 5102 RVA: 0x000497B8 File Offset: 0x000479B8
		internal void OnClosedInternal()
		{
			if (this._showingAsDialog && this._dialogResult == null)
			{
				this._dialogResult = new bool?(false);
			}
			this._isLoadedAfterShow = false;
			if (this._deferredShowInfo == null || !this._deferredShowInfo.IsCancelled)
			{
				this.OnClosed(global::System.EventArgs.Empty);
			}
			base.ClearValue(global::Infragistics.Windows.Controls.ToolWindow.OwnerPropertyKey);
			if (this._showingAsDialog)
			{
				this.OnEndShowDialog();
			}
		}

		// Token: 0x060013EF RID: 5103 RVA: 0x00049828 File Offset: 0x00047A28
		internal bool OnClosingInternal(global::System.ComponentModel.CancelEventArgs e)
		{
			if (this._deferredShowInfo != null && this._deferredShowInfo.IsCancelled)
			{
				return false;
			}
			this.OnClosing(e);
			if (this._isReshowing)
			{
				e.Cancel = false;
			}
			if (e.Cancel)
			{
				this._dialogResult = null;
			}
			return e.Cancel;
		}

		// Token: 0x060013F0 RID: 5104 RVA: 0x0004987C File Offset: 0x00047A7C
		protected internal virtual bool OnDoubleClickCaption(global::System.Windows.Point pt, global::System.Windows.Input.MouseDevice mouse)
		{
			if (this.Host != null)
			{
				global::System.Windows.WindowState windowState = this.WindowState;
				switch (this.WindowState)
				{
				case global::System.Windows.WindowState.Normal:
					if (this.AllowMaximize)
					{
						windowState = global::System.Windows.WindowState.Maximized;
					}
					break;
				case global::System.Windows.WindowState.Minimized:
					if (this.AllowMinimize)
					{
						if (this.RestoreToMaximized && this.AllowMaximize)
						{
							windowState = global::System.Windows.WindowState.Maximized;
						}
						else
						{
							windowState = global::System.Windows.WindowState.Normal;
						}
					}
					break;
				case global::System.Windows.WindowState.Maximized:
					if (this.AllowMaximize)
					{
						windowState = global::System.Windows.WindowState.Normal;
					}
					break;
				}
				if (windowState != this.WindowState)
				{
					this.WindowState = windowState;
					return true;
				}
			}
			return false;
		}

		// Token: 0x060013F1 RID: 5105 RVA: 0x000498FC File Offset: 0x00047AFC
		protected internal virtual bool OnDragCaption(global::System.Windows.Point pt, global::System.Windows.Input.MouseDevice mouse)
		{
			return false;
		}

		// Token: 0x060013F2 RID: 5106 RVA: 0x000498FF File Offset: 0x00047AFF
		internal virtual void OnMoveCancelled()
		{
		}

		// Token: 0x060013F3 RID: 5107 RVA: 0x00049901 File Offset: 0x00047B01
		internal virtual bool OnEnterMove()
		{
			return false;
		}

		// Token: 0x060013F4 RID: 5108 RVA: 0x00049904 File Offset: 0x00047B04
		internal virtual bool OnExitMove()
		{
			return false;
		}

		// Token: 0x060013F5 RID: 5109 RVA: 0x00049907 File Offset: 0x00047B07
		internal virtual void OnWindowMoving(global::System.Windows.Point pt, global::System.Windows.Input.MouseDevice mouse, global::System.Windows.Rect logicalScreenRect)
		{
		}

		// Token: 0x060013F6 RID: 5110 RVA: 0x00049909 File Offset: 0x00047B09
		internal void SetRestoreBounds(global::System.Windows.Rect restoreBounds, bool updateHost)
		{
			if (updateHost && this.Host != null)
			{
				this.Host.SetRestoreBounds(restoreBounds);
				return;
			}
			this._restoreBounds = restoreBounds;
		}

		// Token: 0x060013F7 RID: 5111 RVA: 0x0004992A File Offset: 0x00047B2A
		internal bool ShowSystemContextMenu(global::System.Windows.Point location)
		{
			return this.ShowContextMenu(this, location, false);
		}

		// Token: 0x060013F8 RID: 5112 RVA: 0x00049935 File Offset: 0x00047B35
		internal static bool WillHostInWindow(global::System.Windows.FrameworkElement owner)
		{
			return global::Infragistics.Windows.Controls.ToolWindow.GetOwningWindow(owner) != null || global::Infragistics.Windows.Controls.ToolWindow.GetOwnerHwnd(owner) != global::System.IntPtr.Zero;
		}

		// Token: 0x060013F9 RID: 5113 RVA: 0x00049951 File Offset: 0x00047B51
		internal void VerifyIsUsingOSNonClientArea()
		{
			base.SetValue(global::Infragistics.Windows.Controls.ToolWindow.IsUsingOSNonClientAreaPropertyKey, (global::System.Windows.Window.GetWindow(this) == this.Host && this.UseOSNonClientArea) ? global::Infragistics.KnownBoxes.TrueBox : global::System.Windows.DependencyProperty.UnsetValue);
		}

		// Token: 0x060013FA RID: 5114 RVA: 0x00049980 File Offset: 0x00047B80
		private void CalculateMinMaxExtentsImpl()
		{
			if (this._parts == null)
			{
				return;
			}
			this._isDelayedMinMaxPending = false;
			this.CalculateSizeWithoutContent();
			global::System.Windows.FrameworkElement frameworkElement = this._parts[10];
			frameworkElement = ((frameworkElement != null && global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(frameworkElement) == 1) ? (global::System.Windows.Media.VisualTreeHelper.GetChild(frameworkElement, 0) as global::System.Windows.FrameworkElement) : null);
			this._calculatedMinWidth = this._sizeWithoutContent.Width;
			this._calculatedMinHeight = this._sizeWithoutContent.Height;
			this._calculatedMaxWidth = double.PositiveInfinity;
			this._calculatedMaxHeight = double.PositiveInfinity;
			if (frameworkElement != null)
			{
				bool flag = true;
				if (flag)
				{
					this._calculatedMinWidth = global::System.Math.Max(this._sizeWithoutContent.Width, this._sizeWithoutCaption.Width + frameworkElement.MinWidth);
					this._calculatedMinHeight = this._sizeWithoutContent.Height + frameworkElement.MinHeight;
					if (!double.IsInfinity(frameworkElement.MaxWidth))
					{
						this._calculatedMaxWidth = this._sizeWithoutCaption.Width + frameworkElement.MaxWidth;
					}
					if (!double.IsInfinity(frameworkElement.MaxHeight))
					{
						this._calculatedMaxHeight = this._sizeWithoutContent.Height + frameworkElement.MaxHeight;
					}
				}
				else
				{
					this._calculatedMinHeight = global::System.Math.Max(this._sizeWithoutContent.Height, this._sizeWithoutCaption.Height + frameworkElement.MinHeight);
					this._calculatedMinWidth = this._sizeWithoutContent.Width + frameworkElement.MinWidth;
					if (!double.IsInfinity(frameworkElement.MaxHeight))
					{
						this._calculatedMaxHeight = this._sizeWithoutCaption.Height + frameworkElement.MaxHeight;
					}
					if (!double.IsInfinity(frameworkElement.MaxWidth))
					{
						this._calculatedMaxWidth = this._sizeWithoutContent.Width + frameworkElement.MaxWidth;
					}
				}
			}
			base.CoerceValue(global::System.Windows.FrameworkElement.MinWidthProperty);
			base.CoerceValue(global::System.Windows.FrameworkElement.MinHeightProperty);
			base.CoerceValue(global::System.Windows.FrameworkElement.MaxWidthProperty);
			base.CoerceValue(global::System.Windows.FrameworkElement.MaxHeightProperty);
		}

		// Token: 0x060013FB RID: 5115 RVA: 0x00049B9C File Offset: 0x00047D9C
		private void CalculateSizeWithoutContent()
		{
			if (this._parts == null)
			{
				return;
			}
			bool isCalculatingSizeWithoutContent = this._isCalculatingSizeWithoutContent;
			this._isCalculatingSizeWithoutContent = true;
			try
			{
				this._calculatedMaxHeight = (this._calculatedMaxWidth = (this._calculatedMinHeight = (this._calculatedMinWidth = null)));
				base.CoerceValue(global::System.Windows.FrameworkElement.MinWidthProperty);
				base.CoerceValue(global::System.Windows.FrameworkElement.MinHeightProperty);
				base.CoerceValue(global::System.Windows.FrameworkElement.MaxWidthProperty);
				base.CoerceValue(global::System.Windows.FrameworkElement.MaxHeightProperty);
				base.CoerceValue(global::System.Windows.FrameworkElement.WidthProperty);
				base.CoerceValue(global::System.Windows.FrameworkElement.HeightProperty);
				base.CoerceValue(global::Infragistics.Windows.Controls.ToolWindow.TitleProperty);
				base.CoerceValue(global::Infragistics.Windows.Controls.ToolWindow.ResizeModeProperty);
				this.CalculateSizeWithoutContentImpl();
			}
			finally
			{
				this._isCalculatingSizeWithoutContent = isCalculatingSizeWithoutContent;
				base.CoerceValue(global::System.Windows.FrameworkElement.WidthProperty);
				base.CoerceValue(global::System.Windows.FrameworkElement.HeightProperty);
				base.CoerceValue(global::Infragistics.Windows.Controls.ToolWindow.TitleProperty);
				base.CoerceValue(global::Infragistics.Windows.Controls.ToolWindow.ResizeModeProperty);
			}
		}

		// Token: 0x060013FC RID: 5116 RVA: 0x00049C88 File Offset: 0x00047E88
		private void CalculateSizeWithoutContentImpl()
		{
			global::System.Windows.FrameworkElement frameworkElement = this._parts[10];
			global::System.Windows.FrameworkElement frameworkElement2 = this._parts[0];
			using (new global::Infragistics.Windows.Helpers.TempValueReplacement(frameworkElement, global::System.Windows.UIElement.VisibilityProperty, global::Infragistics.KnownBoxes.VisibilityCollapsedBox))
			{
				if (frameworkElement != null)
				{
					global::Infragistics.Windows.Utilities.InvalidateMeasure(frameworkElement, this);
				}
				base.InvalidateMeasure();
				base.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
				if (base.IsMeasureValid)
				{
					this._sizeWithoutContent = base.DesiredSize;
					using (new global::Infragistics.Windows.Helpers.TempValueReplacement(frameworkElement2, global::System.Windows.UIElement.VisibilityProperty, global::Infragistics.KnownBoxes.VisibilityCollapsedBox))
					{
						if (frameworkElement2 != null)
						{
							global::Infragistics.Windows.Utilities.InvalidateMeasure(frameworkElement2, this);
						}
						base.InvalidateMeasure();
						base.Measure(this._sizeWithoutContent);
						this._sizeWithoutCaption = base.DesiredSize;
						goto IL_CD;
					}
				}
				global::System.Windows.Size sizeWithoutCaption = default(global::System.Windows.Size);
				this._sizeWithoutCaption = sizeWithoutCaption;
				this._sizeWithoutContent = (this._sizeWithoutCaption = sizeWithoutCaption);
				IL_CD:;
			}
			base.InvalidateMeasure();
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x00049D90 File Offset: 0x00047F90
		private bool? CanExecute(global::System.Windows.Input.ICommand command)
		{
			if (command == global::Infragistics.Windows.Controls.ToolWindow.CloseCommand)
			{
				return new bool?(this.AllowClose);
			}
			if (command == global::Infragistics.Windows.Controls.ToolWindow.MinimizeCommand)
			{
				return new bool?(this.AllowMinimize);
			}
			if (command == global::Infragistics.Windows.Controls.ToolWindow.MaximizeCommand)
			{
				return new bool?(this.AllowMaximize);
			}
			if (command == global::Infragistics.Windows.Controls.ToolWindow.RestoreCommand)
			{
				switch (this.WindowState)
				{
				case global::System.Windows.WindowState.Normal:
					return new bool?(false);
				case global::System.Windows.WindowState.Minimized:
					return new bool?(this.AllowMinimize);
				case global::System.Windows.WindowState.Maximized:
					return new bool?(this.AllowMaximize);
				}
			}
			return null;
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x00049E24 File Offset: 0x00048024
		private void CanExecuteDialogCommand(object sender, global::System.Windows.Input.CanExecuteRoutedEventArgs e)
		{
			global::System.Windows.Input.RoutedCommand routedCommand = e.Command as global::System.Windows.Input.RoutedCommand;
			if (routedCommand.OwnerType == typeof(global::System.Windows.Window) && routedCommand.Name == "DialogCancel" && this.Host != null && !this.Host.IsWindow)
			{
				e.CanExecute = true;
				e.Handled = true;
			}
		}

		// Token: 0x060013FF RID: 5119 RVA: 0x00049E8C File Offset: 0x0004808C
		private void ClearWindowOwner(global::System.Windows.Window toolWindow)
		{
			if (toolWindow.Owner != null)
			{
				toolWindow.Owner = null;
				return;
			}
			global::System.IntPtr ownerHwnd = global::Infragistics.Windows.Controls.ToolWindow.GetOwnerHwnd(this.Owner);
			if (global::System.IntPtr.Zero != ownerHwnd)
			{
				global::System.Windows.Interop.WindowInteropHelper windowInteropHelper = new global::System.Windows.Interop.WindowInteropHelper(toolWindow);
				if (windowInteropHelper.Owner == ownerHwnd)
				{
					windowInteropHelper.Owner = global::System.IntPtr.Zero;
				}
			}
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x00049EE4 File Offset: 0x000480E4
		private static object CoerceMinMaxButtonVisibility(global::System.Windows.DependencyObject d, object newValue)
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = d as global::Infragistics.Windows.Controls.ToolWindow;
			if (!toolWindow.AllowMinimize && !toolWindow.AllowMaximize)
			{
				return global::Infragistics.KnownBoxes.VisibilityCollapsedBox;
			}
			return newValue;
		}

		// Token: 0x06001401 RID: 5121 RVA: 0x00049F10 File Offset: 0x00048110
		private static object CoerceMinWidth(global::System.Windows.DependencyObject d, object newValue)
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = (global::Infragistics.Windows.Controls.ToolWindow)d;
			if (toolWindow._isCalculatingSizeWithoutContent)
			{
				return 0.0;
			}
			if (toolWindow.WindowState != global::System.Windows.WindowState.Normal)
			{
				return 0.0;
			}
			return global::Infragistics.Windows.Controls.ToolWindow.CoerceMinMaxValue(newValue, 0.0, toolWindow._calculatedMinWidth);
		}

		// Token: 0x06001402 RID: 5122 RVA: 0x00049F68 File Offset: 0x00048168
		private static object CoerceMinHeight(global::System.Windows.DependencyObject d, object newValue)
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = (global::Infragistics.Windows.Controls.ToolWindow)d;
			if (toolWindow._isCalculatingSizeWithoutContent)
			{
				return 0.0;
			}
			if (toolWindow.WindowState != global::System.Windows.WindowState.Normal)
			{
				return 0.0;
			}
			return global::Infragistics.Windows.Controls.ToolWindow.CoerceMinMaxValue(newValue, 0.0, toolWindow._calculatedMinHeight);
		}

		// Token: 0x06001403 RID: 5123 RVA: 0x00049FC0 File Offset: 0x000481C0
		private static object CoerceMaxWidth(global::System.Windows.DependencyObject d, object newValue)
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = (global::Infragistics.Windows.Controls.ToolWindow)d;
			if (toolWindow._isCalculatingSizeWithoutContent)
			{
				return double.PositiveInfinity;
			}
			if (toolWindow.WindowState != global::System.Windows.WindowState.Normal)
			{
				return double.PositiveInfinity;
			}
			return global::Infragistics.Windows.Controls.ToolWindow.CoerceMinMaxValue(newValue, double.PositiveInfinity, toolWindow._calculatedMaxWidth);
		}

		// Token: 0x06001404 RID: 5124 RVA: 0x0004A018 File Offset: 0x00048218
		private static object CoerceMaxHeight(global::System.Windows.DependencyObject d, object newValue)
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = (global::Infragistics.Windows.Controls.ToolWindow)d;
			if (toolWindow._isCalculatingSizeWithoutContent)
			{
				return double.PositiveInfinity;
			}
			if (toolWindow.WindowState != global::System.Windows.WindowState.Normal)
			{
				return double.PositiveInfinity;
			}
			return global::Infragistics.Windows.Controls.ToolWindow.CoerceMinMaxValue(newValue, double.PositiveInfinity, toolWindow._calculatedMaxHeight);
		}

		// Token: 0x06001405 RID: 5125 RVA: 0x0004A070 File Offset: 0x00048270
		private static object CoerceWidth(global::System.Windows.DependencyObject d, object newValue)
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = (global::Infragistics.Windows.Controls.ToolWindow)d;
			if (toolWindow.WindowState != global::System.Windows.WindowState.Normal)
			{
				return double.NaN;
			}
			double num = (double)newValue;
			if (!double.IsNaN(num) && toolWindow.Host != null && toolWindow.Host.IsWindow)
			{
				newValue = global::System.Math.Round(num, global::System.MidpointRounding.AwayFromZero);
			}
			if (!toolWindow._isCalculatingSizeWithoutContent)
			{
				return newValue;
			}
			return double.NaN;
		}

		// Token: 0x06001406 RID: 5126 RVA: 0x0004A0E8 File Offset: 0x000482E8
		private static object CoerceHeight(global::System.Windows.DependencyObject d, object newValue)
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = (global::Infragistics.Windows.Controls.ToolWindow)d;
			if (toolWindow.WindowState != global::System.Windows.WindowState.Normal)
			{
				return double.NaN;
			}
			double num = (double)newValue;
			if (!double.IsNaN(num) && toolWindow.Host != null && toolWindow.Host.IsWindow)
			{
				newValue = global::System.Math.Round(num, global::System.MidpointRounding.AwayFromZero);
			}
			if (!toolWindow._isCalculatingSizeWithoutContent)
			{
				return newValue;
			}
			return double.NaN;
		}

		// Token: 0x06001407 RID: 5127 RVA: 0x0004A15D File Offset: 0x0004835D
		private static object CoerceMinMaxValue(object newValue, double requiredValue, object calculatedValue)
		{
			if ((newValue == null || (double)newValue == requiredValue) && calculatedValue != null)
			{
				return calculatedValue;
			}
			return newValue;
		}

		// Token: 0x06001408 RID: 5128 RVA: 0x0004A174 File Offset: 0x00048374
		private bool ExecuteCommand(global::System.Windows.Input.ICommand command)
		{
			if (this.CanExecute(command) != true)
			{
				return false;
			}
			if (command == global::Infragistics.Windows.Controls.ToolWindow.CloseCommand)
			{
				this.Close();
			}
			else
			{
				global::System.Windows.WindowState? windowState = null;
				if (command == global::Infragistics.Windows.Controls.ToolWindow.MaximizeCommand)
				{
					windowState = new global::System.Windows.WindowState?(global::System.Windows.WindowState.Maximized);
				}
				else if (command == global::Infragistics.Windows.Controls.ToolWindow.MinimizeCommand)
				{
					windowState = new global::System.Windows.WindowState?(global::System.Windows.WindowState.Minimized);
				}
				else if (command == global::Infragistics.Windows.Controls.ToolWindow.RestoreCommand)
				{
					if (this.WindowState == global::System.Windows.WindowState.Minimized && this.RestoreToMaximized)
					{
						windowState = new global::System.Windows.WindowState?(global::System.Windows.WindowState.Maximized);
					}
					else
					{
						windowState = new global::System.Windows.WindowState?(global::System.Windows.WindowState.Normal);
					}
				}
				if (windowState != null)
				{
					if (this.Host != null)
					{
						this.Host.SetWindowState(windowState.Value);
					}
					else
					{
						this.WindowState = windowState.Value;
					}
				}
			}
			return true;
		}

		// Token: 0x06001409 RID: 5129 RVA: 0x0004A240 File Offset: 0x00048440
		private void ExecuteDialogCommand(object sender, global::System.Windows.Input.ExecutedRoutedEventArgs e)
		{
			global::System.Windows.Input.RoutedCommand routedCommand = e.Command as global::System.Windows.Input.RoutedCommand;
			if (routedCommand.OwnerType == typeof(global::System.Windows.Window) && routedCommand.Name == "DialogCancel")
			{
				this.DialogResult = new bool?(false);
				e.Handled = true;
			}
		}

		// Token: 0x0600140A RID: 5130 RVA: 0x0004A298 File Offset: 0x00048498
		private static global::Infragistics.Windows.Controls.ToolWindowAdorner GetAdorner(global::System.Windows.FrameworkElement owner, bool createIfNull)
		{
			global::System.Windows.UIElement uielement;
			global::System.Windows.Documents.AdornerLayer rootAdornerLayer = global::Infragistics.Windows.Utilities.GetRootAdornerLayer(owner, out uielement);
			if (rootAdornerLayer != null)
			{
				global::Infragistics.Windows.Controls.ToolWindowAdorner toolWindowAdorner = null;
				int i = 0;
				int childrenCount = global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(rootAdornerLayer);
				while (i < childrenCount)
				{
					toolWindowAdorner = (global::System.Windows.Media.VisualTreeHelper.GetChild(rootAdornerLayer, i) as global::Infragistics.Windows.Controls.ToolWindowAdorner);
					if (toolWindowAdorner != null)
					{
						if (toolWindowAdorner.AdornedElement == uielement)
						{
							break;
						}
						toolWindowAdorner = null;
					}
					i++;
				}
				if (createIfNull && toolWindowAdorner == null)
				{
					toolWindowAdorner = new global::Infragistics.Windows.Controls.ToolWindowAdorner(uielement);
					rootAdornerLayer.Add(toolWindowAdorner);
				}
				return toolWindowAdorner;
			}
			return null;
		}

		// Token: 0x0600140B RID: 5131 RVA: 0x0004A2FA File Offset: 0x000484FA
		private static global::System.Windows.Window GetOwningWindow(global::System.Windows.FrameworkElement owner)
		{
			if (!global::System.Windows.Interop.BrowserInteropHelper.IsBrowserHosted)
			{
				return global::System.Windows.Window.GetWindow(owner);
			}
			return null;
		}

		// Token: 0x0600140C RID: 5132 RVA: 0x0004A30C File Offset: 0x0004850C
		private static string GetPartName(global::Infragistics.Windows.Controls.ToolWindowPart part)
		{
			switch (part)
			{
			case global::Infragistics.Windows.Controls.ToolWindowPart.Caption:
				return "PART_Caption";
			case global::Infragistics.Windows.Controls.ToolWindowPart.BorderLeft:
				return "PART_BorderLeft";
			case global::Infragistics.Windows.Controls.ToolWindowPart.BorderRight:
				return "PART_BorderRight";
			case global::Infragistics.Windows.Controls.ToolWindowPart.BorderTop:
				return "PART_BorderTop";
			case global::Infragistics.Windows.Controls.ToolWindowPart.BorderBottom:
				return "PART_BorderBottom";
			case global::Infragistics.Windows.Controls.ToolWindowPart.BorderTopLeft:
				return "PART_BorderTopLeft";
			case global::Infragistics.Windows.Controls.ToolWindowPart.BorderTopRight:
				return "PART_BorderTopRight";
			case global::Infragistics.Windows.Controls.ToolWindowPart.BorderBottomLeft:
				return "PART_BorderBottomLeft";
			case global::Infragistics.Windows.Controls.ToolWindowPart.BorderBottomRight:
				return "PART_BorderBottomRight";
			case global::Infragistics.Windows.Controls.ToolWindowPart.ResizeGrip:
				return "PART_ResizeGrip";
			case global::Infragistics.Windows.Controls.ToolWindowPart.Content:
				return "PART_Content";
			default:
				return string.Empty;
			}
		}

		// Token: 0x0600140D RID: 5133 RVA: 0x0004A398 File Offset: 0x00048598
		private void InitializeBorderThicknessBindings()
		{
			if (this.IsUsingOSNonClientArea)
			{
				base.ClearValue(global::Infragistics.Windows.Controls.ToolWindow.PreferredBorderWidthProperty);
				base.ClearValue(global::Infragistics.Windows.Controls.ToolWindow.PreferredBorderHeightProperty);
				return;
			}
			bool flag = this.ResizeMode == global::System.Windows.ResizeMode.CanResize || this.ResizeMode == global::System.Windows.ResizeMode.CanResizeWithGrip;
			global::System.Windows.ResourceKey name = flag ? global::System.Windows.SystemParameters.ResizeFrameVerticalBorderWidthKey : global::System.Windows.SystemParameters.FixedFrameVerticalBorderWidthKey;
			global::System.Windows.ResourceKey name2 = flag ? global::System.Windows.SystemParameters.ResizeFrameHorizontalBorderHeightKey : global::System.Windows.SystemParameters.FixedFrameHorizontalBorderHeightKey;
			base.SetResourceReference(global::Infragistics.Windows.Controls.ToolWindow.PreferredBorderWidthProperty, name);
			base.SetResourceReference(global::Infragistics.Windows.Controls.ToolWindow.PreferredBorderHeightProperty, name2);
		}

		// Token: 0x0600140E RID: 5134 RVA: 0x0004A412 File Offset: 0x00048612
		private static void OnAllowMinMaxChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			d.CoerceValue(global::Infragistics.Windows.Controls.ToolWindow.MinimizeButtonVisibilityProperty);
			d.CoerceValue(global::Infragistics.Windows.Controls.ToolWindow.MaximizeButtonVisibilityProperty);
		}

		// Token: 0x0600140F RID: 5135 RVA: 0x0004A42C File Offset: 0x0004862C
		private static void OnCanExecuteCommand(object sender, global::System.Windows.Input.CanExecuteRoutedEventArgs e)
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = sender as global::Infragistics.Windows.Controls.ToolWindow;
			bool? flag = toolWindow.CanExecute(e.Command);
			if (flag != null)
			{
				e.CanExecute = flag.Value;
				e.Handled = true;
			}
		}

		// Token: 0x06001410 RID: 5136 RVA: 0x0004A46A File Offset: 0x0004866A
		private void OnEndShowDialog()
		{
			if (this._showingAsDialog)
			{
				this._showingAsDialog = false;
				global::System.Windows.Input.CommandManager.RemoveCanExecuteHandler(this, new global::System.Windows.Input.CanExecuteRoutedEventHandler(this.CanExecuteDialogCommand));
				global::System.Windows.Input.CommandManager.RemoveExecutedHandler(this, new global::System.Windows.Input.ExecutedRoutedEventHandler(this.ExecuteDialogCommand));
			}
		}

		// Token: 0x06001411 RID: 5137 RVA: 0x0004A4A0 File Offset: 0x000486A0
		private static void OnExecuteCommand(object sender, global::System.Windows.Input.ExecutedRoutedEventArgs e)
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = sender as global::Infragistics.Windows.Controls.ToolWindow;
			if (toolWindow.ExecuteCommand(e.Command))
			{
				e.Handled = true;
			}
		}

		// Token: 0x06001412 RID: 5138 RVA: 0x0004A4C9 File Offset: 0x000486C9
		private static void OnFlowDirectionChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.Controls.ToolWindow)d).VerifyResizeGripHitTestResult();
		}

		// Token: 0x06001413 RID: 5139 RVA: 0x0004A4D6 File Offset: 0x000486D6
		private void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this._isLoadedAfterShow = true;
		}

		// Token: 0x06001414 RID: 5140 RVA: 0x0004A4E0 File Offset: 0x000486E0
		private void OnOwnerLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this.Owner.Loaded -= this.OnOwnerLoaded;
			global::Infragistics.Windows.Controls.ToolWindow.IDeferShow deferShow = this.ShowImpl(this.Owner);
			if (deferShow != null)
			{
				deferShow.Show(this._activateOnShow);
			}
		}

		// Token: 0x06001415 RID: 5141 RVA: 0x0004A520 File Offset: 0x00048720
		private void OnOwnerUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this.Close();
		}

		// Token: 0x06001416 RID: 5142 RVA: 0x0004A528 File Offset: 0x00048728
		private void OnPartMouseLeftButtonDown(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (this.Host == null)
			{
				return;
			}
			global::System.Windows.DependencyObject dependencyObject = sender as global::System.Windows.DependencyObject;
			global::Infragistics.Windows.Controls.ToolWindowPart? toolWindowPart = (dependencyObject != null) ? this.GetToolWindowPart(dependencyObject) : null;
			if (toolWindowPart != null)
			{
				if (toolWindowPart.Value == global::Infragistics.Windows.Controls.ToolWindowPart.Caption)
				{
					if (e.ClickCount == 2)
					{
						e.Handled = this.OnDoubleClickCaption(e.GetPosition(this), e.MouseDevice);
					}
					else
					{
						if (e.ClickCount != 1)
						{
							return;
						}
						e.Handled = this.OnDragCaption(e.GetPosition(this), e.MouseDevice);
					}
					if (e.Handled)
					{
						return;
					}
					if (this.Host != null)
					{
						this.Host.DragMove(e);
						e.Handled = true;
						return;
					}
				}
				else
				{
					if (e.ClickCount != 1)
					{
						return;
					}
					global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation location = global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.Top;
					switch (toolWindowPart.Value)
					{
					case global::Infragistics.Windows.Controls.ToolWindowPart.BorderLeft:
						location = global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.Left;
						break;
					case global::Infragistics.Windows.Controls.ToolWindowPart.BorderRight:
						location = global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.Right;
						break;
					case global::Infragistics.Windows.Controls.ToolWindowPart.BorderTop:
						location = global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.Top;
						break;
					case global::Infragistics.Windows.Controls.ToolWindowPart.BorderBottom:
						location = global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.Bottom;
						break;
					case global::Infragistics.Windows.Controls.ToolWindowPart.BorderTopLeft:
						location = global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.TopLeft;
						break;
					case global::Infragistics.Windows.Controls.ToolWindowPart.BorderTopRight:
						location = global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.TopRight;
						break;
					case global::Infragistics.Windows.Controls.ToolWindowPart.BorderBottomLeft:
						location = global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.BottomLeft;
						break;
					case global::Infragistics.Windows.Controls.ToolWindowPart.BorderBottomRight:
						location = global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.BottomRight;
						break;
					case global::Infragistics.Windows.Controls.ToolWindowPart.ResizeGrip:
						location = ((base.FlowDirection == global::System.Windows.FlowDirection.LeftToRight) ? global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.BottomRight : global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.BottomLeft);
						break;
					}
					if (this.Host != null)
					{
						this.Host.DragResize(location, (global::System.Windows.Input.Cursor)dependencyObject.GetValue(global::System.Windows.FrameworkElement.CursorProperty), e);
						e.Handled = true;
					}
				}
			}
		}

		// Token: 0x06001417 RID: 5143 RVA: 0x0004A680 File Offset: 0x00048880
		private void OnPartQueryCursor(object sender, global::System.Windows.Input.QueryCursorEventArgs e)
		{
			if (this.Host == null)
			{
				return;
			}
			global::System.Windows.DependencyObject dependencyObject = sender as global::System.Windows.DependencyObject;
			global::Infragistics.Windows.Controls.ToolWindowPart? toolWindowPart = (dependencyObject != null) ? this.GetToolWindowPart(dependencyObject) : null;
			if (toolWindowPart != null)
			{
				if (toolWindowPart.Value == global::Infragistics.Windows.Controls.ToolWindowPart.Caption)
				{
					return;
				}
				e.Handled = true;
				switch (toolWindowPart.Value)
				{
				case global::Infragistics.Windows.Controls.ToolWindowPart.BorderLeft:
				case global::Infragistics.Windows.Controls.ToolWindowPart.BorderRight:
					e.Cursor = global::System.Windows.Input.Cursors.SizeWE;
					break;
				case global::Infragistics.Windows.Controls.ToolWindowPart.BorderTop:
				case global::Infragistics.Windows.Controls.ToolWindowPart.BorderBottom:
					e.Cursor = global::System.Windows.Input.Cursors.SizeNS;
					break;
				case global::Infragistics.Windows.Controls.ToolWindowPart.BorderTopLeft:
				case global::Infragistics.Windows.Controls.ToolWindowPart.BorderBottomRight:
					e.Cursor = global::System.Windows.Input.Cursors.SizeNWSE;
					break;
				case global::Infragistics.Windows.Controls.ToolWindowPart.BorderTopRight:
				case global::Infragistics.Windows.Controls.ToolWindowPart.BorderBottomLeft:
					e.Cursor = global::System.Windows.Input.Cursors.SizeNESW;
					break;
				case global::Infragistics.Windows.Controls.ToolWindowPart.ResizeGrip:
					e.Cursor = ((base.FlowDirection == global::System.Windows.FlowDirection.LeftToRight) ? global::System.Windows.Input.Cursors.SizeNWSE : global::System.Windows.Input.Cursors.SizeNESW);
					break;
				}
				e.Handled = true;
			}
		}

		// Token: 0x06001418 RID: 5144 RVA: 0x0004A75C File Offset: 0x0004895C
		private static void OnRelativePositionSettingChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = (global::Infragistics.Windows.Controls.ToolWindow)d;
			if (toolWindow.Host != null)
			{
				toolWindow.CalculateMinMaxExtents(true);
				toolWindow.Host.RelativePositionStateChanged();
			}
		}

		// Token: 0x06001419 RID: 5145 RVA: 0x0004A78A File Offset: 0x0004898A
		private void OnStartShowDialog()
		{
			this._showingAsDialog = true;
			global::System.Windows.Input.CommandManager.AddCanExecuteHandler(this, new global::System.Windows.Input.CanExecuteRoutedEventHandler(this.CanExecuteDialogCommand));
			global::System.Windows.Input.CommandManager.AddExecutedHandler(this, new global::System.Windows.Input.ExecutedRoutedEventHandler(this.ExecuteDialogCommand));
		}

		// Token: 0x0600141A RID: 5146 RVA: 0x0004A7B8 File Offset: 0x000489B8
		private static void OnVisibilityChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = d as global::Infragistics.Windows.Controls.ToolWindow;
			if (toolWindow.Host != null && !toolWindow.IsModal && toolWindow.Host.IsWindow && !global::System.Windows.Visibility.Collapsed.Equals(e.NewValue) && toolWindow.IsUsingOSNonClientArea != toolWindow.Host.IsUsingOsNonClientArea)
			{
				toolWindow.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::Infragistics.Windows.Controls.ToolWindow.MethodInvoker(toolWindow.ReshowIfVisible));
			}
		}

		// Token: 0x0600141B RID: 5147 RVA: 0x0004A82C File Offset: 0x00048A2C
		private void PrepareForShow(global::System.Windows.FrameworkElement owner, bool modal)
		{
			if (global::System.Windows.Media.VisualTreeHelper.GetParent(this) != null)
			{
				throw new global::System.InvalidOperationException(global::SR.GetString("LE_ElementHasVisualParent", new object[]
				{
					owner
				}));
			}
			if (owner == null)
			{
				throw new global::System.ArgumentNullException("owner");
			}
			if (this._showingAsDialog)
			{
				throw new global::System.InvalidOperationException(global::SR.GetString("LE_CannotShowOnDialog"));
			}
			if (modal)
			{
				if (!owner.IsLoaded)
				{
					throw new global::System.InvalidOperationException(global::SR.GetString("LE_DialogOwnerNotLoaded"));
				}
				if (!this.SupportsShowDialog)
				{
					throw new global::System.NotSupportedException(global::SR.GetString("LE_ShowDialogNotSupported"));
				}
			}
			this._dialogResult = null;
			if (!modal)
			{
				global::System.Windows.FrameworkElement owner2 = this.Owner;
				if (owner2 != null)
				{
					if (owner2 != owner)
					{
						throw new global::System.InvalidOperationException(global::SR.GetString("LE_ToolWindowHasOwner"));
					}
					return;
				}
			}
			base.SetValue(global::Infragistics.Windows.Controls.ToolWindow.OwnerPropertyKey, owner);
			this._isLoadedAfterShow = false;
		}

		// Token: 0x0600141C RID: 5148 RVA: 0x0004A8F8 File Offset: 0x00048AF8
		private global::Infragistics.Windows.Controls.ToolWindowHostWindow PrepareShowInHostWindow(global::System.Windows.Window owningWindow)
		{
			global::Infragistics.Windows.Controls.ToolWindowHostWindow toolWindowHostWindow = new global::Infragistics.Windows.Controls.ToolWindowHostWindow();
			toolWindowHostWindow.Content = this;
			if (this.IsOwnedWindow)
			{
				this.SetWindowOwner(toolWindowHostWindow, owningWindow);
			}
			switch (this.WindowStartupLocation)
			{
			case global::Infragistics.Windows.Controls.ToolWindowStartupLocation.Manual:
				toolWindowHostWindow.WindowStartupLocation = global::System.Windows.WindowStartupLocation.Manual;
				break;
			case global::Infragistics.Windows.Controls.ToolWindowStartupLocation.CenterScreen:
				toolWindowHostWindow.WindowStartupLocation = global::System.Windows.WindowStartupLocation.CenterScreen;
				break;
			case global::Infragistics.Windows.Controls.ToolWindowStartupLocation.CenterOwnerWindow:
				toolWindowHostWindow.WindowStartupLocation = global::System.Windows.WindowStartupLocation.CenterOwner;
				break;
			}
			if (!base.IsMeasureValid)
			{
				this.CalculateMinMaxExtents(true);
			}
			global::Infragistics.Windows.Utilities.EnableModelessKeyboardInteropForWindow(toolWindowHostWindow);
			this.OnWindowShowing(global::System.EventArgs.Empty);
			return toolWindowHostWindow;
		}

		// Token: 0x0600141D RID: 5149 RVA: 0x0004A978 File Offset: 0x00048B78
		private void Reshow()
		{
			if (this.Host == null)
			{
				return;
			}
			if (this._deferredShowInfo != null)
			{
				return;
			}
			if (this.IsModal)
			{
				throw new global::System.InvalidOperationException(global::SR.GetString("LE_CannotChangeModalToolWindowTransparency"));
			}
			if (this._isReshowing)
			{
				throw new global::System.InvalidOperationException(global::SR.GetString("LE_ToolWindowIsReshowing"));
			}
			bool isActive = this.IsActive;
			global::System.Windows.FrameworkElement owner = this.Owner;
			bool preferPopup = this._preferPopup;
			this._isReshowing = true;
			try
			{
				this.Close();
				this.Show(owner, isActive, preferPopup);
			}
			finally
			{
				this._isReshowing = false;
			}
		}

		// Token: 0x0600141E RID: 5150 RVA: 0x0004AA0C File Offset: 0x00048C0C
		private void ReshowIfVisible()
		{
			if (this.Host != null && base.IsVisible && this.IsUsingOSNonClientArea != this.Host.IsUsingOsNonClientArea)
			{
				this.Reshow();
			}
		}

		// Token: 0x0600141F RID: 5151 RVA: 0x0004AA38 File Offset: 0x00048C38
		private void SetWindowOwner(global::System.Windows.Window toolWindow, global::System.Windows.Window owningWindow)
		{
			toolWindow.Owner = owningWindow;
			if (owningWindow == null)
			{
				global::System.IntPtr ownerHwnd = global::Infragistics.Windows.Controls.ToolWindow.GetOwnerHwnd(this.Owner);
				if (global::System.IntPtr.Zero != ownerHwnd)
				{
					new global::System.Windows.Interop.WindowInteropHelper(toolWindow).Owner = ownerHwnd;
				}
			}
		}

		// Token: 0x06001420 RID: 5152 RVA: 0x0004AA84 File Offset: 0x00048C84
		private bool ShowContextMenu(object originalSource, global::System.Windows.Point location, bool showDefaultOnly)
		{
			if (this.WindowState == global::System.Windows.WindowState.Minimized && this.Host != null && this.Host.IsWindow)
			{
				return false;
			}
			if (base.ReadLocalValue(global::System.Windows.FrameworkElement.ContextMenuProperty) == null)
			{
				return !showDefaultOnly;
			}
			global::System.Windows.Controls.ContextMenu contextMenu = base.ContextMenu;
			if (contextMenu != null && showDefaultOnly)
			{
				return false;
			}
			if (contextMenu == null)
			{
				contextMenu = this.CreateDefaultContextMenu(originalSource);
				if (contextMenu == null)
				{
					return false;
				}
			}
			if (contextMenu.Items.Count == 0)
			{
				return true;
			}
			contextMenu.PlacementTarget = this;
			if (location.X == -1.0 && location.Y == -1.0)
			{
				contextMenu.Placement = global::System.Windows.Controls.Primitives.PlacementMode.Center;
			}
			else
			{
				global::System.Windows.Point point = default(global::System.Windows.Point);
				global::System.Windows.DependencyObject dependencyObject = originalSource as global::System.Windows.DependencyObject;
				while (dependencyObject is global::System.Windows.ContentElement)
				{
					dependencyObject = global::System.Windows.LogicalTreeHelper.GetParent(dependencyObject);
				}
				if (dependencyObject is global::System.Windows.UIElement)
				{
					point = base.TranslatePoint(point, (global::System.Windows.UIElement)dependencyObject);
				}
				contextMenu.Placement = global::System.Windows.Controls.Primitives.PlacementMode.RelativePoint;
				contextMenu.HorizontalOffset = location.X - point.X;
				contextMenu.VerticalOffset = location.Y - point.Y;
			}
			contextMenu.Unloaded += delegate(object sender, global::System.Windows.RoutedEventArgs e)
			{
				((global::System.Windows.Controls.ContextMenu)sender).PlacementTarget = null;
			};
			contextMenu.IsOpen = true;
			return true;
		}

		// Token: 0x06001421 RID: 5153 RVA: 0x0004ABBC File Offset: 0x00048DBC
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private void ShowModalToolWindowHostWindow(global::System.Windows.Window owningWindow, global::Infragistics.Windows.Controls.ToolWindow.ShowDialogCallback callback)
		{
			global::Infragistics.Windows.Controls.ToolWindowHostWindow toolWindowHostWindow = this.PrepareShowInHostWindow(owningWindow);
			bool? dialogResult = toolWindowHostWindow.ShowDialog();
			if (callback != null)
			{
				callback(this, dialogResult);
			}
		}

		// Token: 0x06001422 RID: 5154 RVA: 0x0004ABE4 File Offset: 0x00048DE4
		private global::Infragistics.Windows.Controls.ToolWindow.IDeferShow ShowImpl(global::System.Windows.FrameworkElement owner)
		{
			if (owner != this.Owner || !owner.IsLoaded)
			{
				return null;
			}
			if (this._deferredShowInfo != null)
			{
				throw new global::System.InvalidOperationException("A deferred show is already in progress.");
			}
			base.CoerceValue(global::Infragistics.Windows.Controls.ToolWindow.MinimizeButtonVisibilityProperty);
			base.CoerceValue(global::Infragistics.Windows.Controls.ToolWindow.MaximizeButtonVisibilityProperty);
			if (this._preferPopup)
			{
				return global::Infragistics.Windows.Controls.ToolWindowHostPopup.Show(this);
			}
			global::System.Windows.Window owningWindow = global::Infragistics.Windows.Controls.ToolWindow.GetOwningWindow(owner);
			if (owningWindow != null || global::Infragistics.Windows.Controls.ToolWindow.GetOwnerHwnd(owner) != global::System.IntPtr.Zero)
			{
				return this.ShowInToolWindowHostWindow(owningWindow);
			}
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = global::Infragistics.Windows.Controls.ToolWindow.GetToolWindow(owner);
			if (toolWindow != null && toolWindow.Host is global::Infragistics.Windows.Controls.ToolWindowHostPopup)
			{
				this._preferPopup = true;
				return global::Infragistics.Windows.Controls.ToolWindowHostPopup.Show(this);
			}
			global::Infragistics.Windows.Controls.ToolWindowAdorner adorner = global::Infragistics.Windows.Controls.ToolWindow.GetAdorner(owner, true);
			if (adorner != null)
			{
				return adorner.AddWindow(this, owner);
			}
			return null;
		}

		// Token: 0x06001423 RID: 5155 RVA: 0x0004AC9C File Offset: 0x00048E9C
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private global::Infragistics.Windows.Controls.ToolWindow.IDeferShow ShowInToolWindowHostWindow(global::System.Windows.Window owningWindow)
		{
			global::Infragistics.Windows.Controls.ToolWindowHostWindow window = this.PrepareShowInHostWindow(owningWindow);
			return new global::Infragistics.Windows.Controls.ToolWindowHostWindow.DeferShowHelper(window);
		}

		// Token: 0x06001424 RID: 5156 RVA: 0x0004ACB8 File Offset: 0x00048EB8
		private void UpdatePreferredBorderThickness()
		{
			global::System.Windows.Thickness thickness = default(global::System.Windows.Thickness);
			if (!this.IsUsingOSNonClientArea)
			{
				thickness.Left = (thickness.Right = this.PreferredBorderWidth);
				thickness.Top = (thickness.Bottom = this.PreferredBorderHeight);
			}
			base.SetValue(global::Infragistics.Windows.Controls.ToolWindow.PreferredBorderThicknessPropertyKey, thickness);
		}

		// Token: 0x06001425 RID: 5157 RVA: 0x0004AD14 File Offset: 0x00048F14
		private void VerifyResizeGripHitTestResult()
		{
			if (this._parts == null)
			{
				return;
			}
			global::System.Windows.FrameworkElement frameworkElement = this._parts[9];
			if (frameworkElement != null)
			{
				global::Infragistics.Windows.Controls.ToolWindowPart part = (base.FlowDirection == global::System.Windows.FlowDirection.LeftToRight) ? global::Infragistics.Windows.Controls.ToolWindowPart.BorderBottomRight : global::Infragistics.Windows.Controls.ToolWindowPart.BorderBottomLeft;
				frameworkElement.SetValue(global::Infragistics.Windows.Controls.ToolWindow.HitTestCodePropertyKey, global::Infragistics.Windows.Helpers.NativeWindowMethods.GetHitTestResult(part));
			}
		}

		// Token: 0x06001426 RID: 5158 RVA: 0x0004AD5C File Offset: 0x00048F5C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		protected global::System.Windows.Size CalculateNonClientSize(global::System.Windows.Size clientSize)
		{
			if (this.IsUsingOSNonClientArea)
			{
				clientSize = this.AddToolWindowHostNonClient(clientSize);
			}
			else if (!this._sizeWithoutCaption.IsEmpty)
			{
				clientSize.Width += this._sizeWithoutCaption.Width;
				clientSize.Height += this._sizeWithoutContent.Height;
			}
			return clientSize;
		}

		// Token: 0x06001427 RID: 5159 RVA: 0x0004ADBC File Offset: 0x00048FBC
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private global::System.Windows.Size AddToolWindowHostNonClient(global::System.Windows.Size clientSize)
		{
			global::System.Windows.Size result = clientSize;
			global::Infragistics.Windows.Controls.ToolWindowHostWindow toolWindowHostWindow = this.Host as global::Infragistics.Windows.Controls.ToolWindowHostWindow;
			if (toolWindowHostWindow != null)
			{
				result = toolWindowHostWindow.AddNonClientSize(clientSize);
			}
			return result;
		}

		// Token: 0x06001428 RID: 5160 RVA: 0x0004ADE3 File Offset: 0x00048FE3
		protected virtual global::System.Windows.Controls.ContextMenu CreateDefaultContextMenu(object originalSource)
		{
			return null;
		}

		// Token: 0x06001429 RID: 5161 RVA: 0x0004ADE6 File Offset: 0x00048FE6
		protected void OnSupportsAllowsTransparencyChanged()
		{
			if (this.Host == null)
			{
				return;
			}
			if (this.AllowsTransparencyResolved == this.Host.AllowsTransparency)
			{
				return;
			}
			if (!this.Host.SupportsAllowTransparency(this.AllowsTransparencyResolved))
			{
				return;
			}
			this.Reshow();
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x0600142A RID: 5162 RVA: 0x0004AE1F File Offset: 0x0004901F
		protected virtual bool SupportsAllowsTransparency
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x0600142B RID: 5163 RVA: 0x0004AE22 File Offset: 0x00049022
		protected virtual bool SupportsShowDialog
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600142C RID: 5164 RVA: 0x0004AE25 File Offset: 0x00049025
		protected virtual void SetVisualState(bool useTransitions)
		{
			if (this.IsActive)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Active", useTransitions);
				return;
			}
			global::System.Windows.VisualStateManager.GoToState(this, "Inactive", useTransitions);
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x0004AE4C File Offset: 0x0004904C
		private static void OnVisualStatePropertyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = target as global::Infragistics.Windows.Controls.ToolWindow;
			toolWindow.UpdateVisualStates();
		}

		// Token: 0x0600142E RID: 5166 RVA: 0x0004AE66 File Offset: 0x00049066
		private void UpdateVisualStates()
		{
			this.UpdateVisualStates(true);
		}

		// Token: 0x0600142F RID: 5167 RVA: 0x0004AE6F File Offset: 0x0004906F
		private void UpdateVisualStates(bool useTransitions)
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

		// Token: 0x06001430 RID: 5168 RVA: 0x0004AE8C File Offset: 0x0004908C
		public void Activate()
		{
			if (this.Host != null)
			{
				this.Host.Activate();
			}
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x0004AEA1 File Offset: 0x000490A1
		public void BringToFront()
		{
			if (base.IsVisible && this.Owner != null && this.Host != null)
			{
				this.Host.BringToFront();
			}
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x0004AEC6 File Offset: 0x000490C6
		public void Close()
		{
			if (this._deferredShowInfo != null)
			{
				this._deferredShowInfo.Cancel();
			}
			this.CloseOverride();
		}

		// Token: 0x06001433 RID: 5171 RVA: 0x0004AEE1 File Offset: 0x000490E1
		public global::System.Windows.Rect GetRestoreBounds()
		{
			return this.GetRestoreBounds(true);
		}

		// Token: 0x06001434 RID: 5172 RVA: 0x0004AEEA File Offset: 0x000490EA
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public static global::System.Windows.Point GetScreenPoint(global::System.Windows.FrameworkElement owner, global::System.Windows.Input.MouseEventArgs e)
		{
			global::Infragistics.Windows.Utilities.ThrowIfNull(owner, "owner");
			global::Infragistics.Windows.Utilities.ThrowIfNull(e, "e");
			return global::Infragistics.Windows.Controls.ToolWindow.GetScreenPoint(owner, e.GetPosition(owner), owner);
		}

		// Token: 0x06001435 RID: 5173 RVA: 0x0004AF10 File Offset: 0x00049110
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public static global::System.Windows.Point GetScreenPoint(global::System.Windows.FrameworkElement owner, global::System.Windows.Point relativePoint, global::System.Windows.FrameworkElement relativeElement)
		{
			global::Infragistics.Windows.Utilities.ThrowIfNull(owner, "owner");
			global::System.Windows.Window owningWindow = global::Infragistics.Windows.Controls.ToolWindow.GetOwningWindow(owner);
			global::System.Windows.Point point = relativePoint;
			if (relativeElement != owner)
			{
				if (relativeElement != null)
				{
					point = global::Infragistics.Windows.Utilities.PointToScreenSafe(relativeElement, point);
				}
				point = global::Infragistics.Windows.Utilities.PointFromScreenSafe(owner, point);
			}
			if (owningWindow != null || global::Infragistics.Windows.Controls.ToolWindow.GetOwnerHwnd(owner) != global::System.IntPtr.Zero)
			{
				global::System.Windows.Point point2 = owner.PointToScreen(point);
				return global::Infragistics.Windows.Utilities.ConvertToLogicalPixels((int)point2.X, (int)point2.Y, owner);
			}
			global::System.Windows.UIElement uielement;
			global::Infragistics.Windows.Utilities.GetRootAdornerLayer(owner, out uielement);
			if (uielement != null)
			{
				global::System.Windows.Point point3 = global::Infragistics.Windows.Utilities.PointToScreenSafe(owner, point);
				return global::Infragistics.Windows.Utilities.PointFromScreenSafe(uielement, point3);
			}
			return point;
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x0004AF9C File Offset: 0x0004919C
		public static global::Infragistics.Windows.Controls.ToolWindow[] GetToolWindows(global::System.Windows.FrameworkElement owner)
		{
			int num;
			return global::Infragistics.Windows.Controls.ToolWindow.GetToolWindows(owner, out num);
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x0004AFB4 File Offset: 0x000491B4
		internal static global::Infragistics.Windows.Controls.ToolWindow[] GetToolWindows(global::System.Windows.FrameworkElement owner, out int ownerWindowIndex)
		{
			global::Infragistics.Windows.Utilities.ThrowIfNull(owner, "owner");
			global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.ToolWindow> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.ToolWindow>();
			global::System.Windows.Window owningWindow = global::Infragistics.Windows.Controls.ToolWindow.GetOwningWindow(owner);
			if (owningWindow != null || global::Infragistics.Windows.Controls.ToolWindow.GetOwnerHwnd(owner) != global::System.IntPtr.Zero)
			{
				global::Infragistics.Windows.Controls.ToolWindow.GetToolWindowHostWindows(owner, list, owningWindow, out ownerWindowIndex);
			}
			else
			{
				global::Infragistics.Windows.Controls.ToolWindowHostPopup.AddToolWindows(owner, list);
				ownerWindowIndex = list.Count;
			}
			global::Infragistics.Windows.Controls.ToolWindowAdorner adorner = global::Infragistics.Windows.Controls.ToolWindow.GetAdorner(owner, false);
			if (adorner != null)
			{
				adorner.GetToolWindows(owner, list, ref ownerWindowIndex);
			}
			return list.ToArray();
		}

		// Token: 0x06001438 RID: 5176 RVA: 0x0004B022 File Offset: 0x00049222
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private static void GetToolWindowHostWindows(global::System.Windows.FrameworkElement owner, global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.ToolWindow> windows, global::System.Windows.Window owningWindow, out int ownerWindowIndex)
		{
			global::Infragistics.Windows.Controls.ToolWindowHostWindow.GetToolWindows(owningWindow, owner, windows, out ownerWindowIndex);
		}

		// Token: 0x06001439 RID: 5177 RVA: 0x0004B02D File Offset: 0x0004922D
		public void SetRestoreBounds(global::System.Windows.Rect restoreBounds)
		{
			if (restoreBounds.IsEmpty)
			{
				throw new global::System.InvalidOperationException();
			}
			this.SetRestoreBounds(restoreBounds, true);
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x0004B046 File Offset: 0x00049246
		public void Show(global::System.Windows.FrameworkElement owner)
		{
			this.Show(owner, true);
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x0004B050 File Offset: 0x00049250
		public void Show(global::System.Windows.FrameworkElement owner, bool activate)
		{
			this.Show(owner, activate, false);
		}

		// Token: 0x0600143C RID: 5180 RVA: 0x0004B05C File Offset: 0x0004925C
		public void Show(global::System.Windows.FrameworkElement owner, bool activate, bool preferPopup)
		{
			global::System.IDisposable disposable = this.ShowAsync(owner, activate, preferPopup);
			if (disposable != null)
			{
				disposable.Dispose();
			}
		}

		// Token: 0x0600143D RID: 5181 RVA: 0x0004B07C File Offset: 0x0004927C
		internal global::System.IDisposable ShowAsync(global::System.Windows.FrameworkElement owner, bool activate, bool preferPopup)
		{
			this.PrepareForShow(owner, false);
			this._activateOnShow = activate;
			this._preferPopup = preferPopup;
			owner.Loaded -= this.OnOwnerLoaded;
			if (!owner.IsLoaded)
			{
				owner.Loaded += this.OnOwnerLoaded;
				return null;
			}
			global::Infragistics.Windows.Controls.ToolWindow.IDeferShow deferShow = this.ShowImpl(owner);
			if (deferShow == null)
			{
				return null;
			}
			this._deferredShowInfo = new global::Infragistics.Windows.Controls.ToolWindow.DeferredShowInfo(this, activate, deferShow);
			return this._deferredShowInfo;
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x0004B0F0 File Offset: 0x000492F0
		public void ShowDialog(global::System.Windows.FrameworkElement owner, global::Infragistics.Windows.Controls.ToolWindow.ShowDialogCallback callback)
		{
			this.PrepareForShow(owner, true);
			this._preferPopup = false;
			global::System.Windows.Window owningWindow = global::Infragistics.Windows.Controls.ToolWindow.GetOwningWindow(owner);
			this.OnStartShowDialog();
			if (owningWindow != null || global::Infragistics.Windows.Controls.ToolWindow.GetOwnerHwnd(owner) != global::System.IntPtr.Zero)
			{
				this.ShowModalToolWindowHostWindow(owningWindow, callback);
				return;
			}
			global::Infragistics.Windows.Controls.ToolWindowHostPopup.ShowDialog(this, callback);
		}

		// Token: 0x1400002A RID: 42
		// (add) Token: 0x0600143F RID: 5183 RVA: 0x0004B13E File Offset: 0x0004933E
		// (remove) Token: 0x06001440 RID: 5184 RVA: 0x0004B151 File Offset: 0x00049351
		public event global::System.EventHandler Activated
		{
			add
			{
				this.Events.AddHandler(global::Infragistics.Windows.Controls.ToolWindow.EventActivated, value);
			}
			remove
			{
				this.Events.RemoveHandler(global::Infragistics.Windows.Controls.ToolWindow.EventActivated, value);
			}
		}

		// Token: 0x1400002B RID: 43
		// (add) Token: 0x06001441 RID: 5185 RVA: 0x0004B164 File Offset: 0x00049364
		// (remove) Token: 0x06001442 RID: 5186 RVA: 0x0004B177 File Offset: 0x00049377
		public event global::System.EventHandler Deactivated
		{
			add
			{
				this.Events.AddHandler(global::Infragistics.Windows.Controls.ToolWindow.EventDeactivated, value);
			}
			remove
			{
				this.Events.RemoveHandler(global::Infragistics.Windows.Controls.ToolWindow.EventDeactivated, value);
			}
		}

		// Token: 0x1400002C RID: 44
		// (add) Token: 0x06001443 RID: 5187 RVA: 0x0004B18A File Offset: 0x0004938A
		// (remove) Token: 0x06001444 RID: 5188 RVA: 0x0004B19D File Offset: 0x0004939D
		public event global::System.ComponentModel.CancelEventHandler Closing
		{
			add
			{
				this.Events.AddHandler(global::Infragistics.Windows.Controls.ToolWindow.EventClosing, value);
			}
			remove
			{
				this.Events.RemoveHandler(global::Infragistics.Windows.Controls.ToolWindow.EventClosing, value);
			}
		}

		// Token: 0x1400002D RID: 45
		// (add) Token: 0x06001445 RID: 5189 RVA: 0x0004B1B0 File Offset: 0x000493B0
		// (remove) Token: 0x06001446 RID: 5190 RVA: 0x0004B1C3 File Offset: 0x000493C3
		public event global::System.EventHandler Closed
		{
			add
			{
				this.Events.AddHandler(global::Infragistics.Windows.Controls.ToolWindow.EventClosed, value);
			}
			remove
			{
				this.Events.RemoveHandler(global::Infragistics.Windows.Controls.ToolWindow.EventClosed, value);
			}
		}

		// Token: 0x1400002E RID: 46
		// (add) Token: 0x06001447 RID: 5191 RVA: 0x0004B1D6 File Offset: 0x000493D6
		// (remove) Token: 0x06001448 RID: 5192 RVA: 0x0004B1E9 File Offset: 0x000493E9
		internal event global::System.EventHandler WindowShowing
		{
			add
			{
				this.Events.AddHandler(global::Infragistics.Windows.Controls.ToolWindow.EventWindowShowing, value);
			}
			remove
			{
				this.Events.RemoveHandler(global::Infragistics.Windows.Controls.ToolWindow.EventWindowShowing, value);
			}
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x0004B1FC File Offset: 0x000493FC
		protected virtual void OnActivated(global::System.EventArgs e)
		{
			if (e == null)
			{
				throw new global::System.ArgumentNullException("e");
			}
			global::System.EventHandler eventHandler = (global::System.EventHandler)this.Events[global::Infragistics.Windows.Controls.ToolWindow.EventActivated];
			if (eventHandler != null)
			{
				eventHandler(this, e);
			}
		}

		// Token: 0x0600144A RID: 5194 RVA: 0x0004B238 File Offset: 0x00049438
		protected virtual void OnClosed(global::System.EventArgs e)
		{
			if (e == null)
			{
				throw new global::System.ArgumentNullException("e");
			}
			global::System.EventHandler eventHandler = (global::System.EventHandler)this.Events[global::Infragistics.Windows.Controls.ToolWindow.EventClosed];
			if (eventHandler != null)
			{
				eventHandler(this, e);
			}
		}

		// Token: 0x0600144B RID: 5195 RVA: 0x0004B274 File Offset: 0x00049474
		protected internal virtual void OnClosing(global::System.ComponentModel.CancelEventArgs e)
		{
			if (e == null)
			{
				throw new global::System.ArgumentNullException("e");
			}
			global::System.ComponentModel.CancelEventHandler cancelEventHandler = (global::System.ComponentModel.CancelEventHandler)this.Events[global::Infragistics.Windows.Controls.ToolWindow.EventClosing];
			if (cancelEventHandler != null)
			{
				cancelEventHandler(this, e);
			}
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x0004B2B0 File Offset: 0x000494B0
		protected virtual void OnDeactivated(global::System.EventArgs e)
		{
			if (e == null)
			{
				throw new global::System.ArgumentNullException("e");
			}
			global::System.EventHandler eventHandler = (global::System.EventHandler)this.Events[global::Infragistics.Windows.Controls.ToolWindow.EventDeactivated];
			if (eventHandler != null)
			{
				eventHandler(this, e);
			}
		}

		// Token: 0x0600144D RID: 5197 RVA: 0x0004B2EC File Offset: 0x000494EC
		internal void OnWindowShowing(global::System.EventArgs e)
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(e, "e");
			global::System.EventHandler eventHandler = (global::System.EventHandler)this.Events[global::Infragistics.Windows.Controls.ToolWindow.EventWindowShowing];
			if (eventHandler != null)
			{
				eventHandler(this, e);
			}
		}

		// Token: 0x0600144E RID: 5198 RVA: 0x0004B325 File Offset: 0x00049525
		void global::Infragistics.Windows.Helpers.IMinMaxWatcherOwner.OnMinMaxChanged(global::Infragistics.Windows.Helpers.MinMaxWatcher watcher)
		{
			this.CalculateMinMaxExtents(true);
		}

		// Token: 0x040009FD RID: 2557
		private global::System.Windows.FrameworkElement[] _parts;

		// Token: 0x040009FE RID: 2558
		private static readonly int PartCount;

		// Token: 0x040009FF RID: 2559
		private static object[] BoxedParts;

		// Token: 0x04000A00 RID: 2560
		private global::System.ComponentModel.EventHandlerList _events;

		// Token: 0x04000A01 RID: 2561
		private object _calculatedMinWidth;

		// Token: 0x04000A02 RID: 2562
		private object _calculatedMinHeight;

		// Token: 0x04000A03 RID: 2563
		private object _calculatedMaxWidth;

		// Token: 0x04000A04 RID: 2564
		private object _calculatedMaxHeight;

		// Token: 0x04000A05 RID: 2565
		private global::System.Windows.Size _sizeWithoutContent;

		// Token: 0x04000A06 RID: 2566
		private global::System.Windows.Size _sizeWithoutCaption;

		// Token: 0x04000A07 RID: 2567
		private global::Infragistics.Windows.Helpers.MinMaxWatcher _minMaxWatcher;

		// Token: 0x04000A08 RID: 2568
		private bool _isCalculatingSizeWithoutContent;

		// Token: 0x04000A09 RID: 2569
		private bool _activateOnShow = true;

		// Token: 0x04000A0A RID: 2570
		private bool _isDelayedMinMaxPending;

		// Token: 0x04000A0B RID: 2571
		private bool? _dialogResult;

		// Token: 0x04000A0C RID: 2572
		private bool _showingAsDialog;

		// Token: 0x04000A0D RID: 2573
		private bool _isLoadedAfterShow;

		// Token: 0x04000A0E RID: 2574
		private bool _preferPopup;

		// Token: 0x04000A0F RID: 2575
		private bool _isReshowing;

		// Token: 0x04000A10 RID: 2576
		private global::Infragistics.Windows.Controls.ToolWindow.DeferredShowInfo _deferredShowInfo;

		// Token: 0x04000A11 RID: 2577
		private bool _hasVisualStateGroups;

		// Token: 0x04000A12 RID: 2578
		private global::System.Windows.Rect _restoreBounds = global::System.Windows.Rect.Empty;

		// Token: 0x04000A13 RID: 2579
		private bool _restoreToMaximized;

		// Token: 0x04000A14 RID: 2580
		private global::System.Windows.WindowState _cachedWindowState;

		// Token: 0x04000A15 RID: 2581
		public static readonly global::System.Windows.DependencyProperty AllowCloseProperty = global::System.Windows.DependencyProperty.Register("AllowClose", typeof(bool), typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindow.OnAllowCloseChanged)));

		// Token: 0x04000A16 RID: 2582
		public static readonly global::System.Windows.DependencyProperty AllowMaximizeProperty = global::System.Windows.DependencyProperty.Register("AllowMaximize", typeof(bool), typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindow.OnAllowMinMaxChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.ToolWindow.CoerceAllowMaximize)));

		// Token: 0x04000A17 RID: 2583
		public static readonly global::System.Windows.DependencyProperty AllowMinimizeProperty = global::System.Windows.DependencyProperty.Register("AllowMinimize", typeof(bool), typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindow.OnAllowMinMaxChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.ToolWindow.CoerceAllowMinimize)));

		// Token: 0x04000A18 RID: 2584
		public static readonly global::System.Windows.DependencyProperty AllowsTransparencyProperty = global::System.Windows.DependencyProperty.Register("AllowsTransparency", typeof(bool), typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindow.OnAllowsTransparencyChanged)));

		// Token: 0x04000A19 RID: 2585
		private static readonly global::System.Windows.DependencyPropertyKey CaptionVisibilityPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("CaptionVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityVisibleBox));

		// Token: 0x04000A1A RID: 2586
		public static readonly global::System.Windows.DependencyProperty CaptionVisibilityProperty = global::Infragistics.Windows.Controls.ToolWindow.CaptionVisibilityPropertyKey.DependencyProperty;

		// Token: 0x04000A1B RID: 2587
		public static readonly global::System.Windows.DependencyProperty HorizontalAlignmentModeProperty = global::System.Windows.DependencyProperty.Register("HorizontalAlignmentMode", typeof(global::Infragistics.Windows.Controls.ToolWindowAlignmentMode), typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.ToolWindowAlignmentMode.Manual, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindow.OnRelativePositionSettingChanged)));

		// Token: 0x04000A1C RID: 2588
		public static readonly global::System.Windows.DependencyProperty HorizontalAlignmentOffsetProperty = global::System.Windows.DependencyProperty.Register("HorizontalAlignmentOffset", typeof(double), typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(0.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindow.OnRelativePositionSettingChanged)));

		// Token: 0x04000A1D RID: 2589
		internal static readonly global::System.Windows.DependencyPropertyKey IsActivePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsActive", typeof(bool), typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindow.OnIsActiveChanged)));

		// Token: 0x04000A1E RID: 2590
		public static readonly global::System.Windows.DependencyProperty IsActiveProperty = global::Infragistics.Windows.Controls.ToolWindow.IsActivePropertyKey.DependencyProperty;

		// Token: 0x04000A1F RID: 2591
		public static readonly global::System.Windows.DependencyProperty IsOwnedWindowProperty = global::System.Windows.DependencyProperty.Register("IsOwnedWindow", typeof(bool), typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindow.OnIsOwnedWindowChanged)));

		// Token: 0x04000A20 RID: 2592
		private static readonly global::System.Windows.DependencyPropertyKey IsUsingOSNonClientAreaPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsUsingOSNonClientArea", typeof(bool), typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindow.OnIsUsingOSNonClientAreaChanged)));

		// Token: 0x04000A21 RID: 2593
		public static readonly global::System.Windows.DependencyProperty IsUsingOSNonClientAreaProperty = global::Infragistics.Windows.Controls.ToolWindow.IsUsingOSNonClientAreaPropertyKey.DependencyProperty;

		// Token: 0x04000A22 RID: 2594
		public static readonly global::System.Windows.DependencyProperty LeftProperty = global::System.Windows.Window.LeftProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.ToolWindow));

		// Token: 0x04000A23 RID: 2595
		public static readonly global::System.Windows.DependencyProperty MaximizeButtonVisibilityProperty = global::System.Windows.DependencyProperty.Register("MaximizeButtonVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityVisibleBox, null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.ToolWindow.CoerceMinMaxButtonVisibility)));

		// Token: 0x04000A24 RID: 2596
		public static readonly global::System.Windows.DependencyProperty MinimizeButtonVisibilityProperty = global::System.Windows.DependencyProperty.Register("MinimizeButtonVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityVisibleBox, null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.ToolWindow.CoerceMinMaxButtonVisibility)));

		// Token: 0x04000A25 RID: 2597
		private static readonly global::System.Windows.DependencyPropertyKey OwnerPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Owner", typeof(global::System.Windows.FrameworkElement), typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindow.OnOwnerChanged)));

		// Token: 0x04000A26 RID: 2598
		public static readonly global::System.Windows.DependencyProperty OwnerProperty = global::Infragistics.Windows.Controls.ToolWindow.OwnerPropertyKey.DependencyProperty;

		// Token: 0x04000A27 RID: 2599
		public static readonly global::System.Windows.DependencyProperty ResizeModeProperty = global::System.Windows.DependencyProperty.Register("ResizeMode", typeof(global::System.Windows.ResizeMode), typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.ResizeMode.CanResize, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindow.OnResizeModeChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.ToolWindow.CoerceResizeMode)));

		// Token: 0x04000A28 RID: 2600
		public static readonly global::System.Windows.DependencyProperty ShowInTaskbarProperty = global::System.Windows.DependencyProperty.Register("ShowInTaskbar", typeof(bool), typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000A29 RID: 2601
		private static readonly global::System.Windows.DependencyPropertyKey PreferredBorderThicknessPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("PreferredBorderThickness", typeof(global::System.Windows.Thickness), typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(default(global::System.Windows.Thickness)));

		// Token: 0x04000A2A RID: 2602
		public static readonly global::System.Windows.DependencyProperty PreferredBorderThicknessProperty = global::Infragistics.Windows.Controls.ToolWindow.PreferredBorderThicknessPropertyKey.DependencyProperty;

		// Token: 0x04000A2B RID: 2603
		public static readonly global::System.Windows.DependencyProperty ThemeProperty = global::Infragistics.Windows.Themes.ThemeManager.ThemeProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindow.OnThemeChanged)));

		// Token: 0x04000A2D RID: 2605
		public static readonly global::System.Windows.DependencyProperty TitleProperty;

		// Token: 0x04000A2E RID: 2606
		public static readonly global::System.Windows.DependencyProperty TopProperty;

		// Token: 0x04000A2F RID: 2607
		public static readonly global::System.Windows.DependencyProperty TopmostProperty;

		// Token: 0x04000A30 RID: 2608
		public static readonly global::System.Windows.DependencyProperty UseOSNonClientAreaProperty;

		// Token: 0x04000A31 RID: 2609
		public static readonly global::System.Windows.DependencyProperty VerticalAlignmentModeProperty;

		// Token: 0x04000A32 RID: 2610
		public static readonly global::System.Windows.DependencyProperty VerticalAlignmentOffsetProperty;

		// Token: 0x04000A33 RID: 2611
		public static readonly global::System.Windows.DependencyProperty WindowStartupLocationProperty;

		// Token: 0x04000A34 RID: 2612
		public static readonly global::System.Windows.DependencyProperty WindowStateProperty;

		// Token: 0x04000A35 RID: 2613
		private static readonly global::System.Windows.DependencyPropertyKey HitTestCodePropertyKey;

		// Token: 0x04000A36 RID: 2614
		internal static readonly global::System.Windows.DependencyProperty HitTestCodeProperty;

		// Token: 0x04000A37 RID: 2615
		internal static readonly global::System.Windows.DependencyProperty HostProperty;

		// Token: 0x04000A38 RID: 2616
		private static readonly global::System.Windows.DependencyPropertyKey ToolWindowPropertyKey;

		// Token: 0x04000A39 RID: 2617
		public static readonly global::System.Windows.DependencyProperty ToolWindowProperty;

		// Token: 0x04000A3A RID: 2618
		private static readonly global::System.Windows.DependencyProperty PreferredBorderWidthProperty;

		// Token: 0x04000A3B RID: 2619
		private static readonly global::System.Windows.DependencyProperty PreferredBorderHeightProperty;

		// Token: 0x04000A3C RID: 2620
		private static readonly global::System.Windows.DependencyProperty ToolWindowPartProperty;

		// Token: 0x04000A3D RID: 2621
		private static bool _getOwnerHwndFailed;

		// Token: 0x04000A3E RID: 2622
		public static readonly global::System.Windows.Input.RoutedCommand CloseCommand;

		// Token: 0x04000A3F RID: 2623
		public static readonly global::System.Windows.Input.RoutedCommand MinimizeCommand;

		// Token: 0x04000A40 RID: 2624
		public static readonly global::System.Windows.Input.RoutedCommand MaximizeCommand;

		// Token: 0x04000A41 RID: 2625
		public static readonly global::System.Windows.Input.RoutedCommand RestoreCommand;

		// Token: 0x04000A42 RID: 2626
		private static readonly object EventActivated;

		// Token: 0x04000A43 RID: 2627
		private static readonly object EventDeactivated;

		// Token: 0x04000A44 RID: 2628
		private static readonly object EventClosing;

		// Token: 0x04000A45 RID: 2629
		private static readonly object EventClosed;

		// Token: 0x04000A46 RID: 2630
		private static readonly object EventWindowShowing;

		// Token: 0x02000204 RID: 516
		// (Invoke) Token: 0x06001451 RID: 5201
		internal delegate void MethodInvoker();

		// Token: 0x02000205 RID: 517
		// (Invoke) Token: 0x06001455 RID: 5205
		public delegate void ShowDialogCallback(global::Infragistics.Windows.Controls.ToolWindow window, bool? dialogResult);

		// Token: 0x02000206 RID: 518
		private class DeferredShowInfo : global::System.IDisposable
		{
			// Token: 0x06001458 RID: 5208 RVA: 0x0004B32E File Offset: 0x0004952E
			internal DeferredShowInfo(global::Infragistics.Windows.Controls.ToolWindow toolWindow, bool activate, global::Infragistics.Windows.Controls.ToolWindow.IDeferShow deferShow)
			{
				global::Infragistics.CoreUtilities.ValidateNotNull(toolWindow, "toolWindow");
				global::Infragistics.CoreUtilities.ValidateNotNull(deferShow, "deferShow");
				this._toolWindow = toolWindow;
				this._activate = activate;
				this._deferShow = deferShow;
			}

			// Token: 0x170004A3 RID: 1187
			// (get) Token: 0x06001459 RID: 5209 RVA: 0x0004B361 File Offset: 0x00049561
			internal bool IsCancelled
			{
				get
				{
					return this._result != null && !this._result.Value;
				}
			}

			// Token: 0x0600145A RID: 5210 RVA: 0x0004B380 File Offset: 0x00049580
			internal void Cancel()
			{
				this.ProcessShow(true);
			}

			// Token: 0x0600145B RID: 5211 RVA: 0x0004B389 File Offset: 0x00049589
			internal void Show()
			{
				this.ProcessShow(false);
			}

			// Token: 0x0600145C RID: 5212 RVA: 0x0004B394 File Offset: 0x00049594
			private void ProcessShow(bool cancel)
			{
				if (this._result != null)
				{
					return;
				}
				this._result = new bool?(cancel);
				if (cancel)
				{
					this._deferShow.Cancel();
				}
				else
				{
					this._deferShow.Show(this._activate);
				}
				this._toolWindow._deferredShowInfo = null;
			}

			// Token: 0x0600145D RID: 5213 RVA: 0x0004B3E8 File Offset: 0x000495E8
			void global::System.IDisposable.Dispose()
			{
				this.ProcessShow(false);
			}

			// Token: 0x04000A49 RID: 2633
			private bool _activate;

			// Token: 0x04000A4A RID: 2634
			private bool? _result;

			// Token: 0x04000A4B RID: 2635
			private global::Infragistics.Windows.Controls.ToolWindow _toolWindow;

			// Token: 0x04000A4C RID: 2636
			private global::Infragistics.Windows.Controls.ToolWindow.IDeferShow _deferShow;
		}

		// Token: 0x02000207 RID: 519
		internal interface IDeferShow
		{
			// Token: 0x0600145E RID: 5214
			void Show(bool activate);

			// Token: 0x0600145F RID: 5215
			void Cancel();
		}
	}
}
