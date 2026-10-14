using System;
using Org.BouncyCastle.Math.Raw;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x02000295 RID: 661
	internal class SecT283Field
	{
		// Token: 0x06001CCF RID: 7375 RVA: 0x00086123 File Offset: 0x00084323
		public static void Add(ulong[] x, ulong[] y, ulong[] z)
		{
			z[0] = (x[0] ^ y[0]);
			z[1] = (x[1] ^ y[1]);
			z[2] = (x[2] ^ y[2]);
			z[3] = (x[3] ^ y[3]);
			z[4] = (x[4] ^ y[4]);
		}

		// Token: 0x06001CD0 RID: 7376 RVA: 0x00086158 File Offset: 0x00084358
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
			zz[8] = (xx[8] ^ yy[8]);
		}

		// Token: 0x06001CD1 RID: 7377 RVA: 0x000861BF File Offset: 0x000843BF
		public static void AddOne(ulong[] x, ulong[] z)
		{
			z[0] = (x[0] ^ 1UL);
			z[1] = x[1];
			z[2] = x[2];
			z[3] = x[3];
			z[4] = x[4];
		}

		// Token: 0x06001CD2 RID: 7378 RVA: 0x000861E4 File Offset: 0x000843E4
		private static void AddTo(ulong[] x, ulong[] z)
		{
			z[0] ^= x[0];
			z[1] ^= x[1];
			z[2] ^= x[2];
			z[3] ^= x[3];
			z[4] ^= x[4];
		}

		// Token: 0x06001CD3 RID: 7379 RVA: 0x00086237 File Offset: 0x00084437
		public static ulong[] FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return global::Org.BouncyCastle.Math.Raw.Nat.FromBigInteger64(283, x);
		}

		// Token: 0x06001CD4 RID: 7380 RVA: 0x00086244 File Offset: 0x00084444
		public static void HalfTrace(ulong[] x, ulong[] z)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat.Create64(9);
			global::Org.BouncyCastle.Math.Raw.Nat320.Copy64(x, z);
			for (int i = 1; i < 283; i += 2)
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.ImplSquare(z, tt);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Reduce(tt, z);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.ImplSquare(z, tt);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Reduce(tt, z);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.AddTo(x, z);
			}
		}

		// Token: 0x06001CD5 RID: 7381 RVA: 0x00086294 File Offset: 0x00084494
		public static void Invert(ulong[] x, ulong[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat320.IsZero64(x))
			{
				throw new global::System.InvalidOperationException();
			}
			ulong[] t0 = global::Org.BouncyCastle.Math.Raw.Nat320.Create64();
			ulong[] t = global::Org.BouncyCastle.Math.Raw.Nat320.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Square(x, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Multiply(t0, x, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.SquareN(t0, 2, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Multiply(t, t0, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.SquareN(t, 4, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Multiply(t0, t, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.SquareN(t0, 8, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Multiply(t, t0, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Square(t, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Multiply(t, x, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.SquareN(t, 17, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Multiply(t0, t, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Square(t0, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Multiply(t0, x, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.SquareN(t0, 35, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Multiply(t, t0, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.SquareN(t, 70, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Multiply(t0, t, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Square(t0, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Multiply(t0, x, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.SquareN(t0, 141, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Multiply(t, t0, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Square(t, z);
		}

		// Token: 0x06001CD6 RID: 7382 RVA: 0x00086378 File Offset: 0x00084578
		public static void Multiply(ulong[] x, ulong[] y, ulong[] z)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat320.CreateExt64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.ImplMultiply(x, y, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Reduce(tt, z);
		}

		// Token: 0x06001CD7 RID: 7383 RVA: 0x0008639C File Offset: 0x0008459C
		public static void MultiplyAddToExt(ulong[] x, ulong[] y, ulong[] zz)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat320.CreateExt64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.ImplMultiply(x, y, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.AddExt(zz, tt, zz);
		}

		// Token: 0x06001CD8 RID: 7384 RVA: 0x000863C0 File Offset: 0x000845C0
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
			ulong x8 = xx[8];
			x3 ^= (x8 << 37 ^ x8 << 42 ^ x8 << 44 ^ x8 << 49);
			x4 ^= (x8 >> 27 ^ x8 >> 22 ^ x8 >> 20 ^ x8 >> 15);
			x2 ^= (x7 << 37 ^ x7 << 42 ^ x7 << 44 ^ x7 << 49);
			x3 ^= (x7 >> 27 ^ x7 >> 22 ^ x7 >> 20 ^ x7 >> 15);
			x ^= (x6 << 37 ^ x6 << 42 ^ x6 << 44 ^ x6 << 49);
			x2 ^= (x6 >> 27 ^ x6 >> 22 ^ x6 >> 20 ^ x6 >> 15);
			x0 ^= (x5 << 37 ^ x5 << 42 ^ x5 << 44 ^ x5 << 49);
			x ^= (x5 >> 27 ^ x5 >> 22 ^ x5 >> 20 ^ x5 >> 15);
			ulong t = x4 >> 27;
			z[0] = (x0 ^ t ^ t << 5 ^ t << 7 ^ t << 12);
			z[1] = x;
			z[2] = x2;
			z[3] = x3;
			z[4] = (x4 & 134217727UL);
		}

		// Token: 0x06001CD9 RID: 7385 RVA: 0x00086500 File Offset: 0x00084700
		public static void Reduce37(ulong[] z, int zOff)
		{
			ulong z2 = z[zOff + 4];
			ulong t = z2 >> 27;
			z[zOff] ^= (t ^ t << 5 ^ t << 7 ^ t << 12);
			z[zOff + 4] = (z2 & 134217727UL);
		}

		// Token: 0x06001CDA RID: 7386 RVA: 0x00086540 File Offset: 0x00084740
		public static void Sqrt(ulong[] x, ulong[] z)
		{
			ulong[] array = global::Org.BouncyCastle.Math.Raw.Nat320.Create64();
			ulong u0 = global::Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x[0]);
			ulong u = global::Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x[1]);
			ulong e0 = (u0 & (ulong)-1) | u << 32;
			array[0] = (u0 >> 32 | (u & 18446744069414584320UL));
			u0 = global::Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x[2]);
			u = global::Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x[3]);
			ulong e = (u0 & (ulong)-1) | u << 32;
			array[1] = (u0 >> 32 | (u & 18446744069414584320UL));
			u0 = global::Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x[4]);
			ulong e2 = u0 & (ulong)-1;
			array[2] = u0 >> 32;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Multiply(array, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.ROOT_Z, z);
			z[0] ^= e0;
			z[1] ^= e;
			z[2] ^= e2;
		}

		// Token: 0x06001CDB RID: 7387 RVA: 0x000865F8 File Offset: 0x000847F8
		public static void Square(ulong[] x, ulong[] z)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat.Create64(9);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.ImplSquare(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Reduce(tt, z);
		}

		// Token: 0x06001CDC RID: 7388 RVA: 0x0008661C File Offset: 0x0008481C
		public static void SquareAddToExt(ulong[] x, ulong[] zz)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat.Create64(9);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.ImplSquare(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.AddExt(zz, tt, zz);
		}

		// Token: 0x06001CDD RID: 7389 RVA: 0x00086640 File Offset: 0x00084840
		public static void SquareN(ulong[] x, int n, ulong[] z)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat.Create64(9);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.ImplSquare(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Reduce(tt, z);
			while (--n > 0)
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.ImplSquare(z, tt);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.Reduce(tt, z);
			}
		}

		// Token: 0x06001CDE RID: 7390 RVA: 0x0008667C File Offset: 0x0008487C
		public static uint Trace(ulong[] x)
		{
			return (uint)(x[0] ^ x[4] >> 15) & 1U;
		}

		// Token: 0x06001CDF RID: 7391 RVA: 0x0008668C File Offset: 0x0008488C
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
			zz[0] = (z0 ^ z << 57);
			zz[1] = (z >> 7 ^ z2 << 50);
			zz[2] = (z2 >> 14 ^ z3 << 43);
			zz[3] = (z3 >> 21 ^ z4 << 36);
			zz[4] = (z4 >> 28 ^ z5 << 29);
			zz[5] = (z5 >> 35 ^ z6 << 22);
			zz[6] = (z6 >> 42 ^ z7 << 15);
			zz[7] = (z7 >> 49 ^ z8 << 8);
			zz[8] = (z8 >> 56 ^ z9 << 1);
			zz[9] = z9 >> 63;
		}

		// Token: 0x06001CE0 RID: 7392 RVA: 0x00086744 File Offset: 0x00084944
		protected static void ImplExpand(ulong[] x, ulong[] z)
		{
			ulong x2 = x[0];
			ulong x3 = x[1];
			ulong x4 = x[2];
			ulong x5 = x[3];
			ulong x6 = x[4];
			z[0] = (x2 & 144115188075855871UL);
			z[1] = ((x2 >> 57 ^ x3 << 7) & 144115188075855871UL);
			z[2] = ((x3 >> 50 ^ x4 << 14) & 144115188075855871UL);
			z[3] = ((x4 >> 43 ^ x5 << 21) & 144115188075855871UL);
			z[4] = (x5 >> 36 ^ x6 << 28);
		}

		// Token: 0x06001CE1 RID: 7393 RVA: 0x000867C4 File Offset: 0x000849C4
		protected static void ImplMultiply(ulong[] x, ulong[] y, ulong[] zz)
		{
			ulong[] a = new ulong[5];
			ulong[] b = new ulong[5];
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.ImplExpand(x, a);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.ImplExpand(y, b);
			ulong[] p = new ulong[26];
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.ImplMulw(zz, a[0], b[0], p, 0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.ImplMulw(zz, a[1], b[1], p, 2);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.ImplMulw(zz, a[2], b[2], p, 4);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.ImplMulw(zz, a[3], b[3], p, 6);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.ImplMulw(zz, a[4], b[4], p, 8);
			ulong u0 = a[0] ^ a[1];
			ulong v0 = b[0] ^ b[1];
			ulong u = a[0] ^ a[2];
			ulong v = b[0] ^ b[2];
			ulong u2 = a[2] ^ a[4];
			ulong v2 = b[2] ^ b[4];
			ulong u3 = a[3] ^ a[4];
			ulong v3 = b[3] ^ b[4];
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.ImplMulw(zz, u ^ a[3], v ^ b[3], p, 18);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.ImplMulw(zz, u2 ^ a[1], v2 ^ b[1], p, 20);
			ulong A4 = u0 ^ u3;
			ulong B4 = v0 ^ v3;
			ulong A5 = A4 ^ a[2];
			ulong B5 = B4 ^ b[2];
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.ImplMulw(zz, A4, B4, p, 22);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.ImplMulw(zz, A5, B5, p, 24);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.ImplMulw(zz, u0, v0, p, 10);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.ImplMulw(zz, u, v, p, 12);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.ImplMulw(zz, u2, v2, p, 14);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.ImplMulw(zz, u3, v3, p, 16);
			zz[0] = p[0];
			zz[9] = p[9];
			ulong num = p[0] ^ p[1];
			ulong num2 = num ^ p[2];
			ulong t3 = num2 ^ p[10];
			zz[1] = t3;
			ulong t4 = p[3] ^ p[4];
			ulong t5 = p[11] ^ p[12];
			ulong t6 = t4 ^ t5;
			ulong t7 = num2 ^ t6;
			zz[2] = t7;
			ulong num3 = num ^ t4;
			ulong t8 = p[5] ^ p[6];
			ulong num4 = num3 ^ t8 ^ p[8];
			ulong t9 = p[13] ^ p[14];
			ulong num5 = num4 ^ t9;
			ulong t10 = p[18] ^ p[22] ^ p[24];
			ulong t11 = num5 ^ t10;
			zz[3] = t11;
			ulong num6 = p[7] ^ p[8] ^ p[9];
			ulong t12 = num6 ^ p[17];
			zz[8] = t12;
			ulong num7 = num6 ^ t8;
			ulong t13 = p[15] ^ p[16];
			ulong t14 = num7 ^ t13;
			zz[7] = t14;
			ulong t15 = t14 ^ t3;
			ulong num8 = p[19] ^ p[20];
			ulong t16 = p[25] ^ p[24];
			ulong t17 = p[18] ^ p[23];
			ulong num9 = num8 ^ t16;
			ulong t18 = num9 ^ t17 ^ t15;
			zz[4] = t18;
			ulong t19 = t7 ^ t12;
			ulong num10 = num9 ^ t19;
			ulong t20 = p[21] ^ p[22];
			ulong t21 = num10 ^ t20;
			zz[5] = t21;
			ulong t22 = num4 ^ p[0] ^ p[9] ^ t9 ^ p[21] ^ p[23] ^ p[25];
			zz[6] = t22;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283Field.ImplCompactExt(zz);
		}

		// Token: 0x06001CE2 RID: 7394 RVA: 0x00086A50 File Offset: 0x00084C50
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
			ulong j = u[(int)(i & 7U)];
			int k = 48;
			do
			{
				i = (uint)(x >> k);
				ulong g = u[(int)(i & 7U)] ^ u[(int)(i >> 3 & 7U)] << 3 ^ u[(int)(i >> 6 & 7U)] << 6;
				j ^= g << k;
				h ^= g >> -k;
			}
			while ((k -= 9) > 0);
			h ^= (x & 72198606942111744UL & y << 7 >> 63) >> 8;
			z[zOff] = (j & 144115188075855871UL);
			z[zOff + 1] = (j >> 57 ^ h << 7);
		}

		// Token: 0x06001CE3 RID: 7395 RVA: 0x00086B18 File Offset: 0x00084D18
		protected static void ImplSquare(ulong[] x, ulong[] zz)
		{
			global::Org.BouncyCastle.Math.Raw.Interleave.Expand64To128(x, 0, 4, zz, 0);
			zz[8] = global::Org.BouncyCastle.Math.Raw.Interleave.Expand32to64((uint)x[4]);
		}

		// Token: 0x04000ACB RID: 2763
		private const ulong M27 = 134217727UL;

		// Token: 0x04000ACC RID: 2764
		private const ulong M57 = 144115188075855871UL;

		// Token: 0x04000ACD RID: 2765
		private static readonly ulong[] ROOT_Z = new ulong[]
		{
			878416384462358536UL,
			3513665537849438403UL,
			9369774767598502668UL,
			585610922974906400UL,
			34087042UL
		};
	}
}
