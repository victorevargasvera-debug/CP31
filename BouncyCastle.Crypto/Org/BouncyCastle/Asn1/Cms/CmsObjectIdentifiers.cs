using System;
using Org.BouncyCastle.Asn1.Pkcs;

namespace Org.BouncyCastle.Asn1.Cms
{
	// Token: 0x02000743 RID: 1859
	public abstract class CmsObjectIdentifiers
	{
		// Token: 0x04002013 RID: 8211
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Data = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Data;

		// Token: 0x04002014 RID: 8212
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SignedData = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.SignedData;

		// Token: 0x04002015 RID: 8213
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier EnvelopedData = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.EnvelopedData;

		// Token: 0x04002016 RID: 8214
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SignedAndEnvelopedData = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.SignedAndEnvelopedData;

		// Token: 0x04002017 RID: 8215
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier DigestedData = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.DigestedData;

		// Token: 0x04002018 RID: 8216
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier EncryptedData = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.EncryptedData;

		// Token: 0x04002019 RID: 8217
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier AuthenticatedData = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdCTAuthData;

		// Token: 0x0400201A RID: 8218
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier CompressedData = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdCTCompressedData;

		// Token: 0x0400201B RID: 8219
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier AuthEnvelopedData = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdCTAuthEnvelopedData;

		// Token: 0x0400201C RID: 8220
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier timestampedData = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdCTTimestampedData;

		// Token: 0x0400201D RID: 8221
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_ri = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.3.6.1.5.5.7.16");

		// Token: 0x0400201E RID: 8222
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_ri_ocsp_response = global::Org.BouncyCastle.Asn1.Cms.CmsObjectIdentifiers.id_ri.Branch("2");

		// Token: 0x0400201F RID: 8223
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id_ri_scvp = global::Org.BouncyCastle.Asn1.Cms.CmsObjectIdentifiers.id_ri.Branch("4");
	}
}
