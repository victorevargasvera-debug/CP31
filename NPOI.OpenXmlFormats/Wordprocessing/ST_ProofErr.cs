using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000BF RID: 191
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Serializable]
	public enum ST_ProofErr
	{
		// Token: 0x040004A8 RID: 1192
		spellStart,
		// Token: 0x040004A9 RID: 1193
		spellEnd,
		// Token: 0x040004AA RID: 1194
		gramStart,
		// Token: 0x040004AB RID: 1195
		gramEnd
	}
}
