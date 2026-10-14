using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200033F RID: 831
	public abstract class PrfAlgorithm
	{
		// Token: 0x04000DC8 RID: 3528
		public const int tls_prf_legacy = 0;

		// Token: 0x04000DC9 RID: 3529
		public const int tls_prf_sha256 = 1;

		// Token: 0x04000DCA RID: 3530
		public const int tls_prf_sha384 = 2;
	}
}
