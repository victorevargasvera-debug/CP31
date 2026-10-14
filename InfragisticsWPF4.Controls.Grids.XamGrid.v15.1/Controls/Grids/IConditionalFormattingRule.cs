using System;
using System.ComponentModel;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000032 RID: 50
	public interface IConditionalFormattingRule : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600024C RID: 588
		bool IsTerminalRule { get; }

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600024D RID: 589
		// (set) Token: 0x0600024E RID: 590
		global::Infragistics.Controls.Grids.Column Column { get; set; }

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600024F RID: 591
		global::Infragistics.Controls.Grids.StyleScope StyleScope { get; }

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000250 RID: 592
		bool ShouldRefreshOnDataChange { get; }

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000251 RID: 593
		global::System.Windows.Visibility CellValueVisibility { get; }

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000252 RID: 594
		global::Infragistics.EvaluationStage RuleExecution { get; }

		// Token: 0x06000253 RID: 595
		global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy CreateProxy();
	}
}
