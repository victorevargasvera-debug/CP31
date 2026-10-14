using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000641 RID: 1601
	public class AttributeX509 : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003B4C RID: 15180 RVA: 0x00111454 File Offset: 0x0010F654
		public static global::Org.BouncyCastle.Asn1.X509.AttributeX509 GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.X509.AttributeX509)
			{
				return (global::Org.BouncyCastle.Asn1.X509.AttributeX509)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.X509.AttributeX509((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003B4D RID: 15181 RVA: 0x001114A4 File Offset: 0x0010F6A4
		private AttributeX509(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count != 2)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString());
			}
			this.attrType = global::Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(seq[0]);
			this.attrValues = global::Org.BouncyCastle.Asn1.Asn1Set.GetInstance(seq[1]);
		}

		// Token: 0x06003B4E RID: 15182 RVA: 0x00111502 File Offset: 0x0010F702
		public AttributeX509(global::Org.BouncyCastle.Asn1.DerObjectIdentifier attrType, global::Org.BouncyCastle.Asn1.Asn1Set attrValues)
		{
			this.attrType = attrType;
			this.attrValues = attrValues;
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x06003B4F RID: 15183 RVA: 0x00111518 File Offset: 0x0010F718
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier AttrType
		{
			get
			{
				return this.attrType;
			}
		}

		// Token: 0x06003B50 RID: 15184 RVA: 0x00111520 File Offset: 0x0010F720
		public global::Org.BouncyCastle.Asn1.Asn1Encodable[] GetAttributeValues()
		{
			return this.attrValues.ToArray();
		}

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x06003B51 RID: 15185 RVA: 0x0011152D File Offset: 0x0010F72D
		public global::Org.BouncyCastle.Asn1.Asn1Set AttrValues
		{
			get
			{
				return this.attrValues;
			}
		}

		// Token: 0x06003B52 RID: 15186 RVA: 0x00111535 File Offset: 0x0010F735
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.attrType,
				this.attrValues
			});
		}

		// Token: 0x04001A28 RID: 6696
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier attrType;

		// Token: 0x04001A29 RID: 6697
		private readonly global::Org.BouncyCastle.Asn1.Asn1Set attrValues;
	}
}
