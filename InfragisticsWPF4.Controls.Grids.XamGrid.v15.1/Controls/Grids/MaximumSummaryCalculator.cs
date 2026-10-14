using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000145 RID: 325
	public class MaximumSummaryCalculator : global::Infragistics.SummaryCalculatorBase, global::Infragistics.ISupportLinqSummaries
	{
		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000A90 RID: 2704 RVA: 0x0002850B File Offset: 0x0002670B
		global::Infragistics.LinqSummaryOperator global::Infragistics.ISupportLinqSummaries.SummaryType
		{
			get
			{
				return global::Infragistics.LinqSummaryOperator.Maximum;
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000A91 RID: 2705 RVA: 0x0002850E File Offset: 0x0002670E
		// (set) Token: 0x06000A92 RID: 2706 RVA: 0x00028516 File Offset: 0x00026716
		global::Infragistics.SummaryContext global::Infragistics.ISupportLinqSummaries.SummaryContext { get; set; }
	}
}
