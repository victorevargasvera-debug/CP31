using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000163 RID: 355
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Serializable]
	public enum ST_LineSpacingRule
	{
		// Token: 0x04000A24 RID: 2596
		nil,
		// Token: 0x04000A25 RID: 2597
		auto,
		// Token: 0x04000A26 RID: 2598
		exact,
		// Token: 0x04000A27 RID: 2599
		atLeast
	}
}
