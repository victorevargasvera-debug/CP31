using System;
using Org.BouncyCastle.Crypto.Agreement;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000316 RID: 790
	public class DefaultTlsAgreementCredentials : global::Org.BouncyCastle.Crypto.Tls.AbstractTlsAgreementCredentials
	{
		// Token: 0x06002143 RID: 8515 RVA: 0x000931B4 File Offset: 0x000913B4
		public DefaultTlsAgreementCredentials(global::Org.BouncyCastle.Crypto.Tls.Certificate certificate, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey)
		{
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
				this.mBasicAgreement = new global::Org.BouncyCastle.Crypto.Agreement.DHBasicAgreement();
				this.mTruncateAgreement = true;
			}
			else
			{
				if (!(privateKey is global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters))
				{
					throw new global::System.ArgumentException("type not supported: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(privateKey), "privateKey");
				}
				this.mBasicAgreement = new global::Org.BouncyCastle.Crypto.Agreement.ECDHBasicAgreement();
				this.mTruncateAgreement = false;
			}
			this.mCertificate = certificate;
			this.mPrivateKey = privateKey;
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06002144 RID: 8516 RVA: 0x00093274 File Offset: 0x00091474
		public override global::Org.BouncyCastle.Crypto.Tls.Certificate Certificate
		{
			get
			{
				return this.mCertificate;
			}
		}

		// Token: 0x06002145 RID: 8517 RVA: 0x0009327C File Offset: 0x0009147C
		public override byte[] GenerateAgreement(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter peerPublicKey)
		{
			this.mBasicAgreement.Init(this.mPrivateKey);
			global::Org.BouncyCastle.Math.BigInteger agreementValue = this.mBasicAgreement.CalculateAgreement(peerPublicKey);
			if (this.mTruncateAgreement)
			{
				return global::Org.BouncyCastle.Utilities.BigIntegers.AsUnsignedByteArray(agreementValue);
			}
			return global::Org.BouncyCastle.Utilities.BigIntegers.AsUnsignedByteArray(this.mBasicAgreement.GetFieldSize(), agreementValue);
		}

		// Token: 0x04000CCB RID: 3275
		protected readonly global::Org.BouncyCastle.Crypto.Tls.Certificate mCertificate;

		// Token: 0x04000CCC RID: 3276
		protected readonly global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter mPrivateKey;

		// Token: 0x04000CCD RID: 3277
		protected readonly global::Org.BouncyCastle.Crypto.IBasicAgreement mBasicAgreement;

		// Token: 0x04000CCE RID: 3278
		protected readonly bool mTruncateAgreement;
	}
}
