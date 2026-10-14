using System;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls.Crypto.Impl
{
	// Token: 0x02000159 RID: 345
	public abstract class AbstractTlsCrypto : global::Org.BouncyCastle.Tls.Crypto.TlsCrypto
	{
		// Token: 0x06000D68 RID: 3432
		public abstract bool HasAllRawSignatureAlgorithms();

		// Token: 0x06000D69 RID: 3433
		public abstract bool HasDHAgreement();

		// Token: 0x06000D6A RID: 3434
		public abstract bool HasECDHAgreement();

		// Token: 0x06000D6B RID: 3435
		public abstract bool HasEncryptionAlgorithm(int encryptionAlgorithm);

		// Token: 0x06000D6C RID: 3436
		public abstract bool HasCryptoHashAlgorithm(int cryptoHashAlgorithm);

		// Token: 0x06000D6D RID: 3437
		public abstract bool HasCryptoSignatureAlgorithm(int cryptoSignatureAlgorithm);

		// Token: 0x06000D6E RID: 3438
		public abstract bool HasMacAlgorithm(int macAlgorithm);

		// Token: 0x06000D6F RID: 3439
		public abstract bool HasNamedGroup(int namedGroup);

		// Token: 0x06000D70 RID: 3440
		public abstract bool HasRsaEncryption();

		// Token: 0x06000D71 RID: 3441
		public abstract bool HasSignatureAlgorithm(short signatureAlgorithm);

		// Token: 0x06000D72 RID: 3442
		public abstract bool HasSignatureAndHashAlgorithm(global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm sigAndHashAlgorithm);

		// Token: 0x06000D73 RID: 3443
		public abstract bool HasSignatureScheme(int signatureScheme);

		// Token: 0x06000D74 RID: 3444
		public abstract bool HasSrpAuthentication();

		// Token: 0x06000D75 RID: 3445
		public abstract global::Org.BouncyCastle.Tls.Crypto.TlsSecret CreateSecret(byte[] data);

		// Token: 0x06000D76 RID: 3446
		public abstract global::Org.BouncyCastle.Tls.Crypto.TlsSecret GenerateRsaPreMasterSecret(global::Org.BouncyCastle.Tls.ProtocolVersion clientVersion);

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000D77 RID: 3447
		public abstract global::Org.BouncyCastle.Security.SecureRandom SecureRandom { get; }

		// Token: 0x06000D78 RID: 3448
		public abstract global::Org.BouncyCastle.Tls.Crypto.TlsCertificate CreateCertificate(byte[] encoding);

		// Token: 0x06000D79 RID: 3449
		public abstract global::Org.BouncyCastle.Tls.Crypto.TlsCipher CreateCipher(global::Org.BouncyCastle.Tls.Crypto.TlsCryptoParameters cryptoParams, int encryptionAlgorithm, int macAlgorithm);

		// Token: 0x06000D7A RID: 3450
		public abstract global::Org.BouncyCastle.Tls.Crypto.TlsDHDomain CreateDHDomain(global::Org.BouncyCastle.Tls.Crypto.TlsDHConfig dhConfig);

		// Token: 0x06000D7B RID: 3451
		public abstract global::Org.BouncyCastle.Tls.Crypto.TlsECDomain CreateECDomain(global::Org.BouncyCastle.Tls.Crypto.TlsECConfig ecConfig);

		// Token: 0x06000D7C RID: 3452 RVA: 0x000325C4 File Offset: 0x000307C4
		public virtual global::Org.BouncyCastle.Tls.Crypto.TlsSecret AdoptSecret(global::Org.BouncyCastle.Tls.Crypto.TlsSecret secret)
		{
			if (secret is global::Org.BouncyCastle.Tls.Crypto.Impl.AbstractTlsSecret)
			{
				global::Org.BouncyCastle.Tls.Crypto.Impl.AbstractTlsSecret sec = (global::Org.BouncyCastle.Tls.Crypto.Impl.AbstractTlsSecret)secret;
				return this.CreateSecret(sec.CopyData());
			}
			throw new global::System.ArgumentException("unrecognized TlsSecret - cannot copy data: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(secret));
		}

		// Token: 0x06000D7D RID: 3453
		public abstract global::Org.BouncyCastle.Tls.Crypto.TlsHash CreateHash(int cryptoHashAlgorithm);

		// Token: 0x06000D7E RID: 3454
		public abstract global::Org.BouncyCastle.Tls.Crypto.TlsHmac CreateHmac(int macAlgorithm);

		// Token: 0x06000D7F RID: 3455
		public abstract global::Org.BouncyCastle.Tls.Crypto.TlsHmac CreateHmacForHash(int cryptoHashAlgorithm);

		// Token: 0x06000D80 RID: 3456
		public abstract global::Org.BouncyCastle.Tls.Crypto.TlsNonceGenerator CreateNonceGenerator(byte[] additionalSeedMaterial);

		// Token: 0x06000D81 RID: 3457
		public abstract global::Org.BouncyCastle.Tls.Crypto.TlsSrp6Client CreateSrp6Client(global::Org.BouncyCastle.Tls.Crypto.TlsSrpConfig srpConfig);

		// Token: 0x06000D82 RID: 3458
		public abstract global::Org.BouncyCastle.Tls.Crypto.TlsSrp6Server CreateSrp6Server(global::Org.BouncyCastle.Tls.Crypto.TlsSrpConfig srpConfig, global::Org.BouncyCastle.Math.BigInteger srpVerifier);

		// Token: 0x06000D83 RID: 3459
		public abstract global::Org.BouncyCastle.Tls.Crypto.TlsSrp6VerifierGenerator CreateSrp6VerifierGenerator(global::Org.BouncyCastle.Tls.Crypto.TlsSrpConfig srpConfig);

		// Token: 0x06000D84 RID: 3460
		public abstract global::Org.BouncyCastle.Tls.Crypto.TlsSecret HkdfInit(int cryptoHashAlgorithm);
	}
}
