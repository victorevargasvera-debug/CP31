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
	// Token: 0x02000245 RID: 581
	internal class ToolWindowHostWindow : global::System.Windows.Window, global::Infragistics.Windows.Controls.IToolWindowHost
	{
		// Token: 0x060016EE RID: 5870 RVA: 0x0005491C File Offset: 0x00052B1C
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
			global::System.Windows.UIElement.VisibilityProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ToolWindowHostWindow), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindowHostWindow.OnVisibilityChanged)));
			global::System.Windows.FrameworkElementFactory visualTree = new global::System.Windows.FrameworkElementFactory(typeof(global::System.Windows.Controls.ContentPresenter));
			global::System.Windows.Controls.ControlTemplate controlTemplate = new global::System.Windows.Controls.ControlTemplate(typeof(global::Infragistics.Windows.Controls.ToolWindowHostWindow));
			controlTemplate.VisualTree = visualTree;
			controlTemplate.Seal();
			global::System.Windows.Controls.Control.TemplateProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ToolWindowHostWindow), new global::System.Windows.FrameworkPropertyMetadata(controlTemplate));
		}

		// Token: 0x060016EF RID: 5871 RVA: 0x00054DF0 File Offset: 0x00052FF0
		internal ToolWindowHostWindow()
		{
			this.SetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.UseSystemNonClientArea, (bool)base.GetValue(global::Infragistics.Windows.Controls.ToolWindowHostWindow.UseSystemNonClientAreaProperty));
		}

		// Token: 0x060016F0 RID: 5872 RVA: 0x00054E10 File Offset: 0x00053010
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

		// Token: 0x060016F1 RID: 5873 RVA: 0x00054EDC File Offset: 0x000530DC
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

		// Token: 0x060016F2 RID: 5874 RVA: 0x00054F73 File Offset: 0x00053173
		protected override void OnActivated(global::System.EventArgs e)
		{
			if (this._content != null)
			{
				this._content.SetValue(global::Infragistics.Windows.Controls.ToolWindow.IsActivePropertyKey, global::Infragistics.KnownBoxes.TrueBox);
			}
			base.OnActivated(e);
		}

		// Token: 0x060016F3 RID: 5875 RVA: 0x00054F9C File Offset: 0x0005319C
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

		// Token: 0x060016F4 RID: 5876 RVA: 0x00054FFF File Offset: 0x000531FF
		protected override void OnClosed(global::System.EventArgs e)
		{
			base.OnClosed(e);
			this.OnClosedImpl(false);
		}

		// Token: 0x060016F5 RID: 5877 RVA: 0x00055010 File Offset: 0x00053210
		private void OnClosedImpl(bool clearDeferredShow)
		{
			base.LayoutUpdated -= this.OnLayoutUpdated;
			if (this._content != null)
			{
				global::Infragistics.Windows.Controls.ToolWindow content = this._content;
				base.Content = null;
				content.OnClosedInternal(clearDeferredShow);
			}
			this.ReleaseActivationHook();
		}

		// Token: 0x060016F6 RID: 5878 RVA: 0x00055054 File Offset: 0x00053254
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

		// Token: 0x060016F7 RID: 5879 RVA: 0x000550C4 File Offset: 0x000532C4
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
				base.SetBinding(global::Infragistics.Windows.Controls.ToolWindowHostWindow.UseSystemNonClientAreaProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.Controls.ToolWindow.IsUsingOSNonClientAreaProperty, global::System.Windows.Data.BindingMode.OneWay, toolWindow));
				base.SetBinding(global::System.Windows.FrameworkElement.MaxWidthProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.FrameworkElement.MaxWidthProperty, global::System.Windows.Data.BindingMode.OneWay, toolWindow));
				base.SetBinding(global::System.Windows.FrameworkElement.MaxHeightProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.FrameworkElement.MaxHeightProperty, global::System.Windows.Data.BindingMode.OneWay, toolWindow));
				base.SetBinding(global::System.Windows.FrameworkElement.MinWidthProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.FrameworkElement.MinWidthProperty, global::System.Windows.Data.BindingMode.OneWay, toolWindow, new global::Infragistics.Windows.Controls.ToolWindowHostWindow.NonClientSizeConverter(this, true, true)));
				base.SetBinding(global::System.Windows.FrameworkElement.MinHeightProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.FrameworkElement.MinHeightProperty, global::System.Windows.Data.BindingMode.OneWay, toolWindow, new global::Infragistics.Windows.Controls.ToolWindowHostWindow.NonClientSizeConverter(this, false, true)));
				base.SetBinding(global::System.Windows.FrameworkElement.FlowDirectionProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.FrameworkElement.FlowDirectionProperty, global::System.Windows.Data.BindingMode.OneWay, toolWindow));
				base.SetBinding(global::Infragistics.Windows.Controls.ToolWindowHostWindow.VisibilityInternalProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.UIElement.VisibilityProperty, global::System.Windows.Data.BindingMode.TwoWay, toolWindow));
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
			if (toolWindow == null)
			{
				this.ReleaseActivationHook();
			}
		}

		// Token: 0x060016F8 RID: 5880 RVA: 0x00055408 File Offset: 0x00053608
		private static void OnVisibilityInternalChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.ToolWindowHostWindow toolWindowHostWindow = d as global::Infragistics.Windows.Controls.ToolWindowHostWindow;
			if (toolWindowHostWindow._content == null)
			{
				return;
			}
			global::System.Windows.Visibility visibility = (global::System.Windows.Visibility)e.NewValue;
			if (visibility == toolWindowHostWindow.Visibility)
			{
				toolWindowHostWindow._content.Visibility = visibility;
				return;
			}
			toolWindowHostWindow.Visibility = visibility;
		}

		// Token: 0x060016F9 RID: 5881 RVA: 0x00055450 File Offset: 0x00053650
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

		// Token: 0x060016FA RID: 5882 RVA: 0x00055497 File Offset: 0x00053697
		protected override void OnDeactivated(global::System.EventArgs e)
		{
			if (this._content != null)
			{
				this._content.ClearValue(global::Infragistics.Windows.Controls.ToolWindow.IsActivePropertyKey);
			}
			base.OnDeactivated(e);
		}

		// Token: 0x060016FB RID: 5883 RVA: 0x000554B8 File Offset: 0x000536B8
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			if (e.Key == global::System.Windows.Input.Key.System && e.SystemKey == global::System.Windows.Input.Key.F4 && global::System.Windows.Input.ModifierKeys.Alt == (e.KeyboardDevice.Modifiers & global::System.Windows.Input.ModifierKeys.Alt) && !this.AllowClose)
			{
				e.Handled = true;
			}
			base.OnKeyDown(e);
		}

		// Token: 0x060016FC RID: 5884 RVA: 0x000554F7 File Offset: 0x000536F7
		protected override void OnLocationChanged(global::System.EventArgs e)
		{
			base.OnLocationChanged(e);
			this.SynchronizeLocation(true);
			base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Send, new global::Infragistics.Windows.Controls.ToolWindow.MethodInvoker(this.UpdateRelativePosition));
		}

		// Token: 0x060016FD RID: 5885 RVA: 0x00055521 File Offset: 0x00053721
		protected override void OnStateChanged(global::System.EventArgs e)
		{
			this.CacheRestoreBounds();
			base.CoerceValue(global::System.Windows.Window.SizeToContentProperty);
			base.OnStateChanged(e);
		}

		// Token: 0x060016FE RID: 5886 RVA: 0x0005553C File Offset: 0x0005373C
		protected override void OnSourceInitialized(global::System.EventArgs e)
		{
			this.SetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.HasSourceBeenInitialized, true);
			global::System.Windows.Interop.WindowInteropHelper windowInteropHelper = new global::System.Windows.Interop.WindowInteropHelper(this);
			global::System.IntPtr handle = windowInteropHelper.Handle;
			global::System.Windows.Interop.HwndSource hwndSource = global::System.Windows.Interop.HwndSource.FromHwnd(handle);
			hwndSource.AddHook(new global::System.Windows.Interop.HwndSourceHook(this.WndProc));
			global::System.Windows.PresentationSource.AddSourceChangedHandler(this, new global::System.Windows.SourceChangedEventHandler(this.OnPresentationSourceChanged));
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

		// Token: 0x060016FF RID: 5887 RVA: 0x00055653 File Offset: 0x00053853
		protected override void OnRenderSizeChanged(global::System.Windows.SizeChangedInfo sizeInfo)
		{
			base.OnRenderSizeChanged(sizeInfo);
			this.UpdateRelativePosition();
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06001700 RID: 5888 RVA: 0x00055662 File Offset: 0x00053862
		public bool AllowClose
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.ToolWindowHostWindow.AllowCloseProperty);
			}
		}

		// Token: 0x06001701 RID: 5889 RVA: 0x00055674 File Offset: 0x00053874
		private static void OnAllowCloseChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.ToolWindowHostWindow window = (global::Infragistics.Windows.Controls.ToolWindowHostWindow)d;
			global::Infragistics.Windows.Controls.ToolWindowHostWindow.UpdateAllowClose(window, true.Equals(e.NewValue));
		}

		// Token: 0x06001702 RID: 5890 RVA: 0x0005569E File Offset: 0x0005389E
		private static void OnClientHeightChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.Controls.ToolWindowHostWindow)d).UpdateNonClientSizeFromClientSize(false, true);
			d.InvalidateProperty(global::System.Windows.FrameworkElement.HeightProperty);
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06001703 RID: 5891 RVA: 0x000556B8 File Offset: 0x000538B8
		// (set) Token: 0x06001704 RID: 5892 RVA: 0x000556CA File Offset: 0x000538CA
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

		// Token: 0x06001705 RID: 5893 RVA: 0x000556DD File Offset: 0x000538DD
		private static void OnClientWidthChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.Controls.ToolWindowHostWindow)d).UpdateNonClientSizeFromClientSize(true, false);
			d.InvalidateProperty(global::System.Windows.FrameworkElement.WidthProperty);
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06001706 RID: 5894 RVA: 0x000556F7 File Offset: 0x000538F7
		// (set) Token: 0x06001707 RID: 5895 RVA: 0x00055709 File Offset: 0x00053909
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

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06001708 RID: 5896 RVA: 0x0005571C File Offset: 0x0005391C
		private bool IsInWndProc
		{
			get
			{
				return this._wndProcCount > 0;
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06001709 RID: 5897 RVA: 0x00055727 File Offset: 0x00053927
		// (set) Token: 0x0600170A RID: 5898 RVA: 0x00055739 File Offset: 0x00053939
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

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x0600170B RID: 5899 RVA: 0x0005574C File Offset: 0x0005394C
		// (set) Token: 0x0600170C RID: 5900 RVA: 0x0005575E File Offset: 0x0005395E
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

		// Token: 0x0600170D RID: 5901 RVA: 0x00055774 File Offset: 0x00053974
		private static void OnOwnerRectChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.ToolWindowHostWindow toolWindowHostWindow = (global::Infragistics.Windows.Controls.ToolWindowHostWindow)d;
			toolWindowHostWindow.UpdateRelativePosition();
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x0600170E RID: 5902 RVA: 0x0005578E File Offset: 0x0005398E
		private global::System.Windows.Rect OwnerRect
		{
			get
			{
				return (global::System.Windows.Rect)base.GetValue(global::Infragistics.Windows.Controls.ToolWindowHostWindow.OwnerRectProperty);
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x0600170F RID: 5903 RVA: 0x000557A0 File Offset: 0x000539A0
		// (set) Token: 0x06001710 RID: 5904 RVA: 0x000557A9 File Offset: 0x000539A9
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

		// Token: 0x06001711 RID: 5905 RVA: 0x000557B4 File Offset: 0x000539B4
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

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06001712 RID: 5906 RVA: 0x00055863 File Offset: 0x00053A63
		// (set) Token: 0x06001713 RID: 5907 RVA: 0x0005586C File Offset: 0x00053A6C
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

		// Token: 0x06001714 RID: 5908 RVA: 0x00055880 File Offset: 0x00053A80
		internal global::System.Windows.Size AddNonClientSize(global::System.Windows.Size clientSize)
		{
			double width = clientSize.Width;
			double height = clientSize.Height;
			this.UpdateForClientSize(true, ref width, ref height);
			return new global::System.Windows.Size(width, height);
		}

		// Token: 0x06001715 RID: 5909 RVA: 0x000558B0 File Offset: 0x00053AB0
		internal static bool AreClose(double value1, double value2, double threshold = 1E-10)
		{
			return value1 == value2 || (double.IsNaN(value1) && double.IsNaN(value2)) || global::System.Math.Abs(value1 - value2) < 1E-10;
		}

		// Token: 0x06001716 RID: 5910 RVA: 0x000558E0 File Offset: 0x00053AE0
		internal void BringToFront()
		{
			global::System.IntPtr handle = new global::System.Windows.Interop.WindowInteropHelper(this).Handle;
			if (global::System.IntPtr.Zero != handle)
			{
				global::Infragistics.Windows.Helpers.NativeWindowMethods.SetWindowPosApi(handle, global::System.IntPtr.Zero, 0, 0, 0, 0, 19);
			}
		}

		// Token: 0x06001717 RID: 5911 RVA: 0x00055918 File Offset: 0x00053B18
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

		// Token: 0x06001718 RID: 5912 RVA: 0x00055A0C File Offset: 0x00053C0C
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

		// Token: 0x06001719 RID: 5913 RVA: 0x00055B80 File Offset: 0x00053D80
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

		// Token: 0x0600171A RID: 5914 RVA: 0x00055BC0 File Offset: 0x00053DC0
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
			catch (global::System.Exception)
			{
				this.ReleaseActivationHook();
				throw;
			}
		}

		// Token: 0x0600171B RID: 5915 RVA: 0x00055C00 File Offset: 0x00053E00
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

		// Token: 0x0600171C RID: 5916 RVA: 0x00055C38 File Offset: 0x00053E38
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

		// Token: 0x0600171D RID: 5917 RVA: 0x00055CC4 File Offset: 0x00053EC4
		private void CloseHelper()
		{
			bool flag = this.GetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsClosing);
			if (flag)
			{
				return;
			}
			this.SetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsClosing, true);
			try
			{
				this.CloseHelperImpl();
			}
			finally
			{
				this.SetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsClosing, flag);
			}
		}

		// Token: 0x0600171E RID: 5918 RVA: 0x00055D14 File Offset: 0x00053F14
		private void CloseHelperImpl()
		{
			if (this.IsInWndProc)
			{
				base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::Infragistics.Windows.Controls.ToolWindow.MethodInvoker(this.CloseHelper));
				return;
			}
			global::System.Windows.Interop.WindowInteropHelper windowInteropHelper = new global::System.Windows.Interop.WindowInteropHelper(this);
			global::System.IntPtr handle = windowInteropHelper.Handle;
			global::System.Windows.Interop.HwndSource hwndSource = (global::System.IntPtr.Zero != handle) ? global::System.Windows.Interop.HwndSource.FromHwnd(handle) : null;
			if (hwndSource == null || hwndSource.RootVisual != null)
			{
				base.Close();
			}
			this.ReleaseActivationHook();
		}

		// Token: 0x0600171F RID: 5919 RVA: 0x00055D88 File Offset: 0x00053F88
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

		// Token: 0x06001720 RID: 5920 RVA: 0x00055DD4 File Offset: 0x00053FD4
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

		// Token: 0x06001721 RID: 5921 RVA: 0x00055E20 File Offset: 0x00054020
		private static object CoerceSizeToContent(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Infragistics.Windows.Controls.ToolWindowHostWindow window = d as global::Infragistics.Windows.Controls.ToolWindowHostWindow;
			if (global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowState(window) != global::System.Windows.WindowState.Normal && !global::System.Windows.SizeToContent.Manual.Equals(baseValue))
			{
				return global::System.Windows.SizeToContent.Manual;
			}
			return baseValue;
		}

		// Token: 0x06001722 RID: 5922 RVA: 0x00055E54 File Offset: 0x00054054
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
			return new global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT((int)global::System.Math.Round(point.X, global::System.MidpointRounding.AwayFromZero), (int)global::System.Math.Round(point.Y, global::System.MidpointRounding.AwayFromZero));
		}

		// Token: 0x06001723 RID: 5923 RVA: 0x00055EE0 File Offset: 0x000540E0
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

		// Token: 0x06001724 RID: 5924 RVA: 0x00055F49 File Offset: 0x00054149
		private bool GetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags flag)
		{
			return (this._flags & flag) != (global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags)0;
		}

		// Token: 0x06001725 RID: 5925 RVA: 0x00055F5C File Offset: 0x0005415C
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

		// Token: 0x06001726 RID: 5926 RVA: 0x00055FB0 File Offset: 0x000541B0
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

		// Token: 0x06001727 RID: 5927 RVA: 0x0005600B File Offset: 0x0005420B
		private static void OnInternalLeftTopChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.Controls.ToolWindowHostWindow)d).SynchronizeLocation(false);
		}

		// Token: 0x06001728 RID: 5928 RVA: 0x00056019 File Offset: 0x00054219
		private static void OnHeightChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.Controls.ToolWindowHostWindow)d).UpdateClientSizeFromNonClientSize(false, true);
		}

		// Token: 0x06001729 RID: 5929 RVA: 0x00056028 File Offset: 0x00054228
		private void OnLayoutUpdated(object sender, global::System.EventArgs e)
		{
			base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::Infragistics.Windows.Controls.ToolWindow.MethodInvoker(this.UpdateRelativePosition));
		}

		// Token: 0x0600172A RID: 5930 RVA: 0x00056044 File Offset: 0x00054244
		private void OnAfterWindowStateChanged(global::System.Windows.WindowState newState)
		{
			if (!this.GetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsChangingWindowState) && newState == base.WindowState && newState == global::System.Windows.WindowState.Normal && this._content != null && this._content.WindowState == newState)
			{
				this.UpdateClientSizeFromNonClientSize(!double.IsNaN(this._content.Width), !double.IsNaN(this._content.Height));
			}
		}

		// Token: 0x0600172B RID: 5931 RVA: 0x000560AC File Offset: 0x000542AC
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

		// Token: 0x0600172C RID: 5932 RVA: 0x00056168 File Offset: 0x00054368
		private void OnPresentationSourceChanged(object sender, global::System.Windows.SourceChangedEventArgs e)
		{
			if (e.NewSource == null)
			{
				global::System.Windows.PresentationSource.RemoveSourceChangedHandler(this, new global::System.Windows.SourceChangedEventHandler(this.OnPresentationSourceChanged));
				if (!this.GetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsClosing))
				{
					this.OnClosedImpl(true);
				}
			}
		}

		// Token: 0x0600172D RID: 5933 RVA: 0x000561A5 File Offset: 0x000543A5
		private static void OnSizeToContentChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x0600172E RID: 5934 RVA: 0x000561A7 File Offset: 0x000543A7
		private static void OnWidthChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.Controls.ToolWindowHostWindow)d).UpdateClientSizeFromNonClientSize(true, false);
		}

		// Token: 0x0600172F RID: 5935 RVA: 0x000561B8 File Offset: 0x000543B8
		private static void OnVisibilityChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.ToolWindowHostWindow toolWindowHostWindow = d as global::Infragistics.Windows.Controls.ToolWindowHostWindow;
			bool flag = toolWindowHostWindow.GetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsChangingVisibility);
			if (!flag)
			{
				toolWindowHostWindow.SetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsChangingVisibility, true);
				try
				{
					global::Infragistics.Windows.Controls.ToolWindow content = toolWindowHostWindow._content;
					if (content != null)
					{
						content.Visibility = (global::System.Windows.Visibility)e.NewValue;
					}
					return;
				}
				finally
				{
					toolWindowHostWindow.SetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsChangingVisibility, flag);
				}
			}
			if (global::System.Windows.Visibility.Collapsed.Equals(e.NewValue) && toolWindowHostWindow.GetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.HasSourceBeenInitialized) && global::System.Windows.PresentationSource.FromVisual(toolWindowHostWindow) == null)
			{
				toolWindowHostWindow.OnClosedImpl(true);
			}
		}

		// Token: 0x06001730 RID: 5936 RVA: 0x00056254 File Offset: 0x00054454
		private static void OnWindowStateChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.ToolWindowHostWindow toolWindowHostWindow = d as global::Infragistics.Windows.Controls.ToolWindowHostWindow;
			bool flag = toolWindowHostWindow.GetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsChangingWindowState);
			toolWindowHostWindow.SetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsChangingWindowState, true);
			if (!flag)
			{
				toolWindowHostWindow._previousWindowState = new global::System.Windows.WindowState?((global::System.Windows.WindowState)e.OldValue);
			}
			try
			{
				toolWindowHostWindow.SetValue(global::Infragistics.Windows.Controls.ToolWindowHostWindow.WindowStateInternalProperty, e.NewValue);
			}
			finally
			{
				if (!flag)
				{
					toolWindowHostWindow._previousWindowState = null;
				}
				toolWindowHostWindow.SetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsChangingWindowState, flag);
			}
			toolWindowHostWindow.OnAfterWindowStateChanged((global::System.Windows.WindowState)e.NewValue);
			if (global::System.Windows.WindowState.Normal.Equals(e.NewValue))
			{
				toolWindowHostWindow.VerifyIsInView(false, true, false);
			}
		}

		// Token: 0x06001731 RID: 5937 RVA: 0x0005630C File Offset: 0x0005450C
		[global::System.Diagnostics.Conditional("DEBUG_RELATIVEPOS")]
		private static void OutputRelativePosInfo(object value, string category)
		{
		}

		// Token: 0x06001732 RID: 5938 RVA: 0x0005630E File Offset: 0x0005450E
		[global::System.Diagnostics.Conditional("DEBUG_SIZING")]
		private static void OutputSizeInfo(object value, string category)
		{
		}

		// Token: 0x06001733 RID: 5939 RVA: 0x00056310 File Offset: 0x00054510
		private void ReleaseActivationHook()
		{
			if (global::System.IntPtr.Zero != this._hook)
			{
				global::System.IntPtr hook = this._hook;
				this._hook = global::System.IntPtr.Zero;
				global::Infragistics.Windows.Helpers.NativeWindowMethods.UnhookWindowsHookEx(hook);
			}
		}

		// Token: 0x06001734 RID: 5940 RVA: 0x00056348 File Offset: 0x00054548
		private void SetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags flag, bool set)
		{
			if (set)
			{
				this._flags |= flag;
				return;
			}
			this._flags &= ~flag;
		}

		// Token: 0x06001735 RID: 5941 RVA: 0x0005636C File Offset: 0x0005456C
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

		// Token: 0x06001736 RID: 5942 RVA: 0x000563F4 File Offset: 0x000545F4
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

		// Token: 0x06001737 RID: 5943 RVA: 0x0005647C File Offset: 0x0005467C
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

		// Token: 0x06001738 RID: 5944 RVA: 0x00056570 File Offset: 0x00054770
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

		// Token: 0x06001739 RID: 5945 RVA: 0x0005666C File Offset: 0x0005486C
		private bool TryGetMonitorFromRestoreBounds(global::System.IntPtr hwnd, out global::System.IntPtr hMonitor)
		{
			hMonitor = global::System.IntPtr.Zero;
			if (this.GetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsChangingWindowState) && !this.UseSystemNonClientArea && this._previousWindowState == global::System.Windows.WindowState.Minimized && !base.ShowInTaskbar && base.WindowState == global::System.Windows.WindowState.Maximized && global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowState(hwnd) == global::System.Windows.WindowState.Maximized && !this._content.GetRestoreBounds().IsEmpty)
			{
				global::System.Windows.Rect restoreBounds = this._content.GetRestoreBounds();
				global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT point = this.ConvertFromLogicalPixels(restoreBounds.Left, restoreBounds.Top);
				global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT point2 = this.ConvertFromLogicalPixels(restoreBounds.Right, restoreBounds.Bottom);
				global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT rect = new global::Infragistics.Windows.Helpers.NativeWindowMethods.RECT(point.X, point.Y, point2.X, point2.Y);
				hMonitor = global::Infragistics.Windows.Helpers.NativeWindowMethods.MonitorFromPoint(new global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT(rect.left + rect.Width / 2, rect.top + rect.Height / 2), 2);
			}
			return hMonitor != global::System.IntPtr.Zero;
		}

		// Token: 0x0600173A RID: 5946 RVA: 0x00056798 File Offset: 0x00054998
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

		// Token: 0x0600173B RID: 5947 RVA: 0x000567F4 File Offset: 0x000549F4
		private void UpdateClientSizeFromNonClientSize(bool updateWidth, bool updateHeight)
		{
			bool flag = this.GetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsUpdatingClientWidthFromNonClient);
			bool flag2 = this.GetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsUpdatingClientHeightFromNonClient);
			try
			{
				this.SetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsUpdatingClientWidthFromNonClient, flag || updateWidth);
				this.SetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsUpdatingClientHeightFromNonClient, flag2 || updateHeight);
				this.UpdateClientSizeFromNonClientSizeImpl(updateWidth, updateHeight);
			}
			finally
			{
				this.SetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsUpdatingClientWidthFromNonClient, flag);
				this.SetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsUpdatingClientHeightFromNonClient, flag2);
			}
		}

		// Token: 0x0600173C RID: 5948 RVA: 0x00056870 File Offset: 0x00054A70
		private void UpdateClientSizeFromNonClientSizeImpl(bool updateWidth, bool updateHeight)
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

		// Token: 0x0600173D RID: 5949 RVA: 0x000568E8 File Offset: 0x00054AE8
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
			if (updateHeight && !global::Infragistics.Windows.Controls.ToolWindowHostWindow.AreClose(height, this.ClientHeight, 1E-10))
			{
				this.ClientHeight = (double.IsNaN(height) ? height : global::System.Math.Max(height, 0.0));
			}
			if (updateWidth && !global::Infragistics.Windows.Controls.ToolWindowHostWindow.AreClose(width, this.ClientWidth, 1E-10))
			{
				this.ClientWidth = (double.IsNaN(width) ? width : global::System.Math.Max(width, 0.0));
			}
		}

		// Token: 0x0600173E RID: 5950 RVA: 0x000569A0 File Offset: 0x00054BA0
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

		// Token: 0x0600173F RID: 5951 RVA: 0x00056BB8 File Offset: 0x00054DB8
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
			double threshold = this.GetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsUpdatingClientHeightFromNonClient) ? 1.0 : 1E-10;
			double threshold2 = this.GetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsUpdatingClientWidthFromNonClient) ? 1.0 : 1E-10;
			if (updateHeight && !global::Infragistics.Windows.Controls.ToolWindowHostWindow.AreClose(num2, base.Height, threshold))
			{
				base.Height = num2;
			}
			if (updateWidth && !global::Infragistics.Windows.Controls.ToolWindowHostWindow.AreClose(num, base.Width, threshold2))
			{
				base.Width = num;
			}
		}

		// Token: 0x06001740 RID: 5952 RVA: 0x00056D00 File Offset: 0x00054F00
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

		// Token: 0x06001741 RID: 5953 RVA: 0x00056FB0 File Offset: 0x000551B0
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

		// Token: 0x06001742 RID: 5954 RVA: 0x00057010 File Offset: 0x00055210
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

		// Token: 0x06001743 RID: 5955 RVA: 0x000571AC File Offset: 0x000553AC
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

		// Token: 0x06001744 RID: 5956 RVA: 0x00057338 File Offset: 0x00055538
		private void VerifyTitleBinding()
		{
			if (this._content != null)
			{
				global::System.Windows.Data.BindingOperations.SetBinding(this, global::System.Windows.Window.TitleProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.Controls.ToolWindow.TitleProperty, global::System.Windows.Data.BindingMode.OneWay, this._content));
				return;
			}
			global::System.Windows.Data.BindingOperations.ClearBinding(this, global::System.Windows.Window.TitleProperty);
		}

		// Token: 0x06001745 RID: 5957 RVA: 0x0005736C File Offset: 0x0005556C
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

		// Token: 0x06001746 RID: 5958 RVA: 0x00057420 File Offset: 0x00055620
		private void VerifyWindowStyleBits()
		{
			if (this._content == null)
			{
				return;
			}
			global::System.Windows.Interop.WindowInteropHelper windowInteropHelper = new global::System.Windows.Interop.WindowInteropHelper(this);
			this.VerifyWindowStyleBits(windowInteropHelper.Handle);
		}

		// Token: 0x06001747 RID: 5959 RVA: 0x0005744C File Offset: 0x0005564C
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

		// Token: 0x06001748 RID: 5960 RVA: 0x00057550 File Offset: 0x00055750
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

		// Token: 0x06001749 RID: 5961 RVA: 0x000576E0 File Offset: 0x000558E0
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

		// Token: 0x0600174A RID: 5962 RVA: 0x00057738 File Offset: 0x00055938
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

		// Token: 0x0600174B RID: 5963 RVA: 0x00057780 File Offset: 0x00055980
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
			else if (!this.TryGetMonitorFromRestoreBounds(hwnd, out intPtr))
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
					if (monitorinfo.rcMonitor.Width != monitorinfo2.rcMonitor.Width || monitorinfo.rcMonitor.Height != monitorinfo2.rcMonitor.Height || (monitorinfo.rcMonitor.Width == monitorinfo.rcWork.Width && monitorinfo.rcMonitor.Height == monitorinfo.rcWork.Height))
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

		// Token: 0x0600174C RID: 5964 RVA: 0x000579B8 File Offset: 0x00055BB8
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

		// Token: 0x0600174D RID: 5965 RVA: 0x00057A90 File Offset: 0x00055C90
		private global::System.IntPtr WmNcCalcSize(global::System.IntPtr hwnd, global::System.IntPtr wParam, global::System.IntPtr lParam, ref bool handled)
		{
			if (!this.UseSystemNonClientArea && wParam.ToInt64() == 1L)
			{
				global::Infragistics.Windows.Helpers.NativeWindowMethods.NCCALCSIZE_PARAMS nccalcsize_PARAMS = (global::Infragistics.Windows.Helpers.NativeWindowMethods.NCCALCSIZE_PARAMS)global::System.Runtime.InteropServices.Marshal.PtrToStructure(lParam, typeof(global::Infragistics.Windows.Helpers.NativeWindowMethods.NCCALCSIZE_PARAMS));
				if (global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowState(hwnd) == global::System.Windows.WindowState.Maximized)
				{
					global::System.IntPtr intPtr = global::Infragistics.Windows.Helpers.NativeWindowMethods.MonitorFromWindow(hwnd, 0U);
					if (intPtr == global::System.IntPtr.Zero)
					{
						intPtr = global::Infragistics.Windows.Helpers.NativeWindowMethods.MonitorFromWindow(hwnd, 2U);
					}
					global::Infragistics.Windows.Helpers.NativeWindowMethods.GetScreenHeight(hwnd);
					global::System.IntPtr intPtr2;
					if (this.TryGetMonitorFromRestoreBounds(hwnd, out intPtr2))
					{
						intPtr = intPtr2;
					}
					global::Infragistics.Windows.Helpers.NativeWindowMethods.MONITORINFO monitorinfo = default(global::Infragistics.Windows.Helpers.NativeWindowMethods.MONITORINFO);
					monitorinfo.cbSize = (uint)global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Infragistics.Windows.Helpers.NativeWindowMethods.MONITORINFO));
					if (global::Infragistics.Windows.Helpers.NativeWindowMethods.GetMonitorInfo(intPtr, out monitorinfo) && nccalcsize_PARAMS.rectProposed.top <= monitorinfo.rcMonitor.top && nccalcsize_PARAMS.rectProposed.bottom >= monitorinfo.rcMonitor.bottom && monitorinfo.rcMonitor.Width == monitorinfo.rcWork.Width)
					{
						nccalcsize_PARAMS.rectProposed.bottom = monitorinfo.rcMonitor.bottom - 1;
						global::System.Runtime.InteropServices.Marshal.StructureToPtr(nccalcsize_PARAMS, lParam, false);
					}
				}
				handled = true;
			}
			return global::System.IntPtr.Zero;
		}

		// Token: 0x0600174E RID: 5966 RVA: 0x00057BB0 File Offset: 0x00055DB0
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

		// Token: 0x0600174F RID: 5967 RVA: 0x00057C50 File Offset: 0x00055E50
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

		// Token: 0x06001750 RID: 5968 RVA: 0x00057CCC File Offset: 0x00055ECC
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

		// Token: 0x06001751 RID: 5969 RVA: 0x00057D48 File Offset: 0x00055F48
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

		// Token: 0x06001752 RID: 5970 RVA: 0x00057E60 File Offset: 0x00056060
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

		// Token: 0x06001753 RID: 5971 RVA: 0x00057F68 File Offset: 0x00056168
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

		// Token: 0x06001754 RID: 5972 RVA: 0x00058154 File Offset: 0x00056354
		private global::System.IntPtr WmWindowPosChanging(global::System.IntPtr hwnd, global::System.IntPtr wParam, global::System.IntPtr lParam, ref bool handled)
		{
			global::Infragistics.Windows.Helpers.NativeWindowMethods.WINDOWPOS windowpos = (global::Infragistics.Windows.Helpers.NativeWindowMethods.WINDOWPOS)global::System.Runtime.InteropServices.Marshal.PtrToStructure(lParam, typeof(global::Infragistics.Windows.Helpers.NativeWindowMethods.WINDOWPOS));
			global::System.Windows.WindowState windowState = global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowState(hwnd);
			bool flag = this.GetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsInMoveSize);
			if (!flag && (windowpos.flags & 32768) == 0 && (windowpos.flags & 2) == 0)
			{
				flag = true;
			}
			if (flag && (windowpos.flags & 1) == 0 && windowState == global::System.Windows.WindowState.Normal)
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
				global::System.Windows.Rect workArea = global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWorkArea(point);
				windowpos.x = (int)workArea.X;
				windowpos.y = (int)workArea.Y;
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
							if (windowpos.y == monitorinfo.rcMonitor.top && windowpos.cy + windowpos.y == monitorinfo.rcMonitor.bottom)
							{
								windowpos.cy--;
							}
						}
					}
				}
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

		// Token: 0x06001755 RID: 5973 RVA: 0x00058428 File Offset: 0x00056628
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

		// Token: 0x06001756 RID: 5974 RVA: 0x00058474 File Offset: 0x00056674
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

		// Token: 0x06001757 RID: 5975 RVA: 0x00058648 File Offset: 0x00056848
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

		// Token: 0x06001758 RID: 5976 RVA: 0x000586CC File Offset: 0x000568CC
		void global::Infragistics.Windows.Controls.IToolWindowHost.DragResize(global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation location, global::System.Windows.Input.Cursor cursor, global::System.Windows.Input.MouseEventArgs e)
		{
		}

		// Token: 0x06001759 RID: 5977 RVA: 0x000586CE File Offset: 0x000568CE
		void global::Infragistics.Windows.Controls.IToolWindowHost.Activate()
		{
			base.Activate();
		}

		// Token: 0x0600175A RID: 5978 RVA: 0x000586D7 File Offset: 0x000568D7
		void global::Infragistics.Windows.Controls.IToolWindowHost.Close()
		{
			this.CloseHelper();
		}

		// Token: 0x0600175B RID: 5979 RVA: 0x000586DF File Offset: 0x000568DF
		void global::Infragistics.Windows.Controls.IToolWindowHost.RelativePositionStateChanged()
		{
			this.VerifyRelativePositionBinding();
			this.UpdateRelativePosition();
		}

		// Token: 0x0600175C RID: 5980 RVA: 0x000586ED File Offset: 0x000568ED
		void global::Infragistics.Windows.Controls.IToolWindowHost.BringToFront()
		{
			this.BringToFront();
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x0600175D RID: 5981 RVA: 0x000586F5 File Offset: 0x000568F5
		bool global::Infragistics.Windows.Controls.IToolWindowHost.HandlesDelayedMinMaxRequests
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x0600175E RID: 5982 RVA: 0x000586F8 File Offset: 0x000568F8
		bool global::Infragistics.Windows.Controls.IToolWindowHost.IsWindow
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x0600175F RID: 5983 RVA: 0x000586FB File Offset: 0x000568FB
		bool global::Infragistics.Windows.Controls.IToolWindowHost.AllowsTransparency
		{
			get
			{
				return base.AllowsTransparency;
			}
		}

		// Token: 0x06001760 RID: 5984 RVA: 0x00058703 File Offset: 0x00056903
		bool global::Infragistics.Windows.Controls.IToolWindowHost.SupportsAllowTransparency(bool allowsTransparency)
		{
			return this._content != null && (!this._content.UseOSNonClientArea || !allowsTransparency);
		}

		// Token: 0x06001761 RID: 5985 RVA: 0x00058722 File Offset: 0x00056922
		void global::Infragistics.Windows.Controls.IToolWindowHost.EnsureOnScreen(bool fullyInView)
		{
			this.VerifyIsInView(true, true, fullyInView);
		}

		// Token: 0x06001762 RID: 5986 RVA: 0x00058730 File Offset: 0x00056930
		global::System.Windows.Rect global::Infragistics.Windows.Controls.IToolWindowHost.GetRestoreBounds()
		{
			global::System.Windows.Rect restoreBounds = base.RestoreBounds;
			if (restoreBounds.IsEmpty && this._content != null)
			{
				restoreBounds = this._content.GetRestoreBounds(false);
			}
			return restoreBounds;
		}

		// Token: 0x06001763 RID: 5987 RVA: 0x00058764 File Offset: 0x00056964
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

		// Token: 0x06001764 RID: 5988 RVA: 0x000587B4 File Offset: 0x000569B4
		void global::Infragistics.Windows.Controls.IToolWindowHost.SetWindowState(global::System.Windows.WindowState state)
		{
			bool flag = this.GetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsChangingWindowState);
			this.SetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsChangingWindowState, true);
			if (!flag)
			{
				this._previousWindowState = new global::System.Windows.WindowState?(base.WindowState);
			}
			try
			{
				base.WindowState = state;
			}
			finally
			{
				if (!flag)
				{
					this._previousWindowState = null;
				}
				this.SetFlag(global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags.IsChangingWindowState, flag);
			}
			this.OnAfterWindowStateChanged(state);
		}

		// Token: 0x06001765 RID: 5989 RVA: 0x0005882C File Offset: 0x00056A2C
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

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06001766 RID: 5990 RVA: 0x000588A9 File Offset: 0x00056AA9
		bool global::Infragistics.Windows.Controls.IToolWindowHost.IsUsingOsNonClientArea
		{
			get
			{
				return this.UseSystemNonClientArea;
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06001767 RID: 5991 RVA: 0x000588B1 File Offset: 0x00056AB1
		global::Infragistics.Windows.Controls.ToolWindowHostType global::Infragistics.Windows.Controls.IToolWindowHost.HostType
		{
			get
			{
				return global::Infragistics.Windows.Controls.ToolWindowHostType.Window;
			}
		}

		// Token: 0x04000BDF RID: 3039
		private const double AreCloseThreshold = 1E-10;

		// Token: 0x04000BE0 RID: 3040
		private global::Infragistics.Windows.Controls.ToolWindow _content;

		// Token: 0x04000BE1 RID: 3041
		private global::Infragistics.Windows.Controls.ToolWindowHostWindow.InternalFlags _flags;

		// Token: 0x04000BE2 RID: 3042
		private global::System.IntPtr _hook;

		// Token: 0x04000BE3 RID: 3043
		private global::Infragistics.Windows.Helpers.NativeWindowMethods.HookProc _hookCallback;

		// Token: 0x04000BE4 RID: 3044
		private int _wndProcCount;

		// Token: 0x04000BE5 RID: 3045
		private global::System.Windows.WindowState? _previousWindowState;

		// Token: 0x04000BE6 RID: 3046
		private static readonly global::System.Windows.DependencyProperty VisibilityInternalProperty = global::System.Windows.DependencyProperty.Register("VisibilityInternal", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.Controls.ToolWindowHostWindow), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Visibility.Collapsed, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindowHostWindow.OnVisibilityInternalChanged)));

		// Token: 0x04000BE7 RID: 3047
		private static readonly global::System.Windows.DependencyProperty WindowStateInternalProperty = global::System.Windows.DependencyProperty.Register("WindowStateInternal", typeof(global::System.Windows.WindowState), typeof(global::Infragistics.Windows.Controls.ToolWindowHostWindow), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.WindowState.Normal, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindowHostWindow.OnWindowStateInternalChanged)));

		// Token: 0x04000BE8 RID: 3048
		public static readonly global::System.Windows.DependencyProperty AllowCloseProperty = global::Infragistics.Windows.Controls.ToolWindow.AllowCloseProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.ToolWindowHostWindow), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindowHostWindow.OnAllowCloseChanged)));

		// Token: 0x04000BE9 RID: 3049
		internal static readonly global::System.Windows.DependencyProperty ClientHeightProperty = global::System.Windows.DependencyProperty.Register("ClientHeight", typeof(double), typeof(global::Infragistics.Windows.Controls.ToolWindowHostWindow), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindowHostWindow.OnClientHeightChanged)));

		// Token: 0x04000BEA RID: 3050
		internal static readonly global::System.Windows.DependencyProperty ClientWidthProperty = global::System.Windows.DependencyProperty.Register("ClientWidth", typeof(double), typeof(global::Infragistics.Windows.Controls.ToolWindowHostWindow), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindowHostWindow.OnClientWidthChanged)));

		// Token: 0x04000BEB RID: 3051
		private static readonly global::System.Windows.DependencyProperty InternalLeftProperty = global::System.Windows.DependencyProperty.Register("InternalLeft", typeof(double), typeof(global::Infragistics.Windows.Controls.ToolWindowHostWindow), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindowHostWindow.OnInternalLeftTopChanged)));

		// Token: 0x04000BEC RID: 3052
		private static readonly global::System.Windows.DependencyProperty InternalTopProperty = global::System.Windows.DependencyProperty.Register("InternalTop", typeof(double), typeof(global::Infragistics.Windows.Controls.ToolWindowHostWindow), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindowHostWindow.OnInternalLeftTopChanged)));

		// Token: 0x04000BED RID: 3053
		private static readonly global::System.Windows.DependencyProperty OwnerRectProperty = global::System.Windows.DependencyProperty.Register("OwnerRect", typeof(global::System.Windows.Rect), typeof(global::Infragistics.Windows.Controls.ToolWindowHostWindow), new global::System.Windows.FrameworkPropertyMetadata(default(global::System.Windows.Rect), new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindowHostWindow.OnOwnerRectChanged)));

		// Token: 0x04000BEE RID: 3054
		private static readonly global::System.Windows.DependencyProperty UseSystemNonClientAreaProperty = global::System.Windows.DependencyProperty.Register("UseSystemNonClientArea", typeof(bool), typeof(global::Infragistics.Windows.Controls.ToolWindowHostWindow), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ToolWindowHostWindow.OnUseSystemNonClientAreaChanged)));

		// Token: 0x02000246 RID: 582
		private class WindowPositionToRectConverter : global::System.Windows.Data.IMultiValueConverter
		{
			// Token: 0x06001768 RID: 5992 RVA: 0x000588B4 File Offset: 0x00056AB4
			private WindowPositionToRectConverter()
			{
			}

			// Token: 0x17000546 RID: 1350
			// (get) Token: 0x0600176A RID: 5994 RVA: 0x000588C8 File Offset: 0x00056AC8
			public static global::System.Windows.Data.IMultiValueConverter Instance
			{
				get
				{
					return global::Infragistics.Windows.Controls.ToolWindowHostWindow.WindowPositionToRectConverter.instance;
				}
			}

			// Token: 0x0600176B RID: 5995 RVA: 0x000588D0 File Offset: 0x00056AD0
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

			// Token: 0x0600176C RID: 5996 RVA: 0x0005893C File Offset: 0x00056B3C
			object[] global::System.Windows.Data.IMultiValueConverter.ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
			{
				return new object[]
				{
					global::System.Windows.Data.Binding.DoNothing
				};
			}

			// Token: 0x04000BEF RID: 3055
			private static readonly global::System.Windows.Data.IMultiValueConverter instance = new global::Infragistics.Windows.Controls.ToolWindowHostWindow.WindowPositionToRectConverter();
		}

		// Token: 0x02000247 RID: 583
		internal class DeferShowHelper : global::Infragistics.Windows.Controls.ToolWindow.IDeferShow
		{
			// Token: 0x0600176D RID: 5997 RVA: 0x00058959 File Offset: 0x00056B59
			internal DeferShowHelper(global::Infragistics.Windows.Controls.ToolWindowHostWindow window)
			{
				this._window = window;
			}

			// Token: 0x0600176E RID: 5998 RVA: 0x00058968 File Offset: 0x00056B68
			public void Show(bool activate)
			{
				using (new global::Infragistics.Windows.Helpers.TempValueReplacement(this._window, global::System.Windows.UIElement.VisibilityProperty, global::Infragistics.KnownBoxes.VisibilityVisibleBox))
				{
					this._window.Show(activate);
				}
			}

			// Token: 0x0600176F RID: 5999 RVA: 0x000589B4 File Offset: 0x00056BB4
			public void Cancel()
			{
				this._window.Close();
			}

			// Token: 0x04000BF0 RID: 3056
			private global::Infragistics.Windows.Controls.ToolWindowHostWindow _window;
		}

		// Token: 0x02000248 RID: 584
		private class CoerceProxy
		{
			// Token: 0x06001770 RID: 6000 RVA: 0x000589C1 File Offset: 0x00056BC1
			internal CoerceProxy(global::System.Windows.CoerceValueCallback baseCallback)
			{
				this._baseCallback = baseCallback;
			}

			// Token: 0x06001771 RID: 6001 RVA: 0x000589D0 File Offset: 0x00056BD0
			public virtual object CoerceValue(global::System.Windows.DependencyObject d, object baseValue)
			{
				if (this._baseCallback != null)
				{
					return this._baseCallback(d, baseValue);
				}
				return baseValue;
			}

			// Token: 0x04000BF1 RID: 3057
			private global::System.Windows.CoerceValueCallback _baseCallback;
		}

		// Token: 0x02000249 RID: 585
		private class TopLeftCoerceProxy : global::Infragistics.Windows.Controls.ToolWindowHostWindow.CoerceProxy
		{
			// Token: 0x06001772 RID: 6002 RVA: 0x000589E9 File Offset: 0x00056BE9
			internal TopLeftCoerceProxy(global::System.Windows.DependencyProperty property, global::System.Windows.CoerceValueCallback baseCallback) : base(baseCallback)
			{
				this._property = property;
			}

			// Token: 0x06001773 RID: 6003 RVA: 0x000589FC File Offset: 0x00056BFC
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

			// Token: 0x04000BF2 RID: 3058
			private global::System.Windows.DependencyProperty _property;
		}

		// Token: 0x0200024A RID: 586
		[global::System.Flags]
		private enum InternalFlags
		{
			// Token: 0x04000BF4 RID: 3060
			UpdatingRelativePosition = 1,
			// Token: 0x04000BF5 RID: 3061
			IsSendingWmSize = 2,
			// Token: 0x04000BF6 RID: 3062
			IsSynchronizingLocation = 4,
			// Token: 0x04000BF7 RID: 3063
			UseSystemNonClientArea = 8,
			// Token: 0x04000BF8 RID: 3064
			IsInOnContentChanged = 16,
			// Token: 0x04000BF9 RID: 3065
			IsForcingSizeToContent = 32,
			// Token: 0x04000BFA RID: 3066
			TrackWmMoving = 64,
			// Token: 0x04000BFB RID: 3067
			IsMovingWindow = 128,
			// Token: 0x04000BFC RID: 3068
			IsInMoveSize = 256,
			// Token: 0x04000BFD RID: 3069
			IsChangingWindowState = 512,
			// Token: 0x04000BFE RID: 3070
			IsUpdatingClientWidthFromNonClient = 1024,
			// Token: 0x04000BFF RID: 3071
			IsUpdatingClientHeightFromNonClient = 2048,
			// Token: 0x04000C00 RID: 3072
			IsClosing = 4096,
			// Token: 0x04000C01 RID: 3073
			HasSourceBeenInitialized = 8192,
			// Token: 0x04000C02 RID: 3074
			IsChangingVisibility = 16384
		}

		// Token: 0x0200024B RID: 587
		private class HookTrace
		{
			// Token: 0x06001775 RID: 6005 RVA: 0x00058AEA File Offset: 0x00056CEA
			[global::System.Diagnostics.Conditional("TRACE_HOOKPROC")]
			internal static void Log(bool shouldLog, global::Infragistics.Windows.Controls.ToolWindowHostWindow window, string message, bool includeStackTrace)
			{
			}

			// Token: 0x06001776 RID: 6006 RVA: 0x00058AEE File Offset: 0x00056CEE
			[global::System.Diagnostics.Conditional("TRACE_HOOKPROC")]
			internal static void Log(global::Infragistics.Windows.Controls.ToolWindowHostWindow window, string message, params object[] messageParams)
			{
			}

			// Token: 0x06001777 RID: 6007 RVA: 0x00058AF0 File Offset: 0x00056CF0
			[global::System.Diagnostics.Conditional("TRACE_HOOKPROC")]
			internal static void Log(global::Infragistics.Windows.Controls.ToolWindowHostWindow window, string message, bool includeStackTrace, params object[] messageParams)
			{
				if (global::Infragistics.Windows.Controls.ToolWindowHostWindow.HookTrace._isHookTraceSourceEnabled)
				{
					global::Infragistics.Windows.Controls.ToolWindow content = window._content;
					object obj = (content != null) ? content.Content : null;
					string text = (obj != null) ? string.Format("Type={0}, Hash={1}, ToString='{2}'", obj.GetType().Name, obj.GetHashCode(), obj) : "{None}";
					if (messageParams != null)
					{
						message = string.Format(message, messageParams);
					}
					global::Infragistics.Windows.Controls.ToolWindowHostWindow.HookTrace._HookTraceSource.TraceEvent(global::System.Diagnostics.TraceEventType.Information, 0, "[{0}] {1} ToolWindow={2}, TW.Hash={3}, TW.Content='{4}', Hook={5}, Stack={6}", new object[]
					{
						window.GetHashCode(),
						message,
						content,
						(content != null) ? content.GetHashCode().ToString() : "",
						text,
						window._hook,
						includeStackTrace ? global::System.Environment.StackTrace : ""
					});
				}
			}

			// Token: 0x04000C03 RID: 3075
			private static readonly global::System.Diagnostics.TraceSource _HookTraceSource = new global::System.Diagnostics.TraceSource("Infragistics.ToolWindowHook");

			// Token: 0x04000C04 RID: 3076
			private static bool _isHookTraceSourceEnabled = global::Infragistics.Windows.Controls.ToolWindowHostWindow.HookTrace._HookTraceSource.Switch.ShouldTrace(global::System.Diagnostics.TraceEventType.Information);
		}

		// Token: 0x0200024C RID: 588
		private class NonClientSizeConverter : global::System.Windows.Data.IValueConverter
		{
			// Token: 0x06001779 RID: 6009 RVA: 0x00058BCA File Offset: 0x00056DCA
			internal NonClientSizeConverter(global::Infragistics.Windows.Controls.ToolWindowHostWindow window, bool isWidth, bool addOnConvert)
			{
				global::Infragistics.CoreUtilities.ValidateNotNull(window);
				this._window = window;
				this._isWidth = isWidth;
				this._addOnConvert = addOnConvert;
			}

			// Token: 0x0600177A RID: 6010 RVA: 0x00058BF0 File Offset: 0x00056DF0
			private object ConvertHelper(object value, bool addClientSize)
			{
				if (value is double && this._window.UseSystemNonClientArea)
				{
					double num = (double)value;
					if (!double.IsInfinity(num))
					{
						double num2 = 0.0;
						double num3 = 0.0;
						this._window.UpdateForClientSize(true, ref num2, ref num3);
						double num4 = this._isWidth ? num2 : num3;
						if (addClientSize)
						{
							value = num + num4;
						}
						else if (global::Infragistics.CoreUtilities.LessThanOrClose(num, num4))
						{
							value = global::Infragistics.KnownBoxes.DoubleZeroBox;
						}
						else
						{
							value = num - num4;
						}
					}
				}
				return value;
			}

			// Token: 0x0600177B RID: 6011 RVA: 0x00058C7F File Offset: 0x00056E7F
			public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
			{
				return this.ConvertHelper(value, this._addOnConvert);
			}

			// Token: 0x0600177C RID: 6012 RVA: 0x00058C8E File Offset: 0x00056E8E
			public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
			{
				return this.ConvertHelper(value, !this._addOnConvert);
			}

			// Token: 0x04000C05 RID: 3077
			private global::Infragistics.Windows.Controls.ToolWindowHostWindow _window;

			// Token: 0x04000C06 RID: 3078
			private bool _isWidth;

			// Token: 0x04000C07 RID: 3079
			private bool _addOnConvert;
		}
	}
}
