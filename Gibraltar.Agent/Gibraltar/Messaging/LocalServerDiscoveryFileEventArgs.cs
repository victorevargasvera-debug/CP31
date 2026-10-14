using System;

namespace Gibraltar.Messaging
{
	// Token: 0x02000224 RID: 548
	internal class LocalServerDiscoveryFileEventArgs : global::System.EventArgs
	{
		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06001BB1 RID: 7089 RVA: 0x0006065C File Offset: 0x0005E85C
		// (set) Token: 0x06001BB2 RID: 7090 RVA: 0x00060664 File Offset: 0x0005E864
		public global::Gibraltar.Messaging.LocalServerDiscoveryFile File { get; set; }

		// Token: 0x06001BB3 RID: 7091 RVA: 0x00060670 File Offset: 0x0005E870
		public LocalServerDiscoveryFileEventArgs(global::Gibraltar.Messaging.LocalServerDiscoveryFile file)
		{
			this.File = file;
		}
	}
}
