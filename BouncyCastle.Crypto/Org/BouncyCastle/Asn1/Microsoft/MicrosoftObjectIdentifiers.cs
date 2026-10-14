using System;

namespace Org.BouncyCastle.Asn1.Microsoft
{
	// Token: 0x020006E3 RID: 1763
	public abstract class MicrosoftObjectIdentifiers
	{
		// Token: 0x04001E3C RID: 7740
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Microsoft = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.3.6.1.4.1.311");

		// Token: 0x04001E3D RID: 7741
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier MicrosoftCertTemplateV1 = global::Org.BouncyCastle.Asn1.Microsoft.MicrosoftObjectIdentifiers.Microsoft.Branch("20.2");

		// Token: 0x04001E3E RID: 7742
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier MicrosoftCAVersion = global::Org.BouncyCastle.Asn1.Microsoft.MicrosoftObjectIdentifiers.Microsoft.Branch("21.1");

		// Token: 0x04001E3F RID: 7743
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier MicrosoftPrevCACertHash = global::Org.BouncyCastle.Asn1.Microsoft.MicrosoftObjectIdentifiers.Microsoft.Branch("21.2");

		// Token: 0x04001E40 RID: 7744
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier MicrosoftCrlNextPublish = global::Org.BouncyCastle.Asn1.Microsoft.MicrosoftObjectIdentifiers.Microsoft.Branch("21.4");

		// Token: 0x04001E41 RID: 7745
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier MicrosoftCertTemplateV2 = global::Org.BouncyCastle.Asn1.Microsoft.MicrosoftObjectIdentifiers.Microsoft.Branch("21.7");

		// Token: 0x04001E42 RID: 7746
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier MicrosoftAppPolicies = global::Org.BouncyCastle.Asn1.Microsoft.MicrosoftObjectIdentifiers.Microsoft.Branch("21.10");
	}
}
