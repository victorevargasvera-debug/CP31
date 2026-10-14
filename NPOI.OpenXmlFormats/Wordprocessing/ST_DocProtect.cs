using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200018F RID: 399
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Serializable]
	public enum ST_DocProtect
	{
		// Token: 0x04000C1A RID: 3098
		none,
		// Token: 0x04000C1B RID: 3099
		readOnly,
		// Token: 0x04000C1C RID: 3100
		comments,
		// Token: 0x04000C1D RID: 3101
		trackedChanges,
		// Token: 0x04000C1E RID: 3102
		forms
	}
}
