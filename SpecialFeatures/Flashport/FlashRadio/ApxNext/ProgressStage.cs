using System;

namespace SpecialFeatures.Flashport.FlashRadio.ApxNext
{
	// Token: 0x020000F8 RID: 248
	public enum ProgressStage
	{
		// Token: 0x04000748 RID: 1864
		BasicProgress,
		// Token: 0x04000749 RID: 1865
		FindValidDevice,
		// Token: 0x0400074A RID: 1866
		ConnectDone,
		// Token: 0x0400074B RID: 1867
		ValidateUserParams,
		// Token: 0x0400074C RID: 1868
		RadioSerialValidated,
		// Token: 0x0400074D RID: 1869
		ReadTheCodeplugStart,
		// Token: 0x0400074E RID: 1870
		UnpackTheCodeplug,
		// Token: 0x0400074F RID: 1871
		FlashingRadio,
		// Token: 0x04000750 RID: 1872
		FlashingRadioError,
		// Token: 0x04000751 RID: 1873
		UploadFirmware,
		// Token: 0x04000752 RID: 1874
		UploadFirmwareDone,
		// Token: 0x04000753 RID: 1875
		FirmwarePackageInvalid
	}
}
