using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000310 RID: 784
	public abstract class ClientCertificateType
	{
		// Token: 0x04000CB5 RID: 3253
		public const byte rsa_sign = 1;

		// Token: 0x04000CB6 RID: 3254
		public const byte dss_sign = 2;

		// Token: 0x04000CB7 RID: 3255
		public const byte rsa_fixed_dh = 3;

		// Token: 0x04000CB8 RID: 3256
		public const byte dss_fixed_dh = 4;

		// Token: 0x04000CB9 RID: 3257
		public const byte rsa_ephemeral_dh_RESERVED = 5;

		// Token: 0x04000CBA RID: 3258
		public const byte dss_ephemeral_dh_RESERVED = 6;

		// Token: 0x04000CBB RID: 3259
		public const byte fortezza_dms_RESERVED = 20;

		// Token: 0x04000CBC RID: 3260
		public const byte ecdsa_sign = 64;

		// Token: 0x04000CBD RID: 3261
		public const byte rsa_fixed_ecdh = 65;

		// Token: 0x04000CBE RID: 3262
		public const byte ecdsa_fixed_ecdh = 66;
	}
}
