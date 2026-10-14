using System;
using System.Globalization;
using System.Text;

namespace NPOI.SS.Format
{
	// Token: 0x02000249 RID: 585
	public abstract class CellFormatter
	{
		// Token: 0x06000E56 RID: 3670 RVA: 0x00029BFA File Offset: 0x00027DFA
		public CellFormatter(string format)
		{
			this.format = format;
		}

		// Token: 0x06000E57 RID: 3671
		public abstract void FormatValue(global::System.Text.StringBuilder toAppendTo, object value);

		// Token: 0x06000E58 RID: 3672
		public abstract void SimpleValue(global::System.Text.StringBuilder toAppendTo, object value);

		// Token: 0x06000E59 RID: 3673 RVA: 0x00029C0C File Offset: 0x00027E0C
		public string Format(object value)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			this.FormatValue(stringBuilder, value);
			return stringBuilder.ToString();
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x00029C30 File Offset: 0x00027E30
		public string SimpleFormat(object value)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			this.SimpleValue(stringBuilder, value);
			return stringBuilder.ToString();
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x00029C51 File Offset: 0x00027E51
		private static string Quote(string str)
		{
			return "\"" + str + "\"";
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x00029C63 File Offset: 0x00027E63
		public override string ToString()
		{
			return this.format;
		}

		// Token: 0x04000684 RID: 1668
		protected string format;

		// Token: 0x04000685 RID: 1669
		public static readonly global::System.Globalization.CultureInfo LOCALE = global::System.Globalization.CultureInfo.GetCultureInfo("en-US");
	}
}
