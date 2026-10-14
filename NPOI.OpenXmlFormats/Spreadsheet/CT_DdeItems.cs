using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200060C RID: 1548
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DdeItems
	{
		// Token: 0x17001990 RID: 6544
		// (get) Token: 0x060043B9 RID: 17337 RVA: 0x000A1358 File Offset: 0x0009F558
		// (set) Token: 0x060043BA RID: 17338 RVA: 0x000A1360 File Offset: 0x0009F560
		[global::System.Xml.Serialization.XmlElement("ddeItem")]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_DdeItem[] ddeItem
		{
			get
			{
				return this.ddeItemField;
			}
			set
			{
				this.ddeItemField = value;
			}
		}

		// Token: 0x04002A9C RID: 10908
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_DdeItem[] ddeItemField;
	}
}
