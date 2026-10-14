using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000A4 RID: 164
	public class DateTimeYearToDateFilterOperand : global::Infragistics.Controls.Grids.DateTimeNoInputBaseFilterOperand
	{
		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060005C1 RID: 1473 RVA: 0x0001B6A5 File Offset: 0x000198A5
		protected override string DefaultDisplayName
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("DateTimeYearToDateFilterOperandString");
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060005C2 RID: 1474 RVA: 0x0001B6B1 File Offset: 0x000198B1
		public override global::Infragistics.ComparisonOperator? ComparisonOperatorValue
		{
			get
			{
				return new global::Infragistics.ComparisonOperator?(global::Infragistics.ComparisonOperator.DateTimeYearToDate);
			}
		}
	}
}
