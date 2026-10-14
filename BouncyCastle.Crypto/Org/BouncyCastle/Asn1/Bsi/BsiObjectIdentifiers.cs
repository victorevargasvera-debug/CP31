using System;

namespace Org.BouncyCastle.Asn1.Bsi
{
	// Token: 0x02000792 RID: 1938
	public abstract class BsiObjectIdentifiers
	{
		// Token: 0x0400215E RID: 8542
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier bsi_de = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("0.4.0.127.0.7");

		// Token: 0x0400215F RID: 8543
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_ecc = global::Org.BouncyCastle.Asn1.Bsi.BsiObjectIdentifiers.bsi_de.Branch("1.1");

		// Token: 0x04002160 RID: 8544
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ecdsa_plain_signatures = global::Org.BouncyCastle.Asn1.Bsi.BsiObjectIdentifiers.id_ecc.Branch("4.1");

		// Token: 0x04002161 RID: 8545
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ecdsa_plain_SHA1 = global::Org.BouncyCastle.Asn1.Bsi.BsiObjectIdentifiers.ecdsa_plain_signatures.Branch("1");

		// Token: 0x04002162 RID: 8546
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ecdsa_plain_SHA224 = global::Org.BouncyCastle.Asn1.Bsi.BsiObjectIdentifiers.ecdsa_plain_signatures.Branch("2");

		// Token: 0x04002163 RID: 8547
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ecdsa_plain_SHA256 = global::Org.BouncyCastle.Asn1.Bsi.BsiObjectIdentifiers.ecdsa_plain_signatures.Branch("3");

		// Token: 0x04002164 RID: 8548
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ecdsa_plain_SHA384 = global::Org.BouncyCastle.Asn1.Bsi.BsiObjectIdentifiers.ecdsa_plain_signatures.Branch("4");

		// Token: 0x04002165 RID: 8549
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ecdsa_plain_SHA512 = global::Org.BouncyCastle.Asn1.Bsi.BsiObjectIdentifiers.ecdsa_plain_signatures.Branch("5");

		// Token: 0x04002166 RID: 8550
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ecdsa_plain_RIPEMD160 = global::Org.BouncyCastle.Asn1.Bsi.BsiObjectIdentifiers.ecdsa_plain_signatures.Branch("6");

		// Token: 0x04002167 RID: 8551
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier algorithm = global::Org.BouncyCastle.Asn1.Bsi.BsiObjectIdentifiers.bsi_de.Branch("1");

		// Token: 0x04002168 RID: 8552
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ecka_eg = global::Org.BouncyCastle.Asn1.Bsi.BsiObjectIdentifiers.id_ecc.Branch("5.1");

		// Token: 0x04002169 RID: 8553
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ecka_eg_X963kdf = global::Org.BouncyCastle.Asn1.Bsi.BsiObjectIdentifiers.ecka_eg.Branch("1");

		// Token: 0x0400216A RID: 8554
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ecka_eg_X963kdf_SHA1 = global::Org.BouncyCastle.Asn1.Bsi.BsiObjectIdentifiers.ecka_eg_X963kdf.Branch("1");

		// Token: 0x0400216B RID: 8555
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ecka_eg_X963kdf_SHA224 = global::Org.BouncyCastle.Asn1.Bsi.BsiObjectIdentifiers.ecka_eg_X963kdf.Branch("2");

		// Token: 0x0400216C RID: 8556
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ecka_eg_X963kdf_SHA256 = global::Org.BouncyCastle.Asn1.Bsi.BsiObjectIdentifiers.ecka_eg_X963kdf.Branch("3");

		// Token: 0x0400216D RID: 8557
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ecka_eg_X963kdf_SHA384 = global::Org.BouncyCastle.Asn1.Bsi.BsiObjectIdentifiers.ecka_eg_X963kdf.Branch("4");

		// Token: 0x0400216E RID: 8558
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ecka_eg_X963kdf_SHA512 = global::Org.BouncyCastle.Asn1.Bsi.BsiObjectIdentifiers.ecka_eg_X963kdf.Branch("5");

		// Token: 0x0400216F RID: 8559
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ecka_eg_X963kdf_RIPEMD160 = global::Org.BouncyCastle.Asn1.Bsi.BsiObjectIdentifiers.ecka_eg_X963kdf.Branch("6");

		// Token: 0x04002170 RID: 8560
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ecka_eg_SessionKDF = global::Org.BouncyCastle.Asn1.Bsi.BsiObjectIdentifiers.ecka_eg.Branch("2");

		// Token: 0x04002171 RID: 8561
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ecka_eg_SessionKDF_3DES = global::Org.BouncyCastle.Asn1.Bsi.BsiObjectIdentifiers.ecka_eg_SessionKDF.Branch("1");

		// Token: 0x04002172 RID: 8562
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ecka_eg_SessionKDF_AES128 = global::Org.BouncyCastle.Asn1.Bsi.BsiObjectIdentifiers.ecka_eg_SessionKDF.Branch("2");

		// Token: 0x04002173 RID: 8563
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ecka_eg_SessionKDF_AES192 = global::Org.BouncyCastle.Asn1.Bsi.BsiObjectIdentifiers.ecka_eg_SessionKDF.Branch("3");

		// Token: 0x04002174 RID: 8564
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ecka_eg_SessionKDF_AES256 = global::Org.BouncyCastle.Asn1.Bsi.BsiObjectIdentifiers.ecka_eg_SessionKDF.Branch("4");
	}
}
