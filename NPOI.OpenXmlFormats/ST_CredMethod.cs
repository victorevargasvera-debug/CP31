using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats
{
	// Token: 0x0200003D RID: 61
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = false)]
	[global::System.Serializable]
	public enum ST_CredMethod
	{
		// Token: 0x0400019B RID: 411
		integrated,
		// Token: 0x0400019C RID: 412
		none,
		// Token: 0x0400019D RID: 413
		stored,
		// Token: 0x0400019E RID: 414
		prompt
	}
}
