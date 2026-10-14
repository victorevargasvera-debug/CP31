using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200011B RID: 283
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Serializable]
	public enum ST_HdrFtr
	{
		// Token: 0x040006F1 RID: 1777
		[global::System.Xml.Serialization.XmlEnum("even")]
		even,
		// Token: 0x040006F2 RID: 1778
		[global::System.Xml.Serialization.XmlEnum("default")]
		@default,
		// Token: 0x040006F3 RID: 1779
		[global::System.Xml.Serialization.XmlEnum("first")]
		first
	}
}
