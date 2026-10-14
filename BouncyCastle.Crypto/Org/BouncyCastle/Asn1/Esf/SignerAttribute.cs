using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Esf
{
	// Token: 0x02000719 RID: 1817
	public class SignerAttribute : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06004168 RID: 16744 RVA: 0x001281E2 File Offset: 0x001263E2
		public static global::Org.BouncyCastle.Asn1.Esf.SignerAttribute GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Esf.SignerAttribute)
			{
				return (global::Org.BouncyCastle.Asn1.Esf.SignerAttribute)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Esf.SignerAttribute(obj);
			}
			throw new global::System.ArgumentException("Unknown object in 'SignerAttribute' factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06004169 RID: 16745 RVA: 0x00128220 File Offset: 0x00126420
		private SignerAttribute(object obj)
		{
			global::Org.BouncyCastle.Asn1.DerTaggedObject taggedObject = (global::Org.BouncyCastle.Asn1.DerTaggedObject)((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj)[0];
			if (taggedObject.TagNo == 0)
			{
				this.claimedAttributes = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(taggedObject, true);
				return;
			}
			if (taggedObject.TagNo == 1)
			{
				this.certifiedAttributes = global::Org.BouncyCastle.Asn1.X509.AttributeCertificate.GetInstance(taggedObject);
				return;
			}
			throw new global::System.ArgumentException("illegal tag.", "obj");
		}

		// Token: 0x0600416A RID: 16746 RVA: 0x00128280 File Offset: 0x00126480
		public SignerAttribute(global::Org.BouncyCastle.Asn1.Asn1Sequence claimedAttributes)
		{
			this.claimedAttributes = claimedAttributes;
		}

		// Token: 0x0600416B RID: 16747 RVA: 0x0012828F File Offset: 0x0012648F
		public SignerAttribute(global::Org.BouncyCastle.Asn1.X509.AttributeCertificate certifiedAttributes)
		{
			this.certifiedAttributes = certifiedAttributes;
		}

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x0600416C RID: 16748 RVA: 0x0012829E File Offset: 0x0012649E
		public virtual global::Org.BouncyCastle.Asn1.Asn1Sequence ClaimedAttributes
		{
			get
			{
				return this.claimedAttributes;
			}
		}

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x0600416D RID: 16749 RVA: 0x001282A6 File Offset: 0x001264A6
		public virtual global::Org.BouncyCastle.Asn1.X509.AttributeCertificate CertifiedAttributes
		{
			get
			{
				return this.certifiedAttributes;
			}
		}

		// Token: 0x0600416E RID: 16750 RVA: 0x001282B0 File Offset: 0x001264B0
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			if (this.claimedAttributes != null)
			{
				v.Add(new global::Org.BouncyCastle.Asn1.DerTaggedObject(0, this.claimedAttributes));
			}
			else
			{
				v.Add(new global::Org.BouncyCastle.Asn1.DerTaggedObject(1, this.certifiedAttributes));
			}
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001F4D RID: 8013
		private global::Org.BouncyCastle.Asn1.Asn1Sequence claimedAttributes;

		// Token: 0x04001F4E RID: 8014
		private global::Org.BouncyCastle.Asn1.X509.AttributeCertificate certifiedAttributes;
	}
}
