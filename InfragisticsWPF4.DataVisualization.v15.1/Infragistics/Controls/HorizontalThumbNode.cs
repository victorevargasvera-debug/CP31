using System;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Controls
{
	// Token: 0x02000023 RID: 35
	internal class HorizontalThumbNode : global::Infragistics.Controls.ThumbNode
	{
		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x000098F4 File Offset: 0x00007AF4
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x000098FC File Offset: 0x00007AFC
		public global::Infragistics.ShapeElement ScaleLeftElement
		{
			get
			{
				return this._scaleLeftElement;
			}
			set
			{
				this._scaleLeftElement = value;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x00009905 File Offset: 0x00007B05
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x0000990D File Offset: 0x00007B0D
		public global::Infragistics.ShapeElement ScaleRightElement
		{
			get
			{
				return this._scaleRightElement;
			}
			set
			{
				this._scaleRightElement = value;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001DA RID: 474 RVA: 0x00009916 File Offset: 0x00007B16
		// (set) Token: 0x060001DB RID: 475 RVA: 0x0000991E File Offset: 0x00007B1E
		public global::Infragistics.ShapeElement ThumbBackground
		{
			get
			{
				return this._thumbBackground;
			}
			set
			{
				this._thumbBackground = value;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001DC RID: 476 RVA: 0x00009927 File Offset: 0x00007B27
		// (set) Token: 0x060001DD RID: 477 RVA: 0x0000992F File Offset: 0x00007B2F
		internal bool IsLeft
		{
			get
			{
				return this._isLeft;
			}
			set
			{
				this._isLeft = value;
			}
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00009938 File Offset: 0x00007B38
		public override void ArrangeChildren(global::System.Windows.Rect oldBounds, global::System.Windows.Rect newBounds)
		{
			double x = newBounds.X + base.Zoombar.LeftScaleWidth / 2.0;
			double num = newBounds.Width - base.Zoombar.LeftScaleWidth / 2.0 - base.Zoombar.RightScaleWidth / 2.0;
			if (num < 0.0)
			{
				num = 0.0;
			}
			this.ThumbBackground.Bounds = new global::System.Windows.Rect(x, newBounds.Y, num, newBounds.Height);
			double x2 = newBounds.Right - base.Zoombar.RightScaleWidth;
			this.ScaleLeftElement.Bounds = new global::System.Windows.Rect(newBounds.X, newBounds.Y, base.Zoombar.LeftScaleWidth, newBounds.Height);
			this.ScaleRightElement.Bounds = new global::System.Windows.Rect(x2, newBounds.Y, base.Zoombar.RightScaleWidth, newBounds.Height);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00009A3B File Offset: 0x00007C3B
		public override global::Infragistics.ShapeElement HitResizeThumb(global::System.Windows.Point point)
		{
			if (this.ScaleLeftElement.HitTest(point))
			{
				this.IsLeft = true;
				return this.ScaleLeftElement;
			}
			if (this.ScaleRightElement.HitTest(point))
			{
				this.IsLeft = false;
				return this.ScaleRightElement;
			}
			return null;
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00009A78 File Offset: 0x00007C78
		public override void DoMove(global::System.Windows.Point pt)
		{
			double num = pt.X;
			double num2 = base.Bounds.Left + num;
			double num3 = base.Bounds.Right + num;
			double num4 = base.Zoombar.ActualWidth - base.Zoombar.RightOffset;
			double leftOffset = base.Zoombar.LeftOffset;
			if (num2 < leftOffset)
			{
				num += leftOffset - num2;
			}
			if (num3 > num4)
			{
				num -= num3 - num4;
			}
			num2 = base.Bounds.Left + num;
			num3 = base.Bounds.Right + num;
			double minimum = base.Zoombar.CalculateValue(new global::System.Windows.Point(num2, 0.0));
			double maximum = base.Zoombar.CalculateValue(new global::System.Windows.Point(num3, 0.0));
			base.Zoombar.TempRange.Minimum = minimum;
			base.Zoombar.TempRange.Maximum = maximum;
			base.Zoombar.UpdateTempThumb();
			base.Zoombar.RaiseZoomChangingEvent();
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00009B84 File Offset: 0x00007D84
		public override void DoResize(global::System.Windows.Point offset)
		{
			double num = base.Bounds.Left;
			double num2 = base.Bounds.Right;
			double num3 = base.Zoombar.LeftScaleWidth + base.Zoombar.RightScaleWidth;
			if (this.IsLeft)
			{
				num += offset.X;
				if (num < base.Zoombar.LeftOffset)
				{
					num = base.Zoombar.LeftOffset;
				}
				double num4 = num2 - num3;
				if (num > num4)
				{
					num = num4;
				}
			}
			else
			{
				num2 += offset.X;
				double num5 = base.Zoombar.ActualWidth - base.Zoombar.RightOffset;
				if (num2 > num5)
				{
					num2 = num5;
				}
				double num6 = num + num3;
				if (num2 < num6)
				{
					num2 = num6;
				}
			}
			double minimum = base.Zoombar.CalculateValue(new global::System.Windows.Point(num, 0.0));
			double maximum = base.Zoombar.CalculateValue(new global::System.Windows.Point(num2, 0.0));
			base.Zoombar.TempRange.Minimum = minimum;
			base.Zoombar.TempRange.Maximum = maximum;
			base.Zoombar.UpdateTempThumb();
			base.Zoombar.RaiseZoomChangingEvent();
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00009CAC File Offset: 0x00007EAC
		protected override void ChangeVisualState(string newState)
		{
			foreach (global::System.Windows.FrameworkElement frameworkElement in this.ScaleLeftElement.FrameworkElements)
			{
				global::System.Windows.Controls.Control control = frameworkElement as global::System.Windows.Controls.Control;
				if (control != null)
				{
					global::System.Windows.VisualStateManager.GoToState(control, newState, true);
				}
			}
			foreach (global::System.Windows.FrameworkElement frameworkElement2 in this.ScaleRightElement.FrameworkElements)
			{
				global::System.Windows.Controls.Control control2 = frameworkElement2 as global::System.Windows.Controls.Control;
				if (control2 != null)
				{
					global::System.Windows.VisualStateManager.GoToState(control2, newState, true);
				}
			}
			foreach (global::System.Windows.FrameworkElement frameworkElement3 in this.ThumbBackground.FrameworkElements)
			{
				global::System.Windows.Controls.Control control3 = frameworkElement3 as global::System.Windows.Controls.Control;
				if (control3 != null)
				{
					global::System.Windows.VisualStateManager.GoToState(control3, newState, true);
				}
			}
		}

		// Token: 0x0400008E RID: 142
		private global::Infragistics.ShapeElement _scaleLeftElement;

		// Token: 0x0400008F RID: 143
		private global::Infragistics.ShapeElement _scaleRightElement;

		// Token: 0x04000090 RID: 144
		private global::Infragistics.ShapeElement _thumbBackground;

		// Token: 0x04000091 RID: 145
		internal bool _isLeft;
	}
}
