using System;
using System.Collections;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using Infragistics.Collections;

namespace Infragistics.Windows.Controls
{
	// Token: 0x0200020B RID: 523
	internal abstract class ToolWindowContainer : global::System.Windows.FrameworkElement, global::Infragistics.Windows.Controls.IToolWindowHost
	{
		// Token: 0x0600147E RID: 5246 RVA: 0x0004BE7A File Offset: 0x0004A07A
		internal ToolWindowContainer()
		{
		}

		// Token: 0x0600147F RID: 5247 RVA: 0x0004BE84 File Offset: 0x0004A084
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

		// Token: 0x06001480 RID: 5248 RVA: 0x0004C029 File Offset: 0x0004A229
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			if (this._child != null)
			{
				this._child.Arrange(new global::System.Windows.Rect(finalSize));
			}
			return finalSize;
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06001481 RID: 5249 RVA: 0x0004C045 File Offset: 0x0004A245
		// (set) Token: 0x06001482 RID: 5250 RVA: 0x0004C050 File Offset: 0x0004A250
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

		// Token: 0x06001483 RID: 5251 RVA: 0x0004C1EC File Offset: 0x0004A3EC
		protected override global::System.Windows.Media.Visual GetVisualChild(int index)
		{
			if (index == 0 && this._child != null)
			{
				return this._child;
			}
			return base.GetVisualChild(index);
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06001484 RID: 5252 RVA: 0x0004C207 File Offset: 0x0004A407
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

		// Token: 0x06001485 RID: 5253 RVA: 0x0004C230 File Offset: 0x0004A430
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

		// Token: 0x06001486 RID: 5254 RVA: 0x0004C266 File Offset: 0x0004A466
		protected override void OnMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
			if (base.IsMouseCaptured && this._captureAction != global::Infragistics.Windows.Controls.ToolWindowContainer.CaptureAction.None)
			{
				this.ProcessCaptureAction(e);
			}
			base.OnMouseMove(e);
		}

		// Token: 0x06001487 RID: 5255 RVA: 0x0004C286 File Offset: 0x0004A486
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

		// Token: 0x06001488 RID: 5256 RVA: 0x0004C2AB File Offset: 0x0004A4AB
		protected override void OnLostMouseCapture(global::System.Windows.Input.MouseEventArgs e)
		{
			base.ClearValue(global::System.Windows.FrameworkElement.CursorProperty);
			global::Infragistics.Windows.Controls.ToolWindowContainer.CaptureAction captureAction = this._captureAction;
			base.OnLostMouseCapture(e);
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06001489 RID: 5257 RVA: 0x0004C2C6 File Offset: 0x0004A4C6
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

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x0600148A RID: 5258 RVA: 0x0004C2D3 File Offset: 0x0004A4D3
		internal bool IsInitialPositionPending
		{
			get
			{
				return this._isInitialPositionPending;
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x0600148B RID: 5259 RVA: 0x0004C2DB File Offset: 0x0004A4DB
		protected bool IsResizing
		{
			get
			{
				return this._captureAction == global::Infragistics.Windows.Controls.ToolWindowContainer.CaptureAction.Resize;
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x0600148C RID: 5260 RVA: 0x0004C2E6 File Offset: 0x0004A4E6
		// (set) Token: 0x0600148D RID: 5261 RVA: 0x0004C2F8 File Offset: 0x0004A4F8
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

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x0600148E RID: 5262 RVA: 0x0004C30B File Offset: 0x0004A50B
		// (set) Token: 0x0600148F RID: 5263 RVA: 0x0004C31D File Offset: 0x0004A51D
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

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06001490 RID: 5264 RVA: 0x0004C330 File Offset: 0x0004A530
		// (set) Token: 0x06001491 RID: 5265 RVA: 0x0004C342 File Offset: 0x0004A542
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

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06001492 RID: 5266 RVA: 0x0004C358 File Offset: 0x0004A558
		internal bool UsesRelativePosition
		{
			get
			{
				global::Infragistics.Windows.Controls.ToolWindow toolWindow = this.Child as global::Infragistics.Windows.Controls.ToolWindow;
				return toolWindow != null && toolWindow.UsesRelativePosition;
			}
		}

		// Token: 0x06001493 RID: 5267
		protected abstract global::System.Windows.Point GetRelativeScreenPoint(global::System.Windows.Input.MouseEventArgs e);

		// Token: 0x06001494 RID: 5268 RVA: 0x0004C37C File Offset: 0x0004A57C
		protected virtual void OnChildChanged(global::System.Windows.UIElement oldChild, global::System.Windows.UIElement newChild)
		{
		}

		// Token: 0x06001495 RID: 5269 RVA: 0x0004C37E File Offset: 0x0004A57E
		protected virtual void OnEnteringMove(global::System.Windows.Input.MouseEventArgs e)
		{
		}

		// Token: 0x06001496 RID: 5270 RVA: 0x0004C380 File Offset: 0x0004A580
		protected virtual void OnEnteringDrag(global::System.Windows.Input.MouseEventArgs e, global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation location)
		{
		}

		// Token: 0x06001497 RID: 5271 RVA: 0x0004C384 File Offset: 0x0004A584
		private static void OnGotKeyboardFocusWithin(object sender, global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = (e.NewFocus is global::System.Windows.DependencyObject) ? global::Infragistics.Windows.Controls.ToolWindow.GetToolWindow((global::System.Windows.DependencyObject)e.NewFocus) : null;
			if (toolWindow != null && !toolWindow.IsActive)
			{
				toolWindow.SetValue(global::Infragistics.Windows.Controls.ToolWindow.IsActivePropertyKey, global::Infragistics.KnownBoxes.TrueBox);
			}
		}

		// Token: 0x06001498 RID: 5272 RVA: 0x0004C3D0 File Offset: 0x0004A5D0
		private static void OnLostKeyboardFocusWithin(object sender, global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = (e.OldFocus is global::System.Windows.DependencyObject) ? global::Infragistics.Windows.Controls.ToolWindow.GetToolWindow((global::System.Windows.DependencyObject)e.OldFocus) : null;
			global::Infragistics.Windows.Controls.ToolWindow toolWindow2 = (e.NewFocus is global::System.Windows.DependencyObject) ? global::Infragistics.Windows.Controls.ToolWindow.GetToolWindow((global::System.Windows.DependencyObject)e.NewFocus) : null;
			if (toolWindow != toolWindow2 && toolWindow != null)
			{
				toolWindow.ClearValue(global::Infragistics.Windows.Controls.ToolWindow.IsActivePropertyKey);
			}
		}

		// Token: 0x06001499 RID: 5273 RVA: 0x0004C434 File Offset: 0x0004A634
		private static void OnPreviousLostKeyboardFocus(object sender, global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.ToolWindowContainer toolWindowContainer = sender as global::Infragistics.Windows.Controls.ToolWindowContainer;
			if (e.NewFocus is global::System.Windows.Window && global::System.Windows.Media.VisualTreeHelper.GetParent((global::System.Windows.Window)e.NewFocus) == null)
			{
				global::System.Windows.DependencyObject dependencyObject = e.OldFocus as global::System.Windows.DependencyObject;
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

		// Token: 0x0600149A RID: 5274 RVA: 0x0004C4C0 File Offset: 0x0004A6C0
		private static void OnWindowMouseDown(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			global::Infragistics.Windows.Controls.ToolWindowContainer toolWindowContainer = (global::Infragistics.Windows.Controls.ToolWindowContainer)sender;
			((global::Infragistics.Windows.Controls.IToolWindowHost)toolWindowContainer).Activate();
		}

		// Token: 0x0600149B RID: 5275 RVA: 0x0004C4DC File Offset: 0x0004A6DC
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

		// Token: 0x0600149C RID: 5276 RVA: 0x0004C644 File Offset: 0x0004A844
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

		// Token: 0x0600149D RID: 5277 RVA: 0x0004C924 File Offset: 0x0004AB24
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

		// Token: 0x0600149E RID: 5278 RVA: 0x0004C9BC File Offset: 0x0004ABBC
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

		// Token: 0x0600149F RID: 5279 RVA: 0x0004CA0C File Offset: 0x0004AC0C
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

		// Token: 0x060014A0 RID: 5280 RVA: 0x0004CAB4 File Offset: 0x0004ACB4
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

		// Token: 0x060014A1 RID: 5281
		public abstract void Close();

		// Token: 0x060014A2 RID: 5282
		public abstract void RelativePositionStateChanged();

		// Token: 0x060014A3 RID: 5283
		public abstract void BringToFront();

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x060014A4 RID: 5284 RVA: 0x0004CAEF File Offset: 0x0004ACEF
		bool global::Infragistics.Windows.Controls.IToolWindowHost.HandlesDelayedMinMaxRequests
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x060014A5 RID: 5285 RVA: 0x0004CAF2 File Offset: 0x0004ACF2
		bool global::Infragistics.Windows.Controls.IToolWindowHost.IsWindow
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x060014A6 RID: 5286
		public abstract bool AllowsTransparency { get; }

		// Token: 0x060014A7 RID: 5287
		public abstract bool SupportsAllowTransparency(bool allowsTransparency);

		// Token: 0x060014A8 RID: 5288 RVA: 0x0004CAF5 File Offset: 0x0004ACF5
		public virtual void EnsureOnScreen(bool fullyInView)
		{
		}

		// Token: 0x060014A9 RID: 5289 RVA: 0x0004CAF7 File Offset: 0x0004ACF7
		public virtual global::System.Windows.Rect GetRestoreBounds()
		{
			return global::System.Windows.Rect.Empty;
		}

		// Token: 0x060014AA RID: 5290 RVA: 0x0004CAFE File Offset: 0x0004ACFE
		public virtual void SetRestoreBounds(global::System.Windows.Rect restoreBounds)
		{
		}

		// Token: 0x060014AB RID: 5291 RVA: 0x0004CB00 File Offset: 0x0004AD00
		public void SetWindowState(global::System.Windows.WindowState newState)
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = this._child as global::Infragistics.Windows.Controls.ToolWindow;
			if (toolWindow != null)
			{
				toolWindow.WindowState = newState;
			}
		}

		// Token: 0x060014AC RID: 5292 RVA: 0x0004CB23 File Offset: 0x0004AD23
		global::System.Windows.Rect global::Infragistics.Windows.Controls.IToolWindowHost.GetWindowBounds()
		{
			return global::System.Windows.Rect.Empty;
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x060014AD RID: 5293 RVA: 0x0004CB2A File Offset: 0x0004AD2A
		bool global::Infragistics.Windows.Controls.IToolWindowHost.IsUsingOsNonClientArea
		{
			get
			{
				return false;
			}
		}

		// Token: 0x04000A56 RID: 2646
		private global::Infragistics.Windows.Controls.ToolWindowContainer.CaptureAction _captureAction;

		// Token: 0x04000A57 RID: 2647
		private global::Infragistics.Windows.Controls.ToolWindowContainer.ResizeFlags _resizeFlags;

		// Token: 0x04000A58 RID: 2648
		private global::System.Windows.Point _lastMousePoint;

		// Token: 0x04000A59 RID: 2649
		private global::System.Windows.UIElement _child;

		// Token: 0x04000A5A RID: 2650
		private bool _isInitialPositionPending;

		// Token: 0x04000A5B RID: 2651
		public static readonly global::System.Windows.DependencyProperty LeftProperty = global::Infragistics.Windows.Controls.ToolWindow.LeftProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.ToolWindowContainer), new global::System.Windows.FrameworkPropertyMetadata(0.0, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsParentArrange));

		// Token: 0x04000A5C RID: 2652
		public static readonly global::System.Windows.DependencyProperty TopProperty = global::Infragistics.Windows.Controls.ToolWindow.TopProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.ToolWindowContainer), new global::System.Windows.FrameworkPropertyMetadata(0.0, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsParentArrange));

		// Token: 0x04000A5D RID: 2653
		public static readonly global::System.Windows.DependencyProperty TopmostProperty = global::Infragistics.Windows.Controls.ToolWindow.TopmostProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.ToolWindowContainer), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x0200020C RID: 524
		private enum CaptureAction
		{
			// Token: 0x04000A5F RID: 2655
			None,
			// Token: 0x04000A60 RID: 2656
			Drag,
			// Token: 0x04000A61 RID: 2657
			Resize
		}

		// Token: 0x0200020D RID: 525
		[global::System.Flags]
		internal enum ResizeFlags
		{
			// Token: 0x04000A63 RID: 2659
			Top = 1,
			// Token: 0x04000A64 RID: 2660
			Left = 2,
			// Token: 0x04000A65 RID: 2661
			Right = 4,
			// Token: 0x04000A66 RID: 2662
			Bottom = 8,
			// Token: 0x04000A67 RID: 2663
			TopLeft = 3,
			// Token: 0x04000A68 RID: 2664
			TopRight = 5,
			// Token: 0x04000A69 RID: 2665
			BottomLeft = 10,
			// Token: 0x04000A6A RID: 2666
			BottomRight = 12
		}
	}
}
