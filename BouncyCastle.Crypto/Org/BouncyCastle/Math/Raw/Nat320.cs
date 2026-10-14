using System;
using Org.BouncyCastle.Crypto.Utilities;

namespace Org.BouncyCastle.Math.Raw
{
	// Token: 0x020001F7 RID: 503
	internal abstract class Nat320
	{
		// Token: 0x060013F6 RID: 5110 RVA: 0x0005ED1D File Offset: 0x0005CF1D
		public static void Copy64(ulong[] x, ulong[] z)
		{
			z[0] = x[0];
			z[1] = x[1];
			z[2] = x[2];
			z[3] = x[3];
			z[4] = x[4];
		}

		// Token: 0x060013F7 RID: 5111 RVA: 0x0005ED3D File Offset: 0x0005CF3D
		public static void Copy64(ulong[] x, int xOff, ulong[] z, int zOff)
		{
			z[zOff] = x[xOff];
			z[zOff + 1] = x[xOff + 1];
			z[zOff + 2] = x[xOff + 2];
			z[zOff + 3] = x[xOff + 3];
			z[zOff + 4] = x[xOff + 4];
		}

		// Token: 0x060013F8 RID: 5112 RVA: 0x0005ED6D File Offset: 0x0005CF6D
		public static ulong[] Create64()
		{
			return new ulong[5];
		}

		// Token: 0x060013F9 RID: 5113 RVA: 0x0005ED75 File Offset: 0x0005CF75
		public static ulong[] CreateExt64()
		{
			return new ulong[10];
		}

		// Token: 0x060013FA RID: 5114 RVA: 0x0005ED80 File Offset: 0x0005CF80
		public static bool Eq64(ulong[] x, ulong[] y)
		{
			for (int i = 4; i >= 0; i--)
			{
				if (x[i] != y[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060013FB RID: 5115 RVA: 0x0005EDA4 File Offset: 0x0005CFA4
		public static bool IsOne64(ulong[] x)
		{
			if (x[0] != 1UL)
			{
				return false;
			}
			for (int i = 1; i < 5; i++)
			{
				if (x[i] != 0UL)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060013FC RID: 5116 RVA: 0x0005EDD0 File Offset: 0x0005CFD0
		public static bool IsZero64(ulong[] x)
		{
			for (int i = 0; i < 5; i++)
			{
				if (x[i] != 0UL)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x0005EDF4 File Offset: 0x0005CFF4
		public static global::Org.BouncyCastle.Math.BigInteger ToBigInteger64(ulong[] x)
		{
			byte[] bs = new byte[40];
			for (int i = 0; i < 5; i++)
			{
				ulong x_i = x[i];
				if (x_i != 0UL)
				{
					global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(x_i, bs, 4 - i << 3);
				}
			}
			return new global::Org.BouncyCastle.Math.BigInteger(1, bs);
		}
	}
}
