using System;

namespace Motorola.CommonCPS.Server.CommonDBConstants
{
	// Token: 0x02000044 RID: 68
	[global::System.Serializable]
	public enum MigrationStatus
	{
		// Token: 0x0400026B RID: 619
		NOT_START,
		// Token: 0x0400026C RID: 620
		STARTED,
		// Token: 0x0400026D RID: 621
		RADIO_AND_COMMON_COMPLETE,
		// Token: 0x0400026E RID: 622
		TEMPLATE_SELECTION_SAVED,
		// Token: 0x0400026F RID: 623
		TEMPLATE_COMPLETE,
		// Token: 0x04000270 RID: 624
		SCHEDULE_IN_PROGRESS,
		// Token: 0x04000271 RID: 625
		Complete,
		// Token: 0x04000272 RID: 626
		ABORT
	}
}
