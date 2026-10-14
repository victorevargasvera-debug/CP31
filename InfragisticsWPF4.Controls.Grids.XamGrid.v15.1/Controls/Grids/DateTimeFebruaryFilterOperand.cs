using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000A6 RID: 166
	public class DateTimeFebruaryFilterOperand : global::Infragistics.Controls.Grids.DateTimeNoInputBaseFilterOperand
	{
		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060005C7 RID: 1479 RVA: 0x0001B6DF File Offset: 0x000198DF
		protected override string DefaultDisplayName
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("DateTimeFebruaryFilterOperandString");
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060005C8 RID: 1480 RVA: 0x0001B6EB File Offset: 0x000198EB
		public override global::Infragistics.ComparisonOperator? ComparisonOperatorValue
		{
			get
			{
				return new global::Infragistics.ComparisonOperator?(global::Infragistics.ComparisonOperator.DateTimeFebruary);
			}
		}
	}
}
