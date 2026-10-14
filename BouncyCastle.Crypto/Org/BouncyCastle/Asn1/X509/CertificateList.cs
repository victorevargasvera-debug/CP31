using System;
using System.Collections;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000648 RID: 1608
	public class CertificateList : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003B91 RID: 15249 RVA: 0x00111F87 File Offset: 0x00110187
		public static global::Org.BouncyCastle.Asn1.X509.CertificateList GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.X509.CertificateList.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, explicitly));
		}

		// Token: 0x06003B92 RID: 15250 RVA: 0x00111F95 File Offset: 0x00110195
		public static global::Org.BouncyCastle.Asn1.X509.CertificateList GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.X509.CertificateList)
			{
				return (global::Org.BouncyCastle.Asn1.X509.CertificateList)obj;
			}
			if (obj != null)
			{
				return new global::Org.BouncyCastle.Asn1.X509.CertificateList(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
			}
			return null;
		}

		// Token: 0x06003B93 RID: 15251 RVA: 0x00111FB8 File Offset: 0x001101B8
		private CertificateList(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count != 3)
			{
				throw new global::System.ArgumentException("sequence wrong size for CertificateList", "seq");
			}
			this.tbsCertList = global::Org.BouncyCastle.Asn1.X509.TbsCertificateList.GetInstance(seq[0]);
			this.sigAlgID = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(seq[1]);
			this.sig = global::Org.BouncyCastle.Asn1.DerBitString.GetInstance(seq[2]);
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x06003B94 RID: 15252 RVA: 0x0011201A File Offset: 0x0011021A
		public global::Org.BouncyCastle.Asn1.X509.TbsCertificateList TbsCertList
		{
			get
			{
				return this.tbsCertList;
			}
		}

		// Token: 0x06003B95 RID: 15253 RVA: 0x00112022 File Offset: 0x00110222
		public global::Org.BouncyCastle.Asn1.X509.CrlEntry[] GetRevokedCertificates()
		{
			return this.tbsCertList.GetRevokedCertificates();
		}

		// Token: 0x06003B96 RID: 15254 RVA: 0x0011202F File Offset: 0x0011022F
		public global::System.Collections.IEnumerable GetRevokedCertificateEnumeration()
		{
			return this.tbsCertList.GetRevokedCertificateEnumeration();
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x06003B97 RID: 15255 RVA: 0x0011203C File Offset: 0x0011023C
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier SignatureAlgorithm
		{
			get
			{
				return this.sigAlgID;
			}
		}

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x06003B98 RID: 15256 RVA: 0x00112044 File Offset: 0x00110244
		public global::Org.BouncyCastle.Asn1.DerBitString Signature
		{
			get
			{
				return this.sig;
			}
		}

		// Token: 0x06003B99 RID: 15257 RVA: 0x0011204C File Offset: 0x0011024C
		public byte[] GetSignatureOctets()
		{
			return this.sig.GetOctets();
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x06003B9A RID: 15258 RVA: 0x00112059 File Offset: 0x00110259
		public int Version
		{
			get
			{
				return this.tbsCertList.Version;
			}
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x06003B9B RID: 15259 RVA: 0x00112066 File Offset: 0x00110266
		public global::Org.BouncyCastle.Asn1.X509.X509Name Issuer
		{
			get
			{
				return this.tbsCertList.Issuer;
			}
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x06003B9C RID: 15260 RVA: 0x00112073 File Offset: 0x00110273
		public global::Org.BouncyCastle.Asn1.X509.Time ThisUpdate
		{
			get
			{
				return this.tbsCertList.ThisUpdate;
			}
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x06003B9D RID: 15261 RVA: 0x00112080 File Offset: 0x00110280
		public global::Org.BouncyCastle.Asn1.X509.Time NextUpdate
		{
			get
			{
				return this.tbsCertList.NextUpdate;
			}
		}

		// Token: 0x06003B9E RID: 15262 RVA: 0x0011208D File Offset: 0x0011028D
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.tbsCertList,
				this.sigAlgID,
				this.sig
			});
		}

		// Token: 0x04001A3D RID: 6717
		private readonly global::Org.BouncyCastle.Asn1.X509.TbsCertificateList tbsCertList;

		// Token: 0x04001A3E RID: 6718
		private readonly global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sigAlgID;

		// Token: 0x04001A3F RID: 6719
		private readonly global::Org.BouncyCastle.Asn1.DerBitString sig;
	}
}
