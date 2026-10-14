using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000264 RID: 612
	[global::System.Flags]
	public enum States : long
	{
		// Token: 0x04000E1F RID: 3615
		ItemsSelected = 1L,
		// Token: 0x04000E20 RID: 3616
		Records = 2L,
		// Token: 0x04000E21 RID: 3617
		Record = 4L,
		// Token: 0x04000E22 RID: 3618
		RecordExpandable = 8L,
		// Token: 0x04000E23 RID: 3619
		RecordExpanded = 16L,
		// Token: 0x04000E24 RID: 3620
		RecordFirstDisplayed = 32L,
		// Token: 0x04000E25 RID: 3621
		RecordLastDisplayed = 64L,
		// Token: 0x04000E26 RID: 3622
		RecordFirstOverall = 128L,
		// Token: 0x04000E27 RID: 3623
		RecordLastOverall = 256L,
		// Token: 0x04000E28 RID: 3624
		GroupByRecord = 512L,
		// Token: 0x04000E29 RID: 3625
		ExpandableFieldRecord = 1024L,
		// Token: 0x04000E2A RID: 3626
		Cell = 2048L,
		// Token: 0x04000E2B RID: 3627
		CellFirstInRecord = 4096L,
		// Token: 0x04000E2C RID: 3628
		CellLastInRecord = 8192L,
		// Token: 0x04000E2D RID: 3629
		CellFirstDisplayed = 16384L,
		// Token: 0x04000E2E RID: 3630
		CellLastDisplayed = 32768L,
		// Token: 0x04000E2F RID: 3631
		CellFirstOverall = 65536L,
		// Token: 0x04000E30 RID: 3632
		CellLastOverall = 131072L,
		// Token: 0x04000E31 RID: 3633
		NavigationLayoutStyleGridViewVertical = 262144L,
		// Token: 0x04000E32 RID: 3634
		NavigationLayoutStyleGridViewHorizontal = 524288L,
		// Token: 0x04000E33 RID: 3635
		IsInEditMode = 1048576L,
		// Token: 0x04000E34 RID: 3636
		DataRecordsSelected = 2097152L,
		// Token: 0x04000E35 RID: 3637
		RecordHasPendingChanges = 4194304L,
		// Token: 0x04000E36 RID: 3638
		FilterCell = 8388608L,
		// Token: 0x04000E37 RID: 3639
		FilterCellHasActiveFilters = 16777216L,
		// Token: 0x04000E38 RID: 3640
		FilterRecord = 33554432L,
		// Token: 0x04000E39 RID: 3641
		FilterRecordHasActiveFilters = 67108864L,
		// Token: 0x04000E3A RID: 3642
		CellsSelected = 134217728L,
		// Token: 0x04000E3B RID: 3643
		NavigationLayoutStyleCardViewVertical = 268435456L,
		// Token: 0x04000E3C RID: 3644
		NavigationLayoutStyleCardViewHorizontal = 536870912L,
		// Token: 0x04000E3D RID: 3645
		IsExporting = 1073741824L,
		// Token: 0x04000E3E RID: 3646
		IsExportingInitializing = 1073741824L
	}
}
