using System;
using Org.BouncyCastle.Math.EC.Rfc8032;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Math.EC.Rfc7748
{
	// Token: 0x02000220 RID: 544
	public abstract class X25519
	{
		// Token: 0x06001650 RID: 5712 RVA: 0x0006B809 File Offset: 0x00069A09
		public static bool CalculateAgreement(byte[] k, int kOff, byte[] u, int uOff, byte[] r, int rOff)
		{
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519.ScalarMult(k, kOff, u, uOff, r, rOff);
			return !global::Org.BouncyCastle.Utilities.Arrays.AreAllZeroes(r, rOff, 32);
		}

		// Token: 0x06001651 RID: 5713 RVA: 0x0006B826 File Offset: 0x00069A26
		private static uint Decode32(byte[] bs, int off)
		{
			return (uint)((int)bs[off] | (int)bs[++off] << 8 | (int)bs[++off] << 16 | (int)bs[++off] << 24);
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x0006B850 File Offset: 0x00069A50
		private static void DecodeScalar(byte[] k, int kOff, uint[] n)
		{
			for (int i = 0; i < 8; i++)
			{
				n[i] = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519.Decode32(k, kOff + i * 4);
			}
			n[0] &= 4294967288U;
			n[7] &= 2147483647U;
			n[7] |= 1073741824U;
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x0006B8A4 File Offset: 0x00069AA4
		public static void GeneratePrivateKey(global::Org.BouncyCastle.Security.SecureRandom random, byte[] k)
		{
			random.NextBytes(k);
			int num = 0;
			k[num] &= 248;
			int num2 = 31;
			k[num2] &= 127;
			int num3 = 31;
			k[num3] |= 64;
		}

		// Token: 0x06001654 RID: 5716 RVA: 0x0006B8DC File Offset: 0x00069ADC
		public static void GeneratePublicKey(byte[] k, int kOff, byte[] r, int rOff)
		{
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519.ScalarMultBase(k, kOff, r, rOff);
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x0006B8E8 File Offset: 0x00069AE8
		private static void PointDouble(int[] x, int[] z)
		{
			int[] a = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] b = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Apm(x, z, a, b);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Sqr(a, a);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Sqr(b, b);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(a, b, x);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Sub(a, b, a);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(a, 121666, z);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Add(z, b, z);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(z, a, z);
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x0006B944 File Offset: 0x00069B44
		public static void Precompute()
		{
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.Precompute();
		}

		// Token: 0x06001657 RID: 5719 RVA: 0x0006B94C File Offset: 0x00069B4C
		public static void ScalarMult(byte[] k, int kOff, byte[] u, int uOff, byte[] r, int rOff)
		{
			uint[] i = new uint[8];
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519.DecodeScalar(k, kOff, i);
			int[] x = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Decode(u, uOff, x);
			int[] x2 = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Copy(x, 0, x2, 0);
			int[] z2 = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			z2[0] = 1;
			int[] x3 = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			x3[0] = 1;
			int[] z3 = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] t = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] t2 = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int bit = 254;
			int swap = 1;
			do
			{
				global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Apm(x3, z3, t, x3);
				global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Apm(x2, z2, z3, x2);
				global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(t, x2, t);
				global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(x3, z3, x3);
				global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Sqr(z3, z3);
				global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Sqr(x2, x2);
				global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Sub(z3, x2, t2);
				global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(t2, 121666, z2);
				global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Add(z2, x2, z2);
				global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(z2, t2, z2);
				global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(x2, z3, x2);
				global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Apm(t, x3, x3, z3);
				global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Sqr(x3, x3);
				global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Sqr(z3, z3);
				global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(z3, x, z3);
				bit--;
				int word = bit >> 5;
				int shift = bit & 31;
				int kt = (int)(i[word] >> shift & 1U);
				swap ^= kt;
				global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.CSwap(swap, x2, x3);
				global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.CSwap(swap, z2, z3);
				swap = kt;
			}
			while (bit >= 3);
			for (int j = 0; j < 3; j++)
			{
				global::Org.BouncyCastle.Math.EC.Rfc7748.X25519.PointDouble(x2, z2);
			}
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Inv(z2, z2);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(x2, z2, x2);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Normalize(x2);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Encode(x2, r, rOff);
		}

		// Token: 0x06001658 RID: 5720 RVA: 0x0006BAD0 File Offset: 0x00069CD0
		public static void ScalarMultBase(byte[] k, int kOff, byte[] r, int rOff)
		{
			int[] y = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			int[] z = global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Create();
			global::Org.BouncyCastle.Math.EC.Rfc8032.Ed25519.ScalarMultBaseYZ(k, kOff, y, z);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Apm(z, y, y, z);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Inv(z, z);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Mul(y, z, y);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Normalize(y);
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field.Encode(y, r, rOff);
		}

		// Token: 0x040009BF RID: 2495
		public const int PointSize = 32;

		// Token: 0x040009C0 RID: 2496
		public const int ScalarSize = 32;

		// Token: 0x040009C1 RID: 2497
		private const int C_A = 486662;

		// Token: 0x040009C2 RID: 2498
		private const int C_A24 = 121666;

		// Token: 0x020007CB RID: 1995
		private class F : global::Org.BouncyCastle.Math.EC.Rfc7748.X25519Field
		{
		}
	}
}
