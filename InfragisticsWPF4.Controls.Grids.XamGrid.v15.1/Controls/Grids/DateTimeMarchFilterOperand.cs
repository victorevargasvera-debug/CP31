using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000A7 RID: 167
	public class DateTimeMarchFilterOperand : global::Infragistics.Controls.Grids.DateTimeNoInputBaseFilterOperand
	{
		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060005CA RID: 1482 RVA: 0x0001B6FC File Offset: 0x000198FC
		protected override string DefaultDisplayName
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("DateTimeMarchFilterOperandString");
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x0001B708 File Offset: 0x00019908
		public override global::Infragistics.ComparisonOperator? ComparisonOperatorValue
		{
			get
			{
				return new global::Infragistics.ComparisonOperator?(global::Infragistics.ComparisonOperator.DateTimeMarch);
			}
		}
	}
}
