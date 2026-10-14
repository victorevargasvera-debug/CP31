using System;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Math.EC.Custom.GM
{
	// Token: 0x020002A8 RID: 680
	internal class SM2P256V1Field
	{
		// Token: 0x06001E2D RID: 7725 RVA: 0x0008BEBC File Offset: 0x0008A0BC
		public static void Add(uint[] x, uint[] y, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat256.Add(x, y, z) != 0U || (z[7] >= 4294967294U && global::Org.BouncyCastle.Math.Raw.Nat256.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.P)))
			{
				global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.AddPInvTo(z);
			}
		}

		// Token: 0x06001E2E RID: 7726 RVA: 0x0008BEE2 File Offset: 0x0008A0E2
		public static void AddExt(uint[] xx, uint[] yy, uint[] zz)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat.Add(16, xx, yy, zz) != 0U || (zz[15] >= 4294967294U && global::Org.BouncyCastle.Math.Raw.Nat.Gte(16, zz, global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.PExt)))
			{
				global::Org.BouncyCastle.Math.Raw.Nat.SubFrom(16, global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.PExt, zz);
			}
		}

		// Token: 0x06001E2F RID: 7727 RVA: 0x0008BF15 File Offset: 0x0008A115
		public static void AddOne(uint[] x, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat.Inc(8, x, z) != 0U || (z[7] >= 4294967294U && global::Org.BouncyCastle.Math.Raw.Nat256.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.P)))
			{
				global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.AddPInvTo(z);
			}
		}

		// Token: 0x06001E30 RID: 7728 RVA: 0x0008BF3C File Offset: 0x0008A13C
		public static uint[] FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat.FromBigInteger(256, x);
			if (z[7] >= 4294967294U && global::Org.BouncyCastle.Math.Raw.Nat256.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.P))
			{
				global::Org.BouncyCastle.Math.Raw.Nat256.SubFrom(global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.P, z);
			}
			return z;
		}

		// Token: 0x06001E31 RID: 7729 RVA: 0x0008BF76 File Offset: 0x0008A176
		public static void Inv(uint[] x, uint[] z)
		{
			global::Org.BouncyCastle.Math.Raw.Mod.CheckedModOddInverse(global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.P, x, z);
		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x0008BF84 File Offset: 0x0008A184
		public static void Half(uint[] x, uint[] z)
		{
			if ((x[0] & 1U) == 0U)
			{
				global::Org.BouncyCastle.Math.Raw.Nat.ShiftDownBit(8, x, 0U, z);
				return;
			}
			uint c = global::Org.BouncyCastle.Math.Raw.Nat256.Add(x, global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.P, z);
			global::Org.BouncyCastle.Math.Raw.Nat.ShiftDownBit(8, z, c);
		}

		// Token: 0x06001E33 RID: 7731 RVA: 0x0008BFBC File Offset: 0x0008A1BC
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

		// Token: 0x06001E34 RID: 7732 RVA: 0x0008BFEC File Offset: 0x0008A1EC
		public static void Multiply(uint[] x, uint[] y, uint[] z)
		{
			uint[] tt = global::Org.BouncyCastle.Math.Raw.Nat256.CreateExt();
			global::Org.BouncyCastle.Math.Raw.Nat256.Mul(x, y, tt);
			global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.Reduce(tt, z);
		}

		// Token: 0x06001E35 RID: 7733 RVA: 0x0008C00E File Offset: 0x0008A20E
		public static void MultiplyAddToExt(uint[] x, uint[] y, uint[] zz)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat256.MulAddTo(x, y, zz) != 0U || (zz[15] >= 4294967294U && global::Org.BouncyCastle.Math.Raw.Nat.Gte(16, zz, global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.PExt)))
			{
				global::Org.BouncyCastle.Math.Raw.Nat.SubFrom(16, global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.PExt, zz);
			}
		}

		// Token: 0x06001E36 RID: 7734 RVA: 0x0008C03F File Offset: 0x0008A23F
		public static void Negate(uint[] x, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.IsZero(x) != 0)
			{
				global::Org.BouncyCastle.Math.Raw.Nat256.Sub(global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.P, global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.P, z);
				return;
			}
			global::Org.BouncyCastle.Math.Raw.Nat256.Sub(global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.P, x, z);
		}

		// Token: 0x06001E37 RID: 7735 RVA: 0x0008C068 File Offset: 0x0008A268
		public static void Random(global::Org.BouncyCastle.Security.SecureRandom r, uint[] z)
		{
			byte[] bb = new byte[32];
			do
			{
				r.NextBytes(bb);
				global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bb, 0, z, 0, 8);
			}
			while (global::Org.BouncyCastle.Math.Raw.Nat.LessThan(8, z, global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.P) == 0);
		}

		// Token: 0x06001E38 RID: 7736 RVA: 0x0008C09C File Offset: 0x0008A29C
		public static void RandomMult(global::Org.BouncyCastle.Security.SecureRandom r, uint[] z)
		{
			do
			{
				global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.Random(r, z);
			}
			while (global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.IsZero(z) != 0);
		}

		// Token: 0x06001E39 RID: 7737 RVA: 0x0008C0B0 File Offset: 0x0008A2B0
		public static void Reduce(uint[] xx, uint[] z)
		{
			long xx2 = (long)((ulong)xx[8]);
			long xx3 = (long)((ulong)xx[9]);
			long xx4 = (long)((ulong)xx[10]);
			long xx5 = (long)((ulong)xx[11]);
			long xx6 = (long)((ulong)xx[12]);
			long xx7 = (long)((ulong)xx[13]);
			long xx8 = (long)((ulong)xx[14]);
			long xx9 = (long)((ulong)xx[15]);
			long num = xx2 + xx3;
			long t = xx4 + xx5;
			long t2 = xx6 + xx9;
			long t3 = xx7 + xx8;
			long t4 = t3 + (xx9 << 1);
			long ts = num + t3;
			long tt = t + t2 + ts;
			long cc = 0L;
			cc += (long)((ulong)xx[0] + (ulong)tt + (ulong)xx7 + (ulong)xx8 + (ulong)xx9);
			z[0] = (uint)cc;
			cc >>= 32;
			cc += (long)((ulong)xx[1] + (ulong)tt - (ulong)xx2 + (ulong)xx8 + (ulong)xx9);
			z[1] = (uint)cc;
			cc >>= 32;
			cc += (long)((ulong)xx[2] - (ulong)ts);
			z[2] = (uint)cc;
			cc >>= 32;
			cc += (long)((ulong)xx[3] + (ulong)tt - (ulong)xx3 - (ulong)xx4 + (ulong)xx7);
			z[3] = (uint)cc;
			cc >>= 32;
			cc += (long)((ulong)xx[4] + (ulong)tt - (ulong)t - (ulong)xx2 + (ulong)xx8);
			z[4] = (uint)cc;
			cc >>= 32;
			cc += (long)((ulong)xx[5] + (ulong)t4 + (ulong)xx4);
			z[5] = (uint)cc;
			cc >>= 32;
			cc += (long)((ulong)xx[6] + (ulong)xx5 + (ulong)xx8 + (ulong)xx9);
			z[6] = (uint)cc;
			cc >>= 32;
			cc += (long)((ulong)xx[7] + (ulong)tt + (ulong)t4 + (ulong)xx6);
			z[7] = (uint)cc;
			cc >>= 32;
			global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.Reduce32((uint)cc, z);
		}

		// Token: 0x06001E3A RID: 7738 RVA: 0x0008C220 File Offset: 0x0008A420
		public static void Reduce32(uint x, uint[] z)
		{
			long cc = 0L;
			if (x != 0U)
			{
				long xx8 = (long)((ulong)x);
				cc += (long)((ulong)z[0] + (ulong)xx8);
				z[0] = (uint)cc;
				cc >>= 32;
				if (cc != 0L)
				{
					cc += (long)((ulong)z[1]);
					z[1] = (uint)cc;
					cc >>= 32;
				}
				cc += (long)((ulong)z[2] - (ulong)xx8);
				z[2] = (uint)cc;
				cc >>= 32;
				cc += (long)((ulong)z[3] + (ulong)xx8);
				z[3] = (uint)cc;
				cc >>= 32;
				if (cc != 0L)
				{
					cc += (long)((ulong)z[4]);
					z[4] = (uint)cc;
					cc >>= 32;
					cc += (long)((ulong)z[5]);
					z[5] = (uint)cc;
					cc >>= 32;
					cc += (long)((ulong)z[6]);
					z[6] = (uint)cc;
					cc >>= 32;
				}
				cc += (long)((ulong)z[7] + (ulong)xx8);
				z[7] = (uint)cc;
				cc >>= 32;
			}
			if (cc != 0L || (z[7] >= 4294967294U && global::Org.BouncyCastle.Math.Raw.Nat256.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.P)))
			{
				global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.AddPInvTo(z);
			}
		}

		// Token: 0x06001E3B RID: 7739 RVA: 0x0008C2EC File Offset: 0x0008A4EC
		public static void Square(uint[] x, uint[] z)
		{
			uint[] tt = global::Org.BouncyCastle.Math.Raw.Nat256.CreateExt();
			global::Org.BouncyCastle.Math.Raw.Nat256.Square(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.Reduce(tt, z);
		}

		// Token: 0x06001E3C RID: 7740 RVA: 0x0008C310 File Offset: 0x0008A510
		public static void SquareN(uint[] x, int n, uint[] z)
		{
			uint[] tt = global::Org.BouncyCastle.Math.Raw.Nat256.CreateExt();
			global::Org.BouncyCastle.Math.Raw.Nat256.Square(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.Reduce(tt, z);
			while (--n > 0)
			{
				global::Org.BouncyCastle.Math.Raw.Nat256.Square(z, tt);
				global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.Reduce(tt, z);
			}
		}

		// Token: 0x06001E3D RID: 7741 RVA: 0x0008C34A File Offset: 0x0008A54A
		public static void Subtract(uint[] x, uint[] y, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat256.Sub(x, y, z) != 0)
			{
				global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.SubPInvFrom(z);
			}
		}

		// Token: 0x06001E3E RID: 7742 RVA: 0x0008C35C File Offset: 0x0008A55C
		public static void SubtractExt(uint[] xx, uint[] yy, uint[] zz)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat.Sub(16, xx, yy, zz) != 0)
			{
				global::Org.BouncyCastle.Math.Raw.Nat.AddTo(16, global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.PExt, zz);
			}
		}

		// Token: 0x06001E3F RID: 7743 RVA: 0x0008C378 File Offset: 0x0008A578
		public static void Twice(uint[] x, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat.ShiftUpBit(8, x, 0U, z) != 0U || (z[7] >= 4294967294U && global::Org.BouncyCastle.Math.Raw.Nat256.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.P)))
			{
				global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.AddPInvTo(z);
			}
		}

		// Token: 0x06001E40 RID: 7744 RVA: 0x0008C3A0 File Offset: 0x0008A5A0
		private static void AddPInvTo(uint[] z)
		{
			long c = (long)((ulong)z[0] + 1UL);
			z[0] = (uint)c;
			c >>= 32;
			if (c != 0L)
			{
				c += (long)((ulong)z[1]);
				z[1] = (uint)c;
				c >>= 32;
			}
			c += (long)((ulong)z[2] - 1UL);
			z[2] = (uint)c;
			c >>= 32;
			c += (long)((ulong)z[3] + 1UL);
			z[3] = (uint)c;
			c >>= 32;
			if (c != 0L)
			{
				c += (long)((ulong)z[4]);
				z[4] = (uint)c;
				c >>= 32;
				c += (long)((ulong)z[5]);
				z[5] = (uint)c;
				c >>= 32;
				c += (long)((ulong)z[6]);
				z[6] = (uint)c;
				c >>= 32;
			}
			c += (long)((ulong)z[7] + 1UL);
			z[7] = (uint)c;
		}

		// Token: 0x06001E41 RID: 7745 RVA: 0x0008C440 File Offset: 0x0008A640
		private static void SubPInvFrom(uint[] z)
		{
			long c = (long)((ulong)z[0] - 1UL);
			z[0] = (uint)c;
			c >>= 32;
			if (c != 0L)
			{
				c += (long)((ulong)z[1]);
				z[1] = (uint)c;
				c >>= 32;
			}
			c += (long)((ulong)z[2] + 1UL);
			z[2] = (uint)c;
			c >>= 32;
			c += (long)((ulong)z[3] - 1UL);
			z[3] = (uint)c;
			c >>= 32;
			if (c != 0L)
			{
				c += (long)((ulong)z[4]);
				z[4] = (uint)c;
				c >>= 32;
				c += (long)((ulong)z[5]);
				z[5] = (uint)c;
				c >>= 32;
				c += (long)((ulong)z[6]);
				z[6] = (uint)c;
				c >>= 32;
			}
			c += (long)((ulong)z[7] - 1UL);
			z[7] = (uint)c;
		}

		// Token: 0x04000AF4 RID: 2804
		internal static readonly uint[] P = new uint[]
		{
			uint.MaxValue,
			uint.MaxValue,
			0U,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			4294967294U
		};

		// Token: 0x04000AF5 RID: 2805
		private static readonly uint[] PExt = new uint[]
		{
			1U,
			0U,
			4294967294U,
			1U,
			1U,
			4294967294U,
			0U,
			2U,
			4294967294U,
			4294967293U,
			3U,
			4294967294U,
			uint.MaxValue,
			uint.MaxValue,
			0U,
			4294967294U
		};

		// Token: 0x04000AF6 RID: 2806
		private const uint P7 = 4294967294U;

		// Token: 0x04000AF7 RID: 2807
		private const uint PExt15 = 4294967294U;
	}
}
