using System;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Tls.Crypto
{
	// Token: 0x0200013E RID: 318
	public interface TlsCrypto
	{
		// Token: 0x06000CF8 RID: 3320
		bool HasAllRawSignatureAlgorithms();

		// Token: 0x06000CF9 RID: 3321
		bool HasDHAgreement();

		// Token: 0x06000CFA RID: 3322
		bool HasECDHAgreement();

		// Token: 0x06000CFB RID: 3323
		bool HasEncryptionAlgorithm(int encryptionAlgorithm);

		// Token: 0x06000CFC RID: 3324
		bool HasCryptoHashAlgorithm(int cryptoHashAlgorithm);

		// Token: 0x06000CFD RID: 3325
		bool HasCryptoSignatureAlgorithm(int cryptoSignatureAlgorithm);

		// Token: 0x06000CFE RID: 3326
		bool HasMacAlgorithm(int macAlgorithm);

		// Token: 0x06000CFF RID: 3327
		bool HasNamedGroup(int namedGroup);

		// Token: 0x06000D00 RID: 3328
		bool HasRsaEncryption();

		// Token: 0x06000D01 RID: 3329
		bool HasSignatureAlgorithm(short signatureAlgorithm);

		// Token: 0x06000D02 RID: 3330
		bool HasSignatureAndHashAlgorithm(global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm sigAndHashAlgorithm);

		// Token: 0x06000D03 RID: 3331
		bool HasSignatureScheme(int signatureScheme);

		// Token: 0x06000D04 RID: 3332
		bool HasSrpAuthentication();

		// Token: 0x06000D05 RID: 3333
		global::Org.BouncyCastle.Tls.Crypto.TlsSecret CreateSecret(byte[] data);

		// Token: 0x06000D06 RID: 3334
		global::Org.BouncyCastle.Tls.Crypto.TlsSecret GenerateRsaPreMasterSecret(global::Org.BouncyCastle.Tls.ProtocolVersion clientVersion);

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000D07 RID: 3335
		global::Org.BouncyCastle.Security.SecureRandom SecureRandom { get; }

		// Token: 0x06000D08 RID: 3336
		global::Org.BouncyCastle.Tls.Crypto.TlsCertificate CreateCertificate(byte[] encoding);

		// Token: 0x06000D09 RID: 3337
		global::Org.BouncyCastle.Tls.Crypto.TlsCipher CreateCipher(global::Org.BouncyCastle.Tls.Crypto.TlsCryptoParameters cryptoParams, int encryptionAlgorithm, int macAlgorithm);

		// Token: 0x06000D0A RID: 3338
		global::Org.BouncyCastle.Tls.Crypto.TlsDHDomain CreateDHDomain(global::Org.BouncyCastle.Tls.Crypto.TlsDHConfig dhConfig);

		// Token: 0x06000D0B RID: 3339
		global::Org.BouncyCastle.Tls.Crypto.TlsECDomain CreateECDomain(global::Org.BouncyCastle.Tls.Crypto.TlsECConfig ecConfig);

		// Token: 0x06000D0C RID: 3340
		global::Org.BouncyCastle.Tls.Crypto.TlsSecret AdoptSecret(global::Org.BouncyCastle.Tls.Crypto.TlsSecret secret);

		// Token: 0x06000D0D RID: 3341
		global::Org.BouncyCastle.Tls.Crypto.TlsHash CreateHash(int cryptoHashAlgorithm);

		// Token: 0x06000D0E RID: 3342
		global::Org.BouncyCastle.Tls.Crypto.TlsHmac CreateHmac(int macAlgorithm);

		// Token: 0x06000D0F RID: 3343
		global::Org.BouncyCastle.Tls.Crypto.TlsHmac CreateHmacForHash(int cryptoHashAlgorithm);

		// Token: 0x06000D10 RID: 3344
		global::Org.BouncyCastle.Tls.Crypto.TlsNonceGenerator CreateNonceGenerator(byte[] additionalSeedMaterial);

		// Token: 0x06000D11 RID: 3345
		global::Org.BouncyCastle.Tls.Crypto.TlsSrp6Client CreateSrp6Client(global::Org.BouncyCastle.Tls.Crypto.TlsSrpConfig srpConfig);

		// Token: 0x06000D12 RID: 3346
		global::Org.BouncyCastle.Tls.Crypto.TlsSrp6Server CreateSrp6Server(global::Org.BouncyCastle.Tls.Crypto.TlsSrpConfig srpConfig, global::Org.BouncyCastle.Math.BigInteger srpVerifier);

		// Token: 0x06000D13 RID: 3347
		global::Org.BouncyCastle.Tls.Crypto.TlsSrp6VerifierGenerator CreateSrp6VerifierGenerator(global::Org.BouncyCastle.Tls.Crypto.TlsSrpConfig srpConfig);

		// Token: 0x06000D14 RID: 3348
		global::Org.BouncyCastle.Tls.Crypto.TlsSecret HkdfInit(int cryptoHashAlgorithm);
	}
}
