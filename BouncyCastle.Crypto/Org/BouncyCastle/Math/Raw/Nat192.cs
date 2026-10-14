using System;
using Org.BouncyCastle.Crypto.Utilities;

namespace Org.BouncyCastle.Math.Raw
{
	// Token: 0x020001F4 RID: 500
	internal abstract class Nat192
	{
		// Token: 0x06001372 RID: 4978 RVA: 0x00058E50 File Offset: 0x00057050
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
			return (uint)c;
		}

		// Token: 0x06001373 RID: 4979 RVA: 0x00058EE8 File Offset: 0x000570E8
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
			return (uint)c;
		}

		// Token: 0x06001374 RID: 4980 RVA: 0x00058F9C File Offset: 0x0005719C
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
			return (uint)c;
		}

		// Token: 0x06001375 RID: 4981 RVA: 0x00059034 File Offset: 0x00057234
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
			return (uint)c;
		}

		// Token: 0x06001376 RID: 4982 RVA: 0x000590EC File Offset: 0x000572EC
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
			return (uint)c;
		}

		// Token: 0x06001377 RID: 4983 RVA: 0x000591C8 File Offset: 0x000573C8
		public static void Copy(uint[] x, uint[] z)
		{
			z[0] = x[0];
			z[1] = x[1];
			z[2] = x[2];
			z[3] = x[3];
			z[4] = x[4];
			z[5] = x[5];
		}

		// Token: 0x06001378 RID: 4984 RVA: 0x000591EE File Offset: 0x000573EE
		public static void Copy(uint[] x, int xOff, uint[] z, int zOff)
		{
			z[zOff] = x[xOff];
			z[zOff + 1] = x[xOff + 1];
			z[zOff + 2] = x[xOff + 2];
			z[zOff + 3] = x[xOff + 3];
			z[zOff + 4] = x[xOff + 4];
			z[zOff + 5] = x[xOff + 5];
		}

		// Token: 0x06001379 RID: 4985 RVA: 0x00059228 File Offset: 0x00057428
		public static void Copy64(ulong[] x, ulong[] z)
		{
			z[0] = x[0];
			z[1] = x[1];
			z[2] = x[2];
		}

		// Token: 0x0600137A RID: 4986 RVA: 0x0005923C File Offset: 0x0005743C
		public static void Copy64(ulong[] x, int xOff, ulong[] z, int zOff)
		{
			z[zOff] = x[xOff];
			z[zOff + 1] = x[xOff + 1];
			z[zOff + 2] = x[xOff + 2];
		}

		// Token: 0x0600137B RID: 4987 RVA: 0x00059258 File Offset: 0x00057458
		public static uint[] Create()
		{
			return new uint[6];
		}

		// Token: 0x0600137C RID: 4988 RVA: 0x00059260 File Offset: 0x00057460
		public static ulong[] Create64()
		{
			return new ulong[3];
		}

		// Token: 0x0600137D RID: 4989 RVA: 0x00059268 File Offset: 0x00057468
		public static uint[] CreateExt()
		{
			return new uint[12];
		}

		// Token: 0x0600137E RID: 4990 RVA: 0x00059271 File Offset: 0x00057471
		public static ulong[] CreateExt64()
		{
			return new ulong[6];
		}

		// Token: 0x0600137F RID: 4991 RVA: 0x00059279 File Offset: 0x00057479
		public static bool Diff(uint[] x, int xOff, uint[] y, int yOff, uint[] z, int zOff)
		{
			bool flag = global::Org.BouncyCastle.Math.Raw.Nat192.Gte(x, xOff, y, yOff);
			if (flag)
			{
				global::Org.BouncyCastle.Math.Raw.Nat192.Sub(x, xOff, y, yOff, z, zOff);
				return flag;
			}
			global::Org.BouncyCastle.Math.Raw.Nat192.Sub(y, yOff, x, xOff, z, zOff);
			return flag;
		}

		// Token: 0x06001380 RID: 4992 RVA: 0x000592A4 File Offset: 0x000574A4
		public static bool Eq(uint[] x, uint[] y)
		{
			for (int i = 5; i >= 0; i--)
			{
				if (x[i] != y[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001381 RID: 4993 RVA: 0x000592C8 File Offset: 0x000574C8
		public static bool Eq64(ulong[] x, ulong[] y)
		{
			for (int i = 2; i >= 0; i--)
			{
				if (x[i] != y[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001382 RID: 4994 RVA: 0x000592EC File Offset: 0x000574EC
		public static uint GetBit(uint[] x, int bit)
		{
			if (bit == 0)
			{
				return x[0] & 1U;
			}
			int w = bit >> 5;
			if (w < 0 || w >= 6)
			{
				return 0U;
			}
			int b = bit & 31;
			return x[w] >> b & 1U;
		}

		// Token: 0x06001383 RID: 4995 RVA: 0x00059320 File Offset: 0x00057520
		public static bool Gte(uint[] x, uint[] y)
		{
			for (int i = 5; i >= 0; i--)
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

		// Token: 0x06001384 RID: 4996 RVA: 0x00059350 File Offset: 0x00057550
		public static bool Gte(uint[] x, int xOff, uint[] y, int yOff)
		{
			for (int i = 5; i >= 0; i--)
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

		// Token: 0x06001385 RID: 4997 RVA: 0x00059384 File Offset: 0x00057584
		public static bool IsOne(uint[] x)
		{
			if (x[0] != 1U)
			{
				return false;
			}
			for (int i = 1; i < 6; i++)
			{
				if (x[i] != 0U)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x000593B0 File Offset: 0x000575B0
		public static bool IsOne64(ulong[] x)
		{
			if (x[0] != 1UL)
			{
				return false;
			}
			for (int i = 1; i < 3; i++)
			{
				if (x[i] != 0UL)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001387 RID: 4999 RVA: 0x000593DC File Offset: 0x000575DC
		public static bool IsZero(uint[] x)
		{
			for (int i = 0; i < 6; i++)
			{
				if (x[i] != 0U)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001388 RID: 5000 RVA: 0x00059400 File Offset: 0x00057600
		public static bool IsZero64(ulong[] x)
		{
			for (int i = 0; i < 3; i++)
			{
				if (x[i] != 0UL)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001389 RID: 5001 RVA: 0x00059424 File Offset: 0x00057624
		public static void Mul(uint[] x, uint[] y, uint[] zz)
		{
			ulong y_0 = (ulong)y[0];
			ulong y_ = (ulong)y[1];
			ulong y_2 = (ulong)y[2];
			ulong y_3 = (ulong)y[3];
			ulong y_4 = (ulong)y[4];
			ulong y_5 = (ulong)y[5];
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
			zz[6] = (uint)c;
			for (int i = 1; i < 6; i++)
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
				zz[i + 6] = (uint)c2;
			}
		}

		// Token: 0x0600138A RID: 5002 RVA: 0x000595D8 File Offset: 0x000577D8
		public static void Mul(uint[] x, int xOff, uint[] y, int yOff, uint[] zz, int zzOff)
		{
			ulong y_0 = (ulong)y[yOff];
			ulong y_ = (ulong)y[yOff + 1];
			ulong y_2 = (ulong)y[yOff + 2];
			ulong y_3 = (ulong)y[yOff + 3];
			ulong y_4 = (ulong)y[yOff + 4];
			ulong y_5 = (ulong)y[yOff + 5];
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
			zz[zzOff + 6] = (uint)c;
			for (int i = 1; i < 6; i++)
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
				zz[zzOff + 6] = (uint)c2;
			}
		}

		// Token: 0x0600138B RID: 5003 RVA: 0x000597C4 File Offset: 0x000579C4
		public static uint MulAddTo(uint[] x, uint[] y, uint[] zz)
		{
			ulong y_0 = (ulong)y[0];
			ulong y_ = (ulong)y[1];
			ulong y_2 = (ulong)y[2];
			ulong y_3 = (ulong)y[3];
			ulong y_4 = (ulong)y[4];
			ulong y_5 = (ulong)y[5];
			ulong zc = 0UL;
			for (int i = 0; i < 6; i++)
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
				zc += c + (ulong)zz[i + 6];
				zz[i + 6] = (uint)zc;
				zc >>= 32;
			}
			return (uint)zc;
		}

		// Token: 0x0600138C RID: 5004 RVA: 0x000598FC File Offset: 0x00057AFC
		public static uint MulAddTo(uint[] x, int xOff, uint[] y, int yOff, uint[] zz, int zzOff)
		{
			ulong y_0 = (ulong)y[yOff];
			ulong y_ = (ulong)y[yOff + 1];
			ulong y_2 = (ulong)y[yOff + 2];
			ulong y_3 = (ulong)y[yOff + 3];
			ulong y_4 = (ulong)y[yOff + 4];
			ulong y_5 = (ulong)y[yOff + 5];
			ulong zc = 0UL;
			for (int i = 0; i < 6; i++)
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
				zc += c + (ulong)zz[zzOff + 6];
				zz[zzOff + 6] = (uint)zc;
				zc >>= 32;
				zzOff++;
			}
			return (uint)zc;
		}

		// Token: 0x0600138D RID: 5005 RVA: 0x00059A54 File Offset: 0x00057C54
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
			return c + x7;
		}

		// Token: 0x0600138E RID: 5006 RVA: 0x00059B50 File Offset: 0x00057D50
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
			c += xVal * (ulong)yy[yyOff + 5] + (ulong)zz[zzOff + 5];
			zz[zzOff + 5] = (uint)c;
			c >>= 32;
			return (uint)c;
		}

		// Token: 0x0600138F RID: 5007 RVA: 0x00059C20 File Offset: 0x00057E20
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
				return global::Org.BouncyCastle.Math.Raw.Nat.IncAt(6, z, zOff, 4);
			}
			return 0U;
		}

		// Token: 0x06001390 RID: 5008 RVA: 0x00059CA8 File Offset: 0x00057EA8
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
				return global::Org.BouncyCastle.Math.Raw.Nat.IncAt(6, z, zOff, 3);
			}
			return 0U;
		}

		// Token: 0x06001391 RID: 5009 RVA: 0x00059D0C File Offset: 0x00057F0C
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
				return global::Org.BouncyCastle.Math.Raw.Nat.IncAt(6, z, zOff, 3);
			}
			return 0U;
		}

		// Token: 0x06001392 RID: 5010 RVA: 0x00059D74 File Offset: 0x00057F74
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
			while (++i < 6);
			return (uint)c;
		}

		// Token: 0x06001393 RID: 5011 RVA: 0x00059DA8 File Offset: 0x00057FA8
		public static void Square(uint[] x, uint[] zz)
		{
			ulong x_0 = (ulong)x[0];
			uint c = 0U;
			int i = 5;
			int j = 12;
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
			zz_8 += (zz_7 >> 32) + x_5 * x_3;
			zz_9 += (zz_8 >> 32) + x_5 * x_4;
			zz_10 += zz_9 >> 32;
			w = (uint)zz_6;
			zz[6] = (w << 1 | c);
			c = w >> 31;
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
			w = zz[11] + (uint)(zz_10 >> 32);
			zz[11] = (w << 1 | c);
		}

		// Token: 0x06001394 RID: 5012 RVA: 0x0005A0A8 File Offset: 0x000582A8
		public static void Square(uint[] x, int xOff, uint[] zz, int zzOff)
		{
			ulong x_0 = (ulong)x[xOff];
			uint c = 0U;
			int i = 5;
			int j = 12;
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
			zz_8 += (zz_7 >> 32) + x_5 * x_3;
			zz_9 += (zz_8 >> 32) + x_5 * x_4;
			zz_10 += zz_9 >> 32;
			w = (uint)zz_6;
			zz[zzOff + 6] = (w << 1 | c);
			c = w >> 31;
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
			w = zz[zzOff + 11] + (uint)(zz_10 >> 32);
			zz[zzOff + 11] = (w << 1 | c);
		}

		// Token: 0x06001395 RID: 5013 RVA: 0x0005A3E0 File Offset: 0x000585E0
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
			return (int)c;
		}

		// Token: 0x06001396 RID: 5014 RVA: 0x0005A478 File Offset: 0x00058678
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
			return (int)c;
		}

		// Token: 0x06001397 RID: 5015 RVA: 0x0005A538 File Offset: 0x00058738
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
			return (int)c;
		}

		// Token: 0x06001398 RID: 5016 RVA: 0x0005A5EC File Offset: 0x000587EC
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
			return (int)c;
		}

		// Token: 0x06001399 RID: 5017 RVA: 0x0005A684 File Offset: 0x00058884
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
			return (int)c;
		}

		// Token: 0x0600139A RID: 5018 RVA: 0x0005A738 File Offset: 0x00058938
		public static global::Org.BouncyCastle.Math.BigInteger ToBigInteger(uint[] x)
		{
			byte[] bs = new byte[24];
			for (int i = 0; i < 6; i++)
			{
				uint x_i = x[i];
				if (x_i != 0U)
				{
					global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(x_i, bs, 5 - i << 2);
				}
			}
			return new global::Org.BouncyCastle.Math.BigInteger(1, bs);
		}

		// Token: 0x0600139B RID: 5019 RVA: 0x0005A774 File Offset: 0x00058974
		public static global::Org.BouncyCastle.Math.BigInteger ToBigInteger64(ulong[] x)
		{
			byte[] bs = new byte[24];
			for (int i = 0; i < 3; i++)
			{
				ulong x_i = x[i];
				if (x_i != 0UL)
				{
					global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(x_i, bs, 2 - i << 3);
				}
			}
			return new global::Org.BouncyCastle.Math.BigInteger(1, bs);
		}

		// Token: 0x0600139C RID: 5020 RVA: 0x0005A7AF File Offset: 0x000589AF
		public static void Zero(uint[] z)
		{
			z[0] = 0U;
			z[1] = 0U;
			z[2] = 0U;
			z[3] = 0U;
			z[4] = 0U;
			z[5] = 0U;
		}

		// Token: 0x04000932 RID: 2354
		private const ulong M = 4294967295UL;
	}
}
