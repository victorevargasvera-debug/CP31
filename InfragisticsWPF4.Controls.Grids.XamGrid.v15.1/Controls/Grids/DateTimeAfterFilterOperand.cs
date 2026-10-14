using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000092 RID: 146
	public class DateTimeAfterFilterOperand : global::Infragistics.Controls.Grids.FilterOperand
	{
		// Token: 0x1700017B RID: 379
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x0001B4B0 File Offset: 0x000196B0
		protected override string DefaultDisplayName
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("DateTimeAfterFilterOperandString");
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x0600058E RID: 1422 RVA: 0x0001B4BC File Offset: 0x000196BC
		public override global::Infragistics.ComparisonOperator? ComparisonOperatorValue
		{
			get
			{
				return new global::Infragistics.ComparisonOperator?(global::Infragistics.ComparisonOperator.DateTimeAfter);
			}
		}
	}
}
