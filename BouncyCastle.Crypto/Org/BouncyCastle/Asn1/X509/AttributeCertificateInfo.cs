using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000643 RID: 1603
	public class AttributeCertificateInfo : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003B5B RID: 15195 RVA: 0x00111651 File Offset: 0x0010F851
		public static global::Org.BouncyCastle.Asn1.X509.AttributeCertificateInfo GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
		{
			return global::Org.BouncyCastle.Asn1.X509.AttributeCertificateInfo.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, isExplicit));
		}

		// Token: 0x06003B5C RID: 15196 RVA: 0x0011165F File Offset: 0x0010F85F
		public static global::Org.BouncyCastle.Asn1.X509.AttributeCertificateInfo GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.X509.AttributeCertificateInfo)
			{
				return (global::Org.BouncyCastle.Asn1.X509.AttributeCertificateInfo)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.X509.AttributeCertificateInfo((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003B5D RID: 15197 RVA: 0x001116A0 File Offset: 0x0010F8A0
		private AttributeCertificateInfo(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count < 6 || seq.Count > 9)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString());
			}
			int start;
			if (seq[0] is global::Org.BouncyCastle.Asn1.DerInteger)
			{
				this.version = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[0]);
				start = 1;
			}
			else
			{
				this.version = new global::Org.BouncyCastle.Asn1.DerInteger(0);
				start = 0;
			}
			this.holder = global::Org.BouncyCastle.Asn1.X509.Holder.GetInstance(seq[start]);
			this.issuer = global::Org.BouncyCastle.Asn1.X509.AttCertIssuer.GetInstance(seq[start + 1]);
			this.signature = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(seq[start + 2]);
			this.serialNumber = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[start + 3]);
			this.attrCertValidityPeriod = global::Org.BouncyCastle.Asn1.X509.AttCertValidityPeriod.GetInstance(seq[start + 4]);
			this.attributes = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(seq[start + 5]);
			for (int i = start + 6; i < seq.Count; i++)
			{
				global::Org.BouncyCastle.Asn1.Asn1Encodable obj = seq[i];
				if (obj is global::Org.BouncyCastle.Asn1.DerBitString)
				{
					this.issuerUniqueID = global::Org.BouncyCastle.Asn1.DerBitString.GetInstance(seq[i]);
				}
				else if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence || obj is global::Org.BouncyCastle.Asn1.X509.X509Extensions)
				{
					this.extensions = global::Org.BouncyCastle.Asn1.X509.X509Extensions.GetInstance(seq[i]);
				}
			}
		}

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x06003B5E RID: 15198 RVA: 0x001117E5 File Offset: 0x0010F9E5
		public global::Org.BouncyCastle.Asn1.DerInteger Version
		{
			get
			{
				return this.version;
			}
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x06003B5F RID: 15199 RVA: 0x001117ED File Offset: 0x0010F9ED
		public global::Org.BouncyCastle.Asn1.X509.Holder Holder
		{
			get
			{
				return this.holder;
			}
		}

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x06003B60 RID: 15200 RVA: 0x001117F5 File Offset: 0x0010F9F5
		public global::Org.BouncyCastle.Asn1.X509.AttCertIssuer Issuer
		{
			get
			{
				return this.issuer;
			}
		}

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x06003B61 RID: 15201 RVA: 0x001117FD File Offset: 0x0010F9FD
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier Signature
		{
			get
			{
				return this.signature;
			}
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x06003B62 RID: 15202 RVA: 0x00111805 File Offset: 0x0010FA05
		public global::Org.BouncyCastle.Asn1.DerInteger SerialNumber
		{
			get
			{
				return this.serialNumber;
			}
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x06003B63 RID: 15203 RVA: 0x0011180D File Offset: 0x0010FA0D
		public global::Org.BouncyCastle.Asn1.X509.AttCertValidityPeriod AttrCertValidityPeriod
		{
			get
			{
				return this.attrCertValidityPeriod;
			}
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x06003B64 RID: 15204 RVA: 0x00111815 File Offset: 0x0010FA15
		public global::Org.BouncyCastle.Asn1.Asn1Sequence Attributes
		{
			get
			{
				return this.attributes;
			}
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x06003B65 RID: 15205 RVA: 0x0011181D File Offset: 0x0010FA1D
		public global::Org.BouncyCastle.Asn1.DerBitString IssuerUniqueID
		{
			get
			{
				return this.issuerUniqueID;
			}
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x06003B66 RID: 15206 RVA: 0x00111825 File Offset: 0x0010FA25
		public global::Org.BouncyCastle.Asn1.X509.X509Extensions Extensions
		{
			get
			{
				return this.extensions;
			}
		}

		// Token: 0x06003B67 RID: 15207 RVA: 0x00111830 File Offset: 0x0010FA30
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(9);
			if (!this.version.HasValue(0))
			{
				v.Add(this.version);
			}
			v.Add(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.holder,
				this.issuer,
				this.signature,
				this.serialNumber,
				this.attrCertValidityPeriod,
				this.attributes
			});
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.issuerUniqueID,
				this.extensions
			});
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001A2D RID: 6701
		internal readonly global::Org.BouncyCastle.Asn1.DerInteger version;

		// Token: 0x04001A2E RID: 6702
		internal readonly global::Org.BouncyCastle.Asn1.X509.Holder holder;

		// Token: 0x04001A2F RID: 6703
		internal readonly global::Org.BouncyCastle.Asn1.X509.AttCertIssuer issuer;

		// Token: 0x04001A30 RID: 6704
		internal readonly global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier signature;

		// Token: 0x04001A31 RID: 6705
		internal readonly global::Org.BouncyCastle.Asn1.DerInteger serialNumber;

		// Token: 0x04001A32 RID: 6706
		internal readonly global::Org.BouncyCastle.Asn1.X509.AttCertValidityPeriod attrCertValidityPeriod;

		// Token: 0x04001A33 RID: 6707
		internal readonly global::Org.BouncyCastle.Asn1.Asn1Sequence attributes;

		// Token: 0x04001A34 RID: 6708
		internal readonly global::Org.BouncyCastle.Asn1.DerBitString issuerUniqueID;

		// Token: 0x04001A35 RID: 6709
		internal readonly global::Org.BouncyCastle.Asn1.X509.X509Extensions extensions;
	}
}
