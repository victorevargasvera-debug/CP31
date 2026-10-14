using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000CB RID: 203
	public class GreaterThanOperand : global::Infragistics.Controls.Grids.FilterOperand
	{
		// Token: 0x17000220 RID: 544
		// (get) Token: 0x060006FF RID: 1791 RVA: 0x0001E0FA File Offset: 0x0001C2FA
		protected override string DefaultDisplayName
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("GreaterThanString");
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000700 RID: 1792 RVA: 0x0001E106 File Offset: 0x0001C306
		public override global::Infragistics.ComparisonOperator? ComparisonOperatorValue
		{
			get
			{
				return new global::Infragistics.ComparisonOperator?(global::Infragistics.ComparisonOperator.GreaterThan);
			}
		}
	}
}
