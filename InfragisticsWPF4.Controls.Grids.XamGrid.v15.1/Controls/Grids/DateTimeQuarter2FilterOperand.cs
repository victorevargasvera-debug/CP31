using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000B2 RID: 178
	public class DateTimeQuarter2FilterOperand : global::Infragistics.Controls.Grids.DateTimeNoInputBaseFilterOperand
	{
		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x060005EB RID: 1515 RVA: 0x0001B83B File Offset: 0x00019A3B
		protected override string DefaultDisplayName
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("DateTimeQuarter2FilterOperandString");
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x060005EC RID: 1516 RVA: 0x0001B847 File Offset: 0x00019A47
		public override global::Infragistics.ComparisonOperator? ComparisonOperatorValue
		{
			get
			{
				return new global::Infragistics.ComparisonOperator?(global::Infragistics.ComparisonOperator.DateTimeQuarter2);
			}
		}
	}
}
