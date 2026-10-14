using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000D0 RID: 208
	public class EndsWithOperand : global::Infragistics.Controls.Grids.FilterOperand
	{
		// Token: 0x1700022A RID: 554
		// (get) Token: 0x0600070E RID: 1806 RVA: 0x0001E186 File Offset: 0x0001C386
		public override global::Infragistics.ComparisonOperator? ComparisonOperatorValue
		{
			get
			{
				return new global::Infragistics.ComparisonOperator?(global::Infragistics.ComparisonOperator.EndsWith);
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x0600070F RID: 1807 RVA: 0x0001E18E File Offset: 0x0001C38E
		protected override string DefaultDisplayName
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("EndsWithString");
			}
		}
	}
}
