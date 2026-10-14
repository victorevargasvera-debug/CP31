using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x020003BD RID: 957
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ResizeHandles
	{
		// Token: 0x060025AF RID: 9647 RVA: 0x0005E60B File Offset: 0x0005C80B
		public CT_ResizeHandles()
		{
			this.valField = global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ResizeHandlesStr.rel;
		}

		// Token: 0x17000E4A RID: 3658
		// (get) Token: 0x060025B0 RID: 9648 RVA: 0x0005E61A File Offset: 0x0005C81A
		// (set) Token: 0x060025B1 RID: 9649 RVA: 0x0005E622 File Offset: 0x0005C822
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ResizeHandlesStr.rel)]
		public global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ResizeHandlesStr val
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

		// Token: 0x04001C43 RID: 7235
		private global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ResizeHandlesStr valField;
	}
}
