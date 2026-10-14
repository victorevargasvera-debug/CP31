using System;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x0200025A RID: 602
	internal class SecP224K1Field
	{
		// Token: 0x060018B8 RID: 6328 RVA: 0x00076004 File Offset: 0x00074204
		public static void Add(uint[] x, uint[] y, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat224.Add(x, y, z) != 0U || (z[6] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat224.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.P)))
			{
				global::Org.BouncyCastle.Math.Raw.Nat.Add33To(7, 6803U, z);
			}
		}

		// Token: 0x060018B9 RID: 6329 RVA: 0x00076030 File Offset: 0x00074230
		public static void AddExt(uint[] xx, uint[] yy, uint[] zz)
		{
			if ((global::Org.BouncyCastle.Math.Raw.Nat.Add(14, xx, yy, zz) != 0U || (zz[13] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat.Gte(14, zz, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.PExt))) && global::Org.BouncyCastle.Math.Raw.Nat.AddTo(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.PExtInv.Length, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.PExtInv, zz) != 0U)
			{
				global::Org.BouncyCastle.Math.Raw.Nat.IncAt(14, zz, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.PExtInv.Length);
			}
		}

		// Token: 0x060018BA RID: 6330 RVA: 0x00076083 File Offset: 0x00074283
		public static void AddOne(uint[] x, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat.Inc(7, x, z) != 0U || (z[6] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat224.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.P)))
			{
				global::Org.BouncyCastle.Math.Raw.Nat.Add33To(7, 6803U, z);
			}
		}

		// Token: 0x060018BB RID: 6331 RVA: 0x000760B0 File Offset: 0x000742B0
		public static uint[] FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat.FromBigInteger(224, x);
			if (z[6] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat224.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.P))
			{
				global::Org.BouncyCastle.Math.Raw.Nat224.SubFrom(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.P, z);
			}
			return z;
		}

		// Token: 0x060018BC RID: 6332 RVA: 0x000760EC File Offset: 0x000742EC
		public static void Half(uint[] x, uint[] z)
		{
			if ((x[0] & 1U) == 0U)
			{
				global::Org.BouncyCastle.Math.Raw.Nat.ShiftDownBit(7, x, 0U, z);
				return;
			}
			uint c = global::Org.BouncyCastle.Math.Raw.Nat224.Add(x, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.P, z);
			global::Org.BouncyCastle.Math.Raw.Nat.ShiftDownBit(7, z, c);
		}

		// Token: 0x060018BD RID: 6333 RVA: 0x00076121 File Offset: 0x00074321
		public static void Inv(uint[] x, uint[] z)
		{
			global::Org.BouncyCastle.Math.Raw.Mod.CheckedModOddInverse(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.P, x, z);
		}

		// Token: 0x060018BE RID: 6334 RVA: 0x00076130 File Offset: 0x00074330
		public static int IsZero(uint[] x)
		{
			uint d = 0U;
			for (int i = 0; i < 7; i++)
			{
				d |= x[i];
			}
			d = (d >> 1 | (d & 1U));
			return (int)(d - 1U) >> 31;
		}

		// Token: 0x060018BF RID: 6335 RVA: 0x00076160 File Offset: 0x00074360
		public static void Multiply(uint[] x, uint[] y, uint[] z)
		{
			uint[] tt = global::Org.BouncyCastle.Math.Raw.Nat224.CreateExt();
			global::Org.BouncyCastle.Math.Raw.Nat224.Mul(x, y, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Reduce(tt, z);
		}

		// Token: 0x060018C0 RID: 6336 RVA: 0x00076184 File Offset: 0x00074384
		public static void MultiplyAddToExt(uint[] x, uint[] y, uint[] zz)
		{
			if ((global::Org.BouncyCastle.Math.Raw.Nat224.MulAddTo(x, y, zz) != 0U || (zz[13] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat.Gte(14, zz, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.PExt))) && global::Org.BouncyCastle.Math.Raw.Nat.AddTo(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.PExtInv.Length, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.PExtInv, zz) != 0U)
			{
				global::Org.BouncyCastle.Math.Raw.Nat.IncAt(14, zz, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.PExtInv.Length);
			}
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x000761D5 File Offset: 0x000743D5
		public static void Negate(uint[] x, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.IsZero(x) != 0)
			{
				global::Org.BouncyCastle.Math.Raw.Nat224.Sub(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.P, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.P, z);
				return;
			}
			global::Org.BouncyCastle.Math.Raw.Nat224.Sub(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.P, x, z);
		}

		// Token: 0x060018C2 RID: 6338 RVA: 0x00076200 File Offset: 0x00074400
		public static void Random(global::Org.BouncyCastle.Security.SecureRandom r, uint[] z)
		{
			byte[] bb = new byte[28];
			do
			{
				r.NextBytes(bb);
				global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bb, 0, z, 0, 7);
			}
			while (global::Org.BouncyCastle.Math.Raw.Nat.LessThan(7, z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.P) == 0);
		}

		// Token: 0x060018C3 RID: 6339 RVA: 0x00076234 File Offset: 0x00074434
		public static void RandomMult(global::Org.BouncyCastle.Security.SecureRandom r, uint[] z)
		{
			do
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Random(r, z);
			}
			while (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.IsZero(z) != 0);
		}

		// Token: 0x060018C4 RID: 6340 RVA: 0x00076248 File Offset: 0x00074448
		public static void Reduce(uint[] xx, uint[] z)
		{
			ulong cc = global::Org.BouncyCastle.Math.Raw.Nat224.Mul33Add(6803U, xx, 7, xx, 0, z, 0);
			if (global::Org.BouncyCastle.Math.Raw.Nat224.Mul33DWordAdd(6803U, cc, z, 0) != 0U || (z[6] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat224.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.P)))
			{
				global::Org.BouncyCastle.Math.Raw.Nat.Add33To(7, 6803U, z);
			}
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x00076295 File Offset: 0x00074495
		public static void Reduce32(uint x, uint[] z)
		{
			if ((x != 0U && global::Org.BouncyCastle.Math.Raw.Nat224.Mul33WordAdd(6803U, x, z, 0) != 0U) || (z[6] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat224.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.P)))
			{
				global::Org.BouncyCastle.Math.Raw.Nat.Add33To(7, 6803U, z);
			}
		}

		// Token: 0x060018C6 RID: 6342 RVA: 0x000762CC File Offset: 0x000744CC
		public static void Square(uint[] x, uint[] z)
		{
			uint[] tt = global::Org.BouncyCastle.Math.Raw.Nat224.CreateExt();
			global::Org.BouncyCastle.Math.Raw.Nat224.Square(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Reduce(tt, z);
		}

		// Token: 0x060018C7 RID: 6343 RVA: 0x000762F0 File Offset: 0x000744F0
		public static void SquareN(uint[] x, int n, uint[] z)
		{
			uint[] tt = global::Org.BouncyCastle.Math.Raw.Nat224.CreateExt();
			global::Org.BouncyCastle.Math.Raw.Nat224.Square(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Reduce(tt, z);
			while (--n > 0)
			{
				global::Org.BouncyCastle.Math.Raw.Nat224.Square(z, tt);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Reduce(tt, z);
			}
		}

		// Token: 0x060018C8 RID: 6344 RVA: 0x0007632A File Offset: 0x0007452A
		public static void Subtract(uint[] x, uint[] y, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat224.Sub(x, y, z) != 0)
			{
				global::Org.BouncyCastle.Math.Raw.Nat.Sub33From(7, 6803U, z);
			}
		}

		// Token: 0x060018C9 RID: 6345 RVA: 0x00076343 File Offset: 0x00074543
		public static void SubtractExt(uint[] xx, uint[] yy, uint[] zz)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat.Sub(14, xx, yy, zz) != 0 && global::Org.BouncyCastle.Math.Raw.Nat.SubFrom(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.PExtInv.Length, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.PExtInv, zz) != 0)
			{
				global::Org.BouncyCastle.Math.Raw.Nat.DecAt(14, zz, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.PExtInv.Length);
			}
		}

		// Token: 0x060018CA RID: 6346 RVA: 0x00076375 File Offset: 0x00074575
		public static void Twice(uint[] x, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat.ShiftUpBit(7, x, 0U, z) != 0U || (z[6] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat224.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.P)))
			{
				global::Org.BouncyCastle.Math.Raw.Nat.Add33To(7, 6803U, z);
			}
		}

		// Token: 0x04000A45 RID: 2629
		internal static readonly uint[] P = new uint[]
		{
			4294960493U,
			4294967294U,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue
		};

		// Token: 0x04000A46 RID: 2630
		private static readonly uint[] PExt = new uint[]
		{
			46280809U,
			13606U,
			1U,
			0U,
			0U,
			0U,
			0U,
			4294953690U,
			4294967293U,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue
		};

		// Token: 0x04000A47 RID: 2631
		private static readonly uint[] PExtInv = new uint[]
		{
			4248686487U,
			4294953689U,
			4294967294U,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			13605U,
			2U
		};

		// Token: 0x04000A48 RID: 2632
		private const uint P6 = 4294967295U;

		// Token: 0x04000A49 RID: 2633
		private const uint PExt13 = 4294967295U;

		// Token: 0x04000A4A RID: 2634
		private const uint PInv33 = 6803U;
	}
}
