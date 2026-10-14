using System;

namespace NLog.Internal.NetworkSenders
{
	// Token: 0x02000135 RID: 309
	internal interface INetworkSenderFactory
	{
		// Token: 0x06000DF9 RID: 3577
		global::NLog.Internal.NetworkSenders.NetworkSender Create(string url, int maxQueueSize);
	}
}
