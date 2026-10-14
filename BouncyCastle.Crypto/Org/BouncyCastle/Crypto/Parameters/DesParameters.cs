using System;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003C8 RID: 968
	public class DesParameters : global::Org.BouncyCastle.Crypto.Parameters.KeyParameter
	{
		// Token: 0x06002708 RID: 9992 RVA: 0x000AA12A File Offset: 0x000A832A
		public DesParameters(byte[] key) : base(key)
		{
			if (global::Org.BouncyCastle.Crypto.Parameters.DesParameters.IsWeakKey(key))
			{
				throw new global::System.ArgumentException("attempt to create weak DES key");
			}
		}

		// Token: 0x06002709 RID: 9993 RVA: 0x000AA146 File Offset: 0x000A8346
		public DesParameters(byte[] key, int keyOff, int keyLen) : base(key, keyOff, keyLen)
		{
			if (global::Org.BouncyCastle.Crypto.Parameters.DesParameters.IsWeakKey(key, keyOff))
			{
				throw new global::System.ArgumentException("attempt to create weak DES key");
			}
		}

		// Token: 0x0600270A RID: 9994 RVA: 0x000AA168 File Offset: 0x000A8368
		public static bool IsWeakKey(byte[] key, int offset)
		{
			if (key.Length - offset < 8)
			{
				throw new global::System.ArgumentException("key material too short.");
			}
			for (int i = 0; i < 16; i++)
			{
				bool unmatch = false;
				for (int j = 0; j < 8; j++)
				{
					if (key[j + offset] != global::Org.BouncyCastle.Crypto.Parameters.DesParameters.DES_weak_keys[i * 8 + j])
					{
						unmatch = true;
						break;
					}
				}
				if (!unmatch)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600270B RID: 9995 RVA: 0x000AA1BF File Offset: 0x000A83BF
		public static bool IsWeakKey(byte[] key)
		{
			return global::Org.BouncyCastle.Crypto.Parameters.DesParameters.IsWeakKey(key, 0);
		}

		// Token: 0x0600270C RID: 9996 RVA: 0x000AA1C8 File Offset: 0x000A83C8
		public static byte SetOddParity(byte b)
		{
			uint parity = (uint)(b ^ 1);
			parity ^= parity >> 4;
			parity ^= parity >> 2;
			parity ^= parity >> 1;
			parity &= 1U;
			return (byte)((uint)b ^ parity);
		}

		// Token: 0x0600270D RID: 9997 RVA: 0x000AA1F4 File Offset: 0x000A83F4
		public static void SetOddParity(byte[] bytes)
		{
			for (int i = 0; i < bytes.Length; i++)
			{
				bytes[i] = global::Org.BouncyCastle.Crypto.Parameters.DesParameters.SetOddParity(bytes[i]);
			}
		}

		// Token: 0x0600270E RID: 9998 RVA: 0x000AA21C File Offset: 0x000A841C
		public static void SetOddParity(byte[] bytes, int off, int len)
		{
			for (int i = 0; i < len; i++)
			{
				bytes[off + i] = global::Org.BouncyCastle.Crypto.Parameters.DesParameters.SetOddParity(bytes[off + i]);
			}
		}

		// Token: 0x04000FD9 RID: 4057
		public const int DesKeyLength = 8;

		// Token: 0x04000FDA RID: 4058
		private const int N_DES_WEAK_KEYS = 16;

		// Token: 0x04000FDB RID: 4059
		private static readonly byte[] DES_weak_keys = new byte[]
		{
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			31,
			31,
			31,
			31,
			14,
			14,
			14,
			14,
			224,
			224,
			224,
			224,
			241,
			241,
			241,
			241,
			254,
			254,
			254,
			254,
			254,
			254,
			254,
			254,
			1,
			254,
			1,
			254,
			1,
			254,
			1,
			254,
			31,
			224,
			31,
			224,
			14,
			241,
			14,
			241,
			1,
			224,
			1,
			224,
			1,
			241,
			1,
			241,
			31,
			254,
			31,
			254,
			14,
			254,
			14,
			254,
			1,
			31,
			1,
			31,
			1,
			14,
			1,
			14,
			224,
			254,
			224,
			254,
			241,
			254,
			241,
			254,
			254,
			1,
			254,
			1,
			254,
			1,
			254,
			1,
			224,
			31,
			224,
			31,
			241,
			14,
			241,
			14,
			224,
			1,
			224,
			1,
			241,
			1,
			241,
			1,
			254,
			31,
			254,
			31,
			254,
			14,
			254,
			14,
			31,
			1,
			31,
			1,
			14,
			1,
			14,
			1,
			254,
			224,
			254,
			224,
			254,
			241,
			254,
			241
		};
	}
}
