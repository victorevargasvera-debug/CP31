using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x02000634 RID: 1588
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Serializable]
	public enum ST_BreakBinSub
	{
		// Token: 0x04002B2F RID: 11055
		[global::System.Xml.Serialization.XmlEnum("--")]
		Item,
		// Token: 0x04002B30 RID: 11056
		[global::System.Xml.Serialization.XmlEnum("-+")]
		Item1,
		// Token: 0x04002B31 RID: 11057
		[global::System.Xml.Serialization.XmlEnum("+-")]
		Item2
	}
}
