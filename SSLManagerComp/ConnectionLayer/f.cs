using System;

namespace SSLMangrComp.ConnectionLayer
{
	// Token: 0x02000040 RID: 64
	internal interface f
	{
		// Token: 0x06000189 RID: 393
		void StartListener(int port);

		// Token: 0x0600018A RID: 394
		void a(global::SSLMangrComp.PNConnectionInfo A_0);

		// Token: 0x0600018B RID: 395
		void ShutdownServer();

		// Token: 0x0600018C RID: 396
		void SignalCloseStream();

		// Token: 0x0600018D RID: 397
		bool IsServerRunning();

		// Token: 0x0600018E RID: 398
		int getPortNumber();

		// Token: 0x0600018F RID: 399
		void b(global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle A_0);

		// Token: 0x06000190 RID: 400
		void c(global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle A_0);
	}
}
