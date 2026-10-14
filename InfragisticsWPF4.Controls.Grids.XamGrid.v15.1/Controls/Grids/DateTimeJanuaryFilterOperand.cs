using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000A5 RID: 165
	public class DateTimeJanuaryFilterOperand : global::Infragistics.Controls.Grids.DateTimeNoInputBaseFilterOperand
	{
		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060005C4 RID: 1476 RVA: 0x0001B6C2 File Offset: 0x000198C2
		protected override string DefaultDisplayName
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("DateTimeJanuaryFilterOperandString");
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060005C5 RID: 1477 RVA: 0x0001B6CE File Offset: 0x000198CE
		public override global::Infragistics.ComparisonOperator? ComparisonOperatorValue
		{
			get
			{
				return new global::Infragistics.ComparisonOperator?(global::Infragistics.ComparisonOperator.DateTimeJanuary);
			}
		}
	}
}
