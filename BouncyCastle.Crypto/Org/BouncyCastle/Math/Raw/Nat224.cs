using System;
using Org.BouncyCastle.Crypto.Utilities;

namespace Org.BouncyCastle.Math.Raw
{
	// Token: 0x020001F5 RID: 501
	internal abstract class Nat224
	{
		// Token: 0x0600139E RID: 5022 RVA: 0x0005A7D4 File Offset: 0x000589D4
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
			return (uint)c;
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x0005A880 File Offset: 0x00058A80
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
			return (uint)c;
		}

		// Token: 0x060013A0 RID: 5024 RVA: 0x0005A960 File Offset: 0x00058B60
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
			return (uint)c;
		}

		// Token: 0x060013A1 RID: 5025 RVA: 0x0005AA30 File Offset: 0x00058C30
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
			return (uint)c;
		}

		// Token: 0x060013A2 RID: 5026 RVA: 0x0005AB4C File Offset: 0x00058D4C
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
			return (uint)c;
		}

		// Token: 0x060013A3 RID: 5027 RVA: 0x0005ABF8 File Offset: 0x00058DF8
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
			return (uint)c;
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x0005ACCC File Offset: 0x00058ECC
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
			return (uint)c;
		}

		// Token: 0x060013A5 RID: 5029 RVA: 0x0005ADCB File Offset: 0x00058FCB
		public static void Copy(uint[] x, uint[] z)
		{
			z[0] = x[0];
			z[1] = x[1];
			z[2] = x[2];
			z[3] = x[3];
			z[4] = x[4];
			z[5] = x[5];
			z[6] = x[6];
		}

		// Token: 0x060013A6 RID: 5030 RVA: 0x0005ADF8 File Offset: 0x00058FF8
		public static void Copy(uint[] x, int xOff, uint[] z, int zOff)
		{
			z[zOff] = x[xOff];
			z[zOff + 1] = x[xOff + 1];
			z[zOff + 2] = x[xOff + 2];
			z[zOff + 3] = x[xOff + 3];
			z[zOff + 4] = x[xOff + 4];
			z[zOff + 5] = x[xOff + 5];
			z[zOff + 6] = x[xOff + 6];
		}

		// Token: 0x060013A7 RID: 5031 RVA: 0x0005AE47 File Offset: 0x00059047
		public static uint[] Create()
		{
			return new uint[7];
		}

		// Token: 0x060013A8 RID: 5032 RVA: 0x0005AE4F File Offset: 0x0005904F
		public static uint[] CreateExt()
		{
			return new uint[14];
		}

		// Token: 0x060013A9 RID: 5033 RVA: 0x0005AE58 File Offset: 0x00059058
		public static bool Diff(uint[] x, int xOff, uint[] y, int yOff, uint[] z, int zOff)
		{
			bool flag = global::Org.BouncyCastle.Math.Raw.Nat224.Gte(x, xOff, y, yOff);
			if (flag)
			{
				global::Org.BouncyCastle.Math.Raw.Nat224.Sub(x, xOff, y, yOff, z, zOff);
				return flag;
			}
			global::Org.BouncyCastle.Math.Raw.Nat224.Sub(y, yOff, x, xOff, z, zOff);
			return flag;
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x0005AE84 File Offset: 0x00059084
		public static bool Eq(uint[] x, uint[] y)
		{
			for (int i = 6; i >= 0; i--)
			{
				if (x[i] != y[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060013AB RID: 5035 RVA: 0x0005AEA8 File Offset: 0x000590A8
		public static uint GetBit(uint[] x, int bit)
		{
			if (bit == 0)
			{
				return x[0] & 1U;
			}
			int w = bit >> 5;
			if (w < 0 || w >= 7)
			{
				return 0U;
			}
			int b = bit & 31;
			return x[w] >> b & 1U;
		}

		// Token: 0x060013AC RID: 5036 RVA: 0x0005AEDC File Offset: 0x000590DC
		public static bool Gte(uint[] x, uint[] y)
		{
			for (int i = 6; i >= 0; i--)
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

		// Token: 0x060013AD RID: 5037 RVA: 0x0005AF0C File Offset: 0x0005910C
		public static bool Gte(uint[] x, int xOff, uint[] y, int yOff)
		{
			for (int i = 6; i >= 0; i--)
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

		// Token: 0x060013AE RID: 5038 RVA: 0x0005AF40 File Offset: 0x00059140
		public static bool IsOne(uint[] x)
		{
			if (x[0] != 1U)
			{
				return false;
			}
			for (int i = 1; i < 7; i++)
			{
				if (x[i] != 0U)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x0005AF6C File Offset: 0x0005916C
		public static bool IsZero(uint[] x)
		{
			for (int i = 0; i < 7; i++)
			{
				if (x[i] != 0U)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x0005AF90 File Offset: 0x00059190
		public static void Mul(uint[] x, uint[] y, uint[] zz)
		{
			ulong y_0 = (ulong)y[0];
			ulong y_ = (ulong)y[1];
			ulong y_2 = (ulong)y[2];
			ulong y_3 = (ulong)y[3];
			ulong y_4 = (ulong)y[4];
			ulong y_5 = (ulong)y[5];
			ulong y_6 = (ulong)y[6];
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
			zz[7] = (uint)c;
			for (int i = 1; i < 7; i++)
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
				zz[i + 7] = (uint)c2;
			}
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x0005B180 File Offset: 0x00059380
		public static void Mul(uint[] x, int xOff, uint[] y, int yOff, uint[] zz, int zzOff)
		{
			ulong y_0 = (ulong)y[yOff];
			ulong y_ = (ulong)y[yOff + 1];
			ulong y_2 = (ulong)y[yOff + 2];
			ulong y_3 = (ulong)y[yOff + 3];
			ulong y_4 = (ulong)y[yOff + 4];
			ulong y_5 = (ulong)y[yOff + 5];
			ulong y_6 = (ulong)y[yOff + 6];
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
			zz[zzOff + 7] = (uint)c;
			for (int i = 1; i < 7; i++)
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
				zz[zzOff + 7] = (uint)c2;
			}
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x0005B3B4 File Offset: 0x000595B4
		public static uint MulAddTo(uint[] x, uint[] y, uint[] zz)
		{
			ulong y_0 = (ulong)y[0];
			ulong y_ = (ulong)y[1];
			ulong y_2 = (ulong)y[2];
			ulong y_3 = (ulong)y[3];
			ulong y_4 = (ulong)y[4];
			ulong y_5 = (ulong)y[5];
			ulong y_6 = (ulong)y[6];
			ulong zc = 0UL;
			for (int i = 0; i < 7; i++)
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
				zc += c + (ulong)zz[i + 7];
				zz[i + 7] = (uint)zc;
				zc >>= 32;
			}
			return (uint)zc;
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x0005B514 File Offset: 0x00059714
		public static uint MulAddTo(uint[] x, int xOff, uint[] y, int yOff, uint[] zz, int zzOff)
		{
			ulong y_0 = (ulong)y[yOff];
			ulong y_ = (ulong)y[yOff + 1];
			ulong y_2 = (ulong)y[yOff + 2];
			ulong y_3 = (ulong)y[yOff + 3];
			ulong y_4 = (ulong)y[yOff + 4];
			ulong y_5 = (ulong)y[yOff + 5];
			ulong y_6 = (ulong)y[yOff + 6];
			ulong zc = 0UL;
			for (int i = 0; i < 7; i++)
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
				zc += c + (ulong)zz[zzOff + 7];
				zz[zzOff + 7] = (uint)zc;
				zc >>= 32;
				zzOff++;
			}
			return (uint)zc;
		}

		// Token: 0x060013B4 RID: 5044 RVA: 0x0005B698 File Offset: 0x00059898
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
			return c + x8;
		}

		// Token: 0x060013B5 RID: 5045 RVA: 0x0005B7BC File Offset: 0x000599BC
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
			return (uint)c;
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x0005B858 File Offset: 0x00059A58
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
			return (uint)c;
		}

		// Token: 0x060013B7 RID: 5047 RVA: 0x0005B918 File Offset: 0x00059B18
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
			return (uint)c;
		}

		// Token: 0x060013B8 RID: 5048 RVA: 0x0005BA08 File Offset: 0x00059C08
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
				return global::Org.BouncyCastle.Math.Raw.Nat.IncAt(7, z, zOff, 4);
			}
			return 0U;
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x0005BA90 File Offset: 0x00059C90
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
				return global::Org.BouncyCastle.Math.Raw.Nat.IncAt(7, z, zOff, 3);
			}
			return 0U;
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x0005BAF4 File Offset: 0x00059CF4
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
				return global::Org.BouncyCastle.Math.Raw.Nat.IncAt(7, z, zOff, 3);
			}
			return 0U;
		}

		// Token: 0x060013BB RID: 5051 RVA: 0x0005BB5C File Offset: 0x00059D5C
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
			while (++i < 7);
			return (uint)c;
		}

		// Token: 0x060013BC RID: 5052 RVA: 0x0005BB90 File Offset: 0x00059D90
		public static void Square(uint[] x, uint[] zz)
		{
			ulong x_0 = (ulong)x[0];
			uint c = 0U;
			int i = 6;
			int j = 14;
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
			zz_9 += (zz_8 >> 32) + x_6 * x_3;
			zz_10 += (zz_9 >> 32) + x_6 * x_4;
			zz_11 += (zz_10 >> 32) + x_6 * x_5;
			zz_12 += zz_11 >> 32;
			w = (uint)zz_7;
			zz[7] = (w << 1 | c);
			c = w >> 31;
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
			w = zz[13] + (uint)(zz_12 >> 32);
			zz[13] = (w << 1 | c);
		}

		// Token: 0x060013BD RID: 5053 RVA: 0x0005BF60 File Offset: 0x0005A160
		public static void Square(uint[] x, int xOff, uint[] zz, int zzOff)
		{
			ulong x_0 = (ulong)x[xOff];
			uint c = 0U;
			int i = 6;
			int j = 14;
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
			zz_9 += (zz_8 >> 32) + x_6 * x_3;
			zz_10 += (zz_9 >> 32) + x_6 * x_4;
			zz_11 += (zz_10 >> 32) + x_6 * x_5;
			zz_12 += zz_11 >> 32;
			w = (uint)zz_7;
			zz[zzOff + 7] = (w << 1 | c);
			c = w >> 31;
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
			w = zz[zzOff + 13] + (uint)(zz_12 >> 32);
			zz[zzOff + 13] = (w << 1 | c);
		}

		// Token: 0x060013BE RID: 5054 RVA: 0x0005C374 File Offset: 0x0005A574
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
			return (int)c;
		}

		// Token: 0x060013BF RID: 5055 RVA: 0x0005C420 File Offset: 0x0005A620
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
			return (int)c;
		}

		// Token: 0x060013C0 RID: 5056 RVA: 0x0005C500 File Offset: 0x0005A700
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
			return (int)c;
		}

		// Token: 0x060013C1 RID: 5057 RVA: 0x0005C5D0 File Offset: 0x0005A7D0
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
			return (int)c;
		}

		// Token: 0x060013C2 RID: 5058 RVA: 0x0005C67C File Offset: 0x0005A87C
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
			return (int)c;
		}

		// Token: 0x060013C3 RID: 5059 RVA: 0x0005C74C File Offset: 0x0005A94C
		public static global::Org.BouncyCastle.Math.BigInteger ToBigInteger(uint[] x)
		{
			byte[] bs = new byte[28];
			for (int i = 0; i < 7; i++)
			{
				uint x_i = x[i];
				if (x_i != 0U)
				{
					global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(x_i, bs, 6 - i << 2);
				}
			}
			return new global::Org.BouncyCastle.Math.BigInteger(1, bs);
		}

		// Token: 0x060013C4 RID: 5060 RVA: 0x0005C787 File Offset: 0x0005A987
		public static void Zero(uint[] z)
		{
			z[0] = 0U;
			z[1] = 0U;
			z[2] = 0U;
			z[3] = 0U;
			z[4] = 0U;
			z[5] = 0U;
			z[6] = 0U;
		}

		// Token: 0x04000933 RID: 2355
		private const ulong M = 4294967295UL;
	}
}
