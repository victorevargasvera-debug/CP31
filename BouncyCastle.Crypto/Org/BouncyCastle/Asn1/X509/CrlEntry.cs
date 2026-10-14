using System;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000671 RID: 1649
	public class CrlEntry : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003CCF RID: 15567 RVA: 0x00115B90 File Offset: 0x00113D90
		public CrlEntry(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count < 2 || seq.Count > 3)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString());
			}
			this.seq = seq;
			this.userCertificate = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[0]);
			this.revocationDate = global::Org.BouncyCastle.Asn1.X509.Time.GetInstance(seq[1]);
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x06003CD0 RID: 15568 RVA: 0x00115BFE File Offset: 0x00113DFE
		public global::Org.BouncyCastle.Asn1.DerInteger UserCertificate
		{
			get
			{
				return this.userCertificate;
			}
		}

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x06003CD1 RID: 15569 RVA: 0x00115C06 File Offset: 0x00113E06
		public global::Org.BouncyCastle.Asn1.X509.Time RevocationDate
		{
			get
			{
				return this.revocationDate;
			}
		}

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x06003CD2 RID: 15570 RVA: 0x00115C0E File Offset: 0x00113E0E
		public global::Org.BouncyCastle.Asn1.X509.X509Extensions Extensions
		{
			get
			{
				if (this.crlEntryExtensions == null && this.seq.Count == 3)
				{
					this.crlEntryExtensions = global::Org.BouncyCastle.Asn1.X509.X509Extensions.GetInstance(this.seq[2]);
				}
				return this.crlEntryExtensions;
			}
		}

		// Token: 0x06003CD3 RID: 15571 RVA: 0x00115C43 File Offset: 0x00113E43
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return this.seq;
		}

		// Token: 0x04001AD5 RID: 6869
		internal global::Org.BouncyCastle.Asn1.Asn1Sequence seq;

		// Token: 0x04001AD6 RID: 6870
		internal global::Org.BouncyCastle.Asn1.DerInteger userCertificate;

		// Token: 0x04001AD7 RID: 6871
		internal global::Org.BouncyCastle.Asn1.X509.Time revocationDate;

		// Token: 0x04001AD8 RID: 6872
		internal global::Org.BouncyCastle.Asn1.X509.X509Extensions crlEntryExtensions;
	}
}
