using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000429 RID: 1065
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_BuiltInUnit
	{
		// Token: 0x06002AA2 RID: 10914 RVA: 0x0006B1C6 File Offset: 0x000693C6
		public CT_BuiltInUnit()
		{
			this.valField = global::NPOI.OpenXmlFormats.Dml.Chart.ST_BuiltInUnit.thousands;
		}

		// Token: 0x17001011 RID: 4113
		// (get) Token: 0x06002AA3 RID: 10915 RVA: 0x0006B1D5 File Offset: 0x000693D5
		// (set) Token: 0x06002AA4 RID: 10916 RVA: 0x0006B1DD File Offset: 0x000693DD
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Dml.Chart.ST_BuiltInUnit.thousands)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.ST_BuiltInUnit val
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

		// Token: 0x04001E58 RID: 7768
		private global::NPOI.OpenXmlFormats.Dml.Chart.ST_BuiltInUnit valField;
	}
}
