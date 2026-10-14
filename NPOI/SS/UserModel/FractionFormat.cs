using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using NPOI.SS.Format;
using NPOI.SS.Util;

namespace NPOI.SS.UserModel
{
	// Token: 0x0200003E RID: 62
	public class FractionFormat : global::NPOI.SS.Util.FormatBase
	{
		// Token: 0x06000252 RID: 594 RVA: 0x00009C58 File Offset: 0x00007E58
		public FractionFormat(string wholePartFormatString, string denomFormatString)
		{
			this.wholePartFormatString = wholePartFormatString;
			global::System.Text.RegularExpressions.Match match = global::NPOI.SS.UserModel.FractionFormat.DENOM_FORMAT_PATTERN.Match(denomFormatString);
			int num = -1;
			int num2 = -1;
			if (match.Success)
			{
				if (match.Groups[2] != null && match.Groups[2].Success)
				{
					try
					{
						num = int.Parse(match.Groups[2].Value);
						if (num == 0)
						{
							num = -1;
						}
						goto IL_CA;
					}
					catch (global::System.FormatException)
					{
						goto IL_CA;
					}
				}
				if (match.Groups[1] != null && match.Groups[1].Success)
				{
					int num3 = match.Groups[1].Value.Length;
					num3 = ((num3 > global::NPOI.SS.UserModel.FractionFormat.MAX_DENOM_POW) ? global::NPOI.SS.UserModel.FractionFormat.MAX_DENOM_POW : num3);
					num2 = (int)global::System.Math.Pow(10.0, (double)num3);
				}
				else
				{
					num = 100;
				}
			}
			IL_CA:
			if (num <= 0 && num2 <= 0)
			{
				num = 100;
			}
			this.exactDenom = num;
			this.maxDenom = num2;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00009D58 File Offset: 0x00007F58
		public string Format(string num)
		{
			double num2 = 0.0;
			double.TryParse(num, out num2);
			bool flag = num2 < 0.0;
			double num3 = global::System.Math.Abs(num2);
			double num4 = global::System.Math.Floor(num3);
			double num5 = num3 - num4;
			if (num4 + num5 == 0.0)
			{
				return "0";
			}
			if (num3 < (double)(1 / global::System.Math.Max(this.exactDenom, this.maxDenom)))
			{
				return "0";
			}
			if (num4 + (double)((int)num5) == num4 + num5)
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				if (flag)
				{
					stringBuilder.Append("-");
				}
				stringBuilder.Append((int)num4);
				return stringBuilder.ToString();
			}
			global::NPOI.SS.Format.SimpleFraction simpleFraction = null;
			try
			{
				if (this.exactDenom > 0)
				{
					simpleFraction = global::NPOI.SS.Format.SimpleFraction.BuildFractionExactDenominator(num5, this.exactDenom);
				}
				else
				{
					simpleFraction = global::NPOI.SS.Format.SimpleFraction.BuildFractionMaxDenominator(num5, this.maxDenom);
				}
			}
			catch (global::NPOI.SS.UserModel.FractionFormat.SimpleFractionException)
			{
				return num2.ToString();
			}
			global::System.Text.StringBuilder stringBuilder2 = new global::System.Text.StringBuilder();
			if (flag)
			{
				stringBuilder2.Append("-");
			}
			if ("".Equals(this.wholePartFormatString))
			{
				int value = simpleFraction.Denominator * (int)num4 + simpleFraction.Numerator;
				stringBuilder2.Append(value).Append("/").Append(simpleFraction.Denominator);
				return stringBuilder2.ToString();
			}
			if (simpleFraction.Numerator == 0)
			{
				stringBuilder2.Append((int)num4);
				return stringBuilder2.ToString();
			}
			if (simpleFraction.Numerator == simpleFraction.Denominator)
			{
				stringBuilder2.Append((int)num4 + 1);
				return stringBuilder2.ToString();
			}
			if (num4 > 0.0)
			{
				stringBuilder2.Append((int)num4).Append(" ");
			}
			stringBuilder2.Append(simpleFraction.Numerator).Append("/").Append(simpleFraction.Denominator);
			return stringBuilder2.ToString();
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00009F44 File Offset: 0x00008144
		protected override global::System.Text.StringBuilder Format(object obj, global::System.Text.StringBuilder toAppendTo, int pos)
		{
			return toAppendTo.Append(this.Format(obj.ToString()));
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00009F58 File Offset: 0x00008158
		public override string Format(object obj, global::System.Globalization.CultureInfo culture)
		{
			return this.Format(obj.ToString());
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00009F66 File Offset: 0x00008166
		public override object ParseObject(string source, int pos)
		{
			throw new global::System.NotImplementedException("Reverse parsing not supported");
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00006C8C File Offset: 0x00004E8C
		public override global::System.Text.StringBuilder Format(object obj, global::System.Text.StringBuilder toAppendTo, global::System.Globalization.CultureInfo culture)
		{
			return toAppendTo.Append(this.Format(obj, culture));
		}

		// Token: 0x040000F3 RID: 243
		private static global::System.Text.RegularExpressions.Regex DENOM_FORMAT_PATTERN = new global::System.Text.RegularExpressions.Regex("(?:(#+)|(\\d+))", global::System.Text.RegularExpressions.RegexOptions.Compiled);

		// Token: 0x040000F4 RID: 244
		private static int MAX_DENOM_POW = 4;

		// Token: 0x040000F5 RID: 245
		private int exactDenom;

		// Token: 0x040000F6 RID: 246
		private int maxDenom;

		// Token: 0x040000F7 RID: 247
		private string wholePartFormatString;

		// Token: 0x0200055B RID: 1371
		private class SimpleFractionException : global::System.Exception
		{
			// Token: 0x06003395 RID: 13205 RVA: 0x0000E5BB File Offset: 0x0000C7BB
			public SimpleFractionException(string message) : base(message)
			{
			}
		}
	}
}
