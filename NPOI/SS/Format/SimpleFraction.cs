using System;
using NPOI.Util;

namespace NPOI.SS.Format
{
	// Token: 0x02000253 RID: 595
	public class SimpleFraction
	{
		// Token: 0x06000E92 RID: 3730 RVA: 0x0002B448 File Offset: 0x00029648
		public static global::NPOI.SS.Format.SimpleFraction BuildFractionExactDenominator(double val, int exactDenom)
		{
			return new global::NPOI.SS.Format.SimpleFraction((int)global::System.Math.Round(val * (double)exactDenom, global::System.MidpointRounding.AwayFromZero), exactDenom);
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x0002B45B File Offset: 0x0002965B
		public static global::NPOI.SS.Format.SimpleFraction BuildFractionMaxDenominator(double value, int maxDenominator)
		{
			return global::NPOI.SS.Format.SimpleFraction.BuildFractionMaxDenominator(value, 0.0, maxDenominator, 100);
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x0002B470 File Offset: 0x00029670
		private static global::NPOI.SS.Format.SimpleFraction BuildFractionMaxDenominator(double value, double epsilon, int maxDenominator, int maxIterations)
		{
			long maxValue = long.MaxValue;
			double num = value;
			long num2 = (long)global::System.Math.Floor(num);
			if (num2 > maxValue)
			{
				throw new global::System.ArgumentException(string.Concat(new string[]
				{
					"Overflow trying to convert ",
					value.ToString(),
					" to fraction (",
					num2.ToString(),
					"/",
					1L.ToString(),
					")"
				}));
			}
			if (global::System.Math.Abs((double)num2 - value) < epsilon)
			{
				return new global::NPOI.SS.Format.SimpleFraction((int)num2, 1);
			}
			long num3 = 1L;
			long num4 = 0L;
			long num5 = num2;
			long num6 = 1L;
			int num7 = 0;
			bool flag = false;
			long num10;
			long num11;
			for (;;)
			{
				num7++;
				double num8 = 1.0 / (num - (double)num2);
				long num9 = (long)global::System.Math.Floor(num8);
				num10 = num9 * num5 + num3;
				num11 = num9 * num6 + num4;
				if (epsilon == 0.0 && maxDenominator > 0 && global::System.Math.Abs(num11) > (long)maxDenominator && global::System.Math.Abs(num6) < (long)maxDenominator)
				{
					break;
				}
				if (num10 > maxValue || num11 > maxValue)
				{
					goto IL_103;
				}
				double num12 = (double)num10 / (double)num11;
				if (num7 < maxIterations && global::System.Math.Abs(num12 - value) > epsilon && num11 < (long)maxDenominator)
				{
					num3 = num5;
					num5 = num10;
					num4 = num6;
					num6 = num11;
					num2 = num9;
					num = num8;
				}
				else
				{
					flag = true;
				}
				if (flag)
				{
					goto Block_11;
				}
			}
			return new global::NPOI.SS.Format.SimpleFraction((int)num5, (int)num6);
			IL_103:
			throw new global::NPOI.Util.RuntimeException(string.Concat(new string[]
			{
				"Overflow trying to convert ",
				value.ToString(),
				" to fraction (",
				num10.ToString(),
				"/",
				num11.ToString(),
				")"
			}));
			Block_11:
			if (num7 >= maxIterations)
			{
				throw new global::NPOI.Util.RuntimeException(string.Concat(new string[]
				{
					"Unable to convert ",
					value.ToString(),
					" to fraction after ",
					maxIterations.ToString(),
					" iterations"
				}));
			}
			if (num11 < (long)maxDenominator)
			{
				return new global::NPOI.SS.Format.SimpleFraction((int)num10, (int)num11);
			}
			return new global::NPOI.SS.Format.SimpleFraction((int)num5, (int)num6);
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x0002B66F File Offset: 0x0002986F
		public SimpleFraction(int numerator, int denominator)
		{
			this.numerator = numerator;
			this.denominator = denominator;
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000E96 RID: 3734 RVA: 0x0002B685 File Offset: 0x00029885
		public int Denominator
		{
			get
			{
				return this.denominator;
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000E97 RID: 3735 RVA: 0x0002B68D File Offset: 0x0002988D
		public int Numerator
		{
			get
			{
				return this.numerator;
			}
		}

		// Token: 0x040006A8 RID: 1704
		private int denominator;

		// Token: 0x040006A9 RID: 1705
		private int numerator;
	}
}
