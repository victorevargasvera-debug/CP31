using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200014C RID: 332
	public class MaximumSummaryOperand : global::Infragistics.SummaryOperandBase
	{
		// Token: 0x06000ABD RID: 2749 RVA: 0x00028EC9 File Offset: 0x000270C9
		public MaximumSummaryOperand()
		{
			this._maxSumCalc = new global::Infragistics.Controls.Grids.MaximumSummaryCalculator();
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000ABE RID: 2750 RVA: 0x00028EDC File Offset: 0x000270DC
		public override global::Infragistics.SummaryCalculatorBase SummaryCalculator
		{
			get
			{
				return this._maxSumCalc;
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000ABF RID: 2751 RVA: 0x00028EE4 File Offset: 0x000270E4
		protected override string DefaultSelectionDisplayLabel
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("MaxSummarySelectionLabel");
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x00028EF0 File Offset: 0x000270F0
		protected override string DefaultRowDisplayLabel
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("MaxSummaryRowLabel");
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x00028EFC File Offset: 0x000270FC
		public override global::Infragistics.LinqSummaryOperator? LinqSummaryOperator
		{
			get
			{
				return new global::Infragistics.LinqSummaryOperator?(global::Infragistics.LinqSummaryOperator.Maximum);
			}
		}

		// Token: 0x0400029D RID: 669
		private global::Infragistics.Controls.Grids.MaximumSummaryCalculator _maxSumCalc;
	}
}
