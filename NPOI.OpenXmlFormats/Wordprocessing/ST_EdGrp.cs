using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000C2 RID: 194
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Serializable]
	public enum ST_EdGrp
	{
		// Token: 0x040004B5 RID: 1205
		none,
		// Token: 0x040004B6 RID: 1206
		everyone,
		// Token: 0x040004B7 RID: 1207
		administrators,
		// Token: 0x040004B8 RID: 1208
		contributors,
		// Token: 0x040004B9 RID: 1209
		editors,
		// Token: 0x040004BA RID: 1210
		owners,
		// Token: 0x040004BB RID: 1211
		current
	}
}
