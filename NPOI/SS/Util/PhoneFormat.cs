using System;
using System.Globalization;
using System.Text;

namespace NPOI.SS.Util
{
	// Token: 0x0200001F RID: 31
	public class PhoneFormat : global::NPOI.SS.Util.FormatBase
	{
		// Token: 0x0600015C RID: 348 RVA: 0x00006B83 File Offset: 0x00004D83
		private PhoneFormat()
		{
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00006CB4 File Offset: 0x00004EB4
		public override string Format(object obj, global::System.Globalization.CultureInfo culture)
		{
			string text = ((double)obj).ToString(global::NPOI.SS.Util.PhoneFormat.df, culture);
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			int length = text.Length;
			if (length <= 4)
			{
				return text;
			}
			string value = text.Substring(length - 4);
			int num = global::System.Math.Max(0, length - 7);
			string text2 = text.Substring(global::System.Math.Max(0, length - 7), length - 4 - num);
			num = global::System.Math.Max(0, length - 10);
			string text3 = text.Substring(num, global::System.Math.Max(0, length - 7) - num);
			if (text3 != null && text3.Trim().Length > 0)
			{
				stringBuilder.Append('(').Append(text3).Append(") ");
			}
			if (text2 != null && text2.Trim().Length > 0)
			{
				stringBuilder.Append(text2).Append('-');
			}
			stringBuilder.Append(value);
			return stringBuilder.ToString();
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00006BF3 File Offset: 0x00004DF3
		protected override global::System.Text.StringBuilder Format(object obj, global::System.Text.StringBuilder toAppendTo, int pos)
		{
			return toAppendTo.Append(this.Format(obj, global::System.Globalization.CultureInfo.CurrentCulture));
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00006C8C File Offset: 0x00004E8C
		public override global::System.Text.StringBuilder Format(object obj, global::System.Text.StringBuilder toAppendTo, global::System.Globalization.CultureInfo culture)
		{
			return toAppendTo.Append(this.Format(obj, culture));
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00006C21 File Offset: 0x00004E21
		public override object ParseObject(string source, int pos)
		{
			return long.Parse(source.Substring(pos), global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x04000070 RID: 112
		public static readonly global::NPOI.SS.Util.FormatBase Instance = new global::NPOI.SS.Util.PhoneFormat();

		// Token: 0x04000071 RID: 113
		private static string df = "##########";
	}
}
