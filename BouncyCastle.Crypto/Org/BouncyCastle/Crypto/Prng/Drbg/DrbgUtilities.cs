using System;
using System.Collections;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Prng.Drbg
{
	// Token: 0x020003C1 RID: 961
	internal class DrbgUtilities
	{
		// Token: 0x060026DD RID: 9949 RVA: 0x000A9448 File Offset: 0x000A7648
		static DrbgUtilities()
		{
			global::Org.BouncyCastle.Crypto.Prng.Drbg.DrbgUtilities.maxSecurityStrengths.Add("SHA-1", 128);
			global::Org.BouncyCastle.Crypto.Prng.Drbg.DrbgUtilities.maxSecurityStrengths.Add("SHA-224", 192);
			global::Org.BouncyCastle.Crypto.Prng.Drbg.DrbgUtilities.maxSecurityStrengths.Add("SHA-256", 256);
			global::Org.BouncyCastle.Crypto.Prng.Drbg.DrbgUtilities.maxSecurityStrengths.Add("SHA-384", 256);
			global::Org.BouncyCastle.Crypto.Prng.Drbg.DrbgUtilities.maxSecurityStrengths.Add("SHA-512", 256);
			global::Org.BouncyCastle.Crypto.Prng.Drbg.DrbgUtilities.maxSecurityStrengths.Add("SHA-512/224", 192);
			global::Org.BouncyCastle.Crypto.Prng.Drbg.DrbgUtilities.maxSecurityStrengths.Add("SHA-512/256", 256);
		}

		// Token: 0x060026DE RID: 9950 RVA: 0x000A950E File Offset: 0x000A770E
		internal static int GetMaxSecurityStrength(global::Org.BouncyCastle.Crypto.IDigest d)
		{
			return (int)global::Org.BouncyCastle.Crypto.Prng.Drbg.DrbgUtilities.maxSecurityStrengths[d.AlgorithmName];
		}

		// Token: 0x060026DF RID: 9951 RVA: 0x000A9528 File Offset: 0x000A7728
		internal static int GetMaxSecurityStrength(global::Org.BouncyCastle.Crypto.IMac m)
		{
			string name = m.AlgorithmName;
			return (int)global::Org.BouncyCastle.Crypto.Prng.Drbg.DrbgUtilities.maxSecurityStrengths[name.Substring(0, name.IndexOf("/"))];
		}

		// Token: 0x060026E0 RID: 9952 RVA: 0x000A9560 File Offset: 0x000A7760
		internal static byte[] HashDF(global::Org.BouncyCastle.Crypto.IDigest digest, byte[] seedMaterial, int seedLength)
		{
			byte[] temp = new byte[(seedLength + 7) / 8];
			int len = temp.Length / digest.GetDigestSize();
			int counter = 1;
			byte[] dig = new byte[digest.GetDigestSize()];
			for (int i = 0; i <= len; i++)
			{
				digest.Update((byte)counter);
				digest.Update((byte)(seedLength >> 24));
				digest.Update((byte)(seedLength >> 16));
				digest.Update((byte)(seedLength >> 8));
				digest.Update((byte)seedLength);
				digest.BlockUpdate(seedMaterial, 0, seedMaterial.Length);
				digest.DoFinal(dig, 0);
				int bytesToCopy = (temp.Length - i * dig.Length > dig.Length) ? dig.Length : (temp.Length - i * dig.Length);
				global::System.Array.Copy(dig, 0, temp, i * dig.Length, bytesToCopy);
				counter++;
			}
			if (seedLength % 8 != 0)
			{
				int shift = 8 - seedLength % 8;
				uint carry = 0U;
				for (int j = 0; j != temp.Length; j++)
				{
					uint b = (uint)temp[j];
					temp[j] = (byte)(b >> shift | carry << 8 - shift);
					carry = b;
				}
			}
			return temp;
		}

		// Token: 0x060026E1 RID: 9953 RVA: 0x000A9660 File Offset: 0x000A7860
		internal static bool IsTooLarge(byte[] bytes, int maxBytes)
		{
			return bytes != null && bytes.Length > maxBytes;
		}

		// Token: 0x04000FC0 RID: 4032
		private static readonly global::System.Collections.IDictionary maxSecurityStrengths = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
	}
}
