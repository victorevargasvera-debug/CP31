using System;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000DC RID: 220
	public abstract class PrfAlgorithm
	{
		// Token: 0x060007DD RID: 2013 RVA: 0x000213D0 File Offset: 0x0001F5D0
		public static string GetName(int prfAlgorithm)
		{
			switch (prfAlgorithm)
			{
			case 0:
				return "ssl_prf_legacy";
			case 1:
				return "tls_prf_legacy";
			case 2:
				return "tls_prf_sha256";
			case 3:
				return "tls_prf_sha384";
			case 4:
				return "tls13_hkdf_sha256";
			case 5:
				return "tls13_hkdf_sha384";
			case 7:
				return "tls13_hkdf_sm3";
			}
			return "UNKNOWN";
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x00021434 File Offset: 0x0001F634
		public static string GetText(int prfAlgorithm)
		{
			return global::Org.BouncyCastle.Tls.PrfAlgorithm.GetName(prfAlgorithm) + "(" + prfAlgorithm.ToString() + ")";
		}

		// Token: 0x040005FD RID: 1533
		public const int ssl_prf_legacy = 0;

		// Token: 0x040005FE RID: 1534
		public const int tls_prf_legacy = 1;

		// Token: 0x040005FF RID: 1535
		public const int tls_prf_sha256 = 2;

		// Token: 0x04000600 RID: 1536
		public const int tls_prf_sha384 = 3;

		// Token: 0x04000601 RID: 1537
		public const int tls13_hkdf_sha256 = 4;

		// Token: 0x04000602 RID: 1538
		public const int tls13_hkdf_sha384 = 5;

		// Token: 0x04000603 RID: 1539
		public const int tls13_hkdf_sm3 = 7;
	}
}
