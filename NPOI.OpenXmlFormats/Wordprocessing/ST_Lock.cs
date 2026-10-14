using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000E9 RID: 233
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Serializable]
	public enum ST_Lock
	{
		// Token: 0x040005AB RID: 1451
		sdtLocked,
		// Token: 0x040005AC RID: 1452
		contentLocked,
		// Token: 0x040005AD RID: 1453
		unlocked,
		// Token: 0x040005AE RID: 1454
		sdtContentLocked
	}
}
