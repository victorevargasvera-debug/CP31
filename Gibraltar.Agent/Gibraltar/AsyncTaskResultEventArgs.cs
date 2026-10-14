using System;

namespace Gibraltar
{
	// Token: 0x020000AF RID: 175
	internal class AsyncTaskResultEventArgs : global::System.EventArgs
	{
		// Token: 0x0600072E RID: 1838 RVA: 0x0000D07C File Offset: 0x0000B27C
		public AsyncTaskResultEventArgs(global::Gibraltar.AsyncTaskResult result, string message)
		{
			this.Result = result;
			this.Message = message;
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x0000D094 File Offset: 0x0000B294
		public AsyncTaskResultEventArgs(global::Gibraltar.AsyncTaskResult result, string message, global::System.Exception exception)
		{
			this.Result = result;
			this.Message = message;
			this.Exception = exception;
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000730 RID: 1840 RVA: 0x0000D0C0 File Offset: 0x0000B2C0
		// (set) Token: 0x06000731 RID: 1841 RVA: 0x0000D0C8 File Offset: 0x0000B2C8
		public global::Gibraltar.AsyncTaskResult Result { get; private set; }

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000732 RID: 1842 RVA: 0x0000D0D4 File Offset: 0x0000B2D4
		// (set) Token: 0x06000733 RID: 1843 RVA: 0x0000D0DC File Offset: 0x0000B2DC
		public string Message { get; private set; }

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000734 RID: 1844 RVA: 0x0000D0E8 File Offset: 0x0000B2E8
		// (set) Token: 0x06000735 RID: 1845 RVA: 0x0000D0F0 File Offset: 0x0000B2F0
		public global::System.Exception Exception { get; private set; }
	}
}
