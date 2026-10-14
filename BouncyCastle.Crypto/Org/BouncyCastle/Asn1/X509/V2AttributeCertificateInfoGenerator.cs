using System;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000676 RID: 1654
	public class V2AttributeCertificateInfoGenerator
	{
		// Token: 0x06003CFB RID: 15611 RVA: 0x001162F9 File Offset: 0x001144F9
		public V2AttributeCertificateInfoGenerator()
		{
			this.version = new global::Org.BouncyCastle.Asn1.DerInteger(1);
			this.attributes = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
		}

		// Token: 0x06003CFC RID: 15612 RVA: 0x00116318 File Offset: 0x00114518
		public void SetHolder(global::Org.BouncyCastle.Asn1.X509.Holder holder)
		{
			this.holder = holder;
		}

		// Token: 0x06003CFD RID: 15613 RVA: 0x00116321 File Offset: 0x00114521
		public void AddAttribute(string oid, global::Org.BouncyCastle.Asn1.Asn1Encodable value)
		{
			this.attributes.Add(new global::Org.BouncyCastle.Asn1.X509.AttributeX509(new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(oid), new global::Org.BouncyCastle.Asn1.DerSet(value)));
		}

		// Token: 0x06003CFE RID: 15614 RVA: 0x0011633F File Offset: 0x0011453F
		public void AddAttribute(global::Org.BouncyCastle.Asn1.X509.AttributeX509 attribute)
		{
			this.attributes.Add(attribute);
		}

		// Token: 0x06003CFF RID: 15615 RVA: 0x0011634D File Offset: 0x0011454D
		public void SetSerialNumber(global::Org.BouncyCastle.Asn1.DerInteger serialNumber)
		{
			this.serialNumber = serialNumber;
		}

		// Token: 0x06003D00 RID: 15616 RVA: 0x00116356 File Offset: 0x00114556
		public void SetSignature(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier signature)
		{
			this.signature = signature;
		}

		// Token: 0x06003D01 RID: 15617 RVA: 0x0011635F File Offset: 0x0011455F
		public void SetIssuer(global::Org.BouncyCastle.Asn1.X509.AttCertIssuer issuer)
		{
			this.issuer = issuer;
		}

		// Token: 0x06003D02 RID: 15618 RVA: 0x00116368 File Offset: 0x00114568
		public void SetStartDate(global::Org.BouncyCastle.Asn1.DerGeneralizedTime startDate)
		{
			this.startDate = startDate;
		}

		// Token: 0x06003D03 RID: 15619 RVA: 0x00116371 File Offset: 0x00114571
		public void SetEndDate(global::Org.BouncyCastle.Asn1.DerGeneralizedTime endDate)
		{
			this.endDate = endDate;
		}

		// Token: 0x06003D04 RID: 15620 RVA: 0x0011637A File Offset: 0x0011457A
		public void SetIssuerUniqueID(global::Org.BouncyCastle.Asn1.DerBitString issuerUniqueID)
		{
			this.issuerUniqueID = issuerUniqueID;
		}

		// Token: 0x06003D05 RID: 15621 RVA: 0x00116383 File Offset: 0x00114583
		public void SetExtensions(global::Org.BouncyCastle.Asn1.X509.X509Extensions extensions)
		{
			this.extensions = extensions;
		}

		// Token: 0x06003D06 RID: 15622 RVA: 0x0011638C File Offset: 0x0011458C
		public global::Org.BouncyCastle.Asn1.X509.AttributeCertificateInfo GenerateAttributeCertificateInfo()
		{
			if (this.serialNumber == null || this.signature == null || this.issuer == null || this.startDate == null || this.endDate == null || this.holder == null || this.attributes == null)
			{
				throw new global::System.InvalidOperationException("not all mandatory fields set in V2 AttributeCertificateInfo generator");
			}
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.version,
				this.holder,
				this.issuer,
				this.signature,
				this.serialNumber
			});
			v.Add(new global::Org.BouncyCastle.Asn1.X509.AttCertValidityPeriod(this.startDate, this.endDate));
			v.Add(new global::Org.BouncyCastle.Asn1.DerSequence(this.attributes));
			if (this.issuerUniqueID != null)
			{
				v.Add(this.issuerUniqueID);
			}
			if (this.extensions != null)
			{
				v.Add(this.extensions);
			}
			return global::Org.BouncyCastle.Asn1.X509.AttributeCertificateInfo.GetInstance(new global::Org.BouncyCastle.Asn1.DerSequence(v));
		}

		// Token: 0x04001AEC RID: 6892
		internal global::Org.BouncyCastle.Asn1.DerInteger version;

		// Token: 0x04001AED RID: 6893
		internal global::Org.BouncyCastle.Asn1.X509.Holder holder;

		// Token: 0x04001AEE RID: 6894
		internal global::Org.BouncyCastle.Asn1.X509.AttCertIssuer issuer;

		// Token: 0x04001AEF RID: 6895
		internal global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier signature;

		// Token: 0x04001AF0 RID: 6896
		internal global::Org.BouncyCastle.Asn1.DerInteger serialNumber;

		// Token: 0x04001AF1 RID: 6897
		internal global::Org.BouncyCastle.Asn1.Asn1EncodableVector attributes;

		// Token: 0x04001AF2 RID: 6898
		internal global::Org.BouncyCastle.Asn1.DerBitString issuerUniqueID;

		// Token: 0x04001AF3 RID: 6899
		internal global::Org.BouncyCastle.Asn1.X509.X509Extensions extensions;

		// Token: 0x04001AF4 RID: 6900
		internal global::Org.BouncyCastle.Asn1.DerGeneralizedTime startDate;

		// Token: 0x04001AF5 RID: 6901
		internal global::Org.BouncyCastle.Asn1.DerGeneralizedTime endDate;
	}
}
