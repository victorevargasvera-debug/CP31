using System;

namespace Org.BouncyCastle.Tls.Crypto
{
	// Token: 0x0200013C RID: 316
	public abstract class TlsCertificateRole
	{
		// Token: 0x040007C0 RID: 1984
		public const int DH = 1;

		// Token: 0x040007C1 RID: 1985
		public const int ECDH = 2;

		// Token: 0x040007C2 RID: 1986
		public const int RsaEncryption = 3;

		// Token: 0x040007C3 RID: 1987
		public const int Sm2Encryption = 4;
	}
}
