using System;

namespace SpecialFeatures.Flashport.FlashRadio
{
	// Token: 0x020000E3 RID: 227
	public enum UserState
	{
		// Token: 0x040006E5 RID: 1765
		ConnectStart,
		// Token: 0x040006E6 RID: 1766
		ConnectError,
		// Token: 0x040006E7 RID: 1767
		ConnectDone,
		// Token: 0x040006E8 RID: 1768
		ReadRadInfoStart,
		// Token: 0x040006E9 RID: 1769
		ReadRadInfoError,
		// Token: 0x040006EA RID: 1770
		ReadRadInfoDone,
		// Token: 0x040006EB RID: 1771
		CodeplugStart,
		// Token: 0x040006EC RID: 1772
		CodeplugError,
		// Token: 0x040006ED RID: 1773
		CodeplugDone,
		// Token: 0x040006EE RID: 1774
		FlashingComponentStart,
		// Token: 0x040006EF RID: 1775
		FlashingComponentError,
		// Token: 0x040006F0 RID: 1776
		FlashingComponentDone,
		// Token: 0x040006F1 RID: 1777
		FinalValidationStart,
		// Token: 0x040006F2 RID: 1778
		FinalValidationError,
		// Token: 0x040006F3 RID: 1779
		FinalValidationDone,
		// Token: 0x040006F4 RID: 1780
		UploadFirmwareStart,
		// Token: 0x040006F5 RID: 1781
		UploadFirmwareDone,
		// Token: 0x040006F6 RID: 1782
		UploadFirmwareError,
		// Token: 0x040006F7 RID: 1783
		FirmwarePackageInvalid,
		// Token: 0x040006F8 RID: 1784
		None
	}
}
