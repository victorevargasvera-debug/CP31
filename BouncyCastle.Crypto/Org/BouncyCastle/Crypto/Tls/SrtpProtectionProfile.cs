using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000350 RID: 848
	public abstract class SrtpProtectionProfile
	{
		// Token: 0x04000E1E RID: 3614
		public const int SRTP_AES128_CM_HMAC_SHA1_80 = 1;

		// Token: 0x04000E1F RID: 3615
		public const int SRTP_AES128_CM_HMAC_SHA1_32 = 2;

		// Token: 0x04000E20 RID: 3616
		public const int SRTP_NULL_HMAC_SHA1_80 = 5;

		// Token: 0x04000E21 RID: 3617
		public const int SRTP_NULL_HMAC_SHA1_32 = 6;

		// Token: 0x04000E22 RID: 3618
		public const int SRTP_AEAD_AES_128_GCM = 7;

		// Token: 0x04000E23 RID: 3619
		public const int SRTP_AEAD_AES_256_GCM = 8;
	}
}
