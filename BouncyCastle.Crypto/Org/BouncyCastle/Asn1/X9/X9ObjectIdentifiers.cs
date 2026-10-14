using System;

namespace Org.BouncyCastle.Asn1.X9
{
	// Token: 0x0200063C RID: 1596
	public abstract class X9ObjectIdentifiers
	{
		// Token: 0x040019DC RID: 6620
		internal const string AnsiX962 = "1.2.840.10045";

		// Token: 0x040019DD RID: 6621
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ansi_X9_62 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.10045");

		// Token: 0x040019DE RID: 6622
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdFieldType = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ansi_X9_62.Branch("1");

		// Token: 0x040019DF RID: 6623
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier PrimeField = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdFieldType.Branch("1");

		// Token: 0x040019E0 RID: 6624
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier CharacteristicTwoField = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdFieldType.Branch("2");

		// Token: 0x040019E1 RID: 6625
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier GNBasis = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CharacteristicTwoField.Branch("3.1");

		// Token: 0x040019E2 RID: 6626
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier TPBasis = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CharacteristicTwoField.Branch("3.2");

		// Token: 0x040019E3 RID: 6627
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier PPBasis = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CharacteristicTwoField.Branch("3.3");

		// Token: 0x040019E4 RID: 6628
		[global::System.Obsolete("Use 'id_ecSigType' instead")]
		public const string IdECSigType = "1.2.840.10045.4";

		// Token: 0x040019E5 RID: 6629
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_ecSigType = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ansi_X9_62.Branch("4");

		// Token: 0x040019E6 RID: 6630
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ECDsaWithSha1 = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.id_ecSigType.Branch("1");

		// Token: 0x040019E7 RID: 6631
		[global::System.Obsolete("Use 'id_publicKeyType' instead")]
		public const string IdPublicKeyType = "1.2.840.10045.2";

		// Token: 0x040019E8 RID: 6632
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_publicKeyType = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ansi_X9_62.Branch("2");

		// Token: 0x040019E9 RID: 6633
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdECPublicKey = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.id_publicKeyType.Branch("1");

		// Token: 0x040019EA RID: 6634
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ECDsaWithSha2 = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.id_ecSigType.Branch("3");

		// Token: 0x040019EB RID: 6635
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ECDsaWithSha224 = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha2.Branch("1");

		// Token: 0x040019EC RID: 6636
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ECDsaWithSha256 = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha2.Branch("2");

		// Token: 0x040019ED RID: 6637
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ECDsaWithSha384 = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha2.Branch("3");

		// Token: 0x040019EE RID: 6638
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ECDsaWithSha512 = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha2.Branch("4");

		// Token: 0x040019EF RID: 6639
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier EllipticCurve = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ansi_X9_62.Branch("3");

		// Token: 0x040019F0 RID: 6640
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier CTwoCurve = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.EllipticCurve.Branch("0");

		// Token: 0x040019F1 RID: 6641
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier C2Pnb163v1 = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CTwoCurve.Branch("1");

		// Token: 0x040019F2 RID: 6642
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier C2Pnb163v2 = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CTwoCurve.Branch("2");

		// Token: 0x040019F3 RID: 6643
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier C2Pnb163v3 = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CTwoCurve.Branch("3");

		// Token: 0x040019F4 RID: 6644
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier C2Pnb176w1 = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CTwoCurve.Branch("4");

		// Token: 0x040019F5 RID: 6645
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier C2Tnb191v1 = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CTwoCurve.Branch("5");

		// Token: 0x040019F6 RID: 6646
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier C2Tnb191v2 = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CTwoCurve.Branch("6");

		// Token: 0x040019F7 RID: 6647
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier C2Tnb191v3 = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CTwoCurve.Branch("7");

		// Token: 0x040019F8 RID: 6648
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier C2Onb191v4 = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CTwoCurve.Branch("8");

		// Token: 0x040019F9 RID: 6649
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier C2Onb191v5 = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CTwoCurve.Branch("9");

		// Token: 0x040019FA RID: 6650
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier C2Pnb208w1 = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CTwoCurve.Branch("10");

		// Token: 0x040019FB RID: 6651
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier C2Tnb239v1 = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CTwoCurve.Branch("11");

		// Token: 0x040019FC RID: 6652
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier C2Tnb239v2 = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CTwoCurve.Branch("12");

		// Token: 0x040019FD RID: 6653
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier C2Tnb239v3 = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CTwoCurve.Branch("13");

		// Token: 0x040019FE RID: 6654
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier C2Onb239v4 = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CTwoCurve.Branch("14");

		// Token: 0x040019FF RID: 6655
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier C2Onb239v5 = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CTwoCurve.Branch("15");

		// Token: 0x04001A00 RID: 6656
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier C2Pnb272w1 = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CTwoCurve.Branch("16");

		// Token: 0x04001A01 RID: 6657
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier C2Pnb304w1 = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CTwoCurve.Branch("17");

		// Token: 0x04001A02 RID: 6658
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier C2Tnb359v1 = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CTwoCurve.Branch("18");

		// Token: 0x04001A03 RID: 6659
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier C2Pnb368w1 = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CTwoCurve.Branch("19");

		// Token: 0x04001A04 RID: 6660
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier C2Tnb431r1 = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CTwoCurve.Branch("20");

		// Token: 0x04001A05 RID: 6661
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier PrimeCurve = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.EllipticCurve.Branch("1");

		// Token: 0x04001A06 RID: 6662
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Prime192v1 = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.PrimeCurve.Branch("1");

		// Token: 0x04001A07 RID: 6663
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Prime192v2 = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.PrimeCurve.Branch("2");

		// Token: 0x04001A08 RID: 6664
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Prime192v3 = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.PrimeCurve.Branch("3");

		// Token: 0x04001A09 RID: 6665
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Prime239v1 = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.PrimeCurve.Branch("4");

		// Token: 0x04001A0A RID: 6666
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Prime239v2 = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.PrimeCurve.Branch("5");

		// Token: 0x04001A0B RID: 6667
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Prime239v3 = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.PrimeCurve.Branch("6");

		// Token: 0x04001A0C RID: 6668
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Prime256v1 = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.PrimeCurve.Branch("7");

		// Token: 0x04001A0D RID: 6669
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdDsa = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.10040.4.1");

		// Token: 0x04001A0E RID: 6670
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdDsaWithSha1 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.10040.4.3");

		// Token: 0x04001A0F RID: 6671
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier X9x63Scheme = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.3.133.16.840.63.0");

		// Token: 0x04001A10 RID: 6672
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier DHSinglePassStdDHSha1KdfScheme = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.X9x63Scheme.Branch("2");

		// Token: 0x04001A11 RID: 6673
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier DHSinglePassCofactorDHSha1KdfScheme = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.X9x63Scheme.Branch("3");

		// Token: 0x04001A12 RID: 6674
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier MqvSinglePassSha1KdfScheme = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.X9x63Scheme.Branch("16");

		// Token: 0x04001A13 RID: 6675
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ansi_x9_42 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.10046");

		// Token: 0x04001A14 RID: 6676
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier DHPublicNumber = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ansi_x9_42.Branch("2.1");

		// Token: 0x04001A15 RID: 6677
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier X9x42Schemes = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ansi_x9_42.Branch("2.3");

		// Token: 0x04001A16 RID: 6678
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier DHStatic = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.X9x42Schemes.Branch("1");

		// Token: 0x04001A17 RID: 6679
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier DHEphem = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.X9x42Schemes.Branch("2");

		// Token: 0x04001A18 RID: 6680
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier DHOneFlow = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.X9x42Schemes.Branch("3");

		// Token: 0x04001A19 RID: 6681
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier DHHybrid1 = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.X9x42Schemes.Branch("4");

		// Token: 0x04001A1A RID: 6682
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier DHHybrid2 = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.X9x42Schemes.Branch("5");

		// Token: 0x04001A1B RID: 6683
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier DHHybridOneFlow = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.X9x42Schemes.Branch("6");

		// Token: 0x04001A1C RID: 6684
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Mqv2 = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.X9x42Schemes.Branch("7");

		// Token: 0x04001A1D RID: 6685
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Mqv1 = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.X9x42Schemes.Branch("8");
	}
}
