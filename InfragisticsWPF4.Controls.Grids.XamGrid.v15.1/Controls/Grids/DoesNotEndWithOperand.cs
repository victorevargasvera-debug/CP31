using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000D4 RID: 212
	public class DoesNotEndWithOperand : global::Infragistics.Controls.Grids.FilterOperand
	{
		// Token: 0x17000232 RID: 562
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x0001E1F8 File Offset: 0x0001C3F8
		public override global::Infragistics.ComparisonOperator? ComparisonOperatorValue
		{
			get
			{
				return new global::Infragistics.ComparisonOperator?(global::Infragistics.ComparisonOperator.DoesNotEndWith);
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x0600071B RID: 1819 RVA: 0x0001E201 File Offset: 0x0001C401
		protected override string DefaultDisplayName
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("DoesNotEndWithString");
			}
		}
	}
}
