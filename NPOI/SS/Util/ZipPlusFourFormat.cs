using System;
using System.Globalization;
using System.Text;

namespace NPOI.SS.Util
{
	// Token: 0x0200001E RID: 30
	public class ZipPlusFourFormat : global::NPOI.SS.Util.FormatBase
	{
		// Token: 0x06000156 RID: 342 RVA: 0x00006B83 File Offset: 0x00004D83
		private ZipPlusFourFormat()
		{
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00006C50 File Offset: 0x00004E50
		public override string Format(object obj, global::System.Globalization.CultureInfo culture)
		{
			string text = ((double)obj).ToString(global::NPOI.SS.Util.ZipPlusFourFormat.df, culture);
			return text.Substring(0, 5) + "-" + text.Substring(5, 4);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00006BF3 File Offset: 0x00004DF3
		protected override global::System.Text.StringBuilder Format(object obj, global::System.Text.StringBuilder toAppendTo, int pos)
		{
			return toAppendTo.Append(this.Format(obj, global::System.Globalization.CultureInfo.CurrentCulture));
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00006C8C File Offset: 0x00004E8C
		public override global::System.Text.StringBuilder Format(object obj, global::System.Text.StringBuilder toAppendTo, global::System.Globalization.CultureInfo culture)
		{
			return toAppendTo.Append(this.Format(obj, culture));
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00006C21 File Offset: 0x00004E21
		public override object ParseObject(string source, int pos)
		{
			return long.Parse(source.Substring(pos), global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x0400006E RID: 110
		public static readonly global::NPOI.SS.Util.FormatBase Instance = new global::NPOI.SS.Util.ZipPlusFourFormat();

		// Token: 0x0400006F RID: 111
		private static string df = "000000000";
	}
}
