using System;

namespace Gibraltar.Data
{
	// Token: 0x0200025E RID: 606
	internal class PackageSendEventArgs : global::Gibraltar.AsyncTaskResultEventArgs
	{
		// Token: 0x06001F03 RID: 7939 RVA: 0x00070978 File Offset: 0x0006EB78
		public PackageSendEventArgs(int fileSize, global::Gibraltar.AsyncTaskResult result, string message, global::System.Exception exception) : base(result, message, exception)
		{
			this.FileSize = fileSize;
		}

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x06001F04 RID: 7940 RVA: 0x0007098C File Offset: 0x0006EB8C
		// (set) Token: 0x06001F05 RID: 7941 RVA: 0x00070994 File Offset: 0x0006EB94
		public int FileSize { get; private set; }
	}
}
