using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000E4 RID: 228
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Serializable]
	public enum ST_CalendarType
	{
		// Token: 0x04000593 RID: 1427
		gregorian,
		// Token: 0x04000594 RID: 1428
		hijri,
		// Token: 0x04000595 RID: 1429
		hebrew,
		// Token: 0x04000596 RID: 1430
		taiwan,
		// Token: 0x04000597 RID: 1431
		japan,
		// Token: 0x04000598 RID: 1432
		thai,
		// Token: 0x04000599 RID: 1433
		korea,
		// Token: 0x0400059A RID: 1434
		saka,
		// Token: 0x0400059B RID: 1435
		gregorianXlitEnglish,
		// Token: 0x0400059C RID: 1436
		gregorianXlitFrench
	}
}
