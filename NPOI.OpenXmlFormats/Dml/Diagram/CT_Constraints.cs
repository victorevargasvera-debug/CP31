using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x02000399 RID: 921
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Constraints
	{
		// Token: 0x0600248D RID: 9357 RVA: 0x0005D7F5 File Offset: 0x0005B9F5
		public CT_Constraints()
		{
			this.constrField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Constraint>();
		}

		// Token: 0x17000DC5 RID: 3525
		// (get) Token: 0x0600248E RID: 9358 RVA: 0x0005D808 File Offset: 0x0005BA08
		// (set) Token: 0x0600248F RID: 9359 RVA: 0x0005D810 File Offset: 0x0005BA10
		[global::System.Xml.Serialization.XmlElement("constr", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Constraint> constr
		{
			get
			{
				return this.constrField;
			}
			set
			{
				this.constrField = value;
			}
		}

		// Token: 0x04001B37 RID: 6967
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Constraint> constrField;
	}
}
