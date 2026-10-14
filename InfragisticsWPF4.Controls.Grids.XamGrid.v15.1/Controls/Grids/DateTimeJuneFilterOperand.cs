using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000AA RID: 170
	public class DateTimeJuneFilterOperand : global::Infragistics.Controls.Grids.DateTimeNoInputBaseFilterOperand
	{
		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060005D3 RID: 1491 RVA: 0x0001B753 File Offset: 0x00019953
		protected override string DefaultDisplayName
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("DateTimeJuneFilterOperandString");
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x060005D4 RID: 1492 RVA: 0x0001B75F File Offset: 0x0001995F
		public override global::Infragistics.ComparisonOperator? ComparisonOperatorValue
		{
			get
			{
				return new global::Infragistics.ComparisonOperator?(global::Infragistics.ComparisonOperator.DateTimeJune);
			}
		}
	}
}
