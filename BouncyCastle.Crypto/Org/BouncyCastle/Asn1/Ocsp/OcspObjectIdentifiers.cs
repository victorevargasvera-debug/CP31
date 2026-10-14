using System;

namespace Org.BouncyCastle.Asn1.Ocsp
{
	// Token: 0x020006C9 RID: 1737
	public abstract class OcspObjectIdentifiers
	{
		// Token: 0x06003F7C RID: 16252 RVA: 0x00120618 File Offset: 0x0011E818
		// Note: this type is marked as 'beforefieldinit'.
		static OcspObjectIdentifiers()
		{
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier pkixOcsp = global::Org.BouncyCastle.Asn1.Ocsp.OcspObjectIdentifiers.PkixOcsp;
			global::Org.BouncyCastle.Asn1.Ocsp.OcspObjectIdentifiers.PkixOcspNonce = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((pkixOcsp != null) ? pkixOcsp.ToString() : null) + ".2");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier pkixOcsp2 = global::Org.BouncyCastle.Asn1.Ocsp.OcspObjectIdentifiers.PkixOcsp;
			global::Org.BouncyCastle.Asn1.Ocsp.OcspObjectIdentifiers.PkixOcspCrl = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((pkixOcsp2 != null) ? pkixOcsp2.ToString() : null) + ".3");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier pkixOcsp3 = global::Org.BouncyCastle.Asn1.Ocsp.OcspObjectIdentifiers.PkixOcsp;
			global::Org.BouncyCastle.Asn1.Ocsp.OcspObjectIdentifiers.PkixOcspResponse = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((pkixOcsp3 != null) ? pkixOcsp3.ToString() : null) + ".4");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier pkixOcsp4 = global::Org.BouncyCastle.Asn1.Ocsp.OcspObjectIdentifiers.PkixOcsp;
			global::Org.BouncyCastle.Asn1.Ocsp.OcspObjectIdentifiers.PkixOcspNocheck = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((pkixOcsp4 != null) ? pkixOcsp4.ToString() : null) + ".5");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier pkixOcsp5 = global::Org.BouncyCastle.Asn1.Ocsp.OcspObjectIdentifiers.PkixOcsp;
			global::Org.BouncyCastle.Asn1.Ocsp.OcspObjectIdentifiers.PkixOcspArchiveCutoff = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((pkixOcsp5 != null) ? pkixOcsp5.ToString() : null) + ".6");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier pkixOcsp6 = global::Org.BouncyCastle.Asn1.Ocsp.OcspObjectIdentifiers.PkixOcsp;
			global::Org.BouncyCastle.Asn1.Ocsp.OcspObjectIdentifiers.PkixOcspServiceLocator = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((pkixOcsp6 != null) ? pkixOcsp6.ToString() : null) + ".7");
		}

		// Token: 0x04001D62 RID: 7522
		internal const string PkixOcspId = "1.3.6.1.5.5.7.48.1";

		// Token: 0x04001D63 RID: 7523
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier PkixOcsp = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.3.6.1.5.5.7.48.1");

		// Token: 0x04001D64 RID: 7524
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier PkixOcspBasic = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.3.6.1.5.5.7.48.1.1");

		// Token: 0x04001D65 RID: 7525
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier PkixOcspNonce;

		// Token: 0x04001D66 RID: 7526
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier PkixOcspCrl;

		// Token: 0x04001D67 RID: 7527
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier PkixOcspResponse;

		// Token: 0x04001D68 RID: 7528
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier PkixOcspNocheck;

		// Token: 0x04001D69 RID: 7529
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier PkixOcspArchiveCutoff;

		// Token: 0x04001D6A RID: 7530
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier PkixOcspServiceLocator;
	}
}
