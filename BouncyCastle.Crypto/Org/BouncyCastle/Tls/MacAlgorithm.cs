using System;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000D4 RID: 212
	public abstract class MacAlgorithm
	{
		// Token: 0x060007A5 RID: 1957 RVA: 0x0002076C File Offset: 0x0001E96C
		public static string GetName(int macAlgorithm)
		{
			switch (macAlgorithm)
			{
			case 0:
				return "null";
			case 1:
				return "hmac_md5";
			case 2:
				return "hmac_sha1";
			case 3:
				return "hmac_sha256";
			case 4:
				return "hmac_sha384";
			case 5:
				return "hmac_sha512";
			default:
				return "UNKNOWN";
			}
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x000207C2 File Offset: 0x0001E9C2
		public static string GetText(int macAlgorithm)
		{
			return global::Org.BouncyCastle.Tls.MacAlgorithm.GetName(macAlgorithm) + "(" + macAlgorithm.ToString() + ")";
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x000207E0 File Offset: 0x0001E9E0
		public static bool IsHmac(int macAlgorithm)
		{
			return macAlgorithm - 1 <= 4;
		}

		// Token: 0x040005B4 RID: 1460
		public const int cls_null = 0;

		// Token: 0x040005B5 RID: 1461
		public const int md5 = 1;

		// Token: 0x040005B6 RID: 1462
		public const int sha = 2;

		// Token: 0x040005B7 RID: 1463
		public const int hmac_md5 = 1;

		// Token: 0x040005B8 RID: 1464
		public const int hmac_sha1 = 2;

		// Token: 0x040005B9 RID: 1465
		public const int hmac_sha256 = 3;

		// Token: 0x040005BA RID: 1466
		public const int hmac_sha384 = 4;

		// Token: 0x040005BB RID: 1467
		public const int hmac_sha512 = 5;
	}
}
