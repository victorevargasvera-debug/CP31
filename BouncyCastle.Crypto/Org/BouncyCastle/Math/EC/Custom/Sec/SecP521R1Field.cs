using System;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x0200026E RID: 622
	internal class SecP521R1Field
	{
		// Token: 0x06001A0C RID: 6668 RVA: 0x0007B4A0 File Offset: 0x000796A0
		public static void Add(uint[] x, uint[] y, uint[] z)
		{
			uint c = global::Org.BouncyCastle.Math.Raw.Nat.Add(16, x, y, z) + x[16] + y[16];
			if (c > 511U || (c == 511U && global::Org.BouncyCastle.Math.Raw.Nat.Eq(16, z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.P)))
			{
				c += global::Org.BouncyCastle.Math.Raw.Nat.Inc(16, z);
				c &= 511U;
			}
			z[16] = c;
		}

		// Token: 0x06001A0D RID: 6669 RVA: 0x0007B4FC File Offset: 0x000796FC
		public static void AddOne(uint[] x, uint[] z)
		{
			uint c = global::Org.BouncyCastle.Math.Raw.Nat.Inc(16, x, z) + x[16];
			if (c > 511U || (c == 511U && global::Org.BouncyCastle.Math.Raw.Nat.Eq(16, z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.P)))
			{
				c += global::Org.BouncyCastle.Math.Raw.Nat.Inc(16, z);
				c &= 511U;
			}
			z[16] = c;
		}

		// Token: 0x06001A0E RID: 6670 RVA: 0x0007B550 File Offset: 0x00079750
		public static uint[] FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat.FromBigInteger(521, x);
			if (global::Org.BouncyCastle.Math.Raw.Nat.Eq(17, z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.P))
			{
				global::Org.BouncyCastle.Math.Raw.Nat.Zero(17, z);
			}
			return z;
		}

		// Token: 0x06001A0F RID: 6671 RVA: 0x0007B584 File Offset: 0x00079784
		public static void Half(uint[] x, uint[] z)
		{
			uint x2 = x[16];
			uint c = global::Org.BouncyCastle.Math.Raw.Nat.ShiftDownBit(16, x, x2, z);
			z[16] = (x2 >> 1 | c >> 23);
		}

		// Token: 0x06001A10 RID: 6672 RVA: 0x0007B5AD File Offset: 0x000797AD
		public static void Inv(uint[] x, uint[] z)
		{
			global::Org.BouncyCastle.Math.Raw.Mod.CheckedModOddInverse(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.P, x, z);
		}

		// Token: 0x06001A11 RID: 6673 RVA: 0x0007B5BC File Offset: 0x000797BC
		public static int IsZero(uint[] x)
		{
			uint d = 0U;
			for (int i = 0; i < 17; i++)
			{
				d |= x[i];
			}
			d = (d >> 1 | (d & 1U));
			return (int)(d - 1U) >> 31;
		}

		// Token: 0x06001A12 RID: 6674 RVA: 0x0007B5EC File Offset: 0x000797EC
		public static void Multiply(uint[] x, uint[] y, uint[] z)
		{
			uint[] tt = global::Org.BouncyCastle.Math.Raw.Nat.Create(33);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.ImplMultiply(x, y, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Reduce(tt, z);
		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x0007B610 File Offset: 0x00079810
		public static void Negate(uint[] x, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.IsZero(x) != 0)
			{
				global::Org.BouncyCastle.Math.Raw.Nat.Sub(17, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.P, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.P, z);
				return;
			}
			global::Org.BouncyCastle.Math.Raw.Nat.Sub(17, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.P, x, z);
		}

		// Token: 0x06001A14 RID: 6676 RVA: 0x0007B640 File Offset: 0x00079840
		public static void Random(global::Org.BouncyCastle.Security.SecureRandom r, uint[] z)
		{
			byte[] bb = new byte[68];
			do
			{
				r.NextBytes(bb);
				global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bb, 0, z, 0, 17);
				z[16] &= 511U;
			}
			while (global::Org.BouncyCastle.Math.Raw.Nat.LessThan(17, z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.P) == 0);
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x0007B687 File Offset: 0x00079887
		public static void RandomMult(global::Org.BouncyCastle.Security.SecureRandom r, uint[] z)
		{
			do
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Random(r, z);
			}
			while (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.IsZero(z) != 0);
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x0007B698 File Offset: 0x00079898
		public static void Reduce(uint[] xx, uint[] z)
		{
			uint xx2 = xx[32];
			uint c = global::Org.BouncyCastle.Math.Raw.Nat.ShiftDownBits(16, xx, 16, 9, xx2, z, 0) >> 23;
			c += xx2 >> 9;
			c += global::Org.BouncyCastle.Math.Raw.Nat.AddTo(16, xx, z);
			if (c > 511U || (c == 511U && global::Org.BouncyCastle.Math.Raw.Nat.Eq(16, z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.P)))
			{
				c += global::Org.BouncyCastle.Math.Raw.Nat.Inc(16, z);
				c &= 511U;
			}
			z[16] = c;
		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x0007B708 File Offset: 0x00079908
		public static void Reduce23(uint[] z)
		{
			uint z2 = z[16];
			uint c = global::Org.BouncyCastle.Math.Raw.Nat.AddWordTo(16, z2 >> 9, z) + (z2 & 511U);
			if (c > 511U || (c == 511U && global::Org.BouncyCastle.Math.Raw.Nat.Eq(16, z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.P)))
			{
				c += global::Org.BouncyCastle.Math.Raw.Nat.Inc(16, z);
				c &= 511U;
			}
			z[16] = c;
		}

		// Token: 0x06001A18 RID: 6680 RVA: 0x0007B768 File Offset: 0x00079968
		public static void Square(uint[] x, uint[] z)
		{
			uint[] tt = global::Org.BouncyCastle.Math.Raw.Nat.Create(33);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.ImplSquare(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Reduce(tt, z);
		}

		// Token: 0x06001A19 RID: 6681 RVA: 0x0007B78C File Offset: 0x0007998C
		public static void SquareN(uint[] x, int n, uint[] z)
		{
			uint[] tt = global::Org.BouncyCastle.Math.Raw.Nat.Create(33);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.ImplSquare(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Reduce(tt, z);
			while (--n > 0)
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.ImplSquare(z, tt);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Reduce(tt, z);
			}
		}

		// Token: 0x06001A1A RID: 6682 RVA: 0x0007B7C8 File Offset: 0x000799C8
		public static void Subtract(uint[] x, uint[] y, uint[] z)
		{
			int c = global::Org.BouncyCastle.Math.Raw.Nat.Sub(16, x, y, z) + (int)(x[16] - y[16]);
			if (c < 0)
			{
				c += global::Org.BouncyCastle.Math.Raw.Nat.Dec(16, z);
				c &= 511;
			}
			z[16] = (uint)c;
		}

		// Token: 0x06001A1B RID: 6683 RVA: 0x0007B808 File Offset: 0x00079A08
		public static void Twice(uint[] x, uint[] z)
		{
			uint x2 = x[16];
			uint c = global::Org.BouncyCastle.Math.Raw.Nat.ShiftUpBit(16, x, x2 << 23, z) | x2 << 1;
			z[16] = (c & 511U);
		}

		// Token: 0x06001A1C RID: 6684 RVA: 0x0007B838 File Offset: 0x00079A38
		protected static void ImplMultiply(uint[] x, uint[] y, uint[] zz)
		{
			global::Org.BouncyCastle.Math.Raw.Nat512.Mul(x, y, zz);
			uint x2 = x[16];
			uint y2 = y[16];
			zz[32] = global::Org.BouncyCastle.Math.Raw.Nat.Mul31BothAdd(16, x2, y, y2, x, zz, 16) + x2 * y2;
		}

		// Token: 0x06001A1D RID: 6685 RVA: 0x0007B870 File Offset: 0x00079A70
		protected static void ImplSquare(uint[] x, uint[] zz)
		{
			global::Org.BouncyCastle.Math.Raw.Nat512.Square(x, zz);
			uint x2 = x[16];
			zz[32] = global::Org.BouncyCastle.Math.Raw.Nat.MulWordAddTo(16, x2 << 1, x, 0, zz, 16) + x2 * x2;
		}

		// Token: 0x04000A83 RID: 2691
		internal static readonly uint[] P = new uint[]
		{
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			511U
		};

		// Token: 0x04000A84 RID: 2692
		private const uint P16 = 511U;
	}
}
