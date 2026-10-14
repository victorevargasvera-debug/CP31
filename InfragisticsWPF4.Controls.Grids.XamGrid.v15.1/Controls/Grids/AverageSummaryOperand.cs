using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000150 RID: 336
	public class AverageSummaryOperand : global::Infragistics.SummaryOperandBase
	{
		// Token: 0x06000AD1 RID: 2769 RVA: 0x00028FB5 File Offset: 0x000271B5
		public AverageSummaryOperand()
		{
			this._AverageSumCalc = new global::Infragistics.Controls.Grids.AverageSummaryCalculator();
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000AD2 RID: 2770 RVA: 0x00028FC8 File Offset: 0x000271C8
		public override global::Infragistics.SummaryCalculatorBase SummaryCalculator
		{
			get
			{
				return this._AverageSumCalc;
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000AD3 RID: 2771 RVA: 0x00028FD0 File Offset: 0x000271D0
		protected override string DefaultSelectionDisplayLabel
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("AvgSummarySelectionLabel");
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000AD4 RID: 2772 RVA: 0x00028FDC File Offset: 0x000271DC
		protected override string DefaultRowDisplayLabel
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("AvgSummaryRowLabel");
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x00028FE8 File Offset: 0x000271E8
		public override global::Infragistics.LinqSummaryOperator? LinqSummaryOperator
		{
			get
			{
				return new global::Infragistics.LinqSummaryOperator?(global::Infragistics.LinqSummaryOperator.Average);
			}
		}

		// Token: 0x040002A1 RID: 673
		private global::Infragistics.Controls.Grids.AverageSummaryCalculator _AverageSumCalc;
	}
}
