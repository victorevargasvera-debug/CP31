using System;

namespace Gibraltar
{
	// Token: 0x020000AE RID: 174
	[global::System.Flags]
	internal enum AsyncTaskResult
	{
		// Token: 0x0400014E RID: 334
		Unknown = 0,
		// Token: 0x0400014F RID: 335
		Canceled = 1,
		// Token: 0x04000150 RID: 336
		Error = 2,
		// Token: 0x04000151 RID: 337
		Warning = 4,
		// Token: 0x04000152 RID: 338
		Information = 8,
		// Token: 0x04000153 RID: 339
		Success = 16
	}
}
