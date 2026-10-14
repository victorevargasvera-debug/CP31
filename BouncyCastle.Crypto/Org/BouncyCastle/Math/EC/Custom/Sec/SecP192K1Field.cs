using System;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x02000252 RID: 594
	internal class SecP192K1Field
	{
		// Token: 0x06001832 RID: 6194 RVA: 0x00074084 File Offset: 0x00072284
		public static void Add(uint[] x, uint[] y, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat192.Add(x, y, z) != 0U || (z[5] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat192.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.P)))
			{
				global::Org.BouncyCastle.Math.Raw.Nat.Add33To(6, 4553U, z);
			}
		}

		// Token: 0x06001833 RID: 6195 RVA: 0x000740B0 File Offset: 0x000722B0
		public static void AddExt(uint[] xx, uint[] yy, uint[] zz)
		{
			if ((global::Org.BouncyCastle.Math.Raw.Nat.Add(12, xx, yy, zz) != 0U || (zz[11] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat.Gte(12, zz, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.PExt))) && global::Org.BouncyCastle.Math.Raw.Nat.AddTo(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.PExtInv.Length, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.PExtInv, zz) != 0U)
			{
				global::Org.BouncyCastle.Math.Raw.Nat.IncAt(12, zz, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.PExtInv.Length);
			}
		}

		// Token: 0x06001834 RID: 6196 RVA: 0x00074103 File Offset: 0x00072303
		public static void AddOne(uint[] x, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat.Inc(6, x, z) != 0U || (z[5] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat192.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.P)))
			{
				global::Org.BouncyCastle.Math.Raw.Nat.Add33To(6, 4553U, z);
			}
		}

		// Token: 0x06001835 RID: 6197 RVA: 0x00074130 File Offset: 0x00072330
		public static uint[] FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat.FromBigInteger(192, x);
			if (z[5] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat192.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.P))
			{
				global::Org.BouncyCastle.Math.Raw.Nat192.SubFrom(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.P, z);
			}
			return z;
		}

		// Token: 0x06001836 RID: 6198 RVA: 0x0007416C File Offset: 0x0007236C
		public static void Half(uint[] x, uint[] z)
		{
			if ((x[0] & 1U) == 0U)
			{
				global::Org.BouncyCastle.Math.Raw.Nat.ShiftDownBit(6, x, 0U, z);
				return;
			}
			uint c = global::Org.BouncyCastle.Math.Raw.Nat192.Add(x, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.P, z);
			global::Org.BouncyCastle.Math.Raw.Nat.ShiftDownBit(6, z, c);
		}

		// Token: 0x06001837 RID: 6199 RVA: 0x000741A1 File Offset: 0x000723A1
		public static void Inv(uint[] x, uint[] z)
		{
			global::Org.BouncyCastle.Math.Raw.Mod.CheckedModOddInverse(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.P, x, z);
		}

		// Token: 0x06001838 RID: 6200 RVA: 0x000741B0 File Offset: 0x000723B0
		public static int IsZero(uint[] x)
		{
			uint d = 0U;
			for (int i = 0; i < 6; i++)
			{
				d |= x[i];
			}
			d = (d >> 1 | (d & 1U));
			return (int)(d - 1U) >> 31;
		}

		// Token: 0x06001839 RID: 6201 RVA: 0x000741E0 File Offset: 0x000723E0
		public static void Multiply(uint[] x, uint[] y, uint[] z)
		{
			uint[] tt = global::Org.BouncyCastle.Math.Raw.Nat192.CreateExt();
			global::Org.BouncyCastle.Math.Raw.Nat192.Mul(x, y, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.Reduce(tt, z);
		}

		// Token: 0x0600183A RID: 6202 RVA: 0x00074204 File Offset: 0x00072404
		public static void MultiplyAddToExt(uint[] x, uint[] y, uint[] zz)
		{
			if ((global::Org.BouncyCastle.Math.Raw.Nat192.MulAddTo(x, y, zz) != 0U || (zz[11] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat.Gte(12, zz, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.PExt))) && global::Org.BouncyCastle.Math.Raw.Nat.AddTo(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.PExtInv.Length, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.PExtInv, zz) != 0U)
			{
				global::Org.BouncyCastle.Math.Raw.Nat.IncAt(12, zz, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.PExtInv.Length);
			}
		}

		// Token: 0x0600183B RID: 6203 RVA: 0x00074255 File Offset: 0x00072455
		public static void Negate(uint[] x, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.IsZero(x) != 0)
			{
				global::Org.BouncyCastle.Math.Raw.Nat192.Sub(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.P, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.P, z);
				return;
			}
			global::Org.BouncyCastle.Math.Raw.Nat192.Sub(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.P, x, z);
		}

		// Token: 0x0600183C RID: 6204 RVA: 0x00074280 File Offset: 0x00072480
		public static void Random(global::Org.BouncyCastle.Security.SecureRandom r, uint[] z)
		{
			byte[] bb = new byte[24];
			do
			{
				r.NextBytes(bb);
				global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bb, 0, z, 0, 6);
			}
			while (global::Org.BouncyCastle.Math.Raw.Nat.LessThan(6, z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.P) == 0);
		}

		// Token: 0x0600183D RID: 6205 RVA: 0x000742B4 File Offset: 0x000724B4
		public static void RandomMult(global::Org.BouncyCastle.Security.SecureRandom r, uint[] z)
		{
			do
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.Random(r, z);
			}
			while (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.IsZero(z) != 0);
		}

		// Token: 0x0600183E RID: 6206 RVA: 0x000742C8 File Offset: 0x000724C8
		public static void Reduce(uint[] xx, uint[] z)
		{
			ulong cc = global::Org.BouncyCastle.Math.Raw.Nat192.Mul33Add(4553U, xx, 6, xx, 0, z, 0);
			if (global::Org.BouncyCastle.Math.Raw.Nat192.Mul33DWordAdd(4553U, cc, z, 0) != 0U || (z[5] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat192.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.P)))
			{
				global::Org.BouncyCastle.Math.Raw.Nat.Add33To(6, 4553U, z);
			}
		}

		// Token: 0x0600183F RID: 6207 RVA: 0x00074315 File Offset: 0x00072515
		public static void Reduce32(uint x, uint[] z)
		{
			if ((x != 0U && global::Org.BouncyCastle.Math.Raw.Nat192.Mul33WordAdd(4553U, x, z, 0) != 0U) || (z[5] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat192.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.P)))
			{
				global::Org.BouncyCastle.Math.Raw.Nat.Add33To(6, 4553U, z);
			}
		}

		// Token: 0x06001840 RID: 6208 RVA: 0x0007434C File Offset: 0x0007254C
		public static void Square(uint[] x, uint[] z)
		{
			uint[] tt = global::Org.BouncyCastle.Math.Raw.Nat192.CreateExt();
			global::Org.BouncyCastle.Math.Raw.Nat192.Square(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.Reduce(tt, z);
		}

		// Token: 0x06001841 RID: 6209 RVA: 0x00074370 File Offset: 0x00072570
		public static void SquareN(uint[] x, int n, uint[] z)
		{
			uint[] tt = global::Org.BouncyCastle.Math.Raw.Nat192.CreateExt();
			global::Org.BouncyCastle.Math.Raw.Nat192.Square(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.Reduce(tt, z);
			while (--n > 0)
			{
				global::Org.BouncyCastle.Math.Raw.Nat192.Square(z, tt);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.Reduce(tt, z);
			}
		}

		// Token: 0x06001842 RID: 6210 RVA: 0x000743AA File Offset: 0x000725AA
		public static void Subtract(uint[] x, uint[] y, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat192.Sub(x, y, z) != 0)
			{
				global::Org.BouncyCastle.Math.Raw.Nat.Sub33From(6, 4553U, z);
			}
		}

		// Token: 0x06001843 RID: 6211 RVA: 0x000743C3 File Offset: 0x000725C3
		public static void SubtractExt(uint[] xx, uint[] yy, uint[] zz)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat.Sub(12, xx, yy, zz) != 0 && global::Org.BouncyCastle.Math.Raw.Nat.SubFrom(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.PExtInv.Length, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.PExtInv, zz) != 0)
			{
				global::Org.BouncyCastle.Math.Raw.Nat.DecAt(12, zz, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.PExtInv.Length);
			}
		}

		// Token: 0x06001844 RID: 6212 RVA: 0x000743F5 File Offset: 0x000725F5
		public static void Twice(uint[] x, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat.ShiftUpBit(6, x, 0U, z) != 0U || (z[5] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat192.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.P)))
			{
				global::Org.BouncyCastle.Math.Raw.Nat.Add33To(6, 4553U, z);
			}
		}

		// Token: 0x04000A2C RID: 2604
		internal static readonly uint[] P = new uint[]
		{
			4294962743U,
			4294967294U,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue
		};

		// Token: 0x04000A2D RID: 2605
		private static readonly uint[] PExt = new uint[]
		{
			20729809U,
			9106U,
			1U,
			0U,
			0U,
			0U,
			4294958190U,
			4294967293U,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue
		};

		// Token: 0x04000A2E RID: 2606
		private static readonly uint[] PExtInv = new uint[]
		{
			4274237487U,
			4294958189U,
			4294967294U,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			9105U,
			2U
		};

		// Token: 0x04000A2F RID: 2607
		private const uint P5 = 4294967295U;

		// Token: 0x04000A30 RID: 2608
		private const uint PExt11 = 4294967295U;

		// Token: 0x04000A31 RID: 2609
		private const uint PInv33 = 4553U;
	}
}
