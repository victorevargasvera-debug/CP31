using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000246 RID: 582
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_AudioCD
	{
		// Token: 0x06001778 RID: 6008 RVA: 0x000431B6 File Offset: 0x000413B6
		public CT_AudioCD()
		{
			this.extLstField = new global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList();
			this.endField = new global::NPOI.OpenXmlFormats.Dml.CT_AudioCDTime();
			this.stField = new global::NPOI.OpenXmlFormats.Dml.CT_AudioCDTime();
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x06001779 RID: 6009 RVA: 0x000431DF File Offset: 0x000413DF
		// (set) Token: 0x0600177A RID: 6010 RVA: 0x000431E7 File Offset: 0x000413E7
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_AudioCDTime st
		{
			get
			{
				return this.stField;
			}
			set
			{
				this.stField = value;
			}
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x0600177B RID: 6011 RVA: 0x000431F0 File Offset: 0x000413F0
		// (set) Token: 0x0600177C RID: 6012 RVA: 0x000431F8 File Offset: 0x000413F8
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_AudioCDTime end
		{
			get
			{
				return this.endField;
			}
			set
			{
				this.endField = value;
			}
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x0600177D RID: 6013 RVA: 0x00043201 File Offset: 0x00041401
		// (set) Token: 0x0600177E RID: 6014 RVA: 0x00043209 File Offset: 0x00041409
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
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

		// Token: 0x04001242 RID: 4674
		private global::NPOI.OpenXmlFormats.Dml.CT_AudioCDTime stField;

		// Token: 0x04001243 RID: 4675
		private global::NPOI.OpenXmlFormats.Dml.CT_AudioCDTime endField;

		// Token: 0x04001244 RID: 4676
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;
	}
}
