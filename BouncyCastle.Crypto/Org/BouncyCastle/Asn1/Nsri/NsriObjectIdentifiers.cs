using System;

namespace Org.BouncyCastle.Asn1.Nsri
{
	// Token: 0x020006D7 RID: 1751
	public sealed class NsriObjectIdentifiers
	{
		// Token: 0x04001D99 RID: 7577
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier nsri = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.410.200046");

		// Token: 0x04001D9A RID: 7578
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_algorithm = global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.nsri.Branch("1");

		// Token: 0x04001D9B RID: 7579
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_sea = global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_algorithm.Branch("1");

		// Token: 0x04001D9C RID: 7580
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_pad = global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_algorithm.Branch("2");

		// Token: 0x04001D9D RID: 7581
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_pad_null = global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_algorithm.Branch("0");

		// Token: 0x04001D9E RID: 7582
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_pad_1 = global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_algorithm.Branch("1");

		// Token: 0x04001D9F RID: 7583
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_aria128_ecb = global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_sea.Branch("1");

		// Token: 0x04001DA0 RID: 7584
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_aria128_cbc = global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_sea.Branch("2");

		// Token: 0x04001DA1 RID: 7585
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_aria128_cfb = global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_sea.Branch("3");

		// Token: 0x04001DA2 RID: 7586
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_aria128_ofb = global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_sea.Branch("4");

		// Token: 0x04001DA3 RID: 7587
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_aria128_ctr = global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_sea.Branch("5");

		// Token: 0x04001DA4 RID: 7588
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_aria192_ecb = global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_sea.Branch("6");

		// Token: 0x04001DA5 RID: 7589
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_aria192_cbc = global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_sea.Branch("7");

		// Token: 0x04001DA6 RID: 7590
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_aria192_cfb = global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_sea.Branch("8");

		// Token: 0x04001DA7 RID: 7591
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_aria192_ofb = global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_sea.Branch("9");

		// Token: 0x04001DA8 RID: 7592
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_aria192_ctr = global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_sea.Branch("10");

		// Token: 0x04001DA9 RID: 7593
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_aria256_ecb = global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_sea.Branch("11");

		// Token: 0x04001DAA RID: 7594
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_aria256_cbc = global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_sea.Branch("12");

		// Token: 0x04001DAB RID: 7595
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_aria256_cfb = global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_sea.Branch("13");

		// Token: 0x04001DAC RID: 7596
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_aria256_ofb = global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_sea.Branch("14");

		// Token: 0x04001DAD RID: 7597
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_aria256_ctr = global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_sea.Branch("15");

		// Token: 0x04001DAE RID: 7598
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_aria128_cmac = global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_sea.Branch("21");

		// Token: 0x04001DAF RID: 7599
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_aria192_cmac = global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_sea.Branch("22");

		// Token: 0x04001DB0 RID: 7600
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_aria256_cmac = global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_sea.Branch("23");

		// Token: 0x04001DB1 RID: 7601
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_aria128_ocb2 = global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_sea.Branch("31");

		// Token: 0x04001DB2 RID: 7602
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_aria192_ocb2 = global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_sea.Branch("32");

		// Token: 0x04001DB3 RID: 7603
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_aria256_ocb2 = global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_sea.Branch("33");

		// Token: 0x04001DB4 RID: 7604
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_aria128_gcm = global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_sea.Branch("34");

		// Token: 0x04001DB5 RID: 7605
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_aria192_gcm = global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_sea.Branch("35");

		// Token: 0x04001DB6 RID: 7606
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_aria256_gcm = global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_sea.Branch("36");

		// Token: 0x04001DB7 RID: 7607
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_aria128_ccm = global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_sea.Branch("37");

		// Token: 0x04001DB8 RID: 7608
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_aria192_ccm = global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_sea.Branch("38");

		// Token: 0x04001DB9 RID: 7609
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_aria256_ccm = global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_sea.Branch("39");

		// Token: 0x04001DBA RID: 7610
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_aria128_kw = global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_sea.Branch("40");

		// Token: 0x04001DBB RID: 7611
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_aria192_kw = global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_sea.Branch("41");

		// Token: 0x04001DBC RID: 7612
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_aria256_kw = global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_sea.Branch("42");

		// Token: 0x04001DBD RID: 7613
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_aria128_kwp = global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_sea.Branch("43");

		// Token: 0x04001DBE RID: 7614
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_aria192_kwp = global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_sea.Branch("44");

		// Token: 0x04001DBF RID: 7615
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_aria256_kwp = global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_sea.Branch("45");
	}
}
