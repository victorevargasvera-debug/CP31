using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x02000647 RID: 1607
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Serializable]
	public enum ST_Script
	{
		// Token: 0x04002B58 RID: 11096
		roman,
		// Token: 0x04002B59 RID: 11097
		script,
		// Token: 0x04002B5A RID: 11098
		fraktur,
		// Token: 0x04002B5B RID: 11099
		[global::System.Xml.Serialization.XmlEnum("double-struck")]
		doublestruck,
		// Token: 0x04002B5C RID: 11100
		[global::System.Xml.Serialization.XmlEnum("sans-serif")]
		sansserif,
		// Token: 0x04002B5D RID: 11101
		monospace
	}
}
