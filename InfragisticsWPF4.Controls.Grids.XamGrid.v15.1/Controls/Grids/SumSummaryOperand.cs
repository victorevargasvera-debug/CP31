using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200014F RID: 335
	public class SumSummaryOperand : global::Infragistics.SummaryOperandBase
	{
		// Token: 0x06000ACC RID: 2764 RVA: 0x00028F7A File Offset: 0x0002717A
		public SumSummaryOperand()
		{
			this._SumSumCalc = new global::Infragistics.Controls.Grids.SumSummaryCalculator();
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000ACD RID: 2765 RVA: 0x00028F8D File Offset: 0x0002718D
		public override global::Infragistics.SummaryCalculatorBase SummaryCalculator
		{
			get
			{
				return this._SumSumCalc;
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000ACE RID: 2766 RVA: 0x00028F95 File Offset: 0x00027195
		protected override string DefaultSelectionDisplayLabel
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("SumSummarySelectionLabel");
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000ACF RID: 2767 RVA: 0x00028FA1 File Offset: 0x000271A1
		protected override string DefaultRowDisplayLabel
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("SumSummaryRowLabel");
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000AD0 RID: 2768 RVA: 0x00028FAD File Offset: 0x000271AD
		public override global::Infragistics.LinqSummaryOperator? LinqSummaryOperator
		{
			get
			{
				return new global::Infragistics.LinqSummaryOperator?(global::Infragistics.LinqSummaryOperator.Sum);
			}
		}

		// Token: 0x040002A0 RID: 672
		private global::Infragistics.Controls.Grids.SumSummaryCalculator _SumSumCalc;
	}
}
