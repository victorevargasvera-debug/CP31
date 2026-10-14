using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200036B RID: 875
	public class TlsECDheKeyExchange : global::Org.BouncyCastle.Crypto.Tls.TlsECDHKeyExchange
	{
		// Token: 0x06002399 RID: 9113 RVA: 0x0009BF84 File Offset: 0x0009A184
		public TlsECDheKeyExchange(int keyExchange, global::System.Collections.IList supportedSignatureAlgorithms, int[] namedCurves, byte[] clientECPointFormats, byte[] serverECPointFormats) : base(keyExchange, supportedSignatureAlgorithms, namedCurves, clientECPointFormats, serverECPointFormats)
		{
		}

		// Token: 0x0600239A RID: 9114 RVA: 0x0009BF93 File Offset: 0x0009A193
		public override void ProcessServerCredentials(global::Org.BouncyCastle.Crypto.Tls.TlsCredentials serverCredentials)
		{
			if (!(serverCredentials is global::Org.BouncyCastle.Crypto.Tls.TlsSignerCredentials))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
			this.ProcessServerCertificate(serverCredentials.Certificate);
			this.mServerCredentials = (global::Org.BouncyCastle.Crypto.Tls.TlsSignerCredentials)serverCredentials;
		}

		// Token: 0x0600239B RID: 9115 RVA: 0x0009BFC0 File Offset: 0x0009A1C0
		public override byte[] GenerateServerKeyExchange()
		{
			global::Org.BouncyCastle.Crypto.Tls.DigestInputBuffer buf = new global::Org.BouncyCastle.Crypto.Tls.DigestInputBuffer();
			this.mECAgreePrivateKey = global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.GenerateEphemeralServerKeyExchange(this.mContext.SecureRandom, this.mNamedCurves, this.mClientECPointFormats, buf);
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

		// Token: 0x0600239C RID: 9116 RVA: 0x0009C074 File Offset: 0x0009A274
		public override void ProcessServerKeyExchange(global::System.IO.Stream input)
		{
			global::Org.BouncyCastle.Crypto.Tls.SecurityParameters securityParameters = this.mContext.SecurityParameters;
			global::Org.BouncyCastle.Crypto.Tls.SignerInputBuffer buf = new global::Org.BouncyCastle.Crypto.Tls.SignerInputBuffer();
			global::System.IO.Stream teeIn = new global::Org.BouncyCastle.Utilities.IO.TeeInputStream(input, buf);
			global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters curve_params = global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.ReadECParameters(this.mNamedCurves, this.mClientECPointFormats, teeIn);
			byte[] point = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque8(teeIn);
			global::Org.BouncyCastle.Crypto.Tls.DigitallySigned signed_params = this.ParseSignature(input);
			global::Org.BouncyCastle.Crypto.ISigner signer = this.InitVerifyer(this.mTlsSigner, signed_params.Algorithm, securityParameters);
			buf.UpdateSigner(signer);
			if (!signer.VerifySignature(signed_params.Signature))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(51);
			}
			this.mECAgreePublicKey = global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.ValidateECPublicKey(global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.DeserializeECPublicKey(this.mClientECPointFormats, curve_params, point));
		}

		// Token: 0x0600239D RID: 9117 RVA: 0x0009C110 File Offset: 0x0009A310
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

		// Token: 0x0600239E RID: 9118 RVA: 0x0009C149 File Offset: 0x0009A349
		public override void ProcessClientCredentials(global::Org.BouncyCastle.Crypto.Tls.TlsCredentials clientCredentials)
		{
			if (!(clientCredentials is global::Org.BouncyCastle.Crypto.Tls.TlsSignerCredentials))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
		}

		// Token: 0x0600239F RID: 9119 RVA: 0x0009C15B File Offset: 0x0009A35B
		protected virtual global::Org.BouncyCastle.Crypto.ISigner InitVerifyer(global::Org.BouncyCastle.Crypto.Tls.TlsSigner tlsSigner, global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm algorithm, global::Org.BouncyCastle.Crypto.Tls.SecurityParameters securityParameters)
		{
			global::Org.BouncyCastle.Crypto.ISigner signer = tlsSigner.CreateVerifyer(algorithm, this.mServerPublicKey);
			signer.BlockUpdate(securityParameters.clientRandom, 0, securityParameters.clientRandom.Length);
			signer.BlockUpdate(securityParameters.serverRandom, 0, securityParameters.serverRandom.Length);
			return signer;
		}

		// Token: 0x04000E63 RID: 3683
		protected global::Org.BouncyCastle.Crypto.Tls.TlsSignerCredentials mServerCredentials;
	}
}
