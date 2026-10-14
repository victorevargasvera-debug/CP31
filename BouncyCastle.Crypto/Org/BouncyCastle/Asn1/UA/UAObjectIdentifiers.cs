using System;

namespace Org.BouncyCastle.Asn1.UA
{
	// Token: 0x02000696 RID: 1686
	public abstract class UAObjectIdentifiers
	{
		// Token: 0x04001BAF RID: 7087
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier UaOid = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.804.2.1.1.1");

		// Token: 0x04001BB0 RID: 7088
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier dstu4145le = global::Org.BouncyCastle.Asn1.UA.UAObjectIdentifiers.UaOid.Branch("1.3.1.1");

		// Token: 0x04001BB1 RID: 7089
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier dstu4145be = global::Org.BouncyCastle.Asn1.UA.UAObjectIdentifiers.UaOid.Branch("1.3.1.1.1.1");

		// Token: 0x04001BB2 RID: 7090
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier dstu7564digest_256 = global::Org.BouncyCastle.Asn1.UA.UAObjectIdentifiers.UaOid.Branch("1.2.2.1");

		// Token: 0x04001BB3 RID: 7091
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier dstu7564digest_384 = global::Org.BouncyCastle.Asn1.UA.UAObjectIdentifiers.UaOid.Branch("1.2.2.2");

		// Token: 0x04001BB4 RID: 7092
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier dstu7564digest_512 = global::Org.BouncyCastle.Asn1.UA.UAObjectIdentifiers.UaOid.Branch("1.2.2.3");

		// Token: 0x04001BB5 RID: 7093
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier dstu7564mac_256 = global::Org.BouncyCastle.Asn1.UA.UAObjectIdentifiers.UaOid.Branch("1.2.2.4");

		// Token: 0x04001BB6 RID: 7094
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier dstu7564mac_384 = global::Org.BouncyCastle.Asn1.UA.UAObjectIdentifiers.UaOid.Branch("1.2.2.5");

		// Token: 0x04001BB7 RID: 7095
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier dstu7564mac_512 = global::Org.BouncyCastle.Asn1.UA.UAObjectIdentifiers.UaOid.Branch("1.2.2.6");

		// Token: 0x04001BB8 RID: 7096
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier dstu7624ecb_128 = global::Org.BouncyCastle.Asn1.UA.UAObjectIdentifiers.UaOid.Branch("1.1.3.1.1");

		// Token: 0x04001BB9 RID: 7097
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier dstu7624ecb_256 = global::Org.BouncyCastle.Asn1.UA.UAObjectIdentifiers.UaOid.Branch("1.1.3.1.2");

		// Token: 0x04001BBA RID: 7098
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier dstu7624ecb_512 = global::Org.BouncyCastle.Asn1.UA.UAObjectIdentifiers.UaOid.Branch("1.1.3.1.3");

		// Token: 0x04001BBB RID: 7099
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier dstu7624ctr_128 = global::Org.BouncyCastle.Asn1.UA.UAObjectIdentifiers.UaOid.Branch("1.1.3.2.1");

		// Token: 0x04001BBC RID: 7100
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier dstu7624ctr_256 = global::Org.BouncyCastle.Asn1.UA.UAObjectIdentifiers.UaOid.Branch("1.1.3.2.2");

		// Token: 0x04001BBD RID: 7101
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier dstu7624ctr_512 = global::Org.BouncyCastle.Asn1.UA.UAObjectIdentifiers.UaOid.Branch("1.1.3.2.3");

		// Token: 0x04001BBE RID: 7102
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier dstu7624cfb_128 = global::Org.BouncyCastle.Asn1.UA.UAObjectIdentifiers.UaOid.Branch("1.1.3.3.1");

		// Token: 0x04001BBF RID: 7103
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier dstu7624cfb_256 = global::Org.BouncyCastle.Asn1.UA.UAObjectIdentifiers.UaOid.Branch("1.1.3.3.2");

		// Token: 0x04001BC0 RID: 7104
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier dstu7624cfb_512 = global::Org.BouncyCastle.Asn1.UA.UAObjectIdentifiers.UaOid.Branch("1.1.3.3.3");

		// Token: 0x04001BC1 RID: 7105
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier dstu7624cmac_128 = global::Org.BouncyCastle.Asn1.UA.UAObjectIdentifiers.UaOid.Branch("1.1.3.4.1");

		// Token: 0x04001BC2 RID: 7106
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier dstu7624cmac_256 = global::Org.BouncyCastle.Asn1.UA.UAObjectIdentifiers.UaOid.Branch("1.1.3.4.2");

		// Token: 0x04001BC3 RID: 7107
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier dstu7624cmac_512 = global::Org.BouncyCastle.Asn1.UA.UAObjectIdentifiers.UaOid.Branch("1.1.3.4.3");

		// Token: 0x04001BC4 RID: 7108
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier dstu7624cbc_128 = global::Org.BouncyCastle.Asn1.UA.UAObjectIdentifiers.UaOid.Branch("1.1.3.5.1");

		// Token: 0x04001BC5 RID: 7109
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier dstu7624cbc_256 = global::Org.BouncyCastle.Asn1.UA.UAObjectIdentifiers.UaOid.Branch("1.1.3.5.2");

		// Token: 0x04001BC6 RID: 7110
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier dstu7624cbc_512 = global::Org.BouncyCastle.Asn1.UA.UAObjectIdentifiers.UaOid.Branch("1.1.3.5.3");

		// Token: 0x04001BC7 RID: 7111
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier dstu7624ofb_128 = global::Org.BouncyCastle.Asn1.UA.UAObjectIdentifiers.UaOid.Branch("1.1.3.6.1");

		// Token: 0x04001BC8 RID: 7112
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier dstu7624ofb_256 = global::Org.BouncyCastle.Asn1.UA.UAObjectIdentifiers.UaOid.Branch("1.1.3.6.2");

		// Token: 0x04001BC9 RID: 7113
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier dstu7624ofb_512 = global::Org.BouncyCastle.Asn1.UA.UAObjectIdentifiers.UaOid.Branch("1.1.3.6.3");

		// Token: 0x04001BCA RID: 7114
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier dstu7624gmac_128 = global::Org.BouncyCastle.Asn1.UA.UAObjectIdentifiers.UaOid.Branch("1.1.3.7.1");

		// Token: 0x04001BCB RID: 7115
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier dstu7624gmac_256 = global::Org.BouncyCastle.Asn1.UA.UAObjectIdentifiers.UaOid.Branch("1.1.3.7.2");

		// Token: 0x04001BCC RID: 7116
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier dstu7624gmac_512 = global::Org.BouncyCastle.Asn1.UA.UAObjectIdentifiers.UaOid.Branch("1.1.3.7.3");

		// Token: 0x04001BCD RID: 7117
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier dstu7624ccm_128 = global::Org.BouncyCastle.Asn1.UA.UAObjectIdentifiers.UaOid.Branch("1.1.3.8.1");

		// Token: 0x04001BCE RID: 7118
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier dstu7624ccm_256 = global::Org.BouncyCastle.Asn1.UA.UAObjectIdentifiers.UaOid.Branch("1.1.3.8.2");

		// Token: 0x04001BCF RID: 7119
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier dstu7624ccm_512 = global::Org.BouncyCastle.Asn1.UA.UAObjectIdentifiers.UaOid.Branch("1.1.3.8.3");

		// Token: 0x04001BD0 RID: 7120
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier dstu7624xts_128 = global::Org.BouncyCastle.Asn1.UA.UAObjectIdentifiers.UaOid.Branch("1.1.3.9.1");

		// Token: 0x04001BD1 RID: 7121
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier dstu7624xts_256 = global::Org.BouncyCastle.Asn1.UA.UAObjectIdentifiers.UaOid.Branch("1.1.3.9.2");

		// Token: 0x04001BD2 RID: 7122
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier dstu7624xts_512 = global::Org.BouncyCastle.Asn1.UA.UAObjectIdentifiers.UaOid.Branch("1.1.3.9.3");

		// Token: 0x04001BD3 RID: 7123
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier dstu7624kw_128 = global::Org.BouncyCastle.Asn1.UA.UAObjectIdentifiers.UaOid.Branch("1.1.3.10.1");

		// Token: 0x04001BD4 RID: 7124
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier dstu7624kw_256 = global::Org.BouncyCastle.Asn1.UA.UAObjectIdentifiers.UaOid.Branch("1.1.3.10.2");

		// Token: 0x04001BD5 RID: 7125
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier dstu7624kw_512 = global::Org.BouncyCastle.Asn1.UA.UAObjectIdentifiers.UaOid.Branch("1.1.3.10.3");
	}
}
