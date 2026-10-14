using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000389 RID: 905
	public interface TlsSignerCredentials : global::Org.BouncyCastle.Crypto.Tls.TlsCredentials
	{
		// Token: 0x060024C5 RID: 9413
		byte[] GenerateCertificateSignature(byte[] hash);

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x060024C6 RID: 9414
		global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm SignatureAndHashAlgorithm { get; }
	}
}
