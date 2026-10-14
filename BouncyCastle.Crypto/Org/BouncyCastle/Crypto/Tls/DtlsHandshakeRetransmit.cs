using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000323 RID: 803
	internal interface DtlsHandshakeRetransmit
	{
		// Token: 0x060021C2 RID: 8642
		void ReceivedHandshakeRecord(int epoch, byte[] buf, int off, int len);
	}
}
