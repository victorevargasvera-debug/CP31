using System;
using Gibraltar.Monitor.Windows;

namespace Gibraltar.Agent.Windows
{
	// Token: 0x02000016 RID: 22
	public sealed class MessageChangedEventArgs : global::System.EventArgs
	{
		// Token: 0x06000171 RID: 369 RVA: 0x000057C8 File Offset: 0x000039C8
		internal MessageChangedEventArgs(string message)
		{
			this.m_Message = message;
		}

		// Token: 0x06000172 RID: 370 RVA: 0x000057D8 File Offset: 0x000039D8
		internal MessageChangedEventArgs(global::Gibraltar.Monitor.Windows.MessageChangedEventArgs internalArgs)
		{
			this.m_Message = internalArgs.Message;
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000173 RID: 371 RVA: 0x000057EC File Offset: 0x000039EC
		public string Message
		{
			get
			{
				return this.m_Message;
			}
		}

		// Token: 0x04000059 RID: 89
		private readonly string m_Message;
	}
}
