using System;

namespace Gibraltar.Monitor
{
	// Token: 0x020001A3 RID: 419
	internal interface IMessageSourceProvider
	{
		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x0600126B RID: 4715
		string MethodName { get; }

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x0600126C RID: 4716
		string ClassName { get; }

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x0600126D RID: 4717
		string FileName { get; }

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x0600126E RID: 4718
		int LineNumber { get; }
	}
}
