using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x0200037D RID: 893
	[global::System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.17379")]
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
	[global::System.Serializable]
	public class CT_CTName
	{
		// Token: 0x060023CF RID: 9167 RVA: 0x0005CECF File Offset: 0x0005B0CF
		public CT_CTName()
		{
			this.langField = "";
		}

		// Token: 0x17000D71 RID: 3441
		// (get) Token: 0x060023D0 RID: 9168 RVA: 0x0005CEE2 File Offset: 0x0005B0E2
		// (set) Token: 0x060023D1 RID: 9169 RVA: 0x0005CEEA File Offset: 0x0005B0EA
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue("")]
		public string lang
		{
			get
			{
				return this.langField;
			}
			set
			{
				this.langField = value;
			}
		}

		// Token: 0x17000D72 RID: 3442
		// (get) Token: 0x060023D2 RID: 9170 RVA: 0x0005CEF3 File Offset: 0x0005B0F3
		// (set) Token: 0x060023D3 RID: 9171 RVA: 0x0005CEFB File Offset: 0x0005B0FB
		[global::System.Xml.Serialization.XmlAttribute]
		public string val
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

		// Token: 0x04001A8D RID: 6797
		private string langField;

		// Token: 0x04001A8E RID: 6798
		private string valField;
	}
}
