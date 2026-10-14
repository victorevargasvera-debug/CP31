using System;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000034 RID: 52
	public abstract class DiscreetRuleBase : global::Infragistics.Controls.Grids.ConditionalFormattingRuleBase
	{
		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000279 RID: 633 RVA: 0x0000C447 File Offset: 0x0000A647
		// (set) Token: 0x0600027A RID: 634 RVA: 0x0000C459 File Offset: 0x0000A659
		public global::System.Windows.Style StyleToApply
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.DiscreetRuleBase.StyleToApplyProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.DiscreetRuleBase.StyleToApplyProperty, value);
			}
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0000C468 File Offset: 0x0000A668
		private static void StyleToApplyChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.DiscreetRuleBase discreetRuleBase = (global::Infragistics.Controls.Grids.DiscreetRuleBase)obj;
			discreetRuleBase.OnPropertyChanged("StyleToApply");
		}

		// Token: 0x040000A2 RID: 162
		public static readonly global::System.Windows.DependencyProperty StyleToApplyProperty = global::System.Windows.DependencyProperty.Register("StyleToApply", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.DiscreetRuleBase), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.DiscreetRuleBase.StyleToApplyChanged)));
	}
}
