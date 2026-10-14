using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000CF RID: 207
	public class StartsWithOperand : global::Infragistics.Controls.Grids.FilterOperand
	{
		// Token: 0x17000228 RID: 552
		// (get) Token: 0x0600070B RID: 1803 RVA: 0x0001E16A File Offset: 0x0001C36A
		public override global::Infragistics.ComparisonOperator? ComparisonOperatorValue
		{
			get
			{
				return new global::Infragistics.ComparisonOperator?(global::Infragistics.ComparisonOperator.StartsWith);
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x0600070C RID: 1804 RVA: 0x0001E172 File Offset: 0x0001C372
		protected override string DefaultDisplayName
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("StartsWithString");
			}
		}
	}
}
