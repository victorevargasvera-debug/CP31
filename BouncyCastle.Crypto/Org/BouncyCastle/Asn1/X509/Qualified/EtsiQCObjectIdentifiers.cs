using System;

namespace Org.BouncyCastle.Asn1.X509.Qualified
{
	// Token: 0x02000688 RID: 1672
	public abstract class EtsiQCObjectIdentifiers
	{
		// Token: 0x06003DB2 RID: 15794 RVA: 0x001198F0 File Offset: 0x00117AF0
		// Note: this type is marked as 'beforefieldinit'.
		static EtsiQCObjectIdentifiers()
		{
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idEtsiQcs = global::Org.BouncyCastle.Asn1.X509.Qualified.EtsiQCObjectIdentifiers.IdEtsiQcs;
			global::Org.BouncyCastle.Asn1.X509.Qualified.EtsiQCObjectIdentifiers.IdEtsiQcsQcCompliance = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idEtsiQcs != null) ? idEtsiQcs.ToString() : null) + ".1");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idEtsiQcs2 = global::Org.BouncyCastle.Asn1.X509.Qualified.EtsiQCObjectIdentifiers.IdEtsiQcs;
			global::Org.BouncyCastle.Asn1.X509.Qualified.EtsiQCObjectIdentifiers.IdEtsiQcsLimitValue = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idEtsiQcs2 != null) ? idEtsiQcs2.ToString() : null) + ".2");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idEtsiQcs3 = global::Org.BouncyCastle.Asn1.X509.Qualified.EtsiQCObjectIdentifiers.IdEtsiQcs;
			global::Org.BouncyCastle.Asn1.X509.Qualified.EtsiQCObjectIdentifiers.IdEtsiQcsRetentionPeriod = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idEtsiQcs3 != null) ? idEtsiQcs3.ToString() : null) + ".3");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idEtsiQcs4 = global::Org.BouncyCastle.Asn1.X509.Qualified.EtsiQCObjectIdentifiers.IdEtsiQcs;
			global::Org.BouncyCastle.Asn1.X509.Qualified.EtsiQCObjectIdentifiers.IdEtsiQcsQcSscd = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idEtsiQcs4 != null) ? idEtsiQcs4.ToString() : null) + ".4");
		}

		// Token: 0x04001B91 RID: 7057
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdEtsiQcs = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("0.4.0.1862.1");

		// Token: 0x04001B92 RID: 7058
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdEtsiQcsQcCompliance;

		// Token: 0x04001B93 RID: 7059
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdEtsiQcsLimitValue;

		// Token: 0x04001B94 RID: 7060
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdEtsiQcsRetentionPeriod;

		// Token: 0x04001B95 RID: 7061
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdEtsiQcsQcSscd;
	}
}
