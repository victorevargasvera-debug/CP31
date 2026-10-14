using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200031C RID: 796
	public class DefaultTlsSignerCredentials : global::Org.BouncyCastle.Crypto.Tls.AbstractTlsSignerCredentials
	{
		// Token: 0x06002186 RID: 8582 RVA: 0x00093BC0 File Offset: 0x00091DC0
		public DefaultTlsSignerCredentials(global::Org.BouncyCastle.Crypto.Tls.TlsContext context, global::Org.BouncyCastle.Crypto.Tls.Certificate certificate, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey) : this(context, certificate, privateKey, null)
		{
		}

		// Token: 0x06002187 RID: 8583 RVA: 0x00093BCC File Offset: 0x00091DCC
		public DefaultTlsSignerCredentials(global::Org.BouncyCastle.Crypto.Tls.TlsContext context, global::Org.BouncyCastle.Crypto.Tls.Certificate certificate, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm signatureAndHashAlgorithm)
		{
			if (certificate == null)
			{
				throw new global::System.ArgumentNullException("certificate");
			}
			if (certificate.IsEmpty)
			{
				throw new global::System.ArgumentException("cannot be empty", "clientCertificate");
			}
			if (privateKey == null)
			{
				throw new global::System.ArgumentNullException("privateKey");
			}
			if (!privateKey.IsPrivate)
			{
				throw new global::System.ArgumentException("must be private", "privateKey");
			}
			if (global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsTlsV12(context) && signatureAndHashAlgorithm == null)
			{
				throw new global::System.ArgumentException("cannot be null for (D)TLS 1.2+", "signatureAndHashAlgorithm");
			}
			if (privateKey is global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters)
			{
				this.mSigner = new global::Org.BouncyCastle.Crypto.Tls.TlsRsaSigner();
			}
			else if (privateKey is global::Org.BouncyCastle.Crypto.Parameters.DsaPrivateKeyParameters)
			{
				this.mSigner = new global::Org.BouncyCastle.Crypto.Tls.TlsDssSigner();
			}
			else
			{
				if (!(privateKey is global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters))
				{
					throw new global::System.ArgumentException("type not supported: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(privateKey), "privateKey");
				}
				this.mSigner = new global::Org.BouncyCastle.Crypto.Tls.TlsECDsaSigner();
			}
			this.mSigner.Init(context);
			this.mContext = context;
			this.mCertificate = certificate;
			this.mPrivateKey = privateKey;
			this.mSignatureAndHashAlgorithm = signatureAndHashAlgorithm;
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06002188 RID: 8584 RVA: 0x00093CCA File Offset: 0x00091ECA
		public override global::Org.BouncyCastle.Crypto.Tls.Certificate Certificate
		{
			get
			{
				return this.mCertificate;
			}
		}

		// Token: 0x06002189 RID: 8585 RVA: 0x00093CD4 File Offset: 0x00091ED4
		public override byte[] GenerateCertificateSignature(byte[] hash)
		{
			byte[] result;
			try
			{
				if (global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsTlsV12(this.mContext))
				{
					result = this.mSigner.GenerateRawSignature(this.mSignatureAndHashAlgorithm, this.mPrivateKey, hash);
				}
				else
				{
					result = this.mSigner.GenerateRawSignature(this.mPrivateKey, hash);
				}
			}
			catch (global::Org.BouncyCastle.Crypto.CryptoException e)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80, e);
			}
			return result;
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x0600218A RID: 8586 RVA: 0x00093D3C File Offset: 0x00091F3C
		public override global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm SignatureAndHashAlgorithm
		{
			get
			{
				return this.mSignatureAndHashAlgorithm;
			}
		}

		// Token: 0x04000CD7 RID: 3287
		protected readonly global::Org.BouncyCastle.Crypto.Tls.TlsContext mContext;

		// Token: 0x04000CD8 RID: 3288
		protected readonly global::Org.BouncyCastle.Crypto.Tls.Certificate mCertificate;

		// Token: 0x04000CD9 RID: 3289
		protected readonly global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter mPrivateKey;

		// Token: 0x04000CDA RID: 3290
		protected readonly global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm mSignatureAndHashAlgorithm;

		// Token: 0x04000CDB RID: 3291
		protected readonly global::Org.BouncyCastle.Crypto.Tls.TlsSigner mSigner;
	}
}
