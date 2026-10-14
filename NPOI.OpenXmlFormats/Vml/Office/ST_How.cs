using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Vml.Office
{
	// Token: 0x02000220 RID: 544
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:office:office")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:office:office", IsNullable = false)]
	[global::System.Serializable]
	public enum ST_How
	{
		// Token: 0x0400117B RID: 4475
		NONE,
		// Token: 0x0400117C RID: 4476
		top,
		// Token: 0x0400117D RID: 4477
		middle,
		// Token: 0x0400117E RID: 4478
		bottom,
		// Token: 0x0400117F RID: 4479
		left,
		// Token: 0x04001180 RID: 4480
		center,
		// Token: 0x04001181 RID: 4481
		right
	}
}
