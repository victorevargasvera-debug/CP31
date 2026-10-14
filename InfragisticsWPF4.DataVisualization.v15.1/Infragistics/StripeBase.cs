using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Infragistics
{
	// Token: 0x0200000B RID: 11
	public abstract class StripeBase : global::System.Windows.Controls.Control
	{
		// Token: 0x0600006A RID: 106 RVA: 0x00003797 File Offset: 0x00001997
		protected StripeBase()
		{
			base.DefaultStyleKey = typeof(global::Infragistics.StripeBase);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000037AF File Offset: 0x000019AF
		private static void OnPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600006C RID: 108 RVA: 0x000037B1 File Offset: 0x000019B1
		// (set) Token: 0x0600006D RID: 109 RVA: 0x000037C3 File Offset: 0x000019C3
		public global::System.Windows.Media.Brush Stroke
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.StripeBase.StrokeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.StripeBase.StrokeProperty, value);
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600006E RID: 110 RVA: 0x000037D1 File Offset: 0x000019D1
		// (set) Token: 0x0600006F RID: 111 RVA: 0x000037E3 File Offset: 0x000019E3
		public double StrokeThickness
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.StripeBase.StrokeThicknessProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.StripeBase.StrokeThicknessProperty, value);
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000070 RID: 112 RVA: 0x000037F6 File Offset: 0x000019F6
		// (set) Token: 0x06000071 RID: 113 RVA: 0x00003808 File Offset: 0x00001A08
		public global::System.Windows.Media.Brush Fill
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.StripeBase.FillProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.StripeBase.FillProperty, value);
			}
		}

		// Token: 0x04000020 RID: 32
		public static readonly global::System.Windows.DependencyProperty StrokeProperty = global::System.Windows.DependencyProperty.Register("Stroke", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.StripeBase), new global::System.Windows.PropertyMetadata(new global::System.Windows.Media.SolidColorBrush(global::System.Windows.Media.Colors.Gray), new global::System.Windows.PropertyChangedCallback(global::Infragistics.StripeBase.OnPropertyChanged)));

		// Token: 0x04000021 RID: 33
		public static readonly global::System.Windows.DependencyProperty StrokeThicknessProperty = global::System.Windows.DependencyProperty.Register("StrokeThickness", typeof(double), typeof(global::Infragistics.StripeBase), new global::System.Windows.PropertyMetadata(1.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.StripeBase.OnPropertyChanged)));

		// Token: 0x04000022 RID: 34
		public static readonly global::System.Windows.DependencyProperty FillProperty = global::System.Windows.DependencyProperty.Register("Fill", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.StripeBase), new global::System.Windows.PropertyMetadata(new global::System.Windows.Media.SolidColorBrush(global::System.Windows.Media.Colors.LightGray), new global::System.Windows.PropertyChangedCallback(global::Infragistics.StripeBase.OnPropertyChanged)));
	}
}
