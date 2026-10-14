using System;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x020004BF RID: 1215
	public enum ObjectKind : short
	{
		// Token: 0x04001402 RID: 5122
		AxisGroup,
		// Token: 0x04001403 RID: 5123
		AttachedLabelRecord = 2,
		// Token: 0x04001404 RID: 5124
		Axis = 4,
		// Token: 0x04001405 RID: 5125
		ChartGroup,
		// Token: 0x04001406 RID: 5126
		DatRecord,
		// Token: 0x04001407 RID: 5127
		Frame,
		// Token: 0x04001408 RID: 5128
		Legend = 9,
		// Token: 0x04001409 RID: 5129
		LegendException,
		// Token: 0x0400140A RID: 5130
		Series = 12,
		// Token: 0x0400140B RID: 5131
		Sheet,
		// Token: 0x0400140C RID: 5132
		DataFormatRecord,
		// Token: 0x0400140D RID: 5133
		DropBarRecord
	}
}
