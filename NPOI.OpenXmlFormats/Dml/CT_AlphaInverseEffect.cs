using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000336 RID: 822
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_AlphaInverseEffect
	{
		// Token: 0x17000C48 RID: 3144
		// (get) Token: 0x0600209D RID: 8349 RVA: 0x00056421 File Offset: 0x00054621
		// (set) Token: 0x0600209E RID: 8350 RVA: 0x00056429 File Offset: 0x00054629
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
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

		// Token: 0x17000C49 RID: 3145
		// (get) Token: 0x0600209F RID: 8351 RVA: 0x00056432 File Offset: 0x00054632
		// (set) Token: 0x060020A0 RID: 8352 RVA: 0x0005643A File Offset: 0x0005463A
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
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

		// Token: 0x17000C4A RID: 3146
		// (get) Token: 0x060020A1 RID: 8353 RVA: 0x00056443 File Offset: 0x00054643
		// (set) Token: 0x060020A2 RID: 8354 RVA: 0x0005644B File Offset: 0x0005464B
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
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

		// Token: 0x17000C4B RID: 3147
		// (get) Token: 0x060020A3 RID: 8355 RVA: 0x00056454 File Offset: 0x00054654
		// (set) Token: 0x060020A4 RID: 8356 RVA: 0x0005645C File Offset: 0x0005465C
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
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

		// Token: 0x17000C4C RID: 3148
		// (get) Token: 0x060020A5 RID: 8357 RVA: 0x00056465 File Offset: 0x00054665
		// (set) Token: 0x060020A6 RID: 8358 RVA: 0x0005646D File Offset: 0x0005466D
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x17000C4D RID: 3149
		// (get) Token: 0x060020A7 RID: 8359 RVA: 0x00056476 File Offset: 0x00054676
		// (set) Token: 0x060020A8 RID: 8360 RVA: 0x0005647E File Offset: 0x0005467E
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
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

		// Token: 0x04001939 RID: 6457
		private global::NPOI.OpenXmlFormats.Dml.CT_ScRgbColor scrgbClrField;

		// Token: 0x0400193A RID: 6458
		private global::NPOI.OpenXmlFormats.Dml.CT_SRgbColor srgbClrField;

		// Token: 0x0400193B RID: 6459
		private global::NPOI.OpenXmlFormats.Dml.CT_HslColor hslClrField;

		// Token: 0x0400193C RID: 6460
		private global::NPOI.OpenXmlFormats.Dml.CT_SystemColor sysClrField;

		// Token: 0x0400193D RID: 6461
		private global::NPOI.OpenXmlFormats.Dml.CT_SchemeColor schemeClrField;

		// Token: 0x0400193E RID: 6462
		private global::NPOI.OpenXmlFormats.Dml.CT_PresetColor prstClrField;
	}
}
