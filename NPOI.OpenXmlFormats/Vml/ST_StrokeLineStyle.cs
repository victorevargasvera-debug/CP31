using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Vml
{
	// Token: 0x020001DE RID: 478
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:vml")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:vml", IsNullable = false)]
	[global::System.Serializable]
	public enum ST_StrokeLineStyle
	{
		// Token: 0x04000E86 RID: 3718
		single,
		// Token: 0x04000E87 RID: 3719
		thinThin,
		// Token: 0x04000E88 RID: 3720
		thinThick,
		// Token: 0x04000E89 RID: 3721
		thickThin,
		// Token: 0x04000E8A RID: 3722
		thickBetweenThin
	}
}
