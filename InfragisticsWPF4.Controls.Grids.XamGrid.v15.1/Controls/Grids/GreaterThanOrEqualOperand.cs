using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000CC RID: 204
	public class GreaterThanOrEqualOperand : global::Infragistics.Controls.Grids.FilterOperand
	{
		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000702 RID: 1794 RVA: 0x0001E116 File Offset: 0x0001C316
		public override global::Infragistics.ComparisonOperator? ComparisonOperatorValue
		{
			get
			{
				return new global::Infragistics.ComparisonOperator?(global::Infragistics.ComparisonOperator.GreaterThanOrEqual);
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000703 RID: 1795 RVA: 0x0001E11E File Offset: 0x0001C31E
		protected override string DefaultDisplayName
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("GreaterThanOrEqualsString");
			}
		}
	}
}
