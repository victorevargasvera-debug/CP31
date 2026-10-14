using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000C9 RID: 201
	public class EqualsOperand : global::Infragistics.Controls.Grids.FilterOperand
	{
		// Token: 0x1700021C RID: 540
		// (get) Token: 0x060006F9 RID: 1785 RVA: 0x0001E0C2 File Offset: 0x0001C2C2
		protected override string DefaultDisplayName
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("EqualsString");
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060006FA RID: 1786 RVA: 0x0001E0CE File Offset: 0x0001C2CE
		public override global::Infragistics.ComparisonOperator? ComparisonOperatorValue
		{
			get
			{
				return new global::Infragistics.ComparisonOperator?(global::Infragistics.ComparisonOperator.Equals);
			}
		}
	}
}
