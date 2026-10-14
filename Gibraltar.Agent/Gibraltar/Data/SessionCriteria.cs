using System;

namespace Gibraltar.Data
{
	// Token: 0x0200025F RID: 607
	[global::System.Flags]
	internal enum SessionCriteria
	{
		// Token: 0x04000BA7 RID: 2983
		None = 0,
		// Token: 0x04000BA8 RID: 2984
		CompletedSessions = 1,
		// Token: 0x04000BA9 RID: 2985
		NewSessions = 2,
		// Token: 0x04000BAA RID: 2986
		CrashedSessions = 4,
		// Token: 0x04000BAB RID: 2987
		CriticalSessions = 8,
		// Token: 0x04000BAC RID: 2988
		ErrorSessions = 16,
		// Token: 0x04000BAD RID: 2989
		WarningSessions = 32,
		// Token: 0x04000BAE RID: 2990
		ActiveSession = 64,
		// Token: 0x04000BAF RID: 2991
		AllSessions = 65
	}
}
