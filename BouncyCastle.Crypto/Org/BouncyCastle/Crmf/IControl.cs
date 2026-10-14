using System;
using Org.BouncyCastle.Asn1;

namespace Org.BouncyCastle.Crmf
{
	// Token: 0x0200050D RID: 1293
	public interface IControl
	{
		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x06003293 RID: 12947
		global::Org.BouncyCastle.Asn1.DerObjectIdentifier Type { get; }

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x06003294 RID: 12948
		global::Org.BouncyCastle.Asn1.Asn1Encodable Value { get; }
	}
}
