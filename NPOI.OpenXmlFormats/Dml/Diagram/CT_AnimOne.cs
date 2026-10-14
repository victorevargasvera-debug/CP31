using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x020003B9 RID: 953
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
	[global::System.Serializable]
	public class CT_AnimOne
	{
		// Token: 0x060025A9 RID: 9641 RVA: 0x0005E5CB File Offset: 0x0005C7CB
		public CT_AnimOne()
		{
			this.valField = global::NPOI.OpenXmlFormats.Dml.Diagram.ST_AnimOneStr.one;
		}

		// Token: 0x17000E48 RID: 3656
		// (get) Token: 0x060025AA RID: 9642 RVA: 0x0005E5DA File Offset: 0x0005C7DA
		// (set) Token: 0x060025AB RID: 9643 RVA: 0x0005E5E2 File Offset: 0x0005C7E2
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Dml.Diagram.ST_AnimOneStr.one)]
		public global::NPOI.OpenXmlFormats.Dml.Diagram.ST_AnimOneStr val
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

		// Token: 0x04001C39 RID: 7225
		private global::NPOI.OpenXmlFormats.Dml.Diagram.ST_AnimOneStr valField;
	}
}
