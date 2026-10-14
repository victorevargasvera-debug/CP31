using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Vml.Wordprocessing
{
	// Token: 0x020001FF RID: 511
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:office:word")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:office:word", IsNullable = false)]
	[global::System.Serializable]
	public enum ST_HorizontalAnchor
	{
		// Token: 0x04000FF8 RID: 4088
		margin,
		// Token: 0x04000FF9 RID: 4089
		page,
		// Token: 0x04000FFA RID: 4090
		text,
		// Token: 0x04000FFB RID: 4091
		@char
	}
}
