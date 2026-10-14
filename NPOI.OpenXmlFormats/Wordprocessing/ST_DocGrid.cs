using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000083 RID: 131
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Serializable]
	public enum ST_DocGrid
	{
		// Token: 0x04000352 RID: 850
		@default,
		// Token: 0x04000353 RID: 851
		lines,
		// Token: 0x04000354 RID: 852
		linesAndChars,
		// Token: 0x04000355 RID: 853
		snapToChars
	}
}
