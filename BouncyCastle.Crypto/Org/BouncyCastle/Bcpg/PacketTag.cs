using System;

namespace Org.BouncyCastle.Bcpg
{
	// Token: 0x02000583 RID: 1411
	public enum PacketTag
	{
		// Token: 0x040017FA RID: 6138
		Reserved,
		// Token: 0x040017FB RID: 6139
		PublicKeyEncryptedSession,
		// Token: 0x040017FC RID: 6140
		Signature,
		// Token: 0x040017FD RID: 6141
		SymmetricKeyEncryptedSessionKey,
		// Token: 0x040017FE RID: 6142
		OnePassSignature,
		// Token: 0x040017FF RID: 6143
		SecretKey,
		// Token: 0x04001800 RID: 6144
		PublicKey,
		// Token: 0x04001801 RID: 6145
		SecretSubkey,
		// Token: 0x04001802 RID: 6146
		CompressedData,
		// Token: 0x04001803 RID: 6147
		SymmetricKeyEncrypted,
		// Token: 0x04001804 RID: 6148
		Marker,
		// Token: 0x04001805 RID: 6149
		LiteralData,
		// Token: 0x04001806 RID: 6150
		Trust,
		// Token: 0x04001807 RID: 6151
		UserId,
		// Token: 0x04001808 RID: 6152
		PublicSubkey,
		// Token: 0x04001809 RID: 6153
		UserAttribute = 17,
		// Token: 0x0400180A RID: 6154
		SymmetricEncryptedIntegrityProtected,
		// Token: 0x0400180B RID: 6155
		ModificationDetectionCode,
		// Token: 0x0400180C RID: 6156
		Experimental1 = 60,
		// Token: 0x0400180D RID: 6157
		Experimental2,
		// Token: 0x0400180E RID: 6158
		Experimental3,
		// Token: 0x0400180F RID: 6159
		Experimental4
	}
}
