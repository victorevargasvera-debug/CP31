using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000356 RID: 854
	public interface TlsAgreementCredentials : global::Org.BouncyCastle.Crypto.Tls.TlsCredentials
	{
		// Token: 0x060022F0 RID: 8944
		byte[] GenerateAgreement(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter peerPublicKey);
	}
}
