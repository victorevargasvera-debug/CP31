using System;
using System.Linq;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000057 RID: 87
	public class MinimumValueConditionalFormatRuleProxy : global::Infragistics.Controls.Grids.EqualToConditionalFormatRuleProxy
	{
		// Token: 0x0600030F RID: 783 RVA: 0x0000E64C File Offset: 0x0000C84C
		protected override void GatherData(global::System.Linq.IQueryable query)
		{
			global::Infragistics.Controls.Grids.Column column = base.Parent.Column;
			global::Infragistics.SummaryContext summaryContext = global::Infragistics.SummaryContext.CreateGenericSummary(column.ColumnLayout.ObjectDataTypeInfo, column.Key, global::Infragistics.LinqSummaryOperator.Minimum);
			base.Value = summaryContext.Execute(query);
		}
	}
}
