using System;
using Org.BouncyCastle.Crypto.Utilities;

namespace Org.BouncyCastle.Math.Raw
{
	// Token: 0x020001F3 RID: 499
	internal abstract class Nat160
	{
		// Token: 0x0600134D RID: 4941 RVA: 0x00057918 File Offset: 0x00055B18
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
			return (uint)c;
		}

		// Token: 0x0600134E RID: 4942 RVA: 0x00057998 File Offset: 0x00055B98
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
			return (uint)c;
		}

		// Token: 0x0600134F RID: 4943 RVA: 0x00057A34 File Offset: 0x00055C34
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
			return (uint)c;
		}

		// Token: 0x06001350 RID: 4944 RVA: 0x00057AB4 File Offset: 0x00055CB4
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
			return (uint)c;
		}

		// Token: 0x06001351 RID: 4945 RVA: 0x00057B60 File Offset: 0x00055D60
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
			return (uint)c;
		}

		// Token: 0x06001352 RID: 4946 RVA: 0x00057C19 File Offset: 0x00055E19
		public static void Copy(uint[] x, uint[] z)
		{
			z[0] = x[0];
			z[1] = x[1];
			z[2] = x[2];
			z[3] = x[3];
			z[4] = x[4];
		}

		// Token: 0x06001353 RID: 4947 RVA: 0x00057C39 File Offset: 0x00055E39
		public static void Copy(uint[] x, int xOff, uint[] z, int zOff)
		{
			z[zOff] = x[xOff];
			z[zOff + 1] = x[xOff + 1];
			z[zOff + 2] = x[xOff + 2];
			z[zOff + 3] = x[xOff + 3];
			z[zOff + 4] = x[xOff + 4];
		}

		// Token: 0x06001354 RID: 4948 RVA: 0x00057C69 File Offset: 0x00055E69
		public static uint[] Create()
		{
			return new uint[5];
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x00057C71 File Offset: 0x00055E71
		public static uint[] CreateExt()
		{
			return new uint[10];
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x00057C7A File Offset: 0x00055E7A
		public static bool Diff(uint[] x, int xOff, uint[] y, int yOff, uint[] z, int zOff)
		{
			bool flag = global::Org.BouncyCastle.Math.Raw.Nat160.Gte(x, xOff, y, yOff);
			if (flag)
			{
				global::Org.BouncyCastle.Math.Raw.Nat160.Sub(x, xOff, y, yOff, z, zOff);
				return flag;
			}
			global::Org.BouncyCastle.Math.Raw.Nat160.Sub(y, yOff, x, xOff, z, zOff);
			return flag;
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x00057CA8 File Offset: 0x00055EA8
		public static bool Eq(uint[] x, uint[] y)
		{
			for (int i = 4; i >= 0; i--)
			{
				if (x[i] != y[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x00057CCC File Offset: 0x00055ECC
		public static uint GetBit(uint[] x, int bit)
		{
			if (bit == 0)
			{
				return x[0] & 1U;
			}
			int w = bit >> 5;
			if (w < 0 || w >= 5)
			{
				return 0U;
			}
			int b = bit & 31;
			return x[w] >> b & 1U;
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x00057D00 File Offset: 0x00055F00
		public static bool Gte(uint[] x, uint[] y)
		{
			for (int i = 4; i >= 0; i--)
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

		// Token: 0x0600135A RID: 4954 RVA: 0x00057D30 File Offset: 0x00055F30
		public static bool Gte(uint[] x, int xOff, uint[] y, int yOff)
		{
			for (int i = 4; i >= 0; i--)
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

		// Token: 0x0600135B RID: 4955 RVA: 0x00057D64 File Offset: 0x00055F64
		public static bool IsOne(uint[] x)
		{
			if (x[0] != 1U)
			{
				return false;
			}
			for (int i = 1; i < 5; i++)
			{
				if (x[i] != 0U)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x00057D90 File Offset: 0x00055F90
		public static bool IsZero(uint[] x)
		{
			for (int i = 0; i < 5; i++)
			{
				if (x[i] != 0U)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x00057DB4 File Offset: 0x00055FB4
		public static void Mul(uint[] x, uint[] y, uint[] zz)
		{
			ulong y_0 = (ulong)y[0];
			ulong y_ = (ulong)y[1];
			ulong y_2 = (ulong)y[2];
			ulong y_3 = (ulong)y[3];
			ulong y_4 = (ulong)y[4];
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
			zz[5] = (uint)c;
			for (int i = 1; i < 5; i++)
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
				zz[i + 5] = (uint)c2;
			}
		}

		// Token: 0x0600135E RID: 4958 RVA: 0x00057F28 File Offset: 0x00056128
		public static void Mul(uint[] x, int xOff, uint[] y, int yOff, uint[] zz, int zzOff)
		{
			ulong y_0 = (ulong)y[yOff];
			ulong y_ = (ulong)y[yOff + 1];
			ulong y_2 = (ulong)y[yOff + 2];
			ulong y_3 = (ulong)y[yOff + 3];
			ulong y_4 = (ulong)y[yOff + 4];
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
			zz[zzOff + 5] = (uint)c;
			for (int i = 1; i < 5; i++)
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
				zz[zzOff + 5] = (uint)c2;
			}
		}

		// Token: 0x0600135F RID: 4959 RVA: 0x000580CC File Offset: 0x000562CC
		public static uint MulAddTo(uint[] x, uint[] y, uint[] zz)
		{
			ulong y_0 = (ulong)y[0];
			ulong y_ = (ulong)y[1];
			ulong y_2 = (ulong)y[2];
			ulong y_3 = (ulong)y[3];
			ulong y_4 = (ulong)y[4];
			ulong zc = 0UL;
			for (int i = 0; i < 5; i++)
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
				zc += c + (ulong)zz[i + 5];
				zz[i + 5] = (uint)zc;
				zc >>= 32;
			}
			return (uint)zc;
		}

		// Token: 0x06001360 RID: 4960 RVA: 0x000581DC File Offset: 0x000563DC
		public static uint MulAddTo(uint[] x, int xOff, uint[] y, int yOff, uint[] zz, int zzOff)
		{
			ulong y_0 = (ulong)y[yOff];
			ulong y_ = (ulong)y[yOff + 1];
			ulong y_2 = (ulong)y[yOff + 2];
			ulong y_3 = (ulong)y[yOff + 3];
			ulong y_4 = (ulong)y[yOff + 4];
			ulong zc = 0UL;
			for (int i = 0; i < 5; i++)
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
				zc += c + (ulong)zz[zzOff + 5];
				zz[zzOff + 5] = (uint)zc;
				zc >>= 32;
				zzOff++;
			}
			return (uint)zc;
		}

		// Token: 0x06001361 RID: 4961 RVA: 0x00058308 File Offset: 0x00056508
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
			return c + x6;
		}

		// Token: 0x06001362 RID: 4962 RVA: 0x000583DC File Offset: 0x000565DC
		public static uint MulWordAddExt(uint x, uint[] yy, int yyOff, uint[] zz, int zzOff)
		{
			ulong c = 0UL;
			ulong xVal = (ulong)x;
			c += xVal * (ulong)yy[yyOff] + (ulong)zz[zzOff];
			zz[zzOff] = (uint)c;
			c >>= 32;
			c += xVal * (ulong)yy[yyOff + 1] + (ulong)zz[zzOff + 1];
			zz[zzOff + 1] = (uint)c;
			c >>= 32;
			c += xVal * (ulong)yy[yyOff + 2] + (ulong)zz[zzOff + 2];
			zz[zzOff + 2] = (uint)c;
			c >>= 32;
			c += xVal * (ulong)yy[yyOff + 3] + (ulong)zz[zzOff + 3];
			zz[zzOff + 3] = (uint)c;
			c >>= 32;
			c += xVal * (ulong)yy[yyOff + 4] + (ulong)zz[zzOff + 4];
			zz[zzOff + 4] = (uint)c;
			c >>= 32;
			return (uint)c;
		}

		// Token: 0x06001363 RID: 4963 RVA: 0x0005848C File Offset: 0x0005668C
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
				return global::Org.BouncyCastle.Math.Raw.Nat.IncAt(5, z, zOff, 4);
			}
			return 0U;
		}

		// Token: 0x06001364 RID: 4964 RVA: 0x00058514 File Offset: 0x00056714
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
				return global::Org.BouncyCastle.Math.Raw.Nat.IncAt(5, z, zOff, 3);
			}
			return 0U;
		}

		// Token: 0x06001365 RID: 4965 RVA: 0x00058578 File Offset: 0x00056778
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
				return global::Org.BouncyCastle.Math.Raw.Nat.IncAt(5, z, zOff, 3);
			}
			return 0U;
		}

		// Token: 0x06001366 RID: 4966 RVA: 0x000585E0 File Offset: 0x000567E0
		public static uint MulWordsAdd(uint x, uint y, uint[] z, int zOff)
		{
			ulong c = 0UL;
			ulong xVal = (ulong)x;
			ulong yVal = (ulong)y;
			c += yVal * xVal + (ulong)z[zOff];
			z[zOff] = (uint)c;
			c >>= 32;
			c += (ulong)z[zOff + 1];
			z[zOff + 1] = (uint)c;
			c >>= 32;
			if (c != 0UL)
			{
				return global::Org.BouncyCastle.Math.Raw.Nat.IncAt(5, z, zOff, 2);
			}
			return 0U;
		}

		// Token: 0x06001367 RID: 4967 RVA: 0x00058630 File Offset: 0x00056830
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
			while (++i < 5);
			return (uint)c;
		}

		// Token: 0x06001368 RID: 4968 RVA: 0x00058664 File Offset: 0x00056864
		public static void Square(uint[] x, uint[] zz)
		{
			ulong x_0 = (ulong)x[0];
			uint c = 0U;
			int i = 4;
			int j = 10;
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
			zz_7 += (zz_6 >> 32) + x_4 * x_3;
			zz_8 += zz_7 >> 32;
			w = (uint)zz_5;
			zz[5] = (w << 1 | c);
			c = w >> 31;
			w = (uint)zz_6;
			zz[6] = (w << 1 | c);
			c = w >> 31;
			w = (uint)zz_7;
			zz[7] = (w << 1 | c);
			c = w >> 31;
			w = (uint)zz_8;
			zz[8] = (w << 1 | c);
			c = w >> 31;
			w = zz[9] + (uint)(zz_8 >> 32);
			zz[9] = (w << 1 | c);
		}

		// Token: 0x06001369 RID: 4969 RVA: 0x000588A8 File Offset: 0x00056AA8
		public static void Square(uint[] x, int xOff, uint[] zz, int zzOff)
		{
			ulong x_0 = (ulong)x[xOff];
			uint c = 0U;
			int i = 4;
			int j = 10;
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
			zz_7 += (zz_6 >> 32) + x_4 * x_3;
			zz_8 += zz_7 >> 32;
			w = (uint)zz_5;
			zz[zzOff + 5] = (w << 1 | c);
			c = w >> 31;
			w = (uint)zz_6;
			zz[zzOff + 6] = (w << 1 | c);
			c = w >> 31;
			w = (uint)zz_7;
			zz[zzOff + 7] = (w << 1 | c);
			c = w >> 31;
			w = (uint)zz_8;
			zz[zzOff + 8] = (w << 1 | c);
			c = w >> 31;
			w = zz[zzOff + 9] + (uint)(zz_8 >> 32);
			zz[zzOff + 9] = (w << 1 | c);
		}

		// Token: 0x0600136A RID: 4970 RVA: 0x00058B1C File Offset: 0x00056D1C
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
			return (int)c;
		}

		// Token: 0x0600136B RID: 4971 RVA: 0x00058B9C File Offset: 0x00056D9C
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
			return (int)c;
		}

		// Token: 0x0600136C RID: 4972 RVA: 0x00058C40 File Offset: 0x00056E40
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
			return (int)c;
		}

		// Token: 0x0600136D RID: 4973 RVA: 0x00058CDC File Offset: 0x00056EDC
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
			return (int)c;
		}

		// Token: 0x0600136E RID: 4974 RVA: 0x00058D5C File Offset: 0x00056F5C
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
			return (int)c;
		}

		// Token: 0x0600136F RID: 4975 RVA: 0x00058DF4 File Offset: 0x00056FF4
		public static global::Org.BouncyCastle.Math.BigInteger ToBigInteger(uint[] x)
		{
			byte[] bs = new byte[20];
			for (int i = 0; i < 5; i++)
			{
				uint x_i = x[i];
				if (x_i != 0U)
				{
					global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(x_i, bs, 4 - i << 2);
				}
			}
			return new global::Org.BouncyCastle.Math.BigInteger(1, bs);
		}

		// Token: 0x06001370 RID: 4976 RVA: 0x00058E2F File Offset: 0x0005702F
		public static void Zero(uint[] z)
		{
			z[0] = 0U;
			z[1] = 0U;
			z[2] = 0U;
			z[3] = 0U;
			z[4] = 0U;
		}

		// Token: 0x04000931 RID: 2353
		private const ulong M = 4294967295UL;
	}
}
