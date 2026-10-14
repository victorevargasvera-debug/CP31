using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x020003B7 RID: 951
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
	[global::System.Serializable]
	public class CT_HierBranchStyle
	{
		// Token: 0x060025A6 RID: 9638 RVA: 0x0005E5AB File Offset: 0x0005C7AB
		public CT_HierBranchStyle()
		{
			this.valField = global::NPOI.OpenXmlFormats.Dml.Diagram.ST_HierBranchStyle.std;
		}

		// Token: 0x17000E47 RID: 3655
		// (get) Token: 0x060025A7 RID: 9639 RVA: 0x0005E5BA File Offset: 0x0005C7BA
		// (set) Token: 0x060025A8 RID: 9640 RVA: 0x0005E5C2 File Offset: 0x0005C7C2
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Dml.Diagram.ST_HierBranchStyle.std)]
		public global::NPOI.OpenXmlFormats.Dml.Diagram.ST_HierBranchStyle val
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

		// Token: 0x04001C32 RID: 7218
		private global::NPOI.OpenXmlFormats.Dml.Diagram.ST_HierBranchStyle valField;
	}
}
