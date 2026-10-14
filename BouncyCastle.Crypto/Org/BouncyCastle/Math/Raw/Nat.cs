using System;
using Org.BouncyCastle.Crypto.Utilities;

namespace Org.BouncyCastle.Math.Raw
{
	// Token: 0x020001F1 RID: 497
	internal abstract class Nat
	{
		// Token: 0x060012AD RID: 4781 RVA: 0x00054BC8 File Offset: 0x00052DC8
		public static uint Add(int len, uint[] x, uint[] y, uint[] z)
		{
			ulong c = 0UL;
			for (int i = 0; i < len; i++)
			{
				c += (ulong)x[i] + (ulong)y[i];
				z[i] = (uint)c;
				c >>= 32;
			}
			return (uint)c;
		}

		// Token: 0x060012AE RID: 4782 RVA: 0x00054BFC File Offset: 0x00052DFC
		public static uint Add33At(int len, uint x, uint[] z, int zPos)
		{
			ulong c = (ulong)z[zPos] + (ulong)x;
			z[zPos] = (uint)c;
			c >>= 32;
			c += (ulong)z[zPos + 1] + 1UL;
			z[zPos + 1] = (uint)c;
			c >>= 32;
			if (c != 0UL)
			{
				return global::Org.BouncyCastle.Math.Raw.Nat.IncAt(len, z, zPos + 2);
			}
			return 0U;
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x00054C44 File Offset: 0x00052E44
		public static uint Add33At(int len, uint x, uint[] z, int zOff, int zPos)
		{
			ulong c = (ulong)z[zOff + zPos] + (ulong)x;
			z[zOff + zPos] = (uint)c;
			c >>= 32;
			c += (ulong)z[zOff + zPos + 1] + 1UL;
			z[zOff + zPos + 1] = (uint)c;
			c >>= 32;
			if (c != 0UL)
			{
				return global::Org.BouncyCastle.Math.Raw.Nat.IncAt(len, z, zOff, zPos + 2);
			}
			return 0U;
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x00054C98 File Offset: 0x00052E98
		public static uint Add33To(int len, uint x, uint[] z)
		{
			ulong c = (ulong)z[0] + (ulong)x;
			z[0] = (uint)c;
			c >>= 32;
			c += (ulong)z[1] + 1UL;
			z[1] = (uint)c;
			c >>= 32;
			if (c != 0UL)
			{
				return global::Org.BouncyCastle.Math.Raw.Nat.IncAt(len, z, 2);
			}
			return 0U;
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x00054CD8 File Offset: 0x00052ED8
		public static uint Add33To(int len, uint x, uint[] z, int zOff)
		{
			ulong c = (ulong)z[zOff] + (ulong)x;
			z[zOff] = (uint)c;
			c >>= 32;
			c += (ulong)z[zOff + 1] + 1UL;
			z[zOff + 1] = (uint)c;
			c >>= 32;
			if (c != 0UL)
			{
				return global::Org.BouncyCastle.Math.Raw.Nat.IncAt(len, z, zOff, 2);
			}
			return 0U;
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x00054D20 File Offset: 0x00052F20
		public static uint AddBothTo(int len, uint[] x, uint[] y, uint[] z)
		{
			ulong c = 0UL;
			for (int i = 0; i < len; i++)
			{
				c += (ulong)x[i] + (ulong)y[i] + (ulong)z[i];
				z[i] = (uint)c;
				c >>= 32;
			}
			return (uint)c;
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x00054D5C File Offset: 0x00052F5C
		public static uint AddBothTo(int len, uint[] x, int xOff, uint[] y, int yOff, uint[] z, int zOff)
		{
			ulong c = 0UL;
			for (int i = 0; i < len; i++)
			{
				c += (ulong)x[xOff + i] + (ulong)y[yOff + i] + (ulong)z[zOff + i];
				z[zOff + i] = (uint)c;
				c >>= 32;
			}
			return (uint)c;
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x00054DA4 File Offset: 0x00052FA4
		public static uint AddDWordAt(int len, ulong x, uint[] z, int zPos)
		{
			ulong c = (ulong)z[zPos] + (x & (ulong)-1);
			z[zPos] = (uint)c;
			c >>= 32;
			c += (ulong)z[zPos + 1] + (x >> 32);
			z[zPos + 1] = (uint)c;
			c >>= 32;
			if (c != 0UL)
			{
				return global::Org.BouncyCastle.Math.Raw.Nat.IncAt(len, z, zPos + 2);
			}
			return 0U;
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x00054DF0 File Offset: 0x00052FF0
		public static uint AddDWordAt(int len, ulong x, uint[] z, int zOff, int zPos)
		{
			ulong c = (ulong)z[zOff + zPos] + (x & (ulong)-1);
			z[zOff + zPos] = (uint)c;
			c >>= 32;
			c += (ulong)z[zOff + zPos + 1] + (x >> 32);
			z[zOff + zPos + 1] = (uint)c;
			c >>= 32;
			if (c != 0UL)
			{
				return global::Org.BouncyCastle.Math.Raw.Nat.IncAt(len, z, zOff, zPos + 2);
			}
			return 0U;
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x00054E48 File Offset: 0x00053048
		public static uint AddDWordTo(int len, ulong x, uint[] z)
		{
			ulong c = (ulong)z[0] + (x & (ulong)-1);
			z[0] = (uint)c;
			c >>= 32;
			c += (ulong)z[1] + (x >> 32);
			z[1] = (uint)c;
			c >>= 32;
			if (c != 0UL)
			{
				return global::Org.BouncyCastle.Math.Raw.Nat.IncAt(len, z, 2);
			}
			return 0U;
		}

		// Token: 0x060012B7 RID: 4791 RVA: 0x00054E8C File Offset: 0x0005308C
		public static uint AddDWordTo(int len, ulong x, uint[] z, int zOff)
		{
			ulong c = (ulong)z[zOff] + (x & (ulong)-1);
			z[zOff] = (uint)c;
			c >>= 32;
			c += (ulong)z[zOff + 1] + (x >> 32);
			z[zOff + 1] = (uint)c;
			c >>= 32;
			if (c != 0UL)
			{
				return global::Org.BouncyCastle.Math.Raw.Nat.IncAt(len, z, zOff, 2);
			}
			return 0U;
		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x00054ED8 File Offset: 0x000530D8
		public static uint AddTo(int len, uint[] x, uint[] z)
		{
			ulong c = 0UL;
			for (int i = 0; i < len; i++)
			{
				c += (ulong)x[i] + (ulong)z[i];
				z[i] = (uint)c;
				c >>= 32;
			}
			return (uint)c;
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x00054F0C File Offset: 0x0005310C
		public static uint AddTo(int len, uint[] x, int xOff, uint[] z, int zOff)
		{
			ulong c = 0UL;
			for (int i = 0; i < len; i++)
			{
				c += (ulong)x[xOff + i] + (ulong)z[zOff + i];
				z[zOff + i] = (uint)c;
				c >>= 32;
			}
			return (uint)c;
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x00054F48 File Offset: 0x00053148
		public static uint AddTo(int len, uint[] x, int xOff, uint[] z, int zOff, uint cIn)
		{
			ulong c = (ulong)cIn;
			for (int i = 0; i < len; i++)
			{
				c += (ulong)x[xOff + i] + (ulong)z[zOff + i];
				z[zOff + i] = (uint)c;
				c >>= 32;
			}
			return (uint)c;
		}

		// Token: 0x060012BB RID: 4795 RVA: 0x00054F88 File Offset: 0x00053188
		public static uint AddToEachOther(int len, uint[] u, int uOff, uint[] v, int vOff)
		{
			ulong c = 0UL;
			for (int i = 0; i < len; i++)
			{
				c += (ulong)u[uOff + i] + (ulong)v[vOff + i];
				u[uOff + i] = (uint)c;
				v[vOff + i] = (uint)c;
				c >>= 32;
			}
			return (uint)c;
		}

		// Token: 0x060012BC RID: 4796 RVA: 0x00054FCC File Offset: 0x000531CC
		public static uint AddWordAt(int len, uint x, uint[] z, int zPos)
		{
			ulong c = (ulong)x + (ulong)z[zPos];
			z[zPos] = (uint)c;
			c >>= 32;
			if (c != 0UL)
			{
				return global::Org.BouncyCastle.Math.Raw.Nat.IncAt(len, z, zPos + 1);
			}
			return 0U;
		}

		// Token: 0x060012BD RID: 4797 RVA: 0x00054FFC File Offset: 0x000531FC
		public static uint AddWordAt(int len, uint x, uint[] z, int zOff, int zPos)
		{
			ulong c = (ulong)x + (ulong)z[zOff + zPos];
			z[zOff + zPos] = (uint)c;
			c >>= 32;
			if (c != 0UL)
			{
				return global::Org.BouncyCastle.Math.Raw.Nat.IncAt(len, z, zOff, zPos + 1);
			}
			return 0U;
		}

		// Token: 0x060012BE RID: 4798 RVA: 0x00055034 File Offset: 0x00053234
		public static uint AddWordTo(int len, uint x, uint[] z)
		{
			ulong c = (ulong)x + (ulong)z[0];
			z[0] = (uint)c;
			c >>= 32;
			if (c != 0UL)
			{
				return global::Org.BouncyCastle.Math.Raw.Nat.IncAt(len, z, 1);
			}
			return 0U;
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x00055060 File Offset: 0x00053260
		public static uint AddWordTo(int len, uint x, uint[] z, int zOff)
		{
			ulong c = (ulong)x + (ulong)z[zOff];
			z[zOff] = (uint)c;
			c >>= 32;
			if (c != 0UL)
			{
				return global::Org.BouncyCastle.Math.Raw.Nat.IncAt(len, z, zOff, 1);
			}
			return 0U;
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x00055090 File Offset: 0x00053290
		public static uint CAdd(int len, int mask, uint[] x, uint[] y, uint[] z)
		{
			uint MASK = (uint)(-(uint)(mask & 1));
			ulong c = 0UL;
			for (int i = 0; i < len; i++)
			{
				c += (ulong)x[i] + (ulong)(y[i] & MASK);
				z[i] = (uint)c;
				c >>= 32;
			}
			return (uint)c;
		}

		// Token: 0x060012C1 RID: 4801 RVA: 0x000550CC File Offset: 0x000532CC
		public static void CMov(int len, int mask, uint[] x, int xOff, uint[] z, int zOff)
		{
			uint MASK = (uint)(-(uint)(mask & 1));
			for (int i = 0; i < len; i++)
			{
				uint z_i = z[zOff + i];
				uint diff = z_i ^ x[xOff + i];
				z_i ^= (diff & MASK);
				z[zOff + i] = z_i;
			}
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x00055108 File Offset: 0x00053308
		public static void CMov(int len, int mask, int[] x, int xOff, int[] z, int zOff)
		{
			mask = -(mask & 1);
			for (int i = 0; i < len; i++)
			{
				int z_i = z[zOff + i];
				int diff = z_i ^ x[xOff + i];
				z_i ^= (diff & mask);
				z[zOff + i] = z_i;
			}
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x00055148 File Offset: 0x00053348
		public static int Compare(int len, uint[] x, uint[] y)
		{
			for (int i = len - 1; i >= 0; i--)
			{
				uint x_i = x[i];
				uint y_i = y[i];
				if (x_i < y_i)
				{
					return -1;
				}
				if (x_i > y_i)
				{
					return 1;
				}
			}
			return 0;
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x00055178 File Offset: 0x00053378
		public static int Compare(int len, uint[] x, int xOff, uint[] y, int yOff)
		{
			for (int i = len - 1; i >= 0; i--)
			{
				uint x_i = x[xOff + i];
				uint y_i = y[yOff + i];
				if (x_i < y_i)
				{
					return -1;
				}
				if (x_i > y_i)
				{
					return 1;
				}
			}
			return 0;
		}

		// Token: 0x060012C5 RID: 4805 RVA: 0x000551AD File Offset: 0x000533AD
		public static void Copy(int len, uint[] x, uint[] z)
		{
			global::System.Array.Copy(x, 0, z, 0, len);
		}

		// Token: 0x060012C6 RID: 4806 RVA: 0x000551BC File Offset: 0x000533BC
		public static uint[] Copy(int len, uint[] x)
		{
			uint[] z = new uint[len];
			global::System.Array.Copy(x, 0, z, 0, len);
			return z;
		}

		// Token: 0x060012C7 RID: 4807 RVA: 0x000551DB File Offset: 0x000533DB
		public static void Copy(int len, uint[] x, int xOff, uint[] z, int zOff)
		{
			global::System.Array.Copy(x, xOff, z, zOff, len);
		}

		// Token: 0x060012C8 RID: 4808 RVA: 0x000551E8 File Offset: 0x000533E8
		public static ulong[] Copy64(int len, ulong[] x)
		{
			ulong[] z = new ulong[len];
			global::System.Array.Copy(x, 0, z, 0, len);
			return z;
		}

		// Token: 0x060012C9 RID: 4809 RVA: 0x00055207 File Offset: 0x00053407
		public static void Copy64(int len, ulong[] x, ulong[] z)
		{
			global::System.Array.Copy(x, 0, z, 0, len);
		}

		// Token: 0x060012CA RID: 4810 RVA: 0x00055213 File Offset: 0x00053413
		public static void Copy64(int len, ulong[] x, int xOff, ulong[] z, int zOff)
		{
			global::System.Array.Copy(x, xOff, z, zOff, len);
		}

		// Token: 0x060012CB RID: 4811 RVA: 0x00055220 File Offset: 0x00053420
		public static uint[] Create(int len)
		{
			return new uint[len];
		}

		// Token: 0x060012CC RID: 4812 RVA: 0x00055228 File Offset: 0x00053428
		public static ulong[] Create64(int len)
		{
			return new ulong[len];
		}

		// Token: 0x060012CD RID: 4813 RVA: 0x00055230 File Offset: 0x00053430
		public static int CSub(int len, int mask, uint[] x, uint[] y, uint[] z)
		{
			long MASK = (long)((ulong)(-(ulong)(mask & 1)));
			long c = 0L;
			for (int i = 0; i < len; i++)
			{
				c += (long)((ulong)x[i] - ((ulong)y[i] & (ulong)MASK));
				z[i] = (uint)c;
				c >>= 32;
			}
			return (int)c;
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x00055270 File Offset: 0x00053470
		public static int CSub(int len, int mask, uint[] x, int xOff, uint[] y, int yOff, uint[] z, int zOff)
		{
			long MASK = (long)((ulong)(-(ulong)(mask & 1)));
			long c = 0L;
			for (int i = 0; i < len; i++)
			{
				c += (long)((ulong)x[xOff + i] - ((ulong)y[yOff + i] & (ulong)MASK));
				z[zOff + i] = (uint)c;
				c >>= 32;
			}
			return (int)c;
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x000552B8 File Offset: 0x000534B8
		public static int Dec(int len, uint[] z)
		{
			for (int i = 0; i < len; i++)
			{
				int num = i;
				uint num2 = z[num] - 1U;
				z[num] = num2;
				if (num2 != 4294967295U)
				{
					return 0;
				}
			}
			return -1;
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x000552E8 File Offset: 0x000534E8
		public static int Dec(int len, uint[] x, uint[] z)
		{
			int i = 0;
			while (i < len)
			{
				uint c = x[i] - 1U;
				z[i] = c;
				i++;
				if (c != 4294967295U)
				{
					while (i < len)
					{
						z[i] = x[i];
						i++;
					}
					return 0;
				}
			}
			return -1;
		}

		// Token: 0x060012D1 RID: 4817 RVA: 0x00055324 File Offset: 0x00053524
		public static int DecAt(int len, uint[] z, int zPos)
		{
			for (int i = zPos; i < len; i++)
			{
				int num = i;
				uint num2 = z[num] - 1U;
				z[num] = num2;
				if (num2 != 4294967295U)
				{
					return 0;
				}
			}
			return -1;
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x00055354 File Offset: 0x00053554
		public static int DecAt(int len, uint[] z, int zOff, int zPos)
		{
			for (int i = zPos; i < len; i++)
			{
				int num = zOff + i;
				uint num2 = z[num] - 1U;
				z[num] = num2;
				if (num2 != 4294967295U)
				{
					return 0;
				}
			}
			return -1;
		}

		// Token: 0x060012D3 RID: 4819 RVA: 0x00055384 File Offset: 0x00053584
		public static bool Eq(int len, uint[] x, uint[] y)
		{
			for (int i = len - 1; i >= 0; i--)
			{
				if (x[i] != y[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060012D4 RID: 4820 RVA: 0x000553AC File Offset: 0x000535AC
		public static uint EqualTo(int len, uint[] x, uint y)
		{
			uint d = x[0] ^ y;
			for (int i = 1; i < len; i++)
			{
				d |= x[i];
			}
			d = (d >> 1 | (d & 1U));
			return (uint)((int)(d - 1U) >> 31);
		}

		// Token: 0x060012D5 RID: 4821 RVA: 0x000553E0 File Offset: 0x000535E0
		public static uint EqualTo(int len, uint[] x, int xOff, uint y)
		{
			uint d = x[xOff] ^ y;
			for (int i = 1; i < len; i++)
			{
				d |= x[xOff + i];
			}
			d = (d >> 1 | (d & 1U));
			return (uint)((int)(d - 1U) >> 31);
		}

		// Token: 0x060012D6 RID: 4822 RVA: 0x00055418 File Offset: 0x00053618
		public static uint EqualTo(int len, uint[] x, uint[] y)
		{
			uint d = 0U;
			for (int i = 0; i < len; i++)
			{
				d |= (x[i] ^ y[i]);
			}
			d = (d >> 1 | (d & 1U));
			return (uint)((int)(d - 1U) >> 31);
		}

		// Token: 0x060012D7 RID: 4823 RVA: 0x0005544C File Offset: 0x0005364C
		public static uint EqualTo(int len, uint[] x, int xOff, uint[] y, int yOff)
		{
			uint d = 0U;
			for (int i = 0; i < len; i++)
			{
				d |= (x[xOff + i] ^ y[yOff + i]);
			}
			d = (d >> 1 | (d & 1U));
			return (uint)((int)(d - 1U) >> 31);
		}

		// Token: 0x060012D8 RID: 4824 RVA: 0x00055484 File Offset: 0x00053684
		public static uint EqualToZero(int len, uint[] x)
		{
			uint d = 0U;
			for (int i = 0; i < len; i++)
			{
				d |= x[i];
			}
			d = (d >> 1 | (d & 1U));
			return (uint)((int)(d - 1U) >> 31);
		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x000554B4 File Offset: 0x000536B4
		public static uint EqualToZero(int len, uint[] x, int xOff)
		{
			uint d = 0U;
			for (int i = 0; i < len; i++)
			{
				d |= x[xOff + i];
			}
			d = (d >> 1 | (d & 1U));
			return (uint)((int)(d - 1U) >> 31);
		}

		// Token: 0x060012DA RID: 4826 RVA: 0x000554E8 File Offset: 0x000536E8
		public static uint[] FromBigInteger(int bits, global::Org.BouncyCastle.Math.BigInteger x)
		{
			if (bits < 1)
			{
				throw new global::System.ArgumentException();
			}
			if (x.SignValue < 0 || x.BitLength > bits)
			{
				throw new global::System.ArgumentException();
			}
			int len = bits + 31 >> 5;
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat.Create(len);
			z[0] = (uint)x.IntValue;
			for (int i = 1; i < len; i++)
			{
				x = x.ShiftRight(32);
				z[i] = (uint)x.IntValue;
			}
			return z;
		}

		// Token: 0x060012DB RID: 4827 RVA: 0x00055550 File Offset: 0x00053750
		public static ulong[] FromBigInteger64(int bits, global::Org.BouncyCastle.Math.BigInteger x)
		{
			if (bits < 1)
			{
				throw new global::System.ArgumentException();
			}
			if (x.SignValue < 0 || x.BitLength > bits)
			{
				throw new global::System.ArgumentException();
			}
			int len = bits + 63 >> 6;
			ulong[] z = global::Org.BouncyCastle.Math.Raw.Nat.Create64(len);
			z[0] = (ulong)x.LongValue;
			for (int i = 1; i < len; i++)
			{
				x = x.ShiftRight(64);
				z[i] = (ulong)x.LongValue;
			}
			return z;
		}

		// Token: 0x060012DC RID: 4828 RVA: 0x000555B8 File Offset: 0x000537B8
		public static uint GetBit(uint[] x, int bit)
		{
			if (bit == 0)
			{
				return x[0] & 1U;
			}
			int w = bit >> 5;
			if (w < 0 || w >= x.Length)
			{
				return 0U;
			}
			int b = bit & 31;
			return x[w] >> b & 1U;
		}

		// Token: 0x060012DD RID: 4829 RVA: 0x000555F0 File Offset: 0x000537F0
		public static bool Gte(int len, uint[] x, uint[] y)
		{
			for (int i = len - 1; i >= 0; i--)
			{
				uint x_i = x[i];
				uint y_i = y[i];
				if (x_i < y_i)
				{
					return false;
				}
				if (x_i > y_i)
				{
					return true;
				}
			}
			return true;
		}

		// Token: 0x060012DE RID: 4830 RVA: 0x00055620 File Offset: 0x00053820
		public static uint Inc(int len, uint[] z)
		{
			for (int i = 0; i < len; i++)
			{
				int num = i;
				uint num2 = z[num] + 1U;
				z[num] = num2;
				if (num2 != 0U)
				{
					return 0U;
				}
			}
			return 1U;
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x00055650 File Offset: 0x00053850
		public static uint Inc(int len, uint[] x, uint[] z)
		{
			int i = 0;
			while (i < len)
			{
				uint c = x[i] + 1U;
				z[i] = c;
				i++;
				if (c != 0U)
				{
					while (i < len)
					{
						z[i] = x[i];
						i++;
					}
					return 0U;
				}
			}
			return 1U;
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x0005568C File Offset: 0x0005388C
		public static uint IncAt(int len, uint[] z, int zPos)
		{
			for (int i = zPos; i < len; i++)
			{
				int num = i;
				uint num2 = z[num] + 1U;
				z[num] = num2;
				if (num2 != 0U)
				{
					return 0U;
				}
			}
			return 1U;
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x000556BC File Offset: 0x000538BC
		public static uint IncAt(int len, uint[] z, int zOff, int zPos)
		{
			for (int i = zPos; i < len; i++)
			{
				int num = zOff + i;
				uint num2 = z[num] + 1U;
				z[num] = num2;
				if (num2 != 0U)
				{
					return 0U;
				}
			}
			return 1U;
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x000556EC File Offset: 0x000538EC
		public static bool IsOne(int len, uint[] x)
		{
			if (x[0] != 1U)
			{
				return false;
			}
			for (int i = 1; i < len; i++)
			{
				if (x[i] != 0U)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x00055718 File Offset: 0x00053918
		public static bool IsZero(int len, uint[] x)
		{
			if (x[0] != 0U)
			{
				return false;
			}
			for (int i = 1; i < len; i++)
			{
				if (x[i] != 0U)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x00055740 File Offset: 0x00053940
		public static int LessThan(int len, uint[] x, uint[] y)
		{
			long c = 0L;
			for (int i = 0; i < len; i++)
			{
				c += (long)((ulong)x[i] - (ulong)y[i]);
				c >>= 32;
			}
			return (int)c;
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x00055770 File Offset: 0x00053970
		public static int LessThan(int len, uint[] x, int xOff, uint[] y, int yOff)
		{
			long c = 0L;
			for (int i = 0; i < len; i++)
			{
				c += (long)((ulong)x[xOff + i] - (ulong)y[yOff + i]);
				c >>= 32;
			}
			return (int)c;
		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x000557A4 File Offset: 0x000539A4
		public static void Mul(int len, uint[] x, uint[] y, uint[] zz)
		{
			zz[len] = global::Org.BouncyCastle.Math.Raw.Nat.MulWord(len, x[0], y, zz);
			for (int i = 1; i < len; i++)
			{
				zz[i + len] = global::Org.BouncyCastle.Math.Raw.Nat.MulWordAddTo(len, x[i], y, 0, zz, i);
			}
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x000557E0 File Offset: 0x000539E0
		public static void Mul(int len, uint[] x, int xOff, uint[] y, int yOff, uint[] zz, int zzOff)
		{
			zz[zzOff + len] = global::Org.BouncyCastle.Math.Raw.Nat.MulWord(len, x[xOff], y, yOff, zz, zzOff);
			for (int i = 1; i < len; i++)
			{
				zz[zzOff + i + len] = global::Org.BouncyCastle.Math.Raw.Nat.MulWordAddTo(len, x[xOff + i], y, yOff, zz, zzOff + i);
			}
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x00055830 File Offset: 0x00053A30
		public static void Mul(uint[] x, int xOff, int xLen, uint[] y, int yOff, int yLen, uint[] zz, int zzOff)
		{
			zz[zzOff + yLen] = global::Org.BouncyCastle.Math.Raw.Nat.MulWord(yLen, x[xOff], y, yOff, zz, zzOff);
			for (int i = 1; i < xLen; i++)
			{
				zz[zzOff + i + yLen] = global::Org.BouncyCastle.Math.Raw.Nat.MulWordAddTo(yLen, x[xOff + i], y, yOff, zz, zzOff + i);
			}
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x00055884 File Offset: 0x00053A84
		public static uint MulAddTo(int len, uint[] x, uint[] y, uint[] zz)
		{
			ulong zc = 0UL;
			for (int i = 0; i < len; i++)
			{
				zc += ((ulong)global::Org.BouncyCastle.Math.Raw.Nat.MulWordAddTo(len, x[i], y, 0, zz, i) & (ulong)-1);
				zc += ((ulong)zz[i + len] & (ulong)-1);
				zz[i + len] = (uint)zc;
				zc >>= 32;
			}
			return (uint)zc;
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x000558D0 File Offset: 0x00053AD0
		public static uint MulAddTo(int len, uint[] x, int xOff, uint[] y, int yOff, uint[] zz, int zzOff)
		{
			ulong zc = 0UL;
			for (int i = 0; i < len; i++)
			{
				zc += ((ulong)global::Org.BouncyCastle.Math.Raw.Nat.MulWordAddTo(len, x[xOff + i], y, yOff, zz, zzOff) & (ulong)-1);
				zc += ((ulong)zz[zzOff + len] & (ulong)-1);
				zz[zzOff + len] = (uint)zc;
				zc >>= 32;
				zzOff++;
			}
			return (uint)zc;
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x0005592C File Offset: 0x00053B2C
		public static uint Mul31BothAdd(int len, uint a, uint[] x, uint b, uint[] y, uint[] z, int zOff)
		{
			ulong c = 0UL;
			ulong aVal = (ulong)a;
			ulong bVal = (ulong)b;
			int i = 0;
			do
			{
				c += aVal * (ulong)x[i] + bVal * (ulong)y[i] + (ulong)z[zOff + i];
				z[zOff + i] = (uint)c;
				c >>= 32;
			}
			while (++i < len);
			return (uint)c;
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x00055978 File Offset: 0x00053B78
		public static uint MulWord(int len, uint x, uint[] y, uint[] z)
		{
			ulong c = 0UL;
			ulong xVal = (ulong)x;
			int i = 0;
			do
			{
				c += xVal * (ulong)y[i];
				z[i] = (uint)c;
				c >>= 32;
			}
			while (++i < len);
			return (uint)c;
		}

		// Token: 0x060012ED RID: 4845 RVA: 0x000559AC File Offset: 0x00053BAC
		public static uint MulWord(int len, uint x, uint[] y, int yOff, uint[] z, int zOff)
		{
			ulong c = 0UL;
			ulong xVal = (ulong)x;
			int i = 0;
			do
			{
				c += xVal * (ulong)y[yOff + i];
				z[zOff + i] = (uint)c;
				c >>= 32;
			}
			while (++i < len);
			return (uint)c;
		}

		// Token: 0x060012EE RID: 4846 RVA: 0x000559E4 File Offset: 0x00053BE4
		public static uint MulWordAddTo(int len, uint x, uint[] y, int yOff, uint[] z, int zOff)
		{
			ulong c = 0UL;
			ulong xVal = (ulong)x;
			int i = 0;
			do
			{
				c += xVal * (ulong)y[yOff + i] + (ulong)z[zOff + i];
				z[zOff + i] = (uint)c;
				c >>= 32;
			}
			while (++i < len);
			return (uint)c;
		}

		// Token: 0x060012EF RID: 4847 RVA: 0x00055A28 File Offset: 0x00053C28
		public static uint MulWordDwordAddAt(int len, uint x, ulong y, uint[] z, int zPos)
		{
			ulong c = 0UL;
			ulong xVal = (ulong)x;
			c += xVal * (ulong)((uint)y) + (ulong)z[zPos];
			z[zPos] = (uint)c;
			c >>= 32;
			c += xVal * (y >> 32) + (ulong)z[zPos + 1];
			z[zPos + 1] = (uint)c;
			c >>= 32;
			c += (ulong)z[zPos + 2];
			z[zPos + 2] = (uint)c;
			c >>= 32;
			if (c != 0UL)
			{
				return global::Org.BouncyCastle.Math.Raw.Nat.IncAt(len, z, zPos + 3);
			}
			return 0U;
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x00055A9C File Offset: 0x00053C9C
		public static uint ShiftDownBit(int len, uint[] z, uint c)
		{
			int i = len;
			while (--i >= 0)
			{
				uint next = z[i];
				z[i] = (next >> 1 | c << 31);
				c = next;
			}
			return c << 31;
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x00055ACC File Offset: 0x00053CCC
		public static uint ShiftDownBit(int len, uint[] z, int zOff, uint c)
		{
			int i = len;
			while (--i >= 0)
			{
				uint next = z[zOff + i];
				z[zOff + i] = (next >> 1 | c << 31);
				c = next;
			}
			return c << 31;
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x00055B00 File Offset: 0x00053D00
		public static uint ShiftDownBit(int len, uint[] x, uint c, uint[] z)
		{
			int i = len;
			while (--i >= 0)
			{
				uint next = x[i];
				z[i] = (next >> 1 | c << 31);
				c = next;
			}
			return c << 31;
		}

		// Token: 0x060012F3 RID: 4851 RVA: 0x00055B30 File Offset: 0x00053D30
		public static uint ShiftDownBit(int len, uint[] x, int xOff, uint c, uint[] z, int zOff)
		{
			int i = len;
			while (--i >= 0)
			{
				uint next = x[xOff + i];
				z[zOff + i] = (next >> 1 | c << 31);
				c = next;
			}
			return c << 31;
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x00055B68 File Offset: 0x00053D68
		public static uint ShiftDownBits(int len, uint[] z, int bits, uint c)
		{
			int i = len;
			while (--i >= 0)
			{
				uint next = z[i];
				z[i] = (next >> bits | c << -bits);
				c = next;
			}
			return c << -bits;
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x00055BA0 File Offset: 0x00053DA0
		public static uint ShiftDownBits(int len, uint[] z, int zOff, int bits, uint c)
		{
			int i = len;
			while (--i >= 0)
			{
				uint next = z[zOff + i];
				z[zOff + i] = (next >> bits | c << -bits);
				c = next;
			}
			return c << -bits;
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x00055BE0 File Offset: 0x00053DE0
		public static uint ShiftDownBits(int len, uint[] x, int bits, uint c, uint[] z)
		{
			int i = len;
			while (--i >= 0)
			{
				uint next = x[i];
				z[i] = (next >> bits | c << -bits);
				c = next;
			}
			return c << -bits;
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x00055C1C File Offset: 0x00053E1C
		public static uint ShiftDownBits(int len, uint[] x, int xOff, int bits, uint c, uint[] z, int zOff)
		{
			int i = len;
			while (--i >= 0)
			{
				uint next = x[xOff + i];
				z[zOff + i] = (next >> bits | c << -bits);
				c = next;
			}
			return c << -bits;
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x00055C5C File Offset: 0x00053E5C
		public static uint ShiftDownWord(int len, uint[] z, uint c)
		{
			int i = len;
			while (--i >= 0)
			{
				uint num = z[i];
				z[i] = c;
				c = num;
			}
			return c;
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x00055C80 File Offset: 0x00053E80
		public static uint ShiftUpBit(int len, uint[] z, uint c)
		{
			for (int i = 0; i < len; i++)
			{
				uint next = z[i];
				z[i] = (next << 1 | c >> 31);
				c = next;
			}
			return c >> 31;
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x00055CB0 File Offset: 0x00053EB0
		public static uint ShiftUpBit(int len, uint[] z, int zOff, uint c)
		{
			for (int i = 0; i < len; i++)
			{
				uint next = z[zOff + i];
				z[zOff + i] = (next << 1 | c >> 31);
				c = next;
			}
			return c >> 31;
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x00055CE4 File Offset: 0x00053EE4
		public static uint ShiftUpBit(int len, uint[] x, uint c, uint[] z)
		{
			for (int i = 0; i < len; i++)
			{
				uint next = x[i];
				z[i] = (next << 1 | c >> 31);
				c = next;
			}
			return c >> 31;
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x00055D14 File Offset: 0x00053F14
		public static uint ShiftUpBit(int len, uint[] x, int xOff, uint c, uint[] z, int zOff)
		{
			for (int i = 0; i < len; i++)
			{
				uint next = x[xOff + i];
				z[zOff + i] = (next << 1 | c >> 31);
				c = next;
			}
			return c >> 31;
		}

		// Token: 0x060012FD RID: 4861 RVA: 0x00055D4C File Offset: 0x00053F4C
		public static ulong ShiftUpBit64(int len, ulong[] x, int xOff, ulong c, ulong[] z, int zOff)
		{
			for (int i = 0; i < len; i++)
			{
				ulong next = x[xOff + i];
				z[zOff + i] = (next << 1 | c >> 63);
				c = next;
			}
			return c >> 63;
		}

		// Token: 0x060012FE RID: 4862 RVA: 0x00055D84 File Offset: 0x00053F84
		public static uint ShiftUpBits(int len, uint[] z, int bits, uint c)
		{
			for (int i = 0; i < len; i++)
			{
				uint next = z[i];
				z[i] = (next << bits | c >> -bits);
				c = next;
			}
			return c >> -bits;
		}

		// Token: 0x060012FF RID: 4863 RVA: 0x00055DBC File Offset: 0x00053FBC
		public static uint ShiftUpBits(int len, uint[] z, int zOff, int bits, uint c)
		{
			for (int i = 0; i < len; i++)
			{
				uint next = z[zOff + i];
				z[zOff + i] = (next << bits | c >> -bits);
				c = next;
			}
			return c >> -bits;
		}

		// Token: 0x06001300 RID: 4864 RVA: 0x00055DFC File Offset: 0x00053FFC
		public static ulong ShiftUpBits64(int len, ulong[] z, int zOff, int bits, ulong c)
		{
			for (int i = 0; i < len; i++)
			{
				ulong next = z[zOff + i];
				z[zOff + i] = (next << bits | c >> -bits);
				c = next;
			}
			return c >> -bits;
		}

		// Token: 0x06001301 RID: 4865 RVA: 0x00055E3C File Offset: 0x0005403C
		public static uint ShiftUpBits(int len, uint[] x, int bits, uint c, uint[] z)
		{
			for (int i = 0; i < len; i++)
			{
				uint next = x[i];
				z[i] = (next << bits | c >> -bits);
				c = next;
			}
			return c >> -bits;
		}

		// Token: 0x06001302 RID: 4866 RVA: 0x00055E78 File Offset: 0x00054078
		public static uint ShiftUpBits(int len, uint[] x, int xOff, int bits, uint c, uint[] z, int zOff)
		{
			for (int i = 0; i < len; i++)
			{
				uint next = x[xOff + i];
				z[zOff + i] = (next << bits | c >> -bits);
				c = next;
			}
			return c >> -bits;
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x00055EB8 File Offset: 0x000540B8
		public static ulong ShiftUpBits64(int len, ulong[] x, int xOff, int bits, ulong c, ulong[] z, int zOff)
		{
			for (int i = 0; i < len; i++)
			{
				ulong next = x[xOff + i];
				z[zOff + i] = (next << bits | c >> -bits);
				c = next;
			}
			return c >> -bits;
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x00055EF8 File Offset: 0x000540F8
		public static void Square(int len, uint[] x, uint[] zz)
		{
			int extLen = len << 1;
			uint c = 0U;
			int i = len;
			int j = extLen;
			do
			{
				ulong num = (ulong)x[--i];
				ulong p = num * num;
				zz[--j] = (c << 31 | (uint)(p >> 33));
				zz[--j] = (uint)(p >> 1);
				c = (uint)p;
			}
			while (i > 0);
			ulong d = 0UL;
			int zzPos = 2;
			for (int k = 1; k < len; k++)
			{
				d += (ulong)global::Org.BouncyCastle.Math.Raw.Nat.SquareWordAddTo(x, k, zz);
				d += (ulong)zz[zzPos];
				zz[zzPos++] = (uint)d;
				d >>= 32;
				d += (ulong)zz[zzPos];
				zz[zzPos++] = (uint)d;
				d >>= 32;
			}
			global::Org.BouncyCastle.Math.Raw.Nat.ShiftUpBit(extLen, zz, x[0] << 31);
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x00055FB0 File Offset: 0x000541B0
		public static void Square(int len, uint[] x, int xOff, uint[] zz, int zzOff)
		{
			int extLen = len << 1;
			uint c = 0U;
			int i = len;
			int j = extLen;
			do
			{
				ulong num = (ulong)x[xOff + --i];
				ulong p = num * num;
				zz[zzOff + --j] = (c << 31 | (uint)(p >> 33));
				zz[zzOff + --j] = (uint)(p >> 1);
				c = (uint)p;
			}
			while (i > 0);
			ulong d = 0UL;
			int zzPos = zzOff + 2;
			for (int k = 1; k < len; k++)
			{
				d += (ulong)global::Org.BouncyCastle.Math.Raw.Nat.SquareWordAddTo(x, xOff, k, zz, zzOff);
				d += (ulong)zz[zzPos];
				zz[zzPos++] = (uint)d;
				d >>= 32;
				d += (ulong)zz[zzPos];
				zz[zzPos++] = (uint)d;
				d >>= 32;
			}
			global::Org.BouncyCastle.Math.Raw.Nat.ShiftUpBit(extLen, zz, zzOff, x[xOff] << 31);
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x00056078 File Offset: 0x00054278
		[global::System.Obsolete("Use 'SquareWordAddTo' instead")]
		public static uint SquareWordAdd(uint[] x, int xPos, uint[] z)
		{
			ulong c = 0UL;
			ulong xVal = (ulong)x[xPos];
			int i = 0;
			do
			{
				c += xVal * (ulong)x[i] + (ulong)z[xPos + i];
				z[xPos + i] = (uint)c;
				c >>= 32;
			}
			while (++i < xPos);
			return (uint)c;
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x000560B8 File Offset: 0x000542B8
		[global::System.Obsolete("Use 'SquareWordAddTo' instead")]
		public static uint SquareWordAdd(uint[] x, int xOff, int xPos, uint[] z, int zOff)
		{
			ulong c = 0UL;
			ulong xVal = (ulong)x[xOff + xPos];
			int i = 0;
			do
			{
				c += xVal * ((ulong)x[xOff + i] & (ulong)-1) + ((ulong)z[xPos + zOff] & (ulong)-1);
				z[xPos + zOff] = (uint)c;
				c >>= 32;
				zOff++;
			}
			while (++i < xPos);
			return (uint)c;
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x00056108 File Offset: 0x00054308
		public static uint SquareWordAddTo(uint[] x, int xPos, uint[] z)
		{
			ulong c = 0UL;
			ulong xVal = (ulong)x[xPos];
			int i = 0;
			do
			{
				c += xVal * (ulong)x[i] + (ulong)z[xPos + i];
				z[xPos + i] = (uint)c;
				c >>= 32;
			}
			while (++i < xPos);
			return (uint)c;
		}

		// Token: 0x06001309 RID: 4873 RVA: 0x00056148 File Offset: 0x00054348
		public static uint SquareWordAddTo(uint[] x, int xOff, int xPos, uint[] z, int zOff)
		{
			ulong c = 0UL;
			ulong xVal = (ulong)x[xOff + xPos];
			int i = 0;
			do
			{
				c += xVal * ((ulong)x[xOff + i] & (ulong)-1) + ((ulong)z[xPos + zOff] & (ulong)-1);
				z[xPos + zOff] = (uint)c;
				c >>= 32;
				zOff++;
			}
			while (++i < xPos);
			return (uint)c;
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x00056198 File Offset: 0x00054398
		public static int Sub(int len, uint[] x, uint[] y, uint[] z)
		{
			long c = 0L;
			for (int i = 0; i < len; i++)
			{
				c += (long)((ulong)x[i] - (ulong)y[i]);
				z[i] = (uint)c;
				c >>= 32;
			}
			return (int)c;
		}

		// Token: 0x0600130B RID: 4875 RVA: 0x000561CC File Offset: 0x000543CC
		public static int Sub(int len, uint[] x, int xOff, uint[] y, int yOff, uint[] z, int zOff)
		{
			long c = 0L;
			for (int i = 0; i < len; i++)
			{
				c += (long)((ulong)x[xOff + i] - (ulong)y[yOff + i]);
				z[zOff + i] = (uint)c;
				c >>= 32;
			}
			return (int)c;
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x0005620C File Offset: 0x0005440C
		public static int Sub33At(int len, uint x, uint[] z, int zPos)
		{
			long c = (long)((ulong)z[zPos] - (ulong)x);
			z[zPos] = (uint)c;
			c >>= 32;
			c += (long)((ulong)z[zPos + 1] - 1UL);
			z[zPos + 1] = (uint)c;
			c >>= 32;
			if (c != 0L)
			{
				return global::Org.BouncyCastle.Math.Raw.Nat.DecAt(len, z, zPos + 2);
			}
			return 0;
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x00056254 File Offset: 0x00054454
		public static int Sub33At(int len, uint x, uint[] z, int zOff, int zPos)
		{
			long c = (long)((ulong)z[zOff + zPos] - (ulong)x);
			z[zOff + zPos] = (uint)c;
			c >>= 32;
			c += (long)((ulong)z[zOff + zPos + 1] - 1UL);
			z[zOff + zPos + 1] = (uint)c;
			c >>= 32;
			if (c != 0L)
			{
				return global::Org.BouncyCastle.Math.Raw.Nat.DecAt(len, z, zOff, zPos + 2);
			}
			return 0;
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x000562A8 File Offset: 0x000544A8
		public static int Sub33From(int len, uint x, uint[] z)
		{
			long c = (long)((ulong)z[0] - (ulong)x);
			z[0] = (uint)c;
			c >>= 32;
			c += (long)((ulong)z[1] - 1UL);
			z[1] = (uint)c;
			c >>= 32;
			if (c != 0L)
			{
				return global::Org.BouncyCastle.Math.Raw.Nat.DecAt(len, z, 2);
			}
			return 0;
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x000562E8 File Offset: 0x000544E8
		public static int Sub33From(int len, uint x, uint[] z, int zOff)
		{
			long c = (long)((ulong)z[zOff] - (ulong)x);
			z[zOff] = (uint)c;
			c >>= 32;
			c += (long)((ulong)z[zOff + 1] - 1UL);
			z[zOff + 1] = (uint)c;
			c >>= 32;
			if (c != 0L)
			{
				return global::Org.BouncyCastle.Math.Raw.Nat.DecAt(len, z, zOff, 2);
			}
			return 0;
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x00056330 File Offset: 0x00054530
		public static int SubBothFrom(int len, uint[] x, uint[] y, uint[] z)
		{
			long c = 0L;
			for (int i = 0; i < len; i++)
			{
				c += (long)((ulong)z[i] - (ulong)x[i] - (ulong)y[i]);
				z[i] = (uint)c;
				c >>= 32;
			}
			return (int)c;
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x0005636C File Offset: 0x0005456C
		public static int SubBothFrom(int len, uint[] x, int xOff, uint[] y, int yOff, uint[] z, int zOff)
		{
			long c = 0L;
			for (int i = 0; i < len; i++)
			{
				c += (long)((ulong)z[zOff + i] - (ulong)x[xOff + i] - (ulong)y[yOff + i]);
				z[zOff + i] = (uint)c;
				c >>= 32;
			}
			return (int)c;
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x000563B4 File Offset: 0x000545B4
		public static int SubDWordAt(int len, ulong x, uint[] z, int zPos)
		{
			long c = (long)((ulong)z[zPos] - (x & (ulong)-1));
			z[zPos] = (uint)c;
			c >>= 32;
			c += (long)((ulong)z[zPos + 1] - (x >> 32));
			z[zPos + 1] = (uint)c;
			c >>= 32;
			if (c != 0L)
			{
				return global::Org.BouncyCastle.Math.Raw.Nat.DecAt(len, z, zPos + 2);
			}
			return 0;
		}

		// Token: 0x06001313 RID: 4883 RVA: 0x00056400 File Offset: 0x00054600
		public static int SubDWordAt(int len, ulong x, uint[] z, int zOff, int zPos)
		{
			long c = (long)((ulong)z[zOff + zPos] - (x & (ulong)-1));
			z[zOff + zPos] = (uint)c;
			c >>= 32;
			c += (long)((ulong)z[zOff + zPos + 1] - (x >> 32));
			z[zOff + zPos + 1] = (uint)c;
			c >>= 32;
			if (c != 0L)
			{
				return global::Org.BouncyCastle.Math.Raw.Nat.DecAt(len, z, zOff, zPos + 2);
			}
			return 0;
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x00056458 File Offset: 0x00054658
		public static int SubDWordFrom(int len, ulong x, uint[] z)
		{
			long c = (long)((ulong)z[0] - (x & (ulong)-1));
			z[0] = (uint)c;
			c >>= 32;
			c += (long)((ulong)z[1] - (x >> 32));
			z[1] = (uint)c;
			c >>= 32;
			if (c != 0L)
			{
				return global::Org.BouncyCastle.Math.Raw.Nat.DecAt(len, z, 2);
			}
			return 0;
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x0005649C File Offset: 0x0005469C
		public static int SubDWordFrom(int len, ulong x, uint[] z, int zOff)
		{
			long c = (long)((ulong)z[zOff] - (x & (ulong)-1));
			z[zOff] = (uint)c;
			c >>= 32;
			c += (long)((ulong)z[zOff + 1] - (x >> 32));
			z[zOff + 1] = (uint)c;
			c >>= 32;
			if (c != 0L)
			{
				return global::Org.BouncyCastle.Math.Raw.Nat.DecAt(len, z, zOff, 2);
			}
			return 0;
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x000564E8 File Offset: 0x000546E8
		public static int SubFrom(int len, uint[] x, uint[] z)
		{
			long c = 0L;
			for (int i = 0; i < len; i++)
			{
				c += (long)((ulong)z[i] - (ulong)x[i]);
				z[i] = (uint)c;
				c >>= 32;
			}
			return (int)c;
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x0005651C File Offset: 0x0005471C
		public static int SubFrom(int len, uint[] x, int xOff, uint[] z, int zOff)
		{
			long c = 0L;
			for (int i = 0; i < len; i++)
			{
				c += (long)((ulong)z[zOff + i] - (ulong)x[xOff + i]);
				z[zOff + i] = (uint)c;
				c >>= 32;
			}
			return (int)c;
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x00056558 File Offset: 0x00054758
		public static int SubWordAt(int len, uint x, uint[] z, int zPos)
		{
			long c = (long)((ulong)z[zPos] - (ulong)x);
			z[zPos] = (uint)c;
			c >>= 32;
			if (c != 0L)
			{
				return global::Org.BouncyCastle.Math.Raw.Nat.DecAt(len, z, zPos + 1);
			}
			return 0;
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x00056588 File Offset: 0x00054788
		public static int SubWordAt(int len, uint x, uint[] z, int zOff, int zPos)
		{
			long c = (long)((ulong)z[zOff + zPos] - (ulong)x);
			z[zOff + zPos] = (uint)c;
			c >>= 32;
			if (c != 0L)
			{
				return global::Org.BouncyCastle.Math.Raw.Nat.DecAt(len, z, zOff, zPos + 1);
			}
			return 0;
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x000565C0 File Offset: 0x000547C0
		public static int SubWordFrom(int len, uint x, uint[] z)
		{
			long c = (long)((ulong)z[0] - (ulong)x);
			z[0] = (uint)c;
			c >>= 32;
			if (c != 0L)
			{
				return global::Org.BouncyCastle.Math.Raw.Nat.DecAt(len, z, 1);
			}
			return 0;
		}

		// Token: 0x0600131B RID: 4891 RVA: 0x000565EC File Offset: 0x000547EC
		public static int SubWordFrom(int len, uint x, uint[] z, int zOff)
		{
			long c = (long)((ulong)z[zOff] - (ulong)x);
			z[zOff] = (uint)c;
			c >>= 32;
			if (c != 0L)
			{
				return global::Org.BouncyCastle.Math.Raw.Nat.DecAt(len, z, zOff, 1);
			}
			return 0;
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x0005661C File Offset: 0x0005481C
		public static global::Org.BouncyCastle.Math.BigInteger ToBigInteger(int len, uint[] x)
		{
			byte[] bs = new byte[len << 2];
			for (int i = 0; i < len; i++)
			{
				uint x_i = x[i];
				if (x_i != 0U)
				{
					global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(x_i, bs, len - 1 - i << 2);
				}
			}
			return new global::Org.BouncyCastle.Math.BigInteger(1, bs);
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x0005665C File Offset: 0x0005485C
		public static void Zero(int len, uint[] z)
		{
			for (int i = 0; i < len; i++)
			{
				z[i] = 0U;
			}
		}

		// Token: 0x0600131E RID: 4894 RVA: 0x0005667C File Offset: 0x0005487C
		public static void Zero64(int len, ulong[] z)
		{
			for (int i = 0; i < len; i++)
			{
				z[i] = 0UL;
			}
		}

		// Token: 0x0400092F RID: 2351
		private const ulong M = 4294967295UL;
	}
}
