using System;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000661 RID: 1633
	public class OtherName : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003C60 RID: 15456 RVA: 0x00114937 File Offset: 0x00112B37
		public static global::Org.BouncyCastle.Asn1.X509.OtherName GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.X509.OtherName)
			{
				return (global::Org.BouncyCastle.Asn1.X509.OtherName)obj;
			}
			if (obj == null)
			{
				return null;
			}
			return new global::Org.BouncyCastle.Asn1.X509.OtherName(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
		}

		// Token: 0x06003C61 RID: 15457 RVA: 0x00114958 File Offset: 0x00112B58
		public OtherName(global::Org.BouncyCastle.Asn1.DerObjectIdentifier typeID, global::Org.BouncyCastle.Asn1.Asn1Encodable value)
		{
			this.typeID = typeID;
			this.value = value;
		}

		// Token: 0x06003C62 RID: 15458 RVA: 0x0011496E File Offset: 0x00112B6E
		private OtherName(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.typeID = global::Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(seq[0]);
			this.value = global::Org.BouncyCastle.Asn1.Asn1TaggedObject.GetInstance(seq[1]).GetObject();
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x06003C63 RID: 15459 RVA: 0x0011499F File Offset: 0x00112B9F
		public virtual global::Org.BouncyCastle.Asn1.DerObjectIdentifier TypeID
		{
			get
			{
				return this.typeID;
			}
		}

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x06003C64 RID: 15460 RVA: 0x001149A7 File Offset: 0x00112BA7
		public global::Org.BouncyCastle.Asn1.Asn1Encodable Value
		{
			get
			{
				return this.value;
			}
		}

		// Token: 0x06003C65 RID: 15461 RVA: 0x001149AF File Offset: 0x00112BAF
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.typeID,
				new global::Org.BouncyCastle.Asn1.DerTaggedObject(true, 0, this.value)
			});
		}

		// Token: 0x04001AA8 RID: 6824
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier typeID;

		// Token: 0x04001AA9 RID: 6825
		private readonly global::Org.BouncyCastle.Asn1.Asn1Encodable value;
	}
}
