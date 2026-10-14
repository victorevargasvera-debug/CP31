using System;

namespace Org.BouncyCastle.Asn1.Misc
{
	// Token: 0x020006DF RID: 1759
	public abstract class MiscObjectIdentifiers
	{
		// Token: 0x04001E0D RID: 7693
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Netscape = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.16.840.1.113730.1");

		// Token: 0x04001E0E RID: 7694
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier NetscapeCertType = global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.Netscape.Branch("1");

		// Token: 0x04001E0F RID: 7695
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier NetscapeBaseUrl = global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.Netscape.Branch("2");

		// Token: 0x04001E10 RID: 7696
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier NetscapeRevocationUrl = global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.Netscape.Branch("3");

		// Token: 0x04001E11 RID: 7697
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier NetscapeCARevocationUrl = global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.Netscape.Branch("4");

		// Token: 0x04001E12 RID: 7698
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier NetscapeRenewalUrl = global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.Netscape.Branch("7");

		// Token: 0x04001E13 RID: 7699
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier NetscapeCAPolicyUrl = global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.Netscape.Branch("8");

		// Token: 0x04001E14 RID: 7700
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier NetscapeSslServerName = global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.Netscape.Branch("12");

		// Token: 0x04001E15 RID: 7701
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier NetscapeCertComment = global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.Netscape.Branch("13");

		// Token: 0x04001E16 RID: 7702
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Verisign = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.16.840.1.113733.1");

		// Token: 0x04001E17 RID: 7703
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier VerisignCzagExtension = global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.Verisign.Branch("6.3");

		// Token: 0x04001E18 RID: 7704
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier VerisignPrivate_6_9 = global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.Verisign.Branch("6.9");

		// Token: 0x04001E19 RID: 7705
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier VerisignOnSiteJurisdictionHash = global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.Verisign.Branch("6.11");

		// Token: 0x04001E1A RID: 7706
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier VerisignBitString_6_13 = global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.Verisign.Branch("6.13");

		// Token: 0x04001E1B RID: 7707
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier VerisignDnbDunsNumber = global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.Verisign.Branch("6.15");

		// Token: 0x04001E1C RID: 7708
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier VerisignIssStrongCrypto = global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.Verisign.Branch("8.1");

		// Token: 0x04001E1D RID: 7709
		public static readonly string Novell = "2.16.840.1.113719";

		// Token: 0x04001E1E RID: 7710
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier NovellSecurityAttribs = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.Novell + ".1.9.4.1");

		// Token: 0x04001E1F RID: 7711
		public static readonly string Entrust = "1.2.840.113533.7";

		// Token: 0x04001E20 RID: 7712
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier EntrustVersionExtension = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.Entrust + ".65.0");

		// Token: 0x04001E21 RID: 7713
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier cast5CBC = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.Entrust + ".66.10");

		// Token: 0x04001E22 RID: 7714
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier HMAC_SHA1 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.3.6.1.5.5.8.1.2");

		// Token: 0x04001E23 RID: 7715
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier as_sys_sec_alg_ideaCBC = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.3.6.1.4.1.188.7.1.1.2");

		// Token: 0x04001E24 RID: 7716
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier cryptlib = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.3.6.1.4.1.3029");

		// Token: 0x04001E25 RID: 7717
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier cryptlib_algorithm = global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.cryptlib.Branch("1");

		// Token: 0x04001E26 RID: 7718
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier cryptlib_algorithm_blowfish_ECB = global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.cryptlib_algorithm.Branch("1.1");

		// Token: 0x04001E27 RID: 7719
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier cryptlib_algorithm_blowfish_CBC = global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.cryptlib_algorithm.Branch("1.2");

		// Token: 0x04001E28 RID: 7720
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier cryptlib_algorithm_blowfish_CFB = global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.cryptlib_algorithm.Branch("1.3");

		// Token: 0x04001E29 RID: 7721
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier cryptlib_algorithm_blowfish_OFB = global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.cryptlib_algorithm.Branch("1.4");

		// Token: 0x04001E2A RID: 7722
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier blake2 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.3.6.1.4.1.1722.12.2");

		// Token: 0x04001E2B RID: 7723
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_blake2b160 = global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.blake2.Branch("1.5");

		// Token: 0x04001E2C RID: 7724
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_blake2b256 = global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.blake2.Branch("1.8");

		// Token: 0x04001E2D RID: 7725
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_blake2b384 = global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.blake2.Branch("1.12");

		// Token: 0x04001E2E RID: 7726
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_blake2b512 = global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.blake2.Branch("1.16");

		// Token: 0x04001E2F RID: 7727
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_blake2s128 = global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.blake2.Branch("2.4");

		// Token: 0x04001E30 RID: 7728
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_blake2s160 = global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.blake2.Branch("2.5");

		// Token: 0x04001E31 RID: 7729
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_blake2s224 = global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.blake2.Branch("2.7");

		// Token: 0x04001E32 RID: 7730
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_blake2s256 = global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.blake2.Branch("2.8");

		// Token: 0x04001E33 RID: 7731
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_scrypt = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.3.6.1.4.1.11591.4.11");
	}
}
