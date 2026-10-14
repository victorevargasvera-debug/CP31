using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Vml.Office
{
	// Token: 0x0200021F RID: 543
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:office:office")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:office:office", IsNullable = false)]
	[global::System.Serializable]
	public enum ST_RType
	{
		// Token: 0x04001175 RID: 4469
		NONE,
		// Token: 0x04001176 RID: 4470
		arc,
		// Token: 0x04001177 RID: 4471
		callout,
		// Token: 0x04001178 RID: 4472
		connector,
		// Token: 0x04001179 RID: 4473
		align
	}
}
