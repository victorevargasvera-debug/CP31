using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002EE RID: 750
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IncludeInSchema = false)]
	[global::System.Serializable]
	public enum ItemsChoiceType
	{
		// Token: 0x04001763 RID: 5987
		arcTo,
		// Token: 0x04001764 RID: 5988
		close,
		// Token: 0x04001765 RID: 5989
		cubicBezTo,
		// Token: 0x04001766 RID: 5990
		lnTo,
		// Token: 0x04001767 RID: 5991
		moveTo,
		// Token: 0x04001768 RID: 5992
		quadBezTo
	}
}
