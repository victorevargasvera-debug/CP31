using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Vml
{
	// Token: 0x020001F8 RID: 504
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:vml")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:vml", IsNullable = false)]
	[global::System.Serializable]
	public enum ST_Ext
	{
		// Token: 0x04000FBA RID: 4026
		NONE,
		// Token: 0x04000FBB RID: 4027
		view,
		// Token: 0x04000FBC RID: 4028
		edit,
		// Token: 0x04000FBD RID: 4029
		backwardCompatible
	}
}
