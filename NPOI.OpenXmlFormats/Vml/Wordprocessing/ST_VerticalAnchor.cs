using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Vml.Wordprocessing
{
	// Token: 0x02000200 RID: 512
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:office:word")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:office:word", IsNullable = false)]
	[global::System.Serializable]
	public enum ST_VerticalAnchor
	{
		// Token: 0x04000FFD RID: 4093
		margin,
		// Token: 0x04000FFE RID: 4094
		page,
		// Token: 0x04000FFF RID: 4095
		text,
		// Token: 0x04001000 RID: 4096
		line
	}
}
