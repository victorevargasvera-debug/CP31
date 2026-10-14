using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005E9 RID: 1513
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_XmlCellPr
	{
		// Token: 0x0600424C RID: 16972 RVA: 0x0009F5B1 File Offset: 0x0009D7B1
		public CT_XmlCellPr()
		{
			this.extLstField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList();
			this.xmlPrField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_XmlPr();
		}

		// Token: 0x170018FC RID: 6396
		// (get) Token: 0x0600424D RID: 16973 RVA: 0x0009F5CF File Offset: 0x0009D7CF
		// (set) Token: 0x0600424E RID: 16974 RVA: 0x0009F5D7 File Offset: 0x0009D7D7
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_XmlPr xmlPr
		{
			get
			{
				return this.xmlPrField;
			}
			set
			{
				this.xmlPrField = value;
			}
		}

		// Token: 0x170018FD RID: 6397
		// (get) Token: 0x0600424F RID: 16975 RVA: 0x0009F5E0 File Offset: 0x0009D7E0
		// (set) Token: 0x06004250 RID: 16976 RVA: 0x0009F5E8 File Offset: 0x0009D7E8
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

		// Token: 0x170018FE RID: 6398
		// (get) Token: 0x06004251 RID: 16977 RVA: 0x0009F5F1 File Offset: 0x0009D7F1
		// (set) Token: 0x06004252 RID: 16978 RVA: 0x0009F5F9 File Offset: 0x0009D7F9
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

		// Token: 0x170018FF RID: 6399
		// (get) Token: 0x06004253 RID: 16979 RVA: 0x0009F602 File Offset: 0x0009D802
		// (set) Token: 0x06004254 RID: 16980 RVA: 0x0009F60A File Offset: 0x0009D80A
		[global::System.Xml.Serialization.XmlAttribute]
		public string uniqueName
		{
			get
			{
				return this.uniqueNameField;
			}
			set
			{
				this.uniqueNameField = value;
			}
		}

		// Token: 0x040029FA RID: 10746
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_XmlPr xmlPrField;

		// Token: 0x040029FB RID: 10747
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;

		// Token: 0x040029FC RID: 10748
		private uint idField;

		// Token: 0x040029FD RID: 10749
		private string uniqueNameField;
	}
}
