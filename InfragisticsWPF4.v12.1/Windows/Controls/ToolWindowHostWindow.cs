using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Threading;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000214 RID: 532
	internal class ToolWindowHostWindow : global::System.Windows.Window, global::Infragistics.Windows.Controls.IToolWindowHost
	{
		// Token: 0x06001501 RID: 5377 RVA: 0x0004E728 File Offset: 0x0004C928
		static ToolWindowHostWindow()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ToolWindowHostWindow), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Controls.ToolWindowHostWindow)));
			global::System.Windows.Window.WindowStyleProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ToolWindowHostWindow), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.WindowStyle.None));
			global::System.Windows.Window.ShowInTaskbarProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ToolWindowHostWindow), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::System.Windows.FrameworkElement.MaxWidthProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ToolWindowHostWindow), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.ToolWindowHostWindow.CoerceMaxWidth)));
			global::System.Windows.FrameworkElement.MaxHeightProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ToolWindowHostWindow), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.ToolWindowHostWindow.CoerceMaxHeight)));
			global::System.Windows.FrameworkElement.WidthProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ToolWindowHostWindow), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindowHostWindow.OnWidthChanged)));
			global::System.Windows.FrameworkElement.HeightProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ToolWindowHostWindow), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindowHostWindow.OnHeightChanged)));
			global::Infragistics.Windows.Controls.ToolWindow.AllowMinimizeProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.ToolWindowHostWindow), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindowHostWindow.OnAllowMinMaxChanged)));
			global::Infragistics.Windows.Controls.ToolWindow.AllowMaximizeProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.ToolWindowHostWindow), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindowHostWindow.OnAllowMinMaxChanged)));
			if (global::System.Environment.Version.Major <= 3)
			{
				global::System.Windows.Window.TopProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ToolWindowHostWindow), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(new global::Infragistics.Windows.Controls.ToolWindowHostWindow.TopLeftCoerceProxy(global::System.Windows.Window.TopProperty, global::System.Windows.Window.TopProperty.GetMetadata(typeof(global::Infragistics.Windows.Controls.ToolWindowHostWindow)).CoerceValueCallback).CoerceValue)));
				global::System.Windows.Window.LeftProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ToolWindowHostWindow), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(new global::Infragistics.Windows.Controls.ToolWindowHostWindow.TopLeftCoerceProxy(global::System.Windows.Window.LeftProperty, global::System.Windows.Window.LeftProperty.GetMetadata(typeof(global::Infragistics.Windows.Controls.ToolWindowHostWindow)).CoerceValueCallback).CoerceValue)));
			}
			global::System.Windows.Window.SizeToContentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ToolWindowHostWindow), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindowHostWindow.OnSizeToContentChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.ToolWindowHostWindow.CoerceSizeToContent)));
			global::System.Windows.Window.WindowStateProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ToolWindowHostWindow), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindowHostWindow.OnWindowStateChanged)));
			global::System.Windows.FrameworkElementFactory visualTree = new global::System.Windows.FrameworkElementFactory(typeof(global::System.Windows.Controls.ContentPresenter));
			global::System.Windows.Controls.ControlTemplate controlTemplate = new global::System.Windows.Controls.ControlTemplate(typeof(global::Infragistics.Windows.Controls.ToolWindowHostWindow));
			controlTemplate.VisualTree = visualTree;
			controlTemplate.Seal();
			global::System.Windows.Controls.Control.TemplateProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ToolWindowHostWindow), new global::System.Windows.FrameworkPropertyMetadata(controlTemplate));
		}

		// Token: 0x06001502 RID: 5378 RVA: 0x0004EB9D File Offset: 0x0004CD9D
		internal ToolWindowHostWindow()
		{
			this.SetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.UseSystemNonClientArea, (bool)base.GetValue(global::Infragistics.Windows.Controls.ToolWindowHostWindow.UseSystemNonClientAreaProperty));
		}

		// Token: 0x06001503 RID: 5379 RVA: 0x0004EBBC File Offset: 0x0004CDBC
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size arrangeBounds)
		{
			if (this.UseSystemNonClientArea)
			{
				this.UpdateClientSizeFromNonClientSize(!double.IsNaN(this.ClientWidth), !double.IsNaN(this.ClientHeight), arrangeBounds.Width, arrangeBounds.Height);
				return base.ArrangeOverride(arrangeBounds);
			}
			if (!this.UseSystemNonClientArea && this.VisualChildrenCount > 0)
			{
				global::System.Windows.FrameworkElement frameworkElement = this.GetVisualChild(0) as global::System.Windows.FrameworkElement;
				frameworkElement.Arrange(new global::System.Windows.Rect(arrangeBounds));
				if (base.FlowDirection == global::System.Windows.FlowDirection.RightToLeft)
				{
					frameworkElement.LayoutTransform = new global::System.Windows.Media.MatrixTransform(-1.0, 0.0, 0.0, 1.0, arrangeBounds.Width, 0.0);
				}
				else
				{
					frameworkElement.LayoutTransform = null;
				}
			}
			return arrangeBounds;
		}

		// Token: 0x06001504 RID: 5380 RVA: 0x0004EC88 File Offset: 0x0004CE88
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			if (this.UseSystemNonClientArea)
			{
				this.UpdateClientSizeFromNonClientSize(!double.IsInfinity(availableSize.Width) && !double.IsNaN(this.ClientWidth), !double.IsInfinity(availableSize.Height) && !double.IsNaN(this.ClientHeight), availableSize.Width, availableSize.Height);
				return base.MeasureOverride(availableSize);
			}
			if (this.VisualChildrenCount > 0)
			{
				global::System.Windows.UIElement uielement = this.GetVisualChild(0) as global::System.Windows.UIElement;
				if (uielement != null)
				{
					uielement.Measure(availableSize);
					return uielement.DesiredSize;
				}
			}
			return availableSize;
		}

		// Token: 0x06001505 RID: 5381 RVA: 0x0004ED1F File Offset: 0x0004CF1F
		protected override void OnActivated(global::System.EventArgs e)
		{
			if (this._content != null)
			{
				this._content.SetValue(global::Infragistics.Windows.Controls.ToolWindow.IsActivePropertyKey, global::Infragistics.KnownBoxes.TrueBox);
			}
			base.OnActivated(e);
		}

		// Token: 0x06001506 RID: 5382 RVA: 0x0004ED48 File Offset: 0x0004CF48
		protected override void OnClosing(global::System.ComponentModel.CancelEventArgs e)
		{
			base.OnClosing(e);
			if (this._content != null)
			{
				this.CacheRestoreBounds();
				this._content.OnClosingInternal(e);
			}
			if (!e.Cancel)
			{
				global::System.Windows.Interop.WindowInteropHelper windowInteropHelper = new global::System.Windows.Interop.WindowInteropHelper(this);
				if (windowInteropHelper.Handle != global::System.IntPtr.Zero)
				{
					global::Infragistics.Windows.Helpers.NativeWindowMethods.SetWindowLong(windowInteropHelper.Handle, -8, global::System.IntPtr.Zero);
				}
			}
		}

		// Token: 0x06001507 RID: 5383 RVA: 0x0004EDAC File Offset: 0x0004CFAC
		protected override void OnClosed(global::System.EventArgs e)
		{
			base.OnClosed(e);
			base.LayoutUpdated -= this.OnLayoutUpdated;
			if (this._content != null)
			{
				global::Infragistics.Windows.Controls.ToolWindow content = this._content;
				base.Content = null;
				content.OnClosedInternal();
			}
		}

		// Token: 0x06001508 RID: 5384 RVA: 0x0004EDF0 File Offset: 0x0004CFF0
		protected override void OnContentChanged(object oldContent, object newContent)
		{
			base.OnContentChanged(oldContent, newContent);
			bool flag = this.GetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsInOnContentChanged);
			try
			{
				this.SetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsInOnContentChanged, true);
				this.OnContentChangedImpl(oldContent, newContent);
			}
			finally
			{
				this.SetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsInOnContentChanged, flag);
			}
			if (this._content != null && this._content.WindowState == global::System.Windows.WindowState.Normal)
			{
				this.SynchronizeLocation(false);
				this.UpdateNonClientSizeFromClientSize(true, true);
			}
		}

		// Token: 0x06001509 RID: 5385 RVA: 0x0004EE60 File Offset: 0x0004D060
		private void OnContentChangedImpl(object oldContent, object newContent)
		{
			if (this._content != null)
			{
				this._content.ClearValue(global::Infragistics.Windows.Controls.ToolWindow.HostProperty);
				this._content.ClearValue(global::Infragistics.Windows.Controls.ToolWindow.IsActivePropertyKey);
			}
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = newContent as global::Infragistics.Windows.Controls.ToolWindow;
			this._content = toolWindow;
			if (toolWindow != null)
			{
				toolWindow.SetValue(global::Infragistics.Windows.Controls.ToolWindow.HostProperty, this);
				toolWindow.SetValue(global::Infragistics.Windows.Controls.ToolWindow.IsActivePropertyKey, base.IsActive ? global::Infragistics.KnownBoxes.TrueBox : global::System.Windows.DependencyProperty.UnsetValue);
				base.SetBinding(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalLeftProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.Controls.ToolWindow.LeftProperty, global::System.Windows.Data.BindingMode.TwoWay, toolWindow));
				base.SetBinding(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalTopProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.Controls.ToolWindow.TopProperty, global::System.Windows.Data.BindingMode.TwoWay, toolWindow));
				base.SetBinding(global::System.Windows.FrameworkElement.MaxWidthProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.FrameworkElement.MaxWidthProperty, global::System.Windows.Data.BindingMode.OneWay, toolWindow));
				base.SetBinding(global::System.Windows.FrameworkElement.MaxHeightProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.FrameworkElement.MaxHeightProperty, global::System.Windows.Data.BindingMode.OneWay, toolWindow));
				base.SetBinding(global::System.Windows.FrameworkElement.MinWidthProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.FrameworkElement.MinWidthProperty, global::System.Windows.Data.BindingMode.OneWay, toolWindow));
				base.SetBinding(global::System.Windows.FrameworkElement.MinHeightProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.FrameworkElement.MinHeightProperty, global::System.Windows.Data.BindingMode.OneWay, toolWindow));
				base.SetBinding(global::System.Windows.FrameworkElement.FlowDirectionProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.FrameworkElement.FlowDirectionProperty, global::System.Windows.Data.BindingMode.OneWay, toolWindow));
				base.SetBinding(global::Infragistics.Windows.Controls.ToolWindowHostWindow.UseSystemNonClientAreaProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.Controls.ToolWindow.IsUsingOSNonClientAreaProperty, global::System.Windows.Data.BindingMode.OneWay, toolWindow));
				base.SetBinding(global::System.Windows.UIElement.VisibilityProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.UIElement.VisibilityProperty, global::System.Windows.Data.BindingMode.TwoWay, toolWindow));
				base.SetBinding(global::System.Windows.Window.TopmostProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.Controls.ToolWindow.TopmostProperty, global::System.Windows.Data.BindingMode.OneWay, toolWindow));
				base.SetBinding(global::System.Windows.Window.ResizeModeProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.Controls.ToolWindow.ResizeModeProperty, global::System.Windows.Data.BindingMode.OneWay, toolWindow));
				base.SetBinding(global::Infragistics.Windows.Controls.ToolWindowHostWindow.AllowCloseProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.Controls.ToolWindow.AllowCloseProperty, global::System.Windows.Data.BindingMode.OneWay, toolWindow));
				base.SetBinding(global::System.Windows.Window.ShowInTaskbarProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.Controls.ToolWindow.ShowInTaskbarProperty, global::System.Windows.Data.BindingMode.OneWay, toolWindow));
				base.SetBinding(global::Infragistics.Windows.Controls.ToolWindow.AllowMaximizeProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.Controls.ToolWindow.AllowMaximizeProperty, global::System.Windows.Data.BindingMode.OneWay, toolWindow));
				base.SetBinding(global::Infragistics.Windows.Controls.ToolWindow.AllowMinimizeProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.Controls.ToolWindow.AllowMinimizeProperty, global::System.Windows.Data.BindingMode.OneWay, toolWindow));
				if (new global::System.Windows.Interop.WindowInteropHelper(this).Handle != global::System.IntPtr.Zero)
				{
					base.SetBinding(global::Infragistics.Windows.Controls.ToolWindowHostWindow.WindowStateInternalProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.Controls.ToolWindow.WindowStateProperty, global::System.Windows.Data.BindingMode.TwoWay, toolWindow));
				}
				global::System.Windows.Input.FocusManager.SetFocusedElement(this, toolWindow);
			}
			else
			{
				global::System.Windows.Data.BindingOperations.ClearBinding(this, global::System.Windows.Window.LeftProperty);
				global::System.Windows.Data.BindingOperations.ClearBinding(this, global::System.Windows.Window.TopProperty);
				global::System.Windows.Data.BindingOperations.ClearBinding(this, global::System.Windows.FrameworkElement.MaxWidthProperty);
				global::System.Windows.Data.BindingOperations.ClearBinding(this, global::System.Windows.FrameworkElement.MinWidthProperty);
				global::System.Windows.Data.BindingOperations.ClearBinding(this, global::System.Windows.FrameworkElement.MaxHeightProperty);
				global::System.Windows.Data.BindingOperations.ClearBinding(this, global::System.Windows.FrameworkElement.MinHeightProperty);
				global::System.Windows.Data.BindingOperations.ClearBinding(this, global::Infragistics.Windows.Controls.ToolWindowHostWindow.ClientWidthProperty);
				global::System.Windows.Data.BindingOperations.ClearBinding(this, global::Infragistics.Windows.Controls.ToolWindowHostWindow.ClientHeightProperty);
				global::System.Windows.Data.BindingOperations.ClearBinding(this, global::System.Windows.FrameworkElement.FlowDirectionProperty);
				global::System.Windows.Data.BindingOperations.ClearBinding(this, global::Infragistics.Windows.Controls.ToolWindowHostWindow.UseSystemNonClientAreaProperty);
				global::System.Windows.Data.BindingOperations.ClearBinding(this, global::System.Windows.UIElement.VisibilityProperty);
				global::System.Windows.Data.BindingOperations.ClearBinding(this, global::System.Windows.Window.TopmostProperty);
				global::System.Windows.Data.BindingOperations.ClearBinding(this, global::System.Windows.Window.ResizeModeProperty);
				global::System.Windows.Data.BindingOperations.ClearBinding(this, global::Infragistics.Windows.Controls.ToolWindowHostWindow.AllowCloseProperty);
				global::System.Windows.Data.BindingOperations.ClearBinding(this, global::System.Windows.Window.ShowInTaskbarProperty);
				global::System.Windows.Data.BindingOperations.ClearBinding(this, global::Infragistics.Windows.Controls.ToolWindow.AllowMaximizeProperty);
				global::System.Windows.Data.BindingOperations.ClearBinding(this, global::Infragistics.Windows.Controls.ToolWindow.AllowMinimizeProperty);
				global::System.Windows.Data.BindingOperations.ClearBinding(this, global::Infragistics.Windows.Controls.ToolWindowHostWindow.WindowStateInternalProperty);
				global::System.Windows.Input.FocusManager.SetFocusedElement(this, null);
			}
			this.VerifyTitleBinding();
			this.VerifyWindowStyle();
			if (toolWindow != null)
			{
				base.SetBinding(global::Infragistics.Windows.Controls.ToolWindowHostWindow.ClientWidthProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.FrameworkElement.WidthProperty, global::System.Windows.Data.BindingMode.TwoWay, toolWindow));
				base.SetBinding(global::Infragistics.Windows.Controls.ToolWindowHostWindow.ClientHeightProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.FrameworkElement.HeightProperty, global::System.Windows.Data.BindingMode.TwoWay, toolWindow));
			}
			this.VerifyRelativePositionBinding();
		}

		// Token: 0x0600150A RID: 5386 RVA: 0x0004F18C File Offset: 0x0004D38C
		private static void OnWindowStateInternalChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.ToolWindowHostWindow toolWindowHostWindow = d as global::Infragistics.Windows.Controls.ToolWindowHostWindow;
			if (toolWindowHostWindow._content == null)
			{
				return;
			}
			global::System.Windows.WindowState windowState = (global::System.Windows.WindowState)e.NewValue;
			if (windowState == toolWindowHostWindow.WindowState)
			{
				toolWindowHostWindow._content.WindowState = windowState;
				return;
			}
			((global::Infragistics.Windows.Controls.IToolWindowHost)toolWindowHostWindow).SetWindowState(windowState);
		}

		// Token: 0x0600150B RID: 5387 RVA: 0x0004F1D3 File Offset: 0x0004D3D3
		protected override void OnDeactivated(global::System.EventArgs e)
		{
			if (this._content != null)
			{
				this._content.ClearValue(global::Infragistics.Windows.Controls.ToolWindow.IsActivePropertyKey);
			}
			base.OnDeactivated(e);
		}

		// Token: 0x0600150C RID: 5388 RVA: 0x0004F1F4 File Offset: 0x0004D3F4
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			if (e.Key == global::System.Windows.Input.Key.System && e.SystemKey == global::System.Windows.Input.Key.F4 && global::System.Windows.Input.ModifierKeys.Alt == (e.KeyboardDevice.Modifiers & global::System.Windows.Input.ModifierKeys.Alt) && !this.AllowClose)
			{
				e.Handled = true;
			}
			base.OnKeyDown(e);
		}

		// Token: 0x0600150D RID: 5389 RVA: 0x0004F233 File Offset: 0x0004D433
		protected override void OnLocationChanged(global::System.EventArgs e)
		{
			base.OnLocationChanged(e);
			this.SynchronizeLocation(true);
			base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Send, new global::Infragistics.Windows.Controls.ToolWindow.MethodInvoker(this.UpdateRelativePosition));
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x0004F25D File Offset: 0x0004D45D
		protected override void OnStateChanged(global::System.EventArgs e)
		{
			this.CacheRestoreBounds();
			base.CoerceValue(global::System.Windows.Window.SizeToContentProperty);
			base.OnStateChanged(e);
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x0004F278 File Offset: 0x0004D478
		protected override void OnSourceInitialized(global::System.EventArgs e)
		{
			global::System.Windows.Interop.WindowInteropHelper windowInteropHelper = new global::System.Windows.Interop.WindowInteropHelper(this);
			global::System.IntPtr handle = windowInteropHelper.Handle;
			global::System.Windows.Interop.HwndSource hwndSource = global::System.Windows.Interop.HwndSource.FromHwnd(handle);
			hwndSource.AddHook(new global::System.Windows.Interop.HwndSourceHook(this.WndProc));
			if (this._content != null)
			{
				base.SetBinding(global::Infragistics.Windows.Controls.ToolWindowHostWindow.WindowStateInternalProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.Controls.ToolWindow.WindowStateProperty, global::System.Windows.Data.BindingMode.TwoWay, this._content));
				if (this._content != null && base.WindowState != global::System.Windows.WindowState.Normal)
				{
					global::System.Windows.Rect restoreBounds = this._content.GetRestoreBounds(false);
					if (global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowState(this) == global::System.Windows.WindowState.Normal && base.WindowState == global::System.Windows.WindowState.Minimized && !restoreBounds.IsEmpty)
					{
						base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::System.Threading.SendOrPostCallback(this.AsyncInitializeRestoreBounds), restoreBounds);
					}
					else
					{
						this.SetRestoreBounds(handle, restoreBounds);
					}
				}
				this.UseSystemNonClientArea = this.UseSystemNonClientArea;
			}
			this.VerifyWindowStyleBits(handle);
			global::Infragistics.Windows.Controls.ToolWindowHostWindow.UpdateAllowClose(this, this.AllowClose);
			this.VerifyRelativePositionBinding();
			this.SynchronizeLocation(true);
			base.OnSourceInitialized(e);
			this.VerifyIsInView(false, true, false);
		}

		// Token: 0x06001510 RID: 5392 RVA: 0x0004F371 File Offset: 0x0004D571
		protected override void OnRenderSizeChanged(global::System.Windows.SizeChangedInfo sizeInfo)
		{
			base.OnRenderSizeChanged(sizeInfo);
			this.UpdateRelativePosition();
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06001511 RID: 5393 RVA: 0x0004F380 File Offset: 0x0004D580
		public bool AllowClose
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.ToolWindowHostWindow.AllowCloseProperty);
			}
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x0004F394 File Offset: 0x0004D594
		private static void OnAllowCloseChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.ToolWindowHostWindow window = (global::Infragistics.Windows.Controls.ToolWindowHostWindow)d;
			global::Infragistics.Windows.Controls.ToolWindowHostWindow.UpdateAllowClose(window, true.Equals(e.NewValue));
		}

		// Token: 0x06001513 RID: 5395 RVA: 0x0004F3BE File Offset: 0x0004D5BE
		private static void OnClientHeightChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.Controls.ToolWindowHostWindow)d).UpdateNonClientSizeFromClientSize(false, true);
			d.InvalidateProperty(global::System.Windows.FrameworkElement.HeightProperty);
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06001514 RID: 5396 RVA: 0x0004F3D8 File Offset: 0x0004D5D8
		// (set) Token: 0x06001515 RID: 5397 RVA: 0x0004F3EA File Offset: 0x0004D5EA
		internal double ClientHeight
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.Controls.ToolWindowHostWindow.ClientHeightProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ToolWindowHostWindow.ClientHeightProperty, value);
			}
		}

		// Token: 0x06001516 RID: 5398 RVA: 0x0004F3FD File Offset: 0x0004D5FD
		private static void OnClientWidthChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.Controls.ToolWindowHostWindow)d).UpdateNonClientSizeFromClientSize(true, false);
			d.InvalidateProperty(global::System.Windows.FrameworkElement.WidthProperty);
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06001517 RID: 5399 RVA: 0x0004F417 File Offset: 0x0004D617
		// (set) Token: 0x06001518 RID: 5400 RVA: 0x0004F429 File Offset: 0x0004D629
		internal double ClientWidth
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.Controls.ToolWindowHostWindow.ClientWidthProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ToolWindowHostWindow.ClientWidthProperty, value);
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06001519 RID: 5401 RVA: 0x0004F43C File Offset: 0x0004D63C
		private bool IsInWndProc
		{
			get
			{
				return this._wndProcCount > 0;
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x0600151A RID: 5402 RVA: 0x0004F447 File Offset: 0x0004D647
		// (set) Token: 0x0600151B RID: 5403 RVA: 0x0004F459 File Offset: 0x0004D659
		private double InternalLeft
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalLeftProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalLeftProperty, value);
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x0600151C RID: 5404 RVA: 0x0004F46C File Offset: 0x0004D66C
		// (set) Token: 0x0600151D RID: 5405 RVA: 0x0004F47E File Offset: 0x0004D67E
		private double InternalTop
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalTopProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalTopProperty, value);
			}
		}

		// Token: 0x0600151E RID: 5406 RVA: 0x0004F494 File Offset: 0x0004D694
		private static void OnOwnerRectChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.ToolWindowHostWindow toolWindowHostWindow = (global::Infragistics.Windows.Controls.ToolWindowHostWindow)d;
			toolWindowHostWindow.UpdateRelativePosition();
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x0600151F RID: 5407 RVA: 0x0004F4AE File Offset: 0x0004D6AE
		private global::System.Windows.Rect OwnerRect
		{
			get
			{
				return (global::System.Windows.Rect)base.GetValue(global::Infragistics.Windows.Controls.ToolWindowHostWindow.OwnerRectProperty);
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06001520 RID: 5408 RVA: 0x0004F4C0 File Offset: 0x0004D6C0
		// (set) Token: 0x06001521 RID: 5409 RVA: 0x0004F4C9 File Offset: 0x0004D6C9
		private bool UpdatingRelativePosition
		{
			get
			{
				return this.GetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.UpdatingRelativePosition);
			}
			set
			{
				this.SetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.UpdatingRelativePosition, value);
			}
		}

		// Token: 0x06001522 RID: 5410 RVA: 0x0004F4D4 File Offset: 0x0004D6D4
		private static void OnUseSystemNonClientAreaChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.ToolWindowHostWindow toolWindowHostWindow = (global::Infragistics.Windows.Controls.ToolWindowHostWindow)d;
			toolWindowHostWindow.SetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.UseSystemNonClientArea, (bool)e.NewValue);
			if (toolWindowHostWindow._content == null)
			{
				return;
			}
			global::System.Windows.Interop.WindowInteropHelper windowInteropHelper = new global::System.Windows.Interop.WindowInteropHelper(toolWindowHostWindow);
			global::System.IntPtr handle = windowInteropHelper.Handle;
			if (handle == global::System.IntPtr.Zero)
			{
				toolWindowHostWindow.VerifyWindowStyle();
				return;
			}
			toolWindowHostWindow.CoerceValue(global::System.Windows.Window.SizeToContentProperty);
			toolWindowHostWindow.VerifyWindowStyle();
			if (toolWindowHostWindow._content != null && toolWindowHostWindow._content.Host == toolWindowHostWindow)
			{
				toolWindowHostWindow._content.CalculateMinMaxExtents(false);
			}
			toolWindowHostWindow.UpdateNonClientSizeFromClientSize(true, true);
			if (handle != global::System.IntPtr.Zero)
			{
				global::Infragistics.Windows.Helpers.NativeWindowMethods.SetWindowPosApi(handle, global::System.IntPtr.Zero, 0, 0, 0, 0, 567);
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06001523 RID: 5411 RVA: 0x0004F583 File Offset: 0x0004D783
		// (set) Token: 0x06001524 RID: 5412 RVA: 0x0004F58C File Offset: 0x0004D78C
		private bool UseSystemNonClientArea
		{
			get
			{
				return this.GetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.UseSystemNonClientArea);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ToolWindowHostWindow.UseSystemNonClientAreaProperty, value);
			}
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x0004F5A0 File Offset: 0x0004D7A0
		internal global::System.Windows.Size AddNonClientSize(global::System.Windows.Size clientSize)
		{
			double width = clientSize.Width;
			double height = clientSize.Height;
			this.UpdateForClientSize(true, ref width, ref height);
			return new global::System.Windows.Size(width, height);
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x0004F5D0 File Offset: 0x0004D7D0
		internal static bool AreClose(double value1, double value2)
		{
			return value1 == value2 || (double.IsNaN(value1) && double.IsNaN(value2)) || global::System.Math.Abs(value1 - value2) < 1E-10;
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x0004F600 File Offset: 0x0004D800
		internal void BringToFront()
		{
			global::System.IntPtr handle = new global::System.Windows.Interop.WindowInteropHelper(this).Handle;
			if (global::System.IntPtr.Zero != handle)
			{
				global::Infragistics.Windows.Helpers.NativeWindowMethods.SetWindowPosApi(handle, global::System.IntPtr.Zero, 0, 0, 0, 0, 19);
			}
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x0004F638 File Offset: 0x0004D838
		internal static global::Infragistics.Windows.Controls.ToolWindow FromRootVisual(global::System.Windows.Media.Visual rootVisual)
		{
			global::Infragistics.Windows.Controls.ToolWindow result = null;
			if (rootVisual != null)
			{
				global::Infragistics.Windows.Controls.ToolWindowHostWindow toolWindowHostWindow = rootVisual as global::Infragistics.Windows.Controls.ToolWindowHostWindow;
				if (toolWindowHostWindow != null)
				{
					result = (toolWindowHostWindow.Content as global::Infragistics.Windows.Controls.ToolWindow);
				}
				else
				{
					global::System.Windows.Controls.Primitives.Popup popup = global::System.Windows.LogicalTreeHelper.GetParent(rootVisual) as global::System.Windows.Controls.Primitives.Popup;
					global::Infragistics.Windows.Controls.ToolWindowHostPopup host = global::Infragistics.Windows.Controls.ToolWindowHostPopup.GetHost(popup);
					if (host != null)
					{
						result = (host.Child as global::Infragistics.Windows.Controls.ToolWindow);
					}
				}
			}
			return result;
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x0004F72C File Offset: 0x0004D92C
		internal static void GetToolWindows(global::System.Windows.Window window, global::System.Windows.FrameworkElement owner, global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.ToolWindow> list, out int ownerWindowIndex)
		{
			global::System.IntPtr parent = global::System.IntPtr.Zero;
			if (window != null)
			{
				parent = new global::System.Windows.Interop.WindowInteropHelper(window).Handle;
			}
			else
			{
				global::System.IntPtr ownerHwnd = global::Infragistics.Windows.Controls.ToolWindow.GetOwnerHwnd(owner);
				if (ownerHwnd != global::System.IntPtr.Zero)
				{
					parent = global::Infragistics.Windows.Helpers.NativeWindowMethods.GetAncestorApi(ownerHwnd, 2);
				}
			}
			int windowIndex = list.Count;
			if (global::System.IntPtr.Zero != parent)
			{
				global::System.Collections.Generic.Dictionary<global::System.IntPtr, global::System.Windows.Interop.HwndSource> sources = new global::System.Collections.Generic.Dictionary<global::System.IntPtr, global::System.Windows.Interop.HwndSource>();
				foreach (object obj in global::System.Windows.PresentationSource.CurrentSources)
				{
					global::System.Windows.PresentationSource presentationSource = (global::System.Windows.PresentationSource)obj;
					global::System.Windows.Interop.HwndSource hwndSource = presentationSource as global::System.Windows.Interop.HwndSource;
					if (hwndSource != null && !hwndSource.IsDisposed)
					{
						global::System.IntPtr handle = hwndSource.Handle;
						if (!(handle == global::System.IntPtr.Zero))
						{
							sources[handle] = hwndSource;
						}
					}
				}
				global::Infragistics.Windows.Helpers.NativeWindowMethods.EnumWindowsProc childCallback = delegate(global::System.IntPtr hwnd, global::System.IntPtr lParam)
				{
					global::Infragistics.Windows.Controls.ToolWindowHostWindow.GetToolWindows(owner, list, sources, hwnd);
					return true;
				};
				global::Infragistics.Windows.Helpers.NativeWindowMethods.EnumWindowsProc lpfn = delegate(global::System.IntPtr hwnd, global::System.IntPtr lParam)
				{
					global::Infragistics.Windows.Helpers.NativeWindowMethods.EnumChildWindows(hwnd, childCallback, global::System.IntPtr.Zero);
					global::Infragistics.Windows.Controls.ToolWindowHostWindow.GetToolWindows(owner, list, sources, hwnd);
					if (hwnd == parent)
					{
						windowIndex = list.Count;
					}
					return true;
				};
				global::Infragistics.Windows.Helpers.NativeWindowMethods.EnumThreadWindows(global::Infragistics.Windows.Helpers.NativeWindowMethods.GetCurrentThreadIdApi(), lpfn, global::System.IntPtr.Zero);
			}
			ownerWindowIndex = windowIndex;
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x0004F8A0 File Offset: 0x0004DAA0
		private static void GetToolWindows(global::System.Windows.FrameworkElement owner, global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.ToolWindow> list, global::System.Collections.Generic.Dictionary<global::System.IntPtr, global::System.Windows.Interop.HwndSource> sources, global::System.IntPtr hwnd)
		{
			global::System.Windows.Interop.HwndSource hwndSource;
			if (sources.TryGetValue(hwnd, out hwndSource) && !hwndSource.IsDisposed)
			{
				global::Infragistics.Windows.Controls.ToolWindow toolWindow = global::Infragistics.Windows.Controls.ToolWindowHostWindow.FromRootVisual(hwndSource.RootVisual);
				if (toolWindow != null && toolWindow.Owner == owner)
				{
					list.Add(toolWindow);
				}
			}
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x0004F8E0 File Offset: 0x0004DAE0
		internal void Show(bool activate)
		{
			this.VerifyWindowStyle();
			if (!activate)
			{
				this.InstallActivationHook();
			}
			try
			{
				base.Show();
			}
			catch
			{
				this.ReleaseActivationHook();
				throw;
			}
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x0004F920 File Offset: 0x0004DB20
		private void AsyncInitializeRestoreBounds(object restoreBounds)
		{
			global::System.Windows.Rect restoreBounds2 = (global::System.Windows.Rect)restoreBounds;
			global::System.IntPtr handle = new global::System.Windows.Interop.WindowInteropHelper(this).Handle;
			if (global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowState(handle) != global::System.Windows.WindowState.Normal)
			{
				base.SizeToContent = global::System.Windows.SizeToContent.Manual;
				this.SetRestoreBounds(handle, restoreBounds2);
			}
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x0004F958 File Offset: 0x0004DB58
		private void CacheRestoreBounds()
		{
			if (this._content != null)
			{
				if (base.WindowState != global::System.Windows.WindowState.Normal)
				{
					global::System.Windows.Rect restoreBounds = base.RestoreBounds;
					if (!restoreBounds.IsEmpty)
					{
						this._content.SetRestoreBounds(restoreBounds, false);
						global::System.Windows.Interop.WindowInteropHelper windowInteropHelper = new global::System.Windows.Interop.WindowInteropHelper(this);
						if (windowInteropHelper.Handle != global::System.IntPtr.Zero)
						{
							global::Infragistics.Windows.Helpers.NativeWindowMethods.WINDOWPLACEMENT windowPlacement = global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowPlacement(windowInteropHelper.Handle);
							this._content.RestoreToMaximized = ((windowPlacement.flags & 2) == 2);
							return;
						}
					}
				}
				else if (global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowState(this) == global::System.Windows.WindowState.Normal)
				{
					this._content.RestoreToMaximized = false;
				}
			}
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x0004F9E3 File Offset: 0x0004DBE3
		private void CloseHelper()
		{
			if (this.IsInWndProc)
			{
				base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::Infragistics.Windows.Controls.ToolWindow.MethodInvoker(this.CloseHelper));
				return;
			}
			base.Close();
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x0004FA10 File Offset: 0x0004DC10
		private static object CoerceMaxWidth(global::System.Windows.DependencyObject d, object newValue)
		{
			global::Infragistics.Windows.Controls.ToolWindowHostWindow toolWindowHostWindow = (global::Infragistics.Windows.Controls.ToolWindowHostWindow)d;
			double num = (double)newValue;
			if (double.IsPositiveInfinity(num) || !toolWindowHostWindow.UseSystemNonClientArea)
			{
				return newValue;
			}
			double naN = double.NaN;
			toolWindowHostWindow.UpdateForClientSize(true, ref num, ref naN);
			return num;
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x0004FA5C File Offset: 0x0004DC5C
		private static object CoerceMaxHeight(global::System.Windows.DependencyObject d, object newValue)
		{
			global::Infragistics.Windows.Controls.ToolWindowHostWindow toolWindowHostWindow = (global::Infragistics.Windows.Controls.ToolWindowHostWindow)d;
			double num = (double)newValue;
			if (double.IsPositiveInfinity(num) || !toolWindowHostWindow.UseSystemNonClientArea)
			{
				return newValue;
			}
			double naN = double.NaN;
			toolWindowHostWindow.UpdateForClientSize(true, ref naN, ref num);
			return num;
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x0004FAA8 File Offset: 0x0004DCA8
		private static object CoerceSizeToContent(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Infragistics.Windows.Controls.ToolWindowHostWindow window = d as global::Infragistics.Windows.Controls.ToolWindowHostWindow;
			if (global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowState(window) != global::System.Windows.WindowState.Normal && !global::System.Windows.SizeToContent.Manual.Equals(baseValue))
			{
				return global::System.Windows.SizeToContent.Manual;
			}
			return baseValue;
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x0004FADC File Offset: 0x0004DCDC
		private global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT ConvertFromLogicalPixels(double x, double y)
		{
			global::System.Windows.Interop.WindowInteropHelper windowInteropHelper = new global::System.Windows.Interop.WindowInteropHelper(this);
			global::System.IntPtr handle = windowInteropHelper.Handle;
			global::System.Windows.Interop.HwndSource hwndSource = (global::System.IntPtr.Zero != handle) ? global::System.Windows.Interop.HwndSource.FromHwnd(handle) : null;
			global::System.Windows.Point point;
			if (hwndSource != null)
			{
				point = hwndSource.CompositionTarget.TransformToDevice.Transform(new global::System.Windows.Point(x, y));
			}
			else
			{
				point = new global::System.Windows.Point((double)global::Infragistics.Windows.Utilities.ConvertFromLogicalPixels(x), (double)global::Infragistics.Windows.Utilities.ConvertFromLogicalPixels(y));
			}
			return new global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT((int)point.X, (int)point.Y);
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x0004FB5C File Offset: 0x0004DD5C
		private global::System.Windows.Point ConvertToLogicalPixels(int x, int y)
		{
			global::System.Windows.Interop.WindowInteropHelper windowInteropHelper = new global::System.Windows.Interop.WindowInteropHelper(this);
			global::System.IntPtr handle = windowInteropHelper.Handle;
			global::System.Windows.Interop.HwndSource hwndSource = (global::System.IntPtr.Zero != handle) ? global::System.Windows.Interop.HwndSource.FromHwnd(handle) : null;
			global::System.Windows.Point result;
			if (hwndSource != null)
			{
				result = hwndSource.CompositionTarget.TransformFromDevice.Transform(new global::System.Windows.Point((double)x, (double)y));
			}
			else
			{
				result = new global::System.Windows.Point(global::Infragistics.Windows.Utilities.ConvertToLogicalPixels(x), global::Infragistics.Windows.Utilities.ConvertToLogicalPixels(y));
			}
			return result;
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x0004FBC5 File Offset: 0x0004DDC5
		private bool GetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags flag)
		{
			return (this._flags & flag) != (global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags)0;
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x0004FBD8 File Offset: 0x0004DDD8
		private global::System.IntPtr HookProc(int nCode, global::System.IntPtr wParam, global::System.IntPtr lParam)
		{
			if (nCode == 5)
			{
				global::System.Windows.Window window = global::System.Windows.Window.GetWindow(this);
				global::System.Windows.Interop.WindowInteropHelper windowInteropHelper = (window != null) ? new global::System.Windows.Interop.WindowInteropHelper(window) : null;
				if (windowInteropHelper != null && windowInteropHelper.Handle == wParam)
				{
					this.ReleaseActivationHook();
					return new global::System.IntPtr(1);
				}
			}
			return global::Infragistics.Windows.Helpers.NativeWindowMethods.CallNextHookEx(this._hook, nCode, wParam, lParam);
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x0004FC2C File Offset: 0x0004DE2C
		private void InstallActivationHook()
		{
			if (this._hook != global::System.IntPtr.Zero)
			{
				this.ReleaseActivationHook();
			}
			if (this._hookCallback == null)
			{
				this._hookCallback = new global::Infragistics.Windows.Helpers.NativeWindowMethods.HookProc(this.HookProc);
			}
			this._hook = global::Infragistics.Windows.Helpers.NativeWindowMethods.SetWindowsHookEx(5, this._hookCallback, global::System.IntPtr.Zero, global::Infragistics.Windows.Helpers.NativeWindowMethods.GetCurrentThreadIdApi());
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x0004FC87 File Offset: 0x0004DE87
		private static void OnInternalLeftTopChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.Controls.ToolWindowHostWindow)d).SynchronizeLocation(false);
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x0004FC95 File Offset: 0x0004DE95
		private static void OnHeightChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.Controls.ToolWindowHostWindow)d).UpdateClientSizeFromNonClientSize(false, true);
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x0004FCA4 File Offset: 0x0004DEA4
		private void OnLayoutUpdated(object sender, global::System.EventArgs e)
		{
			base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::Infragistics.Windows.Controls.ToolWindow.MethodInvoker(this.UpdateRelativePosition));
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x0004FCC0 File Offset: 0x0004DEC0
		private void OnAfterWindowStateChanged(global::System.Windows.WindowState newState)
		{
			if (!this.GetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsChangingWindowState) && newState == base.WindowState && newState == global::System.Windows.WindowState.Normal && this._content != null && this._content.WindowState == newState)
			{
				this.UpdateClientSizeFromNonClientSize(!double.IsNaN(this._content.Width), !double.IsNaN(this._content.Height));
			}
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x0004FD28 File Offset: 0x0004DF28
		private static void OnAllowMinMaxChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.ToolWindowHostWindow toolWindowHostWindow = d as global::Infragistics.Windows.Controls.ToolWindowHostWindow;
			global::System.Windows.Size size = toolWindowHostWindow.AddNonClientSize(new global::System.Windows.Size(100.0, 100.0));
			toolWindowHostWindow.VerifyWindowStyle();
			toolWindowHostWindow.UpdateNonClientSizeFromClientSize(true, true);
			if (toolWindowHostWindow.SizeToContent != global::System.Windows.SizeToContent.Manual && toolWindowHostWindow.UseSystemNonClientArea)
			{
				global::System.Windows.Size size2 = toolWindowHostWindow.AddNonClientSize(new global::System.Windows.Size(100.0, 100.0));
				if (size2 != size)
				{
					bool flag = toolWindowHostWindow.GetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsForcingSizeToContent);
					toolWindowHostWindow.SetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsForcingSizeToContent, true);
					try
					{
						global::System.Windows.SizeToContent sizeToContent = toolWindowHostWindow.SizeToContent;
						toolWindowHostWindow.SizeToContent = global::System.Windows.SizeToContent.Manual;
						toolWindowHostWindow.SizeToContent = sizeToContent;
					}
					finally
					{
						toolWindowHostWindow.SetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsForcingSizeToContent, flag);
					}
				}
			}
		}

		// Token: 0x0600153C RID: 5436 RVA: 0x0004FDE4 File Offset: 0x0004DFE4
		private static void OnSizeToContentChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x0600153D RID: 5437 RVA: 0x0004FDE6 File Offset: 0x0004DFE6
		private static void OnWidthChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.Controls.ToolWindowHostWindow)d).UpdateClientSizeFromNonClientSize(true, false);
		}

		// Token: 0x0600153E RID: 5438 RVA: 0x0004FDF8 File Offset: 0x0004DFF8
		private static void OnWindowStateChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.ToolWindowHostWindow toolWindowHostWindow = d as global::Infragistics.Windows.Controls.ToolWindowHostWindow;
			bool flag = toolWindowHostWindow.GetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsChangingWindowState);
			toolWindowHostWindow.SetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsChangingWindowState, true);
			try
			{
				toolWindowHostWindow.SetValue(global::Infragistics.Windows.Controls.ToolWindowHostWindow.WindowStateInternalProperty, e.NewValue);
			}
			finally
			{
				toolWindowHostWindow.SetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsChangingWindowState, flag);
			}
			toolWindowHostWindow.OnAfterWindowStateChanged((global::System.Windows.WindowState)e.NewValue);
			if (global::System.Windows.WindowState.Normal.Equals(e.NewValue))
			{
				toolWindowHostWindow.VerifyIsInView(false, true, false);
			}
		}

		// Token: 0x0600153F RID: 5439 RVA: 0x0004FE84 File Offset: 0x0004E084
		[global::System.Diagnostics.Conditional("DEBUG_RELATIVEPOS")]
		private static void OutputRelativePosInfo(object value, string category)
		{
		}

		// Token: 0x06001540 RID: 5440 RVA: 0x0004FE86 File Offset: 0x0004E086
		[global::System.Diagnostics.Conditional("DEBUG_SIZING")]
		private static void OutputSizeInfo(object value, string category)
		{
		}

		// Token: 0x06001541 RID: 5441 RVA: 0x0004FE88 File Offset: 0x0004E088
		private void ReleaseActivationHook()
		{
			if (global::System.IntPtr.Zero != this._hook)
			{
				global::System.IntPtr hook = this._hook;
				this._hook = global::System.IntPtr.Zero;
				global::Infragistics.Windows.Helpers.NativeWindowMethods.UnhookWindowsHookEx(hook);
			}
		}

		// Token: 0x06001542 RID: 5442 RVA: 0x0004FEC0 File Offset: 0x0004E0C0
		private void SetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags flag, bool set)
		{
			if (set)
			{
				this._flags |= flag;
				return;
			}
			this._flags &= ~flag;
		}

		// Token: 0x06001543 RID: 5443 RVA: 0x0004FEE4 File Offset: 0x0004E0E4
		private void SetRestoreBounds(global::System.IntPtr hwnd, global::System.Windows.Rect restoreBounds)
		{
			if (hwnd != global::System.IntPtr.Zero && !restoreBounds.IsEmpty)
			{
				global::Infragistics.Windows.Helpers.NativeWindowMethods.WINDOWPLACEMENT windowPlacement = global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowPlacement(hwnd);
				global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT point = this.ConvertFromLogicalPixels(restoreBounds.Left, restoreBounds.Top);
				global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT point2 = this.ConvertFromLogicalPixels(restoreBounds.Right, restoreBounds.Bottom);
				windowPlacement.rcNormalPosition = new global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT(point.X, point.Y, point2.X, point2.Y);
				global::Infragistics.Windows.Helpers.NativeWindowMethods.SetWindowPlacement(hwnd, ref windowPlacement);
			}
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x0004FF6C File Offset: 0x0004E16C
		private void SetRestoreToMaximize(global::System.IntPtr hwnd)
		{
			if (hwnd != global::System.IntPtr.Zero)
			{
				global::Infragistics.Windows.Helpers.NativeWindowMethods.WINDOWPLACEMENT windowPlacement = global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowPlacement(hwnd);
				if (this._content != null && windowPlacement.showCmd == 2 && base.WindowState == global::System.Windows.WindowState.Minimized)
				{
					int flags = windowPlacement.flags;
					if (this._content.RestoreToMaximized)
					{
						windowPlacement.flags |= 2;
					}
					else
					{
						windowPlacement.flags &= -3;
					}
					if (windowPlacement.flags != flags)
					{
						global::Infragistics.Windows.Helpers.NativeWindowMethods.SetWindowPlacement(hwnd, ref windowPlacement);
					}
				}
			}
		}

		// Token: 0x06001545 RID: 5445 RVA: 0x0004FFF4 File Offset: 0x0004E1F4
		private bool ShowContentContextMenu(global::System.IntPtr hwnd, global::System.Windows.Point? location)
		{
			bool flag = false;
			if (this._content != null && location != null)
			{
				global::System.Windows.Media.GeneralTransform generalTransform = base.TransformToDescendant(this._content);
				if (generalTransform != null)
				{
					location = new global::System.Windows.Point?(generalTransform.Transform(location.Value));
					flag = this._content.ShowSystemContextMenu(location.Value);
				}
			}
			if (!flag)
			{
				global::System.IntPtr systemMenuApi = global::Infragistics.Windows.Helpers.NativeWindowMethods.GetSystemMenuApi(hwnd, false);
				if (this._content == null || !this._content.AllowMaximize)
				{
					global::Infragistics.Windows.Helpers.NativeWindowMethods.EnableMenuItem(systemMenuApi, 61488, 1);
				}
				else
				{
					global::Infragistics.Windows.Helpers.NativeWindowMethods.EnableMenuItem(systemMenuApi, 61488, 0);
				}
				if (this._content == null || !this._content.AllowMinimize)
				{
					global::Infragistics.Windows.Helpers.NativeWindowMethods.EnableMenuItem(systemMenuApi, 61472, 1);
				}
				else
				{
					global::Infragistics.Windows.Helpers.NativeWindowMethods.EnableMenuItem(systemMenuApi, 61472, 0);
				}
				if (this._content == null || global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowState(hwnd) == global::System.Windows.WindowState.Normal)
				{
					global::Infragistics.Windows.Helpers.NativeWindowMethods.EnableMenuItem(systemMenuApi, 61728, 1);
				}
				else
				{
					global::Infragistics.Windows.Helpers.NativeWindowMethods.EnableMenuItem(systemMenuApi, 61728, 0);
				}
			}
			return flag;
		}

		// Token: 0x06001546 RID: 5446 RVA: 0x000500E8 File Offset: 0x0004E2E8
		private void SynchronizeLocation(bool updateFromTopLeft)
		{
			if (this.GetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsSynchronizingLocation))
			{
				return;
			}
			if (this.GetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsInOnContentChanged))
			{
				return;
			}
			if (global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowState(this) != global::System.Windows.WindowState.Normal)
			{
				return;
			}
			this.SetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsSynchronizingLocation, true);
			try
			{
				global::System.IntPtr handle = new global::System.Windows.Interop.WindowInteropHelper(this).Handle;
				double num = base.Top;
				double num2 = base.Left;
				if (global::System.IntPtr.Zero != handle)
				{
					global::Infragistics.Windows.Helpers.NativeWindowMethods.WINDOWINFO windowInfo = global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowInfo(handle);
					global::System.Windows.Point point = this.ConvertToLogicalPixels(windowInfo.rcWindow.left, windowInfo.rcWindow.top);
					num = point.Y;
					num2 = point.X;
				}
				if (updateFromTopLeft)
				{
					this.InternalLeft = num2;
					this.InternalTop = num;
				}
				else
				{
					if (!this.InternalTop.Equals(num))
					{
						base.Top = this.InternalTop;
					}
					if (!this.InternalLeft.Equals(num2))
					{
						base.Left = this.InternalLeft;
					}
				}
			}
			finally
			{
				this.SetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsSynchronizingLocation, false);
			}
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x000501E4 File Offset: 0x0004E3E4
		private static void UpdateAllowClose(global::System.Windows.Window window, bool allowClose)
		{
			global::System.Windows.Interop.WindowInteropHelper windowInteropHelper = new global::System.Windows.Interop.WindowInteropHelper(window);
			global::System.IntPtr handle = windowInteropHelper.Handle;
			if (global::System.IntPtr.Zero != handle)
			{
				global::System.IntPtr systemMenuApi = global::Infragistics.Windows.Helpers.NativeWindowMethods.GetSystemMenuApi(handle, false);
				if (global::System.IntPtr.Zero != systemMenuApi)
				{
					int num = 0;
					if (allowClose)
					{
						num &= -2;
					}
					else
					{
						num |= 1;
					}
					global::Infragistics.Windows.Helpers.NativeWindowMethods.EnableMenuItem(systemMenuApi, 61536, num);
				}
			}
		}

		// Token: 0x06001548 RID: 5448 RVA: 0x00050240 File Offset: 0x0004E440
		private void UpdateClientSizeFromNonClientSize(bool updateWidth, bool updateHeight)
		{
			if (this.GetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsInOnContentChanged))
			{
				return;
			}
			double width = base.Width;
			double height = base.Height;
			if (updateWidth && (base.SizeToContent & global::System.Windows.SizeToContent.Width) == global::System.Windows.SizeToContent.Width)
			{
				width = double.NaN;
			}
			if (updateHeight && (base.SizeToContent & global::System.Windows.SizeToContent.Height) == global::System.Windows.SizeToContent.Height)
			{
				height = double.NaN;
			}
			if (base.WindowState != global::System.Windows.WindowState.Normal || global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowState(this) != base.WindowState)
			{
				return;
			}
			this.UpdateClientSizeFromNonClientSize(updateWidth, updateHeight, width, height);
		}

		// Token: 0x06001549 RID: 5449 RVA: 0x000502B8 File Offset: 0x0004E4B8
		private void UpdateClientSizeFromNonClientSize(bool updateWidth, bool updateHeight, double width, double height)
		{
			if (this._content != null && this._content.IsCalculatingSizeWithoutContent)
			{
				return;
			}
			if (this.GetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsChangingWindowState))
			{
				return;
			}
			this.UpdateForClientSize(false, ref width, ref height);
			if (updateHeight && !global::Infragistics.Windows.Controls.ToolWindowHostWindow.AreClose(height, this.ClientHeight))
			{
				this.ClientHeight = (double.IsNaN(height) ? height : global::System.Math.Max(height, 0.0));
			}
			if (updateWidth && !global::Infragistics.Windows.Controls.ToolWindowHostWindow.AreClose(width, this.ClientWidth))
			{
				this.ClientWidth = (double.IsNaN(width) ? width : global::System.Math.Max(width, 0.0));
			}
		}

		// Token: 0x0600154A RID: 5450 RVA: 0x0005035C File Offset: 0x0004E55C
		private bool UpdateForClientSize(bool addNonClient, ref double width, ref double height)
		{
			global::System.Windows.Interop.WindowInteropHelper windowInteropHelper = new global::System.Windows.Interop.WindowInteropHelper(this);
			global::System.IntPtr handle = windowInteropHelper.Handle;
			double num3;
			double num4;
			if (handle == global::System.IntPtr.Zero)
			{
				if (!this.UseSystemNonClientArea)
				{
					return false;
				}
				global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT rect = default(global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT);
				rect.right = 200;
				rect.bottom = 200;
				int num = 13107200;
				num |= 12582912;
				if (this._content != null && this._content.AllowMinimize)
				{
					num |= 131072;
				}
				if (this._content != null && this._content.AllowMaximize)
				{
					num |= 65536;
				}
				int num2 = 256;
				if (base.WindowStyle == global::System.Windows.WindowStyle.SingleBorderWindow)
				{
					num2 |= 1;
				}
				else
				{
					num2 |= 128;
				}
				switch (base.ResizeMode)
				{
				case global::System.Windows.ResizeMode.CanResize:
				case global::System.Windows.ResizeMode.CanResizeWithGrip:
					num |= 262144;
					break;
				}
				if (!global::Infragistics.Windows.Helpers.NativeWindowMethods.AdjustWindowRectExApi(ref rect, num, false, num2))
				{
					return false;
				}
				global::System.Windows.Point point = this.ConvertToLogicalPixels(rect.right - rect.left - 200, rect.bottom - rect.top - 200);
				num3 = point.X;
				num4 = point.Y;
			}
			else
			{
				if (!this.UseSystemNonClientArea)
				{
					return false;
				}
				global::Infragistics.Windows.Helpers.NativeWindowMethods.WINDOWINFO windowInfo = global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowInfo(handle);
				global::System.Windows.Point point2 = this.ConvertToLogicalPixels(windowInfo.rcWindow.Width - windowInfo.rcClient.Width, windowInfo.rcWindow.Height - windowInfo.rcClient.Height);
				num3 = point2.X;
				num4 = point2.Y;
			}
			if (!addNonClient)
			{
				num3 *= -1.0;
				num4 *= -1.0;
			}
			if (!double.IsNaN(width))
			{
				width += num3;
			}
			if (!double.IsNaN(height))
			{
				height += num4;
			}
			if (addNonClient)
			{
				if (width > base.MaxWidth)
				{
					width = base.MaxWidth;
				}
				if (height > base.MaxHeight)
				{
					height = base.MaxHeight;
				}
			}
			return true;
		}

		// Token: 0x0600154B RID: 5451 RVA: 0x00050574 File Offset: 0x0004E774
		private void UpdateNonClientSizeFromClientSize(bool updateWidth, bool updateHeight)
		{
			if (this._content != null && this._content.IsCalculatingSizeWithoutContent)
			{
				return;
			}
			if (base.WindowState != global::System.Windows.WindowState.Normal)
			{
				return;
			}
			if (this._content == null)
			{
				return;
			}
			if (this.GetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsChangingWindowState))
			{
				return;
			}
			double num = this.ClientWidth;
			double num2 = this.ClientHeight;
			this.UpdateForClientSize(true, ref num, ref num2);
			global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT point = this.ConvertFromLogicalPixels(num, num2);
			global::System.Windows.Point point2 = this.ConvertToLogicalPixels(point.X, point.Y);
			if (!double.IsNaN(num))
			{
				num = point2.X;
			}
			if (!double.IsNaN(num2))
			{
				num2 = point2.Y;
			}
			if (base.WindowState != global::System.Windows.WindowState.Normal || global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowState(this) != global::System.Windows.WindowState.Normal)
			{
				updateWidth = (updateHeight = false);
			}
			if ((base.SizeToContent & global::System.Windows.SizeToContent.Height) == global::System.Windows.SizeToContent.Height)
			{
				updateHeight = false;
			}
			if ((base.SizeToContent & global::System.Windows.SizeToContent.Width) == global::System.Windows.SizeToContent.Width)
			{
				updateWidth = false;
			}
			if (updateHeight && !global::Infragistics.Windows.Controls.ToolWindowHostWindow.AreClose(num2, base.Height))
			{
				base.Height = num2;
			}
			if (updateWidth && !global::Infragistics.Windows.Controls.ToolWindowHostWindow.AreClose(num, base.Width))
			{
				base.Width = num;
			}
		}

		// Token: 0x0600154C RID: 5452 RVA: 0x00050674 File Offset: 0x0004E874
		private void UpdateRelativePosition()
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = base.Content as global::Infragistics.Windows.Controls.ToolWindow;
			if (toolWindow != null)
			{
				global::System.Windows.Rect rect = new global::System.Windows.Rect(base.Left, base.Top, base.ActualWidth, base.ActualHeight);
				if (this.OwnerRect.IsEmpty)
				{
					return;
				}
				global::System.Windows.FrameworkElement owner = toolWindow.Owner;
				if (owner == null)
				{
					return;
				}
				if (rect.Width == 0.0 && rect.Height == 0.0)
				{
					return;
				}
				if (this.UpdatingRelativePosition)
				{
					return;
				}
				if (global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowState(this) != global::System.Windows.WindowState.Normal)
				{
					return;
				}
				this.UpdatingRelativePosition = true;
				try
				{
					global::System.Windows.Point point;
					try
					{
						point = owner.PointToScreen(default(global::System.Windows.Point));
						point = this.ConvertToLogicalPixels((int)point.X, (int)point.Y);
						if (owner.FlowDirection == global::System.Windows.FlowDirection.RightToLeft)
						{
							point.X -= owner.ActualWidth;
						}
					}
					catch (global::System.InvalidOperationException)
					{
						return;
					}
					global::System.Windows.Rect ownerRect = new global::System.Windows.Rect(point.X, point.Y, owner.ActualWidth, owner.ActualHeight);
					toolWindow.AdjustRelativeRect(ownerRect, ref rect);
					global::System.Windows.Interop.WindowInteropHelper windowInteropHelper = new global::System.Windows.Interop.WindowInteropHelper(this);
					if (windowInteropHelper.Handle == global::System.IntPtr.Zero)
					{
						base.Left = rect.Left;
						base.Top = rect.Top;
						base.Width = rect.Width;
						base.Height = rect.Height;
					}
					else
					{
						if (toolWindow.UsesRelativePosition)
						{
							if (toolWindow.VerticalAlignmentMode == global::Infragistics.Windows.Controls.ToolWindowAlignmentMode.UseAlignment)
							{
								if (toolWindow.VerticalAlignment == global::System.Windows.VerticalAlignment.Stretch)
								{
									base.ClearValue(global::System.Windows.FrameworkElement.HeightProperty);
								}
								base.ClearValue(global::System.Windows.Window.TopProperty);
								base.CoerceValue(global::System.Windows.Window.TopProperty);
							}
							if (toolWindow.HorizontalAlignmentMode == global::Infragistics.Windows.Controls.ToolWindowAlignmentMode.UseAlignment)
							{
								if (toolWindow.HorizontalAlignment == global::System.Windows.HorizontalAlignment.Stretch)
								{
									base.ClearValue(global::System.Windows.FrameworkElement.WidthProperty);
								}
								base.ClearValue(global::System.Windows.Window.LeftProperty);
								base.CoerceValue(global::System.Windows.Window.LeftProperty);
							}
						}
						global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT other = this.ConvertFromLogicalPixels(rect.Left, rect.Top);
						global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT other2 = this.ConvertFromLogicalPixels(rect.Width, rect.Height);
						global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT point2 = this.ConvertFromLogicalPixels(base.Left, base.Top);
						global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT point3 = this.ConvertFromLogicalPixels(base.ActualWidth, base.ActualHeight);
						if (!point2.Equals(other) || !point3.Equals(other2))
						{
							global::Infragistics.Windows.Helpers.NativeWindowMethods.SetWindowPosApi(windowInteropHelper.Handle, global::System.IntPtr.Zero, other.X, other.Y, other2.X, other2.Y, 532);
						}
					}
				}
				finally
				{
					this.UpdatingRelativePosition = false;
				}
			}
		}

		// Token: 0x0600154D RID: 5453 RVA: 0x00050924 File Offset: 0x0004EB24
		private void VerifyIsInView(bool force, bool async, bool ensureFullyInView)
		{
			if (this._content == null || (!this._content.KeepOnScreen && !force))
			{
				return;
			}
			if (base.WindowState == global::System.Windows.WindowState.Minimized)
			{
				return;
			}
			if (async)
			{
				base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Background, new global::System.Threading.SendOrPostCallback(this.VerifyIsInViewImpl), ensureFullyInView);
				return;
			}
			this.VerifyIsInViewImpl(ensureFullyInView);
		}

		// Token: 0x0600154E RID: 5454 RVA: 0x00050984 File Offset: 0x0004EB84
		private void VerifyIsInViewImpl(object param)
		{
			if (this._content == null)
			{
				return;
			}
			global::System.Windows.Rect logicalScreenRect = new global::System.Windows.Rect(base.Left, base.Top, base.ActualWidth, base.ActualHeight);
			if (this._content.WindowState == global::System.Windows.WindowState.Normal)
			{
				global::System.Windows.Point? point = global::Infragistics.Windows.Utilities.CalculateOnScreenLocation(logicalScreenRect, this, true.Equals(param));
				if (point != null)
				{
					if (this._content != null && this._content.HorizontalAlignmentMode == global::Infragistics.Windows.Controls.ToolWindowAlignmentMode.Manual)
					{
						base.Left = point.Value.X;
					}
					if (this._content != null && this._content.VerticalAlignmentMode == global::Infragistics.Windows.Controls.ToolWindowAlignmentMode.Manual)
					{
						base.Top = point.Value.Y;
						return;
					}
				}
			}
			else if (this._content.WindowState == global::System.Windows.WindowState.Maximized)
			{
				global::System.Windows.Interop.WindowInteropHelper windowInteropHelper = new global::System.Windows.Interop.WindowInteropHelper(this);
				global::System.Windows.Point point2;
				if (windowInteropHelper.Handle == global::System.IntPtr.Zero)
				{
					point2 = new global::System.Windows.Point((double)global::Infragistics.Windows.Utilities.ConvertFromLogicalPixels(base.Left + base.ActualWidth / 2.0, this), (double)global::Infragistics.Windows.Utilities.ConvertFromLogicalPixels(base.Top + base.ActualHeight / 2.0, this));
				}
				else
				{
					global::Infragistics.Windows.Helpers.NativeWindowMethods.WINDOWINFO windowInfo = global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowInfo(windowInteropHelper.Handle);
					point2 = new global::System.Windows.Point((double)(windowInfo.rcWindow.left + windowInfo.rcWindow.Width / 2), (double)(windowInfo.rcWindow.top + windowInfo.rcWindow.Height / 2));
				}
				if (!global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWorkArea(point2).Contains(point2))
				{
					((global::Infragistics.Windows.Controls.IToolWindowHost)this).SetWindowState(global::System.Windows.WindowState.Normal);
					((global::Infragistics.Windows.Controls.IToolWindowHost)this).SetWindowState(global::System.Windows.WindowState.Maximized);
				}
			}
		}

		// Token: 0x0600154F RID: 5455 RVA: 0x00050B20 File Offset: 0x0004ED20
		private void VerifyRelativePositionBinding()
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = base.Content as global::Infragistics.Windows.Controls.ToolWindow;
			base.LayoutUpdated -= this.OnLayoutUpdated;
			if (toolWindow == null || (toolWindow.VerticalAlignmentMode == global::Infragistics.Windows.Controls.ToolWindowAlignmentMode.Manual && toolWindow.HorizontalAlignmentMode == global::Infragistics.Windows.Controls.ToolWindowAlignmentMode.Manual))
			{
				global::System.Windows.Data.BindingOperations.ClearBinding(this, global::Infragistics.Windows.Controls.ToolWindowHostWindow.OwnerRectProperty);
			}
			else
			{
				global::System.Windows.Window owner = base.Owner;
				if (owner == null)
				{
					global::System.Windows.Data.BindingOperations.ClearBinding(this, global::Infragistics.Windows.Controls.ToolWindowHostWindow.OwnerRectProperty);
				}
				else
				{
					global::System.Windows.Data.MultiBinding multiBinding = new global::System.Windows.Data.MultiBinding();
					multiBinding.Bindings.Add(global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.Window.LeftProperty, global::System.Windows.Data.BindingMode.OneWay, owner));
					multiBinding.Bindings.Add(global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.Window.TopProperty, global::System.Windows.Data.BindingMode.OneWay, owner));
					multiBinding.Bindings.Add(global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.FrameworkElement.ActualWidthProperty, global::System.Windows.Data.BindingMode.OneWay, owner));
					multiBinding.Bindings.Add(global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.FrameworkElement.ActualHeightProperty, global::System.Windows.Data.BindingMode.OneWay, owner));
					multiBinding.Converter = global::Infragistics.Windows.Controls.ToolWindowHostWindow.WindowPositionToRectConverter.Instance;
					base.SetBinding(global::Infragistics.Windows.Controls.ToolWindowHostWindow.OwnerRectProperty, multiBinding);
				}
				base.LayoutUpdated += this.OnLayoutUpdated;
			}
			bool flag = false;
			bool flag2 = false;
			if (toolWindow != null)
			{
				flag = ((toolWindow.HorizontalAlignmentMode != global::Infragistics.Windows.Controls.ToolWindowAlignmentMode.UseAlignment || toolWindow.HorizontalAlignment != global::System.Windows.HorizontalAlignment.Stretch) && double.IsNaN(toolWindow.Width));
				flag2 = ((toolWindow.VerticalAlignmentMode != global::Infragistics.Windows.Controls.ToolWindowAlignmentMode.UseAlignment || toolWindow.VerticalAlignment != global::System.Windows.VerticalAlignment.Stretch) && double.IsNaN(toolWindow.Height));
				if (toolWindow.WindowState == global::System.Windows.WindowState.Maximized && !toolWindow.GetRestoreBounds(false).IsEmpty)
				{
					flag2 = (flag = false);
				}
			}
			if (flag && flag2)
			{
				base.SizeToContent = global::System.Windows.SizeToContent.WidthAndHeight;
				return;
			}
			if (flag)
			{
				base.SizeToContent = global::System.Windows.SizeToContent.Width;
				return;
			}
			if (flag2)
			{
				base.SizeToContent = global::System.Windows.SizeToContent.Height;
				return;
			}
			base.SizeToContent = global::System.Windows.SizeToContent.Manual;
		}

		// Token: 0x06001550 RID: 5456 RVA: 0x00050CAC File Offset: 0x0004EEAC
		private void VerifyTitleBinding()
		{
			if (this._content != null)
			{
				global::System.Windows.Data.BindingOperations.SetBinding(this, global::System.Windows.Window.TitleProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.Controls.ToolWindow.TitleProperty, global::System.Windows.Data.BindingMode.OneWay, this._content));
				return;
			}
			global::System.Windows.Data.BindingOperations.ClearBinding(this, global::System.Windows.Window.TitleProperty);
		}

		// Token: 0x06001551 RID: 5457 RVA: 0x00050CE0 File Offset: 0x0004EEE0
		private void VerifyWindowStyle()
		{
			bool allowsTransparency;
			if (this._content != null && this.UseSystemNonClientArea)
			{
				allowsTransparency = false;
				if (this._content.AllowMinimize || this._content.AllowMaximize)
				{
					base.WindowStyle = global::System.Windows.WindowStyle.SingleBorderWindow;
				}
				else
				{
					base.WindowStyle = global::System.Windows.WindowStyle.ToolWindow;
				}
			}
			else
			{
				base.WindowStyle = global::System.Windows.WindowStyle.None;
				allowsTransparency = (this._content != null && this._content.AllowsTransparencyResolved);
			}
			try
			{
				if (this._content != null && new global::System.Windows.Interop.WindowInteropHelper(this).Handle == global::System.IntPtr.Zero)
				{
					base.AllowsTransparency = allowsTransparency;
				}
			}
			catch (global::System.InvalidOperationException)
			{
			}
			if (this._content != null)
			{
				this.VerifyWindowStyleBits();
			}
		}

		// Token: 0x06001552 RID: 5458 RVA: 0x00050D94 File Offset: 0x0004EF94
		private void VerifyWindowStyleBits()
		{
			if (this._content == null)
			{
				return;
			}
			global::System.Windows.Interop.WindowInteropHelper windowInteropHelper = new global::System.Windows.Interop.WindowInteropHelper(this);
			this.VerifyWindowStyleBits(windowInteropHelper.Handle);
		}

		// Token: 0x06001553 RID: 5459 RVA: 0x00050DC0 File Offset: 0x0004EFC0
		private void VerifyWindowStyleBits(global::System.IntPtr hwnd)
		{
			if (hwnd != global::System.IntPtr.Zero)
			{
				global::System.IntPtr windowLong = global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowLong(hwnd, -16);
				global::Infragistics.Windows.Controls.ToolWindow toolWindow = base.Content as global::Infragistics.Windows.Controls.ToolWindow;
				global::System.IntPtr intPtr = windowLong;
				if (toolWindow == null || !toolWindow.AllowMaximize)
				{
					intPtr = global::Infragistics.Windows.Helpers.NativeWindowMethods.RemoveBits(intPtr, 65536);
				}
				else
				{
					intPtr = global::Infragistics.Windows.Helpers.NativeWindowMethods.AddBits(intPtr, 65536);
				}
				if (toolWindow == null || !toolWindow.AllowMinimize)
				{
					intPtr = global::Infragistics.Windows.Helpers.NativeWindowMethods.RemoveBits(intPtr, 131072);
				}
				else
				{
					intPtr = global::Infragistics.Windows.Helpers.NativeWindowMethods.AddBits(intPtr, 131072);
				}
				if (windowLong != intPtr)
				{
					global::Infragistics.Windows.Helpers.NativeWindowMethods.SetWindowLong(hwnd, -16, intPtr);
				}
				windowLong = global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowLong(hwnd, -20);
				intPtr = windowLong;
				if (base.WindowStyle == global::System.Windows.WindowStyle.SingleBorderWindow)
				{
					intPtr = global::Infragistics.Windows.Helpers.NativeWindowMethods.AddBits(intPtr, 1);
				}
				else
				{
					intPtr = global::Infragistics.Windows.Helpers.NativeWindowMethods.RemoveBits(intPtr, 1);
				}
				if (base.WindowStyle == global::System.Windows.WindowStyle.None && global::System.Environment.Version.Major <= 3)
				{
					intPtr = global::Infragistics.Windows.Helpers.NativeWindowMethods.AddBits(intPtr, 128);
				}
				else if (base.WindowStyle != global::System.Windows.WindowStyle.ToolWindow)
				{
					intPtr = global::Infragistics.Windows.Helpers.NativeWindowMethods.RemoveBits(intPtr, 128);
				}
				if (windowLong != intPtr)
				{
					global::Infragistics.Windows.Helpers.NativeWindowMethods.SetWindowLong(hwnd, -20, intPtr);
				}
			}
		}

		// Token: 0x06001554 RID: 5460 RVA: 0x00050EC4 File Offset: 0x0004F0C4
		private global::System.IntPtr WmContextMenu(global::System.IntPtr hwnd, global::System.IntPtr wParam, global::System.IntPtr lParam, ref bool handled)
		{
			global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT point = global::Infragistics.Windows.Helpers.NativeWindowMethods.PointFromLParam(lParam);
			global::System.Windows.Point? location = null;
			if (base.WindowState == global::System.Windows.WindowState.Minimized)
			{
				if (this.UseSystemNonClientArea)
				{
					return global::System.IntPtr.Zero;
				}
				if (point.X == -1 && point.Y == -1)
				{
					global::Infragistics.Windows.Helpers.NativeWindowMethods.GetCursorPos(ref point);
				}
				this.ShowContentContextMenu(hwnd, null);
				global::System.IntPtr systemMenuApi = global::Infragistics.Windows.Helpers.NativeWindowMethods.GetSystemMenuApi(hwnd, false);
				if (systemMenuApi != global::System.IntPtr.Zero)
				{
					handled = true;
					uint fuFlags = 258U;
					int num = global::Infragistics.Windows.Helpers.NativeWindowMethods.TrackPopupMenuEx(systemMenuApi, fuFlags, point.X, point.Y, hwnd, global::System.IntPtr.Zero);
					if (num != 0)
					{
						global::Infragistics.Windows.Helpers.NativeWindowMethods.PostMessage(hwnd, 274, new global::System.IntPtr(num), global::System.IntPtr.Zero);
					}
					return global::System.IntPtr.Zero;
				}
			}
			if (point.X != -1 || point.Y != -1)
			{
				switch ((int)global::Infragistics.Windows.Helpers.NativeWindowMethods.SendMessageApi(hwnd, 132, global::System.IntPtr.Zero, lParam).ToInt64())
				{
				case 1:
				case 4:
				case 6:
				case 7:
				case 10:
				case 11:
				case 12:
				case 13:
				case 14:
				case 15:
				case 16:
				case 17:
				case 18:
					return global::System.IntPtr.Zero;
				}
				location = new global::System.Windows.Point?(base.PointFromScreen(new global::System.Windows.Point((double)point.X, (double)point.Y)));
			}
			if (this.ShowContentContextMenu(hwnd, location))
			{
				handled = true;
				return global::System.IntPtr.Zero;
			}
			return global::System.IntPtr.Zero;
		}

		// Token: 0x06001555 RID: 5461 RVA: 0x00051054 File Offset: 0x0004F254
		private global::System.IntPtr WmExitSizeMove(global::System.IntPtr hwnd, ref bool handled)
		{
			this.SetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsInMoveSize, false);
			this.SetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsMovingWindow, false);
			bool flag = this.GetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.TrackWmMoving);
			this.SetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.TrackWmMoving, false);
			if (this._content != null && flag && this._content.OnExitMove())
			{
				handled = true;
			}
			return global::System.IntPtr.Zero;
		}

		// Token: 0x06001556 RID: 5462 RVA: 0x000510AC File Offset: 0x0004F2AC
		private global::System.IntPtr WmEnterSizeMove(global::System.IntPtr hwnd)
		{
			this.SetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsInMoveSize, true);
			if (this._content != null && this.GetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsMovingWindow))
			{
				bool set = this._content.OnEnterMove();
				this.SetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.TrackWmMoving, set);
			}
			return global::System.IntPtr.Zero;
		}

		// Token: 0x06001557 RID: 5463 RVA: 0x000510F4 File Offset: 0x0004F2F4
		private global::System.IntPtr WmGetMinMaxInfo(global::System.IntPtr hwnd, global::System.IntPtr lParam)
		{
			if (this.UseSystemNonClientArea)
			{
				return global::System.IntPtr.Zero;
			}
			global::System.IntPtr intPtr = global::System.IntPtr.Zero;
			if (this.GetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsInMoveSize))
			{
				int messagePos = global::Infragistics.Windows.Helpers.NativeWindowMethods.GetMessagePos();
				int x = global::Infragistics.Windows.Helpers.NativeWindowMethods.SignedLoWord(messagePos);
				int y = global::Infragistics.Windows.Helpers.NativeWindowMethods.SignedHiWord(messagePos);
				intPtr = global::Infragistics.Windows.Helpers.NativeWindowMethods.MonitorFromPoint(new global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT(x, y), 2);
			}
			else
			{
				intPtr = global::Infragistics.Windows.Helpers.NativeWindowMethods.MonitorFromWindow(hwnd, 2U);
			}
			if (global::System.IntPtr.Zero != intPtr)
			{
				global::System.IntPtr intPtr2 = global::Infragistics.Windows.Helpers.NativeWindowMethods.MonitorFromPoint(new global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT(0, 0), 1);
				global::Infragistics.Windows.Helpers.NativeWindowMethods.MONITORINFO monitorinfo = default(global::Infragistics.Windows.Helpers.NativeWindowMethods.MONITORINFO);
				monitorinfo.cbSize = (uint)global::System.Runtime.InteropServices.Marshal.SizeOf(monitorinfo.GetType());
				if (global::Infragistics.Windows.Helpers.NativeWindowMethods.GetMonitorInfo(intPtr, out monitorinfo) && global::System.IntPtr.Zero != intPtr2)
				{
					global::Infragistics.Windows.Helpers.NativeWindowMethods.MONITORINFO monitorinfo2 = default(global::Infragistics.Windows.Helpers.NativeWindowMethods.MONITORINFO);
					monitorinfo2.cbSize = (uint)global::System.Runtime.InteropServices.Marshal.SizeOf(monitorinfo.GetType());
					if (intPtr == intPtr2)
					{
						monitorinfo2 = monitorinfo;
					}
					else if (!global::Infragistics.Windows.Helpers.NativeWindowMethods.GetMonitorInfo(intPtr2, out monitorinfo2))
					{
						return global::System.IntPtr.Zero;
					}
					global::Infragistics.Windows.Helpers.NativeWindowMethods.MINMAXINFO minmaxinfo = (global::Infragistics.Windows.Helpers.NativeWindowMethods.MINMAXINFO)global::System.Runtime.InteropServices.Marshal.PtrToStructure(lParam, typeof(global::Infragistics.Windows.Helpers.NativeWindowMethods.MINMAXINFO));
					minmaxinfo.ptMaxSize.X = global::System.Math.Abs(monitorinfo.rcWork.right - monitorinfo.rcWork.left);
					minmaxinfo.ptMaxSize.Y = global::System.Math.Abs(monitorinfo.rcWork.bottom - monitorinfo.rcWork.top);
					if (monitorinfo.rcMonitor.Width != monitorinfo2.rcMonitor.Width || monitorinfo.rcMonitor.Height != monitorinfo2.rcMonitor.Height)
					{
						minmaxinfo.ptMaxSize.X = monitorinfo2.rcMonitor.Width;
						minmaxinfo.ptMaxSize.Y = monitorinfo2.rcMonitor.Height - 1;
					}
					minmaxinfo.ptMaxPosition.X = 0;
					minmaxinfo.ptMaxPosition.Y = 0;
					global::System.Runtime.InteropServices.Marshal.StructureToPtr(minmaxinfo, lParam, false);
				}
			}
			return global::System.IntPtr.Zero;
		}

		// Token: 0x06001558 RID: 5464 RVA: 0x000512EC File Offset: 0x0004F4EC
		private global::System.IntPtr WmMoving(global::System.IntPtr hwnd, global::System.IntPtr wParam, global::System.IntPtr lParam, ref bool handled)
		{
			if (!this.GetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.TrackWmMoving))
			{
				return global::System.IntPtr.Zero;
			}
			if (this._content != null)
			{
				int messagePos = global::Infragistics.Windows.Helpers.NativeWindowMethods.GetMessagePos();
				int num = global::Infragistics.Windows.Helpers.NativeWindowMethods.SignedLoWord(messagePos);
				int num2 = global::Infragistics.Windows.Helpers.NativeWindowMethods.SignedHiWord(messagePos);
				global::Infragistics.Windows.Helpers.NativeWindowMethods.WINDOWINFO windowInfo = global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowInfo(hwnd);
				int left = windowInfo.rcClient.left;
				int top = windowInfo.rcClient.top;
				global::System.Windows.Point pt = this.ConvertToLogicalPixels(num - left, num2 - top);
				global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT rect = (global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT)global::System.Runtime.InteropServices.Marshal.PtrToStructure(lParam, typeof(global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT));
				global::System.Windows.Rect logicalScreenRect = new global::System.Windows.Rect(global::Infragistics.Windows.Utilities.ConvertToLogicalPixels(rect.left), global::Infragistics.Windows.Utilities.ConvertToLogicalPixels(rect.top), global::Infragistics.Windows.Utilities.ConvertToLogicalPixels(rect.Width), global::Infragistics.Windows.Utilities.ConvertToLogicalPixels(rect.Height));
				this._content.OnWindowMoving(pt, global::System.Windows.Input.Mouse.PrimaryDevice, logicalScreenRect);
			}
			return global::System.IntPtr.Zero;
		}

		// Token: 0x06001559 RID: 5465 RVA: 0x000513C4 File Offset: 0x0004F5C4
		private global::System.IntPtr WmNcCalcSize(global::System.IntPtr hwnd, global::System.IntPtr wParam, global::System.IntPtr lParam, ref bool handled)
		{
			if (!this.UseSystemNonClientArea && wParam.ToInt64() == 1L)
			{
				global::Infragistics.Windows.Helpers.NativeWindowMethods.NCCALCSIZE_PARAMS nccalcsize_PARAMS = (global::Infragistics.Windows.Helpers.NativeWindowMethods.NCCALCSIZE_PARAMS)global::System.Runtime.InteropServices.Marshal.PtrToStructure(lParam, typeof(global::Infragistics.Windows.Helpers.NativeWindowMethods.NCCALCSIZE_PARAMS));
				if (global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowState(hwnd) == global::System.Windows.WindowState.Maximized)
				{
					int screenHeight = global::Infragistics.Windows.Helpers.NativeWindowMethods.GetScreenHeight(hwnd);
					int num = nccalcsize_PARAMS.rectProposed.Height + nccalcsize_PARAMS.rectProposed.top - screenHeight;
					if (num > 0)
					{
						nccalcsize_PARAMS.rectProposed.bottom = nccalcsize_PARAMS.rectProposed.bottom - (num + 1);
						global::System.Runtime.InteropServices.Marshal.StructureToPtr(nccalcsize_PARAMS, lParam, false);
					}
				}
				handled = true;
			}
			return global::System.IntPtr.Zero;
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x00051458 File Offset: 0x0004F658
		private global::System.IntPtr WmNcHitTest(global::System.IntPtr hwnd, global::System.IntPtr wParam, global::System.IntPtr lParam, ref bool handled)
		{
			global::System.Windows.Point point = new global::System.Windows.Point((double)global::Infragistics.Windows.Helpers.NativeWindowMethods.GetXFromLParam(lParam), (double)global::Infragistics.Windows.Helpers.NativeWindowMethods.GetYFromLParam(lParam));
			point = base.PointFromScreen(point);
			global::System.Windows.DependencyObject dependencyObject = base.InputHitTest(point) as global::System.Windows.DependencyObject;
			global::System.Windows.FrameworkElement frameworkElement = dependencyObject as global::System.Windows.FrameworkElement;
			if (dependencyObject != null && frameworkElement == null)
			{
				frameworkElement = (global::Infragistics.Windows.Utilities.GetAncestorFromType(dependencyObject, typeof(global::System.Windows.FrameworkElement), true) as global::System.Windows.FrameworkElement);
			}
			if (frameworkElement != null && frameworkElement.TemplatedParent == this._content)
			{
				global::Infragistics.Windows.Helpers.NativeWindowMethods.HitTestResults hitTestCode = global::Infragistics.Windows.Controls.ToolWindow.GetHitTestCode(frameworkElement);
				handled = true;
				return new global::System.IntPtr((int)hitTestCode);
			}
			if (!this.UseSystemNonClientArea)
			{
				global::Infragistics.Windows.Helpers.NativeWindowMethods.HitTestResults value = (dependencyObject != null) ? global::Infragistics.Windows.Helpers.NativeWindowMethods.HitTestResults.HTCLIENT : global::Infragistics.Windows.Helpers.NativeWindowMethods.HitTestResults.HTTRANSPARENT;
				handled = true;
				return new global::System.IntPtr((int)value);
			}
			return global::System.IntPtr.Zero;
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x000514F8 File Offset: 0x0004F6F8
		private global::System.IntPtr WmNclButtonDblClk(global::System.IntPtr hwnd, global::System.IntPtr wParam, global::System.IntPtr lParam, ref bool handled)
		{
			if (this._content != null && global::Infragistics.Windows.Helpers.NativeWindowMethods.IntPtrToInt32(wParam) == 2)
			{
				int num = global::Infragistics.Windows.Helpers.NativeWindowMethods.GetXFromLParam(lParam);
				int num2 = global::Infragistics.Windows.Helpers.NativeWindowMethods.GetYFromLParam(lParam);
				global::Infragistics.Windows.Helpers.NativeWindowMethods.WINDOWINFO windowInfo = global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowInfo(hwnd);
				num -= windowInfo.rcWindow.left;
				num2 -= windowInfo.rcWindow.top;
				global::System.Windows.Point pt = this.ConvertToLogicalPixels(num, num2);
				if (this._content.OnDoubleClickCaption(pt, global::System.Windows.Input.Mouse.PrimaryDevice))
				{
					handled = true;
					return global::System.IntPtr.Zero;
				}
			}
			return global::System.IntPtr.Zero;
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x00051574 File Offset: 0x0004F774
		private global::System.IntPtr WmShowWindow(global::System.IntPtr hwnd, global::System.IntPtr wParam, global::System.IntPtr lParam, ref bool handled)
		{
			if (global::System.IntPtr.Zero == lParam && global::System.IntPtr.Zero != wParam)
			{
				global::Infragistics.Windows.Controls.ToolWindow toolWindow = base.Content as global::Infragistics.Windows.Controls.ToolWindow;
				if (toolWindow.IsDelayedMinMaxPending)
				{
					toolWindow.CalculateMinMaxExtents(false);
				}
			}
			else if (global::System.IntPtr.Zero != wParam && lParam.ToInt32() == 3 && global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowPlacement(hwnd).showCmd == 3)
			{
				global::Infragistics.Windows.Helpers.NativeWindowMethods.ShowWindow(hwnd, 8);
			}
			return global::System.IntPtr.Zero;
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x000515F0 File Offset: 0x0004F7F0
		private global::System.IntPtr WmSize(global::System.IntPtr hwnd, global::System.IntPtr wParam, global::System.IntPtr lParam, ref bool handled)
		{
			if (!this.UseSystemNonClientArea)
			{
				if (global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowState(hwnd) == global::System.Windows.WindowState.Minimized)
				{
					int value = global::Infragistics.Windows.Helpers.NativeWindowMethods.IntPtrToInt32(lParam);
					int x = global::Infragistics.Windows.Helpers.NativeWindowMethods.SignedLoWord(value);
					int y = global::Infragistics.Windows.Helpers.NativeWindowMethods.SignedHiWord(value);
					global::System.Windows.Point point = this.ConvertToLogicalPixels(x, y);
					global::System.Windows.Size size = new global::System.Windows.Size(point.X, point.Y);
					base.Measure(size);
					base.Arrange(new global::System.Windows.Rect(size));
				}
				if (!base.AllowsTransparency && global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowState(hwnd) != global::System.Windows.WindowState.Minimized && !this.GetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsSendingWmSize))
				{
					int value2 = global::Infragistics.Windows.Helpers.NativeWindowMethods.IntPtrToInt32(lParam);
					int num = global::Infragistics.Windows.Helpers.NativeWindowMethods.SignedLoWord(value2);
					int num2 = global::Infragistics.Windows.Helpers.NativeWindowMethods.SignedHiWord(value2);
					global::Infragistics.Windows.Helpers.NativeWindowMethods.SIZE nonClientSize = global::Infragistics.Windows.Helpers.NativeWindowMethods.GetNonClientSize(hwnd);
					num = global::System.Math.Max(num - nonClientSize.width, 0);
					num2 = global::System.Math.Max(num2 - nonClientSize.height, 0);
					global::System.IntPtr lparam = global::Infragistics.Windows.Helpers.NativeWindowMethods.EncodeSize(num, num2);
					try
					{
						this.SetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsSendingWmSize, true);
						global::Infragistics.Windows.Helpers.NativeWindowMethods.SendMessageApi(hwnd, 5, wParam, lparam);
					}
					finally
					{
						this.SetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsSendingWmSize, false);
					}
					handled = true;
					return global::System.IntPtr.Zero;
				}
			}
			return global::System.IntPtr.Zero;
		}

		// Token: 0x0600155E RID: 5470 RVA: 0x00051708 File Offset: 0x0004F908
		private global::System.IntPtr WmStyleChanging(global::System.IntPtr hwnd, global::System.IntPtr wParam, global::System.IntPtr lParam, ref bool handled)
		{
			int num = wParam.ToInt32();
			if (num == -16)
			{
				global::Infragistics.Windows.Helpers.NativeWindowMethods.STYLESTRUCT stylestruct = (global::Infragistics.Windows.Helpers.NativeWindowMethods.STYLESTRUCT)global::System.Runtime.InteropServices.Marshal.PtrToStructure(lParam, typeof(global::Infragistics.Windows.Helpers.NativeWindowMethods.STYLESTRUCT));
				global::Infragistics.Windows.Controls.ToolWindow content = this._content;
				if (content == null || !content.AllowMaximize)
				{
					stylestruct.styleNew &= -65537;
				}
				else
				{
					stylestruct.styleNew |= 65536;
				}
				if (content == null || !content.AllowMinimize)
				{
					stylestruct.styleNew &= -131073;
				}
				else
				{
					stylestruct.styleNew |= 131072;
				}
				global::System.Runtime.InteropServices.Marshal.StructureToPtr(stylestruct, lParam, false);
			}
			else if (num == -20)
			{
				global::Infragistics.Windows.Helpers.NativeWindowMethods.STYLESTRUCT stylestruct2 = (global::Infragistics.Windows.Helpers.NativeWindowMethods.STYLESTRUCT)global::System.Runtime.InteropServices.Marshal.PtrToStructure(lParam, typeof(global::Infragistics.Windows.Helpers.NativeWindowMethods.STYLESTRUCT));
				if (base.WindowStyle == global::System.Windows.WindowStyle.SingleBorderWindow)
				{
					stylestruct2.styleNew |= 1;
				}
				else
				{
					stylestruct2.styleNew &= -2;
				}
				global::System.Runtime.InteropServices.Marshal.StructureToPtr(stylestruct2, lParam, false);
			}
			return global::System.IntPtr.Zero;
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x00051810 File Offset: 0x0004FA10
		private global::System.IntPtr WmSysCommand(global::System.IntPtr hwnd, global::System.IntPtr wParam, global::System.IntPtr lParam, ref bool handled)
		{
			int num = wParam.ToInt32() & 65520;
			global::Infragistics.Windows.Controls.ToolWindow content = this._content;
			int num2 = num;
			if (num2 <= 61488)
			{
				if (num2 != 61456)
				{
					if (num2 != 61472)
					{
						if (num2 == 61488)
						{
							if (content == null || !content.AllowMaximize)
							{
								handled = true;
								return global::System.IntPtr.Zero;
							}
						}
					}
					else if (content == null || !content.AllowMinimize)
					{
						handled = true;
						return global::System.IntPtr.Zero;
					}
				}
				else if (content != null)
				{
					int num3;
					int num4;
					if (lParam != global::System.IntPtr.Zero)
					{
						num3 = global::Infragistics.Windows.Helpers.NativeWindowMethods.GetXFromLParam(lParam);
						num4 = global::Infragistics.Windows.Helpers.NativeWindowMethods.GetYFromLParam(lParam);
					}
					else
					{
						global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT point = default(global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT);
						if (global::Infragistics.Windows.Helpers.NativeWindowMethods.GetCursorPos(ref point) == 0)
						{
							return global::System.IntPtr.Zero;
						}
						num3 = point.X;
						num4 = point.Y;
					}
					global::System.Windows.Point pt = content.PointFromScreen(new global::System.Windows.Point((double)num3, (double)num4));
					bool flag = false;
					bool isNonClientTouchDrag = content.IsNonClientTouchDrag;
					try
					{
						content.IsNonClientTouchDrag = ((global::Infragistics.Windows.Helpers.NativeWindowMethods.GetBits(global::Infragistics.Windows.Helpers.NativeWindowMethods.GetMessageExtraInfo()) & (long)((ulong)-11446528)) == (long)((ulong)-11446528));
						flag = content.OnDragCaption(pt, global::System.Windows.Input.Mouse.PrimaryDevice);
					}
					finally
					{
						content.IsNonClientTouchDrag = isNonClientTouchDrag;
					}
					if (flag)
					{
						handled = true;
						return global::System.IntPtr.Zero;
					}
					this.SetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsMovingWindow, true);
					global::System.IntPtr result = global::Infragistics.Windows.Helpers.NativeWindowMethods.DefWindowProc(hwnd, 274, wParam, lParam);
					if (this.GetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsMovingWindow) && !this.GetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsInMoveSize))
					{
						content.OnMoveCancelled();
					}
					handled = true;
					return result;
				}
			}
			else if (num2 != 61584 && num2 != 61696)
			{
				if (num2 == 61728)
				{
					global::System.Windows.WindowState windowState = global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowState(hwnd);
					if (windowState == global::System.Windows.WindowState.Maximized && (content == null || !content.AllowMaximize))
					{
						handled = true;
						return global::System.IntPtr.Zero;
					}
				}
			}
			else if (this.ShowContentContextMenu(hwnd, null))
			{
				handled = true;
				return global::System.IntPtr.Zero;
			}
			return global::System.IntPtr.Zero;
		}

		// Token: 0x06001560 RID: 5472 RVA: 0x000519FC File Offset: 0x0004FBFC
		private global::System.IntPtr WmWindowPosChanging(global::System.IntPtr hwnd, global::System.IntPtr wParam, global::System.IntPtr lParam, ref bool handled)
		{
			global::Infragistics.Windows.Helpers.NativeWindowMethods.WINDOWPOS windowpos = (global::Infragistics.Windows.Helpers.NativeWindowMethods.WINDOWPOS)global::System.Runtime.InteropServices.Marshal.PtrToStructure(lParam, typeof(global::Infragistics.Windows.Helpers.NativeWindowMethods.WINDOWPOS));
			global::System.Windows.WindowState windowState = global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowState(hwnd);
			if (this.GetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsInMoveSize) && (windowpos.flags & 1) == 0 && windowState == global::System.Windows.WindowState.Normal)
			{
				global::Infragistics.Windows.Helpers.NativeWindowMethods.WINDOWINFO windowInfo = global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowInfo(hwnd);
				if (windowInfo.rcWindow.Width != windowpos.cx || windowInfo.rcWindow.Height != windowpos.cy)
				{
					base.SizeToContent = global::System.Windows.SizeToContent.Manual;
				}
			}
			if (((windowpos.flags & 32768) == 32768 || (windowpos.flags & 2) != 2) && windowState == global::System.Windows.WindowState.Maximized && !this.UseSystemNonClientArea)
			{
				global::System.Windows.Point point = new global::System.Windows.Point((double)(windowpos.x + windowpos.cx / 2), (double)(windowpos.y + windowpos.cy / 2));
				global::System.IntPtr intPtr = global::Infragistics.Windows.Helpers.NativeWindowMethods.MonitorFromPoint(new global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT((int)point.X, (int)point.Y), 2);
				global::System.IntPtr intPtr2 = global::Infragistics.Windows.Helpers.NativeWindowMethods.MonitorFromPoint(new global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT(0, 0), 1);
				if (intPtr != intPtr2)
				{
					global::Infragistics.Windows.Helpers.NativeWindowMethods.MONITORINFO monitorinfo = default(global::Infragistics.Windows.Helpers.NativeWindowMethods.MONITORINFO);
					monitorinfo.cbSize = (uint)global::System.Runtime.InteropServices.Marshal.SizeOf(monitorinfo.GetType());
					if (global::Infragistics.Windows.Helpers.NativeWindowMethods.GetMonitorInfo(intPtr, out monitorinfo))
					{
						global::Infragistics.Windows.Helpers.NativeWindowMethods.MONITORINFO monitorinfo2 = default(global::Infragistics.Windows.Helpers.NativeWindowMethods.MONITORINFO);
						monitorinfo2.cbSize = (uint)global::System.Runtime.InteropServices.Marshal.SizeOf(monitorinfo2.GetType());
						if (global::Infragistics.Windows.Helpers.NativeWindowMethods.GetMonitorInfo(intPtr2, out monitorinfo2) && (monitorinfo.rcMonitor.Width != monitorinfo2.rcMonitor.Width || monitorinfo.rcMonitor.Height != monitorinfo2.rcMonitor.Height))
						{
							windowpos.cx = monitorinfo.rcWork.Width;
							windowpos.cy = monitorinfo.rcWork.Height;
						}
					}
				}
				global::System.Windows.Rect workArea = global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWorkArea(point);
				windowpos.x = (int)workArea.X;
				windowpos.y = (int)workArea.Y;
				global::System.Runtime.InteropServices.Marshal.StructureToPtr(windowpos, lParam, false);
			}
			if ((windowpos.flags & 32768) == 32768)
			{
				if (windowState == global::System.Windows.WindowState.Maximized && base.SizeToContent != global::System.Windows.SizeToContent.Manual)
				{
					base.CoerceValue(global::System.Windows.Window.SizeToContentProperty);
				}
				this.SetRestoreToMaximize(hwnd);
			}
			if (base.Owner == null && (windowpos.flags & 2) != 0 && (windowpos.flags & 1) != 0)
			{
				base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::Infragistics.Windows.Controls.ToolWindow.MethodInvoker(this.UpdateRelativePosition));
			}
			return global::System.IntPtr.Zero;
		}

		// Token: 0x06001561 RID: 5473 RVA: 0x00051C68 File Offset: 0x0004FE68
		private global::System.IntPtr WndProc(global::System.IntPtr hwnd, int message, global::System.IntPtr wParam, global::System.IntPtr lParam, ref bool handled)
		{
			global::System.IntPtr result;
			try
			{
				this._wndProcCount++;
				result = this.WndProcImpl(hwnd, message, wParam, lParam, ref handled);
			}
			finally
			{
				this._wndProcCount--;
			}
			return result;
		}

		// Token: 0x06001562 RID: 5474 RVA: 0x00051CB4 File Offset: 0x0004FEB4
		private global::System.IntPtr WndProcImpl(global::System.IntPtr hwnd, int message, global::System.IntPtr wParam, global::System.IntPtr lParam, ref bool handled)
		{
			if (message <= 134)
			{
				if (message <= 24)
				{
					if (message == 5)
					{
						return this.WmSize(hwnd, wParam, lParam, ref handled);
					}
					if (message == 24)
					{
						return this.WmShowWindow(hwnd, wParam, lParam, ref handled);
					}
				}
				else
				{
					if (message == 36)
					{
						return this.WmGetMinMaxInfo(hwnd, lParam);
					}
					switch (message)
					{
					case 70:
						return this.WmWindowPosChanging(hwnd, wParam, lParam, ref handled);
					case 71:
						break;
					default:
						switch (message)
						{
						case 123:
							return this.WmContextMenu(hwnd, wParam, lParam, ref handled);
						case 124:
							return this.WmStyleChanging(hwnd, wParam, lParam, ref handled);
						case 126:
							this.VerifyIsInView(false, true, true);
							break;
						case 131:
							return this.WmNcCalcSize(hwnd, wParam, lParam, ref handled);
						case 132:
							return this.WmNcHitTest(hwnd, wParam, lParam, ref handled);
						case 133:
							if (!this.UseSystemNonClientArea && !global::Infragistics.Windows.Helpers.NativeWindowMethods.IsDWMCompositionEnabled)
							{
								handled = true;
							}
							break;
						case 134:
							if (!this.UseSystemNonClientArea)
							{
								handled = true;
								return global::Infragistics.Windows.Helpers.NativeWindowMethods.DefWindowProc(hwnd, message, wParam, new global::System.IntPtr(-1));
							}
							break;
						}
						break;
					}
				}
			}
			else if (message <= 175)
			{
				if (message == 163)
				{
					return this.WmNclButtonDblClk(hwnd, wParam, lParam, ref handled);
				}
				switch (message)
				{
				case 174:
				case 175:
					if (!this.UseSystemNonClientArea)
					{
						handled = true;
					}
					break;
				}
			}
			else
			{
				if (message == 274)
				{
					return this.WmSysCommand(hwnd, wParam, lParam, ref handled);
				}
				if (message == 534)
				{
					return this.WmMoving(hwnd, wParam, lParam, ref handled);
				}
				switch (message)
				{
				case 561:
					return this.WmEnterSizeMove(hwnd);
				case 562:
					return this.WmExitSizeMove(hwnd, ref handled);
				}
			}
			return global::System.IntPtr.Zero;
		}

		// Token: 0x06001563 RID: 5475 RVA: 0x00051E88 File Offset: 0x00050088
		void global::Infragistics.Windows.Controls.IToolWindowHost.DragMove(global::System.Windows.Input.MouseEventArgs e)
		{
			if (base.WindowState != global::System.Windows.WindowState.Normal)
			{
				base.VerifyAccess();
				if (global::System.Windows.Input.Mouse.LeftButton != global::System.Windows.Input.MouseButtonState.Pressed)
				{
					throw new global::System.InvalidOperationException();
				}
				global::System.Windows.Interop.WindowInteropHelper windowInteropHelper = new global::System.Windows.Interop.WindowInteropHelper(this);
				if (windowInteropHelper.Handle != global::System.IntPtr.Zero)
				{
					global::Infragistics.Windows.Helpers.NativeWindowMethods.SendMessageApi(windowInteropHelper.Handle, 274, new global::System.IntPtr(61458), global::System.IntPtr.Zero);
					global::Infragistics.Windows.Helpers.NativeWindowMethods.SendMessageApi(windowInteropHelper.Handle, 514, global::System.IntPtr.Zero, global::System.IntPtr.Zero);
					return;
				}
			}
			else
			{
				base.DragMove();
			}
		}

		// Token: 0x06001564 RID: 5476 RVA: 0x00051F0C File Offset: 0x0005010C
		void global::Infragistics.Windows.Controls.IToolWindowHost.DragResize(global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation location, global::System.Windows.Input.Cursor cursor, global::System.Windows.Input.MouseEventArgs e)
		{
		}

		// Token: 0x06001565 RID: 5477 RVA: 0x00051F0E File Offset: 0x0005010E
		void global::Infragistics.Windows.Controls.IToolWindowHost.Activate()
		{
			base.Activate();
		}

		// Token: 0x06001566 RID: 5478 RVA: 0x00051F17 File Offset: 0x00050117
		void global::Infragistics.Windows.Controls.IToolWindowHost.Close()
		{
			this.CloseHelper();
		}

		// Token: 0x06001567 RID: 5479 RVA: 0x00051F1F File Offset: 0x0005011F
		void global::Infragistics.Windows.Controls.IToolWindowHost.RelativePositionStateChanged()
		{
			this.VerifyRelativePositionBinding();
			this.UpdateRelativePosition();
		}

		// Token: 0x06001568 RID: 5480 RVA: 0x00051F2D File Offset: 0x0005012D
		void global::Infragistics.Windows.Controls.IToolWindowHost.BringToFront()
		{
			this.BringToFront();
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06001569 RID: 5481 RVA: 0x00051F35 File Offset: 0x00050135
		bool global::Infragistics.Windows.Controls.IToolWindowHost.HandlesDelayedMinMaxRequests
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x0600156A RID: 5482 RVA: 0x00051F38 File Offset: 0x00050138
		bool global::Infragistics.Windows.Controls.IToolWindowHost.IsWindow
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x0600156B RID: 5483 RVA: 0x00051F3B File Offset: 0x0005013B
		bool global::Infragistics.Windows.Controls.IToolWindowHost.AllowsTransparency
		{
			get
			{
				return base.AllowsTransparency;
			}
		}

		// Token: 0x0600156C RID: 5484 RVA: 0x00051F43 File Offset: 0x00050143
		bool global::Infragistics.Windows.Controls.IToolWindowHost.SupportsAllowTransparency(bool allowsTransparency)
		{
			return this._content != null && (!this._content.UseOSNonClientArea || !allowsTransparency);
		}

		// Token: 0x0600156D RID: 5485 RVA: 0x00051F62 File Offset: 0x00050162
		void global::Infragistics.Windows.Controls.IToolWindowHost.EnsureOnScreen(bool fullyInView)
		{
			this.VerifyIsInView(true, true, fullyInView);
		}

		// Token: 0x0600156E RID: 5486 RVA: 0x00051F70 File Offset: 0x00050170
		global::System.Windows.Rect global::Infragistics.Windows.Controls.IToolWindowHost.GetRestoreBounds()
		{
			global::System.Windows.Rect restoreBounds = base.RestoreBounds;
			if (restoreBounds.IsEmpty && this._content != null)
			{
				restoreBounds = this._content.GetRestoreBounds(false);
			}
			return restoreBounds;
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x00051FA4 File Offset: 0x000501A4
		void global::Infragistics.Windows.Controls.IToolWindowHost.SetRestoreBounds(global::System.Windows.Rect restoreBounds)
		{
			if (!restoreBounds.IsEmpty)
			{
				global::System.Windows.Interop.WindowInteropHelper windowInteropHelper = new global::System.Windows.Interop.WindowInteropHelper(this);
				global::System.IntPtr handle = windowInteropHelper.Handle;
				if (handle != global::System.IntPtr.Zero)
				{
					this.SetRestoreBounds(handle, restoreBounds);
					return;
				}
				if (this._content != null)
				{
					this._content.SetRestoreBounds(restoreBounds, false);
				}
			}
		}

		// Token: 0x06001570 RID: 5488 RVA: 0x00051FF4 File Offset: 0x000501F4
		void global::Infragistics.Windows.Controls.IToolWindowHost.SetWindowState(global::System.Windows.WindowState state)
		{
			bool flag = this.GetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsChangingWindowState);
			this.SetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsChangingWindowState, true);
			try
			{
				base.WindowState = state;
			}
			finally
			{
				this.SetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsChangingWindowState, flag);
			}
			this.OnAfterWindowStateChanged(state);
		}

		// Token: 0x06001571 RID: 5489 RVA: 0x00052048 File Offset: 0x00050248
		global::System.Windows.Rect global::Infragistics.Windows.Controls.IToolWindowHost.GetWindowBounds()
		{
			global::System.Windows.Interop.WindowInteropHelper windowInteropHelper = new global::System.Windows.Interop.WindowInteropHelper(this);
			if (windowInteropHelper.Handle == global::System.IntPtr.Zero)
			{
				return global::System.Windows.Rect.Empty;
			}
			global::Infragistics.Windows.Helpers.NativeWindowMethods.WINDOWINFO windowInfo = global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowInfo(windowInteropHelper.Handle);
			global::System.Windows.Point point = this.ConvertToLogicalPixels(windowInfo.rcWindow.left, windowInfo.rcWindow.top);
			global::System.Windows.Point point2 = this.ConvertToLogicalPixels(windowInfo.rcWindow.right, windowInfo.rcWindow.bottom);
			return global::Infragistics.Windows.Utilities.RectFromPoints(point, point2);
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06001572 RID: 5490 RVA: 0x000520C5 File Offset: 0x000502C5
		bool global::Infragistics.Windows.Controls.IToolWindowHost.IsUsingOsNonClientArea
		{
			get
			{
				return this.UseSystemNonClientArea;
			}
		}

		// Token: 0x04000A8A RID: 2698
		private global::Infragistics.Windows.Controls.ToolWindow _content;

		// Token: 0x04000A8B RID: 2699
		private global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags _flags;

		// Token: 0x04000A8C RID: 2700
		private global::System.IntPtr _hook;

		// Token: 0x04000A8D RID: 2701
		private global::Infragistics.Windows.Helpers.NativeWindowMethods.HookProc _hookCallback;

		// Token: 0x04000A8E RID: 2702
		private int _wndProcCount;

		// Token: 0x04000A8F RID: 2703
		private static readonly global::System.Windows.DependencyProperty WindowStateInternalProperty = global::System.Windows.DependencyProperty.Register("WindowStateInternal", typeof(global::System.Windows.WindowState), typeof(global::Infragistics.Windows.Controls.ToolWindowHostWindow), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.WindowState.Normal, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindowHostWindow.OnWindowStateInternalChanged)));

		// Token: 0x04000A90 RID: 2704
		public static readonly global::System.Windows.DependencyProperty AllowCloseProperty = global::Infragistics.Windows.Controls.ToolWindow.AllowCloseProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.ToolWindowHostWindow), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindowHostWindow.OnAllowCloseChanged)));

		// Token: 0x04000A91 RID: 2705
		internal static readonly global::System.Windows.DependencyProperty ClientHeightProperty = global::System.Windows.DependencyProperty.Register("ClientHeight", typeof(double), typeof(global::Infragistics.Windows.Controls.ToolWindowHostWindow), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindowHostWindow.OnClientHeightChanged)));

		// Token: 0x04000A92 RID: 2706
		internal static readonly global::System.Windows.DependencyProperty ClientWidthProperty = global::System.Windows.DependencyProperty.Register("ClientWidth", typeof(double), typeof(global::Infragistics.Windows.Controls.ToolWindowHostWindow), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindowHostWindow.OnClientWidthChanged)));

		// Token: 0x04000A93 RID: 2707
		private static readonly global::System.Windows.DependencyProperty InternalLeftProperty = global::System.Windows.DependencyProperty.Register("InternalLeft", typeof(double), typeof(global::Infragistics.Windows.Controls.ToolWindowHostWindow), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindowHostWindow.OnInternalLeftTopChanged)));

		// Token: 0x04000A94 RID: 2708
		private static readonly global::System.Windows.DependencyProperty InternalTopProperty = global::System.Windows.DependencyProperty.Register("InternalTop", typeof(double), typeof(global::Infragistics.Windows.Controls.ToolWindowHostWindow), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindowHostWindow.OnInternalLeftTopChanged)));

		// Token: 0x04000A95 RID: 2709
		private static readonly global::System.Windows.DependencyProperty OwnerRectProperty = global::System.Windows.DependencyProperty.Register("OwnerRect", typeof(global::System.Windows.Rect), typeof(global::Infragistics.Windows.Controls.ToolWindowHostWindow), new global::System.Windows.FrameworkPropertyMetadata(default(global::System.Windows.Rect), new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindowHostWindow.OnOwnerRectChanged)));

		// Token: 0x04000A96 RID: 2710
		private static readonly global::System.Windows.DependencyProperty UseSystemNonClientAreaProperty = global::System.Windows.DependencyProperty.Register("UseSystemNonClientArea", typeof(bool), typeof(global::Infragistics.Windows.Controls.ToolWindowHostWindow), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindowHostWindow.OnUseSystemNonClientAreaChanged)));

		// Token: 0x02000215 RID: 533
		private class WindowPositionToRectConverter : global::System.Windows.Data.IMultiValueConverter
		{
			// Token: 0x06001573 RID: 5491 RVA: 0x000520CD File Offset: 0x000502CD
			private WindowPositionToRectConverter()
			{
			}

			// Token: 0x170004CA RID: 1226
			// (get) Token: 0x06001575 RID: 5493 RVA: 0x000520E1 File Offset: 0x000502E1
			public static global::System.Windows.Data.IMultiValueConverter Instance
			{
				get
				{
					return global::Infragistics.Windows.Controls.ToolWindowHostWindow.WindowPositionToRectConverter.instance;
				}
			}

			// Token: 0x06001576 RID: 5494 RVA: 0x000520E8 File Offset: 0x000502E8
			object global::System.Windows.Data.IMultiValueConverter.Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
			{
				double num = (double)values[0];
				double num2 = (double)values[1];
				double num3 = (double)values[2];
				double num4 = (double)values[3];
				if (double.IsNaN(num) || double.IsNaN(num2) || double.IsNaN(num3) || double.IsNaN(num4))
				{
					return global::System.Windows.Rect.Empty;
				}
				return new global::System.Windows.Rect(num, num2, num3, num4);
			}

			// Token: 0x06001577 RID: 5495 RVA: 0x00052154 File Offset: 0x00050354
			object[] global::System.Windows.Data.IMultiValueConverter.ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
			{
				return new object[]
				{
					global::System.Windows.Data.Binding.DoNothing
				};
			}

			// Token: 0x04000A97 RID: 2711
			private static readonly global::System.Windows.Data.IMultiValueConverter instance = new global::Infragistics.Windows.Controls.ToolWindowHostWindow.WindowPositionToRectConverter();
		}

		// Token: 0x02000216 RID: 534
		internal class DeferShowHelper : global::Infragistics.Windows.Controls.ToolWindow.IDeferShow
		{
			// Token: 0x06001578 RID: 5496 RVA: 0x00052171 File Offset: 0x00050371
			internal DeferShowHelper(global::Infragistics.Windows.Controls.ToolWindowHostWindow window)
			{
				this._window = window;
			}

			// Token: 0x06001579 RID: 5497 RVA: 0x00052180 File Offset: 0x00050380
			public void Show(bool activate)
			{
				using (new global::Infragistics.Windows.Helpers.TempValueReplacement(this._window, global::System.Windows.UIElement.VisibilityProperty, global::Infragistics.KnownBoxes.VisibilityVisibleBox))
				{
					this._window.Show(activate);
				}
			}

			// Token: 0x0600157A RID: 5498 RVA: 0x000521CC File Offset: 0x000503CC
			public void Cancel()
			{
				this._window.Close();
			}

			// Token: 0x04000A98 RID: 2712
			private global::Infragistics.Windows.Controls.ToolWindowHostWindow _window;
		}

		// Token: 0x02000217 RID: 535
		private class CoerceProxy
		{
			// Token: 0x0600157B RID: 5499 RVA: 0x000521D9 File Offset: 0x000503D9
			internal CoerceProxy(global::System.Windows.CoerceValueCallback baseCallback)
			{
				this._baseCallback = baseCallback;
			}

			// Token: 0x0600157C RID: 5500 RVA: 0x000521E8 File Offset: 0x000503E8
			public virtual object CoerceValue(global::System.Windows.DependencyObject d, object baseValue)
			{
				if (this._baseCallback != null)
				{
					return this._baseCallback(d, baseValue);
				}
				return baseValue;
			}

			// Token: 0x04000A99 RID: 2713
			private global::System.Windows.CoerceValueCallback _baseCallback;
		}

		// Token: 0x02000218 RID: 536
		private class TopLeftCoerceProxy : global::Infragistics.Windows.Controls.ToolWindowHostWindow.CoerceProxy
		{
			// Token: 0x0600157D RID: 5501 RVA: 0x00052201 File Offset: 0x00050401
			internal TopLeftCoerceProxy(global::System.Windows.DependencyProperty property, global::System.Windows.CoerceValueCallback baseCallback) : base(baseCallback)
			{
				this._property = property;
			}

			// Token: 0x0600157E RID: 5502 RVA: 0x00052214 File Offset: 0x00050414
			public override object CoerceValue(global::System.Windows.DependencyObject d, object baseValue)
			{
				if (!global::Infragistics.CoreUtilities.Antirecursion.Enter(d, this._property, true))
				{
					return baseValue;
				}
				object result2;
				try
				{
					global::Infragistics.Windows.Controls.ToolWindowHostWindow toolWindowHostWindow = d as global::Infragistics.Windows.Controls.ToolWindowHostWindow;
					if (toolWindowHostWindow != null && toolWindowHostWindow.WindowState != global::System.Windows.WindowState.Normal)
					{
						if (global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowState(toolWindowHostWindow) == global::System.Windows.WindowState.Normal)
						{
							return baseValue;
						}
						global::System.Windows.Interop.WindowInteropHelper windowInteropHelper = new global::System.Windows.Interop.WindowInteropHelper(toolWindowHostWindow);
						global::System.IntPtr handle = windowInteropHelper.Handle;
						if (handle != global::System.IntPtr.Zero)
						{
							global::Infragistics.Windows.Helpers.NativeWindowMethods.WINDOWPLACEMENT windowPlacement = global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowPlacement(handle);
							object result = base.CoerceValue(d, baseValue);
							if (!windowPlacement.Equals(global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowPlacement(handle)))
							{
								global::Infragistics.Windows.Helpers.NativeWindowMethods.SetWindowPlacement(handle, ref windowPlacement);
							}
							return result;
						}
					}
					result2 = base.CoerceValue(d, baseValue);
				}
				finally
				{
					global::Infragistics.CoreUtilities.Antirecursion.Exit(d, this._property);
				}
				return result2;
			}

			// Token: 0x04000A9A RID: 2714
			private global::System.Windows.DependencyProperty _property;
		}

		// Token: 0x02000219 RID: 537
		[global::System.Flags]
		private enum InternalFlags
		{
			// Token: 0x04000A9C RID: 2716
			UpdatingRelativePosition = 1,
			// Token: 0x04000A9D RID: 2717
			IsSendingWmSize = 2,
			// Token: 0x04000A9E RID: 2718
			IsSynchronizingLocation = 4,
			// Token: 0x04000A9F RID: 2719
			UseSystemNonClientArea = 8,
			// Token: 0x04000AA0 RID: 2720
			IsInOnContentChanged = 16,
			// Token: 0x04000AA1 RID: 2721
			IsForcingSizeToContent = 32,
			// Token: 0x04000AA2 RID: 2722
			TrackWmMoving = 64,
			// Token: 0x04000AA3 RID: 2723
			IsMovingWindow = 128,
			// Token: 0x04000AA4 RID: 2724
			IsInMoveSize = 256,
			// Token: 0x04000AA5 RID: 2725
			IsChangingWindowState = 512
		}
	}
}
