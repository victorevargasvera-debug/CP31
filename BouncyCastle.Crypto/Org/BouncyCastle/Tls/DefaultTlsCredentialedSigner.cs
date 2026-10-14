using System;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Tls.Crypto.Impl;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000AE RID: 174
	public class DefaultTlsCredentialedSigner : global::Org.BouncyCastle.Tls.TlsCredentialedSigner, global::Org.BouncyCastle.Tls.TlsCredentials
	{
		// Token: 0x06000695 RID: 1685 RVA: 0x0001B2CC File Offset: 0x000194CC
		public DefaultTlsCredentialedSigner(global::Org.BouncyCastle.Tls.Crypto.TlsCryptoParameters cryptoParams, global::Org.BouncyCastle.Tls.Crypto.TlsSigner signer, global::Org.BouncyCastle.Tls.Certificate certificate, global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm signatureAndHashAlgorithm)
		{
			if (certificate == null)
			{
				throw new global::System.ArgumentNullException("certificate");
			}
			if (certificate.IsEmpty)
			{
				throw new global::System.ArgumentException("cannot be empty", "certificate");
			}
			if (signer == null)
			{
				throw new global::System.ArgumentNullException("signer");
			}
			this.m_cryptoParams = cryptoParams;
			this.m_certificate = certificate;
			this.m_signatureAndHashAlgorithm = signatureAndHashAlgorithm;
			this.m_signer = signer;
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000696 RID: 1686 RVA: 0x0001B330 File Offset: 0x00019530
		public virtual global::Org.BouncyCastle.Tls.Certificate Certificate
		{
			get
			{
				return this.m_certificate;
			}
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x0001B338 File Offset: 0x00019538
		public virtual byte[] GenerateRawSignature(byte[] hash)
		{
			return this.m_signer.GenerateRawSignature(this.GetEffectiveAlgorithm(), hash);
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000698 RID: 1688 RVA: 0x0001B34C File Offset: 0x0001954C
		public virtual global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm SignatureAndHashAlgorithm
		{
			get
			{
				return this.m_signatureAndHashAlgorithm;
			}
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x0001B354 File Offset: 0x00019554
		public virtual global::Org.BouncyCastle.Tls.Crypto.TlsStreamSigner GetStreamSigner()
		{
			return this.m_signer.GetStreamSigner(this.GetEffectiveAlgorithm());
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x0001B368 File Offset: 0x00019568
		protected virtual global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm GetEffectiveAlgorithm()
		{
			global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm algorithm = null;
			if (global::Org.BouncyCastle.Tls.Crypto.Impl.TlsImplUtilities.IsTlsV12(this.m_cryptoParams))
			{
				algorithm = this.SignatureAndHashAlgorithm;
				if (algorithm == null)
				{
					throw new global::System.InvalidOperationException("'signatureAndHashAlgorithm' cannot be null for (D)TLS 1.2+");
				}
			}
			return algorithm;
		}

		// Token: 0x040004C6 RID: 1222
		protected readonly global::Org.BouncyCastle.Tls.Crypto.TlsCryptoParameters m_cryptoParams;

		// Token: 0x040004C7 RID: 1223
		protected readonly global::Org.BouncyCastle.Tls.Certificate m_certificate;

		// Token: 0x040004C8 RID: 1224
		protected readonly global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm m_signatureAndHashAlgorithm;

		// Token: 0x040004C9 RID: 1225
		protected readonly global::Org.BouncyCastle.Tls.Crypto.TlsSigner m_signer;
	}
}
