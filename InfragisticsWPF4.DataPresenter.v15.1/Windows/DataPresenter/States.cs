using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020002A6 RID: 678
	[global::System.Flags]
	public enum States : long
	{
		// Token: 0x04001081 RID: 4225
		ItemsSelected = 1L,
		// Token: 0x04001082 RID: 4226
		Records = 2L,
		// Token: 0x04001083 RID: 4227
		Record = 4L,
		// Token: 0x04001084 RID: 4228
		RecordExpandable = 8L,
		// Token: 0x04001085 RID: 4229
		RecordExpanded = 16L,
		// Token: 0x04001086 RID: 4230
		RecordFirstDisplayed = 32L,
		// Token: 0x04001087 RID: 4231
		RecordLastDisplayed = 64L,
		// Token: 0x04001088 RID: 4232
		RecordFirstOverall = 128L,
		// Token: 0x04001089 RID: 4233
		RecordLastOverall = 256L,
		// Token: 0x0400108A RID: 4234
		GroupByRecord = 512L,
		// Token: 0x0400108B RID: 4235
		ExpandableFieldRecord = 1024L,
		// Token: 0x0400108C RID: 4236
		Cell = 2048L,
		// Token: 0x0400108D RID: 4237
		CellFirstInRecord = 4096L,
		// Token: 0x0400108E RID: 4238
		CellLastInRecord = 8192L,
		// Token: 0x0400108F RID: 4239
		CellFirstDisplayed = 16384L,
		// Token: 0x04001090 RID: 4240
		CellLastDisplayed = 32768L,
		// Token: 0x04001091 RID: 4241
		CellFirstOverall = 65536L,
		// Token: 0x04001092 RID: 4242
		CellLastOverall = 131072L,
		// Token: 0x04001093 RID: 4243
		NavigationLayoutStyleGridViewVertical = 262144L,
		// Token: 0x04001094 RID: 4244
		NavigationLayoutStyleGridViewHorizontal = 524288L,
		// Token: 0x04001095 RID: 4245
		IsInEditMode = 1048576L,
		// Token: 0x04001096 RID: 4246
		DataRecordsSelected = 2097152L,
		// Token: 0x04001097 RID: 4247
		RecordHasPendingChanges = 4194304L,
		// Token: 0x04001098 RID: 4248
		FilterCell = 8388608L,
		// Token: 0x04001099 RID: 4249
		FilterCellHasActiveFilters = 16777216L,
		// Token: 0x0400109A RID: 4250
		FilterRecord = 33554432L,
		// Token: 0x0400109B RID: 4251
		FilterRecordHasActiveFilters = 67108864L,
		// Token: 0x0400109C RID: 4252
		CellsSelected = 134217728L,
		// Token: 0x0400109D RID: 4253
		NavigationLayoutStyleCardViewVertical = 268435456L,
		// Token: 0x0400109E RID: 4254
		NavigationLayoutStyleCardViewHorizontal = 536870912L,
		// Token: 0x0400109F RID: 4255
		IsExporting = 1073741824L,
		// Token: 0x040010A0 RID: 4256
		IsExportingInitializing = 2147483648L,
		// Token: 0x040010A1 RID: 4257
		EditorAcceptsArrowKeys = 4294967296L,
		// Token: 0x040010A2 RID: 4258
		CanFlipOrientation = 8589934592L
	}
}
