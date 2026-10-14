using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005F2 RID: 1522
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = false)]
	[global::System.Serializable]
	public enum ST_GrowShrinkType
	{
		// Token: 0x04002A42 RID: 10818
		insertDelete,
		// Token: 0x04002A43 RID: 10819
		insertClear,
		// Token: 0x04002A44 RID: 10820
		overwriteClear
	}
}
