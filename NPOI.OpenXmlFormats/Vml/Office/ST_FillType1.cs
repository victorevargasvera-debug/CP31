using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Vml.Office
{
	// Token: 0x0200022D RID: 557
	[global::System.Xml.Serialization.XmlType(TypeName = "ST_FillType", Namespace = "urn:schemas-microsoft-com:office:office")]
	[global::System.Xml.Serialization.XmlRoot("ST_FillType", Namespace = "urn:schemas-microsoft-com:office:office", IsNullable = false)]
	[global::System.Serializable]
	public enum ST_FillType1
	{
		// Token: 0x040011E3 RID: 4579
		gradientCenter,
		// Token: 0x040011E4 RID: 4580
		solid,
		// Token: 0x040011E5 RID: 4581
		pattern,
		// Token: 0x040011E6 RID: 4582
		tile,
		// Token: 0x040011E7 RID: 4583
		frame,
		// Token: 0x040011E8 RID: 4584
		gradientUnscaled,
		// Token: 0x040011E9 RID: 4585
		gradientRadial,
		// Token: 0x040011EA RID: 4586
		gradient,
		// Token: 0x040011EB RID: 4587
		background
	}
}
