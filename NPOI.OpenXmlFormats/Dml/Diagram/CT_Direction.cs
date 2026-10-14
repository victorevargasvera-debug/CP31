using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x020003B5 RID: 949
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Direction
	{
		// Token: 0x060025A3 RID: 9635 RVA: 0x0005E58B File Offset: 0x0005C78B
		public CT_Direction()
		{
			this.valField = global::NPOI.OpenXmlFormats.Dml.Diagram.ST_Direction.norm;
		}

		// Token: 0x17000E46 RID: 3654
		// (get) Token: 0x060025A4 RID: 9636 RVA: 0x0005E59A File Offset: 0x0005C79A
		// (set) Token: 0x060025A5 RID: 9637 RVA: 0x0005E5A2 File Offset: 0x0005C7A2
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Dml.Diagram.ST_Direction.norm)]
		public global::NPOI.OpenXmlFormats.Dml.Diagram.ST_Direction val
		{
			get
			{
				return this.valField;
			}
			set
			{
				this.valField = value;
			}
		}

		// Token: 0x04001C2E RID: 7214
		private global::NPOI.OpenXmlFormats.Dml.Diagram.ST_Direction valField;
	}
}
