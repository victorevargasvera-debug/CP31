using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000559 RID: 1369
	public class CT_SheetIdMap
	{
		// Token: 0x06003B71 RID: 15217 RVA: 0x00092D2F File Offset: 0x00090F2F
		public CT_SheetIdMap()
		{
			this.sheetIdField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetId>();
		}

		// Token: 0x1700162D RID: 5677
		// (get) Token: 0x06003B72 RID: 15218 RVA: 0x00092D42 File Offset: 0x00090F42
		// (set) Token: 0x06003B73 RID: 15219 RVA: 0x00092D4A File Offset: 0x00090F4A
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetId> sheetId
		{
			get
			{
				return this.sheetIdField;
			}
			set
			{
				this.sheetIdField = value;
			}
		}

		// Token: 0x1700162E RID: 5678
		// (get) Token: 0x06003B74 RID: 15220 RVA: 0x00092D53 File Offset: 0x00090F53
		// (set) Token: 0x06003B75 RID: 15221 RVA: 0x00092D5B File Offset: 0x00090F5B
		public uint count
		{
			get
			{
				return this.countField;
			}
			set
			{
				this.countField = value;
			}
		}

		// Token: 0x1700162F RID: 5679
		// (get) Token: 0x06003B76 RID: 15222 RVA: 0x00092D64 File Offset: 0x00090F64
		// (set) Token: 0x06003B77 RID: 15223 RVA: 0x00092D6C File Offset: 0x00090F6C
		[global::System.Xml.Serialization.XmlIgnore]
		public bool countSpecified
		{
			get
			{
				return this.countFieldSpecified;
			}
			set
			{
				this.countFieldSpecified = value;
			}
		}

		// Token: 0x0400262C RID: 9772
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetId> sheetIdField;

		// Token: 0x0400262D RID: 9773
		private uint countField;

		// Token: 0x0400262E RID: 9774
		private bool countFieldSpecified;
	}
}
