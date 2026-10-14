using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace Infragistics.Windows.Controls
{
	// Token: 0x020001BC RID: 444
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class PopupResizerStackPanel : global::System.Windows.Controls.Panel, global::System.Windows.Controls.Primitives.IScrollInfo
	{
		// Token: 0x06000EDC RID: 3804 RVA: 0x0002FCC0 File Offset: 0x0002DEC0
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.PopupResizerStackPanel.ResizableItemInfo> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.PopupResizerStackPanel.ResizableItemInfo>();
			global::System.Windows.Controls.UIElementCollection internalChildren = base.InternalChildren;
			double num = 0.0;
			bool flag = this.Orientation == global::System.Windows.Controls.Orientation.Vertical;
			int i = 0;
			int count = internalChildren.Count;
			while (i < count)
			{
				global::System.Windows.UIElement uielement = internalChildren[i];
				if (uielement != null && uielement.Visibility != global::System.Windows.Visibility.Collapsed)
				{
					bool flag2 = uielement is global::System.Windows.FrameworkElement && global::Infragistics.Windows.Controls.PopupResizerStackPanel.GetIsResizable(uielement);
					if (flag2 && list.Count == 1)
					{
						flag2 = false;
					}
					global::Infragistics.Windows.Controls.PopupResizerDecorator.Constraints resizeConstraints = (!flag2) ? null : global::Infragistics.Windows.Controls.PopupResizerDecorator.GetResizeConstraints(uielement as global::System.Windows.FrameworkElement);
					if (flag2)
					{
						list.Add(new global::Infragistics.Windows.Controls.PopupResizerStackPanel.ResizableItemInfo
						{
							Index = i,
							ResizeConstraints = resizeConstraints
						});
					}
					else
					{
						global::System.Windows.Size desiredSize = uielement.DesiredSize;
						num += (flag ? desiredSize.Height : desiredSize.Width);
					}
				}
				i++;
			}
			double num2 = flag ? finalSize.Height : finalSize.Width;
			int num3 = internalChildren.Count;
			if (list.Count > 0 && num2 > num)
			{
				list[0].Extent = num2 - num;
				num3 = list[0].Index;
			}
			global::System.Windows.Rect finalRect = new global::System.Windows.Rect(finalSize);
			int num4 = 0;
			int j = 0;
			int count2 = internalChildren.Count;
			while (j < count2)
			{
				global::System.Windows.UIElement uielement2 = internalChildren[j];
				if (uielement2 != null && uielement2.Visibility != global::System.Windows.Visibility.Collapsed)
				{
					if (j == num3)
					{
						if (flag)
						{
							finalRect.Height = list[num4].Extent;
						}
						else
						{
							finalRect.Width = list[num4].Extent;
						}
						num4++;
						num3 = ((num4 < list.Count) ? list[num4].Index : internalChildren.Count);
					}
					else if (flag)
					{
						finalRect.Height = uielement2.DesiredSize.Height;
					}
					else
					{
						finalRect.Width = uielement2.DesiredSize.Width;
					}
					uielement2.Arrange(finalRect);
					if (flag)
					{
						finalRect.Y += finalRect.Height;
					}
					else
					{
						finalRect.X += finalRect.Width;
					}
				}
				j++;
			}
			if (flag && finalRect.Y > finalSize.Height)
			{
				finalSize.Height = finalRect.Y;
			}
			else if (!flag && finalRect.X > finalSize.Width)
			{
				finalSize.Width = finalRect.X;
			}
			return finalSize;
		}

		// Token: 0x06000EDD RID: 3805 RVA: 0x0002FF48 File Offset: 0x0002E148
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			global::System.Windows.Controls.UIElementCollection internalChildren = base.InternalChildren;
			global::System.Windows.Size availableSize2 = availableSize;
			bool flag = this.Orientation == global::System.Windows.Controls.Orientation.Vertical;
			double num = flag ? availableSize.Height : availableSize.Width;
			double num2 = flag ? availableSize.Width : availableSize.Height;
			if (flag)
			{
				availableSize2.Height = double.PositiveInfinity;
			}
			else
			{
				availableSize2.Width = double.PositiveInfinity;
			}
			double num3 = 0.0;
			double num4 = 0.0;
			global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.PopupResizerStackPanel.ResizableItemInfo> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.PopupResizerStackPanel.ResizableItemInfo>();
			int i = 0;
			int count = internalChildren.Count;
			while (i < count)
			{
				global::System.Windows.UIElement uielement = internalChildren[i];
				if (uielement != null && uielement.Visibility != global::System.Windows.Visibility.Collapsed)
				{
					global::System.Windows.FrameworkElement frameworkElement = uielement as global::System.Windows.FrameworkElement;
					bool flag2 = frameworkElement != null && global::Infragistics.Windows.Controls.PopupResizerStackPanel.GetIsResizable(frameworkElement);
					global::Infragistics.Windows.Controls.PopupResizerDecorator.Constraints constraints = null;
					if (flag2)
					{
						if (!flag2 || list.Count != 1)
						{
							constraints = global::Infragistics.Windows.Controls.PopupResizerDecorator.GetResizeConstraints(frameworkElement);
							if (constraints == null)
							{
								uielement.Measure(availableSize2);
								constraints = global::Infragistics.Windows.Controls.PopupResizerDecorator.GetResizeConstraints(frameworkElement);
								if (constraints == null)
								{
									constraints = new global::Infragistics.Windows.Controls.PopupResizerStackPanel.ItemConstraints();
									global::Infragistics.Windows.Controls.PopupResizerDecorator.SetResizeConstraints(frameworkElement, constraints);
								}
								constraints.MinimumWidth = uielement.DesiredSize.Width;
								constraints.MinimumHeight = uielement.DesiredSize.Height;
							}
							num3 = global::System.Math.Max(flag ? constraints.MinimumWidth : constraints.MinimumHeight, num3);
						}
					}
					if (constraints != null)
					{
						list.Add(new global::Infragistics.Windows.Controls.PopupResizerStackPanel.ResizableItemInfo
						{
							Index = i,
							ResizeConstraints = constraints
						});
					}
					else
					{
						uielement.Measure(availableSize2);
						global::System.Windows.Size desiredSize = uielement.DesiredSize;
						num3 = global::System.Math.Max(flag ? desiredSize.Width : desiredSize.Height, num3);
						num4 += (flag ? desiredSize.Height : desiredSize.Width);
					}
				}
				i++;
			}
			int count2 = list.Count;
			if (count2 > 0)
			{
				bool flag3 = double.IsInfinity(num);
				bool flag4 = double.IsInfinity(num2);
				double num5 = global::System.Math.Max(num - num4, 0.0);
				double num6 = flag4 ? num3 : num2;
				global::System.Windows.Size availableSize3 = flag ? new global::System.Windows.Size(num6, double.PositiveInfinity) : new global::System.Windows.Size(double.PositiveInfinity, num6);
				for (int j = 0; j < count2; j++)
				{
					global::Infragistics.Windows.Controls.PopupResizerStackPanel.ResizableItemInfo resizableItemInfo = list[j];
					double num7;
					if (flag3)
					{
						num7 = (flag ? resizableItemInfo.ResizeConstraints.MinimumHeight : resizableItemInfo.ResizeConstraints.MinimumWidth);
					}
					else
					{
						num7 = num5 / (double)(count2 - j);
						num5 -= num7;
						if (flag)
						{
							availableSize3.Height = num7;
						}
						else
						{
							availableSize3.Width = num7;
						}
					}
					num4 += num7;
					internalChildren[resizableItemInfo.Index].Measure(availableSize3);
				}
			}
			global::System.Windows.Size result;
			if (flag)
			{
				result = new global::System.Windows.Size(num3, num4);
			}
			else
			{
				result = new global::System.Windows.Size(num4, num3);
			}
			return result;
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x0003023A File Offset: 0x0002E43A
		[global::System.Windows.AttachedPropertyBrowsableForChildren(IncludeDescendants = false)]
		public static bool GetIsResizable(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.Controls.PopupResizerStackPanel.IsResizableProperty);
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x0003024C File Offset: 0x0002E44C
		public static void SetIsResizable(global::System.Windows.DependencyObject d, bool value)
		{
			d.SetValue(global::Infragistics.Windows.Controls.PopupResizerStackPanel.IsResizableProperty, value);
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000EE0 RID: 3808 RVA: 0x0003025F File Offset: 0x0002E45F
		// (set) Token: 0x06000EE1 RID: 3809 RVA: 0x00030271 File Offset: 0x0002E471
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Description("Returns or sets the orientation of the items.")]
		[global::System.ComponentModel.Category("Behavior")]
		public global::System.Windows.Controls.Orientation Orientation
		{
			get
			{
				return (global::System.Windows.Controls.Orientation)base.GetValue(global::Infragistics.Windows.Controls.PopupResizerStackPanel.OrientationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.PopupResizerStackPanel.OrientationProperty, value);
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000EE2 RID: 3810 RVA: 0x00030284 File Offset: 0x0002E484
		private bool IsScrollClient
		{
			get
			{
				return this._scrollDataInfo != null && this._scrollDataInfo._scrollOwner != null;
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000EE3 RID: 3811 RVA: 0x000302A1 File Offset: 0x0002E4A1
		private global::Infragistics.Windows.Controls.PagerContentPresenter.ScrollData ScrollDataInfo
		{
			get
			{
				if (this._scrollDataInfo == null)
				{
					this._scrollDataInfo = new global::Infragistics.Windows.Controls.PagerContentPresenter.ScrollData();
				}
				return this._scrollDataInfo;
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000EE4 RID: 3812 RVA: 0x000302BC File Offset: 0x0002E4BC
		// (set) Token: 0x06000EE5 RID: 3813 RVA: 0x000302D3 File Offset: 0x0002E4D3
		public bool CanHorizontallyScroll
		{
			get
			{
				return this.IsScrollClient && this.ScrollDataInfo._canHorizontallyScroll;
			}
			set
			{
				if (this.IsScrollClient && this.ScrollDataInfo._canHorizontallyScroll != value)
				{
					this.ScrollDataInfo._canHorizontallyScroll = value;
					base.InvalidateMeasure();
				}
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000EE6 RID: 3814 RVA: 0x000302FD File Offset: 0x0002E4FD
		// (set) Token: 0x06000EE7 RID: 3815 RVA: 0x00030314 File Offset: 0x0002E514
		public bool CanVerticallyScroll
		{
			get
			{
				return this.IsScrollClient && this.ScrollDataInfo._canVerticallyScroll;
			}
			set
			{
				if (this.IsScrollClient && this.ScrollDataInfo._canVerticallyScroll != value)
				{
					this.ScrollDataInfo._canVerticallyScroll = value;
					base.InvalidateMeasure();
				}
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000EE8 RID: 3816 RVA: 0x0003033E File Offset: 0x0002E53E
		public double ExtentHeight
		{
			get
			{
				if (!this.IsScrollClient)
				{
					return 0.0;
				}
				return this.ScrollDataInfo._extent.Height;
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000EE9 RID: 3817 RVA: 0x00030362 File Offset: 0x0002E562
		public double ExtentWidth
		{
			get
			{
				if (!this.IsScrollClient)
				{
					return 0.0;
				}
				return this.ScrollDataInfo._extent.Width;
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000EEA RID: 3818 RVA: 0x00030386 File Offset: 0x0002E586
		public double HorizontalOffset
		{
			get
			{
				if (!this.IsScrollClient)
				{
					return 0.0;
				}
				return this.ScrollDataInfo._offset.X;
			}
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x000303AA File Offset: 0x0002E5AA
		public void LineDown()
		{
			if (this.IsScrollClient)
			{
				this.SetVerticalOffset(this.ScrollDataInfo._offset.Y + 16.0);
			}
		}

		// Token: 0x06000EEC RID: 3820 RVA: 0x000303D4 File Offset: 0x0002E5D4
		public void LineLeft()
		{
			if (this.IsScrollClient)
			{
				this.SetHorizontalOffset(this.ScrollDataInfo._offset.X - 16.0);
			}
		}

		// Token: 0x06000EED RID: 3821 RVA: 0x000303FE File Offset: 0x0002E5FE
		public void LineRight()
		{
			if (this.IsScrollClient)
			{
				this.SetHorizontalOffset(this.ScrollDataInfo._offset.X + 16.0);
			}
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x00030428 File Offset: 0x0002E628
		public void LineUp()
		{
			if (this.IsScrollClient)
			{
				this.SetVerticalOffset(this.ScrollDataInfo._offset.Y - 16.0);
			}
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x00030454 File Offset: 0x0002E654
		public global::System.Windows.Rect MakeVisible(global::System.Windows.Media.Visual visual, global::System.Windows.Rect rectangle)
		{
			if (rectangle.IsEmpty || visual == null || !base.IsAncestorOf(visual))
			{
				return global::System.Windows.Rect.Empty;
			}
			global::System.Windows.Media.GeneralTransform generalTransform = visual.TransformToAncestor(this);
			if (generalTransform == null)
			{
				return global::System.Windows.Rect.Empty;
			}
			global::System.Windows.Rect rect = generalTransform.TransformBounds(rectangle);
			if (this.IsScrollClient)
			{
				global::System.Windows.Rect rect2 = new global::System.Windows.Rect(base.RenderSize);
				global::System.Windows.Rect rect3 = global::System.Windows.Rect.Intersect(rect, rect2);
				if (rect3.Width != rect.Width)
				{
					double num = 0.0;
					if (rect.Right > rect2.Right)
					{
						num = rect.Right - rect2.Right;
					}
					if (rect.Left - num - rect2.Left < 0.0)
					{
						num += rect.Left - num - rect2.Left;
					}
					rect.X -= num;
					num += this.HorizontalOffset;
					this.SetHorizontalOffset(num);
				}
				if (rect3.Height != rect.Height)
				{
					double num2 = 0.0;
					if (rect.Bottom > rect2.Bottom)
					{
						num2 = rect.Bottom - rect2.Bottom;
					}
					if (rect.Top - num2 - rect2.Top < 0.0)
					{
						num2 += rect.Top - num2 - rect2.Top;
					}
					rect.Y -= num2;
					num2 += this.VerticalOffset;
					this.SetVerticalOffset(num2);
				}
			}
			return rect;
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x000305E2 File Offset: 0x0002E7E2
		public void MouseWheelDown()
		{
			if (this.IsScrollClient)
			{
				this.SetVerticalOffset(this.ScrollDataInfo._offset.Y + (double)global::System.Windows.SystemParameters.WheelScrollLines * 16.0);
			}
		}

		// Token: 0x06000EF1 RID: 3825 RVA: 0x00030613 File Offset: 0x0002E813
		public void MouseWheelLeft()
		{
			if (this.IsScrollClient)
			{
				this.SetHorizontalOffset(this.ScrollDataInfo._offset.X - (double)global::System.Windows.SystemParameters.WheelScrollLines * 16.0);
			}
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x00030644 File Offset: 0x0002E844
		public void MouseWheelRight()
		{
			if (this.IsScrollClient)
			{
				this.SetHorizontalOffset(this.ScrollDataInfo._offset.X + (double)global::System.Windows.SystemParameters.WheelScrollLines * 16.0);
			}
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x00030675 File Offset: 0x0002E875
		public void MouseWheelUp()
		{
			if (this.IsScrollClient)
			{
				this.SetVerticalOffset(this.ScrollDataInfo._offset.Y - (double)global::System.Windows.SystemParameters.WheelScrollLines * 16.0);
			}
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x000306A6 File Offset: 0x0002E8A6
		public void PageDown()
		{
			if (this.IsScrollClient)
			{
				this.SetVerticalOffset(this.ScrollDataInfo._offset.Y + this.ScrollDataInfo._viewport.Height);
			}
		}

		// Token: 0x06000EF5 RID: 3829 RVA: 0x000306D7 File Offset: 0x0002E8D7
		public void PageLeft()
		{
			if (this.IsScrollClient)
			{
				this.SetVerticalOffset(this.ScrollDataInfo._offset.X - this.ScrollDataInfo._viewport.Width);
			}
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x00030708 File Offset: 0x0002E908
		public void PageRight()
		{
			if (this.IsScrollClient)
			{
				this.SetVerticalOffset(this.ScrollDataInfo._offset.X + this.ScrollDataInfo._viewport.Width);
			}
		}

		// Token: 0x06000EF7 RID: 3831 RVA: 0x00030739 File Offset: 0x0002E939
		public void PageUp()
		{
			if (this.IsScrollClient)
			{
				this.SetVerticalOffset(this.ScrollDataInfo._offset.Y - this.ScrollDataInfo._viewport.Height);
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000EF8 RID: 3832 RVA: 0x0003076A File Offset: 0x0002E96A
		// (set) Token: 0x06000EF9 RID: 3833 RVA: 0x00030781 File Offset: 0x0002E981
		public global::System.Windows.Controls.ScrollViewer ScrollOwner
		{
			get
			{
				if (this.IsScrollClient)
				{
					return this.ScrollDataInfo._scrollOwner;
				}
				return null;
			}
			set
			{
				if (this.IsScrollClient)
				{
					this.ScrollDataInfo._scrollOwner = value;
				}
			}
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x00030798 File Offset: 0x0002E998
		public void SetHorizontalOffset(double offset)
		{
			if (this.IsScrollClient)
			{
				global::Infragistics.Windows.Controls.PagerContentPresenter.EnsureIsANumber(offset);
				offset = global::System.Math.Max(offset, 0.0);
				if (!global::Infragistics.CoreUtilities.AreClose(offset, this.ScrollDataInfo._offset.X))
				{
					this.ScrollDataInfo._offset.X = offset;
					if (this.ScrollDataInfo._scrollOwner != null)
					{
						this.ScrollDataInfo._scrollOwner.InvalidateScrollInfo();
					}
					base.InvalidateArrange();
				}
			}
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x00030810 File Offset: 0x0002EA10
		public void SetVerticalOffset(double offset)
		{
			if (this.IsScrollClient)
			{
				global::Infragistics.Windows.Controls.PagerContentPresenter.EnsureIsANumber(offset);
				offset = global::System.Math.Max(offset, 0.0);
				if (!global::Infragistics.CoreUtilities.AreClose(offset, this.ScrollDataInfo._offset.Y))
				{
					this.ScrollDataInfo._offset.Y = offset;
					if (this.ScrollDataInfo._scrollOwner != null)
					{
						this.ScrollDataInfo._scrollOwner.InvalidateScrollInfo();
					}
					base.InvalidateArrange();
				}
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000EFC RID: 3836 RVA: 0x00030888 File Offset: 0x0002EA88
		public double VerticalOffset
		{
			get
			{
				if (!this.IsScrollClient)
				{
					return 0.0;
				}
				return this.ScrollDataInfo._offset.Y;
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000EFD RID: 3837 RVA: 0x000308AC File Offset: 0x0002EAAC
		public double ViewportHeight
		{
			get
			{
				if (!this.IsScrollClient)
				{
					return 0.0;
				}
				return this.ScrollDataInfo._viewport.Height;
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000EFE RID: 3838 RVA: 0x000308D0 File Offset: 0x0002EAD0
		public double ViewportWidth
		{
			get
			{
				if (!this.IsScrollClient)
				{
					return 0.0;
				}
				return this.ScrollDataInfo._viewport.Width;
			}
		}

		// Token: 0x04000816 RID: 2070
		private global::Infragistics.Windows.Controls.PagerContentPresenter.ScrollData _scrollDataInfo;

		// Token: 0x04000817 RID: 2071
		public static readonly global::System.Windows.DependencyProperty IsResizableProperty = global::System.Windows.DependencyProperty.RegisterAttached("IsResizable", typeof(bool), typeof(global::Infragistics.Windows.Controls.PopupResizerStackPanel), new global::System.Windows.FrameworkPropertyMetadata(false, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsParentMeasure));

		// Token: 0x04000818 RID: 2072
		public static readonly global::System.Windows.DependencyProperty OrientationProperty = global::System.Windows.DependencyProperty.Register("Orientation", typeof(global::System.Windows.Controls.Orientation), typeof(global::Infragistics.Windows.Controls.PopupResizerStackPanel), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.OrientationVerticalBox, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));

		// Token: 0x020001BD RID: 445
		private class ResizableItemInfo
		{
			// Token: 0x04000819 RID: 2073
			public int Index;

			// Token: 0x0400081A RID: 2074
			public double Extent;

			// Token: 0x0400081B RID: 2075
			public global::Infragistics.Windows.Controls.PopupResizerDecorator.Constraints ResizeConstraints;
		}

		// Token: 0x020001C1 RID: 449
		private class ItemConstraints : global::Infragistics.Windows.Controls.PopupResizerDecorator.Constraints
		{
			// Token: 0x06000F46 RID: 3910 RVA: 0x000329EC File Offset: 0x00030BEC
			internal override void OnElementChanged(global::System.Windows.FrameworkElement oldElement, global::System.Windows.FrameworkElement newElement)
			{
				if (newElement == null && oldElement != null)
				{
					global::Infragistics.Windows.Controls.PopupResizerStackPanel popupResizerStackPanel = global::System.Windows.Media.VisualTreeHelper.GetParent(oldElement) as global::Infragistics.Windows.Controls.PopupResizerStackPanel;
					if (popupResizerStackPanel != null)
					{
						popupResizerStackPanel.InvalidateMeasure();
					}
				}
			}
		}
	}
}
