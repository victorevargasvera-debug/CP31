using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Pkcs
{
	// Token: 0x020006A8 RID: 1704
	public class AttributePkcs : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003E81 RID: 16001 RVA: 0x0011D554 File Offset: 0x0011B754
		public static global::Org.BouncyCastle.Asn1.Pkcs.AttributePkcs GetInstance(object obj)
		{
			global::Org.BouncyCastle.Asn1.Pkcs.AttributePkcs attr = obj as global::Org.BouncyCastle.Asn1.Pkcs.AttributePkcs;
			if (obj == null || attr != null)
			{
				return attr;
			}
			global::Org.BouncyCastle.Asn1.Asn1Sequence seq = obj as global::Org.BouncyCastle.Asn1.Asn1Sequence;
			if (seq != null)
			{
				return new global::Org.BouncyCastle.Asn1.Pkcs.AttributePkcs(seq);
			}
			throw new global::System.ArgumentException("Unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003E82 RID: 16002 RVA: 0x0011D59C File Offset: 0x0011B79C
		private AttributePkcs(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count != 2)
			{
				throw new global::System.ArgumentException("Wrong number of elements in sequence", "seq");
			}
			this.attrType = global::Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(seq[0]);
			this.attrValues = global::Org.BouncyCastle.Asn1.Asn1Set.GetInstance(seq[1]);
		}

		// Token: 0x06003E83 RID: 16003 RVA: 0x0011D5EC File Offset: 0x0011B7EC
		public AttributePkcs(global::Org.BouncyCastle.Asn1.DerObjectIdentifier attrType, global::Org.BouncyCastle.Asn1.Asn1Set attrValues)
		{
			this.attrType = attrType;
			this.attrValues = attrValues;
		}

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x06003E84 RID: 16004 RVA: 0x0011D602 File Offset: 0x0011B802
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier AttrType
		{
			get
			{
				return this.attrType;
			}
		}

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x06003E85 RID: 16005 RVA: 0x0011D60A File Offset: 0x0011B80A
		public global::Org.BouncyCastle.Asn1.Asn1Set AttrValues
		{
			get
			{
				return this.attrValues;
			}
		}

		// Token: 0x06003E86 RID: 16006 RVA: 0x0011D612 File Offset: 0x0011B812
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.attrType,
				this.attrValues
			});
		}

		// Token: 0x04001C61 RID: 7265
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier attrType;

		// Token: 0x04001C62 RID: 7266
		private readonly global::Org.BouncyCastle.Asn1.Asn1Set attrValues;
	}
}
