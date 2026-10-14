using System;
using Org.BouncyCastle.Crypto.Utilities;

namespace Org.BouncyCastle.Math.Raw
{
	// Token: 0x020001FB RID: 507
	internal abstract class Nat576
	{
		// Token: 0x06001410 RID: 5136 RVA: 0x0005F31A File Offset: 0x0005D51A
		public static void Copy64(ulong[] x, ulong[] z)
		{
			z[0] = x[0];
			z[1] = x[1];
			z[2] = x[2];
			z[3] = x[3];
			z[4] = x[4];
			z[5] = x[5];
			z[6] = x[6];
			z[7] = x[7];
			z[8] = x[8];
		}

		// Token: 0x06001411 RID: 5137 RVA: 0x0005F354 File Offset: 0x0005D554
		public static void Copy64(ulong[] x, int xOff, ulong[] z, int zOff)
		{
			z[zOff] = x[xOff];
			z[zOff + 1] = x[xOff + 1];
			z[zOff + 2] = x[xOff + 2];
			z[zOff + 3] = x[xOff + 3];
			z[zOff + 4] = x[xOff + 4];
			z[zOff + 5] = x[xOff + 5];
			z[zOff + 6] = x[xOff + 6];
			z[zOff + 7] = x[xOff + 7];
			z[zOff + 8] = x[xOff + 8];
		}

		// Token: 0x06001412 RID: 5138 RVA: 0x0005F3B7 File Offset: 0x0005D5B7
		public static ulong[] Create64()
		{
			return new ulong[9];
		}

		// Token: 0x06001413 RID: 5139 RVA: 0x0005F3C0 File Offset: 0x0005D5C0
		public static ulong[] CreateExt64()
		{
			return new ulong[18];
		}

		// Token: 0x06001414 RID: 5140 RVA: 0x0005F3CC File Offset: 0x0005D5CC
		public static bool Eq64(ulong[] x, ulong[] y)
		{
			for (int i = 8; i >= 0; i--)
			{
				if (x[i] != y[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001415 RID: 5141 RVA: 0x0005F3F0 File Offset: 0x0005D5F0
		public static bool IsOne64(ulong[] x)
		{
			if (x[0] != 1UL)
			{
				return false;
			}
			for (int i = 1; i < 9; i++)
			{
				if (x[i] != 0UL)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001416 RID: 5142 RVA: 0x0005F41C File Offset: 0x0005D61C
		public static bool IsZero64(ulong[] x)
		{
			for (int i = 0; i < 9; i++)
			{
				if (x[i] != 0UL)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001417 RID: 5143 RVA: 0x0005F440 File Offset: 0x0005D640
		public static global::Org.BouncyCastle.Math.BigInteger ToBigInteger64(ulong[] x)
		{
			byte[] bs = new byte[72];
			for (int i = 0; i < 9; i++)
			{
				ulong x_i = x[i];
				if (x_i != 0UL)
				{
					global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(x_i, bs, 8 - i << 3);
				}
			}
			return new global::Org.BouncyCastle.Math.BigInteger(1, bs);
		}
	}
}
