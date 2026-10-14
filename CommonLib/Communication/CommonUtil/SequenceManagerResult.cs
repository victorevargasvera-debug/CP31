using System;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000070 RID: 112
	public enum SequenceManagerResult
	{
		// Token: 0x040002F4 RID: 756
		Success,
		// Token: 0x040002F5 RID: 757
		Failure,
		// Token: 0x040002F6 RID: 758
		RcmpIncorrectMode,
		// Token: 0x040002F7 RID: 759
		RcmpOpcodeNotSupported,
		// Token: 0x040002F8 RID: 760
		RcmpInvalidParameter,
		// Token: 0x040002F9 RID: 761
		RcmpReplyTooBig,
		// Token: 0x040002FA RID: 762
		RcmpSecurityLocked,
		// Token: 0x040002FB RID: 763
		RcmpBundledOpcodeNotSupported,
		// Token: 0x040002FC RID: 764
		RcmpSoftpotOperationNotSupported = 64,
		// Token: 0x040002FD RID: 765
		RcmpSoftpotTypeNotSupported,
		// Token: 0x040002FE RID: 766
		RcmpSoftpotValueOutOfRange,
		// Token: 0x040002FF RID: 767
		RcmpFlashWriteFailure = 128,
		// Token: 0x04000300 RID: 768
		RcmpIshItemNotFound,
		// Token: 0x04000301 RID: 769
		RcmpIshOffsetOutOfRange,
		// Token: 0x04000302 RID: 770
		RcmpIshInsufficientPartitionSpace,
		// Token: 0x04000303 RID: 771
		RcmpIshPartitionDoesNotExist,
		// Token: 0x04000304 RID: 772
		RcmpIshPartitionReadOnly,
		// Token: 0x04000305 RID: 773
		RcmpIshReorgNeeded,
		// Token: 0x04000306 RID: 774
		Undefined,
		// Token: 0x04000307 RID: 775
		FlashNotNeeded = 144,
		// Token: 0x04000308 RID: 776
		InvalidUpgradeFileContents,
		// Token: 0x04000309 RID: 777
		InvalidSerialNumber,
		// Token: 0x0400030A RID: 778
		InvalidUpgradeFile,
		// Token: 0x0400030B RID: 779
		RadioStillErasingInactive,
		// Token: 0x0400030C RID: 780
		FlashDowngrade,
		// Token: 0x0400030D RID: 781
		ComponentNotFoundInUpgradeFile
	}
}
