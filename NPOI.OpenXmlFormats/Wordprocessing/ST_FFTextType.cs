using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000090 RID: 144
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Serializable]
	public enum ST_FFTextType
	{
		// Token: 0x04000390 RID: 912
		regular,
		// Token: 0x04000391 RID: 913
		number,
		// Token: 0x04000392 RID: 914
		date,
		// Token: 0x04000393 RID: 915
		currentTime,
		// Token: 0x04000394 RID: 916
		currentDate,
		// Token: 0x04000395 RID: 917
		calculated
	}
}
