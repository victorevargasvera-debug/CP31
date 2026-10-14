using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000138 RID: 312
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class ExpanderBar : global::System.Windows.Controls.Button
	{
		// Token: 0x06000A7B RID: 2683 RVA: 0x00022014 File Offset: 0x00020214
		static ExpanderBar()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ExpanderBar), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Controls.ExpanderBar)));
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000A7C RID: 2684 RVA: 0x00022096 File Offset: 0x00020296
		// (set) Token: 0x06000A7D RID: 2685 RVA: 0x000220A8 File Offset: 0x000202A8
		public global::System.Windows.Media.Brush BackgroundHover
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Windows.Controls.ExpanderBar.BackgroundHoverProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ExpanderBar.BackgroundHoverProperty, value);
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000A7E RID: 2686 RVA: 0x000220B6 File Offset: 0x000202B6
		// (set) Token: 0x06000A7F RID: 2687 RVA: 0x000220C8 File Offset: 0x000202C8
		public global::System.Windows.Media.Brush BorderHoverBrush
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Windows.Controls.ExpanderBar.BorderHoverBrushProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ExpanderBar.BorderHoverBrushProperty, value);
			}
		}

		// Token: 0x040004C1 RID: 1217
		public static readonly global::System.Windows.DependencyProperty BackgroundHoverProperty = global::System.Windows.DependencyProperty.Register("BackgroundHover", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.Controls.ExpanderBar), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040004C2 RID: 1218
		public static readonly global::System.Windows.DependencyProperty BorderHoverBrushProperty = global::System.Windows.DependencyProperty.Register("BorderHoverBrush", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.Controls.ExpanderBar), new global::System.Windows.FrameworkPropertyMetadata(null));
	}
}
