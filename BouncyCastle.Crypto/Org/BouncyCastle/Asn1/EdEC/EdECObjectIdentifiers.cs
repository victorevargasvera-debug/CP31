using System;

namespace Org.BouncyCastle.Asn1.EdEC
{
	// Token: 0x0200071C RID: 1820
	public abstract class EdECObjectIdentifiers
	{
		// Token: 0x04001F54 RID: 8020
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_edwards_curve_algs = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.3.101");

		// Token: 0x04001F55 RID: 8021
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_X25519 = global::Org.BouncyCastle.Asn1.EdEC.EdECObjectIdentifiers.id_edwards_curve_algs.Branch("110");

		// Token: 0x04001F56 RID: 8022
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_X448 = global::Org.BouncyCastle.Asn1.EdEC.EdECObjectIdentifiers.id_edwards_curve_algs.Branch("111");

		// Token: 0x04001F57 RID: 8023
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_Ed25519 = global::Org.BouncyCastle.Asn1.EdEC.EdECObjectIdentifiers.id_edwards_curve_algs.Branch("112");

		// Token: 0x04001F58 RID: 8024
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_Ed448 = global::Org.BouncyCastle.Asn1.EdEC.EdECObjectIdentifiers.id_edwards_curve_algs.Branch("113");
	}
}
