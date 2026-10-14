using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020002A7 RID: 679
	[global::System.Flags]
	public enum SummaryDisplayAreas
	{
		// Token: 0x040010A4 RID: 4260
		None = 0,
		// Token: 0x040010A5 RID: 4261
		Top = 1,
		// Token: 0x040010A6 RID: 4262
		TopFixed = 2,
		// Token: 0x040010A7 RID: 4263
		Bottom = 4,
		// Token: 0x040010A8 RID: 4264
		BottomFixed = 8,
		// Token: 0x040010A9 RID: 4265
		TopLevelOnly = 16,
		// Token: 0x040010AA RID: 4266
		DataRecordsOnly = 32,
		// Token: 0x040010AB RID: 4267
		InGroupByRecords = 64
	}
}
