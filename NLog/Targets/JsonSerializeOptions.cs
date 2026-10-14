using System;
using System.ComponentModel;

namespace NLog.Targets
{
	// Token: 0x0200003F RID: 63
	public class JsonSerializeOptions
	{
		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000617 RID: 1559 RVA: 0x0000EEE2 File Offset: 0x0000D0E2
		// (set) Token: 0x06000618 RID: 1560 RVA: 0x0000EEEA File Offset: 0x0000D0EA
		[global::System.ComponentModel.DefaultValue(true)]
		public bool QuoteKeys { get; set; }

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000619 RID: 1561 RVA: 0x0000EEF3 File Offset: 0x0000D0F3
		// (set) Token: 0x0600061A RID: 1562 RVA: 0x0000EEFB File Offset: 0x0000D0FB
		public global::System.IFormatProvider FormatProvider { get; set; }

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x0600061B RID: 1563 RVA: 0x0000EF04 File Offset: 0x0000D104
		// (set) Token: 0x0600061C RID: 1564 RVA: 0x0000EF0C File Offset: 0x0000D10C
		public string Format { get; set; }

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600061D RID: 1565 RVA: 0x0000EF15 File Offset: 0x0000D115
		// (set) Token: 0x0600061E RID: 1566 RVA: 0x0000EF1D File Offset: 0x0000D11D
		[global::System.ComponentModel.DefaultValue(false)]
		public bool EscapeUnicode { get; set; }

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600061F RID: 1567 RVA: 0x0000EF26 File Offset: 0x0000D126
		// (set) Token: 0x06000620 RID: 1568 RVA: 0x0000EF2E File Offset: 0x0000D12E
		[global::System.ComponentModel.DefaultValue(false)]
		public bool EnumAsInteger { get; set; }

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000621 RID: 1569 RVA: 0x0000EF37 File Offset: 0x0000D137
		// (set) Token: 0x06000622 RID: 1570 RVA: 0x0000EF3F File Offset: 0x0000D13F
		[global::System.ComponentModel.DefaultValue(false)]
		public bool SanitizeDictionaryKeys { get; set; }

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000623 RID: 1571 RVA: 0x0000EF48 File Offset: 0x0000D148
		// (set) Token: 0x06000624 RID: 1572 RVA: 0x0000EF50 File Offset: 0x0000D150
		[global::System.ComponentModel.DefaultValue(10)]
		public int MaxRecursionLimit { get; set; }

		// Token: 0x06000625 RID: 1573 RVA: 0x0000EF59 File Offset: 0x0000D159
		public JsonSerializeOptions()
		{
			this.QuoteKeys = true;
			this.MaxRecursionLimit = 10;
		}
	}
}
