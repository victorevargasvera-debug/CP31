using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Vml.Wordprocessing
{
	// Token: 0x020001FD RID: 509
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:office:word")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:office:word", IsNullable = false)]
	[global::System.Serializable]
	public enum ST_WrapType
	{
		// Token: 0x04000FED RID: 4077
		topAndBottom,
		// Token: 0x04000FEE RID: 4078
		square,
		// Token: 0x04000FEF RID: 4079
		none,
		// Token: 0x04000FF0 RID: 4080
		tight,
		// Token: 0x04000FF1 RID: 4081
		through
	}
}
