using System;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000B9 RID: 185
	internal interface DtlsHandshakeRetransmit
	{
		// Token: 0x060006FB RID: 1787
		void ReceivedHandshakeRecord(int epoch, byte[] buf, int off, int len);
	}
}
