using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x02000394 RID: 916
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Parameter
	{
		// Token: 0x17000DB4 RID: 3508
		// (get) Token: 0x06002468 RID: 9320 RVA: 0x0005D5BC File Offset: 0x0005B7BC
		// (set) Token: 0x06002469 RID: 9321 RVA: 0x0005D5C4 File Offset: 0x0005B7C4
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ParameterId type
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

		// Token: 0x17000DB5 RID: 3509
		// (get) Token: 0x0600246A RID: 9322 RVA: 0x0005D5CD File Offset: 0x0005B7CD
		// (set) Token: 0x0600246B RID: 9323 RVA: 0x0005D5D5 File Offset: 0x0005B7D5
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

		// Token: 0x04001AE3 RID: 6883
		private global::NPOI.OpenXmlFormats.Dml.Diagram.ST_ParameterId typeField;

		// Token: 0x04001AE4 RID: 6884
		private string valField;
	}
}
