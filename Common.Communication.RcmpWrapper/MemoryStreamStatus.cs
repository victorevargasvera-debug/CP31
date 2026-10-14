using System;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000C RID: 12
	public enum MemoryStreamStatus : byte
	{
		// Token: 0x04000017 RID: 23
		Success,
		// Token: 0x04000018 RID: 24
		Transfer_failed,
		// Token: 0x04000019 RID: 25
		Flash_failed,
		// Token: 0x0400001A RID: 26
		Transfer_in_progress,
		// Token: 0x0400001B RID: 27
		Flash_in_progress
	}
}
