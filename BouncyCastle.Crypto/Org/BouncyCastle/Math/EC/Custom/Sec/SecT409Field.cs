using System;
using Org.BouncyCastle.Math.Raw;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x0200029B RID: 667
	internal class SecT409Field
	{
		// Token: 0x06001D3E RID: 7486 RVA: 0x00087DC4 File Offset: 0x00085FC4
		public static void Add(ulong[] x, ulong[] y, ulong[] z)
		{
			z[0] = (x[0] ^ y[0]);
			z[1] = (x[1] ^ y[1]);
			z[2] = (x[2] ^ y[2]);
			z[3] = (x[3] ^ y[3]);
			z[4] = (x[4] ^ y[4]);
			z[5] = (x[5] ^ y[5]);
			z[6] = (x[6] ^ y[6]);
		}

		// Token: 0x06001D3F RID: 7487 RVA: 0x00087E18 File Offset: 0x00086018
		public static void AddExt(ulong[] xx, ulong[] yy, ulong[] zz)
		{
			for (int i = 0; i < 13; i++)
			{
				zz[i] = (xx[i] ^ yy[i]);
			}
		}

		// Token: 0x06001D40 RID: 7488 RVA: 0x00087E3C File Offset: 0x0008603C
		public static void AddOne(ulong[] x, ulong[] z)
		{
			z[0] = (x[0] ^ 1UL);
			z[1] = x[1];
			z[2] = x[2];
			z[3] = x[3];
			z[4] = x[4];
			z[5] = x[5];
			z[6] = x[6];
		}

		// Token: 0x06001D41 RID: 7489 RVA: 0x00087E6C File Offset: 0x0008606C
		private static void AddTo(ulong[] x, ulong[] z)
		{
			z[0] ^= x[0];
			z[1] ^= x[1];
			z[2] ^= x[2];
			z[3] ^= x[3];
			z[4] ^= x[4];
			z[5] ^= x[5];
			z[6] ^= x[6];
		}

		// Token: 0x06001D42 RID: 7490 RVA: 0x00087EDB File Offset: 0x000860DB
		public static ulong[] FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return global::Org.BouncyCastle.Math.Raw.Nat.FromBigInteger64(409, x);
		}

		// Token: 0x06001D43 RID: 7491 RVA: 0x00087EE8 File Offset: 0x000860E8
		public static void HalfTrace(ulong[] x, ulong[] z)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat.Create64(13);
			global::Org.BouncyCastle.Math.Raw.Nat448.Copy64(x, z);
			for (int i = 1; i < 409; i += 2)
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.ImplSquare(z, tt);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.Reduce(tt, z);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.ImplSquare(z, tt);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.Reduce(tt, z);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.AddTo(x, z);
			}
		}

		// Token: 0x06001D44 RID: 7492 RVA: 0x00087F38 File Offset: 0x00086138
		public static void Invert(ulong[] x, ulong[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat448.IsZero64(x))
			{
				throw new global::System.InvalidOperationException();
			}
			ulong[] t0 = global::Org.BouncyCastle.Math.Raw.Nat448.Create64();
			ulong[] t = global::Org.BouncyCastle.Math.Raw.Nat448.Create64();
			ulong[] t2 = global::Org.BouncyCastle.Math.Raw.Nat448.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.Square(x, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.SquareN(t0, 1, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.Multiply(t0, t, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.SquareN(t, 1, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.Multiply(t0, t, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.SquareN(t0, 3, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.Multiply(t0, t, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.SquareN(t0, 6, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.Multiply(t0, t, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.SquareN(t0, 12, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.Multiply(t0, t, t2);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.SquareN(t2, 24, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.SquareN(t0, 24, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.Multiply(t0, t, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.SquareN(t0, 48, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.Multiply(t0, t, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.SquareN(t0, 96, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.Multiply(t0, t, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.SquareN(t0, 192, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.Multiply(t0, t, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.Multiply(t0, t2, z);
		}

		// Token: 0x06001D45 RID: 7493 RVA: 0x00088018 File Offset: 0x00086218
		public static void Multiply(ulong[] x, ulong[] y, ulong[] z)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat448.CreateExt64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.ImplMultiply(x, y, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.Reduce(tt, z);
		}

		// Token: 0x06001D46 RID: 7494 RVA: 0x0008803C File Offset: 0x0008623C
		public static void MultiplyAddToExt(ulong[] x, ulong[] y, ulong[] zz)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat448.CreateExt64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.ImplMultiply(x, y, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.AddExt(zz, tt, zz);
		}

		// Token: 0x06001D47 RID: 7495 RVA: 0x00088060 File Offset: 0x00086260
		public static void Reduce(ulong[] xx, ulong[] z)
		{
			ulong x0 = xx[0];
			ulong x = xx[1];
			ulong x2 = xx[2];
			ulong x3 = xx[3];
			ulong x4 = xx[4];
			ulong x5 = xx[5];
			ulong x6 = xx[6];
			ulong num = xx[7];
			ulong u = xx[12];
			x5 ^= u << 39;
			x6 ^= (u >> 25 ^ u << 62);
			ulong num2 = num ^ u >> 2;
			u = xx[11];
			x4 ^= u << 39;
			x5 ^= (u >> 25 ^ u << 62);
			x6 ^= u >> 2;
			u = xx[10];
			x3 ^= u << 39;
			x4 ^= (u >> 25 ^ u << 62);
			x5 ^= u >> 2;
			u = xx[9];
			x2 ^= u << 39;
			x3 ^= (u >> 25 ^ u << 62);
			x4 ^= u >> 2;
			u = xx[8];
			x ^= u << 39;
			x2 ^= (u >> 25 ^ u << 62);
			x3 ^= u >> 2;
			u = num2;
			x0 ^= u << 39;
			x ^= (u >> 25 ^ u << 62);
			x2 ^= u >> 2;
			ulong t = x6 >> 25;
			z[0] = (x0 ^ t);
			z[1] = (x ^ t << 23);
			z[2] = x2;
			z[3] = x3;
			z[4] = x4;
			z[5] = x5;
			z[6] = (x6 & 33554431UL);
		}

		// Token: 0x06001D48 RID: 7496 RVA: 0x000881A0 File Offset: 0x000863A0
		public static void Reduce39(ulong[] z, int zOff)
		{
			ulong z2 = z[zOff + 6];
			ulong t = z2 >> 25;
			z[zOff] ^= t;
			z[zOff + 1] ^= t << 23;
			z[zOff + 6] = (z2 & 33554431UL);
		}

		// Token: 0x06001D49 RID: 7497 RVA: 0x000881E4 File Offset: 0x000863E4
		public static void Sqrt(ulong[] x, ulong[] z)
		{
			ulong num = global::Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x[0]);
			ulong u = global::Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x[1]);
			ulong e0 = (num & (ulong)-1) | u << 32;
			ulong c0 = num >> 32 | (u & 18446744069414584320UL);
			ulong num2 = global::Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x[2]);
			u = global::Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x[3]);
			ulong e = (num2 & (ulong)-1) | u << 32;
			ulong c = num2 >> 32 | (u & 18446744069414584320UL);
			ulong num3 = global::Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x[4]);
			u = global::Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x[5]);
			ulong e2 = (num3 & (ulong)-1) | u << 32;
			ulong c2 = num3 >> 32 | (u & 18446744069414584320UL);
			ulong num4 = global::Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x[6]);
			ulong e3 = num4 & (ulong)-1;
			ulong c3 = num4 >> 32;
			z[0] = (e0 ^ c0 << 44);
			z[1] = (e ^ c << 44 ^ c0 >> 20);
			z[2] = (e2 ^ c2 << 44 ^ c >> 20);
			z[3] = (e3 ^ c3 << 44 ^ c2 >> 20 ^ c0 << 13);
			z[4] = (c3 >> 20 ^ c << 13 ^ c0 >> 51);
			z[5] = (c2 << 13 ^ c >> 51);
			z[6] = (c3 << 13 ^ c2 >> 51);
		}

		// Token: 0x06001D4A RID: 7498 RVA: 0x000882F8 File Offset: 0x000864F8
		public static void Square(ulong[] x, ulong[] z)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat.Create64(13);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.ImplSquare(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.Reduce(tt, z);
		}

		// Token: 0x06001D4B RID: 7499 RVA: 0x0008831C File Offset: 0x0008651C
		public static void SquareAddToExt(ulong[] x, ulong[] zz)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat.Create64(13);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.ImplSquare(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.AddExt(zz, tt, zz);
		}

		// Token: 0x06001D4C RID: 7500 RVA: 0x00088340 File Offset: 0x00086540
		public static void SquareN(ulong[] x, int n, ulong[] z)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat.Create64(13);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.ImplSquare(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.Reduce(tt, z);
			while (--n > 0)
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.ImplSquare(z, tt);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.Reduce(tt, z);
			}
		}

		// Token: 0x06001D4D RID: 7501 RVA: 0x0008837C File Offset: 0x0008657C
		public static uint Trace(ulong[] x)
		{
			return (uint)x[0] & 1U;
		}

		// Token: 0x06001D4E RID: 7502 RVA: 0x00088384 File Offset: 0x00086584
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
			ulong z8 = zz[8];
			ulong z9 = zz[9];
			ulong z10 = zz[10];
			ulong z11 = zz[11];
			ulong z12 = zz[12];
			ulong z13 = zz[13];
			zz[0] = (z0 ^ z << 59);
			zz[1] = (z >> 5 ^ z2 << 54);
			zz[2] = (z2 >> 10 ^ z3 << 49);
			zz[3] = (z3 >> 15 ^ z4 << 44);
			zz[4] = (z4 >> 20 ^ z5 << 39);
			zz[5] = (z5 >> 25 ^ z6 << 34);
			zz[6] = (z6 >> 30 ^ z7 << 29);
			zz[7] = (z7 >> 35 ^ z8 << 24);
			zz[8] = (z8 >> 40 ^ z9 << 19);
			zz[9] = (z9 >> 45 ^ z10 << 14);
			zz[10] = (z10 >> 50 ^ z11 << 9);
			zz[11] = (z11 >> 55 ^ z12 << 4 ^ z13 << 63);
			zz[12] = z13 >> 1;
		}

		// Token: 0x06001D4F RID: 7503 RVA: 0x00088488 File Offset: 0x00086688
		protected static void ImplExpand(ulong[] x, ulong[] z)
		{
			ulong x2 = x[0];
			ulong x3 = x[1];
			ulong x4 = x[2];
			ulong x5 = x[3];
			ulong x6 = x[4];
			ulong x7 = x[5];
			ulong x8 = x[6];
			z[0] = (x2 & 576460752303423487UL);
			z[1] = ((x2 >> 59 ^ x3 << 5) & 576460752303423487UL);
			z[2] = ((x3 >> 54 ^ x4 << 10) & 576460752303423487UL);
			z[3] = ((x4 >> 49 ^ x5 << 15) & 576460752303423487UL);
			z[4] = ((x5 >> 44 ^ x6 << 20) & 576460752303423487UL);
			z[5] = ((x6 >> 39 ^ x7 << 25) & 576460752303423487UL);
			z[6] = (x7 >> 34 ^ x8 << 30);
		}

		// Token: 0x06001D50 RID: 7504 RVA: 0x00088540 File Offset: 0x00086740
		protected static void ImplMultiply(ulong[] x, ulong[] y, ulong[] zz)
		{
			ulong[] a = new ulong[7];
			ulong[] b = new ulong[7];
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.ImplExpand(x, a);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.ImplExpand(y, b);
			ulong[] u = new ulong[8];
			for (int i = 0; i < 7; i++)
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.ImplMulwAcc(u, a[i], b[i], zz, i << 1);
			}
			ulong v0 = zz[0];
			ulong v = zz[1];
			v0 ^= zz[2];
			zz[1] = (v0 ^ v);
			v ^= zz[3];
			v0 ^= zz[4];
			zz[2] = (v0 ^ v);
			v ^= zz[5];
			v0 ^= zz[6];
			zz[3] = (v0 ^ v);
			v ^= zz[7];
			v0 ^= zz[8];
			zz[4] = (v0 ^ v);
			v ^= zz[9];
			v0 ^= zz[10];
			zz[5] = (v0 ^ v);
			v ^= zz[11];
			v0 ^= zz[12];
			zz[6] = (v0 ^ v);
			v ^= zz[13];
			ulong w = v0 ^ v;
			zz[7] = (zz[0] ^ w);
			zz[8] = (zz[1] ^ w);
			zz[9] = (zz[2] ^ w);
			zz[10] = (zz[3] ^ w);
			zz[11] = (zz[4] ^ w);
			zz[12] = (zz[5] ^ w);
			zz[13] = (zz[6] ^ w);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.ImplMulwAcc(u, a[0] ^ a[1], b[0] ^ b[1], zz, 1);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.ImplMulwAcc(u, a[0] ^ a[2], b[0] ^ b[2], zz, 2);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.ImplMulwAcc(u, a[0] ^ a[3], b[0] ^ b[3], zz, 3);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.ImplMulwAcc(u, a[1] ^ a[2], b[1] ^ b[2], zz, 3);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.ImplMulwAcc(u, a[0] ^ a[4], b[0] ^ b[4], zz, 4);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.ImplMulwAcc(u, a[1] ^ a[3], b[1] ^ b[3], zz, 4);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.ImplMulwAcc(u, a[0] ^ a[5], b[0] ^ b[5], zz, 5);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.ImplMulwAcc(u, a[1] ^ a[4], b[1] ^ b[4], zz, 5);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.ImplMulwAcc(u, a[2] ^ a[3], b[2] ^ b[3], zz, 5);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.ImplMulwAcc(u, a[0] ^ a[6], b[0] ^ b[6], zz, 6);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.ImplMulwAcc(u, a[1] ^ a[5], b[1] ^ b[5], zz, 6);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.ImplMulwAcc(u, a[2] ^ a[4], b[2] ^ b[4], zz, 6);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.ImplMulwAcc(u, a[1] ^ a[6], b[1] ^ b[6], zz, 7);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.ImplMulwAcc(u, a[2] ^ a[5], b[2] ^ b[5], zz, 7);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.ImplMulwAcc(u, a[3] ^ a[4], b[3] ^ b[4], zz, 7);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.ImplMulwAcc(u, a[2] ^ a[6], b[2] ^ b[6], zz, 8);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.ImplMulwAcc(u, a[3] ^ a[5], b[3] ^ b[5], zz, 8);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.ImplMulwAcc(u, a[3] ^ a[6], b[3] ^ b[6], zz, 9);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.ImplMulwAcc(u, a[4] ^ a[5], b[4] ^ b[5], zz, 9);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.ImplMulwAcc(u, a[4] ^ a[6], b[4] ^ b[6], zz, 10);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.ImplMulwAcc(u, a[5] ^ a[6], b[5] ^ b[6], zz, 11);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409Field.ImplCompactExt(zz);
		}

		// Token: 0x06001D51 RID: 7505 RVA: 0x00088844 File Offset: 0x00086A44
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
			int k = 54;
			do
			{
				i = (uint)(x >> k);
				ulong g = u[(int)(i & 7U)] ^ u[(int)(i >> 3 & 7U)] << 3;
				j ^= g << k;
				h ^= g >> -k;
			}
			while ((k -= 6) > 0);
			z[zOff] ^= (j & 576460752303423487UL);
			z[zOff + 1] ^= (j >> 59 ^ h << 5);
		}

		// Token: 0x06001D52 RID: 7506 RVA: 0x00088904 File Offset: 0x00086B04
		protected static void ImplSquare(ulong[] x, ulong[] zz)
		{
			global::Org.BouncyCastle.Math.Raw.Interleave.Expand64To128(x, 0, 6, zz, 0);
			zz[12] = global::Org.BouncyCastle.Math.Raw.Interleave.Expand32to64((uint)x[6]);
		}

		// Token: 0x04000AD7 RID: 2775
		private const ulong M25 = 33554431UL;

		// Token: 0x04000AD8 RID: 2776
		private const ulong M59 = 576460752303423487UL;
	}
}
