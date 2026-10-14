using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000A8 RID: 168
	public class DateTimeAprilFilterOperand : global::Infragistics.Controls.Grids.DateTimeNoInputBaseFilterOperand
	{
		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060005CD RID: 1485 RVA: 0x0001B719 File Offset: 0x00019919
		protected override string DefaultDisplayName
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("DateTimeAprilFilterOperandString");
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060005CE RID: 1486 RVA: 0x0001B725 File Offset: 0x00019925
		public override global::Infragistics.ComparisonOperator? ComparisonOperatorValue
		{
			get
			{
				return new global::Infragistics.ComparisonOperator?(global::Infragistics.ComparisonOperator.DateTimeApril);
			}
		}
	}
}
