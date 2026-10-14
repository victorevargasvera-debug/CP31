using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x020003A7 RID: 935
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Serializable]
	public enum ST_FunctionType
	{
		// Token: 0x04001BCD RID: 7117
		cnt,
		// Token: 0x04001BCE RID: 7118
		pos,
		// Token: 0x04001BCF RID: 7119
		revPos,
		// Token: 0x04001BD0 RID: 7120
		posEven,
		// Token: 0x04001BD1 RID: 7121
		posOdd,
		// Token: 0x04001BD2 RID: 7122
		var,
		// Token: 0x04001BD3 RID: 7123
		depth,
		// Token: 0x04001BD4 RID: 7124
		maxDepth
	}
}
