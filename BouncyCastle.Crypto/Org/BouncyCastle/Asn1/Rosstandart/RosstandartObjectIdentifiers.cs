using System;

namespace Org.BouncyCastle.Asn1.Rosstandart
{
	// Token: 0x020006A7 RID: 1703
	public abstract class RosstandartObjectIdentifiers
	{
		// Token: 0x04001C4D RID: 7245
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier rosstandart = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.643.7");

		// Token: 0x04001C4E RID: 7246
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_tc26 = global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.rosstandart.Branch("1");

		// Token: 0x04001C4F RID: 7247
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_tc26_gost_3411_12_256 = global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26.Branch("1.2.2");

		// Token: 0x04001C50 RID: 7248
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_tc26_gost_3411_12_512 = global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26.Branch("1.2.3");

		// Token: 0x04001C51 RID: 7249
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_tc26_hmac_gost_3411_12_256 = global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26.Branch("1.4.1");

		// Token: 0x04001C52 RID: 7250
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_tc26_hmac_gost_3411_12_512 = global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26.Branch("1.4.2");

		// Token: 0x04001C53 RID: 7251
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_tc26_gost_3410_12_256 = global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26.Branch("1.1.1");

		// Token: 0x04001C54 RID: 7252
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_tc26_gost_3410_12_512 = global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26.Branch("1.1.2");

		// Token: 0x04001C55 RID: 7253
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_tc26_signwithdigest_gost_3410_12_256 = global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26.Branch("1.3.2");

		// Token: 0x04001C56 RID: 7254
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_tc26_signwithdigest_gost_3410_12_512 = global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26.Branch("1.3.3");

		// Token: 0x04001C57 RID: 7255
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_tc26_agreement = global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26.Branch("1.6");

		// Token: 0x04001C58 RID: 7256
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_tc26_agreement_gost_3410_12_256 = global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_agreement.Branch("1");

		// Token: 0x04001C59 RID: 7257
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_tc26_agreement_gost_3410_12_512 = global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_agreement.Branch("2");

		// Token: 0x04001C5A RID: 7258
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_tc26_gost_3410_12_256_paramSet = global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26.Branch("2.1.1");

		// Token: 0x04001C5B RID: 7259
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_tc26_gost_3410_12_256_paramSetA = global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_gost_3410_12_256_paramSet.Branch("1");

		// Token: 0x04001C5C RID: 7260
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_tc26_gost_3410_12_512_paramSet = global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26.Branch("2.1.2");

		// Token: 0x04001C5D RID: 7261
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_tc26_gost_3410_12_512_paramSetA = global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_gost_3410_12_512_paramSet.Branch("1");

		// Token: 0x04001C5E RID: 7262
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_tc26_gost_3410_12_512_paramSetB = global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_gost_3410_12_512_paramSet.Branch("2");

		// Token: 0x04001C5F RID: 7263
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_tc26_gost_3410_12_512_paramSetC = global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_gost_3410_12_512_paramSet.Branch("3");

		// Token: 0x04001C60 RID: 7264
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_tc26_gost_28147_param_Z = global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26.Branch("2.5.1.1");
	}
}
