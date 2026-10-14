using System;

namespace DevAge.Patterns
{
	// Token: 0x0200027C RID: 636
	[global::System.Serializable]
	internal class TimeOutActivityException : global::DevAge.DevAgeApplicationException
	{
		// Token: 0x0600207E RID: 8318 RVA: 0x0007412C File Offset: 0x0007232C
		public TimeOutActivityException() : base("Activity timeout.")
		{
		}
	}
}
