using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000297 RID: 663
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Serializable]
	public enum ST_CompoundLine
	{
		// Token: 0x04001434 RID: 5172
		NONE,
		// Token: 0x04001435 RID: 5173
		sng,
		// Token: 0x04001436 RID: 5174
		dbl,
		// Token: 0x04001437 RID: 5175
		thickThin,
		// Token: 0x04001438 RID: 5176
		thinThick,
		// Token: 0x04001439 RID: 5177
		tri
	}
}
