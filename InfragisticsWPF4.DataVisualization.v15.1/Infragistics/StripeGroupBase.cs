using System;
using System.Windows;
using System.Windows.Media;

namespace Infragistics
{
	// Token: 0x0200000C RID: 12
	public class StripeGroupBase : global::System.Windows.DependencyObject
	{
		// Token: 0x06000073 RID: 115 RVA: 0x000038E3 File Offset: 0x00001AE3
		protected StripeGroupBase()
		{
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000074 RID: 116 RVA: 0x000038EB File Offset: 0x00001AEB
		// (set) Token: 0x06000075 RID: 117 RVA: 0x000038FD File Offset: 0x00001AFD
		public global::System.Windows.Media.Brush Stroke
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.StripeGroupBase.StrokeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.StripeGroupBase.StrokeProperty, value);
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000076 RID: 118 RVA: 0x0000390B File Offset: 0x00001B0B
		// (set) Token: 0x06000077 RID: 119 RVA: 0x0000391D File Offset: 0x00001B1D
		public double StrokeThickness
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.StripeGroupBase.StrokeThicknessProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.StripeGroupBase.StrokeThicknessProperty, value);
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00003930 File Offset: 0x00001B30
		// (set) Token: 0x06000079 RID: 121 RVA: 0x00003942 File Offset: 0x00001B42
		public global::System.Windows.Style Style
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.StripeGroupBase.StyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.StripeGroupBase.StyleProperty, value);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00003950 File Offset: 0x00001B50
		// (set) Token: 0x0600007B RID: 123 RVA: 0x00003962 File Offset: 0x00001B62
		public global::System.Windows.Media.Brush Fill
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.StripeGroupBase.FillProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.StripeGroupBase.FillProperty, value);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00003970 File Offset: 0x00001B70
		// (set) Token: 0x0600007D RID: 125 RVA: 0x00003982 File Offset: 0x00001B82
		public double Unit
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.StripeGroupBase.UnitProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.StripeGroupBase.UnitProperty, value);
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00003998 File Offset: 0x00001B98
		private static bool AxisUnitValidateCallback(object value)
		{
			double num = (double)value;
			return num >= 0.0;
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600007F RID: 127 RVA: 0x000039BB File Offset: 0x00001BBB
		// (set) Token: 0x06000080 RID: 128 RVA: 0x000039CD File Offset: 0x00001BCD
		public double Width
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.StripeGroupBase.WidthProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.StripeGroupBase.WidthProperty, value);
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000039E0 File Offset: 0x00001BE0
		protected internal static void OnPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.StripeGroupBase stripeGroupBase = d as global::Infragistics.StripeGroupBase;
			stripeGroupBase.OnPropertyChanged(e);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000039FB File Offset: 0x00001BFB
		protected new virtual void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x04000023 RID: 35
		public static readonly global::System.Windows.DependencyProperty StrokeProperty = global::System.Windows.DependencyProperty.Register("Stroke", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.StripeGroupBase), new global::System.Windows.PropertyMetadata(new global::System.Windows.Media.SolidColorBrush(global::System.Windows.Media.Colors.Gray), new global::System.Windows.PropertyChangedCallback(global::Infragistics.StripeGroupBase.OnPropertyChanged)));

		// Token: 0x04000024 RID: 36
		public static readonly global::System.Windows.DependencyProperty StrokeThicknessProperty = global::System.Windows.DependencyProperty.Register("StrokeThickness", typeof(double), typeof(global::Infragistics.StripeGroupBase), new global::System.Windows.PropertyMetadata(1.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.StripeGroupBase.OnPropertyChanged)));

		// Token: 0x04000025 RID: 37
		public static readonly global::System.Windows.DependencyProperty StyleProperty = global::System.Windows.DependencyProperty.Register("Style", typeof(global::System.Windows.Style), typeof(global::Infragistics.StripeGroupBase), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.StripeGroupBase.OnPropertyChanged)));

		// Token: 0x04000026 RID: 38
		public static readonly global::System.Windows.DependencyProperty FillProperty = global::System.Windows.DependencyProperty.Register("Fill", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.StripeGroupBase), new global::System.Windows.PropertyMetadata(new global::System.Windows.Media.SolidColorBrush(global::System.Windows.Media.Colors.LightGray), new global::System.Windows.PropertyChangedCallback(global::Infragistics.StripeGroupBase.OnPropertyChanged)));

		// Token: 0x04000027 RID: 39
		public static readonly global::System.Windows.DependencyProperty UnitProperty = global::System.Windows.DependencyProperty.Register("Unit", typeof(double), typeof(global::Infragistics.StripeGroupBase), new global::System.Windows.PropertyMetadata(0.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.StripeGroupBase.OnPropertyChanged)));

		// Token: 0x04000028 RID: 40
		public static readonly global::System.Windows.DependencyProperty WidthProperty = global::System.Windows.DependencyProperty.Register("Width", typeof(double), typeof(global::Infragistics.StripeGroupBase), new global::System.Windows.PropertyMetadata(0.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.StripeGroupBase.OnPropertyChanged)));
	}
}
