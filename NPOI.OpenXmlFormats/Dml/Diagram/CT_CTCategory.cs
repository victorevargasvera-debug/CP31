using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x02000382 RID: 898
	[global::System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.0.30319.17379")]
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
	[global::System.Serializable]
	public class CT_CTCategory
	{
		// Token: 0x17000D7E RID: 3454
		// (get) Token: 0x060023EC RID: 9196 RVA: 0x0005D035 File Offset: 0x0005B235
		// (set) Token: 0x060023ED RID: 9197 RVA: 0x0005D03D File Offset: 0x0005B23D
		[global::System.Xml.Serialization.XmlAttribute(DataType = "anyURI")]
		public string type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}

		// Token: 0x17000D7F RID: 3455
		// (get) Token: 0x060023EE RID: 9198 RVA: 0x0005D046 File Offset: 0x0005B246
		// (set) Token: 0x060023EF RID: 9199 RVA: 0x0005D04E File Offset: 0x0005B24E
		[global::System.Xml.Serialization.XmlAttribute]
		public uint pri
		{
			get
			{
				return this.priField;
			}
			set
			{
				this.priField = value;
			}
		}

		// Token: 0x04001AA1 RID: 6817
		private string typeField;

		// Token: 0x04001AA2 RID: 6818
		private uint priField;
	}
}
