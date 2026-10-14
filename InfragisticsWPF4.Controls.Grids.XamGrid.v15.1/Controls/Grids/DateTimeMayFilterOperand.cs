using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000A9 RID: 169
	public class DateTimeMayFilterOperand : global::Infragistics.Controls.Grids.DateTimeNoInputBaseFilterOperand
	{
		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060005D0 RID: 1488 RVA: 0x0001B736 File Offset: 0x00019936
		protected override string DefaultDisplayName
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("DateTimeMayFilterOperandString");
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x060005D1 RID: 1489 RVA: 0x0001B742 File Offset: 0x00019942
		public override global::Infragistics.ComparisonOperator? ComparisonOperatorValue
		{
			get
			{
				return new global::Infragistics.ComparisonOperator?(global::Infragistics.ComparisonOperator.DateTimeMay);
			}
		}
	}
}
