using System;

namespace DevAge.Patterns
{
	// Token: 0x0200027A RID: 634
	[global::System.Serializable]
	internal class ActivityCanceledException : global::DevAge.DevAgeApplicationException
	{
		// Token: 0x0600207C RID: 8316 RVA: 0x0007410C File Offset: 0x0007230C
		public ActivityCanceledException() : base("Activity canceled.")
		{
		}
	}
}
