using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x0200038C RID: 908
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
	[global::System.Serializable]
	public class CT_PtList
	{
		// Token: 0x0600243A RID: 9274 RVA: 0x0005D3BE File Offset: 0x0005B5BE
		public CT_PtList()
		{
			this.ptField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Pt>();
		}

		// Token: 0x17000DA1 RID: 3489
		// (get) Token: 0x0600243B RID: 9275 RVA: 0x0005D3D1 File Offset: 0x0005B5D1
		// (set) Token: 0x0600243C RID: 9276 RVA: 0x0005D3D9 File Offset: 0x0005B5D9
		[global::System.Xml.Serialization.XmlElement("pt", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Pt> pt
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

		// Token: 0x04001AD0 RID: 6864
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Pt> ptField;
	}
}
