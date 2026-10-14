using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace Infragistics.Windows.Controls
{
	// Token: 0x020001F8 RID: 504
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class PagerContentPresenter : global::System.Windows.Controls.ContentPresenter, global::System.Windows.Controls.Primitives.IScrollInfo
	{
		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x060012EF RID: 4847 RVA: 0x0004526F File Offset: 0x0004346F
		// (set) Token: 0x060012F0 RID: 4848 RVA: 0x00045281 File Offset: 0x00043481
		public bool CanContentScroll
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.PagerContentPresenter.CanContentScrollProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.PagerContentPresenter.CanContentScrollProperty, value);
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x060012F1 RID: 4849 RVA: 0x00045294 File Offset: 0x00043494
		// (set) Token: 0x060012F2 RID: 4850 RVA: 0x000452A6 File Offset: 0x000434A6
		public bool? ClipContentHorizontally
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Windows.Controls.PagerContentPresenter.ClipContentHorizontallyProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.PagerContentPresenter.ClipContentHorizontallyProperty, value);
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x060012F3 RID: 4851 RVA: 0x000452B9 File Offset: 0x000434B9
		// (set) Token: 0x060012F4 RID: 4852 RVA: 0x000452CB File Offset: 0x000434CB
		public bool? ClipContentVertically
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Windows.Controls.PagerContentPresenter.ClipContentVerticallyProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.PagerContentPresenter.ClipContentVerticallyProperty, value);
			}
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x000452E0 File Offset: 0x000434E0
		private static void OnReserveSpaceForScrollButtonsChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.PagerContentPresenter pagerContentPresenter = target as global::Infragistics.Windows.Controls.PagerContentPresenter;
			if (pagerContentPresenter != null)
			{
				pagerContentPresenter._cachedReserveSpaceForScrollButtons = (bool)e.NewValue;
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x060012F6 RID: 4854 RVA: 0x00045309 File Offset: 0x00043509
		// (set) Token: 0x060012F7 RID: 4855 RVA: 0x00045311 File Offset: 0x00043511
		public bool ReserveSpaceForScrollButtons
		{
			get
			{
				return this._cachedReserveSpaceForScrollButtons;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.PagerContentPresenter.ReserveSpaceForScrollButtonsProperty, value);
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x060012F8 RID: 4856 RVA: 0x00045324 File Offset: 0x00043524
		private bool IsScrollClient
		{
			get
			{
				return this._scrollInfo == this;
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x060012F9 RID: 4857 RVA: 0x0004532F File Offset: 0x0004352F
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

		// Token: 0x060012FA RID: 4858 RVA: 0x0004534C File Offset: 0x0004354C
		internal void AdjustRect(ref global::System.Windows.Rect renderRect, global::Infragistics.Windows.Controls.PagerScrollDirection direction)
		{
			if (!this._cachedReserveSpaceForScrollButtons)
			{
				return;
			}
			global::Infragistics.Windows.Controls.XamPager xamPager = base.TemplatedParent as global::Infragistics.Windows.Controls.XamPager;
			if (xamPager != null)
			{
				global::System.Windows.FrameworkElement scrollElement = xamPager.GetScrollElement(direction);
				if (scrollElement != null && scrollElement.Visibility == global::System.Windows.Visibility.Visible)
				{
					global::System.Windows.Media.GeneralTransform generalTransform = scrollElement.TransformToVisual(this);
					global::System.Windows.Rect rect = generalTransform.TransformBounds(new global::System.Windows.Rect(0.0, 0.0, scrollElement.ActualWidth, scrollElement.ActualHeight));
					global::System.Windows.Rect rect2 = global::System.Windows.Rect.Intersect(rect, renderRect);
					if (!rect2.IsEmpty)
					{
						switch (direction)
						{
						case global::Infragistics.Windows.Controls.PagerScrollDirection.Up:
							if (rect2.Height > 0.0)
							{
								renderRect.Height -= rect2.Height;
								renderRect.Y = rect2.Bottom;
								return;
							}
							break;
						case global::Infragistics.Windows.Controls.PagerScrollDirection.Down:
							if (rect2.Height > 0.0)
							{
								renderRect.Height -= rect2.Height;
							}
							break;
						case global::Infragistics.Windows.Controls.PagerScrollDirection.Left:
							if (rect2.Width > 0.0)
							{
								renderRect.Width -= rect2.Width;
								renderRect.X = rect2.Right;
								return;
							}
							break;
						case global::Infragistics.Windows.Controls.PagerScrollDirection.Right:
							if (rect2.Width > 0.0)
							{
								renderRect.Width -= rect2.Width;
								return;
							}
							break;
						default:
							return;
						}
					}
				}
			}
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x000454AC File Offset: 0x000436AC
		internal static void EnsureIsANumber(double number)
		{
			if (double.IsNaN(number))
			{
				throw new global::System.ArgumentOutOfRangeException("offset", number, global::SR.GetString("LE_ValueCannotBeNan"));
			}
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x000454D4 File Offset: 0x000436D4
		private static void OnCanContentScrollChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.PagerContentPresenter pagerContentPresenter = d as global::Infragistics.Windows.Controls.PagerContentPresenter;
			if (pagerContentPresenter != null && pagerContentPresenter._scrollDataInfo != null)
			{
				pagerContentPresenter.VerifyScrollInfo();
				pagerContentPresenter.InvalidateMeasure();
			}
		}

		// Token: 0x060012FD RID: 4861 RVA: 0x00045500 File Offset: 0x00043700
		private void VerifyScrollInfo()
		{
			global::Infragistics.Windows.Controls.XamPager xamPager = base.TemplatedParent as global::Infragistics.Windows.Controls.XamPager;
			if (xamPager != null)
			{
				global::System.Windows.Controls.Primitives.IScrollInfo scrollInfo = null;
				if (this.CanContentScroll)
				{
					scrollInfo = (base.Content as global::System.Windows.Controls.Primitives.IScrollInfo);
					if (scrollInfo == null)
					{
						global::System.Windows.Controls.ItemsPresenter itemsPresenter = base.Content as global::System.Windows.Controls.ItemsPresenter;
						if (itemsPresenter != null)
						{
							itemsPresenter.ApplyTemplate();
							if (global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(itemsPresenter) > 0)
							{
								scrollInfo = (global::System.Windows.Media.VisualTreeHelper.GetChild(itemsPresenter, 0) as global::System.Windows.Controls.Primitives.IScrollInfo);
							}
						}
					}
				}
				if (scrollInfo == null)
				{
					scrollInfo = this;
				}
				if (scrollInfo != this._scrollInfo)
				{
					if (this.IsScrollClient)
					{
						this._scrollInfo = null;
					}
					else if (this._scrollInfo != null && this._scrollInfo.ScrollOwner == xamPager)
					{
						this._scrollInfo.ScrollOwner = null;
					}
				}
				if (scrollInfo != null)
				{
					this._scrollInfo = scrollInfo;
					scrollInfo.ScrollOwner = xamPager;
					xamPager.ScrollInfoInternal = scrollInfo;
					return;
				}
			}
			else if (this._scrollInfo != null)
			{
				xamPager = (this._scrollInfo.ScrollOwner as global::Infragistics.Windows.Controls.XamPager);
				if (xamPager != null && xamPager.ScrollInfoInternal == this._scrollInfo)
				{
					xamPager.ScrollInfoInternal = null;
				}
				this._scrollInfo.ScrollOwner = null;
				this._scrollInfo = null;
				this._scrollDataInfo = null;
			}
		}

		// Token: 0x060012FE RID: 4862 RVA: 0x00045609 File Offset: 0x00043809
		internal static bool AreClose(double value1, double value2)
		{
			return value1 == value2 || global::System.Math.Abs(value1 - value2) < 1E-10;
		}

		// Token: 0x060012FF RID: 4863 RVA: 0x00045624 File Offset: 0x00043824
		internal bool IsDescendantInView(global::System.Windows.DependencyObject d)
		{
			bool result = false;
			global::System.Windows.UIElement uielement = d as global::System.Windows.UIElement;
			if (uielement == null && d is global::System.Windows.ContentElement)
			{
				uielement = (global::Infragistics.Windows.Utilities.GetAncestorFromType(d, typeof(global::System.Windows.UIElement), true) as global::System.Windows.UIElement);
			}
			if (uielement != null && uielement.IsDescendantOf(this))
			{
				global::System.Windows.Media.GeneralTransform generalTransform = uielement.TransformToAncestor(this);
				global::System.Windows.Rect rect = generalTransform.TransformBounds(new global::System.Windows.Rect(uielement.RenderSize));
				global::System.Windows.Rect rect2 = new global::System.Windows.Rect(base.RenderSize);
				this.AdjustRect(ref rect2, global::Infragistics.Windows.Controls.PagerScrollDirection.Left);
				this.AdjustRect(ref rect2, global::Infragistics.Windows.Controls.PagerScrollDirection.Right);
				this.AdjustRect(ref rect2, global::Infragistics.Windows.Controls.PagerScrollDirection.Up);
				this.AdjustRect(ref rect2, global::Infragistics.Windows.Controls.PagerScrollDirection.Down);
				result = !global::System.Windows.Rect.Intersect(rect, rect2).Size.IsEmpty;
			}
			return result;
		}

		// Token: 0x06001300 RID: 4864 RVA: 0x000456D8 File Offset: 0x000438D8
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			if (this.IsScrollClient)
			{
				this.ScrollDataInfo.VerifyScrollData(finalSize, this.ScrollDataInfo._extent);
			}
			global::System.Windows.UIElement uielement = (this.VisualChildrenCount > 0) ? (this.GetVisualChild(0) as global::System.Windows.UIElement) : null;
			if (uielement != null)
			{
				global::System.Windows.Rect finalRect = new global::System.Windows.Rect(uielement.DesiredSize);
				if (this.IsScrollClient)
				{
					finalRect.Location = new global::System.Windows.Point(-this.ScrollDataInfo._offset.X, -this.ScrollDataInfo._offset.Y);
				}
				if (finalSize.Width > finalRect.Width)
				{
					finalRect.Width = finalSize.Width;
				}
				if (finalSize.Height > finalRect.Height)
				{
					finalRect.Height = finalSize.Height;
				}
				uielement.Arrange(finalRect);
			}
			return finalSize;
		}

		// Token: 0x06001301 RID: 4865 RVA: 0x000457AC File Offset: 0x000439AC
		protected override global::System.Windows.Media.Geometry GetLayoutClip(global::System.Windows.Size layoutSlotSize)
		{
			global::System.Windows.Controls.Primitives.IScrollInfo scrollInfo = this._scrollInfo;
			bool flag = scrollInfo != null && scrollInfo.CanHorizontallyScroll;
			bool flag2 = scrollInfo != null && scrollInfo.CanVerticallyScroll;
			global::System.Windows.Media.Geometry geometry;
			if (flag || flag2)
			{
				global::System.Windows.Rect rect = new global::System.Windows.Rect(base.RenderSize);
				bool? clipContentVertically = this.ClipContentVertically;
				bool flag3;
				if (clipContentVertically != null)
				{
					flag3 = clipContentVertically.Value;
				}
				else
				{
					flag3 = (flag2 && scrollInfo.ViewportHeight < scrollInfo.ExtentHeight && !global::Infragistics.Windows.Controls.PagerContentPresenter.AreClose(scrollInfo.ViewportHeight, scrollInfo.ExtentHeight));
				}
				if (!flag3)
				{
					rect.Y -= 100.0;
					rect.Height += 200.0;
				}
				else
				{
					this.AdjustRect(ref rect, global::Infragistics.Windows.Controls.PagerScrollDirection.Up);
					this.AdjustRect(ref rect, global::Infragistics.Windows.Controls.PagerScrollDirection.Down);
				}
				bool? clipContentHorizontally = this.ClipContentHorizontally;
				bool flag4;
				if (clipContentHorizontally != null)
				{
					flag4 = clipContentHorizontally.Value;
				}
				else
				{
					flag4 = (flag && scrollInfo.ViewportWidth < scrollInfo.ExtentWidth && !global::Infragistics.Windows.Controls.PagerContentPresenter.AreClose(scrollInfo.ViewportWidth, scrollInfo.ExtentWidth));
				}
				if (!flag4)
				{
					rect.X -= 100.0;
					rect.Width += 200.0;
				}
				else
				{
					this.AdjustRect(ref rect, global::Infragistics.Windows.Controls.PagerScrollDirection.Left);
					this.AdjustRect(ref rect, global::Infragistics.Windows.Controls.PagerScrollDirection.Right);
				}
				geometry = new global::System.Windows.Media.RectangleGeometry(rect);
				geometry.Freeze();
			}
			else
			{
				geometry = null;
			}
			return geometry;
		}

		// Token: 0x06001302 RID: 4866 RVA: 0x00045920 File Offset: 0x00043B20
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			global::System.Windows.Size size = global::System.Windows.Size.Empty;
			if (this.VisualChildrenCount > 0)
			{
				global::System.Windows.Size constraint = availableSize;
				if (this.IsScrollClient)
				{
					if (this.ScrollDataInfo._canHorizontallyScroll)
					{
						constraint.Width = double.PositiveInfinity;
					}
					if (this.ScrollDataInfo._canVerticallyScroll)
					{
						constraint.Height = double.PositiveInfinity;
					}
				}
				size = base.MeasureOverride(constraint);
			}
			if (this.IsScrollClient)
			{
				this.ScrollDataInfo.VerifyScrollData(availableSize, size);
			}
			if (availableSize.Width < size.Width)
			{
				size.Width = availableSize.Width;
			}
			if (availableSize.Height < size.Height)
			{
				size.Height = availableSize.Height;
			}
			return size;
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x000459DA File Offset: 0x00043BDA
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this.VerifyScrollInfo();
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06001304 RID: 4868 RVA: 0x000459E8 File Offset: 0x00043BE8
		// (set) Token: 0x06001305 RID: 4869 RVA: 0x000459FF File Offset: 0x00043BFF
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

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06001306 RID: 4870 RVA: 0x00045A29 File Offset: 0x00043C29
		// (set) Token: 0x06001307 RID: 4871 RVA: 0x00045A40 File Offset: 0x00043C40
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

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06001308 RID: 4872 RVA: 0x00045A6A File Offset: 0x00043C6A
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

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06001309 RID: 4873 RVA: 0x00045A8E File Offset: 0x00043C8E
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

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x0600130A RID: 4874 RVA: 0x00045AB2 File Offset: 0x00043CB2
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

		// Token: 0x0600130B RID: 4875 RVA: 0x00045AD6 File Offset: 0x00043CD6
		public void LineDown()
		{
			if (this.IsScrollClient)
			{
				this.SetVerticalOffset(this.ScrollDataInfo._offset.Y + 16.0);
			}
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x00045B00 File Offset: 0x00043D00
		public void LineLeft()
		{
			if (this.IsScrollClient)
			{
				this.SetHorizontalOffset(this.ScrollDataInfo._offset.X - 16.0);
			}
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x00045B2A File Offset: 0x00043D2A
		public void LineRight()
		{
			if (this.IsScrollClient)
			{
				this.SetHorizontalOffset(this.ScrollDataInfo._offset.X + 16.0);
			}
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x00045B54 File Offset: 0x00043D54
		public void LineUp()
		{
			if (this.IsScrollClient)
			{
				this.SetVerticalOffset(this.ScrollDataInfo._offset.Y - 16.0);
			}
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x00045B80 File Offset: 0x00043D80
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
				this.AdjustRect(ref rect2, global::Infragistics.Windows.Controls.PagerScrollDirection.Left);
				this.AdjustRect(ref rect2, global::Infragistics.Windows.Controls.PagerScrollDirection.Right);
				this.AdjustRect(ref rect2, global::Infragistics.Windows.Controls.PagerScrollDirection.Up);
				this.AdjustRect(ref rect2, global::Infragistics.Windows.Controls.PagerScrollDirection.Down);
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

		// Token: 0x06001310 RID: 4880 RVA: 0x00045D37 File Offset: 0x00043F37
		public void MouseWheelDown()
		{
			if (this.IsScrollClient)
			{
				this.SetVerticalOffset(this.ScrollDataInfo._offset.Y + (double)global::System.Windows.SystemParameters.WheelScrollLines * 16.0);
			}
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x00045D68 File Offset: 0x00043F68
		public void MouseWheelLeft()
		{
			if (this.IsScrollClient)
			{
				this.SetHorizontalOffset(this.ScrollDataInfo._offset.X - (double)global::System.Windows.SystemParameters.WheelScrollLines * 16.0);
			}
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x00045D99 File Offset: 0x00043F99
		public void MouseWheelRight()
		{
			if (this.IsScrollClient)
			{
				this.SetHorizontalOffset(this.ScrollDataInfo._offset.X + (double)global::System.Windows.SystemParameters.WheelScrollLines * 16.0);
			}
		}

		// Token: 0x06001313 RID: 4883 RVA: 0x00045DCA File Offset: 0x00043FCA
		public void MouseWheelUp()
		{
			if (this.IsScrollClient)
			{
				this.SetVerticalOffset(this.ScrollDataInfo._offset.Y - (double)global::System.Windows.SystemParameters.WheelScrollLines * 16.0);
			}
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x00045DFB File Offset: 0x00043FFB
		public void PageDown()
		{
			if (this.IsScrollClient)
			{
				this.SetVerticalOffset(this.ScrollDataInfo._offset.Y + this.ScrollDataInfo._viewport.Height);
			}
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x00045E2C File Offset: 0x0004402C
		public void PageLeft()
		{
			if (this.IsScrollClient)
			{
				this.SetVerticalOffset(this.ScrollDataInfo._offset.X - this.ScrollDataInfo._viewport.Width);
			}
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x00045E5D File Offset: 0x0004405D
		public void PageRight()
		{
			if (this.IsScrollClient)
			{
				this.SetVerticalOffset(this.ScrollDataInfo._offset.X + this.ScrollDataInfo._viewport.Width);
			}
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x00045E8E File Offset: 0x0004408E
		public void PageUp()
		{
			if (this.IsScrollClient)
			{
				this.SetVerticalOffset(this.ScrollDataInfo._offset.Y - this.ScrollDataInfo._viewport.Height);
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06001318 RID: 4888 RVA: 0x00045EBF File Offset: 0x000440BF
		// (set) Token: 0x06001319 RID: 4889 RVA: 0x00045ED6 File Offset: 0x000440D6
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

		// Token: 0x0600131A RID: 4890 RVA: 0x00045EEC File Offset: 0x000440EC
		public void SetHorizontalOffset(double offset)
		{
			if (this.IsScrollClient)
			{
				global::Infragistics.Windows.Controls.PagerContentPresenter.EnsureIsANumber(offset);
				offset = global::System.Math.Max(offset, 0.0);
				if (!global::Infragistics.Windows.Controls.PagerContentPresenter.AreClose(offset, this.ScrollDataInfo._offset.X))
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

		// Token: 0x0600131B RID: 4891 RVA: 0x00045F64 File Offset: 0x00044164
		public void SetVerticalOffset(double offset)
		{
			if (this.IsScrollClient)
			{
				global::Infragistics.Windows.Controls.PagerContentPresenter.EnsureIsANumber(offset);
				offset = global::System.Math.Max(offset, 0.0);
				if (!global::Infragistics.Windows.Controls.PagerContentPresenter.AreClose(offset, this.ScrollDataInfo._offset.Y))
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

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x0600131C RID: 4892 RVA: 0x00045FDC File Offset: 0x000441DC
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

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x0600131D RID: 4893 RVA: 0x00046000 File Offset: 0x00044200
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

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x0600131E RID: 4894 RVA: 0x00046024 File Offset: 0x00044224
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

		// Token: 0x040009D2 RID: 2514
		internal const double LineOffset = 16.0;

		// Token: 0x040009D3 RID: 2515
		private global::Infragistics.Windows.Controls.PagerContentPresenter.ScrollData _scrollDataInfo;

		// Token: 0x040009D4 RID: 2516
		private global::System.Windows.Controls.Primitives.IScrollInfo _scrollInfo;

		// Token: 0x040009D5 RID: 2517
		public static readonly global::System.Windows.DependencyProperty CanContentScrollProperty = global::System.Windows.Controls.ScrollViewer.CanContentScrollProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.PagerContentPresenter), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.PagerContentPresenter.OnCanContentScrollChanged)));

		// Token: 0x040009D6 RID: 2518
		public static readonly global::System.Windows.DependencyProperty ClipContentHorizontallyProperty = global::System.Windows.DependencyProperty.Register("ClipContentHorizontally", typeof(bool?), typeof(global::Infragistics.Windows.Controls.PagerContentPresenter), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));

		// Token: 0x040009D7 RID: 2519
		public static readonly global::System.Windows.DependencyProperty ClipContentVerticallyProperty = global::System.Windows.DependencyProperty.Register("ClipContentVertically", typeof(bool?), typeof(global::Infragistics.Windows.Controls.PagerContentPresenter), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));

		// Token: 0x040009D8 RID: 2520
		public static readonly global::System.Windows.DependencyProperty ReserveSpaceForScrollButtonsProperty = global::System.Windows.DependencyProperty.Register("ReserveSpaceForScrollButtons", typeof(bool), typeof(global::Infragistics.Windows.Controls.PagerContentPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.PagerContentPresenter.OnReserveSpaceForScrollButtonsChanged)));

		// Token: 0x040009D9 RID: 2521
		private bool _cachedReserveSpaceForScrollButtons = true;

		// Token: 0x020001F9 RID: 505
		internal class ScrollData
		{
			// Token: 0x06001320 RID: 4896 RVA: 0x0004610C File Offset: 0x0004430C
			internal void Reset()
			{
				this._offset = default(global::System.Windows.Vector);
				this._extent = default(global::System.Windows.Size);
				this._viewport = default(global::System.Windows.Size);
			}

			// Token: 0x06001321 RID: 4897 RVA: 0x00046134 File Offset: 0x00044334
			internal void VerifyScrollData(global::System.Windows.Size viewPort, global::System.Windows.Size extent)
			{
				if (double.IsInfinity(viewPort.Width))
				{
					viewPort.Width = extent.Width;
				}
				if (double.IsInfinity(viewPort.Height))
				{
					viewPort.Height = extent.Height;
				}
				bool flag = !global::Infragistics.Windows.Controls.PagerContentPresenter.AreClose(this._viewport.Width, viewPort.Width) || !global::Infragistics.Windows.Controls.PagerContentPresenter.AreClose(this._viewport.Height, viewPort.Height) || !global::Infragistics.Windows.Controls.PagerContentPresenter.AreClose(this._extent.Width, extent.Width) || !global::Infragistics.Windows.Controls.PagerContentPresenter.AreClose(this._extent.Width, extent.Width);
				this._viewport = viewPort;
				this._extent = extent;
				flag |= this.VerifyOffset();
				if (this._scrollOwner != null && flag)
				{
					this._scrollOwner.InvalidateScrollInfo();
				}
			}

			// Token: 0x06001322 RID: 4898 RVA: 0x00046210 File Offset: 0x00044410
			private bool VerifyOffset()
			{
				double x = global::System.Math.Max(global::System.Math.Min(this._offset.X, this._extent.Width - this._viewport.Width), 0.0);
				double y = global::System.Math.Max(global::System.Math.Min(this._offset.Y, this._extent.Height - this._viewport.Height), 0.0);
				global::System.Windows.Vector offset = this._offset;
				this._offset = new global::System.Windows.Vector(x, y);
				return !global::Infragistics.Windows.Controls.PagerContentPresenter.AreClose(this._offset.X, offset.X) || !global::Infragistics.Windows.Controls.PagerContentPresenter.AreClose(this._offset.Y, offset.Y);
			}

			// Token: 0x040009DA RID: 2522
			internal global::System.Windows.Controls.ScrollViewer _scrollOwner;

			// Token: 0x040009DB RID: 2523
			internal global::System.Windows.Size _extent = default(global::System.Windows.Size);

			// Token: 0x040009DC RID: 2524
			internal global::System.Windows.Size _viewport = default(global::System.Windows.Size);

			// Token: 0x040009DD RID: 2525
			internal global::System.Windows.Vector _offset = default(global::System.Windows.Vector);

			// Token: 0x040009DE RID: 2526
			internal bool _canHorizontallyScroll;

			// Token: 0x040009DF RID: 2527
			internal bool _canVerticallyScroll;
		}
	}
}
