using System;
using Org.BouncyCastle.Math.Raw;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x0200027D RID: 637
	internal class SecT163Field
	{
		// Token: 0x06001B18 RID: 6936 RVA: 0x0007F4EF File Offset: 0x0007D6EF
		public static void Add(ulong[] x, ulong[] y, ulong[] z)
		{
			z[0] = (x[0] ^ y[0]);
			z[1] = (x[1] ^ y[1]);
			z[2] = (x[2] ^ y[2]);
		}

		// Token: 0x06001B19 RID: 6937 RVA: 0x0007F50F File Offset: 0x0007D70F
		public static void AddExt(ulong[] xx, ulong[] yy, ulong[] zz)
		{
			zz[0] = (xx[0] ^ yy[0]);
			zz[1] = (xx[1] ^ yy[1]);
			zz[2] = (xx[2] ^ yy[2]);
			zz[3] = (xx[3] ^ yy[3]);
			zz[4] = (xx[4] ^ yy[4]);
			zz[5] = (xx[5] ^ yy[5]);
		}

		// Token: 0x06001B1A RID: 6938 RVA: 0x0007F54D File Offset: 0x0007D74D
		public static void AddOne(ulong[] x, ulong[] z)
		{
			z[0] = (x[0] ^ 1UL);
			z[1] = x[1];
			z[2] = x[2];
		}

		// Token: 0x06001B1B RID: 6939 RVA: 0x0007F564 File Offset: 0x0007D764
		private static void AddTo(ulong[] x, ulong[] z)
		{
			z[0] ^= x[0];
			z[1] ^= x[1];
			z[2] ^= x[2];
		}

		// Token: 0x06001B1C RID: 6940 RVA: 0x0007F590 File Offset: 0x0007D790
		public static ulong[] FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return global::Org.BouncyCastle.Math.Raw.Nat.FromBigInteger64(163, x);
		}

		// Token: 0x06001B1D RID: 6941 RVA: 0x0007F5A0 File Offset: 0x0007D7A0
		public static void HalfTrace(ulong[] x, ulong[] z)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat192.CreateExt64();
			global::Org.BouncyCastle.Math.Raw.Nat192.Copy64(x, z);
			for (int i = 1; i < 163; i += 2)
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.ImplSquare(z, tt);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.Reduce(tt, z);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.ImplSquare(z, tt);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.Reduce(tt, z);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.AddTo(x, z);
			}
		}

		// Token: 0x06001B1E RID: 6942 RVA: 0x0007F5F0 File Offset: 0x0007D7F0
		public static void Invert(ulong[] x, ulong[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat192.IsZero64(x))
			{
				throw new global::System.InvalidOperationException();
			}
			ulong[] t0 = global::Org.BouncyCastle.Math.Raw.Nat192.Create64();
			ulong[] t = global::Org.BouncyCastle.Math.Raw.Nat192.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.Square(x, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.SquareN(t0, 1, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.Multiply(t0, t, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.SquareN(t, 1, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.Multiply(t0, t, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.SquareN(t0, 3, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.Multiply(t0, t, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.SquareN(t, 3, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.Multiply(t0, t, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.SquareN(t0, 9, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.Multiply(t0, t, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.SquareN(t, 9, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.Multiply(t0, t, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.SquareN(t0, 27, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.Multiply(t0, t, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.SquareN(t, 27, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.Multiply(t0, t, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.SquareN(t0, 81, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.Multiply(t0, t, z);
		}

		// Token: 0x06001B1F RID: 6943 RVA: 0x0007F6B4 File Offset: 0x0007D8B4
		public static void Multiply(ulong[] x, ulong[] y, ulong[] z)
		{
			ulong[] tt = new ulong[8];
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.ImplMultiply(x, y, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.Reduce(tt, z);
		}

		// Token: 0x06001B20 RID: 6944 RVA: 0x0007F6D8 File Offset: 0x0007D8D8
		public static void MultiplyAddToExt(ulong[] x, ulong[] y, ulong[] zz)
		{
			ulong[] tt = new ulong[8];
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.ImplMultiply(x, y, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.AddExt(zz, tt, zz);
		}

		// Token: 0x06001B21 RID: 6945 RVA: 0x0007F6FC File Offset: 0x0007D8FC
		public static void Reduce(ulong[] xx, ulong[] z)
		{
			ulong x0 = xx[0];
			ulong x = xx[1];
			ulong x2 = xx[2];
			ulong x3 = xx[3];
			ulong x4 = xx[4];
			ulong x5 = xx[5];
			x2 ^= (x5 << 29 ^ x5 << 32 ^ x5 << 35 ^ x5 << 36);
			x3 ^= (x5 >> 35 ^ x5 >> 32 ^ x5 >> 29 ^ x5 >> 28);
			x ^= (x4 << 29 ^ x4 << 32 ^ x4 << 35 ^ x4 << 36);
			x2 ^= (x4 >> 35 ^ x4 >> 32 ^ x4 >> 29 ^ x4 >> 28);
			x0 ^= (x3 << 29 ^ x3 << 32 ^ x3 << 35 ^ x3 << 36);
			x ^= (x3 >> 35 ^ x3 >> 32 ^ x3 >> 29 ^ x3 >> 28);
			ulong t = x2 >> 35;
			z[0] = (x0 ^ t ^ t << 3 ^ t << 6 ^ t << 7);
			z[1] = x;
			z[2] = (x2 & 34359738367UL);
		}

		// Token: 0x06001B22 RID: 6946 RVA: 0x0007F7E8 File Offset: 0x0007D9E8
		public static void Reduce29(ulong[] z, int zOff)
		{
			ulong z2 = z[zOff + 2];
			ulong t = z2 >> 35;
			z[zOff] ^= (t ^ t << 3 ^ t << 6 ^ t << 7);
			z[zOff + 2] = (z2 & 34359738367UL);
		}

		// Token: 0x06001B23 RID: 6947 RVA: 0x0007F828 File Offset: 0x0007DA28
		public static void Sqrt(ulong[] x, ulong[] z)
		{
			ulong[] array = global::Org.BouncyCastle.Math.Raw.Nat192.Create64();
			ulong u0 = global::Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x[0]);
			ulong u = global::Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x[1]);
			ulong e0 = (u0 & (ulong)-1) | u << 32;
			array[0] = (u0 >> 32 | (u & 18446744069414584320UL));
			u0 = global::Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x[2]);
			ulong e = u0 & (ulong)-1;
			array[1] = u0 >> 32;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.Multiply(array, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.ROOT_Z, z);
			z[0] ^= e0;
			z[1] ^= e;
		}

		// Token: 0x06001B24 RID: 6948 RVA: 0x0007F8A4 File Offset: 0x0007DAA4
		public static void Square(ulong[] x, ulong[] z)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat192.CreateExt64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.ImplSquare(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.Reduce(tt, z);
		}

		// Token: 0x06001B25 RID: 6949 RVA: 0x0007F8C8 File Offset: 0x0007DAC8
		public static void SquareAddToExt(ulong[] x, ulong[] zz)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat192.CreateExt64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.ImplSquare(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.AddExt(zz, tt, zz);
		}

		// Token: 0x06001B26 RID: 6950 RVA: 0x0007F8EC File Offset: 0x0007DAEC
		public static void SquareN(ulong[] x, int n, ulong[] z)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat192.CreateExt64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.ImplSquare(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.Reduce(tt, z);
			while (--n > 0)
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.ImplSquare(z, tt);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.Reduce(tt, z);
			}
		}

		// Token: 0x06001B27 RID: 6951 RVA: 0x0007F926 File Offset: 0x0007DB26
		public static uint Trace(ulong[] x)
		{
			return (uint)(x[0] ^ x[2] >> 29) & 1U;
		}

		// Token: 0x06001B28 RID: 6952 RVA: 0x0007F938 File Offset: 0x0007DB38
		protected static void ImplCompactExt(ulong[] zz)
		{
			ulong z0 = zz[0];
			ulong z = zz[1];
			ulong z2 = zz[2];
			ulong z3 = zz[3];
			ulong z4 = zz[4];
			ulong z5 = zz[5];
			zz[0] = (z0 ^ z << 55);
			zz[1] = (z >> 9 ^ z2 << 46);
			zz[2] = (z2 >> 18 ^ z3 << 37);
			zz[3] = (z3 >> 27 ^ z4 << 28);
			zz[4] = (z4 >> 36 ^ z5 << 19);
			zz[5] = z5 >> 45;
		}

		// Token: 0x06001B29 RID: 6953 RVA: 0x0007F9A4 File Offset: 0x0007DBA4
		protected static void ImplMultiply(ulong[] x, ulong[] y, ulong[] zz)
		{
			ulong f0 = x[0];
			ulong f = x[1];
			ulong f2 = x[2];
			f2 = (f >> 46 ^ f2 << 18);
			f = ((f0 >> 55 ^ f << 9) & 36028797018963967UL);
			f0 &= 36028797018963967UL;
			ulong g0 = y[0];
			ulong g = y[1];
			ulong g2 = y[2];
			g2 = (g >> 46 ^ g2 << 18);
			g = ((g0 >> 55 ^ g << 9) & 36028797018963967UL);
			g0 &= 36028797018963967UL;
			ulong[] H = new ulong[10];
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.ImplMulw(zz, f0, g0, H, 0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.ImplMulw(zz, f2, g2, H, 2);
			ulong t0 = f0 ^ f ^ f2;
			ulong t = g0 ^ g ^ g2;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.ImplMulw(zz, t0, t, H, 4);
			ulong t2 = f << 1 ^ f2 << 2;
			ulong t3 = g << 1 ^ g2 << 2;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.ImplMulw(zz, f0 ^ t2, g0 ^ t3, H, 6);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.ImplMulw(zz, t0 ^ t2, t ^ t3, H, 8);
			ulong num = H[6] ^ H[8];
			ulong t4 = H[7] ^ H[9];
			ulong v0 = num << 1 ^ H[6];
			ulong v = num ^ t4 << 1 ^ H[7];
			ulong v2 = t4;
			ulong u0 = H[0];
			ulong u = H[1] ^ H[0] ^ H[4];
			ulong u2 = H[1] ^ H[5];
			ulong w0 = u0 ^ v0 ^ H[2] << 4 ^ H[2] << 1;
			ulong w = u ^ v ^ H[3] << 4 ^ H[3] << 1;
			ulong w2 = u2 ^ v2;
			w ^= w0 >> 55;
			w0 &= 36028797018963967UL;
			w2 ^= w >> 55;
			w &= 36028797018963967UL;
			w0 = (w0 >> 1 ^ (w & 1UL) << 54);
			w = (w >> 1 ^ (w2 & 1UL) << 54);
			w2 >>= 1;
			w0 ^= w0 << 1;
			w0 ^= w0 << 2;
			w0 ^= w0 << 4;
			w0 ^= w0 << 8;
			w0 ^= w0 << 16;
			w0 ^= w0 << 32;
			w0 &= 36028797018963967UL;
			w ^= w0 >> 54;
			w ^= w << 1;
			w ^= w << 2;
			w ^= w << 4;
			w ^= w << 8;
			w ^= w << 16;
			w ^= w << 32;
			w &= 36028797018963967UL;
			w2 ^= w >> 54;
			w2 ^= w2 << 1;
			w2 ^= w2 << 2;
			w2 ^= w2 << 4;
			w2 ^= w2 << 8;
			w2 ^= w2 << 16;
			w2 ^= w2 << 32;
			zz[0] = u0;
			zz[1] = (u ^ w0 ^ H[2]);
			zz[2] = (u2 ^ w ^ w0 ^ H[3]);
			zz[3] = (w2 ^ w);
			zz[4] = (w2 ^ H[2]);
			zz[5] = H[3];
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163Field.ImplCompactExt(zz);
		}

		// Token: 0x06001B2A RID: 6954 RVA: 0x0007FC88 File Offset: 0x0007DE88
		protected static void ImplMulw(ulong[] u, ulong x, ulong y, ulong[] z, int zOff)
		{
			u[1] = y;
			u[2] = u[1] << 1;
			u[3] = (u[2] ^ y);
			u[4] = u[2] << 1;
			u[5] = (u[4] ^ y);
			u[6] = u[3] << 1;
			u[7] = (u[6] ^ y);
			uint i = (uint)x;
			ulong h = 0UL;
			ulong j = u[(int)(i & 3U)];
			int k = 47;
			do
			{
				i = (uint)(x >> k);
				ulong g = u[(int)(i & 7U)] ^ u[(int)(i >> 3 & 7U)] << 3 ^ u[(int)(i >> 6 & 7U)] << 6;
				j ^= g << k;
				h ^= g >> -k;
			}
			while ((k -= 9) > 0);
			z[zOff] = (j & 36028797018963967UL);
			z[zOff + 1] = (j >> 55 ^ h << 9);
		}

		// Token: 0x06001B2B RID: 6955 RVA: 0x0007FD3A File Offset: 0x0007DF3A
		protected static void ImplSquare(ulong[] x, ulong[] zz)
		{
			global::Org.BouncyCastle.Math.Raw.Interleave.Expand64To128(x, 0, 3, zz, 0);
		}

		// Token: 0x04000A9E RID: 2718
		private const ulong M35 = 34359738367UL;

		// Token: 0x04000A9F RID: 2719
		private const ulong M55 = 36028797018963967UL;

		// Token: 0x04000AA0 RID: 2720
		private static readonly ulong[] ROOT_Z = new ulong[]
		{
			13176245766935393968UL,
			5270498306774195053UL,
			19634136210UL
		};
	}
}
