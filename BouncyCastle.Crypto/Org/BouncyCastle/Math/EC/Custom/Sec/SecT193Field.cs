using System;
using Org.BouncyCastle.Math.Raw;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x02000285 RID: 645
	internal class SecT193Field
	{
		// Token: 0x06001BA0 RID: 7072 RVA: 0x00081783 File Offset: 0x0007F983
		public static void Add(ulong[] x, ulong[] y, ulong[] z)
		{
			z[0] = (x[0] ^ y[0]);
			z[1] = (x[1] ^ y[1]);
			z[2] = (x[2] ^ y[2]);
			z[3] = (x[3] ^ y[3]);
		}

		// Token: 0x06001BA1 RID: 7073 RVA: 0x000817B0 File Offset: 0x0007F9B0
		public static void AddExt(ulong[] xx, ulong[] yy, ulong[] zz)
		{
			zz[0] = (xx[0] ^ yy[0]);
			zz[1] = (xx[1] ^ yy[1]);
			zz[2] = (xx[2] ^ yy[2]);
			zz[3] = (xx[3] ^ yy[3]);
			zz[4] = (xx[4] ^ yy[4]);
			zz[5] = (xx[5] ^ yy[5]);
			zz[6] = (xx[6] ^ yy[6]);
		}

		// Token: 0x06001BA2 RID: 7074 RVA: 0x00081803 File Offset: 0x0007FA03
		public static void AddOne(ulong[] x, ulong[] z)
		{
			z[0] = (x[0] ^ 1UL);
			z[1] = x[1];
			z[2] = x[2];
			z[3] = x[3];
		}

		// Token: 0x06001BA3 RID: 7075 RVA: 0x00081820 File Offset: 0x0007FA20
		private static void AddTo(ulong[] x, ulong[] z)
		{
			z[0] ^= x[0];
			z[1] ^= x[1];
			z[2] ^= x[2];
			z[3] ^= x[3];
		}

		// Token: 0x06001BA4 RID: 7076 RVA: 0x0008185A File Offset: 0x0007FA5A
		public static ulong[] FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return global::Org.BouncyCastle.Math.Raw.Nat.FromBigInteger64(193, x);
		}

		// Token: 0x06001BA5 RID: 7077 RVA: 0x00081868 File Offset: 0x0007FA68
		public static void HalfTrace(ulong[] x, ulong[] z)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat256.CreateExt64();
			global::Org.BouncyCastle.Math.Raw.Nat256.Copy64(x, z);
			for (int i = 1; i < 193; i += 2)
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.ImplSquare(z, tt);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.Reduce(tt, z);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.ImplSquare(z, tt);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.Reduce(tt, z);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.AddTo(x, z);
			}
		}

		// Token: 0x06001BA6 RID: 7078 RVA: 0x000818B8 File Offset: 0x0007FAB8
		public static void Invert(ulong[] x, ulong[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat256.IsZero64(x))
			{
				throw new global::System.InvalidOperationException();
			}
			ulong[] t0 = global::Org.BouncyCastle.Math.Raw.Nat256.Create64();
			ulong[] t = global::Org.BouncyCastle.Math.Raw.Nat256.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.Square(x, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.SquareN(t0, 1, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.Multiply(t0, t, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.SquareN(t, 1, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.Multiply(t0, t, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.SquareN(t0, 3, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.Multiply(t0, t, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.SquareN(t0, 6, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.Multiply(t0, t, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.SquareN(t0, 12, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.Multiply(t0, t, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.SquareN(t0, 24, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.Multiply(t0, t, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.SquareN(t0, 48, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.Multiply(t0, t, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.SquareN(t0, 96, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.Multiply(t0, t, z);
		}

		// Token: 0x06001BA7 RID: 7079 RVA: 0x0008196C File Offset: 0x0007FB6C
		public static void Multiply(ulong[] x, ulong[] y, ulong[] z)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat256.CreateExt64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.ImplMultiply(x, y, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.Reduce(tt, z);
		}

		// Token: 0x06001BA8 RID: 7080 RVA: 0x00081990 File Offset: 0x0007FB90
		public static void MultiplyAddToExt(ulong[] x, ulong[] y, ulong[] zz)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat256.CreateExt64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.ImplMultiply(x, y, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.AddExt(zz, tt, zz);
		}

		// Token: 0x06001BA9 RID: 7081 RVA: 0x000819B4 File Offset: 0x0007FBB4
		public static void Reduce(ulong[] xx, ulong[] z)
		{
			ulong x0 = xx[0];
			ulong x = xx[1];
			ulong x2 = xx[2];
			ulong x3 = xx[3];
			ulong x4 = xx[4];
			ulong x5 = xx[5];
			ulong x6 = xx[6];
			x2 ^= x6 << 63;
			x3 ^= (x6 >> 1 ^ x6 << 14);
			x4 ^= x6 >> 50;
			x ^= x5 << 63;
			x2 ^= (x5 >> 1 ^ x5 << 14);
			x3 ^= x5 >> 50;
			x0 ^= x4 << 63;
			x ^= (x4 >> 1 ^ x4 << 14);
			x2 ^= x4 >> 50;
			ulong t = x3 >> 1;
			z[0] = (x0 ^ t ^ t << 15);
			z[1] = (x ^ t >> 49);
			z[2] = x2;
			z[3] = (x3 & 1UL);
		}

		// Token: 0x06001BAA RID: 7082 RVA: 0x00081A60 File Offset: 0x0007FC60
		public static void Reduce63(ulong[] z, int zOff)
		{
			ulong z2 = z[zOff + 3];
			ulong t = z2 >> 1;
			z[zOff] ^= (t ^ t << 15);
			z[zOff + 1] ^= t >> 49;
			z[zOff + 3] = (z2 & 1UL);
		}

		// Token: 0x06001BAB RID: 7083 RVA: 0x00081AA4 File Offset: 0x0007FCA4
		public static void Sqrt(ulong[] x, ulong[] z)
		{
			ulong num = global::Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x[0]);
			ulong u = global::Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x[1]);
			ulong e0 = (num & (ulong)-1) | u << 32;
			ulong c0 = num >> 32 | (u & 18446744069414584320UL);
			ulong num2 = global::Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x[2]);
			ulong e = (num2 & (ulong)-1) ^ x[3] << 32;
			ulong c = num2 >> 32;
			z[0] = (e0 ^ c0 << 8);
			z[1] = (e ^ c << 8 ^ c0 >> 56 ^ c0 << 33);
			z[2] = (c >> 56 ^ c << 33 ^ c0 >> 31);
			z[3] = c >> 31;
		}

		// Token: 0x06001BAC RID: 7084 RVA: 0x00081B2C File Offset: 0x0007FD2C
		public static void Square(ulong[] x, ulong[] z)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat256.CreateExt64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.ImplSquare(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.Reduce(tt, z);
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x00081B50 File Offset: 0x0007FD50
		public static void SquareAddToExt(ulong[] x, ulong[] zz)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat256.CreateExt64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.ImplSquare(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.AddExt(zz, tt, zz);
		}

		// Token: 0x06001BAE RID: 7086 RVA: 0x00081B74 File Offset: 0x0007FD74
		public static void SquareN(ulong[] x, int n, ulong[] z)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat256.CreateExt64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.ImplSquare(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.Reduce(tt, z);
			while (--n > 0)
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.ImplSquare(z, tt);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.Reduce(tt, z);
			}
		}

		// Token: 0x06001BAF RID: 7087 RVA: 0x00081BAE File Offset: 0x0007FDAE
		public static uint Trace(ulong[] x)
		{
			return (uint)x[0] & 1U;
		}

		// Token: 0x06001BB0 RID: 7088 RVA: 0x00081BB8 File Offset: 0x0007FDB8
		protected static void ImplCompactExt(ulong[] zz)
		{
			ulong z0 = zz[0];
			ulong z = zz[1];
			ulong z2 = zz[2];
			ulong z3 = zz[3];
			ulong z4 = zz[4];
			ulong z5 = zz[5];
			ulong z6 = zz[6];
			ulong z7 = zz[7];
			zz[0] = (z0 ^ z << 49);
			zz[1] = (z >> 15 ^ z2 << 34);
			zz[2] = (z2 >> 30 ^ z3 << 19);
			zz[3] = (z3 >> 45 ^ z4 << 4 ^ z5 << 53);
			zz[4] = (z4 >> 60 ^ z6 << 38 ^ z5 >> 11);
			zz[5] = (z6 >> 26 ^ z7 << 23);
			zz[6] = z7 >> 41;
			zz[7] = 0UL;
		}

		// Token: 0x06001BB1 RID: 7089 RVA: 0x00081C4C File Offset: 0x0007FE4C
		protected static void ImplExpand(ulong[] x, ulong[] z)
		{
			ulong x2 = x[0];
			ulong x3 = x[1];
			ulong x4 = x[2];
			ulong x5 = x[3];
			z[0] = (x2 & 562949953421311UL);
			z[1] = ((x2 >> 49 ^ x3 << 15) & 562949953421311UL);
			z[2] = ((x3 >> 34 ^ x4 << 30) & 562949953421311UL);
			z[3] = (x4 >> 19 ^ x5 << 45);
		}

		// Token: 0x06001BB2 RID: 7090 RVA: 0x00081CB0 File Offset: 0x0007FEB0
		protected static void ImplMultiply(ulong[] x, ulong[] y, ulong[] zz)
		{
			ulong[] f = new ulong[4];
			ulong[] g = new ulong[4];
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.ImplExpand(x, f);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.ImplExpand(y, g);
			ulong[] u = new ulong[8];
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.ImplMulwAcc(u, f[0], g[0], zz, 0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.ImplMulwAcc(u, f[1], g[1], zz, 1);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.ImplMulwAcc(u, f[2], g[2], zz, 2);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.ImplMulwAcc(u, f[3], g[3], zz, 3);
			for (int i = 5; i > 0; i--)
			{
				zz[i] ^= zz[i - 1];
			}
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.ImplMulwAcc(u, f[0] ^ f[1], g[0] ^ g[1], zz, 1);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.ImplMulwAcc(u, f[2] ^ f[3], g[2] ^ g[3], zz, 3);
			for (int j = 7; j > 1; j--)
			{
				zz[j] ^= zz[j - 2];
			}
			ulong c0 = f[0] ^ f[2];
			ulong c = f[1] ^ f[3];
			ulong d0 = g[0] ^ g[2];
			ulong d = g[1] ^ g[3];
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.ImplMulwAcc(u, c0 ^ c, d0 ^ d, zz, 3);
			ulong[] t = new ulong[3];
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.ImplMulwAcc(u, c0, d0, t, 0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.ImplMulwAcc(u, c, d, t, 1);
			ulong t2 = t[0];
			ulong t3 = t[1];
			ulong t4 = t[2];
			zz[2] ^= t2;
			zz[3] ^= (t2 ^ t3);
			zz[4] ^= (t4 ^ t3);
			zz[5] ^= t4;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193Field.ImplCompactExt(zz);
		}

		// Token: 0x06001BB3 RID: 7091 RVA: 0x00081E2C File Offset: 0x0008002C
		protected static void ImplMulwAcc(ulong[] u, ulong x, ulong y, ulong[] z, int zOff)
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
			ulong j = u[(int)(i & 7U)] ^ u[(int)(i >> 3 & 7U)] << 3;
			int k = 36;
			do
			{
				i = (uint)(x >> k);
				ulong g = u[(int)(i & 7U)] ^ u[(int)(i >> 3 & 7U)] << 3 ^ u[(int)(i >> 6 & 7U)] << 6 ^ u[(int)(i >> 9 & 7U)] << 9 ^ u[(int)(i >> 12 & 7U)] << 12;
				j ^= g << k;
				h ^= g >> -k;
			}
			while ((k -= 15) > 0);
			z[zOff] ^= (j & 562949953421311UL);
			z[zOff + 1] ^= (j >> 49 ^ h << 15);
		}

		// Token: 0x06001BB4 RID: 7092 RVA: 0x00081F10 File Offset: 0x00080110
		protected static void ImplSquare(ulong[] x, ulong[] zz)
		{
			global::Org.BouncyCastle.Math.Raw.Interleave.Expand64To128(x, 0, 3, zz, 0);
			zz[6] = (x[3] & 1UL);
		}

		// Token: 0x04000AAE RID: 2734
		private const ulong M01 = 1UL;

		// Token: 0x04000AAF RID: 2735
		private const ulong M49 = 562949953421311UL;
	}
}
