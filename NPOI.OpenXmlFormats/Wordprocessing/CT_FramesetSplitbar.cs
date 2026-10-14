using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200009D RID: 157
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_FramesetSplitbar
	{
		// Token: 0x06000455 RID: 1109 RVA: 0x0000CD2C File Offset: 0x0000AF2C
		public CT_FramesetSplitbar()
		{
			this.flatBordersField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff();
			this.noBorderField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff();
			this.colorField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Color();
			this.wField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TwipsMeasure();
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x0000CD60 File Offset: 0x0000AF60
		// (set) Token: 0x06000457 RID: 1111 RVA: 0x0000CD68 File Offset: 0x0000AF68
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TwipsMeasure w
		{
			get
			{
				return this.wField;
			}
			set
			{
				this.wField = value;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x0000CD71 File Offset: 0x0000AF71
		// (set) Token: 0x06000459 RID: 1113 RVA: 0x0000CD79 File Offset: 0x0000AF79
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Color color
		{
			get
			{
				return this.colorField;
			}
			set
			{
				this.colorField = value;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x0000CD82 File Offset: 0x0000AF82
		// (set) Token: 0x0600045B RID: 1115 RVA: 0x0000CD8A File Offset: 0x0000AF8A
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff noBorder
		{
			get
			{
				return this.noBorderField;
			}
			set
			{
				this.noBorderField = value;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x0600045C RID: 1116 RVA: 0x0000CD93 File Offset: 0x0000AF93
		// (set) Token: 0x0600045D RID: 1117 RVA: 0x0000CD9B File Offset: 0x0000AF9B
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff flatBorders
		{
			get
			{
				return this.flatBordersField;
			}
			set
			{
				this.flatBordersField = value;
			}
		}

		// Token: 0x040003C8 RID: 968
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TwipsMeasure wField;

		// Token: 0x040003C9 RID: 969
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Color colorField;

		// Token: 0x040003CA RID: 970
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff noBorderField;

		// Token: 0x040003CB RID: 971
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff flatBordersField;
	}
}
