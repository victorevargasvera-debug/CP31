using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000122 RID: 290
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Serializable]
	public enum ST_FtnEdn
	{
		// Token: 0x04000724 RID: 1828
		normal,
		// Token: 0x04000725 RID: 1829
		separator,
		// Token: 0x04000726 RID: 1830
		continuationSeparator,
		// Token: 0x04000727 RID: 1831
		continuationNotice
	}
}
