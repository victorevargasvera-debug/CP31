using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000388 RID: 904
	public interface TlsSigner
	{
		// Token: 0x060024BB RID: 9403
		void Init(global::Org.BouncyCastle.Crypto.Tls.TlsContext context);

		// Token: 0x060024BC RID: 9404
		byte[] GenerateRawSignature(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, byte[] md5AndSha1);

		// Token: 0x060024BD RID: 9405
		byte[] GenerateRawSignature(global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm algorithm, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, byte[] hash);

		// Token: 0x060024BE RID: 9406
		bool VerifyRawSignature(byte[] sigBytes, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey, byte[] md5AndSha1);

		// Token: 0x060024BF RID: 9407
		bool VerifyRawSignature(global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm algorithm, byte[] sigBytes, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey, byte[] hash);

		// Token: 0x060024C0 RID: 9408
		global::Org.BouncyCastle.Crypto.ISigner CreateSigner(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey);

		// Token: 0x060024C1 RID: 9409
		global::Org.BouncyCastle.Crypto.ISigner CreateSigner(global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm algorithm, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey);

		// Token: 0x060024C2 RID: 9410
		global::Org.BouncyCastle.Crypto.ISigner CreateVerifyer(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey);

		// Token: 0x060024C3 RID: 9411
		global::Org.BouncyCastle.Crypto.ISigner CreateVerifyer(global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm algorithm, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey);

		// Token: 0x060024C4 RID: 9412
		bool IsValidPublicKey(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey);
	}
}
