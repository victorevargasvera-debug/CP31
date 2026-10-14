using System;
using Org.BouncyCastle.Math.Raw;

namespace Org.BouncyCastle.Math.EC.Rfc7748
{
	// Token: 0x02000223 RID: 547
	[global::System.CLSCompliant(false)]
	public abstract class X448Field
	{
		// Token: 0x06001691 RID: 5777 RVA: 0x0006D314 File Offset: 0x0006B514
		public static void Add(uint[] x, uint[] y, uint[] z)
		{
			for (int i = 0; i < 16; i++)
			{
				z[i] = x[i] + y[i];
			}
		}

		// Token: 0x06001692 RID: 5778 RVA: 0x0006D338 File Offset: 0x0006B538
		public static void AddOne(uint[] z)
		{
			z[0] += 1U;
		}

		// Token: 0x06001693 RID: 5779 RVA: 0x0006D346 File Offset: 0x0006B546
		public static void AddOne(uint[] z, int zOff)
		{
			z[zOff] += 1U;
		}

		// Token: 0x06001694 RID: 5780 RVA: 0x0006D354 File Offset: 0x0006B554
		public static int AreEqual(uint[] x, uint[] y)
		{
			uint d = 0U;
			for (int i = 0; i < 16; i++)
			{
				d |= (x[i] ^ y[i]);
			}
			d |= d >> 16;
			d &= 65535U;
			return (int)(d - 1U) >> 31;
		}

		// Token: 0x06001695 RID: 5781 RVA: 0x0006D38F File Offset: 0x0006B58F
		public static bool AreEqualVar(uint[] x, uint[] y)
		{
			return global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.AreEqual(x, y) != 0;
		}

		// Token: 0x06001696 RID: 5782 RVA: 0x0006D39C File Offset: 0x0006B59C
		public static void Carry(uint[] z)
		{
			uint z2 = z[0];
			uint z3 = z[1];
			uint z4 = z[2];
			uint z5 = z[3];
			uint z6 = z[4];
			uint z7 = z[5];
			uint z8 = z[6];
			uint z9 = z[7];
			uint z10 = z[8];
			uint z11 = z[9];
			uint z12 = z[10];
			uint z13 = z[11];
			uint z14 = z[12];
			uint z15 = z[13];
			uint z16 = z[14];
			uint z17 = z[15];
			z3 += z2 >> 28;
			z2 &= 268435455U;
			z7 += z6 >> 28;
			z6 &= 268435455U;
			z11 += z10 >> 28;
			z10 &= 268435455U;
			z15 += z14 >> 28;
			z14 &= 268435455U;
			z4 += z3 >> 28;
			z3 &= 268435455U;
			z8 += z7 >> 28;
			z7 &= 268435455U;
			z12 += z11 >> 28;
			z11 &= 268435455U;
			z16 += z15 >> 28;
			z15 &= 268435455U;
			z5 += z4 >> 28;
			z4 &= 268435455U;
			z9 += z8 >> 28;
			z8 &= 268435455U;
			z13 += z12 >> 28;
			z12 &= 268435455U;
			z17 += z16 >> 28;
			z16 &= 268435455U;
			uint t = z17 >> 28;
			z17 &= 268435455U;
			z2 += t;
			z10 += t;
			z6 += z5 >> 28;
			z5 &= 268435455U;
			z10 += z9 >> 28;
			z9 &= 268435455U;
			z14 += z13 >> 28;
			z13 &= 268435455U;
			z3 += z2 >> 28;
			z2 &= 268435455U;
			z7 += z6 >> 28;
			z6 &= 268435455U;
			z11 += z10 >> 28;
			z10 &= 268435455U;
			z15 += z14 >> 28;
			z14 &= 268435455U;
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
			z[10] = z12;
			z[11] = z13;
			z[12] = z14;
			z[13] = z15;
			z[14] = z16;
			z[15] = z17;
		}

		// Token: 0x06001697 RID: 5783 RVA: 0x0006D5D4 File Offset: 0x0006B7D4
		public static void CMov(int cond, uint[] x, int xOff, uint[] z, int zOff)
		{
			for (int i = 0; i < 16; i++)
			{
				uint z_i = z[zOff + i];
				uint diff = z_i ^ x[xOff + i];
				z_i ^= (diff & (uint)cond);
				z[zOff + i] = z_i;
			}
		}

		// Token: 0x06001698 RID: 5784 RVA: 0x0006D60C File Offset: 0x0006B80C
		public static void CNegate(int negate, uint[] z)
		{
			uint[] t = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sub(t, z, t);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.CMov(-negate, t, 0, z, 0);
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x0006D634 File Offset: 0x0006B834
		public static void Copy(uint[] x, int xOff, uint[] z, int zOff)
		{
			for (int i = 0; i < 16; i++)
			{
				z[zOff + i] = x[xOff + i];
			}
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x0006D658 File Offset: 0x0006B858
		public static uint[] Create()
		{
			return new uint[16];
		}

		// Token: 0x0600169B RID: 5787 RVA: 0x0006D661 File Offset: 0x0006B861
		public static uint[] CreateTable(int n)
		{
			return new uint[16 * n];
		}

		// Token: 0x0600169C RID: 5788 RVA: 0x0006D66C File Offset: 0x0006B86C
		public static void CSwap(int swap, uint[] a, uint[] b)
		{
			uint mask = (uint)(0 - swap);
			for (int i = 0; i < 16; i++)
			{
				uint ai = a[i];
				uint bi = b[i];
				uint dummy = mask & (ai ^ bi);
				a[i] = (ai ^ dummy);
				b[i] = (bi ^ dummy);
			}
		}

		// Token: 0x0600169D RID: 5789 RVA: 0x0006D6A7 File Offset: 0x0006B8A7
		public static void Decode(uint[] x, int xOff, uint[] z)
		{
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Decode224(x, xOff, z, 0);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Decode224(x, xOff + 7, z, 8);
		}

		// Token: 0x0600169E RID: 5790 RVA: 0x0006D6C0 File Offset: 0x0006B8C0
		public static void Decode(byte[] x, int xOff, uint[] z)
		{
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Decode56(x, xOff, z, 0);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Decode56(x, xOff + 7, z, 2);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Decode56(x, xOff + 14, z, 4);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Decode56(x, xOff + 21, z, 6);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Decode56(x, xOff + 28, z, 8);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Decode56(x, xOff + 35, z, 10);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Decode56(x, xOff + 42, z, 12);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Decode56(x, xOff + 49, z, 14);
		}

		// Token: 0x0600169F RID: 5791 RVA: 0x0006D72C File Offset: 0x0006B92C
		private static void Decode224(uint[] x, int xOff, uint[] z, int zOff)
		{
			uint x2 = x[xOff];
			uint x3 = x[xOff + 1];
			uint x4 = x[xOff + 2];
			uint x5 = x[xOff + 3];
			uint x6 = x[xOff + 4];
			uint x7 = x[xOff + 5];
			uint x8 = x[xOff + 6];
			z[zOff] = (x2 & 268435455U);
			z[zOff + 1] = ((x2 >> 28 | x3 << 4) & 268435455U);
			z[zOff + 2] = ((x3 >> 24 | x4 << 8) & 268435455U);
			z[zOff + 3] = ((x4 >> 20 | x5 << 12) & 268435455U);
			z[zOff + 4] = ((x5 >> 16 | x6 << 16) & 268435455U);
			z[zOff + 5] = ((x6 >> 12 | x7 << 20) & 268435455U);
			z[zOff + 6] = ((x7 >> 8 | x8 << 24) & 268435455U);
			z[zOff + 7] = x8 >> 4;
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x0006D7F1 File Offset: 0x0006B9F1
		private static uint Decode24(byte[] bs, int off)
		{
			return (uint)((int)bs[off] | (int)bs[++off] << 8 | (int)bs[++off] << 16);
		}

		// Token: 0x060016A1 RID: 5793 RVA: 0x0006D80D File Offset: 0x0006BA0D
		private static uint Decode32(byte[] bs, int off)
		{
			return (uint)((int)bs[off] | (int)bs[++off] << 8 | (int)bs[++off] << 16 | (int)bs[++off] << 24);
		}

		// Token: 0x060016A2 RID: 5794 RVA: 0x0006D838 File Offset: 0x0006BA38
		private static void Decode56(byte[] bs, int off, uint[] z, int zOff)
		{
			uint lo = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Decode32(bs, off);
			uint hi = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Decode24(bs, off + 4);
			z[zOff] = (lo & 268435455U);
			z[zOff + 1] = (lo >> 28 | hi << 4);
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x0006D86E File Offset: 0x0006BA6E
		public static void Encode(uint[] x, uint[] z, int zOff)
		{
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Encode224(x, 0, z, zOff);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Encode224(x, 8, z, zOff + 7);
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x0006D884 File Offset: 0x0006BA84
		public static void Encode(uint[] x, byte[] z, int zOff)
		{
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Encode56(x, 0, z, zOff);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Encode56(x, 2, z, zOff + 7);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Encode56(x, 4, z, zOff + 14);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Encode56(x, 6, z, zOff + 21);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Encode56(x, 8, z, zOff + 28);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Encode56(x, 10, z, zOff + 35);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Encode56(x, 12, z, zOff + 42);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Encode56(x, 14, z, zOff + 49);
		}

		// Token: 0x060016A5 RID: 5797 RVA: 0x0006D8F0 File Offset: 0x0006BAF0
		private static void Encode224(uint[] x, int xOff, uint[] z, int zOff)
		{
			uint x2 = x[xOff];
			uint x3 = x[xOff + 1];
			uint x4 = x[xOff + 2];
			uint x5 = x[xOff + 3];
			uint x6 = x[xOff + 4];
			uint x7 = x[xOff + 5];
			uint x8 = x[xOff + 6];
			uint x9 = x[xOff + 7];
			z[zOff] = (x2 | x3 << 28);
			z[zOff + 1] = (x3 >> 4 | x4 << 24);
			z[zOff + 2] = (x4 >> 8 | x5 << 20);
			z[zOff + 3] = (x5 >> 12 | x6 << 16);
			z[zOff + 4] = (x6 >> 16 | x7 << 12);
			z[zOff + 5] = (x7 >> 20 | x8 << 8);
			z[zOff + 6] = (x8 >> 24 | x9 << 4);
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x0006D98F File Offset: 0x0006BB8F
		private static void Encode24(uint n, byte[] bs, int off)
		{
			bs[off] = (byte)n;
			bs[++off] = (byte)(n >> 8);
			bs[++off] = (byte)(n >> 16);
		}

		// Token: 0x060016A7 RID: 5799 RVA: 0x0006D9AF File Offset: 0x0006BBAF
		private static void Encode32(uint n, byte[] bs, int off)
		{
			bs[off] = (byte)n;
			bs[++off] = (byte)(n >> 8);
			bs[++off] = (byte)(n >> 16);
			bs[++off] = (byte)(n >> 24);
		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x0006D9DC File Offset: 0x0006BBDC
		private static void Encode56(uint[] x, int xOff, byte[] bs, int off)
		{
			uint num = x[xOff];
			uint hi = x[xOff + 1];
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Encode32(num | hi << 28, bs, off);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Encode24(hi >> 4, bs, off + 4);
		}

		// Token: 0x060016A9 RID: 5801 RVA: 0x0006DA0C File Offset: 0x0006BC0C
		public static void Inv(uint[] x, uint[] z)
		{
			uint[] t = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			uint[] u = new uint[14];
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Copy(x, 0, t, 0);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Normalize(t);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Encode(t, u, 0);
			global::Org.BouncyCastle.Math.Raw.Mod.ModOddInverse(global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.P32, u, u);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Decode(u, 0, z);
		}

		// Token: 0x060016AA RID: 5802 RVA: 0x0006DA54 File Offset: 0x0006BC54
		public static void InvVar(uint[] x, uint[] z)
		{
			uint[] t = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			uint[] u = new uint[14];
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Copy(x, 0, t, 0);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Normalize(t);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Encode(t, u, 0);
			global::Org.BouncyCastle.Math.Raw.Mod.ModOddInverseVar(global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.P32, u, u);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Decode(u, 0, z);
		}

		// Token: 0x060016AB RID: 5803 RVA: 0x0006DA9C File Offset: 0x0006BC9C
		public static int IsOne(uint[] x)
		{
			uint d = x[0] ^ 1U;
			for (int i = 1; i < 16; i++)
			{
				d |= x[i];
			}
			d |= d >> 16;
			d &= 65535U;
			return (int)(d - 1U) >> 31;
		}

		// Token: 0x060016AC RID: 5804 RVA: 0x0006DAD7 File Offset: 0x0006BCD7
		public static bool IsOneVar(uint[] x)
		{
			return global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.IsOne(x) != 0;
		}

		// Token: 0x060016AD RID: 5805 RVA: 0x0006DAE4 File Offset: 0x0006BCE4
		public static int IsZero(uint[] x)
		{
			uint d = 0U;
			for (int i = 0; i < 16; i++)
			{
				d |= x[i];
			}
			d |= d >> 16;
			d &= 65535U;
			return (int)(d - 1U) >> 31;
		}

		// Token: 0x060016AE RID: 5806 RVA: 0x0006DB1B File Offset: 0x0006BD1B
		public static bool IsZeroVar(uint[] x)
		{
			return (long)global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.IsZero(x) != 0L;
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x0006DB28 File Offset: 0x0006BD28
		public static void Mul(uint[] x, uint y, uint[] z)
		{
			uint x2 = x[0];
			uint x3 = x[1];
			uint x4 = x[2];
			uint x5 = x[3];
			uint x6 = x[4];
			uint x7 = x[5];
			uint x8 = x[6];
			uint x9 = x[7];
			uint x10 = x[8];
			uint x11 = x[9];
			uint x12 = x[10];
			uint x13 = x[11];
			uint x14 = x[12];
			ulong num = (ulong)x[13];
			uint x15 = x[14];
			uint x16 = x[15];
			ulong c = (ulong)x3 * (ulong)y;
			uint z2 = (uint)c & 268435455U;
			c >>= 28;
			ulong d = (ulong)x7 * (ulong)y;
			uint z3 = (uint)d & 268435455U;
			d >>= 28;
			ulong e = (ulong)x11 * (ulong)y;
			uint z4 = (uint)e & 268435455U;
			e >>= 28;
			ulong f = num * (ulong)y;
			uint z5 = (uint)f & 268435455U;
			f >>= 28;
			c += (ulong)x4 * (ulong)y;
			z[2] = ((uint)c & 268435455U);
			c >>= 28;
			d += (ulong)x8 * (ulong)y;
			z[6] = ((uint)d & 268435455U);
			d >>= 28;
			e += (ulong)x12 * (ulong)y;
			z[10] = ((uint)e & 268435455U);
			e >>= 28;
			f += (ulong)x15 * (ulong)y;
			z[14] = ((uint)f & 268435455U);
			f >>= 28;
			c += (ulong)x5 * (ulong)y;
			z[3] = ((uint)c & 268435455U);
			c >>= 28;
			d += (ulong)x9 * (ulong)y;
			z[7] = ((uint)d & 268435455U);
			d >>= 28;
			e += (ulong)x13 * (ulong)y;
			z[11] = ((uint)e & 268435455U);
			e >>= 28;
			f += (ulong)x16 * (ulong)y;
			z[15] = ((uint)f & 268435455U);
			f >>= 28;
			d += f;
			c += (ulong)x6 * (ulong)y;
			z[4] = ((uint)c & 268435455U);
			c >>= 28;
			d += (ulong)x10 * (ulong)y;
			z[8] = ((uint)d & 268435455U);
			d >>= 28;
			e += (ulong)x14 * (ulong)y;
			z[12] = ((uint)e & 268435455U);
			e >>= 28;
			f += (ulong)x2 * (ulong)y;
			z[0] = ((uint)f & 268435455U);
			f >>= 28;
			z[1] = z2 + (uint)f;
			z[5] = z3 + (uint)c;
			z[9] = z4 + (uint)d;
			z[13] = z5 + (uint)e;
		}

		// Token: 0x060016B0 RID: 5808 RVA: 0x0006DD84 File Offset: 0x0006BF84
		public static void Mul(uint[] x, uint[] y, uint[] z)
		{
			uint x2 = x[0];
			uint x3 = x[1];
			uint x4 = x[2];
			uint x5 = x[3];
			uint x6 = x[4];
			uint x7 = x[5];
			uint x8 = x[6];
			uint x9 = x[7];
			uint u0 = x[8];
			uint u = x[9];
			uint u2 = x[10];
			uint u3 = x[11];
			uint u4 = x[12];
			uint u5 = x[13];
			uint u6 = x[14];
			uint u7 = x[15];
			uint y2 = y[0];
			uint y3 = y[1];
			uint y4 = y[2];
			uint y5 = y[3];
			uint y6 = y[4];
			uint y7 = y[5];
			uint y8 = y[6];
			uint y9 = y[7];
			uint v0 = y[8];
			uint v = y[9];
			uint v2 = y[10];
			uint v3 = y[11];
			uint v4 = y[12];
			uint v5 = y[13];
			uint v6 = y[14];
			uint v7 = y[15];
			uint s0 = x2 + u0;
			uint s = x3 + u;
			uint s2 = x4 + u2;
			uint s3 = x5 + u3;
			uint s4 = x6 + u4;
			uint s5 = x7 + u5;
			uint s6 = x8 + u6;
			uint s7 = x9 + u7;
			uint t0 = y2 + v0;
			uint t = y3 + v;
			uint t2 = y4 + v2;
			uint t3 = y5 + v3;
			uint t4 = y6 + v4;
			uint t5 = y7 + v5;
			uint t6 = y8 + v6;
			uint t7 = y9 + v7;
			ulong f0 = (ulong)x2 * (ulong)y2;
			ulong f = (ulong)x9 * (ulong)y3 + (ulong)x8 * (ulong)y4 + (ulong)x7 * (ulong)y5 + (ulong)x6 * (ulong)y6 + (ulong)x5 * (ulong)y7 + (ulong)x4 * (ulong)y8 + (ulong)x3 * (ulong)y9;
			ulong g0 = (ulong)u0 * (ulong)v0;
			ulong num = (ulong)u7 * (ulong)v + (ulong)u6 * (ulong)v2 + (ulong)u5 * (ulong)v3 + (ulong)u4 * (ulong)v4 + (ulong)u3 * (ulong)v5 + (ulong)u2 * (ulong)v6 + (ulong)u * (ulong)v7;
			ulong h0 = (ulong)s0 * (ulong)t0;
			ulong h = (ulong)s7 * (ulong)t + (ulong)s6 * (ulong)t2 + (ulong)s5 * (ulong)t3 + (ulong)s4 * (ulong)t4 + (ulong)s3 * (ulong)t5 + (ulong)s2 * (ulong)t6 + (ulong)s * (ulong)t7;
			ulong c = f0 + g0 + h - f;
			uint z2 = (uint)c & 268435455U;
			c >>= 28;
			ulong d = num + h0 - f0 + h;
			uint z3 = (uint)d & 268435455U;
			d >>= 28;
			ulong f2 = (ulong)x3 * (ulong)y2 + (ulong)x2 * (ulong)y3;
			ulong f3 = (ulong)x9 * (ulong)y4 + (ulong)x8 * (ulong)y5 + (ulong)x7 * (ulong)y6 + (ulong)x6 * (ulong)y7 + (ulong)x5 * (ulong)y8 + (ulong)x4 * (ulong)y9;
			ulong g = (ulong)u * (ulong)v0 + (ulong)u0 * (ulong)v;
			ulong g2 = (ulong)u7 * (ulong)v2 + (ulong)u6 * (ulong)v3 + (ulong)u5 * (ulong)v4 + (ulong)u4 * (ulong)v5 + (ulong)u3 * (ulong)v6 + (ulong)u2 * (ulong)v7;
			ulong h2 = (ulong)s * (ulong)t0 + (ulong)s0 * (ulong)t;
			ulong h3 = (ulong)s7 * (ulong)t2 + (ulong)s6 * (ulong)t3 + (ulong)s5 * (ulong)t4 + (ulong)s4 * (ulong)t5 + (ulong)s3 * (ulong)t6 + (ulong)s2 * (ulong)t7;
			c += f2 + g + h3 - f3;
			uint z4 = (uint)c & 268435455U;
			c >>= 28;
			d += g2 + h2 - f2 + h3;
			uint z5 = (uint)d & 268435455U;
			d >>= 28;
			ulong f4 = (ulong)x4 * (ulong)y2 + (ulong)x3 * (ulong)y3 + (ulong)x2 * (ulong)y4;
			ulong f5 = (ulong)x9 * (ulong)y5 + (ulong)x8 * (ulong)y6 + (ulong)x7 * (ulong)y7 + (ulong)x6 * (ulong)y8 + (ulong)x5 * (ulong)y9;
			ulong g3 = (ulong)u2 * (ulong)v0 + (ulong)u * (ulong)v + (ulong)u0 * (ulong)v2;
			ulong g4 = (ulong)u7 * (ulong)v3 + (ulong)u6 * (ulong)v4 + (ulong)u5 * (ulong)v5 + (ulong)u4 * (ulong)v6 + (ulong)u3 * (ulong)v7;
			ulong h4 = (ulong)s2 * (ulong)t0 + (ulong)s * (ulong)t + (ulong)s0 * (ulong)t2;
			ulong h5 = (ulong)s7 * (ulong)t3 + (ulong)s6 * (ulong)t4 + (ulong)s5 * (ulong)t5 + (ulong)s4 * (ulong)t6 + (ulong)s3 * (ulong)t7;
			c += f4 + g3 + h5 - f5;
			uint z6 = (uint)c & 268435455U;
			c >>= 28;
			d += g4 + h4 - f4 + h5;
			uint z7 = (uint)d & 268435455U;
			d >>= 28;
			ulong f6 = (ulong)x5 * (ulong)y2 + (ulong)x4 * (ulong)y3 + (ulong)x3 * (ulong)y4 + (ulong)x2 * (ulong)y5;
			ulong f7 = (ulong)x9 * (ulong)y6 + (ulong)x8 * (ulong)y7 + (ulong)x7 * (ulong)y8 + (ulong)x6 * (ulong)y9;
			ulong g5 = (ulong)u3 * (ulong)v0 + (ulong)u2 * (ulong)v + (ulong)u * (ulong)v2 + (ulong)u0 * (ulong)v3;
			ulong g6 = (ulong)u7 * (ulong)v4 + (ulong)u6 * (ulong)v5 + (ulong)u5 * (ulong)v6 + (ulong)u4 * (ulong)v7;
			ulong h6 = (ulong)s3 * (ulong)t0 + (ulong)s2 * (ulong)t + (ulong)s * (ulong)t2 + (ulong)s0 * (ulong)t3;
			ulong h7 = (ulong)s7 * (ulong)t4 + (ulong)s6 * (ulong)t5 + (ulong)s5 * (ulong)t6 + (ulong)s4 * (ulong)t7;
			c += f6 + g5 + h7 - f7;
			uint z8 = (uint)c & 268435455U;
			c >>= 28;
			d += g6 + h6 - f6 + h7;
			uint z9 = (uint)d & 268435455U;
			d >>= 28;
			ulong f8 = (ulong)x6 * (ulong)y2 + (ulong)x5 * (ulong)y3 + (ulong)x4 * (ulong)y4 + (ulong)x3 * (ulong)y5 + (ulong)x2 * (ulong)y6;
			ulong f9 = (ulong)x9 * (ulong)y7 + (ulong)x8 * (ulong)y8 + (ulong)x7 * (ulong)y9;
			ulong g7 = (ulong)u4 * (ulong)v0 + (ulong)u3 * (ulong)v + (ulong)u2 * (ulong)v2 + (ulong)u * (ulong)v3 + (ulong)u0 * (ulong)v4;
			ulong g8 = (ulong)u7 * (ulong)v5 + (ulong)u6 * (ulong)v6 + (ulong)u5 * (ulong)v7;
			ulong h8 = (ulong)s4 * (ulong)t0 + (ulong)s3 * (ulong)t + (ulong)s2 * (ulong)t2 + (ulong)s * (ulong)t3 + (ulong)s0 * (ulong)t4;
			ulong h9 = (ulong)s7 * (ulong)t5 + (ulong)s6 * (ulong)t6 + (ulong)s5 * (ulong)t7;
			c += f8 + g7 + h9 - f9;
			uint z10 = (uint)c & 268435455U;
			c >>= 28;
			d += g8 + h8 - f8 + h9;
			uint z11 = (uint)d & 268435455U;
			d >>= 28;
			ulong f10 = (ulong)x7 * (ulong)y2 + (ulong)x6 * (ulong)y3 + (ulong)x5 * (ulong)y4 + (ulong)x4 * (ulong)y5 + (ulong)x3 * (ulong)y6 + (ulong)x2 * (ulong)y7;
			ulong f11 = (ulong)x9 * (ulong)y8 + (ulong)x8 * (ulong)y9;
			ulong g9 = (ulong)u5 * (ulong)v0 + (ulong)u4 * (ulong)v + (ulong)u3 * (ulong)v2 + (ulong)u2 * (ulong)v3 + (ulong)u * (ulong)v4 + (ulong)u0 * (ulong)v5;
			ulong g10 = (ulong)u7 * (ulong)v6 + (ulong)u6 * (ulong)v7;
			ulong h10 = (ulong)s5 * (ulong)t0 + (ulong)s4 * (ulong)t + (ulong)s3 * (ulong)t2 + (ulong)s2 * (ulong)t3 + (ulong)s * (ulong)t4 + (ulong)s0 * (ulong)t5;
			ulong h11 = (ulong)s7 * (ulong)t6 + (ulong)s6 * (ulong)t7;
			c += f10 + g9 + h11 - f11;
			uint z12 = (uint)c & 268435455U;
			c >>= 28;
			d += g10 + h10 - f10 + h11;
			uint z13 = (uint)d & 268435455U;
			d >>= 28;
			ulong f12 = (ulong)x8 * (ulong)y2 + (ulong)x7 * (ulong)y3 + (ulong)x6 * (ulong)y4 + (ulong)x5 * (ulong)y5 + (ulong)x4 * (ulong)y6 + (ulong)x3 * (ulong)y7 + (ulong)x2 * (ulong)y8;
			ulong f13 = (ulong)x9 * (ulong)y9;
			ulong g11 = (ulong)u6 * (ulong)v0 + (ulong)u5 * (ulong)v + (ulong)u4 * (ulong)v2 + (ulong)u3 * (ulong)v3 + (ulong)u2 * (ulong)v4 + (ulong)u * (ulong)v5 + (ulong)u0 * (ulong)v6;
			ulong g12 = (ulong)u7 * (ulong)v7;
			ulong h12 = (ulong)s6 * (ulong)t0 + (ulong)s5 * (ulong)t + (ulong)s4 * (ulong)t2 + (ulong)s3 * (ulong)t3 + (ulong)s2 * (ulong)t4 + (ulong)s * (ulong)t5 + (ulong)s0 * (ulong)t6;
			ulong h13 = (ulong)s7 * (ulong)t7;
			c += f12 + g11 + h13 - f13;
			uint z14 = (uint)c & 268435455U;
			c >>= 28;
			d += g12 + h12 - f12 + h13;
			uint z15 = (uint)d & 268435455U;
			d >>= 28;
			ulong f14 = (ulong)x9 * (ulong)y2 + (ulong)x8 * (ulong)y3 + (ulong)x7 * (ulong)y4 + (ulong)x6 * (ulong)y5 + (ulong)x5 * (ulong)y6 + (ulong)x4 * (ulong)y7 + (ulong)x3 * (ulong)y8 + (ulong)x2 * (ulong)y9;
			ulong g13 = (ulong)u7 * (ulong)v0 + (ulong)u6 * (ulong)v + (ulong)u5 * (ulong)v2 + (ulong)u4 * (ulong)v3 + (ulong)u3 * (ulong)v4 + (ulong)u2 * (ulong)v5 + (ulong)u * (ulong)v6 + (ulong)u0 * (ulong)v7;
			ulong h14 = (ulong)s7 * (ulong)t0 + (ulong)s6 * (ulong)t + (ulong)s5 * (ulong)t2 + (ulong)s4 * (ulong)t3 + (ulong)s3 * (ulong)t4 + (ulong)s2 * (ulong)t5 + (ulong)s * (ulong)t6 + (ulong)s0 * (ulong)t7;
			c += f14 + g13;
			uint z16 = (uint)c & 268435455U;
			c >>= 28;
			d += h14 - f14;
			uint z17 = (uint)d & 268435455U;
			d >>= 28;
			c += d;
			c += (ulong)z3;
			z3 = ((uint)c & 268435455U);
			c >>= 28;
			d += (ulong)z2;
			z2 = ((uint)d & 268435455U);
			d >>= 28;
			z5 += (uint)c;
			z4 += (uint)d;
			z[0] = z2;
			z[1] = z4;
			z[2] = z6;
			z[3] = z8;
			z[4] = z10;
			z[5] = z12;
			z[6] = z14;
			z[7] = z16;
			z[8] = z3;
			z[9] = z5;
			z[10] = z7;
			z[11] = z9;
			z[12] = z11;
			z[13] = z13;
			z[14] = z15;
			z[15] = z17;
		}

		// Token: 0x060016B1 RID: 5809 RVA: 0x0006E760 File Offset: 0x0006C960
		public static void Negate(uint[] x, uint[] z)
		{
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sub(global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create(), x, z);
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x0006E76E File Offset: 0x0006C96E
		public static void Normalize(uint[] z)
		{
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Reduce(z, 1);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Reduce(z, -1);
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x0006E780 File Offset: 0x0006C980
		public static void One(uint[] z)
		{
			z[0] = 1U;
			for (int i = 1; i < 16; i++)
			{
				z[i] = 0U;
			}
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x0006E7A4 File Offset: 0x0006C9A4
		private static void PowPm3d4(uint[] x, uint[] z)
		{
			uint[] x2 = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sqr(x, x2);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(x, x2, x2);
			uint[] x3 = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sqr(x2, x3);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(x, x3, x3);
			uint[] x4 = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sqr(x3, 3, x4);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(x3, x4, x4);
			uint[] x5 = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sqr(x4, 3, x5);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(x3, x5, x5);
			uint[] x6 = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sqr(x5, 9, x6);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(x5, x6, x6);
			uint[] x7 = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sqr(x6, x7);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(x, x7, x7);
			uint[] x8 = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sqr(x7, 18, x8);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(x6, x8, x8);
			uint[] x9 = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sqr(x8, 37, x9);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(x8, x9, x9);
			uint[] x10 = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sqr(x9, 37, x10);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(x8, x10, x10);
			uint[] x11 = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sqr(x10, 111, x11);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(x10, x11, x11);
			uint[] x12 = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sqr(x11, x12);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(x, x12, x12);
			uint[] t = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sqr(x12, 223, t);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(t, x11, z);
		}

		// Token: 0x060016B5 RID: 5813 RVA: 0x0006E8EC File Offset: 0x0006CAEC
		private static void Reduce(uint[] z, int x)
		{
			uint num = z[15];
			uint z2 = num & 268435455U;
			int t = (int)((num >> 28) + (uint)x);
			long cc = (long)t;
			for (int i = 0; i < 8; i++)
			{
				cc += (long)((ulong)z[i]);
				z[i] = ((uint)cc & 268435455U);
				cc >>= 28;
			}
			cc += (long)t;
			for (int j = 8; j < 15; j++)
			{
				cc += (long)((ulong)z[j]);
				z[j] = ((uint)cc & 268435455U);
				cc >>= 28;
			}
			z[15] = z2 + (uint)cc;
		}

		// Token: 0x060016B6 RID: 5814 RVA: 0x0006E968 File Offset: 0x0006CB68
		public static void Sqr(uint[] x, uint[] z)
		{
			uint x2 = x[0];
			uint x3 = x[1];
			uint x4 = x[2];
			uint x5 = x[3];
			uint x6 = x[4];
			uint x7 = x[5];
			uint x8 = x[6];
			uint x9 = x[7];
			uint u0 = x[8];
			uint u = x[9];
			uint u2 = x[10];
			uint u3 = x[11];
			uint u4 = x[12];
			uint u5 = x[13];
			uint u6 = x[14];
			uint u7 = x[15];
			uint x0_2 = x2 * 2U;
			uint x1_2 = x3 * 2U;
			uint x2_2 = x4 * 2U;
			uint x3_2 = x5 * 2U;
			uint x4_2 = x6 * 2U;
			uint x5_2 = x7 * 2U;
			uint x6_2 = x8 * 2U;
			uint u0_2 = u0 * 2U;
			uint u1_2 = u * 2U;
			uint u2_2 = u2 * 2U;
			uint u3_2 = u3 * 2U;
			uint u4_2 = u4 * 2U;
			uint u5_2 = u5 * 2U;
			uint u6_2 = u6 * 2U;
			uint s0 = x2 + u0;
			uint s = x3 + u;
			uint s2 = x4 + u2;
			uint s3 = x5 + u3;
			uint s4 = x6 + u4;
			uint s5 = x7 + u5;
			uint s6 = x8 + u6;
			uint s7 = x9 + u7;
			uint s0_2 = s0 * 2U;
			uint s1_2 = s * 2U;
			uint s2_2 = s2 * 2U;
			uint s3_2 = s3 * 2U;
			uint s4_2 = s4 * 2U;
			uint s5_2 = s5 * 2U;
			uint s6_2 = s6 * 2U;
			ulong f0 = (ulong)x2 * (ulong)x2;
			ulong f = (ulong)x9 * (ulong)x1_2 + (ulong)x8 * (ulong)x2_2 + (ulong)x7 * (ulong)x3_2 + (ulong)x6 * (ulong)x6;
			ulong g0 = (ulong)u0 * (ulong)u0;
			ulong num = (ulong)u7 * (ulong)u1_2 + (ulong)u6 * (ulong)u2_2 + (ulong)u5 * (ulong)u3_2 + (ulong)u4 * (ulong)u4;
			ulong h0 = (ulong)s0 * (ulong)s0;
			ulong h = (ulong)s7 * (ulong)s1_2 + (ulong)s6 * (ulong)s2_2 + (ulong)s5 * (ulong)s3_2 + (ulong)s4 * (ulong)s4;
			ulong c = f0 + g0 + h - f;
			uint z2 = (uint)c & 268435455U;
			c >>= 28;
			ulong d = num + h0 - f0 + h;
			uint z3 = (uint)d & 268435455U;
			d >>= 28;
			ulong f2 = (ulong)x3 * (ulong)x0_2;
			ulong f3 = (ulong)x9 * (ulong)x2_2 + (ulong)x8 * (ulong)x3_2 + (ulong)x7 * (ulong)x4_2;
			ulong g = (ulong)u * (ulong)u0_2;
			ulong g2 = (ulong)u7 * (ulong)u2_2 + (ulong)u6 * (ulong)u3_2 + (ulong)u5 * (ulong)u4_2;
			ulong h2 = (ulong)s * (ulong)s0_2;
			ulong h3 = (ulong)s7 * (ulong)s2_2 + (ulong)s6 * (ulong)s3_2 + (ulong)s5 * (ulong)s4_2;
			c += f2 + g + h3 - f3;
			uint z4 = (uint)c & 268435455U;
			c >>= 28;
			d += g2 + h2 - f2 + h3;
			uint z5 = (uint)d & 268435455U;
			d >>= 28;
			ulong f4 = (ulong)x4 * (ulong)x0_2 + (ulong)x3 * (ulong)x3;
			ulong f5 = (ulong)x9 * (ulong)x3_2 + (ulong)x8 * (ulong)x4_2 + (ulong)x7 * (ulong)x7;
			ulong g3 = (ulong)u2 * (ulong)u0_2 + (ulong)u * (ulong)u;
			ulong g4 = (ulong)u7 * (ulong)u3_2 + (ulong)u6 * (ulong)u4_2 + (ulong)u5 * (ulong)u5;
			ulong h4 = (ulong)s2 * (ulong)s0_2 + (ulong)s * (ulong)s;
			ulong h5 = (ulong)s7 * (ulong)s3_2 + (ulong)s6 * (ulong)s4_2 + (ulong)s5 * (ulong)s5;
			c += f4 + g3 + h5 - f5;
			uint z6 = (uint)c & 268435455U;
			c >>= 28;
			d += g4 + h4 - f4 + h5;
			uint z7 = (uint)d & 268435455U;
			d >>= 28;
			ulong f6 = (ulong)x5 * (ulong)x0_2 + (ulong)x4 * (ulong)x1_2;
			ulong f7 = (ulong)x9 * (ulong)x4_2 + (ulong)x8 * (ulong)x5_2;
			ulong g5 = (ulong)u3 * (ulong)u0_2 + (ulong)u2 * (ulong)u1_2;
			ulong g6 = (ulong)u7 * (ulong)u4_2 + (ulong)u6 * (ulong)u5_2;
			ulong h6 = (ulong)s3 * (ulong)s0_2 + (ulong)s2 * (ulong)s1_2;
			ulong h7 = (ulong)s7 * (ulong)s4_2 + (ulong)s6 * (ulong)s5_2;
			c += f6 + g5 + h7 - f7;
			uint z8 = (uint)c & 268435455U;
			c >>= 28;
			d += g6 + h6 - f6 + h7;
			uint z9 = (uint)d & 268435455U;
			d >>= 28;
			ulong f8 = (ulong)x6 * (ulong)x0_2 + (ulong)x5 * (ulong)x1_2 + (ulong)x4 * (ulong)x4;
			ulong f9 = (ulong)x9 * (ulong)x5_2 + (ulong)x8 * (ulong)x8;
			ulong g7 = (ulong)u4 * (ulong)u0_2 + (ulong)u3 * (ulong)u1_2 + (ulong)u2 * (ulong)u2;
			ulong g8 = (ulong)u7 * (ulong)u5_2 + (ulong)u6 * (ulong)u6;
			ulong h8 = (ulong)s4 * (ulong)s0_2 + (ulong)s3 * (ulong)s1_2 + (ulong)s2 * (ulong)s2;
			ulong h9 = (ulong)s7 * (ulong)s5_2 + (ulong)s6 * (ulong)s6;
			c += f8 + g7 + h9 - f9;
			uint z10 = (uint)c & 268435455U;
			c >>= 28;
			d += g8 + h8 - f8 + h9;
			uint z11 = (uint)d & 268435455U;
			d >>= 28;
			ulong f10 = (ulong)x7 * (ulong)x0_2 + (ulong)x6 * (ulong)x1_2 + (ulong)x5 * (ulong)x2_2;
			ulong f11 = (ulong)x9 * (ulong)x6_2;
			ulong g9 = (ulong)u5 * (ulong)u0_2 + (ulong)u4 * (ulong)u1_2 + (ulong)u3 * (ulong)u2_2;
			ulong g10 = (ulong)u7 * (ulong)u6_2;
			ulong h10 = (ulong)s5 * (ulong)s0_2 + (ulong)s4 * (ulong)s1_2 + (ulong)s3 * (ulong)s2_2;
			ulong h11 = (ulong)s7 * (ulong)s6_2;
			c += f10 + g9 + h11 - f11;
			uint z12 = (uint)c & 268435455U;
			c >>= 28;
			d += g10 + h10 - f10 + h11;
			uint z13 = (uint)d & 268435455U;
			d >>= 28;
			ulong f12 = (ulong)x8 * (ulong)x0_2 + (ulong)x7 * (ulong)x1_2 + (ulong)x6 * (ulong)x2_2 + (ulong)x5 * (ulong)x5;
			ulong f13 = (ulong)x9 * (ulong)x9;
			ulong g11 = (ulong)u6 * (ulong)u0_2 + (ulong)u5 * (ulong)u1_2 + (ulong)u4 * (ulong)u2_2 + (ulong)u3 * (ulong)u3;
			ulong g12 = (ulong)u7 * (ulong)u7;
			ulong h12 = (ulong)s6 * (ulong)s0_2 + (ulong)s5 * (ulong)s1_2 + (ulong)s4 * (ulong)s2_2 + (ulong)s3 * (ulong)s3;
			ulong h13 = (ulong)s7 * (ulong)s7;
			c += f12 + g11 + h13 - f13;
			uint z14 = (uint)c & 268435455U;
			c >>= 28;
			d += g12 + h12 - f12 + h13;
			uint z15 = (uint)d & 268435455U;
			d >>= 28;
			ulong f14 = (ulong)x9 * (ulong)x0_2 + (ulong)x8 * (ulong)x1_2 + (ulong)x7 * (ulong)x2_2 + (ulong)x6 * (ulong)x3_2;
			ulong g13 = (ulong)u7 * (ulong)u0_2 + (ulong)u6 * (ulong)u1_2 + (ulong)u5 * (ulong)u2_2 + (ulong)u4 * (ulong)u3_2;
			ulong h14 = (ulong)s7 * (ulong)s0_2 + (ulong)s6 * (ulong)s1_2 + (ulong)s5 * (ulong)s2_2 + (ulong)s4 * (ulong)s3_2;
			c += f14 + g13;
			uint z16 = (uint)c & 268435455U;
			c >>= 28;
			d += h14 - f14;
			uint z17 = (uint)d & 268435455U;
			d >>= 28;
			c += d;
			c += (ulong)z3;
			z3 = ((uint)c & 268435455U);
			c >>= 28;
			d += (ulong)z2;
			z2 = ((uint)d & 268435455U);
			d >>= 28;
			z5 += (uint)c;
			z4 += (uint)d;
			z[0] = z2;
			z[1] = z4;
			z[2] = z6;
			z[3] = z8;
			z[4] = z10;
			z[5] = z12;
			z[6] = z14;
			z[7] = z16;
			z[8] = z3;
			z[9] = z5;
			z[10] = z7;
			z[11] = z9;
			z[12] = z11;
			z[13] = z13;
			z[14] = z15;
			z[15] = z17;
		}

		// Token: 0x060016B7 RID: 5815 RVA: 0x0006F0A1 File Offset: 0x0006D2A1
		public static void Sqr(uint[] x, int n, uint[] z)
		{
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sqr(x, z);
			while (--n > 0)
			{
				global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sqr(z, z);
			}
		}

		// Token: 0x060016B8 RID: 5816 RVA: 0x0006F0BC File Offset: 0x0006D2BC
		public static bool SqrtRatioVar(uint[] u, uint[] v, uint[] z)
		{
			uint[] u3v = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			uint[] u5v3 = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sqr(u, u3v);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(u3v, v, u3v);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sqr(u3v, u5v3);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(u3v, u, u3v);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(u5v3, u, u5v3);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(u5v3, v, u5v3);
			uint[] x = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.PowPm3d4(u5v3, x);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(x, u3v, x);
			uint[] t = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sqr(x, t);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(t, v, t);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sub(u, t, t);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Normalize(t);
			if (global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.IsZeroVar(t))
			{
				global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Copy(x, 0, z, 0);
				return true;
			}
			return false;
		}

		// Token: 0x060016B9 RID: 5817 RVA: 0x0006F150 File Offset: 0x0006D350
		public static void Sub(uint[] x, uint[] y, uint[] z)
		{
			uint num = x[0];
			uint x2 = x[1];
			uint x3 = x[2];
			uint x4 = x[3];
			uint x5 = x[4];
			uint x6 = x[5];
			uint x7 = x[6];
			uint x8 = x[7];
			uint x9 = x[8];
			uint x10 = x[9];
			uint x11 = x[10];
			uint x12 = x[11];
			uint x13 = x[12];
			uint x14 = x[13];
			uint x15 = x[14];
			uint x16 = x[15];
			uint y2 = y[0];
			uint y3 = y[1];
			uint y4 = y[2];
			uint y5 = y[3];
			uint y6 = y[4];
			uint y7 = y[5];
			uint y8 = y[6];
			uint y9 = y[7];
			uint y10 = y[8];
			uint y11 = y[9];
			uint y12 = y[10];
			uint y13 = y[11];
			uint y14 = y[12];
			uint y15 = y[13];
			uint y16 = y[14];
			uint y17 = y[15];
			uint z2 = num + 536870910U - y2;
			uint z3 = x2 + 536870910U - y3;
			uint z4 = x3 + 536870910U - y4;
			uint z5 = x4 + 536870910U - y5;
			uint z6 = x5 + 536870910U - y6;
			uint z7 = x6 + 536870910U - y7;
			uint z8 = x7 + 536870910U - y8;
			uint z9 = x8 + 536870910U - y9;
			uint z10 = x9 + 536870908U - y10;
			uint z11 = x10 + 536870910U - y11;
			uint z12 = x11 + 536870910U - y12;
			uint z13 = x12 + 536870910U - y13;
			uint z14 = x13 + 536870910U - y14;
			uint z15 = x14 + 536870910U - y15;
			uint z16 = x15 + 536870910U - y16;
			uint z17 = x16 + 536870910U - y17;
			z4 += z3 >> 28;
			z3 &= 268435455U;
			z8 += z7 >> 28;
			z7 &= 268435455U;
			z12 += z11 >> 28;
			z11 &= 268435455U;
			z16 += z15 >> 28;
			z15 &= 268435455U;
			z5 += z4 >> 28;
			z4 &= 268435455U;
			z9 += z8 >> 28;
			z8 &= 268435455U;
			z13 += z12 >> 28;
			z12 &= 268435455U;
			z17 += z16 >> 28;
			z16 &= 268435455U;
			uint t = z17 >> 28;
			z17 &= 268435455U;
			z2 += t;
			z10 += t;
			z6 += z5 >> 28;
			z5 &= 268435455U;
			z10 += z9 >> 28;
			z9 &= 268435455U;
			z14 += z13 >> 28;
			z13 &= 268435455U;
			z3 += z2 >> 28;
			z2 &= 268435455U;
			z7 += z6 >> 28;
			z6 &= 268435455U;
			z11 += z10 >> 28;
			z10 &= 268435455U;
			z15 += z14 >> 28;
			z14 &= 268435455U;
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
			z[10] = z12;
			z[11] = z13;
			z[12] = z14;
			z[13] = z15;
			z[14] = z16;
			z[15] = z17;
		}

		// Token: 0x060016BA RID: 5818 RVA: 0x0006F474 File Offset: 0x0006D674
		public static void SubOne(uint[] z)
		{
			uint[] one = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			one[0] = 1U;
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sub(z, one, z);
		}

		// Token: 0x060016BB RID: 5819 RVA: 0x0006F494 File Offset: 0x0006D694
		public static void Zero(uint[] z)
		{
			for (int i = 0; i < 16; i++)
			{
				z[i] = 0U;
			}
		}

		// Token: 0x040009CD RID: 2509
		public const int Size = 16;

		// Token: 0x040009CE RID: 2510
		private const uint M28 = 268435455U;

		// Token: 0x040009CF RID: 2511
		private static readonly uint[] P32 = new uint[]
		{
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			4294967294U,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue
		};
	}
}
