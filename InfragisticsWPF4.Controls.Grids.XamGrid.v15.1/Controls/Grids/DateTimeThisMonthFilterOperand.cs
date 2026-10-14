using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200009B RID: 155
	public class DateTimeThisMonthFilterOperand : global::Infragistics.Controls.Grids.DateTimeNoInputBaseFilterOperand
	{
		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060005A8 RID: 1448 RVA: 0x0001B5B5 File Offset: 0x000197B5
		protected override string DefaultDisplayName
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("DateTimeThisMonthFilterOperandString");
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x0001B5C1 File Offset: 0x000197C1
		public override global::Infragistics.ComparisonOperator? ComparisonOperatorValue
		{
			get
			{
				return new global::Infragistics.ComparisonOperator?(global::Infragistics.ComparisonOperator.DateTimeThisMonth);
			}
		}
	}
}
