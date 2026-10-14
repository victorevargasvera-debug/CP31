using System;
using Org.BouncyCastle.Asn1.Pkcs;

namespace Org.BouncyCastle.Asn1.Esf
{
	// Token: 0x0200070C RID: 1804
	public abstract class EsfAttributes
	{
		// Token: 0x04001F27 RID: 7975
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SigPolicyId = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAAEtsSigPolicyID;

		// Token: 0x04001F28 RID: 7976
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier CommitmentType = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAAEtsCommitmentType;

		// Token: 0x04001F29 RID: 7977
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SignerLocation = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAAEtsSignerLocation;

		// Token: 0x04001F2A RID: 7978
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SignerAttr = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAAEtsSignerAttr;

		// Token: 0x04001F2B RID: 7979
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier OtherSigCert = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAAEtsOtherSigCert;

		// Token: 0x04001F2C RID: 7980
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ContentTimestamp = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAAEtsContentTimestamp;

		// Token: 0x04001F2D RID: 7981
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier CertificateRefs = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAAEtsCertificateRefs;

		// Token: 0x04001F2E RID: 7982
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier RevocationRefs = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAAEtsRevocationRefs;

		// Token: 0x04001F2F RID: 7983
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier CertValues = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAAEtsCertValues;

		// Token: 0x04001F30 RID: 7984
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier RevocationValues = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAAEtsRevocationValues;

		// Token: 0x04001F31 RID: 7985
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier EscTimeStamp = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAAEtsEscTimeStamp;

		// Token: 0x04001F32 RID: 7986
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier CertCrlTimestamp = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAAEtsCertCrlTimestamp;

		// Token: 0x04001F33 RID: 7987
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ArchiveTimestamp = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAAEtsArchiveTimestamp;

		// Token: 0x04001F34 RID: 7988
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ArchiveTimestampV2 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113549.1.9.16.2.48");
	}
}
