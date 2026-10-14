using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x0200038A RID: 906
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Serializable]
	public enum ST_CxnType
	{
		// Token: 0x04001AC5 RID: 6853
		parOf,
		// Token: 0x04001AC6 RID: 6854
		presOf,
		// Token: 0x04001AC7 RID: 6855
		presParOf,
		// Token: 0x04001AC8 RID: 6856
		unknownRelationship
	}
}
