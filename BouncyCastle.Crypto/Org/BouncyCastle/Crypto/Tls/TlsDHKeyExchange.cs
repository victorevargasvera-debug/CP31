using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000365 RID: 869
	public class TlsDHKeyExchange : global::Org.BouncyCastle.Crypto.Tls.AbstractTlsKeyExchange
	{
		// Token: 0x0600233B RID: 9019 RVA: 0x0009AB95 File Offset: 0x00098D95
		[global::System.Obsolete("Use constructor that takes a TlsDHVerifier")]
		public TlsDHKeyExchange(int keyExchange, global::System.Collections.IList supportedSignatureAlgorithms, global::Org.BouncyCastle.Crypto.Parameters.DHParameters dhParameters) : this(keyExchange, supportedSignatureAlgorithms, new global::Org.BouncyCastle.Crypto.Tls.DefaultTlsDHVerifier(), dhParameters)
		{
		}

		// Token: 0x0600233C RID: 9020 RVA: 0x0009ABA8 File Offset: 0x00098DA8
		public TlsDHKeyExchange(int keyExchange, global::System.Collections.IList supportedSignatureAlgorithms, global::Org.BouncyCastle.Crypto.Tls.TlsDHVerifier dhVerifier, global::Org.BouncyCastle.Crypto.Parameters.DHParameters dhParameters) : base(keyExchange, supportedSignatureAlgorithms)
		{
			switch (keyExchange)
			{
			case 3:
				this.mTlsSigner = new global::Org.BouncyCastle.Crypto.Tls.TlsDssSigner();
				goto IL_64;
			case 5:
				this.mTlsSigner = new global::Org.BouncyCastle.Crypto.Tls.TlsRsaSigner();
				goto IL_64;
			case 7:
			case 9:
			case 11:
				this.mTlsSigner = null;
				goto IL_64;
			}
			throw new global::System.InvalidOperationException("unsupported key exchange algorithm");
			IL_64:
			this.mDHVerifier = dhVerifier;
			this.mDHParameters = dhParameters;
		}

		// Token: 0x0600233D RID: 9021 RVA: 0x0009AC28 File Offset: 0x00098E28
		public override void Init(global::Org.BouncyCastle.Crypto.Tls.TlsContext context)
		{
			base.Init(context);
			if (this.mTlsSigner != null)
			{
				this.mTlsSigner.Init(context);
			}
		}

		// Token: 0x0600233E RID: 9022 RVA: 0x0009AC45 File Offset: 0x00098E45
		public override void SkipServerCredentials()
		{
			if (this.mKeyExchange != 11)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
			}
		}

		// Token: 0x0600233F RID: 9023 RVA: 0x0009AC5C File Offset: 0x00098E5C
		public override void ProcessServerCertificate(global::Org.BouncyCastle.Crypto.Tls.Certificate serverCertificate)
		{
			if (this.mKeyExchange == 11)
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
					this.mDHAgreePublicKey = (global::Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters)this.mServerPublicKey;
					this.mDHParameters = this.mDHAgreePublicKey.Parameters;
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

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06002340 RID: 9024 RVA: 0x0009AD3C File Offset: 0x00098F3C
		public override bool RequiresServerKeyExchange
		{
			get
			{
				int mKeyExchange = this.mKeyExchange;
				return mKeyExchange == 3 || mKeyExchange == 5 || mKeyExchange == 11;
			}
		}

		// Token: 0x06002341 RID: 9025 RVA: 0x0009AD60 File Offset: 0x00098F60
		public override byte[] GenerateServerKeyExchange()
		{
			if (!this.RequiresServerKeyExchange)
			{
				return null;
			}
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
			this.mDHAgreePrivateKey = global::Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.GenerateEphemeralServerKeyExchange(this.mContext.SecureRandom, this.mDHParameters, buf);
			return buf.ToArray();
		}

		// Token: 0x06002342 RID: 9026 RVA: 0x0009ADA0 File Offset: 0x00098FA0
		public override void ProcessServerKeyExchange(global::System.IO.Stream input)
		{
			if (!this.RequiresServerKeyExchange)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
			}
			this.mDHParameters = global::Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.ReceiveDHParameters(this.mDHVerifier, input);
			this.mDHAgreePublicKey = new global::Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters(global::Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.ReadDHParameter(input), this.mDHParameters);
		}

		// Token: 0x06002343 RID: 9027 RVA: 0x0009ADDC File Offset: 0x00098FDC
		public override void ValidateCertificateRequest(global::Org.BouncyCastle.Crypto.Tls.CertificateRequest certificateRequest)
		{
			if (this.mKeyExchange == 11)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(40);
			}
			foreach (byte b in certificateRequest.CertificateTypes)
			{
				if (b - 1 > 3 && b != 64)
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
				}
			}
		}

		// Token: 0x06002344 RID: 9028 RVA: 0x0009AE27 File Offset: 0x00099027
		public override void ProcessClientCredentials(global::Org.BouncyCastle.Crypto.Tls.TlsCredentials clientCredentials)
		{
			if (this.mKeyExchange == 11)
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

		// Token: 0x06002345 RID: 9029 RVA: 0x0009AE60 File Offset: 0x00099060
		public override void GenerateClientKeyExchange(global::System.IO.Stream output)
		{
			if (this.mAgreementCredentials == null)
			{
				this.mDHAgreePrivateKey = global::Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.GenerateEphemeralClientKeyExchange(this.mContext.SecureRandom, this.mDHParameters, output);
			}
		}

		// Token: 0x06002346 RID: 9030 RVA: 0x0009AE87 File Offset: 0x00099087
		public override void ProcessClientCertificate(global::Org.BouncyCastle.Crypto.Tls.Certificate clientCertificate)
		{
			if (this.mKeyExchange == 11)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
			}
		}

		// Token: 0x06002347 RID: 9031 RVA: 0x0009AE9B File Offset: 0x0009909B
		public override void ProcessClientKeyExchange(global::System.IO.Stream input)
		{
			if (this.mDHAgreePublicKey != null)
			{
				return;
			}
			this.mDHAgreePublicKey = new global::Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters(global::Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.ReadDHParameter(input), this.mDHParameters);
		}

		// Token: 0x06002348 RID: 9032 RVA: 0x0009AEBD File Offset: 0x000990BD
		public override byte[] GeneratePremasterSecret()
		{
			if (this.mAgreementCredentials != null)
			{
				return this.mAgreementCredentials.GenerateAgreement(this.mDHAgreePublicKey);
			}
			if (this.mDHAgreePrivateKey != null)
			{
				return global::Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.CalculateDHBasicAgreement(this.mDHAgreePublicKey, this.mDHAgreePrivateKey);
			}
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
		}

		// Token: 0x04000E50 RID: 3664
		protected global::Org.BouncyCastle.Crypto.Tls.TlsSigner mTlsSigner;

		// Token: 0x04000E51 RID: 3665
		protected global::Org.BouncyCastle.Crypto.Tls.TlsDHVerifier mDHVerifier;

		// Token: 0x04000E52 RID: 3666
		protected global::Org.BouncyCastle.Crypto.Parameters.DHParameters mDHParameters;

		// Token: 0x04000E53 RID: 3667
		protected global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter mServerPublicKey;

		// Token: 0x04000E54 RID: 3668
		protected global::Org.BouncyCastle.Crypto.Tls.TlsAgreementCredentials mAgreementCredentials;

		// Token: 0x04000E55 RID: 3669
		protected global::Org.BouncyCastle.Crypto.Parameters.DHPrivateKeyParameters mDHAgreePrivateKey;

		// Token: 0x04000E56 RID: 3670
		protected global::Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters mDHAgreePublicKey;
	}
}
