using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000364 RID: 868
	public class TlsDheKeyExchange : global::Org.BouncyCastle.Crypto.Tls.TlsDHKeyExchange
	{
		// Token: 0x06002335 RID: 9013 RVA: 0x0009A9C6 File Offset: 0x00098BC6
		[global::System.Obsolete("Use constructor that takes a TlsDHVerifier")]
		public TlsDheKeyExchange(int keyExchange, global::System.Collections.IList supportedSignatureAlgorithms, global::Org.BouncyCastle.Crypto.Parameters.DHParameters dhParameters) : this(keyExchange, supportedSignatureAlgorithms, new global::Org.BouncyCastle.Crypto.Tls.DefaultTlsDHVerifier(), dhParameters)
		{
		}

		// Token: 0x06002336 RID: 9014 RVA: 0x0009A9D6 File Offset: 0x00098BD6
		public TlsDheKeyExchange(int keyExchange, global::System.Collections.IList supportedSignatureAlgorithms, global::Org.BouncyCastle.Crypto.Tls.TlsDHVerifier dhVerifier, global::Org.BouncyCastle.Crypto.Parameters.DHParameters dhParameters) : base(keyExchange, supportedSignatureAlgorithms, dhVerifier, dhParameters)
		{
		}

		// Token: 0x06002337 RID: 9015 RVA: 0x0009A9E3 File Offset: 0x00098BE3
		public override void ProcessServerCredentials(global::Org.BouncyCastle.Crypto.Tls.TlsCredentials serverCredentials)
		{
			if (!(serverCredentials is global::Org.BouncyCastle.Crypto.Tls.TlsSignerCredentials))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
			this.ProcessServerCertificate(serverCredentials.Certificate);
			this.mServerCredentials = (global::Org.BouncyCastle.Crypto.Tls.TlsSignerCredentials)serverCredentials;
		}

		// Token: 0x06002338 RID: 9016 RVA: 0x0009AA10 File Offset: 0x00098C10
		public override byte[] GenerateServerKeyExchange()
		{
			if (this.mDHParameters == null)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
			global::Org.BouncyCastle.Crypto.Tls.DigestInputBuffer buf = new global::Org.BouncyCastle.Crypto.Tls.DigestInputBuffer();
			this.mDHAgreePrivateKey = global::Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.GenerateEphemeralServerKeyExchange(this.mContext.SecureRandom, this.mDHParameters, buf);
			global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm signatureAndHashAlgorithm = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetSignatureAndHashAlgorithm(this.mContext, this.mServerCredentials);
			global::Org.BouncyCastle.Crypto.IDigest d = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreateHash(signatureAndHashAlgorithm);
			global::Org.BouncyCastle.Crypto.Tls.SecurityParameters securityParameters = this.mContext.SecurityParameters;
			d.BlockUpdate(securityParameters.clientRandom, 0, securityParameters.clientRandom.Length);
			d.BlockUpdate(securityParameters.serverRandom, 0, securityParameters.serverRandom.Length);
			buf.UpdateDigest(d);
			byte[] hash = global::Org.BouncyCastle.Security.DigestUtilities.DoFinal(d);
			byte[] signature = this.mServerCredentials.GenerateCertificateSignature(hash);
			new global::Org.BouncyCastle.Crypto.Tls.DigitallySigned(signatureAndHashAlgorithm, signature).Encode(buf);
			return buf.ToArray();
		}

		// Token: 0x06002339 RID: 9017 RVA: 0x0009AAD0 File Offset: 0x00098CD0
		public override void ProcessServerKeyExchange(global::System.IO.Stream input)
		{
			global::Org.BouncyCastle.Crypto.Tls.SecurityParameters securityParameters = this.mContext.SecurityParameters;
			global::Org.BouncyCastle.Crypto.Tls.SignerInputBuffer buf = new global::Org.BouncyCastle.Crypto.Tls.SignerInputBuffer();
			global::System.IO.Stream teeIn = new global::Org.BouncyCastle.Utilities.IO.TeeInputStream(input, buf);
			this.mDHParameters = global::Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.ReceiveDHParameters(this.mDHVerifier, teeIn);
			this.mDHAgreePublicKey = new global::Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters(global::Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.ReadDHParameter(teeIn), this.mDHParameters);
			global::Org.BouncyCastle.Crypto.Tls.DigitallySigned signed_params = this.ParseSignature(input);
			global::Org.BouncyCastle.Crypto.ISigner signer = this.InitVerifyer(this.mTlsSigner, signed_params.Algorithm, securityParameters);
			buf.UpdateSigner(signer);
			if (!signer.VerifySignature(signed_params.Signature))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(51);
			}
		}

		// Token: 0x0600233A RID: 9018 RVA: 0x0009AB5C File Offset: 0x00098D5C
		protected virtual global::Org.BouncyCastle.Crypto.ISigner InitVerifyer(global::Org.BouncyCastle.Crypto.Tls.TlsSigner tlsSigner, global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm algorithm, global::Org.BouncyCastle.Crypto.Tls.SecurityParameters securityParameters)
		{
			global::Org.BouncyCastle.Crypto.ISigner signer = tlsSigner.CreateVerifyer(algorithm, this.mServerPublicKey);
			signer.BlockUpdate(securityParameters.clientRandom, 0, securityParameters.clientRandom.Length);
			signer.BlockUpdate(securityParameters.serverRandom, 0, securityParameters.serverRandom.Length);
			return signer;
		}

		// Token: 0x04000E4F RID: 3663
		protected global::Org.BouncyCastle.Crypto.Tls.TlsSignerCredentials mServerCredentials;
	}
}
