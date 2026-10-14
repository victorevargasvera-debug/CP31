using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000333 RID: 819
	public abstract class HashAlgorithm
	{
		// Token: 0x06002225 RID: 8741 RVA: 0x00097560 File Offset: 0x00095760
		public static string GetName(byte hashAlgorithm)
		{
			switch (hashAlgorithm)
			{
			case 0:
				return "none";
			case 1:
				return "md5";
			case 2:
				return "sha1";
			case 3:
				return "sha224";
			case 4:
				return "sha256";
			case 5:
				return "sha384";
			case 6:
				return "sha512";
			default:
				return "UNKNOWN";
			}
		}

		// Token: 0x06002226 RID: 8742 RVA: 0x000975C0 File Offset: 0x000957C0
		public static string GetText(byte hashAlgorithm)
		{
			return global::Org.BouncyCastle.Crypto.Tls.HashAlgorithm.GetName(hashAlgorithm) + "(" + hashAlgorithm.ToString() + ")";
		}

		// Token: 0x06002227 RID: 8743 RVA: 0x000975DE File Offset: 0x000957DE
		public static bool IsPrivate(byte hashAlgorithm)
		{
			return 224 <= hashAlgorithm && hashAlgorithm <= byte.MaxValue;
		}

		// Token: 0x06002228 RID: 8744 RVA: 0x000975F5 File Offset: 0x000957F5
		public static bool IsRecognized(byte hashAlgorithm)
		{
			return hashAlgorithm - 1 <= 5;
		}

		// Token: 0x04000D71 RID: 3441
		public const byte none = 0;

		// Token: 0x04000D72 RID: 3442
		public const byte md5 = 1;

		// Token: 0x04000D73 RID: 3443
		public const byte sha1 = 2;

		// Token: 0x04000D74 RID: 3444
		public const byte sha224 = 3;

		// Token: 0x04000D75 RID: 3445
		public const byte sha256 = 4;

		// Token: 0x04000D76 RID: 3446
		public const byte sha384 = 5;

		// Token: 0x04000D77 RID: 3447
		public const byte sha512 = 6;
	}
}
