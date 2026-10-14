using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200009E RID: 158
	public class DateTimeThisQuarterFilterOperand : global::Infragistics.Controls.Grids.DateTimeNoInputBaseFilterOperand
	{
		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060005B1 RID: 1457 RVA: 0x0001B60C File Offset: 0x0001980C
		protected override string DefaultDisplayName
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("DateTimeThisQuarterFilterOperandString");
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060005B2 RID: 1458 RVA: 0x0001B618 File Offset: 0x00019818
		public override global::Infragistics.ComparisonOperator? ComparisonOperatorValue
		{
			get
			{
				return new global::Infragistics.ComparisonOperator?(global::Infragistics.ComparisonOperator.DateTimeThisQuarter);
			}
		}
	}
}
