using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000B2 RID: 178
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Serializable]
	public enum ST_RestartNumber
	{
		// Token: 0x04000469 RID: 1129
		continuous,
		// Token: 0x0400046A RID: 1130
		eachSect,
		// Token: 0x0400046B RID: 1131
		eachPage
	}
}
