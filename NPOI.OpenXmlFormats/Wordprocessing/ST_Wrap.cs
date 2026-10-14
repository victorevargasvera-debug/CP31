using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000A5 RID: 165
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Serializable]
	public enum ST_Wrap
	{
		// Token: 0x040003FE RID: 1022
		auto,
		// Token: 0x040003FF RID: 1023
		notBeside,
		// Token: 0x04000400 RID: 1024
		around,
		// Token: 0x04000401 RID: 1025
		tight,
		// Token: 0x04000402 RID: 1026
		through,
		// Token: 0x04000403 RID: 1027
		none
	}
}
