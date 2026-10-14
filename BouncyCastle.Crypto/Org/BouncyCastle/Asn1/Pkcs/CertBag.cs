using System;

namespace Org.BouncyCastle.Asn1.Pkcs
{
	// Token: 0x020006AA RID: 1706
	public class CertBag : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003E8D RID: 16013 RVA: 0x0011D714 File Offset: 0x0011B914
		public static global::Org.BouncyCastle.Asn1.Pkcs.CertBag GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Pkcs.CertBag)
			{
				return (global::Org.BouncyCastle.Asn1.Pkcs.CertBag)obj;
			}
			if (obj == null)
			{
				return null;
			}
			return new global::Org.BouncyCastle.Asn1.Pkcs.CertBag(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
		}

		// Token: 0x06003E8E RID: 16014 RVA: 0x0011D738 File Offset: 0x0011B938
		private CertBag(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count != 2)
			{
				throw new global::System.ArgumentException("Wrong number of elements in sequence", "seq");
			}
			this.certID = global::Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(seq[0]);
			this.certValue = global::Org.BouncyCastle.Asn1.Asn1TaggedObject.GetInstance(seq[1]).GetObject();
		}

		// Token: 0x06003E8F RID: 16015 RVA: 0x0011D78D File Offset: 0x0011B98D
		public CertBag(global::Org.BouncyCastle.Asn1.DerObjectIdentifier certID, global::Org.BouncyCastle.Asn1.Asn1Object certValue)
		{
			this.certID = certID;
			this.certValue = certValue;
		}

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x06003E90 RID: 16016 RVA: 0x0011D7A3 File Offset: 0x0011B9A3
		public virtual global::Org.BouncyCastle.Asn1.DerObjectIdentifier CertID
		{
			get
			{
				return this.certID;
			}
		}

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x06003E91 RID: 16017 RVA: 0x0011D7AB File Offset: 0x0011B9AB
		public virtual global::Org.BouncyCastle.Asn1.Asn1Object CertValue
		{
			get
			{
				return this.certValue;
			}
		}

		// Token: 0x06003E92 RID: 16018 RVA: 0x0011D7B3 File Offset: 0x0011B9B3
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.certID,
				new global::Org.BouncyCastle.Asn1.DerTaggedObject(0, this.certValue)
			});
		}

		// Token: 0x04001C65 RID: 7269
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier certID;

		// Token: 0x04001C66 RID: 7270
		private readonly global::Org.BouncyCastle.Asn1.Asn1Object certValue;
	}
}
