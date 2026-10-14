using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000AF RID: 175
	public class DateTimeNovemberFilterOperand : global::Infragistics.Controls.Grids.DateTimeNoInputBaseFilterOperand
	{
		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x060005E2 RID: 1506 RVA: 0x0001B7E4 File Offset: 0x000199E4
		protected override string DefaultDisplayName
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("DateTimeNovemberFilterOperandString");
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x060005E3 RID: 1507 RVA: 0x0001B7F0 File Offset: 0x000199F0
		public override global::Infragistics.ComparisonOperator? ComparisonOperatorValue
		{
			get
			{
				return new global::Infragistics.ComparisonOperator?(global::Infragistics.ComparisonOperator.DateTimeNovember);
			}
		}
	}
}
