using System;
using Gibraltar.Agent.Data;
using Gibraltar.Agent.Internal;
using Gibraltar.Messaging;
using Gibraltar.Monitor;
using Loupe.Extensibility.Data;

namespace Gibraltar.Agent
{
	// Token: 0x0200000C RID: 12
	public class LogMessageAlertEventArgs : global::System.EventArgs
	{
		// Token: 0x06000092 RID: 146 RVA: 0x000039C4 File Offset: 0x00001BC4
		internal LogMessageAlertEventArgs(global::Gibraltar.Messaging.NotificationEventArgs eventArgs)
		{
			this.m_Event = eventArgs;
			global::Gibraltar.Agent.Internal.LogMessageInfo[] messages = global::Gibraltar.Agent.LogMessageAlertEventArgs.ConvertMessages(eventArgs.Messages);
			this.m_MessageCollection = new global::Gibraltar.Agent.Internal.LogMessageInfoCollection(messages);
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000093 RID: 147 RVA: 0x000039FC File Offset: 0x00001BFC
		public global::Gibraltar.Agent.Data.ILogMessageCollection Messages
		{
			get
			{
				return this.m_MessageCollection;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00003A04 File Offset: 0x00001C04
		public global::Gibraltar.Agent.LogMessageSeverity TopSeverity
		{
			get
			{
				return (global::Gibraltar.Agent.LogMessageSeverity)this.m_Event.TopSeverity;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00003A14 File Offset: 0x00001C14
		public int TotalCount
		{
			get
			{
				return this.m_Event.TotalCount;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00003A24 File Offset: 0x00001C24
		public int CriticalCount
		{
			get
			{
				return this.m_Event.CriticalCount;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00003A34 File Offset: 0x00001C34
		public int ErrorCount
		{
			get
			{
				return this.m_Event.ErrorCount;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00003A44 File Offset: 0x00001C44
		public int WarningCount
		{
			get
			{
				return this.m_Event.WarningCount;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00003A54 File Offset: 0x00001C54
		public int ExceptionCount
		{
			get
			{
				return this.m_Event.ExceptionCount;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00003A64 File Offset: 0x00001C64
		// (set) Token: 0x0600009B RID: 155 RVA: 0x00003A74 File Offset: 0x00001C74
		public global::System.TimeSpan MinimumDelay
		{
			get
			{
				return this.m_Event.MinimumNotificationDelay;
			}
			set
			{
				this.m_Event.MinimumNotificationDelay = value;
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00003A84 File Offset: 0x00001C84
		public bool CanSendSession(ref string reason)
		{
			return global::Gibraltar.Monitor.Log.CanSendSessions(ref reason);
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00003A8C File Offset: 0x00001C8C
		// (set) Token: 0x0600009E RID: 158 RVA: 0x00003A9C File Offset: 0x00001C9C
		public bool SendSession
		{
			get
			{
				return this.m_Event.SendSession;
			}
			set
			{
				this.m_Event.SendSession = value;
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00003AAC File Offset: 0x00001CAC
		private static global::Gibraltar.Agent.Internal.LogMessageInfo[] ConvertMessages(global::Loupe.Extensibility.Data.ILogMessage[] internalMessages)
		{
			if (internalMessages == null)
			{
				return new global::Gibraltar.Agent.Internal.LogMessageInfo[0];
			}
			int num = internalMessages.Length;
			global::Gibraltar.Agent.Internal.LogMessageInfo[] array = new global::Gibraltar.Agent.Internal.LogMessageInfo[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = new global::Gibraltar.Agent.Internal.LogMessageInfo(internalMessages[i]);
			}
			return array;
		}

		// Token: 0x0400002F RID: 47
		private readonly global::Gibraltar.Messaging.NotificationEventArgs m_Event;

		// Token: 0x04000030 RID: 48
		private readonly global::Gibraltar.Agent.Internal.LogMessageInfoCollection m_MessageCollection;
	}
}
