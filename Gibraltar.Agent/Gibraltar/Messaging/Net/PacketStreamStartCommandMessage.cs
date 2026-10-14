using System;
using System.IO;

namespace Gibraltar.Messaging.Net
{
	// Token: 0x02000248 RID: 584
	internal class PacketStreamStartCommandMessage : global::Gibraltar.Messaging.Net.NetworkMessage
	{
		// Token: 0x06001D72 RID: 7538 RVA: 0x00067F94 File Offset: 0x00066194
		public PacketStreamStartCommandMessage()
		{
			base.TypeCode = global::Gibraltar.Messaging.Net.NetworkMessageTypeCode.PacketStreamStartCommand;
			base.Version = new global::System.Version(1, 0);
		}

		// Token: 0x06001D73 RID: 7539 RVA: 0x00067FB4 File Offset: 0x000661B4
		protected override void OnWrite(global::System.IO.Stream stream)
		{
		}

		// Token: 0x06001D74 RID: 7540 RVA: 0x00067FB8 File Offset: 0x000661B8
		protected override void OnRead(global::System.IO.Stream stream)
		{
		}
	}
}
