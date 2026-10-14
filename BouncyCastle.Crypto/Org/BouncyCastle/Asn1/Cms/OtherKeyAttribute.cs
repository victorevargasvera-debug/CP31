using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cms
{
	// Token: 0x02000758 RID: 1880
	public class OtherKeyAttribute : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06004335 RID: 17205 RVA: 0x0012D740 File Offset: 0x0012B940
		public static global::Org.BouncyCastle.Asn1.Cms.OtherKeyAttribute GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Cms.OtherKeyAttribute)
			{
				return (global::Org.BouncyCastle.Asn1.Cms.OtherKeyAttribute)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cms.OtherKeyAttribute((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06004336 RID: 17206 RVA: 0x0012D78D File Offset: 0x0012B98D
		public OtherKeyAttribute(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.keyAttrId = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)seq[0];
			this.keyAttr = seq[1];
		}

		// Token: 0x06004337 RID: 17207 RVA: 0x0012D7B4 File Offset: 0x0012B9B4
		public OtherKeyAttribute(global::Org.BouncyCastle.Asn1.DerObjectIdentifier keyAttrId, global::Org.BouncyCastle.Asn1.Asn1Encodable keyAttr)
		{
			this.keyAttrId = keyAttrId;
			this.keyAttr = keyAttr;
		}

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x06004338 RID: 17208 RVA: 0x0012D7CA File Offset: 0x0012B9CA
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier KeyAttrId
		{
			get
			{
				return this.keyAttrId;
			}
		}

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x06004339 RID: 17209 RVA: 0x0012D7D2 File Offset: 0x0012B9D2
		public global::Org.BouncyCastle.Asn1.Asn1Encodable KeyAttr
		{
			get
			{
				return this.keyAttr;
			}
		}

		// Token: 0x0600433A RID: 17210 RVA: 0x0012D7DA File Offset: 0x0012B9DA
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.keyAttrId,
				this.keyAttr
			});
		}

		// Token: 0x0400205B RID: 8283
		private global::Org.BouncyCastle.Asn1.DerObjectIdentifier keyAttrId;

		// Token: 0x0400205C RID: 8284
		private global::Org.BouncyCastle.Asn1.Asn1Encodable keyAttr;
	}
}
