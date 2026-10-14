using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000B3 RID: 179
	public class DateTimeQuarter3FilterOperand : global::Infragistics.Controls.Grids.DateTimeNoInputBaseFilterOperand
	{
		// Token: 0x170001BB RID: 443
		// (get) Token: 0x060005EE RID: 1518 RVA: 0x0001B858 File Offset: 0x00019A58
		protected override string DefaultDisplayName
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("DateTimeQuarter3FilterOperandString");
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060005EF RID: 1519 RVA: 0x0001B864 File Offset: 0x00019A64
		public override global::Infragistics.ComparisonOperator? ComparisonOperatorValue
		{
			get
			{
				return new global::Infragistics.ComparisonOperator?(global::Infragistics.ComparisonOperator.DateTimeQuarter3);
			}
		}
	}
}
