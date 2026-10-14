using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x0200043F RID: 1087
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Serializable]
	public enum ST_TrendlineType
	{
		// Token: 0x04001EDE RID: 7902
		exp,
		// Token: 0x04001EDF RID: 7903
		linear,
		// Token: 0x04001EE0 RID: 7904
		log,
		// Token: 0x04001EE1 RID: 7905
		movingAvg,
		// Token: 0x04001EE2 RID: 7906
		poly,
		// Token: 0x04001EE3 RID: 7907
		power
	}
}
