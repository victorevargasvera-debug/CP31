using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000458 RID: 1112
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Serializable]
	public enum ST_Shape
	{
		// Token: 0x04001F2E RID: 7982
		cone,
		// Token: 0x04001F2F RID: 7983
		coneToMax,
		// Token: 0x04001F30 RID: 7984
		box,
		// Token: 0x04001F31 RID: 7985
		cylinder,
		// Token: 0x04001F32 RID: 7986
		pyramid,
		// Token: 0x04001F33 RID: 7987
		pyramidToMax
	}
}
