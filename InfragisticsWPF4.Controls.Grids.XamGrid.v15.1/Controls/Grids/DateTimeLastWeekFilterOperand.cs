using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000099 RID: 153
	public class DateTimeLastWeekFilterOperand : global::Infragistics.Controls.Grids.DateTimeNoInputBaseFilterOperand
	{
		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060005A2 RID: 1442 RVA: 0x0001B57B File Offset: 0x0001977B
		protected override string DefaultDisplayName
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("DateTimeLastWeekFilterOperandString");
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x0001B587 File Offset: 0x00019787
		public override global::Infragistics.ComparisonOperator? ComparisonOperatorValue
		{
			get
			{
				return new global::Infragistics.ComparisonOperator?(global::Infragistics.ComparisonOperator.DateTimeLastWeek);
			}
		}
	}
}
