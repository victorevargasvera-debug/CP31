using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Vml.Office
{
	// Token: 0x02000234 RID: 564
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:office:office")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:office:office", IsNullable = false)]
	[global::System.Serializable]
	public enum ST_ConnectType
	{
		// Token: 0x04001212 RID: 4626
		none,
		// Token: 0x04001213 RID: 4627
		rect,
		// Token: 0x04001214 RID: 4628
		segments,
		// Token: 0x04001215 RID: 4629
		custom
	}
}
