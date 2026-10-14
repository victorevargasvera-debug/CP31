using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x02000632 RID: 1586
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Serializable]
	public enum ST_OnOff
	{
		// Token: 0x04002B28 RID: 11048
		[global::System.Xml.Serialization.XmlEnum("0")]
		Value0,
		// Token: 0x04002B29 RID: 11049
		[global::System.Xml.Serialization.XmlEnum("1")]
		Value1,
		// Token: 0x04002B2A RID: 11050
		on,
		// Token: 0x04002B2B RID: 11051
		off
	}
}
