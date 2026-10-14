using System;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000683 RID: 1667
	public abstract class X509ObjectIdentifiers
	{
		// Token: 0x06003D92 RID: 15762 RVA: 0x001190C4 File Offset: 0x001172C4
		// Note: this type is marked as 'beforefieldinit'.
		static X509ObjectIdentifiers()
		{
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idPkix = global::Org.BouncyCastle.Asn1.X509.X509ObjectIdentifiers.IdPkix;
			global::Org.BouncyCastle.Asn1.X509.X509ObjectIdentifiers.IdPE = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idPkix != null) ? idPkix.ToString() : null) + ".1");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idPkix2 = global::Org.BouncyCastle.Asn1.X509.X509ObjectIdentifiers.IdPkix;
			global::Org.BouncyCastle.Asn1.X509.X509ObjectIdentifiers.IdAD = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idPkix2 != null) ? idPkix2.ToString() : null) + ".48");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idAD = global::Org.BouncyCastle.Asn1.X509.X509ObjectIdentifiers.IdAD;
			global::Org.BouncyCastle.Asn1.X509.X509ObjectIdentifiers.IdADCAIssuers = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idAD != null) ? idAD.ToString() : null) + ".2");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idAD2 = global::Org.BouncyCastle.Asn1.X509.X509ObjectIdentifiers.IdAD;
			global::Org.BouncyCastle.Asn1.X509.X509ObjectIdentifiers.IdADOcsp = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idAD2 != null) ? idAD2.ToString() : null) + ".1");
			global::Org.BouncyCastle.Asn1.X509.X509ObjectIdentifiers.OcspAccessMethod = global::Org.BouncyCastle.Asn1.X509.X509ObjectIdentifiers.IdADOcsp;
			global::Org.BouncyCastle.Asn1.X509.X509ObjectIdentifiers.CrlAccessMethod = global::Org.BouncyCastle.Asn1.X509.X509ObjectIdentifiers.IdADCAIssuers;
		}

		// Token: 0x04001B68 RID: 7016
		internal const string ID = "2.5.4";

		// Token: 0x04001B69 RID: 7017
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier CommonName = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.4.3");

		// Token: 0x04001B6A RID: 7018
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier CountryName = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.4.6");

		// Token: 0x04001B6B RID: 7019
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier LocalityName = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.4.7");

		// Token: 0x04001B6C RID: 7020
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier StateOrProvinceName = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.4.8");

		// Token: 0x04001B6D RID: 7021
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Organization = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.4.10");

		// Token: 0x04001B6E RID: 7022
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier OrganizationalUnitName = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.4.11");

		// Token: 0x04001B6F RID: 7023
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_at_telephoneNumber = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.4.20");

		// Token: 0x04001B70 RID: 7024
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_at_name = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.4.41");

		// Token: 0x04001B71 RID: 7025
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_at_organizationIdentifier = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.4.97");

		// Token: 0x04001B72 RID: 7026
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdSha1 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.3.14.3.2.26");

		// Token: 0x04001B73 RID: 7027
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier RipeMD160 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.3.36.3.2.1");

		// Token: 0x04001B74 RID: 7028
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier RipeMD160WithRsaEncryption = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.3.36.3.3.1.2");

		// Token: 0x04001B75 RID: 7029
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdEARsa = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.8.1.1");

		// Token: 0x04001B76 RID: 7030
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdPkix = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.3.6.1.5.5.7");

		// Token: 0x04001B77 RID: 7031
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdPE;

		// Token: 0x04001B78 RID: 7032
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAD;

		// Token: 0x04001B79 RID: 7033
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdADCAIssuers;

		// Token: 0x04001B7A RID: 7034
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdADOcsp;

		// Token: 0x04001B7B RID: 7035
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier OcspAccessMethod;

		// Token: 0x04001B7C RID: 7036
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier CrlAccessMethod;
	}
}
