using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000080 RID: 128
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Serializable]
	public enum ST_DocPartType
	{
		// Token: 0x0400033E RID: 830
		none,
		// Token: 0x0400033F RID: 831
		normal,
		// Token: 0x04000340 RID: 832
		autoExp,
		// Token: 0x04000341 RID: 833
		toolbar,
		// Token: 0x04000342 RID: 834
		speller,
		// Token: 0x04000343 RID: 835
		formFld,
		// Token: 0x04000344 RID: 836
		bbPlcHdr
	}
}
