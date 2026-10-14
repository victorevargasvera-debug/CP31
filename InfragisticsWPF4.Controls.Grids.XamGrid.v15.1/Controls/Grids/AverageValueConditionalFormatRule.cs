using System;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000035 RID: 53
	public class AverageValueConditionalFormatRule : global::Infragistics.Controls.Grids.DiscreetRuleBase
	{
		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600027E RID: 638 RVA: 0x0000C4C5 File Offset: 0x0000A6C5
		// (set) Token: 0x0600027F RID: 639 RVA: 0x0000C4D7 File Offset: 0x0000A6D7
		public global::Infragistics.Controls.Grids.AverageFormattingTarget FormattingTarget
		{
			get
			{
				return (global::Infragistics.Controls.Grids.AverageFormattingTarget)base.GetValue(global::Infragistics.Controls.Grids.AverageValueConditionalFormatRule.FormattingTargetProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.AverageValueConditionalFormatRule.FormattingTargetProperty, value);
			}
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0000C4EC File Offset: 0x0000A6EC
		private static void FormattingTargetChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.AverageValueConditionalFormatRule averageValueConditionalFormatRule = (global::Infragistics.Controls.Grids.AverageValueConditionalFormatRule)obj;
			averageValueConditionalFormatRule.OnPropertyChanged("FormattingTarget");
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0000C50B File Offset: 0x0000A70B
		protected internal override global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy CreateProxy()
		{
			return new global::Infragistics.Controls.Grids.AverageValueConditionalFormatRuleProxy();
		}

		// Token: 0x040000A3 RID: 163
		public static readonly global::System.Windows.DependencyProperty FormattingTargetProperty = global::System.Windows.DependencyProperty.Register("FormattingTarget", typeof(global::Infragistics.Controls.Grids.AverageFormattingTarget), typeof(global::Infragistics.Controls.Grids.AverageValueConditionalFormatRule), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.AverageFormattingTarget.Above, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.AverageValueConditionalFormatRule.FormattingTargetChanged)));
	}
}
