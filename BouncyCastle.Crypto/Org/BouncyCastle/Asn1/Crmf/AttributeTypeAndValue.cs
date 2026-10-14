using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Crmf
{
	// Token: 0x02000725 RID: 1829
	public class AttributeTypeAndValue : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060041B6 RID: 16822 RVA: 0x00129866 File Offset: 0x00127A66
		private AttributeTypeAndValue(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.type = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)seq[0];
			this.value = seq[1];
		}

		// Token: 0x060041B7 RID: 16823 RVA: 0x0012988D File Offset: 0x00127A8D
		public static global::Org.BouncyCastle.Asn1.Crmf.AttributeTypeAndValue GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Crmf.AttributeTypeAndValue)
			{
				return (global::Org.BouncyCastle.Asn1.Crmf.AttributeTypeAndValue)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Crmf.AttributeTypeAndValue((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid object: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x060041B8 RID: 16824 RVA: 0x001298CC File Offset: 0x00127ACC
		public AttributeTypeAndValue(string oid, global::Org.BouncyCastle.Asn1.Asn1Encodable value) : this(new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(oid), value)
		{
		}

		// Token: 0x060041B9 RID: 16825 RVA: 0x001298DB File Offset: 0x00127ADB
		public AttributeTypeAndValue(global::Org.BouncyCastle.Asn1.DerObjectIdentifier type, global::Org.BouncyCastle.Asn1.Asn1Encodable value)
		{
			this.type = type;
			this.value = value;
		}

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x060041BA RID: 16826 RVA: 0x001298F1 File Offset: 0x00127AF1
		public virtual global::Org.BouncyCastle.Asn1.DerObjectIdentifier Type
		{
			get
			{
				return this.type;
			}
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x060041BB RID: 16827 RVA: 0x001298F9 File Offset: 0x00127AF9
		public virtual global::Org.BouncyCastle.Asn1.Asn1Encodable Value
		{
			get
			{
				return this.value;
			}
		}

		// Token: 0x060041BC RID: 16828 RVA: 0x00129901 File Offset: 0x00127B01
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.type,
				this.value
			});
		}

		// Token: 0x04001F9D RID: 8093
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier type;

		// Token: 0x04001F9E RID: 8094
		private readonly global::Org.BouncyCastle.Asn1.Asn1Encodable value;
	}
}
