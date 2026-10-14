using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x020003AB RID: 939
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Categories
	{
		// Token: 0x060024FF RID: 9471 RVA: 0x0005DEE8 File Offset: 0x0005C0E8
		public CT_Categories()
		{
			this.catField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Category>();
		}

		// Token: 0x17000DF9 RID: 3577
		// (get) Token: 0x06002500 RID: 9472 RVA: 0x0005DEFB File Offset: 0x0005C0FB
		// (set) Token: 0x06002501 RID: 9473 RVA: 0x0005DF03 File Offset: 0x0005C103
		[global::System.Xml.Serialization.XmlElement("cat", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Category> cat
		{
			get
			{
				return this.catField;
			}
			set
			{
				this.catField = value;
			}
		}

		// Token: 0x04001BE1 RID: 7137
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Category> catField;
	}
}
