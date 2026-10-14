using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002BF RID: 703
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Scale2D
	{
		// Token: 0x06001BDF RID: 7135 RVA: 0x0004CD69 File Offset: 0x0004AF69
		public CT_Scale2D()
		{
			this.syField = new global::NPOI.OpenXmlFormats.Dml.CT_Ratio();
			this.sxField = new global::NPOI.OpenXmlFormats.Dml.CT_Ratio();
		}

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x06001BE0 RID: 7136 RVA: 0x0004CD87 File Offset: 0x0004AF87
		// (set) Token: 0x06001BE1 RID: 7137 RVA: 0x0004CD8F File Offset: 0x0004AF8F
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Ratio sx
		{
			get
			{
				return this.sxField;
			}
			set
			{
				this.sxField = value;
			}
		}

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x06001BE2 RID: 7138 RVA: 0x0004CD98 File Offset: 0x0004AF98
		// (set) Token: 0x06001BE3 RID: 7139 RVA: 0x0004CDA0 File Offset: 0x0004AFA0
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Ratio sy
		{
			get
			{
				return this.syField;
			}
			set
			{
				this.syField = value;
			}
		}

		// Token: 0x040015E0 RID: 5600
		private global::NPOI.OpenXmlFormats.Dml.CT_Ratio sxField;

		// Token: 0x040015E1 RID: 5601
		private global::NPOI.OpenXmlFormats.Dml.CT_Ratio syField;
	}
}
