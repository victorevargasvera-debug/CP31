using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000315 RID: 789
	public interface DatagramTransport : global::Org.BouncyCastle.Crypto.Tls.TlsCloseable
	{
		// Token: 0x0600213F RID: 8511
		int GetReceiveLimit();

		// Token: 0x06002140 RID: 8512
		int GetSendLimit();

		// Token: 0x06002141 RID: 8513
		int Receive(byte[] buf, int off, int len, int waitMillis);

		// Token: 0x06002142 RID: 8514
		void Send(byte[] buf, int off, int len);
	}
}
