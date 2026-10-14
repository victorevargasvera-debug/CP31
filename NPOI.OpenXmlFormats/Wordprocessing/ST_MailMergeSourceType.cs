using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000189 RID: 393
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Serializable]
	public enum ST_MailMergeSourceType
	{
		// Token: 0x04000BE7 RID: 3047
		database,
		// Token: 0x04000BE8 RID: 3048
		addressBook,
		// Token: 0x04000BE9 RID: 3049
		document1,
		// Token: 0x04000BEA RID: 3050
		document2,
		// Token: 0x04000BEB RID: 3051
		text,
		// Token: 0x04000BEC RID: 3052
		email,
		// Token: 0x04000BED RID: 3053
		native,
		// Token: 0x04000BEE RID: 3054
		legacy,
		// Token: 0x04000BEF RID: 3055
		master
	}
}
