using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000149 RID: 329
	public class AverageSummaryCalculator : global::Infragistics.SummaryCalculatorBase, global::Infragistics.ISupportLinqSummaries
	{
		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000AA0 RID: 2720 RVA: 0x0002857B File Offset: 0x0002677B
		global::Infragistics.LinqSummaryOperator global::Infragistics.ISupportLinqSummaries.SummaryType
		{
			get
			{
				return global::Infragistics.LinqSummaryOperator.Average;
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000AA1 RID: 2721 RVA: 0x0002857E File Offset: 0x0002677E
		// (set) Token: 0x06000AA2 RID: 2722 RVA: 0x00028586 File Offset: 0x00026786
		global::Infragistics.SummaryContext global::Infragistics.ISupportLinqSummaries.SummaryContext { get; set; }
	}
}
