using System;

namespace Org.BouncyCastle.Asn1.GM
{
	// Token: 0x020006F9 RID: 1785
	public abstract class GMObjectIdentifiers
	{
		// Token: 0x04001EBF RID: 7871
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sm_scheme = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.156.10197.1");

		// Token: 0x04001EC0 RID: 7872
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sm6_ecb = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("101.1");

		// Token: 0x04001EC1 RID: 7873
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sm6_cbc = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("101.2");

		// Token: 0x04001EC2 RID: 7874
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sm6_ofb128 = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("101.3");

		// Token: 0x04001EC3 RID: 7875
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sm6_cfb128 = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("101.4");

		// Token: 0x04001EC4 RID: 7876
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sm1_ecb = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("102.1");

		// Token: 0x04001EC5 RID: 7877
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sm1_cbc = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("102.2");

		// Token: 0x04001EC6 RID: 7878
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sm1_ofb128 = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("102.3");

		// Token: 0x04001EC7 RID: 7879
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sm1_cfb128 = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("102.4");

		// Token: 0x04001EC8 RID: 7880
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sm1_cfb1 = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("102.5");

		// Token: 0x04001EC9 RID: 7881
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sm1_cfb8 = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("102.6");

		// Token: 0x04001ECA RID: 7882
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ssf33_ecb = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("103.1");

		// Token: 0x04001ECB RID: 7883
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ssf33_cbc = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("103.2");

		// Token: 0x04001ECC RID: 7884
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ssf33_ofb128 = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("103.3");

		// Token: 0x04001ECD RID: 7885
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ssf33_cfb128 = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("103.4");

		// Token: 0x04001ECE RID: 7886
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ssf33_cfb1 = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("103.5");

		// Token: 0x04001ECF RID: 7887
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ssf33_cfb8 = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("103.6");

		// Token: 0x04001ED0 RID: 7888
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sms4_ecb = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("104.1");

		// Token: 0x04001ED1 RID: 7889
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sms4_cbc = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("104.2");

		// Token: 0x04001ED2 RID: 7890
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sms4_ofb128 = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("104.3");

		// Token: 0x04001ED3 RID: 7891
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sms4_cfb128 = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("104.4");

		// Token: 0x04001ED4 RID: 7892
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sms4_cfb1 = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("104.5");

		// Token: 0x04001ED5 RID: 7893
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sms4_cfb8 = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("104.6");

		// Token: 0x04001ED6 RID: 7894
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sms4_ctr = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("104.7");

		// Token: 0x04001ED7 RID: 7895
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sms4_gcm = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("104.8");

		// Token: 0x04001ED8 RID: 7896
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sms4_ccm = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("104.9");

		// Token: 0x04001ED9 RID: 7897
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sms4_xts = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("104.10");

		// Token: 0x04001EDA RID: 7898
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sms4_wrap = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("104.11");

		// Token: 0x04001EDB RID: 7899
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sms4_wrap_pad = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("104.12");

		// Token: 0x04001EDC RID: 7900
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sms4_ocb = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("104.100");

		// Token: 0x04001EDD RID: 7901
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sm5 = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("201");

		// Token: 0x04001EDE RID: 7902
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sm2p256v1 = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("301");

		// Token: 0x04001EDF RID: 7903
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sm2sign = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("301.1");

		// Token: 0x04001EE0 RID: 7904
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sm2exchange = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("301.2");

		// Token: 0x04001EE1 RID: 7905
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sm2encrypt = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("301.3");

		// Token: 0x04001EE2 RID: 7906
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier wapip192v1 = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("301.101");

		// Token: 0x04001EE3 RID: 7907
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sm2encrypt_recommendedParameters = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm2encrypt.Branch("1");

		// Token: 0x04001EE4 RID: 7908
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sm2encrypt_specifiedParameters = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm2encrypt.Branch("2");

		// Token: 0x04001EE5 RID: 7909
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sm2encrypt_with_sm3 = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm2encrypt.Branch("2.1");

		// Token: 0x04001EE6 RID: 7910
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sm2encrypt_with_sha1 = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm2encrypt.Branch("2.2");

		// Token: 0x04001EE7 RID: 7911
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sm2encrypt_with_sha224 = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm2encrypt.Branch("2.3");

		// Token: 0x04001EE8 RID: 7912
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sm2encrypt_with_sha256 = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm2encrypt.Branch("2.4");

		// Token: 0x04001EE9 RID: 7913
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sm2encrypt_with_sha384 = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm2encrypt.Branch("2.5");

		// Token: 0x04001EEA RID: 7914
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sm2encrypt_with_sha512 = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm2encrypt.Branch("2.6");

		// Token: 0x04001EEB RID: 7915
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sm2encrypt_with_rmd160 = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm2encrypt.Branch("2.7");

		// Token: 0x04001EEC RID: 7916
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sm2encrypt_with_whirlpool = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm2encrypt.Branch("2.8");

		// Token: 0x04001EED RID: 7917
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sm2encrypt_with_blake2b512 = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm2encrypt.Branch("2.9");

		// Token: 0x04001EEE RID: 7918
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sm2encrypt_with_blake2s256 = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm2encrypt.Branch("2.10");

		// Token: 0x04001EEF RID: 7919
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sm2encrypt_with_md5 = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm2encrypt.Branch("2.11");

		// Token: 0x04001EF0 RID: 7920
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_sm9PublicKey = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("302");

		// Token: 0x04001EF1 RID: 7921
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sm9sign = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("302.1");

		// Token: 0x04001EF2 RID: 7922
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sm9keyagreement = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("302.2");

		// Token: 0x04001EF3 RID: 7923
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sm9encrypt = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("302.3");

		// Token: 0x04001EF4 RID: 7924
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sm3 = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("401");

		// Token: 0x04001EF5 RID: 7925
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier hmac_sm3 = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm3.Branch("2");

		// Token: 0x04001EF6 RID: 7926
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sm2sign_with_sm3 = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("501");

		// Token: 0x04001EF7 RID: 7927
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sm2sign_with_sha1 = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("502");

		// Token: 0x04001EF8 RID: 7928
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sm2sign_with_sha256 = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("503");

		// Token: 0x04001EF9 RID: 7929
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sm2sign_with_sha512 = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("504");

		// Token: 0x04001EFA RID: 7930
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sm2sign_with_sha224 = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("505");

		// Token: 0x04001EFB RID: 7931
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sm2sign_with_sha384 = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("506");

		// Token: 0x04001EFC RID: 7932
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sm2sign_with_rmd160 = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("507");

		// Token: 0x04001EFD RID: 7933
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sm2sign_with_whirlpool = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("520");

		// Token: 0x04001EFE RID: 7934
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sm2sign_with_blake2b512 = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("521");

		// Token: 0x04001EFF RID: 7935
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier sm2sign_with_blake2s256 = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm_scheme.Branch("522");
	}
}
