using System;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x0200025E RID: 606
	internal class SecP224R1Field
	{
		// Token: 0x060018FA RID: 6394 RVA: 0x00076F8C File Offset: 0x0007518C
		public static void Add(uint[] x, uint[] y, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat224.Add(x, y, z) != 0U || (z[6] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat224.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.P)))
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.AddPInvTo(z);
			}
		}

		// Token: 0x060018FB RID: 6395 RVA: 0x00076FB4 File Offset: 0x000751B4
		public static void AddExt(uint[] xx, uint[] yy, uint[] zz)
		{
			if ((global::Org.BouncyCastle.Math.Raw.Nat.Add(14, xx, yy, zz) != 0U || (zz[13] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat.Gte(14, zz, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.PExt))) && global::Org.BouncyCastle.Math.Raw.Nat.AddTo(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.PExtInv.Length, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.PExtInv, zz) != 0U)
			{
				global::Org.BouncyCastle.Math.Raw.Nat.IncAt(14, zz, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.PExtInv.Length);
			}
		}

		// Token: 0x060018FC RID: 6396 RVA: 0x00077007 File Offset: 0x00075207
		public static void AddOne(uint[] x, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat.Inc(7, x, z) != 0U || (z[6] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat224.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.P)))
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.AddPInvTo(z);
			}
		}

		// Token: 0x060018FD RID: 6397 RVA: 0x0007702C File Offset: 0x0007522C
		public static uint[] FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat.FromBigInteger(224, x);
			if (z[6] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat224.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.P))
			{
				global::Org.BouncyCastle.Math.Raw.Nat224.SubFrom(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.P, z);
			}
			return z;
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x00077068 File Offset: 0x00075268
		public static void Half(uint[] x, uint[] z)
		{
			if ((x[0] & 1U) == 0U)
			{
				global::Org.BouncyCastle.Math.Raw.Nat.ShiftDownBit(7, x, 0U, z);
				return;
			}
			uint c = global::Org.BouncyCastle.Math.Raw.Nat224.Add(x, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.P, z);
			global::Org.BouncyCastle.Math.Raw.Nat.ShiftDownBit(7, z, c);
		}

		// Token: 0x060018FF RID: 6399 RVA: 0x0007709D File Offset: 0x0007529D
		public static void Inv(uint[] x, uint[] z)
		{
			global::Org.BouncyCastle.Math.Raw.Mod.CheckedModOddInverse(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.P, x, z);
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x000770AC File Offset: 0x000752AC
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

		// Token: 0x06001901 RID: 6401 RVA: 0x000770DC File Offset: 0x000752DC
		public static void Multiply(uint[] x, uint[] y, uint[] z)
		{
			uint[] tt = global::Org.BouncyCastle.Math.Raw.Nat224.CreateExt();
			global::Org.BouncyCastle.Math.Raw.Nat224.Mul(x, y, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Reduce(tt, z);
		}

		// Token: 0x06001902 RID: 6402 RVA: 0x00077100 File Offset: 0x00075300
		public static void MultiplyAddToExt(uint[] x, uint[] y, uint[] zz)
		{
			if ((global::Org.BouncyCastle.Math.Raw.Nat224.MulAddTo(x, y, zz) != 0U || (zz[13] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat.Gte(14, zz, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.PExt))) && global::Org.BouncyCastle.Math.Raw.Nat.AddTo(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.PExtInv.Length, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.PExtInv, zz) != 0U)
			{
				global::Org.BouncyCastle.Math.Raw.Nat.IncAt(14, zz, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.PExtInv.Length);
			}
		}

		// Token: 0x06001903 RID: 6403 RVA: 0x00077151 File Offset: 0x00075351
		public static void Negate(uint[] x, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.IsZero(x) != 0)
			{
				global::Org.BouncyCastle.Math.Raw.Nat224.Sub(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.P, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.P, z);
				return;
			}
			global::Org.BouncyCastle.Math.Raw.Nat224.Sub(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.P, x, z);
		}

		// Token: 0x06001904 RID: 6404 RVA: 0x0007717C File Offset: 0x0007537C
		public static void Random(global::Org.BouncyCastle.Security.SecureRandom r, uint[] z)
		{
			byte[] bb = new byte[28];
			do
			{
				r.NextBytes(bb);
				global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bb, 0, z, 0, 7);
			}
			while (global::Org.BouncyCastle.Math.Raw.Nat.LessThan(7, z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.P) == 0);
		}

		// Token: 0x06001905 RID: 6405 RVA: 0x000771B0 File Offset: 0x000753B0
		public static void RandomMult(global::Org.BouncyCastle.Security.SecureRandom r, uint[] z)
		{
			do
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Random(r, z);
			}
			while (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.IsZero(z) != 0);
		}

		// Token: 0x06001906 RID: 6406 RVA: 0x000771C4 File Offset: 0x000753C4
		public static void Reduce(uint[] xx, uint[] z)
		{
			long xx2 = (long)((ulong)xx[10]);
			long xx3 = (long)((ulong)xx[11]);
			long xx4 = (long)((ulong)xx[12]);
			long xx5 = (long)((ulong)xx[13]);
			long t0 = (long)((ulong)xx[7] + (ulong)xx3 - 1UL);
			long t = (long)((ulong)xx[8] + (ulong)xx4);
			long t2 = (long)((ulong)xx[9] + (ulong)xx5);
			long cc = 0L;
			cc += (long)((ulong)xx[0] - (ulong)t0);
			long z2 = (long)((ulong)((uint)cc));
			cc >>= 32;
			cc += (long)((ulong)xx[1] - (ulong)t);
			z[1] = (uint)cc;
			cc >>= 32;
			cc += (long)((ulong)xx[2] - (ulong)t2);
			z[2] = (uint)cc;
			cc >>= 32;
			cc += (long)((ulong)xx[3] + (ulong)t0 - (ulong)xx2);
			long z3 = (long)((ulong)((uint)cc));
			cc >>= 32;
			cc += (long)((ulong)xx[4] + (ulong)t - (ulong)xx3);
			z[4] = (uint)cc;
			cc >>= 32;
			cc += (long)((ulong)xx[5] + (ulong)t2 - (ulong)xx4);
			z[5] = (uint)cc;
			cc >>= 32;
			cc += (long)((ulong)xx[6] + (ulong)xx2 - (ulong)xx5);
			z[6] = (uint)cc;
			cc >>= 32;
			cc += 1L;
			z3 += cc;
			z2 -= cc;
			z[0] = (uint)z2;
			cc = z2 >> 32;
			if (cc != 0L)
			{
				cc += (long)((ulong)z[1]);
				z[1] = (uint)cc;
				cc >>= 32;
				cc += (long)((ulong)z[2]);
				z[2] = (uint)cc;
				z3 += cc >> 32;
			}
			z[3] = (uint)z3;
			cc = z3 >> 32;
			if ((cc != 0L && global::Org.BouncyCastle.Math.Raw.Nat.IncAt(7, z, 4) != 0U) || (z[6] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat224.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.P)))
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.AddPInvTo(z);
			}
		}

		// Token: 0x06001907 RID: 6407 RVA: 0x00077348 File Offset: 0x00075548
		public static void Reduce32(uint x, uint[] z)
		{
			long cc = 0L;
			if (x != 0U)
			{
				long xx7 = (long)((ulong)x);
				cc += (long)((ulong)z[0] - (ulong)xx7);
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
				cc += (long)((ulong)z[3] + (ulong)xx7);
				z[3] = (uint)cc;
				cc >>= 32;
			}
			if ((cc != 0L && global::Org.BouncyCastle.Math.Raw.Nat.IncAt(7, z, 4) != 0U) || (z[6] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat224.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.P)))
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.AddPInvTo(z);
			}
		}

		// Token: 0x06001908 RID: 6408 RVA: 0x000773D0 File Offset: 0x000755D0
		public static void Square(uint[] x, uint[] z)
		{
			uint[] tt = global::Org.BouncyCastle.Math.Raw.Nat224.CreateExt();
			global::Org.BouncyCastle.Math.Raw.Nat224.Square(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Reduce(tt, z);
		}

		// Token: 0x06001909 RID: 6409 RVA: 0x000773F4 File Offset: 0x000755F4
		public static void SquareN(uint[] x, int n, uint[] z)
		{
			uint[] tt = global::Org.BouncyCastle.Math.Raw.Nat224.CreateExt();
			global::Org.BouncyCastle.Math.Raw.Nat224.Square(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Reduce(tt, z);
			while (--n > 0)
			{
				global::Org.BouncyCastle.Math.Raw.Nat224.Square(z, tt);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Reduce(tt, z);
			}
		}

		// Token: 0x0600190A RID: 6410 RVA: 0x0007742E File Offset: 0x0007562E
		public static void Subtract(uint[] x, uint[] y, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat224.Sub(x, y, z) != 0)
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.SubPInvFrom(z);
			}
		}

		// Token: 0x0600190B RID: 6411 RVA: 0x00077440 File Offset: 0x00075640
		public static void SubtractExt(uint[] xx, uint[] yy, uint[] zz)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat.Sub(14, xx, yy, zz) != 0 && global::Org.BouncyCastle.Math.Raw.Nat.SubFrom(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.PExtInv.Length, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.PExtInv, zz) != 0)
			{
				global::Org.BouncyCastle.Math.Raw.Nat.DecAt(14, zz, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.PExtInv.Length);
			}
		}

		// Token: 0x0600190C RID: 6412 RVA: 0x00077472 File Offset: 0x00075672
		public static void Twice(uint[] x, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat.ShiftUpBit(7, x, 0U, z) != 0U || (z[6] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat224.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.P)))
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.AddPInvTo(z);
			}
		}

		// Token: 0x0600190D RID: 6413 RVA: 0x00077498 File Offset: 0x00075698
		private static void AddPInvTo(uint[] z)
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
				global::Org.BouncyCastle.Math.Raw.Nat.IncAt(7, z, 4);
			}
		}

		// Token: 0x0600190E RID: 6414 RVA: 0x000774FC File Offset: 0x000756FC
		private static void SubPInvFrom(uint[] z)
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
				global::Org.BouncyCastle.Math.Raw.Nat.DecAt(7, z, 4);
			}
		}

		// Token: 0x04000A53 RID: 2643
		internal static readonly uint[] P = new uint[]
		{
			1U,
			0U,
			0U,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue
		};

		// Token: 0x04000A54 RID: 2644
		private static readonly uint[] PExt = new uint[]
		{
			1U,
			0U,
			0U,
			4294967294U,
			uint.MaxValue,
			uint.MaxValue,
			0U,
			2U,
			0U,
			0U,
			4294967294U,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue
		};

		// Token: 0x04000A55 RID: 2645
		private static readonly uint[] PExtInv = new uint[]
		{
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			1U,
			0U,
			0U,
			uint.MaxValue,
			4294967293U,
			uint.MaxValue,
			uint.MaxValue,
			1U
		};

		// Token: 0x04000A56 RID: 2646
		private const uint P6 = 4294967295U;

		// Token: 0x04000A57 RID: 2647
		private const uint PExt13 = 4294967295U;
	}
}
