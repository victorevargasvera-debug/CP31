using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000306 RID: 774
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = false)]
	[global::System.Serializable]
	public enum ST_TextVerticalType
	{
		// Token: 0x040017F8 RID: 6136
		horz,
		// Token: 0x040017F9 RID: 6137
		vert,
		// Token: 0x040017FA RID: 6138
		vert270,
		// Token: 0x040017FB RID: 6139
		wordArtVert,
		// Token: 0x040017FC RID: 6140
		eaVert,
		// Token: 0x040017FD RID: 6141
		mongolianVert,
		// Token: 0x040017FE RID: 6142
		wordArtVertRtl
	}
}
