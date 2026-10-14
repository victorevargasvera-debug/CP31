using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000195 RID: 405
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class PopupResizerStackPanel : global::System.Windows.Controls.Panel, global::System.Windows.Controls.Primitives.IScrollInfo
	{
		// Token: 0x06000D89 RID: 3465 RVA: 0x0002B460 File Offset: 0x00029660
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

		// Token: 0x06000D8A RID: 3466 RVA: 0x0002B6E8 File Offset: 0x000298E8
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

		// Token: 0x06000D8B RID: 3467 RVA: 0x0002B9DA File Offset: 0x00029BDA
		[global::System.Windows.AttachedPropertyBrowsableForChildren(IncludeDescendants = false)]
		public static bool GetIsResizable(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.Controls.PopupResizerStackPanel.IsResizableProperty);
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x0002B9EC File Offset: 0x00029BEC
		public static void SetIsResizable(global::System.Windows.DependencyObject d, bool value)
		{
			d.SetValue(global::Infragistics.Windows.Controls.PopupResizerStackPanel.IsResizableProperty, value);
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000D8D RID: 3469 RVA: 0x0002B9FF File Offset: 0x00029BFF
		// (set) Token: 0x06000D8E RID: 3470 RVA: 0x0002BA11 File Offset: 0x00029C11
		[global::System.ComponentModel.Category("Behavior")]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Description("Returns or sets the orientation of the items.")]
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

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000D8F RID: 3471 RVA: 0x0002BA24 File Offset: 0x00029C24
		private bool IsScrollClient
		{
			get
			{
				return this._scrollDataInfo != null && this._scrollDataInfo._scrollOwner != null;
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000D90 RID: 3472 RVA: 0x0002BA41 File Offset: 0x00029C41
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

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000D91 RID: 3473 RVA: 0x0002BA5C File Offset: 0x00029C5C
		// (set) Token: 0x06000D92 RID: 3474 RVA: 0x0002BA73 File Offset: 0x00029C73
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

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000D93 RID: 3475 RVA: 0x0002BA9D File Offset: 0x00029C9D
		// (set) Token: 0x06000D94 RID: 3476 RVA: 0x0002BAB4 File Offset: 0x00029CB4
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

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000D95 RID: 3477 RVA: 0x0002BADE File Offset: 0x00029CDE
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

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000D96 RID: 3478 RVA: 0x0002BB02 File Offset: 0x00029D02
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

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000D97 RID: 3479 RVA: 0x0002BB26 File Offset: 0x00029D26
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

		// Token: 0x06000D98 RID: 3480 RVA: 0x0002BB4A File Offset: 0x00029D4A
		public void LineDown()
		{
			if (this.IsScrollClient)
			{
				this.SetVerticalOffset(this.ScrollDataInfo._offset.Y + 16.0);
			}
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x0002BB74 File Offset: 0x00029D74
		public void LineLeft()
		{
			if (this.IsScrollClient)
			{
				this.SetHorizontalOffset(this.ScrollDataInfo._offset.X - 16.0);
			}
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x0002BB9E File Offset: 0x00029D9E
		public void LineRight()
		{
			if (this.IsScrollClient)
			{
				this.SetHorizontalOffset(this.ScrollDataInfo._offset.X + 16.0);
			}
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x0002BBC8 File Offset: 0x00029DC8
		public void LineUp()
		{
			if (this.IsScrollClient)
			{
				this.SetVerticalOffset(this.ScrollDataInfo._offset.Y - 16.0);
			}
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x0002BBF4 File Offset: 0x00029DF4
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

		// Token: 0x06000D9D RID: 3485 RVA: 0x0002BD82 File Offset: 0x00029F82
		public void MouseWheelDown()
		{
			if (this.IsScrollClient)
			{
				this.SetVerticalOffset(this.ScrollDataInfo._offset.Y + (double)global::System.Windows.SystemParameters.WheelScrollLines * 16.0);
			}
		}

		// Token: 0x06000D9E RID: 3486 RVA: 0x0002BDB3 File Offset: 0x00029FB3
		public void MouseWheelLeft()
		{
			if (this.IsScrollClient)
			{
				this.SetHorizontalOffset(this.ScrollDataInfo._offset.X - (double)global::System.Windows.SystemParameters.WheelScrollLines * 16.0);
			}
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x0002BDE4 File Offset: 0x00029FE4
		public void MouseWheelRight()
		{
			if (this.IsScrollClient)
			{
				this.SetHorizontalOffset(this.ScrollDataInfo._offset.X + (double)global::System.Windows.SystemParameters.WheelScrollLines * 16.0);
			}
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x0002BE15 File Offset: 0x0002A015
		public void MouseWheelUp()
		{
			if (this.IsScrollClient)
			{
				this.SetVerticalOffset(this.ScrollDataInfo._offset.Y - (double)global::System.Windows.SystemParameters.WheelScrollLines * 16.0);
			}
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x0002BE46 File Offset: 0x0002A046
		public void PageDown()
		{
			if (this.IsScrollClient)
			{
				this.SetVerticalOffset(this.ScrollDataInfo._offset.Y + this.ScrollDataInfo._viewport.Height);
			}
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x0002BE77 File Offset: 0x0002A077
		public void PageLeft()
		{
			if (this.IsScrollClient)
			{
				this.SetVerticalOffset(this.ScrollDataInfo._offset.X - this.ScrollDataInfo._viewport.Width);
			}
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x0002BEA8 File Offset: 0x0002A0A8
		public void PageRight()
		{
			if (this.IsScrollClient)
			{
				this.SetVerticalOffset(this.ScrollDataInfo._offset.X + this.ScrollDataInfo._viewport.Width);
			}
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x0002BED9 File Offset: 0x0002A0D9
		public void PageUp()
		{
			if (this.IsScrollClient)
			{
				this.SetVerticalOffset(this.ScrollDataInfo._offset.Y - this.ScrollDataInfo._viewport.Height);
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000DA5 RID: 3493 RVA: 0x0002BF0A File Offset: 0x0002A10A
		// (set) Token: 0x06000DA6 RID: 3494 RVA: 0x0002BF21 File Offset: 0x0002A121
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

		// Token: 0x06000DA7 RID: 3495 RVA: 0x0002BF38 File Offset: 0x0002A138
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

		// Token: 0x06000DA8 RID: 3496 RVA: 0x0002BFB0 File Offset: 0x0002A1B0
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

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000DA9 RID: 3497 RVA: 0x0002C028 File Offset: 0x0002A228
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

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000DAA RID: 3498 RVA: 0x0002C04C File Offset: 0x0002A24C
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

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000DAB RID: 3499 RVA: 0x0002C070 File Offset: 0x0002A270
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

		// Token: 0x040006EC RID: 1772
		private global::Infragistics.Windows.Controls.PagerContentPresenter.ScrollData _scrollDataInfo;

		// Token: 0x040006ED RID: 1773
		public static readonly global::System.Windows.DependencyProperty IsResizableProperty = global::System.Windows.DependencyProperty.RegisterAttached("IsResizable", typeof(bool), typeof(global::Infragistics.Windows.Controls.PopupResizerStackPanel), new global::System.Windows.FrameworkPropertyMetadata(false, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsParentMeasure));

		// Token: 0x040006EE RID: 1774
		public static readonly global::System.Windows.DependencyProperty OrientationProperty = global::System.Windows.DependencyProperty.Register("Orientation", typeof(global::System.Windows.Controls.Orientation), typeof(global::Infragistics.Windows.Controls.PopupResizerStackPanel), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.OrientationVerticalBox, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));

		// Token: 0x02000196 RID: 406
		private class ResizableItemInfo
		{
			// Token: 0x040006EF RID: 1775
			public int Index;

			// Token: 0x040006F0 RID: 1776
			public double Extent;

			// Token: 0x040006F1 RID: 1777
			public global::Infragistics.Windows.Controls.PopupResizerDecorator.Constraints ResizeConstraints;
		}

		// Token: 0x0200019A RID: 410
		private class ItemConstraints : global::Infragistics.Windows.Controls.PopupResizerDecorator.Constraints
		{
			// Token: 0x06000DF3 RID: 3571 RVA: 0x0002E174 File Offset: 0x0002C374
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
