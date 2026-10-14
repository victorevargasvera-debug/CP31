using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x020003C5 RID: 965
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
	[global::System.Serializable]
	public class CT_SDDescription
	{
		// Token: 0x060025F2 RID: 9714 RVA: 0x0005E93F File Offset: 0x0005CB3F
		public CT_SDDescription()
		{
			this.langField = "";
		}

		// Token: 0x17000E68 RID: 3688
		// (get) Token: 0x060025F3 RID: 9715 RVA: 0x0005E952 File Offset: 0x0005CB52
		// (set) Token: 0x060025F4 RID: 9716 RVA: 0x0005E95A File Offset: 0x0005CB5A
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

		// Token: 0x17000E69 RID: 3689
		// (get) Token: 0x060025F5 RID: 9717 RVA: 0x0005E963 File Offset: 0x0005CB63
		// (set) Token: 0x060025F6 RID: 9718 RVA: 0x0005E96B File Offset: 0x0005CB6B
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

		// Token: 0x04001C64 RID: 7268
		private string langField;

		// Token: 0x04001C65 RID: 7269
		private string valField;
	}
}
