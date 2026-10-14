using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Ess
{
	// Token: 0x020006FB RID: 1787
	public class ContentIdentifier : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060040A2 RID: 16546 RVA: 0x001253FC File Offset: 0x001235FC
		public static global::Org.BouncyCastle.Asn1.Ess.ContentIdentifier GetInstance(object o)
		{
			if (o == null || o is global::Org.BouncyCastle.Asn1.Ess.ContentIdentifier)
			{
				return (global::Org.BouncyCastle.Asn1.Ess.ContentIdentifier)o;
			}
			if (o is global::Org.BouncyCastle.Asn1.Asn1OctetString)
			{
				return new global::Org.BouncyCastle.Asn1.Ess.ContentIdentifier((global::Org.BouncyCastle.Asn1.Asn1OctetString)o);
			}
			throw new global::System.ArgumentException("unknown object in 'ContentIdentifier' factory : " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(o) + ".");
		}

		// Token: 0x060040A3 RID: 16547 RVA: 0x00125449 File Offset: 0x00123649
		public ContentIdentifier(global::Org.BouncyCastle.Asn1.Asn1OctetString value)
		{
			this.value = value;
		}

		// Token: 0x060040A4 RID: 16548 RVA: 0x00125458 File Offset: 0x00123658
		public ContentIdentifier(byte[] value) : this(new global::Org.BouncyCastle.Asn1.DerOctetString(value))
		{
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x060040A5 RID: 16549 RVA: 0x00125466 File Offset: 0x00123666
		public global::Org.BouncyCastle.Asn1.Asn1OctetString Value
		{
			get
			{
				return this.value;
			}
		}

		// Token: 0x060040A6 RID: 16550 RVA: 0x0012546E File Offset: 0x0012366E
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return this.value;
		}

		// Token: 0x04001F02 RID: 7938
		private global::Org.BouncyCastle.Asn1.Asn1OctetString value;
	}
}
