using System;
using System.Windows;

namespace Infragistics.Controls
{
	// Token: 0x02000020 RID: 32
	public class Range : global::System.Windows.DependencyObject
	{
		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x0000913C File Offset: 0x0000733C
		// (set) Token: 0x060001A7 RID: 423 RVA: 0x0000914E File Offset: 0x0000734E
		public double Minimum
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Controls.Range.MinimumProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Range.MinimumProperty, value);
			}
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00009164 File Offset: 0x00007364
		private static void OnMinimumChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Range range = d as global::Infragistics.Controls.Range;
			range.OnMinimumChanged((double)e.OldValue, (double)e.NewValue);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00009198 File Offset: 0x00007398
		protected virtual void OnMinimumChanged(double oldValue, double newValue)
		{
			if (this.Zoombar == null || this.Initialize)
			{
				return;
			}
			if (newValue < this.Zoombar.ActualMinimum)
			{
				this.Minimum = this.Zoombar.ActualMinimum;
				return;
			}
			double num = global::System.Math.Min(this.Zoombar.ActualMaximum, this.Maximum);
			num = global::System.Math.Max(this.Zoombar.ActualMinimum, num);
			if (newValue > num)
			{
				this.Minimum = num;
				return;
			}
			global::Infragistics.Controls.Range range = new global::Infragistics.Controls.Range();
			this.Initialize = true;
			range.Minimum = oldValue;
			range.Maximum = this.Maximum;
			this.Initialize = false;
			this.Zoombar.ChangeRange(range, this.Zoombar.Range);
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060001AA RID: 426 RVA: 0x00009249 File Offset: 0x00007449
		// (set) Token: 0x060001AB RID: 427 RVA: 0x0000925B File Offset: 0x0000745B
		public double Maximum
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Controls.Range.MaximumProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Range.MaximumProperty, value);
			}
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00009270 File Offset: 0x00007470
		private static void OnMaximumChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Range range = d as global::Infragistics.Controls.Range;
			range.OnMaximumChanged((double)e.OldValue, (double)e.NewValue);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000092A4 File Offset: 0x000074A4
		protected virtual void OnMaximumChanged(double oldValue, double newValue)
		{
			if (this.Zoombar == null || this.Initialize)
			{
				return;
			}
			if (newValue > this.Zoombar.ActualMaximum)
			{
				this.Maximum = this.Zoombar.ActualMaximum;
				return;
			}
			double num = global::System.Math.Max(this.Zoombar.ActualMinimum, this.Minimum);
			num = global::System.Math.Min(this.Zoombar.ActualMaximum, num);
			if (newValue < num)
			{
				this.Maximum = num;
				return;
			}
			global::Infragistics.Controls.Range range = new global::Infragistics.Controls.Range();
			this.Initialize = true;
			range.Minimum = this.Minimum;
			range.Maximum = oldValue;
			this.Initialize = false;
			this.Zoombar.ChangeRange(range, this.Zoombar.Range);
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060001AE RID: 430 RVA: 0x00009358 File Offset: 0x00007558
		public double Scale
		{
			get
			{
				double num = 0.0;
				if (this.Zoombar == null)
				{
					return num;
				}
				double num2 = this.Zoombar.ActualMaximum - this.Zoombar.ActualMinimum;
				double num3 = this.Maximum - this.Minimum;
				if (num3 > 0.0 && num2 > 0.0)
				{
					num = num3 / num2;
				}
				if (num < 0.001)
				{
					num = 0.001;
				}
				return num;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060001AF RID: 431 RVA: 0x000093D4 File Offset: 0x000075D4
		public double Scroll
		{
			get
			{
				double result = 0.0;
				if (this.Zoombar == null)
				{
					return result;
				}
				double num = this.Zoombar.ActualMaximum - this.Zoombar.ActualMinimum;
				double num2 = this.Maximum - this.Minimum;
				double num3 = this.Minimum - this.Zoombar.ActualMinimum;
				double num4 = num - num2;
				if (num4 > 0.0)
				{
					result = num3 / num4;
				}
				return result;
			}
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00009448 File Offset: 0x00007648
		public void FromScaleScroll(double scale, double scroll)
		{
			if (this.Zoombar == null)
			{
				return;
			}
			scale = this.GetPossibleScale(scale);
			scroll = global::Infragistics.Controls.Range.GetPossibleScroll(scroll);
			double num = this.Zoombar.ActualMaximum - this.Zoombar.ActualMinimum;
			double num2 = num * scale;
			double num3 = num - num2;
			double num4 = num3 * scroll;
			double maximum = num4 + num2;
			this.Initialize = true;
			this.Minimum = num4;
			this.Maximum = maximum;
			this.Initialize = false;
			this.Zoombar.ChangeRange(null, this.Zoombar.Range);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x000094CC File Offset: 0x000076CC
		private double GetPossibleScale(double scale)
		{
			double num = this.Zoombar.CalculateMinScale();
			if (num < 0.001)
			{
				num = 0.001;
			}
			if (scale < num)
			{
				scale = num;
			}
			else if (scale > 1.0)
			{
				scale = 1.0;
			}
			return scale;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0000951C File Offset: 0x0000771C
		private static double GetPossibleScroll(double scroll)
		{
			if (scroll < 0.0)
			{
				scroll = 0.0;
			}
			else if (scroll > 1.0)
			{
				scroll = 1.0;
			}
			return scroll;
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x0000954F File Offset: 0x0000774F
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x00009557 File Offset: 0x00007757
		internal bool Initialize
		{
			get
			{
				return this._initialize;
			}
			set
			{
				this._initialize = value;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x00009560 File Offset: 0x00007760
		// (set) Token: 0x060001B6 RID: 438 RVA: 0x00009568 File Offset: 0x00007768
		internal global::Infragistics.Controls.XamZoombar Zoombar
		{
			get
			{
				return this._zoombar;
			}
			set
			{
				this._zoombar = value;
			}
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00009571 File Offset: 0x00007771
		public override string ToString()
		{
			return string.Format("Minimum = {0}, Maximum = {1}", this.Minimum, this.Maximum);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00009594 File Offset: 0x00007794
		internal global::Infragistics.Controls.Range Clone()
		{
			return new global::Infragistics.Controls.Range
			{
				Initialize = true,
				Minimum = this.Minimum,
				Maximum = this.Maximum,
				Initialize = false
			};
		}

		// Token: 0x0400007E RID: 126
		private const double MinScale = 0.001;

		// Token: 0x0400007F RID: 127
		private const double MaxScale = 1.0;

		// Token: 0x04000080 RID: 128
		private const double MinScroll = 0.0;

		// Token: 0x04000081 RID: 129
		private const double MaxScroll = 1.0;

		// Token: 0x04000082 RID: 130
		public static readonly global::System.Windows.DependencyProperty MinimumProperty = global::System.Windows.DependencyProperty.Register("Minimum", typeof(double), typeof(global::Infragistics.Controls.Range), new global::System.Windows.PropertyMetadata(0.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Range.OnMinimumChanged)));

		// Token: 0x04000083 RID: 131
		public static readonly global::System.Windows.DependencyProperty MaximumProperty = global::System.Windows.DependencyProperty.Register("Maximum", typeof(double), typeof(global::Infragistics.Controls.Range), new global::System.Windows.PropertyMetadata(1.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Range.OnMaximumChanged)));

		// Token: 0x04000084 RID: 132
		private bool _initialize;

		// Token: 0x04000085 RID: 133
		private global::Infragistics.Controls.XamZoombar _zoombar;
	}
}
