using System;
using System.Net;
using SSLMangrComp.Packets;

namespace SSLMangrComp.ConnectionLayer
{
	// Token: 0x02000037 RID: 55
	public interface IServerListener
	{
		// Token: 0x06000139 RID: 313
		void StartListner(global::System.Net.IPAddress pnIpAddress, global::SSLMangrComp.SecureServerConfiguration secureServerConfiguration, global::SSLMangrComp.Packets.SubscriptionType lMode);

		// Token: 0x0600013A RID: 314
		void StartListner(int port);

		// Token: 0x0600013B RID: 315
		void ShutdownServer();

		// Token: 0x0600013C RID: 316
		bool IsServerRunning();

		// Token: 0x0600013D RID: 317
		int getPortNumber();

		// Token: 0x0600013E RID: 318
		void RegisterIncomingPacketHandler(global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle hdl);

		// Token: 0x0600013F RID: 319
		void RegisterIncomingErrorHandler(global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle hdl);
	}
}
