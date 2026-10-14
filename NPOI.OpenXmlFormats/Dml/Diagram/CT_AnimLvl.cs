using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Diagram
{
	// Token: 0x020003BB RID: 955
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/diagram", IsNullable = true)]
	[global::System.Serializable]
	public class CT_AnimLvl
	{
		// Token: 0x060025AC RID: 9644 RVA: 0x0005E5EB File Offset: 0x0005C7EB
		public CT_AnimLvl()
		{
			this.valField = global::NPOI.OpenXmlFormats.Dml.Diagram.ST_AnimLvlStr.none;
		}

		// Token: 0x17000E49 RID: 3657
		// (get) Token: 0x060025AD RID: 9645 RVA: 0x0005E5FA File Offset: 0x0005C7FA
		// (set) Token: 0x060025AE RID: 9646 RVA: 0x0005E602 File Offset: 0x0005C802
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Dml.Diagram.ST_AnimLvlStr.none)]
		public global::NPOI.OpenXmlFormats.Dml.Diagram.ST_AnimLvlStr val
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

		// Token: 0x04001C3E RID: 7230
		private global::NPOI.OpenXmlFormats.Dml.Diagram.ST_AnimLvlStr valField;
	}
}
