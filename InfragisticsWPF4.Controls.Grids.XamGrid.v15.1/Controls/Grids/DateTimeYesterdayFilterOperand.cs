using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000096 RID: 150
	public class DateTimeYesterdayFilterOperand : global::Infragistics.Controls.Grids.DateTimeNoInputBaseFilterOperand
	{
		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x0001B524 File Offset: 0x00019724
		protected override string DefaultDisplayName
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("DateTimeYesterdayFilterOperandString");
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x0600059A RID: 1434 RVA: 0x0001B530 File Offset: 0x00019730
		public override global::Infragistics.ComparisonOperator? ComparisonOperatorValue
		{
			get
			{
				return new global::Infragistics.ComparisonOperator?(global::Infragistics.ComparisonOperator.DateTimeYesterday);
			}
		}
	}
}
