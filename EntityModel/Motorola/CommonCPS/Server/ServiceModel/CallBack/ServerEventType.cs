using System;

namespace Motorola.CommonCPS.Server.ServiceModel.CallBack
{
	// Token: 0x0200000D RID: 13
	[global::System.Serializable]
	public enum ServerEventType
	{
		// Token: 0x04000018 RID: 24
		JobCreated,
		// Token: 0x04000019 RID: 25
		JobChanged,
		// Token: 0x0400001A RID: 26
		JobDeleted,
		// Token: 0x0400001B RID: 27
		APXRadioSummaryChanged,
		// Token: 0x0400001C RID: 28
		APXRadioSummaryDeleted,
		// Token: 0x0400001D RID: 29
		MatrixRadioSummaryChanged,
		// Token: 0x0400001E RID: 30
		MatrixRadioSummaryDeleted,
		// Token: 0x0400001F RID: 31
		PBBRadioSummaryChanged,
		// Token: 0x04000020 RID: 32
		PBBRadioSummaryDeleted,
		// Token: 0x04000021 RID: 33
		BatchOpJobViewSummaryChanged,
		// Token: 0x04000022 RID: 34
		JobContainerSummaryCreated,
		// Token: 0x04000023 RID: 35
		JobContainerSummaryChanged,
		// Token: 0x04000024 RID: 36
		JobContainerSummaryDeleted,
		// Token: 0x04000025 RID: 37
		PropertyChanged,
		// Token: 0x04000026 RID: 38
		OTAPKeyChanged,
		// Token: 0x04000027 RID: 39
		DBMigrationEvent,
		// Token: 0x04000028 RID: 40
		ConversionEvent,
		// Token: 0x04000029 RID: 41
		DBSizeChangedEvent,
		// Token: 0x0400002A RID: 42
		OTAPKeyCreated,
		// Token: 0x0400002B RID: 43
		OTAPKeyDeleted,
		// Token: 0x0400002C RID: 44
		PBBRadioDeleted,
		// Token: 0x0400002D RID: 45
		PBBPasswordChanged,
		// Token: 0x0400002E RID: 46
		None
	}
}
