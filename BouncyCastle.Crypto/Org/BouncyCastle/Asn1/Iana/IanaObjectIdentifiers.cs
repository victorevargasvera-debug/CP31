using System;

namespace Org.BouncyCastle.Asn1.Iana
{
	// Token: 0x020006F6 RID: 1782
	public abstract class IanaObjectIdentifiers
	{
		// Token: 0x0600408B RID: 16523 RVA: 0x00124A3C File Offset: 0x00122C3C
		// Note: this type is marked as 'beforefieldinit'.
		static IanaObjectIdentifiers()
		{
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier isakmpOakley = global::Org.BouncyCastle.Asn1.Iana.IanaObjectIdentifiers.IsakmpOakley;
			global::Org.BouncyCastle.Asn1.Iana.IanaObjectIdentifiers.HmacMD5 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((isakmpOakley != null) ? isakmpOakley.ToString() : null) + ".1");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier isakmpOakley2 = global::Org.BouncyCastle.Asn1.Iana.IanaObjectIdentifiers.IsakmpOakley;
			global::Org.BouncyCastle.Asn1.Iana.IanaObjectIdentifiers.HmacSha1 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((isakmpOakley2 != null) ? isakmpOakley2.ToString() : null) + ".2");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier isakmpOakley3 = global::Org.BouncyCastle.Asn1.Iana.IanaObjectIdentifiers.IsakmpOakley;
			global::Org.BouncyCastle.Asn1.Iana.IanaObjectIdentifiers.HmacTiger = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((isakmpOakley3 != null) ? isakmpOakley3.ToString() : null) + ".3");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier isakmpOakley4 = global::Org.BouncyCastle.Asn1.Iana.IanaObjectIdentifiers.IsakmpOakley;
			global::Org.BouncyCastle.Asn1.Iana.IanaObjectIdentifiers.HmacRipeMD160 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((isakmpOakley4 != null) ? isakmpOakley4.ToString() : null) + ".4");
		}

		// Token: 0x04001E9E RID: 7838
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IsakmpOakley = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.3.6.1.5.5.8.1");

		// Token: 0x04001E9F RID: 7839
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier HmacMD5;

		// Token: 0x04001EA0 RID: 7840
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier HmacSha1;

		// Token: 0x04001EA1 RID: 7841
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier HmacTiger;

		// Token: 0x04001EA2 RID: 7842
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier HmacRipeMD160;
	}
}
