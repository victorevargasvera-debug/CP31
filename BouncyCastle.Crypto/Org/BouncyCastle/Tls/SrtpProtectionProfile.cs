using System;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000F3 RID: 243
	public abstract class SrtpProtectionProfile
	{
		// Token: 0x040006C7 RID: 1735
		public const int SRTP_AES128_CM_HMAC_SHA1_80 = 1;

		// Token: 0x040006C8 RID: 1736
		public const int SRTP_AES128_CM_HMAC_SHA1_32 = 2;

		// Token: 0x040006C9 RID: 1737
		public const int SRTP_NULL_HMAC_SHA1_80 = 5;

		// Token: 0x040006CA RID: 1738
		public const int SRTP_NULL_HMAC_SHA1_32 = 6;

		// Token: 0x040006CB RID: 1739
		public const int SRTP_AEAD_AES_128_GCM = 7;

		// Token: 0x040006CC RID: 1740
		public const int SRTP_AEAD_AES_256_GCM = 8;
	}
}
