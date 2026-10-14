using System;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005DE RID: 1502
	public class CT_Mdx
	{
		// Token: 0x170018E9 RID: 6377
		// (get) Token: 0x0600421D RID: 16925 RVA: 0x0009F20A File Offset: 0x0009D40A
		// (set) Token: 0x0600421E RID: 16926 RVA: 0x0009F212 File Offset: 0x0009D412
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
			}
		}

		// Token: 0x170018EA RID: 6378
		// (get) Token: 0x0600421F RID: 16927 RVA: 0x0009F21B File Offset: 0x0009D41B
		// (set) Token: 0x06004220 RID: 16928 RVA: 0x0009F223 File Offset: 0x0009D423
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

		// Token: 0x170018EB RID: 6379
		// (get) Token: 0x06004221 RID: 16929 RVA: 0x0009F22C File Offset: 0x0009D42C
		// (set) Token: 0x06004222 RID: 16930 RVA: 0x0009F234 File Offset: 0x0009D434
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_MdxFunctionType f
		{
			get
			{
				return this.fField;
			}
			set
			{
				this.fField = value;
			}
		}

		// Token: 0x040029A2 RID: 10658
		private object itemField;

		// Token: 0x040029A3 RID: 10659
		private uint nField;

		// Token: 0x040029A4 RID: 10660
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_MdxFunctionType fField;
	}
}
