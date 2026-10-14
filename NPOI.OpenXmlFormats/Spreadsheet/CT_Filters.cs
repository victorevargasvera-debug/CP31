using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000536 RID: 1334
	public class CT_Filters
	{
		// Token: 0x06003A7D RID: 14973 RVA: 0x00090FCA File Offset: 0x0008F1CA
		public CT_Filters()
		{
			this.dateGroupItemField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_DateGroupItem>();
			this.filterField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Filter>();
			this.blankField = false;
			this.calendarTypeField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_CalendarType.none;
		}

		// Token: 0x170015D8 RID: 5592
		// (get) Token: 0x06003A7E RID: 14974 RVA: 0x00090FF6 File Offset: 0x0008F1F6
		// (set) Token: 0x06003A7F RID: 14975 RVA: 0x00090FFE File Offset: 0x0008F1FE
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Filter> filter
		{
			get
			{
				return this.filterField;
			}
			set
			{
				this.filterField = value;
			}
		}

		// Token: 0x170015D9 RID: 5593
		// (get) Token: 0x06003A80 RID: 14976 RVA: 0x00091007 File Offset: 0x0008F207
		// (set) Token: 0x06003A81 RID: 14977 RVA: 0x0009100F File Offset: 0x0008F20F
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_DateGroupItem> dateGroupItem
		{
			get
			{
				return this.dateGroupItemField;
			}
			set
			{
				this.dateGroupItemField = value;
			}
		}

		// Token: 0x170015DA RID: 5594
		// (get) Token: 0x06003A82 RID: 14978 RVA: 0x00091018 File Offset: 0x0008F218
		// (set) Token: 0x06003A83 RID: 14979 RVA: 0x00091020 File Offset: 0x0008F220
		[global::System.ComponentModel.DefaultValue(false)]
		public bool blank
		{
			get
			{
				return this.blankField;
			}
			set
			{
				this.blankField = value;
			}
		}

		// Token: 0x170015DB RID: 5595
		// (get) Token: 0x06003A84 RID: 14980 RVA: 0x00091029 File Offset: 0x0008F229
		// (set) Token: 0x06003A85 RID: 14981 RVA: 0x00091031 File Offset: 0x0008F231
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_CalendarType.none)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_CalendarType calendarType
		{
			get
			{
				return this.calendarTypeField;
			}
			set
			{
				this.calendarTypeField = value;
			}
		}

		// Token: 0x04002569 RID: 9577
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Filter> filterField;

		// Token: 0x0400256A RID: 9578
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_DateGroupItem> dateGroupItemField;

		// Token: 0x0400256B RID: 9579
		private bool blankField;

		// Token: 0x0400256C RID: 9580
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_CalendarType calendarTypeField;
	}
}
