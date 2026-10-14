using System;
using System.Collections;
using System.Collections.Generic;
using Gibraltar.Data;

namespace Gibraltar.Monitor.Internal
{
	// Token: 0x020001F6 RID: 502
	internal class LogMessageEnumerable : global::System.Collections.Generic.IEnumerable<global::Gibraltar.Monitor.LogMessage>, global::System.Collections.IEnumerable
	{
		// Token: 0x060018DB RID: 6363 RVA: 0x00057970 File Offset: 0x00055B70
		public LogMessageEnumerable(global::Gibraltar.Monitor.Session session, global::Gibraltar.Monitor.ThreadInfoCollection threads, global::Gibraltar.Monitor.ApplicationUserCollection users, global::System.Collections.Generic.List<global::Gibraltar.Data.GLFReader> availableReaders)
		{
			this.m_Session = session;
			this.m_Threads = threads;
			this.m_Users = users;
			this.m_AvailableReaders = availableReaders;
		}

		// Token: 0x060018DC RID: 6364 RVA: 0x00057998 File Offset: 0x00055B98
		public global::System.Collections.Generic.IEnumerator<global::Gibraltar.Monitor.LogMessage> GetEnumerator()
		{
			if (this.m_AvailableReaders.Count == 0)
			{
				return ((global::System.Collections.Generic.IEnumerable<global::Gibraltar.Monitor.LogMessage>)this.m_Session.Messages).GetEnumerator();
			}
			return new global::Gibraltar.Monitor.Internal.LogMessageEnumerator(this.m_Session, this.m_Threads, this.m_Users, this.m_AvailableReaders);
		}

		// Token: 0x060018DD RID: 6365 RVA: 0x000579D8 File Offset: 0x00055BD8
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x040008FA RID: 2298
		private readonly global::Gibraltar.Monitor.Session m_Session;

		// Token: 0x040008FB RID: 2299
		private readonly global::Gibraltar.Monitor.ThreadInfoCollection m_Threads;

		// Token: 0x040008FC RID: 2300
		private readonly global::Gibraltar.Monitor.ApplicationUserCollection m_Users;

		// Token: 0x040008FD RID: 2301
		private readonly global::System.Collections.Generic.List<global::Gibraltar.Data.GLFReader> m_AvailableReaders;
	}
}
