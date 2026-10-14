using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x0200038D RID: 909
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
	[global::System.Serializable]
	public class CT_CxnList
	{
		// Token: 0x0600243D RID: 9277 RVA: 0x0005D3E2 File Offset: 0x0005B5E2
		public CT_CxnList()
		{
			this.cxnField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Cxn>();
		}

		// Token: 0x17000DA2 RID: 3490
		// (get) Token: 0x0600243E RID: 9278 RVA: 0x0005D3F5 File Offset: 0x0005B5F5
		// (set) Token: 0x0600243F RID: 9279 RVA: 0x0005D3FD File Offset: 0x0005B5FD
		[global::System.Xml.Serialization.XmlElement("cxn", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Cxn> cxn
		{
			get
			{
				return this.cxnField;
			}
			set
			{
				this.cxnField = value;
			}
		}

		// Token: 0x04001AD1 RID: 6865
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Cxn> cxnField;
	}
}
