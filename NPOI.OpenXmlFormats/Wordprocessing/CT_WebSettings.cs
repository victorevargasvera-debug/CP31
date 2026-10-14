using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200019F RID: 415
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot("webSettings", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = false)]
	[global::System.Serializable]
	public class CT_WebSettings
	{
		// Token: 0x06000F99 RID: 3993 RVA: 0x00032B38 File Offset: 0x00030D38
		public CT_WebSettings()
		{
			this.allowPNGField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff();
			this.optimizeForBrowserField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff();
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06000F9A RID: 3994 RVA: 0x00032B56 File Offset: 0x00030D56
		// (set) Token: 0x06000F9B RID: 3995 RVA: 0x00032B5E File Offset: 0x00030D5E
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Frameset frameset
		{
			get
			{
				return this.framesetField;
			}
			set
			{
				this.framesetField = value;
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06000F9C RID: 3996 RVA: 0x00032B67 File Offset: 0x00030D67
		// (set) Token: 0x06000F9D RID: 3997 RVA: 0x00032B6F File Offset: 0x00030D6F
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Divs divs
		{
			get
			{
				return this.divsField;
			}
			set
			{
				this.divsField = value;
			}
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06000F9E RID: 3998 RVA: 0x00032B78 File Offset: 0x00030D78
		// (set) Token: 0x06000F9F RID: 3999 RVA: 0x00032B80 File Offset: 0x00030D80
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_String encoding
		{
			get
			{
				return this.encodingField;
			}
			set
			{
				this.encodingField = value;
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06000FA0 RID: 4000 RVA: 0x00032B89 File Offset: 0x00030D89
		// (set) Token: 0x06000FA1 RID: 4001 RVA: 0x00032B91 File Offset: 0x00030D91
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff optimizeForBrowser
		{
			get
			{
				return this.optimizeForBrowserField;
			}
			set
			{
				this.optimizeForBrowserField = value;
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06000FA2 RID: 4002 RVA: 0x00032B9A File Offset: 0x00030D9A
		// (set) Token: 0x06000FA3 RID: 4003 RVA: 0x00032BA2 File Offset: 0x00030DA2
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff relyOnVML
		{
			get
			{
				return this.relyOnVMLField;
			}
			set
			{
				this.relyOnVMLField = value;
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06000FA4 RID: 4004 RVA: 0x00032BAB File Offset: 0x00030DAB
		// (set) Token: 0x06000FA5 RID: 4005 RVA: 0x00032BB3 File Offset: 0x00030DB3
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff allowPNG
		{
			get
			{
				return this.allowPNGField;
			}
			set
			{
				this.allowPNGField = value;
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06000FA6 RID: 4006 RVA: 0x00032BBC File Offset: 0x00030DBC
		// (set) Token: 0x06000FA7 RID: 4007 RVA: 0x00032BC4 File Offset: 0x00030DC4
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotRelyOnCSS
		{
			get
			{
				return this.doNotRelyOnCSSField;
			}
			set
			{
				this.doNotRelyOnCSSField = value;
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06000FA8 RID: 4008 RVA: 0x00032BCD File Offset: 0x00030DCD
		// (set) Token: 0x06000FA9 RID: 4009 RVA: 0x00032BD5 File Offset: 0x00030DD5
		[global::System.Xml.Serialization.XmlElement(Order = 7)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotSaveAsSingleFile
		{
			get
			{
				return this.doNotSaveAsSingleFileField;
			}
			set
			{
				this.doNotSaveAsSingleFileField = value;
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06000FAA RID: 4010 RVA: 0x00032BDE File Offset: 0x00030DDE
		// (set) Token: 0x06000FAB RID: 4011 RVA: 0x00032BE6 File Offset: 0x00030DE6
		[global::System.Xml.Serialization.XmlElement(Order = 8)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotOrganizeInFolder
		{
			get
			{
				return this.doNotOrganizeInFolderField;
			}
			set
			{
				this.doNotOrganizeInFolderField = value;
			}
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06000FAC RID: 4012 RVA: 0x00032BEF File Offset: 0x00030DEF
		// (set) Token: 0x06000FAD RID: 4013 RVA: 0x00032BF7 File Offset: 0x00030DF7
		[global::System.Xml.Serialization.XmlElement(Order = 9)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotUseLongFileNames
		{
			get
			{
				return this.doNotUseLongFileNamesField;
			}
			set
			{
				this.doNotUseLongFileNamesField = value;
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06000FAE RID: 4014 RVA: 0x00032C00 File Offset: 0x00030E00
		// (set) Token: 0x06000FAF RID: 4015 RVA: 0x00032C08 File Offset: 0x00030E08
		[global::System.Xml.Serialization.XmlElement(Order = 10)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber pixelsPerInch
		{
			get
			{
				return this.pixelsPerInchField;
			}
			set
			{
				this.pixelsPerInchField = value;
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06000FB0 RID: 4016 RVA: 0x00032C11 File Offset: 0x00030E11
		// (set) Token: 0x06000FB1 RID: 4017 RVA: 0x00032C19 File Offset: 0x00030E19
		[global::System.Xml.Serialization.XmlElement(Order = 11)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TargetScreenSz targetScreenSz
		{
			get
			{
				return this.targetScreenSzField;
			}
			set
			{
				this.targetScreenSzField = value;
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06000FB2 RID: 4018 RVA: 0x00032C22 File Offset: 0x00030E22
		// (set) Token: 0x06000FB3 RID: 4019 RVA: 0x00032C2A File Offset: 0x00030E2A
		[global::System.Xml.Serialization.XmlElement(Order = 12)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff saveSmartTagsAsXml
		{
			get
			{
				return this.saveSmartTagsAsXmlField;
			}
			set
			{
				this.saveSmartTagsAsXmlField = value;
			}
		}

		// Token: 0x04000CAE RID: 3246
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Frameset framesetField;

		// Token: 0x04000CAF RID: 3247
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Divs divsField;

		// Token: 0x04000CB0 RID: 3248
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_String encodingField;

		// Token: 0x04000CB1 RID: 3249
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff optimizeForBrowserField;

		// Token: 0x04000CB2 RID: 3250
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff relyOnVMLField;

		// Token: 0x04000CB3 RID: 3251
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff allowPNGField;

		// Token: 0x04000CB4 RID: 3252
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotRelyOnCSSField;

		// Token: 0x04000CB5 RID: 3253
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotSaveAsSingleFileField;

		// Token: 0x04000CB6 RID: 3254
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotOrganizeInFolderField;

		// Token: 0x04000CB7 RID: 3255
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff doNotUseLongFileNamesField;

		// Token: 0x04000CB8 RID: 3256
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber pixelsPerInchField;

		// Token: 0x04000CB9 RID: 3257
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TargetScreenSz targetScreenSzField;

		// Token: 0x04000CBA RID: 3258
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff saveSmartTagsAsXmlField;
	}
}
