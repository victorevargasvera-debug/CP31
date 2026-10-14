using System;
using Loupe.Extensibility.Data;

namespace Loupe.Extensibility.Server
{
	// Token: 0x02000056 RID: 86
	internal class LogEventEventArgs : global::System.EventArgs
	{
		// Token: 0x060004D3 RID: 1235 RVA: 0x0000C020 File Offset: 0x0000A220
		public LogEventEventArgs(global::Loupe.Extensibility.Data.ISessionSummary session, global::Loupe.Extensibility.Data.ILogEvent logEvent)
		{
			this.Session = session;
			this.LogEvent = logEvent;
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060004D4 RID: 1236 RVA: 0x0000C038 File Offset: 0x0000A238
		// (set) Token: 0x060004D5 RID: 1237 RVA: 0x0000C040 File Offset: 0x0000A240
		public global::Loupe.Extensibility.Data.ISessionSummary Session { get; private set; }

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x0000C04C File Offset: 0x0000A24C
		// (set) Token: 0x060004D7 RID: 1239 RVA: 0x0000C054 File Offset: 0x0000A254
		public global::Loupe.Extensibility.Data.ILogEvent LogEvent { get; private set; }
	}
}
