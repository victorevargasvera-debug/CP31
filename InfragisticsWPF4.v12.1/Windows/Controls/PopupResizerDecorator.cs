using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Threading;
using Infragistics.Collections;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000197 RID: 407
	[global::System.Windows.StyleTypedProperty(Property = "ResizerBarStyle", StyleTargetType = typeof(global::Infragistics.Windows.Controls.PopupResizerBar))]
	[global::System.Windows.TemplatePart(Name = "PART_Thumb", Type = typeof(global::System.Windows.Controls.Primitives.Thumb))]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public sealed class PopupResizerDecorator : global::System.Windows.Controls.Decorator
	{
		// Token: 0x06000DAF RID: 3503 RVA: 0x0002C12C File Offset: 0x0002A32C
		static PopupResizerDecorator()
		{
			global::System.Windows.FrameworkElement.FlowDirectionProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.PopupResizerDecorator), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.PopupResizerDecorator.OnFlowDirectionChanged)));
			global::System.Windows.FrameworkElement.HeightProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.PopupResizerDecorator), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.PopupResizerDecorator.CoerceHeight)));
			global::System.Windows.FrameworkElement.WidthProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.PopupResizerDecorator), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.PopupResizerDecorator.CoerceWidth)));
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x0002C2C0 File Offset: 0x0002A4C0
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size arrangeSize)
		{
			global::System.Windows.Rect finalRect = new global::System.Windows.Rect(arrangeSize);
			if (this._resizerBar != null)
			{
				global::System.Windows.Rect finalRect2 = new global::System.Windows.Rect(arrangeSize);
				finalRect2.Height = global::System.Math.Min(arrangeSize.Height, this._resizerBar.DesiredSize.Height);
				finalRect.Height = global::System.Math.Max(finalRect.Height - finalRect2.Height, 0.0);
				if (this._resizerBar.Location == global::Infragistics.Windows.Controls.PopupResizerBarLocation.Top)
				{
					finalRect.Y = finalRect2.Height;
				}
				else
				{
					finalRect2.Y = finalRect.Height;
				}
				this._resizerBar.Arrange(finalRect2);
			}
			global::System.Windows.UIElement child = this.Child;
			if (child != null)
			{
				child.Arrange(finalRect);
			}
			return arrangeSize;
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x0002C37C File Offset: 0x0002A57C
		protected override global::System.Windows.Media.Visual GetVisualChild(int index)
		{
			int visualChildrenCount = base.VisualChildrenCount;
			if (index == visualChildrenCount && this._resizerBar != null)
			{
				return this._resizerBar;
			}
			return base.GetVisualChild(index);
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000DB2 RID: 3506 RVA: 0x0002C3AC File Offset: 0x0002A5AC
		protected override global::System.Collections.IEnumerator LogicalChildren
		{
			get
			{
				if (this._resizerBar == null)
				{
					return base.LogicalChildren;
				}
				return new global::Infragistics.Collections.MultiSourceEnumerator(new global::System.Collections.IEnumerator[]
				{
					base.LogicalChildren,
					new global::Infragistics.Collections.SingleItemEnumerator(this._resizerBar)
				});
			}
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x0002C3EC File Offset: 0x0002A5EC
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
		{
			if (constraint.Width > this._preferredWidth)
			{
				constraint.Width = this._preferredWidth;
			}
			if (constraint.Height > this._preferredHeight)
			{
				constraint.Height = this._preferredHeight;
			}
			global::System.Windows.Size size = default(global::System.Windows.Size);
			if (this.ResizeMode == global::Infragistics.Windows.Controls.PopupResizeMode.None)
			{
				if (this._resizerBar != null)
				{
					base.RemoveLogicalChild(this._resizerBar);
					base.RemoveVisualChild(this._resizerBar);
					this._resizerBar = null;
				}
			}
			else
			{
				if (this._resizerBar == null)
				{
					this._resizerBar = new global::Infragistics.Windows.Controls.PopupResizerBar();
					base.AddLogicalChild(this._resizerBar);
					base.AddVisualChild(this._resizerBar);
					this._resizerBar.SetBinding(global::Infragistics.Windows.Controls.PopupResizerBar.ResizeModeProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.Controls.PopupResizerDecorator.ResizeModeProperty, global::System.Windows.Data.BindingMode.OneWay, this));
					this._resizerBar.SetBinding(global::Infragistics.Windows.Controls.PopupResizerBar.LocationProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.Controls.PopupResizerDecorator.ResizerBarLocationProperty, global::System.Windows.Data.BindingMode.OneWay, this));
					this.SynchronizeResizerBarStyle();
					this.VerifyResizerBarFlowDirection();
					this._resizerBar.SetBinding(global::System.Windows.FrameworkElement.FlowDirectionProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.Controls.PopupResizerDecorator.ResizerBarFlowDirectionProperty, global::System.Windows.Data.BindingMode.OneWay, this));
				}
				this._resizerBar.Measure(constraint);
				size = this._resizerBar.DesiredSize;
				if (!double.IsPositiveInfinity(constraint.Height))
				{
					constraint.Height = global::System.Math.Max(constraint.Height - this._resizerBar.DesiredSize.Height, 1.0);
				}
			}
			global::System.Windows.Size result = base.MeasureOverride(constraint);
			if (this._resizerBar != null && this._resizerBar.Location == global::Infragistics.Windows.Controls.PopupResizerBarLocation.Bottom)
			{
				result.Height += size.Height;
			}
			if (!double.IsPositiveInfinity(this._preferredHeight) && result.Height < constraint.Height)
			{
				result.Height = constraint.Height;
			}
			if (this._resizerBar != null && this._resizerBar.Location == global::Infragistics.Windows.Controls.PopupResizerBarLocation.Top)
			{
				result.Height += size.Height;
			}
			if (!double.IsPositiveInfinity(this._preferredWidth) && result.Width < constraint.Width)
			{
				result.Width = constraint.Width;
			}
			return result;
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x0002C60B File Offset: 0x0002A80B
		protected override void OnRender(global::System.Windows.Media.DrawingContext drawingContext)
		{
			base.OnRender(drawingContext);
			this.InitializeLocation();
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000DB5 RID: 3509 RVA: 0x0002C61C File Offset: 0x0002A81C
		protected override int VisualChildrenCount
		{
			get
			{
				int num = base.VisualChildrenCount;
				if (this._resizerBar != null)
				{
					num++;
				}
				return num;
			}
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x0002C640 File Offset: 0x0002A840
		private static void OnResizeConstraintsChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.FrameworkElement frameworkElement = target as global::System.Windows.FrameworkElement;
			if (frameworkElement == null)
			{
				throw new global::System.InvalidOperationException(global::SR.GetString("LE_InvalidOperationException_6"));
			}
			global::Infragistics.Windows.Controls.PopupResizerDecorator.Constraints constraints = e.OldValue as global::Infragistics.Windows.Controls.PopupResizerDecorator.Constraints;
			if (constraints != null)
			{
				constraints.Initialize(null);
			}
			constraints = (e.NewValue as global::Infragistics.Windows.Controls.PopupResizerDecorator.Constraints);
			if (constraints != null)
			{
				constraints.Initialize(frameworkElement);
			}
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x0002C695 File Offset: 0x0002A895
		[global::System.Windows.AttachedPropertyBrowsableForChildren(IncludeDescendants = true)]
		public static global::Infragistics.Windows.Controls.PopupResizerDecorator.Constraints GetResizeConstraints(global::System.Windows.FrameworkElement element)
		{
			return (global::Infragistics.Windows.Controls.PopupResizerDecorator.Constraints)element.GetValue(global::Infragistics.Windows.Controls.PopupResizerDecorator.ResizeConstraintsProperty);
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x0002C6A7 File Offset: 0x0002A8A7
		public static void SetResizeConstraints(global::System.Windows.FrameworkElement element, global::Infragistics.Windows.Controls.PopupResizerDecorator.Constraints value)
		{
			element.SetValue(global::Infragistics.Windows.Controls.PopupResizerDecorator.ResizeConstraintsProperty, value);
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000DB9 RID: 3513 RVA: 0x0002C6B5 File Offset: 0x0002A8B5
		// (set) Token: 0x06000DBA RID: 3514 RVA: 0x0002C6C7 File Offset: 0x0002A8C7
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Controls.PopupResizeMode ResizeMode
		{
			get
			{
				return (global::Infragistics.Windows.Controls.PopupResizeMode)base.GetValue(global::Infragistics.Windows.Controls.PopupResizerDecorator.ResizeModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.PopupResizerDecorator.ResizeModeProperty, value);
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000DBB RID: 3515 RVA: 0x0002C6DA File Offset: 0x0002A8DA
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Controls.PopupResizerBarLocation ResizerBarLocation
		{
			get
			{
				return (global::Infragistics.Windows.Controls.PopupResizerBarLocation)base.GetValue(global::Infragistics.Windows.Controls.PopupResizerDecorator.ResizerBarLocationProperty);
			}
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x0002C6EC File Offset: 0x0002A8EC
		private static void OnResizerBarStyleChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.PopupResizerDecorator popupResizerDecorator = target as global::Infragistics.Windows.Controls.PopupResizerDecorator;
			if (popupResizerDecorator != null)
			{
				popupResizerDecorator.SynchronizeResizerBarStyle();
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000DBD RID: 3517 RVA: 0x0002C709 File Offset: 0x0002A909
		// (set) Token: 0x06000DBE RID: 3518 RVA: 0x0002C71B File Offset: 0x0002A91B
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Style ResizerBarStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Windows.Controls.PopupResizerDecorator.ResizerBarStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.PopupResizerDecorator.ResizerBarStyleProperty, value);
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000DBF RID: 3519 RVA: 0x0002C729 File Offset: 0x0002A929
		private global::System.Windows.UIElement CommonAncestor
		{
			get
			{
				if (this._commonAncestor != null)
				{
					return this._commonAncestor;
				}
				if (this._popup == null || !global::System.Windows.Interop.BrowserInteropHelper.IsBrowserHosted)
				{
					return null;
				}
				this._commonAncestor = (global::Infragistics.Windows.Utilities.GetCommonAncestor(this._popup, null) as global::System.Windows.UIElement);
				return this._commonAncestor;
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000DC0 RID: 3520 RVA: 0x0002C768 File Offset: 0x0002A968
		// (set) Token: 0x06000DC1 RID: 3521 RVA: 0x0002C770 File Offset: 0x0002A970
		private double PreferredWidth
		{
			get
			{
				return this._preferredWidth;
			}
			set
			{
				this._preferredWidth = value;
				base.CoerceValue(global::System.Windows.FrameworkElement.WidthProperty);
				base.InvalidateMeasure();
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000DC2 RID: 3522 RVA: 0x0002C78A File Offset: 0x0002A98A
		// (set) Token: 0x06000DC3 RID: 3523 RVA: 0x0002C792 File Offset: 0x0002A992
		private double PreferredHeight
		{
			get
			{
				return this._preferredHeight;
			}
			set
			{
				this._preferredHeight = value;
				base.CoerceValue(global::System.Windows.FrameworkElement.HeightProperty);
				base.InvalidateMeasure();
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000DC4 RID: 3524 RVA: 0x0002C7AC File Offset: 0x0002A9AC
		private global::System.Windows.FlowDirection ResizerBarFlowDirection
		{
			get
			{
				return (global::System.Windows.FlowDirection)base.GetValue(global::Infragistics.Windows.Controls.PopupResizerDecorator.ResizerBarFlowDirectionProperty);
			}
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x0002C7BE File Offset: 0x0002A9BE
		internal void PerformMove(double deltaX, double deltaY)
		{
			this.ProcessOnDragStarted();
			this.ProcessOnDragDelta(deltaX, deltaY);
			this.ProcessOnDragCompleted();
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x0002C7D4 File Offset: 0x0002A9D4
		internal void RegisterDescendantResizeConstraints(global::System.Windows.FrameworkElement element, global::Infragistics.Windows.Controls.PopupResizerDecorator.Constraints constraints)
		{
			if (constraints == null)
			{
				throw new global::System.ArgumentNullException("constraints");
			}
			if (element == null || !element.IsDescendantOf(this))
			{
				throw new global::System.InvalidOperationException(global::SR.GetString("LE_InvalidOperationException_5"));
			}
			if (this._constraintDictionary == null)
			{
				this._constraintDictionary = new global::System.Collections.Generic.Dictionary<global::System.Windows.FrameworkElement, global::Infragistics.Windows.Controls.PopupResizerDecorator.Constraints>();
			}
			this._constraintDictionary.Add(element, constraints);
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x0002C82B File Offset: 0x0002AA2B
		internal void UnregisterDescendantResizeConstraints(global::System.Windows.FrameworkElement element)
		{
			if (this._constraintDictionary != null && this._constraintDictionary.ContainsKey(element))
			{
				this._constraintDictionary.Remove(element);
			}
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x0002C850 File Offset: 0x0002AA50
		private static void ApplyExplicitElementConstraints(double explicitExtent, double explicitMinExtent, double explicitMaxExtent, ref double minDraggingExtent, ref double maxDraggingExtent)
		{
			if (!double.IsNaN(explicitExtent))
			{
				minDraggingExtent = explicitExtent;
				maxDraggingExtent = explicitExtent;
			}
			if (!double.IsNaN(explicitMaxExtent))
			{
				maxDraggingExtent = global::System.Math.Min(explicitMaxExtent, maxDraggingExtent);
			}
			if (!double.IsNaN(explicitMinExtent))
			{
				minDraggingExtent = global::System.Math.Max(explicitMinExtent, minDraggingExtent);
				maxDraggingExtent = global::System.Math.Max(explicitMinExtent, maxDraggingExtent);
			}
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x0002C8A0 File Offset: 0x0002AAA0
		private static double CalculateConstrainedDelta(double currentValue, double delta, double minimum, double maximum)
		{
			double num = currentValue + delta;
			if (!double.IsPositiveInfinity(maximum))
			{
				num = global::System.Math.Min(num, maximum);
			}
			num = global::System.Math.Max(num, minimum);
			return num - currentValue;
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x0002C8CC File Offset: 0x0002AACC
		private static object CoerceHeight(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.Controls.PopupResizerDecorator popupResizerDecorator = target as global::Infragistics.Windows.Controls.PopupResizerDecorator;
			if (!double.IsPositiveInfinity(popupResizerDecorator._preferredHeight))
			{
				return double.NaN;
			}
			return value;
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x0002C900 File Offset: 0x0002AB00
		private static object CoerceWidth(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.Controls.PopupResizerDecorator popupResizerDecorator = target as global::Infragistics.Windows.Controls.PopupResizerDecorator;
			if (!double.IsPositiveInfinity(popupResizerDecorator._preferredWidth))
			{
				return double.NaN;
			}
			return value;
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x0002C934 File Offset: 0x0002AB34
		private global::System.Windows.Controls.Primitives.CustomPopupPlacement[] CustomPopupPlacementCallback(global::System.Windows.Size popupSize, global::System.Windows.Size targetSize, global::System.Windows.Point offset)
		{
			global::System.Windows.Point customPlacmentPoint = this._customPlacmentPoint;
			if (this.ResizerBarFlowDirection == global::System.Windows.FlowDirection.RightToLeft)
			{
				customPlacmentPoint.X -= popupSize.Width;
			}
			return new global::System.Windows.Controls.Primitives.CustomPopupPlacement[]
			{
				new global::System.Windows.Controls.Primitives.CustomPopupPlacement(customPlacmentPoint, global::System.Windows.Controls.Primitives.PopupPrimaryAxis.None)
			};
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x0002C984 File Offset: 0x0002AB84
		private global::Infragistics.Windows.Controls.PopupResizerBarLocation DetermineLocation()
		{
			global::Infragistics.Windows.Controls.PopupResizerBarLocation result = global::Infragistics.Windows.Controls.PopupResizerBarLocation.Bottom;
			if (this.ResizeMode == global::Infragistics.Windows.Controls.PopupResizeMode.None)
			{
				return result;
			}
			if (this._popup == null)
			{
				this._popup = (global::Infragistics.Windows.Utilities.GetAncestorFromType(this, typeof(global::System.Windows.Controls.Primitives.Popup), true) as global::System.Windows.Controls.Primitives.Popup);
				if (this._popup != null)
				{
					this._popup.Closed += this.OnPopupClosed;
					this._popupOriginalPlacement = this._popup.Placement;
					this._popupOriginalVerticalOffset = this._popup.VerticalOffset;
					this._popupOriginalHorizontalOffset = this._popup.HorizontalOffset;
					this._popupRoot = (this._popup.Child as global::System.Windows.FrameworkElement);
					this._popupOriginalCustomPopupCallback = this._popup.CustomPopupPlacementCallback;
					this.VerifyResizerBarFlowDirection();
				}
			}
			if (this._popup == null)
			{
				global::System.Diagnostics.Trace.TraceError("Popup element not found");
				return result;
			}
			switch (this._popupOriginalPlacement)
			{
			case global::System.Windows.Controls.Primitives.PlacementMode.Bottom:
			case global::System.Windows.Controls.Primitives.PlacementMode.Center:
			case global::System.Windows.Controls.Primitives.PlacementMode.AbsolutePoint:
			case global::System.Windows.Controls.Primitives.PlacementMode.RelativePoint:
			case global::System.Windows.Controls.Primitives.PlacementMode.Top:
				base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Input, new global::Infragistics.Windows.Controls.PopupResizerDecorator.MethodDelegate(this.VerifyLocation));
				break;
			}
			return result;
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x0002CAA8 File Offset: 0x0002ACA8
		private static void GetExplicitElementConstraint(global::System.Windows.FrameworkElement element, global::System.Windows.DependencyProperty property, double adjustment, ref double constraint)
		{
			if (!double.IsNaN(constraint))
			{
				return;
			}
			double num = (double)element.GetValue(property);
			if (!double.IsNaN(num) && !double.IsPositiveInfinity(num) && num != (double)property.GetMetadata(element.GetType()).DefaultValue)
			{
				constraint = num - adjustment;
			}
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x0002CAFC File Offset: 0x0002ACFC
		private void InitializeLocation()
		{
			if (this._resizerBar == null)
			{
				return;
			}
			global::System.Windows.Controls.Primitives.Thumb thumb = this._resizerBar.GetThumb();
			if (thumb == null)
			{
				global::System.Diagnostics.Trace.TraceError("A Thumb with the name PART_Thumb not found in PopupResizerBar");
			}
			if (thumb != this._thumb)
			{
				if (this._thumb != null)
				{
					this._thumb.DragStarted -= this.OnDragStarted;
				}
				this._thumb = thumb;
				if (this._thumb != null)
				{
					this._thumb.DragStarted += this.OnDragStarted;
				}
			}
			if (this._popup == null)
			{
				global::Infragistics.Windows.Controls.PopupResizerBarLocation popupResizerBarLocation = this.DetermineLocation();
				if (popupResizerBarLocation == global::Infragistics.Windows.Controls.PopupResizerBarLocation.Bottom)
				{
					base.ClearValue(global::Infragistics.Windows.Controls.PopupResizerDecorator.ResizerBarLocationPropertyKey);
					return;
				}
				base.SetValue(global::Infragistics.Windows.Controls.PopupResizerDecorator.ResizerBarLocationPropertyKey, popupResizerBarLocation);
			}
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x0002CBA8 File Offset: 0x0002ADA8
		internal static void InvalidateMeasure(global::System.Windows.UIElement descendant, global::System.Windows.UIElement ancestor)
		{
			for (;;)
			{
				global::System.Windows.UIElement uielement = global::System.Windows.Media.VisualTreeHelper.GetParent(descendant) as global::System.Windows.UIElement;
				if (uielement == null)
				{
					return;
				}
				if (uielement == ancestor)
				{
					break;
				}
				uielement.InvalidateMeasure();
				descendant = uielement;
			}
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x0002CBD4 File Offset: 0x0002ADD4
		private void OnConstraintPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			this._draggingConstraintsDirty = true;
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x0002CBE0 File Offset: 0x0002ADE0
		private static void OnFlowDirectionChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.PopupResizerDecorator popupResizerDecorator = target as global::Infragistics.Windows.Controls.PopupResizerDecorator;
			if (popupResizerDecorator != null)
			{
				popupResizerDecorator.VerifyResizerBarFlowDirection();
			}
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x0002CBFD File Offset: 0x0002ADFD
		private void OnDragCompleted(object sender, global::System.Windows.Controls.Primitives.DragCompletedEventArgs e)
		{
			this._thumb.DragDelta -= this.OnDragDelta;
			this._thumb.DragCompleted -= this.OnDragCompleted;
			e.Handled = true;
			this.ProcessOnDragCompleted();
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x0002CC3C File Offset: 0x0002AE3C
		private void ProcessOnDragCompleted()
		{
			if (this._constraintDictionary != null && this._constraintDictionary.Count > 0)
			{
				global::System.ComponentModel.PropertyChangedEventHandler value = new global::System.ComponentModel.PropertyChangedEventHandler(this.OnConstraintPropertyChanged);
				foreach (global::System.Collections.Generic.KeyValuePair<global::System.Windows.FrameworkElement, global::Infragistics.Windows.Controls.PopupResizerDecorator.Constraints> keyValuePair in this._constraintDictionary)
				{
					global::Infragistics.Windows.Controls.PopupResizerDecorator.Constraints value2 = keyValuePair.Value;
					value2.PropertyChanged -= value;
				}
			}
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x0002CCBC File Offset: 0x0002AEBC
		private void OnDragDelta(object sender, global::System.Windows.Controls.Primitives.DragDeltaEventArgs e)
		{
			e.Handled = true;
			this.ProcessOnDragDelta(e.HorizontalChange, e.VerticalChange);
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x0002CCD8 File Offset: 0x0002AED8
		private void ProcessOnDragDelta(double horizontalChange, double verticalChange)
		{
			if (this._popup == null)
			{
				return;
			}
			if (this._processingDragDelta)
			{
				return;
			}
			this._processingDragDelta = true;
			try
			{
				bool flag = false;
				bool flag2 = false;
				switch (this.ResizeMode)
				{
				case global::Infragistics.Windows.Controls.PopupResizeMode.VerticalOnly:
					flag2 = true;
					break;
				case global::Infragistics.Windows.Controls.PopupResizeMode.Both:
					flag = true;
					flag2 = true;
					break;
				}
				global::System.Windows.Thickness margin = base.Margin;
				global::System.Windows.FrameworkElement frameworkElement = this._popupRoot ?? this;
				global::System.Windows.Point point = this.PointToTopLevelElement(frameworkElement, default(global::System.Windows.Point));
				if (flag2 && verticalChange != 0.0)
				{
					double actualHeight = base.ActualHeight;
					double num = actualHeight - (margin.Top + margin.Bottom);
					double num2 = verticalChange;
					if (this._resizerBar.Location == global::Infragistics.Windows.Controls.PopupResizerBarLocation.Top)
					{
						num2 = -num2;
						if (num2 > 0.0)
						{
							num2 = global::System.Math.Max(global::System.Math.Min(point.Y - (2.0 + this._resizeWorkArea.Y), num2), 0.0);
						}
					}
					else if (num2 > 0.0)
					{
						num2 = global::System.Math.Max(global::System.Math.Min(this._resizeWorkArea.Bottom - (point.Y + frameworkElement.ActualHeight + 2.0), num2), 0.0);
					}
					if (num2 != 0.0)
					{
						num2 = global::Infragistics.Windows.Controls.PopupResizerDecorator.CalculateConstrainedDelta(num, num2, this._minDraggingHeight, this._maxDraggingHeight);
						if (num2 != 0.0)
						{
							this._draggingConstraintsDirty = true;
						}
					}
					if (num2 != 0.0)
					{
						if (this._resizerBar.Location == global::Infragistics.Windows.Controls.PopupResizerBarLocation.Top)
						{
							this._popup.VerticalOffset -= num2;
							this.PreferredHeight = num + num2;
						}
						else
						{
							this.PreferredHeight = num + num2;
						}
						global::Infragistics.Windows.Controls.PopupResizerDecorator.InvalidateMeasure(this, null);
					}
				}
				if (flag && horizontalChange != 0.0)
				{
					double actualWidth = base.ActualWidth;
					double num3 = actualWidth - (margin.Left + margin.Right);
					double num4 = global::Infragistics.Windows.Controls.PopupResizerDecorator.CalculateConstrainedDelta(num3, horizontalChange, this._minDraggingWidth, this._maxDraggingWidth);
					if (num4 > 0.0)
					{
						if (this.ResizerBarFlowDirection == global::System.Windows.FlowDirection.RightToLeft)
						{
							if (point.X - num4 <= this._resizeWorkArea.X)
							{
								num4 = global::System.Math.Max(point.X - this._resizeWorkArea.X, 0.0);
							}
						}
						else
						{
							global::System.Windows.Point point2 = global::Infragistics.Windows.Utilities.PointToScreenSafe(frameworkElement, new global::System.Windows.Point(frameworkElement.ActualWidth + num4, frameworkElement.ActualHeight));
							global::System.Windows.Rect rect = global::Infragistics.Windows.Utilities.RectFromPoints(point, point2);
							global::System.Windows.Rect rect2 = global::System.Windows.Rect.Intersect(this._resizeWorkArea, rect);
							if (rect2.Width < rect.Width)
							{
								num4 = global::System.Math.Max(rect2.Width - frameworkElement.ActualWidth, 0.0);
							}
						}
					}
					if (num4 != 0.0)
					{
						this.PreferredWidth = num3 + num4;
						global::Infragistics.Windows.Controls.PopupResizerDecorator.InvalidateMeasure(this, null);
					}
				}
			}
			finally
			{
				this._processingDragDelta = false;
			}
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x0002CFEC File Offset: 0x0002B1EC
		private void OnDragStarted(object sender, global::System.Windows.Controls.Primitives.DragStartedEventArgs e)
		{
			this._thumb.DragDelta += this.OnDragDelta;
			this._thumb.DragCompleted += this.OnDragCompleted;
			e.Handled = true;
			this.ProcessOnDragStarted();
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x0002D02C File Offset: 0x0002B22C
		private void ProcessOnDragStarted()
		{
			this._draggingConstraintsDirty = true;
			this.VerifyDraggingConstraints(true);
			global::System.Windows.FrameworkElement frameworkElement = global::System.Windows.Media.VisualTreeHelper.GetParent(this) as global::System.Windows.FrameworkElement;
			global::System.Windows.FrameworkElement frameworkElement2 = frameworkElement;
			while (frameworkElement != null)
			{
				frameworkElement2 = frameworkElement;
				frameworkElement = (global::System.Windows.Media.VisualTreeHelper.GetParent(frameworkElement) as global::System.Windows.FrameworkElement);
			}
			if (frameworkElement2 != null)
			{
				global::System.Windows.Point point = this.PointToTopLevelElement(frameworkElement2, default(global::System.Windows.Point));
				global::System.Windows.FrameworkElement frameworkElement3 = this._popupRoot ?? this;
				global::System.Windows.Thickness margin = frameworkElement3.Margin;
				global::System.Windows.UIElement uielement = null;
				if (global::System.Windows.Interop.BrowserInteropHelper.IsBrowserHosted)
				{
					uielement = this.CommonAncestor;
					if (uielement != null)
					{
						global::System.Windows.UIElement uielement2 = uielement;
						if (uielement2 is global::System.Windows.Controls.ContentControl && ((global::System.Windows.Controls.ContentControl)uielement2).Content is global::System.Windows.UIElement)
						{
							uielement2 = (((global::System.Windows.Controls.ContentControl)uielement2).Content as global::System.Windows.UIElement);
						}
						this._resizeWorkArea = new global::System.Windows.Rect(global::Infragistics.Windows.Utilities.PointToScreenSafe(uielement, default(global::System.Windows.Point)), uielement2.RenderSize);
					}
				}
				if (uielement == null)
				{
					this._resizeWorkArea = global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWorkArea(point);
					this._resizeWorkArea = new global::System.Windows.Rect(global::Infragistics.Windows.Utilities.ConvertToLogicalPixels((int)this._resizeWorkArea.X), global::Infragistics.Windows.Utilities.ConvertToLogicalPixels((int)this._resizeWorkArea.Y), global::Infragistics.Windows.Utilities.ConvertToLogicalPixels((int)this._resizeWorkArea.Width), global::Infragistics.Windows.Utilities.ConvertToLogicalPixels((int)this._resizeWorkArea.Height));
				}
				this._resizeWorkArea.Height = this._resizeWorkArea.Height - margin.Bottom;
				this._resizeWorkArea.Width = this._resizeWorkArea.Width - margin.Right;
				if (this.ResizerBarFlowDirection == global::System.Windows.FlowDirection.RightToLeft)
				{
					this._resizeWorkArea.X = this._resizeWorkArea.X + margin.Right;
				}
				if (this._popup.Placement != global::System.Windows.Controls.Primitives.PlacementMode.Absolute && (this._popup.Placement != global::System.Windows.Controls.Primitives.PlacementMode.Custom || !(this._popup.CustomPopupPlacementCallback == this._popupPlacementCallback)))
				{
					global::System.Windows.Thickness margin2 = base.Margin;
					this.PreferredWidth = base.ActualWidth - (margin2.Left + margin2.Right);
					this.PreferredHeight = base.ActualHeight - (margin2.Top + margin2.Bottom);
					this._popupWasResized = true;
					global::System.Windows.UIElement uielement3 = this._popup.PlacementTarget;
					if (uielement3 == null)
					{
						uielement3 = (global::System.Windows.Media.VisualTreeHelper.GetParent(this._popup) as global::System.Windows.UIElement);
					}
					if (uielement3 == null)
					{
						uielement3 = (this._popup.TemplatedParent as global::System.Windows.UIElement);
					}
					if (uielement3 != null && frameworkElement3 != this)
					{
						this._customPlacmentPoint = frameworkElement3.TranslatePoint(default(global::System.Windows.Point), uielement3);
						this._customPlacmentPoint.X = this._customPlacmentPoint.X - this._popup.HorizontalOffset;
						this._customPlacmentPoint.Y = this._customPlacmentPoint.Y - this._popup.VerticalOffset;
						if (this.ResizerBarFlowDirection == global::System.Windows.FlowDirection.RightToLeft)
						{
							if (frameworkElement3.FlowDirection == global::System.Windows.FlowDirection.LeftToRight)
							{
								this._customPlacmentPoint.X = this._customPlacmentPoint.X + (frameworkElement2.ActualWidth + margin.Right);
							}
							else
							{
								this._customPlacmentPoint.X = -(this._customPlacmentPoint.X + margin.Right);
							}
						}
						if (global::System.Windows.Interop.BrowserInteropHelper.IsBrowserHosted)
						{
							this._customPlacmentPoint.X = global::System.Math.Ceiling(this._customPlacmentPoint.X);
							this._customPlacmentPoint.Y = global::System.Math.Ceiling(this._customPlacmentPoint.Y);
						}
						if (this._popupPlacementCallback == null)
						{
							this._popupPlacementCallback = new global::System.Windows.Controls.Primitives.CustomPopupPlacementCallback(this.CustomPopupPlacementCallback);
						}
						this._popup.CustomPopupPlacementCallback = this._popupPlacementCallback;
						this._popup.Placement = global::System.Windows.Controls.Primitives.PlacementMode.Custom;
					}
					else
					{
						this._popup.VerticalOffset = point.Y;
						this._popup.HorizontalOffset = point.X;
						this._popup.Placement = global::System.Windows.Controls.Primitives.PlacementMode.Absolute;
					}
				}
			}
			global::System.Windows.Controls.MenuItem menuItem = (this._popup == null) ? null : (this._popup.TemplatedParent as global::System.Windows.Controls.MenuItem);
			if (menuItem != null)
			{
				global::System.Windows.Controls.ItemContainerGenerator itemContainerGenerator = menuItem.ItemContainerGenerator;
				for (int i = 0; i < menuItem.Items.Count; i++)
				{
					global::System.Windows.Controls.MenuItem menuItem2 = itemContainerGenerator.ContainerFromIndex(i) as global::System.Windows.Controls.MenuItem;
					if (menuItem2 != null && menuItem2.IsSubmenuOpen)
					{
						menuItem2.IsSubmenuOpen = false;
						return;
					}
				}
			}
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x0002D43C File Offset: 0x0002B63C
		private void OnPopupClosed(object sender, global::System.EventArgs e)
		{
			this.PreferredHeight = (this.PreferredWidth = double.PositiveInfinity);
			if (this._constraintDictionary != null && this._constraintDictionary.Count > 0)
			{
				int count = this._constraintDictionary.Count;
				global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> list = new global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>(count);
				foreach (global::System.Collections.Generic.KeyValuePair<global::System.Windows.FrameworkElement, global::Infragistics.Windows.Controls.PopupResizerDecorator.Constraints> keyValuePair in this._constraintDictionary)
				{
					list.Add(keyValuePair.Key);
				}
				for (int i = 0; i < count; i++)
				{
					list[i].ClearValue(global::Infragistics.Windows.Controls.PopupResizerDecorator.ResizeConstraintsProperty);
				}
			}
			if (this._popup != null)
			{
				this._popup.ClearValue(global::System.Windows.Controls.Primitives.Popup.PlacementProperty);
				this._popup.ClearValue(global::System.Windows.Controls.Primitives.Popup.VerticalOffsetProperty);
				this._popup.ClearValue(global::System.Windows.Controls.Primitives.Popup.HorizontalOffsetProperty);
				if (this._popupOriginalCustomPopupCallback != null)
				{
					this._popup.CustomPopupPlacementCallback = this._popupOriginalCustomPopupCallback;
				}
				else
				{
					this._popup.ClearValue(global::System.Windows.Controls.Primitives.Popup.CustomPopupPlacementCallbackProperty);
				}
				this._popup.Closed -= this.OnPopupClosed;
				this._popup = null;
			}
			this._popupRoot = null;
			base.InvalidateVisual();
			if (this._popupWasResized)
			{
				this._popupWasResized = false;
				global::Infragistics.Windows.Controls.PopupResizerDecorator.InvalidateMeasure(this, null);
			}
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x0002D59C File Offset: 0x0002B79C
		private global::System.Windows.Point PointFromTopLevelElement(global::System.Windows.UIElement referenceElement, global::System.Windows.Point point)
		{
			if (!global::System.Windows.Interop.BrowserInteropHelper.IsBrowserHosted)
			{
				return referenceElement.PointFromScreen(point);
			}
			global::System.Windows.UIElement commonAncestor = this.CommonAncestor;
			if (commonAncestor == null)
			{
				return point;
			}
			return commonAncestor.TranslatePoint(point, referenceElement);
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x0002D5CC File Offset: 0x0002B7CC
		private global::System.Windows.Point PointToTopLevelElement(global::System.Windows.UIElement referenceElement, global::System.Windows.Point point)
		{
			if (!global::System.Windows.Interop.BrowserInteropHelper.IsBrowserHosted)
			{
				return referenceElement.PointToScreen(point);
			}
			global::System.Windows.UIElement commonAncestor = this.CommonAncestor;
			if (commonAncestor == null)
			{
				return point;
			}
			return referenceElement.TranslatePoint(point, commonAncestor);
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x0002D5FC File Offset: 0x0002B7FC
		private void SynchronizeResizerBarStyle()
		{
			if (this._resizerBar == null)
			{
				return;
			}
			global::System.Windows.Style resizerBarStyle = this.ResizerBarStyle;
			if (resizerBarStyle != null)
			{
				this._resizerBar.SetValue(global::System.Windows.FrameworkElement.StyleProperty, resizerBarStyle);
				return;
			}
			this._resizerBar.ClearValue(global::System.Windows.FrameworkElement.StyleProperty);
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x0002D640 File Offset: 0x0002B840
		private void VerifyDraggingConstraints(bool dragStarting)
		{
			if (!this._draggingConstraintsDirty || this._popup == null)
			{
				return;
			}
			global::System.Windows.UIElement child = this.Child;
			if (child == null)
			{
				return;
			}
			global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> list = null;
			double naN = double.NaN;
			double naN2 = double.NaN;
			double naN3 = double.NaN;
			double naN4 = double.NaN;
			if (this._constraintDictionary != null && this._constraintDictionary.Count > 0)
			{
				global::System.ComponentModel.PropertyChangedEventHandler value = new global::System.ComponentModel.PropertyChangedEventHandler(this.OnConstraintPropertyChanged);
				foreach (global::System.Collections.Generic.KeyValuePair<global::System.Windows.FrameworkElement, global::Infragistics.Windows.Controls.PopupResizerDecorator.Constraints> keyValuePair in this._constraintDictionary)
				{
					global::Infragistics.Windows.Controls.PopupResizerDecorator.Constraints value2 = keyValuePair.Value;
					global::System.Windows.FrameworkElement element = value2.Element;
					bool flag = element == null;
					if (dragStarting && !flag && !element.IsDescendantOf(this))
					{
						flag = true;
					}
					if (flag)
					{
						if (list == null)
						{
							list = new global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>();
						}
						list.Add(keyValuePair.Key);
					}
					else
					{
						value2.Aggregate(ref naN, ref naN2, ref naN3, ref naN4);
						if (dragStarting)
						{
							value2.PropertyChanged += value;
						}
					}
				}
			}
			if (list != null)
			{
				foreach (global::System.Windows.FrameworkElement key in list)
				{
					this._constraintDictionary.Remove(key);
				}
			}
			global::System.Windows.Thickness margin = base.Margin;
			double num = base.ActualWidth - (margin.Left + margin.Right);
			double num2 = base.ActualHeight - (margin.Top + margin.Bottom);
			global::System.Windows.Size desiredSize = child.DesiredSize;
			global::System.Windows.Size renderSize = child.RenderSize;
			double val = global::System.Math.Max(renderSize.Height - desiredSize.Height, 0.0);
			double val2 = global::System.Math.Max(renderSize.Width - desiredSize.Width, 0.0);
			if (!double.IsNaN(naN))
			{
				this._minDraggingWidth = global::System.Math.Max(num - global::System.Math.Max(naN, val2), 2.0);
			}
			else
			{
				this._minDraggingWidth = 2.0;
			}
			if (!double.IsNaN(naN3))
			{
				this._minDraggingHeight = global::System.Math.Max(num2 - global::System.Math.Max(naN3, val), 2.0);
			}
			else
			{
				this._minDraggingHeight = 2.0;
			}
			if (!double.IsNaN(naN2))
			{
				this._maxDraggingWidth = num + naN2;
			}
			else
			{
				this._maxDraggingWidth = double.PositiveInfinity;
			}
			if (!double.IsNaN(naN4))
			{
				this._maxDraggingHeight = num2 + naN4;
			}
			else
			{
				this._maxDraggingHeight = double.PositiveInfinity;
			}
			double width = this._popup.Width;
			double height = this._popup.Height;
			double num3 = this._popup.MinWidth;
			double num4 = this._popup.MinHeight;
			double num5 = this._popup.MaxWidth;
			double num6 = this._popup.MaxHeight;
			if (this._resizerBar != null)
			{
				global::System.Windows.Size size = default(global::System.Windows.Size);
				if (this._popupRoot != null)
				{
					global::System.Windows.Size renderSize2 = this._popupRoot.RenderSize;
					global::System.Windows.Size renderSize3 = base.RenderSize;
					size.Width = global::System.Math.Max(renderSize2.Width - renderSize3.Width, 0.0);
					size.Height = global::System.Math.Max(renderSize2.Height - renderSize3.Height, 0.0);
					global::System.Windows.Thickness margin2 = this._popupRoot.Margin;
					size.Width += margin2.Left + margin2.Right;
					size.Height += margin2.Top + margin2.Bottom;
					num4 = global::System.Math.Max(num4 - size.Height, 0.0);
					num3 = global::System.Math.Max(num3 - size.Width, 0.0);
				}
				if (!double.IsNaN(num5) && !double.IsPositiveInfinity(num5))
				{
					num5 -= size.Width;
					num5 = global::System.Math.Max(base.ActualWidth, num5);
				}
				if (!double.IsNaN(num6) && !double.IsPositiveInfinity(num6))
				{
					num6 -= this._resizerBar.ActualHeight + size.Height;
					num6 = global::System.Math.Max(base.ActualHeight, num6);
				}
				num4 = global::System.Math.Max(num4, this._resizerBar.ActualHeight * 2.0);
			}
			global::Infragistics.Windows.Controls.PopupResizerDecorator.ApplyExplicitElementConstraints(width, num3, num5, ref this._minDraggingWidth, ref this._maxDraggingWidth);
			global::Infragistics.Windows.Controls.PopupResizerDecorator.ApplyExplicitElementConstraints(height, num4, num6, ref this._minDraggingHeight, ref this._maxDraggingHeight);
			this._draggingConstraintsDirty = false;
		}

		// Token: 0x06000DDE RID: 3550 RVA: 0x0002DAF0 File Offset: 0x0002BCF0
		private void VerifyLocation()
		{
			global::System.Windows.DependencyObject dependencyObject = null;
			for (global::System.Windows.DependencyObject dependencyObject2 = this; dependencyObject2 != null; dependencyObject2 = global::System.Windows.Media.VisualTreeHelper.GetParent(dependencyObject))
			{
				dependencyObject = dependencyObject2;
			}
			global::System.Windows.FrameworkElement frameworkElement = null;
			if (dependencyObject != null)
			{
				frameworkElement = (global::System.Windows.Media.VisualTreeHelper.GetChild(dependencyObject, 0) as global::System.Windows.FrameworkElement);
			}
			frameworkElement = (frameworkElement ?? this);
			global::System.Windows.Point point = default(global::System.Windows.Point);
			global::System.Windows.UIElement uielement = this._popup.PlacementTarget;
			if (uielement == null)
			{
				uielement = (this._popup.TemplatedParent as global::System.Windows.UIElement);
				if (uielement == null)
				{
					return;
				}
			}
			switch (this._popup.Placement)
			{
			case global::System.Windows.Controls.Primitives.PlacementMode.Bottom:
				point = new global::System.Windows.Point(0.0, uielement.RenderSize.Height);
				break;
			case global::System.Windows.Controls.Primitives.PlacementMode.Center:
				point = new global::System.Windows.Point(uielement.RenderSize.Width / 2.0, uielement.RenderSize.Height / 2.0);
				break;
			case global::System.Windows.Controls.Primitives.PlacementMode.AbsolutePoint:
				point = new global::System.Windows.Point(this._popup.HorizontalOffset, this._popup.VerticalOffset);
				point = this.PointFromTopLevelElement(uielement, point);
				break;
			case global::System.Windows.Controls.Primitives.PlacementMode.RelativePoint:
				point = new global::System.Windows.Point(this._popup.HorizontalOffset, this._popup.VerticalOffset);
				break;
			}
			global::System.Windows.Point point2 = frameworkElement.TranslatePoint(new global::System.Windows.Point(0.0, global::System.Math.Max(frameworkElement.RenderSize.Height - 10.0, 10.0)), uielement);
			global::Infragistics.Windows.Controls.PopupResizerBarLocation popupResizerBarLocation = global::Infragistics.Windows.Controls.PopupResizerBarLocation.Bottom;
			if (point2.Y < point.Y)
			{
				popupResizerBarLocation = global::Infragistics.Windows.Controls.PopupResizerBarLocation.Top;
			}
			base.SetValue(global::Infragistics.Windows.Controls.PopupResizerDecorator.ResizerBarLocationPropertyKey, popupResizerBarLocation);
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x0002DCA4 File Offset: 0x0002BEA4
		private void VerifyResizerBarFlowDirection()
		{
			global::System.Windows.Controls.Primitives.Popup popup;
			if (this._popup != null)
			{
				popup = this._popup;
			}
			else
			{
				popup = (global::Infragistics.Windows.Utilities.GetAncestorFromType(this, typeof(global::System.Windows.Controls.Primitives.Popup), true) as global::System.Windows.Controls.Primitives.Popup);
			}
			global::System.Windows.Controls.Primitives.PlacementMode placementMode;
			global::System.Windows.FlowDirection flowDirection;
			if (popup != null)
			{
				placementMode = popup.Placement;
				flowDirection = popup.FlowDirection;
			}
			else
			{
				placementMode = global::System.Windows.Controls.Primitives.PlacementMode.Absolute;
				flowDirection = base.FlowDirection;
			}
			global::System.Windows.Controls.Primitives.PlacementMode placementMode2 = placementMode;
			if (placementMode2 == global::System.Windows.Controls.Primitives.PlacementMode.Left && flowDirection == global::System.Windows.FlowDirection.LeftToRight)
			{
				flowDirection = global::System.Windows.FlowDirection.RightToLeft;
			}
			base.SetValue(global::Infragistics.Windows.Controls.PopupResizerDecorator.ResizerBarFlowDirectionPropertyKey, flowDirection);
		}

		// Token: 0x040006F2 RID: 1778
		private global::Infragistics.Windows.Controls.PopupResizerBar _resizerBar;

		// Token: 0x040006F3 RID: 1779
		private global::System.Windows.Controls.Primitives.Thumb _thumb;

		// Token: 0x040006F4 RID: 1780
		private global::System.Windows.Controls.Primitives.Popup _popup;

		// Token: 0x040006F5 RID: 1781
		private global::System.Windows.Controls.Primitives.PlacementMode _popupOriginalPlacement;

		// Token: 0x040006F6 RID: 1782
		private double _popupOriginalVerticalOffset;

		// Token: 0x040006F7 RID: 1783
		private double _popupOriginalHorizontalOffset;

		// Token: 0x040006F8 RID: 1784
		private global::System.Windows.Controls.Primitives.CustomPopupPlacementCallback _popupOriginalCustomPopupCallback;

		// Token: 0x040006F9 RID: 1785
		private global::System.Windows.Point _customPlacmentPoint;

		// Token: 0x040006FA RID: 1786
		private global::System.Windows.FrameworkElement _popupRoot;

		// Token: 0x040006FB RID: 1787
		private global::System.Windows.UIElement _commonAncestor;

		// Token: 0x040006FC RID: 1788
		private global::System.Collections.Generic.Dictionary<global::System.Windows.FrameworkElement, global::Infragistics.Windows.Controls.PopupResizerDecorator.Constraints> _constraintDictionary;

		// Token: 0x040006FD RID: 1789
		private bool _draggingConstraintsDirty;

		// Token: 0x040006FE RID: 1790
		private double _minDraggingWidth;

		// Token: 0x040006FF RID: 1791
		private double _minDraggingHeight;

		// Token: 0x04000700 RID: 1792
		private double _maxDraggingWidth;

		// Token: 0x04000701 RID: 1793
		private double _maxDraggingHeight;

		// Token: 0x04000702 RID: 1794
		private global::System.Windows.Rect _resizeWorkArea;

		// Token: 0x04000703 RID: 1795
		private bool _popupWasResized;

		// Token: 0x04000704 RID: 1796
		private global::System.Windows.Controls.Primitives.CustomPopupPlacementCallback _popupPlacementCallback;

		// Token: 0x04000705 RID: 1797
		private double _preferredWidth = double.PositiveInfinity;

		// Token: 0x04000706 RID: 1798
		private double _preferredHeight = double.PositiveInfinity;

		// Token: 0x04000707 RID: 1799
		public static readonly global::System.Windows.DependencyProperty ResizeConstraintsProperty = global::System.Windows.DependencyProperty.RegisterAttached("ResizeConstraints", typeof(global::Infragistics.Windows.Controls.PopupResizerDecorator.Constraints), typeof(global::Infragistics.Windows.Controls.PopupResizerDecorator), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.PopupResizerDecorator.OnResizeConstraintsChanged)));

		// Token: 0x04000708 RID: 1800
		public static readonly global::System.Windows.DependencyProperty ResizeModeProperty = global::System.Windows.DependencyProperty.Register("ResizeMode", typeof(global::Infragistics.Windows.Controls.PopupResizeMode), typeof(global::Infragistics.Windows.Controls.PopupResizerDecorator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.PopupResizeMode.None, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));

		// Token: 0x04000709 RID: 1801
		private static readonly global::System.Windows.DependencyPropertyKey ResizerBarLocationPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ResizerBarLocation", typeof(global::Infragistics.Windows.Controls.PopupResizerBarLocation), typeof(global::Infragistics.Windows.Controls.PopupResizerDecorator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.PopupResizerBarLocation.Bottom, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange));

		// Token: 0x0400070A RID: 1802
		public static readonly global::System.Windows.DependencyProperty ResizerBarLocationProperty = global::Infragistics.Windows.Controls.PopupResizerDecorator.ResizerBarLocationPropertyKey.DependencyProperty;

		// Token: 0x0400070B RID: 1803
		public static readonly global::System.Windows.DependencyProperty ResizerBarStyleProperty = global::System.Windows.DependencyProperty.Register("ResizerBarStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.Controls.PopupResizerDecorator), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.PopupResizerDecorator.OnResizerBarStyleChanged)));

		// Token: 0x0400070C RID: 1804
		private static readonly global::System.Windows.DependencyPropertyKey ResizerBarFlowDirectionPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ResizerBarFlowDirection", typeof(global::System.Windows.FlowDirection), typeof(global::Infragistics.Windows.Controls.PopupResizerDecorator), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.FlowDirection.LeftToRight));

		// Token: 0x0400070D RID: 1805
		private static readonly global::System.Windows.DependencyProperty ResizerBarFlowDirectionProperty = global::Infragistics.Windows.Controls.PopupResizerDecorator.ResizerBarFlowDirectionPropertyKey.DependencyProperty;

		// Token: 0x0400070E RID: 1806
		private bool _processingDragDelta;

		// Token: 0x02000198 RID: 408
		// (Invoke) Token: 0x06000DE1 RID: 3553
		private delegate void MethodDelegate();

		// Token: 0x02000199 RID: 409
		public class Constraints : global::Infragistics.PropertyChangeNotifier
		{
			// Token: 0x170002AC RID: 684
			// (get) Token: 0x06000DE5 RID: 3557 RVA: 0x0002DD63 File Offset: 0x0002BF63
			// (set) Token: 0x06000DE6 RID: 3558 RVA: 0x0002DD6C File Offset: 0x0002BF6C
			public double MaximumHeight
			{
				get
				{
					return this._maximumHeight;
				}
				set
				{
					if (value != this._maximumHeight)
					{
						if (value < 0.0)
						{
							throw new global::System.ArgumentOutOfRangeException("MaximumHeight", value, global::SR.GetString("LE_ValueCannotBeNegative"));
						}
						this._maximumHeight = value;
						base.RaisePropertyChangedEvent("MaximumHeight");
					}
				}
			}

			// Token: 0x170002AD RID: 685
			// (get) Token: 0x06000DE7 RID: 3559 RVA: 0x0002DDBB File Offset: 0x0002BFBB
			// (set) Token: 0x06000DE8 RID: 3560 RVA: 0x0002DDC4 File Offset: 0x0002BFC4
			public double MaximumWidth
			{
				get
				{
					return this._maximumWidth;
				}
				set
				{
					if (value != this._maximumWidth)
					{
						if (value < 0.0)
						{
							throw new global::System.ArgumentOutOfRangeException("MaximumWidth", value, global::SR.GetString("LE_ValueCannotBeNegative"));
						}
						this._maximumWidth = value;
						base.RaisePropertyChangedEvent("MaximumWidth");
					}
				}
			}

			// Token: 0x170002AE RID: 686
			// (get) Token: 0x06000DE9 RID: 3561 RVA: 0x0002DE13 File Offset: 0x0002C013
			// (set) Token: 0x06000DEA RID: 3562 RVA: 0x0002DE1C File Offset: 0x0002C01C
			public double MinimumHeight
			{
				get
				{
					return this._minimumHeight;
				}
				set
				{
					if (value != this._minimumHeight)
					{
						if (value < 0.0)
						{
							throw new global::System.ArgumentOutOfRangeException("MinimumHeight", value, global::SR.GetString("LE_ValueCannotBeNegative"));
						}
						this._minimumHeight = value;
						base.RaisePropertyChangedEvent("MinimumHeight");
					}
				}
			}

			// Token: 0x170002AF RID: 687
			// (get) Token: 0x06000DEB RID: 3563 RVA: 0x0002DE6B File Offset: 0x0002C06B
			// (set) Token: 0x06000DEC RID: 3564 RVA: 0x0002DE74 File Offset: 0x0002C074
			public double MinimumWidth
			{
				get
				{
					return this._minimumWidth;
				}
				set
				{
					if (value != this._minimumWidth)
					{
						if (value < 0.0)
						{
							throw new global::System.ArgumentOutOfRangeException("MinimumWidth", value, global::SR.GetString("LE_ValueCannotBeNegative"));
						}
						this._minimumWidth = value;
						base.RaisePropertyChangedEvent("MinimumWidth");
					}
				}
			}

			// Token: 0x170002B0 RID: 688
			// (get) Token: 0x06000DED RID: 3565 RVA: 0x0002DEC3 File Offset: 0x0002C0C3
			internal global::System.Windows.FrameworkElement Element
			{
				get
				{
					if (this._elementReference == null)
					{
						return null;
					}
					return global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._elementReference) as global::System.Windows.FrameworkElement;
				}
			}

			// Token: 0x06000DEE RID: 3566 RVA: 0x0002DEE0 File Offset: 0x0002C0E0
			internal void Aggregate(ref double maxHorizontalDeltaNegative, ref double maxHorizontalDeltaPositive, ref double maxVerticalDeltaNegative, ref double maxVerticalDeltaPositive)
			{
				global::System.Windows.FrameworkElement element = this.Element;
				if (element == null)
				{
					return;
				}
				global::System.Windows.Thickness margin = element.Margin;
				double actual = element.ActualWidth - (margin.Left + margin.Right);
				double actual2 = element.ActualHeight - (margin.Top + margin.Bottom);
				global::Infragistics.Windows.Controls.PopupResizerDecorator.Constraints.AggregateHelper(ref maxHorizontalDeltaNegative, ref maxHorizontalDeltaPositive, actual, this._minimumWidth, this._maximumWidth, false);
				global::Infragistics.Windows.Controls.PopupResizerDecorator.Constraints.AggregateHelper(ref maxVerticalDeltaNegative, ref maxVerticalDeltaPositive, actual2, this._minimumHeight, this._maximumHeight, true);
			}

			// Token: 0x06000DEF RID: 3567 RVA: 0x0002DF58 File Offset: 0x0002C158
			private static void AggregateHelper(ref double maxDeltaNegative, ref double maxDeltaPositive, double actual, double minimum, double maximum, bool isStackedDimension)
			{
				if (!double.IsNaN(minimum) && !double.IsPositiveInfinity(minimum))
				{
					double num = actual - minimum;
					if (double.IsNaN(maxDeltaNegative))
					{
						if (isStackedDimension)
						{
							maxDeltaNegative = 0.0;
						}
						else
						{
							maxDeltaNegative = actual;
						}
					}
					if (num >= 0.0)
					{
						if (isStackedDimension)
						{
							maxDeltaNegative += num;
						}
						else
						{
							maxDeltaNegative = global::System.Math.Min(maxDeltaNegative, num);
						}
					}
					else if (!isStackedDimension)
					{
						maxDeltaNegative = 0.0;
					}
				}
				if (!double.IsNaN(maximum) && !double.IsPositiveInfinity(maximum) && maximum > actual)
				{
					double num2 = maximum - actual;
					if (double.IsNaN(maxDeltaPositive))
					{
						if (isStackedDimension)
						{
							maxDeltaPositive = 0.0;
						}
						else
						{
							maxDeltaPositive = double.MaxValue;
						}
					}
					if (num2 > 0.0)
					{
						if (isStackedDimension)
						{
							maxDeltaPositive += num2;
							return;
						}
						maxDeltaPositive = global::System.Math.Min(maxDeltaPositive, num2);
						return;
					}
					else if (!isStackedDimension)
					{
						maxDeltaPositive = 0.0;
					}
				}
			}

			// Token: 0x06000DF0 RID: 3568 RVA: 0x0002E048 File Offset: 0x0002C248
			internal void Initialize(global::System.Windows.FrameworkElement element)
			{
				global::System.Windows.FrameworkElement element2 = this.Element;
				if (element2 != null)
				{
					if (this._resizeDecorator != null)
					{
						this._resizeDecorator.UnregisterDescendantResizeConstraints(element2);
						this._resizeDecorator = null;
					}
					else if (!element2.IsLoaded)
					{
						element2.Loaded -= this.OnElementLoaded;
					}
					this._elementReference = null;
				}
				if (element != null)
				{
					this._elementReference = new global::System.WeakReference(element);
					this._resizeDecorator = (global::Infragistics.Windows.Utilities.GetAncestorFromType(element, typeof(global::Infragistics.Windows.Controls.PopupResizerDecorator), false, null, typeof(global::System.Windows.Controls.Primitives.Popup)) as global::Infragistics.Windows.Controls.PopupResizerDecorator);
					if (this._resizeDecorator != null)
					{
						this._resizeDecorator.RegisterDescendantResizeConstraints(element, this);
					}
					else if (!element.IsLoaded)
					{
						element.Loaded += this.OnElementLoaded;
					}
				}
				this.OnElementChanged(element2, element);
			}

			// Token: 0x06000DF1 RID: 3569 RVA: 0x0002E10C File Offset: 0x0002C30C
			internal virtual void OnElementChanged(global::System.Windows.FrameworkElement oldElement, global::System.Windows.FrameworkElement newElement)
			{
			}

			// Token: 0x06000DF2 RID: 3570 RVA: 0x0002E110 File Offset: 0x0002C310
			private void OnElementLoaded(object sender, global::System.Windows.RoutedEventArgs e)
			{
				global::System.Windows.FrameworkElement frameworkElement = sender as global::System.Windows.FrameworkElement;
				global::System.Windows.FrameworkElement element = this.Element;
				frameworkElement.Loaded -= this.OnElementLoaded;
				if (element == frameworkElement)
				{
					this._resizeDecorator = (global::Infragistics.Windows.Utilities.GetAncestorFromType(element, typeof(global::Infragistics.Windows.Controls.PopupResizerDecorator), false) as global::Infragistics.Windows.Controls.PopupResizerDecorator);
					if (this._resizeDecorator != null)
					{
						this._resizeDecorator.RegisterDescendantResizeConstraints(element, this);
					}
				}
			}

			// Token: 0x0400070F RID: 1807
			private global::System.WeakReference _elementReference;

			// Token: 0x04000710 RID: 1808
			private global::Infragistics.Windows.Controls.PopupResizerDecorator _resizeDecorator;

			// Token: 0x04000711 RID: 1809
			private double _minimumHeight = double.NaN;

			// Token: 0x04000712 RID: 1810
			private double _minimumWidth = double.NaN;

			// Token: 0x04000713 RID: 1811
			private double _maximumHeight = double.NaN;

			// Token: 0x04000714 RID: 1812
			private double _maximumWidth = double.NaN;
		}
	}
}
