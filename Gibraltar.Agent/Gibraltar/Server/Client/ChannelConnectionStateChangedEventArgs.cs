using System;

namespace Gibraltar.Server.Client
{
	// Token: 0x02000119 RID: 281
	internal class ChannelConnectionStateChangedEventArgs : global::System.EventArgs
	{
		// Token: 0x06000B9F RID: 2975 RVA: 0x0001DA7C File Offset: 0x0001BC7C
		internal ChannelConnectionStateChangedEventArgs(global::Gibraltar.Server.Client.ChannelConnectionState state)
		{
			this.State = state;
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06000BA0 RID: 2976 RVA: 0x0001DA8C File Offset: 0x0001BC8C
		// (set) Token: 0x06000BA1 RID: 2977 RVA: 0x0001DA94 File Offset: 0x0001BC94
		public global::Gibraltar.Server.Client.ChannelConnectionState State { get; private set; }
	}
}
