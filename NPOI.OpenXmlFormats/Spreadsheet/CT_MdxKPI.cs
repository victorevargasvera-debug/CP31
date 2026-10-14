using System;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005D7 RID: 1495
	public class CT_MdxKPI
	{
		// Token: 0x170018D1 RID: 6353
		// (get) Token: 0x060041E8 RID: 16872 RVA: 0x0009F00C File Offset: 0x0009D20C
		// (set) Token: 0x060041E9 RID: 16873 RVA: 0x0009F014 File Offset: 0x0009D214
		public uint n
		{
			get
			{
				return this.nField;
			}
			set
			{
				this.nField = value;
			}
		}

		// Token: 0x170018D2 RID: 6354
		// (get) Token: 0x060041EA RID: 16874 RVA: 0x0009F01D File Offset: 0x0009D21D
		// (set) Token: 0x060041EB RID: 16875 RVA: 0x0009F025 File Offset: 0x0009D225
		public uint np
		{
			get
			{
				return this.npField;
			}
			set
			{
				this.npField = value;
			}
		}

		// Token: 0x170018D3 RID: 6355
		// (get) Token: 0x060041EC RID: 16876 RVA: 0x0009F02E File Offset: 0x0009D22E
		// (set) Token: 0x060041ED RID: 16877 RVA: 0x0009F036 File Offset: 0x0009D236
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_MdxKPIProperty p
		{
			get
			{
				return this.pField;
			}
			set
			{
				this.pField = value;
			}
		}

		// Token: 0x0400297B RID: 10619
		private uint nField;

		// Token: 0x0400297C RID: 10620
		private uint npField;

		// Token: 0x0400297D RID: 10621
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_MdxKPIProperty pField;
	}
}
