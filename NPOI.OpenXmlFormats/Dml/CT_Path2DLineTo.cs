using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002E9 RID: 745
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Path2DLineTo
	{
		// Token: 0x06001CF0 RID: 7408 RVA: 0x0004EACF File Offset: 0x0004CCCF
		public CT_Path2DLineTo()
		{
			this.ptField = new global::NPOI.OpenXmlFormats.Dml.CT_AdjPoint2D();
		}

		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x06001CF1 RID: 7409 RVA: 0x0004EAE2 File Offset: 0x0004CCE2
		// (set) Token: 0x06001CF2 RID: 7410 RVA: 0x0004EAEA File Offset: 0x0004CCEA
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

		// Token: 0x04001751 RID: 5969
		private global::NPOI.OpenXmlFormats.Dml.CT_AdjPoint2D ptField;
	}
}
