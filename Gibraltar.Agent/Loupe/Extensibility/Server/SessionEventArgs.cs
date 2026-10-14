using System;
using Loupe.Extensibility.Data;

namespace Loupe.Extensibility.Server
{
	// Token: 0x02000058 RID: 88
	internal class SessionEventArgs : global::System.EventArgs
	{
		// Token: 0x060004DC RID: 1244 RVA: 0x0000C060 File Offset: 0x0000A260
		public SessionEventArgs(global::Loupe.Extensibility.Data.ISessionSummary session)
		{
			this.Session = session;
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x0000C070 File Offset: 0x0000A270
		// (set) Token: 0x060004DE RID: 1246 RVA: 0x0000C078 File Offset: 0x0000A278
		public global::Loupe.Extensibility.Data.ISessionSummary Session { get; private set; }
	}
}
