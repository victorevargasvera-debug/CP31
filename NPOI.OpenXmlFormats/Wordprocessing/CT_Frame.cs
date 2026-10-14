using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000A0 RID: 160
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Frame
	{
		// Token: 0x06000461 RID: 1121 RVA: 0x0000CDB8 File Offset: 0x0000AFB8
		public CT_Frame()
		{
			this.linkedToFileField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff();
			this.noResizeAllowedField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff();
			this.scrollbarField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_FrameScrollbar();
			this.marHField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_PixelsMeasure();
			this.marWField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_PixelsMeasure();
			this.sourceFileNameField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Rel();
			this.nameField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_String();
			this.szField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_String();
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000462 RID: 1122 RVA: 0x0000CE23 File Offset: 0x0000B023
		// (set) Token: 0x06000463 RID: 1123 RVA: 0x0000CE2B File Offset: 0x0000B02B
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

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x0000CE34 File Offset: 0x0000B034
		// (set) Token: 0x06000465 RID: 1125 RVA: 0x0000CE3C File Offset: 0x0000B03C
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_String name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x0000CE45 File Offset: 0x0000B045
		// (set) Token: 0x06000467 RID: 1127 RVA: 0x0000CE4D File Offset: 0x0000B04D
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Rel sourceFileName
		{
			get
			{
				return this.sourceFileNameField;
			}
			set
			{
				this.sourceFileNameField = value;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x0000CE56 File Offset: 0x0000B056
		// (set) Token: 0x06000469 RID: 1129 RVA: 0x0000CE5E File Offset: 0x0000B05E
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_PixelsMeasure marW
		{
			get
			{
				return this.marWField;
			}
			set
			{
				this.marWField = value;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x0000CE67 File Offset: 0x0000B067
		// (set) Token: 0x0600046B RID: 1131 RVA: 0x0000CE6F File Offset: 0x0000B06F
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_PixelsMeasure marH
		{
			get
			{
				return this.marHField;
			}
			set
			{
				this.marHField = value;
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x0000CE78 File Offset: 0x0000B078
		// (set) Token: 0x0600046D RID: 1133 RVA: 0x0000CE80 File Offset: 0x0000B080
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_FrameScrollbar scrollbar
		{
			get
			{
				return this.scrollbarField;
			}
			set
			{
				this.scrollbarField = value;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x0000CE89 File Offset: 0x0000B089
		// (set) Token: 0x0600046F RID: 1135 RVA: 0x0000CE91 File Offset: 0x0000B091
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff noResizeAllowed
		{
			get
			{
				return this.noResizeAllowedField;
			}
			set
			{
				this.noResizeAllowedField = value;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x0000CE9A File Offset: 0x0000B09A
		// (set) Token: 0x06000471 RID: 1137 RVA: 0x0000CEA2 File Offset: 0x0000B0A2
		[global::System.Xml.Serialization.XmlElement(Order = 7)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff linkedToFile
		{
			get
			{
				return this.linkedToFileField;
			}
			set
			{
				this.linkedToFileField = value;
			}
		}

		// Token: 0x040003D1 RID: 977
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_String szField;

		// Token: 0x040003D2 RID: 978
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_String nameField;

		// Token: 0x040003D3 RID: 979
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Rel sourceFileNameField;

		// Token: 0x040003D4 RID: 980
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_PixelsMeasure marWField;

		// Token: 0x040003D5 RID: 981
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_PixelsMeasure marHField;

		// Token: 0x040003D6 RID: 982
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_FrameScrollbar scrollbarField;

		// Token: 0x040003D7 RID: 983
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff noResizeAllowedField;

		// Token: 0x040003D8 RID: 984
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff linkedToFileField;
	}
}
