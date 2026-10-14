using System;
using Org.BouncyCastle.Math.Raw;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x0200028B RID: 651
	internal class SecT233Field
	{
		// Token: 0x06001C0D RID: 7181 RVA: 0x0008321B File Offset: 0x0008141B
		public static void Add(ulong[] x, ulong[] y, ulong[] z)
		{
			z[0] = (x[0] ^ y[0]);
			z[1] = (x[1] ^ y[1]);
			z[2] = (x[2] ^ y[2]);
			z[3] = (x[3] ^ y[3]);
		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x00083248 File Offset: 0x00081448
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

		// Token: 0x06001C0F RID: 7183 RVA: 0x000832A5 File Offset: 0x000814A5
		public static void AddOne(ulong[] x, ulong[] z)
		{
			z[0] = (x[0] ^ 1UL);
			z[1] = x[1];
			z[2] = x[2];
			z[3] = x[3];
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x000832C2 File Offset: 0x000814C2
		private static void AddTo(ulong[] x, ulong[] z)
		{
			z[0] ^= x[0];
			z[1] ^= x[1];
			z[2] ^= x[2];
			z[3] ^= x[3];
		}

		// Token: 0x06001C11 RID: 7185 RVA: 0x000832FC File Offset: 0x000814FC
		public static ulong[] FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return global::Org.BouncyCastle.Math.Raw.Nat.FromBigInteger64(233, x);
		}

		// Token: 0x06001C12 RID: 7186 RVA: 0x0008330C File Offset: 0x0008150C
		public static void HalfTrace(ulong[] x, ulong[] z)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat256.CreateExt64();
			global::Org.BouncyCastle.Math.Raw.Nat256.Copy64(x, z);
			for (int i = 1; i < 233; i += 2)
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.ImplSquare(z, tt);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Reduce(tt, z);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.ImplSquare(z, tt);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Reduce(tt, z);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.AddTo(x, z);
			}
		}

		// Token: 0x06001C13 RID: 7187 RVA: 0x0008335C File Offset: 0x0008155C
		public static void Invert(ulong[] x, ulong[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat256.IsZero64(x))
			{
				throw new global::System.InvalidOperationException();
			}
			ulong[] t0 = global::Org.BouncyCastle.Math.Raw.Nat256.Create64();
			ulong[] t = global::Org.BouncyCastle.Math.Raw.Nat256.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Square(x, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Multiply(t0, x, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Square(t0, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Multiply(t0, x, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.SquareN(t0, 3, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Multiply(t, t0, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Square(t, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Multiply(t, x, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.SquareN(t, 7, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Multiply(t0, t, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.SquareN(t0, 14, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Multiply(t, t0, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Square(t, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Multiply(t, x, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.SquareN(t, 29, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Multiply(t0, t, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.SquareN(t0, 58, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Multiply(t, t0, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.SquareN(t, 116, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Multiply(t0, t, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Square(t0, z);
		}

		// Token: 0x06001C14 RID: 7188 RVA: 0x0008342C File Offset: 0x0008162C
		public static void Multiply(ulong[] x, ulong[] y, ulong[] z)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat256.CreateExt64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.ImplMultiply(x, y, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Reduce(tt, z);
		}

		// Token: 0x06001C15 RID: 7189 RVA: 0x00083450 File Offset: 0x00081650
		public static void MultiplyAddToExt(ulong[] x, ulong[] y, ulong[] zz)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat256.CreateExt64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.ImplMultiply(x, y, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.AddExt(zz, tt, zz);
		}

		// Token: 0x06001C16 RID: 7190 RVA: 0x00083474 File Offset: 0x00081674
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
			x3 ^= x7 << 23;
			x4 ^= (x7 >> 41 ^ x7 << 33);
			x5 ^= x7 >> 31;
			x2 ^= x6 << 23;
			x3 ^= (x6 >> 41 ^ x6 << 33);
			x4 ^= x6 >> 31;
			x ^= x5 << 23;
			x2 ^= (x5 >> 41 ^ x5 << 33);
			x3 ^= x5 >> 31;
			x0 ^= x4 << 23;
			x ^= (x4 >> 41 ^ x4 << 33);
			x2 ^= x4 >> 31;
			ulong t = x3 >> 41;
			z[0] = (x0 ^ t);
			z[1] = (x ^ t << 10);
			z[2] = x2;
			z[3] = (x3 & 2199023255551UL);
		}

		// Token: 0x06001C17 RID: 7191 RVA: 0x0008354C File Offset: 0x0008174C
		public static void Reduce23(ulong[] z, int zOff)
		{
			ulong z2 = z[zOff + 3];
			ulong t = z2 >> 41;
			z[zOff] ^= t;
			z[zOff + 1] ^= t << 10;
			z[zOff + 3] = (z2 & 2199023255551UL);
		}

		// Token: 0x06001C18 RID: 7192 RVA: 0x00083594 File Offset: 0x00081794
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
			ulong c2 = c >> 27;
			c ^= (c0 >> 27 | c << 37);
			c0 ^= c0 << 37;
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat256.CreateExt64();
			int[] shifts = new int[]
			{
				32,
				117,
				191
			};
			for (int i = 0; i < shifts.Length; i++)
			{
				int w = shifts[i] >> 6;
				int s = shifts[i] & 63;
				tt[w] ^= c0 << s;
				tt[w + 1] ^= (c << s | c0 >> -s);
				tt[w + 2] ^= (c2 << s | c >> -s);
				tt[w + 3] ^= c2 >> -s;
			}
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Reduce(tt, z);
			z[0] ^= e0;
			z[1] ^= e;
		}

		// Token: 0x06001C19 RID: 7193 RVA: 0x000836E8 File Offset: 0x000818E8
		public static void Square(ulong[] x, ulong[] z)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat256.CreateExt64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.ImplSquare(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Reduce(tt, z);
		}

		// Token: 0x06001C1A RID: 7194 RVA: 0x0008370C File Offset: 0x0008190C
		public static void SquareAddToExt(ulong[] x, ulong[] zz)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat256.CreateExt64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.ImplSquare(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.AddExt(zz, tt, zz);
		}

		// Token: 0x06001C1B RID: 7195 RVA: 0x00083730 File Offset: 0x00081930
		public static void SquareN(ulong[] x, int n, ulong[] z)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat256.CreateExt64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.ImplSquare(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Reduce(tt, z);
			while (--n > 0)
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.ImplSquare(z, tt);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.Reduce(tt, z);
			}
		}

		// Token: 0x06001C1C RID: 7196 RVA: 0x0008376A File Offset: 0x0008196A
		public static uint Trace(ulong[] x)
		{
			return (uint)(x[0] ^ x[2] >> 31) & 1U;
		}

		// Token: 0x06001C1D RID: 7197 RVA: 0x0008377C File Offset: 0x0008197C
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
			zz[0] = (z0 ^ z << 59);
			zz[1] = (z >> 5 ^ z2 << 54);
			zz[2] = (z2 >> 10 ^ z3 << 49);
			zz[3] = (z3 >> 15 ^ z4 << 44);
			zz[4] = (z4 >> 20 ^ z5 << 39);
			zz[5] = (z5 >> 25 ^ z6 << 34);
			zz[6] = (z6 >> 30 ^ z7 << 29);
			zz[7] = z7 >> 35;
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x0008380C File Offset: 0x00081A0C
		protected static void ImplExpand(ulong[] x, ulong[] z)
		{
			ulong x2 = x[0];
			ulong x3 = x[1];
			ulong x4 = x[2];
			ulong x5 = x[3];
			z[0] = (x2 & 576460752303423487UL);
			z[1] = ((x2 >> 59 ^ x3 << 5) & 576460752303423487UL);
			z[2] = ((x3 >> 54 ^ x4 << 10) & 576460752303423487UL);
			z[3] = (x4 >> 49 ^ x5 << 15);
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x00083870 File Offset: 0x00081A70
		protected static void ImplMultiply(ulong[] x, ulong[] y, ulong[] zz)
		{
			ulong[] f = new ulong[4];
			ulong[] g = new ulong[4];
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.ImplExpand(x, f);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.ImplExpand(y, g);
			ulong[] u = new ulong[8];
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.ImplMulwAcc(u, f[0], g[0], zz, 0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.ImplMulwAcc(u, f[1], g[1], zz, 1);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.ImplMulwAcc(u, f[2], g[2], zz, 2);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.ImplMulwAcc(u, f[3], g[3], zz, 3);
			for (int i = 5; i > 0; i--)
			{
				zz[i] ^= zz[i - 1];
			}
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.ImplMulwAcc(u, f[0] ^ f[1], g[0] ^ g[1], zz, 1);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.ImplMulwAcc(u, f[2] ^ f[3], g[2] ^ g[3], zz, 3);
			for (int j = 7; j > 1; j--)
			{
				zz[j] ^= zz[j - 2];
			}
			ulong c0 = f[0] ^ f[2];
			ulong c = f[1] ^ f[3];
			ulong d0 = g[0] ^ g[2];
			ulong d = g[1] ^ g[3];
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.ImplMulwAcc(u, c0 ^ c, d0 ^ d, zz, 3);
			ulong[] t = new ulong[3];
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.ImplMulwAcc(u, c0, d0, t, 0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.ImplMulwAcc(u, c, d, t, 1);
			ulong t2 = t[0];
			ulong t3 = t[1];
			ulong t4 = t[2];
			zz[2] ^= t2;
			zz[3] ^= (t2 ^ t3);
			zz[4] ^= (t4 ^ t3);
			zz[5] ^= t4;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233Field.ImplCompactExt(zz);
		}

		// Token: 0x06001C20 RID: 7200 RVA: 0x000839EC File Offset: 0x00081BEC
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

		// Token: 0x06001C21 RID: 7201 RVA: 0x00083AAC File Offset: 0x00081CAC
		protected static void ImplSquare(ulong[] x, ulong[] zz)
		{
			global::Org.BouncyCastle.Math.Raw.Interleave.Expand64To128(x, 0, 4, zz, 0);
		}

		// Token: 0x04000AB9 RID: 2745
		private const ulong M41 = 2199023255551UL;

		// Token: 0x04000ABA RID: 2746
		private const ulong M59 = 576460752303423487UL;
	}
}
