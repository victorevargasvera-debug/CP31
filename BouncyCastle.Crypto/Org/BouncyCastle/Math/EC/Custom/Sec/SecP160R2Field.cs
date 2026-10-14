using System;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x0200024E RID: 590
	internal class SecP160R2Field
	{
		// Token: 0x060017F0 RID: 6128 RVA: 0x00073120 File Offset: 0x00071320
		public static void Add(uint[] x, uint[] y, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat160.Add(x, y, z) != 0U || (z[4] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat160.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.P)))
			{
				global::Org.BouncyCastle.Math.Raw.Nat.Add33To(5, 21389U, z);
			}
		}

		// Token: 0x060017F1 RID: 6129 RVA: 0x0007314C File Offset: 0x0007134C
		public static void AddExt(uint[] xx, uint[] yy, uint[] zz)
		{
			if ((global::Org.BouncyCastle.Math.Raw.Nat.Add(10, xx, yy, zz) != 0U || (zz[9] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat.Gte(10, zz, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.PExt))) && global::Org.BouncyCastle.Math.Raw.Nat.AddTo(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.PExtInv.Length, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.PExtInv, zz) != 0U)
			{
				global::Org.BouncyCastle.Math.Raw.Nat.IncAt(10, zz, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.PExtInv.Length);
			}
		}

		// Token: 0x060017F2 RID: 6130 RVA: 0x0007319F File Offset: 0x0007139F
		public static void AddOne(uint[] x, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat.Inc(5, x, z) != 0U || (z[4] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat160.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.P)))
			{
				global::Org.BouncyCastle.Math.Raw.Nat.Add33To(5, 21389U, z);
			}
		}

		// Token: 0x060017F3 RID: 6131 RVA: 0x000731CC File Offset: 0x000713CC
		public static uint[] FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat.FromBigInteger(160, x);
			if (z[4] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat160.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.P))
			{
				global::Org.BouncyCastle.Math.Raw.Nat160.SubFrom(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.P, z);
			}
			return z;
		}

		// Token: 0x060017F4 RID: 6132 RVA: 0x00073208 File Offset: 0x00071408
		public static void Half(uint[] x, uint[] z)
		{
			if ((x[0] & 1U) == 0U)
			{
				global::Org.BouncyCastle.Math.Raw.Nat.ShiftDownBit(5, x, 0U, z);
				return;
			}
			uint c = global::Org.BouncyCastle.Math.Raw.Nat160.Add(x, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.P, z);
			global::Org.BouncyCastle.Math.Raw.Nat.ShiftDownBit(5, z, c);
		}

		// Token: 0x060017F5 RID: 6133 RVA: 0x0007323D File Offset: 0x0007143D
		public static void Inv(uint[] x, uint[] z)
		{
			global::Org.BouncyCastle.Math.Raw.Mod.CheckedModOddInverse(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.P, x, z);
		}

		// Token: 0x060017F6 RID: 6134 RVA: 0x0007324C File Offset: 0x0007144C
		public static int IsZero(uint[] x)
		{
			uint d = 0U;
			for (int i = 0; i < 5; i++)
			{
				d |= x[i];
			}
			d = (d >> 1 | (d & 1U));
			return (int)(d - 1U) >> 31;
		}

		// Token: 0x060017F7 RID: 6135 RVA: 0x0007327C File Offset: 0x0007147C
		public static void Multiply(uint[] x, uint[] y, uint[] z)
		{
			uint[] tt = global::Org.BouncyCastle.Math.Raw.Nat160.CreateExt();
			global::Org.BouncyCastle.Math.Raw.Nat160.Mul(x, y, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Reduce(tt, z);
		}

		// Token: 0x060017F8 RID: 6136 RVA: 0x000732A0 File Offset: 0x000714A0
		public static void MultiplyAddToExt(uint[] x, uint[] y, uint[] zz)
		{
			if ((global::Org.BouncyCastle.Math.Raw.Nat160.MulAddTo(x, y, zz) != 0U || (zz[9] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat.Gte(10, zz, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.PExt))) && global::Org.BouncyCastle.Math.Raw.Nat.AddTo(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.PExtInv.Length, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.PExtInv, zz) != 0U)
			{
				global::Org.BouncyCastle.Math.Raw.Nat.IncAt(10, zz, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.PExtInv.Length);
			}
		}

		// Token: 0x060017F9 RID: 6137 RVA: 0x000732F1 File Offset: 0x000714F1
		public static void Negate(uint[] x, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.IsZero(x) != 0)
			{
				global::Org.BouncyCastle.Math.Raw.Nat160.Sub(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.P, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.P, z);
				return;
			}
			global::Org.BouncyCastle.Math.Raw.Nat160.Sub(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.P, x, z);
		}

		// Token: 0x060017FA RID: 6138 RVA: 0x0007331C File Offset: 0x0007151C
		public static void Random(global::Org.BouncyCastle.Security.SecureRandom r, uint[] z)
		{
			byte[] bb = new byte[20];
			do
			{
				r.NextBytes(bb);
				global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bb, 0, z, 0, 5);
			}
			while (global::Org.BouncyCastle.Math.Raw.Nat.LessThan(5, z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.P) == 0);
		}

		// Token: 0x060017FB RID: 6139 RVA: 0x00073350 File Offset: 0x00071550
		public static void RandomMult(global::Org.BouncyCastle.Security.SecureRandom r, uint[] z)
		{
			do
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Random(r, z);
			}
			while (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.IsZero(z) != 0);
		}

		// Token: 0x060017FC RID: 6140 RVA: 0x00073364 File Offset: 0x00071564
		public static void Reduce(uint[] xx, uint[] z)
		{
			ulong cc = global::Org.BouncyCastle.Math.Raw.Nat160.Mul33Add(21389U, xx, 5, xx, 0, z, 0);
			if (global::Org.BouncyCastle.Math.Raw.Nat160.Mul33DWordAdd(21389U, cc, z, 0) != 0U || (z[4] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat160.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.P)))
			{
				global::Org.BouncyCastle.Math.Raw.Nat.Add33To(5, 21389U, z);
			}
		}

		// Token: 0x060017FD RID: 6141 RVA: 0x000733B1 File Offset: 0x000715B1
		public static void Reduce32(uint x, uint[] z)
		{
			if ((x != 0U && global::Org.BouncyCastle.Math.Raw.Nat160.Mul33WordAdd(21389U, x, z, 0) != 0U) || (z[4] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat160.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.P)))
			{
				global::Org.BouncyCastle.Math.Raw.Nat.Add33To(5, 21389U, z);
			}
		}

		// Token: 0x060017FE RID: 6142 RVA: 0x000733E8 File Offset: 0x000715E8
		public static void Square(uint[] x, uint[] z)
		{
			uint[] tt = global::Org.BouncyCastle.Math.Raw.Nat160.CreateExt();
			global::Org.BouncyCastle.Math.Raw.Nat160.Square(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Reduce(tt, z);
		}

		// Token: 0x060017FF RID: 6143 RVA: 0x0007340C File Offset: 0x0007160C
		public static void SquareN(uint[] x, int n, uint[] z)
		{
			uint[] tt = global::Org.BouncyCastle.Math.Raw.Nat160.CreateExt();
			global::Org.BouncyCastle.Math.Raw.Nat160.Square(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Reduce(tt, z);
			while (--n > 0)
			{
				global::Org.BouncyCastle.Math.Raw.Nat160.Square(z, tt);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Reduce(tt, z);
			}
		}

		// Token: 0x06001800 RID: 6144 RVA: 0x00073446 File Offset: 0x00071646
		public static void Subtract(uint[] x, uint[] y, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat160.Sub(x, y, z) != 0)
			{
				global::Org.BouncyCastle.Math.Raw.Nat.Sub33From(5, 21389U, z);
			}
		}

		// Token: 0x06001801 RID: 6145 RVA: 0x0007345F File Offset: 0x0007165F
		public static void SubtractExt(uint[] xx, uint[] yy, uint[] zz)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat.Sub(10, xx, yy, zz) != 0 && global::Org.BouncyCastle.Math.Raw.Nat.SubFrom(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.PExtInv.Length, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.PExtInv, zz) != 0)
			{
				global::Org.BouncyCastle.Math.Raw.Nat.DecAt(10, zz, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.PExtInv.Length);
			}
		}

		// Token: 0x06001802 RID: 6146 RVA: 0x00073491 File Offset: 0x00071691
		public static void Twice(uint[] x, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat.ShiftUpBit(5, x, 0U, z) != 0U || (z[4] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat160.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.P)))
			{
				global::Org.BouncyCastle.Math.Raw.Nat.Add33To(5, 21389U, z);
			}
		}

		// Token: 0x04000A1F RID: 2591
		internal static readonly uint[] P = new uint[]
		{
			4294945907U,
			4294967294U,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue
		};

		// Token: 0x04000A20 RID: 2592
		private static readonly uint[] PExt = new uint[]
		{
			457489321U,
			42778U,
			1U,
			0U,
			0U,
			4294924518U,
			4294967293U,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue
		};

		// Token: 0x04000A21 RID: 2593
		private static readonly uint[] PExtInv = new uint[]
		{
			3837477975U,
			4294924517U,
			4294967294U,
			uint.MaxValue,
			uint.MaxValue,
			42777U,
			2U
		};

		// Token: 0x04000A22 RID: 2594
		private const uint P4 = 4294967295U;

		// Token: 0x04000A23 RID: 2595
		private const uint PExt9 = 4294967295U;

		// Token: 0x04000A24 RID: 2596
		private const uint PInv33 = 21389U;
	}
}
