using System;

namespace Org.BouncyCastle.Asn1.X500
{
	// Token: 0x0200068F RID: 1679
	public class AttributeTypeAndValue : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003DD9 RID: 15833 RVA: 0x0011A003 File Offset: 0x00118203
		private AttributeTypeAndValue(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.type = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)seq[0];
			this.value = seq[1];
		}

		// Token: 0x06003DDA RID: 15834 RVA: 0x0011A02A File Offset: 0x0011822A
		public static global::Org.BouncyCastle.Asn1.X500.AttributeTypeAndValue GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.X500.AttributeTypeAndValue)
			{
				return (global::Org.BouncyCastle.Asn1.X500.AttributeTypeAndValue)obj;
			}
			if (obj != null)
			{
				return new global::Org.BouncyCastle.Asn1.X500.AttributeTypeAndValue(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
			}
			throw new global::System.ArgumentNullException("obj");
		}

		// Token: 0x06003DDB RID: 15835 RVA: 0x0011A054 File Offset: 0x00118254
		public AttributeTypeAndValue(global::Org.BouncyCastle.Asn1.DerObjectIdentifier type, global::Org.BouncyCastle.Asn1.Asn1Encodable value)
		{
			this.type = type;
			this.value = value;
		}

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x06003DDC RID: 15836 RVA: 0x0011A06A File Offset: 0x0011826A
		public virtual global::Org.BouncyCastle.Asn1.DerObjectIdentifier Type
		{
			get
			{
				return this.type;
			}
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x06003DDD RID: 15837 RVA: 0x0011A072 File Offset: 0x00118272
		public virtual global::Org.BouncyCastle.Asn1.Asn1Encodable Value
		{
			get
			{
				return this.value;
			}
		}

		// Token: 0x06003DDE RID: 15838 RVA: 0x0011A07A File Offset: 0x0011827A
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.type,
				this.value
			});
		}

		// Token: 0x04001BA7 RID: 7079
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier type;

		// Token: 0x04001BA8 RID: 7080
		private readonly global::Org.BouncyCastle.Asn1.Asn1Encodable value;
	}
}
