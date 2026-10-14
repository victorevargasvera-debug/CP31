using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000148 RID: 328
	public class SumSummaryCalculator : global::Infragistics.SummaryCalculatorBase, global::Infragistics.ISupportLinqSummaries
	{
		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000A9C RID: 2716 RVA: 0x0002855F File Offset: 0x0002675F
		global::Infragistics.LinqSummaryOperator global::Infragistics.ISupportLinqSummaries.SummaryType
		{
			get
			{
				return global::Infragistics.LinqSummaryOperator.Sum;
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000A9D RID: 2717 RVA: 0x00028562 File Offset: 0x00026762
		// (set) Token: 0x06000A9E RID: 2718 RVA: 0x0002856A File Offset: 0x0002676A
		global::Infragistics.SummaryContext global::Infragistics.ISupportLinqSummaries.SummaryContext { get; set; }
	}
}
