using System;

namespace NLog.Config
{
	// Token: 0x02000167 RID: 359
	public class LoggingConfigurationReloadedEventArgs : global::System.EventArgs
	{
		// Token: 0x06000FC0 RID: 4032 RVA: 0x00028C37 File Offset: 0x00026E37
		public LoggingConfigurationReloadedEventArgs(bool succeeded)
		{
			this.Succeeded = succeeded;
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x00028C46 File Offset: 0x00026E46
		public LoggingConfigurationReloadedEventArgs(bool succeeded, global::System.Exception exception)
		{
			this.Succeeded = succeeded;
			this.Exception = exception;
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000FC2 RID: 4034 RVA: 0x00028C5C File Offset: 0x00026E5C
		// (set) Token: 0x06000FC3 RID: 4035 RVA: 0x00028C64 File Offset: 0x00026E64
		public bool Succeeded { get; private set; }

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000FC4 RID: 4036 RVA: 0x00028C6D File Offset: 0x00026E6D
		// (set) Token: 0x06000FC5 RID: 4037 RVA: 0x00028C75 File Offset: 0x00026E75
		public global::System.Exception Exception { get; private set; }
	}
}
