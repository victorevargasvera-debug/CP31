using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000AD RID: 173
	public class DateTimeSeptemberFilterOperand : global::Infragistics.Controls.Grids.DateTimeNoInputBaseFilterOperand
	{
		// Token: 0x170001AF RID: 431
		// (get) Token: 0x060005DC RID: 1500 RVA: 0x0001B7AA File Offset: 0x000199AA
		protected override string DefaultDisplayName
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("DateTimeSeptemberFilterOperandString");
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x060005DD RID: 1501 RVA: 0x0001B7B6 File Offset: 0x000199B6
		public override global::Infragistics.ComparisonOperator? ComparisonOperatorValue
		{
			get
			{
				return new global::Infragistics.ComparisonOperator?(global::Infragistics.ComparisonOperator.DateTimeSeptember);
			}
		}
	}
}
