using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x020003AE RID: 942
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot("layoutDefHdrLst", Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = false)]
	[global::System.Serializable]
	public class CT_DiagramDefinitionHeaderLst
	{
		// Token: 0x0600252A RID: 9514 RVA: 0x0005E121 File Offset: 0x0005C321
		public CT_DiagramDefinitionHeaderLst()
		{
			this.layoutDefHdrField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_DiagramDefinitionHeader>();
		}

		// Token: 0x17000E0D RID: 3597
		// (get) Token: 0x0600252B RID: 9515 RVA: 0x0005E134 File Offset: 0x0005C334
		// (set) Token: 0x0600252C RID: 9516 RVA: 0x0005E13C File Offset: 0x0005C33C
		[global::System.Xml.Serialization.XmlElement("layoutDefHdr", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_DiagramDefinitionHeader> layoutDefHdr
		{
			get
			{
				return this.layoutDefHdrField;
			}
			set
			{
				this.layoutDefHdrField = value;
			}
		}

		// Token: 0x04001BF5 RID: 7157
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_DiagramDefinitionHeader> layoutDefHdrField;
	}
}
