using System;

namespace NLog.Targets
{
	// Token: 0x0200005A RID: 90
	[global::System.Flags]
	public enum Win32FileAttributes
	{
		// Token: 0x0400019C RID: 412
		ReadOnly = 1,
		// Token: 0x0400019D RID: 413
		Hidden = 2,
		// Token: 0x0400019E RID: 414
		System = 4,
		// Token: 0x0400019F RID: 415
		Archive = 32,
		// Token: 0x040001A0 RID: 416
		Device = 64,
		// Token: 0x040001A1 RID: 417
		Normal = 128,
		// Token: 0x040001A2 RID: 418
		Temporary = 256,
		// Token: 0x040001A3 RID: 419
		SparseFile = 512,
		// Token: 0x040001A4 RID: 420
		ReparsePoint = 1024,
		// Token: 0x040001A5 RID: 421
		Compressed = 2048,
		// Token: 0x040001A6 RID: 422
		NotContentIndexed = 8192,
		// Token: 0x040001A7 RID: 423
		Encrypted = 16384,
		// Token: 0x040001A8 RID: 424
		WriteThrough = -2147483648,
		// Token: 0x040001A9 RID: 425
		NoBuffering = 536870912,
		// Token: 0x040001AA RID: 426
		DeleteOnClose = 67108864,
		// Token: 0x040001AB RID: 427
		PosixSemantics = 16777216
	}
}
