using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000487 RID: 1159
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = false)]
	public enum ST_SourceType
	{
		// Token: 0x04002005 RID: 8197
		worksheet,
		// Token: 0x04002006 RID: 8198
		external,
		// Token: 0x04002007 RID: 8199
		consolidation,
		// Token: 0x04002008 RID: 8200
		scenario
	}
}
