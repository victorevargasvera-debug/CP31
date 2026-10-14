using System;

namespace Motorola.Common.Communication
{
	// Token: 0x02000010 RID: 16
	public enum RcmpReplyResult : byte
	{
		// Token: 0x0400002A RID: 42
		Success,
		// Token: 0x0400002B RID: 43
		Failure,
		// Token: 0x0400002C RID: 44
		IncorrectMode,
		// Token: 0x0400002D RID: 45
		OpcodeNotSupported,
		// Token: 0x0400002E RID: 46
		InvalidParameter,
		// Token: 0x0400002F RID: 47
		ReplyTooBig,
		// Token: 0x04000030 RID: 48
		SecurityLocked,
		// Token: 0x04000031 RID: 49
		BundledOpcodeNotSupported,
		// Token: 0x04000032 RID: 50
		LockSequenceFailure = 16,
		// Token: 0x04000033 RID: 51
		EraseInProgress = 16,
		// Token: 0x04000034 RID: 52
		Busy = 16,
		// Token: 0x04000035 RID: 53
		PairDeviceFailure = 16,
		// Token: 0x04000036 RID: 54
		BitLocked,
		// Token: 0x04000037 RID: 55
		LanguagePackNotExist = 17,
		// Token: 0x04000038 RID: 56
		PasswordVerificationFailure = 17,
		// Token: 0x04000039 RID: 57
		BitUnlocked,
		// Token: 0x0400003A RID: 58
		RadioIsLocked = 18,
		// Token: 0x0400003B RID: 59
		TTSLanguagePackNotExist = 18,
		// Token: 0x0400003C RID: 60
		VoltageNotStable,
		// Token: 0x0400003D RID: 61
		ProgramFailure,
		// Token: 0x0400003E RID: 62
		TransferComplete = 22,
		// Token: 0x0400003F RID: 63
		RequestNotRXed,
		// Token: 0x04000040 RID: 64
		SoftpotOperationNotSupported = 64,
		// Token: 0x04000041 RID: 65
		SoftpotTypeNotSupported,
		// Token: 0x04000042 RID: 66
		SoftpotValueOutOfRange,
		// Token: 0x04000043 RID: 67
		FlashWriteFailure = 128,
		// Token: 0x04000044 RID: 68
		IshItemNotFound,
		// Token: 0x04000045 RID: 69
		IshOffsetOutOfRange,
		// Token: 0x04000046 RID: 70
		IshInsufficientPartitionSpace,
		// Token: 0x04000047 RID: 71
		IshPartitionDoesNotExist,
		// Token: 0x04000048 RID: 72
		IshPartitionReadOnly,
		// Token: 0x04000049 RID: 73
		IshReorgNeeded,
		// Token: 0x0400004A RID: 74
		Undefined
	}
}
