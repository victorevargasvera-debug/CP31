using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Vml.Office
{
	// Token: 0x02000225 RID: 549
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:office:office")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:office:office", IsNullable = false)]
	[global::System.Serializable]
	public enum ST_OLELinkType
	{
		// Token: 0x040011A6 RID: 4518
		Picture,
		// Token: 0x040011A7 RID: 4519
		Bitmap,
		// Token: 0x040011A8 RID: 4520
		EnhancedMetaFile
	}
}
