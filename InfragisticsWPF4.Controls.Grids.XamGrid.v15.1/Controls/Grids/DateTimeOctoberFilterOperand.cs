using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000AE RID: 174
	public class DateTimeOctoberFilterOperand : global::Infragistics.Controls.Grids.DateTimeNoInputBaseFilterOperand
	{
		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x060005DF RID: 1503 RVA: 0x0001B7C7 File Offset: 0x000199C7
		protected override string DefaultDisplayName
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("DateTimeOctoberFilterOperandString");
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x060005E0 RID: 1504 RVA: 0x0001B7D3 File Offset: 0x000199D3
		public override global::Infragistics.ComparisonOperator? ComparisonOperatorValue
		{
			get
			{
				return new global::Infragistics.ComparisonOperator?(global::Infragistics.ComparisonOperator.DateTimeOctober);
			}
		}
	}
}
