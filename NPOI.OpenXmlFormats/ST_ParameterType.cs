using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats
{
	// Token: 0x0200003C RID: 60
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = false)]
	[global::System.Serializable]
	public enum ST_ParameterType
	{
		// Token: 0x04000197 RID: 407
		prompt,
		// Token: 0x04000198 RID: 408
		value,
		// Token: 0x04000199 RID: 409
		cell
	}
}
