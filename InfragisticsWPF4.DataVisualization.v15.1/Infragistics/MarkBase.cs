using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Infragistics
{
	// Token: 0x0200000A RID: 10
	public abstract class MarkBase : global::System.Windows.Controls.Control
	{
		// Token: 0x0600005E RID: 94 RVA: 0x000035CF File Offset: 0x000017CF
		protected MarkBase()
		{
			base.DefaultStyleKey = typeof(global::Infragistics.MarkBase);
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600005F RID: 95 RVA: 0x000035E7 File Offset: 0x000017E7
		// (set) Token: 0x06000060 RID: 96 RVA: 0x000035F9 File Offset: 0x000017F9
		public global::System.Windows.Media.Brush Stroke
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.MarkBase.StrokeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.MarkBase.StrokeProperty, value);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00003607 File Offset: 0x00001807
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00003619 File Offset: 0x00001819
		public global::System.Windows.Media.Brush Fill
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.MarkBase.FillProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.MarkBase.FillProperty, value);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00003627 File Offset: 0x00001827
		// (set) Token: 0x06000064 RID: 100 RVA: 0x00003639 File Offset: 0x00001839
		public double StrokeThickness
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.MarkBase.StrokeThicknessProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.MarkBase.StrokeThicknessProperty, value);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000065 RID: 101 RVA: 0x0000364C File Offset: 0x0000184C
		// (set) Token: 0x06000066 RID: 102 RVA: 0x0000365E File Offset: 0x0000185E
		public double TickMarkSize
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.MarkBase.TickMarkSizeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.MarkBase.TickMarkSizeProperty, value);
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00003674 File Offset: 0x00001874
		private static bool OnTickMarkSizeValidate(object value)
		{
			double num = (double)value;
			return num >= 0.0;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00003697 File Offset: 0x00001897
		private static void OnPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x0400001C RID: 28
		public static readonly global::System.Windows.DependencyProperty StrokeProperty = global::System.Windows.DependencyProperty.Register("Stroke", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.MarkBase), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.MarkBase.OnPropertyChanged)));

		// Token: 0x0400001D RID: 29
		public static readonly global::System.Windows.DependencyProperty FillProperty = global::System.Windows.DependencyProperty.Register("Fill", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.MarkBase), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.MarkBase.OnPropertyChanged)));

		// Token: 0x0400001E RID: 30
		public static readonly global::System.Windows.DependencyProperty StrokeThicknessProperty = global::System.Windows.DependencyProperty.Register("StrokeThickness", typeof(double), typeof(global::Infragistics.MarkBase), new global::System.Windows.PropertyMetadata(1.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.MarkBase.OnPropertyChanged)));

		// Token: 0x0400001F RID: 31
		public static readonly global::System.Windows.DependencyProperty TickMarkSizeProperty = global::System.Windows.DependencyProperty.Register("TickMarkSize", typeof(double), typeof(global::Infragistics.MarkBase), new global::System.Windows.PropertyMetadata(1.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.MarkBase.OnPropertyChanged)));
	}
}
