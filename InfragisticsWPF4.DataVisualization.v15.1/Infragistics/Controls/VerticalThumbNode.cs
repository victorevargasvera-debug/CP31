using System;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Controls
{
	// Token: 0x02000024 RID: 36
	internal class VerticalThumbNode : global::Infragistics.Controls.ThumbNode
	{
		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x00009DC0 File Offset: 0x00007FC0
		// (set) Token: 0x060001E5 RID: 485 RVA: 0x00009DC8 File Offset: 0x00007FC8
		public global::Infragistics.ShapeElement ScaleTopElement
		{
			get
			{
				return this._scaleTopElement;
			}
			set
			{
				this._scaleTopElement = value;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x00009DD1 File Offset: 0x00007FD1
		// (set) Token: 0x060001E7 RID: 487 RVA: 0x00009DD9 File Offset: 0x00007FD9
		public global::Infragistics.ShapeElement ScaleBottomElement
		{
			get
			{
				return this._scaleBottomElement;
			}
			set
			{
				this._scaleBottomElement = value;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x00009DE2 File Offset: 0x00007FE2
		// (set) Token: 0x060001E9 RID: 489 RVA: 0x00009DEA File Offset: 0x00007FEA
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

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001EA RID: 490 RVA: 0x00009DF3 File Offset: 0x00007FF3
		// (set) Token: 0x060001EB RID: 491 RVA: 0x00009DFB File Offset: 0x00007FFB
		internal bool IsTop
		{
			get
			{
				return this._isTop;
			}
			set
			{
				this._isTop = value;
			}
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00009E04 File Offset: 0x00008004
		public override void ArrangeChildren(global::System.Windows.Rect oldBounds, global::System.Windows.Rect newBounds)
		{
			double y = newBounds.Y + base.Zoombar.TopScaleHeight / 2.0;
			double num = newBounds.Height - base.Zoombar.TopScaleHeight / 2.0 - base.Zoombar.BottomScaleHeight / 2.0;
			if (num < 0.0)
			{
				num = 0.0;
			}
			this.ThumbBackground.Bounds = new global::System.Windows.Rect(newBounds.X, y, newBounds.Width, num);
			double y2 = newBounds.Bottom - base.Zoombar.BottomScaleHeight;
			this.ScaleTopElement.Bounds = new global::System.Windows.Rect(newBounds.X, newBounds.Y, newBounds.Width, base.Zoombar.TopScaleHeight);
			this.ScaleBottomElement.Bounds = new global::System.Windows.Rect(newBounds.X, y2, newBounds.Width, base.Zoombar.BottomScaleHeight);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00009F07 File Offset: 0x00008107
		public override global::Infragistics.ShapeElement HitResizeThumb(global::System.Windows.Point point)
		{
			if (this._scaleTopElement.HitTest(point))
			{
				this.IsTop = true;
				return this._scaleTopElement;
			}
			if (this._scaleBottomElement.HitTest(point))
			{
				this.IsTop = false;
				return this._scaleBottomElement;
			}
			return null;
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00009F44 File Offset: 0x00008144
		public override void DoMove(global::System.Windows.Point pt)
		{
			double num = pt.Y;
			double num2 = base.Bounds.Top + num;
			double num3 = base.Bounds.Bottom + num;
			double num4 = base.Zoombar.ActualHeight - base.Zoombar.BottomOffset;
			double topOffset = base.Zoombar.TopOffset;
			if (num2 < topOffset)
			{
				num += topOffset - num2;
			}
			if (num3 > num4)
			{
				num -= num3 - num4;
			}
			num2 = base.Bounds.Top + num;
			num3 = base.Bounds.Bottom + num;
			double minimum = base.Zoombar.CalculateValue(new global::System.Windows.Point(0.0, num2));
			double maximum = base.Zoombar.CalculateValue(new global::System.Windows.Point(0.0, num3));
			base.Zoombar.TempRange.Minimum = minimum;
			base.Zoombar.TempRange.Maximum = maximum;
			base.Zoombar.UpdateTempThumb();
			base.Zoombar.RaiseZoomChangingEvent();
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0000A050 File Offset: 0x00008250
		public override void DoResize(global::System.Windows.Point offset)
		{
			double topOffset = base.Zoombar.TopOffset;
			double num = base.Bounds.Top;
			double num2 = base.Bounds.Bottom;
			double num3 = base.Zoombar.TopScaleHeight + base.Zoombar.BottomScaleHeight;
			if (this.IsTop)
			{
				num += offset.Y;
				if (num < topOffset)
				{
					num = topOffset;
				}
				double num4 = num2 - num3;
				if (num > num4)
				{
					num = num4;
				}
			}
			else
			{
				num2 += offset.Y;
				double num5 = base.Zoombar.ActualHeight - base.Zoombar.BottomOffset;
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
			double minimum = base.Zoombar.CalculateValue(new global::System.Windows.Point(0.0, num));
			double maximum = base.Zoombar.CalculateValue(new global::System.Windows.Point(0.0, num2));
			base.Zoombar.TempRange.Minimum = minimum;
			base.Zoombar.TempRange.Maximum = maximum;
			base.Zoombar.UpdateTempThumb();
			base.Zoombar.RaiseZoomChangingEvent();
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0000A174 File Offset: 0x00008374
		protected override void ChangeVisualState(string newState)
		{
			foreach (global::System.Windows.FrameworkElement frameworkElement in this.ScaleTopElement.FrameworkElements)
			{
				global::System.Windows.Controls.Control control = frameworkElement as global::System.Windows.Controls.Control;
				if (control != null)
				{
					global::System.Windows.VisualStateManager.GoToState(control, newState, true);
				}
			}
			foreach (global::System.Windows.FrameworkElement frameworkElement2 in this.ScaleBottomElement.FrameworkElements)
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

		// Token: 0x04000092 RID: 146
		private global::Infragistics.ShapeElement _scaleTopElement;

		// Token: 0x04000093 RID: 147
		private global::Infragistics.ShapeElement _scaleBottomElement;

		// Token: 0x04000094 RID: 148
		private global::Infragistics.ShapeElement _thumbBackground;

		// Token: 0x04000095 RID: 149
		internal bool _isTop;
	}
}
