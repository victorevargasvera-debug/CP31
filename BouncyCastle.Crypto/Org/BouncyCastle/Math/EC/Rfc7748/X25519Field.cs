using System;
using Org.BouncyCastle.Math.Raw;

namespace Org.BouncyCastle.Math.EC.Rfc7748
{
	// Token: 0x02000221 RID: 545
	public abstract class X25519Field
	{
		// Token: 0x0600165B RID: 5723 RVA: 0x0006BB28 File Offset: 0x00069D28
		public static void Add(int[] x, int[] y, int[] z)
		{
			for (int i = 0; i < 10; i++)
			{
				z[i] = x[i] + y[i];
			}
		}

		// Token: 0x0600165C RID: 5724 RVA: 0x0006BB4C File Offset: 0x00069D4C
		public static void AddOne(int[] z)
		{
			z[0]++;
		}

		// Token: 0x0600165D RID: 5725 RVA: 0x0006BB5A File Offset: 0x00069D5A
		public static void AddOne(int[] z, int zOff)
		{
			z[zOff]++;
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x0006BB68 File Offset: 0x00069D68
		public static void Apm(int[] x, int[] y, int[] zp, int[] zm)
		{
			for (int i = 0; i < 10; i++)
			{
				int xi = x[i];
				int yi = y[i];
				zp[i] = xi + yi;
				zm[i] = xi - yi;
			}
		}

		// Token: 0x0600165F RID: 5727 RVA: 0x0006BB98 File Offset: 0x00069D98
		public static int AreEqual(int[] x, int[] y)
		{
			int d = 0;
			for (int i = 0; i < 10; i++)
			{
				d |= (x[i] ^ y[i]);
			}
			d |= d >> 16;
			d &= 65535;
			return d - 1 >> 31;
		}

		// Token: 0x06001660 RID: 5728 RVA: 0x0006BBD3 File Offset: 0x00069DD3
		public static bool AreEqualVar(int[] x, int[] y)
		{
			return global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.AreEqual(x, y) != 0;
		}

		// Token: 0x06001661 RID: 5729 RVA: 0x0006BBE0 File Offset: 0x00069DE0
		public static void Carry(int[] z)
		{
			int z2 = z[0];
			int z3 = z[1];
			int z4 = z[2];
			int z5 = z[3];
			int z6 = z[4];
			int z7 = z[5];
			int z8 = z[6];
			int z9 = z[7];
			int z10 = z[8];
			int z11 = z[9];
			z4 += z3 >> 26;
			z3 &= 67108863;
			z6 += z5 >> 26;
			z5 &= 67108863;
			z9 += z8 >> 26;
			z8 &= 67108863;
			z11 += z10 >> 26;
			z10 &= 67108863;
			z5 += z4 >> 25;
			z4 &= 33554431;
			z7 += z6 >> 25;
			z6 &= 33554431;
			z10 += z9 >> 25;
			z9 &= 33554431;
			z2 += (z11 >> 25) * 38;
			z11 &= 33554431;
			z3 += z2 >> 26;
			z2 &= 67108863;
			z8 += z7 >> 26;
			z7 &= 67108863;
			z4 += z3 >> 26;
			z3 &= 67108863;
			z6 += z5 >> 26;
			z5 &= 67108863;
			z9 += z8 >> 26;
			z8 &= 67108863;
			z11 += z10 >> 26;
			z10 &= 67108863;
			z[0] = z2;
			z[1] = z3;
			z[2] = z4;
			z[3] = z5;
			z[4] = z6;
			z[5] = z7;
			z[6] = z8;
			z[7] = z9;
			z[8] = z10;
			z[9] = z11;
		}

		// Token: 0x06001662 RID: 5730 RVA: 0x0006BD4C File Offset: 0x00069F4C
		public static void CMov(int cond, int[] x, int xOff, int[] z, int zOff)
		{
			for (int i = 0; i < 10; i++)
			{
				int z_i = z[zOff + i];
				int diff = z_i ^ x[xOff + i];
				z_i ^= (diff & cond);
				z[zOff + i] = z_i;
			}
		}

		// Token: 0x06001663 RID: 5731 RVA: 0x0006BD84 File Offset: 0x00069F84
		public static void CNegate(int negate, int[] z)
		{
			int mask = 0 - negate;
			for (int i = 0; i < 10; i++)
			{
				z[i] = (z[i] ^ mask) - mask;
			}
		}

		// Token: 0x06001664 RID: 5732 RVA: 0x0006BDAC File Offset: 0x00069FAC
		public static void Copy(int[] x, int xOff, int[] z, int zOff)
		{
			for (int i = 0; i < 10; i++)
			{
				z[zOff + i] = x[xOff + i];
			}
		}

		// Token: 0x06001665 RID: 5733 RVA: 0x0006BDD0 File Offset: 0x00069FD0
		public static int[] Create()
		{
			return new int[10];
		}

		// Token: 0x06001666 RID: 5734 RVA: 0x0006BDD9 File Offset: 0x00069FD9
		public static int[] CreateTable(int n)
		{
			return new int[10 * n];
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x0006BDE4 File Offset: 0x00069FE4
		public static void CSwap(int swap, int[] a, int[] b)
		{
			int mask = 0 - swap;
			for (int i = 0; i < 10; i++)
			{
				int ai = a[i];
				int bi = b[i];
				int dummy = mask & (ai ^ bi);
				a[i] = (ai ^ dummy);
				b[i] = (bi ^ dummy);
			}
		}

		// Token: 0x06001668 RID: 5736 RVA: 0x0006BE1F File Offset: 0x0006A01F
		[global::System.CLSCompliant(false)]
		public static void Decode(uint[] x, int xOff, int[] z)
		{
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Decode128(x, xOff, z, 0);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Decode128(x, xOff + 4, z, 5);
			z[9] &= 16777215;
		}

		// Token: 0x06001669 RID: 5737 RVA: 0x0006BE46 File Offset: 0x0006A046
		public static void Decode(byte[] x, int xOff, int[] z)
		{
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Decode128(x, xOff, z, 0);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Decode128(x, xOff + 16, z, 5);
			z[9] &= 16777215;
		}

		// Token: 0x0600166A RID: 5738 RVA: 0x0006BE70 File Offset: 0x0006A070
		private static void Decode128(uint[] x, int xOff, int[] z, int zOff)
		{
			uint t0 = x[xOff];
			uint t = x[xOff + 1];
			uint t2 = x[xOff + 2];
			uint t3 = x[xOff + 3];
			z[zOff] = (int)(t0 & 67108863U);
			z[zOff + 1] = (int)((t << 6 | t0 >> 26) & 67108863U);
			z[zOff + 2] = (int)((t2 << 12 | t >> 20) & 33554431U);
			z[zOff + 3] = (int)((t3 << 19 | t2 >> 13) & 67108863U);
			z[zOff + 4] = (int)(t3 >> 7);
		}

		// Token: 0x0600166B RID: 5739 RVA: 0x0006BEE0 File Offset: 0x0006A0E0
		private static void Decode128(byte[] bs, int off, int[] z, int zOff)
		{
			uint t0 = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Decode32(bs, off);
			uint t = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Decode32(bs, off + 4);
			uint t2 = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Decode32(bs, off + 8);
			uint t3 = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Decode32(bs, off + 12);
			z[zOff] = (int)(t0 & 67108863U);
			z[zOff + 1] = (int)((t << 6 | t0 >> 26) & 67108863U);
			z[zOff + 2] = (int)((t2 << 12 | t >> 20) & 33554431U);
			z[zOff + 3] = (int)((t3 << 19 | t2 >> 13) & 67108863U);
			z[zOff + 4] = (int)(t3 >> 7);
		}

		// Token: 0x0600166C RID: 5740 RVA: 0x0006BF61 File Offset: 0x0006A161
		private static uint Decode32(byte[] bs, int off)
		{
			return (uint)((int)bs[off] | (int)bs[++off] << 8 | (int)bs[++off] << 16 | (int)bs[++off] << 24);
		}

		// Token: 0x0600166D RID: 5741 RVA: 0x0006BF89 File Offset: 0x0006A189
		[global::System.CLSCompliant(false)]
		public static void Encode(int[] x, uint[] z, int zOff)
		{
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Encode128(x, 0, z, zOff);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Encode128(x, 5, z, zOff + 4);
		}

		// Token: 0x0600166E RID: 5742 RVA: 0x0006BF9F File Offset: 0x0006A19F
		public static void Encode(int[] x, byte[] z, int zOff)
		{
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Encode128(x, 0, z, zOff);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Encode128(x, 5, z, zOff + 16);
		}

		// Token: 0x0600166F RID: 5743 RVA: 0x0006BFB8 File Offset: 0x0006A1B8
		private static void Encode128(int[] x, int xOff, uint[] z, int zOff)
		{
			uint x2 = (uint)x[xOff];
			uint x3 = (uint)x[xOff + 1];
			uint x4 = (uint)x[xOff + 2];
			uint x5 = (uint)x[xOff + 3];
			uint x6 = (uint)x[xOff + 4];
			z[zOff] = (x2 | x3 << 26);
			z[zOff + 1] = (x3 >> 6 | x4 << 20);
			z[zOff + 2] = (x4 >> 12 | x5 << 13);
			z[zOff + 3] = (x5 >> 19 | x6 << 7);
		}

		// Token: 0x06001670 RID: 5744 RVA: 0x0006C014 File Offset: 0x0006A214
		private static void Encode128(int[] x, int xOff, byte[] bs, int off)
		{
			uint num = (uint)x[xOff];
			uint x2 = (uint)x[xOff + 1];
			uint x3 = (uint)x[xOff + 2];
			uint x4 = (uint)x[xOff + 3];
			uint x5 = (uint)x[xOff + 4];
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Encode32(num | x2 << 26, bs, off);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Encode32(x2 >> 6 | x3 << 20, bs, off + 4);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Encode32(x3 >> 12 | x4 << 13, bs, off + 8);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Encode32(x4 >> 19 | x5 << 7, bs, off + 12);
		}

		// Token: 0x06001671 RID: 5745 RVA: 0x0006C07D File Offset: 0x0006A27D
		private static void Encode32(uint n, byte[] bs, int off)
		{
			bs[off] = (byte)n;
			bs[++off] = (byte)(n >> 8);
			bs[++off] = (byte)(n >> 16);
			bs[++off] = (byte)(n >> 24);
		}

		// Token: 0x06001672 RID: 5746 RVA: 0x0006C0AC File Offset: 0x0006A2AC
		public static void Inv(int[] x, int[] z)
		{
			int[] t = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			uint[] u = new uint[8];
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Copy(x, 0, t, 0);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Normalize(t);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Encode(t, u, 0);
			global::Org.BouncyCastle.Math.Raw.Mod.ModOddInverse(global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.P32, u, u);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Decode(u, 0, z);
		}

		// Token: 0x06001673 RID: 5747 RVA: 0x0006C0F4 File Offset: 0x0006A2F4
		public static void InvVar(int[] x, int[] z)
		{
			int[] t = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			uint[] u = new uint[8];
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Copy(x, 0, t, 0);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Normalize(t);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Encode(t, u, 0);
			global::Org.BouncyCastle.Math.Raw.Mod.ModOddInverseVar(global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.P32, u, u);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Decode(u, 0, z);
		}

		// Token: 0x06001674 RID: 5748 RVA: 0x0006C13C File Offset: 0x0006A33C
		public static int IsOne(int[] x)
		{
			int d = x[0] ^ 1;
			for (int i = 1; i < 10; i++)
			{
				d |= x[i];
			}
			d |= d >> 16;
			d &= 65535;
			return d - 1 >> 31;
		}

		// Token: 0x06001675 RID: 5749 RVA: 0x0006C177 File Offset: 0x0006A377
		public static bool IsOneVar(int[] x)
		{
			return global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.IsOne(x) != 0;
		}

		// Token: 0x06001676 RID: 5750 RVA: 0x0006C184 File Offset: 0x0006A384
		public static int IsZero(int[] x)
		{
			int d = 0;
			for (int i = 0; i < 10; i++)
			{
				d |= x[i];
			}
			d |= d >> 16;
			d &= 65535;
			return d - 1 >> 31;
		}

		// Token: 0x06001677 RID: 5751 RVA: 0x0006C1BB File Offset: 0x0006A3BB
		public static bool IsZeroVar(int[] x)
		{
			return global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.IsZero(x) != 0;
		}

		// Token: 0x06001678 RID: 5752 RVA: 0x0006C1C8 File Offset: 0x0006A3C8
		public static void Mul(int[] x, int y, int[] z)
		{
			int x2 = x[0];
			int x3 = x[1];
			int x4 = x[2];
			int x5 = x[3];
			int x6 = x[4];
			int x7 = x[5];
			int x8 = x[6];
			int x9 = x[7];
			int x10 = x[8];
			int x11 = x[9];
			long c0 = (long)x4 * (long)y;
			x4 = ((int)c0 & 33554431);
			c0 >>= 25;
			long c = (long)x6 * (long)y;
			x6 = ((int)c & 33554431);
			c >>= 25;
			long c2 = (long)x9 * (long)y;
			x9 = ((int)c2 & 33554431);
			c2 >>= 25;
			long c3 = (long)x11 * (long)y;
			x11 = ((int)c3 & 33554431);
			c3 >>= 25;
			c3 *= 38L;
			c3 += (long)x2 * (long)y;
			z[0] = ((int)c3 & 67108863);
			c3 >>= 26;
			c += (long)x7 * (long)y;
			z[5] = ((int)c & 67108863);
			c >>= 26;
			c3 += (long)x3 * (long)y;
			z[1] = ((int)c3 & 67108863);
			c3 >>= 26;
			c0 += (long)x5 * (long)y;
			z[3] = ((int)c0 & 67108863);
			c0 >>= 26;
			c += (long)x8 * (long)y;
			z[6] = ((int)c & 67108863);
			c >>= 26;
			c2 += (long)x10 * (long)y;
			z[8] = ((int)c2 & 67108863);
			c2 >>= 26;
			z[2] = x4 + (int)c3;
			z[4] = x6 + (int)c0;
			z[7] = x9 + (int)c;
			z[9] = x11 + (int)c2;
		}

		// Token: 0x06001679 RID: 5753 RVA: 0x0006C348 File Offset: 0x0006A548
		public static void Mul(int[] x, int[] y, int[] z)
		{
			int x2 = x[0];
			int y2 = y[0];
			int x3 = x[1];
			int y3 = y[1];
			int x4 = x[2];
			int y4 = y[2];
			int x5 = x[3];
			int y5 = y[3];
			int x6 = x[4];
			int y6 = y[4];
			int u0 = x[5];
			int v0 = y[5];
			int u = x[6];
			int v = y[6];
			int u2 = x[7];
			int v2 = y[7];
			int u3 = x[8];
			int v3 = y[8];
			int u4 = x[9];
			int v4 = y[9];
			long a0 = (long)x2 * (long)y2;
			long a = (long)x2 * (long)y3 + (long)x3 * (long)y2;
			long a2 = (long)x2 * (long)y4 + (long)x3 * (long)y3 + (long)x4 * (long)y2;
			long a3 = (long)x3 * (long)y4 + (long)x4 * (long)y3;
			a3 <<= 1;
			a3 += (long)x2 * (long)y5 + (long)x5 * (long)y2;
			long a4 = (long)x4 * (long)y4;
			a4 <<= 1;
			a4 += (long)x2 * (long)y6 + (long)x3 * (long)y5 + (long)x5 * (long)y3 + (long)x6 * (long)y2;
			long a5 = (long)x3 * (long)y6 + (long)x4 * (long)y5 + (long)x5 * (long)y4 + (long)x6 * (long)y3;
			a5 <<= 1;
			long a6 = (long)x4 * (long)y6 + (long)x6 * (long)y4;
			a6 <<= 1;
			a6 += (long)x5 * (long)y5;
			long a7 = (long)x5 * (long)y6 + (long)x6 * (long)y5;
			long a8 = (long)x6 * (long)y6;
			a8 <<= 1;
			long b0 = (long)u0 * (long)v0;
			long b = (long)u0 * (long)v + (long)u * (long)v0;
			long b2 = (long)u0 * (long)v2 + (long)u * (long)v + (long)u2 * (long)v0;
			long b3 = (long)u * (long)v2 + (long)u2 * (long)v;
			b3 <<= 1;
			b3 += (long)u0 * (long)v3 + (long)u3 * (long)v0;
			long b4 = (long)u2 * (long)v2;
			b4 <<= 1;
			b4 += (long)u0 * (long)v4 + (long)u * (long)v3 + (long)u3 * (long)v + (long)u4 * (long)v0;
			long b5 = (long)u * (long)v4 + (long)u2 * (long)v3 + (long)u3 * (long)v2 + (long)u4 * (long)v;
			long b6 = (long)u2 * (long)v4 + (long)u4 * (long)v2;
			b6 <<= 1;
			b6 += (long)u3 * (long)v3;
			long b7 = (long)u3 * (long)v4 + (long)u4 * (long)v3;
			long b8 = (long)u4 * (long)v4;
			a0 -= b5 * 76L;
			a -= b6 * 38L;
			a2 -= b7 * 38L;
			a3 -= b8 * 76L;
			a5 -= b0;
			a6 -= b;
			a7 -= b2;
			a8 -= b3;
			x2 += u0;
			y2 += v0;
			x3 += u;
			y3 += v;
			x4 += u2;
			y4 += v2;
			x5 += u3;
			y5 += v3;
			x6 += u4;
			y6 += v4;
			long c0 = (long)x2 * (long)y2;
			long c = (long)x2 * (long)y3 + (long)x3 * (long)y2;
			long c2 = (long)x2 * (long)y4 + (long)x3 * (long)y3 + (long)x4 * (long)y2;
			long c3 = (long)x3 * (long)y4 + (long)x4 * (long)y3;
			c3 <<= 1;
			c3 += (long)x2 * (long)y5 + (long)x5 * (long)y2;
			long c4 = (long)x4 * (long)y4;
			c4 <<= 1;
			c4 += (long)x2 * (long)y6 + (long)x3 * (long)y5 + (long)x5 * (long)y3 + (long)x6 * (long)y2;
			long c5 = (long)x3 * (long)y6 + (long)x4 * (long)y5 + (long)x5 * (long)y4 + (long)x6 * (long)y3;
			c5 <<= 1;
			long c6 = (long)x4 * (long)y6 + (long)x6 * (long)y4;
			c6 <<= 1;
			c6 += (long)x5 * (long)y5;
			long c7 = (long)x5 * (long)y6 + (long)x6 * (long)y5;
			long c8 = (long)x6 * (long)y6;
			c8 <<= 1;
			long t = a8 + (c3 - a3);
			int z2 = (int)t & 67108863;
			t >>= 26;
			t += c4 - a4 - b4;
			int z3 = (int)t & 33554431;
			t >>= 25;
			t = a0 + (t + c5 - a5) * 38L;
			z[0] = ((int)t & 67108863);
			t >>= 26;
			t += a + (c6 - a6) * 38L;
			z[1] = ((int)t & 67108863);
			t >>= 26;
			t += a2 + (c7 - a7) * 38L;
			z[2] = ((int)t & 33554431);
			t >>= 25;
			t += a3 + (c8 - a8) * 38L;
			z[3] = ((int)t & 67108863);
			t >>= 26;
			t += a4 + b4 * 38L;
			z[4] = ((int)t & 33554431);
			t >>= 25;
			t += a5 + (c0 - a0);
			z[5] = ((int)t & 67108863);
			t >>= 26;
			t += a6 + (c - a);
			z[6] = ((int)t & 67108863);
			t >>= 26;
			t += a7 + (c2 - a2);
			z[7] = ((int)t & 33554431);
			t >>= 25;
			t += (long)z2;
			z[8] = ((int)t & 67108863);
			t >>= 26;
			z[9] = z3 + (int)t;
		}

		// Token: 0x0600167A RID: 5754 RVA: 0x0006C86C File Offset: 0x0006AA6C
		public static void Negate(int[] x, int[] z)
		{
			for (int i = 0; i < 10; i++)
			{
				z[i] = -x[i];
			}
		}

		// Token: 0x0600167B RID: 5755 RVA: 0x0006C890 File Offset: 0x0006AA90
		public static void Normalize(int[] z)
		{
			int x = z[9] >> 23 & 1;
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Reduce(z, x);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Reduce(z, -x);
		}

		// Token: 0x0600167C RID: 5756 RVA: 0x0006C8B8 File Offset: 0x0006AAB8
		public static void One(int[] z)
		{
			z[0] = 1;
			for (int i = 1; i < 10; i++)
			{
				z[i] = 0;
			}
		}

		// Token: 0x0600167D RID: 5757 RVA: 0x0006C8DC File Offset: 0x0006AADC
		private static void PowPm5d8(int[] x, int[] rx2, int[] rz)
		{
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Sqr(x, rx2);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(x, rx2, rx2);
			int[] x2 = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Sqr(rx2, x2);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(x, x2, x2);
			int[] x3 = x2;
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Sqr(x2, 2, x3);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(rx2, x3, x3);
			int[] x4 = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Sqr(x3, 5, x4);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(x3, x4, x4);
			int[] x5 = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Sqr(x4, 5, x5);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(x3, x5, x5);
			int[] x6 = x3;
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Sqr(x5, 10, x6);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(x4, x6, x6);
			int[] x7 = x4;
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Sqr(x6, 25, x7);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(x6, x7, x7);
			int[] x8 = x5;
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Sqr(x7, 25, x8);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(x6, x8, x8);
			int[] x9 = x6;
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Sqr(x8, 50, x9);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(x7, x9, x9);
			int[] x10 = x7;
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Sqr(x9, 125, x10);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(x9, x10, x10);
			int[] t = x9;
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Sqr(x10, 2, t);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(t, x, rz);
		}

		// Token: 0x0600167E RID: 5758 RVA: 0x0006C9E8 File Offset: 0x0006ABE8
		private static void Reduce(int[] z, int x)
		{
			int num = z[9];
			int z2 = num & 16777215;
			long cc = (long)(((num >> 24) + x) * 19);
			cc += (long)z[0];
			z[0] = ((int)cc & 67108863);
			cc >>= 26;
			cc += (long)z[1];
			z[1] = ((int)cc & 67108863);
			cc >>= 26;
			cc += (long)z[2];
			z[2] = ((int)cc & 33554431);
			cc >>= 25;
			cc += (long)z[3];
			z[3] = ((int)cc & 67108863);
			cc >>= 26;
			cc += (long)z[4];
			z[4] = ((int)cc & 33554431);
			cc >>= 25;
			cc += (long)z[5];
			z[5] = ((int)cc & 67108863);
			cc >>= 26;
			cc += (long)z[6];
			z[6] = ((int)cc & 67108863);
			cc >>= 26;
			cc += (long)z[7];
			z[7] = ((int)cc & 33554431);
			cc >>= 25;
			cc += (long)z[8];
			z[8] = ((int)cc & 67108863);
			cc >>= 26;
			z[9] = z2 + (int)cc;
		}

		// Token: 0x0600167F RID: 5759 RVA: 0x0006CAE4 File Offset: 0x0006ACE4
		public static void Sqr(int[] x, int[] z)
		{
			int x2 = x[0];
			int x3 = x[1];
			int num = x[2];
			int x4 = x[3];
			int x5 = x[4];
			int u0 = x[5];
			int u = x[6];
			int u2 = x[7];
			int u3 = x[8];
			int u4 = x[9];
			int x1_2 = x3 * 2;
			int x2_2 = num * 2;
			int x3_2 = x4 * 2;
			int x4_2 = x5 * 2;
			long a0 = (long)x2 * (long)x2;
			long a = (long)x2 * (long)x1_2;
			long a2 = (long)x2 * (long)x2_2 + (long)x3 * (long)x3;
			long a3 = (long)x1_2 * (long)x2_2 + (long)x2 * (long)x3_2;
			long a4 = (long)num * (long)x2_2 + (long)x2 * (long)x4_2 + (long)x3 * (long)x3_2;
			long a5 = (long)x1_2 * (long)x4_2 + (long)x2_2 * (long)x3_2;
			long a6 = (long)x2_2 * (long)x4_2 + (long)x4 * (long)x4;
			long a7 = (long)x4 * (long)x4_2;
			long a8 = (long)x5 * (long)x4_2;
			int u1_2 = u * 2;
			int u2_2 = u2 * 2;
			int u3_2 = u3 * 2;
			int u4_2 = u4 * 2;
			long b0 = (long)u0 * (long)u0;
			long b = (long)u0 * (long)u1_2;
			long b2 = (long)u0 * (long)u2_2 + (long)u * (long)u;
			long b3 = (long)u1_2 * (long)u2_2 + (long)u0 * (long)u3_2;
			long b4 = (long)u2 * (long)u2_2 + (long)u0 * (long)u4_2 + (long)u * (long)u3_2;
			long b5 = (long)u1_2 * (long)u4_2 + (long)u2_2 * (long)u3_2;
			long b6 = (long)u2_2 * (long)u4_2 + (long)u3 * (long)u3;
			long b7 = (long)u3 * (long)u4_2;
			long b8 = (long)u4 * (long)u4_2;
			a0 -= b5 * 38L;
			a -= b6 * 38L;
			a2 -= b7 * 38L;
			a3 -= b8 * 38L;
			a5 -= b0;
			a6 -= b;
			a7 -= b2;
			a8 -= b3;
			x2 += u0;
			x3 += u;
			int num2 = num + u2;
			x4 += u3;
			x5 += u4;
			x1_2 = x3 * 2;
			x2_2 = num2 * 2;
			x3_2 = x4 * 2;
			x4_2 = x5 * 2;
			long c0 = (long)x2 * (long)x2;
			long c = (long)x2 * (long)x1_2;
			long c2 = (long)x2 * (long)x2_2 + (long)x3 * (long)x3;
			long c3 = (long)x1_2 * (long)x2_2 + (long)x2 * (long)x3_2;
			long c4 = (long)num2 * (long)x2_2 + (long)x2 * (long)x4_2 + (long)x3 * (long)x3_2;
			long c5 = (long)x1_2 * (long)x4_2 + (long)x2_2 * (long)x3_2;
			long c6 = (long)x2_2 * (long)x4_2 + (long)x4 * (long)x4;
			long c7 = (long)x4 * (long)x4_2;
			long c8 = (long)x5 * (long)x4_2;
			long t = a8 + (c3 - a3);
			int z2 = (int)t & 67108863;
			t >>= 26;
			t += c4 - a4 - b4;
			int z3 = (int)t & 33554431;
			t >>= 25;
			t = a0 + (t + c5 - a5) * 38L;
			z[0] = ((int)t & 67108863);
			t >>= 26;
			t += a + (c6 - a6) * 38L;
			z[1] = ((int)t & 67108863);
			t >>= 26;
			t += a2 + (c7 - a7) * 38L;
			z[2] = ((int)t & 33554431);
			t >>= 25;
			t += a3 + (c8 - a8) * 38L;
			z[3] = ((int)t & 67108863);
			t >>= 26;
			t += a4 + b4 * 38L;
			z[4] = ((int)t & 33554431);
			t >>= 25;
			t += a5 + (c0 - a0);
			z[5] = ((int)t & 67108863);
			t >>= 26;
			t += a6 + (c - a);
			z[6] = ((int)t & 67108863);
			t >>= 26;
			t += a7 + (c2 - a2);
			z[7] = ((int)t & 33554431);
			t >>= 25;
			t += (long)z2;
			z[8] = ((int)t & 67108863);
			t >>= 26;
			z[9] = z3 + (int)t;
		}

		// Token: 0x06001680 RID: 5760 RVA: 0x0006CE94 File Offset: 0x0006B094
		public static void Sqr(int[] x, int n, int[] z)
		{
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Sqr(x, z);
			while (--n > 0)
			{
				global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Sqr(z, z);
			}
		}

		// Token: 0x06001681 RID: 5761 RVA: 0x0006CEB0 File Offset: 0x0006B0B0
		public static bool SqrtRatioVar(int[] u, int[] v, int[] z)
		{
			int[] uv3 = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] uv4 = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(u, v, uv3);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Sqr(v, uv4);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(uv3, uv4, uv3);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Sqr(uv4, uv4);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(uv4, uv3, uv4);
			int[] t = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] x = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.PowPm5d8(uv4, t, x);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(x, uv3, x);
			int[] vx2 = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Sqr(x, vx2);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(vx2, v, vx2);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Sub(vx2, u, t);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Normalize(t);
			if (global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.IsZeroVar(t))
			{
				global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Copy(x, 0, z, 0);
				return true;
			}
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Add(vx2, u, t);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Normalize(t);
			if (global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.IsZeroVar(t))
			{
				global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(x, global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.RootNegOne, z);
				return true;
			}
			return false;
		}

		// Token: 0x06001682 RID: 5762 RVA: 0x0006CF6C File Offset: 0x0006B16C
		public static void Sub(int[] x, int[] y, int[] z)
		{
			for (int i = 0; i < 10; i++)
			{
				z[i] = x[i] - y[i];
			}
		}

		// Token: 0x06001683 RID: 5763 RVA: 0x0006CF90 File Offset: 0x0006B190
		public static void SubOne(int[] z)
		{
			z[0]--;
		}

		// Token: 0x06001684 RID: 5764 RVA: 0x0006CFA0 File Offset: 0x0006B1A0
		public static void Zero(int[] z)
		{
			for (int i = 0; i < 10; i++)
			{
				z[i] = 0;
			}
		}

		// Token: 0x040009C3 RID: 2499
		public const int Size = 10;

		// Token: 0x040009C4 RID: 2500
		private const int M24 = 16777215;

		// Token: 0x040009C5 RID: 2501
		private const int M25 = 33554431;

		// Token: 0x040009C6 RID: 2502
		private const int M26 = 67108863;

		// Token: 0x040009C7 RID: 2503
		private static readonly uint[] P32 = new uint[]
		{
			4294967277U,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			2147483647U
		};

		// Token: 0x040009C8 RID: 2504
		private static readonly int[] RootNegOne = new int[]
		{
			34513072,
			59165138,
			4688974,
			3500415,
			6194736,
			33281959,
			54535759,
			32551604,
			163342,
			5703241
		};
	}
}
