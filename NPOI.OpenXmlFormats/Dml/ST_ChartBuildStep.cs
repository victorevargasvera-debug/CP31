using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002CD RID: 717
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Serializable]
	public enum ST_ChartBuildStep
	{
		// Token: 0x04001628 RID: 5672
		category,
		// Token: 0x04001629 RID: 5673
		ptInCategory,
		// Token: 0x0400162A RID: 5674
		series,
		// Token: 0x0400162B RID: 5675
		ptInSeries,
		// Token: 0x0400162C RID: 5676
		allPts,
		// Token: 0x0400162D RID: 5677
		gridLegend
	}
}
