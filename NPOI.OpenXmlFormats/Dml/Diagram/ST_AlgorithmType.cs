using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x02000396 RID: 918
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Serializable]
	public enum ST_AlgorithmType
	{
		// Token: 0x04001B1E RID: 6942
		composite,
		// Token: 0x04001B1F RID: 6943
		conn,
		// Token: 0x04001B20 RID: 6944
		cycle,
		// Token: 0x04001B21 RID: 6945
		hierChild,
		// Token: 0x04001B22 RID: 6946
		hierRoot,
		// Token: 0x04001B23 RID: 6947
		pyra,
		// Token: 0x04001B24 RID: 6948
		lin,
		// Token: 0x04001B25 RID: 6949
		sp,
		// Token: 0x04001B26 RID: 6950
		tx,
		// Token: 0x04001B27 RID: 6951
		snake
	}
}
