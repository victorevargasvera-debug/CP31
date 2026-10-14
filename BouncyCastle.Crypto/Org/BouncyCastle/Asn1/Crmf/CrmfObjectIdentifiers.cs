using System;

namespace Org.BouncyCastle.Asn1.Crmf
{
	// Token: 0x0200072D RID: 1837
	public abstract class CrmfObjectIdentifiers
	{
		// Token: 0x04001FBE RID: 8126
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_pkix = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.3.6.1.5.5.7");

		// Token: 0x04001FBF RID: 8127
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_pkip = global::Org.BouncyCastle.Asn1.Crmf.CrmfObjectIdentifiers.id_pkix.Branch("5");

		// Token: 0x04001FC0 RID: 8128
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_regCtrl = global::Org.BouncyCastle.Asn1.Crmf.CrmfObjectIdentifiers.id_pkip.Branch("1");

		// Token: 0x04001FC1 RID: 8129
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_regCtrl_regToken = global::Org.BouncyCastle.Asn1.Crmf.CrmfObjectIdentifiers.id_regCtrl.Branch("1");

		// Token: 0x04001FC2 RID: 8130
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_regCtrl_authenticator = global::Org.BouncyCastle.Asn1.Crmf.CrmfObjectIdentifiers.id_regCtrl.Branch("2");

		// Token: 0x04001FC3 RID: 8131
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_regCtrl_pkiPublicationInfo = global::Org.BouncyCastle.Asn1.Crmf.CrmfObjectIdentifiers.id_regCtrl.Branch("3");

		// Token: 0x04001FC4 RID: 8132
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_regCtrl_pkiArchiveOptions = global::Org.BouncyCastle.Asn1.Crmf.CrmfObjectIdentifiers.id_regCtrl.Branch("4");

		// Token: 0x04001FC5 RID: 8133
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_ct_encKeyWithID = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.16.1.21");
	}
}
