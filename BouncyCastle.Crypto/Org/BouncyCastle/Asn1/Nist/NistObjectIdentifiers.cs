using System;

namespace Org.BouncyCastle.Asn1.Nist
{
	// Token: 0x020006DB RID: 1755
	public sealed class NistObjectIdentifiers
	{
		// Token: 0x06003FF8 RID: 16376 RVA: 0x00121DF9 File Offset: 0x0011FFF9
		private NistObjectIdentifiers()
		{
		}

		// Token: 0x06003FF9 RID: 16377 RVA: 0x00121E04 File Offset: 0x00120004
		// Note: this type is marked as 'beforefieldinit'.
		static NistObjectIdentifiers()
		{
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier nistAlgorithm = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.NistAlgorithm;
			global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.Aes = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((nistAlgorithm != null) ? nistAlgorithm.ToString() : null) + ".1");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier aes = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.Aes;
			global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes128Ecb = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((aes != null) ? aes.ToString() : null) + ".1");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier aes2 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.Aes;
			global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes128Cbc = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((aes2 != null) ? aes2.ToString() : null) + ".2");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier aes3 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.Aes;
			global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes128Ofb = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((aes3 != null) ? aes3.ToString() : null) + ".3");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier aes4 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.Aes;
			global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes128Cfb = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((aes4 != null) ? aes4.ToString() : null) + ".4");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier aes5 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.Aes;
			global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes128Wrap = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((aes5 != null) ? aes5.ToString() : null) + ".5");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier aes6 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.Aes;
			global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes128Gcm = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((aes6 != null) ? aes6.ToString() : null) + ".6");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier aes7 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.Aes;
			global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes128Ccm = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((aes7 != null) ? aes7.ToString() : null) + ".7");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier aes8 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.Aes;
			global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes192Ecb = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((aes8 != null) ? aes8.ToString() : null) + ".21");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier aes9 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.Aes;
			global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes192Cbc = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((aes9 != null) ? aes9.ToString() : null) + ".22");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier aes10 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.Aes;
			global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes192Ofb = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((aes10 != null) ? aes10.ToString() : null) + ".23");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier aes11 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.Aes;
			global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes192Cfb = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((aes11 != null) ? aes11.ToString() : null) + ".24");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier aes12 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.Aes;
			global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes192Wrap = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((aes12 != null) ? aes12.ToString() : null) + ".25");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier aes13 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.Aes;
			global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes192Gcm = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((aes13 != null) ? aes13.ToString() : null) + ".26");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier aes14 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.Aes;
			global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes192Ccm = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((aes14 != null) ? aes14.ToString() : null) + ".27");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier aes15 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.Aes;
			global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes256Ecb = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((aes15 != null) ? aes15.ToString() : null) + ".41");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier aes16 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.Aes;
			global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes256Cbc = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((aes16 != null) ? aes16.ToString() : null) + ".42");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier aes17 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.Aes;
			global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes256Ofb = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((aes17 != null) ? aes17.ToString() : null) + ".43");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier aes18 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.Aes;
			global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes256Cfb = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((aes18 != null) ? aes18.ToString() : null) + ".44");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier aes19 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.Aes;
			global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes256Wrap = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((aes19 != null) ? aes19.ToString() : null) + ".45");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier aes20 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.Aes;
			global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes256Gcm = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((aes20 != null) ? aes20.ToString() : null) + ".46");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier aes21 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.Aes;
			global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes256Ccm = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((aes21 != null) ? aes21.ToString() : null) + ".47");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier nistAlgorithm2 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.NistAlgorithm;
			global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdDsaWithSha2 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((nistAlgorithm2 != null) ? nistAlgorithm2.ToString() : null) + ".3");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idDsaWithSha = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdDsaWithSha2;
			global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha224 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idDsaWithSha != null) ? idDsaWithSha.ToString() : null) + ".1");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idDsaWithSha2 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdDsaWithSha2;
			global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha256 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idDsaWithSha2 != null) ? idDsaWithSha2.ToString() : null) + ".2");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idDsaWithSha3 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdDsaWithSha2;
			global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha384 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idDsaWithSha3 != null) ? idDsaWithSha3.ToString() : null) + ".3");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idDsaWithSha4 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdDsaWithSha2;
			global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha512 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idDsaWithSha4 != null) ? idDsaWithSha4.ToString() : null) + ".4");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idDsaWithSha5 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdDsaWithSha2;
			global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdDsaWithSha3_224 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idDsaWithSha5 != null) ? idDsaWithSha5.ToString() : null) + ".5");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idDsaWithSha6 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdDsaWithSha2;
			global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdDsaWithSha3_256 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idDsaWithSha6 != null) ? idDsaWithSha6.ToString() : null) + ".6");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idDsaWithSha7 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdDsaWithSha2;
			global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdDsaWithSha3_384 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idDsaWithSha7 != null) ? idDsaWithSha7.ToString() : null) + ".7");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idDsaWithSha8 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdDsaWithSha2;
			global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdDsaWithSha3_512 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idDsaWithSha8 != null) ? idDsaWithSha8.ToString() : null) + ".8");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idDsaWithSha9 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdDsaWithSha2;
			global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdEcdsaWithSha3_224 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idDsaWithSha9 != null) ? idDsaWithSha9.ToString() : null) + ".9");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idDsaWithSha10 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdDsaWithSha2;
			global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdEcdsaWithSha3_256 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idDsaWithSha10 != null) ? idDsaWithSha10.ToString() : null) + ".10");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idDsaWithSha11 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdDsaWithSha2;
			global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdEcdsaWithSha3_384 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idDsaWithSha11 != null) ? idDsaWithSha11.ToString() : null) + ".11");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idDsaWithSha12 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdDsaWithSha2;
			global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdEcdsaWithSha3_512 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idDsaWithSha12 != null) ? idDsaWithSha12.ToString() : null) + ".12");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idDsaWithSha13 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdDsaWithSha2;
			global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdRsassaPkcs1V15WithSha3_224 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idDsaWithSha13 != null) ? idDsaWithSha13.ToString() : null) + ".13");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idDsaWithSha14 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdDsaWithSha2;
			global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdRsassaPkcs1V15WithSha3_256 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idDsaWithSha14 != null) ? idDsaWithSha14.ToString() : null) + ".14");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idDsaWithSha15 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdDsaWithSha2;
			global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdRsassaPkcs1V15WithSha3_384 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idDsaWithSha15 != null) ? idDsaWithSha15.ToString() : null) + ".15");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idDsaWithSha16 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdDsaWithSha2;
			global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdRsassaPkcs1V15WithSha3_512 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idDsaWithSha16 != null) ? idDsaWithSha16.ToString() : null) + ".16");
		}

		// Token: 0x04001DCA RID: 7626
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier NistAlgorithm = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.16.840.1.101.3.4");

		// Token: 0x04001DCB RID: 7627
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier HashAlgs = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.NistAlgorithm.Branch("2");

		// Token: 0x04001DCC RID: 7628
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdSha256 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.HashAlgs.Branch("1");

		// Token: 0x04001DCD RID: 7629
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdSha384 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.HashAlgs.Branch("2");

		// Token: 0x04001DCE RID: 7630
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdSha512 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.HashAlgs.Branch("3");

		// Token: 0x04001DCF RID: 7631
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdSha224 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.HashAlgs.Branch("4");

		// Token: 0x04001DD0 RID: 7632
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdSha512_224 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.HashAlgs.Branch("5");

		// Token: 0x04001DD1 RID: 7633
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdSha512_256 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.HashAlgs.Branch("6");

		// Token: 0x04001DD2 RID: 7634
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdSha3_224 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.HashAlgs.Branch("7");

		// Token: 0x04001DD3 RID: 7635
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdSha3_256 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.HashAlgs.Branch("8");

		// Token: 0x04001DD4 RID: 7636
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdSha3_384 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.HashAlgs.Branch("9");

		// Token: 0x04001DD5 RID: 7637
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdSha3_512 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.HashAlgs.Branch("10");

		// Token: 0x04001DD6 RID: 7638
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdShake128 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.HashAlgs.Branch("11");

		// Token: 0x04001DD7 RID: 7639
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdShake256 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.HashAlgs.Branch("12");

		// Token: 0x04001DD8 RID: 7640
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdHMacWithSha3_224 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.HashAlgs.Branch("13");

		// Token: 0x04001DD9 RID: 7641
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdHMacWithSha3_256 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.HashAlgs.Branch("14");

		// Token: 0x04001DDA RID: 7642
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdHMacWithSha3_384 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.HashAlgs.Branch("15");

		// Token: 0x04001DDB RID: 7643
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdHMacWithSha3_512 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.HashAlgs.Branch("16");

		// Token: 0x04001DDC RID: 7644
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdShake128Len = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.HashAlgs.Branch("17");

		// Token: 0x04001DDD RID: 7645
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdShake256Len = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.HashAlgs.Branch("18");

		// Token: 0x04001DDE RID: 7646
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdKmacWithShake128 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.HashAlgs.Branch("19");

		// Token: 0x04001DDF RID: 7647
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdKmacWithShake256 = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.HashAlgs.Branch("20");

		// Token: 0x04001DE0 RID: 7648
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Aes;

		// Token: 0x04001DE1 RID: 7649
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAes128Ecb;

		// Token: 0x04001DE2 RID: 7650
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAes128Cbc;

		// Token: 0x04001DE3 RID: 7651
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAes128Ofb;

		// Token: 0x04001DE4 RID: 7652
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAes128Cfb;

		// Token: 0x04001DE5 RID: 7653
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAes128Wrap;

		// Token: 0x04001DE6 RID: 7654
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAes128Gcm;

		// Token: 0x04001DE7 RID: 7655
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAes128Ccm;

		// Token: 0x04001DE8 RID: 7656
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAes192Ecb;

		// Token: 0x04001DE9 RID: 7657
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAes192Cbc;

		// Token: 0x04001DEA RID: 7658
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAes192Ofb;

		// Token: 0x04001DEB RID: 7659
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAes192Cfb;

		// Token: 0x04001DEC RID: 7660
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAes192Wrap;

		// Token: 0x04001DED RID: 7661
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAes192Gcm;

		// Token: 0x04001DEE RID: 7662
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAes192Ccm;

		// Token: 0x04001DEF RID: 7663
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAes256Ecb;

		// Token: 0x04001DF0 RID: 7664
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAes256Cbc;

		// Token: 0x04001DF1 RID: 7665
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAes256Ofb;

		// Token: 0x04001DF2 RID: 7666
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAes256Cfb;

		// Token: 0x04001DF3 RID: 7667
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAes256Wrap;

		// Token: 0x04001DF4 RID: 7668
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAes256Gcm;

		// Token: 0x04001DF5 RID: 7669
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdAes256Ccm;

		// Token: 0x04001DF6 RID: 7670
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdDsaWithSha2;

		// Token: 0x04001DF7 RID: 7671
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier DsaWithSha224;

		// Token: 0x04001DF8 RID: 7672
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier DsaWithSha256;

		// Token: 0x04001DF9 RID: 7673
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier DsaWithSha384;

		// Token: 0x04001DFA RID: 7674
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier DsaWithSha512;

		// Token: 0x04001DFB RID: 7675
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdDsaWithSha3_224;

		// Token: 0x04001DFC RID: 7676
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdDsaWithSha3_256;

		// Token: 0x04001DFD RID: 7677
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdDsaWithSha3_384;

		// Token: 0x04001DFE RID: 7678
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdDsaWithSha3_512;

		// Token: 0x04001DFF RID: 7679
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdEcdsaWithSha3_224;

		// Token: 0x04001E00 RID: 7680
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdEcdsaWithSha3_256;

		// Token: 0x04001E01 RID: 7681
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdEcdsaWithSha3_384;

		// Token: 0x04001E02 RID: 7682
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdEcdsaWithSha3_512;

		// Token: 0x04001E03 RID: 7683
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdRsassaPkcs1V15WithSha3_224;

		// Token: 0x04001E04 RID: 7684
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdRsassaPkcs1V15WithSha3_256;

		// Token: 0x04001E05 RID: 7685
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdRsassaPkcs1V15WithSha3_384;

		// Token: 0x04001E06 RID: 7686
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdRsassaPkcs1V15WithSha3_512;
	}
}
