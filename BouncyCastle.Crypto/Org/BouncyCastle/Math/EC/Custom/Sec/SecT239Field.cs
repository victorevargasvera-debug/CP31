using System;
using Org.BouncyCastle.Math.Raw;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x02000291 RID: 657
	internal class SecT239Field
	{
		// Token: 0x06001C7B RID: 7291 RVA: 0x00084D2F File Offset: 0x00082F2F
		public static void Add(ulong[] x, ulong[] y, ulong[] z)
		{
			z[0] = (x[0] ^ y[0]);
			z[1] = (x[1] ^ y[1]);
			z[2] = (x[2] ^ y[2]);
			z[3] = (x[3] ^ y[3]);
		}

		// Token: 0x06001C7C RID: 7292 RVA: 0x00084D5C File Offset: 0x00082F5C
		public static void AddExt(ulong[] xx, ulong[] yy, ulong[] zz)
		{
			zz[0] = (xx[0] ^ yy[0]);
			zz[1] = (xx[1] ^ yy[1]);
			zz[2] = (xx[2] ^ yy[2]);
			zz[3] = (xx[3] ^ yy[3]);
			zz[4] = (xx[4] ^ yy[4]);
			zz[5] = (xx[5] ^ yy[5]);
			zz[6] = (xx[6] ^ yy[6]);
			zz[7] = (xx[7] ^ yy[7]);
		}

		// Token: 0x06001C7D RID: 7293 RVA: 0x00084DB9 File Offset: 0x00082FB9
		public static void AddOne(ulong[] x, ulong[] z)
		{
			z[0] = (x[0] ^ 1UL);
			z[1] = x[1];
			z[2] = x[2];
			z[3] = x[3];
		}

		// Token: 0x06001C7E RID: 7294 RVA: 0x00084DD6 File Offset: 0x00082FD6
		private static void AddTo(ulong[] x, ulong[] z)
		{
			z[0] ^= x[0];
			z[1] ^= x[1];
			z[2] ^= x[2];
			z[3] ^= x[3];
		}

		// Token: 0x06001C7F RID: 7295 RVA: 0x00084E10 File Offset: 0x00083010
		public static ulong[] FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return global::Org.BouncyCastle.Math.Raw.Nat.FromBigInteger64(239, x);
		}

		// Token: 0x06001C80 RID: 7296 RVA: 0x00084E20 File Offset: 0x00083020
		public static void HalfTrace(ulong[] x, ulong[] z)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat256.CreateExt64();
			global::Org.BouncyCastle.Math.Raw.Nat256.Copy64(x, z);
			for (int i = 1; i < 239; i += 2)
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.ImplSquare(z, tt);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Reduce(tt, z);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.ImplSquare(z, tt);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Reduce(tt, z);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.AddTo(x, z);
			}
		}

		// Token: 0x06001C81 RID: 7297 RVA: 0x00084E70 File Offset: 0x00083070
		public static void Invert(ulong[] x, ulong[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat256.IsZero64(x))
			{
				throw new global::System.InvalidOperationException();
			}
			ulong[] t0 = global::Org.BouncyCastle.Math.Raw.Nat256.Create64();
			ulong[] t = global::Org.BouncyCastle.Math.Raw.Nat256.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Square(x, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Multiply(t0, x, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Square(t0, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Multiply(t0, x, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.SquareN(t0, 3, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Multiply(t, t0, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Square(t, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Multiply(t, x, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.SquareN(t, 7, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Multiply(t0, t, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.SquareN(t0, 14, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Multiply(t, t0, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Square(t, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Multiply(t, x, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.SquareN(t, 29, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Multiply(t0, t, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Square(t0, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Multiply(t0, x, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.SquareN(t0, 59, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Multiply(t, t0, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Square(t, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Multiply(t, x, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.SquareN(t, 119, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Multiply(t0, t, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Square(t0, z);
		}

		// Token: 0x06001C82 RID: 7298 RVA: 0x00084F5C File Offset: 0x0008315C
		public static void Multiply(ulong[] x, ulong[] y, ulong[] z)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat256.CreateExt64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.ImplMultiply(x, y, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Reduce(tt, z);
		}

		// Token: 0x06001C83 RID: 7299 RVA: 0x00084F80 File Offset: 0x00083180
		public static void MultiplyAddToExt(ulong[] x, ulong[] y, ulong[] zz)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat256.CreateExt64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.ImplMultiply(x, y, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.AddExt(zz, tt, zz);
		}

		// Token: 0x06001C84 RID: 7300 RVA: 0x00084FA4 File Offset: 0x000831A4
		public static void Reduce(ulong[] xx, ulong[] z)
		{
			ulong x0 = xx[0];
			ulong x = xx[1];
			ulong x2 = xx[2];
			ulong x3 = xx[3];
			ulong x4 = xx[4];
			ulong x5 = xx[5];
			ulong x6 = xx[6];
			ulong x7 = xx[7];
			x3 ^= x7 << 17;
			x4 ^= x7 >> 47;
			x5 ^= x7 << 47;
			x6 ^= x7 >> 17;
			x2 ^= x6 << 17;
			x3 ^= x6 >> 47;
			x4 ^= x6 << 47;
			x5 ^= x6 >> 17;
			x ^= x5 << 17;
			x2 ^= x5 >> 47;
			x3 ^= x5 << 47;
			x4 ^= x5 >> 17;
			x0 ^= x4 << 17;
			x ^= x4 >> 47;
			x2 ^= x4 << 47;
			x3 ^= x4 >> 17;
			ulong t = x3 >> 47;
			z[0] = (x0 ^ t);
			z[1] = x;
			z[2] = (x2 ^ t << 30);
			z[3] = (x3 & 140737488355327UL);
		}

		// Token: 0x06001C85 RID: 7301 RVA: 0x0008508C File Offset: 0x0008328C
		public static void Reduce17(ulong[] z, int zOff)
		{
			ulong z2 = z[zOff + 3];
			ulong t = z2 >> 47;
			z[zOff] ^= t;
			z[zOff + 2] ^= t << 30;
			z[zOff + 3] = (z2 & 140737488355327UL);
		}

		// Token: 0x06001C86 RID: 7302 RVA: 0x000850D4 File Offset: 0x000832D4
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
			ulong c2 = c >> 49;
			ulong c3 = c0 >> 49 | c << 15;
			c ^= c0 << 15;
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat256.CreateExt64();
			int[] shifts = new int[]
			{
				39,
				120
			};
			for (int i = 0; i < shifts.Length; i++)
			{
				int w = shifts[i] >> 6;
				int s = shifts[i] & 63;
				tt[w] ^= c0 << s;
				tt[w + 1] ^= (c << s | c0 >> -s);
				tt[w + 2] ^= (c3 << s | c >> -s);
				tt[w + 3] ^= (c2 << s | c3 >> -s);
				tt[w + 4] ^= c2 >> -s;
			}
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Reduce(tt, z);
			z[0] ^= e0;
			z[1] ^= e;
		}

		// Token: 0x06001C87 RID: 7303 RVA: 0x00085248 File Offset: 0x00083448
		public static void Square(ulong[] x, ulong[] z)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat256.CreateExt64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.ImplSquare(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Reduce(tt, z);
		}

		// Token: 0x06001C88 RID: 7304 RVA: 0x0008526C File Offset: 0x0008346C
		public static void SquareAddToExt(ulong[] x, ulong[] zz)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat256.CreateExt64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.ImplSquare(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.AddExt(zz, tt, zz);
		}

		// Token: 0x06001C89 RID: 7305 RVA: 0x00085290 File Offset: 0x00083490
		public static void SquareN(ulong[] x, int n, ulong[] z)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat256.CreateExt64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.ImplSquare(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Reduce(tt, z);
			while (--n > 0)
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.ImplSquare(z, tt);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.Reduce(tt, z);
			}
		}

		// Token: 0x06001C8A RID: 7306 RVA: 0x000852CA File Offset: 0x000834CA
		public static uint Trace(ulong[] x)
		{
			return (uint)(x[0] ^ x[1] >> 17 ^ x[2] >> 34) & 1U;
		}

		// Token: 0x06001C8B RID: 7307 RVA: 0x000852E0 File Offset: 0x000834E0
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
			zz[0] = (z0 ^ z << 60);
			zz[1] = (z >> 4 ^ z2 << 56);
			zz[2] = (z2 >> 8 ^ z3 << 52);
			zz[3] = (z3 >> 12 ^ z4 << 48);
			zz[4] = (z4 >> 16 ^ z5 << 44);
			zz[5] = (z5 >> 20 ^ z6 << 40);
			zz[6] = (z6 >> 24 ^ z7 << 36);
			zz[7] = z7 >> 28;
		}

		// Token: 0x06001C8C RID: 7308 RVA: 0x00085370 File Offset: 0x00083570
		protected static void ImplExpand(ulong[] x, ulong[] z)
		{
			ulong x2 = x[0];
			ulong x3 = x[1];
			ulong x4 = x[2];
			ulong x5 = x[3];
			z[0] = (x2 & 1152921504606846975UL);
			z[1] = ((x2 >> 60 ^ x3 << 4) & 1152921504606846975UL);
			z[2] = ((x3 >> 56 ^ x4 << 8) & 1152921504606846975UL);
			z[3] = (x4 >> 52 ^ x5 << 12);
		}

		// Token: 0x06001C8D RID: 7309 RVA: 0x000853D4 File Offset: 0x000835D4
		protected static void ImplMultiply(ulong[] x, ulong[] y, ulong[] zz)
		{
			ulong[] f = new ulong[4];
			ulong[] g = new ulong[4];
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.ImplExpand(x, f);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.ImplExpand(y, g);
			ulong[] u = new ulong[8];
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.ImplMulwAcc(u, f[0], g[0], zz, 0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.ImplMulwAcc(u, f[1], g[1], zz, 1);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.ImplMulwAcc(u, f[2], g[2], zz, 2);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.ImplMulwAcc(u, f[3], g[3], zz, 3);
			for (int i = 5; i > 0; i--)
			{
				zz[i] ^= zz[i - 1];
			}
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.ImplMulwAcc(u, f[0] ^ f[1], g[0] ^ g[1], zz, 1);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.ImplMulwAcc(u, f[2] ^ f[3], g[2] ^ g[3], zz, 3);
			for (int j = 7; j > 1; j--)
			{
				zz[j] ^= zz[j - 2];
			}
			ulong c0 = f[0] ^ f[2];
			ulong c = f[1] ^ f[3];
			ulong d0 = g[0] ^ g[2];
			ulong d = g[1] ^ g[3];
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.ImplMulwAcc(u, c0 ^ c, d0 ^ d, zz, 3);
			ulong[] t = new ulong[3];
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.ImplMulwAcc(u, c0, d0, t, 0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.ImplMulwAcc(u, c, d, t, 1);
			ulong t2 = t[0];
			ulong t3 = t[1];
			ulong t4 = t[2];
			zz[2] ^= t2;
			zz[3] ^= (t2 ^ t3);
			zz[4] ^= (t4 ^ t3);
			zz[5] ^= t4;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239Field.ImplCompactExt(zz);
		}

		// Token: 0x06001C8E RID: 7310 RVA: 0x00085550 File Offset: 0x00083750
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
			h ^= (x & 585610922974906400UL & y << 4 >> 63) >> 5;
			z[zOff] ^= (j & 1152921504606846975UL);
			z[zOff + 1] ^= (j >> 60 ^ h << 4);
		}

		// Token: 0x06001C8F RID: 7311 RVA: 0x00085627 File Offset: 0x00083827
		protected static void ImplSquare(ulong[] x, ulong[] zz)
		{
			global::Org.BouncyCastle.Math.Raw.Interleave.Expand64To128(x, 0, 4, zz, 0);
		}

		// Token: 0x04000AC4 RID: 2756
		private const ulong M47 = 140737488355327UL;

		// Token: 0x04000AC5 RID: 2757
		private const ulong M60 = 1152921504606846975UL;
	}
}
