using System;

namespace Org.BouncyCastle.Tls.Crypto
{
	// Token: 0x02000135 RID: 309
	public abstract class CryptoSignatureAlgorithm
	{
		// Token: 0x0400076D RID: 1901
		public const int rsa = 1;

		// Token: 0x0400076E RID: 1902
		public const int dsa = 2;

		// Token: 0x0400076F RID: 1903
		public const int ecdsa = 3;

		// Token: 0x04000770 RID: 1904
		public const int rsa_pss_rsae_sha256 = 4;

		// Token: 0x04000771 RID: 1905
		public const int rsa_pss_rsae_sha384 = 5;

		// Token: 0x04000772 RID: 1906
		public const int rsa_pss_rsae_sha512 = 6;

		// Token: 0x04000773 RID: 1907
		public const int ed25519 = 7;

		// Token: 0x04000774 RID: 1908
		public const int ed448 = 8;

		// Token: 0x04000775 RID: 1909
		public const int rsa_pss_pss_sha256 = 9;

		// Token: 0x04000776 RID: 1910
		public const int rsa_pss_pss_sha384 = 10;

		// Token: 0x04000777 RID: 1911
		public const int rsa_pss_pss_sha512 = 11;

		// Token: 0x04000778 RID: 1912
		public const int gostr34102012_256 = 64;

		// Token: 0x04000779 RID: 1913
		public const int gostr34102012_512 = 65;

		// Token: 0x0400077A RID: 1914
		public const int sm2 = 200;
	}
}
