using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x020003C7 RID: 967
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot("styleDefHdrLst", Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = false)]
	[global::System.Serializable]
	public class CT_StyleDefinitionHeaderLst
	{
		// Token: 0x06002606 RID: 9734 RVA: 0x0005EA26 File Offset: 0x0005CC26
		public CT_StyleDefinitionHeaderLst()
		{
			this.styleDefHdrField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_StyleDefinitionHeader>();
		}

		// Token: 0x17000E71 RID: 3697
		// (get) Token: 0x06002607 RID: 9735 RVA: 0x0005EA39 File Offset: 0x0005CC39
		// (set) Token: 0x06002608 RID: 9736 RVA: 0x0005EA41 File Offset: 0x0005CC41
		[global::System.Xml.Serialization.XmlElement("styleDefHdr", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_StyleDefinitionHeader> styleDefHdr
		{
			get
			{
				return this.styleDefHdrField;
			}
			set
			{
				this.styleDefHdrField = value;
			}
		}

		// Token: 0x04001C6D RID: 7277
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_StyleDefinitionHeader> styleDefHdrField;
	}
}
