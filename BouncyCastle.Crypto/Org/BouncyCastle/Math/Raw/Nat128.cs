using System;
using Org.BouncyCastle.Crypto.Utilities;

namespace Org.BouncyCastle.Math.Raw
{
	// Token: 0x020001F2 RID: 498
	internal abstract class Nat128
	{
		// Token: 0x06001320 RID: 4896 RVA: 0x000566A4 File Offset: 0x000548A4
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
			return (uint)c;
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x00056710 File Offset: 0x00054910
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
			return (uint)c;
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x00056790 File Offset: 0x00054990
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
			return (uint)c;
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x000567FC File Offset: 0x000549FC
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
			return (uint)c;
		}

		// Token: 0x06001324 RID: 4900 RVA: 0x0005687C File Offset: 0x00054A7C
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
			return (uint)c;
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x00056912 File Offset: 0x00054B12
		public static void Copy(uint[] x, uint[] z)
		{
			z[0] = x[0];
			z[1] = x[1];
			z[2] = x[2];
			z[3] = x[3];
		}

		// Token: 0x06001326 RID: 4902 RVA: 0x0005692C File Offset: 0x00054B2C
		public static void Copy(uint[] x, int xOff, uint[] z, int zOff)
		{
			z[zOff] = x[xOff];
			z[zOff + 1] = x[xOff + 1];
			z[zOff + 2] = x[xOff + 2];
			z[zOff + 3] = x[xOff + 3];
		}

		// Token: 0x06001327 RID: 4903 RVA: 0x00056952 File Offset: 0x00054B52
		public static void Copy64(ulong[] x, ulong[] z)
		{
			z[0] = x[0];
			z[1] = x[1];
		}

		// Token: 0x06001328 RID: 4904 RVA: 0x00056960 File Offset: 0x00054B60
		public static void Copy64(ulong[] x, int xOff, ulong[] z, int zOff)
		{
			z[zOff] = x[xOff];
			z[zOff + 1] = x[xOff + 1];
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x00056972 File Offset: 0x00054B72
		public static uint[] Create()
		{
			return new uint[4];
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x0005697A File Offset: 0x00054B7A
		public static ulong[] Create64()
		{
			return new ulong[2];
		}

		// Token: 0x0600132B RID: 4907 RVA: 0x00056982 File Offset: 0x00054B82
		public static uint[] CreateExt()
		{
			return new uint[8];
		}

		// Token: 0x0600132C RID: 4908 RVA: 0x0005698A File Offset: 0x00054B8A
		public static ulong[] CreateExt64()
		{
			return new ulong[4];
		}

		// Token: 0x0600132D RID: 4909 RVA: 0x00056992 File Offset: 0x00054B92
		public static bool Diff(uint[] x, int xOff, uint[] y, int yOff, uint[] z, int zOff)
		{
			bool flag = global::Org.BouncyCastle.Math.Raw.Nat128.Gte(x, xOff, y, yOff);
			if (flag)
			{
				global::Org.BouncyCastle.Math.Raw.Nat128.Sub(x, xOff, y, yOff, z, zOff);
				return flag;
			}
			global::Org.BouncyCastle.Math.Raw.Nat128.Sub(y, yOff, x, xOff, z, zOff);
			return flag;
		}

		// Token: 0x0600132E RID: 4910 RVA: 0x000569C0 File Offset: 0x00054BC0
		public static bool Eq(uint[] x, uint[] y)
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

		// Token: 0x0600132F RID: 4911 RVA: 0x000569E4 File Offset: 0x00054BE4
		public static bool Eq64(ulong[] x, ulong[] y)
		{
			for (int i = 1; i >= 0; i--)
			{
				if (x[i] != y[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001330 RID: 4912 RVA: 0x00056A08 File Offset: 0x00054C08
		public static uint GetBit(uint[] x, int bit)
		{
			if (bit == 0)
			{
				return x[0] & 1U;
			}
			if ((bit & 127) != bit)
			{
				return 0U;
			}
			int w = bit >> 5;
			int b = bit & 31;
			return x[w] >> b & 1U;
		}

		// Token: 0x06001331 RID: 4913 RVA: 0x00056A3C File Offset: 0x00054C3C
		public static bool Gte(uint[] x, uint[] y)
		{
			for (int i = 3; i >= 0; i--)
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

		// Token: 0x06001332 RID: 4914 RVA: 0x00056A6C File Offset: 0x00054C6C
		public static bool Gte(uint[] x, int xOff, uint[] y, int yOff)
		{
			for (int i = 3; i >= 0; i--)
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

		// Token: 0x06001333 RID: 4915 RVA: 0x00056AA0 File Offset: 0x00054CA0
		public static bool IsOne(uint[] x)
		{
			if (x[0] != 1U)
			{
				return false;
			}
			for (int i = 1; i < 4; i++)
			{
				if (x[i] != 0U)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001334 RID: 4916 RVA: 0x00056ACC File Offset: 0x00054CCC
		public static bool IsOne64(ulong[] x)
		{
			if (x[0] != 1UL)
			{
				return false;
			}
			for (int i = 1; i < 2; i++)
			{
				if (x[i] != 0UL)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x00056AF8 File Offset: 0x00054CF8
		public static bool IsZero(uint[] x)
		{
			for (int i = 0; i < 4; i++)
			{
				if (x[i] != 0U)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001336 RID: 4918 RVA: 0x00056B1C File Offset: 0x00054D1C
		public static bool IsZero64(ulong[] x)
		{
			for (int i = 0; i < 2; i++)
			{
				if (x[i] != 0UL)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001337 RID: 4919 RVA: 0x00056B40 File Offset: 0x00054D40
		public static void Mul(uint[] x, uint[] y, uint[] zz)
		{
			ulong y_0 = (ulong)y[0];
			ulong y_ = (ulong)y[1];
			ulong y_2 = (ulong)y[2];
			ulong y_3 = (ulong)y[3];
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
			zz[4] = (uint)c;
			for (int i = 1; i < 4; i++)
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
				zz[i + 4] = (uint)c2;
			}
		}

		// Token: 0x06001338 RID: 4920 RVA: 0x00056C74 File Offset: 0x00054E74
		public static void Mul(uint[] x, int xOff, uint[] y, int yOff, uint[] zz, int zzOff)
		{
			ulong y_0 = (ulong)y[yOff];
			ulong y_ = (ulong)y[yOff + 1];
			ulong y_2 = (ulong)y[yOff + 2];
			ulong y_3 = (ulong)y[yOff + 3];
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
			zz[zzOff + 4] = (uint)c;
			for (int i = 1; i < 4; i++)
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
				zz[zzOff + 4] = (uint)c2;
			}
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x00056DD0 File Offset: 0x00054FD0
		public static uint MulAddTo(uint[] x, uint[] y, uint[] zz)
		{
			ulong y_0 = (ulong)y[0];
			ulong y_ = (ulong)y[1];
			ulong y_2 = (ulong)y[2];
			ulong y_3 = (ulong)y[3];
			ulong zc = 0UL;
			for (int i = 0; i < 4; i++)
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
				zc += c + (ulong)zz[i + 4];
				zz[i + 4] = (uint)zc;
				zc >>= 32;
			}
			return (uint)zc;
		}

		// Token: 0x0600133A RID: 4922 RVA: 0x00056EB8 File Offset: 0x000550B8
		public static uint MulAddTo(uint[] x, int xOff, uint[] y, int yOff, uint[] zz, int zzOff)
		{
			ulong y_0 = (ulong)y[yOff];
			ulong y_ = (ulong)y[yOff + 1];
			ulong y_2 = (ulong)y[yOff + 2];
			ulong y_3 = (ulong)y[yOff + 3];
			ulong zc = 0UL;
			for (int i = 0; i < 4; i++)
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
				zc += c + (ulong)zz[zzOff + 4];
				zz[zzOff + 4] = (uint)zc;
				zc >>= 32;
				zzOff++;
			}
			return (uint)zc;
		}

		// Token: 0x0600133B RID: 4923 RVA: 0x00056FB8 File Offset: 0x000551B8
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
			return c + x5;
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x00057064 File Offset: 0x00055264
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
			return (uint)c;
		}

		// Token: 0x0600133D RID: 4925 RVA: 0x000570F4 File Offset: 0x000552F4
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
			return (uint)c;
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x00057170 File Offset: 0x00055370
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
				return global::Org.BouncyCastle.Math.Raw.Nat.IncAt(4, z, zOff, 3);
			}
			return 0U;
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x000571D4 File Offset: 0x000553D4
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
				return global::Org.BouncyCastle.Math.Raw.Nat.IncAt(4, z, zOff, 3);
			}
			return 0U;
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x0005723C File Offset: 0x0005543C
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
				return global::Org.BouncyCastle.Math.Raw.Nat.IncAt(4, z, zOff, 2);
			}
			return 0U;
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x0005728C File Offset: 0x0005548C
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
			while (++i < 4);
			return (uint)c;
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x000572C0 File Offset: 0x000554C0
		public static void Square(uint[] x, uint[] zz)
		{
			ulong x_0 = (ulong)x[0];
			uint c = 0U;
			int i = 3;
			int j = 8;
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
			zz_6 += zz_5 >> 32;
			w = (uint)zz_4;
			zz[4] = (w << 1 | c);
			c = w >> 31;
			w = (uint)zz_5;
			zz[5] = (w << 1 | c);
			c = w >> 31;
			w = (uint)zz_6;
			zz[6] = (w << 1 | c);
			c = w >> 31;
			w = zz[7] + (uint)(zz_6 >> 32);
			zz[7] = (w << 1 | c);
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x00057464 File Offset: 0x00055664
		public static void Square(uint[] x, int xOff, uint[] zz, int zzOff)
		{
			ulong x_0 = (ulong)x[xOff];
			uint c = 0U;
			int i = 3;
			int j = 8;
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
			zz_6 += zz_5 >> 32;
			w = (uint)zz_4;
			zz[zzOff + 4] = (w << 1 | c);
			c = w >> 31;
			w = (uint)zz_5;
			zz[zzOff + 5] = (w << 1 | c);
			c = w >> 31;
			w = (uint)zz_6;
			zz[zzOff + 6] = (w << 1 | c);
			c = w >> 31;
			w = zz[zzOff + 7] + (uint)(zz_6 >> 32);
			zz[zzOff + 7] = (w << 1 | c);
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x0005762C File Offset: 0x0005582C
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
			return (int)c;
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x00057698 File Offset: 0x00055898
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
			return (int)c;
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x0005771C File Offset: 0x0005591C
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
			return (int)c;
		}

		// Token: 0x06001347 RID: 4935 RVA: 0x0005779C File Offset: 0x0005599C
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
			return (int)c;
		}

		// Token: 0x06001348 RID: 4936 RVA: 0x00057808 File Offset: 0x00055A08
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
			return (int)c;
		}

		// Token: 0x06001349 RID: 4937 RVA: 0x00057884 File Offset: 0x00055A84
		public static global::Org.BouncyCastle.Math.BigInteger ToBigInteger(uint[] x)
		{
			byte[] bs = new byte[16];
			for (int i = 0; i < 4; i++)
			{
				uint x_i = x[i];
				if (x_i != 0U)
				{
					global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(x_i, bs, 3 - i << 2);
				}
			}
			return new global::Org.BouncyCastle.Math.BigInteger(1, bs);
		}

		// Token: 0x0600134A RID: 4938 RVA: 0x000578C0 File Offset: 0x00055AC0
		public static global::Org.BouncyCastle.Math.BigInteger ToBigInteger64(ulong[] x)
		{
			byte[] bs = new byte[16];
			for (int i = 0; i < 2; i++)
			{
				ulong x_i = x[i];
				if (x_i != 0UL)
				{
					global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(x_i, bs, 1 - i << 3);
				}
			}
			return new global::Org.BouncyCastle.Math.BigInteger(1, bs);
		}

		// Token: 0x0600134B RID: 4939 RVA: 0x000578FB File Offset: 0x00055AFB
		public static void Zero(uint[] z)
		{
			z[0] = 0U;
			z[1] = 0U;
			z[2] = 0U;
			z[3] = 0U;
		}

		// Token: 0x04000930 RID: 2352
		private const ulong M = 4294967295UL;
	}
}
