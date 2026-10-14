using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005FF RID: 1535
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DdeValue
	{
		// Token: 0x0600435A RID: 17242 RVA: 0x000A03B0 File Offset: 0x0009E5B0
		public CT_DdeValue()
		{
			this.tField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_DdeValueType.n;
		}

		// Token: 0x17001972 RID: 6514
		// (get) Token: 0x0600435B RID: 17243 RVA: 0x000A03BF File Offset: 0x0009E5BF
		// (set) Token: 0x0600435C RID: 17244 RVA: 0x000A03C7 File Offset: 0x0009E5C7
		public string val
		{
			get
			{
				return this.valField;
			}
			set
			{
				this.valField = value;
			}
		}

		// Token: 0x17001973 RID: 6515
		// (get) Token: 0x0600435D RID: 17245 RVA: 0x000A03D0 File Offset: 0x0009E5D0
		// (set) Token: 0x0600435E RID: 17246 RVA: 0x000A03D8 File Offset: 0x0009E5D8
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_DdeValueType.n)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_DdeValueType t
		{
			get
			{
				return this.tField;
			}
			set
			{
				this.tField = value;
			}
		}

		// Token: 0x04002A78 RID: 10872
		private string valField;

		// Token: 0x04002A79 RID: 10873
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_DdeValueType tField;
	}
}
