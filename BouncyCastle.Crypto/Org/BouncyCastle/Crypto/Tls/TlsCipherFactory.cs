using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200035A RID: 858
	public interface TlsCipherFactory
	{
		// Token: 0x060022FF RID: 8959
		global::Org.BouncyCastle.Crypto.Tls.TlsCipher CreateCipher(global::Org.BouncyCastle.Crypto.Tls.TlsContext context, int encryptionAlgorithm, int macAlgorithm);
	}
}
