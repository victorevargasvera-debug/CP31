using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x0200038B RID: 907
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Serializable]
	public enum ST_PtType
	{
		// Token: 0x04001ACA RID: 6858
		node,
		// Token: 0x04001ACB RID: 6859
		asst,
		// Token: 0x04001ACC RID: 6860
		doc,
		// Token: 0x04001ACD RID: 6861
		pres,
		// Token: 0x04001ACE RID: 6862
		parTrans,
		// Token: 0x04001ACF RID: 6863
		sibTrans
	}
}
