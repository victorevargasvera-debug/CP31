using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000349 RID: 841
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot("themeOverride", Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = false)]
	[global::System.Serializable]
	public class CT_BaseStylesOverride
	{
		// Token: 0x06002120 RID: 8480 RVA: 0x0005748B File Offset: 0x0005568B
		public CT_BaseStylesOverride()
		{
			this.fmtSchemeField = new global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrix();
			this.fontSchemeField = new global::NPOI.OpenXmlFormats.Dml.CT_FontScheme();
			this.clrSchemeField = new global::NPOI.OpenXmlFormats.Dml.CT_ColorScheme();
		}

		// Token: 0x17000C7C RID: 3196
		// (get) Token: 0x06002121 RID: 8481 RVA: 0x000574B4 File Offset: 0x000556B4
		// (set) Token: 0x06002122 RID: 8482 RVA: 0x000574BC File Offset: 0x000556BC
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_ColorScheme clrScheme
		{
			get
			{
				return this.clrSchemeField;
			}
			set
			{
				this.clrSchemeField = value;
			}
		}

		// Token: 0x17000C7D RID: 3197
		// (get) Token: 0x06002123 RID: 8483 RVA: 0x000574C5 File Offset: 0x000556C5
		// (set) Token: 0x06002124 RID: 8484 RVA: 0x000574CD File Offset: 0x000556CD
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_FontScheme fontScheme
		{
			get
			{
				return this.fontSchemeField;
			}
			set
			{
				this.fontSchemeField = value;
			}
		}

		// Token: 0x17000C7E RID: 3198
		// (get) Token: 0x06002125 RID: 8485 RVA: 0x000574D6 File Offset: 0x000556D6
		// (set) Token: 0x06002126 RID: 8486 RVA: 0x000574DE File Offset: 0x000556DE
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrix fmtScheme
		{
			get
			{
				return this.fmtSchemeField;
			}
			set
			{
				this.fmtSchemeField = value;
			}
		}

		// Token: 0x04001976 RID: 6518
		private global::NPOI.OpenXmlFormats.Dml.CT_ColorScheme clrSchemeField;

		// Token: 0x04001977 RID: 6519
		private global::NPOI.OpenXmlFormats.Dml.CT_FontScheme fontSchemeField;

		// Token: 0x04001978 RID: 6520
		private global::NPOI.OpenXmlFormats.Dml.CT_StyleMatrix fmtSchemeField;
	}
}
