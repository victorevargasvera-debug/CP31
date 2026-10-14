using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Vml
{
	// Token: 0x020001F6 RID: 502
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:vml")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:vml", IsNullable = false)]
	[global::System.Serializable]
	public enum ST_EditAs
	{
		// Token: 0x04000FAD RID: 4013
		canvas,
		// Token: 0x04000FAE RID: 4014
		orgchart,
		// Token: 0x04000FAF RID: 4015
		radial,
		// Token: 0x04000FB0 RID: 4016
		cycle,
		// Token: 0x04000FB1 RID: 4017
		stacked,
		// Token: 0x04000FB2 RID: 4018
		venn,
		// Token: 0x04000FB3 RID: 4019
		bullseye
	}
}
