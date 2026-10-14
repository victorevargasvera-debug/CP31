using System;
using Org.BouncyCastle.Asn1.Pkcs;

namespace Org.BouncyCastle.Asn1.Cms
{
	// Token: 0x02000742 RID: 1858
	public abstract class CmsAttributes
	{
		// Token: 0x0400200E RID: 8206
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ContentType = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs9AtContentType;

		// Token: 0x0400200F RID: 8207
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier MessageDigest = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs9AtMessageDigest;

		// Token: 0x04002010 RID: 8208
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SigningTime = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs9AtSigningTime;

		// Token: 0x04002011 RID: 8209
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier CounterSignature = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs9AtCounterSignature;

		// Token: 0x04002012 RID: 8210
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ContentHint = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAAContentHint;
	}
}
