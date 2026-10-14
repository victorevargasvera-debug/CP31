using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000D2 RID: 210
	public class DoesNotContainOperand : global::Infragistics.Controls.Grids.FilterOperand
	{
		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x0001E1BF File Offset: 0x0001C3BF
		public override global::Infragistics.ComparisonOperator? ComparisonOperatorValue
		{
			get
			{
				return new global::Infragistics.ComparisonOperator?(global::Infragistics.ComparisonOperator.DoesNotContain);
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000715 RID: 1813 RVA: 0x0001E1C8 File Offset: 0x0001C3C8
		protected override string DefaultDisplayName
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("DoesNotContainString");
			}
		}
	}
}
