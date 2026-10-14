using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000CD RID: 205
	public class LessThanOperand : global::Infragistics.Controls.Grids.FilterOperand
	{
		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000705 RID: 1797 RVA: 0x0001E132 File Offset: 0x0001C332
		public override global::Infragistics.ComparisonOperator? ComparisonOperatorValue
		{
			get
			{
				return new global::Infragistics.ComparisonOperator?(global::Infragistics.ComparisonOperator.LessThan);
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000706 RID: 1798 RVA: 0x0001E13A File Offset: 0x0001C33A
		protected override string DefaultDisplayName
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("LessThanString");
			}
		}
	}
}
