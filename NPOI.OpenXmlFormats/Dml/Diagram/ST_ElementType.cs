using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x0200039D RID: 925
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Serializable]
	public enum ST_ElementType
	{
		// Token: 0x04001B8A RID: 7050
		all,
		// Token: 0x04001B8B RID: 7051
		doc,
		// Token: 0x04001B8C RID: 7052
		node,
		// Token: 0x04001B8D RID: 7053
		norm,
		// Token: 0x04001B8E RID: 7054
		nonNorm,
		// Token: 0x04001B8F RID: 7055
		asst,
		// Token: 0x04001B90 RID: 7056
		nonAsst,
		// Token: 0x04001B91 RID: 7057
		parTrans,
		// Token: 0x04001B92 RID: 7058
		pres,
		// Token: 0x04001B93 RID: 7059
		sibTrans
	}
}
