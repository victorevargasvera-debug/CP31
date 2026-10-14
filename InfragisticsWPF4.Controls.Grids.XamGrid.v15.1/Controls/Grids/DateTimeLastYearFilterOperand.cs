using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000A2 RID: 162
	public class DateTimeLastYearFilterOperand : global::Infragistics.Controls.Grids.DateTimeNoInputBaseFilterOperand
	{
		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060005BD RID: 1469 RVA: 0x0001B680 File Offset: 0x00019880
		protected override string DefaultDisplayName
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("DateTimeLastYearFilterOperandString");
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060005BE RID: 1470 RVA: 0x0001B68C File Offset: 0x0001988C
		public override global::Infragistics.ComparisonOperator? ComparisonOperatorValue
		{
			get
			{
				return new global::Infragistics.ComparisonOperator?(global::Infragistics.ComparisonOperator.DateTimeLastYear);
			}
		}
	}
}
