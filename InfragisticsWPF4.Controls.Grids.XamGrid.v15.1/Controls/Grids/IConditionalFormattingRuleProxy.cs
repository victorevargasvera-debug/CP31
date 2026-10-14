using System;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000036 RID: 54
	public interface IConditionalFormattingRuleProxy : global::Infragistics.IRule
	{
		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000284 RID: 644
		// (set) Token: 0x06000285 RID: 645
		global::Infragistics.Controls.Grids.IConditionalFormattingRule Parent { get; set; }

		// Token: 0x06000286 RID: 646
		global::System.Windows.Style EvaluateCondition(object sourceDataObject, object sourceDataValue);
	}
}
