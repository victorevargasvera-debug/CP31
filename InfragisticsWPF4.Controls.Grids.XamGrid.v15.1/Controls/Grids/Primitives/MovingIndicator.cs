using System;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000022 RID: 34
	[global::System.Windows.TemplatePart(Name = "FillIndicator", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplateVisualState(GroupName = "CommonStates", Name = "Normal")]
	[global::System.Windows.TemplatePart(Name = "TopIndicator", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplatePart(Name = "BottomIndicator", Type = typeof(global::System.Windows.FrameworkElement))]
	public class MovingIndicator : global::System.Windows.Controls.Control
	{
		// Token: 0x06000197 RID: 407 RVA: 0x00009B34 File Offset: 0x00007D34
		static MovingIndicator()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.MovingIndicator), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.MovingIndicator)));
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000199 RID: 409 RVA: 0x00009BAE File Offset: 0x00007DAE
		// (set) Token: 0x0600019A RID: 410 RVA: 0x00009BC0 File Offset: 0x00007DC0
		public double HorizontalOffset
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Controls.Grids.Primitives.MovingIndicator.HorizontalOffsetProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.MovingIndicator.HorizontalOffsetProperty, value);
			}
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00009BD3 File Offset: 0x00007DD3
		private static void HorizontalOffsetChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600019C RID: 412 RVA: 0x00009BD5 File Offset: 0x00007DD5
		// (set) Token: 0x0600019D RID: 413 RVA: 0x00009BDD File Offset: 0x00007DDD
		internal double TopIndicatorDesiredHeight { get; private set; }

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600019E RID: 414 RVA: 0x00009BE6 File Offset: 0x00007DE6
		// (set) Token: 0x0600019F RID: 415 RVA: 0x00009BEE File Offset: 0x00007DEE
		internal double FillIndicatorHeight { get; set; }

		// Token: 0x060001A0 RID: 416 RVA: 0x00009BF8 File Offset: 0x00007DF8
		public override void OnApplyTemplate()
		{
			this._topIndicator = (base.GetTemplateChild("TopIndicator") as global::System.Windows.FrameworkElement);
			this._bottomIndicator = (base.GetTemplateChild("BottomIndicator") as global::System.Windows.FrameworkElement);
			this._fillIndicator = (base.GetTemplateChild("FillIndicator") as global::System.Windows.FrameworkElement);
			global::System.Windows.VisualStateManager.GoToState(this, "Normal", true);
			this.TopIndicatorDesiredHeight = 0.0;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00009C64 File Offset: 0x00007E64
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
		{
			double num = 0.0;
			double num2 = 0.0;
			if (this._topIndicator != null)
			{
				this._topIndicator.Measure(constraint);
				num2 += this._topIndicator.DesiredSize.Height;
				num = global::System.Math.Max(num, this._topIndicator.DesiredSize.Width);
				this.TopIndicatorDesiredHeight = this._topIndicator.DesiredSize.Height;
			}
			if (this._fillIndicator != null)
			{
				this._fillIndicator.Measure(new global::System.Windows.Size(constraint.Width, this.FillIndicatorHeight));
				num2 += this.FillIndicatorHeight;
				num = global::System.Math.Max(num, this._fillIndicator.DesiredSize.Width);
			}
			else
			{
				num2 += this.FillIndicatorHeight;
				if (!double.IsInfinity(constraint.Width))
				{
					num = global::System.Math.Max(num, constraint.Width);
				}
			}
			if (this._bottomIndicator != null)
			{
				this._bottomIndicator.Measure(constraint);
				num2 += this._bottomIndicator.DesiredSize.Height;
				num = global::System.Math.Max(num, this._bottomIndicator.DesiredSize.Width);
			}
			return new global::System.Windows.Size(num, num2);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00009DA0 File Offset: 0x00007FA0
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			double num = 0.0;
			if (this._topIndicator != null)
			{
				double length = 0.0;
				double length2 = 0.0;
				num = this._topIndicator.DesiredSize.Height;
				global::System.Windows.Controls.Canvas.SetTop(this._topIndicator, length);
				global::System.Windows.Controls.Canvas.SetLeft(this._topIndicator, length2);
			}
			if (this._fillIndicator != null)
			{
				this._fillIndicator.Height = this.FillIndicatorHeight;
				global::System.Windows.Controls.Canvas.SetLeft(this._fillIndicator, 0.0);
				global::System.Windows.Controls.Canvas.SetTop(this._fillIndicator, num);
			}
			num += this.FillIndicatorHeight;
			if (this._bottomIndicator != null)
			{
				double length3 = num;
				double length4 = 0.0;
				global::System.Windows.Controls.Canvas.SetTop(this._bottomIndicator, length3);
				global::System.Windows.Controls.Canvas.SetLeft(this._bottomIndicator, length4);
			}
			return base.ArrangeOverride(finalSize);
		}

		// Token: 0x04000067 RID: 103
		private global::System.Windows.FrameworkElement _topIndicator;

		// Token: 0x04000068 RID: 104
		private global::System.Windows.FrameworkElement _bottomIndicator;

		// Token: 0x04000069 RID: 105
		private global::System.Windows.FrameworkElement _fillIndicator;

		// Token: 0x0400006A RID: 106
		public static readonly global::System.Windows.DependencyProperty HorizontalOffsetProperty = global::System.Windows.DependencyProperty.Register("HorizontalOffset", typeof(double), typeof(global::Infragistics.Controls.Grids.Primitives.MovingIndicator), new global::System.Windows.PropertyMetadata(0.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.MovingIndicator.HorizontalOffsetChanged)));
	}
}
