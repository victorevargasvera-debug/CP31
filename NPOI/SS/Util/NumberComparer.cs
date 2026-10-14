using System;
using NPOI.Util;

namespace NPOI.SS.Util
{
	// Token: 0x02000027 RID: 39
	public class NumberComparer
	{
		// Token: 0x0600019A RID: 410 RVA: 0x000077CC File Offset: 0x000059CC
		public static int Compare(double a, double b)
		{
			long num = global::System.BitConverter.DoubleToInt64Bits(a);
			long num2 = global::System.BitConverter.DoubleToInt64Bits(b);
			int biasedExponent = global::NPOI.SS.Util.IEEEDouble.GetBiasedExponent(num);
			int biasedExponent2 = global::NPOI.SS.Util.IEEEDouble.GetBiasedExponent(num2);
			if (biasedExponent == 2047)
			{
				throw new global::System.ArgumentException("Special double values are not allowed: " + global::NPOI.SS.Util.NumberComparer.ToHex(a));
			}
			if (biasedExponent2 == 2047)
			{
				throw new global::System.ArgumentException("Special double values are not allowed: " + global::NPOI.SS.Util.NumberComparer.ToHex(a));
			}
			bool flag = num < 0L;
			bool flag2 = num2 < 0L;
			if (flag != flag2)
			{
				if (!flag)
				{
					return 1;
				}
				return -1;
			}
			else
			{
				int num3 = biasedExponent - biasedExponent2;
				int num4 = global::System.Math.Abs(num3);
				if (num4 > 1)
				{
					if (!flag)
					{
						return num3;
					}
					return -num3;
				}
				else
				{
					if (num4 != 1 && num == num2)
					{
						return 0;
					}
					if (biasedExponent == 0)
					{
						if (biasedExponent2 == 0)
						{
							return global::NPOI.SS.Util.NumberComparer.CompareSubnormalNumbers(num & 4503599627370495L, num2 & 4503599627370495L, flag);
						}
						return -global::NPOI.SS.Util.NumberComparer.CompareAcrossSubnormalThreshold(num2, num, flag);
					}
					else
					{
						if (biasedExponent2 == 0)
						{
							return global::NPOI.SS.Util.NumberComparer.CompareAcrossSubnormalThreshold(num, num2, flag);
						}
						global::NPOI.SS.Util.ExpandedDouble expandedDouble = global::NPOI.SS.Util.ExpandedDouble.FromRawBitsAndExponent(num, biasedExponent - 1023);
						global::NPOI.SS.Util.ExpandedDouble expandedDouble2 = global::NPOI.SS.Util.ExpandedDouble.FromRawBitsAndExponent(num2, biasedExponent2 - 1023);
						global::NPOI.SS.Util.NormalisedDecimal normalisedDecimal = expandedDouble.NormaliseBaseTen().RoundUnits();
						global::NPOI.SS.Util.NormalisedDecimal other = expandedDouble2.NormaliseBaseTen().RoundUnits();
						num3 = normalisedDecimal.CompareNormalised(other);
						if (flag)
						{
							return -num3;
						}
						return num3;
					}
				}
			}
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00007900 File Offset: 0x00005B00
		private static int CompareSubnormalNumbers(long fracA, long fracB, bool isNegative)
		{
			int num = (fracA > fracB) ? 1 : ((fracA < fracB) ? -1 : 0);
			if (!isNegative)
			{
				return num;
			}
			return -num;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00007924 File Offset: 0x00005B24
		private static int CompareAcrossSubnormalThreshold(long normalRawBitsA, long subnormalRawBitsB, bool isNegative)
		{
			long num = subnormalRawBitsB & 4503599627370495L;
			if (num == 0L)
			{
				if (!isNegative)
				{
					return 1;
				}
				return -1;
			}
			else
			{
				long num2 = normalRawBitsA & 4503599627370495L;
				if (num2 <= 7L && num >= 4503599627370490L)
				{
					if (num2 == 7L && num == 4503599627370490L)
					{
						return 0;
					}
					if (!isNegative)
					{
						return -1;
					}
					return 1;
				}
				else
				{
					if (!isNegative)
					{
						return 1;
					}
					return -1;
				}
			}
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00007984 File Offset: 0x00005B84
		private static string ToHex(double a)
		{
			return "0x" + global::NPOI.Util.StringUtil.ToHexString(global::System.BitConverter.DoubleToInt64Bits(a)).ToUpper();
		}
	}
}
