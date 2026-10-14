using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004D4 RID: 1236
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = false)]
	public enum ST_Type
	{
		// Token: 0x0400225E RID: 8798
		none,
		// Token: 0x0400225F RID: 8799
		all,
		// Token: 0x04002260 RID: 8800
		row,
		// Token: 0x04002261 RID: 8801
		column
	}
}
