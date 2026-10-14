using System;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000679 RID: 1657
	public class V3TbsCertificateGenerator
	{
		// Token: 0x06003D21 RID: 15649 RVA: 0x001168DC File Offset: 0x00114ADC
		public void SetSerialNumber(global::Org.BouncyCastle.Asn1.DerInteger serialNumber)
		{
			this.serialNumber = serialNumber;
		}

		// Token: 0x06003D22 RID: 15650 RVA: 0x001168E5 File Offset: 0x00114AE5
		public void SetSignature(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier signature)
		{
			this.signature = signature;
		}

		// Token: 0x06003D23 RID: 15651 RVA: 0x001168EE File Offset: 0x00114AEE
		public void SetIssuer(global::Org.BouncyCastle.Asn1.X509.X509Name issuer)
		{
			this.issuer = issuer;
		}

		// Token: 0x06003D24 RID: 15652 RVA: 0x001168F7 File Offset: 0x00114AF7
		public void SetStartDate(global::Org.BouncyCastle.Asn1.DerUtcTime startDate)
		{
			this.startDate = new global::Org.BouncyCastle.Asn1.X509.Time(startDate);
		}

		// Token: 0x06003D25 RID: 15653 RVA: 0x00116905 File Offset: 0x00114B05
		public void SetStartDate(global::Org.BouncyCastle.Asn1.X509.Time startDate)
		{
			this.startDate = startDate;
		}

		// Token: 0x06003D26 RID: 15654 RVA: 0x0011690E File Offset: 0x00114B0E
		public void SetEndDate(global::Org.BouncyCastle.Asn1.DerUtcTime endDate)
		{
			this.endDate = new global::Org.BouncyCastle.Asn1.X509.Time(endDate);
		}

		// Token: 0x06003D27 RID: 15655 RVA: 0x0011691C File Offset: 0x00114B1C
		public void SetEndDate(global::Org.BouncyCastle.Asn1.X509.Time endDate)
		{
			this.endDate = endDate;
		}

		// Token: 0x06003D28 RID: 15656 RVA: 0x00116925 File Offset: 0x00114B25
		public void SetSubject(global::Org.BouncyCastle.Asn1.X509.X509Name subject)
		{
			this.subject = subject;
		}

		// Token: 0x06003D29 RID: 15657 RVA: 0x0011692E File Offset: 0x00114B2E
		public void SetIssuerUniqueID(global::Org.BouncyCastle.Asn1.DerBitString uniqueID)
		{
			this.issuerUniqueID = uniqueID;
		}

		// Token: 0x06003D2A RID: 15658 RVA: 0x00116937 File Offset: 0x00114B37
		public void SetSubjectUniqueID(global::Org.BouncyCastle.Asn1.DerBitString uniqueID)
		{
			this.subjectUniqueID = uniqueID;
		}

		// Token: 0x06003D2B RID: 15659 RVA: 0x00116940 File Offset: 0x00114B40
		public void SetSubjectPublicKeyInfo(global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo pubKeyInfo)
		{
			this.subjectPublicKeyInfo = pubKeyInfo;
		}

		// Token: 0x06003D2C RID: 15660 RVA: 0x0011694C File Offset: 0x00114B4C
		public void SetExtensions(global::Org.BouncyCastle.Asn1.X509.X509Extensions extensions)
		{
			this.extensions = extensions;
			if (extensions != null)
			{
				global::Org.BouncyCastle.Asn1.X509.X509Extension altName = extensions.GetExtension(global::Org.BouncyCastle.Asn1.X509.X509Extensions.SubjectAlternativeName);
				if (altName != null && altName.IsCritical)
				{
					this.altNamePresentAndCritical = true;
				}
			}
		}

		// Token: 0x06003D2D RID: 15661 RVA: 0x00116984 File Offset: 0x00114B84
		public global::Org.BouncyCastle.Asn1.X509.TbsCertificateStructure GenerateTbsCertificate()
		{
			if (this.serialNumber == null || this.signature == null || this.issuer == null || this.startDate == null || this.endDate == null || (this.subject == null && !this.altNamePresentAndCritical) || this.subjectPublicKeyInfo == null)
			{
				throw new global::System.InvalidOperationException("not all mandatory fields set in V3 TBScertificate generator");
			}
			global::Org.BouncyCastle.Asn1.DerSequence validity = new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.startDate,
				this.endDate
			});
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.version,
				this.serialNumber,
				this.signature,
				this.issuer,
				validity
			});
			if (this.subject != null)
			{
				v.Add(this.subject);
			}
			else
			{
				v.Add(global::Org.BouncyCastle.Asn1.DerSequence.Empty);
			}
			v.Add(this.subjectPublicKeyInfo);
			if (this.issuerUniqueID != null)
			{
				v.Add(new global::Org.BouncyCastle.Asn1.DerTaggedObject(false, 1, this.issuerUniqueID));
			}
			if (this.subjectUniqueID != null)
			{
				v.Add(new global::Org.BouncyCastle.Asn1.DerTaggedObject(false, 2, this.subjectUniqueID));
			}
			if (this.extensions != null)
			{
				v.Add(new global::Org.BouncyCastle.Asn1.DerTaggedObject(3, this.extensions));
			}
			return new global::Org.BouncyCastle.Asn1.X509.TbsCertificateStructure(new global::Org.BouncyCastle.Asn1.DerSequence(v));
		}

		// Token: 0x04001B00 RID: 6912
		internal global::Org.BouncyCastle.Asn1.DerTaggedObject version = new global::Org.BouncyCastle.Asn1.DerTaggedObject(0, new global::Org.BouncyCastle.Asn1.DerInteger(2));

		// Token: 0x04001B01 RID: 6913
		internal global::Org.BouncyCastle.Asn1.DerInteger serialNumber;

		// Token: 0x04001B02 RID: 6914
		internal global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier signature;

		// Token: 0x04001B03 RID: 6915
		internal global::Org.BouncyCastle.Asn1.X509.X509Name issuer;

		// Token: 0x04001B04 RID: 6916
		internal global::Org.BouncyCastle.Asn1.X509.Time startDate;

		// Token: 0x04001B05 RID: 6917
		internal global::Org.BouncyCastle.Asn1.X509.Time endDate;

		// Token: 0x04001B06 RID: 6918
		internal global::Org.BouncyCastle.Asn1.X509.X509Name subject;

		// Token: 0x04001B07 RID: 6919
		internal global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo subjectPublicKeyInfo;

		// Token: 0x04001B08 RID: 6920
		internal global::Org.BouncyCastle.Asn1.X509.X509Extensions extensions;

		// Token: 0x04001B09 RID: 6921
		private bool altNamePresentAndCritical;

		// Token: 0x04001B0A RID: 6922
		private global::Org.BouncyCastle.Asn1.DerBitString issuerUniqueID;

		// Token: 0x04001B0B RID: 6923
		private global::Org.BouncyCastle.Asn1.DerBitString subjectUniqueID;
	}
}
