using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Infragistics.Windows.Resizing
{
	// Token: 0x0200026D RID: 621
	public class ResizeController
	{
		// Token: 0x06001898 RID: 6296 RVA: 0x0005E270 File Offset: 0x0005C470
		public ResizeController(global::Infragistics.Windows.Resizing.IResizeHost host)
		{
			if (host == null)
			{
				throw new global::System.ArgumentNullException("host");
			}
			this._host = host;
			global::System.Windows.FrameworkElement rootElement = this._host.RootElement;
			rootElement.PreviewMouseLeftButtonDown += this.OnPreviewMouseLeftButtonDown;
			rootElement.QueryCursor += this.OnQueryCursor;
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06001899 RID: 6297 RVA: 0x0005E2D7 File Offset: 0x0005C4D7
		public global::Infragistics.Windows.Resizing.IResizeHost Host
		{
			get
			{
				return this._host;
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x0600189A RID: 6298 RVA: 0x0005E2DF File Offset: 0x0005C4DF
		// (set) Token: 0x0600189B RID: 6299 RVA: 0x0005E2E7 File Offset: 0x0005C4E7
		public double InterItemSpacingX
		{
			get
			{
				return this._interItemSpacingX;
			}
			set
			{
				global::Infragistics.CoreUtilities.ValidateIsNotNan(value);
				global::Infragistics.CoreUtilities.ValidateIsNotInfinity(value);
				global::Infragistics.CoreUtilities.ValidateIsNotNegative(value);
				this._interItemSpacingX = value;
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x0600189C RID: 6300 RVA: 0x0005E302 File Offset: 0x0005C502
		// (set) Token: 0x0600189D RID: 6301 RVA: 0x0005E30A File Offset: 0x0005C50A
		public double InterItemSpacingY
		{
			get
			{
				return this._interItemSpacingY;
			}
			set
			{
				global::Infragistics.CoreUtilities.ValidateIsNotNan(value);
				global::Infragistics.CoreUtilities.ValidateIsNotInfinity(value);
				global::Infragistics.CoreUtilities.ValidateIsNotNegative(value);
				this._interItemSpacingY = value;
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x0600189E RID: 6302 RVA: 0x0005E325 File Offset: 0x0005C525
		public bool IsResizing
		{
			get
			{
				return this._resizeTarget != null && (this._constraintsInXAxis != null || this._constraintsInYAxis != null);
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x0600189F RID: 6303 RVA: 0x0005E348 File Offset: 0x0005C548
		public global::System.Windows.FrameworkElement ResizerBar
		{
			get
			{
				if (this.IsResizing)
				{
					if (this._constraintsInXAxis != null && !this._constraintsInXAxis.ResizeWhileDragging)
					{
						return this._constraintsInXAxis.ResizerBar;
					}
					if (this._constraintsInYAxis != null && !this._constraintsInYAxis.ResizeWhileDragging)
					{
						return this._constraintsInYAxis.ResizerBar;
					}
				}
				return null;
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x060018A0 RID: 6304 RVA: 0x0005E3A0 File Offset: 0x0005C5A0
		// (set) Token: 0x060018A1 RID: 6305 RVA: 0x0005E3A8 File Offset: 0x0005C5A8
		public double ResizerBarWidth
		{
			get
			{
				return this._resizerBarWidth;
			}
			set
			{
				if (value < 1.0)
				{
					throw new global::System.ArgumentOutOfRangeException("value", global::SR.GetString("LE_ArgumentOutOfRangeException_5"));
				}
				this._resizerBarWidth = value;
			}
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x0005E3D2 File Offset: 0x0005C5D2
		public void CancelResize()
		{
			this.ClearConstraints(true);
			this.ClearConstraints(false);
		}

		// Token: 0x060018A3 RID: 6307 RVA: 0x0005E3E4 File Offset: 0x0005C5E4
		public void PositionResizerBar()
		{
			if (this._constraintsInXAxis != null && this._constraintsInXAxis.ResizerBar != null)
			{
				double left = global::System.Windows.Controls.Canvas.GetLeft(this._constraintsInXAxis.ResizerBar);
				double y = 0.0;
				this._constraintsInXAxis.ResizerBar.Arrange(new global::System.Windows.Rect(left, y, this._constraintsInXAxis.ResizerBar.DesiredSize.Width, this._constraintsInXAxis.ResizerBar.DesiredSize.Height));
			}
			if (this._constraintsInYAxis != null && this._constraintsInYAxis.ResizerBar != null)
			{
				double x = 0.0;
				double top = global::System.Windows.Controls.Canvas.GetTop(this._constraintsInYAxis.ResizerBar);
				this._constraintsInYAxis.ResizerBar.Arrange(new global::System.Windows.Rect(x, top, this._constraintsInYAxis.ResizerBar.DesiredSize.Width, this._constraintsInYAxis.ResizerBar.DesiredSize.Height));
			}
		}

		// Token: 0x060018A4 RID: 6308 RVA: 0x0005E4E4 File Offset: 0x0005C6E4
		internal void BeginResize(global::System.Windows.Input.MouseButtonEventArgs e, global::System.Windows.FrameworkElement itemToResize, bool? resizeInXAxis)
		{
			if (e.ClickCount == 2)
			{
				global::Infragistics.Windows.Resizing.IAutoResizeHost autoResizeHost = this._host as global::Infragistics.Windows.Resizing.IAutoResizeHost;
				if (autoResizeHost != null)
				{
					if (resizeInXAxis != null)
					{
						if (autoResizeHost.PerformAutoSize(itemToResize, resizeInXAxis.Value))
						{
							e.Handled = true;
							return;
						}
					}
					else
					{
						bool flag = autoResizeHost.PerformAutoSize(itemToResize, true);
						if (autoResizeHost.PerformAutoSize(itemToResize, false))
						{
							flag = true;
						}
						if (flag)
						{
							e.Handled = true;
							return;
						}
					}
				}
			}
			global::System.Windows.FrameworkElement resizeAreaForItem = this.Host.GetResizeAreaForItem(itemToResize);
			if (resizeAreaForItem == null)
			{
				return;
			}
			this._resizeTarget = itemToResize;
			this._resizeInXAxis = resizeInXAxis;
			this._isFlowDirectionFlipped = (this._resizeTarget.FlowDirection != resizeAreaForItem.FlowDirection);
			this._lastDragPoint = (this._originalDragPoint = e.MouseDevice.GetPosition(resizeAreaForItem));
			if (resizeInXAxis != null)
			{
				if (this.InitializeConstraints(e, resizeAreaForItem, resizeInXAxis.Value) == null)
				{
					return;
				}
			}
			else
			{
				this.InitializeConstraints(e, resizeAreaForItem, true);
				this._resizeTarget = itemToResize;
				this.InitializeConstraints(e, resizeAreaForItem, false);
				if (this._constraintsInXAxis == null && this._constraintsInYAxis == null)
				{
					return;
				}
			}
			this._cachedCursor = this.Host.RootElement.Cursor;
			this.Host.RootElement.Cursor = this.GetResizeCursor(itemToResize, resizeInXAxis);
			this.HookMouseEvents();
			e.Handled = true;
		}

		// Token: 0x060018A5 RID: 6309 RVA: 0x0005E624 File Offset: 0x0005C824
		private global::Infragistics.Windows.Resizing.ResizeConstraints InitializeConstraints(global::System.Windows.Input.MouseButtonEventArgs e, global::System.Windows.FrameworkElement resizeArea, bool resizeInXAxis)
		{
			global::System.Windows.FrameworkElement resizerBar = this.CreateResizerBar(resizeInXAxis, resizeArea);
			global::System.Windows.Point point = resizeArea.TranslatePoint(this._originalDragPoint, this._resizeTarget);
			global::System.Windows.Point point2 = default(global::System.Windows.Point);
			if (this._isFlowDirectionFlipped)
			{
				point2.X = this._resizeTarget.ActualWidth;
			}
			this._originalTargetOffset = resizeArea.TranslatePoint(point2, this._resizeTarget);
			if (this._resizeInXAxis == true)
			{
				double actualWidth = this._resizeTarget.ActualWidth;
				if (this._isFlowDirectionFlipped)
				{
					point.X += actualWidth;
				}
				this._originalDragPointOffset.X = actualWidth - (point.X + this.ResizerBarWidth / 2.0);
				this._resizerBarOffset.X = global::System.Math.Max(actualWidth - point.X, 0.0) - this.ResizerBarWidth / 2.0;
			}
			else
			{
				double actualHeight = this._resizeTarget.ActualHeight;
				this._originalDragPointOffset.Y = actualHeight - (point.Y + this.ResizerBarWidth / 2.0);
				this._resizerBarOffset.Y = global::System.Math.Max(actualHeight - point.Y, 0.0) - this.ResizerBarWidth / 2.0;
			}
			global::Infragistics.Windows.Resizing.ResizeConstraints resizeConstraints = new global::Infragistics.Windows.Resizing.ResizeConstraints(resizerBar, resizeArea, resizeInXAxis);
			if (resizeInXAxis)
			{
				this._constraintsInXAxis = resizeConstraints;
			}
			else
			{
				this._constraintsInYAxis = resizeConstraints;
			}
			this.PositionResizerBar(e.MouseDevice, resizeInXAxis);
			this.Host.InitializeResizeConstraints(resizeArea, this._resizeTarget, resizeConstraints);
			if (resizeConstraints.Cancel)
			{
				this.ClearConstraints(resizeInXAxis);
				return null;
			}
			if (resizeConstraints.ResizeWhileDragging)
			{
				this._originalDragPointOffset = default(global::System.Windows.Point);
				this._resizerBarOffset = default(global::System.Windows.Point);
				resizeConstraints.ResizerBar.Visibility = global::System.Windows.Visibility.Collapsed;
			}
			else
			{
				resizeConstraints.ResizerBar.Visibility = global::System.Windows.Visibility.Visible;
				resizeConstraints.ResizerBar.Measure(new global::System.Windows.Size(resizeArea.ActualWidth, resizeArea.ActualHeight));
			}
			return resizeConstraints;
		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x0005E830 File Offset: 0x0005CA30
		private void ClearConstraints(bool resizeInXAxis)
		{
			global::Infragistics.Windows.Resizing.ResizeConstraints resizeConstraints;
			if (resizeInXAxis)
			{
				resizeConstraints = this._constraintsInXAxis;
			}
			else
			{
				resizeConstraints = this._constraintsInYAxis;
			}
			if (resizeConstraints != null)
			{
				this.Host.RemoveResizerBar(resizeConstraints.ResizerBar);
				if (resizeInXAxis)
				{
					this._constraintsInXAxis = null;
				}
				else
				{
					this._constraintsInYAxis = null;
				}
				this.Host.RootElement.Cursor = this._cachedCursor;
			}
			this._resizeTarget = null;
			this.UnhookMouseEvents();
		}

		// Token: 0x060018A7 RID: 6311 RVA: 0x0005E89C File Offset: 0x0005CA9C
		private global::System.Windows.FrameworkElement CreateResizerBar(bool vertical, global::System.Windows.FrameworkElement resizeArea)
		{
			double resizerBarWidth = this.ResizerBarWidth;
			global::System.Windows.Shapes.Rectangle rectangle = new global::System.Windows.Shapes.Rectangle();
			rectangle.Visibility = global::System.Windows.Visibility.Collapsed;
			rectangle.Opacity = 0.18;
			rectangle.Fill = global::System.Windows.Media.Brushes.Black;
			if (vertical)
			{
				rectangle.Height = resizeArea.ActualHeight;
				rectangle.Width = resizerBarWidth;
				global::System.Windows.Controls.Canvas.SetTop(rectangle, 0.0);
			}
			else
			{
				rectangle.Height = resizerBarWidth;
				rectangle.Width = resizeArea.ActualWidth;
				global::System.Windows.Controls.Canvas.SetLeft(rectangle, 0.0);
			}
			this.Host.AddResizerBar(rectangle);
			return rectangle;
		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x0005E930 File Offset: 0x0005CB30
		private global::System.Windows.FrameworkElement GetAncestorResizableItem(global::System.Windows.IInputElement descendant)
		{
			global::System.Windows.FrameworkElement rootElement = this._host.RootElement;
			for (global::System.Windows.DependencyObject dependencyObject = (global::System.Windows.DependencyObject)descendant; dependencyObject != null; dependencyObject = global::Infragistics.Windows.Utilities.GetParent(dependencyObject, false))
			{
				if (dependencyObject == rootElement)
				{
					return null;
				}
				if (dependencyObject is global::Infragistics.Windows.Resizing.IResizableElement)
				{
					return dependencyObject as global::System.Windows.FrameworkElement;
				}
			}
			return null;
		}

		// Token: 0x060018A9 RID: 6313 RVA: 0x0005E974 File Offset: 0x0005CB74
		internal double GetConstrainedPosition(global::System.Windows.Input.MouseDevice device, bool adjustWithOffset, bool resizeInXAxis)
		{
			global::System.Windows.Point point;
			return this.GetConstrainedPosition(device, adjustWithOffset, resizeInXAxis, out point);
		}

		// Token: 0x060018AA RID: 6314 RVA: 0x0005E98C File Offset: 0x0005CB8C
		internal double GetConstrainedPosition(global::System.Windows.Input.MouseDevice device, bool adjustWithOffset, bool resizeInXAxis, out global::System.Windows.Point currentResizeAreaPoint)
		{
			currentResizeAreaPoint = default(global::System.Windows.Point);
			global::Infragistics.Windows.Resizing.ResizeConstraints resizeConstraints;
			if (resizeInXAxis)
			{
				resizeConstraints = this._constraintsInXAxis;
			}
			else
			{
				resizeConstraints = this._constraintsInYAxis;
			}
			if (resizeConstraints == null || resizeConstraints.Cancel)
			{
				return 0.0;
			}
			global::System.Windows.Point position = device.GetPosition(resizeConstraints.ResizeArea);
			global::System.Windows.Point point = resizeConstraints.ResizeArea.TranslatePoint(position, this._resizeTarget);
			global::System.Windows.Point point2 = default(global::System.Windows.Point);
			if (this._isFlowDirectionFlipped)
			{
				point2.X = this._resizeTarget.ActualWidth;
				point.X = -point.X;
				point.X += this._resizeTarget.ActualWidth;
			}
			global::System.Windows.Point point3 = resizeConstraints.ResizeArea.TranslatePoint(point2, this._resizeTarget);
			double num;
			double num2;
			if (resizeInXAxis)
			{
				point.X += this._originalTargetOffset.X - point3.X;
				num = position.X - point.X;
				num2 = position.X;
			}
			else
			{
				point.Y += this._originalTargetOffset.Y - point3.Y;
				num = position.Y - point.Y;
				num2 = position.Y;
			}
			if (adjustWithOffset)
			{
				if (resizeInXAxis)
				{
					num2 += this._resizerBarOffset.X;
				}
				else
				{
					num2 += this._resizerBarOffset.Y;
				}
			}
			double num3 = num + resizeConstraints.MinExtent;
			double num4;
			if (resizeConstraints.MaxExtent > resizeConstraints.MinExtent)
			{
				num4 = num + resizeConstraints.MaxExtent;
			}
			else
			{
				num4 = num3;
			}
			double num5 = num2;
			if (num2 < num3)
			{
				num2 = num3;
			}
			else if (num2 > num4 && num4 != 0.0)
			{
				num2 = num4;
			}
			double num6 = num5 - num2;
			currentResizeAreaPoint = position;
			if (resizeInXAxis)
			{
				currentResizeAreaPoint.X -= num6;
			}
			else
			{
				currentResizeAreaPoint.Y -= num6;
			}
			return num2;
		}

		// Token: 0x060018AB RID: 6315 RVA: 0x0005EB68 File Offset: 0x0005CD68
		private global::System.Windows.FrameworkElement GetElementToResize(global::System.Windows.FrameworkElement element, global::System.Windows.Input.MouseDevice mouseDevice, out bool? processWidth)
		{
			processWidth = new bool?(true);
			global::System.Windows.FrameworkElement frameworkElement = this.GetAncestorResizableItem(element);
			if (frameworkElement == null)
			{
				global::System.Windows.FrameworkElement rootElement = this._host.RootElement;
				frameworkElement = this.GetNeighborUsingInterItemSpacing(rootElement, mouseDevice, true);
				if (frameworkElement == null)
				{
					frameworkElement = this.GetNeighborUsingInterItemSpacing(rootElement, mouseDevice, false);
				}
				if (frameworkElement == null)
				{
					return null;
				}
			}
			global::Infragistics.Windows.Resizing.IResizeHost host = this.Host;
			if (host == null)
			{
				return null;
			}
			global::Infragistics.Windows.Resizing.IResizeHostMulti resizeHostMulti = host as global::Infragistics.Windows.Resizing.IResizeHostMulti;
			bool flag = false;
			if (resizeHostMulti != null)
			{
				flag = resizeHostMulti.CanResizeInBothDimensions(frameworkElement);
			}
			global::System.Windows.FrameworkElement frameworkElement2 = this.GetElementToResizeHelper(frameworkElement, mouseDevice, processWidth.Value);
			if (frameworkElement2 != null && !this.IsValidResizeElement(frameworkElement2, mouseDevice))
			{
				frameworkElement2 = null;
			}
			if (frameworkElement2 != null && !flag && host.CanResize(frameworkElement2, processWidth.Value))
			{
				return frameworkElement2;
			}
			processWidth = new bool?(false);
			global::System.Windows.FrameworkElement frameworkElement3 = this.GetElementToResizeHelper(frameworkElement, mouseDevice, processWidth.Value);
			if (frameworkElement3 != null && !this.IsValidResizeElement(frameworkElement3, mouseDevice))
			{
				frameworkElement3 = null;
			}
			if (frameworkElement3 != null && !flag && host.CanResize(frameworkElement3, processWidth.Value))
			{
				return frameworkElement3;
			}
			if (flag)
			{
				if (frameworkElement3 != null && frameworkElement2 != null && frameworkElement3 == frameworkElement2)
				{
					processWidth = null;
					return frameworkElement3;
				}
				if (frameworkElement2 != null)
				{
					processWidth = new bool?(true);
					return frameworkElement2;
				}
				if (frameworkElement3 != null)
				{
					processWidth = new bool?(false);
					return frameworkElement3;
				}
			}
			return null;
		}

		// Token: 0x060018AC RID: 6316 RVA: 0x0005ECA0 File Offset: 0x0005CEA0
		private global::System.Windows.FrameworkElement GetElementToResizeHelper(global::System.Windows.FrameworkElement resizableElement, global::System.Windows.Input.MouseDevice mouseDevice, bool processWidth)
		{
			global::System.Windows.FrameworkElement resizeAreaForItem = this._host.GetResizeAreaForItem(resizableElement);
			if (resizeAreaForItem == null)
			{
				return null;
			}
			global::System.Windows.Point position = mouseDevice.GetPosition(resizableElement);
			if (processWidth)
			{
				bool flag = resizeAreaForItem.FlowDirection != resizableElement.FlowDirection;
				double actualWidth = resizableElement.ActualWidth;
				if ((position.X < 3.0 && !flag) || (flag && position.X >= actualWidth - 3.0))
				{
					global::System.Windows.Point point = position;
					point.X = ((!flag) ? -2.0 : (actualWidth + 2.0));
					global::System.Windows.Point point2 = resizableElement.TranslatePoint(point, resizeAreaForItem);
					global::System.Windows.FrameworkElement frameworkElement = resizeAreaForItem.InputHitTest(point2) as global::System.Windows.FrameworkElement;
					if (frameworkElement != null)
					{
						global::System.Windows.FrameworkElement ancestorResizableItem = this.GetAncestorResizableItem(frameworkElement);
						if (ancestorResizableItem != null && ancestorResizableItem != resizableElement)
						{
							return this.GetElementToResizeHelper(ancestorResizableItem, mouseDevice, processWidth);
						}
					}
				}
				else if ((position.X < 3.0 && flag) || (!flag && position.X >= actualWidth - 3.0))
				{
					return resizableElement;
				}
			}
			else if (position.Y < 3.0)
			{
				global::System.Windows.Point position2 = mouseDevice.GetPosition(resizableElement);
				position2.Y -= 2.0 + position.Y;
				global::System.Windows.Point point3 = resizableElement.TranslatePoint(position2, resizeAreaForItem);
				global::System.Windows.FrameworkElement frameworkElement = resizeAreaForItem.InputHitTest(point3) as global::System.Windows.FrameworkElement;
				if (frameworkElement != null)
				{
					global::System.Windows.FrameworkElement ancestorResizableItem2 = this.GetAncestorResizableItem(frameworkElement);
					if (ancestorResizableItem2 != null && ancestorResizableItem2 != resizableElement)
					{
						return this.GetElementToResizeHelper(ancestorResizableItem2, mouseDevice, processWidth);
					}
				}
			}
			else
			{
				double actualHeight = resizableElement.ActualHeight;
				if (position.Y >= actualHeight - 3.0)
				{
					return resizableElement;
				}
			}
			return null;
		}

		// Token: 0x060018AD RID: 6317 RVA: 0x0005EE44 File Offset: 0x0005D044
		private global::System.Windows.FrameworkElement GetNeighborUsingInterItemSpacing(global::System.Windows.FrameworkElement root, global::System.Windows.Input.MouseDevice mouseDevice, bool processWidth)
		{
			double num = global::System.Math.Ceiling(this._interItemSpacingX);
			double num2 = global::System.Math.Ceiling(this._interItemSpacingY);
			if (num < 0.1 && num2 < 0.1)
			{
				return null;
			}
			global::System.Windows.Point position = mouseDevice.GetPosition(root);
			if (processWidth)
			{
				return this.GetNeighborHelper(root, mouseDevice, position, -num, 0.0);
			}
			global::System.Windows.FrameworkElement neighborHelper = this.GetNeighborHelper(root, mouseDevice, position, 0.0, -num2);
			if (neighborHelper != null)
			{
				return neighborHelper;
			}
			global::Infragistics.Windows.Resizing.IResizeHostMulti resizeHostMulti = this._host as global::Infragistics.Windows.Resizing.IResizeHostMulti;
			if (resizeHostMulti != null)
			{
				return this.GetNeighborHelper(root, mouseDevice, position, -num, -num2);
			}
			return null;
		}

		// Token: 0x060018AE RID: 6318 RVA: 0x0005EEE0 File Offset: 0x0005D0E0
		private global::System.Windows.FrameworkElement GetNeighborHelper(global::System.Windows.FrameworkElement root, global::System.Windows.Input.MouseDevice mouseDevice, global::System.Windows.Point point, double adjustmentX, double adjustmentY)
		{
			double num = global::System.Math.Abs(adjustmentX);
			double num2 = global::System.Math.Abs(adjustmentY);
			double num3 = 0.0;
			double num4 = 0.0;
			while (adjustmentX != 0.0 || adjustmentY != 0.0)
			{
				double num5 = global::System.Math.Max(adjustmentX, -4.0);
				double num6 = global::System.Math.Max(adjustmentY, -4.0);
				point.X += num5;
				point.Y += num6;
				global::System.Windows.FrameworkElement neighborResizableElementHelper = this.GetNeighborResizableElementHelper(root, mouseDevice, point);
				if (neighborResizableElementHelper != null)
				{
					return neighborResizableElementHelper;
				}
				num3 += global::System.Math.Abs(num5);
				num4 += global::System.Math.Abs(num6);
				if (num3 >= num && num4 >= num2)
				{
					return null;
				}
				if ((adjustmentX >= -4.0 || point.X < 4.0) && (adjustmentY >= -4.0 || point.Y < 4.0))
				{
					break;
				}
				adjustmentX -= num5;
				num6 -= num6;
			}
			return null;
		}

		// Token: 0x060018AF RID: 6319 RVA: 0x0005EFF8 File Offset: 0x0005D1F8
		private global::System.Windows.FrameworkElement GetNeighborResizableElementHelper(global::System.Windows.FrameworkElement root, global::System.Windows.Input.MouseDevice mouseDevice, global::System.Windows.Point point)
		{
			global::System.Windows.FrameworkElement frameworkElement = root.InputHitTest(point) as global::System.Windows.FrameworkElement;
			if (frameworkElement != null)
			{
				frameworkElement = this.GetAncestorResizableItem(frameworkElement);
			}
			return frameworkElement;
		}

		// Token: 0x060018B0 RID: 6320 RVA: 0x0005F020 File Offset: 0x0005D220
		private global::System.Windows.Input.Cursor GetResizeCursor(global::System.Windows.FrameworkElement resizeableItem, bool? resizeInXAxis)
		{
			if (resizeInXAxis == null)
			{
				global::Infragistics.Windows.Resizing.IResizeHostMulti resizeHostMulti = this.Host as global::Infragistics.Windows.Resizing.IResizeHostMulti;
				if (resizeHostMulti != null)
				{
					return resizeHostMulti.GetMultiResizeCursor(resizeableItem, global::System.Windows.Input.Cursors.SizeNWSE);
				}
				return global::System.Windows.Input.Cursors.SizeNWSE;
			}
			else
			{
				if (resizeInXAxis == true)
				{
					return this.Host.GetResizeCursor(resizeableItem, resizeInXAxis.Value, global::System.Windows.Input.Cursors.SizeWE);
				}
				return this.Host.GetResizeCursor(resizeableItem, resizeInXAxis.Value, global::System.Windows.Input.Cursors.SizeNS);
			}
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x0005F0A0 File Offset: 0x0005D2A0
		private void HookMouseEvents()
		{
			global::System.Windows.FrameworkElement rootElement = this.Host.RootElement;
			rootElement.PreviewMouseMove += this.OnPreviewMouseMove;
			rootElement.PreviewMouseLeftButtonUp += this.OnPreviewMouseLeftButtonUp;
			rootElement.LostMouseCapture += this.OnLostMouseCapture;
			rootElement.PreviewKeyDown += this.OnPreviewKeyDown;
			this._mouseEventsHooked = true;
			rootElement.CaptureMouse();
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x0005F110 File Offset: 0x0005D310
		private bool IsValidResizeElement(global::System.Windows.FrameworkElement element, global::System.Windows.Input.MouseDevice mouseDevice)
		{
			if (element != null && !this.IsResizing && mouseDevice != null)
			{
				global::System.Windows.IInputElement captured = mouseDevice.Captured;
				if (captured != null)
				{
					global::System.Windows.DependencyObject dependencyObject = captured as global::System.Windows.DependencyObject;
					if (dependencyObject == null)
					{
						return false;
					}
					if (element != dependencyObject && !global::Infragistics.Windows.Utilities.IsDescendantOf(dependencyObject, element, false))
					{
						return false;
					}
				}
				global::System.Windows.FrameworkElement resizeAreaForItem = this._host.GetResizeAreaForItem(element);
				if (resizeAreaForItem != null)
				{
					global::System.Windows.Point position = mouseDevice.GetPosition(resizeAreaForItem);
					return position.X >= 0.0 && position.Y >= 0.0 && position.X < resizeAreaForItem.ActualWidth && position.Y < resizeAreaForItem.ActualHeight;
				}
			}
			return true;
		}

		// Token: 0x060018B3 RID: 6323 RVA: 0x0005F1B8 File Offset: 0x0005D3B8
		private void OnLostMouseCapture(object sender, global::System.Windows.Input.MouseEventArgs e)
		{
			this.CancelResize();
			this.UnhookMouseEvents();
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x0005F1C6 File Offset: 0x0005D3C6
		private void OnPreviewKeyDown(object sender, global::System.Windows.Input.KeyEventArgs e)
		{
			if (this._resizeTarget != null && e.Key == global::System.Windows.Input.Key.Escape)
			{
				this.CancelResize();
				e.Handled = true;
			}
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x0005F1E8 File Offset: 0x0005D3E8
		private void OnPreviewMouseLeftButtonDown(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (!e.Handled)
			{
				global::System.Windows.FrameworkElement frameworkElement = e.OriginalSource as global::System.Windows.FrameworkElement;
				if (frameworkElement != null)
				{
					bool? resizeInXAxis;
					global::System.Windows.FrameworkElement elementToResize = this.GetElementToResize(frameworkElement, e.MouseDevice, out resizeInXAxis);
					if (elementToResize != null)
					{
						this.BeginResize(e, elementToResize, resizeInXAxis);
					}
				}
			}
		}

		// Token: 0x060018B6 RID: 6326 RVA: 0x0005F228 File Offset: 0x0005D428
		private void OnPreviewMouseLeftButtonUp(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (this._resizeTarget != null)
			{
				this.ResizeToNewMousePosition(e.MouseDevice);
				this.CancelResize();
				e.Handled = true;
			}
		}

		// Token: 0x060018B7 RID: 6327 RVA: 0x0005F24C File Offset: 0x0005D44C
		private void OnPreviewMouseMove(object sender, global::System.Windows.Input.MouseEventArgs e)
		{
			if (this._resizeTarget != null && ((this._constraintsInXAxis != null && !this._constraintsInXAxis.Cancel) || (this._constraintsInYAxis != null && !this._constraintsInYAxis.Cancel)))
			{
				if (this._constraintsInXAxis != null)
				{
					if (this._constraintsInXAxis.ResizeWhileDragging)
					{
						this.ResizeToNewMousePosition(e.MouseDevice);
					}
					else
					{
						this.PositionResizerBar(e.MouseDevice, true);
					}
				}
				if (this._constraintsInYAxis != null)
				{
					if (this._constraintsInYAxis.ResizeWhileDragging)
					{
						this.ResizeToNewMousePosition(e.MouseDevice);
					}
					else
					{
						this.PositionResizerBar(e.MouseDevice, false);
					}
				}
				e.Handled = true;
			}
		}

		// Token: 0x060018B8 RID: 6328 RVA: 0x0005F2F8 File Offset: 0x0005D4F8
		private void OnQueryCursor(object sender, global::System.Windows.Input.QueryCursorEventArgs e)
		{
			if (!e.Handled)
			{
				global::System.Windows.FrameworkElement frameworkElement = e.OriginalSource as global::System.Windows.FrameworkElement;
				if (frameworkElement != null)
				{
					bool? resizeInXAxis;
					global::System.Windows.FrameworkElement elementToResize = this.GetElementToResize(frameworkElement, e.MouseDevice, out resizeInXAxis);
					if (elementToResize != null)
					{
						global::System.Windows.Input.Cursor resizeCursor = this.GetResizeCursor(elementToResize, resizeInXAxis);
						if (resizeCursor != null)
						{
							e.Cursor = resizeCursor;
							e.Handled = true;
						}
					}
				}
			}
		}

		// Token: 0x060018B9 RID: 6329 RVA: 0x0005F34C File Offset: 0x0005D54C
		internal void PositionResizerBar(global::System.Windows.Input.MouseDevice device, bool resizeInXAxis)
		{
			global::Infragistics.Windows.Resizing.ResizeConstraints resizeConstraints;
			if (resizeInXAxis)
			{
				resizeConstraints = this._constraintsInXAxis;
			}
			else
			{
				resizeConstraints = this._constraintsInYAxis;
			}
			if (resizeConstraints == null || resizeConstraints.Cancel || resizeConstraints.ResizeWhileDragging || resizeConstraints.ResizerBar.Visibility == global::System.Windows.Visibility.Collapsed)
			{
				return;
			}
			double constrainedPosition = this.GetConstrainedPosition(device, true, resizeInXAxis);
			if (resizeInXAxis)
			{
				global::System.Windows.Controls.Canvas.SetLeft(resizeConstraints.ResizerBar, constrainedPosition);
			}
			else
			{
				global::System.Windows.Controls.Canvas.SetTop(resizeConstraints.ResizerBar, constrainedPosition);
			}
			global::System.Windows.FrameworkElement frameworkElement = this.Host as global::System.Windows.FrameworkElement;
			if (frameworkElement != null)
			{
				frameworkElement.InvalidateArrange();
			}
		}

		// Token: 0x060018BA RID: 6330 RVA: 0x0005F3CC File Offset: 0x0005D5CC
		private void ResizeToNewMousePosition(global::System.Windows.Input.MouseDevice mouseDevice)
		{
			global::Infragistics.Windows.Resizing.IResizeHostMulti resizeHostMulti = this.Host as global::Infragistics.Windows.Resizing.IResizeHostMulti;
			global::System.Windows.Point point = default(global::System.Windows.Point);
			bool flag = this._constraintsInXAxis != null;
			bool flag2 = this._constraintsInYAxis != null;
			if (resizeHostMulti != null && flag && flag2)
			{
				global::System.Windows.Point lastDragPoint = default(global::System.Windows.Point);
				double num = this.ResizeToNewMousePositionHelper(mouseDevice, true, false, out point);
				lastDragPoint.X = point.X;
				double num2 = this.ResizeToNewMousePositionHelper(mouseDevice, false, false, out point);
				lastDragPoint.Y = point.Y;
				if (num != 0.0 && num2 != 0.0)
				{
					this._lastDragPoint = lastDragPoint;
					this._originalDragPointOffset = default(global::System.Windows.Point);
					this._resizerBarOffset = default(global::System.Windows.Point);
					resizeHostMulti.ResizeBothDimensions(this._resizeTarget, num, num2);
					return;
				}
			}
			else
			{
				if (flag)
				{
					this.ResizeToNewMousePositionHelper(mouseDevice, true, true, out point);
				}
				if (flag2)
				{
					this.ResizeToNewMousePositionHelper(mouseDevice, false, true, out point);
				}
			}
		}

		// Token: 0x060018BB RID: 6331 RVA: 0x0005F4C0 File Offset: 0x0005D6C0
		private double ResizeToNewMousePositionHelper(global::System.Windows.Input.MouseDevice mouseDevice, bool resizeInXAxis, bool callResizeMethod, out global::System.Windows.Point currentPoint)
		{
			double constrainedPosition = this.GetConstrainedPosition(mouseDevice, false, resizeInXAxis, out currentPoint);
			double num;
			bool flag;
			if (resizeInXAxis)
			{
				num = constrainedPosition - this._lastDragPoint.X;
				flag = (currentPoint.X > this._lastDragPoint.X);
			}
			else
			{
				num = constrainedPosition - this._lastDragPoint.Y;
				flag = (currentPoint.Y > this._lastDragPoint.Y);
			}
			if (num > 0.0)
			{
				if (!flag)
				{
					return 0.0;
				}
			}
			else if (flag)
			{
				return 0.0;
			}
			if (callResizeMethod && num != 0.0)
			{
				this._lastDragPoint = currentPoint;
				this._originalDragPointOffset = default(global::System.Windows.Point);
				this._resizerBarOffset = default(global::System.Windows.Point);
				this.Host.Resize(this._resizeTarget, resizeInXAxis, num);
			}
			return num;
		}

		// Token: 0x060018BC RID: 6332 RVA: 0x0005F59C File Offset: 0x0005D79C
		private void UnhookMouseEvents()
		{
			if (!this._mouseEventsHooked)
			{
				return;
			}
			global::System.Windows.FrameworkElement rootElement = this.Host.RootElement;
			rootElement.PreviewMouseMove -= this.OnPreviewMouseMove;
			rootElement.PreviewMouseLeftButtonUp -= this.OnPreviewMouseLeftButtonUp;
			rootElement.LostMouseCapture -= this.OnLostMouseCapture;
			rootElement.PreviewKeyDown -= this.OnPreviewKeyDown;
			this._mouseEventsHooked = false;
			rootElement.ReleaseMouseCapture();
		}

		// Token: 0x04000BD8 RID: 3032
		private const bool DebugResize = false;

		// Token: 0x04000BD9 RID: 3033
		private const double MAX_NEIGHBOR_TEST_ADJUSTMENT = 4.0;

		// Token: 0x04000BDA RID: 3034
		private global::Infragistics.Windows.Resizing.IResizeHost _host;

		// Token: 0x04000BDB RID: 3035
		private bool? _resizeInXAxis;

		// Token: 0x04000BDC RID: 3036
		private bool _mouseEventsHooked;

		// Token: 0x04000BDD RID: 3037
		private global::Infragistics.Windows.Resizing.ResizeConstraints _constraintsInXAxis;

		// Token: 0x04000BDE RID: 3038
		private global::Infragistics.Windows.Resizing.ResizeConstraints _constraintsInYAxis;

		// Token: 0x04000BDF RID: 3039
		private global::System.Windows.FrameworkElement _resizeTarget;

		// Token: 0x04000BE0 RID: 3040
		private global::System.Windows.Point _originalDragPoint;

		// Token: 0x04000BE1 RID: 3041
		private global::System.Windows.Point _lastDragPoint;

		// Token: 0x04000BE2 RID: 3042
		private global::System.Windows.Point _originalDragPointOffset;

		// Token: 0x04000BE3 RID: 3043
		private global::System.Windows.Point _resizerBarOffset;

		// Token: 0x04000BE4 RID: 3044
		private double _resizerBarWidth = 6.0;

		// Token: 0x04000BE5 RID: 3045
		private global::System.Windows.Input.Cursor _cachedCursor;

		// Token: 0x04000BE6 RID: 3046
		private double _interItemSpacingX;

		// Token: 0x04000BE7 RID: 3047
		private double _interItemSpacingY;

		// Token: 0x04000BE8 RID: 3048
		private global::System.Windows.Point _originalTargetOffset;

		// Token: 0x04000BE9 RID: 3049
		private bool _isFlowDirectionFlipped;
	}
}
