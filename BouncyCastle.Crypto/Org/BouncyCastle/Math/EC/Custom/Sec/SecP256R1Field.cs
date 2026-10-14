using System;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x02000266 RID: 614
	internal class SecP256R1Field
	{
		// Token: 0x06001985 RID: 6533 RVA: 0x0007910C File Offset: 0x0007730C
		public static void Add(uint[] x, uint[] y, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat256.Add(x, y, z) != 0U || (z[7] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat256.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.P)))
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.AddPInvTo(z);
			}
		}

		// Token: 0x06001986 RID: 6534 RVA: 0x00079131 File Offset: 0x00077331
		public static void AddExt(uint[] xx, uint[] yy, uint[] zz)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat.Add(16, xx, yy, zz) != 0U || (zz[15] >= 4294967294U && global::Org.BouncyCastle.Math.Raw.Nat.Gte(16, zz, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.PExt)))
			{
				global::Org.BouncyCastle.Math.Raw.Nat.SubFrom(16, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.PExt, zz);
			}
		}

		// Token: 0x06001987 RID: 6535 RVA: 0x00079164 File Offset: 0x00077364
		public static void AddOne(uint[] x, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat.Inc(8, x, z) != 0U || (z[7] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat256.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.P)))
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.AddPInvTo(z);
			}
		}

		// Token: 0x06001988 RID: 6536 RVA: 0x0007918C File Offset: 0x0007738C
		public static uint[] FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat.FromBigInteger(256, x);
			if (z[7] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat256.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.P))
			{
				global::Org.BouncyCastle.Math.Raw.Nat256.SubFrom(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.P, z);
			}
			return z;
		}

		// Token: 0x06001989 RID: 6537 RVA: 0x000791C8 File Offset: 0x000773C8
		public static void Half(uint[] x, uint[] z)
		{
			if ((x[0] & 1U) == 0U)
			{
				global::Org.BouncyCastle.Math.Raw.Nat.ShiftDownBit(8, x, 0U, z);
				return;
			}
			uint c = global::Org.BouncyCastle.Math.Raw.Nat256.Add(x, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.P, z);
			global::Org.BouncyCastle.Math.Raw.Nat.ShiftDownBit(8, z, c);
		}

		// Token: 0x0600198A RID: 6538 RVA: 0x000791FD File Offset: 0x000773FD
		public static void Inv(uint[] x, uint[] z)
		{
			global::Org.BouncyCastle.Math.Raw.Mod.CheckedModOddInverse(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.P, x, z);
		}

		// Token: 0x0600198B RID: 6539 RVA: 0x0007920C File Offset: 0x0007740C
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

		// Token: 0x0600198C RID: 6540 RVA: 0x0007923C File Offset: 0x0007743C
		public static void Multiply(uint[] x, uint[] y, uint[] z)
		{
			uint[] tt = global::Org.BouncyCastle.Math.Raw.Nat256.CreateExt();
			global::Org.BouncyCastle.Math.Raw.Nat256.Mul(x, y, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.Reduce(tt, z);
		}

		// Token: 0x0600198D RID: 6541 RVA: 0x0007925E File Offset: 0x0007745E
		public static void MultiplyAddToExt(uint[] x, uint[] y, uint[] zz)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat256.MulAddTo(x, y, zz) != 0U || (zz[15] >= 4294967294U && global::Org.BouncyCastle.Math.Raw.Nat.Gte(16, zz, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.PExt)))
			{
				global::Org.BouncyCastle.Math.Raw.Nat.SubFrom(16, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.PExt, zz);
			}
		}

		// Token: 0x0600198E RID: 6542 RVA: 0x0007928F File Offset: 0x0007748F
		public static void Negate(uint[] x, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.IsZero(x) != 0)
			{
				global::Org.BouncyCastle.Math.Raw.Nat256.Sub(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.P, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.P, z);
				return;
			}
			global::Org.BouncyCastle.Math.Raw.Nat256.Sub(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.P, x, z);
		}

		// Token: 0x0600198F RID: 6543 RVA: 0x000792B8 File Offset: 0x000774B8
		public static void Random(global::Org.BouncyCastle.Security.SecureRandom r, uint[] z)
		{
			byte[] bb = new byte[32];
			do
			{
				r.NextBytes(bb);
				global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bb, 0, z, 0, 8);
			}
			while (global::Org.BouncyCastle.Math.Raw.Nat.LessThan(8, z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.P) == 0);
		}

		// Token: 0x06001990 RID: 6544 RVA: 0x000792EC File Offset: 0x000774EC
		public static void RandomMult(global::Org.BouncyCastle.Security.SecureRandom r, uint[] z)
		{
			do
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.Random(r, z);
			}
			while (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.IsZero(z) != 0);
		}

		// Token: 0x06001991 RID: 6545 RVA: 0x00079300 File Offset: 0x00077500
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
			xx2 -= 6L;
			long t0 = xx2 + xx3;
			long t = xx3 + xx4;
			long t2 = xx4 + xx5 - xx9;
			long t3 = xx5 + xx6;
			long t4 = xx6 + xx7;
			long t5 = xx7 + xx8;
			long t6 = xx8 + xx9;
			long t7 = t5 - t0;
			long cc = 0L;
			cc += (long)((ulong)xx[0] - (ulong)t3 - (ulong)t7);
			z[0] = (uint)cc;
			cc >>= 32;
			cc += (long)((ulong)xx[1] + (ulong)t - (ulong)t4 - (ulong)t6);
			z[1] = (uint)cc;
			cc >>= 32;
			cc += (long)((ulong)xx[2] + (ulong)t2 - (ulong)t5);
			z[2] = (uint)cc;
			cc >>= 32;
			cc += (long)((ulong)xx[3] + (ulong)((ulong)t3 << 1) + (ulong)t7 - (ulong)t6);
			z[3] = (uint)cc;
			cc >>= 32;
			cc += (long)((ulong)xx[4] + (ulong)((ulong)t4 << 1) + (ulong)xx8 - (ulong)t);
			z[4] = (uint)cc;
			cc >>= 32;
			cc += (long)((ulong)xx[5] + (ulong)((ulong)t5 << 1) - (ulong)t2);
			z[5] = (uint)cc;
			cc >>= 32;
			cc += (long)((ulong)xx[6] + (ulong)((ulong)t6 << 1) + (ulong)t7);
			z[6] = (uint)cc;
			cc >>= 32;
			cc += (long)((ulong)xx[7] + (ulong)((ulong)xx9 << 1) + (ulong)xx2 - (ulong)t2 - (ulong)t4);
			z[7] = (uint)cc;
			cc >>= 32;
			cc += 6L;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.Reduce32((uint)cc, z);
		}

		// Token: 0x06001992 RID: 6546 RVA: 0x00079488 File Offset: 0x00077688
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
					cc += (long)((ulong)z[2]);
					z[2] = (uint)cc;
					cc >>= 32;
				}
				cc += (long)((ulong)z[3] - (ulong)xx8);
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
				}
				cc += (long)((ulong)z[6] - (ulong)xx8);
				z[6] = (uint)cc;
				cc >>= 32;
				cc += (long)((ulong)z[7] + (ulong)xx8);
				z[7] = (uint)cc;
				cc >>= 32;
			}
			if (cc != 0L || (z[7] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat256.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.P)))
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.AddPInvTo(z);
			}
		}

		// Token: 0x06001993 RID: 6547 RVA: 0x00079554 File Offset: 0x00077754
		public static void Square(uint[] x, uint[] z)
		{
			uint[] tt = global::Org.BouncyCastle.Math.Raw.Nat256.CreateExt();
			global::Org.BouncyCastle.Math.Raw.Nat256.Square(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.Reduce(tt, z);
		}

		// Token: 0x06001994 RID: 6548 RVA: 0x00079578 File Offset: 0x00077778
		public static void SquareN(uint[] x, int n, uint[] z)
		{
			uint[] tt = global::Org.BouncyCastle.Math.Raw.Nat256.CreateExt();
			global::Org.BouncyCastle.Math.Raw.Nat256.Square(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.Reduce(tt, z);
			while (--n > 0)
			{
				global::Org.BouncyCastle.Math.Raw.Nat256.Square(z, tt);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.Reduce(tt, z);
			}
		}

		// Token: 0x06001995 RID: 6549 RVA: 0x000795B2 File Offset: 0x000777B2
		public static void Subtract(uint[] x, uint[] y, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat256.Sub(x, y, z) != 0)
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.SubPInvFrom(z);
			}
		}

		// Token: 0x06001996 RID: 6550 RVA: 0x000795C4 File Offset: 0x000777C4
		public static void SubtractExt(uint[] xx, uint[] yy, uint[] zz)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat.Sub(16, xx, yy, zz) != 0)
			{
				global::Org.BouncyCastle.Math.Raw.Nat.AddTo(16, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.PExt, zz);
			}
		}

		// Token: 0x06001997 RID: 6551 RVA: 0x000795E0 File Offset: 0x000777E0
		public static void Twice(uint[] x, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat.ShiftUpBit(8, x, 0U, z) != 0U || (z[7] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat256.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.P)))
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.AddPInvTo(z);
			}
		}

		// Token: 0x06001998 RID: 6552 RVA: 0x00079608 File Offset: 0x00077808
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
				c += (long)((ulong)z[2]);
				z[2] = (uint)c;
				c >>= 32;
			}
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
			}
			c += (long)((ulong)z[6] - 1UL);
			z[6] = (uint)c;
			c >>= 32;
			c += (long)((ulong)z[7] + 1UL);
			z[7] = (uint)c;
		}

		// Token: 0x06001999 RID: 6553 RVA: 0x000796A8 File Offset: 0x000778A8
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
				c += (long)((ulong)z[2]);
				z[2] = (uint)c;
				c >>= 32;
			}
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
			}
			c += (long)((ulong)z[6] + 1UL);
			z[6] = (uint)c;
			c >>= 32;
			c += (long)((ulong)z[7] - 1UL);
			z[7] = (uint)c;
		}

		// Token: 0x04000A6C RID: 2668
		internal static readonly uint[] P = new uint[]
		{
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			0U,
			0U,
			0U,
			1U,
			uint.MaxValue
		};

		// Token: 0x04000A6D RID: 2669
		private static readonly uint[] PExt = new uint[]
		{
			1U,
			0U,
			0U,
			4294967294U,
			uint.MaxValue,
			uint.MaxValue,
			4294967294U,
			1U,
			4294967294U,
			1U,
			4294967294U,
			1U,
			1U,
			4294967294U,
			2U,
			4294967294U
		};

		// Token: 0x04000A6E RID: 2670
		private const uint P7 = 4294967295U;

		// Token: 0x04000A6F RID: 2671
		private const uint PExt15 = 4294967294U;
	}
}
