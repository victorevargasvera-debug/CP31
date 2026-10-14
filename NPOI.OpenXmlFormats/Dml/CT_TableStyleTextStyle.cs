using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000253 RID: 595
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TableStyleTextStyle
	{
		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06001819 RID: 6169 RVA: 0x0004380E File Offset: 0x00041A0E
		// (set) Token: 0x0600181A RID: 6170 RVA: 0x00043816 File Offset: 0x00041A16
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_FontCollection font
		{
			get
			{
				return this.fontField;
			}
			set
			{
				this.fontField = value;
			}
		}

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x0600181B RID: 6171 RVA: 0x0004381F File Offset: 0x00041A1F
		// (set) Token: 0x0600181C RID: 6172 RVA: 0x00043827 File Offset: 0x00041A27
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_FontReference fontRef
		{
			get
			{
				return this.fontRefField;
			}
			set
			{
				this.fontRefField = value;
			}
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x0600181D RID: 6173 RVA: 0x00043830 File Offset: 0x00041A30
		// (set) Token: 0x0600181E RID: 6174 RVA: 0x00043838 File Offset: 0x00041A38
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.CT_ScRgbColor scrgbClr
		{
			get
			{
				return this.scrgbClrField;
			}
			set
			{
				this.scrgbClrField = value;
			}
		}

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x0600181F RID: 6175 RVA: 0x00043841 File Offset: 0x00041A41
		// (set) Token: 0x06001820 RID: 6176 RVA: 0x00043849 File Offset: 0x00041A49
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.CT_SRgbColor srgbClr
		{
			get
			{
				return this.srgbClrField;
			}
			set
			{
				this.srgbClrField = value;
			}
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06001821 RID: 6177 RVA: 0x00043852 File Offset: 0x00041A52
		// (set) Token: 0x06001822 RID: 6178 RVA: 0x0004385A File Offset: 0x00041A5A
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Dml.CT_HslColor hslClr
		{
			get
			{
				return this.hslClrField;
			}
			set
			{
				this.hslClrField = value;
			}
		}

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x06001823 RID: 6179 RVA: 0x00043863 File Offset: 0x00041A63
		// (set) Token: 0x06001824 RID: 6180 RVA: 0x0004386B File Offset: 0x00041A6B
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Dml.CT_SystemColor sysClr
		{
			get
			{
				return this.sysClrField;
			}
			set
			{
				this.sysClrField = value;
			}
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x06001825 RID: 6181 RVA: 0x00043874 File Offset: 0x00041A74
		// (set) Token: 0x06001826 RID: 6182 RVA: 0x0004387C File Offset: 0x00041A7C
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
		public global::NPOI.OpenXmlFormats.Dml.CT_SchemeColor schemeClr
		{
			get
			{
				return this.schemeClrField;
			}
			set
			{
				this.schemeClrField = value;
			}
		}

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x06001827 RID: 6183 RVA: 0x00043885 File Offset: 0x00041A85
		// (set) Token: 0x06001828 RID: 6184 RVA: 0x0004388D File Offset: 0x00041A8D
		[global::System.Xml.Serialization.XmlElement(Order = 7)]
		public global::NPOI.OpenXmlFormats.Dml.CT_PresetColor prstClr
		{
			get
			{
				return this.prstClrField;
			}
			set
			{
				this.prstClrField = value;
			}
		}

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06001829 RID: 6185 RVA: 0x00043896 File Offset: 0x00041A96
		// (set) Token: 0x0600182A RID: 6186 RVA: 0x0004389E File Offset: 0x00041A9E
		[global::System.Xml.Serialization.XmlElement(Order = 8)]
		public global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLst
		{
			get
			{
				return this.extLstField;
			}
			set
			{
				this.extLstField = value;
			}
		}

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x0600182B RID: 6187 RVA: 0x000438A7 File Offset: 0x00041AA7
		// (set) Token: 0x0600182C RID: 6188 RVA: 0x000438AF File Offset: 0x00041AAF
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Dml.ST_OnOffStyleType.def)]
		public global::NPOI.OpenXmlFormats.Dml.ST_OnOffStyleType b
		{
			get
			{
				return this.bField;
			}
			set
			{
				this.bField = value;
			}
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x0600182D RID: 6189 RVA: 0x000438B8 File Offset: 0x00041AB8
		// (set) Token: 0x0600182E RID: 6190 RVA: 0x000438C0 File Offset: 0x00041AC0
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Dml.ST_OnOffStyleType.def)]
		public global::NPOI.OpenXmlFormats.Dml.ST_OnOffStyleType i
		{
			get
			{
				return this.iField;
			}
			set
			{
				this.iField = value;
			}
		}

		// Token: 0x04001290 RID: 4752
		private global::NPOI.OpenXmlFormats.Dml.CT_FontCollection fontField;

		// Token: 0x04001291 RID: 4753
		private global::NPOI.OpenXmlFormats.Dml.CT_FontReference fontRefField;

		// Token: 0x04001292 RID: 4754
		private global::NPOI.OpenXmlFormats.Dml.CT_ScRgbColor scrgbClrField;

		// Token: 0x04001293 RID: 4755
		private global::NPOI.OpenXmlFormats.Dml.CT_SRgbColor srgbClrField;

		// Token: 0x04001294 RID: 4756
		private global::NPOI.OpenXmlFormats.Dml.CT_HslColor hslClrField;

		// Token: 0x04001295 RID: 4757
		private global::NPOI.OpenXmlFormats.Dml.CT_SystemColor sysClrField;

		// Token: 0x04001296 RID: 4758
		private global::NPOI.OpenXmlFormats.Dml.CT_SchemeColor schemeClrField;

		// Token: 0x04001297 RID: 4759
		private global::NPOI.OpenXmlFormats.Dml.CT_PresetColor prstClrField;

		// Token: 0x04001298 RID: 4760
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x04001299 RID: 4761
		private global::NPOI.OpenXmlFormats.Dml.ST_OnOffStyleType bField;

		// Token: 0x0400129A RID: 4762
		private global::NPOI.OpenXmlFormats.Dml.ST_OnOffStyleType iField;
	}
}
