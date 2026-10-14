using System;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x02000244 RID: 580
	internal class SecP128R1Field
	{
		// Token: 0x06001754 RID: 5972 RVA: 0x00070B10 File Offset: 0x0006ED10
		public static void Add(uint[] x, uint[] y, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat128.Add(x, y, z) != 0U || (z[3] >= 4294967293U && global::Org.BouncyCastle.Math.Raw.Nat128.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.P)))
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.AddPInvTo(z);
			}
		}

		// Token: 0x06001755 RID: 5973 RVA: 0x00070B36 File Offset: 0x0006ED36
		public static void AddExt(uint[] xx, uint[] yy, uint[] zz)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat256.Add(xx, yy, zz) != 0U || (zz[7] >= 4294967292U && global::Org.BouncyCastle.Math.Raw.Nat256.Gte(zz, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.PExt)))
			{
				global::Org.BouncyCastle.Math.Raw.Nat.AddTo(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.PExtInv.Length, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.PExtInv, zz);
			}
		}

		// Token: 0x06001756 RID: 5974 RVA: 0x00070B69 File Offset: 0x0006ED69
		public static void AddOne(uint[] x, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat.Inc(4, x, z) != 0U || (z[3] >= 4294967293U && global::Org.BouncyCastle.Math.Raw.Nat128.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.P)))
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.AddPInvTo(z);
			}
		}

		// Token: 0x06001757 RID: 5975 RVA: 0x00070B90 File Offset: 0x0006ED90
		public static uint[] FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat.FromBigInteger(128, x);
			if (z[3] >= 4294967293U && global::Org.BouncyCastle.Math.Raw.Nat128.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.P))
			{
				global::Org.BouncyCastle.Math.Raw.Nat128.SubFrom(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.P, z);
			}
			return z;
		}

		// Token: 0x06001758 RID: 5976 RVA: 0x00070BCC File Offset: 0x0006EDCC
		public static void Half(uint[] x, uint[] z)
		{
			if ((x[0] & 1U) == 0U)
			{
				global::Org.BouncyCastle.Math.Raw.Nat.ShiftDownBit(4, x, 0U, z);
				return;
			}
			uint c = global::Org.BouncyCastle.Math.Raw.Nat128.Add(x, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.P, z);
			global::Org.BouncyCastle.Math.Raw.Nat.ShiftDownBit(4, z, c);
		}

		// Token: 0x06001759 RID: 5977 RVA: 0x00070C01 File Offset: 0x0006EE01
		public static void Inv(uint[] x, uint[] z)
		{
			global::Org.BouncyCastle.Math.Raw.Mod.CheckedModOddInverse(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.P, x, z);
		}

		// Token: 0x0600175A RID: 5978 RVA: 0x00070C10 File Offset: 0x0006EE10
		public static int IsZero(uint[] x)
		{
			uint d = 0U;
			for (int i = 0; i < 4; i++)
			{
				d |= x[i];
			}
			d = (d >> 1 | (d & 1U));
			return (int)(d - 1U) >> 31;
		}

		// Token: 0x0600175B RID: 5979 RVA: 0x00070C40 File Offset: 0x0006EE40
		public static void Multiply(uint[] x, uint[] y, uint[] z)
		{
			uint[] tt = global::Org.BouncyCastle.Math.Raw.Nat128.CreateExt();
			global::Org.BouncyCastle.Math.Raw.Nat128.Mul(x, y, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Reduce(tt, z);
		}

		// Token: 0x0600175C RID: 5980 RVA: 0x00070C62 File Offset: 0x0006EE62
		public static void MultiplyAddToExt(uint[] x, uint[] y, uint[] zz)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat128.MulAddTo(x, y, zz) != 0U || (zz[7] >= 4294967292U && global::Org.BouncyCastle.Math.Raw.Nat256.Gte(zz, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.PExt)))
			{
				global::Org.BouncyCastle.Math.Raw.Nat.AddTo(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.PExtInv.Length, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.PExtInv, zz);
			}
		}

		// Token: 0x0600175D RID: 5981 RVA: 0x00070C95 File Offset: 0x0006EE95
		public static void Negate(uint[] x, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.IsZero(x) != 0)
			{
				global::Org.BouncyCastle.Math.Raw.Nat128.Sub(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.P, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.P, z);
				return;
			}
			global::Org.BouncyCastle.Math.Raw.Nat128.Sub(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.P, x, z);
		}

		// Token: 0x0600175E RID: 5982 RVA: 0x00070CC0 File Offset: 0x0006EEC0
		public static void Random(global::Org.BouncyCastle.Security.SecureRandom r, uint[] z)
		{
			byte[] bb = new byte[16];
			do
			{
				r.NextBytes(bb);
				global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bb, 0, z, 0, 4);
			}
			while (global::Org.BouncyCastle.Math.Raw.Nat.LessThan(4, z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.P) == 0);
		}

		// Token: 0x0600175F RID: 5983 RVA: 0x00070CF4 File Offset: 0x0006EEF4
		public static void RandomMult(global::Org.BouncyCastle.Security.SecureRandom r, uint[] z)
		{
			do
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Random(r, z);
			}
			while (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.IsZero(z) != 0);
		}

		// Token: 0x06001760 RID: 5984 RVA: 0x00070D08 File Offset: 0x0006EF08
		public static void Reduce(uint[] xx, uint[] z)
		{
			ulong x0 = (ulong)xx[0];
			ulong x = (ulong)xx[1];
			ulong x2 = (ulong)xx[2];
			ulong x3 = (ulong)xx[3];
			ulong x4 = (ulong)xx[4];
			ulong x5 = (ulong)xx[5];
			ulong x6 = (ulong)xx[6];
			ulong x7 = (ulong)xx[7];
			x3 += x7;
			x6 += x7 << 1;
			x2 += x6;
			x5 += x6 << 1;
			x += x5;
			x4 += x5 << 1;
			x0 += x4;
			x3 += x4 << 1;
			z[0] = (uint)x0;
			x += x0 >> 32;
			z[1] = (uint)x;
			x2 += x >> 32;
			z[2] = (uint)x2;
			x3 += x2 >> 32;
			z[3] = (uint)x3;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Reduce32((uint)(x3 >> 32), z);
		}

		// Token: 0x06001761 RID: 5985 RVA: 0x00070DAC File Offset: 0x0006EFAC
		public static void Reduce32(uint x, uint[] z)
		{
			while (x != 0U)
			{
				ulong x2 = (ulong)x;
				ulong c = (ulong)z[0] + x2;
				z[0] = (uint)c;
				c >>= 32;
				if (c != 0UL)
				{
					c += (ulong)z[1];
					z[1] = (uint)c;
					c >>= 32;
					c += (ulong)z[2];
					z[2] = (uint)c;
					c >>= 32;
				}
				c += (ulong)z[3] + (x2 << 1);
				z[3] = (uint)c;
				c >>= 32;
				x = (uint)c;
			}
			if (z[3] >= 4294967293U && global::Org.BouncyCastle.Math.Raw.Nat128.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.P))
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.AddPInvTo(z);
			}
		}

		// Token: 0x06001762 RID: 5986 RVA: 0x00070E2C File Offset: 0x0006F02C
		public static void Square(uint[] x, uint[] z)
		{
			uint[] tt = global::Org.BouncyCastle.Math.Raw.Nat128.CreateExt();
			global::Org.BouncyCastle.Math.Raw.Nat128.Square(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Reduce(tt, z);
		}

		// Token: 0x06001763 RID: 5987 RVA: 0x00070E50 File Offset: 0x0006F050
		public static void SquareN(uint[] x, int n, uint[] z)
		{
			uint[] tt = global::Org.BouncyCastle.Math.Raw.Nat128.CreateExt();
			global::Org.BouncyCastle.Math.Raw.Nat128.Square(x, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Reduce(tt, z);
			while (--n > 0)
			{
				global::Org.BouncyCastle.Math.Raw.Nat128.Square(z, tt);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Reduce(tt, z);
			}
		}

		// Token: 0x06001764 RID: 5988 RVA: 0x00070E8A File Offset: 0x0006F08A
		public static void Subtract(uint[] x, uint[] y, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat128.Sub(x, y, z) != 0)
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.SubPInvFrom(z);
			}
		}

		// Token: 0x06001765 RID: 5989 RVA: 0x00070E9C File Offset: 0x0006F09C
		public static void SubtractExt(uint[] xx, uint[] yy, uint[] zz)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat.Sub(10, xx, yy, zz) != 0)
			{
				global::Org.BouncyCastle.Math.Raw.Nat.SubFrom(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.PExtInv.Length, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.PExtInv, zz);
			}
		}

		// Token: 0x06001766 RID: 5990 RVA: 0x00070EBD File Offset: 0x0006F0BD
		public static void Twice(uint[] x, uint[] z)
		{
			if (global::Org.BouncyCastle.Math.Raw.Nat.ShiftUpBit(4, x, 0U, z) != 0U || (z[3] >= 4294967293U && global::Org.BouncyCastle.Math.Raw.Nat128.Gte(z, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.P)))
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.AddPInvTo(z);
			}
		}

		// Token: 0x06001767 RID: 5991 RVA: 0x00070EE4 File Offset: 0x0006F0E4
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
			c += (long)((ulong)z[3] + 2UL);
			z[3] = (uint)c;
		}

		// Token: 0x06001768 RID: 5992 RVA: 0x00070F38 File Offset: 0x0006F138
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
			c += (long)((ulong)z[3] - 2UL);
			z[3] = (uint)c;
		}

		// Token: 0x04000A01 RID: 2561
		internal static readonly uint[] P = new uint[]
		{
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			4294967293U
		};

		// Token: 0x04000A02 RID: 2562
		private static readonly uint[] PExt = new uint[]
		{
			1U,
			0U,
			0U,
			4U,
			4294967294U,
			uint.MaxValue,
			3U,
			4294967292U
		};

		// Token: 0x04000A03 RID: 2563
		private static readonly uint[] PExtInv = new uint[]
		{
			uint.MaxValue,
			uint.MaxValue,
			uint.MaxValue,
			4294967291U,
			1U,
			0U,
			4294967292U,
			3U
		};

		// Token: 0x04000A04 RID: 2564
		private const uint P3 = 4294967293U;

		// Token: 0x04000A05 RID: 2565
		private const uint PExt7 = 4294967292U;
	}
}
