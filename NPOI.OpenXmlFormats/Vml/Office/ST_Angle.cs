using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Vml.Office
{
	// Token: 0x02000212 RID: 530
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:office:office")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:office:office", IsNullable = false)]
	[global::System.Serializable]
	public enum ST_Angle
	{
		// Token: 0x04001127 RID: 4391
		any,
		// Token: 0x04001128 RID: 4392
		[global::System.Xml.Serialization.XmlEnum("30")]
		Item30,
		// Token: 0x04001129 RID: 4393
		[global::System.Xml.Serialization.XmlEnum("45")]
		Item45,
		// Token: 0x0400112A RID: 4394
		[global::System.Xml.Serialization.XmlEnum("60")]
		Item60,
		// Token: 0x0400112B RID: 4395
		[global::System.Xml.Serialization.XmlEnum("90")]
		Item90,
		// Token: 0x0400112C RID: 4396
		auto
	}
}
