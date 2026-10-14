using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Vml.Office
{
	// Token: 0x02000232 RID: 562
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:office:office")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:office:office", IsNullable = false)]
	[global::System.Serializable]
	public enum ST_ConnectorType
	{
		// Token: 0x04001209 RID: 4617
		none,
		// Token: 0x0400120A RID: 4618
		straight,
		// Token: 0x0400120B RID: 4619
		elbow,
		// Token: 0x0400120C RID: 4620
		curved
	}
}
