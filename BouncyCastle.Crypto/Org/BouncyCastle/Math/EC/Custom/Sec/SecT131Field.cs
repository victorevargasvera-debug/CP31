using System;
using Org.BouncyCastle.Math.Raw;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x02000277 RID: 631
	internal class SecT131Field
	{
		// Token: 0x06001AAB RID: 6827 RVA: 0x0007D983 File Offset: 0x0007BB83
		public static void Add(ulong[] x, ulong[] y, ulong[] z)
		{
			z[0] = (x[0] ^ y[0]);
			z[1] = (x[1] ^ y[1]);
			z[2] = (x[2] ^ y[2]);
		}

		// Token: 0x06001AAC RID: 6828 RVA: 0x0007D9A3 File Offset: 0x0007BBA3
		public static void AddExt(ulong[] xx, ulong[] yy, ulong[] zz)
		{
			zz[0] = (xx[0] ^ yy[0]);
			zz[1] = (xx[1] ^ yy[1]);
			zz[2] = (xx[2] ^ yy[2]);
			zz[3] = (xx[3] ^ yy[3]);
			zz[4] = (xx[4] ^ yy[4]);
		}

		// Token: 0x06001AAD RID: 6829 RVA: 0x0007D9D7 File Offset: 0x0007BBD7
		public static void AddOne(ulong[] x, ulong[] z)
		{
			z[0] = (x[0] ^ 1UL);
			z[1] = x[1];
			z[2] = x[2];
		}

		// Token: 0x06001AAE RID: 6830 RVA: 0x0007D9EE File Offset: 0x0007BBEE
		private static void AddTo(ulong[] x, ulong[] z)
		{
			z[0] ^= x[0];
			z[1] ^= x[1];
			z[2] ^= x[2];
		}

		// Token: 0x06001AAF RID: 6831 RVA: 0x0007DA1A File Offset: 0x0007BC1A
		public static ulong[] FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return global::Org.BouncyCastle.Math.Raw.Nat.FromBigInteger64(131, x);
		}

		// Token: 0x06001AB0 RID: 6832 RVA: 0x0007DA28 File Offset: 0x0007BC28
		public static void HalfTrace(ulong[] x, ulong[] z)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat.Create64(5);
			global::Org.BouncyCastle.Math.Raw.Nat192.Copy64(x, z);
			for (int i = 1; i < 131; i += 2)
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.ImplSquare(z, tt);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.Reduce(tt, z);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.ImplSquare(z, tt);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.Reduce(tt, z);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.AddTo(x, z);
			}
		}

		// Token: 0x06001AB1 RID: 6833 RVA: 0x0007DA78 File Offset: 0x0007BC78
		public static void Invert(ulong[] x, ulong[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat192.IsZero64(x))
			{
				throw new global::System.InvalidOperationException();
			}
			ulong[] t0 = global::Org.BouncyCastle.Math.Raw.Nat192.Create64();
			ulong[] t = global::Org.BouncyCastle.Math.Raw.Nat192.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.Square(x, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.Multiply(t0, x, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.SquareN(t0, 2, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.Multiply(t, t0, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.SquareN(t, 4, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.Multiply(t0, t, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.SquareN(t0, 8, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.Multiply(t, t0, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.SquareN(t, 16, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.Multiply(t0, t, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.SquareN(t0, 32, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.Multiply(t, t0, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.Square(t, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.Multiply(t, x, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.SquareN(t, 65, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.Multiply(t0, t, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.Square(t0, z);
		}

		// Token: 0x06001AB2 RID: 6834 RVA: 0x0007DB28 File Offset: 0x0007BD28
		public static void Multiply(ulong[] x, ulong[] y, ulong[] z)
		{
			ulong[] tt = new ulong[8];
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.ImplMultiply(x, y, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.Reduce(tt, z);
		}

		// Token: 0x06001AB3 RID: 6835 RVA: 0x0007DB4C File Offset: 0x0007BD4C
		public static void MultiplyAddToExt(ulong[] x, ulong[] y, ulong[] zz)
		{
			ulong[] tt = new ulong[8];
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.ImplMultiply(x, y, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.AddExt(zz, tt, zz);
		}

		// Token: 0x06001AB4 RID: 6836 RVA: 0x0007DB70 File Offset: 0x0007BD70
		public static void Reduce(ulong[] xx, ulong[] z)
		{
			ulong x0 = xx[0];
			ulong x = xx[1];
			ulong x2 = xx[2];
			ulong x3 = xx[3];
			ulong x4 = xx[4];
			x ^= (x4 << 61 ^ x4 << 63);
			x2 ^= (x4 >> 3 ^ x4 >> 1 ^ x4 ^ x4 << 5);
			x3 ^= x4 >> 59;
			x0 ^= (x3 << 61 ^ x3 << 63);
			x ^= (x3 >> 3 ^ x3 >> 1 ^ x3 ^ x3 << 5);
			x2 ^= x3 >> 59;
			ulong t = x2 >> 3;
			z[0] = (x0 ^ t ^ t << 2 ^ t << 3 ^ t << 8);
			z[1] = (x ^ t >> 56);
			z[2] = (x2 & 7UL);
		}

		// Token: 0x06001AB5 RID: 6837 RVA: 0x0007DC0C File Offset: 0x0007BE0C
		public static void Reduce61(ulong[] z, int zOff)
		{
			ulong z2 = z[zOff + 2];
			ulong t = z2 >> 3;
			z[zOff] ^= (t ^ t << 2 ^ t << 3 ^ t << 8);
			z[zOff + 1] ^= t >> 56;
			z[zOff + 2] = (z2 & 7UL);
		}

		// Token: 0x06001AB6 RID: 6838 RVA: 0x0007DC58 File Offset: 0x0007BE58
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
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.Multiply(array, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.ROOT_Z, z);
			z[0] ^= e0;
			z[1] ^= e;
		}

		// Token: 0x06001AB7 RID: 6839 RVA: 0x0007DCD4 File Offset: 0x0007BED4
		public static void Square(ulong[] x, ulong[] z)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat.Create64(5);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.ImplSquare(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.Reduce(tt, z);
		}

		// Token: 0x06001AB8 RID: 6840 RVA: 0x0007DCF8 File Offset: 0x0007BEF8
		public static void SquareAddToExt(ulong[] x, ulong[] zz)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat.Create64(5);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.ImplSquare(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.AddExt(zz, tt, zz);
		}

		// Token: 0x06001AB9 RID: 6841 RVA: 0x0007DD1C File Offset: 0x0007BF1C
		public static void SquareN(ulong[] x, int n, ulong[] z)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat.Create64(5);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.ImplSquare(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.Reduce(tt, z);
			while (--n > 0)
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.ImplSquare(z, tt);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.Reduce(tt, z);
			}
		}

		// Token: 0x06001ABA RID: 6842 RVA: 0x0007DD57 File Offset: 0x0007BF57
		public static uint Trace(ulong[] x)
		{
			return (uint)(x[0] ^ x[1] >> 59 ^ x[2] >> 1) & 1U;
		}

		// Token: 0x06001ABB RID: 6843 RVA: 0x0007DD6C File Offset: 0x0007BF6C
		protected static void ImplCompactExt(ulong[] zz)
		{
			ulong z0 = zz[0];
			ulong z = zz[1];
			ulong z2 = zz[2];
			ulong z3 = zz[3];
			ulong z4 = zz[4];
			ulong z5 = zz[5];
			zz[0] = (z0 ^ z << 44);
			zz[1] = (z >> 20 ^ z2 << 24);
			zz[2] = (z2 >> 40 ^ z3 << 4 ^ z4 << 48);
			zz[3] = (z3 >> 60 ^ z5 << 28 ^ z4 >> 16);
			zz[4] = z5 >> 36;
			zz[5] = 0UL;
		}

		// Token: 0x06001ABC RID: 6844 RVA: 0x0007DDDC File Offset: 0x0007BFDC
		protected static void ImplMultiply(ulong[] x, ulong[] y, ulong[] zz)
		{
			ulong f0 = x[0];
			ulong f = x[1];
			ulong f2 = x[2];
			f2 = ((f >> 24 ^ f2 << 40) & 17592186044415UL);
			f = ((f0 >> 44 ^ f << 20) & 17592186044415UL);
			f0 &= 17592186044415UL;
			ulong g0 = y[0];
			ulong g = y[1];
			ulong g2 = y[2];
			g2 = ((g >> 24 ^ g2 << 40) & 17592186044415UL);
			g = ((g0 >> 44 ^ g << 20) & 17592186044415UL);
			g0 &= 17592186044415UL;
			ulong[] H = new ulong[10];
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.ImplMulw(zz, f0, g0, H, 0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.ImplMulw(zz, f2, g2, H, 2);
			ulong t0 = f0 ^ f ^ f2;
			ulong t = g0 ^ g ^ g2;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.ImplMulw(zz, t0, t, H, 4);
			ulong t2 = f << 1 ^ f2 << 2;
			ulong t3 = g << 1 ^ g2 << 2;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.ImplMulw(zz, f0 ^ t2, g0 ^ t3, H, 6);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.ImplMulw(zz, t0 ^ t2, t ^ t3, H, 8);
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
			w ^= w0 >> 44;
			w0 &= 17592186044415UL;
			w2 ^= w >> 44;
			w &= 17592186044415UL;
			w0 = (w0 >> 1 ^ (w & 1UL) << 43);
			w = (w >> 1 ^ (w2 & 1UL) << 43);
			w2 >>= 1;
			w0 ^= w0 << 1;
			w0 ^= w0 << 2;
			w0 ^= w0 << 4;
			w0 ^= w0 << 8;
			w0 ^= w0 << 16;
			w0 ^= w0 << 32;
			w0 &= 17592186044415UL;
			w ^= w0 >> 43;
			w ^= w << 1;
			w ^= w << 2;
			w ^= w << 4;
			w ^= w << 8;
			w ^= w << 16;
			w ^= w << 32;
			w &= 17592186044415UL;
			w2 ^= w >> 43;
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
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131Field.ImplCompactExt(zz);
		}

		// Token: 0x06001ABD RID: 6845 RVA: 0x0007E0D4 File Offset: 0x0007C2D4
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
			ulong j = u[(int)(i & 7U)] ^ u[(int)(i >> 3 & 7U)] << 3 ^ u[(int)(i >> 6 & 7U)] << 6 ^ u[(int)(i >> 9 & 7U)] << 9 ^ u[(int)(i >> 12 & 7U)] << 12;
			int k = 30;
			do
			{
				i = (uint)(x >> k);
				ulong g = u[(int)(i & 7U)] ^ u[(int)(i >> 3 & 7U)] << 3 ^ u[(int)(i >> 6 & 7U)] << 6 ^ u[(int)(i >> 9 & 7U)] << 9 ^ u[(int)(i >> 12 & 7U)] << 12;
				j ^= g << k;
				h ^= g >> -k;
			}
			while ((k -= 15) > 0);
			z[zOff] = (j & 17592186044415UL);
			z[zOff + 1] = (j >> 44 ^ h << 20);
		}

		// Token: 0x06001ABE RID: 6846 RVA: 0x0007E1CA File Offset: 0x0007C3CA
		protected static void ImplSquare(ulong[] x, ulong[] zz)
		{
			global::Org.BouncyCastle.Math.Raw.Interleave.Expand64To128(x, 0, 2, zz, 0);
			zz[4] = (ulong)global::Org.BouncyCastle.Math.Raw.Interleave.Expand8to16((uint)x[2]);
		}

		// Token: 0x04000A92 RID: 2706
		private const ulong M03 = 7UL;

		// Token: 0x04000A93 RID: 2707
		private const ulong M44 = 17592186044415UL;

		// Token: 0x04000A94 RID: 2708
		private static readonly ulong[] ROOT_Z = new ulong[]
		{
			2791191049453778211UL,
			2791191049453778402UL,
			6UL
		};
	}
}
