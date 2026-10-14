using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200014D RID: 333
	public class MinimumSummaryOperand : global::Infragistics.SummaryOperandBase
	{
		// Token: 0x06000AC2 RID: 2754 RVA: 0x00028F04 File Offset: 0x00027104
		public MinimumSummaryOperand()
		{
			this._minSumCalc = new global::Infragistics.Controls.Grids.MinimumSummaryCalculator();
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x00028F17 File Offset: 0x00027117
		public override global::Infragistics.SummaryCalculatorBase SummaryCalculator
		{
			get
			{
				return this._minSumCalc;
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000AC4 RID: 2756 RVA: 0x00028F1F File Offset: 0x0002711F
		protected override string DefaultSelectionDisplayLabel
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("MinSummarySelectionLabel");
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000AC5 RID: 2757 RVA: 0x00028F2B File Offset: 0x0002712B
		protected override string DefaultRowDisplayLabel
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("MinSummaryRowLabel");
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000AC6 RID: 2758 RVA: 0x00028F37 File Offset: 0x00027137
		public override global::Infragistics.LinqSummaryOperator? LinqSummaryOperator
		{
			get
			{
				return new global::Infragistics.LinqSummaryOperator?(global::Infragistics.LinqSummaryOperator.Minimum);
			}
		}

		// Token: 0x0400029E RID: 670
		private global::Infragistics.Controls.Grids.MinimumSummaryCalculator _minSumCalc;
	}
}
