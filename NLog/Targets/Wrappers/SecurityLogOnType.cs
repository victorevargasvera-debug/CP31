using System;

namespace NLog.Targets.Wrappers
{
	// Token: 0x0200006F RID: 111
	public enum SecurityLogOnType
	{
		// Token: 0x040001EE RID: 494
		Interactive = 2,
		// Token: 0x040001EF RID: 495
		Network,
		// Token: 0x040001F0 RID: 496
		Batch,
		// Token: 0x040001F1 RID: 497
		Service,
		// Token: 0x040001F2 RID: 498
		NetworkClearText = 8,
		// Token: 0x040001F3 RID: 499
		NewCredentials
	}
}
