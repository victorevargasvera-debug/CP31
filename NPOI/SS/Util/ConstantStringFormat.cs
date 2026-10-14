using System;
using System.Globalization;
using System.Text;

namespace NPOI.SS.Util
{
	// Token: 0x02000023 RID: 35
	public class ConstantStringFormat : global::NPOI.SS.Util.FormatBase
	{
		// Token: 0x0600017A RID: 378 RVA: 0x0000711B File Offset: 0x0000531B
		public ConstantStringFormat(string s)
		{
			this.str = s;
		}

		// Token: 0x0600017B RID: 379 RVA: 0x0000712A File Offset: 0x0000532A
		public override string Format(object obj)
		{
			return this.str;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0000712A File Offset: 0x0000532A
		public override string Format(object obj, global::System.Globalization.CultureInfo culture)
		{
			return this.str;
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00007132 File Offset: 0x00005332
		public override global::System.Text.StringBuilder Format(object obj, global::System.Text.StringBuilder toAppendTo, global::System.Globalization.CultureInfo culture)
		{
			return toAppendTo.Append(this.str);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00007140 File Offset: 0x00005340
		public override object ParseObject(string source, int pos)
		{
			return global::NPOI.SS.Util.ConstantStringFormat.df.ParseObject(source, pos);
		}

		// Token: 0x0400007D RID: 125
		private static global::NPOI.SS.Util.DecimalFormat df = new global::NPOI.SS.Util.DecimalFormat("##########");

		// Token: 0x0400007E RID: 126
		private string str;
	}
}
