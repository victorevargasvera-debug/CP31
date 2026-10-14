using System;
using System.Windows;
using System.Windows.Media;

namespace Infragistics.Windows.Controls
{
	// Token: 0x020000F6 RID: 246
	public class BrushHelper
	{
		// Token: 0x06000883 RID: 2179 RVA: 0x0001C9F2 File Offset: 0x0001ABF2
		protected BrushHelper()
		{
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x0001C9FA File Offset: 0x0001ABFA
		public static global::System.Windows.Media.Brush GetBackground(global::System.Windows.DependencyObject d)
		{
			return (global::System.Windows.Media.Brush)d.GetValue(global::Infragistics.Windows.Controls.BrushHelper.BackgroundProperty);
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x0001CA0C File Offset: 0x0001AC0C
		public static void SetBackground(global::System.Windows.DependencyObject d, global::System.Windows.Media.Brush value)
		{
			d.SetValue(global::Infragistics.Windows.Controls.BrushHelper.BackgroundProperty, value);
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x0001CA1A File Offset: 0x0001AC1A
		public static global::System.Windows.Media.Brush GetBorderBrush(global::System.Windows.DependencyObject d)
		{
			return (global::System.Windows.Media.Brush)d.GetValue(global::Infragistics.Windows.Controls.BrushHelper.BorderBrushProperty);
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x0001CA2C File Offset: 0x0001AC2C
		public static void SetBorderBrush(global::System.Windows.DependencyObject d, global::System.Windows.Media.Brush value)
		{
			d.SetValue(global::Infragistics.Windows.Controls.BrushHelper.BorderBrushProperty, value);
		}

		// Token: 0x04000398 RID: 920
		public static readonly global::System.Windows.DependencyProperty BackgroundProperty = global::System.Windows.DependencyProperty.RegisterAttached("Background", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.Controls.BrushHelper), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000399 RID: 921
		public static readonly global::System.Windows.DependencyProperty BorderBrushProperty = global::System.Windows.DependencyProperty.RegisterAttached("BorderBrush", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.Controls.BrushHelper), new global::System.Windows.FrameworkPropertyMetadata(null));
	}
}
