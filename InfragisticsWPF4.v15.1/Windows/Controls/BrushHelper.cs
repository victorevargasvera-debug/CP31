using System;
using System.Windows;
using System.Windows.Media;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000114 RID: 276
	public class BrushHelper
	{
		// Token: 0x06000982 RID: 2434 RVA: 0x000205BA File Offset: 0x0001E7BA
		protected BrushHelper()
		{
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x000205C2 File Offset: 0x0001E7C2
		public static global::System.Windows.Media.Brush GetBackground(global::System.Windows.DependencyObject d)
		{
			return (global::System.Windows.Media.Brush)d.GetValue(global::Infragistics.Windows.Controls.BrushHelper.BackgroundProperty);
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x000205D4 File Offset: 0x0001E7D4
		public static void SetBackground(global::System.Windows.DependencyObject d, global::System.Windows.Media.Brush value)
		{
			d.SetValue(global::Infragistics.Windows.Controls.BrushHelper.BackgroundProperty, value);
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x000205E2 File Offset: 0x0001E7E2
		public static global::System.Windows.Media.Brush GetBorderBrush(global::System.Windows.DependencyObject d)
		{
			return (global::System.Windows.Media.Brush)d.GetValue(global::Infragistics.Windows.Controls.BrushHelper.BorderBrushProperty);
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x000205F4 File Offset: 0x0001E7F4
		public static void SetBorderBrush(global::System.Windows.DependencyObject d, global::System.Windows.Media.Brush value)
		{
			d.SetValue(global::Infragistics.Windows.Controls.BrushHelper.BorderBrushProperty, value);
		}

		// Token: 0x0400044B RID: 1099
		public static readonly global::System.Windows.DependencyProperty BackgroundProperty = global::System.Windows.DependencyProperty.RegisterAttached("Background", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.Controls.BrushHelper), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x0400044C RID: 1100
		public static readonly global::System.Windows.DependencyProperty BorderBrushProperty = global::System.Windows.DependencyProperty.RegisterAttached("BorderBrush", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.Controls.BrushHelper), new global::System.Windows.FrameworkPropertyMetadata(null));
	}
}
