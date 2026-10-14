using System;
using Org.BouncyCastle.Crypto.Utilities;

namespace Org.BouncyCastle.Math.Raw
{
	// Token: 0x020001F9 RID: 505
	internal abstract class Nat448
	{
		// Token: 0x06001402 RID: 5122 RVA: 0x0005EF6E File Offset: 0x0005D16E
		public static void Copy64(ulong[] x, ulong[] z)
		{
			z[0] = x[0];
			z[1] = x[1];
			z[2] = x[2];
			z[3] = x[3];
			z[4] = x[4];
			z[5] = x[5];
			z[6] = x[6];
		}

		// Token: 0x06001403 RID: 5123 RVA: 0x0005EF9C File Offset: 0x0005D19C
		public static void Copy64(ulong[] x, int xOff, ulong[] z, int zOff)
		{
			z[zOff] = x[xOff];
			z[zOff + 1] = x[xOff + 1];
			z[zOff + 2] = x[xOff + 2];
			z[zOff + 3] = x[xOff + 3];
			z[zOff + 4] = x[xOff + 4];
			z[zOff + 5] = x[xOff + 5];
			z[zOff + 6] = x[xOff + 6];
		}

		// Token: 0x06001404 RID: 5124 RVA: 0x0005EFEB File Offset: 0x0005D1EB
		public static ulong[] Create64()
		{
			return new ulong[7];
		}

		// Token: 0x06001405 RID: 5125 RVA: 0x0005EFF3 File Offset: 0x0005D1F3
		public static ulong[] CreateExt64()
		{
			return new ulong[14];
		}

		// Token: 0x06001406 RID: 5126 RVA: 0x0005EFFC File Offset: 0x0005D1FC
		public static bool Eq64(ulong[] x, ulong[] y)
		{
			for (int i = 6; i >= 0; i--)
			{
				if (x[i] != y[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001407 RID: 5127 RVA: 0x0005F020 File Offset: 0x0005D220
		public static bool IsOne64(ulong[] x)
		{
			if (x[0] != 1UL)
			{
				return false;
			}
			for (int i = 1; i < 7; i++)
			{
				if (x[i] != 0UL)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001408 RID: 5128 RVA: 0x0005F04C File Offset: 0x0005D24C
		public static bool IsZero64(ulong[] x)
		{
			for (int i = 0; i < 7; i++)
			{
				if (x[i] != 0UL)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001409 RID: 5129 RVA: 0x0005F070 File Offset: 0x0005D270
		public static void Mul(uint[] x, uint[] y, uint[] zz)
		{
			global::Org.BouncyCastle.Math.Raw.Nat224.Mul(x, y, zz);
			global::Org.BouncyCastle.Math.Raw.Nat224.Mul(x, 7, y, 7, zz, 14);
			uint c21 = global::Org.BouncyCastle.Math.Raw.Nat224.AddToEachOther(zz, 7, zz, 14);
			uint c22 = c21 + global::Org.BouncyCastle.Math.Raw.Nat224.AddTo(zz, 0, zz, 7, 0U);
			c21 += global::Org.BouncyCastle.Math.Raw.Nat224.AddTo(zz, 21, zz, 14, c22);
			uint[] dx = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
			uint[] dy = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
			bool neg = global::Org.BouncyCastle.Math.Raw.Nat224.Diff(x, 7, x, 0, dx, 0) != global::Org.BouncyCastle.Math.Raw.Nat224.Diff(y, 7, y, 0, dy, 0);
			uint[] tt = global::Org.BouncyCastle.Math.Raw.Nat224.CreateExt();
			global::Org.BouncyCastle.Math.Raw.Nat224.Mul(dx, dy, tt);
			c21 += (neg ? global::Org.BouncyCastle.Math.Raw.Nat.AddTo(14, tt, 0, zz, 7) : ((uint)global::Org.BouncyCastle.Math.Raw.Nat.SubFrom(14, tt, 0, zz, 7)));
			global::Org.BouncyCastle.Math.Raw.Nat.AddWordAt(28, c21, zz, 21);
		}

		// Token: 0x0600140A RID: 5130 RVA: 0x0005F120 File Offset: 0x0005D320
		public static void Square(uint[] x, uint[] zz)
		{
			global::Org.BouncyCastle.Math.Raw.Nat224.Square(x, zz);
			global::Org.BouncyCastle.Math.Raw.Nat224.Square(x, 7, zz, 14);
			uint c21 = global::Org.BouncyCastle.Math.Raw.Nat224.AddToEachOther(zz, 7, zz, 14);
			uint c22 = c21 + global::Org.BouncyCastle.Math.Raw.Nat224.AddTo(zz, 0, zz, 7, 0U);
			c21 += global::Org.BouncyCastle.Math.Raw.Nat224.AddTo(zz, 21, zz, 14, c22);
			uint[] dx = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
			global::Org.BouncyCastle.Math.Raw.Nat224.Diff(x, 7, x, 0, dx, 0);
			uint[] tt = global::Org.BouncyCastle.Math.Raw.Nat224.CreateExt();
			global::Org.BouncyCastle.Math.Raw.Nat224.Square(dx, tt);
			c21 += (uint)global::Org.BouncyCastle.Math.Raw.Nat.SubFrom(14, tt, 0, zz, 7);
			global::Org.BouncyCastle.Math.Raw.Nat.AddWordAt(28, c21, zz, 21);
		}

		// Token: 0x0600140B RID: 5131 RVA: 0x0005F1A0 File Offset: 0x0005D3A0
		public static global::Org.BouncyCastle.Math.BigInteger ToBigInteger64(ulong[] x)
		{
			byte[] bs = new byte[56];
			for (int i = 0; i < 7; i++)
			{
				ulong x_i = x[i];
				if (x_i != 0UL)
				{
					global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(x_i, bs, 6 - i << 3);
				}
			}
			return new global::Org.BouncyCastle.Math.BigInteger(1, bs);
		}
	}
}
