using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000D5 RID: 213
	public class InOperand : global::Infragistics.Controls.Grids.FilterOperand
	{
		// Token: 0x17000234 RID: 564
		// (get) Token: 0x0600071D RID: 1821 RVA: 0x0001E215 File Offset: 0x0001C415
		public override global::Infragistics.ComparisonOperator? ComparisonOperatorValue
		{
			get
			{
				return new global::Infragistics.ComparisonOperator?(global::Infragistics.ComparisonOperator.InOperand);
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x0001E21E File Offset: 0x0001C41E
		protected override string DefaultDisplayName
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("InOperandString");
			}
		}
	}
}
