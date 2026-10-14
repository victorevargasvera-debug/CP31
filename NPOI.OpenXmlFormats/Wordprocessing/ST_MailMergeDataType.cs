using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000184 RID: 388
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Serializable]
	public enum ST_MailMergeDataType
	{
		// Token: 0x04000BD1 RID: 3025
		textFile,
		// Token: 0x04000BD2 RID: 3026
		database,
		// Token: 0x04000BD3 RID: 3027
		spreadsheet,
		// Token: 0x04000BD4 RID: 3028
		query,
		// Token: 0x04000BD5 RID: 3029
		odbc,
		// Token: 0x04000BD6 RID: 3030
		native
	}
}
