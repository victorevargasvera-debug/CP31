using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Microsoft.IdentityModel.Logging;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x0200004B RID: 75
	public class X509SecurityKey : global::Microsoft.IdentityModel.Tokens.AsymmetricSecurityKey
	{
		// Token: 0x0600022F RID: 559 RVA: 0x00008880 File Offset: 0x00006A80
		public X509SecurityKey(global::System.Security.Cryptography.X509Certificates.X509Certificate2 certificate)
		{
			if (certificate == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentNullException("certificate"));
			}
			this._certificate = certificate;
			this.KeyId = certificate.Thumbprint;
			this.X5t = global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.Encode(certificate.GetCertHash());
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000230 RID: 560 RVA: 0x000088D6 File Offset: 0x00006AD6
		public override int KeySize
		{
			get
			{
				return this.PublicKey.KeySize;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000231 RID: 561 RVA: 0x000088E3 File Offset: 0x00006AE3
		public string X5t { get; }

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000232 RID: 562 RVA: 0x000088EC File Offset: 0x00006AEC
		public global::System.Security.Cryptography.AsymmetricAlgorithm PrivateKey
		{
			get
			{
				if (!this._privateKeyAvailabilityDetermined)
				{
					object thisLock = this.ThisLock;
					lock (thisLock)
					{
						if (!this._privateKeyAvailabilityDetermined)
						{
							this._privateKey = this._certificate.PrivateKey;
							this._privateKeyAvailabilityDetermined = true;
						}
					}
				}
				return this._privateKey;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000233 RID: 563 RVA: 0x00008954 File Offset: 0x00006B54
		public global::System.Security.Cryptography.AsymmetricAlgorithm PublicKey
		{
			get
			{
				if (this._publicKey == null)
				{
					object thisLock = this.ThisLock;
					lock (thisLock)
					{
						if (this._publicKey == null)
						{
							this._publicKey = this._certificate.PublicKey.Key;
						}
					}
				}
				return this._publicKey;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000234 RID: 564 RVA: 0x000089BC File Offset: 0x00006BBC
		private object ThisLock
		{
			get
			{
				return this._thisLock;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000235 RID: 565 RVA: 0x000089C4 File Offset: 0x00006BC4
		[global::System.Obsolete("HasPrivateKey method is deprecated, please use PrivateKeyStatus instead.")]
		public override bool HasPrivateKey
		{
			get
			{
				return this.PrivateKey != null;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000236 RID: 566 RVA: 0x000089CF File Offset: 0x00006BCF
		public override global::Microsoft.IdentityModel.Tokens.PrivateKeyStatus PrivateKeyStatus
		{
			get
			{
				if (this.PrivateKey != null)
				{
					return global::Microsoft.IdentityModel.Tokens.PrivateKeyStatus.Exists;
				}
				return global::Microsoft.IdentityModel.Tokens.PrivateKeyStatus.DoesNotExist;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000237 RID: 567 RVA: 0x000089DC File Offset: 0x00006BDC
		public global::System.Security.Cryptography.X509Certificates.X509Certificate2 Certificate
		{
			get
			{
				return this._certificate;
			}
		}

		// Token: 0x06000238 RID: 568 RVA: 0x000089E4 File Offset: 0x00006BE4
		public override bool Equals(object obj)
		{
			global::Microsoft.IdentityModel.Tokens.X509SecurityKey x509SecurityKey = obj as global::Microsoft.IdentityModel.Tokens.X509SecurityKey;
			return x509SecurityKey != null && x509SecurityKey.Certificate.Thumbprint.ToString() == this._certificate.Thumbprint.ToString();
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00008A22 File Offset: 0x00006C22
		public override int GetHashCode()
		{
			return this._certificate.GetHashCode();
		}

		// Token: 0x0400019C RID: 412
		private global::System.Security.Cryptography.X509Certificates.X509Certificate2 _certificate;

		// Token: 0x0400019D RID: 413
		private global::System.Security.Cryptography.AsymmetricAlgorithm _privateKey;

		// Token: 0x0400019E RID: 414
		private bool _privateKeyAvailabilityDetermined;

		// Token: 0x0400019F RID: 415
		private global::System.Security.Cryptography.AsymmetricAlgorithm _publicKey;

		// Token: 0x040001A0 RID: 416
		private object _thisLock = new object();
	}
}
