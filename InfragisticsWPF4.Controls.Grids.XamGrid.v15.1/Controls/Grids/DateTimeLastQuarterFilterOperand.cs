using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200009F RID: 159
	public class DateTimeLastQuarterFilterOperand : global::Infragistics.Controls.Grids.DateTimeNoInputBaseFilterOperand
	{
		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060005B4 RID: 1460 RVA: 0x0001B629 File Offset: 0x00019829
		protected override string DefaultDisplayName
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("DateTimeLastQuarterFilterOperandString");
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060005B5 RID: 1461 RVA: 0x0001B635 File Offset: 0x00019835
		public override global::Infragistics.ComparisonOperator? ComparisonOperatorValue
		{
			get
			{
				return new global::Infragistics.ComparisonOperator?(global::Infragistics.ComparisonOperator.DateTimeLastQuarter);
			}
		}
	}
}
