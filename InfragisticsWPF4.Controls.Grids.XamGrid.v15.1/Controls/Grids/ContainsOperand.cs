using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000D1 RID: 209
	public class ContainsOperand : global::Infragistics.Controls.Grids.FilterOperand
	{
		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000711 RID: 1809 RVA: 0x0001E1A2 File Offset: 0x0001C3A2
		public override global::Infragistics.ComparisonOperator? ComparisonOperatorValue
		{
			get
			{
				return new global::Infragistics.ComparisonOperator?(global::Infragistics.ComparisonOperator.Contains);
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000712 RID: 1810 RVA: 0x0001E1AB File Offset: 0x0001C3AB
		protected override string DefaultDisplayName
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("ContainsString");
			}
		}
	}
}
