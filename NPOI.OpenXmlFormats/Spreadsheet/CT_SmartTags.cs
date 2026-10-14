using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005C7 RID: 1479
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_SmartTags
	{
		// Token: 0x06004159 RID: 16729 RVA: 0x0009E19B File Offset: 0x0009C39B
		public CT_SmartTags()
		{
			this.cellSmartTagsField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellSmartTags>();
		}

		// Token: 0x1700189A RID: 6298
		// (get) Token: 0x0600415A RID: 16730 RVA: 0x0009E1AE File Offset: 0x0009C3AE
		// (set) Token: 0x0600415B RID: 16731 RVA: 0x0009E1B6 File Offset: 0x0009C3B6
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellSmartTags> cellSmartTags
		{
			get
			{
				return this.cellSmartTagsField;
			}
			set
			{
				this.cellSmartTagsField = value;
			}
		}

		// Token: 0x04002944 RID: 10564
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellSmartTags> cellSmartTagsField;
	}
}
