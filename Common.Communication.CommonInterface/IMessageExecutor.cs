using System;
using Motorola.Common.Communication.CommunicationPipe;

namespace Motorola.Common.Communication
{
	// Token: 0x02000017 RID: 23
	public interface IMessageExecutor
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000062 RID: 98
		// (set) Token: 0x06000063 RID: 99
		global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe CommPipe { get; set; }

		// Token: 0x06000064 RID: 100
		void Setup();

		// Token: 0x06000065 RID: 101
		void TearDown();

		// Token: 0x06000066 RID: 102
		void SendAndReceiveMessage(global::Motorola.Common.Communication.IMessage msg);

		// Token: 0x06000067 RID: 103
		void SendAndReceivePresenceInfo(global::Motorola.Common.Communication.IMessage msg);

		// Token: 0x06000068 RID: 104
		void SetRxTimeoutTimer(int timeout);
	}
}
