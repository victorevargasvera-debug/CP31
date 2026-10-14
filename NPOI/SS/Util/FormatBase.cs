using System;
using System.Globalization;
using System.Text;

namespace NPOI.SS.Util
{
	// Token: 0x0200001C RID: 28
	public abstract class FormatBase
	{
		// Token: 0x06000148 RID: 328 RVA: 0x0000253E File Offset: 0x0000073E
		public FormatBase()
		{
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00006B4D File Offset: 0x00004D4D
		public virtual string Format(object obj, global::System.Globalization.CultureInfo culture)
		{
			return obj.ToString();
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00006B55 File Offset: 0x00004D55
		public virtual string Format(object obj)
		{
			return this.Format(obj, new global::System.Text.StringBuilder(), 0).ToString();
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00006B69 File Offset: 0x00004D69
		protected virtual global::System.Text.StringBuilder Format(object obj, global::System.Text.StringBuilder sb, int pos)
		{
			return sb.Append(obj);
		}

		// Token: 0x0600014C RID: 332
		public abstract global::System.Text.StringBuilder Format(object obj, global::System.Text.StringBuilder toAppendTo, global::System.Globalization.CultureInfo culture);

		// Token: 0x0600014D RID: 333
		public abstract object ParseObject(string source, int pos);

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600014E RID: 334 RVA: 0x00006B72 File Offset: 0x00004D72
		// (set) Token: 0x0600014F RID: 335 RVA: 0x00006B7A File Offset: 0x00004D7A
		public global::System.TimeZoneInfo TimeZone { get; set; }
	}
}
