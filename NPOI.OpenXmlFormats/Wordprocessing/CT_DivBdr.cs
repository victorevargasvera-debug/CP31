using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000107 RID: 263
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DivBdr
	{
		// Token: 0x06000726 RID: 1830 RVA: 0x00016154 File Offset: 0x00014354
		public CT_DivBdr()
		{
			this.rightField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border();
			this.bottomField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border();
			this.leftField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border();
			this.topField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border();
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000727 RID: 1831 RVA: 0x00016188 File Offset: 0x00014388
		// (set) Token: 0x06000728 RID: 1832 RVA: 0x00016190 File Offset: 0x00014390
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border top
		{
			get
			{
				return this.topField;
			}
			set
			{
				this.topField = value;
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000729 RID: 1833 RVA: 0x00016199 File Offset: 0x00014399
		// (set) Token: 0x0600072A RID: 1834 RVA: 0x000161A1 File Offset: 0x000143A1
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border left
		{
			get
			{
				return this.leftField;
			}
			set
			{
				this.leftField = value;
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x0600072B RID: 1835 RVA: 0x000161AA File Offset: 0x000143AA
		// (set) Token: 0x0600072C RID: 1836 RVA: 0x000161B2 File Offset: 0x000143B2
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border bottom
		{
			get
			{
				return this.bottomField;
			}
			set
			{
				this.bottomField = value;
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x0600072D RID: 1837 RVA: 0x000161BB File Offset: 0x000143BB
		// (set) Token: 0x0600072E RID: 1838 RVA: 0x000161C3 File Offset: 0x000143C3
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border right
		{
			get
			{
				return this.rightField;
			}
			set
			{
				this.rightField = value;
			}
		}

		// Token: 0x04000650 RID: 1616
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border topField;

		// Token: 0x04000651 RID: 1617
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border leftField;

		// Token: 0x04000652 RID: 1618
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border bottomField;

		// Token: 0x04000653 RID: 1619
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border rightField;
	}
}
