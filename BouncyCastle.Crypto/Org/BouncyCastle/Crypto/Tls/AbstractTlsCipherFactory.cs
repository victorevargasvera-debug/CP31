using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x020002F3 RID: 755
	public class AbstractTlsCipherFactory : global::Org.BouncyCastle.Crypto.Tls.TlsCipherFactory
	{
		// Token: 0x0600204D RID: 8269 RVA: 0x000912D3 File Offset: 0x0008F4D3
		public virtual global::Org.BouncyCastle.Crypto.Tls.TlsCipher CreateCipher(global::Org.BouncyCastle.Crypto.Tls.TlsContext context, int encryptionAlgorithm, int macAlgorithm)
		{
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
		}
	}
}
