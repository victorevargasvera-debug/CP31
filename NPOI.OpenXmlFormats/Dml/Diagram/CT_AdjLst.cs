using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x020003A5 RID: 933
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
	[global::System.Serializable]
	public class CT_AdjLst
	{
		// Token: 0x060024E4 RID: 9444 RVA: 0x0005DD8C File Offset: 0x0005BF8C
		public CT_AdjLst()
		{
			this.adjField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Adj>();
		}

		// Token: 0x17000DED RID: 3565
		// (get) Token: 0x060024E5 RID: 9445 RVA: 0x0005DD9F File Offset: 0x0005BF9F
		// (set) Token: 0x060024E6 RID: 9446 RVA: 0x0005DDA7 File Offset: 0x0005BFA7
		[global::System.Xml.Serialization.XmlElement("adj", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Adj> adj
		{
			get
			{
				return this.adjField;
			}
			set
			{
				this.adjField = value;
			}
		}

		// Token: 0x04001BC2 RID: 7106
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Adj> adjField;
	}
}
