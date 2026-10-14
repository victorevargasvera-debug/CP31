using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto.Agreement.Srp;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200038C RID: 908
	public class TlsSrpKeyExchange : global::Org.BouncyCastle.Crypto.Tls.AbstractTlsKeyExchange
	{
		// Token: 0x060024C9 RID: 9417 RVA: 0x0009FC10 File Offset: 0x0009DE10
		protected static global::Org.BouncyCastle.Crypto.Tls.TlsSigner CreateSigner(int keyExchange)
		{
			switch (keyExchange)
			{
			case 21:
				return null;
			case 22:
				return new global::Org.BouncyCastle.Crypto.Tls.TlsDssSigner();
			case 23:
				return new global::Org.BouncyCastle.Crypto.Tls.TlsRsaSigner();
			default:
				throw new global::System.ArgumentException("unsupported key exchange algorithm");
			}
		}

		// Token: 0x060024CA RID: 9418 RVA: 0x0009FC41 File Offset: 0x0009DE41
		[global::System.Obsolete("Use constructor taking an explicit 'groupVerifier' argument")]
		public TlsSrpKeyExchange(int keyExchange, global::System.Collections.IList supportedSignatureAlgorithms, byte[] identity, byte[] password) : this(keyExchange, supportedSignatureAlgorithms, new global::Org.BouncyCastle.Crypto.Tls.DefaultTlsSrpGroupVerifier(), identity, password)
		{
		}

		// Token: 0x060024CB RID: 9419 RVA: 0x0009FC53 File Offset: 0x0009DE53
		public TlsSrpKeyExchange(int keyExchange, global::System.Collections.IList supportedSignatureAlgorithms, global::Org.BouncyCastle.Crypto.Tls.TlsSrpGroupVerifier groupVerifier, byte[] identity, byte[] password) : base(keyExchange, supportedSignatureAlgorithms)
		{
			this.mTlsSigner = global::Org.BouncyCastle.Crypto.Tls.TlsSrpKeyExchange.CreateSigner(keyExchange);
			this.mGroupVerifier = groupVerifier;
			this.mIdentity = identity;
			this.mPassword = password;
			this.mSrpClient = new global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6Client();
		}

		// Token: 0x060024CC RID: 9420 RVA: 0x0009FC8C File Offset: 0x0009DE8C
		public TlsSrpKeyExchange(int keyExchange, global::System.Collections.IList supportedSignatureAlgorithms, byte[] identity, global::Org.BouncyCastle.Crypto.Tls.TlsSrpLoginParameters loginParameters) : base(keyExchange, supportedSignatureAlgorithms)
		{
			this.mTlsSigner = global::Org.BouncyCastle.Crypto.Tls.TlsSrpKeyExchange.CreateSigner(keyExchange);
			this.mIdentity = identity;
			this.mSrpServer = new global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6Server();
			this.mSrpGroup = loginParameters.Group;
			this.mSrpVerifier = loginParameters.Verifier;
			this.mSrpSalt = loginParameters.Salt;
		}

		// Token: 0x060024CD RID: 9421 RVA: 0x0009FCE6 File Offset: 0x0009DEE6
		public override void Init(global::Org.BouncyCastle.Crypto.Tls.TlsContext context)
		{
			base.Init(context);
			if (this.mTlsSigner != null)
			{
				this.mTlsSigner.Init(context);
			}
		}

		// Token: 0x060024CE RID: 9422 RVA: 0x0009FD03 File Offset: 0x0009DF03
		public override void SkipServerCredentials()
		{
			if (this.mTlsSigner != null)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
			}
		}

		// Token: 0x060024CF RID: 9423 RVA: 0x0009FD18 File Offset: 0x0009DF18
		public override void ProcessServerCertificate(global::Org.BouncyCastle.Crypto.Tls.Certificate serverCertificate)
		{
			if (this.mTlsSigner == null)
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
			if (!this.mTlsSigner.IsValidPublicKey(this.mServerPublicKey))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(46);
			}
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ValidateKeyUsage(x509Cert, 128);
			base.ProcessServerCertificate(serverCertificate);
		}

		// Token: 0x060024D0 RID: 9424 RVA: 0x0009FDAC File Offset: 0x0009DFAC
		public override void ProcessServerCredentials(global::Org.BouncyCastle.Crypto.Tls.TlsCredentials serverCredentials)
		{
			if (this.mKeyExchange == 21 || !(serverCredentials is global::Org.BouncyCastle.Crypto.Tls.TlsSignerCredentials))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
			this.ProcessServerCertificate(serverCredentials.Certificate);
			this.mServerCredentials = (global::Org.BouncyCastle.Crypto.Tls.TlsSignerCredentials)serverCredentials;
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x060024D1 RID: 9425 RVA: 0x0009FDE0 File Offset: 0x0009DFE0
		public override bool RequiresServerKeyExchange
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060024D2 RID: 9426 RVA: 0x0009FDE4 File Offset: 0x0009DFE4
		public override byte[] GenerateServerKeyExchange()
		{
			this.mSrpServer.Init(this.mSrpGroup, this.mSrpVerifier, global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreateHash(2), this.mContext.SecureRandom);
			global::Org.BouncyCastle.Math.BigInteger B = this.mSrpServer.GenerateServerCredentials();
			global::Org.BouncyCastle.Crypto.Tls.ServerSrpParams serverSrpParams = new global::Org.BouncyCastle.Crypto.Tls.ServerSrpParams(this.mSrpGroup.N, this.mSrpGroup.G, this.mSrpSalt, B);
			global::Org.BouncyCastle.Crypto.Tls.DigestInputBuffer buf = new global::Org.BouncyCastle.Crypto.Tls.DigestInputBuffer();
			serverSrpParams.Encode(buf);
			if (this.mServerCredentials != null)
			{
				global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm signatureAndHashAlgorithm = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetSignatureAndHashAlgorithm(this.mContext, this.mServerCredentials);
				global::Org.BouncyCastle.Crypto.IDigest d = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreateHash(signatureAndHashAlgorithm);
				global::Org.BouncyCastle.Crypto.Tls.SecurityParameters securityParameters = this.mContext.SecurityParameters;
				d.BlockUpdate(securityParameters.clientRandom, 0, securityParameters.clientRandom.Length);
				d.BlockUpdate(securityParameters.serverRandom, 0, securityParameters.serverRandom.Length);
				buf.UpdateDigest(d);
				byte[] hash = new byte[d.GetDigestSize()];
				d.DoFinal(hash, 0);
				byte[] signature = this.mServerCredentials.GenerateCertificateSignature(hash);
				new global::Org.BouncyCastle.Crypto.Tls.DigitallySigned(signatureAndHashAlgorithm, signature).Encode(buf);
			}
			return buf.ToArray();
		}

		// Token: 0x060024D3 RID: 9427 RVA: 0x0009FEEC File Offset: 0x0009E0EC
		public override void ProcessServerKeyExchange(global::System.IO.Stream input)
		{
			global::Org.BouncyCastle.Crypto.Tls.SecurityParameters securityParameters = this.mContext.SecurityParameters;
			global::Org.BouncyCastle.Crypto.Tls.SignerInputBuffer buf = null;
			global::System.IO.Stream teeIn = input;
			if (this.mTlsSigner != null)
			{
				buf = new global::Org.BouncyCastle.Crypto.Tls.SignerInputBuffer();
				teeIn = new global::Org.BouncyCastle.Utilities.IO.TeeInputStream(input, buf);
			}
			global::Org.BouncyCastle.Crypto.Tls.ServerSrpParams srpParams = global::Org.BouncyCastle.Crypto.Tls.ServerSrpParams.Parse(teeIn);
			if (buf != null)
			{
				global::Org.BouncyCastle.Crypto.Tls.DigitallySigned signed_params = this.ParseSignature(input);
				global::Org.BouncyCastle.Crypto.ISigner signer = this.InitVerifyer(this.mTlsSigner, signed_params.Algorithm, securityParameters);
				buf.UpdateSigner(signer);
				if (!signer.VerifySignature(signed_params.Signature))
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(51);
				}
			}
			this.mSrpGroup = new global::Org.BouncyCastle.Crypto.Parameters.Srp6GroupParameters(srpParams.N, srpParams.G);
			if (!this.mGroupVerifier.Accept(this.mSrpGroup))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(71);
			}
			this.mSrpSalt = srpParams.S;
			try
			{
				this.mSrpPeerCredentials = global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6Utilities.ValidatePublicValue(this.mSrpGroup.N, srpParams.B);
			}
			catch (global::Org.BouncyCastle.Crypto.CryptoException e)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47, e);
			}
			this.mSrpClient.Init(this.mSrpGroup, global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreateHash(2), this.mContext.SecureRandom);
		}

		// Token: 0x060024D4 RID: 9428 RVA: 0x000A0004 File Offset: 0x0009E204
		public override void ValidateCertificateRequest(global::Org.BouncyCastle.Crypto.Tls.CertificateRequest certificateRequest)
		{
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
		}

		// Token: 0x060024D5 RID: 9429 RVA: 0x000A000D File Offset: 0x0009E20D
		public override void ProcessClientCredentials(global::Org.BouncyCastle.Crypto.Tls.TlsCredentials clientCredentials)
		{
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
		}

		// Token: 0x060024D6 RID: 9430 RVA: 0x000A0016 File Offset: 0x0009E216
		public override void GenerateClientKeyExchange(global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Crypto.Tls.TlsSrpUtilities.WriteSrpParameter(this.mSrpClient.GenerateClientCredentials(this.mSrpSalt, this.mIdentity, this.mPassword), output);
			this.mContext.SecurityParameters.srpIdentity = global::Org.BouncyCastle.Utilities.Arrays.Clone(this.mIdentity);
		}

		// Token: 0x060024D7 RID: 9431 RVA: 0x000A0058 File Offset: 0x0009E258
		public override void ProcessClientKeyExchange(global::System.IO.Stream input)
		{
			try
			{
				this.mSrpPeerCredentials = global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6Utilities.ValidatePublicValue(this.mSrpGroup.N, global::Org.BouncyCastle.Crypto.Tls.TlsSrpUtilities.ReadSrpParameter(input));
			}
			catch (global::Org.BouncyCastle.Crypto.CryptoException e)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47, e);
			}
			this.mContext.SecurityParameters.srpIdentity = global::Org.BouncyCastle.Utilities.Arrays.Clone(this.mIdentity);
		}

		// Token: 0x060024D8 RID: 9432 RVA: 0x000A00B8 File Offset: 0x0009E2B8
		public override byte[] GeneratePremasterSecret()
		{
			byte[] result;
			try
			{
				result = global::Org.BouncyCastle.Utilities.BigIntegers.AsUnsignedByteArray((this.mSrpServer != null) ? this.mSrpServer.CalculateSecret(this.mSrpPeerCredentials) : this.mSrpClient.CalculateSecret(this.mSrpPeerCredentials));
			}
			catch (global::Org.BouncyCastle.Crypto.CryptoException e)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47, e);
			}
			return result;
		}

		// Token: 0x060024D9 RID: 9433 RVA: 0x000A0114 File Offset: 0x0009E314
		protected virtual global::Org.BouncyCastle.Crypto.ISigner InitVerifyer(global::Org.BouncyCastle.Crypto.Tls.TlsSigner tlsSigner, global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm algorithm, global::Org.BouncyCastle.Crypto.Tls.SecurityParameters securityParameters)
		{
			global::Org.BouncyCastle.Crypto.ISigner signer = tlsSigner.CreateVerifyer(algorithm, this.mServerPublicKey);
			signer.BlockUpdate(securityParameters.clientRandom, 0, securityParameters.clientRandom.Length);
			signer.BlockUpdate(securityParameters.serverRandom, 0, securityParameters.serverRandom.Length);
			return signer;
		}

		// Token: 0x04000EC7 RID: 3783
		protected global::Org.BouncyCastle.Crypto.Tls.TlsSigner mTlsSigner;

		// Token: 0x04000EC8 RID: 3784
		protected global::Org.BouncyCastle.Crypto.Tls.TlsSrpGroupVerifier mGroupVerifier;

		// Token: 0x04000EC9 RID: 3785
		protected byte[] mIdentity;

		// Token: 0x04000ECA RID: 3786
		protected byte[] mPassword;

		// Token: 0x04000ECB RID: 3787
		protected global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter mServerPublicKey;

		// Token: 0x04000ECC RID: 3788
		protected global::Org.BouncyCastle.Crypto.Parameters.Srp6GroupParameters mSrpGroup;

		// Token: 0x04000ECD RID: 3789
		protected global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6Client mSrpClient;

		// Token: 0x04000ECE RID: 3790
		protected global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6Server mSrpServer;

		// Token: 0x04000ECF RID: 3791
		protected global::Org.BouncyCastle.Math.BigInteger mSrpPeerCredentials;

		// Token: 0x04000ED0 RID: 3792
		protected global::Org.BouncyCastle.Math.BigInteger mSrpVerifier;

		// Token: 0x04000ED1 RID: 3793
		protected byte[] mSrpSalt;

		// Token: 0x04000ED2 RID: 3794
		protected global::Org.BouncyCastle.Crypto.Tls.TlsSignerCredentials mServerCredentials;
	}
}
