using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000304 RID: 772
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = false)]
	[global::System.Serializable]
	public enum ST_TextVertOverflowType
	{
		// Token: 0x040017F1 RID: 6129
		overflow,
		// Token: 0x040017F2 RID: 6130
		ellipsis,
		// Token: 0x040017F3 RID: 6131
		clip
	}
}
