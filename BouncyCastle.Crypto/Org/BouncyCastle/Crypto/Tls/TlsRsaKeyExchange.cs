using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200037F RID: 895
	public class TlsRsaKeyExchange : global::Org.BouncyCastle.Crypto.Tls.AbstractTlsKeyExchange
	{
		// Token: 0x06002473 RID: 9331 RVA: 0x0009E951 File Offset: 0x0009CB51
		public TlsRsaKeyExchange(global::System.Collections.IList supportedSignatureAlgorithms) : base(1, supportedSignatureAlgorithms)
		{
		}

		// Token: 0x06002474 RID: 9332 RVA: 0x0009E95B File Offset: 0x0009CB5B
		public override void SkipServerCredentials()
		{
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
		}

		// Token: 0x06002475 RID: 9333 RVA: 0x0009E964 File Offset: 0x0009CB64
		public override void ProcessServerCredentials(global::Org.BouncyCastle.Crypto.Tls.TlsCredentials serverCredentials)
		{
			if (!(serverCredentials is global::Org.BouncyCastle.Crypto.Tls.TlsEncryptionCredentials))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
			this.ProcessServerCertificate(serverCredentials.Certificate);
			this.mServerCredentials = (global::Org.BouncyCastle.Crypto.Tls.TlsEncryptionCredentials)serverCredentials;
		}

		// Token: 0x06002476 RID: 9334 RVA: 0x0009E990 File Offset: 0x0009CB90
		public override void ProcessServerCertificate(global::Org.BouncyCastle.Crypto.Tls.Certificate serverCertificate)
		{
			if (serverCertificate.IsEmpty)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(50);
			}
			global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure x509Cert = serverCertificate.GetCertificateAt(0);
			global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo keyInfo = x509Cert.SubjectPublicKeyInfo;
			try
			{
				this.mServerPublicKey = global::Org.BouncyCastle.Security.PublicKeyFactory.CreateKey(keyInfo);
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(43, e);
			}
			if (this.mServerPublicKey.IsPrivate)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
			this.mRsaServerPublicKey = this.ValidateRsaPublicKey((global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters)this.mServerPublicKey);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ValidateKeyUsage(x509Cert, 32);
			base.ProcessServerCertificate(serverCertificate);
		}

		// Token: 0x06002477 RID: 9335 RVA: 0x0009EA20 File Offset: 0x0009CC20
		public override void ValidateCertificateRequest(global::Org.BouncyCastle.Crypto.Tls.CertificateRequest certificateRequest)
		{
			foreach (byte b in certificateRequest.CertificateTypes)
			{
				if (b - 1 > 1 && b != 64)
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
				}
			}
		}

		// Token: 0x06002478 RID: 9336 RVA: 0x0009EA59 File Offset: 0x0009CC59
		public override void ProcessClientCredentials(global::Org.BouncyCastle.Crypto.Tls.TlsCredentials clientCredentials)
		{
			if (!(clientCredentials is global::Org.BouncyCastle.Crypto.Tls.TlsSignerCredentials))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
		}

		// Token: 0x06002479 RID: 9337 RVA: 0x0009EA6B File Offset: 0x0009CC6B
		public override void GenerateClientKeyExchange(global::System.IO.Stream output)
		{
			this.mPremasterSecret = global::Org.BouncyCastle.Crypto.Tls.TlsRsaUtilities.GenerateEncryptedPreMasterSecret(this.mContext, this.mRsaServerPublicKey, output);
		}

		// Token: 0x0600247A RID: 9338 RVA: 0x0009EA88 File Offset: 0x0009CC88
		public override void ProcessClientKeyExchange(global::System.IO.Stream input)
		{
			byte[] encryptedPreMasterSecret;
			if (global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsSsl(this.mContext))
			{
				encryptedPreMasterSecret = global::Org.BouncyCastle.Utilities.IO.Streams.ReadAll(input);
			}
			else
			{
				encryptedPreMasterSecret = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque16(input);
			}
			this.mPremasterSecret = this.mServerCredentials.DecryptPreMasterSecret(encryptedPreMasterSecret);
		}

		// Token: 0x0600247B RID: 9339 RVA: 0x0009EAC4 File Offset: 0x0009CCC4
		public override byte[] GeneratePremasterSecret()
		{
			if (this.mPremasterSecret == null)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
			byte[] result = this.mPremasterSecret;
			this.mPremasterSecret = null;
			return result;
		}

		// Token: 0x0600247C RID: 9340 RVA: 0x0009EAE3 File Offset: 0x0009CCE3
		protected virtual global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters ValidateRsaPublicKey(global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters key)
		{
			if (!key.Exponent.IsProbablePrime(2))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
			}
			return key;
		}

		// Token: 0x04000EB9 RID: 3769
		protected global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter mServerPublicKey;

		// Token: 0x04000EBA RID: 3770
		protected global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters mRsaServerPublicKey;

		// Token: 0x04000EBB RID: 3771
		protected global::Org.BouncyCastle.Crypto.Tls.TlsEncryptionCredentials mServerCredentials;

		// Token: 0x04000EBC RID: 3772
		protected byte[] mPremasterSecret;
	}
}
