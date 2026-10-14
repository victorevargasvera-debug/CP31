using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC
{
	// Token: 0x02000165 RID: 357
	public class BcDefaultTlsCredentialedAgreement : global::Org.BouncyCastle.Tls.TlsCredentialedAgreement, global::Org.BouncyCastle.Tls.TlsCredentials
	{
		// Token: 0x06000DE1 RID: 3553 RVA: 0x0003408C File Offset: 0x0003228C
		public BcDefaultTlsCredentialedAgreement(global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto crypto, global::Org.BouncyCastle.Tls.Certificate certificate, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey)
		{
			if (crypto == null)
			{
				throw new global::System.ArgumentNullException("crypto");
			}
			if (certificate == null)
			{
				throw new global::System.ArgumentNullException("certificate");
			}
			if (certificate.IsEmpty)
			{
				throw new global::System.ArgumentException("cannot be empty", "certificate");
			}
			if (privateKey == null)
			{
				throw new global::System.ArgumentNullException("privateKey");
			}
			if (!privateKey.IsPrivate)
			{
				throw new global::System.ArgumentException("must be private", "privateKey");
			}
			if (privateKey is global::Org.BouncyCastle.Crypto.Parameters.DHPrivateKeyParameters)
			{
				this.m_agreementCredentials = new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcDefaultTlsCredentialedAgreement.DHCredentialedAgreement(crypto, certificate, (global::Org.BouncyCastle.Crypto.Parameters.DHPrivateKeyParameters)privateKey);
				return;
			}
			if (privateKey is global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters)
			{
				this.m_agreementCredentials = new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcDefaultTlsCredentialedAgreement.ECCredentialedAgreement(crypto, certificate, (global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters)privateKey);
				return;
			}
			throw new global::System.ArgumentException("'privateKey' type not supported: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(privateKey));
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000DE2 RID: 3554 RVA: 0x00034146 File Offset: 0x00032346
		public virtual global::Org.BouncyCastle.Tls.Certificate Certificate
		{
			get
			{
				return this.m_agreementCredentials.Certificate;
			}
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x00034153 File Offset: 0x00032353
		public virtual global::Org.BouncyCastle.Tls.Crypto.TlsSecret GenerateAgreement(global::Org.BouncyCastle.Tls.Crypto.TlsCertificate peerCertificate)
		{
			return this.m_agreementCredentials.GenerateAgreement(peerCertificate);
		}

		// Token: 0x04000804 RID: 2052
		protected readonly global::Org.BouncyCastle.Tls.TlsCredentialedAgreement m_agreementCredentials;

		// Token: 0x020007AD RID: 1965
		private sealed class DHCredentialedAgreement : global::Org.BouncyCastle.Tls.TlsCredentialedAgreement, global::Org.BouncyCastle.Tls.TlsCredentials
		{
			// Token: 0x0600452E RID: 17710 RVA: 0x00132B7B File Offset: 0x00130D7B
			internal DHCredentialedAgreement(global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto crypto, global::Org.BouncyCastle.Tls.Certificate certificate, global::Org.BouncyCastle.Crypto.Parameters.DHPrivateKeyParameters privateKey)
			{
				this.m_crypto = crypto;
				this.m_certificate = certificate;
				this.m_privateKey = privateKey;
			}

			// Token: 0x0600452F RID: 17711 RVA: 0x00132B98 File Offset: 0x00130D98
			public global::Org.BouncyCastle.Tls.Crypto.TlsSecret GenerateAgreement(global::Org.BouncyCastle.Tls.Crypto.TlsCertificate peerCertificate)
			{
				global::Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters peerPublicKey = global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCertificate.Convert(this.m_crypto, peerCertificate).GetPubKeyDH();
				return global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsDHDomain.CalculateDHAgreement(this.m_crypto, this.m_privateKey, peerPublicKey, false);
			}

			// Token: 0x17000A72 RID: 2674
			// (get) Token: 0x06004530 RID: 17712 RVA: 0x00132BCA File Offset: 0x00130DCA
			public global::Org.BouncyCastle.Tls.Certificate Certificate
			{
				get
				{
					return this.m_certificate;
				}
			}

			// Token: 0x0400232C RID: 9004
			private readonly global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto m_crypto;

			// Token: 0x0400232D RID: 9005
			private readonly global::Org.BouncyCastle.Tls.Certificate m_certificate;

			// Token: 0x0400232E RID: 9006
			private readonly global::Org.BouncyCastle.Crypto.Parameters.DHPrivateKeyParameters m_privateKey;
		}

		// Token: 0x020007AE RID: 1966
		private sealed class ECCredentialedAgreement : global::Org.BouncyCastle.Tls.TlsCredentialedAgreement, global::Org.BouncyCastle.Tls.TlsCredentials
		{
			// Token: 0x06004531 RID: 17713 RVA: 0x00132BD2 File Offset: 0x00130DD2
			internal ECCredentialedAgreement(global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto crypto, global::Org.BouncyCastle.Tls.Certificate certificate, global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters privateKey)
			{
				this.m_crypto = crypto;
				this.m_certificate = certificate;
				this.m_privateKey = privateKey;
			}

			// Token: 0x06004532 RID: 17714 RVA: 0x00132BF0 File Offset: 0x00130DF0
			public global::Org.BouncyCastle.Tls.Crypto.TlsSecret GenerateAgreement(global::Org.BouncyCastle.Tls.Crypto.TlsCertificate peerCertificate)
			{
				global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters peerPublicKey = global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCertificate.Convert(this.m_crypto, peerCertificate).GetPubKeyEC();
				return global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsECDomain.CalculateBasicAgreement(this.m_crypto, this.m_privateKey, peerPublicKey);
			}

			// Token: 0x17000A73 RID: 2675
			// (get) Token: 0x06004533 RID: 17715 RVA: 0x00132C21 File Offset: 0x00130E21
			public global::Org.BouncyCastle.Tls.Certificate Certificate
			{
				get
				{
					return this.m_certificate;
				}
			}

			// Token: 0x0400232F RID: 9007
			private readonly global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto m_crypto;

			// Token: 0x04002330 RID: 9008
			private readonly global::Org.BouncyCastle.Tls.Certificate m_certificate;

			// Token: 0x04002331 RID: 9009
			private readonly global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters m_privateKey;
		}
	}
}
