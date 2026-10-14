using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000105 RID: 261
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Divs
	{
		// Token: 0x06000710 RID: 1808 RVA: 0x0001602C File Offset: 0x0001422C
		public CT_Divs()
		{
			this.divField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Div>();
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000711 RID: 1809 RVA: 0x0001603F File Offset: 0x0001423F
		// (set) Token: 0x06000712 RID: 1810 RVA: 0x00016047 File Offset: 0x00014247
		[global::System.Xml.Serialization.XmlElement("div", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Div> div
		{
			get
			{
				return this.divField;
			}
			set
			{
				this.divField = value;
			}
		}

		// Token: 0x04000646 RID: 1606
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Div> divField;
	}
}
