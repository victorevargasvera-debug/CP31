using System;
using Org.BouncyCastle.Math.Raw;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x02000271 RID: 625
	internal class SecT113Field
	{
		// Token: 0x06001A40 RID: 6720 RVA: 0x0007C1A1 File Offset: 0x0007A3A1
		public static void Add(ulong[] x, ulong[] y, ulong[] z)
		{
			z[0] = (x[0] ^ y[0]);
			z[1] = (x[1] ^ y[1]);
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x0007C1B7 File Offset: 0x0007A3B7
		public static void AddExt(ulong[] xx, ulong[] yy, ulong[] zz)
		{
			zz[0] = (xx[0] ^ yy[0]);
			zz[1] = (xx[1] ^ yy[1]);
			zz[2] = (xx[2] ^ yy[2]);
			zz[3] = (xx[3] ^ yy[3]);
		}

		// Token: 0x06001A42 RID: 6722 RVA: 0x0007C1E1 File Offset: 0x0007A3E1
		public static void AddOne(ulong[] x, ulong[] z)
		{
			z[0] = (x[0] ^ 1UL);
			z[1] = x[1];
		}

		// Token: 0x06001A43 RID: 6723 RVA: 0x0007C1F2 File Offset: 0x0007A3F2
		private static void AddTo(ulong[] x, ulong[] z)
		{
			z[0] ^= x[0];
			z[1] ^= x[1];
		}

		// Token: 0x06001A44 RID: 6724 RVA: 0x0007C210 File Offset: 0x0007A410
		public static ulong[] FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return global::Org.BouncyCastle.Math.Raw.Nat.FromBigInteger64(113, x);
		}

		// Token: 0x06001A45 RID: 6725 RVA: 0x0007C21C File Offset: 0x0007A41C
		public static void HalfTrace(ulong[] x, ulong[] z)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat128.CreateExt64();
			global::Org.BouncyCastle.Math.Raw.Nat128.Copy64(x, z);
			for (int i = 1; i < 113; i += 2)
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.ImplSquare(z, tt);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.Reduce(tt, z);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.ImplSquare(z, tt);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.Reduce(tt, z);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.AddTo(x, z);
			}
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x0007C268 File Offset: 0x0007A468
		public static void Invert(ulong[] x, ulong[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat128.IsZero64(x))
			{
				throw new global::System.InvalidOperationException();
			}
			ulong[] t0 = global::Org.BouncyCastle.Math.Raw.Nat128.Create64();
			ulong[] t = global::Org.BouncyCastle.Math.Raw.Nat128.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.Square(x, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.Multiply(t0, x, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.Square(t0, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.Multiply(t0, x, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.SquareN(t0, 3, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.Multiply(t, t0, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.Square(t, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.Multiply(t, x, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.SquareN(t, 7, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.Multiply(t0, t, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.SquareN(t0, 14, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.Multiply(t, t0, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.SquareN(t, 28, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.Multiply(t0, t, t0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.SquareN(t0, 56, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.Multiply(t, t0, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.Square(t, z);
		}

		// Token: 0x06001A47 RID: 6727 RVA: 0x0007C318 File Offset: 0x0007A518
		public static void Multiply(ulong[] x, ulong[] y, ulong[] z)
		{
			ulong[] tt = new ulong[8];
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.ImplMultiply(x, y, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.Reduce(tt, z);
		}

		// Token: 0x06001A48 RID: 6728 RVA: 0x0007C33C File Offset: 0x0007A53C
		public static void MultiplyAddToExt(ulong[] x, ulong[] y, ulong[] zz)
		{
			ulong[] tt = new ulong[8];
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.ImplMultiply(x, y, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.AddExt(zz, tt, zz);
		}

		// Token: 0x06001A49 RID: 6729 RVA: 0x0007C360 File Offset: 0x0007A560
		public static void Reduce(ulong[] xx, ulong[] z)
		{
			ulong x0 = xx[0];
			ulong x = xx[1];
			ulong x2 = xx[2];
			ulong x3 = xx[3];
			x ^= (x3 << 15 ^ x3 << 24);
			x2 ^= (x3 >> 49 ^ x3 >> 40);
			x0 ^= (x2 << 15 ^ x2 << 24);
			x ^= (x2 >> 49 ^ x2 >> 40);
			ulong t = x >> 49;
			z[0] = (x0 ^ t ^ t << 9);
			z[1] = (x & 562949953421311UL);
		}

		// Token: 0x06001A4A RID: 6730 RVA: 0x0007C3D0 File Offset: 0x0007A5D0
		public static void Reduce15(ulong[] z, int zOff)
		{
			ulong z2 = z[zOff + 1];
			ulong t = z2 >> 49;
			z[zOff] ^= (t ^ t << 9);
			z[zOff + 1] = (z2 & 562949953421311UL);
		}

		// Token: 0x06001A4B RID: 6731 RVA: 0x0007C40C File Offset: 0x0007A60C
		public static void Sqrt(ulong[] x, ulong[] z)
		{
			ulong num = global::Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x[0]);
			ulong u = global::Org.BouncyCastle.Math.Raw.Interleave.Unshuffle(x[1]);
			ulong e0 = (num & (ulong)-1) | u << 32;
			ulong c0 = num >> 32 | (u & 18446744069414584320UL);
			z[0] = (e0 ^ c0 << 57 ^ c0 << 5);
			z[1] = (c0 >> 7 ^ c0 >> 59);
		}

		// Token: 0x06001A4C RID: 6732 RVA: 0x0007C45C File Offset: 0x0007A65C
		public static void Square(ulong[] x, ulong[] z)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat128.CreateExt64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.ImplSquare(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.Reduce(tt, z);
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x0007C480 File Offset: 0x0007A680
		public static void SquareAddToExt(ulong[] x, ulong[] zz)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat128.CreateExt64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.ImplSquare(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.AddExt(zz, tt, zz);
		}

		// Token: 0x06001A4E RID: 6734 RVA: 0x0007C4A4 File Offset: 0x0007A6A4
		public static void SquareN(ulong[] x, int n, ulong[] z)
		{
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat128.CreateExt64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.ImplSquare(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.Reduce(tt, z);
			while (--n > 0)
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.ImplSquare(z, tt);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.Reduce(tt, z);
			}
		}

		// Token: 0x06001A4F RID: 6735 RVA: 0x0007C4DE File Offset: 0x0007A6DE
		public static uint Trace(ulong[] x)
		{
			return (uint)x[0] & 1U;
		}

		// Token: 0x06001A50 RID: 6736 RVA: 0x0007C4E8 File Offset: 0x0007A6E8
		protected static void ImplMultiply(ulong[] x, ulong[] y, ulong[] zz)
		{
			ulong f0 = x[0];
			ulong f = x[1];
			f = ((f0 >> 57 ^ f << 7) & 144115188075855871UL);
			f0 &= 144115188075855871UL;
			ulong g0 = y[0];
			ulong g = y[1];
			g = ((g0 >> 57 ^ g << 7) & 144115188075855871UL);
			g0 &= 144115188075855871UL;
			ulong[] H = new ulong[6];
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.ImplMulw(zz, f0, g0, H, 0);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.ImplMulw(zz, f, g, H, 2);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113Field.ImplMulw(zz, f0 ^ f, g0 ^ g, H, 4);
			ulong r = H[1] ^ H[2];
			ulong z0 = H[0];
			ulong z = H[3];
			ulong z2 = H[4] ^ z0 ^ r;
			ulong z3 = H[5] ^ z ^ r;
			zz[0] = (z0 ^ z2 << 57);
			zz[1] = (z2 >> 7 ^ z3 << 50);
			zz[2] = (z3 >> 14 ^ z << 43);
			zz[3] = z >> 21;
		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x0007C5D0 File Offset: 0x0007A7D0
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

		// Token: 0x06001A52 RID: 6738 RVA: 0x0007C698 File Offset: 0x0007A898
		protected static void ImplSquare(ulong[] x, ulong[] zz)
		{
			global::Org.BouncyCastle.Math.Raw.Interleave.Expand64To128(x, 0, 2, zz, 0);
		}

		// Token: 0x04000A87 RID: 2695
		private const ulong M49 = 562949953421311UL;

		// Token: 0x04000A88 RID: 2696
		private const ulong M57 = 144115188075855871UL;
	}
}
