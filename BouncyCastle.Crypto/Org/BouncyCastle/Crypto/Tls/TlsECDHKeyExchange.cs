using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200036C RID: 876
	public class TlsECDHKeyExchange : global::Org.BouncyCastle.Crypto.Tls.AbstractTlsKeyExchange
	{
		// Token: 0x060023A0 RID: 9120 RVA: 0x0009C194 File Offset: 0x0009A394
		public TlsECDHKeyExchange(int keyExchange, global::System.Collections.IList supportedSignatureAlgorithms, int[] namedCurves, byte[] clientECPointFormats, byte[] serverECPointFormats) : base(keyExchange, supportedSignatureAlgorithms)
		{
			switch (keyExchange)
			{
			case 16:
			case 18:
			case 20:
				this.mTlsSigner = null;
				break;
			case 17:
				this.mTlsSigner = new global::Org.BouncyCastle.Crypto.Tls.TlsECDsaSigner();
				break;
			case 19:
				this.mTlsSigner = new global::Org.BouncyCastle.Crypto.Tls.TlsRsaSigner();
				break;
			default:
				throw new global::System.InvalidOperationException("unsupported key exchange algorithm");
			}
			this.mNamedCurves = namedCurves;
			this.mClientECPointFormats = clientECPointFormats;
			this.mServerECPointFormats = serverECPointFormats;
		}

		// Token: 0x060023A1 RID: 9121 RVA: 0x0009C20D File Offset: 0x0009A40D
		public override void Init(global::Org.BouncyCastle.Crypto.Tls.TlsContext context)
		{
			base.Init(context);
			if (this.mTlsSigner != null)
			{
				this.mTlsSigner.Init(context);
			}
		}

		// Token: 0x060023A2 RID: 9122 RVA: 0x0009C22A File Offset: 0x0009A42A
		public override void SkipServerCredentials()
		{
			if (this.mKeyExchange != 20)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
			}
		}

		// Token: 0x060023A3 RID: 9123 RVA: 0x0009C240 File Offset: 0x0009A440
		public override void ProcessServerCertificate(global::Org.BouncyCastle.Crypto.Tls.Certificate serverCertificate)
		{
			if (this.mKeyExchange == 20)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
			}
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
			if (this.mTlsSigner == null)
			{
				try
				{
					this.mECAgreePublicKey = global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.ValidateECPublicKey((global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters)this.mServerPublicKey);
				}
				catch (global::System.InvalidCastException e2)
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(46, e2);
				}
				global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ValidateKeyUsage(x509Cert, 8);
			}
			else
			{
				if (!this.mTlsSigner.IsValidPublicKey(this.mServerPublicKey))
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(46);
				}
				global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ValidateKeyUsage(x509Cert, 128);
			}
			base.ProcessServerCertificate(serverCertificate);
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x060023A4 RID: 9124 RVA: 0x0009C314 File Offset: 0x0009A514
		public override bool RequiresServerKeyExchange
		{
			get
			{
				int mKeyExchange = this.mKeyExchange;
				return mKeyExchange == 17 || mKeyExchange - 19 <= 1;
			}
		}

		// Token: 0x060023A5 RID: 9125 RVA: 0x0009C338 File Offset: 0x0009A538
		public override byte[] GenerateServerKeyExchange()
		{
			if (!this.RequiresServerKeyExchange)
			{
				return null;
			}
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
			this.mECAgreePrivateKey = global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.GenerateEphemeralServerKeyExchange(this.mContext.SecureRandom, this.mNamedCurves, this.mClientECPointFormats, buf);
			return buf.ToArray();
		}

		// Token: 0x060023A6 RID: 9126 RVA: 0x0009C380 File Offset: 0x0009A580
		public override void ProcessServerKeyExchange(global::System.IO.Stream input)
		{
			if (!this.RequiresServerKeyExchange)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
			}
			global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters curve_params = global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.ReadECParameters(this.mNamedCurves, this.mClientECPointFormats, input);
			byte[] point = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque8(input);
			this.mECAgreePublicKey = global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.ValidateECPublicKey(global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.DeserializeECPublicKey(this.mClientECPointFormats, curve_params, point));
		}

		// Token: 0x060023A7 RID: 9127 RVA: 0x0009C3D0 File Offset: 0x0009A5D0
		public override void ValidateCertificateRequest(global::Org.BouncyCastle.Crypto.Tls.CertificateRequest certificateRequest)
		{
			if (this.mKeyExchange == 20)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(40);
			}
			foreach (byte b in certificateRequest.CertificateTypes)
			{
				if (b - 1 > 1 && b - 64 > 2)
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
				}
			}
		}

		// Token: 0x060023A8 RID: 9128 RVA: 0x0009C41D File Offset: 0x0009A61D
		public override void ProcessClientCredentials(global::Org.BouncyCastle.Crypto.Tls.TlsCredentials clientCredentials)
		{
			if (this.mKeyExchange == 20)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
			if (clientCredentials is global::Org.BouncyCastle.Crypto.Tls.TlsAgreementCredentials)
			{
				this.mAgreementCredentials = (global::Org.BouncyCastle.Crypto.Tls.TlsAgreementCredentials)clientCredentials;
				return;
			}
			if (!(clientCredentials is global::Org.BouncyCastle.Crypto.Tls.TlsSignerCredentials))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
		}

		// Token: 0x060023A9 RID: 9129 RVA: 0x0009C456 File Offset: 0x0009A656
		public override void GenerateClientKeyExchange(global::System.IO.Stream output)
		{
			if (this.mAgreementCredentials == null)
			{
				this.mECAgreePrivateKey = global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.GenerateEphemeralClientKeyExchange(this.mContext.SecureRandom, this.mServerECPointFormats, this.mECAgreePublicKey.Parameters, output);
			}
		}

		// Token: 0x060023AA RID: 9130 RVA: 0x0009C488 File Offset: 0x0009A688
		public override void ProcessClientCertificate(global::Org.BouncyCastle.Crypto.Tls.Certificate clientCertificate)
		{
			if (this.mKeyExchange == 20)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
			}
		}

		// Token: 0x060023AB RID: 9131 RVA: 0x0009C49C File Offset: 0x0009A69C
		public override void ProcessClientKeyExchange(global::System.IO.Stream input)
		{
			if (this.mECAgreePublicKey != null)
			{
				return;
			}
			byte[] point = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque8(input);
			global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters curve_params = this.mECAgreePrivateKey.Parameters;
			this.mECAgreePublicKey = global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.ValidateECPublicKey(global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.DeserializeECPublicKey(this.mServerECPointFormats, curve_params, point));
		}

		// Token: 0x060023AC RID: 9132 RVA: 0x0009C4DD File Offset: 0x0009A6DD
		public override byte[] GeneratePremasterSecret()
		{
			if (this.mAgreementCredentials != null)
			{
				return this.mAgreementCredentials.GenerateAgreement(this.mECAgreePublicKey);
			}
			if (this.mECAgreePrivateKey != null)
			{
				return global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.CalculateECDHBasicAgreement(this.mECAgreePublicKey, this.mECAgreePrivateKey);
			}
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
		}

		// Token: 0x04000E64 RID: 3684
		protected global::Org.BouncyCastle.Crypto.Tls.TlsSigner mTlsSigner;

		// Token: 0x04000E65 RID: 3685
		protected int[] mNamedCurves;

		// Token: 0x04000E66 RID: 3686
		protected byte[] mClientECPointFormats;

		// Token: 0x04000E67 RID: 3687
		protected byte[] mServerECPointFormats;

		// Token: 0x04000E68 RID: 3688
		protected global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter mServerPublicKey;

		// Token: 0x04000E69 RID: 3689
		protected global::Org.BouncyCastle.Crypto.Tls.TlsAgreementCredentials mAgreementCredentials;

		// Token: 0x04000E6A RID: 3690
		protected global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters mECAgreePrivateKey;

		// Token: 0x04000E6B RID: 3691
		protected global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters mECAgreePublicKey;
	}
}
