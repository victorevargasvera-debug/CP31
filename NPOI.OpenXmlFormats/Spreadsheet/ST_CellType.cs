using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000587 RID: 1415
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public enum ST_CellType
	{
		// Token: 0x04002778 RID: 10104
		b,
		// Token: 0x04002779 RID: 10105
		n,
		// Token: 0x0400277A RID: 10106
		e,
		// Token: 0x0400277B RID: 10107
		s,
		// Token: 0x0400277C RID: 10108
		str,
		// Token: 0x0400277D RID: 10109
		inlineStr
	}
}
