using System;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000ED RID: 237
	public class SignatureAlgorithm
	{
		// Token: 0x0600089F RID: 2207 RVA: 0x00022EAC File Offset: 0x000210AC
		public static short GetClientCertificateType(short signatureAlgorithm)
		{
			switch (signatureAlgorithm)
			{
			case 1:
			case 4:
			case 5:
			case 6:
			case 9:
			case 10:
			case 11:
				return 1;
			case 2:
				return 2;
			case 3:
			case 7:
			case 8:
				return 64;
			default:
				if (signatureAlgorithm == 64)
				{
					return 67;
				}
				if (signatureAlgorithm != 65)
				{
					return -1;
				}
				return 68;
			}
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x00022F08 File Offset: 0x00021108
		public static string GetName(short signatureAlgorithm)
		{
			switch (signatureAlgorithm)
			{
			case 0:
				return "anonymous";
			case 1:
				return "rsa";
			case 2:
				return "dsa";
			case 3:
				return "ecdsa";
			case 4:
				return "rsa_pss_rsae_sha256";
			case 5:
				return "rsa_pss_rsae_sha384";
			case 6:
				return "rsa_pss_rsae_sha512";
			case 7:
				return "ed25519";
			case 8:
				return "ed448";
			case 9:
				return "rsa_pss_pss_sha256";
			case 10:
				return "rsa_pss_pss_sha384";
			case 11:
				return "rsa_pss_pss_sha512";
			case 12:
			case 13:
			case 14:
			case 15:
			case 16:
			case 17:
			case 18:
			case 19:
			case 20:
			case 21:
			case 22:
			case 23:
			case 24:
			case 25:
				break;
			case 26:
				return "ecdsa_brainpoolP256r1tls13_sha256";
			case 27:
				return "ecdsa_brainpoolP384r1tls13_sha384";
			case 28:
				return "ecdsa_brainpoolP512r1tls13_sha512";
			default:
				if (signatureAlgorithm == 64)
				{
					return "gostr34102012_256";
				}
				if (signatureAlgorithm == 65)
				{
					return "gostr34102012_512";
				}
				break;
			}
			return "UNKNOWN";
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x00023006 File Offset: 0x00021206
		public static string GetText(short signatureAlgorithm)
		{
			return global::Org.BouncyCastle.Tls.SignatureAlgorithm.GetName(signatureAlgorithm) + "(" + signatureAlgorithm.ToString() + ")";
		}

		// Token: 0x04000688 RID: 1672
		public const short anonymous = 0;

		// Token: 0x04000689 RID: 1673
		public const short rsa = 1;

		// Token: 0x0400068A RID: 1674
		public const short dsa = 2;

		// Token: 0x0400068B RID: 1675
		public const short ecdsa = 3;

		// Token: 0x0400068C RID: 1676
		public const short ed25519 = 7;

		// Token: 0x0400068D RID: 1677
		public const short ed448 = 8;

		// Token: 0x0400068E RID: 1678
		public const short rsa_pss_rsae_sha256 = 4;

		// Token: 0x0400068F RID: 1679
		public const short rsa_pss_rsae_sha384 = 5;

		// Token: 0x04000690 RID: 1680
		public const short rsa_pss_rsae_sha512 = 6;

		// Token: 0x04000691 RID: 1681
		public const short rsa_pss_pss_sha256 = 9;

		// Token: 0x04000692 RID: 1682
		public const short rsa_pss_pss_sha384 = 10;

		// Token: 0x04000693 RID: 1683
		public const short rsa_pss_pss_sha512 = 11;

		// Token: 0x04000694 RID: 1684
		public const short ecdsa_brainpoolP256r1tls13_sha256 = 26;

		// Token: 0x04000695 RID: 1685
		public const short ecdsa_brainpoolP384r1tls13_sha384 = 27;

		// Token: 0x04000696 RID: 1686
		public const short ecdsa_brainpoolP512r1tls13_sha512 = 28;

		// Token: 0x04000697 RID: 1687
		public const short gostr34102012_256 = 64;

		// Token: 0x04000698 RID: 1688
		public const short gostr34102012_512 = 65;
	}
}
