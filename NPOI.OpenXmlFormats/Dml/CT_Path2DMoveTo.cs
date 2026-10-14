using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002E8 RID: 744
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Path2DMoveTo
	{
		// Token: 0x06001CED RID: 7405 RVA: 0x0004EAAB File Offset: 0x0004CCAB
		public CT_Path2DMoveTo()
		{
			this.ptField = new global::NPOI.OpenXmlFormats.Dml.CT_AdjPoint2D();
		}

		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x06001CEE RID: 7406 RVA: 0x0004EABE File Offset: 0x0004CCBE
		// (set) Token: 0x06001CEF RID: 7407 RVA: 0x0004EAC6 File Offset: 0x0004CCC6
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_AdjPoint2D pt
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

		// Token: 0x04001750 RID: 5968
		private global::NPOI.OpenXmlFormats.Dml.CT_AdjPoint2D ptField;
	}
}
