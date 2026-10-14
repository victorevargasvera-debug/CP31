using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats
{
	// Token: 0x02000037 RID: 55
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = false)]
	[global::System.Serializable]
	public enum ST_ExternalConnectionType
	{
		// Token: 0x04000174 RID: 372
		general,
		// Token: 0x04000175 RID: 373
		text,
		// Token: 0x04000176 RID: 374
		MDY,
		// Token: 0x04000177 RID: 375
		DMY,
		// Token: 0x04000178 RID: 376
		YMD,
		// Token: 0x04000179 RID: 377
		MYD,
		// Token: 0x0400017A RID: 378
		DYM,
		// Token: 0x0400017B RID: 379
		YDM,
		// Token: 0x0400017C RID: 380
		skip,
		// Token: 0x0400017D RID: 381
		EMD
	}
}
