using System;
using Gibraltar.Data;

namespace Gibraltar.Agent
{
	// Token: 0x02000010 RID: 16
	public sealed class PackageSendEventArgs : global::System.EventArgs
	{
		// Token: 0x060000F1 RID: 241 RVA: 0x00004940 File Offset: 0x00002B40
		internal PackageSendEventArgs(global::Gibraltar.Data.PackageSendEventArgs args)
		{
			this.FileSize = args.FileSize;
			this.Result = (global::Gibraltar.Agent.AsyncTaskResult)args.Result;
			this.Message = args.Message;
			this.Exception = args.Exception;
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00004988 File Offset: 0x00002B88
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x00004990 File Offset: 0x00002B90
		public global::Gibraltar.Agent.AsyncTaskResult Result { get; private set; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x0000499C File Offset: 0x00002B9C
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x000049A4 File Offset: 0x00002BA4
		public string Message { get; private set; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x000049B0 File Offset: 0x00002BB0
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x000049B8 File Offset: 0x00002BB8
		public global::System.Exception Exception { get; private set; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x000049C4 File Offset: 0x00002BC4
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x000049CC File Offset: 0x00002BCC
		public int FileSize { get; private set; }
	}
}
