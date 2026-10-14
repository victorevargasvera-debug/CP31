using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004BF RID: 1215
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = false)]
	public enum ST_ItemType
	{
		// Token: 0x040021FF RID: 8703
		data,
		// Token: 0x04002200 RID: 8704
		@default,
		// Token: 0x04002201 RID: 8705
		sum,
		// Token: 0x04002202 RID: 8706
		countA,
		// Token: 0x04002203 RID: 8707
		avg,
		// Token: 0x04002204 RID: 8708
		max,
		// Token: 0x04002205 RID: 8709
		min,
		// Token: 0x04002206 RID: 8710
		product,
		// Token: 0x04002207 RID: 8711
		count,
		// Token: 0x04002208 RID: 8712
		stdDev,
		// Token: 0x04002209 RID: 8713
		stdDevP,
		// Token: 0x0400220A RID: 8714
		var,
		// Token: 0x0400220B RID: 8715
		varP,
		// Token: 0x0400220C RID: 8716
		grand,
		// Token: 0x0400220D RID: 8717
		blank
	}
}
