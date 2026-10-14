using System;

namespace Org.BouncyCastle.Bcpg
{
	// Token: 0x02000590 RID: 1424
	public enum SignatureSubpacketTag
	{
		// Token: 0x0400185F RID: 6239
		CreationTime = 2,
		// Token: 0x04001860 RID: 6240
		ExpireTime,
		// Token: 0x04001861 RID: 6241
		Exportable,
		// Token: 0x04001862 RID: 6242
		TrustSig,
		// Token: 0x04001863 RID: 6243
		RegExp,
		// Token: 0x04001864 RID: 6244
		Revocable,
		// Token: 0x04001865 RID: 6245
		KeyExpireTime = 9,
		// Token: 0x04001866 RID: 6246
		Placeholder,
		// Token: 0x04001867 RID: 6247
		PreferredSymmetricAlgorithms,
		// Token: 0x04001868 RID: 6248
		RevocationKey,
		// Token: 0x04001869 RID: 6249
		IssuerKeyId = 16,
		// Token: 0x0400186A RID: 6250
		NotationData = 20,
		// Token: 0x0400186B RID: 6251
		PreferredHashAlgorithms,
		// Token: 0x0400186C RID: 6252
		PreferredCompressionAlgorithms,
		// Token: 0x0400186D RID: 6253
		KeyServerPreferences,
		// Token: 0x0400186E RID: 6254
		PreferredKeyServer,
		// Token: 0x0400186F RID: 6255
		PrimaryUserId,
		// Token: 0x04001870 RID: 6256
		PolicyUrl,
		// Token: 0x04001871 RID: 6257
		KeyFlags,
		// Token: 0x04001872 RID: 6258
		SignerUserId,
		// Token: 0x04001873 RID: 6259
		RevocationReason,
		// Token: 0x04001874 RID: 6260
		Features,
		// Token: 0x04001875 RID: 6261
		SignatureTarget,
		// Token: 0x04001876 RID: 6262
		EmbeddedSignature
	}
}
