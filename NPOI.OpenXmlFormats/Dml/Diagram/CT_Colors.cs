using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x0200037E RID: 894
	[global::System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.17379")]
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Colors
	{
		// Token: 0x060023D4 RID: 9172 RVA: 0x0005CF04 File Offset: 0x0005B104
		public CT_Colors()
		{
			this.itemsField = new global::System.Collections.Generic.List<object>();
			this.methField = global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ClrAppMethod.span;
			this.hueDirField = global::NPOI.OpenXmlFormats.Dml.Diagram.ST_HueDir.cw;
		}

		// Token: 0x17000D73 RID: 3443
		// (get) Token: 0x060023D5 RID: 9173 RVA: 0x0005CF25 File Offset: 0x0005B125
		// (set) Token: 0x060023D6 RID: 9174 RVA: 0x0005CF2D File Offset: 0x0005B12D
		[global::System.Xml.Serialization.XmlElement("hslClr", typeof(global::NPOI.OpenXmlFormats.Dml.CT_HslColor), Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("prstClr", typeof(global::NPOI.OpenXmlFormats.Dml.CT_PresetColor), Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("schemeClr", typeof(global::NPOI.OpenXmlFormats.Dml.CT_SchemeColor), Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("scrgbClr", typeof(global::NPOI.OpenXmlFormats.Dml.CT_ScRgbColor), Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("srgbClr", typeof(global::NPOI.OpenXmlFormats.Dml.CT_SRgbColor), Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("sysClr", typeof(global::NPOI.OpenXmlFormats.Dml.CT_SystemColor), Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", Order = 0)]
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

		// Token: 0x17000D74 RID: 3444
		// (get) Token: 0x060023D7 RID: 9175 RVA: 0x0005CF36 File Offset: 0x0005B136
		// (set) Token: 0x060023D8 RID: 9176 RVA: 0x0005CF3E File Offset: 0x0005B13E
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ClrAppMethod.span)]
		public global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ClrAppMethod meth
		{
			get
			{
				return this.methField;
			}
			set
			{
				this.methField = value;
			}
		}

		// Token: 0x17000D75 RID: 3445
		// (get) Token: 0x060023D9 RID: 9177 RVA: 0x0005CF47 File Offset: 0x0005B147
		// (set) Token: 0x060023DA RID: 9178 RVA: 0x0005CF4F File Offset: 0x0005B14F
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Dml.Diagram.ST_HueDir.cw)]
		public global::NPOI.OpenXmlFormats.Dml.Diagram.ST_HueDir hueDir
		{
			get
			{
				return this.hueDirField;
			}
			set
			{
				this.hueDirField = value;
			}
		}

		// Token: 0x04001A8F RID: 6799
		private global::System.Collections.Generic.List<object> itemsField;

		// Token: 0x04001A90 RID: 6800
		private global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ClrAppMethod methField;

		// Token: 0x04001A91 RID: 6801
		private global::NPOI.OpenXmlFormats.Dml.Diagram.ST_HueDir hueDirField;
	}
}
