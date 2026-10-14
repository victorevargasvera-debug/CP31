using System;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000CB RID: 203
	public abstract class HashAlgorithm
	{
		// Token: 0x0600077B RID: 1915 RVA: 0x00020260 File Offset: 0x0001E460
		public static string GetName(short hashAlgorithm)
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
			case 8:
				return "Intrinsic";
			}
			return "UNKNOWN";
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x000202CE File Offset: 0x0001E4CE
		public static int GetOutputSize(short hashAlgorithm)
		{
			switch (hashAlgorithm)
			{
			case 1:
				return 16;
			case 2:
				return 20;
			case 3:
				return 28;
			case 4:
				return 32;
			case 5:
				return 48;
			case 6:
				return 64;
			default:
				return -1;
			}
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x00020305 File Offset: 0x0001E505
		public static string GetText(short hashAlgorithm)
		{
			return global::Org.BouncyCastle.Tls.HashAlgorithm.GetName(hashAlgorithm) + "(" + hashAlgorithm.ToString() + ")";
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x00020323 File Offset: 0x0001E523
		public static bool IsPrivate(short hashAlgorithm)
		{
			return 224 <= hashAlgorithm && hashAlgorithm <= 255;
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x0002033A File Offset: 0x0001E53A
		public static bool IsRecognized(short hashAlgorithm)
		{
			return hashAlgorithm - 1 <= 5 || hashAlgorithm == 8;
		}

		// Token: 0x04000582 RID: 1410
		public const short none = 0;

		// Token: 0x04000583 RID: 1411
		public const short md5 = 1;

		// Token: 0x04000584 RID: 1412
		public const short sha1 = 2;

		// Token: 0x04000585 RID: 1413
		public const short sha224 = 3;

		// Token: 0x04000586 RID: 1414
		public const short sha256 = 4;

		// Token: 0x04000587 RID: 1415
		public const short sha384 = 5;

		// Token: 0x04000588 RID: 1416
		public const short sha512 = 6;

		// Token: 0x04000589 RID: 1417
		public const short Intrinsic = 8;
	}
}
