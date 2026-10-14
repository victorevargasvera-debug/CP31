using System;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x02000256 RID: 598
	internal class SecP192R1Field
	{
		// Token: 0x06001874 RID: 6260 RVA: 0x00074FA0 File Offset: 0x000731A0
		public static void Add(uint[] x, uint[] y, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat192.Add(x, y, z) != 0U || (z[5] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat192.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.P)))
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.AddPInvTo(z);
			}
		}

		// Token: 0x06001875 RID: 6261 RVA: 0x00074FC8 File Offset: 0x000731C8
		public static void AddExt(uint[] xx, uint[] yy, uint[] zz)
		{
			if ((global::Org.BouncyCastle.Math.Raw.Nat.Add(12, xx, yy, zz) != 0U || (zz[11] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat.Gte(12, zz, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.PExt))) && global::Org.BouncyCastle.Math.Raw.Nat.AddTo(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.PExtInv.Length, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.PExtInv, zz) != 0U)
			{
				global::Org.BouncyCastle.Math.Raw.Nat.IncAt(12, zz, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.PExtInv.Length);
			}
		}

		// Token: 0x06001876 RID: 6262 RVA: 0x0007501B File Offset: 0x0007321B
		public static void AddOne(uint[] x, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat.Inc(6, x, z) != 0U || (z[5] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat192.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.P)))
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.AddPInvTo(z);
			}
		}

		// Token: 0x06001877 RID: 6263 RVA: 0x00075040 File Offset: 0x00073240
		public static uint[] FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat.FromBigInteger(192, x);
			if (z[5] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat192.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.P))
			{
				global::Org.BouncyCastle.Math.Raw.Nat192.SubFrom(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.P, z);
			}
			return z;
		}

		// Token: 0x06001878 RID: 6264 RVA: 0x0007507C File Offset: 0x0007327C
		public static void Half(uint[] x, uint[] z)
		{
			if ((x[0] & 1U) == 0U)
			{
				global::Org.BouncyCastle.Math.Raw.Nat.ShiftDownBit(6, x, 0U, z);
				return;
			}
			uint c = global::Org.BouncyCastle.Math.Raw.Nat192.Add(x, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.P, z);
			global::Org.BouncyCastle.Math.Raw.Nat.ShiftDownBit(6, z, c);
		}

		// Token: 0x06001879 RID: 6265 RVA: 0x000750B1 File Offset: 0x000732B1
		public static void Inv(uint[] x, uint[] z)
		{
			global::Org.BouncyCastle.Math.Raw.Mod.CheckedModOddInverse(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.P, x, z);
		}

		// Token: 0x0600187A RID: 6266 RVA: 0x000750C0 File Offset: 0x000732C0
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

		// Token: 0x0600187B RID: 6267 RVA: 0x000750F0 File Offset: 0x000732F0
		public static void Multiply(uint[] x, uint[] y, uint[] z)
		{
			uint[] tt = global::Org.BouncyCastle.Math.Raw.Nat192.CreateExt();
			global::Org.BouncyCastle.Math.Raw.Nat192.Mul(x, y, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.Reduce(tt, z);
		}

		// Token: 0x0600187C RID: 6268 RVA: 0x00075114 File Offset: 0x00073314
		public static void MultiplyAddToExt(uint[] x, uint[] y, uint[] zz)
		{
			if ((global::Org.BouncyCastle.Math.Raw.Nat192.MulAddTo(x, y, zz) != 0U || (zz[11] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat.Gte(12, zz, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.PExt))) && global::Org.BouncyCastle.Math.Raw.Nat.AddTo(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.PExtInv.Length, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.PExtInv, zz) != 0U)
			{
				global::Org.BouncyCastle.Math.Raw.Nat.IncAt(12, zz, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.PExtInv.Length);
			}
		}

		// Token: 0x0600187D RID: 6269 RVA: 0x00075165 File Offset: 0x00073365
		public static void Negate(uint[] x, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.IsZero(x) != 0)
			{
				global::Org.BouncyCastle.Math.Raw.Nat192.Sub(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.P, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.P, z);
				return;
			}
			global::Org.BouncyCastle.Math.Raw.Nat192.Sub(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.P, x, z);
		}

		// Token: 0x0600187E RID: 6270 RVA: 0x00075190 File Offset: 0x00073390
		public static void Random(global::Org.BouncyCastle.Security.SecureRandom r, uint[] z)
		{
			byte[] bb = new byte[24];
			do
			{
				r.NextBytes(bb);
				global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bb, 0, z, 0, 6);
			}
			while (global::Org.BouncyCastle.Math.Raw.Nat.LessThan(6, z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.P) == 0);
		}

		// Token: 0x0600187F RID: 6271 RVA: 0x000751C4 File Offset: 0x000733C4
		public static void RandomMult(global::Org.BouncyCastle.Security.SecureRandom r, uint[] z)
		{
			do
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.Random(r, z);
			}
			while (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.IsZero(z) != 0);
		}

		// Token: 0x06001880 RID: 6272 RVA: 0x000751D8 File Offset: 0x000733D8
		public static void Reduce(uint[] xx, uint[] z)
		{
			ulong xx2 = (ulong)xx[6];
			ulong xx3 = (ulong)xx[7];
			ulong xx4 = (ulong)xx[8];
			ulong xx5 = (ulong)xx[9];
			ulong xx6 = (ulong)xx[10];
			ulong xx7 = (ulong)xx[11];
			ulong t0 = xx2 + xx6;
			ulong t = xx3 + xx7;
			ulong cc = 0UL;
			cc += (ulong)xx[0] + t0;
			uint z2 = (uint)cc;
			cc >>= 32;
			cc += (ulong)xx[1] + t;
			z[1] = (uint)cc;
			cc >>= 32;
			t0 += xx4;
			t += xx5;
			cc += (ulong)xx[2] + t0;
			ulong z3 = (ulong)((uint)cc);
			cc >>= 32;
			cc += (ulong)xx[3] + t;
			z[3] = (uint)cc;
			cc >>= 32;
			t0 -= xx2;
			t -= xx3;
			cc += (ulong)xx[4] + t0;
			z[4] = (uint)cc;
			cc >>= 32;
			cc += (ulong)xx[5] + t;
			z[5] = (uint)cc;
			cc >>= 32;
			z3 += cc;
			cc += (ulong)z2;
			z[0] = (uint)cc;
			cc >>= 32;
			if (cc != 0UL)
			{
				cc += (ulong)z[1];
				z[1] = (uint)cc;
				z3 += cc >> 32;
			}
			z[2] = (uint)z3;
			cc = z3 >> 32;
			if ((cc != 0UL && global::Org.BouncyCastle.Math.Raw.Nat.IncAt(6, z, 3) != 0U) || (z[5] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat192.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.P)))
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.AddPInvTo(z);
			}
		}

		// Token: 0x06001881 RID: 6273 RVA: 0x00075334 File Offset: 0x00073534
		public static void Reduce32(uint x, uint[] z)
		{
			ulong cc = 0UL;
			if (x != 0U)
			{
				cc += (ulong)z[0] + (ulong)x;
				z[0] = (uint)cc;
				cc >>= 32;
				if (cc != 0UL)
				{
					cc += (ulong)z[1];
					z[1] = (uint)cc;
					cc >>= 32;
				}
				cc += (ulong)z[2] + (ulong)x;
				z[2] = (uint)cc;
				cc >>= 32;
			}
			if ((cc != 0UL && global::Org.BouncyCastle.Math.Raw.Nat.IncAt(6, z, 3) != 0U) || (z[5] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat192.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.P)))
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.AddPInvTo(z);
			}
		}

		// Token: 0x06001882 RID: 6274 RVA: 0x000753AC File Offset: 0x000735AC
		public static void Square(uint[] x, uint[] z)
		{
			uint[] tt = global::Org.BouncyCastle.Math.Raw.Nat192.CreateExt();
			global::Org.BouncyCastle.Math.Raw.Nat192.Square(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.Reduce(tt, z);
		}

		// Token: 0x06001883 RID: 6275 RVA: 0x000753D0 File Offset: 0x000735D0
		public static void SquareN(uint[] x, int n, uint[] z)
		{
			uint[] tt = global::Org.BouncyCastle.Math.Raw.Nat192.CreateExt();
			global::Org.BouncyCastle.Math.Raw.Nat192.Square(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.Reduce(tt, z);
			while (--n > 0)
			{
				global::Org.BouncyCastle.Math.Raw.Nat192.Square(z, tt);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.Reduce(tt, z);
			}
		}

		// Token: 0x06001884 RID: 6276 RVA: 0x0007540A File Offset: 0x0007360A
		public static void Subtract(uint[] x, uint[] y, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat192.Sub(x, y, z) != 0)
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.SubPInvFrom(z);
			}
		}

		// Token: 0x06001885 RID: 6277 RVA: 0x0007541C File Offset: 0x0007361C
		public static void SubtractExt(uint[] xx, uint[] yy, uint[] zz)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat.Sub(12, xx, yy, zz) != 0 && global::Org.BouncyCastle.Math.Raw.Nat.SubFrom(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.PExtInv.Length, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.PExtInv, zz) != 0)
			{
				global::Org.BouncyCastle.Math.Raw.Nat.DecAt(12, zz, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.PExtInv.Length);
			}
		}

		// Token: 0x06001886 RID: 6278 RVA: 0x0007544E File Offset: 0x0007364E
		public static void Twice(uint[] x, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat.ShiftUpBit(6, x, 0U, z) != 0U || (z[5] == 4294967295U && global::Org.BouncyCastle.Math.Raw.Nat192.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.P)))
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.AddPInvTo(z);
			}
		}

		// Token: 0x06001887 RID: 6279 RVA: 0x00075474 File Offset: 0x00073674
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
			c += (long)((ulong)z[2] + 1UL);
			z[2] = (uint)c;
			c >>= 32;
			if (c != 0L)
			{
				global::Org.BouncyCastle.Math.Raw.Nat.IncAt(6, z, 3);
			}
		}

		// Token: 0x06001888 RID: 6280 RVA: 0x000754C8 File Offset: 0x000736C8
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
			c += (long)((ulong)z[2] - 1UL);
			z[2] = (uint)c;
			c >>= 32;
			if (c != 0L)
			{
				global::Org.BouncyCastle.Math.Raw.Nat.DecAt(6, z, 3);
			}
		}

		// Token: 0x04000A39 RID: 2617
		internal static readonly uint[] P = new uint[]
		{
			uint.MaxValue,
			uint.MaxValue,
			4294967294U,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue
		};

		// Token: 0x04000A3A RID: 2618
		private static readonly uint[] PExt = new uint[]
		{
			1U,
			0U,
			2U,
			0U,
			1U,
			0U,
			4294967294U,
			uint.MaxValue,
			4294967293U,
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue
		};

		// Token: 0x04000A3B RID: 2619
		private static readonly uint[] PExtInv = new uint[]
		{
			uint.MaxValue,
			uint.MaxValue,
			4294967293U,
			uint.MaxValue,
			4294967294U,
			uint.MaxValue,
			1U,
			0U,
			2U
		};

		// Token: 0x04000A3C RID: 2620
		private const uint P5 = 4294967295U;

		// Token: 0x04000A3D RID: 2621
		private const uint PExt11 = 4294967295U;
	}
}
