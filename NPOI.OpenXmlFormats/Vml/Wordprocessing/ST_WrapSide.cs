using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Vml.Wordprocessing
{
	// Token: 0x020001FE RID: 510
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:office:word")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:office:word", IsNullable = false)]
	[global::System.Serializable]
	public enum ST_WrapSide
	{
		// Token: 0x04000FF3 RID: 4083
		both,
		// Token: 0x04000FF4 RID: 4084
		left,
		// Token: 0x04000FF5 RID: 4085
		right,
		// Token: 0x04000FF6 RID: 4086
		largest
	}
}
