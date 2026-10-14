using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x020003C8 RID: 968
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
	[global::System.Serializable]
	public class CT_SDCategories
	{
		// Token: 0x06002609 RID: 9737 RVA: 0x0005EA4A File Offset: 0x0005CC4A
		public CT_SDCategories()
		{
			this.catField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_SDCategory>();
		}

		// Token: 0x17000E72 RID: 3698
		// (get) Token: 0x0600260A RID: 9738 RVA: 0x0005EA5D File Offset: 0x0005CC5D
		// (set) Token: 0x0600260B RID: 9739 RVA: 0x0005EA65 File Offset: 0x0005CC65
		[global::System.Xml.Serialization.XmlElement("cat", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_SDCategory> cat
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

		// Token: 0x04001C6E RID: 7278
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_SDCategory> catField;
	}
}
