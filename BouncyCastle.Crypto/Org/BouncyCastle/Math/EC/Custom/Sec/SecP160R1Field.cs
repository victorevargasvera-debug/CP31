using System;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x0200024A RID: 586
	internal class SecP160R1Field
	{
		// Token: 0x060017AE RID: 6062 RVA: 0x000721C8 File Offset: 0x000703C8
		public static void Add(uint[] x, uint[] y, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat160.Add(x, y, z) != 0U || (z[4] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat160.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.P)))
			{
				global::Org.BouncyCastle.Math.Raw.Nat.AddWordTo(5, 2147483649U, z);
			}
		}

		// Token: 0x060017AF RID: 6063 RVA: 0x000721F4 File Offset: 0x000703F4
		public static void AddExt(uint[] xx, uint[] yy, uint[] zz)
		{
			if ((global::Org.BouncyCastle.Math.Raw.Nat.Add(10, xx, yy, zz) != 0U || (zz[9] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat.Gte(10, zz, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.PExt))) && global::Org.BouncyCastle.Math.Raw.Nat.AddTo(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.PExtInv.Length, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.PExtInv, zz) != 0U)
			{
				global::Org.BouncyCastle.Math.Raw.Nat.IncAt(10, zz, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.PExtInv.Length);
			}
		}

		// Token: 0x060017B0 RID: 6064 RVA: 0x00072247 File Offset: 0x00070447
		public static void AddOne(uint[] x, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat.Inc(5, x, z) != 0U || (z[4] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat160.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.P)))
			{
				global::Org.BouncyCastle.Math.Raw.Nat.AddWordTo(5, 2147483649U, z);
			}
		}

		// Token: 0x060017B1 RID: 6065 RVA: 0x00072274 File Offset: 0x00070474
		public static uint[] FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat.FromBigInteger(160, x);
			if (z[4] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat160.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.P))
			{
				global::Org.BouncyCastle.Math.Raw.Nat160.SubFrom(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.P, z);
			}
			return z;
		}

		// Token: 0x060017B2 RID: 6066 RVA: 0x000722B0 File Offset: 0x000704B0
		public static void Half(uint[] x, uint[] z)
		{
			if ((x[0] & 1U) == 0U)
			{
				global::Org.BouncyCastle.Math.Raw.Nat.ShiftDownBit(5, x, 0U, z);
				return;
			}
			uint c = global::Org.BouncyCastle.Math.Raw.Nat160.Add(x, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.P, z);
			global::Org.BouncyCastle.Math.Raw.Nat.ShiftDownBit(5, z, c);
		}

		// Token: 0x060017B3 RID: 6067 RVA: 0x000722E5 File Offset: 0x000704E5
		public static void Inv(uint[] x, uint[] z)
		{
			global::Org.BouncyCastle.Math.Raw.Mod.CheckedModOddInverse(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.P, x, z);
		}

		// Token: 0x060017B4 RID: 6068 RVA: 0x000722F4 File Offset: 0x000704F4
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

		// Token: 0x060017B5 RID: 6069 RVA: 0x00072324 File Offset: 0x00070524
		public static void Multiply(uint[] x, uint[] y, uint[] z)
		{
			uint[] tt = global::Org.BouncyCastle.Math.Raw.Nat160.CreateExt();
			global::Org.BouncyCastle.Math.Raw.Nat160.Mul(x, y, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.Reduce(tt, z);
		}

		// Token: 0x060017B6 RID: 6070 RVA: 0x00072348 File Offset: 0x00070548
		public static void MultiplyAddToExt(uint[] x, uint[] y, uint[] zz)
		{
			if ((global::Org.BouncyCastle.Math.Raw.Nat160.MulAddTo(x, y, zz) != 0U || (zz[9] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat.Gte(10, zz, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.PExt))) && global::Org.BouncyCastle.Math.Raw.Nat.AddTo(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.PExtInv.Length, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.PExtInv, zz) != 0U)
			{
				global::Org.BouncyCastle.Math.Raw.Nat.IncAt(10, zz, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.PExtInv.Length);
			}
		}

		// Token: 0x060017B7 RID: 6071 RVA: 0x00072399 File Offset: 0x00070599
		public static void Negate(uint[] x, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.IsZero(x) != 0)
			{
				global::Org.BouncyCastle.Math.Raw.Nat160.Sub(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.P, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.P, z);
				return;
			}
			global::Org.BouncyCastle.Math.Raw.Nat160.Sub(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.P, x, z);
		}

		// Token: 0x060017B8 RID: 6072 RVA: 0x000723C4 File Offset: 0x000705C4
		public static void Random(global::Org.BouncyCastle.Security.SecureRandom r, uint[] z)
		{
			byte[] bb = new byte[20];
			do
			{
				r.NextBytes(bb);
				global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bb, 0, z, 0, 5);
			}
			while (global::Org.BouncyCastle.Math.Raw.Nat.LessThan(5, z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.P) == 0);
		}

		// Token: 0x060017B9 RID: 6073 RVA: 0x000723F8 File Offset: 0x000705F8
		public static void RandomMult(global::Org.BouncyCastle.Security.SecureRandom r, uint[] z)
		{
			do
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.Random(r, z);
			}
			while (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.IsZero(z) != 0);
		}

		// Token: 0x060017BA RID: 6074 RVA: 0x0007240C File Offset: 0x0007060C
		public static void Reduce(uint[] xx, uint[] z)
		{
			ulong x5 = (ulong)xx[5];
			ulong x6 = (ulong)xx[6];
			ulong x7 = (ulong)xx[7];
			ulong x8 = (ulong)xx[8];
			ulong x9 = (ulong)xx[9];
			ulong c = 0UL;
			c += (ulong)xx[0] + x5 + (x5 << 31);
			z[0] = (uint)c;
			c >>= 32;
			c += (ulong)xx[1] + x6 + (x6 << 31);
			z[1] = (uint)c;
			c >>= 32;
			c += (ulong)xx[2] + x7 + (x7 << 31);
			z[2] = (uint)c;
			c >>= 32;
			c += (ulong)xx[3] + x8 + (x8 << 31);
			z[3] = (uint)c;
			c >>= 32;
			c += (ulong)xx[4] + x9 + (x9 << 31);
			z[4] = (uint)c;
			c >>= 32;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.Reduce32((uint)c, z);
		}

		// Token: 0x060017BB RID: 6075 RVA: 0x000724D4 File Offset: 0x000706D4
		public static void Reduce32(uint x, uint[] z)
		{
			if ((x != 0U && global::Org.BouncyCastle.Math.Raw.Nat160.MulWordsAdd(2147483649U, x, z, 0) != 0U) || (z[4] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat160.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.P)))
			{
				global::Org.BouncyCastle.Math.Raw.Nat.AddWordTo(5, 2147483649U, z);
			}
		}

		// Token: 0x060017BC RID: 6076 RVA: 0x00072508 File Offset: 0x00070708
		public static void Square(uint[] x, uint[] z)
		{
			uint[] tt = global::Org.BouncyCastle.Math.Raw.Nat160.CreateExt();
			global::Org.BouncyCastle.Math.Raw.Nat160.Square(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.Reduce(tt, z);
		}

		// Token: 0x060017BD RID: 6077 RVA: 0x0007252C File Offset: 0x0007072C
		public static void SquareN(uint[] x, int n, uint[] z)
		{
			uint[] tt = global::Org.BouncyCastle.Math.Raw.Nat160.CreateExt();
			global::Org.BouncyCastle.Math.Raw.Nat160.Square(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.Reduce(tt, z);
			while (--n > 0)
			{
				global::Org.BouncyCastle.Math.Raw.Nat160.Square(z, tt);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.Reduce(tt, z);
			}
		}

		// Token: 0x060017BE RID: 6078 RVA: 0x00072566 File Offset: 0x00070766
		public static void Subtract(uint[] x, uint[] y, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat160.Sub(x, y, z) != 0)
			{
				global::Org.BouncyCastle.Math.Raw.Nat.SubWordFrom(5, 2147483649U, z);
			}
		}

		// Token: 0x060017BF RID: 6079 RVA: 0x0007257F File Offset: 0x0007077F
		public static void SubtractExt(uint[] xx, uint[] yy, uint[] zz)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat.Sub(10, xx, yy, zz) != 0 && global::Org.BouncyCastle.Math.Raw.Nat.SubFrom(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.PExtInv.Length, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.PExtInv, zz) != 0)
			{
				global::Org.BouncyCastle.Math.Raw.Nat.DecAt(10, zz, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.PExtInv.Length);
			}
		}

		// Token: 0x060017C0 RID: 6080 RVA: 0x000725B1 File Offset: 0x000707B1
		public static void Twice(uint[] x, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat.ShiftUpBit(5, x, 0U, z) != 0U || (z[4] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat160.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.P)))
			{
				global::Org.BouncyCastle.Math.Raw.Nat.AddWordTo(5, 2147483649U, z);
			}
		}

		// Token: 0x04000A12 RID: 2578
		internal static readonly uint[] P = new uint[]
		{
			2147483647U,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue
		};

		// Token: 0x04000A13 RID: 2579
		private static readonly uint[] PExt = new uint[]
		{
			1U,
			1073741825U,
			0U,
			0U,
			0U,
			4294967294U,
			4294967294U,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue
		};

		// Token: 0x04000A14 RID: 2580
		private static readonly uint[] PExtInv = new uint[]
		{
			uint.MaxValue,
			3221225470U,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			1U,
			1U
		};

		// Token: 0x04000A15 RID: 2581
		private const uint P4 = 4294967295U;

		// Token: 0x04000A16 RID: 2582
		private const uint PExt9 = 4294967295U;

		// Token: 0x04000A17 RID: 2583
		private const uint PInv = 2147483649U;
	}
}
