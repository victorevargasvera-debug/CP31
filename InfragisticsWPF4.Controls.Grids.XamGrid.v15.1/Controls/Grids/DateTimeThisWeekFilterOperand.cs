using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000098 RID: 152
	public class DateTimeThisWeekFilterOperand : global::Infragistics.Controls.Grids.DateTimeNoInputBaseFilterOperand
	{
		// Token: 0x17000187 RID: 391
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x0001B55E File Offset: 0x0001975E
		protected override string DefaultDisplayName
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("DateTimeThisWeekFilterOperandString");
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060005A0 RID: 1440 RVA: 0x0001B56A File Offset: 0x0001976A
		public override global::Infragistics.ComparisonOperator? ComparisonOperatorValue
		{
			get
			{
				return new global::Infragistics.ComparisonOperator?(global::Infragistics.ComparisonOperator.DateTimeThisWeek);
			}
		}
	}
}
