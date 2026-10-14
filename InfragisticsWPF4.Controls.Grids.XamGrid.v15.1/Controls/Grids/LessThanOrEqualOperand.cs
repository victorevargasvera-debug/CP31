using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000CE RID: 206
	public class LessThanOrEqualOperand : global::Infragistics.Controls.Grids.FilterOperand
	{
		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000708 RID: 1800 RVA: 0x0001E14E File Offset: 0x0001C34E
		public override global::Infragistics.ComparisonOperator? ComparisonOperatorValue
		{
			get
			{
				return new global::Infragistics.ComparisonOperator?(global::Infragistics.ComparisonOperator.LessThanOrEqual);
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000709 RID: 1801 RVA: 0x0001E156 File Offset: 0x0001C356
		protected override string DefaultDisplayName
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("LessThanOrEqualsString");
			}
		}
	}
}
