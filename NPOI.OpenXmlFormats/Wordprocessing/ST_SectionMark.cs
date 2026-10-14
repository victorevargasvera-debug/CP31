using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000CD RID: 205
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Serializable]
	public enum ST_SectionMark
	{
		// Token: 0x040004EC RID: 1260
		nextPage,
		// Token: 0x040004ED RID: 1261
		nextColumn,
		// Token: 0x040004EE RID: 1262
		continuous,
		// Token: 0x040004EF RID: 1263
		evenPage,
		// Token: 0x040004F0 RID: 1264
		oddPage
	}
}
