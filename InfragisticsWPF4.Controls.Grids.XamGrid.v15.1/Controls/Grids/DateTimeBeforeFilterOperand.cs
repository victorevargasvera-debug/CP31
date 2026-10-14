using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000093 RID: 147
	public class DateTimeBeforeFilterOperand : global::Infragistics.Controls.Grids.FilterOperand
	{
		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x0001B4CD File Offset: 0x000196CD
		protected override string DefaultDisplayName
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("DateTimeBeforeFilterOperandString");
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x0001B4D9 File Offset: 0x000196D9
		public override global::Infragistics.ComparisonOperator? ComparisonOperatorValue
		{
			get
			{
				return new global::Infragistics.ComparisonOperator?(global::Infragistics.ComparisonOperator.DateTimeBefore);
			}
		}
	}
}
