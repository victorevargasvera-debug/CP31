using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x0200032F RID: 815
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ColorReplaceEffect
	{
		// Token: 0x17000C38 RID: 3128
		// (get) Token: 0x06002072 RID: 8306 RVA: 0x00056115 File Offset: 0x00054315
		// (set) Token: 0x06002073 RID: 8307 RVA: 0x0005611D File Offset: 0x0005431D
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

		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x06002074 RID: 8308 RVA: 0x00056126 File Offset: 0x00054326
		// (set) Token: 0x06002075 RID: 8309 RVA: 0x0005612E File Offset: 0x0005432E
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

		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x06002076 RID: 8310 RVA: 0x00056137 File Offset: 0x00054337
		// (set) Token: 0x06002077 RID: 8311 RVA: 0x0005613F File Offset: 0x0005433F
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

		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x06002078 RID: 8312 RVA: 0x00056148 File Offset: 0x00054348
		// (set) Token: 0x06002079 RID: 8313 RVA: 0x00056150 File Offset: 0x00054350
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

		// Token: 0x17000C3C RID: 3132
		// (get) Token: 0x0600207A RID: 8314 RVA: 0x00056159 File Offset: 0x00054359
		// (set) Token: 0x0600207B RID: 8315 RVA: 0x00056161 File Offset: 0x00054361
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

		// Token: 0x17000C3D RID: 3133
		// (get) Token: 0x0600207C RID: 8316 RVA: 0x0005616A File Offset: 0x0005436A
		// (set) Token: 0x0600207D RID: 8317 RVA: 0x00056172 File Offset: 0x00054372
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

		// Token: 0x04001929 RID: 6441
		private global::NPOI.OpenXmlFormats.Dml.CT_ScRgbColor scrgbClrField;

		// Token: 0x0400192A RID: 6442
		private global::NPOI.OpenXmlFormats.Dml.CT_SRgbColor srgbClrField;

		// Token: 0x0400192B RID: 6443
		private global::NPOI.OpenXmlFormats.Dml.CT_HslColor hslClrField;

		// Token: 0x0400192C RID: 6444
		private global::NPOI.OpenXmlFormats.Dml.CT_SystemColor sysClrField;

		// Token: 0x0400192D RID: 6445
		private global::NPOI.OpenXmlFormats.Dml.CT_SchemeColor schemeClrField;

		// Token: 0x0400192E RID: 6446
		private global::NPOI.OpenXmlFormats.Dml.CT_PresetColor prstClrField;
	}
}
