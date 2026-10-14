using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000600 RID: 1536
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = false)]
	[global::System.Serializable]
	public enum ST_DdeValueType
	{
		// Token: 0x04002A7B RID: 10875
		nil,
		// Token: 0x04002A7C RID: 10876
		b,
		// Token: 0x04002A7D RID: 10877
		n,
		// Token: 0x04002A7E RID: 10878
		e,
		// Token: 0x04002A7F RID: 10879
		str
	}
}
