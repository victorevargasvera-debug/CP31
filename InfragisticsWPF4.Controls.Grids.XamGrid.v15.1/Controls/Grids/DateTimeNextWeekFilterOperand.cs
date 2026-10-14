using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000097 RID: 151
	public class DateTimeNextWeekFilterOperand : global::Infragistics.Controls.Grids.DateTimeNoInputBaseFilterOperand
	{
		// Token: 0x17000185 RID: 389
		// (get) Token: 0x0600059C RID: 1436 RVA: 0x0001B541 File Offset: 0x00019741
		protected override string DefaultDisplayName
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("DateTimeNextWeekFilterOperandString");
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x0600059D RID: 1437 RVA: 0x0001B54D File Offset: 0x0001974D
		public override global::Infragistics.ComparisonOperator? ComparisonOperatorValue
		{
			get
			{
				return new global::Infragistics.ComparisonOperator?(global::Infragistics.ComparisonOperator.DateTimeNextWeek);
			}
		}
	}
}
