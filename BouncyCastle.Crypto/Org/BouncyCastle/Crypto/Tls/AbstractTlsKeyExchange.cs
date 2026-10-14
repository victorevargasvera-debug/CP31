using System;
using System.Collections;
using System.IO;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x020002F8 RID: 760
	public abstract class AbstractTlsKeyExchange : global::Org.BouncyCastle.Crypto.Tls.TlsKeyExchange
	{
		// Token: 0x0600207D RID: 8317 RVA: 0x00091717 File Offset: 0x0008F917
		protected AbstractTlsKeyExchange(int keyExchange, global::System.Collections.IList supportedSignatureAlgorithms)
		{
			this.mKeyExchange = keyExchange;
			this.mSupportedSignatureAlgorithms = supportedSignatureAlgorithms;
		}

		// Token: 0x0600207E RID: 8318 RVA: 0x00091730 File Offset: 0x0008F930
		protected virtual global::Org.BouncyCastle.Crypto.Tls.DigitallySigned ParseSignature(global::System.IO.Stream input)
		{
			global::Org.BouncyCastle.Crypto.Tls.DigitallySigned digitallySigned = global::Org.BouncyCastle.Crypto.Tls.DigitallySigned.Parse(this.mContext, input);
			global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm signatureAlgorithm = digitallySigned.Algorithm;
			if (signatureAlgorithm != null)
			{
				global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.VerifySupportedSignatureAlgorithm(this.mSupportedSignatureAlgorithms, signatureAlgorithm);
			}
			return digitallySigned;
		}

		// Token: 0x0600207F RID: 8319 RVA: 0x00091760 File Offset: 0x0008F960
		public virtual void Init(global::Org.BouncyCastle.Crypto.Tls.TlsContext context)
		{
			this.mContext = context;
			global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion clientVersion = context.ClientVersion;
			if (global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsSignatureAlgorithmsExtensionAllowed(clientVersion))
			{
				if (this.mSupportedSignatureAlgorithms == null)
				{
					switch (this.mKeyExchange)
					{
					case 1:
					case 5:
					case 9:
					case 15:
					case 18:
					case 19:
					case 23:
						this.mSupportedSignatureAlgorithms = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetDefaultRsaSignatureAlgorithms();
						return;
					case 3:
					case 7:
					case 22:
						this.mSupportedSignatureAlgorithms = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetDefaultDssSignatureAlgorithms();
						return;
					case 13:
					case 14:
					case 21:
					case 24:
						return;
					case 16:
					case 17:
						this.mSupportedSignatureAlgorithms = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetDefaultECDsaSignatureAlgorithms();
						return;
					}
					throw new global::System.InvalidOperationException("unsupported key exchange algorithm");
				}
			}
			else if (this.mSupportedSignatureAlgorithms != null)
			{
				string str = "supported_signature_algorithms not allowed for ";
				global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion protocolVersion = clientVersion;
				throw new global::System.InvalidOperationException(str + ((protocolVersion != null) ? protocolVersion.ToString() : null));
			}
		}

		// Token: 0x06002080 RID: 8320
		public abstract void SkipServerCredentials();

		// Token: 0x06002081 RID: 8321 RVA: 0x00091856 File Offset: 0x0008FA56
		public virtual void ProcessServerCertificate(global::Org.BouncyCastle.Crypto.Tls.Certificate serverCertificate)
		{
			global::System.Collections.IList list = this.mSupportedSignatureAlgorithms;
		}

		// Token: 0x06002082 RID: 8322 RVA: 0x0009185F File Offset: 0x0008FA5F
		public virtual void ProcessServerCredentials(global::Org.BouncyCastle.Crypto.Tls.TlsCredentials serverCredentials)
		{
			this.ProcessServerCertificate(serverCredentials.Certificate);
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06002083 RID: 8323 RVA: 0x0009186D File Offset: 0x0008FA6D
		public virtual bool RequiresServerKeyExchange
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06002084 RID: 8324 RVA: 0x00091870 File Offset: 0x0008FA70
		public virtual byte[] GenerateServerKeyExchange()
		{
			if (this.RequiresServerKeyExchange)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
			return null;
		}

		// Token: 0x06002085 RID: 8325 RVA: 0x00091883 File Offset: 0x0008FA83
		public virtual void SkipServerKeyExchange()
		{
			if (this.RequiresServerKeyExchange)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
			}
		}

		// Token: 0x06002086 RID: 8326 RVA: 0x00091895 File Offset: 0x0008FA95
		public virtual void ProcessServerKeyExchange(global::System.IO.Stream input)
		{
			if (!this.RequiresServerKeyExchange)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
			}
		}

		// Token: 0x06002087 RID: 8327
		public abstract void ValidateCertificateRequest(global::Org.BouncyCastle.Crypto.Tls.CertificateRequest certificateRequest);

		// Token: 0x06002088 RID: 8328 RVA: 0x000918A7 File Offset: 0x0008FAA7
		public virtual void SkipClientCredentials()
		{
		}

		// Token: 0x06002089 RID: 8329
		public abstract void ProcessClientCredentials(global::Org.BouncyCastle.Crypto.Tls.TlsCredentials clientCredentials);

		// Token: 0x0600208A RID: 8330 RVA: 0x000918A9 File Offset: 0x0008FAA9
		public virtual void ProcessClientCertificate(global::Org.BouncyCastle.Crypto.Tls.Certificate clientCertificate)
		{
		}

		// Token: 0x0600208B RID: 8331
		public abstract void GenerateClientKeyExchange(global::System.IO.Stream output);

		// Token: 0x0600208C RID: 8332 RVA: 0x000918AB File Offset: 0x0008FAAB
		public virtual void ProcessClientKeyExchange(global::System.IO.Stream input)
		{
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
		}

		// Token: 0x0600208D RID: 8333
		public abstract byte[] GeneratePremasterSecret();

		// Token: 0x04000B4D RID: 2893
		protected readonly int mKeyExchange;

		// Token: 0x04000B4E RID: 2894
		protected global::System.Collections.IList mSupportedSignatureAlgorithms;

		// Token: 0x04000B4F RID: 2895
		protected global::Org.BouncyCastle.Crypto.Tls.TlsContext mContext;
	}
}
