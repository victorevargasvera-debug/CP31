using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x020004EB RID: 1259
	internal class XofUtilities
	{
		// Token: 0x060031AA RID: 12714 RVA: 0x000EEBEC File Offset: 0x000ECDEC
		internal static byte[] LeftEncode(long strLen)
		{
			byte i = 1;
			long v = strLen;
			while ((v >>= 8) != 0L)
			{
				i += 1;
			}
			byte[] b = new byte[(int)(i + 1)];
			b[0] = i;
			for (int j = 1; j <= (int)i; j++)
			{
				b[j] = (byte)(strLen >> 8 * ((int)i - j));
			}
			return b;
		}

		// Token: 0x060031AB RID: 12715 RVA: 0x000EEC34 File Offset: 0x000ECE34
		internal static byte[] RightEncode(long strLen)
		{
			byte i = 1;
			long v = strLen;
			while ((v >>= 8) != 0L)
			{
				i += 1;
			}
			byte[] b = new byte[(int)(i + 1)];
			b[(int)i] = i;
			for (int j = 0; j < (int)i; j++)
			{
				b[j] = (byte)(strLen >> 8 * ((int)i - j - 1));
			}
			return b;
		}

		// Token: 0x060031AC RID: 12716 RVA: 0x000EEC7D File Offset: 0x000ECE7D
		internal static byte[] Encode(byte X)
		{
			return global::Org.BouncyCastle.Utilities.Arrays.Concatenate(global::Org.BouncyCastle.Crypto.Digests.XofUtilities.LeftEncode(8L), new byte[]
			{
				X
			});
		}

		// Token: 0x060031AD RID: 12717 RVA: 0x000EEC95 File Offset: 0x000ECE95
		internal static byte[] Encode(byte[] inBuf, int inOff, int len)
		{
			if (inBuf.Length == len)
			{
				return global::Org.BouncyCastle.Utilities.Arrays.Concatenate(global::Org.BouncyCastle.Crypto.Digests.XofUtilities.LeftEncode((long)(len * 8)), inBuf);
			}
			return global::Org.BouncyCastle.Utilities.Arrays.Concatenate(global::Org.BouncyCastle.Crypto.Digests.XofUtilities.LeftEncode((long)(len * 8)), global::Org.BouncyCastle.Utilities.Arrays.CopyOfRange(inBuf, inOff, inOff + len));
		}
	}
}
