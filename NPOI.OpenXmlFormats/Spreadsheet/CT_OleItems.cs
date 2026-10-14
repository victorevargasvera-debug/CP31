using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200060D RID: 1549
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_OleItems
	{
		// Token: 0x17001991 RID: 6545
		// (get) Token: 0x060043BC RID: 17340 RVA: 0x000A1369 File Offset: 0x0009F569
		// (set) Token: 0x060043BD RID: 17341 RVA: 0x000A1371 File Offset: 0x0009F571
		[global::System.Xml.Serialization.XmlElement("oleItem")]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_OleItem[] oleItem
		{
			get
			{
				return this.oleItemField;
			}
			set
			{
				this.oleItemField = value;
			}
		}

		// Token: 0x04002A9D RID: 10909
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_OleItem[] oleItemField;
	}
}
