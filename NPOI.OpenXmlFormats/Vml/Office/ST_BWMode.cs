using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Vml.Office
{
	// Token: 0x0200022E RID: 558
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:office:office")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:office:office", IsNullable = false)]
	[global::System.Serializable]
	public enum ST_BWMode
	{
		// Token: 0x040011ED RID: 4589
		color,
		// Token: 0x040011EE RID: 4590
		auto,
		// Token: 0x040011EF RID: 4591
		grayScale,
		// Token: 0x040011F0 RID: 4592
		lightGrayscale,
		// Token: 0x040011F1 RID: 4593
		inverseGray,
		// Token: 0x040011F2 RID: 4594
		grayOutline,
		// Token: 0x040011F3 RID: 4595
		highContrast,
		// Token: 0x040011F4 RID: 4596
		black,
		// Token: 0x040011F5 RID: 4597
		white,
		// Token: 0x040011F6 RID: 4598
		hide,
		// Token: 0x040011F7 RID: 4599
		undrawn,
		// Token: 0x040011F8 RID: 4600
		blackTextAndLines
	}
}
