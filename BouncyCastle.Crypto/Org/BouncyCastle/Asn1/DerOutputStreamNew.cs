using System;
using System.IO;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x02000613 RID: 1555
	internal class DerOutputStreamNew : global::Org.BouncyCastle.Asn1.Asn1OutputStream
	{
		// Token: 0x06003A20 RID: 14880 RVA: 0x0010E3C5 File Offset: 0x0010C5C5
		internal DerOutputStreamNew(global::System.IO.Stream os) : base(os)
		{
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06003A21 RID: 14881 RVA: 0x0010E3CE File Offset: 0x0010C5CE
		internal override bool IsBer
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06003A22 RID: 14882 RVA: 0x0010E3D4 File Offset: 0x0010C5D4
		internal override void WritePrimitive(global::Org.BouncyCastle.Asn1.Asn1Object primitive, bool withID)
		{
			global::Org.BouncyCastle.Asn1.Asn1Set asn1Set = primitive as global::Org.BouncyCastle.Asn1.Asn1Set;
			if (asn1Set != null)
			{
				primitive = new global::Org.BouncyCastle.Asn1.DerSet(asn1Set.elements);
			}
			primitive.Encode(this, withID);
		}
	}
}
