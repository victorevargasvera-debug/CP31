using System;

namespace Org.BouncyCastle.Tls.Crypto
{
	// Token: 0x02000150 RID: 336
	public interface TlsSecret
	{
		// Token: 0x06000D50 RID: 3408
		byte[] CalculateHmac(int cryptoHashAlgorithm, byte[] buf, int off, int len);

		// Token: 0x06000D51 RID: 3409
		global::Org.BouncyCastle.Tls.Crypto.TlsSecret DeriveUsingPrf(int prfAlgorithm, string label, byte[] seed, int length);

		// Token: 0x06000D52 RID: 3410
		void Destroy();

		// Token: 0x06000D53 RID: 3411
		byte[] Encrypt(global::Org.BouncyCastle.Tls.Crypto.TlsEncryptor encryptor);

		// Token: 0x06000D54 RID: 3412
		byte[] Extract();

		// Token: 0x06000D55 RID: 3413
		global::Org.BouncyCastle.Tls.Crypto.TlsSecret HkdfExpand(int cryptoHashAlgorithm, byte[] info, int length);

		// Token: 0x06000D56 RID: 3414
		global::Org.BouncyCastle.Tls.Crypto.TlsSecret HkdfExtract(int cryptoHashAlgorithm, global::Org.BouncyCastle.Tls.Crypto.TlsSecret ikm);

		// Token: 0x06000D57 RID: 3415
		bool IsAlive();
	}
}
