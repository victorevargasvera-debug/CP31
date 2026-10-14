using System;

namespace Gibraltar.Monitor.Internal
{
	// Token: 0x020001F8 RID: 504
	internal interface ISessionPacketCache
	{
		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x060018E9 RID: 6377
		global::Gibraltar.Monitor.ThreadInfoCollection Threads { get; }

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x060018EA RID: 6378
		global::Gibraltar.Monitor.ApplicationUserCollection Users { get; }
	}
}
