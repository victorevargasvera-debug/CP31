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
	// Token: 0x02000233 RID: 563
	[global::System.Windows.TemplatePart(Name = "PART_BorderBottomRight", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplatePart(Name = "PART_BorderRight", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplatePart(Name = "PART_ResizeGrip", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplatePart(Name = "PART_Content", Type = typeof(global::System.Windows.Controls.ContentPresenter))]
	[global::System.Windows.TemplateVisualState(Name = "Inactive", GroupName = "ActiveStates")]
	[global::System.Windows.TemplatePart(Name = "PART_BorderBottom", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplatePart(Name = "PART_BorderLeft", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplatePart(Name = "PART_BorderTopLeft", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplatePart(Name = "PART_BorderBottomLeft", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplatePart(Name = "PART_BorderTop", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplatePart(Name = "PART_BorderTopRight", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplateVisualState(Name = "Active", GroupName = "ActiveStates")]
	[global::System.Windows.TemplatePart(Name = "PART_Caption", Type = typeof(global::System.Windows.FrameworkElement))]
	public class ToolWindow : global::System.Windows.Controls.ContentControl, global::Infragistics.Windows.Helpers.IMinMaxWatcherOwner
	{
		// Token: 0x0600155A RID: 5466 RVA: 0x0004DA60 File Offset: 0x0004BC60
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
			global::Infragistics.Windows.Controls.ToolWindow.RequiredPopupHeightProperty = global::Infragistics.DependencyPropertyUtilities.Register("RequiredPopupHeight", typeof(double), typeof(global::Infragistics.Windows.Controls.ToolWindow), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(double.NaN));
			global::Infragistics.Windows.Controls.ToolWindow.RequiredPopupWidthProperty = global::Infragistics.DependencyPropertyUtilities.Register("RequiredPopupWidth", typeof(double), typeof(global::Infragistics.Windows.Controls.ToolWindow), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(double.NaN));
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

		// Token: 0x0600155B RID: 5467 RVA: 0x0004E5DC File Offset: 0x0004C7DC
		public ToolWindow()
		{
			this._cachedWindowState = (global::System.Windows.WindowState)base.GetValue(global::Infragistics.Windows.Controls.ToolWindow.WindowStateProperty);
			base.SetValue(global::Infragistics.Windows.Controls.ToolWindow.ToolWindowPropertyKey, this);
			base.Loaded += this.OnLoaded;
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x0004E638 File Offset: 0x0004C838
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
			if (!this._isInCalculatingSizeWithoutContent)
			{
				this.CalculateMinMaxExtents(true);
			}
			this.VerifyResizeGripHitTestResult();
			this._hasVisualStateGroups = global::Infragistics.VisualStateUtilities.GetHasVisualStateGroups(this);
			this.UpdateVisualStates(false);
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x0004E778 File Offset: 0x0004C978
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

		// Token: 0x0600155E RID: 5470 RVA: 0x0004E7C4 File Offset: 0x0004C9C4
		protected sealed override void OnContextMenuOpening(global::System.Windows.Controls.ContextMenuEventArgs e)
		{
			base.OnContextMenuOpening(e);
			if (this.ShowContextMenu(e.OriginalSource, new global::System.Windows.Point(e.CursorLeft, e.CursorTop), true))
			{
				e.Handled = true;
			}
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x0004E7F4 File Offset: 0x0004C9F4
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.ToolWindowAutomationPeer(this);
		}

		// Token: 0x06001560 RID: 5472 RVA: 0x0004E7FC File Offset: 0x0004C9FC
		protected override void OnInitialized(global::System.EventArgs e)
		{
			base.OnInitialized(e);
			this.InitializeBorderThicknessBindings();
		}

		// Token: 0x06001561 RID: 5473 RVA: 0x0004E80B File Offset: 0x0004CA0B
		protected override void OnPreviewMouseDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (this.Host != null)
			{
				this.Host.Activate();
			}
			base.OnPreviewMouseDown(e);
		}

		// Token: 0x06001562 RID: 5474 RVA: 0x0004E827 File Offset: 0x0004CA27
		public override string ToString()
		{
			return string.Format("{0} Content: {1}", base.GetType().Name, base.Content);
		}

		// Token: 0x06001563 RID: 5475 RVA: 0x0004E844 File Offset: 0x0004CA44
		private static void OnAllowCloseChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Input.CommandManager.InvalidateRequerySuggested();
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06001564 RID: 5476 RVA: 0x0004E84B File Offset: 0x0004CA4B
		// (set) Token: 0x06001565 RID: 5477 RVA: 0x0004E85D File Offset: 0x0004CA5D
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

		// Token: 0x06001566 RID: 5478 RVA: 0x0004E870 File Offset: 0x0004CA70
		private static object CoerceAllowMaximize(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = d as global::Infragistics.Windows.Controls.ToolWindow;
			if (toolWindow.ResizeMode == global::System.Windows.ResizeMode.NoResize)
			{
				return global::Infragistics.KnownBoxes.FalseBox;
			}
			return baseValue;
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06001567 RID: 5479 RVA: 0x0004E893 File Offset: 0x0004CA93
		// (set) Token: 0x06001568 RID: 5480 RVA: 0x0004E8A5 File Offset: 0x0004CAA5
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

		// Token: 0x06001569 RID: 5481 RVA: 0x0004E8B8 File Offset: 0x0004CAB8
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

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x0600156A RID: 5482 RVA: 0x0004E8F0 File Offset: 0x0004CAF0
		// (set) Token: 0x0600156B RID: 5483 RVA: 0x0004E902 File Offset: 0x0004CB02
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

		// Token: 0x0600156C RID: 5484 RVA: 0x0004E915 File Offset: 0x0004CB15
		private static void OnAllowsTransparencyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.Controls.ToolWindow)d).OnSupportsAllowsTransparencyChanged();
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x0600156D RID: 5485 RVA: 0x0004E922 File Offset: 0x0004CB22
		// (set) Token: 0x0600156E RID: 5486 RVA: 0x0004E934 File Offset: 0x0004CB34
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

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x0600156F RID: 5487 RVA: 0x0004E947 File Offset: 0x0004CB47
		// (set) Token: 0x06001570 RID: 5488 RVA: 0x0004E959 File Offset: 0x0004CB59
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
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

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06001571 RID: 5489 RVA: 0x0004E96C File Offset: 0x0004CB6C
		// (set) Token: 0x06001572 RID: 5490 RVA: 0x0004E97C File Offset: 0x0004CB7C
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

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06001573 RID: 5491 RVA: 0x0004E9E5 File Offset: 0x0004CBE5
		// (set) Token: 0x06001574 RID: 5492 RVA: 0x0004E9F7 File Offset: 0x0004CBF7
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

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06001575 RID: 5493 RVA: 0x0004EA0A File Offset: 0x0004CC0A
		// (set) Token: 0x06001576 RID: 5494 RVA: 0x0004EA1C File Offset: 0x0004CC1C
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

		// Token: 0x06001577 RID: 5495 RVA: 0x0004EA30 File Offset: 0x0004CC30
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

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06001578 RID: 5496 RVA: 0x0004EA75 File Offset: 0x0004CC75
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsActive
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.ToolWindow.IsActiveProperty);
			}
		}

		// Token: 0x06001579 RID: 5497 RVA: 0x0004EA88 File Offset: 0x0004CC88
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

		// Token: 0x0600157A RID: 5498 RVA: 0x0004EAD4 File Offset: 0x0004CCD4
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

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x0600157B RID: 5499 RVA: 0x0004EB2D File Offset: 0x0004CD2D
		// (set) Token: 0x0600157C RID: 5500 RVA: 0x0004EB3F File Offset: 0x0004CD3F
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

		// Token: 0x0600157D RID: 5501 RVA: 0x0004EB54 File Offset: 0x0004CD54
		private static void OnIsUsingOSNonClientAreaChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = d as global::Infragistics.Windows.Controls.ToolWindow;
			toolWindow.InitializeBorderThicknessBindings();
			if (toolWindow.Host != null && !toolWindow.IsModal && toolWindow.Host.IsWindow && toolWindow.IsVisible)
			{
				toolWindow.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::Infragistics.Windows.Controls.ToolWindow.MethodInvoker(toolWindow.ReshowIfVisible));
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x0600157E RID: 5502 RVA: 0x0004EBAD File Offset: 0x0004CDAD
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsUsingOSNonClientArea
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.ToolWindow.IsUsingOSNonClientAreaProperty);
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x0600157F RID: 5503 RVA: 0x0004EBBF File Offset: 0x0004CDBF
		// (set) Token: 0x06001580 RID: 5504 RVA: 0x0004EBD1 File Offset: 0x0004CDD1
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

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06001581 RID: 5505 RVA: 0x0004EBE4 File Offset: 0x0004CDE4
		// (set) Token: 0x06001582 RID: 5506 RVA: 0x0004EBF6 File Offset: 0x0004CDF6
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

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06001583 RID: 5507 RVA: 0x0004EC09 File Offset: 0x0004CE09
		// (set) Token: 0x06001584 RID: 5508 RVA: 0x0004EC1B File Offset: 0x0004CE1B
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

		// Token: 0x06001585 RID: 5509 RVA: 0x0004EC30 File Offset: 0x0004CE30
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

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06001586 RID: 5510 RVA: 0x0004EC9A File Offset: 0x0004CE9A
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::System.Windows.FrameworkElement Owner
		{
			get
			{
				return (global::System.Windows.FrameworkElement)base.GetValue(global::Infragistics.Windows.Controls.ToolWindow.OwnerProperty);
			}
		}

		// Token: 0x06001587 RID: 5511 RVA: 0x0004ECAC File Offset: 0x0004CEAC
		private static void OnResizeModeChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.Controls.ToolWindow)d).InitializeBorderThicknessBindings();
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x0004ECBC File Offset: 0x0004CEBC
		private static object CoerceResizeMode(global::System.Windows.DependencyObject d, object newValue)
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = (global::Infragistics.Windows.Controls.ToolWindow)d;
			if (toolWindow._isCalculatingSizeWithoutContent && (global::System.Windows.ResizeMode)newValue == global::System.Windows.ResizeMode.CanResizeWithGrip)
			{
				return global::System.Windows.ResizeMode.CanResize;
			}
			return newValue;
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06001589 RID: 5513 RVA: 0x0004ECE9 File Offset: 0x0004CEE9
		// (set) Token: 0x0600158A RID: 5514 RVA: 0x0004ECFB File Offset: 0x0004CEFB
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

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x0600158B RID: 5515 RVA: 0x0004ED0E File Offset: 0x0004CF0E
		// (set) Token: 0x0600158C RID: 5516 RVA: 0x0004ED20 File Offset: 0x0004CF20
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

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x0600158D RID: 5517 RVA: 0x0004ED33 File Offset: 0x0004CF33
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Thickness PreferredBorderThickness
		{
			get
			{
				return (global::System.Windows.Thickness)base.GetValue(global::Infragistics.Windows.Controls.ToolWindow.PreferredBorderThicknessProperty);
			}
		}

		// Token: 0x0600158E RID: 5518 RVA: 0x0004ED48 File Offset: 0x0004CF48
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

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x0600158F RID: 5519 RVA: 0x0004ED8E File Offset: 0x0004CF8E
		// (set) Token: 0x06001590 RID: 5520 RVA: 0x0004EDA0 File Offset: 0x0004CFA0
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Themes.ThemeTypeConverter))]
		[global::System.ComponentModel.DefaultValue(null)]
		[global::System.ComponentModel.Bindable(true)]
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

		// Token: 0x06001591 RID: 5521 RVA: 0x0004EDB0 File Offset: 0x0004CFB0
		protected virtual void OnThemeChanged(string previousValue, string currentValue)
		{
			base.RaiseEvent(new global::System.Windows.RoutedPropertyChangedEventArgs<string>(previousValue, currentValue)
			{
				RoutedEvent = global::Infragistics.Windows.Controls.ToolWindow.ThemeChangedEvent,
				Source = this
			});
		}

		// Token: 0x1400002B RID: 43
		// (add) Token: 0x06001592 RID: 5522 RVA: 0x0004EDDE File Offset: 0x0004CFDE
		// (remove) Token: 0x06001593 RID: 5523 RVA: 0x0004EDEC File Offset: 0x0004CFEC
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

		// Token: 0x06001594 RID: 5524 RVA: 0x0004EDFC File Offset: 0x0004CFFC
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

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06001595 RID: 5525 RVA: 0x0004EE29 File Offset: 0x0004D029
		// (set) Token: 0x06001596 RID: 5526 RVA: 0x0004EE3B File Offset: 0x0004D03B
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

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06001597 RID: 5527 RVA: 0x0004EE49 File Offset: 0x0004D049
		// (set) Token: 0x06001598 RID: 5528 RVA: 0x0004EE5B File Offset: 0x0004D05B
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.LengthConverter))]
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

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06001599 RID: 5529 RVA: 0x0004EE6E File Offset: 0x0004D06E
		// (set) Token: 0x0600159A RID: 5530 RVA: 0x0004EE80 File Offset: 0x0004D080
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

		// Token: 0x0600159B RID: 5531 RVA: 0x0004EE93 File Offset: 0x0004D093
		private static void OnUseOSNonClientAreaChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.Controls.ToolWindow)d).VerifyIsUsingOSNonClientArea();
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x0600159C RID: 5532 RVA: 0x0004EEA0 File Offset: 0x0004D0A0
		// (set) Token: 0x0600159D RID: 5533 RVA: 0x0004EEB2 File Offset: 0x0004D0B2
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

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x0600159E RID: 5534 RVA: 0x0004EEC5 File Offset: 0x0004D0C5
		// (set) Token: 0x0600159F RID: 5535 RVA: 0x0004EED7 File Offset: 0x0004D0D7
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

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x060015A0 RID: 5536 RVA: 0x0004EEEA File Offset: 0x0004D0EA
		// (set) Token: 0x060015A1 RID: 5537 RVA: 0x0004EEFC File Offset: 0x0004D0FC
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

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x060015A2 RID: 5538 RVA: 0x0004EF0F File Offset: 0x0004D10F
		// (set) Token: 0x060015A3 RID: 5539 RVA: 0x0004EF21 File Offset: 0x0004D121
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

		// Token: 0x060015A4 RID: 5540 RVA: 0x0004EF34 File Offset: 0x0004D134
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
			toolWindow.OnWindowStateChanged();
		}

		// Token: 0x060015A5 RID: 5541 RVA: 0x0004EFA2 File Offset: 0x0004D1A2
		internal virtual void OnWindowStateChanged()
		{
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x060015A6 RID: 5542 RVA: 0x0004EFA4 File Offset: 0x0004D1A4
		// (set) Token: 0x060015A7 RID: 5543 RVA: 0x0004EFAC File Offset: 0x0004D1AC
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

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x060015A8 RID: 5544 RVA: 0x0004EFBF File Offset: 0x0004D1BF
		internal bool AllowsTransparencyResolved
		{
			get
			{
				return this.SupportsAllowsTransparency && this.AllowsTransparency;
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x060015A9 RID: 5545 RVA: 0x0004EFD1 File Offset: 0x0004D1D1
		internal global::System.Windows.FrameworkElement CaptionElement
		{
			get
			{
				return base.GetTemplateChild("PART_Caption") as global::System.Windows.FrameworkElement;
			}
		}

		// Token: 0x060015AA RID: 5546 RVA: 0x0004EFE4 File Offset: 0x0004D1E4
		internal void EnsureOnScreen(bool fullyInView)
		{
			global::Infragistics.Windows.Controls.IToolWindowHost host = this.Host;
			if (host == null)
			{
				return;
			}
			host.EnsureOnScreen(fullyInView);
		}

		// Token: 0x060015AB RID: 5547 RVA: 0x0004F003 File Offset: 0x0004D203
		internal static global::Infragistics.Windows.Helpers.NativeWindowMethods.HitTestResults GetHitTestCode(global::System.Windows.DependencyObject d)
		{
			return (global::Infragistics.Windows.Helpers.NativeWindowMethods.HitTestResults)d.GetValue(global::Infragistics.Windows.Controls.ToolWindow.HitTestCodeProperty);
		}

		// Token: 0x060015AC RID: 5548 RVA: 0x0004F018 File Offset: 0x0004D218
		private static void OnHostChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = d as global::Infragistics.Windows.Controls.ToolWindow;
			toolWindow.VerifyIsUsingOSNonClientArea();
			toolWindow.CoerceValue(global::System.Windows.FrameworkElement.MinWidthProperty);
			toolWindow.CoerceValue(global::System.Windows.FrameworkElement.MinHeightProperty);
			toolWindow.CoerceValue(global::System.Windows.FrameworkElement.WidthProperty);
			toolWindow.CoerceValue(global::System.Windows.FrameworkElement.HeightProperty);
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x060015AD RID: 5549 RVA: 0x0004F05E File Offset: 0x0004D25E
		// (set) Token: 0x060015AE RID: 5550 RVA: 0x0004F070 File Offset: 0x0004D270
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

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x060015AF RID: 5551 RVA: 0x0004F07E File Offset: 0x0004D27E
		internal bool IsCalculatingSizeWithoutContent
		{
			get
			{
				return this._isCalculatingSizeWithoutContent;
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x060015B0 RID: 5552 RVA: 0x0004F086 File Offset: 0x0004D286
		internal bool IsDeferredShowPending
		{
			get
			{
				return this._deferredShowInfo != null;
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x060015B1 RID: 5553 RVA: 0x0004F094 File Offset: 0x0004D294
		internal bool IsDelayedMinMaxPending
		{
			get
			{
				return this._isDelayedMinMaxPending;
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x060015B2 RID: 5554 RVA: 0x0004F09C File Offset: 0x0004D29C
		internal bool IsModal
		{
			get
			{
				return this._showingAsDialog;
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x060015B3 RID: 5555 RVA: 0x0004F0A4 File Offset: 0x0004D2A4
		internal bool IsReshowing
		{
			get
			{
				return this._isReshowing;
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x060015B4 RID: 5556 RVA: 0x0004F0AC File Offset: 0x0004D2AC
		internal virtual bool KeepOnScreen
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x060015B5 RID: 5557 RVA: 0x0004F0AF File Offset: 0x0004D2AF
		// (set) Token: 0x060015B6 RID: 5558 RVA: 0x0004F0C1 File Offset: 0x0004D2C1
		internal double RequiredPopupHeight
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.Controls.ToolWindow.RequiredPopupHeightProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ToolWindow.RequiredPopupHeightProperty, value);
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x060015B7 RID: 5559 RVA: 0x0004F0D4 File Offset: 0x0004D2D4
		// (set) Token: 0x060015B8 RID: 5560 RVA: 0x0004F0E6 File Offset: 0x0004D2E6
		internal double RequiredPopupWidth
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.Controls.ToolWindow.RequiredPopupWidthProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ToolWindow.RequiredPopupWidthProperty, value);
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x060015B9 RID: 5561 RVA: 0x0004F0F9 File Offset: 0x0004D2F9
		// (set) Token: 0x060015BA RID: 5562 RVA: 0x0004F101 File Offset: 0x0004D301
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

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x060015BB RID: 5563 RVA: 0x0004F10A File Offset: 0x0004D30A
		// (set) Token: 0x060015BC RID: 5564 RVA: 0x0004F112 File Offset: 0x0004D312
		internal bool IsNonClientTouchDrag { get; set; }

		// Token: 0x060015BD RID: 5565 RVA: 0x0004F11C File Offset: 0x0004D31C
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

		// Token: 0x060015BE RID: 5566 RVA: 0x0004F175 File Offset: 0x0004D375
		public static global::Infragistics.Windows.Controls.ToolWindow GetToolWindow(global::System.Windows.DependencyObject d)
		{
			return (global::Infragistics.Windows.Controls.ToolWindow)d.GetValue(global::Infragistics.Windows.Controls.ToolWindow.ToolWindowProperty);
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x060015BF RID: 5567 RVA: 0x0004F187 File Offset: 0x0004D387
		internal bool UsesRelativePosition
		{
			get
			{
				return (!this._isLoadedAfterShow || !this._showingAsDialog) && (this.VerticalAlignmentMode == global::Infragistics.Windows.Controls.ToolWindowAlignmentMode.UseAlignment || this.HorizontalAlignmentMode == global::Infragistics.Windows.Controls.ToolWindowAlignmentMode.UseAlignment);
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x060015C0 RID: 5568 RVA: 0x0004F1AE File Offset: 0x0004D3AE
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

		// Token: 0x060015C1 RID: 5569 RVA: 0x0004F1C9 File Offset: 0x0004D3C9
		private static void OnPreferredBorderSizeChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.Controls.ToolWindow)d).UpdatePreferredBorderThickness();
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x060015C2 RID: 5570 RVA: 0x0004F1D6 File Offset: 0x0004D3D6
		// (set) Token: 0x060015C3 RID: 5571 RVA: 0x0004F1E8 File Offset: 0x0004D3E8
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

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x060015C4 RID: 5572 RVA: 0x0004F1FB File Offset: 0x0004D3FB
		// (set) Token: 0x060015C5 RID: 5573 RVA: 0x0004F20D File Offset: 0x0004D40D
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

		// Token: 0x060015C6 RID: 5574 RVA: 0x0004F220 File Offset: 0x0004D420
		private static bool ValidateToolWindowPart(object newValue)
		{
			return newValue == null || newValue is global::Infragistics.Windows.Controls.ToolWindowPart;
		}

		// Token: 0x060015C7 RID: 5575 RVA: 0x0004F230 File Offset: 0x0004D430
		private global::Infragistics.Windows.Controls.ToolWindowPart? GetToolWindowPart(global::System.Windows.DependencyObject d)
		{
			return (global::Infragistics.Windows.Controls.ToolWindowPart?)d.GetValue(global::Infragistics.Windows.Controls.ToolWindow.ToolWindowPartProperty);
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x0004F244 File Offset: 0x0004D444
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

		// Token: 0x060015C9 RID: 5577 RVA: 0x0004F3F8 File Offset: 0x0004D5F8
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

		// Token: 0x060015CA RID: 5578 RVA: 0x0004F461 File Offset: 0x0004D661
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

		// Token: 0x060015CB RID: 5579 RVA: 0x0004F48C File Offset: 0x0004D68C
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

		// Token: 0x060015CC RID: 5580 RVA: 0x0004F4DC File Offset: 0x0004D6DC
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

		// Token: 0x060015CD RID: 5581 RVA: 0x0004F504 File Offset: 0x0004D704
		internal global::System.Windows.Rect GetRestoreBounds(bool queryHost)
		{
			if (queryHost && this.Host != null)
			{
				return this.Host.GetRestoreBounds();
			}
			return this._restoreBounds;
		}

		// Token: 0x060015CE RID: 5582 RVA: 0x0004F523 File Offset: 0x0004D723
		internal global::System.Windows.FrameworkElement GetTemplatePart(global::Infragistics.Windows.Controls.ToolWindowPart part)
		{
			if (this._parts != null)
			{
				return this._parts[(int)part];
			}
			return null;
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x0004F538 File Offset: 0x0004D738
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

		// Token: 0x060015D0 RID: 5584 RVA: 0x0004F5AC File Offset: 0x0004D7AC
		private static bool IsMouseOverRootUnsafe(global::System.IntPtr hwnd, global::System.Windows.FrameworkElement relativeElement, global::System.Windows.Point relativePoint)
		{
			global::System.Windows.Point point = global::Infragistics.Windows.Utilities.PointToScreenSafe(relativeElement, relativePoint);
			global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT rcWindow = global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowInfo(hwnd).rcWindow;
			return rcWindow.ToRect().Contains(point);
		}

		// Token: 0x060015D1 RID: 5585 RVA: 0x0004F5E0 File Offset: 0x0004D7E0
		internal void OnClosedInternal(bool clearDeferredShow = false)
		{
			global::Infragistics.Windows.Controls.ToolWindow.DeferredShowInfo deferredShowInfo = this._deferredShowInfo;
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
			if (clearDeferredShow && this._deferredShowInfo == deferredShowInfo)
			{
				this._deferredShowInfo = null;
			}
		}

		// Token: 0x060015D2 RID: 5586 RVA: 0x0004F668 File Offset: 0x0004D868
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

		// Token: 0x060015D3 RID: 5587 RVA: 0x0004F6BC File Offset: 0x0004D8BC
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

		// Token: 0x060015D4 RID: 5588 RVA: 0x0004F73C File Offset: 0x0004D93C
		protected internal virtual bool OnDragCaption(global::System.Windows.Point pt, global::System.Windows.Input.MouseDevice mouse)
		{
			return false;
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x0004F73F File Offset: 0x0004D93F
		internal virtual void OnMoveCancelled()
		{
		}

		// Token: 0x060015D6 RID: 5590 RVA: 0x0004F741 File Offset: 0x0004D941
		internal virtual bool OnEnterMove()
		{
			return false;
		}

		// Token: 0x060015D7 RID: 5591 RVA: 0x0004F744 File Offset: 0x0004D944
		internal virtual bool OnExitMove()
		{
			return false;
		}

		// Token: 0x060015D8 RID: 5592 RVA: 0x0004F747 File Offset: 0x0004D947
		internal virtual void OnWindowMoving(global::System.Windows.Point pt, global::System.Windows.Input.MouseDevice mouse, global::System.Windows.Rect logicalScreenRect)
		{
		}

		// Token: 0x060015D9 RID: 5593 RVA: 0x0004F749 File Offset: 0x0004D949
		internal void SetRestoreBounds(global::System.Windows.Rect restoreBounds, bool updateHost)
		{
			if (updateHost && this.Host != null)
			{
				this.Host.SetRestoreBounds(restoreBounds);
				return;
			}
			this._restoreBounds = restoreBounds;
		}

		// Token: 0x060015DA RID: 5594 RVA: 0x0004F76A File Offset: 0x0004D96A
		internal bool ShowSystemContextMenu(global::System.Windows.Point location)
		{
			return this.ShowContextMenu(this, location, false);
		}

		// Token: 0x060015DB RID: 5595 RVA: 0x0004F775 File Offset: 0x0004D975
		internal static bool WillHostInWindow(global::System.Windows.FrameworkElement owner)
		{
			return global::Infragistics.Windows.Controls.ToolWindow.GetOwningWindow(owner) != null || global::Infragistics.Windows.Controls.ToolWindow.GetOwnerHwnd(owner) != global::System.IntPtr.Zero;
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x0004F791 File Offset: 0x0004D991
		internal void VerifyIsUsingOSNonClientArea()
		{
			base.SetValue(global::Infragistics.Windows.Controls.ToolWindow.IsUsingOSNonClientAreaPropertyKey, (global::System.Windows.Window.GetWindow(this) == this.Host && this.UseOSNonClientArea) ? global::Infragistics.KnownBoxes.TrueBox : global::System.Windows.DependencyProperty.UnsetValue);
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x0004F7C0 File Offset: 0x0004D9C0
		private object AdjustMinExtent(object extent, bool isWidth)
		{
			if (extent is double)
			{
				double num = (double)extent;
				global::Infragistics.Windows.Controls.IToolWindowHost host = this.Host;
				if (host != null && host.IsUsingOsNonClientArea)
				{
					global::System.Windows.Size size = this.CalculateNonClientSize(default(global::System.Windows.Size));
					double num2 = isWidth ? size.Width : size.Height;
					if (global::Infragistics.CoreUtilities.LessThanOrClose(num, num2))
					{
						extent = global::Infragistics.KnownBoxes.DoubleZeroBox;
					}
					else
					{
						extent = num - num2;
					}
				}
			}
			return extent;
		}

		// Token: 0x060015DE RID: 5598 RVA: 0x0004F830 File Offset: 0x0004DA30
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

		// Token: 0x060015DF RID: 5599 RVA: 0x0004FA4C File Offset: 0x0004DC4C
		private void CalculateSizeWithoutContent()
		{
			if (this._parts == null)
			{
				return;
			}
			bool isCalculatingSizeWithoutContent = this._isCalculatingSizeWithoutContent;
			this._isCalculatingSizeWithoutContent = true;
			bool isInCalculatingSizeWithoutContent = this._isInCalculatingSizeWithoutContent;
			this._isInCalculatingSizeWithoutContent = true;
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
				this._isInCalculatingSizeWithoutContent = isInCalculatingSizeWithoutContent;
			}
		}

		// Token: 0x060015E0 RID: 5600 RVA: 0x0004FB50 File Offset: 0x0004DD50
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

		// Token: 0x060015E1 RID: 5601 RVA: 0x0004FC58 File Offset: 0x0004DE58
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

		// Token: 0x060015E2 RID: 5602 RVA: 0x0004FCEC File Offset: 0x0004DEEC
		private void CanExecuteDialogCommand(object sender, global::System.Windows.Input.CanExecuteRoutedEventArgs e)
		{
			global::System.Windows.Input.RoutedCommand routedCommand = e.Command as global::System.Windows.Input.RoutedCommand;
			if (routedCommand.OwnerType == typeof(global::System.Windows.Window) && routedCommand.Name == "DialogCancel" && this.Host != null && !this.Host.IsWindow)
			{
				e.CanExecute = true;
				e.Handled = true;
			}
		}

		// Token: 0x060015E3 RID: 5603 RVA: 0x0004FD54 File Offset: 0x0004DF54
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

		// Token: 0x060015E4 RID: 5604 RVA: 0x0004FDAC File Offset: 0x0004DFAC
		private static object CoerceMinMaxButtonVisibility(global::System.Windows.DependencyObject d, object newValue)
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = d as global::Infragistics.Windows.Controls.ToolWindow;
			if (!toolWindow.AllowMinimize && !toolWindow.AllowMaximize)
			{
				return global::Infragistics.KnownBoxes.VisibilityCollapsedBox;
			}
			return newValue;
		}

		// Token: 0x060015E5 RID: 5605 RVA: 0x0004FDD8 File Offset: 0x0004DFD8
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
			newValue = toolWindow.AdjustMinExtent(newValue, true);
			return global::Infragistics.Windows.Controls.ToolWindow.CoerceMinMaxValue(newValue, 0.0, toolWindow._calculatedMinWidth);
		}

		// Token: 0x060015E6 RID: 5606 RVA: 0x0004FE3C File Offset: 0x0004E03C
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
			newValue = toolWindow.AdjustMinExtent(newValue, false);
			return global::Infragistics.Windows.Controls.ToolWindow.CoerceMinMaxValue(newValue, 0.0, toolWindow._calculatedMinHeight);
		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x0004FEA0 File Offset: 0x0004E0A0
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

		// Token: 0x060015E8 RID: 5608 RVA: 0x0004FEF8 File Offset: 0x0004E0F8
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

		// Token: 0x060015E9 RID: 5609 RVA: 0x0004FF50 File Offset: 0x0004E150
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
				double m = global::Infragistics.Windows.Utilities.GetDeviceMatrix(false, toolWindow).M11;
				double num2 = m / 2.0;
				int num3 = (int)global::System.Math.Floor((num + num2) / m);
				double value = (double)num3 * m;
				if (!global::Infragistics.CoreUtilities.AreClose(value, num))
				{
				}
			}
			if (!toolWindow._isCalculatingSizeWithoutContent)
			{
				return newValue;
			}
			return double.NaN;
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x0004FFF8 File Offset: 0x0004E1F8
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
				double m = global::Infragistics.Windows.Utilities.GetDeviceMatrix(false, toolWindow).M22;
				double num2 = m / 2.0;
				int num3 = (int)global::System.Math.Floor((num + num2) / m);
				double value = (double)num3 * m;
				if (!global::Infragistics.CoreUtilities.AreClose(value, num))
				{
				}
			}
			if (!toolWindow._isCalculatingSizeWithoutContent)
			{
				return newValue;
			}
			return double.NaN;
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x0005009E File Offset: 0x0004E29E
		private static object CoerceMinMaxValue(object newValue, double requiredValue, object calculatedValue)
		{
			if ((newValue == null || (double)newValue == requiredValue) && calculatedValue != null)
			{
				return calculatedValue;
			}
			return newValue;
		}

		// Token: 0x060015EC RID: 5612 RVA: 0x000500B4 File Offset: 0x0004E2B4
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

		// Token: 0x060015ED RID: 5613 RVA: 0x00050180 File Offset: 0x0004E380
		private void ExecuteDialogCommand(object sender, global::System.Windows.Input.ExecutedRoutedEventArgs e)
		{
			global::System.Windows.Input.RoutedCommand routedCommand = e.Command as global::System.Windows.Input.RoutedCommand;
			if (routedCommand.OwnerType == typeof(global::System.Windows.Window) && routedCommand.Name == "DialogCancel")
			{
				this.DialogResult = new bool?(false);
				e.Handled = true;
			}
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x000501D8 File Offset: 0x0004E3D8
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

		// Token: 0x060015EF RID: 5615 RVA: 0x0005023A File Offset: 0x0004E43A
		private static global::System.Windows.Window GetOwningWindow(global::System.Windows.FrameworkElement owner)
		{
			if (!global::System.Windows.Interop.BrowserInteropHelper.IsBrowserHosted)
			{
				return global::System.Windows.Window.GetWindow(owner);
			}
			return null;
		}

		// Token: 0x060015F0 RID: 5616 RVA: 0x0005024C File Offset: 0x0004E44C
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

		// Token: 0x060015F1 RID: 5617 RVA: 0x000502D8 File Offset: 0x0004E4D8
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

		// Token: 0x060015F2 RID: 5618 RVA: 0x00050352 File Offset: 0x0004E552
		private static void OnAllowMinMaxChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			d.CoerceValue(global::Infragistics.Windows.Controls.ToolWindow.MinimizeButtonVisibilityProperty);
			d.CoerceValue(global::Infragistics.Windows.Controls.ToolWindow.MaximizeButtonVisibilityProperty);
		}

		// Token: 0x060015F3 RID: 5619 RVA: 0x0005036C File Offset: 0x0004E56C
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

		// Token: 0x060015F4 RID: 5620 RVA: 0x000503AA File Offset: 0x0004E5AA
		private void OnEndShowDialog()
		{
			if (this._showingAsDialog)
			{
				this._showingAsDialog = false;
				global::System.Windows.Input.CommandManager.RemoveCanExecuteHandler(this, new global::System.Windows.Input.CanExecuteRoutedEventHandler(this.CanExecuteDialogCommand));
				global::System.Windows.Input.CommandManager.RemoveExecutedHandler(this, new global::System.Windows.Input.ExecutedRoutedEventHandler(this.ExecuteDialogCommand));
			}
		}

		// Token: 0x060015F5 RID: 5621 RVA: 0x000503E0 File Offset: 0x0004E5E0
		private static void OnExecuteCommand(object sender, global::System.Windows.Input.ExecutedRoutedEventArgs e)
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = sender as global::Infragistics.Windows.Controls.ToolWindow;
			if (toolWindow.ExecuteCommand(e.Command))
			{
				e.Handled = true;
			}
		}

		// Token: 0x060015F6 RID: 5622 RVA: 0x00050409 File Offset: 0x0004E609
		private static void OnFlowDirectionChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.Controls.ToolWindow)d).VerifyResizeGripHitTestResult();
		}

		// Token: 0x060015F7 RID: 5623 RVA: 0x00050416 File Offset: 0x0004E616
		private void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this._isLoadedAfterShow = true;
		}

		// Token: 0x060015F8 RID: 5624 RVA: 0x00050420 File Offset: 0x0004E620
		private void OnOwnerLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this.Owner.Loaded -= this.OnOwnerLoaded;
			global::Infragistics.Windows.Controls.ToolWindow.IDeferShow deferShow = this.ShowImpl(this.Owner);
			if (deferShow != null)
			{
				deferShow.Show(this._activateOnShow);
			}
		}

		// Token: 0x060015F9 RID: 5625 RVA: 0x00050460 File Offset: 0x0004E660
		private void OnOwnerUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this.Close();
		}

		// Token: 0x060015FA RID: 5626 RVA: 0x00050468 File Offset: 0x0004E668
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

		// Token: 0x060015FB RID: 5627 RVA: 0x000505C0 File Offset: 0x0004E7C0
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

		// Token: 0x060015FC RID: 5628 RVA: 0x0005069C File Offset: 0x0004E89C
		private static void OnRelativePositionSettingChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = (global::Infragistics.Windows.Controls.ToolWindow)d;
			if (toolWindow.Host != null)
			{
				toolWindow.CalculateMinMaxExtents(true);
				toolWindow.Host.RelativePositionStateChanged();
			}
		}

		// Token: 0x060015FD RID: 5629 RVA: 0x000506CA File Offset: 0x0004E8CA
		private void OnStartShowDialog()
		{
			this._showingAsDialog = true;
			global::System.Windows.Input.CommandManager.AddCanExecuteHandler(this, new global::System.Windows.Input.CanExecuteRoutedEventHandler(this.CanExecuteDialogCommand));
			global::System.Windows.Input.CommandManager.AddExecutedHandler(this, new global::System.Windows.Input.ExecutedRoutedEventHandler(this.ExecuteDialogCommand));
		}

		// Token: 0x060015FE RID: 5630 RVA: 0x000506F8 File Offset: 0x0004E8F8
		private static void OnVisibilityChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = d as global::Infragistics.Windows.Controls.ToolWindow;
			if (toolWindow.Host != null && !toolWindow.IsModal && toolWindow.Host.IsWindow && !global::System.Windows.Visibility.Collapsed.Equals(e.NewValue) && toolWindow.IsUsingOSNonClientArea != toolWindow.Host.IsUsingOsNonClientArea)
			{
				toolWindow.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::Infragistics.Windows.Controls.ToolWindow.MethodInvoker(toolWindow.ReshowIfVisible));
			}
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x0005076C File Offset: 0x0004E96C
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

		// Token: 0x06001600 RID: 5632 RVA: 0x00050838 File Offset: 0x0004EA38
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

		// Token: 0x06001601 RID: 5633 RVA: 0x000508B8 File Offset: 0x0004EAB8
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
			global::Infragistics.Windows.Controls.ToolWindowHostType preferredHost = this._preferredHost;
			this._isReshowing = true;
			try
			{
				this.Close();
				this.Show(owner, isActive, preferredHost);
			}
			finally
			{
				this._isReshowing = false;
			}
		}

		// Token: 0x06001602 RID: 5634 RVA: 0x0005094C File Offset: 0x0004EB4C
		private void ReshowIfVisible()
		{
			if (this.Host != null && base.IsVisible && this.IsUsingOSNonClientArea != this.Host.IsUsingOsNonClientArea)
			{
				this.Reshow();
			}
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x00050978 File Offset: 0x0004EB78
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

		// Token: 0x06001604 RID: 5636 RVA: 0x000509C4 File Offset: 0x0004EBC4
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

		// Token: 0x06001605 RID: 5637 RVA: 0x00050AFC File Offset: 0x0004ECFC
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

		// Token: 0x06001606 RID: 5638 RVA: 0x00050B24 File Offset: 0x0004ED24
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
			if (this._preferredHost == global::Infragistics.Windows.Controls.ToolWindowHostType.Popup)
			{
				return global::Infragistics.Windows.Controls.ToolWindowHostPopup.Show(this);
			}
			global::System.Windows.Window owningWindow = global::Infragistics.Windows.Controls.ToolWindow.GetOwningWindow(owner);
			bool flag = owningWindow != null || global::Infragistics.Windows.Controls.ToolWindow.GetOwnerHwnd(owner) != global::System.IntPtr.Zero;
			if (this._preferredHost == global::Infragistics.Windows.Controls.ToolWindowHostType.Window && flag)
			{
				return this.ShowInToolWindowHostWindow(owningWindow);
			}
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = global::Infragistics.Windows.Controls.ToolWindow.GetToolWindow(owner);
			if (toolWindow != null && toolWindow.Host is global::Infragistics.Windows.Controls.ToolWindowHostPopup)
			{
				this._preferredHost = global::Infragistics.Windows.Controls.ToolWindowHostType.Popup;
				return global::Infragistics.Windows.Controls.ToolWindowHostPopup.Show(this);
			}
			global::Infragistics.Windows.Controls.ToolWindowAdorner adorner = global::Infragistics.Windows.Controls.ToolWindow.GetAdorner(owner, true);
			if (adorner != null)
			{
				return adorner.AddWindow(this, owner);
			}
			if (this._preferredHost == global::Infragistics.Windows.Controls.ToolWindowHostType.Adorner && flag)
			{
				this._preferredHost = global::Infragistics.Windows.Controls.ToolWindowHostType.Window;
				return this.ShowImpl(owner);
			}
			return null;
		}

		// Token: 0x06001607 RID: 5639 RVA: 0x00050C04 File Offset: 0x0004EE04
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private global::Infragistics.Windows.Controls.ToolWindow.IDeferShow ShowInToolWindowHostWindow(global::System.Windows.Window owningWindow)
		{
			global::Infragistics.Windows.Controls.ToolWindowHostWindow window = this.PrepareShowInHostWindow(owningWindow);
			return new global::Infragistics.Windows.Controls.ToolWindowHostWindow.DeferShowHelper(window);
		}

		// Token: 0x06001608 RID: 5640 RVA: 0x00050C20 File Offset: 0x0004EE20
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

		// Token: 0x06001609 RID: 5641 RVA: 0x00050C7C File Offset: 0x0004EE7C
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

		// Token: 0x0600160A RID: 5642 RVA: 0x00050CC4 File Offset: 0x0004EEC4
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

		// Token: 0x0600160B RID: 5643 RVA: 0x00050D24 File Offset: 0x0004EF24
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

		// Token: 0x0600160C RID: 5644 RVA: 0x00050D4B File Offset: 0x0004EF4B
		protected virtual global::System.Windows.Controls.ContextMenu CreateDefaultContextMenu(object originalSource)
		{
			return null;
		}

		// Token: 0x0600160D RID: 5645 RVA: 0x00050D4E File Offset: 0x0004EF4E
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

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x0600160E RID: 5646 RVA: 0x00050D87 File Offset: 0x0004EF87
		protected virtual bool SupportsAllowsTransparency
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x0600160F RID: 5647 RVA: 0x00050D8A File Offset: 0x0004EF8A
		protected virtual bool SupportsShowDialog
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x00050D8D File Offset: 0x0004EF8D
		protected virtual void SetVisualState(bool useTransitions)
		{
			if (this.IsActive)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Active", useTransitions);
				return;
			}
			global::System.Windows.VisualStateManager.GoToState(this, "Inactive", useTransitions);
		}

		// Token: 0x06001611 RID: 5649 RVA: 0x00050DB4 File Offset: 0x0004EFB4
		private static void OnVisualStatePropertyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = target as global::Infragistics.Windows.Controls.ToolWindow;
			toolWindow.UpdateVisualStates();
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x00050DCE File Offset: 0x0004EFCE
		private void UpdateVisualStates()
		{
			this.UpdateVisualStates(true);
		}

		// Token: 0x06001613 RID: 5651 RVA: 0x00050DD7 File Offset: 0x0004EFD7
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

		// Token: 0x06001614 RID: 5652 RVA: 0x00050DF4 File Offset: 0x0004EFF4
		public void Activate()
		{
			if (this.Host != null)
			{
				this.Host.Activate();
			}
		}

		// Token: 0x06001615 RID: 5653 RVA: 0x00050E09 File Offset: 0x0004F009
		public void BringToFront()
		{
			if (base.IsVisible && this.Owner != null && this.Host != null)
			{
				this.Host.BringToFront();
			}
		}

		// Token: 0x06001616 RID: 5654 RVA: 0x00050E2E File Offset: 0x0004F02E
		public void Close()
		{
			if (this._deferredShowInfo != null)
			{
				this._deferredShowInfo.Cancel();
			}
			this.CloseOverride();
		}

		// Token: 0x06001617 RID: 5655 RVA: 0x00050E49 File Offset: 0x0004F049
		public global::System.Windows.Rect GetRestoreBounds()
		{
			return this.GetRestoreBounds(true);
		}

		// Token: 0x06001618 RID: 5656 RVA: 0x00050E52 File Offset: 0x0004F052
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public static global::System.Windows.Point GetScreenPoint(global::System.Windows.FrameworkElement owner, global::System.Windows.Input.MouseEventArgs e)
		{
			global::Infragistics.Windows.Utilities.ThrowIfNull(owner, "owner");
			global::Infragistics.Windows.Utilities.ThrowIfNull(e, "e");
			return global::Infragistics.Windows.Controls.ToolWindow.GetScreenPoint(owner, e.GetPosition(owner), owner);
		}

		// Token: 0x06001619 RID: 5657 RVA: 0x00050E78 File Offset: 0x0004F078
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public static global::System.Windows.Point GetScreenPoint(global::System.Windows.FrameworkElement owner, global::System.Windows.Point relativePoint, global::System.Windows.FrameworkElement relativeElement)
		{
			return global::Infragistics.Windows.Controls.ToolWindow.GetScreenPoint(owner, relativePoint, relativeElement, global::Infragistics.Windows.Controls.ToolWindowHostType.Window);
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x00050E84 File Offset: 0x0004F084
		internal static global::System.Windows.Point GetScreenPoint(global::System.Windows.FrameworkElement owner, global::System.Windows.Point relativePoint, global::System.Windows.FrameworkElement relativeElement, global::Infragistics.Windows.Controls.ToolWindowHostType preferredHost)
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
			bool flag = owningWindow != null || global::Infragistics.Windows.Controls.ToolWindow.GetOwnerHwnd(owner) != global::System.IntPtr.Zero;
			if (flag && preferredHost != global::Infragistics.Windows.Controls.ToolWindowHostType.Adorner)
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
			if (flag && preferredHost == global::Infragistics.Windows.Controls.ToolWindowHostType.Adorner)
			{
				return global::Infragistics.Windows.Controls.ToolWindow.GetScreenPoint(owner, relativePoint, relativeElement, global::Infragistics.Windows.Controls.ToolWindowHostType.Window);
			}
			return point;
		}

		// Token: 0x0600161B RID: 5659 RVA: 0x00050F2C File Offset: 0x0004F12C
		public static global::Infragistics.Windows.Controls.ToolWindow[] GetToolWindows(global::System.Windows.FrameworkElement owner)
		{
			int num;
			return global::Infragistics.Windows.Controls.ToolWindow.GetToolWindows(owner, out num);
		}

		// Token: 0x0600161C RID: 5660 RVA: 0x00050F44 File Offset: 0x0004F144
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

		// Token: 0x0600161D RID: 5661 RVA: 0x00050FB2 File Offset: 0x0004F1B2
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private static void GetToolWindowHostWindows(global::System.Windows.FrameworkElement owner, global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.ToolWindow> windows, global::System.Windows.Window owningWindow, out int ownerWindowIndex)
		{
			global::Infragistics.Windows.Controls.ToolWindowHostWindow.GetToolWindows(owningWindow, owner, windows, out ownerWindowIndex);
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x00050FBD File Offset: 0x0004F1BD
		public void SetRestoreBounds(global::System.Windows.Rect restoreBounds)
		{
			if (restoreBounds.IsEmpty)
			{
				throw new global::System.InvalidOperationException();
			}
			this.SetRestoreBounds(restoreBounds, true);
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x00050FD6 File Offset: 0x0004F1D6
		public void Show(global::System.Windows.FrameworkElement owner)
		{
			this.Show(owner, true);
		}

		// Token: 0x06001620 RID: 5664 RVA: 0x00050FE0 File Offset: 0x0004F1E0
		public void Show(global::System.Windows.FrameworkElement owner, bool activate)
		{
			this.Show(owner, activate, false);
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x00050FEB File Offset: 0x0004F1EB
		public void Show(global::System.Windows.FrameworkElement owner, bool activate, bool preferPopup)
		{
			this.Show(owner, activate, preferPopup ? global::Infragistics.Windows.Controls.ToolWindowHostType.Popup : global::Infragistics.Windows.Controls.ToolWindowHostType.Window);
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x00050FFC File Offset: 0x0004F1FC
		internal void Show(global::System.Windows.FrameworkElement owner, bool activate, global::Infragistics.Windows.Controls.ToolWindowHostType preferredHost)
		{
			global::System.IDisposable disposable = this.ShowAsync(owner, activate, preferredHost);
			if (disposable != null)
			{
				disposable.Dispose();
			}
		}

		// Token: 0x06001623 RID: 5667 RVA: 0x0005101C File Offset: 0x0004F21C
		internal global::System.IDisposable ShowAsync(global::System.Windows.FrameworkElement owner, bool activate, bool preferPopup)
		{
			return this.ShowAsync(owner, activate, preferPopup ? global::Infragistics.Windows.Controls.ToolWindowHostType.Popup : global::Infragistics.Windows.Controls.ToolWindowHostType.Window);
		}

		// Token: 0x06001624 RID: 5668 RVA: 0x00051030 File Offset: 0x0004F230
		internal global::System.IDisposable ShowAsync(global::System.Windows.FrameworkElement owner, bool activate, global::Infragistics.Windows.Controls.ToolWindowHostType preferredHost)
		{
			this.PrepareForShow(owner, false);
			this._activateOnShow = activate;
			this._preferredHost = preferredHost;
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

		// Token: 0x06001625 RID: 5669 RVA: 0x000510A4 File Offset: 0x0004F2A4
		public void ShowDialog(global::System.Windows.FrameworkElement owner, global::Infragistics.Windows.Controls.ToolWindow.ShowDialogCallback callback)
		{
			this.PrepareForShow(owner, true);
			this._preferredHost = global::Infragistics.Windows.Controls.ToolWindowHostType.Window;
			global::System.Windows.Window owningWindow = global::Infragistics.Windows.Controls.ToolWindow.GetOwningWindow(owner);
			this.OnStartShowDialog();
			base.CoerceValue(global::Infragistics.Windows.Controls.ToolWindow.MinimizeButtonVisibilityProperty);
			base.CoerceValue(global::Infragistics.Windows.Controls.ToolWindow.MaximizeButtonVisibilityProperty);
			if (owningWindow != null || global::Infragistics.Windows.Controls.ToolWindow.GetOwnerHwnd(owner) != global::System.IntPtr.Zero)
			{
				this.ShowModalToolWindowHostWindow(owningWindow, callback);
				return;
			}
			global::Infragistics.Windows.Controls.ToolWindowHostPopup.ShowDialog(this, callback);
		}

		// Token: 0x1400002C RID: 44
		// (add) Token: 0x06001626 RID: 5670 RVA: 0x00051108 File Offset: 0x0004F308
		// (remove) Token: 0x06001627 RID: 5671 RVA: 0x0005111B File Offset: 0x0004F31B
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

		// Token: 0x1400002D RID: 45
		// (add) Token: 0x06001628 RID: 5672 RVA: 0x0005112E File Offset: 0x0004F32E
		// (remove) Token: 0x06001629 RID: 5673 RVA: 0x00051141 File Offset: 0x0004F341
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

		// Token: 0x1400002E RID: 46
		// (add) Token: 0x0600162A RID: 5674 RVA: 0x00051154 File Offset: 0x0004F354
		// (remove) Token: 0x0600162B RID: 5675 RVA: 0x00051167 File Offset: 0x0004F367
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

		// Token: 0x1400002F RID: 47
		// (add) Token: 0x0600162C RID: 5676 RVA: 0x0005117A File Offset: 0x0004F37A
		// (remove) Token: 0x0600162D RID: 5677 RVA: 0x0005118D File Offset: 0x0004F38D
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

		// Token: 0x14000030 RID: 48
		// (add) Token: 0x0600162E RID: 5678 RVA: 0x000511A0 File Offset: 0x0004F3A0
		// (remove) Token: 0x0600162F RID: 5679 RVA: 0x000511B3 File Offset: 0x0004F3B3
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

		// Token: 0x06001630 RID: 5680 RVA: 0x000511C8 File Offset: 0x0004F3C8
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

		// Token: 0x06001631 RID: 5681 RVA: 0x00051204 File Offset: 0x0004F404
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

		// Token: 0x06001632 RID: 5682 RVA: 0x00051240 File Offset: 0x0004F440
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

		// Token: 0x06001633 RID: 5683 RVA: 0x0005127C File Offset: 0x0004F47C
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

		// Token: 0x06001634 RID: 5684 RVA: 0x000512B8 File Offset: 0x0004F4B8
		internal void OnWindowShowing(global::System.EventArgs e)
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(e, "e");
			global::System.EventHandler eventHandler = (global::System.EventHandler)this.Events[global::Infragistics.Windows.Controls.ToolWindow.EventWindowShowing];
			if (eventHandler != null)
			{
				eventHandler(this, e);
			}
		}

		// Token: 0x06001635 RID: 5685 RVA: 0x000512F1 File Offset: 0x0004F4F1
		void global::Infragistics.Windows.Helpers.IMinMaxWatcherOwner.OnMinMaxChanged(global::Infragistics.Windows.Helpers.MinMaxWatcher watcher)
		{
			this.CalculateMinMaxExtents(true);
		}

		// Token: 0x04000B48 RID: 2888
		private global::System.Windows.FrameworkElement[] _parts;

		// Token: 0x04000B49 RID: 2889
		private static readonly int PartCount;

		// Token: 0x04000B4A RID: 2890
		private static object[] BoxedParts;

		// Token: 0x04000B4B RID: 2891
		private global::System.ComponentModel.EventHandlerList _events;

		// Token: 0x04000B4C RID: 2892
		private object _calculatedMinWidth;

		// Token: 0x04000B4D RID: 2893
		private object _calculatedMinHeight;

		// Token: 0x04000B4E RID: 2894
		private object _calculatedMaxWidth;

		// Token: 0x04000B4F RID: 2895
		private object _calculatedMaxHeight;

		// Token: 0x04000B50 RID: 2896
		private global::System.Windows.Size _sizeWithoutContent;

		// Token: 0x04000B51 RID: 2897
		private global::System.Windows.Size _sizeWithoutCaption;

		// Token: 0x04000B52 RID: 2898
		private global::Infragistics.Windows.Helpers.MinMaxWatcher _minMaxWatcher;

		// Token: 0x04000B53 RID: 2899
		private bool _isCalculatingSizeWithoutContent;

		// Token: 0x04000B54 RID: 2900
		private bool _isInCalculatingSizeWithoutContent;

		// Token: 0x04000B55 RID: 2901
		private bool _activateOnShow = true;

		// Token: 0x04000B56 RID: 2902
		private bool _isDelayedMinMaxPending;

		// Token: 0x04000B57 RID: 2903
		private bool? _dialogResult;

		// Token: 0x04000B58 RID: 2904
		private bool _showingAsDialog;

		// Token: 0x04000B59 RID: 2905
		private bool _isLoadedAfterShow;

		// Token: 0x04000B5A RID: 2906
		private global::Infragistics.Windows.Controls.ToolWindowHostType _preferredHost;

		// Token: 0x04000B5B RID: 2907
		private bool _isReshowing;

		// Token: 0x04000B5C RID: 2908
		private global::Infragistics.Windows.Controls.ToolWindow.DeferredShowInfo _deferredShowInfo;

		// Token: 0x04000B5D RID: 2909
		private bool _hasVisualStateGroups;

		// Token: 0x04000B5E RID: 2910
		private global::System.Windows.Rect _restoreBounds = global::System.Windows.Rect.Empty;

		// Token: 0x04000B5F RID: 2911
		private bool _restoreToMaximized;

		// Token: 0x04000B60 RID: 2912
		private global::System.Windows.WindowState _cachedWindowState;

		// Token: 0x04000B61 RID: 2913
		public static readonly global::System.Windows.DependencyProperty AllowCloseProperty = global::System.Windows.DependencyProperty.Register("AllowClose", typeof(bool), typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindow.OnAllowCloseChanged)));

		// Token: 0x04000B62 RID: 2914
		public static readonly global::System.Windows.DependencyProperty AllowMaximizeProperty = global::System.Windows.DependencyProperty.Register("AllowMaximize", typeof(bool), typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindow.OnAllowMinMaxChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.ToolWindow.CoerceAllowMaximize)));

		// Token: 0x04000B63 RID: 2915
		public static readonly global::System.Windows.DependencyProperty AllowMinimizeProperty = global::System.Windows.DependencyProperty.Register("AllowMinimize", typeof(bool), typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindow.OnAllowMinMaxChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.ToolWindow.CoerceAllowMinimize)));

		// Token: 0x04000B64 RID: 2916
		public static readonly global::System.Windows.DependencyProperty AllowsTransparencyProperty = global::System.Windows.DependencyProperty.Register("AllowsTransparency", typeof(bool), typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindow.OnAllowsTransparencyChanged)));

		// Token: 0x04000B65 RID: 2917
		private static readonly global::System.Windows.DependencyPropertyKey CaptionVisibilityPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("CaptionVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityVisibleBox));

		// Token: 0x04000B66 RID: 2918
		public static readonly global::System.Windows.DependencyProperty CaptionVisibilityProperty = global::Infragistics.Windows.Controls.ToolWindow.CaptionVisibilityPropertyKey.DependencyProperty;

		// Token: 0x04000B67 RID: 2919
		public static readonly global::System.Windows.DependencyProperty HorizontalAlignmentModeProperty = global::System.Windows.DependencyProperty.Register("HorizontalAlignmentMode", typeof(global::Infragistics.Windows.Controls.ToolWindowAlignmentMode), typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.ToolWindowAlignmentMode.Manual, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindow.OnRelativePositionSettingChanged)));

		// Token: 0x04000B68 RID: 2920
		public static readonly global::System.Windows.DependencyProperty HorizontalAlignmentOffsetProperty = global::System.Windows.DependencyProperty.Register("HorizontalAlignmentOffset", typeof(double), typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(0.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindow.OnRelativePositionSettingChanged)));

		// Token: 0x04000B69 RID: 2921
		internal static readonly global::System.Windows.DependencyPropertyKey IsActivePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsActive", typeof(bool), typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindow.OnIsActiveChanged)));

		// Token: 0x04000B6A RID: 2922
		public static readonly global::System.Windows.DependencyProperty IsActiveProperty = global::Infragistics.Windows.Controls.ToolWindow.IsActivePropertyKey.DependencyProperty;

		// Token: 0x04000B6B RID: 2923
		public static readonly global::System.Windows.DependencyProperty IsOwnedWindowProperty = global::System.Windows.DependencyProperty.Register("IsOwnedWindow", typeof(bool), typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindow.OnIsOwnedWindowChanged)));

		// Token: 0x04000B6C RID: 2924
		private static readonly global::System.Windows.DependencyPropertyKey IsUsingOSNonClientAreaPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsUsingOSNonClientArea", typeof(bool), typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindow.OnIsUsingOSNonClientAreaChanged)));

		// Token: 0x04000B6D RID: 2925
		public static readonly global::System.Windows.DependencyProperty IsUsingOSNonClientAreaProperty = global::Infragistics.Windows.Controls.ToolWindow.IsUsingOSNonClientAreaPropertyKey.DependencyProperty;

		// Token: 0x04000B6E RID: 2926
		public static readonly global::System.Windows.DependencyProperty LeftProperty = global::System.Windows.Window.LeftProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.ToolWindow));

		// Token: 0x04000B6F RID: 2927
		public static readonly global::System.Windows.DependencyProperty MaximizeButtonVisibilityProperty = global::System.Windows.DependencyProperty.Register("MaximizeButtonVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityVisibleBox, null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.ToolWindow.CoerceMinMaxButtonVisibility)));

		// Token: 0x04000B70 RID: 2928
		public static readonly global::System.Windows.DependencyProperty MinimizeButtonVisibilityProperty = global::System.Windows.DependencyProperty.Register("MinimizeButtonVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityVisibleBox, null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.ToolWindow.CoerceMinMaxButtonVisibility)));

		// Token: 0x04000B71 RID: 2929
		private static readonly global::System.Windows.DependencyPropertyKey OwnerPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Owner", typeof(global::System.Windows.FrameworkElement), typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindow.OnOwnerChanged)));

		// Token: 0x04000B72 RID: 2930
		public static readonly global::System.Windows.DependencyProperty OwnerProperty = global::Infragistics.Windows.Controls.ToolWindow.OwnerPropertyKey.DependencyProperty;

		// Token: 0x04000B73 RID: 2931
		public static readonly global::System.Windows.DependencyProperty ResizeModeProperty = global::System.Windows.DependencyProperty.Register("ResizeMode", typeof(global::System.Windows.ResizeMode), typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.ResizeMode.CanResize, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindow.OnResizeModeChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.ToolWindow.CoerceResizeMode)));

		// Token: 0x04000B74 RID: 2932
		public static readonly global::System.Windows.DependencyProperty ShowInTaskbarProperty = global::System.Windows.DependencyProperty.Register("ShowInTaskbar", typeof(bool), typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000B75 RID: 2933
		private static readonly global::System.Windows.DependencyPropertyKey PreferredBorderThicknessPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("PreferredBorderThickness", typeof(global::System.Windows.Thickness), typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(default(global::System.Windows.Thickness)));

		// Token: 0x04000B76 RID: 2934
		public static readonly global::System.Windows.DependencyProperty PreferredBorderThicknessProperty = global::Infragistics.Windows.Controls.ToolWindow.PreferredBorderThicknessPropertyKey.DependencyProperty;

		// Token: 0x04000B77 RID: 2935
		public static readonly global::System.Windows.DependencyProperty ThemeProperty = global::Infragistics.Windows.Themes.ThemeManager.ThemeProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.ToolWindow), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindow.OnThemeChanged)));

		// Token: 0x04000B79 RID: 2937
		public static readonly global::System.Windows.DependencyProperty TitleProperty;

		// Token: 0x04000B7A RID: 2938
		public static readonly global::System.Windows.DependencyProperty TopProperty;

		// Token: 0x04000B7B RID: 2939
		public static readonly global::System.Windows.DependencyProperty TopmostProperty;

		// Token: 0x04000B7C RID: 2940
		public static readonly global::System.Windows.DependencyProperty UseOSNonClientAreaProperty;

		// Token: 0x04000B7D RID: 2941
		public static readonly global::System.Windows.DependencyProperty VerticalAlignmentModeProperty;

		// Token: 0x04000B7E RID: 2942
		public static readonly global::System.Windows.DependencyProperty VerticalAlignmentOffsetProperty;

		// Token: 0x04000B7F RID: 2943
		public static readonly global::System.Windows.DependencyProperty WindowStartupLocationProperty;

		// Token: 0x04000B80 RID: 2944
		public static readonly global::System.Windows.DependencyProperty WindowStateProperty;

		// Token: 0x04000B81 RID: 2945
		private static readonly global::System.Windows.DependencyPropertyKey HitTestCodePropertyKey;

		// Token: 0x04000B82 RID: 2946
		internal static readonly global::System.Windows.DependencyProperty HitTestCodeProperty;

		// Token: 0x04000B83 RID: 2947
		internal static readonly global::System.Windows.DependencyProperty HostProperty;

		// Token: 0x04000B84 RID: 2948
		internal static readonly global::System.Windows.DependencyProperty RequiredPopupHeightProperty;

		// Token: 0x04000B85 RID: 2949
		internal static readonly global::System.Windows.DependencyProperty RequiredPopupWidthProperty;

		// Token: 0x04000B86 RID: 2950
		private static readonly global::System.Windows.DependencyPropertyKey ToolWindowPropertyKey;

		// Token: 0x04000B87 RID: 2951
		public static readonly global::System.Windows.DependencyProperty ToolWindowProperty;

		// Token: 0x04000B88 RID: 2952
		private static readonly global::System.Windows.DependencyProperty PreferredBorderWidthProperty;

		// Token: 0x04000B89 RID: 2953
		private static readonly global::System.Windows.DependencyProperty PreferredBorderHeightProperty;

		// Token: 0x04000B8A RID: 2954
		private static readonly global::System.Windows.DependencyProperty ToolWindowPartProperty;

		// Token: 0x04000B8B RID: 2955
		private static bool _getOwnerHwndFailed;

		// Token: 0x04000B8C RID: 2956
		public static readonly global::System.Windows.Input.RoutedCommand CloseCommand;

		// Token: 0x04000B8D RID: 2957
		public static readonly global::System.Windows.Input.RoutedCommand MinimizeCommand;

		// Token: 0x04000B8E RID: 2958
		public static readonly global::System.Windows.Input.RoutedCommand MaximizeCommand;

		// Token: 0x04000B8F RID: 2959
		public static readonly global::System.Windows.Input.RoutedCommand RestoreCommand;

		// Token: 0x04000B90 RID: 2960
		private static readonly object EventActivated;

		// Token: 0x04000B91 RID: 2961
		private static readonly object EventDeactivated;

		// Token: 0x04000B92 RID: 2962
		private static readonly object EventClosing;

		// Token: 0x04000B93 RID: 2963
		private static readonly object EventClosed;

		// Token: 0x04000B94 RID: 2964
		private static readonly object EventWindowShowing;

		// Token: 0x02000234 RID: 564
		// (Invoke) Token: 0x06001638 RID: 5688
		internal delegate void MethodInvoker();

		// Token: 0x02000235 RID: 565
		// (Invoke) Token: 0x0600163C RID: 5692
		public delegate void ShowDialogCallback(global::Infragistics.Windows.Controls.ToolWindow window, bool? dialogResult);

		// Token: 0x02000236 RID: 566
		private class DeferredShowInfo : global::System.IDisposable
		{
			// Token: 0x0600163F RID: 5695 RVA: 0x000512FA File Offset: 0x0004F4FA
			internal DeferredShowInfo(global::Infragistics.Windows.Controls.ToolWindow toolWindow, bool activate, global::Infragistics.Windows.Controls.ToolWindow.IDeferShow deferShow)
			{
				global::Infragistics.CoreUtilities.ValidateNotNull(toolWindow, "toolWindow");
				global::Infragistics.CoreUtilities.ValidateNotNull(deferShow, "deferShow");
				this._toolWindow = toolWindow;
				this._activate = activate;
				this._deferShow = deferShow;
			}

			// Token: 0x1700051A RID: 1306
			// (get) Token: 0x06001640 RID: 5696 RVA: 0x0005132D File Offset: 0x0004F52D
			internal bool IsCancelled
			{
				get
				{
					return this._result != null && !this._result.Value;
				}
			}

			// Token: 0x06001641 RID: 5697 RVA: 0x0005134C File Offset: 0x0004F54C
			internal void Cancel()
			{
				this.ProcessShow(true);
			}

			// Token: 0x06001642 RID: 5698 RVA: 0x00051355 File Offset: 0x0004F555
			internal void Show()
			{
				this.ProcessShow(false);
			}

			// Token: 0x06001643 RID: 5699 RVA: 0x00051360 File Offset: 0x0004F560
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

			// Token: 0x06001644 RID: 5700 RVA: 0x000513B4 File Offset: 0x0004F5B4
			void global::System.IDisposable.Dispose()
			{
				this.ProcessShow(false);
			}

			// Token: 0x04000B97 RID: 2967
			private bool _activate;

			// Token: 0x04000B98 RID: 2968
			private bool? _result;

			// Token: 0x04000B99 RID: 2969
			private global::Infragistics.Windows.Controls.ToolWindow _toolWindow;

			// Token: 0x04000B9A RID: 2970
			private global::Infragistics.Windows.Controls.ToolWindow.IDeferShow _deferShow;
		}

		// Token: 0x02000237 RID: 567
		internal interface IDeferShow
		{
			// Token: 0x06001645 RID: 5701
			void Show(bool activate);

			// Token: 0x06001646 RID: 5702
			void Cancel();
		}
	}
}
