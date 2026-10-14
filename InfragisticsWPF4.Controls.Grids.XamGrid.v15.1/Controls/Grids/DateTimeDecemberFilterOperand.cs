using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000B0 RID: 176
	public class DateTimeDecemberFilterOperand : global::Infragistics.Controls.Grids.DateTimeNoInputBaseFilterOperand
	{
		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x060005E5 RID: 1509 RVA: 0x0001B801 File Offset: 0x00019A01
		protected override string DefaultDisplayName
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("DateTimeDecemberFilterOperandString");
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x060005E6 RID: 1510 RVA: 0x0001B80D File Offset: 0x00019A0D
		public override global::Infragistics.ComparisonOperator? ComparisonOperatorValue
		{
			get
			{
				return new global::Infragistics.ComparisonOperator?(global::Infragistics.ComparisonOperator.DateTimeDecember);
			}
		}
	}
}
