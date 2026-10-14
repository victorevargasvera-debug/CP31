using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using NPOI.SS.Util;

namespace NPOI.SS.UserModel
{
	// Token: 0x02000063 RID: 99
	public class ExcelStyleDateFormatter : global::NPOI.SS.Util.SimpleDateFormat
	{
		// Token: 0x060003BD RID: 957 RVA: 0x0000CD97 File Offset: 0x0000AF97
		public ExcelStyleDateFormatter()
		{
		}

		// Token: 0x060003BE RID: 958 RVA: 0x0000CD9F File Offset: 0x0000AF9F
		public ExcelStyleDateFormatter(string pattern) : base(global::NPOI.SS.UserModel.ExcelStyleDateFormatter.ProcessFormatPattern(pattern))
		{
		}

		// Token: 0x060003BF RID: 959 RVA: 0x0000CDAD File Offset: 0x0000AFAD
		private static string DateTimeMatchEvaluator(global::System.Text.RegularExpressions.Match match)
		{
			return match.Groups[1].Value;
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x0000CDC0 File Offset: 0x0000AFC0
		private static string ProcessFormatPattern(string f)
		{
			return global::System.Text.RegularExpressions.Regex.Replace(global::System.Text.RegularExpressions.Regex.Replace(global::System.Text.RegularExpressions.Regex.Replace(global::System.Text.RegularExpressions.Regex.Replace(global::System.Text.RegularExpressions.Regex.Replace(global::System.Text.RegularExpressions.Regex.Replace(global::System.Text.RegularExpressions.Regex.Replace(f.Replace("MMMMM", "MMM"), "\\[H\\]", ''.ToString(), global::System.Text.RegularExpressions.RegexOptions.IgnoreCase), "\\[HH\\]", ''.ToString(), global::System.Text.RegularExpressions.RegexOptions.IgnoreCase), "\\[m\\]", ''.ToString(), global::System.Text.RegularExpressions.RegexOptions.IgnoreCase), "\\[mm\\]", ''.ToString(), global::System.Text.RegularExpressions.RegexOptions.IgnoreCase), "\\[s\\]", ''.ToString(), global::System.Text.RegularExpressions.RegexOptions.IgnoreCase), "\\[ss\\]", ''.ToString(), global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Replace("s.000", "s.fff").Replace("s.00", "s.").Replace("s.0", "s.").Replace("\"", ''.ToString()), "(?<![M%])M(?!M)", "%M");
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0000CEC0 File Offset: 0x0000B0C0
		public void SetDateToBeFormatted(double date)
		{
			this.dateToBeFormatted = date;
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x0000CEC9 File Offset: 0x0000B0C9
		public override string Format(object obj, global::System.Globalization.CultureInfo culture)
		{
			return this.Format((global::System.DateTime)obj, new global::System.Text.StringBuilder(), culture).ToString();
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x0000CEE4 File Offset: 0x0000B0E4
		public global::System.Text.StringBuilder Format(global::System.DateTime date, global::System.Text.StringBuilder paramStringBuilder, global::System.Globalization.CultureInfo culture)
		{
			string text = string.Empty;
			if (global::System.Text.RegularExpressions.Regex.IsMatch(base.Pattern, "[yYmMdDhHsS\\-/,. :\"\\\\]+0?[ampAMP/]*"))
			{
				text = date.ToString(base.Pattern, culture);
			}
			else
			{
				text = base.Pattern;
			}
			if (text.IndexOf('') != -1)
			{
				text = text.Replace('', '"');
			}
			if (text.IndexOf('') != -1)
			{
				global::System.Text.RegularExpressions.Regex regex = new global::System.Text.RegularExpressions.Regex("(\\w)\\w+", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase);
				global::System.Text.RegularExpressions.Match match = regex.Match(text);
				if (match.Success)
				{
					text = regex.Replace(text, match.Groups[1].Value);
				}
			}
			if (text.IndexOf('') != -1 || text.IndexOf('') != -1)
			{
				double num = this.dateToBeFormatted * 24.0 + 0.01;
				num = global::System.Math.Floor(num);
				text = text.Replace(''.ToString(), global::NPOI.SS.UserModel.ExcelStyleDateFormatter.format1digit.Format(num, culture));
				text = text.Replace(''.ToString(), global::NPOI.SS.UserModel.ExcelStyleDateFormatter.format2digits.Format(num, culture));
			}
			if (text.IndexOf('') != -1 || text.IndexOf('') != -1)
			{
				double num2 = this.dateToBeFormatted * 24.0 * 60.0 + 0.01;
				num2 = global::System.Math.Floor(num2);
				text = text.Replace(''.ToString(), global::NPOI.SS.UserModel.ExcelStyleDateFormatter.format1digit.Format(num2, culture));
				text = text.Replace(''.ToString(), global::NPOI.SS.UserModel.ExcelStyleDateFormatter.format2digits.Format(num2, culture));
			}
			if (text.IndexOf('') != -1 || text.IndexOf('') != -1)
			{
				double num3 = this.dateToBeFormatted * 24.0 * 60.0 * 60.0 + 0.01;
				text = text.Replace(''.ToString(), global::NPOI.SS.UserModel.ExcelStyleDateFormatter.format1digit.Format(num3, culture));
				text = text.Replace(''.ToString(), global::NPOI.SS.UserModel.ExcelStyleDateFormatter.format2digits.Format(num3, culture));
			}
			if (text.IndexOf('') != -1 || text.IndexOf('') != -1)
			{
				float num4 = (float)((this.dateToBeFormatted - global::System.Math.Floor(this.dateToBeFormatted)) * 24.0 * 60.0 * 60.0);
				float num5 = num4 - (float)((int)num4);
				text = text.Replace(''.ToString(), global::NPOI.SS.UserModel.ExcelStyleDateFormatter.format3digit.Format(num5 * 10f, culture));
				text = text.Replace(''.ToString(), global::NPOI.SS.UserModel.ExcelStyleDateFormatter.format4digits.Format(num5 * 100f, culture));
			}
			return new global::System.Text.StringBuilder(text);
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0000D1F4 File Offset: 0x0000B3F4
		public override bool Equals(object o)
		{
			if (!(o is global::NPOI.SS.UserModel.ExcelStyleDateFormatter))
			{
				return false;
			}
			global::NPOI.SS.UserModel.ExcelStyleDateFormatter excelStyleDateFormatter = (global::NPOI.SS.UserModel.ExcelStyleDateFormatter)o;
			return this.dateToBeFormatted == excelStyleDateFormatter.dateToBeFormatted;
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0000D220 File Offset: 0x0000B420
		public override int GetHashCode()
		{
			return this.dateToBeFormatted.GetHashCode();
		}

		// Token: 0x040001B8 RID: 440
		public const char MMMMM_START_SYMBOL = '';

		// Token: 0x040001B9 RID: 441
		public const char MMMMM_TRUNCATE_SYMBOL = '';

		// Token: 0x040001BA RID: 442
		public const char H_BRACKET_SYMBOL = '';

		// Token: 0x040001BB RID: 443
		public const char HH_BRACKET_SYMBOL = '';

		// Token: 0x040001BC RID: 444
		public const char M_BRACKET_SYMBOL = '';

		// Token: 0x040001BD RID: 445
		public const char MM_BRACKET_SYMBOL = '';

		// Token: 0x040001BE RID: 446
		public const char S_BRACKET_SYMBOL = '';

		// Token: 0x040001BF RID: 447
		public const char SS_BRACKET_SYMBOL = '';

		// Token: 0x040001C0 RID: 448
		public const char L_BRACKET_SYMBOL = '';

		// Token: 0x040001C1 RID: 449
		public const char LL_BRACKET_SYMBOL = '';

		// Token: 0x040001C2 RID: 450
		public const char QUOTE_SYMBOL = '';

		// Token: 0x040001C3 RID: 451
		private static global::NPOI.SS.Util.DecimalFormat format1digit = new global::NPOI.SS.Util.DecimalFormat("0");

		// Token: 0x040001C4 RID: 452
		private static global::NPOI.SS.Util.DecimalFormat format2digits = new global::NPOI.SS.Util.DecimalFormat("00");

		// Token: 0x040001C5 RID: 453
		private static global::NPOI.SS.Util.DecimalFormat format3digit = new global::NPOI.SS.Util.DecimalFormat("0");

		// Token: 0x040001C6 RID: 454
		private static global::NPOI.SS.Util.DecimalFormat format4digits = new global::NPOI.SS.Util.DecimalFormat("00");

		// Token: 0x040001C7 RID: 455
		private double dateToBeFormatted;
	}
}
