using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000157 RID: 343
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class ExpanderBar : global::System.Windows.Controls.Button
	{
		// Token: 0x06000B7A RID: 2938 RVA: 0x00025BDC File Offset: 0x00023DDC
		static ExpanderBar()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ExpanderBar), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Controls.ExpanderBar)));
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000B7B RID: 2939 RVA: 0x00025C5E File Offset: 0x00023E5E
		// (set) Token: 0x06000B7C RID: 2940 RVA: 0x00025C70 File Offset: 0x00023E70
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

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000B7D RID: 2941 RVA: 0x00025C7E File Offset: 0x00023E7E
		// (set) Token: 0x06000B7E RID: 2942 RVA: 0x00025C90 File Offset: 0x00023E90
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

		// Token: 0x04000577 RID: 1399
		public static readonly global::System.Windows.DependencyProperty BackgroundHoverProperty = global::System.Windows.DependencyProperty.Register("BackgroundHover", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.Controls.ExpanderBar), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000578 RID: 1400
		public static readonly global::System.Windows.DependencyProperty BorderHoverBrushProperty = global::System.Windows.DependencyProperty.Register("BorderHoverBrush", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.Controls.ExpanderBar), new global::System.Windows.FrameworkPropertyMetadata(null));
	}
}
