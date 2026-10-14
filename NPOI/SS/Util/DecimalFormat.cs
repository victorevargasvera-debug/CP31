using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace NPOI.SS.Util
{
	// Token: 0x02000020 RID: 32
	public class DecimalFormat : global::NPOI.SS.Util.FormatBase
	{
		// Token: 0x06000162 RID: 354 RVA: 0x00006B83 File Offset: 0x00004D83
		public DecimalFormat()
		{
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00006DAE File Offset: 0x00004FAE
		public DecimalFormat(string pattern)
		{
			if (pattern.IndexOf("'", global::System.StringComparison.Ordinal) != -1)
			{
				throw new global::System.ArgumentException("invalid pattern");
			}
			this._pattern = pattern;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00006DD7 File Offset: 0x00004FD7
		public DecimalFormat(string pattern, global::System.Globalization.NumberFormatInfo formatInfo) : this(pattern)
		{
			this._formatInfo = formatInfo;
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00006DE7 File Offset: 0x00004FE7
		public string Pattern
		{
			get
			{
				return this._pattern;
			}
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00006DEF File Offset: 0x00004FEF
		public override string Format(object obj)
		{
			return this.Format(obj, global::System.Globalization.CultureInfo.CurrentCulture);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00006E00 File Offset: 0x00005000
		public override string Format(object obj, global::System.Globalization.CultureInfo culture)
		{
			this._pattern = global::NPOI.SS.Util.DecimalFormat.RegexFraction.Replace(this._pattern, "/");
			if (this._formatInfo != null)
			{
				culture = (global::System.Globalization.CultureInfo)culture.Clone();
				culture.NumberFormat = this._formatInfo;
			}
			if (this._pattern.IndexOf("'", global::System.StringComparison.Ordinal) != -1)
			{
				return global::System.Convert.ToDouble(obj, global::System.Globalization.CultureInfo.InvariantCulture).ToString(culture);
			}
			string text = global::System.Convert.ToDouble(obj, global::System.Globalization.CultureInfo.InvariantCulture).ToString(this._pattern, culture);
			if (string.IsNullOrEmpty(text))
			{
				text = "0";
			}
			return text;
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00006C8C File Offset: 0x00004E8C
		public override global::System.Text.StringBuilder Format(object obj, global::System.Text.StringBuilder toAppendTo, global::System.Globalization.CultureInfo culture)
		{
			return toAppendTo.Append(this.Format(obj, culture));
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00006E9C File Offset: 0x0000509C
		public override object ParseObject(string source, int pos)
		{
			return decimal.Parse(source.Substring(pos), global::System.Globalization.CultureInfo.CurrentCulture);
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600016A RID: 362 RVA: 0x00006EB4 File Offset: 0x000050B4
		public bool ParseIntegerOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x04000072 RID: 114
		private string _pattern;

		// Token: 0x04000073 RID: 115
		private global::System.Globalization.NumberFormatInfo _formatInfo;

		// Token: 0x04000074 RID: 116
		private static readonly global::System.Text.RegularExpressions.Regex RegexFraction = new global::System.Text.RegularExpressions.Regex("#+/#+", global::System.Text.RegularExpressions.RegexOptions.Compiled);
	}
}
