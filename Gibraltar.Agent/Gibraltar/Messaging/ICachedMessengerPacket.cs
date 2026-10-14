using System;
using Gibraltar.Serialization;

namespace Gibraltar.Messaging
{
	// Token: 0x0200023F RID: 575
	internal interface ICachedMessengerPacket : global::Gibraltar.Serialization.ICachedPacket, global::Gibraltar.Serialization.IPacket, global::Gibraltar.Messaging.IMessengerPacket
	{
		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x06001CEE RID: 7406
		bool IsHeader { get; }
	}
}
