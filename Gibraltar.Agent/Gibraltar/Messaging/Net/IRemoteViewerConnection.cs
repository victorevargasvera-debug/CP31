using System;
using System.ComponentModel;
using Gibraltar.Data;
using Loupe.Extensibility.Data;

namespace Gibraltar.Messaging.Net
{
	// Token: 0x02000243 RID: 579
	internal interface IRemoteViewerConnection : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x14000086 RID: 134
		// (add) Token: 0x06001D2D RID: 7469
		// (remove) Token: 0x06001D2E RID: 7470
		event global::Gibraltar.Messaging.Net.MessageAvailableEventHandler MessageAvailable;

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x06001D2F RID: 7471
		bool HasCorruptData { get; }

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x06001D30 RID: 7472
		int PacketsLostCount { get; }

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x06001D31 RID: 7473
		bool IsConnected { get; }

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x06001D32 RID: 7474
		global::System.Guid Id { get; }

		// Token: 0x06001D33 RID: 7475
		void Connect();

		// Token: 0x06001D34 RID: 7476
		void SendToServer(global::Gibraltar.Data.SessionCriteria criteria);

		// Token: 0x06001D35 RID: 7477
		global::Loupe.Extensibility.Data.ILogMessage[] GetMessageBuffer();
	}
}
