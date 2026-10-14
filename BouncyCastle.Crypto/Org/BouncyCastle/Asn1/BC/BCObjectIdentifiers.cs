using System;

namespace Org.BouncyCastle.Asn1.BC
{
	// Token: 0x02000793 RID: 1939
	public abstract class BCObjectIdentifiers
	{
		// Token: 0x04002175 RID: 8565
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier bc = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.3.6.1.4.1.22554");

		// Token: 0x04002176 RID: 8566
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier bc_pbe = global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.bc.Branch("1");

		// Token: 0x04002177 RID: 8567
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier bc_pbe_sha1 = global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.bc_pbe.Branch("1");

		// Token: 0x04002178 RID: 8568
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier bc_pbe_sha256 = global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.bc_pbe.Branch("2.1");

		// Token: 0x04002179 RID: 8569
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier bc_pbe_sha384 = global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.bc_pbe.Branch("2.2");

		// Token: 0x0400217A RID: 8570
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier bc_pbe_sha512 = global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.bc_pbe.Branch("2.3");

		// Token: 0x0400217B RID: 8571
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier bc_pbe_sha224 = global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.bc_pbe.Branch("2.4");

		// Token: 0x0400217C RID: 8572
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier bc_pbe_sha1_pkcs5 = global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.bc_pbe_sha1.Branch("1");

		// Token: 0x0400217D RID: 8573
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier bc_pbe_sha1_pkcs12 = global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.bc_pbe_sha1.Branch("2");

		// Token: 0x0400217E RID: 8574
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier bc_pbe_sha256_pkcs5 = global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.bc_pbe_sha256.Branch("1");

		// Token: 0x0400217F RID: 8575
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier bc_pbe_sha256_pkcs12 = global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.bc_pbe_sha256.Branch("2");

		// Token: 0x04002180 RID: 8576
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier bc_pbe_sha1_pkcs12_aes128_cbc = global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.bc_pbe_sha1_pkcs12.Branch("1.2");

		// Token: 0x04002181 RID: 8577
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier bc_pbe_sha1_pkcs12_aes192_cbc = global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.bc_pbe_sha1_pkcs12.Branch("1.22");

		// Token: 0x04002182 RID: 8578
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier bc_pbe_sha1_pkcs12_aes256_cbc = global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.bc_pbe_sha1_pkcs12.Branch("1.42");

		// Token: 0x04002183 RID: 8579
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier bc_pbe_sha256_pkcs12_aes128_cbc = global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.bc_pbe_sha256_pkcs12.Branch("1.2");

		// Token: 0x04002184 RID: 8580
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier bc_pbe_sha256_pkcs12_aes192_cbc = global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.bc_pbe_sha256_pkcs12.Branch("1.22");

		// Token: 0x04002185 RID: 8581
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier bc_pbe_sha256_pkcs12_aes256_cbc = global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.bc_pbe_sha256_pkcs12.Branch("1.42");

		// Token: 0x04002186 RID: 8582
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier bc_sig = global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.bc.Branch("2");

		// Token: 0x04002187 RID: 8583
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sphincs256 = global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.bc_sig.Branch("1");

		// Token: 0x04002188 RID: 8584
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sphincs256_with_BLAKE512 = global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.sphincs256.Branch("1");

		// Token: 0x04002189 RID: 8585
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sphincs256_with_SHA512 = global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.sphincs256.Branch("2");

		// Token: 0x0400218A RID: 8586
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sphincs256_with_SHA3_512 = global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.sphincs256.Branch("3");

		// Token: 0x0400218B RID: 8587
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier xmss = global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.bc_sig.Branch("2");

		// Token: 0x0400218C RID: 8588
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier xmss_with_SHA256 = global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.xmss.Branch("1");

		// Token: 0x0400218D RID: 8589
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier xmss_with_SHA512 = global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.xmss.Branch("2");

		// Token: 0x0400218E RID: 8590
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier xmss_with_SHAKE128 = global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.xmss.Branch("3");

		// Token: 0x0400218F RID: 8591
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier xmss_with_SHAKE256 = global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.xmss.Branch("4");

		// Token: 0x04002190 RID: 8592
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier xmss_mt = global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.bc_sig.Branch("3");

		// Token: 0x04002191 RID: 8593
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier xmss_mt_with_SHA256 = global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.xmss_mt.Branch("1");

		// Token: 0x04002192 RID: 8594
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier xmss_mt_with_SHA512 = global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.xmss_mt.Branch("2");

		// Token: 0x04002193 RID: 8595
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier xmss_mt_with_SHAKE128 = global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.xmss_mt.Branch("3");

		// Token: 0x04002194 RID: 8596
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier xmss_mt_with_SHAKE256 = global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.xmss_mt.Branch("4");

		// Token: 0x04002195 RID: 8597
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier bc_exch = global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.bc.Branch("3");

		// Token: 0x04002196 RID: 8598
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier newHope = global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.bc_exch.Branch("1");

		// Token: 0x04002197 RID: 8599
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier bc_ext = global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.bc.Branch("4");

		// Token: 0x04002198 RID: 8600
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier linkedCertificate = global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.bc_ext.Branch("1");
	}
}
