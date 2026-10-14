using System;

namespace Gibraltar
{
	// Token: 0x020000A8 RID: 168
	internal class ErrorNotificationEventArgs : global::System.EventArgs
	{
		// Token: 0x060006FF RID: 1791 RVA: 0x0000C744 File Offset: 0x0000A944
		public ErrorNotificationEventArgs(global::System.Exception exception)
		{
			this.m_Exception = exception;
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000700 RID: 1792 RVA: 0x0000C754 File Offset: 0x0000A954
		public global::System.Exception Exception
		{
			get
			{
				return this.m_Exception;
			}
		}

		// Token: 0x04000131 RID: 305
		private readonly global::System.Exception m_Exception;
	}
}
