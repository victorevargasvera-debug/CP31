using System;
using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x02000101 RID: 257
	public interface TlsCredentialedSigner : global::Org.BouncyCastle.Tls.TlsCredentials
	{
		// Token: 0x06000936 RID: 2358
		byte[] GenerateRawSignature(byte[] hash);

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000937 RID: 2359
		global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm SignatureAndHashAlgorithm { get; }

		// Token: 0x06000938 RID: 2360
		global::Org.BouncyCastle.Tls.Crypto.TlsStreamSigner GetStreamSigner();
	}
}
