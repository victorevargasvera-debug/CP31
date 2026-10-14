using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000A1 RID: 161
	public class DateTimeThisYearFilterOperand : global::Infragistics.Controls.Grids.DateTimeNoInputBaseFilterOperand
	{
		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060005BA RID: 1466 RVA: 0x0001B663 File Offset: 0x00019863
		protected override string DefaultDisplayName
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("DateTimeThisYearFilterOperandString");
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060005BB RID: 1467 RVA: 0x0001B66F File Offset: 0x0001986F
		public override global::Infragistics.ComparisonOperator? ComparisonOperatorValue
		{
			get
			{
				return new global::Infragistics.ComparisonOperator?(global::Infragistics.ComparisonOperator.DateTimeThisYear);
			}
		}
	}
}
