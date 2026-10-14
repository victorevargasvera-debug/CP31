using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats
{
	// Token: 0x02000038 RID: 56
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = false)]
	[global::System.Serializable]
	public enum ST_FileType
	{
		// Token: 0x0400017F RID: 383
		mac,
		// Token: 0x04000180 RID: 384
		win,
		// Token: 0x04000181 RID: 385
		dos
	}
}
