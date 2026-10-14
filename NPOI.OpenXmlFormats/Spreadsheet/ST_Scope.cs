using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004D3 RID: 1235
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = false)]
	public enum ST_Scope
	{
		// Token: 0x0400225A RID: 8794
		selection,
		// Token: 0x0400225B RID: 8795
		data,
		// Token: 0x0400225C RID: 8796
		field
	}
}
