using System;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000675 RID: 1653
	public class V1TbsCertificateGenerator
	{
		// Token: 0x06003CF1 RID: 15601 RVA: 0x001161F1 File Offset: 0x001143F1
		public void SetSerialNumber(global::Org.BouncyCastle.Asn1.DerInteger serialNumber)
		{
			this.serialNumber = serialNumber;
		}

		// Token: 0x06003CF2 RID: 15602 RVA: 0x001161FA File Offset: 0x001143FA
		public void SetSignature(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier signature)
		{
			this.signature = signature;
		}

		// Token: 0x06003CF3 RID: 15603 RVA: 0x00116203 File Offset: 0x00114403
		public void SetIssuer(global::Org.BouncyCastle.Asn1.X509.X509Name issuer)
		{
			this.issuer = issuer;
		}

		// Token: 0x06003CF4 RID: 15604 RVA: 0x0011620C File Offset: 0x0011440C
		public void SetStartDate(global::Org.BouncyCastle.Asn1.X509.Time startDate)
		{
			this.startDate = startDate;
		}

		// Token: 0x06003CF5 RID: 15605 RVA: 0x00116215 File Offset: 0x00114415
		public void SetStartDate(global::Org.BouncyCastle.Asn1.DerUtcTime startDate)
		{
			this.startDate = new global::Org.BouncyCastle.Asn1.X509.Time(startDate);
		}

		// Token: 0x06003CF6 RID: 15606 RVA: 0x00116223 File Offset: 0x00114423
		public void SetEndDate(global::Org.BouncyCastle.Asn1.X509.Time endDate)
		{
			this.endDate = endDate;
		}

		// Token: 0x06003CF7 RID: 15607 RVA: 0x0011622C File Offset: 0x0011442C
		public void SetEndDate(global::Org.BouncyCastle.Asn1.DerUtcTime endDate)
		{
			this.endDate = new global::Org.BouncyCastle.Asn1.X509.Time(endDate);
		}

		// Token: 0x06003CF8 RID: 15608 RVA: 0x0011623A File Offset: 0x0011443A
		public void SetSubject(global::Org.BouncyCastle.Asn1.X509.X509Name subject)
		{
			this.subject = subject;
		}

		// Token: 0x06003CF9 RID: 15609 RVA: 0x00116243 File Offset: 0x00114443
		public void SetSubjectPublicKeyInfo(global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo pubKeyInfo)
		{
			this.subjectPublicKeyInfo = pubKeyInfo;
		}

		// Token: 0x06003CFA RID: 15610 RVA: 0x0011624C File Offset: 0x0011444C
		public global::Org.BouncyCastle.Asn1.X509.TbsCertificateStructure GenerateTbsCertificate()
		{
			if (this.serialNumber == null || this.signature == null || this.issuer == null || this.startDate == null || this.endDate == null || this.subject == null || this.subjectPublicKeyInfo == null)
			{
				throw new global::System.InvalidOperationException("not all mandatory fields set in V1 TBScertificate generator");
			}
			return new global::Org.BouncyCastle.Asn1.X509.TbsCertificateStructure(new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.serialNumber,
				this.signature,
				this.issuer,
				new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
				{
					this.startDate,
					this.endDate
				}),
				this.subject,
				this.subjectPublicKeyInfo
			}));
		}

		// Token: 0x04001AE4 RID: 6884
		internal global::Org.BouncyCastle.Asn1.DerTaggedObject version = new global::Org.BouncyCastle.Asn1.DerTaggedObject(0, new global::Org.BouncyCastle.Asn1.DerInteger(0));

		// Token: 0x04001AE5 RID: 6885
		internal global::Org.BouncyCastle.Asn1.DerInteger serialNumber;

		// Token: 0x04001AE6 RID: 6886
		internal global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier signature;

		// Token: 0x04001AE7 RID: 6887
		internal global::Org.BouncyCastle.Asn1.X509.X509Name issuer;

		// Token: 0x04001AE8 RID: 6888
		internal global::Org.BouncyCastle.Asn1.X509.Time startDate;

		// Token: 0x04001AE9 RID: 6889
		internal global::Org.BouncyCastle.Asn1.X509.Time endDate;

		// Token: 0x04001AEA RID: 6890
		internal global::Org.BouncyCastle.Asn1.X509.X509Name subject;

		// Token: 0x04001AEB RID: 6891
		internal global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo subjectPublicKeyInfo;
	}
}
