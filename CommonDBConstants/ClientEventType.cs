using System;

namespace Motorola.CommonCPS.Server.CommonDBConstants
{
	// Token: 0x02000019 RID: 25
	public enum ClientEventType
	{
		// Token: 0x040000C4 RID: 196
		JobCreated,
		// Token: 0x040000C5 RID: 197
		JobChanged,
		// Token: 0x040000C6 RID: 198
		JobDeleted,
		// Token: 0x040000C7 RID: 199
		APXRadioSummaryChanged,
		// Token: 0x040000C8 RID: 200
		APXRadioSummaryDeleted,
		// Token: 0x040000C9 RID: 201
		MatrixRadioSummaryChanged,
		// Token: 0x040000CA RID: 202
		MatrixRadioSummaryDeleted,
		// Token: 0x040000CB RID: 203
		PBBRadioSummaryChanged,
		// Token: 0x040000CC RID: 204
		PBBRadioSummaryDeleted,
		// Token: 0x040000CD RID: 205
		BatchOpJobViewSummaryChanged,
		// Token: 0x040000CE RID: 206
		JobContainerSummaryCreated,
		// Token: 0x040000CF RID: 207
		JobContainerSummaryChanged,
		// Token: 0x040000D0 RID: 208
		JobContainerSummaryDeleted,
		// Token: 0x040000D1 RID: 209
		PropertyChanged,
		// Token: 0x040000D2 RID: 210
		OTAPKeyChanged,
		// Token: 0x040000D3 RID: 211
		DBMigrationEvent,
		// Token: 0x040000D4 RID: 212
		ConversionEvent,
		// Token: 0x040000D5 RID: 213
		DBSizeChangedEvent,
		// Token: 0x040000D6 RID: 214
		OfflineJobForceRemoveWhileImportExport,
		// Token: 0x040000D7 RID: 215
		JobCancelled,
		// Token: 0x040000D8 RID: 216
		JobExpired,
		// Token: 0x040000D9 RID: 217
		JobRunning,
		// Token: 0x040000DA RID: 218
		JobPending,
		// Token: 0x040000DB RID: 219
		PBBRadioDeleted,
		// Token: 0x040000DC RID: 220
		PBBPasswordChanged
	}
}
