using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000228 RID: 552
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class PagerContentPresenter : global::System.Windows.Controls.ContentPresenter, global::System.Windows.Controls.Primitives.IScrollInfo
	{
		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x060014CC RID: 5324 RVA: 0x0004AF7F File Offset: 0x0004917F
		// (set) Token: 0x060014CD RID: 5325 RVA: 0x0004AF91 File Offset: 0x00049191
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

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x060014CE RID: 5326 RVA: 0x0004AFA4 File Offset: 0x000491A4
		// (set) Token: 0x060014CF RID: 5327 RVA: 0x0004AFB6 File Offset: 0x000491B6
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

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x060014D0 RID: 5328 RVA: 0x0004AFC9 File Offset: 0x000491C9
		// (set) Token: 0x060014D1 RID: 5329 RVA: 0x0004AFDB File Offset: 0x000491DB
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

		// Token: 0x060014D2 RID: 5330 RVA: 0x0004AFF0 File Offset: 0x000491F0
		private static void OnReserveSpaceForScrollButtonsChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.PagerContentPresenter pagerContentPresenter = target as global::Infragistics.Windows.Controls.PagerContentPresenter;
			if (pagerContentPresenter != null)
			{
				pagerContentPresenter._cachedReserveSpaceForScrollButtons = (bool)e.NewValue;
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x060014D3 RID: 5331 RVA: 0x0004B019 File Offset: 0x00049219
		// (set) Token: 0x060014D4 RID: 5332 RVA: 0x0004B021 File Offset: 0x00049221
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

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x060014D5 RID: 5333 RVA: 0x0004B034 File Offset: 0x00049234
		private bool IsScrollClient
		{
			get
			{
				return this._scrollInfo == this;
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x060014D6 RID: 5334 RVA: 0x0004B03F File Offset: 0x0004923F
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

		// Token: 0x060014D7 RID: 5335 RVA: 0x0004B05C File Offset: 0x0004925C
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

		// Token: 0x060014D8 RID: 5336 RVA: 0x0004B1BC File Offset: 0x000493BC
		internal static void EnsureIsANumber(double number)
		{
			if (double.IsNaN(number))
			{
				throw new global::System.ArgumentOutOfRangeException("offset", number, global::SR.GetString("LE_ValueCannotBeNan"));
			}
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x0004B1E4 File Offset: 0x000493E4
		private static void OnCanContentScrollChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.PagerContentPresenter pagerContentPresenter = d as global::Infragistics.Windows.Controls.PagerContentPresenter;
			if (pagerContentPresenter != null && pagerContentPresenter._scrollDataInfo != null)
			{
				pagerContentPresenter.VerifyScrollInfo();
				pagerContentPresenter.InvalidateMeasure();
			}
		}

		// Token: 0x060014DA RID: 5338 RVA: 0x0004B210 File Offset: 0x00049410
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

		// Token: 0x060014DB RID: 5339 RVA: 0x0004B319 File Offset: 0x00049519
		internal static bool AreClose(double value1, double value2)
		{
			return value1 == value2 || global::System.Math.Abs(value1 - value2) < 1E-10;
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x0004B334 File Offset: 0x00049534
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

		// Token: 0x060014DD RID: 5341 RVA: 0x0004B3E8 File Offset: 0x000495E8
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

		// Token: 0x060014DE RID: 5342 RVA: 0x0004B4BC File Offset: 0x000496BC
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

		// Token: 0x060014DF RID: 5343 RVA: 0x0004B630 File Offset: 0x00049830
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

		// Token: 0x060014E0 RID: 5344 RVA: 0x0004B6EA File Offset: 0x000498EA
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this.VerifyScrollInfo();
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x060014E1 RID: 5345 RVA: 0x0004B6F8 File Offset: 0x000498F8
		// (set) Token: 0x060014E2 RID: 5346 RVA: 0x0004B70F File Offset: 0x0004990F
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

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x060014E3 RID: 5347 RVA: 0x0004B739 File Offset: 0x00049939
		// (set) Token: 0x060014E4 RID: 5348 RVA: 0x0004B750 File Offset: 0x00049950
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

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x060014E5 RID: 5349 RVA: 0x0004B77A File Offset: 0x0004997A
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

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x060014E6 RID: 5350 RVA: 0x0004B79E File Offset: 0x0004999E
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

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x060014E7 RID: 5351 RVA: 0x0004B7C2 File Offset: 0x000499C2
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

		// Token: 0x060014E8 RID: 5352 RVA: 0x0004B7E6 File Offset: 0x000499E6
		public void LineDown()
		{
			if (this.IsScrollClient)
			{
				this.SetVerticalOffset(this.ScrollDataInfo._offset.Y + 16.0);
			}
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x0004B810 File Offset: 0x00049A10
		public void LineLeft()
		{
			if (this.IsScrollClient)
			{
				this.SetHorizontalOffset(this.ScrollDataInfo._offset.X - 16.0);
			}
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x0004B83A File Offset: 0x00049A3A
		public void LineRight()
		{
			if (this.IsScrollClient)
			{
				this.SetHorizontalOffset(this.ScrollDataInfo._offset.X + 16.0);
			}
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x0004B864 File Offset: 0x00049A64
		public void LineUp()
		{
			if (this.IsScrollClient)
			{
				this.SetVerticalOffset(this.ScrollDataInfo._offset.Y - 16.0);
			}
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x0004B890 File Offset: 0x00049A90
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

		// Token: 0x060014ED RID: 5357 RVA: 0x0004BA47 File Offset: 0x00049C47
		public void MouseWheelDown()
		{
			if (this.IsScrollClient)
			{
				this.SetVerticalOffset(this.ScrollDataInfo._offset.Y + (double)global::System.Windows.SystemParameters.WheelScrollLines * 16.0);
			}
		}

		// Token: 0x060014EE RID: 5358 RVA: 0x0004BA78 File Offset: 0x00049C78
		public void MouseWheelLeft()
		{
			if (this.IsScrollClient)
			{
				this.SetHorizontalOffset(this.ScrollDataInfo._offset.X - (double)global::System.Windows.SystemParameters.WheelScrollLines * 16.0);
			}
		}

		// Token: 0x060014EF RID: 5359 RVA: 0x0004BAA9 File Offset: 0x00049CA9
		public void MouseWheelRight()
		{
			if (this.IsScrollClient)
			{
				this.SetHorizontalOffset(this.ScrollDataInfo._offset.X + (double)global::System.Windows.SystemParameters.WheelScrollLines * 16.0);
			}
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x0004BADA File Offset: 0x00049CDA
		public void MouseWheelUp()
		{
			if (this.IsScrollClient)
			{
				this.SetVerticalOffset(this.ScrollDataInfo._offset.Y - (double)global::System.Windows.SystemParameters.WheelScrollLines * 16.0);
			}
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x0004BB0B File Offset: 0x00049D0B
		public void PageDown()
		{
			if (this.IsScrollClient)
			{
				this.SetVerticalOffset(this.ScrollDataInfo._offset.Y + this.ScrollDataInfo._viewport.Height);
			}
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x0004BB3C File Offset: 0x00049D3C
		public void PageLeft()
		{
			if (this.IsScrollClient)
			{
				this.SetVerticalOffset(this.ScrollDataInfo._offset.X - this.ScrollDataInfo._viewport.Width);
			}
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x0004BB6D File Offset: 0x00049D6D
		public void PageRight()
		{
			if (this.IsScrollClient)
			{
				this.SetVerticalOffset(this.ScrollDataInfo._offset.X + this.ScrollDataInfo._viewport.Width);
			}
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x0004BB9E File Offset: 0x00049D9E
		public void PageUp()
		{
			if (this.IsScrollClient)
			{
				this.SetVerticalOffset(this.ScrollDataInfo._offset.Y - this.ScrollDataInfo._viewport.Height);
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x060014F5 RID: 5365 RVA: 0x0004BBCF File Offset: 0x00049DCF
		// (set) Token: 0x060014F6 RID: 5366 RVA: 0x0004BBE6 File Offset: 0x00049DE6
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

		// Token: 0x060014F7 RID: 5367 RVA: 0x0004BBFC File Offset: 0x00049DFC
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

		// Token: 0x060014F8 RID: 5368 RVA: 0x0004BC74 File Offset: 0x00049E74
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

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x060014F9 RID: 5369 RVA: 0x0004BCEC File Offset: 0x00049EEC
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

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x060014FA RID: 5370 RVA: 0x0004BD10 File Offset: 0x00049F10
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

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x060014FB RID: 5371 RVA: 0x0004BD34 File Offset: 0x00049F34
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

		// Token: 0x04000B1D RID: 2845
		internal const double LineOffset = 16.0;

		// Token: 0x04000B1E RID: 2846
		private global::Infragistics.Windows.Controls.PagerContentPresenter.ScrollData _scrollDataInfo;

		// Token: 0x04000B1F RID: 2847
		private global::System.Windows.Controls.Primitives.IScrollInfo _scrollInfo;

		// Token: 0x04000B20 RID: 2848
		public static readonly global::System.Windows.DependencyProperty CanContentScrollProperty = global::System.Windows.Controls.ScrollViewer.CanContentScrollProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.PagerContentPresenter), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.PagerContentPresenter.OnCanContentScrollChanged)));

		// Token: 0x04000B21 RID: 2849
		public static readonly global::System.Windows.DependencyProperty ClipContentHorizontallyProperty = global::System.Windows.DependencyProperty.Register("ClipContentHorizontally", typeof(bool?), typeof(global::Infragistics.Windows.Controls.PagerContentPresenter), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));

		// Token: 0x04000B22 RID: 2850
		public static readonly global::System.Windows.DependencyProperty ClipContentVerticallyProperty = global::System.Windows.DependencyProperty.Register("ClipContentVertically", typeof(bool?), typeof(global::Infragistics.Windows.Controls.PagerContentPresenter), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));

		// Token: 0x04000B23 RID: 2851
		public static readonly global::System.Windows.DependencyProperty ReserveSpaceForScrollButtonsProperty = global::System.Windows.DependencyProperty.Register("ReserveSpaceForScrollButtons", typeof(bool), typeof(global::Infragistics.Windows.Controls.PagerContentPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.PagerContentPresenter.OnReserveSpaceForScrollButtonsChanged)));

		// Token: 0x04000B24 RID: 2852
		private bool _cachedReserveSpaceForScrollButtons = true;

		// Token: 0x02000229 RID: 553
		internal class ScrollData
		{
			// Token: 0x060014FD RID: 5373 RVA: 0x0004BE1C File Offset: 0x0004A01C
			internal void Reset()
			{
				this._offset = default(global::System.Windows.Vector);
				this._extent = default(global::System.Windows.Size);
				this._viewport = default(global::System.Windows.Size);
			}

			// Token: 0x060014FE RID: 5374 RVA: 0x0004BE44 File Offset: 0x0004A044
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

			// Token: 0x060014FF RID: 5375 RVA: 0x0004BF20 File Offset: 0x0004A120
			private bool VerifyOffset()
			{
				double x = global::System.Math.Max(global::System.Math.Min(this._offset.X, this._extent.Width - this._viewport.Width), 0.0);
				double y = global::System.Math.Max(global::System.Math.Min(this._offset.Y, this._extent.Height - this._viewport.Height), 0.0);
				global::System.Windows.Vector offset = this._offset;
				this._offset = new global::System.Windows.Vector(x, y);
				return !global::Infragistics.Windows.Controls.PagerContentPresenter.AreClose(this._offset.X, offset.X) || !global::Infragistics.Windows.Controls.PagerContentPresenter.AreClose(this._offset.Y, offset.Y);
			}

			// Token: 0x04000B25 RID: 2853
			internal global::System.Windows.Controls.ScrollViewer _scrollOwner;

			// Token: 0x04000B26 RID: 2854
			internal global::System.Windows.Size _extent = default(global::System.Windows.Size);

			// Token: 0x04000B27 RID: 2855
			internal global::System.Windows.Size _viewport = default(global::System.Windows.Size);

			// Token: 0x04000B28 RID: 2856
			internal global::System.Windows.Vector _offset = default(global::System.Windows.Vector);

			// Token: 0x04000B29 RID: 2857
			internal bool _canHorizontallyScroll;

			// Token: 0x04000B2A RID: 2858
			internal bool _canVerticallyScroll;
		}
	}
}
