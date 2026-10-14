using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000178 RID: 376
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Serializable]
	public enum ST_View
	{
		// Token: 0x04000B96 RID: 2966
		none,
		// Token: 0x04000B97 RID: 2967
		print,
		// Token: 0x04000B98 RID: 2968
		outline,
		// Token: 0x04000B99 RID: 2969
		masterPages,
		// Token: 0x04000B9A RID: 2970
		normal,
		// Token: 0x04000B9B RID: 2971
		web
	}
}
