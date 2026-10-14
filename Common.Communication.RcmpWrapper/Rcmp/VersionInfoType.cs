using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000059 RID: 89
	public enum VersionInfoType : byte
	{
		// Token: 0x0400017E RID: 382
		HostSoftwareVersion,
		// Token: 0x0400017F RID: 383
		BBFBundleVersion = 2,
		// Token: 0x04000180 RID: 384
		PendingBBFBundleVersion,
		// Token: 0x04000181 RID: 385
		CPRequiredFwVer,
		// Token: 0x04000182 RID: 386
		TlsPskPortNumber = 9,
		// Token: 0x04000183 RID: 387
		DspSoftwareVersion = 16,
		// Token: 0x04000184 RID: 388
		DspCapability,
		// Token: 0x04000185 RID: 389
		DTPCapability = 19,
		// Token: 0x04000186 RID: 390
		MaceFlashVersion = 34,
		// Token: 0x04000187 RID: 391
		MaceHardwareVersion = 36,
		// Token: 0x04000188 RID: 392
		MaceHardwareType,
		// Token: 0x04000189 RID: 393
		FlashBootAppVersion = 48,
		// Token: 0x0400018A RID: 394
		RamdownloaderVersion = 50,
		// Token: 0x0400018B RID: 395
		L3BootloaderVersion = 53,
		// Token: 0x0400018C RID: 396
		TuneVersion = 64,
		// Token: 0x0400018D RID: 397
		SecurityVersion,
		// Token: 0x0400018E RID: 398
		CodeplugVersion,
		// Token: 0x0400018F RID: 399
		CodeplugSessionID = 75,
		// Token: 0x04000190 RID: 400
		PsdtVersion = 80,
		// Token: 0x04000191 RID: 401
		ConfigurationVersion,
		// Token: 0x04000192 RID: 402
		KernelVersion,
		// Token: 0x04000193 RID: 403
		FlashSize = 109,
		// Token: 0x04000194 RID: 404
		OptionBoardFirmwareVersion = 129,
		// Token: 0x04000195 RID: 405
		OptionBoardName,
		// Token: 0x04000196 RID: 406
		OptionBoardHardwareType = 132,
		// Token: 0x04000197 RID: 407
		OptionBoardMainAppVersion,
		// Token: 0x04000198 RID: 408
		OptionBoardFlashImageType = 135,
		// Token: 0x04000199 RID: 409
		OptionBoardFlashImageVersion,
		// Token: 0x0400019A RID: 410
		ConsoletteBrdHwType = 164,
		// Token: 0x0400019B RID: 411
		ConsoletteBrdHostVer,
		// Token: 0x0400019C RID: 412
		FPGAControllerAlternativeVersion = 176,
		// Token: 0x0400019D RID: 413
		FPGAControllerFactoryVersion,
		// Token: 0x0400019E RID: 414
		FPGAControllerActiveVersion,
		// Token: 0x0400019F RID: 415
		FPGAWirelineAlternativeVersion,
		// Token: 0x040001A0 RID: 416
		FPGAWirelineFactoryVersion,
		// Token: 0x040001A1 RID: 417
		FPGAWirelineActiveVersion
	}
}
