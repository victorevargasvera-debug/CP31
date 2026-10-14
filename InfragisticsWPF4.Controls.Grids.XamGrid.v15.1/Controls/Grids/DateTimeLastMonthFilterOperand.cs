using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200009C RID: 156
	public class DateTimeLastMonthFilterOperand : global::Infragistics.Controls.Grids.DateTimeNoInputBaseFilterOperand
	{
		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060005AB RID: 1451 RVA: 0x0001B5D2 File Offset: 0x000197D2
		protected override string DefaultDisplayName
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("DateTimeLastMonthFilterOperandString");
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060005AC RID: 1452 RVA: 0x0001B5DE File Offset: 0x000197DE
		public override global::Infragistics.ComparisonOperator? ComparisonOperatorValue
		{
			get
			{
				return new global::Infragistics.ComparisonOperator?(global::Infragistics.ComparisonOperator.DateTimeLastMonth);
			}
		}
	}
}
