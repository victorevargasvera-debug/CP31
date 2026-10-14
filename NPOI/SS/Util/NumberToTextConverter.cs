using System;
using System.Text;

namespace NPOI.SS.Util
{
	// Token: 0x02000028 RID: 40
	public class NumberToTextConverter
	{
		// Token: 0x0600019F RID: 415 RVA: 0x0000253E File Offset: 0x0000073E
		private NumberToTextConverter()
		{
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x000079A0 File Offset: 0x00005BA0
		public static string ToText(double value)
		{
			return global::NPOI.SS.Util.NumberToTextConverter.RawDoubleBitsToText(global::System.BitConverter.DoubleToInt64Bits(value));
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x000079B0 File Offset: 0x00005BB0
		public static string RawDoubleBitsToText(long pRawBits)
		{
			long num = pRawBits;
			bool flag = num < 0L;
			if (flag)
			{
				num &= long.MaxValue;
			}
			if (num == 0L)
			{
				if (!flag)
				{
					return "0";
				}
				return "-0";
			}
			else
			{
				global::NPOI.SS.Util.ExpandedDouble expandedDouble = new global::NPOI.SS.Util.ExpandedDouble(num);
				if (expandedDouble.GetBinaryExponent() >= -1022)
				{
					if (expandedDouble.GetBinaryExponent() == 1024)
					{
						if (num == -276939487313920L)
						{
							return "3.484840871308E+308";
						}
						flag = false;
					}
					global::NPOI.SS.Util.NormalisedDecimal pnd = expandedDouble.NormaliseBaseTen();
					global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(21);
					if (flag)
					{
						stringBuilder.Append('-');
					}
					global::NPOI.SS.Util.NumberToTextConverter.ConvertToText(stringBuilder, pnd);
					return stringBuilder.ToString();
				}
				if (!flag)
				{
					return "0";
				}
				return "-0";
			}
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00007A58 File Offset: 0x00005C58
		private static void ConvertToText(global::System.Text.StringBuilder sb, global::NPOI.SS.Util.NormalisedDecimal pnd)
		{
			global::NPOI.SS.Util.NormalisedDecimal normalisedDecimal = pnd.RoundUnits();
			int num = normalisedDecimal.GetDecimalExponent();
			string text;
			if (global::System.Math.Abs(num) > 98)
			{
				text = normalisedDecimal.GetSignificantDecimalDigitsLastDigitRounded();
				if (text.Length == 16)
				{
					num++;
				}
			}
			else
			{
				text = normalisedDecimal.GetSignificantDecimalDigits();
			}
			int countSigDigits = global::NPOI.SS.Util.NumberToTextConverter.CountSignifantDigits(text);
			if (num < 0)
			{
				global::NPOI.SS.Util.NumberToTextConverter.FormatLessThanOne(sb, text, num, countSigDigits);
				return;
			}
			global::NPOI.SS.Util.NumberToTextConverter.FormatGreaterThanOne(sb, text, num, countSigDigits);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00007ABC File Offset: 0x00005CBC
		private static void FormatLessThanOne(global::System.Text.StringBuilder sb, string decimalDigits, int decExponent, int countSigDigits)
		{
			int num = -decExponent - 1;
			if (global::NPOI.SS.Util.NumberToTextConverter.NeedsScientificNotation(2 + num + countSigDigits))
			{
				sb.Append(decimalDigits[0]);
				if (countSigDigits > 1)
				{
					sb.Append('.');
					sb.Append(decimalDigits.Substring(1, countSigDigits - 1));
				}
				sb.Append("E-");
				global::NPOI.SS.Util.NumberToTextConverter.AppendExp(sb, -decExponent);
				return;
			}
			sb.Append("0.");
			for (int i = num; i > 0; i--)
			{
				sb.Append('0');
			}
			sb.Append(decimalDigits.Substring(0, countSigDigits));
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00007B4C File Offset: 0x00005D4C
		private static void FormatGreaterThanOne(global::System.Text.StringBuilder sb, string decimalDigits, int decExponent, int countSigDigits)
		{
			if (decExponent > 19)
			{
				sb.Append(decimalDigits[0]);
				if (countSigDigits > 1)
				{
					sb.Append('.');
					sb.Append(decimalDigits.Substring(1, countSigDigits - 1));
				}
				sb.Append("E+");
				global::NPOI.SS.Util.NumberToTextConverter.AppendExp(sb, decExponent);
				return;
			}
			int num = countSigDigits - decExponent - 1;
			if (num > 0)
			{
				sb.Append(decimalDigits.Substring(0, decExponent + 1));
				sb.Append('.');
				sb.Append(decimalDigits.Substring(decExponent + 1, num));
				return;
			}
			sb.Append(decimalDigits.Substring(0, countSigDigits));
			for (int i = -num; i > 0; i--)
			{
				sb.Append('0');
			}
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00007BF9 File Offset: 0x00005DF9
		private static bool NeedsScientificNotation(int nDigits)
		{
			return nDigits > 20;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00007C00 File Offset: 0x00005E00
		private static int CountSignifantDigits(string sb)
		{
			int num = sb.Length - 1;
			while (sb[num] == '0')
			{
				num--;
				if (num < 0)
				{
					throw new global::System.Exception("No non-zero digits found");
				}
			}
			return num + 1;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00007C39 File Offset: 0x00005E39
		private static void AppendExp(global::System.Text.StringBuilder sb, int val)
		{
			if (val < 10)
			{
				sb.Append('0');
				sb.Append((char)(48 + val));
				return;
			}
			sb.Append(val);
		}

		// Token: 0x04000094 RID: 148
		private const long EXCEL_NAN_BITS = -276939487313920L;

		// Token: 0x04000095 RID: 149
		private const int MAX_TEXT_LEN = 20;
	}
}
