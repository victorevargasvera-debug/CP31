using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats
{
	// Token: 0x02000030 RID: 48
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_WebPr
	{
		// Token: 0x060001C0 RID: 448 RVA: 0x0000379C File Offset: 0x0000199C
		public CT_WebPr()
		{
			this.xmlField = false;
			this.sourceDataField = false;
			this.parsePreField = false;
			this.consecutiveField = false;
			this.firstRowField = false;
			this.xl97Field = false;
			this.textDatesField = false;
			this.xl2000Field = false;
			this.htmlTablesField = false;
			this.htmlFormatField = global::NPOI.OpenXmlFormats.ST_HtmlFmt.none;
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x000037F5 File Offset: 0x000019F5
		// (set) Token: 0x060001C2 RID: 450 RVA: 0x000037FD File Offset: 0x000019FD
		public global::NPOI.OpenXmlFormats.CT_Tables tables
		{
			get
			{
				return this.tablesField;
			}
			set
			{
				this.tablesField = value;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x00003806 File Offset: 0x00001A06
		// (set) Token: 0x060001C4 RID: 452 RVA: 0x0000380E File Offset: 0x00001A0E
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool xml
		{
			get
			{
				return this.xmlField;
			}
			set
			{
				this.xmlField = value;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x00003817 File Offset: 0x00001A17
		// (set) Token: 0x060001C6 RID: 454 RVA: 0x0000381F File Offset: 0x00001A1F
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool sourceData
		{
			get
			{
				return this.sourceDataField;
			}
			set
			{
				this.sourceDataField = value;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x00003828 File Offset: 0x00001A28
		// (set) Token: 0x060001C8 RID: 456 RVA: 0x00003830 File Offset: 0x00001A30
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool parsePre
		{
			get
			{
				return this.parsePreField;
			}
			set
			{
				this.parsePreField = value;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x00003839 File Offset: 0x00001A39
		// (set) Token: 0x060001CA RID: 458 RVA: 0x00003841 File Offset: 0x00001A41
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool consecutive
		{
			get
			{
				return this.consecutiveField;
			}
			set
			{
				this.consecutiveField = value;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060001CB RID: 459 RVA: 0x0000384A File Offset: 0x00001A4A
		// (set) Token: 0x060001CC RID: 460 RVA: 0x00003852 File Offset: 0x00001A52
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool firstRow
		{
			get
			{
				return this.firstRowField;
			}
			set
			{
				this.firstRowField = value;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060001CD RID: 461 RVA: 0x0000385B File Offset: 0x00001A5B
		// (set) Token: 0x060001CE RID: 462 RVA: 0x00003863 File Offset: 0x00001A63
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool xl97
		{
			get
			{
				return this.xl97Field;
			}
			set
			{
				this.xl97Field = value;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060001CF RID: 463 RVA: 0x0000386C File Offset: 0x00001A6C
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x00003874 File Offset: 0x00001A74
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool textDates
		{
			get
			{
				return this.textDatesField;
			}
			set
			{
				this.textDatesField = value;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x0000387D File Offset: 0x00001A7D
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x00003885 File Offset: 0x00001A85
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool xl2000
		{
			get
			{
				return this.xl2000Field;
			}
			set
			{
				this.xl2000Field = value;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x0000388E File Offset: 0x00001A8E
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x00003896 File Offset: 0x00001A96
		[global::System.Xml.Serialization.XmlAttribute]
		public string url
		{
			get
			{
				return this.urlField;
			}
			set
			{
				this.urlField = value;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x0000389F File Offset: 0x00001A9F
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x000038A7 File Offset: 0x00001AA7
		[global::System.Xml.Serialization.XmlAttribute]
		public string post
		{
			get
			{
				return this.postField;
			}
			set
			{
				this.postField = value;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x000038B0 File Offset: 0x00001AB0
		// (set) Token: 0x060001D8 RID: 472 RVA: 0x000038B8 File Offset: 0x00001AB8
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool htmlTables
		{
			get
			{
				return this.htmlTablesField;
			}
			set
			{
				this.htmlTablesField = value;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x000038C1 File Offset: 0x00001AC1
		// (set) Token: 0x060001DA RID: 474 RVA: 0x000038C9 File Offset: 0x00001AC9
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.ST_HtmlFmt.none)]
		public global::NPOI.OpenXmlFormats.ST_HtmlFmt htmlFormat
		{
			get
			{
				return this.htmlFormatField;
			}
			set
			{
				this.htmlFormatField = value;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060001DB RID: 475 RVA: 0x000038D2 File Offset: 0x00001AD2
		// (set) Token: 0x060001DC RID: 476 RVA: 0x000038DA File Offset: 0x00001ADA
		[global::System.Xml.Serialization.XmlAttribute]
		public string editPage
		{
			get
			{
				return this.editPageField;
			}
			set
			{
				this.editPageField = value;
			}
		}

		// Token: 0x0400014A RID: 330
		private global::NPOI.OpenXmlFormats.CT_Tables tablesField;

		// Token: 0x0400014B RID: 331
		private bool xmlField;

		// Token: 0x0400014C RID: 332
		private bool sourceDataField;

		// Token: 0x0400014D RID: 333
		private bool parsePreField;

		// Token: 0x0400014E RID: 334
		private bool consecutiveField;

		// Token: 0x0400014F RID: 335
		private bool firstRowField;

		// Token: 0x04000150 RID: 336
		private bool xl97Field;

		// Token: 0x04000151 RID: 337
		private bool textDatesField;

		// Token: 0x04000152 RID: 338
		private bool xl2000Field;

		// Token: 0x04000153 RID: 339
		private string urlField;

		// Token: 0x04000154 RID: 340
		private string postField;

		// Token: 0x04000155 RID: 341
		private bool htmlTablesField;

		// Token: 0x04000156 RID: 342
		private global::NPOI.OpenXmlFormats.ST_HtmlFmt htmlFormatField;

		// Token: 0x04000157 RID: 343
		private string editPageField;
	}
}
