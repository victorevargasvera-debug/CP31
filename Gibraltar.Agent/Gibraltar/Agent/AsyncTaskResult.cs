using System;

namespace Gibraltar.Agent
{
	// Token: 0x02000004 RID: 4
	[global::System.Flags]
	public enum AsyncTaskResult
	{
		// Token: 0x0400000A RID: 10
		None = 0,
		// Token: 0x0400000B RID: 11
		Canceled = 1,
		// Token: 0x0400000C RID: 12
		Error = 2,
		// Token: 0x0400000D RID: 13
		Warning = 4,
		// Token: 0x0400000E RID: 14
		Information = 8,
		// Token: 0x0400000F RID: 15
		Success = 16
	}
}
