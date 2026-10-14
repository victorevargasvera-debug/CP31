using System;
using System.Text;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Pkix
{
	// Token: 0x020001A8 RID: 424
	public class TrustAnchor
	{
		// Token: 0x06001013 RID: 4115 RVA: 0x0003FBF8 File Offset: 0x0003DDF8
		public TrustAnchor(global::Org.BouncyCastle.X509.X509Certificate trustedCert, byte[] nameConstraints)
		{
			if (trustedCert == null)
			{
				throw new global::System.ArgumentNullException("trustedCert");
			}
			this.trustedCert = trustedCert;
			this.pubKey = null;
			this.caName = null;
			this.caPrincipal = null;
			this.setNameConstraints(nameConstraints);
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x0003FC34 File Offset: 0x0003DE34
		public TrustAnchor(global::Org.BouncyCastle.Asn1.X509.X509Name caPrincipal, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter pubKey, byte[] nameConstraints)
		{
			if (caPrincipal == null)
			{
				throw new global::System.ArgumentNullException("caPrincipal");
			}
			if (pubKey == null)
			{
				throw new global::System.ArgumentNullException("pubKey");
			}
			this.trustedCert = null;
			this.caPrincipal = caPrincipal;
			this.caName = caPrincipal.ToString();
			this.pubKey = pubKey;
			this.setNameConstraints(nameConstraints);
		}

		// Token: 0x06001015 RID: 4117 RVA: 0x0003FC8C File Offset: 0x0003DE8C
		public TrustAnchor(string caName, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter pubKey, byte[] nameConstraints)
		{
			if (caName == null)
			{
				throw new global::System.ArgumentNullException("caName");
			}
			if (pubKey == null)
			{
				throw new global::System.ArgumentNullException("pubKey");
			}
			if (caName.Length == 0)
			{
				throw new global::System.ArgumentException("caName can not be an empty string");
			}
			this.caPrincipal = new global::Org.BouncyCastle.Asn1.X509.X509Name(caName);
			this.pubKey = pubKey;
			this.caName = caName;
			this.trustedCert = null;
			this.setNameConstraints(nameConstraints);
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06001016 RID: 4118 RVA: 0x0003FCF6 File Offset: 0x0003DEF6
		public global::Org.BouncyCastle.X509.X509Certificate TrustedCert
		{
			get
			{
				return this.trustedCert;
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06001017 RID: 4119 RVA: 0x0003FCFE File Offset: 0x0003DEFE
		public global::Org.BouncyCastle.Asn1.X509.X509Name CA
		{
			get
			{
				return this.caPrincipal;
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06001018 RID: 4120 RVA: 0x0003FD06 File Offset: 0x0003DF06
		public string CAName
		{
			get
			{
				return this.caName;
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06001019 RID: 4121 RVA: 0x0003FD0E File Offset: 0x0003DF0E
		public global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter CAPublicKey
		{
			get
			{
				return this.pubKey;
			}
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x0003FD16 File Offset: 0x0003DF16
		private void setNameConstraints(byte[] bytes)
		{
			if (bytes == null)
			{
				this.ncBytes = null;
				this.nc = null;
				return;
			}
			this.ncBytes = (byte[])bytes.Clone();
			this.nc = global::Org.BouncyCastle.Asn1.X509.NameConstraints.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(bytes));
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x0600101B RID: 4123 RVA: 0x0003FD4C File Offset: 0x0003DF4C
		public byte[] GetNameConstraints
		{
			get
			{
				return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.ncBytes);
			}
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x0003FD5C File Offset: 0x0003DF5C
		public override string ToString()
		{
			string nl = global::Org.BouncyCastle.Utilities.Platform.NewLine;
			global::System.Text.StringBuilder sb = new global::System.Text.StringBuilder();
			sb.Append("[");
			sb.Append(nl);
			if (this.pubKey != null)
			{
				sb.Append("  Trusted CA Public Key: ").Append(this.pubKey).Append(nl);
				sb.Append("  Trusted CA Issuer Name: ").Append(this.caName).Append(nl);
			}
			else
			{
				sb.Append("  Trusted CA cert: ").Append(this.TrustedCert).Append(nl);
			}
			if (this.nc != null)
			{
				sb.Append("  Name Constraints: ").Append(this.nc).Append(nl);
			}
			return sb.ToString();
		}

		// Token: 0x04000894 RID: 2196
		private readonly global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter pubKey;

		// Token: 0x04000895 RID: 2197
		private readonly string caName;

		// Token: 0x04000896 RID: 2198
		private readonly global::Org.BouncyCastle.Asn1.X509.X509Name caPrincipal;

		// Token: 0x04000897 RID: 2199
		private readonly global::Org.BouncyCastle.X509.X509Certificate trustedCert;

		// Token: 0x04000898 RID: 2200
		private byte[] ncBytes;

		// Token: 0x04000899 RID: 2201
		private global::Org.BouncyCastle.Asn1.X509.NameConstraints nc;
	}
}
