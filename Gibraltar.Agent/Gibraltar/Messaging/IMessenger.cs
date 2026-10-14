using System;

namespace Gibraltar.Messaging
{
	// Token: 0x02000235 RID: 565
	internal interface IMessenger : global::System.IEquatable<global::Gibraltar.Messaging.IMessenger>, global::System.IDisposable
	{
		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x06001C6C RID: 7276
		string Caption { get; }

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x06001C6D RID: 7277
		string Description { get; }

		// Token: 0x06001C6E RID: 7278
		void ConfigurationUpdated(global::Gibraltar.Messaging.MessengerConfiguration configuration);

		// Token: 0x06001C6F RID: 7279
		void Initialize(global::Gibraltar.Messaging.Publisher publisher, global::Gibraltar.Messaging.MessengerConfiguration configuration);

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x06001C70 RID: 7280
		string Name { get; }

		// Token: 0x06001C71 RID: 7281
		void Write(global::Gibraltar.Messaging.IMessengerPacket packet, bool writeThrough);
	}
}
