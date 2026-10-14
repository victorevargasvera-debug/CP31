using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Security.Certificates;

namespace Org.BouncyCastle.X509
{
	// Token: 0x02000014 RID: 20
	public class X509CertificatePair
	{
		// Token: 0x060000E1 RID: 225 RVA: 0x00007242 File Offset: 0x00005442
		public X509CertificatePair(global::Org.BouncyCastle.X509.X509Certificate forward, global::Org.BouncyCastle.X509.X509Certificate reverse)
		{
			this.forward = forward;
			this.reverse = reverse;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00007258 File Offset: 0x00005458
		public X509CertificatePair(global::Org.BouncyCastle.Asn1.X509.CertificatePair pair)
		{
			if (pair.Forward != null)
			{
				this.forward = new global::Org.BouncyCastle.X509.X509Certificate(pair.Forward);
			}
			if (pair.Reverse != null)
			{
				this.reverse = new global::Org.BouncyCastle.X509.X509Certificate(pair.Reverse);
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00007294 File Offset: 0x00005494
		public byte[] GetEncoded()
		{
			byte[] derEncoded;
			try
			{
				global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure f = null;
				global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure r = null;
				if (this.forward != null)
				{
					f = global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(this.forward.GetEncoded()));
					if (f == null)
					{
						throw new global::Org.BouncyCastle.Security.Certificates.CertificateEncodingException("unable to get encoding for forward");
					}
				}
				if (this.reverse != null)
				{
					r = global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(this.reverse.GetEncoded()));
					if (r == null)
					{
						throw new global::Org.BouncyCastle.Security.Certificates.CertificateEncodingException("unable to get encoding for reverse");
					}
				}
				derEncoded = new global::Org.BouncyCastle.Asn1.X509.CertificatePair(f, r).GetDerEncoded();
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Security.Certificates.CertificateEncodingException(e.Message, e);
			}
			return derEncoded;
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x0000732C File Offset: 0x0000552C
		public global::Org.BouncyCastle.X509.X509Certificate Forward
		{
			get
			{
				return this.forward;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x00007334 File Offset: 0x00005534
		public global::Org.BouncyCastle.X509.X509Certificate Reverse
		{
			get
			{
				return this.reverse;
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000733C File Offset: 0x0000553C
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			global::Org.BouncyCastle.X509.X509CertificatePair other = obj as global::Org.BouncyCastle.X509.X509CertificatePair;
			return other != null && object.Equals(this.forward, other.forward) && object.Equals(this.reverse, other.reverse);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00007384 File Offset: 0x00005584
		public override int GetHashCode()
		{
			int hash = -1;
			if (this.forward != null)
			{
				hash ^= this.forward.GetHashCode();
			}
			if (this.reverse != null)
			{
				hash *= 17;
				hash ^= this.reverse.GetHashCode();
			}
			return hash;
		}

		// Token: 0x04000087 RID: 135
		private readonly global::Org.BouncyCastle.X509.X509Certificate forward;

		// Token: 0x04000088 RID: 136
		private readonly global::Org.BouncyCastle.X509.X509Certificate reverse;
	}
}
