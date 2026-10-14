using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200053A RID: 1338
	public class CT_IconFilter
	{
		// Token: 0x170015E9 RID: 5609
		// (get) Token: 0x06003AA2 RID: 15010 RVA: 0x00091117 File Offset: 0x0008F317
		// (set) Token: 0x06003AA3 RID: 15011 RVA: 0x0009111F File Offset: 0x0008F31F
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_IconSetType iconSet
		{
			get
			{
				return this.iconSetField;
			}
			set
			{
				this.iconSetField = value;
			}
		}

		// Token: 0x170015EA RID: 5610
		// (get) Token: 0x06003AA4 RID: 15012 RVA: 0x00091128 File Offset: 0x0008F328
		// (set) Token: 0x06003AA5 RID: 15013 RVA: 0x00091130 File Offset: 0x0008F330
		public uint iconId
		{
			get
			{
				return this.iconIdField;
			}
			set
			{
				this.iconIdField = value;
			}
		}

		// Token: 0x170015EB RID: 5611
		// (get) Token: 0x06003AA6 RID: 15014 RVA: 0x00091139 File Offset: 0x0008F339
		// (set) Token: 0x06003AA7 RID: 15015 RVA: 0x00091141 File Offset: 0x0008F341
		[global::System.Xml.Serialization.XmlIgnore]
		public bool iconIdSpecified
		{
			get
			{
				return this.iconIdFieldSpecified;
			}
			set
			{
				this.iconIdFieldSpecified = value;
			}
		}

		// Token: 0x04002581 RID: 9601
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_IconSetType iconSetField;

		// Token: 0x04002582 RID: 9602
		private uint iconIdField;

		// Token: 0x04002583 RID: 9603
		private bool iconIdFieldSpecified;
	}
}
