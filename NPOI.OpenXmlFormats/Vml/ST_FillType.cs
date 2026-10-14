using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Vml
{
	// Token: 0x020001D0 RID: 464
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:vml")]
	[global::System.Serializable]
	public enum ST_FillType
	{
		// Token: 0x04000DDC RID: 3548
		solid,
		// Token: 0x04000DDD RID: 3549
		gradient,
		// Token: 0x04000DDE RID: 3550
		gradientRadial,
		// Token: 0x04000DDF RID: 3551
		tile,
		// Token: 0x04000DE0 RID: 3552
		pattern,
		// Token: 0x04000DE1 RID: 3553
		frame
	}
}
