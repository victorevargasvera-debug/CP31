using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace Infragistics.Controls.Primitives
{
	// Token: 0x020000C0 RID: 192
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class PopupResizer : global::System.Windows.Controls.Control
	{
		// Token: 0x06000725 RID: 1829 RVA: 0x00019048 File Offset: 0x00017248
		static PopupResizer()
		{
			global::System.Windows.Style style = new global::System.Windows.Style();
			style.Seal();
			global::System.Windows.FrameworkElement.FocusVisualStyleProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Primitives.PopupResizer), new global::System.Windows.FrameworkPropertyMetadata(style));
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x0001911D File Offset: 0x0001731D
		public PopupResizer()
		{
			base.DefaultStyleKey = typeof(global::Infragistics.Controls.Primitives.PopupResizer);
			base.IsTabStop = false;
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000727 RID: 1831 RVA: 0x0001913C File Offset: 0x0001733C
		// (set) Token: 0x06000728 RID: 1832 RVA: 0x0001914E File Offset: 0x0001734E
		public global::System.Windows.FrameworkElement ResizeElement
		{
			get
			{
				return (global::System.Windows.FrameworkElement)base.GetValue(global::Infragistics.Controls.Primitives.PopupResizer.ResizeElementProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Primitives.PopupResizer.ResizeElementProperty, value);
			}
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x0001915C File Offset: 0x0001735C
		private static void ResizeElementChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x0600072A RID: 1834 RVA: 0x0001915E File Offset: 0x0001735E
		// (set) Token: 0x0600072B RID: 1835 RVA: 0x00019170 File Offset: 0x00017370
		public global::System.Windows.Controls.Primitives.Popup Popup
		{
			get
			{
				return (global::System.Windows.Controls.Primitives.Popup)base.GetValue(global::Infragistics.Controls.Primitives.PopupResizer.PopupProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Primitives.PopupResizer.PopupProperty, value);
			}
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x0001917E File Offset: 0x0001737E
		private static void PopupChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x0600072D RID: 1837 RVA: 0x00019180 File Offset: 0x00017380
		// (set) Token: 0x0600072E RID: 1838 RVA: 0x00019192 File Offset: 0x00017392
		public global::Infragistics.Controls.Primitives.ResizerPosition Position
		{
			get
			{
				return (global::Infragistics.Controls.Primitives.ResizerPosition)base.GetValue(global::Infragistics.Controls.Primitives.PopupResizer.PositionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Primitives.PopupResizer.PositionProperty, value);
			}
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x000191A8 File Offset: 0x000173A8
		private static void PositionChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Primitives.PopupResizer popupResizer = (global::Infragistics.Controls.Primitives.PopupResizer)obj;
			popupResizer.EnsureVisualStates();
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x000191C4 File Offset: 0x000173C4
		protected virtual void EndResize(bool cancel)
		{
			this._isMouseDown = false;
			this._isResizing = false;
			this._resizeElem.ReleaseMouseCapture();
			if (cancel && this.ResizeElement != null)
			{
				this.ResizeElement.Height = this._originalSize.Height;
				this.ResizeElement.Width = this._originalSize.Width;
			}
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x00019224 File Offset: 0x00017424
		protected virtual void EnsureVisualStates()
		{
			bool flag = this.Position == global::Infragistics.Controls.Primitives.ResizerPosition.Above;
			if (flag)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Above", false);
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Below", false);
			}
			if (base.FlowDirection == global::System.Windows.FlowDirection.LeftToRight)
			{
				if (flag)
				{
					global::System.Windows.VisualStateManager.GoToState(this, "AboveLTR", false);
					return;
				}
				global::System.Windows.VisualStateManager.GoToState(this, "LTR", false);
				return;
			}
			else
			{
				if (flag)
				{
					global::System.Windows.VisualStateManager.GoToState(this, "AboveRTL", false);
					return;
				}
				global::System.Windows.VisualStateManager.GoToState(this, "RTL", false);
				return;
			}
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x000192A0 File Offset: 0x000174A0
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			if (this._resizeElem != null)
			{
				this._resizeElem.LostMouseCapture -= this.ResizableElement_LostMouseCapture;
				this._resizeElem.MouseLeftButtonUp -= this.ResizableElement_MouseLeftButtonUp;
				this._resizeElem.MouseLeftButtonDown -= this.ResizableElement_MouseLeftButtonDown;
				this._resizeElem.MouseMove -= this.ResizableElement_MouseMove;
			}
			this._resizeElem = (base.GetTemplateChild("ResizeElem") as global::System.Windows.FrameworkElement);
			if (this._resizeElem != null)
			{
				this._resizeElem.LostMouseCapture += this.ResizableElement_LostMouseCapture;
				this._resizeElem.MouseLeftButtonUp += this.ResizableElement_MouseLeftButtonUp;
				this._resizeElem.MouseLeftButtonDown += this.ResizableElement_MouseLeftButtonDown;
				this._resizeElem.MouseMove += this.ResizableElement_MouseMove;
			}
			this.EnsureVisualStates();
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x00019397 File Offset: 0x00017597
		private void ResizableElement_LostMouseCapture(object sender, global::System.Windows.Input.MouseEventArgs e)
		{
			this.EndResize(false);
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x000193A0 File Offset: 0x000175A0
		private void ResizableElement_MouseLeftButtonUp(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			this.EndResize(false);
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x000193A9 File Offset: 0x000175A9
		private void ResizableElement_MouseLeftButtonDown(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (this.ResizeElement != null)
			{
				this._isMouseDown = ((global::System.Windows.UIElement)sender).CaptureMouse();
				e.Handled = this._isMouseDown;
			}
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x000193D0 File Offset: 0x000175D0
		private void ResizableElement_MouseMove(object sender, global::System.Windows.Input.MouseEventArgs e)
		{
			if (this._isMouseDown)
			{
				if (!this._isResizing)
				{
					double actualHeight = this.ResizeElement.ActualHeight;
					double actualWidth = this.ResizeElement.ActualWidth;
					if (double.IsNaN(actualWidth) || double.IsNaN(actualHeight) || (actualWidth == 0.0 && actualHeight == 0.0))
					{
						return;
					}
					this._isResizing = true;
					this._offsetPoint = e.GetPosition(global::Infragistics.PlatformProxy.GetRootVisual(this.ResizeElement));
					this._originalSize = new global::System.Windows.Size(actualWidth, actualHeight);
					if (this.Popup != null)
					{
						this._originalTop = this.Popup.VerticalOffset;
					}
				}
				global::System.Windows.Point position = e.GetPosition(global::Infragistics.PlatformProxy.GetRootVisual(this.ResizeElement));
				double num = position.X - this._offsetPoint.X;
				double y = position.Y - this._offsetPoint.Y;
				if (base.FlowDirection == global::System.Windows.FlowDirection.RightToLeft)
				{
					num *= -1.0;
				}
				global::System.Windows.Point point = new global::System.Windows.Point(num, y);
				global::System.Windows.Size size = default(global::System.Windows.Size);
				size.Width = global::System.Math.Max(this._originalSize.Width - point.X, base.MinWidth);
				size.Width = global::System.Math.Min(size.Width, base.MaxWidth);
				size.Height = global::System.Math.Max(this._originalSize.Height - point.Y, base.MinHeight);
				size.Height = global::System.Math.Min(size.Height, base.MaxHeight);
				global::System.Windows.Size size2 = default(global::System.Windows.Size);
				size2.Width = global::System.Math.Max(this._originalSize.Width + point.X, base.MinWidth);
				size2.Width = global::System.Math.Min(size2.Width, base.MaxWidth);
				size2.Height = global::System.Math.Max(this._originalSize.Height + point.Y, base.MinHeight);
				size2.Height = global::System.Math.Min(size2.Height, base.MaxHeight);
				point = new global::System.Windows.Point(this._originalSize.Width - size.Width, this._originalSize.Height - size.Height);
				global::System.Windows.Point point2 = default(global::System.Windows.Point);
				this.ResizeElement.Width = size2.Width;
				if (this.Position == global::Infragistics.Controls.Primitives.ResizerPosition.Above)
				{
					if (this.Popup != null)
					{
						if (size.Height != this.ResizeElement.MinHeight)
						{
							point2.Y = this._originalTop + point.Y;
							if (point2.Y == 0.0)
							{
								size.Height = this.ResizeElement.ActualHeight;
							}
							else if (size.Height < this.ResizeElement.MinHeight)
							{
								size.Height = this.ResizeElement.MinHeight;
								double num2 = this.ResizeElement.MinHeight - (this._originalSize.Height - point.Y);
								point2.Y = this._originalTop + point.Y - num2;
							}
						}
						else
						{
							double num3 = this.ResizeElement.MinHeight - (this._originalSize.Height - point.Y);
							point2.Y = this._originalTop + point.Y - num3;
						}
					}
					this.Popup.VerticalOffset = point2.Y;
					this.ResizeElement.Height = size.Height;
					return;
				}
				this.ResizeElement.Height = size2.Height;
			}
		}

		// Token: 0x0400033E RID: 830
		private global::System.Windows.FrameworkElement _resizeElem;

		// Token: 0x0400033F RID: 831
		private bool _isMouseDown;

		// Token: 0x04000340 RID: 832
		private bool _isResizing;

		// Token: 0x04000341 RID: 833
		private global::System.Windows.Point _offsetPoint;

		// Token: 0x04000342 RID: 834
		private global::System.Windows.Size _originalSize;

		// Token: 0x04000343 RID: 835
		private double _originalTop;

		// Token: 0x04000344 RID: 836
		public static readonly global::System.Windows.DependencyProperty ResizeElementProperty = global::System.Windows.DependencyProperty.Register("ResizeElement", typeof(global::System.Windows.FrameworkElement), typeof(global::Infragistics.Controls.Primitives.PopupResizer), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Primitives.PopupResizer.ResizeElementChanged)));

		// Token: 0x04000345 RID: 837
		public static readonly global::System.Windows.DependencyProperty PopupProperty = global::System.Windows.DependencyProperty.Register("Popup", typeof(global::System.Windows.Controls.Primitives.Popup), typeof(global::Infragistics.Controls.Primitives.PopupResizer), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Primitives.PopupResizer.PopupChanged)));

		// Token: 0x04000346 RID: 838
		public static readonly global::System.Windows.DependencyProperty PositionProperty = global::System.Windows.DependencyProperty.Register("Position", typeof(global::Infragistics.Controls.Primitives.ResizerPosition), typeof(global::Infragistics.Controls.Primitives.PopupResizer), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Primitives.ResizerPosition.Below, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Primitives.PopupResizer.PositionChanged)));
	}
}
