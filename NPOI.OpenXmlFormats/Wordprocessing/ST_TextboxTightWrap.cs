using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200013F RID: 319
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Serializable]
	public enum ST_TextboxTightWrap
	{
		// Token: 0x040007BC RID: 1980
		none,
		// Token: 0x040007BD RID: 1981
		allLines,
		// Token: 0x040007BE RID: 1982
		firstAndLastLine,
		// Token: 0x040007BF RID: 1983
		firstLineOnly,
		// Token: 0x040007C0 RID: 1984
		lastLineOnly
	}
}
