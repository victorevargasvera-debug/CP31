using System;
using Gibraltar.Agent.Data;
using Gibraltar.Agent.Internal;
using Gibraltar.Monitor;
using Loupe.Extensibility.Data;

namespace Gibraltar.Agent
{
	// Token: 0x02000008 RID: 8
	public class LogMessageFilterEventArgs : global::System.EventArgs
	{
		// Token: 0x06000082 RID: 130 RVA: 0x0000379C File Offset: 0x0000199C
		internal LogMessageFilterEventArgs(global::Gibraltar.Monitor.MessageFilterEventArgs eventArgs)
		{
			this.m_Event = eventArgs;
			this.m_Message = global::Gibraltar.Agent.LogMessageFilterEventArgs.ConvertMessage(this.m_Event.Message);
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000083 RID: 131 RVA: 0x000037C4 File Offset: 0x000019C4
		public global::Gibraltar.Agent.Data.ILogMessage Message
		{
			get
			{
				return this.m_Message;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000084 RID: 132 RVA: 0x000037CC File Offset: 0x000019CC
		// (set) Token: 0x06000085 RID: 133 RVA: 0x000037DC File Offset: 0x000019DC
		public bool Cancel
		{
			get
			{
				return this.m_Event.Cancel;
			}
			set
			{
				this.m_Event.Cancel = value;
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000037EC File Offset: 0x000019EC
		private static global::Gibraltar.Agent.Internal.LogMessageInfo ConvertMessage(global::Loupe.Extensibility.Data.ILogMessage internalMessage)
		{
			if (internalMessage == null)
			{
				return null;
			}
			return new global::Gibraltar.Agent.Internal.LogMessageInfo(internalMessage);
		}

		// Token: 0x04000022 RID: 34
		private readonly global::Gibraltar.Monitor.MessageFilterEventArgs m_Event;

		// Token: 0x04000023 RID: 35
		private readonly global::Gibraltar.Agent.Data.ILogMessage m_Message;
	}
}
