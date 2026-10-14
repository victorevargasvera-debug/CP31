using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002DF RID: 735
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Path2DQuadBezierTo
	{
		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x06001CA6 RID: 7334 RVA: 0x0004E43A File Offset: 0x0004C63A
		// (set) Token: 0x06001CA7 RID: 7335 RVA: 0x0004E442 File Offset: 0x0004C642
		[global::System.Xml.Serialization.XmlElement("pt", Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_AdjPoint2D[] pt
		{
			get
			{
				return this.ptField;
			}
			set
			{
				this.ptField = value;
			}
		}

		// Token: 0x04001736 RID: 5942
		private global::NPOI.OpenXmlFormats.Dml.CT_AdjPoint2D[] ptField;
	}
}
