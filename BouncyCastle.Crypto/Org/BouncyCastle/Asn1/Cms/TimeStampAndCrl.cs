using System;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Asn1.Cms
{
	// Token: 0x02000766 RID: 1894
	public class TimeStampAndCrl : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060043AD RID: 17325 RVA: 0x0012EC70 File Offset: 0x0012CE70
		public TimeStampAndCrl(global::Org.BouncyCastle.Asn1.Cms.ContentInfo timeStamp)
		{
			this.timeStamp = timeStamp;
		}

		// Token: 0x060043AE RID: 17326 RVA: 0x0012EC7F File Offset: 0x0012CE7F
		private TimeStampAndCrl(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.timeStamp = global::Org.BouncyCastle.Asn1.Cms.ContentInfo.GetInstance(seq[0]);
			if (seq.Count == 2)
			{
				this.crl = global::Org.BouncyCastle.Asn1.X509.CertificateList.GetInstance(seq[1]);
			}
		}

		// Token: 0x060043AF RID: 17327 RVA: 0x0012ECB4 File Offset: 0x0012CEB4
		public static global::Org.BouncyCastle.Asn1.Cms.TimeStampAndCrl GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Cms.TimeStampAndCrl)
			{
				return (global::Org.BouncyCastle.Asn1.Cms.TimeStampAndCrl)obj;
			}
			if (obj != null)
			{
				return new global::Org.BouncyCastle.Asn1.Cms.TimeStampAndCrl(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
			}
			return null;
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x060043B0 RID: 17328 RVA: 0x0012ECD5 File Offset: 0x0012CED5
		public virtual global::Org.BouncyCastle.Asn1.Cms.ContentInfo TimeStampToken
		{
			get
			{
				return this.timeStamp;
			}
		}

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x060043B1 RID: 17329 RVA: 0x0012ECDD File Offset: 0x0012CEDD
		public virtual global::Org.BouncyCastle.Asn1.X509.CertificateList Crl
		{
			get
			{
				return this.crl;
			}
		}

		// Token: 0x060043B2 RID: 17330 RVA: 0x0012ECE8 File Offset: 0x0012CEE8
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.timeStamp
			});
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.crl
			});
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04002088 RID: 8328
		private global::Org.BouncyCastle.Asn1.Cms.ContentInfo timeStamp;

		// Token: 0x04002089 RID: 8329
		private global::Org.BouncyCastle.Asn1.X509.CertificateList crl;
	}
}
