using System;

namespace Gibraltar.Messaging
{
	// Token: 0x02000227 RID: 551
	internal class NetworkEventArgs : global::System.EventArgs
	{
		// Token: 0x06001BC1 RID: 7105 RVA: 0x000609F8 File Offset: 0x0005EBF8
		public NetworkEventArgs(string description)
		{
			this.Description = description;
		}

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x06001BC2 RID: 7106 RVA: 0x00060A08 File Offset: 0x0005EC08
		// (set) Token: 0x06001BC3 RID: 7107 RVA: 0x00060A10 File Offset: 0x0005EC10
		public string Description { get; private set; }
	}
}
