using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200009D RID: 157
	public class DateTimeNextQuarterFilterOperand : global::Infragistics.Controls.Grids.DateTimeNoInputBaseFilterOperand
	{
		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060005AE RID: 1454 RVA: 0x0001B5EF File Offset: 0x000197EF
		protected override string DefaultDisplayName
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("DateTimeNextQuarterFilterOperandString");
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x0001B5FB File Offset: 0x000197FB
		public override global::Infragistics.ComparisonOperator? ComparisonOperatorValue
		{
			get
			{
				return new global::Infragistics.ComparisonOperator?(global::Infragistics.ComparisonOperator.DateTimeNextQuarter);
			}
		}
	}
}
