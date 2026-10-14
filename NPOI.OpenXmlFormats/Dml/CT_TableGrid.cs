using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x0200024F RID: 591
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TableGrid
	{
		// Token: 0x06001809 RID: 6153 RVA: 0x00043765 File Offset: 0x00041965
		public CT_TableGrid()
		{
			this.gridColField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_TableCol>();
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x0600180A RID: 6154 RVA: 0x00043778 File Offset: 0x00041978
		// (set) Token: 0x0600180B RID: 6155 RVA: 0x00043780 File Offset: 0x00041980
		[global::System.Xml.Serialization.XmlElement("gridCol", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_TableCol> gridCol
		{
			get
			{
				return this.gridColField;
			}
			set
			{
				this.gridColField = value;
			}
		}

		// Token: 0x04001286 RID: 4742
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.CT_TableCol> gridColField;
	}
}
