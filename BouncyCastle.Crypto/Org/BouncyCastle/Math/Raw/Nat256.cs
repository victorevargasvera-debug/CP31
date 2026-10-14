using System;
using Org.BouncyCastle.Crypto.Utilities;

namespace Org.BouncyCastle.Math.Raw
{
	// Token: 0x020001F6 RID: 502
	internal abstract class Nat256
	{
		// Token: 0x060013C6 RID: 5062 RVA: 0x0005C7B0 File Offset: 0x0005A9B0
		public static uint Add(uint[] x, uint[] y, uint[] z)
		{
			ulong c = 0UL;
			c += (ulong)x[0] + (ulong)y[0];
			z[0] = (uint)c;
			c >>= 32;
			c += (ulong)x[1] + (ulong)y[1];
			z[1] = (uint)c;
			c >>= 32;
			c += (ulong)x[2] + (ulong)y[2];
			z[2] = (uint)c;
			c >>= 32;
			c += (ulong)x[3] + (ulong)y[3];
			z[3] = (uint)c;
			c >>= 32;
			c += (ulong)x[4] + (ulong)y[4];
			z[4] = (uint)c;
			c >>= 32;
			c += (ulong)x[5] + (ulong)y[5];
			z[5] = (uint)c;
			c >>= 32;
			c += (ulong)x[6] + (ulong)y[6];
			z[6] = (uint)c;
			c >>= 32;
			c += (ulong)x[7] + (ulong)y[7];
			z[7] = (uint)c;
			c >>= 32;
			return (uint)c;
		}

		// Token: 0x060013C7 RID: 5063 RVA: 0x0005C874 File Offset: 0x0005AA74
		public static uint Add(uint[] x, int xOff, uint[] y, int yOff, uint[] z, int zOff)
		{
			ulong c = 0UL;
			c += (ulong)x[xOff] + (ulong)y[yOff];
			z[zOff] = (uint)c;
			c >>= 32;
			c += (ulong)x[xOff + 1] + (ulong)y[yOff + 1];
			z[zOff + 1] = (uint)c;
			c >>= 32;
			c += (ulong)x[xOff + 2] + (ulong)y[yOff + 2];
			z[zOff + 2] = (uint)c;
			c >>= 32;
			c += (ulong)x[xOff + 3] + (ulong)y[yOff + 3];
			z[zOff + 3] = (uint)c;
			c >>= 32;
			c += (ulong)x[xOff + 4] + (ulong)y[yOff + 4];
			z[zOff + 4] = (uint)c;
			c >>= 32;
			c += (ulong)x[xOff + 5] + (ulong)y[yOff + 5];
			z[zOff + 5] = (uint)c;
			c >>= 32;
			c += (ulong)x[xOff + 6] + (ulong)y[yOff + 6];
			z[zOff + 6] = (uint)c;
			c >>= 32;
			c += (ulong)x[xOff + 7] + (ulong)y[yOff + 7];
			z[zOff + 7] = (uint)c;
			c >>= 32;
			return (uint)c;
		}

		// Token: 0x060013C8 RID: 5064 RVA: 0x0005C970 File Offset: 0x0005AB70
		public static uint AddBothTo(uint[] x, uint[] y, uint[] z)
		{
			ulong c = 0UL;
			c += (ulong)x[0] + (ulong)y[0] + (ulong)z[0];
			z[0] = (uint)c;
			c >>= 32;
			c += (ulong)x[1] + (ulong)y[1] + (ulong)z[1];
			z[1] = (uint)c;
			c >>= 32;
			c += (ulong)x[2] + (ulong)y[2] + (ulong)z[2];
			z[2] = (uint)c;
			c >>= 32;
			c += (ulong)x[3] + (ulong)y[3] + (ulong)z[3];
			z[3] = (uint)c;
			c >>= 32;
			c += (ulong)x[4] + (ulong)y[4] + (ulong)z[4];
			z[4] = (uint)c;
			c >>= 32;
			c += (ulong)x[5] + (ulong)y[5] + (ulong)z[5];
			z[5] = (uint)c;
			c >>= 32;
			c += (ulong)x[6] + (ulong)y[6] + (ulong)z[6];
			z[6] = (uint)c;
			c >>= 32;
			c += (ulong)x[7] + (ulong)y[7] + (ulong)z[7];
			z[7] = (uint)c;
			c >>= 32;
			return (uint)c;
		}

		// Token: 0x060013C9 RID: 5065 RVA: 0x0005CA5C File Offset: 0x0005AC5C
		public static uint AddBothTo(uint[] x, int xOff, uint[] y, int yOff, uint[] z, int zOff)
		{
			ulong c = 0UL;
			c += (ulong)x[xOff] + (ulong)y[yOff] + (ulong)z[zOff];
			z[zOff] = (uint)c;
			c >>= 32;
			c += (ulong)x[xOff + 1] + (ulong)y[yOff + 1] + (ulong)z[zOff + 1];
			z[zOff + 1] = (uint)c;
			c >>= 32;
			c += (ulong)x[xOff + 2] + (ulong)y[yOff + 2] + (ulong)z[zOff + 2];
			z[zOff + 2] = (uint)c;
			c >>= 32;
			c += (ulong)x[xOff + 3] + (ulong)y[yOff + 3] + (ulong)z[zOff + 3];
			z[zOff + 3] = (uint)c;
			c >>= 32;
			c += (ulong)x[xOff + 4] + (ulong)y[yOff + 4] + (ulong)z[zOff + 4];
			z[zOff + 4] = (uint)c;
			c >>= 32;
			c += (ulong)x[xOff + 5] + (ulong)y[yOff + 5] + (ulong)z[zOff + 5];
			z[zOff + 5] = (uint)c;
			c >>= 32;
			c += (ulong)x[xOff + 6] + (ulong)y[yOff + 6] + (ulong)z[zOff + 6];
			z[zOff + 6] = (uint)c;
			c >>= 32;
			c += (ulong)x[xOff + 7] + (ulong)y[yOff + 7] + (ulong)z[zOff + 7];
			z[zOff + 7] = (uint)c;
			c >>= 32;
			return (uint)c;
		}

		// Token: 0x060013CA RID: 5066 RVA: 0x0005CBA0 File Offset: 0x0005ADA0
		public static uint AddTo(uint[] x, uint[] z)
		{
			ulong c = 0UL;
			c += (ulong)x[0] + (ulong)z[0];
			z[0] = (uint)c;
			c >>= 32;
			c += (ulong)x[1] + (ulong)z[1];
			z[1] = (uint)c;
			c >>= 32;
			c += (ulong)x[2] + (ulong)z[2];
			z[2] = (uint)c;
			c >>= 32;
			c += (ulong)x[3] + (ulong)z[3];
			z[3] = (uint)c;
			c >>= 32;
			c += (ulong)x[4] + (ulong)z[4];
			z[4] = (uint)c;
			c >>= 32;
			c += (ulong)x[5] + (ulong)z[5];
			z[5] = (uint)c;
			c >>= 32;
			c += (ulong)x[6] + (ulong)z[6];
			z[6] = (uint)c;
			c >>= 32;
			c += (ulong)x[7] + (ulong)z[7];
			z[7] = (uint)c;
			c >>= 32;
			return (uint)c;
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x0005CC64 File Offset: 0x0005AE64
		public static uint AddTo(uint[] x, int xOff, uint[] z, int zOff, uint cIn)
		{
			ulong c = (ulong)cIn;
			c += (ulong)x[xOff] + (ulong)z[zOff];
			z[zOff] = (uint)c;
			c >>= 32;
			c += (ulong)x[xOff + 1] + (ulong)z[zOff + 1];
			z[zOff + 1] = (uint)c;
			c >>= 32;
			c += (ulong)x[xOff + 2] + (ulong)z[zOff + 2];
			z[zOff + 2] = (uint)c;
			c >>= 32;
			c += (ulong)x[xOff + 3] + (ulong)z[zOff + 3];
			z[zOff + 3] = (uint)c;
			c >>= 32;
			c += (ulong)x[xOff + 4] + (ulong)z[zOff + 4];
			z[zOff + 4] = (uint)c;
			c >>= 32;
			c += (ulong)x[xOff + 5] + (ulong)z[zOff + 5];
			z[zOff + 5] = (uint)c;
			c >>= 32;
			c += (ulong)x[xOff + 6] + (ulong)z[zOff + 6];
			z[zOff + 6] = (uint)c;
			c >>= 32;
			c += (ulong)x[xOff + 7] + (ulong)z[zOff + 7];
			z[zOff + 7] = (uint)c;
			c >>= 32;
			return (uint)c;
		}

		// Token: 0x060013CC RID: 5068 RVA: 0x0005CD54 File Offset: 0x0005AF54
		public static uint AddToEachOther(uint[] u, int uOff, uint[] v, int vOff)
		{
			ulong c = 0UL;
			c += (ulong)u[uOff] + (ulong)v[vOff];
			u[uOff] = (uint)c;
			v[vOff] = (uint)c;
			c >>= 32;
			c += (ulong)u[uOff + 1] + (ulong)v[vOff + 1];
			u[uOff + 1] = (uint)c;
			v[vOff + 1] = (uint)c;
			c >>= 32;
			c += (ulong)u[uOff + 2] + (ulong)v[vOff + 2];
			u[uOff + 2] = (uint)c;
			v[vOff + 2] = (uint)c;
			c >>= 32;
			c += (ulong)u[uOff + 3] + (ulong)v[vOff + 3];
			u[uOff + 3] = (uint)c;
			v[vOff + 3] = (uint)c;
			c >>= 32;
			c += (ulong)u[uOff + 4] + (ulong)v[vOff + 4];
			u[uOff + 4] = (uint)c;
			v[vOff + 4] = (uint)c;
			c >>= 32;
			c += (ulong)u[uOff + 5] + (ulong)v[vOff + 5];
			u[uOff + 5] = (uint)c;
			v[vOff + 5] = (uint)c;
			c >>= 32;
			c += (ulong)u[uOff + 6] + (ulong)v[vOff + 6];
			u[uOff + 6] = (uint)c;
			v[vOff + 6] = (uint)c;
			c >>= 32;
			c += (ulong)u[uOff + 7] + (ulong)v[vOff + 7];
			u[uOff + 7] = (uint)c;
			v[vOff + 7] = (uint)c;
			c >>= 32;
			return (uint)c;
		}

		// Token: 0x060013CD RID: 5069 RVA: 0x0005CE76 File Offset: 0x0005B076
		public static void Copy(uint[] x, uint[] z)
		{
			z[0] = x[0];
			z[1] = x[1];
			z[2] = x[2];
			z[3] = x[3];
			z[4] = x[4];
			z[5] = x[5];
			z[6] = x[6];
			z[7] = x[7];
		}

		// Token: 0x060013CE RID: 5070 RVA: 0x0005CEA8 File Offset: 0x0005B0A8
		public static void Copy(uint[] x, int xOff, uint[] z, int zOff)
		{
			z[zOff] = x[xOff];
			z[zOff + 1] = x[xOff + 1];
			z[zOff + 2] = x[xOff + 2];
			z[zOff + 3] = x[xOff + 3];
			z[zOff + 4] = x[xOff + 4];
			z[zOff + 5] = x[xOff + 5];
			z[zOff + 6] = x[xOff + 6];
			z[zOff + 7] = x[xOff + 7];
		}

		// Token: 0x060013CF RID: 5071 RVA: 0x0005CF01 File Offset: 0x0005B101
		public static void Copy64(ulong[] x, ulong[] z)
		{
			z[0] = x[0];
			z[1] = x[1];
			z[2] = x[2];
			z[3] = x[3];
		}

		// Token: 0x060013D0 RID: 5072 RVA: 0x0005CF1B File Offset: 0x0005B11B
		public static void Copy64(ulong[] x, int xOff, ulong[] z, int zOff)
		{
			z[zOff] = x[xOff];
			z[zOff + 1] = x[xOff + 1];
			z[zOff + 2] = x[xOff + 2];
			z[zOff + 3] = x[xOff + 3];
		}

		// Token: 0x060013D1 RID: 5073 RVA: 0x0005CF41 File Offset: 0x0005B141
		public static uint[] Create()
		{
			return new uint[8];
		}

		// Token: 0x060013D2 RID: 5074 RVA: 0x0005CF49 File Offset: 0x0005B149
		public static ulong[] Create64()
		{
			return new ulong[4];
		}

		// Token: 0x060013D3 RID: 5075 RVA: 0x0005CF51 File Offset: 0x0005B151
		public static uint[] CreateExt()
		{
			return new uint[16];
		}

		// Token: 0x060013D4 RID: 5076 RVA: 0x0005CF5A File Offset: 0x0005B15A
		public static ulong[] CreateExt64()
		{
			return new ulong[8];
		}

		// Token: 0x060013D5 RID: 5077 RVA: 0x0005CF62 File Offset: 0x0005B162
		public static bool Diff(uint[] x, int xOff, uint[] y, int yOff, uint[] z, int zOff)
		{
			bool flag = global::Org.BouncyCastle.Math.Raw.Nat256.Gte(x, xOff, y, yOff);
			if (flag)
			{
				global::Org.BouncyCastle.Math.Raw.Nat256.Sub(x, xOff, y, yOff, z, zOff);
				return flag;
			}
			global::Org.BouncyCastle.Math.Raw.Nat256.Sub(y, yOff, x, xOff, z, zOff);
			return flag;
		}

		// Token: 0x060013D6 RID: 5078 RVA: 0x0005CF90 File Offset: 0x0005B190
		public static bool Eq(uint[] x, uint[] y)
		{
			for (int i = 7; i >= 0; i--)
			{
				if (x[i] != y[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060013D7 RID: 5079 RVA: 0x0005CFB4 File Offset: 0x0005B1B4
		public static bool Eq64(ulong[] x, ulong[] y)
		{
			for (int i = 3; i >= 0; i--)
			{
				if (x[i] != y[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x0005CFD8 File Offset: 0x0005B1D8
		public static uint GetBit(uint[] x, int bit)
		{
			if (bit == 0)
			{
				return x[0] & 1U;
			}
			if ((bit & 255) != bit)
			{
				return 0U;
			}
			int w = bit >> 5;
			int b = bit & 31;
			return x[w] >> b & 1U;
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x0005D010 File Offset: 0x0005B210
		public static bool Gte(uint[] x, uint[] y)
		{
			for (int i = 7; i >= 0; i--)
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

		// Token: 0x060013DA RID: 5082 RVA: 0x0005D040 File Offset: 0x0005B240
		public static bool Gte(uint[] x, int xOff, uint[] y, int yOff)
		{
			for (int i = 7; i >= 0; i--)
			{
				uint x_i = x[xOff + i];
				uint y_i = y[yOff + i];
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

		// Token: 0x060013DB RID: 5083 RVA: 0x0005D074 File Offset: 0x0005B274
		public static bool IsOne(uint[] x)
		{
			if (x[0] != 1U)
			{
				return false;
			}
			for (int i = 1; i < 8; i++)
			{
				if (x[i] != 0U)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060013DC RID: 5084 RVA: 0x0005D0A0 File Offset: 0x0005B2A0
		public static bool IsOne64(ulong[] x)
		{
			if (x[0] != 1UL)
			{
				return false;
			}
			for (int i = 1; i < 4; i++)
			{
				if (x[i] != 0UL)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060013DD RID: 5085 RVA: 0x0005D0CC File Offset: 0x0005B2CC
		public static bool IsZero(uint[] x)
		{
			for (int i = 0; i < 8; i++)
			{
				if (x[i] != 0U)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060013DE RID: 5086 RVA: 0x0005D0F0 File Offset: 0x0005B2F0
		public static bool IsZero64(ulong[] x)
		{
			for (int i = 0; i < 4; i++)
			{
				if (x[i] != 0UL)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060013DF RID: 5087 RVA: 0x0005D114 File Offset: 0x0005B314
		public static void Mul(uint[] x, uint[] y, uint[] zz)
		{
			ulong y_0 = (ulong)y[0];
			ulong y_ = (ulong)y[1];
			ulong y_2 = (ulong)y[2];
			ulong y_3 = (ulong)y[3];
			ulong y_4 = (ulong)y[4];
			ulong y_5 = (ulong)y[5];
			ulong y_6 = (ulong)y[6];
			ulong y_7 = (ulong)y[7];
			ulong c = 0UL;
			ulong x_0 = (ulong)x[0];
			c += x_0 * y_0;
			zz[0] = (uint)c;
			c >>= 32;
			c += x_0 * y_;
			zz[1] = (uint)c;
			c >>= 32;
			c += x_0 * y_2;
			zz[2] = (uint)c;
			c >>= 32;
			c += x_0 * y_3;
			zz[3] = (uint)c;
			c >>= 32;
			c += x_0 * y_4;
			zz[4] = (uint)c;
			c >>= 32;
			c += x_0 * y_5;
			zz[5] = (uint)c;
			c >>= 32;
			c += x_0 * y_6;
			zz[6] = (uint)c;
			c >>= 32;
			c += x_0 * y_7;
			zz[7] = (uint)c;
			c >>= 32;
			zz[8] = (uint)c;
			for (int i = 1; i < 8; i++)
			{
				ulong c2 = 0UL;
				ulong x_i = (ulong)x[i];
				c2 += x_i * y_0 + (ulong)zz[i];
				zz[i] = (uint)c2;
				c2 >>= 32;
				c2 += x_i * y_ + (ulong)zz[i + 1];
				zz[i + 1] = (uint)c2;
				c2 >>= 32;
				c2 += x_i * y_2 + (ulong)zz[i + 2];
				zz[i + 2] = (uint)c2;
				c2 >>= 32;
				c2 += x_i * y_3 + (ulong)zz[i + 3];
				zz[i + 3] = (uint)c2;
				c2 >>= 32;
				c2 += x_i * y_4 + (ulong)zz[i + 4];
				zz[i + 4] = (uint)c2;
				c2 >>= 32;
				c2 += x_i * y_5 + (ulong)zz[i + 5];
				zz[i + 5] = (uint)c2;
				c2 >>= 32;
				c2 += x_i * y_6 + (ulong)zz[i + 6];
				zz[i + 6] = (uint)c2;
				c2 >>= 32;
				c2 += x_i * y_7 + (ulong)zz[i + 7];
				zz[i + 7] = (uint)c2;
				c2 >>= 32;
				zz[i + 8] = (uint)c2;
			}
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x0005D344 File Offset: 0x0005B544
		public static void Mul(uint[] x, int xOff, uint[] y, int yOff, uint[] zz, int zzOff)
		{
			ulong y_0 = (ulong)y[yOff];
			ulong y_ = (ulong)y[yOff + 1];
			ulong y_2 = (ulong)y[yOff + 2];
			ulong y_3 = (ulong)y[yOff + 3];
			ulong y_4 = (ulong)y[yOff + 4];
			ulong y_5 = (ulong)y[yOff + 5];
			ulong y_6 = (ulong)y[yOff + 6];
			ulong y_7 = (ulong)y[yOff + 7];
			ulong c = 0UL;
			ulong x_0 = (ulong)x[xOff];
			c += x_0 * y_0;
			zz[zzOff] = (uint)c;
			c >>= 32;
			c += x_0 * y_;
			zz[zzOff + 1] = (uint)c;
			c >>= 32;
			c += x_0 * y_2;
			zz[zzOff + 2] = (uint)c;
			c >>= 32;
			c += x_0 * y_3;
			zz[zzOff + 3] = (uint)c;
			c >>= 32;
			c += x_0 * y_4;
			zz[zzOff + 4] = (uint)c;
			c >>= 32;
			c += x_0 * y_5;
			zz[zzOff + 5] = (uint)c;
			c >>= 32;
			c += x_0 * y_6;
			zz[zzOff + 6] = (uint)c;
			c >>= 32;
			c += x_0 * y_7;
			zz[zzOff + 7] = (uint)c;
			c >>= 32;
			zz[zzOff + 8] = (uint)c;
			for (int i = 1; i < 8; i++)
			{
				zzOff++;
				ulong c2 = 0UL;
				ulong x_i = (ulong)x[xOff + i];
				c2 += x_i * y_0 + (ulong)zz[zzOff];
				zz[zzOff] = (uint)c2;
				c2 >>= 32;
				c2 += x_i * y_ + (ulong)zz[zzOff + 1];
				zz[zzOff + 1] = (uint)c2;
				c2 >>= 32;
				c2 += x_i * y_2 + (ulong)zz[zzOff + 2];
				zz[zzOff + 2] = (uint)c2;
				c2 >>= 32;
				c2 += x_i * y_3 + (ulong)zz[zzOff + 3];
				zz[zzOff + 3] = (uint)c2;
				c2 >>= 32;
				c2 += x_i * y_4 + (ulong)zz[zzOff + 4];
				zz[zzOff + 4] = (uint)c2;
				c2 >>= 32;
				c2 += x_i * y_5 + (ulong)zz[zzOff + 5];
				zz[zzOff + 5] = (uint)c2;
				c2 >>= 32;
				c2 += x_i * y_6 + (ulong)zz[zzOff + 6];
				zz[zzOff + 6] = (uint)c2;
				c2 >>= 32;
				c2 += x_i * y_7 + (ulong)zz[zzOff + 7];
				zz[zzOff + 7] = (uint)c2;
				c2 >>= 32;
				zz[zzOff + 8] = (uint)c2;
			}
		}

		// Token: 0x060013E1 RID: 5089 RVA: 0x0005D5BC File Offset: 0x0005B7BC
		public static uint MulAddTo(uint[] x, uint[] y, uint[] zz)
		{
			ulong y_0 = (ulong)y[0];
			ulong y_ = (ulong)y[1];
			ulong y_2 = (ulong)y[2];
			ulong y_3 = (ulong)y[3];
			ulong y_4 = (ulong)y[4];
			ulong y_5 = (ulong)y[5];
			ulong y_6 = (ulong)y[6];
			ulong y_7 = (ulong)y[7];
			ulong zc = 0UL;
			for (int i = 0; i < 8; i++)
			{
				ulong c = 0UL;
				ulong x_i = (ulong)x[i];
				c += x_i * y_0 + (ulong)zz[i];
				zz[i] = (uint)c;
				c >>= 32;
				c += x_i * y_ + (ulong)zz[i + 1];
				zz[i + 1] = (uint)c;
				c >>= 32;
				c += x_i * y_2 + (ulong)zz[i + 2];
				zz[i + 2] = (uint)c;
				c >>= 32;
				c += x_i * y_3 + (ulong)zz[i + 3];
				zz[i + 3] = (uint)c;
				c >>= 32;
				c += x_i * y_4 + (ulong)zz[i + 4];
				zz[i + 4] = (uint)c;
				c >>= 32;
				c += x_i * y_5 + (ulong)zz[i + 5];
				zz[i + 5] = (uint)c;
				c >>= 32;
				c += x_i * y_6 + (ulong)zz[i + 6];
				zz[i + 6] = (uint)c;
				c >>= 32;
				c += x_i * y_7 + (ulong)zz[i + 7];
				zz[i + 7] = (uint)c;
				c >>= 32;
				zc += c + (ulong)zz[i + 8];
				zz[i + 8] = (uint)zc;
				zc >>= 32;
			}
			return (uint)zc;
		}

		// Token: 0x060013E2 RID: 5090 RVA: 0x0005D744 File Offset: 0x0005B944
		public static uint MulAddTo(uint[] x, int xOff, uint[] y, int yOff, uint[] zz, int zzOff)
		{
			ulong y_0 = (ulong)y[yOff];
			ulong y_ = (ulong)y[yOff + 1];
			ulong y_2 = (ulong)y[yOff + 2];
			ulong y_3 = (ulong)y[yOff + 3];
			ulong y_4 = (ulong)y[yOff + 4];
			ulong y_5 = (ulong)y[yOff + 5];
			ulong y_6 = (ulong)y[yOff + 6];
			ulong y_7 = (ulong)y[yOff + 7];
			ulong zc = 0UL;
			for (int i = 0; i < 8; i++)
			{
				ulong c = 0UL;
				ulong x_i = (ulong)x[xOff + i];
				c += x_i * y_0 + (ulong)zz[zzOff];
				zz[zzOff] = (uint)c;
				c >>= 32;
				c += x_i * y_ + (ulong)zz[zzOff + 1];
				zz[zzOff + 1] = (uint)c;
				c >>= 32;
				c += x_i * y_2 + (ulong)zz[zzOff + 2];
				zz[zzOff + 2] = (uint)c;
				c >>= 32;
				c += x_i * y_3 + (ulong)zz[zzOff + 3];
				zz[zzOff + 3] = (uint)c;
				c >>= 32;
				c += x_i * y_4 + (ulong)zz[zzOff + 4];
				zz[zzOff + 4] = (uint)c;
				c >>= 32;
				c += x_i * y_5 + (ulong)zz[zzOff + 5];
				zz[zzOff + 5] = (uint)c;
				c >>= 32;
				c += x_i * y_6 + (ulong)zz[zzOff + 6];
				zz[zzOff + 6] = (uint)c;
				c >>= 32;
				c += x_i * y_7 + (ulong)zz[zzOff + 7];
				zz[zzOff + 7] = (uint)c;
				c >>= 32;
				zc += c + (ulong)zz[zzOff + 8];
				zz[zzOff + 8] = (uint)zc;
				zc >>= 32;
				zzOff++;
			}
			return (uint)zc;
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x0005D8F4 File Offset: 0x0005BAF4
		public static ulong Mul33Add(uint w, uint[] x, int xOff, uint[] y, int yOff, uint[] z, int zOff)
		{
			ulong c = 0UL;
			ulong wVal = (ulong)w;
			ulong x2 = (ulong)x[xOff];
			c += wVal * x2 + (ulong)y[yOff];
			z[zOff] = (uint)c;
			c >>= 32;
			ulong x3 = (ulong)x[xOff + 1];
			c += wVal * x3 + x2 + (ulong)y[yOff + 1];
			z[zOff + 1] = (uint)c;
			c >>= 32;
			ulong x4 = (ulong)x[xOff + 2];
			c += wVal * x4 + x3 + (ulong)y[yOff + 2];
			z[zOff + 2] = (uint)c;
			c >>= 32;
			ulong x5 = (ulong)x[xOff + 3];
			c += wVal * x5 + x4 + (ulong)y[yOff + 3];
			z[zOff + 3] = (uint)c;
			c >>= 32;
			ulong x6 = (ulong)x[xOff + 4];
			c += wVal * x6 + x5 + (ulong)y[yOff + 4];
			z[zOff + 4] = (uint)c;
			c >>= 32;
			ulong x7 = (ulong)x[xOff + 5];
			c += wVal * x7 + x6 + (ulong)y[yOff + 5];
			z[zOff + 5] = (uint)c;
			c >>= 32;
			ulong x8 = (ulong)x[xOff + 6];
			c += wVal * x8 + x7 + (ulong)y[yOff + 6];
			z[zOff + 6] = (uint)c;
			c >>= 32;
			ulong x9 = (ulong)x[xOff + 7];
			c += wVal * x9 + x8 + (ulong)y[yOff + 7];
			z[zOff + 7] = (uint)c;
			c >>= 32;
			return c + x9;
		}

		// Token: 0x060013E4 RID: 5092 RVA: 0x0005DA40 File Offset: 0x0005BC40
		public static uint MulByWord(uint x, uint[] z)
		{
			ulong c = 0UL;
			ulong xVal = (ulong)x;
			c += xVal * (ulong)z[0];
			z[0] = (uint)c;
			c >>= 32;
			c += xVal * (ulong)z[1];
			z[1] = (uint)c;
			c >>= 32;
			c += xVal * (ulong)z[2];
			z[2] = (uint)c;
			c >>= 32;
			c += xVal * (ulong)z[3];
			z[3] = (uint)c;
			c >>= 32;
			c += xVal * (ulong)z[4];
			z[4] = (uint)c;
			c >>= 32;
			c += xVal * (ulong)z[5];
			z[5] = (uint)c;
			c >>= 32;
			c += xVal * (ulong)z[6];
			z[6] = (uint)c;
			c >>= 32;
			c += xVal * (ulong)z[7];
			z[7] = (uint)c;
			c >>= 32;
			return (uint)c;
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x0005DAF0 File Offset: 0x0005BCF0
		public static uint MulByWordAddTo(uint x, uint[] y, uint[] z)
		{
			ulong c = 0UL;
			ulong xVal = (ulong)x;
			c += xVal * (ulong)z[0] + (ulong)y[0];
			z[0] = (uint)c;
			c >>= 32;
			c += xVal * (ulong)z[1] + (ulong)y[1];
			z[1] = (uint)c;
			c >>= 32;
			c += xVal * (ulong)z[2] + (ulong)y[2];
			z[2] = (uint)c;
			c >>= 32;
			c += xVal * (ulong)z[3] + (ulong)y[3];
			z[3] = (uint)c;
			c >>= 32;
			c += xVal * (ulong)z[4] + (ulong)y[4];
			z[4] = (uint)c;
			c >>= 32;
			c += xVal * (ulong)z[5] + (ulong)y[5];
			z[5] = (uint)c;
			c >>= 32;
			c += xVal * (ulong)z[6] + (ulong)y[6];
			z[6] = (uint)c;
			c >>= 32;
			c += xVal * (ulong)z[7] + (ulong)y[7];
			z[7] = (uint)c;
			c >>= 32;
			return (uint)c;
		}

		// Token: 0x060013E6 RID: 5094 RVA: 0x0005DBC8 File Offset: 0x0005BDC8
		public static uint MulWordAddTo(uint x, uint[] y, int yOff, uint[] z, int zOff)
		{
			ulong c = 0UL;
			ulong xVal = (ulong)x;
			c += xVal * (ulong)y[yOff] + (ulong)z[zOff];
			z[zOff] = (uint)c;
			c >>= 32;
			c += xVal * (ulong)y[yOff + 1] + (ulong)z[zOff + 1];
			z[zOff + 1] = (uint)c;
			c >>= 32;
			c += xVal * (ulong)y[yOff + 2] + (ulong)z[zOff + 2];
			z[zOff + 2] = (uint)c;
			c >>= 32;
			c += xVal * (ulong)y[yOff + 3] + (ulong)z[zOff + 3];
			z[zOff + 3] = (uint)c;
			c >>= 32;
			c += xVal * (ulong)y[yOff + 4] + (ulong)z[zOff + 4];
			z[zOff + 4] = (uint)c;
			c >>= 32;
			c += xVal * (ulong)y[yOff + 5] + (ulong)z[zOff + 5];
			z[zOff + 5] = (uint)c;
			c >>= 32;
			c += xVal * (ulong)y[yOff + 6] + (ulong)z[zOff + 6];
			z[zOff + 6] = (uint)c;
			c >>= 32;
			c += xVal * (ulong)y[yOff + 7] + (ulong)z[zOff + 7];
			z[zOff + 7] = (uint)c;
			c >>= 32;
			return (uint)c;
		}

		// Token: 0x060013E7 RID: 5095 RVA: 0x0005DCD8 File Offset: 0x0005BED8
		public static uint Mul33DWordAdd(uint x, ulong y, uint[] z, int zOff)
		{
			ulong c = 0UL;
			ulong xVal = (ulong)x;
			ulong y2 = y & (ulong)-1;
			c += xVal * y2 + (ulong)z[zOff];
			z[zOff] = (uint)c;
			c >>= 32;
			ulong y3 = y >> 32;
			c += xVal * y3 + y2 + (ulong)z[zOff + 1];
			z[zOff + 1] = (uint)c;
			c >>= 32;
			c += y3 + (ulong)z[zOff + 2];
			z[zOff + 2] = (uint)c;
			c >>= 32;
			c += (ulong)z[zOff + 3];
			z[zOff + 3] = (uint)c;
			c >>= 32;
			if (c != 0UL)
			{
				return global::Org.BouncyCastle.Math.Raw.Nat.IncAt(8, z, zOff, 4);
			}
			return 0U;
		}

		// Token: 0x060013E8 RID: 5096 RVA: 0x0005DD60 File Offset: 0x0005BF60
		public static uint Mul33WordAdd(uint x, uint y, uint[] z, int zOff)
		{
			ulong c = 0UL;
			ulong yVal = (ulong)y;
			c += yVal * (ulong)x + (ulong)z[zOff];
			z[zOff] = (uint)c;
			c >>= 32;
			c += yVal + (ulong)z[zOff + 1];
			z[zOff + 1] = (uint)c;
			c >>= 32;
			c += (ulong)z[zOff + 2];
			z[zOff + 2] = (uint)c;
			c >>= 32;
			if (c != 0UL)
			{
				return global::Org.BouncyCastle.Math.Raw.Nat.IncAt(8, z, zOff, 3);
			}
			return 0U;
		}

		// Token: 0x060013E9 RID: 5097 RVA: 0x0005DDC4 File Offset: 0x0005BFC4
		public static uint MulWordDwordAdd(uint x, ulong y, uint[] z, int zOff)
		{
			ulong c = 0UL;
			ulong xVal = (ulong)x;
			c += xVal * y + (ulong)z[zOff];
			z[zOff] = (uint)c;
			c >>= 32;
			c += xVal * (y >> 32) + (ulong)z[zOff + 1];
			z[zOff + 1] = (uint)c;
			c >>= 32;
			c += (ulong)z[zOff + 2];
			z[zOff + 2] = (uint)c;
			c >>= 32;
			if (c != 0UL)
			{
				return global::Org.BouncyCastle.Math.Raw.Nat.IncAt(8, z, zOff, 3);
			}
			return 0U;
		}

		// Token: 0x060013EA RID: 5098 RVA: 0x0005DE2C File Offset: 0x0005C02C
		public static uint MulWord(uint x, uint[] y, uint[] z, int zOff)
		{
			ulong c = 0UL;
			ulong xVal = (ulong)x;
			int i = 0;
			do
			{
				c += xVal * (ulong)y[i];
				z[zOff + i] = (uint)c;
				c >>= 32;
			}
			while (++i < 8);
			return (uint)c;
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x0005DE60 File Offset: 0x0005C060
		public static void Square(uint[] x, uint[] zz)
		{
			ulong x_0 = (ulong)x[0];
			uint c = 0U;
			int i = 7;
			int j = 16;
			do
			{
				ulong num = (ulong)x[i--];
				ulong p = num * num;
				zz[--j] = (c << 31 | (uint)(p >> 33));
				zz[--j] = (uint)(p >> 1);
				c = (uint)p;
			}
			while (i > 0);
			ulong p2 = x_0 * x_0;
			ulong zz_ = (ulong)((ulong)c << 31) | p2 >> 33;
			zz[0] = (uint)p2;
			c = ((uint)(p2 >> 32) & 1U);
			ulong x_ = (ulong)x[1];
			ulong zz_2 = (ulong)zz[2];
			zz_ += x_ * x_0;
			uint w = (uint)zz_;
			zz[1] = (w << 1 | c);
			c = w >> 31;
			zz_2 += zz_ >> 32;
			ulong x_2 = (ulong)x[2];
			ulong zz_3 = (ulong)zz[3];
			ulong zz_4 = (ulong)zz[4];
			zz_2 += x_2 * x_0;
			w = (uint)zz_2;
			zz[2] = (w << 1 | c);
			c = w >> 31;
			zz_3 += (zz_2 >> 32) + x_2 * x_;
			zz_4 += zz_3 >> 32;
			zz_3 &= (ulong)-1;
			ulong x_3 = (ulong)x[3];
			ulong zz_5 = (ulong)zz[5] + (zz_4 >> 32);
			zz_4 &= (ulong)-1;
			ulong zz_6 = (ulong)zz[6] + (zz_5 >> 32);
			zz_5 &= (ulong)-1;
			zz_3 += x_3 * x_0;
			w = (uint)zz_3;
			zz[3] = (w << 1 | c);
			c = w >> 31;
			zz_4 += (zz_3 >> 32) + x_3 * x_;
			zz_5 += (zz_4 >> 32) + x_3 * x_2;
			zz_4 &= (ulong)-1;
			zz_6 += zz_5 >> 32;
			zz_5 &= (ulong)-1;
			ulong x_4 = (ulong)x[4];
			ulong zz_7 = (ulong)zz[7] + (zz_6 >> 32);
			zz_6 &= (ulong)-1;
			ulong zz_8 = (ulong)zz[8] + (zz_7 >> 32);
			zz_7 &= (ulong)-1;
			zz_4 += x_4 * x_0;
			w = (uint)zz_4;
			zz[4] = (w << 1 | c);
			c = w >> 31;
			zz_5 += (zz_4 >> 32) + x_4 * x_;
			zz_6 += (zz_5 >> 32) + x_4 * x_2;
			zz_5 &= (ulong)-1;
			zz_7 += (zz_6 >> 32) + x_4 * x_3;
			zz_6 &= (ulong)-1;
			zz_8 += zz_7 >> 32;
			zz_7 &= (ulong)-1;
			ulong x_5 = (ulong)x[5];
			ulong zz_9 = (ulong)zz[9] + (zz_8 >> 32);
			zz_8 &= (ulong)-1;
			ulong zz_10 = (ulong)zz[10] + (zz_9 >> 32);
			zz_9 &= (ulong)-1;
			zz_5 += x_5 * x_0;
			w = (uint)zz_5;
			zz[5] = (w << 1 | c);
			c = w >> 31;
			zz_6 += (zz_5 >> 32) + x_5 * x_;
			zz_7 += (zz_6 >> 32) + x_5 * x_2;
			zz_6 &= (ulong)-1;
			zz_8 += (zz_7 >> 32) + x_5 * x_3;
			zz_7 &= (ulong)-1;
			zz_9 += (zz_8 >> 32) + x_5 * x_4;
			zz_8 &= (ulong)-1;
			zz_10 += zz_9 >> 32;
			zz_9 &= (ulong)-1;
			ulong x_6 = (ulong)x[6];
			ulong zz_11 = (ulong)zz[11] + (zz_10 >> 32);
			zz_10 &= (ulong)-1;
			ulong zz_12 = (ulong)zz[12] + (zz_11 >> 32);
			zz_11 &= (ulong)-1;
			zz_6 += x_6 * x_0;
			w = (uint)zz_6;
			zz[6] = (w << 1 | c);
			c = w >> 31;
			zz_7 += (zz_6 >> 32) + x_6 * x_;
			zz_8 += (zz_7 >> 32) + x_6 * x_2;
			zz_7 &= (ulong)-1;
			zz_9 += (zz_8 >> 32) + x_6 * x_3;
			zz_8 &= (ulong)-1;
			zz_10 += (zz_9 >> 32) + x_6 * x_4;
			zz_9 &= (ulong)-1;
			zz_11 += (zz_10 >> 32) + x_6 * x_5;
			zz_10 &= (ulong)-1;
			zz_12 += zz_11 >> 32;
			zz_11 &= (ulong)-1;
			ulong x_7 = (ulong)x[7];
			ulong zz_13 = (ulong)zz[13] + (zz_12 >> 32);
			zz_12 &= (ulong)-1;
			ulong zz_14 = (ulong)zz[14] + (zz_13 >> 32);
			zz_13 &= (ulong)-1;
			zz_7 += x_7 * x_0;
			w = (uint)zz_7;
			zz[7] = (w << 1 | c);
			c = w >> 31;
			zz_8 += (zz_7 >> 32) + x_7 * x_;
			zz_9 += (zz_8 >> 32) + x_7 * x_2;
			zz_10 += (zz_9 >> 32) + x_7 * x_3;
			zz_11 += (zz_10 >> 32) + x_7 * x_4;
			zz_12 += (zz_11 >> 32) + x_7 * x_5;
			zz_13 += (zz_12 >> 32) + x_7 * x_6;
			zz_14 += zz_13 >> 32;
			w = (uint)zz_8;
			zz[8] = (w << 1 | c);
			c = w >> 31;
			w = (uint)zz_9;
			zz[9] = (w << 1 | c);
			c = w >> 31;
			w = (uint)zz_10;
			zz[10] = (w << 1 | c);
			c = w >> 31;
			w = (uint)zz_11;
			zz[11] = (w << 1 | c);
			c = w >> 31;
			w = (uint)zz_12;
			zz[12] = (w << 1 | c);
			c = w >> 31;
			w = (uint)zz_13;
			zz[13] = (w << 1 | c);
			c = w >> 31;
			w = (uint)zz_14;
			zz[14] = (w << 1 | c);
			c = w >> 31;
			w = zz[15] + (uint)(zz_14 >> 32);
			zz[15] = (w << 1 | c);
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x0005E318 File Offset: 0x0005C518
		public static void Square(uint[] x, int xOff, uint[] zz, int zzOff)
		{
			ulong x_0 = (ulong)x[xOff];
			uint c = 0U;
			int i = 7;
			int j = 16;
			do
			{
				ulong num = (ulong)x[xOff + i--];
				ulong p = num * num;
				zz[zzOff + --j] = (c << 31 | (uint)(p >> 33));
				zz[zzOff + --j] = (uint)(p >> 1);
				c = (uint)p;
			}
			while (i > 0);
			ulong p2 = x_0 * x_0;
			ulong zz_ = (ulong)((ulong)c << 31) | p2 >> 33;
			zz[zzOff] = (uint)p2;
			c = ((uint)(p2 >> 32) & 1U);
			ulong x_ = (ulong)x[xOff + 1];
			ulong zz_2 = (ulong)zz[zzOff + 2];
			zz_ += x_ * x_0;
			uint w = (uint)zz_;
			zz[zzOff + 1] = (w << 1 | c);
			c = w >> 31;
			zz_2 += zz_ >> 32;
			ulong x_2 = (ulong)x[xOff + 2];
			ulong zz_3 = (ulong)zz[zzOff + 3];
			ulong zz_4 = (ulong)zz[zzOff + 4];
			zz_2 += x_2 * x_0;
			w = (uint)zz_2;
			zz[zzOff + 2] = (w << 1 | c);
			c = w >> 31;
			zz_3 += (zz_2 >> 32) + x_2 * x_;
			zz_4 += zz_3 >> 32;
			zz_3 &= (ulong)-1;
			ulong x_3 = (ulong)x[xOff + 3];
			ulong zz_5 = (ulong)zz[zzOff + 5] + (zz_4 >> 32);
			zz_4 &= (ulong)-1;
			ulong zz_6 = (ulong)zz[zzOff + 6] + (zz_5 >> 32);
			zz_5 &= (ulong)-1;
			zz_3 += x_3 * x_0;
			w = (uint)zz_3;
			zz[zzOff + 3] = (w << 1 | c);
			c = w >> 31;
			zz_4 += (zz_3 >> 32) + x_3 * x_;
			zz_5 += (zz_4 >> 32) + x_3 * x_2;
			zz_4 &= (ulong)-1;
			zz_6 += zz_5 >> 32;
			zz_5 &= (ulong)-1;
			ulong x_4 = (ulong)x[xOff + 4];
			ulong zz_7 = (ulong)zz[zzOff + 7] + (zz_6 >> 32);
			zz_6 &= (ulong)-1;
			ulong zz_8 = (ulong)zz[zzOff + 8] + (zz_7 >> 32);
			zz_7 &= (ulong)-1;
			zz_4 += x_4 * x_0;
			w = (uint)zz_4;
			zz[zzOff + 4] = (w << 1 | c);
			c = w >> 31;
			zz_5 += (zz_4 >> 32) + x_4 * x_;
			zz_6 += (zz_5 >> 32) + x_4 * x_2;
			zz_5 &= (ulong)-1;
			zz_7 += (zz_6 >> 32) + x_4 * x_3;
			zz_6 &= (ulong)-1;
			zz_8 += zz_7 >> 32;
			zz_7 &= (ulong)-1;
			ulong x_5 = (ulong)x[xOff + 5];
			ulong zz_9 = (ulong)zz[zzOff + 9] + (zz_8 >> 32);
			zz_8 &= (ulong)-1;
			ulong zz_10 = (ulong)zz[zzOff + 10] + (zz_9 >> 32);
			zz_9 &= (ulong)-1;
			zz_5 += x_5 * x_0;
			w = (uint)zz_5;
			zz[zzOff + 5] = (w << 1 | c);
			c = w >> 31;
			zz_6 += (zz_5 >> 32) + x_5 * x_;
			zz_7 += (zz_6 >> 32) + x_5 * x_2;
			zz_6 &= (ulong)-1;
			zz_8 += (zz_7 >> 32) + x_5 * x_3;
			zz_7 &= (ulong)-1;
			zz_9 += (zz_8 >> 32) + x_5 * x_4;
			zz_8 &= (ulong)-1;
			zz_10 += zz_9 >> 32;
			zz_9 &= (ulong)-1;
			ulong x_6 = (ulong)x[xOff + 6];
			ulong zz_11 = (ulong)zz[zzOff + 11] + (zz_10 >> 32);
			zz_10 &= (ulong)-1;
			ulong zz_12 = (ulong)zz[zzOff + 12] + (zz_11 >> 32);
			zz_11 &= (ulong)-1;
			zz_6 += x_6 * x_0;
			w = (uint)zz_6;
			zz[zzOff + 6] = (w << 1 | c);
			c = w >> 31;
			zz_7 += (zz_6 >> 32) + x_6 * x_;
			zz_8 += (zz_7 >> 32) + x_6 * x_2;
			zz_7 &= (ulong)-1;
			zz_9 += (zz_8 >> 32) + x_6 * x_3;
			zz_8 &= (ulong)-1;
			zz_10 += (zz_9 >> 32) + x_6 * x_4;
			zz_9 &= (ulong)-1;
			zz_11 += (zz_10 >> 32) + x_6 * x_5;
			zz_10 &= (ulong)-1;
			zz_12 += zz_11 >> 32;
			zz_11 &= (ulong)-1;
			ulong x_7 = (ulong)x[xOff + 7];
			ulong zz_13 = (ulong)zz[zzOff + 13] + (zz_12 >> 32);
			zz_12 &= (ulong)-1;
			ulong zz_14 = (ulong)zz[zzOff + 14] + (zz_13 >> 32);
			zz_13 &= (ulong)-1;
			zz_7 += x_7 * x_0;
			w = (uint)zz_7;
			zz[zzOff + 7] = (w << 1 | c);
			c = w >> 31;
			zz_8 += (zz_7 >> 32) + x_7 * x_;
			zz_9 += (zz_8 >> 32) + x_7 * x_2;
			zz_10 += (zz_9 >> 32) + x_7 * x_3;
			zz_11 += (zz_10 >> 32) + x_7 * x_4;
			zz_12 += (zz_11 >> 32) + x_7 * x_5;
			zz_13 += (zz_12 >> 32) + x_7 * x_6;
			zz_14 += zz_13 >> 32;
			w = (uint)zz_8;
			zz[zzOff + 8] = (w << 1 | c);
			c = w >> 31;
			w = (uint)zz_9;
			zz[zzOff + 9] = (w << 1 | c);
			c = w >> 31;
			w = (uint)zz_10;
			zz[zzOff + 10] = (w << 1 | c);
			c = w >> 31;
			w = (uint)zz_11;
			zz[zzOff + 11] = (w << 1 | c);
			c = w >> 31;
			w = (uint)zz_12;
			zz[zzOff + 12] = (w << 1 | c);
			c = w >> 31;
			w = (uint)zz_13;
			zz[zzOff + 13] = (w << 1 | c);
			c = w >> 31;
			w = (uint)zz_14;
			zz[zzOff + 14] = (w << 1 | c);
			c = w >> 31;
			w = zz[zzOff + 15] + (uint)(zz_14 >> 32);
			zz[zzOff + 15] = (w << 1 | c);
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x0005E820 File Offset: 0x0005CA20
		public static int Sub(uint[] x, uint[] y, uint[] z)
		{
			long c = 0L;
			c += (long)((ulong)x[0] - (ulong)y[0]);
			z[0] = (uint)c;
			c >>= 32;
			c += (long)((ulong)x[1] - (ulong)y[1]);
			z[1] = (uint)c;
			c >>= 32;
			c += (long)((ulong)x[2] - (ulong)y[2]);
			z[2] = (uint)c;
			c >>= 32;
			c += (long)((ulong)x[3] - (ulong)y[3]);
			z[3] = (uint)c;
			c >>= 32;
			c += (long)((ulong)x[4] - (ulong)y[4]);
			z[4] = (uint)c;
			c >>= 32;
			c += (long)((ulong)x[5] - (ulong)y[5]);
			z[5] = (uint)c;
			c >>= 32;
			c += (long)((ulong)x[6] - (ulong)y[6]);
			z[6] = (uint)c;
			c >>= 32;
			c += (long)((ulong)x[7] - (ulong)y[7]);
			z[7] = (uint)c;
			c >>= 32;
			return (int)c;
		}

		// Token: 0x060013EE RID: 5102 RVA: 0x0005E8E4 File Offset: 0x0005CAE4
		public static int Sub(uint[] x, int xOff, uint[] y, int yOff, uint[] z, int zOff)
		{
			long c = 0L;
			c += (long)((ulong)x[xOff] - (ulong)y[yOff]);
			z[zOff] = (uint)c;
			c >>= 32;
			c += (long)((ulong)x[xOff + 1] - (ulong)y[yOff + 1]);
			z[zOff + 1] = (uint)c;
			c >>= 32;
			c += (long)((ulong)x[xOff + 2] - (ulong)y[yOff + 2]);
			z[zOff + 2] = (uint)c;
			c >>= 32;
			c += (long)((ulong)x[xOff + 3] - (ulong)y[yOff + 3]);
			z[zOff + 3] = (uint)c;
			c >>= 32;
			c += (long)((ulong)x[xOff + 4] - (ulong)y[yOff + 4]);
			z[zOff + 4] = (uint)c;
			c >>= 32;
			c += (long)((ulong)x[xOff + 5] - (ulong)y[yOff + 5]);
			z[zOff + 5] = (uint)c;
			c >>= 32;
			c += (long)((ulong)x[xOff + 6] - (ulong)y[yOff + 6]);
			z[zOff + 6] = (uint)c;
			c >>= 32;
			c += (long)((ulong)x[xOff + 7] - (ulong)y[yOff + 7]);
			z[zOff + 7] = (uint)c;
			c >>= 32;
			return (int)c;
		}

		// Token: 0x060013EF RID: 5103 RVA: 0x0005E9E0 File Offset: 0x0005CBE0
		public static int SubBothFrom(uint[] x, uint[] y, uint[] z)
		{
			long c = 0L;
			c += (long)((ulong)z[0] - (ulong)x[0] - (ulong)y[0]);
			z[0] = (uint)c;
			c >>= 32;
			c += (long)((ulong)z[1] - (ulong)x[1] - (ulong)y[1]);
			z[1] = (uint)c;
			c >>= 32;
			c += (long)((ulong)z[2] - (ulong)x[2] - (ulong)y[2]);
			z[2] = (uint)c;
			c >>= 32;
			c += (long)((ulong)z[3] - (ulong)x[3] - (ulong)y[3]);
			z[3] = (uint)c;
			c >>= 32;
			c += (long)((ulong)z[4] - (ulong)x[4] - (ulong)y[4]);
			z[4] = (uint)c;
			c >>= 32;
			c += (long)((ulong)z[5] - (ulong)x[5] - (ulong)y[5]);
			z[5] = (uint)c;
			c >>= 32;
			c += (long)((ulong)z[6] - (ulong)x[6] - (ulong)y[6]);
			z[6] = (uint)c;
			c >>= 32;
			c += (long)((ulong)z[7] - (ulong)x[7] - (ulong)y[7]);
			z[7] = (uint)c;
			c >>= 32;
			return (int)c;
		}

		// Token: 0x060013F0 RID: 5104 RVA: 0x0005EACC File Offset: 0x0005CCCC
		public static int SubFrom(uint[] x, uint[] z)
		{
			long c = 0L;
			c += (long)((ulong)z[0] - (ulong)x[0]);
			z[0] = (uint)c;
			c >>= 32;
			c += (long)((ulong)z[1] - (ulong)x[1]);
			z[1] = (uint)c;
			c >>= 32;
			c += (long)((ulong)z[2] - (ulong)x[2]);
			z[2] = (uint)c;
			c >>= 32;
			c += (long)((ulong)z[3] - (ulong)x[3]);
			z[3] = (uint)c;
			c >>= 32;
			c += (long)((ulong)z[4] - (ulong)x[4]);
			z[4] = (uint)c;
			c >>= 32;
			c += (long)((ulong)z[5] - (ulong)x[5]);
			z[5] = (uint)c;
			c >>= 32;
			c += (long)((ulong)z[6] - (ulong)x[6]);
			z[6] = (uint)c;
			c >>= 32;
			c += (long)((ulong)z[7] - (ulong)x[7]);
			z[7] = (uint)c;
			c >>= 32;
			return (int)c;
		}

		// Token: 0x060013F1 RID: 5105 RVA: 0x0005EB90 File Offset: 0x0005CD90
		public static int SubFrom(uint[] x, int xOff, uint[] z, int zOff)
		{
			long c = 0L;
			c += (long)((ulong)z[zOff] - (ulong)x[xOff]);
			z[zOff] = (uint)c;
			c >>= 32;
			c += (long)((ulong)z[zOff + 1] - (ulong)x[xOff + 1]);
			z[zOff + 1] = (uint)c;
			c >>= 32;
			c += (long)((ulong)z[zOff + 2] - (ulong)x[xOff + 2]);
			z[zOff + 2] = (uint)c;
			c >>= 32;
			c += (long)((ulong)z[zOff + 3] - (ulong)x[xOff + 3]);
			z[zOff + 3] = (uint)c;
			c >>= 32;
			c += (long)((ulong)z[zOff + 4] - (ulong)x[xOff + 4]);
			z[zOff + 4] = (uint)c;
			c >>= 32;
			c += (long)((ulong)z[zOff + 5] - (ulong)x[xOff + 5]);
			z[zOff + 5] = (uint)c;
			c >>= 32;
			c += (long)((ulong)z[zOff + 6] - (ulong)x[xOff + 6]);
			z[zOff + 6] = (uint)c;
			c >>= 32;
			c += (long)((ulong)z[zOff + 7] - (ulong)x[xOff + 7]);
			z[zOff + 7] = (uint)c;
			c >>= 32;
			return (int)c;
		}

		// Token: 0x060013F2 RID: 5106 RVA: 0x0005EC7C File Offset: 0x0005CE7C
		public static global::Org.BouncyCastle.Math.BigInteger ToBigInteger(uint[] x)
		{
			byte[] bs = new byte[32];
			for (int i = 0; i < 8; i++)
			{
				uint x_i = x[i];
				if (x_i != 0U)
				{
					global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(x_i, bs, 7 - i << 2);
				}
			}
			return new global::Org.BouncyCastle.Math.BigInteger(1, bs);
		}

		// Token: 0x060013F3 RID: 5107 RVA: 0x0005ECB8 File Offset: 0x0005CEB8
		public static global::Org.BouncyCastle.Math.BigInteger ToBigInteger64(ulong[] x)
		{
			byte[] bs = new byte[32];
			for (int i = 0; i < 4; i++)
			{
				ulong x_i = x[i];
				if (x_i != 0UL)
				{
					global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(x_i, bs, 3 - i << 3);
				}
			}
			return new global::Org.BouncyCastle.Math.BigInteger(1, bs);
		}

		// Token: 0x060013F4 RID: 5108 RVA: 0x0005ECF3 File Offset: 0x0005CEF3
		public static void Zero(uint[] z)
		{
			z[0] = 0U;
			z[1] = 0U;
			z[2] = 0U;
			z[3] = 0U;
			z[4] = 0U;
			z[5] = 0U;
			z[6] = 0U;
			z[7] = 0U;
		}

		// Token: 0x04000934 RID: 2356
		private const ulong M = 4294967295UL;
	}
}
