using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200014E RID: 334
	public class CountSummaryOperand : global::Infragistics.SummaryOperandBase
	{
		// Token: 0x06000AC7 RID: 2759 RVA: 0x00028F3F File Offset: 0x0002713F
		public CountSummaryOperand()
		{
			this._countSumCalc = new global::Infragistics.Controls.Grids.CountSummaryCalculator();
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000AC8 RID: 2760 RVA: 0x00028F52 File Offset: 0x00027152
		public override global::Infragistics.SummaryCalculatorBase SummaryCalculator
		{
			get
			{
				return this._countSumCalc;
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000AC9 RID: 2761 RVA: 0x00028F5A File Offset: 0x0002715A
		protected override string DefaultSelectionDisplayLabel
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("CountSummarySelectionLabel");
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000ACA RID: 2762 RVA: 0x00028F66 File Offset: 0x00027166
		protected override string DefaultRowDisplayLabel
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("CountSummaryRowLabel");
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000ACB RID: 2763 RVA: 0x00028F72 File Offset: 0x00027172
		public override global::Infragistics.LinqSummaryOperator? LinqSummaryOperator
		{
			get
			{
				return new global::Infragistics.LinqSummaryOperator?(global::Infragistics.LinqSummaryOperator.Count);
			}
		}

		// Token: 0x0400029F RID: 671
		private global::Infragistics.Controls.Grids.CountSummaryCalculator _countSumCalc;
	}
}
