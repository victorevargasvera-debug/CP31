using System;

namespace SpecialFeatures.Flashport.FlashRadio
{
	// Token: 0x020000EA RID: 234
	internal enum UpgradeRadioResult
	{
		// Token: 0x0400071F RID: 1823
		Success,
		// Token: 0x04000720 RID: 1824
		RadioNotSupported,
		// Token: 0x04000721 RID: 1825
		InvalidUpgradeFileContents,
		// Token: 0x04000722 RID: 1826
		ValidFlashkeyNotFound,
		// Token: 0x04000723 RID: 1827
		NoUpgradesLeftInFlashkey,
		// Token: 0x04000724 RID: 1828
		FlashkeyValidationFailed,
		// Token: 0x04000725 RID: 1829
		ModelNumberValidationFailed,
		// Token: 0x04000726 RID: 1830
		FlashcodeValidationFailed,
		// Token: 0x04000727 RID: 1831
		FlashRadioFailed,
		// Token: 0x04000728 RID: 1832
		CodeplugUpdateFailed,
		// Token: 0x04000729 RID: 1833
		GetRadioParametersFailed,
		// Token: 0x0400072A RID: 1834
		UpgradeFileNotFound,
		// Token: 0x0400072B RID: 1835
		SerialNumberValidationFailed,
		// Token: 0x0400072C RID: 1836
		CBISerialNumber,
		// Token: 0x0400072D RID: 1837
		UpgradeRadioFailed
	}
}
