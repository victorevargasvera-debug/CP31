using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002DD RID: 733
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Path2DCubicBezierTo
	{
		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x06001C9C RID: 7324 RVA: 0x0004E35B File Offset: 0x0004C55B
		// (set) Token: 0x06001C9D RID: 7325 RVA: 0x0004E363 File Offset: 0x0004C563
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

		// Token: 0x04001733 RID: 5939
		private global::NPOI.OpenXmlFormats.Dml.CT_AdjPoint2D[] ptField;
	}
}
