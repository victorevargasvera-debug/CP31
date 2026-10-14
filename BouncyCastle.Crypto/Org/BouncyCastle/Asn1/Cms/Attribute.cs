using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cms
{
	// Token: 0x0200073B RID: 1851
	public class Attribute : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06004253 RID: 16979 RVA: 0x0012AF1C File Offset: 0x0012911C
		public static global::Org.BouncyCastle.Asn1.Cms.Attribute GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Cms.Attribute)
			{
				return (global::Org.BouncyCastle.Asn1.Cms.Attribute)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cms.Attribute((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06004254 RID: 16980 RVA: 0x0012AF69 File Offset: 0x00129169
		public Attribute(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.attrType = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)seq[0];
			this.attrValues = (global::Org.BouncyCastle.Asn1.Asn1Set)seq[1];
		}

		// Token: 0x06004255 RID: 16981 RVA: 0x0012AF95 File Offset: 0x00129195
		public Attribute(global::Org.BouncyCastle.Asn1.DerObjectIdentifier attrType, global::Org.BouncyCastle.Asn1.Asn1Set attrValues)
		{
			this.attrType = attrType;
			this.attrValues = attrValues;
		}

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x06004256 RID: 16982 RVA: 0x0012AFAB File Offset: 0x001291AB
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier AttrType
		{
			get
			{
				return this.attrType;
			}
		}

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x06004257 RID: 16983 RVA: 0x0012AFB3 File Offset: 0x001291B3
		public global::Org.BouncyCastle.Asn1.Asn1Set AttrValues
		{
			get
			{
				return this.attrValues;
			}
		}

		// Token: 0x06004258 RID: 16984 RVA: 0x0012AFBB File Offset: 0x001291BB
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.attrType,
				this.attrValues
			});
		}

		// Token: 0x04001FF1 RID: 8177
		private global::Org.BouncyCastle.Asn1.DerObjectIdentifier attrType;

		// Token: 0x04001FF2 RID: 8178
		private global::Org.BouncyCastle.Asn1.Asn1Set attrValues;
	}
}
