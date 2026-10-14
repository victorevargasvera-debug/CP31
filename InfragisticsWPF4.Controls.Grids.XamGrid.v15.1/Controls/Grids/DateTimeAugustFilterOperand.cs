using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000AC RID: 172
	public class DateTimeAugustFilterOperand : global::Infragistics.Controls.Grids.DateTimeNoInputBaseFilterOperand
	{
		// Token: 0x170001AD RID: 429
		// (get) Token: 0x060005D9 RID: 1497 RVA: 0x0001B78D File Offset: 0x0001998D
		protected override string DefaultDisplayName
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("DateTimeAugustFilterOperandString");
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x060005DA RID: 1498 RVA: 0x0001B799 File Offset: 0x00019999
		public override global::Infragistics.ComparisonOperator? ComparisonOperatorValue
		{
			get
			{
				return new global::Infragistics.ComparisonOperator?(global::Infragistics.ComparisonOperator.DateTimeAugust);
			}
		}
	}
}
