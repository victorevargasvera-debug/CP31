using System;

namespace Org.BouncyCastle.Tls.Crypto
{
	// Token: 0x02000158 RID: 344
	public interface TlsVerifier
	{
		// Token: 0x06000D66 RID: 3430
		global::Org.BouncyCastle.Tls.Crypto.TlsStreamVerifier GetStreamVerifier(global::Org.BouncyCastle.Tls.DigitallySigned signature);

		// Token: 0x06000D67 RID: 3431
		bool VerifyRawSignature(global::Org.BouncyCastle.Tls.DigitallySigned signature, byte[] hash);
	}
}
