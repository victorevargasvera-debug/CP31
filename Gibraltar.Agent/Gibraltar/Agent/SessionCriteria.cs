using System;

namespace Gibraltar.Agent
{
	// Token: 0x02000011 RID: 17
	[global::System.Flags]
	public enum SessionCriteria
	{
		// Token: 0x04000042 RID: 66
		None = 0,
		// Token: 0x04000043 RID: 67
		CompletedSessions = 1,
		// Token: 0x04000044 RID: 68
		NewSessions = 2,
		// Token: 0x04000045 RID: 69
		CrashedSessions = 4,
		// Token: 0x04000046 RID: 70
		CriticalSessions = 8,
		// Token: 0x04000047 RID: 71
		ErrorSessions = 16,
		// Token: 0x04000048 RID: 72
		WarningSessions = 32,
		// Token: 0x04000049 RID: 73
		ActiveSession = 64,
		// Token: 0x0400004A RID: 74
		AllSessions = 65
	}
}
