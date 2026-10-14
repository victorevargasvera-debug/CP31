using System;

namespace Org.BouncyCastle.Asn1.Cms
{
	// Token: 0x0200073C RID: 1852
	public class Attributes : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06004259 RID: 16985 RVA: 0x0012AFDA File Offset: 0x001291DA
		private Attributes(global::Org.BouncyCastle.Asn1.Asn1Set attributes)
		{
			this.attributes = attributes;
		}

		// Token: 0x0600425A RID: 16986 RVA: 0x0012AFE9 File Offset: 0x001291E9
		public Attributes(global::Org.BouncyCastle.Asn1.Asn1EncodableVector v)
		{
			this.attributes = new global::Org.BouncyCastle.Asn1.BerSet(v);
		}

		// Token: 0x0600425B RID: 16987 RVA: 0x0012AFFD File Offset: 0x001291FD
		public static global::Org.BouncyCastle.Asn1.Cms.Attributes GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Cms.Attributes)
			{
				return (global::Org.BouncyCastle.Asn1.Cms.Attributes)obj;
			}
			if (obj != null)
			{
				return new global::Org.BouncyCastle.Asn1.Cms.Attributes(global::Org.BouncyCastle.Asn1.Asn1Set.GetInstance(obj));
			}
			return null;
		}

		// Token: 0x0600425C RID: 16988 RVA: 0x0012B020 File Offset: 0x00129220
		public virtual global::Org.BouncyCastle.Asn1.Cms.Attribute[] GetAttributes()
		{
			global::Org.BouncyCastle.Asn1.Cms.Attribute[] rv = new global::Org.BouncyCastle.Asn1.Cms.Attribute[this.attributes.Count];
			for (int i = 0; i != rv.Length; i++)
			{
				rv[i] = global::Org.BouncyCastle.Asn1.Cms.Attribute.GetInstance(this.attributes[i]);
			}
			return rv;
		}

		// Token: 0x0600425D RID: 16989 RVA: 0x0012B061 File Offset: 0x00129261
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return this.attributes;
		}

		// Token: 0x04001FF3 RID: 8179
		private readonly global::Org.BouncyCastle.Asn1.Asn1Set attributes;
	}
}
