using System;
using System.Linq;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000055 RID: 85
	public class MaximumValueConditionalFormatRuleProxy : global::Infragistics.Controls.Grids.EqualToConditionalFormatRuleProxy
	{
		// Token: 0x0600030B RID: 779 RVA: 0x0000E5DC File Offset: 0x0000C7DC
		protected override void GatherData(global::System.Linq.IQueryable query)
		{
			global::Infragistics.Controls.Grids.Column column = base.Parent.Column;
			global::Infragistics.SummaryContext summaryContext = global::Infragistics.SummaryContext.CreateGenericSummary(column.ColumnLayout.ObjectDataTypeInfo, column.Key, global::Infragistics.LinqSummaryOperator.Maximum);
			base.Value = summaryContext.Execute(query);
		}
	}
}
