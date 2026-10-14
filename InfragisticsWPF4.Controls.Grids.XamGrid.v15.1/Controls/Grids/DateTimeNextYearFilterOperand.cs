using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000A0 RID: 160
	public class DateTimeNextYearFilterOperand : global::Infragistics.Controls.Grids.DateTimeNoInputBaseFilterOperand
	{
		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x0001B646 File Offset: 0x00019846
		protected override string DefaultDisplayName
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("DateTimeNextYearFilterOperandString");
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060005B8 RID: 1464 RVA: 0x0001B652 File Offset: 0x00019852
		public override global::Infragistics.ComparisonOperator? ComparisonOperatorValue
		{
			get
			{
				return new global::Infragistics.ComparisonOperator?(global::Infragistics.ComparisonOperator.DateTimeNextYear);
			}
		}
	}
}
