using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x020002F2 RID: 754
	public abstract class AbstractTlsAgreementCredentials : global::Org.BouncyCastle.Crypto.Tls.AbstractTlsCredentials, global::Org.BouncyCastle.Crypto.Tls.TlsAgreementCredentials, global::Org.BouncyCastle.Crypto.Tls.TlsCredentials
	{
		// Token: 0x0600204B RID: 8267
		public abstract byte[] GenerateAgreement(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter peerPublicKey);
	}
}
