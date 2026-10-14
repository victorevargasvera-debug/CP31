using System;

namespace Gibraltar.Monitor.Windows
{
	// Token: 0x020001E0 RID: 480
	internal class MessageChangedEventArgs : global::System.EventArgs
	{
		// Token: 0x060016E3 RID: 5859 RVA: 0x0004A4F4 File Offset: 0x000486F4
		public MessageChangedEventArgs(string message)
		{
			this.m_Message = message;
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x060016E4 RID: 5860 RVA: 0x0004A504 File Offset: 0x00048704
		public string Message
		{
			get
			{
				return this.m_Message;
			}
		}

		// Token: 0x040007CB RID: 1995
		private readonly string m_Message;
	}
}
