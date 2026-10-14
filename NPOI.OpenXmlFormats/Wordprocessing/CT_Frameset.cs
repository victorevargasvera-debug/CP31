using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200009C RID: 156
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Frameset
	{
		// Token: 0x0600044C RID: 1100 RVA: 0x0000CCB3 File Offset: 0x0000AEB3
		public CT_Frameset()
		{
			this.itemsField = new object[0];
			this.frameLayoutField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_FrameLayout();
			this.framesetSplitbarField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_FramesetSplitbar();
			this.szField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_String();
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x0000CCE8 File Offset: 0x0000AEE8
		// (set) Token: 0x0600044E RID: 1102 RVA: 0x0000CCF0 File Offset: 0x0000AEF0
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_String sz
		{
			get
			{
				return this.szField;
			}
			set
			{
				this.szField = value;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x0000CCF9 File Offset: 0x0000AEF9
		// (set) Token: 0x06000450 RID: 1104 RVA: 0x0000CD01 File Offset: 0x0000AF01
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_FramesetSplitbar framesetSplitbar
		{
			get
			{
				return this.framesetSplitbarField;
			}
			set
			{
				this.framesetSplitbarField = value;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x0000CD0A File Offset: 0x0000AF0A
		// (set) Token: 0x06000452 RID: 1106 RVA: 0x0000CD12 File Offset: 0x0000AF12
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_FrameLayout frameLayout
		{
			get
			{
				return this.frameLayoutField;
			}
			set
			{
				this.frameLayoutField = value;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000453 RID: 1107 RVA: 0x0000CD1B File Offset: 0x0000AF1B
		// (set) Token: 0x06000454 RID: 1108 RVA: 0x0000CD23 File Offset: 0x0000AF23
		[global::System.Xml.Serialization.XmlElement("frame", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Frame), Order = 3)]
		[global::System.Xml.Serialization.XmlElement("frameset", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Frameset), Order = 3)]
		public object[] Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
			}
		}

		// Token: 0x040003C4 RID: 964
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_String szField;

		// Token: 0x040003C5 RID: 965
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_FramesetSplitbar framesetSplitbarField;

		// Token: 0x040003C6 RID: 966
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_FrameLayout frameLayoutField;

		// Token: 0x040003C7 RID: 967
		private object[] itemsField;
	}
}
