using System;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Math.Raw
{
	// Token: 0x020001F0 RID: 496
	internal abstract class Mod
	{
		// Token: 0x06001296 RID: 4758 RVA: 0x000540EA File Offset: 0x000522EA
		public static void CheckedModOddInverse(uint[] m, uint[] x, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Mod.ModOddInverse(m, x, z) == 0U)
			{
				throw new global::System.ArithmeticException("Inverse does not exist.");
			}
		}

		// Token: 0x06001297 RID: 4759 RVA: 0x00054101 File Offset: 0x00052301
		public static void CheckedModOddInverseVar(uint[] m, uint[] x, uint[] z)
		{
			if (!global::Org.BouncyCastle.Math.Raw.Mod.ModOddInverseVar(m, x, z))
			{
				throw new global::System.ArithmeticException("Inverse does not exist.");
			}
		}

		// Token: 0x06001298 RID: 4760 RVA: 0x00054118 File Offset: 0x00052318
		public static uint Inverse32(uint d)
		{
			uint x = d * (2U - d * d);
			x *= 2U - d * x;
			x *= 2U - d * x;
			return x * (2U - d * x);
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x00054148 File Offset: 0x00052348
		public static uint ModOddInverse(uint[] m, uint[] x, uint[] z)
		{
			int len32 = m.Length;
			int bits = (len32 << 5) - global::Org.BouncyCastle.Utilities.Integers.NumberOfLeadingZeros((int)m[len32 - 1]);
			int len33 = (bits + 29) / 30;
			int[] t = new int[4];
			int[] D = new int[len33];
			int[] E = new int[len33];
			int[] F = new int[len33];
			int[] G = new int[len33];
			int[] M = new int[len33];
			E[0] = 1;
			global::Org.BouncyCastle.Math.Raw.Mod.Encode30(bits, x, 0, G, 0);
			global::Org.BouncyCastle.Math.Raw.Mod.Encode30(bits, m, 0, M, 0);
			global::System.Array.Copy(M, 0, F, 0, len33);
			int eta = -1;
			int m0Inv32 = (int)global::Org.BouncyCastle.Math.Raw.Mod.Inverse32((uint)M[0]);
			int maxDivsteps = global::Org.BouncyCastle.Math.Raw.Mod.GetMaximumDivsteps(bits);
			for (int divSteps = 0; divSteps < maxDivsteps; divSteps += 30)
			{
				eta = global::Org.BouncyCastle.Math.Raw.Mod.Divsteps30(eta, F[0], G[0], t);
				global::Org.BouncyCastle.Math.Raw.Mod.UpdateDE30(len33, D, E, t, m0Inv32, M);
				global::Org.BouncyCastle.Math.Raw.Mod.UpdateFG30(len33, F, G, t);
			}
			int signF = F[len33 - 1] >> 31;
			global::Org.BouncyCastle.Math.Raw.Mod.CNegate30(len33, signF, F);
			global::Org.BouncyCastle.Math.Raw.Mod.CNormalize30(len33, signF, D, M);
			global::Org.BouncyCastle.Math.Raw.Mod.Decode30(bits, D, 0, z, 0);
			return (uint)(global::Org.BouncyCastle.Math.Raw.Mod.EqualTo(len33, F, 1) & global::Org.BouncyCastle.Math.Raw.Mod.EqualToZero(len33, G));
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x00054258 File Offset: 0x00052458
		public static bool ModOddInverseVar(uint[] m, uint[] x, uint[] z)
		{
			int len32 = m.Length;
			int bits = (len32 << 5) - global::Org.BouncyCastle.Utilities.Integers.NumberOfLeadingZeros((int)m[len32 - 1]);
			int len33 = (bits + 29) / 30;
			int[] t = new int[4];
			int[] D = new int[len33];
			int[] E = new int[len33];
			int[] F = new int[len33];
			int[] G = new int[len33];
			int[] M = new int[len33];
			E[0] = 1;
			global::Org.BouncyCastle.Math.Raw.Mod.Encode30(bits, x, 0, G, 0);
			global::Org.BouncyCastle.Math.Raw.Mod.Encode30(bits, m, 0, M, 0);
			global::System.Array.Copy(M, 0, F, 0, len33);
			int clzG = global::Org.BouncyCastle.Utilities.Integers.NumberOfLeadingZeros(G[len33 - 1] | 1) - (len33 * 30 + 2 - bits);
			int eta = -1 - clzG;
			int lenDE = len33;
			int lenFG = len33;
			int m0Inv32 = (int)global::Org.BouncyCastle.Math.Raw.Mod.Inverse32((uint)M[0]);
			int maxDivsteps = global::Org.BouncyCastle.Math.Raw.Mod.GetMaximumDivsteps(bits);
			int divsteps = 0;
			while (!global::Org.BouncyCastle.Math.Raw.Mod.IsZero(lenFG, G))
			{
				if (divsteps >= maxDivsteps)
				{
					return false;
				}
				divsteps += 30;
				eta = global::Org.BouncyCastle.Math.Raw.Mod.Divsteps30Var(eta, F[0], G[0], t);
				global::Org.BouncyCastle.Math.Raw.Mod.UpdateDE30(lenDE, D, E, t, m0Inv32, M);
				global::Org.BouncyCastle.Math.Raw.Mod.UpdateFG30(lenFG, F, G, t);
				int fn = F[lenFG - 1];
				int gn = G[lenFG - 1];
				if ((lenFG - 2 >> 31 | (fn ^ fn >> 31) | (gn ^ gn >> 31)) == 0)
				{
					F[lenFG - 2] |= fn << 30;
					G[lenFG - 2] |= gn << 30;
					lenFG--;
				}
			}
			int num = F[lenFG - 1] >> 31;
			int signD = D[lenDE - 1] >> 31;
			if (signD < 0)
			{
				signD = global::Org.BouncyCastle.Math.Raw.Mod.Add30(lenDE, D, M);
			}
			if (num < 0)
			{
				signD = global::Org.BouncyCastle.Math.Raw.Mod.Negate30(lenDE, D);
				global::Org.BouncyCastle.Math.Raw.Mod.Negate30(lenFG, F);
			}
			if (!global::Org.BouncyCastle.Math.Raw.Mod.IsOne(lenFG, F))
			{
				return false;
			}
			if (signD < 0)
			{
				signD = global::Org.BouncyCastle.Math.Raw.Mod.Add30(lenDE, D, M);
			}
			global::Org.BouncyCastle.Math.Raw.Mod.Decode30(bits, D, 0, z, 0);
			return true;
		}

		// Token: 0x0600129B RID: 4763 RVA: 0x00054428 File Offset: 0x00052628
		public static uint[] Random(uint[] p)
		{
			int len = p.Length;
			uint[] s = global::Org.BouncyCastle.Math.Raw.Nat.Create(len);
			uint i = p[len - 1];
			i |= i >> 1;
			i |= i >> 2;
			i |= i >> 4;
			i |= i >> 8;
			i |= i >> 16;
			do
			{
				byte[] bytes = new byte[len << 2];
				global::Org.BouncyCastle.Math.Raw.Mod.RandomSource.NextBytes(bytes);
				global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(bytes, 0, s);
				s[len - 1] &= i;
			}
			while (global::Org.BouncyCastle.Math.Raw.Nat.Gte(len, s, p));
			return s;
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x0005449C File Offset: 0x0005269C
		private static int Add30(int len30, int[] D, int[] M)
		{
			int c = 0;
			int last = len30 - 1;
			for (int i = 0; i < last; i++)
			{
				c += D[i] + M[i];
				D[i] = (c & 1073741823);
				c >>= 30;
			}
			c += D[last] + M[last];
			D[last] = c;
			return c >> 30;
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x000544E8 File Offset: 0x000526E8
		private static void CNegate30(int len30, int cond, int[] D)
		{
			int c = 0;
			int last = len30 - 1;
			for (int i = 0; i < last; i++)
			{
				c += (D[i] ^ cond) - cond;
				D[i] = (c & 1073741823);
				c >>= 30;
			}
			c += (D[last] ^ cond) - cond;
			D[last] = c;
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x00054530 File Offset: 0x00052730
		private static void CNormalize30(int len30, int condNegate, int[] D, int[] M)
		{
			int last = len30 - 1;
			int c = 0;
			int condAdd = D[last] >> 31;
			for (int i = 0; i < last; i++)
			{
				int di = D[i] + (M[i] & condAdd);
				di = (di ^ condNegate) - condNegate;
				c += di;
				D[i] = (c & 1073741823);
				c >>= 30;
			}
			int di2 = D[last] + (M[last] & condAdd);
			di2 = (di2 ^ condNegate) - condNegate;
			c += di2;
			D[last] = c;
			int c2 = 0;
			int condAdd2 = D[last] >> 31;
			for (int j = 0; j < last; j++)
			{
				int di3 = D[j] + (M[j] & condAdd2);
				c2 += di3;
				D[j] = (c2 & 1073741823);
				c2 >>= 30;
			}
			int di4 = D[last] + (M[last] & condAdd2);
			c2 += di4;
			D[last] = c2;
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x000545F4 File Offset: 0x000527F4
		private static void Decode30(int bits, int[] x, int xOff, uint[] z, int zOff)
		{
			int avail = 0;
			ulong data = 0UL;
			while (bits > 0)
			{
				while (avail < global::System.Math.Min(32, bits))
				{
					data |= (ulong)((ulong)((long)x[xOff++]) << avail);
					avail += 30;
				}
				z[zOff++] = (uint)data;
				data >>= 32;
				avail -= 32;
				bits -= 32;
			}
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x00054648 File Offset: 0x00052848
		private static int Divsteps30(int eta, int f0, int g0, int[] t)
		{
			int u = 1;
			int v = 0;
			int q = 0;
			int r = 1;
			int f = f0;
			int g = g0;
			for (int i = 0; i < 30; i++)
			{
				int c = eta >> 31;
				int c2 = -(g & 1);
				int x = (f ^ c) - c;
				int y = (u ^ c) - c;
				int z = (v ^ c) - c;
				g += (x & c2);
				q += (y & c2);
				r += (z & c2);
				c &= c2;
				eta = (eta ^ c) - (c + 1);
				f += (g & c);
				u += (q & c);
				v += (r & c);
				g >>= 1;
				u <<= 1;
				v <<= 1;
			}
			t[0] = u;
			t[1] = v;
			t[2] = q;
			t[3] = r;
			return eta;
		}

		// Token: 0x060012A1 RID: 4769 RVA: 0x00054708 File Offset: 0x00052908
		private static int Divsteps30Var(int eta, int f0, int g0, int[] t)
		{
			int u = 1;
			int v = 0;
			int q = 0;
			int r = 1;
			int f = f0;
			int g = g0;
			int i = 30;
			for (;;)
			{
				int zeros = global::Org.BouncyCastle.Utilities.Integers.NumberOfTrailingZeros(g | -1 << i);
				g >>= zeros;
				u <<= zeros;
				v <<= zeros;
				eta -= zeros;
				i -= zeros;
				if (i <= 0)
				{
					break;
				}
				int w;
				if (eta < 0)
				{
					eta = -eta;
					int num = f;
					f = g;
					g = -num;
					int num2 = u;
					u = q;
					q = -num2;
					int num3 = v;
					v = r;
					r = -num3;
					int limit = (eta + 1 > i) ? i : (eta + 1);
					int j = (int)(uint.MaxValue >> 32 - limit & 63U);
					w = (f * g * (f * f - 2) & j);
				}
				else
				{
					int limit = (eta + 1 > i) ? i : (eta + 1);
					int j = (int)(uint.MaxValue >> 32 - limit & 15U);
					w = f + ((f + 1 & 4) << 1);
					w = (-w * g & j);
				}
				g += f * w;
				q += u * w;
				r += v * w;
			}
			t[0] = u;
			t[1] = v;
			t[2] = q;
			t[3] = r;
			return eta;
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x0005481C File Offset: 0x00052A1C
		private static void Encode30(int bits, uint[] x, int xOff, int[] z, int zOff)
		{
			int avail = 0;
			ulong data = 0UL;
			while (bits > 0)
			{
				if (avail < global::System.Math.Min(30, bits))
				{
					data |= ((ulong)x[xOff++] & (ulong)-1) << avail;
					avail += 32;
				}
				z[zOff++] = ((int)data & 1073741823);
				data >>= 30;
				avail -= 30;
				bits -= 30;
			}
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x0005487C File Offset: 0x00052A7C
		private static int EqualTo(int len, int[] x, int y)
		{
			int d = x[0] ^ y;
			for (int i = 1; i < len; i++)
			{
				d |= x[i];
			}
			d = (int)((uint)d >> 1 | (uint)(d & 1));
			return d - 1 >> 31;
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x000548B0 File Offset: 0x00052AB0
		private static int EqualToZero(int len, int[] x)
		{
			int d = 0;
			for (int i = 0; i < len; i++)
			{
				d |= x[i];
			}
			d = (int)((uint)d >> 1 | (uint)(d & 1));
			return d - 1 >> 31;
		}

		// Token: 0x060012A5 RID: 4773 RVA: 0x000548DF File Offset: 0x00052ADF
		private static int GetMaximumDivsteps(int bits)
		{
			return (49 * bits + ((bits < 46) ? 80 : 47)) / 17;
		}

		// Token: 0x060012A6 RID: 4774 RVA: 0x000548F4 File Offset: 0x00052AF4
		private static bool IsOne(int len, int[] x)
		{
			if (x[0] != 1)
			{
				return false;
			}
			for (int i = 1; i < len; i++)
			{
				if (x[i] != 0)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060012A7 RID: 4775 RVA: 0x00054920 File Offset: 0x00052B20
		private static bool IsZero(int len, int[] x)
		{
			if (x[0] != 0)
			{
				return false;
			}
			for (int i = 1; i < len; i++)
			{
				if (x[i] != 0)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060012A8 RID: 4776 RVA: 0x00054948 File Offset: 0x00052B48
		private static int Negate30(int len30, int[] D)
		{
			int c = 0;
			int last = len30 - 1;
			for (int i = 0; i < last; i++)
			{
				c -= D[i];
				D[i] = (c & 1073741823);
				c >>= 30;
			}
			c -= D[last];
			D[last] = c;
			return c >> 30;
		}

		// Token: 0x060012A9 RID: 4777 RVA: 0x0005498C File Offset: 0x00052B8C
		private static void UpdateDE30(int len30, int[] D, int[] E, int[] t, int m0Inv32, int[] M)
		{
			int u = t[0];
			int v = t[1];
			int q = t[2];
			int r = t[3];
			int sd = D[len30 - 1] >> 31;
			int se = E[len30 - 1] >> 31;
			int md = (u & sd) + (v & se);
			int me = (q & sd) + (r & se);
			int mi = M[0];
			int di = D[0];
			int ei = E[0];
			long cd = (long)u * (long)di + (long)v * (long)ei;
			long ce = (long)q * (long)di + (long)r * (long)ei;
			md -= (m0Inv32 * (int)cd + md & 1073741823);
			me -= (m0Inv32 * (int)ce + me & 1073741823);
			cd += (long)mi * (long)md;
			ce += (long)mi * (long)me;
			cd >>= 30;
			ce >>= 30;
			for (int i = 1; i < len30; i++)
			{
				mi = M[i];
				di = D[i];
				ei = E[i];
				cd += (long)u * (long)di + (long)v * (long)ei + (long)mi * (long)md;
				ce += (long)q * (long)di + (long)r * (long)ei + (long)mi * (long)me;
				D[i - 1] = ((int)cd & 1073741823);
				cd >>= 30;
				E[i - 1] = ((int)ce & 1073741823);
				ce >>= 30;
			}
			D[len30 - 1] = (int)cd;
			E[len30 - 1] = (int)ce;
		}

		// Token: 0x060012AA RID: 4778 RVA: 0x00054AE4 File Offset: 0x00052CE4
		private static void UpdateFG30(int len30, int[] F, int[] G, int[] t)
		{
			int u = t[0];
			int v = t[1];
			int q = t[2];
			int r = t[3];
			int fi = F[0];
			int gi = G[0];
			long cf = (long)u * (long)fi + (long)v * (long)gi;
			long cg = (long)q * (long)fi + (long)r * (long)gi;
			cf >>= 30;
			cg >>= 30;
			for (int i = 1; i < len30; i++)
			{
				fi = F[i];
				gi = G[i];
				cf += (long)u * (long)fi + (long)v * (long)gi;
				cg += (long)q * (long)fi + (long)r * (long)gi;
				F[i - 1] = ((int)cf & 1073741823);
				cf >>= 30;
				G[i - 1] = ((int)cg & 1073741823);
				cg >>= 30;
			}
			F[len30 - 1] = (int)cf;
			G[len30 - 1] = (int)cg;
		}

		// Token: 0x0400092C RID: 2348
		private static readonly global::Org.BouncyCastle.Security.SecureRandom RandomSource = new global::Org.BouncyCastle.Security.SecureRandom();

		// Token: 0x0400092D RID: 2349
		private const int M30 = 1073741823;

		// Token: 0x0400092E RID: 2350
		private const ulong M32UL = 4294967295UL;
	}
}
