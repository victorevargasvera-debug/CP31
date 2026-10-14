using System;

namespace Org.BouncyCastle.Asn1.X509.Qualified
{
	// Token: 0x0200068C RID: 1676
	public sealed class Rfc3739QCObjectIdentifiers
	{
		// Token: 0x06003DC8 RID: 15816 RVA: 0x00119D29 File Offset: 0x00117F29
		private Rfc3739QCObjectIdentifiers()
		{
		}

		// Token: 0x06003DC9 RID: 15817 RVA: 0x00119D34 File Offset: 0x00117F34
		// Note: this type is marked as 'beforefieldinit'.
		static Rfc3739QCObjectIdentifiers()
		{
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idQcs = global::Org.BouncyCastle.Asn1.X509.Qualified.Rfc3739QCObjectIdentifiers.IdQcs;
			global::Org.BouncyCastle.Asn1.X509.Qualified.Rfc3739QCObjectIdentifiers.IdQcsPkixQCSyntaxV1 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idQcs != null) ? idQcs.ToString() : null) + ".1");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idQcs2 = global::Org.BouncyCastle.Asn1.X509.Qualified.Rfc3739QCObjectIdentifiers.IdQcs;
			global::Org.BouncyCastle.Asn1.X509.Qualified.Rfc3739QCObjectIdentifiers.IdQcsPkixQCSyntaxV2 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idQcs2 != null) ? idQcs2.ToString() : null) + ".2");
		}

		// Token: 0x04001B9F RID: 7071
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdQcs = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.3.6.1.5.5.7.11");

		// Token: 0x04001BA0 RID: 7072
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdQcsPkixQCSyntaxV1;

		// Token: 0x04001BA1 RID: 7073
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdQcsPkixQCSyntaxV2;
	}
}
