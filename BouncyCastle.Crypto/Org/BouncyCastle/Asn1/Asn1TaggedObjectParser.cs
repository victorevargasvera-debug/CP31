using System;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020005EB RID: 1515
	public interface Asn1TaggedObjectParser : global::Org.BouncyCastle.Asn1.IAsn1Convertible
	{
		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x060038CC RID: 14540
		int TagNo { get; }

		// Token: 0x060038CD RID: 14541
		global::Org.BouncyCastle.Asn1.IAsn1Convertible GetObjectParser(int tag, bool isExplicit);
	}
}
