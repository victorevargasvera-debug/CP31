using System;
using System.Collections;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using Infragistics.Collections;

namespace Infragistics.Windows.Controls
{
	// Token: 0x0200023C RID: 572
	internal abstract class ToolWindowContainer : global::System.Windows.FrameworkElement, global::Infragistics.Windows.Controls.IToolWindowHost
	{
		// Token: 0x06001665 RID: 5733 RVA: 0x00051E46 File Offset: 0x00050046
		internal ToolWindowContainer()
		{
		}

		// Token: 0x06001666 RID: 5734 RVA: 0x00051E50 File Offset: 0x00050050
		static ToolWindowContainer()
		{
			global::System.Windows.FrameworkElement.HorizontalAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ToolWindowContainer), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.HorizontalAlignmentStretchBox));
			global::System.Windows.FrameworkElement.VerticalAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ToolWindowContainer), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VerticalAlignmentStretchBox));
			global::System.Windows.Input.FocusManager.IsFocusScopeProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ToolWindowContainer), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.Controls.ToolWindowContainer), global::System.Windows.Input.Keyboard.PreviewLostKeyboardFocusEvent, new global::System.Windows.Input.KeyboardFocusChangedEventHandler(global::Infragistics.Windows.Controls.ToolWindowContainer.OnPreviousLostKeyboardFocus));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.Controls.ToolWindowContainer), global::System.Windows.Input.Keyboard.GotKeyboardFocusEvent, new global::System.Windows.Input.KeyboardFocusChangedEventHandler(global::Infragistics.Windows.Controls.ToolWindowContainer.OnGotKeyboardFocusWithin), true);
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.Controls.ToolWindowContainer), global::System.Windows.Input.Keyboard.LostKeyboardFocusEvent, new global::System.Windows.Input.KeyboardFocusChangedEventHandler(global::Infragistics.Windows.Controls.ToolWindowContainer.OnLostKeyboardFocusWithin), true);
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.Controls.ToolWindowContainer), global::System.Windows.Input.Mouse.MouseDownEvent, new global::System.Windows.Input.MouseButtonEventHandler(global::Infragistics.Windows.Controls.ToolWindowContainer.OnWindowMouseDown), true);
			global::System.Windows.Input.KeyboardNavigation.TabNavigationProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ToolWindowContainer), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.Cycle));
			global::System.Windows.Input.KeyboardNavigation.DirectionalNavigationProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ToolWindowContainer), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.Cycle));
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x00051FF5 File Offset: 0x000501F5
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			if (this._child != null)
			{
				this._child.Arrange(new global::System.Windows.Rect(finalSize));
			}
			return finalSize;
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06001668 RID: 5736 RVA: 0x00052011 File Offset: 0x00050211
		// (set) Token: 0x06001669 RID: 5737 RVA: 0x0005201C File Offset: 0x0005021C
		public global::System.Windows.UIElement Child
		{
			get
			{
				return this._child;
			}
			set
			{
				global::System.Windows.UIElement child = this.Child;
				if (child != null)
				{
					child.ClearValue(global::Infragistics.Windows.Controls.ToolWindow.HostProperty);
				}
				this._child = value;
				if (child != null)
				{
					base.RemoveVisualChild(child);
					if (global::System.Windows.LogicalTreeHelper.GetParent(child) == this)
					{
						base.RemoveLogicalChild(child);
					}
				}
				if (value != null)
				{
					base.AddVisualChild(value);
					if (global::System.Windows.LogicalTreeHelper.GetParent(value) == null)
					{
						base.AddLogicalChild(value);
					}
				}
				if (this.Child != null)
				{
					global::Infragistics.Windows.Controls.ToolWindow toolWindow = value as global::Infragistics.Windows.Controls.ToolWindow;
					this._isInitialPositionPending = (toolWindow != null && toolWindow.WindowStartupLocation != global::Infragistics.Windows.Controls.ToolWindowStartupLocation.Manual);
					this.Child.SetValue(global::Infragistics.Windows.Controls.ToolWindow.HostProperty, this);
					base.SetBinding(global::System.Windows.UIElement.VisibilityProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.UIElement.VisibilityProperty, global::System.Windows.Data.BindingMode.TwoWay, value));
					base.SetBinding(global::Infragistics.Windows.Controls.ToolWindowContainer.LeftProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.Controls.ToolWindow.LeftProperty, global::System.Windows.Data.BindingMode.TwoWay, value));
					base.SetBinding(global::Infragistics.Windows.Controls.ToolWindowContainer.TopProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.Controls.ToolWindow.TopProperty, global::System.Windows.Data.BindingMode.TwoWay, value));
					base.SetBinding(global::System.Windows.FrameworkElement.WidthProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.FrameworkElement.WidthProperty, global::System.Windows.Data.BindingMode.TwoWay, value));
					base.SetBinding(global::System.Windows.FrameworkElement.HeightProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.FrameworkElement.HeightProperty, global::System.Windows.Data.BindingMode.TwoWay, value));
					base.SetBinding(global::System.Windows.FrameworkElement.MaxWidthProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.FrameworkElement.MaxWidthProperty, global::System.Windows.Data.BindingMode.OneWay, value));
					base.SetBinding(global::System.Windows.FrameworkElement.MaxHeightProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.FrameworkElement.MaxHeightProperty, global::System.Windows.Data.BindingMode.OneWay, value));
					base.SetBinding(global::System.Windows.FrameworkElement.MinWidthProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.FrameworkElement.MinWidthProperty, global::System.Windows.Data.BindingMode.OneWay, value));
					base.SetBinding(global::System.Windows.FrameworkElement.MinHeightProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.FrameworkElement.MinHeightProperty, global::System.Windows.Data.BindingMode.OneWay, value));
					base.SetBinding(global::Infragistics.Windows.Controls.ToolWindowContainer.TopmostProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.Controls.ToolWindow.TopmostProperty, global::System.Windows.Data.BindingMode.OneWay, value));
				}
				else
				{
					global::System.Windows.Data.BindingOperations.ClearAllBindings(this);
				}
				this.OnChildChanged(child, this.Child);
			}
		}

		// Token: 0x0600166A RID: 5738 RVA: 0x000521B8 File Offset: 0x000503B8
		protected override global::System.Windows.Media.Visual GetVisualChild(int index)
		{
			if (index == 0 && this._child != null)
			{
				return this._child;
			}
			return base.GetVisualChild(index);
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x0600166B RID: 5739 RVA: 0x000521D3 File Offset: 0x000503D3
		protected override global::System.Collections.IEnumerator LogicalChildren
		{
			get
			{
				if (this._child != null && global::System.Windows.LogicalTreeHelper.GetParent(this._child) == this)
				{
					return new global::Infragistics.Collections.SingleItemEnumerator(this._child);
				}
				return global::Infragistics.Collections.EmptyEnumerator.Instance;
			}
		}

		// Token: 0x0600166C RID: 5740 RVA: 0x000521FC File Offset: 0x000503FC
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			global::System.Windows.Size result = default(global::System.Windows.Size);
			if (this._child != null)
			{
				this._child.Measure(availableSize);
				result = this._child.DesiredSize;
			}
			return result;
		}

		// Token: 0x0600166D RID: 5741 RVA: 0x00052232 File Offset: 0x00050432
		protected override void OnMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
			if (base.IsMouseCaptured && this._captureAction != global::Infragistics.Windows.Controls.ToolWindowContainer.CaptureAction.None)
			{
				this.ProcessCaptureAction(e);
			}
			base.OnMouseMove(e);
		}

		// Token: 0x0600166E RID: 5742 RVA: 0x00052252 File Offset: 0x00050452
		protected override void OnMouseLeftButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (base.IsMouseCaptured)
			{
				this._captureAction = global::Infragistics.Windows.Controls.ToolWindowContainer.CaptureAction.None;
				e.Handled = true;
				base.ReleaseMouseCapture();
			}
			base.OnMouseLeftButtonUp(e);
		}

		// Token: 0x0600166F RID: 5743 RVA: 0x00052277 File Offset: 0x00050477
		protected override void OnLostMouseCapture(global::System.Windows.Input.MouseEventArgs e)
		{
			base.ClearValue(global::System.Windows.FrameworkElement.CursorProperty);
			global::Infragistics.Windows.Controls.ToolWindowContainer.CaptureAction captureAction = this._captureAction;
			base.OnLostMouseCapture(e);
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06001670 RID: 5744 RVA: 0x00052292 File Offset: 0x00050492
		protected override int VisualChildrenCount
		{
			get
			{
				if (this._child != null)
				{
					return 1;
				}
				return 0;
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06001671 RID: 5745 RVA: 0x0005229F File Offset: 0x0005049F
		internal bool IsInitialPositionPending
		{
			get
			{
				return this._isInitialPositionPending;
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06001672 RID: 5746 RVA: 0x000522A7 File Offset: 0x000504A7
		protected bool IsResizing
		{
			get
			{
				return this._captureAction == global::Infragistics.Windows.Controls.ToolWindowContainer.CaptureAction.Resize;
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06001673 RID: 5747 RVA: 0x000522B2 File Offset: 0x000504B2
		// (set) Token: 0x06001674 RID: 5748 RVA: 0x000522C4 File Offset: 0x000504C4
		public double Left
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.Controls.ToolWindowContainer.LeftProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ToolWindowContainer.LeftProperty, value);
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06001675 RID: 5749 RVA: 0x000522D7 File Offset: 0x000504D7
		// (set) Token: 0x06001676 RID: 5750 RVA: 0x000522E9 File Offset: 0x000504E9
		public double Top
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.Controls.ToolWindowContainer.TopProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ToolWindowContainer.TopProperty, value);
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06001677 RID: 5751 RVA: 0x000522FC File Offset: 0x000504FC
		// (set) Token: 0x06001678 RID: 5752 RVA: 0x0005230E File Offset: 0x0005050E
		public bool Topmost
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.ToolWindowContainer.TopmostProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ToolWindowContainer.TopmostProperty, value);
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06001679 RID: 5753 RVA: 0x00052324 File Offset: 0x00050524
		internal bool UsesRelativePosition
		{
			get
			{
				global::Infragistics.Windows.Controls.ToolWindow toolWindow = this.Child as global::Infragistics.Windows.Controls.ToolWindow;
				return toolWindow != null && toolWindow.UsesRelativePosition;
			}
		}

		// Token: 0x0600167A RID: 5754
		protected abstract global::System.Windows.Point GetRelativeScreenPoint(global::System.Windows.Input.MouseEventArgs e);

		// Token: 0x0600167B RID: 5755 RVA: 0x00052348 File Offset: 0x00050548
		protected virtual void OnChildChanged(global::System.Windows.UIElement oldChild, global::System.Windows.UIElement newChild)
		{
		}

		// Token: 0x0600167C RID: 5756 RVA: 0x0005234A File Offset: 0x0005054A
		protected virtual void OnEnteringMove(global::System.Windows.Input.MouseEventArgs e)
		{
		}

		// Token: 0x0600167D RID: 5757 RVA: 0x0005234C File Offset: 0x0005054C
		protected virtual void OnEnteringDrag(global::System.Windows.Input.MouseEventArgs e, global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation location)
		{
		}

		// Token: 0x0600167E RID: 5758 RVA: 0x00052350 File Offset: 0x00050550
		private static void OnGotKeyboardFocusWithin(object sender, global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = (e.NewFocus is global::System.Windows.DependencyObject) ? global::Infragistics.Windows.Controls.ToolWindow.GetToolWindow((global::System.Windows.DependencyObject)e.NewFocus) : null;
			if (toolWindow != null && !toolWindow.IsActive)
			{
				toolWindow.SetValue(global::Infragistics.Windows.Controls.ToolWindow.IsActivePropertyKey, global::Infragistics.KnownBoxes.TrueBox);
			}
		}

		// Token: 0x0600167F RID: 5759 RVA: 0x0005239C File Offset: 0x0005059C
		private static void OnLostKeyboardFocusWithin(object sender, global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = (e.OldFocus is global::System.Windows.DependencyObject) ? global::Infragistics.Windows.Controls.ToolWindow.GetToolWindow((global::System.Windows.DependencyObject)e.OldFocus) : null;
			global::Infragistics.Windows.Controls.ToolWindow toolWindow2 = (e.NewFocus is global::System.Windows.DependencyObject) ? global::Infragistics.Windows.Controls.ToolWindow.GetToolWindow((global::System.Windows.DependencyObject)e.NewFocus) : null;
			if (toolWindow != toolWindow2 && toolWindow != null)
			{
				toolWindow.ClearValue(global::Infragistics.Windows.Controls.ToolWindow.IsActivePropertyKey);
			}
		}

		// Token: 0x06001680 RID: 5760 RVA: 0x00052400 File Offset: 0x00050600
		private static void OnPreviousLostKeyboardFocus(object sender, global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.ToolWindowContainer toolWindowContainer = sender as global::Infragistics.Windows.Controls.ToolWindowContainer;
			if (e.NewFocus is global::System.Windows.Window && global::System.Windows.Media.VisualTreeHelper.GetParent((global::System.Windows.Window)e.NewFocus) == null)
			{
				global::System.Windows.DependencyObject dependencyObject = e.OldFocus as global::System.Windows.DependencyObject;
				while (dependencyObject is global::System.Windows.ContentElement)
				{
					dependencyObject = global::System.Windows.LogicalTreeHelper.GetParent(dependencyObject);
				}
				if (dependencyObject != null && toolWindowContainer.IsAncestorOf(dependencyObject))
				{
					global::System.Windows.UIElement uielement = global::System.Windows.Input.FocusManager.GetFocusScope(dependencyObject) as global::System.Windows.UIElement;
					if (uielement != toolWindowContainer && uielement.IsVisible)
					{
						return;
					}
				}
				e.Handled = true;
				global::System.Windows.IInputElement focusedElement = global::System.Windows.Input.FocusManager.GetFocusedElement(toolWindowContainer);
				if (focusedElement != null)
				{
					focusedElement.Focus();
					return;
				}
				toolWindowContainer.MoveFocus(new global::System.Windows.Input.TraversalRequest(global::System.Windows.Input.FocusNavigationDirection.First));
			}
		}

		// Token: 0x06001681 RID: 5761 RVA: 0x0005249C File Offset: 0x0005069C
		private static void OnWindowMouseDown(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			global::Infragistics.Windows.Controls.ToolWindowContainer toolWindowContainer = (global::Infragistics.Windows.Controls.ToolWindowContainer)sender;
			((global::Infragistics.Windows.Controls.IToolWindowHost)toolWindowContainer).Activate();
		}

		// Token: 0x06001682 RID: 5762 RVA: 0x000524B8 File Offset: 0x000506B8
		internal void PerformInitialPositioning(ref global::System.Windows.Rect thisRect)
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = this.Child as global::Infragistics.Windows.Controls.ToolWindow;
			if (toolWindow != null && this.IsInitialPositionPending)
			{
				global::System.Windows.FrameworkElement owner = toolWindow.Owner;
				if (owner != null)
				{
					this._isInitialPositionPending = false;
					global::System.Windows.Rect? rect = null;
					switch (toolWindow.WindowStartupLocation)
					{
					case global::Infragistics.Windows.Controls.ToolWindowStartupLocation.CenterScreen:
						rect = new global::System.Windows.Rect?(global::Infragistics.Windows.Utilities.GetWorkArea(this));
						break;
					case global::Infragistics.Windows.Controls.ToolWindowStartupLocation.CenterOwnerWindow:
					{
						global::Infragistics.Windows.Controls.ToolWindow toolWindow2;
						if ((toolWindow2 = (owner as global::Infragistics.Windows.Controls.ToolWindow)) == null && (toolWindow2 = global::Infragistics.Windows.Controls.ToolWindow.GetToolWindow(owner)) == null)
						{
							toolWindow2 = ((global::Infragistics.Windows.Utilities.GetCommonAncestor(owner, null) as global::System.Windows.UIElement) ?? global::System.Windows.Window.GetWindow(this));
						}
						global::System.Windows.UIElement uielement = toolWindow2;
						if (uielement is global::System.Windows.Window && global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(uielement) > 0)
						{
							uielement = (global::System.Windows.Media.VisualTreeHelper.GetChild(uielement, 0) as global::System.Windows.UIElement);
						}
						if (uielement == null)
						{
							rect = new global::System.Windows.Rect?(global::Infragistics.Windows.Utilities.GetWorkArea(this));
						}
						else
						{
							rect = new global::System.Windows.Rect?(new global::System.Windows.Rect(global::Infragistics.Windows.Utilities.PointToScreenSafe(uielement, default(global::System.Windows.Point)), uielement.RenderSize));
						}
						break;
					}
					}
					if (rect != null)
					{
						global::System.Windows.Rect value = rect.Value;
						thisRect.Y = value.Top + (value.Height - thisRect.Height) / 2.0;
						thisRect.X = value.Left + (value.Width - thisRect.Width) / 2.0;
						this.Left = thisRect.X;
						this.Top = thisRect.Y;
					}
				}
			}
		}

		// Token: 0x06001683 RID: 5763 RVA: 0x00052620 File Offset: 0x00050820
		private void ProcessCaptureAction(global::System.Windows.Input.MouseEventArgs e)
		{
			global::System.Windows.Point relativeScreenPoint = this.GetRelativeScreenPoint(e);
			if (relativeScreenPoint != this._lastMousePoint)
			{
				double num = relativeScreenPoint.X - this._lastMousePoint.X;
				double num2 = relativeScreenPoint.Y - this._lastMousePoint.Y;
				this._lastMousePoint = relativeScreenPoint;
				double num3 = this.Left;
				double num4 = this.Top;
				if (double.IsNaN(num3))
				{
					num3 = 0.0;
				}
				if (double.IsNaN(num4))
				{
					num4 = 0.0;
				}
				double num5 = base.Width;
				double num6 = base.Height;
				double num7 = num5;
				double num8 = num6;
				if (this._captureAction == global::Infragistics.Windows.Controls.ToolWindowContainer.CaptureAction.Drag)
				{
					num3 += num;
					num4 += num2;
				}
				else if (this._captureAction == global::Infragistics.Windows.Controls.ToolWindowContainer.CaptureAction.Resize)
				{
					if (double.IsNaN(num5))
					{
						num5 = base.ActualWidth;
					}
					if (double.IsNaN(num6))
					{
						num6 = base.ActualHeight;
					}
					double maxWidth = base.MaxWidth;
					double maxHeight = base.MaxHeight;
					double minWidth = base.MinWidth;
					double minHeight = base.MinHeight;
					if ((this._resizeFlags & global::Infragistics.Windows.Controls.ToolWindowContainer.ResizeFlags.Left) == global::Infragistics.Windows.Controls.ToolWindowContainer.ResizeFlags.Left)
					{
						num7 = num5 - num;
						num3 += num;
						if (!double.IsNaN(maxWidth) && num7 > maxWidth)
						{
							double num9 = num7 - maxWidth;
							num3 += num9;
							this._lastMousePoint.X = this._lastMousePoint.X + num9;
							num7 = maxWidth;
						}
						if (num7 < base.MinWidth)
						{
							double num10 = base.MinWidth - num7;
							num3 -= num10;
							this._lastMousePoint.X = this._lastMousePoint.X - num10;
							num7 = base.MinWidth;
						}
					}
					else if ((this._resizeFlags & global::Infragistics.Windows.Controls.ToolWindowContainer.ResizeFlags.Right) == global::Infragistics.Windows.Controls.ToolWindowContainer.ResizeFlags.Right)
					{
						num7 = num5 + num;
						if (!double.IsNaN(maxWidth) && num7 > maxWidth)
						{
							double num11 = num7 - maxWidth;
							this._lastMousePoint.X = this._lastMousePoint.X - num11;
							num7 = maxWidth;
						}
						if (num7 < minWidth)
						{
							double num12 = minWidth - num7;
							this._lastMousePoint.X = this._lastMousePoint.X + num12;
							num7 = minWidth;
						}
					}
					if ((this._resizeFlags & global::Infragistics.Windows.Controls.ToolWindowContainer.ResizeFlags.Top) == global::Infragistics.Windows.Controls.ToolWindowContainer.ResizeFlags.Top)
					{
						num8 = num6 - num2;
						num4 += num2;
						if (!double.IsNaN(maxHeight) && num8 > maxHeight)
						{
							double num13 = num8 - maxHeight;
							num4 += num13;
							this._lastMousePoint.Y = this._lastMousePoint.Y + num13;
							num8 = maxHeight;
						}
						if (num8 < minHeight)
						{
							double num14 = minHeight - num8;
							num4 -= num14;
							this._lastMousePoint.Y = this._lastMousePoint.Y - num14;
							num8 = minHeight;
						}
					}
					else if ((this._resizeFlags & global::Infragistics.Windows.Controls.ToolWindowContainer.ResizeFlags.Bottom) == global::Infragistics.Windows.Controls.ToolWindowContainer.ResizeFlags.Bottom)
					{
						num8 = num6 + num2;
						if (!double.IsNaN(maxHeight) && num8 > maxHeight)
						{
							double num15 = num8 - maxHeight;
							this._lastMousePoint.Y = this._lastMousePoint.Y - num15;
							num8 = maxHeight;
						}
						if (num8 < minHeight)
						{
							double num16 = minHeight - num8;
							this._lastMousePoint.Y = this._lastMousePoint.Y + num16;
							num8 = minHeight;
						}
					}
				}
				this.ProcessMoveSize(num3, num4, num7, num8);
			}
		}

		// Token: 0x06001684 RID: 5764 RVA: 0x00052900 File Offset: 0x00050B00
		protected virtual void ProcessMoveSize(double left, double top, double width, double height)
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = this.Child as global::Infragistics.Windows.Controls.ToolWindow;
			bool flag = !toolWindow.UsesRelativePosition || toolWindow.HorizontalAlignmentMode == global::Infragistics.Windows.Controls.ToolWindowAlignmentMode.Manual;
			bool flag2 = !toolWindow.UsesRelativePosition || toolWindow.VerticalAlignmentMode == global::Infragistics.Windows.Controls.ToolWindowAlignmentMode.Manual;
			if (flag)
			{
				this.Left = left;
			}
			if (flag2)
			{
				this.Top = top;
			}
			bool flag3 = false;
			if (flag && width != base.Width)
			{
				base.Width = width;
				flag3 = true;
			}
			if (flag2 && height != base.Height)
			{
				base.Height = height;
				flag3 = true;
			}
			if (flag3)
			{
				((global::System.Windows.UIElement)base.Parent).InvalidateArrange();
			}
		}

		// Token: 0x06001685 RID: 5765 RVA: 0x00052998 File Offset: 0x00050B98
		void global::Infragistics.Windows.Controls.IToolWindowHost.DragMove(global::System.Windows.Input.MouseEventArgs e)
		{
			if (global::System.Windows.Input.Mouse.LeftButton != global::System.Windows.Input.MouseButtonState.Pressed)
			{
				throw new global::System.InvalidOperationException(global::SR.GetString("LE_ToolWindowLeftMouseButtonNotDown"));
			}
			this.OnEnteringMove(e);
			this._lastMousePoint = this.GetRelativeScreenPoint(e);
			base.CaptureMouse();
			if (base.IsMouseCaptured)
			{
				this._captureAction = global::Infragistics.Windows.Controls.ToolWindowContainer.CaptureAction.Drag;
			}
		}

		// Token: 0x06001686 RID: 5766 RVA: 0x000529E8 File Offset: 0x00050BE8
		void global::Infragistics.Windows.Controls.IToolWindowHost.DragResize(global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation location, global::System.Windows.Input.Cursor cursor, global::System.Windows.Input.MouseEventArgs e)
		{
			if (global::System.Windows.Input.Mouse.LeftButton != global::System.Windows.Input.MouseButtonState.Pressed)
			{
				throw new global::System.InvalidOperationException(global::SR.GetString("LE_ToolWindowLeftMouseButtonNotDown"));
			}
			this.OnEnteringDrag(e, location);
			this._lastMousePoint = this.GetRelativeScreenPoint(e);
			base.CaptureMouse();
			if (base.IsMouseCaptured)
			{
				base.Cursor = cursor;
				global::Infragistics.Windows.Controls.ToolWindowContainer.ResizeFlags resizeFlags;
				switch (location)
				{
				default:
					resizeFlags = global::Infragistics.Windows.Controls.ToolWindowContainer.ResizeFlags.Left;
					break;
				case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.Top:
					resizeFlags = global::Infragistics.Windows.Controls.ToolWindowContainer.ResizeFlags.Top;
					break;
				case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.Right:
					resizeFlags = global::Infragistics.Windows.Controls.ToolWindowContainer.ResizeFlags.Right;
					break;
				case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.Bottom:
					resizeFlags = global::Infragistics.Windows.Controls.ToolWindowContainer.ResizeFlags.Bottom;
					break;
				case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.TopLeft:
					resizeFlags = global::Infragistics.Windows.Controls.ToolWindowContainer.ResizeFlags.TopLeft;
					break;
				case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.TopRight:
					resizeFlags = global::Infragistics.Windows.Controls.ToolWindowContainer.ResizeFlags.TopRight;
					break;
				case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.BottomLeft:
					resizeFlags = global::Infragistics.Windows.Controls.ToolWindowContainer.ResizeFlags.BottomLeft;
					break;
				case global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation.BottomRight:
					resizeFlags = global::Infragistics.Windows.Controls.ToolWindowContainer.ResizeFlags.BottomRight;
					break;
				}
				this._resizeFlags = resizeFlags;
				this._captureAction = global::Infragistics.Windows.Controls.ToolWindowContainer.CaptureAction.Resize;
			}
		}

		// Token: 0x06001687 RID: 5767 RVA: 0x00052A90 File Offset: 0x00050C90
		void global::Infragistics.Windows.Controls.IToolWindowHost.Activate()
		{
			if (!base.IsKeyboardFocusWithin)
			{
				global::System.Windows.IInputElement focusedElement = global::System.Windows.Input.FocusManager.GetFocusedElement(this);
				if (focusedElement != null)
				{
					if (focusedElement.Focus())
					{
						((global::Infragistics.Windows.Controls.IToolWindowHost)this).BringToFront();
						return;
					}
				}
				else
				{
					this.MoveFocus(new global::System.Windows.Input.TraversalRequest(global::System.Windows.Input.FocusNavigationDirection.First));
				}
			}
		}

		// Token: 0x06001688 RID: 5768
		public abstract void Close();

		// Token: 0x06001689 RID: 5769
		public abstract void RelativePositionStateChanged();

		// Token: 0x0600168A RID: 5770
		public abstract void BringToFront();

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x0600168B RID: 5771 RVA: 0x00052ACB File Offset: 0x00050CCB
		bool global::Infragistics.Windows.Controls.IToolWindowHost.HandlesDelayedMinMaxRequests
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x0600168C RID: 5772 RVA: 0x00052ACE File Offset: 0x00050CCE
		bool global::Infragistics.Windows.Controls.IToolWindowHost.IsWindow
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x0600168D RID: 5773
		public abstract bool AllowsTransparency { get; }

		// Token: 0x0600168E RID: 5774
		public abstract bool SupportsAllowTransparency(bool allowsTransparency);

		// Token: 0x0600168F RID: 5775 RVA: 0x00052AD1 File Offset: 0x00050CD1
		public virtual void EnsureOnScreen(bool fullyInView)
		{
		}

		// Token: 0x06001690 RID: 5776 RVA: 0x00052AD3 File Offset: 0x00050CD3
		public virtual global::System.Windows.Rect GetRestoreBounds()
		{
			return global::System.Windows.Rect.Empty;
		}

		// Token: 0x06001691 RID: 5777 RVA: 0x00052ADA File Offset: 0x00050CDA
		public virtual void SetRestoreBounds(global::System.Windows.Rect restoreBounds)
		{
		}

		// Token: 0x06001692 RID: 5778 RVA: 0x00052ADC File Offset: 0x00050CDC
		public void SetWindowState(global::System.Windows.WindowState newState)
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = this._child as global::Infragistics.Windows.Controls.ToolWindow;
			if (toolWindow != null)
			{
				toolWindow.WindowState = newState;
			}
		}

		// Token: 0x06001693 RID: 5779 RVA: 0x00052AFF File Offset: 0x00050CFF
		global::System.Windows.Rect global::Infragistics.Windows.Controls.IToolWindowHost.GetWindowBounds()
		{
			return global::System.Windows.Rect.Empty;
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06001694 RID: 5780 RVA: 0x00052B06 File Offset: 0x00050D06
		bool global::Infragistics.Windows.Controls.IToolWindowHost.IsUsingOsNonClientArea
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06001695 RID: 5781
		public abstract global::Infragistics.Windows.Controls.ToolWindowHostType HostType { get; }

		// Token: 0x04000BA8 RID: 2984
		private global::Infragistics.Windows.Controls.ToolWindowContainer.CaptureAction _captureAction;

		// Token: 0x04000BA9 RID: 2985
		private global::Infragistics.Windows.Controls.ToolWindowContainer.ResizeFlags _resizeFlags;

		// Token: 0x04000BAA RID: 2986
		private global::System.Windows.Point _lastMousePoint;

		// Token: 0x04000BAB RID: 2987
		private global::System.Windows.UIElement _child;

		// Token: 0x04000BAC RID: 2988
		private bool _isInitialPositionPending;

		// Token: 0x04000BAD RID: 2989
		public static readonly global::System.Windows.DependencyProperty LeftProperty = global::Infragistics.Windows.Controls.ToolWindow.LeftProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.ToolWindowContainer), new global::System.Windows.FrameworkPropertyMetadata(0.0, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsParentArrange));

		// Token: 0x04000BAE RID: 2990
		public static readonly global::System.Windows.DependencyProperty TopProperty = global::Infragistics.Windows.Controls.ToolWindow.TopProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.ToolWindowContainer), new global::System.Windows.FrameworkPropertyMetadata(0.0, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsParentArrange));

		// Token: 0x04000BAF RID: 2991
		public static readonly global::System.Windows.DependencyProperty TopmostProperty = global::Infragistics.Windows.Controls.ToolWindow.TopmostProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.ToolWindowContainer), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x0200023D RID: 573
		private enum CaptureAction
		{
			// Token: 0x04000BB1 RID: 2993
			None,
			// Token: 0x04000BB2 RID: 2994
			Drag,
			// Token: 0x04000BB3 RID: 2995
			Resize
		}

		// Token: 0x0200023E RID: 574
		[global::System.Flags]
		internal enum ResizeFlags
		{
			// Token: 0x04000BB5 RID: 2997
			Top = 1,
			// Token: 0x04000BB6 RID: 2998
			Left = 2,
			// Token: 0x04000BB7 RID: 2999
			Right = 4,
			// Token: 0x04000BB8 RID: 3000
			Bottom = 8,
			// Token: 0x04000BB9 RID: 3001
			TopLeft = 3,
			// Token: 0x04000BBA RID: 3002
			TopRight = 5,
			// Token: 0x04000BBB RID: 3003
			BottomLeft = 10,
			// Token: 0x04000BBC RID: 3004
			BottomRight = 12
		}
	}
}
