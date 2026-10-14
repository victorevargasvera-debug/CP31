using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000614 RID: 1556
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public enum ST_UnderlineValues
	{
		// Token: 0x04002AB2 RID: 10930
		none,
		// Token: 0x04002AB3 RID: 10931
		single,
		// Token: 0x04002AB4 RID: 10932
		[global::System.Xml.Serialization.XmlEnum("double")]
		@double,
		// Token: 0x04002AB5 RID: 10933
		singleAccounting,
		// Token: 0x04002AB6 RID: 10934
		doubleAccounting
	}
}
