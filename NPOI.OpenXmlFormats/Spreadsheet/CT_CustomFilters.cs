using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000531 RID: 1329
	public class CT_CustomFilters
	{
		// Token: 0x06003A68 RID: 14952 RVA: 0x00090F08 File Offset: 0x0008F108
		public CT_CustomFilters()
		{
			this.customFilterField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomFilter>();
			this.andField = false;
		}

		// Token: 0x170015CF RID: 5583
		// (get) Token: 0x06003A69 RID: 14953 RVA: 0x00090F22 File Offset: 0x0008F122
		// (set) Token: 0x06003A6A RID: 14954 RVA: 0x00090F2A File Offset: 0x0008F12A
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomFilter> customFilter
		{
			get
			{
				return this.customFilterField;
			}
			set
			{
				this.customFilterField = value;
			}
		}

		// Token: 0x170015D0 RID: 5584
		// (get) Token: 0x06003A6B RID: 14955 RVA: 0x00090F33 File Offset: 0x0008F133
		// (set) Token: 0x06003A6C RID: 14956 RVA: 0x00090F3B File Offset: 0x0008F13B
		[global::System.ComponentModel.DefaultValue(false)]
		public bool and
		{
			get
			{
				return this.andField;
			}
			set
			{
				this.andField = value;
			}
		}

		// Token: 0x04002535 RID: 9525
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CustomFilter> customFilterField;

		// Token: 0x04002536 RID: 9526
		private bool andField;
	}
}
