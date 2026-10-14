using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000B1 RID: 177
	public class DateTimeQuarter1FilterOperand : global::Infragistics.Controls.Grids.DateTimeNoInputBaseFilterOperand
	{
		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x060005E8 RID: 1512 RVA: 0x0001B81E File Offset: 0x00019A1E
		protected override string DefaultDisplayName
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("DateTimeQuarter1FilterOperandString");
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x060005E9 RID: 1513 RVA: 0x0001B82A File Offset: 0x00019A2A
		public override global::Infragistics.ComparisonOperator? ComparisonOperatorValue
		{
			get
			{
				return new global::Infragistics.ComparisonOperator?(global::Infragistics.ComparisonOperator.DateTimeQuarter1);
			}
		}
	}
}
