using System;
using System.IO;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x02000107 RID: 263
	public abstract class TlsDHUtilities
	{
		// Token: 0x06000967 RID: 2407 RVA: 0x00025B5C File Offset: 0x00023D5C
		public static global::Org.BouncyCastle.Tls.Crypto.TlsDHConfig CreateNamedDHConfig(global::Org.BouncyCastle.Tls.TlsContext context, int namedGroup)
		{
			if (namedGroup < 0 || global::Org.BouncyCastle.Tls.NamedGroup.GetFiniteFieldBits(namedGroup) < 1)
			{
				return null;
			}
			bool padded = global::Org.BouncyCastle.Tls.TlsUtilities.IsTlsV13(context);
			return new global::Org.BouncyCastle.Tls.Crypto.TlsDHConfig(namedGroup, padded);
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x00025B88 File Offset: 0x00023D88
		public static global::Org.BouncyCastle.Tls.Crypto.DHGroup GetDHGroup(global::Org.BouncyCastle.Tls.Crypto.TlsDHConfig dhConfig)
		{
			int namedGroup = dhConfig.NamedGroup;
			if (namedGroup >= 0)
			{
				return global::Org.BouncyCastle.Tls.TlsDHUtilities.GetNamedDHGroup(namedGroup);
			}
			return dhConfig.ExplicitGroup;
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x00025BB0 File Offset: 0x00023DB0
		public static global::Org.BouncyCastle.Tls.Crypto.DHGroup GetNamedDHGroup(int namedGroup)
		{
			switch (namedGroup)
			{
			case 256:
				return global::Org.BouncyCastle.Tls.Crypto.DHStandardGroups.rfc7919_ffdhe2048;
			case 257:
				return global::Org.BouncyCastle.Tls.Crypto.DHStandardGroups.rfc7919_ffdhe3072;
			case 258:
				return global::Org.BouncyCastle.Tls.Crypto.DHStandardGroups.rfc7919_ffdhe4096;
			case 259:
				return global::Org.BouncyCastle.Tls.Crypto.DHStandardGroups.rfc7919_ffdhe6144;
			case 260:
				return global::Org.BouncyCastle.Tls.Crypto.DHStandardGroups.rfc7919_ffdhe8192;
			default:
				return null;
			}
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x00025BFE File Offset: 0x00023DFE
		public static int GetMinimumFiniteFieldBits(int cipherSuite)
		{
			if (!global::Org.BouncyCastle.Tls.TlsDHUtilities.IsDHCipherSuite(cipherSuite))
			{
				return 0;
			}
			return 1;
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x00025C0C File Offset: 0x00023E0C
		public static bool IsDHCipherSuite(int cipherSuite)
		{
			int keyExchangeAlgorithm = global::Org.BouncyCastle.Tls.TlsUtilities.GetKeyExchangeAlgorithm(cipherSuite);
			switch (keyExchangeAlgorithm)
			{
			case 3:
			case 5:
			case 7:
			case 9:
			case 11:
				break;
			case 4:
			case 6:
			case 8:
			case 10:
				return false;
			default:
				if (keyExchangeAlgorithm != 14)
				{
					return false;
				}
				break;
			}
			return true;
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x00025C54 File Offset: 0x00023E54
		public static int GetNamedGroupForDHParameters(global::Org.BouncyCastle.Math.BigInteger p, global::Org.BouncyCastle.Math.BigInteger g)
		{
			foreach (int namedGroup in new int[]
			{
				256,
				257,
				258,
				259,
				260
			})
			{
				global::Org.BouncyCastle.Tls.Crypto.DHGroup dhGroup = global::Org.BouncyCastle.Tls.TlsDHUtilities.GetNamedDHGroup(namedGroup);
				if (dhGroup != null && dhGroup.P.Equals(p) && dhGroup.G.Equals(g))
				{
					return namedGroup;
				}
			}
			return -1;
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x00025CB0 File Offset: 0x00023EB0
		public static global::Org.BouncyCastle.Tls.Crypto.DHGroup GetStandardGroupForDHParameters(global::Org.BouncyCastle.Math.BigInteger p, global::Org.BouncyCastle.Math.BigInteger g)
		{
			foreach (global::Org.BouncyCastle.Tls.Crypto.DHGroup dhGroup in new global::Org.BouncyCastle.Tls.Crypto.DHGroup[]
			{
				global::Org.BouncyCastle.Tls.Crypto.DHStandardGroups.rfc7919_ffdhe2048,
				global::Org.BouncyCastle.Tls.Crypto.DHStandardGroups.rfc7919_ffdhe3072,
				global::Org.BouncyCastle.Tls.Crypto.DHStandardGroups.rfc7919_ffdhe4096,
				global::Org.BouncyCastle.Tls.Crypto.DHStandardGroups.rfc7919_ffdhe6144,
				global::Org.BouncyCastle.Tls.Crypto.DHStandardGroups.rfc7919_ffdhe8192,
				global::Org.BouncyCastle.Tls.Crypto.DHStandardGroups.rfc3526_1536,
				global::Org.BouncyCastle.Tls.Crypto.DHStandardGroups.rfc3526_2048,
				global::Org.BouncyCastle.Tls.Crypto.DHStandardGroups.rfc3526_3072,
				global::Org.BouncyCastle.Tls.Crypto.DHStandardGroups.rfc3526_4096,
				global::Org.BouncyCastle.Tls.Crypto.DHStandardGroups.rfc3526_6144,
				global::Org.BouncyCastle.Tls.Crypto.DHStandardGroups.rfc3526_8192,
				global::Org.BouncyCastle.Tls.Crypto.DHStandardGroups.rfc5996_768,
				global::Org.BouncyCastle.Tls.Crypto.DHStandardGroups.rfc5996_1024
			})
			{
				if (dhGroup != null && dhGroup.P.Equals(p) && dhGroup.G.Equals(g))
				{
					return dhGroup;
				}
			}
			return null;
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x00025D68 File Offset: 0x00023F68
		public static global::Org.BouncyCastle.Tls.Crypto.TlsDHConfig ReceiveDHConfig(global::Org.BouncyCastle.Tls.TlsContext context, global::Org.BouncyCastle.Tls.TlsDHGroupVerifier dhGroupVerifier, global::System.IO.Stream input)
		{
			global::Org.BouncyCastle.Math.BigInteger p = global::Org.BouncyCastle.Tls.TlsDHUtilities.ReadDHParameter(input);
			global::Org.BouncyCastle.Math.BigInteger g = global::Org.BouncyCastle.Tls.TlsDHUtilities.ReadDHParameter(input);
			int namedGroup = global::Org.BouncyCastle.Tls.TlsDHUtilities.GetNamedGroupForDHParameters(p, g);
			if (namedGroup < 0)
			{
				global::Org.BouncyCastle.Tls.Crypto.DHGroup dhGroup = global::Org.BouncyCastle.Tls.TlsDHUtilities.GetStandardGroupForDHParameters(p, g);
				if (dhGroup == null)
				{
					dhGroup = new global::Org.BouncyCastle.Tls.Crypto.DHGroup(p, null, g, 0);
				}
				if (!dhGroupVerifier.Accept(dhGroup))
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(71);
				}
				return new global::Org.BouncyCastle.Tls.Crypto.TlsDHConfig(dhGroup);
			}
			else
			{
				int[] clientSupportedGroups = context.SecurityParameters.ClientSupportedGroups;
				if (clientSupportedGroups == null || global::Org.BouncyCastle.Utilities.Arrays.Contains(clientSupportedGroups, namedGroup))
				{
					return new global::Org.BouncyCastle.Tls.Crypto.TlsDHConfig(namedGroup, false);
				}
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
			}
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x00025DE8 File Offset: 0x00023FE8
		public static global::Org.BouncyCastle.Math.BigInteger ReadDHParameter(global::System.IO.Stream input)
		{
			return new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque16(input, 1));
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x00025DF7 File Offset: 0x00023FF7
		public static void WriteDHConfig(global::Org.BouncyCastle.Tls.Crypto.TlsDHConfig dhConfig, global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Tls.Crypto.DHGroup dhgroup = global::Org.BouncyCastle.Tls.TlsDHUtilities.GetDHGroup(dhConfig);
			global::Org.BouncyCastle.Tls.TlsDHUtilities.WriteDHParameter(dhgroup.P, output);
			global::Org.BouncyCastle.Tls.TlsDHUtilities.WriteDHParameter(dhgroup.G, output);
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x00025E16 File Offset: 0x00024016
		public static void WriteDHParameter(global::Org.BouncyCastle.Math.BigInteger x, global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque16(global::Org.BouncyCastle.Utilities.BigIntegers.AsUnsignedByteArray(x), output);
		}
	}
}
