using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Vml.Office
{
	// Token: 0x0200020E RID: 526
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:office:office")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:office:office", IsNullable = false)]
	[global::System.Serializable]
	public enum ST_ExtrusionRender
	{
		// Token: 0x04001107 RID: 4359
		solid,
		// Token: 0x04001108 RID: 4360
		wireFrame,
		// Token: 0x04001109 RID: 4361
		boundingCube
	}
}
