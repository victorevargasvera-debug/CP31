using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000449 RID: 1097
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Serializable]
	public enum ST_ErrValType
	{
		// Token: 0x04001F00 RID: 7936
		cust,
		// Token: 0x04001F01 RID: 7937
		fixedVal,
		// Token: 0x04001F02 RID: 7938
		percentage,
		// Token: 0x04001F03 RID: 7939
		stdDev,
		// Token: 0x04001F04 RID: 7940
		stdErr
	}
}
