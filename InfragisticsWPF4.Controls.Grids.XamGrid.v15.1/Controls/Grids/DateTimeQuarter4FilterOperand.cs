using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000B4 RID: 180
	public class DateTimeQuarter4FilterOperand : global::Infragistics.Controls.Grids.DateTimeNoInputBaseFilterOperand
	{
		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060005F1 RID: 1521 RVA: 0x0001B875 File Offset: 0x00019A75
		protected override string DefaultDisplayName
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("DateTimeQuarter4FilterOperandString");
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x060005F2 RID: 1522 RVA: 0x0001B881 File Offset: 0x00019A81
		public override global::Infragistics.ComparisonOperator? ComparisonOperatorValue
		{
			get
			{
				return new global::Infragistics.ComparisonOperator?(global::Infragistics.ComparisonOperator.DateTimeQuarter4);
			}
		}
	}
}
