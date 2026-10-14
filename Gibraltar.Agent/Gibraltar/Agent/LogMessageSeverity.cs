using System;

namespace Gibraltar.Agent
{
	// Token: 0x02000009 RID: 9
	[global::System.Flags]
	public enum LogMessageSeverity
	{
		// Token: 0x04000025 RID: 37
		None = 0,
		// Token: 0x04000026 RID: 38
		Critical = 1,
		// Token: 0x04000027 RID: 39
		Error = 2,
		// Token: 0x04000028 RID: 40
		Warning = 4,
		// Token: 0x04000029 RID: 41
		Information = 8,
		// Token: 0x0400002A RID: 42
		Verbose = 16
	}
}
