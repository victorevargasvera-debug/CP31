using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x020003A9 RID: 937
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Otherwise
	{
		// Token: 0x060024FA RID: 9466 RVA: 0x0005DEA8 File Offset: 0x0005C0A8
		public CT_Otherwise()
		{
			this.itemsField = new global::System.Collections.Generic.List<object>();
			this.nameField = "";
		}

		// Token: 0x17000DF7 RID: 3575
		// (get) Token: 0x060024FB RID: 9467 RVA: 0x0005DEC6 File Offset: 0x0005C0C6
		// (set) Token: 0x060024FC RID: 9468 RVA: 0x0005DECE File Offset: 0x0005C0CE
		[global::System.Xml.Serialization.XmlElement("alg", typeof(global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Algorithm), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("choose", typeof(global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Choose), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("constrLst", typeof(global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Constraints), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("extLst", typeof(global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("forEach", typeof(global::NPOI.OpenXmlFormats.Dml.Diagram.CT_ForEach), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("layoutNode", typeof(global::NPOI.OpenXmlFormats.Dml.Diagram.CT_LayoutNode), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("presOf", typeof(global::NPOI.OpenXmlFormats.Dml.Diagram.CT_PresentationOf), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("ruleLst", typeof(global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Rules), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("shape", typeof(global::NPOI.OpenXmlFormats.Dml.Diagram.CT_Shape), Order = 0)]
		public global::System.Collections.Generic.List<object> Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
			}
		}

		// Token: 0x17000DF8 RID: 3576
		// (get) Token: 0x060024FD RID: 9469 RVA: 0x0005DED7 File Offset: 0x0005C0D7
		// (set) Token: 0x060024FE RID: 9470 RVA: 0x0005DEDF File Offset: 0x0005C0DF
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue("")]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		// Token: 0x04001BDC RID: 7132
		private global::System.Collections.Generic.List<object> itemsField;

		// Token: 0x04001BDD RID: 7133
		private string nameField;
	}
}
