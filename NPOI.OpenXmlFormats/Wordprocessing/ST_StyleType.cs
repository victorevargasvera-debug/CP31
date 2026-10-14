using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200010C RID: 268
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Serializable]
	public enum ST_StyleType
	{
		// Token: 0x04000666 RID: 1638
		paragraph,
		// Token: 0x04000667 RID: 1639
		character,
		// Token: 0x04000668 RID: 1640
		table,
		// Token: 0x04000669 RID: 1641
		numbering
	}
}
