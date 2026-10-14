using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000146 RID: 326
	public class MinimumSummaryCalculator : global::Infragistics.SummaryCalculatorBase, global::Infragistics.ISupportLinqSummaries
	{
		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000A94 RID: 2708 RVA: 0x00028527 File Offset: 0x00026727
		global::Infragistics.LinqSummaryOperator global::Infragistics.ISupportLinqSummaries.SummaryType
		{
			get
			{
				return global::Infragistics.LinqSummaryOperator.Minimum;
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000A95 RID: 2709 RVA: 0x0002852A File Offset: 0x0002672A
		// (set) Token: 0x06000A96 RID: 2710 RVA: 0x00028532 File Offset: 0x00026732
		global::Infragistics.SummaryContext global::Infragistics.ISupportLinqSummaries.SummaryContext { get; set; }
	}
}
