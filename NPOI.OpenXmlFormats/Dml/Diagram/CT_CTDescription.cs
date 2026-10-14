using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x02000383 RID: 899
	[global::System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.17379")]
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
	[global::System.Serializable]
	public class CT_CTDescription
	{
		// Token: 0x060023F1 RID: 9201 RVA: 0x0005D057 File Offset: 0x0005B257
		public CT_CTDescription()
		{
			this.langField = "";
		}

		// Token: 0x17000D80 RID: 3456
		// (get) Token: 0x060023F2 RID: 9202 RVA: 0x0005D06A File Offset: 0x0005B26A
		// (set) Token: 0x060023F3 RID: 9203 RVA: 0x0005D072 File Offset: 0x0005B272
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

		// Token: 0x17000D81 RID: 3457
		// (get) Token: 0x060023F4 RID: 9204 RVA: 0x0005D07B File Offset: 0x0005B27B
		// (set) Token: 0x060023F5 RID: 9205 RVA: 0x0005D083 File Offset: 0x0005B283
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

		// Token: 0x04001AA3 RID: 6819
		private string langField;

		// Token: 0x04001AA4 RID: 6820
		private string valField;
	}
}
