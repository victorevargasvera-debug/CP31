using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000094 RID: 148
	public class DateTimeTodayFilterOperand : global::Infragistics.Controls.Grids.DateTimeNoInputBaseFilterOperand
	{
		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x0001B4EA File Offset: 0x000196EA
		protected override string DefaultDisplayName
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("DateTimeTodayFilterOperandString");
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x0001B4F6 File Offset: 0x000196F6
		public override global::Infragistics.ComparisonOperator? ComparisonOperatorValue
		{
			get
			{
				return new global::Infragistics.ComparisonOperator?(global::Infragistics.ComparisonOperator.DateTimeToday);
			}
		}
	}
}
