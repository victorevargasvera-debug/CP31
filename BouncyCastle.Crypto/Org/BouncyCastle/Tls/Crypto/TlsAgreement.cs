using System;

namespace Org.BouncyCastle.Tls.Crypto
{
	// Token: 0x0200013A RID: 314
	public interface TlsAgreement
	{
		// Token: 0x06000CE0 RID: 3296
		byte[] GenerateEphemeral();

		// Token: 0x06000CE1 RID: 3297
		void ReceivePeerValue(byte[] peerValue);

		// Token: 0x06000CE2 RID: 3298
		global::Org.BouncyCastle.Tls.Crypto.TlsSecret CalculateSecret();
	}
}
