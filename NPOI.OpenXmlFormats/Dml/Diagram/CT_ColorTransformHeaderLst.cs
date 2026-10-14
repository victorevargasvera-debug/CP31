using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x02000385 RID: 901
	[global::System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.17379")]
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot("colorsDefHdrLst", Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = false)]
	[global::System.Serializable]
	public class CT_ColorTransformHeaderLst
	{
		// Token: 0x06002405 RID: 9221 RVA: 0x0005D13E File Offset: 0x0005B33E
		public CT_ColorTransformHeaderLst()
		{
			this.colorsDefHdrField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_ColorTransformHeader>();
		}

		// Token: 0x17000D89 RID: 3465
		// (get) Token: 0x06002406 RID: 9222 RVA: 0x0005D151 File Offset: 0x0005B351
		// (set) Token: 0x06002407 RID: 9223 RVA: 0x0005D159 File Offset: 0x0005B359
		[global::System.Xml.Serialization.XmlElement("colorsDefHdr", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_ColorTransformHeader> colorsDefHdr
		{
			get
			{
				return this.colorsDefHdrField;
			}
			set
			{
				this.colorsDefHdrField = value;
			}
		}

		// Token: 0x04001AAC RID: 6828
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Diagram.CT_ColorTransformHeader> colorsDefHdrField;
	}
}
