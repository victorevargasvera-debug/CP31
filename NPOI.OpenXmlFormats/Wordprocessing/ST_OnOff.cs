using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000041 RID: 65
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Serializable]
	public enum ST_OnOff
	{
		// Token: 0x040001A2 RID: 418
		off,
		// Token: 0x040001A3 RID: 419
		on,
		// Token: 0x040001A4 RID: 420
		[global::System.Xml.Serialization.XmlEnum("true")]
		True,
		// Token: 0x040001A5 RID: 421
		[global::System.Xml.Serialization.XmlEnum("false")]
		False
	}
}
