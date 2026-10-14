using System;
using System.Globalization;
using System.Text;

namespace NPOI.SS.Util
{
	// Token: 0x0200001D RID: 29
	public class SSNFormat : global::NPOI.SS.Util.FormatBase
	{
		// Token: 0x06000150 RID: 336 RVA: 0x00006B83 File Offset: 0x00004D83
		private SSNFormat()
		{
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00006B8C File Offset: 0x00004D8C
		public override string Format(object obj, global::System.Globalization.CultureInfo culture)
		{
			string text = ((double)obj).ToString(global::NPOI.SS.Util.SSNFormat.df, culture);
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(text.Substring(0, 3)).Append('-');
			stringBuilder.Append(text.Substring(3, 2)).Append('-');
			stringBuilder.Append(text.Substring(5, 4));
			return stringBuilder.ToString();
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00006BF3 File Offset: 0x00004DF3
		protected override global::System.Text.StringBuilder Format(object obj, global::System.Text.StringBuilder toAppendTo, int pos)
		{
			return toAppendTo.Append(this.Format(obj, global::System.Globalization.CultureInfo.CurrentCulture));
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00006C07 File Offset: 0x00004E07
		public override global::System.Text.StringBuilder Format(object obj, global::System.Text.StringBuilder toAppendTo, global::System.Globalization.CultureInfo culture)
		{
			return toAppendTo.Append(this.Format((long)obj, culture));
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00006C21 File Offset: 0x00004E21
		public override object ParseObject(string source, int pos)
		{
			return long.Parse(source.Substring(pos), global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x0400006C RID: 108
		public static readonly global::NPOI.SS.Util.FormatBase Instance = new global::NPOI.SS.Util.SSNFormat();

		// Token: 0x0400006D RID: 109
		private static string df = "000000000";
	}
}
