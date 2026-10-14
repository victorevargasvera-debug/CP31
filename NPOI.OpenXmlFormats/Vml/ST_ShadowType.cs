using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Vml
{
	// Token: 0x020001DC RID: 476
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:vml")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:vml", IsNullable = false)]
	[global::System.Serializable]
	public enum ST_ShadowType
	{
		// Token: 0x04000E5B RID: 3675
		single,
		// Token: 0x04000E5C RID: 3676
		@double,
		// Token: 0x04000E5D RID: 3677
		emboss,
		// Token: 0x04000E5E RID: 3678
		perspective
	}
}
