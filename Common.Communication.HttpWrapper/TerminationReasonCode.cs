using System;

namespace Motorola.Common.Communication
{
	// Token: 0x02000008 RID: 8
	public enum TerminationReasonCode
	{
		// Token: 0x0400000A RID: 10
		JobComplete = 10,
		// Token: 0x0400000B RID: 11
		SessionAbort,
		// Token: 0x0400000C RID: 12
		InactivityTimerExpired,
		// Token: 0x0400000D RID: 13
		FactoryReset,
		// Token: 0x0400000E RID: 14
		HaveNoJob
	}
}
