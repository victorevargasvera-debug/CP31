using System;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Math.EC.Custom.Djb
{
	// Token: 0x020002AC RID: 684
	internal class Curve25519Field
	{
		// Token: 0x06001E71 RID: 7793 RVA: 0x0008D08A File Offset: 0x0008B28A
		public static void Add(uint[] x, uint[] y, uint[] z)
		{
			global::Org.BouncyCastle.Math.Raw.Nat256.Add(x, y, z);
			if (global::Org.BouncyCastle.Math.Raw.Nat256.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.P))
			{
				global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.SubPFrom(z);
			}
		}

		// Token: 0x06001E72 RID: 7794 RVA: 0x0008D0A9 File Offset: 0x0008B2A9
		public static void AddExt(uint[] xx, uint[] yy, uint[] zz)
		{
			global::Org.BouncyCastle.Math.Raw.Nat.Add(16, xx, yy, zz);
			if (global::Org.BouncyCastle.Math.Raw.Nat.Gte(16, zz, global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.PExt))
			{
				global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.SubPExtFrom(zz);
			}
		}

		// Token: 0x06001E73 RID: 7795 RVA: 0x0008D0CC File Offset: 0x0008B2CC
		public static void AddOne(uint[] x, uint[] z)
		{
			global::Org.BouncyCastle.Math.Raw.Nat.Inc(8, x, z);
			if (global::Org.BouncyCastle.Math.Raw.Nat256.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.P))
			{
				global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.SubPFrom(z);
			}
		}

		// Token: 0x06001E74 RID: 7796 RVA: 0x0008D0EC File Offset: 0x0008B2EC
		public static uint[] FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat.FromBigInteger(256, x);
			while (global::Org.BouncyCastle.Math.Raw.Nat256.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.P))
			{
				global::Org.BouncyCastle.Math.Raw.Nat256.SubFrom(global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.P, z);
			}
			return z;
		}

		// Token: 0x06001E75 RID: 7797 RVA: 0x0008D121 File Offset: 0x0008B321
		public static void Half(uint[] x, uint[] z)
		{
			if ((x[0] & 1U) == 0U)
			{
				global::Org.BouncyCastle.Math.Raw.Nat.ShiftDownBit(8, x, 0U, z);
				return;
			}
			global::Org.BouncyCastle.Math.Raw.Nat256.Add(x, global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.P, z);
			global::Org.BouncyCastle.Math.Raw.Nat.ShiftDownBit(8, z, 0U);
		}

		// Token: 0x06001E76 RID: 7798 RVA: 0x0008D14B File Offset: 0x0008B34B
		public static void Inv(uint[] x, uint[] z)
		{
			global::Org.BouncyCastle.Math.Raw.Mod.CheckedModOddInverse(global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.P, x, z);
		}

		// Token: 0x06001E77 RID: 7799 RVA: 0x0008D15C File Offset: 0x0008B35C
		public static int IsZero(uint[] x)
		{
			uint d = 0U;
			for (int i = 0; i < 8; i++)
			{
				d |= x[i];
			}
			d = (d >> 1 | (d & 1U));
			return (int)(d - 1U) >> 31;
		}

		// Token: 0x06001E78 RID: 7800 RVA: 0x0008D18C File Offset: 0x0008B38C
		public static void Multiply(uint[] x, uint[] y, uint[] z)
		{
			uint[] tt = global::Org.BouncyCastle.Math.Raw.Nat256.CreateExt();
			global::Org.BouncyCastle.Math.Raw.Nat256.Mul(x, y, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Reduce(tt, z);
		}

		// Token: 0x06001E79 RID: 7801 RVA: 0x0008D1AE File Offset: 0x0008B3AE
		public static void MultiplyAddToExt(uint[] x, uint[] y, uint[] zz)
		{
			global::Org.BouncyCastle.Math.Raw.Nat256.MulAddTo(x, y, zz);
			if (global::Org.BouncyCastle.Math.Raw.Nat.Gte(16, zz, global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.PExt))
			{
				global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.SubPExtFrom(zz);
			}
		}

		// Token: 0x06001E7A RID: 7802 RVA: 0x0008D1CF File Offset: 0x0008B3CF
		public static void Negate(uint[] x, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.IsZero(x) != 0)
			{
				global::Org.BouncyCastle.Math.Raw.Nat256.Sub(global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.P, global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.P, z);
				return;
			}
			global::Org.BouncyCastle.Math.Raw.Nat256.Sub(global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.P, x, z);
		}

		// Token: 0x06001E7B RID: 7803 RVA: 0x0008D1F8 File Offset: 0x0008B3F8
		public static void Random(global::Org.BouncyCastle.Security.SecureRandom r, uint[] z)
		{
			byte[] bb = new byte[32];
			do
			{
				r.NextBytes(bb);
				global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bb, 0, z, 0, 8);
				z[7] &= 2147483647U;
			}
			while (global::Org.BouncyCastle.Math.Raw.Nat.LessThan(8, z, global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.P) == 0);
		}

		// Token: 0x06001E7C RID: 7804 RVA: 0x0008D23C File Offset: 0x0008B43C
		public static void RandomMult(global::Org.BouncyCastle.Security.SecureRandom r, uint[] z)
		{
			do
			{
				global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Random(r, z);
			}
			while (global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.IsZero(z) != 0);
		}

		// Token: 0x06001E7D RID: 7805 RVA: 0x0008D250 File Offset: 0x0008B450
		public static void Reduce(uint[] xx, uint[] z)
		{
			uint xx2 = xx[7];
			global::Org.BouncyCastle.Math.Raw.Nat.ShiftUpBit(8, xx, 8, xx2, z, 0);
			uint c = global::Org.BouncyCastle.Math.Raw.Nat256.MulByWordAddTo(19U, xx, z) << 1;
			uint z2 = z[7];
			c += (z2 >> 31) - (xx2 >> 31);
			z2 &= 2147483647U;
			z2 += global::Org.BouncyCastle.Math.Raw.Nat.AddWordTo(7, c * 19U, z);
			z[7] = z2;
			if (z2 >= 2147483647U && global::Org.BouncyCastle.Math.Raw.Nat256.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.P))
			{
				global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.SubPFrom(z);
			}
		}

		// Token: 0x06001E7E RID: 7806 RVA: 0x0008D2C0 File Offset: 0x0008B4C0
		public static void Reduce27(uint x, uint[] z)
		{
			uint z2 = z[7];
			uint c = x << 1 | z2 >> 31;
			z2 &= 2147483647U;
			z2 += global::Org.BouncyCastle.Math.Raw.Nat.AddWordTo(7, c * 19U, z);
			z[7] = z2;
			if (z2 >= 2147483647U && global::Org.BouncyCastle.Math.Raw.Nat256.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.P))
			{
				global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.SubPFrom(z);
			}
		}

		// Token: 0x06001E7F RID: 7807 RVA: 0x0008D310 File Offset: 0x0008B510
		public static void Square(uint[] x, uint[] z)
		{
			uint[] tt = global::Org.BouncyCastle.Math.Raw.Nat256.CreateExt();
			global::Org.BouncyCastle.Math.Raw.Nat256.Square(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Reduce(tt, z);
		}

		// Token: 0x06001E80 RID: 7808 RVA: 0x0008D334 File Offset: 0x0008B534
		public static void SquareN(uint[] x, int n, uint[] z)
		{
			uint[] tt = global::Org.BouncyCastle.Math.Raw.Nat256.CreateExt();
			global::Org.BouncyCastle.Math.Raw.Nat256.Square(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Reduce(tt, z);
			while (--n > 0)
			{
				global::Org.BouncyCastle.Math.Raw.Nat256.Square(z, tt);
				global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Reduce(tt, z);
			}
		}

		// Token: 0x06001E81 RID: 7809 RVA: 0x0008D36E File Offset: 0x0008B56E
		public static void Subtract(uint[] x, uint[] y, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat256.Sub(x, y, z) != 0)
			{
				global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.AddPTo(z);
			}
		}

		// Token: 0x06001E82 RID: 7810 RVA: 0x0008D381 File Offset: 0x0008B581
		public static void SubtractExt(uint[] xx, uint[] yy, uint[] zz)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat.Sub(16, xx, yy, zz) != 0)
			{
				global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.AddPExtTo(zz);
			}
		}

		// Token: 0x06001E83 RID: 7811 RVA: 0x0008D396 File Offset: 0x0008B596
		public static void Twice(uint[] x, uint[] z)
		{
			global::Org.BouncyCastle.Math.Raw.Nat.ShiftUpBit(8, x, 0U, z);
			if (global::Org.BouncyCastle.Math.Raw.Nat256.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.P))
			{
				global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.SubPFrom(z);
			}
		}

		// Token: 0x06001E84 RID: 7812 RVA: 0x0008D3B8 File Offset: 0x0008B5B8
		private static uint AddPTo(uint[] z)
		{
			long c = (long)((ulong)z[0] - 19UL);
			z[0] = (uint)c;
			c >>= 32;
			if (c != 0L)
			{
				c = (long)global::Org.BouncyCastle.Math.Raw.Nat.DecAt(7, z, 1);
			}
			c += (long)((ulong)z[7] + (ulong)int.MinValue);
			z[7] = (uint)c;
			c >>= 32;
			return (uint)c;
		}

		// Token: 0x06001E85 RID: 7813 RVA: 0x0008D400 File Offset: 0x0008B600
		private static uint AddPExtTo(uint[] zz)
		{
			long c = (long)((ulong)zz[0] + (ulong)global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.PExt[0]);
			zz[0] = (uint)c;
			c >>= 32;
			if (c != 0L)
			{
				c = (long)((ulong)global::Org.BouncyCastle.Math.Raw.Nat.IncAt(8, zz, 1));
			}
			c += (long)((ulong)zz[8] - 19UL);
			zz[8] = (uint)c;
			c >>= 32;
			if (c != 0L)
			{
				c = (long)global::Org.BouncyCastle.Math.Raw.Nat.DecAt(15, zz, 9);
			}
			c += (long)((ulong)zz[15] + (ulong)(global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.PExt[15] + 1U));
			zz[15] = (uint)c;
			c >>= 32;
			return (uint)c;
		}

		// Token: 0x06001E86 RID: 7814 RVA: 0x0008D478 File Offset: 0x0008B678
		private static int SubPFrom(uint[] z)
		{
			long c = (long)((ulong)z[0] + 19UL);
			z[0] = (uint)c;
			c >>= 32;
			if (c != 0L)
			{
				c = (long)((ulong)global::Org.BouncyCastle.Math.Raw.Nat.IncAt(7, z, 1));
			}
			c += (long)((ulong)z[7] - (ulong)int.MinValue);
			z[7] = (uint)c;
			c >>= 32;
			return (int)c;
		}

		// Token: 0x06001E87 RID: 7815 RVA: 0x0008D4C0 File Offset: 0x0008B6C0
		private static int SubPExtFrom(uint[] zz)
		{
			long c = (long)((ulong)zz[0] - (ulong)global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.PExt[0]);
			zz[0] = (uint)c;
			c >>= 32;
			if (c != 0L)
			{
				c = (long)global::Org.BouncyCastle.Math.Raw.Nat.DecAt(8, zz, 1);
			}
			c += (long)((ulong)zz[8] + 19UL);
			zz[8] = (uint)c;
			c >>= 32;
			if (c != 0L)
			{
				c = (long)((ulong)global::Org.BouncyCastle.Math.Raw.Nat.IncAt(15, zz, 9));
			}
			c += (long)((ulong)zz[15] - (ulong)(global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.PExt[15] + 1U));
			zz[15] = (uint)c;
			c >>= 32;
			return (int)c;
		}

		// Token: 0x04000B01 RID: 2817
		internal static readonly uint[] P = new uint[]
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

		// Token: 0x04000B02 RID: 2818
		private const uint P7 = 2147483647U;

		// Token: 0x04000B03 RID: 2819
		private static readonly uint[] PExt = new uint[]
		{
			361U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			0U,
			4294967277U,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			1073741823U
		};

		// Token: 0x04000B04 RID: 2820
		private const uint PInv = 19U;
	}
}
