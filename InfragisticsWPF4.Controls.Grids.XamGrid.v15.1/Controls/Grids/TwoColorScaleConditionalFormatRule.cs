using System;
using System.Windows;
using System.Windows.Media;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200005E RID: 94
	public class TwoColorScaleConditionalFormatRule : global::Infragistics.Controls.Grids.TwoInputConditionalFormatRule
	{
		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600031D RID: 797 RVA: 0x0000E79D File Offset: 0x0000C99D
		// (set) Token: 0x0600031E RID: 798 RVA: 0x0000E7AF File Offset: 0x0000C9AF
		public global::System.Windows.Media.Color MinimumColor
		{
			get
			{
				return (global::System.Windows.Media.Color)base.GetValue(global::Infragistics.Controls.Grids.TwoColorScaleConditionalFormatRule.MinimumColorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.TwoColorScaleConditionalFormatRule.MinimumColorProperty, value);
			}
		}

		// Token: 0x0600031F RID: 799 RVA: 0x0000E7C4 File Offset: 0x0000C9C4
		private static void MinimumColorChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.TwoColorScaleConditionalFormatRule twoColorScaleConditionalFormatRule = (global::Infragistics.Controls.Grids.TwoColorScaleConditionalFormatRule)obj;
			twoColorScaleConditionalFormatRule.OnPropertyChanged("MinimumColor");
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000320 RID: 800 RVA: 0x0000E7E3 File Offset: 0x0000C9E3
		// (set) Token: 0x06000321 RID: 801 RVA: 0x0000E7F5 File Offset: 0x0000C9F5
		public global::System.Windows.Media.Color MaximumColor
		{
			get
			{
				return (global::System.Windows.Media.Color)base.GetValue(global::Infragistics.Controls.Grids.TwoColorScaleConditionalFormatRule.MaximumColorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.TwoColorScaleConditionalFormatRule.MaximumColorProperty, value);
			}
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0000E808 File Offset: 0x0000CA08
		private static void MaximumColorChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.TwoColorScaleConditionalFormatRule twoColorScaleConditionalFormatRule = (global::Infragistics.Controls.Grids.TwoColorScaleConditionalFormatRule)obj;
			twoColorScaleConditionalFormatRule.OnPropertyChanged("MaximumColor");
		}

		// Token: 0x06000323 RID: 803 RVA: 0x0000E828 File Offset: 0x0000CA28
		protected internal override global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy CreateProxy()
		{
			return new global::Infragistics.Controls.Grids.TwoColorScaleConditionalFormatRuleProxy
			{
				MaximumValue = base.MaximumValue,
				MinimumValue = base.MinimumValue
			};
		}

		// Token: 0x040000BE RID: 190
		public static readonly global::System.Windows.DependencyProperty MinimumColorProperty = global::System.Windows.DependencyProperty.Register("MinimumColor", typeof(global::System.Windows.Media.Color), typeof(global::Infragistics.Controls.Grids.TwoColorScaleConditionalFormatRule), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.TwoColorScaleConditionalFormatRule.MinimumColorChanged)));

		// Token: 0x040000BF RID: 191
		public static readonly global::System.Windows.DependencyProperty MaximumColorProperty = global::System.Windows.DependencyProperty.Register("MaximumColor", typeof(global::System.Windows.Media.Color), typeof(global::Infragistics.Controls.Grids.TwoColorScaleConditionalFormatRule), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.TwoColorScaleConditionalFormatRule.MaximumColorChanged)));
	}
}
