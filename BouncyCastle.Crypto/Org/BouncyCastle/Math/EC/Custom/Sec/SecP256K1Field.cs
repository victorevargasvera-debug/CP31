using System;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x02000262 RID: 610
	internal class SecP256K1Field
	{
		// Token: 0x06001943 RID: 6467 RVA: 0x000781E4 File Offset: 0x000763E4
		public static void Add(uint[] x, uint[] y, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat256.Add(x, y, z) != 0U || (z[7] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat256.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.P)))
			{
				global::Org.BouncyCastle.Math.Raw.Nat.Add33To(8, 977U, z);
			}
		}

		// Token: 0x06001944 RID: 6468 RVA: 0x00078210 File Offset: 0x00076410
		public static void AddExt(uint[] xx, uint[] yy, uint[] zz)
		{
			if ((global::Org.BouncyCastle.Math.Raw.Nat.Add(16, xx, yy, zz) != 0U || (zz[15] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat.Gte(16, zz, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.PExt))) && global::Org.BouncyCastle.Math.Raw.Nat.AddTo(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.PExtInv.Length, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.PExtInv, zz) != 0U)
			{
				global::Org.BouncyCastle.Math.Raw.Nat.IncAt(16, zz, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.PExtInv.Length);
			}
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x00078263 File Offset: 0x00076463
		public static void AddOne(uint[] x, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat.Inc(8, x, z) != 0U || (z[7] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat256.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.P)))
			{
				global::Org.BouncyCastle.Math.Raw.Nat.Add33To(8, 977U, z);
			}
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x00078290 File Offset: 0x00076490
		public static uint[] FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat.FromBigInteger(256, x);
			if (z[7] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat256.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.P))
			{
				global::Org.BouncyCastle.Math.Raw.Nat256.SubFrom(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.P, z);
			}
			return z;
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x000782CC File Offset: 0x000764CC
		public static void Half(uint[] x, uint[] z)
		{
			if ((x[0] & 1U) == 0U)
			{
				global::Org.BouncyCastle.Math.Raw.Nat.ShiftDownBit(8, x, 0U, z);
				return;
			}
			uint c = global::Org.BouncyCastle.Math.Raw.Nat256.Add(x, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.P, z);
			global::Org.BouncyCastle.Math.Raw.Nat.ShiftDownBit(8, z, c);
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x00078301 File Offset: 0x00076501
		public static void Inv(uint[] x, uint[] z)
		{
			global::Org.BouncyCastle.Math.Raw.Mod.CheckedModOddInverse(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.P, x, z);
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x00078310 File Offset: 0x00076510
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

		// Token: 0x0600194A RID: 6474 RVA: 0x00078340 File Offset: 0x00076540
		public static void Multiply(uint[] x, uint[] y, uint[] z)
		{
			uint[] tt = global::Org.BouncyCastle.Math.Raw.Nat256.CreateExt();
			global::Org.BouncyCastle.Math.Raw.Nat256.Mul(x, y, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Reduce(tt, z);
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x00078364 File Offset: 0x00076564
		public static void MultiplyAddToExt(uint[] x, uint[] y, uint[] zz)
		{
			if ((global::Org.BouncyCastle.Math.Raw.Nat256.MulAddTo(x, y, zz) != 0U || (zz[15] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat.Gte(16, zz, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.PExt))) && global::Org.BouncyCastle.Math.Raw.Nat.AddTo(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.PExtInv.Length, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.PExtInv, zz) != 0U)
			{
				global::Org.BouncyCastle.Math.Raw.Nat.IncAt(16, zz, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.PExtInv.Length);
			}
		}

		// Token: 0x0600194C RID: 6476 RVA: 0x000783B5 File Offset: 0x000765B5
		public static void Negate(uint[] x, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.IsZero(x) != 0)
			{
				global::Org.BouncyCastle.Math.Raw.Nat256.Sub(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.P, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.P, z);
				return;
			}
			global::Org.BouncyCastle.Math.Raw.Nat256.Sub(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.P, x, z);
		}

		// Token: 0x0600194D RID: 6477 RVA: 0x000783E0 File Offset: 0x000765E0
		public static void Random(global::Org.BouncyCastle.Security.SecureRandom r, uint[] z)
		{
			byte[] bb = new byte[32];
			do
			{
				r.NextBytes(bb);
				global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bb, 0, z, 0, 8);
			}
			while (global::Org.BouncyCastle.Math.Raw.Nat.LessThan(8, z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.P) == 0);
		}

		// Token: 0x0600194E RID: 6478 RVA: 0x00078414 File Offset: 0x00076614
		public static void RandomMult(global::Org.BouncyCastle.Security.SecureRandom r, uint[] z)
		{
			do
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Random(r, z);
			}
			while (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.IsZero(z) != 0);
		}

		// Token: 0x0600194F RID: 6479 RVA: 0x00078428 File Offset: 0x00076628
		public static void Reduce(uint[] xx, uint[] z)
		{
			ulong cc = global::Org.BouncyCastle.Math.Raw.Nat256.Mul33Add(977U, xx, 8, xx, 0, z, 0);
			if (global::Org.BouncyCastle.Math.Raw.Nat256.Mul33DWordAdd(977U, cc, z, 0) != 0U || (z[7] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat256.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.P)))
			{
				global::Org.BouncyCastle.Math.Raw.Nat.Add33To(8, 977U, z);
			}
		}

		// Token: 0x06001950 RID: 6480 RVA: 0x00078475 File Offset: 0x00076675
		public static void Reduce32(uint x, uint[] z)
		{
			if ((x != 0U && global::Org.BouncyCastle.Math.Raw.Nat256.Mul33WordAdd(977U, x, z, 0) != 0U) || (z[7] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat256.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.P)))
			{
				global::Org.BouncyCastle.Math.Raw.Nat.Add33To(8, 977U, z);
			}
		}

		// Token: 0x06001951 RID: 6481 RVA: 0x000784AC File Offset: 0x000766AC
		public static void Square(uint[] x, uint[] z)
		{
			uint[] tt = global::Org.BouncyCastle.Math.Raw.Nat256.CreateExt();
			global::Org.BouncyCastle.Math.Raw.Nat256.Square(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Reduce(tt, z);
		}

		// Token: 0x06001952 RID: 6482 RVA: 0x000784D0 File Offset: 0x000766D0
		public static void SquareN(uint[] x, int n, uint[] z)
		{
			uint[] tt = global::Org.BouncyCastle.Math.Raw.Nat256.CreateExt();
			global::Org.BouncyCastle.Math.Raw.Nat256.Square(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Reduce(tt, z);
			while (--n > 0)
			{
				global::Org.BouncyCastle.Math.Raw.Nat256.Square(z, tt);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Reduce(tt, z);
			}
		}

		// Token: 0x06001953 RID: 6483 RVA: 0x0007850A File Offset: 0x0007670A
		public static void Subtract(uint[] x, uint[] y, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat256.Sub(x, y, z) != 0)
			{
				global::Org.BouncyCastle.Math.Raw.Nat.Sub33From(8, 977U, z);
			}
		}

		// Token: 0x06001954 RID: 6484 RVA: 0x00078523 File Offset: 0x00076723
		public static void SubtractExt(uint[] xx, uint[] yy, uint[] zz)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat.Sub(16, xx, yy, zz) != 0 && global::Org.BouncyCastle.Math.Raw.Nat.SubFrom(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.PExtInv.Length, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.PExtInv, zz) != 0)
			{
				global::Org.BouncyCastle.Math.Raw.Nat.DecAt(16, zz, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.PExtInv.Length);
			}
		}

		// Token: 0x06001955 RID: 6485 RVA: 0x00078555 File Offset: 0x00076755
		public static void Twice(uint[] x, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat.ShiftUpBit(8, x, 0U, z) != 0U || (z[7] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat256.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.P)))
			{
				global::Org.BouncyCastle.Math.Raw.Nat.Add33To(8, 977U, z);
			}
		}

		// Token: 0x04000A5F RID: 2655
		internal static readonly uint[] P = new uint[]
		{
			4294966319U,
			4294967294U,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue
		};

		// Token: 0x04000A60 RID: 2656
		private static readonly uint[] PExt = new uint[]
		{
			954529U,
			1954U,
			1U,
			0U,
			0U,
			0U,
			0U,
			0U,
			4294965342U,
			4294967293U,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue
		};

		// Token: 0x04000A61 RID: 2657
		private static readonly uint[] PExtInv = new uint[]
		{
			4294012767U,
			4294965341U,
			4294967294U,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			1953U,
			2U
		};

		// Token: 0x04000A62 RID: 2658
		private const uint P7 = 4294967295U;

		// Token: 0x04000A63 RID: 2659
		private const uint PExt15 = 4294967295U;

		// Token: 0x04000A64 RID: 2660
		private const uint PInv33 = 977U;
	}
}
