using System;
using Gibraltar.Data;

namespace Gibraltar.Server.Client
{
	// Token: 0x02000179 RID: 377
	internal class SessionHeaderEventArgs : global::System.EventArgs
	{
		// Token: 0x06000FA9 RID: 4009 RVA: 0x0002AC00 File Offset: 0x00028E00
		public SessionHeaderEventArgs(global::Gibraltar.Data.SessionHeader header)
		{
			this.SessionHeader = header;
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06000FAA RID: 4010 RVA: 0x0002AC10 File Offset: 0x00028E10
		// (set) Token: 0x06000FAB RID: 4011 RVA: 0x0002AC18 File Offset: 0x00028E18
		public global::Gibraltar.Data.SessionHeader SessionHeader { get; private set; }
	}
}
