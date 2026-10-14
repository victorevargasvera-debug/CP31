using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000AB RID: 171
	public class DateTimeJulyFilterOperand : global::Infragistics.Controls.Grids.DateTimeNoInputBaseFilterOperand
	{
		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060005D6 RID: 1494 RVA: 0x0001B770 File Offset: 0x00019970
		protected override string DefaultDisplayName
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("DateTimeJulyFilterOperandString");
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x060005D7 RID: 1495 RVA: 0x0001B77C File Offset: 0x0001997C
		public override global::Infragistics.ComparisonOperator? ComparisonOperatorValue
		{
			get
			{
				return new global::Infragistics.ComparisonOperator?(global::Infragistics.ComparisonOperator.DateTimeJuly);
			}
		}
	}
}
