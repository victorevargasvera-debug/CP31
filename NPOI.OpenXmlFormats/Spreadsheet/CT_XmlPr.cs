using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005EA RID: 1514
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_XmlPr
	{
		// Token: 0x06004255 RID: 16981 RVA: 0x0009F613 File Offset: 0x0009D813
		public CT_XmlPr()
		{
			this.extLstField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList();
		}

		// Token: 0x17001900 RID: 6400
		// (get) Token: 0x06004256 RID: 16982 RVA: 0x0009F626 File Offset: 0x0009D826
		// (set) Token: 0x06004257 RID: 16983 RVA: 0x0009F62E File Offset: 0x0009D82E
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

		// Token: 0x17001901 RID: 6401
		// (get) Token: 0x06004258 RID: 16984 RVA: 0x0009F637 File Offset: 0x0009D837
		// (set) Token: 0x06004259 RID: 16985 RVA: 0x0009F63F File Offset: 0x0009D83F
		[global::System.Xml.Serialization.XmlAttribute]
		public uint mapId
		{
			get
			{
				return this.mapIdField;
			}
			set
			{
				this.mapIdField = value;
			}
		}

		// Token: 0x17001902 RID: 6402
		// (get) Token: 0x0600425A RID: 16986 RVA: 0x0009F648 File Offset: 0x0009D848
		// (set) Token: 0x0600425B RID: 16987 RVA: 0x0009F650 File Offset: 0x0009D850
		[global::System.Xml.Serialization.XmlAttribute]
		public string xpath
		{
			get
			{
				return this.xpathField;
			}
			set
			{
				this.xpathField = value;
			}
		}

		// Token: 0x17001903 RID: 6403
		// (get) Token: 0x0600425C RID: 16988 RVA: 0x0009F659 File Offset: 0x0009D859
		// (set) Token: 0x0600425D RID: 16989 RVA: 0x0009F661 File Offset: 0x0009D861
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_XmlDataType xmlDataType
		{
			get
			{
				return this.xmlDataTypeField;
			}
			set
			{
				this.xmlDataTypeField = value;
			}
		}

		// Token: 0x040029FE RID: 10750
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;

		// Token: 0x040029FF RID: 10751
		private uint mapIdField;

		// Token: 0x04002A00 RID: 10752
		private string xpathField;

		// Token: 0x04002A01 RID: 10753
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_XmlDataType xmlDataTypeField;
	}
}
