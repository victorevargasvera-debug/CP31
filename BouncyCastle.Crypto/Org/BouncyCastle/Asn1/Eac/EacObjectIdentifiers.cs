using System;

namespace Org.BouncyCastle.Asn1.Eac
{
	// Token: 0x0200071D RID: 1821
	public abstract class EacObjectIdentifiers
	{
		// Token: 0x06004184 RID: 16772 RVA: 0x001286B8 File Offset: 0x001268B8
		// Note: this type is marked as 'beforefieldinit'.
		static EacObjectIdentifiers()
		{
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier derObjectIdentifier = global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.bsi_de;
			global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_PK = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((derObjectIdentifier != null) ? derObjectIdentifier.ToString() : null) + ".2.2.1");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier derObjectIdentifier2 = global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_PK;
			global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_PK_DH = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((derObjectIdentifier2 != null) ? derObjectIdentifier2.ToString() : null) + ".1");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier derObjectIdentifier3 = global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_PK;
			global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_PK_ECDH = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((derObjectIdentifier3 != null) ? derObjectIdentifier3.ToString() : null) + ".2");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier derObjectIdentifier4 = global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.bsi_de;
			global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_CA = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((derObjectIdentifier4 != null) ? derObjectIdentifier4.ToString() : null) + ".2.2.3");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier derObjectIdentifier5 = global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_CA;
			global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_CA_DH = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((derObjectIdentifier5 != null) ? derObjectIdentifier5.ToString() : null) + ".1");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier derObjectIdentifier6 = global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_CA_DH;
			global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_CA_DH_3DES_CBC_CBC = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((derObjectIdentifier6 != null) ? derObjectIdentifier6.ToString() : null) + ".1");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier derObjectIdentifier7 = global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_CA;
			global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_CA_ECDH = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((derObjectIdentifier7 != null) ? derObjectIdentifier7.ToString() : null) + ".2");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier derObjectIdentifier8 = global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_CA_ECDH;
			global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_CA_ECDH_3DES_CBC_CBC = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((derObjectIdentifier8 != null) ? derObjectIdentifier8.ToString() : null) + ".1");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier derObjectIdentifier9 = global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.bsi_de;
			global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((derObjectIdentifier9 != null) ? derObjectIdentifier9.ToString() : null) + ".2.2.2");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier derObjectIdentifier10 = global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA;
			global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_RSA = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((derObjectIdentifier10 != null) ? derObjectIdentifier10.ToString() : null) + ".1");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier derObjectIdentifier11 = global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_RSA;
			global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_RSA_v1_5_SHA_1 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((derObjectIdentifier11 != null) ? derObjectIdentifier11.ToString() : null) + ".1");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier derObjectIdentifier12 = global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_RSA;
			global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_RSA_v1_5_SHA_256 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((derObjectIdentifier12 != null) ? derObjectIdentifier12.ToString() : null) + ".2");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier derObjectIdentifier13 = global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_RSA;
			global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_RSA_PSS_SHA_1 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((derObjectIdentifier13 != null) ? derObjectIdentifier13.ToString() : null) + ".3");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier derObjectIdentifier14 = global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_RSA;
			global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_RSA_PSS_SHA_256 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((derObjectIdentifier14 != null) ? derObjectIdentifier14.ToString() : null) + ".4");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier derObjectIdentifier15 = global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA;
			global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_ECDSA = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((derObjectIdentifier15 != null) ? derObjectIdentifier15.ToString() : null) + ".2");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier derObjectIdentifier16 = global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_ECDSA;
			global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_ECDSA_SHA_1 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((derObjectIdentifier16 != null) ? derObjectIdentifier16.ToString() : null) + ".1");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier derObjectIdentifier17 = global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_ECDSA;
			global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_ECDSA_SHA_224 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((derObjectIdentifier17 != null) ? derObjectIdentifier17.ToString() : null) + ".2");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier derObjectIdentifier18 = global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_ECDSA;
			global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_ECDSA_SHA_256 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((derObjectIdentifier18 != null) ? derObjectIdentifier18.ToString() : null) + ".3");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier derObjectIdentifier19 = global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_ECDSA;
			global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_ECDSA_SHA_384 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((derObjectIdentifier19 != null) ? derObjectIdentifier19.ToString() : null) + ".4");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier derObjectIdentifier20 = global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_ECDSA;
			global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_ECDSA_SHA_512 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((derObjectIdentifier20 != null) ? derObjectIdentifier20.ToString() : null) + ".5");
		}

		// Token: 0x04001F59 RID: 8025
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier bsi_de = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("0.4.0.127.0.7");

		// Token: 0x04001F5A RID: 8026
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_PK;

		// Token: 0x04001F5B RID: 8027
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_PK_DH;

		// Token: 0x04001F5C RID: 8028
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_PK_ECDH;

		// Token: 0x04001F5D RID: 8029
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_CA;

		// Token: 0x04001F5E RID: 8030
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_CA_DH;

		// Token: 0x04001F5F RID: 8031
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_CA_DH_3DES_CBC_CBC;

		// Token: 0x04001F60 RID: 8032
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_CA_ECDH;

		// Token: 0x04001F61 RID: 8033
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_CA_ECDH_3DES_CBC_CBC;

		// Token: 0x04001F62 RID: 8034
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_TA;

		// Token: 0x04001F63 RID: 8035
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_TA_RSA;

		// Token: 0x04001F64 RID: 8036
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_TA_RSA_v1_5_SHA_1;

		// Token: 0x04001F65 RID: 8037
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_TA_RSA_v1_5_SHA_256;

		// Token: 0x04001F66 RID: 8038
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_TA_RSA_PSS_SHA_1;

		// Token: 0x04001F67 RID: 8039
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_TA_RSA_PSS_SHA_256;

		// Token: 0x04001F68 RID: 8040
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_TA_ECDSA;

		// Token: 0x04001F69 RID: 8041
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_TA_ECDSA_SHA_1;

		// Token: 0x04001F6A RID: 8042
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_TA_ECDSA_SHA_224;

		// Token: 0x04001F6B RID: 8043
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_TA_ECDSA_SHA_256;

		// Token: 0x04001F6C RID: 8044
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_TA_ECDSA_SHA_384;

		// Token: 0x04001F6D RID: 8045
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_TA_ECDSA_SHA_512;
	}
}
