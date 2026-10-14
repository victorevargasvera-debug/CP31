using System;
using Gibraltar.Monitor;
using Loupe.Extensibility.Data;

namespace Gibraltar.Messaging
{
	// Token: 0x0200022C RID: 556
	internal class NotificationEventArgs : global::System.EventArgs
	{
		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x06001BEC RID: 7148 RVA: 0x00061F50 File Offset: 0x00060150
		// (set) Token: 0x06001BED RID: 7149 RVA: 0x00061F58 File Offset: 0x00060158
		public bool SendSession
		{
			get
			{
				return this.m_SendSession;
			}
			set
			{
				if (this.m_SendSession == value)
				{
					return;
				}
				if (!value)
				{
					this.m_SendSession = false;
					return;
				}
				string text = null;
				if (global::Gibraltar.Monitor.Log.CanSendSessions(ref text))
				{
					this.m_SendSession = true;
				}
			}
		}

		// Token: 0x06001BEE RID: 7150 RVA: 0x00061F9C File Offset: 0x0006019C
		internal NotificationEventArgs(global::Loupe.Extensibility.Data.ILogMessage[] messages, global::System.TimeSpan defaultMinWait)
		{
			this.MinimumNotificationDelay = defaultMinWait;
			this.Messages = messages;
			this.TopSeverity = global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose;
			foreach (global::Loupe.Extensibility.Data.ILogMessage logMessage in messages)
			{
				if (logMessage != null)
				{
					this.TotalCount++;
					global::Loupe.Extensibility.Data.LogMessageSeverity severity = logMessage.Severity;
					if (severity < this.TopSeverity)
					{
						this.TopSeverity = severity;
					}
					switch (severity)
					{
					case global::Loupe.Extensibility.Data.LogMessageSeverity.Critical:
						this.CriticalCount++;
						break;
					case global::Loupe.Extensibility.Data.LogMessageSeverity.Error:
						this.ErrorCount++;
						break;
					case global::Loupe.Extensibility.Data.LogMessageSeverity.Warning:
						this.WarningCount++;
						break;
					}
					if (logMessage.HasException)
					{
						this.ExceptionCount++;
					}
				}
			}
		}

		// Token: 0x04000A16 RID: 2582
		private bool m_SendSession;

		// Token: 0x04000A17 RID: 2583
		public readonly global::Loupe.Extensibility.Data.ILogMessage[] Messages;

		// Token: 0x04000A18 RID: 2584
		public readonly global::Loupe.Extensibility.Data.LogMessageSeverity TopSeverity;

		// Token: 0x04000A19 RID: 2585
		public readonly int TotalCount;

		// Token: 0x04000A1A RID: 2586
		public readonly int CriticalCount;

		// Token: 0x04000A1B RID: 2587
		public readonly int ErrorCount;

		// Token: 0x04000A1C RID: 2588
		public readonly int WarningCount;

		// Token: 0x04000A1D RID: 2589
		public readonly int ExceptionCount;

		// Token: 0x04000A1E RID: 2590
		public global::System.TimeSpan MinimumNotificationDelay;
	}
}
