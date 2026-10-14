using System;

namespace Org.BouncyCastle.Tls.Crypto
{
	// Token: 0x02000151 RID: 337
	public interface TlsSigner
	{
		// Token: 0x06000D58 RID: 3416
		byte[] GenerateRawSignature(global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm algorithm, byte[] hash);

		// Token: 0x06000D59 RID: 3417
		global::Org.BouncyCastle.Tls.Crypto.TlsStreamSigner GetStreamSigner(global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm algorithm);
	}
}
