using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000CA RID: 202
	public class NotEqualsOperand : global::Infragistics.Controls.Grids.FilterOperand
	{
		// Token: 0x1700021E RID: 542
		// (get) Token: 0x060006FC RID: 1788 RVA: 0x0001E0DE File Offset: 0x0001C2DE
		public override global::Infragistics.ComparisonOperator? ComparisonOperatorValue
		{
			get
			{
				return new global::Infragistics.ComparisonOperator?(global::Infragistics.ComparisonOperator.NotEquals);
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x060006FD RID: 1789 RVA: 0x0001E0E6 File Offset: 0x0001C2E6
		protected override string DefaultDisplayName
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("NotEqualsString");
			}
		}
	}
}
