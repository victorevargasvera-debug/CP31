using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000265 RID: 613
	[global::System.Flags]
	public enum SummaryDisplayAreas
	{
		// Token: 0x04000E40 RID: 3648
		None = 0,
		// Token: 0x04000E41 RID: 3649
		Top = 1,
		// Token: 0x04000E42 RID: 3650
		TopFixed = 2,
		// Token: 0x04000E43 RID: 3651
		Bottom = 4,
		// Token: 0x04000E44 RID: 3652
		BottomFixed = 8,
		// Token: 0x04000E45 RID: 3653
		TopLevelOnly = 16,
		// Token: 0x04000E46 RID: 3654
		DataRecordsOnly = 32,
		// Token: 0x04000E47 RID: 3655
		InGroupByRecords = 64
	}
}
