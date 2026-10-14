using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Math.EC.Multiplier
{
	// Token: 0x02000235 RID: 565
	public abstract class WNafUtilities
	{
		// Token: 0x060016FA RID: 5882 RVA: 0x0006FCB0 File Offset: 0x0006DEB0
		public static void ConfigureBasepoint(global::Org.BouncyCastle.Math.EC.ECPoint p)
		{
			global::Org.BouncyCastle.Math.EC.ECCurve c = p.Curve;
			if (c == null)
			{
				return;
			}
			global::Org.BouncyCastle.Math.BigInteger i = c.Order;
			int bits = (i == null) ? (c.FieldSize + 1) : i.BitLength;
			int confWidth = global::System.Math.Min(global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.MAX_WIDTH, global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GetWindowSize(bits) + 3);
			c.Precompute(p, global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.PRECOMP_NAME, new global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.ConfigureBasepointCallback(c, confWidth));
		}

		// Token: 0x060016FB RID: 5883 RVA: 0x0006FD0C File Offset: 0x0006DF0C
		public static int[] GenerateCompactNaf(global::Org.BouncyCastle.Math.BigInteger k)
		{
			if (k.BitLength >> 16 != 0)
			{
				throw new global::System.ArgumentException("must have bitlength < 2^16", "k");
			}
			if (k.SignValue == 0)
			{
				return global::Org.BouncyCastle.Utilities.Arrays.EmptyInts;
			}
			global::Org.BouncyCastle.Math.BigInteger bigInteger = k.ShiftLeft(1).Add(k);
			int bits = bigInteger.BitLength;
			int[] naf = new int[bits >> 1];
			global::Org.BouncyCastle.Math.BigInteger diff = bigInteger.Xor(k);
			int highBit = bits - 1;
			int length = 0;
			int zeroes = 0;
			for (int i = 1; i < highBit; i++)
			{
				if (!diff.TestBit(i))
				{
					zeroes++;
				}
				else
				{
					int digit = k.TestBit(i) ? -1 : 1;
					naf[length++] = (digit << 16 | zeroes);
					zeroes = 1;
					i++;
				}
			}
			naf[length++] = (65536 | zeroes);
			if (naf.Length > length)
			{
				naf = global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.Trim(naf, length);
			}
			return naf;
		}

		// Token: 0x060016FC RID: 5884 RVA: 0x0006FDE0 File Offset: 0x0006DFE0
		public static int[] GenerateCompactWindowNaf(int width, global::Org.BouncyCastle.Math.BigInteger k)
		{
			if (width == 2)
			{
				return global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GenerateCompactNaf(k);
			}
			if (width < 2 || width > 16)
			{
				throw new global::System.ArgumentException("must be in the range [2, 16]", "width");
			}
			if (k.BitLength >> 16 != 0)
			{
				throw new global::System.ArgumentException("must have bitlength < 2^16", "k");
			}
			if (k.SignValue == 0)
			{
				return global::Org.BouncyCastle.Utilities.Arrays.EmptyInts;
			}
			int[] wnaf = new int[k.BitLength / width + 1];
			int pow2 = 1 << width;
			int mask = pow2 - 1;
			int sign = pow2 >> 1;
			bool carry = false;
			int length = 0;
			int pos = 0;
			while (pos <= k.BitLength)
			{
				if (k.TestBit(pos) == carry)
				{
					pos++;
				}
				else
				{
					k = k.ShiftRight(pos);
					int digit = k.IntValue & mask;
					if (carry)
					{
						digit++;
					}
					carry = ((digit & sign) != 0);
					if (carry)
					{
						digit -= pow2;
					}
					int zeroes = (length > 0) ? (pos - 1) : pos;
					wnaf[length++] = (digit << 16 | zeroes);
					pos = width;
				}
			}
			if (wnaf.Length > length)
			{
				wnaf = global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.Trim(wnaf, length);
			}
			return wnaf;
		}

		// Token: 0x060016FD RID: 5885 RVA: 0x0006FEE8 File Offset: 0x0006E0E8
		public static byte[] GenerateJsf(global::Org.BouncyCastle.Math.BigInteger g, global::Org.BouncyCastle.Math.BigInteger h)
		{
			byte[] jsf = new byte[global::System.Math.Max(g.BitLength, h.BitLength) + 1];
			global::Org.BouncyCastle.Math.BigInteger k0 = g;
			global::Org.BouncyCastle.Math.BigInteger k = h;
			int i = 0;
			int d0 = 0;
			int d = 0;
			int offset = 0;
			while ((d0 | d) != 0 || k0.BitLength > offset || k.BitLength > offset)
			{
				int n0 = (int)(((uint)k0.IntValue >> offset) + (uint)d0 & 7U);
				int n = (int)(((uint)k.IntValue >> offset) + (uint)d & 7U);
				int u0 = n0 & 1;
				if (u0 != 0)
				{
					u0 -= (n0 & 2);
					if (n0 + u0 == 4 && (n & 3) == 2)
					{
						u0 = -u0;
					}
				}
				int u = n & 1;
				if (u != 0)
				{
					u -= (n & 2);
					if (n + u == 4 && (n0 & 3) == 2)
					{
						u = -u;
					}
				}
				if (d0 << 1 == 1 + u0)
				{
					d0 ^= 1;
				}
				if (d << 1 == 1 + u)
				{
					d ^= 1;
				}
				if (++offset == 30)
				{
					offset = 0;
					k0 = k0.ShiftRight(30);
					k = k.ShiftRight(30);
				}
				jsf[i++] = (byte)(u0 << 4 | (u & 15));
			}
			if (jsf.Length > i)
			{
				jsf = global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.Trim(jsf, i);
			}
			return jsf;
		}

		// Token: 0x060016FE RID: 5886 RVA: 0x0007001C File Offset: 0x0006E21C
		public static byte[] GenerateNaf(global::Org.BouncyCastle.Math.BigInteger k)
		{
			if (k.SignValue == 0)
			{
				return global::Org.BouncyCastle.Utilities.Arrays.EmptyBytes;
			}
			global::Org.BouncyCastle.Math.BigInteger bigInteger = k.ShiftLeft(1).Add(k);
			int digits = bigInteger.BitLength - 1;
			byte[] naf = new byte[digits];
			global::Org.BouncyCastle.Math.BigInteger diff = bigInteger.Xor(k);
			for (int i = 1; i < digits; i++)
			{
				if (diff.TestBit(i))
				{
					naf[i - 1] = (byte)(k.TestBit(i) ? -1 : 1);
					i++;
				}
			}
			naf[digits - 1] = 1;
			return naf;
		}

		// Token: 0x060016FF RID: 5887 RVA: 0x00070090 File Offset: 0x0006E290
		public static byte[] GenerateWindowNaf(int width, global::Org.BouncyCastle.Math.BigInteger k)
		{
			if (width == 2)
			{
				return global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GenerateNaf(k);
			}
			if (width < 2 || width > 8)
			{
				throw new global::System.ArgumentException("must be in the range [2, 8]", "width");
			}
			if (k.SignValue == 0)
			{
				return global::Org.BouncyCastle.Utilities.Arrays.EmptyBytes;
			}
			byte[] wnaf = new byte[k.BitLength + 1];
			int pow2 = 1 << width;
			int mask = pow2 - 1;
			int sign = pow2 >> 1;
			bool carry = false;
			int length = 0;
			int pos = 0;
			while (pos <= k.BitLength)
			{
				if (k.TestBit(pos) == carry)
				{
					pos++;
				}
				else
				{
					k = k.ShiftRight(pos);
					int digit = k.IntValue & mask;
					if (carry)
					{
						digit++;
					}
					carry = ((digit & sign) != 0);
					if (carry)
					{
						digit -= pow2;
					}
					length += ((length > 0) ? (pos - 1) : pos);
					wnaf[length++] = (byte)digit;
					pos = width;
				}
			}
			if (wnaf.Length > length)
			{
				wnaf = global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.Trim(wnaf, length);
			}
			return wnaf;
		}

		// Token: 0x06001700 RID: 5888 RVA: 0x00070177 File Offset: 0x0006E377
		public static int GetNafWeight(global::Org.BouncyCastle.Math.BigInteger k)
		{
			if (k.SignValue == 0)
			{
				return 0;
			}
			return k.ShiftLeft(1).Add(k).Xor(k).BitCount;
		}

		// Token: 0x06001701 RID: 5889 RVA: 0x0007019B File Offset: 0x0006E39B
		public static global::Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo GetWNafPreCompInfo(global::Org.BouncyCastle.Math.EC.ECPoint p)
		{
			return global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GetWNafPreCompInfo(p.Curve.GetPreCompInfo(p, global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.PRECOMP_NAME));
		}

		// Token: 0x06001702 RID: 5890 RVA: 0x000701B3 File Offset: 0x0006E3B3
		public static global::Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo GetWNafPreCompInfo(global::Org.BouncyCastle.Math.EC.Multiplier.PreCompInfo preCompInfo)
		{
			return preCompInfo as global::Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo;
		}

		// Token: 0x06001703 RID: 5891 RVA: 0x000701BB File Offset: 0x0006E3BB
		public static int GetWindowSize(int bits)
		{
			return global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GetWindowSize(bits, global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.DEFAULT_WINDOW_SIZE_CUTOFFS, global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.MAX_WIDTH);
		}

		// Token: 0x06001704 RID: 5892 RVA: 0x000701CD File Offset: 0x0006E3CD
		public static int GetWindowSize(int bits, int maxWidth)
		{
			return global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GetWindowSize(bits, global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.DEFAULT_WINDOW_SIZE_CUTOFFS, maxWidth);
		}

		// Token: 0x06001705 RID: 5893 RVA: 0x000701DB File Offset: 0x0006E3DB
		public static int GetWindowSize(int bits, int[] windowSizeCutoffs)
		{
			return global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GetWindowSize(bits, windowSizeCutoffs, global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.MAX_WIDTH);
		}

		// Token: 0x06001706 RID: 5894 RVA: 0x000701EC File Offset: 0x0006E3EC
		public static int GetWindowSize(int bits, int[] windowSizeCutoffs, int maxWidth)
		{
			int w = 0;
			while (w < windowSizeCutoffs.Length && bits >= windowSizeCutoffs[w])
			{
				w++;
			}
			return global::System.Math.Max(2, global::System.Math.Min(maxWidth, w + 2));
		}

		// Token: 0x06001707 RID: 5895 RVA: 0x0007021C File Offset: 0x0006E41C
		[global::System.Obsolete]
		public static global::Org.BouncyCastle.Math.EC.ECPoint MapPointWithPrecomp(global::Org.BouncyCastle.Math.EC.ECPoint p, int minWidth, bool includeNegated, global::Org.BouncyCastle.Math.EC.ECPointMap pointMap)
		{
			global::Org.BouncyCastle.Math.EC.ECCurve curve = p.Curve;
			global::Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo infoP = global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.Precompute(p, minWidth, includeNegated);
			global::Org.BouncyCastle.Math.EC.ECPoint q = pointMap.Map(p);
			curve.Precompute(q, global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.PRECOMP_NAME, new global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.MapPointCallback(infoP, includeNegated, pointMap));
			return q;
		}

		// Token: 0x06001708 RID: 5896 RVA: 0x00070255 File Offset: 0x0006E455
		public static global::Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo Precompute(global::Org.BouncyCastle.Math.EC.ECPoint p, int minWidth, bool includeNegated)
		{
			return (global::Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo)p.Curve.Precompute(p, global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.PRECOMP_NAME, new global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.PrecomputeCallback(p, minWidth, includeNegated));
		}

		// Token: 0x06001709 RID: 5897 RVA: 0x00070275 File Offset: 0x0006E475
		public static global::Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo PrecomputeWithPointMap(global::Org.BouncyCastle.Math.EC.ECPoint p, global::Org.BouncyCastle.Math.EC.ECPointMap pointMap, global::Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo fromWNaf, bool includeNegated)
		{
			return (global::Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo)p.Curve.Precompute(p, global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.PRECOMP_NAME, new global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.PrecomputeWithPointMapCallback(p, pointMap, fromWNaf, includeNegated));
		}

		// Token: 0x0600170A RID: 5898 RVA: 0x00070298 File Offset: 0x0006E498
		private static byte[] Trim(byte[] a, int length)
		{
			byte[] result = new byte[length];
			global::System.Array.Copy(a, 0, result, 0, result.Length);
			return result;
		}

		// Token: 0x0600170B RID: 5899 RVA: 0x000702BC File Offset: 0x0006E4BC
		private static int[] Trim(int[] a, int length)
		{
			int[] result = new int[length];
			global::System.Array.Copy(a, 0, result, 0, result.Length);
			return result;
		}

		// Token: 0x0600170C RID: 5900 RVA: 0x000702E0 File Offset: 0x0006E4E0
		private static global::Org.BouncyCastle.Math.EC.ECPoint[] ResizeTable(global::Org.BouncyCastle.Math.EC.ECPoint[] a, int length)
		{
			global::Org.BouncyCastle.Math.EC.ECPoint[] result = new global::Org.BouncyCastle.Math.EC.ECPoint[length];
			global::System.Array.Copy(a, 0, result, 0, a.Length);
			return result;
		}

		// Token: 0x040009E2 RID: 2530
		public static readonly string PRECOMP_NAME = "bc_wnaf";

		// Token: 0x040009E3 RID: 2531
		private static readonly int[] DEFAULT_WINDOW_SIZE_CUTOFFS = new int[]
		{
			13,
			41,
			121,
			337,
			897,
			2305
		};

		// Token: 0x040009E4 RID: 2532
		private static readonly int MAX_WIDTH = 16;

		// Token: 0x040009E5 RID: 2533
		private static readonly global::Org.BouncyCastle.Math.EC.ECPoint[] EMPTY_POINTS = new global::Org.BouncyCastle.Math.EC.ECPoint[0];

		// Token: 0x020007CE RID: 1998
		private class ConfigureBasepointCallback : global::Org.BouncyCastle.Math.EC.Multiplier.IPreCompCallback
		{
			// Token: 0x06004577 RID: 17783 RVA: 0x00133721 File Offset: 0x00131921
			internal ConfigureBasepointCallback(global::Org.BouncyCastle.Math.EC.ECCurve curve, int confWidth)
			{
				this.m_curve = curve;
				this.m_confWidth = confWidth;
			}

			// Token: 0x06004578 RID: 17784 RVA: 0x00133738 File Offset: 0x00131938
			public global::Org.BouncyCastle.Math.EC.Multiplier.PreCompInfo Precompute(global::Org.BouncyCastle.Math.EC.Multiplier.PreCompInfo existing)
			{
				global::Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo existingWNaf = existing as global::Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo;
				if (existingWNaf != null && existingWNaf.ConfWidth == this.m_confWidth)
				{
					existingWNaf.PromotionCountdown = 0;
					return existingWNaf;
				}
				global::Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo result = new global::Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo();
				result.PromotionCountdown = 0;
				result.ConfWidth = this.m_confWidth;
				if (existingWNaf != null)
				{
					result.PreComp = existingWNaf.PreComp;
					result.PreCompNeg = existingWNaf.PreCompNeg;
					result.Twice = existingWNaf.Twice;
					result.Width = existingWNaf.Width;
				}
				return result;
			}

			// Token: 0x0400240D RID: 9229
			private readonly global::Org.BouncyCastle.Math.EC.ECCurve m_curve;

			// Token: 0x0400240E RID: 9230
			private readonly int m_confWidth;
		}

		// Token: 0x020007CF RID: 1999
		private class MapPointCallback : global::Org.BouncyCastle.Math.EC.Multiplier.IPreCompCallback
		{
			// Token: 0x06004579 RID: 17785 RVA: 0x001337B3 File Offset: 0x001319B3
			internal MapPointCallback(global::Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo infoP, bool includeNegated, global::Org.BouncyCastle.Math.EC.ECPointMap pointMap)
			{
				this.m_infoP = infoP;
				this.m_includeNegated = includeNegated;
				this.m_pointMap = pointMap;
			}

			// Token: 0x0600457A RID: 17786 RVA: 0x001337D0 File Offset: 0x001319D0
			public global::Org.BouncyCastle.Math.EC.Multiplier.PreCompInfo Precompute(global::Org.BouncyCastle.Math.EC.Multiplier.PreCompInfo existing)
			{
				global::Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo result = new global::Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo();
				result.ConfWidth = this.m_infoP.ConfWidth;
				global::Org.BouncyCastle.Math.EC.ECPoint twiceP = this.m_infoP.Twice;
				if (twiceP != null)
				{
					global::Org.BouncyCastle.Math.EC.ECPoint twiceQ = this.m_pointMap.Map(twiceP);
					result.Twice = twiceQ;
				}
				global::Org.BouncyCastle.Math.EC.ECPoint[] preCompP = this.m_infoP.PreComp;
				global::Org.BouncyCastle.Math.EC.ECPoint[] preCompQ = new global::Org.BouncyCastle.Math.EC.ECPoint[preCompP.Length];
				for (int i = 0; i < preCompP.Length; i++)
				{
					preCompQ[i] = this.m_pointMap.Map(preCompP[i]);
				}
				result.PreComp = preCompQ;
				result.Width = this.m_infoP.Width;
				if (this.m_includeNegated)
				{
					global::Org.BouncyCastle.Math.EC.ECPoint[] preCompNegQ = new global::Org.BouncyCastle.Math.EC.ECPoint[preCompQ.Length];
					for (int j = 0; j < preCompNegQ.Length; j++)
					{
						preCompNegQ[j] = preCompQ[j].Negate();
					}
					result.PreCompNeg = preCompNegQ;
				}
				return result;
			}

			// Token: 0x0400240F RID: 9231
			private readonly global::Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo m_infoP;

			// Token: 0x04002410 RID: 9232
			private readonly bool m_includeNegated;

			// Token: 0x04002411 RID: 9233
			private readonly global::Org.BouncyCastle.Math.EC.ECPointMap m_pointMap;
		}

		// Token: 0x020007D0 RID: 2000
		private class PrecomputeCallback : global::Org.BouncyCastle.Math.EC.Multiplier.IPreCompCallback
		{
			// Token: 0x0600457B RID: 17787 RVA: 0x001338A7 File Offset: 0x00131AA7
			internal PrecomputeCallback(global::Org.BouncyCastle.Math.EC.ECPoint p, int minWidth, bool includeNegated)
			{
				this.m_p = p;
				this.m_minWidth = minWidth;
				this.m_includeNegated = includeNegated;
			}

			// Token: 0x0600457C RID: 17788 RVA: 0x001338C4 File Offset: 0x00131AC4
			public global::Org.BouncyCastle.Math.EC.Multiplier.PreCompInfo Precompute(global::Org.BouncyCastle.Math.EC.Multiplier.PreCompInfo existing)
			{
				global::Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo existingWNaf = existing as global::Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo;
				int width = global::System.Math.Max(2, global::System.Math.Min(global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.MAX_WIDTH, this.m_minWidth));
				int reqPreCompLen = 1 << width - 2;
				if (this.CheckExisting(existingWNaf, width, reqPreCompLen, this.m_includeNegated))
				{
					existingWNaf.DecrementPromotionCountdown();
					return existingWNaf;
				}
				global::Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo result = new global::Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo();
				global::Org.BouncyCastle.Math.EC.ECCurve c = this.m_p.Curve;
				global::Org.BouncyCastle.Math.EC.ECPoint[] preComp = null;
				global::Org.BouncyCastle.Math.EC.ECPoint[] preCompNeg = null;
				global::Org.BouncyCastle.Math.EC.ECPoint twiceP = null;
				if (existingWNaf != null)
				{
					int promotionCountdown = existingWNaf.DecrementPromotionCountdown();
					result.PromotionCountdown = promotionCountdown;
					int confWidth = existingWNaf.ConfWidth;
					result.ConfWidth = confWidth;
					preComp = existingWNaf.PreComp;
					preCompNeg = existingWNaf.PreCompNeg;
					twiceP = existingWNaf.Twice;
				}
				width = global::System.Math.Min(global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.MAX_WIDTH, global::System.Math.Max(result.ConfWidth, width));
				reqPreCompLen = 1 << width - 2;
				int iniPreCompLen = 0;
				if (preComp == null)
				{
					preComp = global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.EMPTY_POINTS;
				}
				else
				{
					iniPreCompLen = preComp.Length;
				}
				if (iniPreCompLen < reqPreCompLen)
				{
					preComp = global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.ResizeTable(preComp, reqPreCompLen);
					if (reqPreCompLen == 1)
					{
						preComp[0] = this.m_p.Normalize();
					}
					else
					{
						int curPreCompLen = iniPreCompLen;
						if (curPreCompLen == 0)
						{
							preComp[0] = this.m_p;
							curPreCompLen = 1;
						}
						global::Org.BouncyCastle.Math.EC.ECFieldElement iso = null;
						if (reqPreCompLen == 2)
						{
							preComp[1] = this.m_p.ThreeTimes();
						}
						else
						{
							global::Org.BouncyCastle.Math.EC.ECPoint isoTwiceP = twiceP;
							global::Org.BouncyCastle.Math.EC.ECPoint last = preComp[curPreCompLen - 1];
							if (isoTwiceP == null)
							{
								isoTwiceP = preComp[0].Twice();
								twiceP = isoTwiceP;
								if (!twiceP.IsInfinity && global::Org.BouncyCastle.Math.EC.ECAlgorithms.IsFpCurve(c) && c.FieldSize >= 64)
								{
									int coordinateSystem = c.CoordinateSystem;
									if (coordinateSystem - 2 <= 2)
									{
										iso = twiceP.GetZCoord(0);
										isoTwiceP = c.CreatePoint(twiceP.XCoord.ToBigInteger(), twiceP.YCoord.ToBigInteger());
										global::Org.BouncyCastle.Math.EC.ECFieldElement iso2 = iso.Square();
										global::Org.BouncyCastle.Math.EC.ECFieldElement iso3 = iso2.Multiply(iso);
										last = last.ScaleX(iso2).ScaleY(iso3);
										if (iniPreCompLen == 0)
										{
											preComp[0] = last;
										}
									}
								}
							}
							while (curPreCompLen < reqPreCompLen)
							{
								last = (preComp[curPreCompLen++] = last.Add(isoTwiceP));
							}
						}
						c.NormalizeAll(preComp, iniPreCompLen, reqPreCompLen - iniPreCompLen, iso);
					}
				}
				if (this.m_includeNegated)
				{
					int pos;
					if (preCompNeg == null)
					{
						pos = 0;
						preCompNeg = new global::Org.BouncyCastle.Math.EC.ECPoint[reqPreCompLen];
					}
					else
					{
						pos = preCompNeg.Length;
						if (pos < reqPreCompLen)
						{
							preCompNeg = global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.ResizeTable(preCompNeg, reqPreCompLen);
						}
					}
					while (pos < reqPreCompLen)
					{
						preCompNeg[pos] = preComp[pos].Negate();
						pos++;
					}
				}
				result.PreComp = preComp;
				result.PreCompNeg = preCompNeg;
				result.Twice = twiceP;
				result.Width = width;
				return result;
			}

			// Token: 0x0600457D RID: 17789 RVA: 0x00133B45 File Offset: 0x00131D45
			private bool CheckExisting(global::Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo existingWNaf, int width, int reqPreCompLen, bool includeNegated)
			{
				return existingWNaf != null && existingWNaf.Width >= global::System.Math.Max(existingWNaf.ConfWidth, width) && this.CheckTable(existingWNaf.PreComp, reqPreCompLen) && (!includeNegated || this.CheckTable(existingWNaf.PreCompNeg, reqPreCompLen));
			}

			// Token: 0x0600457E RID: 17790 RVA: 0x00133B82 File Offset: 0x00131D82
			private bool CheckTable(global::Org.BouncyCastle.Math.EC.ECPoint[] table, int reqLen)
			{
				return table != null && table.Length >= reqLen;
			}

			// Token: 0x04002412 RID: 9234
			private readonly global::Org.BouncyCastle.Math.EC.ECPoint m_p;

			// Token: 0x04002413 RID: 9235
			private readonly int m_minWidth;

			// Token: 0x04002414 RID: 9236
			private readonly bool m_includeNegated;
		}

		// Token: 0x020007D1 RID: 2001
		private class PrecomputeWithPointMapCallback : global::Org.BouncyCastle.Math.EC.Multiplier.IPreCompCallback
		{
			// Token: 0x0600457F RID: 17791 RVA: 0x00133B92 File Offset: 0x00131D92
			internal PrecomputeWithPointMapCallback(global::Org.BouncyCastle.Math.EC.ECPoint point, global::Org.BouncyCastle.Math.EC.ECPointMap pointMap, global::Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo fromWNaf, bool includeNegated)
			{
				this.m_point = point;
				this.m_pointMap = pointMap;
				this.m_fromWNaf = fromWNaf;
				this.m_includeNegated = includeNegated;
			}

			// Token: 0x06004580 RID: 17792 RVA: 0x00133BB8 File Offset: 0x00131DB8
			public global::Org.BouncyCastle.Math.EC.Multiplier.PreCompInfo Precompute(global::Org.BouncyCastle.Math.EC.Multiplier.PreCompInfo existing)
			{
				global::Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo existingWNaf = existing as global::Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo;
				int width = this.m_fromWNaf.Width;
				int reqPreCompLen = this.m_fromWNaf.PreComp.Length;
				if (this.CheckExisting(existingWNaf, width, reqPreCompLen, this.m_includeNegated))
				{
					existingWNaf.DecrementPromotionCountdown();
					return existingWNaf;
				}
				global::Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo result = new global::Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo();
				result.PromotionCountdown = this.m_fromWNaf.PromotionCountdown;
				global::Org.BouncyCastle.Math.EC.ECPoint twiceFrom = this.m_fromWNaf.Twice;
				if (twiceFrom != null)
				{
					global::Org.BouncyCastle.Math.EC.ECPoint twice = this.m_pointMap.Map(twiceFrom);
					result.Twice = twice;
				}
				global::Org.BouncyCastle.Math.EC.ECPoint[] preCompFrom = this.m_fromWNaf.PreComp;
				global::Org.BouncyCastle.Math.EC.ECPoint[] preComp = new global::Org.BouncyCastle.Math.EC.ECPoint[preCompFrom.Length];
				for (int i = 0; i < preCompFrom.Length; i++)
				{
					preComp[i] = this.m_pointMap.Map(preCompFrom[i]);
				}
				result.PreComp = preComp;
				result.Width = width;
				if (this.m_includeNegated)
				{
					global::Org.BouncyCastle.Math.EC.ECPoint[] preCompNeg = new global::Org.BouncyCastle.Math.EC.ECPoint[preComp.Length];
					for (int j = 0; j < preCompNeg.Length; j++)
					{
						preCompNeg[j] = preComp[j].Negate();
					}
					result.PreCompNeg = preCompNeg;
				}
				return result;
			}

			// Token: 0x06004581 RID: 17793 RVA: 0x00133CCC File Offset: 0x00131ECC
			private bool CheckExisting(global::Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo existingWNaf, int width, int reqPreCompLen, bool includeNegated)
			{
				return existingWNaf != null && existingWNaf.Width >= width && this.CheckTable(existingWNaf.PreComp, reqPreCompLen) && (!includeNegated || this.CheckTable(existingWNaf.PreCompNeg, reqPreCompLen));
			}

			// Token: 0x06004582 RID: 17794 RVA: 0x00133CFE File Offset: 0x00131EFE
			private bool CheckTable(global::Org.BouncyCastle.Math.EC.ECPoint[] table, int reqLen)
			{
				return table != null && table.Length >= reqLen;
			}

			// Token: 0x04002415 RID: 9237
			private readonly global::Org.BouncyCastle.Math.EC.ECPoint m_point;

			// Token: 0x04002416 RID: 9238
			private readonly global::Org.BouncyCastle.Math.EC.ECPointMap m_pointMap;

			// Token: 0x04002417 RID: 9239
			private readonly global::Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo m_fromWNaf;

			// Token: 0x04002418 RID: 9240
			private readonly bool m_includeNegated;
		}
	}
}
