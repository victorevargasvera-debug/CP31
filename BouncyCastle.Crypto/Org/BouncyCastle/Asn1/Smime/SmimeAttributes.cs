using System;
using Org.BouncyCastle.Asn1.Pkcs;

namespace Org.BouncyCastle.Asn1.Smime
{
	// Token: 0x0200069E RID: 1694
	public abstract class SmimeAttributes
	{
		// Token: 0x04001C10 RID: 7184
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SmimeCapabilities = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs9AtSmimeCapabilities;

		// Token: 0x04001C11 RID: 7185
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier EncrypKeyPref = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAAEncrypKeyPref;
	}
}
