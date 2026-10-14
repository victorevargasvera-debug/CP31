using System;
using Gibraltar.Serialization;

namespace Gibraltar.Messaging
{
	// Token: 0x02000240 RID: 576
	internal interface IMessengerPacket : global::Gibraltar.Serialization.IPacket
	{
		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x06001CEF RID: 7407
		// (set) Token: 0x06001CF0 RID: 7408
		long Sequence { get; set; }

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x06001CF1 RID: 7409
		// (set) Token: 0x06001CF2 RID: 7410
		global::System.DateTimeOffset Timestamp { get; set; }
	}
}
