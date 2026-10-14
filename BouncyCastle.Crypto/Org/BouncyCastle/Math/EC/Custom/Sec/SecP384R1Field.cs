using System;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x0200026A RID: 618
	internal class SecP384R1Field
	{
		// Token: 0x060019C9 RID: 6601 RVA: 0x0007A232 File Offset: 0x00078432
		public static void Add(uint[] x, uint[] y, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat.Add(12, x, y, z) != 0U || (z[11] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat.Gte(12, z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.P)))
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.AddPInvTo(z);
			}
		}

		// Token: 0x060019CA RID: 6602 RVA: 0x0007A25C File Offset: 0x0007845C
		public static void AddExt(uint[] xx, uint[] yy, uint[] zz)
		{
			if ((global::Org.BouncyCastle.Math.Raw.Nat.Add(24, xx, yy, zz) != 0U || (zz[23] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat.Gte(24, zz, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.PExt))) && global::Org.BouncyCastle.Math.Raw.Nat.AddTo(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.PExtInv.Length, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.PExtInv, zz) != 0U)
			{
				global::Org.BouncyCastle.Math.Raw.Nat.IncAt(24, zz, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.PExtInv.Length);
			}
		}

		// Token: 0x060019CB RID: 6603 RVA: 0x0007A2AF File Offset: 0x000784AF
		public static void AddOne(uint[] x, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat.Inc(12, x, z) != 0U || (z[11] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat.Gte(12, z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.P)))
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.AddPInvTo(z);
			}
		}

		// Token: 0x060019CC RID: 6604 RVA: 0x0007A2D8 File Offset: 0x000784D8
		public static uint[] FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat.FromBigInteger(384, x);
			if (z[11] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat.Gte(12, z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.P))
			{
				global::Org.BouncyCastle.Math.Raw.Nat.SubFrom(12, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.P, z);
			}
			return z;
		}

		// Token: 0x060019CD RID: 6605 RVA: 0x0007A318 File Offset: 0x00078518
		public static void Half(uint[] x, uint[] z)
		{
			if ((x[0] & 1U) == 0U)
			{
				global::Org.BouncyCastle.Math.Raw.Nat.ShiftDownBit(12, x, 0U, z);
				return;
			}
			uint c = global::Org.BouncyCastle.Math.Raw.Nat.Add(12, x, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.P, z);
			global::Org.BouncyCastle.Math.Raw.Nat.ShiftDownBit(12, z, c);
		}

		// Token: 0x060019CE RID: 6606 RVA: 0x0007A351 File Offset: 0x00078551
		public static void Inv(uint[] x, uint[] z)
		{
			global::Org.BouncyCastle.Math.Raw.Mod.CheckedModOddInverse(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.P, x, z);
		}

		// Token: 0x060019CF RID: 6607 RVA: 0x0007A360 File Offset: 0x00078560
		public static int IsZero(uint[] x)
		{
			uint d = 0U;
			for (int i = 0; i < 12; i++)
			{
				d |= x[i];
			}
			d = (d >> 1 | (d & 1U));
			return (int)(d - 1U) >> 31;
		}

		// Token: 0x060019D0 RID: 6608 RVA: 0x0007A390 File Offset: 0x00078590
		public static void Multiply(uint[] x, uint[] y, uint[] z)
		{
			uint[] tt = global::Org.BouncyCastle.Math.Raw.Nat.Create(24);
			global::Org.BouncyCastle.Math.Raw.Nat384.Mul(x, y, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Reduce(tt, z);
		}

		// Token: 0x060019D1 RID: 6609 RVA: 0x0007A3B4 File Offset: 0x000785B4
		public static void Negate(uint[] x, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.IsZero(x) != 0)
			{
				global::Org.BouncyCastle.Math.Raw.Nat.Sub(12, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.P, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.P, z);
				return;
			}
			global::Org.BouncyCastle.Math.Raw.Nat.Sub(12, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.P, x, z);
		}

		// Token: 0x060019D2 RID: 6610 RVA: 0x0007A3E4 File Offset: 0x000785E4
		public static void Random(global::Org.BouncyCastle.Security.SecureRandom r, uint[] z)
		{
			byte[] bb = new byte[48];
			do
			{
				r.NextBytes(bb);
				global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bb, 0, z, 0, 12);
			}
			while (global::Org.BouncyCastle.Math.Raw.Nat.LessThan(12, z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.P) == 0);
		}

		// Token: 0x060019D3 RID: 6611 RVA: 0x0007A41A File Offset: 0x0007861A
		public static void RandomMult(global::Org.BouncyCastle.Security.SecureRandom r, uint[] z)
		{
			do
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Random(r, z);
			}
			while (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.IsZero(z) != 0);
		}

		// Token: 0x060019D4 RID: 6612 RVA: 0x0007A42C File Offset: 0x0007862C
		public static void Reduce(uint[] xx, uint[] z)
		{
			long xx2 = (long)((ulong)xx[16]);
			long xx3 = (long)((ulong)xx[17]);
			long xx4 = (long)((ulong)xx[18]);
			long xx5 = (long)((ulong)xx[19]);
			long xx6 = (long)((ulong)xx[20]);
			long xx7 = (long)((ulong)xx[21]);
			long xx8 = (long)((ulong)xx[22]);
			long xx9 = (long)((ulong)xx[23]);
			long t0 = (long)((ulong)xx[12] + (ulong)xx6 - 1UL);
			long t = (long)((ulong)xx[13] + (ulong)xx8);
			long t2 = (long)((ulong)xx[14] + (ulong)xx8 + (ulong)xx9);
			long t3 = (long)((ulong)xx[15] + (ulong)xx9);
			long t4 = xx3 + xx7;
			long t5 = xx7 - xx9;
			long t6 = xx8 - xx9;
			long t7 = t0 + t5;
			long cc = 0L;
			cc += (long)((ulong)xx[0] + (ulong)t7);
			z[0] = (uint)cc;
			cc >>= 32;
			cc += (long)((ulong)xx[1] + (ulong)xx9 - (ulong)t0 + (ulong)t);
			z[1] = (uint)cc;
			cc >>= 32;
			cc += (long)((ulong)xx[2] - (ulong)xx7 - (ulong)t + (ulong)t2);
			z[2] = (uint)cc;
			cc >>= 32;
			cc += (long)((ulong)xx[3] - (ulong)t2 + (ulong)t3 + (ulong)t7);
			z[3] = (uint)cc;
			cc >>= 32;
			cc += (long)((ulong)xx[4] + (ulong)xx2 + (ulong)xx7 + (ulong)t - (ulong)t3 + (ulong)t7);
			z[4] = (uint)cc;
			cc >>= 32;
			cc += (long)((ulong)xx[5] - (ulong)xx2 + (ulong)t + (ulong)t2 + (ulong)t4);
			z[5] = (uint)cc;
			cc >>= 32;
			cc += (long)((ulong)xx[6] + (ulong)xx4 - (ulong)xx3 + (ulong)t2 + (ulong)t3);
			z[6] = (uint)cc;
			cc >>= 32;
			cc += (long)((ulong)xx[7] + (ulong)xx2 + (ulong)xx5 - (ulong)xx4 + (ulong)t3);
			z[7] = (uint)cc;
			cc >>= 32;
			cc += (long)((ulong)xx[8] + (ulong)xx2 + (ulong)xx3 + (ulong)xx6 - (ulong)xx5);
			z[8] = (uint)cc;
			cc >>= 32;
			cc += (long)((ulong)xx[9] + (ulong)xx4 - (ulong)xx6 + (ulong)t4);
			z[9] = (uint)cc;
			cc >>= 32;
			cc += (long)((ulong)xx[10] + (ulong)xx4 + (ulong)xx5 - (ulong)t5 + (ulong)t6);
			z[10] = (uint)cc;
			cc >>= 32;
			cc += (long)((ulong)xx[11] + (ulong)xx5 + (ulong)xx6 - (ulong)t6);
			z[11] = (uint)cc;
			cc >>= 32;
			cc += 1L;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Reduce32((uint)cc, z);
		}

		// Token: 0x060019D5 RID: 6613 RVA: 0x0007A648 File Offset: 0x00078848
		public static void Reduce32(uint x, uint[] z)
		{
			long cc = 0L;
			if (x != 0U)
			{
				long xx12 = (long)((ulong)x);
				cc += (long)((ulong)z[0] + (ulong)xx12);
				z[0] = (uint)cc;
				cc >>= 32;
				cc += (long)((ulong)z[1] - (ulong)xx12);
				z[1] = (uint)cc;
				cc >>= 32;
				if (cc != 0L)
				{
					cc += (long)((ulong)z[2]);
					z[2] = (uint)cc;
					cc >>= 32;
				}
				cc += (long)((ulong)z[3] + (ulong)xx12);
				z[3] = (uint)cc;
				cc >>= 32;
				cc += (long)((ulong)z[4] + (ulong)xx12);
				z[4] = (uint)cc;
				cc >>= 32;
			}
			if ((cc != 0L && global::Org.BouncyCastle.Math.Raw.Nat.IncAt(12, z, 5) != 0U) || (z[11] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat.Gte(12, z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.P)))
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.AddPInvTo(z);
			}
		}

		// Token: 0x060019D6 RID: 6614 RVA: 0x0007A6E8 File Offset: 0x000788E8
		public static void Square(uint[] x, uint[] z)
		{
			uint[] tt = global::Org.BouncyCastle.Math.Raw.Nat.Create(24);
			global::Org.BouncyCastle.Math.Raw.Nat384.Square(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Reduce(tt, z);
		}

		// Token: 0x060019D7 RID: 6615 RVA: 0x0007A70C File Offset: 0x0007890C
		public static void SquareN(uint[] x, int n, uint[] z)
		{
			uint[] tt = global::Org.BouncyCastle.Math.Raw.Nat.Create(24);
			global::Org.BouncyCastle.Math.Raw.Nat384.Square(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Reduce(tt, z);
			while (--n > 0)
			{
				global::Org.BouncyCastle.Math.Raw.Nat384.Square(z, tt);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Reduce(tt, z);
			}
		}

		// Token: 0x060019D8 RID: 6616 RVA: 0x0007A748 File Offset: 0x00078948
		public static void Subtract(uint[] x, uint[] y, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat.Sub(12, x, y, z) != 0)
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.SubPInvFrom(z);
			}
		}

		// Token: 0x060019D9 RID: 6617 RVA: 0x0007A75C File Offset: 0x0007895C
		public static void SubtractExt(uint[] xx, uint[] yy, uint[] zz)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat.Sub(24, xx, yy, zz) != 0 && global::Org.BouncyCastle.Math.Raw.Nat.SubFrom(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.PExtInv.Length, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.PExtInv, zz) != 0)
			{
				global::Org.BouncyCastle.Math.Raw.Nat.DecAt(24, zz, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.PExtInv.Length);
			}
		}

		// Token: 0x060019DA RID: 6618 RVA: 0x0007A78E File Offset: 0x0007898E
		public static void Twice(uint[] x, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat.ShiftUpBit(12, x, 0U, z) != 0U || (z[11] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat.Gte(12, z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.P)))
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.AddPInvTo(z);
			}
		}

		// Token: 0x060019DB RID: 6619 RVA: 0x0007A7B8 File Offset: 0x000789B8
		private static void AddPInvTo(uint[] z)
		{
			long c = (long)((ulong)z[0] + 1UL);
			z[0] = (uint)c;
			c >>= 32;
			c += (long)((ulong)z[1] - 1UL);
			z[1] = (uint)c;
			c >>= 32;
			if (c != 0L)
			{
				c += (long)((ulong)z[2]);
				z[2] = (uint)c;
				c >>= 32;
			}
			c += (long)((ulong)z[3] + 1UL);
			z[3] = (uint)c;
			c >>= 32;
			c += (long)((ulong)z[4] + 1UL);
			z[4] = (uint)c;
			c >>= 32;
			if (c != 0L)
			{
				global::Org.BouncyCastle.Math.Raw.Nat.IncAt(12, z, 5);
			}
		}

		// Token: 0x060019DC RID: 6620 RVA: 0x0007A834 File Offset: 0x00078A34
		private static void SubPInvFrom(uint[] z)
		{
			long c = (long)((ulong)z[0] - 1UL);
			z[0] = (uint)c;
			c >>= 32;
			c += (long)((ulong)z[1] + 1UL);
			z[1] = (uint)c;
			c >>= 32;
			if (c != 0L)
			{
				c += (long)((ulong)z[2]);
				z[2] = (uint)c;
				c >>= 32;
			}
			c += (long)((ulong)z[3] - 1UL);
			z[3] = (uint)c;
			c >>= 32;
			c += (long)((ulong)z[4] - 1UL);
			z[4] = (uint)c;
			c >>= 32;
			if (c != 0L)
			{
				global::Org.BouncyCastle.Math.Raw.Nat.DecAt(12, z, 5);
			}
		}

		// Token: 0x04000A77 RID: 2679
		internal static readonly uint[] P = new uint[]
		{
			uint.MaxValue,
			0U,
			0U,
			uint.MaxValue,
			4294967294U,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue
		};

		// Token: 0x04000A78 RID: 2680
		private static readonly uint[] PExt = new uint[]
		{
			1U,
			4294967294U,
			0U,
			2U,
			0U,
			4294967294U,
			0U,
			2U,
			1U,
			0U,
			0U,
			0U,
			4294967294U,
			1U,
			0U,
			4294967294U,
			4294967293U,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue
		};

		// Token: 0x04000A79 RID: 2681
		private static readonly uint[] PExtInv = new uint[]
		{
			uint.MaxValue,
			1U,
			uint.MaxValue,
			4294967293U,
			uint.MaxValue,
			1U,
			uint.MaxValue,
			4294967293U,
			4294967294U,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			1U,
			4294967294U,
			uint.MaxValue,
			1U,
			2U
		};

		// Token: 0x04000A7A RID: 2682
		private const uint P11 = 4294967295U;

		// Token: 0x04000A7B RID: 2683
		private const uint PExt23 = 4294967295U;
	}
}
