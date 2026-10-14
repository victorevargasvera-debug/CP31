using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Vml
{
	// Token: 0x020001D3 RID: 467
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:vml")]
	[global::System.Serializable]
	public enum ST_FillMethod
	{
		// Token: 0x04000DEC RID: 3564
		none,
		// Token: 0x04000DED RID: 3565
		linear,
		// Token: 0x04000DEE RID: 3566
		sigma,
		// Token: 0x04000DEF RID: 3567
		any,
		// Token: 0x04000DF0 RID: 3568
		[global::System.Xml.Serialization.XmlEnum("linear sigma")]
		linearsigma
	}
}
