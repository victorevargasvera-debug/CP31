using System;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Spreadsheet
{
	// Token: 0x02000374 RID: 884
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing")]
	[global::System.Serializable]
	public class CT_LegacyDrawing
	{
		// Token: 0x17000D3E RID: 3390
		// (get) Token: 0x06002344 RID: 9028 RVA: 0x0005BEF3 File Offset: 0x0005A0F3
		// (set) Token: 0x06002345 RID: 9029 RVA: 0x0005BEFB File Offset: 0x0005A0FB
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/relationships")]
		public string id
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

		// Token: 0x04001A60 RID: 6752
		private string idField;
	}
}
