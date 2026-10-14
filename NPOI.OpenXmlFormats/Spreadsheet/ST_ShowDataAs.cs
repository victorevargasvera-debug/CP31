using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004CC RID: 1228
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = false)]
	public enum ST_ShowDataAs
	{
		// Token: 0x0400223A RID: 8762
		normal,
		// Token: 0x0400223B RID: 8763
		difference,
		// Token: 0x0400223C RID: 8764
		percent,
		// Token: 0x0400223D RID: 8765
		percentDiff,
		// Token: 0x0400223E RID: 8766
		runTotal,
		// Token: 0x0400223F RID: 8767
		percentOfRow,
		// Token: 0x04002240 RID: 8768
		percentOfCol,
		// Token: 0x04002241 RID: 8769
		percentOfTotal,
		// Token: 0x04002242 RID: 8770
		index
	}
}
