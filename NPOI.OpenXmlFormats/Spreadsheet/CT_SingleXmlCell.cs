using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005E8 RID: 1512
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_SingleXmlCell
	{
		// Token: 0x06004241 RID: 16961 RVA: 0x0009F53E File Offset: 0x0009D73E
		public CT_SingleXmlCell()
		{
			this.extLstField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList();
			this.xmlCellPrField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_XmlCellPr();
		}

		// Token: 0x170018F7 RID: 6391
		// (get) Token: 0x06004242 RID: 16962 RVA: 0x0009F55C File Offset: 0x0009D75C
		// (set) Token: 0x06004243 RID: 16963 RVA: 0x0009F564 File Offset: 0x0009D764
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_XmlCellPr xmlCellPr
		{
			get
			{
				return this.xmlCellPrField;
			}
			set
			{
				this.xmlCellPrField = value;
			}
		}

		// Token: 0x170018F8 RID: 6392
		// (get) Token: 0x06004244 RID: 16964 RVA: 0x0009F56D File Offset: 0x0009D76D
		// (set) Token: 0x06004245 RID: 16965 RVA: 0x0009F575 File Offset: 0x0009D775
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLst
		{
			get
			{
				return this.extLstField;
			}
			set
			{
				this.extLstField = value;
			}
		}

		// Token: 0x170018F9 RID: 6393
		// (get) Token: 0x06004246 RID: 16966 RVA: 0x0009F57E File Offset: 0x0009D77E
		// (set) Token: 0x06004247 RID: 16967 RVA: 0x0009F586 File Offset: 0x0009D786
		[global::System.Xml.Serialization.XmlAttribute]
		public uint id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		// Token: 0x170018FA RID: 6394
		// (get) Token: 0x06004248 RID: 16968 RVA: 0x0009F58F File Offset: 0x0009D78F
		// (set) Token: 0x06004249 RID: 16969 RVA: 0x0009F597 File Offset: 0x0009D797
		[global::System.Xml.Serialization.XmlAttribute]
		public string r
		{
			get
			{
				return this.rField;
			}
			set
			{
				this.rField = value;
			}
		}

		// Token: 0x170018FB RID: 6395
		// (get) Token: 0x0600424A RID: 16970 RVA: 0x0009F5A0 File Offset: 0x0009D7A0
		// (set) Token: 0x0600424B RID: 16971 RVA: 0x0009F5A8 File Offset: 0x0009D7A8
		[global::System.Xml.Serialization.XmlAttribute]
		public uint connectionId
		{
			get
			{
				return this.connectionIdField;
			}
			set
			{
				this.connectionIdField = value;
			}
		}

		// Token: 0x040029F5 RID: 10741
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_XmlCellPr xmlCellPrField;

		// Token: 0x040029F6 RID: 10742
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;

		// Token: 0x040029F7 RID: 10743
		private uint idField;

		// Token: 0x040029F8 RID: 10744
		private string rField;

		// Token: 0x040029F9 RID: 10745
		private uint connectionIdField;
	}
}
