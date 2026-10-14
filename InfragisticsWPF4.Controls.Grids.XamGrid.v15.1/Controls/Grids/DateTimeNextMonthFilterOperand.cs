using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200009A RID: 154
	public class DateTimeNextMonthFilterOperand : global::Infragistics.Controls.Grids.DateTimeNoInputBaseFilterOperand
	{
		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x0001B598 File Offset: 0x00019798
		protected override string DefaultDisplayName
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("DateTimeNextMonthFilterOperandString");
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060005A6 RID: 1446 RVA: 0x0001B5A4 File Offset: 0x000197A4
		public override global::Infragistics.ComparisonOperator? ComparisonOperatorValue
		{
			get
			{
				return new global::Infragistics.ComparisonOperator?(global::Infragistics.ComparisonOperator.DateTimeNextMonth);
			}
		}
	}
}
