using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200037E RID: 894
	public class TlsPskKeyExchange : global::Org.BouncyCastle.Crypto.Tls.AbstractTlsKeyExchange
	{
		// Token: 0x06002464 RID: 9316 RVA: 0x0009E394 File Offset: 0x0009C594
		[global::System.Obsolete("Use constructor that takes a TlsDHVerifier")]
		public TlsPskKeyExchange(int keyExchange, global::System.Collections.IList supportedSignatureAlgorithms, global::Org.BouncyCastle.Crypto.Tls.TlsPskIdentity pskIdentity, global::Org.BouncyCastle.Crypto.Tls.TlsPskIdentityManager pskIdentityManager, global::Org.BouncyCastle.Crypto.Parameters.DHParameters dhParameters, int[] namedCurves, byte[] clientECPointFormats, byte[] serverECPointFormats) : this(keyExchange, supportedSignatureAlgorithms, pskIdentity, pskIdentityManager, new global::Org.BouncyCastle.Crypto.Tls.DefaultTlsDHVerifier(), dhParameters, namedCurves, clientECPointFormats, serverECPointFormats)
		{
		}

		// Token: 0x06002465 RID: 9317 RVA: 0x0009E3BC File Offset: 0x0009C5BC
		public TlsPskKeyExchange(int keyExchange, global::System.Collections.IList supportedSignatureAlgorithms, global::Org.BouncyCastle.Crypto.Tls.TlsPskIdentity pskIdentity, global::Org.BouncyCastle.Crypto.Tls.TlsPskIdentityManager pskIdentityManager, global::Org.BouncyCastle.Crypto.Tls.TlsDHVerifier dhVerifier, global::Org.BouncyCastle.Crypto.Parameters.DHParameters dhParameters, int[] namedCurves, byte[] clientECPointFormats, byte[] serverECPointFormats) : base(keyExchange, supportedSignatureAlgorithms)
		{
			if (keyExchange - 13 > 2 && keyExchange != 24)
			{
				throw new global::System.InvalidOperationException("unsupported key exchange algorithm");
			}
			this.mPskIdentity = pskIdentity;
			this.mPskIdentityManager = pskIdentityManager;
			this.mDHVerifier = dhVerifier;
			this.mDHParameters = dhParameters;
			this.mNamedCurves = namedCurves;
			this.mClientECPointFormats = clientECPointFormats;
			this.mServerECPointFormats = serverECPointFormats;
		}

		// Token: 0x06002466 RID: 9318 RVA: 0x0009E41F File Offset: 0x0009C61F
		public override void SkipServerCredentials()
		{
			if (this.mKeyExchange == 15)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
			}
		}

		// Token: 0x06002467 RID: 9319 RVA: 0x0009E433 File Offset: 0x0009C633
		public override void ProcessServerCredentials(global::Org.BouncyCastle.Crypto.Tls.TlsCredentials serverCredentials)
		{
			if (!(serverCredentials is global::Org.BouncyCastle.Crypto.Tls.TlsEncryptionCredentials))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
			this.ProcessServerCertificate(serverCredentials.Certificate);
			this.mServerCredentials = (global::Org.BouncyCastle.Crypto.Tls.TlsEncryptionCredentials)serverCredentials;
		}

		// Token: 0x06002468 RID: 9320 RVA: 0x0009E460 File Offset: 0x0009C660
		public override byte[] GenerateServerKeyExchange()
		{
			this.mPskIdentityHint = this.mPskIdentityManager.GetHint();
			if (this.mPskIdentityHint == null && !this.RequiresServerKeyExchange)
			{
				return null;
			}
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
			if (this.mPskIdentityHint == null)
			{
				global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque16(global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.EmptyBytes, buf);
			}
			else
			{
				global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque16(this.mPskIdentityHint, buf);
			}
			if (this.mKeyExchange == 14)
			{
				if (this.mDHParameters == null)
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
				}
				this.mDHAgreePrivateKey = global::Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.GenerateEphemeralServerKeyExchange(this.mContext.SecureRandom, this.mDHParameters, buf);
			}
			else if (this.mKeyExchange == 24)
			{
				this.mECAgreePrivateKey = global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.GenerateEphemeralServerKeyExchange(this.mContext.SecureRandom, this.mNamedCurves, this.mClientECPointFormats, buf);
			}
			return buf.ToArray();
		}

		// Token: 0x06002469 RID: 9321 RVA: 0x0009E524 File Offset: 0x0009C724
		public override void ProcessServerCertificate(global::Org.BouncyCastle.Crypto.Tls.Certificate serverCertificate)
		{
			if (this.mKeyExchange != 15)
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
			if (this.mServerPublicKey.IsPrivate)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
			this.mRsaServerPublicKey = this.ValidateRsaPublicKey((global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters)this.mServerPublicKey);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ValidateKeyUsage(x509Cert, 32);
			base.ProcessServerCertificate(serverCertificate);
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x0600246A RID: 9322 RVA: 0x0009E5C8 File Offset: 0x0009C7C8
		public override bool RequiresServerKeyExchange
		{
			get
			{
				int mKeyExchange = this.mKeyExchange;
				return mKeyExchange == 14 || mKeyExchange == 24;
			}
		}

		// Token: 0x0600246B RID: 9323 RVA: 0x0009E5EC File Offset: 0x0009C7EC
		public override void ProcessServerKeyExchange(global::System.IO.Stream input)
		{
			this.mPskIdentityHint = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque16(input);
			if (this.mKeyExchange == 14)
			{
				this.mDHParameters = global::Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.ReceiveDHParameters(this.mDHVerifier, input);
				this.mDHAgreePublicKey = new global::Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters(global::Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.ReadDHParameter(input), this.mDHParameters);
				return;
			}
			if (this.mKeyExchange == 24)
			{
				global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters ecParams = global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.ReadECParameters(this.mNamedCurves, this.mClientECPointFormats, input);
				byte[] point = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque8(input);
				this.mECAgreePublicKey = global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.ValidateECPublicKey(global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.DeserializeECPublicKey(this.mClientECPointFormats, ecParams, point));
			}
		}

		// Token: 0x0600246C RID: 9324 RVA: 0x0009E675 File Offset: 0x0009C875
		public override void ValidateCertificateRequest(global::Org.BouncyCastle.Crypto.Tls.CertificateRequest certificateRequest)
		{
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
		}

		// Token: 0x0600246D RID: 9325 RVA: 0x0009E67E File Offset: 0x0009C87E
		public override void ProcessClientCredentials(global::Org.BouncyCastle.Crypto.Tls.TlsCredentials clientCredentials)
		{
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
		}

		// Token: 0x0600246E RID: 9326 RVA: 0x0009E688 File Offset: 0x0009C888
		public override void GenerateClientKeyExchange(global::System.IO.Stream output)
		{
			if (this.mPskIdentityHint == null)
			{
				this.mPskIdentity.SkipIdentityHint();
			}
			else
			{
				this.mPskIdentity.NotifyIdentityHint(this.mPskIdentityHint);
			}
			byte[] psk_identity = this.mPskIdentity.GetPskIdentity();
			if (psk_identity == null)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
			this.mPsk = this.mPskIdentity.GetPsk();
			if (this.mPsk == null)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque16(psk_identity, output);
			this.mContext.SecurityParameters.pskIdentity = psk_identity;
			if (this.mKeyExchange == 14)
			{
				this.mDHAgreePrivateKey = global::Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.GenerateEphemeralClientKeyExchange(this.mContext.SecureRandom, this.mDHParameters, output);
				return;
			}
			if (this.mKeyExchange == 24)
			{
				this.mECAgreePrivateKey = global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.GenerateEphemeralClientKeyExchange(this.mContext.SecureRandom, this.mServerECPointFormats, this.mECAgreePublicKey.Parameters, output);
				return;
			}
			if (this.mKeyExchange == 15)
			{
				this.mPremasterSecret = global::Org.BouncyCastle.Crypto.Tls.TlsRsaUtilities.GenerateEncryptedPreMasterSecret(this.mContext, this.mRsaServerPublicKey, output);
			}
		}

		// Token: 0x0600246F RID: 9327 RVA: 0x0009E788 File Offset: 0x0009C988
		public override void ProcessClientKeyExchange(global::System.IO.Stream input)
		{
			byte[] psk_identity = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque16(input);
			this.mPsk = this.mPskIdentityManager.GetPsk(psk_identity);
			if (this.mPsk == null)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(115);
			}
			this.mContext.SecurityParameters.pskIdentity = psk_identity;
			if (this.mKeyExchange == 14)
			{
				this.mDHAgreePublicKey = new global::Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters(global::Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.ReadDHParameter(input), this.mDHParameters);
				return;
			}
			if (this.mKeyExchange == 24)
			{
				byte[] point = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque8(input);
				global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters curve_params = this.mECAgreePrivateKey.Parameters;
				this.mECAgreePublicKey = global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.ValidateECPublicKey(global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.DeserializeECPublicKey(this.mServerECPointFormats, curve_params, point));
				return;
			}
			if (this.mKeyExchange == 15)
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
		}

		// Token: 0x06002470 RID: 9328 RVA: 0x0009E860 File Offset: 0x0009CA60
		public override byte[] GeneratePremasterSecret()
		{
			byte[] other_secret = this.GenerateOtherSecret(this.mPsk.Length);
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream(4 + other_secret.Length + this.mPsk.Length);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque16(other_secret, buf);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque16(this.mPsk, buf);
			global::Org.BouncyCastle.Utilities.Arrays.Fill(this.mPsk, 0);
			this.mPsk = null;
			return buf.ToArray();
		}

		// Token: 0x06002471 RID: 9329 RVA: 0x0009E8BC File Offset: 0x0009CABC
		protected virtual byte[] GenerateOtherSecret(int pskLength)
		{
			if (this.mKeyExchange == 14)
			{
				if (this.mDHAgreePrivateKey != null)
				{
					return global::Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.CalculateDHBasicAgreement(this.mDHAgreePublicKey, this.mDHAgreePrivateKey);
				}
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
			else if (this.mKeyExchange == 24)
			{
				if (this.mECAgreePrivateKey != null)
				{
					return global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.CalculateECDHBasicAgreement(this.mECAgreePublicKey, this.mECAgreePrivateKey);
				}
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
			else
			{
				if (this.mKeyExchange == 15)
				{
					return this.mPremasterSecret;
				}
				return new byte[pskLength];
			}
		}

		// Token: 0x06002472 RID: 9330 RVA: 0x0009E938 File Offset: 0x0009CB38
		protected virtual global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters ValidateRsaPublicKey(global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters key)
		{
			if (!key.Exponent.IsProbablePrime(2))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
			}
			return key;
		}

		// Token: 0x04000EA8 RID: 3752
		protected global::Org.BouncyCastle.Crypto.Tls.TlsPskIdentity mPskIdentity;

		// Token: 0x04000EA9 RID: 3753
		protected global::Org.BouncyCastle.Crypto.Tls.TlsPskIdentityManager mPskIdentityManager;

		// Token: 0x04000EAA RID: 3754
		protected global::Org.BouncyCastle.Crypto.Tls.TlsDHVerifier mDHVerifier;

		// Token: 0x04000EAB RID: 3755
		protected global::Org.BouncyCastle.Crypto.Parameters.DHParameters mDHParameters;

		// Token: 0x04000EAC RID: 3756
		protected int[] mNamedCurves;

		// Token: 0x04000EAD RID: 3757
		protected byte[] mClientECPointFormats;

		// Token: 0x04000EAE RID: 3758
		protected byte[] mServerECPointFormats;

		// Token: 0x04000EAF RID: 3759
		protected byte[] mPskIdentityHint;

		// Token: 0x04000EB0 RID: 3760
		protected byte[] mPsk;

		// Token: 0x04000EB1 RID: 3761
		protected global::Org.BouncyCastle.Crypto.Parameters.DHPrivateKeyParameters mDHAgreePrivateKey;

		// Token: 0x04000EB2 RID: 3762
		protected global::Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters mDHAgreePublicKey;

		// Token: 0x04000EB3 RID: 3763
		protected global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters mECAgreePrivateKey;

		// Token: 0x04000EB4 RID: 3764
		protected global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters mECAgreePublicKey;

		// Token: 0x04000EB5 RID: 3765
		protected global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter mServerPublicKey;

		// Token: 0x04000EB6 RID: 3766
		protected global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters mRsaServerPublicKey;

		// Token: 0x04000EB7 RID: 3767
		protected global::Org.BouncyCastle.Crypto.Tls.TlsEncryptionCredentials mServerCredentials;

		// Token: 0x04000EB8 RID: 3768
		protected byte[] mPremasterSecret;
	}
}
