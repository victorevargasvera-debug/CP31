using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x020003A1 RID: 929
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Serializable]
	public enum ST_AxisType
	{
		// Token: 0x04001BAA RID: 7082
		self,
		// Token: 0x04001BAB RID: 7083
		ch,
		// Token: 0x04001BAC RID: 7084
		des,
		// Token: 0x04001BAD RID: 7085
		desOrSelf,
		// Token: 0x04001BAE RID: 7086
		par,
		// Token: 0x04001BAF RID: 7087
		ancst,
		// Token: 0x04001BB0 RID: 7088
		ancstOrSelf,
		// Token: 0x04001BB1 RID: 7089
		followSib,
		// Token: 0x04001BB2 RID: 7090
		precedSib,
		// Token: 0x04001BB3 RID: 7091
		follow,
		// Token: 0x04001BB4 RID: 7092
		preced,
		// Token: 0x04001BB5 RID: 7093
		root,
		// Token: 0x04001BB6 RID: 7094
		none
	}
}
