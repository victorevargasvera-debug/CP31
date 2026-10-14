using System;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Asn1.Crmf
{
	// Token: 0x0200072B RID: 1835
	public class CertTemplateBuilder
	{
		// Token: 0x060041E5 RID: 16869 RVA: 0x00129EF6 File Offset: 0x001280F6
		public virtual global::Org.BouncyCastle.Asn1.Crmf.CertTemplateBuilder SetVersion(int ver)
		{
			this.version = new global::Org.BouncyCastle.Asn1.DerInteger(ver);
			return this;
		}

		// Token: 0x060041E6 RID: 16870 RVA: 0x00129F05 File Offset: 0x00128105
		public virtual global::Org.BouncyCastle.Asn1.Crmf.CertTemplateBuilder SetSerialNumber(global::Org.BouncyCastle.Asn1.DerInteger ser)
		{
			this.serialNumber = ser;
			return this;
		}

		// Token: 0x060041E7 RID: 16871 RVA: 0x00129F0F File Offset: 0x0012810F
		public virtual global::Org.BouncyCastle.Asn1.Crmf.CertTemplateBuilder SetSigningAlg(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier aid)
		{
			this.signingAlg = aid;
			return this;
		}

		// Token: 0x060041E8 RID: 16872 RVA: 0x00129F19 File Offset: 0x00128119
		public virtual global::Org.BouncyCastle.Asn1.Crmf.CertTemplateBuilder SetIssuer(global::Org.BouncyCastle.Asn1.X509.X509Name name)
		{
			this.issuer = name;
			return this;
		}

		// Token: 0x060041E9 RID: 16873 RVA: 0x00129F23 File Offset: 0x00128123
		public virtual global::Org.BouncyCastle.Asn1.Crmf.CertTemplateBuilder SetValidity(global::Org.BouncyCastle.Asn1.Crmf.OptionalValidity v)
		{
			this.validity = v;
			return this;
		}

		// Token: 0x060041EA RID: 16874 RVA: 0x00129F2D File Offset: 0x0012812D
		public virtual global::Org.BouncyCastle.Asn1.Crmf.CertTemplateBuilder SetSubject(global::Org.BouncyCastle.Asn1.X509.X509Name name)
		{
			this.subject = name;
			return this;
		}

		// Token: 0x060041EB RID: 16875 RVA: 0x00129F37 File Offset: 0x00128137
		public virtual global::Org.BouncyCastle.Asn1.Crmf.CertTemplateBuilder SetPublicKey(global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo spki)
		{
			this.publicKey = spki;
			return this;
		}

		// Token: 0x060041EC RID: 16876 RVA: 0x00129F41 File Offset: 0x00128141
		public virtual global::Org.BouncyCastle.Asn1.Crmf.CertTemplateBuilder SetIssuerUID(global::Org.BouncyCastle.Asn1.DerBitString uid)
		{
			this.issuerUID = uid;
			return this;
		}

		// Token: 0x060041ED RID: 16877 RVA: 0x00129F4B File Offset: 0x0012814B
		public virtual global::Org.BouncyCastle.Asn1.Crmf.CertTemplateBuilder SetSubjectUID(global::Org.BouncyCastle.Asn1.DerBitString uid)
		{
			this.subjectUID = uid;
			return this;
		}

		// Token: 0x060041EE RID: 16878 RVA: 0x00129F55 File Offset: 0x00128155
		public virtual global::Org.BouncyCastle.Asn1.Crmf.CertTemplateBuilder SetExtensions(global::Org.BouncyCastle.Asn1.X509.X509Extensions extens)
		{
			this.extensions = extens;
			return this;
		}

		// Token: 0x060041EF RID: 16879 RVA: 0x00129F60 File Offset: 0x00128160
		public virtual global::Org.BouncyCastle.Asn1.Crmf.CertTemplate Build()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			this.AddOptional(v, 0, false, this.version);
			this.AddOptional(v, 1, false, this.serialNumber);
			this.AddOptional(v, 2, false, this.signingAlg);
			this.AddOptional(v, 3, true, this.issuer);
			this.AddOptional(v, 4, false, this.validity);
			this.AddOptional(v, 5, true, this.subject);
			this.AddOptional(v, 6, false, this.publicKey);
			this.AddOptional(v, 7, false, this.issuerUID);
			this.AddOptional(v, 8, false, this.subjectUID);
			this.AddOptional(v, 9, false, this.extensions);
			return global::Org.BouncyCastle.Asn1.Crmf.CertTemplate.GetInstance(new global::Org.BouncyCastle.Asn1.DerSequence(v));
		}

		// Token: 0x060041F0 RID: 16880 RVA: 0x0012A015 File Offset: 0x00128215
		private void AddOptional(global::Org.BouncyCastle.Asn1.Asn1EncodableVector v, int tagNo, bool isExplicit, global::Org.BouncyCastle.Asn1.Asn1Encodable obj)
		{
			if (obj != null)
			{
				v.Add(new global::Org.BouncyCastle.Asn1.DerTaggedObject(isExplicit, tagNo, obj));
			}
		}

		// Token: 0x04001FB3 RID: 8115
		private global::Org.BouncyCastle.Asn1.DerInteger version;

		// Token: 0x04001FB4 RID: 8116
		private global::Org.BouncyCastle.Asn1.DerInteger serialNumber;

		// Token: 0x04001FB5 RID: 8117
		private global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier signingAlg;

		// Token: 0x04001FB6 RID: 8118
		private global::Org.BouncyCastle.Asn1.X509.X509Name issuer;

		// Token: 0x04001FB7 RID: 8119
		private global::Org.BouncyCastle.Asn1.Crmf.OptionalValidity validity;

		// Token: 0x04001FB8 RID: 8120
		private global::Org.BouncyCastle.Asn1.X509.X509Name subject;

		// Token: 0x04001FB9 RID: 8121
		private global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo publicKey;

		// Token: 0x04001FBA RID: 8122
		private global::Org.BouncyCastle.Asn1.DerBitString issuerUID;

		// Token: 0x04001FBB RID: 8123
		private global::Org.BouncyCastle.Asn1.DerBitString subjectUID;

		// Token: 0x04001FBC RID: 8124
		private global::Org.BouncyCastle.Asn1.X509.X509Extensions extensions;
	}
}
