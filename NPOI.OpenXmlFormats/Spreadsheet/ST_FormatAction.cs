using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004CF RID: 1231
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = false)]
	public enum ST_FormatAction
	{
		// Token: 0x0400224B RID: 8779
		blank,
		// Token: 0x0400224C RID: 8780
		formatting,
		// Token: 0x0400224D RID: 8781
		drill,
		// Token: 0x0400224E RID: 8782
		formula
	}
}
