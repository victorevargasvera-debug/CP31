using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200010B RID: 267
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IncludeInSchema = false)]
	[global::System.Serializable]
	public enum ItemsChoiceType9
	{
		// Token: 0x04000663 RID: 1635
		[global::System.Xml.Serialization.XmlEnum("urn:schemas-microsoft-com:office:office:")]
		office,
		// Token: 0x04000664 RID: 1636
		[global::System.Xml.Serialization.XmlEnum("urn:schemas-microsoft-com:vml:")]
		vml
	}
}
