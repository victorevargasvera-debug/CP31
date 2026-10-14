using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020001A6 RID: 422
	[global::System.Xml.Serialization.XmlInclude(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblGrid))]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TblGridBase
	{
		// Token: 0x06000FE7 RID: 4071 RVA: 0x00034373 File Offset: 0x00032573
		public CT_TblGridBase()
		{
			this.gridColField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblGridCol>();
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06000FE8 RID: 4072 RVA: 0x00034386 File Offset: 0x00032586
		// (set) Token: 0x06000FE9 RID: 4073 RVA: 0x0003438E File Offset: 0x0003258E
		[global::System.Xml.Serialization.XmlElement("gridCol", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblGridCol> gridCol
		{
			get
			{
				return this.gridColField;
			}
			set
			{
				this.gridColField = value;
			}
		}

		// Token: 0x04000CD7 RID: 3287
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblGridCol> gridColField;
	}
}
