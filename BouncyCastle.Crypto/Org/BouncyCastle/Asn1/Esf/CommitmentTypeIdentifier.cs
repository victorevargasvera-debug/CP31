using System;
using Org.BouncyCastle.Asn1.Pkcs;

namespace Org.BouncyCastle.Asn1.Esf
{
	// Token: 0x02000703 RID: 1795
	public abstract class CommitmentTypeIdentifier
	{
		// Token: 0x04001F12 RID: 7954
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ProofOfOrigin = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdCtiEtsProofOfOrigin;

		// Token: 0x04001F13 RID: 7955
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ProofOfReceipt = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdCtiEtsProofOfReceipt;

		// Token: 0x04001F14 RID: 7956
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ProofOfDelivery = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdCtiEtsProofOfDelivery;

		// Token: 0x04001F15 RID: 7957
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ProofOfSender = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdCtiEtsProofOfSender;

		// Token: 0x04001F16 RID: 7958
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ProofOfApproval = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdCtiEtsProofOfApproval;

		// Token: 0x04001F17 RID: 7959
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ProofOfCreation = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdCtiEtsProofOfCreation;
	}
}
