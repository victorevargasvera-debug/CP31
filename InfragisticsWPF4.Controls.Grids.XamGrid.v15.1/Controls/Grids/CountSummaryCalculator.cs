using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000147 RID: 327
	public class CountSummaryCalculator : global::Infragistics.SummaryCalculatorBase, global::Infragistics.ISupportLinqSummaries
	{
		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000A98 RID: 2712 RVA: 0x00028543 File Offset: 0x00026743
		global::Infragistics.LinqSummaryOperator global::Infragistics.ISupportLinqSummaries.SummaryType
		{
			get
			{
				return global::Infragistics.LinqSummaryOperator.Count;
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000A99 RID: 2713 RVA: 0x00028546 File Offset: 0x00026746
		// (set) Token: 0x06000A9A RID: 2714 RVA: 0x0002854E File Offset: 0x0002674E
		global::Infragistics.SummaryContext global::Infragistics.ISupportLinqSummaries.SummaryContext { get; set; }
	}
}
