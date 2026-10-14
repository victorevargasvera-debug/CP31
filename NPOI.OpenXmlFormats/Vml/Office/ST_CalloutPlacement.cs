using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Vml.Office
{
	// Token: 0x02000231 RID: 561
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:office:office")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:office:office", IsNullable = false)]
	[global::System.Serializable]
	public enum ST_CalloutPlacement
	{
		// Token: 0x04001204 RID: 4612
		top,
		// Token: 0x04001205 RID: 4613
		center,
		// Token: 0x04001206 RID: 4614
		bottom,
		// Token: 0x04001207 RID: 4615
		user
	}
}
