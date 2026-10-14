using System;
using Org.BouncyCastle.Math.EC.Rfc8032;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Math.EC.Rfc7748
{
	// Token: 0x02000222 RID: 546
	public abstract class X448
	{
		// Token: 0x06001686 RID: 5766 RVA: 0x0006CFED File Offset: 0x0006B1ED
		public static bool CalculateAgreement(byte[] k, int kOff, byte[] u, int uOff, byte[] r, int rOff)
		{
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448.ScalarMult(k, kOff, u, uOff, r, rOff);
			return !global::Org.BouncyCastle.Utilities.Arrays.AreAllZeroes(r, rOff, 56);
		}

		// Token: 0x06001687 RID: 5767 RVA: 0x0006D00A File Offset: 0x0006B20A
		private static uint Decode32(byte[] bs, int off)
		{
			return (uint)((int)bs[off] | (int)bs[++off] << 8 | (int)bs[++off] << 16 | (int)bs[++off] << 24);
		}

		// Token: 0x06001688 RID: 5768 RVA: 0x0006D034 File Offset: 0x0006B234
		private static void DecodeScalar(byte[] k, int kOff, uint[] n)
		{
			for (int i = 0; i < 14; i++)
			{
				n[i] = global::Org.BouncyCastle.Math.EC.Rfc7748.X448.Decode32(k, kOff + i * 4);
			}
			n[0] &= 4294967292U;
			n[13] |= 2147483648U;
		}

		// Token: 0x06001689 RID: 5769 RVA: 0x0006D07A File Offset: 0x0006B27A
		public static void GeneratePrivateKey(global::Org.BouncyCastle.Security.SecureRandom random, byte[] k)
		{
			random.NextBytes(k);
			int num = 0;
			k[num] &= 252;
			int num2 = 55;
			k[num2] |= 128;
		}

		// Token: 0x0600168A RID: 5770 RVA: 0x0006D0A6 File Offset: 0x0006B2A6
		public static void GeneratePublicKey(byte[] k, int kOff, byte[] r, int rOff)
		{
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448.ScalarMultBase(k, kOff, r, rOff);
		}

		// Token: 0x0600168B RID: 5771 RVA: 0x0006D0B4 File Offset: 0x0006B2B4
		private static void PointDouble(uint[] x, uint[] z)
		{
			uint[] a = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			uint[] b = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Add(x, z, a);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sub(x, z, b);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sqr(a, a);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sqr(b, b);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(a, b, x);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sub(a, b, a);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(a, 39082U, z);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Add(z, b, z);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(z, a, z);
		}

		// Token: 0x0600168C RID: 5772 RVA: 0x0006D117 File Offset: 0x0006B317
		public static void Precompute()
		{
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.Precompute();
		}

		// Token: 0x0600168D RID: 5773 RVA: 0x0006D120 File Offset: 0x0006B320
		public static void ScalarMult(byte[] k, int kOff, byte[] u, int uOff, byte[] r, int rOff)
		{
			uint[] i = new uint[14];
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448.DecodeScalar(k, kOff, i);
			uint[] x = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Decode(u, uOff, x);
			uint[] x2 = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Copy(x, 0, x2, 0);
			uint[] z2 = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			z2[0] = 1U;
			uint[] x3 = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			x3[0] = 1U;
			uint[] z3 = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			uint[] t = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			uint[] t2 = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			int bit = 447;
			int swap = 1;
			do
			{
				global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Add(x3, z3, t);
				global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sub(x3, z3, x3);
				global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Add(x2, z2, z3);
				global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sub(x2, z2, x2);
				global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(t, x2, t);
				global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(x3, z3, x3);
				global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sqr(z3, z3);
				global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sqr(x2, x2);
				global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sub(z3, x2, t2);
				global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(t2, 39082U, z2);
				global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Add(z2, x2, z2);
				global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(z2, t2, z2);
				global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(x2, z3, x2);
				global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sub(t, x3, z3);
				global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Add(t, x3, x3);
				global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sqr(x3, x3);
				global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sqr(z3, z3);
				global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(z3, x, z3);
				bit--;
				int word = bit >> 5;
				int shift = bit & 31;
				int kt = (int)(i[word] >> shift & 1U);
				swap ^= kt;
				global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.CSwap(swap, x2, x3);
				global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.CSwap(swap, z2, z3);
				swap = kt;
			}
			while (bit >= 2);
			for (int j = 0; j < 2; j++)
			{
				global::Org.BouncyCastle.Math.EC.Rfc7748.X448.PointDouble(x2, z2);
			}
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Inv(z2, z2);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(x2, z2, x2);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Normalize(x2);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Encode(x2, r, rOff);
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x0006D2BC File Offset: 0x0006B4BC
		public static void ScalarMultBase(byte[] k, int kOff, byte[] r, int rOff)
		{
			uint[] x = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			uint[] y = global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Create();
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed448.ScalarMultBaseXY(k, kOff, x, y);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Inv(x, x);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Mul(x, y, x);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Sqr(x, x);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Normalize(x);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field.Encode(x, r, rOff);
		}

		// Token: 0x040009C9 RID: 2505
		public const int PointSize = 56;

		// Token: 0x040009CA RID: 2506
		public const int ScalarSize = 56;

		// Token: 0x040009CB RID: 2507
		private const uint C_A = 156326U;

		// Token: 0x040009CC RID: 2508
		private const uint C_A24 = 39082U;

		// Token: 0x020007CC RID: 1996
		private class F : global::Org.BouncyCastle.Math.EC.Rfc7748.X448Field
		{
		}
	}
}
