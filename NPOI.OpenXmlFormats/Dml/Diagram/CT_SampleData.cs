using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x02000391 RID: 913
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
	[global::System.Serializable]
	public class CT_SampleData
	{
		// Token: 0x0600244F RID: 9295 RVA: 0x0005D492 File Offset: 0x0005B692
		public CT_SampleData()
		{
			this.dataModelField = new global::NPOI.OpenXmlFormats.Dml.Diagram.CT_DataModel();
			this.useDefField = false;
		}

		// Token: 0x17000DA9 RID: 3497
		// (get) Token: 0x06002450 RID: 9296 RVA: 0x0005D4AC File Offset: 0x0005B6AC
		// (set) Token: 0x06002451 RID: 9297 RVA: 0x0005D4B4 File Offset: 0x0005B6B4
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.Diagram.CT_DataModel dataModel
		{
			get
			{
				return this.dataModelField;
			}
			set
			{
				this.dataModelField = value;
			}
		}

		// Token: 0x17000DAA RID: 3498
		// (get) Token: 0x06002452 RID: 9298 RVA: 0x0005D4BD File Offset: 0x0005B6BD
		// (set) Token: 0x06002453 RID: 9299 RVA: 0x0005D4C5 File Offset: 0x0005B6C5
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool useDef
		{
			get
			{
				return this.useDefField;
			}
			set
			{
				this.useDefField = value;
			}
		}

		// Token: 0x04001AD8 RID: 6872
		private global::NPOI.OpenXmlFormats.Dml.Diagram.CT_DataModel dataModelField;

		// Token: 0x04001AD9 RID: 6873
		private bool useDefField;
	}
}
