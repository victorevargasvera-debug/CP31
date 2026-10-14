using System;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000EF RID: 239
	public abstract class SignatureScheme
	{
		// Token: 0x060008B0 RID: 2224 RVA: 0x00023328 File Offset: 0x00021528
		public static int From(global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm sigAndHashAlg)
		{
			if (sigAndHashAlg == null)
			{
				throw new global::System.ArgumentNullException();
			}
			return global::Org.BouncyCastle.Tls.SignatureScheme.From(sigAndHashAlg.Hash, sigAndHashAlg.Signature);
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x00023344 File Offset: 0x00021544
		public static int From(short hashAlgorithm, short signatureAlgorithm)
		{
			return (int)(hashAlgorithm & 255) << 8 | (int)(signatureAlgorithm & 255);
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x00023358 File Offset: 0x00021558
		public static int GetCryptoHashAlgorithm(int signatureScheme)
		{
			if (signatureScheme != 1800)
			{
				switch (signatureScheme)
				{
				case 2052:
				case 2057:
					break;
				case 2053:
				case 2058:
					return 5;
				case 2054:
				case 2059:
					return 6;
				case 2055:
				case 2056:
					return -1;
				default:
					switch (signatureScheme)
					{
					case 2074:
						break;
					case 2075:
						return 5;
					case 2076:
						return 6;
					default:
					{
						short hashAlgorithm = global::Org.BouncyCastle.Tls.SignatureScheme.GetHashAlgorithm(signatureScheme);
						if (8 == hashAlgorithm || !global::Org.BouncyCastle.Tls.HashAlgorithm.IsRecognized(hashAlgorithm))
						{
							return -1;
						}
						return global::Org.BouncyCastle.Tls.Crypto.TlsCryptoUtilities.GetHash(global::Org.BouncyCastle.Tls.SignatureScheme.GetHashAlgorithm(signatureScheme));
					}
					}
					break;
				}
				return 4;
			}
			return 7;
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x000233E0 File Offset: 0x000215E0
		public static string GetName(int signatureScheme)
		{
			if (signatureScheme <= 1281)
			{
				if (signatureScheme <= 515)
				{
					if (signatureScheme == 513)
					{
						return "rsa_pkcs1_sha1";
					}
					if (signatureScheme == 515)
					{
						return "ecdsa_sha1";
					}
				}
				else
				{
					if (signatureScheme == 1025)
					{
						return "rsa_pkcs1_sha256";
					}
					if (signatureScheme == 1027)
					{
						return "ecdsa_secp256r1_sha256";
					}
					if (signatureScheme == 1281)
					{
						return "rsa_pkcs1_sha384";
					}
				}
			}
			else if (signatureScheme <= 1539)
			{
				if (signatureScheme == 1283)
				{
					return "ecdsa_secp384r1_sha384";
				}
				if (signatureScheme == 1537)
				{
					return "rsa_pkcs1_sha512";
				}
				if (signatureScheme == 1539)
				{
					return "ecdsa_secp521r1_sha512";
				}
			}
			else
			{
				if (signatureScheme == 1800)
				{
					return "sm2sig_sm3";
				}
				switch (signatureScheme)
				{
				case 2052:
					return "rsa_pss_rsae_sha256";
				case 2053:
					return "rsa_pss_rsae_sha384";
				case 2054:
					return "rsa_pss_rsae_sha512";
				case 2055:
					return "ed25519";
				case 2056:
					return "ed448";
				case 2057:
					return "rsa_pss_pss_sha256";
				case 2058:
					return "rsa_pss_pss_sha384";
				case 2059:
					return "rsa_pss_pss_sha512";
				default:
					switch (signatureScheme)
					{
					case 2074:
						return "ecdsa_brainpoolP256r1tls13_sha256";
					case 2075:
						return "ecdsa_brainpoolP384r1tls13_sha384";
					case 2076:
						return "ecdsa_brainpoolP512r1tls13_sha512";
					}
					break;
				}
			}
			return "UNKNOWN";
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x00023538 File Offset: 0x00021738
		public static int GetNamedGroup(int signatureScheme)
		{
			if (signatureScheme <= 1283)
			{
				if (signatureScheme == 1027)
				{
					return 23;
				}
				if (signatureScheme == 1283)
				{
					return 24;
				}
			}
			else
			{
				if (signatureScheme == 1539)
				{
					return 25;
				}
				if (signatureScheme == 1800)
				{
					return 41;
				}
				switch (signatureScheme)
				{
				case 2074:
					return 31;
				case 2075:
					return 32;
				case 2076:
					return 33;
				}
			}
			return -1;
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x0002359F File Offset: 0x0002179F
		public static short GetHashAlgorithm(int signatureScheme)
		{
			return (short)(signatureScheme >> 8 & 255);
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x000235AB File Offset: 0x000217AB
		public static short GetSignatureAlgorithm(int signatureScheme)
		{
			return (short)(signatureScheme & 255);
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x000235B5 File Offset: 0x000217B5
		public static global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm GetSignatureAndHashAlgorithm(int signatureScheme)
		{
			return global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm.GetInstance(global::Org.BouncyCastle.Tls.SignatureScheme.GetHashAlgorithm(signatureScheme), global::Org.BouncyCastle.Tls.SignatureScheme.GetSignatureAlgorithm(signatureScheme));
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x000235C8 File Offset: 0x000217C8
		public static string GetText(int signatureScheme)
		{
			string hex = global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(global::System.Convert.ToString(signatureScheme, 16));
			return global::Org.BouncyCastle.Tls.SignatureScheme.GetName(signatureScheme) + "(0x" + hex + ")";
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x000235F9 File Offset: 0x000217F9
		public static bool IsPrivate(int signatureScheme)
		{
			return signatureScheme >> 9 == 254;
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x00023606 File Offset: 0x00021806
		public static bool IsECDsa(int signatureScheme)
		{
			return signatureScheme - 2074 <= 2 || 3 == global::Org.BouncyCastle.Tls.SignatureScheme.GetSignatureAlgorithm(signatureScheme);
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x0002361D File Offset: 0x0002181D
		public static bool IsRsaPss(int signatureScheme)
		{
			return signatureScheme - 2052 <= 2 || signatureScheme - 2057 <= 2;
		}

		// Token: 0x040006A8 RID: 1704
		public const int rsa_pkcs1_sha1 = 513;

		// Token: 0x040006A9 RID: 1705
		public const int ecdsa_sha1 = 515;

		// Token: 0x040006AA RID: 1706
		public const int rsa_pkcs1_sha256 = 1025;

		// Token: 0x040006AB RID: 1707
		public const int rsa_pkcs1_sha384 = 1281;

		// Token: 0x040006AC RID: 1708
		public const int rsa_pkcs1_sha512 = 1537;

		// Token: 0x040006AD RID: 1709
		public const int ecdsa_secp256r1_sha256 = 1027;

		// Token: 0x040006AE RID: 1710
		public const int ecdsa_secp384r1_sha384 = 1283;

		// Token: 0x040006AF RID: 1711
		public const int ecdsa_secp521r1_sha512 = 1539;

		// Token: 0x040006B0 RID: 1712
		public const int rsa_pss_rsae_sha256 = 2052;

		// Token: 0x040006B1 RID: 1713
		public const int rsa_pss_rsae_sha384 = 2053;

		// Token: 0x040006B2 RID: 1714
		public const int rsa_pss_rsae_sha512 = 2054;

		// Token: 0x040006B3 RID: 1715
		public const int ed25519 = 2055;

		// Token: 0x040006B4 RID: 1716
		public const int ed448 = 2056;

		// Token: 0x040006B5 RID: 1717
		public const int rsa_pss_pss_sha256 = 2057;

		// Token: 0x040006B6 RID: 1718
		public const int rsa_pss_pss_sha384 = 2058;

		// Token: 0x040006B7 RID: 1719
		public const int rsa_pss_pss_sha512 = 2059;

		// Token: 0x040006B8 RID: 1720
		public const int ecdsa_brainpoolP256r1tls13_sha256 = 2074;

		// Token: 0x040006B9 RID: 1721
		public const int ecdsa_brainpoolP384r1tls13_sha384 = 2075;

		// Token: 0x040006BA RID: 1722
		public const int ecdsa_brainpoolP512r1tls13_sha512 = 2076;

		// Token: 0x040006BB RID: 1723
		public const int sm2sig_sm3 = 1800;
	}
}
