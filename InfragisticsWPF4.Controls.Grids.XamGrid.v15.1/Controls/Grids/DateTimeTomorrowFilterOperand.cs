using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000095 RID: 149
	public class DateTimeTomorrowFilterOperand : global::Infragistics.Controls.Grids.DateTimeNoInputBaseFilterOperand
	{
		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000596 RID: 1430 RVA: 0x0001B507 File Offset: 0x00019707
		protected override string DefaultDisplayName
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("DateTimeTomorrowFilterOperandString");
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x0001B513 File Offset: 0x00019713
		public override global::Infragistics.ComparisonOperator? ComparisonOperatorValue
		{
			get
			{
				return new global::Infragistics.ComparisonOperator?(global::Infragistics.ComparisonOperator.DateTimeTomorrow);
			}
		}
	}
}
