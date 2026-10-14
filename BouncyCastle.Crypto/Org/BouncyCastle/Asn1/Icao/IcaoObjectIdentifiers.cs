using System;

namespace Org.BouncyCastle.Asn1.Icao
{
	// Token: 0x020006F3 RID: 1779
	public abstract class IcaoObjectIdentifiers
	{
		// Token: 0x04001E8D RID: 7821
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdIcao = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.23.136");

		// Token: 0x04001E8E RID: 7822
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdIcaoMrtd = global::Org.BouncyCastle.Asn1.Icao.IcaoObjectIdentifiers.IdIcao.Branch("1");

		// Token: 0x04001E8F RID: 7823
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdIcaoMrtdSecurity = global::Org.BouncyCastle.Asn1.Icao.IcaoObjectIdentifiers.IdIcaoMrtd.Branch("1");

		// Token: 0x04001E90 RID: 7824
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdIcaoLdsSecurityObject = global::Org.BouncyCastle.Asn1.Icao.IcaoObjectIdentifiers.IdIcaoMrtdSecurity.Branch("1");

		// Token: 0x04001E91 RID: 7825
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdIcaoCscaMasterList = global::Org.BouncyCastle.Asn1.Icao.IcaoObjectIdentifiers.IdIcaoMrtdSecurity.Branch("2");

		// Token: 0x04001E92 RID: 7826
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdIcaoCscaMasterListSigningKey = global::Org.BouncyCastle.Asn1.Icao.IcaoObjectIdentifiers.IdIcaoMrtdSecurity.Branch("3");

		// Token: 0x04001E93 RID: 7827
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdIcaoDocumentTypeList = global::Org.BouncyCastle.Asn1.Icao.IcaoObjectIdentifiers.IdIcaoMrtdSecurity.Branch("4");

		// Token: 0x04001E94 RID: 7828
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdIcaoAAProtocolObject = global::Org.BouncyCastle.Asn1.Icao.IcaoObjectIdentifiers.IdIcaoMrtdSecurity.Branch("5");

		// Token: 0x04001E95 RID: 7829
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdIcaoExtensions = global::Org.BouncyCastle.Asn1.Icao.IcaoObjectIdentifiers.IdIcaoMrtdSecurity.Branch("6");

		// Token: 0x04001E96 RID: 7830
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdIcaoExtensionsNamechangekeyrollover = global::Org.BouncyCastle.Asn1.Icao.IcaoObjectIdentifiers.IdIcaoExtensions.Branch("1");
	}
}
