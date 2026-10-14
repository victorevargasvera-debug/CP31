using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200034A RID: 842
	public abstract class SignatureAlgorithm
	{
		// Token: 0x04000E0D RID: 3597
		public const byte anonymous = 0;

		// Token: 0x04000E0E RID: 3598
		public const byte rsa = 1;

		// Token: 0x04000E0F RID: 3599
		public const byte dsa = 2;

		// Token: 0x04000E10 RID: 3600
		public const byte ecdsa = 3;
	}
}
