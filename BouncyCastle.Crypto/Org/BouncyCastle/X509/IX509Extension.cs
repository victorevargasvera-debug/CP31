using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Utilities.Collections;

namespace Org.BouncyCastle.X509
{
	// Token: 0x0200000D RID: 13
	public interface IX509Extension
	{
		// Token: 0x0600009D RID: 157
		global::Org.BouncyCastle.Utilities.Collections.ISet GetCriticalExtensionOids();

		// Token: 0x0600009E RID: 158
		global::Org.BouncyCastle.Utilities.Collections.ISet GetNonCriticalExtensionOids();

		// Token: 0x0600009F RID: 159
		[global::System.Obsolete("Use version taking a DerObjectIdentifier instead")]
		global::Org.BouncyCastle.Asn1.Asn1OctetString GetExtensionValue(string oid);

		// Token: 0x060000A0 RID: 160
		global::Org.BouncyCastle.Asn1.Asn1OctetString GetExtensionValue(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid);
	}
}
