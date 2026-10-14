using System;

namespace Motorola.CommonCPS.Server.CommonDBConstants
{
	// Token: 0x02000031 RID: 49
	[global::System.Flags]
	public enum FeatureStatus
	{
		// Token: 0x04000173 RID: 371
		None = 1,
		// Token: 0x04000174 RID: 372
		Disabled = 2,
		// Token: 0x04000175 RID: 373
		Free = 4,
		// Token: 0x04000176 RID: 374
		Active = 8,
		// Token: 0x04000177 RID: 375
		Registered = 16,
		// Token: 0x04000178 RID: 376
		PendingActive = 32,
		// Token: 0x04000179 RID: 377
		PendingDisabled = 64,
		// Token: 0x0400017A RID: 378
		ScheduledActivation = 128
	}
}
